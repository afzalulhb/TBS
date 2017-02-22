using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBS.Domain.DB.DBContext;

namespace TBS.Win.UI.Control
{
    public partial class TemplatePage : UserControl
    {
        public TBSContext context;

        public TemplatePage()
        {
            InitializeComponent();
            context = new TBSContext();
        }

        protected virtual void btnNew_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected virtual void HideButtonPanel()
        {
            grpButton.Visible = false;
        }

        protected virtual void DisableButton(string buttonId)
        {
            switch (buttonId.ToLower())
            {
                case "btnnew":
                    btnNew.Enabled = false;
                    break;
                case "btnsave":
                    btnSave.Enabled = false;
                    break;
                case "btndelete":
                    btnDelete.Enabled = false;
                    break;
                case "btncancel":
                    btnCancel.Enabled = false;
                    break;
                case "btnclose":
                    btnClose.Enabled = false;
                    break;

            }
        }
    }
}
