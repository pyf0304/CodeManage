
/*-- -- -- -- -- -- -- -- -- -- --
类名:cc_WorkStuRelationExApiController
表名:cc_WorkStuRelation(01120145)
* 版本:2023.12.07.1(服务器:WIN-SRV103-116)
日期:2023/12/11 17:25:48
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:互动管理(InteractManage)
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
    /// cc_WorkStuRelationExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class cc_WorkStuRelationExApiController : ControllerBase
    {

        /// <summary>
        /// 获取家庭作业
        /// 调用方法: Get /api/clscc_WorkStuRelationBLExApi/GetHomeWork?strIdStu=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdStu">学生流水号</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetHomeWork")]
        public ActionResult GetHomeWork(string strIdStu)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strIdStu", strIdStu);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clscc_WorkStuRelationBLEx.GetHomeWork(strIdStu);
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