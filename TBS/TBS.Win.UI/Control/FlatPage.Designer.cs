namespace TBS.Win.UI.Control
{
    partial class FlatPage
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
            this.chklstUtility = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chklstMeter = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxRent = new System.Windows.Forms.TextBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.cboApartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLstWMeter = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // chklstUtility
            // 
            this.chklstUtility.FormattingEnabled = true;
            this.chklstUtility.Location = new System.Drawing.Point(107, 203);
            this.chklstUtility.Name = "chklstUtility";
            this.chklstUtility.Size = new System.Drawing.Size(213, 79);
            this.chklstUtility.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Utilities :";
            // 
            // chklstMeter
            // 
            this.chklstMeter.FormattingEnabled = true;
            this.chklstMeter.Location = new System.Drawing.Point(107, 118);
            this.chklstMeter.Name = "chklstMeter";
            this.chklstMeter.Size = new System.Drawing.Size(213, 79);
            this.chklstMeter.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Rent :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Meter(s) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Code :";
            // 
            // tbxRent
            // 
            this.tbxRent.Location = new System.Drawing.Point(107, 86);
            this.tbxRent.Name = "tbxRent";
            this.tbxRent.Size = new System.Drawing.Size(215, 20);
            this.tbxRent.TabIndex = 23;
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(107, 58);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(215, 20);
            this.tbxCode.TabIndex = 22;
            // 
            // cboApartment
            // 
            this.cboApartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApartment.FormattingEnabled = true;
            this.cboApartment.Location = new System.Drawing.Point(178, 14);
            this.cboApartment.Name = "cboApartment";
            this.cboApartment.Size = new System.Drawing.Size(227, 21);
            this.cboApartment.TabIndex = 21;
            this.cboApartment.SelectedIndexChanged += new System.EventHandler(this.cboApartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select an apartment :";
            // 
            // chkLstWMeter
            // 
            this.chkLstWMeter.FormattingEnabled = true;
            this.chkLstWMeter.Location = new System.Drawing.Point(360, 118);
            this.chkLstWMeter.Name = "chkLstWMeter";
            this.chkLstWMeter.Size = new System.Drawing.Size(120, 79);
            this.chkLstWMeter.TabIndex = 30;
            // 
            // FlatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkLstWMeter);
            this.Controls.Add(this.chklstUtility);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chklstMeter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxRent);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.cboApartment);
            this.Controls.Add(this.label1);
            this.Name = "FlatPage";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cboApartment, 0);
            this.Controls.SetChildIndex(this.tbxCode, 0);
            this.Controls.SetChildIndex(this.tbxRent, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.chklstMeter, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.chklstUtility, 0);
            this.Controls.SetChildIndex(this.chkLstWMeter, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstUtility;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chklstMeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxRent;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.ComboBox cboApartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkLstWMeter;
    }
}