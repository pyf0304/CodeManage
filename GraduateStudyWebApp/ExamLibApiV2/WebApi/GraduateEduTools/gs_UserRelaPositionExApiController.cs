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
    public class gs_UserRelaPositionExApiController : ControllerBase
    {

        /// <summary>
        /// 通过JSON对象来添加记录对象
        /// 调用方法: POST /api/gs_UserRelaPositionApi/AddNewRecord
        /// 在Body区传输objgs_UserRelaPositionEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_AddNewRecord)
        /// </summary>
        /// <param name = "objgs_UserRelaPositionEN">对象</param>
        /// <returns>是否成功</returns>
        [HttpPost("AddNewRecord")]        
        public ActionResult AddNewRecord([FromBody] List<clsgs_UserRelaPositionEN> arrgs_UserRelaPosition)
        {
            
            try
            {
                //List<clsgs_UserRelaPositionEN> arrgs_UserRelaPosition = JsonConvert.DeserializeObject<List<clsgs_UserRelaPositionEN>>(strresult);

                bool bolResult = false;
                foreach (clsgs_UserRelaPositionEN objgs_UserRelaPositionEN in arrgs_UserRelaPosition)
                {
                    clsgs_UserRelaPositionEN objgs_UserRelaPosition = new clsgs_UserRelaPositionEN();
                    objgs_UserRelaPosition.UserId = objgs_UserRelaPositionEN.UserId;
                    objgs_UserRelaPosition.UpdUser = objgs_UserRelaPositionEN.UpdUser;
                    objgs_UserRelaPosition.UpdDate = objgs_UserRelaPositionEN.UpdDate;
                    objgs_UserRelaPosition.IdCurrEduCls = objgs_UserRelaPositionEN.IdCurrEduCls;
                    objgs_UserRelaPosition.OrderNum = objgs_UserRelaPositionEN.OrderNum;
                    objgs_UserRelaPosition.XPosition = objgs_UserRelaPositionEN.XPosition;
                    objgs_UserRelaPosition.YPosition = objgs_UserRelaPositionEN.YPosition;

                    bolResult = clsgs_UserRelaPositionBL.AddNewRecordBySql2(objgs_UserRelaPosition);

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