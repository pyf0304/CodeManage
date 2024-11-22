
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_TopicRoleBLEx
表名:gs_TopicRole(01120869)
生成代码版本:2021.01.07.1
生成日期:2021/01/07 23:53:38
生成者:lyl
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
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
    public static class clsgs_TopicRoleBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_TopicRoleENS">源对象</param>
        /// <returns>目标对象=>clsgs_TopicRoleEN:objgs_TopicRoleENT</returns>
        public static clsgs_TopicRoleENEx CopyToEx(this clsgs_TopicRoleEN objgs_TopicRoleENS)
        {
            try
            {
                clsgs_TopicRoleENEx objgs_TopicRoleENT = new clsgs_TopicRoleENEx();
                clsgs_TopicRoleBL.gs_TopicRoleDA.CopyTo(objgs_TopicRoleENS, objgs_TopicRoleENT);
                return objgs_TopicRoleENT;
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
        /// <param name = "objgs_TopicRoleENS">源对象</param>
        /// <returns>目标对象=>clsgs_TopicRoleEN:objgs_TopicRoleENT</returns>
        public static clsgs_TopicRoleEN CopyTo(this clsgs_TopicRoleENEx objgs_TopicRoleENS)
        {
            try
            {
                clsgs_TopicRoleEN objgs_TopicRoleENT = new clsgs_TopicRoleEN();
                clsgs_TopicRoleBL.CopyTo(objgs_TopicRoleENS, objgs_TopicRoleENT);
                return objgs_TopicRoleENT;
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
    /// 主题权限表(gs_TopicRole)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_TopicRoleBLEx : clsgs_TopicRoleBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_TopicRoleDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_TopicRoleDAEx gs_TopicRoleDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_TopicRoleDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_TopicRoleENS">源对象</param>
        /// <returns>目标对象=>clsgs_TopicRoleEN:objgs_TopicRoleENT</returns>
        public static clsgs_TopicRoleENEx CopyToEx(clsgs_TopicRoleEN objgs_TopicRoleENS)
        {
            try
            {
                clsgs_TopicRoleENEx objgs_TopicRoleENT = new clsgs_TopicRoleENEx();
                clsgs_TopicRoleBL.gs_TopicRoleDA.CopyTo(objgs_TopicRoleENS, objgs_TopicRoleENT);
                return objgs_TopicRoleENT;
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
        public static List<clsgs_TopicRoleENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_TopicRoleEN> arrObjLst = clsgs_TopicRoleBL.GetObjLst(strCondition);
            List<clsgs_TopicRoleENEx> arrObjExLst = new List<clsgs_TopicRoleENEx>();
            foreach (clsgs_TopicRoleEN objInFor in arrObjLst)
            {
                clsgs_TopicRoleENEx objgs_TopicRoleENEx = new clsgs_TopicRoleENEx();
                clsgs_TopicRoleBL.CopyTo(objInFor, objgs_TopicRoleENEx);
                arrObjExLst.Add(objgs_TopicRoleENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTopicRoleId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_TopicRoleENEx GetObjExByTopicRoleId(string strTopicRoleId)
        {
            clsgs_TopicRoleEN objgs_TopicRoleEN = clsgs_TopicRoleBL.GetObjByTopicRoleId(strTopicRoleId);
            clsgs_TopicRoleENEx objgs_TopicRoleENEx = new clsgs_TopicRoleENEx();
            clsgs_TopicRoleBL.CopyTo(objgs_TopicRoleEN, objgs_TopicRoleENEx);
            return objgs_TopicRoleENEx;
        }




        /// <summary>
        /// 添加默认设置
        /// </summary>
        /// <param name="strTopicId"></param>
        /// <param name="strUpdUser"></param>
        /// <returns></returns>
        public static bool AddDefaultSettings(string strTopicId, string strUpdUser)
        {
            bool bolresult = false;
            try
            {
                //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                string strWhereCond = "IsDefault=1";
                List<clsgs_TopicRoleEN> arrgs_TopicRole = clsgs_TopicRoleBL.GetObjLst(strWhereCond);

                foreach (clsgs_TopicRoleEN objgs_TopicRole in arrgs_TopicRole)
                {

                    clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
                    objgs_TopicRoleEN.TopicId = strTopicId;
                    objgs_TopicRoleEN.MenuNum = objgs_TopicRole.MenuNum;
                    objgs_TopicRoleEN.MenuName = objgs_TopicRole.MenuName;
                    objgs_TopicRoleEN.MenuIsHide = objgs_TopicRole.MenuIsHide;
                    objgs_TopicRoleEN.UpdDate = objgs_TopicRole.UpdDate;
                    objgs_TopicRoleEN.UpdUser = strUpdUser;
                    objgs_TopicRoleEN.IsDefault = false;

                    string strTopicRoleId = clsgs_TopicRoleBL_Static.AddNewRecordWithMaxId(objgs_TopicRoleEN);
                    if (strTopicRoleId != "")
                    {
                        bolresult = true;
                    }
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("添加默认设置出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }


    }
}