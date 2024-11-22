
using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamLib.BusinessLogicEx
{
    public static class clsQxUsersBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxUsersENS">源对象</param>
        /// <returns>目标对象=>clsQxUsersEN:objQxUsersENT</returns>
        public static clsQxUsersENEx CopyToEx(this clsQxUsersEN objQxUsersENS)
        {
            try
            {
                clsQxUsersENEx objQxUsersENT = new clsQxUsersENEx();
                clsQxUsersBL.QxUsersDA.CopyTo(objQxUsersENS, objQxUsersENT);
                return objQxUsersENT;
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
        /// <param name = "objQxUsersENS">源对象</param>
        /// <returns>目标对象=>clsQxUsersEN:objQxUsersENT</returns>
        public static clsQxUsersEN CopyTo(this clsQxUsersENEx objQxUsersENS)
        {
            try
            {
                clsQxUsersEN objQxUsersENT = new clsQxUsersEN();
                clsQxUsersBL.CopyTo(objQxUsersENS, objQxUsersENT);
                return objQxUsersENT;
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
    /// Qx用户(QxUsers)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxUsersBLEx : clsQxUsersBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUsersDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUsersDAEx QxUsersDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUsersDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxUsersENS">源对象</param>
        /// <returns>目标对象=>clsQxUsersEN:objQxUsersENT</returns>
        public static clsQxUsersENEx CopyToEx(clsQxUsersEN objQxUsersENS)
        {
            try
            {
                clsQxUsersENEx objQxUsersENT = new clsQxUsersENEx();
                clsQxUsersBL.QxUsersDA.CopyTo(objQxUsersENS, objQxUsersENT);
                return objQxUsersENT;
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
        public static List<clsQxUsersENEx> GetObjExLst(string strCondition)
        {
            List<clsQxUsersEN> arrObjLst = clsQxUsersBL.GetObjLst(strCondition);
            List<clsQxUsersENEx> arrObjExLst = new List<clsQxUsersENEx>();
            foreach (clsQxUsersEN objInFor in arrObjLst)
            {
                clsQxUsersENEx objQxUsersENEx = new clsQxUsersENEx();
                clsQxUsersBL.CopyTo(objInFor, objQxUsersENEx);
                arrObjExLst.Add(objQxUsersENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strUserId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxUsersENEx GetObjExByUserId(string strUserId)
        {
            clsQxUsersEN objQxUsersEN = clsQxUsersBL.GetObjByUserId(strUserId);
            clsQxUsersENEx objQxUsersENEx = new clsQxUsersENEx();
            clsQxUsersBL.CopyTo(objQxUsersEN, objQxUsersENEx);
            return objQxUsersENEx;
        }
        public static bool AddNewUsers(clsQxUsersEN objUsers, string strPrjId, string strRoleId)
        {
            if (clsQxUsersBL.IsExist(objUsers.UserId))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendFormat("用户:{0}({1})已经存在,不能再添加！", objUsers.UserId, objUsers.UserName);
            }
            else
            {
                clsQxUsersBL.AddNewRecordBySql2(objUsers);
            }

            AddPrjUserRelation(objUsers.UserId, strPrjId);
            AddUserRoleRelation(objUsers.UserId, strRoleId);
            return true;
        }

        //
        // 摘要:
        //     建立工程用户关系
        //
        // 参数:
        //   strUserId:
        //     用户ID
        //
        //   strPrjId:
        //     工程ID
        public static bool AddPrjUserRelation(string strUserId, string strPrjId)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("QxPrjId='{0}' and UserId='{1}'", strPrjId, strUserId);
            if (!clsQxPrjUserRelationBL.IsExistRecord(stringBuilder.ToString()))
            {
                clsQxPrjUserRelationEN clsQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
                clsQxPrjUserRelationEN.QxPrjId = strPrjId;
                clsQxPrjUserRelationEN.UserId = strUserId;
                clsQxPrjUserRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                clsQxPrjUserRelationEN.UpdUserId = "WebService";
                clsQxPrjUserRelationEN.Memo = "由WebService同步！";
                clsQxPrjUserRelationBL.AddNewRecordBySql2(clsQxPrjUserRelationEN);
            }

            return true;
        }

        //
        // 摘要:
        //     建立用户角色关系
        //
        // 参数:
        //   strUserId:
        //     用户ID
        //
        //   strRoleId:
        //     工程ID
        public static bool AddUserRoleRelation(string strUserId, string strRoleId)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("RoleId='{0}' and UserId='{1}'", strRoleId, strUserId);
            if (!clsQxUserRoleRelationBL.IsExistRecord(stringBuilder.ToString()))
            {
                clsQxUserRoleRelationEN clsQxUserRoleRelationEN = new clsQxUserRoleRelationEN();
                clsQxUserRoleRelationEN.RoleId = strRoleId;
                clsQxUserRoleRelationEN.UserId = strUserId;
                clsQxUserRoleRelationEN.QxPrjId = strRoleId.Substring(0, 4);
                clsQxUserRoleRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                clsQxUserRoleRelationEN.UpdUserId = "WebService";
                clsQxUserRoleRelationEN.Memo = "由WebService同步！";
                clsQxUserRoleRelationBL.AddNewRecordBySql2(clsQxUserRoleRelationEN);
            }

            return true;
        }


    }
}