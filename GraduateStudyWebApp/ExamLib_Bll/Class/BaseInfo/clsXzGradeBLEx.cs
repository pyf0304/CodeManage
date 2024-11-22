
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsXzGradeBLEx
表名:XzGrade(01120349)
生成代码版本:2020.07.31.1
生成日期:2020/07/31 22:47:46
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:基本信息维护
模块英文名:BaseInfo
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
    public static class clsXzGradeBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objXzGradeENS">源对象</param>
        /// <returns>目标对象=>clsXzGradeEN:objXzGradeENT</returns>
        public static clsXzGradeENEx CopyToEx(this clsXzGradeEN objXzGradeENS)
        {
            try
            {
                clsXzGradeENEx objXzGradeENT = new clsXzGradeENEx();
                clsXzGradeBL.XzGradeDA.CopyTo(objXzGradeENS, objXzGradeENT);
                return objXzGradeENT;
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
        /// <param name = "objXzGradeENS">源对象</param>
        /// <returns>目标对象=>clsXzGradeEN:objXzGradeENT</returns>
        public static clsXzGradeEN CopyTo(this clsXzGradeENEx objXzGradeENS)
        {
            try
            {
                clsXzGradeEN objXzGradeENT = new clsXzGradeEN();
                clsXzGradeBL.CopyTo(objXzGradeENS, objXzGradeENT);
                return objXzGradeENT;
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
    /// 年级(XzGrade)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsXzGradeBLEx : clsXzGradeBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsXzGradeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsXzGradeDAEx XzGradeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsXzGradeDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objXzGradeENS">源对象</param>
        /// <returns>目标对象=>clsXzGradeEN:objXzGradeENT</returns>
        public static clsXzGradeENEx CopyToEx(clsXzGradeEN objXzGradeENS)
        {
            try
            {
                clsXzGradeENEx objXzGradeENT = new clsXzGradeENEx();
                clsXzGradeBL.XzGradeDA.CopyTo(objXzGradeENS, objXzGradeENT);
                return objXzGradeENT;
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
        public static List<clsXzGradeENEx> GetObjExLst(string strCondition)
        {
            List<clsXzGradeEN> arrObjLst = clsXzGradeBL.GetObjLst(strCondition);
            List<clsXzGradeENEx> arrObjExLst = new List<clsXzGradeENEx>();
            foreach (clsXzGradeEN objInFor in arrObjLst)
            {
                clsXzGradeENEx objXzGradeENEx = new clsXzGradeENEx();
                clsXzGradeBL.CopyTo(objInFor, objXzGradeENEx);
                arrObjExLst.Add(objXzGradeENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strid_Grade">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsXzGradeENEx GetObjExByid_Grade(string strid_Grade)
        {
            clsXzGradeEN objXzGradeEN = clsXzGradeBL.GetObjByIdGrade(strid_Grade);
            clsXzGradeENEx objXzGradeENEx = new clsXzGradeENEx();
            clsXzGradeBL.CopyTo(objXzGradeEN, objXzGradeENEx);
            return objXzGradeENEx;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strGradeName">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsXzGradeEN GetObjByGradeName_Cache(string strGradeName)
        {
            var arrXzGradeObjLst_Cache = GetObjLstCache();

            foreach (clsXzGradeEN objAdminClassEN in arrXzGradeObjLst_Cache)
            {
                if (objAdminClassEN.GradeName == strGradeName)
                {
                    return objAdminClassEN;
                }
            }
            return null;
        }

    }
}