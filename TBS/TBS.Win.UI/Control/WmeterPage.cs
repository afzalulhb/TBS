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
    public partial class WmeterPage : TemplatePage
    {
        private bool bNew;
        public WmeterPage()
        {
            InitializeComponent();
            BindMeterList();
        }

        private void BindMeterList()
        {
            var meters = context.WMeters.ToList();
            cboMeter.DataSource = meters;
            cboMeter.ValueMember = "Id";
            cboMeter.DisplayMember = "MeterNumber";
            LoadMeter();
        }

        private void LoadMeter()
        {
            var meterId = 0;
            int.TryParse(cboMeter.SelectedValue.ToString(), out meterId);
            var meter = context.WMeters.FirstOrDefault(m => m.Id == meterId);

            if (meter != null && meter.Id > 0)
            {
                tbxFrom1.Text = meter.MeterNumber;
                chkActive.Checked = meter.IsActive;
            }
            else
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            tbxFrom1.Text = "";
            chkActive.Checked = true;
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
            SaveMeter();
            if (bNew)
            {
                BindMeterList();
            }
            bNew = false;
        }

        private void SaveMeter()
        {
            var meter = new WMeter();
            var meterId = 0;
            if (!bNew)
            {
                int.TryParse(cboMeter.SelectedValue.ToString(), out meterId);
                meter = context.WMeters.FirstOrDefault(m => m.Id == meterId);
            }
            meter.MeterNumber = tbxFrom1.Text;
            meter.IsActive = chkActive.Checked;
            if (bNew)
            {
                context.WMeters.Add(meter);
            }
            context.SaveChanges();
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            base.btnDelete_Click(sender, e);
            if (bNew)
            {
                LoadMeter();
                bNew = false;
            }
            else
            {
                if (MessageBox.Show("Delete current meter?", "Confirm", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                DeleteEMeter();
                BindMeterList();
                LoadMeter();
            }
        }

        private void DeleteEMeter()
        {
            var meterId = 0;
            int.TryParse(cboMeter.SelectedValue.ToString(), out meterId);

            var meter = context.WMeters.FirstOrDefault(m => m.Id == meterId);
            if (meter == null || meter.Id <= 0) return;
            context.WMeters.Remove(meter);
            context.SaveChanges();
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            base.btnCancel_Click(sender, e);
            LoadMeter();
            bNew = false;
        }
        private void cboMeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMeter();
        }
    }
}
