using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    partial class WA_Access4TypeScript : clsGeneCodeBase, IImportClass
    {
        //private bool bolIsHasFuncMap4Path = false;
        private string strIsShare_GC = "";
        //public string strBaseUrl = "../../";
        #region ���캯��

        public WA_Access4TypeScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strBaseUrl = "../../TS";
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_Access4TypeScript(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strBaseUrl = "../../TS";
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_Access4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strBaseUrl = "../../TS";
            this.arrImportClass = new List<ImportClass>();
        }
        #endregion
        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            //if (objPrjTabENEx.IsShare) strIsShare_GC = "_1Share";
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
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objPrjTabENEx.ClsName = ThisClsName4WApi;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".ts";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".ts";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ
                List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                   clsvFunction4GeneCodeBLEx.GetObjLstByPrjTabEx(objPrjTabENEx, (int)enumApplicationType.SpaAppInCore_TS_18, this.CmPrjId);
                if (arrvFunction4GeneCodeObjLst.Find(x => x.FuncName.Contains("FuncMap4Path")) != null)
                {
                    //bolIsHasFuncMap4Path = true;
                }

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    objvFunction4GeneCodeEN.CodeText = strTemp;
                }
                clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId);
                var arrCodeTypeCache = clsCodeTypeBL.GetObjLstCache();
                string strCodeTypeENName_Business = "BusinessLogic";
                clsCodeTypeEN objCodeType_Business = arrCodeTypeCache.Find(x => x.ProgLangTypeId == objCodeType.ProgLangTypeId && x.CodeTypeENName == strCodeTypeENName_Business);
                if (objCodeType_Business != null)
                {
                    IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Business =
             clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                         objPrjTabENEx.LangType, objCodeType_Business.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
               .OrderBy(x => x.OrderNum);

                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Business)
                    {
                        clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                        strFuncName = objvFunction4GeneCodeEN.FuncName;

                        try
                        {
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                            objvFunction4GeneCodeEN.CodeText = strTemp;
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.", strFuncName, objException.Message);
                            throw new Exception(strMsg);
                        }
                        //if (string.IsNullOrEmpty(strTemp) == false)
                        //{
                        //    strCodeForCs.Append("\r\n" + strTemp);
                        //}

                    }

                }
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4TypeScript(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n/**");
                strCodeForCs.AppendFormat("\r\n * {0}({1})", objPrjTabENEx.TabCnName, ThisTabName4GC);

                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + " **/");

                //strCodeForCs.Append("\r\n" + "import $ from \"jquery\";");
                strCodeForCs.Append("\r\n" + "import axios from \"axios\";");
                if (objPrjTabENEx.ApplicationTypeId == (int)enumApplicationType.VueAppInCore_TS_30)
                {
                    strCodeForCs.Append("\r\n" + "import { ACCESS_TOKEN_KEY } from '@/enums/cacheEnum';");
                    strCodeForCs.Append("\r\n" + "import { Storage } from '@/utils/Storage';");
                }
                //strCodeForCs.Append("\r\n" + "//import * as QQ from \"q\";");

                GetImportClassLst(objFuncModule);
                if (objPrjTabENEx.ApplicationTypeId == (int)enumApplicationType.VueAppInCore_TS_30)
                {
                    foreach (var objInFor in arrImportClass)
                    {
                        objInFor.ClsName = objInFor.ClsName;
                        objInFor.FilePath = objInFor.FilePath.Replace(".js", "")
                  .Replace("../../TS/", "@/ts/")
                  .Replace("../TS/", "@/ts/")
.Replace("../../PubFun", "@/ts/PubFun")
.Replace("../../PubConfig", "@/ts/PubConfig")
.Replace("../../L0Entity", "@/ts/L0Entity")
.Replace("../../L3ForWApi", "@/ts/L3ForWApi")
.Replace("../PubFun", "@/ts/PubFun")
.Replace("../PubConfig", "@/ts/PubConfig")
.Replace("../L0Entity", "@/ts/L0Entity")
                    .Replace("../L3ForWApi", "@/ts/L3ForWApi");
                    }
                }
                var arrImportClass_RemoveDup = clsPubFun4GC.ImportClass_RemoveDup(arrImportClass);


                StringBuilder sbImport = new StringBuilder();
                foreach (var objInFor in arrImportClass_RemoveDup)
                {
                    sbImport.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClsName,
                        objInFor.FilePath);
                }

                strCodeForCs.AppendLine(sbImport.ToString());

                //strCodeForCs.AppendFormat("\r\n" + "export class  cls{0}WApi ",
                //  ThisTabName4GC);
                //strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + " export const " + this.controllerName + " = \"{0}Api\";",
                    ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n" + " export const " + this.constructorName + " = \"{0}\";",
    clsString.FstLcaseS(ThisTabName4GC));

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }

                if (objCodeType_Business != null)
                {
                    IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Business =
             clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                         objPrjTabENEx.LangType, objCodeType_Business.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
               .OrderBy(x => x.OrderNum);



                    //strCodeForCs.AppendFormat("\r\n" + "export class  cls{0}BL", ThisTabName4GC);
                    //strCodeForCs.Append("\r\n" + "{");

                    //˽��������-----�����Թ���
                    //strCodeForCs.Append("\r\n/**");
                    //strCodeForCs.Append("\r\n * ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                    //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    //strCodeForCs.Append("\r\n*/");
                    //strCodeForCs.AppendFormat("\r\n" + "private arr{0}ObjLstCache = new Array<{0}>();",
                    //       ThisTabName4GC);

                    //strCodeForCs.AppendFormat("\r\n/**");
                    //strCodeForCs.AppendFormat("\r\n * �ӻ����в���ʧ�ܵĴ���");
                    //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    //strCodeForCs.AppendFormat("\r\n*/");
                    //strCodeForCs.AppendFormat("\r\n" + "private intFindFailCount = 0;");

                    //�������еĺ���

                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Business)
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
                        //try
                        //{
                        //    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        //}
                        //catch (Exception objException)
                        //{
                        //    string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.", strFuncName, objException.Message);
                        //    throw new Exception(strMsg);
                        //}
                        strTemp = objvFunction4GeneCodeEN.CodeText;
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }

                    }

                    //strCodeForCs.Append("\r\n" + "}");
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

        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {
            //List<ImportClass> arrImportClass = new List<ImportClass>();
            //arrImportClass.Add(new ImportClass
            //{
            //    ClsName = string.Format("cls{0}EN", ThisTabName4GC),
            //    FilePath = string.Format("../../L0Entity/{0}/cls{1}ENEx.js", objFuncModule.FuncModuleEnName4GC()
            //   ThisTabName4GC)
            //});

            //          arrImportClass.Add(new ImportClass
            //          {
            //              ClsName = string.Format("enumComparisonOp", ThisTabName4GC),
            //              FilePath = string.Format("../../PubFun/enumComparisonOp.js", objFuncModule.FuncModuleEnName4GC()
            //ThisTabName4GC)
            //          });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("{0}", ThisClsName4EN),
                FilePath = string.Format("../../L0Entity/{0}{2}/cls{1}EN.js", objFuncModule.FuncModuleEnName4GC(),
                   ThisTabName4GC, strIsShare_GC)
            });
            //arrImportClass.Add(new ImportClass
            //{
            //    ClsName = string.Format("cls{0}EN_Sim", ThisTabName4GC),
            //    FilePath = string.Format("../../L0Entity/{0}/cls{1}EN.js", objFuncModule.FuncModuleEnName4GC()
            //     ThisTabName4GC)
            //});

            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format("GetExceptionStr, myShowErrorMsg, ObjectAssign", ThisTabName4GC),
                    FilePath = string.Format("../../PubFun/clsCommFunc4Web.js")
                });
            }
            else
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format("GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign", ThisTabName4GC),
                    FilePath = string.Format("../../PubFun/clsCommFunc4Web.js")
                });
            }
            //          arrImportClass.Add(new ImportClass
            //          {
            //              ClsName = string.Format("clsPubSessionStorage", ThisTabName4GC),
            //              FilePath = string.Format("../../PubFun/clsPubSessionStorage.js", objFuncModule.FuncModuleEnName4GC()
            //ThisTabName4GC)
            //          });


            //           arrImportClass.Add(new ImportClass
            //           {
            //               ClsName = string.Format("Dictionary", ThisTabName4GC),
            //               FilePath = string.Format("../../PubFun/tzDictionary.js")
            //           });
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("clsSysPara4WebApi, {0}", objProjectsENEx.GetWebApiFunc),
                FilePath = string.Format("../../PubConfig/clsSysPara4WebApi.js")
            });
            //           arrImportClass.Add(new ImportClass
            //           {
            //               ClsName = string.Format("clsOrderByData", ThisTabName4GC),
            //               FilePath = string.Format("../../PubFun/clsOrderByData.js")
            //           });
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("stuTopPara", ThisTabName4GC),
                FilePath = string.Format("../../PubFun/stuTopPara.js")
            });
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("stuRangePara", ThisTabName4GC),
                FilePath = string.Format("../../PubFun/stuRangePara.js")
            });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("stuPagerPara", ThisTabName4GC),
                FilePath = string.Format("../../PubFun/stuPagerPara.js")
            });
            //           arrImportClass.Add(new ImportClass
            //           {
            //               ClsName = string.Format("stuDnPathPara", ThisTabName4GC),
            //               FilePath = string.Format("../../PubFun/stuDnPathPara.js")
            //           });
            //arrImportClass.Add(new ImportClass
            //{
            //    ClsName = string.Format("CacheHelper", ThisTabName4GC),
            //    FilePath = string.Format("../../PubFun/CacheHelper.js")
            //});
            //           arrImportClass.Add(new ImportClass
            //           {
            //               ClsName = string.Format("myShowErrorMsg, GetStrLen", ThisTabName4GC),
            //               FilePath = string.Format("../../PubFun/tzPubFun.js")
            //           });
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format("tzDataType", ThisTabName4GC),
                    FilePath = string.Format("../../PubFun/clsString.js")
                });
            }
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("Format, IsNullOrEmpty", ThisTabName4GC),
                FilePath = string.Format("../../PubFun/clsString.js")
            });
            if (objPrjTabENEx.IsUseCache_TS() == true)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format("clsDateTime", ThisTabName4GC),
                    FilePath = string.Format("../../PubFun/clsDateTime.js")
                });
            }
            arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
            return arrImportClass;
        }


        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string A_GenWebApiTransCode_Ts_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "cls" + objWebSrvClassENEx.ClsName + "WS4SD";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".ts";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".ts";
            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n/**");
                strCodeForCs.AppendFormat("\r\n * {0}({1})", objWebSrvClassENEx.ClsName, objWebSrvClassENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "/// <reference path=\"../PubFun/tzDictionary.ts\" />");
                strCodeForCs.Append("\r\n" + "/// <reference path=\"../PubFun/tzResponseData.ts\" />");
                strCodeForCs.Append("\r\n" + "/// <reference path=\"../PubFun/tzStringFormat.ts\" />");
                strCodeForCs.Append("\r\n" + "/// <reference path=\"../PubFun/tzGetXmlHttp.ts\" />");
                strCodeForCs.Append("\r\n" + "/// <reference path=\"../PubFun/jsPubVar.ts\" />");
                strCodeForCs.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//�ú���������/js/PubFun/jsPubFun.ts�ļ���");

                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.ts\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzResponseData.ts\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzGetXmlHttp.ts\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.ts\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.ts\");");

                //strCodeForCs.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.ts\");",
                //    objWebSrvClassENEx.ClsName,
                //    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());

                strCodeForCs.Append("\r\n" + "const ResponseData;");
                strCodeForCs.Append("\r\n" + "const ReCallFunc = null;");

                strCodeForCs.AppendFormat("\r\n" + "const cls{0}WS4SD = function()",
                  objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const Param;");
                strCodeForCs.Append("\r\n" + "const NameSpace = \"http://tempuri.org/\";");
                strCodeForCs.Append("\r\n" + "const MethodName = \"\";");
                strCodeForCs.Append("\r\n" + "const WEB_SERVICE_URL = \"\";");
                strCodeForCs.Append("\r\n" + "const soapAction = \"\";");

                //strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN;",
                //      objWebSrvClassENEx.ClsName);
                //˽��������-----�����Թ���

                //˽��������-----�����Թ���

                strCodeForCs.Append("\r\n" + "this.init = function()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.Param = new Dictionary();");
                //strCodeForCs.AppendFormat("\r\n" + "this.obj{0}EN = new cls{0}EN();",
                //     objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "ResponseData = new tzResponseData();",
                    objWebSrvClassENEx.ClsName);

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "this.init = function(strMethod, mapParam, pobj{0}EN, pReCallFunc)",
                  objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "Param = new Dictionary();");
                //strCodeForCs.Append("\r\n" + "obj{0}EN = new cls{0}EN();");
                //strCodeForCs.Append("\r\n" + "this.currentElementValue = \"\";");
                //strCodeForCs.AppendFormat("\r\n" + "this.obj{0}EN = pobj{0}EN;",
                //objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "ReCallFunc = pReCallFunc;");
                strCodeForCs.AppendFormat("\r\n" + "ResponseData = new tzResponseData();",
                     objWebSrvClassENEx.ClsName);

                strCodeForCs.Append("\r\n" + "this.MethodName = strMethod;");
                strCodeForCs.Append("\r\n" + "this.Param = mapParam;");
                strCodeForCs.Append("\r\n" + "if (this.Param.length() === 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.Param = new Dictionary();");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "this.WEB_SERVICE_URL = `${CurrIPAddressAndPort}/${CurrPrx}/{3}/{0}.asmx\");",
                  objWebSrvClassENEx.ClsName, "{", "}", objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());

                strCodeForCs.Append("\r\n" + "}");
                //�������еĺ���

                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_main_Ts_SelfDefWs");
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strCodeForCs.Append("\r\n" + strTemp);

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WA_Ts_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú���: [{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú���: [{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_CallWebApi_Ts_SelfDefWs");
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strCodeForCs.Append("\r\n" + strTemp);

                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_getReturnValue_TypeScript");
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strCodeForCs.Append("\r\n" + strTemp);


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
        public string A_GeneFuncCode_TypeScript1(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            if (strFuncName.IndexOf("Async") > 0)
            {
                return A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
            }
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
        public string Gen_4WA_Ts_AddNewRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����WebApi����Ӽ�¼,���ݴ���ʹ��JSON��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.AppendFormat("\r\n * @param obj{0}EN:��Ҫ��ӵĶ���", ThisTabName4GC);
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "AddNewRecord (obj{0}EN: cls{0}EN, cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"AddNewRecord\";", ThisTabName4GC,
      objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "v1ar strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"AddNewRecord\";",
              ThisTabName4GC,
              objKeyField.FldName);
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
     && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
     && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType != "bool"
     && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType != "int"
      && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType != "long")
            {

                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} === null || obj{0}EN.{1} === 0)",
                      ThisTabName4GC,
                   objKeyField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} === null || obj{0}EN.{1} === \"\")",
                         ThisTabName4GC,
                      objKeyField.FldName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"��Ҫ�Ķ���Ĺؼ���Ϊ��,�������!\";");
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");
            }
            //strCodeForCs.AppendFormat("\r\n" + "const strJSON = {0}GetJSONStrByObj(obj{0}EN);",
            //  ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN);",
           ThisTabName4GC);
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
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN, config);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");
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
        public string Gen_4WA_Ts_UpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����WebApi���޸ļ�¼,���ݴ���ʹ��JSON��");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.AppendFormat("\r\n * @param obj{0}EN:��Ҫ��ӵĶ���", ThisTabName4GC);
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡ�޸��Ƿ�ɹ���");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "UpdateRecord (obj{0}EN: cls{0}EN, cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"UpdateRecord\";", ThisTabName4GC,
      objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "const 1strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"UpdateRecord\";",
              ThisTabName4GC,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + " if (obj{0}EN.sfUpdFldSetStr === undefined || obj{0}EN.sfUpdFldSetStr === null || obj{0}EN.sfUpdFldSetStr === \"\")",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����(�ؼ���: {{0}})�ġ��޸��ֶμ���Ϊ��,�����޸�!\", obj{0}EN.{1});",
                ThisTabName4GC, objKeyField.FldName, "{", "}");
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
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN, config);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");

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
        public string Gen_4WA_Ts_EditRecordEx()
        {
            IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = null;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                if (objInFor.ConstraintTypeId != enumConstraintType.Uniqueness_01) continue;
                arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

            }
            if (arrObjLst_Flds == null || arrObjLst_Flds.Count() == 0) return "";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����WebApi���༭��¼�����ھ��޸ģ������ھ���ӣ�,���ݴ���ʹ��JSON��");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.AppendFormat("\r\n * @param obj{0}EN:��Ҫ�༭�Ķ���", ThisTabName4GC);
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡ�޸��Ƿ�ɹ���");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "EditRecordEx (obj{0}EN: cls{0}EN, cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"EditRecordEx\";", ThisTabName4GC,
      objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "const 1strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"EditRecordEx\";",
              ThisTabName4GC,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + " if (obj{0}EN.sfUpdFldSetStr === undefined || obj{0}EN.sfUpdFldSetStr === null || obj{0}EN.sfUpdFldSetStr === \"\")",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����(�ؼ���: {{0}})�ġ��޸��ֶμ���Ϊ��,�����޸�!\", obj{0}EN.{1});",
                ThisTabName4GC, objKeyField.PropertyName(this.IsFstLcase), "{", "}");
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
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN, config);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");

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
        public string Gen_4WA_Ts_DelRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����WebApi��ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.AppendFormat("\r\n * @param {0}:�ؼ���", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡɾ���Ľ��");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "DelRecord({0}: {1}, cb: (json: any) => void, errorCb: (json: any) => void) ",
                            objKeyField.PrivFuncName, KeyDataType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"DelRecord\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"DelRecord\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");

            //strCodeForCs.Append("\r\n" + "const mapParam: Dictionary = new Dictionary();");
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {0});", objKeyField.PrivFuncName);
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"����: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.delete(strUrl,");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "params: {{ \"Id\": {0}, }}", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_IsExistRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����������ȡ�Ƿ������Ӧ�ļ�¼��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns �Ƿ���ڼ�¼��");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "IsExistRecord(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"IsExistRecord\";", ThisTabName4GC,
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

            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetRecCountByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ȡĳһ�����ļ�¼��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡĳһ�����ļ�¼��");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetRecCountByCond(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetRecCountByCond\";", ThisTabName4GC,
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

            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjLst()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");

            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ�����б�");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLst(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLst\";", ThisTabName4GC,
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

            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetTopObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param strWhereCond:��������");
            strCodeForCs.Append("\r\n * @param intTopSize:������¼��");
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ�����б�");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetTopObjLst(strWhereCond: string, intTopSize: number, cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetTopObjLst\";", ThisTabName4GC,
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
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "\"intTopSize\": intTopSize,");
            strCodeForCs.Append("\r\n" + "\"strWhereCond\": strWhereCond,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");
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
        public string Gen_4WA_Ts_GetObjLstByPager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param intPageIndex:ҳ���");
            strCodeForCs.Append("\r\n * @param intPageSize:ÿҳ��¼��");
            strCodeForCs.Append("\r\n * @param strWhereCond:��������");
            strCodeForCs.Append("\r\n * @param strOrderBy:����ʽ");
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ��¼�����б�");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstByPager(intPageIndex: number, intPageSize: number, strWhereCond: string, strOrderBy = \"\", cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByPager\";", ThisTabName4GC,
      objKeyField.FldName);

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
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "\"intPageIndex\": intPageIndex,");
            strCodeForCs.Append("\r\n" + "\"intPageSize\": intPageSize,");
            strCodeForCs.Append("\r\n" + "\"strWhereCond\": strWhereCond,");
            strCodeForCs.Append("\r\n" + "\"strOrderBy\": strOrderBy,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");

            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");
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
        public string Gen_4WA_Ts_GetFirstObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ����");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetFirstObj(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetFirstObj\";", ThisTabName4GC,
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
            strCodeForCs.Append("\r\n" + "cb(data);");
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
        public string Gen_4WA_Ts_GetMaxStrId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ȡ������ؼ���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡ������ؼ���");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetMaxStrId(cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetMaxStrId\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetMaxStrId\";",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"����: strIdentityID =01\";");
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

            strCodeForCs.Append("\r\n" + "cb(data);");
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
        public string Gen_4WA_Ts_GetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param mapParam:�����б�");
            strCodeForCs.Append("\r\n * @returns ��ȡ��ǰ��ؼ���ֵ�����ֵ");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetMaxStrIdByPrefix(strPrefix: string) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetMaxStrIdByPrefix\";", ThisTabName4GC,
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
        public string Gen_4WA_Ts_CallWebApi()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ͨ�õĵ���WebApi����");
            strCodeForCs.AppendFormat("\r\n * mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param MethodName:����");
            strCodeForCs.Append("\r\n * @param mapParam:�����б�");
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n*/");
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
        public string Gen_4WA_CallWebApi_Ts_SelfDefWs()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ͨ�õĵ���WebApi����");
            //            strCodeForCs.AppendFormat("\r\n * mapParam����:{0} = \"01\"", objWebSrvClassENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param MethodName:����");
            strCodeForCs.Append("\r\n * @param mapParam:�����б�");
            strCodeForCs.Append("\r\n * @returns ��ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.Append("\r\n*/");
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
            strCodeForCs.Append("\r\n" + "const strTemp = `<${key}>${value}</${key}>`, , );");
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
        public string Gen_4WA_Ts_main()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * �̳�Runnable�����ʵ�ֵġ�run������");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n*/");
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
            strCodeForCs.AppendFormat("\r\n" + "this.AddNewRecordByJSON(this.Param, this.obj{0}EN);",
                ThisTabName4GC);
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
            strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecordByJSON(this.Param, this.obj{0}EN);",
                ThisTabName4GC);
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
        public string Gen_4WA_main_Ts_SelfDefWs()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * �̳�Runnable�����ʵ�ֵġ�run������");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n*/");
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
        public string Gen_4WA_Ts_start()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * �̳�Runnable�����ʵ�ֵġ�run������");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.Append("\r\n" + "this.start = function()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjByKeyId()
        {
            string strBy = objKeyField.FldName;
            if (objPrjTabENEx.arrKeyFldSet.Count > 1) strBy = "KeyLst";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ���ݹؼ��ֻ�ȡ��Ӧ�Ķ���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�ؼ���", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ����");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjBy{0} ({1}: {2}, cb: (json: any) => void, errorCb: (json: any) => void) ",
              strBy,
              objKeyField.PrivFuncName, KeyDataType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjBy{0}\";", strBy,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjBy{0}\";", strBy);
            string strFuncName = string.Format("GetObjBy{0}", strBy);

            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                var strTemp = clsPubFun4GC.Gc_CheckVarEmpty_Ts(objInFor.PrivFuncName, objInFor.TypeScriptType,
                    objInFor.ObjFieldTab0().DataTypeId,
              this.ClsName, strFuncName, objInFor.ObjFieldTab().FldLength, true, this, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + strTemp);
            }

            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},", objKeyField.FldName, objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");

            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");
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
        public string Gen_4WA_Ts_getReturnValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ȡ����ֵ����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n*/");

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
        public string Gen_4WA_Ts_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
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
            strCodeForCs.Append("\r\n/**");
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
            strCodeForCs.Append("\r\n*/");

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

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjByKeyIdCache()
        {

            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetObjByKeyId_Cache)}({objPrjTabENEx.KeyVarDefineLstStr_TS})";

            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ��ֻ�ȡ��ض���, �ӻ����л�ȡ.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjBy{thisTabProp_TS.ByInFuncName}Cache]����;(in {clsStackTrace.GetCurrClassFunction()} )";

            var objVarManage = new clsVarManage("TypeScript");
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                objVarManage.AddVariable(new clsVariable(objInFor.PrivFuncName, objInFor.TypeScriptType));
            }
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
            {
                objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.TypeScriptType));
            }
            if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == true)
            {
                objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName2, thisCacheClassify_TS.TypeScriptType2));
            }

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݹؼ��ֻ�ȡ��ض���, �ӻ����л�ȡ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�����Ĺؼ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns ����");
            strCodeForCs.AppendFormat("\r\n*/");

            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjByKeyId_Cache)}({objPrjTabENEx.KeyVarDefineLstStr_TS}, bolTryAsyncOnce = true) {{");

            }
            else
            {
                strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjByKeyId_Cache)}({objVarManage.ParaVarDefLstStr()}, bolTryAsyncOnce = true) {{");
            }
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjBy{0}Cache\";", thisTabProp_TS.ByInFuncName);

            string strFuncName = string.Format("GetObjBy{0}Cache", thisTabProp_TS.ByInFuncName);

            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                string strDataTypeId = objInFor.ObjFieldTab().ObjDataTypeAbbr1().DataTypeId;
                var strTemp = clsPubFun4GC.Gc_CheckVarEmpty_Ts(objInFor.PrivFuncName, objInFor.TypeScriptType,
                    objInFor.ObjFieldTab().DataTypeId,
                 this.ClsName, strFuncName, objInFor.ObjFieldTab().FldLength, strDataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + strTemp);
            }

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({clsPrjTabBLEx.Cache_ParaVarLstStr(objPrjTabENEx, "TypeScript")});");
            //strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null) 1return null;", ThisTabName4GC);

            //strCodeForCs.AppendFormat("\r\n" + "const obj = new cls{0}EN();", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            string strFilterCondition = clsPubFun4GC.GenFilterCondition("x", objPrjTabENEx, this.IsFstLcase);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}Sel = arr{0}ObjLstCache.filter(x => {1});",
                ThisTabName4GC, strFilterCondition);

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}: cls{0}EN;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Sel.length > 0)", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "obj{0} = arr{0}Sel[0];", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0};", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (bolTryAsyncOnce == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const obj{ThisTabName4GC}Const = await {thisWA_F(WA_F.GetObjByKeyId)}({thisTabProp_TS.KeyPrivVarNameLstStr});");
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Const != null)", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F(WA_F.ReFreshThisCache)}({clsPrjTabBLEx.Cache_ParaVarLstStr(objPrjTabENEx, "TypeScript")});");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}Const;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����:[{{0}}]. \\n���ݹؼ���:[{{1}}]��ȡ��Ӧ�Ķ��󲻳ɹ�!(in {{2}}.{{3}})\", e, {0}, " + this.constructorName + ", strThisFuncName);", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return null;");

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_UpdateObjInLstCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "UpdateObjInLstCache(obj{0}: cls{0}EN) {{",
                    ThisTabName4GC);
            Re_objFunction4Code.FuncCHName4Code = "�޸��ڻ�������б��еĶ���, ���̨���ݿ��޹�.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[UpdateObjInLstCache]����;(in {clsStackTrace.GetCurrClassFunction()}";

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * �޸��ڻ�������б��еĶ���, ���̨���ݿ��޹�.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}:�����Ķ���", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @returns ����");
            strCodeForCs.AppendFormat("\r\n*/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "UpdateObjInLstCache(obj{0}: cls{0}EN) {{",
                    ThisTabName4GC);

            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "UpdateObjInLstCache(obj{0}: cls{0}EN,{1}: {2}) {{",
                    ThisTabName4GC,
                    thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.TypeScriptType);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "UpdateObjInLstCache(obj{0}: cls{0}EN,{1}: {2}) {{",
                    ThisTabName4GC,
                    thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.TypeScriptType);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "UpdateObjInLstCache(obj{0}: cls{0}EN,{1}: {2}, {3}:{4}) {{",
                    ThisTabName4GC,
                    thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.TypeScriptType,
                    thisCacheClassify_TS.PriVarName2,
                    thisCacheClassify_TS.TypeScriptType2);

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "UpdateObjInLstCache(obj{0}: cls{0}EN,{1}: {2}, {3}:{4}) {{",
                    ThisTabName4GC,
                    thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.TypeScriptType,
                    thisCacheClassify_TS.PriVarName2,
                    thisCacheClassify_TS.TypeScriptType2);
            }
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"UpdateObjInLstCache\";");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}();");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName});");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
            }
            //  strCodeForCs.AppendFormat("\r\n" + "const obj = new cls{0}EN();", ThisTabName4GC);
            //strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null) 1return;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "const obj = arr{0}ObjLstCache.find(x => ", ThisTabName4GC);

            IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = null;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                if (objInFor.ConstraintTypeId != enumConstraintType.Uniqueness_01) continue;
                arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

            }

            if (arrObjLst_Flds != null && arrObjLst_Flds.Count() > 0)
            {
                bool bolIsFirst = true;
                foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                {
                    if (bolIsFirst)
                    {
                        strCodeForCs.AppendFormat("x.{1} == obj{0}.{1}",
                            ThisTabName4GC,
                            objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                        bolIsFirst = false;
                    }
                    else
                    {
                        strCodeForCs.AppendFormat(" && x.{1} == obj{0}.{1}",
                            ThisTabName4GC,
                            objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                    }
                }
                strCodeForCs.Append(");");
            }
            else
            {
                string strErrMsg = "";
                switch (objPrjTabENEx.objKeyField0.PrimaryTypeId)
                {
                    case enumPrimaryType.Identity_02:
                        strErrMsg = string.Format("�������󣺹ؼ�������Ϊ:[Identity]�ı�,һ��Ҫ����Ψһ������;",                       ThisTabName4GC,
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strErrMsg);
                        clsPrjTabBLEx.CheckTabFlds(objPrjTabENEx.TabId, CmPrjId, objPrjTabENEx.UserId);
                        throw new Exception(strErrMsg);
                        //break;
                    case enumPrimaryType.StringAutoAddPrimaryKey_03:

                        strErrMsg = string.Format("�������󣺹ؼ�������Ϊ:[�ַ����Զ���������]�ı�,һ��Ҫ����Ψһ������;", ThisTabName4GC,
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strErrMsg);
                        clsPrjTabBLEx.CheckTabFlds(objPrjTabENEx.TabId, CmPrjId, objPrjTabENEx.UserId);
                        throw new Exception(strErrMsg);
                        //break;
                    case enumPrimaryType.PrimaryKey_01:

                        strCodeForCs.AppendFormat("\r\n" + "x.{1} == obj{0}.{1});",
                            ThisTabName4GC,
                            objKeyField.PropertyName(this.IsFstLcase));

                        break;
                }

            }


            strCodeForCs.Append("\r\n" + "if (obj != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj.{1};", ThisTabName4GC, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign( obj, obj{0});", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache.push(obj{0});", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����:[{0}]. \\n���б����޸Ķ��󲻳ɹ�!(in {1}.{2})\", e, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }



        public string Gen_4WA_Ts_GetObjByKeyId_localStorage()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetObjBy{1}localStorage({2}) {{",
                    ThisTabName4GC, objKeyField.FldName,
                     objPrjTabENEx.KeyVarDefineLstStr_TS);

            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ��ֻ�ȡ��ض���, ��localStorage�����л�ȡ.";
            string strBy = objKeyField.FldName;
            if (objPrjTabENEx.arrKeyFldSet.Count > 1) strBy = "KeyLst";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjBy{strBy}localStorage]����;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݹؼ��ֻ�ȡ��ض���, ��localStorage�����л�ȡ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�����Ĺؼ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns ����");
            strCodeForCs.AppendFormat("\r\n*/");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjBy{1}localStorage({2}) {{",
                    ThisTabName4GC, strBy,
                     objPrjTabENEx.KeyVarDefineLstStr_TS);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjBy{0}localStorage\";", strBy);
            string strFuncName = string.Format("GetObjBy{0}localStorage", strBy);

            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                var strTemp = clsPubFun4GC.Gc_CheckVarEmpty_Ts(objInFor.PrivFuncName, objInFor.TypeScriptType,
                    objInFor.ObjFieldTab0().DataTypeId,
             this.ClsName, strFuncName, objInFor.ObjFieldTab().FldLength, true, this, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + strTemp);
            }
            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                ThisTabName4GC, objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "console.error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.AppendFormat("\r\n" + "throw new Error(\"�ؼ���Ϊ��!����ȷ\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (Object.prototype.hasOwnProperty.call(localStorage, strKey))");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "//�������,ֱ�ӷ���");
            strCodeForCs.AppendFormat("\r\n" + "const strTempObj = localStorage.getItem(strKey) as string;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cache: cls{0}EN = JSON.parse(strTempObj);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cache;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");




            strCodeForCs.AppendFormat("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const obj{ThisTabName4GC} = await {thisWA_F(WA_F.GetObjByKeyId)}({objPrjTabENEx.KeyPrivFuncFldNameLstStr_TS});");
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0} != null)", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "localStorage.setItem(strKey, JSON.stringify(obj{0}));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"Key:[${ strKey}]�Ļ����Ѿ�����!\");");
            strCodeForCs.AppendFormat("\r\n" + "console.log(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0};", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0};", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����:[{{0}}]. \\n���ݹؼ���:[{{1}}]��ȡ��Ӧ�Ķ��󲻳ɹ�!(in {{2}}.{{3}})\", e, {0}, " + this.constructorName + ", strThisFuncName);", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "console.error(strMsg);");
            strCodeForCs.AppendFormat("\r\n" + "alert(strMsg);");
            strCodeForCs.AppendFormat("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }



        public string Gen_4WA_Ts_GetNameByKeyIdCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetNameBy{0}Cache",
              objKeyField.FldName);
            Re_objFunction4Code.FuncCHName4Code = string.Format("���ݹؼ��ֻ�ȡ��ض������������, �ӻ����л�ȡ.",
                  ThisTabName4GC);

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetNameBy{objKeyField.FldName}Cache]����;(in {clsStackTrace.GetCurrClassFunction()})";
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
                return "/*�ñ�û�������ֶ�,�������ɴ˺���!*/";
            }
            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݹؼ��ֻ�ȡ��ض������������, �ӻ����л�ȡ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�����Ĺؼ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns ����");
            strCodeForCs.AppendFormat("\r\n*/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetNameBy{1}Cache({2}: {3}) {{",
                    ThisTabName4GC, objKeyField.FldName,
            objKeyField.PrivFuncName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetNameBy{1}Cache({2}: {3}) {{",
                    ThisTabName4GC, objKeyField.FldName,
            objKeyField.PrivFuncName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetNameBy{1}Cache({2}: {3},{4}: {5}) {{",
                    ThisTabName4GC, objKeyField.FldName,
            objKeyField.PrivFuncName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);
                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetNameBy{1}Cache({2}: {3},{4}: {5}) {{",
                    ThisTabName4GC, objKeyField.FldName,
            objKeyField.PrivFuncName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);
            }

            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetNameBy{1}Cache({2}: {3},{4}: {5}, {6}:{7}) {{",
                    ThisTabName4GC, objKeyField.FldName,
            objKeyField.PrivFuncName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
            thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
            thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "GetNameBy{1}Cache({2}: {3},{4}: {5}, {6}:{7}) {{",
                    ThisTabName4GC, objKeyField.FldName,
            objKeyField.PrivFuncName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
            thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
            thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);

            }
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetNameBy{0}Cache\";", objKeyField.FldName);
            string strFuncName = string.Format("GetNameBy{0}Cache", KeyFldName);

            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                var strTemp = clsPubFun4GC.Gc_CheckVarEmpty_Ts(objInFor.PrivFuncName, objInFor.TypeScriptType,
                    objInFor.ObjFieldTab0().DataTypeId,
 this.ClsName, strFuncName, objInFor.ObjFieldTab().FldLength, true, this, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + strTemp);
            }

            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}();");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName});");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
            }
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null) return \"\";", ThisTabName4GC);

            //strCodeForCs.AppendFormat("\r\n" + "const obj = new cls{0}EN();", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            string strFilterCondition = clsPubFun4GC.GenFilterCondition("x", objPrjTabENEx, this.IsFstLcase);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}Sel = arr{0}ObjLstCache.filter(x => {1});",
                ThisTabName4GC, strFilterCondition);

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}: cls{0}EN;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Sel.length > 0)", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "obj{0} = arr{0}Sel[0];", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}.{1};", ThisTabName4GC, objField_Name.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����:[{{0}}]. \\n���ݹؼ���:[{{1}}]��ȡ��Ӧ�Ķ����������Բ��ɹ�!\", e, {0});", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return \"\";");

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_IsExistCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "IsExistCache({0})",
                    clsPrjTabBLEx.ParaVarDefLstStr(objPrjTabENEx, "TypeScript"));
            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ����ж��Ƿ���ڼ�¼, �ӱ��ػ������ж�.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[IsExistCache]����;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݹؼ����ж��Ƿ���ڼ�¼, �ӱ��ػ������ж�.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�����Ĺؼ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns ����");
            strCodeForCs.AppendFormat("\r\n*/");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "IsExistCache({0}) {{",
                    clsPrjTabBLEx.ParaVarDefLstStr(objPrjTabENEx, "TypeScript"));

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"IsExistCache\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({clsPrjTabBLEx.Cache_ParaVarLstStr(objPrjTabENEx, "TypeScript")});");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null) return false;", ThisTabName4GC);

            //strCodeForCs.AppendFormat("\r\n" + "const obj = new cls{0}EN();", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            var objVarManageObj = clsPrjTabBLEx.GetVarManageObj4Key(objPrjTabENEx, "TypeScript");
            var arrVarObjLst = objVarManageObj.GetObjLst();
            StringBuilder sbTemp = new StringBuilder();
            bool bolIsFirst = true;
            foreach (var objInFor in arrVarObjLst)
            {
                if (bolIsFirst == true)
                {
                    sbTemp.AppendFormat("x.{0} == {1}", clsString.FstLcaseS(objInFor.FldName), objInFor.VariableName);
                    bolIsFirst = false;
                }
                else
                {
                    sbTemp.AppendFormat(" && x.{0} == {1}", clsString.FstLcaseS(objInFor.FldName), objInFor.VariableName);
                }
            }

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}Sel = arr{0}ObjLstCache.filter(x => {1});",
                ThisTabName4GC, sbTemp.ToString());

            //strCodeForCs.AppendFormat("\r\n" + "let obj{0}: cls{0}EN;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Sel.length > 0)", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return true;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"���ݹؼ���:[{{0}}]�ж��Ƿ���ڲ��ɹ�!(in {{1}}.{{2}})\", {0}, " + this.constructorName + ", strThisFuncName);", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return false;");

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_JoinByKeyLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// �Ѷ���ؼ��ֶε�ֵ��������,��|����(Join)--{0}({1})",
              ThisTabName4GC, objPrjTabENEx.TabCnName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ���ӵĶ���</param>",
                   ThisTabName4GC, objPrjTabENEx.TabCnName);
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + $"export  function {thisWA_F(WA_F.JoinByKeyLst)}(obj{ThisTabName4GC}EN: cls{ThisTabName4GC}EN):string");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n" + "//����¼�Ƿ����");

            //strCodeForCs.AppendFormat("\r\n" + "let strResult = \"\";");
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strResult = `${{obj{0}EN.{1}}}", ThisTabName4GC, objInFor.PropertyName(this.IsFstLcase));
                }
                else
                {
                    strCodeForCs.AppendFormat("|${{obj{0}EN.{1}}}", ThisTabName4GC, objInFor.PropertyName(this.IsFstLcase));
                }
                intIndex++;
            }
            strCodeForCs.Append("`");
            strCodeForCs.Append("\r\n" + "return strResult;");

            strCodeForCs.Append("\r\n" + "}");

            ///�������ĳ����(������)�Ƿ�Ψһ == == == == == == == == = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetObjLstByKeyLstCache()
        {
            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetObjLstByKeyLstsCache)}(arr{objKeyField.FldName}Lst: Array<{objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType}>) ";

            string strFuncName = $"{thisWA_F(WA_F.GetObjLstByKeyLstsCache)}";


            Re_objFunction4Code.FuncCHName4Code = "���ݹؼ����б��ȡ��ض����б�, �ӻ����л�ȡ.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstBy{objKeyField.FldName}LstCache]����;(in {clsStackTrace.GetCurrClassFunction()})";
            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + Gen_4WA_Ts_JoinByKeyLst());
                //string strJoinByKeyLst = JoinByKeyLst();
            }
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݹؼ����б��ȡ��ض����б�, �ӻ����л�ȡ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param arr{0}Lst:�ؼ����б�", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �����б�");
            strCodeForCs.AppendFormat("\r\n*/");
            var objFuncParaLst = new FuncParaLst("GetObjLstCacheAsync", this.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);

            string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            string strCondFldLst = objFuncParaLst.GetCondFldLst();
            string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);

            if (strFuncParaLst.Length > 0) strFuncParaLst = "," + strFuncParaLst;
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjLstByKeyLstsCache)}(arrKeysLst: Array<string> {strFuncParaLst}) {{");
                Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetObjLstByKeyLstsCache)}(arrKeysLst: Array<string> {strFuncParaLst})";
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByKeyLstsCache\";", ThisTabName4GC,
                objKeyField.FldName);
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjLstByKeyLstCache)}(arr{objKeyField.FldName}Lst: Array<{objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType}> {strFuncParaLst}) {{");
                Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetObjLstByKeyLstCache)}(arr{objKeyField.FldName}Lst: Array<{objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType}>{strFuncParaLst}) ";

                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstBy{1}LstCache\";", ThisTabName4GC,
                objKeyField.FldName);
            }


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({strCondFldLst});");

            //strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null) 1return null;", ThisTabName4GC);
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}Sel = arr{ThisTabName4GC}ObjLstCache.filter(x => arrKeysLst.indexOf({thisWA_F(WA_F.JoinByKeyLst)}(x))>-1);");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}Sel = arr{0}ObjLstCache.filter(x => arr{1}Lst.indexOf(x.{2})>-1);",
                ThisTabName4GC, objKeyField.FldName, objKeyField.PropertyName(this.IsFstLcase));
            }
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}Sel;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + $"const strMsg = Format(\"����:[{{0}}]. \\n���ݹؼ���:[{{1}}]��ȡ�����б��ɹ�!(in {{2}}.{{3}})\", e, arrKeysLst.join(\",\"), " + this.constructorName + ", strThisFuncName);");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����:[{{0}}]. \\n���ݹؼ���:[{{1}}]��ȡ�����б��ɹ�!(in {{2}}.{{3}})\", e, arr{0}Lst.join(\",\"), " + this.constructorName + ", strThisFuncName);", objKeyField.FldName);
            }
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "return new Array<cls{0}EN>();", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_GetObjLstByPagerCache()
        {
            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetObjLstByPagerCache)}(objPagerPara: stuPagerPara)";
            Re_objFunction4Code.FuncCHName4Code = "���ݷ�ҳ�����ӻ����л�ȡ��ҳ�����б�,ֻ��ȡһҳ";


            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstByPagerCache]����;(in {clsStackTrace.GetCurrClassFunction()})";

            string strFuncName = $"{thisWA_F(WA_F.GetObjLstByPagerCache)}";

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݷ�ҳ�����ӻ����л�ȡ��ҳ�����б�,ֻ��ȡһҳ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param objPagerPara:��ҳ�����ṹ", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �����б�");
            strCodeForCs.AppendFormat("\r\n*/");
            var objFuncParaLst = new FuncParaLst("GetObjLstByPagerCache", this.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);

            string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            string strCondFldLst = objFuncParaLst.GetCondFldLst();
            string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);

            if (strFuncParaLst.Length > 0) strFuncParaLst = "," + strFuncParaLst;

            strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetObjLstByPagerCache)}(objPagerPara: stuPagerPara {strFuncParaLst}) {{");
            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetObjLstByPagerCache)}(objPagerPara: stuPagerPara {strFuncParaLst}) ";

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByPagerCache\";", ThisTabName4GC,
            objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (objPagerPara.pageIndex == 0) return new Array<cls{0}EN>();", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({strCondFldLst});");
            //strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null) 1return null;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache.length == 0) return arr{0}ObjLstCache;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "let arr{0}Sel = arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const objCond = JSON.parse(objPagerPara.whereCond);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}Cond, objCond);", ThisTabName4GC);
            AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("cls{0}EN", ThisTabName4GC), enumImportObjType.ENClassInWApi, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "let dicFldComparisonOp: { [index: string]: string } = {};");
            strCodeForCs.Append("\r\n" + "if (objCond.sfFldComparisonOp != \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "dicFldComparisonOp = JSON.parse(objCond.sfFldComparisonOp);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"cls{0}WApi->GetObjLstByPagerCache->dicFldComparisonOp:\");", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(dicFldComparisonOp);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.Append("\r\n" + "const sstrKeys = GetObjKeys(objCond);");
            strCodeForCs.Append("\r\n" + "//console.log(sstrKeys);");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys) {");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) != null);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "const strComparisonOp = dicFldComparisonOp[strKey];");
            //strCodeForCs.AppendFormat("\r\n" + "const obj{0} = {0}GetObjFromSimObj(objCond);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}Cond.GetFldValue(strKey);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strValue);");
            strCodeForCs.Append("\r\n" + "switch (strType) {");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");
            strCodeForCs.Append("\r\n" + "if (strValue == \"\") continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"like\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length equal\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"in\") {");
            //else if (strComparisonOp == "in")
            //{
            //    const arrValues = strValue.split(',');
            //    console.error(arrValues);
            //    arrUserCodePath_Sel = arrUserCodePath_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
            //}
            strCodeForCs.Append("\r\n" + "const arrValues = strValue.toString().split(',');");
            //strCodeForCs.Append("\r\n" + "console.error(arrValues);");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");

            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strValue) == 0) continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) >= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) > strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Sel.length == 0) return arr{0}Sel;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);");
            strCodeForCs.Append("\r\n" + "if (intStart <= 0) intStart = 0;");

            strCodeForCs.Append("\r\n" + "const intEnd = intStart + objPagerPara.pageSize;");


            strCodeForCs.Append("\r\n" + "if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {");
            strCodeForCs.Append("\r\n" + "const sstrSplit: string[] = objPagerPara.orderBy.split(\" \");");
            strCodeForCs.Append("\r\n" + "let strSortType = \"asc\";");
            strCodeForCs.Append("\r\n" + "const strSortFld = sstrSplit[0];");
            strCodeForCs.Append("\r\n" + "if (sstrSplit.length > 1) strSortType = sstrSplit[1];");
            strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}Sel = arr{ThisTabName4GC}Sel.sort({thisWA_F(WA_F.SortFunByKey)}(strSortFld, strSortType));");



            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + "//��������ֶ���[OrderBy]Ϊ��,�͵���������");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.sort(objPagerPara.sortFun);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.slice(intStart, intEnd);     ", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}Sel;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����:[{0}]. \\n��������:[{1}]��ȡ��ҳ�����б��ɹ�!(In {2}.{3})\", e, objPagerPara.whereCond, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return new Array<cls{0}EN>();", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GetSubObjLstCache()
        {
            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetSubObjLstCache)}({ThisObjName4Cond}: {ThisClsName4EN}) ";
            Re_objFunction4Code.FuncCHName4Code = "������������, �ӻ���Ķ����б��л�ȡ�Ӽ�.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetSubObjLstCache]����;(in {clsStackTrace.GetCurrClassFunction()})";
            string strFuncName = thisWA_F(WA_F.GetSubObjLstCache);
            var objFuncParaLst = new FuncParaLst("GetSubObjLstCache", this.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);

            string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            string strCondFldLst_Cache = objFuncParaLst.GetCondFldLst();
            string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);

            if (strFuncParaLst.Length > 0) strFuncParaLst = "," + strFuncParaLst;



            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ������������, �ӻ���Ķ����б��л�ȡ�Ӽ�.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}Cond:��������", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �����б��Ӽ�");
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetSubObjLstCache)}({ThisObjName4Cond}: {ThisClsName4EN} {strFuncParaLst}) {{");

            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetSubObjLstCache)}({ThisObjName4Cond}: {ThisClsName4EN} {strFuncParaLst})";

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetSubObjLstCache\";", ThisTabName4GC,
              objKeyField.FldName);

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({strCondFldLst_Cache});");
            //strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null) 1return null;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "let arr{0}Sel = arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.sfFldComparisonOp == null || obj{0}Cond.sfFldComparisonOp == \"\") return arr{0}Sel;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "const dicFldComparisonOp: {{ [index: string]: string }} = JSON.parse(obj{0}Cond.sfFldComparisonOp);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"cls{0}WApi->GetSubObjLstCache->dicFldComparisonOp:\");", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(dicFldComparisonOp);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = GetObjKeys(obj{0}Cond);", ThisTabName4GC);
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "GetObjKeys", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "//console.log(sstrKeys);");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys) {");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) != null);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "const strComparisonOp = dicFldComparisonOp[strKey];");

            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}Cond.GetFldValue(strKey);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strValue);");
            strCodeForCs.Append("\r\n" + "switch (strType) {");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");
            strCodeForCs.Append("\r\n" + "if (strValue == \"\") continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"like\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length equal\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");

            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strValue) == 0) continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) >= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) > strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}Sel;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����:[{{0}}]. \\n��������:[{{1}}]��������б��л�ȡ�Ӽ����󲻳ɹ�!(in {{2}}.{{3}})\", e, JSON.stringify( obj{0}Cond), " + this.constructorName + ", strThisFuncName);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return new Array<{0}>();", ThisClsName4EN);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_IsExistRecordCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "IsExistRecordCache({1}: {0}) {{",
                  ThisClsName4EN, ThisObjName4Cond,
          objKeyField.FldName,
          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);
            Re_objFunction4Code.FuncCHName4Code = "������������, �ӻ���Ķ����б��л�ȡ�Ӽ�.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[IsExistRecordCache]����;(in {clsStackTrace.GetCurrClassFunction()})";
            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ������������, �ӻ���Ķ����б��л�ȡ�Ӽ�.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}Cond:��������", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �����б��Ӽ�");
            strCodeForCs.AppendFormat("\r\n*/");
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "IsExistRecordCache({1}: {0}) {{",
                  ThisClsName4EN, ThisObjName4Cond,
          objKeyField.FldName,
          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);

            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "IsExistRecordCache({1}: {0},{4}: {5}) {{",
                    ThisClsName4EN, ThisObjName4Cond,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "IsExistRecordCache({1}: {0},{3}: {4}) {{",
                    ThisClsName4EN, ThisObjName4Cond,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "IsExistRecordCache({1}: {0},{3}: {4}, {5}:{6}) {{",
                 ThisClsName4EN, ThisObjName4Cond,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
            thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
            thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "IsExistRecordCache({1}: {0},{3}: {4}, {5}:{6}) {{",
                    ThisClsName4EN, ThisObjName4Cond,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
            thisCacheClassify_TS.PriVarName,
                thisCacheClassify_TS.TypeScriptType,
            thisCacheClassify_TS.PriVarName2,
                thisCacheClassify_TS.TypeScriptType2);
            }
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"IsExistRecordCache\";", ThisTabName4GC,
      objKeyField.FldName);

            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}();");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName});");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
            }
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null) return false;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "let arr{0}Sel = arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.sfFldComparisonOp == null || obj{0}Cond.sfFldComparisonOp == \"\") return arr{0}Sel.length>0?true:false;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "const dicFldComparisonOp: {{ [index: string]: string }} = JSON.parse(obj{0}Cond.sfFldComparisonOp);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"cls{0}WApi->GetSubObjLstCache->dicFldComparisonOp:\");", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(dicFldComparisonOp);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = GetObjKeys(obj{0}Cond);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "//console.log(sstrKeys);");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys) {");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;");
            strCodeForCs.Append("\r\n" + "const strComparisonOp = dicFldComparisonOp[strKey];");

            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}Cond.GetFldValue(strKey);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strValue);");
            strCodeForCs.Append("\r\n" + "switch (strType) {");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");
            strCodeForCs.Append("\r\n" + "if (strValue == \"\") continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"like\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length equal\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");

            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strValue) == 0) continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) >= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) > strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Sel.length > 0)", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return true;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��������:[{{0}}]�ж��Ƿ���ڲ��ɹ�!(in {{1}}.{{2}})\", JSON.stringify( obj{0}Cond), " + this.constructorName + ", strThisFuncName);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return false;", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_GetRecCountByCondCache()
        {
            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWA_F(WA_F.GetRecCountByCondCache)}({ThisObjName4Cond}: {ThisClsName4EN}) ";
            Re_objFunction4Code.FuncCHName4Code = "������������, �ӻ���Ķ����б��л�ȡ��¼��.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetRecCountByCondCache]����;(in {clsStackTrace.GetCurrClassFunction()})";

            string strFuncName = thisWA_F(WA_F.GetRecCountByCondCache);
            var objFuncParaLst = new FuncParaLst("GetObjLstCacheAsync", this.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);

            string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            string strCondFldLst_Cache = objFuncParaLst.GetCondFldLst();
            string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);

            if (strFuncParaLst.Length > 0) strFuncParaLst = "," + strFuncParaLst;



            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ������������, �ӻ���Ķ����б��л�ȡ��¼��.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}Cond:��������", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @returns �����б��¼��");
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.GetRecCountByCondCache)}({ThisObjName4Cond}: {ThisClsName4EN} {strFuncParaLst}) {{");

            Re_objFunction4Code.FuncName4Code =
            $"export  async function {thisWA_F(WA_F.GetRecCountByCondCache)}({ThisObjName4Cond}: {ThisClsName4EN}{strFuncParaLst}) ";

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetRecCountByCondCache\";", ThisTabName4GC,
      objKeyField.FldName);


            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLstCache = await {thisWA_F(WA_F.GetObjLst_Cache)}({strCondFldLst_Cache});");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null) return 0;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "let arr{0}Sel = arr{0}ObjLstCache;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.sfFldComparisonOp == null || obj{0}Cond.sfFldComparisonOp == \"\") return arr{0}Sel.length;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "const dicFldComparisonOp: {{ [index: string]: string }} = JSON.parse(obj{0}Cond.sfFldComparisonOp);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"cls{0}WApi->GetSubObjLstCache->dicFldComparisonOp:\");", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(dicFldComparisonOp);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = GetObjKeys(obj{0}Cond);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "//console.log(sstrKeys);");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys) {");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) != null);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "const strComparisonOp = dicFldComparisonOp[strKey];");

            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}Cond.GetFldValue(strKey);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strValue);");
            strCodeForCs.Append("\r\n" + "switch (strType) {");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");
            strCodeForCs.Append("\r\n" + "if (strValue == \"\") continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"like\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length equal\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"in\") {");
            strCodeForCs.Append("\r\n" + "const arrValues = strValue.toString().split(',');");
            //strCodeForCs.Append("\r\n" + "console.error(arrValues);");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");

            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strValue) == 0) continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) >= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) > strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}Sel.length;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����:[{{0}}]. \\n��������:[{{1}}]�ӻ�������б��л�ȡ��¼�����ɹ�!(in {{2}}.{{3}})\", e, JSON.stringify( obj{0}Cond), " + this.constructorName + ", strThisFuncName);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return 0;", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_ClassConstructor1()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Ts_ComboBoxBindFunction()
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
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strCodeForCs.Append("\r\n/**");
                    strCodeForCs.Append("\r\n * �󶨻���Win��������");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n * @param objComboBox:��Ҫ�󶨵�ǰ���������");
                    strCodeForCs.Append("\r\n*/");
                    strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"BindCbo_{0}\";", strValueFieldName,
      objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strCodeForCs.AppendFormat("\r\n" + "Array<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
                    ThisTabName4GC);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    ThisTabName4GC);
                    strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    //strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    //ThisTabName4GC);
                    strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    ThisTabName4GC);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                    ThisTabName4GC, strValueFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"ѡ[{2}]...\";",
                        ThisTabName4GC, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst.Insert(0, obj{0}EN);",
                    ThisTabName4GC);
                    strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
                    //strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
                    //strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    //ThisTabName4GC);
                    //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[\"{1}\"].ToString();",
                    //ThisTabName4GC, strValueFieldName);
                    //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[\"{1}\"].ToString();",
                    //ThisTabName4GC, strTextFieldName);
                    //strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
                    //ThisTabName4GC);
                    //strCodeForCs.Append("\r\n" + "}");
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

        public string Gen_4WA_Ts_DdlBindCache()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "BindDdl[�ֶ���]Cache2(strDdlName: string, {1}: {0}) {{",
                   ThisClsName4EN, ThisObjName4Cond);
            Re_objFunction4Code.FuncCHName4Code = string.Format("Ϊ�������ȡ����,�ӱ�:[{0}]�л�ȡ",
                  ThisTabName4GC);
            string strFuncName = thisWA_F(WA_F.GetSubObjLstCache);
            var objFuncParaLst = new FuncParaLst("DdlBindCache", this.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);

            string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            string strCondFldLst_Cache = objFuncParaLst.GetCondFldLst();
            string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);

            if (strFuncParaLst.Length > 0) strFuncParaLst = "," + strFuncParaLst;

            string strTextFieldName = "";
            string strValueFieldName = "";
            string strValueFieldName_FldName = "";
            string strTextFieldName_FldName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;


                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                        strValueFieldName_FldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                        strTextFieldName_FldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[BindDdl_{strValueFieldName_FldName}Cache2]����;(in {clsStackTrace.GetCurrClassFunction()})";
                var strIsCache = "Cache";
                if (objPrjTabENEx.IsUseCache_TS() == false) strIsCache = "";

                if (string.IsNullOrEmpty(strTextFieldName) == true) return "/* ����������ص������ֶ�Ϊ��,�������ɰ���������. */";

                string strFuncName_Temp = $"BindDdl{strTextFieldName_FldName}{strIsCache}2";

                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Ϊ�������ȡ����,�ӱ�:[{0}]�л�ȡ",
                  ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "* @returns ��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable");
                strCodeForCs.Append("\r\n" + " **/");

                strCodeForCs.Append("\r\n" + $"export  async function " + this.tabNameHead + $"{strFuncName_Temp}(strDdlName: string, {ThisObjName4Cond}: {ThisClsName4EN} {strFuncParaLst}) {{");

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + $"{strFuncName_Temp}(strDdlName: string, {ThisObjName4Cond}: {ThisClsName4EN} {strFuncParaLst}) ");

                strCodeForCs.Append("\r\n" + $"const strThisFuncName = this.{strFuncName_Temp}.name;");
                strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(strDdlName);",
                    ThisTabName4GC, strValueFieldName, strTextFieldName);
                strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{{0}} ������!\", strDdlName);",
                    ThisTabName4GC, strValueFieldName, strTextFieldName);
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + $"const arrObjLstSel: Array<cls{ThisTabName4GC}EN> = await {thisWA_F(WA_F.GetSubObjLstCache)}(obj{ThisTabName4GC}Cond {strCondFldLst_Cache});");

                strCodeForCs.AppendFormat("\r\n" + "BindDdl_ObjLst(strDdlName, arrObjLstSel, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                ThisTabName4GC,
                                strValueFieldName_FldName,
                                strTextFieldName_FldName,
                                objPrjTabENEx.TabCnName);
                strCodeForCs.AppendFormat("\r\n" + "//console.log(\"���BindDdl_{0}!\");", strValueFieldName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ʹ�û�������б�����������,{0}.(in {1}.{2})\", e, " + this.constructorName + ", strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

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

        //  public string Gen_4WA_Ts_DdlBindFunction()
        //  {
        //      string strFuncName = "";
        //      StringBuilder strCodeForCs = new StringBuilder();
        //      string strTextFieldName = "";
        //      string strValueFieldName = "";
        //      try
        //      {
        //          ///���ɽ��б���;
        //          //��������ĺ��� ����;
        //          //��0��:�ѿؼ���������ComboBoxת����ComboBox
        //          foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
        //          {
        //              if (objField.FieldTypeId == "02")
        //              {
        //                  strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
        //              }
        //              if (objField.FieldTypeId == "03")
        //              {
        //                  strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
        //              }
        //          }
        //          if (strValueFieldName != "" && strTextFieldName != "")
        //          {
        //              //					strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()", 
        //              //						strValueFieldName);
        //              //					strCodeForCs.Append("\r\n" + "{");
        //              //					strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
        //              //					strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
        //              //						strValueFieldName, strTextFieldName, ThisTabName4GC);
        //              //					//									if (objViewCtlField.DsCondStr.Trim() == "" )
        //              //					//									{
        //              //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
        //              //					//											strValueFieldName, strTextFieldName, objViewCtlField.DsTabName);
        //              //					//									}
        //              //					//									else
        //              //					//									{
        //              //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
        //              //					//											strValueFieldName, strTextFieldName, objViewCtlField.DsTabName, objViewCtlField.DsCondStr);
        //              //					//									}
        //              //					strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql=new 1clsSpecSQLforSql();");
        //              //					strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
        //              //					strCodeForCs.Append("\r\n" + "return objDT;");
        //              //					strCodeForCs.Append("\r\n" + "}");
        //              strCodeForCs.Append("\r\n/**");
        //              strCodeForCs.Append("\r\n * �󶨻���Web��������");
        //              strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
        //              strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
        //              strCodeForCs.Append("\r\n*/");
        //              strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
        //              strValueFieldName);
        //              strCodeForCs.Append("\r\n" + "{");
        //              strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"BindDdl_{0}\";", strValueFieldName,
        //objKeyField.FldName);

        //              strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");

        //              strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
        //                    objPrjTabENEx.TabCnName);

        //              strCodeForCs.AppendFormat("\r\n" + "Array<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
        //                  ThisTabName4GC);

        //              strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField=\"{1}\";",
        //                  ThisTabName4GC, strValueFieldName);
        //              strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField=\"{1}\";",
        //                  ThisTabName4GC, strTextFieldName);
        //              strCodeForCs.Append("\r\n" + "objDDL.DataSource = arrObjLst;");
        //              strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
        //              strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
        //              strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
        //              strCodeForCs.Append("\r\n" + "}");
        //          }
        //      }

        //      catch (Exception ex)
        //      {
        //          string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

        //          clsEntityBase.LogErrorS(ex, strMsg);
        //          throw new Exception(strMsg);
        //      }
        //      return strCodeForCs.ToString();
        //  }

        public string Gen_4WA_Ts_CheckPropertyNew()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\npublic void CheckPropertyNew(cls{0}EN obj{0}EN)",
            ThisTabName4GC);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + ThisTabName4GC + "EN", this.IsFstLcase);

                if (objField.IsTabNullable = false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "byte")
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
            //strCodeForCs.AppendFormat("\r\n obj{0}EN.SetIsCheckProperty(true);", ThisTabName4GC);

            strCodeForCs.Append("\r\n }");
            ///������������Ƿ���ȷ == == ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetFirstId()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param strWhereCond:����");
            strCodeForCs.Append("\r\n * @returns ���صĵ�һ����¼�Ĺؼ���ֵ");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetFirstID(strWhereCond: string) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetFirstID\";", ThisTabName4GC,
      objKeyField.FldName);

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


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_GetNameByKeyIdCacheBak()
        {
            string strTextFieldName = "";
            string strValueFieldName = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            if (objPrjTabENEx.IsUseCache == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[Get{strTextFieldName}By{objKeyField.FldName}Cache]����;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�����Ĺؼ���", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns ���ݹؼ��ֻ�ȡ������");
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "string Get{4}By{1}Cache({2} {3})",
            ThisTabName4GC,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"Get{0}By{1}Cache\";", strTextFieldName,
      objKeyField.FldName);

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
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                 ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "while (intEnd >= intStart)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                ThisTabName4GC,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intFindFailCount = 0;");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.{1};",
                  ThisTabName4GC,
                  strTextFieldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                  ThisTabName4GC,
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


            //strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //ThisTabName4GC);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //ThisTabName4GC,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.{1};",
            //ThisTabName4GC,
            //strTextFieldName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "intFindFailCount++;");
            strCodeForCs.AppendFormat("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼[{3} = {{0}}][intFindFailCount = {{1}}](����:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              ThisTabName4GC,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ�������ֶ�����ֵ:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               ThisTabName4GC,
               objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ���Ϊnull, ����![intMid = {{0}}]\", intMid);",
               "{", "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               ThisTabName4GC,
                objKeyField.FldName,
                strTextFieldName);
            //strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.error(strErrMsgForGetObjById);");

            strCodeForCs.Append("\r\n" + "throw new Error(strErrMsgForGetObjById);");
            //strCodeForCs.AppendFormat("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ʼ���б���.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_InitListCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ʼ���б���.-----------------------------;


            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ��ʼ���б���.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.Append("\r\n" + "export  function " + this.tabNameHead + "InitListCache():void");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"InitListCache\";", ThisTabName4GC,
      objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "}");

            //��ʼ���б���.======================= = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GetObjLstByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ����������ȡ��Ӧ�ļ�¼�����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param intMinNum:��С��¼��");
            strCodeForCs.Append("\r\n * @param intMaxNum:����¼��");
            strCodeForCs.Append("\r\n * @param strWhereCond:��������");
            strCodeForCs.Append("\r\n * @param strOrderBy:����ʽ");
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��ȡ����Ӧ��¼�����б�");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy = \"\", cb: (json: any) => void, errorCb: (json: any) => void) ",
              ThisTabName4GC,
              objKeyField.FldName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByRange\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "const strAction = \"GetObjLstByRange\";");
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.Append("\r\n" + clsPubFun4GC.GC_GetToken(objPrjTabENEx, this, strBaseUrl));
            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
            strCodeForCs.Append("\r\n" + "const config = {");
            strCodeForCs.Append("\r\n" + "headers: {");
            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "params: {");
            strCodeForCs.Append("\r\n" + "\"intMinNum\": intMinNum,");
            strCodeForCs.Append("\r\n" + "\"intMaxNum\": intMaxNum,");
            strCodeForCs.Append("\r\n" + "\"strWhereCond\": strWhereCond,");
            strCodeForCs.Append("\r\n" + "\"strOrderBy\": strOrderBy,");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");
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
        public string Gen_4WA_Ts_DelRecords()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ���ݹؼ����б�ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ʵ��ɾ����¼�ĸ���");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "int DelRecords(string strKeyIdLst)",
            ThisTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"DelRecords\";", ThisTabName4GC,
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

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_DelMultiRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ���ݹؼ����б�ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param arr{0}:�ؼ����б�", objKeyField.FldName);
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ʵ��ɾ����¼�ĸ���");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.DelMultiRecord)}(arr{objKeyField.FldName}: Array<string>, cb: (json: any) => void, errorCb: (json: any) => void)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"Del{0}s\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"Del{0}s\";", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"����: strIdentityID =01\";");
            strCodeForCs.AppendFormat("\r\n" + "axios.post(strUrl, arr{0});", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_DelMultiRecordByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��������ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ʵ��ɾ����¼�ĸ���");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.Append("\r\n" + $"export  async function {thisWA_F(WA_F.DelMultiRecordByCond)}(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"Del{0}sByCond\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"Del{0}sByCond\";", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");

            //strCodeForCs.Append("\r\n" + "const mapParam: Dictionary = new Dictionary();");
            //strCodeForCs.Append("\r\n" + "mapParam.add(\"strWhereCond\", strWhereCond);");
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"����: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "axios.get(strUrl,");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "params: { strWhereCond}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��Ӽ�¼,���ҷ��عؼ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Ts_AddNewRecordWithReturnKey()
        {
            //if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * �ѱ������ӵ����ݿ���,���ҷ��ظü�¼�Ĺؼ���(���Identity�ؼ���)");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}EN:��Ҫ��ӵı����",
                    ThisTabName4GC);
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");
            strCodeForCs.Append("\r\n * @returns ��������Ӽ�¼�Ĺؼ���");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "AddNewRecordWithReturnKey(obj{0}EN: cls{0}EN, cb: (json: any) => void, errorCb: (json: any) => void)",
            ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"AddNewRecordWithReturnKey\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "const strAction = \"AddNewRecordWithReturnKey\";");

            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} === null || obj{0}EN.{1} === 0)",
                     ThisTabName4GC,
                  objKeyField.PropertyName(this.IsFstLcase));
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} === null || obj{0}EN.{1} === \"\")",
                 ThisTabName4GC,
              objKeyField.PropertyName(this.IsFstLcase));
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��Ҫ�Ķ���Ĺؼ���Ϊ��,�������!\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

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
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN, config);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "cb(data);");
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
        public string Gen_4WA_Ts_UpdateWithCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * �����������޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}EN:��Ҫ�޸ĵĶ���",
                  ThisTabName4GC);
            strCodeForCs.Append("\r\n * @param strWhereCond:������");
            strCodeForCs.Append("\r\n * @returns ���صĵ�һ����¼�Ĺؼ���ֵ");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "UpdateWithCondition(obj{0}EN: cls{0}EN, strWhereCond: string , cb: (json: any) => void, errorCb: (json: any) => void)",
            ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"UpdateWithCondition\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "const strAction = \"UpdateWithCondition\";");
            strCodeForCs.AppendFormat("\r\n" + " if (obj{0}EN.sfUpdFldSetStr === undefined || obj{0}EN.sfUpdFldSetStr === null || obj{0}EN.sfUpdFldSetStr === \"\")",
             ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����(�ؼ���: {{0}})�ġ��޸��ֶμ���Ϊ��,�����޸�!\", obj{0}EN.{1});",
                ThisTabName4GC, objKeyField.FldName, "{", "}");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + " throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.Append("\r\n" + $"const strUrl = {objProjectsENEx.GetWebApiFunc}(" + this.controllerName + ", strAction);");
            strCodeForCs.AppendFormat("\r\n" + "axios.post(strUrl, obj{0});", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!���ʵ�ַ:{0}���ɹ�!(in {1}.{2})\", strUrl, " + this.constructorName + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Ts_IsExist()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ���ݹؼ����ж��Ƿ���ڼ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param {0}:�ؼ���", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n * @param cb:CallBack����,������ʾ��ȷ�������");
            strCodeForCs.Append("\r\n * @param errorCb:CallBack����,������ʾ������Ϣ");

            strCodeForCs.Append("\r\n * @returns �Ƿ����?���ڷ���True");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "IsExist({0}: {1}, cb: (json: any) => void, errorCb: (json: any) => void)",
                    objKeyField.PrivFuncName, KeyDataType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"IsExist\";", ThisTabName4GC,
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
            strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},", objKeyField.FldName, objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,config);");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");
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
        public string Gen_4WA_Ts_GetWebApiUrl()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "GetWebApiUrl(strController: string, strAction: string): string ",
           "");

            Re_objFunction4Code.FuncCHName4Code = "��ȡWebApi�ĵ�ַ";

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ȡWebApi�ĵ�ַ");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ���ص�ǰ�ļ���Web����ĵ�ַ");
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.Append("\r\n" + "export  function " + this.tabNameHead + "GetWebApiUrl(strController: string, strAction: string): string {");
            //strCodeForCs.Append("\r\n" + "const strThisFuncName = \"GetWebApiUrl\";");

            strCodeForCs.Append("\r\n" + "let strServiceUrl:string;");
            strCodeForCs.Append("\r\n" + "let strCurrIPAddressAndPort = \"\";");
            strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort_Local;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(clsSysPara4WebApi.CurrPrx) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = Format(\"{0}/{1}/{2}\", strCurrIPAddressAndPort, strController, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = Format(\"{0}/{1}/{2}/{3}\", strCurrIPAddressAndPort, clsSysPara4WebApi.CurrPrx, strController, strAction);");
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
                string strTemp_ImportClass = GeneCode_ImportClass();
                if (string.IsNullOrEmpty(strTemp_ImportClass) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp_ImportClass);
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

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_Java1(string strFuncId4GC)
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
                    switch (objvFunction4GeneCodeEN.ProgLangTypeId)
                    {
                        case "02":
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                            break;
                        default:
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                            break;

                    }
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

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_Swift41(string strFuncId4GC)
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

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_JavaScript1(string strFuncId4GC)
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

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_SilverLight1(string strFuncId4GC)
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


        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}WApi", ThisTabName4GC);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Access4TypeScript);
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
                    Re_objFunction4Code.FuncName4Code = this.Re_objFunction4Code.FuncName4Code;
                    Re_objFunction4Code.FuncCHName4Code = this.Re_objFunction4Code.FuncCHName4Code;

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
        public string Gen_4WA_TabFeature_DdlBindFunctionBak20240501(List<string> arrCondFldId)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCheckEmpty = new StringBuilder();
            string strFuncName = "";
            try
            {
                List<clsTabFeatureEN> arrTabFeature = objPrjTabENEx.arrTabFeatureSet().Where(x => x.FeatureId == enumPrjFeature.Tab_BindDdl_0173).ToList();
                foreach (var objTabFeature_BindDdl in arrTabFeature)
                {
                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature_BindDdl.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    objFuncParaLst.AddParaByTabFeature(objTabFeature_BindDdl, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
                    objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para();
                    string strPrivFuncName_Additional = objFuncParaLst.GetCondFldLst();
                    string strCodeText_CheckEmpty = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName,
                        objTabFeature_BindDdl.FuncNameJs, true, this, this.strBaseUrl);
                    string strFuncRemark = objFuncParaLst.GetFuncRemark();
                    strFuncPara = strFuncPara == "" ? "" : ", " + strFuncPara;

                    if (objTabFeature_BindDdl == null) continue;
                    if (objTabFeature_BindDdl.IsNeedGC == false)
                    {
                        strCodeForCs.Append("\r\n//�ñ��������ܲ���Ҫ����;");
                        continue;
                    }
                    if (objTabFeature_BindDdl.IsExtendedClass == true)
                    {
                        strCodeForCs.Append("\r\n//�ñ��������ܽ���ʹ������չ��;");
                        continue;
                    }

                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�������ֶ�,������Ӱ���������!");
                    }
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�йؼ��ֶ�,������Ӱ���������!");
                    }
                    clsTabFeatureFldsEN objField_Key = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
                    clsTabFeatureFldsEN objField_Name = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.NameField_03);
                    clsTabFeatureFldsEN objField_OrderNum = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09);
                    string strTextFieldName = objField_Name.ObjFieldTab().FldName;
                    string strValueFieldName = objField_Key.ObjFieldTab().FldName;
                    //��0��:�ѿؼ���������ComboBoxת����ComboBox
                    //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[BindDdl_{0}Cache]����;(in {clsStackTrace.GetCurrClassFunction()}",
                    //strValueFieldName);
                    var strIsCache = "Cache";
                    if (objPrjTabENEx.IsUseCache_TS() == false) strIsCache = "";

                    if (strValueFieldName != "" && strTextFieldName != "")
                    {

                        strCodeForCs.Append("\r\n/**");
                        strCodeForCs.Append("\r\n * �󶨻���Web��������");
                        strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                        strCodeForCs.Append("\r\n" + strFuncRemark);
                        strCodeForCs.Append("\r\n*/");

                        string strFuncName_Temp = $"BindDdl_{strValueFieldName}{strIsCache}";

                        strCodeForCs.Append("\r\n" + $"export  async function {this.tabNameHead}{strFuncName_Temp}(strDdlName: string {strFuncPara})");

                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + $"//const strThisFuncName = this.{strFuncName_Temp}.name;");

                        strCodeForCs.AppendLine(sbCheckEmpty.ToString());

                        strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(strDdlName);",
        ThisTabName4GC, strValueFieldName, strTextFieldName);
                        strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{{0}} ������!(In {0})\", strDdlName);", strFuncName_Temp);
                        strCodeForCs.Append("\r\n" + "alert(strMsg);");
                        strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                        strCodeForCs.Append("\r\n" + "throw (strMsg);");
                        strCodeForCs.Append("\r\n" + "}");

                        strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                        strCodeForCs.AppendFormat("\r\n" + "//console.log(\"��ʼ��BindDdl_{0}Cache\");", strValueFieldName);

                        var strLetOrConst = "const";
                        if (objFuncParaLst.GetLst.Count > 0)
                        {
                            strLetOrConst = "let";
                        }
                        if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                        {
                            strLetOrConst = "let";
                        }
                        if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
                        {
                            string strConditionStr = objFuncParaLst.GeneConditionStr();
                            strCodeForCs.Append("\r\n" + $"{strLetOrConst} arrObjLstSel: Array<cls{ThisTabName4GC}EN> = await {thisWA_F(WA_F.GetObjLstAsync)}({strConditionStr});");
                        }
                        else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
                        {
                            strCodeForCs.Append("\r\n" + $"{strLetOrConst} arrObjLstSel: Array<cls{ThisTabName4GC}EN> = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName});");

                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"{strLetOrConst} arrObjLstSel: Array<cls{ThisTabName4GC}EN> = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");

                        }

                        if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                        {
                            clsTabFeatureFldsEN objField_Sort = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                            switch (objField_Sort.ObjFieldTab().ObjDataTypeAbbr1().TypeScriptType)
                            {
                                case "string":
                                    strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0}.localeCompare(y.{0}));",
                                        objField_Sort.ObjFieldTab().PropertyName(this.IsFstLcase));
                                    break;
                                case "number":
                                case "boolean":
                                    strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0} - y.{0});",
                                        objField_Sort.ObjFieldTab().PropertyName(this.IsFstLcase));
                                    break;
                            }
                        }
                        if (objPrjTabENEx.IsUseCache_TS() == true)
                        {
                            //���ɹ����������
                            string strFilterCondition = objFuncParaLst.GeneFilterCondition();
                            strCodeForCs.Append(strFilterCondition);
                        }
                        strCodeForCs.AppendFormat("\r\n" + "BindDdl_ObjLst(strDdlName, arrObjLstSel, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                    ThisTabName4GC,
                                    strValueFieldName,
                                    strTextFieldName,
                                    objPrjTabENEx.TabCnName);

                        strCodeForCs.Append("\r\n" + "}");
                    }
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

        public string Gen_4WA_TabFeature_DdlBindFunction(List<string> arrCondFldId)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCheckEmpty = new StringBuilder();
            string strFuncName = "";
            try
            {
                List<clsTabFeatureEN> arrTabFeature = objPrjTabENEx.arrTabFeatureSet().Where(x => x.FeatureId == enumPrjFeature.Tab_BindDdl_0173).ToList();
                foreach (var objTabFeature in arrTabFeature)
                {
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objTabFeature, this.IsFstLcase, objPrjTabENEx);

                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    objFuncParaLst.AddParaByTabFeature(objTabFeature, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
                    objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para();
                    string strPrivFuncName_Additional = objFuncParaLst.GetCondFldLst();
                    string strCodeText_CheckEmpty = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName,
                        objTabFeature.FuncNameJs, true, this, this.strBaseUrl);
                    string strFuncRemark = objFuncParaLst.GetFuncRemark();
                    strFuncPara = strFuncPara == "" ? "" : ", " + strFuncPara;

                    if (objTabFeature == null) continue;
                    if (objTabFeature.IsNeedGC == false)
                    {
                        strCodeForCs.Append("\r\n//�ñ��������ܲ���Ҫ����;");
                        continue;
                    }
                    if (objTabFeature.IsExtendedClass == true)
                    {
                        strCodeForCs.Append("\r\n//�ñ��������ܽ���ʹ������չ��;");
                        continue;
                    }
                    if (objTabFeature4Ddl.IsHasErr)
                    {
                        throw new Exception(objTabFeature4Ddl.ErrMsg_Ddl);
                    }

                    
                    //��0��:�ѿؼ���������ComboBoxת����ComboBox
                    //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[BindDdl_{0}Cache]����;(in {clsStackTrace.GetCurrClassFunction()}",
                    //strValueFieldName);
                    var strIsCache = "Cache";
                    if (objPrjTabENEx.IsUseCache_TS() == false) strIsCache = "";


                    strCodeForCs.Append("\r\n/**");
                    strCodeForCs.Append("\r\n * �󶨻���Web��������");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                    strCodeForCs.Append("\r\n" + objTabFeature4Ddl.FuncRemark);
                    strCodeForCs.Append("\r\n*/");

                    string strFuncName_Temp = $"BindDdl_{objTabFeature4Ddl.ValueFieldName}{strIsCache}";

                    strCodeForCs.Append("\r\n" + $"export  async function {objTabFeature4Ddl.FuncName_Js_Gc}(strDdlName: string {strFuncPara})");

                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"//const strThisFuncName = this.{objTabFeature4Ddl.FuncName_Js_Gc}.name;");

                    strCodeForCs.AppendLine(sbCheckEmpty.ToString());

                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(strDdlName);",
    ThisTabName4GC, objTabFeature4Ddl.ValueFieldName, objTabFeature4Ddl.TextFieldName);
                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{{0}} ������!(In {0})\", strDdlName);", strFuncName_Temp);
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                    strCodeForCs.AppendFormat("\r\n" + "//console.log(\"��ʼ��BindDdl_{0}Cache\");", objTabFeature4Ddl.ValueFieldName);

                    if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
                    {
                        string strConditionStr = objFuncParaLst.GeneConditionStr();
                        strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel: Array<cls{objTabFeature4Ddl.TabName4GC}EN> = await {thisWA_F(WA_F.GetObjLstAsync)}({strConditionStr});");
                    }
                    else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
                    {
                        strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel: Array<cls{objTabFeature4Ddl.TabName4GC}EN> = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName});");

                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel: Array<cls{objTabFeature4Ddl.TabName4GC}EN> = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                    }

                    if (string.IsNullOrEmpty(objTabFeature4Ddl.SortStr) == false)
                    {
                        strCodeForCs.Append("\r\n" + $"arrObjLstSel = arrObjLstSel.sort({objTabFeature4Ddl.SortStr});");
                    }
                    if (objPrjTabENEx.IsUseCache_TS() == true)
                    {
                        //���ɹ����������
                        strCodeForCs.Append(objTabFeature4Ddl.FilterCondition);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "BindDdl_ObjLst(strDdlName, arrObjLstSel, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                ThisTabName4GC,
                                objTabFeature4Ddl.ValueFieldName,
                                objTabFeature4Ddl.TextFieldName,
                                objPrjTabENEx.TabCnName);

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



        public string Gen_4WA_TabFeature_DdlBindFunctionInDivBak20240502()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("BindDdl[�ֶ���]InDivCache",
              ThisTabName4GC);
            Re_objFunction4Code.FuncCHName4Code = string.Format("�󶨻���Web��������,��ĳһ���µ�������",
                  ThisTabName4GC);

            List<string> arrCondFldName = new List<string>();


            List<string> arrCacheFldName = new List<string>();

            StringBuilder strCodeForCs = new StringBuilder();

            string strFuncName = "";
            try
            {
                //Ԥ��� 
                List<clsTabFeatureEN> arrTabFeature = objPrjTabENEx.arrTabFeatureSet().Where(x => x.FeatureId == enumPrjFeature.Tab_BindDdl_0173).ToList();
                if (arrTabFeature.Count == 0)
                {
                    return "/* �ñ����������û������,����Ҫ����������󶨺�����*/";
                }

                //���ÿһ������--������
                foreach (var objTabFeature_BindDdl in arrTabFeature)
                {
                    List<string> arrCondFldId = objTabFeature_BindDdl.GetCondFldIdLst();
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature_BindDdl.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
                    objFuncParaLst.AddParaByTabFeature(objTabFeature_BindDdl, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
                    objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para();
                    string strPrivFuncName_Additional = objFuncParaLst.GetCondFldLst();
                    string strCodeText_CheckEmpty = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName,
                        objTabFeature_BindDdl.FuncNameJs, true, this, this.strBaseUrl);

                    string strFuncRemark = objFuncParaLst.GetFuncRemark();
                    strFuncPara = strFuncPara == "" ? "" : "," + strFuncPara;

                    //Ԥ���
                    if (objTabFeature_BindDdl == null) continue;
                    //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[{objTabFeature_BindDdl.FuncNameJs}Cache]����;(in {clsStackTrace.GetCurrClassFunction()} )";
                    var strIsCache = "Cache";
                    if (objPrjTabENEx.IsUseCache_TS() == false) strIsCache = "";
                    if (objTabFeature_BindDdl.IsNeedGC == false)
                    {
                        strCodeForCs.Append("\r\n//(IsNeedGC == false)�ñ��������ܲ���Ҫ����;");
                        continue;
                    }
                    if (objTabFeature_BindDdl.IsExtendedClass == true)
                    {
                        strCodeForCs.Append("\r\n//(IsExtendedClass == true)�ñ��������ܽ���ʹ������չ��;");
                        continue;
                    }

                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�������ֶ�,������Ӱ���������!");
                    }
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�йؼ��ֶ�,������Ӱ���������!");
                    }

                    string strFuncName_Temp = $"{objTabFeature_BindDdl.FuncNameJs}{strIsCache}";

                    //����Ԥ�������
                    Re_objFunction4Code.FuncName4Code = string.Format("Cache",
        objTabFeature_BindDdl.FuncNameJs);

                    clsTabFeatureFldsEN objField_Key = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
                    clsTabFeatureFldsEN objField_Name = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.NameField_03);
                    string strTextFieldName = objField_Name.ObjFieldTab().FldName;
                    string strValueFieldName = objField_Key.ObjFieldTab().FldName;

                    //��0��:�ѿؼ���������ComboBoxת����ComboBox

                    if (strValueFieldName == "" || strTextFieldName == "") continue;

                    //���ɹ����������
                    string strFilterCondition = objFuncParaLst.GeneFilterCondition();


                    var strLetOrConst = "const";
                    var strLetOrConst2 = "const";
                    if (string.IsNullOrEmpty(strFilterCondition) == false)
                    {
                        strLetOrConst = "let";
                    }
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                    {
                        strLetOrConst = "let";
                        strLetOrConst2 = "let";
                    }


                    strCodeForCs.Append("\r\n/**");
                    strCodeForCs.Append("\r\n * �󶨻���Web��������,��ĳһ���µ�������");
                    strCodeForCs.AppendFormat("\r\n * ({0})-pyf", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                    //���������������ĺ���˵��
                    strCodeForCs.Append("\r\n" + strFuncRemark);
                    strCodeForCs.Append("\r\n*/");

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);

                    strCodeForCs.Append("\r\n" + $"export  async function {this.tabNameHead}{strFuncName_Temp}(objDiv: HTMLDivElement, strDdlName: string {strFuncPara})");

                    Re_objFunction4Code.FuncName4Code = $"export  async function {this.tabNameHead}{strFuncName_Temp}(objDiv: HTMLDivElement, strDdlName: string {strFuncPara})";

                    strCodeForCs.Append("\r\n" + "{");
                    //              strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"{0}Cache\";", objTabFeature_BindDdl.FuncNameJs,
                    //objKeyField.FldName);
                    //���ɼ�����������Ƿ�Ϊ�յĴ���
                    strCodeForCs.AppendLine(strCodeText_CheckEmpty);


                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(strDdlName);",
    ThisTabName4GC, strValueFieldName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{{0}} ������!(In {0})\", strDdlName);",
                        objTabFeature_BindDdl.FuncNameJs);
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                    strCodeForCs.AppendFormat("\r\n" + "//console.log(\"��ʼ��{0}Cache\");", objTabFeature_BindDdl.FuncNameJs);
                    //strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
                    //                  objPrjTabENEx.TabCnName);

                    //                strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", cls{0}EN.con_{1}); ",
                    //ThisTabName4GC, strValueFieldName);
                    if (objPrjTabENEx.IsUseCache_TS() == false)
                    {
                        string strConditionStr = objFuncParaLst.GeneConditionStr();
                        strCodeForCs.Append("\r\n" + strConditionStr);
                        strCodeForCs.Append("\r\n" + $"{strLetOrConst2} arrObjLstSel = await {thisWA_F(WA_F.GetObjLstAsync)}(strCondition);");
                    }
                    else
                    {
                        if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
                        {
                            strCodeForCs.Append("\r\n" + $"{strLetOrConst} arrObjLstSel = await {thisWA_F(WA_F.GetObjLst_Cache)}();");

                        }
                        else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
                        {
                            string strPrivFuncName = thisCacheClassify_TS.PriVarName;
                            arrCacheFldName.Add(thisCacheClassify_TS.FldName);
                            strCodeForCs.Append("\r\n" + $"{strLetOrConst} arrObjLstSel = await {thisWA_F(WA_F.GetObjLst_Cache)}({strPrivFuncName});");

                        }
                        else
                        {
                            string strPrivFuncName = thisCacheClassify_TS.PriVarName;
                            string strPrivFuncName2 = thisCacheClassify_TS.PriVarName2;
                            arrCacheFldName.Add(thisCacheClassify_TS.FldName);
                            arrCacheFldName.Add(thisCacheClassify_TS.FldName2);

                            strCodeForCs.Append("\r\n" + $"{strLetOrConst} arrObjLstSel = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");

                        }
                    }
                    strCodeForCs.Append("\r\n" + "if (arrObjLstSel == null) return;");

                    //���ɹ����������
                    //string strFilterCondition = objFuncParaLst.GeneFilterCondition();
                    if (objPrjTabENEx.IsUseCache_TS() == true)
                    {
                        strCodeForCs.Append(strFilterCondition);
                    }
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                    {
                        clsTabFeatureFldsEN objField_Sort = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                        switch (objField_Sort.ObjFieldTab().TypeScriptType())
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0}.localeCompare(y.{0}));",
                                    objField_Sort.ObjFieldTab().PropertyName(this.IsFstLcase));
                                break;
                            case "number":
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0} - y.{0});",
                                    objField_Sort.ObjFieldTab().PropertyName(this.IsFstLcase));
                                break;
                        }
                    }

                    if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindDdl_ObjLstInDivObj(objDiv, strDdlName, arrObjLstSel, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                    ThisTabName4GC,
                                    strValueFieldName,
                                    strTextFieldName,
                                    objPrjTabENEx.TabCnName);
                        AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "BindDdl_ObjLstInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindDdl_ObjLstInDivObj_V(objDiv, strDdlName, arrObjLstSel, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                ThisTabName4GC,
                                strValueFieldName,
                                strTextFieldName,
                                objPrjTabENEx.TabCnName);
                        AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "BindDdl_ObjLstInDivObj_V", enumImportObjType.CustomFunc, this.strBaseUrl);

                    }

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

        public string Gen_4WA_TabFeature_DdlBindFunctionInDiv()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("BindDdl[�ֶ���]InDivCache",
              ThisTabName4GC);
            Re_objFunction4Code.FuncCHName4Code = string.Format("�󶨻���Web��������,��ĳһ���µ�������",
                  ThisTabName4GC);

            List<string> arrCondFldName = new List<string>();


            List<string> arrCacheFldName = new List<string>();

            StringBuilder strCodeForCs = new StringBuilder();

            string strFuncName = "";
            try
            {
                //Ԥ��� 
                List<clsTabFeatureEN> arrTabFeature = objPrjTabENEx.arrTabFeatureSet().Where(x => x.FeatureId == enumPrjFeature.Tab_BindDdl_0173).ToList();
                if (arrTabFeature.Count == 0)
                {
                    return "/* �ñ����������û������,����Ҫ����������󶨺�����*/";
                }

                //���ÿһ������--������
                foreach (var objTabFeature in arrTabFeature)
                {
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objTabFeature, this.IsFstLcase, objPrjTabENEx);

                    List<string> arrCondFldId = objTabFeature.GetCondFldIdLst();
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
                    objFuncParaLst.AddParaByTabFeature(objTabFeature, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
                    objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para();
                    string strPrivFuncName_Additional = objFuncParaLst.GetCondFldLst();
                    string strCodeText_CheckEmpty = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName,
                        objTabFeature.FuncNameJs, true, this, this.strBaseUrl);

                    string strFuncRemark = objFuncParaLst.GetFuncRemark();
                    strFuncPara = strFuncPara == "" ? "" : "," + strFuncPara;

                    //Ԥ���
                    if (objTabFeature == null) continue;
                    //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[{objTabFeature_BindDdl.FuncNameJs}Cache]����;(in {clsStackTrace.GetCurrClassFunction()} )";

                    if (objTabFeature.IsNeedGC == false)
                    {
                        strCodeForCs.Append("\r\n//(IsNeedGC == false)�ñ��������ܲ���Ҫ����;");
                        continue;
                    }
                    if (objTabFeature.IsExtendedClass == true)
                    {
                        strCodeForCs.Append("\r\n//(IsExtendedClass == true)�ñ��������ܽ���ʹ������չ��;");
                        continue;
                    }

                    if (objTabFeature.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�������ֶ�,������Ӱ���������!");
                    }
                    if (objTabFeature.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�йؼ��ֶ�,������Ӱ���������!");
                    }

                    //string strFuncName_Temp = $"{objTabFeature.FuncNameJs}{strIsCache}";

                    //����Ԥ�������
                    Re_objFunction4Code.FuncName4Code = string.Format("Cache",
        objTabFeature.FuncNameJs);


                    //��0��:�ѿؼ���������ComboBoxת����ComboBox
                    if (objTabFeature4Ddl.IsHasErr)
                    {
                        throw new Exception(objTabFeature4Ddl.ErrMsg_Ddl);
                    }

                    //���ɹ����������
                    string strFilterCondition = objFuncParaLst.GeneFilterCondition();
                    
                    strCodeForCs.Append("\r\n/**");
                    strCodeForCs.Append("\r\n * �󶨻���Web��������,��ĳһ���µ�������");
                    strCodeForCs.AppendFormat("\r\n * ({0})-pyf", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                    //���������������ĺ���˵��
                    strCodeForCs.Append("\r\n" + strFuncRemark);
                    strCodeForCs.Append("\r\n*/");

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);

                    strCodeForCs.Append("\r\n" + $"export  async function {objTabFeature4Ddl.FuncName_Js_Gc}(objDiv: HTMLDivElement, strDdlName: string {strFuncPara})");

                    Re_objFunction4Code.FuncName4Code = $"export  async function {objTabFeature4Ddl.FuncName_Js_Gc}(objDiv: HTMLDivElement, strDdlName: string {strFuncPara})";

                    strCodeForCs.Append("\r\n" + "{");
                    //              strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"{0}Cache\";", objTabFeature_BindDdl.FuncNameJs,
                    //objKeyField.FldName);
                    //���ɼ�����������Ƿ�Ϊ�յĴ���
                    strCodeForCs.AppendLine(strCodeText_CheckEmpty);

                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(strDdlName);",
    objTabFeature4Ddl.TabName4GC, objTabFeature4Ddl.ValueFieldName, objTabFeature4Ddl.TextFieldName);
                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{{0}} ������!(In {0})\", strDdlName);",
                        objTabFeature.FuncNameJs);
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                    strCodeForCs.AppendFormat("\r\n" + "//console.log(\"��ʼ��{0}Cache\");", objTabFeature.FuncNameJs);

                    if (objPrjTabENEx.IsUseCache_TS() == false)
                    {
                        string strConditionStr = objFuncParaLst.GeneConditionStr();
                        strCodeForCs.Append("\r\n" + strConditionStr);
                        strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst2} arrObjLstSel = await {thisWA_F(WA_F.GetObjLstAsync)}(strCondition);");
                    }
                    else
                    {
                        if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
                        {
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {thisWA_F(WA_F.GetObjLst_Cache)}();");
                        }
                        else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
                        {
                            string strPrivFuncName = thisCacheClassify_TS.PriVarName;
                            arrCacheFldName.Add(thisCacheClassify_TS.FldName);
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {thisWA_F(WA_F.GetObjLst_Cache)}({strPrivFuncName});");

                        }
                        else
                        {
                            string strPrivFuncName = thisCacheClassify_TS.PriVarName;
                            string strPrivFuncName2 = thisCacheClassify_TS.PriVarName2;
                            arrCacheFldName.Add(thisCacheClassify_TS.FldName);
                            arrCacheFldName.Add(thisCacheClassify_TS.FldName2);

                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");

                        }
                    }
                    strCodeForCs.Append("\r\n" + "if (arrObjLstSel == null) return;");

                    //���ɹ����������
                    //string strFilterCondition = objFuncParaLst.GeneFilterCondition();
                    if (objPrjTabENEx.IsUseCache_TS() == true)
                    {
                        strCodeForCs.Append(strFilterCondition);
                    }
                    if (objTabFeature.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                    {
                        clsTabFeatureFldsEN objField_Sort = objTabFeature.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                        switch (objField_Sort.ObjFieldTab().TypeScriptType())
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0}.localeCompare(y.{0}));",
                                    objField_Sort.ObjFieldTab().PropertyName(this.IsFstLcase));
                                break;
                            case "number":
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0} - y.{0});",
                                    objField_Sort.ObjFieldTab().PropertyName(this.IsFstLcase));
                                break;
                        }
                    }

                    if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindDdl_ObjLstInDivObj(objDiv, strDdlName, arrObjLstSel, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                    objTabFeature4Ddl.TabName4GC,
                                    objTabFeature4Ddl.ValueFieldName,
                                    objTabFeature4Ddl.TextFieldName,
                                    objPrjTabENEx.TabCnName);
                        AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "BindDdl_ObjLstInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindDdl_ObjLstInDivObj_V(objDiv, strDdlName, arrObjLstSel, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                objTabFeature4Ddl.TabName4GC,
                                objTabFeature4Ddl.ValueFieldName,
                                objTabFeature4Ddl.TextFieldName,
                                objPrjTabENEx.TabCnName);
                        AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "BindDdl_ObjLstInDivObj_V", enumImportObjType.CustomFunc, this.strBaseUrl);

                    }

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


        public string Gen_4WA_TabFeature_GetDdlData()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("BindDdl[�ֶ���]InDivCache",
              ThisTabName4GC);
            Re_objFunction4Code.FuncCHName4Code = string.Format("�󶨻���Web��������,��ĳһ���µ�������",
                  ThisTabName4GC);

            List<string> arrCondFldName = new List<string>();


            List<string> arrCacheFldName = new List<string>();

            StringBuilder strCodeForCs = new StringBuilder();

            string strFuncName = "";
            try
            {
                //Ԥ��� 
                List<clsTabFeatureEN> arrTabFeature = objPrjTabENEx.arrTabFeatureSet().Where(x => x.FeatureId == enumPrjFeature.Tab_BindDdl_0173).ToList();
                if (arrTabFeature.Count == 0)
                {
                    return "/* �ñ����������û������,����Ҫ����������󶨺�����*/";
                }

                //���ÿһ������--������
                foreach (var objTabFeature in arrTabFeature)
                {
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objTabFeature, this.IsFstLcase, objPrjTabENEx);

                    List<string> arrCondFldId = objTabFeature.GetCondFldIdLst();
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
                    objFuncParaLst.AddParaByTabFeature(objTabFeature, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
                    objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para();
                    string strPrivFuncName_Additional = objFuncParaLst.GetCondFldLst();
                    string strCodeText_CheckEmpty = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName,
                        objTabFeature.FuncNameJs, true, this, this.strBaseUrl);

                    string strFuncRemark = objFuncParaLst.GetFuncRemark();
                    //strFuncPara = strFuncPara == "" ? "" : "," + strFuncPara;

                    //Ԥ���
                    if (objTabFeature == null) continue;
                    //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[{objTabFeature_BindDdl.FuncNameJs}Cache]����;(in {clsStackTrace.GetCurrClassFunction()} )";

                    if (objTabFeature.IsNeedGC == false)
                    {
                        strCodeForCs.Append("\r\n//(IsNeedGC == false)�ñ��������ܲ���Ҫ����;");
                        continue;
                    }
                    if (objTabFeature.IsExtendedClass == true)
                    {
                        strCodeForCs.Append("\r\n//(IsExtendedClass == true)�ñ��������ܽ���ʹ������չ��;");
                        continue;
                    }

                    if (objTabFeature.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�������ֶ�,������Ӱ���������!");
                    }
                    if (objTabFeature.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�йؼ��ֶ�,������Ӱ���������!");
                    }

                    //string strFuncName_Temp = $"{objTabFeature.FuncNameJs}{strIsCache}";

                    //����Ԥ�������
                    Re_objFunction4Code.FuncName4Code = string.Format("Cache",
        objTabFeature.FuncNameJs);


                    //��0��:�ѿؼ���������ComboBoxת����ComboBox
                    if (objTabFeature4Ddl.IsHasErr)
                    {
                        throw new Exception(objTabFeature4Ddl.ErrMsg_Ddl);
                    }

                    //���ɹ����������
                    string strFilterCondition = objFuncParaLst.GeneFilterCondition();

                    strCodeForCs.Append("\r\n/**");
                    strCodeForCs.Append("\r\n * �󶨻���Web��������,��ĳһ���µ�������");
                    strCodeForCs.AppendFormat("\r\n * ({0})-pyf", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                    //���������������ĺ���˵��
                    strCodeForCs.Append("\r\n" + strFuncRemark);
                    strCodeForCs.Append("\r\n*/");

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);
                    string strByCondition = "";
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.ConditionFieldName) == false)
                        strByCondition = $"By{objTabFeature4Ddl.ConditionFieldName}";
                    strCodeForCs.Append("\r\n" + $"export  async function " + this.tabNameHead + $"GetArr{objTabFeature4Ddl.TabName4GC}{strByCondition}({strFuncPara})");

                    Re_objFunction4Code.FuncName4Code = $"export  async function " + this.tabNameHead + $"GetArr{objTabFeature4Ddl.TabName4GC}{strByCondition}( {strFuncPara})";

                    strCodeForCs.Append("\r\n" + "{");
                    //              strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"{0}Cache\";", objTabFeature_BindDdl.FuncNameJs,
                    //objKeyField.FldName);
                    //���ɼ�����������Ƿ�Ϊ�յĴ���
                    strCodeForCs.AppendLine(strCodeText_CheckEmpty);


                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                    strCodeForCs.AppendFormat("\r\n" + "//console.log(\"��ʼ��{0}Cache\");", objTabFeature.FuncNameJs);
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = new Array<cls{objTabFeature4Ddl.TabName4GC}EN>();");

                    if (objPrjTabENEx.IsUseCache_TS() == false)
                    {
                        string strConditionStr = objFuncParaLst.GeneConditionStr();
                        strCodeForCs.Append("\r\n" + strConditionStr);
                        strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst2} arrObjLstSel = await {thisWA_F(WA_F.GetObjLstAsync)}(strCondition);");
                    }
                    else
                    {
                        if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
                        {
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {thisWA_F(WA_F.GetObjLst_Cache)}();");
                        }
                        else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
                        {
                            string strPrivFuncName = thisCacheClassify_TS.PriVarName;
                            arrCacheFldName.Add(thisCacheClassify_TS.FldName);
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {thisWA_F(WA_F.GetObjLst_Cache)}({strPrivFuncName});");

                        }
                        else
                        {
                            string strPrivFuncName = thisCacheClassify_TS.PriVarName;
                            string strPrivFuncName2 = thisCacheClassify_TS.PriVarName2;
                            arrCacheFldName.Add(thisCacheClassify_TS.FldName);
                            arrCacheFldName.Add(thisCacheClassify_TS.FldName2);

                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {thisWA_F(WA_F.GetObjLst_Cache)}({thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");

                        }
                    }
                    strCodeForCs.Append("\r\n" + "if (arrObjLstSel == null) return null;");

                    //���ɹ����������
                    //string strFilterCondition = objFuncParaLst.GeneFilterCondition();
                    if (objPrjTabENEx.IsUseCache_TS() == true)
                    {
                        strCodeForCs.Append(strFilterCondition);
                    }
                    if (objTabFeature.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                    {
                        clsTabFeatureFldsEN objField_Sort = objTabFeature.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                        switch (objField_Sort.ObjFieldTab().TypeScriptType())
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0}.localeCompare(y.{0}));",
                                    objField_Sort.ObjFieldTab().PropertyName(this.IsFstLcase));
                                break;
                            case "number":
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0} - y.{0});",
                                    objField_Sort.ObjFieldTab().PropertyName(this.IsFstLcase));
                                break;
                        }
                    }
                    strCodeForCs.Append("\r\n" + $"const obj0 = new cls{objTabFeature4Ddl.TabName4GC}EN();");
                    if (objTabFeature4Ddl.IsNumberType == true)
                    {
                        strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.ValueFieldName)} = 0;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.ValueFieldName)} = '0';");
                    }

                    strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.TextFieldName)} = '��ѡ��{clsString.FstLcaseS(objTabFeature4Ddl.TabCnName4GC)}...';");
                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC}.push(obj0);");
                    //���ɹ����������

                    strCodeForCs.Append("\r\n" + $"arrObjLstSel.forEach(x => arr{objTabFeature4Ddl.TabName4GC}.push(x));");

                    strCodeForCs.Append("\r\n" + $"return arr{objTabFeature4Ddl.TabName4GC};");

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


        public string Gen_4BL_Ts_CheckPropertyNew()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.Append("\r\n" + $"export  function {thisWA_F(WA_F.CheckPropertyNew)}(pobj{ThisTabName4GC}EN: cls{ThisTabName4GC}EN)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("CheckPropertyNew0", ThisTabName4GC, objKeyField.FldName);
            string strExplanation = "�ֶ�[{1}|{0}]����Ϊ��(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strCodeForCs.Append("\r\n//����ֶηǿ�, �����ݱ�Ҫ��ǳ��ǿյ��ֶ�,����Ϊ��!");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return "";//ֻ���Ͳ���Ҫ���

                if (objField.IsTabNullable == false
                    && objField.FieldTypeId != enumFieldType.KeyField_02
                    && objField.FieldTypeId != enumFieldType.Log_UpdDate_13)
                {
                    strCodeForCs.Append(inGen_CheckNull4Field_Ts(objField, strErrId, strFunctionName));
                }
            }

            //������Գ��ȴ���;
            strCodeForCs.Append(inGen_CheckFieldLength_Ts("CheckPropertyNew"));

            //����ֶε����������Ƿ���ȷ
            strCodeForCs.Append(inGen_CheckDataType_Ts(strFunctionName));

            //�������ֶγ���;

            strCodeForCs.Append(inGen_CheckFieldForeighKey_Ts("CheckPropertyNew"));


            strCodeForCs.Append("\r\n//����˵���ö����Ѿ�������,���治��Ҫ�ټ��,���Ƿ�!");

            //strCodeForCs.AppendFormat("\r\n pobj{0}EN.SetIsCheckProperty(true);", ThisTabName4GC);

            strCodeForCs.Append("\r\n}");


            ///������������Ƿ���ȷ-------------------------------------------;
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * רҵ����޸ļ�¼,�������ֶ�ֵ�Ƿ�Ϸ�,1)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.Append("\r\n" + $"export  function {thisWA_F(WA_F.CheckProperty4Update)}(pobj{ThisTabName4GC}EN: cls{ThisTabName4GC}EN)");
            strCodeForCs.Append("\r\n{");
            //������Գ��ȴ���;

            strCodeForCs.Append(inGen_CheckFieldLength_Ts("CheckProperty4Update"));

            //������������Ƿ���ȷ
            strCodeForCs.Append(inGen_CheckDataType_Ts("CheckProperty4Update"));

            //��������Ƿ�Null
            strFunctionName = string.Format("CheckProperty4Update", ThisTabName4GC, objKeyField.FldName);
            strExplanation = "�ֶ�[{1}|{0}]����Ϊ��(NULL)!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.Append("\r\n//��������Ƿ�ΪNull���߿�!");

            strCodeForCs.Append(inGen_CheckNull4Field_Ts(objPrjTabENEx.objKeyField0, strErrId, "CheckProperty4Update"));
            ///�������ֶγ���;

            strCodeForCs.Append(inGen_CheckFieldForeighKey_Ts("CheckProperty4Update"));

            //strCodeForCs.AppendFormat("\r\n pobj{0}EN.SetIsCheckProperty(true);", ThisTabName4GC);

            strCodeForCs.Append("\r\n}");

            ///������������Ƿ���ȷ ==  ==  == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_Ts_CopyObjToSimObj()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                //return "";
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ͬһ����Ķ���,���Ƶ���һ������(��)");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ����", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENT:Ŀ�����", ThisTabName4GC);
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "CopyObjToSimObj(obj{0}ENS: cls{0}EN , obj{0}ENT: cls{0}EN ): void ", ThisTabName4GC);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{2}); //{3}",
                      ThisTabName4GC, objField.ObjFieldTabENEx.FldName,

                      objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{2}(); //{3}",
                      ThisTabName4GC, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    ThisTabName4GC, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sfUpdFldSetStr = obj{0}ENS.updFldString; //ר�����ڼ�¼ĳ�ֶ������Ƿ��޸�",
                ThisTabName4GC);
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sfFldComparisonOp = obj{0}ENS.sfFldComparisonOp; //ר�����ڼ�¼��������ĳ�ֶεıȽ������",
                ThisTabName4GC);

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_Ts_GetObjFromSimObj()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ͬһ����Ķ���,���Ƶ���һ������(��)");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ����", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENT:Ŀ�����", ThisTabName4GC);
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetObjFromSimObj(obj{0}ENS: cls{0}EN_Sim ): cls{0}EN ", ThisTabName4GC);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n const obj{0}ENT: cls{0}EN = new cls{0}EN();", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}ENT, obj{0}ENS);", ThisTabName4GC);


            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", ThisTabName4GC);

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_Ts_CopyObjTo()
        {
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            //{
            //    return "";
            //}

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ͬһ����Ķ���,���Ƶ���һ������");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ����", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENT:Ŀ�����", ThisTabName4GC);
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "CopyObjTo(obj{0}ENS: cls{0}EN , obj{0}ENT: cls{0}EN ): void ", ThisTabName4GC);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      ThisTabName4GC, objField.ObjFieldTabENEx.FldName,
                      objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                      objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{2}(); //{3}",
                      ThisTabName4GC, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    ThisTabName4GC, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sfUpdFldSetStr = obj{0}ENS.updFldString; //sfUpdFldSetStr",
                ThisTabName4GC);
            }
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objPrjTabENEx"></param>
        /// <returns></returns>
        public string Gen_4BL_Ts_CombineConditionByCondObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n/**");
                strCodeForCs.Append("\r\n * �������������е��ֶ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n * @returns ������(strWhereCond)");
                strCodeForCs.Append("\r\n*/");
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetCombineCondition({1}: {0} ):string", ThisClsName4EN, ThisObjName4Cond);
                strCodeForCs.Append("\r\n" + "{");
                //          strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetCombineCondition\";", ThisTabName4GC,
                //objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");


                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {

                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {
                        case enumDataTypeAbbr.bit_03:
                            strCodeForCs.AppendFormat("\r\n" + "if (Object.prototype.hasOwnProperty.call(obj{0}Cond.dicFldComparisonOp, cls{0}EN.con_{1}) == true)",
                                 ThisTabName4GC,
                                        objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.{1} == true)",
                                        ThisTabName4GC,
                                  objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                            strCodeForCs.Append("\r\n" + "{");


                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0});",
                                     objField.ObjFieldTabENEx.FldName,
                                     ThisTabName4GC,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                 objField.ObjFieldTabENEx.FldName,
                                     ThisTabName4GC,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                            break;

                        case enumDataTypeAbbr.char_04:
                        case enumDataTypeAbbr.varchar_25:
                        case enumDataTypeAbbr.nvarchar_15:
                            strCodeForCs.AppendFormat("\r\n" + "if (Object.prototype.hasOwnProperty.call(obj{0}Cond.dicFldComparisonOp, cls{0}EN.con_{1}) == true)",
                      ThisTabName4GC,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strComparisonOp{2}:string = obj{0}Cond.dicFldComparisonOp[cls{0}EN.con_{1}];",
                                ThisTabName4GC,
                                objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} {{2}} '{{1}}'\", cls{2}EN.con_{0}, obj{2}Cond.{3}, strComparisonOp{1});",
                                 objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.FldName,
                                ThisTabName4GC, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.datetime_05:
                            strCodeForCs.AppendFormat("\r\n" + "if (Object.prototype.hasOwnProperty.call(obj{0}Cond.dicFldComparisonOp, cls{0}EN.con_{1}) == true)",
                      ThisTabName4GC,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strComparisonOp{1}:string = obj{0}Cond.dicFldComparisonOp[cls{0}EN.con_{1}];",
                                ThisTabName4GC,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} {{2}} '{{1}}'\", cls{1}EN.con_{0}, obj{1}Cond.{3}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                ThisTabName4GC, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.decimal_06:
                        case enumDataTypeAbbr.float_07:
                        case enumDataTypeAbbr.int_09:
                        case enumDataTypeAbbr.bigint_01:
                        case enumDataTypeAbbr.bigintidentity_26:


                            strCodeForCs.AppendFormat("\r\n" + "if (Object.prototype.hasOwnProperty.call(obj{0}Cond.dicFldComparisonOp, cls{0}EN.con_{1}) == true)",
                      ThisTabName4GC,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strComparisonOp{1}:string = obj{0}Cond.dicFldComparisonOp[cls{0}EN.con_{1}];",
                                ThisTabName4GC,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} {{2}} {{1}}\", cls{1}EN.con_{0}, obj{1}Cond.{3}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                ThisTabName4GC, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "//��������{0}({1})�ں���:[{2}]��û�д���!",
                                  objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                  clsStackTrace.GetCurrClassFunction());
                            break;
                    }
                }

                strCodeForCs.Append("\r\n" + " return strWhereCond;");

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


        /// <summary>
        /// ��ȡΨһ��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_GetUniquenessConditionString()
        {
            if (objPrjTabENEx.arrPrjConstraintSet().Count == 0) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;


                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n *��ȡΨһ��������(Uniqueness)--{0}({1}),����ΨһԼ������������",
                              ThisTabName4GC, objPrjTabENEx.TabCnName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                List<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId).ToList();

                foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                {
                    strCodeForCs.AppendFormat("\r\n * @param {0}: {1}(Ҫ��Ψһ���ֶ�)",
                            objField.ObjFieldTab().PrivFuncName1(), objField.ObjFieldTab().Caption);
                }

                strCodeForCs.Append("\r\n * @returns ������(strWhereCond)");
                strCodeForCs.Append("\r\n **/");



                strCodeForCs.Append("\r\n" + $"export  function {thisWA_F(WA_F.GetUniCondStr)}{strVersion}(obj{ThisTabName4GC}EN: cls{ThisTabName4GC}EN ):string");

                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");

                foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                {
                    //if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    strCodeForCs.AppendFormat("\r\n strWhereCond +=  Format(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                                objField.ObjFieldTab().FldName,
                                ThisTabName4GC, objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                }

                strCodeForCs.Append("\r\n" + " return strWhereCond;");
                strCodeForCs.Append("\r\n}");
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡΨһ��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_GetUniquenessConditionString4Update()
        {
            if (objPrjTabENEx.arrPrjConstraintSet().Count == 0) return "";

            StringBuilder strCodeForCs = new StringBuilder();
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n *��ȡΨһ��������(Uniqueness)--{0}({1}),����ΨһԼ������������",
                              ThisTabName4GC, objPrjTabENEx.TabCnName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                {
                    strCodeForCs.AppendFormat("\r\n * @param {0}: {1}(Ҫ��Ψһ���ֶ�)",
                            objField.ObjFieldTab().PrivFuncName1(), objField.ObjFieldTab().Caption);
                }

                strCodeForCs.Append("\r\n * @returns ������(strWhereCond)");
                strCodeForCs.Append("\r\n **/");

                strCodeForCs.Append("\r\n" + $"export  function {thisWA_F(WA_F.GetUniCondStr4Update)}{strVersion}(obj{ThisTabName4GC}EN: cls{ThisTabName4GC}EN ):string");

                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                var arrPrjTabFld_Key = clsPrjTabFldBLEx.GetPrimaryKeyObjLstByTabIdCache(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                foreach (var objInFor2 in arrPrjTabFld_Key)
                {
                    strCodeForCs.AppendFormat("\r\n" + " strWhereCond += Format(\" and {0} <> '{{0}}'\", obj{1}EN.{2});",
                                    objInFor2.ObjFieldTab().FldName,
                                    ThisTabName4GC, objInFor2.ObjFieldTab().PropertyName(this.IsFstLcase));
                }
                foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                {
                    //if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    strCodeForCs.AppendFormat("\r\n strWhereCond +=  Format(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                                objField.ObjFieldTab().FldName,
                                ThisTabName4GC, objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                }

                strCodeForCs.Append("\r\n" + " return strWhereCond;");
                strCodeForCs.Append("\r\n}");
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }




        public string Gen_4BL_Ts_GetSimObjFromObj()
        {
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            //{
            //    return "";
            //}
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ͬһ����Ķ���,���Ƶ���һ������(��)");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ����", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENT:Ŀ�����", ThisTabName4GC);
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetSimObjFromObj(obj{0}ENS: cls{0}EN): cls{0}EN_Sim ", ThisTabName4GC);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n const obj{0}ENT: cls{0}EN_Sim = new cls{0}EN_Sim();", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}ENT, obj{0}ENS);", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", ThisTabName4GC);

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_Ts_GetObjFromJsonObj()
        {
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            //{
            //    return "";
            //}
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��һ��JSON�Ķ���,���Ƶ���һ��ʵ�����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ����", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENT:Ŀ�����", ThisTabName4GC);
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetObjFromJsonObj(obj{0}ENS: cls{0}EN): cls{0}EN ", ThisTabName4GC);
            strCodeForCs.Append("\r\n{");
            //strCodeForCs.AppendFormat("\r\n if (obj{0}ENS == null) 1return null;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n const obj{0}ENT: cls{0}EN = new cls{0}EN();", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}ENT, obj{0}ENS);", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", ThisTabName4GC);

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_Ts_CopyObjFromSimObj()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                return "";
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ�򻯶���", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENT:Ŀ�����", ThisTabName4GC);
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "CopyObjFromSimObj(obj{0}ENS: cls{0}EN_Sim, obj{0}ENT: cls{0}EN): void ", ThisTabName4GC);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{2}); //{3}",
                      ThisTabName4GC, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{2}",
                      ThisTabName4GC,
                      objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{2}",
                    ThisTabName4GC, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                    objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_Ts_CopyObjFromSimObj4Upd()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                return "";
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����. ר������޸ļ�¼,�����ֶβŸ���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ�򻯶���", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENT:Ŀ�����", ThisTabName4GC);
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "CopyObjFromSimObj4Upd(obj{0}ENS: cls{0}EN_Sim, obj{0}ENT: cls{0}EN ): void", ThisTabName4GC);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n   const strsfUpdFldSetStr: string = obj{0}ENS.sfUpdFldSetStr;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n    const sstrFldSet: string[] = strsfUpdFldSetStr.split('|');");
            //strCodeForCs.Append("\r\n   var arrFldSet : Array<string> = new Array<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{2}); //{3}",
                      ThisTabName4GC, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{2}(); //{3}",
                      ThisTabName4GC,
                      objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                      objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (sstrFldSet.indexOf(cls{0}EN.con_{1})  >= 0)",
                         ThisTabName4GC, objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{2}",
                               ThisTabName4GC, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    strCodeForCs.Append("\r\n" + "}");

                }
            }
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        private string inGen_CheckDataType_Ts(string strFunctionName)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //����ֶε����������Ƿ���ȷ

            string strExplanation = "�ֶ�[{0}|{1}]��ֵ����{2}��,�Ƿ�,Ӧ��Ϊ��ֵ��!00";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "//����ֶε����������Ƿ���ȷ");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + ThisTabName4GC + "EN", this.IsFstLcase);

                string strDataTypeName = "";
                switch (objField.TypeScriptType)
                {
                    case "string":
                        strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({2}) == false && undefined !== {2} && tzDataType.isString(pobj{0}EN.{1}) === false)",
                            ThisTabName4GC,
                            objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "�ַ���";
                        break;
                    case "number":
                        strCodeForCs.AppendFormat("\r\n" + "if (null != {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                            ThisTabName4GC,
                            objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "��ֵ��";
                        break;
                    case "any":

                        strDataTypeName = "any��";
                        break;
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "if (null != {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                            ThisTabName4GC,
                            objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "if (null != {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          ThisTabName4GC,
                          objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "����";
                        break;
                    case "double":
                        strCodeForCs.AppendFormat("\r\n" + "if (null != {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          ThisTabName4GC,
                          objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "˫����";
                        break;
                    case "float":
                        strCodeForCs.AppendFormat("\r\n" + "if (null != {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          ThisTabName4GC,
                          objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "short":
                        strCodeForCs.AppendFormat("\r\n" + "if (null != {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          ThisTabName4GC,
                          objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "boolean":
                        strCodeForCs.AppendFormat("\r\n" + "if (null != {2} && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.{1}) === false)",
                         ThisTabName4GC,
                         objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "������";
                        break;
                    case "Date":
                        strCodeForCs.AppendFormat("\r\n" + "if (null != {2} && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.{1}) === false)",
                         ThisTabName4GC,
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
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n throw new Error(`(errid:{7})�ֶ�[{0}({4})]��ֵ:[${{pobj{3}EN.{4}}}], �Ƿ�,Ӧ��Ϊ{8}(In {2}({3}))!(cls{3}BL:{9})`);",
                           objField.ColCaption,
                           objField.ObjFieldTabENEx.FldLength,
                           objPrjTabENEx.TabCnName,
                           ThisTabName4GC,
                           objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                           "{", "}",
                           strErrId,
                           strDataTypeName,
                           strFunctionName);
                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }
        private string inGen_CheckNull4Field_Ts(clsPrjTabFldENEx objField, string strErrId, string strFunctionName)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + ThisTabName4GC + "EN", this.IsFstLcase);
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + ThisTabName4GC + "EN");


            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
            {
                return "";
            }

            if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03) return "";//�Զ����ӵ��ַ��;Ͳ���Ҫ���

            if (objField.FldOpTypeId == "0003")
            {

                strCodeForCs.AppendFormat("\r\n if (null === {0} ",
                    strPrivPropNameWithObjectName4Get);

                strCodeForCs.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.ToString()  ===  \"\" ",
                    strPrivPropNameWithObjectName4Get);
                if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                {
                    strCodeForCs.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {1}.toString()  ===  \"0\"",
                        strPrivPropNameWithObjectName4Get,
                        strPrivPropNameWithObjectName4Get);
                }
                strCodeForCs.Append("\r\n )");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n throw new Error(`(errid:{2})�ֶ�[{0}]����Ϊ��(IN {1})!(cls{3}BL:{4})`);",
                        objField.ColCaption,
                        objPrjTabENEx.TabCnName,
                        strErrId,
                        ThisTabName4GC,
                        strFunctionName);
                strCodeForCs.Append("\r\n}");
            }
            else
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "string")
                {
                    strCodeForCs.AppendFormat("\r\nif (IsNullOrEmpty({0}) === true ", strPrivPropNameWithObjectName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\nif (null === {0} ", strPrivPropNameWithObjectName);
                    strCodeForCs.AppendFormat("\r\n || {0} != null && {0}.toString()  ===  \"\"", strPrivPropNameWithObjectName);
                }
                if (objField.ObjFieldTab4CodeConv() != null && string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                {
                    strCodeForCs.AppendFormat("\r\n || {0}.toString()  ===  \"0\" ", strPrivPropNameWithObjectName);
                }
                strCodeForCs.Append(")");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n throw new Error(`(errid:{2})�ֶ�[{0}]����Ϊ��(In {1})!(cls{3}BL:{4})`);",
                            objField.ColCaption,
                            objPrjTabENEx.TabCnName,
                            strErrId,
                            ThisTabName4GC,
                            strFunctionName);
                strCodeForCs.Append("\r\n}");
            }

            return strCodeForCs.ToString();
        }
        private string inGen_CheckFieldLength_Ts(string strFunctionName)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = string.Format(strFuncName, ThisTabName4GC, objKeyField.FldName);
            string strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}11";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strCodeForCs.Append("\r\n//����ֶγ���, ���ַ����ֶγ��ȳ����涨�ĳ���,���Ƿ�!");


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���

                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + ThisTabName4GC + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + ThisTabName4GC + "EN");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                  && objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "string"
                  && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        AddImportClass("", "/PubFun/clsString.js", "GetStrLen", enumImportObjType.CustomFunc, strBaseUrl);
                        strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n throw new Error(1(errid:{7})�ֶ�[{0}({4})]�ĳ��Ȳ��ܳ���{1}(In {2}({3}))!ֵ:$(pobj{3}EN.{4}))(cls{3}BL:{8})`;",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        objPrjTabENEx.TabCnName,
                        ThisTabName4GC,
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                        "{", "}",
                        strErrId,
                        strFunctionName);
                        strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && GetStrLen({0}) > {1})",
                             strPrivPropNameWithObjectName,
                              objField.ObjFieldTabENEx.FldLength);
                        AddImportClass("", "/PubFun/clsString.js", "GetStrLen", enumImportObjType.CustomFunc, strBaseUrl);

                        strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n throw new Error(`(errid:{7})�ֶ�[{0}({4})]�ĳ��Ȳ��ܳ���{1}(In {2}({3}))!ֵ:${{pobj{3}EN.{4}}}(cls{3}BL:{8})`);",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        objPrjTabENEx.TabCnName,
                        ThisTabName4GC,
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                        "{", "}",
                        strErrId,
                        strFunctionName);
                        strCodeForCs.Append("\r\n}");
                    }
                }
            }

            return strCodeForCs.ToString();
        }


        private string inGen_CheckFieldForeighKey_Ts(string strFunctionName)
        {
            StringBuilder strCodeForCs = new StringBuilder();


            string strExplanation = "�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!33";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strCodeForCs.Append("\r\n//������, ��Ϊ���Ӧ�ú��������ֶγ�����һ����, ����һ��,���Ƿ�!");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + ThisTabName4GC + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + ThisTabName4GC + "EN");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && GetStrLen({0}) != {1})",
                             strPrivPropNameWithObjectName4Get,
                              objField.ObjFieldTabENEx.FldLength);
                        strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n throw (\"(errid:{3})�ֶ�[{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}(In {2})!(cls{4}BL:CheckPropertyNew)\");",
                              objField.ColCaption,
                              objField.ObjFieldTabENEx.FldLength,
                              objPrjTabENEx.TabCnName,
                              strErrId,
                              ThisTabName4GC);
                        strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && {0} != '[nuull]' && GetStrLen({0}) !=  {1})",
                            strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength);
                        strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n throw (\"(errid:{3})�ֶ�[{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}(In {2})!(cls{4}BL:CheckPropertyNew)\");",
                                 objField.ColCaption,
                                 objField.ObjFieldTabENEx.FldLength,
                                 objPrjTabENEx.TabCnName,
                              strErrId,
                              ThisTabName4GC);
                        strCodeForCs.Append("\r\n}");
                    }
                }
            }
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getRecObjByJSONStr()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ��һ��JSON��ת��Ϊһ������");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param strJSON:��Ҫת����JSON��",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @returns ����һ�����ɵĶ���",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetObjByJSONStr (strJSON: string): cls{0}EN",
                  ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            //      strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjByJSONStr\";", ThisTabName4GC,
            //objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "let pobj{0}EN = new cls{0}EN();",
              ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "if (strJSON === \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return pobj{0}EN;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //  var data : NSData! = NSJSONSerialization.dataWithJSONObject(strJSON, options: []);
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN = JSON.parse(strJSON);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "catch(objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return pobj{0}EN;",
                    ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return pobj{0}EN;",
                    ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getJSONStrByRecObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ��һ������ת��Ϊһ��JSON��");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param strJSON:��Ҫת����JSON��",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @returns ����һ�����ɵĶ���",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetJSONStrByObj (pobj{0}EN: cls{0}EN): string",
                  ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            //      strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetJSONStrByObj\";", ThisTabName4GC,
            //objKeyField.FldName);
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.sfUpdFldSetStr = pobj{0}EN.updFldString;",
                    ThisTabName4GC);
            }
            strCodeForCs.Append("\r\n" + "let strJson = \"\";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strJson = JSON.stringify(pobj{0}EN);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strEx = GetExceptionStr(objException);");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(strEx);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (strJson == undefined) return \"\";");
            strCodeForCs.Append("\r\n" + "else return strJson;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getDictionaryObjByRecObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ��һ������ת��Ϊһ��JSON��");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param strJSON:��Ҫת����JSON��",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @returns ����һ�����ɵĶ���",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "GetDictionaryObjByObj (pobj{0}EN: cls{0}EN)",
                  ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetDictionaryObjByObj\";", ThisTabName4GC,
      objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.sfUpdFldSetStr = pobj{0}EN.updFldString;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const objDict;");
            strCodeForCs.Append("\r\n" + "objDict = NSMutableDictionary();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
                {
                    case "Int32":
                        strCodeForCs.AppendFormat("\r\n" + "objDict.setValue(String(pobj{0}EN.{1}), forKey: cls{0}EN.con_{1});",
                             ThisTabName4GC,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "objDict.setValue(pobj{0}EN.{1}, forKey: cls{0}EN.con_{1});",
                             ThisTabName4GC,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "objDict.setValue(pobj{0}EN.sfUpdFldSetStr, forKey: \"sfUpdFldSetStr\");",
                 ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "return objDict;");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ��һ��JSON��ת��Ϊһ�������б�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getObjLstByJSONStr()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ��һ��JSON��ת��Ϊһ�������б�");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param strJSON:��Ҫת����JSON��",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @returns ����һ�����ɵĶ����б�",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetObjLstByJSONStr (strJSON: string): Array<cls{0}EN>",
                  ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            //      strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByJSONStr\";", ThisTabName4GC,
            //objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLst = new Array<cls{0}EN>();",
              ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "if (strJSON === \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = JSON.parse(strJSON);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "catch(objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                    ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_Ts_getObjLstByJSONObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ��һ��JSON�����б�ת��Ϊһ��ʵ������б�");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ObjLstS:��Ҫת����JSON�����б�",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @returns ����һ�����ɵĶ����б�",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "GetObjLstByJSONObjLst (arr{0}ObjLstS: Array<cls{0}EN>): Array<cls{0}EN>",
                  ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            //      strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByJSONObjLst\";", ThisTabName4GC,
            //objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n if (arr{0}ObjLstS == null) 1return null;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = new Array<cls{0}EN>();",
              ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLstS) {{",
                    ThisTabName4GC);
            strCodeForCs.Append($"\r\n" + $"const obj1 = {thisWA_F(WA_F.GetObjFromJsonObj)}(objInFor);");
            strCodeForCs.Append("\r\n" + "if (obj1 == null) continue;");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.push(obj1);",
                    ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");



            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                    ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Ts_func()
        {
            string strInFldNameLst = clsPubFun4GC.GenInFldNameLst(objPrjTabENEx);
            string strInValueLst = clsPubFun4GC.GenInValueLst(objPrjTabENEx);
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function {0}_func({1} , strOutFldName:string ,  strInValue: {2}) ",
            this.tabNameHead, strInFldNameLst, "");

            Re_objFunction4Code.FuncCHName4Code = "ӳ�亯�������ݱ�ӳ��������ֶ�ֵ,ӳ�������ֶ�ֵ.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[func]����;(in {clsStackTrace.GetCurrClassFunction()} )";

            string strBy = objKeyField.FldName;
            if (objPrjTabENEx.arrKeyFldSet.Count > 1) strBy = "KeyLst";
            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCheckEmpty = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ӳ�亯�������ݱ�ӳ��������ֶ�ֵ,ӳ�������ֶ�ֵ");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            string strInValueType = "string";
            string strFuncName_Temp = string.Format("func");

            if (objKeyField.IsNumberType())
            {
                strInValueType = "number";
            }
            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            string strFuncAddiPara = clsPubFun4GC.Gen_WApi_Ts_GetFuncAddiPara(objPrjTabENEx);
            string strFuncAddiParam = clsPubFun4GC.Gen_WApi_Ts_GetFuncAddiParam(objPrjTabENEx);


            strCodeForCs.Append("\r\n * @param strInFldName:�����ֶ���");
            strCodeForCs.Append("\r\n * @param strOutFldName:����ֶ���");
            strCodeForCs.Append("\r\n * @param strInValue:�����ֶ�ֵ");
            strCodeForCs.Append(strFuncAddiParam);
            strCodeForCs.AppendFormat("\r\n * @returns ����һ������ֶ�ֵ",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function {0}func({1} , strOutFldName:string , {2} {3})",
                 this.tabNameHead, strInFldNameLst, strInValueLst, strFuncAddiPara);

            if (thisCacheClassify_TS.IsHasCacheClassfyFld == true && arrPrjmaryKeyFldName.Contains(thisCacheClassify_TS.FldName) == false)
            {
                sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName + "Classfy",
                                   thisCacheClassify_TS.TypeScriptType,
                    thisCacheClassify_TS.DataTypeId,
                                   this.ClsName, strFuncName_Temp,
                                   thisCacheClassify_TS.FldLength,
                                   thisCacheClassify_TS.DataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));
            }

            if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == true && arrPrjmaryKeyFldName.Contains(thisCacheClassify_TS.FldName2) == false)
            {
                sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName2 + "Classfy",
                                   thisCacheClassify_TS.TypeScriptType2,
                    thisCacheClassify_TS.DataTypeId2,
                                   this.ClsName, strFuncName_Temp,
                                   thisCacheClassify_TS.FldLength2,
                                   thisCacheClassify_TS.DataTypeId2 == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));
            }
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function {0}_func({1}, strOutFldName:string , {2} {3})",
                     this.tabNameHead, strInFldNameLst, strInValueLst, strFuncAddiPara);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "//const strThisFuncName = \"func\";", ThisTabName4GC,
      objKeyField.FldName);
            strCodeForCs.AppendLine(sbCheckEmpty.ToString());
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                string strIndex = "";
                if (objPrjTabENEx.arrKeyFldSet.Count > 1)
                {
                    strIndex = (intIndex + 1).ToString();
                }
                strCodeForCs.AppendFormat("\r\n" + "if (strInFldName{0} != cls{1}EN.con_{2})", strIndex, ThisTabName4GC, objInFor.ObjFieldTab().FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"�����ֶ���:[{{0}}]����ȷ!\", strInFldName{0});", strIndex);
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                intIndex++;
            }
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}EN.AttributeName.indexOf(strOutFldName) == -1)", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����ֶ���:[{0}]����ȷ,��������ֶη�Χ֮��!({1})\",");
            strCodeForCs.AppendFormat("\r\n" + "strOutFldName, cls{0}EN.AttributeName.join(','));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            string strCacheClassifyFld = "";
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == true && arrPrjmaryKeyFldName.Contains(thisCacheClassify_TS.FldName) == false)
            {
                strCacheClassifyFld += string.Format(", {0}Classfy", thisCacheClassify_TS.PriVarName);
            }
            if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == true && arrPrjmaryKeyFldName.Contains(thisCacheClassify_TS.FldName2) == false)
            {

                strCacheClassifyFld += string.Format(", {0}Classfy", thisCacheClassify_TS.PriVarName2);
            }
            intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                string strIndex = "";
                if (objPrjTabENEx.arrKeyFldSet.Count > 1)
                {
                    strIndex = (intIndex + 1).ToString();
                }
                if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "const {0} = strInValue{1};", objInFor.ObjFieldTab().PrivFuncName1(), strIndex);
                    strCodeForCs.Append("\r\n" + $"if (IsNullOrEmpty({objInFor.ObjFieldTab().PrivFuncName1()}) == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                {
                    strCodeForCs.AppendFormat("\r\n" + "const {0} = Number(strInValue{1});", objInFor.ObjFieldTab().PrivFuncName1(), strIndex);

                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", objInFor.ObjFieldTab().PrivFuncName1());
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const {0} = strInValue{1};", objInFor.ObjFieldTab().PrivFuncName1(), strIndex);
                    strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(strInValue{0}) == true)", strIndex);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");
                }
                intIndex++;
            }

            strCodeForCs.Append("\r\n" + $"const obj{ThisTabName4GC} = await {thisWA_F(WA_F.GetObjByKeyId_Cache)}({objPrjTabENEx.KeyPrivFuncFldNameLstStr_TS} {strCacheClassifyFld});");

            //}

            strCodeForCs.AppendFormat("\r\n" + "if (obj{0} == null) return \"\";", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}.GetFldValue(strOutFldName) == null) return \"\";", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}.GetFldValue(strOutFldName).toString();", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_funcKey()
        {
            //string strInFldNameLst = clsPubFun4GC.GenInFldNameLst(objPrjTabENEx);
            //string strInValueLst = clsPubFun4GC.GenInValueLst(objPrjTabENEx);
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function {0}funcKey(strInFldName:string, strInValue: any, strComparisonOp:string) ",
            this.tabNameHead, "");

            Re_objFunction4Code.FuncCHName4Code = "ӳ�亯�������ݱ�ӳ��������ֶ�ֵ,ӳ�������ֶ�ֵ.";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[{this.tabNameHead}_funcKey]����;(in {clsStackTrace.GetCurrClassFunction()})";

            string strBy = objKeyField.FldName;
            if (objPrjTabENEx.arrKeyFldSet.Count > 1) strBy = "KeyLst";
            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCheckEmpty = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ӳ�亯�������ݱ�ӳ��������ֶ�ֵ,ӳ�������ֶ�ֵ");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            string strKeyValueType = "string";
            string strFuncName_Temp = string.Format("funcKey");
            if (objPrjTabENEx.arrKeyFldSet.Count == 1 && objKeyField.IsNumberType())
            {
                strKeyValueType = "number";
            }
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n * @param strInFldName:�����ֶ���");
                strCodeForCs.Append("\r\n * @param strInValue:�����ֶ�ֵ");
                strCodeForCs.Append("\r\n * @param strComparisonOp:�Ƚϲ�����");
                strCodeForCs.AppendFormat("\r\n * @returns ����һ���ؼ���ֵ�б�",
                ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n*/");
                strCodeForCs.AppendFormat("\r\n" + "export  async function {0}funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<{1}>> ",
                    this.tabNameHead, strKeyValueType);
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.Append("\r\n * @param strInFldName:�����ֶ���");
                strCodeForCs.Append("\r\n * @param strInValue:�����ֶ�ֵ");
                strCodeForCs.Append("\r\n * @param strComparisonOp:�Ƚϲ�����");
                strCodeForCs.AppendFormat("\r\n @param {0}:����ķ����ֶ�", thisCacheClassify_TS.PriVarName);
                strCodeForCs.AppendFormat("\r\n * @returns ����һ���ؼ���ֵ�б�",
                ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n*/");
                strCodeForCs.AppendFormat("\r\n" + "export  async function {0}funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, {1}Classfy: {2}): Promise<Array<{3}>>",
                     this.tabNameHead, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.TypeScriptType, strKeyValueType);

                sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName + "Classfy",
                                   thisCacheClassify_TS.TypeScriptType,
                    thisCacheClassify_TS.DataTypeId,
                                   this.ClsName, strFuncName_Temp,
                                   thisCacheClassify_TS.FldLength,
                                   thisCacheClassify_TS.DataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function {0}funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, {1}Classfy: {2})",
                     this.tabNameHead, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.TypeScriptType);


            }
            else
            {
                strCodeForCs.Append("\r\n * @param strInFldName:�����ֶ���");
                strCodeForCs.Append("\r\n * @param strInValue:�����ֶ�ֵ");
                strCodeForCs.Append("\r\n * @param strComparisonOp:�Ƚϲ�����");
                strCodeForCs.AppendFormat("\r\n * @param {0}:����ķ����ֶ�", thisCacheClassify_TS.PriVarName);
                strCodeForCs.AppendFormat("\r\n * @param {0}:����ķ����ֶ�2", thisCacheClassify_TS.PriVarName2);
                strCodeForCs.AppendFormat("\r\n * @returns ����һ���ؼ���ֵ�б�",
                ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n*/");
                strCodeForCs.AppendFormat("\r\n" + "export  async function {0}funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, {1}Classfy: {2}, {3}Classfy:{4}): Promise<Array<{5}>>",
                     this.tabNameHead, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.TypeScriptType,
                     thisCacheClassify_TS.PriVarName2, thisCacheClassify_TS.TypeScriptType2, strKeyValueType);

                sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName + "Classfy",
                        thisCacheClassify_TS.TypeScriptType,
                        thisCacheClassify_TS.DataTypeId,
                        this.ClsName, strFuncName_Temp,
                        thisCacheClassify_TS.FldLength,
                        thisCacheClassify_TS.DataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));

                Re_objFunction4Code.FuncName4Code = string.Format("export  async function {0}funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, {1}: {2}, {3}:{4})",
                     this.tabNameHead, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.TypeScriptType,
                     thisCacheClassify_TS.PriVarName2, thisCacheClassify_TS.TypeScriptType2);

                sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(thisCacheClassify_TS.PriVarName2 + "Classfy",
                   thisCacheClassify_TS.TypeScriptType2,
                   thisCacheClassify_TS.DataTypeId2,
                   this.ClsName, strFuncName_Temp,
                   thisCacheClassify_TS.FldLength2,
                   thisCacheClassify_TS.DataTypeId2 == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));
            }

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "//const strThisFuncName = \"funcKey\";", ThisTabName4GC,
      objKeyField.FldName);
            strCodeForCs.AppendLine(sbCheckEmpty.ToString());
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                //string strIndex = "";
                //if (objPrjTabENEx.arrKeyFldSet.Count > 1)
                //{
                //    strIndex = (intIndex + 1).ToString();
                //}
                strCodeForCs.AppendFormat("\r\n" + "if (strInFldName == cls{0}EN.con_{1})", ThisTabName4GC, objInFor.ObjFieldTab().FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"�����ֶ���:[{{0}}]����ȷ, ����Ϊ�ؼ��ֶ�!\", strInFldName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                intIndex++;
            }
            //strCodeForCs.AppendFormat("\r\n" + "if (cls{0}EN.AttributeName.indexOf(strOutFldName) == -1)", ThisTabName4GC);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����ֶ���:[{0}]����ȷ,��������ֶη�Χ֮��!({1})\",");
            //strCodeForCs.AppendFormat("\r\n" + "strOutFldName, cls{0}EN.AttributeName.join(','));", ThisTabName4GC);
            //strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            //strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            //strCodeForCs.Append("\r\n" + "}");
            string strCacheClassifyFld = "";
            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCacheClassifyFld = string.Format("{0}Classfy", thisCacheClassify_TS.PriVarName);
            }
            else
            {
                strCacheClassifyFld = string.Format("{0}Classfy, {1}Classfy", thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.PriVarName2);
            }

            if (strKeyValueType == "string")
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0} = strInValue{1};", objInFor.ObjFieldTab().PrivFuncName1(), strIndex);
                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strInValue) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return [];");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0} = Number(strInValue{1});", objInFor.ObjFieldTab().PrivFuncName1(), strIndex);

                strCodeForCs.AppendFormat("\r\n" + "if (Number(strInValue) == 0)", objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return [];");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC} = await {thisWA_F(WA_F.GetObjLst_Cache)}({strCacheClassifyFld});");
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0} == null) return [];", ThisTabName4GC);
            //}
            strCodeForCs.AppendFormat("\r\n" + "let arr{0}Sel = arr{0};", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strInValue);");
            strCodeForCs.Append("\r\n" + "let arrValues: string[];");
            strCodeForCs.Append("\r\n" + "switch (strType)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "switch (strComparisonOp)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case enumComparisonOp.Equal_01: // \" = \"");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/enumComparisonOp.js", "enumComparisonOp", enumImportObjType.CustomFunc, this.strBaseUrl);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case enumComparisonOp.Like_03:");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case enumComparisonOp.In_04:");
            strCodeForCs.Append("\r\n" + "arrValues = strInValue.split(',');");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strInValue == null) return [];");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == enumComparisonOp.Equal_01)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strInValue) == 0) return [];");
            strCodeForCs.Append("\r\n" + "switch (strComparisonOp)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case enumComparisonOp.Equal_01:");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case enumComparisonOp.NotEqual_02:");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case enumComparisonOp.NotLessThan_05://\" >= \":");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case enumComparisonOp.NotGreaterThan_06://\" <= \":");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case enumComparisonOp.GreaterThan_07://\" > \":");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case enumComparisonOp.LessThan_08://\" < \":");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}Sel = arr{0}.filter(x => x.GetFldValue(strInFldName) == strInValue);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Sel.length == 0) return [];", ThisTabName4GC);
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}.map(x=>", ThisTabName4GC);
                intIndex = 0;
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (intIndex == 0)
                    {
                        strCodeForCs.AppendFormat("`${{x.{0}}}", objInFor.PropertyName(this.IsFstLcase));
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("|${{x.{0}}}", objInFor.PropertyName(this.IsFstLcase));
                    }
                    intIndex++;
                }
                strCodeForCs.Append("`");
                strCodeForCs.Append(");");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}Sel.map(x=>x.{1});", ThisTabName4GC, objKeyField.PropertyName(this.IsFstLcase));
            }
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_SortFun()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "SortFunDefa(a:cls{0}EN , b:cls{0}EN): number ", ThisTabName4GC);

            Re_objFunction4Code.FuncCHName4Code = "�����������ݹؼ����ֶε�ֵ���бȽ�.";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * �����������ݹؼ����ֶε�ֵ���бȽ�");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param a:�Ƚϵĵ�1������");
            strCodeForCs.Append("\r\n * @param  b:�Ƚϵĵ�1������");
            strCodeForCs.AppendFormat("\r\n * @returns ������������ȽϵĽ��",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "SortFunDefa(a:cls{0}EN , b:cls{0}EN): number ", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"SortFunDefa\";");

            if (objKeyField.IsNumberType())
            {
                strCodeForCs.AppendFormat("\r\n" + "return a.{0}-b.{0};", objKeyField.PropertyName(this.IsFstLcase));
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "return a.{0}.localeCompare(b.{0});",
                    objKeyField.PropertyName(this.IsFstLcase));
            }
            strCodeForCs.Append("\r\n" + "}");

            clsPrjTabFldENEx objField_1 = null;
            clsPrjTabFldENEx objField_2 = null;
            foreach (var objInFor in objPrjTabENEx.arrFldSet)
            {
                if (objInFor.FieldTypeId == enumFieldType.KeyField_02) continue;
                if (objInFor.ObjFieldTabENEx.DataTypeId == enumDataTypeAbbr.bit_03) continue;
                if (objField_1 == null) objField_1 = objInFor;
                else if (objField_2 == null)
                {
                    objField_2 = objInFor;
                    break;
                }
            }
            if (objField_1 == null || objField_2 == null) return strCodeForCs.ToString();

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * �����������ݱ��������������ֶε�ֵ���бȽ�");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param  a:�Ƚϵĵ�1������");
            strCodeForCs.Append("\r\n * @param  b:�Ƚϵĵ�1������");
            strCodeForCs.AppendFormat("\r\n * @returns ������������ȽϵĽ��",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "SortFunDefa2Fld(a:cls{0}EN , b:cls{0}EN): number ", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"SortFunDefa2Fld\";");

            //if (a.Id_CourseType == b.Id_CourseType) return a.CourseSeq - b.CourseSeq;
            //else return a.Id_CourseType.localeCompare(b.Id_CourseType);
            if (objField_1.IsNumberType() && objField_2.IsNumberType())
            {
                strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) return a.{1} - b.{1};", objField_1.PropertyName(this.IsFstLcase), objField_2.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "else return a.{0} - b.{0};", objField_1.PropertyName(this.IsFstLcase));
            }
            else if (objField_1.IsNumberType() && objField_2.IsNumberType() == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) return a.{1}.localeCompare(b.{1});", objField_1.PropertyName(this.IsFstLcase), objField_2.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "else return a.{0} - b.{0};", objField_1.PropertyName(this.IsFstLcase));
            }
            else if (objField_1.IsNumberType() == false && objField_2.IsNumberType())
            {
                strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) return a.{1} - b.{1};", objField_1.PropertyName(this.IsFstLcase), objField_2.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "else return a.{0}.localeCompare(b.{0});", objField_1.PropertyName(this.IsFstLcase));
            }
            else if (objField_1.IsNumberType() == false && objField_2.IsNumberType() == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) return a.{1}.localeCompare(b.{1});", objField_1.PropertyName(this.IsFstLcase), objField_2.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "else return a.{0}.localeCompare(b.{0});", objField_1.PropertyName(this.IsFstLcase));
            }

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_SortFunByKey()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "SortFunByKey(strKey:string, AscOrDesc: string) ", ThisTabName4GC);

            Re_objFunction4Code.FuncCHName4Code = "�����������ݹؼ����ֶε�ֵ���бȽ�.";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * �����������ݹؼ����ֶε�ֵ���бȽ�");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param a:�Ƚϵĵ�1������");
            strCodeForCs.Append("\r\n * @param  b:�Ƚϵĵ�1������");
            strCodeForCs.AppendFormat("\r\n * @returns ������������ȽϵĽ��",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "SortFunByKey(strKey:string, AscOrDesc: string)", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"SortFunByKey\";");
            strCodeForCs.Append("\r\n" + "let strMsg =\"\";");

            strCodeForCs.Append("\r\n" + "if (AscOrDesc == \"Asc\" || AscOrDesc == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "switch (strKey)");
            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }

                strCodeForCs.AppendFormat("\r\ncase cls{0}EN.con_{1}:",
                    ThisTabName4GC,
                objField.ObjFieldTabENEx.FldName);
                switch (objField.ObjFieldTabENEx.TypeScriptType)
                {
                    case "string":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}EN, b: cls{0}EN) => {{", ThisTabName4GC);
                        if (objField.IsTabNullable)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == null) return -1;", objField.PropertyName(this.IsFstLcase));
                            strCodeForCs.AppendFormat("\r\n" + "if (b.{0} == null) return 1;", objField.PropertyName(this.IsFstLcase));
                        }
                        strCodeForCs.AppendFormat("\r\n" + "return a.{0}.localeCompare(b.{0});",
                            objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "Date":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}EN, b: cls{0}EN) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return a.{0}.getTime() - b.{0}.getTime();",
                            objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "number":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}EN, b: cls{0}EN) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return a.{0}-b.{0};", objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "boolean":
                        //                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}EN, b: cls{0}EN) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}EN) => {{", ThisTabName4GC);

                        strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == true) return 1;", objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "else return -1");
                        strCodeForCs.Append("\r\n" + "}");
                        break;

                    default:
                        var strMsg = string.Format("TypeScript:[{0}]�ں�����û�б�����(in {1})", objField.ObjFieldTabENEx.TypeScriptType, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                        //break;
                }

            }


            strCodeForCs.Append("\r\n" + "        default:");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = `�ֶ���:[${{strKey}}]�ڱ����:[{0}]�в�����!(in ${{ " + this.constructorName + "}}.${{ strThisFuncName}})`;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "       console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "     break;");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + "  else");
            strCodeForCs.Append("\r\n" + " {");

            strCodeForCs.Append("\r\n" + "switch (strKey)");
            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }

                strCodeForCs.AppendFormat("\r\ncase cls{0}EN.con_{1}:",
                    ThisTabName4GC,
                objField.ObjFieldTabENEx.FldName);
                switch (objField.ObjFieldTabENEx.TypeScriptType)
                {
                    case "string":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}EN, b: cls{0}EN) => {{", ThisTabName4GC);
                        if (objField.IsTabNullable)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if (b.{0} == null) return -1;", objField.PropertyName(this.IsFstLcase));
                            strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == null) return 1;", objField.PropertyName(this.IsFstLcase));
                        }
                        strCodeForCs.AppendFormat("\r\n" + "return b.{0}.localeCompare(a.{0});",
                            objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "Date":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}EN, b: cls{0}EN) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return b.{0}.getTime() - a.{0}.getTime();",
                            objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "number":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}EN, b: cls{0}EN) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return b.{0}-a.{0};", objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "boolean":
                        strCodeForCs.AppendFormat("\r\n" + "return (b: cls{0}EN) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "if (b.{0} == true) return 1;", objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "else return -1");

                        strCodeForCs.Append("\r\n" + "}");
                        break;

                    default:
                        var strMsg = string.Format("TypeScript:[{0}]�ں�����û�б�����(in {1})", objField.ObjFieldTabENEx.TypeScriptType, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                        //break;
                }

            }


            strCodeForCs.Append("\r\n" + "        default:");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = `�ֶ���:[${{strKey}}]�ڱ����:[{0}]�в�����!(in ${{ " + this.constructorName + "}}.${{ strThisFuncName}})`;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "       console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "     break;");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_FilterFunByKey()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHead + "FilterFunByKey(strKey:string, value: any) ", ThisTabName4GC);

            Re_objFunction4Code.FuncCHName4Code = "�����������ݹؼ����ֶε�ֵ���бȽ�.";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���˺��������ݹؼ����ֶε�ֵ�����ֵ���бȽ�,�����Ƿ����");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param strKey:�ȽϵĹؼ��ֶ�����");
            strCodeForCs.Append("\r\n * @param value:����ֵ");
            strCodeForCs.AppendFormat("\r\n * @returns ���ض�����ֶ�ֵ�Ƿ���ڸ���ֵ",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "FilterFunByKey(strKey:string, value: any)", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"FilterFunByKey\";");

            strCodeForCs.Append("\r\n" + "let strMsg =\"\";");
            strCodeForCs.Append("\r\n" + "switch (strKey)");
            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }

                strCodeForCs.AppendFormat("\r\ncase cls{0}EN.con_{1}:",
                    ThisTabName4GC,
                objField.ObjFieldTabENEx.FldName);
                switch (objField.ObjFieldTabENEx.TypeScriptType)
                {
                    case "string":
                        strCodeForCs.AppendFormat("\r\n" + "return (obj: cls{0}EN) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return obj.{0} === value;",
                            objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "Date":
                        strCodeForCs.AppendFormat("\r\n" + "return (obj: cls{0}EN) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return obj.{0} === value;",
                            objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "number":
                        strCodeForCs.AppendFormat("\r\n" + "return (obj: cls{0}EN) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return obj.{0} === value;",
    objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "boolean":
                        strCodeForCs.AppendFormat("\r\n" + "return (obj: cls{0}EN) => {{", ThisTabName4GC);

                        strCodeForCs.AppendFormat("\r\n" + "return obj.{0} === value;",
 objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");
                        break;

                    default:
                        var strMsg = string.Format("TypeScript:[{0}]�ں�����û�б�����(in {1})", objField.ObjFieldTabENEx.TypeScriptType, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                        //break;
                }

            }


            strCodeForCs.Append("\r\n" + "        default:");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = `�ֶ���:[${{strKey}}]�ڱ����:[{0}]�в�����!(in ${{ " + this.constructorName + "}}.${{ strThisFuncName}})`;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "       console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "     break;");
            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string GeneCode_ImportClass()
        {
            StringBuilder sbImport = new StringBuilder();
            arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
            foreach (var objInFor in arrImportClass)
            {
                sbImport.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                  objInFor.ClsName,
                    objInFor.FilePath);
            }

            if (objPrjTabENEx.ApplicationTypeId == (int)enumApplicationType.VueAppInCore_TS_30)
            {
                sbImport = sbImport.Replace(".js", "");
            }
            return sbImport.ToString();
        }
        //public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        //{
        //    return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, objViewInfoENEx.PrjId);
        //}
        public string Gen_4WAEx_Ts_GetObjExLstByPagerAsync()
        {
            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWAEx_F(WA_F.GetObjExLstByPagerAsync)}(objPagerPara: stuPagerPara):Promise<Array<cls{ThisTabName4GC}ENEx>>";

            Re_objFunction4Code.FuncCHName4Code = "���ݷ�ҳ�����ӻ����л�ȡ��ҳ�����б�,ֻ��ȡһҳ";

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݷ�ҳ�����ӻ����л�ȡ��ҳ�����б�,ֻ��ȡһҳ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param objPagerPara:��ҳ�����ṹ", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �����б�");
            strCodeForCs.AppendFormat("\r\n*/");


            strCodeForCs.Append("\r\n" + $"export  async function {thisWAEx_F(WA_F.GetObjExLstByPagerAsync)}(objPagerPara: stuPagerPara):Promise<Array<cls{ThisTabName4GC}ENEx>> {{");

            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWAEx_F(WA_F.GetObjExLstByPagerAsync)}(objPagerPara: stuPagerPara) :Promise<Array<cls{ThisTabName4GC}ENEx>>";

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjExLstByPagerAsync\";", ThisTabName4GC,
            objKeyField.FldName);

            var strCache_ParaVarLstStr = clsPrjTabBLEx.Cache_ParaVarLstStr(objPrjTabENEx, "TypeScript");

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLst = await {thisWAEx_F(WA_F.GetObjExLstByPagerAsync)}(objPagerPara);");

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ExObjLst = arr{0}ObjLst.map({1}CopyToEx);", ThisTabName4GC, this.tabNameHeadEx);

            strCodeForCs.Append("\r\n" + " const objSortInfo = GetSortExpressInfo(objPagerPara);");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "GetSortExpressInfo", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + $" if (IsNullOrEmpty(objSortInfo.SortFld) == false && cls{ThisTabName4GC}EN.AttributeName.indexOf(objSortInfo.SortFld) == -1)");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + " {");

            strCodeForCs.AppendFormat("\r\n" + " for (const objInFor of arr{0}ExObjLst) {{", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"await {thisWAEx_F(WA_F.FuncMapByFldName)}(objSortInfo.SortFld, objInFor);");

            //AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC+"Ex", string.Format("FuncMap", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);
            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ExObjLst.length == 0) return arr{0}ExObjLst;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "let arr{0}Sel: Array < cls{0}ENEx > = arr{0}ExObjLst;", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "try {");

            strCodeForCs.Append("\r\n" + "if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {");
            strCodeForCs.Append("\r\n" + "const sstrSplit: string[] = objPagerPara.orderBy.split(\" \");");
            strCodeForCs.Append("\r\n" + "let strSortType = \"asc\";");
            strCodeForCs.Append("\r\n" + "const strSortFld = sstrSplit[0];");
            strCodeForCs.Append("\r\n" + "if (sstrSplit.length > 1) strSortType = sstrSplit[1];");
            strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}Sel = arr{ThisTabName4GC}Sel.sort({thisWAEx_F(WA_F.SortFunByKey)}(strSortFld, strSortType));");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + "//��������ֶ���[OrderBy]Ϊ��,�͵���������");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.sort(objPagerPara.sortFun);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
                        
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}Sel;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����:[{0}]. \\n��������:[{1}]��ȡ��ҳ�����б��ɹ�!(In {2}.{3})\", e, objPagerPara.whereCond, " + this.constructorNameEx + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return new Array<cls{0}ENEx>();", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Ts_GetDdlData()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                List<string> arrTemp = new List<string>();
                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objEditRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                    if (arrTemp.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTemp.Add(objTabFeature4Ddl.TabName4GC);
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN[]>([]);");

                }
                arrTemp.RemoveRange(0, arrTemp.Count);
                //���ÿһ������--������
                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objEditRegionFld.TabFeatureId4Ddl, this.IsFstLcase);

                    if (arrTemp.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTemp.Add(objTabFeature4Ddl.TabName4GC);

                    List<string> arrCondFldId = objTabFeature4Ddl.GetCondFldIdLst();
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature4Ddl.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
                    CacheClassify objCacheClassify_TS = null;
                    clsPrjTabENEx objPrjTabENEx_Ddl = null;
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.TabId) == false)
                    {
                        objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeature4Ddl.TabId, objTabFeature4Ddl.PrjId);
                        objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);

                        //objFuncParaLst.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                        //objFuncParaLstAll.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                        objFuncParaLst.AddParaByTabFeature(objTabFeature4Ddl, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
                        objFuncParaLst.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                    }


                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para();

                    //��0��:�ѿؼ���������ComboBoxת����ComboBox
                    if (objTabFeature4Ddl.IsHasErr)
                    {
                        throw new Exception(objTabFeature4Ddl.ErrMsg_Ddl);
                    }


                    strCodeForCs.Append("\r\n/**");
                    strCodeForCs.Append("\r\n * ��ȡ�������������");
                    strCodeForCs.AppendFormat("\r\n * ({0})-pyf", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                    //���������������ĺ���˵��
                    strCodeForCs.Append("\r\n" + objTabFeature4Ddl.FuncRemark);
                    strCodeForCs.Append("\r\n*/");

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);

                    strCodeForCs.Append("\r\n" + $"export  async function " + this.tabNameHead + $"getArr{objTabFeature4Ddl.TabName4GC}({strFuncPara}): Promise<Array<cls{objTabFeature4Ddl.TabName4GC}EN>>");

                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = new Array<cls{objTabFeature4Ddl.TabName4GC}EN>();");

                    if (objPrjTabENEx_Ddl.IsUseCache_TS() == false)
                    {
                        string strConditionStr = objTabFeature4Ddl.ConditionStr;
                        strCodeForCs.Append("\r\n" + strConditionStr);
                        strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst2} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstAsync(strCondition);");
                    }
                    else
                    {
                        if (objCacheClassify_TS.IsHasCacheClassfyFld == false)
                        {
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstCache();");
                        }
                        else if (objCacheClassify_TS.IsHasCacheClassfyFld2 == false)
                        {
                            string strPrivFuncName = objCacheClassify_TS.PriVarName;
                            arrCacheFldName.Add(objCacheClassify_TS.FldName);
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstCache({strPrivFuncName});");

                        }
                        else
                        {
                            string strPrivFuncName = objCacheClassify_TS.PriVarName;
                            string strPrivFuncName2 = objCacheClassify_TS.PriVarName2;
                            arrCacheFldName.Add(objCacheClassify_TS.FldName);
                            arrCacheFldName.Add(objCacheClassify_TS.FldName2);

                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstCache({objCacheClassify_TS.PriVarName}, {objCacheClassify_TS.PriVarName2});");

                        }
                    }
                    strCodeForCs.Append("\r\n" + "if (arrObjLstSel == null) return;");
                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC}.value.length = 0;");
                    strCodeForCs.Append("\r\n" + $"const obj0 = new cls{objTabFeature4Ddl.TabName4GC}EN();");
                    if (objEditRegionFld.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                    {
                        strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.ValueFieldName)} = 0;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.ValueFieldName)} = '0';");
                    }

                    strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.TextFieldName)} = '��ѡ��{clsString.FstLcaseS(objTabFeature4Ddl.TabCnName4GC)}...';");
                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC}.value.push(obj0);");
                    //���ɹ����������
                    //string strFilterCondition = objFuncParaLst.GeneFilterCondition();
                    if (objPrjTabENEx_Ddl.IsUseCache_TS() == true)
                    {
                        strCodeForCs.Append(objTabFeature4Ddl.FilterCondition);
                    }
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.SortStr) == false)
                    {
                        strCodeForCs.Append("\r\n" + $"arrObjLstSel = arrObjLstSel.sort({objTabFeature4Ddl.SortStr});");
                    }

                    strCodeForCs.Append("\r\n" + $"arrObjLstSel.forEach(x => arr{objTabFeature4Ddl.TabName4GC}.value.push(x));");
                    if (objEditRegionFld.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                    {
                        strCodeForCs.Append("\r\n" + $"{objEditRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}.value = 0;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"{objEditRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}.value = '0';");
                    }

                    strCodeForCs.Append("\r\n" + $"return arr{objTabFeature4Ddl.TabName4GC};");
                    strCodeForCs.Append("\r\n" + "}");
                }

            }

            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɻ�ȡ����������:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


    }
}
