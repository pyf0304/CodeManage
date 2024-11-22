using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// ����ר�����������ݱ�ı�����,�ô�������߼����һ����,��ϵ�ṹ���µ���,
    /// </summary>
    partial class Vue_Share_TS4TypeScript : clsGeneCodeBase
    {
        private bool bolIsNeedGeneReMapFunc = false;
        protected clsPrjTabENEx objPrjTabEx_ListRegion = null;
        protected List<clsPropertyDef4GC> arrPropertyDef4GC = null;

        //private string strTabName_Out4ListRegion = "";
        //private string strTabId_Out4ListRegion = "";
        private string strJSPath = "";
        private clsFuncModule_AgcEN objFuncModule = null;
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region ���캯��
        public Vue_Share_TS4TypeScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_Share_TS4TypeScript(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_Share_TS4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
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







        public string Gen_Vue_setup_fun_ts_BindTabByList()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * ͨ��List������󶨱�����");
            //���������������ĺ���˵��            
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.Append("\r\n" + "export const BindTabByList = async(");
            strCodeForCs.Append("\r\n" + $"arrObjLst: Array<cls{TabName_Out4ListRegion}ENEx>,");
            strCodeForCs.Append("\r\n" + "bolIsShowErrMsg: boolean,");
            strCodeForCs.Append("\r\n" + "): Promise<void> => {");
            strCodeForCs.Append("\r\n" + $"dataList{TabName_Out4ListRegion}.value = arrObjLst;");
            strCodeForCs.Append("\r\n" + "showErrorMessage.value = bolIsShowErrMsg;");
            strCodeForCs.Append("\r\n" + "};");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_setup_ts_GetDdlData()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN[]>([]);");
                }
                //���ÿһ������--������
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);

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
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                    //���������������ĺ���˵��
                    strCodeForCs.Append("\r\n" + objTabFeature4Ddl.FuncRemark);
                    strCodeForCs.Append("\r\n*/");

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);

                    strCodeForCs.Append("\r\n" + $"async function getArr{objTabFeature4Ddl.TabName4GC}({strFuncPara})");
                    //strCodeForCs.Append("\r\n" + $"async function getArr{objTabFeature4Ddl.TabName4GC}()");
                    strCodeForCs.Append("\r\n" + "{");

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
                    strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.ValueFieldName)} = '0';");
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
                    strCodeForCs.Append("\r\n" + $"{objQryRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q.value = '0';");
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
                            strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = $('#txt{1}{2}').val();",
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
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = $('#txt{1}{2}').val();",
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


        /// <summary>
        /// ����:����Ĳ�ѯ���޸ġ����롢ɾ��
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            string strFuncName = "";

            clsViewRegionEN objViewRegion_Edit = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);

            if (string.IsNullOrEmpty(TabId_Out4ListRegion) == false)
            {
                var objPrjTab_ListRegion = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4ListRegion, objViewInfoENEx.PrjId);
                //if (objPrjTab_ListRegion != null)
                //{
                //    strSqlDsTypeId4ListRegion = objPrjTab_ListRegion.SqlDsTypeId;
                //}

                objPrjTabEx_ListRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ListRegion);
                objPrjTabEx_ListRegion.GetObjAllInfoEx();
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
  objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            objViewInfoENEx.WebFormName = string.Format("{0}", ThisClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.ts",
                objViewInfoENEx.FolderName, ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objViewInfoENEx);

            try
            {
                //��ȡ��������Ҫ�Ĺ�������

                //������ʼ
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                //if (string.IsNullOrEmpty(this.TabId_Out4ListRegion) == false) this.GetViewPubVarLst(this.TabId_Out4ListRegion);
                if (string.IsNullOrEmpty(this.TabId_Out4ListRegion) == false) this.GetViewIdVarRelaVarLst(objViewInfoENEx.ViewId);

                strCodeForCs.Append("\r\n" + "import { reactive, ref } from 'vue';");
                strCodeForCs.Append("\r\n" + "import { Format } from \"@/ts/PubFun/clsString\"");
                //strCodeForCs.Append("\r\n" + "import router from '@/router';");

                strCodeForCs.Append("\r\n" + $"import {{ cls{TabName_Out4ListRegion}EN }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}EN\";");
                strCodeForCs.Append("\r\n" + $"import {{ cls{TabName_Out4ListRegion}ENEx }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}ENEx\";");
                if (objViewInfoENEx.arrQryRegionFldSet != null)
                {
                    var arrQryRegionFldSetEx = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.IsUseFunc() == true && string.IsNullOrEmpty(x.DataPropertyName()) == false).ToList();
                    if (arrQryRegionFldSetEx.Count > 0)
                    {
                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx_In in arrQryRegionFldSetEx)
                        {
                            strCodeForCs.Append("\r\n" + $"import {{ {TabName_Out4ListRegion}Ex_FuncMapKey{objQryRegionFldsEx_In.DataPropertyName()} }} from '@/ts/L3ForWApiEx/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}ExWApi';");
                        }
                        strCodeForCs.Append("\r\n" + "import { intersectSets } from '@/ts/PubFun/clsCommFunc4Ctrl';");
                    }
                }
                //foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                //{
                //    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                //    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl);
                //    strCodeForCs.Append("\r\n" + $"import {{ cls{objTabFeature4Ddl.TabName4GC}EN }} from \"@/ts/L0Entity/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}EN\";");

                //}
                ////���ÿһ������--������
                //foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                //{
                //    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                //    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl);
                //    var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeature4Ddl.TabId, objTabFeature4Ddl.PrjId);
                //    if (objPrjTabENEx_Ddl.IsUseCache_TS() == false)
                //    {
                //        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_GetObjLstAsync }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");
                //    }
                //    else
                //    {
                //        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_GetObjLstCache }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");
                //    }

                //}

                strCodeForCs.Append("\r\n" + Gen_Vue_ts_ViewVar());
                strCodeForCs.Append("\r\n" + Gen_Vue_ts_PubVar());
                strCodeForCs.Append("\r\n" + Gen_Vue_ts_ShareVar());
                strCodeForCs.Append("\r\n" + Gen_Vue_setup_var_ts_DataListVarDef());
                strCodeForCs.Append("\r\n" + Gen_Vue_ts_QryVarDef());
                //strCodeForCs.Append("\r\n" + Gen_Vue_ts_EditVarDef());
                //strCodeForCs.Append("\r\n" + Gen_Vue_ts_DetailVarDef());
                strCodeForCs.Append("\r\n" + Gen_Vue_ts_FeatureVarDef());

                strCodeForCs.Append("\r\n" + Gen_Vue_ts_ExportFuncDef());
                //strCodeForCs.Append("\r\n" + Gen_Vue_ts_DivVarDef());

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }
        public string GenFeatureRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            string lngRegionId = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;

            //			string strTemp ;     ///��ʱ����;
            ///�ж�DataGrid�Ƿ���Ҫ����
            //foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            //{
            //    if (objDGRegionFldsEx.IsNeedSort)
            //    {
            //        //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
            //    }
            //}
            try
            {


                ASPDivEx objASPDivENEx_Function = clsASPDivBLEx.GetEmptyDiv();
                objASPDivENEx_Function.Class = "table table-bordered table-hover";
                objASPDivENEx_Function.Runat = "server";
                objASPDivENEx_Function.CtrlId = "divFunction";
                objASPDivENEx_Function.Ref = "refDivFunction";

                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
                if (objViewInfoENEx.arrFeatureRegionFlds == null)
                {
                    string strMsg = string.Format("���湦����Ϊ��,����ӽ��湦��!����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion
                    .Where(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);
                if (arrViewRegion.Count() == 0)
                {
                    string strMsg = string.Format("���湦����Ϊ��,����ӽ��湦��!����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                lngRegionId = arrViewRegion.First().RegionId;

                IEnumerable<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, objViewInfoENEx, "");

                List<ASPControlGroupEx> arrControlGroupLst = arrControls
                    .OrderBy(x => x.OrderNum)
                    .Select(clsASPControlGroupBLEx.GetControlGroup)
                    .OrderBy(x => x.GroupName).ToList();


                //IEnumerable<VueButtonEx> arrButtonLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.FunctionRegion_0001).Select(clsVueButtonBLEx.GetButton4MvcAjax);
                IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);


                //��Ӳ�div
                ASPUlEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
                objASPUlENEx.Class = "nav";
                objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

                ASPLiEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item";
                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                //�б����
                ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx, true);
                objASPLiENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                //Action<VueButtonEx> AddToTd = (x) =>
                //{
                //    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                //    VueButtonEx objASPNETButtonENEx = clsVueButtonBLEx.GetbtnAddNewRec4Gv();
                //    objASPNETColENEx.arrSubAspControlLst2.Add(x);
                //    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                //};
                //< li class="nav-item">

                Action<ASPButtonEx> AddToLi = (x) =>
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(x);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                };

                foreach (ASPControlGroupEx objInFor in arrControlGroupLst_New)
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    //VueButtonEx objASPNETButtonENEx = clsVueButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(objInFor);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                }

                objASPDivENEx_Function.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                //����GridView�Ĵ���;

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
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
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

        private string GenViewTitle(string strTitle, clsViewInfoENEx objViewInfoENEx)
        {
            if (string.IsNullOrEmpty(objViewInfoENEx.objViewStyleEN.TitleStyleId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڽ���:{0}��,û�����ñ�������,����!", objViewInfoENEx.ViewName);
                throw new Exception(sbMsg.ToString());
            }
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            if (objTitleStyle == null)
            {
                string strMsg = string.Format("(errid:BlEx000044)����ģʽId:[{0}]û����Ӧ�Ķ���,����!(AutoGC6Cs_VWeb_Net2005:GenViewTitle)", objViewInfoENEx.objViewStyleEN.TitleStyleId);
                throw new Exception(strMsg);
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            ///����Label�Ĵ���;
            switch (objTitleStyle.TitleTypeId)
            {
                case "01":
                    strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabTitle\" style = \"z-index: 102; left: 8px; position: absolute; top: 1px\" cellspacing = \"1\" ");
                    strCodeForCs.AppendFormat("\r\n" + "cellpadding = \"1\" width = \"100%\" bgColor = \"{0}\" border = \"0\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    strCodeForCs.AppendFormat("\r\n" + "<td bgColor = \"{0}\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lblViewTile\" runat = \"server\" Font-Size = \"Small\" Font-Names = \"����\" ForeColor = \"{1}\" Font-Bold = \"True\">{0}</asp:Label>",
                      strTitle, objTitleStyle.ForeColor);
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    strCodeForCs.AppendFormat("\r\n" + "</table>");
                    break;
                case "02":

                    break;
                case "03":
                    ASPDivEx objDiv = new ASPDivEx();
                    objDiv.Style = "position: relative; width: 648px; height: 37px; left: 0px; top: 0px;";
                    ASPLabelEx objLabel = new ASPLabelEx();
                    objLabel.CtrlId = "lblViewTitle";
                    objLabel.Class = "h5";
                    //objLabel.Is4PureHtml = true;
                    objLabel.Text = "{{{{ strTitle }}}}";// strTitle;
                    objDiv.arrSubAspControlLst2.Add(objLabel);
                    ASPLabelEx objLabel_ErrMsg = clsASPLabelBLEx.GetLabel4ErrMsg("lblMsg_List", true);
                    objDiv.arrSubAspControlLst2.Add(objLabel_ErrMsg);
                    objDiv.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    //strCodeForCs.AppendFormat("\r\n" + "<div style = \"position: relative; width: 648px; height: 37px; left: 0px; top: 0px;\">");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblViewTitle\" runat = \"server\" CssClass = \"h5\" >{0}",
                    //  strTitle);
                    //strCodeForCs.AppendFormat("\r\n" + "</asp:Label>");
                    ////����в�ѯ����
                    //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblMsg_List\" runat = \"server\" CssClass = \"text-warning\"  Style = \"z-index: 105;");
                    //    strCodeForCs.AppendFormat("\r\n" + "left: 54px; position: relative; top: 4px\" Width = \"347px\"></asp:Label>");
                    //}
                    //strCodeForCs.AppendFormat("\r\n" + "	</div>");
                    break;
            }

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ɲ�ѯ������ش���
        /// </summary>
        /// <returns></returns>
        public string GenQryRegionCode4Table()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //�����������ĵı�ǩ����
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;

            strCodeForCs.AppendFormat("\r\n" + "<div id = \"divQuery\" ref = \"refDivQuery\" class = \"div_query\"> ",
              objViewInfoENEx.TabName, intDivHeight);


            intCurrTop -= 30;//��Ϊ�����ڲ�(div)��
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///����ר�����ڲ�ѯ�Ľ���ؼ��Ĵ���;

            IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            if (arrViewRegion.Count() == 0)
            {
                string strMsg = string.Format("���湦����Ϊ��,����ӽ��湦��!����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            clsViewRegionENEx objViewRegion = arrViewRegion.First();
            string lngRegionId = objViewRegion.RegionId;

            IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroup(lngRegionId, objViewInfoENEx, "Item1");



            switch (objViewRegion.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:

                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewInfoENEx.objViewRegion_Query.ColNum ?? 0);
                    objTable.Width = objViewRegion.Width ?? 0;
                    objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objDiv_FormControl = clsASPDivBLEx.PackageByFormControl4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objDiv_FormControl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objFormInline.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objDivTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4QueryRegion_H(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objUl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4QueryRegion_V(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objUl2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewInfoENEx.objViewRegion_Query.ColNum ?? 0);
                    objTable2.Width = objViewRegion.Width ?? 0;
                    objTable2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
            }



            strCodeForCs.Append("\r\n" + "</div>");

            intCurrTop += 40;
            return strCodeForCs.ToString();
        }


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Vue_Share_TS4TypeScript);
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
            this.ClsName = string.Format("{0}VueShare", objViewInfoENEx.TabName);
            if (objViewInfoENEx.ViewName != $"{objViewInfoENEx.TabName}CRUD")
            {
                this.ClsName = string.Format("{0}VueShare", objViewInfoENEx.ViewName);
            }
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



        public string Gen_Vue_ts_ExportFuncDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ListRegion4GC}Condition : ()=>Promise<string>; ");
            strCodeForCs.Append("\r\n" + Gen_vue_ts_setup_fun_CombineCondition());

            //strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ListRegion4GC}ConditionObj: ()=> Promise<cls{TabName_Out4ListRegion4GC}EN>; ");
            strCodeForCs.Append("\r\n" + Gen_vue_ts_setup_fun_CombineConditionObj());
            //strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel: ()=>Promise<cls{TabName_Out4ExportExcel4GC}EN>; ");
            strCodeForCs.Append("\r\n" + Gen_vue_ts_setup_fun_CombineConditionObj4ExportExcel());
            strCodeForCs.Append("\r\n" + Gen_Ts_CombineConditionInFldValueLst_GeneFun());


            //strCodeForCs.Append("\r\n" + $"export let BindTabByList: (arrObjLst: Array<cls{TabName_Out4ListRegion4GC}ENEx>,    bolIsShowErrMsg: boolean,) => Promise<void>;");

            strCodeForCs.Append("\r\n" + Gen_Vue_setup_fun_ts_BindTabByList());

            return strCodeForCs.ToString();
        }

        public string Gen_vue_ts_setup_fun_CombineConditionObj()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n /** �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns ������(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export const Combine{0}ConditionObj=async (): Promise<cls{0}EN> =>", TabName_Out4ListRegion4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

                if ((objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    && (objViewInfoENEx.arrQryRegionFldSet.Count > 0))
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                }
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", TabName_Out4ListRegion4GC);
                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_IsDeleted, false, \"=\");", TabName_Out4ListRegion4GC);
                }
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                var arrQryRegionFldsEx = arrQryRegionFlds.Select(clsQryRegionFldsBLEx.CopyToEx);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFldsEx)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;
                        string strIsEx = "";
                        if (clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objInFor.FldId) == true)
                        {
                            strIsEx = "Ex";
                        }
                        else if (string.IsNullOrEmpty(objInFor.OutFldId) == false &&
                            clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objInFor.OutFldId) == true) strIsEx = "Ex";

                        if (objInFor.IsUseFunc() && string.IsNullOrEmpty(objInFor.DataPropertyName()) == false) continue;
                        if (objInFor.IsForExtendClass() == true) continue;
                        string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004 || objVar.VarTypeId == enumGCVariableType.localStorage_0003)
                        {
                            CheckQueryField(objInFor);

                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objInFor.ObjFieldTab().FldName}, {strVarName}.value, \"=\");");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objInFor.ObjFieldTab().FldName}, {strVarName}.value, \"=\");");
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");
                if (objViewInfoENEx.arrQryRegionFldSet.Count > 0)
                {

                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    {
                        strCodeForCs.Append("\r\n" + "try");
                        strCodeForCs.Append("\r\n" + "{");
                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                        {

                            if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;
                            string strIsEx = "";
                            if (clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objQryRegionFldsEx.FldId) == true)
                            {
                                strIsEx = "Ex";
                            }
                            else if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false &&
                                clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objQryRegionFldsEx.OutFldId) == true) strIsEx = "Ex";

                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.FldName}, true, \"=\");");


                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, false, \"=\");");

                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///����ؼ���������;
                                case "DropDownList_Bool": ///����ؼ���������;

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if ({objQryRegionFldsEx.PropertyName}.value == true)");
                                        //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}); ");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, true, \"=\");");

                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if ({objQryRegionFldsEx.PropertyName}.value  ==false)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, false, \"=\");");

                                        strCodeForCs.Append("\r\n" + "}");

                                    }
                                    else
                                    {
                                        //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                 objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\" && {0}.value != \"0\")",
                                                    objQryRegionFldsEx.PropertyName);
                                        }
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                        {
                                            case "string":


                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");


                                                break;
                                            case "int":


                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                                break;
                                            default:


                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                                break;
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;

                                case "TextBox": ///����ؼ��������ı���;
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                        && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                    {
                                        objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                    }
                                    if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                    (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                                    {
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")",
                                objQryRegionFldsEx.PropertyName);
                                        }

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                        {
                                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        }
                                        else
                                        {
                                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"like\");");

                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///��Χ��ѯ;
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value), , );");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
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
                                case "CheckBoxList":
                                    break;
                                case "DataGrid":
                                    break;
                                case "DataList":
                                    break;
                                case "Button":
                                    break;
                                case "sessionStorage":
                                    break;
                                case "CacheClassifyField":
                                    break;
                                case "ViewVariable":
                                    break;
                                default:
                                    var strMsg = string.Format("(errorId:018)�ؼ����ͣ�{0}����Ӧ������û�б�����!({1})", objQryRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //���������չ�ֶεĲ�ѯ
                        strCodeForCs.Append("\r\n" + Gen_Ts_CombineConditionInFldValueLst());

                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "catch(objException)");
                        strCodeForCs.Append("\r\n" + "{");
                        //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj", "����ϲ�ѯ��������(CombineTabNameConditionObj)ʱ����!����ϵ����Ա!", "���ɴ���");
                        AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                        strCodeForCs.Append("\r\n" + $"const strMsg:string = Format(\"����ϲ�ѯ��������(Combine{ViewMainTabName4GC}ConditionObj)ʱ����!����ϵ����Ա!{{0}}\", objException);");
                        strCodeForCs.Append("\r\n" + "throw strMsg;");
                        strCodeForCs.Append("\r\n" + "}");
                    }

                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.whereCond = strWhereCond;", TabName_Out4ListRegion4GC);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ListRegion4GC);
                strCodeForCs.Append("\r\n" + "};");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_QryVarDef()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "//��ѯ����������");

            StringBuilder sbCode_Export = new StringBuilder();
            sbCode_Export.Append("const qryVarSet = reactive({");
            List<string> arrCheck = new List<string>();
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (objQryRegionFldsEx.InUse == false) continue;

                if (arrCheck.Contains(objQryRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)) == true) continue;
                arrCheck.Add(objQryRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                if (string.IsNullOrEmpty(objQryRegionFldsEx.TabFeatureId4Ddl) == false)
                {
                    switch (objQryRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        case "number":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref(0);", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        case "boolean":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref(true)", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                    }
                    sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q,");
                    continue;
                }
                try
                {
                    switch (objQryRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        case "number":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref(0);", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        case "boolean":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref(true)", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                    }
                    sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q,");
                }
                catch (Exception objExceptionIn)
                {
                    throw objExceptionIn;
                }

            }
            var arrQryRegionFldSetEx = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.IsUseFunc() == true && string.IsNullOrEmpty(x.DataPropertyName()) == false).ToList();
            if (arrQryRegionFldSetEx.Count > 0)
            {

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx_In in arrQryRegionFldSetEx)
                {
                    if (objQryRegionFldsEx_In.InUse == false) continue;
                    if (arrCheck.Contains(objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase)) == true) continue;
                    arrCheck.Add(objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase));
                    if (string.IsNullOrEmpty(objQryRegionFldsEx_In.TabFeatureId4Ddl) == false)
                    {
                        switch (objQryRegionFldsEx_In.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('');", objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase));
                                break;
                            case "number":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref(0);", objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase));
                                break;
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref(true)", objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase));
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('');", objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase));
                                break;
                        }
                        sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase)},");
                        continue;
                    }
                    try
                    {
                        switch (objQryRegionFldsEx_In.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('');", objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase));
                                break;
                            case "number":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref(0);", objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase));
                                break;
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref(true)", objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase));
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('');", objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase));
                                break;
                        }
                        sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx_In.DataPropertyName_Property(this.IsFstLcase)},");
                    }
                    catch (Exception objExceptionIn)
                    {
                        throw objExceptionIn;
                    }
                }
            }

            sbCode_Export.Append("});");
            sbCode_Export.Append("\r\n" + "export { qryVarSet };");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_ts_FeatureVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "//��������������");

            StringBuilder sbCode_Export = new StringBuilder();
            sbCode_Export.Append("const featureVarSet = reactive({");
            List<string> arrCheck = new List<string>();
            foreach (clsViewFeatureFldsENEx objFeatureRegionFldsEx in objViewInfoENEx.arrViewFeatureFlds)
            {
                if (objFeatureRegionFldsEx.InUse == false) continue;
                if (arrCheck.Contains(objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)) == true) continue;
                arrCheck.Add(objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                if (string.IsNullOrEmpty(objFeatureRegionFldsEx.TabFeatureId4Ddl) == false)
                {
                    switch (objFeatureRegionFldsEx.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('');", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        case "number":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref(0);", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        case "boolean":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref(true)", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('');", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                    }
                    sbCode_Export.Append("\r\n" + $" {objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)}_f,");
                    continue;
                }
                try
                {
                    switch (objFeatureRegionFldsEx.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('');", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        case "number":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref(0);", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        case "boolean":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref(true)", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('');", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                    }
                    sbCode_Export.Append("\r\n" + $" {objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)}_f,");
                }
                catch (Exception objExceptionIn)
                {
                    throw objExceptionIn;
                }
            }
            sbCode_Export.Append("});");
            sbCode_Export.Append("\r\n" + "export { featureVarSet };");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_EditVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "//�༭����������");

            strCodeForCs.Append("\r\n" + "export const refEditObj = ref ();");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_DetailVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "//��ϸ��Ϣ����������");

            strCodeForCs.Append("\r\n" + "export const refDetailObj = ref ();");

            return strCodeForCs.ToString();
        }

        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());


        public string Gen_Vue_ts_FeatureVarDefBak()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strCacheClassifyFldName4View = "";
            string strCacheClassifyFldName4View2 = "";
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                strCacheClassifyFldName4View = thisCacheClassify4View.FldName;
            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                strCacheClassifyFldName4View2 = thisCacheClassify4View.FldName2;
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
                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {

                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true) continue;

                    clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var arrTabFeatureFldsEx = objTabFeature.arrTabFeatureFldsSetEx();
                    var arrTabFeatureFlds_Cond = arrTabFeatureFldsEx.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    var arrCondFldId = objTabFeature.GetCondFldIdLst();
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

                    CacheClassify objCacheClassify_TS = null;
                    if (string.IsNullOrEmpty(objInfor.DsTabId) == false)
                    {
                        var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objInfor.DsTabId, objInfor.PrjId);
                        objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);
                    }


                    string strCtrlId = objInfor.CtrlId;
                    if (string.IsNullOrEmpty(strCtrlId) == true)
                    {
                        strCtrlId = string.Format("ddl{0}", objInfor.FldName);
                    }
                    if (objInfor.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    {
                        if (strCtrlId.IndexOf("_SetFldValue") == -1)
                        {
                            strCtrlId = strCtrlId + "_SetFldValue";
                            objInfor.CtrlId = strCtrlId;
                        }
                    }

                    if (string.IsNullOrEmpty(objTabFeature.FuncNameJs) == true)
                    {
                        var tuple = clsTabFeatureBLEx.GetFuncName(objTabFeature);
                        objTabFeature.FuncNameJs = tuple.Item2;
                        //print(tuple.Item1);
                        //print(int.Parse(tuple.Item2));
                    }
                    objInfor.DivName = $"divVarSet.refDivList";


                    objInfor.CodeText = objInfor.GC_SetBindDdl4TabFeature4QueryEdit_TS(this.IsFstLcase, $"divVarSet.refDivFunction", objCacheClassify_TS, arrTabFeatureFldsEx, arrCondFldId, objFuncParaLstAll, "InFeature",
                         this, this.strBaseUrl);
                    //}
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);
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


        public string Gen_Vue_setup_var_ts_DataListVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "export const showErrorMessage = ref (false);");
            strCodeForCs.Append("\r\n" + $"export const dataList{TabName_Out4ListRegion} = ref<Array<cls{TabName_Out4ListRegion}ENEx>>([]);");
            strCodeForCs.Append("\r\n" + "export const emptyRecNumInfo = ref ('');");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_PubVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            var strFuncName = "";
            strCodeForCs.Append("\r\n" + GeneViewPubVarInVue(strFuncName));

            return strCodeForCs.ToString();
        }
        public string Gen_Vue_ts_ShareVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCode_Export = new StringBuilder();
            StringBuilder sbCode_ExportLst = new StringBuilder();

            sbCode_Export.Append("const divVarSet = reactive({");
            sbCode_Export.Append("\r\n" + " refDivLayout,");
            sbCode_Export.Append("\r\n" + "refDivQuery,");
            sbCode_Export.Append("\r\n" + "refDivFunction,");
            sbCode_Export.Append("\r\n" + "refDivList,");
            sbCode_Export.Append("\r\n" + "refDivEdit,");
            sbCode_Export.Append("\r\n" + "refDivDetail,");

            sbCode_ExportLst.Append("refDivLayout,");
            sbCode_ExportLst.Append("refDivQuery,");
            sbCode_ExportLst.Append("refDivFunction,");
            sbCode_ExportLst.Append("refDivList,");
            sbCode_ExportLst.Append("refDivEdit,");
            sbCode_ExportLst.Append("refDivDetail,");


            strCodeForCs.Append("\r\n" + "const refDivLayout = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivQuery = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivFunction = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivList = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivEdit = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivDetail = ref ();");
            if (IsHasDetailRegion)
            {
                strCodeForCs.Append("\r\n" + $"const ref{ThisDetailClsName} = ref ();");
                sbCode_Export.Append("\r\n" + $"ref{ThisDetailClsName},");
                sbCode_ExportLst.Append("\r\n" + $"ref{ThisDetailClsName},");

            }
            if (IsHasEditRegion)
            {
                strCodeForCs.Append("\r\n" + $"const ref{ThisEditClsName} = ref ();");
                sbCode_Export.Append("\r\n" + $"ref{ThisEditClsName},");
                sbCode_ExportLst.Append("\r\n" + $"ref{ThisEditClsName},");

            }
            if (IsHasListRegion)
            {
                strCodeForCs.Append("\r\n" + $"const ref{ThisListClsName} = ref ();");
                sbCode_Export.Append("\r\n" + $"ref{ThisListClsName},");
                sbCode_ExportLst.Append("\r\n" + $"ref{ThisListClsName},");

            }
            sbCode_Export.Append("});");
            sbCode_Export.Append("\r\n" + $"export {{ divVarSet, {sbCode_ExportLst} }};");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());

            return strCodeForCs.ToString();
        }
        public string Gen_Vue_ts_ViewVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "const ascOrDesc4SortFun = ref ('Asc');");
            strCodeForCs.Append("\r\n" + $"const sort{TabName_Out4ListRegion}By = ref ('');");
            strCodeForCs.Append("\r\n" + "const viewVarSet = reactive({");
            strCodeForCs.Append("\r\n" + "ascOrDesc4SortFun,");
            strCodeForCs.Append("\r\n" + $"sort{TabName_Out4ListRegion}By,");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "export { viewVarSet };");

            return strCodeForCs.ToString();
        }
        public string Gen_Vue_ts_DivVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCode_Export = new StringBuilder();
            sbCode_Export.Append("const divVarSet = reactive({");
            sbCode_Export.Append("\r\n" + " refDivLayout,");
            sbCode_Export.Append("\r\n" + "refDivQuery,");
            sbCode_Export.Append("\r\n" + "refDivFunction,");
            sbCode_Export.Append("\r\n" + "refDivList,");

            strCodeForCs.Append("\r\n" + "const refDivLayout = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivQuery = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivFunction = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivList = ref ();");
            if (IsHasDetailRegion)
            {
                strCodeForCs.AppendFormat("\r\n" + "const ref{0} = ref ();", ThisDetailClsName);
                sbCode_Export.Append("\r\n" + $"ref{ThisDetailClsName},");
            }

            sbCode_Export.Append("});");
            sbCode_Export.Append("export { divVarSet };");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());

            return strCodeForCs.ToString();
        }

        private string Gen_Ts_CombineConditionInFldValueLst()
        {
            bolIsNeedGeneReMapFunc = false;
            var arrQryRegionFldSetEx = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.IsUseFunc() == true && string.IsNullOrEmpty(x.DataPropertyName()) == false).ToList();
            if (arrQryRegionFldSetEx.Count == 0) return "";
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                ///���ɽ��б���;
                var arrQryRegionFld_InFld = arrQryRegionFldSetEx.GroupBy(x => x.FldId).ToList();
                foreach (var arrInFld in arrQryRegionFld_InFld)
                {
                    string strFldId = arrInFld.Key;
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, objViewInfoENEx.PrjId);
                    string strFldName = objFieldTab.FldName;

                    strCodeForCs.AppendFormat("\r\n" + "//���������չ�ֶ�:[{0}]�Ĳ�ѯ", strFldName);
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0} = await GetCondition_{0}Lst_In();", strFldName);
                    bolIsNeedGeneReMapFunc = true;
                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length > 0)", strFldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} in ({{1}})\", {strClsName_Fld}.con_{strFldName}, arr{strFldName}.join(','));");
                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{strFldName}, arr{strFldName}.join(','), \"in\");");
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

        public string Gen_Ts_CombineConditionInFldValueLst_GeneFun()
        {
            if (bolIsNeedGeneReMapFunc == false) return "";
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            var arrQryRegionFldSetEx = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.IsUseFunc() == true && string.IsNullOrEmpty(x.DataPropertyName()) == false).ToList();
            if (arrQryRegionFldSetEx.Count == 0) return "";
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;
                var arrQryRegionFld_InFld = arrQryRegionFldSetEx.GroupBy(x => x.FldId).ToList();
                foreach (var arrInFld in arrQryRegionFld_InFld)
                {
                    string strFldId = arrInFld.Key;
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, objViewInfoENEx.PrjId);
                    string strReturnString = objFieldTab.TypeScriptType();
                    if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
                    {
                        strReturnString = "string";
                    }
                    strCodeForCs.Append("\r\n /** �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.AppendFormat("\r\n * @returns ����ֶεĹؼ����б�(Array<{0}>)", strReturnString);
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + " export async function GetCondition_{0}Lst_In(): Promise<Array<{1}>> ", objFieldTab.FldName, strReturnString);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                    strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");

                    strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}ENEx();", TabName_Out4ListRegion4GC);

                    string strClsName_Fld = string.Format("cls{0}ENEx", TabName_Out4ListRegion4GC);


                    strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");
                    strCodeForCs.AppendFormat("\r\n" + "let arr{0}Include: Array<{1}> = [];", objFieldTab.FldName, strReturnString);

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (var objQryRegionFldsEx in arrInFld)
                    {
                        string strIsEx = "";
                        if (clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objQryRegionFldsEx.FldId) == true)
                        {
                            strIsEx = "Ex";
                        }
                        else if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false &&
                            clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objQryRegionFldsEx.OutFldId) == true) strIsEx = "Ex";

                        if (objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                        {

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objQryRegionFldsEx.objCtlType.CtlTypeName,
                                CtrlId = objQryRegionFldsEx.CtrlId(),
                                PropertyName = objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase),
                                Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "GetConditionInFldValueLst()"),
                                DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                ParentDivName = $"divVarSet.refDivQuery"
                            });
                        }
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                        {

                            case "CheckBox":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                             objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.DataPropertyName4GC()});");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, true, \"=\");");


                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.AppendFormat("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.DataPropertyName()}, false, \"=\");");
                                strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName(), objPrjTabEx_ListRegion.TabName));

                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "DropDownList": ///����ؼ���������;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {

                                    //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                    //objQryRegionFldsEx.DataPropertyName(), objQryRegionFldsEx.CtrlId());

                                    strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                    AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, true, \"=\");");

                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, false, \"=\");");
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName));

                                    strCodeForCs.Append("\r\n" + "}");

                                }
                                else
                                {
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                             objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\" && {0}.value != \"0\")",
                                                objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                    {
                                        case "string":

                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");


                                            break;
                                        case "int":

                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                            break;
                                        default:

                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                            break;
                                    }
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName));
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "TextBox": ///����ؼ��������ı���;

                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                    && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                {
                                    objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                }
                                if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                                {
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                            objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")",
                            objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                    {

                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                    }
                                    else
                                    {

                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                    }
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"like\");");
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                { ///��Χ��ѯ;
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
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
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "Button":
                                break;
                        }
                    }

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetConditionInFldValueLst", "����ϲ�ѯ�����йؼ����б�(GetConditionInFldValueLst)ʱ����!����ϵ����Ա!", "���ɴ���");
                    //AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                    strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"����ϲ�ѯ�����йؼ����б�(GetConditionInFldValueLst)ʱ����!����ϵ����Ա!{{0}}\", objException);",
                       ViewMainTabName4GC);
                    strCodeForCs.Append("\r\n" + "throw strMsg;");
                    strCodeForCs.Append("\r\n" + "}");
                    //    }

                    //}

                    strCodeForCs.AppendFormat("\r\n" + "return arr{0}Include;", objFieldTab.FldName);
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

        public string Gen_vue_ts_setup_fun_CombineCondition()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;

                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);


                strCodeForCs.Append("\r\n /** �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns ������(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export const  Combine{0}Condition = async():Promise<string> =>", TabName_Out4ListRegion4GC);
                strFuncName = $" public async Combine{TabName_Out4ListRegion4GC}Condition():Promise<string> ";
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");

                StringBuilder sbTemp = new StringBuilder();
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004)
                        {
                            CheckQueryField(objInFor);

                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == false)
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {strVarName}.value);");
                            }
                            else
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {strVarName}.value);");
                            }
                        }
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);
                        }

                        else
                        {
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == false)
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {strVarName}.value);");
                            }
                            else
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {strVarName}.value);");
                            }
                        }
                    }
                }

                if ((objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    && (objViewInfoENEx.arrQryRegionFldSet.Count > 0))
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    if (sbTemp.Length > 0)
                    {
                        strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                    }
                }
                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                }
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");

                strCodeForCs.Append("\r\n" + sbTemp.ToString());

                if (objViewInfoENEx.arrQryRegionFldSet.Count > 0)
                {
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("cls{0}EN", TabName_Out4ListRegion4GC), enumImportObjType.ENClass, this.strBaseUrl);
                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    {
                        strCodeForCs.Append("\r\n" + "try");
                        strCodeForCs.Append("\r\n" + "{");

                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                        {
                            string strFldName_T = objQryRegionFldsEx.FldName();
                            string strPropertyName_T = objQryRegionFldsEx.PropertyName;
                            string strFldName = objQryRegionFldsEx.FldName();
                            if (strFldName.IndexOf("Id_Stu") > -1)
                            {
                                strFldName = "";
                            }
                            //if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;

                            string strIsEx = "";
                            List<string> arrWhereConditionEx = new List<string>();
                            if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false)
                            {
                                strFldName_T = objQryRegionFldsEx.OutFldName();
                                strPropertyName_T = clsString.FirstLcaseS($"{strFldName_T}_q");
                                arrWhereConditionEx = clsDnPathBLEx.GetWhereConditionByDnPathId(objQryRegionFldsEx.DnPathId(), objQryRegionFldsEx.PrjId);
                                strIsEx = "Ex";
                            }
                            else if (clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objQryRegionFldsEx.FldId) == true)
                            {
                                strFldName_T = objQryRegionFldsEx.FldName();
                                strPropertyName_T = clsString.FirstLcaseS($"{strFldName_T}_q");
                                arrWhereConditionEx = clsDnPathBLEx.GetWhereConditionByDnPathId(objQryRegionFldsEx.DnPathId(), objQryRegionFldsEx.PrjId);

                                strIsEx = "Ex";
                            }
                            else if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false &&
                                clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objQryRegionFldsEx.OutFldId) == true)
                            {
                                strFldName_T = objQryRegionFldsEx.OutFldName();
                                strPropertyName_T = clsString.FirstLcaseS($"{strFldName_T}_q");
                                arrWhereConditionEx = clsDnPathBLEx.GetWhereConditionByDnPathId(objQryRegionFldsEx.DnPathId(), objQryRegionFldsEx.PrjId);

                                strIsEx = "Ex";
                            }


                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                            if (objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                            {
                            }
                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                                 strPropertyName_T);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///����ؼ���������;
                                case "DropDownList_Bool": ///����ؼ���������;

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if ({strPropertyName_T}.value == true)");
                                        //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}); ");
                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if ({strPropertyName_T}.value == false)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                        strCodeForCs.Append("\r\n" + "}");

                                    }
                                    else
                                    {
                                        //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                 strPropertyName_T);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\" && {0}.value != \"0\")",
                                                    strPropertyName_T);
                                        }
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                        {
                                            case "string":

                                                if (strIsEx == "Ex")
                                                {
                                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {arrWhereConditionEx[0]}\", {strPropertyName_T}.value);");
                                                }
                                                else
                                                {
                                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                                }
                                                break;
                                            case "int":

                                                if (strIsEx == "Ex")
                                                {
                                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {arrWhereConditionEx[0]}\", {strPropertyName_T}.value);");
                                                }
                                                else
                                                {
                                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                                }
                                                break;
                                            default:


                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                                break;
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;

                                case "TextBox": ///����ؼ��������ı���;
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                        && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                    {
                                        objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                    }
                                    if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                    (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                                    {
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                strPropertyName_T);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")",
                                strPropertyName_T);
                                        }

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                        {
                                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                        }
                                        else
                                        {
                                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", strPropertyName_T);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        if (strIsEx == "Ex" && arrWhereConditionEx.Count > 0)
                                        {
                                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {arrWhereConditionEx[0]} \", {strPropertyName_T}.value);");
                                        }
                                        else
                                        {
                                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///��Χ��ѯ;
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", strPropertyName_T);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value), , );");
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", strPropertyName_T);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value), , );");
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
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
                                case "CheckBoxList":
                                    break;
                                case "DataGrid":
                                    break;
                                case "DataList":
                                    break;
                                case "Button":
                                    break;
                                case "sessionStorage":
                                    break;
                                case "CacheClassifyField":
                                    break;
                                case "ViewVariable":
                                    break;
                                default:
                                    var strMsg = string.Format("(errorId:018)�ؼ����ͣ�{0}����Ӧ������û�б�����!({1})", objQryRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "catch(objException)");
                        strCodeForCs.Append("\r\n" + "{");
                        //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameCondition", "����ϲ�ѯ����(CombineTabNameCondition)ʱ����!����ϵ����Ա!", "���ɴ���");
                        AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                        strCodeForCs.Append("\r\n" + $"const strMsg:string = Format(\"����ϲ�ѯ����(Combine{ViewMainTabName4GC}Condition)ʱ����!����ϵ����Ա!{{0}}\", objException);");
                        strCodeForCs.Append("\r\n" + "throw strMsg;");
                        strCodeForCs.Append("\r\n" + "}");
                    }


                }
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "};");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_vue_ts_setup_fun_CombineConditionObj4ExportExcel()
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;


                strCodeForCs.Append("\r\n /** �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns ������(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + $"export const Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel = async ():Promise<cls{TabName_Out4ExportExcel4GC}EN> => ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

                if ((objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    && (objViewInfoENEx.arrQryRegionFldSet.Count > 0))
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                }

                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}ENEx();", TabName_Out4ExportExcel4GC);
                AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("cls{0}EN", TabName_Out4ExportExcel4GC), enumImportObjType.ENExClass, this.strBaseUrl);

                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_IsDeleted, false, \"=\");", TabName_Out4ListRegion4GC);
                }
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;
                        if (objInFor.IsForExtendClass()) continue;
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004 || objVar.VarTypeId == enumGCVariableType.localStorage_0003)
                        {
                            CheckQueryField(objInFor);

                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue(cls{TabName_Out4ExportExcel4GC}EN.con_{objInFor.ObjFieldTab().FldName}, {strVarName}.value, \"=\");");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue(cls{TabName_Out4ExportExcel4GC}EN.con_{objInFor.ObjFieldTab().FldName}, {strVarName}.value, \"=\");");
                        }
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");
                if (objViewInfoENEx.arrQryRegionFldSet.Count() > 0)
                {
                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    {
                        strCodeForCs.Append("\r\n" + "try");
                        strCodeForCs.Append("\r\n" + "{");
                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                        {

                            if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;
                            string strIsEx = "";
                            if (clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objQryRegionFldsEx.FldId) == true)
                            {
                                strIsEx = "Ex";
                            }
                            else if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false &&
                                clsPrjTabFldBLEx.IsForExtendClass(TabId_Out4ListRegion, objQryRegionFldsEx.OutFldId) == true) strIsEx = "Ex";

                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ExportExcel4GC);
                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, true, \"=\");");


                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, false, \"=\");");

                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///����ؼ���������;
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if ({objQryRegionFldsEx.PropertyName}.value == true)");
                                        //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}); ");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, true, \"=\");");

                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if ({objQryRegionFldsEx.PropertyName}.value == false)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, false, \"=\");");

                                        strCodeForCs.Append("\r\n" + "}");

                                    }
                                    else
                                    {
                                        //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                 objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\" && {0}.value != \"0\")",
                                                    objQryRegionFldsEx.PropertyName);
                                        }
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                        {
                                            case "string":


                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");


                                                break;
                                            case "int":


                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                                break;
                                            default:


                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                                break;
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;

                                case "TextBox": ///����ؼ��������ı���;
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                        && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                    {
                                        objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                    }
                                    if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                    (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                                    {
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")",
                                objQryRegionFldsEx.PropertyName);
                                        }

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                        {
                                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        }
                                        else
                                        {
                                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"like\");");

                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///��Χ��ѯ;
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value), , );");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
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
                                case "CheckBoxList":
                                    break;
                                case "DataGrid":
                                    break;
                                case "DataList":
                                    break;
                                case "Button":
                                    break;
                            }
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "catch(objException)");
                        strCodeForCs.Append("\r\n" + "{");
                        //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj4ExportExcel", "����ϵ���Excel��������(CombineTabNameConditionObj)ʱ����!����ϵ����Ա!", "���ɴ���");
                        AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                        strCodeForCs.Append("\r\n" + $"const strMsg:string = Format(\"����ϵ���Excel��������(Combine{ViewMainTabName4GC}ConditionObj4ExportExcel)ʱ����!����ϵ����Ա!{{0}}\", objException);");
                        strCodeForCs.Append("\r\n" + "throw strMsg;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.whereCond = strWhereCond;", TabName_Out4ExportExcel4GC);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ExportExcel4GC);
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


        public string GeneSetOperate(string strFldName, string strDataPropertyName, string strTabName)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_{1} = await {2}Ex_FuncMapKey{1}(obj{2}Cond);",
                                 strFldName, strDataPropertyName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Include.length == 0)",
                strFldName, strDataPropertyName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = arr{0}_{1}.map(x=>x.toString());",
                strFldName, strDataPropertyName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = intersectSets(arr{0}Include, arr{0}_{1}.map(x=>x.toString())); ",
                strFldName, strDataPropertyName);
            strCodeForCs.Append("\r\n" + "}");
            AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", String.Format("FuncMapKey{0}", strDataPropertyName), enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);
            AddImportClass(TabId_Out4ListRegion, "/PubFun/clsCommFunc4Ctrl.js", "intersectSets", enumImportObjType.CustomFunc, this.strBaseUrl);

            return strCodeForCs.ToString();
        }
    }
}
