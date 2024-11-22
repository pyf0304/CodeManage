(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsStuEN.js", "../TS/L0_Entity/UserManage_Share/clsStudentInfoEN.js", "../TS/L0_Entity/UserManage_Share/clsvStudentInfoEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsStuWApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../PagesBase/UserManage_Share/StudentInfoCRUD.js", "../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvStudentInfoWApi.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.StudentInfoList = void 0;
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsCurrEduClsStuEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsStuEN.js");
    const clsStudentInfoEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsStudentInfoEN.js");
    const clsvStudentInfoEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvStudentInfoEN.js");
    const clsCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsStuWApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    //import { clszx_TextExWApi } from "../TS/L3_ForWApiEx/ZXCourseware/clszx_TextExWApi.js";
    const StudentInfoCRUD_js_1 = require("../PagesBase/UserManage_Share/StudentInfoCRUD.js");
    const clsStudentInfoWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsvStudentInfoWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvStudentInfoWApi.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* StudentInfoCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class StudentInfoList extends StudentInfoCRUD_js_1.StudentInfoCRUD {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst"; //列表区数据列表层id
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsLoadDetailRegion = false; //记录是否导入详细信息区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.divName4Detail = "divDetail"; //详细信息区的Id
            this.recCount = 0;
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvStudentInfoBy: string = "id_StudentInfo";
        BindGv(strType, strPara) {
            this.BindGv_vStudentInfo();
        }
        BindGv_Cache(strType, strPara) {
            switch (strType) {
                case "vStudentInfo":
                    alert('该类没有绑定该函数：[this.BindGv_vStudentInfo_Cache]！');
                    //this.BindGv_vStudentInfo_Cache();
                    break;
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new StudentInfoList();
            //var objPage_Edit: Ex = new Ex(objPage);
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(StudentInfoCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        //public objPager: clsPager = new clsPager();
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //判断角色
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    $("#btnOkPushStuText").show();
                }
                else {
                }
                this.hidSortvStudentInfoBy = "stuID Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_vStudentInfo();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvStudentInfoBy = "stuID Asc";
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_vStudentInfo();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click() {
            const responseBindGv = await this.BindGv_vStudentInfo();
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
        }
        /*
         添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
        */
        async btnCopyRecord_Click() {
            try {
                var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要克隆的记录！");
                    return "";
                }
                const responseText = await this.CopyRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vStudentInfo();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `复制记录不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
       */
        async btnDelRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.BindGv_vStudentInfo();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里选择记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
       */
        async btnSelectRecordInTab_Click1(strKeyId) {
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
                var strMsg = `选择记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(strid_StudentInfo) {
            try {
                const responseText = await (0, clsStudentInfoWApi_js_1.StudentInfo_DelRecordAsync)(strid_StudentInfo);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //StudentInfo_ReFreshCache();
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strid_StudentInfo) {
            try {
                const responseText = await (0, clsStudentInfoWApi_js_1.StudentInfo_GetObjByid_StudentInfoAsync)(strid_StudentInfo);
                var objStudentInfoEN = responseText;
                console.log("完成SelectRecord!");
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_vStudentInfo");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
       */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vStudentInfo();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            var strWhereCond = " 1=1 ";
            try {
                const responseText = await (0, clsvStudentInfoWApi_js_1.vStudentInfo_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvStudentInfoObjLst = jsonData;
                    this.BindTab_vStudentInfo(this.mstrListDiv, arrvStudentInfoObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `导出Excel不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevStudentInfoCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strCurrEduClsId = $('#hidCurrEduClsId').val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.StuID_q != "") {
                    strWhereCond += ` And ${clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuID} like '% ${this.StuID_q}%'`;
                }
                if (this.StuName_q != "") {
                    strWhereCond += ` And ${clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuName} like '% ${this.StuName_q}%'`;
                }
                ////根据当前教学班来查询学生数据；
                //if (strCurrEduClsId != "") {
                //    strWhereCond += " And id_StudentInfo in (select id_Stu from CurrEduClsStu where id_CurrEduCls='" + strCurrEduClsId + "' )";
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(CombineStudentInfoCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevStudentInfoConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvStudentInfo_Cond = new clsvStudentInfoEN_js_1.clsvStudentInfoEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.StuID_q != "") {
                    strWhereCond += ` And ${clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuID} like '% ${this.StuID_q}%'`;
                    objvStudentInfo_Cond.SetCondFldValue(clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuID, this.StuID_q, "like");
                }
                if (this.StuName_q != "") {
                    strWhereCond += ` And ${clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuName} like '% ${this.StuName_q}%'`;
                    objvStudentInfo_Cond.SetCondFldValue(clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuName, this.StuName_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(CombineStudentInfoConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvStudentInfo_Cond;
        }
        /* 显示vStudentInfo对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrStudentInfoObjLst">需要绑定的对象列表</param>
       */
        async BindTab_vStudentInfo(divContainer, arrvStudentInfoObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    colHeader: "",
                    text: "",
                    tdClass: "text-left",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "stuID",
                    sortBy: "stuID", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    colHeader: "学号",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: () => { }
                },
                {
                    fldName: "stuName",
                    sortBy: "stuName", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    colHeader: "姓名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: () => { }
                },
                {
                    fldName: "SexDesc",
                    sortBy: "SexDesc", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    colHeader: "性别名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: () => { }
                },
                {
                    fldName: "collegeName",
                    sortBy: "collegeName", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    colHeader: "学院名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
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
                //    sortBy: "", sortFun: SortFun, getDataSource: "",
                //    colHeader: "修改",
                //    text: "修改",
                //    tdClass: "text-left",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    sortBy: "", sortFun: SortFun, getDataSource: "",
                //    colHeader: "删除",
                //    text: "删除",
                //    tdClass: "text-left",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvStudentInfoObjLst, arrDataColumn, "id_StudentInfo", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //确定选择 并添加到关系表中
        async btnCurrEduClsInTab_Click(strkeyId) {
            //获取页面传入参数，判断调用哪个数据源放
            var strPagetype = $('#hidPagetype').val();
            if (strPagetype == "01") {
                const response = await this.AddNewRecordSaveCurrEduClsStu(strkeyId);
            }
            else {
                ////这里调用中学课文界面方法；
                ////获取课文Id；
                //var strTextId = $('#hidTextId').val();
                //var strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                //var strUpdUser = clsPublocalStorage.userId;
                ////推送前查询该教学班是否已经有推送记录；
                //var strWhere = "pushTypeId = '02' And requesTypeId = '03' And tableKey= '" + strTextId + "' And receiveUser='" + strkeyId + "' And id_CurrEduCls = '" + strId_CurrEduCls + "'";
                //const responseTextOne = await sys_RequestPush_GetFirstObjAsync(strWhere);
                //var objsys_RequestPushEN: clssys_RequestPushEN = <clssys_RequestPushEN>responseTextOne;
                //if (objsys_RequestPushEN != null) {
                //    var strInfo: string = `当前数据已经有推送`;
                //    //显示信息框
                //    alert(strInfo);
                //    return;
                //}
                //else {
                //    const responseText = await zx_TextEx_RequestPushDataToSingerStuAsync(strkeyId, strTextId, strId_CurrEduCls, strUpdUser);
                //    var bolIsExist: boolean = responseText;
                //    if (bolIsExist == true) {
                //        var strMsg: string = `推送成功！`;
                //        alert(strMsg);
                //    }
                //    else {
                //        var strMsg: string = `推送失败！`;
                //        alert(strMsg);
                //    }
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
            }
        }
        ////多个学生推送方法、
        //public async btnOkPushStuText() {
        //    //获取课文Id；
        //    var strTextId = $('#hidTextId').val();
        //    var strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        //    var strUpdUser = clsPublocalStorage.userId;
        //    try {
        //        var arrKeyIds = GetCheckedKeyIds();
        //        if (arrKeyIds.length == 0) {
        //            alert("请选择需要推送的记录！");
        //            return "";
        //        }
        //        const responseText = await zx_TextEx_RequestPushDataToStuAsync(arrKeyIds, strTextId, strId_CurrEduCls, strUpdUser);
        //        var bolIs: boolean = responseText;
        //        if (bolIs == true) {
        //            var strMsg: string = `推送成功！`;
        //            alert(strMsg);
        //        }
        //        else {
        //            var strMsg: string = `推送失败！`;
        //            alert(strMsg);
        //        }
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `推送记录不成功,${e}.`;
        //        alert(strMsg);
        //        return false;
        //    }
        //}
        /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSaveCurrEduClsStu(strid_Teacher) {
            // this.DivName = "divAddNewRecordSave";
            var strCurrEduClsId = $('#hidCurrEduClsId').val();
            var strId_Teacher = strid_Teacher;
            var objCurrEduClsStuEN = new clsCurrEduClsStuEN_js_1.clsCurrEduClsStuEN();
            const responseText = await this.PutDataToCurrEduClsStu(objCurrEduClsStuEN, strid_Teacher);
            try {
                //同一用户，同一主题 同一观点 只能添加一次；
                var strWhere = " 1 = 1 And id_CurrEduCls = '" + strCurrEduClsId + "' And id_Stu = '" + strId_Teacher + "'";
                const responseText = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_IsExistRecordAsync)(strWhere);
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
                    CloseWindow();
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
        async PutDataToCurrEduClsStu(pobjCurrEduClsStuEN, strid_Stu) {
            var strCurrEduClsId = $('#hidCurrEduClsId').val();
            pobjCurrEduClsStuEN.Setid_CurrEduCls(strCurrEduClsId); // 教学班
            //获取用户，通过用户Id 查询学生表数据得到学生流水号；
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strid_TeacherInfo = "";
            var strSchoolTeam = "";
            var strSchoolYear = "";
            pobjCurrEduClsStuEN.Setid_Stu(strid_Stu); // 老
            //pobjCurrEduClsStuEN.schoolTerm = this.schoolTerm;// 学期
            //pobjCurrEduClsStuEN.schoolYear = this.schoolYear;// 学年
            pobjCurrEduClsStuEN.SetModifyDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd()); // 
            pobjCurrEduClsStuEN.SetModifyUserID(strUserId); //
            // pobjCurrEduClsStuEN.SetMemo(this.memo;// 备注
        }
        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.SetCurrPageIndex(intPageIndex);
            const responseBindGv = await this.BindGv_vStudentInfo();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vStudentInfo() {
            if (this.hidSortvStudentInfoBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortvStudentInfoBy)为空，请检查！(In BindGv_vStudentInfo)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var strWhereCond = await this.CombinevStudentInfoCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvStudentInfoObjLst = [];
            try {
                this.recCount = await (0, clsvStudentInfoWApi_js_1.vStudentInfo_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvStudentInfoBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvStudentInfoWApi_js_1.vStudentInfo_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvStudentInfoObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
            try {
                this.BindTab_vStudentInfo(strListDiv, arrvStudentInfoObjLst);
                console.log("完成BindGv_vStudentInfo!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                //console.trace();
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_vStudentInfo_Cache() {
            if (this.hidSortvStudentInfoBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortvStudentInfoBy)为空，请检查！(In BindGv_vStudentInfo_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objvStudentInfo_Cond = await this.CombinevStudentInfoConditionObj();
            var strWhereCond = JSON.stringify(objvStudentInfo_Cond);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvStudentInfoObjLst = [];
            try {
                this.recCount = await (0, clsvStudentInfoWApi_js_1.vStudentInfo_GetRecCountByCond_Cache)(objvStudentInfo_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvStudentInfoBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvStudentInfoObjLst = await (0, clsvStudentInfoWApi_js_1.vStudentInfo_GetObjLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
                return;
            }
            if (arrvStudentInfoObjLst.length == 0) {
                var strKey = `${clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vStudentInfo(strListDiv, arrvStudentInfoObjLst);
                console.log("完成BindGv_vStudentInfo!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortvStudentInfoBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvStudentInfoBy.indexOf("Asc") >= 0) {
                    this.hidSortvStudentInfoBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvStudentInfoBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvStudentInfoBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vStudentInfo();
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtid_StudentInfo').prop['ReadOnly'] = bolReadonly;
        }
        /* 复制记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
       */
        async CopyRecord(arrid_StudentInfo) {
            try {
                const responseText = await (0, clsStudentInfoWApi_js_1.StudentInfo_GetObjLstByid_StudentInfoLstAsync)(arrid_StudentInfo);
                console.log('responseText=');
                console.log(responseText);
                var intCount = 0;
                var arrStudentInfoObjLst = responseText;
                for (let objInFor of arrStudentInfoObjLst) {
                    const responseText2 = await (0, clsStudentInfoWApi_js_1.StudentInfo_AddNewRecordAsync)(objInFor);
                    console.log('responseText2=');
                    console.log(responseText2);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = `克隆记录成功!`;
                        intCount++;
                    }
                    else {
                        var strInfo = `克隆记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                }
                var strInfo = `共克隆了${intCount}条记录!`;
                alert(strInfo);
                console.log('完成！');
            }
            catch (e) {
                var strMsg = `复制记录不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrid_StudentInfo) {
            try {
                const responseText = await (0, clsStudentInfoWApi_js_1.StudentInfo_DelStudentInfosAsync)(arrid_StudentInfo);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //StudentInfo_ReFreshCache();
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelMultiRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objStudentInfo">需要显示的对象</param>
       */
        ShowStudentInfoObj(divContainer, objStudentInfo) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objStudentInfo);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objStudentInfo[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjStudentInfoEN">表实体类对象</param>
        <returns>列表的第一个关键字值</returns>
       */
        GetFirstKey() {
            if (clsCommFunc4Web_js_1.arrSelectedKeys.length == 1) {
                return clsCommFunc4Web_js_1.arrSelectedKeys[0];
            }
            else {
                alert(`请选择一个关键字！目前选择了:${clsCommFunc4Web_js_1.arrSelectedKeys.length}个关键字。`);
                return "";
            }
        }
        /*
        设置Session
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
        <param name = "Key">关键字</param>
        <param name = "Value">值</param>
        */
        SetSessionAsync(Key, Value) {
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
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号(Used In BindGv_)
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvStudentInfoBy(value) {
            $("#hidSortvStudentInfoBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvStudentInfoBy() {
            return $("#hidSortvStudentInfoBy").val();
        }
        /*
        * 学号 (Used In CombineCondition())
       */
        get StuID_q() {
            return $("#txtStuID_q").val();
        }
        /*
        * 姓名 (Used In CombineCondition())
       */
        get StuName_q() {
            return $("#txtStuName_q").val();
        }
    }
    exports.StudentInfoList = StudentInfoList;
});
