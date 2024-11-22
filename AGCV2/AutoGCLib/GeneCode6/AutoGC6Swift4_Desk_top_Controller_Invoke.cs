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



        public string Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "func invokeGetJSONObjByKey(vcParentView : NSObject) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetObjBy{1} : icls{0}GetObjBy{1} = icls{0}GetObjBy{1}(pvcParent: vcParentView);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_Desk_top_InvokeGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeGetFirstJSONObj(vcParentView : NSObject) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetFirstObj : icls{0}GetFirstObj = icls{0}GetFirstObj(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_Desk_top_InvokeByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Swift���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
            }
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ú�����[{0}]", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "func Invoke{0}(vcParentView : NSObject) ",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}_{1} : icls{0}_{1} = icls{0}_{1}(pvcParent: vcParentView);",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
              
        public string Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "func invokeGetJSONObjLst(vcParentView : NSObject) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLst : icls{0}GetJSONObjLst = icls{0}GetJSONObjLst(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_Controller_Swift4_Desk_top_InvokeGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ������������б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "func invokeGetTopJSONObjLst(vcParentView : NSObject) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetTopJSONObjLst : icls{0}GetTopJSONObjLst = icls{0}GetTopJSONObjLst(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
          
            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ķ�ҳ���������б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "func invokeGetJSONObjLstByPager(vcParentView : NSObject) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLstByPager : icls{0}GetJSONObjLstByPager = icls{0}GetJSONObjLstByPager(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_Desk_top_InvokeIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strBuilder.Append("\r\n" + "func invokeIsExistRecord(vcParentView : NSObject) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}_IsExistRecord : icls{0}_IsExistRecord = icls{0}_IsExistRecord(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_IsExistRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_Desk_top_InvokeGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ������Ӧ�ļ�¼��");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns>���ؼ�¼��</returns>");

            strBuilder.Append("\r\n" + "func invokeGetRecCountByCond(vcParentView : NSObject) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetRecCountByCond : icls{0}GetRecCountByCond = icls{0}GetRecCountByCond(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetRecCountByCond.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_Desk_top_InvokeDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ɾ����¼");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "func invokeDelRecord(vcParentView : NSObject) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}_DelRecord : icls{0}_DelRecord = icls{0}_DelRecord(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_Desk_top_InvokeAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeAddNewRecord(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}_AddNewRecord : icls{0}_AddNewRecord = icls{0}_AddNewRecord(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_Desk_top_InvokeAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeAddNewRecord4GetMaxStrId(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}_AddNewRecord4GetMaxStrId : icls{0}_AddNewRecord4GetMaxStrId = icls{0}_AddNewRecord4GetMaxStrId(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord4GetMaxStrId.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_Desk_top_InvokeGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeGetMaxStrId(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetMaxStrId : icls{0}GetMaxStrId = icls{0}GetMaxStrId(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_Desk_top_InvokeGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeGetMaxStrIdByPrefix(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetMaxStrIdByPrefix : icls{0}GetMaxStrIdByPrefix = icls{0}GetMaxStrIdByPrefix(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrIdByPrefix.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

      

        public string Gen_Controller_Swift4_Desk_top_InvokeUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �޸ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">���øú����ĸ��������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "func invokeUpdateRecord(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}_UpdateRecord : icls{0}_UpdateRecord = icls{0}_UpdateRecord(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_UpdateRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string A_GeneFuncCode_Swift4_Desk_top_Invoke(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {


                    case "Gen_Controller_Swift4_Desk_top_InvokeGetFirstJSONObj":
                    case "Gen_Controller_Swift4_Desk_top_InvokeGetFirstJSONObj_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeGetFirstJSONObj();

                    case "Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjByKey":
                    case "Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjByKey_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjByKey();


                    case "Gen_Controller_Swift4_Desk_top_InvokeDelRecord":
                    case "Gen_Controller_Swift4_Desk_top_InvokeDelRecord_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeDelRecord();


                    case "Gen_Controller_Swift4_Desk_top_InvokeAddNewRecord":
                    case "Gen_Controller_Swift4_Desk_top_InvokeAddNewRecord_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeAddNewRecord();


                    case "Gen_Controller_Swift4_Desk_top_InvokeAddNewRecord4GetMaxStrId":
                    case "Gen_Controller_Swift4_Desk_top_InvokeAddNewRecord4GetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_Swift4_Desk_top_InvokeGetMaxStrId":
                    case "Gen_Controller_Swift4_Desk_top_InvokeGetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeGetMaxStrId();
                    case "Gen_Controller_Swift4_Desk_top_InvokeGetMaxStrIdByPrefix":
                    case "Gen_Controller_Swift4_Desk_top_InvokeGetMaxStrIdByPrefix_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeGetMaxStrIdByPrefix();


                    case "Gen_Controller_Swift4_Desk_top_InvokeUpdateRecord":
                    case "Gen_Controller_Swift4_Desk_top_InvokeUpdateRecord_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeUpdateRecord();

                    case "Gen_Controller_Swift4_Desk_top_InvokeIsExistRecord":
                    case "Gen_Controller_Swift4_Desk_top_InvokeIsExistRecord_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeIsExistRecord();

                    case "Gen_Controller_Swift4_Desk_top_InvokeGetRecCountByCond":          
                        return Gen_Controller_Swift4_Desk_top_InvokeGetRecCountByCond();

                    case "Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjLst":
                    case "Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjLst();
                    case "Gen_Controller_Swift4_Desk_top_InvokeGetTopJSONObjLst":
                    case "Gen_Controller_Swift4_Desk_top_InvokeGetTopJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift4_Desk_top_InvokeGetTopJSONObjLst();

                    case "Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjLstByPager":
                        return Gen_Controller_Swift4_Desk_top_InvokeGetJSONObjLstByPager();

                    default:
                        string strMsg = string.Format("������:{1}��Switchû�д���,����!({0})",
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

    }
}
