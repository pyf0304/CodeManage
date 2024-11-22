
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvgs_TotalDataStatisticsBLEx
表名:vgs_TotalDataStatistics(01120682)
生成代码版本:2020.06.21.1
生成日期:2020/06/23 22:48:03
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
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
    public static class clsvgs_TotalDataStatisticsBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvgs_TotalDataStatisticsENS">源对象</param>
        /// <returns>目标对象=>clsvgs_TotalDataStatisticsEN:objvgs_TotalDataStatisticsENT</returns>
        public static clsvgs_TotalDataStatisticsENEx CopyToEx(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsENS)
        {
            try
            {
                clsvgs_TotalDataStatisticsENEx objvgs_TotalDataStatisticsENT = new clsvgs_TotalDataStatisticsENEx();
                clsvgs_TotalDataStatisticsBL.vgs_TotalDataStatisticsDA.CopyTo(objvgs_TotalDataStatisticsENS, objvgs_TotalDataStatisticsENT);
                return objvgs_TotalDataStatisticsENT;
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
        /// <param name = "objvgs_TotalDataStatisticsENS">源对象</param>
        /// <returns>目标对象=>clsvgs_TotalDataStatisticsEN:objvgs_TotalDataStatisticsENT</returns>
        public static clsvgs_TotalDataStatisticsEN CopyTo(this clsvgs_TotalDataStatisticsENEx objvgs_TotalDataStatisticsENS)
        {
            try
            {
                clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsENT = new clsvgs_TotalDataStatisticsEN();
                clsvgs_TotalDataStatisticsBL.CopyTo(objvgs_TotalDataStatisticsENS, objvgs_TotalDataStatisticsENT);
                return objvgs_TotalDataStatisticsENT;
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
    /// 总数据统计视图(vgs_TotalDataStatistics)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvgs_TotalDataStatisticsBLEx : clsvgs_TotalDataStatisticsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvgs_TotalDataStatisticsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvgs_TotalDataStatisticsDAEx vgs_TotalDataStatisticsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvgs_TotalDataStatisticsDAEx();
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
        public static List<clsvgs_TotalDataStatisticsENEx> GetObjExLst(string strCondition)
        {
            List<clsvgs_TotalDataStatisticsEN> arrObjLst = clsvgs_TotalDataStatisticsBL.GetObjLst(strCondition);
            List<clsvgs_TotalDataStatisticsENEx> arrObjExLst = new List<clsvgs_TotalDataStatisticsENEx>();
            foreach (clsvgs_TotalDataStatisticsEN objInFor in arrObjLst)
            {
                clsvgs_TotalDataStatisticsENEx objvgs_TotalDataStatisticsENEx = new clsvgs_TotalDataStatisticsENEx();
                clsvgs_TotalDataStatisticsBL.CopyTo(objInFor, objvgs_TotalDataStatisticsENEx);
                arrObjExLst.Add(objvgs_TotalDataStatisticsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvgs_TotalDataStatisticsENEx GetObjExBymId(string lngmId)
        {
            clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = clsvgs_TotalDataStatisticsBL.GetObjByTotalDataId(lngmId);
            clsvgs_TotalDataStatisticsENEx objvgs_TotalDataStatisticsENEx = new clsvgs_TotalDataStatisticsENEx();
            clsvgs_TotalDataStatisticsBL.CopyTo(objvgs_TotalDataStatisticsEN, objvgs_TotalDataStatisticsENEx);
            return objvgs_TotalDataStatisticsENEx;
        }



        private static string strMsg = "";

        /// <summary>
        /// 获取用户统计数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvgs_TotalDataStatisticsEN> GetUserNumObjLst(string strWhereCond)
        {
            List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>();
            System.Data.DataTable objDT = null;
            objDT = GetUserNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatistics = new clsvgs_TotalDataStatisticsEN();


                objvgs_TotalDataStatistics.DataUser = objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //用户
                objvgs_TotalDataStatistics.Memo = objRow["Num"].ToString().Trim(); //统计
                arrObjLst.Add(objvgs_TotalDataStatistics);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetUserNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvgs_TotalDataStatisticsDAEx.GetUserNumDataTable(strWhereCond);
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
        /// 获取周统计数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvgs_TotalDataStatisticsEN> GetWeekNumObjLst(string strWhereCond)
        {
            List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>();
            System.Data.DataTable objDT = null;
            objDT = GetWeekNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatistics = new clsvgs_TotalDataStatisticsEN();

                
                objvgs_TotalDataStatistics.Week = int.Parse(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
                objvgs_TotalDataStatistics.Memo = objRow["Num"].ToString().Trim(); //统计
                objvgs_TotalDataStatistics.WeekTimeRange = objRow["WeekTimeRange"].ToString().Trim(); //周范围
                arrObjLst.Add(objvgs_TotalDataStatistics);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetWeekNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvgs_TotalDataStatisticsDAEx.GetWeekNumDataTable(strWhereCond);
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

        //获取教学班周教师打分平均分
        /// <summary>
        /// 获取周统计数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvgs_TotalDataStatisticsEN> GetWeekAVGTeaScoreObjLst(string strWhereCond)
        {
            List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>();
            System.Data.DataTable objDT = null;
            objDT = GetWeekAVGTeaScoreDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatistics = new clsvgs_TotalDataStatisticsEN();


                objvgs_TotalDataStatistics.Week = int.Parse(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
                objvgs_TotalDataStatistics.Memo = objRow["TeaScore"].ToString().Trim(); //平均分统计
                objvgs_TotalDataStatistics.WeekTimeRange = objRow["WeekTimeRange"].ToString().Trim(); //周范围
                arrObjLst.Add(objvgs_TotalDataStatistics);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetWeekAVGTeaScoreDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvgs_TotalDataStatisticsDAEx.GetWeekAVGTeaScoreDataTable(strWhereCond);
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
        /// 获取周、用户统计数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvgs_TotalDataStatisticsEN> GetUser_WeekNumObjLst(string strWhereCond)
        {
            List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>();
            System.Data.DataTable objDT = null;
            objDT = GetUser_WeekNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatistics = new clsvgs_TotalDataStatisticsEN();

                objvgs_TotalDataStatistics.DataUser = objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //用户
                objvgs_TotalDataStatistics.Week = int.Parse(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
                objvgs_TotalDataStatistics.Memo = objRow["Num"].ToString().Trim(); //统计
                objvgs_TotalDataStatistics.WeekTimeRange = objRow["WeekTimeRange"].ToString().Trim(); //周范围

                arrObjLst.Add(objvgs_TotalDataStatistics);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetUser_WeekNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvgs_TotalDataStatisticsDAEx.GetUser_WeekNumDataTable(strWhereCond);
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