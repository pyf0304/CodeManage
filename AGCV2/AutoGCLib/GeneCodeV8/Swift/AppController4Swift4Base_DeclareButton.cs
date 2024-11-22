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
    partial class AppController4Swift4Base : clsGeneCodeBase
    {
        public string A_GeneFuncCode_Swift4_DeclareButton(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_Swift4_DeclareButtonGetFirstJSONObj":
                        return Gen_Controller_Swift4_DeclareButtonGetFirstJSONObj();

                    case "Gen_Controller_Swift4_DeclareButtonGetJSONObjByKey":
                        return Gen_Controller_Swift4_DeclareButtonGetJSONObjByKey();

                    case "Gen_Controller_Swift4_DeclareButtonDelRecord":
                        return Gen_Controller_Swift4_DeclareButtonDelRecord();

                    case "Gen_Controller_Swift4_DeclareButtonAddNewRecord":
                        return Gen_Controller_Swift4_DeclareButtonAddNewRecord();

                    case "Gen_Controller_Swift4_DeclareButtonAddNewRecord4GetMaxStrId":
                        return Gen_Controller_Swift4_DeclareButtonAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_Swift4_DeclareButtonGetMaxStrId":
                        return Gen_Controller_Swift4_DeclareButtonGetMaxStrId();
                    case "Gen_Controller_Swift4_DeclareButtonGetMaxStrIdByPrefix":
                        return Gen_Controller_Swift4_DeclareButtonGetMaxStrIdByPrefix();

                    case "Gen_Controller_Swift4_DeclareButtonUpdateRecord":
                        return Gen_Controller_Swift4_DeclareButtonUpdateRecord();

                    case "Gen_Controller_Swift4_DeclareButtonIsExistRecord":
                        return Gen_Controller_Swift4_DeclareButtonIsExistRecord();

                    case "Gen_Controller_Swift4_DeclareButtonGetRecCountByCond":
                        return Gen_Controller_Swift4_DeclareButtonGetRecCountByCond();

                    case "Gen_Controller_Swift4_DeclareButtonGetJSONObjLst":
                        return Gen_Controller_Swift4_DeclareButtonGetJSONObjLst();

                    case "Gen_Controller_Swift4_DeclareButtonGetTopJSONObjLst":
                        return Gen_Controller_Swift4_DeclareButtonGetTopJSONObjLst();

                    case "Gen_Controller_Swift4_DeclareButtonGetJSONObjLstByPager":
                        return Gen_Controller_Swift4_DeclareButtonGetJSONObjLstByPager();
                    case "Gen_Controller_Swift4_DeclareButtontvMsg":
                        return Gen_Controller_Swift4_DeclareButtontvMsg();
                        
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
        public string Gen_Controller_Swift4_DeclareButtonAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            //string strFunctionName_CN = "����¼�¼";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);
        
            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            //string strFunctionName_CN = "����¼�¼(��ȡ���ؼ���)";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            //string strFunctionName_CN = "��ȡ���ؼ���ֵ";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            //string strFunctionName_CN = "��ȡ���ؼ���ֵ,����ǰ׺";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            //string strFunctionName_CN = "�޸ļ�¼";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            //string strFunctionName_CN = "ɾ����¼";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);

            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_DeclareButtonIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            //string strFunctionName_CN = "����Ƿ���ڼ�¼";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            //string strFunctionName_CN = "����������ȡ��¼��";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }


        public string Gen_Controller_Swift4_DeclareButtonGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLst";
            //string strFunctionName_CN = "��ȡ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopJSONObjLst";
            //string strFunctionName_CN = "��ȡ������¼�����б�";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLstByPager";
            //string strFunctionName_CN = "��ȡ��ҳ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjByKey";
            //string strFunctionName_CN = "���ݹؼ��ֻ�ȡ����";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtonGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_DeclareButtontvMsg()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            ////string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", strFunctionName);

            return strBuilder.ToString();
        }
        public string Gen_Controller_Swift4_DeclareButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "@IBOutlet weak var btn{0}: UIButton!", objWebSrvFunctionsENEx.FunctionName);
            return strBuilder.ToString();
        }
    }
}
