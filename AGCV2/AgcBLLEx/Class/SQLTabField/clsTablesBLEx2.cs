using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.sql;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;
using System.Linq;
using com.taishsoft.common;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 
    /// </summary>
    public class clsTablesBLEx
    {



        /////���ɰ�ListView�Ĵ���
        ///// <summary>
        ///// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        /////			 ����ʾ��ListView�С�
        ///// </summary>
        //public static int BindLv_Tables(System.Windows.Forms.ListView lvTables, string strWhereCond)
        //{
        //    //��������:(��4��)
        //    //	1����Ͻ�����������
        //    //	2��������������ȡ�ñ�����������DataTable��
        //    //	3������ListView����ͷ��Ϣ
        //    //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
        //    //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

        //    System.Windows.Forms.ListViewItem lviTables;
        //    List<clsTablesEN> arrTablesObjList;
        //    //	2��������������ȡ�ñ�����������DataTable��
        //    arrTablesObjList = clsTablesBL.GetTablesObjList(strWhereCond);
        //    //	3������ListView����ͷ��Ϣ
        //    lvTables.Items.Clear();//���ԭ������Item
        //    lvTables.Columns.Clear();//���ԭ��������ͷ��Ϣ
        //    lvTables.Columns.Add("����", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvTables.Columns.Add("�ֶ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvTables.Columns.Add("���ݿ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvTables.View = System.Windows.Forms.View.Details;
        //    //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
        //    foreach (clsTablesEN objTables in arrTablesObjList)
        //    {
        //        lviTables = new System.Windows.Forms.ListViewItem();
        //        lviTables.Tag = objTables.TabName;
        //        lviTables.Text = objTables.TabName;
        //        lviTables.SubItems.Add(objTables.ColumnsNum.ToString());
        //        lviTables.SubItems.Add(objTables.DataBaseName);
        //        lvTables.Items.Add(lviTables);
        //    }
        //    //	4�����ü�¼����״̬,
        //    //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
        //    return arrTablesObjList.Count;
        //}
        /// <summary>
        /// ����:��ȡ������ĳӵ���ߵ���������Ϣ
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <param name = "strDataBaseOwner">������ӵ����</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static DataTable GetColumns(string strTabName, string strDataBaseOwner, string strPrjDataBaseId)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);
            objDT = objSQL.GetColumns(strTabName, strDataBaseOwner);
            return objDT;
        }
        /// <summary>
        /// ����:��ȡ���������������Ϣ
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static DataTable GetColumns(string strTabName, string strPrjDataBaseId)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            objDT = objSQL.GetColumns(strTabName, objPrjDataBase.DatabaseOwner);
            return objDT;
        }
        /// <summary>
        /// ����:��ȡ���������������Ϣ
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <param name = "strPrjDataBaseId">�������ݿ�Id</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static List<clsColumns> GetColumnObjList(string strTabName, string strPrjDataBaseId)
        {
            List<clsColumns> arrColumnObjList = new List<clsColumns>();
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            if (objPrjDataBase == null)
            {
                string strMsg = string.Format("�������ݿ�Id:[{0}]û����Ӧ�ļ�¼�����飡", strPrjDataBaseId);
                throw new Exception(strMsg);
            }
            objDT = objSQL.GetColumns(strTabName, objPrjDataBase.DatabaseOwner);

            foreach (DataRow objRow in objDT.Rows)
            {
                clsColumns objColumns = new clsColumns();
                objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();
                objColumns.Type_Name = objRow["Type_Name"].ToString().Trim();
                objColumns.length = int.Parse(objRow["length"].ToString());
                objColumns.Is_Nullable = objRow["Is_Nullable"].ToString();
                arrColumnObjList.Add(objColumns);
            }
            return arrColumnObjList;
        }

        /// <summary>
        /// ����:�Ƿ���ڸ�����
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <param name = "strPrjDataBaseId">�������ݿ�Id</param>
        /// <returns>�����Ƿ���ڱ�</returns>
        public static bool IsExistTable(string strTabName, string strPrjDataBaseId)
        {

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            if (objPrjDataBase == null)
            {
                string strMsg = string.Format("�������ݿ�Id:[{0}]û����Ӧ�ļ�¼�����飡", strPrjDataBaseId);
                throw new Exception(strMsg);
            }
            bool bolIsExist = objSQL.IsExistTable(strTabName);

            return bolIsExist;
        }



        /// <summary>
        /// ����:��ȡ���������������Ϣ
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static DataTable GetConstraints(string strTabName, string strPrjDataBaseId)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            objDT = objSQL.GetConstraint(strTabName);
            return objDT;
        }


        /// <summary>
        /// ����:��ȡ�������ĳ�ֶε�����Լ��������
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <param name = "strFldName">�������ֶ���</param>
        /// <param name = "strPrjDataBaseId">���ݿ�Id</param>
        /// <returns>����Լ��������</returns>
        public static List<string> GetConstraintNameLst4FldName(string strTabName, string strFldName, string strPrjDataBaseId)
        {
            List<clsConstraints> arrConstraints = GetConstraintObjList(strTabName, strPrjDataBaseId);
            string strFindStr = string.Format("on column {0}", strFldName);
            List<clsConstraints> arrConstraints_Sel = arrConstraints.Where(x => x.Constraint_type.Contains(strFindStr) == true).ToList();
            List<string> arrConstraintName = arrConstraints_Sel.Select(x => x.Constraint_Name).ToList();
            return arrConstraintName;
        }

        /// <summary>
        /// ����:��ȡ���������������Ϣ
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static List<clsConstraints> GetConstraintObjList(string strTabName, string strPrjDataBaseId)
        {
            List<clsConstraints> arrConstraintObjList = new List<clsConstraints>();
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            if (objPrjDataBase == null)
            {
                string strMsg = string.Format("�������ݿ�Id:[{0}]û����Ӧ�ļ�¼�����飡", strPrjDataBaseId);
                throw new Exception(strMsg);
            }
            objDT = objSQL.GetConstraint(strTabName);

            foreach (DataRow objRow in objDT.Rows)
            {
                clsConstraints objConstraints = new clsConstraints();
                objConstraints.Constraint_Name = objRow["Constraint_Name"].ToString().Trim();     //����
                objConstraints.Constraint_type = objRow["Constraint_type"].ToString().Trim();     //��������
                objConstraints.Delete_action = objRow["Delete_action"].ToString().Trim();     //�ֶγ���
                objConstraints.Status_for_replication = objRow["Status_for_replication"].ToString().Trim();     //�Ƿ�ɿ�
                objConstraints.Constraint_keys = objRow["Constraint_keys"].ToString().Trim();     //�ֶ�ȱʡֵ
                objConstraints.Update_action = objRow["Update_action"].ToString().Trim();     //��ȷ��
                arrConstraintObjList.Add(objConstraints);
            }
            return arrConstraintObjList;
        }



        /// <summary>
        /// ����:��ȡ�������������Ϣ
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <param name = "strPrjDataBaseId">���ݿ�Id</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static DataTable GetDataTableByTabName(string strTabName, string strPrjDataBaseId)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strSql = string.Format("Select * from {0}", strTabName);
            objDT = objSQL.GetDataTable(strSql);
            return objDT;
        }

        public static List<string> GetKeyValuesByTabName(string strTabName, List<string> arrKeyFldName, string strWhere, string strSortExpress, string strPrjDataBaseId)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strSql = "";
            string strKeyFldName = string.Join(",", arrKeyFldName);
            if (string.IsNullOrEmpty(strSortExpress))
            {
                strSql = string.Format("Select top 1 * from {0} where {1} order by {2} desc", strTabName, strWhere, strKeyFldName);
            }
            else
            {
                strSql = string.Format("Select top 1 * from {0} where {1} order by {2} desc", strTabName, strWhere, strSortExpress);
            }
            try
            {
                List<string> arrKeyFldValue = new List<string>();
                objDT = objSQL.GetDataTable(strSql);
                if (objDT.Rows.Count == 0) return arrKeyFldValue;
                var objRow = objDT.Rows[0];
                foreach (var strFldName in arrKeyFldName)
                {
                    var strKeyValue = objRow[strFldName].ToString();
                    arrKeyFldValue.Add(strKeyValue);
                }
                return arrKeyFldValue;
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("���ݱ�����ȡ�ؼ���ֵ��������:[{0}], �ؼ��ֶ�:[{1}],����:[{2}], ������Ϣ:{3}.(in {4}) ",
                    strTabName, strKeyFldName, strSortExpress, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            //return "";
        }
        /// <summary>
        /// ����:��ȡ������ķ�ҳ��������
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <param name = "strPrjDataBaseId">���ݿ�Id</param>
        /// <param name = "strKeyFldName">��ؼ���</param>
        /// <param name = "intPageIndex">ҳ���</param>
        /// <param name = "intPageSize">ҳ��¼��</param>
        /// <param name = "strCondition">������</param>
        /// <param name = "strOrderBy">����ʽ</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static DataTable GetDataTableByPager(string strPrjDataBaseId, string strTabName, string strKeyFldName, int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            objDT = objSQL.GetDataTableByPager(strTabName, strKeyFldName, intPageIndex, intPageSize, strCondition, strOrderBy);
            return objDT;
        }

        /// <summary>
        /// ����:��ȡ������ķ�ҳ��������
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <param name = "strPrjDataBaseId">���ݿ�Id</param>
        /// <param name = "intTopSize">������¼��</param>
        /// <param name = "strCondition">������</param>
        /// <param name = "strOrderBy">����ʽ</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static DataTable GetDataTableByTop(string strPrjDataBaseId, string strTabName, int intTopSize, string strCondition, string strOrderBy)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            objDT = objSQL.GetDataTableByTop(strTabName, intTopSize, strCondition, strOrderBy);
            return objDT;
        }

        /// <summary>
        /// ����:��ȡ������ĸ����ؼ���ֵ��һ������
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <param name = "strPrjDataBaseId">���ݿ�Id</param>
        /// <param name = "strKeyFldName">��ؼ���</param>
        /// <param name = "strKeyValue">�ؼ���ֵ</param>
        /// <param name = "bolIsNumurable">�Ƿ���ֵ��</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static DataTable GetDataTableByKey(string strPrjDataBaseId, string strTabName, string strKeyFldName, string strKeyValue, bool bolIsNumurable)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            objDT = objSQL.GetDataTableByKey(strTabName, strKeyFldName, strKeyValue, bolIsNumurable);
            return objDT;
        }

        /// <summary>
        /// ����:��ȡ������ĸ����ؼ���ֵ��һ������
        /// </summary>
        /// <param name = "strTabName">�����ı���</param>
        /// <param name = "strPrjDataBaseId">���ݿ�Id</param>
        /// <returns>���������������Ϣ,��DataTable��ʽ</returns>
        public static int GetRecNum4TabName(string strPrjDataBaseId, string strTabName)
        {

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);
            //var strSql = string.Format("EXEC SP_SPACEUSED '{0}'", strTabName);
            int intRecNum = objSQL.GetRecCount(strTabName);
            return intRecNum;
        }
        /// <summary>
        /// ��ȡ���ݿ������б�
        /// </summary>
        /// <param name="strPrjDataBaseId">���ݿ�id,����ĳ�����ݿ�</param>
        /// <param name="strWhereCond">����</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataTable GetTableAndViewsByCond(string strPrjDataBaseId, string strWhereCond)
        {
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);

            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

                clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN(strPrjDataBaseId);
                clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBaseEN);
                objDT = objSQL.getTableAndViewsByCond(strWhereCond);

                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;

                throw new Exception(strMsg);
            }
        }

    }
}