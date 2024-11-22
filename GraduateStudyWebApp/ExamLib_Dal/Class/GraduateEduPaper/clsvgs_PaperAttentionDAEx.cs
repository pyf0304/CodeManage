/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvgs_PaperAttentionDAEx
表名:vgs_PaperAttention(01120750)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 11:51:14
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
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
    /// vgs_PaperAttention(vgs_PaperAttention)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsvgs_PaperAttentionDAEx : clsvgs_PaperAttentionDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsvgs_PaperAttentionDAEx()
        {
        }


        public static System.Data.DataTable GetPaperIdNumDataTable(string strCondition)
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
            objSQL = clsvgs_PaperAttentionDA.GetSpecSQLObj();
            strSQL = "SELECT PaperId FROM Paper where " + strCondition;
            strSQL += " UNION SELECT PaperId FROM PaperSubViewpoint where " + strCondition;
            strSQL += " UNION SELECT PaperId FROM qa_Questions where " + strCondition;
            strSQL += " UNION SELECT PaperId FROM gs_Tags where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}