using System;
using System.Windows.Forms;

namespace AsyenOtomatikYedekleme.Forms
{
    public partial class SplashScreenLoading : DevExpress.XtraEditors.XtraForm
    {
        public SplashScreenLoading()
        {
            InitializeComponent();
        }
        private void SplashScreenLoading_Load(object sender, EventArgs e)
        {
            labelCopyright.Text = $"Copyright© {DateTime.Now.Year} Asyen Bilişim, Tüm Hakları Saklıdır";
        }
        private void SplashScreenLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}