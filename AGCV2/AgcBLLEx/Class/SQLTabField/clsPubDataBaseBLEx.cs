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
using AGC.DAL;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 
    /// </summary>
    public class clsPubDataBaseBLEx
    {



        /// <summary>
        /// 获取SQL服务器连接对象
        /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
        /// </summary>
        /// <returns>SQL服务器连接对象</returns>
        public static clsSpecSQLforSql GetSpecSQLObj()
        {
            if (clsSysParaEN.objLog == null)
            {
                throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
            }
            if (clsSysParaEN.objErrorLog == null)
            {
                throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
            }
            clsSpecSQLforSql objSQL;
            //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
            if (clsSysParaEN.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
                return objSQL;
            }
            //2. 如果类所指定的连接串非空,就用该类所指定的连接串
            //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
            if (string.IsNullOrEmpty(clsCollegeEN._ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsCollegeEN._ConnectString);
            }
            return objSQL;
        }


        /// <summary>
        /// 功能:获取给定表的所有字段值列表
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <param name = "strFldName">strFldName</param>
        /// <param name = "strWhere">strWhere</param>
        /// <returns>给定表的所有字段值列表</returns>
        public static List<string> GetFieldValue(string strTabName, string strFldName, string strWhere)
        {
            clsSpecSQLforSql objSQL;
            //获取连接对象
            objSQL = clsPubDataBaseBLEx.GetSpecSQLObj();


            List<string> arrValue =  objSQL.GetFldDataOfTable(strTabName, strFldName, strWhere);
            return arrValue;
        }

        /// <summary>
        /// 功能:是否存在给定表
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>返回是否存在表</returns>
        public static bool IsExistTable(string strTabName, string strPrjDataBaseId)
        {

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            if (objPrjDataBase == null)
            {
                string strMsg = string.Format("工程数据库Id:[{0}]没有相应的记录，请检查！", strPrjDataBaseId);
                throw new Exception(strMsg);
            }
            bool bolIsExist = objSQL.IsExistTable(strTabName);

            return bolIsExist;
        }



        /// <summary>
        /// 功能:获取给定表的所有列信息
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息,以DataTable形式</returns>
        public static DataTable GetConstraints(string strTabName, string strPrjDataBaseId)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            objDT = objSQL.GetConstraint(strTabName);
            return objDT;
        }


        /// <summary>
        /// 功能:获取给定表的某字段的所有约束对象名
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <param name = "strFldName">给定的字段名</param>
        /// <param name = "strPrjDataBaseId">数据库Id</param>
        /// <returns>所有约束对象名</returns>
        public static List<string> GetConstraintNameLst4FldName(string strTabName, string strFldName, string strPrjDataBaseId)
        {
            List<clsConstraints> arrConstraints = GetConstraintObjList(strTabName, strPrjDataBaseId);
            string strFindStr = string.Format("on column {0}", strFldName);
            List<clsConstraints> arrConstraints_Sel = arrConstraints.Where(x => x.Constraint_type.Contains(strFindStr) == true).ToList();
            List<string> arrConstraintName = arrConstraints_Sel.Select(x => x.Constraint_Name).ToList();
            return arrConstraintName;
        }

        /// <summary>
        /// 功能:获取给定表的所有列信息
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息,以DataTable形式</returns>
        public static List<clsConstraints> GetConstraintObjList(string strTabName, string strPrjDataBaseId)
        {
            List<clsConstraints> arrConstraintObjList = new List<clsConstraints>();
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            if (objPrjDataBase == null)
            {
                string strMsg = string.Format("工程数据库Id:[{0}]没有相应的记录，请检查！", strPrjDataBaseId);
                throw new Exception(strMsg);
            }
            objDT = objSQL.GetConstraint(strTabName);

            foreach (DataRow objRow in objDT.Rows)
            {
                clsConstraints objConstraints = new clsConstraints();
                objConstraints.Constraint_Name = objRow["Constraint_Name"].ToString().Trim();     //列名
                objConstraints.Constraint_type = objRow["Constraint_type"].ToString().Trim();     //数据类型
                objConstraints.Delete_action = objRow["Delete_action"].ToString().Trim();     //字段长度
                objConstraints.Status_for_replication = objRow["Status_for_replication"].ToString().Trim();     //是否可空
                objConstraints.Constraint_keys = objRow["Constraint_keys"].ToString().Trim();     //字段缺省值
                objConstraints.Update_action = objRow["Update_action"].ToString().Trim();     //精确度
                arrConstraintObjList.Add(objConstraints);
            }
            return arrConstraintObjList;
        }



        /// <summary>
        /// 功能:获取给定表的内容信息
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <param name = "strPrjDataBaseId">数据库Id</param>
        /// <returns>给定表的所有列信息,以DataTable形式</returns>
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
                var strMsg = string.Format("根据表名获取关键字值出错。表名:[{0}], 关键字段:[{1}],排序:[{2}], 出错信息:{3}.(in {4}) ",
                    strTabName, strKeyFldName, strSortExpress, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            //return "";
        }
        /// <summary>
        /// 功能:获取给定表的分页数据内容
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <param name = "strPrjDataBaseId">数据库Id</param>
        /// <param name = "strKeyFldName">表关键字</param>
        /// <param name = "intPageIndex">页序号</param>
        /// <param name = "intPageSize">页记录数</param>
        /// <param name = "strCondition">条件串</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <returns>给定表的所有列信息,以DataTable形式</returns>
        public static DataTable GetDataTableByPager(string strPrjDataBaseId, string strTabName, string strKeyFldName, int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            objDT = objSQL.GetDataTableByPager(strTabName, strKeyFldName, intPageIndex, intPageSize, strCondition, strOrderBy);
            return objDT;
        }

        /// <summary>
        /// 功能:获取给定表的分页数据内容
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <param name = "strPrjDataBaseId">数据库Id</param>
        /// <param name = "intTopSize">顶部记录数</param>
        /// <param name = "strCondition">条件串</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <returns>给定表的所有列信息,以DataTable形式</returns>
        public static DataTable GetDataTableByTop(string strPrjDataBaseId, string strTabName, int intTopSize, string strCondition, string strOrderBy)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            objDT = objSQL.GetDataTableByTop(strTabName, intTopSize, strCondition, strOrderBy);
            return objDT;
        }

        /// <summary>
        /// 功能:获取给定表的给定关键字值的一行数据
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <param name = "strPrjDataBaseId">数据库Id</param>
        /// <param name = "strKeyFldName">表关键字</param>
        /// <param name = "strKeyValue">关键字值</param>
        /// <param name = "bolIsNumurable">是否数值型</param>
        /// <returns>给定表的所有列信息,以DataTable形式</returns>
        public static DataTable GetDataTableByKey(string strPrjDataBaseId, string strTabName, string strKeyFldName, string strKeyValue, bool bolIsNumurable)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            objDT = objSQL.GetDataTableByKey(strTabName, strKeyFldName, strKeyValue, bolIsNumurable);
            return objDT;
        }

        /// <summary>
        /// 功能:获取给定表的给定关键字值的一行数据
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <param name = "strPrjDataBaseId">数据库Id</param>
        /// <returns>给定表的所有列信息,以DataTable形式</returns>
        public static int GetRecNum4TabName(string strPrjDataBaseId, string strTabName)
        {

            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);
            //var strSql = string.Format("EXEC SP_SPACEUSED '{0}'", strTabName);
            int intRecNum = objSQL.GetRecCount(strTabName);
            return intRecNum;
        }
        /// <summary>
        /// 获取数据库中所有表
        /// </summary>
        /// <param name="strPrjDataBaseId">数据库id,代表某个数据库</param>
        /// <param name="strWhereCond">条件</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataTable GetTableAndViewsByCond(string strPrjDataBaseId, string strWhereCond)
        {
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);

            //	2、根据条件串获取该表满足条件的DataTable；
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
                string strMsg = "获取数据表(DataTable)不成功!" + objException.Message;

                throw new Exception(strMsg);
            }
        }

    }
}