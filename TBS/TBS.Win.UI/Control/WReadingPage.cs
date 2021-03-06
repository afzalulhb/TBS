﻿using System;
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
    public partial class WReadingPage : TemplatePage
    {
        private DateTime firstDate;
        private DateTime lastDate;
        private bool bNew;
        private int wReadingId = 0;

        public WReadingPage()
        {
            InitializeComponent();
            Initialize();

        }
        private void Initialize()
        {
            dtpRange.Value = DateTime.Now;
            DateTime toDay = DateTime.Now;
            firstDate = new DateTime(toDay.Year, toDay.Month, 1);
            lastDate = firstDate.AddMonths(1).AddDays(-1);
            dtpStartDate.Value = firstDate;
            dtpEndDate.Value = lastDate;

            BindMeterList();
        }

        private void BindMeterList()
        {
            var meters = context.WMeters.ToList();
            cboMeter.DataSource = meters;
            cboMeter.ValueMember = "Id";
            cboMeter.DisplayMember = "MeterNumber";
            LoadReading();

        }

        private void LoadReading()
        {
            if (cboMeter.SelectedItem != null)
            {
                wReadingId = 0;
                var meter = (WMeter)cboMeter.SelectedItem;
                var wReading = context.WReadings.FirstOrDefault(r => (r.WMeter.Id == meter.Id) && ((r.StartDate >= firstDate && r.StartDate <= lastDate) ||
                (r.EndDate >= firstDate && r.EndDate <= lastDate)));
                if (wReading != null && wReading.Id > 0)
                {
                    tbxPrevious.Text = wReading.PreviousReading.ToString();
                    tbxCurrent.Text = wReading.CurrentReading.ToString();
                    firstDate = wReading.StartDate;
                    lastDate = wReading.EndDate;
                    wReadingId = wReading.Id;
                    dtpStartDate.Value = firstDate;
                    dtpEndDate.Value = lastDate;
                }
                else
                {
                    ClearFields();
                }
            }

        }

        private void ClearFields()
        {
            tbxCurrent.Text = "";
            tbxPrevious.Text = "";
            wReadingId = 0;
        }

        private void dtpRange_ValueChanged(object sender, EventArgs e)
        {
            DateTime range = dtpRange.Value;
            firstDate = new DateTime(range.Year, range.Month, 1);
            lastDate = firstDate.AddMonths(1).AddDays(-1);

            dtpStartDate.Value = firstDate;
            dtpEndDate.Value = lastDate;
            LoadReading();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            firstDate = dtpStartDate.Value;

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lastDate = dtpEndDate.Value;

        }

        private void cboMeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReading();

        }
        protected override void btnNew_Click(object sender, EventArgs e)
        {
            base.btnNew_Click(sender, e);
            if (bNew) return;
            ClearFields();
            FillGuessedValue();
            bNew = true;
        }

        private void FillGuessedValue()
        {
            tbxPrevious.Text = "0";
            if (cboMeter.SelectedItem == null) return;
            var meter = (WMeter)cboMeter.SelectedItem;
            var wReading = context.WReadings.Where(r => r.WMeter.Id == meter.Id).OrderBy(r => r.CurrentReading).FirstOrDefault();

            if (wReading != null && wReading.Id > 0)
            {
                tbxPrevious.Text = wReading.CurrentReading.ToString();
            }
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            base.btnCancel_Click(sender, e);
            LoadReading();
            bNew = false;
        }
        protected override void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                base.btnSave_Click(sender, e);
                SaveReading();
            }
            bNew = false;
        }

        private bool CheckValidate()
        {
            var success = false;
            var preReading = 0;
            var curReading = 0;
            int.TryParse(tbxPrevious.Text, out preReading);
            int.TryParse(tbxCurrent.Text, out curReading);
            if (firstDate == lastDate || firstDate > lastDate)
            {
                MessageBox.Show("End date must be later than start date!");
            }
            else if (!bNew && wReadingId <= 0)
            {
                MessageBox.Show("Please consider creating new reading!");
            }
            else if (cboMeter.Items.Count <= 0)
            {
                MessageBox.Show("No Electric meter available!");
            }
            else if (string.IsNullOrEmpty(tbxCurrent.Text) || string.IsNullOrWhiteSpace(tbxCurrent.Text) ||
                     string.IsNullOrEmpty(tbxPrevious.Text) || string.IsNullOrWhiteSpace(tbxPrevious.Text))
            {
                MessageBox.Show("Current and previous reading required!");
            }
            else if (preReading > curReading)
            {
                MessageBox.Show("Current reading cand be less than previous reading!");
            }
            else if (!int.TryParse(tbxCurrent.Text, out curReading) || !int.TryParse(tbxPrevious.Text, out preReading))
            {
                MessageBox.Show("Current and previous reading required!");
            }
            else
            {
                success = true;
            }
            return success;
        }

        private void SaveReading()
        {
            var meter = (WMeter)cboMeter.SelectedItem;
            var reading = new WReading();
            var preReading = 0;
            var curReading = 0;
            int.TryParse(tbxPrevious.Text, out preReading);
            int.TryParse(tbxCurrent.Text, out curReading);
            if (!bNew)
            {
                reading = context.WReadings.FirstOrDefault(r => r.Id == wReadingId);
            }
            reading.StartDate = firstDate;
            reading.EndDate = lastDate;
            reading.PreviousReading = preReading;
            reading.CurrentReading = curReading;
            reading.WMeter = meter;
            if (bNew)
            {
                context.WReadings.Add(reading);
            }
            context.SaveChanges();
            wReadingId = reading.Id;
        }
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            base.btnDelete_Click(sender, e);
            if (bNew)
            {
                LoadReading();
                bNew = false;
            }
            else
            {
                if (MessageBox.Show("Delete current reading?", "Confirm", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                DeleteReading();
                BindMeterList();
                LoadReading();
            }
        }

        private void DeleteReading()
        {
            var reading = context.WReadings.FirstOrDefault(r => r.Id == wReadingId);
            if (reading != null && reading.Id > 0)
            {
                context.WReadings.Remove(reading);
                context.SaveChanges();
                wReadingId = 0;
            }
        }

    }
}
