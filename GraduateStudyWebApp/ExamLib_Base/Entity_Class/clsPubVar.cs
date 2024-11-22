using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;


namespace Questionnaire.Entity
{
    /// <summary>
    /// clsPubVar 的摘要说明
    /// </summary>
    public class clsPubVar
    {
        public clsPubVar()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            
        }
      //public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysPara.ConfigFileName)
        //public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysPara.ConfigFileName)

        /// <summary>
        /// 通过列名隐藏GridView的列
        /// </summary>
        /// <param name="arrHidItem">存储需要隐藏的列名（多个）</param>
        /// <param name="gvThis">需要隐藏的GridView</param>
        //public static void HidGvColumnByArray(System.Collections.ArrayList arrHidItem, GridView gvThis)
        //{
        //    GetGVCollumPositionListByName(arrHidItem, gvThis);
        //    for (int k = 0; k < arrHidItem.Count; k++)
        //    {
        //        gvThis.Columns[(int)arrHidItem[k]].Visible = false;
        //    }
        //}
        /// <summary>
        /// 通过名字取得需要的列的位置
        /// </summary>
        /// <param name="arrCollumName">名称列表</param>
        /// <param name="gvThis">需要操作的GridView</param>
        /// <returns></returns>
        private static ArrayList GetGVCollumPositionListByName(System.Collections.ArrayList arrCollumName, GridView gvThis)
        {

            int cellNum = gvThis.Columns.Count;
            for (int j = 0; j < arrCollumName.Count; j++)
            {
                int IndexOfItem = 0;
                for (int i = 0; i < cellNum; i++)
                {
                    if (gvThis.Columns[i].HeaderText == arrCollumName[j].ToString())
                    {
                        IndexOfItem = i;
                        break;
                    }
                }
                arrCollumName[j] = IndexOfItem;
            }
            return arrCollumName;
        }
       /// <summary>
       /// 在Gridview的列中显示字段前5个字符，其完整内容在TOOLTIP中显示
       /// </summary>
       /// <param name="objGv">当前Gridview控件</param>
       /// <param name="Rcount">所要操作的字段列的索引号</param>
       /// <param name="Cname">该字段列中用做显示的Label控件名称</param>
        public void GetSubstring(System.Web.UI.WebControls.GridView objGv,int Rcount,string Cname)
        {

            for (int i = 0; i < objGv.Rows.Count; i++)
            {
                GridViewRow objdvr = objGv.Rows[i];
                Label objlb = (Label)objdvr.Cells[Rcount].FindControl(Cname);
                if (objlb.ToolTip.ToString().Length <= 5)
                {
                    objlb.Text = objlb.ToolTip.ToString();
                }
                else
                    objlb.Text = objlb.ToolTip.ToString().Substring(0, 5) + "...";

            }
        }
        public void GvNullsetText(System.Web.UI.WebControls.GridView objgv,System.Web.UI.WebControls.Label objlabel)
        {
            if (objgv.Rows.Count == 0)
            {
                objlabel.Text = "无记录！";
            }
        }
    }
}