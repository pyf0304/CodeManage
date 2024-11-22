
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvUsersBLEx
表名:vUsers(01120027)
生成代码版本:2020.02.18.1
生成日期:2020/02/19 11:54:47
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:用户管理
模块英文名:UserManage
框架-层名:业务逻辑扩展层CSharp(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;

namespace ExamLib.BusinessLogicEx
{
    public static class clsvUsersBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objvUsersENS">源对象</param>
        /// <returns>目标对象=>clsvUsersEN:objvUsersENT</returns>
        public static clsvUsersEN CopyTo(this clsvUsersENEx objvUsersENS)
        {
            try
            {
                clsvUsersEN objvUsersENT = new clsvUsersEN();
                clsvUsersBL.CopyTo(objvUsersENS, objvUsersENT);
                return objvUsersENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvUsersENS">源对象</param>
        /// <returns>目标对象=>clsvUsersEN:objvUsersENT</returns>
        public static clsvUsersENEx CopyToEx(this clsvUsersEN objvUsersENS)
        {
            try
            {
                clsvUsersENEx objvUsersENT = new clsvUsersENEx();
                clsvUsersBL.vUsersDA.CopyTo(objvUsersENS, objvUsersENT);
                return objvUsersENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// v用户(vUsers)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvUsersBLEx : clsvUsersBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvUsersDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvUsersDAEx vUsersDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvUsersDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strUserId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvUsersENEx GetObjExByUserId(string strUserId)
        {
            clsvUsersEN objvUsersEN = clsvUsersBL.GetObjByUserId(strUserId);
            clsvUsersENEx objvUsersENEx = new clsvUsersENEx();
            clsvUsersBL.CopyTo(objvUsersEN, objvUsersENEx);
            return objvUsersENEx;
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvUsersENEx> GetObjExLst(string strCondition)
        {
            List<clsvUsersEN> arrObjLst = clsvUsersBL.GetObjLst(strCondition);
            List<clsvUsersENEx> arrObjExLst = new List<clsvUsersENEx>();
            foreach (clsvUsersEN objInFor in arrObjLst)
            {
                clsvUsersENEx objvUsersENEx = new clsvUsersENEx();
                clsvUsersBL.CopyTo(objInFor, objvUsersENEx);
                arrObjExLst.Add(objvUsersENEx);
            }
            return arrObjExLst;
        }
    }
}