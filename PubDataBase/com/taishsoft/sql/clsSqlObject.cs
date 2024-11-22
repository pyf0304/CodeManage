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
        /// 功能：获取给定表某拥有者的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <param name="strDataBaseOwner">给定的拥有者</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public static DataTable GetColumns(string strTabName, string strConnectString, string strDataBaseOwner)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strDataBaseOwner);
            return objDT;
        }
        ///// <summary>
        ///// 功能：获取给定表的所有列信息,拥有者为dbo
        ///// </summary>
        ///// <param name="strTabName">给定的表名</param>
        ///// <returns>给定表的所有列信息，以DataTable形式</returns>
        //public static DataTable GetColumnsByDbo(string strTabName, string strConnectString)
        //{
        //    System.Data.DataTable objDT;

        //    clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

        //    objDT = objSQL.GetColumnsByDbo(strTabName);
        //    return objDT;
        //}
        ///// <summary>
        ///// 功能：获取给定表的所有列信息
        ///// </summary>
        ///// <param name="strTabName">给定的表名</param>
        ///// <returns>给定表的所有列信息，以DataTable形式</returns>
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
        /// 功能：获取给定表的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <param name="strConnectString">连接串</param>
        /// <param name="strDataBaseOwner">拥有者</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
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
        /// 功能：获取给定表的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <param name="strConnectString">连接串</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
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
        /// 功能：获取给定表的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <param name="strConnectString">连接串</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public static int GetColumnCount(string strTabName, string strConnectString)
        {
          
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            int intCount = objSQL.GetColumnsCount(strTabName);

            return intCount;
        }

        /// <summary>
        /// 功能：获取给定表、给定列的列信息，用对象的形式表示
        /// </summary>
        /// <param name="strTabName">给定的表名</param>       
        /// <param name="strColumnName">字段名</param>
        /// <param name="strConnectString">连接串</param>
        /// <param name="strDataBaseOwner">拥有者</param>
        /// <returns>给定表,给定列信息，用对象的形式表示</returns>
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
        /// 功能：获取给定表的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
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
        /// 功能：获取给定列的数据类型
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public static string GetColumnTypeName(string strTabName, string strColumnName, string strConnectString, string strDataBaseOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.GetColumns(strTabName, strColumnName, strDataBaseOwner);
            if (objDT.Rows.Count != 1)
            {
                throw new Exception (new StringBuilder().AppendFormat("在表（[{0}].[{1}]中没有字段{2}。请检查！", strDataBaseOwner, strTabName, strColumnName).ToString());
            }
            string strTypeName = objDT.Rows[0]["Type_Name"].ToString().Trim();
            return strTypeName;
        }
        /// <summary>
        /// 获取指定服务器的所有数据库
        /// </summary>
        /// <returns>返回所有数据库的DataTable</returns>
        public static System.Data.DataTable getDataBases(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getDataBases();
            return objDT;

        }


        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public static System.Data.DataTable getTables(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getTables();
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public static System.Data.DataTable getTables(string strConnectString, string strOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getTablesByOwner(strOwner);
            return objDT;
        }
        /// <summary>
        /// 获取所定的服务器和数据库中所有表名对象列表。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
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
        /// 获取所定的服务器和数据库中所有表名对象列表。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
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
        /// 获取所定的服务器和数据库中所有表、视图名。
        /// </summary>
        /// <returns>所有表、视图名的DataTable</returns>
        public static System.Data.DataTable getTableAndViews(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getTableAndViews();
            return objDT;
        }

        ///// <summary>
        ///// 获取所定的服务器和数据库中所有表、视图名。
        ///// </summary>
        ///// <returns>所有表、视图名的DataTable</returns>
        //public static System.Data.DataTable getTableAndViewsBak20130307(string strConnectString, string strOwner)
        //{
        //    System.Data.DataTable objDT;
        //    clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
        //    objDT = objSQL.getTableAndViewsByOwner(strOwner);
        //    return objDT;
        //}
        /// <summary>
        /// 获取所定的服务器和数据库中所有表、视图名对象列表。
        /// </summary>
        /// <returns>所有表、视图名的DataTable</returns>
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
        /// 是否存在给定表？
        /// </summary>
        /// <param name="strConnectString">表相关的连接</param>
        /// <param name="strTabName">表名</param>
        /// <returns>是否存在？</returns>
        public static bool IsExistTable(string strConnectString, string strTabName)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.IsExistTable(strTabName);
        }

        /// <summary>
        /// 是否存在存储过程？
        /// </summary>
        /// <param name="strConnectString">存储过程相关的连接</param>
        /// <param name="strStoreProcedure">存储过程</param>
        /// <param name="strOwner">拥有者</param>
        /// <returns>是否存在？</returns>
        public static bool IsExistStoreProcedure(string strConnectString, string strStoreProcedure, string strOwner)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.IsExistStoreProcedure(strStoreProcedure, strOwner);
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.IsIdentity(strTabName, strDataBaseOwner, strColumnName);
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有VIEW名。
        /// </summary>
        /// <returns>所有View名的DataTable</returns>
        public static System.Data.DataTable getViews(string strConnectString, string strOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getViewsByOwner(strOwner);
            return objDT;
        }

        /// <summary>
        /// 获取数据表的主键列表
        /// </summary>
        /// <param name="strConnectString">连接串</param>
        /// <param name="strTabName">表名</param>
        /// <returns>主键列表，以ArrayList形式返回</returns>
        public static ArrayList GetPKeys(string strConnectString, string strTabName)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.GetPKeys(strTabName);
        }

        /// <summary>
        /// 获取数据表的主键列表
        /// </summary>
        /// <param name="strConnectString">连接串</param>
        /// <param name="strTabName">表名</param>
        /// <param name="strDataBaseOwner">拥有者</param>
        /// <returns>主键列表，以ArrayList形式返回</returns>
        public static ArrayList GetPKeys(string strConnectString, string strTabName, string strDataBaseOwner)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.GetPKeys(strTabName, strDataBaseOwner);
        }

        /// <summary>
        /// 获取数据表的主键列表
        /// </summary>
        /// <param name="strConnectString">连接串</param>
        /// <param name="strTabName">表名</param>
        /// <param name="strDataBaseOwner">拥有者</param>
        /// <returns>主键列表，以List《clsPKeys》形式返回</returns>
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
        /// 获取数据表的外键列表
        /// </summary>
        /// <param name="strConnectString">连接串</param>
        /// <param name="strTabName">表名</param>
        /// <param name="strDataBaseOwner">拥有者</param>
        /// <returns>外键列表，以List《clsFKeys》形式返回</returns>
        public static System.Collections.Generic.List<clsFKeys> GetFKeyObjList(string strConnectString, string strTabName, string strDataBaseOwner)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            DataTable objDT = objSQL.GetFKeys(strTabName, strDataBaseOwner);
            System.Collections.Generic.List<clsFKeys> arrFKeyObjList = new System.Collections.Generic.List<clsFKeys>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsFKeys objFKeys = new clsFKeys();
                //objFKeys.Id = Int32.Parse(objRow["Id"].ToString().Trim()); //对象Id
                objFKeys.FKeyName = objRow["FKeyName"].ToString().Trim(); //外键名称
                objFKeys.FKeyColumnID = objRow["FKeyColumnID"].ToString().Trim(); //外键列Id
                objFKeys.FKeyColumnName = objRow["FKeyColumnName"].ToString().Trim(); //外键列名
                objFKeys.FKeyTabID = objRow["FKeyTabID"].ToString().Trim(); //外键表ID
                objFKeys.FKeyTabName = objRow["FKeyTabName"].ToString().Trim(); //外键表名称
                objFKeys.PKeyColumnID = objRow["PKeyColumnID"].ToString().Trim(); //主键列ID
                objFKeys.PKeyColumnName = objRow["PKeyColumnName"].ToString().Trim(); //主键列名
                objFKeys.PKeyTabId = objRow["PKeyTabId"].ToString().Trim(); //主键表Id
                objFKeys.PKeyTabName = objRow["PKeyTabName"].ToString().Trim(); //主键表名
                objFKeys.Update_Action = objRow["Update_Action"].ToString().Trim(); //级联更新
                objFKeys.Delete_Action = Int32.Parse(objRow["Delete_Action"].ToString().Trim()); //级联删除
                objFKeys.ClearUpdateState();//清除修改状态,即清除脏字段信息
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
                    throw new Exception("在判断是否加引号函数中没有该数据类型：" + strDataTypeName);
