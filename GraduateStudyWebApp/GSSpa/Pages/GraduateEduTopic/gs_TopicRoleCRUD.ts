
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TopicRoleCRUD
表名:gs_TopicRole(01120869)
生成代码版本:2021.01.08.1
生成日期:2021/01/08 01:07:39
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
import { clsgs_TopicRoleEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_TopicRoleEN.js";
import { gs_TopicRole_AddNewRecordAsync, gs_TopicRole_Delgs_TopicRolesAsync, gs_TopicRole_DelRecordAsync, gs_TopicRole_GetMaxStrIdAsync, gs_TopicRole_GetObjByTopicRoleIdAsync, gs_TopicRole_GetObjLstAsync, gs_TopicRole_GetObjLstByPagerAsync, gs_TopicRole_GetObjLstByPager_Cache, gs_TopicRole_GetObjLstByTopicRoleIdLstAsync, gs_TopicRole_GetRecCountByCondAsync, gs_TopicRole_GetRecCountByCond_Cache, gs_TopicRole_SortFun_Defa } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_TopicRole(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_TopicRole(): void;
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
/* gs_TopicRoleCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class gs_TopicRoleCRUD implements clsOperateList {
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
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortgs_TopicRoleBy = "topicRoleId Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_gs_TopicRole();
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

            this.hidSortgs_TopicRoleBy = "topicRoleId Asc";
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_gs_TopicRole();
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
        const responseBindGv = await this.BindGv_gs_TopicRole();
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
            const responseBindGv = await this.BindGv_gs_TopicRole();
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
            const responseBindGv = await this.BindGv_gs_TopicRole();
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
    public async DelRecord(strTopicRoleId: string) {
        try {
            const responseText = await gs_TopicRole_DelRecordAsync(strTopicRoleId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_TopicRole_ReFreshCache();
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
    public async SelectRecord(strTopicRoleId: string) {
        try {
            const responseText = await gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId);
            var objgs_TopicRoleEN: clsgs_TopicRoleEN = <clsgs_TopicRoleEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_gs_TopicRole");
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
            const responseBindGv = await this.BindGv_gs_TopicRole();
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
            const responseText = await gs_TopicRole_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrgs_TopicRoleObjLst: Array<clsgs_TopicRoleEN> = <Array<clsgs_TopicRoleEN>>jsonData;
                this.BindTab_gs_TopicRole(this.mstrListDiv, arrgs_TopicRoleObjLst);
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
    public Combinegs_TopicRoleCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_TopicRoleCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public Combinegs_TopicRoleConditionObj(): clsgs_TopicRoleEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objgs_TopicRole_Cond: clsgs_TopicRoleEN = new clsgs_TopicRoleEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0010)在组合查询条件对象(Combinegs_TopicRoleConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objgs_TopicRole_Cond;
    }

    /* 显示gs_TopicRole对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrgs_TopicRoleObjLst">需要绑定的对象列表</param>
   */
    public BindTab_gs_TopicRole(divContainer: string, arrgs_TopicRoleObjLst: Array<clsgs_TopicRoleEN>) {
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
                    FldName: "topicRoleId",
                    SortBy: "topicRoleId",
                    ColHeader: "主题权限Id",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "menuNum",
                    SortBy: "menuNum",
                    ColHeader: "菜单编号",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "menuName",
                    SortBy: "menuName",
                    ColHeader: "菜单名称",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "menuIsHide",
                    SortBy: "menuIsHide",
                    ColHeader: "菜单是否隐藏",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
            ];
        clsCommonFunc4Web.BindTabV3(o, arrgs_TopicRoleObjLst, arrDataColumn, "topicRoleId", this);
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
        const responseBindGv = await this.BindGv_gs_TopicRole();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_gs_TopicRole() {
        if (this.hidSortgs_TopicRoleBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortgs_TopicRoleBy)为空，请检查！(In BindGv_gs_TopicRole)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.Combinegs_TopicRoleCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrgs_TopicRoleObjLst: Array<clsgs_TopicRoleEN> = [];
        try {
            const responseRecCount = await gs_TopicRole_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var intPageCount = this.objPager.GetPageCount(this.RecCount, this.pageSize);
            if (intCurrPageIndex == 0) {
                if (intPageCount > 1) intCurrPageIndex = intPageCount;
                else intCurrPageIndex = 1;
                this.CurrPageIndex = intCurrPageIndex;
            }
            else if (intCurrPageIndex > intPageCount) {
                intCurrPageIndex = intPageCount;
                this.CurrPageIndex = intCurrPageIndex;
            }
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortgs_TopicRoleBy,//如果该字段为空，就使用下面的排序函数
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await gs_TopicRole_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrgs_TopicRoleObjLst = <Array<clsgs_TopicRoleEN>>jsonData;
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
        if (arrgs_TopicRoleObjLst.length == 0) {
            var lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
            lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
            var divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
            if (divDataLst != null) {
                divDataLst.innerText = "";
                divDataLst.appendChild(lblMsg);
            }
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_gs_TopicRole(strListDiv, arrgs_TopicRoleObjLst);
            console.log("完成BindGv_gs_TopicRole!");
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
    public async BindGv_gs_TopicRole_Cache() {
        if (this.hidSortgs_TopicRoleBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortgs_TopicRoleBy)为空，请检查！(In BindGv_gs_TopicRole_Cache)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var objgs_TopicRole_Cond = this.Combinegs_TopicRoleConditionObj();
        var strWhereCond = JSON.stringify(objgs_TopicRole_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrgs_TopicRoleObjLst: Array<clsgs_TopicRoleEN> = [];
        try {
            this.RecCount = await gs_TopicRole_GetRecCountByCond_Cache(objgs_TopicRole_Cond);
            var intPageCount = this.objPager.GetPageCount(this.RecCount, this.pageSize);
            if (intCurrPageIndex == 0) {
                if (intPageCount > 1) intCurrPageIndex = intPageCount;
                else intCurrPageIndex = 1;
                this.CurrPageIndex = intCurrPageIndex;
            }
            else if (intCurrPageIndex > intPageCount) {
                intCurrPageIndex = intPageCount;
                this.CurrPageIndex = intCurrPageIndex;
            }
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortgs_TopicRoleBy,//如果该字段为空，就使用下面的排序函数
                sortFun: gs_TopicRole_SortFun_Defa
            };
            var arrgs_TopicRoleObjLst = await gs_TopicRole_GetObjLstByPager_Cache(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
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
        if (arrgs_TopicRoleObjLst.length == 0) {
            var lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
            lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
            var divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
            if (divDataLst != null) {
                divDataLst.innerText = "";
                divDataLst.appendChild(lblMsg);
            }
            var strKey: string = `${clsgs_TopicRoleEN._CurrTabName}`;
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_gs_TopicRole(strListDiv, arrgs_TopicRoleObjLst);
            console.log("完成BindGv_gs_TopicRole!");
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
     <param name = "objAnchorElement">带有排序字段的Anchors</param>
   */
    public async SortBy(objAnchorElement) {
        console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
        //event = window.event || event;
        var thisEventObj: HTMLInputElement = objAnchorElement;
        var strFldName: string = thisEventObj.getAttribute("FldName") as string;
        var strSortByFld: string = strFldName;
        if (this.hidSortgs_TopicRoleBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortgs_TopicRoleBy.indexOf("Asc") >= 0) {
                this.hidSortgs_TopicRoleBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortgs_TopicRoleBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortgs_TopicRoleBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_gs_TopicRole();
    }

    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtTopicRoleId').prop['ReadOnly'] = bolReadonly;
    }

    /* 复制记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
   */
    public async CopyRecord(arrTopicRoleId: Array<string>) {
        try {
            const responseText = await gs_TopicRole_GetObjLstByTopicRoleIdLstAsync(arrTopicRoleId);
            console.log('responseText=');
            console.log(responseText);
            var intCount: number = 0;
            var arrgs_TopicRoleObjLst: Array<clsgs_TopicRoleEN> = <Array<clsgs_TopicRoleEN>>responseText;
            for (let objInFor of arrgs_TopicRoleObjLst) {
                const strMaxStrId = await gs_TopicRole_GetMaxStrIdAsync();
                console.log('strMaxStrId=' + strMaxStrId);
                objInFor.topicRoleId = strMaxStrId;
                const responseText2 = await gs_TopicRole_AddNewRecordAsync(objInFor);
                console.log('responseText2=');
                console.log(responseText2);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    //gs_TopicRole_ReFreshCache();
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
    public async DelMultiRecord(arrTopicRoleId: Array<string>) {
        try {
            const responseText = await gs_TopicRole_Delgs_TopicRolesAsync(arrTopicRoleId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_TopicRole_ReFreshCache();
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
     <param name = "objgs_TopicRole">需要显示的对象</param>
   */
    public Showgs_TopicRoleObj(divContainer: string, objgs_TopicRole: clsgs_TopicRoleEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_TopicRole);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objgs_TopicRole[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjgs_TopicRoleEN">表实体类对象</param>
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
    public set hidSortgs_TopicRoleBy(value: string) {
        $("#hidSortgs_TopicRoleBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortgs_TopicRoleBy(): string {
        return $("#hidSortgs_TopicRoleBy").val();
    }
}