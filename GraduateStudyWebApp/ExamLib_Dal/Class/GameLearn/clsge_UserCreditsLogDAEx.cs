
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_UserCreditsLogDAEx
表名:ge_UserCreditsLog(01120883)
生成代码版本:2021.02.21.1
生成日期:2021/02/24 18:51:00
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:游戏化学习
模块英文名:GameLearn
框架-层名:数据处理扩展层(DALExCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using com.taishsoft.commdb;
using ExamLib.Entity;

namespace ExamLib.DAL
{
    /// <summary>
    /// 用户积分日志(ge_UserCreditsLog)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsge_UserCreditsLogDAEx : clsge_UserCreditsLogDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsge_UserCreditsLogDAEx()
        {
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable) 闯关号+课程号获取随机数据；
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable GetDataTableEx(string strUserId, string strid_CurrEduCls)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            try
            {
                //clsCheckSql.CheckStrSQL_Weak(strCondition);
                //strCondition = clsString.RemoveElementValue(strCondition, "exclude");

                //获取连接对象
                objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
                
                strSQL = "select * from ( select *,ROW_NUMBER()over(partition by LevelNo order by LevelNo desc) as disorder from ge_UserCreditsLog)t where t.disorder=1 And UserId='"+strUserId+"' and IdCurrEduCls='"+ strid_CurrEduCls + "'";
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
            }

            return objDT;
        }

        //获取用户闯关的分数 用于排名；根据教学班查询；
        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable) 闯关号+课程号获取随机数据；
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable GetDataTableByWhere(string strWhere)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            try
            {
                //clsCheckSql.CheckStrSQL_Weak(strCondition);
                //strCondition = clsString.RemoveElementValue(strCondition, "exclude");

                //获取连接对象
                objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
                //根据条件获取 每个人每关的最大分值；
                strSQL = "select GameLevelId, MAX(Credits) as Credits,UserId,IdCurrEduCls,CourseId from ge_UserCreditsLog where " + strWhere + " GROUP BY GameLevelId,UserId,IdCurrEduCls,CourseId  ORDER BY GameLevelId,Credits desc";
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
            }

            return objDT;
        }



        ////获取用户闯关的分数 用于排名；根据教学班查询；
        ///// <summary>
        ///// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        ///// (AutoGCLib.clsGeneCodeBase:GenGetDataTable) 闯关号+课程号获取随机数据；
        ///// </summary>
        ///// <param name = "strCondition">条件串</param>
        ///// <returns>返回数据表DataTable</returns>
        //public static System.Data.DataTable GetDataTableByid_CurrEduCls(string strid_CurrEduCls)
        //{
        //    string strSQL;
        //    System.Data.DataTable objDT;
        //    clsSpecSQLforSql objSQL = null;
        //    try
        //    {
        //        //clsCheckSql.CheckStrSQL_Weak(strCondition);
        //        //strCondition = clsString.RemoveElementValue(strCondition, "exclude");

        //        //获取连接对象
        //        objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
        //        //根据闯关号，来获取题目中对应的随机10条数据；
        //        strSQL = "select LevelNo, sum(Credits) as Credits,UserId,IdCurrEduCls from ge_UserCreditsLog where IdCurrEduCls='"+ strid_CurrEduCls + "' GROUP BY LevelNo,UserId,IdCurrEduCls ORDER BY Credits asc";
        //        objDT = objSQL.GetDataTable(strSQL);
        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
        //    }

        //    return objDT;
        //}
    }
}