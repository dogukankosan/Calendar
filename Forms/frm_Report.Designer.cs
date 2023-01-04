
namespace Calendar.Forms
{
    partial class frm_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Report));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_TopCount = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_NotTask = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TaskAccept = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Lbl_TodayList = new DevExpress.XtraEditors.LabelControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Lbl_TodayAccept = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.Lbl_TopCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOPLAM GÖREV SAYISI";
            // 
            // Lbl_TopCount
            // 
            this.Lbl_TopCount.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_TopCount.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TopCount.Appearance.Options.UseFont = true;
            this.Lbl_TopCount.Appearance.Options.UseForeColor = true;
            this.Lbl_TopCount.Location = new System.Drawing.Point(90, 23);
            this.Lbl_TopCount.Name = "Lbl_TopCount";
            this.Lbl_TopCount.Size = new System.Drawing.Size(9, 17);
            this.Lbl_TopCount.TabIndex = 1;
            this.Lbl_TopCount.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.Lbl_NotTask);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TAMAMLANMAMIŞ GÖREV SAYISI";
            // 
            // Lbl_NotTask
            // 
            this.Lbl_NotTask.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_NotTask.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_NotTask.Appearance.Options.UseFont = true;
            this.Lbl_NotTask.Appearance.Options.UseForeColor = true;
            this.Lbl_NotTask.Location = new System.Drawing.Point(90, 19);
            this.Lbl_NotTask.Name = "Lbl_NotTask";
            this.Lbl_NotTask.Size = new System.Drawing.Size(9, 17);
            this.Lbl_NotTask.TabIndex = 1;
            this.Lbl_NotTask.Text = "0";
            // 
            // Lbl_TaskAccept
            // 
            this.Lbl_TaskAccept.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_TaskAccept.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TaskAccept.Appearance.Options.UseFont = true;
            this.Lbl_TaskAccept.Appearance.Options.UseForeColor = true;
            this.Lbl_TaskAccept.Location = new System.Drawing.Point(90, 19);
            this.Lbl_TaskAccept.Name = "Lbl_TaskAccept";
            this.Lbl_TaskAccept.Size = new System.Drawing.Size(9, 17);
            this.Lbl_TaskAccept.TabIndex = 1;
            this.Lbl_TaskAccept.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.Lbl_TaskAccept);
            this.groupBox3.Location = new System.Drawing.Point(12, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 46);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TAMAMLANMIŞ GÖREV SAYISI";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.Lbl_TodayList);
            this.groupBox4.Location = new System.Drawing.Point(12, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 46);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TAMAMLANMAMIŞ BUGUNKÜ GÖREVLER SAYISI";
            // 
            // Lbl_TodayList
            // 
            this.Lbl_TodayList.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_TodayList.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TodayList.Appearance.Options.UseFont = true;
            this.Lbl_TodayList.Appearance.Options.UseForeColor = true;
            this.Lbl_TodayList.Location = new System.Drawing.Point(90, 23);
            this.Lbl_TodayList.Name = "Lbl_TodayList";
            this.Lbl_TodayList.Size = new System.Drawing.Size(9, 17);
            this.Lbl_TodayList.TabIndex = 1;
            this.Lbl_TodayList.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox5.Controls.Add(this.Lbl_TodayAccept);
            this.groupBox5.Location = new System.Drawing.Point(12, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(197, 46);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TAMAMLANMIŞ BUGUNKÜ GÖREVLER SAYISI";
            // 
            // Lbl_TodayAccept
            // 
            this.Lbl_TodayAccept.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_TodayAccept.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TodayAccept.Appearance.Options.UseFont = true;
            this.Lbl_TodayAccept.Appearance.Options.UseForeColor = true;
            this.Lbl_TodayAccept.Location = new System.Drawing.Point(90, 23);
            this.Lbl_TodayAccept.Name = "Lbl_TodayAccept";
            this.Lbl_TodayAccept.Size = new System.Drawing.Size(9, 17);
            this.Lbl_TodayAccept.TabIndex = 1;
            this.Lbl_TodayAccept.Text = "0";
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 321);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_Report.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAPORLAMA";
            this.Load += new System.EventHandler(this.frm_Report_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Report_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl Lbl_TopCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl Lbl_TaskAccept;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl Lbl_NotTask;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.LabelControl Lbl_TodayList;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.LabelControl Lbl_TodayAccept;
    }
}