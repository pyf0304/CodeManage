using com.taishsoft.common;
using com.taishsoft.json;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExamLib.BusinessLogicEx
{
    public class clsvPaperReadWriteBLEx
    {
        private static string strMsg = "";

        public static List<clsvPaperReadWriteEN> GetUserNumObjLst(string strWhereCond)
        {
            List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>();
            System.Data.DataTable objDT = null;
            objDT = GetUserNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();

                objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改用户Id
                objvPaperReadWriteEN.Memo = objRow["Num"].ToString().Trim(); //统计

                //objvPaperReadWriteEN.UserName = objRow[convPaperReadWrite.UserName].ToString().Trim(); //用户名

                //objvPaperReadWriteEN.CollegeName = objRow[convPaperReadWrite.CollegeName].ToString().Trim(); //学院名称
                //objvPaperReadWriteEN.IdXzCollege = objRow[convPaperReadWrite.IdXzCollege].ToString().Trim(); //学院流水号
                //objvPaperReadWriteEN.IdXzMajor = objRow[convPaperReadWrite.IdXzMajor].ToString().Trim(); //专业流水号
                //objvPaperReadWriteEN.MajorName = objRow[convPaperReadWrite.MajorName].ToString().Trim(); //专业名称

                arrObjLst.Add(objvPaperReadWriteEN);
            }
            objDT = null;
            return arrObjLst;
        }



        /// <summary>
        /// 根据条件获取JSON对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static string GetGroupJSONObjLst(string strWhereCond)
        {
            List<clsvPaperReadWriteEN> arrObjLst = GetUserNumObjLst(strWhereCond);
            string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
            return strJSON;
        }


        public static DataTable GetUserNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvPaperReadWriteDAEx.GetUserNumDataTable(strWhereCond);
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
