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
    public partial class UtilityOptionPage :TemplatePage
    {
        private bool bNew;
        public UtilityOptionPage()
        {
            InitializeComponent();
            BindOptionList();
        }

        private void BindOptionList()
        {
            var options = context.UtilityOptions.ToList();
            cboOption.DataSource = options;
            cboOption.ValueMember = "Id";
            cboOption.DisplayMember = "Name";
            LoadOption();
        }

        private void LoadOption()
        {
            var optionId = 0;
            int.TryParse(cboOption.SelectedValue.ToString(), out optionId);
            var option = context.UtilityOptions.FirstOrDefault(o => o.Id == optionId);
            if (option != null && option.Id > 0)
            {
                tbxName.Text = option.Name;
                tbxDescription.Text = option.Description;
                tbxCost.Text = option.Cost.ToString();
                chkActive.Checked = option.IsActive;
            }
            else
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            tbxName.Text = "";
            tbxDescription.Text = "";
            tbxCost.Text = "";
            chkActive.Checked = true;
        }

        private void cboOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOption();
        }
        protected override void btnNew_Click(object sender, EventArgs e)
        {
            base.btnNew_Click(sender, e);
            if (bNew) return;
            ClearFields();
            bNew = true;
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            base.btnSave_Click(sender, e);
            SaveOption();
            if (bNew)
            {
                BindOptionList();
            }
            bNew = false;
        }

        private void SaveOption()
        {
            var option = new UtilityOption();
            var optionId = 0;
            var cost = 0.00M;
            decimal.TryParse(tbxCost.Text,out cost);

            if (!bNew)
            {
                int.TryParse(cboOption.SelectedValue.ToString(), out optionId);
                option = context.UtilityOptions.FirstOrDefault(o => o.Id == optionId);
            }
            option.Name = tbxName.Text;
            option.Description = tbxDescription.Text;
            option.Cost = cost;
            option.IsActive = chkActive.Checked;
            if (bNew)
            {
                context.UtilityOptions.Add(option);
            }
            context.SaveChanges();
        }


        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            base.btnDelete_Click(sender, e);
            if (bNew)
            {
                LoadOption();
                bNew = false;
            }
            else
            {
                if (MessageBox.Show("Delete current option?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DeleteOption();
                    BindOptionList();
                    LoadOption();
                }
            }
        }

        private void DeleteOption()
        {
            var option = new UtilityOption();
            var optionId = 0;
            int.TryParse(cboOption.SelectedValue.ToString(), out optionId);
            option = context.UtilityOptions.FirstOrDefault(o => o.Id == optionId);
            if (option == null || option.Id <= 0) return;
            context.UtilityOptions.Remove(option);
            context.SaveChanges();
        }
        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            base.btnCancel_Click(sender, e);
            LoadOption();
            bNew = false;
        }

    }
}
