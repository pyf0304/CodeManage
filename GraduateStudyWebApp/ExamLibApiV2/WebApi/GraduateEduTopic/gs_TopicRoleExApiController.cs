
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_MeetingMinutesExApiController
表名:gs_MeetingMinutes(01120549)
生成代码版本:2019.12.06.1
生成日期:2019/12/25 17:53:33
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_服务扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using ExamLib.BusinessLogicEx;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class gs_TopicRoleExApiController : ControllerBase
    {
        // 添加默认设置
        [HttpGet("AddDefaultSettings")]
        public ActionResult AddDefaultSettings(string strTopicId, string strUpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTopicId", strTopicId);
            dictParam.Add("strUpdUser", strUpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
           
            try
            {
                bool varResult = false;
                varResult = clsgs_TopicRoleBLEx.AddDefaultSettings(strTopicId, strUpdUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

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