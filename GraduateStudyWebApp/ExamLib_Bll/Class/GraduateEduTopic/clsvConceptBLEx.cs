using com.taishsoft.common;
using ExamLib.DAL;
using ExamLib.Entity;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLibBll.BLLEX.GraduateEdu
{
    public class clsvConceptBLEx
    {
        public clsvConceptBLEx() { }


        public static DataTable GetUserByConcept(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvConceptDAEx.GetUserByConcept(strWhereCond);
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
