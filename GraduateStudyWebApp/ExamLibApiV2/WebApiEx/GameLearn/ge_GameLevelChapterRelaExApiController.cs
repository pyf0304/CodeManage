
/*-- -- -- -- -- -- -- -- -- -- --
类名:ge_GameLevelChapterRelaExApiController
表名:ge_GameLevelChapterRela(01120913)
生成代码版本:2022.11.24.1
生成日期:2022/11/30 02:23:10
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:游戏化学习(GameLearn)
框架-层名:WA_服务扩展层(CS)(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using com.taishsoft.json;
using ExamLib.Entity;
using ExamLib.BusinessLogicEx;

using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    /// <summary>
    /// ge_GameLevelChapterRelaExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ge_GameLevelChapterRelaExApiController : ControllerBase
    {
        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/ge_GameLevelChapterRelaApi/AddNewRecord
        /// 在Body区传输objge_GameLevelChapterRelaEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objge_GameLevelChapterRelaEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecordEx")]
        public ActionResult AddNewRecordEx([FromBody] clsge_GameLevelChapterRelaEN objge_GameLevelChapterRelaEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strge_GameLevelChapterRelaJSONObj = clsJSON.GetJsonFromObj(objge_GameLevelChapterRelaEN);
            dictParam.Add("strge_GameLevelChapterRelaJSONObj", strge_GameLevelChapterRelaJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                bool bolResult = clsge_GameLevelChapterRelaBLEx.AddNewRecordEx(objge_GameLevelChapterRelaEN);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 扩展删除
        /// 调用方法: Get /api/clsge_GameLevelChapterRelaBLExApi/DelRecordEx?strGameLevelId=value&strCourseChapterId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strGameLevelId">关卡Id</param>
        /// <param name = "strCourseChapterId">章节Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRecordEx")]
        public ActionResult DelRecordEx(string strGameLevelId, string strCourseChapterId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strGameLevelId", strGameLevelId);
            dictParam.Add("strCourseChapterId", strCourseChapterId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_GameLevelChapterRelaBLEx.DelRecordEx(strGameLevelId, strCourseChapterId);
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