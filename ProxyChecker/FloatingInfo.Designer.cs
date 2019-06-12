namespace ProxyChecker
{
    partial class FloatingInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowserMyMap = new System.Windows.Forms.WebBrowser();
            this.richTextBoxInfo2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // webBrowserMyMap
            // 
            this.webBrowserMyMap.AllowWebBrowserDrop = false;
            this.webBrowserMyMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMyMap.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserMyMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMyMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMyMap.Name = "webBrowserMyMap";
            this.webBrowserMyMap.ScriptErrorsSuppressed = true;
            this.webBrowserMyMap.ScrollBarsEnabled = false;
            this.webBrowserMyMap.Size = new System.Drawing.Size(656, 331);
            this.webBrowserMyMap.TabIndex = 5;
            this.webBrowserMyMap.TabStop = false;
            this.webBrowserMyMap.WebBrowserShortcutsEnabled = false;
            this.webBrowserMyMap.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowserMyMap_DocumentCompleted);
            // 
            // richTextBoxInfo2
            // 
            this.richTextBoxInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxInfo2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxInfo2.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxInfo2.Enabled = false;
            this.richTextBoxInfo2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInfo2.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInfo2.Name = "richTextBoxInfo2";
            this.richTextBoxInfo2.ReadOnly = true;
            this.richTextBoxInfo2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxInfo2.Size = new System.Drawing.Size(290, 331);
            this.richTextBoxInfo2.TabIndex = 17;
            this.richTextBoxInfo2.Text = "";
            // 
            // FloatingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 331);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBoxInfo2);
            this.Controls.Add(this.webBrowserMyMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FloatingInfo";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FloatingInfo";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FloatingInfo_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBrowserMyMap;
        public System.Windows.Forms.RichTextBox richTextBoxInfo2;
    }
}