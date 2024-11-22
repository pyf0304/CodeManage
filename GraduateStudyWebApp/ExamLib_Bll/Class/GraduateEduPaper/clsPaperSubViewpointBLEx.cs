
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPaperSubViewpointBLEx
表名:PaperSubViewpoint(01120534)
生成代码版本:2020.09.24.1
生成日期:2020/10/19 16:59:39
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
    public static class clsPaperSubViewpointBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objPaperSubViewpointENS">源对象</param>
        /// <returns>目标对象=>clsPaperSubViewpointEN:objPaperSubViewpointENT</returns>
        public static clsPaperSubViewpointENEx CopyToEx(this clsPaperSubViewpointEN objPaperSubViewpointENS)
        {
            try
            {
                clsPaperSubViewpointENEx objPaperSubViewpointENT = new clsPaperSubViewpointENEx();
                clsPaperSubViewpointBL.PaperSubViewpointDA.CopyTo(objPaperSubViewpointENS, objPaperSubViewpointENT);
                return objPaperSubViewpointENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objPaperSubViewpointENS">源对象</param>
        /// <returns>目标对象=>clsPaperSubViewpointEN:objPaperSubViewpointENT</returns>
        public static clsPaperSubViewpointEN CopyTo(this clsPaperSubViewpointENEx objPaperSubViewpointENS)
        {
            try
            {
                clsPaperSubViewpointEN objPaperSubViewpointENT = new clsPaperSubViewpointEN();
                clsPaperSubViewpointBL.CopyTo(objPaperSubViewpointENS, objPaperSubViewpointENT);
                return objPaperSubViewpointENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 子观点表(PaperSubViewpoint)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsPaperSubViewpointBLEx : clsPaperSubViewpointBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsPaperSubViewpointDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsPaperSubViewpointDAEx PaperSubViewpointDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsPaperSubViewpointDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        public static clsPaperSubViewpointEN GetObjByViewPoint(clsViewpointEN objViewpointENS)
        {
            try
            {
                clsPaperSubViewpointEN objPaperSubViewpointENT = new clsPaperSubViewpointEN();
                //objPaperSubViewpointENT.SubViewpointId = GetMaxStrId_S(); //objViewpointENS.SubViewpointId; //子观点Id
                if (objViewpointENS.ViewpointContent == null) objViewpointENS.ViewpointContent = objViewpointENS.ViewpointName;
                while (clsString.getStrLenS(objViewpointENS.ViewpointContent) > 499)
                {
                    int intLen = objViewpointENS.ViewpointContent.Length;
                    objViewpointENS.ViewpointContent = objViewpointENS.ViewpointContent.Substring(0, intLen - 2);
                }
                objPaperSubViewpointENT.SubViewpointContent = objViewpointENS.ViewpointContent; //详情内容
                                                                                                //objPaperSubViewpointENT.PaperRWId = objViewpointENS.PaperRWId; //课文阅读
                objPaperSubViewpointENT.PaperId = objViewpointENS.CitationId;//论文Id
                objPaperSubViewpointENT.IdCurrEduCls = objViewpointENS.IdCurrEduCls; //教学班流水号
                objPaperSubViewpointENT.UserId = objViewpointENS.VPProposePeople;//.UserId; //用户ID
                                                                                 //objPaperSubViewpointENT.SectionId = objViewpointENS.SectionId; //节Id
                objPaperSubViewpointENT.SubViewpointTypeId = "00000000";// objViewpointENS.SubViewpointTypeId; //类型Id
                objPaperSubViewpointENT.gsKnowledgeTypeId = enumgs_KnowledgeType.PersonalOpinion_01;//
                if (objViewpointENS.UserTypeId == "02") objPaperSubViewpointENT.gsKnowledgeTypeId = enumgs_KnowledgeType.ExpertOpinion_02;//

                //objPaperSubViewpointENT.RWTitle = objViewpointENS.RWTitle; //读写标题
                switch (objViewpointENS.ViewpointTypeId)
                {
                    case "0001"://说明
                        objPaperSubViewpointENT.ExplainTypeId = enumExplainType.ExplanationOrDescription_01;
                        break;
                    case "0002":    //方法
                        objPaperSubViewpointENT.ExplainTypeId = enumExplainType.MethodOrApproach_03;
                        break;
                    case "0003"://    依据 
                        objPaperSubViewpointENT.ExplainTypeId = enumExplainType.BasisOrGrounds_02;
                        break;
                }
                if (objViewpointENS.Reason == null)
                {
                    objPaperSubViewpointENT.ExplainContent = "";
                }
                else
                {
                    while (clsString.getStrLenS(objViewpointENS.Reason) > 4999)
                    {
                        int intLen = objViewpointENS.Reason.Length;
                        objViewpointENS.Reason = objViewpointENS.Reason.Substring(0, intLen - 2);
                    }
                    objPaperSubViewpointENT.ExplainContent = objViewpointENS.Reason; //说明内容
                }                                                               //objPaperSubViewpointENT.IsPublic = objViewpointENS.IsPublic; //是否公开
                                                                                //objPaperSubViewpointENT.LiteratureSourcesId = objViewpointENS.LiteratureSourcesId; //文献来源
                objPaperSubViewpointENT.PageNumber = objViewpointENS.PdfPageNum; //页码
                                                                                 //objPaperSubViewpointENT.OrderNum = objViewpointENS.OrderNum; //序号
                objPaperSubViewpointENT.PdfContent = objViewpointENS.PdfContent; //Pdf内容
                                                                                 //objPaperSubViewpointENT.selectSpanRange = objViewpointENS.selectSpanRange; //选择Span范围
                                                                                 //objPaperSubViewpointENT.PaperLineNum = objViewpointENS.PaperLineNum; //论文行号
                                                                                 //objPaperSubViewpointENT.PaperPageNum = objViewpointENS.PaperPageNum; //论文页码
                objPaperSubViewpointENT.AppraiseCount = objViewpointENS.AppraiseCount; //评论数
                objPaperSubViewpointENT.OkCount = objViewpointENS.OkCount; //点赞统计
                objPaperSubViewpointENT.Score = objViewpointENS.Score; //评分
                objPaperSubViewpointENT.StuScore = objViewpointENS.StuScore; //学生平均分
                objPaperSubViewpointENT.TeaScore = objViewpointENS.TeaScore; //教师评分
                objPaperSubViewpointENT.CreateDate = objViewpointENS.CreateDate; //建立日期
                objPaperSubViewpointENT.ShareId = objViewpointENS.ShareId; //分享Id
                                                                           //objPaperSubViewpointENT.TopicId = objViewpointENS.TopicId; //主题Id
                                                                           //objPaperSubViewpointENT.AttitudesId = objViewpointENS.AttitudesId; //态度Id
                objPaperSubViewpointENT.UpdDate = objViewpointENS.UpdDate; //修改日期
                objPaperSubViewpointENT.UpdUser = objViewpointENS.UpdUser; //修改人
                objPaperSubViewpointENT.Memo = objViewpointENS.ViewpointId; //备注
                return objPaperSubViewpointENT;
            }
            catch (Exception objEx)
            {
                throw new Exception(objEx.Message);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objPaperSubViewpointENS">源对象</param>
        /// <returns>目标对象=>clsPaperSubViewpointEN:objPaperSubViewpointENT</returns>
        public static clsPaperSubViewpointENEx CopyToEx(clsPaperSubViewpointEN objPaperSubViewpointENS)
        {
            try
            {
                clsPaperSubViewpointENEx objPaperSubViewpointENT = new clsPaperSubViewpointENEx();
                clsPaperSubViewpointBL.PaperSubViewpointDA.CopyTo(objPaperSubViewpointENS, objPaperSubViewpointENT);
                return objPaperSubViewpointENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsPaperSubViewpointENEx> GetObjExLst(string strCondition)
        {
            List<clsPaperSubViewpointEN> arrObjLst = clsPaperSubViewpointBL.GetObjLst(strCondition);
            List<clsPaperSubViewpointENEx> arrObjExLst = new List<clsPaperSubViewpointENEx>();
            foreach (clsPaperSubViewpointEN objInFor in arrObjLst)
            {
                clsPaperSubViewpointENEx objPaperSubViewpointENEx = new clsPaperSubViewpointENEx();
                clsPaperSubViewpointBL.CopyTo(objInFor, objPaperSubViewpointENEx);
                arrObjExLst.Add(objPaperSubViewpointENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strSubViewpointId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsPaperSubViewpointENEx GetObjExBySubViewpointId(long strSubViewpointId)
        {
            clsPaperSubViewpointEN objPaperSubViewpointEN = clsPaperSubViewpointBL.GetObjBySubViewpointId(strSubViewpointId);
            clsPaperSubViewpointENEx objPaperSubViewpointENEx = new clsPaperSubViewpointENEx();
            clsPaperSubViewpointBL.CopyTo(objPaperSubViewpointEN, objPaperSubViewpointENEx);
            return objPaperSubViewpointENEx;
        }
        public static int ImportViewPoint()
        {
            List<clsViewpointEN> arrViewpoint = clsViewpointBL.GetObjLst("1=1");
            int iCount = 0;
            foreach (var objViewPoint in arrViewpoint)
            {
                long strSubViewpointId = 0;
                clsPaperSubViewpointEN objPaperSubViewpointEN = GetObjByViewPoint(objViewPoint);
                if (objPaperSubViewpointEN.PaperId == null) { objPaperSubViewpointEN.PaperId = "00000000"; }
                if (objPaperSubViewpointEN.PaperId == "") { objPaperSubViewpointEN.PaperId = "00000000"; }

                string strWhere2 = "";
                try
                {
                    clsPaperSubViewpointBL.CheckPropertyNew(objPaperSubViewpointEN);
                    strWhere2 = $"{conPaperSubViewpoint.SubViewpointContent} = '{objPaperSubViewpointEN.SubViewpointContent}' and {conPaperSubViewpoint.UserId} = '{objPaperSubViewpointEN.UserId}'";
                    if (clsPaperSubViewpointBL.IsExistRecord(strWhere2) == true)
                    {
                        strSubViewpointId = clsPaperSubViewpointBL.GetFirstID_S(strWhere2);
                        objPaperSubViewpointEN.SetSubViewpointId(strSubViewpointId);
                        objPaperSubViewpointEN.UpdateWithCondition(strWhere2);
                    }
                    else
                    {
                        clsPaperSubViewpointBL.AddNewRecordBySql2(objPaperSubViewpointEN);
                        strSubViewpointId = objPaperSubViewpointEN.SubViewpointId;
                    }


                }
                catch (Exception objEx)
                {
                    strSubViewpointId = long.Parse(objViewPoint.Memo);
                    if (objEx.Message.Length > 498)
                    {
                        objViewPoint.Memo = objEx.Message.Substring(0, 498);
                    }
                    else objViewPoint.Memo = objEx.Message;
                    objViewPoint.Update();
                    continue;
                }
                string strWhere = $"{conRTViewpointRela.ViewpointId} = '{objViewPoint.ViewpointId}'";
                List<clsRTViewpointRelaEN> arrRela = clsRTViewpointRelaBL.GetObjLst(strWhere);
                foreach (clsRTViewpointRelaEN objRTViewpointRela in arrRela)
                {
                    var objRTViewpoint = clsRTViewpointBLEx.GetObjByRTViewpointRela(objRTViewpointRela, objPaperSubViewpointEN.SubViewpointId, objPaperSubViewpointEN.gsKnowledgeTypeId);

                    try
                    {
                        clsRTViewpointBL.CheckPropertyNew(objRTViewpoint);
                        objRTViewpoint.Memo = objRTViewpointRela.ViewpointId;
                        strWhere = $"{conRTViewpoint.SubViewpointId} = '{objRTViewpoint.SubViewpointId}' and {conRTViewpoint.TopicId} = '{objRTViewpointRela.TopicId}'";
                        if (clsRTViewpointBL.IsExistRecord(strWhere) == false)
                        {
                            clsRTViewpointBL.AddNewRecordBySql2(objRTViewpoint);
                        }
                        else
                        {
                            objRTViewpoint.UpdateWithCondition(strWhere);
                        }
                    }
                    //catch (Exception ex)
                    catch
                    {
                        continue;
                    }
                }

                objViewPoint.Memo = objPaperSubViewpointEN.SubViewpointId.ToString();
                objViewPoint.Update();
                iCount++;
            }
            return iCount;
        }

        public static int ImportConcept()
        {
            List<clsConceptEN> arrViewpoint = clsConceptBL.GetObjLst("1=1");
            int iCount = 0;
            foreach (var objConceptEN in arrViewpoint)
            {
                long strSubViewpointId = 0;
                clsPaperSubViewpointEN objPaperSubViewpointEN = GetObjByConcept(objConceptEN);
                if (objPaperSubViewpointEN.PaperId == null) { objPaperSubViewpointEN.PaperId = "00000000"; }
                if (objPaperSubViewpointEN.PaperId == "") { objPaperSubViewpointEN.PaperId = "00000000"; }

                string strWhere2 = "";
                try
                {
                    clsPaperSubViewpointBL.CheckPropertyNew(objPaperSubViewpointEN);
                    strWhere2 = $"{conPaperSubViewpoint.SubViewpointContent} = '{objPaperSubViewpointEN.SubViewpointContent}' and {conPaperSubViewpoint.UserId} = '{objPaperSubViewpointEN.UserId}'";


                    if (clsPaperSubViewpointBL.IsExistRecord(strWhere2) == true)
                    {
                        strSubViewpointId = clsPaperSubViewpointBL.GetFirstID_S(strWhere2);
                        objPaperSubViewpointEN.SetSubViewpointId(strSubViewpointId);
                        objPaperSubViewpointEN.UpdateWithCondition(strWhere2);
                    }
                    else
                    {
                        clsPaperSubViewpointBL.AddNewRecordBySql2(objPaperSubViewpointEN);
                        strSubViewpointId = objPaperSubViewpointEN.SubViewpointId;
                    }


                }
                catch (Exception objEx)
                {
                    strSubViewpointId = long.Parse(objConceptEN.Memo);
                    objConceptEN.Memo = objEx.Message.Substring(0, 498);
                    objConceptEN.Update();
                    continue;
                }
                string strWhere = $"{conRTConceptRela.ConceptId} = '{objConceptEN.ConceptId}'";
                List<clsRTConceptRelaEN> arrRela = clsRTConceptRelaBL.GetObjLst(strWhere);
                foreach (clsRTConceptRelaEN objRTConceptRela in arrRela)
                {
                    var objRTViewpoint = clsRTViewpointBLEx.GetObjByRTConceptRela(objRTConceptRela, strSubViewpointId);

                    try
                    {
                        clsRTViewpointBL.CheckPropertyNew(objRTViewpoint);
                        objRTViewpoint.Memo = objRTConceptRela.ConceptId;
                        strWhere = $"{conRTViewpoint.SubViewpointId} = '{objRTViewpoint.SubViewpointId}' and {conRTViewpoint.TopicId} = '{objRTConceptRela.TopicId}'";
                        if (clsRTViewpointBL.IsExistRecord(strWhere) == false)
                        {
                            clsRTViewpointBL.AddNewRecordBySql2(objRTViewpoint);
                        }
                        else
                        {
                            objRTViewpoint.UpdateWithCondition(strWhere);
                        }
                    }
                    //catch (Exception ex)
                    catch
                    {
                        continue;
                    }
                }

                objConceptEN.Memo = objPaperSubViewpointEN.SubViewpointId.ToString();
                objConceptEN.Update();
                iCount++;
            }
            return iCount;
        }
        public static clsPaperSubViewpointEN GetObjByConcept(clsConceptEN objConceptEN)
        {
            try
            {
                clsPaperSubViewpointEN objPaperSubViewpointENT = new clsPaperSubViewpointEN();
                //objPaperSubViewpointENT.SubViewpointId = GetMaxStrId_S(); //objConceptEN.SubViewpointId; //子观点Id

                while (clsString.getStrLenS(objConceptEN.ConceptName) > 499)
                {
                    int intLen = objConceptEN.ConceptName.Length;
                    objConceptEN.ConceptName = objConceptEN.ConceptName.Substring(0, intLen - 2);
                }
                objPaperSubViewpointENT.SubViewpointContent = objConceptEN.ConceptName; //详情内容
                                                                                        //objPaperSubViewpointENT.PaperRWId = objConceptEN.PaperRWId; //课文阅读
                objPaperSubViewpointENT.PaperId = objConceptEN.CitationId;//论文Id
                objPaperSubViewpointENT.IdCurrEduCls = objConceptEN.IdCurrEduCls; //教学班流水号
                objPaperSubViewpointENT.UserId = objConceptEN.UpdUser;//.UserId; //用户ID
                                                                      //objPaperSubViewpointENT.SectionId = objConceptEN.SectionId; //节Id
                objPaperSubViewpointENT.SubViewpointTypeId = "00000000";// objConceptEN.SubViewpointTypeId; //类型Id
                objPaperSubViewpointENT.gsKnowledgeTypeId = enumgs_KnowledgeType.Concept_03;//
                objPaperSubViewpointENT.ExplainTypeId = enumExplainType.ExplanationOrDescription_01;
                if (objConceptEN.ConceptContent == null)
                {
                    objPaperSubViewpointENT.ExplainContent = "";
                }
                else
                {
                    while (clsString.getStrLenS(objConceptEN.ConceptContent) > 4999)
                    {
                        int intLen = objConceptEN.ConceptContent.Length;
                        objConceptEN.ConceptContent = objConceptEN.ConceptContent.Substring(0, intLen - 2);
                    }
                    objPaperSubViewpointENT.ExplainContent = objConceptEN.ConceptContent; //说明内容
                }                                                               //objPaperSubViewpointENT.IsPublic = objConceptEN.IsPublic; //是否公开
                                                                                //objPaperSubViewpointENT.LiteratureSourcesId = objConceptEN.LiteratureSourcesId; //文献来源
                objPaperSubViewpointENT.PageNumber = objConceptEN.PdfPageNum; //页码
                                                                              //objPaperSubViewpointENT.OrderNum = objConceptEN.OrderNum; //序号
                objPaperSubViewpointENT.PdfContent = objConceptEN.PdfContent; //Pdf内容
                                                                              //objPaperSubViewpointENT.selectSpanRange = objConceptEN.selectSpanRange; //选择Span范围
                                                                              //objPaperSubViewpointENT.PaperLineNum = objConceptEN.PaperLineNum; //论文行号
                                                                              //objPaperSubViewpointENT.PaperPageNum = objConceptEN.PaperPageNum; //论文页码
                objPaperSubViewpointENT.AppraiseCount = objConceptEN.AppraiseCount; //评论数
                objPaperSubViewpointENT.OkCount = objConceptEN.OkCount; //点赞统计
                objPaperSubViewpointENT.Score = objConceptEN.Score; //评分
                objPaperSubViewpointENT.StuScore = objConceptEN.StuScore; //学生平均分
                objPaperSubViewpointENT.TeaScore = objConceptEN.TeaScore; //教师评分
                objPaperSubViewpointENT.CreateDate = objConceptEN.CreateDate; //建立日期
                objPaperSubViewpointENT.ShareId = objConceptEN.ShareId; //分享Id
                                                                        //objPaperSubViewpointENT.TopicId = objConceptEN.TopicId; //主题Id
                                                                        //objPaperSubViewpointENT.AttitudesId = objConceptEN.AttitudesId; //态度Id
                objPaperSubViewpointENT.UpdDate = objConceptEN.UpdDate; //修改日期
                objPaperSubViewpointENT.UpdUser = objConceptEN.UpdUser; //修改人
                objPaperSubViewpointENT.Memo = objConceptEN.ConceptId; //备注
                return objPaperSubViewpointENT;
            }
            catch (Exception objEx)
            {
                throw new Exception(objEx.Message);
            }
        }


        public static int ImportSysSkill()
        {
            List<clsSysSkillEN> arrViewpoint = clsSysSkillBL.GetObjLst("1=1");
            int iCount = 0;
            foreach (var objSysSkillEN in arrViewpoint)
            {
                long strSubViewpointId = 0;
                clsPaperSubViewpointEN objPaperSubViewpointEN = GetObjBySysSkill(objSysSkillEN);
                if (objPaperSubViewpointEN.PaperId == null) { objPaperSubViewpointEN.PaperId = "00000000"; }
                if (objPaperSubViewpointEN.PaperId == "") { objPaperSubViewpointEN.PaperId = "00000000"; }

                string strWhere2 = "";
                try
                {
                    clsPaperSubViewpointBL.CheckPropertyNew(objPaperSubViewpointEN);
                    strWhere2 = $"{conPaperSubViewpoint.SubViewpointContent} = '{objPaperSubViewpointEN.SubViewpointContent}' and {conPaperSubViewpoint.UserId} = '{objPaperSubViewpointEN.UserId}'";


                    if (clsPaperSubViewpointBL.IsExistRecord(strWhere2) == true)
                    {
                        strSubViewpointId = clsPaperSubViewpointBL.GetFirstID_S(strWhere2);
                        objPaperSubViewpointEN.SetSubViewpointId(strSubViewpointId);
                        objPaperSubViewpointEN.UpdateWithCondition(strWhere2);
                    }
                    else
                    {
                        clsPaperSubViewpointBL.AddNewRecordBySql2(objPaperSubViewpointEN);
                        strSubViewpointId = objPaperSubViewpointEN.SubViewpointId;
                    }


                }
                catch (Exception objEx)
                {
                    strSubViewpointId = long.Parse(objSysSkillEN.Memo);
                    objSysSkillEN.Memo = objEx.Message.Substring(0, 498);
                    objSysSkillEN.Update();
                    continue;
                }
                string strWhere = $"{conRTSysSkillRela.SkillId} = '{objSysSkillEN.SkillId}'";
                List<clsRTSysSkillRelaEN> arrRela = clsRTSysSkillRelaBL.GetObjLst(strWhere);
                foreach (clsRTSysSkillRelaEN objRTSysSkillRela in arrRela)
                {
                    var objRTViewpoint = clsRTViewpointBLEx.GetObjByRTSysSkillRela(objRTSysSkillRela, strSubViewpointId);

                    try
                    {
                        clsRTViewpointBL.CheckPropertyNew(objRTViewpoint);
                        objRTViewpoint.Memo = objRTSysSkillRela.SkillId;
                        strWhere = $"{conRTViewpoint.SubViewpointId} = '{objRTViewpoint.SubViewpointId}' and {conRTViewpoint.TopicId} = '{objRTSysSkillRela.TopicId}'";
                        if (clsRTViewpointBL.IsExistRecord(strWhere) == false)
                        {
                            clsRTViewpointBL.AddNewRecordBySql2(objRTViewpoint);
                        }
                        else
                        {
                            objRTViewpoint.UpdateWithCondition(strWhere);
                        }
                    }
                    //catch (Exception ex)
                    catch
                    {
                        continue;
                    }
                }

                objSysSkillEN.Memo = objPaperSubViewpointEN.SubViewpointId.ToString();
                objSysSkillEN.Update();
                iCount++;
            }
            return iCount;
        }
        public static clsPaperSubViewpointEN GetObjBySysSkill(clsSysSkillEN objSysSkillEN)
        {
            try
            {
                clsPaperSubViewpointEN objPaperSubViewpointENT = new clsPaperSubViewpointEN();
                //objPaperSubViewpointENT.SubViewpointId = GetMaxStrId_S(); //objSysSkillEN.SubViewpointId; //子观点Id

                while (clsString.getStrLenS(objSysSkillEN.SkillName) > 499)
                {
                    int intLen = objSysSkillEN.SkillName.Length;
                    objSysSkillEN.SkillName = objSysSkillEN.SkillName.Substring(0, intLen - 2);
                }
                objPaperSubViewpointENT.SubViewpointContent = objSysSkillEN.SkillName; //详情内容
                                                                                       //objPaperSubViewpointENT.PaperRWId = objSysSkillEN.PaperRWId; //课文阅读
                objPaperSubViewpointENT.PaperId = objSysSkillEN.CitationId;//论文Id
                objPaperSubViewpointENT.IdCurrEduCls = objSysSkillEN.IdCurrEduCls; //教学班流水号
                objPaperSubViewpointENT.UserId = objSysSkillEN.UpdUser;//.UserId; //用户ID
                                                                       //objPaperSubViewpointENT.SectionId = objSysSkillEN.SectionId; //节Id
                objPaperSubViewpointENT.SubViewpointTypeId = "00000000";// objSysSkillEN.SubViewpointTypeId; //类型Id
                objPaperSubViewpointENT.gsKnowledgeTypeId = enumgs_KnowledgeType.Skill_06;//
                objPaperSubViewpointENT.ExplainTypeId = enumExplainType.ExplanationOrDescription_01;
                if (objSysSkillEN.Process == null)
                {
                    objPaperSubViewpointENT.ExplainContent = "";
                }
                else
                {
                    while (clsString.getStrLenS(objSysSkillEN.Process) > 4999)
                    {
                        int intLen = objSysSkillEN.Process.Length;
                        objSysSkillEN.Process = objSysSkillEN.Process.Substring(0, intLen - 2);
                    }
                    objPaperSubViewpointENT.ExplainContent = objSysSkillEN.Process; //说明内容

                }                                                               //objPaperSubViewpointENT.IsPublic = objSysSkillEN.IsPublic; //是否公开
                objPaperSubViewpointENT.OperationTypeId = objSysSkillEN.OperationTypeId;
                objPaperSubViewpointENT.LevelId = objSysSkillEN.LevelId;

                //objPaperSubViewpointENT.LiteratureSourcesId = objSysSkillEN.LiteratureSourcesId; //文献来源
                objPaperSubViewpointENT.PageNumber = objSysSkillEN.PdfPageNum; //页码
                                                                               //objPaperSubViewpointENT.OrderNum = objSysSkillEN.OrderNum; //序号
                objPaperSubViewpointENT.PdfContent = objSysSkillEN.PdfContent; //Pdf内容
                                                                               //objPaperSubViewpointENT.selectSpanRange = objSysSkillEN.selectSpanRange; //选择Span范围
                                                                               //objPaperSubViewpointENT.PaperLineNum = objSysSkillEN.PaperLineNum; //论文行号
                                                                               //objPaperSubViewpointENT.PaperPageNum = objSysSkillEN.PaperPageNum; //论文页码
                objPaperSubViewpointENT.AppraiseCount = objSysSkillEN.AppraiseCount; //评论数
                objPaperSubViewpointENT.OkCount = objSysSkillEN.OkCount; //点赞统计
                objPaperSubViewpointENT.Score = objSysSkillEN.Score; //评分
                objPaperSubViewpointENT.StuScore = objSysSkillEN.StuScore; //学生平均分
                objPaperSubViewpointENT.TeaScore = objSysSkillEN.TeaScore; //教师评分
                objPaperSubViewpointENT.CreateDate = objSysSkillEN.CreateDate; //建立日期
                objPaperSubViewpointENT.ShareId = objSysSkillEN.ShareId; //分享Id
                                                                         //objPaperSubViewpointENT.TopicId = objSysSkillEN.TopicId; //主题Id
                                                                         //objPaperSubViewpointENT.AttitudesId = objSysSkillEN.AttitudesId; //态度Id
                objPaperSubViewpointENT.UpdDate = objSysSkillEN.UpdDate; //修改日期
                objPaperSubViewpointENT.UpdUser = objSysSkillEN.UpdUser; //修改人
                objPaperSubViewpointENT.Memo = objSysSkillEN.SkillId; //备注
                return objPaperSubViewpointENT;
            }
            catch (Exception objEx)
            {
                throw new Exception(objEx.Message);
            }
        }



        public static int ImportTopicObjective()
        {
            List<clsTopicObjectiveEN> arrViewpoint = clsTopicObjectiveBL.GetObjLst("1=1");
            int iCount = 0;
            foreach (var objTopicObjectiveEN in arrViewpoint)
            {
                long strSubViewpointId = 0;
                clsPaperSubViewpointEN objPaperSubViewpointEN = GetObjByTopicObjective(objTopicObjectiveEN);
                if (objPaperSubViewpointEN.PaperId == null) { objPaperSubViewpointEN.PaperId = "00000000"; }
                if (objPaperSubViewpointEN.PaperId == "") { objPaperSubViewpointEN.PaperId = "00000000"; }

                string strWhere2 = "";
                try
                {
                    clsPaperSubViewpointBL.CheckPropertyNew(objPaperSubViewpointEN);
                    strWhere2 = $"{conPaperSubViewpoint.SubViewpointContent} = '{objPaperSubViewpointEN.SubViewpointContent}' and {conPaperSubViewpoint.UserId} = '{objPaperSubViewpointEN.UserId}'";


                    if (clsPaperSubViewpointBL.IsExistRecord(strWhere2) == true)
                    {
                        strSubViewpointId = clsPaperSubViewpointBL.GetFirstID_S(strWhere2);
                        objPaperSubViewpointEN.SetSubViewpointId(strSubViewpointId);
                        objPaperSubViewpointEN.UpdateWithCondition(strWhere2);
                    }
                    else
                    {
                        clsPaperSubViewpointBL.AddNewRecordBySql2(objPaperSubViewpointEN);
                        strSubViewpointId = objPaperSubViewpointEN.SubViewpointId;
                    }


                }
                catch (Exception objEx)
                {
                    strSubViewpointId = long.Parse(objTopicObjectiveEN.Memo);
                    if (objEx.Message.Length > 499)
                    {
                        objTopicObjectiveEN.Memo = objEx.Message.Substring(0, 498);
                    }
                    else
                    {
                        objTopicObjectiveEN.Memo = objEx.Message;
                    }
                    objTopicObjectiveEN.Update();
                    continue;
                }
                string strWhere = $"{conRTTopicObjectiveRela.TopicObjectiveId} = '{objTopicObjectiveEN.TopicObjectiveId}'";
                List<clsRTTopicObjectiveRelaEN> arrRela = clsRTTopicObjectiveRelaBL.GetObjLst(strWhere);
                foreach (clsRTTopicObjectiveRelaEN objRTTopicObjectiveRela in arrRela)
                {
                    var objRTViewpoint = clsRTViewpointBLEx.GetObjByRTTopicObjectiveRela(objRTTopicObjectiveRela, strSubViewpointId, objPaperSubViewpointEN.gsKnowledgeTypeId);

                    try
                    {
                        clsRTViewpointBL.CheckPropertyNew(objRTViewpoint);
                        objRTViewpoint.Memo = objRTTopicObjectiveRela.TopicObjectiveId;
                        strWhere = $"{conRTViewpoint.SubViewpointId} = '{objRTViewpoint.SubViewpointId}' and {conRTViewpoint.TopicId} = '{objRTTopicObjectiveRela.TopicId}'";
                        if (clsRTViewpointBL.IsExistRecord(strWhere) == false)
                        {
                            clsRTViewpointBL.AddNewRecordBySql2(objRTViewpoint);
                        }
                        else
                        {
                            objRTViewpoint.UpdateWithCondition(strWhere);
                        }
                    }
                    //catch (Exception ex)
                    catch
                    {
                        continue;
                    }
                }

                objTopicObjectiveEN.Memo = objPaperSubViewpointEN.SubViewpointId.ToString();
                objTopicObjectiveEN.Update();
                iCount++;
            }
            return iCount;
        }
        public static clsPaperSubViewpointEN GetObjByTopicObjective(clsTopicObjectiveEN objTopicObjectiveEN)
        {
            try
            {
                clsPaperSubViewpointEN objPaperSubViewpointENT = new clsPaperSubViewpointEN();
                //objPaperSubViewpointENT.SubViewpointId = GetMaxStrId_S(); //objTopicObjectiveEN.SubViewpointId; //子观点Id

                while (clsString.getStrLenS(objTopicObjectiveEN.ObjectiveName) > 499)
                {
                    int intLen = objTopicObjectiveEN.ObjectiveName.Length;
                    objTopicObjectiveEN.ObjectiveName = objTopicObjectiveEN.ObjectiveName.Substring(0, intLen - 2);
                }
                objPaperSubViewpointENT.SubViewpointContent = objTopicObjectiveEN.ObjectiveName; //详情内容
                objPaperSubViewpointENT.Conclusion = objTopicObjectiveEN.Conclusion; //详情内容
                                                                                     //objPaperSubViewpointENT.PaperRWId = objTopicObjectiveEN.PaperRWId; //课文阅读
                objPaperSubViewpointENT.PaperId = objTopicObjectiveEN.SourceId;//论文Id
                objPaperSubViewpointENT.IdCurrEduCls = objTopicObjectiveEN.IdCurrEduCls; //教学班流水号
                objPaperSubViewpointENT.UserId = objTopicObjectiveEN.UpdUser;//.UserId; //用户ID
                                                                             //objPaperSubViewpointENT.SectionId = objTopicObjectiveEN.SectionId; //节Id
                objPaperSubViewpointENT.SubViewpointTypeId = "00000000";// objTopicObjectiveEN.SubViewpointTypeId; //类型Id
                objPaperSubViewpointENT.gsKnowledgeTypeId = enumgs_KnowledgeType.Skill_06;//

                objPaperSubViewpointENT.gsKnowledgeTypeId = enumgs_KnowledgeType.ObjectiveFact_04;//
                if (objTopicObjectiveEN.ObjectiveType == "02") objPaperSubViewpointENT.gsKnowledgeTypeId = enumgs_KnowledgeType.ObjectiveData_05;//


                objPaperSubViewpointENT.ExplainTypeId = enumExplainType.ExplanationOrDescription_01;
                if (objTopicObjectiveEN.ObjectiveContent == null)
                {
                    objPaperSubViewpointENT.ExplainContent = "";
                }
                else
                {
                    while (clsString.getStrLenS(objTopicObjectiveEN.ObjectiveContent) > 4999)
                    {
                        int intLen = objTopicObjectiveEN.ObjectiveContent.Length;
                        objTopicObjectiveEN.ObjectiveContent = objTopicObjectiveEN.ObjectiveContent.Substring(0, intLen - 2);
                    }
                    objPaperSubViewpointENT.ExplainContent = objTopicObjectiveEN.ObjectiveContent; //说明内容

                }
                //objPaperSubViewpointENT.OperationTypeId = objTopicObjectiveEN.OperationTypeId;
                //objPaperSubViewpointENT.LevelId = objTopicObjectiveEN.LevelId;

                //objPaperSubViewpointENT.LiteratureSourcesId = objTopicObjectiveEN.LiteratureSourcesId; //文献来源
                objPaperSubViewpointENT.PageNumber = objTopicObjectiveEN.PdfPageNum; //页码
                                                                                     //objPaperSubViewpointENT.OrderNum = objTopicObjectiveEN.OrderNum; //序号
                objPaperSubViewpointENT.PdfContent = objTopicObjectiveEN.PdfContent; //Pdf内容
                                                                                     //objPaperSubViewpointENT.selectSpanRange = objTopicObjectiveEN.selectSpanRange; //选择Span范围
                                                                                     //objPaperSubViewpointENT.PaperLineNum = objTopicObjectiveEN.PaperLineNum; //论文行号
                                                                                     //objPaperSubViewpointENT.PaperPageNum = objTopicObjectiveEN.PaperPageNum; //论文页码
                objPaperSubViewpointENT.AppraiseCount = objTopicObjectiveEN.AppraiseCount; //评论数
                objPaperSubViewpointENT.OkCount = objTopicObjectiveEN.OkCount; //点赞统计
                objPaperSubViewpointENT.Score = objTopicObjectiveEN.Score; //评分
                objPaperSubViewpointENT.StuScore = objTopicObjectiveEN.StuScore; //学生平均分
                objPaperSubViewpointENT.TeaScore = objTopicObjectiveEN.TeaScore; //教师评分
                objPaperSubViewpointENT.CreateDate = objTopicObjectiveEN.CreateDate; //建立日期
                objPaperSubViewpointENT.ShareId = objTopicObjectiveEN.ShareId; //分享Id
                if (objPaperSubViewpointENT.ShareId == null) objPaperSubViewpointENT.ShareId = "01";
                //objPaperSubViewpointENT.TopicId = objTopicObjectiveEN.TopicId; //主题Id
                //objPaperSubViewpointENT.AttitudesId = objTopicObjectiveEN.AttitudesId; //态度Id
                objPaperSubViewpointENT.UpdDate = objTopicObjectiveEN.UpdDate; //修改日期
                objPaperSubViewpointENT.UpdUser = objTopicObjectiveEN.UpdUser; //修改人
                objPaperSubViewpointENT.Memo = objTopicObjectiveEN.TopicObjectiveId; //备注
                return objPaperSubViewpointENT;
            }
            catch (Exception objEx)
            {
                throw new Exception(objEx.Message);
            }
        }



        public static int ImportSysSocialRelations()
        {
            List<clsSysSocialRelationsEN> arrViewpoint = clsSysSocialRelationsBL.GetObjLst("1=1");
            int iCount = 0;
            foreach (var objSysSocialRelationsEN in arrViewpoint)
            {
                long strSubViewpointId = 0;
                clsPaperSubViewpointEN objPaperSubViewpointEN = GetObjBySysSocialRelations(objSysSocialRelationsEN);
                if (objPaperSubViewpointEN.PaperId == null) { objPaperSubViewpointEN.PaperId = "00000000"; }
                if (objPaperSubViewpointEN.PaperId == "") { objPaperSubViewpointEN.PaperId = "00000000"; }

                string strWhere2 = "";
                try
                {
                    clsPaperSubViewpointBL.CheckPropertyNew(objPaperSubViewpointEN);
                    strWhere2 = $"{conPaperSubViewpoint.SubViewpointContent} = '{objPaperSubViewpointEN.SubViewpointContent}' and {conPaperSubViewpoint.UserId} = '{objPaperSubViewpointEN.UserId}'";


                    if (clsPaperSubViewpointBL.IsExistRecord(strWhere2) == true)
                    {
                        strSubViewpointId = clsPaperSubViewpointBL.GetFirstID_S(strWhere2);
                        objPaperSubViewpointEN.SetSubViewpointId(strSubViewpointId);
                        objPaperSubViewpointEN.UpdateWithCondition(strWhere2);
                    }
                    else
                    {
                        clsPaperSubViewpointBL.AddNewRecordBySql2(objPaperSubViewpointEN);
                        strSubViewpointId = objPaperSubViewpointEN.SubViewpointId;
                    }


                }
                catch (Exception objEx)
                {
                    strSubViewpointId = long.Parse(objSysSocialRelationsEN.Memo);
                    if (objEx.Message.Length > 499)
                    {
                        objSysSocialRelationsEN.Memo = objEx.Message.Substring(0, 498);
                    }
                    else
                    {
                        objSysSocialRelationsEN.Memo = objEx.Message;
                    }
                    objSysSocialRelationsEN.Update();
                    continue;
                }
                string strWhere = $"{conRTSysSocialRela.SocialId} = '{objSysSocialRelationsEN.SocialId}'";
                List<clsRTSysSocialRelaEN> arrRela = clsRTSysSocialRelaBL.GetObjLst(strWhere);
                foreach (clsRTSysSocialRelaEN objRTSysSocialRela in arrRela)
                {
                    var objRTViewpoint = clsRTViewpointBLEx.GetObjByRTSysSocialRela(objRTSysSocialRela, strSubViewpointId);

                    try
                    {
                        clsRTViewpointBL.CheckPropertyNew(objRTViewpoint);
                        objRTViewpoint.Memo = objRTSysSocialRela.SocialId;
                        strWhere = $"{conRTViewpoint.SubViewpointId} = '{objRTViewpoint.SubViewpointId}' and {conRTViewpoint.TopicId} = '{objRTSysSocialRela.TopicId}'";
                        if (clsRTViewpointBL.IsExistRecord(strWhere) == false)
                        {
                            clsRTViewpointBL.AddNewRecordBySql2(objRTViewpoint);
                        }
                        else
                        {
                            objRTViewpoint.UpdateWithCondition(strWhere);
                        }
                    }
                    //catch (Exception ex)
                    catch
                    {
                        continue;
                    }
                }

                objSysSocialRelationsEN.Memo = objPaperSubViewpointEN.SubViewpointId.ToString();
                objSysSocialRelationsEN.Update();
                iCount++;
            }
            return iCount;
        }
        public static clsPaperSubViewpointEN GetObjBySysSocialRelations(clsSysSocialRelationsEN objSysSocialRelationsEN)
        {
            try
            {
                clsPaperSubViewpointEN objPaperSubViewpointENT = new clsPaperSubViewpointEN();
                //objPaperSubViewpointENT.SubViewpointId = GetMaxStrId_S(); //objSysSocialRelationsEN.SubViewpointId; //子观点Id

                while (clsString.getStrLenS(objSysSocialRelationsEN.FullName) > 499)
                {
                    int intLen = objSysSocialRelationsEN.FullName.Length;
                    objSysSocialRelationsEN.FullName = objSysSocialRelationsEN.FullName.Substring(0, intLen - 2);
                }
                objPaperSubViewpointENT.SubViewpointContent = objSysSocialRelationsEN.FullName; //详情内容
                                                                                                //objPaperSubViewpointENT.Conclusion = objSysSocialRelationsEN.Conclusion; //详情内容
                                                                                                //objPaperSubViewpointENT.PaperRWId = objSysSocialRelationsEN.PaperRWId; //课文阅读
                objPaperSubViewpointENT.PaperId = objSysSocialRelationsEN.CitationId;//论文Id
                objPaperSubViewpointENT.IdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls; //教学班流水号
                objPaperSubViewpointENT.UserId = objSysSocialRelationsEN.UpdUser;//.UserId; //用户ID
                                                                                 //objPaperSubViewpointENT.SectionId = objSysSocialRelationsEN.SectionId; //节Id
                objPaperSubViewpointENT.SubViewpointTypeId = "00000000";// objSysSocialRelationsEN.SubViewpointTypeId; //类型Id
                objPaperSubViewpointENT.gsKnowledgeTypeId = enumgs_KnowledgeType.SocialRelationships_07;//


                objPaperSubViewpointENT.Nationality = objSysSocialRelationsEN.Nationality;//
                objPaperSubViewpointENT.WorkUnit = objSysSocialRelationsEN.WorkUnit;//
                objPaperSubViewpointENT.Major = objSysSocialRelationsEN.Major;//
                objPaperSubViewpointENT.Achievement = objSysSocialRelationsEN.Achievement;//

                objPaperSubViewpointENT.ExplainTypeId = enumExplainType.ExplanationOrDescription_01;
                if (objSysSocialRelationsEN.DetailedDescription == null)
                {
                    objPaperSubViewpointENT.ExplainContent = "";
                }
                else
                {
                    while (clsString.getStrLenS(objSysSocialRelationsEN.DetailedDescription) > 4999)
                    {
                        int intLen = objSysSocialRelationsEN.DetailedDescription.Length;
                        objSysSocialRelationsEN.DetailedDescription = objSysSocialRelationsEN.DetailedDescription.Substring(0, intLen - 2);
                    }
                    objPaperSubViewpointENT.ExplainContent = objSysSocialRelationsEN.DetailedDescription; //说明内容

                }
                //objPaperSubViewpointENT.OperationTypeId = objSysSocialRelationsEN.OperationTypeId;
                //objPaperSubViewpointENT.LevelId = objSysSocialRelationsEN.LevelId;

                //objPaperSubViewpointENT.LiteratureSourcesId = objSysSocialRelationsEN.LiteratureSourcesId; //文献来源
                objPaperSubViewpointENT.PageNumber = objSysSocialRelationsEN.PdfPageNum; //页码
                                                                                         //objPaperSubViewpointENT.OrderNum = objSysSocialRelationsEN.OrderNum; //序号
                objPaperSubViewpointENT.PdfContent = objSysSocialRelationsEN.PdfContent; //Pdf内容
                                                                                         //objPaperSubViewpointENT.selectSpanRange = objSysSocialRelationsEN.selectSpanRange; //选择Span范围
                                                                                         //objPaperSubViewpointENT.PaperLineNum = objSysSocialRelationsEN.PaperLineNum; //论文行号
                                                                                         //objPaperSubViewpointENT.PaperPageNum = objSysSocialRelationsEN.PaperPageNum; //论文页码
                objPaperSubViewpointENT.AppraiseCount = objSysSocialRelationsEN.AppraiseCount; //评论数
                objPaperSubViewpointENT.OkCount = objSysSocialRelationsEN.OkCount; //点赞统计
                objPaperSubViewpointENT.Score = objSysSocialRelationsEN.Score; //评分
                objPaperSubViewpointENT.StuScore = objSysSocialRelationsEN.StuScore; //学生平均分
                objPaperSubViewpointENT.TeaScore = objSysSocialRelationsEN.TeaScore; //教师评分
                objPaperSubViewpointENT.CreateDate = objSysSocialRelationsEN.CreateDate; //建立日期
                objPaperSubViewpointENT.ShareId = objSysSocialRelationsEN.ShareId; //分享Id
                if (objPaperSubViewpointENT.ShareId == null) objPaperSubViewpointENT.ShareId = "01";
                //objPaperSubViewpointENT.TopicId = objSysSocialRelationsEN.TopicId; //主题Id
                //objPaperSubViewpointENT.AttitudesId = objSysSocialRelationsEN.AttitudesId; //态度Id
                objPaperSubViewpointENT.UpdDate = objSysSocialRelationsEN.UpdDate; //修改日期
                objPaperSubViewpointENT.UpdUser = objSysSocialRelationsEN.UpdUser; //修改人
                objPaperSubViewpointENT.Memo = objSysSocialRelationsEN.SocialId; //备注
                return objPaperSubViewpointENT;
            }
            catch (Exception objEx)
            {
                throw new Exception(objEx.Message);
            }
        }

    }
}