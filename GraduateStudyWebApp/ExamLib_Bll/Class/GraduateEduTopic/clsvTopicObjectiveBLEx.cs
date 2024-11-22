using com.taishsoft.common;
using ExamLib.Entity;
using ExamLib.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLibBll.BLLEX.GraduateEdu
{
    public class clsvTopicObjectiveBLEx
    {
        public clsvTopicObjectiveBLEx() { }

        /// <summary>
        /// 获取观点中的用户数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvTopicObjectiveEN> GetTopicObjectiveUserObjLst(string strWhereCond)
        {
            List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>();
            System.Data.DataTable objDT = null;
            objDT = GetUserByTopicObjective(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();

                objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改用户Id
               // objvTopicObjectiveEN.UserName = objRow[convTopicObjective.UserName].ToString().Trim(); //用户名

                arrObjLst.Add(objvTopicObjectiveEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetUserByTopicObjective(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvTopicObjectiveDAEx.GetUserByTopicObjective(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}
