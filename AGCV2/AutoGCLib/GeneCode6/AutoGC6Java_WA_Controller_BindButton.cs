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
        public string A_GeneFuncCode_Java_BindButton(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_WA_Controller_Java_BindButtonGetFirstObj":
                        return Gen_WA_Controller_Java_BindButtonGetFirstObj();

                    case "Gen_WA_Controller_Java_BindButtonGetObjByKey":
                        return Gen_WA_Controller_Java_BindButtonGetObjByKey();

                    case "Gen_WA_Controller_Java_BindButtonDelRecord":
                        return Gen_WA_Controller_Java_BindButtonDelRecord();

                    case "Gen_WA_Controller_Java_BindButtonDelRecordsByJSON":
                        return Gen_WA_Controller_Java_BindButtonDelRecordsByJSON();

                    case "Gen_WA_Controller_Java_BindButtonAddNewRecord":
                        return Gen_WA_Controller_Java_BindButtonAddNewRecord();

                    case "Gen_WA_Controller_Java_BindButtonAddNewRecord4GetMaxStrId":
                        return Gen_WA_Controller_Java_BindButtonAddNewRecord4GetMaxStrId();
                    case "Gen_WA_Controller_Java_BindButtonGetMaxStrId":
                        return Gen_WA_Controller_Java_BindButtonGetMaxStrId();
                    case "Gen_WA_Controller_Java_BindButtonGetMaxStrIdByPrefix":
                        return Gen_WA_Controller_Java_BindButtonGetMaxStrIdByPrefix();

                    case "Gen_WA_Controller_Java_BindButtonUpdateRecord":
                        return Gen_WA_Controller_Java_BindButtonUpdateRecord();

                    case "Gen_WA_Controller_Java_BindButtonIsExistRecord":
                        return Gen_WA_Controller_Java_BindButtonIsExistRecord();

                    case "Gen_WA_Controller_Java_BindButtonGetRecCountByCond":
                        return Gen_WA_Controller_Java_BindButtonGetRecCountByCond();

                    case "Gen_WA_Controller_Java_BindButtonGetObjLst":
                        return Gen_WA_Controller_Java_BindButtonGetObjLst();

                    case "Gen_WA_Controller_Java_BindButtonGetTopObjLst":
                        return Gen_WA_Controller_Java_BindButtonGetTopObjLst();

                    case "Gen_WA_Controller_Java_BindButtonGetObjLstByPager":
                        return Gen_WA_Controller_Java_BindButtonGetObjLstByPager();
                    case "Gen_WA_Controller_Java_BindButtontvMsg":
                        return Gen_WA_Controller_Java_BindButtontvMsg();
                        
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
        public string Gen_WA_Controller_Java_BindButtonAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            //string strFunctionName_CN = "����¼�¼";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);
        
            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            //string strFunctionName_CN = "����¼�¼(��ȡ���ؼ���)";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            //string strFunctionName_CN = "��ȡ���ؼ���ֵ";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            //string strFunctionName_CN = "��ȡ���ؼ���ֵ,����ǰ׺";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            //string strFunctionName_CN = "�޸ļ�¼";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            //string strFunctionName_CN = "ɾ����¼";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }
        public string Gen_WA_Controller_Java_BindButtonDelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecordsByJSON";
            //string strFunctionName_CN = "ɾ����¼ByJSON";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_BindButtonIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            //string strFunctionName_CN = "����Ƿ���ڼ�¼";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            //string strFunctionName_CN = "����������ȡ��¼��";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }


        public string Gen_WA_Controller_Java_BindButtonGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLst";
            //string strFunctionName_CN = "��ȡ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopObjLst";
            //string strFunctionName_CN = "��ȡ������¼�����б�";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLstByPager";
            //string strFunctionName_CN = "��ȡ��ҳ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjByKey";
            //string strFunctionName_CN = "���ݹؼ��ֻ�ȡ����";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtontvMsg()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", 
                objWebSrvFunctionsENEx.FunctionName);

            return strBuilder.ToString();
        }
    }
}
