
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_RTqa_PaperRelaApiController
表名:gs_RTqa_PaperRela(01120696)
生成代码版本:2020.08.03.1
生成日期:2020/08/03 14:23:06
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_服务层(WA_Srv)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using com.taishsoft.json;
using ExamLib.BusinessLogic;
using ExamLib.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLib.WebApi
{
    [ApiController]
    [Route("[controller]")]
    public class gs_RTqa_PaperRelaExApiController : ControllerBase
    {

        /// <summary>
        /// 同步主题论文答疑
        /// </summary>
        /// <param name="objPaperEN"></param>
        /// <returns></returns>
        [HttpGet("SynTopicPaperQA")]
        public bool SynTopicPaperQA(string stridCurrEduCls, string strTopicId, string strUpdUser)
        {
            bool bolResult = true;
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                List<clsvRTPaperRelaEN> objvRTPaperRelaList = clsvRTPaperRelaBL.GetObjLst(" TopicId ='" + strTopicId + "' and PaperTypeId='01'");


                foreach (clsvRTPaperRelaEN objvRTPaperRela in objvRTPaperRelaList)
                {
                    int intCount = clsvgs_RTqa_PaperRelaBL.GetRecCountByCond(" TopicId ='" + strTopicId + "' and PaperId ='" + objvRTPaperRela.PaperId + "'");

                    if (intCount == 0)
                    {

                        //添加论文答疑
                        clsqa_PaperEN objqa_Paper = new clsqa_PaperEN();
                        objqa_Paper.IdCurrEduCls = stridCurrEduCls;
                        objqa_Paper.PaperId = objvRTPaperRela.PaperId;
                        objqa_Paper.IsDelete = false;
                        objqa_Paper.IsPublic = true;
                        objqa_Paper.IsSubmit = true;
                        objqa_Paper.UpdUser = strUpdUser;
                        objqa_Paper.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        objqa_Paper.QuestionsCount = 0;
                        objqa_Paper.AnswerCount = 0;
                        objqa_Paper.ShareId = "02";

                        string strqa_PaperId = clsqa_PaperBL.AddNewRecordBySql2WithReturnKey(objqa_Paper);


                        //添加主题答疑关系表
                        clsgs_RTqa_PaperRelaEN objgs_RTqa_PaperRela = new clsgs_RTqa_PaperRelaEN();
                        objgs_RTqa_PaperRela.TopicId = strTopicId;
                        objgs_RTqa_PaperRela.QaPaperId = strqa_PaperId;
                        objgs_RTqa_PaperRela.UpdUser = strUpdUser;
                        objgs_RTqa_PaperRela.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        bolResult = clsgs_RTqa_PaperRelaBL.AddNewRecordBySql2(objgs_RTqa_PaperRela);
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
    }
}