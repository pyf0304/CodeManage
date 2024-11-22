﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_ResearchResultCRUD
表名:gs_ResearchResult(01120780)
生成代码版本:2020.12.17.1
生成日期:2020/12/22 22:18:00
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsgs_ResearchResultEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchResultEN.js";
import { clsvgs_ResearchResultEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchResultEN.js";
import { gs_ResearchResult_AddNewRecordAsync, gs_ResearchResult_Delgs_ResearchResultsAsync, gs_ResearchResult_DelRecordAsync, gs_ResearchResult_GetObjByResultIdAsync, gs_ResearchResult_GetObjLstByResultIdLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultWApi.js";
import { vgs_ResearchResult_GetObjLstAsync, vgs_ResearchResult_GetObjLstByPagerAsync, vgs_ResearchResult_GetObjLstByPager_Cache, vgs_ResearchResult_GetRecCountByCondAsync, vgs_ResearchResult_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchResultWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_ResearchResult(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_ResearchResult(): void;
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
/* gs_ResearchResultCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class gs_ResearchResultCRUD implements clsOperateList{
    public mstrListDiv: string = "divDataLst";//列表区数据列表层id
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public bolIsLoadDetailRegion: boolean = false;  //记录是否导入详细信息区的变量
    public divName4Edit: string = "divResearchResultEdit";  //编辑区的Id
    public divName4Detail: string = "divDetail";  //详细信息区的Id
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvgs_ResearchResultBy = "resultName Asc";
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_vgs_ResearchResult();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
   */
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvgs_ResearchResultBy = "resultName Asc";
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_vgs_ResearchResult();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }


    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    public async btnQuery_Click() {
        this.CurrPageIndex = 1;
        const responseBindGv = await this.BindGv_vgs_ResearchResult();
    }

    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
    }


    /*
     添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
    */
    public async btnCopyRecord_Click() {
        try {
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要克隆的记录！");
                return "";
            }
            const responseText = await this.CopyRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vgs_ResearchResult();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `复制记录不成功,${e}.`;
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
            const responseText = await this.DelRecord(strKeyId);
            const responseBindGv = await this.BindGv_vgs_ResearchResult();
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
            this.SelectRecord(strKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `选择记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord(strResultId: string) {
        try {
            const responseText = await gs_ResearchResult_DelRecordAsync(strResultId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_ResearchResult_ReFreshCache();
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
    根据关键字选择相应的记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
     <param name = "sender">参数列表</param>
   */
    public async SelectRecord(strResultId: string) {
        try {
            const responseText = await gs_ResearchResult_GetObjByResultIdAsync(strResultId);
            var objgs_ResearchResultEN: clsgs_ResearchResultEN = <clsgs_ResearchResultEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_vgs_ResearchResult");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
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
            const responseBindGv = await this.BindGv_vgs_ResearchResult();
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
            const responseText = await vgs_ResearchResult_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrvgs_ResearchResultObjLst: Array<clsvgs_ResearchResultEN> = <Array<clsvgs_ResearchResultEN>>jsonData;
                this.BindTab_vgs_ResearchResult(this.mstrListDiv, arrvgs_ResearchResultObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `导出Excel不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public Combinevgs_ResearchResultCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.ResultName_q != "") {
                strWhereCond += ` And ${clsvgs_ResearchResultEN.con_ResultName} like '% ${this.ResultName_q}%'`;
            }
            if (this.UpdDate_q != "") {
                strWhereCond += ` And ${clsvgs_ResearchResultEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_ResearchResultCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public Combinevgs_ResearchResultConditionObj(): clsvgs_ResearchResultEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvgs_ResearchResult_Cond: clsvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.ResultName_q != "") {
                strWhereCond += ` And ${clsvgs_ResearchResultEN.con_ResultName} like '% ${this.ResultName_q}%'`;
                objvgs_ResearchResult_Cond.SetCondFldValue(clsvgs_ResearchResultEN.con_ResultName, this.ResultName_q, "like");
            }
            if (this.UpdDate_q != "") {
                strWhereCond += ` And ${clsvgs_ResearchResultEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
                objvgs_ResearchResult_Cond.SetCondFldValue(clsvgs_ResearchResultEN.con_UpdDate, this.UpdDate_q, "like");
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0010)在组合查询条件对象(Combinegs_ResearchResultConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvgs_ResearchResult_Cond;
    }

    /* 显示vgs_ResearchResult对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrgs_ResearchResultObjLst">需要绑定的对象列表</param>
   */
    public BindTab_vgs_ResearchResult(divContainer: string, arrvgs_ResearchResultObjLst: Array<clsvgs_ResearchResultEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "resultName",
                    SortBy: "resultName",
                    ColHeader: "成果名称",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "resultContent",
                    SortBy: "resultContent",
                    ColHeader: "成果内容",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    SortBy: "author",
                    ColHeader: "作者",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "division",
                    SortBy: "division",
                    ColHeader: "分工",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "okCount",
                    SortBy: "okCount",
                    ColHeader: "点赞统计",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "appraiseCount",
                    SortBy: "appraiseCount",
                    ColHeader: "评论数",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
                {
                    FldName: "score",
                    SortBy: "score",
                    ColHeader: "评分",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 8,
                    FuncName: () => { }
                },
                {
                    FldName: "stuScore",
                    SortBy: "stuScore",
                    ColHeader: "学生平均分",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 9,
                    FuncName: () => { }
                },
                {
                    FldName: "teaScore",
                    SortBy: "teaScore",
                    ColHeader: "教师评分",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 10,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 11,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 12,
                    FuncName: () => { }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvgs_ResearchResultObjLst, arrDataColumn, "resultId");
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
        const responseBindGv = await this.BindGv_vgs_ResearchResult();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vgs_ResearchResult() {
        if (this.hidSortvgs_ResearchResultBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_ResearchResultBy)为空，请检查！(In BindGv_vgs_ResearchResult)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.Combinevgs_ResearchResultCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvgs_ResearchResultObjLst: Array<clsvgs_ResearchResultEN> = [];
        try {
            const responseRecCount = await vgs_ResearchResult_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_ResearchResultBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_ResearchResult_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_ResearchResultObjLst = <Array<clsvgs_ResearchResultEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
        if (arrvgs_ResearchResultObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vgs_ResearchResult(strListDiv, arrvgs_ResearchResultObjLst);
            console.log("完成BindGv_vgs_ResearchResult!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            //console.trace();
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
   */
    public async BindGv_vgs_ResearchResult_Cache() {
        if (this.hidSortvgs_ResearchResultBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_ResearchResultBy)为空，请检查！(In BindGv_vgs_ResearchResult_Cache)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var objvgs_ResearchResult_Cond = this.Combinevgs_ResearchResultConditionObj();
        var strWhereCond = JSON.stringify(objvgs_ResearchResult_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvgs_ResearchResultObjLst: Array<clsvgs_ResearchResultEN> = [];
        try {
            this.RecCount = await vgs_ResearchResult_GetRecCountByCond_Cache(objvgs_ResearchResult_Cond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_ResearchResultBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrvgs_ResearchResultObjLst = await vgs_ResearchResult_GetObjLstByPager_Cache(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
            return;
        }
        if (arrvgs_ResearchResultObjLst.length == 0) {
            var strKey: string = `${clsgs_ResearchResultEN._CurrTabName}`;
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vgs_ResearchResult(strListDiv, arrvgs_ResearchResultObjLst);
            console.log("完成BindGv_vgs_ResearchResult!");
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
        if (this.hidSortvgs_ResearchResultBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvgs_ResearchResultBy.indexOf("Asc") >= 0) {
                this.hidSortvgs_ResearchResultBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvgs_ResearchResultBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvgs_ResearchResultBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vgs_ResearchResult();
    }

    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtResultId').prop['ReadOnly'] = bolReadonly;
    }

    /* 复制记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
   */
    public async CopyRecord(arrResultId: Array<string>) {
        try {
            const responseText = await gs_ResearchResult_GetObjLstByResultIdLstAsync(arrResultId);
            console.log('responseText=');
            console.log(responseText);
            var intCount: number = 0;
            var arrgs_ResearchResultObjLst: Array<clsgs_ResearchResultEN> = <Array<clsgs_ResearchResultEN>>responseText;
            for (let objInFor of arrgs_ResearchResultObjLst) {
                const responseText2 = await gs_ResearchResult_AddNewRecordAsync(objInFor);
                console.log('responseText2=');
                console.log(responseText2);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    //gs_ResearchResult_ReFreshCache();
                    var strInfo: string = `克隆记录成功!`;
                    intCount++;
                }
                else {
                    var strInfo: string = `克隆记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
            }
            var strInfo: string = `共克隆了${intCount}条记录!`;
            alert(strInfo);
            console.log('完成！');
        }
        catch (e) {
            var strMsg: string = `复制记录不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public async DelMultiRecord(arrResultId: Array<string>) {
        try {
            const responseText = await gs_ResearchResult_Delgs_ResearchResultsAsync(arrResultId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_ResearchResult_ReFreshCache();
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
     <param name = "objgs_ResearchResult">需要显示的对象</param>
   */
    public Showgs_ResearchResultObj(divContainer: string, objgs_ResearchResult: clsgs_ResearchResultEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_ResearchResult);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objgs_ResearchResult[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjgs_ResearchResultEN">表实体类对象</param>
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
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 获取当前页序号(Used In BindGv_)
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvgs_ResearchResultBy(value: string) {
        $("#hidSortvgs_ResearchResultBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_ResearchResultBy(): string {
        return $("#hidSortvgs_ResearchResultBy").val();
    }
    /*
    * 成果名称 (Used In CombineCondition())
   */
    public get ResultName_q(): string {
        return $("#txtResultName_q").val();
    }
    /*
    * 修改日期 (Used In CombineCondition())
   */
    public get UpdDate_q(): string {
        return $("#txtUpdDate_q").val();
    }
}