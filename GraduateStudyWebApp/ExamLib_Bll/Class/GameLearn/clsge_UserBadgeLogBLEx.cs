
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_UserBadgeLogBLEx
表名:ge_UserBadgeLog(01120881)
生成代码版本:2022.12.10.1
生成日期:2022/12/11 05:42:13
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
    public class RelatedActions_ge_UserBadgeLogEx : RelatedActions_ge_UserBadgeLog
    {
        public override bool UpdRelaTabDate(long lngmId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsge_UserBadgeLogBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_UserBadgeLogENS">源对象</param>
        /// <returns>目标对象=>clsge_UserBadgeLogEN:objge_UserBadgeLogENT</returns>
        public static clsge_UserBadgeLogENEx CopyToEx(this clsge_UserBadgeLogEN objge_UserBadgeLogENS)
        {
            try
            {
                clsge_UserBadgeLogENEx objge_UserBadgeLogENT = new clsge_UserBadgeLogENEx();
                clsge_UserBadgeLogBL.ge_UserBadgeLogDA.CopyTo(objge_UserBadgeLogENS, objge_UserBadgeLogENT);
                return objge_UserBadgeLogENT;
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
        /// <param name = "objge_UserBadgeLogENS">源对象</param>
        /// <returns>目标对象=>clsge_UserBadgeLogEN:objge_UserBadgeLogENT</returns>
        public static clsge_UserBadgeLogEN CopyTo(this clsge_UserBadgeLogENEx objge_UserBadgeLogENS)
        {
            try
            {
                clsge_UserBadgeLogEN objge_UserBadgeLogENT = new clsge_UserBadgeLogEN();
                clsge_UserBadgeLogBL.CopyTo(objge_UserBadgeLogENS, objge_UserBadgeLogENT);
                return objge_UserBadgeLogENT;
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
    /// 用户徽章日志(ge_UserBadgeLog)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_UserBadgeLogBLEx : clsge_UserBadgeLogBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_UserBadgeLogDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_UserBadgeLogDAEx ge_UserBadgeLogDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_UserBadgeLogDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_UserBadgeLogENS">源对象</param>
        /// <returns>目标对象=>clsge_UserBadgeLogEN:objge_UserBadgeLogENT</returns>
        public static clsge_UserBadgeLogENEx CopyToEx(clsge_UserBadgeLogEN objge_UserBadgeLogENS)
        {
            try
            {
                clsge_UserBadgeLogENEx objge_UserBadgeLogENT = new clsge_UserBadgeLogENEx();
                clsge_UserBadgeLogBL.ge_UserBadgeLogDA.CopyTo(objge_UserBadgeLogENS, objge_UserBadgeLogENT);
                return objge_UserBadgeLogENT;
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
        public static List<clsge_UserBadgeLogENEx> GetObjExLst(string strCondition)
        {
            List<clsge_UserBadgeLogEN> arrObjLst = clsge_UserBadgeLogBL.GetObjLst(strCondition);
            List<clsge_UserBadgeLogENEx> arrObjExLst = new List<clsge_UserBadgeLogENEx>();
            foreach (clsge_UserBadgeLogEN objInFor in arrObjLst)
            {
                clsge_UserBadgeLogENEx objge_UserBadgeLogENEx = new clsge_UserBadgeLogENEx();
                clsge_UserBadgeLogBL.CopyTo(objInFor, objge_UserBadgeLogENEx);
                arrObjExLst.Add(objge_UserBadgeLogENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_UserBadgeLogENEx GetObjExBymId(long lngmId)
        {
            clsge_UserBadgeLogEN objge_UserBadgeLogEN = clsge_UserBadgeLogBL.GetObjBymId(lngmId);
            clsge_UserBadgeLogENEx objge_UserBadgeLogENEx = new clsge_UserBadgeLogENEx();
            clsge_UserBadgeLogBL.CopyTo(objge_UserBadgeLogEN, objge_UserBadgeLogENEx);
            return objge_UserBadgeLogENEx;
        }

        /// <summary>
        /// 根据积分自动设置徽章
        /// </summary>
        /// <param name="strIdCurrEduCls"></param>
        /// <param name="strCourseId"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static bool ImportCreditBadge(string strIdCurrEduCls, string strCourseId, string strOpUser)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            var arrge_GameLevel = clsge_GameLevelBL.GetObjLstCache(strCourseId);
            foreach (var objge_GameLevel in arrge_GameLevel)
            {
                var arrge_UserCreditsLog = clsge_UserCreditsLogBL.GetObjLstCache(strIdCurrEduCls);
                var arrge_UserCreditsLog_Sel = arrge_UserCreditsLog.Where(x => x.GameLevelId == objge_GameLevel.GameLevelId).ToList();
                arrge_UserCreditsLog_Sel = arrge_UserCreditsLog_Sel.OrderByDescending(x => x.Credits).ToList();
                int intCount_Ttl = arrge_UserCreditsLog_Sel.Count();
                double dblCount_Badge = 0.3 * intCount_Ttl;
                int intCount_Badge = (int)Math.Round(dblCount_Badge);
                float fltCredit = arrge_UserCreditsLog_Sel[intCount_Badge].Credits ?? 0;
                if (fltCredit == 0) continue;
                var arrge_UserCreditsLog_Badge = arrge_UserCreditsLog_Sel.Where(x => x.Credits >= fltCredit).ToList();
                if (arrge_UserCreditsLog_Badge.Count() > 0) ClearBadge4GameLevel(strIdCurrEduCls, objge_GameLevel.GameLevelId);
                foreach (var objInfor in arrge_UserCreditsLog_Badge)
                {
                    objInfor.BadgeNum = 1;
                    objInfor.Update();
                    clsge_UserBadgeLogEN objge_UserBadgeLog = new clsge_UserBadgeLogEN();
                    objge_UserBadgeLog.IdCurrEduCls = strIdCurrEduCls;
                    objge_UserBadgeLog.BadgeTypeId = enumBadgeType.CreditBadge_01;
                    objge_UserBadgeLog.UserId = objInfor.UserId;
                    objge_UserBadgeLog.GameLevelId = objInfor.GameLevelId;
                    objge_UserBadgeLog.GetDate = strCurrDate;
                    objge_UserBadgeLog.GetInstructions = string.Format("积分处于前30%，不低于:{0}.", fltCredit);
                    //objge_UserBadgeLog.CourseChapterId = objge_GameLevel.cou.
                    objge_UserBadgeLog.UpdDate = strCurrDate;
                    objge_UserBadgeLog.UpdUser = strOpUser;
                    string strCondition = objge_UserBadgeLog.GetUniCondStr();
                    if (clsge_UserBadgeLogBL.IsExistRecord(strCondition) == false)
                    {
                        objge_UserBadgeLog.AddNewRecord();
                    }
                }
                var arrge_UserCreditsLog_Except = arrge_UserCreditsLog_Sel.Except(arrge_UserCreditsLog_Badge);
                foreach (var objInfor in arrge_UserCreditsLog_Badge)
                {
                    objInfor.BadgeNum = 0;
                    objInfor.Update();
                }
            }
            CalcBadgeTtl(strIdCurrEduCls, strOpUser);
            return true;
        }

        public static bool CalcBadgeTtl(string strIdCurrEduCls, string strOpUser)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            
            var arrge_UserBadgeLog = clsge_UserBadgeLogBL.GetObjLstCache(strIdCurrEduCls);

            var arrge_UserBadgeLog_Group = arrge_UserBadgeLog.GroupBy(x => new { x.UserId, x.BadgeTypeId }).ToList();

            //foreach (var list in Lists)
            //{
            //    Console.WriteLine(list.Key + ":");
            //    foreach (var lis in list)
            //    {
            //        Console.WriteLine($"{lis.Country} - {lis.City} - {lis.Name}");
            //    }
            //}

            foreach (var list in arrge_UserBadgeLog_Group)
            {
                Console.WriteLine(list.Key + ":");
                foreach (var objInfor in list)
                {
                    int intCount = arrge_UserBadgeLog.Count(x => x.UserId == objInfor.UserId && x.BadgeTypeId == objInfor.BadgeTypeId);

                    clsge_UserBadgeTtlEN objge_UserBadgeTtl = new clsge_UserBadgeTtlEN();
                    objge_UserBadgeTtl.IdCurrEduCls = strIdCurrEduCls;
                    objge_UserBadgeTtl.BadgeTypeId = objInfor.BadgeTypeId;
                    objge_UserBadgeTtl.UserId = objInfor.UserId;
                    objge_UserBadgeTtl.BadgeNum = list.Count();
                    //objge_UserBadgeTtl.CourseChapterId = objge_GameLevel.cou.
                    objge_UserBadgeTtl.UpdDate = strCurrDate;
                    objge_UserBadgeTtl.UpdUser = strOpUser;
                    string strCondition = objge_UserBadgeTtl.GetUniCondStr();
                    if (clsge_UserBadgeTtlBL.IsExistRecord(strCondition) == false)
                    {
                        objge_UserBadgeTtl.AddNewRecord();
                    }
                    else
                    {
                        objge_UserBadgeTtl.UpdateWithCondition(strCondition);
                    }
                }
            }

            return true;
        }

        public static bool ClearBadge4GameLevel(string strIdCurrEduCls, string strGameLevelId)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conge_UserBadgeLog.IdCurrEduCls, strIdCurrEduCls, conge_UserBadgeLog.GameLevelId, strGameLevelId);
            int intReturn = clsge_UserBadgeLogBL.Delge_UserBadgeLogsByCond(strCondition);
            return true;
        }
    }
}