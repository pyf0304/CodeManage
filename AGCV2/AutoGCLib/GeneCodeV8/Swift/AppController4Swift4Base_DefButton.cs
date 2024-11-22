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
using AgcCommBase;
using AGC.PureClass;

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
        public ISOButtonEx A_GeneFuncCode_Swift4_DefButton(string strFuncName, string strViewControllerID, ref int intY)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_Swift4_DefButtonGetFirstJSONObj":
                        return Gen_Controller_Swift4_DefButtonGetFirstJSONObj(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonGetJSONObjByKey":
                        return Gen_Controller_Swift4_DefButtonGetJSONObjByKey(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonDelRecord":
                        return Gen_Controller_Swift4_DefButtonDelRecord(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonAddNewRecord":
                        return Gen_Controller_Swift4_DefButtonAddNewRecord(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonAddNewRecord4GetMaxStrId":
                        return Gen_Controller_Swift4_DefButtonAddNewRecord4GetMaxStrId(strViewControllerID, ref intY);
                    case "Gen_Controller_Swift4_DefButtonGetMaxStrId":
                        return Gen_Controller_Swift4_DefButtonGetMaxStrId(strViewControllerID, ref intY);
                    case "Gen_Controller_Swift4_DefButtonGetMaxStrIdByPrefix":
                        return Gen_Controller_Swift4_DefButtonGetMaxStrIdByPrefix(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonUpdateRecord":
                        return Gen_Controller_Swift4_DefButtonUpdateRecord(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonIsExistRecord":
                        return Gen_Controller_Swift4_DefButtonIsExistRecord(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonGetRecCountByCond":
                        return Gen_Controller_Swift4_DefButtonGetRecCountByCond(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonGetJSONObjLst":
                        return Gen_Controller_Swift4_DefButtonGetJSONObjLst(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonGetTopJSONObjLst":
                        return Gen_Controller_Swift4_DefButtonGetTopJSONObjLst(strViewControllerID, ref intY);

                    case "Gen_Controller_Swift4_DefButtonGetJSONObjLstByPager":
                        return Gen_Controller_Swift4_DefButtonGetJSONObjLstByPager(strViewControllerID, ref intY);
                    //case "Gen_Controller_Swift4_DefButtontvMsg":
                    //    return Gen_Controller_Swift4_DefButtontvMsg(strViewControllerID, ref intY);
                        
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
        public ISOButtonEx Gen_Controller_Swift4_DefButtonAddNewRecord(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            string strFunctionName_CN = "����¼�¼";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
           
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonAddNewRecord4GetMaxStrId(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            string strFunctionName_CN = "����¼�¼(��ȡ���ؼ���)";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;

            //return strBuilder.ToString();
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonGetMaxStrId(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            string strFunctionName_CN = "��ȡ���ؼ���ֵ";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonGetMaxStrIdByPrefix(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            string strFunctionName_CN = "��ȡ���ؼ���ֵ,����ǰ׺";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonUpdateRecord(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            string strFunctionName_CN = "�޸ļ�¼";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonDelRecord(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            string strFunctionName_CN = "ɾ����¼";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public ISOButtonEx Gen_Controller_Swift4_DefButtonIsExistRecord(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            string strFunctionName_CN = "����Ƿ���ڼ�¼";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonGetRecCountByCond(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            string strFunctionName_CN = "����������ȡ��¼��";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }


        public ISOButtonEx Gen_Controller_Swift4_DefButtonGetJSONObjLst(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLst";
            string strFunctionName_CN = "��ȡ��¼�����б�";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonGetTopJSONObjLst(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopJSONObjLst";
            string strFunctionName_CN = "��ȡ������¼�����б�";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonGetJSONObjLstByPager(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLstByPager";
            string strFunctionName_CN = "��ȡ��ҳ��¼�����б�";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonGetJSONObjByKey(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjByKey";
            string strFunctionName_CN = "���ݹؼ��ֻ�ȡ����";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonGetFirstJSONObj(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();

            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strFunctionName_CN;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click",  strFunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);

            return objISOButtonEN;
        }


        public static ISOButtonEx GetISOButton4NavigitionBar_Swift4(
            string strText, 
            string strViewControllerID,
            string strEventFunc)
        {
           
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName = "GetFirstJSONObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            string strButtonId = AgcPubFun.getSwiftID();
            
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            //objISOButtonEN.IsoControlName = strFunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = strText;
            objISOButtonEN.y = 7;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            objISOButtonEN.mKey = "customView";
            ISOAutoresizingMaskEx objISOAutoresizingMaskEN = new ISOAutoresizingMaskEx();
        
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOAutoresizingMaskEN);

            if (string .IsNullOrEmpty(strEventFunc) == false)
            {
                ISOActionEx objISOActionEN = new ISOActionEx();
                objISOActionEN.destination = strViewControllerID;
                objISOActionEN.EventFuncName = strEventFunc;
                objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            }
            return objISOButtonEN;
        }
        public string Gen_Controller_Swift4_DefButtontvMsg(string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + " <TextView android:id=\"@+id/tvMsg\"", strFunctionName);
            strBuilder.Append("\r\n" + "        android:layout_width=\"fill_parent\"");
            strBuilder.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strBuilder.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    strFunctionName_CN);
            strBuilder.Append("\r\n" + "android:textSize=\"12sp\"");
            //strBuilder.Append("\r\n" + "android:minHeight=\"35dp\"");
            strBuilder.Append("\r\n" + "android:padding=\"10dip\"");
            strBuilder.Append("\r\n" + "        />");


            return strBuilder.ToString();
        }

        public ISOButtonEx Gen_Controller_Swift4_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx, string strViewControllerID, ref int intY)
        {
            intY += 30;
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";

            string strButtonId = AgcPubFun.getSwiftID();
            string strActionId = AgcPubFun.getSwiftID();
            
            ISOButtonEx objISOButtonEN = new ISOButtonEx();
            objISOButtonEN.IsoControlId = strButtonId;
            objISOButtonEN.IsoControlName = objWebSrvFunctionsENEx.FunctionName;
            objISOButtonEN.ParentViewControllerID = strViewControllerID;
            objISOButtonEN.Text = objWebSrvFunctionsENEx.FunctionName;
            objISOButtonEN.y = intY;
            objISOButtonEN.x = 0;
            objISOButtonEN.Width = 130;
            objISOButtonEN.Height = 30;
            ISOActionEx objISOActionEN = new ISOActionEx();
            objISOActionEN.destination = strViewControllerID;
            objISOActionEN.EventFuncName = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName);
            objISOButtonEN.arrSubIsoControlLst2.Add(objISOActionEN);
            return objISOButtonEN;
                       
        }
    }
}
