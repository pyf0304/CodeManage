using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    partial class Vue_ViewScript_EditCS_TS4TypeScript : WA_ViewScript_EditCS_TS4TypeScript
    {
        #region ���캯��
        public Vue_ViewScript_EditCS_TS4TypeScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_EditCS_TS4TypeScript(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_EditCS_TS4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.GetClsName();

            this.arrImportClass = new List<ImportClass>();
        }
        ///// <summary>
        ///// ��ʼ��ҳ������
        ///// </summary>
        //public void InitPageSetup()
        //{
        //    intZIndex = 100;        ///�ؼ��������
        //    intCurrLeft = 10;  ///�ؼ�����߿�;
        //    intCurrTop = 10;
        //}

        #endregion

        public string Gen_Vue_Ts_Page_Load()
        {
            return Gen_WApi_Ts_Page_Load();

        }

        public string Gen_Vue_Ts_SetEventFunc()
        {
            return Gen_WApi_Ts_SetEventFunc();
        }

        public string Gen_Vue_Ts_GeneEventFunc()
        {
            return Gen_WApi_Ts_GeneEventFunc();

        }

        public string Gen_Vue_Ts_DdlBind()
        {
            return Gen_WApi_Ts_DdlBind();
        }

        public string Gen_Vue_Ts_BindDdl4EditRegion()
        {
            return Gen_WApi_Ts_BindDdl4EditRegion();
        }

        public string Gen_Vue_Ts_BindDdl4EditRegionInDiv()
        {
            return Gen_WApi_Ts_BindDdl4EditRegionInDiv();
        }

        /// <summary>
        /// ����Appҳ���̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objViewInfoENEx.objViewRegion_Edit == null || objViewInfoENEx.objViewRegion_Edit.IsDispInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            //���û���������;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }

            //string strResult = "";

            string strFuncName = "";
            string strTemp = ""; ///��ʱ����;
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);


            //if (PrjTabEx_ListRegion.IsUseCache_TS())
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDICache", TabName_In4Edit4GC);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDICache.ts",
            //        TabName_In4Edit4GC, objViewInfoENEx.WebFormName);
            //}
            //else
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDI_TS", TabName_In4Edit4GC);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDI_TS.ts",
            //        TabName_In4Edit4GC, objViewInfoENEx.WebFormName);
            //}

            objViewInfoENEx.WebFormName = ThisClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            var objPrjTab_EditRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);


            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModuleEN, objViewInfoENEx, TabName_In4Edit4GC);

            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                //׼������
                //��ȡ��������Ҫ�Ĺ�������

                this.GetViewPubVarLst(this.TabId_In4Edit);


                //������ʼ
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                   clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);


                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);

                    objvFunction4GeneCodeEN.CodeText = strTemp;

                }


                strCodeForCs.AppendFormat("\r\n" + "import $ from \"jquery\";");
                //strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");

                GetImportClassLst(objFuncModuleEN);
                strFuncName = "clsPubFun4GC.Gen_Vue_Ts_ControlProperty";
                StringBuilder sbPropertyDef = new StringBuilder();

                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(sbPropertyDef, arrPropertyDef4GC, $"this.divEdit", this, this.strBaseUrl);


                arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
                foreach (var objInFor in arrImportClass)
                {
                    objInFor.ClsName = objInFor.ClsName;
                    objInFor.FilePath = objInFor.FilePath.Replace(".js", "")
                              .Replace("../../TS/", "@/ts/")
                              .Replace("../../L0Entity/", "@/ts/L0Entity/")
                              .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                              .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/")
                              .Replace("../TS/", "@/ts/");
                }

                var arrImportClass_RemoveDup = clsPubFun4GC.ImportClass_RemoveDup(arrImportClass);
                foreach (var objInFor in arrImportClass_RemoveDup)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClsName,
                        objInFor.FilePath.Replace(".js", "")
                        .Replace("../../TS/", "@/ts/")
                        .Replace("../TS/", "@/ts/"));
                }


                strCodeForCs.AppendFormat("\r\n /** {0} ��ժҪ˵��������Q�����ѯ,U�����޸�",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class  {0} ", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "protected _className = \"Unknown\"; // �����е�ʵ���ֶ�");
                strCodeForCs.Append("\r\n" + "// ������������");
                strCodeForCs.Append("\r\n" + "get className(): string {");
                strCodeForCs.Append("\r\n" + "return this._className;");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "public static E1ditObj: any;");
                //strCodeForCs.Append("\r\n" + "public divEdit: HTMLDivElement;");
                strCodeForCs.Append("\r\n" + "public static times4TestShowDialog = 0;");

                var objPageDispMode = clsPageDispModeBL.GetObjByPageDispModeIdCache(objViewInfoENEx.objViewRegion_Edit.PageDispModeId);
                if (objPageDispMode == null)
                {
                    string strMsg = string.Format("���ɽ���:[{0}]�༭��,ҳ����ʾģʽΪ��,����������!(In {1})",
                        objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                strCodeForCs.Append("\r\n" + "public opType = \"\";");
                if (objKeyField.IsNumberType())
                {
                    strCodeForCs.Append("\r\n" + "public keyId = 0;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "public keyId = \"\";");
                }

                strCodeForCs.Append("\r\n" + "public isShowMsg = true; //�༭��¼ʱ�Ƿ���ʾ��ʾ��Ϣ");
                strCodeForCs.Append("\r\n" + "public tag = \"\"; //�༭����ı�־�����ڴ�Ż��߱�־һЩ��Ϣ");

                strCodeForCs.AppendFormat("\r\n" + "public static strPageDispModeId = \"{0}\";//{1}({2})",
                    objPageDispMode.PageDispModeId, objPageDispMode.PageDispModeENName, objPageDispMode.PageDispModeName);

                strCodeForCs.AppendFormat("\r\n" + "public static objPageEdit: {0};", ThisClsName);
                strCodeForCs.AppendFormat("\r\n" + "public static objPageEdit2: {0};", ThisClsName);
                strCodeForCs.AppendFormat("\r\n" + "public static objPageEdit3: {0};", ThisClsName);

                //strCodeForCs.Append("\r\n" + GeneViewPubVar_TS(strFuncName));

                //strCodeForCs.Append("\r\n" + "private strInfo = \"\";");
                //strCodeForCs.Append("\r\n" + "private strWhereCond = \"\";");
                //strCodeForCs.AppendFormat("\r\n" + "public obj{0}: cls{0}EN;", TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "protected iShowList: IShowList | null;");

                strCodeForCs.Append("\r\n" + "public bolIsLoadEditRegion = false;  //��¼�Ƿ���༭���ı���");

                strCodeForCs.Append("\r\n" + "public divName4Edit = \"divEditLayout\";  //�༭����Id");


                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ��ȡ��ǰ�����divEdit�Ĳ����");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get thisDivEdit(): HTMLDivElement {");
                strCodeForCs.Append("\r\n" + $"return divVarSet.refDivEdit;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ��ȡ��ǰ�����divEdit�Ĳ����");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get thisDivLayout(): HTMLDivElement {");
                strCodeForCs.Append("\r\n" + $"return divVarSet.refDivEdit;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "constructor(strClassName: string, objShowList: IShowList | null) {");
                strCodeForCs.Append("\r\n" + "this._className = strClassName;");
                strCodeForCs.Append("\r\n" + "this.iShowList = objShowList;");
                //strCodeForCs.Append("\r\n" + "const divTemp = document.createElement('div');");
                //strCodeForCs.Append("\r\n" + "divTemp.id = 'temp';");
                //strCodeForCs.Append("\r\n" + "this.divEdit = divTemp;");
                //strCodeForCs.AppendFormat("\r\n" + "{0}.objPageEdit = this;", ThisClsName);
                //strCodeForCs.AppendFormat("\r\n" + "this.obj{0} = new cls{0}EN();", TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.SetPageEdit(this, 1) == true) return;");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.SetPageEdit(this, 2) == true) return;");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.SetPageEdit(this, 3) == true) return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"public static SetPageEdit(objDataLst: any, intIndex: number): boolean {{");
                strCodeForCs.Append("\r\n" + $"const strNewClassName = objDataLst.className;");
                strCodeForCs.Append("\r\n" + $"switch (intIndex)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"case 1:");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strNewClassName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"break;");
                strCodeForCs.Append("\r\n" + $"case 2:");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit2 == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit2 = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit2.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strNewClassName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit2 = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"break;");
                strCodeForCs.Append("\r\n" + $"case 3:");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit3 == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit3 = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit3.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strNewClassName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit3 = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"break;");
                strCodeForCs.Append("\r\n" + $"default:");
                strCodeForCs.Append("\r\n" + $"return false;");
                strCodeForCs.Append("\r\n" + $"// break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"public static GetPageEditObj(strClassName: string): any {{");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strClassName) return {ThisClsName}.objPageEdit;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit2 != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit2.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strClassName) return {ThisClsName}.objPageEdit2;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit3 != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit3.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strClassName) return {ThisClsName}.objPageEdit3;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"return null;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "");
                //�������еĺ���


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        //objvFunction4GeneCodeEN.CodeText = strTemp;
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }
                strFuncName = "clsPubFun4GC.Gen_Vue_Ts_ControlProperty";
                strCodeForCs.Append("\r\n" + sbPropertyDef.ToString());
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

        public void Gen_Vue_Ts_ControlProperty4One_NotInDiv(StringBuilder strCodeForCs, clsPropertyDef4GC x)
        {
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
            //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            string strIsStatic = "";
            if (x.IsStatic) strIsStatic = "static";
            switch (x.OperateType)
            {
                case "get":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":
                            if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "const str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            }
                            break;
                        case "button":
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":

                            if (x.DataType == "boolean")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                            }
                            else if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//�������(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "CacheClassifyFieldTS":
                            strCodeForCs.Append("\r\n" + "//��������ֶ�(CacheClassifyFieldTS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//��Ը���ֵ(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return Number(strValue);");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return strValue;");
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return 0;");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return \"\";");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                    }
                    break;
                case "set":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":

                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value.toString());", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "button":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "Label":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//�������(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            break;
                        case "CacheClassifyFieldTS":
                            strCodeForCs.Append("\r\n" + "//��������ֶ�(CacheClassifyFieldTS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//��Ը���ֵ(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                    }
                    break;

            }
            strCodeForCs.Append("\r\n" + "}");

        }

        public void Gen_Vue_Ts_ControlPropertyBak(StringBuilder strCodeForCs)
        {
            var arrPropertyDef4GC2 = arrPropertyDef4GC.OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.ParentDivName) == true)
                {
                    Gen_Vue_Ts_ControlProperty4One_NotInDiv(strCodeForCs, x);
                    return;
                }
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                string strIsStatic = "";
                if (x.IsStatic) strIsStatic = "static";
                switch (x.OperateType)
                {
                    case "get":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.Append("\r\n" + $"const objDiv = $(`#$this.divEdit`);");

                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + "return objDiv.find(strId).prop(\"checked\");");

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);

                                if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " var str{1} = objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                    //strCodeForCs.AppendFormat("\r\n" + "const str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                    strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                    strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                    //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                }
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);

                                if (x.DataType == "boolean")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return false;", x.CtrlId);
                                    //                                    strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                }
                                else if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return 0;", x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + " const strValue = objDiv.find(strId).val();", x.CtrlId, x.PropertyName);
                                    strCodeForCs.Append("\r\n" + " return Number(strValue);");

                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return \"\";", x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);
                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                                }

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//�������(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                                strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "CacheClassifyFieldTS":
                                strCodeForCs.Append("\r\n" + "//��������ֶ�(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                                strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//��Ը���ֵ(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                                strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return Number(strValue);");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return strValue;");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return 0;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return \"\";");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                        }
                        break;
                    case "set":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.Append("\r\n" + $"const objDiv = $(`#$this.divEdit`);");


                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).attr(\"checked\", value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "Label":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//�������(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                                break;
                            case "CacheClassifyFieldTS":
                                strCodeForCs.Append("\r\n" + "//��������ֶ�(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//��Ը���ֵ(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                        }
                        break;

                }
                strCodeForCs.Append("\r\n" + "}");
            });
        }


        public string Gen_Vue_Ts_SetKeyReadOnly()
        {
            return Gen_WApi_Ts_SetKeyReadOnly();
        }

        public string Gen_Vue_Ts_Clear()
        {
            return "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //����˽�д���;
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + " * ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public Clear()");
                strCodeForCs.Append("\r\n" + "{");
                //                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Clear.name;",
                //this.TabName_In4Edit4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13) continue;
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14) continue;

                    if (objEditRegionFldsEx.InUse == false) continue;

                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.DefaultValue_36) continue;
                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    

                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }

                    try
                    {
                        //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        //{
                        //    OperateType = "set",
                        //    ControlType = objEditRegionFldsEx.CtlTypeName,
                        //    CtrlId = objEditRegionFldsEx.CtrlId,
                        //    PropertyName = objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                        //    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                        //                "Clear()"),
                        //    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                        //    ParentDivName = $"this.divEdit"
                        //});
                        if (this.objViewInfoENEx.objCodeType == null)
                        {
                            this.objViewInfoENEx.objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(this.objViewInfoENEx.CodeTypeId);
                        }
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue == null || objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.{objEditRegionFldsEx.PropertyName(this.IsFstLcase)} = false;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.{objEditRegionFldsEx.PropertyName(this.IsFstLcase)} = \"{objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue}\";");
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///����ؼ���������;
                                //strCodeForCs.AppendFormat("\r\n" + " ClearSelectValueByIdInDivObj(this.divEdit, \"{1}\");", ThisClsName, objEditRegionFldsEx.CtrlId);
                                //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "ClearSelectValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);
                                strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.{objEditRegionFldsEx.PropertyName(this.IsFstLcase)} = \"0\";");
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox": ///����ؼ��������ı���;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue == null || objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.{objEditRegionFldsEx.PropertyName(this.IsFstLcase)} = {strInitValue};");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.{objEditRegionFldsEx.PropertyName(this.IsFstLcase)} = \"{objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue}\";");
                                }
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.{objEditRegionFldsEx.PropertyName(this.IsFstLcase)} = {strInitValue};");
                                break;
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("�����ֶ�:{0}ʱ����!{1}(In {2})", objEditRegionFldsEx.FldName,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
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

        public string Gen_Vue_Ts_AddNewRecord()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //���ɵĲ����¼׼�����̴���for C#

                strCodeForCs.Append("\r\n /** Ϊ�����¼��׼������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async AddNewRecord()",
                TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecord.name;",
TabName_In4Edit4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                List<string> arrKey = new List<string>() { enumPrimaryType.Identity_02,
                enumPrimaryType.StringAutoAddPrimaryKey_03,
                enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06,
                enumPrimaryType.PrimaryKey_01 };

                if (arrKey.Contains(objKeyField.PrimaryTypeId) == false)
                {
                    if (objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => x.FldName == objKeyField.ObjFieldTabENEx.FldName).Count() > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.SetKeyReadOnly(false);",
                    TabName_In4Edit4GC);
                    }
                }


                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                    RefVarName = "strSubmitButtonText",
                    PropertyName = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                    Comment = "����ȷ����ť�ı���(Used In AddNewRecord())",
                    DataType = "string",
                    ParentDivName = $"this.divEdit",
                    ThisClsName = ThisEditClsName,
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                    RefVarName = "strCancelButtonText",
                    PropertyName = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                    Comment = "����ȡ����ť�ı���(Used In AddNewRecord())",
                    DataType = "string",
                    ParentDivName = $"this.divEdit",
                    ThisClsName = ThisEditClsName,
                });

                strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.Clear();");

                //��ȡ���ֵ
                strCodeForCs.AppendFormat("\r\n" + "//wuc{0}B1.{1} = {0}GetMaxStrId_S();",
                TabName_In4Edit4GC, objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objKeyField.ObjFieldTabENEx.FldLength);

                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdAsync)}();");

                    strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                        TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + $"this.keyId = returnString;");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ȡ��ؼ��ֵ����ֵ���ɹ�,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
                {

                    if (objPrefixField == null)
                    {
                        strCodeForCs.AppendFormat("\r\n // ��:{0}��������ǰ׺����,���ñ���û��һ����ص�ǰ׺�ֶΡ�����!(In {1})",
                                TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());

                    }

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objPrefixField == null)
                    {
                        strCodeForCs.AppendFormat("\r\n // ��:{0}��������ǰ׺����,���ñ���û��һ����ص�ǰ׺�ֶΡ�����!(In {1})",
                                TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + $"await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}(\"\");");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}({ThisClsName}.{objPrefixField.FldName}4PrefixStatic);");
                    }

                    strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                        TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"this.keyId = returnString;");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ȡ��ؼ��ֵ����ֵ���ɹ�,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

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

        public Tuple<string, bool> Gen_Vue_Ts_AddNewRecordWithMaxId_Body()
        {

            StringBuilder sbTemp = new StringBuilder();
            bool bolIsUseFuncName = false;
            //��ȡ���ֵ
            sbTemp.AppendFormat("\r\n" + "//this.{1} = await {0}_GetMaxStrIdAsync();",
            TabName_In4Edit4GC, objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objKeyField.ObjFieldTabENEx.FldLength);

            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {

                sbTemp.Append("\r\n" + "try");
                sbTemp.Append("\r\n" + "{");
                sbTemp.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdAsync)}();");

                sbTemp.Append("\r\n" + "if (returnString == \"\")");
                sbTemp.Append("\r\n" + "{");
                sbTemp.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                    TabName_In4Edit4GC);

                sbTemp.Append("\r\n" + "//��ʾ��Ϣ��");
                sbTemp.Append("\r\n" + "alert(strInfo);");
                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "else");
                sbTemp.Append("\r\n" + "{");

                sbTemp.Append("\r\n" + $"this.keyId = returnString;");

                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "catch(e)");
                sbTemp.Append("\r\n" + "{");
                sbTemp.Append("\r\n" + "const strMsg = Format(\"��ȡ��ؼ��ֵ����ֵ���ɹ�,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
                bolIsUseFuncName = true;
                sbTemp.Append("\r\n" + "console.error(strMsg);");
                sbTemp.Append("\r\n" + "alert(strMsg);");
                sbTemp.Append("\r\n" + "}");

            }
            else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
            {

                if (objPrefixField == null)
                {
                    sbTemp.AppendFormat("\r\n // ��:{0}��������ǰ׺����,���ñ���û��һ����ص�ǰ׺�ֶΡ�����!(In {1})",
                            TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());

                }

                sbTemp.Append("\r\n" + "try");
                sbTemp.Append("\r\n" + "{");
                if (objPrefixField == null)
                {
                    sbTemp.AppendFormat("\r\n // ��:{0}��������ǰ׺����,���ñ���û��һ����ص�ǰ׺�ֶΡ�����!(In {1})",
                            TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());
                    sbTemp.Append("\r\n" + $"await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}(\"\");");
                }
                else
                {
                    sbTemp.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}({ThisClsName}.{objPrefixField.FldName}4PrefixStatic);");
                }

                sbTemp.Append("\r\n" + "if (returnString == \"\")");
                sbTemp.Append("\r\n" + "{");
                sbTemp.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                    TabName_In4Edit4GC);

                sbTemp.Append("\r\n" + "//��ʾ��Ϣ��");
                sbTemp.Append("\r\n" + "alert(strInfo);");
                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "else");
                sbTemp.Append("\r\n" + "{");

                sbTemp.Append("\r\n" + $"this.keyId = returnString;");


                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "catch(e)");
                sbTemp.Append("\r\n" + "{");
                sbTemp.Append("\r\n" + "const strMsg = Format(\"��ȡ��ؼ��ֵ����ֵ���ɹ�,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
                bolIsUseFuncName = true;
                sbTemp.Append("\r\n" + "console.error(strMsg);");
                sbTemp.Append("\r\n" + "alert(strMsg);");
                sbTemp.Append("\r\n" + "}");

            }
            Tuple<string, bool> returnValue = Tuple.Create<string, bool>(sbTemp.ToString(), bolIsUseFuncName);
            return returnValue;
        }
        //���ɲ����¼׼�����̴���
        public string Gen_Vue_Ts_AddNewRecordWithMaxId()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            Tuple<string, bool> returnValue = Gen_Vue_Ts_AddNewRecordWithMaxId_Body();
            try
            {

                //���ɵĲ����¼׼�����̴���for C#

                strCodeForCs.Append("\r\n /** Ϊ�����¼��׼������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async AddNewRecordWithMaxId()",
                TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "{");
                if (returnValue.Item2 == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithMaxId.name;", TabName_In4Edit4GC, objKeyField.FldName);
                }
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    if (objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => x.FldName == objKeyField.ObjFieldTabENEx.FldName).Count() > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.SetKeyReadOnly(false);",
                        TabName_In4Edit4GC);
                    }
                }

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                    RefVarName = "strSubmitButtonText",
                    PropertyName = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                    Comment = "����ȷ����ť�ı���(Used In AddNewRecordWithMaxId())",
                    DataType = "string",
                    ThisClsName = ThisEditClsName,
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                    RefVarName = "strCancelButtonText",
                    PropertyName = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                    Comment = "����ȡ����ť�ı���(Used In AddNewRecordWithMaxId())",
                    DataType = "string",
                    ThisClsName = ThisEditClsName,
                });

                strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.Clear();");
                strCodeForCs.Append("\r\n" + returnValue.Item1);
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


        public string Gen_Vue_Ts_btnOKUpd_Click()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n * ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async btnSubmit_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnSubmit_Click.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strCommandText: string = this.btnSubmit{0};", this.TabName_In4Edit4GC);

                clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    RefVarName = "strSubmitButtonText",
                    PropertyName = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    Comment = "��ȡ��ť�ı���",
                    DataType = "string",
                    ParentDivName = "",
                    ThisClsName = ThisEditClsName,
                };
                arrPropertyDef4GC.Add(objPropertyDef4GC);

                strCodeForCs.Append("\r\n" + "try {");
                //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                //this.TabName_In4Edit4GC, this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "let returnBool = false;");

                StringBuilder sbDefVar = new StringBuilder();
                StringBuilder sbCodeNext = new StringBuilder();



                sbCodeNext.Append("\r\n" + "let strInfo = \"\";");
                sbCodeNext.Append("\r\n" + "let strMsg = \"\";");

                sbCodeNext.Append("\r\n" + "switch(strCommandText)");
                sbCodeNext.Append("\r\n" + "{");

                sbCodeNext.Append("\r\n" + "case \"���\":");
                sbCodeNext.AppendFormat("\r\n" + "this.btnSubmit{0} = \"ȷ�����\";", this.TabName_In4Edit4GC);
                sbCodeNext.AppendFormat("\r\n" + "this.btnCancel{0} = \"ȡ�����\";", this.TabName_In4Edit4GC);

                sbCodeNext.AppendFormat("\r\n" + " await this.AddNewRecord();",
                this.TabName_In4Edit4GC);
                sbCodeNext.Append("\r\n" + "break;				");
                sbCodeNext.Append("\r\n" + "case \"ȷ�����\":");
                sbCodeNext.Append("\r\n" + "//����һ������Ĳ���Ĵ���,�����߼���̫��,");
                sbCodeNext.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");
                if (thisEditTabProp_TS.KeyFldCount > 1)
                {
                    sbCodeNext.Append("\r\n" + "returnBool = await this.AddNewRecordSave();");
                    //sbCodeNext.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    sbCodeNext.Append("\r\n" + "if (returnBool == true)");
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                    ThisClsName);
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();");
                    sbCodeNext.Append("\r\n" + "}");
                    //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");
                    if (objKeyField.IsNumberType())
                    {
                        iShowList_BindGv(sbCodeNext, "this.keyId.toString()");
                    }
                    else
                    {
                        iShowList_BindGv(sbCodeNext, "this.keyId");
                    }
                    //sbCodeNext.Append("\r\n" + "}");

                    sbCodeNext.Append("\r\n" + "}");

                }
                else if (thisEditTabProp_TS.KeyFldCount == 1)
                {
                    sbCodeNext.Append("\r\n" + $"if (['02', '03', '06'].indexOf(cls{TabName_In4Edit}EN.PrimaryTypeId) > -1)");
                    sbCodeNext.Append("\r\n" + "{");
                    if (objKeyField.CsType != "string")
                    {
                        sbCodeNext.Append("\r\n" + "const returnKeyId = await this.AddNewRecordWithReturnKeySave();");
                        //sbCodeNext.Append("\r\n" + "//const returnKeyId: string = <string>jsonData;");
                        if (objKeyField.IsNumberType())
                        {
                            sbCodeNext.Append("\r\n" + "if (returnKeyId != 0)");
                        }
                        else
                        {
                            sbCodeNext.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false && returnKeyId != \"0\")");
                        }
                        sbCodeNext.Append("\r\n" + "{");
                        sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();");
                        sbCodeNext.AppendFormat("\r\n" + "if (this.iShowList != null) this.iShowList.BindGvCache(cls{0}EN._CurrTabName, \"\");", this.TabName_In4Edit4GC);

                        sbCodeNext.Append("\r\n" + "}");
                        //sbCodeNext.Append("\r\n" + "//});");

                    }
                    else
                    {
                        sbCodeNext.Append("\r\n" + "returnKeyId = await this.AddNewRecordWithMaxIdSave();");
                        //sbCodeNext.Append("\r\n" + "const returnKeyId: string = <string>jsonData;");
                        sbCodeNext.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                        AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                        sbCodeNext.Append("\r\n" + "{");
                        sbCodeNext.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId == enumPageDispMode.PopupBox_01)");
                        //sbCodeNext.Append("\r\n" + "{");
                        //sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();", ThisClsName);
                        //sbCodeNext.Append("\r\n" + "}");
                        sbCodeNext.Append("\r\n" + $"this.HideDialog_{TabName_In4Edit}();");
                        //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()?"Cache":"");

                        iShowList_BindGv(sbCodeNext, "returnKeyId");

                        sbCodeNext.Append("\r\n" + "}");
                        //�������returnKeyId
                        sbDefVar.Append("\r\n" + "let returnKeyId = \"\";");

                        //sbCodeNext.Append("\r\n" + "});");
                    }

                    sbCodeNext.Append("\r\n" + "}");
                    sbCodeNext.Append("\r\n" + "else");
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.AppendFormat("\r\n" + "returnBool = await this.AddNewRecordSave();",
                          this.TabName_In4Edit4GC);
                    //sbCodeNext.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    sbCodeNext.Append("\r\n" + "if (returnBool == true)");
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                    ThisClsName);
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();");
                    sbCodeNext.Append("\r\n" + "}");
                    //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");
                    if (objKeyField.IsNumberType())
                    {
                        iShowList_BindGv(sbCodeNext, "this.keyId.toString()");
                    }
                    else
                    {
                        iShowList_BindGv(sbCodeNext, "this.keyId");
                    }
                    sbCodeNext.Append("\r\n" + "}");
                    sbCodeNext.Append("\r\n" + "}");
                }
                sbCodeNext.Append("\r\n" + "break;");

                sbCodeNext.Append("\r\n" + "case \"ȷ���޸�\":");
                sbCodeNext.Append("\r\n" + "//����һ��������޸ĵĴ���,�����߼���̫��,");
                //sbCodeNext.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                //this.TabName_In4Edit4GC);
                sbCodeNext.AppendFormat("\r\n" + "returnBool = await this.UpdateRecordSave();",
                this.TabName_In4Edit4GC);
                //sbCodeNext.Append("\r\n" + "const returnBool: boolean = jsonData;");
                sbCodeNext.Append("\r\n" + "strInfo = returnBool ? \"�޸ĳɹ�!\" : \"�޸Ĳ��ɹ�!\";");
                sbCodeNext.AppendFormat("\r\n" + "strInfo += \"(In {0}.btnSubmit_Click)\";",
                    ThisClsName);

                sbCodeNext.Append("\r\n" + "//��ʾ��Ϣ��");
                sbCodeNext.Append("\r\n" + "//console.log(strInfo);");
                sbCodeNext.Append("\r\n" + "alert(strInfo);");

                sbCodeNext.Append("\r\n" + "if (returnBool == true)");
                sbCodeNext.Append("\r\n" + "{");

                sbCodeNext.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
     ThisClsName);
                sbCodeNext.Append("\r\n" + "{");
                sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();");
                sbCodeNext.Append("\r\n" + "}");
                //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");

                if (objKeyField.IsNumberType())
                {
                    iShowList_BindGv(sbCodeNext, "this.keyId.toString()");
                }
                else
                {
                    iShowList_BindGv(sbCodeNext, "this.keyId");
                }

                sbCodeNext.Append("\r\n" + "}");
                //sbCodeNext.Append("\r\n" + "});");
                sbCodeNext.Append("\r\n" + "break;");
                sbCodeNext.Append("\r\n" + "default:");
                sbCodeNext.Append("\r\n" + "strMsg = Format(\"strCommandText:{0}��switch��û�д���!(In btnSubmit_Click())\", strCommandText);");
                sbCodeNext.Append("\r\n" + "console.error(strMsg);");
                sbCodeNext.Append("\r\n" + "alert(strMsg);");
                sbCodeNext.Append("\r\n" + "break;");

                sbCodeNext.Append("\r\n" + "}");

                sbCodeNext.Append("\r\n" + "}");
                sbCodeNext.Append("\r\n" + "catch (e)");
                sbCodeNext.Append("\r\n" + "{");
                sbCodeNext.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0033)�ڱ����¼ʱ({3})ʱ����!����ϵ����Ա!{0}.(in {1}.{2})\", e, this.className, strThisFuncName, strCommandText);");
                sbCodeNext.Append("\r\n" + "console.error(strMsg);");
                sbCodeNext.Append("\r\n" + "alert(strMsg);");
                sbCodeNext.Append("\r\n" + "}");

                strCodeForCs.Append(sbDefVar.ToString());
                strCodeForCs.Append(sbCodeNext.ToString());

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

        public string Gen_Vue_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_ShowTabObj(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_UpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param sender\">�����б�</param>");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async UpdateRecord({0}):Promise<boolean> ",
                 thisEditTabProp_TS.KeyVarDefineLstStr);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.UpdateRecord.name;",
