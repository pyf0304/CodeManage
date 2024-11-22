using com.taishsoft.common;
using ExamLib.BusinessLogicEx;
using ExamLib.WebApi;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLibApi.Controllers.QuestionnaireResult
{
    [ApiController]
    [Route("[controller]")]
    public class UserAnswerResultExApiController : ControllerBase
    {
    

        /// <summary>
        /// 功能:判断是否存在某一条件的记录   MarkType(用来区分是点击上一步或下一步触发（类型值：1） ，还是点击提交按钮触发（类型值：2）；根据不同的类型去实行不同的操作；)
        /// 调用方法: GET /api/UserAnswerResultApi/IsExistRecord?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExistRecordByCond)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>包含结果的Jobject, 如果存在就返回TRUE,否则返回FALSE</returns>
        [HttpGet("AddOrUpdateRecord")]
        public ActionResult AddOrUpdateRecord(string UserId,string ExamBatchNo,long QuestionId,string IdCurrEduCls, string answerText)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["UserId"] = UserId,
                ["ExamBatchNo"] = ExamBatchNo,
                ["QuestionId"] = QuestionId.ToString(),
                ["IdCurrEduCls"] = IdCurrEduCls,
                ["answerText"] = answerText,
             
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
                       
            try
            {
                bool bolIsExist = clsUserAnswerResultBLEx.AddOrUpdateRecord(UserId, ExamBatchNo, QuestionId, IdCurrEduCls, answerText);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolIsExist });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:判断是否存在某一条件的记录   MarkType(用来区分是点击上一步或下一步触发（类型值：1） ，还是点击提交按钮触发（类型值：2）；根据不同的类型去实行不同的操作；)
        /// 调用方法: GET /api/UserAnswerResultApi/IsExistRecord?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExistRecordByCond)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>包含结果的Jobject, 如果存在就返回TRUE,否则返回FALSE</returns>
        [HttpGet("Score_UserAnswer")]
        public ActionResult Score_UserAnswer(string MarkerId, string UserId, string strGameLevelId, string ExamBatchNo, long QuestionId, string IdCurrEduCls, float Score, bool Passed)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["MarkerId"] = MarkerId,
                ["UserId"] = UserId,
                ["ExamBatchNo"] = ExamBatchNo,
                ["QuestionId"] = QuestionId.ToString(),
                ["IdCurrEduCls"] = IdCurrEduCls,
                ["Score"] = Score.ToString(),
                ["Passed"] = Passed.ToString()


            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                bool bolIsExist = clsUserAnswerResultBLEx.Score_UserAnswer(MarkerId, UserId, strGameLevelId, ExamBatchNo, QuestionId, IdCurrEduCls, Score, Passed);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolIsExist });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

    }
}