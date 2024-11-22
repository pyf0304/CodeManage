
/*-- -- -- -- -- -- -- -- -- -- --
类名:DataNodeApiController
表名:DataNode(00050547)
生成代码版本:2021.11.05.1
生成日期:2021/11/05 12:00:51
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:AGC
工程ID:0005
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:AI模块
模块英文名:AIModule
框架-层名:WA_服务层(WA_Srv)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.json;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;


namespace AGC.WebApi
{
    //[Route("DataNodeApi")]//
    /// <summary>
    /// DataNodeController 的摘要说明
    /// (AutoGCLib.WA_Srv4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class DataNodeApi2Controller : ControllerBase
    {

        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// 调用方法: GET /api/DataNodeApi/GetObjByDataNodeId?DataNodeId=value
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId)
        /// </summary>
        /// <param name = "strDataNodeId">表关键字</param>
        /// <returns>表对象</returns>
        [HttpGet("GetObjByDataNodeId/{DataNodeId}")]
        public ActionResult GetObjByDataNodeId(string DataNodeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["DataNodeId"] = DataNodeId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(DataNodeId) == true)
            {
                string strMsg = string.Format("根据关键字获取对象时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId(DataNodeId);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObj = objDataNodeEN });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// 调用方法: GET /api/DataNodeApi/GetObjByKey_Cache?DataNodeId=value
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjByKeyId_Cache)
        /// </summary>
        /// <param name = "strDataNodeId">表关键字</param>
        /// <returns>表对象</returns>
        [HttpGet("GetObjByDataNodeId_Cache/{DataNodeId},{CMPrjId}")]
        public ActionResult GetObjByDataNodeId_Cache(string DataNodeId, string CMPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["DataNodeId"] = DataNodeId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(DataNodeId) == true)
            {
                string strMsg = string.Format("根据关键字获取对象时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId_Cache(DataNodeId, CMPrjId);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObj = objDataNodeEN });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/DataNodeApi/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetObjLst")]
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                List<clsDataNodeEN> arrDataNodeObjLst = clsDataNodeBL.GetObjLst(strWhereCond);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrDataNodeObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/DataNodeApi/GetObjLst_Cache?
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst_Cache)
        /// </summary>
        /// <returns>返回对象列表</returns>
        [HttpGet]
        public ActionResult GetObjLst_Cache(string strCMPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                List<clsDataNodeEN> arrDataNodeObjLst = clsDataNodeBL.GetObjLst_Cache(strCMPrjId);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrDataNodeObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件分页获取JSON对象列表
        /// 调用方法: GET /api/DataNodeApi/GetSubObjLst_Cache?objTabName_Cond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetSubObjLst_Cache)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回JSON对象列表</returns>
        [HttpPost]
        public ActionResult GetSubObjLst_Cache([FromBody] clsDataNodeEN objDataNode_Cond)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strDataNodeJSONObj = clsJSON.GetJsonFromObj(objDataNode_Cond);
            dictParam.Add("strDataNodeJSONObj", strDataNodeJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            IEnumerable<clsDataNodeEN> arrDataNodeObjLst = null;
            try
            {
                if (objDataNode_Cond.sf_FldComparisonOp == null)
                {
                    objDataNode_Cond.dicFldComparisonOp = null;
                }
                else
                {
                    //objDataNode_Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objDataNode_Cond.sf_FldComparisonOp);
                }
                clsDataNodeBL.SetUpdFlag(objDataNode_Cond);
                arrDataNodeObjLst = clsDataNodeBL.GetSubObjLst_Cache(objDataNode_Cond);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrDataNodeObjLst });
        }

        /// <summary>
        /// 根据关键字列表获取相关对象列表
        /// 调用方法: POST /api/DataNodeapi/GetObjLstByDataNodeIdLst
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst)
        /// </summary>
        /// <param name = "arrDataNodeIdLst">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        [HttpPost]
        public ActionResult GetObjLstByDataNodeIdLst([FromBody] string[] arrDataNodeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            List<string> arrLst = new List<string>(arrDataNodeId);
            dictParam.Add("arrDataNodeId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (arrDataNodeId.Length == 0)
            {
                string strMsg = string.Format("根据关键字列表串获取对象列表时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            List<string> lstDataNodeId = new List<string>(arrDataNodeId);
            try
            {
                List<clsDataNodeEN> arrDataNodeObjLst = clsDataNodeBL.GetObjLstByDataNodeIdLst(lstDataNodeId);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrDataNodeObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据关键字列表获取相关对象列表
        /// 调用方法: POST /api/DataNodeapi/GetObjLstByDataNodeIdLst
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByKeyLst_Cache)
        /// </summary>
        /// <param name = "arrDataNodeIdLst">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        [HttpPost]
        public ActionResult GetObjLstByDataNodeIdLst_Cache([FromBody] string[] arrDataNodeId, string CMPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            List<string> arrLst = new List<string>(arrDataNodeId);
            dictParam.Add("arrDataNodeId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (arrDataNodeId.Length == 0)
            {
                string strMsg = string.Format("根据关键字列表串获取对象列表时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            List<string> lstDataNodeId = new List<string>(arrDataNodeId);
            try
            {
                IEnumerable<clsDataNodeEN> arrDataNodeObjLst = clsDataNodeBL.GetObjLstByDataNodeIdLst_Cache(lstDataNodeId, CMPrjId);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrDataNodeObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取顶部对象列表
        /// 调用方法: GET /api/DataNodeApi/GetTopObjLst?intTopSize=v1&strOrderBy=v2&strWhereCond=v3&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetTopObjLst)
        /// </summary>
        /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
        /// <returns>返回对象列表</returns>
        [HttpPost]
        public ActionResult GetTopObjLst([FromBody] stuTopPara objTopPara)
        {
            objTopPara.whereCond = objTopPara.whereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objTopPara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objTopPara.whereCond) == true)
            {
                string strMsg = string.Format("根据条件获取顶部对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objTopPara.TopSize <= 0)
            {
                string strMsg = string.Format("根据条件获取顶部对象列表，顶部记录数:[{0}]不能小于等于0!({1})", objTopPara.TopSize, clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }
            try
            {
                List<clsDataNodeEN> arrDataNodeObjLst = clsDataNodeBL.GetTopObjLst(objTopPara);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrDataNodeObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// 调用方法: GET /api/DataNodeApi/GetFirstID?strWhereCond=v1&
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            string strDataNodeId;
            try
            {
                strDataNodeId = clsDataNodeBL.GetFirstID_S(strWhereCond);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnStr = strDataNodeId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// 调用方法: GET /api/DataNodeApi/GetFirstObj?strWhereCond=v1&
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetFirstObj_S(strWhereCond);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObj = objDataNodeEN });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件分页获取JSON对象列表
        /// 调用方法: GET /api/DataNodeApi/GetObjLstByPager?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回JSON对象列表</returns>
        [HttpPost]
        public ActionResult GetObjLstByPager([FromBody] stuPagerPara objPagerPara)
        {
            objPagerPara.whereCond = objPagerPara.whereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objPagerPara.whereCond) == true)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objPagerPara.pageSize <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objPagerPara.pageIndex <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，页序号:[{0}]不能小于等于0!({1})", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            List<clsDataNodeEN> arrDataNodeObjLst = null;
            try
            {
                arrDataNodeObjLst = clsDataNodeBL.GetObjLstByPager(objPagerPara);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrDataNodeObjLst });
        }

        /// <summary>
        /// 根据条件分页获取JSON对象列表
        /// 调用方法: GET /api/DataNodeApi/GetObjLstByPager_Cache?intPageIndex=v1&intPageSize=v2&strOrderBy=v3&strWhereCond=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByPager_Cache)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回JSON对象列表</returns>
        [HttpPost]
        public ActionResult GetObjLstByPager_Cache([FromBody] stuPagerPara objPagerPara)
        {
            objPagerPara.whereCond = objPagerPara.whereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objPagerPara.whereCond) == true)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objPagerPara.pageSize <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objPagerPara.pageIndex <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，页序号:[{0}]不能小于等于0!({1})", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            IEnumerable<clsDataNodeEN> arrDataNodeObjLst = null;
            try
            {
                arrDataNodeObjLst = clsDataNodeBL.GetObjLstByPager_Cache(objPagerPara);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrDataNodeObjLst });
        }

        /// <summary>
        /// 根据条件获取范围内的对象列表
        /// 调用方法: GET /api/DataNodeApi/GetObjLstByRange?strOrderBy=v1&intMaxNum=v2&intMinNum=v3&strWhereCond=v4&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLstByRange)
        /// </summary>
        /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
        /// <returns>返回对象列表</returns>
        [HttpPost]
        public ActionResult GetObjLstByRange([FromBody] stuRangePara objRangePara)
        {
            objRangePara.whereCond = objRangePara.whereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objRangePara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objRangePara.whereCond) == true)
            {
                string strMsg = string.Format("根据条件获取范围内的对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objRangePara.minNum < 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，最小记录号:[{0}]不能小于0!({1})", objRangePara.minNum, clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objRangePara.maxNum < 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，最大记录号:[{0}]不能小于0!({1})", objRangePara.maxNum, clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            if (objRangePara.maxNum <= objRangePara.minNum)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，最大记录号:[{0}]不能小于等于最小记录号:[{1}]!({2})", objRangePara.maxNum, objRangePara.minNum, clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            List<clsDataNodeEN> arrDataNodeObjLst = null;
            try
            {
                arrDataNodeObjLst = clsDataNodeBL.GetObjLstByRange(objRangePara);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnObjLst = arrDataNodeObjLst });
        }

        /// <summary>
        /// 功能:获取某一条件的记录数
        /// 调用方法: GET /api/DataNodeApi/GetRecCountByCond?strWhereCond=v1&
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                int intCount = clsDataNodeBL.GetRecCountByCond(strWhereCond);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intCount });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
        /// 调用方法: GET /api/DataNodeApi/GetFldValue?strWhereCond=v1&strFldName=v2&strTabName=v3&
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                List<string> arrList = clsDataNodeBL.GetFldValue(strFldName, strWhereCond);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnStrLst = string.Join(",", arrList) });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
        /// 调用方法: GET /api/DataNodeApi/funSetFldValue?strCondition=v1&strFldName=v2&strTabName=v3&varValue=v4&
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                int intRecCount = clsDataNodeBL.SetFldValue(clsDataNodeEN._CurrTabName_S, strFldName, strValue, strWhereCond);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecCount });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:判断是否存在某一条件的记录
        /// 调用方法: GET /api/DataNodeApi/IsExistRecord?strWhereCond=v1&
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                bool bolIsExist = clsDataNodeBL.IsExistRecord(strWhereCond);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolIsExist });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }
        [HttpGet("Plus1/{a},{b}")]
        public ActionResult<int> Plus(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// 调用方法: GET /api/DataNodeApi/IsExist?DataNodeId=value
        /// (AutoGCLib.WA_Srv4CSharp:Gen_IsExist)
        /// </summary>
        /// <param name = "strDataNodeId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("IsExist/{DataNodeId}")]
        public ActionResult IsExist(string DataNodeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["DataNodeId"] = DataNodeId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(DataNodeId) == true)
            {
                string strMsg = string.Format("判断表中是否存在给定关键字的记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                bool bolIsExist = clsDataNodeBL.IsExist(DataNodeId);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolIsExist });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 获取当前表关键字值的最大值,再加1,避免重复
        /// 调用方法: GET /api/DataNodeApi/GetMaxStrId?
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
                string strMaxstrDataNodeId = clsDataNodeBL.GetMaxStrId_S();
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnStr = strMaxstrDataNodeId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/DataNodeApi/AddNewRecord
        /// 在Body区传输objDataNodeEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objDataNodeEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost]
        public ActionResult AddNewRecord([FromBody] clsDataNodeEN objDataNodeEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strDataNodeJSONObj = clsJSON.GetJsonFromObj(objDataNodeEN);
            dictParam.Add("strDataNodeJSONObj", strDataNodeJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                clsDataNodeEN objDataNode_Cond = new clsDataNodeEN();
                string strCondition = objDataNode_Cond
                .SetTabId(objDataNodeEN.TabId, "=")
                .SetFldId(objDataNodeEN.FldId, "=")
                .SetVersionNo(objDataNodeEN.VersionNo, "=")
                .SetCMPrjId(objDataNodeEN.CMPrjId, "=")
                .GetCombineCondition();
                bool bolIsExist = clsDataNodeBL.IsExistRecord(strCondition);
                if (bolIsExist)
                {
                    string strMsg = string.Format("满足条件:{0}的记录表中已经存在，违反了唯一性.(from {1})", strCondition, clsStackTrace.GetCurrClassFunction());
                    clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                    return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
                }
                if (string.IsNullOrEmpty(objDataNodeEN.DataNodeId) == true || clsDataNodeBL.IsExist(objDataNodeEN.DataNodeId) == true)
                {
                    objDataNodeEN.DataNodeId = clsDataNodeBL.GetMaxStrId_S();
                }
                bool bolResult = objDataNodeEN.AddNewRecord();
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/DataNodeApi/AddNewRecordWithMaxId
        /// 在Body区传输objDataNodeEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithMaxId)
        /// </summary>
        /// <param name = "objDataNodeEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost]
        public ActionResult AddNewRecordWithMaxId([FromBody] clsDataNodeEN objDataNodeEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strDataNodeJSONObj = clsJSON.GetJsonFromObj(objDataNodeEN);
            dictParam.Add("strDataNodeJSONObj", strDataNodeJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                string strDataNodeId = objDataNodeEN.AddNewRecordWithMaxId();
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnStr = strDataNodeId });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// 调用方法: POST /api/DataNodeApi/AddNewRecord
        /// 在Body区传输objDataNodeEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objDataNodeEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        [HttpPost]
        public ActionResult AddNewRecordWithReturnKey(clsDataNodeEN objDataNodeEN)
        {
            if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
            {
                clsPubVar_WebApi.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
            }
            else
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                dictParam.Add("objDataNodeEN", clsDataNodeBL.SerializeObjToXMLStr(objDataNodeEN));
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            }
            try
            {
                string strKey = clsDataNodeBL.AddNewRecordBySql2WithReturnKey(objDataNodeEN);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnStr = strKey });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 通过JSON对象来修改记录对象
        /// 调用方法: Post /api/DataNodeApi/UpdateRecord
        /// 在Body区传输objDataNodeEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
        /// </summary>
        /// <param name = "strDataNodeJSONObj">JSON对象字符串</param>
        /// <returns>是否成功</returns>
        [HttpPost]
        public ActionResult UpdateRecord([FromBody] clsDataNodeEN objDataNodeEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strDataNodeJSONObj = clsJSON.GetJsonFromObj(objDataNodeEN);
            dictParam.Add("strDataNodeJSONObj", strDataNodeJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objDataNodeEN.DataNodeId) == true)
            {
                string strMsg = string.Format("修改记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                clsDataNodeBL.SetUpdFlag(objDataNodeEN);
                bool bolResult = objDataNodeEN.Update();
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件来修改记录对象
        /// 调用方法: Post /api/DataNodeApi/UpdateWithCondition
        /// 在Body区传输objDataNodeEN的JSON对象和strWhereCond条件串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateWithCondition)
        /// </summary>
        /// <param name = "strDataNodeJSONObj">JSON对象字符串</param>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>是否成功</returns>
        [HttpPost]
        public ActionResult UpdateWithCondition(clsDataNodeEN objDataNodeEN, string strWhereCond)
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                bool bolResult = objDataNodeEN.UpdateWithCondition(strWhereCond);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:删除关键字所指定的记录
        /// 调用方法: DELETE /api/DataNodeApi/DelRecord/Id
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
        /// </summary>
        /// <param name = "Id">给定的关键字值</param>
        /// <returns>返回删除的记录数</returns>
        [HttpDelete]
        public ActionResult DelRecord(string Id)
        {
            string strDataNodeId = Id;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strDataNodeId"] = strDataNodeId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strDataNodeId) == true)
            {
                string strMsg = string.Format("删除关键字所指定的记录，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                int intRecNum = clsDataNodeBL.DelRecord(strDataNodeId);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录
        /// 调用方法: POST /api/DataNodeApi/DelDataNodes
        /// 在Body区传输arrDataNodeId(关键字值列表)的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
        /// </summary>
        /// <param name = "arrDataNodeId">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost]
        public ActionResult DelDataNodes([FromBody] string[] arrDataNodeId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            List<string> arrLst = new List<string>(arrDataNodeId);
            dictParam.Add("arrDataNodeId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = clsDataNodeBL.DelDataNodes(arrLst);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录, 通过JSON串
        /// 调用方法: POST /api/DataNodeApi/DelRecords
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            string[] sstrDataNodeId = strKeyIdLst.Trim().Split(',');
            List<string> arrDataNodeId = new List<string>();
            foreach (string strDataNodeId in sstrDataNodeId)
            {
                if (string.IsNullOrEmpty(strDataNodeId) == false)
                {
                    arrDataNodeId.Add(strDataNodeId);
                }
            }
            try
            {
                int intRecNum = clsDataNodeBL.DelDataNodes(arrDataNodeId);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:删除满足条件的多条记录
        /// 调用方法: POST /api/DataNodeApi/DelDataNodesByCond
        /// 在Body区传输{"strWhereCond":"1=1"}
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecordByCond)
        /// </summary>
        /// <param name = "strWhereCond">需要删除的记录条件</param>
        /// <returns>返回删除的记录数。</returns>
        [HttpPost]
        public ActionResult DelDataNodesByCond([FromBody] string strWhereCond)
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
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
            try
            {
                int intRecNum = clsDataNodeBL.DelDataNodesByCond(strWhereCond);
                return Ok(new { ErrorId = 0, ErrorMsg = "", ReturnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { ErrorId = 1, ErrorMsg = strMsg });
            }
        }
    }
}