
/*-- -- -- -- -- -- -- -- -- -- --
类名:cc_CourseKnowledgesExApiController
表名:cc_CourseKnowledges(01120082)
生成代码版本:2019.11.22.1
生成日期:2019/12/04 11:09:48
生成者:
生成服务器IP:101.251.68.133
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关
模块英文名:Knowledges
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
using Comm.WebApi;

namespace ExamLib.WebApi
{
    /// <summary>
    /// cc_CourseKnowledgesExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class cc_CourseKnowledgesExApiController : cc_CourseKnowledgesApiController
    {

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/cc_CourseKnowledgesApi/AddNewRecord
        /// 在Body区传输objcc_CourseKnowledgesEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objcc_CourseKnowledgesEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecordEx")]
        public bool AddNewRecordEx([FromBody]clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
        {
            //获取主键最大值+1；
            objcc_CourseKnowledgesEN.CourseKnowledgeId = GetMaxStrId().ToString();
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strcc_CourseKnowledgesJSONObj = clsJSON.GetJsonFromObj(objcc_CourseKnowledgesEN);
            dictParam.Add("strcc_CourseKnowledgesJSONObj", strcc_CourseKnowledgesJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
            {
                string strMsg = string.Format("添加记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }
            if (clscc_CourseKnowledgesBL.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
            {
                string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!({1})", objcc_CourseKnowledgesEN.CourseKnowledgeId, clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }
            try
            {
                bool bolResult = objcc_CourseKnowledgesEN.AddNewRecord();
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }
        }
    }
}