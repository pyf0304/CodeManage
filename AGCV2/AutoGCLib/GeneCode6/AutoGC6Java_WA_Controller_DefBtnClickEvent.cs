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
    partial class AutoGC6_WA_Controller : AutoGCPubFuncV6
    {
        public string A_GeneFuncCode_Java_DefBtnClickEvent(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetFirstObj":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetFirstObj();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetObjByKey":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetObjByKey();

                    case "Gen_WA_Controller_Java_DefBtnClickEventDelRecord":
                        return Gen_WA_Controller_Java_DefBtnClickEventDelRecord();
                    case "Gen_WA_Controller_Java_DefBtnClickEventDelRecordsByJSON":
                        return Gen_WA_Controller_Java_DefBtnClickEventDelRecordsByJSON();
                        
                    case "Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord":
                        return Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord();

                    case "Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord4GetMaxStrId":
                        return Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord4GetMaxStrId();
                    case "Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrId":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrId();
                    case "Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrIdByPrefix":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrIdByPrefix();

                    case "Gen_WA_Controller_Java_DefBtnClickEventUpdateRecord":
                        return Gen_WA_Controller_Java_DefBtnClickEventUpdateRecord();

                    case "Gen_WA_Controller_Java_DefBtnClickEventIsExistRecord":
                        return Gen_WA_Controller_Java_DefBtnClickEventIsExistRecord();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetRecCountByCond":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetRecCountByCond();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetObjLst":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetObjLst();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetTopObjLst":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetTopObjLst();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetObjLstByPager":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetObjLstByPager();
                    case "Gen_WA_Controller_Java_DefBtnClickEventtvMsg":
                        return Gen_WA_Controller_Java_DefBtnClickEventtvMsg();
                        
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
        public string Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }
        public string Gen_WA_Controller_Java_DefBtnClickEventDelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecordsByJSON";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_DefBtnClickEventIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }


        public string Gen_WA_Controller_Java_DefBtnClickEventGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLst";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopObjLst";

            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLstByPager";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjByKey";

            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";

            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventtvMsg()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
                   

            return strBuilder.ToString();
        }
    }
}
