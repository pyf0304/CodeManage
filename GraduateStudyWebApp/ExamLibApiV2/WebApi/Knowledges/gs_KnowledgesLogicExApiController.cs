using com.taishsoft.common;
using ExamLib.BusinessLogic;
using ExamLib.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class gs_KnowledgesLogicExApiController : ControllerBase
    {

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/gs_KnowledgesLogicApi/AddNewRecord
        /// 在Body区传输objgs_KnowledgesLogicEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objgs_KnowledgesLogicEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecord")]
        public ActionResult AddNewRecord([FromBody] List<clsgs_KnowledgesLogicEN> arrgs_KnowledgesLogic)
        {            
            try
            {         
                bool bolResult = false;
                foreach (clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN in arrgs_KnowledgesLogic)
                {
                    clsgs_KnowledgesLogicEN objgs_KnowledgesLogic = new clsgs_KnowledgesLogicEN();
                    objgs_KnowledgesLogic.CourseKnowledgeId = objgs_KnowledgesLogicEN.CourseKnowledgeId;
                    objgs_KnowledgesLogic.CourseKnowledgeTitle = objgs_KnowledgesLogicEN.CourseKnowledgeTitle;
                    objgs_KnowledgesLogic.LogicNodeId = objgs_KnowledgesLogicEN.LogicNodeId;
                    objgs_KnowledgesLogic.UpdUser = objgs_KnowledgesLogicEN.UpdUser;
                    objgs_KnowledgesLogic.UpdDate = objgs_KnowledgesLogicEN.UpdDate;
                    objgs_KnowledgesLogic.KnowledgeGraphId = objgs_KnowledgesLogicEN.KnowledgeGraphId;
                    objgs_KnowledgesLogic.ClassNameCss = objgs_KnowledgesLogicEN.ClassNameCss;

                    objgs_KnowledgesLogic.XPosition = objgs_KnowledgesLogicEN.XPosition;
                    objgs_KnowledgesLogic.YPosition = objgs_KnowledgesLogicEN.YPosition;

                    bolResult = clsgs_KnowledgesLogicBL.AddNewRecordBySql2(objgs_KnowledgesLogic);

                }
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });


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