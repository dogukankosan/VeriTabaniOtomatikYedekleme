
namespace AsyenOtomatikYedekleme.Forms
{
    partial class BackUpSettingsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpSettingsForms));
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.chk_Monday = new System.Windows.Forms.CheckBox();
            this.chk_Tuesday = new System.Windows.Forms.CheckBox();
            this.chk_Wednesday = new System.Windows.Forms.CheckBox();
            this.chk_Thursday = new System.Windows.Forms.CheckBox();
            this.chk_Friday = new System.Windows.Forms.CheckBox();
            this.chk_Saturday = new System.Windows.Forms.CheckBox();
            this.chk_Sunday = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_FolderBackUp = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_WinrarPassword = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_WinrarFolder = new DevExpress.XtraEditors.TextEdit();
            this.btn_NotEye = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Eye = new DevExpress.XtraEditors.SimpleButton();
            this.chk_BackDelete = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FolderBackUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WinrarPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WinrarFolder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2024, 9, 7, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(118, 22);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(140, 20);
            this.timeEdit1.TabIndex = 0;
            // 
            // chk_Monday
            // 
            this.chk_Monday.AutoSize = true;
            this.chk_Monday.Location = new System.Drawing.Point(5, 26);
            this.chk_Monday.Name = "chk_Monday";
            this.chk_Monday.Size = new System.Drawing.Size(70, 17);
            this.chk_Monday.TabIndex = 3;
            this.chk_Monday.Text = "Pazartesi";
            this.chk_Monday.UseVisualStyleBackColor = true;
            // 
            // chk_Tuesday
            // 
            this.chk_Tuesday.AutoSize = true;
            this.chk_Tuesday.Location = new System.Drawing.Point(81, 26);
            this.chk_Tuesday.Name = "chk_Tuesday";
            this.chk_Tuesday.Size = new System.Drawing.Size(42, 17);
            this.chk_Tuesday.TabIndex = 4;
            this.chk_Tuesday.Text = "Salı";
            this.chk_Tuesday.UseVisualStyleBackColor = true;
            // 
            // chk_Wednesday
            // 
            this.chk_Wednesday.AutoSize = true;
            this.chk_Wednesday.Location = new System.Drawing.Point(157, 26);
            this.chk_Wednesday.Name = "chk_Wednesday";
            this.chk_Wednesday.Size = new System.Drawing.Size(74, 17);
            this.chk_Wednesday.TabIndex = 5;
            this.chk_Wednesday.Text = "Çarşamba";
            this.chk_Wednesday.UseVisualStyleBackColor = true;
            // 
            // chk_Thursday
            // 
            this.chk_Thursday.AutoSize = true;
            this.chk_Thursday.Location = new System.Drawing.Point(5, 49);
            this.chk_Thursday.Name = "chk_Thursday";
            this.chk_Thursday.Size = new System.Drawing.Size(73, 17);
            this.chk_Thursday.TabIndex = 6;
            this.chk_Thursday.Text = "Perşembe";
            this.chk_Thursday.UseVisualStyleBackColor = true;
            // 
            // chk_Friday
            // 
            this.chk_Friday.AutoSize = true;
            this.chk_Friday.Location = new System.Drawing.Point(81, 49);
            this.chk_Friday.Name = "chk_Friday";
            this.chk_Friday.Size = new System.Drawing.Size(53, 17);
            this.chk_Friday.TabIndex = 7;
            this.chk_Friday.Text = "Cuma";
            this.chk_Friday.UseVisualStyleBackColor = true;
            // 
            // chk_Saturday
            // 
            this.chk_Saturday.AutoSize = true;
            this.chk_Saturday.Location = new System.Drawing.Point(157, 49);
            this.chk_Saturday.Name = "chk_Saturday";
            this.chk_Saturday.Size = new System.Drawing.Size(74, 17);
            this.chk_Saturday.TabIndex = 8;
            this.chk_Saturday.Text = "Cumartesi";
            this.chk_Saturday.UseVisualStyleBackColor = true;
            // 
            // chk_Sunday
            // 
            this.chk_Sunday.AutoSize = true;
            this.chk_Sunday.Location = new System.Drawing.Point(5, 72);
            this.chk_Sunday.Name = "chk_Sunday";
            this.chk_Sunday.Size = new System.Drawing.Size(53, 17);
            this.chk_Sunday.TabIndex = 9;
            this.chk_Sunday.Text = "Pazar";
            this.chk_Sunday.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Yedekleme Saati:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chk_Monday);
            this.groupControl1.Controls.Add(this.chk_Tuesday);
            this.groupControl1.Controls.Add(this.chk_Sunday);
            this.groupControl1.Controls.Add(this.chk_Wednesday);
            this.groupControl1.Controls.Add(this.chk_Saturday);
            this.groupControl1.Controls.Add(this.chk_Thursday);
            this.groupControl1.Controls.Add(this.chk_Friday);
            this.groupControl1.Location = new System.Drawing.Point(12, 129);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(246, 102);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Yedek Alınacak Günler";
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.btn_Save.Appearance.Options.UseBackColor = true;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(0, 273);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(297, 58);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_FolderBackUp
            // 
            this.txt_FolderBackUp.Location = new System.Drawing.Point(118, 48);
            this.txt_FolderBackUp.Name = "txt_FolderBackUp";
            this.txt_FolderBackUp.Properties.MaxLength = 50;
            this.txt_FolderBackUp.Size = new System.Drawing.Size(140, 20);
            this.txt_FolderBackUp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Yedek Klasörü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Winrar Şifresi:";
            // 
            // txt_WinrarPassword
            // 
            this.txt_WinrarPassword.Location = new System.Drawing.Point(118, 103);
            this.txt_WinrarPassword.Name = "txt_WinrarPassword";
            this.txt_WinrarPassword.Properties.MaxLength = 50;
            this.txt_WinrarPassword.Properties.PasswordChar = '*';
            this.txt_WinrarPassword.Size = new System.Drawing.Size(140, 20);
            this.txt_WinrarPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Winrar Yolu:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_WinrarFolder
            // 
            this.txt_WinrarFolder.Location = new System.Drawing.Point(118, 74);
            this.txt_WinrarFolder.Name = "txt_WinrarFolder";
            this.txt_WinrarFolder.Properties.MaxLength = 100;
            this.txt_WinrarFolder.Size = new System.Drawing.Size(140, 20);
            this.txt_WinrarFolder.TabIndex = 2;
            // 
            // btn_NotEye
            // 
            this.btn_NotEye.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_NotEye.Appearance.Options.UseBackColor = true;
            this.btn_NotEye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NotEye.ImageOptions.Image")));
            this.btn_NotEye.Location = new System.Drawing.Point(79, 103);
            this.btn_NotEye.Name = "btn_NotEye";
            this.btn_NotEye.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_NotEye.Size = new System.Drawing.Size(36, 20);
            this.btn_NotEye.TabIndex = 22;
            this.btn_NotEye.Click += new System.EventHandler(this.btn_NotEye_Click);
            // 
            // btn_Eye
            // 
            this.btn_Eye.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eye.Appearance.Options.UseBackColor = true;
            this.btn_Eye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eye.ImageOptions.Image")));
            this.btn_Eye.Location = new System.Drawing.Point(80, 103);
            this.btn_Eye.Name = "btn_Eye";
            this.btn_Eye.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Eye.Size = new System.Drawing.Size(35, 20);
            this.btn_Eye.TabIndex = 21;
            this.btn_Eye.Click += new System.EventHandler(this.btn_Eye_Click);
            // 
            // chk_BackDelete
            // 
            this.chk_BackDelete.AutoSize = true;
            this.chk_BackDelete.Location = new System.Drawing.Point(12, 240);
            this.chk_BackDelete.Name = "chk_BackDelete";
            this.chk_BackDelete.Size = new System.Drawing.Size(244, 17);
            this.chk_BackDelete.TabIndex = 4;
            this.chk_BackDelete.Text = "Yedekleme Sonrası Eski Yedekler Silinecek Mi ?";
            this.chk_BackDelete.UseVisualStyleBackColor = true;
            // 
            // BackUpSettingsForms
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 331);
            this.Controls.Add(this.chk_BackDelete);
            this.Controls.Add(this.btn_NotEye);
            this.Controls.Add(this.btn_Eye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_WinrarFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_WinrarPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_FolderBackUp);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeEdit1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("BackUpSettingsForms.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "BackUpSettingsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedek Alma Ayarları";
            this.Load += new System.EventHandler(this.BackUpSettingscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FolderBackUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WinrarPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WinrarFolder.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private System.Windows.Forms.CheckBox chk_Monday;
        private System.Windows.Forms.CheckBox chk_Tuesday;
        private System.Windows.Forms.CheckBox chk_Wednesday;
        private System.Windows.Forms.CheckBox chk_Thursday;
        private System.Windows.Forms.CheckBox chk_Friday;
        private System.Windows.Forms.CheckBox chk_Saturday;
        private System.Windows.Forms.CheckBox chk_Sunday;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit txt_FolderBackUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_WinrarPassword;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_WinrarFolder;
        private DevExpress.XtraEditors.SimpleButton btn_NotEye;
        private DevExpress.XtraEditors.SimpleButton btn_Eye;
        private System.Windows.Forms.CheckBox chk_BackDelete;
    }
}