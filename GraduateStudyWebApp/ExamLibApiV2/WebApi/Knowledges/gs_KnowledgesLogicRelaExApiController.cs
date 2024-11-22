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
    public class gs_KnowledgesLogicRelaExApiController : ControllerBase
    {

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/gs_KnowledgesLogicRelaApi/AddNewRecord
        /// 在Body区传输objgs_KnowledgesLogicRelaEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objgs_KnowledgesLogicRelaEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecord")]
        public ActionResult AddNewRecord([FromBody] List<clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRela)
        {
            //Request.Content.ReadAsStreamAsync().Result.Seek(0, System.IO.SeekOrigin.Begin);
            //string strresult = Request.Content.ReadAsStringAsync().Result;

            try
            {
                //List<clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRela = JsonConvert.DeserializeObject<List<clsgs_KnowledgesLogicRelaEN>>(strresult);

                bool bolResult = false;
                foreach (clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN in arrgs_KnowledgesLogicRela)
                {
                    clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRela = new clsgs_KnowledgesLogicRelaEN();
                    string strCourseKnowledgeIdA = objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA;
                    strCourseKnowledgeIdA = strCourseKnowledgeIdA.Substring(strCourseKnowledgeIdA.Length - 8);

                    objgs_KnowledgesLogicRela.CourseKnowledgeIdA = strCourseKnowledgeIdA;

                    string strCourseKnowledgeIdB = objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB;
                    strCourseKnowledgeIdB = strCourseKnowledgeIdB.Substring(strCourseKnowledgeIdB.Length - 8);

                    objgs_KnowledgesLogicRela.CourseKnowledgeIdB = strCourseKnowledgeIdB;

                    objgs_KnowledgesLogicRela.CourseKnowledgeTitleA = objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA;
                    objgs_KnowledgesLogicRela.CourseKnowledgeTitleB = objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB;

                    objgs_KnowledgesLogicRela.SourceAnchor = objgs_KnowledgesLogicRelaEN.SourceAnchor;
                    objgs_KnowledgesLogicRela.TargetAnchor = objgs_KnowledgesLogicRelaEN.TargetAnchor;

                    objgs_KnowledgesLogicRela.KnowledgeGraphId = objgs_KnowledgesLogicRelaEN.KnowledgeGraphId;

                    objgs_KnowledgesLogicRela.RelaTitle = objgs_KnowledgesLogicRelaEN.RelaTitle;
                    objgs_KnowledgesLogicRela.UpdUser = objgs_KnowledgesLogicRelaEN.UpdUser;
                    objgs_KnowledgesLogicRela.UpdDate = objgs_KnowledgesLogicRelaEN.UpdDate;

                    bolResult = clsgs_KnowledgesLogicRelaBL.AddNewRecordBySql2(objgs_KnowledgesLogicRela);

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