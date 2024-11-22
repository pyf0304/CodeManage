using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System.Collections.Generic;

namespace com.taishsoft.sql
{
    /// <summary>
    /// 
    /// </summary>
    public class clsSqlObject
    {

        /// <summary>
        /// ���ܣ���ȡ������ĳӵ���ߵ���������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <param name="strDataBaseOwner">������ӵ����</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public static DataTable GetColumns(string strTabName, string strConnectString, string strDataBaseOwner)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strDataBaseOwner);
            return objDT;
        }
        ///// <summary>
        ///// ���ܣ���ȡ���������������Ϣ,ӵ����Ϊdbo
        ///// </summary>
        ///// <param name="strTabName">�����ı���</param>
        ///// <returns>���������������Ϣ����DataTable��ʽ</returns>
        //public static DataTable GetColumnsByDbo(string strTabName, string strConnectString)
        //{
        //    System.Data.DataTable objDT;

        //    clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

        //    objDT = objSQL.GetColumnsByDbo(strTabName);
        //    return objDT;
        //}
        ///// <summary>
        ///// ���ܣ���ȡ���������������Ϣ
        ///// </summary>
        ///// <param name="strTabName">�����ı���</param>
        ///// <returns>���������������Ϣ����DataTable��ʽ</returns>
        //public static ArrayList GetColumnObjListByDbo(string strTabName, string strConnectString)
        //{
        //    ArrayList arrColumnObjList = new ArrayList();
        //    System.Data.DataTable objDT;

        //    clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
        //    objDT = objSQL.GetColumnsByDbo(strTabName);

        //    foreach (DataRow objRow in objDT.Rows)
        //    {
        //        clsColumns objColumns = new clsColumns();
        //        objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();
        //        objColumns.Type_Name = objRow["Type_Name"].ToString().Trim();
        //        objColumns.length = int.Parse(objRow["length"].ToString());
        //        objColumns.Is_Nullable = objRow["Is_Nullable"].ToString();
        //        objColumns.COLUMN_DEF = objRow["COLUMN_DEF"].ToString();
        //        objColumns.PRECISION = int.Parse(objRow["PRECISION"].ToString());

        //        arrColumnObjList.Add(objColumns);
        //    }
        //    return arrColumnObjList;
        //}
      
        /// <summary>
        /// ���ܣ���ȡ���������������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <param name="strConnectString">���Ӵ�</param>
        /// <param name="strDataBaseOwner">ӵ����</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public static List<clsColumns> GetColumnObjList(string strTabName, string strConnectString, string strDataBaseOwner)
        {
            List<clsColumns> arrColumnObjList = new List<clsColumns>();
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strDataBaseOwner);

