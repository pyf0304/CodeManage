
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsXzGradeBaseBLEx
表名:XzGradeBase(01120129)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 12:11:06
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:系统参数
模块英文名:SysPara
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
    public static class clsXzGradeBaseBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objXzGradeBaseENS">源对象</param>
        /// <returns>目标对象=>clsXzGradeBaseEN:objXzGradeBaseENT</returns>
        public static clsXzGradeBaseENEx CopyToEx(this clsXzGradeBaseEN objXzGradeBaseENS)
        {
            try
            {
                clsXzGradeBaseENEx objXzGradeBaseENT = new clsXzGradeBaseENEx();
                clsXzGradeBaseBL.XzGradeBaseDA.CopyTo(objXzGradeBaseENS, objXzGradeBaseENT);
                return objXzGradeBaseENT;
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
        /// <param name = "objXzGradeBaseENS">源对象</param>
        /// <returns>目标对象=>clsXzGradeBaseEN:objXzGradeBaseENT</returns>
        public static clsXzGradeBaseEN CopyTo(this clsXzGradeBaseENEx objXzGradeBaseENS)
        {
            try
            {
                clsXzGradeBaseEN objXzGradeBaseENT = new clsXzGradeBaseEN();
                clsXzGradeBaseBL.CopyTo(objXzGradeBaseENS, objXzGradeBaseENT);
                return objXzGradeBaseENT;
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
    /// 年级(XzGradeBase)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsXzGradeBaseBLEx : clsXzGradeBaseBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsXzGradeBaseDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsXzGradeBaseDAEx XzGradeBaseDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsXzGradeBaseDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objXzGradeBaseENS">源对象</param>
        /// <returns>目标对象=>clsXzGradeBaseEN:objXzGradeBaseENT</returns>
        public static clsXzGradeBaseENEx CopyToEx(clsXzGradeBaseEN objXzGradeBaseENS)
        {
            try
            {
                clsXzGradeBaseENEx objXzGradeBaseENT = new clsXzGradeBaseENEx();
                clsXzGradeBaseBL.XzGradeBaseDA.CopyTo(objXzGradeBaseENS, objXzGradeBaseENT);
                return objXzGradeBaseENT;
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
        public static List<clsXzGradeBaseENEx> GetObjExLst(string strCondition)
        {
            List<clsXzGradeBaseEN> arrObjLst = clsXzGradeBaseBL.GetObjLst(strCondition);
            List<clsXzGradeBaseENEx> arrObjExLst = new List<clsXzGradeBaseENEx>();
            foreach (clsXzGradeBaseEN objInFor in arrObjLst)
            {
                clsXzGradeBaseENEx objXzGradeBaseENEx = new clsXzGradeBaseENEx();
                clsXzGradeBaseBL.CopyTo(objInFor, objXzGradeBaseENEx);
                arrObjExLst.Add(objXzGradeBaseENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strid_GradeBase">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsXzGradeBaseENEx GetObjExByid_GradeBase(string strid_GradeBase)
        {
            clsXzGradeBaseEN objXzGradeBaseEN = clsXzGradeBaseBL.GetObjByIdGradeBase(strid_GradeBase);
            clsXzGradeBaseENEx objXzGradeBaseENEx = new clsXzGradeBaseENEx();
            clsXzGradeBaseBL.CopyTo(objXzGradeBaseEN, objXzGradeBaseENEx);
            return objXzGradeBaseENEx;
        }
        /// <summary>
        /// 根据年级名称获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strGradeBaseName">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsXzGradeBaseEN GetObjByGradeBaseName_Cache(string strGradeBaseName)
        {
            var arrXzGradeBaseObjLst_Cache = GetObjLstCache();

            foreach (clsXzGradeBaseEN objGradeBaseEN in arrXzGradeBaseObjLst_Cache)
            {
                if (objGradeBaseEN.GradeBaseName == strGradeBaseName)
                {
                    return objGradeBaseEN;
                }
            }
            return null;
        }
    }
}