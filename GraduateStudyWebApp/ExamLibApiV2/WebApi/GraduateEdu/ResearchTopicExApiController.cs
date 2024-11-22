
/*-- -- -- -- -- -- -- -- -- -- --
类名:ResearchTopicExApiController
表名:ResearchTopic(01120546)
生成代码版本:2019.12.06.1
生成日期:2019/12/26 20:37:13
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
using Comm.WebApi;
using ExamLib.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ExamLib.WebApi
{
    /// <summary>
    /// ResearchTopicExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ResearchTopicExApiController : ControllerBase
    {


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
            string strTopicId = Id;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strTopicId"] = strTopicId
            };
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            if (string.IsNullOrEmpty(strTopicId) == true)
            {
                string strMsg = string.Format("删除关键字所指定的记录，关键字不能为空!({0})", clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
            try
            {
                int intRecNum = 0;
                bool bolResult = false;
                string strWhere = " 1=1 And TopicId='" + Id + "'";

                //先判断主题下面是否存在数据，存在则不执行删除操作
                //主题用户关系数据过滤掉，不用判断；


                //删除主题论文关系数据
                bolResult = clsRTPaperRelaBL.IsExistRecord(strWhere);
                if (bolResult == true)
                {
                    intRecNum = 0;
                }
                else
                {
                    //删除主题观点关系数据
                    bolResult = clsRTViewpointRelaBL.IsExistRecord(strWhere);
                    if (bolResult == true)
                    {
                        intRecNum = 0;
                    }
                    else
                    {



                        //删除主题用户关系数据；
                        clsRTUserRelaBL.DelRTUserRelasByCond(strWhere);
                        //删除主题观点关系数据
                        clsRTViewpointRelaBL.DelRTViewpointRelasByCond(strWhere);
                        //删除主题论文关系数据
                        clsRTPaperRelaBL.DelRTPaperRelasByCond(strWhere);
                        //主题概念
                        clsRTConceptRelaBL.DelRTConceptRelasByCond(strWhere);
                        //主题技能
                        clsRTSysSkillRelaBL.DelRTSysSkillRelasByCond(strWhere);
                        //主题社会关系；
                        clsRTSysSocialRelaBL.DelRTSysSocialRelasByCond(strWhere);
                        //主题客观数据；
                        clsRTTopicObjectiveRelaBL.DelRTTopicObjectiveRelasByCond(strWhere);

                        //删除带主题的问题回答数据；
                        clsqa_AnswerBL.Delqa_AnswersByCond(strWhere);

                        intRecNum = clsResearchTopicBL.DelRecord(strTopicId);
                
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
    }
}