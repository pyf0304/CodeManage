using com.taishsoft.common;
using ExamLib.BusinessLogic;
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
    public class gs_TotalDataStatisticsExApiController : ControllerBase
    {

        //获取各个表的数据统计同步到总表 ；（参数，教学班，编辑人；）
        [HttpGet("GetTotalStatisticsByTable")]
        public ActionResult GetTotalStatisticsByTable(string strIdCurrEduCls,string UpdUser)
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
                bool i = clsgs_TotalDataStatisticsBLEx.GetTotalStatisticsByTable(strIdCurrEduCls, UpdUser);
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


        [HttpGet("AddTotalStatisticsByTypeData")]
        public ActionResult AddTotalStatisticsByTypeData(string strCurrEduclsId, string TotalDataTypeId, string TableKey, string DataUser, string DataAddDate, float fScore, float fTeaScore)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strCurrEduclsId", strCurrEduclsId);
            dictParam.Add("TotalDataTypeId", TotalDataTypeId);
            dictParam.Add("TableKey", TableKey);
            dictParam.Add("DataUser", DataUser);
            dictParam.Add("DataAddDate", DataAddDate);
            dictParam.Add("fScore", fScore.ToString());
            dictParam.Add("fTeaScore", fTeaScore.ToString());
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {
                #region 获取教学班数据
                //1.获取评分教学班数据
                bool i = clsgs_TotalDataStatisticsBLEx.AddTotalStatisticsByTypeData(strCurrEduclsId, TotalDataTypeId, TableKey, DataUser, DataAddDate, fScore, fTeaScore);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("操作成功");
                    dictParam.Add("AddTotalStatisticsByTypeData", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "AddTotalStatisticsByTypeData", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("操作失败");
                    dictParam.Add("AddTotalStatisticsByTypeData", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "AddTotalStatisticsByTypeData", dictParam);
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

        //通过3个参数 来处理10个类型数据 添加 修改 删除；
        [HttpGet("AddAndUpdateAndDeleteTotalStatis")]
        public ActionResult AddAndUpdateAndDeleteTotalStatis(string strTablekey, string strTotalDataTypeId, string PageTypeId, string IdCurrEduCls)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTotalDataTypeId", strTotalDataTypeId);
            dictParam.Add("strTablekey", strTablekey);
            dictParam.Add("PageTypeId", PageTypeId);
            dictParam.Add("IdCurrEduCls", IdCurrEduCls);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {
                #region 处理总数据 添加修改删除；
                //通过3个参数 来处理10个类型数据 添加 修改 删除；
                bool i = clsgs_TotalDataStatisticsBLEx.AddAndUpdateAndDeleteTotalStatis(strTablekey,strTotalDataTypeId,PageTypeId, IdCurrEduCls);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("操作成功");
                    dictParam.Add("AddAndUpdateAndDeleteTotalStatis", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "AddAndUpdateAndDeleteTotalStatis", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("操作失败");
                    dictParam.Add("AddAndUpdateAndDeleteTotalStatis", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "AddAndUpdateAndDeleteTotalStatis", dictParam);
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




        #region 获取数据总类型 详细数据；
        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/gs_TotalDataStatisticsApi/GetObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetObjLstEx")]
        public ActionResult GetObjLstEx(string strWhereCond)
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
                List<clsgs_TotalDataStatisticsEN> arrgs_TotalDataStatisticsObjLst = clsgs_TotalDataStatisticsNewBLEx.GetObjLstEx(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrgs_TotalDataStatisticsObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        //获取数据总类型 详细数据；
        [HttpPost("GetObjLstByPagerEx")]
        public ActionResult GetObjLstByPagerEx([FromBody]stuPagerPara objPagerPara)
        {
            objPagerPara.whereCond = objPagerPara.whereCond.Replace("'% ", "'%");
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objPagerPara.whereCond) == true)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，条件不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (objPagerPara.pageSize <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，每页记录数:[{0}]不能小于等于0!({1})", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            if (objPagerPara.pageIndex <= 0)
            {
                string strMsg = string.Format("根据条件分页获取JSON对象列表，页序号:[{0}]不能小于等于0!({1})", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            List<clsgs_TotalDataStatisticsEN> arrgs_TotalDataStatisticsObjLst = null;
            try
            {
                arrgs_TotalDataStatisticsObjLst = clsgs_TotalDataStatisticsNewBLEx.GetObjLstByPagerEx(objPagerPara);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrgs_TotalDataStatisticsObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        
        }
        #endregion

    }
}