            foreach (DataRow objRow in objDT.Rows)
            {
                clsColumns objColumns = new clsColumns();
                objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();
                objColumns.Type_Name = objRow["Type_Name"].ToString().Trim();
                objColumns.length = int.Parse(objRow["length"].ToString());
                objColumns.Is_Nullable = objRow["Is_Nullable"].ToString();
                objColumns.COLUMN_DEF = objRow["COLUMN_DEF"].ToString();
                objColumns.PRECISION = int.Parse( objRow["PRECISION"].ToString());

                arrColumnObjList.Add(objColumns);
            }
            return arrColumnObjList;
        }

        /// <summary>
        /// ���ܣ���ȡ���������������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <param name="strConnectString">���Ӵ�</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public static List<clsColumns> GetColumnObjList(string strTabName, string strConnectString)
        {
            List<clsColumns> arrColumnObjList = new List<clsColumns>();
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.GetColumns(strTabName);

            foreach (DataRow objRow in objDT.Rows)
            {
                clsColumns objColumns = new clsColumns();
                objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();
                objColumns.Type_Name = objRow["Type_Name"].ToString().Trim();
                objColumns.length = int.Parse(objRow["length"].ToString());
                objColumns.Is_Nullable = objRow["Is_Nullable"].ToString();
                objColumns.COLUMN_DEF = objRow["COLUMN_DEF"].ToString();
                objColumns.PRECISION = int.Parse(objRow["PRECISION"].ToString());

                arrColumnObjList.Add(objColumns);
            }
            return arrColumnObjList;
        }


        /// <summary>
        /// ���ܣ���ȡ���������������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <param name="strConnectString">���Ӵ�</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public static int GetColumnCount(string strTabName, string strConnectString)
        {
          
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            int intCount = objSQL.GetColumnsCount(strTabName);

            return intCount;
        }

        /// <summary>
        /// ���ܣ���ȡ�����������е�����Ϣ���ö������ʽ��ʾ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>       
        /// <param name="strColumnName">�ֶ���</param>
        /// <param name="strConnectString">���Ӵ�</param>
        /// <param name="strDataBaseOwner">ӵ����</param>
        /// <returns>������,��������Ϣ���ö������ʽ��ʾ</returns>
        public static clsColumns GetColumnObj(string strTabName, string strColumnName, string strConnectString, string strDataBaseOwner)
        {
            ArrayList arrColumnObjList = new ArrayList();
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strDataBaseOwner);
            foreach (DataRow objRow in objDT.Rows)
            {
                string strColumn_Name_Temp = objRow["Column_Name"].ToString().Trim();
                if (string.Compare(strColumnName, strColumn_Name_Temp, true) == 0)
                {
                    clsColumns objColumns = new clsColumns();
                    objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();
                    objColumns.Type_Name = objRow["Type_Name"].ToString().Trim();
                    objColumns.length = int.Parse(objRow["length"].ToString());
                    objColumns.Is_Nullable = objRow["Is_Nullable"].ToString();
                    objColumns.COLUMN_DEF = objRow["COLUMN_DEF"].ToString();
                    objColumns.PRECISION = int.Parse(objRow["PRECISION"].ToString());
                    return objColumns;
                }
            }
            return null;
        }

        /// <summary>
        /// ���ܣ���ȡ���������������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public static clsColumns GetColumnObjList(string strTabName, string strColumnName, string strConnectString, string strDataBaseOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strColumnName, strDataBaseOwner);
            if (objDT.Rows.Count != 1)
            {
                return null;
            }
            clsColumns objColumns = new clsColumns();
            objColumns.Column_Name = objDT.Rows[0]["Column_Name"].ToString().Trim();
            objColumns.Type_Name = objDT.Rows[0]["Type_Name"].ToString().Trim();
            objColumns.length = int.Parse(objDT.Rows[0]["length"].ToString());
            objColumns.Is_Nullable = objDT.Rows[0]["Is_Nullable"].ToString();
            objColumns.COLUMN_DEF = objDT.Rows[0]["COLUMN_DEF"].ToString();
            objColumns.PRECISION = int.Parse(objDT.Rows[0]["PRECISION"].ToString());
            return objColumns;
        }

        /// <summary>
        /// ���ܣ���ȡ�����е���������
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public static string GetColumnTypeName(string strTabName, string strColumnName, string strConnectString, string strDataBaseOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strColumnName, strDataBaseOwner);
            if (objDT.Rows.Count != 1)
            {
                throw new Exception (new StringBuilder().AppendFormat("�ڱ�[{0}].[{1}]��û���ֶ�{2}�����飡", strDataBaseOwner, strTabName, strColumnName).ToString());
            }
            string strTypeName = objDT.Rows[0]["Type_Name"].ToString().Trim();
            return strTypeName;
        }
        /// <summary>
        /// ��ȡָ�����������������ݿ�
        /// </summary>
        /// <returns>�����������ݿ��DataTable</returns>
        public static System.Data.DataTable getDataBases(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getDataBases();
            return objDT;

        }


        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static System.Data.DataTable getTables(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getTables();
            return objDT;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static System.Data.DataTable getTables(string strConnectString, string strOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getTablesByOwner(strOwner);
            return objDT;
        }
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б��������б�
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static List<clsSqlTabView> getTableObjList(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getTables();
            DataTable objDT_sp = objSQL.getTableAndViewsBySp_Tables();

            List<clsSqlTabView> arrTableObjList = new List<clsSqlTabView>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlTabView objSqlTabView = new clsSqlTabView();
                objSqlTabView.Id = long.Parse( objRow["Id"].ToString());
                objSqlTabView.Name = objRow["Name"].ToString().Trim();
                objSqlTabView.FldNum = int.Parse( objRow["info"].ToString());
                objSqlTabView.ConnectString = strConnectString;
                foreach (DataRow objRow_sp in objDT_sp.Rows)
                {
                    if (objSqlTabView.Name == objRow_sp["Table_Name"].ToString().Trim())
                    {
                        objSqlTabView.Owner = objRow_sp["Table_Owner"].ToString().Trim();
                        objSqlTabView.TabType = objRow_sp["Table_Type"].ToString().Trim();

                    }
                }
                arrTableObjList.Add(objSqlTabView);
            }
            return arrTableObjList;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б��������б�
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static List<clsSqlTabView> getViewObjList(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getViews();
            DataTable objDT_sp = objSQL.getTableAndViewsBySp_Tables();

            List<clsSqlTabView> arrTableObjList = new List<clsSqlTabView>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlTabView objSqlTabView = new clsSqlTabView();
                objSqlTabView.Id = long.Parse(objRow["Id"].ToString());
                objSqlTabView.Name = objRow["Name"].ToString().Trim();
                objSqlTabView.FldNum = int.Parse(objRow["info"].ToString());
                objSqlTabView.ConnectString = strConnectString;
                foreach (DataRow objRow_sp in objDT_sp.Rows)
                {
                    if (objSqlTabView.Name == objRow_sp["Table_Name"].ToString().Trim())
                    {
                        objSqlTabView.Owner = objRow_sp["Table_Owner"].ToString().Trim();
                        objSqlTabView.TabType = objRow_sp["Table_Type"].ToString().Trim();

                    }
                }
                arrTableObjList.Add(objSqlTabView);
            }
            return arrTableObjList;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б���ͼ����
        /// </summary>
        /// <returns>���б���ͼ����DataTable</returns>
        public static System.Data.DataTable getTableAndViews(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getTableAndViews();
            return objDT;
        }

        ///// <summary>
        ///// ��ȡ�����ķ����������ݿ������б���ͼ����
        ///// </summary>
        ///// <returns>���б���ͼ����DataTable</returns>
        //public static System.Data.DataTable getTableAndViewsBak20130307(string strConnectString, string strOwner)
        //{
        //    System.Data.DataTable objDT;
        //    clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
        //    objDT = objSQL.getTableAndViewsByOwner(strOwner);
        //    return objDT;
        //}
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б���ͼ�������б�
        /// </summary>
        /// <returns>���б���ͼ����DataTable</returns>
        public static List<clsSqlTabView> getTableAndViewObjList(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getTableAndViewsByDbo();
            DataTable objDT_sp = objSQL.getTableAndViewsBySp_Tables();
            List<clsSqlTabView> arrTableObjList = new List<clsSqlTabView>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlTabView objSqlTabView = new clsSqlTabView();
                objSqlTabView.Id = long.Parse(objRow["Id"].ToString());
                objSqlTabView.Name = objRow["Name"].ToString().Trim();
                //objSqlTabView.Owner = objRow["Owner"].ToString().Trim();
                objSqlTabView.FldNum = int.Parse(objRow["info"].ToString());
                foreach (DataRow objRow_sp in objDT_sp.Rows)
                {
                    if (objSqlTabView.Name == objRow_sp["Table_Name"].ToString().Trim())
                    {
                        objSqlTabView.Owner = objRow_sp["Table_Owner"].ToString().Trim();
                        objSqlTabView.TabType = objRow_sp["Table_Type"].ToString().Trim();

                    }
                }
                objSqlTabView.ConnectString = strConnectString;
                arrTableObjList.Add(objSqlTabView);
            }
            return arrTableObjList;
        }


        /// <summary>
        /// �Ƿ���ڸ�����
        /// </summary>
        /// <param name="strConnectString">����ص�����</param>
        /// <param name="strTabName">����</param>
        /// <returns>�Ƿ���ڣ�</returns>
        public static bool IsExistTable(string strConnectString, string strTabName)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.IsExistTable(strTabName);
        }

        /// <summary>
        /// �Ƿ���ڴ洢���̣�
        /// </summary>
        /// <param name="strConnectString">�洢������ص�����</param>
        /// <param name="strStoreProcedure">�洢����</param>
        /// <param name="strOwner">ӵ����</param>
        /// <returns>�Ƿ���ڣ�</returns>
        public static bool IsExistStoreProcedure(string strConnectString, string strStoreProcedure, string strOwner)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.IsExistStoreProcedure(strStoreProcedure, strOwner);
        }
        /// <summary>
        /// �ж������ı����Ƿ����ĳ�ֶΡ�
        /// </summary>
        /// <param name="strConnectString">�����ص�����</param>
        /// <param name="strTabName">����</param>
        /// <param name="strDataBaseOwner">��ӵ����</param>
        /// <param name="strColumnName">����</param>
        /// <returns>�Ƿ���ڣ�</returns>
        public static bool IsExistColumnInTable(string strConnectString, string strTabName, 
            string strDataBaseOwner, string strColumnName)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.IsExistColumnInTable(strTabName, strDataBaseOwner, strColumnName);
        }

        /// <summary>
        /// �ж��������ֶ��Ƿ�Identity�ֶΡ�
        /// </summary>
        /// <param name="strConnectString">�����ص�����</param>
        /// <param name="strTabName">����</param>
        /// <param name="strDataBaseOwner">��ӵ����</param>
        /// <param name="strColumnName">����</param>
        /// <returns>�Ƿ�Identity��</returns>
        public static bool IsIdentityColumn(string strConnectString, string strTabName,
           string strDataBaseOwner, string strColumnName)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.IsIdentity(strTabName, strDataBaseOwner, strColumnName);
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ�������VIEW����
        /// </summary>
        /// <returns>����View����DataTable</returns>
        public static System.Data.DataTable getViews(string strConnectString, string strOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getViewsByOwner(strOwner);
            return objDT;
        }

        /// <summary>
        /// ��ȡ���ݱ�������б�
        /// </summary>
        /// <param name="strConnectString">���Ӵ�</param>
        /// <param name="strTabName">����</param>
        /// <returns>�����б���ArrayList��ʽ����</returns>
        public static ArrayList GetPKeys(string strConnectString, string strTabName)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.GetPKeys(strTabName);
        }

        /// <summary>
        /// ��ȡ���ݱ�������б�
        /// </summary>
        /// <param name="strConnectString">���Ӵ�</param>
        /// <param name="strTabName">����</param>
        /// <param name="strDataBaseOwner">ӵ����</param>
        /// <returns>�����б���ArrayList��ʽ����</returns>
        public static ArrayList GetPKeys(string strConnectString, string strTabName, string strDataBaseOwner)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.GetPKeys(strTabName, strDataBaseOwner);
        }

        /// <summary>
        /// ��ȡ���ݱ�������б�
        /// </summary>
        /// <param name="strConnectString">���Ӵ�</param>
        /// <param name="strTabName">����</param>
        /// <param name="strDataBaseOwner">ӵ����</param>
        /// <returns>�����б���List��clsPKeys����ʽ����</returns>
        public static System.Collections.Generic.List<clsPKeys> GetPKeyObjList(string strConnectString, string strTabName, string strDataBaseOwner)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            DataTable objDT = objSQL.GetPKeysDT(strTabName, strDataBaseOwner);
            System.Collections.Generic.List<clsPKeys> arrPKeyObjList = new System.Collections.Generic.List<clsPKeys>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPKeys objPKeys = new clsPKeys();
                //objPKeys.Id = long.Parse(objRow["Id"].ToString());
                objPKeys.COLUMN_NAME = objRow["COLUMN_NAME"].ToString().Trim();
                objPKeys.KEY_SEQ = int.Parse(objRow["KEY_SEQ"].ToString().Trim());
                objPKeys.PK_NAME = objRow["PK_NAME"].ToString().Trim();
                objPKeys.TABLE_NAME = objRow["TABLE_NAME"].ToString().Trim();
                objPKeys.TABLE_OWNER = objRow["TABLE_OWNER"].ToString().Trim();
                objPKeys.TABLE_QUALIFIER = objRow["TABLE_QUALIFIER"].ToString().Trim();
                arrPKeyObjList.Add(objPKeys);
            }
            return arrPKeyObjList;

        }

        /// <summary>
        /// ��ȡ���ݱ������б�
        /// </summary>
        /// <param name="strConnectString">���Ӵ�</param>
        /// <param name="strTabName">����</param>
        /// <param name="strDataBaseOwner">ӵ����</param>
        /// <returns>����б���List��clsFKeys����ʽ����</returns>
        public static System.Collections.Generic.List<clsFKeys> GetFKeyObjList(string strConnectString, string strTabName, string strDataBaseOwner)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            DataTable objDT = objSQL.GetFKeys(strTabName, strDataBaseOwner);
            System.Collections.Generic.List<clsFKeys> arrFKeyObjList = new System.Collections.Generic.List<clsFKeys>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsFKeys objFKeys = new clsFKeys();
                //objFKeys.Id = Int32.Parse(objRow["Id"].ToString().Trim()); //����Id
                objFKeys.FKeyName = objRow["FKeyName"].ToString().Trim(); //�������
                objFKeys.FKeyColumnID = objRow["FKeyColumnID"].ToString().Trim(); //�����Id
                objFKeys.FKeyColumnName = objRow["FKeyColumnName"].ToString().Trim(); //�������
                objFKeys.FKeyTabID = objRow["FKeyTabID"].ToString().Trim(); //�����ID
                objFKeys.FKeyTabName = objRow["FKeyTabName"].ToString().Trim(); //���������
                objFKeys.PKeyColumnID = objRow["PKeyColumnID"].ToString().Trim(); //������ID
                objFKeys.PKeyColumnName = objRow["PKeyColumnName"].ToString().Trim(); //��������
                objFKeys.PKeyTabId = objRow["PKeyTabId"].ToString().Trim(); //������Id
                objFKeys.PKeyTabName = objRow["PKeyTabName"].ToString().Trim(); //��������
                objFKeys.Update_Action = objRow["Update_Action"].ToString().Trim(); //��������
                objFKeys.Delete_Action = Int32.Parse(objRow["Delete_Action"].ToString().Trim()); //����ɾ��
                objFKeys.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
                arrFKeyObjList.Add(objFKeys);
            }
            return arrFKeyObjList;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strConnectString"></param>
        /// <param name="strTabName"></param>
        /// <returns></returns>
        public static DataTable GetFKeys(string strConnectString, string strTabName)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.GetFKeys(strTabName);
        }

        public static DataTable GetConstraint(string strConnectString, string strTabName)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.GetConstraint(strTabName);
        }

        public static string GetFirstPKeys(string strConnectString, string strTabName)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            ArrayList arrLst = objSQL.GetPKeys(strTabName);
            if (arrLst.Count == 0)
            {
                return "";
            }
            return arrLst[0].ToString();
        }
        /// <summary>
        /// �Ƿ���Ҫ����(Quotes)
        /// </summary>
        /// <param name="strDataTypeName">����������</param>
        /// <returns>��Ҫ��</returns>
        public static bool IsNeedQuotes(string strDataTypeName)
        {
            string strTypeName = strDataTypeName.ToLower();
            switch (strTypeName)
            {
                case "text":
                case "string":
                    return true;
                case "char":
                    return true;
                case "varchar":
                case "nvarchar":
                    return true;
                case "bool":
                    return true;
                case "bit":
                    return true;
                case "boolean":
                    return true;
                case "date":
                    return true;
                case "number":
                case "decimal":
                case "money":
                    return false;
                case "smallint":
                case "tinyint":
                case "int":
                    return false;
                case "int identity":
                    return false;
                case "bigint":
                    return false;
                case "bigint identity":
                    return false;
                case "shortint":
                    return false;
                case "double":
                    return false;
                case "datetime":
                    return true;
                case "float":
                    return false;
                case "long":
                    return false;
                default:
                    throw new Exception("���ж��Ƿ�����ź�����û�и��������ͣ�" + strDataTypeName);
//                    return true;
            }
        }
        /// <summary>
        /// �ڽ���ʱ�Ƿ���Ҫ����
        /// </summary>
        /// <param name="strDataTypeName">��������</param>
        /// <returns>�Ƿ���Ҫ?</returns>
        public static bool IsNeedLength(string strDataTypeName)
        {
            if (strDataTypeName == "bigint" || strDataTypeName == "int"
                || strDataTypeName == "float" || strDataTypeName == "bit"
                || strDataTypeName == "double" || strDataTypeName == "text"
                || strDataTypeName == "timestamp" || strDataTypeName == "smallint"
                || strDataTypeName == "tinyint" || strDataTypeName == "money"
                || strDataTypeName == "int identity" 
                || strDataTypeName == "datetime" || strDataTypeName == "smalldatetime"
                || strDataTypeName == "NUMBER"
                || strDataTypeName == "image" || strDataTypeName == "bigint identity")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// �ж�ĳֵ�Ƿ����ĳ����
        /// </summary>
        /// <param name="strDataTypeName"></param>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static bool IsValid(string strDataTypeName, string strValue)
        {
            string strTypeName = strDataTypeName.ToLower();
            switch (strTypeName)
            {
                case "string":
                    return true;
                case "char":
                    return true;
                case "varchar":
                case "nvarchar":
                    return true;
                case "bool":
                    return clsString.IsBoolean(strValue);
                case "bit":
                    return clsString.IsBit(strValue);
                case "boolean":
                    return clsString.IsBoolean(strValue);
                case "date":
                    return clsString.IsDate(strValue);
                case "smallint":
                case "tinyint":
                case "int":
                    return clsString.IsNumeric(strValue);
                case "bigint":
                    return clsString.IsNumeric(strValue);
                case "bigint identity":
                    return clsString.IsNumeric(strValue);
                case "shortint":
                    return clsString.IsNumeric(strValue);
                case "double":
                    return clsString.IsFloat(strValue);
                case "decimal":
                    return clsString.IsFloat(strValue);
                case "datetime":
                    return clsString.IsDate(strValue);
                case "float":
                    return clsString.IsFloat(strValue);
                case "long":
                    return clsString.IsNumeric(strValue);
                case "text":
                    return true;

                default:
                    throw new Exception("��У�麯����û�и��������ͣ�" + strDataTypeName);
//                    return true;
            }
        }


        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static System.Data.DataTable getStoreProcedures(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProcedures();
            return objDT;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static System.Data.DataTable getStoreProceduresByCond(string strConnectString, string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProceduresByCond(strCondition);
            return objDT;
        }
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static System.Data.DataTable getStoreProceduresByOwner(string strConnectString, string strOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProceduresByOwner(strOwner);
            return objDT;
        }
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static System.Data.DataTable getStoreProceduresByOwnerByCond(string strConnectString, string strOwner, string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProceduresByOwnerByCond(strOwner, strCondition);
            return objDT;
        }
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̵Ķ����б�
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <returns>���д洢���̵Ķ����б�</returns>
        public static List<clsSqlStoreProcedure> getStoreProceduresObjList(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProcedures();

            List<clsSqlStoreProcedure> arrStoreProceduresObjList = new List<clsSqlStoreProcedure>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlStoreProcedure objSqlStoreProcedure = new clsSqlStoreProcedure();
                objSqlStoreProcedure.SP_ID = long.Parse(objRow["Id"].ToString());
                objSqlStoreProcedure.SP_Name = objRow["Name"].ToString().Trim();
                objSqlStoreProcedure.uid = int.Parse(objRow["uid"].ToString());
                objSqlStoreProcedure.ConnectString_db = strConnectString;
                arrStoreProceduresObjList.Add(objSqlStoreProcedure);
            }
            return arrStoreProceduresObjList;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̵Ķ����б�
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <param name="strOwner">ӵ����</param>
        /// <returns>�洢���̵Ķ����б�</returns>
        public static List<clsSqlStoreProcedure> getStoreProceduresObjListByOwner(string strConnectString, string strOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProceduresByOwner(strOwner);

            List<clsSqlStoreProcedure> arrStoreProceduresObjList = new List<clsSqlStoreProcedure>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlStoreProcedure objSqlStoreProcedure = new clsSqlStoreProcedure();
                objSqlStoreProcedure.SP_ID = long.Parse(objRow["Id"].ToString());
                objSqlStoreProcedure.SP_Name = objRow["Name"].ToString().Trim();
                objSqlStoreProcedure.uid = int.Parse(objRow["uid"].ToString());
                objSqlStoreProcedure.ConnectString_db = strConnectString;
                arrStoreProceduresObjList.Add(objSqlStoreProcedure);
            }
            return arrStoreProceduresObjList;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̵Ķ����б�
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <param name="strCondition">����</param>
        /// <returns>�洢���̵Ķ����б�</returns>
        public static List<clsSqlStoreProcedure> getStoreProceduresObjListByCond(string strConnectString, string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProceduresByCond(strCondition);

            List<clsSqlStoreProcedure> arrStoreProceduresObjList = new List<clsSqlStoreProcedure>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlStoreProcedure objSqlStoreProcedure = new clsSqlStoreProcedure();
                objSqlStoreProcedure.SP_ID = long.Parse(objRow["Id"].ToString());
                objSqlStoreProcedure.SP_Name = objRow["Name"].ToString().Trim();
                objSqlStoreProcedure.uid = int.Parse(objRow["uid"].ToString());
                objSqlStoreProcedure.ConnectString_db = strConnectString;
                arrStoreProceduresObjList.Add(objSqlStoreProcedure);
            }
            return arrStoreProceduresObjList;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̵Ķ����б�
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <param name="strCondition">����</param>
        /// <returns>�洢���̵Ķ����б�</returns>
        public static List<clsSqlStoreProcedure> getStoreProceduresObjListByOwnerByCond(string strConnectString, string strOwner, string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProceduresByOwnerByCond(strOwner, strCondition);

            List<clsSqlStoreProcedure> arrStoreProceduresObjList = new List<clsSqlStoreProcedure>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlStoreProcedure objSqlStoreProcedure = new clsSqlStoreProcedure();
                objSqlStoreProcedure.SP_ID = long.Parse(objRow["Id"].ToString());
                objSqlStoreProcedure.SP_Name = objRow["Name"].ToString().Trim();
                objSqlStoreProcedure.uid = int.Parse(objRow["uid"].ToString());
                objSqlStoreProcedure.ConnectString_db = strConnectString;
                arrStoreProceduresObjList.Add(objSqlStoreProcedure);
            }
            return arrStoreProceduresObjList;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̲�����
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <returns>���д洢���̲�����DataTable</returns>
        public static System.Data.DataTable getSp_ParaAll(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getSp_ParaAll();
            return objDT;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̲�����
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <param name="strCondition">����</param>
        /// <returns>�洢���̲�����DataTable</returns>
        public static System.Data.DataTable getSp_ParaByCond(string strConnectString, string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getSp_ParaByCond(strCondition);
            return objDT;
        }
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̲�����
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <param name="strSP_Name">�洢������</param>
        /// <returns>�洢���̲�����DataTable</returns>
        public static System.Data.DataTable getSp_ParaByName(string strConnectString, string strSP_Name)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getSp_ParaByName(strSP_Name);
            return objDT;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̲��������б�
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <returns>���д洢���̲����Ķ����б�</returns>
        public static List<clsSqlSP_Para> getSp_ParaAllObjList(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getSp_ParaAll();
            List<clsSqlSP_Para> arrSP_ParasObjList = new List<clsSqlSP_Para>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlSP_Para objSqlSP_Para = new clsSqlSP_Para();
                objSqlSP_Para.id_StoreProcedure = long.Parse(objRow["Id"].ToString());
                objSqlSP_Para.SP_ID = long.Parse(objRow["Id"].ToString());
                objSqlSP_Para.ParaName = objRow["Name"].ToString().Trim();
                objSqlSP_Para.ParaDataType = objRow["ParaDataType"].ToString().Trim();
                objSqlSP_Para.ParaSize = short.Parse( objRow["ParaSize"].ToString().Trim());
                if (objRow["ParaDirection"].ToString().Trim() == "1")
                {
                    objSqlSP_Para.ParaDirection = "spParamOutput";
                }
                else
                {
                    objSqlSP_Para.ParaDirection = "spParamInput";
                }
                if (objRow["IsNullable"].ToString().Trim() == "1")
                {
                    objSqlSP_Para.IsNullable = true;
                }
                else
                {
                    objSqlSP_Para.IsNullable = false;
                }
                arrSP_ParasObjList.Add(objSqlSP_Para);
            }
            return arrSP_ParasObjList;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̲��������б�
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <param name="strCondition">����</param>
        /// <returns>�洢���̲����Ķ����б�</returns>
        public static List<clsSqlSP_Para> getSp_ParaObjListByCond(string strConnectString, string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getSp_ParaByCond(strCondition);
            List<clsSqlSP_Para> arrSP_ParasObjList = new List<clsSqlSP_Para>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlSP_Para objSqlSP_Para = new clsSqlSP_Para();
                objSqlSP_Para.id_StoreProcedure = long.Parse(objRow["Id"].ToString());
                objSqlSP_Para.SP_ID = long.Parse(objRow["Id"].ToString());
                objSqlSP_Para.ParaName = objRow["Name"].ToString().Trim();
                objSqlSP_Para.ParaDataType = objRow["ParaDataType"].ToString().Trim();
                objSqlSP_Para.ParaSize = short.Parse(objRow["ParaSize"].ToString().Trim());
                if (objRow["ParaDirection"].ToString().Trim() == "1")
                {
                    objSqlSP_Para.ParaDirection = "spParamOutput";
                }
                else
                {
                    objSqlSP_Para.ParaDirection = "spParamInput";
                }
                if (objRow["IsNullable"].ToString().Trim() == "1")
                {
                    objSqlSP_Para.IsNullable = true;
                }
                else
                {
                    objSqlSP_Para.IsNullable = false;
                }
                arrSP_ParasObjList.Add(objSqlSP_Para);
            }
            return arrSP_ParasObjList;
        }
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̲��������б�
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <param name="strSP_Name">�洢������</param>
        /// <returns>�洢���̲����Ķ����б�</returns>
        public static List<clsSqlSP_Para> getSp_ParaObjListByName(string strConnectString, string strSP_Name)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getSp_ParaByName(strSP_Name);
            List<clsSqlSP_Para> arrSP_ParasObjList = new List<clsSqlSP_Para>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlSP_Para objSqlSP_Para = new clsSqlSP_Para();
                objSqlSP_Para.id_StoreProcedure = long.Parse(objRow["Id"].ToString());
                objSqlSP_Para.SP_ID = long.Parse(objRow["Id"].ToString());
                objSqlSP_Para.ParaName = objRow["Name"].ToString().Trim();
                objSqlSP_Para.ParaDataType = objRow["ParaDataType"].ToString().Trim();
                objSqlSP_Para.ParaSize = short.Parse(objRow["ParaSize"].ToString().Trim());
                if (objRow["ParaDirection"].ToString().Trim() == "1")
                {
                    objSqlSP_Para.ParaDirection = "spParamOutput";
                }
                else
                {
                    objSqlSP_Para.ParaDirection = "spParamInput";
                }
                if (objRow["IsNullable"].ToString().Trim() == "1")
                {
                    objSqlSP_Para.IsNullable = true;
                }
                else
                {
                    objSqlSP_Para.IsNullable = false;
                }
                arrSP_ParasObjList.Add(objSqlSP_Para);
            }
            return arrSP_ParasObjList;
        }
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������д洢���̵Ķ����б�
        /// </summary>
        /// <param name="strConnectString">�����ķ����������ݿ�</param>
        /// <returns>���д洢���̵Ķ����б�</returns>
        public static List<clsSqlStoreProcedureEx> getStoreProceduresAndParamObjList(string strConnectString)
        {
            System.Data.DataTable objDT_SP , objDT_SP_Param;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT_SP = objSQL.getStoreProcedures();
            objDT_SP_Param = objSQL.getSp_ParaAll();
            List<clsSqlStoreProcedureEx> arrStoreProceduresObjList = new List<clsSqlStoreProcedureEx>();
            foreach (DataRow objRow in objDT_SP.Rows)
            {
                clsSqlStoreProcedureEx objSqlStoreProcedure = new clsSqlStoreProcedureEx();
                objSqlStoreProcedure.SP_ID = long.Parse(objRow["Id"].ToString());
                objSqlStoreProcedure.SP_Name = objRow["Name"].ToString().Trim();
                objSqlStoreProcedure.uid = int.Parse(objRow["uid"].ToString());
                objSqlStoreProcedure.ConnectString_db = strConnectString;
                arrStoreProceduresObjList.Add(objSqlStoreProcedure);
            }

            List<clsSqlSP_Para> arrSP_ParasObjList = new List<clsSqlSP_Para>();
            foreach (DataRow objRow in objDT_SP_Param.Rows)
            {
                clsSqlSP_Para objSqlSP_Para = new clsSqlSP_Para();
                objSqlSP_Para.id_StoreProcedure = long.Parse(objRow["Id"].ToString());
                objSqlSP_Para.SP_ID = long.Parse(objRow["Id"].ToString());
                objSqlSP_Para.ParaName = objRow["Name"].ToString().Trim();
                objSqlSP_Para.ParaDataType = objRow["ParaDataType"].ToString().Trim();
                objSqlSP_Para.ParaSize = short.Parse(objRow["ParaSize"].ToString().Trim());

                if (objRow["ParaDirection"].ToString().Trim() == "1")
                {
                    objSqlSP_Para.ParaDirection = "spParamOutput";
                }
                else
                {
                    objSqlSP_Para.ParaDirection = "spParamInput";
                }
                if (objRow["IsNullable"].ToString().Trim() == "1")
                {
                    objSqlSP_Para.IsNullable = true;
                }
                else
                {
                    objSqlSP_Para.IsNullable = false;
                }
                arrSP_ParasObjList.Add(objSqlSP_Para);
            }
            foreach (clsSqlStoreProcedureEx objSqlStoreProcedure in arrStoreProceduresObjList)
            {
                foreach (clsSqlSP_Para objSqlSp_Para in arrSP_ParasObjList)
                {
                    if (objSqlSp_Para.SP_ID == objSqlStoreProcedure.SP_ID)
                    {
                        objSqlStoreProcedure.AddSpParamObj(objSqlSp_Para);
                    }
                }
            }
            return arrStoreProceduresObjList;
        }
    }
}