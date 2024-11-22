
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_UserRelaBLEx
表名:gs_UserRela(01120773)
生成代码版本:2020.12.02.1
生成日期:2020/12/09 17:30:50
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培设置
模块英文名:GraduateEduTools
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
using System.Data;

namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_UserRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_UserRelaENS">源对象</param>
        /// <returns>目标对象=>clsgs_UserRelaEN:objgs_UserRelaENT</returns>
        public static clsgs_UserRelaENEx CopyToEx(this clsgs_UserRelaEN objgs_UserRelaENS)
        {
            try
            {
                clsgs_UserRelaENEx objgs_UserRelaENT = new clsgs_UserRelaENEx();
                clsgs_UserRelaBL.gs_UserRelaDA.CopyTo(objgs_UserRelaENS, objgs_UserRelaENT);
                return objgs_UserRelaENT;
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
        /// <param name = "objgs_UserRelaENS">源对象</param>
        /// <returns>目标对象=>clsgs_UserRelaEN:objgs_UserRelaENT</returns>
        public static clsgs_UserRelaEN CopyTo(this clsgs_UserRelaENEx objgs_UserRelaENS)
        {
            try
            {
                clsgs_UserRelaEN objgs_UserRelaENT = new clsgs_UserRelaEN();
                clsgs_UserRelaBL.CopyTo(objgs_UserRelaENS, objgs_UserRelaENT);
                return objgs_UserRelaENT;
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
    /// 用户关系(gs_UserRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_UserRelaBLEx : clsgs_UserRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_UserRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_UserRelaDAEx gs_UserRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_UserRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_UserRelaENS">源对象</param>
        /// <returns>目标对象=>clsgs_UserRelaEN:objgs_UserRelaENT</returns>
        public static clsgs_UserRelaENEx CopyToEx(clsgs_UserRelaEN objgs_UserRelaENS)
        {
            try
            {
                clsgs_UserRelaENEx objgs_UserRelaENT = new clsgs_UserRelaENEx();
                clsgs_UserRelaBL.gs_UserRelaDA.CopyTo(objgs_UserRelaENS, objgs_UserRelaENT);
                return objgs_UserRelaENT;
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
        public static List<clsgs_UserRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_UserRelaEN> arrObjLst = clsgs_UserRelaBL.GetObjLst(strCondition);
            List<clsgs_UserRelaENEx> arrObjExLst = new List<clsgs_UserRelaENEx>();
            foreach (clsgs_UserRelaEN objInFor in arrObjLst)
            {
                clsgs_UserRelaENEx objgs_UserRelaENEx = new clsgs_UserRelaENEx();
                clsgs_UserRelaBL.CopyTo(objInFor, objgs_UserRelaENEx);
                arrObjExLst.Add(objgs_UserRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_UserRelaENEx GetObjExBymId(long lngmId)
        {
            clsgs_UserRelaEN objgs_UserRelaEN = clsgs_UserRelaBL.GetObjBymId(lngmId);
            clsgs_UserRelaENEx objgs_UserRelaENEx = new clsgs_UserRelaENEx();
            clsgs_UserRelaBL.CopyTo(objgs_UserRelaEN, objgs_UserRelaENEx);
            return objgs_UserRelaENEx;
        }

        /// <summary>
        /// 同步
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="stridCurrEduCls"></param>
        /// <returns></returns>
        public static bool SynUserRelaNum(string stridCurrEduCls, string strUpdUser)
        {
            bool bolResult = true;
            try
            {

                string strCondition = "IdCurrEduCls='" + stridCurrEduCls + "'";
                //教师教学班关系
                List<clsvCurrEduClsTeacherEN> arrvCurrEduClsTeacherObjLst = clsvCurrEduClsTeacherBL.GetObjLst(strCondition);
                foreach (clsvCurrEduClsTeacherEN objvCurrEduClsTeacher in arrvCurrEduClsTeacherObjLst)
                {
                    string strUserId = objvCurrEduClsTeacher.TeacherId;
                    string strUpdUserName = objvCurrEduClsTeacher.TeacherName;

                    System.Data.DataTable objDT = null;
                    objDT = objDT = clsgs_UserRelaDAEx.GetUserRelaNumDataTable(strUserId, stridCurrEduCls);
                    foreach (DataRow objRow in objDT.Rows)
                    {
                        string strUserRelaId = objRow[congs_UserRela.UserId].ToString().Trim();
                        string strURWhere = " UserId='" + strUserId + "' and UserRelaId='" + strUserRelaId + "' and IdCurrEduCls='" + stridCurrEduCls + "'";
                        int intURCount = clsgs_UserRelaBL.GetRecCountByCond(strURWhere);
                        if (intURCount == 0)
                        {
                            clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
                            objgs_UserRelaEN.UserId = strUserId;
                            objgs_UserRelaEN.UserRelaId = strUserRelaId;
                            objgs_UserRelaEN.UpdUser = strUpdUser;
                            objgs_UserRelaEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objgs_UserRelaEN.IdCurrEduCls = stridCurrEduCls;
                            objgs_UserRelaEN.UpdUserName = strUpdUserName;

                            bolResult = clsgs_UserRelaBL.gs_UserRelaDA.AddNewRecordBySQL2(objgs_UserRelaEN);
                        }
                    }
                }

                //学生教学班关系
                List<clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLst = clsvCurrEduClsStuBL.GetObjLst(strCondition);
                foreach (clsvCurrEduClsStuEN objvCurrEduClsStu in arrvCurrEduClsStuObjLst)
                {
                    string strUserId = objvCurrEduClsStu.StuId;
                    string strUpdUserName = objvCurrEduClsStu.StuName;


                    System.Data.DataTable objDT = null;
                    objDT = objDT = clsgs_UserRelaDAEx.GetUserRelaNumDataTable(strUserId, stridCurrEduCls);
                    foreach (DataRow objRow in objDT.Rows)
                    {
                        string strUserRelaId = objRow[congs_UserRela.UserId].ToString().Trim();
                        string strURWhere = " UserId='" + strUserId + "' and UserRelaId='" + strUserRelaId + "' and IdCurrEduCls='" + stridCurrEduCls + "'";
                        int intURCount = clsgs_UserRelaBL.GetRecCountByCond(strURWhere);
                        if (intURCount == 0)
                        {
                            clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
                            objgs_UserRelaEN.UserId = strUserId;
                            objgs_UserRelaEN.UserRelaId = strUserRelaId;
                            objgs_UserRelaEN.UpdUser = strUpdUser;
                            objgs_UserRelaEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objgs_UserRelaEN.IdCurrEduCls = stridCurrEduCls;
                            objgs_UserRelaEN.UpdUserName = strUpdUserName;
                            bolResult = clsgs_UserRelaBL.gs_UserRelaDA.AddNewRecordBySQL2(objgs_UserRelaEN);
                        }
                    }
                }


                //string strWhere = "UserId='" + strUserId + "'";
                //int intDel = Delgs_UserRelasByCond(strDelWhere);


                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                clsgs_UserRelaBL.ReFreshCache(stridCurrEduCls);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }

        }


    }
}