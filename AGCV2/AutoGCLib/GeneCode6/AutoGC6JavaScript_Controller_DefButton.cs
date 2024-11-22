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
    /// ����ר�����������ݱ��ı�������,�ô��������߼����һ����,��ϵ�ṹ���µ���,
    /// �������¼���:
    ///		1�������
    ///			ͨ�ý����,ר���ṩһЩ����ؼ��Ĺ�����������
    ///		2���߼���
    ///			2.1 ҵ���߼���
    ///			2.2 �������㡣����:
    ///					1)����¼�����ӡ�
    ///					2)����¼��ɾ��
    ///					3)����¼���޸�
    ///					4)����¼�Ĳ�ѯ
    ///					5)��ȡĳЩ����¼���й��ֶ�����
    ///					6)���ñ���¼���й��ֶ����Եȡ�
    ///		3�����ݲ�,��ͨ�����ݲ�,ר�����ڲ������ݿ��һЩ����,�Լ���������һЩͨ�ò���
    /// </summary>
    partial class AutoGC6_Controller : AutoGCPubFuncV6
    {
        public string A_GeneFuncCode_JavaScript_DefButton(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_JavaScript_DefButtonGetFirstJSONObj":
                        return Gen_Controller_JavaScript_DefButtonGetFirstJSONObj();

                    case "Gen_Controller_JavaScript_DefButtonGetJSONObjByKey":
                        return Gen_Controller_JavaScript_DefButtonGetJSONObjByKey();

                    case "Gen_Controller_JavaScript_DefButtonDelRecord":
                        return Gen_Controller_JavaScript_DefButtonDelRecord();

                    case "Gen_Controller_JavaScript_DefButtonAddNewRecord":
                        return Gen_Controller_JavaScript_DefButtonAddNewRecord();

                    case "Gen_Controller_JavaScript_DefButtonAddNewRecord4GetMaxStrId":
                        return Gen_Controller_JavaScript_DefButtonAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_JavaScript_DefButtonGetMaxStrId":
                        return Gen_Controller_JavaScript_DefButtonGetMaxStrId();
                    case "Gen_Controller_JavaScript_DefButtonGetMaxStrIdByPrefix":
                        return Gen_Controller_JavaScript_DefButtonGetMaxStrIdByPrefix();

                    case "Gen_Controller_JavaScript_DefButtonUpdateRecord":
                        return Gen_Controller_JavaScript_DefButtonUpdateRecord();

                    case "Gen_Controller_JavaScript_DefButtonIsExistRecord":
                        return Gen_Controller_JavaScript_DefButtonIsExistRecord();

                    case "Gen_Controller_JavaScript_DefButtonGetRecCountByCond":
                        return Gen_Controller_JavaScript_DefButtonGetRecCountByCond();

                    case "Gen_Controller_JavaScript_DefButtonGetJSONObjLst":
                        return Gen_Controller_JavaScript_DefButtonGetJSONObjLst();

                    case "Gen_Controller_JavaScript_DefButtonGetTopJSONObjLst":
                        return Gen_Controller_JavaScript_DefButtonGetTopJSONObjLst();

                    case "Gen_Controller_JavaScript_DefButtonGetJSONObjLstByPager":
                        return Gen_Controller_JavaScript_DefButtonGetJSONObjLstByPager();

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
        public string Gen_Controller_JavaScript_DefButtonAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            string strFunctionName_CN = "�����¼�¼";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />", 
                strFunctionName, strFunctionName_CN);
        
            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            string strFunctionName_CN = "�����¼�¼(��ȡ���ؼ���)";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            string strFunctionName_CN = "��ȡ���ؼ���ֵ";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            string strFunctionName_CN = "��ȡ���ؼ���ֵ,����ǰ׺";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            string strFunctionName_CN = "�޸ļ�¼";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            string strFunctionName_CN = "ɾ����¼";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_DefButtonIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            string strFunctionName_CN = "����Ƿ���ڼ�¼";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            string strFunctionName_CN = "����������ȡ��¼��";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }


        public string Gen_Controller_JavaScript_DefButtonGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLst";
            string strFunctionName_CN = "��ȡ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopJSONObjLst";
            string strFunctionName_CN = "��ȡ������¼�����б�";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLstByPager";
            string strFunctionName_CN = "��ȡ��ҳ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjByKey";
            string strFunctionName_CN = "���ݹؼ��ֻ�ȡ����";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }
        public string Gen_Controller_JavaScript_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";

            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                objWebSrvFunctionsENEx.FunctionName, objWebSrvFunctionsENEx.FunctionName);

            return strBuilder.ToString();
        }
    }
}