//                    return true;
            }
        }
        /// <summary>
        /// 在建表时是否需要长度
        /// </summary>
        /// <param name="strDataTypeName">数据类型</param>
        /// <returns>是否需要?</returns>
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
                    throw new Exception("在校验函数中没有该数据类型：" + strDataTypeName);
//                    return true;
            }
        }


        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public static System.Data.DataTable getStoreProcedures(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProcedures();
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public static System.Data.DataTable getStoreProceduresByCond(string strConnectString, string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProceduresByCond(strCondition);
            return objDT;
        }
        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public static System.Data.DataTable getStoreProceduresByOwner(string strConnectString, string strOwner)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProceduresByOwner(strOwner);
            return objDT;
        }
        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public static System.Data.DataTable getStoreProceduresByOwnerByCond(string strConnectString, string strOwner, string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getStoreProceduresByOwnerByCond(strOwner, strCondition);
            return objDT;
        }
        /// <summary>
        /// 获取所定的服务器和数据库中所有存储过程的对象列表。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <returns>所有存储过程的对象列表</returns>
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
        /// 获取所定的服务器和数据库中所有存储过程的对象列表。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <param name="strOwner">拥有者</param>
        /// <returns>存储过程的对象列表</returns>
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
        /// 获取所定的服务器和数据库中所有存储过程的对象列表。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <param name="strCondition">条件</param>
        /// <returns>存储过程的对象列表</returns>
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
        /// 获取所定的服务器和数据库中所有存储过程的对象列表。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <param name="strCondition">条件</param>
        /// <returns>存储过程的对象列表</returns>
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
        /// 获取所定的服务器和数据库中所有存储过程参数。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <returns>所有存储过程参数的DataTable</returns>
        public static System.Data.DataTable getSp_ParaAll(string strConnectString)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getSp_ParaAll();
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有存储过程参数。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <param name="strCondition">条件</param>
        /// <returns>存储过程参数的DataTable</returns>
        public static System.Data.DataTable getSp_ParaByCond(string strConnectString, string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getSp_ParaByCond(strCondition);
            return objDT;
        }
        /// <summary>
        /// 获取所定的服务器和数据库中所有存储过程参数。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <param name="strSP_Name">存储过程名</param>
        /// <returns>存储过程参数的DataTable</returns>
        public static System.Data.DataTable getSp_ParaByName(string strConnectString, string strSP_Name)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            objDT = objSQL.getSp_ParaByName(strSP_Name);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有存储过程参数对象列表。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <returns>所有存储过程参数的对象列表</returns>
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
        /// 获取所定的服务器和数据库中所有存储过程参数对象列表。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <param name="strCondition">条件</param>
        /// <returns>存储过程参数的对象列表</returns>
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
        /// 获取所定的服务器和数据库中所有存储过程参数对象列表。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <param name="strSP_Name">存储过程名</param>
        /// <returns>存储过程参数的对象列表</returns>
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
        /// 获取所定的服务器和数据库中所有存储过程的对象列表。
        /// </summary>
        /// <param name="strConnectString">给定的服务器和数据库</param>
        /// <returns>所有存储过程的对象列表</returns>
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