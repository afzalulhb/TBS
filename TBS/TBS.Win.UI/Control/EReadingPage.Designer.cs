namespace TBS.Win.UI.Control
{
    partial class EReadingPage
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCurrent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpRange = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPrevious = new System.Windows.Forms.TextBox();
            this.cboMeter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Current reading :";
            // 
            // tbxCurrent
            // 
            this.tbxCurrent.Location = new System.Drawing.Point(213, 180);
            this.tbxCurrent.Name = "tbxCurrent";
            this.tbxCurrent.Size = new System.Drawing.Size(125, 20);
            this.tbxCurrent.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(101, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 15);
            this.label11.TabIndex = 56;
            this.label11.Text = "Meter number :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(213, 86);
            this.dtpEndDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(137, 20);
            this.dtpEndDate.TabIndex = 55;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 54;
            this.label10.Text = "End date :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(213, 60);
            this.dtpStartDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(137, 20);
            this.dtpStartDate.TabIndex = 53;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "Start date :";
            // 
            // dtpRange
            // 
            this.dtpRange.CustomFormat = "MMM yyyy";
            this.dtpRange.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRange.Location = new System.Drawing.Point(213, 31);
            this.dtpRange.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpRange.Name = "dtpRange";
            this.dtpRange.Size = new System.Drawing.Size(105, 20);
            this.dtpRange.TabIndex = 51;
            this.dtpRange.ValueChanged += new System.EventHandler(this.dtpRange_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Previous reading :";
            // 
            // tbxPrevious
            // 
            this.tbxPrevious.Location = new System.Drawing.Point(212, 148);
            this.tbxPrevious.Name = "tbxPrevious";
            this.tbxPrevious.Size = new System.Drawing.Size(126, 20);
            this.tbxPrevious.TabIndex = 49;
            // 
            // cboMeter
            // 
            this.cboMeter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeter.FormattingEnabled = true;
            this.cboMeter.Location = new System.Drawing.Point(212, 117);
            this.cboMeter.Name = "cboMeter";
            this.cboMeter.Size = new System.Drawing.Size(227, 21);
            this.cboMeter.TabIndex = 48;
            this.cboMeter.SelectedIndexChanged += new System.EventHandler(this.cboMeter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Select a range :";
            // 
            // EReadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCurrent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpRange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxPrevious);
            this.Controls.Add(this.cboMeter);
            this.Controls.Add(this.label1);
            this.Name = "EReadingPage";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cboMeter, 0);
            this.Controls.SetChildIndex(this.tbxPrevious, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dtpRange, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.dtpEndDate, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.tbxCurrent, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCurrent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpRange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPrevious;
        private System.Windows.Forms.ComboBox cboMeter;
        private System.Windows.Forms.Label label1;
    }
}