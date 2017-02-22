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
    public partial class TenantPage : TemplatePage
    {
        private bool bNew;
        public TenantPage()
        {
            InitializeComponent();
            BindTenantList();
            BindFlatList();
        }

        private void BindTenantList()
        {
            var tenants = context.Tenants.ToList();
            cboTenant.DataSource = tenants;
            cboTenant.ValueMember = "Id";
            cboTenant.DisplayMember = "Name";
            LoadTenant();
        }

        private void LoadTenant()
        {
            var tenantId = 0;
            int.TryParse(cboTenant.SelectedValue.ToString(), out tenantId);
            var tenant = context.Tenants.Include("Flat").FirstOrDefault(t => t.Id == tenantId);
            if (tenant != null && tenant.Id > 0)
            {
                tbxName.Text = tenant.Name;
                tbxAddress.Text = tenant.PAddress;
                tbxOccupation.Text = tenant.Occupation;
                tbxTelephone.Text = tenant.Telephone;
                dtpStartDate.Value = tenant.StartDate;
                chkActive.Checked = tenant.IsActive;
                cboApartment.SelectedIndex = cboApartment.Items.IndexOf(tenant.Flat);
            }
            else
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            tbxName.Text = "";
            tbxAddress.Text = "";
            tbxOccupation.Text = "";
            tbxTelephone.Text = "";
            dtpStartDate.Value = DateTime.Now;
            chkActive.Checked = true;
        }

        private void BindFlatList()
        {
            var flats = context.Flats.OrderBy(f => f.Code).ToList();
            cboApartment.DataSource = flats;
            cboApartment.ValueMember = "Id";
            cboApartment.DisplayMember = "Code";
            LoadTenant();
        }

        private void cboTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTenant();
        }

        protected override void btnNew_Click(object sender, EventArgs e)
        {
            base.btnNew_Click(sender,e);
            if (bNew) return;
            ClearFields();
            bNew = true;
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            base.btnCancel_Click(sender,e);
            LoadTenant();
            bNew = false;
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            base.btnSave_Click(sender,e);
            SaveTenant();
            if (bNew)
            {
                BindTenantList();
               
            }
            bNew = false;
        }

        private void SaveTenant()
        {
            var tenant=new Tenant();
            var tenantId = 0;
            if (!bNew)
            {
                int.TryParse(cboTenant.SelectedValue.ToString(), out tenantId);
                tenant = context.Tenants.FirstOrDefault(t => t.Id == tenantId);
            }
            tenant.Name = tbxName.Text;
            tenant.Flat = (Flat) cboApartment.SelectedItem;
            tenant.PAddress = tbxAddress.Text;
            tenant.Occupation = tbxOccupation.Text;
            tenant.Telephone = tbxTelephone.Text;
            tenant.StartDate = dtpStartDate.Value;
            tenant.IsActive = chkActive.Checked;

            if (bNew)
            {
                context.Tenants.Add(tenant);
            }
            context.SaveChanges();
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            base.btnDelete_Click(sender,e);
            if (bNew)
            {
                LoadTenant();
                bNew = false;
            }
            else
            {
                if (MessageBox.Show("Delete current tenant?", "Confirm", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                DeleteTenant();
                BindTenantList();
                LoadTenant();
            }
        }

        private void DeleteTenant()
        {
            var tenantId = 0;
            int.TryParse(cboTenant.SelectedValue.ToString(), out tenantId);

            var tenant = context.Tenants.FirstOrDefault(t => t.Id == tenantId);
            if (tenant == null || tenant.Id <= 0) return;
            context.Tenants.Remove(tenant);
            context.SaveChanges();
        }
    }
}
