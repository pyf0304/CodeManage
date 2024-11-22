using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.sql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{

    public class JsFunction : IDisposable
    {
        public StringBuilder sbText = null;
        //�Ƿ�������
        bool _disposed;
        /// <summary>
        /// ������
        /// </summary>
        public string funcName { get; set; }
        /// <summary>
        /// �����ı�����
        /// </summary>
        public string funcText
        {
            get { return sbText.ToString(); }
        }

        public JsFunction()
        {
            sbText = new StringBuilder();

        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return; //����Ѿ�������,���ж�ִ��
            if (disposing)
            {
                //TODO:�ͷ���Щʵ��IDisposable�ӿڵ��йܶ���
            }
            //TODO:�ͷŷ��й���Դ,���ö���Ϊnull
            _disposed = true;
        }
    }


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
    public abstract partial class clsGeneCodeBase : IImportClass
    {

        private bool isFstLcase = false;      //�Ƿ���������ĸСд
        protected string strBaseUrl = "../..";
        private string strTabName_Out4ListRegion;
        private string strTabName_Out4ListRegion4GC;
        private string strTabId_Out4ListRegion;

        private string strTabName_In4Edit;
        private string strTabName_In4Edit4GC;
        private string strTabCnName_In4Edit4GC;

        private string strTabCnName_In4Edit;
        private string strTabId_In4Edit;
        private string strViewMainTabName4GC;
        private string strViewMainTabId4GC;
        private string strTabNameHead;
        private string strTabNameHeadEx;
        private string strControllerName;
        private string strControllerNameEx;
        private string strConstructorName;
        private string strConstructorNameEx;

        private string strTabName_Out4DetailRegion;
        private string strTabName_Out4DetailRegion4GC;
        private string strTabId_Out4DetailRegion;

        private string strTabName_Out4ExportExcel;
        private string strTabName_Out4ExportExcel4GC;
        private string strTabId_Out4ExportExcel;
        private string strIsUseFunc = null;
        private string strIsUseFunc4ExcelExport = null;
        private CacheClassify4View myCacheClassify4View = null;
        private CacheClassify objCacheClassify_TS = null;
        private CacheClassify objCacheClassify_List_TS = null;
        private CacheClassify objCacheClassify_ExportExcel_TS = null;
        private CacheClassify objCacheClassify = null;
        private TabProp objTabProp_TS = null;
        private TabProp objEditTabProp_TS = null;
        private TabProp objDetailTabProp_TS = null;

        private TabProp objExcelExportTabProp_TS = null;
        private TabProp objListTabProp_TS = null;

        private TabProp objViewTabProp_TS = null;

        private clsPrjTabENEx objPrjTabEx_EditRegion = null;
        private clsPrjTabENEx objPrjTabEx_DetailRegion = null;
        private clsPrjTabENEx objPrjTabEx_ExcelExportRegion = null;
        private clsPrjTabENEx objPrjTabEx_ListRegion = null;

        private clsPrjTabENEx objPrjTabEx_View = null;

        //protected clsPrjTabENEx objPrjTabEx_EditRegion = null;

        protected int intZIndex;      ///�ؼ��������
        protected float intCurrLeft;  ///�ؼ�����߿�;
        protected float intCurrTop;  ///�ؼ��Ķ����;
        public bool IsHasOrderFunc = false;//�Ƿ���������

        //public string controllerName = "_";
        //public string constructorName = "";
        public clsFunction4CodeEN Re_objFunction4Code = null;
        public List<JsFunction> arrJsFunction = null;
        public List<string> arrDdlKeyIdLst = null;
        public List<ImportClass> arrImportClass = null;// new List<ImportClass>();
        //public List<ImportClass> arrImportClass_RemoveDup = null;// new List<ImportClass>();

        private clsPrjTabFldENEx mobjKeyField = null;
        private clsPrjTabFldENEx mobjPrefixField = null;
        protected clsPrjTabFldENEx objPrefixField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objPrefixField;
                }
                return mobjPrefixField;
            }
        }

        public CacheClassify thisCacheClassify
        {
            get
            {
                if (objCacheClassify == null)
                {
                    CacheClassify obj = new CacheClassify
                    {
                        FldId = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.FldId : "",
                        FldId2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.FldId : "",
                        FldName = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.FldName : "",
                        FldName2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.FldName : "",
                        PriVarName = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.PrivFuncName : "",
                        PriVarName2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.PrivFuncName : "",
                        TypeScriptType = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                        TypeScriptType2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                        CsType = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "",
                        CsType2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "",

                        DataTypeId = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.DataTypeId : "",
                        DataTypeId2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.DataTypeId : "",
                        FldLength = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength : 0,
                        FldLength2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.FldLength : 0,
                        IsHasCacheClassfyFld = objPrjTabENEx.objCacheClassifyFld == null ? false : true,
                        IsHasCacheClassfyFld2 = objPrjTabENEx.objCacheClassifyFld2 == null ? false : true,
                        IsNumberType = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.IsNumberType() : false,
                        IsNumberType2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.IsNumberType() : false,
                    };
                    objCacheClassify = obj;
                }
                return objCacheClassify;
            }
        }
        public TabProp thisTabProp_TS
        {
            get
            {
                if (objTabProp_TS == null)
                {
                    TabProp obj = new TabProp
                    {
                        KeyFldCount = objPrjTabENEx.arrKeyFldSet.Count,
                        FldId = objPrjTabENEx.KeyFldId(),
                        FldName = objPrjTabENEx.KeyFldName(),
                        KeyFldNameLstStr = objPrjTabENEx.KeyFldNameLstStr,
                        KeyVarDefineLstStr = objPrjTabENEx.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = objPrjTabENEx.KeyPrivFuncFldNameLstStr_TS,

                        ByInFuncName = objPrjTabENEx.arrKeyFldSet.Count == 1 ? objPrjTabENEx.KeyFldName() : "KeyLst",
                    };
                    objTabProp_TS = obj;
                }
                return objTabProp_TS;
            }
        }

        public TabProp thisDetailTabProp_TS
        {
            get
            {
                if (objDetailTabProp_TS == null)
                {
                    List<string> arrTemp = new List<string>();
                    foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                    {
                        arrTemp.Add(objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    string strTemp = clsArray.GetSqlInStrByArray(arrTemp, false);
                    TabProp obj = new TabProp
                    {
                        KeyFldCount = PrjTabEx_DetailRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_DetailRegion.KeyFldId(),
                        FldName = PrjTabEx_DetailRegion.KeyFldName(),
                        KeyFldNameLstStr = PrjTabEx_DetailRegion.KeyFldNameLstStr,
                        PropertyNameLstrStr = strTemp,
                        KeyVarDefineLstStr = PrjTabEx_DetailRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_DetailRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_DetailRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_EditRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_DetailRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objDetailTabProp_TS = obj;
                }
                return objDetailTabProp_TS;
            }
        }

        public string thisPrjId
        {
            get
            {
                if (objPrjTabENEx != null) return objPrjTabENEx.PrjId;
                return objViewInfoENEx.PrjId;
            }
        }

        public TabProp thisViewTabProp_TS
        {
            get
            {
                if (objViewTabProp_TS == null)
                {
                    TabProp obj = new TabProp
                    {
                        KeyFldCount = PrjTabEx_DetailRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_ExcelExportRegion.KeyFldId(),
                        FldName = PrjTabEx_ExcelExportRegion.KeyFldName(),
                        KeyFldNameLstStr = PrjTabEx_ExcelExportRegion.KeyFldNameLstStr,
                        KeyVarDefineLstStr = PrjTabEx_ExcelExportRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_ExcelExportRegion.KeyPrivFuncFldNameLstStr_TS,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_ExcelExportRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_ExcelExportRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_ExcelExportRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_ExcelExportRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objExcelExportTabProp_TS = obj;
                }
                return objExcelExportTabProp_TS;
            }
        }

        public TabProp thisExcelExportTabProp_TS
        {
            get
            {
                if (objExcelExportTabProp_TS == null)
                {
                    TabProp obj = new TabProp
                    {
                        KeyFldCount = PrjTabEx_DetailRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_ExcelExportRegion.KeyFldId(),
                        FldName = PrjTabEx_ExcelExportRegion.KeyFldName(),
                        KeyFldNameLstStr = PrjTabEx_ExcelExportRegion.KeyFldNameLstStr,
                        KeyVarDefineLstStr = PrjTabEx_ExcelExportRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_ExcelExportRegion.KeyPrivFuncFldNameLstStr_TS,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_ExcelExportRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_ExcelExportRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_ExcelExportRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_ExcelExportRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objExcelExportTabProp_TS = obj;
                }
                return objExcelExportTabProp_TS;
            }
        }

        public TabProp thisListTabProp_TS
        {
            get
            {
                if (objListTabProp_TS == null)
                {
                    TabProp obj = new TabProp
                    {
                        KeyFldCount = PrjTabEx_ListRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_ListRegion.KeyFldId(),
                        FldName = PrjTabEx_ListRegion.KeyFldName(),
                        KeyFldNameLstStr = PrjTabEx_ListRegion.KeyFldNameLstStr,
                        KeyVarDefineLstStr = PrjTabEx_ListRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_ListRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_ListRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_ListRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_ListRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objListTabProp_TS = obj;
                }
                return objListTabProp_TS;
            }
        }


        public TabProp thisEditTabProp_TS
        {
            get
            {
                if (objEditTabProp_TS == null)
                {
                    List<string> arrTemp = new List<string>();
                    foreach ( var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                    {
                        arrTemp.Add(objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    string strTemp = clsArray.GetSqlInStrByArray(arrTemp, false);
                    TabProp obj = new TabProp
                    {
                        KeyFldCount = PrjTabEx_EditRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_EditRegion.KeyFldId(),
                        FldName = PrjTabEx_EditRegion.KeyFldName(),
                        KeyFldNameLstStr = PrjTabEx_EditRegion.KeyFldNameLstStr,
                        PropertyNameLstrStr = strTemp,
                        KeyVarDefineLstStr = PrjTabEx_EditRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_EditRegion.KeyPrivFuncFldNameLstStr_TS,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_EditRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_EditRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_EditRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_EditRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objEditTabProp_TS = obj;
                }
                return objEditTabProp_TS;
            }
        }

        public CacheClassify thisCacheClassify_TS
        {
            get
            {
                if (objCacheClassify_TS == null)
                {
                    CacheClassify obj = new CacheClassify
                    {
                        FldId = objPrjTabENEx.objCacheClassifyFld_TS != null ? objPrjTabENEx.objCacheClassifyFld_TS.FldId : "",
                        FldId2 = objPrjTabENEx.objCacheClassifyFld2_TS != null ? objPrjTabENEx.objCacheClassifyFld2_TS.FldId : "",
                        FldName = objPrjTabENEx.objCacheClassifyFld_TS != null ? objPrjTabENEx.objCacheClassifyFld_TS.FldName : "",
                        FldName2 = objPrjTabENEx.objCacheClassifyFld2_TS != null ? objPrjTabENEx.objCacheClassifyFld2_TS.FldName : "",
                        PriVarName = objPrjTabENEx.objCacheClassifyFld_TS != null ? objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName : "",
                        PriVarName2 = objPrjTabENEx.objCacheClassifyFld2_TS != null ? objPrjTabENEx.objCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName : "",
                        TypeScriptType = objPrjTabENEx.objCacheClassifyFld_TS != null ? objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                        TypeScriptType2 = objPrjTabENEx.objCacheClassifyFld2_TS != null ? objPrjTabENEx.objCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                        CsType = objPrjTabENEx.objCacheClassifyFld_TS != null ? objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "",
                        CsType2 = objPrjTabENEx.objCacheClassifyFld2_TS != null ? objPrjTabENEx.objCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "",

                        DataTypeId = objPrjTabENEx.objCacheClassifyFld_TS != null ? objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.DataTypeId : "",
                        DataTypeId2 = objPrjTabENEx.objCacheClassifyFld2_TS != null ? objPrjTabENEx.objCacheClassifyFld2_TS.ObjFieldTabENEx.DataTypeId : "",
                        FldLength = objPrjTabENEx.objCacheClassifyFld_TS != null ? objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.FldLength : 0,
                        FldLength2 = objPrjTabENEx.objCacheClassifyFld2_TS != null ? objPrjTabENEx.objCacheClassifyFld2_TS.ObjFieldTabENEx.FldLength : 0,
                        IsHasCacheClassfyFld = objPrjTabENEx.objCacheClassifyFld_TS == null ? false : true,
                        IsHasCacheClassfyFld2 = objPrjTabENEx.objCacheClassifyFld2_TS == null ? false : true,
                        IsNumberType = objPrjTabENEx.objCacheClassifyFld_TS != null ? objPrjTabENEx.objCacheClassifyFld_TS.IsNumberType() : false,
                        IsNumberType2 = objPrjTabENEx.objCacheClassifyFld2_TS != null ? objPrjTabENEx.objCacheClassifyFld2_TS.IsNumberType() : false,
                        IsForExtendClass = objPrjTabENEx.objCacheClassifyFld_TS != null ? objPrjTabENEx.objCacheClassifyFld_TS.IsForExtendClass():false,
                        IsForExtendClass2 = objPrjTabENEx.objCacheClassifyFld2_TS != null ? objPrjTabENEx.objCacheClassifyFld2_TS.IsForExtendClass():false,

                    };
                    objCacheClassify_TS = obj;
                }
                return objCacheClassify_TS;
            }
        }

        public CacheClassify thisCacheClassify_List_TS
        {
            get
            {
                if (objCacheClassify_List_TS == null)
                {
                    CacheClassify obj = new CacheClassify();

                    obj.FldId = PrjTabEx_ListRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld_TS.FldId : "";
                    obj.FldId2 = PrjTabEx_ListRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld2_TS.FldId : "";
                    obj.FldName = PrjTabEx_ListRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld_TS.FldName : "";
                    obj.FldName2 = PrjTabEx_ListRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld2_TS.FldName : "";
                    obj.PriVarName = PrjTabEx_ListRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.PriVarName2 = PrjTabEx_ListRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.TypeScriptType = PrjTabEx_ListRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.TypeScriptType2 = PrjTabEx_ListRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.CsType = PrjTabEx_ListRegion.objCacheClassifyFld != null ? PrjTabEx_ListRegion.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "";
                    obj.CsType2 = PrjTabEx_ListRegion.objCacheClassifyFld2 != null ? PrjTabEx_ListRegion.objCacheClassifyFld2.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "";
                    obj.DataTypeId = PrjTabEx_ListRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.DataTypeId2 = PrjTabEx_ListRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld2_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.FldLength = PrjTabEx_ListRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.FldLength2 = PrjTabEx_ListRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld2_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.IsHasCacheClassfyFld = PrjTabEx_ListRegion.objCacheClassifyFld_TS == null ? false : true;
                    obj.IsHasCacheClassfyFld2 = PrjTabEx_ListRegion.objCacheClassifyFld2_TS == null ? false : true;
                    obj.IsNumberType = PrjTabEx_ListRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld_TS.IsNumberType() : false;
                    obj.IsNumberType2 = PrjTabEx_ListRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.objCacheClassifyFld2_TS.IsNumberType() : false;

                    objCacheClassify_List_TS = obj;
                }
                return objCacheClassify_List_TS;
            }
        }

        public CacheClassify thisCacheClassify_ExportExcel_TS
        {
            get
            {
                if (PrjTabEx_ExcelExportRegion == null) return null;
                if (objCacheClassify_ExportExcel_TS == null)
                {
                    CacheClassify obj = new CacheClassify();

                    obj.FldId = PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS.FldId : "";
                    obj.FldId2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS.FldId : "";
                    obj.FldName = PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS.FldName : "";
                    obj.FldName2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS.FldName : "";
                    obj.PriVarName = PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.PriVarName2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.TypeScriptType = PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.TypeScriptType2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.CsType = PrjTabEx_ExcelExportRegion.objCacheClassifyFld != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "";
                    obj.CsType2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2 != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld2.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "";
                    obj.DataTypeId = PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.DataTypeId2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.FldLength = PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.FldLength2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.IsHasCacheClassfyFld = PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS == null ? false : true;
                    obj.IsHasCacheClassfyFld2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS == null ? false : true;
                    obj.IsNumberType = PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld_TS.IsNumberType() : false;
                    obj.IsNumberType2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld2_TS.IsNumberType() : false;

                    objCacheClassify_ExportExcel_TS = obj;
                }
                return objCacheClassify_ExportExcel_TS;
            }
        }

        public CacheClassify4View thisCacheClassify4View
        {
            get
            {
                if (myCacheClassify4View != null) return myCacheClassify4View;
                try
                {
                    CacheClassify4View obj = new CacheClassify4View();

                    obj.FldId = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.FldId : "";
                    obj.FldId2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.FldId : "";
                    obj.FldName = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.FldName : "";
                    obj.FldName2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.FldName : "";
                    obj.VarDef4Fld = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? string.Format("{0}.{1}Cache", ThisClsName, objViewInfoENEx.objCacheClassifyFld4View_TS.FldName) : "";
                    obj.VarDef4Fld2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? string.Format("{0}.{1}Cache", ThisClsName, objViewInfoENEx.objCacheClassifyFld4View2_TS.FldName) : "";

                    obj.PriVarName = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.PriVarName2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.TypeScriptType = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.TypeScriptType2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.DataTypeId = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.DataTypeId2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.FldLength = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.FldLength2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.IsHasCacheClassfyFld = objViewInfoENEx.objCacheClassifyFld4View_TS == null ? false : true;
                    obj.IsHasCacheClassfyFld2 = objViewInfoENEx.objCacheClassifyFld4View2_TS == null ? false : true;
                    obj.IsNumberType = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.IsNumberType() : false;
                    obj.IsNumberType2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.IsNumberType() : false;
                    obj.IsForExtendClass = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.IsForExtendClass : false;
                    obj.IsForExtendClass2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.IsForExtendClass : false;
                    obj.ViewVarName = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? clsViewIdGCVariableRelaBLEx.GetViewVarName(obj.IsHasCacheClassfyFld,
                        objViewInfoENEx.ViewId, obj.FldId, objViewInfoENEx.PrjId) : "";
                    obj.ViewVarName2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? clsViewIdGCVariableRelaBLEx.GetViewVarName(obj.IsHasCacheClassfyFld2,
                                            objViewInfoENEx.ViewId, obj.FldId2, objViewInfoENEx.PrjId) : "";

                    myCacheClassify4View = obj;
                    return myCacheClassify4View;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                    //return null;
                }

            }
        }

        //public clsPrjTabFldENEx thisCacheClassifyFld4View
        //{
        //    get
        //    {
        //        if (thisCacheClassify4View.IsHasCacheClassfyFld == true) return objViewInfoENEx.objCacheClassifyFld4View_TS;
        //        return null;
        //    }

        //}
        //public clsPrjTabFldENEx thisCacheClassifyFld4View2
        //{
        //    get
        //    {
        //        if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true) return objViewInfoENEx.objCacheClassifyFld4View2_TS;
        //        return null;
        //    }
        //}

        public clsPrjTabENEx PrjTabEx_ExcelExportRegion
        {
            get
            {
                if (objPrjTabEx_ExcelExportRegion != null) return objPrjTabEx_ExcelExportRegion;
                if (objViewInfoENEx.objViewRegion_ExportExcel != null)
                {
                    var objPrjTab_ExcelExportRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);
                    objPrjTabEx_ExcelExportRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ExcelExportRegion);
                    objPrjTabEx_ExcelExportRegion.GetObjAllInfoEx();
                }
                return objPrjTabEx_ExcelExportRegion;
            }
        }
        public clsPrjTabENEx PrjTabEx_ListRegion
        {
            get
            {
                if (objPrjTabEx_ListRegion != null) return objPrjTabEx_ListRegion;
                if (objViewInfoENEx.objViewRegion_List != null)
                {
                    var objPrjTab_ListRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);
                    objPrjTabEx_ListRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ListRegion);
                    objPrjTabEx_ListRegion.GetObjAllInfoEx();
                }
                return objPrjTabEx_ListRegion;
            }
        }


        public clsPrjTabENEx PrjTabEx_DetailRegion
        {
            get
            {
                if (objPrjTabEx_DetailRegion != null) return objPrjTabEx_DetailRegion;
                if (objViewInfoENEx.objViewRegion_Detail != null)
                {
                    var objPrjTab_DetailRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);
                    objPrjTabEx_DetailRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_DetailRegion);
                    objPrjTabEx_DetailRegion.GetObjAllInfoEx();
                }
                return objPrjTabEx_DetailRegion;
            }
        }

        public clsPrjTabENEx PrjTabEx_View
        {
            get
            {
                if (objPrjTabEx_View != null) return objPrjTabEx_View;
                if (objViewInfoENEx.MainTabId != null)
                {
                    var objPrjTab_View = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                    objPrjTabEx_View = clsPrjTabBLEx.CopyToEx(objPrjTab_View);
                    objPrjTabEx_View.GetObjAllInfoEx();
                }
                return objPrjTabEx_View;
            }
        }

        public clsPrjTabENEx PrjTabEx_EditRegion
        {
            get
            {
                if (objPrjTabEx_EditRegion != null) return objPrjTabEx_EditRegion;
                if (objViewInfoENEx.objViewRegion_Edit != null)
                {

                    var objPrjTab_EditRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);

                    objPrjTabEx_EditRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_EditRegion);
                    objPrjTabEx_EditRegion.GetObjAllInfoEx();
                }
                return objPrjTabEx_EditRegion;
            }
        }
        public string ThisClsName
        {
            get
            {
                return objViewInfoENEx.ClsName;
            }
        }
        public string ThisBaseClsName
        {
            get
            {
                string str = objViewInfoENEx.ClsName;

                if (str.EndsWith("Ex"))
                {
                    str = str.Substring(0, str.Length - 2);
                }
                return str;
            }
        }
        public string ThisClsName4EN
        {
            get
            {
                return string.Format("cls{0}EN", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4StoreEN
        {
            get
            {
                return string.Format("cls{0}", objPrjTabENEx.TabName);
            }
        }
        public string ThisObjName4Cond
        {
            get
            {
                return string.Format("obj{0}Cond", objPrjTabENEx.TabName);
            }
        }
        public string ThisObjName4EN
        {
            get
            {
                return string.Format("obj{0}EN", objPrjTabENEx.TabName);
            }
        }
        public string ThisTabName4GC
        {
            get
            {
                return string.Format("{0}", objPrjTabENEx.TabName);
            }
        }
        public string ThisTabId4GC
        {
            get
            {
                return string.Format("{0}", objPrjTabENEx.TabId);
            }
        }

        public string ThisClsName4ENEx
        {
            get
            {
                return string.Format("cls{0}ENEx", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4Bl
        {
            get
            {
                return string.Format("cls{0}BL", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4BlEx
        {
            get
            {
                return string.Format("cls{0}BLEx", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4DA
        {
            get
            {
                return string.Format("cls{0}DA", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4DAEx
        {
            get
            {
                return string.Format("cls{0}DAEx", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4WApi
        {
            get
            {
                return string.Format("cls{0}WApi", objPrjTabENEx.TabName);
            }
        }

        public string tabNameHead
        {
            get
            {
                if (strTabNameHead == null)
                {
                    strTabNameHead = string.Format("{0}_", this.objPrjTabENEx.TabName);
                }
                return strTabNameHead;

            }
        }

        public string tabNameHeadEx
        {
            get
            {
                if (strTabNameHeadEx == null)
                {
                    strTabNameHeadEx = string.Format("{0}Ex_", this.objPrjTabENEx.TabName);
                }
                return strTabNameHeadEx;

            }
        }


        public string controllerName
        {
            get
            {
                if (strControllerName == null)
                {
                    strControllerName = string.Format("{0}_Controller", clsString.FstLcaseS(objPrjTabENEx.TabName));
                }
                return strControllerName;

            }
        }

        public string controllerNameEx
        {
            get
            {
                if (strControllerNameEx == null)
                {
                    strControllerNameEx = string.Format("{0}ExController", clsString.FstLcaseS(objPrjTabENEx.TabName));
                }
                return strControllerNameEx;

            }
        }

        public string constructorName
        {
            get
            {
                if (strConstructorName == null)
                {
                    strConstructorName = string.Format("{0}_ConstructorName", clsString.FstLcaseS(objPrjTabENEx.TabName));
                }
                return strConstructorName;

            }
        }

        public string constructorNameEx
        {
            get
            {
                if (strConstructorNameEx == null)
                {
                    strConstructorNameEx = string.Format("{0}Ex_ConstructorName", clsString.FstLcaseS(objPrjTabENEx.TabName));
                }
                return strConstructorNameEx;

            }
        }



        public string ThisEditClsName
        {
            get
            {
                if (objViewInfoENEx.objViewRegion_Edit == null) return "";
                return objViewInfoENEx.objViewRegion_Edit.ClsName;
            }
        }
        public string ThisDetailClsName
        {
            get
            {
                return objViewInfoENEx.objViewRegion_Detail.ClsName;
            }
        }

        public string ThisListClsName
        {
            get
            {
                return objViewInfoENEx.objViewRegion_List.ClsName;
            }
        }

        public bool IsHasDetailRegion
        {
            get
            {
                clsViewRegionEN objViewRegion_Detail = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
                if (objViewRegion_Detail != null && objViewRegion_Detail.InUseInViewInfo(objViewInfoENEx) == true) return true;
                else return false;
            }
        }
        public bool IsHasListRegion
        {
            get
            {
                clsViewRegionEN objViewRegion_List = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
                if (objViewRegion_List != null && objViewRegion_List.InUseInViewInfo(objViewInfoENEx) == true) return true;
                else return false;
            }
        }
        public bool IsHasEditRegion
        {
            get
            {
                clsViewRegionEN objViewRegion_Edit = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
                if (objViewRegion_Edit != null && objViewRegion_Edit.InUseInViewInfo(objViewInfoENEx) == true) return true;
                else return false;
            }
        }
        public string TabName_Out4ExportExcel
        {
            get
            {
                if (strTabName_Out4ExportExcel == null)
                {
                    strTabName_Out4ExportExcel = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);

                }
                return strTabName_Out4ExportExcel;
            }
        }
        public string TabName_Out4ExportExcel4GC
        {
            get
            {
                if (strTabName_Out4ExportExcel4GC == null)
                {
                    strTabName_Out4ExportExcel4GC = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);

                }
                return strTabName_Out4ExportExcel4GC;
            }
        }
        public string TabId_Out4ExportExcel
        {
            get
            {
                if (strTabId_Out4ExportExcel == null)
                {
                    strTabId_Out4ExportExcel = objViewInfoENEx.objViewRegion_ExportExcel.TabId;
                }
                return strTabId_Out4ExportExcel;
            }
        }
        public string TabName_In4Edit4GC
        {
            get
            {
                if (objViewInfoENEx.objViewRegion_Edit == null) return "";
                if (strTabName_In4Edit4GC == null)
                {
                    strTabName_In4Edit4GC = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_In4Edit4GC;
            }
        }
        public string TabCnName_In4Edit4GC
        {
            get
            {
                if (objViewInfoENEx.objViewRegion_Edit == null) return "";
                if (strTabCnName_In4Edit4GC == null)
                {
                    strTabCnName_In4Edit4GC = clsPrjTabBLEx.GetTabCnNameByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);
                }
                return strTabCnName_In4Edit4GC;
            }
        }
        public string TabName_In4Edit
        {
            get
            {
                if (strTabName_In4Edit == null)
                {
                    strTabName_In4Edit = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_In4Edit;
            }
        }
        public string TabCnName_In4Edit
        {
            get
            {
                if (strTabCnName_In4Edit == null)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);

                    strTabCnName_In4Edit = objPrjTab.TabCnName;
                }
                return strTabCnName_In4Edit;
            }
        }
        public string TabId_In4Edit
        {
            get
            {
                if (strTabId_In4Edit == null)
                {
                    strTabId_In4Edit = objViewInfoENEx.objViewRegion_Edit.TabId;
                }
                return strTabId_In4Edit;
            }
        }
        public string ViewMainTabName4GC
        {
            get
            {
                if (strViewMainTabName4GC == null)
                {
                    strViewMainTabName4GC = objViewInfoENEx.TabName;
                }
                return strViewMainTabName4GC;
            }
        }

        public string ViewMainTabId4GC
        {
            get
            {
                if (strViewMainTabId4GC == null)
                {
                    strViewMainTabId4GC = objViewInfoENEx.MainTabId;
                }
                return strViewMainTabId4GC;
            }
        }

        public string TabName_Out4ListRegion
        {
            get
            {
                if (strTabName_Out4ListRegion == null)
                {
                    if (objViewInfoENEx.objViewRegion_List == null) return "";
                    strTabName_Out4ListRegion = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_Out4ListRegion;
            }
        }
        public string TabName_Out4ListRegion4GC
        {
            get
            {
                if (strTabName_Out4ListRegion4GC == null)
                {
                    if (objViewInfoENEx.objViewRegion_List == null) return "";
                    strTabName_Out4ListRegion4GC = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_Out4ListRegion4GC;
            }
        }
        public string TabId_Out4ListRegion
        {
            get
            {
                if (strTabId_Out4ListRegion == null)
                {
                    if (objViewInfoENEx.objViewRegion_List == null) return "";
                    strTabId_Out4ListRegion = objViewInfoENEx.objViewRegion_List.TabId;
                }
                return strTabId_Out4ListRegion;
            }
        }
        public string TabName_Out4DetailRegion4GC
        {
            get
            {
                if (strTabName_Out4DetailRegion4GC == null)
                {
                    strTabName_Out4DetailRegion4GC = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_Out4DetailRegion4GC;
            }
        }



        public bool IsUseFunc
        {
            get
            {
                bool bolIsUseFunc0 = false;
                if (strIsUseFunc == null)
                {
                    if (objViewInfoENEx.arrDGRegionFldSet != null && objViewInfoENEx.arrDGRegionFldSet.Where(x => x.IsUseFunc() == true).Count() > 0)
                    {
                        bolIsUseFunc0 = true;
                        strIsUseFunc = "true";
                    }
                    else
                    {
                        bolIsUseFunc0 = false;
                        strIsUseFunc = "false";
                    }
                }
                else
                {
                    bolIsUseFunc0 = bool.Parse(strIsUseFunc);
                }
                return bolIsUseFunc0;
            }
        }
        public bool IsUseFunc4ExcelExport
        {
            get
            {
                bool bolIsUseFunc4ExcelExport = false;
                if (strIsUseFunc4ExcelExport == null)
                {
                    if (objViewInfoENEx.arrExcelExportRegionFldSet == null)
                    {
                        bolIsUseFunc4ExcelExport = false;
                        strIsUseFunc4ExcelExport = "false";
                        return bolIsUseFunc4ExcelExport;
                    }
                    if (objViewInfoENEx.arrExcelExportRegionFldSet.Where(x => x.IsUseFunc() == true).Count() > 0)
                    {
                        bolIsUseFunc4ExcelExport = true;
                        strIsUseFunc4ExcelExport = "true";
                    }
                    else
                    {
                        bolIsUseFunc4ExcelExport = false;
                        strIsUseFunc4ExcelExport = "false";
                    }
                }
                else
                {
                    bolIsUseFunc4ExcelExport = bool.Parse(strIsUseFunc4ExcelExport);
                }
                return bolIsUseFunc4ExcelExport;
            }
        }


        public string TabName_Out4DetailRegion
        {
            get
            {
                if (strTabName_Out4DetailRegion == null)
                {
                    strTabName_Out4DetailRegion = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_Out4DetailRegion;
            }
        }
        public string TabId_Out4DetailRegion
        {
            get
            {
                if (strTabId_Out4DetailRegion == null)
                {
                    strTabId_Out4DetailRegion = objViewInfoENEx.objViewRegion_Detail.TabId;
                }
                return strTabId_Out4DetailRegion;
            }
        }


        /// <summary>
        /// �ؼ��ֶζ���
        /// </summary>
        protected clsPrjTabFldENEx objKeyField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objMainTabKeyField;
                }
                return mobjKeyField;
            }
            set
            {
                mobjKeyField = value;
            }
        }
        public string CmPrjId { get; set; }

        /// <summary>
        /// �ؼ��ֶε��ֶ���
        /// </summary>
        protected string FldName4Key
        {
            get
            {
                return objKeyField.FldName;
            }
        }
        private clsPrjTabFldENEx mobjOrderNumField = null;
        /// <summary>
        /// ����ֶζ���
        /// </summary>
        public clsPrjTabFldENEx objOrderNumField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objMainOrderNumField;
                }
                return mobjOrderNumField;
            }
            set => mobjOrderNumField = value;
        }
        private clsFieldTabENEx mobjSortField = null;
        /// <summary>
        /// Ĭ�������ֶζ���
        /// </summary>
        public clsFieldTabENEx objSortField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objSortField_Out;
                }
                return mobjSortField;
            }
            set => mobjSortField = value;
        }


        private clsPrjTabFldENEx mobjDelSignField = null;

        /// <summary>
        /// ɾ����־�ֶζ���
        /// </summary>
        public clsPrjTabFldENEx objDelSignField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objMainDelSignField;
                }
                return mobjDelSignField;
            }
            set => mobjDelSignField = value;
        }
        private clsPrjTabFldENEx mobjNameField = null;

        /// <summary>
        /// �����ֶζ���
        /// </summary>
        public clsPrjTabFldENEx objNameField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objMainNameField;
                }
                return mobjNameField;
            }
            set => mobjNameField = value;
        }


        public clsPrjTabEN objMainPrjTab
        {
            get
            {
                return objViewInfoENEx.objMainPrjTab;
            }
        }
        public clsPrjTabENEx objPrjTabENEx { get => mobjPrjTabENEx; set => mobjPrjTabENEx = value; }

        public clsFuncModule_AgcEN objFuncModuleEN { get => mobjFuncModuleEN; set => mobjFuncModuleEN = value; }
        public clsProjectsENEx objProjectsENEx
        {
            get
            {
                if (mobjProjectsENEx == null)
                {
                    if (objPrjTabENEx != null)
                    {
                        mobjProjectsENEx = objPrjTabENEx.objProjectsEN.CopyToEx();
                        return mobjProjectsENEx;
                    }
                    if (objViewInfoENEx != null)
                    {
                        mobjProjectsENEx = objViewInfoENEx.objProjectsEN.CopyToEx();
                        return mobjProjectsENEx;
                    }
                    return null;
                }
                else
                {
                    return mobjProjectsENEx;
                }
            }
            set => mobjProjectsENEx = value;
        }
        public clsPrjDataBaseEN objPrjDataBaseEN { get => mobjPrjDataBaseEN; set => mobjPrjDataBaseEN = value; }
        public clsWebSrvClassENEx objWebSrvClassENEx { get => mobjWebSrvClassENEx; set => mobjWebSrvClassENEx = value; }
        public string WebSrvClassId { get => mstrWebSrvClassId; set => mstrWebSrvClassId = value; }
        public string ClsName { get => mstrClsName; set => mstrClsName = value; }
        public string BaseClsName { get; set; }
        public string CurrUserName
        {
            set
            {
                if (mobjViewInfoENEx != null)
                {
                    mobjViewInfoENEx.CurrUserName = value;
                }
                if (mobjPrjTabENEx != null)
                {
                    mobjPrjTabENEx.UserId = value;
                }
            }

        }
        private clsPrjTabENEx mobjPrjTabENEx = null;


        private clsFuncModule_AgcEN mobjFuncModuleEN = null;

        private clsProjectsENEx mobjProjectsENEx = null;

        private clsPrjDataBaseEN mobjPrjDataBaseEN = null;

        private clsWebSrvClassENEx mobjWebSrvClassENEx = null;

        private clsViewInfoENEx mobjViewInfoENEx = null;


        private string mstrWebSrvClassId = "";
        //protected //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
        private string mstrClsName = "";
        //public string objPrjTabENEx.ClsName;
        protected string strClsNameEx;
        public string ClsNameEx;
        public string strTemp;
        protected string strDataBaseType = clsPubConst.con_MsSql;
        //protected bool objPrjTabENEx.IsHaveImageField;
        //protected string objPrjTabENEx.ImageFieldName;

        //protected string objPrjTabENEx.ClsFName; // '���ļ���
        //protected string objPrjTabENEx.FolderName; // '�ļ�Ŀ¼��

        //protected string objPrjTabENEx.FolderName_Root; // '���ļ�Ŀ¼��

        //public string FolderName_Root
        //{
        //    get { return objPrjTabENEx.FolderName_Root; }
        //    set { objPrjTabENEx.FolderName_Root = value; }
        //}
        //protected string objPrjTabENEx.BackupFolderName; // '�ļ�Ŀ¼��
        /// <summary>
        /// ���ݵ��ļ�Ŀ¼
        /// </summary>
        //public string BackupFolderName
        //{
        //    get { return objPrjTabENEx.BackupFolderName; }
        //    set { objPrjTabENEx.BackupFolderName = value; }
        //}
        //protected string objPrjTabENEx.SimpleFileName;
        ///// <summary>
        ///// ���ļ���,������Ŀ¼����
        ///// </summary>
        //public string SimpleFileName
        //{
        //    get { return objPrjTabENEx.SimpleFileName; }
        //    set { objPrjTabENEx.SimpleFileName = value; }
        //}

        //protected string objPrjTabENEx.FileName;

        #region ���캯��

        public clsGeneCodeBase()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            arrJsFunction = new List<JsFunction>();
            this.Re_objFunction4Code = new clsFunction4CodeEN();
            pubVarTypes = new List<PubVarType>();
        }
        public clsGeneCodeBase(string strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            arrJsFunction = new List<JsFunction>();
            this.Re_objFunction4Code = new clsFunction4CodeEN();
            pubVarTypes = new List<PubVarType>();
        }
        public clsGeneCodeBase(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        {
            arrJsFunction = new List<JsFunction>();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            if (string.IsNullOrEmpty(strTabId) == false)
            {
                GetPrjTabInfo(strTabId, strPrjDataBaseId, strPrjId);
            }
            else if (string.IsNullOrEmpty(strViewId) == false)
            {
                arrDdlKeyIdLst = new List<string>();
                GetPrjViewInfo(strViewId, strPrjDataBaseId, strPrjId);
                if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyFieldTS).Count() > 0)
                {
                    objViewInfoENEx.objCacheClassifyFld4View_TS = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyFieldTS).First();
                }
                if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField2TS).Count() > 0)
                {
                    objViewInfoENEx.objCacheClassifyFld4View2_TS = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField2TS).First();
                }

            }
            this.Re_objFunction4Code = new clsFunction4CodeEN();
            pubVarTypes = new List<PubVarType>();

        }

        public abstract string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code);


        public bool GetPrjTabInfo(string strTabId, string strPrjDataBaseId, string strPrjId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            this.objPrjTabENEx = new clsPrjTabENEx(strTabId);
            clsPrjTabBL.CopyTo(objPrjTabEN, this.objPrjTabENEx);
            //this.objPrjTabENEx = new clsPrjTabENEx(strTabId);
            mobjPrjTabENEx.GetObjAllInfoEx();

            this.objPrjTabENEx.PrjDataBaseId = strPrjDataBaseId;

            //clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            this.objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            if (this.objFuncModuleEN == null)
            {
                string strMsg = string.Format("��:[{0}({1})]��ģ��Ϊ��,��ά���ñ��ģ�顣({2})",
                    this.objPrjTabENEx.TabName, this.objPrjTabENEx.TabCnName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId);
            this.objProjectsENEx = new clsProjectsENEx();
            clsProjectsBL.CopyTo(objProjectsEN, objProjectsENEx);
            this.objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strFunctionTemplateId = clsPrjFuncTemplateRelaBLEx.getFunctionTemplateIdByPrjId(objPrjTabENEx.PrjId);
            //objPrjTabENEx.FunctionTemplateId = strFunctionTemplateId;
            this.mobjKeyField = objPrjTabENEx.objKeyField0;
            this.mobjNameField = objPrjTabENEx.objNameField;
            this.mobjOrderNumField = objPrjTabENEx.objOrderNumField;
            this.mobjDelSignField = objPrjTabENEx.objDelSignField;
            this.mobjSortField = objPrjTabENEx.objSortField;

            this.GetClsName();
            return true;
        }

        public bool GetPrjViewInfo(string strViewId, string strPrjDataBaseId, string strPrjId)
        {
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            try
            {
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, this.IsFstLcase, strPrjId);
            }
            catch (Exception objException)
            {
                throw objException;
            }
            this.objViewInfoENEx = objViewInfoENEx;

            if (string.IsNullOrEmpty(strPrjDataBaseId) == false)
            {
                objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
            }

            //objViewInfoENEx.LangType = ltLangType;
            //objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

            //this.mobjKeyField = objPrjTabENEx.objKeyField0;
            this.GetClsName();
            return true;
        }


        #endregion

        //public string FileName
        //{
        //    get
        //    {
        //        return objPrjTabENEx.FileName;
        //    }
        //    set
        //    {
        //        objPrjTabENEx.FileName = value;
        //    }
        //}
        //public bool IsHaveImageField
        //{
        //    get
        //    {
        //        return objPrjTabENEx.IsHaveImageField; // '�ļ�Ŀ¼��
        //    }
        //    set
        //    {
        //        objPrjTabENEx.IsHaveImageField = value;
        //    }
        //}

        //public string ImageFieldName
        //{
        //    get
        //    {
        //        return objPrjTabENEx.ImageFieldName; // '�ļ�Ŀ¼��
        //    }
        //    set
        //    {
        //        objPrjTabENEx.ImageFieldName = value;
        //    }
        //}

        //public string FolderName
        //{
        //    get
        //    {
        //        return objPrjTabENEx.FolderName; // '�ļ�Ŀ¼��
        //    }
        //    set
        //    {
        //        objPrjTabENEx.FolderName = value;
        //    }
        //}
        //public string GetCodeTabName(string strTabId)
        //{
        //    return clsPrjTabBL.GetTabNameByTabIdCache(strTabId);
        //}

        public virtual string GenSQLCode(string strPrjDataBaseId)
        {
            string strResult = "";
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
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

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;	//���ݿ�ӵ����
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;		//, strIsNullable0;		// = " null ";
            string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//�ֶγ���

            ArrayList arrFieldCodes = new ArrayList();

            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {

                ///�����ֶ���
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///�����ֶ�ע��(���ֶ���������)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + " **/";

                ///�����Ƿ�ɿ�

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///��������

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }
            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        public virtual string GenStoreProcedure_Add(string strPrjDataBaseId)
        {

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Add ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,

                    objField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);

                }
            }
            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            //��Ҫ�������ֶ��б�
            ArrayList arrFieldListForInsert = new ArrayList();
            //��Ҫ������ֵ�б�
            ArrayList arrValueListForInsert = new ArrayList();


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if ((objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY) && (objField.FieldTypeId == enumFieldType.KeyField_02))
                {
                    continue;
                }
                arrFieldListForInsert.Add(objField.ObjFieldTabENEx.FldName);
                arrValueListForInsert.Add("@" + objField.ObjFieldTabENEx.FldName);
            }

            //��֯�����¼SQL��
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);

            strCodeForCs.AppendFormat("\r\n" + "insert into {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "({0}) values ({1}) ;", strFieldListCode, strValuesListCode);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Add()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Add";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                objField.ObjFieldTabENEx.FldName,
                objField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                objField.ObjFieldTabENEx.FldLength);
            }
            //<Parameter name = "@Name" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@Sex" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@ClgId" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@MajorId" size = "4" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@UserType" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Update()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Update";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                objField.ObjFieldTabENEx.FldName,
                objField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                objField.ObjFieldTabENEx.FldLength);
            }

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Delete()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Delete";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Select()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Select";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_SelectOne()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectOne";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_IsExist()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_IsExist";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\n" + "<Parameter name = \"@IsExist\" size = \"1\" datatype = \"Char\" direction = \"spParamOutput\" isNullable = \"False\" />");

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectByCond";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectTop1ByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectTop1ByCond";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_Update(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Update ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
                {

                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);
                }
            }
            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "update {0} set ",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "{0} = @{0},", objField.ObjFieldTabENEx.FldName);
            }

            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public virtual string GenStoreProcedure_Delete(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Delete ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "delete from {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public virtual string GenStoreProcedure_Select(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Select ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            //if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            //{
            // strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
            // objKeyField.FldName,
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            // objKeyField.ObjFieldTabENEx.FldLength);
            //}
            //else
            //{
            // strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
            // objKeyField.FldName,
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            // objKeyField.ObjFieldTabENEx.FldLength);
            //}

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "Select * from {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "-- Where {0} = @{0};", objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectOne(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectOne ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "Select * from {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public virtual string GenStoreProcedure_IsExist(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "-- Run Example:");
            strCodeForCs.Append("\r\n" + "-- declare @Exist char(1)");
            strCodeForCs.Append("\r\n" + "-- exec Student_IsExist '1005', @Exist out");
            strCodeForCs.Append("\r\n" + "-- select @Exist;");

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_IsExist ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            strCodeForCs.Append("\r\n" + "@IsExist char(1) out");
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.AppendFormat("\r\n" + "if (Exists(select * from {1} Where {0} = @{0}))",
            objKeyField.FldName,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '1';");
            strCodeForCs.Append("\r\n" + "return 1;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '0'");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectByCond(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectByCond ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");

            strCodeForCs.Append("\r\n" + "declare @ret int, -- return value of sp call");
            strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select * from {0} ';",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectTop1ByCond(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectTop1ByCond ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");

            strCodeForCs.Append("\r\n" + "declare @ret int, -- return value of sp call");
            strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select Top 1 * from {0} ';",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenSQLCode4CreateTab(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
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

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;		//, strIsNullable0;		// = " null ";
            string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//�ֶγ���

            ArrayList arrFieldCodes = new ArrayList();

            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {

                ///�����ֶ���
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///�����ֶ�ע��(���ֶ���������)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + " **/";

                ///�����Ƿ�ɿ�

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///��������
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        public string AccessNull(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objDT.Rows[0][con{0}.{1}]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    strContent = string.Format("objDT.Rows[0][con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
            }
        }
        public string AccessNull_Static(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objRow[con{0}.{1}]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    if (objField.IsTabNullable == true && objField.IsNumberType() == true)
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        string strTemp = AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                        return string.Format("objRow[con{0}.{1}] == DBNull.Value ? ({3}?)null : {2}", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, strTemp, objField.ObjFieldTab().ObjDataTypeAbbr().CsType);
                    }
                    else if (objField.IsTabNullable == true && objField.CsType == "string")
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        string strTemp = AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                        return string.Format("objRow[con{0}.{1}] == DBNull.Value ? null : {2}", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, strTemp, objField.ObjFieldTab().ObjDataTypeAbbr().CsType);
                    }
                    else
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        return AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);

                    }
            }
        }
        public string AccessNull2(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objRow[con{0}.{1}]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    if (objField.IsTabNullable && objField.IsNumberType() == true)
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        string strTemp = AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                        return string.Format("objRow[con{0}.{1}] == DBNull.Value ? ({3}?)null : {2}", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, strTemp, objField.ObjFieldTab().ObjDataTypeAbbr().CsType);
                    }
                    else if (objField.IsTabNullable && objField.CsType == "string")
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        string strTemp = AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                        return string.Format("objRow[con{0}.{1}] == DBNull.Value ? null : {2}", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, strTemp, objField.ObjFieldTab().ObjDataTypeAbbr().CsType);
                    }
                    else
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                        return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                    }
            }
        }
        public string AccessNull4WS(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objRow[\"{1}\"]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull_Sub4WS(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    strContent = string.Format("objRow[\"{1}\"].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull_Sub4WS(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
            }
        }

        public string AccessNull_Sub4WS(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            switch (strPropType)
            {
                case "string":
                    return strContent;
                case "int":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToShort_S(" + strContent + ")";
                    }
                    else
                    {
                        return "short.Parse(" + strContent + ")";
                    }
                case "DateTime":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToDate_S(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToFloat_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Single.Parse(" + strContent + ")";
                    }
                case "Double":
                case "Money":
                case "double":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "bool":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToBool_S(" + strContent + ")";
                    }
                    else
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToBool_S(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":
                    return "(byte[])" + strContent;
                case "byte":
                    return "(byte)" + strContent;
                case "Int16":
                    if (bolIsNullable == true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull

        public string AccessNull(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            switch (strPropType)
            {
                case "string":
                    return strContent;
                case "int":
                    return "TransNullToInt(" + strContent + ")";
                case "short":
                    return "TransNullToShort(" + strContent + ")";
                case "DateTime":
                    return "TransNullToDate(" + strContent + ")";
                case "Single":
                case "float":
                    return "TransNullToFloat(" + strContent + ")";
                case "Double":
                case "Money":
                case "double":
                    return "TransNullToDouble(" + strContent + ")";
                case "bool":
                    return "TransNullToBool(" + strContent + ")";
                case "Decimal":
                    return "TransNullToDouble(" + strContent + ")";
                case "Long":
                case "long":
                    return "TransNullToInt(" + strContent + ")";
                case "Byte":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":
                    return "(byte[])" + strContent;
                case "byte":
                    return "(byte)" + strContent;
                case "Int16":

                    return "TransNullToInt(" + strContent + ")";

                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull


        public string AccessNull_Static(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            switch (strPropType)
            {
                case "string":
                    return strContent;
                case "int":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToShort_S(" + strContent + ")";
                    }
                    else
                    {
                        return "short.Parse(" + strContent + ")";
                    }
                case "DateTime":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToDate_S(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToFloat_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Single.Parse(" + strContent + ")";
                    }
                case "Double":
                case "Money":
                case "double":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "bool":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToBool_S(" + strContent + ")";
                    }
                    else
                    {
                        return "clsEntityBase2.TransNullToBool_S(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":
                    return "(byte[])" + strContent;
                case "byte":
                    return "(byte)" + strContent;
                case "Int16":
                    if (bolIsNullable == true)
                    {
                        return "clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull

        public string Mark(clsPrjTabFldENEx pobjField)
        {
            if (pobjField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                return "\"\'\"";
            }
            else
            {
                return "\"\"";
            }

        }


        //ƴװ�ؼ��ֵ�WHERE��
        public string KeyWhereStr()
        {
            bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.ObjFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                if (i == 0)	//�Ƿ��ǵ�һ��
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }

        //ƴװ�ؼ��ֵ�WHERE��
        public string KeyWhereStr(bool isNeed_m)
        {
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.ObjFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                ///'strTemp = objPrjTabENEx.arrKeyFldSet[i].ColumnName + " = \"" + Mark(objPrjTabENEx.arrKeyFldSet[i]) + "+ " + "m" + objField.ObjFieldTabENEx.PrivFuncName + Mark(objPrjTabENEx.arrKeyFldSet[i])
                if (i == 0)	//�Ƿ��ǵ�һ��
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }


        /// <summary>
        /// �ؼ��ָ�ֵ,���ڹ��캯���йؼ��ָ���ֵ
        /// </summary>
        /// <returns>��ֵ���ʽ��</returns>

        //ƴװ�ؼ��ֵĴ�ֵ������
        public string GetKeyPara()
        {
            string strPara, strTemp;
            int i = 0;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                if (objPrjTabENEx.LangType == clsPubConst.LangType.CSharp)
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.SilverLight)
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.JAVA)
                {
                    strTemp = objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift)
                {
                    strTemp = string.Format("{0} : {1}",
                         objField.ObjFieldTabENEx.PrivFuncName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift3)
                {
                    strTemp = string.Format("{0} : {1}",
                         objField.ObjFieldTabENEx.PrivFuncName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift4)
                {
                    strTemp = string.Format("{0} : {1}",
                         objField.ObjFieldTabENEx.PrivFuncName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.JavaScript)
                {
                    strTemp = objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else
                {
                    string strMsg = string.Format("�ں�����,û�д�����������:[{0}].({1})",
                       objPrjTabENEx.LangType,
                       clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (i == 0)		//�Ƿ��ǵ�һ��
                {
                    strPara += strTemp;
                }
                else
                {
                    strPara += " , " + strTemp;
                }
                i++;
            }
            return strPara;
        }

        /// <summary>
        /// ���˽�б���,���������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string GenClsPrivateVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���˽�б���,���������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string GenClsPrivateVar_Sim()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty_Sim(objPrjTabENEx.LangType, objField));
            }
            //ϵͳ�ֶ�_�޸��ֶμ��ϴ�
            clsPrjTabFldENEx objField1 = new clsPrjTabFldENEx();
            objField1.ObjFieldTabENEx.FldName = "sf_UpdFldSetStr";
            objField1.ObjFieldTabENEx.Caption = "ϵͳ�ֶ�_�޸��ֶμ��ϴ�";
            objField1.ObjFieldTabENEx.FldLength = 4;
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN().CopyToEx();
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.CsType = "string";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType = "String";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType = "String";

            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "str";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "str";
            strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty_Sim(objPrjTabENEx.LangType, objField1));

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����ֶ����Ƴ���,�������������Ƶ�����
        /// </summary>
        /// <returns></returns>
        public string GenPropertyNameConst()
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
        /// ����ֶ����Ƴ���,�������������Ƶ�����
        /// </summary>
        /// <returns></returns>
        public string GenPropertyNameConst4ConstLevel()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //���������������Ƴ���
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPropertyNameConst4ConstLevel(objPrjTabENEx.LangType, objField));
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string GenClsPropertyV2()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///����������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToStringV2(objField,this.IsFstLcase, objPrjTabENEx.LangType, objPrjTabENEx.TabName);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string GenClsProperty_Sim()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///����������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToString2(objField, objPrjTabENEx.LangType, true);
                strCodeForCs.Append("\r\n" + strTemp);
            }
            clsPrjTabFldENEx objField1 = new clsPrjTabFldENEx();
            objField1.ObjFieldTabENEx.FldName = "sf_UpdFldSetStr";
            objField1.ObjFieldTabENEx.Caption = "ϵͳ�ֶ�_�޸��ֶμ��ϴ�";
            objField1.ObjFieldTabENEx.FldLength = 4;
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN().CopyToEx();
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.CsType = "string";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType = "String";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType = "String";

            objField1.FldOpTypeId = "0001";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "str";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "str";
            strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.ToString2(objField1, objPrjTabENEx.LangType, true));

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public string GenClsIndexer()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\npublic static int AttributeCount");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nget");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn mintAttributeCount;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            //��������,�ַ�������
            strCodeForCs.Append("\r\npublic override object this[string strAttributeName]");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nget");
            strCodeForCs.Append("\r\n{");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strCodeForCs.AppendFormat("\r\nif (strAttributeName  ==  con{0}.{1})",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\nelse if (strAttributeName  ==  con{0}.{1})",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nset");
            strCodeForCs.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strCodeForCs.AppendFormat("\r\nif (strAttributeName  ==  con{0}.{1})",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n{0} = {1};", objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                    strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});", objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\nelse if (strAttributeName  ==  con{0}.{1})",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n{0} = {1};",
                        objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                        strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});", objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                    }
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");

            //��������,����(INT)��Ų���

            strCodeForCs.Append("\r\npublic object this[int intIndex]");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nget");
            strCodeForCs.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strCodeForCs.AppendFormat("\r\nif (con{0}.{1}  ==  AttributeName[intIndex])",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\nelse if (con{0}.{1}  ==  AttributeName[intIndex])",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nset");
            strCodeForCs.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strCodeForCs.AppendFormat("\r\nif (con{0}.{1}  ==  AttributeName[intIndex])",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n{0} = {1};",
                               objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                    strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\nelse if (con{0}.{1}  ==  AttributeName[intIndex])",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n{0} = {1};",
                              objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                        strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    }
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");

            return strCodeForCs.ToString();
        }

        public string GenConnectString()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�;
            strCodeForCs.Append("\r\n//�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�");
            strCodeForCs.Append("\r\nprivate static string m_strConnectString;");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ǰ��ʹ�õ����Ӵ�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.Append("\r\npublic static string ConnectString");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nget { return m_strConnectString; }");
            strCodeForCs.Append("\r\nset { m_strConnectString = value; }");
            strCodeForCs.Append("\r\n}");

            return strCodeForCs.ToString();
        }

        public string GenpErrNo()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///���Թ���;
            ///ÿ�����඼Ӧ���еĴ��������;
            strCodeForCs.Append("\r\npublic int ErrNo");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n return mintErrNo;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n set");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n mintErrNo = value;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenDispErrMsg()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///ÿ�����඼Ӧ���еĶ�����ʾ�Ĵ�����Ϣ;
            strCodeForCs.Append("\r\npublic string DispErrMsg //������ʾ�Ĵ�����Ϣ");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n return objPrjTabENEx.DispErrMsg;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n set");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objPrjTabENEx.DispErrMsg = value;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡ�ؼ���Id(keyId)
        /// </summary>
        /// <returns></returns>
        public string GenGetKeyId()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ��ȡ�ؼ���Id(keyId)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.Append("\r\n public override string _KeyId");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n  return {0};", objKeyField.ObjFieldTabENEx.PrivPropName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n  return {0}.ToString();", objKeyField.ObjFieldTabENEx.PrivPropName);
            }
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡ�����ֶ�ֵ(NameValue)
        /// </summary>
        /// <returns></returns>
        public string GenGetNameValue()
        {
            if (objPrjTabENEx.objPrjTabFld4NameFld == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ��ȡ�����ֶ�ֵ(NameValue)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.Append("\r\n public override string _NameValue");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n  return {0};", objPrjTabENEx.objPrjTabFld4NameFld.ObjFieldTabENEx.PrivPropName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ��������ʵ��㹹�캯��
        /// </summary>
        /// <returns></returns>
        public string GenCondEntityClassConstructor()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ����ʵ��㹹�캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n  dicFldComparisonOp = new Dictionary<string, string>();");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ���ɹ��캯��1
        /// </summary>
        /// <returns></returns>
        public string GenClassConstructor1()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.Append("\r\n mbolIsCheckProperty = false;");
            //strCodeForCs.AppendFormat("\r\n _CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ���ɹ��캯��2
        /// </summary>
        /// <returns></returns>
        public string GenClassConstructor2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivFuncName,
                objKeyField.ColCaption);
            strCodeForCs.Append("\r\npublic " + objPrjTabENEx.ClsName + "(" + GetKeyPara() + ")");
            strCodeForCs.Append("\r\n {");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":
                    strCodeForCs.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                              objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length > {1})", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"�ڱ�:{0}��,�ؼ��ֳ��Ȳ���ȷ!\");", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!\");", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "throw new Exception(string.Format(\"�ڹؼ����к���{" + "0" + "},����!\", objException.Message));");
                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);

                    break;
                case "bool":
                    break;
                case "int":
                case "short":
                case "Int16":
                case "Int32":
                case "long":
                    strCodeForCs.AppendFormat("\r\n if ({0}  ==  0)", objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n {");
                    strCodeForCs.Append("\r\n throw new Exception(\"�ؼ��ֲ���Ϊ0!\");");
                    strCodeForCs.Append("\r\n }");
                    break;
                case "float":
                case "double":
                    break;
                default:
                    break;
            }

            strCodeForCs.Append("\r\n" + GetKeyAssign());
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.Append("\r\n mbolIsCheckProperty = false;");
            //strCodeForCs.AppendFormat("\r\n _CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor3()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2})",
            objPrjTabENEx.ClsName, GetKeyPara(), objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":

                    strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);

                    break;
                case "bool":
                    break;
                case "int":
                case "short":
                case "Int16":
                case "Int32":
                case "long":
                    strCodeForCs.AppendFormat("\r\n if ({0}  ==  0)", objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n {");
                    strCodeForCs.Append("\r\n throw new Exception(\"�ؼ��ֲ���Ϊ0!\");");
                    strCodeForCs.Append("\r\n }");
                    break;
                case "float":
                case "double":
                    break;
                default:
                    break;
            }
            strCodeForCs.AppendFormat("\r\n{0}", GetKeyAssign() + ";");
            strCodeForCs.Append("\r\nSetInit();");
            strCodeForCs.Append("\r\n mbolIsCheckProperty = false;");
            strCodeForCs.AppendFormat("\r\nif (bolIsGet{0} == true)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nGet{0}();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            // strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructorEx1()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n public " + ClsNameEx + "()" + ": base()");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructorEx2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\npublic " + ClsNameEx + "(" + GetKeyPara() + ")" + ": base(" + objKeyField.PrivFuncName + ")");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructorEx3()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2}) : base({3},bolIsGet{2})",
            ClsNameEx, GetKeyPara(), objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }

        public string GenSetInit()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���������Щ���Գ�ʼֵ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\nprivate void SetInit()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nmstrModuleName = this.GetType().ToString();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strCodeForCs.AppendFormat("\r\n {0} = System.DateTime.Parse(\"01/01/1900\");	",
                        strPrivPropNameWithObjectName4Get);
                }
            }
            strCodeForCs.Append("\r\n}");
            ///�๹���� ==  ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string Gen_GetSpecSQLObj()
        {
            return "";

        }

        public virtual string Gen_GetSpecSQLObj_Obj()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strCodeForCs.Append("\r\n public override clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            //strCodeForCs.Append("\r\n //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�");
            //strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            //strCodeForCs.Append("\r\n {");
            //strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            //strCodeForCs.Append("\r\n return objSQL;");
            //strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strCodeForCs.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}EN._ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n");
            ///ɾ����¼ == = ;
            return strCodeForCs.ToString();
        }


        public virtual string Gen_GetSpecSQLObjV5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strCodeForCs.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");

            strCodeForCs.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strCodeForCs.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objSQL;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///ɾ����¼ == = ;
            return strCodeForCs.ToString();
        }
        public virtual string Gen_GetSpecSQLObj_ObjV5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strCodeForCs.Append("\r\n public clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n if (clsSysPara.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //3. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n //4. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strCodeForCs.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n");
            ///ɾ����¼ == = ;
            return strCodeForCs.ToString();
        }


        public virtual string Gen_GetSpecSQLObj5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strCodeForCs.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");

            strCodeForCs.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n if (clsSysPara.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strCodeForCs.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objSQL;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///ɾ����¼ == = ;
            return strCodeForCs.ToString();
        }
        public virtual string Gen_GetSpecSQLObj_Obj5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strCodeForCs.Append("\r\n public clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n if (clsSysPara.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //3. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strCodeForCs.Append("\r\n //4. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strCodeForCs.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n");
            ///ɾ����¼ == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenDelRecordWithTransactionBak()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///ɾ����¼------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:��ǰ������ָ�ļ�¼.(��������)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strCodeForCs.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?��</returns>");

            strCodeForCs.Append("\r\npublic bool DelRecord(SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL = \"\";");
            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strCodeForCs.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //											 strCodeForCs.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strCodeForCs.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            strCodeForCs.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strCodeForCs.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///ɾ����¼ == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenDelRecordWithTransaction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///ɾ����¼------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:ɾ���ؼ�����ָ�ļ�¼,ʹ������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strCodeForCs.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?��</returns>");
            strCodeForCs.AppendFormat("\r\npublic bool DelRecord({0}, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.KeyVarDefineLstStr);
            strCodeForCs.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\nstring strSQL = \"\";");
            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strCodeForCs.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //											 strCodeForCs.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strCodeForCs.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            strCodeForCs.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strCodeForCs.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///ɾ����¼ == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenDelMultiRec()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///ɾ��һЩ��¼------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:ͬʱɾ��������¼,ɾ�������ؼ����б�ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"lstKey\">�����Ĺؼ���ֵ�б�</param>");
                strCodeForCs.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?</returns>");
                strTemp = string.Format("public int DelRecKeyLsts(List<string> arrKeyLsts)",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + strTemp);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"lstKey\">�����Ĺؼ���ֵ�б�</param>");
                strCodeForCs.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?</returns>");
                strTemp = string.Format("public int Del{0}(List<string> lstKey)",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + strTemp);
            }
            strCodeForCs.Append("\r\n{");


            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {

                strCodeForCs.Append("\r\nif (arrKeyLsts.Count  == 0) return 0;");

                strCodeForCs.Append("\r\n" + "int intCount = 0;");
                strCodeForCs.Append("\r\nforeach (var strKeyLst in arrKeyLsts)");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\n" + "string[] sstrKey = strKeyLst.Split('|');");
                int intIndex = 0;
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType())
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(sstrKey[{2}]);", objInFor.CsType, objInFor.PrivFuncName, intIndex);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = sstrKey[{2}];", objInFor.CsType, objInFor.PrivFuncName, intIndex);
                    }
                    intIndex++;
                }

                strCodeForCs.AppendFormat("\r\n int intRecNum  = this.DelRecord({0});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n intCount += intRecNum;");
                strCodeForCs.Append("\r\n}");
                strCodeForCs.Append("\r\n return intCount;");

            }
            else
            {
                strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
                strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
                strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\nstring strSQL;");
                strCodeForCs.Append("\r\nstring strKeyList;");
                strCodeForCs.Append("\r\nif (lstKey.Count  == 0) return 0;");
                strCodeForCs.Append("\r\nstrKeyList = \"\";");
                strCodeForCs.Append("\r\nfor (int i = 0; i<lstKey.Count; i++)");
                strCodeForCs.Append("\r\n{");
                ///				if ( (i == 0) strKeyList +=  "'" + lstKey[i].ToString() + "'";
                ///				else strKeyList +=  ", " + "'" + lstKey[i].ToString() + "'";
                if (objPrjTabENEx.arrKeyFldSet.Count == 0)
                {
                    strCodeForCs.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ���,��������һ���ؼ���!");
                }
                else
                {
                    strCodeForCs.Append("\r\nif (i == 0) strKeyList = strKeyList + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                    strCodeForCs.Append("\r\nelse strKeyList +=  \",\" + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                    strCodeForCs.Append("\r\n}");
                }
                strCodeForCs.Append("\r\nstrSQL = \"\";");

                strCodeForCs.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
                if (objPrjTabENEx.arrKeyFldSet.Count == 0)
                {
                    strCodeForCs.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ���,��������һ���ؼ���!");
                    strCodeForCs.Append("\r\nreturn false;");
                }
                else
                {
                    strCodeForCs.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + objKeyField.FldName + " in (\" + strKeyList + \")\";");
                    strCodeForCs.Append("\r\nreturn objSQL.ExecSql2(strSQL);");
                }
            }
            strCodeForCs.Append("\r\n}");
            ///ɾ��һЩ��¼ == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenDelRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strCodeForCs.Append("\r\n" + string.Format("public int DelRecord({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strCodeForCs.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strCodeForCs.Append("\r\n//ɾ��������¼");
            strCodeForCs.Append("\r\nstring strSQL = \"\";");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab !=  \")
            //			{
            //				strCodeForCs.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //				strCodeForCs.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            strTemp = string.Format("//ɾ��{0}�������뵱ǰ�����йصļ�¼",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + strTemp);
            strCodeForCs.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strCodeForCs.Append("\r\n return objSQL.ExecSql2(strSQL);");
            strCodeForCs.Append("\r\n}");
            ///ɾ��һ����¼ == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenDelCondRec()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///ɾ��������¼,ɾ���������ļ�¼------------------;
            strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:ɾ�����������Ķ�����¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">��Ҫɾ���ļ�¼����</param>");
            strCodeForCs.Append("\r\n /// <returns>����ɾ���ļ�¼����</returns>");
            strCodeForCs.AppendFormat("\r\npublic int Del{0}(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = "Del{0}";//, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: Del{0})\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstring strSQL;");
            strCodeForCs.Append("\r\nif (strCondition  ==  \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn 0;	//��ʾɾ��0����¼,ʵ�����ǲ��ܸñ�����м�¼");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nint intRecoCount = objSQL.ExecSql2(strSQL);");
            strCodeForCs.Append("\r\nreturn intRecoCount;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///ɾ��������¼,ɾ���������ļ�¼ == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenDelCondRecWithTransaction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///ɾ��������¼,ɾ���������ļ�¼------------------;
            strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:ɾ�����������Ķ�����¼,ͬʱ��������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">��Ҫɾ���ļ�¼����</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ�ɾ���ɹ���</returns>");
            strCodeForCs.AppendFormat("\r\npublic bool Del{0}WithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = "Del{0}WithTransaction_S";//, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: Del{0}WithTransaction_S)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstring strSQL;");
            strCodeForCs.Append("\r\nif (strCondition  ==  \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;	//��ʾɾ��0����¼,ʵ�����ǲ��ܸñ�����м�¼");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);");
            strCodeForCs.Append("\r\nreturn bolResult;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///ɾ��������¼,ɾ���������ļ�¼ == = ;
            return strCodeForCs.ToString();
        }





        public virtual string GenGetRecValueBySP()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.�ô洢����{0}_SelectOne����ȡ��", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ����ݿ��еĶ���</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strCodeForCs.AppendFormat("\r\npublic bool Get{0}OneBySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");

            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n " + clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
            strCodeForCs.Append("\r\n};");


            strCodeForCs.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectOne\",values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n {4} = {5}; //{0}(�ֶ�����:{1},�ֶγ���:{2},�Ƿ�ɿ�:{3})",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objField.ObjFieldTabENEx.FldLength,
                        objField.ObjFieldTabENEx.IsNull,
                         strPrivPropNameWithObjectName,
                          AccessNull(objField));
                }
            }

            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable GetDataTable_{0}(string strCondition)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strFunctionName = "GetDataTable_{0}";//, objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�����������к���{0},����!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_{0})\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByTabName_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(��������)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, string strTabName)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!(��������)";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataTable_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByTabName_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, string strTabName, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTable_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByTabName_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string Gen_GetDataTable_Top_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ������¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objTopPara\">��ȡ���������б�Ĳ�������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");


            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ������¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)");
            strCodeForCs.Append("\r\n{");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable_Top", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_Top)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} order by {{2}}\", intTopSize, strCondition, strOrderBy);",
       objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataTableByPager_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ҳ��¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByPager", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڷ�ҳ��ѯ�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�ڷ�ҳ��ѯ�����������к���{{0}},����!({1}: GetDataTableByPager)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append(this.GeneSqlStrByPaper());

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string Gen_GetDataTable_Top_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ������¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_Top)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
         objPrjTabENEx.TabName, "{", "}");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string Gen_GetDataTable_Top_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ������¼���ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable_Top(string strCondition, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_Top)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
         objPrjTabENEx.TabName, "{", "}");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");



            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GeneSqlStrByPaper()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n int intTop_In = intPageSize * (intPageIndex - 1);//��ȡ���Ӷ���");

            strCodeForCs.Append("\r\n" + "int intPos_Dot = strOrderBy.IndexOf('|');");
            strCodeForCs.Append("\r\n" + "if (intPos_Dot > 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var IsAscOrDesc = \"Asc\";");
            strCodeForCs.Append("\r\n" + "if (strOrderBy.IndexOf(\" Asc\", StringComparison.InvariantCultureIgnoreCase) > 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strOrderBy = strOrderBy.Replace(\" Asc\", \"\");");
            strCodeForCs.Append("\r\n" + "IsAscOrDesc = \"Asc\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strOrderBy.IndexOf(\" Desc\", StringComparison.InvariantCultureIgnoreCase) > 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strOrderBy = strOrderBy.Replace(\" Desc\", \"\");");
            strCodeForCs.Append("\r\n" + "IsAscOrDesc = \"Desc\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "var arrPart = strOrderBy.Split('|');");
            strCodeForCs.Append("\r\n" + "if (arrPart.Length != 3)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw new Exception(string.Format(\"�ڴ������������ҳ��ѯ��,strOrderBy:[{0}]Ӧ��������(|)�ָ���3�������,����!(in {1})\",");
            strCodeForCs.Append("\r\n" + "strOrderBy, clsStackTrace.GetCurrClassFunction()));");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "string strTabName = arrPart[0];");
            strCodeForCs.Append("\r\n" + "string strNewOrderBy = arrPart[1];");
            strCodeForCs.Append("\r\n" + "string strOnCondition = arrPart[2];");
            strCodeForCs.AppendFormat("\r\n" + "strSQL = string.Format(\"Select Top {{0}} {0}.* from {0} Left Join {{1}} on {{2}} where {{3}} and {0}.{1} not in (Select top {{5}} {0}.{1} from {0} Left Join {{1}} on {{2}} where {{3}} order by {{4}} {{6}}) order by {{4}} {{6}} \",",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strSQL);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "catch (Exception objEx)");
            //strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {1} not in (Select top {{2}} {1} from {0} where {{1}}) \", intPageSize, strCondition, intTop_In);",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            //   strSQL = string.Format("Select Top {0} * from {0} where {1} and {0}Id not in (Select top {3} {0}Id from {0} where {1} order by {2}) order by {2}", intPageSize, strCondition, strOrderBy, intTop_In);
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {1} not in (Select top {{3}} {1} from {0} where {{1}} order by {{2}}) order by {{2}} \", intPageSize, strCondition, strOrderBy, intTop_In);",
           objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataTableByPager_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ҳ��¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڷ�ҳ��ѯ�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�ڷ�ҳ��ѯ�����������к���{{0}},����!({1}: GetDataTableByPager)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append(this.GeneSqlStrByPaper());

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByPager_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ҳ��¼���ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڷ�ҳ��ѯ�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�ڷ�ҳ��ѯ�����������к���{{0}},����!({1}: GetDataTableByPager)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append(this.GeneSqlStrByPaper());

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRange_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRange_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRange_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataTableByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRangeV_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ����ͼ(View)��һ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableVByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableVByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableVByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRangeV_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ����ͼ(View)��һ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");



            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRangeV_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ����ͼ(View)��һ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                 "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");



            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableBySP_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����, �ô洢��������ȡ��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByCondBySP(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataTableByCondBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableByCondBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetCondRecDataSetBySP_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ������ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����, �ô洢��������ȡ��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݱ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByCondBySP(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByCondBySP(string strCondition)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");


            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetByCondBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondBySP_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ������ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����,�ô洢��������ȡ��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByCondBySP(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByCondBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetByCondBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCond_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ������ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSet(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSet(string strCondition)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSet)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n strSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n return objDS;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetTopDataSetByCond_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ��Ķ������ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSet_Top(int intTopSize, string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSet_Top(string strCondition)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSet_Top)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
            objPrjTabENEx.TabName, "{", "}");

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n return objDS;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataSetByCondByRange_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡһ����Χ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                       objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSet)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                   objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataSet��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strCodeForCs.Append("\r\n /// <returns>������������һ����Χ��DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSet)ByRange\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");



            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\n System.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
               "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                       objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");



            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataSetByCond_V_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ����ͼ�����ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetV(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetV", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetV)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n strSQL = \"Select * from v" + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"v{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n return objDS;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataSetByCondByRange_V_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ����ͼ��һ����Χ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetVByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetVByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                   objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_V_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ����ͼ��һ����Χ�����ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                       objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_V_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ����ͼ��һ����Χ�����ݼ�,��DataSet��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
               "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {0}3{1} And {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
           objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n return objDS;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
            strCodeForCs.AppendFormat("\r\npublic List<cls{0}EN> GetObjLst(string strCondition)",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLst", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetObjLst)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"�ڸ���������ȡ�����б�ʱ,����:{{0}},����!({1}: GetObjLst)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");


            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetObjLstByTabName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
            strCodeForCs.AppendFormat("\r\npublic List<cls{0}EN> GetObjLstByTabName(string strCondition, string strTabName)",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLstByTabName", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetObjLstByTabName)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"�ڸ���������ȡ�����б�ʱ,����:{{0}},����!({1}: GetObjLst)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");


            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// Ϊ�ֶ����������ֶ�ֵ
        /// </summary>
        /// <returns></returns>
        public virtual string GenSetCondFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// ����������ȡ�����б�-{0}[{1}]", objField.ObjFieldTabENEx.FldCnName, objField.ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"strCondValue\">�ֶ�����ֵ</param>");
                strCodeForCs.Append("\r\n /// <param name = \"strComparisonOp\">�Ƚ������</param>");
                strCodeForCs.Append("\r\n /// <returns>void</returns>");
                strCodeForCs.AppendFormat("\r\npublic void SetCond_{0}(string strCondValue, string strComparisonOp)",
                    objKeyField.FldName,
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n" + "this.{0} = strCondValue;",
                    objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "if (dicFldComparisonOp.ContainsKey(con{0}) == false)",
                    objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "dicFldComparisonOp.Add(con{0}, strComparisonOp);",
                    objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "dicFldComparisonOp[con{0}] = strComparisonOp;",
                    objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n}");

            }

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenCopyObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
            }
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenCopyObj5()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.AppendFormat("\r\npublic void CopyTo(cls{0} obj{0})", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = {2}; //{3}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
            }
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }
        public string GenCopyObj_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenCopyObjToSimObj_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������(��)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyObjToSimObj(cls{0}EN obj{0}ENS, cls{0}EN_Sim obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sf_UpdFldSetStr = obj{0}ENS.getsfUpdFldSetStr(); //sf_UpdFldSetStr",
                objPrjTabENEx.TabName);
            }
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenCopyObjFromSimObj_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyObjFromSimObj(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public string GenCopyObjFromSimObj4Upd_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����. ר������޸ļ�¼,�����ֶβŸ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyObjFromSimObj4Upd(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n   string strsfUpdFldSetStr = obj{0}ENS.sf_UpdFldSetStr;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');");
            strCodeForCs.Append("\r\n   List<string> arrFldSet = new List<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (arrFldSet.Contains(con{0}.{1}, new clsStrCompareIgnoreCase())  ==  true)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strCodeForCs.Append("\r\n" + "}");

                }
            }
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }


        public string GenCopyObj_S5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}S\">Դ����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}T\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyTo(cls{0} obj{0}S, cls{0} obj{0}T)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}T.{1} = obj{0}S.{1}; //{3}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
            }
            strCodeForCs.Append("\r\n}");
            ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetObjLstBySP()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ�����б�,ʹ�ô洢����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
            strCodeForCs.AppendFormat("\r\npublic List<cls{0}EN> GetObjLstBySP(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLstBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetObjLstBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                   objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"����������ȡ�����б�ʱ,����:{{0}},����!({1}: GetObjLstBySP)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");


            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenGetRecValueObjByDataRow()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ��DataRowת���ɼ�¼����.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"objRow\">������DataRow</param>");
            strCodeForCs.AppendFormat("\r\n /// <returns>��¼����</returns>");

            strCodeForCs.AppendFormat("\r\npublic cls{0}EN GetObjByDataRow(DataRow objRow)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (objRow  ==  null)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[con{0}.{1}] as byte[]; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        //strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[con{0}.{1}] as byte[]; //{2}",
                        // objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"��DataRowת���ɼ�¼����ʱ,����:{{0}},����!({1}: GetObjByDataRow{0})\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ��DataRowViewת���ɼ�¼����.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"objRow\">������DataRowView</param>");
            strCodeForCs.AppendFormat("\r\n /// <returns>��¼����</returns>");

            strCodeForCs.AppendFormat("\r\npublic cls{0}EN GetObjByDataRow(DataRowView objRow)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (objRow  ==  null)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[con{0}.{1}] as byte[]; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        //strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[con{0}.{1}] as byte[]; //{2}",
                        // objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"��DataRowViewת���ɼ�¼����ʱ,����:{{0}},����!({1}: GetObjByDataRow)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetFirstCondRecObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��һ�����������ļ�¼,�Զ�����ʽ��ʾ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������������ĵ�һ������</returns>");
            strCodeForCs.AppendFormat("\r\npublic cls{0}EN GetFirstObj(string strCondition)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetFirstObj", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetFirstObj)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append(Gen_4BL_GC_GetObjFromDataRow());
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"�ڸ���������ȡ��һ������ʱ,����:{{0}},����!({1}: GetFirstObj)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetFirstCondRecObjBySP()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��һ�����������ļ�¼,�Զ�����ʽ��ʾ,�ô洢��������ȡ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strCodeForCs.Append("\r\n /// <returns>�������������ĵ�һ������</returns>");
            strCodeForCs.AppendFormat("\r\npublic cls{0}EN GetFirstObjBySP(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetFirstObjBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetFirstObjBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);

            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectTop1ByCond\",values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strCodeForCs.Append(Gen_4BL_GC_GetObjFromDataRow());

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableT_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///��ȡĳһ������DataTable,���еĴ���ת������Ӧ������------------------------;
            if (objPrjTabENEx.IsNeedTransCode)
            {
                strCodeForCs = new StringBuilder();
                strCodeForCs.Append("\r\n");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����:��ȡĳһ������DataTable,���еĴ���ת������Ӧ������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
                strCodeForCs.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
                strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable Get{0}T(string strCondition)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\ntry");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
                strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
                strCodeForCs.Append("\r\n}");
                strCodeForCs.Append("\r\ncatch (Exception objException)");
                strCodeForCs.Append("\r\n{");

                string strFunctionName = string.Format("Get{0}T", objPrjTabENEx.TabName, objKeyField.FldName);
                string strExplanation = "�����������к���{0},����!";
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

                strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:Get{0}T)\", objException.Message));",
                            objPrjTabENEx.TabName,
                            objPrjTabENEx.ClsName,
                            "{", "}",
                            strErrId);
                strCodeForCs.Append("\r\n}");

                strCodeForCs.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
                strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

                strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
                strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
                strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\nstrSQL.Append(\"Select {0}.* \");", objPrjTabENEx.TabName);
                bool bolIsFirst;
                StringBuilder sbTabName = new StringBuilder();
                StringBuilder sbWhereStr = new StringBuilder();
                StringBuilder sbFldStr = new StringBuilder();
                StringBuilder sbLeftJoinStr = new StringBuilder();
                bool bolIsSelfLink = false;
                bolIsFirst = true;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.ObjFieldTab4CodeConv() != null)
                    {
                        if (objPrjTabENEx.TabId == objField.ObjFieldTab4CodeConv().CodeTabId)
                        {
                            bolIsSelfLink = true;
                        }
                        else
                        {
                            bolIsSelfLink = false;
                        }
                        if (bolIsFirst)
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" from {0}, {1}\");",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" where {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                            bolIsFirst = false;
                        }
                        else
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" , {0} \");",
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" && {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        if (bolIsSelfLink == true)
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}Self.{1} {2}{3} \");",
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} {2}Self on {0}.{1} = {2}Self.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        else
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}.{1} {2}{3} \");",
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} on {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabCode);
                        }
                    }
                }

                strCodeForCs.Append(sbFldStr.ToString());
                strCodeForCs.AppendFormat("\r\nstrSQL.Append(\" from {0} \");",
                objPrjTabENEx.TabName);
                strCodeForCs.Append(sbLeftJoinStr.ToString());
                /// strCodeForCs.Append(sbTabName.ToString());
                /// strCodeForCs.Append(sbWhereStr.ToString());
                strCodeForCs.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
                strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
                strCodeForCs.Append("\r\nreturn objDT;");
                strCodeForCs.Append("\r\n}");
                strCodeForCs.Append("\r\n");
            }
            ///��ȡĳһ������DataTable,���еĴ���ת������Ӧ������ == = ;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����ͼ(SQL View)�л�ȡ��Ϣ���� == >DataTable
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetDataTableV_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///��ȡĳһ��������ر���ͼ(View)------------------------;
            strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ�����ͼ(View)����,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
            strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable GetDataTableV(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataTableV", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableV)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);

            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ�����ͼ(View)����,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
            strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable GetDataTable_{0}V(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            strFunctionName = "GetDataTable_{0}V";//, objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�����������к���{0},����!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_{0}V)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);

            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ������DataTable,���еĴ���ת������Ӧ������ == = ;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����ͼ(SQL View)�л�ȡ��Ϣ���� == >DataTable
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetDataTableV_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ǰ�����ͼ(View)����,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
            strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable GetDataTableV(string strCondition, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableV(string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetDataTableV)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\n");
            ///��ȡĳһ������DataTable,���еĴ���ת������Ӧ������ == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetPrimaryKeyID_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///��ȡĳһ�����Ĺؼ����б�-----------------------------------------;
            strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:��ȡĳһ�����Ĺؼ����б�");
            strCodeForCs.Append("\r\n ///		 �����ؼ����Ƕ��,�����ؼ���֮����\"//\"����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�ؼ����б�</returns>");
            strCodeForCs.Append("\r\npublic static List<string> GetPrimaryKeyID(string strCondition) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT ;");
            strCodeForCs.Append("\r\nList<string> arrList = new List<string>();");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\nint iRow, iCol; ");
            strCodeForCs.Append("\r\nstring strKeyValue; ");
            strCodeForCs.AppendFormat("\r\nstrSQL = \"Select {0} from {1} where \" + strCondition;",
            objKeyField.FldName, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n//				clsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n//				objDT = null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfor (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue = \"\";");
            strCodeForCs.Append("\r\nfor (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (iCol  ==  0)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue +=  objDT.Rows[iRow][iCol].ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue +=  \"//\" + objDT.Rows[iRow][iCol].ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\narrList.Add(strKeyValue);");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nreturn arrList;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///��ȡĳһ�����Ĺؼ����б� ==  ==  ==  ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetFileFromTabField()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///�ϴ��ļ��Լ������ļ���ش���------------------------------------ ;
            if (objPrjTabENEx.IsHaveImageField == true)
            {
                strCodeForCs = new StringBuilder();
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����:�����ݿ���ֶ��л�ȡ����,���Ҵ�����ļ��С�");
                strCodeForCs.Append("\r\n ///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">��ȡ���ݺ�,�����˵��ļ�����</param>");
                strCodeForCs.Append("\r\n /// <returns>����ɹ���ȡ�ͷ���TRUE,����ΪFALSE</returns>");
                strCodeForCs.Append("\r\npublic bool GetFileFromTabField(string strDownLoadFileName)");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\nSpecData.clsSpecSQLforSql objSQL = new SpecData.clsSpecSQLforSql();");
                strCodeForCs.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\nstring strFldName = \"{0}\";", objPrjTabENEx.ImageFieldName);
                strCodeForCs.Append("\r\nStringBuilder strCondition = new StringBuilder();");
                /// strCodeForCs.Append("\r\nstrCondition.AppendFormat(\"Stdid = '{0}'\", objPrjTabENEx.Stdid);");
                strCodeForCs.Append("\r\nstrCondition.AppendFormat(\" ");
                strCodeForCs.AppendFormat("{0}", objKeyField.FldName);
                strCodeForCs.Append(" = '{0}'\", ");
                strCodeForCs.AppendFormat("{0});", clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
                strCodeForCs.Append("\r\nobjSQL.GetFile(strDownLoadFileName,strTabName, strFldName, strCondition.ToString());");
                strCodeForCs.Append("\r\nreturn true;");
                strCodeForCs.Append("\r\n}");
            }
            return strCodeForCs.ToString();
        }

        public virtual string GenStoreFileToTabField()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:�洢�ļ������ļ��洢�����ݿ���ֶ��С�");
            strCodeForCs.Append("\r\n ///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strUpLoadFileName\">��Ҫ�洢���ļ���</param>");
            strCodeForCs.Append("\r\n /// <returns>����ɹ��ͷ���TRUE,���򷵻�FALSE</returns>");
            strCodeForCs.Append("\r\npublic bool StoreFileToTabField(string strUpLoadFileName)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strFldName = \"{0}\";", objPrjTabENEx.ImageFieldName);
            strCodeForCs.Append("\r\nStringBuilder strCondition = new StringBuilder();");
            strCodeForCs.Append("\r\nstrCondition.AppendFormat(\" ");
            strCodeForCs.AppendFormat("{0}", objKeyField.FldName);
            strCodeForCs.Append(" = '{0}'\", ");
            strCodeForCs.AppendFormat("{0});", clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
            strCodeForCs.Append("\r\nSpecData.clsSpecSQLforSql objSQL = new SpecData.clsSpecSQLforSql();");
            strCodeForCs.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.ToString());");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public virtual string GenShowPic_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:��ʾͼƬ����ʾ��ؼ�����ؼ�¼��ͼƬ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"imgPic\">��Ҫ��ʾͼƬ��image�ؼ�</param>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
            objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <param name = \"strWebFileDir\">����WEB��ʾ���ļ�·��,��URL</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strDownloadFileDir\">���������ļ�ʱ,��WEB���������ļ���Ŀ¼</param>");
            strCodeForCs.Append("\r\npublic static void ShowPic(System.Web.UI.WebControls.Image imgPic, ");
            strCodeForCs.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\nstring strWebFileDir, ");
            strCodeForCs.Append("\r\nstring strDownloadFileDir)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\nimgPic.ImageUrl = \"\";");
            strCodeForCs.AppendFormat("\r\nif (cls{0}BL.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\nobj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strFileName = obj{0}EN.FileName;",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (strFileName != \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strDownLoadFileName = strDownloadFileDir + strFileName;");
            strCodeForCs.AppendFormat("\r\nobj{0}EN.GetFileFromTabField(strDownLoadFileName);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nimgPic.ImageUrl = strWebFileDir + strFileName;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }
        public virtual string GenGetFileFromTabField_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:�����ݿ���ֶ��������ļ����ݡ��ú����Ǿ�̬(static)������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">�������ص��ļ���</param>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
            objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <param name = \"strDownloadFileDir\">���������ļ�ʱ,��WEB���������ļ���Ŀ¼</param>");
            strCodeForCs.Append("\r\npublic static bool GetFileFromTabField(ref string strDownLoadFileName, ");
            strCodeForCs.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\nstring strDownloadFileDir)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nif (cls{0}BL.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\nobj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strFileName = obj{0}EN.FileName;",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (strFileName != \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrDownLoadFileName = strDownloadFileDir + strFileName;");
            strCodeForCs.AppendFormat("\r\nobj{0}EN.GetFileFromTabField(strDownLoadFileName);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");

            ///�ϴ��ļ��Լ������ļ���ش��� ==  ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataTable_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///��ȡĳһSQL����DataTable---------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����Sql����ȡDataTable");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strSql\">Sql���</param>");
            strCodeForCs.Append("\r\n /// <returns>�������ڰ��������DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strSql)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSql);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            ///��ȡĳһSQL����DataTable ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenIsExist()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����-----------------------;
            strCodeForCs.Append("\r\npublic bool IsExist()");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr() + "))");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            ///�����ݿ����Ƿ���ڵ�ǰ���� ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenIsExistBySP()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����-----------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼, �ô洢��������ȡ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����?</returns>");
            strCodeForCs.AppendFormat("\r\npublic bool IsExistBySP({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strCodeForCs.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");

            strCodeForCs.Append("\r\n" + "string strIsExist = \"\";");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strCodeForCs.Append("\r\n" + objField.ObjFieldTabENEx.PrivFuncName + ",");
            }
            strCodeForCs.Append("\r\n" + "strIsExist");
            strCodeForCs.Append("\r\n};");

            strCodeForCs.AppendFormat("\r\n" + "ArrayList arrReturn = objSQL.ExecSpWithOutPut(\"{0}_IsExist\", values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "if (arrReturn[0].ToString()  ==  \"1\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            ///�����ݿ����Ƿ���ڵ�ǰ���� ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenIsExist_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����(������̺���)-----------------------;
            ///objField.ObjFieldTabENEx.PrivFuncName;
            int i = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {

                if (i == 0)	//�Ƿ��ǵ�һ��
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else
                {
                    strTemp += ", " + objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                i++;
            }
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����?</returns>");

            strCodeForCs.Append("\r\npublic bool IsExist(" + strTemp + ")");
            strCodeForCs.Append("\r\n{");
            if (objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
                }
            }
            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr(false) + "))");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            ///�����ݿ����Ƿ���ڵ�ǰ����(������̺���) ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenIsExistCondRec_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����:�ж��Ƿ����ĳһ�����ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>������ھͷ���TRUE,���򷵻�FALSE</returns>");
            strCodeForCs.Append("\r\npublic bool IsExistCondRec(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("IsExistCondRec", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:IsExistCondRec)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", strCondition))");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string GenCheckPropertyBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.Append("\r\npublic bool CheckProperty(ref string strResult)");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        strPrivPropNameWithObjectName4Get);
                    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        strPrivPropNameWithObjectName4Get);
                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                            strPrivPropNameWithObjectName4Get);
                    }
                    strCodeForCs.Append(")");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nstrResult = \"�ֶ�[" + objField.ColCaption + "]����Ϊ��(NULL)!\";");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                }
            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strCodeForCs.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})",
                        strPrivPropNameWithObjectName4Get,
                         objField.ObjFieldTabENEx.FldLength);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nstrResult = \"�ֶ�[" + objField.ColCaption + "]�ĳ��Ȳ��ܳ���" + objField.ObjFieldTabENEx.FldLength.ToString().Trim() + "!\";");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            ///������������Ƿ���ȷ ==  ==  == = ;
            return strCodeForCs.ToString();
        }


        public string GenCheckUniqueness()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strCodeForCs.Append("\r\n /// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " !=  '{0}' and "
                 + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\nelse");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn true;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\n}");

                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }

        public string GenCheckUniquenessV2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strCodeForCs.Append("\r\n /// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " !=  '{0}' and "
                     + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " !=  {0} and "
                      + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");

                    }
                    strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\nelse");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn true;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\n}");

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strCodeForCs.Append("\r\n /// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness({3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.Append("\r\nsbCondition.AppendFormat(\"" + objField.ObjFieldTabENEx.FldName + " = '{0}'\", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\nelse");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn true;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\n}");
                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }

        public string GenCheckUniquenessV3()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                          objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
            objKeyField.PrivFuncName,
            objKeyField.ColCaption);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                        objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
            }

            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness({1} {2} ",
                objPrjTabENEx.TabName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat(", {0} {1}",
                      objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                      objField.ObjFieldTabENEx.PrivFuncName);
            }
            strCodeForCs.Append(")");

            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  {{0}}\", {1});",
                   objKeyField.FldName,
                   objKeyField.PrivFuncName,
                   "{", "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  '{{0}}'\", {1});",
                   objKeyField.FldName,
                   objKeyField.PrivFuncName,
                   "{", "}");
            }
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", {1});",
                            objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.PrivFuncName,
                            "{", "}");
            }
            strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");

            //StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                          objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
            //objKeyField.PrivFuncName,
            //objKeyField.ColCaption);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                        objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
            }

            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness(",
                objPrjTabENEx.TabName,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName);
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                if (bolIsFirst == true)
                {
                    strCodeForCs.AppendFormat("{0} {1}",
                          objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objField.ObjFieldTabENEx.PrivFuncName);
                    bolIsFirst = false;

                }
                else
                {
                    strCodeForCs.AppendFormat(", {0} {1}",
                       objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                       objField.ObjFieldTabENEx.PrivFuncName);
                }
            }
            strCodeForCs.Append(")");

            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
            strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
               objKeyField.FldName,
               objKeyField.PrivFuncName,
               "{", "}");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", {1});",
                            objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.PrivFuncName,
                            "{", "}");
            }
            strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");


            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡΨһ��������
        /// </summary>
        /// <returns></returns>
        public string GenGetUniquenessConditionString()
        {
            if (objPrjTabENEx.arrPrjConstraintSet().Count == 0) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;

                var arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// ��ȡΨһ��������(Uniqueness)--{0}({1}),����ΨһԼ������������",
                              objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">�����</param>",
                        objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n /// <returns>����Ψһ��������</returns>");
                strCodeForCs.Append($"\r\npublic string GetUniCondStr{strVersion}(cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                objKeyField.FldName,
                objKeyField.PrivFuncName);
                foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                {
                    //if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    var objPrjTabFld = objField.ObjPrjTabFld();
                    if (objPrjTabFld != null && objPrjTabFld.IsTabNullable == true)
                    {

                        strCodeForCs.AppendFormat("\r\n " + "if (obj{1}EN.{0} == null)",
                                     objField.ObjFieldTab().PropertyName(this.IsFstLcase),
                                     objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} is null\");",
 objField.ObjFieldTab().PropertyName(this.IsFstLcase),
 objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                        objField.ObjFieldTab().FldName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                                     objField.ObjFieldTab().FldName,
                                     objPrjTabENEx.TabName,
                                     objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                    }
                }

                strCodeForCs.Append("\r\nreturn sbCondition.ToString();");
                strCodeForCs.Append("\r\n}");
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }


        public string GenCheckPropertyNew()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\npublic void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("CheckPropertyNew[{2}]",
                objPrjTabENEx.TabName, objKeyField.FldName, this.strDataBaseType);
            string strExplanation = "�ֶ�[{1}|{0}]����Ϊ��(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strCodeForCs.AppendFormat("\r\n" + "//����ֶβ���Ϊ��(NULL)");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }

                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                        //strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName4Get);
                        //strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //    strPrivPropNameWithObjectName4Get );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName4Get );
                        //}
                        //strCodeForCs.Append(")");
                        //strCodeForCs.Append("\r\n{");
                        //strCodeForCs.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //        objField.ColCaption,
                        //        objPrjTabENEx.TabCnName,
                        //        strErrId,
                        //        objPrjTabENEx.TabName);
                        //strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                  strPrivPropNameWithObjectName,
                  objField.ObjFieldTabENEx.FldLength,
                  objPrjTabENEx.TabName,
                  objField.ObjFieldTabENEx.FldName);
                        //strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName );
                        //strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //     strPrivPropNameWithObjectName );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName );
                        //}
                        //strCodeForCs.Append(")");
                        //strCodeForCs.Append("\r\n{");
                        //strCodeForCs.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //            objField.ColCaption,
                        //            objPrjTabENEx.TabCnName,
                        //            strErrId,
                        //            objPrjTabENEx.TabName);
                        //strCodeForCs.Append("\r\n}");
                    }
                }


            }
            //������Գ��ȴ���;

            strFunctionName = string.Format("CheckPropertyNew0", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strCodeForCs.AppendFormat("\r\n" + "//����ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                 strPrivPropNameWithObjectName,
                 objField.ObjFieldTabENEx.FldLength,
                 objPrjTabENEx.TabName,
                 objField.ObjFieldTabENEx.FldName);
                        //strCodeForCs.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        //strCodeForCs.Append("\r\n{");
                        //strCodeForCs.AppendFormat("\r\n throw new clsDbObjException(string.Format(\"(errid:{7})�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}(cls{3}DA:CheckPropertyNew)\", obj{3}EN.{4}));",
                        //objField.ColCaption,
                        //objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        //objPrjTabENEx.TabCnName,
                        //objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName,
                        //"{", "}",
                        //strErrId);
                        // strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                             strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength,
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName);

                    }
                }
            }

            //�������ֶγ���;

            strFunctionName = string.Format("CheckPropertyNew1", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strCodeForCs.AppendFormat("\r\n" + "//����ֶ�����̶�����");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
            //strCodeForCs.AppendFormat("\r\n" + "//���Sqlע��");
            //foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            //{
            //    string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

            //    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
            //        && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
            //        && objField.ObjFieldTabENEx.FldLength > 0)
            //    {

            //        //  strCodeForCs.AppendFormat("\r\n" + "//���Sqlע��");
            //        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
            //          strPrivPropNameWithObjectName,
            //          objPrjTabENEx.TabName,
            //          objField.ObjFieldTabENEx.FldName);
            //    }
            //}
            strCodeForCs.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");

            ///������������Ƿ���ȷ-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// רҵ����޸ļ�¼,�������ֶ�ֵ�Ƿ�Ϸ�,1)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\npublic void CheckProperty4Update(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            //������Գ��ȴ���;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strCodeForCs.AppendFormat("\r\n" + "//����ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02) continue;
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);


                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
            ///�������ֶγ���;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strCodeForCs.AppendFormat("\r\n" + "//�������ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
            //strCodeForCs.AppendFormat("\r\n" + "//���Sqlע��");
            //foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            //{
            //    string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

            //    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
            //        && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
            //        && objField.ObjFieldTabENEx.FldLength > 0)
            //    {

            //        //  strCodeForCs.AppendFormat("\r\n" + "//���Sqlע��");
            //        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
            //          strPrivPropNameWithObjectName,
            //          objPrjTabENEx.TabName,
            //          objField.ObjFieldTabENEx.FldName);                    
            //    }
            //}
            strCodeForCs.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");

            ///������������Ƿ���ȷ ==  ==  == = ;
            return strCodeForCs.ToString();
        }


        public string GenCheckProperty4Condition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\npublic void CheckProperty4Condition(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            //FldOpTypeId:
            //0000	δ֪	
            //0001	�ɶ�д	
            //0002	ֻ��	
            //0003	ֻд	
            //0004	���ɶ�д	

            //FieldTypeId:
            //01	һ���ֶ�	NULL
            //02	�ؼ��ֶ�	NULL
            //03	�����ֶ�	NULL
            //04	�����ֶ�	NULL

            ///������Գ��ȴ���;
            string strFunctionName = string.Format("CheckProperty4Condition", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            string strErrId1 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�Ĳ��ܰ����� = ��!ֵ:{{0}}";
            string strErrId2 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�Ĳ��ܰ����� and��!ֵ:{{0}}";
            string strErrId3 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�Ĳ��ܰ�����and ��!ֵ:{{0}}";
            string strErrId4 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strCodeForCs.AppendFormat("\r\n" + "//����ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {

                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                        strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "//���Sqlע��");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {

                    //  strCodeForCs.AppendFormat("\r\n" + "//���Sqlע��");
                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
                      strPrivPropNameWithObjectName,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);


                }
            }
            strCodeForCs.AppendFormat("\r\n" + "//�������ֶγ���");

            ///�������ֶγ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                     strPrivPropNameWithObjectName,
                     objField.ObjFieldTabENEx.FldLength,
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName);

                }
            }
            strCodeForCs.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");


            ///������������Ƿ���ȷ ==  ==  == = ;
            return strCodeForCs.ToString();
        }



        public virtual string GenCurrTabName_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ǰ����");
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n public override string _CurrTabName");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return cls{0}EN._CurrTabName;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");

            return strCodeForCs.ToString();
        }

        public virtual string GenGetPrimaryKeyID()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ���������������м�¼�Ĺؼ���ֵ�б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>���صĹؼ���ֵ�б�</returns>");

            strCodeForCs.Append("\r\npublic List<string> GetID(string strCondition) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\n System.Data.DataTable objDT ;");
            strCodeForCs.Append("\r\nList<string> arrList = new List<string>();");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nint iRow, iCol; ");
            strCodeForCs.Append("\r\nstring strKeyValue; ");
            //			strCodeForCs.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"+ " + KeyWhereStr(true) + "))");
            //			strCodeForCs.Append("\r\nreturn arrList;");
            strCodeForCs.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            ///			
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfor (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue = \"\";");
            strCodeForCs.Append("\r\nfor (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (iCol  ==  0)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue +=  objDT.Rows[iRow][iCol].ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue +=  \"//\" + objDT.Rows[iRow][iCol].ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\narrList.Add(strKeyValue);");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nreturn arrList;");
            strCodeForCs.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strCodeForCs.ToString();
        }


        public string GenGetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ǰ׺��ȡ��ǰ������ַ��͹ؼ���ID");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>���ص����ؼ���ֵID</returns>");
            strCodeForCs.Append("\r\npublic string GetMaxStrIdByPrefix(string strPrefix)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n//��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strMaxValue = objSQL.GetMaxStrId(cls{0}EN._CurrTabName, con{0}.{1}, {2}, strPrefix);",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\nreturn strMaxValue;");
            strCodeForCs.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strCodeForCs.ToString();
        }
        public virtual string GenGetMaxStrID()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ������ַ��͹ؼ���ID");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>���ص����ؼ���ֵID</returns>");
            strCodeForCs.Append("\r\npublic static string GetMaxStrId()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n//��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strMaxValue = objSQL.GetMaxStrId(cls{0}EN._CurrTabName, con{0}.{1}, {2}, \"\");",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\nreturn strMaxValue;");
            strCodeForCs.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strCodeForCs.ToString();
        }

        public virtual string GenIsExistTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����Ƿ���ڵ�ǰ��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>���ھͷ���True,���򷵻�False</returns>");
            strCodeForCs.Append("\r\npublic static bool IsExistTable()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n//��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nbool bolIsExist = objSQL.IsExistTable(\"{0}\");",
                                        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn bolIsExist;");
            strCodeForCs.Append("\r\n}");

            //strCodeForCs.Append("\r\n /// <summary>");
            //strCodeForCs.Append("\r\n /// ����Ƿ���ڸ�����");
            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.Append("\r\n /// </summary>");
            //strCodeForCs.Append("\r\n /// <param name = \"strTabName\">������</param>");
            //strCodeForCs.Append("\r\n /// <returns>���ھͷ���True,���򷵻�FalseD</returns>");
            //strCodeForCs.Append("\r\npublic static bool IsExistTable(string strTabName)");
            //strCodeForCs.Append("\r\n{");
            //strCodeForCs.Append("\r\nclsSpecSQLforSql objSQL;");
            //strCodeForCs.Append("\r\n//��ȡ���Ӷ���");
            //strCodeForCs.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\nbool bolIsExist = objSQL.IsExistTable(strTabName);",
            //                            objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\nreturn bolIsExist;");
            //strCodeForCs.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetFirstID()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");

            strCodeForCs.AppendFormat("\r\npublic {0} GetFirstID(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\n System.Data.DataTable objDT ;");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strCodeForCs.Append("\r\nint iRow, iCol; ");
            strCodeForCs.Append("\r\nstring strKeyValue; ");
            strCodeForCs.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            ///			
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.Append("\r\nreturn \"\";");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strCodeForCs.Append("\r\nreturn 0;");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";",
                objPrjTabENEx.TabName);
            }
            //strCodeForCs.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");

            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "int":
                    strCodeForCs.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strCodeForCs.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strCodeForCs.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strCodeForCs.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strCodeForCs.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strCodeForCs.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strCodeForCs.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strCodeForCs.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strCodeForCs.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetFirstID_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");

            strCodeForCs.AppendFormat("\r\npublic {0} GetFirstID_S(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\n System.Data.DataTable objDT ;");
            strCodeForCs.Append("\r\n List<string> arrList = new List<string>();");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strCodeForCs.Append("\r\nint iRow, iCol; ");
            strCodeForCs.Append("\r\nstring strKeyValue; ");
            strCodeForCs.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nLogErrorS(objException, \"cls{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            ///			
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType  ==  "string")
            //{
            // strCodeForCs.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");
            //}
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.Append("\r\nreturn \"\";");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strCodeForCs.Append("\r\nreturn 0;");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\nreturn new cls{0}DA()." + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";",
                objPrjTabENEx.TabName);
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");

            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "int":
                    strCodeForCs.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strCodeForCs.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strCodeForCs.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strCodeForCs.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strCodeForCs.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strCodeForCs.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strCodeForCs.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strCodeForCs.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strCodeForCs.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strCodeForCs.ToString();
        }


        public virtual string GenGetReader()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\npublic System.Data.SqlClient.SqlDataReader GetReader(string strCondition) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\nSystem.Data.SqlClient.SqlDataReader objDR ;");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + string.Format("strSQL = \"Select * from {0} where \" + strCondition;", objPrjTabENEx.TabName));
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDR = objSQL.GetSqlDataReader(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            /// strCodeForCs.Append("\r\nobjDR = null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objDR;");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public virtual string GenGetTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///GetTable(����������ȡ���ݱ�);
            strCodeForCs.Append("\r\npublic DataTable GetTable(string strCondition) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT ;");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            /// 
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public virtual string GenGetTableBySQL()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///GetTableBySQL(����SQL����ȡ���ݱ�)----------------------------------;
            strCodeForCs.Append("\r\npublic DataTable GetTableBySQL(string strSQL) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT ;");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            ///GetTableBySQL(����SQL����ȡ���ݱ�) ==  ==  == ;
            ///��������END ==  ==  == ;
            return strCodeForCs.ToString();
        }

        public string GengetStrLen()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ�---------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"strTemp\">������ԭ�ַ���</param>");
            strCodeForCs.Append("\r\n /// <returns>�����ַ�������</returns>");
            strCodeForCs.Append("\r\npublic static int GetStrLen(string strTemp)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nint len ;");
            strCodeForCs.Append("\r\nbyte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);");
            strCodeForCs.Append("\r\nlen = sarr.Length;//will output as 3+3*2 = 9");
            strCodeForCs.Append("\r\nreturn len;");
            strCodeForCs.Append("\r\n}");
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1��;
            ///˽�к��� ==  ==  == ;
            return strCodeForCs.ToString();
        }
        public string GenDispose()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///������������---------------------------------------;
            strCodeForCs.Append("\r\n public void Dispose()");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (mblnDisposed  ==  false)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n //Free up the database connection resource by ");
            strCodeForCs.Append("\r\n //calling its Dispose method");
            strCodeForCs.Append("\r\n //mobjConnection.Dispose()");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n finally");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n //Because this Dispose method has done the necessary cleanup,");
            strCodeForCs.Append("\r\n //prevent the Finalize method from being called.");
            strCodeForCs.Append("\r\n GC.SuppressFinalize(this);");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n //Let our class know that Dispose() has been called");
            strCodeForCs.Append("\r\n mblnDisposed = true;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            ///������������ ==  ==  == ;
            return strCodeForCs.ToString();
        }
        public string GenLogError()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ� == ;
            ///������־;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �Ѹ������쳣����洢����־��ȥ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"objException\">�������쳣����</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\nprotected void LogError" + "(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n //Log the error information to the Application Log");
            strCodeForCs.Append("\r\n string strLogMsg ;");
            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strCodeForCs.Append("\r\n+ mstrModuleName + \"Source: \" + objException.Source \r\n");
            strCodeForCs.Append("\r\n+ \"Message: \" + objException.Message ");
            strCodeForCs.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strCodeForCs.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n //Write error to event log");
            strCodeForCs.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }

        public string GenLogError_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ� == ;
            ///������־;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �Ѹ������쳣����洢����־��ȥ(��ģ����)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"objException\">�������쳣����</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"strModuleName\">ģ������</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\nprotected static void LogErrorS" + "(Exception objException, string strModuleName)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n //Log the error information to the Application Log");
            strCodeForCs.Append("\r\n string strLogMsg ;");
            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strCodeForCs.Append("\r\n+ strModuleName + \"Source: \" + objException.Source \r\n");
            strCodeForCs.Append("\r\n+ \"Message: \" + objException.Message ");
            strCodeForCs.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strCodeForCs.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n //Write error to event log");
            strCodeForCs.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string Gen_ClearUpdateState()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����޸�״̬,����մ洢���ֶ���Ϣ��HashTable�б�.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public void ClearUpdateState()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "htProperty.Clear();");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public virtual string GenComboBoxBindFunction5()
        {
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
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��ȡ���ڰ��������DataTable,��ȡ�����ֶ�:1���ؼ��֣�2�������ֶ�");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <returns>�������ڰ��������DataTable</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						if (objField.DsCondStr.Trim()  ==  "")
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    //						}

                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objDT;");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// �󶨻���Win��������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                    strValueFieldName);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0};",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"0\";",
                    objPrjTabENEx.TabName, strValueFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"ѡ[{2}]...\";",
              objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
                    strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[con{0}.{1}].ToString();",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[con{0}.{1}].ToString();",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");

                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = con{0}.{1};",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = con{0}.{1};",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                  objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
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

        public virtual string GenComboBoxBindFunction()
        {
            return "";
            //StringBuilder strCodeForCs = new StringBuilder();
            //string strTextFieldName = "";
            //string strValueFieldName = "";

            //try
            //{
            //    //��0��:�ѿؼ���������ComboBoxת����ComboBox
            //    foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            //    {
            //        if (objField.FieldTypeId == "02")
            //        {
            //            strValueFieldName = objField.ObjFieldTabENEx.FldName;
            //        }
            //        if (objField.FieldTypeId == "03")
            //        {
            //            strTextFieldName = objField.ObjFieldTabENEx.FldName;
            //        }
            //    }
            //    if (strValueFieldName != "" && strTextFieldName != "")
            //    {
            //        strCodeForCs.Append("\r\n /// <summary>");
            //        strCodeForCs.Append("\r\n /// ��ȡ���ڰ��������DataTable,��ȡ�����ֶ�:1���ؼ��֣�2�������ֶ�");
            //        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //        strCodeForCs.Append("\r\n /// </summary>");
            //        strCodeForCs.Append("\r\n /// <returns>�������ڰ��������DataTable</returns>");
            //        strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
            //        strValueFieldName);
            //        strCodeForCs.Append("\r\n" + "{");
            //        strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
            //        strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
            //        strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
            //        //						if (objField.DsCondStr.Trim()  ==  "")
            //        //						{
            //        //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
            //        //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
            //        //						}
            //        //						else
            //        //						{
            //        //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
            //        //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
            //        //						}

            //        strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //        strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
            //        strCodeForCs.Append("\r\n" + "return objDT;");
            //        strCodeForCs.Append("\r\n" + "}");
            //        strCodeForCs.Append("\r\n /// <summary>");
            //        strCodeForCs.Append("\r\n /// �󶨻���Win��������");
            //        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //        strCodeForCs.Append("\r\n /// </summary>");
            //        strCodeForCs.Append("\r\n /// <param name = \"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
            //        strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
            //        strValueFieldName);
            //        strCodeForCs.Append("\r\n" + "{");
            //        strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
            //        strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
            //        strValueFieldName);


            //        strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
            //        strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
            //        objPrjTabENEx.TabName, strValueFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"��ѡ��1...\";",
            //        objPrjTabENEx.TabName, strTextFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
            //        strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
            //        strCodeForCs.Append("\r\n" + "{");
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[con{0}.{1}].ToString();",
            //        objPrjTabENEx.TabName, strValueFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[con{0}.{1}].ToString();",
            //        objPrjTabENEx.TabName, strTextFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "}");
            //        strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");

            //        strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = con{0}.{1};",
            //        objPrjTabENEx.TabName, strValueFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = con{0}.{1};",
            //       objPrjTabENEx.TabName, strTextFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
            //      objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
            //        strCodeForCs.Append("\r\n" + "}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    clsEntityBase.LogErrorS(ex, "");
            //    throw new Exception(ex.Message, ex);
            //}
            //return strCodeForCs.ToString();
        }

        public string GenDdlBindFunction__Java()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///���ɽ��б���;
                //��������ĺ��� ����;
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
                    //					strCodeForCs.AppendFormat("\r\n" + "public ResultSet Get{0}()", 
                    //						strValueFieldName);
                    //					strCodeForCs.Append("\r\n" + "{");
                    //					strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    //					strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //						strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //					//									if (objViewCtlField.DsCondStr.Trim() == "")
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DsTabName);
                    //					//									}
                    //					//									else
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DsTabName, objViewCtlField.DsCondStr);
                    //					//									}
                    //					strCodeForCs.Append("\r\n" + "clsSpecSQL mySql = new clsSpecSQL();");
                    //					strCodeForCs.Append("\r\n" + "ResultSet objRS = mySql.GetResultSet(strSQL);");
                    //					strCodeForCs.Append("\r\n" + "return objRS;");
                    //					strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// �󶨻���Web��������");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
                  objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "ResultSet objRS = Get{0}();",
                    strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = \"{0}\";", strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = \"{0}\";", strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objRS;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
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

        Func<clsEditRegionFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());


        public string GenDdlBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                IEnumerable<clsEditRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrEditRegionFldSet4InUse
                    .Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj
                    = arrERF4DropDownLst.Select(GetDdlObj2);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    //strCodeForCs.Append("\r\n" + objInfor.GC_BindDdlFunc());

                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �ѱ������ݰ󶨵�ListView��
        /// </summary>
        /// <returns></returns>
        public string GenBindListView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //strCodeForCs.Append("\r\n /1//���ɰ�ListView�Ĵ���");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��ListView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��4��)");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ArrayList arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = new cls{0}BL.GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//���ԭ������Item",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//���ԭ��������ͷ��Ϣ",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//���ǹ����ֶ�
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}EN.{1};",
                objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.FldName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objKeyField.FldId == objField.FldId)
                    {
                        continue;
                    }
                    if (objField.FieldTypeId != "04"
                    && objField.IsTabForeignKey == false
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4�����ü�¼����״̬,");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// �ѱ������ݰ󶨵�ListView��
        /// </summary>
        /// <returns></returns>
        public string GenBindListView5()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //strCodeForCs.Append("\r\n //1/���ɰ�ListView�Ĵ���");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��ListView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��4��)");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ArrayList arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = new cls{0}().GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//���ԭ������Item",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//���ԭ��������ͷ��Ϣ",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//���ǹ����ֶ�
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0} obj{0} in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}.{1};",
                objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.FldName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objKeyField.FldId == objField.FldId)
                    {
                        continue;
                    }
                    if (objField.FieldTypeId != "04"
                    && objField.IsTabForeignKey == false
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4�����ü�¼����״̬,");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        #region ˽�к���
        protected void LogError(Exception objException)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {

                strLogMsg = "An error occurred in the following module: "
              + objPrjTabENEx.ModuleName + "\r\nSource: " + objException.Source
              + "Message: " + objException.Message + "\r\n"
              + "Stack Trace: " + objException.StackTrace

              + "Target Site: " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(objPrjTabENEx.ModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }
        #endregion
        public static void CheckTabNameIsNotNull(string strTabName)
        {
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                string strMsg = string.Format("�˴���������Ϊ��!");
                throw new Exception(strMsg);
            }
        }
        public static clsGeneCodeBase GetClassByName(string strClassName)
        {
            Type expType = Type.GetType(strClassName);
            if (expType == null)
            {
                string strMsg = string.Format("����:{0}������,����!", strClassName);
                throw new Exception(strMsg);
            }
            //ʹ��Type����Ҳ����ʵ����һ������ͬ���������淽��
            clsGeneCodeBase objGeneCodeBase = (clsGeneCodeBase)Activator.CreateInstance(expType);
            return objGeneCodeBase;
        }


        public static clsGeneCodeBase GetClassByName(string strClassName, string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        {
            Type expType = Type.GetType(strClassName);
            if (expType == null)
            {
                string strMsg = string.Format("����:{0}������,����!", strClassName);
                throw new Exception(strMsg);
            }
            //ʹ��Type����Ҳ����ʵ����һ������ͬ���������淽��
            clsGeneCodeBase objGeneCodeBase = null;
            try
            {
                objGeneCodeBase = (clsGeneCodeBase)Activator.CreateInstance(expType, strTabId, strViewId, strPrjDataBaseId, strPrjId);
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return objGeneCodeBase;
        }
        public abstract string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName);
        public abstract void GetClsName();
        //{
        //    string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);
        //}

        //public virtual string A_GenEntityLayerCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);   
        //}
        //public virtual string A_GenTableFldConstCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);
        //}

        public virtual string A_GenEntityLayerCode_Cond(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }

        public virtual string A_GenEntityLayerCodeExBak(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }


        public virtual string A_GenEntityLayerCode_Sim(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        //public virtual string A_GenDALCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);
        //}
        public virtual string A_GenDALExCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }

        public virtual string A_GenDALCode_Java(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public virtual string A_GenGeneralLogicCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public virtual string A_GenGeneralExLogicCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }



        public string GenClassConstructor2_Java()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\npublic {0}({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n hmProperty = new HashMap<String, String>();");
            string strTemp = GetKeyAssign();
            if (string.IsNullOrEmpty(strTemp) == false)
            {
                strCodeForCs.AppendFormat("\r\n {0}", strTemp);
            }
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor2_JavaScript()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\npublic {0}({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n hmProperty = new Dictionary();");
            strCodeForCs.Append("\r\n" + GetKeyAssign() + ";");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor2_TypeScript()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\npublic constructor({0}: {1})",
                objKeyField.ObjFieldTabENEx.PrivPropName, objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1} || {2};",
                               this.objKeyField.FldName,
                               this.objKeyField.PrivFuncName,
                                (this.objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true ? "\"\"" : "0")
               );
            strCodeForCs.Append("\r\n hmProperty = new Dictionary();");
            strCodeForCs.Append("\r\n" + GetKeyAssign() + ";");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor2_Swift()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\n init({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + GetKeyAssign_Swift());
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor2_Swift3()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\n init({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + GetKeyAssign_Swift());
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor2_Swift4()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\n init({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + GetKeyAssign_Swift());
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GetKeyAssignBak()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.PrivPropName + " = " + objField.ObjFieldTabENEx.PrivFuncName + ";";
                strPara += "\r\n" + strTemp;
            }
            return strPara;
        }
        public string GetKeyAssign()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = string.Format("this.{0} = {1};",
                    objField.ObjFieldTabENEx.PrivPropName,
                     objField.ObjFieldTabENEx.PrivFuncName);
                strPara += "\r\n" + strTemp;
            }
            return strPara;
        }

        public string GetKeyAssign_Swift()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = string.Format("self.{0} = {1};",
                    objField.ObjFieldTabENEx.PrivPropName,
                     objField.ObjFieldTabENEx.PrivFuncName);
                strPara += "\r\n" + strTemp;
            }
            return strPara;
        }
        public string GenClassConstructor1_Java()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n public {0}()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n hmProperty = new HashMap<String, String>();");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor1_JavaScript()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n this.init = function()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n this.hmProperty = new Dictionary();");
            strCodeForCs.Append("\r\n this.SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n };");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor1_Swift()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n override init()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor1_Swift3()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n override init()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor1_Swift4()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n override init()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor1_Swift4_Sim()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// ���캯��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n init()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);
            }

            strCodeForCs.AppendFormat("\r\n" + "self.sf_UpdFldSetStr = \"\";     //�޸��ַ���־��");

            //strCodeForCs.Append("\r\n super.init();");
            //strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            //strCodeForCs.Append("\r\n SetInit();");
            //strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��
        /// </summary>
        /// <param name = "strWordTypeId">�ؼ���</param>
        /// <returns>�Ƿ���ɹ�</returns>
        public string GenCheckPrimaryKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��.-----------------------------;
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�ؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>�Ƿ���ɹ�</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public bool CheckPrimaryKey(string {0})", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length > {1})", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\n" + "{");

            string strFunctionName = string.Format("CheckPrimaryKey", objKeyField.PrivFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڱ�:{0}��,���ؼ���,���Ȳ���ȷ!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})�ڱ�:{0}��,���ؼ���,���Ȳ���ȷ!(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strExplanation = "�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strExplanation = "�ڹؼ����к���{0},�Ƿ�,����!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(string.Format(\"(errid:{3})�ڹؼ����к���{{0}},�Ƿ�,����!(cls{2}DA:CheckPrimaryKey)\", objException.Message));",
                    "{", "}",
                    objPrjTabENEx.TabName,
                    strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");

            ///����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��. ==  == = ;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��
        /// </summary>
        /// <param name = "strWordTypeId">�ؼ���</param>
        /// <returns>�Ƿ���ɹ�</returns>
        public string GenCheckPrimaryKey_Sim()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��.-----------------------------;
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�ؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>�Ƿ���ɹ�</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public bool CheckPrimaryKey_Sim(string {0})", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length > {1} + 4)", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\n" + "{");

            string strFunctionName = string.Format("CheckPrimaryKey_Sim", objKeyField.PrivFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڱ�:{0}��,���ؼ���,���Ȳ���ȷ!(�򻯰�)";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})�ڱ�:{0}��,���ؼ���,���Ȳ���ȷ!(�򻯰�)(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strExplanation = "�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strExplanation = "�ڹؼ����к���{0},�Ƿ�,����!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(string.Format(\"(errid:{3})�ڹؼ����к���{{0}},�Ƿ�,����!(cls{2}DA:CheckPrimaryKey)\", objException.Message));",
                    "{", "}",
                    objPrjTabENEx.TabName,
                    strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");

            ///����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��. ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string Gen_4DAL_GetDataTable4DdlBind()
        {
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
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��ȡ���ڰ��������DataTable,��ȡ�����ֶ�:1���ؼ��֣�2�������ֶ�");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <returns>�������ڰ��������DataTable</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						if (objField.DsCondStr.Trim()  ==  "")
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    //						}

                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objDT;");
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

        public string SetProperty4DefaultValue_Swift3(clsPrjTabFldENEx objField)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );

                    break;
                case "Int32":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Int":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Double":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Float":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Short":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Bool":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Date":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = Date();",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift��������:[{1}]��switch��û�д���({0})",
                        clsStackTrace.GetCurrClassFunction(),
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                    throw new Exception(strMsg);

            }
            //strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string SetProperty4DefaultValue_Swift4(clsPrjTabFldENEx objField)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //strCodeForCs.AppendFormat("\r\n" + "if (jsonAllKeys.contains(\"{0}\") == true)",
            //     objField.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n" + "{");
            //  strCodeForCs.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );

                    break;
                case "Int32":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Int":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Double":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Float":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Short":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Bool":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Date":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift��������:[{1}]��switch��û�д���({0})",
                        clsStackTrace.GetCurrClassFunction(),
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                    throw new Exception(strMsg);

            }
            //strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public abstract string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code);
        //{
        //    string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);
        //}     

        public string KeyDataType
        {
            get
            {
                return objKeyField.TypeScriptType;
            }
        }

        /// <summary>
        /// �ؼ��ֵ��ֶ���
        /// </summary>
        public string KeyFldName
        {
            get
            {
                return objKeyField.FldName;
            }
        }

        public clsViewInfoENEx objViewInfoENEx { get => mobjViewInfoENEx; set => mobjViewInfoENEx = value; }
        /// <summary>
        /// �Ƿ񵯳���༭
        /// </summary>
        public bool IsPopupDivEdit { get; set; }
        /// <summary>
        /// ����ֶ����Ƿ��ǹؼ��ֶ�
        /// </summary>
        /// <param name = "strFldName">������ֶ���</param>
        /// <param name = "objPrjTabENEx"></param>
        /// <returns></returns>
        public bool IsKeyField(string strFldName)
        {
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {

                if (objField.ObjFieldTabENEx.FldName == strFldName)
                {
                    return true;
                }
            }
            return false;
        }
        public string Gen_Controller_Java_BindDdl(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(Spinner spnObject, Activity acPage)",
                strValueFld);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mspnObject = spnObject;");
            strCodeForCs.Append("\r\n" + "macPage = acPage;");
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.arr{0}ObjLstCache != null)",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, {1}.arr{0}ObjLstCache);",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //  strCodeForCs.Append("\r\n" + "SendMessage(\"ʹ�û���!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}ʹ�û���!\", 1);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.icls{0}GetJSONObjLstEx iobj{0}GetJSONObjLst = new {1}.icls{0}GetJSONObjLstEx({1}.this);",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_Controller_Java_GetJSONObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void btnGetJSONObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetJSONObjLstEx iobj{0}GetJSONObjLst = new icls{0}GetJSONObjLstEx({1}.this);",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstEx  extends  cls{0}_Controller.icls{0}GetJSONObjLst",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.set{0}(\"0\");",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.set{0}(\"��ѡ��...\");", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLstCache = arr{0}ObjLst;",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"��ѡ������{0}: \");", objPrjTabENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"û��ʹ�û���!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, û��ʹ�û���!\", 1);",
                strTabName);
            //strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = \" 1 = 1 \"; "); 
            //strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��������:[%s]����ȡ�����б�����%s!\", strWhereCond, arr{0}ObjLst.size());",
            //    objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_Controller_Java_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}4SD_UnitTest.this);",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_{1}Ex  extends  cls{0}4SD_Controller.icls{0}_{1}",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}WS4SDController obj{0}WS4SDController = new {0}WS4SDController();",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.objTableObjWS4ControllerDelegate = this;",
                objWebSrvClassENEx.ClsName);

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
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            objWebSrvFuncParaEN._StrTag);
                    }
                    else
                    {
                        switch (objWebSrvFuncParaEN.DataTypeId)
                        {
                            case enumDataTypeAbbr.float_07:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.int_09:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.money_11:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            default:
                                strMsg = string.Format("�������ͣ�[{0}({1})](Java:{2})�ں�����û�д���!({3})",
                                    objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                    objDataTypeAbbrEN.JavaType,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
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

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"����ֵΪ��[%s]!\", returnString);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_{1}Ex  extends  cls{0}_Controller.icls{0}_{1}",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
              clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
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
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
                                objDataTypeAbbrEN.JavaType,
                                objFuncPara4CodeEN.ParaName,
                                objFuncPara4CodeEN._StrTag);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                default:
                                    strMsg = string.Format("�������ͣ�[{0}({1})](Java:{2})�ں�����û�д���!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.JavaType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        if (objSelfDefDataTypeEN_Para != null)
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objSelfDefDataTypeEN_Para.JavaType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        else
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objDataTypeAbbrEN.JavaType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.{1}({2});",
                    objPrjTabENEx.TabName,
                    objvFunction4GeneCodeEN.FuncName4Code,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"����ֵΪ��[%s]!\", returnString);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
        public string Gen_Controller_Java_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "fill_parent";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + " <Button android:id=\"@+id/btn{0}\"", 
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "        android:layout_width=\"fill_parent\"");
            //strCodeForCs.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strCodeForCs.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.AppendFormat("\r\n" + "android:onClick = \"btn{0}_Click\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "android:textSize=\"12sp\"");
            //strCodeForCs.Append("\r\n" + "android:minHeight=\"35dp\"");
            //strCodeForCs.Append("\r\n" + "        />");            

            return strCodeForCs.ToString();
        }
        public string GetNewParaCtrlName(string strFuncId4GC, string strParaName)
        {
            clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
            clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
            {
                if (objFuncPara4CodeEN.ParaName == strParaName) return objFuncPara4CodeEN._StrTag;
            }
            return "";
        }
        public string Gen_WA_Controller_Java_BindDdl(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(Spinner spnObject, Activity acPage)",
                strValueFld);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mspnObject = spnObject;");
            strCodeForCs.Append("\r\n" + "macPage = acPage;");
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.arr{0}ObjLstCache != null)",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, {1}.arr{0}ObjLstCache);",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //  strCodeForCs.Append("\r\n" + "SendMessage(\"ʹ�û���!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}ʹ�û���!\", 1);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.icls{0}GetObjLstEx iobj{0}GetObjLst = new {1}.icls{0}GetObjLstEx({1}.this);",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetObjLst.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WA_Controller_Java_GetObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void btnGetObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetObjLstEx iobj{0}GetObjLst = new icls{0}GetObjLstEx({1}.this);",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetObjLstEx  extends  cls{0}_WA_Controller.icls{0}GetObjLst",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetObjLstEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4Controller.GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.set{0}(\"0\");",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.set{0}(\"��ѡ��...\");", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLstCache = arr{0}ObjLst;",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"��ѡ������{0}: \");", objPrjTabENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"û��ʹ�û���!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, û��ʹ�û���!\", 1);",
                strTabName);
            //strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = \" 1 = 1 \"; "); 
            //strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��������:[%s]����ȡ�����б�����%s!\", strWhereCond, arr{0}ObjLst.size());",
            //    objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WA_Controller_Java_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}4SD_WA_UT.this);",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_{1}Ex extends  cls{0}4SD_Controller.icls{0}_{1}",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}WA4SDController obj{0}WA4SDController = new {0}WA4SDController();",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4SDController.objTableObjWA4ControllerDelegate = this;",
                objWebSrvClassENEx.ClsName);

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
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            objWebSrvFuncParaEN._StrTag);
                    }
                    else
                    {
                        switch (objWebSrvFuncParaEN.DataTypeId)
                        {
                            case enumDataTypeAbbr.float_07:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.int_09:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.money_11:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            default:
                                strMsg = string.Format("�������ͣ�[{0}({1})](Java:{2})�ں�����û�д���!({3})",
                                    objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                    objDataTypeAbbrEN.JavaType,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
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

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4SDController.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"����ֵΪ��[%s]!\", returnString);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_{1}Ex extends  cls{0}_WA_Controller.icls{0}_{1}",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
              clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
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
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
                                objDataTypeAbbrEN.JavaType,
                                objFuncPara4CodeEN.ParaName,
                                objFuncPara4CodeEN._StrTag);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                default:
                                    strMsg = string.Format("�������ͣ�[{0}({1})](Java:{2})�ں�����û�д���!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.JavaType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        if (objSelfDefDataTypeEN_Para != null)
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objSelfDefDataTypeEN_Para.JavaType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        else
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objDataTypeAbbrEN.JavaType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4Controller.{1}({2});",
                    objPrjTabENEx.TabName,
                    objvFunction4GeneCodeEN.FuncName4Code,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"����ֵΪ��[%s]!\", returnString);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
        public string Gen_WA_Controller_Java_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "fill_parent";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + " <Button android:id=\"@+id/btn{0}\"", 
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "        android:layout_width=\"fill_parent\"");
            //strCodeForCs.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strCodeForCs.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.AppendFormat("\r\n" + "android:onClick = \"btn{0}_Click\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "android:textSize=\"12sp\"");
            //strCodeForCs.Append("\r\n" + "android:minHeight=\"35dp\"");
            //strCodeForCs.Append("\r\n" + "        />");            

            return strCodeForCs.ToString();
        }
        public string KeyFldNameLstStrWithAddStr(string strAdditionalStr, clsViewInfoENEx objViewInfoENEx)
        {
            List<string> arrKeyFldNameLst = new List<string>();
            foreach (clsPrjTabFldENEx objField in objViewInfoENEx.arrKeyPrjTabFldSet)
            {
                arrKeyFldNameLst.Add(strAdditionalStr + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
            }
            string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
            return strKeyFldNameLst;
        }

        public string KeyFldNameLstStrWithAddStr(string strAdditionalStr, clsPrjTabENEx objPrjTabENEx)
        {
            List<string> arrKeyFldNameLst = new List<string>();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                arrKeyFldNameLst.Add(strAdditionalStr + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
            }
            string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
            return strKeyFldNameLst;
        }

        public clsEditRegionFldsENEx getEditRegionKeyFld()
        {
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsEx.FldName
                     == objKeyField.ObjFieldTabENEx.FldName)
                {
                    return objEditRegionFldsEx;
                }
            }
            return null;
        }

        public string TransKeyWords4FuncName(string strFuncName)
        {
            string strFuncName2 = strFuncName.Replace("[Key]", objKeyField.FldName);
            strFuncName2 = strFuncName2.Replace("[key]", objKeyField.FldName);
            strFuncName2 = strFuncName2.Replace("[TabName]", objPrjTabENEx.TabName);
            //strFuncName2 = strFuncName.Replace("[key]", objKeyField.FldName);
            return strFuncName2;
        }
        public bool IsNumberType4Key
        {
            get
            {
                return clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN);
            }
        }

        public bool IsFstLcase { get => isFstLcase; set => isFstLcase = value; }


        //ƴװ�ؼ��ֵ�WHERE��
        protected string KeyWhereStrWithObject(clsPrjTabENEx objPrjTabENEx, string strObject)
        {
            //bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                strTemp = string.Format("{0} = \" + {1}+ {2}+{1}",
                    objField.ObjFieldTabENEx.FldName,
                     Mark(objField),
                      strPrivPropNameWithObjectName4Get);
                if (i == 0) //�Ƿ��ǵ�һ��
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += string.Format(" + \" and {0}", strTemp);
                }
                i++;
            }

            return WhereStr;
        }


        //ƴװ�ؼ��ֵ�WHERE��
        protected string KeyWhereStrWithObject(string strObject)
        {
            //bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, strObject, this.IsFstLcase) + "+" + Mark(objField);
                if (i == 0) //�Ƿ��ǵ�һ��
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }


        protected string AccessNull_Java(clsPrjTabFldENEx objField)
        {
            return AccessNull_Java("objRS.Rows[0][\"" + objField.ObjFieldTabENEx.FldName + "\"].toString().Trim()", objField.JavaType, objField.IsTabNullable);
        }
        protected string AccessNull2_Java(clsPrjTabFldENEx objField)
        {
            strTemp = objField.JavaType;
            clsString.FstUcase_S(ref strTemp);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("objRS.get{0}(\"{1}\")",
            strTemp, objField.ObjFieldTabENEx.FldName);
            return AccessNull(strCodeForCs.ToString(), objField.JavaType, objField.IsTabNullable);
        }
        protected string AccessNull_Java(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            if (bolIsNullable == false)
            {
                return strContent;
            }
            switch (strPropType)
            {
                case "String":
                    return strContent;
                case "int":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Integer.parseInt(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToShort(" + strContent + ")";
                    }
                    else
                    {
                        return "Short.parseShort(" + strContent + ")";
                    }
                case "Date":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToDate(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToFloat(" + strContent + ")";
                    }
                    else
                    {
                        return "Single.Parse(" + strContent + ")";
                    }
                case "Double":
                case "Money":
                case "double":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.parseDouble(" + strContent + ")";
                    }
                case "boolean":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToBool(" + strContent + ")";
                    }
                    else
                    {
                        return "boolean.parseBoolean(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.parseDouble(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Integer.parseInt(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":

                    return "(byte[])" + strContent;
                case "byte":

                    return "(byte)" + strContent;
                case "Int16":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Integer.parseInt(" + strContent + ")";
                    }
                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull

        protected string getValueStr(clsPrjTabFldENEx pobjField)
        {
            if (pobjField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                return "'\" + " + pobjField.ObjFieldTabENEx.PropertyName(this.IsFstLcase) + " + \"'";
            }
            else
            {
                return pobjField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
            }
        }



        protected string KeyWhereStr(bool isNeed_m, clsPrjTabENEx objPrjTabENEx)
        {
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.ObjFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                ///'strTemp = arrKeyFldSet[i].ColumnName + " = \"" + Mark(arrKeyFldSet[i]) + "+ " + "m" + objField.ObjFieldTabENEx.PrivFuncName + Mark(arrKeyFldSet[i])
                if (i == 0) //�Ƿ��ǵ�һ��
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }


        public string gfunTransNullToStr()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///˽�к���Begin-------------------------------------;
            strCodeForCs.Append("\r\nprivate string TransNullToStr(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn \"\";");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn obj.ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToInt()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate int TransNullToInt(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn 0;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn Int32.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToDate()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate DateTime TransNullToDate(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn DateTime.Parse(\"#1/1/1900#\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn DateTime.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToFloat()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate float TransNullToFloat(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn 0.0f;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn float.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToDouble()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate double TransNullToDouble(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn 0.0;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn double.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToBool()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate bool TransNullToBool(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn bool.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }



        public string Gen_4BL_GC_GetObjLstFromDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                intCount++;
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull_Static(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (intCount == objPrjTabENEx.arrFldSet.Count)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull_Static(objField) + "; //{2}",
objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull_Static(objField) + "; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }

                }
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"ת��DataRow�ɶ������, �ؼ���:[{0}]��{1}. (In {2})\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, objException.Message, clsStackTrace.GetCurrClassFunction());",
                objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n	};");
            strCodeForCs.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_GC_GetObjFromDataRow()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN()",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                intCount++;
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (intCount == objPrjTabENEx.arrFldSet.Count)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1} = " + AccessNull2(objField) + " //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1} = " + AccessNull2(objField) + ", //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                }
            }
            strCodeForCs.Append("\r\n};");
            //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            //objPrjTabENEx.TabName);

            return strCodeForCs.ToString();
        }

        public string GetClsNameByRegionTypeId(string strRegionTypeId)
        {
            clsViewRegionENEx obj = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == strRegionTypeId);
            if (obj != null && string.IsNullOrEmpty(obj.ClsName) == false)
            {
                return string.Format("{0}", obj.ClsName);
            }
            else
            {
                return "����������,�������������������������ϵ����Ա!";
            }
        }

        protected string A_GeneFuncCodeBase(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, Type t)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                //Type t = typeof(WA_ViewScriptCS_TS4TypeScript);
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
        public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        {
            return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, thisPrjId);
        }
    }
}
