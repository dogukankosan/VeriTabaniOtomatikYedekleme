using AsyenOtomatikYedekleme.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AsyenOtomatikYedekleme.Forms
{
    public partial class AboutForm : DevExpress.XtraEditors.XtraForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        private void AboutForm_Load(object sender, EventArgs e)
        {
            SQLLiteConnection cn = new SQLLiteConnection();
            cn.LoadDataIntoGridView(gridControl1, "SELECT  UserName 'Yetkili Ad Soyad',Phone 'Telefon',[E-Mail] FROM About");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.asyendestek.com.tr/Account/Login/1",
                UseShellExecute = true
            });
        }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string cellValue = gridView1.GetRowCellDisplayText(e.RowHandle, e.Column);
            if (e.Column.FieldName == "E-Mail")
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = $"mailto:{cellValue}",
                    UseShellExecute = true
                });
            }
            else if (e.Column.FieldName == "Telefon")
            {
                string phoneNumber = cellValue; // Telefon numarasının formatını doğrulamak gerekebilir
                Process.Start(new ProcessStartInfo
                {
                    FileName = $"https://wa.me/{phoneNumber}",
                    UseShellExecute = true
                });
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "E-Mail" || e.Column.FieldName == "Telefon")
            {
                e.Appearance.ForeColor = Color.Blue;
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Underline);
            }
        }
        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null)
                return;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if ((hitInfo.Column != null && (hitInfo.Column.FieldName == "E-Mail" || hitInfo.Column.FieldName == "Telefon")) && hitInfo.InRowCell)
            {
                view.GridControl.Cursor = Cursors.Hand;
                if (hitInfo.Column.FieldName == "E-Mail")
                    toolTip1.SetToolTip(gridControl1, "E-Mail İle Aç");
                else if (hitInfo.Column.FieldName == "Telefon")
                    toolTip1.SetToolTip(gridControl1, "Whatsapp İle Aç");
            }
            else
                view.GridControl.Cursor = Cursors.Default;
        }
        private void gridView1_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Asyen Destek Portalına Git");
        }
    }
}