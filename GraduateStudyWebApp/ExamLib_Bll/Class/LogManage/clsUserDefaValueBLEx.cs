
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUserDefaValueBLEx
表名:UserDefaValue(01120203)
生成代码版本:2022.11.12.1
生成日期:2022/11/15 00:58:52
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:日志管理(LogManage)
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
    public class RelatedActions_UserDefaValueEx : RelatedActions_UserDefaValue
    {
        public override bool UpdRelaTabDate(long lngmId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsUserDefaValueBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objUserDefaValueENS">源对象</param>
        /// <returns>目标对象=>clsUserDefaValueEN:objUserDefaValueENT</returns>
        public static clsUserDefaValueENEx CopyToEx(this clsUserDefaValueEN objUserDefaValueENS)
        {
            try
            {
                clsUserDefaValueENEx objUserDefaValueENT = new clsUserDefaValueENEx();
                clsUserDefaValueBL.UserDefaValueDA.CopyTo(objUserDefaValueENS, objUserDefaValueENT);
                return objUserDefaValueENT;
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
        /// <param name = "objUserDefaValueENS">源对象</param>
        /// <returns>目标对象=>clsUserDefaValueEN:objUserDefaValueENT</returns>
        public static clsUserDefaValueEN CopyTo(this clsUserDefaValueENEx objUserDefaValueENS)
        {
            try
            {
                clsUserDefaValueEN objUserDefaValueENT = new clsUserDefaValueEN();
                clsUserDefaValueBL.CopyTo(objUserDefaValueENS, objUserDefaValueENT);
                return objUserDefaValueENT;
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
    /// 用户缺省值(UserDefaValue)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsUserDefaValueBLEx : clsUserDefaValueBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsUserDefaValueDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsUserDefaValueDAEx UserDefaValueDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsUserDefaValueDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objUserDefaValueENS">源对象</param>
        /// <returns>目标对象=>clsUserDefaValueEN:objUserDefaValueENT</returns>
        public static clsUserDefaValueENEx CopyToEx(clsUserDefaValueEN objUserDefaValueENS)
        {
            try
            {
                clsUserDefaValueENEx objUserDefaValueENT = new clsUserDefaValueENEx();
                clsUserDefaValueBL.UserDefaValueDA.CopyTo(objUserDefaValueENS, objUserDefaValueENT);
                return objUserDefaValueENT;
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
        public static List<clsUserDefaValueENEx> GetObjExLst(string strCondition)
        {
            List<clsUserDefaValueEN> arrObjLst = clsUserDefaValueBL.GetObjLst(strCondition);
            List<clsUserDefaValueENEx> arrObjExLst = new List<clsUserDefaValueENEx>();
            foreach (clsUserDefaValueEN objInFor in arrObjLst)
            {
                clsUserDefaValueENEx objUserDefaValueENEx = new clsUserDefaValueENEx();
                clsUserDefaValueBL.CopyTo(objInFor, objUserDefaValueENEx);
                arrObjExLst.Add(objUserDefaValueENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsUserDefaValueENEx GetObjExBymId(long lngmId)
        {
            clsUserDefaValueEN objUserDefaValueEN = clsUserDefaValueBL.GetObjBymId(lngmId);
            clsUserDefaValueENEx objUserDefaValueENEx = new clsUserDefaValueENEx();
            clsUserDefaValueBL.CopyTo(objUserDefaValueEN, objUserDefaValueENEx);
            return objUserDefaValueENEx;
        }


        /// <summary>
        /// 获取用户缺省值
        /// </summary>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strCurrSelPrjId">当前用户选择的工程Id</param>
        /// <param name="strUserId"></param>
        /// <param name="strDefaValName"></param>
        /// <returns></returns>
        public static string getUserDefaValue(string strUserId, string strDefaValName)
        {
            //操作步骤:
            //1、根据缺省值名称()获取相应的编号(DefaValNameId)；如果不存在该编号，说明该缺省值不存在，返回空值。
            //2、根据用户ID()和编号(DefaValNameId)到用户缺省值表去查找相应的记录以便获取相应缺省值名称的缺省值，
            //  并返回此值。
            //3、如果不存在相应的缺省值，就根据缺省值编号到系统缺省值表()去查找系统定义的缺省值，并返回该值。

            List<string> arrLst = new List<string>();
            StringBuilder strCondition = new StringBuilder();
            string strDefaValNameId;
            string strUserDefaValue;
            //操作步骤的实现:
            //1、根据缺省值名称()获取相应的编号(DefaValNameId)；如果不存在该编号，说明该缺省值不存在，返回空值。
            strCondition.AppendFormat("DefaValName = '{0}'", strDefaValName);
            arrLst = clsSysDefaValNameBL.GetFldValue("DefaValNameId", strCondition.ToString());
            if (arrLst.Count == 0) return "";
            strDefaValNameId = arrLst[0].ToString();
            //2、根据用户ID()和编号(DefaValNameId)到用户缺省值表去查找相应的记录以便获取相应缺省值名称的缺省值，
            //  并返回此值。
            strCondition = new StringBuilder();
            strCondition.AppendFormat("UserId = '{0}'", strUserId);
            strCondition.AppendFormat(" and DefaValNameId = '{0}'", strDefaValNameId);
            //strCondition.AppendFormat(" and {0} = '{1}'", conUserDefaValue.PrjId, strCurrSelPrjId);
            arrLst = clsUserDefaValueBL.GetFldValue("UserDefaValue", strCondition.ToString());
            if (arrLst.Count > 0)
            {
                strUserDefaValue = arrLst[0].ToString();
                return strUserDefaValue;
            }

            //3、如果不存在相应的缺省值，就根据缺省值编号到系统缺省值表()去查找系统定义的缺省值，并返回该值。
            strCondition = new StringBuilder();
            strCondition.AppendFormat("DefaValNameId = '{0}'", strDefaValNameId);
            arrLst = clsSysDefaValNameBL.GetFldValue("SysDefaValue", strCondition.ToString());
            strUserDefaValue = arrLst[0].ToString();
            return strUserDefaValue;
        }

        /// <summary>
        /// 设置用户默认值
        /// </summary>
        /// <param name = "strCurrPrjId">当前工程</param>
        /// <param name = "strCurrSelPrjId">当前用户选择的工程Id</param>
        /// <param name = "strUserId"></param>
        /// <param name = "strDefaValName"></param>
        /// <param name = "strUserDefaValue"></param>
        /// <returns></returns>
        public static bool setUserDefaValue(string strUserId, string strDefaValName, string strUserDefaValue)
        {
            //操作步骤:
            //1、根据缺省值名称()获取相应的编号(DefaValNameId)；如果不存在该编号，说明该缺省值不存在，返回空值。
            //2、根据用户ID()和编号(DefaValNameId)到用户缺省值表去查找相应的记录以便获取相应缺省值名称的缺省值，
            //  并返回此值。
            //3、如果不存在相应的缺省值，就根据缺省值编号到系统缺省值表()去查找系统定义的缺省值，并返回该值。

            List<string> arrLst = new List<string>();
            StringBuilder strCondition = new StringBuilder();
            string strDefaValNameId;
            //string strUserDefaValue;
            //操作步骤的实现:
            //1、根据缺省值名称()获取相应的编号(DefaValNameId)；如果不存在该编号，说明该缺省值不存在，返回空值。
            strCondition.AppendFormat("{0} = '{1}'", conSysDefaValName.DefaValName, strDefaValName);
            List<clsSysDefaValNameEN> arrSysDefaValNameObjLst_Sel = clsSysDefaValNameBLEx.GetAllSysDefaValNameObjLst_CacheEx(strDefaValName);
            if (arrSysDefaValNameObjLst_Sel.Count == 0)
            {
                string strMsg = string.Format("在系统默认值名称中，没有默认值名:{0}, 请检查!({1})",
                    strDefaValName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            strDefaValNameId = arrSysDefaValNameObjLst_Sel[0].DefaValNameId;
            //2、根据用户ID()和编号(DefaValNameId)到用户缺省值表去查找相应的记录以便获取相应缺省值名称的缺省值，
            //  并返回此值。
            strCondition = new StringBuilder();
            strCondition.AppendFormat("UserId = '{0}'", strUserId);
            strCondition.AppendFormat(" and DefaValNameId = '{0}'", strDefaValNameId);
            List<clsUserDefaValueEN> arrUserDefaValueObjLst_Sel = GetAllUserDefaValueObjLst_CacheEx(strUserId, strDefaValNameId);
            if (arrUserDefaValueObjLst_Sel.Count > 0)
            {
                clsUserDefaValueEN objUserDefaValueEN = arrUserDefaValueObjLst_Sel[0];
                if (objUserDefaValueEN.UserDefaValue == strUserDefaValue) return true;
                objUserDefaValueEN.UserDefaValue = strUserDefaValue;
                objUserDefaValueEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objUserDefaValueEN.UpdUser = strUserId;
                clsUserDefaValueBL.UpdateBySql2(objUserDefaValueEN);
                return true;
            }
            else
            {
                clsUserDefaValueEN objUserDefaValueEN = new clsUserDefaValueEN();
                //objUserDefaValueEN.PrjId = strCurrSelPrjId;
                objUserDefaValueEN.UserId = strUserId;

                objUserDefaValueEN.DefaValNameId = strDefaValNameId;
                objUserDefaValueEN.UserDefaValue = strUserDefaValue;
                objUserDefaValueEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objUserDefaValueEN.UpdUser = strUserId;
                clsUserDefaValueBL.AddNewRecordBySql2(objUserDefaValueEN);
                return true;
            }

        }
        /// <summary>
        /// 从缓存中获取所有正在使用的用户缺省值对象列表.
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <param name = "strUserId"></param>
        /// <param name = "strDefaValNameId"></param>
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsUserDefaValueEN> GetAllUserDefaValueObjLst_CacheEx(string strUserId, string strDefaValNameId)
        {
            List<clsUserDefaValueEN> arrObjLst_Cache = clsUserDefaValueBL.GetObjLstCache();
            List<clsUserDefaValueEN> arrUserDefaValueObjLst = new List<clsUserDefaValueEN>();
            List<clsUserDefaValueEN> arrUserDefaValueObjLst_Sel =
                arrObjLst_Cache.Where(x => x.UserId == strUserId && x.DefaValNameId == strDefaValNameId).ToList();
            return arrUserDefaValueObjLst_Sel;
        }

    }
}