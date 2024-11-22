(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/DailyRunning_Share/CurrEduClsStuCRUD.js", "../TS/FunClass_Share/clsPubVar4Web.js", "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js", "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./CurrEduClsStu_EditEx.js"], factory);
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
    const CurrEduClsStuCRUD_js_1 = require("../PagesBase/DailyRunning_Share/CurrEduClsStuCRUD.js");
    const clsPubVar4Web_js_1 = require("../TS/FunClass_Share/clsPubVar4Web.js");
    const clsvCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js");
    const clsvCurrEduClsStuEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js");
    const clsvCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const CurrEduClsStu_EditEx_js_1 = require("./CurrEduClsStu_EditEx.js");
    /* CurrEduClsStuCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class CurrEduClsStuCRUDEx extends CurrEduClsStuCRUD_js_1.CurrEduClsStuCRUD {
        constructor() {
            super(...arguments);
            //论文列表
            this.mstrListDivCurrEduCls = "divCurrEduClsDataLst";
        }
        //public static divName4List: string = "divDataLst";
        //public static mstrSortvCurrEduClsStuBy: string = "id_EduClsStu";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_vCurrEduClsStu();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vCurrEduClsTeacher":
                    alert('该类没有绑定该函数：[this.BindGv_vCurrEduClsStu]！');
                    //this.BindGv_vCurrEduClsStu();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                CurrEduClsStuCRUD_js_1.CurrEduClsStuCRUD.CourseId_Static = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
                //建立缓存
                //根据角色隐藏按钮 
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strRoleId == "00620003") {
                    $("#btnAddNewRecord").show();
                }
                else {
                    $("#btnAddNewRecord").hide();
                }
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                CurrEduClsStuCRUD_js_1.CurrEduClsStuCRUD.sortvCurrEduClsStuBy = "eduClsName Asc";
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
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (CurrEduClsStuCRUD_js_1.CurrEduClsStuCRUD.objPage_CRUD == null) {
                CurrEduClsStuCRUD_js_1.CurrEduClsStuCRUD.objPage_CRUD = new CurrEduClsStuCRUDEx();
                objPage = CurrEduClsStuCRUD_js_1.CurrEduClsStuCRUD.objPage_CRUD;
            }
            else {
                objPage = CurrEduClsStuCRUD_js_1.CurrEduClsStuCRUD.objPage_CRUD;
            }
            const objPage_Edit = new CurrEduClsStu_EditEx_js_1.CurrEduClsStu_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
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
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
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
                    strMsg = '命令:' + strCommandName + "在函数(UsersCRUD_CacheEx.btn_Click)中没有被处理！";
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
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevCurrEduClsStuCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvCurrEduClsStuObjLst = [];
            try {
                const responseRecCount = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.recCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: CurrEduClsStuCRUD_js_1.CurrEduClsStuCRUD.sortvCurrEduClsStuBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvCurrEduClsStuObjLst = jsonData;
                });
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vCurrEduClsStu(strListDiv, arrvCurrEduClsStuObjLst);
                console.log("完成BindGv_vCurrEduClsStu!");
            }
            catch (e) {
                console.log('catch(e)=');
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
        async BindTab_vCurrEduCls(divContainer, arrvCurrEduClsObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "currEduClsId",
                    colHeader: "教学班Id",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "eduClsName",
                    colHeader: "教学班",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "CourseCode",
                //    colHeader: "课程代码",
                //    text: "", tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "courseName",
                //    colHeader: "课程",
                //    text: "", tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "collegeName",
                    colHeader: "学院",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolYear",
                    colHeader: "学年",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolTerm",
                    colHeader: "学期",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "modifyDate",
                //    colHeader: "日期",
                //    text: "", tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "modifyUserID",
                //    colHeader: "编辑人",
                //    text: "", tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnCurrEduClsInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            await (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvCurrEduClsObjLst, arrDataColumn, "id_CurrEduCls", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        //public async IndexPageTwo(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.PageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //    this.BindGv_vCurrEduCls();
        //}
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
            var strWhereCond = await this.CombinevCurrEduClsCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvCurrEduClsObjLst = [];
            try {
                const responseRecCount = await (0, clsvCurrEduClsWApi_js_1.vCurrEduCls_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.recCount = jsonData;
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
                console.log('catch(e)=');
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
                console.log('catch(e)=');
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
        get currEduClsId_q() {
            return $("#txtCurrEduClsId_q").val();
        }
        /*
    * 教学班名称
    */
        get eduClsName_q() {
            return $("#txtEduClsName_q").val();
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
    */
        async CombinevCurrEduClsStuCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
                }
                //if (this.currEduClsId_q != "") {
                //    strWhereCond += ` And ${clsvCurrEduClsStuEN.con_CurrEduClsId} like '% ${this.currEduClsId_q}%'`;
                //}
                if (this.eduClsName_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
                }
                if (this.StuId_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID} like '% ${this.StuId_q}%'`;
                }
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    //教师
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += " and stuID in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "')";
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
        async BindTab_vCurrEduClsStu(divContainer, arrvCurrEduClsStuObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "eduClsName",
                    colHeader: "教学班",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "courseName",
                    colHeader: "课程",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "stuID",
                    colHeader: "学生Id",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "stuName",
                    colHeader: "姓名",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "schoolTerm",
                //    colHeader: "学期",
                //    text: "",tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "schoolYear",
                //    colHeader: "学年",
                //    text: "",tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            await (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvCurrEduClsStuObjLst, arrDataColumn, "id_EduClsStu", this);
            this.objPager.recCount = this.recCount;
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
            return $("#currEduClsId_q").val();
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
