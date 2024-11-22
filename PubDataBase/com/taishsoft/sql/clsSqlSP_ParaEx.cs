//----------------------
//生成代码版本：6.3.0.0
//生成日期：2008/01/27
//生成者：潘以锋
//注意：需要数据底层（PubDataBase.dll）的版本：4.3.0.0
//========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;

namespace com.taishsoft.sql
{
    public class clsSqlSP_ParaEx : clsSqlSP_Para
    {

        public clsSqlSP_ParaEx()
            : base()
        {
        }

        public clsSqlSP_ParaEx(long lngmId)
            : base(lngmId)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lngmId"></param>
        /// <param name="bolIsGetSqlSP_Para"></param>
        public clsSqlSP_ParaEx(long lngmId, bool bolIsGetSqlSP_Para)
            : base(lngmId, bolIsGetSqlSP_Para)
        {
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_SqlSP_Para(System.Windows.Forms.ListView lvSqlSP_Para, string strWhereCond)
        {
            //	操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviSqlSP_Para;
            ArrayList arrSqlSP_ParaObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrSqlSP_ParaObjList = new clsSqlSP_Para().GetSqlSP_ParaObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvSqlSP_Para.Items.Clear();//清除原来所有Item
            lvSqlSP_Para.Columns.Clear();//清除原来所有列头信息
            lvSqlSP_Para.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("存储过程ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("参数名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("参数长度", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("参数数据类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("参数数据类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("是否可空", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsSqlSP_Para objSqlSP_Para in arrSqlSP_ParaObjList)
            {
                lviSqlSP_Para = new System.Windows.Forms.ListViewItem();
                lviSqlSP_Para.Tag = objSqlSP_Para.mId;
                lviSqlSP_Para.Text = objSqlSP_Para.mId.ToString();
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.id_StoreProcedure.ToString());
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.ParaName);
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.ParaSize.ToString());
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.ParaDataType);
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.ParaDirection);
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.IsNullable.ToString());
                lvSqlSP_Para.Items.Add(lviSqlSP_Para);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrSqlSP_ParaObjList.Count;
        }
    }
}