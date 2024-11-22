
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_UserCreditsTtlBLEx
表名:ge_UserCreditsTtl(01120884)
生成代码版本:2021.02.21.1
生成日期:2021/02/24 18:51:06
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:游戏化学习
模块英文名:GameLearn
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
using com.taishsoft.datetime;

namespace ExamLib.BusinessLogicEx
{
    public static class clsge_UserCreditsTtlBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_UserCreditsTtlENS">源对象</param>
        /// <returns>目标对象=>clsge_UserCreditsTtlEN:objge_UserCreditsTtlENT</returns>
        public static clsge_UserCreditsTtlENEx CopyToEx(this clsge_UserCreditsTtlEN objge_UserCreditsTtlENS)
        {
            try
            {
                clsge_UserCreditsTtlENEx objge_UserCreditsTtlENT = new clsge_UserCreditsTtlENEx();
                clsge_UserCreditsTtlBL.ge_UserCreditsTtlDA.CopyTo(objge_UserCreditsTtlENS, objge_UserCreditsTtlENT);
                return objge_UserCreditsTtlENT;
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
        /// <param name = "objge_UserCreditsTtlENS">源对象</param>
        /// <returns>目标对象=>clsge_UserCreditsTtlEN:objge_UserCreditsTtlENT</returns>
        public static clsge_UserCreditsTtlEN CopyTo(this clsge_UserCreditsTtlENEx objge_UserCreditsTtlENS)
        {
            try
            {
                clsge_UserCreditsTtlEN objge_UserCreditsTtlENT = new clsge_UserCreditsTtlEN();
                clsge_UserCreditsTtlBL.CopyTo(objge_UserCreditsTtlENS, objge_UserCreditsTtlENT);
                return objge_UserCreditsTtlENT;
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
    /// 用户积分汇总(ge_UserCreditsTtl)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_UserCreditsTtlBLEx : clsge_UserCreditsTtlBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_UserCreditsTtlDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_UserCreditsTtlDAEx ge_UserCreditsTtlDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_UserCreditsTtlDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_UserCreditsTtlENS">源对象</param>
        /// <returns>目标对象=>clsge_UserCreditsTtlEN:objge_UserCreditsTtlENT</returns>
        public static clsge_UserCreditsTtlENEx CopyToEx(clsge_UserCreditsTtlEN objge_UserCreditsTtlENS)
        {
            try
            {
                clsge_UserCreditsTtlENEx objge_UserCreditsTtlENT = new clsge_UserCreditsTtlENEx();
                clsge_UserCreditsTtlBL.ge_UserCreditsTtlDA.CopyTo(objge_UserCreditsTtlENS, objge_UserCreditsTtlENT);
                return objge_UserCreditsTtlENT;
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
        public static List<clsge_UserCreditsTtlENEx> GetObjExLst(string strCondition)
        {
            List<clsge_UserCreditsTtlEN> arrObjLst = clsge_UserCreditsTtlBL.GetObjLst(strCondition);
            List<clsge_UserCreditsTtlENEx> arrObjExLst = new List<clsge_UserCreditsTtlENEx>();
            foreach (clsge_UserCreditsTtlEN objInFor in arrObjLst)
            {
                clsge_UserCreditsTtlENEx objge_UserCreditsTtlENEx = new clsge_UserCreditsTtlENEx();
                clsge_UserCreditsTtlBL.CopyTo(objInFor, objge_UserCreditsTtlENEx);
                arrObjExLst.Add(objge_UserCreditsTtlENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_UserCreditsTtlENEx GetObjExBymId(long lngmId)
        {
            clsge_UserCreditsTtlEN objge_UserCreditsTtlEN = clsge_UserCreditsTtlBL.GetObjBymId(lngmId);
            clsge_UserCreditsTtlENEx objge_UserCreditsTtlENEx = new clsge_UserCreditsTtlENEx();
            clsge_UserCreditsTtlBL.CopyTo(objge_UserCreditsTtlEN, objge_UserCreditsTtlENEx);
            return objge_UserCreditsTtlENEx;
        }
        /// <summary>
        /// 汇总每个教学班用户的积分
        /// </summary>
        /// <param name="strIdCurrEduCls"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static bool CalcCreditTtl(string strIdCurrEduCls, string strOpUser)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            //clsge_UserCreditsLogBLEx.CalcUserLevelScore(strIdCurrEduCls, strOpUser);

            string strCondition0 = string.Format("{0}='{1}'", conge_UserLevelScore.IdCurrEduCls, strIdCurrEduCls);
            var arrge_UserLevelScore = clsge_UserLevelScoreBL.GetObjLst(strCondition0);

            var arrge_UserLevelScore_Group = arrge_UserLevelScore.GroupBy(x => new { x.UserId }).ToList();

            //foreach (var list in Lists)
            //{
            //    Console.WriteLine(list.Key + ":");
            //    foreach (var lis in list)
            //    {
            //        Console.WriteLine($"{lis.Country} - {lis.City} - {lis.Name}");
            //    }
            //}

            foreach (var list in arrge_UserLevelScore_Group)
            {
                Console.WriteLine(list.Key + ":");
                foreach (var objInfor in list)
                {
                    int intCount = arrge_UserLevelScore.Where(x => x.UserId == objInfor.UserId).Sum(x => x.Credits);

                    clsge_UserCreditsTtlEN objge_UserCreditsTtl = new clsge_UserCreditsTtlEN();
                    objge_UserCreditsTtl.IdCurrEduCls = strIdCurrEduCls;
                    objge_UserCreditsTtl.UserId = objInfor.UserId;
                    objge_UserCreditsTtl.CreditsNum = list.Sum(x => x.Credits);
                    //objge_UserCreditsTtl.CourseChapterId = objge_GameLevel.cou.
                    objge_UserCreditsTtl.UpdDate = strCurrDate;
                    objge_UserCreditsTtl.UpdUser = strOpUser;
                    string strCondition = objge_UserCreditsTtl.GetUniCondStr();
                    if (clsge_UserCreditsTtlBL.IsExistRecord(strCondition) == false)
                    {
                        objge_UserCreditsTtl.AddNewRecord();
                    }
                    else
                    {
                        objge_UserCreditsTtl.UpdateWithCondition(strCondition);
                    }
                }
            }

            return true;
        }


        public static bool CalcCreditTtlByUserId(string strIdCurrEduCls, string strUserId, string strOpUser)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            //clsge_UserCreditsLogBLEx.CalcUserLevelScoreByUserId(strIdCurrEduCls, strUserId, strOpUser);

            string strCondition0 = string.Format("{0}='{1}'", conge_UserLevelScore.IdCurrEduCls, strIdCurrEduCls);
            strCondition0 += string.Format(" and {0}='{1}'", conge_UserLevelScore.UserId, strUserId);
            var arrge_UserLevelScore = clsge_UserLevelScoreBL.GetObjLst(strCondition0);

            //var arrge_UserLevelScore_Group = arrge_UserLevelScore.GroupBy(x => new { x.UserId }).ToList();

            //foreach (var list in arrge_UserLevelScore_Group)
            //{
            //    Console.WriteLine(list.Key + ":");
            //    foreach (var objInfor in list)
            //    {
            int intCreditsSum = arrge_UserLevelScore.Sum(x => x.Credits);
            int intCount = arrge_UserLevelScore.Where(x => x.UserId == strUserId).Sum(x => x.Credits);

            clsge_UserCreditsTtlEN objge_UserCreditsTtl = new clsge_UserCreditsTtlEN();
            objge_UserCreditsTtl.IdCurrEduCls = strIdCurrEduCls;
            objge_UserCreditsTtl.UserId = strUserId;
            objge_UserCreditsTtl.CreditsNum = intCreditsSum;
            //objge_UserCreditsTtl.CourseChapterId = objge_GameLevel.cou.
            objge_UserCreditsTtl.UpdDate = strCurrDate;
            objge_UserCreditsTtl.UpdUser = strOpUser;
            string strCondition = objge_UserCreditsTtl.GetUniCondStr();
            if (clsge_UserCreditsTtlBL.IsExistRecord(strCondition) == false)
            {
                objge_UserCreditsTtl.AddNewRecord();
            }
            else
            {
                objge_UserCreditsTtl.UpdateWithCondition(strCondition);
            }
            //    }
            //}

            return true;
        }

    }
}