
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPaperDAEx
表名:vPaper(01120549)
生成代码版本:2020.02.10.2
生成日期:2020/02/11 13:17:02
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
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
    /// v论文表(vPaper)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsvPaperDAEx
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsvPaperDAEx()
        {
        }

        //public static System.Data.DataTable GetUserNumDataTable(string strCondition)
        //{
        //    try
        //    {
        //        clsCheckSql.CheckStrSQL_Weak(strCondition);
        //        strCondition = clsString.RemoveElementValue(strCondition, "exclude");
        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
        //    }
        //    string strSQL;
        //    System.Data.DataTable objDT;
        //    clsSpecSQLforSql objSQL = null;
        //    //获取连接对象
        //    objSQL = clsvPaperDA.GetSpecSQLObj();
        //    strSQL = "SELECT IdXzCollege,CollegeName,IdXzMajor,MajorName,UpdUser,UserName,SUM(1) as UserNum,SUM(OkCount)AS OkCount,SUM(AppraiseCount)AS AppraiseCount  FROM  vPaper where " + strCondition + " group by IdXzCollege,CollegeName,IdXzMajor,MajorName,UpdUser,UserName order by UserNum Desc";
        //    objDT = objSQL.GetDataTable(strSQL);
        //    return objDT;
        //}

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
            strSQL = "SELECT UpdUser,SUM(1) as UserNum,SUM(OkCount)AS OkCount,SUM(AppraiseCount)AS AppraiseCount  FROM  vPaper where " + strCondition + " group by UpdUser order by UserNum Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }


        public static System.Data.DataTable GetMajorNumDataTable(string strCondition)
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
            strSQL = "SELECT IdXzMajor,MajorName,SUM(1) as MajorNum  FROM  vPaper where " + strCondition + " and MajorName<>'' group by IdXzMajor,MajorName order by MajorNum Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public static System.Data.DataTable GetPaperLikeNumDataTable(string strCondition)
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
            objSQL = clsvPaperLikeLogDA.GetSpecSQLObj();
            strSQL = "select UpdUser,UserName,SUM(1) as LikeNum FROM vPaperLikeLog where " + strCondition + " Group by UpdUser,UserName order by LikeNum Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }


        
        public static System.Data.DataTable GetPaperAppraiseNumDataTable(string strCondition)
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
            objSQL = clsvPaperAppraiseDA.GetSpecSQLObj();
            strSQL = "select UpdUser,UserName,SUM(1) as AppraiseNum FROM vPaperAppraise where " + strCondition + " Group by UpdUser,UserName order by AppraiseNum Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}