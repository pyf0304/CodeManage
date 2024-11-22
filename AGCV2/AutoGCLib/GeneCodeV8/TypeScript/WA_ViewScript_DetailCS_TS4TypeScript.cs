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
    partial class WA_ViewScript_DetailCS_TS4TypeScript : clsGeneCodeBase,IImportClass
    {
   
        protected string strMapFuncCode = "";

        protected bool bolIsUseFunc4Detail = false;
        
        
        //protected string TabId_Out4DetailRegion = "";
        protected clsPrjTabENEx objPrjTabEx_DetailRegion = null;
        public List<clsPropertyDef4GC> arrPropertyDef4GC = null;
        
        //private string strVarDef4GivingValue = "";

        #region ���캯��
        public WA_ViewScript_DetailCS_TS4TypeScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strBaseUrl = "../../TS";
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_ViewScript_DetailCS_TS4TypeScript(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strBaseUrl = "../../TS";
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_ViewScript_DetailCS_TS4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strBaseUrl = "../../TS";
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.GetClsName();
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
            this.arrImportClass = new List<ImportClass>();
        }
        /// <summary>
        /// ��ʼ��ҳ������
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;        ///�ؼ��������
            intCurrLeft = 10;  ///�ؼ�����߿�;
            intCurrTop = 10;
        }

        #endregion

        public string Gen_WApi_Ts_Page_Load()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* ��������:ҳ�浼��,��ҳ�濪ʼ����ʱ���������¼�");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public async PageLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PageLoad.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //����PageLoad�еİ�������Ĵ���
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //���û���
                strCodeForCs.Append("\r\n" + "this.SetEventFunc();");

                //strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
                List<string> arrTabName = new List<string>();



                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ҳ���������ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_SetEventFunc()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* ��������:�����¼�����");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public async SetEventFunc()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetEventFunc.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");


                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //����PageLoad�еİ�������Ĵ���
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                var arrDetailRegionFlds_ChangeEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.AppendFormat("\r\n" + "const {0} = < {1} > document.getElementById('{0}');",
                                    x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('change', e => {{ this.{0}_SelectedIndexChanged({1}); }});",
                       x.CtrlId, objViewInfoENEx.ClsName);
                });

                var arrDetailRegionFlds_ClickEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.AppendFormat("\r\n" + "const {0} = < {1} > document.getElementById('{0}');",
                                    x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('change', e => {{ this.{0}_Clicked({1}); }});",
                       x.CtrlId, objViewInfoENEx.ClsName);
                });
                if (arrDetailRegionFlds_ChangeEvent.Count == 0 && arrDetailRegionFlds_ClickEvent.Count == 0)
                {
                    strCodeForCs.Append("\r\n" + "//û�ж�������¼�");
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�����¼��������ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_GeneEventFunc()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {


                var arrDetailRegionFlds_ChangeEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /* ��������:ϵͳ���ɵ�Change�¼�����");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "*/");
                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;//",
                       x.ChangeEvent);
                    //strCodeForCs.AppendFormat("\r\n" + "alert('������չ��:{0}Ex�и��Ǹú���!');", objViewInfoENEx.ClsName);
                    //strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrDetailRegionFlds_ClickEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /* ��������:ϵͳ���ɵ�Click�¼�����");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "*/");

                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;",
                       x.ClickEvent, objViewInfoENEx.ClsName);

                });

                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }






        public string Gen_WApi_Ts_DdlBind4ViewFeatureInPage_Load()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strCacheClassifyFldName4View = "";
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                strCacheClassifyFldName4View = objViewInfoENEx.objCacheClassifyFld4View.FldName;
            }
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {


                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };

                //�ӽ��湦���ֶ��л�ȡ�������ֶ�

                IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    string strCtrlId = objInfor.CtrlId;
                    if (objInfor.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    {
                        if (strCtrlId.IndexOf("_SetFldValue") == -1)
                        {
                            strCtrlId = strCtrlId + "_SetFldValue";
                            objInfor.CtrlId = strCtrlId;
                        }
                    }
                    //strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl4WA_TS(objVarManage, strCacheClassifyFldName4View, thisCacheClassify4View.VarDef4Fld, objInfor.objFieldTabCacheClassify(), this, this.strBaseUrl));
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

        public void GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {

            //arrImportClass.Add(new ImportClass
            //{
            //    ClsName =  string.Format("cls{0}EN", TabName_Out4DetailRegion4GC),
            //    FilePath = string.Format("{0}/L0Entity/{1}/cls{2}EN.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC()
            //       TabName_Out4DetailRegion4GC)
            //});
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            arrImportClass.Add(new ImportClass
            {
                ClsName = "divVarSet",
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare", "", objFuncModule.FuncModuleEnName4GC(),
                  ViewMainTabName4GC)
            });
            arrImportClass.Add(new ImportClass
            {
                ClsName = $"ref{ThisDetailClsName}",
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare", "", objFuncModule.FuncModuleEnName4GC(),
              ViewMainTabName4GC)
            });
            if (bolIsUseFunc4Detail == true)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName =  string.Format("cls{0}ENEx",TabName_Out4DetailRegion4GC),
                    FilePath = string.Format("{0}/L0Entity/{1}/cls{2}ENEx.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
                        TabName_Out4DetailRegion4GC)
                });
    
            }
            

            if (objViewInfoENEx.CodeTypeId == enumCodeType.WA_ViewScript_DetailCS_TS_0251)
            {
            //    arrImportClass.Add(new ImportClass
            //    {
            //        ClsName =  string.Format("arrSelectedKeys", objViewInfoENEx.TabName),
            //        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC()
            //objViewInfoENEx.TabName)
            //    });
            }
            else
            {
            //    arrImportClass.Add(new ImportClass
            //    {
            //        ClsName =  string.Format("HideDialog, ShowDialog", objViewInfoENEx.TabName),
            //        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC()
            //objViewInfoENEx.TabName)
            //    });
            }
            arrImportClass.Add(new ImportClass
            {
                ClsName =  string.Format("SetLabelHtmlByIdInDivObj", objViewInfoENEx.TabName),
                FilePath = string.Format("{0}/PubFun/clsCommFunc4Ctrl.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
objViewInfoENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClsName =  string.Format("Format", objViewInfoENEx.TabName),
                FilePath = string.Format("{0}/PubFun/clsString.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
 objViewInfoENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClsName =  string.Format("IShowList", objViewInfoENEx.TabName),
                FilePath = string.Format("{0}/PubFun/IShowList.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
 objViewInfoENEx.TabName)
            });

            var objPrjTab_PageDispMode = clsPrjTabBLEx.GetObjByTabNameExCache(objViewInfoENEx.PrjId, conPageDispMode._CurrTabName);
            if (objPrjTab_PageDispMode != null)
            {
                var objFuncModule_PageDispMode = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTab_PageDispMode.FuncModuleAgcId, objPrjTab_PageDispMode.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClsName =  string.Format("enumPageDispMode", this.TabName_In4Edit4GC),
                    FilePath = string.Format("{0}/PubFun/enumPageDispMode.js", this.strBaseUrl, objFuncModule_PageDispMode.FuncModuleEnName4GC())
                });
            }

        }
        /// <summary>
        /// ����Appҳ���̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objViewInfoENEx.objViewRegion_Detail == null || objViewInfoENEx.objViewRegion_Detail.InUseInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            //���û���������;
            if (objViewInfoENEx.arrDetailRegionFldSet4InUse == null || objViewInfoENEx.arrDetailRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrDetailRegionFldSet4InUse.Where(x => x.IsUseFunc() == true).Count() > 0)
            {
                this.bolIsUseFunc4Detail = true;
            }
            //TabName_Out4DetailRegion4GC = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);
            //TabId_Out4DetailRegion = objViewInfoENEx.objViewRegion_Detail.TabId;
            var objPrjTab_DetailRegion = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4DetailRegion, objViewInfoENEx.PrjId);
           

            objPrjTabEx_DetailRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_DetailRegion);
            objPrjTabEx_DetailRegion.GetObjAllInfoEx();

            string strFuncName = "";
            string strTemp = ""; ///��ʱ����;
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);


            //if (PrjTabEx_ListRegion.IsUseCache_TS())
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDICache", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDICache.ts",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}
            //else
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDI_TS.ts",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}

            objViewInfoENEx.WebFormName = objViewInfoENEx.ClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", objViewInfoENEx.ClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
             objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModuleEN, objViewInfoENEx, objViewInfoENEx.TabName);

            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
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
                          
                //������ʼ
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                GetImportClassLst(objFuncModuleEN);

                arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
                strCodeForCs.Append("\r\n" + "//import $ from \"jquery\";");

                foreach (var objInFor in arrImportClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClsName,
                        objInFor.FilePath);
                }
            
                strCodeForCs.Append("\r\n" + " /**");
                strCodeForCs.Append("\r\n" + "* ����һ���Ѿ��ڴ��ڵĺ���ShowDialog,������ʾ�����,");
                strCodeForCs.Append("\r\n" + "* strOpType���ǲ�������,����������֮һ��Add, Update, Detail");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "declare function ShowDialog(strDialogName:string): void;", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* ����һ���Ѿ��ڴ��ڵĺ���HideDialog,�������ض����,");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "declare function HideDialog(strDialogName:string): void;", objViewInfoENEx.TabName_In);
                      
                strCodeForCs.AppendFormat("\r\n /* {0} ��ժҪ˵��������Q�����ѯ,U�����޸�",
                    objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class  {0} ", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "public opType = \"\";");
                strCodeForCs.Append("\r\n" + "public keyId = \"\";");

                //strCodeForCs.Append("\r\n" + GeneViewCacheStaticVar());
                strCodeForCs.Append("\r\n" + GeneViewPubVar_TS(strFuncName));

                strCodeForCs.Append("\r\n" + "private iShowList: IShowList;");

                strCodeForCs.Append("\r\n" + "public mstrListDiv = \"divDataLst\";");
                strCodeForCs.Append("\r\n" + "public bolIsLoadDetailRegion = false;  //��¼�Ƿ���༭���ı���");
                
                strCodeForCs.Append("\r\n" + "public divName4Detail = \"divDetail\";  //�༭����Id");
                
                strCodeForCs.Append("\r\n" + "constructor(objShowList: IShowList) {");
                strCodeForCs.Append("\r\n" + "this.iShowList = objShowList;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "");
       
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    
                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }

                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(strCodeForCs, arrPropertyDef4GC, $"divVarSet.refDivDetail", this, this.strBaseUrl);

                //strCodeForCs.Append("\r\n" + "}");
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

    
        public void Gen_WApi_Ts_ControlProperty4One_NotInDiv(StringBuilder strCodeForCs, clsPropertyDef4GC x)
        {
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
            //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
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
                            strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
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
                            strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
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
                            strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
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

                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
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

        public void Gen_WApi_Ts_ControlPropertyBak(StringBuilder strCodeForCs)
        {
            var arrPropertyDef4GC2 = arrPropertyDef4GC.OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.ParentDivName) == true)
                {
                    Gen_WApi_Ts_ControlProperty4One_NotInDiv(strCodeForCs, x);
                    return;
                }
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                string strIsStatic = "";
                if (x.IsStatic) strIsStatic = "static";
                switch (x.OperateType)
                {
                    case "get":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                        strCodeForCs.Append("\r\n" + $"const objDiv = $(`#$divVarSet.refDivDetail`);");

                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).prop(\"checked\");");

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).prop(\"checked\");");
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
                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
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
                                }
                                else if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return 0;", x.CtrlId);

                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return \"\";", x.CtrlId);

                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                                }
                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//�������(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//�������,ֱ�ӷ���");
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
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
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
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
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
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
                        strCodeForCs.Append("\r\n" + "const objDiv = $(`#${(divVarSet.refDivDetail)}`);");
                        

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


        public string Gen_WApi_Ts_Demo_Session(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "��ʾSession ����");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async Demo_Session()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Demo_Session.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//����Session");
            strCodeForCs.Append("\r\n" + "const strUserId = \"TestUserId\";");
            strCodeForCs.Append("\r\n" + "await this.SetSessionAsync(\"UserId\", strUserId);");
            strCodeForCs.Append("\r\n" + "//��ȡSession");
            strCodeForCs.Append("\r\n" + "const strUserId_Value1 = await this.GetSessionAsync(\"UserId\");");
            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value1:' + strUserId_Value1);");
            strCodeForCs.Append("\r\n" + "//��ȡSession����2��ֱ�Ӷ�ȡҳ���е�hidUserId");
            //          strCodeForCs.Append("\r\n" + " strUserId_Value2 = $('#hidUserId').val();");
            strCodeForCs.Append("\r\n" + "const strUserId_Value2 = this.hidUserId;");


            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value2:' + strUserId_Value2);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ʾSession���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_SetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "����Session");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">�ؼ���</param>");
            strCodeForCs.Append("\r\n" + "<param name = \"Value\">ֵ</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public SetSessionAsync(Key: string, Value: string): Promise<void> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetSessionAsync.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");


            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "            $.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl_Session_SetString,");
            strCodeForCs.Append("\r\n" + "cache: false,");
            strCodeForCs.Append("\r\n" + "async: false,");
            strCodeForCs.Append("\r\n" + "type: 'get',");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
            strCodeForCs.Append("\r\n" + "data: {");
            strCodeForCs.Append("\r\n" + "Key: Key,");
            strCodeForCs.Append("\r\n" + "Value: Value");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "success: function (data) {");
            strCodeForCs.Append("\r\n" + "const strKey = data.key;");
            strCodeForCs.Append("\r\n" + "const strValue = data.value;");


            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_GetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "��ȡSession �ؼ��ֵ�ֵ");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">�ؼ���</param>");
            strCodeForCs.Append("\r\n" + " <return>ֵ</return>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public GetSessionAsync(Key: string): Promise<string> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetSessionAsync.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "            $.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl_Session_GetString,");
            strCodeForCs.Append("\r\n" + "cache: false,");
            strCodeForCs.Append("\r\n" + "async: false,");
            strCodeForCs.Append("\r\n" + "type: 'get',");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
            strCodeForCs.Append("\r\n" + "data: {");
            strCodeForCs.Append("\r\n" + "Key: Key,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "success: function (data) {");
            strCodeForCs.Append("\r\n" + "const strKey = data.key;");
            strCodeForCs.Append("\r\n" + "const strValue = data.value;");

            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�������!�������粻�ɹ�!\");");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_SetKeyReadOnly()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //����˽�д���;
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                    {
                        if (objDetailRegionFldsEx.FldName != objKeyField.ObjFieldTabENEx.FldName) continue;
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                        strCodeForCs.Append("\r\n" + "public SetKeyReadOnly(bolReadonly:boolean)");
                        strCodeForCs.Append("\r\n" + "{");
//                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetKeyReadOnly.name;",
//objViewInfoENEx.TabName, objKeyField.FldName);
                        //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");


                        strCodeForCs.AppendFormat("\r\n" + "$('#{0}').attr('ReadOnly', bolReadonly.toString());", objDetailRegionFldsEx.CtrlId);
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

        public string Gen_WApi_Ts_Clear()
        {
            return "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //����˽�д���;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public Clear()");
                strCodeForCs.Append("\r\n" + "{");
//                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Clear.name;",
//objViewInfoENEx.TabName, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                {


                    if (objDetailRegionFldsEx.InUse == false) continue;
                    if (objDetailRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objDetailRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    try
                    {
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "set",
                            ControlType = objDetailRegionFldsEx.CtlTypeName,
                            CtrlId = objDetailRegionFldsEx.CtrlId,
                            PropertyName = objDetailRegionFldsEx.FldName,
                            Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "Clear()"),
                            DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                            ParentDivName = $"divVarSet.refDivDetail"
                        });
                        string strInitValue = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objDetailRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objDetailRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = false;",
                                    objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objDetailRegionFldsEx.PropertyName(this.IsFstLcase),
                                    objDetailRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///����ؼ���������;
                                
                                strCodeForCs.AppendFormat("\r\n" + " ClearSelectValueByIdInDivObj(this.divEdit, \"{1}\");", ThisClsName, objDetailRegionFldsEx.CtrlId);
                                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "ClearSelectValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

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
                                if (objDetailRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objDetailRegionFldsEx.FldName, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = \"{1}\";",
                                        objDetailRegionFldsEx.PropertyName(this.IsFstLcase), objDetailRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                 objDetailRegionFldsEx.PropertyName(this.IsFstLcase), strInitValue);
                                break;
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("�����ֶ�:{0}ʱ����!{1}(In {2})", objDetailRegionFldsEx.FldName,
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

        //���ɲ����¼׼�����̴���
        private void iShowList_BindGv(StringBuilder strCode)
        {
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                strCode.AppendFormat("\r\n" + "if (this.iShowList != null) this.iShowList.BindGvCache(cls{0}EN._CurrTabName, \"\");", TabName_Out4DetailRegion4GC);
            }
            else
            {
                strCode.AppendFormat("\r\n" + "if (this.iShowList != null) this.iShowList.BindGv(cls{0}EN._CurrTabName, \"\");", TabName_Out4DetailRegion4GC);
            }
        }
        private void await_iShowList_BindGv(StringBuilder strCode)
        {
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                strCode.AppendFormat("\r\n" + "if (this.iShowList != null) const conShowList = await this.iShowList.BindGvCache(cls{0}EN._CurrTabName, \"\");", TabName_Out4DetailRegion4GC);
            }
            else
            {
                strCode.AppendFormat("\r\n" + "if (this.iShowList != null) const conShowList = await this.iShowList.BindGv(cls{0}EN._CurrTabName, \"\");", TabName_Out4DetailRegion4GC);
            }
        }

        public string Gen_WApi_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ��ʾ{0}�������������ֵ");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n  <param name = \"divContainer\">��ʾ����</param>");
            strCodeForCs.AppendFormat("\r\n  <param name = \"obj{0}\">��Ҫ��ʾ�Ķ���</param>",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public Show{0}Obj(divContainer: HTMLDivElement, obj{0}: cls{0}EN) ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Show{0}Obj.name;",
objViewInfoENEx.TabName);

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}������!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = clsCommFunc4Web.GetObjKeys(obj{0});",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "const ul: HTMLUListElement = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "const li: HTMLLIElement = document.createElement(\"li\");");
            strCodeForCs.Append("\r\n" + "li.innerHTML = Format(\"{0}:{1}\", strKey, strValue);");
            strCodeForCs.Append("\r\n" + "ul.appendChild(li);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "divContainer.appendChild(ul);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }




        public string Gen_WApi_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "���ݹؼ���ѡ����Ӧ�ļ�¼");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async SelectRecord({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SelectRecord.name;",
objViewInfoENEx.TabName, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            //strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtstrKeyId{0}').val();",
            //        objvFunction4GeneCodeEN.OrderNum);

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
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + $"const obj{TabName_Out4DetailRegion}EN = await {thisWA_F_InDetail(WA_F.GetObjByKeyId)}({objKeyField.PrivFuncName});");


            strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}EN == null)", TabName_Out4DetailRegion4GC);
            strCodeForCs.Append("\r\n" + "        {");

            strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���Ϊ��.(in {0}.{1})\", this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "            alert(strMsg);");
            strCodeForCs.Append("\r\n" + "            return false;");
            strCodeForCs.Append("\r\n" + "        }");
            
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���SelectRecord!\", obj{0}EN);", objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.Redirect(\"/Index/Main_{0}\");", TabName_Out4DetailRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_DetailRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4Detail == true) return "";
            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "���ݹؼ�����ϸ��Ϣ��¼");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n" + "*/");
            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "public async DetailRecord({0}):Promise<boolean> ",
                     objPrjTabEx_DetailRegion.KeyVarDefineLstStr_TS);
            }
            else
            {            
            strCodeForCs.AppendFormat("\r\n" + "public async DetailRecord({0}: {1}):Promise<boolean> ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.DetailRecord.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"\";", TabName_Out4DetailRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"�ر�\";", TabName_Out4DetailRegion4GC);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "button",
            //    CtrlId = string.Format("btnSubmit{0}", TabName_Out4DetailRegion4GC),
            //    PropertyName = string.Format("btnSubmit{0}", TabName_Out4DetailRegion4GC),
            //    Comment = "����ȷ����ť�ı���(Used In DetailRecord())",
            //    DataType = "string",
            //    ParentDivName = $"divVarSet.refDivDetail",
            //    ThisClsName = ThisClsName,
            //});

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel{0}", TabName_Out4DetailRegion4GC),
                RefVarName = "strCancelButtonText",
                PropertyName = string.Format("btnCancel{0}", TabName_Out4DetailRegion4GC),
                Comment = "����ȡ����ť�ı���(Used In DetailRecord())",
                DataType = "string",
                ParentDivName = $"divVarSet.refDivDetail",
                ThisClsName = ThisClsName,
            });

            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

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

            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + $"const obj{TabName_Out4DetailRegion4GC}EN = await {thisWA_F_InDetail(WA_F.GetObjByKeyLstAsync)}({objPrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS});");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const obj{TabName_Out4DetailRegion4GC}EN = await {thisWA_F_InDetail(WA_F.GetObjByKeyId)}({objKeyField.PrivFuncName});");
            }

            strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}EN == null)", TabName_Out4DetailRegion4GC);
            strCodeForCs.Append("\r\n" + "        {");

            strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���Ϊ��.(in {0}.{1})\", this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "            alert(strMsg);");
            strCodeForCs.Append("\r\n" + "            return false;");
            strCodeForCs.Append("\r\n" + "        }");
            
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDetailDataFrom{0}Class(obj{0}EN);",
                TabName_Out4DetailRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���DetailRecord!\");", TabName_Out4DetailRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ʾ��ϸ��Ϣ���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "            return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "            return true;");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_DetailRecord4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4Detail == false) return "";
            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "���ݹؼ�����ϸ��Ϣ��¼");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n" + "*/");
            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "public async DetailRecord4Func({0}) ",
                    objPrjTabEx_DetailRegion.KeyVarDefineLstStr_TS);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public async DetailRecord4Func({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.DetailRecord4Func.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"\";", TabName_Out4DetailRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"�ر�\";", TabName_Out4DetailRegion4GC);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "button",
            //    CtrlId = string.Format("btnSubmit{0}", TabName_Out4DetailRegion4GC),
            //    PropertyName = string.Format("btnSubmit{0}", TabName_Out4DetailRegion4GC),
            //    Comment = "����ȷ����ť�ı���(Used In DetailRecord())",
            //    DataType = "string",
            //    ParentDivName = $"divVarSet.refDivDetail",
            //    ThisClsName = ThisClsName,
            //});


            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel{0}", TabName_Out4DetailRegion4GC),
                RefVarName = "strCancelButtonText",
                PropertyName = string.Format("btnCancel{0}", TabName_Out4DetailRegion4GC),
                Comment = "����ȡ����ť�ı���(Used In DetailRecord())",
                DataType = "string",
                ParentDivName = $"divVarSet.refDivDetail",
                ThisClsName = ThisClsName,
            });

            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

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
            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + $"const obj{TabName_Out4DetailRegion4GC}EN = await {thisWA_F_InDetail(WA_F.GetObjByKeyLstAsync)}({objPrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS});");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const obj{TabName_Out4DetailRegion4GC}EN = await {thisWA_F_InDetail(WA_F.GetObjByKeyId)}({objKeyField.PrivFuncName});");                
            }

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}ENEx = new cls{0}ENEx();", TabName_Out4DetailRegion4GC);

            //strCodeForCs.AppendFormat("\r\n" + "const objEx = new cls{0}ENEx(); ", TabName_Out4DetailRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}ENEx, obj{0}EN); ", TabName_Out4DetailRegion4GC);
            AddImportClass(TabId_Out4DetailRegion, "/PubFun/clsCommFunc4Web.js", "ObjectAssign", enumImportObjType.CustomFunc, this.strBaseUrl);
            foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
            {
                if (objDetailRegionFldsEx.IsUseFunc() == false) continue;
                strCodeForCs.Append("\r\n" + $"await {thisWA_F_InDetail(WA_F.FuncMapByFldName)}(cls{TabName_Out4DetailRegion4GC}ENEx.con_{objDetailRegionFldsEx.DataPropertyName4GC()}, obj{TabName_Out4DetailRegion4GC}ENEx);");               
            }
            
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDetailDataFrom{0}Class4Func(obj{0}ENEx);",
                TabName_Out4DetailRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���DetailRecord4Func!\");", TabName_Out4DetailRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ʾ��ϸ��Ϣ4Func���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
      
        public string Gen_WApi_Ts_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n �����ݱ�����ϸ��Ϣ��¼");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "public async btnDetailRecordInTab_Click({0}) {{", objPrjTabEx_DetailRegion.KeyVarDefineLstStr_TS);
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public async btnDetailRecordInTab_Click(strKeyId:string) {");
            }
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDetailRecordInTab_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Detail\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"Detail\";");
            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_Out4DetailRegion}('Detail');");
                strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabEx_DetailRegion.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " if ({0} == 0)", objInFor.PrivFuncName);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + " if (IsNullOrEmpty({0}) == true)", objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ��ϸ��Ϣ�ļ�¼!\");");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            else
            {
                strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ��ϸ��Ϣ�ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
            }
            string strSuffix4Func = "";//��׺4Func
            if (bolIsUseFunc4Detail == true) strSuffix4Func = "4Func";
            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");
            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}({1});",
                     strSuffix4Func, objPrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}({1});",
                        strSuffix4Func, objPrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS);
                }
            }
            else
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(lngKeyId);",
                     strSuffix4Func);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(strKeyId);",
                        strSuffix4Func);
                }
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ϸ��Ϣ��¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnDetailRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            var objFeatureRegionFlds_Detail = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.DetailRecord_0239);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "public async btnDetailRecord_Click({0}) {{", objPrjTabEx_DetailRegion.KeyVarDefineLstStr_TS);
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public async btnDetailRecord_Click(strKeyId:string) {");
            }
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDetailRecord_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"Detail\";");

            if (objFeatureRegionFlds_Detail == null
                || string.IsNullOrEmpty(objFeatureRegionFlds_Detail.KeyIdGetModeId)
                || objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
            {
                if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
                {
                    foreach (var objInFor in objPrjTabEx_DetailRegion.arrKeyFldSet)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " if (IsNullOrEmpty({0}) == true)", objInFor.PrivFuncName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ��ϸ��Ϣ�ļ�¼!\");");
                        strCodeForCs.Append("\r\n" + "return \"\";");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strKeyId) == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"��Ҫ��ʾ��ϸ��Ϣ��¼�Ĺؼ���Ϊ��,����!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");

                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            else if (objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                strCodeForCs.AppendFormat("\r\n" + "strKeyId = {0}.{1}_Static;", this.ClsName, objKeyField.FldName);
                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == 0)");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"����ʾ��ϸ��Ϣʱ,���澲̬�ؼ���Ϊ��!(In btnDetailRecord_Click)\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadDetailRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const responseBool = await this.AddDPV_Detail(divVarSet.refDivDetail);");
            strCodeForCs.Append("\r\n // Ϊ�༭����������");
            strCodeForCs.AppendFormat("\r\n" + "//const conBindDdl = await this.BindDdl4DetailRegion();", objViewInfoENEx.ClsName);

           
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadDetailRegion = true;  //", objViewInfoENEx.ClsName);
            string strSuffix4Func = "";//��׺4Func
            if (bolIsUseFunc4Detail == true) strSuffix4Func = "4Func";
            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}({1});",
                     strSuffix4Func, objPrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}({1});",
                        strSuffix4Func, objPrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS);
                }
            }
            else
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(lngKeyId);",
                     strSuffix4Func);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(strKeyId);",
                        strSuffix4Func);
                }
            }
            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Detail');", objViewInfoENEx.TabName_In);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabEx_DetailRegion.arrKeyFldSet.Count > 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}({1});",
                     strSuffix4Func, objPrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}({1});",
                        strSuffix4Func, objPrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS);
                }
            }
            else
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(lngKeyId);",
                     strSuffix4Func);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(strKeyId);",
                        strSuffix4Func);
                }
            }
            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Detail');", objViewInfoENEx.TabName_In);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

      
    
        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());





        private void GC_GetInputValue4Para_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strCodeForCs)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
            clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
                                objDataTypeAbbrEN.TypeScriptType,
                                objFuncPara4CodeEN.ParaName,
                                objvFunction4GeneCodeEN.OrderNum);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                case enumDataTypeAbbr.int_09:
                                case enumDataTypeAbbr.bigint_01:
                                case enumDataTypeAbbr.bigintidentity_26:

                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                default:
                                    strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.TypeScriptType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //if (objSelfDefDataTypeEN_Para != null)
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objSelfDefDataTypeEN_Para.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //else
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objDataTypeAbbrEN.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }

        }
        public string Gen_WApi_Ts_GetDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* ��������:������������������ʾ��������");
                strCodeForCs.Append("\r\n ע��:���������������,������һ��������������ϵ��,����Ϊһ��������ֵ,Ȼ����Ϊ����������ֵ");
                strCodeForCs.Append("\r\n  ������������ݿ�ʱ,��Ӧ��һ���ֶ���ǰ,�����ֶ��ں�");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">��ʵ�������</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public async GetDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetDataFrom{0}Class.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");


                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInGetDataFromClass(objDetailRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

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

        public string Gen_WApi_Ts_ShowDetailDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4Detail == true) return "";
            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* ��������:������������������ʾ���������ϸ��Ϣ������");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">��ʵ�������</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public ShowDetailDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                           TabName_Out4DetailRegion4GC, TabName_Out4DetailRegion4GC, TabName_Out4DetailRegion4GC);
                strCodeForCs.Append("\r\n" + "{");
