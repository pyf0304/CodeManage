
/*-- -- -- -- -- -- -- -- -- -- --
类名:CacheUseStateCRUD
表名:CacheUseState(00050566)
生成代码版本:2020.06.27.2
生成日期:2020/07/03 04:23:25
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsCacheUseStateEN } from "../TS/L0_Entity/SystemSet/clsCacheUseStateEN.js";
import { clsvCacheUseStateEN } from "../TS/L0_Entity/SystemSet/clsvCacheUseStateEN.js";
import { CacheMode_BindDdl_CacheModeIdInDiv_Cache } from "../TS/L3_ForWApi/SystemSet/clsCacheModeWApi.js";
import { CacheUseState_AddNewRecordAsync, CacheUseState_DelCacheUseStatesAsync, CacheUseState_DelRecordAsync, CacheUseState_GetObjBymIdAsync, CacheUseState_IsExistAsync, CacheUseState_ReFreshCache, CacheUseState_UpdateRecordAsync } from "../TS/L3_ForWApi/SystemSet/clsCacheUseStateWApi.js";
import { vCacheUseState_GetObjBymIdAsync, vCacheUseState_GetObjLstAsync, vCacheUseState_GetObjLstByPager_Cache, vCacheUseState_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/SystemSet/clsvCacheUseStateWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_CacheUseState(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_CacheUseState(): void;
/*
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
*/
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
declare var $;
declare var window;
/* CacheUseStateCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class CacheUseStateCRUD implements clsOperateList {
    public static UserId_Static: string = "0";
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public bolIsLoadDetailRegion: boolean = false;  //记录是否导入详细信息区的变量
    public divName4Edit: string = "divEdit";  //编辑区的Id
    public divName4Detail: string = "divDetail";  //详细信息区的Id

    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;


    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        var strUrl: string = "./CacheUseState_Edit/";
        console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Edit).html(data);
                    resolve(true);
                    //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                    //clsEditObj.BindTab();
                },
                error: (e) => {
                    console.error(e);
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Detail)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Detail(divName4Detail) {
        var strUrl: string = "./vCacheUseState_Detail/";
        console.log("divName4Detail:(In AddDPV_Detail)" + divName4Detail);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Detail).html(data);
                    resolve(true);
                    //setTimeout(() => { clsDetailObj.BindTab(); }, 100);
                    //clsDetailObj.BindTab();
                },
                error: (e) => {
                    console.error(e);
                    reject(e);
                }
            });
        });
    };

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
   */
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvCacheUseStateBy = "mId Asc";
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCacheUseState_Cache();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    public async btnQuery_Click() {
        var objvCacheUseState_Cond = this.CombinevCacheUseStateConditionObj();
        var strWhereCond = JSON.stringify(objvCacheUseState_Cond);
        try {
            this.RecCount = await vCacheUseState_GetRecCountByCond_Cache(objvCacheUseState_Cond, clsPubSessionStorage.GetSession_UserId());
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvCacheUseStateBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vCacheUseState_GetObjLstByPager_Cache(objPagerPara, clsPubSessionStorage.GetSession_UserId()).then((jsonData) => {
                var arrvCacheUseStateObjLst: Array<clsvCacheUseStateEN> = <Array<clsvCacheUseStateEN>>jsonData;
                this.BindTab_vCacheUseState(this.mstrListDiv, arrvCacheUseStateObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `查询不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.OpType = "Add";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog_CacheUseState('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog_CacheUseState('Add');
                const responseText = await this.AddNewRecord();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
   */
    public async btnAddNewRecordWithMaxId_Click() {
        this.OpType = "AddWithMaxId";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog_CacheUseState('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecordWithMaxId();
            }
            else {
                ShowDialog_CacheUseState('Add');
                const responseText = this.AddNewRecordWithMaxId();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
   */
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面

        const ddlCacheModeId = await CacheMode_BindDdl_CacheModeIdInDiv_Cache(this.divName4List, "ddlCacheModeId");//编辑区域
    }


    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面        
        const ddlCacheModeId_q = await CacheMode_BindDdl_CacheModeIdInDiv_Cache(this.divName4List, "ddlCacheModeId_q");//查询区域
    }


    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
        this.OpType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            ShowDialog_CacheUseState('Update');
            this.bolIsLoadEditRegion = true;  //
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        else {
            ShowDialog_CacheUseState('Update');
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
    }

    /* 
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelRecord(lngKeyId);
            const responseBindGv = await this.BindGv_vCacheUseState_Cache();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    在数据表里选择记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
   */
    public async btnSelectRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            this.SelectRecord(lngKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `选择记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    在数据表里详细信息记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
   */
    public async btnDetailRecordInTab_Click(strKeyId: string) {
        this.OpType = "Detail";
        try {
            if (strKeyId == "") {
                alert("请选择需要详细信息的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            this.DetailRecord(lngKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `详细信息记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord(lngmId: number) {
        try {
            const responseText = await CacheUseState_DelRecordAsync(lngmId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                CacheUseState_ReFreshCache(clsPubSessionStorage.GetSession_UserId());
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelRecord!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字详细信息记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
     <param name = "sender">参数列表</param>
   */
    public async DetailRecord(lngmId: number) {
        this.btnSubmit_d_vCacheUseState = "";
        this.btnCancel_d_vCacheUseState = "关闭";
        try {
            const responseText = await vCacheUseState_GetObjBymIdAsync(lngmId);
            var objvCacheUseStateEN: clsvCacheUseStateEN = <clsvCacheUseStateEN>responseText;
            this.ShowDetailDataFromvCacheUseStateClass(objvCacheUseStateEN);
            console.log("完成DetailRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字选择相应的记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
     <param name = "sender">参数列表</param>
   */
    public async SelectRecord(lngmId: number) {
        try {
            const responseText = await CacheUseState_GetObjBymIdAsync(lngmId);
            var objCacheUseStateEN: clsCacheUseStateEN = <clsCacheUseStateEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_vCacheUseState");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
   */
    public async btnUpdateRecord_Click(strKeyId: string) {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            ShowDialog_CacheUseState('Update');
            this.bolIsLoadEditRegion = true;  //
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        else {
            ShowDialog_CacheUseState('Update');
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecord_Click)
   */
    public async btnDetailRecord_Click(strKeyId: string) {
        this.OpType_d = "Detail";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadDetailRegion == false)  //
        {
            const responseBool = await this.AddDPV_Detail(this.divName4Detail);
            // 为编辑区绑定下拉框
            //const conBindDdl = await this.BindDdl4DetailRegion();
            ShowDialog_CacheUseState('Detail');
            this.bolIsLoadDetailRegion = true;  //
            var lngKeyId = Number(strKeyId);
            this.DetailRecord(lngKeyId);
        }
        else {
            ShowDialog_CacheUseState('Detail');
            var lngKeyId = Number(strKeyId);
            this.DetailRecord(lngKeyId);
        }
    }

    /* 删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
   */
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vCacheUseState_Cache();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
   */
    public async btnExportExcel_Click() {
        var strWhereCond = " 1=1 ";
        try {
            const responseText = await vCacheUseState_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrvCacheUseStateObjLst: Array<clsvCacheUseStateEN> = <Array<clsvCacheUseStateEN>>jsonData;
                this.BindTab_vCacheUseState(this.mstrListDiv, arrvCacheUseStateObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `导出Excel不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_CacheUseState;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    if (this.OpType == "AddWithMaxId") {
                        //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                        //var returnBool2: boolean = jsonData;
                        //if (returnBool2 == true)
                        //{
                        //HideDialog_CacheUseState();
                        //this.BindGv_vCacheUseState_Cache();
                        //}
                        //});
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog_CacheUseState();
                                this.BindGv_vCacheUseState_Cache();
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In CacheUseStateCRUD.btnSubmit_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog_CacheUseState();
                            this.BindGv_vCacheUseState_Cache();
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevCacheUseStateCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        strWhereCond += `userId =${CacheUseStateCRUD.UserId_Static}`;
        try {
            if (this.CacheModeId_q != "" && this.CacheModeId_q != "0") {
                strWhereCond += ` And ${clsvCacheUseStateEN.con_CacheModeId} = '${this.CacheModeId_q}'`;
            }
            if (this.CacheKey_q != "") {
                strWhereCond += ` And ${clsvCacheUseStateEN.con_CacheKey} like '% ${this.CacheKey_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineCacheUseStateCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevCacheUseStateConditionObj(): clsvCacheUseStateEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvCacheUseState_Cond: clsvCacheUseStateEN = new clsvCacheUseStateEN();
        objvCacheUseState_Cond.SetCondFldValue(clsvCacheUseStateEN.con_UserId, CacheUseStateCRUD.UserId_Static, "=");
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.CacheModeId_q != "" && this.CacheModeId_q != "0") {
                strWhereCond += ` And ${clsvCacheUseStateEN.con_CacheModeId} = '${this.CacheModeId_q}'`;
                objvCacheUseState_Cond.SetCondFldValue(clsvCacheUseStateEN.con_CacheModeId, this.CacheModeId_q, "=");
            }
            if (this.CacheKey_q != "") {
                strWhereCond += ` And ${clsvCacheUseStateEN.con_CacheKey} like '% ${this.CacheKey_q}%'`;
                objvCacheUseState_Cond.SetCondFldValue(clsvCacheUseStateEN.con_CacheKey, this.CacheKey_q, "like");
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0008)在组合查询条件对象(CombineCacheUseStateConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvCacheUseState_Cond;
    }

    /* 显示vCacheUseState对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrCacheUseStateObjLst">需要绑定的对象列表</param>
   */
    public BindTab_vCacheUseState(divContainer: string, arrvCacheUseStateObjLst: Array<clsvCacheUseStateEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "mId",
                    ColHeader: "mId",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cacheModeName",
                    ColHeader: "缓存方式名",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cacheModeENName",
                    ColHeader: "缓存方式英文名",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cacheKey",
                    ColHeader: "缓存关键字",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cacheSize",
                    ColHeader: "缓存大小",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "memo",
                    ColHeader: "说明",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userId",
                    ColHeader: "用户Id",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvCacheUseStateObjLst, arrDataColumn, "mId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /* 函数功能:在数据 列表中跳转到某一页
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
   */
    public async IndexPage(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_vCacheUseState_Cache();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
   */
    public async BindGv_vCacheUseState_Cache() {
        var strListDiv: string = this.mstrListDiv;
        var objvCacheUseState_Cond = this.CombinevCacheUseStateConditionObj();
        var strWhereCond = JSON.stringify(objvCacheUseState_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvCacheUseStateObjLst: Array<clsvCacheUseStateEN> = [];
        try {
            this.RecCount = await vCacheUseState_GetRecCountByCond_Cache(objvCacheUseState_Cond, clsPubSessionStorage.GetSession_UserId());
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvCacheUseStateBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrvCacheUseStateObjLst = await vCacheUseState_GetObjLstByPager_Cache(objPagerPara, clsPubSessionStorage.GetSession_UserId());
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
            return;
        }
        if (arrvCacheUseStateObjLst.length == 0) {
            var strKey: string = `${clsvCacheUseStateEN._CurrTabName}_${clsPubSessionStorage.GetSession_UserId()}`;
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vCacheUseState(strListDiv, arrvCacheUseStateObjLst);
            console.log("完成BindGv_vCacheUseState!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:从界面列表中根据某一个字段排序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     <param name = "strSortByFld">排序的字段</param>
   */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvCacheUseStateBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvCacheUseStateBy.indexOf("Asc") >= 0) {
                this.hidSortvCacheUseStateBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvCacheUseStateBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvCacheUseStateBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vCacheUseState_Cache();
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
    }

    // /* 获取当前表关键字值的最大值,再加1,避免重复
    //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
    //*/
    //public async GetMaxStrId(strKeyCtrlName) {
    //this.DivName = "divGetMaxStrId";
    //try
    //{
    //const responseText = await CacheUseState_GetMaxStrIdAsync();
    //var returnString: string = responseText.toString();
    //if (returnString == "")
    //{
    //var strInfo: string = `获取表CacheUseState的最大关键字为空，不成功，请检查!`;
    //$('#lblResult40').val(strInfo);
    ////显示信息框
    //alert(strInfo);
    // $(strKeyCtrlName).val(returnString);
    //}
    //else
    //{
    //var strInfo: string = `获取表CacheUseState的最大关键字为：${returnString}!`;
    //$('#lblResult40').val(strInfo);
    ////显示信息框
    //alert(strInfo);
    // $(strKeyCtrlName).val(returnString);
    //}
    //}
    //catch(e)
    //{
    //console.error('catch(e)=');
    //console.error(e);
    //var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
    //alert(strMsg);
    //}
    //}

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        this.btnSubmit_CacheUseState = "确认添加";
        this.btnCancel_CacheUseState = "取消添加";
        this.Clear();
        //wucCacheUseStateB1.mId = clsCacheUseStateBL.GetMaxStrId_S();
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.btnSubmit_CacheUseState = "确认添加";
        this.btnCancel_CacheUseState = "取消添加";
        this.Clear();
        //wucCacheUseStateB1.mId = clsCacheUseStateBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjCacheUseStateEN">数据传输的目的类对象</param>
   */
    public PutDataToCacheUseStateClass(pobjCacheUseStateEN: clsCacheUseStateEN) {
        pobjCacheUseStateEN.cacheModeId = this.cacheModeId;// 缓存方式Id
        pobjCacheUseStateEN.cacheKey = this.cacheKey;// 缓存关键字
        pobjCacheUseStateEN.cacheSize = this.cacheSize;// 缓存大小
        pobjCacheUseStateEN.memo = this.memo;// 说明
        pobjCacheUseStateEN.userId = CacheUseStateCRUD.UserId_Static;// 用户Id
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objCacheUseStateEN: clsCacheUseStateEN = new clsCacheUseStateEN();
        this.PutDataToCacheUseStateClass(objCacheUseStateEN);
        try {
            const responseText2 = await CacheUseState_AddNewRecordAsync(objCacheUseStateEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                CacheUseState_ReFreshCache(clsPubSessionStorage.GetSession_UserId());
                var strInfo: string = `添加记录成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
    }

    /* 函数功能:把以该关键字的记录内容显示在界面上,
          在这里是把值传到表控件中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
     <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(lngmId: number) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objCacheUseStateEN: clsCacheUseStateEN = new clsCacheUseStateEN();
        try {
            const responseText = await CacheUseState_IsExistAsync(lngmId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${lngmId}] 的记录不存在!`;
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
            }
        }
        catch (e) {
            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
            alert(strMsg);
        }
        try {
            const responseText = await CacheUseState_GetObjBymIdAsync(lngmId);
            objCacheUseStateEN = <clsCacheUseStateEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromCacheUseStateClass(objCacheUseStateEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjCacheUseStateEN">表实体类对象</param>
   */
    public GetDataFromCacheUseStateClass(pobjCacheUseStateEN: clsCacheUseStateEN) {
        this.cacheModeId = pobjCacheUseStateEN.cacheModeId;// 缓存方式Id
        this.cacheKey = pobjCacheUseStateEN.cacheKey;// 缓存关键字
        this.cacheSize = pobjCacheUseStateEN.cacheSize;// 缓存大小
        this.memo = pobjCacheUseStateEN.memo;// 说明
        this.userId = pobjCacheUseStateEN.userId;// 用户Id
    }

    /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
     <param name = "pobjCacheUseStateEN">表实体类对象</param>
   */
    public ShowDetailDataFromvCacheUseStateClass(pobjvCacheUseStateEN: clsvCacheUseStateEN) {
        this.UserId_d = pobjvCacheUseStateEN.userId;// 用户Id
        this.CacheModeName_d = pobjvCacheUseStateEN.cacheModeName;// 缓存方式名
        this.CacheModeENName_d = pobjvCacheUseStateEN.cacheModeENName;// 缓存方式英文名
        this.CacheKey_d = pobjvCacheUseStateEN.cacheKey;// 缓存关键字
        this.CacheSize_d = pobjvCacheUseStateEN.cacheSize;// 缓存大小
        this.Memo_d = pobjvCacheUseStateEN.memo;// 说明
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(lngmId: number) {
        this.btnSubmit_CacheUseState = "确认修改";
        this.btnCancel_CacheUseState = "取消修改";
        this.KeyId = lngmId.toString();
        try {
            const responseText = await CacheUseState_GetObjBymIdAsync(lngmId);
            var objCacheUseStateEN: clsCacheUseStateEN = <clsCacheUseStateEN>responseText;
            this.GetDataFromCacheUseStateClass(objCacheUseStateEN);
            console.log("完成UpdateRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public async UpdateRecordSave() {
        this.DivName = "divUpdateRecordSave";
        var objCacheUseStateEN: clsCacheUseStateEN = new clsCacheUseStateEN();
        objCacheUseStateEN.mId = Number(this.KeyId);
        this.PutDataToCacheUseStateClass(objCacheUseStateEN);
        objCacheUseStateEN.sf_UpdFldSetStr = objCacheUseStateEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objCacheUseStateEN.mId == 0 || objCacheUseStateEN.mId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await CacheUseState_UpdateRecordAsync(objCacheUseStateEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                CacheUseState_ReFreshCache(clsPubSessionStorage.GetSession_UserId());
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }

    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public async DelMultiRecord(arrmId: Array<string>) {
        try {
            const responseText = await CacheUseState_DelCacheUseStatesAsync(arrmId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                CacheUseState_ReFreshCache(clsPubSessionStorage.GetSession_UserId());
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelMultiRecord!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 显示{0}对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
     <param name = "divContainer">显示容器</param>
     <param name = "objCacheUseState">需要显示的对象</param>
   */
    public ShowCacheUseStateObj(divContainer: string, objCacheUseState: clsCacheUseStateEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objCacheUseState);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objCacheUseState[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjCacheUseStateEN">表实体类对象</param>
    <returns>列表的第一个关键字值</returns>
   */
    public GetFirstKey(): string {
        if (arrSelectedKeys.length == 1) {
            return arrSelectedKeys[0];
        }
        else {
            alert(`请选择一个关键字！目前选择了:${arrSelectedKeys.length}个关键字。`);
            return "";
        }
    }

    /*
    演示Session 操作
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
    */
    public async Demo_Session() {
        try {
            //设置Session
            var strUserId = "TestUserId";
            await this.SetSessionAsync("userId", strUserId);
            //获取Session
            var strUserId_Value1 = await this.GetSessionAsync("userId");
            console.log('strUserId_Value1:' + strUserId_Value1);
            //获取Session方法2：直接读取页面中的hidUserId
            var strUserId_Value2 = this.hidUserId;
            console.log('strUserId_Value2:' + strUserId_Value2);
        }
        catch (e) {
            var strMsg: string = `演示Session不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*
    设置Session
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
    <param name = "Key">关键字</param>
    <param name = "Value">值</param>
    */
    public SetSessionAsync(Key: string, Value: string): Promise<void> {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl_Session_SetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                    Value: Value
                },
                success: function (data) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log('strKey, strValue=' + strKey + strValue);
                }
            });
        });
    }

    /*
    获取Session 关键字的值
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
    <param name = "Key">关键字</param>
     <return>值</return>
    */
    public GetSessionAsync(Key: string): Promise<string> {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl_Session_GetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                },
                success: function (data) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log('strKey, strValue=' + strKey + strValue);
                    resolve(data);
                },
                error: function (result) {
                    console.log(result);
                    console.log(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问网络不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }
    /*
    * 设置取消按钮的标题(Used In AddNewRecord())
   */
    public set btnCancel_CacheUseState(value: string) {
        $("#btnCancel_CacheUseState").html(value);
    }
    /*
    * 设置取消按钮的标题(Used In DetailRecord())
   */
    public set btnCancel_d_vCacheUseState(value: string) {
        $("#btnCancel_d_vCacheUseState").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnSubmit_CacheUseState(): string {
        return $("#btnSubmit_CacheUseState").html();
    }
    /*
    * 设置确定按钮的标题(Used In AddNewRecord())
   */
    public set btnSubmit_CacheUseState(value: string) {
        $("#btnSubmit_CacheUseState").html(value);
    }
    /*
    * 设置确定按钮的标题(Used In DetailRecord())
   */
    public set btnSubmit_d_vCacheUseState(value: string) {
        $("#btnSubmit_d_vCacheUseState").html(value);
    }
    /*
    * 缓存关键字 (Used In Clear())
   */
    public set cacheKey(value: string) {
        $("#txtCacheKey").val(value);
    }
    /*
    * 缓存关键字 (Used In PutDataToClass())
   */
    public get cacheKey(): string {
        return $("#txtCacheKey").val();
    }
    /*
    * 缓存关键字 (Used In ShowDetailDataFromClass())
   */
    public set CacheKey_d(value: string) {
        $("#lblCacheKey_d").html(value);
    }
    /*
    * 缓存关键字 (Used In CombineCondition())
   */
    public get CacheKey_q(): string {
        return $("#txtCacheKey_q").val();
    }
    /*
    * 缓存方式英文名 (Used In ShowDetailDataFromClass())
   */
    public set CacheModeENName_d(value: string) {
        $("#lblCacheModeENName_d").html(value);
    }
    /*
    * 缓存方式Id (Used In Clear())
   */
    public set cacheModeId(value: string) {
        $("#ddlCacheModeId").val(value);
    }
    /*
    * 缓存方式Id (Used In PutDataToClass())
   */
    public get cacheModeId(): string {
        return $("#ddlCacheModeId").val();
    }
    /*
    * 缓存方式Id (Used In CombineCondition())
   */
    public get CacheModeId_q(): string {
        return $("#ddlCacheModeId_q").val();
    }
    /*
    * 缓存方式名 (Used In ShowDetailDataFromClass())
   */
    public set CacheModeName_d(value: string) {
        $("#lblCacheModeName_d").html(value);
    }
    /*
    * 缓存大小 (Used In Clear())
   */
    public set cacheSize(value: number) {
        $("#txtCacheSize").val(value);
    }
    /*
    * 缓存大小 (Used In PutDataToClass())
   */
    public get cacheSize(): number {
        return $("#txtCacheSize").val();
    }
    /*
    * 缓存大小 (Used In ShowDetailDataFromClass())
   */
    public set CacheSize_d(value: number) {
        $("#lblCacheSize_d").html(value);
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 获取当前页序号(Used In BindGv_Cache)
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvCacheUseStateBy(value: string) {
        $("#hidSortvCacheUseStateBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvCacheUseStateBy(): string {
        return $("#hidSortvCacheUseStateBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return $("#hidUserId").val();
    }
    /*
    * 设置关键字的值(Used In UpdateRecord())
   */
    public set KeyId(value: string) {
        $("#hidKeyId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get KeyId(): string {
        return $("#hidKeyId").val();
    }
    /*
    * 说明 (Used In Clear())
   */
    public set memo(value: string) {
        $("#txtMemo").val(value);
    }
    /*
    * 说明 (Used In PutDataToClass())
   */
    public get memo(): string {
        return $("#txtMemo").val();
    }
    /*
    * 说明 (Used In ShowDetailDataFromClass())
   */
    public set Memo_d(value: string) {
        $("#lblMemo_d").html(value);
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set OpType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public get OpType(): string {
        return $("#hidOpType").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set OpType_d(value: string) {
        $("#hidOpType_d").val(value);
    }
    /*
    * 用户Id (Used In Clear())
   */
    public set userId(value: string) {
        //界面变量(ViewVariable)
        var strKey: string = `varUserId`;
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            sessionStorage.removeItem(strKey);
        }
        sessionStorage.setItem(strKey, value.toString());
    }
    /*
    * 用户Id (Used In ShowDetailDataFromClass())
   */
    public set UserId_d(value: string) {
        $("#lblUserId_d").html(value);
    }
    /*
    * 用户Id (Used In CombineCondition())
   */
    public get UserId_q(): string {
        //界面变量(ViewVariable)
        var strKey: string = `varUserId_q`;
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strValue: string = sessionStorage.getItem(strKey) as string;
            return strValue;
        }
        return "";
    }
}