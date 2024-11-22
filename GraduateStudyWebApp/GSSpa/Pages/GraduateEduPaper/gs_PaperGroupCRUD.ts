﻿
/**
* 类名:gs_PaperGroupCRUD(界面:gs_PaperGroupCRUD)
* 表名:gs_PaperGroup(01120749)
* 生成代码版本:2021.10.18.1
* 生成日期:2021/10/24 11:25:45
* 生成者:
* 工程名称:问卷调查
* 工程ID:0112
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培论文
* 模块英文名:GraduateEduPaper
* 框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
* 编程语言:TypeScript
**/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsgs_PaperGroupEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { gs_PaperGroup_AddNewRecordAsync, gs_PaperGroup_Delgs_PaperGroupsAsync, gs_PaperGroup_DelRecordAsync, gs_PaperGroup_DownMoveAsync, gs_PaperGroup_GetMaxStrIdAsync, gs_PaperGroup_GetObjByPaperGroupIdAsync, gs_PaperGroup_GetObjLstAsync, gs_PaperGroup_GetObjLstByPagerAsync, gs_PaperGroup_GetObjLstByPager_Cache, gs_PaperGroup_GetObjLstByPaperGroupIdLstAsync, gs_PaperGroup_GetRecCountByCondAsync, gs_PaperGroup_GetRecCountByCond_Cache, gs_PaperGroup_GetSubObjLst_Cache, gs_PaperGroup_GoBottomAsync, gs_PaperGroup_GoTopAsync, gs_PaperGroup_ReOrderAsync, gs_PaperGroup_SortFun_Defa, gs_PaperGroup_UpMoveAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { clsOrderByData } from "../TS/PubFun/clsOrderByData.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/**
* 宣布一个用于导出Excel的函数，用于调用js端的导出Excel。
**/
declare function exportSpecialExcel_pyf(arrData, strFileName): void;
/**
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
 **/
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
/**
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
 **/
declare var strCurrPrjId;
declare var $;
/** gs_PaperGroupCRUD 的摘要说明。其中Q代表查询,U代表修改
* (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
**/
export abstract class gs_PaperGroupCRUD implements clsOperateList {
    public static objPage_CRUD: gs_PaperGroupCRUD;
    public static strUpdUser_Cache = "99999999999999999991";//缓存分类字段
    public divName4Query = "divQuery";  //查询区的层Id
    public divName4Function = "divFunction";  //功能区的层Id
    public divName4Layout = "divLayout";  //界面布局的层Id
    constructor() {
        super();
        gs_PaperGroupCRUD.objPage_CRUD = this;
    }
    /**
    * 每页记录数，在扩展类可以修改
    **/
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;





    /** 函数功能:页面导入,当页面开始运行时所发生的事件
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    **/
    public async Page_Load() {
        const strThisFuncName = this.Page_Load.name;
        // 在此处放置用户代码以初始化页面
        try {
            this.SetEventFunc();
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortgs_PaperGroupBy = "paperGroupId Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_gs_PaperGroup();
        }
        catch (e) {
            const strMsg = clsString.Format("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }


    /** 函数功能:设置事件函数
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
    **/
    public async SetEventFunc() {
        const strThisFuncName = this.SetEventFunc.name;
        // 在此处放置用户代码以初始化页面
        try {
            //没有定义相关事件
        }
        catch (e) {
            const strMsg = clsString.Format("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }


    /** 函数功能:页面导入,当页面开始运行时所发生的事件
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
    **/
    public async Page_Load_Cache() {
        const strThisFuncName = this.Page_Load_Cache.name;
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.SetEventFunc();
            this.hidSortgs_PaperGroupBy = "paperGroupId Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_gs_PaperGroup();
        }
        catch (e) {
            const strMsg = clsString.Format("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }


    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    **/
    public async btnQuery_Click() {
        const strThisFuncName = this.btnQuery_Click.name;
        console.log('strThisFuncName', strThisFuncName);
        this.setCurrPageIndex(1, this.divName4Pager);
        const responseBindGv = await this.BindGv_gs_PaperGroup();
    }

    /** 合并数据
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
    **/
    public CombineData(arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN>, arrDataColumn: Array<clsDataColumn>) {
        const strThisFuncName = this.CombineData.name;
        console.log('strThisFuncName', strThisFuncName);
        const intRowNum = arrgs_PaperGroupObjLst.length;
        const intColNum = arrDataColumn.length;
        const arrData: Array<Array<any>> = new Array<Array<any>>();
        const arrHead: Array<any> = new Array<any>();
        for (let j = 0; j < intColNum; j++) {
            arrHead.push(arrDataColumn[j].ColHeader);
        }
        arrData.push(arrHead);
        for (let i = 0; i < intRowNum; i++) {
            const arrRow: Array<any> = new Array<any>();
            const objEN: clsgs_PaperGroupEN = arrgs_PaperGroupObjLst[i];
            for (let j = 0; j < intColNum; j++) {
                arrRow.push(objEN[arrDataColumn[j].FldName]);//i + "" + j;
            }
            arrData.push(arrRow);
        }
        console.log("arrData", arrData);
        const strFileName = clsString.Format("论文分组({0})导出.xlsx",
            clsgs_PaperGroupEN._CurrTabName);
        exportSpecialExcel_pyf(arrData, strFileName);
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
    **/
    public async ExportExcel_gs_PaperGroup() {
        const strThisFuncName = this.ExportExcel_gs_PaperGroup.name;
        if (this.hidSortgs_PaperGroupBy == null) {
            const strMsg = clsString.Format("在显示列表时，排序字段(hidSortgs_PaperGroupBy)为空，请检查！(In BindGv_gs_PaperGroup_Cache)");
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        const strListDiv: string = this.mstrListDiv;
        const strWhereCond = this.Combinegs_PaperGroupCondition();
        const intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        let arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = [];
        try {
            this.RecCount = await gs_PaperGroup_GetRecCountByCondAsync(strWhereCond);
            if (this.RecCount == 0) {
                const lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
                lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
                const divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strMsg = clsString.Format("在绑定ExportExcel过程中，根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            arrgs_PaperGroupObjLst = await gs_PaperGroup_GetObjLstAsync(strWhereCond);
        }
        catch (e) {
            const strMsg = clsString.Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        if (arrgs_PaperGroupObjLst.length == 0) {
            const strMsg = clsString.Format("在ExportExcel过程中，根据条件获取的记录数为0！");
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            const arrDataColumn: Array<clsDataColumn> =
                [
                    {
                        FldName: "paperGroupId",
                        SortBy: "",
                        ColHeader: "组Id",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 2,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "paperGroupName",
                        SortBy: "",
                        ColHeader: "组名",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 3,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "updUser",
                        SortBy: "",
                        ColHeader: "修改人",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 4,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "orderNum",
                        SortBy: "",
                        ColHeader: "序号",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 5,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "updDate",
                        SortBy: "",
                        ColHeader: "修改日期",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 6,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "meno",
                        SortBy: "",
                        ColHeader: "备注",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 7,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
            arrgs_PaperGroupObjLst = arrgs_PaperGroupObjLst.sort(this.SortFun_ExportExcel);
            this.CombineData(arrgs_PaperGroupObjLst, arrDataColumn);
            console.log("完成BindGv_gs_PaperGroup!");
        }
        catch (e) {
            const strMsg = clsString.Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel_Cache)
    **/
    public async ExportExcel_gs_PaperGroup_Cache() {
        const strThisFuncName = this.ExportExcel_gs_PaperGroup_Cache.name;
        if (this.hidSortgs_PaperGroupBy == null) {
            const strMsg = clsString.Format("在显示列表时，排序字段(hidSortgs_PaperGroupBy)为空，请检查！(In BindGv_gs_PaperGroup_Cache)");
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        const strListDiv: string = this.mstrListDiv;
        const objgs_PaperGroup_Cond = this.Combinegs_PaperGroupConditionObj4ExportExcel();
        objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN.con_UpdUser, gs_PaperGroupCRUD.strUpdUser_Cache, "=");
        const strWhereCond = JSON.stringify(objgs_PaperGroup_Cond);
        const intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        let arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = [];
        try {
            this.RecCount = await gs_PaperGroup_GetRecCountByCond_Cache(objgs_PaperGroup_Cond, gs_PaperGroupCRUD.strUpdUser_Cache);
            if (this.RecCount == 0) {
                const lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
                lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objgs_PaperGroup_Cond.whereCond);
                const divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strMsg = clsString.Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objgs_PaperGroup_Cond.whereCond);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            arrgs_PaperGroupObjLst = await gs_PaperGroup_GetSubObjLst_Cache(objgs_PaperGroup_Cond, gs_PaperGroupCRUD.strUpdUser_Cache);
        }
        catch (e) {
            const strMsg = clsString.Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        if (arrgs_PaperGroupObjLst.length == 0) {
            const strKey = clsString.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, gs_PaperGroupCRUD.strUpdUser_Cache);
            const strMsg = clsString.Format("根据条件获取的记录数为0！(Key={0})", strKey);
            console.error("Error: ", strMsg);
            //console.trace();
            this.ShowEmptyRecNumInfo(strListDiv, strMsg);
            this.objPager.Hide(this.divName4Pager);
            return;
        }
        try {
            const arrDataColumn: Array<clsDataColumn> =
                [
                    {
                        FldName: "paperGroupId",
                        SortBy: "",
                        ColHeader: "组Id",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 2,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "paperGroupName",
                        SortBy: "",
                        ColHeader: "组名",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 3,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "updUser",
                        SortBy: "",
                        ColHeader: "修改人",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 4,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "orderNum",
                        SortBy: "",
                        ColHeader: "序号",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 5,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "updDate",
                        SortBy: "",
                        ColHeader: "修改日期",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 6,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        FldName: "meno",
                        SortBy: "",
                        ColHeader: "备注",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 7,
                        FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
            arrgs_PaperGroupObjLst = arrgs_PaperGroupObjLst.sort(this.SortFun_ExportExcel);
            this.CombineData(arrgs_PaperGroupObjLst, arrDataColumn);
            console.log("完成BindGv_gs_PaperGroup!");
        }
        catch (e) {
            const strMsg = clsString.Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 函数功能:为查询区绑定下拉框
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
    **/
    public async BindDdl4QueryRegion() {
        const strThisFuncName = this.BindDdl4QueryRegion.name;
        console.log('strThisFuncName', strThisFuncName);
        // 在此处放置用户代码以初始化页面
    }


    /**
    * 重序
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
    **/
    public async btnReOrder_Click() {
        const strThisFuncName = this.btnReOrder_Click.name;
        if (this.PreCheck4Order() == false) return;
        var strUpdUser: string = gs_PaperGroupCRUD.UpdUser_OrderNum;
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            var jsonObject =
            {
                "updUser": strUpdUser,
            }
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperGroup_ReOrderAsync(objOrderByData);
        }
        catch (e) {
            const strMsg = clsString.Format("重序出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_gs_PaperGroup();
    }

    /**
    * 置底
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoBottum_Click)
    **/
    public async btnGoBottum_Click() {
        const strThisFuncName = this.btnGoBottum_Click.name;
        if (this.PreCheck4Order() == false) return;
        var strUpdUser: string = gs_PaperGroupCRUD.UpdUser_OrderNum;
        const arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert("请选择需要置底的记录！");
            return "";
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "updUser": strUpdUser,
            }
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperGroup_GoBottomAsync(objOrderByData);
        }
        catch (e) {
            const strMsg = clsString.Format("置底出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_gs_PaperGroup();
        const strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /**
    * 移动记录序号时的预检查函数
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
    **/
    public PreCheck4Order(): boolean {
        const strThisFuncName = this.PreCheck4Order.name;
        var strUpdUser: string = gs_PaperGroupCRUD.UpdUser_OrderNum;
        if (strUpdUser == "") {
            const strMsg = clsString.Format("请输入updUser!");
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return false;
        }
        return true;
    }

    /**
    * 下移
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
    **/
    public async btnDownMove_Click() {
        const strThisFuncName = this.btnDownMove_Click.name;
        if (this.PreCheck4Order() == false) return;
        var strUpdUser: string = gs_PaperGroupCRUD.UpdUser_OrderNum;
        const arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert(`请选择需要下移的记录!`);
            return;
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "updUser": strUpdUser,
            }
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperGroup_DownMoveAsync(objOrderByData);
        }
        catch (e) {
            const strMsg = clsString.Format("下移记录出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_gs_PaperGroup();
        const strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /**
    * 上移
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
    **/
    public async btnUpMove_Click() {
        const strThisFuncName = this.btnUpMove_Click.name;
        if (this.PreCheck4Order() == false) return;
        var strUpdUser: string = gs_PaperGroupCRUD.UpdUser_OrderNum;
        const arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert(`请选择需要上移的记录!`);
            return;
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "updUser": strUpdUser,
            }
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperGroup_UpMoveAsync(objOrderByData);
        }
        catch (e) {
            const strMsg = clsString.Format("上移记录出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_gs_PaperGroup();
        const strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /** 置顶
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoTop_Click)
    **/
    public async btnGoTop_Click() {
        const strThisFuncName = this.btnGoTop_Click.name;
        if (this.PreCheck4Order() == false) return;
        var strUpdUser: string = gs_PaperGroupCRUD.UpdUser_OrderNum;
        const arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert("请选择需要置顶的记录！");
            return "";
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "updUser": strUpdUser,
            }
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await gs_PaperGroup_GoTopAsync(objOrderByData);
        }
        catch (e) {
            const strMsg = clsString.Format("置顶出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_gs_PaperGroup();
        const strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /**
    * 添加新记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
    **/
    public async btnCopyRecord_Click() {
        const strThisFuncName = this.btnCopyRecord_Click.name;
        try {
            const arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要克隆的记录！");
                return "";
            }
            const responseText = await this.CopyRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_gs_PaperGroup();
        }
        catch (e) {
            const strMsg = clsString.Format("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 
    * 在数据表里删除记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
    **/
    public async btnDelRecordInTab_Click(strKeyId: string) {
        const strThisFuncName = this.btnDelRecordInTab_Click.name;
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            if (clsCommonFunc4Web.confirm_del(0) == false) {
                return;
            }
            const responseText = await this.DelRecord(strKeyId);
            const responseBindGv = await this.BindGv_gs_PaperGroup();
        }
        catch (e) {
            const strMsg = clsString.Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 
    * 在数据表里选择记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
    **/
    public async btnSelectRecordInTab_Click(strKeyId: string) {
        const strThisFuncName = this.btnSelectRecordInTab_Click.name;
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            if (clsCommonFunc4Web.confirm_del(0) == false) {
                return;
            }
            this.SelectRecord(strKeyId);
        }
        catch (e) {
            const strMsg = clsString.Format("选择记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 
    * 根据关键字删除记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    **/
    public async DelRecord(strPaperGroupId: string) {
        const strThisFuncName = this.DelRecord.name;
        try {
            const responseText = await gs_PaperGroup_DelRecordAsync(strPaperGroupId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                const strInfo = clsString.Format("删除记录成功,共删除{0}条记录!", returnInt);
                //显示信息框
                alert(strInfo);
            }
            else {
                const strInfo = clsString.Format("删除记录不成功!");
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelRecord!");
        }
        catch (e) {
            const strMsg = clsString.Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 
    * 根据关键字选择相应的记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
    * @param sender:参数列表
    **/
    public async SelectRecord(strPaperGroupId: string) {
        const strThisFuncName = this.SelectRecord.name;
        try {
            const objgs_PaperGroupEN = await gs_PaperGroup_GetObjByPaperGroupIdAsync(strPaperGroupId);
            console.log("完成SelectRecord!", objgs_PaperGroupEN);
            clsCommonFunc4Web.Redirect("/Index/Main_gs_PaperGroup");
        }
        catch (e) {
            const strMsg = clsString.Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

    /** 删除记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
    **/
    public async btnDelRecord_Click() {
        const strThisFuncName = this.btnDelRecord_Click.name;
        try {
            const arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            if (clsCommonFunc4Web.confirm_del(arrKeyIds.length) == false) {
                return;
            }
            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_gs_PaperGroup();
        }
        catch (e) {
            const strMsg = clsString.Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
    **/
    public async btnExportExcel_Click() {
        const strThisFuncName = this.btnExportExcel_Click.name;
        console.log('strThisFuncName', strThisFuncName);
        const responseBindGv = await this.ExportExcel_gs_PaperGroup_Cache();
    }

    /** 把所有的查询控件内容组合成一个条件串
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    * @returns 条件串(strWhereCond)
    **/
    public Combinegs_PaperGroupCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperGroupName_q != "") {
                strWhereCond += clsString.Format(" And {0} like '% {1}%'", clsgs_PaperGroupEN.con_PaperGroupName, this.PaperGroupName_q);
            }
            if (this.UpdUser_q != "") {
                strWhereCond += clsString.Format(" And {0} like '% {1}%'", clsgs_PaperGroupEN.con_UpdUser, this.UpdUser_q);
            }
        }
        catch (objException) {
            const strMsg: string = clsString.Format("(errid:WiTsCs0009)在组合查询条件(Combinegs_PaperGroupCondition)时出错!请联系管理员!{0}", objException);
            throw strMsg;
        }
        return strWhereCond;
    }

    /** 把所有的查询控件内容组合成一个条件串
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
    * @returns 条件串(strWhereCond)
    **/
    public Combinegs_PaperGroupConditionObj(): clsgs_PaperGroupEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        let strWhereCond = " 1 = 1 ";
        const objgs_PaperGroup_Cond = new clsgs_PaperGroupEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperGroupName_q != "") {
                strWhereCond += clsString.Format(" And {0} like '% {1}%'", clsgs_PaperGroupEN.con_PaperGroupName, this.PaperGroupName_q);
                objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN.con_PaperGroupName, this.PaperGroupName_q, "like");
            }
            if (this.UpdUser_q != "") {
                strWhereCond += clsString.Format(" And {0} like '% {1}%'", clsgs_PaperGroupEN.con_UpdUser, this.UpdUser_q);
                objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN.con_UpdUser, this.UpdUser_q, "like");
            }
        }
        catch (objException) {
            const strMsg: string = clsString.Format("(errid:WiTsCs0010)在组合查询条件对象(Combinegs_PaperGroupConditionObj)时出错!请联系管理员!{0}", objException);
            throw strMsg;
        }
        objgs_PaperGroup_Cond.whereCond = strWhereCond;
        return objgs_PaperGroup_Cond;
    }

    /** 把所有的查询控件内容组合成一个条件串
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
    * @returns 条件串(strWhereCond)
    **/
    public Combinegs_PaperGroupConditionObj4ExportExcel(): clsgs_PaperGroupEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        let strWhereCond = " 1 = 1 ";
        const objgs_PaperGroup_Cond = new clsgs_PaperGroupEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperGroupName_q != "") {
                strWhereCond += clsString.Format(" And {0} like '% {1}%'", clsgs_PaperGroupEN.con_PaperGroupName, this.PaperGroupName_q);
                objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN.con_PaperGroupName, this.PaperGroupName_q, "like");
            }
            if (this.UpdUser_q != "") {
                strWhereCond += clsString.Format(" And {0} like '% {1}%'", clsgs_PaperGroupEN.con_UpdUser, this.UpdUser_q);
                objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN.con_UpdUser, this.UpdUser_q, "like");
            }
        }
        catch (objException) {
            const strMsg: string = clsString.Format("(errid:WiTsCs0013)在组合导出Excel条件对象(Combinegs_PaperGroupConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
            throw strMsg;
        }
        objgs_PaperGroup_Cond.whereCond = strWhereCond;
        return objgs_PaperGroup_Cond;
    }

    /** 显示gs_PaperGroup对象的所有属性值
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    * @param divContainer:显示容器
    * @param arrgs_PaperGroupObjLst:需要绑定的对象列表
    **/
    public BindTab_gs_PaperGroup(divContainer: string, arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN>) {
        const strThisFuncName = this.BindTab_gs_PaperGroup.name;
        console.log('strThisFuncName', strThisFuncName);
        const o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(clsString.Format("{0}不存在！", divContainer));
            return;
        }
        const arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    FldName: "orderNum",
                    SortBy: "orderNum",
                    ColHeader: "序号",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    FldName: "paperGroupId",
                    SortBy: "paperGroupId",
                    ColHeader: "组Id",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    FldName: "paperGroupName",
                    SortBy: "paperGroupName",
                    ColHeader: "组名",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    FldName: "meno",
                    SortBy: "meno",
                    ColHeader: "备注",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
        clsCommonFunc4Web.BindTabV4(o, arrgs_PaperGroupObjLst, arrDataColumn, "paperGroupId", this);
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /** 函数功能:在数据 列表中跳转到某一页
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    * @param intPageIndex:页序号
    **/
    public async IndexPage(intPageIndex: number) {
        const strThisFuncName = this.IndexPage.name;
        console.log('strThisFuncName', strThisFuncName);
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        const responseBindGv = await this.BindGv_gs_PaperGroup();
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    **/
    public async BindGv_gs_PaperGroup() {
        const strThisFuncName = this.BindGv_gs_PaperGroup.name;
        if (this.hidSortgs_PaperGroupBy == null) {
            const strMsg = clsString.Format("在显示列表时，排序字段(hidSortgs_PaperGroupBy)为空，请检查！(In BindGv_gs_PaperGroup)");
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        const strListDiv: string = this.mstrListDiv;
        const strWhereCond = this.Combinegs_PaperGroupCondition();
        let intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        let arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = [];
        try {
            const responseRecCount = await gs_PaperGroup_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            if (this.RecCount == 0) {
                const lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
                lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
                const divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strMsg = clsString.Format("在绑定Gv过程中，根据条件:[${strWhereCond}]获取的对象列表数为0！");
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            var intPageCount = this.objPager.GetPageCount(this.RecCount, this.pageSize);
            if (intCurrPageIndex == 0) {
                if (intPageCount > 1) intCurrPageIndex = intPageCount;
                else intCurrPageIndex = 1;
                this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
            }
            else if (intCurrPageIndex > intPageCount) {
                intCurrPageIndex = intPageCount;
                this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
            }
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortgs_PaperGroupBy,//如果该字段为空，就使用下面的排序函数
                sortFun: (x, y) => { console.log(x, y); return 0; }
            }
            const responseObjLst = await gs_PaperGroup_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrgs_PaperGroupObjLst = <Array<clsgs_PaperGroupEN>>jsonData;
            });
        }
        catch (e) {
            const strMsg = clsString.Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
        var divPager: HTMLDivElement = <HTMLDivElement>document.getElementById("divPager");
        if (this.RecCount <= this.pageSize) {
            if (divPager != null) {
                divPager.style.display = "none";
            }
        }
        else {
            if (divPager != null) {
                divPager.style.display = "block";
            }
        }
        if (arrgs_PaperGroupObjLst.length == 0) {
            const lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
            lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
            const divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
            if (divDataLst != null) {
                divDataLst.innerText = "";
                divDataLst.appendChild(lblMsg);
            }
            const strMsg = clsString.Format("根据条件获取的记录数为0！");
            console.error("Error: ", strMsg);
            //console.trace();
            this.ShowEmptyRecNumInfo(strListDiv, strMsg);
            this.objPager.Hide(this.divName4Pager);
            return;
        }
        try {
            this.BindTab_gs_PaperGroup(strListDiv, arrgs_PaperGroupObjLst);
            console.log("完成BindGv_gs_PaperGroup!");
        }
        catch (e) {
            //console.trace();
            const strMsg = clsString.Format("绑定对象列表不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
    **/
    public async BindGv_gs_PaperGroup_Cache() {
        const strThisFuncName = this.BindGv_gs_PaperGroup_Cache.name;
        if (this.hidSortgs_PaperGroupBy == null) {
            const strMsg = clsString.Format("在显示列表时，排序字段(hidSortgs_PaperGroupBy)为空，请检查！(In BindGv_gs_PaperGroup_Cache)");
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        const strListDiv: string = this.mstrListDiv;
        const objgs_PaperGroup_Cond = this.Combinegs_PaperGroupConditionObj();
        objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN.con_UpdUser, gs_PaperGroupCRUD.strUpdUser_Cache, "=");
        const strWhereCond = JSON.stringify(objgs_PaperGroup_Cond);
        let intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        let arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = [];
        try {
            this.RecCount = await gs_PaperGroup_GetRecCountByCond_Cache(objgs_PaperGroup_Cond, gs_PaperGroupCRUD.strUpdUser_Cache);
            if (this.RecCount == 0) {
                const lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
                lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objgs_PaperGroup_Cond.whereCond);
                const divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strMsg = clsString.Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objgs_PaperGroup_Cond.whereCond);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            var intPageCount = this.objPager.GetPageCount(this.RecCount, this.pageSize);
            if (intCurrPageIndex == 0) {
                if (intPageCount > 1) intCurrPageIndex = intPageCount;
                else intCurrPageIndex = 1;
                this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
            }
            else if (intCurrPageIndex > intPageCount) {
                intCurrPageIndex = intPageCount;
                this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
            }
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortgs_PaperGroupBy,//如果该字段为空，就使用下面的排序函数
                sortFun: gs_PaperGroup_SortFun_Defa
            }
            arrgs_PaperGroupObjLst = await gs_PaperGroup_GetObjLstByPager_Cache(objPagerPara, gs_PaperGroupCRUD.strUpdUser_Cache);
        }
        catch (e) {
            const strMsg = clsString.Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var divPager: HTMLDivElement = <HTMLDivElement>document.getElementById("divPager");
        if (this.RecCount <= this.pageSize) {
            if (divPager != null) {
                divPager.style.display = "none";
            }
        }
        else {
            if (divPager != null) {
                divPager.style.display = "block";
            }
        }
        if (arrgs_PaperGroupObjLst.length == 0) {
            const lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
            lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
            const divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
            if (divDataLst != null) {
                divDataLst.innerText = "";
                divDataLst.appendChild(lblMsg);
            }
            const strKey = clsString.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, gs_PaperGroupCRUD.strUpdUser_Cache);
            const strMsg = clsString.Format("根据条件获取的记录数为0！(Key={0})", strKey);
            console.error("Error: ", strMsg);
            //console.trace();
            this.ShowEmptyRecNumInfo(strListDiv, strMsg);
            this.objPager.Hide(this.divName4Pager);
            return;
        }
        try {
            this.BindTab_gs_PaperGroup(strListDiv, arrgs_PaperGroupObjLst);
            console.log("完成BindGv_gs_PaperGroup_Cache!");
        }
        catch (e) {
            const strMsg = clsString.Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /**
    * 排序函数。根据表对象中随机两个字段的值进行比较,正常使用时，需用该类的扩展类的同名函数
    * 作者:pyf
    * 日期:
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortFunExportExcel)
    * @param a:比较的第1个对象
    * @param b:比较的第1个对象
    * @returns 返回两个对象比较的结果
    **/
    public SortFun_ExportExcel(a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN): number {
        const strThisFuncName = this.SortFun_ExportExcel.name;
        console.log('strThisFuncName', strThisFuncName);
        if (a.updDate == b.updDate) return a.updUser.localeCompare(b.updUser);
        else return a.updDate.localeCompare(b.updDate);
    }

    /** 函数功能:从界面列表中根据某一个字段排序
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
    * @param objAnchorElement:带有排序字段的Anchors
    **/
    public async SortBy(objAnchorElement: any) {
        const strThisFuncName = this.SortBy.name;
        console.log('strThisFuncName', strThisFuncName);
        console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
        //event = window.event || event;
        var thisEventObj: HTMLInputElement = objAnchorElement;
        var strFldName: string = thisEventObj.getAttribute("FldName") as string;
        if (clsString.IsNullOrEmpty(strFldName) == true) return;
        var strSortByFld: string = strFldName;
        if (this.hidSortgs_PaperGroupBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortgs_PaperGroupBy.indexOf("Asc") >= 0) {
                this.hidSortgs_PaperGroupBy = clsString.Format("{0} Desc", strSortByFld);
            }
            else {
                this.hidSortgs_PaperGroupBy = clsString.Format("{0} Asc", strSortByFld);
            }
        }
        else {
            this.hidSortgs_PaperGroupBy = clsString.Format("{0} Asc", strSortByFld);
        }
        const responseBindGv = await this.BindGv_gs_PaperGroup();
    }

    /**
    * 在用户自定义控件中，设置关键字的值，是否只读
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    * @param bolReadonly:是否只读
    **/
    public SetKeyReadOnly(bolReadonly: boolean) {
        const strThisFuncName = this.SetKeyReadOnly.name;
        console.log('strThisFuncName', strThisFuncName);
        $('#txtPaperGroupId').prop['ReadOnly'] = bolReadonly;
    }

    /** 复制记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
    **/
    public async CopyRecord(arrPaperGroupId: Array<string>) {
        const strThisFuncName = this.CopyRecord.name;
        try {
            const responseText = await gs_PaperGroup_GetObjLstByPaperGroupIdLstAsync(arrPaperGroupId);
            console.log('responseText=');
            console.log(responseText);
            let intCount = 0;
            const arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = <Array<clsgs_PaperGroupEN>>responseText;
            for (const objInFor of arrgs_PaperGroupObjLst) {
                const strMaxStrId = await gs_PaperGroup_GetMaxStrIdAsync();
                console.log('strMaxStrId=' + strMaxStrId);
                objInFor.paperGroupId = strMaxStrId;
                const returnBool = await gs_PaperGroup_AddNewRecordAsync(objInFor);
                console.log('returnBool=');
                console.log(returnBool);
                if (returnBool == true) {
                    const strInfo = clsString.Format("克隆记录成功!");
                    intCount++;
                }
                else {
                    const strInfo = clsString.Format("克隆记录不成功!");
                    //显示信息框
                    alert(strInfo);
                }
            }
            const strInfo = clsString.Format("共克隆了${ intCount}条记录!");
            alert(strInfo);
            console.log('完成！');
        }
        catch (e) {
            const strMsg = clsString.Format("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

    /** 根据关键字列表删除记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
    **/
    public async DelMultiRecord(arrPaperGroupId: Array<string>) {
        const strThisFuncName = this.DelMultiRecord.name;
        try {
            const responseText = await gs_PaperGroup_Delgs_PaperGroupsAsync(arrPaperGroupId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                const strInfo = clsString.Format("删除记录成功,共删除{0}条记录!", returnInt);
                //显示信息框
                alert(strInfo);
            }
            else {
                const strInfo = clsString.Format("删除记录不成功!");
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelMultiRecord!");
        }
        catch (e) {
            const strMsg = clsString.Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 显示{0}对象的所有属性值
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
    * @param divContainer:显示容器
    * @param objgs_PaperGroup:需要显示的对象
    **/
    public Showgs_PaperGroupObj(divContainer: string, objgs_PaperGroup: clsgs_PaperGroupEN) {
        const strThisFuncName = this.Showgs_PaperGroupObj.name;
        console.log('strThisFuncName', strThisFuncName);
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(clsString.Format("{}不存在！", divContainer));
            return;
        }
        const sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_PaperGroup);
        var ul: HTMLUListElement = document.createElement("ul");
        for (const strKey of sstrKeys) {
            const strValue = objgs_PaperGroup[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = clsString.Format("{0}:{1}", strKey, strValue);
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /** 函数功能:从界面列表中获取第一个关键字的值
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
    * @param pobjgs_PaperGroupEN:表实体类对象
    * @returns 列表的第一个关键字值
    **/
    public GetFirstKey(): string {
        const strThisFuncName = this.GetFirstKey.name;
        console.log('strThisFuncName', strThisFuncName);
        if (arrSelectedKeys.length == 1) {
            return arrSelectedKeys[0];
        }
        else {
            alert(`请选择一个关键字！目前选择了:${arrSelectedKeys.length}个关键字。`);
            return "";
        }
    }
    /**
    * 设置排序字段-相当使用ViewState功能
    **/
    public set hidSortgs_PaperGroupBy(value: string) {
        $("#hidSortgs_PaperGroupBy").val(value);
    }
    /**
    * 设置排序字段
    **/
    public get hidSortgs_PaperGroupBy(): string {
        return $("#hidSortgs_PaperGroupBy").val();
    }
    /**
    * 组名 (Used In CombineCondition())
    **/
    public get PaperGroupName_q(): string {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtPaperGroupName_q");
        const strId = clsString.Format("input[id ^= 'txtPaperGroupName_q']");
        const objElem = objDiv.find(strId);
        if (objElem == undefined) return "";
        else {
            const strValue = objElem.val();
            if (strValue == undefined) return "";
            else return strValue.toString();
        }
    }
    /**
    * 组名 (Used In CombineCondition())
    **/
    public set PaperGroupName_q(value: string) {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtPaperGroupName_q");
        const strId = clsString.Format("input[id ^= 'txtPaperGroupName_q']");
        objDiv.find(strId).val(value);
    }
    /**
    * updUser (Used In btnReOrder_Click())
    **/
    public static get UpdUser_OrderNum(): string {
        return $("#txtUpdUser_OrderNum").val();
    }
    /**
    * updUser (Used In btnReOrder_Click())
    **/
    public static set UpdUser_OrderNum(value: string) {
        $("#txtUpdUser_OrderNum").val(value);
    }
    /**
    * 修改人 (Used In CombineCondition())
    **/
    public get UpdUser_q(): string {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtUpdUser_q");
        const strId = clsString.Format("input[id ^= 'txtUpdUser_q']");
        const objElem = objDiv.find(strId);
        if (objElem == undefined) return "";
        else {
            const strValue = objElem.val();
            if (strValue == undefined) return "";
            else return strValue.toString();
        }
    }
    /**
    * 修改人 (Used In CombineCondition())
    **/
    public set UpdUser_q(value: string) {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtUpdUser_q");
        const strId = clsString.Format("input[id ^= 'txtUpdUser_q']");
        objDiv.find(strId).val(value);
    }
    /**
    * 设置界面标题-相当使用ViewState功能
    **/
    public set ViewTitle(value: string) {
        const objDiv = $(`#${this.divName4Layout}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Layout, "label", "lblViewTitle");
        const strId = clsString.Format("label[id ^= 'lblViewTitle']");
        objDiv.find(strId).html(value);
    }
    /**
    * 设置界面标题
    **/
    public get ViewTitle(): string {
        const objDiv = $(`#${this.divName4Layout}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Layout, "label", "lblViewTitle");
        const strId = clsString.Format("label[id ^= 'lblViewTitle']");
        return objDiv.find(strId).html();
    }
}