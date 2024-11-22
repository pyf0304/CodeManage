/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvqa_AnswerDAEx
表名:vqa_Answer(01120635)
生成代码版本:2020.08.03.1
生成日期:2020/08/03 13:55:52
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:互动管理
模块英文名:InteractManage
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
    /// v答疑回答(vqa_Answer)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsvqa_AnswerDAEx : clsvqa_AnswerDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsvqa_AnswerDAEx()
        {

        }

        public static System.Data.DataTable Getvqa_AnswerTopicIdNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
            strSQL = " select TopicId,Sum(1) as ACount  from  vqa_Answer where " + strCondition + " group by TopicId order by ACount Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }


        public static System.Data.DataTable Getvqa_AnswerUserNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvqa_AnswerDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvqa_AnswerDA.GetSpecSQLObj();
            strSQL = " select UpdUser,UserName,Sum(1) as UserCount  from  vqa_Answer where " + strCondition + " group by UpdUser,UserName order by UserCount Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}