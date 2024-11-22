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
     
        public string A_GeneFuncCode_JavaScript_icls(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_JavaScript_iclsGetFirstJSONObj":
                        return Gen_Controller_JavaScript_iclsGetFirstJSONObj();

                    case "Gen_Controller_JavaScript_iclsGetJSONObjByKey":
                        return Gen_Controller_JavaScript_iclsGetJSONObjByKey();

                    case "Gen_Controller_JavaScript_iclsDelRecord":
                        return Gen_Controller_JavaScript_iclsDelRecord();

                    case "Gen_Controller_JavaScript_iclsAddNewRecord":
                        return Gen_Controller_JavaScript_iclsAddNewRecord();

                    case "Gen_Controller_JavaScript_iclsAddNewRecord4GetMaxStrId":
                        return Gen_Controller_JavaScript_iclsAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_JavaScript_iclsGetMaxStrId":
                        return Gen_Controller_JavaScript_iclsGetMaxStrId();
                    case "Gen_Controller_JavaScript_iclsGetMaxStrIdByPrefix":
                        return Gen_Controller_JavaScript_iclsGetMaxStrIdByPrefix();

                    case "Gen_Controller_JavaScript_iclsUpdateRecord":
                        return Gen_Controller_JavaScript_iclsUpdateRecord();

                    case "Gen_Controller_JavaScript_iclsIsExistRecord":
                        return Gen_Controller_JavaScript_iclsIsExistRecord();

                    case "Gen_Controller_JavaScript_iclsGetRecCountByCond":
                        return Gen_Controller_JavaScript_iclsGetRecCountByCond();

                    case "Gen_Controller_JavaScript_iclsGetJSONObjLst":
                        return Gen_Controller_JavaScript_iclsGetJSONObjLst();

                    case "Gen_Controller_JavaScript_iclsGetTopJSONObjLst":
                        return Gen_Controller_JavaScript_iclsGetTopJSONObjLst();

                    case "Gen_Controller_JavaScript_iclsGetJSONObjLstByPager":
                        return Gen_Controller_JavaScript_iclsGetJSONObjLstByPager();

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
        public string Gen_Controller_JavaScript_iclsAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}_AddNewRecord = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.JavaType == "boolean")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName,
                     objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                }
            }
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}4Add(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}4Add(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const strWhereCond = String.format(\"{1} = '{{0}}'\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}4Add(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}4Add(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");

            strBuilder.Append("\r\n" + "if (returnBool === false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);
            
            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//�������������Ƿ�Ϸ�");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}BL = new cls{0}BL();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}BL.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err);");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"�ؼ���Ϊ��{{0}}���ļ�¼�Ѿ�����,���������!\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");



            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");

            strBuilder.Append("\r\n" + "if (returnBool === true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"��Ӽ�¼�ɹ�!\";");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"��Ӽ�¼���ɹ�!\";");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}_AddNewRecord4GetMaxStrId = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnString, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnString, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = returnString;",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                              objPrjTabENEx.TabName,
                              objField.ObjFieldTabENEx.FldName,
                              objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    }
                }
            }
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\n" + "const strWhereCond = String.format(\"{1} = '{{0}}'\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");

            strBuilder.Append("\r\n" + "if (returnBool === false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"�ؼ���Ϊ��{{0}}���ļ�¼�Ѿ�����,���������!\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");


            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "if (returnBool === true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"��Ӽ�¼�ɹ�!\";");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"��Ӽ�¼���ɹ�!\";");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetMaxStrId = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnString, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnString, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnString, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "if (returnString === \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = \"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo =String.format(\"��ȡ��{0}�����ؼ���Ϊ��{{0}}\", returnString);",
                objPrjTabENEx.TabName, "{", "}");


            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetMaxStrIdByPrefix = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
               enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnString, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnString, strClassName);",
                objPrjTabENEx.TabName,
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const strPrefix = \"2\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrIdByPrefix(strPrefix);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrIdByPrefix,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrIdByPrefix,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnString, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "const strInfo = \"\";");

            strBuilder.Append("\r\n" + "if (returnString === \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = \"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"��ȡ��{0}�����ؼ���Ϊ��{{0}}\", returnString);",
                objPrjTabENEx.TabName, "{", "}");
            

            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �޸ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "const icls{0}_UpdateRecord = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.JavaType == "boolean")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName,
                     objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                }
            }
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                  clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));
            
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//�������������Ƿ�Ϸ�");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}BL = new cls{0}BL();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}BL.CheckProperty4Update(obj{0}EN); ", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.UpdateRecord(obj{0}EN);",
                        objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err);");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
       
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��UpdateRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));
            
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��UpdateRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "if (returnBool === true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"�޸ļ�¼�ɹ�!\";");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"�޸ļ�¼���ɹ�!\";");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myShowErrorMsg(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ɾ����¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "const icls{0}_DelRecord = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
   
            strBuilder.Append("\r\n" + "}");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord(\"{1}\");",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord({1});",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��DelRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��DelRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
   
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "if (returnBool === true)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "strInfo = \"ɾ����¼�ɹ�!\";");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strInfo = \"ɾ����¼���ɹ�!\";");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_iclsIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}_IsExistRecord = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnBool, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnBool, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");
            
            strBuilder.AppendFormat("\r\n" + "const strWhereCond = \"{0} ='12'\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnBool, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "switch (strClassName) {");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (returnBool === false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = \"������������{0}='12'�� ������!\";",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strInfo = \"������������{0}='12'�� ����!\";",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller2\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "default: ");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_iclsGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetRecCountByCond = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnInt, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnInt, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const strWhereCond = \"1 = 1\";",
                objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetRecCountByCond(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecCountByCond,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecCountByCond,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnInt, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.Append("\r\n" + "strInfo = String.format(\"������������1=1����ȡ�ļ�¼��Ϊ��{0}!\",returnInt) ;");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetJSONObjLst = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnObjectList, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnObjectList, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "let strWhereCond = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnObjectList, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"����ȡ�����б�����{{0}}\", arr{0}ObjLst.length)",
                objPrjTabENEx.TabName, "{", "}");


            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetTopJSONObjLst = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnObjectList, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnObjectList, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "const intTopSize = 2;");
            strBuilder.Append("\r\n" + "let strWhereCond = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetTopJSONObjLst(intTopSize, strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnObjectList, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"����ȡ�����б�����{{0}}\", arr{0}ObjLst.length);",
                objPrjTabENEx.TabName, "{", "}");


            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetJSONObjLstByPager = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnObjectList, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnObjectList, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n" + "const intPageIndex = 2;");
            strBuilder.Append("\r\n" + "const intPageSize = 2;");
            strBuilder.Append("\r\n" + "const strWhereCond =\" 1=1 \";");
            strBuilder.Append("\r\n" + "const strOrderBy =\"\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
                objPrjTabENEx.TabName);
      
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLstByPager,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLstByPager,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnObjectList, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"����ȡ�����б�����{{0}}\", arr{0}ObjLst.length);",
                objPrjTabENEx.TabName, "{", "}");


            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetObjBy{1} = function()",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnObject, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnObject, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}\";",
                    objKeyField.ObjFieldTabENEx.PrivPropName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = {2};",
                    objKeyField.ObjFieldTabENEx.PrivPropName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjByKey,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjByKey,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnObject, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = returnObject;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"���ݹؼ��֡�01�� ��ȡ����{{0}};\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");

            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_iclsGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}GetFirstObj = function()",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4Controller.init();",
    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName) ",
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName);",
                objPrjTabENEx.TabName,
                  clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(returnObject, strClassName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(returnObject, strClassName);",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "let strWhereCond = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirst{0}(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName)",
                objPrjTabENEx.TabName,
                  clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(returnObject, strClassName)",
                objPrjTabENEx.TabName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = returnObject;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"������������1=1�� ��ȡ��һ����¼����{{0}}\", obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName, "{", "}");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");


            strBuilder.Append("\r\n" + "};");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_Controller_JavaScript_iclsByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "const icls{0}_{1} = function()",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.ClsName);

            strBuilder.Append("\r\n" + "this.init = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "const obj{0}WS4SDController = new cls{0}WS4SDController();",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + " obj{0}WS4SDController.init();",
    objWebSrvClassENEx.ClsName);


            strBuilder.Append("\r\n" + "objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(objResponseData, strClassName, strFunctionName) ",
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(objResponseData, strClassName, strFunctionName);",
                objWebSrvClassENEx.ClsName,
                  clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate.{0} = function(strResult, strClassName, strFunctionName) ",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}_{1}(strResult, strClassName, strFunctionName);",
                objWebSrvClassENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

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
                    strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "const {1} = \"{2}\";",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "const {1} = {2};",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());

            strBuilder.Append("\r\n" + "}");

            //strBuilder.Append("\r\n" + "let strWhereCond = \" 1=1 \";");
            //strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirst{0}(strWhereCond);",
            //    objWebSrvClassENEx.ClsName);
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(objResponseData, strClassName, strFunctionName)",
                objWebSrvClassENEx.ClsName,
                  clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "function {0}_{1}(strResult, strClassName, strFunctionName)",
                objWebSrvClassENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"\";");
            //strBuilder.AppendFormat("\r\n" + "obj{0}EN = returnObject;",
            //    objWebSrvClassENEx.ClsName);

            strBuilder.AppendFormat("\r\n" + "strInfo = String.format(\"������������1=1�� ��ȡ�����{{0}}\", strResult);",
                objWebSrvClassENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "myAlert(strInfo);");
            
            strBuilder.Append("\r\n" + "};");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

    }
}
