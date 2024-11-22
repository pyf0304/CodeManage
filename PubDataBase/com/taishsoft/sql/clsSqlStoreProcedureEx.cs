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
    public class clsSqlStoreProcedureEx : clsSqlStoreProcedure
    {
        public ArrayList arrSpParamObjList = null;
        public clsSqlStoreProcedureEx()
            : base()
        {
            arrSpParamObjList = new ArrayList();
        }

        public clsSqlStoreProcedureEx(long lngmId)
            : base(lngmId)
        {
            arrSpParamObjList = new ArrayList();
        }

        public clsSqlStoreProcedureEx(long lngmId, bool bolIsGetSqlStoreProcedure)
            : base(lngmId, bolIsGetSqlStoreProcedure)
        {
            arrSpParamObjList = new ArrayList();
        }

        public void AddSpParamObj(clsSqlSP_Para objSqlSp_Para)
        {
            arrSpParamObjList.Add(objSqlSp_Para);
        }

      

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_SqlStoreProcedure(System.Windows.Forms.ListView lvSqlStoreProcedure, string strWhereCond)
        {
            //	操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviSqlStoreProcedure;
            ArrayList arrSqlStoreProcedureObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrSqlStoreProcedureObjList = new clsSqlStoreProcedure().GetSqlStoreProcedureObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvSqlStoreProcedure.Items.Clear();//清除原来所有Item
            lvSqlStoreProcedure.Columns.Clear();//清除原来所有列头信息
            lvSqlStoreProcedure.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlStoreProcedure.Columns.Add("SP_ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlStoreProcedure.Columns.Add("存储过程名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlStoreProcedure.Columns.Add("uid", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlStoreProcedure.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsSqlStoreProcedure objSqlStoreProcedure in arrSqlStoreProcedureObjList)
            {
                lviSqlStoreProcedure = new System.Windows.Forms.ListViewItem();
                lviSqlStoreProcedure.Tag = objSqlStoreProcedure.mId;
                lviSqlStoreProcedure.Text = objSqlStoreProcedure.mId.ToString();
                lviSqlStoreProcedure.SubItems.Add(objSqlStoreProcedure.SP_ID.ToString());
                lviSqlStoreProcedure.SubItems.Add(objSqlStoreProcedure.SP_Name);
                lviSqlStoreProcedure.SubItems.Add(objSqlStoreProcedure.uid.ToString());
                lvSqlStoreProcedure.Items.Add(lviSqlStoreProcedure);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrSqlStoreProcedureObjList.Count;
        }
    }
}