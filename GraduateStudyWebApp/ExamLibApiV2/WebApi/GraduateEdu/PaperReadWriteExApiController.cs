
/*-- -- -- -- -- -- -- -- -- -- --
类名:PaperReadWriteExApiController
表名:PaperReadWrite(01120547)
生成代码版本:2019.12.06.1
生成日期:2019/12/26 10:23:36
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
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
using ExamLib.BusinessLogicEx;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    /// <summary>
    /// PaperReadWriteExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PaperReadWriteExApiController : ControllerBase
    {

        
        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/PaperReadWriteApi/AddNewRecord
        /// 在Body区传输objPaperReadWriteEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objPaperReadWriteEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecordEx")]
        public ActionResult AddNewRecordEx([FromBody]clsPaperReadWriteEN objPaperReadWriteEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strPaperReadWriteJSONObj = clsJSON.GetJsonFromObj(objPaperReadWriteEN);
            dictParam.Add("strPaperReadWriteJSONObj", strPaperReadWriteJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            //判断用户名和论文名是否存在，同时判断类型；
            string strwhere = "UpdUser='" + objPaperReadWriteEN.UpdUser + "' And PaperId = '" + objPaperReadWriteEN.PaperId + "' And OperationTypeId = '"+objPaperReadWriteEN.OperationTypeId+"'";
            //clsPaperEN objPaper = clsPaperBL.GetFirstObj_S(strwhere);

           
            try
            {
                //判断同一用户同一论文只能添加一次，且论文类型也一致；
                if (clsPaperReadWriteBL.IsExistRecord(strwhere) == true)
                {
                    string strMsg = string.Format("同一用户同一类型论文只能添加一次，论文:[{0}]已经存在!({1})", objPaperReadWriteEN.PaperId, clsStackTrace.GetCurrClassFunction());
                    clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                    return Ok(new { errorId = 1, errorMsg = strMsg });
                }
                if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true || clsPaperReadWriteBL.IsExist(objPaperReadWriteEN.PaperRWId) == true)
                {
                    objPaperReadWriteEN.PaperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
                }
                bool bolResult = objPaperReadWriteEN.AddNewRecord();                
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 同步论文读写统计
        /// </summary>
        /// <param name="objPaperEN"></param>
        /// <returns></returns>
        [HttpGet("SynPaperRWStatistics")]
        public bool SynPaperRWStatistics(string UpdUser)
        {
            bool bolResult = false;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                List<clsPaperReadWriteEN> objPaperReadWriteList = clsPaperReadWriteBL.GetObjLst("1=1");
                if (objPaperReadWriteList.Count > 0)
                {

                    foreach (clsPaperReadWriteEN objPaperReadWrite in objPaperReadWriteList)
                    {
                        string strWhere = " PaperRWId=" + objPaperReadWrite.PaperRWId;
                       
                        string strWhere2 = "  CommentTypeId='02' and ScoreType='2' and PubParentId=" + objPaperReadWrite.PaperRWId;

                        int intSubVCount = clsPaperSubViewpointBL.GetRecCountByCond(strWhere);
                      
                        int intTeaCount = clsSysCommentBL.GetRecCountByCond(strWhere2);

                        clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();

                        objPaperReadWriteEN.PaperRWId = objPaperReadWrite.PaperRWId;
                        objPaperReadWriteEN.SubVCount = intSubVCount;
                        objPaperReadWriteEN.TeaCount = intTeaCount;
                      

                        bolResult = clsPaperReadWriteBL.UpdateBySql2(objPaperReadWriteEN);
                    }
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return false;
            }

            return bolResult;
        }



        /// <summary>
        /// 功能:同时删除多条记录,并同步论文字段
        /// 调用方法: POST /api/PaperReadWriteApi/DelRecords
        /// 在Body区传输strKeyIdLst字符串列表的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecords)
        /// </summary>
        /// <param name = "strKeyIdLst">给定的关键字值列表的JSON串</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost("DelRecordsEx")]
        public ActionResult DelRecordsEx([FromBody]string strKeyIdLst)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strKeyIdLst", strKeyIdLst);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strKeyIdLst) == true)
            {
                string strMsg = string.Format("根据关键字列表串删除记录时，给定的关键字值列表的JSON串不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            string[] sstrPaperRWId = strKeyIdLst.Trim().Split(',');
            List<string> arrPaperRWId = new List<string>();
            foreach (string strPaperRWId in sstrPaperRWId)
            {
                if (string.IsNullOrEmpty(strPaperRWId) == false)
                {
                    arrPaperRWId.Add(strPaperRWId);

                }
            }
            try
            {
                int intRecNum = clsPaperReadWriteBL.DelPaperReadWrites(arrPaperRWId);
                

                foreach (string strPaperRWId in sstrPaperRWId)
                {
                    if (string.IsNullOrEmpty(strPaperRWId) == false)
                    {
                        string strWhere = " PaperRWId=" + strPaperRWId;

                        clsPaperReadWriteEN objPaperReadWrite = clsPaperReadWriteBL.GetFirstObj_S(strWhere);
                        string strWhere2 = " PaperId=" + objPaperReadWrite.PaperId;
                        int intRWCount = clsPaperReadWriteBL.GetRecCountByCond(strWhere2);
                        int intAttachmentCount = clsPaperAttachmentBL.GetRecCountByCond(strWhere2);
                        int intCollectionCount = clsPaperCollectionLogBL.GetRecCountByCond(strWhere2);
                        int intDownloadCount = clsPaperDownloadLogBL.GetRecCountByCond(strWhere2);
                   
                        clsPaperEN objPaperEN = new clsPaperEN();
                        objPaperEN.PaperId = objPaperReadWrite.PaperId;
                        objPaperEN.Pcount = intRWCount;
                        objPaperEN.AttachmentCount = intAttachmentCount;
                        objPaperEN.CollectionCount = intCollectionCount;
                        objPaperEN.DownloadCount = intDownloadCount;
                        clsPaperBL.UpdateBySql2(objPaperEN);
                    }
                }
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录,并同步论文字段
        /// 调用方法: POST /api/PaperReadWriteApi/DelPaperReadWrites
        /// 在Body区传输arrPaperRWId(关键字值列表)的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
        /// </summary>
        /// <param name = "arrPaperRWId">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost("DelPaperReadWritesEx")]
        public ActionResult DelPaperReadWritesEx([FromBody]string[] arrPaperRWId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            List<string> arrLst = new List<string>(arrPaperRWId);
            dictParam.Add("arrPaperRWId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = clsPaperReadWriteBL.DelPaperReadWrites(arrLst);
                
                for (int i = 0; i < arrLst.Count; i++)
                {
                    string strPaperRWId = arrLst[i].ToString();

                    string strWhere = " PaperRWId=" + strPaperRWId;

                    clsPaperReadWriteEN objPaperReadWrite = clsPaperReadWriteBL.GetFirstObj_S(strWhere);
                    string strWhere2 = " PaperId=" + objPaperReadWrite.PaperId;
                    int intRWCount = clsPaperReadWriteBL.GetRecCountByCond(strWhere2);
                    int intAttachmentCount = clsPaperAttachmentBL.GetRecCountByCond(strWhere2);
                    int intCollectionCount = clsPaperCollectionLogBL.GetRecCountByCond(strWhere2);
                    int intDownloadCount = clsPaperDownloadLogBL.GetRecCountByCond(strWhere2);

                    clsPaperEN objPaperEN = new clsPaperEN();
                    objPaperEN.PaperId = objPaperReadWrite.PaperId;
                    objPaperEN.Pcount = intRWCount;
                    objPaperEN.AttachmentCount = intAttachmentCount;
                    objPaperEN.CollectionCount = intCollectionCount;
                    objPaperEN.DownloadCount = intDownloadCount;

                    clsPaperBL.UpdateBySql2(objPaperEN);

                }
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// 调用方法: GET /api/vPaperReadWriteExApi/GetGroupObjLst?strWhereCond=v1&
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetUserNumObjLst")]
        public ActionResult GetUserNumObjLst(string strWhereCond)
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
                List<clsvPaperReadWriteEN> arrvPaperReadWriteObjLst = clsvPaperReadWriteBLEx.GetUserNumObjLst(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvPaperReadWriteObjLst });
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