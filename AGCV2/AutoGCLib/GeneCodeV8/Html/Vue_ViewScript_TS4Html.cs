using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Drawing.Printing;
using System.Web.UI.WebControls;
using Agc.PureClass;
using System.Reflection.Emit;

namespace AutoGCLib
{
    /// <summary>
    /// ����ר�����������ݱ�ı�����,�ô�������߼����һ����,��ϵ�ṹ���µ���,
    /// </summary>
    partial class Vue_ViewScript_TS4Html : clsGeneCodeBase, IImportClass
    {

        //private string strTabName_Out4ListRegion = "";
        //private string strTabId_Out4ListRegion = "";
        private string strJSPath = "";
        private clsFuncModule_AgcEN objFuncModule = null;
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        protected string strFuncName4BindGv = "";
        #region ���캯��
        public Vue_ViewScript_TS4Html()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_TS4Html(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_TS4Html(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
            strCodeForCs.Append("\r\n" + "BindTabByList = async(");
            strCodeForCs.Append("\r\n" + $"arrObjLst: Array<cls{TabName_Out4ListRegion}ENEx>,");
            strCodeForCs.Append("\r\n" + "bolIsShowErrMsg: boolean,");
            strCodeForCs.Append("\r\n" + "): Promise<void> => {");
            strCodeForCs.Append("\r\n" + $"dataList{TabName_Out4ListRegion}.value = arrObjLst;");
            strCodeForCs.Append("\r\n" + "showErrorMessage.value = bolIsShowErrMsg;");
            strCodeForCs.Append("\r\n" + "};");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_setup_ts_GetDdlDataBak()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            List<string> arrTabName4GC = new List<string>();
            try
            {
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                    if (arrTabName4GC.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTabName4GC.Add(objTabFeature4Ddl.TabName4GC);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}[]>([]);");
                }
                arrTabName4GC.RemoveRange(0, arrTabName4GC.Count);
                //���ÿһ������--������
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                    if (arrTabName4GC.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTabName4GC.Add(objTabFeature4Ddl.TabName4GC);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
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
                    if (objTabFeature4Ddl.IsForExtendClassFld == true)
                    {
//                        strCodeForCs.Append("\r\n" + $"let arrObjExLstSel = arrObjLstSel.map({objTabFeature4Ddl.TabName4GC}{strIsExtendedClassFld}_CopyToEx);");
                        strCodeForCs.Append("\r\n" + $"let arrObjExLstSel = arrObjLstSel.map({objTabFeature4Ddl.TabName4GC}{strIsExtendedClassFld}_CopyToEx);");
                        AddImportClass(objTabFeature4Ddl.TabId, objTabFeature4Ddl.TabName4GC + "Ex", "CopyToEx", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

                    }
                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC}.value.length = 0;");
                    strCodeForCs.Append("\r\n" + $"const obj0 = new cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}();");
                    if (objQryRegionFld.IsNumberType() == true)
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
                        strCodeForCs.Append("\r\n" + $"arrObj{strIsExtendedClassFld}LstSel = arrObj{strIsExtendedClassFld}LstSel.sort({objTabFeature4Ddl.SortStr});");
                    }

                    strCodeForCs.Append("\r\n" + $"arrObj{strIsExtendedClassFld}LstSel.forEach(x => arr{objTabFeature4Ddl.TabName4GC}.value.push(x));");
                    if (objQryRegionFld.IsNumberType() == true)
                    {
                        strCodeForCs.Append("\r\n" + $"{objQryRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q.value = 0;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"{objQryRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q.value = '0';");
                    }
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

        public string Gen_Vue_setup_ts_DefineDdlDataVarName()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            List<string> arrTabName4GC = new List<string>();
            try
            {
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                    if (arrTabName4GC.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTabName4GC.Add(objTabFeature4Ddl.TabName4GC);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}[]>([]);");
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

        public string Gen_Vue_setup_ts_GetDdlData4FeatureRegionBak()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                foreach (var objViewFeatureFlds in objViewInfoENEx.arrViewFeatureFlds)
                {
                    if (string.IsNullOrEmpty(objViewFeatureFlds.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objViewFeatureFlds.TabFeatureId4Ddl, this.IsFstLcase);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}[]>([]);");
                }
                //���ÿһ������--������
                foreach (var objViewFeatureFlds in objViewInfoENEx.arrViewFeatureFlds)
                {
                    if (string.IsNullOrEmpty(objViewFeatureFlds.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objViewFeatureFlds.TabFeatureId4Ddl, this.IsFstLcase);

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
                    strCodeForCs.Append("\r\n" + $"{objViewFeatureFlds.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)}_f.value = '0';");
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
        public string Gen_Vue_setup_ts_DefineDdlDataVarName4FeatureRegion()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                foreach (var objViewFeatureFlds in objViewInfoENEx.arrViewFeatureFlds)
                {
                    if (string.IsNullOrEmpty(objViewFeatureFlds.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objViewFeatureFlds.TabFeatureId4Ddl, this.IsFstLcase);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}[]>([]);");
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


        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = $(\"#{2}\").val();",
            objViewInfoENEx.TabName,
            objEditRegionFldsEx.FldName,
            objEditRegionFldsEx.CtrlId);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            sbCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(pobj{1}EN.{2});",
                        objEditRegionFldsEx.CtrlId,
                        objViewInfoENEx.TabName,
                        objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }

        /// <summary>
        /// ����:����Ĳ�ѯ���޸ġ����롢ɾ��
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            string strFuncName = "";

                clsViewRegionEN objViewRegion_Edit = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);

            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
  objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            objViewInfoENEx.WebFormName = string.Format("{0}", ThisClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.vue",
                objViewInfoENEx.FolderName, ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objViewInfoENEx);

            if (this.IsUseFunc)
            {
                strFuncName4BindGv = string.Format("BindGv_{0}4Func", TabName_Out4ListRegion4GC);
            }
            else
            {
                if (PrjTabEx_ListRegion.IsUseStorageCache_TS())
                {
                    strFuncName4BindGv = string.Format("BindGv_{0}Cache", TabName_Out4ListRegion4GC);
                }
                else
                {
                    strFuncName4BindGv = string.Format("BindGv_{0}", TabName_Out4ListRegion4GC);
                }
            }

            try
            {
                //��ȡ��������Ҫ�Ĺ�������

                if (string.IsNullOrEmpty(this.TabId_Out4ListRegion) == false) this.GetViewPubVarLst(this.TabId_Out4ListRegion);

                strCodeForCs.Append("\r\n" + "<template>");
                strCodeForCs.Append("\r\n" + "<div id = \"divLayout\" ref=\"refDivLayout\" class = \"div_layout\"> ");

                strCodeForCs.Append("\r\n" + "<!--�����-->");
                strCodeForCs.AppendFormat("\r\n" + GenViewTitle(string.Format("{0}", objViewInfoENEx.ViewCnName), objViewInfoENEx));

                //���ɲ�ѯ�������-------------------------------
                if (objViewInfoENEx.objViewRegion_Query != null)
                {
                    intZIndex += 1;
                    intCurrTop += 25;
                    intCurrLeft = 10;

                    clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true)
                    {
                        ///����ר�����ڲ�ѯ�Ľ���ؼ��Ĵ���;
                        strCodeForCs.Append("\r\n" + "<!--��ѯ��-->");
                        strCodeForCs.Append("\r\n" + GenQryRegionCode4Table());
                        intCurrTop += 40;
                    }

                    //����GridView�Ĵ���;

                    //				objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() = true;
                    //				objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() = true;

                    objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);
                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true)
                    {
                        strCodeForCs.Append("\r\n" + "<!--������-->");
                        strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));
                    }
                    if (objViewRegion_Edit != null)
                    {
                        ASPDivEx objDiv_Row;
                        ASPDivEx objDiv_List;
                        ASPDivEx objDiv_Edit;
                        switch (objViewRegion_Edit.PageDispModeId)
                        {
                            case enumPageDispMode.PopupBox_01:
                                GeneCode4ListRegion(strCodeForCs);
                                GeneCode4EditRegion(strCodeForCs);
                                break;
                            case enumPageDispMode.Right_02:
                                objDiv_Row = clsASPDivBLEx.GetEmptyDiv();
                                objDiv_Row.Class = "row";
                                objDiv_List = GetDiv4ListRegion();
                                objDiv_Edit = GetDiv4EditRegion();
                                objDiv_List.Class += " col-9";
                                objDiv_Edit.Class += " col-3";
                                objDiv_Row.arrSubAspControlLst2.Add(objDiv_List);
                                objDiv_Row.arrSubAspControlLst2.Add(objDiv_Edit);
                                objDiv_Row.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                                break;
                            case enumPageDispMode.Left_04:
                                objDiv_Row = clsASPDivBLEx.GetEmptyDiv();
                                objDiv_Row.Class = "row";
                                objDiv_List = GetDiv4ListRegion();
                                objDiv_Edit = GetDiv4EditRegion();
                                objDiv_List.Class += " col-9";
                                objDiv_Edit.Class += " col-3";
                                objDiv_Row.arrSubAspControlLst2.Add(objDiv_Edit);
                                objDiv_Row.arrSubAspControlLst2.Add(objDiv_List);
                                objDiv_Row.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                                break;
                            case enumPageDispMode.Below_03:
                                GeneCode4ListRegion(strCodeForCs);
                                GeneCode4EditRegion(strCodeForCs);
                                break;
                            default:
                                GeneCode4ListRegion(strCodeForCs);
                                GeneCode4EditRegion(strCodeForCs);
                                break;
                        }
                    }
                    //strCodeForCs.Append("\r\n" + GenGridViewNew(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

                    if (objViewInfoENEx.objViewRegion_List != null && objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                    {
                        strCodeForCs.Append("\r\n" + "<INPUT id = \"rd\" style = \"z-index: 109; left: 896px; width: 24px; position: absolute; top: 48px; height: 22px\" type = \"hidden\" size = \"1\" name = \"rd\" runat = \"server\"> ");
                        strCodeForCs.Append("\r\n" + "<INPUT style = \"display: none; z-index: 110; left: 8px; position: absolute; top: 1px\" type = \"radio\" CHECKED name = \"RadioName\">");
                    }


                }
                //���ɲ�ѯ������� == == == == == == == == == == == == == == == 

                if (IsHasDetailRegion)
                {
                    //���ɱ༭�������-------------------------------

                    ///�������ڲ��ֵı�����;
                    strCodeForCs.Append("\r\n" + "<!--��ϸ��Ϣ��-->");

                    strCodeForCs.AppendFormat("\r\n" + "<{0}Com ref='ref{0}'></{0}Com>", ThisDetailClsName);
                    //strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4EditRegion());
                }

                //���ɱ༭������� == == == == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</template>");
                strCodeForCs.Append("\r\n" + "<script lang=\"ts\">");
                //strCodeForCs.Append("\r\n" + "import \"~/lib/xlsx.core.min\" ");
                //strCodeForCs.Append("\r\n" + "import \"~/lib/xlsx.full.min\" ");
                //strCodeForCs.Append("\r\n" + "import $ from \"jquery\";");

                objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

                strCodeForCs.Append("\r\n" + Gen_vue_import_GeneCode());
            

                strCodeForCs.Append("\r\n" + "      export  default defineComponent({");

                strCodeForCs.Append("\r\n" + $"name: '{clsString.FirstUcaseS(ThisClsName)}',");
                //strCodeForCs.Append("\r\n" + "        data() {");
                //strCodeForCs.Append("\r\n" + "            return {");
                //strCodeForCs.Append("\r\n" + "                // ����");
                //strCodeForCs.Append("\r\n" + "            };");
                //strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + "        components: {");
                strCodeForCs.Append("\r\n" + "            // ���ע��");
                if (IsHasEditRegion) strCodeForCs.AppendFormat("\r\n" + "{0}Com,", ThisEditClsName);
                if (IsHasDetailRegion) strCodeForCs.AppendFormat("\r\n" + "{0}Com,", ThisDetailClsName);
                if (IsHasListRegion) strCodeForCs.AppendFormat("\r\n" + " {0}Com,", ThisListClsName);

                strCodeForCs.Append("\r\n" + "        },");

                strCodeForCs.Append("\r\n" + Gen_vue_setup_GeneCode());
                strCodeForCs.Append("\r\n" + "        watch: {");
                strCodeForCs.Append("\r\n" + "            // ���ݼ���");
                strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + "        mounted() {");

                //strCodeForCs.AppendFormat("\r\n" + "            const objPage = new {0}Ex();", ThisClsName);
                //strCodeForCs.Append("\r\n" + "            objPage.PageLoadCache();");                
                strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + Gen_vue_method_GeneCode());

                strCodeForCs.Append("\r\n" + "    });");
                strCodeForCs.Append("\r\n" + "</script>");


                //strCodeForCs.Append("\r\n" + "<input id=\"hidCurrPageIndex\" type = \"hidden\" value = \"1\" />");
                //strCodeForCs.AppendFormat("\r\n" + "<input id=\"h1idSort{0}By\" type = \"hidden\" value = \"\" />", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "<style scoped>");
                //strCodeForCs.Append("\r\n" + "@import \"../../../node_modules/bootstrap/dist/css/bootstrap.css\";");
                //strCodeForCs.Append("\r\n" + "@import \"../../../node_modules/bootstrap/dist/js/bootstrap.min.js\";");
                strCodeForCs.Append("\r\n" + "</style>");
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
                strCodeForCs.AppendFormat("\r\n" + "@click = \"{0}\" ", strOnClick);

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
        public string Gen_Vue_Cs4Ts_DefDiv4DetailRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divDetailDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog modal-dialog-centered modal-dialog-scrollable\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\" style=\"width: 800px;\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">ģ̬��Modal������</h4>", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");