//                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDetailDataFrom{0}Class.name;",
//TabName_Out4DetailRegion4GC, objKeyField.FldName);
                AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion4GC, string.Format("cls{0}EN", TabName_Out4DetailRegion4GC), enumImportObjType.ENClass, this.strBaseUrl);

                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInShowDetailDataFromClass(objDetailRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

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

        private string GetCode4FieldInShowDetailDataFromClass(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
   
            StringBuilder sbCodeForCs = new StringBuilder();

            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = objDetailRegionFldsEx.CtlTypeName,
                CtrlId = objDetailRegionFldsEx.CtrlId + "_d",
                PropertyName = objDetailRegionFldsEx.PropertyName(this.IsFstLcase) + "_d",
                Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "ShowDetailDataFromClass()"),
                DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                ParentDivName = $"divVarSet.refDivDetail"
            });
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlType.CheckBox_02:
                    //7������checkboxΪѡ��״̬
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8������checkboxΪ��ѡ��״̬
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                TabName_Out4DetailRegion4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                TabName_Out4DetailRegion4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                TabName_Out4DetailRegion4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                TabName_Out4DetailRegion4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }


        private string GetCode4FieldInGetDataFromClass(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objDetailRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objDetailRegionFldsEx.CtlTypeName,
                    CtrlId = objDetailRegionFldsEx.CtrlId,
                    PropertyName = objDetailRegionFldsEx.FldName,
                    Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "GetDataFromClass()"),
                    DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                });
            }
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlType.CheckBox_02:
                    //7������checkboxΪѡ��״̬
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8������checkboxΪ��ѡ��״̬
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2} = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_GetFirstKey()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* ��������:�ӽ����б��л�ȡ��һ���ؼ��ֵ�ֵ");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">��ʵ�������</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n <returns>�б�ĵ�һ���ؼ���ֵ</returns>");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public GetFirstKey(): string {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetFirstKey.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                strCodeForCs.Append("\r\n" + "if (arrSelectedKeys.length == 1) {");
                strCodeForCs.Append("\r\n" + "return arrSelectedKeys[0];");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else {");

                strCodeForCs.Append("\r\n" + "alert(`��ѡ��һ���ؼ���!Ŀǰѡ����:${ arrSelectedKeys.length}���ؼ��֡�`);");
                strCodeForCs.Append("\r\n" + "return \"\";");

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

        public string Gen_WApi_Ts_IndexPage()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* ��������:������ �б�����ת��ĳһҳ");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"intPageIndex\">ҳ���</param>",
                        objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public IndexPage(intPageIndex:number)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "if (intPageIndex == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "intPageIndex = this.objPager.pageCount;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "console.log(\"��ת��\" + intPageIndex + \"ҳ\");");

                //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intPageIndex;");
                strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intPageIndex);");

                //strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{1}{2}();",
                //    objViewInfoENEx.TabName, TabName_Out4DetailRegion4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");
                await_iShowList_BindGv(strCodeForCs);

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
        /// ����:����Ĳ�ѯ���޸ġ����롢ɾ��
        /// </summary>
        /// <returns></returns>
        public string GenFunctionRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //int iDGHeight;      //DataGrid�ĸ߶�
            //int iDG_Div_Left;

            try
            {
                ///���ɲ����¼�Ľ������;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;


                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                  objViewInfoENEx.TabName, intCurrTop);

                //if (objViewInfoENEx.objViewRegion_List.IsCheck() == true || objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                //{
                //strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                //��Ӳ�div
                ASPHtmlTableEx objASPNETHtmlTableENEx = clsASPHtmlTableBLEx.GettabGridFunction();
                ASPRowEx objASPNETRowENEx = clsASPRowBLEx.GetEmptyTr();
                objASPNETHtmlTableENEx.arrSubAspControlLst2.Add(objASPNETRowENEx);

                ASPColEx objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                //�б����
                ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx);
                objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                //

                //strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabGridFunction\" style = \"width: 100%; height: 32px\" class = \"msgtable\" >");
                //strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.Append("\r\n" + "<td>");

                //strCodeForCs.AppendFormat("\r\n" + "<asp:label id = \"lbl{0}List\" runat = \"server\" style = \"z-index: 105; \" ",
                //  objViewInfoENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}�б�</asp:label>",
                //  objViewInfoENEx.objInRelaTab.TabCnName);
                //strCodeForCs.Append("\r\n" + "</td>");

                //iDG_Div_Left = 390;//��һ����ť����Ϊ390
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                  || objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnAddNewRec4Gv\" runat = \"server\" OnClick = \"btnAddNewRec4Gv_Click\" style = \"z-index: 106; \"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"��Ӽ�¼\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDelete4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnDelete4Gv\" OnClick = \"btnDelete4Gv_Click\" style = \"z-index: 104; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"ɾ����¼\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnUpdate4Gv\" OnClick = \"btnUpdate4Gv_Click\" style = \"z-index: 105; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"�޸ļ�¼\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnUpdate4Gv\" OnClick = \"btnUpdate4Gv_Click\" style = \"z-index: 105; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"�޸ļ�¼\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail == true)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    //clsInpu
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDetail4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnDetail4Gv\" style = \"z-index: 105; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"��ϸ��Ϣ\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.arrFeatureId.Contains("0142") == true)
                {
                    //List<ASPHtmlButtonEx> arrAspNetButton4AdjustOrderNum = new List<ASPHtmlButtonEx>();
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnGoTop();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpMove();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDownMove();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnGoBottum();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnReOrder();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //foreach (ASPHtmlButtonEx objInfor in arrAspNetButton4AdjustOrderNum)
                    //{
                    //    clsASPHtmlButtonBLEx.GeneCode(objInfor, strCodeForCs);

                    //}
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExcelExport == true)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnExportExcel4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnExportExcel4Gv\" OnClick = \"btnExportExcel4Gv_Click\" ",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "runat = \"server\" Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"����Excel\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.IsNeedSetExportFld == true &&
                      objViewInfoENEx.objViewTypeCodeTab.IsHaveSetExportExcel == true)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnSetExportExcel4User();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnSetExportExcel4User\" OnClick = \"btnSetExportExcel4User_Click\" ",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "runat = \"server\" Width = \"100px\" CssClass = \"btn btn-primary btn-sm\" Text = \"���õ����ֶ�\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }

                //�����
                //strCodeForCs.AppendFormat("\r\n" + "</tr>");
                //strCodeForCs.Append("\r\n" + "</table>");
                objASPNETHtmlTableENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                //}
                //����GridView�Ĵ���;


                strCodeForCs.AppendFormat("\r\n" + "</div>");

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", TabName_Out4DetailRegion4GC);
            return strClsName;
        }
        private string gfunRadioClick()
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            ///����Label�Ĵ���;
            strCodeForCs.Append("\r\n" + "<script language = \"javascript\">");
            strCodeForCs.Append("\r\n" + "<!--");
            strCodeForCs.Append("\r\n" + "function radioClick()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "for (i = 0; i<document.Form1.RadioName.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName[i].checked == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "document.Form1.rd.value = document.Form1.RadioName[i].value;");
            //document.getElementById("TextBox1").value = document.Form1.rd.value;
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//-->");
            strCodeForCs.Append("\r\n" + "</script>");

            intZIndex += 1;
            return strCodeForCs.ToString();


        }


        /// <summary>
        /// ����CheckBox�ؼ�
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            try
            {
                objCheckStyle.StyleZindex = intZIndex + 1;
                objCheckStyle.StyleLeft = (int)intCurrLeft;
                objCheckStyle.StyleTop = (int)intCurrTop;

                ///����CheckBox�Ĵ���;
                ///
                //���ɿؼ���<��ʼ��־>��<ID>
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //����<�ؼ���ʽStyle>
                //����<�߶�>��<���>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
                  objCheckStyle.StyleZindex,
                  objCheckStyle.Width, objCheckStyle.Height);
                //��������ģʽ�Ƿ��ڷ���������
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objCheckStyle.Runat);

                //����<�ֺ�>��<����>
                //strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //  objCheckStyle.FontSize, objCheckStyle.FontName);
                //����<��ʾ�ı�> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);

                //����<������־>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

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
        /// ����{��Ͽؼ�},����ߵı�ǩ,���ұߵ����������Ŀؼ�
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string GenCombineCtlNoPosition(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///����Label�Ĵ���;
            ///      
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///�����ұ߿ؼ��Ĵ���;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
              strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����Button�ؼ�
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenButtonNoPosition(clsButtonStyleEN objButtonStyle, string strButtonId, string strButtonText, string strOnClick)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            try
            {
                objButtonStyle.StyleZindex = intZIndex + 1;
                objButtonStyle.StyleLeft = (int)intCurrLeft;
                objButtonStyle.StyleTop = (int)intCurrTop;

                ///����Button�Ĵ���;
                ///
                //���ɿؼ���<��ʼ��־>��<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"{0}\" ",
                  strButtonId);
                //����<�ؼ���ʽStyle>
                //����<�߶�>��<���>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                  objButtonStyle.StyleZindex, objButtonStyle.StyleLeft,
                  objButtonStyle.Width, objButtonStyle.Height);

                //��������ģʽ�Ƿ��ڷ���������
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objButtonStyle.Runat);

                //����<�ֺ�>��<����>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //����<��ʾ�ı�> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //���ɵ����¼�
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //����<������־>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

                intZIndex += 1;

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
        /// �������ڱ༭�Ĳ�Div,�ò���Ա�����
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_WApi_Ts_DefDiv4DetailRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog modal-dialog-centered modal-dialog-scrollable\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">ģ̬��Modal������</h4>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");
            strCodeForCs.Append("\r\n" + " <table style=\"width: 100%;\">");

            foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
            {
                ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                ///������֤�ؼ�����;
                switch (objDetailRegionFldsEx.ObjFieldTabENEx.CsType())
                {
                    case "bool":
                        strCodeForCs.AppendFormat("\r\n" + "<td colspan='2'>");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"chk{0}\" runat = \"server\" Text = \"{1}\" CssClass = \"Check_Defa\"></asp:CheckBox>",
                          objDetailRegionFldsEx.FldName,
                          objDetailRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        //strCodeForCs.AppendFormat("\r\n" + "<td>");
                        //strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    case "int":
                    case "short":
                    case "long":
                    case "DateTime":
                    case "double":
                    case "float":
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objDetailRegionFldsEx.FldName,
                          objDetailRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"txt{0}\" runat = \"server\" CssClass = \"ValueControl\"></asp:TextBox>",
                          objDetailRegionFldsEx.FldName,
                          objDetailRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objDetailRegionFldsEx.FldName,
                          objDetailRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" CssClass = \"ValueControl\"></asp:{0}>",
                          objDetailRegionFldsEx.objCtlType.CtlTypeName,
                            objDetailRegionFldsEx.CtrlId,
                          objDetailRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                }
                //                strCodeForCs.AppendFormat("\r\n" + "</td>");
                strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                strCodeForCs.AppendFormat("\r\n" + "</tr>");
                //intZIndex += 1;
                //intCurrTop += 25;

            }

            //strCodeForCs.Append("\r\n" + " <tr>");
            //strCodeForCs.Append("\r\n" + " <td>1&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>2&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>3&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " </tr>");
            //strCodeForCs.Append("\r\n" + " <tr>");
            //strCodeForCs.Append("\r\n" + " <td>4&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>5&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>6&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " </tr>");
            strCodeForCs.Append("\r\n" + " </table>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-footer\">");
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">�ر�</button>");
            strCodeForCs.AppendFormat("\r\n" + " <button type=\"button\" class=\"btn btn-primary\" onclick=\"Submit_{0}()\">�ύ����</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_ShowData()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n /* ��������:���Ըùؼ��ֵļ�¼������ʾ�ڽ�����,");
                    strCodeForCs.Append("\r\n" + "* �������ǰ�ֵ������ؼ���");
                    strCodeForCs.AppendFormat("\r\n" +"* ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n" + "* @param {0}: ���¼�Ĺؼ���,��ʾ�ñ�ؼ��ֵ�����",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "*/");

                    strCodeForCs.AppendFormat("\r\n" + "  public async ShowData({0}: {1}) {{",
                        objKeyField.PrivFuncName, objKeyField.TypeScriptType);
                    strCodeForCs.Append("\r\n" + "        //��������:");
                    strCodeForCs.Append("\r\n" + "        //1�����ؼ����Ƿ�Ϊ�գ�");
                    strCodeForCs.Append("\r\n" + "        //2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.Append("\r\n" + "        //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                    strCodeForCs.Append("\r\n" + "        //4����ȡ�������������ԣ�");
                    strCodeForCs.Append("\r\n" + "        //5���Ѹö��������������ʾ�ڽ�����,��������ʾ�ڱ�ؼ���");
                    strCodeForCs.Append("\r\n" + "        //2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.AppendFormat("\r\n" + "        let obj{0}EN = new cls{0}EN();",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InDetail(WA_F.IsExistAsync)}({objKeyField.PrivFuncName});");
                    
                    strCodeForCs.Append("\r\n" + "            if (returnBool == false) {");
                    strCodeForCs.AppendFormat("\r\n" + "                const strInfo = Format(\"�ؼ���:[{{0}}] �ļ�¼������!\", {0});",
                         objKeyField.PrivFuncName);
                    
                    strCodeForCs.Append("\r\n" + "                //��ʾ��Ϣ��");
                    strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "            else {");
                    //                    strCodeForCs.Append("\r\n" + "                const strInfo = Format(\"�ؼ���:[${strExam1TypeId}]����ؼ�¼����!\");");
                    
                    //                strCodeForCs.Append("\r\n" + "                //��ʾ��Ϣ��");
                    //              strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"�����Ӧ�ؼ��ֵļ�¼���ڲ��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4DetailRegion}EN = await {thisWA_F_InDetail(WA_F.GetObjByKeyId)}({objKeyField.PrivFuncName});");

                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");

                    strCodeForCs.Append("\r\n" + "        //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");

                    strCodeForCs.AppendFormat("\r\n" + "        this.GetDataFrom{0}Class(obj{0}EN);",
                        objViewInfoENEx.TabName_In);


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
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(WA_ViewScript_DetailCS_TS4TypeScript));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(WA_ViewScript_DetailCS_TS4TypeScript);
            //    MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

            //    if (mt == null)
            //    {
            //        string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //    }
            //    else
            //    {
            //        //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
            //        if (mt.GetParameters().Length == 0)
            //        {
            //            strCode = (string)mt.Invoke(this, null);
            //        }
            //        else if (mt.GetParameters().Length == 1)
            //        {
            //            strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
            //        }
            //        //Console.WriteLine(str);
            //    }

            //    return strCode;
            //}
            //catch (Exception objException)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    string strMsg = "";
            //    if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
            //    {
            //        strMsg = objException.InnerException.Message;
            //    }
            //    else
            //    {
            //        strMsg = objException.Message;
            //    }
            //    sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, strMsg);
            //    throw new Exception(sbMessage.ToString());
            //}
        }
        public override void GetClsName()
        {
            //this.ClsName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //objViewInfoENEx.ClsName = this.ClsName;
            string strClassName = string.Format("WA_{0}_Detail", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
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
      
     
        private void Gene_ReFreshCache(StringBuilder sbCode)
        {
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", objViewInfoENEx.TabName_In);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}Cache);", objViewInfoENEx.TabName, objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
            }
            else
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache();", objViewInfoENEx.TabName_In);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({2}.{1}Cache);", objViewInfoENEx.TabName, 
                        objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
            }
        }

        public string Gen_WApi_Ts_Code4DetailRegion()
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.DetailRegion_0006)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();

        }



        public string Gen_WApi_Ts_AddDPV_Detail(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strClassName = string.Format("WA_{0}_Detail", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �ڵ�ǰ������,����༭����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public async AddDPV_Detail(divName4Detail:string) {{",
                objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddDPV_Detail.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = \"./{0}/\";", strClassName);
            strCodeForCs.Append("\r\n" + "console.log(\"divName4Detail:(In AddDPV_Detail)\" + divName4Detail);");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"html\",");
            strCodeForCs.Append("\r\n" + "data: { },");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "console.log(\"�Ѿ��ɹ���ȡҳ��:\" + strUrl + \"  �ֽ���: \" + data.length.toString());");
            strCodeForCs.Append("\r\n" + "$('#' + divName4Detail).html(data);");
            strCodeForCs.Append("\r\n" + "resolve(true);");
            strCodeForCs.AppendFormat("\r\n" + "//setTimeout(() => {{ clsDetailObj.BindTab(); }}, 100);");
            strCodeForCs.AppendFormat("\r\n" + "//clsDetailObj.BindTab();");
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

        public string Gen_WApi_TS_ShowDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  ��ʾ�Ի���");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public ShowDialog_{0}(strOp:string) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;", objViewInfoENEx.TabName_In);
            
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + $"CheckControlExist(divVarSet.refDivDetail, \"div\", \"divDetailDialog_{objViewInfoENEx.TabName_In}\");");
            strCodeForCs.Append("\r\n" + $"CheckControlExist(divVarSet.refDivDetail, \"h4\", \"lblDialogTitle_{objViewInfoENEx.TabName_In}\");");

            //strCodeForCs.Append("\r\n" + "   strOp = pstrOp;");
            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\" ) {");
            strCodeForCs.Append("\r\n" + $" SetH4HtmlByIdInDivObj(divVarSet.refDivDetail, 'lblDialogTitle_{objViewInfoENEx.TabName_In}', '��Ӽ�¼');");
            strCodeForCs.AppendFormat("\r\n" + "//{0}Ex.GetMaxStrId('#txt{1}');",
                    objViewInfoENEx.ClsName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $" SetH4HtmlByIdInDivObj(divVarSet.refDivDetail, 'lblDialogTitle_{objViewInfoENEx.TabName_In}', '�޸ļ�¼');");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            strCodeForCs.Append("\r\n" + "{");            
            strCodeForCs.Append("\r\n" + $" const btnSubmit{0} = getButtonObjByIdInDivObj(divVarSet.refDivDetail, 'btnSubmit{TabName_Out4DetailRegion4GC}');");
            strCodeForCs.AppendFormat("\r\n" + " btnSubmit{0}.hidden = true;", TabName_Out4DetailRegion4GC);

            strCodeForCs.Append("\r\n" + $"SetH4HtmlByIdInDivObj(divVarSet.refDivDetail, 'lblDialogTitle_{objViewInfoENEx.TabName_In}', '��ϸ��Ϣ');");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "        ShowDialog('#divDetailDialog_{0}');", objViewInfoENEx.TabName_In);

            strCodeForCs.Append("\r\n" + "}");
            AddImportClass(TabId_Out4DetailRegion, "/PubFun/clsCommFunc4Ctrl.js", "SetH4HtmlByIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);
            AddImportClass(TabId_Out4DetailRegion, "/PubFun/clsCommFunc4Ctrl.js", "getButtonObjByIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_TS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  ���ضԻ���");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public HideDialog_{0}() {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.HideDialog_{0}.name;", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + $"CheckControlExist(divVarSet.refDivDetail, \"div\", \"divDetailDialog_{objViewInfoENEx.TabName_In}\");");

            strCodeForCs.AppendFormat("\r\n" + "      HideDialog('#divDetailDialog_{0}');", objViewInfoENEx.TabName_In);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_ShowDetailDataFromClass4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4Detail == false) return "";

            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* ��������:������������������ʾ���������ϸ��Ϣ������");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">��ʵ�������</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public ShowDetailDataFrom{0}Class4Func(pobj{2}ENEx: cls{1}ENEx )",
                           TabName_Out4DetailRegion4GC, TabName_Out4DetailRegion4GC, TabName_Out4DetailRegion4GC);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDetailDataFrom{0}Class4Func.name;", TabName_Out4DetailRegion4GC);
                
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInShowDetailDataFromClass4Func(objDetailRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

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
        private string GetCode4FieldInShowDetailDataFromClass4Func(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();

            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objDetailRegionFldsEx.IsUseFunc() == true)
            {
                string strDataType = "";
              
                clsDetailRegionFldsBLEx.CheckOutFldId(objDetailRegionFldsEx, this.IsFstLcase, objViewInfoENEx.PrjId, objViewInfoENEx.UserId);
                //string strOutDataNodeId = objDetailRegionFldsEx.OutDataNodeId();
                //var objDataNode_Out1 = clsDataNodeBL.GetObjByDataNodeIdCache(strOutDataNodeId, objViewInfoENEx.PrjId);

                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDetailRegionFldsEx.OutFldId, objDetailRegionFldsEx.PrjId);
                strDataType = objFieldTab.TypeScriptType();
                string strCtrlId = clsCtlTypeBLEx.GetCtrlId(objDetailRegionFldsEx.CtlTypeId, objDetailRegionFldsEx.DataPropertyName());
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objDetailRegionFldsEx.CtlTypeName,
                    CtrlId = strCtrlId + "_d",
                    PropertyName = objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase) + "_d",
                    Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                    "ShowDetailDataFromClass4Func()"),
                    DataType = strDataType,
                    ParentDivName = $"divVarSet.refDivDetail"
                });
            }
            else
            {
                string strCtrlId = clsCtlTypeBLEx.GetCtrlId(objDetailRegionFldsEx.CtlTypeId, objDetailRegionFldsEx.FldName);

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objDetailRegionFldsEx.CtlTypeName,
                    CtrlId = strCtrlId + "_d",
                    PropertyName = objDetailRegionFldsEx.PropertyName(this.IsFstLcase) + "_d",
                    Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                            "ShowDetailDataFromClass4Func()"),
                    DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    ParentDivName = $"divVarSet.refDivDetail"
                });
            }
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlType.CheckBox_02:
                    //7������checkboxΪѡ��״̬
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8������checkboxΪ��ѡ��״̬
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{0}_d = pobj{1}ENEx.{2};",
                         objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
                                TabName_Out4DetailRegion4GC,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{0}_d = pobj{1}ENEx.{2};",
                         objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
                                TabName_Out4DetailRegion4GC,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{0}_d = pobj{1}ENEx.{2};",
                                objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
                                TabName_Out4DetailRegion4GC,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    if (objDetailRegionFldsEx.IsUseFunc() == true)
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " this.{0}_d = pobj{1}ENEx.{3};",
                                 objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
                                 TabName_Out4DetailRegion4GC,
                                 objDetailRegionFldsEx.FldName,
                                 objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase));
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " this.{0}_d = pobj{1}ENEx.{2};",
                                    objDetailRegionFldsEx.PropertyName(this.IsFstLcase),
                                    TabName_Out4DetailRegion4GC,
                                    objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    }
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_FuncMap4Detail()
        {
            if (string.IsNullOrEmpty(strMapFuncCode) == false) return strMapFuncCode;
            if (bolIsUseFunc4Detail == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��һ����չ��Ĳ������Խ��к���ת��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}S\">Դ����</param>", TabName_Out4DetailRegion4GC);
            strCodeForCs.AppendFormat("\r\n public async FuncMap4Detail(obj{0}:cls{0}ENEx )", TabName_Out4DetailRegion4GC);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.FuncMap4Detail.name;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
 
            List<clsDetailRegionFldsENEx> arrDetailRegionFld_Sel = objViewInfoENEx.arrDetailRegionFldSet.FindAll(x => x.IsUseFunc() == true);
            //Graph g1 = clsDataNodeBLEx.InitGraph(objViewInfoENEx.PrjId);
            foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in arrDetailRegionFld_Sel)
            {
                strCodeForCs.Append("\r\n" + "{");
                var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldIdCache(TabId_Out4DetailRegion, objDetailRegionFldsEx.FldId, 1, objViewInfoENEx.PrjId);
                if (objDataNode_Curr == null)
                {
                    string strMsg = string.Format("TabId={0},FldId=[{1}], VersionNo=1, CmPrjId={2}�Ľ��Ϊ��,����!(in {3})", 
                        TabId_Out4DetailRegion, objDetailRegionFldsEx.FldId, objViewInfoENEx.PrjId, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                //var arrPath = clsDataNodeBLEx.GetGraphPath(g, objDataNode_Start.DataNodeId, objDetailRegionFldsEx.OutDataNodeId(), objViewInfoENEx.PrjId);
                string strLastVarName = "";
                long strOutDataNodeId = objDetailRegionFldsEx.OutDataNodeId();
                if (strOutDataNodeId == 0) continue;
                //var strCmPrjId = clsCMProjectPrjTabBLEx.GetFirstCmPrjIdByTabIdCache(strTabId_Out4ListRegion);
                List<clsDnFuncMapEN> arrPath = null;
                try
                {
                    clsDetailRegionFldsBLEx.CheckOutFldId(objDetailRegionFldsEx, this.IsFstLcase, objViewInfoENEx.PrjId, objViewInfoENEx.UserId);
                    strOutDataNodeId = objDetailRegionFldsEx.OutDataNodeId();
                    if (strOutDataNodeId == 0)
                    {

                    }
                    arrPath = clsDnFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, strOutDataNodeId, objViewInfoENEx.PrjId);
                }
                catch (Exception objException)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4DetailRegion, objDetailRegionFldsEx.PrjId());
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDetailRegionFldsEx.FldId, objDetailRegionFldsEx.PrjId());
                    var objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId);
                    string strMsg = string.Format("ת��������,��TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{8}�ڻ�ȡת��·��ʱ,����:{7}�� VersionNo=1, PrjId={2}({5}),����!(In {6})",
                        TabId_Out4DetailRegion,
                        objDetailRegionFldsEx.FldId, objViewInfoENEx.PrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objProject.PrjName,
                        clsStackTrace.GetCurrClassFunction(), objException.Message, objDetailRegionFldsEx.DataPropertyName());
                    throw new Exception(strMsg);
                }


                foreach (var objInFor in arrPath)
                {
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:
                            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, objPrjTab.PrjId);

                                strCacheClassifyField += string.Format(", {0}.{1}Cache", objViewInfoENEx.ClsName, objCacheClassifyField.FldName);
                            }
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField2TS) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyField2TS, objPrjTab.PrjId);

                                strCacheClassifyField += string.Format(", {0}.{1}Cache", objViewInfoENEx.ClsName, objCacheClassifyField.FldName);
                            }

                            if (arrPath.Count == 1)
                            {
                                if (objDataNode_Start.TabId == TabId_Out4DetailRegion)
                                {
                                    strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_Start.DataNodeName,
                                        TabName_Out4DetailRegion4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase));
                                }
                                //else
                                //{
                                //    strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_Start.DataNodeName, objDataNode_Start.DataNodeName);
                                //}
                            }
                            strCodeForCs.AppendFormat("\r\n const {0} = await {1}_func(cls{1}EN.con_{2}, cls{1}EN.con_{3}, {4} {5});",
                                objDataNode_End.DataNodeName,
                                objPrjTab.TabName,
                                objFieldTab_Start.FldName,
                                objFieldTab_End.FldName,
                                objDataNode_Start.DataNodeName,
                                strCacheClassifyField);
                            AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("func", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                            AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("cls{0}EN", objPrjTab.TabName), enumImportObjType.ENClass, this.strBaseUrl);
                                                      
                            strLastVarName = objDataNode_End.DataNodeName;
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objViewInfoENEx.PrjId);
                            switch (objDNFun.DnFunctionName)
                            {
                                case "equal":

                                    if (objDataNode_Start.TabId == TabId_Out4DetailRegion)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_End.DataNodeName,
                                            TabName_Out4DetailRegion4GC,
                                            objFieldTab_Start.PropertyName(this.IsFstLcase));
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName, objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                case "GetDateTime_Sim":
                                    //var objPrjTab2 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == TabId_Out4DetailRegion)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            TabName_Out4DetailRegion4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase));
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == TabId_Out4DetailRegion)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            TabName_Out4DetailRegion4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase),
                                        objDNFun.DnFunctionName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName,
                                        objDNFun.DnFunctionName);
                                    }
                                    AddImportClass(objViewInfoENEx.MainTabId, objDNFun.ImportPath, objDNFun.DnFunctionName, enumImportObjType.CustomFunc, this.strBaseUrl);

                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                            }
                            break;
                    }

                }
                strCodeForCs.AppendFormat("\r\n obj{0}.{1} = {2};",
                                    TabName_Out4DetailRegion4GC,
                                    objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
                                    strLastVarName);
                strCodeForCs.Append("\r\n" + "}");
            }

            //strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.ClsName, "FuncMap4ExcelExport", "����ӳ���:{0} �������ݳ���!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})����ӳ��4Detail��������ݳ���,{{0}}.)\", e);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_CopyToEx()
        {
            if (bolIsUseFunc4Detail == false ) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", TabName_Out4DetailRegion4GC);
            strCodeForCs.AppendFormat("\r\n /// <returns>Ŀ�����=>cls{0}EN:obj{0}ENT</returns>", TabName_Out4DetailRegion4GC);
            strCodeForCs.AppendFormat("\r\n public CopyToEx(obj{0}ENS:cls{0}EN ): cls{0}ENEx", TabName_Out4DetailRegion4GC);
            AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion4GC, string.Format("cls{0}EN", TabName_Out4DetailRegion4GC), enumImportObjType.ENClass, this.strBaseUrl);

            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.CopyToEx.name;");
            strCodeForCs.AppendFormat("\r\n const obj{0}ENT = new cls{0}ENEx();", TabName_Out4DetailRegion4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}ENT, obj{0}ENS);",                    TabName_Out4DetailRegion4GC);
                        
            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", TabName_Out4DetailRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.ClsName, "CopyToEx", "Copy��Ex:{0} �������ݳ���!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})Copy��������ݳ���,{{0}}.(in {{1}}.{{2}})\", e, this.constructor.name, strThisFuncName);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            
            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", TabName_Out4DetailRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }
        //public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        //{
        //    return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, objViewInfoENEx.PrjId);
        //}
    }
}
