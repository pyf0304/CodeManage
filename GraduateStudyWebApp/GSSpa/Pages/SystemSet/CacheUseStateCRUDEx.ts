
/*-- -- -- -- -- -- -- -- -- -- --
类名:CacheUseStateCRUDEx
表名:CacheUseState(00050566)
生成代码版本:2020.06.17.1
生成日期:2020/06/20 16:13:38
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { enumCacheMode } from "../TS/L0_Entity/SystemSet/clsCacheModeEN.js";
import { clsCacheUseStateEN } from "../TS/L0_Entity/SystemSet/clsCacheUseStateEN.js";
import { CacheMode_GetObjLst_Cache } from "../TS/L3_ForWApi/SystemSet/clsCacheModeWApi.js";
import { CacheUseState_AddNewRecordAsync, CacheUseState_DelCacheUseStatesByCondAsync, CacheUseState_ReFreshCache } from "../TS/L3_ForWApi/SystemSet/clsCacheUseStateWApi.js";
import { vCacheUseState_GetObjLst_Cache } from "../TS/L3_ForWApi/SystemSet/clsvCacheUseStateWApi.js";
import { CacheHelper } from "../TS/PubFun/CacheHelper.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { CacheUseStateCRUD } from "./CacheUseStateCRUD.js";
declare function ShowDialog_CacheUseState(strOpType): void;
declare function HideDialog_vCacheUseState(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* CacheUseStateCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class CacheUseStateCRUDEx extends CacheUseStateCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvCacheUseStateBy: string = "mId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }


    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: CacheUseStateCRUDEx = new CacheUseStateCRUDEx();
        switch (strCommandName) {
            case "GetCacheUseState":    //查询记录
                objPage.GetCacheUseState();
                break;

            case "ClearLocalStorage":    //查询记录
                objPage.ClearLocalStorage();
                break;

            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage.btnUpdateRecord_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要下移的记录！");
                    return;
                }
                //objPage.btnDownMove_Click();
                break;
            case "ReOrder":            //重序记录
                //objPage.btnReOrder_Click();
                break;
            default:
                var strMsg = '命令:' + strCommandName + "在函数(CacheUseStateCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            CacheUseStateCRUD.UserId_Static = clsPubSessionStorage.GetSession_UserId();

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvCacheUseStateBy = "mId Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCacheUseState_Cache();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
*/
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {
            CacheUseStateCRUD.UserId_Static = clsPubSessionStorage.GetSession_UserId();

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvCacheUseStateBy = "mId Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCacheUseState_Cache();
            const gvResult2 = await this.Subtotals();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }


    public getBytes(str: string): number {
        var len = str.length;
        var bytes = len;
        for (var i = 0; i < len; i++) {
            if (str.charCodeAt(i) > 255) bytes++;
        }
        return bytes;
    }

    public async GetCacheUseState() {
        var strKey;
        var myCache;
        var strCacheKeyLst: string = "";
        var strCondition = clsString.Format("{0}='{1}'", clsCacheUseStateEN.con_UserId, CacheUseStateCRUD.UserId_Static);
        const conDelete = await  CacheUseState_DelCacheUseStatesByCondAsync(strCondition);
        for (var i = 0; i < localStorage.length; i++) {

            strKey = localStorage.key(i)
            if (strKey == null) continue;

            if (clsString.IsNullOrEmpty(strKey) == true) continue;
            strCacheKeyLst += clsString.Format("{0},", strKey);
            //拿到所有含u-的key
            var objCacheUseState: clsCacheUseStateEN = new clsCacheUseStateEN();
            objCacheUseState.cacheKey = strKey;
            objCacheUseState.userId = CacheUseStateCRUD.UserId_Static;

            objCacheUseState.cacheModeId = enumCacheMode.localStorage_03;
            myCache = localStorage.getItem(strKey);
            if (myCache == null) {
                objCacheUseState.cacheSize = 0;
            }
            else {
                objCacheUseState.cacheSize = this.getBytes(myCache);
            }
         const conAdd = await  CacheUseState_AddNewRecordAsync(objCacheUseState);
        }
        for (var i = 0; i < sessionStorage.length; i++) {

            strKey = sessionStorage.key(i)
            if (strKey == null) continue;
            if (clsString.IsNullOrEmpty(strKey) == true) continue;
            strCacheKeyLst += clsString.Format("{0},", strKey);
            //拿到所有含u-的key
            var objCacheUseState: clsCacheUseStateEN = new clsCacheUseStateEN();
            objCacheUseState.cacheKey = strKey;
            objCacheUseState.userId = CacheUseStateCRUD.UserId_Static;

            objCacheUseState.cacheModeId = enumCacheMode.sessionStorage_04;
             myCache = sessionStorage.getItem(strKey);
            if (myCache == null) {
                objCacheUseState.cacheSize = 0;
            }
            else {
                objCacheUseState.cacheSize = this.getBytes(myCache);
            }
            const conAdd = await CacheUseState_AddNewRecordAsync(objCacheUseState);
        }
        for (var i = 0; i < CacheHelper.CacheLength(); i++) {

            strKey = CacheHelper.Key(i)
            if (strKey == null) continue;

            if (clsString.IsNullOrEmpty(strKey) == true) continue;
            strCacheKeyLst += clsString.Format("{0},", strKey);
            //拿到所有含u-的key
            var objCacheUseState: clsCacheUseStateEN = new clsCacheUseStateEN();
            objCacheUseState.cacheKey = strKey;
            objCacheUseState.userId = CacheUseStateCRUD.UserId_Static;

            objCacheUseState.cacheModeId = enumCacheMode.ClientCache_02;
            myCache = CacheHelper.Get(strKey);
            if (myCache == null) {
                objCacheUseState.cacheSize = 0;
            }
            else {
                objCacheUseState.cacheSize = this.getBytes(myCache);
            }
            const conAdd = await CacheUseState_AddNewRecordAsync(objCacheUseState);
        }
        CacheUseState_ReFreshCache(clsPubSessionStorage.GetSession_UserId());
        const gvResult = await this.BindGv_vCacheUseState_Cache();
        const gvResult2 = await this.Subtotals();
        alert(strCacheKeyLst);
        console.log('strCacheKeyLst:', strCacheKeyLst);
    }
    public async Subtotals() {
        var arrvCacheUseStateObjLst = await vCacheUseState_GetObjLst_Cache(clsPubSessionStorage.GetSession_UserId()); 
        var arrCacheMode = await CacheMode_GetObjLst_Cache();
        arrCacheMode.forEach(x => {
            var arr_Sel = arrvCacheUseStateObjLst.filter(y => y.cacheModeId == x.cacheModeId);
            var intTotals = 0;
            if (arr_Sel.length > 0) {
                var data = arr_Sel.map(z => z.cacheSize);
                data.forEach(d => intTotals += d);
//                arr_Sel.reduce((intTotals, item) => intTotals + item.cacheSize, 0);
                intTotals = intTotals / 1024;
                if (x.cacheModeId == enumCacheMode.localStorage_03 || x.cacheModeId == enumCacheMode.sessionStorage_04) {
                    var fltPercent = (intTotals * 100)/ (1024 * 5);                
                    x.memo = clsString.Format("{0}KB, 占 {1} %", intTotals.toFixed(2), fltPercent.toFixed(2));
                }
                else {
                    x.memo = clsString.Format("{0}KB", intTotals.toFixed(2));
                }
            }
            if (intTotals > 0) {
                switch (x.cacheModeId) {
                    case enumCacheMode.ClientCache_02:
                        var txtClientCache: HTMLInputElement = <HTMLInputElement>document.getElementById('txtClientCache');
                        if (txtClientCache != null) {
                            txtClientCache.value = x.memo;
                        }
                        break;
                    case enumCacheMode.localStorage_03:
                        var txtlocalStorage: HTMLInputElement = <HTMLInputElement>document.getElementById('txtlocalStorage');
                        if (txtlocalStorage != null) {
                            txtlocalStorage.value = x.memo;
                        }
                        break;
                    case enumCacheMode.sessionStorage_04:
                        var txtsessionStorage: HTMLInputElement = <HTMLInputElement>document.getElementById('txtsessionStorage');
                        if (txtsessionStorage != null) {
                            txtsessionStorage.value = x.memo;
                        }
                        break;
                }
            }
        });
    }
    public ClearLocalStorage() {
        var arrCacheKeyLst: Array<string> = new Array<string>();
        for (var i = 0; i < localStorage.length; i++) {

            var strKey = localStorage.key(i)
            if (strKey != null) {
                arrCacheKeyLst.push(strKey);
            }
            //拿到所有含u-的key
        }
        //        alert(strCacheKeyLst);
        arrCacheKeyLst.forEach(x => localStorage.removeItem(x));

    }
}