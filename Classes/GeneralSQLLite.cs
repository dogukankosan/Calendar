using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Calendar.Classes
{
    internal class GeneralSQLLite
    {
        internal static readonly SQLiteConnection Db = new($"Data source={Application.StartupPath}\\Database\\Calendar.db;Versiyon=3");
        internal static bool CRUD(string sql)
        {
            Db.Open();
            SQLiteCommand cmd = new(sql, Db);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI DATABASE İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Db.Close();
                return false;
            }
            Db.Close();
            return true;
        }
        internal static void Backup(string strDestination)
        {
            using (SQLiteConnection location = new($"Data source={Application.StartupPath}\\Database\\Calendar.db;Versiyon=3"))
            using (SQLiteConnection destination = new(string.Format(@"Data Source={0}\\Calendar.db; Version=3;", strDestination)))
            {
                location.Open();
                destination.Open();
                location.BackupDatabase(destination, "main", "main", -1, null, 0);
            }
        }
        internal static void ListDate(string sql, CalendarControl mtCalendar)
        {
            Db.Open();
            SQLiteCommand cmd = new(sql, Db);
            try
            {
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    mtCalendar.AddSelection(DateTime.Parse(rd[0].ToString()));
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI DATABASE OKUMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Db.Close();
        }
        internal static DataTable GeneraList(string sql)
        {
            SQLiteDataAdapter da = new(sql, Db);
            DataSet ds = new();
            try
            {
                da.Fill(ds);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "HATALI DATABASE OKUMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return ds.Tables[0];
        }
    }
}