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
        public string A_GeneFuncCode_Java_DefBtnClickEvent(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_Java_DefBtnClickEventGetFirstJSONObj":
                        return Gen_Controller_Java_DefBtnClickEventGetFirstJSONObj();

                    case "Gen_Controller_Java_DefBtnClickEventGetJSONObjByKey":
                        return Gen_Controller_Java_DefBtnClickEventGetJSONObjByKey();

                    case "Gen_Controller_Java_DefBtnClickEventDelRecord":
                        return Gen_Controller_Java_DefBtnClickEventDelRecord();
                    case "Gen_Controller_Java_DefBtnClickEventDelRecordsByJSON":
                        return Gen_Controller_Java_DefBtnClickEventDelRecordsByJSON();
                        
                    case "Gen_Controller_Java_DefBtnClickEventAddNewRecord":
                        return Gen_Controller_Java_DefBtnClickEventAddNewRecord();

                    case "Gen_Controller_Java_DefBtnClickEventAddNewRecord4GetMaxStrId":
                        return Gen_Controller_Java_DefBtnClickEventAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_Java_DefBtnClickEventGetMaxStrId":
                        return Gen_Controller_Java_DefBtnClickEventGetMaxStrId();
                    case "Gen_Controller_Java_DefBtnClickEventGetMaxStrIdByPrefix":
                        return Gen_Controller_Java_DefBtnClickEventGetMaxStrIdByPrefix();

                    case "Gen_Controller_Java_DefBtnClickEventUpdateRecord":
                        return Gen_Controller_Java_DefBtnClickEventUpdateRecord();

                    case "Gen_Controller_Java_DefBtnClickEventIsExistRecord":
                        return Gen_Controller_Java_DefBtnClickEventIsExistRecord();

                    case "Gen_Controller_Java_DefBtnClickEventGetRecCountByCond":
                        return Gen_Controller_Java_DefBtnClickEventGetRecCountByCond();

                    case "Gen_Controller_Java_DefBtnClickEventGetJSONObjLst":
                        return Gen_Controller_Java_DefBtnClickEventGetJSONObjLst();

                    case "Gen_Controller_Java_DefBtnClickEventGetTopJSONObjLst":
                        return Gen_Controller_Java_DefBtnClickEventGetTopJSONObjLst();

                    case "Gen_Controller_Java_DefBtnClickEventGetJSONObjLstByPager":
                        return Gen_Controller_Java_DefBtnClickEventGetJSONObjLstByPager();
                    case "Gen_Controller_Java_DefBtnClickEventtvMsg":
                        return Gen_Controller_Java_DefBtnClickEventtvMsg();
                        
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
        public string Gen_Controller_Java_DefBtnClickEventAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            //string strFunctionName_CN = "����¼�¼";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            //string strFunctionName_CN = "����¼�¼(��ȡ���ؼ���)";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            //string strFunctionName_CN = "��ȡ���ؼ���ֵ";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            //string strFunctionName_CN = "��ȡ���ؼ���ֵ,����ǰ׺";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            //string strFunctionName_CN = "�޸ļ�¼";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }
        public string Gen_Controller_Java_DefBtnClickEventDelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecordsByJSON";
            //string strFunctionName_CN = "ɾ����¼ByJSON";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            //string strFunctionName_CN = "ɾ����¼";
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
        public string Gen_Controller_Java_DefBtnClickEventIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            //string strFunctionName_CN = "����Ƿ���ڼ�¼";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            //string strFunctionName_CN = "����������ȡ��¼��";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }


        public string Gen_Controller_Java_DefBtnClickEventGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLst";
            //string strFunctionName_CN = "��ȡ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopJSONObjLst";
            //string strFunctionName_CN = "��ȡ������¼�����б�";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLstByPager";
            //string strFunctionName_CN = "��ȡ��ҳ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjByKey";
            //string strFunctionName_CN = "���ݹؼ��ֻ�ȡ����";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventtvMsg()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_DefBtnClickEventByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
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
