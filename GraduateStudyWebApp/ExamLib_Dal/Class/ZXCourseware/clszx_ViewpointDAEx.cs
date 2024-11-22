
/*-- -- -- -- -- -- -- -- -- -- --
类名:clszx_ViewpointDAEx
表名:zx_Viewpoint(01120705)
生成代码版本:2020.07.31.1
生成日期:2020/08/03 09:32:26
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
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
    /// 中学观点表(zx_Viewpoint)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clszx_ViewpointDAEx : clszx_ViewpointDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clszx_ViewpointDAEx()
        {
        }


        public static System.Data.DataTable GetAllVNumDataTable(string strPapeId)
        {
            try
            {
                //clsCheckSql.CheckStrSQL_Weak(strCondition);
                //strCondition = clsString.RemoveElementValue(strCondition, "exclude");
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
            strSQL = "SELECT PdfPageNum,SUM(1) as Num FROM(SELECT PdfPageNum, SUM(1) as Num FROM zx_Viewpoint where TextId = '" + strPapeId + "'  GROUP BY PdfPageNum UNION ALL SELECT PdfPageNum,SUM(1) as Num FROM zx_Concept where TextId = '" + strPapeId + "'  GROUP BY PdfPageNum UNION ALL SELECT PdfPageNum,SUM(1) as Num FROM zx_TopicObjective where TextId = '" + strPapeId + "'  GROUP BY PdfPageNum UNION ALL SELECT PdfPageNum,SUM(1) as Num FROM zx_Skill where TextId = '" + strPapeId + "'  GROUP BY PdfPageNum UNION ALL SELECT PdfPageNum,SUM(1) as Num FROM zx_SocialRelations where TextId = '" + strPapeId + "'  GROUP BY PdfPageNum) as a GROUP BY PdfPageNum";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}