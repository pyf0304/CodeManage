
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsRTViewpointBLEx
表名:RTViewpoint(01120955)
* 版本:2023.11.03.1(服务器:WIN-SRV103-116)
日期:2023/11/15 16:19:44
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题(GradEduTopic)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_RTViewpointEx : RelatedActions_RTViewpoint
    {
        public override bool UpdRelaTabDate(string strTopicId, long strSubViewpointId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsRTViewpointBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objRTViewpointENS">源对象</param>
        /// <returns>目标对象=>clsRTViewpointEN:objRTViewpointENT</returns>
        public static clsRTViewpointENEx CopyToEx(this clsRTViewpointEN objRTViewpointENS)
        {
            try
            {
                clsRTViewpointENEx objRTViewpointENT = new clsRTViewpointENEx();
                clsRTViewpointBL.RTViewpointDA.CopyTo(objRTViewpointENS, objRTViewpointENT);
                return objRTViewpointENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objRTViewpointENS">源对象</param>
        /// <returns>目标对象=>clsRTViewpointEN:objRTViewpointENT</returns>
        public static clsRTViewpointEN CopyTo(this clsRTViewpointENEx objRTViewpointENS)
        {
            try
            {
                clsRTViewpointEN objRTViewpointENT = new clsRTViewpointEN();
                clsRTViewpointBL.CopyTo(objRTViewpointENS, objRTViewpointENT);
                return objRTViewpointENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 主题观点关系(RTViewpoint)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsRTViewpointBLEx : clsRTViewpointBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsRTViewpointDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsRTViewpointDAEx RTViewpointDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsRTViewpointDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objRTViewpointENS">源对象</param>
        /// <returns>目标对象=>clsRTViewpointEN:objRTViewpointENT</returns>
        public static clsRTViewpointENEx CopyToEx(clsRTViewpointEN objRTViewpointENS)
        {
            try
            {
                clsRTViewpointENEx objRTViewpointENT = new clsRTViewpointENEx();
                clsRTViewpointBL.RTViewpointDA.CopyTo(objRTViewpointENS, objRTViewpointENT);
                return objRTViewpointENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
        public static List<clsRTViewpointENEx> GetObjExLst(string strCondition)
        {
            List<clsRTViewpointEN> arrObjLst = clsRTViewpointBL.GetObjLst(strCondition);
            List<clsRTViewpointENEx> arrObjExLst = new List<clsRTViewpointENEx>();
            foreach (clsRTViewpointEN objInFor in arrObjLst)
            {
                clsRTViewpointENEx objRTViewpointENEx = new clsRTViewpointENEx();
                clsRTViewpointBL.CopyTo(objInFor, objRTViewpointENEx);
                arrObjExLst.Add(objRTViewpointENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTopicId">表关键字</param>
        /// <param name = "strSubViewpointId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsRTViewpointENEx GetObjExByKeyLst(string strTopicId, long strSubViewpointId)
        {
            clsRTViewpointEN objRTViewpointEN = clsRTViewpointBL.GetObjByKeyLst(strTopicId, strSubViewpointId);
            clsRTViewpointENEx objRTViewpointENEx = new clsRTViewpointENEx();
            clsRTViewpointBL.CopyTo(objRTViewpointEN, objRTViewpointENEx);
            return objRTViewpointENEx;
        }
        public static clsRTViewpointEN GetObjByRTViewpointRela(clsRTViewpointRelaEN objRTViewpointRelaENS, long strSubViewpointId, string strgsKnowledgeTypeId)
        {
            clsRTViewpointEN objRTViewpoinENT = new clsRTViewpointEN();

            objRTViewpoinENT.TopicId = objRTViewpointRelaENS.TopicId; //主题Id
            objRTViewpoinENT.SubViewpointId = strSubViewpointId; //观点Id
            objRTViewpoinENT.ProposePeople = objRTViewpointRelaENS.ProposePeople; //提出人
            objRTViewpoinENT.UpdDate = objRTViewpointRelaENS.UpdDate; //修改日期
            objRTViewpoinENT.UpdUser = objRTViewpointRelaENS.UpdUser; //修改人
            objRTViewpoinENT.Memo = objRTViewpointRelaENS.Memo; //备注
            objRTViewpoinENT.gsKnowledgeTypeId = strgsKnowledgeTypeId; //分类Id
            objRTViewpoinENT.ClassificationId = objRTViewpointRelaENS.ClassificationId; //分类Id
            objRTViewpoinENT.IdCurrEduCls = objRTViewpointRelaENS.IdCurrEduCls; //教学班流水号
            return objRTViewpoinENT;
        }

        public static clsRTViewpointEN GetObjByRTConceptRela(clsRTConceptRelaEN objRTConceptRela, long strSubViewpointId)
        {
            clsRTViewpointEN objRTViewpoinENT = new clsRTViewpointEN();

            objRTViewpoinENT.TopicId = objRTConceptRela.TopicId; //主题Id
            objRTViewpoinENT.SubViewpointId = strSubViewpointId; //观点Id
            objRTViewpoinENT.ProposePeople = objRTConceptRela.UpdUser; //提出人
            objRTViewpoinENT.UpdDate = objRTConceptRela.UpdDate; //修改日期
            objRTViewpoinENT.UpdUser = objRTConceptRela.UpdUser; //修改人
            objRTViewpoinENT.Memo = objRTConceptRela.Memo; //备注
            objRTViewpoinENT.gsKnowledgeTypeId = enumgs_KnowledgeType.Concept_03; //分类Id
            objRTViewpoinENT.ClassificationId = objRTConceptRela.ClassificationId; //分类Id
            objRTViewpoinENT.IdCurrEduCls = objRTConceptRela.IdCurrEduCls; //教学班流水号
            return objRTViewpoinENT;
        }

        public static clsRTViewpointEN GetObjByRTSysSkillRela(clsRTSysSkillRelaEN objRTSysSkillRela, long strSubViewpointId)
        {
            clsRTViewpointEN objRTViewpoinENT = new clsRTViewpointEN();

            objRTViewpoinENT.TopicId = objRTSysSkillRela.TopicId; //主题Id
            objRTViewpoinENT.SubViewpointId = strSubViewpointId; //观点Id
            objRTViewpoinENT.ProposePeople = objRTSysSkillRela.UpdUser; //提出人
            objRTViewpoinENT.UpdDate = objRTSysSkillRela.UpdDate; //修改日期
            objRTViewpoinENT.UpdUser = objRTSysSkillRela.UpdUser; //修改人
            objRTViewpoinENT.Memo = objRTSysSkillRela.Memo; //备注
            objRTViewpoinENT.gsKnowledgeTypeId = enumgs_KnowledgeType.Skill_06; //分类Id
            objRTViewpoinENT.ClassificationId = objRTSysSkillRela.ClassificationId; //分类Id
            objRTViewpoinENT.IdCurrEduCls = objRTSysSkillRela.IdCurrEduCls; //教学班流水号
            return objRTViewpoinENT;
        }

        public static clsRTViewpointEN GetObjByRTTopicObjectiveRela(clsRTTopicObjectiveRelaEN objRTTopicObjectiveRela, long strSubViewpointId, string strgsKnowledgeTypeId)
        {
            clsRTViewpointEN objRTViewpoinENT = new clsRTViewpointEN();

            objRTViewpoinENT.TopicId = objRTTopicObjectiveRela.TopicId; //主题Id
            objRTViewpoinENT.SubViewpointId = strSubViewpointId; //观点Id
            objRTViewpoinENT.ProposePeople = objRTTopicObjectiveRela.UpdUser; //提出人
            objRTViewpoinENT.UpdDate = objRTTopicObjectiveRela.UpdDate; //修改日期
            objRTViewpoinENT.UpdUser = objRTTopicObjectiveRela.UpdUser; //修改人
            objRTViewpoinENT.Memo = objRTTopicObjectiveRela.Memo; //备注
            objRTViewpoinENT.gsKnowledgeTypeId = strgsKnowledgeTypeId; //分类Id
            objRTViewpoinENT.ClassificationId =  objRTTopicObjectiveRela.ClassificationId; //分类Id
            objRTViewpoinENT.IdCurrEduCls = objRTTopicObjectiveRela.IdCurrEduCls; //教学班流水号
            return objRTViewpoinENT;
        }

        public static clsRTViewpointEN GetObjByRTSysSocialRela(clsRTSysSocialRelaEN objRTSysSocialRela, long strSubViewpointId)
        {
            clsRTViewpointEN objRTViewpoinENT = new clsRTViewpointEN();

            objRTViewpoinENT.TopicId = objRTSysSocialRela.TopicId; //主题Id
            objRTViewpoinENT.SubViewpointId = strSubViewpointId; //观点Id
            objRTViewpoinENT.ProposePeople = objRTSysSocialRela.UpdUser; //提出人
            objRTViewpoinENT.UpdDate = objRTSysSocialRela.UpdDate; //修改日期
            objRTViewpoinENT.UpdUser = objRTSysSocialRela.UpdUser; //修改人
            objRTViewpoinENT.Memo = objRTSysSocialRela.Memo; //备注
            objRTViewpoinENT.gsKnowledgeTypeId = enumgs_KnowledgeType.SocialRelationships_07; //分类Id
            objRTViewpoinENT.ClassificationId = objRTSysSocialRela.ClassificationId; //分类Id
            objRTViewpoinENT.IdCurrEduCls = objRTSysSocialRela.IdCurrEduCls; //教学班流水号
            return objRTViewpoinENT;
        }
        
    }
}