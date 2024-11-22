using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.datetime;
using AgcCommBase;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;


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
    partial class BusinessLogic4TypeScript : clsGeneCodeBase
    {
        #region ���캯��

        public BusinessLogic4TypeScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        public BusinessLogic4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        #endregion
        /// <summary>
        /// ����ҵ���߼�����룭��C#.NET
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strResult;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                     objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);
            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BL";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.TypeScriptLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".ts";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".ts";
            objPrjTabENEx.FileName = strClassFName;
            //clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //������ʼ
                //strCodeForCs.AppendFormat("\r\n" + "/// <reference path=\"../../l0_entity/{0}/cls{1}EN.ts\" />",
                //    objFuncModule.FuncModuleEnName4GC()
                //    objPrjTabENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "/// <reference path=\"../../PubFun/tzpubfun.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "/// <reference path=\"../../PubFun/jsstring.ts\" />");
                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}EN }} from \"../../L0Entity/{0}/cls{1}EN.js\";",
                    objFuncModule.FuncModuleEnName4GC(),
                    objPrjTabENEx.TabName);
                //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
                //{
                    strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}EN_Sim }} from \"../../L0Entity/{0}/cls{1}EN_Sim.js\";",
                        objFuncModule.FuncModuleEnName4GC(),
                        objPrjTabENEx.TabName);
                //}
                //strCodeForCs.Append("\r\n" + "import { GetStrLen, myShowErrorMsg } from \"../../PubFun/tzPubFun.js\";");
                //strCodeForCs.Append("\r\n" + "import { tzDataType } from \"../../PubFun/jsString.js\";");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// ����Դ����:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                //strCodeForCs.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//�ú���������/js/PubFun/jsPubFun.js�ļ���");

                //strCodeForCs.AppendFormat("\r\n" + "import {{ cls{0}EN }}  from '../../l0_Entity/SysPara/cls{0}EN';",
                //    objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "export class  cls{0}BL", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "private arr{0}ObjLstCache = new Array();",
                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "private intFindFailCount = 0;");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                     strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        if (objPrjTabENEx.LangType == clsPubConst.LangType.CSharp)
                        {
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        }
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.", strFuncName, objException.Message);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getRecObjByJSONStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ��JSON��ת��Ϊһ������");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">��Ҫת����JSON��</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵĶ���</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetObjByJSONStr (strJSON: string): cls{0}EN",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
              objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "if (strJSON === \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return pobj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //  var data : NSData! = NSJSONSerialization.dataWithJSONObject(strJSON, options: []);
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN = JSON.parse(strJSON);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return pobj{0}EN;",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return pobj{0}EN;",
                    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getJSONStrByRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ������ת��Ϊһ��JSON��");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">��Ҫת����JSON��</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵĶ���</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetJSONStrByObj (pobj{0}EN: cls{0}EN): string",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strBuilder.AppendFormat("\r\n" + "pobj{0}EN.sfUpdFldSetStr = pobj{0}EN.UpdFldString;",
                    objPrjTabENEx.TabName);
            }
            strBuilder.Append("\r\n" + "const strJson;");
            strBuilder.Append("\r\n" + "const jsonData;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strJson = JSON.stringify(pobj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(objException.message);");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n" + "if (strJson == undefined) return \"\";");
            strBuilder.Append("\r\n" + "else return strJson;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getDictionaryObjByRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ������ת��Ϊһ��JSON��");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">��Ҫת����JSON��</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵĶ���</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetDictionaryObjByObj (pobj{0}EN: cls{0}EN)",
                  objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN.sfUpdFldSetStr = pobj{0}EN.UpdFldString;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "const objDict;");
            strBuilder.Append("\r\n" + "objDict = NSMutableDictionary();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
                {
                    case "Int32":
                        strBuilder.AppendFormat("\r\n" + "objDict.setValue(String(pobj{0}EN.{1}), forKey: cls{0}EN.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n" + "objDict.setValue(pobj{0}EN.{1}, forKey: cls{0}EN.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                }
            }
            strBuilder.AppendFormat("\r\n" + "objDict.setValue(pobj{0}EN.sfUpdFldSetStr, forKey: \"sfUpdFldSetStr\");",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDict;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��һ��JSON��ת��Ϊһ�������б�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getObjLstByJSONStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ��JSON��ת��Ϊһ�������б�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">��Ҫת����JSON��</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵĶ����б�</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetObjLstByJSONStr (strJSON: string): Array<cls{0}EN>",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = new Array();",
              objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "if (strJSON === \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = JSON.parse(strJSON);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        private string SetPropertyByJson_TypeScript(clsPrjTabFldENEx objField)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n" + "if (jsonAllKeys.containsObject(\"{0}\") == true)",
                 objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            //  strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strBuilder.AppendFormat("\r\n" + "pobj{0}EN.{1} = String(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int32":
                    strBuilder.AppendFormat("\r\n" + "pobj{0}EN.{1} = Int32(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int":
                    strBuilder.AppendFormat("\r\n" + "pobj{0}EN.{1} = Int(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Bool":
                    strBuilder.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsPubFun.myBool(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift����������switch��û�д���({0})", clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4BL_Ts_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n public CheckPropertyNew(pobj{0}EN: cls{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("CheckPropertyNew1", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{1}|{0}]����Ϊ��(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.Append("\r\n//����ֶηǿ�, �����ݱ�Ҫ��ǳ��ǿյ��ֶ�,����Ϊ��!");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return "";//ֻ���Ͳ���Ҫ���
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    strBuilder.Append(inGen_CheckNull4Field_Ts(objField, strErrId, strFunctionName));
                }
            }

            //������Գ��ȴ���;
            strBuilder.Append(inGen_CheckFieldLength_Ts("CheckPropertyNew"));

            //����ֶε����������Ƿ���ȷ
            strBuilder.Append(inGen_CheckDataType_Ts(strFunctionName));

            //�������ֶγ���;

            strBuilder.Append(inGen_CheckFieldForeighKey_Ts("CheckPropertyNew"));


            strBuilder.Append("\r\n//����˵���ö����Ѿ�������,���治��Ҫ�ټ��,���Ƿ�!");

            strBuilder.AppendFormat("\r\n pobj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");


            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// רҵ����޸ļ�¼,�������ֶ�ֵ�Ƿ�Ϸ�,1)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n public CheckProperty4Update (pobj{0}EN: cls{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            //������Գ��ȴ���;

            strBuilder.Append(inGen_CheckFieldLength_Ts("CheckProperty4Update"));

            //������������Ƿ���ȷ
            strBuilder.Append(inGen_CheckDataType_Ts("CheckProperty4Update"));

            //��������Ƿ�Null
            strFunctionName = string.Format("CheckProperty4Update1", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{1}|{0}]����Ϊ��(NULL)!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.Append("\r\n//��������Ƿ�ΪNull���߿�!");

            strBuilder.Append(inGen_CheckNull4Field_Ts(objPrjTabENEx.objKeyField0, strErrId, "CheckProperty4Update"));
            ///�������ֶγ���;

            strBuilder.Append(inGen_CheckFieldForeighKey_Ts("CheckProperty4Update"));

            strBuilder.AppendFormat("\r\n pobj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///������������Ƿ���ȷ ==  ==  == = ;
            return strBuilder.ToString();
        }

        private string inGen_CheckDataType_Ts(string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();
            //����ֶε����������Ƿ���ȷ
           
            string strExplanation = "�ֶ�[{0}|{1}]��ֵ����{2}��,�Ƿ�,Ӧ��Ϊ��ֵ��!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "//����ֶε����������Ƿ���ȷ");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                string strDataTypeName = "";
                switch (objField.TypeScriptType)
                {
                    case "string":
                        strBuilder.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isString(pobj{0}EN.{1}) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "�ַ���";
                        break;
                    case "number":
                        strBuilder.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "��ֵ��";
                        break;
                    case "any":

                        strDataTypeName = "any��";
                        break;
                    case "long":
                        strBuilder.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "int":
                        strBuilder.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "����";
                        break;
                    case "double":
                        strBuilder.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "˫����";
                        break;
                    case "float":
                        strBuilder.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "short":
                        strBuilder.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "boolean":
                        strBuilder.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.{1}) === false)",
                         objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "Date":
                        strBuilder.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.{1}) === false)",
                         objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    default:
                        string strMsg = string.Format("Java��������:��{0}����switch��û�д���({0})",
                            clsStackTrace.GetCurrClassFunction(),
                            objField.JavaType);
                        throw new Exception(strMsg);

                }
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n throw new Error(`(errid:{7})�ֶ�[{2}({3})|{0}({4})]��ֵ:[${{pobj{3}EN.{4}}}], �Ƿ�,Ӧ��Ϊ{8}!(cls{3}BL:{9})`);",
                           objField.ColCaption,
                           objField.ObjFieldTabENEx.FldLength,
                           objPrjTabENEx.TabCnName,
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           "{", "}",
                           strErrId,
                           strDataTypeName,
                           strFunctionName);
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }
        private string inGen_CheckNull4Field_Ts(clsPrjTabFldENEx objField, string strErrId, string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();

            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + objPrjTabENEx.TabName + "EN");


            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
            {
                return "";
            }

            if (objField.FldOpTypeId == "0003")
            {

                strBuilder.AppendFormat("\r\n if (null === {0} ",
                    strPrivPropNameWithObjectName4Get);

                strBuilder.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.ToString()  ===  \"\" ",
                    strPrivPropNameWithObjectName4Get);
                if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                {
                    strBuilder.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {1}.toString()  ===  \"0\"",
                        strPrivPropNameWithObjectName4Get,
                        strPrivPropNameWithObjectName4Get);
                }
                strBuilder.Append("\r\n )");
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n throw new Error(`(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}BL:{4})`);",
                        objField.ColCaption,
                        objPrjTabENEx.TabCnName,
                        strErrId,
                        objPrjTabENEx.TabName,
                        strFunctionName);
                strBuilder.Append("\r\n}");
            }
            else
            {

                strBuilder.AppendFormat("\r\nif (null === {0} ", strPrivPropNameWithObjectName);
                strBuilder.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.toString()  ===  \"\"", strPrivPropNameWithObjectName);
                if (objField.ObjFieldTab4CodeConv() != null && string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                {
                    strBuilder.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.toString()  ===  \"0\" ", strPrivPropNameWithObjectName);
                }
                strBuilder.Append(")");
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n throw new Error(`(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}BL:{4})`);",
                            objField.ColCaption,
                            objPrjTabENEx.TabCnName,
                            strErrId,
                            objPrjTabENEx.TabName,
                            strFunctionName);
                strBuilder.Append("\r\n}");
            }

            return strBuilder.ToString();
        }
        private string inGen_CheckFieldLength_Ts(string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName = string.Format(strFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.Append("\r\n//����ֶγ���, ���ַ����ֶγ��ȳ����涨�ĳ���,���Ƿ�!");


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���

                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + objPrjTabENEx.TabName + "EN");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                  && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                  && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && {0} != '[null]' && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw new Error(`(errid:{7})�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:${{pobj{3}EN.{4}}})(cls{3}BL:{8})`;",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        objPrjTabENEx.TabCnName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName,
                        "{", "}",
                        strErrId,
                        strFunctionName);
                        strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && {0} != '[null]' && GetStrLen({0}) > {1})",
                             strPrivPropNameWithObjectName,
                              objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw new Error(`(errid:{7})�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:${{pobj{3}EN.{4}}}(cls{3}BL:{8})`);",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        objPrjTabENEx.TabCnName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName,
                        "{", "}",
                        strErrId,
                        strFunctionName);
                        strBuilder.Append("\r\n}");
                    }
                }
            }

            return strBuilder.ToString();
        }


        private string inGen_CheckFieldForeighKey_Ts(string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();

            //string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.Append("\r\n//������, ��Ϊ���Ӧ�ú��������ֶγ�����һ����, ����һ��,���Ƿ�!");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + objPrjTabENEx.TabName + "EN");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && {0} != '[null]' && GetStrLen({0}) != {1})",
                             strPrivPropNameWithObjectName4Get,
                              objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw (\"(errid:{3})�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!(cls{4}BL:CheckPropertyNew)\");",
                              objField.ColCaption,
                              objField.ObjFieldTabENEx.FldLength,
                              objPrjTabENEx.TabCnName,
                              strErrId,
                              objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && {0} != '[null]' && GetStrLen({0}) !=  {1})",
                            strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw (\"(errid:{3})�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!(cls{4}BL:CheckPropertyNew)\");",
                                 objField.ColCaption,
                                 objField.ObjFieldTabENEx.FldLength,
                                 objPrjTabENEx.TabCnName,
                              strErrId,
                              objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n}");
                    }
                }
            }
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }


        public string Gen_4BL_Ts_CopyObjToSimObj()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                //return "";
            }

            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������(��)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "CopyObjToSimObj(obj{0}ENS: cls{0}EN , obj{0}ENT: cls{0}EN_Sim ): void ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}ENT.sfUpdFldSetStr = obj{0}ENS.UpdFldString; //ר�����ڼ�¼ĳ�ֶ������Ƿ��޸�",
                objPrjTabENEx.TabName);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}ENT.sfFldComparisonOp = obj{0}ENS.sfFldComparisonOp; //ר�����ڼ�¼��������ĳ�ֶεıȽ������",
                objPrjTabENEx.TabName);
            
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_Ts_CopyToEx()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                //return "";
            }

            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������(��)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "CopyToEx(obj{0}ENS: cls{0}EN  ): cls{0}ENEx ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nvar obj{0}ENT: cls{0}ENEx = new cls{0}ENEx();", objPrjTabENEx.TabName);


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}ENT.sfUpdFldSetStr = obj{0}ENS.UpdFldString; //ר�����ڼ�¼ĳ�ֶ������Ƿ��޸�",
                objPrjTabENEx.TabName);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}ENT.sfFldComparisonOp = obj{0}ENS.sfFldComparisonOp; //ר�����ڼ�¼��������ĳ�ֶεıȽ������",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_Ts_CopyObjTo()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                return "";
            }

            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "CopyObjTo(obj{0}ENS: cls{0}EN , obj{0}ENT: cls{0}EN ): void ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}ENT.sfUpdFldSetStr = obj{0}ENS.UpdFldString; //sfUpdFldSetStr",
                objPrjTabENEx.TabName);
            }
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_Ts_GetSimObjFromObj()
        {
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            //{
            //    return "";
            //}
                StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������(��)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetSimObjFromObj(obj{0}ENS: cls{0}EN): cls{0}EN_Sim ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nvar obj{0}ENT: cls{0}EN_Sim = new cls{0}EN_Sim();", objPrjTabENEx.TabName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}ENT.sfUpdFldSetStr = obj{0}ENS.UpdFldString; //ר�����ڼ�¼ĳ�ֶ������Ƿ��޸�",
                    objPrjTabENEx.TabName);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}ENT.sfFldComparisonOp = obj{0}ENS.sfFldComparisonOp; //ר�����ڼ�¼��������ĳ�ֶεıȽ������",
                         objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n return obj{0}ENT;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_Ts_CopyObjFromSimObj()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                return "";
            }

            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "CopyObjFromSimObj(obj{0}ENS: cls{0}EN_Sim, obj{0}ENT: cls{0}EN): void ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_Ts_CopyObjFromSimObj4Upd()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                return "";
            }

            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����. ר������޸ļ�¼,�����ֶβŸ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "CopyObjFromSimObj4Upd(obj{0}ENS: cls{0}EN_Sim, obj{0}ENT: cls{0}EN ): void", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n   var strsfUpdFldSetStr: string = obj{0}ENS.sfUpdFldSetStr;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n    var sstrFldSet: string[] = strsfUpdFldSetStr.split('|');");
            //strBuilder.Append("\r\n   var arrFldSet : Array<string> = new Array<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (sstrFldSet.indexOf(cls{0}EN.con_{1})  >= 0)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strBuilder.Append("\r\n" + "}");

                }
            }
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

      

        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(BusinessLogic4TypeScript);
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

        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}BL", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
