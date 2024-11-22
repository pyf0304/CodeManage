using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using com.taishsoft.commdb;
namespace ExamLib.BusinessLogic
{
    public class ErrorInformationBL
    {
        public static bool AddInformation(string strPageName, string strFunctionName, string strErrorInformation, string strUserId)
        {
            if (strPageName == null)
            {
                throw new Exception("strPageName����ΪNULL");
            }
            if (strFunctionName == null)
            {
                throw new Exception("strFunctionName����ΪNULL");
            }
            if (strErrorInformation == null)
            {
                throw new Exception("strErrorInformation����ΪNULL");
            }
            if (strUserId == null)
            {
                throw new Exception("strUserId����ΪNULL");
            }
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            ArrayList arrValues = new ArrayList();
            arrValues.Add(strPageName);
            arrValues.Add(strFunctionName);
            arrValues.Add(strErrorInformation);
            arrValues.Add(strUserId);
            bool bolResult = objSQL.ExecSP2("AddErrorInformaion", arrValues);
//            clsGeneralTab2.LogErrorS2("AddInformation", "AddInformation", "clsSpecSQLforSql.strWebRoot=" + clsSpecSQLforSql.strWebRoot, "", "");
            return bolResult;
        }
    }
}
