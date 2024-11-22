(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/DailyRunning/clsCurrEduClsStuEN.js", "../TS/L0_Entity/DailyRunning/clsvCurrEduClsEN.js", "../TS/L0_Entity/DailyRunning/clsvCurrEduClsStuEN.js", "../TS/L0_Entity/UserManage/clsStudentInfoEN.js", "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js", "../TS/L3_ForWApi/UserManage/clsStudentInfoWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "./CurrEduClsStuCRUD.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsStuCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:CurrEduClsStuCRUDEx
    表名:CurrEduClsStu(01120125)
    生成代码版本:2020.05.09.1
    生成日期:2020/05/11 16:30:20
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:日常运行
    模块英文名:DailyRunning
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsCurrEduClsStuEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsCurrEduClsStuEN.js");
    const clsvCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsvCurrEduClsEN.js");
    const clsvCurrEduClsStuEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsvCurrEduClsStuEN.js");
    const clsStudentInfoEN_js_1 = require("../TS/L0_Entity/UserManage/clsStudentInfoEN.js");
    const clsCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsCurrEduClsStuWApi.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js");
    const clsvCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js");
    const clsStudentInfoWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsStudentInfoWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const CurrEduClsStuCRUD_js_1 = require("./CurrEduClsStuCRUD.js");
    /* CurrEduClsStuCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class CurrEduClsStuCRUDEx extends CurrEduClsStuCRUD_js_1.CurrEduClsStuCRUD {
        constructor() {
            super(...arguments);
            //论文列表
            this.mstrListDivCurrEduCls = "divCurrEduClsDataLst";
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvCurrEduClsStuBy: string = "id_EduClsStu";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //建立缓存
                //根据角色隐藏按钮 
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                if (strRoleId == "00620003") {
                    $("#btnAddNewRecord").show();
                }
                else {
                    $("#btnAddNewRecord").hide();
                }
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvCurrEduClsStuBy = "eduClsName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vCurrEduClsStu();
                $("#divLoading").hide();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
    */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                //判断session是否失效
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
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
                                //this.BindGv_vCurrEduClsStu();
                                //}
                                //});
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        HideDialog();
                                        this.BindGv_vCurrEduClsStu();
                                    }
                                });
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                strInfo += "(In CurrEduClsStuCRUD.btnOKUpd_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vCurrEduClsStu();
                                }
                            });
                            break;
                        default:
                            var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    alert("登录超时，请重新登录");
                    window.top.location.href = "../Web/Login";
                }
                $("#divLoading").hide();
                //去掉提交按钮不可用状态
                $('#btnOKUpd').attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new CurrEduClsStuCRUDEx();
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "QueryCurrEduCls": //查询记录
                    objPage.btnCurrEduClsQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                case "AddCurrEduCls": //加入教学班
                    objPage.selectCurrEduCls_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vCurrEduClsStu() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevCurrEduClsStuCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvCurrEduClsStuObjLst = [];
            try {
                const responseRecCount = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvCurrEduClsStuBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvCurrEduClsStuObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vCurrEduClsStu(strListDiv, arrvCurrEduClsStuObjLst);
                console.log("完成BindGv_vCurrEduClsStu!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vCurrEduCls对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrCurrEduClsObjLst">需要绑定的对象列表</param>
    */
        BindTab_vCurrEduCls(divContainer, arrvCurrEduClsObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "currEduClsId",
                    ColHeader: "教学班Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    ColHeader: "教学班",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "courseCode",
                //    ColHeader: "课程代码",
                //    Text: "", TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "courseName",
                //    ColHeader: "课程",
                //    Text: "", TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "collegeName",
                    ColHeader: "学院",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "schoolYear",
                    ColHeader: "学年",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "schoolTerm",
                    ColHeader: "学期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "modifyDate",
                //    ColHeader: "日期",
                //    Text: "", TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "modifyUserID",
                //    ColHeader: "编辑人",
                //    Text: "", TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnCurrEduClsInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvCurrEduClsObjLst, arrDataColumn, "id_CurrEduCls");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        IndexPageTwo(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vCurrEduCls();
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
    */
        CombinevCurrEduClsCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.currEduClsId != "") {
                    strWhereCond += ` And ${clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId} like '% ${this.currEduClsId}%'`;
                }
                if (this.eduClsName != "") {
                    strWhereCond += ` And ${clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName} like '% ${this.eduClsName}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vCurrEduCls() {
            var strListDiv = this.mstrListDivCurrEduCls; //教学班
            var strWhereCond = this.CombinevCurrEduClsCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvCurrEduClsObjLst = [];
            try {
                const responseRecCount = await (0, clsvCurrEduClsWApi_js_1.vCurrEduCls_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvCurrEduClsBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvCurrEduClsWApi_js_1.vCurrEduCls_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvCurrEduClsObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvCurrEduClsObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vCurrEduCls(strListDiv, arrvCurrEduClsObjLst);
                console.log("完成BindGv_vCurrEduCls!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //弹出列表数据；
        async selectCurrEduCls_Click() {
            ShowDialogOne();
            const responseObjList = await this.BindGv_vCurrEduCls();
        }
        //查询列表
        async btnCurrEduClsQuery_Click() {
            const responseObjList = await this.BindGv_vCurrEduCls();
        }
        //确定选择 并添加到关系表中
        async btnCurrEduClsInTab_Click(strkeyId) {
            const response = await this.AddNewRecordSaveCurrEduClsStu(strkeyId);
        }
        /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSaveCurrEduClsStu(strid_CurrEduCls) {
            this.DivName = "divAddNewRecordSave";
            //获取用户，通过用户Id 查询学生表数据得到学生流水号；
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var objCurrEduClsStuEN = new clsCurrEduClsStuEN_js_1.clsCurrEduClsStuEN();
            const responseText = await this.PutDataToCurrEduClsStu(objCurrEduClsStuEN, strid_CurrEduCls);
            try {
                //同一用户，同一主题 同一观点 只能添加一次；
                var strWhere = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "' And stuID = '" + strUserId + "'";
                //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
                const responseText = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经加入过该教学班了！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_AddNewRecordAsync)(objCurrEduClsStuEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //关闭列表
                    HideDialogOne();
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjCurrEduClsStuEN">数据传输的目的类对象</param>
    */
        async PutDataToCurrEduClsStu(pobjCurrEduClsStuEN, strid_CurrEduCls) {
            pobjCurrEduClsStuEN.id_CurrEduCls = strid_CurrEduCls; // 教学班
            //获取用户，通过用户Id 查询学生表数据得到学生流水号；
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var strid_StudentInfo = "";
            var strSchoolTeam = "";
            var strSchoolYear = "";
            var strWhereCond = `1=1 And ${clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuID} = '${strUserId}'`;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText = await (0, clsStudentInfoWApi_js_1.StudentInfo_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                var objStudentInfoEN = jsonData;
                if (objStudentInfoEN != null) {
                    strid_StudentInfo = objStudentInfoEN.id_StudentInfo;
                }
            });
            pobjCurrEduClsStuEN.id_Stu = strid_StudentInfo; // 学生
            //pobjCurrEduClsStuEN.schoolTerm = this.schoolTerm;// 学期
            //pobjCurrEduClsStuEN.schoolYear = this.schoolYear;// 学年
            pobjCurrEduClsStuEN.modifyDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 
            pobjCurrEduClsStuEN.modifyUserID = strUserId; //
            pobjCurrEduClsStuEN.memo = this.memo; // 备注
        }
        /*
    * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvCurrEduClsBy(value) {
            $("#hidSortvCurrEduClsBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvCurrEduClsBy() {
            return $("#hidSortvCurrEduClsBy").val();
        }
        /*
    * 当前教学班Id
    */
        get CurrEduClsId_q() {
            return $("#txtCurrEduClsId_q").val();
        }
        /*
    * 教学班名称
    */
        get eduClsName_q() {
            return $("#txteduClsName_q").val();
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
    */
        CombinevCurrEduClsStuCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.CurrEduClsId_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrEduClsId} like '% ${this.CurrEduClsId_q}%'`;
                }
                if (this.eduClsName_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
                }
                if (this.StuId_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID} like '% ${this.StuId_q}%'`;
                }
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    //教师
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += " and stuID in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "')";
                }
                else {
                    ////学生； 
                    strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID} = '${strUserId}'`;
                    ////学生00620003
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsStuCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 显示vCurrEduClsStu对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrCurrEduClsStuObjLst">需要绑定的对象列表</param>
    */
        BindTab_vCurrEduClsStu(divContainer, arrvCurrEduClsStuObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    ColHeader: "教学班",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "courseName",
                    ColHeader: "课程",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "stuID",
                    ColHeader: "学生Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "stuName",
                    ColHeader: "姓名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorName",
                    ColHeader: "专业",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "schoolTerm",
                //    ColHeader: "学期",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "schoolYear",
                //    ColHeader: "学年",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "修改",
                //    Text: "修改",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvCurrEduClsStuObjLst, arrDataColumn, "id_EduClsStu");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /*
    * 教学班名称
    */
        get eduClsName() {
            return $("#eduClsName_q").val();
        }
        /*
    * 当前教学班Id
    */
        get currEduClsId() {
            return $("#CurrEduClsId_q").val();
        }
        /*
    * 课程名称
    */
        get StuId_q() {
            return $("#txtStuID").val();
        }
    }
    exports.CurrEduClsStuCRUDEx = CurrEduClsStuCRUDEx;
});
