/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvgs_TotalDataStatisticsDAEx
表名:vgs_TotalDataStatistics(01120682)
生成代码版本:2020.06.21.1
生成日期:2020/06/23 22:48:04
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
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
    /// 总数据统计视图(vgs_TotalDataStatistics)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsvgs_TotalDataStatisticsDAEx : clsvgs_TotalDataStatisticsDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsvgs_TotalDataStatisticsDAEx()
        {
        }

        /// <summary>
        /// 获取周的统计数量
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetWeekNumDataTable(string strCondition)
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
            objSQL = clsvPaperDA.GetSpecSQLObj();
            strSQL = "select WeekTimeRange,Week,sum(1) as Num from gs_TotalDataStatistics where " + strCondition + " group by Week,WeekTimeRange order by Week Asc ";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 获取教学班周教师打分平均分
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetWeekAVGTeaScoreDataTable(string strCondition)
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
            objSQL = clsvPaperDA.GetSpecSQLObj();
            //strSQL = "select Week,sum(1) as Num from gs_TotalDataStatistics where " + strCondition + " group by Week order by Week Asc ";
            strSQL = "select WeekTimeRange,Week,sum(1) as Num,(ROUND(AVG(TeaScore), 2)) as TeaScore  from gs_TotalDataStatistics where " + strCondition + " And TeaScore is not null And TeaScore <> 0 group by Week,WeekTimeRange order by Week Asc ";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取学生、周的统计数量
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetUser_WeekNumDataTable(string strCondition)
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
            objSQL = clsvPaperDA.GetSpecSQLObj();
            strSQL = "select WeekTimeRange,DataUser,Week,sum(1) as Num from gs_TotalDataStatistics where " + strCondition + " group by DataUser,Week,WeekTimeRange order by DataUser Asc ";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }


        /// <summary>
        /// 获取学生统计数量
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetUserNumDataTable(string strCondition)
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
            objSQL = clsvPaperDA.GetSpecSQLObj();
            strSQL = "select DataUser,sum(1) as Num from gs_TotalDataStatistics where " + strCondition + " group by DataUser order by DataUser Asc ";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}