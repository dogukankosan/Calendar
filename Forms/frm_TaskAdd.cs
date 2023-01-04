using Calendar.Classes;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Calendar.Forms
{
    public partial class frm_TaskAdd : DevExpress.XtraEditors.XtraForm
    {
        public frm_TaskAdd()
        {
            InitializeComponent();
        }
        internal DateTime chooseDateTime = default;
        private void frm_TaskAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void frm_TaskAdd_Load(object sender, System.EventArgs e)
        {
            Dt_Date.CustomFormat = "dd.MM.yyyy HH:mm";
            Dt_Date.Value = chooseDateTime;
        }
        private void Btn_Add_Click(object sender, System.EventArgs e)
        {
            if (DatabaseControl.TaskControl(Rch_Task,Dt_Date,chooseDateTime))
            {
                if (DialogResult.Yes == XtraMessageBox.Show("GÖREV TANIMLAMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "EKLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (GeneralSQLLite.CRUD("insert into Tbl_Task (TaskDesc,_Date) values ('" + Rch_Task.Text.Trim().ToUpper() + "','" + Dt_Date.Value + "')"))
                    {
                        XtraMessageBox.Show("GÖREV TANIMLAMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("GÖREV TANIMLAMA İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }
    }
}