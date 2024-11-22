
/*-- -- -- -- -- -- -- -- -- -- --
类名:SubViewpointTypeExApiController
表名:SubViewpointType(01120533)
生成代码版本:2019.11.22.1
生成日期:2019/12/02 13:39:07
生成者:
生成服务器IP:101.251.68.133
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_服务扩展层(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using com.taishsoft.json;
 

using ExamLib.Entity;
using ExamLib.BusinessLogic;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    /// <summary>
    /// SubViewpointTypeExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class SubViewpointTypeExApiController : SubViewpointTypeApiController
    {

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/SubViewpointTypeApi/AddNewRecord
        /// 在Body区传输objSubViewpointTypeEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objSubViewpointTypeEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecordEx")]
        public ActionResult AddNewRecordEx([FromBody]clsSubViewpointTypeEN objSubViewpointTypeEN)
        {

            //获取主键
            objSubViewpointTypeEN.SubViewpointTypeId = GetMaxStrId().ToString();
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strSubViewpointTypeJSONObj = clsJSON.GetJsonFromObj(objSubViewpointTypeEN);
            dictParam.Add("strSubViewpointTypeJSONObj", strSubViewpointTypeJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true)
            {
                string strMsg = string.Format("添加记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (clsSubViewpointTypeBL.IsExist(objSubViewpointTypeEN.SubViewpointTypeId) == true)
            {
                string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!({1})", objSubViewpointTypeEN.SubViewpointTypeId, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                bool bolResult = objSubViewpointTypeEN.AddNewRecord();
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
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