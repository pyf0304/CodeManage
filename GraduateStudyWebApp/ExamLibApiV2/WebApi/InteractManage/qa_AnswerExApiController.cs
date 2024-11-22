using com.taishsoft.common;
using ExamLib.BusinessLogic;
using ExamLib.Entity;
using ExamLib.WebApi;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLibApi.Controllers.InteractManage
{
    [ApiController]
    [Route("[controller]")]
    public class qa_AnswerExApiController : ControllerBase
    {
        //private object clsSysVoteWApi;


        /// <summary>
        /// 功能:删除关键字所指定的记录
        /// 调用方法: DELETE /api/ResearchTopicApi/DelRecord/Id
        /// (AutoGCLib.WA_Srv4CSharp:Gen_DelRecord)
        /// </summary>
        /// <param name = "Id">给定的关键字值</param>
        /// <returns>返回删除的记录数</returns>
        [HttpDelete("DelRecordEx")]
        public ActionResult DelRecordEx(string Id)
        {
            string strAnswerId = Id;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strAnswerId"] = strAnswerId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strAnswerId) == true)
            {
                string strMsg = string.Format("删除关键字所指定的记录，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {

                string strWhere = " 1=1 And AnswerId = '" + strAnswerId + "'";
                //把对应的历史版本数据删除；
                clsqa_AnswerVerBL.Delqa_AnswerVersByCond(strWhere);

                //回复的子数据也需要删除;通过父节点删除子数据；需要先得到子数据的回答ID 查询有没有点赞数据；先删除点赞数据再删除答复子数据；
                var strWhereChild = " 1=1 And ParentId = '" + strAnswerId + "'";

                clsqa_AnswerEN objqa_Answer = clsqa_AnswerBL.GetFirstObj_S(strWhereChild);
                if (objqa_Answer != null)
                {
                    //得到回答ID 查询是否存在点赞数据，如果存在则删除；类型为12 代表问题回答点赞
                    string strVoteAnswerId = objqa_Answer.AnswerId;
                    string strWhereVote = " 1=1 And VoteTypeId='12' And TableKey = '" + strVoteAnswerId + "'";
                    //删除子回复的点赞
                    var intVoteCount = clsSysVoteBL.DelSysVotesByCond(strWhereVote);

                    //删除子回复数据
                    clsqa_AnswerBL.DelRecord(strVoteAnswerId);
                }
                string strZanWhere = " 1=1 And VoteTypeId='12' And TableKey = '" + strAnswerId + "'";
                //删除回复点赞
                clsSysVoteBL.DelSysVotesByCond(strZanWhere);


                //删除回答答案
                int intRecNum = clsqa_AnswerBL.DelRecord(strAnswerId);

                return Ok(new { errorId = 0, errorMsg = "", returnInt = intRecNum });
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