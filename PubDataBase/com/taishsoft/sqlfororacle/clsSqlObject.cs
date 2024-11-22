using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdbfororacle;
using com.taishsoft.common;
using System.Collections.Generic;


namespace com.taishsoft.sqlfororacle
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
            CheckDataBaseOwner(strDataBaseOwner);
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strDataBaseOwner);
            return objDT;
        }
        /// <summary>
        /// ���ܣ���ȡ���������������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public static DataTable GetColumns(string strTabName, string strConnectString)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);

            objDT = objSQL.GetColumns(strTabName);
            return objDT;
        }
        /// <summary>
        /// ���ܣ���ȡ���������������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public static List<clsColumns> GetColumnObjList(string strTabName, string strConnectString)
        {
            List<clsColumns> arrColumnObjList = new List<clsColumns>();
            System.Data.DataTable objDT;

            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
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
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public static List<clsColumns> GetColumnObjList(string strTabName, string strConnectString, string strDataBaseOwner)
        {
            List<clsColumns> arrColumnObjList = new List<clsColumns>();
            System.Data.DataTable objDT;

            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strDataBaseOwner);
            foreach (DataColumn objCol in objDT.Columns)
            {
                string ss = objCol.ColumnName;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsColumns objColumns = new clsColumns();
                objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();
                objColumns.Type_Name = objRow["Data_Type"].ToString().Trim();
                objColumns.length = int.Parse(objRow["Data_Length"].ToString());
                objColumns.Is_Nullable = objRow["NULLABLE"].ToString();
                //objColumns.COLUMN_DEF = objRow["COLUMN_DEF"].ToString();
                if (string.IsNullOrEmpty(objRow["DATA_PRECISION"].ToString()) == false)
                {
                    objColumns.PRECISION = int.Parse(objRow["DATA_PRECISION"].ToString());
                }
                arrColumnObjList.Add(objColumns);
            }
            return arrColumnObjList;
        }

        /// <summary>
        /// ���ܣ���ȡ�����������е�����Ϣ���ö������ʽ��ʾ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <returns>������,��������Ϣ���ö������ʽ��ʾ</returns>
        public static clsColumns GetColumnObj(string strTabName, string strColumnName, string strConnectString, string strDataBaseOwner)
        {
            ArrayList arrColumnObjList = new ArrayList();
            System.Data.DataTable objDT;

            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strDataBaseOwner);
            foreach (DataRow objRow in objDT.Rows)
            {
                string strColumn_Name_Temp = objRow["Column_Name"].ToString().Trim();
                if (string.Compare(strColumnName, strColumn_Name_Temp, true) == 0)
                {
                    clsColumns objColumns = new clsColumns();


                    objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();
                    objColumns.Type_Name = objRow["Data_Type"].ToString().Trim();
                    objColumns.length = int.Parse(objRow["Data_Length"].ToString());
                    objColumns.Is_Nullable = objRow["NULLABLE"].ToString();
                    //objColumns.COLUMN_DEF = objRow["COLUMN_DEF"].ToString();
                    if (string.IsNullOrEmpty(objRow["DATA_PRECISION"].ToString()) == false)
                    {
                        objColumns.PRECISION = int.Parse(objRow["DATA_PRECISION"].ToString());
                    }
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
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
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
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strColumnName, strDataBaseOwner);
            if (objDT.Rows.Count != 1)
            {
                throw new Exception (new StringBuilder().AppendFormat("�ڱ�[{0}].[{1}]��û���ֶ�{2}�����飡", strDataBaseOwner, strTabName, strColumnName).ToString());
            }
            string strTypeName = objDT.Rows[0]["Data_Type"].ToString().Trim();
            return strTypeName;
        }
        ///// <summary>
        ///// ��ȡָ�����������������ݿ�
        ///// </summary>
        ///// <returns>�����������ݿ��DataTable</returns>
        //public static System.Data.DataTable getDataBases(string strConnectString)
        //{
        //    System.Data.DataTable objDT;
        //    clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
        //    objDT = objSQL.getDataBases();
        //    return objDT;

        //}


        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static System.Data.DataTable getTables(string strConnectString, string strTableSpcce)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.getTables(strTableSpcce);
            return objDT;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б��������б�
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public static List<clsSqlTabView> getTableObjList(string strConnectString, string strTableSpcce)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.getTables(strTableSpcce);
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
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
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


        
        ///// <summary>
        ///// ��ȡ�����ķ����������ݿ������б���ͼ����
        ///// </summary>
        ///// <returns>���б���ͼ����DataTable</returns>
        //public static System.Data.DataTable getTableAndViews(string strConnectString)
        //{
        //    System.Data.DataTable objDT;
        //    clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
        //    objDT = objSQL.getTableAndViews();
        //    return objDT;
        //}

        ///// <summary>
        ///// ��ȡ�����ķ����������ݿ������б���ͼ�������б�
        ///// </summary>
        ///// <returns>���б���ͼ����DataTable</returns>
        //public static ArrayList getTableAndViewObjList(string strConnectString)
        //{
        //    System.Data.DataTable objDT;
        //    clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
        //    objDT = objSQL.getTableAndViews();
        //    DataTable objDT_sp = objSQL.getTableAndViewsBySp_Tables();
        //    ArrayList arrTableObjList = new ArrayList();
        //    foreach (DataRow objRow in objDT.Rows)
        //    {
        //        clsSqlTabView objSqlTabView = new clsSqlTabView();
        //        objSqlTabView.Id = long.Parse(objRow["Id"].ToString());
        //        objSqlTabView.Name = objRow["Name"].ToString().Trim();
        //        //objSqlTabView.Owner = objRow["Owner"].ToString().Trim();
        //        objSqlTabView.FldNum = int.Parse(objRow["info"].ToString());
        //        foreach (DataRow objRow_sp in objDT_sp.Rows)
        //        {
        //            if (objSqlTabView.Name == objRow_sp["Table_Name"].ToString().Trim())
        //            {
        //                objSqlTabView.Owner = objRow_sp["Table_Owner"].ToString().Trim();
        //                objSqlTabView.TabType = objRow_sp["Table_Type"].ToString().Trim();

        //            }
        //        }
        //        objSqlTabView.ConnectString = strConnectString;
        //        arrTableObjList.Add(objSqlTabView);
        //    }
        //    return arrTableObjList;
        //}


        /// <summary>
        /// �Ƿ���ڸ�����
        /// </summary>
        /// <param name="strConnectString">����ص�����</param>
        /// <param name="strTabName">����</param>
        /// <returns>�Ƿ���ڣ�</returns>
        public static bool IsExistTable(string strConnectString, string strTabName)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            return objSQL.IsExistTable(strTabName);
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
            CheckDataBaseOwner(strDataBaseOwner);
            CheckTabName(strTabName);
            CheckColumnName(strColumnName);
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
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
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            return objSQL.IsIdentity(strTabName, strDataBaseOwner, strColumnName);
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ�������VIEW����
        /// </summary>
        /// <returns>����View����DataTable</returns>
        public static System.Data.DataTable getViews(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.getViews();
            return objDT;
        }

        public static ArrayList GetPKeys(string strConnectString, string strTabName)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            return objSQL.GetPKeys(strTabName);
        }


        public DataTable GetFKeys(string strConnectString, string strTabName)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            return objSQL.GetFKeys(strTabName);
        }

        public static DataTable GetConstraint(string strConnectString, string strTabName)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            return objSQL.GetConstraint(strTabName);
        }

        public static string GetFirstPKeys(string strConnectString, string strTabName)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
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
                case "varchar2":
                case "nvarchar":
                case "nvarchar2":
                    return true;
                case "bool":
                    return true;
                case "bit":
                    return true;
                case "boolean":
                    return true;
                case "date":
                    return true;
                case "decimal":
                    return false;
                case "smallint":
                case "int":
                case "number":
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
                case "int":
                    return clsString.IsDigit(strValue);
                case "bigint":
                    return clsString.IsDigit(strValue);
                case "bigint identity":
                    return clsString.IsDigit(strValue);
                case "shortint":
                    return clsString.IsDigit(strValue);
                case "double":
                    return clsString.IsFloat(strValue);
                case "decimal":
                    return clsString.IsFloat(strValue);
                case "datetime":
                    return clsString.IsDate(strValue);
                case "float":
                    return clsString.IsFloat(strValue);
                case "long":
                    return clsString.IsDigit(strValue);
                default:
                    throw new Exception("��У�麯����û�и��������ͣ�" + strDataTypeName);
//                    return true;
            }
        }
        private static void CheckDataBaseOwner(string strDataBaseOwner)
        {
            if (string.IsNullOrEmpty(strDataBaseOwner) == true)
            {
                throw new Exception("���ݿ�ӵ���߲���Ϊ�գ�");
            }
        }
        private static void CheckTabName(string strTabName)
        {
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                throw new Exception("���ݱ�������Ϊ�գ�");
            }
        }
        private static void CheckColumnName(string strColumnName)
        {
            if (string.IsNullOrEmpty(strColumnName) == true)
            {
                throw new Exception("�ֶ�������Ϊ�գ�");
            }
        }
    }
}