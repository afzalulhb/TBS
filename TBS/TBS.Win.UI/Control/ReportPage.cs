using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBS.Domain.DB.Entity;

namespace TBS.Win.UI.Control
{
    public partial class ReportPage : TemplatePage
    {
        private DateTime firstDate;
        private DateTime lastDate;
        private Report frm;
        public ReportPage()
        {
            InitializeComponent();
            HideButtonPanel();
            BindTenantList();
            Initialize();

        }
        private void Initialize()
        {
            dtpRange.Value = DateTime.Now;
            var today = DateTime.Now;
            firstDate = new DateTime(today.Year, today.Month, 1);
            lastDate = firstDate.AddMonths(1).AddDays(-1);

        }

        private void BindTenantList()
        {
            var tenants = context.Tenants.Include("Flat").Where(x => x.IsActive).OrderBy(x => x.Flat.Id).ToList();
            cboTenant.DataSource = tenants;
            cboTenant.DisplayMember = "Name";
            cboTenant.ValueMember = "Id";
            LoadReadings();
        }

        private void LoadReadings()
        {
            var tenantId = 0;
            EReading eReading = null;
            WReading wReading = null;
            WReading wReading2 = null;

            ClearFields();
            tbxPrDate.Text = lastDate.ToShortDateString();
            tbxPreviousDate.Text = firstDate.ToShortDateString();
            int.TryParse(cboTenant.SelectedValue.ToString(), out tenantId);
            var tenant = context.Tenants.Include("Flat").FirstOrDefault(t => t.Id == tenantId);
            if (tenant == null) return;
            var flatId = tenant.Flat.Id;
            var flat = context.Flats.Include("EMeters").Include("WMeters").Include("UtilityOptions").FirstOrDefault(f => f.Id == flatId);

            //          var eMeter = context.EMeters.FirstOrDefault(m => flat != null && flat.EMeters.Contains(m));
            var eMeters = context.EMeters.ToList();
            var emt = eMeters.FirstOrDefault(m => flat != null && flat.EMeters.Contains(m));
            if (emt != null)
            {
                tbxEmeter.Text = emt.MeterNumber;
                eReading = context.EReadings.FirstOrDefault(x => (x.EMeter.Id == emt.Id) &&
                                                                 ((x.StartDate >= firstDate && x.StartDate <= lastDate) ||
                                                                  (x.EndDate >= firstDate && x.EndDate <= lastDate)));
                if (eReading != null && eReading.Id > 0)
                {
                    tbxCurReading.Text = eReading.CurrentReading.ToString();
                    tbxpreReading.Text = eReading.PreviousReading.ToString();
                    tbxEUnit.Text = (eReading.CurrentReading - eReading.PreviousReading).ToString();
                    tbxPrDate.Text = eReading.EndDate.ToShortDateString();
                    tbxPreviousDate.Text = eReading.StartDate.ToShortDateString();
                }
            }
            var wMeters = context.WMeters.ToList();
            wMeters = wMeters.Where(m => flat != null && flat.WMeters.Contains(m)).ToList();
            if (wMeters.Count > 0)
            {
                var wm = wMeters[0];
                tbxWmeter1.Text = wm.MeterNumber;
                wReading = context.WReadings.FirstOrDefault(x => (x.WMeter.Id == wm.Id) &&
                                                                   ((x.StartDate >= firstDate && x.StartDate <= lastDate) ||
                                                                    (x.EndDate >= firstDate && x.EndDate <= lastDate)));
                if (wReading != null && wReading.Id > 0)
                {
                    tbxCurReadingW1.Text = wReading.CurrentReading.ToString();
                    tbxpreReadingW1.Text = wReading.PreviousReading.ToString();
                    tbxW1.Text = (wReading.CurrentReading - wReading.PreviousReading).ToString();
                }

            }
            if (wMeters.Count > 1)
            {
                var wm2 = wMeters[1];
                tbxWmeter2.Text = wm2.MeterNumber;
                wReading2 = context.WReadings.FirstOrDefault(x => (x.WMeter.Id == wm2.Id) &&
                                                                  ((x.StartDate >= firstDate && x.StartDate <= lastDate) ||
                                                                   (x.EndDate >= firstDate && x.EndDate <= lastDate)));
                if (wReading2 != null && wReading2.Id > 0)
                {
                    tbxCurReadingW2.Text = wReading2.CurrentReading.ToString();
                    tbxpreReadingW2.Text = wReading2.PreviousReading.ToString();
                    tbxW2.Text = (wReading2.CurrentReading - wReading2.PreviousReading).ToString();
                }

            }
            var options = flat.UtilityOptions;
            lblRent.Text = flat.Rent.ToString();
            if (options != null)
            {
                label22.Text = options[0].Name;
                lblGas.Text = options[0].Cost.ToString();
                if (options.Count >= 2)
                {
                    label26.Text = options[1].Name;
                    lblCleaner.Text = options[1].Cost.ToString();
                }
                if (options.Count < 2) { label26.Hide(); lblCleaner.Hide(); }
                else
                {
                    label26.Show();
                    lblCleaner.Show();
                }
            }
            CalculateCharge();
        }

