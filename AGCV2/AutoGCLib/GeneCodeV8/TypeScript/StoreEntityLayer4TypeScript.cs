using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;

using AGC.Entity;


using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.file;
using com.taishsoft.commexception;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using AgcCommBase;

namespace AutoGCLib
{

    class StoreEntityLayer4TypeScript : clsGeneCodeBase, IImportClass
    {
        //protected CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        //public string ClsName;


        #region ���캯��

        public StoreEntityLayer4TypeScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public StoreEntityLayer4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {

            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        #endregion


        /// <summary>
        /// ����Entity�����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                                  ThisTabName4GC, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                  ThisTabName4GC, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = "cls" + ThisTabName4GC;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".ts";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            //string strIsShare = objPrjTabENEx.IsShare == true ? "_1Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".ts";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));


                strCodeForCs.Append("\r\n /**");

                strCodeForCs.AppendFormat("\r\n * {0}({1})", objPrjTabENEx.TabCnName, ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                //strCodeForCs.AppendFormat("\r\n" + "/// <reference path=\"../../PubFun/clsGeneralTab.ts\" />");
                StringBuilder sbImport = new StringBuilder();
                //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
                //{
                //    sbImport.Append("\r\n" + "import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';");
                //}
                //else
                //{
                //    sbImport.Append("\r\n" + "import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';");
                //}
                if (objPrjTabENEx.ApplicationTypeId == (int)enumApplicationType.VueAppInCore_TS_30)
                {
                    sbImport = sbImport.Replace(".js", "");
                    sbImport = sbImport.Replace("../../PubFun", "@/ts/PubFun");
                }
                strCodeForCs.AppendLine(sbImport.ToString());
                strCodeForCs.AppendFormat("\r\n" + "export class  {0} ", ThisClsName4StoreEN);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "[x: string]: any;//��������");
                //˽��������-----�����Թ���

                strCodeForCs.AppendFormat("\r\n" + "public static _CurrTabName= \"{0}\"; //��ǰ����,�������صı���", ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n" + "public static _KeyFldName= \"{0}\"; //��ǰ���еĹؼ�������,�������صı��йؼ�����", objPrjTabENEx.KeyFldNameLstStr);
                //������������صĳ�������

                //������������صĴ���
                strCodeForCs.AppendFormat("\r\n" + "public static mintAttributeCount = {0};",
                objPrjTabENEx.arrFldSet.Count);
                strTemp = "";
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp == "")
                    {
                        strTemp += "\"" + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase) + "\"";
                    }
                    else
                    {
                        strTemp += ", \"" + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase) + "\"";
                    }
                }

                strCodeForCs.AppendFormat("\r\n" + "public static AttributeName = [{0}];",
                strTemp);

                strCodeForCs.Append("\r\n" + "//���������Ա���");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                //strCodeForCs.Append("\r\n" + "this.init();");
                strCodeForCs.Append("\r\n" + "}");



                //   clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId);
                //   var arrCodeTypeCache = clsCodeTypeBL.GetObjLstCache();
                //   string strCodeTypeENName_Sim = objCodeType.CodeTypeENName + "_Sim";
                //   clsCodeTypeEN objCodeType_Sim = arrCodeTypeCache.Find(x => x.ProgLangTypeId == objCodeType.ProgLangTypeId && x.CodeTypeENName == strCodeTypeENName_Sim);
                //   if (objCodeType_Sim != null)
                //   {
                //       IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sim =
                //clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                //            objPrjTabENEx.LangType, objCodeType_Sim.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                //  .OrderBy(x => x.OrderNum);

                //       strCodeForCs.Append("\r\n /**");
                //       strCodeForCs.AppendFormat("\r\n * {0}({1})", objPrjTabENEx.TabCnName, ThisTabName4GC);
                //       strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                //       strCodeForCs.Append("\r\n **/");
                //       strCodeForCs.AppendFormat("\r\n" + "export class  {0}_Sim", objPrjTabENEx.ClsName);
                //       strCodeForCs.Append("\r\n" + "{");
                //       strCodeForCs.Append("\r\n" + "[x: string]: any;//��������");
                //       strCodeForCs.Append("\r\n" + "//���������Ա���");

                //       //�������еĺ���

                //       foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Sim)
                //       {
                //           strFuncName = objvFunction4GeneCodeEN.FuncName;
                //           clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                //           strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                //           if (string.IsNullOrEmpty(strTemp) == false)
                //           {
                //               strCodeForCs.Append("\r\n" + strTemp);
                //           }
                //       }
                //       strCodeForCs.Append("\r\n" + "public sfUpdFldSetStr = \"\";     //ר�����ڼ�¼ĳ�ֶ������Ƿ��޸�");
                //       strCodeForCs.Append("\r\n" + "public sfFldComparisonOp = \"\";     //ר�����ڼ�¼��������ĳ�ֶεıȽ������");
                //       strCodeForCs.Append("\r\n" + "}");
                //   }

                strTemp = A_GeneFuncCodeByFuncName("Gen_EN_GeneEnumConstList");
                strCodeForCs.Append(strTemp);
                //objvFunction4GeneCodeEN21 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4BL_GeneEnumConstList4Field");

                strTemp = A_GeneFuncCodeByFuncName("Gen_EN_GeneEnumConstList4Field");
                strCodeForCs.Append(strTemp);

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);

            }
            return strCodeForCs.ToString();
        }

        public string Gen_EN_GeneEnumConstList()
        {
            string strKeyFieldName = "";
            string strNamedFieldName = "";
            string strEnglishNameFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strKeyFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == enumFieldType.NameField_03)
                {
                    strNamedFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == enumFieldType.EnglishNameFIeld_05)
                {
                    strEnglishNameFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (string.IsNullOrEmpty(strKeyFieldName) == true) return "";
            if (string.IsNullOrEmpty(strNamedFieldName) == true) return "";
            if (string.IsNullOrEmpty(strEnglishNameFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڻ�ȡ�����ݣ�GetDataTableByTabName��ʱ����!������{0},������Ϣ��{1}��({2})",
                    ThisTabName4GC, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ݱ���������enum�б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n export class enum{0}",
                       ThisTabName4GC,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    if (objRow[strEnglishNameFieldName].ToString() == "") continue;
                    strCodeForCs.Append("\r\n /**");
                    strCodeForCs.AppendFormat("\r\n * {0}", objRow[strNamedFieldName]);
                    strCodeForCs.Append("\r\n **/");
                    strCodeForCs.AppendFormat("\r\n" + "static readonly {0}_{1} = \"{1}\";",
                        objRow[strEnglishNameFieldName].ToString(), objRow[strKeyFieldName]);
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n export enum enum{0} ",
                ThisTabName4GC,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_{1} = {1}, //{2}",
                        objRow[strEnglishNameFieldName].ToString(),
                        objRow[strKeyFieldName],
                        objRow[strNamedFieldName]);
                }
            }
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_EN_GeneEnumConstList4Field()
        {

            string strStrConstFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.FieldTypeId == "07")
                {
                    strStrConstFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }

            if (string.IsNullOrEmpty(strStrConstFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(ThisTabName4GC, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڻ�ȡ�����ݣ�GetDataTableByTabName��ʱ����!������{0},������Ϣ��{1}��({2})",
                    ThisTabName4GC, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strCodeForCs = new StringBuilder();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") continue;
                if (objField.FieldTypeId != "07") continue;
                //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ���ݱ��ֶ���������enum�б�-�ֶ�����[{0}]", objField.ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");

                strCodeForCs.AppendFormat("\r\n export class enum{0}_{1}",
                       ThisTabName4GC,
                        objField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n{");
                List<string> arrExistItem = new List<string>();
                foreach (DataRow objRow in objDT.Rows)
                {
                    string strFieldValue = objRow[objField.ObjFieldTabENEx.FldName].ToString();
                    if (arrExistItem.Contains(strFieldValue)) continue;
                    arrExistItem.Add(strFieldValue);
                    strCodeForCs.Append("\r\n /**");
                    strCodeForCs.AppendFormat("\r\n * {0}", strFieldValue);
                    strCodeForCs.Append("\r\n **/");
                    strCodeForCs.AppendFormat("\r\n" + "static readonly con{0} = \"{0}\";",
                        strFieldValue);
                }

                strCodeForCs.Append("\r\n}");
            }
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }


        public string A_GeneFuncCodeByFuncName(string strFuncName)
        {

            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBLEx.GetObjByFuncNameCache(strFuncName);
            try
            {
                string strCode = "";
                Type t = typeof(StoreEntityLayer4TypeScript);
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
                        strCode = (string)mt.Invoke(this, new object[] { objFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string Gen_SimEN_ClsProperty()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///����������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n/**");
                strCodeForCs.AppendFormat("\r\n * {4}(˵��:{3};�ֶ�����:{0};�ֶγ���:{1};�Ƿ�ɿ�:{2})",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength,
                    objField.ObjFieldTabENEx.IsNull,
                    objField.ObjFieldTabENEx.MemoInTab,
                     objField.ColCaption);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n*/");
                strCodeForCs.AppendFormat("\r\n public {1} = {2};",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                    objField.ObjFieldTabENEx.InitValue_TypeScript);

                strCodeForCs.Append("\r\n");
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ɱ��ֶ�������
        /// </summary>
        /// <returns></returns>
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
                Type t = typeof(StoreEntityLayer4TypeScript);
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
                    Re_objFunction4Code.FuncName4Code = this.Re_objFunction4Code.FuncName4Code;
                    Re_objFunction4Code.FuncCHName4Code = this.Re_objFunction4Code.FuncCHName4Code;

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
            this.ClsName = string.Format("{0}", ThisClsName4EN);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string Gen_EN_ClassConstructor1()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("constructor() ",
           "");

            Re_objFunction4Code.FuncCHName4Code = "���캯��.";

            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ���캯��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n constructor()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n super();");

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string Gen_EN_ClsProperty()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///����������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //strCodeForCs.AppendFormat("\r\n/**");
                //strCodeForCs.AppendFormat("\r\n * {4}(˵��:{3};�ֶ�����:{0};�ֶγ���:{1};�Ƿ�ɿ�:{2})",
                //    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                //    objField.ObjFieldTabENEx.FldLength,
                //    objField.ObjFieldTabENEx.IsNull,
                //    objField.ObjFieldTabENEx.MemoInTab,
                //     objField.ColCaption);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.AppendFormat("\r\n*/");
                //strCodeForCs.AppendFormat("\r\n public get {1} ()",
                //    objField.JavaType,
                //    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                //strCodeForCs.Append("\r\n{");
                //strCodeForCs.AppendFormat("\r\nreturn this.{0};",
                //     objField.ObjFieldTabENEx.PrivPropName);
                //strCodeForCs.Append("\r\n}");
                strCodeForCs.AppendFormat("\r\n/**");
                strCodeForCs.AppendFormat("\r\n * {4}(˵��:{3};�ֶ�����:{0};�ֶγ���:{1};�Ƿ�ɿ�:{2})",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength,
                    objField.ObjFieldTabENEx.IsNull,
                    objField.ObjFieldTabENEx.MemoInTab,
                     objField.ColCaption);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n*/");
                strCodeForCs.AppendFormat("\r\n public Set{0} (value: {1})",
                        objField.ObjFieldTabENEx.FldName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\nif (value  != undefined)");
                strCodeForCs.Append("\r\n{");
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "String")
                {
                    //strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                    //strCodeForCs.Append("\r\n{");
                    //if (bolIsSimVersion  ==  false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                    //}
                    //strCodeForCs.Append("\r\n}");
                    //strCodeForCs.AppendFormat("\r\nelse");
                    //strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                         objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                    strCodeForCs.AppendFormat("\r\n    this.hmProperty[\"{0}\"] = true;",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                    //strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                            objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                    strCodeForCs.AppendFormat("\r\n    this.hmProperty[\"{0}\"] = true;",
                   objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                }
                strCodeForCs.Append("\r\n   this.sfUpdFldSetStr = this.updFldString;");
                strCodeForCs.Append("\r\n}");
                strCodeForCs.Append("\r\n}");
                strCodeForCs.Append("\r\n");
            }
            return strCodeForCs.ToString();
        }
        public string Gen_EN_SetCondFldValue()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void",
            "");

            Re_objFunction4Code.FuncCHName4Code = "���������ֶ�ֵ";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * ���������ֶ�ֵ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param strFldName:�ֶ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @param strFldValue:�ֶ�ֵ", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @param strComparisonOp:�Ƚϲ�������", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns ���ݹؼ��ֻ�ȡ������");
            strCodeForCs.AppendFormat("\r\n **/");
            strCodeForCs.Append("\r\n" + "public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {                ");
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetCondFldValue.name;");
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "this.SetFldValue(strFldName, strFldValue);");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.dicFldComparisonOp[strFldName] = strComparisonOp;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.dicFldComparisonOp[strFldName] = strComparisonOp;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "this.sfFldComparisonOp = JSON.stringify(this.dicFldComparisonOp);");
            strCodeForCs.Append("\r\n" + "}");
            ///����������
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ���˽�б���,���������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string Gen_EN_ClsPrivateVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ö�����˽������.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n*/");
            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));
            }

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����ֶ����Ƴ���,�������������Ƶ�����
        /// </summary>
        /// <returns></returns>
        public string Gen_StoreEN_PropertyNameConst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //���������������Ƴ���
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPropertyNameConst(objPrjTabENEx.LangType, objField, this.IsFstLcase, clsStackTrace.GetCurrClassFunction()));
            }

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public string Gen_StoreEN_GetFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * �����ֶ�����ȡ������ĳ�ֶε�ֵ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param strFldName:�ֶ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �ֶ�ֵ");
            strCodeForCs.AppendFormat("\r\n*/");

            //��������,�ַ�������
            strCodeForCs.Append("\r\npublic GetFldValue(strFldName: string):any");
            strCodeForCs.Append("\r\n{");
            //            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetFldValue\";", ThisTabName4GC,
            //objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");
            strCodeForCs.Append("\r\n" + "switch (strFldName)");
            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }

                strCodeForCs.AppendFormat("\r\ncase {0}.con_{1}:",
                    ThisClsName4StoreEN,
                objField.ObjFieldTabENEx.FldName);

                strCodeForCs.AppendFormat("\r\nreturn this.{0};",
                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

            }
          
            //strCodeForCs.Append("\r\ncase \"sfFldComparisonOp\":");
            //strCodeForCs.AppendFormat("\r\n" + "return this.sfFldComparisonOp;");

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = `�ֶ���:[${{strFldName}}]�ڱ����:[{0}]�в�����!`;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "return \"\";");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");

            return strCodeForCs.ToString();
        }

        public string Gen_EN_SetFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ö�����ĳ�ֶ�����ֵ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param strFldName:�ֶ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @param strValue:�ֶ�ֵ", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �ֶ�ֵ");
            strCodeForCs.AppendFormat("\r\n*/");

            //��������,�ַ�������
            strCodeForCs.Append("\r\npublic SetFldValue(strFldName: string, strValue:string)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"SetFldValue\";", ThisTabName4GC,
objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");
            strCodeForCs.Append("\r\n" + "switch (strFldName)");
            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }

                strCodeForCs.AppendFormat("\r\ncase {0}.con_{1}:",
                    ThisClsName4EN,
                objField.ObjFieldTabENEx.FldName);
                switch (objField.ObjFieldTabENEx.TypeScriptType)
                {
                    case "string":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = strValue;",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        break;
                    case "number":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = Number(strValue);",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        break;
                    case "boolean":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = Boolean(strValue);",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        break;
                    case "any":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = strValue;",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                        break;
                    case "Date":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = new Date(Date.parse(strValue));",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                        break;

                    default:
                        var strMsg = string.Format("TypeScript:[{0}]�ں�����û�б�����(in {1})", objField.ObjFieldTabENEx.TypeScriptType, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                        //break;
                }
                if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
                {
                    strCodeForCs.AppendFormat("\r\n    this.hmProperty[\"{0}\"] = true;",
           objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                }
                strCodeForCs.Append("\r\n" + "break;");

            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.Append("\r\ncase \"sfUpdFldSetStr\":");
                strCodeForCs.AppendFormat("\r\n" + "this.sfUpdFldSetStr = strValue;");
                strCodeForCs.Append("\r\n" + "break;");
            }
            strCodeForCs.Append("\r\ncase \"sfFldComparisonOp\":");
            strCodeForCs.AppendFormat("\r\n" + "this.sfFldComparisonOp = strValue;");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = `�ֶ���:[${{strFldName}}]�ڱ����:[{0}]�в�����!(in ${{this.constructor.name}}.${{strThisFuncName}})`;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ���˽�б���,���������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string Gen_StoreEN_ClsPublicVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ö����й�������.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n*/");
            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPublicProperty(objPrjTabENEx.LangType, objField, this.IsFstLcase, this, ""));
            }
            //strCodeForCs.Append("\r\n" + "public sfUpdFldSetStr = \"\";     //ר�����ڼ�¼ĳ�ֶ������Ƿ��޸�");
            //strCodeForCs.Append("\r\n" + "public sfFldComparisonOp = \"\";     //ר�����ڼ�¼��������ĳ�ֶεıȽ������");
            return strCodeForCs.ToString();
        }

        //public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        //{
        //    return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, objViewInfoENEx.PrjId);
        //}
    }
}
