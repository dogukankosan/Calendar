
namespace Calendar.Forms
{
    partial class frm_TaskAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaskAdd));
            this.Rch_Task = new System.Windows.Forms.RichTextBox();
            this.Dt_Date = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rch_Task
            // 
            this.Rch_Task.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.Rch_Task.Location = new System.Drawing.Point(122, 57);
            this.Rch_Task.MaxLength = 500;
            this.Rch_Task.Name = "Rch_Task";
            this.Rch_Task.Size = new System.Drawing.Size(303, 101);
            this.Rch_Task.TabIndex = 0;
            this.Rch_Task.Text = "";
            // 
            // Dt_Date
            // 
            this.Dt_Date.CustomFormat = "";
            this.Dt_Date.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.Dt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dt_Date.Location = new System.Drawing.Point(122, 175);
            this.Dt_Date.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.Dt_Date.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Dt_Date.Name = "Dt_Date";
            this.Dt_Date.Size = new System.Drawing.Size(303, 32);
            this.Dt_Date.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "GÖREV";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.Btn_Add);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Rch_Task);
            this.groupControl1.Controls.Add(this.Dt_Date);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(430, 266);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "GÖREV TANIMLAMA";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Appearance.BackColor = System.Drawing.Color.White;
            this.Btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.Btn_Add.Appearance.Options.UseBackColor = true;
            this.Btn_Add.Appearance.Options.UseFont = true;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Add.ImageOptions.SvgImage")));
            this.Btn_Add.Location = new System.Drawing.Point(2, 226);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(426, 38);
            this.Btn_Add.TabIndex = 2;
            this.Btn_Add.Text = "GÖREVİ KAYDET";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "TARİH";
            // 
            // frm_TaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(459, 288);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_TaskAdd.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_TaskAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GÖREV TANIMLA";
            this.Load += new System.EventHandler(this.frm_TaskAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TaskAdd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rch_Task;
        private System.Windows.Forms.DateTimePicker Dt_Date;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
    }
}