using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBS.Win.UI.Control;

namespace TBS.Win.UI
{
    public partial class frmWinUI : Form
    {
        private TemplatePage templatePage;
        public frmWinUI()
        {
            InitializeComponent();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            if (templatePage != null)
            {
               pnlPage.Controls.Remove(templatePage);
            }
                        TenantPage page = new TenantPage();
               templatePage = (TemplatePage) page;
            pnlPage.Controls.Add(page);
        }

        private void btnApartment_Click(object sender, EventArgs e)
        {
            if (templatePage != null)
            {
                pnlPage.Controls.Remove(templatePage);
            }
            FlatPage page = new FlatPage();
            templatePage = page;
            pnlPage.Controls.Add(page);
        }

        private void bntEMeter_Click(object sender, EventArgs e)
        {

            if (templatePage != null)
            {
                pnlPage.Controls.Remove(templatePage);
            }
            var page = new EmeterPage();
            templatePage = page;
            pnlPage.Controls.Add(page);
        }

        private void btnEBillingRules_Click(object sender, EventArgs e)
        {
            if (templatePage != null)
            {
                pnlPage.Controls.Remove(templatePage);
            }
            var page = new EBillingRulesPage();
            templatePage = page;
            pnlPage.Controls.Add(page);
        }

        private void btnEReading_Click(object sender, EventArgs e)
        {
            if (templatePage != null)
            {
                pnlPage.Controls.Remove(templatePage);
            }
            var page = new EReadingPage();
            templatePage = page;
            pnlPage.Controls.Add(page);
        }

        private void btnOtherCharges_Click(object sender, EventArgs e)
        {
            if (templatePage != null)
            {
                pnlPage.Controls.Remove(templatePage);
            }
            var page = new UtilityOptionPage();
            templatePage = page;
            pnlPage.Controls.Add(page);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (templatePage != null)
            {
                pnlPage.Controls.Remove(templatePage);
            }
            var page = new ReportPage();
            templatePage = page;
            pnlPage.Controls.Add(page);
        }

        private void btnWReading_Click(object sender, EventArgs e)
        {
            if (templatePage != null)
            {
                pnlPage.Controls.Remove(templatePage);
            }
            var page = new WReadingPage();
            templatePage = page;
            pnlPage.Controls.Add(page);
        }

        private void btnWBR_Click(object sender, EventArgs e)
        {

            if (templatePage != null)
            {
                pnlPage.Controls.Remove(templatePage);
            }
            var page = new WbillingRulesPage();
            templatePage = page;
            pnlPage.Controls.Add(page);
        }

        private void btnWMeter_Click(object sender, EventArgs e)
        {
            if (templatePage != null)
            {
                pnlPage.Controls.Remove(templatePage);
            }
            var page = new WmeterPage();
            templatePage = page;
            pnlPage.Controls.Add(page);
        }
    }
}
