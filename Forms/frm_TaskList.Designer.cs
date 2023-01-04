
namespace Calendar.Forms
{
    partial class frm_TaskList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaskList));
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarControl1.DrawCellLines = true;
            this.calendarControl1.Location = new System.Drawing.Point(0, 0);
            this.calendarControl1.MaxValue = new System.DateTime(2025, 12, 31, 23, 59, 0, 0);
            this.calendarControl1.MinValue = new System.DateTime(2022, 1, 1, 23, 59, 0, 0);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple;
            this.calendarControl1.Size = new System.Drawing.Size(520, 267);
            this.calendarControl1.TabIndex = 0;
            this.calendarControl1.DoubleClick += new System.EventHandler(this.calendarControl1_DoubleClick);
            this.calendarControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.calendarControl1_MouseMove);
            // 
            // frm_TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 267);
            this.Controls.Add(this.calendarControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_TaskList.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_TaskList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GÖREV LİSTESİ";
            this.Load += new System.EventHandler(this.frm_TaskList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TaskList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
    }
}