TabName_In4Edit4GC, objKeyField.FldName);

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                RefVarName = "strSubmitButtonText",
                PropertyName = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                Comment = "����ȷ����ť�ı���(Used In UpdateRecord())",
                DataType = "string",
                ThisClsName = ThisEditClsName,
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                RefVarName = "strCancelButtonText",
                PropertyName = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                Comment = "����ȡ����ť�ı���(Used In UpdateRecord())",
                DataType = "string",
                ThisClsName = ThisEditClsName,
            });

            if (objKeyField.IsNumberType())
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0};", objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0};", objKeyField.PrivFuncName);
            }


            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;


            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                //  objKeyField.PrivFuncName,
                //  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        //strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + $"const obj{TabName_In4Edit4GC}EN = await {thisWA_F_InEdit(WA_F.GetObjByKeyId)}({thisEditTabProp_TS.KeyPrivVarNameLstStr});");
            strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}EN == null)", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "        {");

            strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���Ϊ��.(in {0}.{1})\", this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "            alert(strMsg);");
            strCodeForCs.Append("\r\n" + "            return false;");
            strCodeForCs.Append("\r\n" + "        }");
            //strCodeForCs.AppendFormat("\r\n" + "this.obj{0} = obj{0}EN;", TabName_In4Edit4GC);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"���ݹؼ���:[{{0}}]��ȡ����{{1}}!\", strKeyId, obj{0}EN.{1});",
            //    TabName_In4Edit4GC,
            //    objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + $"await ref{ThisEditClsName}.value.ShowDataFrom{TabName_In4Edit4GC}Obj(obj{TabName_In4Edit4GC}EN);");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���UpdateRecord!\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "return true;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

      

        Func<clsEditRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_Vue_Ts_SetBindDdl()
        {
            return Gen_WApi_Ts_SetBindDdl();
        }


        public string Gen_Vue_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_SelectRecord(objvFunction4GeneCodeEN);
        }


        public string Gen_Vue_Ts_btnUpdateRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            List<string> arrFeatureId = new List<string>() { enumPrjFeature.UpdateRecord_0137, enumPrjFeature.UpdateRecord_0199 };
            var objFeatureRegionFlds_Update = objViewInfoENEx.arrFeatureRegionFlds.Find(x => arrFeatureId.Contains(x.FeatureId));

            string strFuncPara = "";
            if (thisEditTabProp_TS.KeyFldCount >= 1) strFuncPara = thisEditTabProp_TS.KeyVarDefineLstStr;
            else strFuncPara = thisEditTabProp_TS.KeyVarDefineLstStr;
            if (objFeatureRegionFlds_Update == null)
            {
                if (strFuncPara == "") strFuncPara = "strKeyId: string";
            }
            else if (objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                strFuncPara = "";

            }
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + $"public async btnUpdateRecord_Click({strFuncPara}) {{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecord_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);

            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objFeatureRegionFlds_Update == null
                    || string.IsNullOrEmpty(objFeatureRegionFlds_Update.KeyIdGetModeId)
                    || objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
                {
                    if (objKeyField.IsNumberType())
                    {
                        strCodeForCs.Append("\r\n" + $"if ({objKeyField.PrivFuncName} == 0)");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"if (IsNullOrEmpty({objKeyField.PrivFuncName}) == true)");
                        AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"�޸ļ�¼�Ĺؼ���Ϊ��,����!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKeyId = {0}.{1}Static;", this.ClsName, objKeyField.FldName);
                    if (objKeyField.IsNumberType() == true)
                    {
                        strCodeForCs.Append("\r\n" + "    if (strKeyId == 0)");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�޸ĵļ�¼!\");");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            strCodeForCs.Append("\r\n" + "try {");

            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");
            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_In4Edit}(this.opType);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");

            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", ThisClsName);

            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + $"const lngKeyId =  {objKeyField.PrivFuncName};");

                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
                     TabName_In4Edit4GC, TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const update = await this.UpdateRecord({objKeyField.PrivFuncName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord({0});",
                    thisEditTabProp_TS.KeyPrivVarNameLstStr);
            }
            strCodeForCs.Append("\r\n" + "if (update == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���޸ļ�¼ʱ,��ʾ��¼���ݲ��ɹ�!\");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0034)���޸ļ�¼ʱ����!����ϵ����Ա!{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** �����ݱ����޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            string strFuncPara = "strKeyId: string";
            if (thisEditTabProp_TS.KeyFldCount > 1) strFuncPara = thisEditTabProp_TS.KeyVarDefineLstStr;
            strCodeForCs.AppendFormat("\r\n" + "public async btnUpdateRecordInTab_Click({0}) {{",
                strFuncPara);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecordInTab_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);

            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�޸ĵļ�¼!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + "try {");

            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");
            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_In4Edit}(this.opType);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");

            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");
            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                     TabName_In4Edit4GC, TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                        TabName_In4Edit4GC, TabName_In4Edit4GC.ToLower());
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord({0});",
                    thisEditTabProp_TS.KeyPrivVarNameLstStr);
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0034)���޸ļ�¼ʱ����!����ϵ����Ա!{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ��Ӽ�¼���溯��  
        /// </summary>
        /// <returns></returns>
        public string Gen_Vue_Ts_AddNewRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����¼�¼,���溯��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async AddNewRecordSave(): Promise<boolean>{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "��ӡ��޸��õĲ�1��",
            //    DataType = "string"
            //});

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN;",
               this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ӽ����ȡ���ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckPropertyNew)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"������ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "//���Ψһ������");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {

                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Add(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.Append("\r\n" + $"if (bolIsExistCond{strVersion} == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + "let returnBool = false;");

            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {
                strCodeForCs.Append("\r\n" + $"returnBool = await {thisWA_F_InEdit(WA_F.AddNewRecordAsync)}(obj{TabName_In4Edit4GC}EN);");
            }
            else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                //strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}EN.dnFuncMapId) == true)", this.TabName_In4Edit4GC);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const returnKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithMaxIdAsync)}(obj{TabName_In4Edit4GC}EN);");

                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.keyId = returnKeyId;");
                strCodeForCs.Append("\r\n" + "returnBool = true;");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "}");

            }
            else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
            {
                //strCodeForCs.Append("\r\n" + "let returnBool = false;");
                //strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}EN.dnFuncMapId) == true)", this.TabName_In4Edit4GC);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const returnKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithMaxIdAsync)}(obj{TabName_In4Edit4GC}EN);");

                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "returnBool = true;");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "}");

            }
            else
            {
                if (thisEditTabProp_TS.KeyFldCount > 1)
                {
                    var arrTemp = thisEditTabProp_TS.PropertyNameLstrStr.Split(",".ToCharArray());
                    StringBuilder sbTemp = new StringBuilder();
                    foreach (string strInFor in arrTemp)
                    {
                        sbTemp.Append($"obj{TabName_In4Edit4GC}EN.{strInFor},");
                    }
                    strCodeForCs.Append("\r\n" + $"const bolIsExist = await {thisWA_F_InEdit(WA_F.IsExistAsync)}({sbTemp.ToString()});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const bolIsExist = await {thisWA_F_InEdit(WA_F.IsExistAsync)}(obj{TabName_In4Edit4GC}EN.{objKeyField.PropertyName(this.IsFstLcase)});");
                }
                strCodeForCs.Append("\r\n" + "if (bolIsExist == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��Ӽ�¼ʱ,�ؼ��֣�{{0}}�Ѿ�����!\", obj{0}EN.{1});",
                    this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return false;//һ��Ҫ��һ������ֵ,��������!");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"returnBool = await {thisWA_F_InEdit(WA_F.AddNewRecordAsync)}(obj{TabName_In4Edit4GC}EN);");

            }

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            if (PrjTabEx_EditRegion.IsUseStoreCache_TS() == false)
            {
                Gene_ReFreshCache(strCodeForCs, "");
            }
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼�ɹ�!`;");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "if (this.isShowMsg == true) alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼���ɹ�!`;");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��Ӽ�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_CheckUniCondition4Add(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_CheckUniCondition4Add(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_CheckUniCondition4Update(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_CheckUniCondition4Update(objvFunction4GeneCodeEN);
        }

        /// <summary>
        /// ��Ӽ�¼���溯��  
        /// </summary>
        /// <returns></returns>
        public string Gen_Vue_Ts_AddNewRecordWithMaxIdSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (thisEditTabProp_TS.KeyFldCount > 1) return "";

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����¼�¼,�ɺ�̨�Զ���ȡ���ֵ�Ĺؼ��֡����溯��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async AddNewRecordWithMaxIdSave(): Promise<string>{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithMaxIdSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "��ӡ��޸��õĲ�1��",
            //    DataType = "string"

            //});
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN;", this.TabName_In4Edit4GC);
            AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("cls{0}EN", this.TabName_In4Edit4GC), enumImportObjType.ENClass, this.strBaseUrl);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ӽ����ȡ���ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckPropertyNew)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"������ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {

            }
            else
            {

            }
            strCodeForCs.Append("\r\n" + "//���Ψһ������");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Add{strVersion}(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.Append("\r\n" + $"if (bolIsExistCond{strVersion} == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const responseKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithMaxIdAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.AppendFormat("\r\n" + "const returnKeyId: string = responseKeyId;",
                this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
            AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

            strCodeForCs.Append("\r\n" + "{");
            if (PrjTabEx_EditRegion.IsUseStoreCache_TS() == false)
            {
                Gene_ReFreshCache(strCodeForCs, "");
            }
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼�ɹ�!`;");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "if (this.isShowMsg == true) alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼���ɹ�!`;");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return responseKeyId;//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��Ӽ�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return \"\";//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_AddNewRecordWithReturnKeySave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (thisEditTabProp_TS.KeyFldCount > 1) return "";

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����¼�¼,�ɺ�̨�Զ���ȡ���ֵ�Ĺؼ��֡����溯��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.Append("\r\n" + "public async AddNewRecordWithReturnKeySave(): Promise<number>{");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public async AddNewRecordWithReturnKeySave(): Promise<string>{");
            }
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithReturnKeySave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "��ӡ��޸��õĲ�1��",
            //    DataType = "string"

            //});
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN;", this.TabName_In4Edit4GC);
            AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("cls{0}EN", this.TabName_In4Edit4GC), enumImportObjType.ENClass, this.strBaseUrl);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ӽ����ȡ���ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckPropertyNew)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"������ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {

            }
            else
            {

            }
            strCodeForCs.Append("\r\n" + "//���Ψһ������");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Add{strVersion}(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.Append("\r\n" + $"if (bolIsExistCond{strVersion} == false)");
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.IsNumberType())
                {
                    strCodeForCs.Append("\r\n" + "return 0;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "return \"\";");
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const responseKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithReturnKeyAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.AppendFormat("\r\n" + "const returnKeyId: string = responseKeyId;",
                this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
            AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.Append("\r\n" + $"obj{TabName_In4Edit4GC}EN.{objKeyField.PropertyName(this.IsFstLcase)} = Number(returnKeyId);");

            }
            else
            {
                strCodeForCs.Append("\r\n" + $"obj{TabName_In4Edit4GC}EN.{objKeyField.PropertyName(this.IsFstLcase)} = returnKeyId;");
            }
            if (PrjTabEx_EditRegion.IsUseStoreCache_TS() == false)
            {
                Gene_ReFreshCache(strCodeForCs, "");
            }
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼�ɹ�!`;");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "if (this.isShowMsg == true) alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼���ɹ�!`;");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.Append("\r\n" + "return Number(responseKeyId);//һ��Ҫ��һ������ֵ,��������!");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "return responseKeyId;//һ��Ҫ��һ������ֵ,��������!");
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��Ӽ�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.Append("\r\n" + "return 0;//һ��Ҫ��һ������ֵ,��������!");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "return \"\";//һ��Ҫ��һ������ֵ,��������!");
            }
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnAddNewRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����¼�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnAddNewRecord_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "this.opType = \"Add\";");
            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_In4Edit}(this.opType);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");
            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");
            strCodeForCs.Append("\r\n" + $"if (['02', '03', '06'].indexOf(cls{TabName_In4Edit}EN.PrimaryTypeId) > -1)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "await this.AddNewRecordWithMaxId();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.AddNewRecord();",
            TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����¼�¼��ʼ�����ɹ�,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnAddNewRecordWithMaxId_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����¼�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecordWithMaxId_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnAddNewRecordWithMaxId_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "this.opType = \"AddWithMaxId\";");

            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_In4Edit}(this.opType);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");

            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");

            strCodeForCs.AppendFormat("\r\n" + "this.AddNewRecordWithMaxId();",
                TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����¼�¼��ʼ�����ɹ�,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_GetMaxStrId(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_UpdateRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async UpdateRecordSave(): Promise<boolean> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.UpdateRecordSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + $"const obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");

            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(Number(this.keyId));",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.keyId);",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//������Щ�ֶα��޸�(���ֶ�)",
                this.TabName_In4Edit4GC);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0 || obj{0}EN.{1} == undefined){{",
                this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"�ؼ��ֲ���Ϊ��!\");");
                strCodeForCs.Append("\r\n" + "throw \"�ؼ��ֲ���Ϊ��!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == \"\" || obj{0}EN.{1} == undefined){{",
                        this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"�ؼ��ֲ���Ϊ��!\");");
                strCodeForCs.Append("\r\n" + "throw \"�ؼ��ֲ���Ϊ��!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckProperty4Update)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"������ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���Ψһ������");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Update(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.AppendFormat("\r\n" + $"if (bolIsExistCond{strVersion} == false)", objInFor.ConstraintName4GC());
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.UpdateRecordAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs, PrjTabEx_EditRegion.KeyPropNameLstStrWithObjName_TS);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�޸ļ�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_EditRecordExSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = null;
            var arrPrjConstraintSet = clsPrjConstraintBLEx.GetObjExLstByTabId(TabId_In4Edit);
            foreach (clsPrjConstraintEN objInFor in arrPrjConstraintSet)
            {
                if (objInFor.InUse == false) continue;
                if (objInFor.ConstraintTypeId != enumConstraintType.Uniqueness_01) continue;
                arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

            }
            if (arrObjLst_Flds == null || arrObjLst_Flds.Count() == 0) return "";


            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** �༭��¼�����ھ��޸ģ������ھ����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async EditRecordExSave(): Promise<boolean> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.EditRecordExSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + $"const obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");

            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(Number(this.keyId));",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.keyId);",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//������Щ�ֶα��޸�(���ֶ�)",
                this.TabName_In4Edit4GC);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0 || obj{0}EN.{1} == undefined){{",
                this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"�ؼ��ֲ���Ϊ��!\");");
                strCodeForCs.Append("\r\n" + "throw \"�ؼ��ֲ���Ϊ��!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == \"\" || obj{0}EN.{1} == undefined){{",
                        this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"�ؼ��ֲ���Ϊ��!\");");
                strCodeForCs.Append("\r\n" + "throw \"�ؼ��ֲ���Ϊ��!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckProperty4Update)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"������ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//һ��Ҫ��һ������ֵ,��������!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���Ψһ������");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Update(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.AppendFormat("\r\n" + $"if (bolIsExistCond{strVersion} == false)", objInFor.ConstraintName4GC());
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.EditRecordExAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs, PrjTabEx_EditRegion.KeyPropNameLstStrWithObjName_TS);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�޸ļ�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());



        public string Gen_Vue_Ts_PutDataToClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_PutDataToClass(objvFunction4GeneCodeEN);
        }
        public string Gen_Vue_Ts_GetDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_GetDataFromClass(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_GetFirstKey()
        {
            return Gen_WApi_Ts_GetFirstKey();
        }


        /// <summary>
        /// �������ڱ༭�Ĳ�Div,�ò���Ա�����
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_Vue_Ts_DefDiv4EditRegion()
        {
            return Gen_WApi_Ts_DefDiv4EditRegion();
        }

        public string Gen_Vue_Ts_ShowData()
        {
            //string strBy = objKeyField.FldName;
            //if (thisEditTabProp_TS.KeyFldCount > 1) strBy = "KeyLst";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveUpdateRecord()
|| objViewInfoENEx.objViewRegion_Feature.IsHaveDetailRecord())
                {
                    strCodeForCs.Append("\r\n /** ��������:���Ըùؼ��ֵļ�¼������ʾ�ڽ�����,");
                    strCodeForCs.Append("\r\n" + "* �������ǰ�ֵ������ؼ���");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n * @param {0}: ���¼�Ĺؼ���,��ʾ�ñ�ؼ��ֵ�����", objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "  public async ShowData({0}) {{",
                        thisEditTabProp_TS.KeyVarDefineLstStr);
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowData.name;", this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "        //��������:");
                    strCodeForCs.Append("\r\n" + "        //1�����ؼ����Ƿ�Ϊ�գ�");
                    strCodeForCs.Append("\r\n" + "        //2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.Append("\r\n" + "        //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                    strCodeForCs.Append("\r\n" + "        //4����ȡ�������������ԣ�");
                    strCodeForCs.Append("\r\n" + "        //5���Ѹö��������������ʾ�ڽ�����,��������ʾ�ڱ�ؼ���");
                    strCodeForCs.Append("\r\n" + "        //2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.AppendFormat("\r\n" + "        let obj{0}EN = new cls{0}EN();",
                        this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "        try {");

                    if (thisEditTabProp_TS.KeyFldCount > 1)
                    {
                        strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.IsExistAsync)}({thisEditTabProp_TS.KeyPrivVarNameLstStr});");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.IsExistAsync)}({objKeyField.PrivFuncName});");
                    }
                    strCodeForCs.Append("\r\n" + "            if (returnBool == false) {");
                    strCodeForCs.AppendFormat("\r\n" + "                const strInfo = Format(\"�ؼ���:[{{0}}] �ļ�¼������!\", {0});",
                         objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "                //��ʾ��Ϣ��");
                    strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    //strCodeForCs.Append("\r\n" + "            else {");
                    ////                    strCodeForCs.Append("\r\n" + "                const strInfo = Format(\"�ؼ���:[${strExam1TypeId}]����ؼ�¼����!\");");
                    ////                  strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    ////                strCodeForCs.Append("\r\n" + "                //��ʾ��Ϣ��");
                    ////              strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    //strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"�����Ӧ�ؼ��ֵļ�¼���ڲ��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        try {");

                    strCodeForCs.Append("\r\n" + $"const obj{TabName_In4Edit4GC}ENConst = await {thisWA_F_InEdit(WA_F.GetObjByKeyId)}({thisEditTabProp_TS.KeyPrivVarNameLstStr});");

                    strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}ENConst == null)", this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "        {");

                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���Ϊ��.(in {0}.{1})\", this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "            return;");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.AppendFormat("\r\n" + " obj{0}EN = obj{0}ENConst; ", this.TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");

                    strCodeForCs.Append("\r\n" + "        //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");

                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.ShowDataFrom{this.TabName_In4Edit4GC}Obj(obj{this.TabName_In4Edit4GC}EN);");

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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScript_EditCS_TS4TypeScript));
        }
        public override void GetClsName()
        {
            //this.ClsName = string.Format("WApi{0}_QUDI_TS", TabName_In4Edit4GC);
            //ThisClsName = this.ClsName;
            string strClassName = string.Format("WA_{0}_Edit", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = strClassName;

            objViewInfoENEx.ClsName = this.ClsName;
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
                        objViewInfoENEx.MainTabId, objViewInfoENEx.PrjDataBaseId, objViewInfoENEx.PrjId);
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

        public string Gen_Vue_Ts_Code4EditRegion()
        {
            return Gen_WApi_Ts_Code4EditRegion();
        }

        public string Gen_Vue_Ts_AddDPV_Edit(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strClassName = string.Format("WA_{0}_Edit", TabName_In4Edit4GC);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * �ڵ�ǰ������,����༭����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public async AddDPV_Edit(divName4Edit:string) {{",
                ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddDPV_Edit.name;",
TabName_In4Edit4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "CheckDivExist(divName4Edit);");
            //strCodeForCs.Append("\r\n" + "const objLst = document.getElementsByTagName(\"div\");");
            //strCodeForCs.Append("\r\n" + "const strStartName = \"divEditEdit\";");
            //strCodeForCs.AppendFormat("\r\n" + "let arrElement = WA_{0}_UT_JS.GetArray(objLst) ;", TabName_In4Edit4GC);

            //strCodeForCs.Append("\r\n" + "let arrDiv = arrElement ;");
            //strCodeForCs.Append("\r\n" + "let arrFind = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);");
            //strCodeForCs.Append("\r\n" + "arrFind.forEach(x => x.innerHTML = \"\");");
            //strCodeForCs.Append("\r\n" + "//var o = document.getElementById(\"div\") ;");
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = \"./{0}\";", strClassName);
            strCodeForCs.Append("\r\n" + "console.log(\"divName4Edit:(In AddDPV_Edit)\" + divName4Edit);");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"html\",");
            strCodeForCs.Append("\r\n" + "data: { },");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "console.log(\"�Ѿ��ɹ���ȡҳ��:\" + strUrl + \"  �ֽ���: \" + data.length.toString());");
            strCodeForCs.Append("\r\n" + "$('#' + divName4Edit).html(data);");

            strCodeForCs.Append("\r\n" + "resolve(true);");
            strCodeForCs.AppendFormat("\r\n" + "//setTimeout(() => {{ clsEditObj.BindTab(); }}, 100);");
            strCodeForCs.AppendFormat("\r\n" + "//clsEditObj.BindTab();");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: (e:any) => {");
            strCodeForCs.Append("\r\n" + "console.error(e);");
            strCodeForCs.Append("\r\n" + "reject(e);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }



        public string Gen_Vue_TS_ShowDialogBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ʾ�Ի���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public ShowDialog_{0}(strOp:string) {{", TabName_In4Edit4GC);
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;", TabName_In4Edit4GC);

            //strCodeForCs.Append("\r\n" + "   strOp = pstrOp;");
            strCodeForCs.Append("\r\n" + "//�����ؿؼ��Ƿ����");
            strCodeForCs.AppendFormat("\r\n" + $"CheckControlExist(this.divEdit, \"div\", \"divEditDialog_{0}\");", TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + $"CheckControlExist(this.divEdit, \"h4\", \"lblDialogTitle_{0}\");", TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"ȷ�����\";", TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"ȡ�����\";", TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('�޸ļ�¼');", TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_TS_HideDialogBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ضԻ���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public HideDialog_{0}() {{", TabName_In4Edit4GC);
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.HideDialog_{0}.name;", TabName_In4Edit4GC);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.AppendFormat("\r\n" + $"CheckControlExist(this.divEdit, \"div\", \"divEditDialog_{0}\");", TabName_In4Edit4GC);

            strCodeForCs.AppendFormat("\r\n" + "HideDialog('#divEditDialog_{0}');", TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_Vue_TS_ShowDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ʾ�Ի���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public async ShowDialog_{0}(strOp:string): Promise<boolean> {{", TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;", TabName_In4Edit4GC);

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId == enumPageDispMode.PopupBox_01)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if (ref{ThisEditClsName}.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(");
            strCodeForCs.Append("\r\n" + "'��ǰ�༭����EditObjΪ�գ����飡(in {0}.{1})',");
            strCodeForCs.Append("\r\n" + "this.className,");
            strCodeForCs.Append("\r\n" + "strThisFuncName,");
            strCodeForCs.Append("\r\n" + ");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + $"await ref{ThisEditClsName}.value.showDialog();");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + $"this.divEdit = ref{ThisEditClsName}.value.$refs.refDivEdit;");
            //strCodeForCs.Append("\r\n" + $"if (this.divEdit == null)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.times4TestShowDialog < 2)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog++;");
            //strCodeForCs.Append("\r\n" + "setTimeout(() => {");
            //strCodeForCs.Append("\r\n" + $"this.ShowDialog_{TabName_In4Edit4GC}(strOp);");
            //strCodeForCs.Append("\r\n" + "}, 100);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ǰ�༭���Ĳ�(div)����Ϊ�գ����飡(in {0}.{1})\", this.className, strThisFuncName);");
            //strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            //strCodeForCs.Append("\r\n" + "return false;");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "return false;");
            //strCodeForCs.Append("\r\n" + "} else {");
            //strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog = 0;");
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "console.log(strOp);");
            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"ȷ�����\";", TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"ȡ�����\";", TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"ȷ���޸�\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"ȡ���޸�\";", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            //strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            //strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_TS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���ضԻ���");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public HideDialog_{0}() {{", TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId == enumPageDispMode.PopupBox_01)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $" ref{ThisEditClsName}.value.hideDialog();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }



        public string Gen_Vue_TS_GetDivName(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ȡ�༭div����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "public getDivName(): HTMLDivElement | null {");
            strCodeForCs.Append("\r\n" + "const strThisFuncName = this.getDivName.name;");

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId != enumPageDispMode.PopupBox_01)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if (this.divEdit != null) return this.divEdit;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + $"if (ref{ThisEditClsName}.value.dialogVisible == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format('��ǰ�༭���ĵĶԻ���û�д򿪣����飡(in {0}.{1})',");
            strCodeForCs.Append("\r\n" + "this.className,");
            strCodeForCs.Append("\r\n" + "strThisFuncName,");
            strCodeForCs.Append("\r\n" + ");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + $"this.divEdit = ref{ThisEditClsName}.value.$refs.refDivEdit;");
            strCodeForCs.Append("\r\n" + $"if (this.divEdit == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.times4TestShowDialog < 2)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog++;");
            strCodeForCs.Append("\r\n" + "setTimeout(() => {");
            strCodeForCs.Append("\r\n" + $"this.getDivName();");
            strCodeForCs.Append("\r\n" + "}, 100);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ǰ�༭���Ĳ�(div)����Ϊ�գ����飡(in {0}.{1})\", this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "} else {");
            strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog = 0;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + $"return this.divEdit;");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        private void Gene_ReFreshCache(StringBuilder sbCode, string strParaStr)
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            if (PrjTabEx_ListRegion.IsUseStoreCache_TS() == true)
            {
                sbCode.Append("\r\n" + $"await {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store.delObj({strParaStr});");
                AddImportClass(TabId_In4Edit, clsString.FirstLcaseS(TabName_In4Edit4GC), string.Format("{0}Store", clsString.FirstLcaseS(TabName_In4Edit4GC)), enumImportObjType.StoreModule, $"@/store/modules{strIsShare}");
            }
            else if (objViewInfoENEx.objMainPrjTab.IsUseCache_TS() == true)
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", this.TabName_In4Edit4GC);
                }
                else if (objViewInfoENEx.objCacheClassifyFld4View2_TS == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.value);", this.TabName_In4Edit4GC, thisCacheClassify4View.ViewVarName);
                    AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.value, {2}.value);", this.TabName_In4Edit4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                    AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");
                    AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

                }
                AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("ReFreshCache", this.TabName_In4Edit4GC), enumImportObjType.WApiClassFunc, this.strBaseUrl);

            }
            else
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache();", this.TabName_In4Edit4GC);
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.value);", this.TabName_In4Edit4GC, thisCacheClassify4View.ViewVarName);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.value, {2}.value);", this.TabName_In4Edit4GC,
                        thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

        }

    }
}
