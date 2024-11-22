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
    public partial class frmTestBiDimDistribute : Form
    {
        public frmTestBiDimDistribute()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();

            objBiDimDistribute.RowNum = 4;
            objBiDimDistribute.TotalTableHeight = 800;
            objBiDimDistribute.HeightWeights[0] = 1;
            objBiDimDistribute.HeightWeights[1] = 2;
            objBiDimDistribute.HeightWeights[2] = 3;
            objBiDimDistribute.HeightWeights[3] = 4;
            objBiDimDistribute.MinHeights[0] = 120;

            objBiDimDistribute.CalcRowHeightByWeights();
            StringBuilder sbMsg = new StringBuilder();
            for (int i = 0; i < objBiDimDistribute.RowNum; i++)
            {
                sbMsg.AppendFormat("行{0}的高为:{1}\n\r", i, objBiDimDistribute.CalcRowHeight[i]);
            }
            MessageBox.Show(sbMsg.ToString());
        }

        private void btnCalcColWidth_Click(object sender, EventArgs e)
        {
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();

            objBiDimDistribute.ColNum = 4;
            objBiDimDistribute.TotalTableWidth = 800;
            objBiDimDistribute.WidthWeights[0] = 1;
            objBiDimDistribute.WidthWeights[1] = 2;
            objBiDimDistribute.WidthWeights[2] = 3;
            objBiDimDistribute.WidthWeights[3] = 4;
            objBiDimDistribute.MinWidths[0] = 120;

            objBiDimDistribute.CalcColWidthByWeights();
            StringBuilder sbMsg = new StringBuilder();
            for (int i = 0; i < objBiDimDistribute.ColNum; i++)
            {
                sbMsg.AppendFormat("列{0}的宽为:{1}\n\r", i, objBiDimDistribute.CalcColWidth[i]);
            }
            MessageBox.Show(sbMsg.ToString());
        }

        private void btnCalcPosition_Click(object sender, EventArgs e)
        {
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();

            objBiDimDistribute.RowNum = 4;
            objBiDimDistribute.TotalTableHeight = 800;
            objBiDimDistribute.HeightWeights[0] = 1;
            objBiDimDistribute.HeightWeights[1] = 2;
            objBiDimDistribute.HeightWeights[2] = 3;
            objBiDimDistribute.HeightWeights[3] = 4;
            objBiDimDistribute.MinHeights[0] = 120;
            objBiDimDistribute.ColNum = 4;
            objBiDimDistribute.TotalTableWidth = 800;
            objBiDimDistribute.WidthWeights[0] = 1;
            objBiDimDistribute.WidthWeights[1] = 2;
            objBiDimDistribute.WidthWeights[2] = 3;
            objBiDimDistribute.WidthWeights[3] = 4;
            objBiDimDistribute.MinWidths[0] = 120;
            objBiDimDistribute.StartX = 100;
            objBiDimDistribute.StartY = 100;
            objBiDimDistribute.IsCalcColWidthByWeights = true;
            objBiDimDistribute.IsCalcRowHeightByWeights = true;

            objBiDimDistribute.CalcColWidthByWeights();
            objBiDimDistribute.CalcRowHeightByWeights();
         
            StringBuilder sbMsg = new StringBuilder();
            for (int i = 0; i < objBiDimDistribute.ColNum * objBiDimDistribute.RowNum; i++)
            {
                PointF objPointF = objBiDimDistribute.GetPosition(i);
                sbMsg.AppendFormat("控件{0}的位置为:{1}、{2}\n\r", i, objPointF.X, objPointF.Y);
            }
            MessageBox.Show(sbMsg.ToString());
         
        }
    }
}
