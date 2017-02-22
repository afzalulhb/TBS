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
    public partial class WbillingRulesPage : TemplatePage
    {
       int wBillingRulesId=0;

        public WbillingRulesPage()
        {
            InitializeComponent();
            DisableButton("btnDelete");
            DisableButton("btnNew");
            LoadBillingRules();
        }

        private void LoadBillingRules()
        {
            var wBillingRules = context.WBillingRules.FirstOrDefault();
            if (wBillingRules!=null && wBillingRules.Id > 0)
            {
                tbxRate.Text = wBillingRules.UnitPrice.ToString();
                tbxServiceCharge.Text = wBillingRules.ServiceCharge.ToString();
                tbxVat.Text = wBillingRules.Vat.ToString();
                wBillingRulesId = wBillingRules.Id;

            }
            else
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
        tbxRate.Text = "";
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
            var wBillingRules = new WBillingRules();
     //       int reading = 0;
            decimal rate = 0.00M;
            decimal serviceCharge = 0.00M;
            decimal vat = 0.00M;

            decimal.TryParse(tbxRate.Text, out rate);
            decimal.TryParse(tbxServiceCharge.Text, out serviceCharge);
            decimal.TryParse(tbxVat.Text, out vat);

            if (wBillingRulesId > 0)
            {
                wBillingRules = context.WBillingRules.FirstOrDefault(w => w.Id == wBillingRulesId);
                wBillingRules.ServiceCharge = serviceCharge;
                wBillingRules.UnitPrice = rate;
                wBillingRules.Vat = vat;

               
            }
            if (wBillingRulesId == 0)
            {
                context.WBillingRules.Add(wBillingRules);

            }
            context.SaveChanges();
            wBillingRulesId = wBillingRules.Id;

        }
        private void tbxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
        }
        private void tbxServiceCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
        }
        private void tbxVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
        }

    }
}
