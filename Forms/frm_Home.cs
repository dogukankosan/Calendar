using Calendar.Classes;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Calendar.Forms
{
    public partial class frm_Home : DevExpress.XtraEditors.XtraForm
    {
        public frm_Home()
        {
            InitializeComponent();
        }
        private void frm_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void frm_Home_Load(object sender, EventArgs e)
        {

        }
        private void frm_Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void yEDEKALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fr = new();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(fr.SelectedPath))
                {
                    GeneralSQLLite.Backup(fr.SelectedPath);
                    XtraMessageBox.Show("YEDEK ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("YEDEK ALMA İŞLEMİ BAŞARISIZ YOL SEÇİLMEDİ !!", "BAŞARISIZ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void gÖREVLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TaskList fr = new();
            fr.ShowDialog();
        }
        private void gÖREVEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TaskAddList fr = new();
            fr.ShowDialog();
        }
        private void bUGÜNKÜGÖREVLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TodayList fr = new ();
            fr.sql = "select ID, TaskDesc as 'GOREV_ACIKLAMA',_Date as 'TARIH' from Tbl_Task where Status=0 and _Date like '%"+DateTime.Now.ToShortDateString()+"%'";
            fr.ShowDialog();
        }
        private void genelRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Report fr = new ();
            fr.ShowDialog();
        }
        private void tAMAMLANMIŞGÖREVLERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_GenericList fr = new();
            fr.formText = "TAMAMLANMIŞ GÖREVLER";
            fr.sql = "select TaskDesc as 'GOREV_ACIKLAMA',_Date as 'TARIH' from Tbl_Task where Status=1 order by _Date desc";
            fr.ShowDialog();
        }
        private void tAMAMLANMAMIŞGÖREVLERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_GenericList fr = new();
            fr.formText = "TAMAMLANMAMIŞ GÖREVLER";
            fr.sql = "select TaskDesc as 'GOREV_ACIKLAMA',_Date as 'TARIH' from Tbl_Task where Status=0 order by _Date desc";
            fr.ShowDialog();
        }
    }
}