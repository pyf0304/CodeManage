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
    partial class WA_ViewUTScriptCSRJ4JavaScript : WA_ViewUTScriptCS4JavaScript
    {


        #region ���캯��

        public WA_ViewUTScriptCSRJ4JavaScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_ViewUTScriptCSRJ4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewUTScriptCSRJ4JavaScript);
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
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }

        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {

            List<ImportClass> arrImportClass = new List<ImportClass>();
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}EN", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/L0_Entity/{0}/cls{1}EN.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/L3_ForWApi/{0}/cls{1}WApi.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });


            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}BL", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/L2_BLL/{0}/cls{1}BL.js", objFuncModule.FuncModuleEnName,
                                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsCommFunc4Web", objPrjTabENEx.TabName),
                FilePath = string.Format("clscommonfunc4web", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuTopPara", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/stuTopPara.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuRangePara", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/stuRangePara.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuPagerPara", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/stuPagerPara.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsPubFun", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/clsPubFun.js", objFuncModule.FuncModuleEnName,
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
            return arrImportClass;
        }

        /// <summary>
        /// ����Appҳ���̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.Is4RJ = true;
            string strFuncName = "";
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objPrjTabENEx.ClsName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
            string strXmlFileName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
            strXmlFileName = strXmlFileName.ToLower();
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

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
                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx));

                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);

            //strBuilder.Append("\r\n ///���ɲ�ѯɾ����¼�Ŀ��Ʋ����");
            //strBuilder.Append("\r\n" + GenRefDomainName());    //���ɲο�����
            strBuilder.Append("\r\n" + "(function(factory) {");
                strBuilder.Append("\r\n" + "if (typeof module === \"object\" && typeof module.exports === \"object\")");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "const v = factory(require, exports);");
                strBuilder.Append("\r\n" + "if (v !== undefined) module.exports = v;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else if (typeof define === \"function\" && define.amd)");
                strBuilder.Append("\r\n" + "{");
                IEnumerable<string> arrFilePath = arrImportClass.Select(x=>string.Format("\"{0}\"", x.FilePath));
                string strFilePathStr = string.Join(",", arrFilePath);
                strBuilder.AppendFormat("\r\n" + "define([\"require\", \"exports\", {0}], factory);", strFilePathStr);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "})(function(require, exports) {");
                strBuilder.Append("\r\n" + "\"use strict\";");
                strBuilder.Append("\r\n" + "Object.defineProperty(exports, \"__esModule\", { value: true });");


                strBuilder.Append("\r\n" + "///// <reference path=\"../../../scripts/typings/jquery/jquery.d.ts\" />");
                
                strBuilder.Append("\r\n" + "/////import * as $ from \"jquery\";");

                arrImportClass.ForEach(x=> {
                    strBuilder.AppendFormat("\r\n" + "const {0}_js_1 = require(\"{1}\");", x.ClassName, x.FilePath);
                });

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0} ��ժҪ˵��������Q�����ѯ,U�����޸�", objPrjTabENEx.ClsName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "const {0} = /** @class **/ (function() {{", objPrjTabENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "function {0}()", objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "}");

                    //strBuilder.Append("\r\n" + "private strInfo = \"\";");
                    //strBuilder.Append("\r\n" + "private strWhereCond = \"\";");

                    strBuilder.Append("\r\n" + "");
                /////���ɽ�����Page_Load����;
                //strBuilder.Append("\r\n" + "#region ҳ����������");

                /////���ɽ�����Page_Load����;
                //strTemp = GenPage_LoadCode(false);
                //strBuilder.Append(strTemp);
                //strBuilder.Append("\r\n" + "#endregion ҳ����������");
                //�������еĺ���
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);
                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();
                             
                //Ϊ�����Ĳ�������ؼ����а�
                arrValueLst = new List<string>();

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_ClassStatic =
                    arrvFunction4GeneCodeObjLst.Where(x=>x.FuncTypeId == enumFunctionType.ClassStaticFunction_15);

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_NotClassStatic =
                    arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId != enumFunctionType.ClassStaticFunction_15);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_NotClassStatic)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);                 
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

              
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_ClassStatic)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                
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

        public override void GetClsName()
        {
            this.ClsName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }
}
