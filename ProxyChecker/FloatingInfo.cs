using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyChecker
{
    public partial class FloatingInfo : Form
    {
        public IPInfo MyIPInfo = new IPInfo();
        void SetBrowserEmulation(string programName, IE browserVersion)
        {
            if (!string.IsNullOrEmpty(programName))
            {
                programName = AppDomain.CurrentDomain.FriendlyName;

                Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                //Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                if (regKey != null)
                {
                    try
                    {
                        regKey.SetValue(programName, browserVersion, Microsoft.Win32.RegistryValueKind.DWord);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString(), "Error writing to the registry");
                        //throw new Exception("Error writing to the registry", ex);
                    }
                }
                else
                {
                    try
                    {
                        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl", true);
                        //regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl", true);
                        regKey.CreateSubKey("FEATURE_BROWSER_EMULATION");
                        regKey.SetValue(programName, browserVersion, Microsoft.Win32.RegistryValueKind.DWord);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString(), "Error writing to the registry");
                    }
                }
            }
        }
        internal enum IE
        {
            IE7 = 7000,
            IE8 = 8000,
            IE8StandardsMode = 8888,
            IE9 = 9000,
            IE9StandardsMode = 9999,
            IE10 = 10000,
            IE10StandardsMode = 10000,
            IE11 = 11000,
            IE11StandardsMode = 11000
        }
        public FloatingInfo()
        {
            SetBrowserEmulation(AppDomain.CurrentDomain.FriendlyName, IE.IE11StandardsMode);
            InitializeComponent();
        }


        private void FloatingInfo_Shown(object sender, EventArgs e)
        {
            this.Opacity = 0.90;
            richTextBoxInfo2.Clear();
            richTextBoxInfo2.SelectionAlignment = HorizontalAlignment.Center;
            if (MyIPInfo != null)
            {
                richTextBoxInfo2.AppendText(MyIPInfo.IP.ToString() + "\r\n");
                richTextBoxInfo2.AppendText(MyIPInfo.ISP + "\r\n");
                richTextBoxInfo2.AppendText(MyIPInfo.Organization.ToString() + "\r\n");
                richTextBoxInfo2.AppendText(MyIPInfo.Latitude.ToString() + ", " + MyIPInfo.Longitude.ToString() + "\r\n");
            }

            webBrowserMyMap.Navigate("http://www.google.com/maps/@" + MyIPInfo.Latitude.ToString().Replace(",", ".") + "," + MyIPInfo.Longitude.ToString().Replace(",", ".") + ",13z");
        }

        private void WebBrowserMyMap_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowserMyMap.Url.AbsoluteUri != "about:blank")
            {
                webBrowserMyMap.Document.GetElementById("searchbox").OuterHtml = "";
                webBrowserMyMap.Document.GetElementById("pane").OuterHtml = "";
                webBrowserMyMap.Document.GetElementById("vasquette").OuterHtml = "";
            }
        }

    }
}
