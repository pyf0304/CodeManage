
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPaperSubViewpointBLEx
表名:vPaperSubViewpoint(01120551)
生成代码版本:2020.02.25.1
生成日期:2020/02/25 10:33:20
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
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
    public static class clsvPaperSubViewpointBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvPaperSubViewpointENS">源对象</param>
        /// <returns>目标对象=>clsvPaperSubViewpointEN:objvPaperSubViewpointENT</returns>
        public static clsvPaperSubViewpointENEx CopyToEx(this clsvPaperSubViewpointEN objvPaperSubViewpointENS)
        {
            try
            {
                clsvPaperSubViewpointENEx objvPaperSubViewpointENT = new clsvPaperSubViewpointENEx();
                clsvPaperSubViewpointBL.vPaperSubViewpointDA.CopyTo(objvPaperSubViewpointENS, objvPaperSubViewpointENT);
                return objvPaperSubViewpointENT;
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
        /// <param name = "objvPaperSubViewpointENS">源对象</param>
        /// <returns>目标对象=>clsvPaperSubViewpointEN:objvPaperSubViewpointENT</returns>
        public static clsvPaperSubViewpointEN CopyTo(this clsvPaperSubViewpointENEx objvPaperSubViewpointENS)
        {
            try
            {
                clsvPaperSubViewpointEN objvPaperSubViewpointENT = new clsvPaperSubViewpointEN();
                clsvPaperSubViewpointBL.CopyTo(objvPaperSubViewpointENS, objvPaperSubViewpointENT);
                return objvPaperSubViewpointENT;
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
    /// v子观点表(vPaperSubViewpoint)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvPaperSubViewpointBLEx : clsvPaperSubViewpointBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvPaperSubViewpointDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvPaperSubViewpointDAEx vPaperSubViewpointDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvPaperSubViewpointDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvPaperSubViewpointENEx> GetObjExLst(string strCondition)
        {
            List<clsvPaperSubViewpointEN> arrObjLst = clsvPaperSubViewpointBL.GetObjLst(strCondition);
            List<clsvPaperSubViewpointENEx> arrObjExLst = new List<clsvPaperSubViewpointENEx>();
            foreach (clsvPaperSubViewpointEN objInFor in arrObjLst)
            {
                clsvPaperSubViewpointENEx objvPaperSubViewpointENEx = new clsvPaperSubViewpointENEx();
                clsvPaperSubViewpointBL.CopyTo(objInFor, objvPaperSubViewpointENEx);
                arrObjExLst.Add(objvPaperSubViewpointENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngSubViewpointId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvPaperSubViewpointENEx GetObjExBySubViewpointId(long lngSubViewpointId)
        {
            clsvPaperSubViewpointEN objvPaperSubViewpointEN = clsvPaperSubViewpointBL.GetObjBySubViewpointId(lngSubViewpointId);
            clsvPaperSubViewpointENEx objvPaperSubViewpointENEx = new clsvPaperSubViewpointENEx();
            clsvPaperSubViewpointBL.CopyTo(objvPaperSubViewpointEN, objvPaperSubViewpointENEx);
            return objvPaperSubViewpointENEx;
        }















        private static string strMsg = "";



        /// <summary>
        /// 获取子观点中的用户数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvPaperSubViewpointEN> GetSubViewpointNumObjLst(string strWhereCond)
        {
            List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>();
            System.Data.DataTable objDT = null;
            objDT = GetSubViewpointNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPaperSubViewpointEN objvPaperEN = new clsvPaperSubViewpointEN();

                objvPaperEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改用户Id
               // objvPaperEN.UserName = objRow[convPaperSubViewpoint.UserName].ToString().Trim(); //用户名
                

                
                

                if (objRow["Num"] == DBNull.Value)
                {
                    objvPaperEN.Memo = "0"; //统计
                }
                else
                {
                    objvPaperEN.Memo = objRow["Num"].ToString().Trim(); //统计
                }
                if (objRow["OkCount"] == DBNull.Value)
                {
                    objvPaperEN.OkCount = 0; //统计
                }
                else
                {
                    objvPaperEN.OkCount = int.Parse(objRow["OkCount"].ToString().Trim()); //统计
                }
                if (objRow["AppraiseCount"] == DBNull.Value)
                {
                    objvPaperEN.AppraiseCount = 0; //统计
                }
                else
                {
                    objvPaperEN.AppraiseCount = int.Parse(objRow["AppraiseCount"].ToString().Trim()); //统计
                }


                arrObjLst.Add(objvPaperEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetSubViewpointNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvPaperSubViewpointDAEx.GetSubViewpointNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取子观点点赞数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvPaperSubViewpointLikeLogEN> GetSubViewpointLikeNumObjLst(string strWhereCond)
        {
            List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>();
            System.Data.DataTable objDT = null;
            objDT = GetSubViewpointLikeNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLog = new clsvPaperSubViewpointLikeLogEN();

                objvPaperSubViewpointLikeLog.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改用户Id
               // objvPaperSubViewpointLikeLog.UserName = objRow[convPaperSubViewpointLikeLog.UserName].ToString().Trim(); //用户名
                objvPaperSubViewpointLikeLog.Memo = objRow["LikeNum"].ToString().Trim(); //统计

                arrObjLst.Add(objvPaperSubViewpointLikeLog);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetSubViewpointLikeNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvPaperSubViewpointDAEx.GetSubViewpointLikeNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }



        /// <summary>
        /// 获取子观点评论数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvPaperSubViewpointAppraiseEN> GetSubViewpointAppraiseNumObjLst(string strWhereCond)
        {
            List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>();
            System.Data.DataTable objDT = null;
            objDT = GetSubViewpointAppraiseNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraise = new clsvPaperSubViewpointAppraiseEN();

                objvPaperSubViewpointAppraise.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改用户Id

                objvPaperSubViewpointAppraise.Meno = objRow["AppraiseNum"].ToString().Trim(); //统计

                arrObjLst.Add(objvPaperSubViewpointAppraise);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetSubViewpointAppraiseNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvPaperSubViewpointDAEx.GetSubViewpointAppraiseNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }



        /// <summary>
        /// 获取子观点类型数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvPaperSubViewpointEN> GetSubViewpointTypeNumObjLst(string strWhereCond)
        {
            List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>();
            System.Data.DataTable objDT = null;
            objDT = GetSubViewpointTypeNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPaperSubViewpointEN objvPaperSubViewpoint = new clsvPaperSubViewpointEN();

                objvPaperSubViewpoint.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
                objvPaperSubViewpoint.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名
                //objvPaperSubViewpoint.UserName = objRow[convPaperSubViewpoint.UserName].ToString().Trim(); //用户名
                objvPaperSubViewpoint.Memo = objRow["TypeCount"].ToString().Trim(); //统计

                arrObjLst.Add(objvPaperSubViewpoint);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetSubViewpointTypeNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvPaperSubViewpointDAEx.GetSubViewpointTypeNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}