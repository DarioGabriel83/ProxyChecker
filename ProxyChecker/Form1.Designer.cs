namespace ProxyChecker
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.richTextBoxIPInfo = new System.Windows.Forms.RichTextBox();
            this.listViewProxyList = new System.Windows.Forms.ListView();
            this.columnHeaderIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResponseTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIsWorking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCountryCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCoordinates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTimezone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderISP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemJDExport = new System.Windows.Forms.ToolStripMenuItem();
            this.openCoordinatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxProxyPort = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxProxyIP = new System.Windows.Forms.TextBox();
            this.buttonClearListview = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxClear = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCheckInvalid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarMaxThreads = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxProxyList = new System.Windows.Forms.TextBox();
            this.buttonTestList = new System.Windows.Forms.Button();
            this.timerClosePopup = new System.Windows.Forms.Timer(this.components);
            this.labelProxyInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxClear.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxThreads)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddTest.Location = new System.Drawing.Point(920, 6);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(73, 21);
            this.buttonAddTest.TabIndex = 2;
            this.buttonAddTest.Text = "Add && test";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBoxIPInfo
            // 
            this.richTextBoxIPInfo.AutoWordSelection = true;
            this.richTextBoxIPInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxIPInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxIPInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxIPInfo.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxIPInfo.Name = "richTextBoxIPInfo";
            this.richTextBoxIPInfo.ReadOnly = true;
            this.richTextBoxIPInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxIPInfo.Size = new System.Drawing.Size(984, 24);
            this.richTextBoxIPInfo.TabIndex = 3;
            this.richTextBoxIPInfo.Text = "";
            this.richTextBoxIPInfo.MouseLeave += new System.EventHandler(this.RichTextBoxIPInfo_MouseLeave);
            this.richTextBoxIPInfo.MouseHover += new System.EventHandler(this.RichTextBoxIPInfo_MouseHover);
            // 
            // listViewProxyList
            // 
            this.listViewProxyList.AllowColumnReorder = true;
            this.listViewProxyList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProxyList.CheckBoxes = true;
            this.listViewProxyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIP,
            this.columnHeaderPort,
            this.columnHeaderResponseTime,
            this.columnHeaderIsWorking,
            this.columnHeaderCountryCode,
            this.columnHeaderRegion,
            this.columnHeaderCity,
            this.columnHeaderZipCode,
            this.columnHeaderCoordinates,
            this.columnHeaderTimezone,
            this.columnHeaderISP,
            this.columnHeaderOrg});
            this.listViewProxyList.ContextMenuStrip = this.contextMenuStrip;
            this.listViewProxyList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewProxyList.FullRowSelect = true;
            this.listViewProxyList.GridLines = true;
            this.listViewProxyList.HideSelection = false;
            this.listViewProxyList.Location = new System.Drawing.Point(0, 202);
            this.listViewProxyList.Name = "listViewProxyList";
            this.listViewProxyList.Size = new System.Drawing.Size(1184, 278);
            this.listViewProxyList.TabIndex = 4;
            this.listViewProxyList.UseCompatibleStateImageBehavior = false;
            this.listViewProxyList.View = System.Windows.Forms.View.Details;
            this.listViewProxyList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewProxyList_ColumnClick);
            this.listViewProxyList.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.ListViewProxyList_ItemMouseHover);
            this.listViewProxyList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewProxyList_KeyDown);
            // 
            // columnHeaderIP
            // 
            this.columnHeaderIP.Text = "IP";
            this.columnHeaderIP.Width = 112;
            // 
            // columnHeaderPort
            // 
            this.columnHeaderPort.Text = "Port";
            // 
            // columnHeaderResponseTime
            // 
            this.columnHeaderResponseTime.Text = "Response time";
            this.columnHeaderResponseTime.Width = 86;
            // 
            // columnHeaderIsWorking
            // 
            this.columnHeaderIsWorking.Text = "Working";
            // 
            // columnHeaderCountryCode
            // 
            this.columnHeaderCountryCode.Text = "Country code";
            this.columnHeaderCountryCode.Width = 77;
            // 
            // columnHeaderRegion
            // 
            this.columnHeaderRegion.Text = "Region";
            this.columnHeaderRegion.Width = 113;
            // 
            // columnHeaderCity
            // 
            this.columnHeaderCity.Text = "City";
            this.columnHeaderCity.Width = 118;
            // 
            // columnHeaderZipCode
            // 
            this.columnHeaderZipCode.Text = "Zip code";
            this.columnHeaderZipCode.Width = 64;
            // 
            // columnHeaderCoordinates
            // 
            this.columnHeaderCoordinates.Text = "Coordinate";
            this.columnHeaderCoordinates.Width = 124;
            // 
            // columnHeaderTimezone
            // 
            this.columnHeaderTimezone.Text = "Timezone";
            this.columnHeaderTimezone.Width = 178;
            // 
            // columnHeaderISP
            // 
            this.columnHeaderISP.Text = "ISP";
            this.columnHeaderISP.Width = 70;
            // 
            // columnHeaderOrg
            // 
            this.columnHeaderOrg.Text = "Organization";
            this.columnHeaderOrg.Width = 122;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemRemove,
            this.toolStripMenuItemJDExport,
            this.openCoordinatesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(169, 92);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip_ItemClicked);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemCopy.Text = "Copy";
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemRemove.Text = "Remove";
            // 
            // toolStripMenuItemJDExport
            // 
            this.toolStripMenuItemJDExport.Name = "toolStripMenuItemJDExport";
            this.toolStripMenuItemJDExport.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemJDExport.Text = "JD Export";
            // 
            // openCoordinatesToolStripMenuItem
            // 
            this.openCoordinatesToolStripMenuItem.Name = "openCoordinatesToolStripMenuItem";
            this.openCoordinatesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openCoordinatesToolStripMenuItem.Text = "Open coordinates";
            // 
            // textBoxProxyPort
            // 
            this.textBoxProxyPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxProxyPort.Location = new System.Drawing.Point(857, 6);
            this.textBoxProxyPort.Name = "textBoxProxyPort";
            this.textBoxProxyPort.Size = new System.Drawing.Size(57, 20);
            this.textBoxProxyPort.TabIndex = 6;
            this.textBoxProxyPort.Text = "1448";
            this.textBoxProxyPort.TextChanged += new System.EventHandler(this.TextBoxProxyPort_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 538);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1184, 23);
            this.progressBar.TabIndex = 12;
            // 
            // textBoxProxyIP
            // 
            this.textBoxProxyIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxProxyIP.Location = new System.Drawing.Point(639, 6);
            this.textBoxProxyIP.Name = "textBoxProxyIP";
            this.textBoxProxyIP.Size = new System.Drawing.Size(212, 20);
            this.textBoxProxyIP.TabIndex = 5;
            this.textBoxProxyIP.Text = "94.242.59.135";
            this.textBoxProxyIP.TextChanged += new System.EventHandler(this.TextBoxProxyIP_TextChanged);
            // 
            // buttonClearListview
            // 
            this.buttonClearListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearListview.Location = new System.Drawing.Point(3, 3);
            this.buttonClearListview.Name = "buttonClearListview";
            this.buttonClearListview.Size = new System.Drawing.Size(75, 27);
            this.buttonClearListview.TabIndex = 14;
            this.buttonClearListview.Text = "All";
            this.buttonClearListview.UseVisualStyleBackColor = true;
            this.buttonClearListview.Click += new System.EventHandler(this.ButtonClearListview_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.groupBoxClear, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBoxTest, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 480);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1184, 58);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // groupBoxClear
            // 
            this.groupBoxClear.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxClear.Location = new System.Drawing.Point(3, 3);
            this.groupBoxClear.Name = "groupBoxClear";
            this.groupBoxClear.Size = new System.Drawing.Size(170, 52);
            this.groupBoxClear.TabIndex = 16;
            this.groupBoxClear.TabStop = false;
            this.groupBoxClear.Text = "Clear";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.buttonClearListview, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(164, 33);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(84, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Invalids";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxTest.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTest.Location = new System.Drawing.Point(179, 3);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(1002, 52);
            this.groupBoxTest.TabIndex = 17;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Test proxy";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.buttonCheckInvalid, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonAddTest, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxProxyPort, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxProxyIP, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelProxyInfo, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(996, 33);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // buttonCheckInvalid
            // 
            this.buttonCheckInvalid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheckInvalid.Location = new System.Drawing.Point(3, 3);
            this.buttonCheckInvalid.Name = "buttonCheckInvalid";
            this.buttonCheckInvalid.Size = new System.Drawing.Size(84, 27);
            this.buttonCheckInvalid.TabIndex = 0;
            this.buttonCheckInvalid.Text = "Try invalid";
            this.buttonCheckInvalid.UseVisualStyleBackColor = true;
            this.buttonCheckInvalid.Click += new System.EventHandler(this.ButtonCheckInvalid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Max threads: 40";
            // 
            // trackBarMaxThreads
            // 
            this.trackBarMaxThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarMaxThreads.Location = new System.Drawing.Point(3, 3);
            this.trackBarMaxThreads.Maximum = 100;
            this.trackBarMaxThreads.Minimum = 1;
            this.trackBarMaxThreads.Name = "trackBarMaxThreads";
            this.trackBarMaxThreads.Size = new System.Drawing.Size(978, 17);
            this.trackBarMaxThreads.TabIndex = 9;
            this.trackBarMaxThreads.Value = 40;
            this.trackBarMaxThreads.Scroll += new System.EventHandler(this.TrackBarMaxThreads_Scroll);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.trackBarMaxThreads, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(984, 43);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Font = new System.Drawing.Font("PMingLiU-ExtB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxLog.Size = new System.Drawing.Size(984, 135);
            this.richTextBoxLog.TabIndex = 16;
            this.richTextBoxLog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Paste here your proxy list:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textBoxProxyList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTestList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(984, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 202);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // textBoxProxyList
            // 
            this.textBoxProxyList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProxyList.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProxyChecker.Properties.Settings.Default, "ProxyListToTest", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxProxyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProxyList.Location = new System.Drawing.Point(3, 16);
            this.textBoxProxyList.Multiline = true;
            this.textBoxProxyList.Name = "textBoxProxyList";
            this.textBoxProxyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProxyList.Size = new System.Drawing.Size(194, 143);
            this.textBoxProxyList.TabIndex = 19;
            this.textBoxProxyList.Text = global::ProxyChecker.Properties.Settings.Default.ProxyListToTest;
            // 
            // buttonTestList
            // 
            this.buttonTestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTestList.Location = new System.Drawing.Point(3, 165);
            this.buttonTestList.Name = "buttonTestList";
            this.buttonTestList.Size = new System.Drawing.Size(194, 34);
            this.buttonTestList.TabIndex = 18;
            this.buttonTestList.Text = "Test list";
            this.buttonTestList.UseVisualStyleBackColor = true;
            this.buttonTestList.Click += new System.EventHandler(this.ButtonTestList_Click);
            // 
            // timerClosePopup
            // 
            this.timerClosePopup.Enabled = true;
            this.timerClosePopup.Interval = 400;
            this.timerClosePopup.Tick += new System.EventHandler(this.TimerClosePopup_Tick);
            // 
            // labelProxyInfo
            // 
            this.labelProxyInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProxyInfo.Location = new System.Drawing.Point(313, 5);
            this.labelProxyInfo.Name = "labelProxyInfo";
            this.labelProxyInfo.Size = new System.Drawing.Size(100, 23);
            this.labelProxyInfo.TabIndex = 7;
            this.labelProxyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.richTextBoxIPInfo);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listViewProxyList);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.progressBar);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBoxClear.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxTest.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxThreads)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.ListView listViewProxyList;
        private System.Windows.Forms.ColumnHeader columnHeaderIP;
        private System.Windows.Forms.ColumnHeader columnHeaderCountryCode;
        private System.Windows.Forms.ColumnHeader columnHeaderRegion;
        private System.Windows.Forms.ColumnHeader columnHeaderCity;
        private System.Windows.Forms.ColumnHeader columnHeaderZipCode;
        private System.Windows.Forms.ColumnHeader columnHeaderCoordinates;
        private System.Windows.Forms.ColumnHeader columnHeaderTimezone;
        private System.Windows.Forms.ColumnHeader columnHeaderISP;
        private System.Windows.Forms.ColumnHeader columnHeaderOrg;
        private System.Windows.Forms.ColumnHeader columnHeaderPort;
        private System.Windows.Forms.TextBox textBoxProxyPort;
        private System.Windows.Forms.ColumnHeader columnHeaderResponseTime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBoxProxyIP;
        private System.Windows.Forms.ColumnHeader columnHeaderIsWorking;
        private System.Windows.Forms.Button buttonClearListview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarMaxThreads;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonCheckInvalid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxProxyList;
        private System.Windows.Forms.Button buttonTestList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemJDExport;
        private System.Windows.Forms.ToolStripMenuItem openCoordinatesToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBoxIPInfo;
        public System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Timer timerClosePopup;
        private System.Windows.Forms.Label labelProxyInfo;
    }
}

