using System.Windows.Forms;

namespace Calendar.Forms
{
    public partial class frm_TaskAddList : DevExpress.XtraEditors.XtraForm
    {
        public frm_TaskAddList()
        {
            InitializeComponent();
        }
        private void frm_TaskAddList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            frm_TaskAdd fr = new ();
            fr.chooseDateTime = monthCalendar1.SelectionEnd;
            fr.ShowDialog();
        }
    }
}