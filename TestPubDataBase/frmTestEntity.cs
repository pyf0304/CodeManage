using com.taishsoft.comm_db_obj;
using MSEdu.Entity;
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
    public partial class frmTestEntity : Form
    {
        public frmTestEntity()
        {
            InitializeComponent();
        }

        private void btnTestEntity_Click(object sender, EventArgs e)
        {
            clsSchoolYearEN obj = new clsSchoolYearEN();
            obj.SchoolYearName = "1990";
string strKeyId =             obj._KeyId;
            string strNameValue = obj._NameValue;
            clsEntityBase2 objEntityBase2 = obj;
            string strTabName = objEntityBase2._TabName_Curr;
            lblMsg.Text = string.Format("KeyId={0}, NameValue={1}, _CurrTabName={2}" ,
                strKeyId, strNameValue,
              strTabName);

        }
    }
}
