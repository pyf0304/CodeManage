
/*-- -- -- -- -- -- -- -- -- -- --
类名:XzClgExApiController
表名:XzClg(01120064)
* 版本:2023.12.07.1(服务器:WIN-SRV103-116)
日期:2023/12/11 17:01:37
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:基本信息维护(BaseInfo)
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
    /// XzClgExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class XzClgExApiController : ControllerBase
    {

        /// <summary>
        /// 获取统一平台中部门Id
        /// 调用方法: Get /api/clsXzClgBLExApi/GetDepartmentIdInGPByIdCollege?strid_XzCollege=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strid_XzCollege">strid_XzCollege</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetDepartmentIdInGPByIdCollege")]
        public ActionResult GetDepartmentIdInGPByIdCollege(string strid_XzCollege)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strid_XzCollege", strid_XzCollege);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsXzClgBLEx.GetDepartmentIdInGPByIdCollege(strid_XzCollege);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}