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
        //ͬʱɾ��������¼
        public static bool DelAnswerEx(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsAnswerDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            strSQL = "";
            //ɾ��Answer�������뵱ǰ�����йصļ�¼
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
        /// Ϊĳ��Ŀ�����д���ȷ���߲���ȷ
        /// </summary>
        /// <param name="strQuestionId">��ĿId</param>
        /// <param name="bolIsCorrect">ΪTrueʱ��ȷ��FalseʱΪ����ȷ</param>
        /// <returns>���õļ�¼��</returns>
        public static int SetCorrectAnswer(long strQuestionId, bool bolIsCorrect)
        {
            int intCount = clsGeneralTab.funSetFldValue("Answer", "IsCorrect", bolIsCorrect ? "1" : "0", "QuestionId = '" + strQuestionId.ToString() + "'");
            return intCount;
        }
       
    }
}