        private void CalculateCharge()
        {
            var tUnit = 0;
            var slab1 = 0.00M;
            var slab2 = 0.00M;
            var slab3 = 0.00M;
            var slab4 = 0.00M;
            var eCharge = 0.00M;
            var w1unit = 0;
            var w2unit = 0;
            var tWunit = 0;
            var unitPrice = 0.00M;

            int.TryParse(tbxEUnit.Text, out tUnit);
            var ebr = context.EBillingRules.FirstOrDefault();
            if (ebr != null)
            {
                slab1 = ebr.Rate1;
                slab2 = ebr.Rate2;
                slab3 = ebr.Rate3;
                slab4 = ebr.Rate4;
                int x1 = 0, x2 = 0, x3 = 0, x4 = 0;
                if (tUnit > ebr.To3 /*300*/)
                {
                    x1 = ebr.To1 - ebr.From1;//100;
                    x2 = ebr.To2 - ebr.To1;//100;
                    x3 = ebr.To3 - ebr.To2; //100;
                    x4 = tUnit - ebr.To3;//300;
                }
                else if (tUnit > ebr.To2 /*200*/ && tUnit <= ebr.To3 /* 300*/)
                {
                    x1 = ebr.To1 - ebr.From1;//100;
                    x2 = ebr.To2 - ebr.To1;//100;
                    x3 = tUnit - ebr.To2; //100;
                    x4 = 0;//300;

                }
                else if (tUnit > ebr.From2 /*100*/ && tUnit <= ebr.From3 /* 200*/)
                {
                    x1 = ebr.To1 - ebr.From1;//100;
                    x2 = tUnit - ebr.To1;//100;
                    x3 = 0;
                    x4 = 0;
                }
                else
                {
                    x1 = tUnit;
                    x2 = 0;
                    x3 = 0;
                    x4 = 0;
                }
                eCharge = x1 * slab1 + x2 * slab2 + x3 * slab3 + x4 * slab4;
                tbxEC.Text = eCharge.ToString();
                tbxDC.Text = ebr.DemandCharge.ToString();
                tbxSC.Text = ebr.ServiceCharge.ToString();
                tbxMC.Text = ebr.MinimumCharge.ToString();
                var pAmount = (eCharge < ebr.MinimumCharge ? ebr.MinimumCharge : eCharge) + ebr.DemandCharge + ebr.ServiceCharge;
                tbxPA.Text = pAmount.ToString();
                decimal.TryParse(tbxPA.Text, out pAmount);
                tbxVat.Text = Math.Round(pAmount / 100 * ebr.Vat).ToString("##.00");
                tbxTotal.Text = Math.Round(pAmount + pAmount / 100 * ebr.Vat).ToString("##.00");
            }

            int.TryParse(tbxW1.Text, out w1unit);
            int.TryParse(tbxW2.Text, out w2unit);
            var wbr = context.WBillingRules.FirstOrDefault();
            if (wbr != null)
            {
                tWunit = w1unit + w2unit;
                lblTunit.Text = tWunit.ToString();
                unitPrice = wbr.UnitPrice + wbr.UnitPrice / 100 * wbr.Vat + wbr.UnitPrice / 100 * wbr.ServiceCharge;
                lblUnitPrice.Text = unitPrice.ToString("##.00");
                lblWbill.Text = (tWunit * unitPrice).ToString("##.00");
            }
            lblEbill.Text = tbxTotal.Text ;
            decimal wb; decimal.TryParse(lblWbill.Text, out wb);
            decimal ec; decimal.TryParse(tbxTotal.Text, out ec);
            decimal hr;
            decimal.TryParse(lblRent.Text, out hr);
            decimal gas;
            decimal.TryParse(lblGas.Text, out gas);
            decimal cr;
            decimal.TryParse(lblCleaner.Text, out cr);
            lblTotal.Text = (wb + ec + hr + gas + cr).ToString();

        }

