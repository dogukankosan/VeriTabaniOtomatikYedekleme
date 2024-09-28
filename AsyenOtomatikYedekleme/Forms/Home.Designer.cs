
namespace AsyenOtomatikYedekleme.Forms
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbGetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_BackUp = new DevExpress.XtraEditors.SimpleButton();
            this.serviceStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 449);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem,
            this.dbGetToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(310, 70);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripMenuItem.Image")));
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.DeleteToolStripMenuItem.Text = "Yedek Alınacak Veri Tabanını Kaldır Ve Kaydet";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // dbGetToolStripMenuItem
            // 
            this.dbGetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dbGetToolStripMenuItem.Image")));
            this.dbGetToolStripMenuItem.Name = "dbGetToolStripMenuItem";
            this.dbGetToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.dbGetToolStripMenuItem.Text = "Sistemden Tekrardan Çek";
            this.dbGetToolStripMenuItem.Click += new System.EventHandler(this.dbGetToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.SaveToolStripMenuItem.Text = "Yedek Alınacak Veri Tabanlarını Kaydet";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpSettingsToolStripMenuItem,
            this.eMailToolStripMenuItem,
            this.ServiceSaveToolStripMenuItem,
            this.serviceStartToolStripMenuItem,
            this.serviceStopToolStripMenuItem,
            this.serviceDeleteToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // backUpSettingsToolStripMenuItem
            // 
            this.backUpSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backUpSettingsToolStripMenuItem.Image")));
            this.backUpSettingsToolStripMenuItem.Name = "backUpSettingsToolStripMenuItem";
            this.backUpSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backUpSettingsToolStripMenuItem.Text = "Yedekleme Ayarları";
            this.backUpSettingsToolStripMenuItem.Click += new System.EventHandler(this.backUpSettingsToolStripMenuItem_Click);
            // 
            // eMailToolStripMenuItem
            // 
            this.eMailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eMailToolStripMenuItem.Image")));
            this.eMailToolStripMenuItem.Name = "eMailToolStripMenuItem";
            this.eMailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eMailToolStripMenuItem.Text = "E-Mail";
            this.eMailToolStripMenuItem.Click += new System.EventHandler(this.eMailToolStripMenuItem_Click);
            // 
            // ServiceSaveToolStripMenuItem
            // 
            this.ServiceSaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ServiceSaveToolStripMenuItem.Image")));
            this.ServiceSaveToolStripMenuItem.Name = "ServiceSaveToolStripMenuItem";
            this.ServiceSaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ServiceSaveToolStripMenuItem.Text = "Servisi Kaydet";
            this.ServiceSaveToolStripMenuItem.Click += new System.EventHandler(this.ServiceSaveToolStripMenuItem_Click);
            // 
            // serviceStartToolStripMenuItem
            // 
            this.serviceStartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceStartToolStripMenuItem.Image")));
            this.serviceStartToolStripMenuItem.Name = "serviceStartToolStripMenuItem";
            this.serviceStartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviceStartToolStripMenuItem.Text = "Servisi Başlat";
            this.serviceStartToolStripMenuItem.Click += new System.EventHandler(this.serviceStartToolStripMenuItem_Click);
            // 
            // serviceDeleteToolStripMenuItem
            // 
            this.serviceDeleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceDeleteToolStripMenuItem.Image")));
            this.serviceDeleteToolStripMenuItem.Name = "serviceDeleteToolStripMenuItem";
            this.serviceDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviceDeleteToolStripMenuItem.Text = "Servisi Sil";
            this.serviceDeleteToolStripMenuItem.Click += new System.EventHandler(this.serviceDeleteToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aboutToolStripMenuItem.Text = "Hakkımızda";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btn_BackUp
            // 
            this.btn_BackUp.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_BackUp.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btn_BackUp.Appearance.Options.UseBackColor = true;
            this.btn_BackUp.Appearance.Options.UseFont = true;
            this.btn_BackUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BackUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_BackUp.Location = new System.Drawing.Point(400, 415);
            this.btn_BackUp.Name = "btn_BackUp";
            this.btn_BackUp.Size = new System.Drawing.Size(285, 58);
            this.btn_BackUp.TabIndex = 2;
            this.btn_BackUp.Text = "Manuel Yedeklemeyi Başlat";
            this.btn_BackUp.Click += new System.EventHandler(this.btn_BackUp_Click);
            // 
            // serviceStopToolStripMenuItem
            // 
            this.serviceStopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceStopToolStripMenuItem.Image")));
            this.serviceStopToolStripMenuItem.Name = "serviceStopToolStripMenuItem";
            this.serviceStopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviceStopToolStripMenuItem.Text = "Servisi Durdur";
            this.serviceStopToolStripMenuItem.Click += new System.EventHandler(this.serviceStopToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(685, 473);
            this.Controls.Add(this.btn_BackUp);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.menuStrip1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Home.IconOptions.Image")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekleme Programı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btn_BackUp;
        private System.Windows.Forms.ToolStripMenuItem eMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dbGetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceStopToolStripMenuItem;
    }
}