            Func<clsDetailRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrDetailRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);
            var objViewRegion = objViewInfoENEx.objViewRegion_Detail;
            switch (objViewRegion.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Detail.ColNum ?? 0);
                    objTable.Width = objViewRegion.Width ?? 0;
                    objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objDiv_FormControl = clsASPDivBLEx.PackageByFormControl4DetailRegion(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);

                    objDiv_FormControl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4DetailRegion(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);

                    objFormInline.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4DetailRegion(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);

                    objDivTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4DetailRegion_H(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);

                    objUl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4DetailRegion_V(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);
                    objUl2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);
                    objTable2.Width = objViewRegion.Width ?? 0;
                    objTable2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
            }



            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-footer\">");
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnCancel{0}\" type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">�ر�</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnOKUpd_{0}\" type=\"button\" class=\"btn btn-primary\" @click=\"Submit_{0}()\">���</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }

       
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Vue_ViewScript_TS4Html);
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
            this.ClsName = string.Format("{0}", objViewInfoENEx.ViewName);
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
        public string Gen_WebView_Vue_Code4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "<!--������-->");
            strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_Vue_Code4ListRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "<!--�б��-->");
            strCodeForCs.Append("\r\n" + "<div id = \"divList\" class = \"div_List\" >");

            //strCodeForCs.Append("\r\n" + "<div id = \"divDataLst\" class = \"div_List\" >");

            //strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + $"<{TabName_Out4ListRegion}_ListCom");
            strCodeForCs.Append("\r\n" + $"ref = \"ref{TabName_Out4ListRegion}\"");
            strCodeForCs.Append("\r\n" + $":items = \"dataLst{TabName_Out4ListRegion}\"");
            strCodeForCs.Append("\r\n" + ":show-error-message = \"showErrorMessage\"");
            strCodeForCs.Append("\r\n" + ":empty-rec-num-info = \"emptyRecNumInfo\"");
            strCodeForCs.Append("\r\n" + "@on-edit-tab-relainfo = \"EditTabRelaInfo\"");
            strCodeForCs.Append("\r\n" + "@on-sort-column = \"SortColumn\"");
            strCodeForCs.Append("\r\n" + $"></{TabName_Out4ListRegion}_ListCom>");
            strCodeForCs.Append("\r\n" + "<div id = \"divPager\" class = \"pager\" value=\"1\" >");
            //strCodeForCs.Append("\r\n" + "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")");
            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</div>");
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_Vue_Code4DetailRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "<!--��ϸ��Ϣ��-->");
            strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4DetailRegion());

            return strCodeForCs.ToString();
        }

        public string Gen_WebView_Vue_Code4QueryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "<!--��ѯ��-->");

            strCodeForCs.Append("\r\n" + GenQryRegionCode4Table());
            return strCodeForCs.ToString();
        }
        private void GeneCode4ListRegion(StringBuilder strCodeForCs)
        {
            var objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true)
            {
                strCodeForCs.Append("\r\n" + "<!--�б��-->");
                var objDivEx_List = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_List.CtrlId = "divList";
                objDivEx_List.Ref = "refDivList";
                objDivEx_List.Class = "div_List";
                var objDivEx_DataLst = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_DataLst.CtrlId = "divDataLst";
                objDivEx_DataLst.Class = "div_List";

                var objDivEx_Pager = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_Pager.CtrlId = "divPager";
                objDivEx_Pager.Class = "pager";
                objDivEx_Pager.Value = "1";

                var objHiddenEx = clsASPHiddenFieldBLEx.GetEmptyHiddenField();
                objHiddenEx.CtrlId = string.Format("hidSort{0}By", TabName_Out4ListRegion);
                //objHiddenEx.Class = "pager";
                objHiddenEx.Value = "";

                //          < JxTeachingPlan_ListCom
                //  :items = "dataList"
                //  :show - error - message = "showErrorMessage"
                //  :empty - rec - num - info = "emptyRecNumInfo"
                //  @on - edit - tab - relainfo = "EditTabRelaInfo"
                //  @on - sort - column = "SortColumn"
                //></ JxTeachingPlan_ListCom >

                var myComp = new VueComponentEx();
                myComp.Props = new List<clsVueProp>();
                myComp.Events = new List<clsVueEvent>();

                myComp.ComponentName = $"{TabName_Out4ListRegion}_ListCom";
                myComp.RefName = $"ref{TabName_Out4ListRegion}_List";
                                
                myComp.Props.Add(new clsVueProp("items", $"dataList{TabName_Out4ListRegion}"));
                myComp.Props.Add(new clsVueProp("show-error-message", $"showErrorMessage"));
                myComp.Props.Add(new clsVueProp("empty-rec-num-info", $"emptyRecNumInfo"));
                myComp.Events.Add(new clsVueEvent("on-edit-tab-relainfo", $"EditTabRelaInfo"));
                myComp.Events.Add(new clsVueEvent("on-sort-column", $"SortColumn"));


                var objCode = new ASPCodeEx();
                //objCode.codeText = "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")";
                objDivEx_Pager.arrSubAspControlLst2.Add(objCode);
                objDivEx_List.arrSubAspControlLst2.Add(myComp);
                objDivEx_List.arrSubAspControlLst2.Add(objDivEx_Pager);
                objDivEx_List.arrSubAspControlLst2.Add(objHiddenEx);
                objDivEx_List.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);// clsASPDivBLEx.gene

            }
        }
        private void GeneCode4EditRegion(StringBuilder strCodeForCs)
        {
            var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;

            if (IsHasEditRegion == true)
            {
                //���ɱ༭�������-------------------------------

                strCodeForCs.Append("\r\n" + "<!--�༭��-->");

                strCodeForCs.AppendFormat("\r\n" + "<{0}Com ref='ref{0}'></{0}Com>", ThisEditClsName);


            }


        }

        private ASPDivEx GetDiv4ListRegion()
        {
            var objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true)
            {
                var objDivEx_List = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_List.Comment = "<!--�б��-->";
                objDivEx_List.CtrlId = "divList";
                objDivEx_List.Class = "div_List";
                var objDivEx_DataLst = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_DataLst.CtrlId = "divDataLst";
                objDivEx_DataLst.Class = "div_List";

                var objDivEx_Pager = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_Pager.CtrlId = "divPager";
                objDivEx_Pager.Class = "pager";
                objDivEx_Pager.Value = "1";

                var objCode = new ASPCodeEx();
                //objCode.codeText = "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")";
                objDivEx_Pager.arrSubAspControlLst2.Add(objCode);
                objDivEx_List.arrSubAspControlLst2.Add(objDivEx_DataLst);
                objDivEx_List.arrSubAspControlLst2.Add(objDivEx_Pager);
                return objDivEx_List;

            }
            return null;
        }


        private ASPDivEx GetDiv4EditRegion()
        {
            var objDivEx_Edit = clsASPDivBLEx.GetEmptyDiv();
            objDivEx_Edit.Comment = "<!--�༭��-->";
            var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;

            if (IsHasEditRegion == true)
            {
                //���ɱ༭�������-------------------------------

                objDivEx_Edit.CtrlId = "divEdit";
                objDivEx_Edit.Value = "1";
                return objDivEx_Edit;
            }
            return null;

        }

        public string Gen_Vue_setup_Ts_BindDdl4QryRegionInDivBak()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** ��������:Ϊ�༭����������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " async function BindDdl4QryRegionInDiv()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");

                //���ÿһ������--������
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);

                    //��0��:�ѿؼ���������ComboBoxת����ComboBox
                    if (objTabFeature4Ddl.IsHasErr)
                    {
                        throw new Exception(objTabFeature4Ddl.ErrMsg_Ddl);
                    }

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);

                    strCodeForCs.Append("\r\n" + $"getArr{objTabFeature4Ddl.TabName4GC}();");

                }

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

        public string Gen_Vue_setup_Ts_BindDdl4QryRegion()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            List<ASPDropDownListEx> arrASPDropDownListObj_Query
                = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001).ToList();
            try
            {
                strCodeForCs.Append("\r\n /** ��������:Ϊ��ѯ����������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "async function BindDdl4QryRegion()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");

                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);
                List<string> arrDsTabName = new List<string>();
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    if (arrDsTabName.Contains(objInfor.DsTabName) == true) continue;
                    arrDsTabName.Add(objInfor.DsTabName);
                    List<string> arrCondFldId;
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        if (objInfor.CsType == "bool")
                        {
                            objInfor.CodeText = "\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivQuery, \"{objInfor.CtrlId}\");";
                            AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindDdl_TrueAndFalseInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                        }
                        continue;
                    }
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objTabFeature, this.IsFstLcase, PrjTabEx_ListRegion);
                    string strByCondition = "";
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.ConditionFieldName) == false)
                        strByCondition = $"By{objTabFeature4Ddl.ConditionFieldName}";

                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                    var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    List<clsTabFeatureFldsENEx> arrTabFeatureFldsEx_Cond = arrTabFeatureFlds_Cond.Select(x=> x.CopyToEx()).ToList();
                    //objFuncParaLstAll.AddParaByTabFeature(objTabFeature, arrTabFeatureFldsEx_Cond, enumProgLangType.TypeScript_09);

                    arrCondFldId = objTabFeature.GetCondFldIdLst();
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

                    try
                    {
                        Tuple<string, string> tup = this.Gen_WApi_Ts_DefineVar4Ddl4TabFeature(objInfor, arrCondFldId, objFuncParaLstAll);

                        string strVar4Cond = tup.Item1;
                        string strFuncParaLst_Additional = tup.Item2;//�������������б�

                        if (objInfor.CsType == "bool")
                        {
                            objInfor.CodeText = string.Format("\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivQuery, \"{0}\");",
                                     objInfor.CtrlId);
                            AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindDdl_TrueAndFalseInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                        }
                        else
                        {
                            objInfor.CodeText = "\r\n" + $"arr{objInfor.DsTabName}.value = await {objInfor.DsTabName}_GetArr{objInfor.DsTabName}{strByCondition}({strFuncParaLst_Additional});//{clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId)}";
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
                    }
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl, true));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);
                }

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
        public Tuple<string, string> Gen_WApi_Ts_DefineVar4Ddl4TabFeature(ASPDropDownListEx objInfor, List<string> arrCondFldId, FuncParaLst objFuncParaLstAll)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);
            var strVarId_T1 = clsViewIdGCVariableRelaBLEx.GetCommonOriginVarId(objViewInfoENEx.ViewId, objInfor.VarIdCond1, objViewInfoENEx.PrjId);
            objFuncParaLst.AddParaByVar(strVarId_T1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            objFuncParaLstAll.AddParaByVar(strVarId_T1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            var strVarId_T2 = clsViewIdGCVariableRelaBLEx.GetCommonOriginVarId(objViewInfoENEx.ViewId, objInfor.VarIdCond2, objViewInfoENEx.PrjId);

            objFuncParaLst.AddParaByVar(strVarId_T2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            objFuncParaLstAll.AddParaByVar(strVarId_T2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            if (string.IsNullOrEmpty(objInfor.DsTabId) == false)
            {
                var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objInfor.DsTabId, objInfor.PrjId);
                var objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);

                objFuncParaLst.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                objFuncParaLstAll.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);

            }


            string strFuncParaLst_Additional = objFuncParaLst.GetCondFldLst();

            if (objFuncParaLst.GetLst != null)
            {
                foreach (var objInFor in objFuncParaLst.GetLst)
                {
                    if (string.IsNullOrEmpty(objInFor.FilePath) == true) continue;
                    AddImportClass(objViewInfoENEx.MainTabId, objInFor.FilePath, objInFor.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);
                    if (objInFor.VarTypeId == tsVarType.tsCache)
                    {
                        clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objInFor.FldLen, objInFor.VarName, this.ClsName);

                    }
                }
            }

            string strVar4Cond = "";

            objInfor.CodeText = strCodeForCs.ToString();
            Tuple<string, string> tup = new Tuple<string, string>(strVar4Cond, strFuncParaLst_Additional);

            return tup;
        }



        public string Gen_Vue_ts_ExportFuncDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ListRegion4GC}Condition : ()=>Promise<string>; ");
            strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ListRegion4GC}ConditionObj: ()=> Promise<cls{TabName_Out4ListRegion4GC}EN>; ");
            strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel: ()=>Promise<cls{TabName_Out4ExportExcel4GC}EN>; ");
            strCodeForCs.Append("\r\n" + $"export let BindTabByList: (arrObjLst: Array<cls{TabName_Out4ListRegion4GC}ENEx>,    bolIsShowErrMsg: boolean,) => Promise<void>;");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_ts_QryVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCode_Export = new StringBuilder();
            sbCode_Export.Append("const qryVarSet = reactive({");
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (objQryRegionFldsEx.InUse == false) continue;
                if (string.IsNullOrEmpty(objQryRegionFldsEx.TabFeatureId4Ddl) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref('0');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q,");
                    continue;
                }
                try
                {
                    switch (objQryRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        case "number":
                            strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref(0);", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        case "boolean":
                            strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref(true)", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                    }
                    sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q,");
                }
                catch (Exception objExceptionIn)
                {
                    throw objExceptionIn;
                }
            }
            sbCode_Export.Append("});");
            sbCode_Export.Append("export { qryVarSet };");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_setup_var_ts_DataListVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "const showErrorMessage = ref (false);");
            strCodeForCs.Append("\r\n" + $"const dataList{TabName_Out4ListRegion} = ref<Array<cls{TabName_Out4ListRegion}ENEx>>([]);");
            strCodeForCs.Append("\r\n" + "const emptyRecNumInfo = ref ('');");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_PubVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            var strFuncName = "";
            strCodeForCs.Append("\r\n" + GeneViewPubVarInVue(strFuncName));

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_ViewVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + $"const objPageCRUD = ref<{objViewInfoENEx.TabName}CRUD>();");
            strCodeForCs.Append("\r\n" + "const ascOrDesc4SortFun = ref ('Asc');");
            strCodeForCs.Append("\r\n" + $"const sort{TabName_Out4ListRegion}By = ref ('');");
            strCodeForCs.Append("\r\n" + "const viewVarSet = reactive({");
            strCodeForCs.Append("\r\n" + "objPageCRUD,");
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
                strCodeForCs.AppendFormat("\r\n" + " Combine{0}ConditionObj=async (): Promise<cls{0}EN> =>", TabName_Out4ListRegion4GC);
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
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38};
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                var arrQryRegionFldsEx = arrQryRegionFlds.Select(clsQryRegionFldsBLEx.CopyToEx);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFldsEx)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

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

                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({4}.con_{1}, {3}, \"=\");",
                             TabName_Out4ListRegion4GC,
                             objInFor.ObjFieldTab().FldName,
                             ThisClsName,
                             strVarName, strClsName_Fld);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({4}.con_{1}, {2}.{3}, \"=\");",
                                TabName_Out4ListRegion4GC,
                                objInFor.ObjFieldTab().FldName,
                                ThisClsName,
                                strVarName, strClsName_Fld);
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

                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                             objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, true, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName, strClsName_Fld);


                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.FldName, strClsName_Fld);

                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///����ؼ���������;
                                case "DropDownList_Bool": ///����ؼ���������;

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(this.divQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                        AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0}); ",
                                              objQryRegionFldsEx.FldName,
                                               strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                            TabName_Out4ListRegion4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(this.divQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                               objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                            TabName_Out4ListRegion4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

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


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                            TabName_Out4ListRegion4GC,
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName, strClsName_Fld);


                                                break;
                                            case "int":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                            default:


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
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
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                     objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", {2}.con_{0}, {1}.value);",
                                           objQryRegionFldsEx.FldName,
                                             objQryRegionFldsEx.PropertyName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"like\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///��Χ��ѯ;
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value), , );",
                                             objQryRegionFldsEx.FldName,
                                              objQryRegionFldsEx.PropertyName,
                                              strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName, strClsName_Fld);
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

        private string Gen_Ts_CombineConditionInFldValueLst()
        {
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
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0} = await this.GetCondition_{0}Lst_In();", strFldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length > 0)", strFldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} in ({{1}})\", {0}.con_{1}, arr{1}.join(','));",
                        strClsName_Fld, strFldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({1}.con_{2}, arr{2}.join(','), \"in\");",
                        TabName_Out4ListRegion4GC, strClsName_Fld, strFldName);
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
                strCodeForCs.AppendFormat("\r\n" + "  Combine{0}Condition = async():Promise<string> =>", TabName_Out4ListRegion4GC);
                strFuncName = $" public async Combine{TabName_Out4ListRegion4GC}Condition():Promise<string> ";
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");

                StringBuilder sbTemp = new StringBuilder();
                List<string> arrCtlType = new List<string>() {  enumCtlType.ViewVariable_38};
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
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {strVarName});");
                            }
                            else
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {strVarName});");
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
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {ThisClsName}.{strVarName});");
                            }
                            else
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {ThisClsName}.{strVarName});");
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

                            if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;

                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                            if ( objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                            {
                            }
                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                             objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///����ؼ���������;
                                case "DropDownList_Bool": ///����ؼ���������;

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(this.divQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                        AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0}); ",
                                              objQryRegionFldsEx.FldName,
                                               strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(this.divQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                               objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
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


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                break;
                                            case "int":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                break;
                                            default:


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
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
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                     objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     strClsName_Fld);
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", {2}.con_{0}, {1}.value);",
                                           objQryRegionFldsEx.FldName,
                                             objQryRegionFldsEx.PropertyName,
                                             strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///��Χ��ѯ;
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value), , );",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value), , );",
                                             objQryRegionFldsEx.FldName,
                                              objQryRegionFldsEx.PropertyName,
                                              strClsName_Fld);
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

        public string Gen_vue_setup_GeneCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "setup() {");
            strCodeForCs.Append("\r\n" + clsViewIdGCVariableRelaBLEx.GetGC_InitVarValue(objViewInfoENEx.ViewId, this,""));
            strCodeForCs.AppendFormat("\r\n" + " const objPage = ref<{0}Ex>();", ThisClsName);
            //strCodeForCs.Append("\r\n" + Gen_Vue_setup_var_ts_DataListVarDef());
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_DefineDdlDataVarName());
            }
            strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_DefineDdlDataVarName4FeatureRegion());
            
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("���湦����Ϊ��,����ӽ��湦��!����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            foreach(var objFeature in arrFeatureRegionFldsObjLst)
            {
                switch(objFeature.FeatureId)
                {
                    case enumPrjFeature.AddNewRecord_0136:
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnAddNewRecord_Click());
                        break;
                    case enumPrjFeature.UpdateRecord_0137:
                    case enumPrjFeature.UpdateRecord_Gv_0174:
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnUpdateRecord_Click());
                        break;
                    case enumPrjFeature.DelRecord_0138:
                    case enumPrjFeature.DelRecord_Gv_0175:
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnDelRecord_Click());
                        break;
                    case enumPrjFeature.Query_0139:
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnQuery_Click());

                        break;
                    case enumPrjFeature.CopyRecord_0141:
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnCopyRecord_Click());

                        break;
                    case enumPrjFeature.ExportToFile_0143:
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnExportExcel_Click());

                        break;
                    case enumPrjFeature.AddNewRecordWithMaxId_0183:
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnAddNewRecord_Click());

                        break;
                    case enumPrjFeature.AdjustOrderNum_1196:
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnUpMove_Click());
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnGoTop_Click());
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnGoBottum_Click());
                        strCodeForCs.Append("\r\n" + Gen_Vue_setup_ts_btnReOrder_Click());


                        break;

                    default:
                        var objPrjF = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeature.FeatureId);
                        string strMsg = string.Format("������:{1}��Switchû�д���,����({0})",
                clsStackTrace.GetCurrClassFunction(), objPrjF.FeatureName);
                        throw new Exception(strMsg);


                }
            }

            //strCodeForCs.Append("\r\n" + Gen_Vue_setup_fun_ts_BindTabByList());
            strCodeForCs.Append("\r\n" + Gen_Vue_setup_Ts_BindDdl4QryRegion());
            strCodeForCs.Append("\r\n" + Gen_Vue_setup_Ts_BindDdl4FeatureRegion());
            
            strCodeForCs.AppendFormat("\r\n" + "const strTitle = ref ('{0}ά��');", objViewInfoENEx.TabCnName);
            //strCodeForCs.AppendFormat("\r\n" + "const ref{0} = ref ();", ThisEditClsName);

            strCodeForCs.Append("\r\n" + "onMounted(() => {");

            strCodeForCs.Append("\r\n" + "BindDdl4QryRegion();");
            strCodeForCs.Append("\r\n" + "BindDdl4FeatureRegion();");

            strCodeForCs.Append("\r\n" + $"{ThisClsName}Ex.vuebtn_Click = btn_Click;");
            strCodeForCs.Append("\r\n" + $"{ThisClsName}Ex.GetPropValue = GetPropValue;");

            strCodeForCs.AppendFormat("\r\n" + "            objPage.value = new {0}Ex();", ThisClsName);
            //strCodeForCs.Append("\r\n" + $"objPage.divLayout = refDivLayout.value;");
            //strCodeForCs.Append("\r\n" + $"objPage.divQuery = refDivQuery.value;");
            //strCodeForCs.Append("\r\n" + $"objPage.divFunction = refDivFunction.value;");
            //strCodeForCs.Append("\r\n" + $"objPage.divList = refDivList.value;");
            strCodeForCs.Append("\r\n" + "            objPage.value.PageLoadCache();");
            strCodeForCs.Append("\r\n" + "         });");

            strCodeForCs.Append("\r\n" + "function GetPropValue(strPropName: string): string {");
            strCodeForCs.Append("\r\n" + "switch (strPropName)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case 'strTitle':");
            strCodeForCs.Append("\r\n" + "return strTitle.value;");
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "return '';");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + Gen_vue_ts_setup_fun_CombineConditionObj());
            //strCodeForCs.Append("\r\n" + Gen_vue_ts_setup_fun_CombineCondition());
            //strCodeForCs.Append("\r\n" + Gen_vue_ts_setup_fun_CombineConditionObj4ExportExcel());

            strCodeForCs.Append("\r\n" + "function btn_Click(strCommandName: string, strKeyId: string) {");
            //alert(Format("����:{0}, �ؼ���:{1}.", strCommandName, strKeyId));
            strCodeForCs.Append("\r\n" + "switch (strCommandName)");
            strCodeForCs.Append("\r\n" + "{");
            if (IsHasDetailRegion)
            {
                strCodeForCs.Append("\r\n" + "case 'Detail':");
                //strCodeForCs.AppendFormat("\r\n" + "{0}.DetailObj = ref{1};", ThisClsName, ThisDetailClsName);
                //strCodeForCs.AppendFormat("\r\n" + "{0}.DetailObj = ref{0};", ThisDetailClsName);
                strCodeForCs.Append("\r\n" + "break;");
            }
            if (IsHasEditRegion)
            {
                strCodeForCs.Append("\r\n" + "case 'Create':");
                strCodeForCs.Append("\r\n" + "case 'AddNewRecordWithMaxId':");
                strCodeForCs.Append("\r\n" + "case 'CreateWithMaxId':");
                strCodeForCs.Append("\r\n" + "case 'Update':");
                strCodeForCs.Append("\r\n" + "case 'UpdateRecord':");
                strCodeForCs.Append("\r\n" + "case 'UpdateRecordInTab':");
                //strCodeForCs.AppendFormat("\r\n" + "{0}.EditObj = ref{1}.value;", ThisClsName, ThisEditClsName);
                //strCodeForCs.AppendFormat("\r\n" + "{0}.EditObj = ref{0}.value;", ThisEditClsName);
                strCodeForCs.Append("\r\n" + "break;");
            }
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "{0}Ex.btn_Click(strCommandName, strKeyId);", ThisClsName, ThisEditClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return {");
            strCodeForCs.Append("\r\n" + "showErrorMessage,");
            strCodeForCs.Append("\r\n" + $"dataList{TabName_Out4ListRegion},");
            strCodeForCs.Append("\r\n" + "emptyRecNumInfo,");

            strCodeForCs.Append("\r\n" + "strTitle,");
            strCodeForCs.Append("\r\n" + "btn_Click,");
         
            strCodeForCs.Append("\r\n" + "...divVarSet,");
            strCodeForCs.Append("\r\n" + "refDivLayout,\r\n        refDivQuery,\r\n        refDivFunction,\r\n        refDivList,\r\n        ");
            if (IsHasEditRegion) strCodeForCs.AppendFormat("\r\n" + "ref{0},", ThisEditClsName);
            if (IsHasDetailRegion) strCodeForCs.AppendFormat("\r\n" + "ref{0},", ThisDetailClsName);
            if (IsHasListRegion) strCodeForCs.AppendFormat("\r\n" + "ref{0},", ThisListClsName);
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.InUse == false) continue;
                    if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0}_q,", objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().PropertyName_TS(this.IsFstLcase));
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0}_q,", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                }
            }
            foreach (clsViewFeatureFldsENEx objViewFeatureFldsEx in objViewInfoENEx.arrViewFeatureFlds)
            {
                //if (objQryRegionFldsEx.InUse == false) continue;
                strCodeForCs.AppendFormat("\r\n" + "{0}_f,", objViewFeatureFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
            }
            var arrTabName4GC = new List<string>();
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                    if (arrTabName4GC.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTabName4GC.Add(objTabFeature4Ddl.TabName4GC);
                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC},");
                }
            }
            arrTabName4GC.RemoveRange(0, arrTabName4GC.Count);
            foreach (var objViewFeatureFldsEx in objViewInfoENEx.arrViewFeatureFlds)
            {
                if (string.IsNullOrEmpty(objViewFeatureFldsEx.TabFeatureId4Ddl)) continue;            
                var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objViewFeatureFldsEx.TabFeatureId4Ddl, this.IsFstLcase);
                if (arrTabName4GC.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                                arrTabName4GC.Add(objTabFeature4Ddl.TabName4GC);
                strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC},");
            }
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "},");

            return strCodeForCs.ToString();
        }
        public string Gen_vue_method_GeneCode()
        {
            string strFuncName = "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "        methods: {");
            strCodeForCs.Append("\r\n" + Gen_Vue_method_ts_EditTabRelaInfo());
            strCodeForCs.Append("\r\n" + Gen_Vue_method_ts_SortColumn());
            strCodeForCs.Append("\r\n" + "            // ��������");

            //strCodeForCs.Append("\r\n" + "            /**");
            //strCodeForCs.Append("\r\n" + "             * ҳ�浼��-�ڵ���ҳ������еĺ���");
            //strCodeForCs.Append("\r\n" + "            **/");
            //strCodeForCs.Append("\r\n" + "            myonload() {");
            //strCodeForCs.AppendFormat("\r\n" + "                const objPage = new {0}Ex();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "                objPage.PageLoadCache();");
            //strCodeForCs.Append("\r\n" + "  },");

            strJSPath = string.Format("../js/{0}", objFuncModule.FuncModuleEnName4GC());

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_JS =
                clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx_JS(objViewInfoENEx);


            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_JS)
            {
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }
            }




            //strCodeForCs.Append("\r\n" + "<script>");
            //strCodeForCs.Append("\r\n" + "/**");
            //strCodeForCs.Append("\r\n" + "* ��һ��sheetת�����յ�excel�ļ���blob����,Ȼ������URL.createObjectURL����");
            //strCodeForCs.Append("\r\n" + "**/");
            //strCodeForCs.Append("\r\n" + " sheet2blob(sheet:any, sheetName:string)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "sheetName = sheetName || 'sheet1';");
            //strCodeForCs.Append("\r\n" + "const workbook = {");
            //strCodeForCs.Append("\r\n" + "SheetNames: [sheetName],");
            //strCodeForCs.Append("\r\n" + "Sheets: {}");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "workbook.Sheets[sheetName] = sheet;");
            //strCodeForCs.Append("\r\n" + "// ����excel��������");
            //strCodeForCs.Append("\r\n" + "const wopts = {");
            //strCodeForCs.Append("\r\n" + "bookType: 'xlsx', // Ҫ���ɵ��ļ�����");
            //strCodeForCs.Append("\r\n" + "bookSST: false, // �Ƿ�����Shared String Table,�ٷ�������,������������ٶȻ��½�,���ڵͰ汾IOS�豸���и��õļ�����");
            //strCodeForCs.Append("\r\n" + "type: 'binary'");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "const wbout = XLSX.write(workbook, wopts);");
            //strCodeForCs.Append("\r\n" + "const blob = new Blob([s2ab(wbout)], { type: \"application/octet-stream\" });");
            //strCodeForCs.Append("\r\n" + "// �ַ���תArrayBuffer");
            //strCodeForCs.Append("\r\n" + "function s2ab(s)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const buf = new ArrayBuffer(s.length);");
            //strCodeForCs.Append("\r\n" + "const view = new Uint8Array(buf);");
            //strCodeForCs.Append("\r\n" + "for (let i = 0; i != s.length; ++i) view[i] = s.charCodeAt(i) & 0xFF;");
            //strCodeForCs.Append("\r\n" + "return buf;");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "return blob;");
            //strCodeForCs.Append("\r\n" + "},");
            //strCodeForCs.Append("\r\n" + "/**");
            //strCodeForCs.Append("\r\n" + "* ͨ�õĴ����ضԻ��򷽷�,û�в��Թ����������");
            //strCodeForCs.Append("\r\n" + "* @param url ���ص�ַ,Ҳ������һ��blob����,��ѡ");
            //strCodeForCs.Append("\r\n" + "* @param saveName �����ļ���,��ѡ");
            //strCodeForCs.Append("\r\n" + "**/");
            //strCodeForCs.Append("\r\n" + " openDownloadDialog(url:string, saveName:string)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "if (typeof url == 'object' && url instanceof Blob) {");
            //strCodeForCs.Append("\r\n" + "url = URL.createObjectURL(url); // ����blob��ַ");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "const aLink = document.createElement('a');");
            //strCodeForCs.Append("\r\n" + "aLink.href = url;");
            //strCodeForCs.Append("\r\n" + "aLink.download = saveName || ''; // HTML5����������,ָ�������ļ���,���Բ�Ҫ��׺,ע��,file:///ģʽ�²�����Ч");
            //strCodeForCs.Append("\r\n" + "const event;");
            //strCodeForCs.Append("\r\n" + "if (window.MouseEvent) event = new MouseEvent('click');");
            //strCodeForCs.Append("\r\n" + "else {");
            //strCodeForCs.Append("\r\n" + "event = document.createEvent('MouseEvents');");
            //strCodeForCs.Append("\r\n" + "event.initMouseEvent('click', true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "aLink.dispatchEvent(event);");
            //strCodeForCs.Append("\r\n" + "},");
            //strCodeForCs.Append("\r\n" + "/**");
            //strCodeForCs.Append("\r\n" + "* �����û��Զ����JS�������鶼��������");
            //strCodeForCs.Append("\r\n" + "**/");
            //strCodeForCs.Append("\r\n" + "exportSpecialExcel_pyf(arrData:any, strFileName:string)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const sheet = XLSX.utils.aoa_to_sheet(arrData);");
            //strCodeForCs.Append("\r\n" + "    openDownloadDialog(sheet2blob(sheet), strFileName);");
            //strCodeForCs.Append("\r\n" + "},");

            strCodeForCs.Append("\r\n" + "},");

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
                strCodeForCs.Append("\r\n" + $" Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel = async ():Promise<cls{TabName_Out4ExportExcel4GC}EN> => ");
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
                List<string> arrCtlType = new List<string>() {  enumCtlType.ViewVariable_38, };
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

                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {3}, \"=\");",
                             TabName_Out4ExportExcel4GC,
                             objInFor.ObjFieldTab().FldName,
                             ThisClsName,
                             strVarName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}, \"=\");",
                                TabName_Out4ExportExcel4GC,
                                objInFor.ObjFieldTab().FldName,
                                ThisClsName,
                                strVarName);
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
                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ExportExcel4GC);
                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                             objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName, strClsName_Fld);


                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                    TabName_Out4ExportExcel4GC,
                                    objQryRegionFldsEx.FldName, strClsName_Fld);

                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///����ؼ���������;
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                        AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0}); ",
                                              objQryRegionFldsEx.FldName,
                                               strClsName_Fld,
                                              "{", "}");
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                            TabName_Out4ExportExcel4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                               objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                            TabName_Out4ExportExcel4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

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


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                            TabName_Out4ExportExcel4GC,
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName, strClsName_Fld);


                                                break;
                                            case "int":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                            default:


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
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
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                     objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", {2}.con_{0}, {1}.value);",
                                           objQryRegionFldsEx.FldName,
                                             objQryRegionFldsEx.PropertyName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"like\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///��Χ��ѯ;
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                    TabName_Out4ExportExcel4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value), , );",
                                             objQryRegionFldsEx.FldName,
                                              objQryRegionFldsEx.PropertyName,
                                              strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}N.con_{1}, {2}.value, \"=\");",
                                    TabName_Out4ExportExcel4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    strClsName_Fld);
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

        public string Gen_Vue_method_ts_EditTabRelaInfo()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** ����:�༭��������Ϣ");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "async EditTabRelaInfo(data: any) {");
                strCodeForCs.Append("\r\n" + "console.log('data:', data);");
                strCodeForCs.Append("\r\n" + $"router.push({{ name: 'edit{TabName_Out4ListRegion}', params: {{ courseId: data.courseId }} }});");
                strCodeForCs.Append("\r\n" + "},");

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
        public string Gen_Vue_method_ts_SortColumn()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** ����:���ݱ��н�������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "async SortColumn(data: any) {");
                strCodeForCs.Append("\r\n" + "console.log('data:', data);");
                strCodeForCs.Append("\r\n" + $"const objPage = new {objViewInfoENEx.TabName}CRUDEx();");
                strCodeForCs.Append("\r\n" + "objPage.SortColumn(data.sortColumnKey, data.sortDirection);");
                strCodeForCs.Append("\r\n" + "},");

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

        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());


        public string Gen_Vue_setup_Ts_BindDdl4FeatureRegionInDivBak()
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
        public string Gen_Vue_setup_Ts_BindDdl4FeatureRegion()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
            IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
            List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();


            try
            {
                strCodeForCs.Append("\r\n /** ��������:Ϊ��������������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "async function BindDdl4FeatureRegion()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                //         strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4QueryRegion.name;",
                //ViewMainTabName4GC, objKeyField.FldName);

                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");

                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    List<string> arrCondFldId;
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        if (objInfor.CsType == "bool")
                        {
                            objInfor.CodeText = "\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivFunction, \"{objInfor.CtrlId}\");";
                        }

                        continue;
                    }

                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objTabFeature, this.IsFstLcase, PrjTabEx_EditRegion);
                    string strByCondition = "";
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.ConditionFieldName) == false)
                        strByCondition = $"By{objTabFeature4Ddl.ConditionFieldName}";

                 
                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                    var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    arrCondFldId = objTabFeature.GetCondFldIdLst();
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

                    try
                    {
                        Tuple<string, string> tup;
                        //if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                        //{
                        //    //tup = this.Gen_WApi_Ts_DefineVar4Ddl(objInfor, objVarManage);
                        //}
                        //else
                        //{
                        tup = this.Gen_WApi_Ts_DefineVar4Ddl4TabFeature(objInfor, arrCondFldId, objFuncParaLstAll);
                        //}
                        //
                        string strVar4Cond = tup.Item1;
                        string strFuncParaLst_Additional = tup.Item2;//�������������б�

                        if (objInfor.CsType == "bool")
                        {
                            objInfor.CodeText = string.Format("\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivFunction, \"{0}\");",
                                     objInfor.CtrlId);
                        }
                        else
                        {
                            objInfor.CodeText = "\r\n" + $"arr{objInfor.DsTabName}.value = await {objInfor.DsTabName}_GetArr{objInfor.DsTabName}{strByCondition}({strFuncParaLst_Additional});//{clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId)}";
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
                    }
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);
                }


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
        public void GetImportClassLst(clsFuncModule_AgcEN objFuncModule0)
        {
            //List<ImportClass> arrImportClass = new List<ImportClass>();
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            
                arrImportClass.Add(new ImportClass
            {
                ClsName = "divVarSet ,refDivLayout,refDivQuery,refDivFunction, refDivList",
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare", "", objFuncModule0.FuncModuleEnName4GC(),
             ViewMainTabName4GC)
            });
            if (IsHasEditRegion)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = $"ref{ThisEditClsName}",
                    FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare", "", objFuncModule0.FuncModuleEnName4GC(),
                     ViewMainTabName4GC)
                });
            }
            if (IsHasDetailRegion)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = $"ref{ThisDetailClsName}",
                    FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare", "", objFuncModule0.FuncModuleEnName4GC(),
                     ViewMainTabName4GC)
                });
            }
            if (IsHasListRegion)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = $"ref{ThisListClsName}",
                    FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare", "", objFuncModule0.FuncModuleEnName4GC(),
                     ViewMainTabName4GC)
                });
            }
            //     arrImportClass.Add(new ImportClass
            //     {
            //         ClsName = "viewVarSet",
            //         FilePath = string.Format($"@/views/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare", "", objFuncModule0.FuncModuleEnName4GC(),
            //ViewMainTabName4GC)
            //     });

            string strAllVarNames = clsViewIdGCVariableRelaBLEx.GetAllViewVarNames(objViewInfoENEx.ViewId);
            //if (strAllVarNames.Length > 2) strAllVarNames += ",";
            string strClsNames = "";
            if (strAllVarNames.Length == 0)
            {
                 strClsNames = $" showErrorMessage, dataList{TabName_Out4ListRegion}, emptyRecNumInfo";
            }
            else
            {
                 strClsNames = $" showErrorMessage, dataList{TabName_Out4ListRegion}, emptyRecNumInfo, {strAllVarNames}";
            }
            arrImportClass.Add(new ImportClass
            {
                ClsName = strClsNames,
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare", "", objFuncModule0.FuncModuleEnName4GC(),
       ViewMainTabName4GC)
            });

            StringBuilder sbClassName = new StringBuilder();
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.InUse == false) continue;
                    if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId))
                    {
                        sbClassName.AppendFormat("\r\n" + "{0}_q,", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    else
                    {
                        sbClassName.AppendFormat("\r\n" + "{0}_q,", objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().PropertyName_TS(this.IsFstLcase));
                    }
                }
            }
            foreach (clsViewFeatureFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrViewFeatureFlds)
            {
                //if (objQryRegionFldsEx.InUse == false) continue;
                sbClassName.AppendFormat("\r\n" + "{0}_f,", objQryRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
            }
            arrImportClass.Add(new ImportClass
            {
                ClsName = sbClassName.ToString(),
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare", "", objFuncModule0.FuncModuleEnName4GC(),
       ViewMainTabName4GC)
            });



        }

        public  string Gen_vue_import_GeneCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + "//import $ from \"jquery\";");

            strCodeForCs.Append("\r\n" + "import 'jquery/dist/jquery.min.js';");
            strCodeForCs.Append("\r\n" + "import 'bootstrap/dist/js/bootstrap.min.js';");
            strCodeForCs.Append("\r\n" + "import 'bootstrap/dist/css/bootstrap.css';");
            strCodeForCs.Append("\r\n" + "import { defineComponent, onMounted, ref } from 'vue';");
            if (clsViewIdGCVariableRelaBLEx.IsNeedUseRoute(objViewInfoENEx.ViewId))
            {
                strCodeForCs.Append("\r\n" + "import { useRoute } from 'vue-router';");
            }
            strCodeForCs.Append("\r\n" + "import router from '@/router';");

            string strTemp = clsViewIdGCVariableRelaBLEx.GetGC_InitVarValue(objViewInfoENEx.ViewId, this, "@/ts/");
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                string strTemp2 = Gen_Vue_setup_ts_DefineDdlDataVarName();
            }
            GetImportClassLst(objFuncModuleEN);

            arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
            foreach (var objInFor in arrImportClass)
            {
                objInFor.ClsName = objInFor.ClsName;
                objInFor.FilePath = objInFor.FilePath.Replace(".js", "")
                          .Replace("../../TS/", "@/ts/")
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
                          .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                          .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/")
                          .Replace("../TS/", "@/ts/"));
            }

            //strCodeForCs.Append("\r\n" + "import { Format } from \"@/ts/PubFun/clsString\"");
            
            //strCodeForCs.Append("\r\n" + $"import {{ cls{objViewInfoENEx.TabName}EN }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{objViewInfoENEx.TabName}EN\";");
            //strCodeForCs.Append("\r\n" + $"import {{ cls{TabName_Out4ListRegion}ENEx }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}ENEx\";");

            if (objViewInfoENEx.IsShare)
            {
                strCodeForCs.AppendFormat("\r\n" + "import {{ {0}Ex }} from \"@/viewsShare/{1}/{0}Ex\";", ThisClsName, objFuncModule.FuncModuleEnName4GC());
                //strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"@/viewsBase/{1}Share/{0}\";", ThisClsName, objFuncModule.FuncModuleEnName4GC());
                if (IsHasEditRegion) strCodeForCs.AppendFormat("\r\n" + "import {0}Com from '@/viewsShare/{1}/{0}.vue';", ThisEditClsName, objFuncModule.FuncModuleEnName4GC());
                if (IsHasDetailRegion) strCodeForCs.AppendFormat("\r\n" + "import {0}Com from '@/viewsShare/{1}/{0}.vue';", ThisDetailClsName, objFuncModule.FuncModuleEnName4GC());
                if (IsHasListRegion) strCodeForCs.AppendFormat("\r\n" + "import {0}Com from '@/viewsShare/{1}/{0}.vue';", ThisListClsName, objFuncModule.FuncModuleEnName4GC());

                //if (IsHasEditRegion) strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from '@/viewsBase/{1}Share/{0}';", ThisEditClsName, objFuncModule.FuncModuleEnName4GC());
                //if (IsHasDetailRegion) strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from '@/viewsBase/{1}Share/{0}';", ThisDetailClsName, objFuncModule.FuncModuleEnName4GC());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "import {{ {0}Ex }} from \"@/views/{1}/{0}Ex\";", ThisClsName, objFuncModule.FuncModuleEnName4GC());
                //strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"@/viewsBase/{1}/{0}\";", ThisClsName, objFuncModule.FuncModuleEnName4GC());
                if (IsHasEditRegion) strCodeForCs.AppendFormat("\r\n" + "import {0}Com from '@/views/{1}/{0}.vue';", ThisEditClsName, objFuncModule.FuncModuleEnName4GC());
                if (IsHasDetailRegion) strCodeForCs.AppendFormat("\r\n" + "import {0}Com from '@/views/{1}/{0}.vue';", ThisDetailClsName, objFuncModule.FuncModuleEnName4GC());
                if (IsHasListRegion) strCodeForCs.AppendFormat("\r\n" + "import {0}Com from '@/views/{1}/{0}.vue';", ThisListClsName, objFuncModule.FuncModuleEnName4GC());

                //if (IsHasEditRegion) strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from '@/viewsBase/{1}/{0}';", ThisEditClsName, objFuncModule.FuncModuleEnName4GC());
                //if (IsHasDetailRegion) strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from '@/viewsBase/{1}/{0}';", ThisDetailClsName, objFuncModule.FuncModuleEnName4GC());

            }
            bool bolIsNeedBindTrueAndFalse = false;
            List<string> arrTabFeatureId4Add = new List<string>();
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFld.CtlTypeId == enumCtlType.DropDownList_Bool_18)
                    {
                        bolIsNeedBindTrueAndFalse = true;
                    }
                    if (objQryRegionFld.CtlTypeId == enumCtlType.DropDownList_06 && objQryRegionFld.DdlItemsOptionId==enumDDLItemsOption.TrueAndFalseList_04)
                    {
                        bolIsNeedBindTrueAndFalse = true;
                    }

                    if (arrTabFeatureId4Add.Contains(objQryRegionFld.TabFeatureId4Ddl) == true) continue;
                    arrTabFeatureId4Add.Add(objQryRegionFld.TabFeatureId4Ddl);
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    strCodeForCs.Append("\r\n" + $"import {{ cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld} }} from \"@/ts/L0Entity/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}\";");

                }
            }
            if (bolIsNeedBindTrueAndFalse)
            {
                strCodeForCs.Append("\r\n" + "import {BindDdl_TrueAndFalseInDivObj} from '@/ts/PubFun/clsCommFunc4Web';");
            }
            foreach (var objQryRegionFld in objViewInfoENEx.arrViewFeatureFlds)
            {
                if (arrTabFeatureId4Add.Contains(objQryRegionFld.TabFeatureId4Ddl) == true) continue;
                arrTabFeatureId4Add.Add(objQryRegionFld.TabFeatureId4Ddl);
                if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                strCodeForCs.Append("\r\n" + $"import {{ cls{objTabFeature4Ddl.TabName4GC}EN }} from \"@/ts/L0Entity/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}EN\";");

            }
            arrTabFeatureId4Add.RemoveRange(0, arrTabFeatureId4Add.Count);
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                //���ÿһ������--������
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (arrTabFeatureId4Add.Contains(objQryRegionFld.TabFeatureId4Ddl) == true) continue;
                    arrTabFeatureId4Add.Add(objQryRegionFld.TabFeatureId4Ddl);
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                    var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeature4Ddl.TabId, objTabFeature4Ddl.PrjId);
                    if (objPrjTabENEx_Ddl.IsUseCache_TS() == false)
                    {
                        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_GetObjLstAsync }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_GetObjLstCache }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");
                    }

                }

            }
            //���ÿһ������--������
            foreach (var objQryRegionFld in objViewInfoENEx.arrViewFeatureFlds)
            {
                if (arrTabFeatureId4Add.Contains(objQryRegionFld.TabFeatureId4Ddl) == true) continue;
                arrTabFeatureId4Add.Add(objQryRegionFld.TabFeatureId4Ddl);
                if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.IsFstLcase);
                var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeature4Ddl.TabId, objTabFeature4Ddl.PrjId);
                if (objPrjTabENEx_Ddl.IsUseCache_TS() == false)
                {
                    strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_GetObjLstAsync }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_GetObjLstCache }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");
                }

            }

            return strCodeForCs.ToString();
        }
        public string Gen_Vue_setup_ts_btnQuery_Click()
        {
            
            if (strFuncName4BindGv == "") return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "const btnQuery_Click =  async () => ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            //     strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnQuery_Click.name;",
            //ViewMainTabName4GC, objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = 1;");
            strCodeForCs.Append("\r\n" + "objPage.value.SetCurrPageIndex(1);");

            strCodeForCs.Append("\r\n" + $"await objPage.value.{strFuncName4BindGv}(refDivList.value);");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_setup_ts_btnExportExcel_Click()
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "const btnExportExcel_Click =  async ()=> ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            //     strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnExportExcel_Click.name;",
            //ViewMainTabName4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            if (this.IsUseFunc4ExcelExport == true && PrjTabEx_ExcelExportRegion.IsUseStorageCache_TS() == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "await objPage.value.ExportExcel_{0}4Func();",
                 TabName_Out4ExportExcel4GC);
            }
            else if (PrjTabEx_ExcelExportRegion.IsUseStorageCache_TS() == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "await objPage.value.ExportExcel_{0}Cache();",
                    TabName_Out4ExportExcel4GC);
            }
            else if (this.IsUseFunc4ExcelExport == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "await objPage.value.ExportExcel_{0}4Func();",
                 TabName_Out4ExportExcel4GC);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "await objPage.value.ExportExcel_{0}();",
                 TabName_Out4ExportExcel4GC);
            }
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_setup_ts_btnGoBottum_Click()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * �õ�");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnGoBottum_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnGoBottum_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {this.ClsName}.{objInFor.VarName}Static;");

                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", strViewVarName, enumImportObjType.CustomFunc, "");

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "get",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnGoBottum_Click()"),
                            //    DataType = "string",
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ�õ׵�${this.thisTabName}��¼!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoBottomAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoBottomAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `�õ׳�������:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

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
        public string Gen_Vue_setup_ts_btnReOrder_Click()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ����");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnReOrder_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnReOrder_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {this.ClsName}.{objInFor.VarName}Static;");

                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", strViewVarName, enumImportObjType.CustomFunc, "");

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "get",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                            //    DataType = "string",
                            //    IsStatic = false,
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "set",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                            //    DataType = "string",
                            //    IsStatic = false,
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                AddImportClass("", "/PubFun/clsOrderByData.js", "clsOrderByData", enumImportObjType.CustomFunc, this.strBaseUrl);

                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");

                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.ReOrderAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.ReOrderAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `�����������:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

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

        public string Gen_Vue_setup_ts_btnGoTop_Click()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /** �ö�");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnGoTop_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnGoTop_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        //strCodeForCs.AppendFormat("\r\n" + " const str{0}:string =$('#{1}').val();",
                        //  objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {this.ClsName}.{objInFor.VarName}Static;");

                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", strViewVarName, enumImportObjType.CustomFunc, "");

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "get",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                            //                "btnGoTop_Click()"),
                            //    DataType = "string",
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ�ö���${this.thisTabName}��¼!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                           objInFor.FldName.ToLower(),
                           objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoTopAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoTopAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `�ö���������:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                //strCodeForCs.Append("\r\n" + "}");
                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

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

        public string Gen_Vue_setup_ts_btnUpMove_Click()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ����");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnUpMove_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpMove_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        //strCodeForCs.AppendFormat("\r\n" + " const str{0}:string =$('#{1}').val();",
                        //    objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {this.ClsName}.{objInFor.VarName}Static;");
                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", strViewVarName, enumImportObjType.CustomFunc, "");

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "get",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                            //                "btnUpMove_Click()"),
                            //    DataType = "string",
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ���Ƶ�${this.thisTabName}��¼!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.UpMoveAsync)}(objOrderByData);");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.UpMoveAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `���Ƽ�¼��������:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

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
        protected bool Gene_ReFreshCache(StringBuilder sbCode)
        {
            //if (PrjTabEx_ListRegion.IsUseStorageCache_TS()== false)
            //{
            //    return;
            //}
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            if (PrjTabEx_ListRegion.IsUseStoreCache_TS() == true)
            {
                sbCode.Append("\r\n" + $"await {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store.delObj({PrjTabEx_EditRegion.KeyPrivFuncFldNameLstStr});");
                AddImportClass(TabId_In4Edit, clsString.FirstLcaseS(TabName_In4Edit4GC), string.Format("{0}Store", clsString.FirstLcaseS(TabName_In4Edit4GC)), enumImportObjType.StoreModule, $"@/store/modules{strIsShare}");
            }
            else if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == true)
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", TabName_In4Edit4GC);
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.value);", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                    AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}, {2});", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                    AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");
                    AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

                }
                AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("ReFreshCache", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

            }
            else
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache();", TabName_In4Edit4GC);
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.value);", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.value, {2}.value);", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
                return false;
            }
            return true;
        }
        public string Gen_Vue_setup_ts_btnCopyRecord_Click()
        {
            if (strFuncName4BindGv == "") return "";
            if (PrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                return "//��ؼ���,��֧�ָ��ƹ���!";
            }
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����¼�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "public async btnCopyRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnCopyRecord_Click.name;",
        ViewMainTabName4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
            AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ��¡��${this.thisTabName}��¼!`);");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "await this.CopyRecord(arrKeyIds);");

            strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `���Ƽ�¼���ɹ�,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Vue_setup_ts_btnSetFldValue_Click()
        {
            if (strFuncName4BindGv == "") return "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {

                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objInFor.ReleFldId, objInFor.PrjId());
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));
                    strCodeForCs.AppendFormat("\r\n /** �����ֶ�ֵ-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    strCodeForCs.AppendFormat("\r\n" + "public async {0}_Click() {{", objInFor.ButtonName);
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}_Click.name;", objInFor.ButtonName);
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                    AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                    strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"alert(`��ѡ����Ҫ����{objInFor.ObjFieldTabENEx.Caption}��${{this.thisTabName}}��¼!`);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    clsViewFeatureFldsENEx objViewFeatureFlds = null;
                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("���ܣ������ֶ�ֵ�ĸ�ֵ��ʽ�Ǹ���ֵ,��ȱ����Ӧ�Ľ��湦���ֶ�,��ά���������ɴ���");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                    }
                    if (objInFor.FeatureId == enumPrjFeature.SetFieldValue_0148
        && objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                        x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("���ܣ������ֶ�ֵ�ĸ�ֵ��ʽ�Ǹ���ֵ,��ȱ����Ӧ�Ľ��湦���ֶ�,��ά���������ɴ���");
                        }

                        objViewFeatureFlds = arrViewFeatureFlds[0];
                        ASPControlEx objASPControlENEx = clsASPControlBLEx.GetControl_Asp(objViewFeatureFlds);

                        string strCtrlId = objASPControlENEx.CtrlId.Replace("SetFldValue_SetFldValue", "SetFldValue");
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "Number":
                                strCodeForCs.Append("\r\n" + $"const str{objViewFeatureFlds.ObjFieldTabENEx.FldName} = GetSelectValueInDivObj(divVarSet.refDivFunction, \"{strCtrlId}\");");
                                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "//console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "const {0} = Number(str{1});",
                                    objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName); break;
                            case "boolean":
                                if (objViewFeatureFlds.CtlTypeId == enumCtlType.CheckBox_02)
                                {
                                    strCodeForCs.Append("\r\n" + $"const {objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName} = GetCheckBoxValueInDivObj(divVarSet.refDivFunction, '{strCtrlId}');");
                                    AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckBoxValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const {0}: boolean = $(\"#{1}\").prop(\"checked\");",
                      objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                      strCtrlId);
                                }
                                strCodeForCs.AppendFormat("\r\n" + "//console.log('{0}=' + {0});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                break;
                            default:
                                strCodeForCs.Append("\r\n" + $"const str{objViewFeatureFlds.ObjFieldTabENEx.FldName} = GetSelectValueInDivObj(divVarSet.refDivFunction, \"{strCtrlId}\");");
                                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "//console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "//console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "//console.log(arrKeyIds);");
                        if (objViewFeatureFlds.ObjFieldTabENEx.IsNumberType())
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {0} = Number(str{2});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        }
                        strCodeForCs.AppendFormat("\r\n" + "await this.{0}(arrKeyIds, {1});", strFuncName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "//console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "//console.log(arrKeyIds);");
                        strCodeForCs.AppendFormat("\r\n" + "await this.{0}(arrKeyIds);", strFuncName);
                    }

                    strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = `���ü�¼���ɹ�,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");

                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");

                    strCodeForCs.Append("\r\n" + "alert(strMsg);");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_Vue_setup_ts_btnDelRecord_Click()
        {

            if (PrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlView_02)
                return $"//���ڵ�ǰ����:[${PrjTabEx_View.TabName}]����ͼ,����Ҫ����ɾ�����ܺ���[btnDelRecord_Click];";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ɾ����¼");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDelRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecord_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (PrjTabEx_ListRegion.arrKeyFldSet.Count == 1)
            {
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫɾ����${this.thisTabName}��¼!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (confirmDel(arrKeyIds.length) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");

                strCodeForCs.AppendFormat("\r\n" + "await this.DelMultiRecord(arrKeyIds);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const arrKeyLsts = GetCheckedKeyLstsInDivObj(divVarSet.refDivList);");
                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyLstsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                strCodeForCs.Append("\r\n" + "if (arrKeyLsts.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫɾ����${this.thisTabName}��¼!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (confirmDel(arrKeyLsts.length) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");

                strCodeForCs.AppendFormat("\r\n" + "await this.DelMultiRecord_KeyLst(arrKeyLsts);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            }
            strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `ɾ��${this.thisTabName}��¼���ɹ�. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_setup_ts_btnDelRecordInTab_Click()
        {
            if (PrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlView_02)
                return $"//���ڵ�ǰ����:[${PrjTabEx_View.TabName}]����ͼ,����Ҫ����ɾ�����ܺ���[btnDelRecordInTab_Click];";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * �����ݱ���ɾ����¼");
            foreach (var objInFor in PrjTabEx_ListRegion.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n * \"{0}\": ��ؼ���", objInFor.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            if (PrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "public async btnDelRecordInTab_Click({0}) {{",
                    PrjTabEx_ListRegion.KeyVarDefineLstStr_TS);
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecordInTab_Click.name;",
           ViewMainTabName4GC, objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (var objInFor in PrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType() == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " if (IsNullOrEmpty({0}) == true)", objInFor.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + " if ({0} == 0)", objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫɾ����${this.thisTabName}��¼!`);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "if (confirmDel(0) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");
                strCodeForCs.AppendFormat("\r\n" + "await this.DelRecord({0});", PrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS);
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public async btnDelRecordInTab_Click(strKeyId:string) {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecordInTab_Click.name;",
                    ViewMainTabName4GC, objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫɾ����${this.thisTabName}��¼!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (confirmDel(0) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "await this.DelRecord(lngKeyId);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await this.DelRecord(strKeyId);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
                }
            }
            strCodeForCs.Append("\r\n" + $" await this.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `ɾ��${this.thisTabName}��¼���ɹ�. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_Vue_setup_ts_btnAddNewRecord_Click()
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
        public string Gen_Vue_setup_ts_btnUpdateRecord_Click()
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

    }
}
