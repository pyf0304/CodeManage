
/*-- -- -- -- -- -- -- -- -- -- --
类名:PaperSubViewpointExApiController
表名:PaperSubViewpoint(01120534)
生成代码版本:2019.12.06.1
生成日期:2019/12/26 10:25:40
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
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;
using ExamLib.BusinessLogicEx;

namespace ExamLib.WebApi
{
    /// <summary>
    /// PaperSubViewpointExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PaperSubViewpointExApiController : ControllerBase
    {


        /// <summary>
        /// 功能:同时删除多条记录,同步论文读写统计
        /// 调用方法: POST /api/PaperSubViewpointApi/DelRecords
        /// 在Body区传输strKeyIdLst字符串列表的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecords)
        /// </summary>
        /// <param name = "strKeyIdLst">给定的关键字值列表的JSON串</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost("DelRecordsEx")]
        public ActionResult DelRecordsEx([FromBody] string strKeyIdLst)
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
            string[] sstrSubViewpointId = strKeyIdLst.Trim().Split(',');
            List<string> arrSubViewpointId = new List<string>();
            foreach (string strSubViewpointId in sstrSubViewpointId)
            {
                if (string.IsNullOrEmpty(strSubViewpointId) == false)
                {
                    arrSubViewpointId.Add(strSubViewpointId);
                }
            }
            try
            {
                int intRecNum = clsPaperSubViewpointBL.DelPaperSubViewpoints(arrSubViewpointId);

                foreach (string strSubViewpointId in sstrSubViewpointId)
                {
                    if (string.IsNullOrEmpty(strSubViewpointId) == false)
                    {
                        string strWhere = " SubViewpointId=" + strSubViewpointId;

                        clsPaperSubViewpointEN objPaperSubViewpoint = clsPaperSubViewpointBL.GetFirstObj_S(strWhere);
                        string strPaperRWId = objPaperSubViewpoint.PaperRWId;
                        string strWhere2 = " PaperRWId=" + strPaperRWId;

                        string strWhere3 = "  CommentTypeId='02' and ScoreType='2' and PubParentId=" + strPaperRWId;

                        int intSubVCount = clsPaperSubViewpointBL.GetRecCountByCond(strWhere2);
                        int intTeaCount = clsSysCommentBL.GetRecCountByCond(strWhere3);

                        clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();

                        objPaperReadWriteEN.PaperRWId = strPaperRWId;
                        objPaperReadWriteEN.SubVCount = intSubVCount;
                        objPaperReadWriteEN.TeaCount = intTeaCount;
                        clsPaperReadWriteBL.UpdateBySql2(objPaperReadWriteEN);
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
        /// 功能:同时删除多条记录,删除给定关键字列表的记录
        /// 调用方法: POST /api/PaperSubViewpointApi/DelPaperSubViewpoints
        /// 在Body区传输arrSubViewpointId(关键字值列表)的JSON串
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelMultiRecord)
        /// </summary>
        /// <param name = "arrSubViewpointId">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        [HttpPost("DelPaperSubViewpointsEx")]
        public ActionResult DelPaperSubViewpointsEx([FromBody] string[] arrSubViewpointId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            List<string> arrLst = new List<string>(arrSubViewpointId);
            dictParam.Add("arrSubViewpointId", clsArray.GetSqlInStrByArray(arrLst, true));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                int intRecNum = clsPaperSubViewpointBL.DelPaperSubViewpoints(arrLst);

                for (int i = 0; i < arrLst.Count; i++)
                {
                    string strSubViewpointId = arrLst[i].ToString();
                    string strWhere = " SubViewpointId=" + strSubViewpointId;

                    clsPaperSubViewpointEN objPaperSubViewpoint = clsPaperSubViewpointBL.GetFirstObj_S(strWhere);
                    string strPaperRWId = objPaperSubViewpoint.PaperRWId;
                    string strWhere2 = " PaperRWId=" + strPaperRWId;

                    string strWhere3 = "  CommentTypeId='02' and ScoreType='2' and PubParentId=" + strPaperRWId;

                    int intSubVCount = clsPaperSubViewpointBL.GetRecCountByCond(strWhere2);
                    int intTeaCount = clsSysCommentBL.GetRecCountByCond(strWhere3);

                    clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();

                    objPaperReadWriteEN.PaperRWId = strPaperRWId;
                    objPaperReadWriteEN.SubVCount = intSubVCount;
                    objPaperReadWriteEN.TeaCount = intTeaCount;
                    clsPaperReadWriteBL.UpdateBySql2(objPaperReadWriteEN);
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
        /// 功能:删除关键字所指定的记录
        /// 调用方法: DELETE /api/PaperSubViewpointApi/DelRecord/Id
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
        /// </summary>
        /// <param name = "Id">给定的关键字值</param>
        /// <returns>返回删除的记录数</returns>
        [HttpDelete("DelRecordEx")]
        public ActionResult DelRecordEx(long Id)
        {
            long strSubViewpointId = Id;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strSubViewpointId"] = strSubViewpointId.ToString()
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (strSubViewpointId != 0)
            {
                string strMsg = string.Format("删除关键字所指定的记录，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                //得到论文Id  通过子观点得到论文读写Id
                clsPaperSubViewpointEN objPaperSubViewpointEN = clsPaperSubViewpointBL.GetFirstObj_S(" SubViewpointId='" + strSubViewpointId + "'");
                string strPaperRWId = objPaperSubViewpointEN.PaperRWId;
                string strWhere2 = " PaperRWId=" + strPaperRWId;
                string strWhere3 = "  CommentTypeId='02' and ScoreType='2' and PubParentId=" + strPaperRWId;

                int intRecNum = clsPaperSubViewpointBL.DelRecord(strSubViewpointId);

                //修改论文时间；

                int intSubVCount = clsPaperSubViewpointBL.GetRecCountByCond(strWhere2);
                int intTeaCount = clsSysCommentBL.GetRecCountByCond(strWhere3);
                clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
                objPaperReadWriteEN.PaperRWId = strPaperRWId;
                objPaperReadWriteEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                objPaperReadWriteEN.SubVCount = intSubVCount;
                objPaperReadWriteEN.TeaCount = intTeaCount;
                bool isbool = clsPaperReadWriteBL.UpdateBySql2(objPaperReadWriteEN);

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
        /// 通过JSON对象来修改记录对象
        /// 调用方法: Post /api/PaperSubViewpointApi/UpdateRecord
        /// 在Body区传输objPaperSubViewpointEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
        /// </summary>
        /// <param name = "strPaperSubViewpointJSONObj">JSON对象字符串</param>
        /// <returns>是否成功</returns>
        [HttpPost("UpdateRecordEx")]
        public ActionResult UpdateRecordEx([FromBody] clsPaperSubViewpointEN objPaperSubViewpointEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strPaperSubViewpointJSONObj = clsJSON.GetJsonFromObj(objPaperSubViewpointEN);
            dictParam.Add("strPaperSubViewpointJSONObj", strPaperSubViewpointJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (objPaperSubViewpointEN.SubViewpointId == 0)
            {
                string strMsg = string.Format("修改记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                clsPaperSubViewpointBL.SetUpdFlag(objPaperSubViewpointEN);
                bool bolResult = objPaperSubViewpointEN.Update();
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
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/PaperSubViewpointApi/AddNewRecord
        /// 在Body区传输objPaperSubViewpointEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objPaperSubViewpointEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecordEx")]
        public ActionResult AddNewRecordEx([FromBody] clsPaperSubViewpointEN objPaperSubViewpointEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strPaperSubViewpointJSONObj = clsJSON.GetJsonFromObj(objPaperSubViewpointEN);
            dictParam.Add("strPaperSubViewpointJSONObj", strPaperSubViewpointJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                bool bolResult = Convert.ToBoolean(objPaperSubViewpointEN.AddNewRecord());

                //修改论文时间；
                //得到论文Id
                string strPaperRWId = objPaperSubViewpointEN.PaperRWId;

                clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
                objPaperReadWriteEN.PaperRWId = strPaperRWId;
                objPaperReadWriteEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                bolResult = clsPaperReadWriteBL.UpdateBySql2(objPaperReadWriteEN);

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
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// 调用方法: POST /api/PaperSubViewpointApi/AddNewRecord
        /// 在Body区传输objPaperSubViewpointEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objPaperSubViewpointEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        [HttpPost("AddNewRecordWithReturnKeyEx")]
        public ActionResult AddNewRecordWithReturnKeyEx(clsPaperSubViewpointEN objPaperSubViewpointEN)
        {


            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("objPaperSubViewpointEN", clsJSON.GetJsonFromObj(objPaperSubViewpointEN));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            //}
            try
            {
                if (string.IsNullOrEmpty(objPaperSubViewpointEN.PaperRWId) == true) objPaperSubViewpointEN.PaperRWId = "00000000";
                string strKey = clsPaperSubViewpointBL.AddNewRecordBySql2WithReturnKey(objPaperSubViewpointEN);

                //修改论文时间；
                //得到论文Id
                string strPaperRWId = objPaperSubViewpointEN.PaperRWId;//

                clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
                objPaperReadWriteEN.PaperRWId = strPaperRWId;
                objPaperReadWriteEN.IdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls;

                objPaperReadWriteEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                clsPaperReadWriteBL.UpdateBySql2(objPaperReadWriteEN);
                return Ok(new { errorId = 0, errorMsg = "", returnStr = strKey });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        /// <summary>
        /// 通过JSON对象来修改记录对象
        /// 调用方法: Post /api/PaperReadWriteApi/UpdateRecord
        /// 在Body区传输objPaperReadWriteEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
        /// </summary>
        /// <param name = "strPaperReadWriteJSONObj">JSON对象字符串</param>
        /// <returns>是否成功</returns>
        [HttpPost("UpdateRecord")]
        public ActionResult UpdateRecord([FromBody] clsPaperReadWriteEN objPaperReadWriteEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            string strPaperReadWriteJSONObj = clsJSON.GetJsonFromObj(objPaperReadWriteEN);
            dictParam.Add("strPaperReadWriteJSONObj", strPaperReadWriteJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true)
            {
                string strMsg = string.Format("修改记录时，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                clsPaperReadWriteBL.SetUpdFlag(objPaperReadWriteEN);
                bool bolResult = objPaperReadWriteEN.Update();
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        [HttpPost("ImportViewPoint")]
        public ActionResult ImportViewPoint()
        {


            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("objPaperSubViewpointEN", clsJSON.GetJsonFromObj(objPaperSubViewpointEN));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            //}
            try
            {
                int intReturn = clsPaperSubViewpointBLEx.ImportViewPoint();
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intReturn });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        [HttpPost("ImportConcept")]
        public ActionResult ImportConcept()
        {


            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("objPaperSubViewpointEN", clsJSON.GetJsonFromObj(objPaperSubViewpointEN));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            //}
            try
            {
                int intReturn = clsPaperSubViewpointBLEx.ImportConcept();
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intReturn });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }



        [HttpPost("ImportSysSkill")]
        public ActionResult ImportSysSkill()
        {


            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("objPaperSubViewpointEN", clsJSON.GetJsonFromObj(objPaperSubViewpointEN));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            //}
            try
            {
                int intReturn = clsPaperSubViewpointBLEx.ImportSysSkill();
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intReturn });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
        [HttpPost("ImportTopicObjective")]
        public ActionResult ImportTopicObjective()
        {


            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("objPaperSubViewpointEN", clsJSON.GetJsonFromObj(objPaperSubViewpointEN));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            //}
            try
            {
                int intReturn = clsPaperSubViewpointBLEx.ImportTopicObjective();
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intReturn });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        [HttpPost("ImportSysSocialRelations")]
        public ActionResult ImportSysSocialRelations()
        {

            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("objPaperSubViewpointEN", clsJSON.GetJsonFromObj(objPaperSubViewpointEN));
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            //}
            try
            {
                int intReturn = clsPaperSubViewpointBLEx.ImportSysSocialRelations();
                return Ok(new { errorId = 0, errorMsg = "", returnInt = intReturn });
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