
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TeachingDateCRUD
表名:gs_TeachingDate(01120684)
生成代码版本:2020.07.25.1
生成日期:2020/07/27 15:20:32
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研培设置
模块英文名:GraduateEduTools
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsgs_TeachingDateEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js";
import { clsvgs_TeachingDateEN } from "../TS/L0_Entity/GraduateEduTools/clsvgs_TeachingDateEN.js";
import { gs_TeachingDate_AddNewRecordAsync, gs_TeachingDate_Delgs_TeachingDatesAsync, gs_TeachingDate_DelRecordAsync, gs_TeachingDate_GetObjBymIdAsync, gs_TeachingDate_GetObjLstBymIdLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { vgs_TeachingDate_GetObjLstAsync, vgs_TeachingDate_GetObjLstByPagerAsync, vgs_TeachingDate_GetObjLstByPager_Cache, vgs_TeachingDate_GetRecCountByCondAsync, vgs_TeachingDate_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsvgs_TeachingDateWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_TeachingDate(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_TeachingDate(): void;
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
/* gs_TeachingDateCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class gs_TeachingDateCRUD implements clsOperateList{
    public static strid_CurrEduCls_Cache: string = "99999991";//缓存分类字段
    public mstrListDiv: string = "divDataLst";//列表区数据列表层id
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


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            ////建立缓存
            //
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvgs_TeachingDateBy = "startDate Asc";
           
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vgs_TeachingDate();
            $("#divLoading").hide();
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

            this.hidSortvgs_TeachingDateBy = "startDate Asc";
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vgs_TeachingDate_Cache();
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
        var strWhereCond = this.Combinevgs_TeachingDateCondition();
        try {
            const responseRecCount = await vgs_TeachingDate_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_TeachingDateBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_TeachingDate_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                var arrvgs_TeachingDateObjLst: Array<clsvgs_TeachingDateEN> = <Array<clsvgs_TeachingDateEN>>jsonData;
                this.BindTab_vgs_TeachingDate(this.mstrListDiv, arrvgs_TeachingDateObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `查询不成功,${e}.`;
            alert(strMsg);
        }
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
            const responseBindGv = await this.BindGv_vgs_TeachingDate();
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
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelRecord(lngKeyId);
            const responseBindGv = await this.BindGv_vgs_TeachingDate();
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
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord(lngmId: number) {
        try {
            const responseText = await gs_TeachingDate_DelRecordAsync(lngmId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_TeachingDate_ReFreshCache(gs_TeachingDateCRUD.strid_CurrEduCls_Cache);
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
    public async SelectRecord(lngmId: number) {
        try {
            const responseText = await gs_TeachingDate_GetObjBymIdAsync(lngmId);
            var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_vgs_TeachingDate");
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
            const responseBindGv = await this.BindGv_vgs_TeachingDate();
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
            const responseText = await vgs_TeachingDate_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrvgs_TeachingDateObjLst: Array<clsvgs_TeachingDateEN> = <Array<clsvgs_TeachingDateEN>>jsonData;
                this.BindTab_vgs_TeachingDate(this.mstrListDiv, arrvgs_TeachingDateObjLst);
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
    public Combinevgs_TeachingDateCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.StartDate_q != "") {
            //    strWhereCond += ` And ${clsvgs_TeachingDateEN.con_StartDate} like '% ${this.StartDate_q}%'`;
            //}
            //if (this.EndDate_q != "") {
            //    strWhereCond += ` And ${clsvgs_TeachingDateEN.con_EndDate} like '% ${this.EndDate_q}%'`;
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_TeachingDateCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public Combinevgs_TeachingDateConditionObj(): clsvgs_TeachingDateEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvgs_TeachingDate_Cond: clsvgs_TeachingDateEN = new clsvgs_TeachingDateEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.StartDate_q != "") {
            //    strWhereCond += ` And ${clsvgs_TeachingDateEN.con_StartDate} like '% ${this.StartDate_q}%'`;
            //    objvgs_TeachingDate_Cond.SetCondFldValue(clsvgs_TeachingDateEN.con_StartDate, this.StartDate_q, "like");
            //}
            //if (this.EndDate_q != "") {
            //    strWhereCond += ` And ${clsvgs_TeachingDateEN.con_EndDate} like '% ${this.EndDate_q}%'`;
            //    objvgs_TeachingDate_Cond.SetCondFldValue(clsvgs_TeachingDateEN.con_EndDate, this.EndDate_q, "like");
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0010)在组合查询条件对象(Combinegs_TeachingDateConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvgs_TeachingDate_Cond;
    }

    /* 显示vgs_TeachingDate对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrgs_TeachingDateObjLst">需要绑定的对象列表</param>
   */
    public BindTab_vgs_TeachingDate(divContainer: string, arrvgs_TeachingDateObjLst: Array<clsvgs_TeachingDateEN>) {
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
                    TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "currEduClsId",
                    ColHeader: "当前教学班Id",
                    Text: "",
                    TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    ColHeader: "教学班名称",
                    Text: "",
                    TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "startDate",
                    ColHeader: "开始日期",
                    Text: "",
                    TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "endDate",
                    ColHeader: "截止日期",
                    Text: "",
                    TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改",
                    TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除",
                    TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvgs_TeachingDateObjLst, arrDataColumn, "mId");
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
        this.BindGv_vgs_TeachingDate();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vgs_TeachingDate() {
        if (this.hidSortvgs_TeachingDateBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_TeachingDateBy)为空，请检查！(In BindGv_vgs_TeachingDate)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.Combinevgs_TeachingDateCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvgs_TeachingDateObjLst: Array<clsvgs_TeachingDateEN> = [];
        try {
            const responseRecCount = await vgs_TeachingDate_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_TeachingDateBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_TeachingDate_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_TeachingDateObjLst = <Array<clsvgs_TeachingDateEN>>jsonData;
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
        if (arrvgs_TeachingDateObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vgs_TeachingDate(strListDiv, arrvgs_TeachingDateObjLst);
            console.log("完成BindGv_vgs_TeachingDate!");
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
    public async BindGv_vgs_TeachingDate_Cache() {
        if (this.hidSortvgs_TeachingDateBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_TeachingDateBy)为空，请检查！(In BindGv_vgs_TeachingDate_Cache)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var objvgs_TeachingDate_Cond = this.Combinevgs_TeachingDateConditionObj();
        objvgs_TeachingDate_Cond.SetCondFldValue(clsvgs_TeachingDateEN.con_id_CurrEduCls, gs_TeachingDateCRUD.strid_CurrEduCls_Cache, "=");
        var strWhereCond = JSON.stringify(objvgs_TeachingDate_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvgs_TeachingDateObjLst: Array<clsvgs_TeachingDateEN> = [];
        try {
            this.RecCount = await vgs_TeachingDate_GetRecCountByCond_Cache(objvgs_TeachingDate_Cond, "");
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_TeachingDateBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrvgs_TeachingDateObjLst = await vgs_TeachingDate_GetObjLstByPager_Cache(objPagerPara, "");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
            return;
        }
        if (arrvgs_TeachingDateObjLst.length == 0) {
            var strKey: string = `${clsgs_TeachingDateEN._CurrTabName}_${gs_TeachingDateCRUD.strid_CurrEduCls_Cache}`;
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vgs_TeachingDate(strListDiv, arrvgs_TeachingDateObjLst);
            console.log("完成BindGv_vgs_TeachingDate!");
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
        if (this.hidSortvgs_TeachingDateBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvgs_TeachingDateBy.indexOf("Asc") >= 0) {
                this.hidSortvgs_TeachingDateBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvgs_TeachingDateBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvgs_TeachingDateBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vgs_TeachingDate();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_QueryLst)
   */
    public Queryvgs_TeachingDateLst(strListDiv: string) {
        var strWhereCond = this.Combinevgs_TeachingDateCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        return new Promise((resolve, reject) => {
            try {
                var objPagerPara: stuPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvgs_TeachingDateBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseText = vgs_TeachingDate_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                    var arrvgs_TeachingDateObjLst: Array<clsvgs_TeachingDateEN> = <Array<clsvgs_TeachingDateEN>>jsonData;
                    this.BindTab_vgs_TeachingDate(strListDiv, arrvgs_TeachingDateObjLst);
                    console.log("完成Queryvgs_TeachingDateLst!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `查询对象列表不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        });
    }

    /* 复制记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
   */
    public async CopyRecord(arrmId: Array<string>) {
        try {
            const responseText = await gs_TeachingDate_GetObjLstBymIdLstAsync(arrmId);
            console.log('responseText=');
            console.log(responseText);
            var intCount: number = 0;
            var arrgs_TeachingDateObjLst: Array<clsgs_TeachingDateEN> = <Array<clsgs_TeachingDateEN>>responseText;
            for (let objInFor of arrgs_TeachingDateObjLst) {
                const responseText2 = await gs_TeachingDate_AddNewRecordAsync(objInFor);
                console.log('responseText2=');
                console.log(responseText2);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
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
    public async DelMultiRecord(arrmId: Array<string>) {
        try {
            const responseText = await gs_TeachingDate_Delgs_TeachingDatesAsync(arrmId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_TeachingDate_ReFreshCache(gs_TeachingDateCRUD.strid_CurrEduCls_Cache);
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
     <param name = "objgs_TeachingDate">需要显示的对象</param>
   */
    public Showgs_TeachingDateObj(divContainer: string, objgs_TeachingDate: clsgs_TeachingDateEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_TeachingDate);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objgs_TeachingDate[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjgs_TeachingDateEN">表实体类对象</param>
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
    // /*
    // * 截止日期 (Used In CombineCondition())
    //*/
    //public  get EndDate_q():string {
    //return $("#txtEndDate_q").val();
    //}
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvgs_TeachingDateBy(value: string) {
        $("#hidSortvgs_TeachingDateBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_TeachingDateBy(): string {
        return $("#hidSortvgs_TeachingDateBy").val();
    }
    /*
    * 开始日期 (Used In CombineCondition())
   */
    //public  get StartDate_q():string {
    //return $("#txtStartDate_q").val();
    //}
}