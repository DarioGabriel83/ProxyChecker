using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ProxyChecker
{
    public partial class Form1 : Form
    {
        IPInfo MyIPInfo = new IPInfo();
        Functions Functions = new Functions();
        int threads = 0;
        int MaxThreads = 5;
        int currentline = 0;

        private ListViewColumnSorter lvwColumnSorter;
        public Form1()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listViewProxyList.ListViewItemSorter = lvwColumnSorter;
        }





        bool CheckProxy(string IP, int Port)
        {
            System.Diagnostics.Stopwatch timer = new Stopwatch();
            timer.Start();
            try
            {
                IWebProxy proxy = new WebProxy(IP, Port);
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://ip-api.com/xml/");
                myWebRequest.Timeout = 10000;
                myWebRequest.Proxy = proxy;
                WebResponse response = myWebRequest.GetResponse();
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    response.Close();
                    timer.Stop();

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(responseFromServer);

                    ListViewItem Item = new ListViewItem();
                    if (((XmlNode)doc.DocumentElement.SelectSingleNode("query")).InnerText == IP)
                    {
                        //Item.SubItems.Add(((XmlNode)doc.DocumentElement.SelectSingleNode("query")).InnerText);
                        Item.Text = ((XmlNode)doc.DocumentElement.SelectSingleNode("query")).InnerText;
                    }
                    else
                    {
                        //Item.SubItems.Add(IP);
                        Item.Text = IP;
                    }
                    Item.SubItems.Add(Port.ToString());
                    Item.SubItems.Add(timer.Elapsed.TotalMilliseconds.ToString());
                    Item.SubItems.Add(Boolean.TrueString);
                    Item.SubItems.Add(((XmlNode)doc.DocumentElement.SelectSingleNode("countryCode")).InnerText);
                    Item.SubItems.Add(((XmlNode)doc.DocumentElement.SelectSingleNode("regionName")).InnerText);
                    Item.SubItems.Add(((XmlNode)doc.DocumentElement.SelectSingleNode("city")).InnerText);
                    //if (!string.IsNullOrWhiteSpace(doc.DocumentElement.SelectSingleNode("zip").InnerText))
                    Item.SubItems.Add(" " + ((XmlNode)doc.DocumentElement.SelectSingleNode("zip")).InnerText);// else Item.SubItems.Add("0");
                    Item.SubItems.Add(((XmlNode)doc.DocumentElement.SelectSingleNode("lat")).InnerText + ", " + ((XmlNode)doc.DocumentElement.SelectSingleNode("lon")).InnerText);
                    Item.SubItems.Add(((XmlNode)doc.DocumentElement.SelectSingleNode("timezone")).InnerText);
                    Item.SubItems.Add(((XmlNode)doc.DocumentElement.SelectSingleNode("isp")).InnerText);
                    Item.SubItems.Add(((XmlNode)doc.DocumentElement.SelectSingleNode("org")).InnerText);

                    FormControlHelper.ControlInvoke(listViewProxyList, () => listViewProxyList.Items.Add(Item));

                    if (String.IsNullOrWhiteSpace(responseFromServer))
                    {
                        Item.BackColor = Color.Red;
                        return false;
                    }
                    else
                    {
                        if (timer.Elapsed.TotalMilliseconds < 3000) Item.BackColor = Color.LightGreen;
                        else if ((timer.Elapsed.TotalMilliseconds > 3000) && (timer.Elapsed.TotalMilliseconds < 6000)) Item.BackColor = Color.Yellow;
                        else if ((timer.Elapsed.TotalMilliseconds > 6000) && (timer.Elapsed.TotalMilliseconds < 8000)) Item.BackColor = Color.Orange;
                        else if (timer.Elapsed.TotalMilliseconds > 8000) Item.BackColor = Color.DarkOrange;
                        return true;
                    }
                }
            }
            catch
            {
                timer.Stop();
                ListViewItem Item = new ListViewItem();
                Item.Text = IP.ToString();
                Item.SubItems.Add(Port.ToString());
                //Item.SubItems.Add("Dead or timeout");
                Item.SubItems.Add(timer.Elapsed.TotalMilliseconds.ToString());
                Item.SubItems.Add(Boolean.FalseString);
                Item.SubItems.Add("");
                Item.SubItems.Add("");
                Item.SubItems.Add("");
                Item.SubItems.Add("");
                Item.SubItems.Add("");
                Item.SubItems.Add("");
                Item.SubItems.Add("");
                Item.SubItems.Add("");
                Item.BackColor = Color.Red;
                FormControlHelper.ControlInvoke(listViewProxyList, () => listViewProxyList.Items.Add(Item));
                return false;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            //bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerAsync();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((IPAddress.TryParse(textBoxProxyIP.Text, out IPAddress address)) && (int.TryParse(textBoxProxyPort.Text, out int i)))
            {
                FormControlHelper.ControlInvoke(listViewProxyList, () =>
                    {
                        if (!ProxyMatches(listViewProxyList, textBoxProxyIP.Text, textBoxProxyPort.Text))
                            CheckProxy(textBoxProxyIP.Text, Convert.ToInt32(textBoxProxyPort.Text));
                    });
            }
        }



        private void TextBoxProxyIP_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProxyIP.Text.Contains(':'))
            {
                textBoxProxyPort.Text = textBoxProxyIP.Text.Split(':')[1];
                textBoxProxyIP.Text = textBoxProxyIP.Text.Split(':')[0];
            }
            if (textBoxProxyIP.Text.Contains('\t'))
            {
                textBoxProxyPort.Text = textBoxProxyIP.Text.Split('\t')[1];
                textBoxProxyIP.Text = textBoxProxyIP.Text.Split('\t')[0];
            }
        }

        private void ListViewProxyList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listViewProxyList.Sort();
        }

        private void TrackBarMaxThreads_Scroll(object sender, EventArgs e)
        {
            MaxThreads = trackBarMaxThreads.Value;
            label1.Text = "Max threads: " + MaxThreads.ToString();
        }

        private void TextBoxProxyPort_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProxyPort.Text.Contains(':'))
            {
                textBoxProxyIP.Text = textBoxProxyPort.Text.Split(':')[0];
                textBoxProxyPort.Text = textBoxProxyPort.Text.Split(':')[1];
            }
            if (textBoxProxyPort.Text.Contains('\t'))
            {
                textBoxProxyIP.Text = textBoxProxyPort.Text.Split('\t')[0];
                textBoxProxyPort.Text = textBoxProxyPort.Text.Split('\t')[1];
            }
        }


        private void ButtonTestList_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Clear the list?", "Proxy list", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                listViewProxyList.Items.Clear();
            }
            listViewProxyList.Update();
            CleanList();

            threads = 0;
            currentline = 0;
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            //bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.DoWork += new DoWorkEventHandler(bw_StartProxyList);
            bw.RunWorkerAsync();
        }

        void bw_StartProxyList(object sender, DoWorkEventArgs e)
        {
            FormControlHelper.ControlInvoke(textBoxProxyList, () => textBoxProxyList.Enabled = false);

            string[] tokens = Regex.Split(textBoxProxyList.Text, @"\r?\n|\r");

            int lines = tokens.Length;
            int linesCounter = 0;
            threads = 1;

            FormControlHelper.ControlInvoke(progressBar, () => progressBar.Maximum = lines);
            while ((threads > 0) && (linesCounter <= lines))
            {
                if (threads < MaxThreads)
                {
                    BackgroundWorker bw = new BackgroundWorker();
                    bw.WorkerReportsProgress = true;
                    //bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
                    bw.DoWork += new DoWorkEventHandler(bw_DoList);
                    bw.RunWorkerAsync();
                    linesCounter++;
                    threads++;
                }
            }
        }

        void bw_DoList(object sender, DoWorkEventArgs e)
        {
            string[] tokens = Regex.Split(textBoxProxyList.Text, @"\r?\n|\r");
            if ((tokens.Length > currentline) && (!string.IsNullOrEmpty(tokens[currentline])))
            {
                string ProxyIP = Regex.Split(tokens[currentline].Replace("http://", ""), @":|\t")[0];
                string ProxyPort = Regex.Split(tokens[currentline].Replace("http://", ""), @":|\t")[1];
                currentline++;
                FormControlHelper.ControlInvoke(progressBar, () => progressBar.Value = currentline - 1);
                if ((IPAddress.TryParse(ProxyIP, out _)) && (int.TryParse(ProxyPort, out int i)))
                {

                    /*FormControlHelper.ControlInvoke(listViewProxyList, () =>
                    {
                        if (!ProxyMatches(listViewProxyList, ProxyIP, ProxyPort)) CheckProxy(ProxyIP, i);
                    });*/
                    if (!ProxyMatches(listViewProxyList, ProxyIP, ProxyPort))
                        CheckProxy(ProxyIP, i);
                }
            }
            else currentline++;
            threads--;

            if (threads <= 1)
            {
                FormControlHelper.ControlInvoke(textBoxProxyList, () => textBoxProxyList.Enabled = true);
                FormControlHelper.ControlInvoke(progressBar, () => progressBar.Value = 0);
            }

        }

        void LoadMyIPInfo()
        {
            MyIPInfo = Functions.GetMyIPInfo();

            if (MyIPInfo != null)
            {
                //Font OriginalFont = richTextBoxIPInfo.Font;

                richTextBoxIPInfo.Text = "";
                richTextBoxIPInfo.DeselectAll();
                richTextBoxIPInfo.SelectionAlignment = HorizontalAlignment.Center;
                richTextBoxIPInfo.SelectionFont = new Font("Arial", 7, FontStyle.Bold);
                richTextBoxIPInfo.SelectionColor = Color.Red;
                richTextBoxIPInfo.AppendText("Current IP: ");
                //richTextBoxIPInfo.SelectionFont = OriginalFont;
                richTextBoxIPInfo.SelectionColor = Color.DarkGreen;
                richTextBoxIPInfo.AppendText(MyIPInfo.IP.ToString() + " (" + MyIPInfo.Country + ", " + MyIPInfo.RegionName + ")"); ;

                richTextBoxIPInfo.SelectionFont = new Font("Arial", 7, FontStyle.Bold);
                richTextBoxIPInfo.SelectionColor = Color.Red;
                richTextBoxIPInfo.AppendText("\tLat/Long: ");
                //richTextBoxIPInfo.SelectionFont = OriginalFont;
                richTextBoxIPInfo.SelectionColor = Color.DarkGreen;
                richTextBoxIPInfo.AppendText(MyIPInfo.Latitude + "," + MyIPInfo.Longitude);

                richTextBoxIPInfo.SelectionFont = new Font("Arial", 7, FontStyle.Bold);
                richTextBoxIPInfo.SelectionColor = Color.Red;
                richTextBoxIPInfo.AppendText("\tISP: ");
                //richTextBoxIPInfo.SelectionFont = OriginalFont;
                richTextBoxIPInfo.SelectionColor = Color.DarkGreen;
                richTextBoxIPInfo.AppendText(MyIPInfo.ISP + ", " + MyIPInfo.Organization);
            }
            else
            {
                richTextBoxIPInfo.Text = "No internet connection";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*richTextBoxLog.Text = "Proxy log:"; //richTextBoxLog.Text + "\r\nVersion " + Functions.GetBuildDateTime(System.Reflection.Assembly.GetExecutingAssembly()).ToString();
            richTextBoxLog.SelectAll();
            richTextBoxLog.SelectionAlignment = HorizontalAlignment.Center;
            richTextBoxLog.SelectionColor = Color.GreenYellow;
            richTextBoxLog.DeselectAll();*/
            
            LoadMyIPInfo();
            textBoxProxyList.Text = Properties.Settings.Default.ProxyListToTest;
            LoadProxyList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProxyList();
            Properties.Settings.Default.Save();

        }

        void SaveProxyList()
        {
            string ProxyList = "";

            foreach (ListViewItem item in listViewProxyList.Items)
            {
                //ProxyList = ProxyList + item.Text;
                foreach (ListViewItem.ListViewSubItem SubItem in item.SubItems)
                {
                    ProxyList = ProxyList + "~" + SubItem.Text;
                }
                ProxyList = ProxyList + "\n";
            }

            Properties.Settings.Default.ProxyList = ProxyList;
        }
        void LoadProxyList()
        {
            string ProxyList = Properties.Settings.Default.ProxyList;
            listViewProxyList.Items.Clear();
            foreach (string Line in Regex.Split(ProxyList, @"\r?\n"))
            {
                if (!String.IsNullOrWhiteSpace(Line)) if (!String.IsNullOrWhiteSpace(Line.Remove(0, 1)))
                    {
                        ListViewItem item = listViewProxyList.Items.Add(Regex.Split(Line.Remove(0, 1), @"\r?\n|~")[0]);
                        foreach (string SubItem in Regex.Split(Line.Remove(0, 1), @"~"))
                        {
                            if (SubItem != item.Text)
                            {
                                item.SubItems.Add(SubItem);
                                if (SubItem == "False")
                                    item.BackColor = Color.Red;
                                else if (SubItem == "True")
                                {
                                    if (double.TryParse(item.SubItems[2].Text, out double i))
                                    {
                                        if (i < 3000) item.BackColor = Color.LightGreen;
                                        else if ((i > 3000) && (i < 6000)) item.BackColor = Color.Yellow;
                                        else if ((i > 6000) && (i < 8000)) item.BackColor = Color.Orange;
                                        else if (i > 8000) item.BackColor = Color.DarkOrange;
                                    }
                                    // item.BackColor = Color.LightGreen;
                                }
                            }
                        }
                    }
            }
        }

        private void ButtonClearListview_Click(object sender, EventArgs e)
        {
            listViewProxyList.Items.Clear();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem Item in listViewProxyList.Items)
            {
                if (Item.SubItems[3].Text == "False")
                {
                    Item.Remove();
                }
            }
        }

        public void AppendLogText(string text, Color color, bool addNewLine = false)
        {
            richTextBoxLog.SuspendLayout();
            richTextBoxLog.SelectionColor = color;
            richTextBoxLog.SelectionFont = new Font("Arial", 8, FontStyle.Regular);
            richTextBoxLog.SelectionAlignment = HorizontalAlignment.Left;
            richTextBoxLog.AppendText(addNewLine
                ? $"{text}{Environment.NewLine}"
                : text);
            richTextBoxLog.ScrollToCaret();
            richTextBoxLog.ResumeLayout();
        }
        private bool ProxyMatches(ListView Listview, string Proxy, string Port)
        {
            try
            {
                if ((Listview.FindItemWithText(Proxy, false, 0, false).Text == Proxy) && (Listview.FindItemWithText(Proxy, false, 0, false).SubItems[1].Text == Port))
                {
                    FormControlHelper.ControlInvoke(richTextBoxLog, () =>
                    {
                        AppendLogText(Proxy + ":" + Port + " already exist in list", Color.Black, true);
                        //richTextBoxLog.AppendText("\r\n" + Proxy + ":" + Port + " already exist in list");
                    });
                    return true;
                }
            }
            catch
            {
                return false;
            }
            
            return false;
        }

        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Copy")
            {
                string ToCopy = "";

                foreach (ListViewItem Item in listViewProxyList.SelectedItems)
                {
                    ToCopy = ToCopy + Item.SubItems[0].Text + ":" + Item.SubItems[1].Text + "\r\n";
                }
                ToCopy = ToCopy.Remove(ToCopy.Length - 2, 2);
                Clipboard.SetText(ToCopy);
            }
            else if (e.ClickedItem.Text == "Remove")
            {
                foreach (ListViewItem Item in listViewProxyList.SelectedItems)
                {
                    Item.Remove();
                }
                listViewProxyList.SelectedItems.Clear();
                listViewProxyList.SelectedIndices.Clear();
            }
            else if (e.ClickedItem.Text == "JD Export")
            {
                string ToCopy = "";

                foreach (ListViewItem Item in listViewProxyList.Items)
                {
                    ToCopy = ToCopy + "http://" + Item.SubItems[0].Text + ":" + Item.SubItems[1].Text + "\r\n";
                }
                ToCopy = ToCopy.Remove(ToCopy.Length - 2, 2);
                Clipboard.SetText(ToCopy);
            }
            else if (e.ClickedItem.Text == "Open coordinates")
            {
                System.Diagnostics.Process.Start("http://www.google.com/maps/@" + listViewProxyList.SelectedItems[0].SubItems[8].Text.Replace(" ", "") + ",15z");
            }
                

        }

        private void ListViewProxyList_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control))
            {
                if (e.KeyCode == Keys.C)
                {
                    string ToCopy = "";

                    foreach (ListViewItem Item in listViewProxyList.SelectedItems)
                    {
                        ToCopy = ToCopy + Item.SubItems[0].Text + ":" + Item.SubItems[1].Text + "\r\n";
                    }
                    ToCopy = ToCopy.Remove(ToCopy.Length - 2, 2);
                    Clipboard.SetText(ToCopy);
                }
                else if (e.KeyCode == Keys.A)
                {
                    foreach (ListViewItem item in listViewProxyList.Items)
                    {
                        item.Selected = true;
                    }
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem Item in listViewProxyList.SelectedItems)
                {
                    //Item.Selected = false;
                    //Item.Focused = false;
                    Item.Remove();
                }

                listViewProxyList.SelectedItems.Clear();
                listViewProxyList.SelectedIndices.Clear();
            }

        }

        void CleanList()
        {
            textBoxProxyList.Text = textBoxProxyList.Text
                .Replace('\t', ':')
                .Replace('\r', '\n');

            AppendLogText("Updating list and removing duplicates.",Color.Blue,true);
            string[] s = textBoxProxyList.Text.Split('\n');
                HashSet<string> set = new HashSet<string>(s);
                string[] result = new string[set.Count];
                set.CopyTo(result);

            textBoxProxyList.Text = "";
            foreach (string Line in result)
            {
                if ((!string.IsNullOrWhiteSpace(Line)) && (Line.Contains(":")))
                {
                    if ((IPAddress.TryParse(Line.Split(':')[0], out IPAddress address)) && (int.TryParse(Line.Split(':')[1], out int i)))
                        if (!ProxyMatches(listViewProxyList, Line.Split(':')[0], Line.Split(':')[1]))
                            textBoxProxyList.AppendText(Line + "\r\n");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CleanList();
        }

        private void ButtonCheckInvalid_Click(object sender, EventArgs e)
        {
            textBoxProxyList.Clear();
            foreach (ListViewItem Item in listViewProxyList.Items)
            {
                if (Item.SubItems[3].Text == "False")
                {
                    textBoxProxyList.AppendText(Item.SubItems[0].Text + ":" + Item.SubItems[1].Text + "\r\n");
                    Item.Remove();
                }
            }

            textBoxProxyList.Text = textBoxProxyList.Text.Remove(textBoxProxyList.Text.Length - 2, 2);

            threads = 0;
            currentline = 0;
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            //bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.DoWork += new DoWorkEventHandler(bw_StartProxyList);
            bw.RunWorkerAsync();
        }

        FloatingInfo Form2;
        int Distance = 0;
        public void RichTextBoxIPInfo_MouseHover(object sender, EventArgs e)
        {
            Form2 = new FloatingInfo();
            Form2.Location = new Point(Cursor.Position.X+ Distance, Cursor.Position.Y+ Distance);
            Form2.MyIPInfo = MyIPInfo;
            Form2.Show();
        }

        public void RichTextBoxIPInfo_MouseLeave(object sender, EventArgs e)
        {
            //if (Form2 != null)
              //  Form2.Close();
            //Form2.Hide();
        }

        private void ListViewProxyList_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            try
            {
                Distance = 1;
                if (Form2 != null) Form2.Close();
                Form2 = new FloatingInfo();
                Form2.Location = new Point(Cursor.Position.X + Distance, Cursor.Position.Y + Distance);
                IPAddress.TryParse(e.Item.SubItems[0].Text, out Form2.MyIPInfo.IP);
                Form2.MyIPInfo.ISP = e.Item.SubItems[10].Text;
                Form2.MyIPInfo.Organization = e.Item.SubItems[11].Text;
                Form2.MyIPInfo.Latitude = float.Parse(e.Item.SubItems[8].Text.Split(',')[0], CultureInfo.InvariantCulture.NumberFormat);
                Form2.MyIPInfo.Longitude = float.Parse(e.Item.SubItems[8].Text.Split(',')[1], CultureInfo.InvariantCulture.NumberFormat);
                Form2.Show();
            }
            catch
            {

            }
        }

        private void TimerClosePopup_Tick(object sender, EventArgs e)
        {
            labelProxyInfo.Text = "Proxy count: " + listViewProxyList.Items.Count.ToString();
                 
            if (Form2 != null)
            {

                if ((Cursor.Position.X + Distance > Form2.Location.X + Form2.Width) || (Cursor.Position.X + Distance < Form2.Location.X))
                {
                    Form2.Close();
                }
                if ((Cursor.Position.Y + Distance > Form2.Location.Y + Form2.Height) || (Cursor.Position.Y + Distance < Form2.Location.Y))
                {
                    Form2.Close();
                }

            }

        }
    }

}
