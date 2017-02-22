    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBS.Domain.DB.Entity;

namespace TBS.Win.UI.Control
{
    public partial class EBillingRulesPage : TemplatePage
    {
        private int eBillingRulesId = 0;
        public EBillingRulesPage()
        {
            InitializeComponent();
            DisableButton("btnDelete");
            DisableButton("btnNew");
            LoadBillingRules();
        }

        private void LoadBillingRules()
        {
            var eBillingRules = context.EBillingRules.FirstOrDefault();
            if (eBillingRules != null && eBillingRules.Id > 0)
            {
                tbxFrom1.Text = eBillingRules.From1.ToString();
                tbxFrom2.Text = eBillingRules.From2.ToString();
                tbxFrom3.Text = eBillingRules.From3.ToString();
                tbxFrom4.Text = eBillingRules.From4.ToString();

                tbxTo1.Text = eBillingRules.To1.ToString();
                tbxTo2.Text = eBillingRules.To2.ToString();
                tbxTo3.Text = eBillingRules.To3.ToString();
                tbxTo4.Text = eBillingRules.To4.ToString();

                tbxRate1.Text = eBillingRules.Rate1.ToString();
                tbxRate2.Text = eBillingRules.Rate2.ToString();
                tbxRate3.Text = eBillingRules.Rate3.ToString();
                tbxRate4.Text = eBillingRules.Rate4.ToString();

                tbxDemandCharge.Text = eBillingRules.DemandCharge.ToString();
                tbxMinimumCharge.Text = eBillingRules.MinimumCharge.ToString();
                tbxServiceCharge.Text =eBillingRules.ServiceCharge.ToString();
                tbxVat.Text = eBillingRules.Vat.ToString();
                eBillingRulesId = eBillingRules.Id;
            }
            else
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            tbxFrom1.Text = "";
            tbxFrom2.Text = "";
            tbxFrom3.Text = "";
            tbxFrom4.Text = "";

            tbxTo1.Text = "";
            tbxTo2.Text = "";
            tbxTo3.Text = "";
            tbxTo4.Text = "";

            tbxRate1.Text = "";
            tbxRate2.Text = "";
            tbxRate3.Text = "";
            tbxRate4.Text = "";

            tbxDemandCharge.Text = "";
            tbxMinimumCharge.Text = "";
            tbxServiceCharge.Text = "";
            tbxVat.Text = "";
        }
        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            base.btnCancel_Click(sender, e);
            LoadBillingRules();
        }
        protected override void btnSave_Click(object sender, EventArgs e)
        {
            base.btnSave_Click(sender, e);
            SaveEBillingRules();
            LoadBillingRules();
    
        }

        private void SaveEBillingRules()
        {
            var eBillingRules = new EBillingRules();
            int fromReading1 = 0;
            int fromReading2 = 0;
            int fromReading3 = 0;
            int fromReading4 = 0;
            int toReading1 = 0;
            int toReading2 = 0;
            int toReading3 = 0;
            int toReading4 = 0;
            decimal rate1 = 0.00M;
            decimal rate2 = 0.00M;
            decimal rate3 = 0.00M;
            decimal rate4 = 0.00M;
            decimal demandCharge = 0.00M;
            decimal serviceCharge = 0.00M;
            decimal minimumCharge = 0.00M;
            decimal vat = 0.00M;

            int.TryParse(tbxFrom1.Text, out fromReading1);
            int.TryParse(tbxFrom2.Text, out fromReading2);
            int.TryParse(tbxFrom3.Text, out fromReading3);
            int.TryParse(tbxFrom4.Text, out fromReading4);
            int.TryParse(tbxTo1.Text, out toReading1);
            int.TryParse(tbxTo2.Text, out toReading2);
            int.TryParse(tbxTo3.Text, out toReading3);
            int.TryParse(tbxTo4.Text, out toReading4);
            decimal.TryParse(tbxRate1.Text, out rate1);
            decimal.TryParse(tbxRate2.Text, out rate2);
            decimal.TryParse(tbxRate3.Text, out rate3);
            decimal.TryParse(tbxRate4.Text, out rate4);
            decimal.TryParse(tbxDemandCharge.Text, out demandCharge);
            decimal.TryParse(tbxServiceCharge.Text, out serviceCharge);
            decimal.TryParse(tbxMinimumCharge.Text, out minimumCharge);
            decimal.TryParse(tbxVat.Text, out vat);

            if (eBillingRulesId > 0)
            {
                eBillingRules = context.EBillingRules.FirstOrDefault(e => e.Id == eBillingRulesId);
            }
            eBillingRules.From1 = fromReading1;
            eBillingRules.From2 = fromReading2;
            eBillingRules.From3 = fromReading3;
            eBillingRules.From4 = fromReading4;
            eBillingRules.To1 = toReading1;
            eBillingRules.To2 = toReading2;
            eBillingRules.To3 = toReading3;
            eBillingRules.To4 = toReading4;
            eBillingRules.Rate1 = rate1;
            eBillingRules.Rate2 = rate2;
            eBillingRules.Rate3 = rate3;
            eBillingRules.Rate4 = rate4;
            eBillingRules.DemandCharge = demandCharge;
            eBillingRules.ServiceCharge = serviceCharge;
            eBillingRules.MinimumCharge = minimumCharge;
            eBillingRules.Vat = vat;
            if (eBillingRulesId == 0)
            {
                context.EBillingRules.Add(eBillingRules);
            }
            context.SaveChanges();
            eBillingRulesId = eBillingRules.Id;
        }
        private void tbxFrom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void tbxRate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
        }
    }
}
