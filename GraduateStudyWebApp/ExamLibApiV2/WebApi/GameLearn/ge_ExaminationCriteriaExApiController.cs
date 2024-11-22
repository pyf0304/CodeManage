using com.taishsoft.common;
using com.taishsoft.json;
using ExamLib.BusinessLogic;
using ExamLib.BusinessLogicEx;
using ExamLib.Entity;
using ExamLib.WebApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLibApi.Controllers.GameLearn
{
    [ApiController]
    [Route("[controller]")]
    public class ge_ExaminationCriteriaExApiController : ControllerBase
    {
        public ge_ExaminationCriteriaExApiController()
        {
        }
        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// 调用方法: POST /api/ge_StuBatchQuesRelaApi/AddNewRecord
        /// 在Body区传输objge_StuBatchQuesRelaEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objge_StuBatchQuesRelaEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        [HttpGet("GetChapterNameByGameLevelIdEx")]
        public ActionResult GetChapterNameByGameLevelIdEx(string GameLevelId)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["GameLevelId"] = GameLevelId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strKey = clsge_ExaminationCriteriaBLEx.GetChapterNameByGameLevelIdEx(GameLevelId);

                return Ok(new { errorId = 0, errorMsg = "", returnStr = strKey });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// 调用方法: POST /api/ge_InspectionResultsApi/AddNewRecord
        /// 在Body区传输objge_InspectionResultsEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objge_InspectionResultsEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>

        [HttpPost("Getge_InspectionResultsEx")]
        public ActionResult Getge_InspectionResultsEx([FromBody] clsge_InspectionResultsENEx objge_InspectionResultsEN)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strge_InspectionResultsJSONObj = clsJSON.GetJsonFromObj(objge_InspectionResultsEN);
            dictParam.Add("objge_InspectionResultsEN", strge_InspectionResultsJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                List<clsge_InspectionResultsEN> arrge_InspectionResultsObjLst = clsge_ExaminationCriteriaBLEx.Getge_InspectionResultsEx(objge_InspectionResultsEN);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrge_InspectionResultsObjLst });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }




        /// 功能:判断根据界面传递的html代码 判断 检查类型是隐藏， 还是删除控件操作；
        /// 调用方法: GET /api/UserAnswerResultApi/IsExistRecord? strWhereCond = v1 &
        /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExistRecordByCond)
        /// </summary>
        /// <param name = "strWhereCond" > 条件串 </ param >
        /// < returns > 包含结果的Jobject, 如果存在就返回TRUE, 否则返回FALSE</returns>
        [HttpPost("Getge_InspectionResultsByExamTypeEx")]
        public ActionResult Getge_InspectionResultsByExamTypeEx([FromBody] clsge_InspectionResultsENEx objge_InspectionResultsEN)
        {
            //string strFunctionName = clsStackTrace.GetCurrFunction();
            //Dictionary<string, string> dictParam = new Dictionary<string, string>()
            //{
            //    ["UserId"] = UserId,
            //    ["QuestionId"] = QuestionId,
            //    ["ExamBatchNo"] = ExamBatchNo,

            //    ["CourseId"] = CourseId,
            //    ["ControlHtml"] = ControlHtml,
            //     ["Result"] = Result//代表检查类型为 隐藏 或删除时候，判断的结果值；暂定 1（操作成功） 和2（失败）；

            //};

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strge_InspectionResultsJSONObj = clsJSON.GetJsonFromObj(objge_InspectionResultsEN);
            dictParam.Add("objge_InspectionResultsEN", strge_InspectionResultsJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);


            // clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                //ge_InspectionResults(编程检查结果表)

                List<clsge_InspectionResultsEN> arrge_InspectionResultsObjLst = clsge_ExaminationCriteriaBLEx.Getge_InspectionResultsByExamTypeEx(objge_InspectionResultsEN);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrge_InspectionResultsObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }

        }


        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// 调用方法: POST /api/ge_InspectionResultsApi/AddNewRecord
        /// 在Body区传输objge_InspectionResultsEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objge_InspectionResultsEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        [HttpPost("SubmitQuestionEx")]
        public ActionResult SubmitQuestionEx([FromBody] clsge_InspectionResultsENEx objge_InspectionResultsEN)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strge_InspectionResultsJSONObj = clsJSON.GetJsonFromObj(objge_InspectionResultsEN);
            dictParam.Add("objge_InspectionResultsEN", strge_InspectionResultsJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {

                bool bolIsExist = clsge_ExaminationCriteriaBLEx.SubmitQuestionRecord(objge_InspectionResultsEN);
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
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// 调用方法: POST /api/ge_InspectionResultsApi/AddNewRecord
        /// 在Body区传输objge_InspectionResultsEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objge_InspectionResultsEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        [HttpPost("SubmitAllQuestionEx")]
        public ActionResult SubmitAllQuestionEx([FromBody] clsge_InspectionResultsENEx objge_InspectionResultsEN, string strGameLevelId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strge_InspectionResultsJSONObj = clsJSON.GetJsonFromObj(objge_InspectionResultsEN);
            dictParam.Add("objge_InspectionResultsEN", strge_InspectionResultsJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {

                bool bolIsExist = clsge_ExaminationCriteriaBLEx.SubmitAllQuestionRecord(objge_InspectionResultsEN, strGameLevelId, "");
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
        /// 获取当前表满足条件的第一条记录的对象
        /// 调用方法: GET /api/ge_StuBatchQuesRelaApi/GetFirstObj?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFirstObj)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的对象</returns>
        [HttpGet("GetObjByParaEx")]
        public ActionResult GetObjByParaEx(string UserId, string IdCurrEduCls)
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["UserId"] = UserId,
                ["IdCurrEduCls"] = IdCurrEduCls
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = clsge_ExaminationCriteriaBLEx.GetObjByParaEx(UserId, IdCurrEduCls);

                return Ok(new { errorId = 0, errorMsg = "", returnObj = objge_StuBatchQuesRelaEN });
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