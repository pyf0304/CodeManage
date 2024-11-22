
/*-- -- -- -- -- -- -- -- -- -- --
类名:QuestionnaireExApiController
表名:Questionnaire(01120001)
生成代码版本:2019.08.30.1
生成日期:2019/09/25 13:05:55
生成者:
生成服务器IP:101.251.68.133
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:问卷维护
模块英文名:QuestionaireEdit
框架-层名:WA_服务扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using com.taishsoft.json;
using Comm.WebApi;
using ExamLib.BusinessLogic;
using ExamLib.BusinessLogicEx;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;

namespace ExamLib.WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionnaireExApiController : ControllerBase
    {

        /// <summary>
        /// 获取给定表中满足条件的记录数
        /// 调用方法: Get /api/QuestionnaireExApiControllerApi/GetRecCountByCond?strWhereCond=value
        /// (ExamLib.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetRecCountByCond")]
        public int GetRecCountByCond(string strWhereCond)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strWhereCond", strWhereCond);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQuestionnaireBLEx.GetRecCountByCond(strWhereCond);
                return varResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                return 0;
            }
        }
    
        /// <summary>
        /// 导入Excel数据
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "objExcelData">Excel数据结构</param>
        /// <returns>返回是否存在?</returns>
        [HttpPost("ImportDataFromCsv")]
        public ActionResult ImportDataFromCsv([FromBody] stuExcelData objExcelData)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strJSONString = clsJSON.GetJsonFromObj(objExcelData);
            dictParam.Add("objExcelData", strJSONString);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQuestionnaireBLEx.ImportDataFromCsv(objExcelData);       
                return Ok(new { errorId = 0, errorMsg = "", ReturnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 扩展删除
        /// 调用方法: Get /api/clsQuestionnaireBLExApi/DelRecordEx?strQuestionId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strQuestionId">题目Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(long strQuestionId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strQuestionId", strQuestionId.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQuestionnaireBLEx.DelRecordEx(strQuestionId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 设置题目的标准答案For选择题
        /// 调用方法: Get /api/clsQuestionnaireBLExApi/SetQuestionAnswer4SingleChoice?strCourseId=value&strOpUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCourseId">课程Id</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetQuestionAnswer4SingleChoice")]
        public ActionResult SetQuestionAnswer4SingleChoice(string strCourseId, string strOpUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCourseId", strCourseId);
            dictParam.Add("strOpUser", strOpUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQuestionnaireBLEx.SetQuestionAnswer4SingleChoice(strCourseId, strOpUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}