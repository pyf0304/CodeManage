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
using AGC.PureClass;
using AGC.PureClassEx;

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
        public string A_GeneFuncCode_Java_DefButton(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_WA_Controller_Java_DefButtonGetFirstObj":
                        return Gen_WA_Controller_Java_DefButtonGetFirstObj();

                    case "Gen_WA_Controller_Java_DefButtonGetObjByKey":
                        return Gen_WA_Controller_Java_DefButtonGetObjByKey();

                    case "Gen_WA_Controller_Java_DefButtonDelRecord":
                        return Gen_WA_Controller_Java_DefButtonDelRecord();

                    case "Gen_WA_Controller_Java_DefButtonDelRecordsByJSON":
                        return Gen_WA_Controller_Java_DefButtonDelRecordsByJSON();

                    case "Gen_WA_Controller_Java_DefButtonAddNewRecord":
                        return Gen_WA_Controller_Java_DefButtonAddNewRecord();

                    case "Gen_WA_Controller_Java_DefButtonAddNewRecord4GetMaxStrId":
                        return Gen_WA_Controller_Java_DefButtonAddNewRecord4GetMaxStrId();
                    case "Gen_WA_Controller_Java_DefButtonGetMaxStrId":
                        return Gen_WA_Controller_Java_DefButtonGetMaxStrId();
                    case "Gen_WA_Controller_Java_DefButtonGetMaxStrIdByPrefix":
                        return Gen_WA_Controller_Java_DefButtonGetMaxStrIdByPrefix();

                    case "Gen_WA_Controller_Java_DefButtonUpdateRecord":
                        return Gen_WA_Controller_Java_DefButtonUpdateRecord();

                    case "Gen_WA_Controller_Java_DefButtonIsExistRecord":
                        return Gen_WA_Controller_Java_DefButtonIsExistRecord();

                    case "Gen_WA_Controller_Java_DefButtonGetRecCountByCond":
                        return Gen_WA_Controller_Java_DefButtonGetRecCountByCond();

                    case "Gen_WA_Controller_Java_DefButtonGetObjLst":
                        return Gen_WA_Controller_Java_DefButtonGetObjLst();

                    case "Gen_WA_Controller_Java_DefButtonGetTopObjLst":
                        return Gen_WA_Controller_Java_DefButtonGetTopObjLst();

                    case "Gen_WA_Controller_Java_DefButtonGetObjLstByPager":
                        return Gen_WA_Controller_Java_DefButtonGetObjLstByPager();

                    case "Gen_WA_Controller_Java_DefButtonGetObjLstByRange":
                        return Gen_WA_Controller_Java_DefButtonGetObjLstByRange();

                    case "Gen_WA_Controller_Java_DefButtontvMsg":
                        return Gen_WA_Controller_Java_DefButtontvMsg();
                        
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
        public string Gen_WA_Controller_Java_DefButtonAddNewRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            string strFunctionName_CN = "����¼�¼";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);
        
            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonAddNewRecord4GetMaxStrId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            string strFunctionName_CN = "����¼�¼(��ȡ���ؼ���)";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonGetMaxStrId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            string strFunctionName_CN = "��ȡ���ؼ���ֵ";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);



            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonGetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            string strFunctionName_CN = "��ȡ���ؼ���ֵ,����ǰ׺";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);



            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonUpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            string strFunctionName_CN = "�޸ļ�¼";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);


            return strCodeForCs.ToString();
        }
        public string Gen_WA_Controller_Java_DefButtonDelRecordsByJSON()
        {
            //Gen_WA_Controller_Java_DefButtonDelRecordsByJSON
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "DelRecordsByJSON";
            string strFunctionName_CN = "ɾ����¼ByJSON";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonDelRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "DelRecord";
            string strFunctionName_CN = "ɾ����¼";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_DefButtonIsExistRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            string strFunctionName_CN = "����Ƿ���ڼ�¼";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonGetRecCountByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            string strFunctionName_CN = "����������ȡ��¼��";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            return strCodeForCs.ToString();
        }


        public string Gen_WA_Controller_Java_DefButtonGetObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetObjLst";
            string strFunctionName_CN = "��ȡ��¼�����б�";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonGetTopObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetTopObjLst";
            string strFunctionName_CN = "��ȡ������¼�����б�";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);
            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonGetObjLstByPager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetObjLstByPager";
            string strFunctionName_CN = "��ȡ��ҳ��¼�����б�";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonGetObjLstByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetObjLstByRange";
            string strFunctionName_CN = "��ȡ��Χ�ڼ�¼�����б�";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            return strCodeForCs.ToString();
        }


        public string Gen_WA_Controller_Java_DefButtonGetObjByKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetObjByKey";
            string strFunctionName_CN = "���ݹؼ��ֻ�ȡ����";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);
            
            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonGetFirstObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objAndroidButtonENEx.Text = strFunctionName_CN;
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + " <Button android:id=\"@+id/btn{0}\"", strFunctionName);
            //strCodeForCs.Append("\r\n" + "        android:layout_width=\"wrap_content\"");
            //strCodeForCs.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strCodeForCs.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    strFunctionName_CN);
            //strCodeForCs.Append("\r\n" + "android:textSize=\"12sp\"");
            //strCodeForCs.Append("\r\n" + "android:minHeight=\"35dp\"");
            //strCodeForCs.Append("\r\n" + "        />");


            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtontvMsg()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strCodeForCs.AppendFormat("\r\n" + " <TextView android:id=\"@+id/tvMsg\"", strFunctionName);
            strCodeForCs.Append("\r\n" + "        android:layout_width=\"fill_parent\"");
            strCodeForCs.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strCodeForCs.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    strFunctionName_CN);
            strCodeForCs.Append("\r\n" + "android:textSize=\"12sp\"");
            //strCodeForCs.Append("\r\n" + "android:minHeight=\"35dp\"");
            strCodeForCs.Append("\r\n" + "android:padding=\"10dip\"");
            strCodeForCs.Append("\r\n" + "        />");


            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "fill_parent";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + " <Button android:id=\"@+id/btn{0}\"", 
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "        android:layout_width=\"fill_parent\"");
            //strCodeForCs.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strCodeForCs.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.AppendFormat("\r\n" + "android:onClick = \"btn{0}_Click\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "android:textSize=\"12sp\"");
            //strCodeForCs.Append("\r\n" + "android:minHeight=\"35dp\"");
            //strCodeForCs.Append("\r\n" + "        />");            

            return strCodeForCs.ToString();
        }

        public string GetLinearLayout4FunctionByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            
               StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "fill_parent";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode(enumApplicationType.AndroidApp_5, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + " <Button android:id=\"@+id/btn{0}\"", 
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "        android:layout_width=\"fill_parent\"");
            //strCodeForCs.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strCodeForCs.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.AppendFormat("\r\n" + "android:onClick = \"btn{0}_Click\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "android:textSize=\"12sp\"");
            //strCodeForCs.Append("\r\n" + "android:minHeight=\"35dp\"");
            //strCodeForCs.Append("\r\n" + "        />");            

            return strCodeForCs.ToString();
        }

    }
}
