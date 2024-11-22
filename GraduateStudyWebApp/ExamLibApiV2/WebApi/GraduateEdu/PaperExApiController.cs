
/*-- -- -- -- -- -- -- -- -- -- --
类名:PaperExApiController
表名:Paper(01120535)
生成代码版本:2019.12.06.1
生成日期:2019/12/25 17:24:46
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
using com.taishsoft.common;
using com.taishsoft.json;

using ExamLib.BusinessLogic;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using ExamLib.BusinessLogicEx;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    /// <summary>
    /// PaperExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    public class PaperExApiController : PaperApiController
    {
        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/PaperApi/AddNewRecord
        /// 在Body区传输objPaperEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objPaperEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecordEx")]
        public bool AddNewRecordEx([FromBody]clsPaperEN objPaperEN)
        {
            //// 获取主键
            //objPaperEN.PaperId = GetMaxStrId();
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strPaperJSONObj = clsJSON.GetJsonFromObj(objPaperEN);
            dictParam.Add("strPaperJSONObj", strPaperJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            //判断用户名和论文名是否存在；
            string strwhere = "UpdUser='" + objPaperEN.UpdUser + "' And PaperTitle = '" + objPaperEN.PaperTitle + "'";
            //clsPaperEN objPaper = clsPaperBL.GetFirstObj_S(strwhere);

            if (clsPaperBL.IsExistRecord(strwhere) == true)
            {
                string strMsg = string.Format("添加记录时，论文名:[{0}]已经存在!({1})", objPaperEN.PaperTitle, clsStackTrace.GetCurrClassFunction());
                clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }
            try
            {
                if (string.IsNullOrEmpty(objPaperEN.PaperId) == true || clsPaperBL.IsExist(objPaperEN.PaperId) == true)
                {
                    objPaperEN.PaperId = clsPaperBL.GetMaxStrId_S();
                }
                bool bolResult = objPaperEN.AddNewRecord();
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// 同步论文统计
        /// </summary>
        /// <param name="objPaperEN"></param>
        /// <returns></returns>
        [HttpGet("SynPaperStatistics")]
        public bool SynPaperStatistics(string UpdUser)
        {
            bool bolResult = false;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                List<clsPaperEN> objPaperList = clsPaperBL.GetObjLst("1=1");
                if (objPaperList.Count > 0)
                {
                    
                    foreach (clsPaperEN objPaper in objPaperList)
                    {
                        string strWhere = " PaperId=" + objPaper.PaperId;
                        string strWhere2 = " VoteTypeId='01' and TableKey=" + objPaper.PaperId;
                        string strWhere3 = " CommentTypeId='01' and TableKey=" + objPaper.PaperId;
                        int intRWCount = clsPaperReadWriteBL.GetRecCountByCond(strWhere);
                        int intAttachmentCount = clsPaperAttachmentBL.GetRecCountByCond(strWhere);
                        int intCollectionCount = clsPaperCollectionLogBL.GetRecCountByCond(strWhere);
                        int intVoteCount = clsSysVoteBL.GetRecCountByCond(strWhere2);
                        int intDownloadCount = clsPaperDownloadLogBL.GetRecCountByCond(strWhere);
                        int intCommentCount = clsSysCommentBL.GetRecCountByCond(strWhere3);

                        clsPaperEN objPaperEN = new clsPaperEN();
                        objPaperEN.PaperId = objPaper.PaperId;

                        objPaperEN.Pcount = intRWCount;
                        objPaperEN.AttachmentCount = intAttachmentCount;
                        objPaperEN.CollectionCount = intCollectionCount;
                        objPaperEN.OkCount = intVoteCount;
                        objPaperEN.DownloadCount = intDownloadCount;
                        objPaperEN.AppraiseCount = intCommentCount;

                        bolResult = clsPaperBL.UpdateBySql2(objPaperEN);
                    }
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);
            }

            return bolResult;
        }
        

        /// <summary>
        /// 获取论文中的用户数量
        /// 调用方法: GET /api/vPaperExApi/GetUserNumObjLst?strWhereCond=1=1
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
                List<clsPaperEN> arrvPaperObjLst = clsPaperBLEx.GetUserNumObjLst(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvPaperObjLst });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        /// <summary>
        /// 获取论文中的点赞数量
        /// 调用方法: GET /api/vPaperExApi/GetUserNumObjLst?strWhereCond=1=1
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetPaperLikeNumObjLst")]
        public ActionResult GetPaperLikeNumObjLst(string strWhereCond)
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
                List<clsvPaperLikeLogEN> arrvPaperLikeLogObjLst = clsPaperBLEx.GetPaperLikeNumObjLst(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvPaperLikeLogObjLst });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        /// <summary>
        /// 获取论文中的评论数量
        /// 调用方法: GET /api/vPaperExApi/GetUserNumObjLst?strWhereCond=1=1
        /// (AutoGCLib.WA_Srv4CSharp:Gen_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        [HttpGet("GetPaperAppraiseNumObjLst")]
        public ActionResult GetPaperAppraiseNumObjLst(string strWhereCond)
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
                List<clsvPaperAppraiseEN> arrvPaperAppraiseObjLst = clsvPaperBLEx.GetPaperAppraiseNumObjLst(strWhereCond);
                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = arrvPaperAppraiseObjLst });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }
        }

        /// <summary>
        /// 根据教学班获取对象列表，用对象列表表示
        /// 调用方法: Get /api/clsvPaperBLExApi/GetObjLstByIdCurrEduCls?strIdCurrEduCls=value
        /// (ExamLib.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GetObjLstByIdCurrEduCls")]
        public ActionResult GetObjLstByIdCurrEduCls(string strIdCurrEduCls)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strIdCurrEduCls", strIdCurrEduCls);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsPaperBLEx.GetObjLstByIdCurrEduCls(strIdCurrEduCls);
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