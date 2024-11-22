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
    partial class CommFun4WARJ4JavaScript : clsGeneCodeBase
    {
        public bool Is4RJ { get; set; }
        #region ���캯��

        public CommFun4WARJ4JavaScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLst_Cache = null;
        }
        public CommFun4WARJ4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLst_Cache = null;
        }
        #endregion

      

        /// <summary>
        /// ����ͨ���߼������
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceCodeNew(Encoding myEncoding)
        {
            string strFuncName = "";
            string strResult;
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                 objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Web.Services;");
                strCodeForCs.Append("\r\n" + "using System.Web.Services.Protocols;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.AppendFormat("\r\n" + "using {0};",
                objProjectsEN.PrjDomain);
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                objProjectsEN.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}Service ��ժҪ˵��",
                objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[WebService(Namespace = \"http://tempuri.org/\")]");
                strCodeForCs.Append("\r\n" + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
                strCodeForCs.Append("\r\n" + "[ToolboxItem(false)]");
                strCodeForCs.AppendFormat("\r\n" + "public class {0}Service : System.Web.Services.WebService",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

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
        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {

            List<ImportClass> arrImportClass = new List<ImportClass>();

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("clsCommFun4BL", objPrjTabENEx.TabName),
                    FilePath = string.Format("clscommfun4bl", objFuncModule.FuncModuleEnName,
        objPrjTabENEx.TabName)
                });
            }
            else
            {
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("clsCommFun4BLV2", objPrjTabENEx.TabName),
                    FilePath = string.Format("clscommfun4blv2", objFuncModule.FuncModuleEnName,
  objPrjTabENEx.TabName)
                });
            }

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsSysPara4WebApi", objPrjTabENEx.TabName),
                FilePath = string.Format("clssyspara4webapi", objFuncModule.FuncModuleEnName,
   objPrjTabENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objPrjTabENEx.TabName),
                FilePath = string.Format("../../L3_ForWApi/{0}/cls{1}WApi.js", objFuncModule.FuncModuleEnName,
          objPrjTabENEx.TabName)
            });
            List<string> arrTabId = clsPrjTabBLEx.GetRelaViewTabIdLstByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            foreach (string strRelaTabId in arrTabId)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strRelaTabId, objPrjTabENEx.PrjId);
                if (objPrjTab.TabStateId != "01") continue;
                //string strMsg = string.Format("{0}({1}) ",
                //    objPrjTab.TabName, objPrjTab.TabId);
                //listBox1.Items.Add(strMsg);
                if (objPrjTab.IsUseCache == false) continue;
                if (objPrjTab.TabId == objPrjTabENEx.TabId) continue;
                clsFuncModule_AgcEN objFuncModel_Agc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTab.FuncModuleAgcId, objPrjTab.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objPrjTab.TabName),
                    FilePath = string.Format("../../L3_ForWApi/{0}/cls{1}WApi.js", objFuncModel_Agc.FuncModuleEnName,
     objPrjTab.TabName)
                });
              
            }

            return arrImportClass;
        }


        /// <summary>
        /// ����ҵ���߼�����룭��C#.NET
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.Is4RJ = true;
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
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(1);
            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                         clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
                         objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);
            if (arrvFunction4GeneCodeObjLst.Count() == 0) 
                    {
                string strMsg = string.Format("����:{4}({5}), ��������:{0}, ��������:{1}, Sql���ͣ�{2}({3})==>û�п������ɵĺ���4GC!",
                    objPrjTabENEx.LangType, clsCodeTypeBL.GetNameByCodeTypeId_Cache(objPrjTabENEx.CodeTypeId),
                    clsSQLDSTypeBL.GetNameBySqlDsTypeId_Cache(objPrjTabENEx.SqlDsTypeId), objPrjTabENEx.SqlDsTypeId,
                    objPrjTabENEx.TabName, objPrjTabENEx.TabId);
                return strMsg;
            }
            objPrjTabENEx.ClsName = string.Format("clsCommFun4WA4{0}", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";
            objPrjTabENEx.FileName = strClassFName;

            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx));

                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);
                strCodeForCs.Append("\r\n" + "const __extends = (this && this.__extends) || (function() {");
                strCodeForCs.Append("\r\n" + "const extendStatics = function(d, b) {");
                strCodeForCs.Append("\r\n" + "extendStatics = Object.setPrototypeOf ||");
                strCodeForCs.Append("\r\n" + "({ __proto__: [] }");
                strCodeForCs.Append("\r\n" + "instanceof Array && function(d, b) { d.__proto__ = b; }) ||");
                strCodeForCs.Append("\r\n" + "function(d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };");
                strCodeForCs.Append("\r\n" + "return extendStatics(d, b);");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return function(d, b) {");
                strCodeForCs.Append("\r\n" + "extendStatics(d, b);");
                strCodeForCs.Append("\r\n" + "function __() { this.constructor = d; }");
                strCodeForCs.Append("\r\n" + "d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "})();");

             

                strCodeForCs.Append("\r\n" + "(function(factory) {");
                strCodeForCs.Append("\r\n" + "if (typeof module === \"object\" && typeof module.exports === \"object\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const v = factory(require, exports);");
                strCodeForCs.Append("\r\n" + "if (v !== undefined) module.exports = v;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (typeof define === \"function\" && define.amd)");
                strCodeForCs.Append("\r\n" + "{");
                IEnumerable<string> arrFilePath = arrImportClass.Select(x => string.Format("\"{0}\"", x.FilePath));
                string strFilePathStr = string.Join(",", arrFilePath);
                strCodeForCs.AppendFormat("\r\n" + "define([\"require\", \"exports\", {0}], factory);", strFilePathStr);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "})(function(require, exports) {");
                strCodeForCs.Append("\r\n" + "\"use strict\";");
                strCodeForCs.Append("\r\n" + "Object.defineProperty(exports, \"__esModule\", { value: true });");
                
                arrImportClass.ForEach(x => {
                    if (string.IsNullOrEmpty(x.ModuleName) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const {0}_js_1 = require(\"{1}\");", x.ClassName, x.FilePath);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const {2} = require(\"{1}\");", x.ClassName, x.FilePath, x.ModuleName);
                    }
                });


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeId_Cache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// ����Դ����:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
               
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const {0} = /** @class **/ (function (_super) {{", objPrjTabENEx.ClsName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const {0}  = /** @class **/ (function (_super) {{", objPrjTabENEx.ClsName);
                }
                strCodeForCs.AppendFormat("\r\n" + "__extends({0}, _super);", objPrjTabENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "function {0}()", objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return _super !== null && _super.apply(this, arguments) || this;");
                strCodeForCs.Append("\r\n" + "}");


                //˽��������-----�����Թ���
                //�������еĺ���
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                                objException.Message,
                                clsStackTrace.GetCurrClassFunction());
                        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }
                strCodeForCs.AppendFormat("\r\n" + "return {0};", objPrjTabENEx.ClsName);
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "}}({0}));",
                         ImportClass.GetOutString(string.Format("clsCommFun4BL", objPrjTabENEx.TabName), true));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "}}({0}));",
                       ImportClass.GetOutString(string.Format("clsCommFun4BLV2", objPrjTabENEx.TabName), true));
                }
                strCodeForCs.AppendFormat("\r\n" + "exports.{0} = {0};", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "});");

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
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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
        //public string A_GenCode4Function_Java(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Java(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_JavaScript(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_JavaScript(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}


        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_Swift4(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Swift4(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_Swift3(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Swift3(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}


        ///// <summary>
        ///// ����ָ���ĺ���
        ///// </summary>
        ///// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_Swift(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Swift(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_SilverLight(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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

      


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(CommFun4WARJ4JavaScript);
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
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        
        
        public string Gen_4BL_ReFreshCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshCache()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "  if (clsSysParaEN.spIsUseQueue4Task == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.arrFunctionLst4Queue == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "clsDynamicFunction objDynamicFunction = new clsDynamicFunction();");
            strCodeForCs.AppendFormat("\r\n" + "objDynamicFunction.NameSpace = \"{0}.BusinessLogic\";", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "objDynamicFunction.ClassName = \"cls{0}BL\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objDynamicFunction.AssemblyType = typeof({0}.BusinessLogic.cls{1}BL);", objProjectsENEx.PrjDomain, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objDynamicFunction.FunctionName = clsStackTrace.GetCurrFunction();");
            strCodeForCs.Append("\r\n" + "if (clsDynamicFunction.IsExistSameFunction(clsSysParaEN.arrFunctionLst4Queue, objDynamicFunction) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue.Enqueue(objDynamicFunction);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}_objCommFun4BL != null) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + " string strMsg = string.Format(\"ˢ1�»���ɹ���({{2}}->{{1}}->{{0}})\",", "{", "}");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Cache = null;",
                   objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "{0}_objCommFun4BL.ReFreshCache();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4BL_ReFreshThisCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ˢ�±����еĻ���.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshThisCache()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"\";");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.spSetRefreshCacheOn == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Cache = null;",
          objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"ˢ1�»���ɹ���({{2}}->{{1}}->{{0}})\",");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = string.Format(\"ˢ�»����Ѿ��رա�(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})\",");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3));");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4CFWA_Js_ReFreshCache()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + " clsCommFun4WA4{0}.prototype.ReFreshCache = function()", objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "clsCommFun4WA4{2}.prototype.ReFreshCache = function({0})",                    
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"\";");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.spSetRefreshCacheOn == false)",
                         ImportClass.GetOutString(string.Format("clsSysPara4WebApi", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"ˢ�»����Ѿ��رա�(clsSysPara4WebApi.spSetRefreshCacheOn == false)(\" + clsStackTrace.GetCurrClassFunctionByLevel(3) + \"->\" + clsStackTrace.GetCurrClassFunctionByLevel(2) + \"->\" + clsStackTrace.GetCurrClassFunction() +\")\";");
            strCodeForCs.Append("\r\n" + "console.log(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.ReFreshThisCache();",
                    objPrjTabENEx.TabName,
                         ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}.ReFreshThisCache({1});",
               objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                         ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            //string strTabId = cboPrjTab.SelectedValue.ToString();
            //arrPrjTabObjLst = clsPrjTabBLEx.GetPrjTabObjLstByPrjId_CacheEx(strPrjId);
            //int intIndex = clsPrjTabBLEx.GetIndexByTabId(strTabId, arrPrjTabObjLst);
            //List<string> arrTabId = clsPrjTabBLEx.GetRelaSubNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            List<string> arrTabId = clsPrjTabBLEx.GetRelaViewTabIdLstByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            foreach (string strRelaTabId in arrTabId)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strRelaTabId, objPrjTabENEx.PrjId);
                if (objPrjTab.TabStateId != "01") continue;
                //string strMsg = string.Format("{0}({1}) ",
                //    objPrjTab.TabName, objPrjTab.TabId);
                //listBox1.Items.Add(strMsg);
                if (objPrjTab.IsUseCache == false) continue;
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1}.ReFreshThisCache();",
                        objPrjTab.TabName,
                         ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTab.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{2}.ReFreshThisCache({1});",
                      objPrjTab.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                         ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTab.TabName), this.Is4RJ));
                }
            }

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_GeneEnumConstList()
        {
            string strKeyFieldName = "";
            string strNamedFieldName = "";
            string strEnglishNameFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strKeyFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strNamedFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "05")
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
                sbMsg.AppendFormat("�ڻ�ȡ�����ݣ�GetDataTableByTabName��ʱ����������{0},������Ϣ��{1}��({2})",
                    objPrjTabENEx.TabName, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݱ���������enum�б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\npublic class enum{0}",
                       objPrjTabENEx.TabName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}", objRow[strNamedFieldName]);
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public const string {0}_{1} = \"{1}\";",
                        objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\npublic enum enum{0} : {1}",
                objPrjTabENEx.TabName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strCodeForCs.AppendFormat("\r\n" + "[Description(\"{0}\")]", objRow[strNamedFieldName]);
                    strCodeForCs.AppendFormat("\r\n" + "{0}_{1} = {1},", objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_4BL_GeneEnumConstList4Field()
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
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڻ�ȡ�����ݣ�GetDataTableByTabName��ʱ����������{0},������Ϣ��{1}��({2})",
                    objPrjTabENEx.TabName, objException.Message,
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
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// ���ݱ��ֶ���������enum�б�-�ֶ�����[{0}]", objField.ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\npublic class enum{0}_{1}",
                       objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n{");
                List<string> arrExistItem = new List<string>();
                foreach (DataRow objRow in objDT.Rows)
                {
                    string strFieldValue = objRow[objField.ObjFieldTabENEx.FldName].ToString();
                    if (arrExistItem.Contains(strFieldValue)) continue;
                    arrExistItem.Add(strFieldValue);
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}", strFieldValue);
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public const string con_{0} = \"{0}\";",
                        strFieldValue);
                }

                strCodeForCs.Append("\r\n}");
            }
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public override void GetClsName()
        {
            this.ClsName = string.Format("clsCommFun4WA4{0}", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }


    }
}
