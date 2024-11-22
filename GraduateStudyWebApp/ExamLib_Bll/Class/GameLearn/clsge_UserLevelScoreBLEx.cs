
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_UserLevelScoreBLEx
表名:ge_UserLevelScore(01120942)
* 版本:2022.12.23.1(服务器:WIN-SRV103-116)
日期:2022/12/30 17:19:14
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:游戏化学习(GameLearn)
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
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_ge_UserLevelScoreEx : RelatedActions_ge_UserLevelScore
    {
        public override bool UpdRelaTabDate(string stridCurrEduCls, string strGameLevelId, string strUserId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsge_UserLevelScoreBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_UserLevelScoreENS">源对象</param>
        /// <returns>目标对象=>clsge_UserLevelScoreEN:objge_UserLevelScoreENT</returns>
        public static clsge_UserLevelScoreENEx CopyToEx(this clsge_UserLevelScoreEN objge_UserLevelScoreENS)
        {
            try
            {
                clsge_UserLevelScoreENEx objge_UserLevelScoreENT = new clsge_UserLevelScoreENEx();
                clsge_UserLevelScoreBL.ge_UserLevelScoreDA.CopyTo(objge_UserLevelScoreENS, objge_UserLevelScoreENT);
                return objge_UserLevelScoreENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objge_UserLevelScoreENS">源对象</param>
        /// <returns>目标对象=>clsge_UserLevelScoreEN:objge_UserLevelScoreENT</returns>
        public static clsge_UserLevelScoreEN CopyTo(this clsge_UserLevelScoreENEx objge_UserLevelScoreENS)
        {
            try
            {
                clsge_UserLevelScoreEN objge_UserLevelScoreENT = new clsge_UserLevelScoreEN();
                clsge_UserLevelScoreBL.CopyTo(objge_UserLevelScoreENS, objge_UserLevelScoreENT);
                return objge_UserLevelScoreENT;
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
    /// 用户闯关得分(ge_UserLevelScore)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_UserLevelScoreBLEx : clsge_UserLevelScoreBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_UserLevelScoreDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_UserLevelScoreDAEx ge_UserLevelScoreDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_UserLevelScoreDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_UserLevelScoreENS">源对象</param>
        /// <returns>目标对象=>clsge_UserLevelScoreEN:objge_UserLevelScoreENT</returns>
        public static clsge_UserLevelScoreENEx CopyToEx(clsge_UserLevelScoreEN objge_UserLevelScoreENS)
        {
            try
            {
                clsge_UserLevelScoreENEx objge_UserLevelScoreENT = new clsge_UserLevelScoreENEx();
                clsge_UserLevelScoreBL.ge_UserLevelScoreDA.CopyTo(objge_UserLevelScoreENS, objge_UserLevelScoreENT);
                return objge_UserLevelScoreENT;
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
        public static List<clsge_UserLevelScoreENEx> GetObjExLst(string strCondition)
        {
            List<clsge_UserLevelScoreEN> arrObjLst = clsge_UserLevelScoreBL.GetObjLst(strCondition);
            List<clsge_UserLevelScoreENEx> arrObjExLst = new List<clsge_UserLevelScoreENEx>();
            foreach (clsge_UserLevelScoreEN objInFor in arrObjLst)
            {
                clsge_UserLevelScoreENEx objge_UserLevelScoreENEx = new clsge_UserLevelScoreENEx();
                clsge_UserLevelScoreBL.CopyTo(objInFor, objge_UserLevelScoreENEx);
                arrObjExLst.Add(objge_UserLevelScoreENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "stridCurrEduCls">表关键字</param>
        /// <param name = "strGameLevelId">表关键字</param>
        /// <param name = "strUserId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_UserLevelScoreENEx GetObjExByKeyLst(string stridCurrEduCls, string strGameLevelId, string strUserId)
        {
            clsge_UserLevelScoreEN objge_UserLevelScoreEN = clsge_UserLevelScoreBL.GetObjByKeyLst(stridCurrEduCls, strGameLevelId, strUserId);
            clsge_UserLevelScoreENEx objge_UserLevelScoreENEx = new clsge_UserLevelScoreENEx();
            clsge_UserLevelScoreBL.CopyTo(objge_UserLevelScoreEN, objge_UserLevelScoreENEx);
            return objge_UserLevelScoreENEx;
        }
        public static bool CalcUserLevelScore(clsge_UserCreditsLogEN objge_UserCreditsLog, string strOpUser)
        {

            string strCondition = string.Format("{0}='{1}'", conge_UserLevelScore.IdCurrEduCls, objge_UserCreditsLog.IdCurrEduCls);
            strCondition += string.Format(" and {0}='{1}'", conge_UserLevelScore.GameLevelId, objge_UserCreditsLog.GameLevelId);
            strCondition += string.Format(" and {0}='{1}'", conge_UserLevelScore.UserId, objge_UserCreditsLog.UserId);
            clsge_UserLevelScoreEN objge_UserLevelScore = clsge_UserLevelScoreBL.GetFirstObj_S(strCondition);
            if (objge_UserLevelScore == null)
            {
                objge_UserLevelScore = new clsge_UserLevelScoreEN();
                objge_UserLevelScore.SetIdCurrEduCls(objge_UserCreditsLog.IdCurrEduCls)
                    .SetGameLevelId(objge_UserCreditsLog.GameLevelId)
                    .SetUserId(objge_UserCreditsLog.UserId)
                    .SetCredits(objge_UserCreditsLog.Credits ?? 0)
                    .SetCourseId(objge_UserCreditsLog.CourseId)
                    .SetGetDate(objge_UserCreditsLog.GetDate)
                    .SetGetInstructions(objge_UserCreditsLog.GetInstructions)
                    .SetPassed(objge_UserCreditsLog.Passed)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                    .SetUpdUser(strOpUser)
                    .AddNewRecord();
                return true;
            }
            else
            {
                if (objge_UserCreditsLog.Credits <= objge_UserLevelScore.Credits) return true;
                objge_UserLevelScore
                    .SetCredits(objge_UserCreditsLog.Credits ?? 0)
                    .SetGetDate(objge_UserCreditsLog.GetDate)
                    .SetGetInstructions(objge_UserCreditsLog.GetInstructions)
                    .SetPassed(objge_UserCreditsLog.Passed)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                    .SetUpdUser(strOpUser)
                    .Update();
                return true;
            }
        }

        public static bool CalcUserLevelScore(string stridCurrEduCls, string strOpUser)
        {

            string strCondition = string.Format("{0}='{1}'", conge_UserCreditsLog.IdCurrEduCls, stridCurrEduCls);
            clsge_UserLevelScoreBL.SetFldValue(conge_UserLevelScore._CurrTabName, conge_UserLevelScore.Credits, 0, strCondition);
            List<clsge_UserCreditsLogEN> arrObjLst = clsge_UserCreditsLogBL.GetObjLst(strCondition);

            foreach (var objInFor in arrObjLst)
            {
                if (objInFor == null) continue;
                clsge_UserLevelScoreBLEx.CalcUserLevelScore(objInFor, strOpUser);
            }
            return true;
        }
        public static bool CalcUserLevelScoreByUserId(string strGameLevelId, string stridCurrEduCls, string strUserId, string strOpUser)
        {
            List<clsge_UserCreditsLogEN> arrObjLst = new List<clsge_UserCreditsLogEN>();

            string strCondition = string.Format("{0}='{1}'", conge_UserCreditsLog.IdCurrEduCls, stridCurrEduCls);
            strCondition += string.Format(" and {0}='{1}'", conge_UserCreditsLog.UserId, strUserId);
            strCondition += string.Format(" and {0}='{1}'", conge_UserCreditsLog.GameLevelId, strGameLevelId);
            clsge_UserLevelScoreBL.SetFldValue(conge_UserLevelScore._CurrTabName, conge_UserLevelScore.Credits, 0, strCondition);
            arrObjLst = clsge_UserCreditsLogBL.GetObjLst(strCondition);

            foreach (var objInFor in arrObjLst)
            {
                if (objInFor == null) continue;
                CalcUserLevelScore(objInFor, strOpUser);
            }
            return true;
        }

        public static bool CalcUserLevelScoreByGameLevelId(string stridCurrEduCls, string strUserId, string strGameLevelId, string strOpUser)
        {
            List<clsge_UserCreditsLogEN> arrObjLst = new List<clsge_UserCreditsLogEN>();

            string strCondition = string.Format("{0}='{1}'", conge_UserCreditsLog.IdCurrEduCls, stridCurrEduCls);
            strCondition += string.Format(" and {0}='{1}'", conge_UserCreditsLog.UserId, strUserId);
            strCondition += string.Format(" and {0}='{1}'", conge_UserCreditsLog.GameLevelId, strGameLevelId);
            clsge_UserLevelScoreBL.SetFldValue(conge_UserLevelScore._CurrTabName, conge_UserLevelScore.Credits, 0, strCondition);

            arrObjLst = clsge_UserCreditsLogBL.GetObjLst(strCondition);

            foreach (var objInFor in arrObjLst)
            {
                if (objInFor == null) continue;
                CalcUserLevelScore(objInFor, strOpUser);
            }
            return true;
        }


        public static bool CalcUserLevelScoreByGameLevelIdUserId(string stridCurrEduCls, string strGameLevelId, string strUserId, string strOpUser)
        {

            string strCondition = string.Format("{0}='{1}'", conge_UserCreditsLog.IdCurrEduCls, stridCurrEduCls);
            strCondition += $" and {conge_UserCreditsLog.GameLevelId} = '{strGameLevelId}'";
            strCondition += $" and {conge_UserCreditsLog.UserId} = '{strUserId}'";
            strCondition += $" order by {conge_UserCreditsLog.Credits} desc";
            //clsge_UserLevelScoreBL.SetFldValue(conge_UserLevelScore._CurrTabName, conge_UserLevelScore.Credits, 0, strCondition);
            clsge_UserCreditsLogEN objge_UserCreditsLog = clsge_UserCreditsLogBL.GetFirstObj_S(strCondition);
            if (objge_UserCreditsLog == null) throw new Exception($"游戏关:{strGameLevelId}没有做过相关的题目！");
            //clsge_GameLevelEN objge_GameLevel = clsge_GameLevelBL.GetObjByGameLevelIdCache(strGameLevelId, objge_UserCreditsLog.CourseId);

            strCondition = string.Format("{0}='{1}'", conge_UserLevelScore.IdCurrEduCls, stridCurrEduCls);
            strCondition += string.Format(" and {0}='{1}'", conge_UserLevelScore.GameLevelId, strGameLevelId);
            strCondition += string.Format(" and {0}='{1}'", conge_UserLevelScore.UserId, strUserId);
            clsge_UserLevelScoreEN objge_UserLevelScore = clsge_UserLevelScoreBL.GetFirstObj_S(strCondition);
            if (objge_UserLevelScore == null)
            {
                objge_UserLevelScore = new clsge_UserLevelScoreEN();
                objge_UserLevelScore.SetIdCurrEduCls(stridCurrEduCls)
                    .SetGameLevelId(strGameLevelId)
                    .SetUserId(strUserId)
                    .SetCredits(objge_UserCreditsLog.Credits ?? 0)
                    .SetCourseId(objge_UserCreditsLog.CourseId)
                    .SetGetDate(objge_UserCreditsLog.GetDate)
                    .SetGetInstructions(objge_UserCreditsLog.GetInstructions)
                    .SetPassed(objge_UserCreditsLog.Passed)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                    .SetUpdUser(strOpUser)
                    .AddNewRecord();
                return true;
            }
            else
            {
                if (objge_UserCreditsLog.Credits <= objge_UserLevelScore.Credits) return true;
                objge_UserLevelScore
                    .SetCredits(objge_UserCreditsLog.Credits ?? 0)
                    .SetGetDate(objge_UserCreditsLog.GetDate)
                    .SetGetInstructions(objge_UserCreditsLog.GetInstructions)
                    .SetPassed(objge_UserCreditsLog.Passed)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                    .SetUpdUser(strOpUser)
                    .Update();
                return true;
            }

        }





    }
}