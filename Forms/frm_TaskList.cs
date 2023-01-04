using Calendar.Classes;
using System;
using System.Windows.Forms;

namespace Calendar.Forms
{
    public partial class frm_TaskList : DevExpress.XtraEditors.XtraForm
    {
        public frm_TaskList()
        {
            InitializeComponent();
        }
        private void frm_TaskList_Load(object sender, EventArgs e)
        {
            calendarControl1.Multiselect = false;
            GeneralSQLLite.ListDate("select _Date from Tbl_Task where Status=0", calendarControl1);
        }
        private void frm_TaskList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void calendarControl1_MouseMove(object sender, MouseEventArgs e)
        {
            GeneralSQLLite.ListDate("select _Date from Tbl_Task where Status=0 order by _Date", calendarControl1);
        }
        private void calendarControl1_DoubleClick(object sender, EventArgs e)
        {
            frm_TaskWhereList fr = new ();
            fr.sql = "select ID, TaskDesc as 'GOREV_ACIKLAMA',_Date as 'TARIH' from Tbl_Task where Status=0 and _Date like '%" + calendarControl1.SelectionEnd.AddDays(-1).ToShortDateString() + "%'";
            fr.ShowDialog();
        }
    }
}