using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace AutoGCLib
{
    public abstract partial class clsGeneCodeBase
    {

        public string thisWA_F(WA_F objFuncName)
        {

            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format("{0}_GetObjFromJsonObj", ThisTabName4GC);
                case WA_F.GetObjLst_Cache:
                    return string.Format("{0}_GetObjLstCache", ThisTabName4GC);
                case WA_F.GetObjByKeyId:
                    if (objPrjTabENEx.arrKeyFldSet.Count > 1)
                    {
                        return string.Format($"{ThisTabName4GC}_GetObjByKeyLstAsync");
                    }
                    else
                    {
                        return string.Format($"{ThisTabName4GC}_GetObjBy{thisTabProp_TS.ByInFuncName}Async");
                    }
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{ThisTabName4GC}_GetObjBy{thisTabProp_TS.ByInFuncName}Cache");
                case WA_F.ReFreshThisCache:
                    return string.Format($"{ThisTabName4GC}_ReFreshThisCache");
                case WA_F.ReFreshCache:
                    return string.Format($"{ThisTabName4GC}_ReFreshCache");
                case WA_F.GetObjLstByJSONObjLst:
                    return string.Format($"{ThisTabName4GC}_GetObjLstByJSONObjLst");
                case WA_F.GetSubObjLstCache:
                    return string.Format($"{ThisTabName4GC}_GetSubObjLstCache");
                case WA_F.GetObjLstAsync:
                    
                    return string.Format($"{ThisTabName4GC}_GetObjLstAsync");
                case WA_F.GetObjLstsessionStorage:
                    return string.Format($"{ThisTabName4GC}_GetObjLstsessionStorage");
                case WA_F.GetObjLstlocalStorage:
                    return string.Format($"{ThisTabName4GC}_GetObjLstlocalStorage");
                case WA_F.GetObjLstClientCache:
                    return string.Format($"{ThisTabName4GC}_GetObjLstClientCache");
                case WA_F.GetObjLstsessionStoragePureCache:
                    return string.Format($"{ThisTabName4GC}_GetObjLstsessionStoragePureCache");
                case WA_F.GetObjLstlocalStoragePureCache:
                    return string.Format($"{ThisTabName4GC}_GetObjLstlocalStoragePureCache");
                case WA_F.SortFunByKey:
                    return string.Format($"{ThisTabName4GC}_SortFunByKey");
                case WA_F.JoinByKeyLst:
                    return string.Format($"{ThisTabName4GC}_JoinByKeyLst");
                case WA_F.GetUniCondStr:
                    return string.Format($"{ThisTabName4GC}_GetUniCondStr");
                case WA_F.GetUniCondStr4Update:
                    return string.Format($"{ThisTabName4GC}_GetUniCondStr4Update");
                case WA_F._CurrTabName:
                    return string.Format($"{ThisClsName4EN}._CurrTabName");
                case WA_F.DelRecordAsync:
                    
                    return string.Format($"{ThisTabName4GC}_DelRecordAsync");
                case WA_F.DelRecKeyLstAsync:
                    
                    return string.Format($"{ThisTabName4GC}_DelRecKeyLstAsync");
                case WA_F.GetMaxStrIdAsync:
                    return string.Format($"{ThisTabName4GC}_GetMaxStrIdAsync");
                case WA_F.GetMaxStrIdByPrefixAsync:
                    return string.Format($"{ThisTabName4GC}_GetMaxStrIdByPrefixAsync");
                case WA_F.DelMultiRecord:

                    return string.Format($"{ThisTabName4GC}_Del{ThisTabName4GC}s");
                case WA_F.DelMultiRecordAsync:
                    return string.Format($"{ThisTabName4GC}_Del{ThisTabName4GC}sAsync");

                case WA_F.DelMultiRecordByCond:

                    return string.Format($"{ThisTabName4GC}_Del{ThisTabName4GC}sByCond");

                case WA_F.DelMultiRecordByCondAsync:
                    return string.Format($"{ThisTabName4GC}_Del{ThisTabName4GC}sByCondAsync");
                case WA_F.DelRecKeyLstsAsync:
                    return string.Format($"{ThisTabName4GC}_DelRecKeyLstsAsync");
                case WA_F.GetObjLstByKeyLstAsync:
                    return string.Format($"{ThisTabName4GC}_GetObjLstBy{objKeyField.FldName}LstAsync");
                case WA_F.GetObjLstByKeyLstsCache://多关键字列表
                    return string.Format($"{ThisTabName4GC}_GetObjLstByKeyLstsCache");
                case WA_F.GetObjLstByKeyLstCache://单关键字列表
                    return string.Format($"{ThisTabName4GC}_GetObjLstBy{objKeyField.FldName}LstCache");
                case WA_F.GetObjLstByPagerCache://单关键字列表
                    return string.Format($"{ThisTabName4GC}_GetObjLstByPagerCache");
                case WA_F.GetRecCountByCondCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                    return string.Format($"{ThisTabName4GC}_GetRecCountByCondCache");
                case WA_F.CheckPropertyNew:
                    return string.Format($"{ThisTabName4GC}_CheckPropertyNew");
                case WA_F.CheckProperty4Update:
                    return string.Format($"{ThisTabName4GC}_CheckProperty4Update");

                case WA_F.AddNewRecordWithMaxIdAsync:
                    return string.Format($"{ThisTabName4GC}_AddNewRecordWithMaxIdAsync");
                case WA_F.IsExistRecordAsync:
                    return string.Format($"{ThisTabName4GC}_IsExistRecordAsync");
                case WA_F.GetRecCountByCondAsync:
                    return string.Format($"{ThisTabName4GC}_GetRecCountByCondAsync");
                case WA_F.GetObjExLstByPagerAsync://在本类中定义的分页函数,返回扩展对象列表
                    AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("cls{0}EN", ThisTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);
                    return string.Format($"{ThisTabName4GC}Ex_GetObjExLstByPagerAsync");
                case WA_F.GetObjLstByPagerAsync://在本类中定义的分页函数,返回扩展对象列表
                    
                    AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("GetObjLstByPagerAsync", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);

                    return string.Format($"{ThisTabName4GC}_GetObjLstByPagerAsync");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }

        public string thisWAEx_F(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format("{0}_GetObjFromJsonObj", ThisTabName4GC);
                case WA_F.GetObjLst_Cache:
                    AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, "GetObjLstCache", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format("{0}_GetObjLstCache", ThisTabName4GC);
                case WA_F.GetObjByKeyId:
                    return string.Format($"{ThisTabName4GC}_GetObjBy{thisTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{ThisTabName4GC}_GetObjBy{thisTabProp_TS.ByInFuncName}Cache");
                case WA_F.ReFreshThisCache:
                    return string.Format($"{ThisTabName4GC}_ReFreshThisCache");
                case WA_F.ReFreshCache:
                    return string.Format($"{ThisTabName4GC}_ReFreshCache");
                case WA_F.GetObjLstByJSONObjLst:
                    return string.Format($"{ThisTabName4GC}_GetObjLstByJSONObjLst");
                case WA_F.GetObjLstAsync:
                    AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, "GetObjLstAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{ThisTabName4GC}_GetObjLstAsync");
                case WA_F.GetObjLstsessionStorage:
                    return string.Format($"{ThisTabName4GC}_GetObjLstsessionStorage");
                case WA_F.GetObjLstlocalStorage:
                    return string.Format($"{ThisTabName4GC}_GetObjLstlocalStorage");
                case WA_F.GetObjLstClientCache:
                    return string.Format($"{ThisTabName4GC}_GetObjLstClientCache");
                case WA_F.GetObjLstsessionStoragePureCache:
                    return string.Format($"{ThisTabName4GC}_GetObjLstsessionStoragePureCache");
                case WA_F.GetObjLstlocalStoragePureCache:
                    return string.Format($"{ThisTabName4GC}_GetObjLstlocalStoragePureCache");
                case WA_F.SortFunByKey:
                    return string.Format($"{ThisTabName4GC}Ex_SortFunByKey");
                case WA_F.FuncMapByFldName:
                    return string.Format($"{ThisTabName4GC}Ex_FuncMapByFldName");
                case WA_F.GetObjLstByPagerCache://需要调用其他类中的分页函数
                    return string.Format($"{ThisTabName4GC}_GetObjLstByPagerCache");
                case WA_F.GetObjExLstByPagerCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                    return string.Format($"{ThisTabName4GC}Ex_GetObjExLstByPagerCache");
                case WA_F.GetObjExLstByPagerAsync://在本类中定义的分页函数,返回扩展对象列表
                    AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("cls{0}EN", ThisTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);
                    return string.Format($"{ThisTabName4GC}Ex_GetObjExLstByPagerAsync");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }


        public string thisWA_F_InEdit(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{TabName_In4Edit4GC}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{TabName_In4Edit4GC}_GetObjLstCache");
                case WA_F.GetObjByKeyId:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, string.Format("GetObjBy{0}Async", thisEditTabProp_TS.ByInFuncName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    return string.Format($"{TabName_In4Edit4GC}_GetObjBy{thisEditTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{TabName_In4Edit4GC}_GetObjBy{thisEditTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetUniCondStr:
                    return string.Format($"{TabName_In4Edit4GC}_GetUniCondStr");
                case WA_F.GetUniCondStr4Update:
                    return string.Format($"{TabName_In4Edit4GC}_GetUniCondStr4Update");
                case WA_F.GetMaxStrIdAsync:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "GetMaxStrIdAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_GetMaxStrIdAsync");
                case WA_F.GetMaxStrIdByPrefixAsync:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "GetMaxStrIdByPrefixAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_GetMaxStrIdByPrefixAsync");
                case WA_F.AddNewRecordAsync:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "AddNewRecordAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_AddNewRecordAsync");
                case WA_F.UpdateRecordAsync:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "UpdateRecordAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_UpdateRecordAsync");
                case WA_F.EditRecordExAsync:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "EditRecordExAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_EditRecordExAsync");
                case WA_F.CheckPropertyNew:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "CheckPropertyNew", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_CheckPropertyNew");

                case WA_F.CheckProperty4Update:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "CheckProperty4Update", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_CheckProperty4Update");

                case WA_F.AddNewRecordWithMaxIdAsync:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "AddNewRecordWithMaxIdAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_AddNewRecordWithMaxIdAsync");
                case WA_F.AddNewRecordWithReturnKeyAsync:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "AddNewRecordWithReturnKeyAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_AddNewRecordWithReturnKeyAsync");
                case WA_F.IsExistRecordAsync:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "IsExistRecordAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_IsExistRecordAsync");
                case WA_F.IsExistAsync:
                    AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "IsExistAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_In4Edit4GC}_IsExistAsync");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }
        public string thisWA_F_InView(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{ViewMainTabName4GC}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{ViewMainTabName4GC}_GetObjLstCache");
                case WA_F.GetObjByKeyId:
                    return string.Format($"{ViewMainTabName4GC}_GetObjBy{thisViewTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{ViewMainTabName4GC}_GetObjBy{thisExcelExportTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetObjLstByJSONObjLst:
                    return string.Format($"{ViewMainTabName4GC}_GetObjLstByJSONObjLst");
                case WA_F.GetObjLstAsync:
                    return string.Format($"{ViewMainTabName4GC}_GetObjLstAsync");
                case WA_F.GetRecCountByCondAsync:
                    return string.Format($"{ViewMainTabName4GC}_GetRecCountByCondAsync");
                case WA_F.DelRecKeyLstAsync:
                    AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("DelRecKeyLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{ViewMainTabName4GC}_DelRecKeyLstAsync");
                case WA_F.DelRecordAsync:
                    AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("DelRecordAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{ViewMainTabName4GC}_DelRecordAsync");
                case WA_F.GoBottomAsync:
                    AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("GoBottomAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{ViewMainTabName4GC}_GoBottomAsync");
                case WA_F.GoTopAsync:
                    AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("GoTopAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{ViewMainTabName4GC}_GoTopAsync");
                case WA_F.ReOrderAsync:
                    AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("ReOrderAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{ViewMainTabName4GC}_ReOrderAsync");
                case WA_F.DownMoveAsync:
                    AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("DownMoveAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{ViewMainTabName4GC}_DownMoveAsync");
                case WA_F.UpMoveAsync:
                    AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("UpMoveAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{ViewMainTabName4GC}_UpMoveAsync");

                    
                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }
        public string thisWA_F_InList(WA_F objFuncName)
        {
            string strTabName_Copy = TabName_Out4ListRegion4GC;
            string strTabId_Copy = TabId_Out4ListRegion;

            if (objPrjTabEx_ListRegion.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                if (strTabName_Copy.Substring(0, 1) != "v")
                {
                    string strMsg = $"界面列表区的表名：{strTabName_Copy}，起始字符不是'v'，请修正！";
                    throw new Exception(strMsg);
                }
                strTabName_Copy = strTabName_Copy.Substring(1);
         var objPrjTab= clsPrjTabBLEx.GetObjByTabNameExCache(objViewInfoENEx.PrjId, strTabName_Copy);
                if (objPrjTab == null)
                {
                    string strMsg = $"界面列表区的视图名的相关表名：{strTabName_Copy}在数据库中不存在，请检查！";
                    throw new Exception(strMsg);
                }
                strTabId_Copy = objPrjTab.TabId;

            }
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstCache");
                case WA_F.GetSubObjLstCache:
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("GetSubObjLstCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetSubObjLstCache");
                case WA_F.GetObjByKeyLstAsync:
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("GetObjByKeyLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjByKeyLstAsync");

                case WA_F.GetObjByKeyId:
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format($"GetObjBy{thisListTabProp_TS.ByInFuncName}Async"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjBy{thisListTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjBy{thisListTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetObjLstByJSONObjLst:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstByJSONObjLst");
                case WA_F.GetObjLstAsync:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstAsync");
                case WA_F.GetRecCountByCondAsync:
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, "GetRecCountByCondAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    return string.Format($"{TabName_Out4ListRegion4GC}_GetRecCountByCondAsync");

                case WA_F.DelRecordAsync:
                    AddImportClass(strTabId_Copy, strTabName_Copy, string.Format("DelRecordAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    return string.Format($"{strTabName_Copy}_DelRecordAsync");
                case WA_F.DelRecKeyLstAsync:
                    AddImportClass(strTabId_Copy, strTabName_Copy, string.Format("DelRecKeyLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    return string.Format($"{strTabName_Copy}_DelRecKeyLstAsync");
                case WA_F.GetObjLstByPagerAsync:
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("GetObjLstByPagerAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstByPagerAsync");
                case WA_F.DelMultiRecordAsync:
                    AddImportClass(strTabId_Copy, strTabName_Copy, string.Format($"Del{strTabName_Copy}sAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{strTabName_Copy}_Del{strTabName_Copy}sAsync");

                case WA_F.DelMultiRecordByCondAsync:
                    AddImportClass(strTabId_Copy, strTabName_Copy, string.Format($"Del{strTabName_Copy}sByCondAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{strTabName_Copy}_Del{strTabName_Copy}sByCondAsync");

                case WA_F.DelRecKeyLstsAsync:
                    AddImportClass(strTabId_Copy, strTabName_Copy, string.Format($"DelRecKeyLstsAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{strTabName_Copy}_DelRecKeyLstsAsync");
                case WA_F.FuncMapByFldName:
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", "FuncMapByFldName", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}Ex_FuncMapByFldName");
                case WA_F.GetMaxStrIdAsync:
                    AddImportClass(strTabId_Copy, strTabName_Copy, "GetMaxStrIdAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{strTabName_Copy}_GetMaxStrIdAsync");
                case WA_F.GetMaxStrIdByPrefixAsync:
                    AddImportClass(TabId_Out4ListRegion, strTabName_Copy, "GetMaxStrIdByPrefixAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{strTabName_Copy}_GetMaxStrIdByPrefixAsync");

                case WA_F.AddNewRecordAsync:
                    AddImportClass(strTabId_Copy, strTabName_Copy, "AddNewRecordAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{strTabName_Copy}_AddNewRecordAsync");
                case WA_F.GetObjLstByKeyLstAsync:
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format($"GetObjLstBy{objKeyField.FldName}LstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstBy{objKeyField.FldName}LstAsync");

                case WA_F.GetObjLstByKeyLstAsync_SqlTab:
                    AddImportClass(strTabId_Copy, strTabName_Copy, string.Format($"GetObjLstBy{objKeyField.FldName}LstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{strTabName_Copy}_GetObjLstBy{objKeyField.FldName}LstAsync");

                case WA_F.GetObjLstByPagerCache://单关键字列表
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format($"GetObjLstByPagerCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstByPagerCache");
                case WA_F.GetObjExLstByPagerCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", string.Format($"GetObjExLstByPagerCache"), enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}Ex_GetObjExLstByPagerCache");
                case WA_F.GetObjExLstByPagerAsync://在本类中定义的分页函数,返回扩展对象列表,Cache
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", string.Format($"GetObjExLstByPagerAsync"), enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}Ex_GetObjExLstByPagerAsync");

                case WA_F.GetRecCountByCondCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format($"GetRecCountByCondCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetRecCountByCondCache");
                case WA_F.CopyToEx:
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", "CopyToEx", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}Ex_CopyToEx");
                case WA_F.SortFunDefa:
                    AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, "SortFunDefa", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ListRegion4GC}_SortFunDefa");


                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }


        public string thisWA_F_InExportExcel(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjLstCache");
                case WA_F.GetSubObjLstCache:
                    AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("GetSubObjLstCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ExportExcel}_GetSubObjLstCache");

                case WA_F.GetObjByKeyId:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjBy{thisExcelExportTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjBy{thisExcelExportTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetObjLstByJSONObjLst:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjLstByJSONObjLst");
                case WA_F.GetObjLstAsync:
                    AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("GetObjLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    return string.Format($"{TabName_Out4ExportExcel}_GetObjLstAsync");
                case WA_F.GetRecCountByCondAsync:
                    AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("GetRecCountByCondAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    return string.Format($"{TabName_Out4ExportExcel}_GetRecCountByCondAsync");
                case WA_F.GetRecCountByCondCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                    AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format($"GetRecCountByCondCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ExportExcel4GC}_GetRecCountByCondCache");
                case WA_F.CopyToEx:
                    AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC + "Ex", "CopyToEx", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4ExportExcel4GC}Ex_CopyToEx");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }

        public string thisWA_F_InDetail(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{TabName_Out4DetailRegion}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{TabName_Out4DetailRegion}_GetObjLstCache");
                case WA_F.GetObjByKeyId:
                    AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion, string.Format("GetObjBy{0}Async", thisDetailTabProp_TS.ByInFuncName), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4DetailRegion}_GetObjBy{thisDetailTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{TabName_Out4DetailRegion}_GetObjBy{thisDetailTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetObjByKeyLstAsync:
                    AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion, string.Format("GetObjByKeyLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4DetailRegion}_GetObjByKeyLstAsync");
                case WA_F.FuncMapByFldName:
                    AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion + "Ex", "FuncMapByFldName", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4DetailRegion}Ex_FuncMapByFldName");
                case WA_F.IsExistAsync:
                    AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion, "IsExistAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);
                    return string.Format($"{TabName_Out4DetailRegion}_IsExistAsync");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }

    }
}
