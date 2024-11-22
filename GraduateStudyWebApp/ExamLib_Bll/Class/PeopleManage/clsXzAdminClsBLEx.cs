
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsXzAdminClsBLEx
表名:XzAdminCls(01120194)
生成代码版本:2021.08.17.1
生成日期:2021/08/19 23:17:45
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:人员管理
模块英文名:PeopleManage
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
    public static class clsXzAdminClsBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objXzAdminClsENS">源对象</param>
        /// <returns>目标对象=>clsXzAdminClsEN:objXzAdminClsENT</returns>
        public static clsXzAdminClsENEx CopyToEx(this clsXzAdminClsEN objXzAdminClsENS)
        {
            try
            {
                clsXzAdminClsENEx objXzAdminClsENT = new clsXzAdminClsENEx();
                clsXzAdminClsBL.XzAdminClsDA.CopyTo(objXzAdminClsENS, objXzAdminClsENT);
                return objXzAdminClsENT;
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
        /// <param name = "objXzAdminClsENS">源对象</param>
        /// <returns>目标对象=>clsXzAdminClsEN:objXzAdminClsENT</returns>
        public static clsXzAdminClsEN CopyTo(this clsXzAdminClsENEx objXzAdminClsENS)
        {
            try
            {
                clsXzAdminClsEN objXzAdminClsENT = new clsXzAdminClsEN();
                clsXzAdminClsBL.CopyTo(objXzAdminClsENS, objXzAdminClsENT);
                return objXzAdminClsENT;
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
    /// 行政班(XzAdminCls)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsXzAdminClsBLEx : clsXzAdminClsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsXzAdminClsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsXzAdminClsDAEx XzAdminClsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsXzAdminClsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objXzAdminClsENS">源对象</param>
        /// <returns>目标对象=>clsXzAdminClsEN:objXzAdminClsENT</returns>
        public static clsXzAdminClsENEx CopyToEx(clsXzAdminClsEN objXzAdminClsENS)
        {
            try
            {
                clsXzAdminClsENEx objXzAdminClsENT = new clsXzAdminClsENEx();
                clsXzAdminClsBL.XzAdminClsDA.CopyTo(objXzAdminClsENS, objXzAdminClsENT);
                return objXzAdminClsENT;
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
        public static List<clsXzAdminClsENEx> GetObjExLst(string strCondition)
        {
            List<clsXzAdminClsEN> arrObjLst = clsXzAdminClsBL.GetObjLst(strCondition);
            List<clsXzAdminClsENEx> arrObjExLst = new List<clsXzAdminClsENEx>();
            foreach (clsXzAdminClsEN objInFor in arrObjLst)
            {
                clsXzAdminClsENEx objXzAdminClsENEx = new clsXzAdminClsENEx();
                clsXzAdminClsBL.CopyTo(objInFor, objXzAdminClsENEx);
                arrObjExLst.Add(objXzAdminClsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strid_AdminCls">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsXzAdminClsENEx GetObjExByid_AdminCls(string strid_AdminCls)
        {
            clsXzAdminClsEN objXzAdminClsEN = clsXzAdminClsBL.GetObjByIdAdminCls(strid_AdminCls);
            clsXzAdminClsENEx objXzAdminClsENEx = new clsXzAdminClsENEx();
            clsXzAdminClsBL.CopyTo(objXzAdminClsEN, objXzAdminClsENEx);
            return objXzAdminClsENEx;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strid_AdminClass">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsXzAdminClsEN GetObjByGradeName_Cache(string strGradeName, int intIndex)
        {
            var arrXzAdminClsObjLst_Cache = GetObjLstCache();

            foreach (clsXzAdminClsEN objAdminClassEN in arrXzAdminClsObjLst_Cache)
            {
                if (objAdminClassEN.AdminClsName.Contains(strGradeName) && objAdminClassEN.AdminClsIndex == intIndex)
                {
                    return objAdminClassEN;
                }
            }
            return null;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strid_AdminClass">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsXzAdminClsEN GetObjByAdminClassName_Cache(string strAdminClassName)
        {
            var arrXzAdminClsObjLst_Cache = GetObjLstCache();

            foreach (clsXzAdminClsEN objAdminClassEN in arrXzAdminClsObjLst_Cache)
            {
                if (objAdminClassEN.AdminClsName == strAdminClassName)
                {
                    return objAdminClassEN;
                }
            }
            return null;
        }
    }
}