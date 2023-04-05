
namespace IzradaWebPreglednika
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bntSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.bntBack = new System.Windows.Forms.Button();
            this.bntForward = new System.Windows.Forms.Button();
            this.bntHome = new System.Windows.Forms.Button();
            this.bntRefresh = new System.Windows.Forms.Button();
            this.bntTabs = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cbBookmark = new System.Windows.Forms.ToolStripComboBox();
            this.bntNewTabOpen = new System.Windows.Forms.Button();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(807, 354);
            this.webBrowser1.TabIndex = 0;
            // 
            // bntSearch
            // 
            this.bntSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntSearch.Location = new System.Drawing.Point(632, 27);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(75, 23);
            this.bntSearch.TabIndex = 1;
            this.bntSearch.Text = "Traži";
            this.bntSearch.UseVisualStyleBackColor = false;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxSearch.Location = new System.Drawing.Point(12, 27);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(614, 20);
            this.txtBoxSearch.TabIndex = 2;
            this.txtBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyDown_1);
            // 
            // bntBack
            // 
            this.bntBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntBack.Location = new System.Drawing.Point(93, 54);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(75, 23);
            this.bntBack.TabIndex = 3;
            this.bntBack.Text = "Nazad";
            this.bntBack.UseVisualStyleBackColor = false;
            this.bntBack.Click += new System.EventHandler(this.bntBack_Click);
            // 
            // bntForward
            // 
            this.bntForward.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntForward.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntForward.Location = new System.Drawing.Point(174, 54);
            this.bntForward.Name = "bntForward";
            this.bntForward.Size = new System.Drawing.Size(75, 23);
            this.bntForward.TabIndex = 4;
            this.bntForward.Text = "Naprijed";
            this.bntForward.UseVisualStyleBackColor = false;
            this.bntForward.Click += new System.EventHandler(this.bntForward_Click);
            // 
            // bntHome
            // 
            this.bntHome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntHome.Location = new System.Drawing.Point(12, 54);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(75, 23);
            this.bntHome.TabIndex = 5;
            this.bntHome.Text = "Home";
            this.bntHome.UseVisualStyleBackColor = false;
            this.bntHome.Click += new System.EventHandler(this.bntHome_Click);
            // 
            // bntRefresh
            // 
            this.bntRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntRefresh.Location = new System.Drawing.Point(713, 54);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(96, 23);
            this.bntRefresh.TabIndex = 6;
            this.bntRefresh.Text = "Osvježiti";
            this.bntRefresh.UseVisualStyleBackColor = false;
            this.bntRefresh.Click += new System.EventHandler(this.bntRefresh_Click);
            // 
            // bntTabs
            // 
            this.bntTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntTabs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntTabs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntTabs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntTabs.Location = new System.Drawing.Point(632, 53);
            this.bntTabs.Name = "bntTabs";
            this.bntTabs.Size = new System.Drawing.Size(75, 23);
            this.bntTabs.TabIndex = 7;
            this.bntTabs.Text = "Novi Tab";
            this.bntTabs.UseVisualStyleBackColor = false;
            this.bntTabs.Click += new System.EventHandler(this.bntTabs_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 386);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bookmarkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookmarkToolStripMenuItem,
            this.removeBookmarkToolStripMenuItem,
            this.clearBookmarkToolStripMenuItem,
            this.toolStripSeparator5,
            this.toolStripTextBox1,
            this.cbBookmark});
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.bookmarkToolStripMenuItem.Text = "Bookmark";
            // 
            // addBookmarkToolStripMenuItem
            // 
            this.addBookmarkToolStripMenuItem.Name = "addBookmarkToolStripMenuItem";
            this.addBookmarkToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addBookmarkToolStripMenuItem.Text = "Add Bookmark";
            this.addBookmarkToolStripMenuItem.Click += new System.EventHandler(this.addBookmarkToolStripMenuItem_Click);
            // 
            // removeBookmarkToolStripMenuItem
            // 
            this.removeBookmarkToolStripMenuItem.Name = "removeBookmarkToolStripMenuItem";
            this.removeBookmarkToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.removeBookmarkToolStripMenuItem.Text = "Remove Bookmark";
            this.removeBookmarkToolStripMenuItem.Click += new System.EventHandler(this.removeBookmarkToolStripMenuItem_Click);
            // 
            // clearBookmarkToolStripMenuItem
            // 
            this.clearBookmarkToolStripMenuItem.Name = "clearBookmarkToolStripMenuItem";
            this.clearBookmarkToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.clearBookmarkToolStripMenuItem.Text = "Clear Bookmark";
            this.clearBookmarkToolStripMenuItem.Click += new System.EventHandler(this.clearBookmarkToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(178, 6);
            // 
            // cbBookmark
            // 
            this.cbBookmark.Name = "cbBookmark";
            this.cbBookmark.Size = new System.Drawing.Size(121, 23);
            this.cbBookmark.DropDownClosed += new System.EventHandler(this.cbBookmark_Click);
            // 
            // bntNewTabOpen
            // 
            this.bntNewTabOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntNewTabOpen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntNewTabOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntNewTabOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntNewTabOpen.Location = new System.Drawing.Point(713, 27);
            this.bntNewTabOpen.Name = "bntNewTabOpen";
            this.bntNewTabOpen.Size = new System.Drawing.Size(96, 23);
            this.bntNewTabOpen.TabIndex = 14;
            this.bntNewTabOpen.Text = "Traži u novi Tab";
            this.bntNewTabOpen.UseVisualStyleBackColor = false;
            this.bntNewTabOpen.Click += new System.EventHandler(this.bntNewTabOpen_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Bookmarks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(821, 466);
            this.Controls.Add(this.bntNewTabOpen);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bntTabs);
            this.Controls.Add(this.bntRefresh);
            this.Controls.Add(this.bntHome);
            this.Controls.Add(this.bntForward);
            this.Controls.Add(this.bntBack);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Web Preglednika";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button bntSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button bntBack;
        private System.Windows.Forms.Button bntForward;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.Button bntRefresh;
        private System.Windows.Forms.Button bntTabs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox cbBookmark;
        private System.Windows.Forms.ToolStripMenuItem clearBookmarkToolStripMenuItem;
        private System.Windows.Forms.Button bntNewTabOpen;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

