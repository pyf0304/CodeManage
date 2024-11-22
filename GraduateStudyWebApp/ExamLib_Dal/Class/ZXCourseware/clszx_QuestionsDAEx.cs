
/*-- -- -- -- -- -- -- -- -- -- --
类名:clszx_QuestionsDAEx
表名:zx_Questions(01120722)
生成代码版本:2020.08.04.1
生成日期:2020/08/20 16:02:33
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:中学生课件管理
模块英文名:ZXCourseware
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
    /// zx_Questions(zx_Questions)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clszx_QuestionsDAEx : clszx_QuestionsDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clszx_QuestionsDAEx()
        {
        }
        public static System.Data.DataTable GetPageNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_QuestionsDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clszx_QuestionsDA.GetSpecSQLObj();
            strSQL = "SELECT PdfPageNum,TextId,SUM(1) as PdfNum   FROM  zx_Questions where " + strCondition + " group by PdfPageNum,TextId order by TextId,PdfPageNum Asc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

    }
}