using Calendar.Classes;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Calendar.Forms
{
    public partial class frm_TaskWhereList : DevExpress.XtraEditors.XtraForm
    {
        public frm_TaskWhereList()
        {
            InitializeComponent();
        }
        internal string sql = default;
        private void frm_TaskWhereList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void frm_TaskWhereList_Load(object sender, System.EventArgs e)
        {
            gridControl1.DataSource = GeneralSQLLite.GeneraList(sql);
            gridView1.Columns["ID"].Visible = false;
        }
        private void görevTamamlandıToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") is not null)
            {
                if (XtraMessageBox.Show("GÖREVİ TAMAMLANMIŞ OLARAK İŞARETLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "TAMAMLANMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GeneralSQLLite.CRUD("UPDATE Tbl_Task SET Status=1 WHERE ID=" + gridView1.GetFocusedRowCellValue("ID") + ""))
                    {
                        XtraMessageBox.Show("GÖREV BAŞARILI BİR ŞEKİLDE TAMAMLANDI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        gridControl1.DataSource = GeneralSQLLite.GeneraList(sql);
                    }
                }
            }
            else
                XtraMessageBox.Show("HİÇ BİR İFADE SEÇİLMEMİŞ LÜTFEN SEÇİM YAPINIZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}