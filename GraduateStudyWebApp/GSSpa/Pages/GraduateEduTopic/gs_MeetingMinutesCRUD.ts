
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_MeetingMinutesCRUD
表名:gs_MeetingMinutes(01120770)
生成代码版本:2020.11.22.1
生成日期:2020/11/25 22:05:45
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
import { clsgs_MeetingMinutesEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsvgs_MeetingMinutesEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesEN.js";
import { gs_MeetingMinutes_AddNewRecordAsync, gs_MeetingMinutes_Delgs_MeetingMinutessAsync, gs_MeetingMinutes_DelRecordAsync, gs_MeetingMinutes_GetMaxStrIdAsync, gs_MeetingMinutes_GetObjByMeetingIdAsync, gs_MeetingMinutes_GetObjLstByMeetingIdLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesWApi.js";
import { vgs_MeetingMinutes_GetObjLstAsync, vgs_MeetingMinutes_GetObjLstByPagerAsync, vgs_MeetingMinutes_GetObjLstByPager_Cache, vgs_MeetingMinutes_GetRecCountByCondAsync, vgs_MeetingMinutes_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_MeetingMinutesWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_MeetingMinutes(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_MeetingMinutes(): void;
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
/* gs_MeetingMinutesCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class gs_MeetingMinutesCRUD implements clsOperateList{
    public mstrListDiv: string = "divDataLst";//列表区数据列表层id
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public bolIsLoadDetailRegion: boolean = false;  //记录是否导入详细信息区的变量
    public divName4Edit: string = "divMeetingMinutesEdit";  //编辑区的Id
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

            this.hidSortvgs_MeetingMinutesBy = "isSubmit Asc";
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_vgs_MeetingMinutes();
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

            this.hidSortvgs_MeetingMinutesBy = "isSubmit Asc";
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_vgs_MeetingMinutes();
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
        const responseBindGv = await this.BindGv_vgs_MeetingMinutes();
    }

    /// <summary>
    /// 设置绑定下拉框，针对字段:[topicId]
    /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion)
    /// </summary>
    public async SetDdl_TopicId(strid_CurrEduCls: string) {
        var objResearchTopic_Cond: clsResearchTopicEN = new clsResearchTopicEN();//查询区域
        //定义条件字段
        //var strid_CurrEduCls = "";//定义条件字段
    }


    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
        var strid_CurrEduCls = "";  //定义条件字段
        const ddlTopicId_q = await this.SetDdl_TopicId(strid_CurrEduCls);//查询区域
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
            const responseBindGv = await this.BindGv_vgs_MeetingMinutes();
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
            const responseBindGv = await this.BindGv_vgs_MeetingMinutes();
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
    public async DelRecord(strMeetingId: string) {
        try {
            const responseText = await gs_MeetingMinutes_DelRecordAsync(strMeetingId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_MeetingMinutes_ReFreshCache();
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
    public async SelectRecord(strMeetingId: string) {
        try {
            const responseText = await gs_MeetingMinutes_GetObjByMeetingIdAsync(strMeetingId);
            var objgs_MeetingMinutesEN: clsgs_MeetingMinutesEN = <clsgs_MeetingMinutesEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_vgs_MeetingMinutes");
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
            const responseBindGv = await this.BindGv_vgs_MeetingMinutes();
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
            const responseText = await vgs_MeetingMinutes_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrvgs_MeetingMinutesObjLst: Array<clsvgs_MeetingMinutesEN> = <Array<clsvgs_MeetingMinutesEN>>jsonData;
                this.BindTab_vgs_MeetingMinutes(this.mstrListDiv, arrvgs_MeetingMinutesObjLst);
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
    public Combinevgs_MeetingMinutesCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.TopicId_q != "" && this.TopicId_q != "0") {
                strWhereCond += ` And ${clsvgs_MeetingMinutesEN.con_TopicId} = '${this.TopicId_q}'`;
            }
            if (this.Year_q != "") {
                strWhereCond += ` And ${clsvgs_MeetingMinutesEN.con_Year} like '% ${this.Year_q}%'`;
            }
            if (this.Month_q != "") {
                strWhereCond += ` And ${clsvgs_MeetingMinutesEN.con_Month} like '% ${this.Month_q}%'`;
            }
            if (this.MeetingDate_q != "") {
                strWhereCond += ` And ${clsvgs_MeetingMinutesEN.con_MeetingDate} like '% ${this.MeetingDate_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_MeetingMinutesCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public Combinevgs_MeetingMinutesConditionObj(): clsvgs_MeetingMinutesEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvgs_MeetingMinutes_Cond: clsvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.TopicId_q != "" && this.TopicId_q != "0") {
                strWhereCond += ` And ${clsvgs_MeetingMinutesEN.con_TopicId} = '${this.TopicId_q}'`;
                objvgs_MeetingMinutes_Cond.SetCondFldValue(clsvgs_MeetingMinutesEN.con_TopicId, this.TopicId_q, "=");
            }
            if (this.Year_q != "") {
                strWhereCond += ` And ${clsvgs_MeetingMinutesEN.con_Year} like '% ${this.Year_q}%'`;
                objvgs_MeetingMinutes_Cond.SetCondFldValue(clsvgs_MeetingMinutesEN.con_Year, this.Year_q, "like");
            }
            if (this.Month_q != "") {
                strWhereCond += ` And ${clsvgs_MeetingMinutesEN.con_Month} like '% ${this.Month_q}%'`;
                objvgs_MeetingMinutes_Cond.SetCondFldValue(clsvgs_MeetingMinutesEN.con_Month, this.Month_q, "like");
            }
            if (this.MeetingDate_q != "") {
                strWhereCond += ` And ${clsvgs_MeetingMinutesEN.con_MeetingDate} like '% ${this.MeetingDate_q}%'`;
                objvgs_MeetingMinutes_Cond.SetCondFldValue(clsvgs_MeetingMinutesEN.con_MeetingDate, this.MeetingDate_q, "like");
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0010)在组合查询条件对象(Combinegs_MeetingMinutesConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvgs_MeetingMinutes_Cond;
    }

    /* 显示vgs_MeetingMinutes对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrgs_MeetingMinutesObjLst">需要绑定的对象列表</param>
   */
    public BindTab_vgs_MeetingMinutes(divContainer: string, arrvgs_MeetingMinutesObjLst: Array<clsvgs_MeetingMinutesEN>) {
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
                    FldName: "meetingContent",
                    SortBy: "meetingContent",
                    ColHeader: "会议内容",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "isSubmit",
                    SortBy: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "topicName",
                    SortBy: "topicName",
                    ColHeader: "栏目主题",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "meetingDate",
                    SortBy: "meetingDate",
                    ColHeader: "会议日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
                {
                    FldName: "year",
                    SortBy: "year",
                    ColHeader: "年",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 8,
                    FuncName: () => { }
                },
                {
                    FldName: "month",
                    SortBy: "month",
                    ColHeader: "月",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 9,
                    FuncName: () => { }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvgs_MeetingMinutesObjLst, arrDataColumn, "meetingId");
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
        const responseBindGv = await this.BindGv_vgs_MeetingMinutes();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vgs_MeetingMinutes() {
        if (this.hidSortvgs_MeetingMinutesBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_MeetingMinutesBy)为空，请检查！(In BindGv_vgs_MeetingMinutes)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.Combinevgs_MeetingMinutesCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvgs_MeetingMinutesObjLst: Array<clsvgs_MeetingMinutesEN> = [];
        try {
            const responseRecCount = await vgs_MeetingMinutes_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_MeetingMinutesBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_MeetingMinutes_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_MeetingMinutesObjLst = <Array<clsvgs_MeetingMinutesEN>>jsonData;
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
        if (arrvgs_MeetingMinutesObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vgs_MeetingMinutes(strListDiv, arrvgs_MeetingMinutesObjLst);
            console.log("完成BindGv_vgs_MeetingMinutes!");
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
    public async BindGv_vgs_MeetingMinutes_Cache() {
        if (this.hidSortvgs_MeetingMinutesBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_MeetingMinutesBy)为空，请检查！(In BindGv_vgs_MeetingMinutes_Cache)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var objvgs_MeetingMinutes_Cond = this.Combinevgs_MeetingMinutesConditionObj();
        var strWhereCond = JSON.stringify(objvgs_MeetingMinutes_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvgs_MeetingMinutesObjLst: Array<clsvgs_MeetingMinutesEN> = [];
        try {
            this.RecCount = await vgs_MeetingMinutes_GetRecCountByCond_Cache(objvgs_MeetingMinutes_Cond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_MeetingMinutesBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrvgs_MeetingMinutesObjLst = await vgs_MeetingMinutes_GetObjLstByPager_Cache(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
            return;
        }
        if (arrvgs_MeetingMinutesObjLst.length == 0) {
            var strKey: string = `${clsgs_MeetingMinutesEN._CurrTabName}`;
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vgs_MeetingMinutes(strListDiv, arrvgs_MeetingMinutesObjLst);
            console.log("完成BindGv_vgs_MeetingMinutes!");
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
        if (this.hidSortvgs_MeetingMinutesBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvgs_MeetingMinutesBy.indexOf("Asc") >= 0) {
                this.hidSortvgs_MeetingMinutesBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvgs_MeetingMinutesBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvgs_MeetingMinutesBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vgs_MeetingMinutes();
    }

    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtMeetingId').prop['ReadOnly'] = bolReadonly;
    }

    /* 复制记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
   */
    public async CopyRecord(arrMeetingId: Array<string>) {
        try {
            const responseText = await gs_MeetingMinutes_GetObjLstByMeetingIdLstAsync(arrMeetingId);
            console.log('responseText=');
            console.log(responseText);
            var intCount: number = 0;
            var arrgs_MeetingMinutesObjLst: Array<clsgs_MeetingMinutesEN> = <Array<clsgs_MeetingMinutesEN>>responseText;
            for (let objInFor of arrgs_MeetingMinutesObjLst) {
                const strMaxStrId = await gs_MeetingMinutes_GetMaxStrIdAsync();
                console.log('strMaxStrId=' + strMaxStrId);
                objInFor.meetingId = strMaxStrId;
                const responseText2 = await gs_MeetingMinutes_AddNewRecordAsync(objInFor);
                console.log('responseText2=');
                console.log(responseText2);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    //gs_MeetingMinutes_ReFreshCache();
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
    public async DelMultiRecord(arrMeetingId: Array<string>) {
        try {
            const responseText = await gs_MeetingMinutes_Delgs_MeetingMinutessAsync(arrMeetingId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_MeetingMinutes_ReFreshCache();
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
     <param name = "objgs_MeetingMinutes">需要显示的对象</param>
   */
    public Showgs_MeetingMinutesObj(divContainer: string, objgs_MeetingMinutes: clsgs_MeetingMinutesEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_MeetingMinutes);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objgs_MeetingMinutes[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjgs_MeetingMinutesEN">表实体类对象</param>
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
    public set hidSortvgs_MeetingMinutesBy(value: string) {
        $("#hidSortvgs_MeetingMinutesBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_MeetingMinutesBy(): string {
        return $("#hidSortvgs_MeetingMinutesBy").val();
    }
    /*
    * 会议日期 (Used In CombineCondition())
   */
    public get MeetingDate_q(): string {
        return $("#txtMeetingDate_q").val();
    }
    /*
    * 月 (Used In CombineCondition())
   */
    public get Month_q(): string {
        return $("#txtMonth_q").val();
    }
    /*
    * 主题编号 (Used In CombineCondition())
   */
    public get TopicId_q(): string {
        return $("#ddlTopicId_q").val();
    }
    /*
    * 年 (Used In CombineCondition())
   */
    public get Year_q(): string {
        return $("#txtYear_q").val();
    }
}