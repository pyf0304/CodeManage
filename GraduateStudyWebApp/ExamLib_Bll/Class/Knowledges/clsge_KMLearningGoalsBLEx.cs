
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_KMLearningGoalsBLEx
表名:ge_KMLearningGoals(01120960)
* 版本:2024.02.19.1(服务器:WIN-SRV103-116)
日期:2024/03/05 02:30:21
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关(Knowledges)
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
using com.taishsoft.datetime;

namespace ExamLib.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_ge_KMLearningGoalsEx : RelatedActions_ge_KMLearningGoals
    {
        public override bool UpdRelaTabDate(string strUserId, string strKnowledgeModuleId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsge_KMLearningGoalsBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_KMLearningGoalsENS">源对象</param>
        /// <returns>目标对象=>clsge_KMLearningGoalsEN:objge_KMLearningGoalsENT</returns>
        public static clsge_KMLearningGoalsENEx CopyToEx(this clsge_KMLearningGoalsEN objge_KMLearningGoalsENS)
        {
            try
            {
                clsge_KMLearningGoalsENEx objge_KMLearningGoalsENT = new clsge_KMLearningGoalsENEx();
                clsge_KMLearningGoalsBL.ge_KMLearningGoalsDA.CopyTo(objge_KMLearningGoalsENS, objge_KMLearningGoalsENT);
                return objge_KMLearningGoalsENT;
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
        /// <param name = "objge_KMLearningGoalsENS">源对象</param>
        /// <returns>目标对象=>clsge_KMLearningGoalsEN:objge_KMLearningGoalsENT</returns>
        public static clsge_KMLearningGoalsEN CopyTo(this clsge_KMLearningGoalsENEx objge_KMLearningGoalsENS)
        {
            try
            {
                clsge_KMLearningGoalsEN objge_KMLearningGoalsENT = new clsge_KMLearningGoalsEN();
                clsge_KMLearningGoalsBL.CopyTo(objge_KMLearningGoalsENS, objge_KMLearningGoalsENT);
                return objge_KMLearningGoalsENT;
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
    /// 知识点模块学习目标(ge_KMLearningGoals)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_KMLearningGoalsBLEx : clsge_KMLearningGoalsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_KMLearningGoalsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_KMLearningGoalsDAEx ge_KMLearningGoalsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_KMLearningGoalsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_KMLearningGoalsENS">源对象</param>
        /// <returns>目标对象=>clsge_KMLearningGoalsEN:objge_KMLearningGoalsENT</returns>
        public static clsge_KMLearningGoalsENEx CopyToEx(clsge_KMLearningGoalsEN objge_KMLearningGoalsENS)
        {
            try
            {
                clsge_KMLearningGoalsENEx objge_KMLearningGoalsENT = new clsge_KMLearningGoalsENEx();
                clsge_KMLearningGoalsBL.ge_KMLearningGoalsDA.CopyTo(objge_KMLearningGoalsENS, objge_KMLearningGoalsENT);
                return objge_KMLearningGoalsENT;
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
        public static List<clsge_KMLearningGoalsENEx> GetObjExLst(string strCondition)
        {
            List<clsge_KMLearningGoalsEN> arrObjLst = clsge_KMLearningGoalsBL.GetObjLst(strCondition);
            List<clsge_KMLearningGoalsENEx> arrObjExLst = new List<clsge_KMLearningGoalsENEx>();
            foreach (clsge_KMLearningGoalsEN objInFor in arrObjLst)
            {
                clsge_KMLearningGoalsENEx objge_KMLearningGoalsENEx = new clsge_KMLearningGoalsENEx();
                clsge_KMLearningGoalsBL.CopyTo(objInFor, objge_KMLearningGoalsENEx);
                arrObjExLst.Add(objge_KMLearningGoalsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strUserId">表关键字</param>
        /// <param name = "strKnowledgeModuleId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_KMLearningGoalsENEx GetObjExByKeyLst(string strUserId, string strKnowledgeModuleId)
        {
            clsge_KMLearningGoalsEN objge_KMLearningGoalsEN = clsge_KMLearningGoalsBL.GetObjByKeyLst(strUserId, strKnowledgeModuleId);
            clsge_KMLearningGoalsENEx objge_KMLearningGoalsENEx = new clsge_KMLearningGoalsENEx();
            clsge_KMLearningGoalsBL.CopyTo(objge_KMLearningGoalsEN, objge_KMLearningGoalsENEx);
            return objge_KMLearningGoalsENEx;
        }
        public static int InitUserKnowledge(string strCourseId, string strUserId)
        {
            string strCondition = $"{concc_KnowledgeModules.CourseId} = '{strCourseId}' and {concc_KnowledgeModules.KnowledgeModuleId} not in (select {conge_KMLearningGoals.KnowledgeModuleId} from {conge_KMLearningGoals._CurrTabName} where {conge_KMLearningGoals.UserId} = '{strUserId}' and {conge_KMLearningGoals.CourseId} = '{strCourseId}')";
            var arrcc_KnowledgeModules = clscc_KnowledgeModulesBL.GetObjLst(strCondition);
            if (arrcc_KnowledgeModules.Count == 0) return 0;
            foreach (var objInFor in arrcc_KnowledgeModules)
            {
                var obj = clscc_KnowledgeModulesBL.GetObjByKnowledgeModuleId(objInFor.KnowledgeModuleId);
                if (obj.CourseId != strCourseId)
                {
                    throw new Exception($"初始化用户知识点模块时，知识点课程与所给课程不一致，请检查！");
                }
                clsge_KMLearningGoalsEN objge_KMLearningGoals = new clsge_KMLearningGoalsEN();
                objge_KMLearningGoals.UserId = strUserId;
                objge_KMLearningGoals.CourseId = strCourseId;
                objge_KMLearningGoals.KnowledgeModuleId = objInFor.KnowledgeModuleId;
                objge_KMLearningGoals.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objge_KMLearningGoals.UpdUser = strUserId;
                objge_KMLearningGoals.AddNewRecord();
            }
            return arrcc_KnowledgeModules.Count;
        }

        public static int CalcUserMasteryValue(string strCourseId, string strUserId)
        {
            InitUserKnowledge(strCourseId, strUserId);
            string strCondition = $"{conge_KMLearningGoals.CourseId} = '{strCourseId}' ";
        
            var arrcc_CourseKnowledges = clscc_CourseKnowledgesBL.GetObjLst(strCondition);

            string strCondition_User = $"{conge_KnowledgesUserMaster.CourseId} = '{strCourseId}' " +
                                       $" and { conge_KnowledgesUserMaster.UserId} = '{strUserId}'";
            var arrge_KnowledgesUserMaster = clsge_KnowledgesUserMasterBL.GetObjLst(strCondition_User);
            var arrge_KMLearningGoals = clsge_KMLearningGoalsBL.GetObjLst(strCondition_User);

            if (arrge_KMLearningGoals.Count == 0) return 0;
            foreach (var objInFor in arrge_KMLearningGoals)
            {
                var objcc_KnowledgeModules = clscc_KnowledgeModulesBL.GetObjByKnowledgeModuleIdCache(objInFor.KnowledgeModuleId);

                var arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges.Where(x=>x.KnowledgeModuleId == objInFor.KnowledgeModuleId).ToList();
                double dblTotal = arrcc_CourseKnowledges_Sel.Sum(x => x.ModuleWeight) ?? 0;
                if (dblTotal > 1)
                {
                    string strMsg = $"知识点模块:{objcc_KnowledgeModules.KnowledgeModuleName}的相关知识点的权重百分比总和超过100%，请检查！";
                    throw new Exception(strMsg);
                }
                if (dblTotal<1)
                {
                    var arrcc_CourseKnowledges_SelSub = arrcc_CourseKnowledges_Sel.Where(x => x.ModuleWeight == 0 || x.ModuleWeight == null).ToList();
                    if (arrcc_CourseKnowledges_SelSub.Count == 0)
                    {
                        string strMsg = $"知识点模块:{objcc_KnowledgeModules.KnowledgeModuleName}的相关知识点的权重百分比总和小于100%，请检查！";
                        throw new Exception(strMsg);
                    }
                    double dblShortfall = 1 - dblTotal ;
                    double dblShortfall_Per = dblShortfall / arrcc_CourseKnowledges_SelSub.Count;
                    foreach(var objSub in arrcc_CourseKnowledges_SelSub)
                    {
                        objSub.ModuleWeight = dblShortfall_Per;
                    }

                }
                double dblMasteryValue_M = 0;
                foreach(var objSub in arrcc_CourseKnowledges_Sel)
                {
                    var objge_KnowledgesUserMaster = arrge_KnowledgesUserMaster.Find(x=>x.CourseKnowledgeId == objSub.CourseKnowledgeId);
                    if (objge_KnowledgesUserMaster == null) continue;
                    double dblMasteryValue_K = objge_KnowledgesUserMaster.MasteryValue ?? 0.0;
                    double dblModuleWeight = objSub.ModuleWeight??0.0;
                    dblMasteryValue_M += dblMasteryValue_K * dblModuleWeight; 
                }
                objInFor.MasteryValue = dblMasteryValue_M;
                objInFor.UpdDate = clsDateTime.getTodayDateTimeStr(0);

                objInFor.Update();
            }
            return arrge_KMLearningGoals.Count;
        }

    }
}