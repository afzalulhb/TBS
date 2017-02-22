namespace TBS.Win.UI
{
    partial class frmWinUI
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
            this.pnlMainNav = new System.Windows.Forms.Panel();
            this.btnWBR = new System.Windows.Forms.Button();
            this.btnWReading = new System.Windows.Forms.Button();
            this.btnEBillingRules = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnOtherCharges = new System.Windows.Forms.Button();
            this.btnEReading = new System.Windows.Forms.Button();
            this.bntEMeter = new System.Windows.Forms.Button();
            this.btnApartment = new System.Windows.Forms.Button();
            this.btnTenant = new System.Windows.Forms.Button();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.btnWMeter = new System.Windows.Forms.Button();
            this.pnlMainNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainNav
            // 
            this.pnlMainNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainNav.Controls.Add(this.btnWMeter);
            this.pnlMainNav.Controls.Add(this.btnWBR);
            this.pnlMainNav.Controls.Add(this.btnWReading);
            this.pnlMainNav.Controls.Add(this.btnEBillingRules);
            this.pnlMainNav.Controls.Add(this.btnInvoice);
            this.pnlMainNav.Controls.Add(this.btnOtherCharges);
            this.pnlMainNav.Controls.Add(this.btnEReading);
            this.pnlMainNav.Controls.Add(this.bntEMeter);
            this.pnlMainNav.Controls.Add(this.btnApartment);
            this.pnlMainNav.Controls.Add(this.btnTenant);
            this.pnlMainNav.Location = new System.Drawing.Point(12, 12);
            this.pnlMainNav.Name = "pnlMainNav";
            this.pnlMainNav.Size = new System.Drawing.Size(165, 374);
            this.pnlMainNav.TabIndex = 1;
            // 
            // btnWBR
            // 
            this.btnWBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWBR.Location = new System.Drawing.Point(10, 266);
            this.btnWBR.Name = "btnWBR";
            this.btnWBR.Size = new System.Drawing.Size(143, 33);
            this.btnWBR.TabIndex = 8;
            this.btnWBR.Text = "W. Billing Rules";
            this.btnWBR.UseVisualStyleBackColor = true;
            this.btnWBR.Click += new System.EventHandler(this.btnWBR_Click);
            // 
            // btnWReading
            // 
            this.btnWReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWReading.Location = new System.Drawing.Point(9, 231);
            this.btnWReading.Name = "btnWReading";
            this.btnWReading.Size = new System.Drawing.Size(143, 33);
            this.btnWReading.TabIndex = 7;
            this.btnWReading.Text = "Water Reading";
            this.btnWReading.UseVisualStyleBackColor = true;
            this.btnWReading.Click += new System.EventHandler(this.btnWReading_Click);
            // 
            // btnEBillingRules
            // 
            this.btnEBillingRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEBillingRules.Location = new System.Drawing.Point(10, 122);
            this.btnEBillingRules.Name = "btnEBillingRules";
            this.btnEBillingRules.Size = new System.Drawing.Size(143, 33);
            this.btnEBillingRules.TabIndex = 6;
            this.btnEBillingRules.Text = "E. Billing Rules";
            this.btnEBillingRules.UseVisualStyleBackColor = true;
            this.btnEBillingRules.Click += new System.EventHandler(this.btnEBillingRules_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.Location = new System.Drawing.Point(10, 336);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(143, 33);
            this.btnInvoice.TabIndex = 5;
            this.btnInvoice.Text = "Report";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnOtherCharges
            // 
            this.btnOtherCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherCharges.Location = new System.Drawing.Point(10, 301);
            this.btnOtherCharges.Name = "btnOtherCharges";
            this.btnOtherCharges.Size = new System.Drawing.Size(143, 33);
            this.btnOtherCharges.TabIndex = 4;
            this.btnOtherCharges.Text = "Other Charges";
            this.btnOtherCharges.UseVisualStyleBackColor = true;
            this.btnOtherCharges.Click += new System.EventHandler(this.btnOtherCharges_Click);
            // 
            // btnEReading
            // 
            this.btnEReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEReading.Location = new System.Drawing.Point(9, 159);
            this.btnEReading.Name = "btnEReading";
            this.btnEReading.Size = new System.Drawing.Size(143, 33);
            this.btnEReading.TabIndex = 3;
            this.btnEReading.Text = "Electric Reading";
            this.btnEReading.UseVisualStyleBackColor = true;
            this.btnEReading.Click += new System.EventHandler(this.btnEReading_Click);
            // 
            // bntEMeter
            // 
            this.bntEMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEMeter.Location = new System.Drawing.Point(9, 85);
            this.bntEMeter.Name = "bntEMeter";
            this.bntEMeter.Size = new System.Drawing.Size(143, 33);
            this.bntEMeter.TabIndex = 2;
            this.bntEMeter.Text = "Electric Meter";
            this.bntEMeter.UseVisualStyleBackColor = true;
            this.bntEMeter.Click += new System.EventHandler(this.bntEMeter_Click);
            // 
            // btnApartment
            // 
            this.btnApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartment.Location = new System.Drawing.Point(10, 48);
            this.btnApartment.Name = "btnApartment";
            this.btnApartment.Size = new System.Drawing.Size(143, 33);
            this.btnApartment.TabIndex = 1;
            this.btnApartment.Text = "Apartment";
            this.btnApartment.UseVisualStyleBackColor = true;
            this.btnApartment.Click += new System.EventHandler(this.btnApartment_Click);
            // 
            // btnTenant
            // 
            this.btnTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenant.Location = new System.Drawing.Point(9, 11);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(143, 33);
            this.btnTenant.TabIndex = 0;
            this.btnTenant.Text = "Tenant";
            this.btnTenant.UseVisualStyleBackColor = true;
            this.btnTenant.Click += new System.EventHandler(this.btnTenant_Click);
            // 
            // pnlPage
            // 
            this.pnlPage.AutoSize = true;
            this.pnlPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPage.Location = new System.Drawing.Point(228, 12);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(0, 0);
            this.pnlPage.TabIndex = 2;
            // 
            // btnWMeter
            // 
            this.btnWMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWMeter.Location = new System.Drawing.Point(10, 195);
            this.btnWMeter.Name = "btnWMeter";
            this.btnWMeter.Size = new System.Drawing.Size(143, 33);
            this.btnWMeter.TabIndex = 9;
            this.btnWMeter.Text = "Water Meter";
            this.btnWMeter.UseVisualStyleBackColor = true;
            this.btnWMeter.Click += new System.EventHandler(this.btnWMeter_Click);
            // 
            // frmWinUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 402);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.pnlMainNav);
            this.Name = "frmWinUI";
            this.Text = "Tenant Management System";
            this.pnlMainNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainNav;
        private System.Windows.Forms.Button btnEBillingRules;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnOtherCharges;
        private System.Windows.Forms.Button btnEReading;
        private System.Windows.Forms.Button bntEMeter;
        private System.Windows.Forms.Button btnApartment;
        private System.Windows.Forms.Button btnTenant;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Button btnWBR;
        private System.Windows.Forms.Button btnWReading;
        private System.Windows.Forms.Button btnWMeter;
    }
}

