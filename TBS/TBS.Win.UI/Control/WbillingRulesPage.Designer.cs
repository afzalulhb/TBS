namespace TBS.Win.UI.Control
{
    partial class WbillingRulesPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRate = new System.Windows.Forms.TextBox();
            this.tbxVat = new System.Windows.Forms.TextBox();
            this.tbxServiceCharge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Billing Rules";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "Rate/Unit :";
            // 
            // tbxRate
            // 
            this.tbxRate.Location = new System.Drawing.Point(160, 84);
            this.tbxRate.Name = "tbxRate";
            this.tbxRate.Size = new System.Drawing.Size(91, 20);
            this.tbxRate.TabIndex = 55;
            this.tbxRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRate_KeyPress);
            // 
            // tbxVat
            // 
            this.tbxVat.Location = new System.Drawing.Point(407, 173);
            this.tbxVat.Name = "tbxVat";
            this.tbxVat.Size = new System.Drawing.Size(91, 20);
            this.tbxVat.TabIndex = 75;
            this.tbxVat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVat_KeyPress);
            // 
            // tbxServiceCharge
            // 
            this.tbxServiceCharge.Location = new System.Drawing.Point(160, 173);
            this.tbxServiceCharge.Name = "tbxServiceCharge";
            this.tbxServiceCharge.Size = new System.Drawing.Size(91, 20);
            this.tbxServiceCharge.TabIndex = 74;
            this.tbxServiceCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxServiceCharge_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 73;
            this.label9.Text = "VAT (%)  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 72;
            this.label10.Text = "Service Charge :";
            // 
            // WbillingRulesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxVat);
            this.Controls.Add(this.tbxServiceCharge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "WbillingRulesPage";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbxRate, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbxServiceCharge, 0);
            this.Controls.SetChildIndex(this.tbxVat, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRate;
        private System.Windows.Forms.TextBox tbxVat;
        private System.Windows.Forms.TextBox tbxServiceCharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}