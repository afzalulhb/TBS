namespace TBS.Win.UI.Control
{
    partial class ReportPage
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
            this.btnReport = new System.Windows.Forms.Button();
            this.dtpRange = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTenant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPrDate = new System.Windows.Forms.TextBox();
            this.tbxPreviousDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxpreReading = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCurReading = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxEC = new System.Windows.Forms.TextBox();
            this.tbxDC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxSC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxMC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxPA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxVat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxEmeter = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxWmeter1 = new System.Windows.Forms.TextBox();
            this.tbxpreReadingW1 = new System.Windows.Forms.TextBox();
            this.tbxCurReadingW1 = new System.Windows.Forms.TextBox();
            this.tbxWmeter2 = new System.Windows.Forms.TextBox();
            this.tbxpreReadingW2 = new System.Windows.Forms.TextBox();
            this.tbxCurReadingW2 = new System.Windows.Forms.TextBox();
            this.tbxW2 = new System.Windows.Forms.TextBox();
            this.tbxW1 = new System.Windows.Forms.TextBox();
            this.tbxEUnit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTunit = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblWbill = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblEbill = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblCleaner = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(360, 10);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(149, 26);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dtpRange
            // 
            this.dtpRange.CustomFormat = "MMM yyyy";
            this.dtpRange.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRange.Location = new System.Drawing.Point(249, 14);
            this.dtpRange.Name = "dtpRange";
            this.dtpRange.Size = new System.Drawing.Size(105, 20);
            this.dtpRange.TabIndex = 9;
            this.dtpRange.ValueChanged += new System.EventHandler(this.dtpRange_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Range :";
            // 
            // cboTenant
            // 
            this.cboTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenant.FormattingEnabled = true;
            this.cboTenant.Location = new System.Drawing.Point(65, 13);
            this.cboTenant.Name = "cboTenant";
            this.cboTenant.Size = new System.Drawing.Size(132, 21);
            this.cboTenant.TabIndex = 7;
            this.cboTenant.SelectedIndexChanged += new System.EventHandler(this.cboTenant_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tenant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Present Date:";
            // 
            // tbxPrDate
            // 
            this.tbxPrDate.Location = new System.Drawing.Point(93, 69);
            this.tbxPrDate.Name = "tbxPrDate";
            this.tbxPrDate.Size = new System.Drawing.Size(66, 20);
            this.tbxPrDate.TabIndex = 12;
            // 
            // tbxPreviousDate
            // 
            this.tbxPreviousDate.Location = new System.Drawing.Point(93, 93);
            this.tbxPreviousDate.Name = "tbxPreviousDate";
            this.tbxPreviousDate.Size = new System.Drawing.Size(66, 20);
            this.tbxPreviousDate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Previous Date:";
            // 
            // tbxpreReading
            // 
            this.tbxpreReading.Location = new System.Drawing.Point(258, 95);
            this.tbxpreReading.Name = "tbxpreReading";
            this.tbxpreReading.Size = new System.Drawing.Size(63, 20);
            this.tbxpreReading.TabIndex = 18;
            this.tbxpreReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Previous Reading:";
            // 
            // tbxCurReading
            // 
            this.tbxCurReading.Location = new System.Drawing.Point(258, 71);
            this.tbxCurReading.Name = "tbxCurReading";
            this.tbxCurReading.Size = new System.Drawing.Size(63, 20);
            this.tbxCurReading.TabIndex = 16;
            this.tbxCurReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Current Reading:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Current Charges";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(135, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Taka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Electricity Charge:";
            // 
            // tbxEC
            // 
            this.tbxEC.Location = new System.Drawing.Point(130, 163);
            this.tbxEC.Name = "tbxEC";
            this.tbxEC.Size = new System.Drawing.Size(53, 20);
            this.tbxEC.TabIndex = 22;
            this.tbxEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxDC
            // 
            this.tbxDC.Location = new System.Drawing.Point(130, 186);
            this.tbxDC.Name = "tbxDC";
            this.tbxDC.Size = new System.Drawing.Size(53, 20);
            this.tbxDC.TabIndex = 24;
            this.tbxDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Demand Charge:";
            // 
            // tbxSC
            // 
            this.tbxSC.Location = new System.Drawing.Point(130, 208);
            this.tbxSC.Name = "tbxSC";
            this.tbxSC.Size = new System.Drawing.Size(53, 20);
            this.tbxSC.TabIndex = 26;
            this.tbxSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Service Charge:";
            // 
            // tbxMC
            // 
            this.tbxMC.Location = new System.Drawing.Point(130, 231);
            this.tbxMC.Name = "tbxMC";
            this.tbxMC.Size = new System.Drawing.Size(53, 20);
            this.tbxMC.TabIndex = 28;
            this.tbxMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Minimum Charge:";
            // 
            // tbxPA
            // 
            this.tbxPA.Location = new System.Drawing.Point(130, 255);
            this.tbxPA.Name = "tbxPA";
            this.tbxPA.Size = new System.Drawing.Size(53, 20);
            this.tbxPA.TabIndex = 30;
            this.tbxPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Principal Amount:";
            // 
            // tbxVat
            // 
            this.tbxVat.Location = new System.Drawing.Point(130, 277);
            this.tbxVat.Name = "tbxVat";
            this.tbxVat.Size = new System.Drawing.Size(53, 20);
            this.tbxVat.TabIndex = 32;
            this.tbxVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "VAT: (5%)";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotal.Location = new System.Drawing.Point(130, 298);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(53, 20);
            this.tbxTotal.TabIndex = 34;
            this.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 302);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Bill Month Total:";
            // 
            // tbxEmeter
            // 
            this.tbxEmeter.Location = new System.Drawing.Point(258, 45);
            this.tbxEmeter.Name = "tbxEmeter";
            this.tbxEmeter.Size = new System.Drawing.Size(63, 20);
            this.tbxEmeter.TabIndex = 36;
            this.tbxEmeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "MeterNo:";
            // 
            // tbxWmeter1
            // 
            this.tbxWmeter1.Location = new System.Drawing.Point(336, 45);
            this.tbxWmeter1.Name = "tbxWmeter1";
            this.tbxWmeter1.Size = new System.Drawing.Size(63, 20);
            this.tbxWmeter1.TabIndex = 39;
            this.tbxWmeter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxpreReadingW1
            // 
            this.tbxpreReadingW1.Location = new System.Drawing.Point(336, 95);
            this.tbxpreReadingW1.Name = "tbxpreReadingW1";
            this.tbxpreReadingW1.Size = new System.Drawing.Size(63, 20);
            this.tbxpreReadingW1.TabIndex = 38;
            this.tbxpreReadingW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxCurReadingW1
            // 
            this.tbxCurReadingW1.Location = new System.Drawing.Point(336, 71);
            this.tbxCurReadingW1.Name = "tbxCurReadingW1";
            this.tbxCurReadingW1.Size = new System.Drawing.Size(63, 20);
            this.tbxCurReadingW1.TabIndex = 37;
            this.tbxCurReadingW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxWmeter2
            // 
            this.tbxWmeter2.Location = new System.Drawing.Point(424, 45);
            this.tbxWmeter2.Name = "tbxWmeter2";
            this.tbxWmeter2.Size = new System.Drawing.Size(63, 20);
            this.tbxWmeter2.TabIndex = 42;
            this.tbxWmeter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxpreReadingW2
            // 
            this.tbxpreReadingW2.Location = new System.Drawing.Point(424, 95);
            this.tbxpreReadingW2.Name = "tbxpreReadingW2";
            this.tbxpreReadingW2.Size = new System.Drawing.Size(63, 20);
            this.tbxpreReadingW2.TabIndex = 41;
            this.tbxpreReadingW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxCurReadingW2
            // 
            this.tbxCurReadingW2.Location = new System.Drawing.Point(424, 71);
            this.tbxCurReadingW2.Name = "tbxCurReadingW2";
            this.tbxCurReadingW2.Size = new System.Drawing.Size(63, 20);
            this.tbxCurReadingW2.TabIndex = 40;
            this.tbxCurReadingW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxW2
            // 
            this.tbxW2.Location = new System.Drawing.Point(424, 121);
            this.tbxW2.Name = "tbxW2";
            this.tbxW2.Size = new System.Drawing.Size(63, 20);
            this.tbxW2.TabIndex = 46;
            this.tbxW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxW1
            // 
            this.tbxW1.Location = new System.Drawing.Point(336, 121);
            this.tbxW1.Name = "tbxW1";
            this.tbxW1.Size = new System.Drawing.Size(63, 20);
            this.tbxW1.TabIndex = 45;
            this.tbxW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxEUnit
            // 
            this.tbxEUnit.Location = new System.Drawing.Point(258, 121);
            this.tbxEUnit.Name = "tbxEUnit";
            this.tbxEUnit.Size = new System.Drawing.Size(63, 20);
            this.tbxEUnit.TabIndex = 44;
            this.tbxEUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(162, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Consumed Unit:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(275, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Total consumed Water unit:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTunit
            // 
            this.lblTunit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTunit.Location = new System.Drawing.Point(419, 145);
            this.lblTunit.Name = "lblTunit";
            this.lblTunit.Size = new System.Drawing.Size(68, 17);
            this.lblTunit.TabIndex = 48;
            this.lblTunit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnitPrice.Location = new System.Drawing.Point(419, 164);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(68, 17);
            this.lblUnitPrice.TabIndex = 50;
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(358, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "Unit Price:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWbill
            // 
            this.lblWbill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWbill.Location = new System.Drawing.Point(419, 183);
            this.lblWbill.Name = "lblWbill";
            this.lblWbill.Size = new System.Drawing.Size(68, 17);
            this.lblWbill.TabIndex = 52;
            this.lblWbill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(357, 184);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "Water Bill:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEbill
            // 
            this.lblEbill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEbill.Location = new System.Drawing.Point(419, 202);
            this.lblEbill.Name = "lblEbill";
            this.lblEbill.Size = new System.Drawing.Size(68, 17);
            this.lblEbill.TabIndex = 54;
            this.lblEbill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(352, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "Electric Bill:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRent
            // 
            this.lblRent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRent.Location = new System.Drawing.Point(419, 221);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(68, 17);
            this.lblRent.TabIndex = 56;
            this.lblRent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(346, 223);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 55;
            this.label24.Text = "House Rent:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCleaner
            // 
            this.lblCleaner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCleaner.Location = new System.Drawing.Point(419, 259);
            this.lblCleaner.Name = "lblCleaner";
            this.lblCleaner.Size = new System.Drawing.Size(68, 17);
            this.lblCleaner.TabIndex = 58;
            this.lblCleaner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(366, 262);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 13);
            this.label26.TabIndex = 57;
            this.label26.Text = "Cleaner:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(419, 278);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 17);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(373, 280);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 13);
            this.label28.TabIndex = 59;
            this.label28.Text = "Total:";
            // 
            // lblGas
            // 
            this.lblGas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGas.Location = new System.Drawing.Point(419, 240);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(68, 17);
            this.lblGas.TabIndex = 62;
            this.lblGas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(304, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 13);
            this.label22.TabIndex = 61;
            this.label22.Text = "Gas Bill:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lblCleaner);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblEbill);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblWbill);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblTunit);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbxW2);
            this.Controls.Add(this.tbxW1);
            this.Controls.Add(this.tbxEUnit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbxWmeter2);
            this.Controls.Add(this.tbxpreReadingW2);
            this.Controls.Add(this.tbxCurReadingW2);
            this.Controls.Add(this.tbxWmeter1);
            this.Controls.Add(this.tbxpreReadingW1);
            this.Controls.Add(this.tbxCurReadingW1);
            this.Controls.Add(this.tbxEmeter);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbxVat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbxPA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxMC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxSC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxDC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxEC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxpreReading);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCurReading);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxPreviousDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPrDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dtpRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTenant);
            this.Controls.Add(this.label1);
            this.Name = "ReportPage";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cboTenant, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtpRange, 0);
            this.Controls.SetChildIndex(this.btnReport, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbxPrDate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxPreviousDate, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbxCurReading, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbxpreReading, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbxEC, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.tbxDC, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.tbxSC, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.tbxMC, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.tbxPA, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.tbxVat, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.tbxTotal, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.tbxEmeter, 0);
            this.Controls.SetChildIndex(this.tbxCurReadingW1, 0);
            this.Controls.SetChildIndex(this.tbxpreReadingW1, 0);
            this.Controls.SetChildIndex(this.tbxWmeter1, 0);
            this.Controls.SetChildIndex(this.tbxCurReadingW2, 0);
            this.Controls.SetChildIndex(this.tbxpreReadingW2, 0);
            this.Controls.SetChildIndex(this.tbxWmeter2, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.tbxEUnit, 0);
            this.Controls.SetChildIndex(this.tbxW1, 0);
            this.Controls.SetChildIndex(this.tbxW2, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.lblTunit, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.lblUnitPrice, 0);
            this.Controls.SetChildIndex(this.label23, 0);
            this.Controls.SetChildIndex(this.lblWbill, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.lblEbill, 0);
            this.Controls.SetChildIndex(this.label24, 0);
            this.Controls.SetChildIndex(this.lblRent, 0);
            this.Controls.SetChildIndex(this.label26, 0);
            this.Controls.SetChildIndex(this.lblCleaner, 0);
            this.Controls.SetChildIndex(this.label28, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.lblGas, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DateTimePicker dtpRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTenant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPrDate;
        private System.Windows.Forms.TextBox tbxPreviousDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxpreReading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCurReading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxEC;
        private System.Windows.Forms.TextBox tbxDC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxSC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxMC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxPA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxVat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxEmeter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxWmeter1;
        private System.Windows.Forms.TextBox tbxpreReadingW1;
        private System.Windows.Forms.TextBox tbxCurReadingW1;
        private System.Windows.Forms.TextBox tbxWmeter2;
        private System.Windows.Forms.TextBox tbxpreReadingW2;
        private System.Windows.Forms.TextBox tbxCurReadingW2;
        private System.Windows.Forms.TextBox tbxW2;
        private System.Windows.Forms.TextBox tbxW1;
        private System.Windows.Forms.TextBox tbxEUnit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTunit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblWbill;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblEbill;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblCleaner;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label label22;
    }
}