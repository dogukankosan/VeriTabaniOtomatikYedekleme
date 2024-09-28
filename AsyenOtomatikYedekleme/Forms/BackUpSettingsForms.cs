using AsyenOtomatikYedekleme.Bussiness;
using AsyenOtomatikYedekleme.Classes;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AsyenOtomatikYedekleme.Forms
{
    public partial class BackUpSettingsForms : XtraForm
    {
        public BackUpSettingsForms()
        {
            InitializeComponent();
        }
        private bool status = false;
        private void BackUpSettingscs_Load(object sender, EventArgs e)
        {
            btn_NotEye.Visible = false;
            try
            {
                DataTable table = SQLLiteConnection.GetDataFromSQLite("SELECT BackUpTime,BackUpFolder,WinrarFolder,WinrarPassword,Days,BackUpDelete FROM DbBackUpSettings LIMIT 1");
                if (table.Rows.Count > 0)
                {
                    timeEdit1.EditValue = table.Rows[0][0].ToString();
                    txt_FolderBackUp.Text = table.Rows[0][1].ToString();
                    txt_WinrarFolder.Text = table.Rows[0][2].ToString();
                    txt_WinrarPassword.Text = EncryptionHelper.Decrypt(table.Rows[0][3].ToString());
                    chk_Monday.Checked = table.Rows[0][4].ToString().Contains("Pazartesi") ? true : false;
                    chk_Tuesday.Checked = table.Rows[0][4].ToString().Contains("Salı") ? true : false;
                    chk_Wednesday.Checked = table.Rows[0][4].ToString().Contains("Çarşamba") ? true : false;
                    chk_Thursday.Checked = table.Rows[0][4].ToString().Contains("Perşembe") ? true : false;
                    chk_Friday.Checked = table.Rows[0][4].ToString().Contains("Cuma") ? true : false;
                    chk_Saturday.Checked = table.Rows[0][4].ToString().Contains("Cumartesi") ? true : false;
                    chk_Sunday.Checked = table.Rows[0][4].ToString()
                        .Split(',')
                        .Any(day => day.Trim() == "Pazar");
                    chk_BackDelete.Checked = table.Rows[0][5].ToString() =="1" ? true : false;

                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Yedekleme Bilgileri Okunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.Message);
                status = false;
            }
        }
        private void btn_NotEye_Click(object sender, EventArgs e)
        {
            txt_WinrarPassword.Focus();
            btn_Eye.Visible = true;
            btn_NotEye.Visible = false;
            txt_WinrarPassword.Properties.PasswordChar = '*';
        }
        private void btn_Eye_Click(object sender, EventArgs e)
        {
            txt_WinrarPassword.Focus();
            btn_Eye.Visible = false;
            btn_NotEye.Visible = true;
            txt_WinrarPassword.Properties.PasswordChar = '\0';
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (BackUpSettingsManager.BackUpSettingControl(txt_FolderBackUp, txt_WinrarFolder))
            {
                if (chk_Monday.Checked == false && chk_Tuesday.Checked == false && chk_Wednesday.Checked == false && chk_Thursday.Checked == false && chk_Friday.Checked == false && chk_Saturday.Checked == false && chk_Sunday.Checked == false)
                {
                    XtraMessageBox.Show("Günlerden En Az Biri Seçilmelidir", "Hatalı Gün Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string days = default;
                    days += chk_Monday.Checked ? "Pazartesi," : "";
                    days += chk_Tuesday.Checked ? "Salı," : "";
                    days += chk_Wednesday.Checked ? "Çarşamba," : "";
                    days += chk_Thursday.Checked ? "Perşembe," : "";
                    days += chk_Friday.Checked ? "Cuma," : "";
                    days += chk_Saturday.Checked ? "Cumartesi," : "";
                    days += chk_Sunday.Checked ? "Pazar," : "";
                    if (days.Length > 0)
                        days = days.Substring(0, days.Length - 1);
                    if (status == true)
                    {
                        string message = SQLLiteConnection.InserUpdateDelete("UPDATE DbBackUpSettings SET BackUpTime='" + Convert.ToDateTime(timeEdit1.EditValue).ToString("HH:mm:ss") + "',BackUpFolder='" + txt_FolderBackUp.Text + "',WinrarFolder='" + txt_WinrarFolder.Text + "',WinrarPassword='" + EncryptionHelper.Encrypt(txt_WinrarPassword.Text) + "', Days='" + days + "',BackUpDelete=" + (chk_BackDelete.Checked==true?1:0)+"");
                        if (message == "Başarılı")
                            XtraMessageBox.Show("Yedek Alma Ayarları Güncelleme İşlemi Başarılı", "Başarılı Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            XtraMessageBox.Show(message, "Hatalı Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TextLog.TextLogging(message);
                        }
                    }
                    else
                    {
                        string message = SQLLiteConnection.InserUpdateDelete("INSERT INTO DbBackUpSettings (BackUpTime,BackUpFolder,WinrarFolder,WinrarPassword,Days,BackUpDelete) VALUES ('" + Convert.ToDateTime(timeEdit1.EditValue).ToString("HH:mm:ss") + "','" + txt_FolderBackUp.Text + "','" +txt_WinrarFolder.Text + "','" + EncryptionHelper.Encrypt(txt_WinrarPassword.Text) + "','" + days + "'," + (chk_BackDelete.Checked == true ? 1 : 0) +")");
                        if (message == "Başarılı")
                            XtraMessageBox.Show("Yedek Alma Ayarları Ekleme İşlemi Başarılı", "Başarılı Ekleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            XtraMessageBox.Show(message, "Hatalı Ekleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TextLog.TextLogging(message);
                        }
                        status = true;
                    }
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            string winrarPath = @"C:\Program Files\WinRAR\";
            if (Directory.Exists(winrarPath))
            {
                txt_WinrarFolder.Text = @"C:\Program Files\WinRAR\Rar.exe";
            }
            else
            {
                XtraMessageBox.Show("Winrar Sistemde Kurulu Değil Lütfen Önce Winrarı Kurunuz", "Winrar Kur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("https://www.rarlab.com/download.htm");
            }
        }
    }
}