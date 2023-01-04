using Calendar.Classes;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Calendar.Forms
{
    public partial class frm_Report : DevExpress.XtraEditors.XtraForm
    {
        public frm_Report()
        {
            InitializeComponent();
        }
        private void frm_Report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void frm_Report_Load(object sender, System.EventArgs e)
        {
            GeneralSQLLite.Db.Open();
            SQLiteCommand cmd = new("select count(ID) from Tbl_Task", GeneralSQLLite.Db);
            Lbl_TopCount.Text = cmd.ExecuteScalar().ToString();

            SQLiteCommand cmd1 = new("select count(ID) from Tbl_Task where Status=1", GeneralSQLLite.Db);
            Lbl_TaskAccept.Text = cmd1.ExecuteScalar().ToString();

            SQLiteCommand cmd2 = new("select count(ID) from Tbl_Task where Status=0", GeneralSQLLite.Db);
            Lbl_NotTask.Text = cmd2.ExecuteScalar().ToString();

            SQLiteCommand cmd3 = new("select count(ID) from Tbl_Task where Status=0 and _Date like '%" + DateTime.Now.ToShortDateString() + "%'", GeneralSQLLite.Db);
            Lbl_TodayList.Text = cmd3.ExecuteScalar().ToString();

            SQLiteCommand cmd4 = new("select count(ID) from Tbl_Task where Status=1 and _Date like '%" + DateTime.Now.ToShortDateString() + "%'", GeneralSQLLite.Db);
            Lbl_TodayAccept.Text = cmd4.ExecuteScalar().ToString();

            GeneralSQLLite.Db.Close();
        }
    }
}