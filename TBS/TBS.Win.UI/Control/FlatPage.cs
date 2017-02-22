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
    public partial class FlatPage : TemplatePage
    {
        private bool bNew;
        public FlatPage()
        {
            InitializeComponent();
            BindMeterList();
            BindOptionList();
            BindWMeterList();
            BindFlatList();

        }

        private void BindWMeterList()
        {
            var wMeter = context.WMeters.Where(w => w.IsActive).ToList();
            chkLstWMeter.DataSource = wMeter;
            chkLstWMeter.ValueMember = "Id";
            chkLstWMeter.DisplayMember = "MeterNumber";
        }

        private void BindFlatList()
        {
            var flats = context.Flats.OrderBy(x=>x.Code).ToList();
            cboApartment.DataSource = flats;
            cboApartment.ValueMember = "Id";
            cboApartment.DisplayMember = "Code";
            LoadFlat();
        }

        private void LoadFlat()
        {
            int flatId = 0;
            int.TryParse(cboApartment.SelectedValue.ToString(), out flatId);
            var flat = context.Flats.FirstOrDefault(t => t.Id == flatId);
            EMeter meter;
            WMeter wMeter;
            UtilityOption option;
            if (flat != null && flatId > 0)
            {
                tbxCode.Text = flat.Code;
                tbxRent.Text = flat.Rent.ToString("#0.00");

                for (int i = 0; i < chklstMeter.Items.Count; i++)
                {
                    meter = (EMeter)chklstMeter.Items[i];
                    if (meter != null && flat.EMeters != null &&
                        flat.EMeters.Count > 0 && flat.EMeters.Contains(meter))
                    {
                        chklstMeter.SetItemChecked(i, true);
                    }
                    else
                    {
                        chklstMeter.SetItemChecked(i, false);
                    }
                }

                for (var i = 0; i < chkLstWMeter.Items.Count; i++)
                {
                    wMeter = (WMeter)chkLstWMeter.Items[i];
                    if (wMeter != null && flat.WMeters != null && flat.WMeters.Count > 0 &&
                        flat.WMeters.Contains(wMeter))
                    {
                        chkLstWMeter.SetItemChecked(i, true);
                    }
                    else
                    {
                        chkLstWMeter.SetItemChecked(i, false);
                    }
                }
                context.Entry(flat).Collection(a => a.UtilityOptions).Load();
                for (int i = 0; i < chklstUtility.Items.Count; i++)
                {
                    option = (UtilityOption)chklstUtility.Items[i];
                    if (option != null && flat.UtilityOptions != null &&
                        flat.UtilityOptions.Count > 0 && flat.UtilityOptions.Contains(option))
                    {
                        chklstUtility.SetItemChecked(i, true);
                    }
                    else
                    {
                        chklstUtility.SetItemChecked(i, false);
                    }
                }
            }
            else
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            tbxCode.Text = "";
            tbxRent.Text = "";

            for (int i = 0; i < chklstMeter.Items.Count; i++)
            {
                chklstMeter.SetItemChecked(i, false);
            }
            for (int i = 0; i < chkLstWMeter.Items.Count; i++)
            {
                chkLstWMeter.SetItemChecked(i, false);
            }
        }

        private void BindOptionList()
        {

            var options = context.UtilityOptions.Where(o => o.IsActive).ToList();
            chklstUtility.DataSource = options;
            chklstUtility.DisplayMember = "Name";
            chklstUtility.ValueMember = "Id";

        }

        private void BindMeterList()
        {
            var meters = context.EMeters.Where(m => m.IsActive).ToList();
            chklstMeter.DataSource = meters;
            chklstMeter.ValueMember = "Id";
            chklstMeter.DisplayMember = "MeterNumber";
        }

        private void cboApartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlat();
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            base.btnSave_Click(sender, e);
            SaveFlat();
            if (bNew)
            {
                BindFlatList();
            }
            bNew = false;
        }

        private void SaveFlat()
        {
            var flat = new Flat();
            int flatId = 0;
            decimal rent = 0.00M;

            decimal.TryParse(tbxRent.Text, out rent);
            if (!bNew)
            {
                int.TryParse(cboApartment.SelectedValue.ToString(), out flatId);
                flat = context.Flats.FirstOrDefault(t => t.Id == flatId);
            }
            flat.Code = tbxCode.Text;
            flat.Rent = rent;
            context.Entry(flat).Collection(a => a.UtilityOptions).Load();
            flat.UtilityOptions.Clear();
            var lstEMeters = chklstMeter.CheckedItems.Cast<EMeter>().ToList();
            flat.EMeters = lstEMeters;
            var lstOptions = chklstUtility.CheckedItems.Cast<UtilityOption>().ToList();
            flat.UtilityOptions = lstOptions;
            var lstWMeters = chkLstWMeter.CheckedItems.Cast<WMeter>().ToList();
            flat.WMeters = lstWMeters;
            if (bNew)
            {
                context.Flats.Add(flat);
            }
            context.SaveChanges();
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            base.btnCancel_Click(sender, e);
            LoadFlat();
            bNew = false;
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            base.btnDelete_Click(sender, e);
            if (bNew)
            {
                LoadFlat();
                bNew = false;
            }
            else
            {
                if (MessageBox.Show("Delete current Flat?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DeleteFlat();
                    BindFlatList();
                    LoadFlat();
                }
            }
        }

        private void DeleteFlat()
        {
            var flatId = 0;
            int.TryParse(cboApartment.SelectedValue.ToString(), out flatId);
            var flat = context.Flats.FirstOrDefault(t => t.Id == flatId);
            if (flat == null || flat.Id <= 0) return;
            context.Flats.Remove(flat);
            context.SaveChanges();
        }
    }
}
