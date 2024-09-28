using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AsyenOtomatikYedekleme.Classes
{
    internal class WinrarManager
    {
        internal static void CompressAndEncrypt(string filePath, string rarFilePath, string winrarPath, string password)
        {
            string arguments = "";
            if (string.IsNullOrEmpty(EncryptionHelper.Decrypt(password)))
                 arguments = $"a -m2 \"{rarFilePath}\" \"{filePath}\"";
            else
                arguments = $"a -m2 -hp{EncryptionHelper.Decrypt(password)} \"{rarFilePath}\" \"{filePath}\"";
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = winrarPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                using (Process process = Process.Start(processStartInfo))
                {
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Winrar Alma İşlemi Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.Message);
            }
        }
    }
}