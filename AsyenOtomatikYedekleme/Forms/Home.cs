using AsyenOtomatikYedekleme.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AsyenOtomatikYedekleme.Forms
{
    public partial class Home : XtraForm
    {
        public Home()
        {
            InitializeComponent();
        }
        private void SQLDbDeleteAndAdd()
        {
            SQLLiteConnection.InserUpdateDelete($"DELETE FROM DbNameBackup");
            GridView view = gridView1;
            for (int i = 0; i < view.RowCount; i++)
            {
                int rowHandle = view.GetRowHandle(i);
                DataRow row = view.GetDataRow(rowHandle);
                if (row == null)
                    continue;
                string column1Value = row["Veri Tabanı Adı"].ToString();
                SQLLiteConnection.InserUpdateDelete($"INSERT INTO DbNameBackup (DbName) VALUES ('{column1Value}') ");
            }
            XtraMessageBox.Show("Yedek Alınacak Veri Tabanları Başarılı Bir Şekilde Kaydedildi", "Başarılı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_BackUp_Click(object sender, EventArgs e)
        {
            BackUp backup = new BackUp();
            _ = backup.BackupDatabasesToSqlServerAsync(this, SQLLiteConnection.GetDataFromSQLite("SELECT DbName FROM DbNameBackup"), SQLServerConnection.ConnectionStringGet());
        }
        private void Home_Load(object sender, EventArgs e)
        {
            bool statusData = SQLLiteConnection.GetSqlConnectionControl("SELECT DbName 'Veri Tabanı Adı' FROM DbNameBackup DbName");
            if (statusData)
            {
                SQLLiteConnection sQLLiteConnection = new SQLLiteConnection();
                sQLLiteConnection.LoadDataIntoGridView(gridControl1, "SELECT DbName 'Veri Tabanı Adı' FROM DbNameBackup DbName");
            }
            else
            {
                SQLServerConnection connection = new SQLServerConnection();
                connection.LoadDataIntoGridView(gridControl1, "SELECT name 'Veri Tabanı Adı' FROM sys.databases WHERE name NOT IN ('master','tempdb','model','msdb')");
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length > 0)
            {
                gridView1.DeleteRow(gridView1.GetSelectedRows()[0]);
            }
            SQLDbDeleteAndAdd();
        }
        private void dbGetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLServerConnection connection = new SQLServerConnection();
            connection.LoadDataIntoGridView(gridControl1, "SELECT name 'Veri Tabanı Adı' FROM sys.databases WHERE name NOT IN ('master','tempdb','model','msdb')");
            SQLDbDeleteAndAdd();
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLDbDeleteAndAdd();
        }
        private void backUpSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUpSettingsForms backUpSettingscs = new BackUpSettingsForms();
            backUpSettingscs.ShowDialog();
        }
        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailSettingsForm mailSettingsForm = new MailSettingsForm();
            mailSettingsForm.ShowDialog();
        }
        private void Home_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ServiceSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string installUtilPath = Interaction.InputBox("İlgili .Net Sürümü Yoksa Kurunuz v4.0.30319", "Kontrol Ediniz:", @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe");
            string serviceExePath = Interaction.InputBox("Servis Uygulamasının Kurulu Olduğu Dizin:", "Giriniz:", @"DosyaYolu\VeriTabaniYedeklemeServis");

            if (string.IsNullOrWhiteSpace(serviceExePath))
            {
                XtraMessageBox.Show("Geçerli Bir Servis Dizini Girmelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = installUtilPath,
                Arguments = $"\"{serviceExePath + "\\VeriTabaniYedeklemeServis.exe"}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (process.ExitCode == 0 && string.IsNullOrEmpty(error))
                {
                    XtraMessageBox.Show($"Servis Başarıyla Kaydedildi.\nÇıktı: {output}", "Servis Kaydı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var configFile = serviceExePath + "\\VeriTabaniYedeklemeServis.exe.config";
                    XDocument configXml = XDocument.Load(configFile);
                    var connectionStrings = configXml.Root.Element("connectionStrings");
                    if (connectionStrings != null)
                    {
                        var connectionStringElement = connectionStrings.Elements("add").FirstOrDefault(x => x.Attribute("name").Value == "SQLiteConnectionString");
                        if (connectionStringElement != null)
                        {
                            connectionStringElement.Attribute("connectionString").Value = SQLLiteConnection.connectionString;
                            configXml.Save(configFile);
                        }
                        else
                        {
                            XtraMessageBox.Show("Connection String Bulunamadı.", "SQLITE Connection String Kaydedilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TextLog.TextLogging("Servis Confige ConnectionString Kaydedilemedi");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("ConnectionStrings Bölümü Bulunamadı.", "SQLITE Connection String Kaydedilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextLog.TextLogging("Servis Confige ConnectionString Kaydedilemedi Yada Bulamadı");
                    }
                }
                else
                {
                    XtraMessageBox.Show($"Servis kaydedilemedi.\nHata: {error}\nÇıktı: {output}", "Servis Kaydı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void serviceDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string serviceName = "Veri Tabanı Yedekleme Servis";
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c sc query \"{serviceName}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (output.Contains("RUNNING"))
                {
                    process.StartInfo.Arguments = $"/c net stop \"{serviceName}\"";
                    process.Start();
                    output = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (string.IsNullOrEmpty(error))
                    {
                        XtraMessageBox.Show($"Servis Başarıyla Durduruldu.\nÇıktı: {output}", "Servis Durdurma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show($"Servis Durdurulamadı.\nHata: {error}", "Servis Durdurma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Servis Zaten Durdurulmuş.", "Servis Durumu Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                process.StartInfo.Arguments = $"/c sc delete \"{serviceName}\"";
                process.Start();
                output = process.StandardOutput.ReadToEnd();
                error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (string.IsNullOrEmpty(error))
                {
                    XtraMessageBox.Show($"Servis Başarıyla Silindi.\nÇıktı: {output}", "Servis Silme Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show($"Servis Silinemedi.\nHata: {error}", "Servis Silme Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void serviceStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string serviceName = "Veri Tabanı Yedekleme Servis";
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c sc query \"{serviceName}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (!output.Contains("RUNNING"))
                {
                    process.StartInfo.Arguments = $"/c net start \"{serviceName}\"";
                    process.Start();
                    output = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (string.IsNullOrEmpty(error))
                    {
                        XtraMessageBox.Show($"Servis Başarıyla Başlatıldı.\nÇıktı: {output}", "Servis Başlatma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show($"Servis Başlatılamadı.\nHata: {error}", "Servis Başlatma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Servis Zaten Çalışıyor.", "Servis Durumu Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void serviceStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string serviceName = "Veri Tabanı Yedekleme Servis";
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c sc query \"{serviceName}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (output.Contains("RUNNING"))
                {
                    process.StartInfo.Arguments = $"/c net stop \"{serviceName}\"";
                    process.Start();
                    output = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (process.ExitCode == 0 && string.IsNullOrEmpty(error))
                    {
                        XtraMessageBox.Show($"Servis Başarıyla Durduruldu.\nÇıktı: {output}", "Servis Durdurma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show($"Servis Durdurulamadı.\nHata: {error}", "Servis Durdurma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Servis Zaten Durdurulmuş.", "Servis Durumu Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}