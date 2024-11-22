using com.taishsoft.table;
using com.taishsoft.util;

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
    public partial class frmTestTableData : Form
    {
        public frmTestTableData()
        {
            InitializeComponent();
        }

        private void btnDispSourceData_Click(object sender, EventArgs e)
        {
            clsTableDataBL objTableDataBL = new clsTableDataBL();
            objTableDataBL.MyOrderWay = com.taishsoft.util.OrderWay.ColMainOrder;
            objTableDataBL.RowNum = 8;
            objTableDataBL.AddTableDataObj(16, "CCC");
            objTableDataBL.AddTableDataObj(3, 1, "AAA");

            objTableDataBL.AddTableDataObj(5, 1, "BBB");
            objTableDataBL.AddTableDataObj(6, 2, "BBB");
            objTableDataBL.AddTableDataObjEx(15, "CCC");
            objTableDataBL.AddTableDataObjEx(7, 2, "BBB");
            objTableDataBL.AddTableDataObjEx(7, 3, "CCC");
            objTableDataBL.AddTableDataObjEx(7, 3, "C1C2C3");
            objTableDataBL.AddTableDataObjEx(14, "CCC");
            objTableDataBL.AddTableDataObjEx(1, 1, "AAA");
            objTableDataBL.AddTableDataObjEx(2, 1, "AAA");
            objTableDataBL.AddTableDataObjEx(16, "C1C2C3");
            clsTableDataBL objTableDataBL_New = new clsTableDataBL();
            objTableDataBL.CopyTo(objTableDataBL_New);
            objTableDataBL.CheckSameAsUp();
            foreach (clsTableDataEN objTableDataEN in objTableDataBL.arrTableDataObjLst)
            {
                BindData(objTableDataEN, tableLayoutPanel1);
            }
            foreach (clsTableDataEN objTableDataEN in objTableDataBL_New.arrTableDataObjLst)
            {
                BindData(objTableDataEN, tableLayoutPanel_New);
            }
        }
        private void BindData(clsTableDataEN objTableDataEN, TableLayoutPanel objtableLayoutPanel1)
        {
            Control objCtrl = objtableLayoutPanel1.GetControlFromPosition(objTableDataEN.RowNo, objTableDataEN.ColNo);
            if (objCtrl == null)
            {
                Label objLabel = new Label();
                objLabel.Text = objTableDataEN.GetDispData();
                objtableLayoutPanel1.Controls.Add(objLabel, objTableDataEN.ColNo, objTableDataEN.RowNo);
            }
        }

        private void btnTestTableIndex_Click(object sender, EventArgs e)
        {
            clsTableDataBL objTableDataBL = new clsTableDataBL();
            objTableDataBL.MyOrderWay = com.taishsoft.util.OrderWay.ColMainOrder;
            objTableDataBL.RowNum = 12;
            clsPosition objPosition = new clsPosition();
            objPosition.iRow = 3;
            objPosition.iCol = 5;
            int intIndex = objTableDataBL.GetIndexByPosition_RowCol(objPosition);
            clsPosition objPosition_New = objTableDataBL.GetPosition_RowCol(intIndex);
            MessageBox.Show(string.Format("IRow:{0}, ICol:{1}", objPosition_New.iRow, objPosition_New.iCol));
        }
        
    }
}
