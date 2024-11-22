using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
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
    partial class WA_Access4TypeScript : clsGeneCodeBase
    {

        public string A_GeneFuncCodeAsync_TypeScript(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;

            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Srv4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }
                return strCode;
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
        /// ����WebApi����Ӽ�¼,���ݴ���ʹ��JSON��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_AddNewRecordAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "AddNewRecordAsync({1}: {0}): Promise<boolean> ",
              ThisClsName4EN, ThisObjName4EN);
            Re_objFunction4Code.FuncCHName4Code = "����WebApi����Ӽ�¼,���ݴ���ʹ��JSON��";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����WebApi����Ӽ�¼,���ݴ���ʹ��JSON��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵĶ���", ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n **/");
            
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "AddNewRecordAsync({1}: {0}): Promise<boolean> ",
              ThisClsName4EN, ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"AddNewRecordAsync\";", ThisTabName4GC,
      objKeyField.FldName);


            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"AddNewRecord\";",
              ThisTabName4GC,
              objKeyField.FldName);

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
             && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
             && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
             && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
              && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long")
            {

                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.{1} === null || {0}.{1} === 0)",
                      ThisObjName4EN,
                   objKeyField.PropertyName(this.IsFstLcase));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.{1} === null || {0}.{1} === \"\")",
                     ThisObjName4EN,
                  objKeyField.PropertyName(this.IsFstLcase));
                }

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"��Ҫ�Ķ���Ĺؼ���Ϊ��,�������!\";");
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");
            }
            
            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify({0});",
                    ThisObjName4EN);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, {0}, config);", ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����WebApi����Ӽ�¼,���ݴ���ʹ��JSON��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_AddNewRecordWithMaxIdAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "AddNewRecordWithMaxIdAsync({1}: {0}): Promise<boolean> ",
              ThisClsName4EN, ThisObjName4EN);
            Re_objFunction4Code.FuncCHName4Code = "����WebApi����Ӽ�¼,�ؼ��������ؼ���,���ݴ���ʹ��JSON��";


            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType != "string") return "/* �������Ͳ����ַ���,���������ؼ��ֵķ�ʽ��Ӽ�¼��*/";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����WebApi����Ӽ�¼,�ؼ��������ؼ���,���ݴ���ʹ��JSON��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵĶ���", ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "AddNewRecordWithMaxIdAsync({1}: {0}): Promise<{2}> ",
              ThisClsName4EN, ThisObjName4EN,
              objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"AddNewRecordWithMaxIdAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"AddNewRecordWithMaxId\";",
              ThisTabName4GC,
              objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, {0}, config);", ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnStr;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GoTopAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "�������Ĺؼ����б���صļ�¼�ƶ�";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �������Ĺؼ����б���صļ�¼�ƶ�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵĶ���", ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsOrderByData.js", "clsOrderByData", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GoTopAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GoTop\";",
              ThisTabName4GC,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
              ThisTabName4GC,
           objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"���ݹؼ����б��ö�ʱ,�����Ĺؼ���ֵ�б���Ϊ��!\";");
            strCodeForCs.Append("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, objOrderByData, config);", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GoBottomAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "�������Ĺؼ����б���صļ�¼�Ƶ�";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �������Ĺؼ����б���صļ�¼�Ƶ�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵĶ���", ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsOrderByData.js", "clsOrderByData", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GoBottomAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GoBottom\";",
              ThisTabName4GC,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
              ThisTabName4GC,
           objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"���ݹؼ����б��õ�ʱ,�����Ĺؼ���ֵ�б���Ϊ��!\";");
            strCodeForCs.Append("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify({0});",
                    ThisObjName4EN);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, objOrderByData, config);", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_ReOrderAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "���б��¼����";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���б��¼����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵĶ���", ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsOrderByData.js", "clsOrderByData", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"ReOrderAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"ReOrder\";",
              ThisTabName4GC,
              objKeyField.FldName);

            // strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
            //   ThisTabName4GC,
            //objKeyField.FldName);

            // strCodeForCs.Append("\r\n" + "{");
            // strCodeForCs.Append("\r\n" + "strMsg = \"���ݹؼ����б��ö�ʱ,�����Ĺؼ���ֵ�б���Ϊ��!\";");
            // strCodeForCs.Append("\r\n" + "throw strMsg;");
            // strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify({0});",
                    ThisObjName4EN);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, objOrderByData, config);", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Ts_UpMoveAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "�������Ĺؼ����б���صļ�¼����";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �������Ĺؼ����б���صļ�¼����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵĶ���", ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsOrderByData.js", "clsOrderByData", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"UpMoveAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"UpMove\";",
              ThisTabName4GC,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
              ThisTabName4GC,
           objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"���ݹؼ����б�����ʱ,�����Ĺؼ���ֵ�б���Ϊ��!\";");
            strCodeForCs.Append("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify({0});",
                    ThisObjName4EN);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, objOrderByData, config);", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_DownMoveAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);

            Re_objFunction4Code.FuncCHName4Code = "����WebApi,�������Ĺؼ����б���صļ�¼����";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �������Ĺؼ����б���صļ�¼����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵĶ���", ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> ",
              ThisTabName4GC,
              objKeyField.FldName);
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsOrderByData.js", "clsOrderByData", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"DownMoveAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"DownMove\";",
              ThisTabName4GC,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
              ThisTabName4GC,
           objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"���ݹؼ����б�����ʱ,�����Ĺؼ���ֵ�б���Ϊ��!\";");
            strCodeForCs.Append("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify({0});",
                    ThisObjName4EN);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, objOrderByData, config);", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return (data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����WebApi���޸ļ�¼,���ݴ���ʹ��JSON��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_UpdateRecordAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "UpdateRecordAsync({1}: {0}): Promise<boolean>  ",
              ThisClsName4EN, ThisObjName4EN);
            Re_objFunction4Code.FuncCHName4Code = "����WebApi���޸ļ�¼,���ݴ���ʹ��JSON��";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����WebApi���޸ļ�¼,���ݴ���ʹ��JSON��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵĶ���", ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��ȡ�޸��Ƿ�ɹ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "UpdateRecordAsync({1}: {0}): Promise<boolean>  ",
              ThisClsName4EN, ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"UpdateRecordAsync\";", ThisTabName4GC,
      objKeyField.FldName);


            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"UpdateRecord\";",
              ThisTabName4GC,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + " if ({0}.sfUpdFldSetStr === undefined || {0}.sfUpdFldSetStr === null || {0}.sfUpdFldSetStr === \"\")",
                ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����(�ؼ���: {{0}})�ġ��޸��ֶμ���Ϊ��,�����޸�!\", {0}.{1});",
                ThisObjName4EN, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + " throw strMsg;");
            strCodeForCs.Append("\r\n" + " }");
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  ThisTabName4GC);

            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, {0}, config);", ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_EditRecordExAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "EditRecordExAsync({1}: {0}): Promise<boolean>  ",
              ThisClsName4EN, ThisObjName4EN);
            Re_objFunction4Code.FuncCHName4Code = "����WebApi���༭��¼�����ھ��޸ģ������ھ���ӣ�,���ݴ���ʹ��JSON��";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����WebApi���༭��¼�����ھ��޸ģ������ھ���ӣ�,���ݴ���ʹ��JSON��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵĶ���", ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��ȡ�޸��Ƿ�ɹ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "EditRecordExAsync({1}: {0}): Promise<boolean>  ",
              ThisClsName4EN, ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"EditRecordExAsync\";", ThisTabName4GC,
      objKeyField.FldName);


            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"EditRecordEx\";",
              ThisTabName4GC,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + " if ({0}.sfUpdFldSetStr === undefined || {0}.sfUpdFldSetStr === null || {0}.sfUpdFldSetStr === \"\")",
                ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����(�ؼ���: {{0}})�ġ��޸��ֶμ���Ϊ��,�����޸�!\", {0}.{1});",
                ThisObjName4EN, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + " throw strMsg;");
            strCodeForCs.Append("\r\n" + " }");
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  ThisTabName4GC);

            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, {0}, config);", ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ����WebApi��ɾ����¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_DelRecordAsync()
        {
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "DelRecKeyLstAsync({0}): Promise<number>  ",
                             objPrjTabENEx.KeyVarDefineLstStr_TS);
            }
            else
            {
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "DelRecordAsync({0}: {1}): Promise<number>  ",
                                objKeyField.PrivFuncName, KeyDataType);
            }
            Re_objFunction4Code.FuncCHName4Code = "����WebApi��ɾ����¼,���ݹؼ�����ɾ����¼";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����WebApi��ɾ����¼,���ݹؼ�����ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n * @param {0}:�ؼ����б�", objPrjTabENEx.KeyPrivFuncFldNameLstStr_TS);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n * @param {0}:�ؼ���", objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n * @returns ��ȡɾ���Ľ��");
            strCodeForCs.Append("\r\n **/");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "DelRecKeyLstAsync({0}): Promise<number>  ",
                         objPrjTabENEx.KeyVarDefineLstStr_TS);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"DelRecKeyLstAsync\";", ThisTabName4GC,
          objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "const strAction = \"DelRecKeyLst\";");
                strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "DelRecordAsync({0}: {1}): Promise<number>  ",
                            objKeyField.PrivFuncName, KeyDataType);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"DelRecordAsync\";", ThisTabName4GC,
          objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "const strAction = \"DelRecord\";");
                strCodeForCs.Append("\r\n" + $"let strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
                strCodeForCs.AppendFormat("\r\n" + "strUrl = Format(\"{{0}}?Id={{1}}\", strUrl, {0});", objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + "const config = {");
                strCodeForCs.Append("\r\n" + "headers: {");
                strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
                strCodeForCs.Append("\r\n" + "},");
                strCodeForCs.Append("\r\n" + "params: {");
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1}, ", objInFor.FldName, objInFor.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "},");
                strCodeForCs.Append("\r\n" + "};");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "const configDel = {");
                strCodeForCs.Append("\r\n" + "headers: {");
                strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
                strCodeForCs.Append("\r\n" + "},");
                strCodeForCs.Append("\r\n" + "};");
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "const response = await axios.delete(strUrl, configDel);");
            }
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_IsExistRecordAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "IsExistRecordAsync(strWhereCond: string): Promise<boolean>  ",
              ThisTabName4GC,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "����������ȡ�Ƿ������Ӧ�ļ�¼";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����������ȡ�Ƿ������Ӧ�ļ�¼��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @returns �Ƿ���ڼ�¼��");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "IsExistRecordAsync(strWhereCond: string): Promise<boolean>  ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"IsExistRecordAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"IsExistRecord\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "strWhereCond,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetRecCountByCondAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format($"export  async function {thisWA_F(WA_F.GetRecCountByCondAsync)}(strWhereCond: string): Promise<number>  ");
            Re_objFunction4Code.FuncCHName4Code = "��ȡĳһ�����ļ�¼��";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ȡĳһ�����ļ�¼��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @returns ��ȡĳһ�����ļ�¼��");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetRecCountByCondAsync)}(strWhereCond: string): Promise<number>  ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetRecCountByCondAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetRecCountByCond\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "strWhereCond,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjLstAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format($"export  async function {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond: string): Promise<Array<{ThisClsName4EN}>>  ");
            Re_objFunction4Code.FuncCHName4Code = "����������ȡ��Ӧ�ļ�¼�����б�.";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param strWhereCond:����");

            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ�����б�");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond: string): Promise<Array<{ThisClsName4EN}>>  ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLst\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "strWhereCond,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
         
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
            strCodeForCs.Append("\r\n" + "if (returnObjLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.Append("\r\n" + $"const arrObjLst = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(returnObjLst);");
            strCodeForCs.Append("\r\n" + "return (arrObjLst);");
      
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName+ ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName+ ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjLst_WACacheAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLst_WACacheAsync(): Promise<Array<{0}> | null>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "��ȡ�����������еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ȡ�����������еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param strWhereCond:����");

            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ�����б�");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLst_WACacheAsync(): Promise<Array<{0}>>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLst_WACacheAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLst_Cache\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");

            strCodeForCs.Append("\r\n" + "const mapParam: Dictionary = new Dictionary();");
            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"����: strIdentityID =01\";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "params: { strWhereCond}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
            strCodeForCs.Append("\r\n" + "if (returnObjLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.Append("\r\n" + $"const arrObjLst = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(returnObjLst);");
            strCodeForCs.Append("\r\n" + "return (arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_SetCache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ���ݹؼ��ֻ�ȡ��ض���, �ӻ����л�ȡ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�����Ĺؼ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns ����");
            strCodeForCs.AppendFormat("\r\n **/");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "SetCache() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"SetCache\";", ThisTabName4GC,
      objKeyField.FldName);
                       

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjLstCacheAsyncBak()
        {
            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstCache]����;");

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @returns �ӱ��ػ����л�ȡ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLst_Cache() ",
                ThisTabName4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "//const strThisFuncName = \"GetObjLst_Cache\";", ThisTabName4GC,
          objKeyField.FldName);

            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLst_Cache({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "//const strThisFuncName = \"GetObjLst_Cache\";", ThisTabName4GC,
          objKeyField.FldName);

                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������:[{0}]����Ϊ��!\", {0}.con_{1});", ThisTabName4GC, thisCacheClassify_TS.FldName);
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLst_Cache({0}: {1}, {2}: {3})",
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName2,
                      thisCacheClassify_TS.TypeScriptType2
                      );
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "//const strThisFuncName = \"GetObjLst_Cache\";", ThisTabName4GC,
          objKeyField.FldName);


                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������:[{0}]����Ϊ��!\", {0}.con_{1});", ThisTabName4GC, thisCacheClassify_TS.FldName);
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������:[{0}]����Ϊ��!\", {0}.con_{1});", ThisTabName4GC, thisCacheClassify_TS.FldName2);
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");


            }

            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            strCodeForCs.Append("\r\n" + "let strWhereCond = \"1=1\";");
            //strCodeForCs.AppendFormat("\r\n" + "{0}_InitListCache(); ", ThisTabName4GC);

            //strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
            //  ThisTabName4GC);
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = {thisWA_F(WA_F._CurrTabName)};");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{0}='{{0}}'\", {1});", thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName);
                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{0}='{{0}}' and {2}='{{1}}'\", {1}, {3});",
                    thisCacheClassify_TS.FldName,
                    thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.FldName2,
                    thisCacheClassify_TS.PriVarName2);
                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
            }
            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + " if (CacheHelper.Exsits(strKey))");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLstCache: Array<{0}> = CacheHelper.Get(strKey);", ThisClsName4EN);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLst = await {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond);");

            //strCodeForCs.AppendFormat("\r\n" + "{0}_arr{0}ObjLstCache = arr{0}ObjLst;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Add(strKey, arr{0}ObjLst);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"Key:[{{0}}]�Ļ����Ѿ�����,�����б�����{{1}}!\", strKey, arr{0}ObjLst.length);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.log(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ӻ����л�ȡ���ж����б����,${e}.\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw (strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GetObjLstCacheAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format($"export  async function {thisWA_F(WA_F.GetObjLst_Cache)}() ");
            string strFuncName = string.Format($"{thisWA_F(WA_F.GetObjLst_Cache)}");
            Re_objFunction4Code.FuncCHName4Code = "��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼..";

            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLst_Cache]����;");

            //��ʼ������

            var objFuncParaLst = new FuncParaLst("GetObjLstCacheAsync", this.IsFstLcase, enumAppLevel.DefindFunc);
            List<string > arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);

            string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl); 
            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @returns �ӱ��ػ����л�ȡ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n **/");
           
                strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjLst_Cache)}({strFuncParaLst}): Promise<Array<{ThisClsName4EN}>> ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "//const strThisFuncName = \"GetObjLst_Cache\";");
                 
            
            strCodeForCs.Append("\r\n" + strCheckEmptyCode);
                       

            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLstCache;", ThisTabName4GC);
            
            strCodeForCs.AppendFormat("\r\n" + "switch ({0}.CacheModeId)", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstsessionStorage)}();");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstlocalStorage)}();");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstClientCache)}();");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstClientCache)}();");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstsessionStorage)}({thisCacheClassify_TS.PriVarName});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstlocalStorage)}({thisCacheClassify_TS.PriVarName});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstClientCache)}({thisCacheClassify_TS.PriVarName});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstClientCache)}({thisCacheClassify_TS.PriVarName});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstsessionStorage)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstlocalStorage)}({thisCacheClassify_TS.PriVarName},{thisCacheClassify_TS.PriVarName2});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstClientCache)}({thisCacheClassify_TS.PriVarName},{thisCacheClassify_TS.PriVarName2});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstClientCache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
            }
            
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_GetObjLst_PureCacheAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstPureCache() ",
                ThisTabName4GC);
            Re_objFunction4Code.FuncCHName4Code = "��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼..������ز����ھͷ���null,����ȥ����WebApi��ȡ���ݡ�";

            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstPureCache]����;");

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @returns �ӱ��ػ����л�ȡ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstPureCache() ",
                ThisTabName4GC);
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstPureCache({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstPureCache({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstPureCache({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstPureCache({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "//const strThisFuncName = \"GetObjLstPureCache\";", ThisTabName4GC,
      objKeyField.FldName);
            
            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "switch ({0}.CacheModeId)", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstsessionStoragePureCache)}();");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstlocalStoragePureCache)}();");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLstCache = null;", objPrjTabENEx.ClsName, ThisTabName4GC);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLstCache = null;", objPrjTabENEx.ClsName, ThisTabName4GC);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstsessionStoragePureCache)}({thisCacheClassify_TS.PriVarName});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstlocalStoragePureCache)}({thisCacheClassify_TS.PriVarName});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLstCache = null;",
                    objPrjTabENEx.ClsName, ThisTabName4GC,
                      thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLstCache = null;",
                    objPrjTabENEx.ClsName, ThisTabName4GC,
                      thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstsessionStoragePureCache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLstlocalStoragePureCache)}({thisCacheClassify_TS.PriVarName},{thisCacheClassify_TS.PriVarName2});");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLstCache = null;",
                    objPrjTabENEx.ClsName, ThisTabName4GC,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLstCache = null;",
                    objPrjTabENEx.ClsName, ThisTabName4GC,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_GetObjLst_ClientCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstClientCache() ",
                ThisTabName4GC);

            Re_objFunction4Code.FuncCHName4Code = "��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.";
                        
            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstClientCache]����;");

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @returns �ӱ��ػ����л�ȡ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstClientCache() ",
                ThisTabName4GC);
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstClientCache({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstClientCache({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstClientCache({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                                            thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstClientCache({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                                            thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strThisFuncName = \"GetObjLstClientCache\";");
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            var strLetOrConst = "let";
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
            {
                strLetOrConst = "let";
            }
            strCodeForCs.AppendFormat("\r\n" + "{0} strWhereCond = \"1=1\";", strLetOrConst);

            //strCodeForCs.AppendFormat("\r\n" + "{0}_InitListCache(); ", ThisTabName4GC);

            //strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
            //  ThisTabName4GC);
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = {thisWA_F(WA_F._CurrTabName)};");
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = {0}.WhereFormat;",
                    ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format({0}.WhereFormat, {1});",
                    ThisClsName4EN, thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{0}='{{0}}'\", {1});", thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "}");

                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, { thisCacheClassify_TS.PriVarName});");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format({0}.WhereFormat, {1}, {2});",
                    ThisClsName4EN, thisCacheClassify_TS.PriVarName
, thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{0}='{{0}}' and {2}='{{1}}'\", {1}, {3});",
                    thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.FldName2, thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");

                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {3}._CurrTabName, {1}, {2});",
                           ThisClsName4EN, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.PriVarName2, ThisClsName4EN);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {3}._CurrTabName, {1}, {2});",
                         ThisClsName4EN, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.PriVarName2, ThisClsName4EN);
                }
            }
            
            strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.CacheAddiCondition) == false)", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}\", {0}.CacheAddiCondition);", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + " if (CacheHelper.Exsits(strKey))");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ExObjLstCache: Array<{1}> = CacheHelper.Get(strKey);", ThisTabName4GC, ThisClsName4EN);
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstT = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(arr{ThisTabName4GC}ExObjLstCache);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstT;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ExObjLst = await {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond);");
            //strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst == null) return null;", ThisTabName4GC);

            //strCodeForCs.AppendFormat("\r\n" + "{0}_arr{0}ObjLstCache = arr{0}ObjLst;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Add(strKey, arr{0}ExObjLst);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"[ClientCache]Key:[{{0}}]�Ļ����Ѿ�����,�����б�����{{1}}!\", strKey, arr{0}ExObjLst.length);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.log(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ExObjLst;", ThisTabName4GC);
            
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ӱ��ػ����л�ȡ���ж����б����. \\n����������{0}.(in {1}.{2})\", e, " + this.constructorName+ ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw (strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/CacheHelper.js", "CacheHelper", enumImportObjType.CustomFunc, this.strBaseUrl);

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Ts_GetObjLst_localStorage_PureCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstlocalStoragePureCache() ",
                ThisTabName4GC);

            Re_objFunction4Code.FuncCHName4Code = "��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.������ز����ھͷ���null,����ȥ����WebApi��ȡ���ݡ�";

            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstlocalStoragePureCache]����;");

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.������ز����ھͷ���null,����ȥ����WebApi��ȡ���ݡ�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @returns �ӱ��ػ����л�ȡ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstlocalStoragePureCache() ",
                ThisTabName4GC);
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstlocalStoragePureCache({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                                            thisCacheClassify_TS.PriVarName);

                 Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstlocalStoragePureCache({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                                            thisCacheClassify_TS.PriVarName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstlocalStoragePureCache({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                                            thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstlocalStoragePureCache({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
            }
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strThisFuncName = \"GetObjLstlocalStoragePureCache\";");
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            //var strLetOrConst = "const";
            //if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
            //{
            //    strLetOrConst = "let";
            //}
            
            //strCodeForCs.AppendFormat("\r\n" + "{0}_InitListCache(); ", ThisTabName4GC);

            //strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
            //  ThisTabName4GC);
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = {thisWA_F(WA_F._CurrTabName)};");

            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {

                //strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = Format(\"{0}='{{0}}'\", {1});", thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName);
                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
            }
            else
            {

                //strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = Format(\"{0}='{{0}}' and {2}='{{1}}'\", {1}, {3});",
                //    thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName,
                //    thisCacheClassify_TS.FldName2, thisCacheClassify_TS.PriVarName2);
                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {3}._CurrTabName, {1}, {2});",
                           ThisTabName4GC, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.PriVarName2, ThisClsName4EN);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {3}._CurrTabName, {1}, {2});",
                         ThisTabName4GC, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.PriVarName2, ThisClsName4EN);
                }
            }
            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(localStorage, strKey))");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");

            strCodeForCs.AppendFormat("\r\n" + "const strTempObjLst:string = localStorage.getItem(strKey) as string;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLstCache: Array<{1}> = JSON.parse(strTempObjLst);", ThisTabName4GC, ThisClsName4EN);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_GetObjLst_localStorage()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstlocalStorage() ",
                ThisTabName4GC);

            Re_objFunction4Code.FuncCHName4Code = "��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstlocalStorage]����;");

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @returns �ӱ��ػ����л�ȡ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstlocalStorage() ",
                ThisTabName4GC);
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstlocalStorage({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstlocalStorage({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstlocalStorage({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstlocalStorage({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strThisFuncName = \"GetObjLstlocalStorage\";");
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            var strLetOrConst = "let";
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
            {
                strLetOrConst = "let";
            }
            strCodeForCs.AppendFormat("\r\n" + "{0} strWhereCond = \"1=1\";", strLetOrConst);

            //strCodeForCs.AppendFormat("\r\n" + "{0}_InitListCache(); ", ThisTabName4GC);

            //strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
            //  ThisTabName4GC);
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = {thisWA_F(WA_F._CurrTabName)};");
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = {0}.WhereFormat;",
                    ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format({0}.WhereFormat, {1});",
                    ThisClsName4EN, thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                if (thisCacheClassify_TS.IsForExtendClass == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{{0}}='{{1}}'\",{0}.con_{1}, {2});", ThisClsName4EN, thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName);
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strMsg =\"�����ֶ�Ϊ��չ�ֶ�,��ʱWhereFormat����Ϊ��!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
                }
                strCodeForCs.Append("\r\n" + "}");

                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format({0}.WhereFormat, {1}, {2});",
                    ThisClsName4EN, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{0}='{{0}}' and {2}='{{1}}'\", {1}, {3});",
                    thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.FldName2, thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");

                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
            }
            
            strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.CacheAddiCondition) == false)", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}\", {0}.CacheAddiCondition);", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(localStorage, strKey))");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");

            strCodeForCs.AppendFormat("\r\n" + "const strTempObjLst:string = localStorage.getItem(strKey) as string;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ExObjLstCache: Array<{1}> = JSON.parse(strTempObjLst);", ThisTabName4GC, ThisClsName4EN);

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstT = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(arr{ThisTabName4GC}ExObjLstCache);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstT;", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ExObjLst = await {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond);");
            //strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst == null) return null;", ThisTabName4GC);
            if (objPrjTabENEx.IsMultiKeyClassify == false)
            {
                if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strPrefix = Format(\"{{0}}_\", {thisWA_F(WA_F._CurrTabName)});");
                    strCodeForCs.Append("\r\n" + "const arrCacheKeyLst = LocalStorage_GetKeyByPrefix(strPrefix);");
                    AddImportClass(objPrjTabENEx.TabId, "/PubFun/CacheHelper.js", "LocalStorage_GetKeyByPrefix", enumImportObjType.CustomFunc, this.strBaseUrl);

                    strCodeForCs.Append("\r\n" + "arrCacheKeyLst.forEach(x => localStorage.removeItem(x));");
                }
            }

            strCodeForCs.AppendFormat("\r\n" + "localStorage.setItem(strKey, JSON.stringify(arr{0}ExObjLst));", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"[localStorage]Key:[{{0}}]�Ļ����Ѿ�����,�����б�����{{1}}!\", strKey, arr{0}ExObjLst.length);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.log(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ExObjLst;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ӱ��ػ����л�ȡ���ж����б����. \\n����������{0}.(in {1}.{2})\", e, " + this.constructorName+ ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw (strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/CacheHelper.js", "CacheHelper", enumImportObjType.CustomFunc, this.strBaseUrl);

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstsessionStoragePureCache() ");

            Re_objFunction4Code.FuncCHName4Code = "��ȡ����sessionStorage�����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.������ز����ھͷ���null,����ȥ����WebApi��ȡ���ݡ�";

            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstsessionStoragePureCache]����;");

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ��ȡ���ػ����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @returns �ӱ��ػ����л�ȡ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstsessionStoragePureCache() ");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstsessionStoragePureCache({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstsessionStoragePureCache({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstsessionStoragePureCache({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstsessionStoragePureCache({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);

            }
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strThisFuncName = \"GetObjLstsessionStoragePureCache\";");
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            //var strLetOrConst = "const";
            //if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
            //{
            //    strLetOrConst = "let";
            //}

            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = {thisWA_F(WA_F._CurrTabName)};");

            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                //strCodeForCs.AppendFormat("\r\n" + "{0} strWhereCond = \"1=1\";", strLetOrConst);

                //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{0}='{{0}}'\", {1});", thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName);
                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "{0} strWhereCond = \"1=1\";", strLetOrConst);

                //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{0}='{{0}}' and {2}='{{1}}'\", {1}, {3});",
                //    thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName,
                //    thisCacheClassify_TS.FldName2, thisCacheClassify_TS.PriVarName2);
                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
            }
            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");

            strCodeForCs.AppendFormat("\r\n" + "const strTempObjLst:string = sessionStorage.getItem(strKey) as string;");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLstCache: Array<{1}> = JSON.parse(strTempObjLst);", ThisTabName4GC, ThisClsName4EN);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_GetObjLst_sessionStorage()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstsessionStorage() ");

            Re_objFunction4Code.FuncCHName4Code = "��ȡ����sessionStorage�����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstsessionStorage]����;");

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ��ȡ����sessionStorage�����еĶ����б�,���������е�ȫ����¼,Ҳ���Ǳ���ĳ��������ȫ����¼.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @returns �ӱ��ػ����л�ȡ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstsessionStorage() ");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstsessionStorage({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstsessionStorage({1}: {0})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstsessionStorage({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstsessionStorage({1}: {0}, {3}:{2})",
                      thisCacheClassify_TS.TypeScriptType,
                      thisCacheClassify_TS.PriVarName,
                      thisCacheClassify_TS.TypeScriptType2,
                      thisCacheClassify_TS.PriVarName2);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strThisFuncName = \"GetObjLstsessionStorage\";");
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            var strLetOrConst = "let";
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
            {
                strLetOrConst = "let";
            }
            strCodeForCs.AppendFormat("\r\n" + "{0} strWhereCond = \"1=1\";", strLetOrConst);

            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = {thisWA_F(WA_F._CurrTabName)};");
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = {0}.WhereFormat;",
                    ThisClsName4EN );
                strCodeForCs.Append("\r\n" + "}");

            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format({0}.WhereFormat, {1});",
                    ThisClsName4EN, thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                if (thisCacheClassify_TS.IsForExtendClass == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{{0}}='{{1}}'\",{0}.con_{1}, {2});", ThisClsName4EN, thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName);
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strMsg =\"�����ֶ�Ϊ��չ�ֶ�,��ʱWhereFormat����Ϊ��!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
                }
                strCodeForCs.Append("\r\n" + "}");
                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format({0}.WhereFormat, {1}, {2});",
                    ThisClsName4EN, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Format(\"{0}='{{0}}' and {2}='{{1}}'\", {1}, {3});",
                    thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.FldName2, thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");

                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
            }
            
            strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}.CacheAddiCondition) == false)", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}\", {0}.CacheAddiCondition);", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");

            strCodeForCs.AppendFormat("\r\n" + "const strTempObjLst:string = sessionStorage.getItem(strKey) as string;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ExObjLstCache: Array<{1}> = JSON.parse(strTempObjLst);", ThisTabName4GC, ThisClsName4EN);

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstT = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(arr{ThisTabName4GC}ExObjLstCache);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstT;", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ExObjLst = await {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond);");
            
            if (objPrjTabENEx.IsMultiKeyClassify == false)
            {
                if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
                {
                    strCodeForCs.Append("\r\n" + $"const strPrefix = Format(\"{{0}}_\", {thisWA_F(WA_F._CurrTabName)});");
                    strCodeForCs.Append("\r\n" + "const arrCacheKeyLst = SessionStorage_GetKeyByPrefix(strPrefix);");
                    AddImportClass(objPrjTabENEx.TabId, "/PubFun/CacheHelper.js", "SessionStorage_GetKeyByPrefix", enumImportObjType.CustomFunc, this.strBaseUrl);

                    strCodeForCs.Append("\r\n" + "arrCacheKeyLst.forEach(x => sessionStorage.removeItem(x));");
                }
            }
            
            strCodeForCs.AppendFormat("\r\n" + "sessionStorage.setItem(strKey, JSON.stringify(arr{0}ExObjLst));", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"[sessionStorage]Key:[{{0}}]�Ļ����Ѿ�����,�����б�����{{1}}!\", strKey, arr{0}ExObjLst.length);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.log(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ExObjLst;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ӻ����л�ȡ���ж����б����. \\n����������{0}.(in {1}.{2})\", e, " + this.constructorName+ ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw (strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/CacheHelper.js", "CacheHelper", enumImportObjType.CustomFunc, this.strBaseUrl);

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }



        public string Gen_4WA_Ts_GetObjLstByKeyLstAsync()
        {
            if (objPrjTabENEx.arrKeyFldSet.Count > 1) return "";
            Re_objFunction4Code.FuncName4Code = string.Format($"export  async function {thisWA_F(WA_F.GetObjLstByKeyLstAsync)}(arr{1}: Array<string>): Promise<Array<{0}> >  ",
              ThisClsName4EN,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ����б��ȡ��ض����б�";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݹؼ����б��ȡ��ض����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param arr{0}:�ؼ����б�", objKeyField.FldName);
            strCodeForCs.Append("\r\n * @returns �����б�");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjLstByKeyLstAsync)}(arr{objKeyField.FldName}: Array<string>): Promise<Array<{ThisClsName4EN}>>  ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstBy{1}LstAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLstBy{1}Lst\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");

            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, arr{0}, config);", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
            strCodeForCs.Append("\r\n" + "if (returnObjLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.Append("\r\n" + $"const arrObjLst = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(returnObjLst);");
            strCodeForCs.Append("\r\n" + "return arrObjLst;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GetObjLstByKeyLst_WACacheAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstBy{1}Lst_WACacheAsync(arr{1}: Array<string>): Promise<Array<{0}> | null>  ",
              ThisTabName4GC,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ����б��ȡ��ض����б�, ��WebApi�����л�ȡ.";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݹؼ����б��ȡ��ض����б�, ��WebApi�����л�ȡ");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param arr{0}:�ؼ����б�", objKeyField.FldName);
            strCodeForCs.Append("\r\n * @returns �����б�");
            strCodeForCs.Append("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstBy{1}Lst_WACacheAsync(arr{1}: Array<string>): Promise<Array<{0}>>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstBy{1}Lst_WACacheAsync(arr{1}: Array<string>, {2}: {3}): Promise<Array<{0}>>  ",
          ThisClsName4EN,
          objKeyField.FldName,
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstBy{1}Lst_WACacheAsync(arr{1}: Array<string>, {2}: {3}): Promise<Array<{0}>>  ",
          ThisClsName4EN,
          objKeyField.FldName,
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstBy{1}Lst_WACacheAsync(arr{1}: Array<string>, {2}: {3}, {4}: {5}): Promise<Array<{0}>>  ",
          ThisClsName4EN,
          objKeyField.FldName,
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
                thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstBy{1}Lst_WACacheAsync(arr{1}: Array<string>, {2}: {3}, {4}: {5}): Promise<Array<{0}>>  ",
          ThisClsName4EN,
          objKeyField.FldName,
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
                thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstBy{1}Lst_WACacheAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLstBy{1}LstCache\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, arr{0}, config);", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
            strCodeForCs.Append("\r\n" + "if (returnObjLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.Append("\r\n" + $"const arrObjLst = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(returnObjLst);");
            strCodeForCs.Append("\r\n" + "return (arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetTopObjLstAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<{0}>>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "���ݶ���������ȡ��Ӧ�ļ�¼�����б�";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݶ���������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param objTopPara:��ȡ���������б�Ĳ�������");
            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ�����б�");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<{0}>>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetTopObjLstAsync\";", ThisTabName4GC,
  objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetTopObjLst\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, objTopPara, config);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
            strCodeForCs.Append("\r\n" + "if (returnObjLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.Append("\r\n" + $"const arrObjLst = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(returnObjLst);");
            strCodeForCs.Append("\r\n" + "return (arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjLstByPagerAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<{0}> | null>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "���ݷ�ҳ������ȡ��Ӧ�ļ�¼�����б�,ֻ��ȡһҳ";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݷ�ҳ������ȡ��Ӧ�ļ�¼�����б�,ֻ��ȡһҳ");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param objPagerPara:��ҳ��ȡ�����б�Ĳ�������");
            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ��¼�����б�");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<{0}>>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByPagerAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (objPagerPara.pageIndex == 0) return new Array<{0}>();", ThisClsName4EN);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLstByPager\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");       
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, objPagerPara, config);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
            strCodeForCs.Append("\r\n" + "if (returnObjLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.Append("\r\n" + $"const arrObjLst = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(returnObjLst);");
            strCodeForCs.Append("\r\n" + "return arrObjLst;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GetObjLstByPager_WACacheAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstByPager_WACacheAsync(objPagerPara: stuPagerPara): Promise<Array<{0}> | null>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "����������ȡ��Ӧ�ļ�¼�����б�";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param objPagerPara:��ҳ��ȡ�����б�Ĳ�������");
            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ��¼�����б�");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstByPager_WACacheAsync(objPagerPara: stuPagerPara): Promise<Array<{0}>>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByPager_WACacheAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLstByPagerCache\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");

            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, objPagerPara, config);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
            strCodeForCs.Append("\r\n" + "if (returnObjLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.Append("\r\n" + $"const arrObjLst = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(returnObjLst);");
            strCodeForCs.Append("\r\n" + "return arrObjLst;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GetSubObjLst_WACacheAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetSubObjLst_WACacheAsync(obj{0}Cond: {0}): Promise<Array<{0}> | null>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "�������������ȡ��Ӧ�ļ�¼�����б�";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �������������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}Cond:��������", ThisTabName4GC);
            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ��¼�����б�");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetSubObjLst_WACacheAsync(obj{0}Cond: {0}): Promise<Array<{0}>>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetSubObjLst_WACacheAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetSubObjLstCache\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, {0}, config);", ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
            strCodeForCs.Append("\r\n" + "if (returnObjLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.Append("\r\n" + $"const arrObjLst = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(returnObjLst);");
            strCodeForCs.Append("\r\n" + "return arrObjLst;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetFirstObjAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetFirstObjAsync(strWhereCond: string): Promise<{0} | null>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "����WebApi,����������ȡ���������ĵ�һ����¼����";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����������ȡ���������ĵ�һ����¼����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @returns ��һ����¼����");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetFirstObjAsync(strWhereCond: string): Promise<{0}|null>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetFirstObjAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetFirstObj\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "strWhereCond,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");

            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObj = data.returnObj;");
            strCodeForCs.Append("\r\n" + "if (returnObj == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return null;");
            //strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            //strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            //strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//console.log(returnObj);");
            strCodeForCs.Append("\r\n" + $"const obj{ThisTabName4GC} = {thisWA_F(WA_F.GetObjFromJsonObj)}(returnObj);");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0};", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "} catch (error: any) {");
            
            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetMaxStrIdAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetMaxStrIdAsync(): Promise<string>  ",
              ThisTabName4GC,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "����WebApi,��ȡ������ؼ���";

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "/*�ñ�Ĺؼ������Ͳ����ַ�������,����Ҫ���ɻ�ȡ���ؼ��ֺ���!*/";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ȡ������ؼ���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ��ȡ������ؼ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetMaxStrIdAsync(): Promise<string>  ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetMaxStrIdAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetMaxStrId\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            //strCodeForCs.Append("\r\n" + "params: {");
            //strCodeForCs.Append("\r\n" + "strWhereCond,");
            //strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");
                        
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");

            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnStr;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetMaxStrIdByPrefixAsync()
        {
            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetMaxStrIdByPrefixAsync)}(strPrefix: string): Promise<string>  ";
            Re_objFunction4Code.FuncCHName4Code = "����WebApi,����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�";

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06) return "/*�ñ�Ĺؼ������Ͳ����ַ��ʹ�ǰ׺����,����Ҫ���ɻ�ȡ���ؼ��ֺ���!*/"; ;

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param mapParam:�����б�");
            strCodeForCs.Append("\r\n * @returns ��ȡ��ǰ��ؼ���ֵ�����ֵ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetMaxStrIdByPrefixAsync)}(strPrefix: string): Promise<string>  ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetMaxStrIdByPrefixAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetMaxStrIdByPrefix\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "strPrefix,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");

            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnStr;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// ͨ�õĵ���WebApi����
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_CallWebApiAsync()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ͨ�õĵ���WebApi����");
            strCodeForCs.AppendFormat("\r\n * mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param MethodName:����");
            strCodeForCs.Append("\r\n * @param mapParam:�����б�");
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n" + "CallWebApi(strFunctionName: string, dictPara, myURL) ");
            strCodeForCs.Append("\r\n" + "{");
            //strFunctionName = "mySum";
            //strCodeForCs.Append("\r\n" + "const strPara;");
            //strCodeForCs.Append("\r\n" + "strPara = \"\";");
            //strCodeForCs.Append("\r\n" + "  var myKeyss = dictPara.keys();");
            //strCodeForCs.Append("\r\n" + "             var intLength = dictPara.length();");
            //strCodeForCs.Append("\r\n" + "for (let i = 0; i < intLength; i++)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const key = myKeyss[i];");
            //strCodeForCs.Append("\r\n" + "const value = dictPara.getItem(key);");
            //strCodeForCs.Append("\r\n" + "const strTemp = `<${key}>${value}</${key}>\");");
            //strCodeForCs.Append("\r\n" + "strPara = strPara + strTemp;");
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "const data;");
            //strCodeForCs.Append("\r\n" + "data = '<?xml version=\"1.0\" encoding=\"utf-8\"?>';");
            //strCodeForCs.Append("\r\n" + "data = data + '<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">';");
            //strCodeForCs.Append("\r\n" + "data = data + '<soap:Body>';");
            //strCodeForCs.Append("\r\n" + "data = data + `<${strFunctionName} xmlns=\"http://tempuri.org/\">\");");
            //strCodeForCs.Append("\r\n" + "            data = data + strPara;");
            //strCodeForCs.Append("\r\n" + "data = data + `</${strFunctionName}>';");
            //strCodeForCs.Append("\r\n" + "data = data + '</soap:Body>';");
            //strCodeForCs.Append("\r\n" + "data = data + '</soap:Envelope>';");
            //strCodeForCs.Append("\r\n" + "            xmlhttp = getXmlHttp();");
            //strCodeForCs.Append("\r\n" + "const URL = myURL;//WEB_SERVICE_URL;//\"http://localhost:2408/ExamLib/WebApi/MyTest1Service.asmx\";");
            //strCodeForCs.Append("\r\n" + "xmlhttp.open(\"POST\", URL, true);");
            //strCodeForCs.Append("\r\n" + "xmlhttp.setRequestHeader(\"Content-Type\", \"text/xml; charset=gb2312\");");
            //strCodeForCs.Append("\r\n" + "const strSOAPAction = `http://tempuri.org/${strFunctionName}\");");
            //strCodeForCs.Append("\r\n" + "xmlhttp.setRequestHeader(\"SOAPAction\", strSOAPAction);");
            //strCodeForCs.Append("\r\n" + "xmlhttp.send(data);");
            //strCodeForCs.Append("\r\n" + "xmlhttp.onreadystatechange = function() {");
            //strCodeForCs.Append("\r\n" + "//HTTP �����״̬.��һ�� XMLHttpRequest ���δ���ʱ,������Ե�ֵ�� 0 ��ʼ,ֱ�����յ������� HTTP ��Ӧ,���ֵ���ӵ� 4  ");
            //strCodeForCs.Append("\r\n" + "if (xmlhttp.readyState === 4)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "getReturnValue(strFunctionName);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ͨ�õĵ���WebApi����
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_CallWebApiAsync_Ts_SelfDefWs()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ͨ�õĵ���WebApi����");
            //            strCodeForCs.AppendFormat("\r\n * mapParam����:{0} = \"01\"", objWebSrvClassENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param MethodName:����");
            strCodeForCs.Append("\r\n * @param mapParam:�����б�");
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "this.CallWebApi = function(strFunctionName, dictPara, myURL) ");
            strCodeForCs.Append("\r\n" + "{");
            //strFunctionName = "mySum";
            strCodeForCs.Append("\r\n" + "const strPara;");
            strCodeForCs.Append("\r\n" + "strPara = \"\";");
            strCodeForCs.Append("\r\n" + "  var myKeyss = dictPara.keys();");
            strCodeForCs.Append("\r\n" + "             var intLength = dictPara.length();");
            strCodeForCs.Append("\r\n" + "for (let i = 0; i < intLength; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const key = myKeyss[i];");
            strCodeForCs.Append("\r\n" + "const value = dictPara.getItem(key);");
            strCodeForCs.Append("\r\n" + "const strTemp = `<${key}>${value}</${key}>`, ;");
            strCodeForCs.Append("\r\n" + "strPara = strPara + strTemp;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "const data;");
            strCodeForCs.Append("\r\n" + "data = '<?xml version=\"1.0\" encoding=\"utf-8\"?>';");
            strCodeForCs.Append("\r\n" + "data = data + '<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">';");
            strCodeForCs.Append("\r\n" + "data = data + '<soap:Body>';");
            strCodeForCs.Append("\r\n" + "data = data + `<${strFunctionName} xmlns=\"http://tempuri.org/\">' ;");
            strCodeForCs.Append("\r\n" + "            data = data + strPara;");
            strCodeForCs.Append("\r\n" + "data = data + `</${strFunctionName}>\");");
            strCodeForCs.Append("\r\n" + "data = data + '</soap:Body>';");
            strCodeForCs.Append("\r\n" + "data = data + '</soap:Envelope>';");
            strCodeForCs.Append("\r\n" + "            xmlhttp = getXmlHttp();");
            strCodeForCs.Append("\r\n" + "const URL = myURL;//WEB_SERVICE_URL;//\"http://localhost:2408/ExamLib/WebApi/MyTest1Service.asmx\";");
            strCodeForCs.Append("\r\n" + "xmlhttp.open(\"POST\", URL, true);");
            strCodeForCs.Append("\r\n" + "xmlhttp.setRequestHeader(\"Content-Type\", \"text/xml; charset=gb2312\");");
            strCodeForCs.Append("\r\n" + "const strSOAPAction = `http://tempuri.org/${strFunctionName}\");");
            strCodeForCs.Append("\r\n" + "xmlhttp.setRequestHeader(\"SOAPAction\", strSOAPAction);");
            strCodeForCs.Append("\r\n" + "xmlhttp.send(data);");
            strCodeForCs.Append("\r\n" + "xmlhttp.onreadystatechange = function() {");
            strCodeForCs.Append("\r\n" + "//HTTP �����״̬.��һ�� XMLHttpRequest ���δ���ʱ,������Ե�ֵ�� 0 ��ʼ,ֱ�����յ������� HTTP ��Ӧ,���ֵ���ӵ� 4  ");
            strCodeForCs.Append("\r\n" + "if (xmlhttp.readyState === 4)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "getReturnValue(strFunctionName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_mainAsync()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �̳�Runnable�����ʵ�ֵġ�run������");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "this.main = function()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "switch (this.MethodName)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetJSONObjBy{1}\":",
                ThisTabName4GC,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 1;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.GetJSONObjBy{1}(this.Param);",
                ThisTabName4GC,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetJSONObjLst\":",
                ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 2;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.GetJSONObjLst(this.Param);",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"AddNewRecordByJSON\":");
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 3;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.AddNewRecordByJSON(this.Param, this.{0});",
                ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"UpdateRecordByJSON\":");
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 4;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecordByJSON(this.Param, this.{0});",
                ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"DelRecord\":");
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 5;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.DelRecord(this.Param);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetFirstJSONObj\":",
                ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 6;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.GetFirstJSONObj(this.Param);",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"IsExistRecord\":",
    ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 7;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.IsExistRecord(this.Param);",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetMaxStrId\":",
                ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 8;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.GetMaxStrId(this.Param);",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.AppendFormat("\r\n" + "case \"GetMaxStrIdByPrefix\":",
             ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 9;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.GetMaxStrIdByPrefix(this.Param);",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetTopJSONObjLst\":",
ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 10;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.GetTopJSONObjLst(this.Param);",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetJSONObjLstByPager\":",
ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 11;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.GetJSONObjLstByPager(this.Param);",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetRecCountByCond\":",
ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 12;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.GetRecCountByCond(this.Param);",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_mainAsync_Ts_SelfDefWs()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �̳�Runnable�����ʵ�ֵġ�run������");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "this.main = function()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "switch (this.MethodName)");
            strCodeForCs.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strCodeForCs.AppendFormat("\r\n" + "case \"{0}\":",
              objWebSrvFunctionsENEx.FunctionName);
                strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = {0};", intIndex);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "this.{1}(this.Param);",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(err)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "break;");
                intIndex++;
            }
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_startAsync()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �̳�Runnable�����ʵ�ֵġ�run������");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "this.start = function()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjByKeyIdAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format($"export  async function {thisWA_F(WA_F.GetObjByKeyId)}({objPrjTabENEx.KeyVarDefineLstStr_TS}): Promise<{ThisClsName4EN} | null>  ");

            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ��ֻ�ȡ��Ӧ��¼�Ķ���.";

            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.arrKeyFldSet.Count>1)
            {
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.Append("\r\n * �Ѷ�ؼ���ֵ�ֽ�Ϊ�����ؼ��ֵ�ֵ,�����Զ�����ʽ����");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param strKeyLst:��ؼ���ֵ", objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n * @returns �ֽ��ĵ����ؼ���ֵ����");
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "export  function " + this.tabNameHead + "SplitKeyLst(strKeyLst: string)  ");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const arrKey = strKeyLst.split('|');");
                strCodeForCs.AppendFormat("\r\n" + "if (arrKey.length != {0})", objPrjTabENEx.arrKeyFldSet.Count);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"��ѡ����Ҫ�޸ĵļ�¼!\";");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "const objKeyLst = {");
                int intIndex = 0;
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0}: Number(arrKey[{1}]),", objInFor.ObjFieldTab0().PropertyName(this.IsFstLcase), intIndex);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0}: arrKey[{1}],", objInFor.ObjFieldTab0().PropertyName(this.IsFstLcase), intIndex);
                    }
                    intIndex++;
                }
                strCodeForCs.Append("\r\n" + "};");
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (objKeyLst.{0} == 0)", objInFor.ObjFieldTab0().PropertyName(this.IsFstLcase));
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(objKeyLst.{0})== true)", objInFor.ObjFieldTab0().PropertyName(this.IsFstLcase));
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"�ؼ��ֶ�({0})ֵ����Ϊ��!\";", objInFor.ObjFieldTab0().PropertyName(this.IsFstLcase));
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "return objKeyLst;");
                strCodeForCs.Append("\r\n" + "}");

            }
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݹؼ��ֻ�ȡ��Ӧ��¼�Ķ���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�ؼ���", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n * @returns ����");
            strCodeForCs.Append("\r\n **/");
            string strFuncName;
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjByKeyId)}({objPrjTabENEx.KeyVarDefineLstStr_TS}): Promise<{ThisClsName4EN}|null>  ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strThisFuncName = \"GetObjByKeyLstAsync\";");
                strFuncName = string.Format("GetObjByKeyLstAsync");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjByKeyId)}({objPrjTabENEx.KeyVarDefineLstStr_TS}): Promise<{ThisClsName4EN}|null>  ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjBy{0}Async\";", KeyFldName);
                strFuncName = string.Format("GetObjBy{0}Async", KeyFldName);
            }
        
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                var strTemp = clsPubFun4GC.Gc_CheckVarEmpty_Ts(objInFor.PrivFuncName, objInFor.TypeScriptType,
                    objInFor.ObjFieldTab().DataTypeId,
                    this.ClsName, strFuncName, objInFor.ObjFieldTab().FldLength, true, this, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + strTemp);
            }
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + "const strAction = \"GetObjByKeyLst\";");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjBy{0}\";",
                  objKeyField.FldName);
            }
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "{0},", objInFor.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObj = data.returnObj;");
            strCodeForCs.Append("\r\n" + "if (returnObj == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return null;");
            //strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            //strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            //strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//console.log(returnObj);");
            strCodeForCs.Append("\r\n" + $"const obj{ThisTabName4GC} = {thisWA_F(WA_F.GetObjFromJsonObj)}(returnObj);");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0};", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjByKeyId_WACacheAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjBy{0}_WACacheAsync({1}): Promise<{2} | null>  ",
              KeyFldName,
              clsPrjTabBLEx.ParaVarDefLstStr(objPrjTabENEx, "TypeScript"), ThisClsName4EN);

            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ��ֻ�ȡ��Ӧ�Ķ���.";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݹؼ��ֻ�ȡ��Ӧ�Ķ���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�ؼ���", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n * @returns ����");
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjBy{0}_WACacheAsync({1}): Promise<{2} | null>  ",
          KeyFldName,
          clsPrjTabBLEx.ParaVarDefLstStr(objPrjTabENEx, "TypeScript"), ThisClsName4EN);

            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjBy{0}_WACacheAsync({1}): Promise<{2}|null>  ",
              KeyFldName,
              clsPrjTabBLEx.ParaVarDefLstStr(objPrjTabENEx, "TypeScript"), ThisClsName4EN);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjBy{0}_WACacheAsync\";", KeyFldName);

            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (objInFor.IsNumberType())
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true) ", objInFor.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ؼ��ֲ���Ϊ��!�ӱ��ػ����л�ȡ�������. (in {0}.{1})\", " + this.constructorName+ ", strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjBy{1}Cache\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            var objVarManage = clsPrjTabBLEx.GetVarManageObj(objPrjTabENEx, "TypeScript");
            var arrVarObjLst = objVarManage.GetObjLst();
            foreach (var objVar in arrVarObjLst)
            {
                strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},", objVar.FldName, objVar.VariableName);
            }

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObj = data.returnObj;");
            strCodeForCs.Append("\r\n" + "if (returnObj == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return null;");
            //strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            //strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            //strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//console.log(returnObj);");
            strCodeForCs.Append("\r\n" + $"const obj{ThisTabName4GC} = {thisWA_F(WA_F.GetObjFromJsonObj)}(returnObj);");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0};", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ��ȡ����ֵ����
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_getReturnValueAsync()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ȡ����ֵ����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.Append("\r\n" + "  function getReturnValue(strFunctionName) {");
            strCodeForCs.Append("\r\n" + "//alert(xmlhttp.readyState);");
            strCodeForCs.Append("\r\n" + "////5��������Ӧ����");
            strCodeForCs.Append("\r\n" + "////�ж϶����״̬�ǽ������");
            strCodeForCs.Append("\r\n" + "                //�ж�http�Ľ����Ƿ�ɹ�");
            strCodeForCs.Append("\r\n" + "if (xmlhttp.status !== 200)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(\"������!!!\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ʹ��responseXML�ķ�ʽ������XML���ݶ����DOM����");
            strCodeForCs.Append("\r\n" + "const domObj = xmlhttp.responseXML;");
            strCodeForCs.Append("\r\n" + "if (domObj)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//<message>123123123</message>");
            strCodeForCs.Append("\r\n" + "//dom������getElementsByTagName���Ը��ݱ�ǩ������ȡԪ�ؽڵ�,���ص���һ������");
            strCodeForCs.Append("\r\n" + "const strReturnTag = strFunctionName + \"Result\";");
            strCodeForCs.Append("\r\n" + "const messageNodes = domObj.getElementsByTagName(strReturnTag);");

            strCodeForCs.Append("\r\n" + "if (messageNodes.length > 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//��ȡmessage�ڵ��е��ı�����");
            strCodeForCs.Append("\r\n" + "//message��ǩ�е��ı���dom����message��ǩ����Ӧ��Ԫ�ؽڵ���ֽڵ�,firstChild���Ի�ȡ����ǰ�ڵ�ĵ�һ���ӽڵ�");
            strCodeForCs.Append("\r\n" + "//ͨ�����·�ʽ�Ϳ��Ի�ȡ���ı���������Ӧ�Ľڵ�");
            strCodeForCs.Append("\r\n" + "const textNode = messageNodes[0].firstChild;");
            strCodeForCs.Append("\r\n" + "//�����ı��ڵ���˵,����ͨ��nodeValue�ķ�ʽ�����ı��ڵ���ı�����");
            //            strCodeForCs.Append("\r\n" + "const responseMessage = textNode.nodeValue;");
            strCodeForCs.Append("\r\n" + "const responseMessage = \"\";");
            strCodeForCs.Append("\r\n" + "if (textNode === null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "responseMessage = \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "responseMessage = textNode.nodeValue;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "ResponseData.errorId = 0;");
            strCodeForCs.Append("\r\n" + "ResponseData.IsFinished = true;");
            strCodeForCs.Append("\r\n" + "ResponseData.data = responseMessage;");
            strCodeForCs.Append("\r\n" + "ReCallFunc();");
            strCodeForCs.Append("\r\n" + "//alert(ResponseData.data);");
            strCodeForCs.Append("\r\n" + "//��������ʾ��ҳ����");
            strCodeForCs.Append("\r\n" + "//ͨ��dom�ķ�ʽ�ҵ�div��ǩ����Ӧ��Ԫ�ؽڵ�");
            strCodeForCs.Append("\r\n" + "//var divNode = document.getElementById(\"result\");");
            strCodeForCs.Append("\r\n" + "////����Ԫ�ؽڵ��е�html����");
            strCodeForCs.Append("\r\n" + "//divNode.innerHTML = responseMessage;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "ResponseData.IsFinished = true;");
            strCodeForCs.Append("\r\n" + "ResponseData.errorId = 1;");
            strCodeForCs.Append("\r\n" + "ResponseData.faultString = \"XML���ݸ�ʽ����\";");

            strCodeForCs.Append("\r\n" + "myShowErrorMsg(\"XML���ݸ�ʽ����,ԭʼ�ı�����Ϊ: \" + xmlhttp.responseText);");
            strCodeForCs.Append("\r\n" + "ReCallFunc();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(\"XML���ݸ�ʽ����,ԭʼ�ı�����Ϊ: \" + xmlhttp.responseText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_ByCommonFunctionAsync(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {

            string strMsg = "";
            clsDataTypeAbbrEN objFuncReturnTypeEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFunctionsENEx.ReturnTypeId);
            clsSelfDefDataTypeEN objSelfDefDataTypeEN = null;
            if (objFuncReturnTypeEN == null)
            {
                objSelfDefDataTypeEN = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFunctionsENEx.ReturnType);
                if (objSelfDefDataTypeEN == null)
                {
                    strMsg = string.Format("�����ķ�������: [{0}({1})]û�д���,����������Ӧ���롣", objWebSrvFunctionsENEx.ReturnTypeId, objWebSrvFunctionsENEx.ReturnType);
                    throw new Exception(strMsg);
                }
            }

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
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
                        strMsg = string.Format("������������������: [{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {

                    strCodeForCs.AppendFormat("\r\n * @param {0}:�����Ͳ���,����:{1}",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.TypeScriptType, objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n * @param {0}:{1}",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.TypeScriptType,
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
            strCodeForCs.AppendFormat("\r\n * @returns ����{0}",
                objWebSrvFunctionsENEx.ReturnValueDescription);
            strCodeForCs.Append("\r\n **/");
            if (objSelfDefDataTypeEN != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.{1} = function(mapParam)",
                        objSelfDefDataTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                            sbParaList.ToString());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.{1} = function(mapParam)",
                       objFuncReturnTypeEN.TypeScriptType, objWebSrvFunctionsENEx.FunctionName,
                           sbParaList.ToString());
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMethodName = \"{0}\";",
              objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{        ");
            strCodeForCs.AppendFormat("\r\n" + "return this.CallWebApi(strMethodName, mapParam, this.WEB_SERVICE_URL);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "catch (objException)");
            strCodeForCs.Append("\r\n" + "{        ");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"�ڵ���WebApi����:[{0}]ʱ����,������Ϣ:{{0}}\", objException);",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_ClassConstructor1Async()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Ts_ComboBoxBindFunctionAsync()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    
                    strCodeForCs.Append("\r\n /**");
                    strCodeForCs.Append("\r\n * �󶨻���Win��������");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n * @param objComboBox:��Ҫ�󶨵�ǰ���������");
                    strCodeForCs.Append("\r\n **/");
                    strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox): Promise<number> ",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"BindCbo_{0}\";", strValueFieldName,
      objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strCodeForCs.AppendFormat("\r\n" + "Array<{0}> arrObjLst = GetObjLst(\"1=1\");",
                    ThisClsName4EN);


                    strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                    ThisClsName4EN, ThisObjName4EN);
                    strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    //strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    //ThisTabName4GC);
                    strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strCodeForCs.AppendFormat("\r\n" + "{1} = new {0}();",
                    ThisClsName4EN, ThisObjName4EN);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.{1} = \"0\";",
                    ThisObjName4EN, strValueFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "{0}.{1} = \"ѡ[{2}]...\";",
                        ThisObjName4EN, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst.Insert(0, {0});",
                    ThisObjName4EN);
                    strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
                  
                    strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = arrObjLst;",
                    ThisTabName4GC);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember=\"{1}\";",
                            ThisTabName4GC, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember=\"{1}\";",
                           ThisTabName4GC, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Ts_DdlBindFunctionAsync()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///���ɽ��б���;
                //��������ĺ��� ����;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {

                    strCodeForCs.Append("\r\n /**");
                    strCodeForCs.Append("\r\n * �󶨻���Web��������");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");
                    strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                    strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL): Promise<number> ",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"BindDdl_{0}\";", strValueFieldName,
      objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
                          objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "Array<{0}> arrObjLst = GetObjLst(\"1=1\");",
                        ThisClsName4EN);

                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField=\"{1}\";",
                        ThisTabName4GC, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField=\"{1}\";",
                        ThisTabName4GC, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = arrObjLst;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_CheckPropertyNewAsync()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\npublic void CheckPropertyNew({0} {1})",
            ThisClsName4EN, ThisObjName4EN);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + ThisTabName4GC + "EN", this.IsFstLcase);

                if (objField.IsTabNullable = false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }
                    strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        strPrivPropNameWithObjectName);
                    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"\")",
                         strPrivPropNameWithObjectName);

                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"0\")",
                             strPrivPropNameWithObjectName);
                    }
                    strCodeForCs.Append(")");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n throw new Exception(\"�ֶ�[{0}]����Ϊ��(NULL)!\");",
                    objField.ColCaption);
                    strCodeForCs.Append("\r\n}");
                }


            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + ThisTabName4GC + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strCodeForCs.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})",
                         strPrivPropNameWithObjectName,
                          objField.ObjFieldTabENEx.FldLength);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n throw new Exception(\"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\");",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strCodeForCs.Append("\r\n}");
                }
            }
            //strCodeForCs.AppendFormat("\r\n {0}.SetIsCheckProperty(true);", ThisObjName4EN);

            strCodeForCs.Append("\r\n }");
            ///������������Ƿ���ȷ == == ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetFirstIdAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetFirstIDAsync(strWhereCond: string): Promise<string>  ",
              ThisTabName4GC,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "����WebApi,����������ȡ���������ĵ�һ����¼";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����������ȡ���������ĵ�һ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @returns ���صĵ�һ����¼�Ĺؼ���ֵ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetFirstIDAsync(strWhereCond: string): Promise<string>  ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetFirstIDAsync\";", KeyFldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetFirstID\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "strWhereCond,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");



            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnStr;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_GetFldValueAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetFldValueAsync(strFldName: string, strWhereCond: string): Promise<Array<string>>  ",
              ThisTabName4GC,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "����WebApi,����������ȡ���������ĵ�һ����¼";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����������ȡ���������ĵ�һ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @returns ���صĵ�һ����¼�Ĺؼ���ֵ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetFldValueAsync(strFldName: string, strWhereCond: string): Promise<Array<string>>  ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetFldValueAsync\";", KeyFldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetFldValue\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "strFldName,");
            strCodeForCs.Append("\r\n" + "strWhereCond,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrId = data.returnStrLst.split(',');");
            strCodeForCs.Append("\r\n" + "return arrId;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }



        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetNameByKeyIdCacheAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "string GetNameBy{1}Cache({2} {3}): Promise<string> ",
            ThisTabName4GC,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
            objKeyField.PrivFuncName,
            "");

            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.";


            string strNameFieldName = "";
            string strKeyFieldName = "";

            clsPrjTabFldENEx objField_Key = objPrjTabENEx.arrFldSet.Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
            clsPrjTabFldENEx objField_Name = objPrjTabENEx.arrFldSet.Find(x => x.FieldTypeId == enumFieldType.NameField_03);

            if (objField_Key != null)
            {
                strKeyFieldName = objField_Key.FldName;
            }
            if (objField_Name != null)
            {
                strNameFieldName = objField_Name.FldName;
            }

            if (strKeyFieldName == "" || strNameFieldName == "")
            {
                return "";
            }

            if (objPrjTabENEx.IsUseCache == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[Get{0}By{1}Cache]����;",
        strNameFieldName, objKeyField.FldName);

StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�����Ĺؼ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns ���ݹؼ��ֻ�ȡ������");
            strCodeForCs.AppendFormat("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "string Get{4}By{1}Cache({2} {3}): Promise<string> ",
            ThisTabName4GC,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
            objKeyField.PrivFuncName,
            strNameFieldName);

            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "string Get{4}By{1}Cache({2} {3}): Promise<string> ",
            ThisTabName4GC,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
            objKeyField.PrivFuncName,
            strNameFieldName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"Get{4}By{1}Cache\";", ThisTabName4GC,
            objKeyField.FldName);

            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (objInFor.IsNumberType())
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true) ", objInFor.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ؼ��ֲ���Ϊ��!�ӱ��ػ����л�ȡ�������. (in {0}.{1})\", " + this.constructorName+ ", strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");
            }

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            strCodeForCs.Append("\r\n" + "InitListCache(); ");


            strCodeForCs.Append("\r\n" + "int intStart = 0;");
            strCodeForCs.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "int intMid = 0;");
            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                 ThisClsName4EN, ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "while (intEnd >= intStart)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strCodeForCs.AppendFormat("\r\n" + "{1} = arr{0}ObjLstCache[intMid];",
              ThisTabName4GC, ThisObjName4EN);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.{1} == {2})",
                ThisObjName4EN,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intFindFailCount = 0;");
            strCodeForCs.AppendFormat("\r\n" + "return {0}.{1};",
                  ThisObjName4EN,
                  strNameFieldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if ({0}.{1}.CompareTo({2}) > 0)",
                  ThisObjName4EN,
                  objKeyField.FldName,
                  objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intEnd = intMid - 1;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intStart = intMid + 1;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "intFindFailCount++;");
            strCodeForCs.AppendFormat("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strNameFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "string strErrMsgForGetObjById = `��{0}���󻺴��б���,�Ҳ�����¼[{1} = {{ {2} }}][intFindFailCount = {{intFindFailCount}}](����:{{clsStackTrace.GetCurrFunction()}})\");",
              ThisTabName4GC,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strNameFieldName);
            strCodeForCs.AppendFormat("\r\n" + "if ({0} != null)",
                  ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += `���һ�β��ҵĶ�������ֶ�����ֵ:{{{0}.{1} }}.[intMid = {{intMid}}]\");",
               ThisObjName4EN,
               objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += `���һ�β��ҵĶ���Ϊnull, ����![intMid = {{intMid}}]\");",
               "{", "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               ThisTabName4GC,
                objKeyField.FldName,
                strNameFieldName);
            //strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strCodeForCs.AppendFormat("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ʼ���б���.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_InitListCacheAsync()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ʼ���б���.-----------------------------;


            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ��ʼ���б���.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n **/");
            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "void InitListCache(): Promise<boolean> ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"InitListCache\";", ThisTabName4GC,
           objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Format(\"1 = 1 order by {0}\");", objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null)",
            ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = {0}GetObjLst(strWhereCond);",
                  ThisTabName4GC);
            //strCodeForCs.AppendFormat("\r\n" + "intFldNumCache = arr{0}ObjLstCache.Count;", 
            //      ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            //��ʼ���б���.======================= = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_ReFreshCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "ReFreshCache():void","");
            Re_objFunction4Code.FuncCHName4Code = "ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[ReFreshCache]����;");

            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCheckEmpty = new StringBuilder();

            if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == true)
            {
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.Append("\r\n * ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
              
                    strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "ReFreshCache4Head({0}: {1}):void",
                    thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.TypeScriptType);
              
                strCodeForCs.Append("\r\n" + "{");
            //    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"ReFreshCache4Head\";", ThisTabName4GC,
            //objKeyField.FldName);

                //strCodeForCs.AppendFormat("\r\n" + "if ({0}_objCommFun4BL != null) ",
                //    ThisTabName4GC);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + " const strMsg:string = Format(\"ˢ�»���ɹ�!\");");

                strCodeForCs.Append("\r\n" + "console.trace(strMsg);");

                strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
                //strCodeForCs.AppendFormat("\r\n" + "this.arr{0}ObjLstCache = null;",
                //       ThisTabName4GC);

                strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");

                strCodeForCs.AppendFormat("\r\n" + "switch ({0}.CacheModeId)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.AppendFormat("\r\n" + "CacheHelper.ClearSessionStorage4Head(strKey);", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.AppendFormat("\r\n" + "CacheHelper.ClearLocalStorage4Head(strKey);", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", ThisTabName4GC);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                AddImportClass(objPrjTabENEx.TabId, "/PubFun/CacheHelper.js", "CacheHelper", enumImportObjType.CustomFunc, this.strBaseUrl);

            }

            string strFuncName_Temp = string.Format("{0}.ReFreshCache", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "ReFreshCache():void");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "ReFreshCache({0}: {1}):void",
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);
                sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName,
   thisCacheClassify_TS.TypeScriptType,
        thisCacheClassify_TS.DataTypeId,
   this.ClsName, strFuncName_Temp,
   thisCacheClassify_TS.FldLength,
   thisCacheClassify_TS.DataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));
                Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "ReFreshCache({0}: {1}):void",
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "ReFreshCache({0}: {1}, {2}: {3}):void",
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
                thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);

                var strTemp = clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName,
   thisCacheClassify_TS.TypeScriptType,
   thisCacheClassify_TS.DataTypeId,
this.ClsName, strFuncName_Temp,
   thisCacheClassify_TS.FldLength,
   thisCacheClassify_TS.DataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl);

                sbCheckEmpty.Append("\r\n" + strTemp);
                sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName2,
   thisCacheClassify_TS.TypeScriptType2,
   thisCacheClassify_TS.DataTypeId2,
   this.ClsName, strFuncName_Temp,
   thisCacheClassify_TS.FldLength2,
   thisCacheClassify_TS.DataTypeId2 == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));

                Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "ReFreshCache({0}: {1}, {2}: {3}):void",
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
                thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);

            }
            strCodeForCs.Append("\r\n" + "{");
        //    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"ReFreshCache\";", ThisTabName4GC,
        //objKeyField.FldName);
            strCodeForCs.AppendLine(sbCheckEmpty.ToString());

            //strCodeForCs.AppendFormat("\r\n" + "if ({0}_objCommFun4BL != null) ",
            //    ThisTabName4GC);
            //strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " const strMsg:string = Format(\"ˢ�»���ɹ�!\");");

            strCodeForCs.Append("\r\n" + "console.trace(strMsg);");

            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strCodeForCs.AppendFormat("\r\n" + "this.arr{0}ObjLstCache = null;",
            //       ThisTabName4GC);
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = {thisWA_F(WA_F._CurrTabName)};");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
            }
            
            strCodeForCs.AppendFormat("\r\n" + "switch ({0}.CacheModeId)", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
            strCodeForCs.AppendFormat("\r\n" + "sessionStorage.removeItem(strKey);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
            strCodeForCs.AppendFormat("\r\n" + "localStorage.removeItem(strKey);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"cls{objPrjTabENEx.TabName}EN._RefreshTimeLst.push(clsDateTime.getTodayDateTimeStr(0));");
            if (objPrjTabENEx.IsRefresh4RelaView == true)
            {
                if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
                {
                    var arrTabId4View = clsPrjTabBLEx.GetRelaViewTabIdLstByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                    foreach (var x in arrTabId4View)
                    {
                        if (clsCMProjectPrjTabBLEx.IsExistRecord(this.CmPrjId, x) == false) continue;
                        var objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(x, objPrjTabENEx.PrjId);
                        var objPrjTabENEx_Curr = clsPrjTabBLEx.CopyToEx(objPrjTabEN);
                        objPrjTabENEx_Curr.GetObjAllInfoEx();
                        if (objPrjTabEN.TabStateId != enumTabState.Normal_01) continue;
                        if (objPrjTabEN.IsUseCache_TS() == false) continue;

                        if (string.IsNullOrEmpty(objPrjTabEN.CacheClassifyFieldTS) == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshThisCache();",
                            objPrjTabEN.TabName4GC());
                            AddImportClass(objPrjTabEN.TabId, objPrjTabEN.TabName, string.Format("ReFreshThisCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                        }
                        else if (string.IsNullOrEmpty(objPrjTabEN.CacheClassifyField2TS) == true )
                        {
                            if (thisCacheClassify_TS.IsHasCacheClassfyFld == true && thisCacheClassify_TS.FldId == objPrjTabENEx_Curr.objCacheClassifyFld_TS.FldId)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshThisCache({1});",
                                   objPrjTabEN.TabName4GC(), objPrjTabENEx_Curr.objCacheClassifyFld_TS.PrivFuncName);
                                AddImportClass(objPrjTabEN.TabId, objPrjTabEN.TabName, string.Format("ReFreshThisCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                            }
                        }
                        else
                        {
                            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
                            {
                                //��������չˢ�»���
                            }
                            else if (thisCacheClassify_TS.FldId != objPrjTabENEx_Curr.objCacheClassifyFld_TS.FldId)
                            {
                                //��������չˢ�»���
                            }
                            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshThisCache4Head({1});",
                            objPrjTabEN.TabName4GC(),
                            objPrjTabENEx_Curr.objCacheClassifyFld_TS.PrivFuncName);
                                AddImportClass(objPrjTabEN.TabId, objPrjTabEN.TabName, string.Format("ReFreshThisCache4Head"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                            }
                            else if (thisCacheClassify_TS.FldId2 != objPrjTabENEx_Curr.objCacheClassifyFld2_TS.FldId)
                                    {
                                strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshThisCache4Head({1});",
                            objPrjTabEN.TabName4GC(),
                            objPrjTabENEx_Curr.objCacheClassifyFld_TS.PrivFuncName);
                                AddImportClass(objPrjTabEN.TabId, objPrjTabEN.TabName, string.Format("ReFreshThisCache4Head"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshThisCache({1}, {2});",
                               objPrjTabEN.TabName4GC(),
                               objPrjTabENEx_Curr.objCacheClassifyFld_TS.PrivFuncName,
                               objPrjTabENEx_Curr.objCacheClassifyFld2_TS.PrivFuncName);
                                AddImportClass(objPrjTabEN.TabId, objPrjTabEN.TabName, string.Format("ReFreshThisCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                            }
                        }                       
                    }
                }
            }
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_ReFreshThisCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "ReFreshThisCache():void  ",
             ThisTabName4GC,
             objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "ˢ�±����еĻ���";

            if (objPrjTabENEx.IsUseCache_TS() == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[ReFreshThisCache]����;");

            StringBuilder strCodeForCs = new StringBuilder();
            if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == true)
            {
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.Append("\r\n * ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");

                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "ReFreshThisCache4Head({0}: {1}):void",
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);

                strCodeForCs.Append("\r\n" + "{");
            //    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"ReFreshThisCache4Head\";", ThisTabName4GC,
            //objKeyField.FldName);

                //strCodeForCs.AppendFormat("\r\n" + "if ({0}_objCommFun4BL != null) ",
                //    ThisTabName4GC);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + " const strMsg:string = Format(\"ˢ�»���ɹ�!\");");

                strCodeForCs.Append("\r\n" + "console.trace(strMsg);");

                strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
                //strCodeForCs.AppendFormat("\r\n" + "this.arr{0}ObjLstCache = null;",
                //       ThisTabName4GC);


                strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");

                strCodeForCs.AppendFormat("\r\n" + "switch ({0}.CacheModeId)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.AppendFormat("\r\n" + "CacheHelper.ClearSessionStorage4Head(strKey);", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.AppendFormat("\r\n" + "CacheHelper.ClearLocalStorage4Head(strKey);", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", ThisTabName4GC);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ˢ�±����еĻ���.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "ReFreshThisCache():void");
                strCodeForCs.Append("\r\n" + "{");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "ReFreshThisCache({0}: {1}):void",
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);
                Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "ReFreshThisCache({0}: {1}):void",
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);
                strCodeForCs.Append("\r\n" + "{");
                string strFuncName = $"{this.tabNameHead}ReFreshThisCache";

                string strDataTypeId = objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTab().ObjDataTypeAbbr1().DataTypeId;
                var strTemp = clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.TypeScriptType,
                    objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTab().DataTypeId,
                 this.ClsName, strFuncName, objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTab().FldLength, strDataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + strTemp);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "ReFreshThisCache({0}: {1}, {2}: {3}):void",
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
                thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);
                Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "ReFreshThisCache({0}: {1}, {2}: {3}):void",
                thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
                thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);
                strCodeForCs.Append("\r\n" + "{");
                string strFuncName = $"{this.tabNameHead}ReFreshThisCache";

                string strDataTypeId = objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTab().ObjDataTypeAbbr1().DataTypeId;
                var strTemp = clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.TypeScriptType,
                    objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTab().DataTypeId,
                 this.ClsName, strFuncName, objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTab().FldLength, strDataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + strTemp);

                string strDataTypeId2 = objPrjTabENEx.objCacheClassifyFld2_TS.ObjFieldTab().ObjDataTypeAbbr1().DataTypeId;
                var strTemp2 = clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName2, thisCacheClassify_TS.TypeScriptType2,
                    objPrjTabENEx.objCacheClassifyFld2_TS.ObjFieldTab().DataTypeId,
                 this.ClsName, strFuncName, objPrjTabENEx.objCacheClassifyFld2_TS.ObjFieldTab().FldLength, strDataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + strTemp2);

            }

            //      strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"ReFreshThisCache\";", ThisTabName4GC,
            //objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.spSetRefreshCacheOn == true)");
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = {thisWA_F(WA_F._CurrTabName)};");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const strKey = Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
            }
            
            strCodeForCs.AppendFormat("\r\n" + "switch ({0}.CacheModeId)", ThisClsName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
            strCodeForCs.AppendFormat("\r\n" + "sessionStorage.removeItem(strKey);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
            strCodeForCs.AppendFormat("\r\n" + "localStorage.removeItem(strKey);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"cls{objPrjTabENEx.TabName}EN._RefreshTimeLst.push(clsDateTime.getTodayDateTimeStr(0));");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"ˢ�»���ɹ�!\");");

            strCodeForCs.Append("\r\n" + "console.trace(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ˢ�»����Ѿ��رա�\");");
            strCodeForCs.Append("\r\n" + "console.trace(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "* ��ȡ���µĻ���ˢ��ʱ��");
            strCodeForCs.Append("\r\n" + "* @returns ���µĻ���ˢ��ʱ�䣬�ַ�����");
            strCodeForCs.Append("\r\n" + "**/");
            strCodeForCs.Append("\r\n" + $"export  function {this.tabNameHead}GetLastRefreshTime():string");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if (cls{objPrjTabENEx.TabName}EN._RefreshTimeLst.length == 0) return \"\";");
            strCodeForCs.Append("\r\n" + $"return cls{objPrjTabENEx.TabName}EN._RefreshTimeLst[cls{objPrjTabENEx.TabName}EN._RefreshTimeLst.length - 1];");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_DefineObjCommFun4BL()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// ר�����߼������ڴ�����ȹ��������Ķ���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "objCommFun4BL:clsCommFun4BL;");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "objCommFun4BL:clsCommFun4BLV2;");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "objCommFun4BL:clsCommFun4BLV3;");
            }
           

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GetObjLstByRangeAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<{0}> | null>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "���ݷ�Χ������ȡ��Ӧ�ļ�¼�����б�,��ȡĳ��Χ�ļ�¼";

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݷ�Χ������ȡ��Ӧ�ļ�¼�����б�,��ȡĳ��Χ�ļ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param objRangePara:���ݷ�Χ��ȡ�����б�Ĳ�������");
            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ��¼�����б�");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<{0}>>  ",
              ThisClsName4EN,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByRangeAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "const strAction = \"GetObjLstByRange\";");
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, objRangePara, config);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
            strCodeForCs.Append("\r\n" + "if (returnObjLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strNullInfo = Format(\"��ȡ����Ϊnull, ��ע��!(in {0}.{1})\", " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strNullInfo);");
            strCodeForCs.Append("\r\n" + "throw(strNullInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.Append("\r\n" + $"const arrObjLst = {thisWA_F(WA_F.GetObjLstByJSONObjLst)}(returnObjLst);");
            strCodeForCs.Append("\r\n" + "return arrObjLst;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_DelRecordsAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "DelRecordsAsync(string strKeyIdLst): Promise<number> ",
            ThisTabName4GC, objKeyField.FldName);

            Re_objFunction4Code.FuncCHName4Code = "����WebApi��ɾ����¼,���ݹؼ����б�ɾ����¼";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݹؼ����б�ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ʵ��ɾ����¼�ĸ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "DelRecordsAsync(string strKeyIdLst): Promise<number> ",
            ThisTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"DelRecordsAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"DelRecords\";", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "string strErrMsg;");
            strCodeForCs.Append("\r\n" + "string strResult;");
            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new();");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(strKeyIdLst);",
            //    objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "return intResult;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = Format(\"ִ��WebApi���ܳ���, {HttpUtility.UrlDecode(objException.Message)}.(from {clsStackTrace.GetCurrClassFunction()}). WebApi��ַ:{2}).`,");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����־ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_DelRecordBySignAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "DelRecordBySignAsync(arr{1}: Array<string>): Promise<number> ",
            ThisTabName4GC, objKeyField.FldName);

            Re_objFunction4Code.FuncCHName4Code = "����WebApi��ɾ����¼,���ݹؼ����б���־ɾ����¼";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݹؼ����б���־ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param arr{0}:�ؼ����б�", objKeyField.FldName);
            strCodeForCs.Append("\r\n * @returns ʵ��ɾ����¼�ĸ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "DelRecordBySignAsync(arr{1}: Array<string>): Promise<number> ",
            ThisTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"DelRecordBySignAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"DelRecordBySign\";", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"����: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, arr{0}, config);", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����־ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_UnDelRecordBySignAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "UnDelRecordBySignAsync(arr{1}: Array<string>): Promise<number> ",
            ThisTabName4GC, objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ����б���־�ָ���¼";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݹؼ����б���־�ָ���¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param arr{0}:�ؼ����б�", objKeyField.FldName);
            strCodeForCs.Append("\r\n * @returns ʵ�ʻָ���¼�ĸ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "UnDelRecordBySignAsync(arr{1}: Array<string>): Promise<number> ",
            ThisTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"UnDelRecordBySignAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"UnDelRecordBySign\";", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"����: strIdentityID =01\";");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, arr{0}, config);", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_DelMultiRecordAsync()
        {
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                Re_objFunction4Code.FuncName4Code = string.Format("\r\n" + $"export  async function {thisWA_F(WA_F.DelRecKeyLstsAsync)}(arrKeyLsts: Array<string>): Promise<number> ");
            }
            else
            {
                Re_objFunction4Code.FuncName4Code = string.Format("\r\n" + $"export  async function {thisWA_F(WA_F.DelMultiRecordAsync)}(arr{objKeyField.FldName}: Array<string>): Promise<number> ");
            }
            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ����б�ɾ����¼";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݹؼ����б�ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n * @param arrKeyLsts:�ؼ����б�, �ؼ����Ƕ���ֶε����", objKeyField.FldName);
            }
            else
            { 
                strCodeForCs.AppendFormat("\r\n * @param arr{0}:�ؼ����б�", objKeyField.FldName);
            }
            strCodeForCs.Append("\r\n * @returns ʵ��ɾ����¼�ĸ���");
            strCodeForCs.Append("\r\n **/");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.DelRecKeyLstsAsync)}(arrKeyLsts: Array<string>): Promise<number> ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strThisFuncName = \"DelRecKeyLstsAsync\";");
                strCodeForCs.Append("\r\n" + "const strAction = \"DelRecKeyLsts\";");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.DelMultiRecordAsync)}(arr{objKeyField.FldName}: Array<string>): Promise<number> ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"Del{0}sAsync\";", ThisTabName4GC);

                strCodeForCs.AppendFormat("\r\n" + "const strAction = \"Del{0}s\";", ThisTabName4GC);
            }
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"����: strIdentityID =01\";");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.arrKeyFldSet.Count>1)
            {
                strCodeForCs.Append("\r\n" + "const response = await axios.post(strUrl, arrKeyLsts, config);");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, arr{0}, config);", objKeyField.FldName);
            }
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw data.errorMsg;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_DelMultiRecordByCondAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format($"export  async function {thisWA_F(WA_F.DelMultiRecordByCondAsync)}(strWhereCond: string): Promise<number> ",
            ThisTabName4GC);

            Re_objFunction4Code.FuncCHName4Code = "��������ɾ����¼";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��������ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ʵ��ɾ����¼�ĸ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "Del{0}sByCondAsync(strWhereCond: string): Promise<number> ",
            ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"Del{0}sByCondAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"Del{0}sByCond\";", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");

            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "strWhereCond,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");

            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��Ӽ�¼,���ҷ��عؼ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "AddNewRecordWithReturnKeyAsync({1}: {0}): Promise<string> ",
              ThisClsName4EN, ThisObjName4EN);
            Re_objFunction4Code.FuncCHName4Code = "�ѱ������ӵ����ݿ���,���ҷ��ظü�¼�Ĺؼ���(���Identity�ؼ��ֺ������ؼ���)";

            //if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �ѱ������ӵ����ݿ���,���ҷ��ظü�¼�Ĺؼ���(���Identity�ؼ��ֺ������ؼ���)");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ��ӵı����",
                    ThisObjName4EN);
            strCodeForCs.Append("\r\n * @returns ��������Ӽ�¼�Ĺؼ���");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "AddNewRecordWithReturnKeyAsync({1}: {0}): Promise<string> ",
            ThisClsName4EN, ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"AddNewRecordWithReturnKeyAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "const strAction = \"AddNewRecordWithReturnKey\";");

            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, {0}, config);", ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnStr;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ��Ӽ�¼,���ҷ��عؼ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_UpdateWithConditionAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "UpdateWithConditionAsync({1}: {0}, strWhereCond: string ): Promise<boolean> ",
            ThisClsName4EN, ThisObjName4EN);
            Re_objFunction4Code.FuncCHName4Code = "����WebApi���޸ļ�¼,�����������޸ļ�¼";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �����������޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:��Ҫ�޸ĵĶ���",
                  ThisObjName4EN);
            strCodeForCs.Append("\r\n * @param strWhereCond:������");
            strCodeForCs.Append("\r\n * @returns ���صĵ�һ����¼�Ĺؼ���ֵ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "UpdateWithConditionAsync({1}: {0}, strWhereCond: string ): Promise<boolean> ",
            ThisClsName4EN, ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"UpdateWithConditionAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "const strAction = \"UpdateWithCondition\";");
            strCodeForCs.AppendFormat("\r\n" + " if ({0}.sfUpdFldSetStr === undefined || {0}.sfUpdFldSetStr === null || {0}.sfUpdFldSetStr === \"\")",
             ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����(�ؼ���: {{0}})�ġ��޸��ֶμ���Ϊ��,�����޸�!\", {0}.{1});",
                ThisObjName4EN, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + " throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");

            strCodeForCs.AppendFormat("\r\n" + "{0}.whereCond = strWhereCond;", ThisObjName4EN);

            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");



            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, {0}, config);", ThisObjName4EN);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Ts_IsExistAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "IsExistAsync({0}: {1}): Promise<boolean> ",
                        objKeyField.PrivFuncName, KeyDataType);
            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ����ж��Ƿ���ڼ�¼";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݹؼ����ж��Ƿ���ڼ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�ؼ���", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n * @returns �Ƿ����?���ڷ���True");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + $"export  async function {this.tabNameHead}IsExistAsync({objPrjTabENEx.KeyVarDefineLstStr_TS}): Promise<boolean> ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"IsExistAsync\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//����¼�Ƿ����");
            strCodeForCs.Append("\r\n" + "const strAction = \"IsExist\";");
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0},", objInFor.PrivFuncName);
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{0}", objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return (data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "throw(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

            strCodeForCs.Append("\r\n" + "console.error(error);");

            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw error;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ܲ�����!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "throw(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Ts_GetWebApiUrlAsync()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "GetWebApiUrl(strController: string, strAction: string): string ",
             ThisTabName4GC,
             objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = "��ȡWebApi�ĵ�ַ";

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ȡWebApi�ĵ�ַ");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ���ص�ǰ�ļ���Web����ĵ�ַ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "export  function " + this.tabNameHead + "GetWebApiUrl(strController: string, strAction: string): string {");
      //      strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetWebApiUrl\";", ThisTabName4GC,
      //objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "let strServiceUrl:string;");
            strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false) {");
            strCodeForCs.Append("\r\n" + "strServiceUrl = Format(\"{0}/{1}/{2}/{3}\", clsSysPara4WebApi.CurrIPAddressAndPort, clsSysPara4WebApi.CurrPrx, strController, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + "strServiceUrl = Format(\"{0}/{1}/{2}/{3}\", clsSysPara4WebApi.CurrIPAddressAndPort_Local, clsSysPara4WebApi.CurrPrx, strController, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return strServiceUrl;");
            strCodeForCs.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4FunctionAsync_TypeScript(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCodeAsync_TypeScript(objvFunction4GeneCodeEN);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        //public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        //{
        //    return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, objPrjTabENEx.PrjId);
        //}
        private string GenStr_CheckClassifyFld(string strPrivFuncName, string strFldName, string strDataTypeId, bool bolIsNumber, int intFldLen, bool bolIsCheckLength, string strClassName, string strFuncName)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (bolIsNumber == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strPrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������:[{0}]����Ϊ��!(in {1}.{2})\");", strFldName, strClassName, strFuncName);
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", strPrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������:[{0}]����Ϊ��!(in {1}.{2})\");", strFldName, strClassName, strFuncName);
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                if (bolIsCheckLength == true && strDataTypeId == enumDataTypeAbbr.char_04)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length != {1})", strPrivFuncName, intFldLen);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������:[{0}]�ĳ���:[{{0}}]����ȷ!(in {1}.{2})\", {0}.length);", strPrivFuncName, strClassName, strFuncName);
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            return strCodeForCs.ToString();
        }
    }
}
