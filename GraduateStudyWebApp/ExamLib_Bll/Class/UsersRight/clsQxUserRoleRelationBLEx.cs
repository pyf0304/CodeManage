
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserRoleRelationBLEx
表名:QxUserRoleRelation(01120481)
生成代码版本:2020.06.05.2
生成日期:2020/06/12 23:25:00
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:权限管理
模块英文名:UsersRight
框架-层名:业务逻辑扩展层(BusinessLogicEx)
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
    public static class clsQxUserRoleRelationBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxUserRoleRelationENS">源对象</param>
        /// <returns>目标对象=>clsQxUserRoleRelationEN:objQxUserRoleRelationENT</returns>
        public static clsQxUserRoleRelationENEx CopyToEx(this clsQxUserRoleRelationEN objQxUserRoleRelationENS)
        {
            try
            {
                clsQxUserRoleRelationENEx objQxUserRoleRelationENT = new clsQxUserRoleRelationENEx();
                clsQxUserRoleRelationBL.QxUserRoleRelationDA.CopyTo(objQxUserRoleRelationENS, objQxUserRoleRelationENT);
                return objQxUserRoleRelationENT;
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
        /// <param name = "objQxUserRoleRelationENS">源对象</param>
        /// <returns>目标对象=>clsQxUserRoleRelationEN:objQxUserRoleRelationENT</returns>
        public static clsQxUserRoleRelationEN CopyTo(this clsQxUserRoleRelationENEx objQxUserRoleRelationENS)
        {
            try
            {
                clsQxUserRoleRelationEN objQxUserRoleRelationENT = new clsQxUserRoleRelationEN();
                clsQxUserRoleRelationBL.CopyTo(objQxUserRoleRelationENS, objQxUserRoleRelationENT);
                return objQxUserRoleRelationENT;
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
    /// Qx用户角色关系(QxUserRoleRelation)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxUserRoleRelationBLEx : clsQxUserRoleRelationBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserRoleRelationDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserRoleRelationDAEx QxUserRoleRelationDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserRoleRelationDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxUserRoleRelationENS">源对象</param>
        /// <returns>目标对象=>clsQxUserRoleRelationEN:objQxUserRoleRelationENT</returns>
        public static clsQxUserRoleRelationENEx CopyToEx(clsQxUserRoleRelationEN objQxUserRoleRelationENS)
        {
            try
            {
                clsQxUserRoleRelationENEx objQxUserRoleRelationENT = new clsQxUserRoleRelationENEx();
                clsQxUserRoleRelationBL.QxUserRoleRelationDA.CopyTo(objQxUserRoleRelationENS, objQxUserRoleRelationENT);
                return objQxUserRoleRelationENT;
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
        public static List<clsQxUserRoleRelationENEx> GetObjExLst(string strCondition)
        {
            List<clsQxUserRoleRelationEN> arrObjLst = clsQxUserRoleRelationBL.GetObjLst(strCondition);
            List<clsQxUserRoleRelationENEx> arrObjExLst = new List<clsQxUserRoleRelationENEx>();
            foreach (clsQxUserRoleRelationEN objInFor in arrObjLst)
            {
                clsQxUserRoleRelationENEx objQxUserRoleRelationENEx = new clsQxUserRoleRelationENEx();
                clsQxUserRoleRelationBL.CopyTo(objInFor, objQxUserRoleRelationENEx);
                arrObjExLst.Add(objQxUserRoleRelationENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxUserRoleRelationENEx GetObjExBymId(long lngmId)
        {
            clsQxUserRoleRelationEN objQxUserRoleRelationEN = clsQxUserRoleRelationBL.GetObjBymId(lngmId);
            clsQxUserRoleRelationENEx objQxUserRoleRelationENEx = new clsQxUserRoleRelationENEx();
            clsQxUserRoleRelationBL.CopyTo(objQxUserRoleRelationEN, objQxUserRoleRelationENEx);
            return objQxUserRoleRelationENEx;
        }
    }
}