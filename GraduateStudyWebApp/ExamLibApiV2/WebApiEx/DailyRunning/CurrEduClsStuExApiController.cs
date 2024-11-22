
/*-- -- -- -- -- -- -- -- -- -- --
类名:CurrEduClsStuExApiController
表名:CurrEduClsStu(01120125)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 14:46:49
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
    /// CurrEduClsStuExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class CurrEduClsStuExApiController : CurrEduClsStuApiController
    {



        /// <summary>
        /// 根据学生Id获取教学班流水号列表
        /// 调用方法: Get /api/clsCurrEduClsStuBLExApi/GetidCurrEduClsListByStuId?strStuId=value
        /// (ExamLib.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strStuId">学号</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetidCurrEduClsListByStuId")]
        public ActionResult GetidCurrEduClsListByStuId(string strStuId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strStuId", strStuId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsCurrEduClsStuBLEx.GetidCurrEduClsListByStuId(strStuId);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 根据教学班流水号获取学生Id列表
        /// 调用方法: Get /api/clsCurrEduClsStuBLExApi/GetStuIDLstByIdCurrEduCls?strIdCurrEduCls=value
        /// (ExamLib.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetStuIDLstByIdCurrEduCls")]
        public ActionResult GetStuIDLstByIdCurrEduCls(string strIdCurrEduCls)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsCurrEduClsStuBLEx.GetStuIDLstByIdCurrEduCls(strIdCurrEduCls);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = varResult });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 添加学生Id到教学班
        /// 调用方法: Get /api/clsCurrEduClsStuBLExApi/AddId_Stu4EduCls?strIdStu=value&strId_CurrEduCls=value&strOperator=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdStu">学生流水号</param>
        /// <param name = "strId_CurrEduCls">教学班流水号</param>
        /// <param name = "strOperator">操作者</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AddId_Stu4EduCls")]
        public ActionResult AddId_Stu4EduCls(string strIdStu, string strId_CurrEduCls, string strOperator)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strIdStu", strIdStu);
            dictParam.Add("strId_CurrEduCls", strId_CurrEduCls);
            dictParam.Add("strOperator", strOperator);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsCurrEduClsStuBLEx.AddId_Stu4EduCls(strIdStu, strId_CurrEduCls, strOperator);
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