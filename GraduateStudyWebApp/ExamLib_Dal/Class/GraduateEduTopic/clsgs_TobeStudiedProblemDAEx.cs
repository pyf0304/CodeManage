/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_TobeStudiedProblemDAEx
表名:gs_TobeStudiedProblem(01120776)
生成代码版本:2020.12.12.1
生成日期:2020/12/14 21:00:18
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
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
    /// 待研究问题(gs_TobeStudiedProblem)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsgs_TobeStudiedProblemDAEx : clsgs_TobeStudiedProblemDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsgs_TobeStudiedProblemDAEx()
        {
        }

        /// <summary>
        /// 待研究问题日期合并
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetProblemDateNumDataTable(string strCondition)
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
            objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
            strSQL = "select ProblemDate,SUM(1)as ProblemDateNum FROM gs_TobeStudiedProblem where " + strCondition + " Group by ProblemDate order by ProblemDate Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}