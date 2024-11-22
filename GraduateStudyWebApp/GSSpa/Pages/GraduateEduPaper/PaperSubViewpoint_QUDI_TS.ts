/*-- -- -- -- -- -- -- -- -- -- --
类名:PaperSubViewpoint_QUDI_TS
表名:PaperSubViewpoint(01120534)
生成代码版本:2020.03.03.1
生成日期:2020/03/12 02:22:23
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEduPaper
框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js";

import { clsSectionEN } from "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js";
import { clsvPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsExplainTypeEN } from "../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js";
import { clsSubViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js";
import { PaperSubViewpoint_AddNewRecordAsync, PaperSubViewpoint_DelPaperSubViewpointsAsync, PaperSubViewpoint_DownMoveAsync, PaperSubViewpoint_GetMaxStrIdAsync, PaperSubViewpoint_GetObjBySubViewpointIdAsync, PaperSubViewpoint_GoBottomAsync, PaperSubViewpoint_GoTopAsync, PaperSubViewpoint_IsExistAsync, PaperSubViewpoint_ReOrderAsync, PaperSubViewpoint_UpdateRecordAsync, PaperSubViewpoint_UpMoveAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js";
import { Section_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js";
import { vPaperSubViewpoint_GetObjLstAsync, vPaperSubViewpoint_GetObjLstByPagerAsync, vPaperSubViewpoint_GetObjLstByPager_Cache, vPaperSubViewpoint_GetRecCountByCondAsync, vPaperSubViewpoint_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { ExplainType_BindDdl_ExplainTypeIdInDiv_Cache, ExplainType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js";
import { SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache, SubViewpointType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { clsOrderByData } from "../TS/PubFun/clsOrderByData.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
 
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;
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
/* PaperSubViewpoint_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class PaperSubViewpoint_QUDI_TS implements clsOperateList{
    public mstrListDiv: string = "divDataLst";
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;


    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public AddNewRecord() {
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucPaperSubViewpointB1.subViewpointId = clsPaperSubViewpointBL.GetMaxStrId_S();
    }

    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        try {
            const responseText2 = await PaperSubViewpoint_AddNewRecordAsync(objPaperSubViewpointEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
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
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucPaperSubViewpointB1.subViewpointId = clsPaperSubViewpointBL.GetMaxStrId_S();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vPaperSubViewpoint() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevPaperSubViewpointCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN> = [];
        try {
            const responseRecCount = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperSubViewpointBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperSubViewpointObjLst = <Array<clsvPaperSubViewpointEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvPaperSubViewpointObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vPaperSubViewpoint(strListDiv, arrvPaperSubViewpointObjLst);
            console.log("完成BindGv_vPaperSubViewpoint!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
   */
    public async BindGv_vPaperSubViewpoint_Cache() {
        var strListDiv: string = this.mstrListDiv;
        var objvPaperSubViewpoint_Cond = this.CombinevPaperSubViewpointConditionObj();
        var strWhereCond = JSON.stringify(objvPaperSubViewpoint_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN> = [];
        try {
            this.RecCount = await vPaperSubViewpoint_GetRecCountByCond_Cache(objvPaperSubViewpoint_Cond, clsPublocalStorage.Getid_CurrEduCls());
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperSubViewpointBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrvPaperSubViewpointObjLst = await vPaperSubViewpoint_GetObjLstByPager_Cache(objPagerPara, clsPublocalStorage.Getid_CurrEduCls());
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvPaperSubViewpointObjLst.length == 0) {
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=PaperSubViewpoint)`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vPaperSubViewpoint(strListDiv, arrvPaperSubViewpointObjLst);
            console.log("完成BindGv_vPaperSubViewpoint!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vPaperSubViewpoint对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrPaperSubViewpointObjLst">需要绑定的对象列表</param>
   */
    public BindTab_vPaperSubViewpoint(divContainer: string, arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN>) {
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
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperRWId",
                    ColHeader: "论文读写Id",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "subViewpointTypeName",
                    ColHeader: "类型名称",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "rwTitle",
                    ColHeader: "读写标题",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "subViewpointContent",
                    ColHeader: "详情内容",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "explainTypeName",
                    ColHeader: "说明类型名",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isPublic",
                    ColHeader: "是否公开",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "orderNum",
                    ColHeader: "序号",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改用户Id",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改",TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除",TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvPaperSubViewpointObjLst, arrDataColumn, "subViewpointId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.OpType = "Add";
        try {
            const responseText = await this.AddNewRecord();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
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
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
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
            //const responseText = await this.DelRecord(lngKeyId).then((jsonData) => {
            //    ;
            //});
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
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
            var lngKeyId = strKeyId;
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
    下移
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
    */
    public async btnDownMove_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = this.SubViewpointTypeId_OrderNum;
        var strPaperRWId: string = this.PaperRWId_OrderNum;
        var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert(`请选择需要下移的记录!`);
            return;
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_DownMoveAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `下移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        var strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
   */
    public async btnExportExcel_Click() {
        var strWhereCond = " 1=1 ";
        try {
            const responseText = await vPaperSubViewpoint_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN> = <Array<clsvPaperSubViewpointEN>>jsonData;
                this.BindTab_vPaperSubViewpoint(this.mstrListDiv, arrvPaperSubViewpointObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `导出Excel不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*
    置底
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoBottum_Click)
    */
    public async btnGoBottum_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = this.SubViewpointTypeId_OrderNum;
        var strPaperRWId: string = this.PaperRWId_OrderNum;
        var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert("请选择需要置底的记录！");
            return "";
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_GoBottomAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `置底出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        var strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /* 置顶
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoTop_Click)
    */
    public async btnGoTop_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = this.SubViewpointTypeId_OrderNum;
        var strPaperRWId: string = this.PaperRWId_OrderNum;
        var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert("请选择需要置顶的记录！");
            return "";
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_GoTopAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `置顶出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        var strListDiv: string = this.mstrListDiv;
        var strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnOKUpd;
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
                        //HideDialog();
                        //this.BindGv_vPaperSubViewpoint();
                        //}
                        //});
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vPaperSubViewpoint();
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_vPaperSubViewpoint();
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    public async btnQuery_Click(strListDiv: string) {
        var strWhereCond = this.CombinevPaperSubViewpointCondition();
        try {
            const responseRecCount = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperSubViewpointBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                var arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN> = <Array<clsvPaperSubViewpointEN>>jsonData;
                this.BindTab_vPaperSubViewpoint(this.mstrListDiv, arrvPaperSubViewpointObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `查询不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*
    重序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
    */
    public async btnReOrder_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = this.SubViewpointTypeId_OrderNum;
        var strPaperRWId: string = this.PaperRWId_OrderNum;
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_ReOrderAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `重序出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
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
            var lngKeyId = strKeyId;
            this.SelectRecord(lngKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `选择记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
   */
    public btnUpdateRecord_Click(strKeyId: string) {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        var lngKeyId = strKeyId;
        this.UpdateRecord(lngKeyId);
    }

    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public btnUpdateRecordInTab_Click(strKeyId: string) {
        this.OpType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        var lngKeyId = strKeyId;
        this.UpdateRecord(lngKeyId);
    }

    /*
    上移
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
    */
    public async btnUpMove_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = this.SubViewpointTypeId_OrderNum;
        var strPaperRWId: string = this.PaperRWId_OrderNum;
        var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        if (arrKeyIds.length == 0) {
            alert(`请选择需要上移的记录!`);
            return;
        }
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_UpMoveAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `上移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        var strListDiv: string = this.mstrListDiv;
        arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.paperRWId = "";
        $('#ddlSectionId option[0]').attr("selected", true);
        $('#ddlSubViewpointTypeId option[0]').attr("selected", true);
        this.rwTitle = "";
        this.subViewpointContent = "";
        $('#ddlExplainTypeId option[0]').attr("selected", true);
        this.explainContent = "";
        this.isPublic = false;
        this.literatureSourcesId = "";
        this.pageNumber = 0;
        this.orderNum = 0;
        this.updUser = "";
        this.updDate = "";
        this.memo = "";
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevPaperSubViewpointCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperRWId_q != "") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_PaperRWId} like '% ${this.PaperRWId_q}%'`;
            }
            if (this.SectionId_q != "" && this.SectionId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
            }
            if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
            }
            if (this.ExplainTypeId_q != "" && this.ExplainTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_ExplainTypeId} = '${this.ExplainTypeId_q}'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevPaperSubViewpointConditionObj(): clsvPaperSubViewpointEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvPaperSubViewpoint_Cond: clsvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperRWId_q != "") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_PaperRWId} like '% ${this.PaperRWId_q}%'`;
                objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN.con_PaperRWId, this.PaperRWId_q, "like");
            }
            if (this.SectionId_q != "" && this.SectionId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
                objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN.con_SectionId, this.SectionId_q, "=");
            }
            if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
                objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN.con_SubViewpointTypeId, this.SubViewpointTypeId_q, "=");
            }
            if (this.ExplainTypeId_q != "" && this.ExplainTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_ExplainTypeId} = '${this.ExplainTypeId_q}'`;
                objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN.con_ExplainTypeId, this.ExplainTypeId_q, "=");
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombinePaperSubViewpointConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvPaperSubViewpoint_Cond;
    }

    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public DelMultiRecord(arrSubViewpointId: Array<string>) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubViewpoint_DelPaperSubViewpointsAsync(arrSubViewpointId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
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
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    //public DelRecord(lngSubViewpointId: number): Promise<number> {
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = PaperSubViewpoint_DelRecordAsync(lngSubViewpointId).then((jsonData) => {
    //                var returnInt: number = jsonData;
    //                if (returnInt > 0) {
    //                    var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
    //                    //显示信息框
    //                    alert(strInfo);
    //                }
    //                else {
    //                    var strInfo: string = `删除记录不成功!`;
    //                    //显示信息框
    //                    alert(strInfo);
    //                }
    //                console.log("完成DelRecord!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            console.error('catch(e)=');
    //            console.error(e);
    //            var strMsg: string = `删除记录不成功. ${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}

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
    根据关键字详细信息记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
     <param name = "sender">参数列表</param>
   */
    public DetailRecord(lngSubViewpointId: string) {
        this.btnOKUpd = "";
        this.btnCancel = "关闭";
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubViewpoint_GetObjBySubViewpointIdAsync(lngSubViewpointId).then((jsonData) => {
                    var objPaperSubViewpointEN: clsPaperSubViewpointEN = <clsPaperSubViewpointEN>jsonData;
                    this.GetDataFromPaperSubViewpointClass(objPaperSubViewpointEN);
                    console.log("完成DetailRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjPaperSubViewpointEN">表实体类对象</param>
   */
    public GetDataFromPaperSubViewpointClass(pobjPaperSubViewpointEN: clsPaperSubViewpointEN) {
        this.paperRWId = pobjPaperSubViewpointEN.paperRWId;// 论文读写Id
        this.sectionId = pobjPaperSubViewpointEN.sectionId;// 节Id
        this.subViewpointTypeId = pobjPaperSubViewpointEN.subViewpointTypeId;// 类型Id
        this.rwTitle = pobjPaperSubViewpointEN.rwTitle;// 读写标题
        this.subViewpointContent = pobjPaperSubViewpointEN.subViewpointContent;// 详情内容
        this.explainTypeId = pobjPaperSubViewpointEN.explainTypeId;// 说明类型Id
        this.explainContent = pobjPaperSubViewpointEN.explainContent;// 说明内容
        this.isPublic = pobjPaperSubViewpointEN.isPublic;// 是否公开
        this.literatureSourcesId = pobjPaperSubViewpointEN.literatureSourcesId;// 文献来源

        this.pageNumber = pobjPaperSubViewpointEN.pageNumber;// 页码
        this.orderNum = pobjPaperSubViewpointEN.orderNum;// 序号
        this.updUser = pobjPaperSubViewpointEN.updUser;// 修改用户Id
        this.updDate = pobjPaperSubViewpointEN.updDate;// 修改日期
        this.memo = pobjPaperSubViewpointEN.memo;// 备注
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjPaperSubViewpointEN">表实体类对象</param>
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

    /* 获取当前表关键字值的最大值,再加1,避免重复
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
   */
    public async GetMaxStrId(strKeyCtrlName) {
        this.DivName = "divGetMaxStrId";
        try {
            const responseText = await PaperSubViewpoint_GetMaxStrIdAsync();
            var returnString: string = responseText.toString();
            if (returnString == "") {
                var strInfo: string = `获取表PaperSubViewpoint的最大关键字为空，不成功，请检查!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                $(strKeyCtrlName).val(returnString);
            }
            else {
                var strInfo: string = `获取表PaperSubViewpoint的最大关键字为：${returnString}!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                $(strKeyCtrlName).val(returnString);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
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
        this.BindGv_vPaperSubViewpoint();
    }

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            //建立缓存
            
            const arrSection_Cache = await Section_GetObjLstAsync("1=1");//查询区域
            const arrSubViewpointType_Cache = await SubViewpointType_GetObjLstAsync("1=1");//查询区域
            const arrExplainType_Cache = await ExplainType_GetObjLstAsync("1=1");//查询区域
            const arrvPaperSubViewpoint_Cache = await vPaperSubViewpoint_GetObjLstAsync("1=1");
            var objSection_Cond: clsSectionEN = new clsSectionEN();//查询区域
            var objSubViewpointType_Cond: clsSubViewpointTypeEN = new clsSubViewpointTypeEN();//查询区域
            var objExplainType_Cond: clsExplainTypeEN = new clsExplainTypeEN();//查询区域
                        var strPaperId_q: string = "";
            //const ddlSectionId_q = Section_BindDdl_SectionId_Cache("ddlSectionId_q", objSection_Cond, strPaperId_q);//查询区域
            await SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache(this.divName4List, "ddlSubViewpointTypeId_q");//查询区域
            await ExplainType_BindDdl_ExplainTypeIdInDiv_Cache(this.divName4List, "ddlExplainTypeId_q");//查询区域
            var strPaperId: string = "";
            //const ddlSectionId = Section_BindDdl_SectionId_Cache("ddlSectionId", objSection_Cond, strPaperId);//编辑区域
            await SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache(this.divName4List, "ddlSubViewpointTypeId");//编辑区域
            await ExplainType_BindDdl_ExplainTypeIdInDiv_Cache(this.divName4List, "ddlExplainTypeId");//编辑区域
            await SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache(this.divName4List, "ddlSubViewpointTypeId_OrderNum");//功能区域
            this.hidSortvPaperSubViewpointBy = "paperRWId Asc";
            var strWhereCond = this.CombinevPaperSubViewpointCondition();
            const responseText = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vPaperSubViewpoint();
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
            
            const arrSection_Cache = await Section_GetObjLstAsync("1=1");//查询区域
            const arrSubViewpointType_Cache = await SubViewpointType_GetObjLstAsync("1=1");//查询区域
            const arrExplainType_Cache = await ExplainType_GetObjLstAsync("1=1");//查询区域
            const arrvPaperSubViewpoint_Cache = await vPaperSubViewpoint_GetObjLstAsync("1=1");
            var objSection_Cond: clsSectionEN = new clsSectionEN();//查询区域
            var objSubViewpointType_Cond: clsSubViewpointTypeEN = new clsSubViewpointTypeEN();//查询区域
            var objExplainType_Cond: clsExplainTypeEN = new clsExplainTypeEN();//查询区域

            var strPaperId_q: string = "";
            //const ddlSectionId_q = Section_BindDdl_SectionId_Cache("ddlSectionId_q", objSection_Cond, strPaperId_q);//查询区域
             await SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache(this.divName4List, "ddlSubViewpointTypeId_q");//查询区域
            await ExplainType_BindDdl_ExplainTypeIdInDiv_Cache(this.divName4List, "ddlExplainTypeId_q");//查询区域
            var strPaperId: string = "";
            //const ddlSectionId = Section_BindDdl_SectionId_Cache("ddlSectionId", objSection_Cond, strPaperId);//编辑区域
            await SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache(this.divName4List, "ddlSubViewpointTypeId");//编辑区域
            await ExplainType_BindDdl_ExplainTypeIdInDiv_Cache(this.divName4List, "ddlExplainTypeId");//编辑区域
            await SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache(this.divName4List, "ddlSubViewpointTypeId_OrderNum");//功能区域
            this.hidSortvPaperSubViewpointBy = "paperRWId Asc";
            var objvPaperSubViewpoint_Cond = this.CombinevPaperSubViewpointConditionObj();
            this.RecCount = await vPaperSubViewpoint_GetRecCountByCond_Cache(objvPaperSubViewpoint_Cond, clsPublocalStorage.Getid_CurrEduCls());
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vPaperSubViewpoint_Cache();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }


    /*
    移动记录序号时的预检查函数
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
    */
    public PreCheck4Order(): boolean {
        var strSubViewpointTypeId: string = this.SubViewpointTypeId_OrderNum;
        if (strSubViewpointTypeId == "") {
            var strMsg = `请输入subViewpointTypeId!`;
            alert(strMsg);
            return false;
        }
        var strPaperRWId: string = this.PaperRWId_OrderNum;
        if (strPaperRWId == "") {
            var strMsg = `请输入paperRWId!`;
            alert(strMsg);
            return false;
        }
        return true;
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjPaperSubViewpointEN">数据传输的目的类对象</param>
   */
    public PutDataToPaperSubViewpointClass(pobjPaperSubViewpointEN: clsPaperSubViewpointEN) {
        pobjPaperSubViewpointEN.paperRWId = this.paperRWId;// 论文读写Id
        pobjPaperSubViewpointEN.sectionId = this.sectionId;// 节Id
        pobjPaperSubViewpointEN.subViewpointTypeId = this.subViewpointTypeId;// 类型Id
        pobjPaperSubViewpointEN.rwTitle = this.rwTitle;// 读写标题
        pobjPaperSubViewpointEN.subViewpointContent = this.subViewpointContent;// 详情内容
        pobjPaperSubViewpointEN.explainTypeId = this.explainTypeId;// 说明类型Id
        pobjPaperSubViewpointEN.explainContent = this.explainContent;// 说明内容
        pobjPaperSubViewpointEN.isPublic = this.isPublic;// 是否公开
        pobjPaperSubViewpointEN.literatureSourcesId = this.literatureSourcesId;// 文献来源
        pobjPaperSubViewpointEN.pageNumber = this.pageNumber;// 页码
        pobjPaperSubViewpointEN.orderNum = this.orderNum;// 序号
        pobjPaperSubViewpointEN.updUser = this.updUser;// 修改用户Id
        pobjPaperSubViewpointEN.updDate = this.updDate;// 修改日期
        pobjPaperSubViewpointEN.memo = this.memo;// 备注
    }


    /* 
    根据关键字选择相应的记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
     <param name = "sender">参数列表</param>
   */
    public async SelectRecord(lngSubViewpointId: string) {
        try {
            const responseText = await PaperSubViewpoint_GetObjBySubViewpointIdAsync(lngSubViewpointId);
            var objPaperSubViewpointEN: clsPaperSubViewpointEN = <clsPaperSubViewpointEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_vPaperSubViewpoint");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
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

    /* 函数功能:把以该关键字的记录内容显示在界面上,
          在这里是把值传到表控件中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
     <param name = "lngSubViewpointId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(lngSubViewpointId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        try {
            const responseText = await PaperSubViewpoint_IsExistAsync(lngSubViewpointId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${lngSubViewpointId}] 的记录不存在!`;
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
            const responseText = await PaperSubViewpoint_GetObjBySubViewpointIdAsync(lngSubViewpointId);
            objPaperSubViewpointEN = <clsPaperSubViewpointEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromPaperSubViewpointClass(objPaperSubViewpointEN);
    }

    /* 显示{0}对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
     <param name = "divContainer">显示容器</param>
     <param name = "objPaperSubViewpoint">需要显示的对象</param>
   */
    public ShowPaperSubViewpointObj(divContainer: string, objPaperSubViewpoint: clsPaperSubViewpointEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objPaperSubViewpoint);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objPaperSubViewpoint[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中根据某一个字段排序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     <param name = "strSortByFld">排序的字段</param>
   */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvPaperSubViewpointBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvPaperSubViewpointBy.indexOf("Asc") >= 0) {
                this.hidSortvPaperSubViewpointBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvPaperSubViewpointBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvPaperSubViewpointBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public UpdateRecord(strSubViewpointId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strSubViewpointId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId).then((jsonData) => {
                    var objPaperSubViewpointEN: clsPaperSubViewpointEN = <clsPaperSubViewpointEN>jsonData;
                    this.GetDataFromPaperSubViewpointClass(objPaperSubViewpointEN);
                    console.log("完成UpdateRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public UpdateRecordSave(): Promise<boolean> {
        this.DivName = "divUpdateRecordSave";
        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        objPaperSubViewpointEN.subViewpointId = this.KeyId;
        this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubViewpoint_UpdateRecordAsync(objPaperSubViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `修改记录成功!`;
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        var strInfo: string = `修改记录不成功!`;
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("完成UpdateRecordSave");
                    }
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        });
    }
    /*
    * 设置取消按钮的标题
   */
    public set btnCancel(value: string) {
        $("#btnCancel").html(value);
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnOKUpd(value: string) {
        $("#btnOKUpd").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd(): string {
        return $("#btnOKUpd").html();
    }
    /*
    * 获取当前页序号
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
    }
    /*
    * 说明内容
   */
    public set explainContent(value: string) {
        $("#txtExplainContent").val(value);
    }
    /*
    * 说明内容
   */
    public get explainContent(): string {
        return $("#txtExplainContent").val();
    }
    /*
    * 说明类型Id
   */
    public set explainTypeId(value: string) {
        $("#ddlExplainTypeId").val(value);
    }
    /*
    * 说明类型Id
   */
    public get explainTypeId(): string {
        return $("#ddlExplainTypeId").val();
    }
    /*
    * 说明类型Id
   */
    public get ExplainTypeId_q(): string {
        return $("#ddlExplainTypeId_q").val();
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvPaperSubViewpointBy(value: string) {
        $("#hidSortvPaperSubViewpointBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvPaperSubViewpointBy(): string {
        return $("#hidSortvPaperSubViewpointBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return $("#hidUserId").val();
    }
    /*
    * 是否公开
   */
    public set isPublic(value: boolean) {
        $("#chkIsPublic").val(value);
    }
    /*
    * 是否公开
   */
    public get isPublic(): boolean {
        return $("#chkIsPublic").prop("checked");
    }
    /*
    * 设置关键字的值
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
    * 文献来源
   */
    public set literatureSourcesId(value: string) {
        $("#txtLiteratureSourcesId").val(value);
    }
    /*
    * 文献来源
   */
    public get literatureSourcesId(): string {
        return $("#txtLiteratureSourcesId").val();
    }
    /*
    * 备注
   */
    public set memo(value: string) {
        $("#txtMemo").val(value);
    }
    /*
    * 备注
   */
    public get memo(): string {
        return $("#txtMemo").val();
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
    * 序号
   */
    public set orderNum(value: number) {
        $("#txtOrderNum").val(value);
    }
    /*
    * 序号
   */
    public get orderNum(): number {
        return $("#txtOrderNum").val();
    }
    /*
    * 页码
   */
    public set pageNumber(value: number) {
        $("#txtPageNumber").val(value);
    }
    /*
    * 页码
   */
    public get pageNumber(): number {
        return $("#txtPageNumber").val();
    }
    /*
    * 论文读写Id
   */
    public set paperRWId(value: string) {
        $("#txtPaperRWId").val(value);
    }
    /*
    * 论文读写Id
   */
    public get paperRWId(): string {
        return $("#txtPaperRWId").val();
    }
    /*
    * paperRWId
   */
    public get PaperRWId_OrderNum(): string {
        return $("#txtPaperRWId_OrderNum").val();
    }
    /*
    * 论文读写Id
   */
    public get PaperRWId_q(): string {
        return $("#txtPaperRWId_q").val();
    }
    /*
    * 读写标题
   */
    public set rwTitle(value: string) {
        $("#txtRWTitle").val(value);
    }
    /*
    * 读写标题
   */
    public get rwTitle(): string {
        return $("#txtRWTitle").val();
    }
    /*
    * 节Id
   */
    public set sectionId(value: string) {
        $("#ddlSectionId").val(value);
    }
    /*
    * 节Id
   */
    public get sectionId(): string {
        return $("#ddlSectionId").val();
    }
    /*
    * 节Id
   */
    public get SectionId_q(): string {
        return $("#ddlSectionId_q").val();
    }
    /*
    * 详情内容
   */
    public set subViewpointContent(value: string) {
        $("#txtSubViewpointContent").val(value);
    }
    /*
    * 详情内容
   */
    public get subViewpointContent(): string {
        return $("#txtSubViewpointContent").val();
    }
    /*
    * 类型Id
   */
    public set subViewpointTypeId(value: string) {
        $("#ddlSubViewpointTypeId").val(value);
    }
    /*
    * 类型Id
   */
    public get subViewpointTypeId(): string {
        return $("#ddlSubViewpointTypeId").val();
    }
    /*
    * subViewpointTypeId
   */
    public get SubViewpointTypeId_OrderNum(): string {
        return $("#ddlSubViewpointTypeId_OrderNum").val();
    }
    /*
    * 类型Id
   */
    public get SubViewpointTypeId_q(): string {
        return $("#ddlSubViewpointTypeId_q").val();
    }
    /*
    * 修改日期
   */
    public set updDate(value: string) {
        $("#txtUpdDate").val(value);
    }
    /*
    * 修改日期
   */
    public get updDate(): string {
        return $("#txtUpdDate").val();
    }
    /*
    * 修改用户Id
   */
    public set updUser(value: string) {
        $("#txtUpdUser").val(value);
    }
    /*
    * 修改用户Id
   */
    public get updUser(): string {
        return $("#txtUpdUser").val();
    }

    /*
   * 观点态度
  */
    public set attitudesId(value: string) {
        $("#ddlAttitudesId").val(value);
    }
    /*
    * 观点态度Id
   */
    public get attitudesId(): string {
        return $("#ddl").val();
    }
}