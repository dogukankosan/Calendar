using System;
using System.Windows.Forms;
using Calendar.Classes;

namespace Calendar.Forms
{
    public partial class frm_GenericList : DevExpress.XtraEditors.XtraForm
    {
        public frm_GenericList()
        {
            InitializeComponent();
        }
        internal string sql = default;
        internal string formText = default;
        private void frm_GenericList_Load(object sender, EventArgs e)
        {
            Text = formText;
            gridControl1.DataSource=GeneralSQLLite.GeneraList(sql);
        }
        private void frm_GenericList_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}