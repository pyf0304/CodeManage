using com.taishsoft.common;
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

namespace ExamLibApi.Controllers.InteractManage
{
    [ApiController]
    [Route("[controller]")]
    public class ge_StuBatchQuesRelaExApiController : ControllerBase
    {
       

        //根据传过来的用户ID(UserId)，教学班ID(IdCurrEduCls)、以及闯关号(LevelNo) ，来查询题目表，随机获取相关闯关号对应的题目，然后插入到学生批次题目关系表中（ge_StuBatchQuesRela）；
        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/ge_StuBatchQuesRelaApi/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("Getge_StuBatchQuesRelaListExV2")]
        public ActionResult Getge_StuBatchQuesRelaListExV2(string UserId,string IdCurrEduCls, string DifficultyLevelId, string QuestionTypeId,int QuestionNum,string GameLevelId)
        {
            //
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["UserId"] = UserId,
                ["IdCurrEduCls"] = IdCurrEduCls,
                ["DifficultyLevelId"] = DifficultyLevelId,
                ["QuestionTypeId"] = QuestionTypeId,
                ["QuestionNum"] = Convert.ToString(QuestionNum),
                ["GameLevelId"] = GameLevelId

            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
           
            try
            {
                List<clsge_StuBatchQuesRelaEN> arrge_StuBatchQuesRelaObjLst = clsge_StuBatchQuesRelaBLEx.Getge_StuBatchQuesRelaListEx(UserId,IdCurrEduCls, DifficultyLevelId, QuestionTypeId, QuestionNum, GameLevelId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrge_StuBatchQuesRelaObjLst });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        //获取推荐的学生批次问题对象列表
        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/ge_StuBatchQuesRelaApi/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("Getge_StuBatchQuesRelaListEx")]
        public ActionResult Getge_StuBatchQuesRelaListEx(string UserId, string CourseId)
        {
            
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["UserId"] = UserId,
                ["CourseId"] = CourseId,
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                List<clsge_StuBatchQuesRelaEN> arrge_StuBatchQuesRelaObjLst = clsge_StuBatchQuesRelaBLEx.Getge_StuBatchQuesRelaListEx(UserId, CourseId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrge_StuBatchQuesRelaObjLst });

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
        /// 调用方法: POST /api/ge_StuBatchQuesRelaApi/AddNewRecord
        /// 在Body区传输objge_StuBatchQuesRelaEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objge_StuBatchQuesRelaEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        [HttpGet("GetLevelNoByCourseIdEx")]
        public ActionResult GetLevelNoByCourseIdEx(string CourseId, string strIdCurrEduCls)
        {
            
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["CourseId"] = CourseId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strKey = clsge_StuBatchQuesRelaBLEx.GetLevelNoByCourseIdEx(CourseId, strIdCurrEduCls);
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
        /// 设置是否有答案
        /// 调用方法: Get /api/clsge_StuBatchQuesRelaBLExApi/SetIsHasAnswer?strIdCurrEduCls=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetIsHasAnswer")]
        public ActionResult SetIsHasAnswer(string strIdCurrEduCls)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_StuBatchQuesRelaBLEx.SetIsHasAnswer(strIdCurrEduCls);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 设置是否有答案
        /// 调用方法: Get /api/clsge_StuBatchQuesRelaBLExApi/GetLastExamBatchNo?strGameLevelId=value&strUserId=value&bolIsRecommend=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strGameLevelId">关卡Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "bolIsRecommend">是否推荐</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetLastExamBatchNo")]
        public ActionResult GetLastExamBatchNo(string strGameLevelId, string strUserId, bool bolIsRecommend)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strGameLevelId", strGameLevelId);
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("bolIsRecommend", bolIsRecommend.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_StuBatchQuesRelaBLEx.GetLastExamBatchNo(strGameLevelId, strUserId, bolIsRecommend);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        /// <summary>
        /// 推荐题目
        /// 调用方法: Get /api/clsge_StuBatchQuesRelaBLExApi/RecommendTopics?strCourseKnowledgeId=value&strUserId=value&strIdCurrEduCls=value&intQuestionNum=value&strGameLevelId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCourseKnowledgeId">知识点Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <param name = "intQuestionNum">问题数</param>
        /// <param name = "strGameLevelId">关卡Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("RecommendTopics")]
        public ActionResult RecommendTopics(string strCourseKnowledgeId, string strUserId, string strIdCurrEduCls, int intQuestionNum, string strGameLevelId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCourseKnowledgeId", strCourseKnowledgeId);
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            dictParam.Add("intQuestionNum", intQuestionNum.ToString());
            dictParam.Add("strGameLevelId", strGameLevelId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_StuBatchQuesRelaBLEx.RecommendTopics(strCourseKnowledgeId, strUserId, strIdCurrEduCls, intQuestionNum, strGameLevelId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}