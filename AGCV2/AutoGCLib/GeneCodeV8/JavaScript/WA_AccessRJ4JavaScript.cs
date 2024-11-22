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
    partial class WA_AccessRJ4JavaScript : WA_Access4JavaScript
    {
        #region ���캯��

        public WA_AccessRJ4JavaScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_AccessRJ4JavaScript(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_AccessRJ4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        #endregion

        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {

            List<ImportClass> arrImportClass = new List<ImportClass>();
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}EN", objPrjTabENEx.TabName),
                FilePath = string.Format("../../L0_Entity/{0}/cls{1}EN.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("clsCommFun4WA4{0}", objPrjTabENEx.TabName),
                    FilePath = string.Format("../../L2_BLL/{0}/clsCommFun4WA4{1}.js", objFuncModule.FuncModuleEnName,
                          objPrjTabENEx.TabName)
                });
            }

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsCommFunc4Web", objPrjTabENEx.TabName),
                FilePath = string.Format("clscommonfunc4web", objFuncModule.FuncModuleEnName,
        objPrjTabENEx.TabName)
            });

   //         arrImportClass.Add(new ImportClass
   //         {
   //             ClassName = string.Format("clsStack1Trace", objPrjTabENEx.TabName),
   //             FilePath = string.Format("clsstacktrace", objFuncModule.FuncModuleEnName,
   //objPrjTabENEx.TabName)
   //         });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}BL", objPrjTabENEx.TabName),
                FilePath = string.Format("../../L2_BLL/{0}/cls{1}BL.js", objFuncModule.FuncModuleEnName,
                                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("tzDictionary", objPrjTabENEx.TabName),
                ModuleName = "Dictionary_js_1",
                FilePath = string.Format("tzdictionary", objFuncModule.FuncModuleEnName,
               objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsSysPara4WebApi", objPrjTabENEx.TabName),
                FilePath = string.Format("clssyspara4webapi", objFuncModule.FuncModuleEnName,
            objPrjTabENEx.TabName)
            }); 

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuTopPara", objPrjTabENEx.TabName),
                FilePath = string.Format("../../PubFun/stuTopPara.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuRangePara", objPrjTabENEx.TabName),
                FilePath = string.Format("../../PubFun/stuRangePara.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuPagerPara", objPrjTabENEx.TabName),
                FilePath = string.Format("../../PubFun/stuPagerPara.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

        
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("CacheHelper", objPrjTabENEx.TabName),
                FilePath = string.Format("cachehelper", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsFldComparisonObj", objPrjTabENEx.TabName),
                FilePath = string.Format("clsfldcomparisonobj", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(objPrjTabENEx.RelaTabId4View, objPrjTabENEx.PrjId);
                clsFuncModule_AgcEN objFuncModule_Agc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTab.FuncModuleAgcId, objPrjTab.PrjId);
                if (objPrjTab != null)
                {
                    arrImportClass.Add(new ImportClass
                    {
                        ClassName = string.Format("cls{0}WApi", objPrjTab.TabName),
                        FilePath = string.Format("../../L3_ForWApi/{0}/cls{1}WApi.js", objFuncModule_Agc.FuncModuleEnName,
               objPrjTab.TabName)
                    });
                }
                // List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                // //bool bolIsDef_strMsg = false;
                // foreach (string strRelaTabId in arrTabId)
                // {
                //     clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strRelaTabId, objPrjTabENEx.PrjId);
                //     clsFuncModule_AgcEN objFuncModel_Agc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTab.FuncModuleAgcId, objPrjTab.PrjId);
                //     if (objPrjTab.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW) continue;
                //     arrImportClass.Add(new ImportClass
                //     {
                //         ClassName = string.Format("cls{0}WApi", objPrjTab.TabName),
                //         FilePath = string.Format("../../L3_ForWApi/{0}/cls{1}WApi.js", objFuncModel_Agc.FuncModuleEnName,
                //objPrjTab.TabName)
                //     });
                // }
            }
            return arrImportClass;
        }


        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.Is4RJ = true;
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                     objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
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
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objPrjTabENEx.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx));
                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);

                strBuilder.Append("\r\n" + "const __importStar = (this && this.__importStar) || function(mod) {");
                strBuilder.Append("\r\n" + "if (mod && mod.__esModule) return mod;");
                strBuilder.Append("\r\n" + "const result = { };");
                strBuilder.Append("\r\n" + "if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];");
                strBuilder.Append("\r\n" + "result[\"default\"] = mod;");
                strBuilder.Append("\r\n" + "return result;");
                strBuilder.Append("\r\n" + "};");

                strBuilder.Append("\r\n" + "(function(factory) {");
                strBuilder.Append("\r\n" + "if (typeof module === \"object\" && typeof module.exports === \"object\")");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "const v = factory(require, exports);");
                strBuilder.Append("\r\n" + "if (v !== undefined) module.exports = v;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else if (typeof define === \"function\" && define.amd)");
                strBuilder.Append("\r\n" + "{");
                IEnumerable<string> arrFilePath = arrImportClass.Select(x => string.Format("\"{0}\"", x.FilePath));
                string strFilePathStr = string.Join(",", arrFilePath);
                strBuilder.AppendFormat("\r\n" + "define([\"require\", \"exports\", \"jquery\", {0}], factory);", strFilePathStr);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "})(function(require, exports) {");
                strBuilder.Append("\r\n" + "\"use strict\";");
                strBuilder.Append("\r\n" + "Object.defineProperty(exports, \"__esModule\", { value: true });");

                strBuilder.Append("\r\n" + "const $ = __importStar(require(\"jquery\"));");

                arrImportClass.ForEach(x => {
                    if (string.IsNullOrEmpty(x.ModuleName) == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "const {0}_js_1 = require(\"{1}\");", x.ClassName, x.FilePath);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "const {2} = require(\"{1}\");", x.ClassName, x.FilePath, x.ModuleName);
                    }
                });

                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
             

                //strBuilder.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//�ú���������/js/PubFun/jsPubFun.js�ļ���");

                strBuilder.Append("\r\n" + "const ResponseData;");
 
                
                strBuilder.AppendFormat("\r\n" + "const cls{0}WApi = /** @class **/ (function() {{",
                  objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "function {0}(pobj{1}EN)", objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "this.obj{0}EN = new {1}();",
                    objPrjTabENEx.TabName,
                         ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                strBuilder.AppendFormat("\r\n" + "this.obj{0}EN = pobj{0}EN;",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");

    
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                StringBuilder sbExist = new StringBuilder();
                bool bolIsNotExistSome = false;
                //��麯���Ƿ����
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    bool bolIsExist = A_CheckFuncExist(objvFunction4GeneCodeEN);
                    
                    if (bolIsExist == false)
                    {
                        bolIsNotExistSome = true;
                        sbExist.AppendFormat("\r\n ����:{0}�����ڣ�", strFuncName);
                    }
                }
                if (bolIsNotExistSome)
                {
                    string strMsg = string.Format("�����ɴ���ʱ������[{0}]��(In {1})", sbExist.ToString(), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                //strBuilder.Append("\r\n" + "};");
                strBuilder.AppendFormat("\r\n" + "{1}.mstrController = \"{0}Api\";", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "{0}.{1} = \"{2}\"; //{3}", objPrjTabENEx.ClsName,
                    conPrjTab.CacheModeId, objPrjTabENEx.CacheModeId, clsCacheModeBL.GetNameByCacheModeId_Cache(objPrjTabENEx.CacheModeId));
                strBuilder.AppendFormat("\r\n" + "return {0};", objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "}());");
                strBuilder.AppendFormat("\r\n" + "exports.{0} = {0};", objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "});");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
         
            }
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
                Type t = typeof(WA_AccessRJ4JavaScript);
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
            this.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName);
        }
       
    }
}
