
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_PaperParagraphVerDAEx
表名:gs_PaperParagraphVer(01120743)
* 版本:2023.01.12.1(服务器:WIN-SRV103-116)
日期:2023/01/12 15:19:03
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
框架-层名:数据处理扩展层(CS)(DALExCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;

using ExamLib.Entity;
using com.taishsoft.commdb;

namespace ExamLib.DAL
{
    /// <summary>
    /// 论文段落版本(gs_PaperParagraphVer)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsgs_PaperParagraphVerDAEx : clsgs_PaperParagraphVerDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsgs_PaperParagraphVerDAEx()
        {
        }
        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable GetDataTableEx(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_PaperParagraphVerDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsgs_PaperParagraphVerDA.GetSpecSQLObj();
            strSQL = "Select UpdUser,max(ParagraphVId) as ParagraphVId,ParagraphId from gs_PaperParagraphV where " + strCondition + " Group By UpdUser,ParagraphId Order By ParagraphVId Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

    }
}