using com.taishsoft.datetime;
using com.taishsoft.table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestPubDataBase
{
    public partial class frmTestDateRange : Form
    {
        public frmTestDateRange()
        {
            InitializeComponent();
        }

        private void btnCheckDateEffective_Click(object sender, EventArgs e)
        {
            clsDateRangeEN objDateRangeEN = new clsDateRangeEN();
            objDateRangeEN.BeginDate = txtBeginDate.Text;
            objDateRangeEN.EndDate = txtEndDate.Text;
            bool bolIsEffective = clsDateRangeBL.IsEffectiveDate(objDateRangeEN, txtDate.Text);
            lblResult.Text = bolIsEffective.ToString();
        }
    }
}
