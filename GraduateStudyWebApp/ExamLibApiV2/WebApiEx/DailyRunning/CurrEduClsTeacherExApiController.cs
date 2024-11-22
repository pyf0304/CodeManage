
/*-- -- -- -- -- -- -- -- -- -- --
类名:CurrEduClsTeacherExApiController
表名:CurrEduClsTeacher(01120124)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 14:45:47
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:日常运行
模块英文名:DailyRunning
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
using ExamLib.BusinessLogicEx;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    /// <summary>
    /// CurrEduClsTeacherExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class CurrEduClsTeacherExApiController : CurrEduClsTeacherApiController
    {

        
        /// <summary>
        /// 根据教师Id获取教学班流水号列表
        /// 调用方法: Get /api/clsCurrEduClsTeacherBLExApi/GetidCurrEduClsListByTeacherId?strTeacherId=value
        /// (ExamLib.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTeacherId">工号</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetidCurrEduClsListByTeacherId")]
        public ActionResult GetidCurrEduClsListByTeacherId(string strTeacherId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTeacherId", strTeacherId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsCurrEduClsTeacherBLEx.GetidCurrEduClsListByTeacherId(strTeacherId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 根据教学班流水号获取教师Id列表
        /// 调用方法: Get /api/clsCurrEduClsTeacherBLExApi/GetTeacherIdLstByIdCurrEduCls?strIdCurrEduCls=value
        /// (ExamLib.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetTeacherIdLstByIdCurrEduCls")]
        public ActionResult GetTeacherIdLstByIdCurrEduCls(string strIdCurrEduCls)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsCurrEduClsTeacherBLEx.GetTeacherIdLstByIdCurrEduCls(strIdCurrEduCls);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据工号获取教学班教师对象列表
        /// 调用方法: Get /api/clsCurrEduClsTeacherBLExApi/GetObjListByTeacherId?strTeacherId=value
        /// (ExamLib.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTeacherId">工号</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjListByTeacherId")]
        public ActionResult GetObjListByTeacherId(string strTeacherId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTeacherId", strTeacherId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsCurrEduClsTeacherBLEx.GetObjListByTeacherId(strTeacherId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}