        private void ClearFields()
        {
            tbxPrDate.Text = "";
            tbxPreviousDate.Text = "";
            tbxVat.Text = "";
            tbxCurReading.Text = "";
            tbxCurReadingW1.Text = "";
            tbxCurReadingW2.Text = "";
            tbxDC.Text = "";
            tbxEC.Text = "";
            tbxEUnit.Text = "";
            tbxMC.Text = "";
            tbxPA.Text = "";
            tbxEmeter.Text = "";
            tbxSC.Text = "";
            tbxTotal.Text = "";
            tbxW1.Text = "";
            tbxWmeter1.Text = "";
            tbxW2.Text = "";
            tbxWmeter2.Text = "";
            tbxCurReadingW1.Text = "";
            tbxCurReadingW2.Text = "";
            tbxCurReading.Text = "";
            lblRent.Text = "";
            lblCleaner.Text = "";
            lblEbill.Text = "";
            lblTotal.Text = "";
            lblTunit.Text = "";
            lblUnitPrice.Text = "";
            lblWbill.Text = "";
        }

        private void cboTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReadings();
        }

        private void dtpRange_ValueChanged(object sender, EventArgs e)
        {
            var today = dtpRange.Value;
            firstDate = new DateTime(today.Year, today.Month, 1);
            lastDate = firstDate.AddMonths(1).AddDays(-1);
            LoadReadings();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            UpdateReportData();

            if (frm != null)
            {
                frm = null;
            }
            frm = new Report();
            frm.ShowDialog();
        }

        private void UpdateReportData()
        {
            context.TmpMonthlyBills.RemoveRange(context.TmpMonthlyBills);
            context.SaveChanges();

            var tmpMonthlyBill = new TmpMonthlyBill()
            {
                TenantName = cboTenant.Text,
                BillingPeriod = string.Format("{0} {1}", dtpRange.Value.ToString("MMM", CultureInfo.InvariantCulture), dtpRange.Value.Year),
                BillStartDate = tbxPrDate.Text,
                BillEndDate = tbxPreviousDate.Text,
                ElectricMeterNo = tbxEmeter.Text ,
                ElectricMeterCurrentReading = tbxCurReading.Text ,
                ElectricMeterLastReading = tbxpreReading.Text ,
                ConsumedElectricUnit = tbxEUnit.Text ,
                ElectricityCharge = tbxEC.Text ,
                DemandCharge = tbxDC.Text ,
                ServiceCharge = tbxSC.Text ,
                MinimumCharge = tbxMC.Text ,
                PrincipalAmount = tbxPA.Text,
                VAT = tbxVat.Text ,
                ElectricityBill = tbxTotal.Text ,
                WaterMeter1No = tbxWmeter1.Text ,
                WaterMeter1CurrentReading = tbxCurReadingW1.Text,
                WaterMeter1LastReading = tbxpreReadingW1.Text ,
                WaterMeter1ConsumedUnit = tbxW1.Text,
                WaterMeter2No = tbxWmeter2.Text ,
                WaterMeter2CurrentReading = tbxCurReadingW2.Text ,
                WaterMeter2LastReading = tbxpreReadingW2.Text ,
                WaterMeter2ConsumedUnit = tbxW2.Text ,
                TotalConsumedWaterUnit = lblTunit.Text ,
                WaterUnitPrice = lblUnitPrice.Text,
                WaterBill = lblWbill.Text ,
                HouseRent = lblRent.Text ,
                GasBill = lblGas.Text,
                CleanerBill = lblCleaner.Text ,
                Total = lblTotal.Text
            };
            context.TmpMonthlyBills.Add(tmpMonthlyBill);
            context.SaveChanges();
        }
    }
}
