
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_StuBatchQuesRelaDAEx
表名:ge_StuBatchQuesRela(01120885)
生成代码版本:2021.02.21.1
生成日期:2021/02/25 15:41:00
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:互动管理
模块英文名:InteractManage
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
    /// 学生批次题目关系(ge_StuBatchQuesRela)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsge_StuBatchQuesRelaDAEx : clsge_StuBatchQuesRelaDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsge_StuBatchQuesRelaDAEx()
        {
        }

      

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable) 闯关号+课程号获取随机数据；
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable GetDataTableEx(string CourseId, string DifficultyLevelId,string QuestionTypeId,  int QuestionNum,string strCourseChapterId,string strLevelModeTypeId)
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
                //根据闯关号，来获取题目中对应的随机数据；
                //strSQL = "SELECT TOP "+QuestionNum+ " * FROM Questionnaire where QuestionTypeId=" + QuestionTypeId + " And DifficultyLevelId='"+DifficultyLevelId+"' And CourseId='" + CourseId + "' ORDER BY NEWID()";

                //直接通过课程 和章节、等级 、题目类型来查找相关所有数据；
                strSQL = "SELECT * FROM Questionnaire where QuestionTypeId=" + QuestionTypeId + " And DifficultyLevelId='" + DifficultyLevelId + "' And CourseId='" + CourseId + "' And CourseChapterId ='"+strCourseChapterId+ "' And LevelModeTypeId in ("+strLevelModeTypeId+ ") ORDER BY NEWID()";
                //strSQL = "SELECT * FROM Questionnaire where QuestionTypeId=" + QuestionTypeId + " And DifficultyLevelId='" + DifficultyLevelId + "' And CourseId='" + CourseId + "' And CourseChapterId in (" + strCourseChapterId+")";




                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
            }
          
            return objDT;
        }

        public static System.Data.DataTable GetDT_RecommendTopics(string strCourseKnowledgeId, string DifficultyLevelId, string QuestionTypeId)
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
                //根据闯关号，来获取题目中对应的随机数据；
                //strSQL = "SELECT TOP "+QuestionNum+ " * FROM Questionnaire where QuestionTypeId=" + QuestionTypeId + " And DifficultyLevelId='"+DifficultyLevelId+"' And CourseId='" + CourseId + "' ORDER BY NEWID()";

                //直接通过课程 和章节、等级 、题目类型来查找相关所有数据；
                strSQL = $"SELECT * FROM Questionnaire where QuestionTypeId='{QuestionTypeId}' And DifficultyLevelId='${DifficultyLevelId}' ";
                strSQL += $" And {concc_KnowledgesExamLibRela.QuestionId} in (select {concc_KnowledgesExamLibRela.QuestionId} from {concc_KnowledgesExamLibRela._CurrTabName} where {concc_KnowledgesExamLibRela.CourseKnowledgeId} = '{strCourseKnowledgeId}' and {concc_KnowledgesExamLibRela.IsMain} = '1') ORDER BY NEWID()";

                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
            }

            return objDT;
        }

        public static System.Data.DataTable GetDT_RecommendTopics(string strCourseKnowledgeId,  string QuestionTypeId)
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
                //根据闯关号，来获取题目中对应的随机数据；
                //strSQL = "SELECT TOP "+QuestionNum+ " * FROM Questionnaire where QuestionTypeId=" + QuestionTypeId + " And DifficultyLevelId='"+DifficultyLevelId+"' And CourseId='" + CourseId + "' ORDER BY NEWID()";

                //直接通过课程 和章节、等级 、题目类型来查找相关所有数据；
                strSQL = $"SELECT * FROM Questionnaire where QuestionTypeId='{QuestionTypeId}' ";
                strSQL += $" And {concc_KnowledgesExamLibRela.QuestionId} in (select {concc_KnowledgesExamLibRela.QuestionId} from {concc_KnowledgesExamLibRela._CurrTabName} where {concc_KnowledgesExamLibRela.CourseKnowledgeId} = '{strCourseKnowledgeId}' and {concc_KnowledgesExamLibRela.IsMain} = '1') ORDER BY NEWID()";

                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
            }

            return objDT;
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查   ----QuestionTypeID='09' 只获取操作类型题目
        /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable) 闯关号+课程号获取随机数据；
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable GetDataTableByQuestionTypeEx(string CourseId)
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
                //根据闯关号，来获取题目中对应的随机10条数据；
                strSQL = "SELECT TOP 1 * FROM Questionnaire where QuestionTypeID='09' And CourseId='" + CourseId + "' ORDER BY NEWID()";
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
            }

            return objDT;
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)根据课程号获取最大闯关号；
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回数据表DataTable</returns>
        public static string GetLevelNoByCourseIdEx(string CourseId)
        {
            string strSQL;
            //System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            try
            {
                //clsCheckSql.CheckStrSQL_Weak(strCondition);
                //strCondition = clsString.RemoveElementValue(strCondition, "exclude");

                //获取连接对象
                objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
                //根据闯关号，来获取题目中对应的随机10条数据；
                strSQL = "SELECT max(LevelNo) as LevelNo FROM Questionnaire where CourseId='"+ CourseId + "'";
               // objDT = objSQL.ExecSql2(strSQL);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
            }
            return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();

        }
     
        
    }
}