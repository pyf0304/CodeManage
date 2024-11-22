
/*-- -- -- -- -- -- -- -- -- -- --
类名:SW_PressurePointApiController
表名:SW_PressurePoint(01770001)
生成代码版本:2021.11.05.1
生成日期:2021/11/05 11:51:24
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:智能压力水务管理
工程ID:0177
相关数据库:103.116.76.183,9433SmartWaterMan
PrjDataBaseId:0217
模块中文名:基本信息
模块英文名:BaseInfo
框架-层名:WA_服务层(WA_Srv)
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
using SmartWaterMan.Entity;
using SmartWaterMan.BusinessLogic;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SmartWaterMan.WebApi
{
    /// <summary>
    /// SW_PressurePointController 的摘要说明
    /// (AutoGCLib.WA_Srv4CSharp:GeneCode)
    /// </summary>
    public class SW_PressurePointApiController : Controller
    {

        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// 调用方法: GET /api/SW_PressurePointApi/GetObjByPressurePointId?PressurePointId=value
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
        /// </summary>
        /// <param name = "strPressurePointId">表关键字</param>
        /// <returns>表对象</returns>
        [HttpGet]
        public ActionResult GetObjByPressurePointId(string PressurePointId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["PressurePointId"] = PressurePointId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(PressurePointId) == true)
            {
                string strMsg = string.Format("根据关键字获取对象时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                clsSW_PressurePointEN objSW_PressurePointEN = clsSW_PressurePointBL.GetObjByPressurePointId(PressurePointId);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObj = objSW_PressurePointEN });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// 调用方法: GET /api/SW_PressurePointApi/GetObjByKey_Cache?PressurePointId=value
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId_Cache)
        /// </summary>
        /// <param name = "strPressurePointId">表关键字</param>
        /// <returns>表对象</returns>
        [HttpGet]
        public ActionResult GetObjByPressurePointId_Cache(string PressurePointId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["PressurePointId"] = PressurePointId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(PressurePointId) == true)
            {
                string strMsg = string.Format("根据关键字获取对象时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                clsSW_PressurePointEN objSW_PressurePointEN = clsSW_PressurePointBL.GetObjByPressurePointId_Cache(PressurePointId);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObj = objSW_PressurePointEN });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/SW_PressurePointApi/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet]
        public ActionResult GetObjLst(string strWhereCond)
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
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                List<clsSW_PressurePointEN> arrSW_PressurePointObjLst = clsSW_PressurePointBL.GetObjLst(strWhereCond);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrSW_PressurePointObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/SW_PressurePointApi/GetObjLst_Cache?
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst_Cache)
        /// </summary>
        /// <returns>返回对象列表</returns>
        [HttpGet]
        public ActionResult GetObjLst_Cache()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                List<clsSW_PressurePointEN> arrSW_PressurePointObjLst = clsSW_PressurePointBL.GetObjLst_Cache();
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrSW_PressurePointObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件分页获取JSON对象列表
        /// 调用方法: GET /api/SW_PressurePointApi/GetSubObjLst_Cache?objTabName_Cond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetSubObjLst_Cache)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回JSON对象列表</returns>
        [HttpPost]
        public ActionResult GetSubObjLst_Cache([FromBody] clsSW_PressurePointEN objSW_PressurePoint_Cond)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strSW_PressurePointJSONObj = clsJSON.GetJsonFromObj(objSW_PressurePoint_Cond);
            dictParam.Add("strSW_PressurePointJSONObj", strSW_PressurePointJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            IEnumerable<clsSW_PressurePointEN> arrSW_PressurePointObjLst = null;
            try
            {
                if (objSW_PressurePoint_Cond.sf_FldComparisonOp == null)
                {
                    objSW_PressurePoint_Cond.dicFldComparisonOp = null;
                }
                else
                {
                    objSW_PressurePoint_Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objSW_PressurePoint_Cond.sf_FldComparisonOp);
                }
                clsSW_PressurePointBL.SetUpdFlag(objSW_PressurePoint_Cond);
                arrSW_PressurePointObjLst = clsSW_PressurePointBL.GetSubObjLst_Cache(objSW_PressurePoint_Cond);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrSW_PressurePointObjLst });
        }

        /// <summary>
        /// 根据关键字列表获取相关对象列表
        /// 调用方法: POST /api/SW_PressurePointapi/GetObjLstByPressurePointIdLst
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst)
        /// </summary>
        /// <param name = "arrPressurePointIdLst">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        [HttpPost]
        public ActionResult GetObjLstByPressurePointIdLst([FromBody] string[] arrPressurePointId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            List<string> arrLst = new List<string>(arrPressurePointId);
            dictParam.Add("arrPressurePointId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (arrPressurePointId.Length == 0)
            {
                string strMsg = string.Format("根据关键字列表串获取对象列表时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            List<string> lstPressurePointId = new List<string>(arrPressurePointId);
            try
            {
                List<clsSW_PressurePointEN> arrSW_PressurePointObjLst = clsSW_PressurePointBL.GetObjLstByPressurePointIdLst(lstPressurePointId);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrSW_PressurePointObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据关键字列表获取相关对象列表
        /// 调用方法: POST /api/SW_PressurePointapi/GetObjLstByPressurePointIdLst
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst_Cache)
        /// </summary>
        /// <param name = "arrPressurePointIdLst">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        [HttpPost]
        public ActionResult GetObjLstByPressurePointIdLst_Cache([FromBody] string[] arrPressurePointId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            List<string> arrLst = new List<string>(arrPressurePointId);
            dictParam.Add("arrPressurePointId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (arrPressurePointId.Length == 0)
            {
                string strMsg = string.Format("根据关键字列表串获取对象列表时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            List<string> lstPressurePointId = new List<string>(arrPressurePointId);
            try
            {
                IEnumerable<clsSW_PressurePointEN> arrSW_PressurePointObjLst = clsSW_PressurePointBL.GetObjLstByPressurePointIdLst_Cache(lstPressurePointId);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrSW_PressurePointObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取顶部对象列表
        /// 调用方法: GET /api/SW_PressurePointApi/GetTopObjLst?intTopSize=v1&strOrderBy=v2&strWhereCond=v3&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetTopObjLst)
        /// </summary>
        /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
        /// <returns>返回对象列表</returns>
        [HttpPost]
        public ActionResult GetTopObjLst([FromBody] stuTopPara objTopPara)
        {
            objTopPara.WhereCond = objTopPara.WhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objTopPara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objTopPara.WhereCond) == true)
            {
                string strMsg = string.Format("根据条件获取顶部对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objTopPara.TopSize <= 0)
            {
                string strMsg = string.Format("根据条件获取顶部对象列表，顶部记录数:[{0}]不能小于等于0!({1})", objTopPara.TopSize, clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }
            try
            {
                List<clsSW_PressurePointEN> arrSW_PressurePointObjLst = clsSW_PressurePointBL.GetTopObjLst(objTopPara);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrSW_PressurePointObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// 调用方法: GET /api/SW_PressurePointApi/GetFirstID?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFirstID)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        [HttpGet]
        public ActionResult GetFirstID(string strWhereCond)
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
                string strMsg = string.Format("根据条件获取第一条记录的关键字值时，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            string strPressurePointId;
            try
            {
                strPressurePointId = clsSW_PressurePointBL.GetFirstID_S(strWhereCond);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnStr = strPressurePointId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// 调用方法: GET /api/SW_PressurePointApi/GetFirstObj?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFirstObj)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的对象</returns>
        [HttpGet]
        public ActionResult GetFirstObj(string strWhereCond)
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
                string strMsg = string.Format("根据条件获取第一条对象时，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                clsSW_PressurePointEN objSW_PressurePointEN = clsSW_PressurePointBL.GetFirstObj_S(strWhereCond);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObj = objSW_PressurePointEN });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件分页获取JSON对象列表
        /// 调用方法: GET /api/SW_PressurePointApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回JSON对象列表</returns>
        [HttpPost]
        public ActionResult GetObjLstByPager([FromBody] stuPagerPara objPagerPara)
        {
            objPagerPara.WhereCond = objPagerPara.WhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objPagerPara.WhereCond) == true)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objPagerPara.PageSize <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.PageSize, clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objPagerPara.PageIndex <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，页序号:[{0}]不能小于等于0!({1})", objPagerPara.PageIndex, clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            List<clsSW_PressurePointEN> arrSW_PressurePointObjLst = null;
            try
            {
                arrSW_PressurePointObjLst = clsSW_PressurePointBL.GetObjLstByPager(objPagerPara);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrSW_PressurePointObjLst });
        }

        /// <summary>
        /// 根据条件分页获取JSON对象列表
        /// 调用方法: GET /api/SW_PressurePointApi/GetObjLstByPager_Cache?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager_Cache)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回JSON对象列表</returns>
        [HttpPost]
        public ActionResult GetObjLstByPager_Cache([FromBody] stuPagerPara objPagerPara)
        {
            objPagerPara.WhereCond = objPagerPara.WhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objPagerPara.WhereCond) == true)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objPagerPara.PageSize <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.PageSize, clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objPagerPara.PageIndex <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，页序号:[{0}]不能小于等于0!({1})", objPagerPara.PageIndex, clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            IEnumerable<clsSW_PressurePointEN> arrSW_PressurePointObjLst = null;
            try
            {
                arrSW_PressurePointObjLst = clsSW_PressurePointBL.GetObjLstByPager_Cache(objPagerPara);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrSW_PressurePointObjLst });
        }

        /// <summary>
        /// 根据条件获取范围内的对象列表
        /// 调用方法: GET /api/SW_PressurePointApi/GetObjLstByRange?strOrderBy=v1&intMaxNum=v2&intMinNum=v3&strWhereCond=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByRange)
        /// </summary>
        /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
        /// <returns>返回对象列表</returns>
        [HttpPost]
        public ActionResult GetObjLstByRange([FromBody] stuRangePara objRangePara)
        {
            objRangePara.WhereCond = objRangePara.WhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objRangePara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objRangePara.WhereCond) == true)
            {
                string strMsg = string.Format("根据条件获取范围内的对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objRangePara.MinNum < 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，最小记录号:[{0}]不能小于0!({1})", objRangePara.MinNum, clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objRangePara.MaxNum < 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，最大记录号:[{0}]不能小于0!({1})", objRangePara.MaxNum, clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objRangePara.MaxNum <= objRangePara.MinNum)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，最大记录号:[{0}]不能小于等于最小记录号:[{1}]!({2})", objRangePara.MaxNum, objRangePara.MinNum, clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            List<clsSW_PressurePointEN> arrSW_PressurePointObjLst = null;
            try
            {
                arrSW_PressurePointObjLst = clsSW_PressurePointBL.GetObjLstByRange(objRangePara);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            return Json(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrSW_PressurePointObjLst });
        }

        /// <summary>
        /// 功能:获取某一条件的记录数
        /// 调用方法: GET /api/SW_PressurePointApi/GetRecCountByCond?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetRecCountByCond)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>某一条件的记录数</returns>
        [HttpGet]
        public ActionResult GetRecCountByCond(string strWhereCond)
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
                string strMsg = string.Format("获取某一条件的记录数，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                int intCount = clsSW_PressurePointBL.GetRecCountByCond(strWhereCond);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intCount });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
        /// 调用方法: GET /api/SW_PressurePointApi/GetFldValue?strWhereCond=v1&strFldName=v2&strTabName=v3&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetFldValue)
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strWhereCond">所给定的记录条件</param>
        /// <returns>记录数,为整型</returns>
        [HttpGet]
        public ActionResult GetFldValue(string strFldName, string strWhereCond)
        {
            strWhereCond = strWhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strFldName"] = strFldName,
                ["strWhereCond"] = strWhereCond
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                string strMsg = string.Format("获取某一条件的字段值，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                List<string> arrList = clsSW_PressurePointBL.GetFldValue(strFldName, strWhereCond);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnStrLst = string.Join(",", arrList) });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
        /// 调用方法: GET /api/SW_PressurePointApi/funSetFldValue?strCondition=v1&strFldName=v2&strTabName=v3&varValue=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_funSetFldValue)
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strValue">值</param>
        /// <param name = "strWhereCond">所给定的记录条件</param>
        /// <returns>记录数,为整型</returns>
        [HttpGet]
        public ActionResult SetFldValue(string strFldName, string strValue, string strWhereCond)
        {
            strWhereCond = strWhereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strFldName"] = strFldName,
                ["strValue"] = strValue,
                ["strWhereCond"] = strWhereCond
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                string strMsg = string.Format("获取某一条件的字段值，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                int intRecCount = clsSW_PressurePointBL.SetFldValue(clsSW_PressurePointEN._CurrTabName_S, strFldName, strValue, strWhereCond);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecCount });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:判断是否存在某一条件的记录
        /// 调用方法: GET /api/SW_PressurePointApi/IsExistRecord?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExistRecordByCond)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>包含结果的Jobject, 如果存在就返回TRUE,否则返回FALSE</returns>
        [HttpGet]
        public ActionResult IsExistRecord(string strWhereCond)
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
                string strMsg = string.Format("判断是否存在某一条件的记录，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                bool bolIsExist = clsSW_PressurePointBL.IsExistRecord(strWhereCond);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolIsExist });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// 调用方法: GET /api/SW_PressurePointApi/IsExist?PressurePointId=value
        /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExist)
        /// </summary>
        /// <param name = "strPressurePointId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet]
        public ActionResult IsExist(string PressurePointId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["PressurePointId"] = PressurePointId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(PressurePointId) == true)
            {
                string strMsg = string.Format("判断表中是否存在给定关键字的记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                bool bolIsExist = clsSW_PressurePointBL.IsExist(PressurePointId);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolIsExist });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前表关键字值的最大值,再加1,避免重复
        /// 调用方法: GET /api/SW_PressurePointApi/GetMaxStrId?
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetMaxStrId)
        /// </summary>
        /// <returns>当前表关键字值的最大值,再加1</returns>
        [HttpGet]
        public ActionResult GetMaxStrId()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strMaxstrPressurePointId = clsSW_PressurePointBL.GetMaxStrId_S();
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnStr = strMaxstrPressurePointId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/SW_PressurePointApi/AddNewRecord
        /// 在Body区传输objSW_PressurePointEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objSW_PressurePointEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost]
        public ActionResult AddNewRecord([FromBody] clsSW_PressurePointEN objSW_PressurePointEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strSW_PressurePointJSONObj = clsJSON.GetJsonFromObj(objSW_PressurePointEN);
            dictParam.Add("strSW_PressurePointJSONObj", strSW_PressurePointJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                clsSW_PressurePointEN objSW_PressurePoint_Cond = new clsSW_PressurePointEN();
                string strCondition = objSW_PressurePoint_Cond
                .SetPressurePointName(objSW_PressurePointEN.PressurePointName, "=")
                .GetCombineCondition();
                bool bolIsExist = clsSW_PressurePointBL.IsExistRecord(strCondition);
                if (bolIsExist)
                {
                    string strMsg = string.Format("满足条件:{0}的记录表中已经存在，违反了唯一性.(from {1})", strCondition, clsStackTrace.GetCurrClassFunction());
                    clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                    return Json(new { ErrorId = 1, ErrorMsg = strMsg });
                }
                if (string.IsNullOrEmpty(objSW_PressurePointEN.PressurePointId) == true || clsSW_PressurePointBL.IsExist(objSW_PressurePointEN.PressurePointId) == true)
                {
                    objSW_PressurePointEN.PressurePointId = clsSW_PressurePointBL.GetMaxStrId_S();
                }
                bool bolResult = objSW_PressurePointEN.AddNewRecord();
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/SW_PressurePointApi/AddNewRecordWithMaxId
        /// 在Body区传输objSW_PressurePointEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithMaxId)
        /// </summary>
        /// <param name = "objSW_PressurePointEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost]
        public ActionResult AddNewRecordWithMaxId([FromBody] clsSW_PressurePointEN objSW_PressurePointEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strSW_PressurePointJSONObj = clsJSON.GetJsonFromObj(objSW_PressurePointEN);
            dictParam.Add("strSW_PressurePointJSONObj", strSW_PressurePointJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strPressurePointId = objSW_PressurePointEN.AddNewRecordWithMaxId();
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnStr = strPressurePointId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// 调用方法: POST /api/SW_PressurePointApi/AddNewRecord
        /// 在Body区传输objSW_PressurePointEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objSW_PressurePointEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        [HttpPost]
        public ActionResult AddNewRecordWithReturnKey(clsSW_PressurePointEN objSW_PressurePointEN)
        {
            if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
            {
                clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
            }
            else
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                dictParam.Add("objSW_PressurePointEN", clsSW_PressurePointBL.SerializeObjToXMLStr(objSW_PressurePointEN));
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            }
            try
            {
                string strKey = clsSW_PressurePointBL.AddNewRecordBySql2WithReturnKey(objSW_PressurePointEN);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnStr = strKey });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 通过JSON对象来修改记录对象
        /// 调用方法: Post /api/SW_PressurePointApi/UpdateRecord
        /// 在Body区传输objSW_PressurePointEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
        /// </summary>
        /// <param name = "strSW_PressurePointJSONObj">JSON对象字符串</param>
        /// <returns>是否成功</returns>
        [HttpPost]
        public ActionResult UpdateRecord([FromBody] clsSW_PressurePointEN objSW_PressurePointEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strSW_PressurePointJSONObj = clsJSON.GetJsonFromObj(objSW_PressurePointEN);
            dictParam.Add("strSW_PressurePointJSONObj", strSW_PressurePointJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objSW_PressurePointEN.PressurePointId) == true)
            {
                string strMsg = string.Format("修改记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                clsSW_PressurePointBL.SetUpdFlag(objSW_PressurePointEN);
                bool bolResult = objSW_PressurePointEN.Update();
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件来修改记录对象
        /// 调用方法: Post /api/SW_PressurePointApi/UpdateWithCondition
        /// 在Body区传输objSW_PressurePointEN的JSON对象和strWhereCond条件串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateWithCondition)
        /// </summary>
        /// <param name = "strSW_PressurePointJSONObj">JSON对象字符串</param>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>是否成功</returns>
        [HttpPost]
        public ActionResult UpdateWithCondition(clsSW_PressurePointEN objSW_PressurePointEN, string strWhereCond)
        {
            strWhereCond = strWhereCond.Replace("'% ", "'%");
            if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
            {
                clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
            }
            else
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>()
                {
                    ["strWhereCond"] = strWhereCond
                };
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            }
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                string strMsg = string.Format("根据条件修改记录时，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                bool bolResult = objSW_PressurePointEN.UpdateWithCondition(strWhereCond);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:删除关键字所指定的记录
        /// 调用方法: DELETE /api/SW_PressurePointApi/DelRecord/Id
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
        /// </summary>
        /// <param name = "Id">给定的关键字值</param>
        /// <returns>返回删除的记录数</returns>
        [HttpDelete]
        public ActionResult DelRecord(string Id)
        {
            string strPressurePointId = Id;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPressurePointId"] = strPressurePointId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strPressurePointId) == true)
            {
                string strMsg = string.Format("删除关键字所指定的记录，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                int intRecNum = clsSW_PressurePointBL.DelRecord(strPressurePointId);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录
        /// 调用方法: POST /api/SW_PressurePointApi/DelSW_PressurePoints
        /// 在Body区传输arrPressurePointId(关键字值列表)的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
        /// </summary>
        /// <param name = "arrPressurePointId">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost]
        public ActionResult DelSW_PressurePoints([FromBody] string[] arrPressurePointId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            List<string> arrLst = new List<string>(arrPressurePointId);
            dictParam.Add("arrPressurePointId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = clsSW_PressurePointBL.DelSW_PressurePoints(arrLst);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录, 通过JSON串
        /// 调用方法: POST /api/SW_PressurePointApi/DelRecords
        /// 在Body区传输strKeyIdLst字符串列表的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecords)
        /// </summary>
        /// <param name = "strKeyIdLst">给定的关键字值列表的JSON串</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost]
        public ActionResult DelRecords([FromBody] string strKeyIdLst)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strKeyIdLst", strKeyIdLst);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strKeyIdLst) == true)
            {
                string strMsg = string.Format("根据关键字列表串删除记录时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            string[] sstrPressurePointId = strKeyIdLst.Trim().Split(',');
            List<string> arrPressurePointId = new List<string>();
            foreach (string strPressurePointId in sstrPressurePointId)
            {
                if (string.IsNullOrEmpty(strPressurePointId) == false)
                {
                    arrPressurePointId.Add(strPressurePointId);
                }
            }
            try
            {
                int intRecNum = clsSW_PressurePointBL.DelSW_PressurePoints(arrPressurePointId);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:删除满足条件的多条记录
        /// 调用方法: POST /api/SW_PressurePointApi/DelSW_PressurePointsByCond
        /// 在Body区传输{"strWhereCond":"1=1"}
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecordByCond)
        /// </summary>
        /// <param name = "strWhereCond">需要删除的记录条件</param>
        /// <returns>返回删除的记录数。</returns>
        [HttpPost]
        public ActionResult DelSW_PressurePointsByCond([FromBody] string strWhereCond)
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
                string strMsg = string.Format("删除满足条件的多条记录，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                int intRecNum = clsSW_PressurePointBL.DelSW_PressurePointsByCond(strWhereCond);
                return Json(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Json(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }
    }
}