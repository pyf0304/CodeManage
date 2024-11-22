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
        /// 功能：获取给定表某拥有者的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <param name="strDataBaseOwner">给定的拥有者</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public static DataTable GetColumns(string strTabName, string strConnectString, string strDataBaseOwner)
        {
            System.Data.DataTable objDT;
            CheckDataBaseOwner(strDataBaseOwner);
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strDataBaseOwner);
            return objDT;
        }
        /// <summary>
        /// 功能：获取给定表的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public static DataTable GetColumns(string strTabName, string strConnectString)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);

            objDT = objSQL.GetColumns(strTabName);
            return objDT;
        }
        /// <summary>
        /// 功能：获取给定表的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
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
        /// 功能：获取给定表的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
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
        /// 功能：获取给定表、给定列的列信息，用对象的形式表示
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表,给定列信息，用对象的形式表示</returns>
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
        /// 功能：获取给定表的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
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
        /// 功能：获取给定列的数据类型
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public static string GetColumnTypeName(string strTabName, string strColumnName, string strConnectString, string strDataBaseOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strColumnName, strDataBaseOwner);
            if (objDT.Rows.Count != 1)
            {
                throw new Exception (new StringBuilder().AppendFormat("在表（[{0}].[{1}]中没有字段{2}。请检查！", strDataBaseOwner, strTabName, strColumnName).ToString());
            }
            string strTypeName = objDT.Rows[0]["Data_Type"].ToString().Trim();
            return strTypeName;
        }
        ///// <summary>
        ///// 获取指定服务器的所有数据库
        ///// </summary>
        ///// <returns>返回所有数据库的DataTable</returns>
        //public static System.Data.DataTable getDataBases(string strConnectString)
        //{
        //    System.Data.DataTable objDT;
        //    clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
        //    objDT = objSQL.getDataBases();
        //    return objDT;

        //}


        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public static System.Data.DataTable getTables(string strConnectString, string strTableSpcce)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            objDT = objSQL.getTables(strTableSpcce);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名对象列表。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
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
        /// 获取所定的服务器和数据库中所有表名对象列表。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
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
        ///// 获取所定的服务器和数据库中所有表、视图名。
        ///// </summary>
        ///// <returns>所有表、视图名的DataTable</returns>
        //public static System.Data.DataTable getTableAndViews(string strConnectString)
        //{
        //    System.Data.DataTable objDT;
        //    clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
        //    objDT = objSQL.getTableAndViews();
        //    return objDT;
        //}

        ///// <summary>
        ///// 获取所定的服务器和数据库中所有表、视图名对象列表。
        ///// </summary>
        ///// <returns>所有表、视图名的DataTable</returns>
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
        /// 是否存在给定表？
        /// </summary>
        /// <param name="strConnectString">表相关的连接</param>
        /// <param name="strTabName">表名</param>
        /// <returns>是否存在？</returns>
        public static bool IsExistTable(string strConnectString, string strTabName)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            return objSQL.IsExistTable(strTabName);
        }

        /// <summary>
        /// 判断所给的表中是否存在某字段。
        /// </summary>
        /// <param name="strConnectString">与表相关的连接</param>
        /// <param name="strTabName">表名</param>
        /// <param name="strDataBaseOwner">表拥有者</param>
        /// <param name="strColumnName">列名</param>
        /// <returns>是否存在？</returns>
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
        /// 判断所给的字段是否Identity字段。
        /// </summary>
        /// <param name="strConnectString">与表相关的连接</param>
        /// <param name="strTabName">表名</param>
        /// <param name="strDataBaseOwner">表拥有者</param>
        /// <param name="strColumnName">列名</param>
        /// <returns>是否Identity？</returns>
        public static bool IsIdentityColumn(string strConnectString, string strTabName,
           string strDataBaseOwner, string strColumnName)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra(strConnectString);
            return objSQL.IsIdentity(strTabName, strDataBaseOwner, strColumnName);
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有VIEW名。
        /// </summary>
        /// <returns>所有View名的DataTable</returns>
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
        /// 是否需要引号(Quotes)
        /// </summary>
        /// <param name="strDataTypeName">数据类型名</param>
        /// <returns>需要？</returns>
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
                    throw new Exception("在判断是否加引号函数中没有该数据类型：" + strDataTypeName);
//                    return true;
            }
        }
        /// <summary>
        /// 判断某值是否符合某类型
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
                    throw new Exception("在校验函数中没有该数据类型：" + strDataTypeName);
//                    return true;
            }
        }
        private static void CheckDataBaseOwner(string strDataBaseOwner)
        {
            if (string.IsNullOrEmpty(strDataBaseOwner) == true)
            {
                throw new Exception("数据库拥有者不能为空！");
            }
        }
        private static void CheckTabName(string strTabName)
        {
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                throw new Exception("数据表名不能为空！");
            }
        }
        private static void CheckColumnName(string strColumnName)
        {
            if (string.IsNullOrEmpty(strColumnName) == true)
            {
                throw new Exception("字段名不能为空！");
            }
        }
    }
}