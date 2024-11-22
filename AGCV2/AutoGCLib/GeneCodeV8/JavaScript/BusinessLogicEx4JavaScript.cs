using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

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
    partial class BusinessLogicEx4JavaScript : clsGeneCodeBase
    {
        #region ���캯��

        public BusinessLogicEx4JavaScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLst_Cache = null;
        }
        public BusinessLogicEx4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLst_Cache = null;
        }
        #endregion

     
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
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "js" + objPrjTabENEx.TabName + "BLEx";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.JavaScriptLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";
            objPrjTabENEx.FileName = strClassFName;
            //clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx));

                //������ʼ

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeId_Cache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// ����Դ����:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " /// <reference path=\"../PubFun/tzDictionary.js\" />");
                strCodeForCs.Append("\r\n" + " /// <reference path=\"../PubFun/jsString.js\" />");

                strCodeForCs.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//�ú���������/js/PubFun/jsPubFun.js�ļ���");

                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsString.js\");");

                strCodeForCs.AppendFormat("\r\n" + "const cls{0}BLEx = function()", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����XML����ǩ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "const itemXmlNode = \"{0}ListItem\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �б��XML����ǩ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "const listXmlNode = \"{0}List\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ϵ�XML����ǩ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "const itemsXmlNode = \"Items\";");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = new Array();",
                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "const intFindFailCount = 0;");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);
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
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
      
            }
            return strCodeForCs.ToString();
        }


        public string A_GeneFuncCode_JavaScript(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(BusinessLogicEx4JavaScript);
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
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_JavaScript_getRecObjByJSONStr()
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
            strBuilder.AppendFormat("\r\n" + "this.GetObjByJSONStr = function(strJSON)",
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
        public string Gen_4BL_JavaScript_getJSONStrByRecObj()
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
            strBuilder.AppendFormat("\r\n" + "this.GetJSONStrByObj = function(pobj{0}EN)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "pobj{0}EN.sf_UpdFldSetStr = pobj{0}EN.getUpdFldString();",
                objPrjTabENEx.TabName);

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
            strBuilder.Append("\r\n" + "return strJson;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_getDictionaryObjByRecObj_JavaScript()
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
            strBuilder.AppendFormat("\r\n" + "this.GetDictionaryObjByObj = function(pobj{0}EN)",
                  objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN.sf_UpdFldSetStr = pobj{0}EN.getUpdFldString();",
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
            strBuilder.AppendFormat("\r\n" + "objDict.setValue(pobj{0}EN.sf_UpdFldSetStr, forKey: \"sf_UpdFldSetStr\");",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDict;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��һ��JSON��ת��Ϊһ�������б�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_JavaScript_getObjLstByJSONStr()
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
            strBuilder.AppendFormat("\r\n" + "this.GetObjLstByJSONStr = function(strJSON)",
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

        private string SetPropertyByJson_JavaScript(clsPrjTabFldENEx objField)
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

        public string Gen_4BL_CheckPropertyNew_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n this.CheckPropertyNew = function(pobj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{1}|{0}]����Ϊ��(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.Append("\r\n//����ֶηǿգ� �����ݱ�Ҫ��ǳ��ǿյ��ֶΣ�����Ϊ�գ�");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return "";//ֻ���Ͳ���Ҫ���
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    strBuilder.Append(inGen_CheckNull4Field(objField, strErrId, strFunctionName));
                }
            }

            //������Գ��ȴ���;
            strBuilder.Append(inGen_CheckFieldLength("CheckPropertyNew"));

            //����ֶε����������Ƿ���ȷ
            strBuilder.Append(inGen_CheckDataType(strFunctionName));

            //�������ֶγ���;

            strBuilder.Append(inGen_CheckFieldForeighKey("CheckPropertyNew"));


            strBuilder.Append("\r\n//����˵���ö����Ѿ������ˣ����治��Ҫ�ټ�飬���Ƿ���");

            strBuilder.AppendFormat("\r\n pobj{0}EN.setIsCheckProperty(true);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");


            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// רҵ����޸ļ�¼,�������ֶ�ֵ�Ƿ�Ϸ�,1)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n this.CheckProperty4Update = function(pobj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            //������Գ��ȴ���;

            strBuilder.Append(inGen_CheckFieldLength("CheckProperty4Update"));

            //������������Ƿ���ȷ
            strBuilder.Append(inGen_CheckDataType("CheckProperty4Update"));

            //��������Ƿ�Null
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{1}|{0}]����Ϊ��(NULL)!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.Append("\r\n//��������Ƿ�ΪNull���߿գ�");

            strBuilder.Append(inGen_CheckNull4Field(objPrjTabENEx.objKeyField0, strErrId, "CheckProperty4Update"));
            ///�������ֶγ���;

            strBuilder.Append(inGen_CheckFieldForeighKey("CheckProperty4Update"));

            strBuilder.AppendFormat("\r\n pobj{0}EN.setIsCheckProperty(true);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///������������Ƿ���ȷ ==  ==  == = ;
            return strBuilder.ToString();
        }

        private string inGen_CheckDataType(string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();
            //����ֶε����������Ƿ���ȷ
            //   string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{0}|{1}]��ֵ����{2}��,�Ƿ���Ӧ��Ϊ��ֵ��!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "//����ֶε����������Ƿ���ȷ");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");

                string strDataTypeName = "";
                switch (objField.JavaType)
                {
                    case "String":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isString(pobj{0}EN.get{1}()) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "�ַ���";
                        break;
                    case "long":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "int":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "����";
                        break;
                    case "double":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "˫����";
                        break;
                    case "float":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "short":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "boolean":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.get{1}()) === false)",
                         objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "Date":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.get{1}()) === false)",
                         objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.PropertyName(),
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
                strBuilder.AppendFormat("\r\n throw String.format(\"(errid:{7})�ֶ�[{2}({3})|{0}({4})]��ֵ:[{{0}}], �Ƿ���Ӧ��Ϊ{8}!(cls{3}BL:{9})\", pobj{3}EN.{4});",
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
        private string inGen_CheckNull4Field(clsPrjTabFldENEx objField, string strErrId, string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();

            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");
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
                strBuilder.AppendFormat("\r\n throw \"(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}BL:{4})\";",
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
                if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                {
                    strBuilder.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.toString()  ===  \"0\" ", strPrivPropNameWithObjectName);
                }
                strBuilder.Append(")");
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n throw \"(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}BL:{4})\";",
                            objField.ColCaption,
                            objPrjTabENEx.TabCnName,
                            strErrId,
                            objPrjTabENEx.TabName,
                            strFunctionName);
                strBuilder.Append("\r\n}");
            }

            return strBuilder.ToString();
        }
        private string inGen_CheckFieldLength(string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName = string.Format(strFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.Append("\r\n//����ֶγ��ȣ� ���ַ����ֶγ��ȳ����涨�ĳ��ȣ����Ƿ���");


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���

                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + objPrjTabENEx.TabName + "EN");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                  && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                  && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw(String.format(\"(errid:{7})�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}(cls{3}BL:{8})\", pobj{3}EN.{4}));",
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
                        strBuilder.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && GetStrLen({0}) > {1})",
                             strPrivPropNameWithObjectName,
                              objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw String.format(\"(errid:{7})�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}(cls{3}BL:{8})\", pobj{3}EN.{4});",
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


        private string inGen_CheckFieldForeighKey(string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();

            //string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.Append("\r\n//�������� ��Ϊ���Ӧ�ú��������ֶγ�����һ���ģ� ����һ�������Ƿ���");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + objPrjTabENEx.TabName + "EN");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty({0})  ==  false && GetStrLen({0}) != {1})",
                             strPrivPropNameWithObjectName4Get,
                              objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw \"(errid:{3})�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!(cls{4}BL:CheckPropertyNew)\";",
                              objField.ColCaption,
                              objField.ObjFieldTabENEx.FldLength,
                              objPrjTabENEx.TabCnName,
                              strErrId,
                              objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty({0})  ==  false && GetStrLen({0}) !=  {1})",
                            strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw \"(errid:{3})�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!(cls{4}BL:CheckPropertyNew)\";",
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
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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
                Type t = typeof(BusinessLogicEx4JavaScript);
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
            this.ClsName = string.Format("cls{0}BLEx", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
