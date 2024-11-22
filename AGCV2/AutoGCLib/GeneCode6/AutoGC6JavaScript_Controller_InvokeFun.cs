using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;

namespace AutoGCLib
{
    /// <summary>
    /// ����ר�����������ݱ�ı�����,�ô�������߼����һ����,��ϵ�ṹ���µ���,
    /// �������¼���:
    ///		1�������
    ///			ͨ�ý����,ר���ṩһЩ����ؼ��Ĺ�����������
    ///		2���߼���
    ///			2.1 ҵ���߼���
    ///			2.2 �����㡣����:
    ///					1)���¼����ӡ�
    ///					2)���¼��ɾ��
    ///					3)���¼���޸�
    ///					4)���¼�Ĳ�ѯ
    ///					5)��ȡĳЩ���¼���й��ֶ�����
    ///					6)���ñ��¼���й��ֶ����Եȡ�
    ///		3�����ݲ�,��ͨ�����ݲ�,ר�����ڲ������ݿ��һЩ����,�Լ��������һЩͨ�ò���
    /// </summary>
    partial class AutoGC6_Controller : AutoGCPubFuncV6
    {
        public string A_GeneFuncCode_JavaScript_InvokeFun(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_JavaScript_InvokeFunGetFirstJSONObj":
                        return Gen_Controller_JavaScript_InvokeFunGetFirstJSONObj();

                    case "Gen_Controller_JavaScript_InvokeFunGetJSONObjByKey":
                        return Gen_Controller_JavaScript_InvokeFunGetJSONObjByKey();

                    case "Gen_Controller_JavaScript_InvokeFunDelRecord":
                        return Gen_Controller_JavaScript_InvokeFunDelRecord();

                    case "Gen_Controller_JavaScript_InvokeFunAddNewRecord":
                        return Gen_Controller_JavaScript_InvokeFunAddNewRecord();

                    case "Gen_Controller_JavaScript_InvokeFunAddNewRecord4GetMaxStrId":
                        return Gen_Controller_JavaScript_InvokeFunAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_JavaScript_InvokeFunGetMaxStrId":
                        return Gen_Controller_JavaScript_InvokeFunGetMaxStrId();
                    case "Gen_Controller_JavaScript_InvokeFunGetMaxStrIdByPrefix":
                        return Gen_Controller_JavaScript_InvokeFunGetMaxStrIdByPrefix();

                    case "Gen_Controller_JavaScript_InvokeFunUpdateRecord":
                        return Gen_Controller_JavaScript_InvokeFunUpdateRecord();

                    case "Gen_Controller_JavaScript_InvokeFunIsExistRecord":
                        return Gen_Controller_JavaScript_InvokeFunIsExistRecord();

                    case "Gen_Controller_JavaScript_InvokeFunGetRecCountByCond":
                        return Gen_Controller_JavaScript_InvokeFunGetRecCountByCond();

                    case "Gen_Controller_JavaScript_InvokeFunGetJSONObjLst":
                        return Gen_Controller_JavaScript_InvokeFunGetJSONObjLst();

                    case "Gen_Controller_JavaScript_InvokeFunGetTopJSONObjLst":
                        return Gen_Controller_JavaScript_InvokeFunGetTopJSONObjLst();

                    case "Gen_Controller_JavaScript_InvokeFunGetJSONObjLstByPager":
                        return Gen_Controller_JavaScript_InvokeFunGetJSONObjLstByPager();

                    default:
                        string strMsg = string.Format("������:{1}��Switchû�д���,����({0})",
                             clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //            return "///��1����������:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }


        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_InvokeFunAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");
        
            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_InvokeFunIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_Controller_JavaScript_InvokeFunGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLst";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopJSONObjLst";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLstByPager";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjByKey";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_Controller_JavaScript_InvokeFunByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "function {0}()", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}4SD_UnitTest = new vc{0}4SD_UnitTest();", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "obj{0}4SD_UnitTest.btn{1}_Click();", objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }
    }
}
