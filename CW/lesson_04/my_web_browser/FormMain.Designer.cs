namespace my_web_browser
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxSites = new System.Windows.Forms.ListBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelUrl = new System.Windows.Forms.Panel();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.panelGOBtn = new System.Windows.Forms.Panel();
            this.buttonGO = new System.Windows.Forms.Button();
            this.panelUrlBtns = new System.Windows.Forms.Panel();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelUrl.SuspendLayout();
            this.panelGOBtn.SuspendLayout();
            this.panelUrlBtns.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxSites);
            this.panel1.Controls.Add(this.comboBoxCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 660);
            this.panel1.TabIndex = 0;
            // 
            // listBoxSites
            // 
            this.listBoxSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSites.FormattingEnabled = true;
            this.listBoxSites.ItemHeight = 16;
            this.listBoxSites.Location = new System.Drawing.Point(0, 24);
            this.listBoxSites.Name = "listBoxSites";
            this.listBoxSites.ScrollAlwaysVisible = true;
            this.listBoxSites.Size = new System.Drawing.Size(235, 636);
            this.listBoxSites.TabIndex = 2;
            this.listBoxSites.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSites_MouseDoubleClick);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(0, 0);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(235, 24);
            this.comboBoxCategories.TabIndex = 1;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.sitesToolStripMenuItem,
            this.pagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.removeCategoryToolStripMenuItem});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "&Categories";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addCategoryToolStripMenuItem.Text = "&Add Category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.AddCategoryToolStripMenuItem_Click);
            // 
            // removeCategoryToolStripMenuItem
            // 
            this.removeCategoryToolStripMenuItem.Name = "removeCategoryToolStripMenuItem";
            this.removeCategoryToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.removeCategoryToolStripMenuItem.Text = "&Remove Category";
            this.removeCategoryToolStripMenuItem.Click += new System.EventHandler(this.RemoveCategoryToolStripMenuItem_Click);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSiteToolStripMenuItem,
            this.removeSiteToolStripMenuItem,
            this.editSiteToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sitesToolStripMenuItem.Text = "&Sites";
            // 
            // addSiteToolStripMenuItem
            // 
            this.addSiteToolStripMenuItem.Name = "addSiteToolStripMenuItem";
            this.addSiteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addSiteToolStripMenuItem.Text = "&Add Site";
            this.addSiteToolStripMenuItem.Click += new System.EventHandler(this.AddSiteToolStripMenuItem_Click);
            // 
            // removeSiteToolStripMenuItem
            // 
            this.removeSiteToolStripMenuItem.Name = "removeSiteToolStripMenuItem";
            this.removeSiteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.removeSiteToolStripMenuItem.Text = "&Remove Site";
            this.removeSiteToolStripMenuItem.Click += new System.EventHandler(this.removeSiteToolStripMenuItem_Click);
            // 
            // editSiteToolStripMenuItem
            // 
            this.editSiteToolStripMenuItem.Name = "editSiteToolStripMenuItem";
            this.editSiteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editSiteToolStripMenuItem.Text = "&Edit Site";
            // 
            // pagesToolStripMenuItem
            // 
            this.pagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePageToolStripMenuItem});
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pagesToolStripMenuItem.Text = "&Pages";
            // 
            // savePageToolStripMenuItem
            // 
            this.savePageToolStripMenuItem.Name = "savePageToolStripMenuItem";
            this.savePageToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.savePageToolStripMenuItem.Text = "&Save Page";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelUrl);
            this.panel2.Controls.Add(this.panelGOBtn);
            this.panel2.Controls.Add(this.panelUrlBtns);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(235, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 34);
            this.panel2.TabIndex = 2;
            // 
            // panelUrl
            // 
            this.panelUrl.Controls.Add(this.textBoxUrl);
            this.panelUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUrl.Location = new System.Drawing.Point(97, 0);
            this.panelUrl.Name = "panelUrl";
            this.panelUrl.Size = new System.Drawing.Size(832, 34);
            this.panelUrl.TabIndex = 5;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUrl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUrl.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUrl.Location = new System.Drawing.Point(0, 0);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(832, 31);
            this.textBoxUrl.TabIndex = 0;
            this.textBoxUrl.Click += new System.EventHandler(this.TextBoxUrl_Click);
            this.textBoxUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxUrl_KeyDown);
            // 
            // panelGOBtn
            // 
            this.panelGOBtn.Controls.Add(this.buttonGO);
            this.panelGOBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGOBtn.Location = new System.Drawing.Point(929, 0);
            this.panelGOBtn.Name = "panelGOBtn";
            this.panelGOBtn.Size = new System.Drawing.Size(70, 34);
            this.panelGOBtn.TabIndex = 4;
            // 
            // buttonGO
            // 
            this.buttonGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGO.Location = new System.Drawing.Point(0, 0);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(70, 34);
            this.buttonGO.TabIndex = 3;
            this.buttonGO.Text = "GO";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.ButtonGO_Click);
            // 
            // panelUrlBtns
            // 
            this.panelUrlBtns.Controls.Add(this.buttonForward);
            this.panelUrlBtns.Controls.Add(this.buttonBack);
            this.panelUrlBtns.Controls.Add(this.buttonHome);
            this.panelUrlBtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUrlBtns.Location = new System.Drawing.Point(0, 0);
            this.panelUrlBtns.Name = "panelUrlBtns";
            this.panelUrlBtns.Size = new System.Drawing.Size(97, 34);
            this.panelUrlBtns.TabIndex = 3;
            // 
            // buttonForward
            // 
            this.buttonForward.BackgroundImage = global::my_web_browser.Properties.Resources.iconfinder_forward_5355374;
            this.buttonForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonForward.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonForward.Location = new System.Drawing.Point(69, 0);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(28, 34);
            this.buttonForward.TabIndex = 2;
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.ButtonForward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::my_web_browser.Properties.Resources.iconfinder_arrow_backward_left_2571218;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Location = new System.Drawing.Point(40, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(30, 34);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = global::my_web_browser.Properties.Resources.iconfinder_Home_669946;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHome.Image = global::my_web_browser.Properties.Resources.iconfinder_Home_669946;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 34);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.webBrowser1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(235, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(999, 626);
            this.panel6.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(999, 625);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://google.com", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser1_Navigated);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 684);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Mrbx";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelUrl.ResumeLayout(false);
            this.panelUrl.PerformLayout();
            this.panelGOBtn.ResumeLayout(false);
            this.panelUrlBtns.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePageToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxSites;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelUrl;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Panel panelGOBtn;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.Panel panelUrlBtns;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

