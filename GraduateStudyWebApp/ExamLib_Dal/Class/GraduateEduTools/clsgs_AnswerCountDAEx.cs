/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_AnswerCountDAEx
表名:gs_AnswerCount(01120767)
生成代码版本:2020.09.24.1
生成日期:2020/11/10 20:49:23
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培设置
模块英文名:GraduateEduTools
框架-层名:数据处理扩展层(DALExCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

using com.taishsoft.commdb;
using com.taishsoft.common;
using System;

namespace ExamLib.DAL
{
    /// <summary>
    /// 问题讨论回答统计(gs_AnswerCount)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsgs_AnswerCountDAEx : clsgs_AnswerCountDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsgs_AnswerCountDAEx()
        {
        }

        public static System.Data.DataTable GetAnswerCountNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
            strSQL = " select DataUser,UserName,SUM(1) as AnswerNum FROM gs_AnswerCount where " + strCondition + " Group by DataUser,UserName order by AnswerNum Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }


        public static System.Data.DataTable GetWeekAnswerCountNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
            strSQL = " select Week,WeekTimeRange,SUM(1) as WeekAnswerNum FROM gs_AnswerCount where " + strCondition + " Group by Week,WeekTimeRange order by WeekAnswerNum Asc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

    }
}