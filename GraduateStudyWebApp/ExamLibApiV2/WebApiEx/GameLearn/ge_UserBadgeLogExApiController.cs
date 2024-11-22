
/*-- -- -- -- -- -- -- -- -- -- --
类名:ge_UserBadgeLogExApiController
表名:ge_UserBadgeLog(01120881)
生成代码版本:2022.12.10.1
生成日期:2022/12/11 04:55:04
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
using com.taishsoft.common;
using Comm.WebApi;
using ExamLib.BusinessLogicEx;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ExamLib.WebApi
{
    /// <summary>
    /// ge_UserBadgeLogExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ge_UserBadgeLogExApiController : ControllerBase
    {

        /// <summary>
        /// 根据积分自动设置徽章
        /// 调用方法: Get /api/clsge_UserBadgeLogBLExApi/ImportCreditBadge?strCourseChapterId=value&strCourseId=value&strOpUser=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCourseChapterId">章节Id</param>
        /// <param name = "strCourseId">课程Id</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("ImportCreditBadge")]
        public ActionResult ImportCreditBadge(string strCourseChapterId, string strCourseId, string strOpUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCourseChapterId", strCourseChapterId);
            dictParam.Add("strCourseId", strCourseId);
            dictParam.Add("strOpUser", strOpUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsge_UserBadgeLogBLEx.ImportCreditBadge(strCourseChapterId, strCourseId, strOpUser);
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