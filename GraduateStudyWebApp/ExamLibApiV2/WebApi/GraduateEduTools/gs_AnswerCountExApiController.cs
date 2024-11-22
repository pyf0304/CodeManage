using com.taishsoft.common;
using com.taishsoft.json;
using ExamLib.BusinessLogicEx;
using ExamLib.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class gs_AnswerCountExApiController : ControllerBase
    {


        //获取各个表的数据统计同步到总表 ；（参数，教学班，编辑人；）
        [HttpGet("GetAnswerCountByTable")]
        public ActionResult GetAnswerCountByTable(string strIdCurrEduCls, string UpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("UpdUser", UpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {
                #region 获取教学班数据
                //1.获取评分教学班数据
                bool i = clsgs_AnswerCountBLEx.GetAnswerCountByTable(strIdCurrEduCls, UpdUser);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("同步返回成功");
                    dictParam.Add("GetTotalStatisticsByTable", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetTotalStatisticsByTable", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("同步返回失败");
                    dictParam.Add("GetTotalStatisticsByTable", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetTotalStatisticsByTable", dictParam);
                }

                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);


            }
        
            return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

        }

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/gs_AnswerCountApi/AddNewRecordWithMaxId
        /// 在Body区传输objgs_AnswerCountEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithMaxId)
        /// </summary>
        /// <param name = "objgs_AnswerCountEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecordWithMaxId")]
        public ActionResult AddNewRecordWithMaxId([FromBody]clsgs_AnswerCountEN objgs_AnswerCountEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strgs_AnswerCountJSONObj = clsJSON.GetJsonFromObj(objgs_AnswerCountEN);
            dictParam.Add("strgs_AnswerCountJSONObj", strgs_AnswerCountJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strAnswerCountId = objgs_AnswerCountEN.AddNewRecordWithMaxId();
                
                return Ok(new { errorId = 0, errorMsg = "", returnStr = strAnswerCountId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }





        /// <summary>
        /// 获取回答讨论统计用户数量
        /// 调用方法: GET /api/gs_AnswerCountExApi/GetAnswerCountNumObjLst?strWhereCond=1=1
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetAnswerCountNumObjLst")]
        public ActionResult GetAnswerCountNumObjLst(string strWhereCond)
        {
            strWhereCond = strWhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strWhereCond"] = strWhereCond
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                List<clsgs_AnswerCountEN> arrgs_AnswerCountObjLst = clsgs_AnswerCountBLEx.GetAnswerCountNumObjLst(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrgs_AnswerCountObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        /// <summary>
        /// 获取回答讨论统计周数量
        /// 调用方法: GET /api/gs_AnswerCountExApi/GetAnswerCountNumObjLst?strWhereCond=1=1
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetWeekAnswerCountNumObjLst")]
        public ActionResult GetWeekAnswerCountNumObjLst(string strWhereCond)
        {
            strWhereCond = strWhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strWhereCond"] = strWhereCond
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                string strMsg = string.Format("根据条件获取对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                List<clsgs_AnswerCountEN> arrgs_AnswerCountObjLst = clsgs_AnswerCountBLEx.GetWeekAnswerCountNumObjLst(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrgs_AnswerCountObjLst });
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