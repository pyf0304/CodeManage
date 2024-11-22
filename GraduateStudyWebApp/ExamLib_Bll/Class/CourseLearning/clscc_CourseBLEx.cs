
/*-- -- -- -- -- -- -- -- -- -- --
类名:clscc_CourseBLEx
表名:cc_Course(01120056)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 14:50:07
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:课程学习
模块英文名:CourseLearning
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
    public static class clscc_CourseBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objcc_CourseENS">源对象</param>
        /// <returns>目标对象=>clscc_CourseEN:objcc_CourseENT</returns>
        public static clscc_CourseENEx CopyToEx(this clscc_CourseEN objcc_CourseENS)
        {
            try
            {
                clscc_CourseENEx objcc_CourseENT = new clscc_CourseENEx();
                clscc_CourseBL.cc_CourseDA.CopyTo(objcc_CourseENS, objcc_CourseENT);
                return objcc_CourseENT;
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
        /// <param name = "objcc_CourseENS">源对象</param>
        /// <returns>目标对象=>clscc_CourseEN:objcc_CourseENT</returns>
        public static clscc_CourseEN CopyTo(this clscc_CourseENEx objcc_CourseENS)
        {
            try
            {
                clscc_CourseEN objcc_CourseENT = new clscc_CourseEN();
                clscc_CourseBL.CopyTo(objcc_CourseENS, objcc_CourseENT);
                return objcc_CourseENT;
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
    /// 课程(cc_Course)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clscc_CourseBLEx : clscc_CourseBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clscc_CourseDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clscc_CourseDAEx cc_CourseDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clscc_CourseDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objcc_CourseENS">源对象</param>
        /// <returns>目标对象=>clscc_CourseEN:objcc_CourseENT</returns>
        public static clscc_CourseENEx CopyToEx(clscc_CourseEN objcc_CourseENS)
        {
            try
            {
                clscc_CourseENEx objcc_CourseENT = new clscc_CourseENEx();
                clscc_CourseBL.cc_CourseDA.CopyTo(objcc_CourseENS, objcc_CourseENT);
                return objcc_CourseENT;
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
        public static List<clscc_CourseENEx> GetObjExLst(string strCondition)
        {
            List<clscc_CourseEN> arrObjLst = clscc_CourseBL.GetObjLst(strCondition);
            List<clscc_CourseENEx> arrObjExLst = new List<clscc_CourseENEx>();
            foreach (clscc_CourseEN objInFor in arrObjLst)
            {
                clscc_CourseENEx objcc_CourseENEx = new clscc_CourseENEx();
                clscc_CourseBL.CopyTo(objInFor, objcc_CourseENEx);
                arrObjExLst.Add(objcc_CourseENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCourseId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clscc_CourseENEx GetObjExByCourseId(string strCourseId)
        {
            clscc_CourseEN objcc_CourseEN = clscc_CourseBL.GetObjByCourseId(strCourseId);
            clscc_CourseENEx objcc_CourseENEx = new clscc_CourseENEx();
            clscc_CourseBL.CopyTo(objcc_CourseEN, objcc_CourseENEx);
            return objcc_CourseENEx;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>
        /// <param name = "strCourseName">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clscc_CourseEN GetObjByCourseName_Cache(string strCourseName)
        {
            if (string.IsNullOrEmpty(strCourseName) == true) return null;
            //初始化列表缓存
            var arrcc_CourseObjLst_Cache = GetObjLstCache();
            IEnumerable<clscc_CourseEN> arrcc_CourseObjLst_Sel1 =
            from objcc_CourseEN in arrcc_CourseObjLst_Cache
            where objcc_CourseEN.CourseName == strCourseName
            select objcc_CourseEN;
            List<clscc_CourseEN> arrcc_CourseObjLst_Sel = new List<clscc_CourseEN>();
            foreach (clscc_CourseEN obj in arrcc_CourseObjLst_Sel1)
            {
                arrcc_CourseObjLst_Sel.Add(obj);
            }
            if (arrcc_CourseObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrcc_CourseObjLst_Sel[0];
        }

    }
}