using com.taishsoft.common;
using com.taishsoft.json;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExamLib.BusinessLogicEx
{

    public class clsvSysScoreSummaryBLEx: clsvSysScoreSummaryBL
    {
        private static string strMsg = "";
        /// <summary>
        /// 获取论文中的用户数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvSysScoreSummaryEN> GetUserNumObjLst(string strWhereCond)
        {
            List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>();
            System.Data.DataTable objDT = null;
            objDT = GetUserNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();

                objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户Id
                objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名


                objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
                objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称

                objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
                objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级
               

                arrObjLst.Add(objvSysScoreSummaryEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetUserNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvSysScoreSummaryDAEx.GetUserNumDataTable(strWhereCond);
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
