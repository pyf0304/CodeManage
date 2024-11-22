using System;
using System.Collections.Generic;
using System.Text;
using com.taishsoft.common;
using System.Collections;
using com.taishsoft.commdb;
using System.Data;
using ExamLib.Entity; 

namespace ExamLib.DAL
{
    public class clsAnswerDAEx : clsAnswerDA
    {
        //同时删除多条记录
        public static bool DelAnswerEx(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsAnswerDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            strSQL = "";
            //删除Answer本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from UserAnswerResult where AnswerID in (" + strKeyList + ");";
            strSQL = strSQL + "Delete from Answer where AnswerID in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static int AnswerCount(long strQuestionId)
        {
            int intCount = clsGeneralTab.funGetRecCountByCond("Answer", "QuestionId = " + strQuestionId.ToString());
            return intCount;
        }
        /// <summary>
        /// 为某题目的所有答案正确或者不正确
        /// </summary>
        /// <param name="strQuestionId">题目Id</param>
        /// <param name="bolIsCorrect">为True时正确，False时为不正确</param>
        /// <returns>设置的记录数</returns>
        public static int SetCorrectAnswer(long strQuestionId, bool bolIsCorrect)
        {
            int intCount = clsGeneralTab.funSetFldValue("Answer", "IsCorrect", bolIsCorrect ? "1" : "0", "QuestionId = '" + strQuestionId.ToString() + "'");
            return intCount;
        }
       
    }
}
