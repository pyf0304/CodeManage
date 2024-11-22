﻿
/**
* 类名:gs_TagsCRUD(界面:gs_TagsCRUD)
* 表名:gs_Tags(01120714)
* 生成代码版本:2021.09.26.2
* 生成日期:2021/09/30 09:29:22
* 生成者:
* 工程名称:问卷调查
* 工程ID:0112
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:互动管理
* 模块英文名:InteractManage
* 框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
* 编程语言:TypeScript
**/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsgs_TagsEN } from "../TS/L0_Entity/InteractManage/clsgs_TagsEN.js";
import { clsgs_TagsENEx } from "../TS/L0_Entity/InteractManage/clsgs_TagsENEx.js";
import { clsUsersEN } from "../TS/L0_Entity/UserManage/clsUsersEN.js";
import { Paper_func } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaperEduClsRela_BindDdl_PaperIdInDiv_Cache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperEduClsRelaWApi.js";
import { gs_TagsType_BindDdl_TagsTypeIdInDiv_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TagsTypeWApi.js";
import { gs_Tags_AddNewRecordAsync, gs_Tags_CopyObjTo, gs_Tags_Delgs_TagssAsync, gs_Tags_DelRecordAsync, gs_Tags_GetMaxStrIdAsync, gs_Tags_GetObjByTagsIdAsync, gs_Tags_GetObjLstAsync, gs_Tags_GetObjLstByPagerAsync, gs_Tags_GetObjLstByTagsIdLstAsync, gs_Tags_GetRecCountByCondAsync, gs_Tags_GetSubObjLst_Cache } from "../TS/L3_ForWApi/InteractManage/clsgs_TagsWApi.js";
import { Users_func } from "../TS/L3_ForWApi/UserManage/clsUsersWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
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
declare var window;
/** gs_TagsCRUD 的摘要说明。其中Q代表查询,U代表修改
* (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
**/
export abstract class gs_TagsCRUD implements clsOperateList {
    public static objPage_CRUD: gs_TagsCRUD;
    public divName4Query = "divQuery";  //查询区的层Id
    public divName4Function = "divFunction";  //功能区的层Id
    public divName4Layout = "divLayout";  //界面布局的层Id
    constructor() {
        super();
        gs_TagsCRUD.objPage_CRUD = this;
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
        // 在此处放置用户代码以初始化页面
        try {
            this.SetEventFunc();
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortgs_TagsBy = "tagsContent Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_gs_Tags4Func();
        }
        catch (e) {
            const strMsg = clsString.Format("页面启动不成功,{0}.", e);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }


    /** 函数功能:设置事件函数
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
    **/
    public async SetEventFunc() {
        // 在此处放置用户代码以初始化页面
        try {
        }
        catch (e) {
            const strMsg = clsString.Format("页面启动不成功,{0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }


    /** 函数功能:页面导入,当页面开始运行时所发生的事件
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
    **/
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.SetEventFunc();
            this.hidSortgs_TagsBy = "tagsContent Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_gs_Tags4Func();
        }
        catch (e) {
            const strMsg = clsString.Format("页面启动不成功,{0}.", e);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }


    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    **/
    public async btnQuery_Click() {
        this.setCurrPageIndex(1, this.divName4Pager);
        const responseBindGv = await this.BindGv_gs_Tags4Func();
    }

    /** 合并数据
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
    **/
    public CombineData(arrgs_TagsObjLst: Array<clsgs_TagsEN>, arrDataColumn: Array<clsDataColumn>) {
        const intRowNum = arrgs_TagsObjLst.length;
        const intColNum = arrDataColumn.length;
        const arrData: Array<Array<any>> = new Array<Array<any>>();
        const arrHead: Array<any> = new Array<any>();
        for (let j = 0; j < intColNum; j++) {
            arrHead.push(arrDataColumn[j].ColHeader);
        }
        arrData.push(arrHead);
        for (let i = 0; i < intRowNum; i++) {
            const arrRow: Array<any> = new Array<any>();
            const objEN: clsgs_TagsEN = arrgs_TagsObjLst[i];
            for (let j = 0; j < intColNum; j++) {
                arrRow.push(objEN[arrDataColumn[j].FldName]);//i + "" + j;
            }
            arrData.push(arrRow);
        }
        console.log("arrData", arrData);
        const strFileName = clsString.Format("gs_Tags({0})导出.xlsx",
            clsgs_TagsEN._CurrTabName);
        exportSpecialExcel_pyf(arrData, strFileName);
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
    **/
    public async ExportExcel_gs_Tags() {
        if (this.hidSortgs_TagsBy == null) {
            const strMsg = clsString.Format("在显示列表时，排序字段(hidSortgs_TagsBy)为空，请检查！(In BindGv_gs_Tags_Cache)");
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        const strListDiv: string = this.mstrListDiv;
        const strWhereCond = this.Combinegs_TagsCondition();
        const intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        let arrgs_TagsObjLst: Array<clsgs_TagsEN> = [];
        try {
            this.RecCount = await gs_Tags_GetRecCountByCondAsync(strWhereCond);
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
            arrgs_TagsObjLst = await gs_Tags_GetObjLstAsync(strWhereCond);
        }
        catch (e) {
            const strMsg = clsString.Format("绑定GridView不成功,{0}.", e);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        if (arrgs_TagsObjLst.length == 0) {
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
                        FldName: "tagsId",
                        SortBy: "",
                        ColHeader: "标注Id",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 2,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "tagsContent",
                        SortBy: "",
                        ColHeader: "标注内容",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 3,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfContent",
                        SortBy: "",
                        ColHeader: "Pdf内容",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 4,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfPageNum",
                        SortBy: "",
                        ColHeader: "Pdf页码",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 5,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "voteCount",
                        SortBy: "",
                        ColHeader: "点赞计数",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 6,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "orderNum",
                        SortBy: "",
                        ColHeader: "序号",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 7,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "updUser",
                        SortBy: "",
                        ColHeader: "修改人",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 8,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "updDate",
                        SortBy: "",
                        ColHeader: "修改日期",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 9,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "PdfLineNum",
                        SortBy: "",
                        ColHeader: "pdf行号",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 10,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "PdfX",
                        SortBy: "",
                        ColHeader: "PdfX",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 11,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "PdfY",
                        SortBy: "",
                        ColHeader: "PdfY",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 12,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "memo",
                        SortBy: "",
                        ColHeader: "备注",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 13,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "id_CurrEduCls",
                        SortBy: "",
                        ColHeader: "当前教学班流水号",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 14,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfPageNumIn",
                        SortBy: "",
                        ColHeader: "pdfPageNumIn",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 17,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfPageTop",
                        SortBy: "",
                        ColHeader: "pdf页面顶部位置",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 18,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfDivLet",
                        SortBy: "",
                        ColHeader: "pdfDivLet",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 19,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfDivTop",
                        SortBy: "",
                        ColHeader: "pdfDivTop",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 20,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfZoom",
                        SortBy: "",
                        ColHeader: "pdfZoom",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 21,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                ];
            arrgs_TagsObjLst = arrgs_TagsObjLst.sort(this.SortFun_ExportExcel);
            this.CombineData(arrgs_TagsObjLst, arrDataColumn);
            console.log("完成BindGv_gs_Tags!");
        }
        catch (e) {
            const strMsg = clsString.Format("绑定对象列表不成功.Error Massage:{0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel_Cache)
    **/
    public async ExportExcel_gs_Tags_Cache() {
        if (this.hidSortgs_TagsBy == null) {
            const strMsg = clsString.Format("在显示列表时，排序字段(hidSortgs_TagsBy)为空，请检查！(In BindGv_gs_Tags_Cache)");
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        const strListDiv: string = this.mstrListDiv;
        var objgs_Tags_Cond = this.Combinegs_TagsConditionObj4ExportExcel();
        const strWhereCond = JSON.stringify(objgs_Tags_Cond);
        const intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        let arrgs_TagsObjLst: Array<clsgs_TagsEN> = [];
        try {
            this.RecCount = await gs_Tags_GetRecCountByCond_Cache(objgs_Tags_Cond);
            if (this.RecCount == 0) {
                const lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
                lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objgs_Tags_Cond.whereCond);
                const divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strMsg = clsString.Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objgs_Tags_Cond.whereCond);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            arrgs_TagsObjLst = await gs_Tags_GetSubObjLst_Cache(objgs_Tags_Cond);
        }
        catch (e) {
            const strMsg = clsString.Format("绑定GridView不成功,{0}.", e);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        if (arrgs_TagsObjLst.length == 0) {
            const strKey = clsString.Format("{0}", clsgs_TagsEN._CurrTabName);
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
                        FldName: "tagsId",
                        SortBy: "",
                        ColHeader: "标注Id",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 2,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "tagsContent",
                        SortBy: "",
                        ColHeader: "标注内容",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 3,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfContent",
                        SortBy: "",
                        ColHeader: "Pdf内容",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 4,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfPageNum",
                        SortBy: "",
                        ColHeader: "Pdf页码",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 5,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "voteCount",
                        SortBy: "",
                        ColHeader: "点赞计数",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 6,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "orderNum",
                        SortBy: "",
                        ColHeader: "序号",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 7,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "updUser",
                        SortBy: "",
                        ColHeader: "修改人",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 8,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "updDate",
                        SortBy: "",
                        ColHeader: "修改日期",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 9,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "PdfLineNum",
                        SortBy: "",
                        ColHeader: "pdf行号",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 10,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "PdfX",
                        SortBy: "",
                        ColHeader: "PdfX",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 11,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "PdfY",
                        SortBy: "",
                        ColHeader: "PdfY",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 12,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "memo",
                        SortBy: "",
                        ColHeader: "备注",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 13,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "id_CurrEduCls",
                        SortBy: "",
                        ColHeader: "当前教学班流水号",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 14,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfPageNumIn",
                        SortBy: "",
                        ColHeader: "pdfPageNumIn",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 17,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfPageTop",
                        SortBy: "",
                        ColHeader: "pdf页面顶部位置",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 18,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfDivLet",
                        SortBy: "",
                        ColHeader: "pdfDivLet",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 19,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfDivTop",
                        SortBy: "",
                        ColHeader: "pdfDivTop",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 20,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                    {
                        FldName: "pdfZoom",
                        SortBy: "",
                        ColHeader: "pdfZoom",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 21,
                        FuncName: (strKey, strText) => { return new HTMLElement(); }
                    },
                ];
            arrgs_TagsObjLst = arrgs_TagsObjLst.sort(this.SortFun_ExportExcel);
            this.CombineData(arrgs_TagsObjLst, arrDataColumn);
            console.log("完成BindGv_gs_Tags!");
        }
        catch (e) {
            const strMsg = clsString.Format("绑定对象列表不成功.Error Massage:{0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /**
    * 设置绑定下拉框，针对字段:[paperId]
    * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion)
    */
    public async SetDdl_PaperId(strid_CurrEduCls: string) {
        await vPaperEduClsRela_BindDdl_PaperIdInDiv_Cache(this.divName4List, "ddlPaperId_q", strid_CurrEduCls);//查询区域
    }

    /**
    * 设置绑定下拉框，针对字段:[tagsTypeId]
    * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion)
    */
    public async SetDdl_TagsTypeId() {
        await gs_TagsType_BindDdl_TagsTypeIdInDiv_Cache(this.divName4List, "ddlTagsTypeId_q");//查询区域
    }


    /** 函数功能:为查询区绑定下拉框
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
    **/
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
        var strid_CurrEduCls = "";  //定义条件字段
        const ddlPaperId_q = await this.SetDdl_PaperId(strid_CurrEduCls);//查询区域
        const ddlTagsTypeId_q = await this.SetDdl_TagsTypeId();//查询区域
    }


    /**
    * 添加新记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
    **/
    public async btnCopyRecord_Click() {
        try {
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要克隆的记录！");
                return "";
            }
            const responseText = await this.CopyRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_gs_Tags4Func();
        }
        catch (e) {
            const strMsg = clsString.Format("复制记录不成功,{0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 
    * 在数据表里删除记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
    **/
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            if (clsCommonFunc4Web.confirm_del(0) == false) {
                return;
            }
            const responseText = await this.DelRecord(strKeyId);
            const responseBindGv = await this.BindGv_gs_Tags4Func();
        }
        catch (e) {
            const strMsg = clsString.Format("删除记录不成功. {0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 
    * 在数据表里选择记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
    **/
    public async btnSelectRecordInTab_Click(strKeyId: string) {
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
            const strMsg = clsString.Format("选择记录不成功. {0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 
    * 根据关键字删除记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    **/
    public async DelRecord(strTagsId: string) {
        try {
            const responseText = await gs_Tags_DelRecordAsync(strTagsId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                const strInfo = clsString.Format("删除记录成功,共删除${returnInt}条记录!");
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
            const strMsg = clsString.Format("删除记录不成功. {0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 
    * 根据关键字选择相应的记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
    * @param sender:参数列表
    **/
    public async SelectRecord(strTagsId: string) {
        try {
            const responseText = await gs_Tags_GetObjByTagsIdAsync(strTagsId);
            const objgs_TagsEN: clsgs_TagsEN = <clsgs_TagsEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_gs_Tags");
        }
        catch (e) {
            const strMsg = clsString.Format("根据关键字获取相应的记录的对象不成功,{0}.", e);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

    /** 删除记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
    **/
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            if (clsCommonFunc4Web.confirm_del(arrKeyIds.length) == false) {
                return;
            }
            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_gs_Tags4Func();
        }
        catch (e) {
            const strMsg = clsString.Format("删除记录不成功. {0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
    **/
    public async btnExportExcel_Click() {
        const responseBindGv = await this.ExportExcel_gs_Tags_Cache();
    }

    /** 把所有的查询控件内容组合成一个条件串
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    * @returns 条件串(strWhereCond)
    **/
    public Combinegs_TagsCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.TagsContent_q != "") {
                strWhereCond += clsString.Format(" And {0} like '% {1}%'", clsgs_TagsEN.con_TagsContent, this.TagsContent_q);
            }
            if (this.PaperId_q != "" && this.PaperId_q != "0") {
                strWhereCond += clsString.Format(" And {0} = '{1}'", clsgs_TagsEN.con_PaperId, this.PaperId_q);
            }
            if (this.TagsTypeId_q != "" && this.TagsTypeId_q != "0") {
                strWhereCond += clsString.Format(" And {0} = '{1}'", clsgs_TagsEN.con_TagsTypeId, this.TagsTypeId_q);
            }
        }
        catch (objException) {
            const strMsg: string = clsString.Format("(errid:WiTsCs0009)在组合查询条件(Combinegs_TagsCondition)时出错!请联系管理员!{0}", objException);
            throw strMsg;
        }
        return strWhereCond;
    }

    /** 把所有的查询控件内容组合成一个条件串
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
    * @returns 条件串(strWhereCond)
    **/
    public Combinegs_TagsConditionObj(): clsgs_TagsEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond = " 1 = 1 ";
        var objgs_Tags_Cond = new clsgs_TagsEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.TagsContent_q != "") {
                strWhereCond += clsString.Format(" And {0} like '% {1}%'", clsgs_TagsEN.con_TagsContent, this.TagsContent_q);
                objgs_Tags_Cond.SetCondFldValue(clsgs_TagsEN.con_TagsContent, this.TagsContent_q, "like");
            }
            if (this.PaperId_q != "" && this.PaperId_q != "0") {
                strWhereCond += clsString.Format(" And {0} = '{1}'", clsgs_TagsEN.con_PaperId, this.PaperId_q);
                objgs_Tags_Cond.SetCondFldValue(clsgs_TagsEN.con_PaperId, this.PaperId_q, "=");
            }
            if (this.TagsTypeId_q != "" && this.TagsTypeId_q != "0") {
                strWhereCond += clsString.Format(" And {0} = '{1}'", clsgs_TagsEN.con_TagsTypeId, this.TagsTypeId_q);
                objgs_Tags_Cond.SetCondFldValue(clsgs_TagsEN.con_TagsTypeId, this.TagsTypeId_q, "=");
            }
        }
        catch (objException) {
            const strMsg: string = clsString.Format("(errid:WiTsCs0010)在组合查询条件对象(Combinegs_TagsConditionObj)时出错!请联系管理员!{0}", objException);
            throw strMsg;
        }
        objgs_Tags_Cond.whereCond = strWhereCond;
        return objgs_Tags_Cond;
    }

    /** 把所有的查询控件内容组合成一个条件串
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
    * @returns 条件串(strWhereCond)
    **/
    public Combinegs_TagsConditionObj4ExportExcel(): clsgs_TagsEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond = " 1 = 1 ";
        var objgs_Tags_Cond = new clsgs_TagsEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.TagsContent_q != "") {
                strWhereCond += clsString.Format(" And {0} like '% {1}%'", clsgs_TagsEN.con_TagsContent, this.TagsContent_q);
                objgs_Tags_Cond.SetCondFldValue(clsgs_TagsEN.con_TagsContent, this.TagsContent_q, "like");
            }
            if (this.PaperId_q != "" && this.PaperId_q != "0") {
                strWhereCond += clsString.Format(" And {0} = '{1}'", clsgs_TagsEN.con_PaperId, this.PaperId_q);
                objgs_Tags_Cond.SetCondFldValue(clsgs_TagsEN.con_PaperId, this.PaperId_q, "=");
            }
            if (this.TagsTypeId_q != "" && this.TagsTypeId_q != "0") {
                strWhereCond += clsString.Format(" And {0} = '{1}'", clsgs_TagsEN.con_TagsTypeId, this.TagsTypeId_q);
                objgs_Tags_Cond.SetCondFldValue(clsgs_TagsEN.con_TagsTypeId, this.TagsTypeId_q, "=");
            }
        }
        catch (objException) {
            const strMsg: string = clsString.Format("(errid:WiTsCs0013)在组合导出Excel条件对象(Combinegs_TagsConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
            throw strMsg;
        }
        objgs_Tags_Cond.whereCond = strWhereCond;
        return objgs_Tags_Cond;
    }

    /** 显示gs_Tags对象的所有属性值
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    * @param divContainer:显示容器
    * @param arrgs_TagsObjLst:需要绑定的对象列表
    **/
    public BindTab_gs_Tags(divContainer: string, arrgs_TagsObjLst: Array<clsgs_TagsEN>) {
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
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "paperId",
                    SortBy: "paperTitle",
                    ColHeader: "主题名称",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "tagsContent",
                    SortBy: "tagsContent",
                    ColHeader: "标注内容",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "pdfPageNum",
                    SortBy: "pdfPageNum",
                    ColHeader: "Pdf页码",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "voteCount",
                    SortBy: "voteCount",
                    ColHeader: "点赞数",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "orderNum",
                    SortBy: "orderNum",
                    ColHeader: "序号",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "updUser",
                    SortBy: "userName",
                    ColHeader: "标记人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 8,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 9,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
            ];
        clsCommonFunc4Web.BindTabV4(o, arrgs_TagsObjLst, arrDataColumn, "tagsId", this);
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /** 显示gs_Tags对象的所有属性值
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
    * @param divContainer:显示容器
    * @param arrgs_TagsExObjLst:需要绑定的对象列表
    **/
    public BindTab_gs_Tags4Func(divContainer: string, arrgs_TagsExObjLst: Array<clsgs_TagsENEx>) {
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
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "paperTitle",
                    SortBy: "paperTitle",
                    ColHeader: "主题名称",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "tagsContent",
                    SortBy: "tagsContent",
                    ColHeader: "标注内容",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "pdfPageNum",
                    SortBy: "pdfPageNum",
                    ColHeader: "Pdf页码",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "voteCount",
                    SortBy: "voteCount",
                    ColHeader: "点赞数",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "orderNum",
                    SortBy: "orderNum",
                    ColHeader: "序号",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "userName",
                    SortBy: "userName",
                    ColHeader: "标记人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 8,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 9,
                    FuncName: (strKey, strText) => { return new HTMLElement(); }
                },
            ];
        clsCommonFunc4Web.BindTabV4(o, arrgs_TagsExObjLst, arrDataColumn, "tagsId", this);
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /** 函数功能:在数据 列表中跳转到某一页
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    * @param intPageIndex:页序号
    **/
    public async IndexPage(intPageIndex: number) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        const responseBindGv = await this.BindGv_gs_Tags4Func();
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    **/
    public async BindGv_gs_Tags() {
        if (this.hidSortgs_TagsBy == null) {
            const strMsg = clsString.Format("在显示列表时，排序字段(hidSortgs_TagsBy)为空，请检查！(In BindGv_gs_Tags)");
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        const strListDiv: string = this.mstrListDiv;
        const strWhereCond = this.Combinegs_TagsCondition();
        let intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        let arrgs_TagsObjLst: Array<clsgs_TagsEN> = [];
        try {
            const responseRecCount = await gs_Tags_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
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
                orderBy: this.hidSortgs_TagsBy,//如果该字段为空，就使用下面的排序函数
                sortFun: (x, y) => { return 0; }
            }
            const responseObjLst = await gs_Tags_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrgs_TagsObjLst = <Array<clsgs_TagsEN>>jsonData;
            });
        }
        catch (e) {
            const strMsg = clsString.Format("绑定GridView不成功,{0}.", e);
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
        if (arrgs_TagsObjLst.length == 0) {
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
            this.BindTab_gs_Tags(strListDiv, arrgs_TagsObjLst);
            console.log("完成BindGv_gs_Tags!");
        }
        catch (e) {
            //console.trace();
            const strMsg = clsString.Format("绑定对象列表不成功.Error Massage:{0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 根据条件获取相应的对象列表
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv4Func_NoCache)
    **/
    public async BindGv_gs_Tags4Func() {
        if (this.hidSortgs_TagsBy == null) {
            const strMsg = clsString.Format("在显示列表时，排序字段(hidSortgs_TagsBy)为空，请检查！(In BindGv_gs_Tags_Cache)");
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        const strListDiv: string = this.mstrListDiv;
        const strWhereCond = this.Combinegs_TagsCondition();
        const intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        let arrgs_TagsObjLst: Array<clsgs_TagsEN> = [];
        let arrgs_TagsExObjLst: Array<clsgs_TagsENEx> = [];
        try {
            this.RecCount = await gs_Tags_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortgs_TagsBy,
                sortFun: (x, y) => { return 0; }
            }
            arrgs_TagsObjLst = await gs_Tags_GetObjLstByPagerAsync(objPagerPara);
            arrgs_TagsExObjLst = arrgs_TagsObjLst.map(this.CopyToEx);
            for (var objInFor of arrgs_TagsExObjLst) {
                const conFuncMap = await this.FuncMap(objInFor);
            }
        }
        catch (e) {
            const strMsg = clsString.Format("绑定GridView不成功,{0}.", e);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        if (arrgs_TagsObjLst.length == 0) {
            const strKey = clsString.Format("{0}", clsgs_TagsEN._CurrTabName);
            const strMsg = clsString.Format("根据条件获取的记录数为0！(Key={0})", strKey);
            console.error("Error: ", strMsg);
            //console.trace();
            this.ShowEmptyRecNumInfo(strListDiv, strMsg);
            this.objPager.Hide(this.divName4Pager);
            return;
        }
        try {
            this.BindTab_gs_Tags4Func(strListDiv, arrgs_TagsExObjLst);
            console.log("完成BindGv_gs_Tags4Func!");
        }
        catch (e) {
            const strMsg = clsString.Format("绑定对象列表不成功.Error Massage:{0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
    * @param objgs_TagsENS:源对象
    * @returns 目标对象=>clsgs_TagsEN:objgs_TagsENT
    **/
    public CopyToEx(objgs_TagsENS: clsgs_TagsEN): clsgs_TagsENEx {
        var objgs_TagsENT = new clsgs_TagsENEx();
        try {
            gs_Tags_CopyObjTo(objgs_TagsENS, objgs_TagsENT);
            return objgs_TagsENT;
        }
        catch (e) {
            const strMsg = clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,{0}.", e);
            console.error(strMsg);
            alert(strMsg);
            return objgs_TagsENT;
        }
    }

    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
    * @param objgs_TagsS:源对象
    **/
    public async FuncMap(objgs_Tags: clsgs_TagsENEx) {
        try {
            {
                var Paper_PaperId = objgs_Tags.paperId;
                var Paper_PaperTitle = await Paper_func(clsPaperEN.con_PaperId, clsPaperEN.con_PaperTitle, Paper_PaperId);
                objgs_Tags.paperTitle = Paper_PaperTitle;
            }
            {
                var Users_UserId = objgs_Tags.updUser;
                var Users_UserName = await Users_func(clsUsersEN.con_UserId, clsUsersEN.con_UserName, Users_UserId);
                objgs_Tags.userName = Users_UserName;
            }
        }
        catch (e) {
            const strMsg = clsString.Format("(errid:WiTsCs0012)函数映射表对象数据出错,{0}.", e);
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
    public SortFun_ExportExcel(a: clsgs_TagsEN, b: clsgs_TagsEN): number {
        if (a.updDate == b.updDate) return a.updUser.localeCompare(b.updUser);
        else return a.updDate.localeCompare(b.updDate);
    }

    /** 函数功能:从界面列表中根据某一个字段排序
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
    * @param objAnchorElement:带有排序字段的Anchors
    **/
    public async SortBy(objAnchorElement: any) {
        console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
        //event = window.event || event;
        var thisEventObj: HTMLInputElement = objAnchorElement;
        var strFldName: string = thisEventObj.getAttribute("FldName") as string;
        if (clsString.IsNullOrEmpty(strFldName) == true) return;
        var strSortByFld: string = strFldName;
        if (this.hidSortgs_TagsBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortgs_TagsBy.indexOf("Asc") >= 0) {
                this.hidSortgs_TagsBy = clsString.Format("{0} Desc", strSortByFld);
            }
            else {
                this.hidSortgs_TagsBy = clsString.Format("{0} Asc", strSortByFld);
            }
        }
        else {
            this.hidSortgs_TagsBy = clsString.Format("{0} Asc", strSortByFld);
        }
        const responseBindGv = await this.BindGv_gs_Tags4Func();
    }

    /**
    * 在用户自定义控件中，设置关键字的值，是否只读
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    * @param bolReadonly:是否只读
    **/
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtTagsId').prop['ReadOnly'] = bolReadonly;
    }

    /** 复制记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
    **/
    public async CopyRecord(arrTagsId: Array<string>) {
        try {
            const responseText = await gs_Tags_GetObjLstByTagsIdLstAsync(arrTagsId);
            console.log('responseText=');
            console.log(responseText);
            var intCount: number = 0;
            var arrgs_TagsObjLst: Array<clsgs_TagsEN> = <Array<clsgs_TagsEN>>responseText;
            for (let objInFor of arrgs_TagsObjLst) {
                const strMaxStrId = await gs_Tags_GetMaxStrIdAsync();
                console.log('strMaxStrId=' + strMaxStrId);
                objInFor.tagsId = strMaxStrId;
                const responseText2 = await gs_Tags_AddNewRecordAsync(objInFor);
                console.log('responseText2=');
                console.log(responseText2);
                const returnBool: boolean = !!responseText2;
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
            const strMsg = clsString.Format("复制记录不成功,{0}.", e);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

    /** 根据关键字列表删除记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
    **/
    public async DelMultiRecord(arrTagsId: Array<string>) {
        try {
            const responseText = await gs_Tags_Delgs_TagssAsync(arrTagsId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                const strInfo = clsString.Format("删除记录成功,共删除${returnInt}条记录!");
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
            const strMsg = clsString.Format("删除记录不成功. {0}.", e);
            console.error(strMsg);
            alert(strMsg);
        }
    }

    /** 显示{0}对象的所有属性值
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
    * @param divContainer:显示容器
    * @param objgs_Tags:需要显示的对象
    **/
    public Showgs_TagsObj(divContainer: string, objgs_Tags: clsgs_TagsEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(clsString.Format("{}不存在！", divContainer));
            return;
        }
        const sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_Tags);
        var ul: HTMLUListElement = document.createElement("ul");
        for (const strKey of sstrKeys) {
            const strValue = objgs_Tags[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = clsString.Format("{0}:{1}", strKey, strValue);
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /** 函数功能:从界面列表中获取第一个关键字的值
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
    * @param pobjgs_TagsEN:表实体类对象
    * @returns 列表的第一个关键字值
    **/
    public GetFirstKey(): string {
        if (arrSelectedKeys.length == 1) {
            return arrSelectedKeys[0];
        }
        else {
            alert(`请选择一个关键字！目前选择了:${arrSelectedKeys.length}个关键字。`);
            return "";
        }
    }

    /**
    * 设置Session
     * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
     * @param Key:关键字
     * @param Value:值
     **/
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
                success: function (data: any) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log('strKey, strValue=' + strKey + strValue);
                }
            });
        });
    }
    /**
    * 设置排序字段-相当使用ViewState功能
    **/
    public set hidSortgs_TagsBy(value: string) {
        $("#hidSortgs_TagsBy").val(value);
    }
    /**
    * 设置排序字段
    **/
    public get hidSortgs_TagsBy(): string {
        return $("#hidSortgs_TagsBy").val();
    }
    /**
    * 论文Id (Used In CombineCondition())
    **/
    public get PaperId_q(): string {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlPaperId_q");
        const strId = clsString.Format("select[id ^= 'ddlPaperId_q']");
        const objElem = objDiv.find(strId);
        if (objElem == undefined) return "";
        else {
            const strValue = objElem.val();
            if (strValue == undefined) return "";
            else if (strValue == "0") return "";
            else return strValue;
        }
    }
    /**
    * 论文Id (Used In CombineCondition())
    **/
    public set PaperId_q(value: string) {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlPaperId_q");
        const strId = clsString.Format("select[id ^= 'ddlPaperId_q']");
        objDiv.find(strId).val(value);
    }
    /**
    * 标注内容 (Used In CombineCondition())
    **/
    public get TagsContent_q(): string {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtTagsContent_q");
        const strId = clsString.Format("input[id ^= 'txtTagsContent_q']");
        const objElem = objDiv.find(strId);
        if (objElem == undefined) return "";
        else {
            const strValue = objElem.val();
            if (strValue == undefined) return "";
            else return strValue.toString();
        }
    }
    /**
    * 标注内容 (Used In CombineCondition())
    **/
    public set TagsContent_q(value: string) {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtTagsContent_q");
        const strId = clsString.Format("input[id ^= 'txtTagsContent_q']");
        objDiv.find(strId).val(value);
    }
    /**
    * 标注类型ID (Used In CombineCondition())
    **/
    public get TagsTypeId_q(): string {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlTagsTypeId_q");
        const strId = clsString.Format("select[id ^= 'ddlTagsTypeId_q']");
        const objElem = objDiv.find(strId);
        if (objElem == undefined) return "";
        else {
            const strValue = objElem.val();
            if (strValue == undefined) return "";
            else if (strValue == "0") return "";
            else return strValue;
        }
    }
    /**
    * 标注类型ID (Used In CombineCondition())
    **/
    public set TagsTypeId_q(value: string) {
        const objDiv = $(`#${this.divName4Query}`);
        clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlTagsTypeId_q");
        const strId = clsString.Format("select[id ^= 'ddlTagsTypeId_q']");
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

function gs_Tags_GetRecCountByCond_Cache(objgs_Tags_Cond: clsgs_TagsEN): number | PromiseLike<number> {
    throw new Error("Function not implemented.");
}
