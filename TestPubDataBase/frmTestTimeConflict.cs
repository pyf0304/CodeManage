using com.taishsoft.common;
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
    public partial class frmTestTimeConflict : Form
    {
        public frmTestTimeConflict()
        {
            InitializeComponent();
        }

        private void btnTestConflict_Click(object sender, EventArgs e)
        {
            clsWeekTimesliceEN objWeekTimesliceEN = new clsWeekTimesliceEN();
            objWeekTimesliceEN.WeekDayID = txtWeek.Text;
            objWeekTimesliceEN.StartTime = txtStartTime.Text;
            objWeekTimesliceEN.EndTime = txtEndTime.Text;
            clsWeekTimesliceEN objWeekTimesliceEN_T = new clsWeekTimesliceEN();
            objWeekTimesliceEN_T.WeekDayID = txtWeek_T.Text;
            objWeekTimesliceEN_T.StartTime = txtStartTime_T.Text;
            objWeekTimesliceEN_T.EndTime = txtEndTime_T.Text;

            List<clsWeekTimesliceEN> arrWeekTimesliceObjLst = new List<clsWeekTimesliceEN>();
            arrWeekTimesliceObjLst.Add(objWeekTimesliceEN);
            bool bolIsConflict = clsWeekTimesliceBL.IsConflict(arrWeekTimesliceObjLst, objWeekTimesliceEN_T);
            lblResult.Text = bolIsConflict.ToString();
        }
    }
}
