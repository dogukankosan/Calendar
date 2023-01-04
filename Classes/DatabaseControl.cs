using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Calendar.Classes
{
    internal class DatabaseControl
    {
        internal static bool TaskControl(RichTextBox taskDesc, DateTimePicker dtPickerValue, DateTime chooseDateTime)
        {
            #region TASKDESC
            if (string.IsNullOrEmpty(taskDesc.Text))
            {
                XtraMessageBox.Show("GÖREV BİLGİSİ METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taskDesc.Focus();
                return false;
            }
            if (taskDesc.Text.Length < 5)
            {
                XtraMessageBox.Show("GÖREV TANIMLA EN FAZ 5 KARAKTERDEN OLUŞMAKTADIR !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                taskDesc.Focus();
                return false;
            }
            #endregion
            #region DATETIME
            if (dtPickerValue.Value.Year != chooseDateTime.Year || dtPickerValue.Value.Month != chooseDateTime.Month || dtPickerValue.Value.Day != chooseDateTime.Day)
            {
                XtraMessageBox.Show(
                    "TAKVİMDEN SEÇİLEN TARİH İLE SEÇTİĞİNİZ TARİH FARKLI LÜTFEN SADECE SAAT BÖLÜMÜNÜ DEĞİŞTİRİNİZ !!",
                    "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtPickerValue.Focus();
                return false;
            }
            #endregion
            return true;
        }
    }
}