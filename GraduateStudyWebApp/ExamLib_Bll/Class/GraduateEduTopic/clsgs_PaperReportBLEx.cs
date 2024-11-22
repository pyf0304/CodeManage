
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_PaperReportBLEx
表名:gs_PaperReport(01120772)
生成代码版本:2020.11.22.1
生成日期:2020/11/30 18:49:46
生成者:yy
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
using System.Data;

namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_PaperReportBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_PaperReportENS">源对象</param>
        /// <returns>目标对象=>clsgs_PaperReportEN:objgs_PaperReportENT</returns>
        public static clsgs_PaperReportENEx CopyToEx(this clsgs_PaperReportEN objgs_PaperReportENS)
        {
            try
            {
                clsgs_PaperReportENEx objgs_PaperReportENT = new clsgs_PaperReportENEx();
                clsgs_PaperReportBL.gs_PaperReportDA.CopyTo(objgs_PaperReportENS, objgs_PaperReportENT);
                return objgs_PaperReportENT;
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
        /// <param name = "objgs_PaperReportENS">源对象</param>
        /// <returns>目标对象=>clsgs_PaperReportEN:objgs_PaperReportENT</returns>
        public static clsgs_PaperReportEN CopyTo(this clsgs_PaperReportENEx objgs_PaperReportENS)
        {
            try
            {
                clsgs_PaperReportEN objgs_PaperReportENT = new clsgs_PaperReportEN();
                clsgs_PaperReportBL.CopyTo(objgs_PaperReportENS, objgs_PaperReportENT);
                return objgs_PaperReportENT;
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
    /// 论文汇报表(gs_PaperReport)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_PaperReportBLEx : clsgs_PaperReportBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_PaperReportDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_PaperReportDAEx gs_PaperReportDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_PaperReportDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_PaperReportENS">源对象</param>
        /// <returns>目标对象=>clsgs_PaperReportEN:objgs_PaperReportENT</returns>
        public static clsgs_PaperReportENEx CopyToEx(clsgs_PaperReportEN objgs_PaperReportENS)
        {
            try
            {
                clsgs_PaperReportENEx objgs_PaperReportENT = new clsgs_PaperReportENEx();
                clsgs_PaperReportBL.gs_PaperReportDA.CopyTo(objgs_PaperReportENS, objgs_PaperReportENT);
                return objgs_PaperReportENT;
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
        public static List<clsgs_PaperReportENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_PaperReportEN> arrObjLst = clsgs_PaperReportBL.GetObjLst(strCondition);
            List<clsgs_PaperReportENEx> arrObjExLst = new List<clsgs_PaperReportENEx>();
            foreach (clsgs_PaperReportEN objInFor in arrObjLst)
            {
                clsgs_PaperReportENEx objgs_PaperReportENEx = new clsgs_PaperReportENEx();
                clsgs_PaperReportBL.CopyTo(objInFor, objgs_PaperReportENEx);
                arrObjExLst.Add(objgs_PaperReportENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strReportId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_PaperReportENEx GetObjExByReportId(string strReportId)
        {
            clsgs_PaperReportEN objgs_PaperReportEN = clsgs_PaperReportBL.GetObjByReportId(strReportId);
            clsgs_PaperReportENEx objgs_PaperReportENEx = new clsgs_PaperReportENEx();
            clsgs_PaperReportBL.CopyTo(objgs_PaperReportEN, objgs_PaperReportENEx);
            return objgs_PaperReportENEx;
        }


        private static string strMsg = "";

        /// <summary>
        /// 获取论文汇报月份数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsgs_PaperReportEN> GetReportMonthNumObjLst(string strCondition)
        {
            List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>();
            System.Data.DataTable objDT = null;
            objDT = GetReportMonthNumDataTable(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();

                objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month].ToString().Trim(); //月份
                objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year].ToString().Trim(); //年
                objgs_PaperReportEN.Memo = objRow["MonthNum"].ToString().Trim(); //统计
                arrObjLst.Add(objgs_PaperReportEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetReportMonthNumDataTable(string strCondition)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsgs_PaperReportDAEx.GetReportMonthNumDataTable(strCondition);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strCondition,
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取论文汇报月份数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsgs_PaperReportEN> GetReportYearNumObjLst(string strCondition)
        {
            List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>();
            System.Data.DataTable objDT = null;
            objDT = GetReportYearNumDataTable(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
                objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year].ToString().Trim(); //年
                objgs_PaperReportEN.Memo = objRow["YearNum"].ToString().Trim(); //统计
                arrObjLst.Add(objgs_PaperReportEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetReportYearNumDataTable(string strCondition)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsgs_PaperReportDAEx.GetReportYearNumDataTable(strCondition);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strCondition,
                objException.Message);
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 获取论文汇报日期合并
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsgs_PaperReportEN> GetReportDateNumObjLst(string strCondition)
        {
            List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>();
            System.Data.DataTable objDT = null;
            objDT = GetReportDateNumDataTable(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
                objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate].ToString().Trim(); //年
                objgs_PaperReportEN.Memo = objRow["ReportDateNum"].ToString().Trim(); //统计
                arrObjLst.Add(objgs_PaperReportEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetReportDateNumDataTable(string strCondition)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsgs_PaperReportDAEx.GetReportDateNumDataTable(strCondition);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strCondition,
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}