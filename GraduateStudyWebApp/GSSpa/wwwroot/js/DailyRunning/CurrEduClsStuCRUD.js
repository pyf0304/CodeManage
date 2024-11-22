(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/DailyRunning/clsCurrEduClsStuEN.js", "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js", "../TS/L0_Entity/DailyRunning/clsvCurrEduClsStuEN.js", "../TS/L0_Entity/SysPara/clsSchoolTermEN.js", "../TS/L0_Entity/SysPara/clsSchoolYearEN.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js", "../TS/L3_ForWApi/SysPara/clsSchoolTermWApi.js", "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsStuCRUD = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:CurrEduClsStuCRUD
    表名:CurrEduClsStu(01120125)
    生成代码版本:2020.05.09.1
    生成日期:2020/05/12 09:53:19
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:日常运行
    模块英文名:DailyRunning
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsCurrEduClsStuEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsCurrEduClsStuEN.js");
    const clsCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js");
    const clsvCurrEduClsStuEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsvCurrEduClsStuEN.js");
    const clsSchoolTermEN_js_1 = require("../TS/L0_Entity/SysPara/clsSchoolTermEN.js");
    const clsSchoolYearEN_js_1 = require("../TS/L0_Entity/SysPara/clsSchoolYearEN.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsSchoolYearWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js");
    const clsSchoolTermWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsSchoolTermWApi.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsCurrEduClsStuWApi.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js");
    /* CurrEduClsStuCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class CurrEduClsStuCRUD extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //记录是否导入编辑区的变量
            this.RecCount = 0;
        }
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
                //建立缓存
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvCurrEduClsStuBy = "eduClsName Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vCurrEduClsStu();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            var strUrl = "./WA_CurrEduClsStu_Edit/";
            console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "html",
                    data: {},
                    success: function (data) {
                        console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                        $('#' + divName4Edit).html(data);
                        resolve(true);
                        //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                        //clsEditObj.BindTab();
                    },
                    error: (e) => {
                        console.error(e);
                        reject(e);
                    }
                });
            });
        }
        ;
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvCurrEduClsStuBy = "eduClsName Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vCurrEduClsStu_Cache();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click() {
            var strWhereCond = this.CombinevCurrEduClsStuCondition();
            try {
                const responseRecCount = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvCurrEduClsStuBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvCurrEduClsStuObjLst = jsonData;
                    this.BindTab_vCurrEduClsStu(this.mstrListDiv, arrvCurrEduClsStuObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    ShowDialog('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog('Add');
                    const responseText = await this.AddNewRecord();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var objCurrEduCls_Cond = new clsCurrEduClsEN_js_1.clsCurrEduClsEN(); //编辑区域
            var objSchoolTerm_Cond = new clsSchoolTermEN_js_1.clsSchoolTermEN(); //编辑区域
            var objSchoolYear_Cond = new clsSchoolYearEN_js_1.clsSchoolYearEN(); //编辑区域
            const ddlid_CurrEduCls = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache)(this.divName4List, "ddlid_CurrEduCls"); //编辑区域
            const ddlSchoolTerm = await (0, clsSchoolTermWApi_js_1.SchoolTerm_BindDdl_SchoolTermInDiv_Cache)(this.divName4List, "ddlSchoolTerm"); //编辑区域
            const ddlSchoolYear = await (0, clsSchoolYearWApi_js_1.SchoolYear_BindDdl_SchoolYearInDiv_Cache)(this.divName4List, "ddlSchoolYear"); //编辑区域
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
       */
        async btnAddNewRecordWithMaxId_Click() {
            this.OpType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    ShowDialog('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                }
                else {
                    ShowDialog('Add');
                    const responseText = this.AddNewRecordWithMaxId();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        async btnUpdateRecordInTab_Click(strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Update');
                this.bolIsLoadEditRegion = true; //
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
            else {
                ShowDialog('Update');
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
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
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(lngKeyId);
                const responseBindGv = await this.BindGv_vCurrEduClsStu();
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
        async btnSelectRecordInTab_Click(strKeyId) {
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
                var strMsg = `选择记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里详细信息记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
       */
        async btnDetailRecordInTab_Click(strKeyId) {
            this.OpType = "Detail";
            try {
                if (strKeyId == "") {
                    alert("请选择需要详细信息的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                this.DetailRecord(lngKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `详细信息记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(lngid_EduClsStu) {
            try {
                const responseText = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_DelRecordAsync)(lngid_EduClsStu);
                var returnInt = responseText;
                if (returnInt > 0) {
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
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
         <param name = "sender">参数列表</param>
       */
        async DetailRecord(lngid_EduClsStu) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            try {
                const responseText = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_GetObjByid_EduClsStuAsync)(lngid_EduClsStu);
                var objCurrEduClsStuEN = responseText;
                this.GetDataFromCurrEduClsStuClass(objCurrEduClsStuEN);
                console.log("完成DetailRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(lngid_EduClsStu) {
            try {
                const responseText = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_GetObjByid_EduClsStuAsync)(lngid_EduClsStu);
                var objCurrEduClsStuEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vCurrEduClsStu");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
       */
        async btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Update');
                this.bolIsLoadEditRegion = true; //
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
            else {
                ShowDialog('Update');
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
        }
        /* 删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
       */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vCurrEduClsStu();
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
                const responseText = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvCurrEduClsStuObjLst = jsonData;
                    this.BindTab_vCurrEduClsStu(this.mstrListDiv, arrvCurrEduClsStuObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `导出Excel不成功,${e}.`;
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
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
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
                //if ( this.CourseName_q != "")
                //{
                //strWhereCond += ` And ${ clsvCurrEduClsStuEN.con_CourseName} like '% ${ this.CourseName_q }%'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsStuCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevCurrEduClsStuConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvCurrEduClsStu_Cond = new clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.CurrEduClsId_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrEduClsId} like '% ${this.CurrEduClsId_q}%'`;
                    objvCurrEduClsStu_Cond.SetCondFldValue(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrEduClsId, this.CurrEduClsId_q, "like");
                }
                if (this.eduClsName_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
                    objvCurrEduClsStu_Cond.SetCondFldValue(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName, this.eduClsName_q, "like");
                }
                //if ( this.CourseName_q != "")
                //{
                //strWhereCond += ` And ${ clsvCurrEduClsStuEN.con_CourseName} like '% ${ this.CourseName_q }%'`;
                //objvCurrEduClsStu_Cond.SetCondFldValue(clsvCurrEduClsStuEN.con_CourseName, this.CourseName_q, "like");
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineCurrEduClsStuConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvCurrEduClsStu_Cond;
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
                    FldName: "courseCode",
                    ColHeader: "课程代码",
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
                    FldName: "CourseTypeName",
                    ColHeader: "课程类型",
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
                {
                    FldName: "schoolTerm",
                    ColHeader: "学期",
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
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvCurrEduClsStuObjLst, arrDataColumn, "id_EduClsStu");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vCurrEduClsStu();
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
            if (arrvCurrEduClsStuObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                alert(strMsg);
                return;
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
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_vCurrEduClsStu_Cache() {
            var strListDiv = this.mstrListDiv;
            var objvCurrEduClsStu_Cond = this.CombinevCurrEduClsStuConditionObj();
            var strWhereCond = JSON.stringify(objvCurrEduClsStu_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvCurrEduClsStuObjLst = [];
            try {
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                this.RecCount = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetRecCountByCond_Cache)(objvCurrEduClsStu_Cond, strid_CurrEduCls);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvCurrEduClsStuBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvCurrEduClsStuObjLst = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLstByPager_Cache)(objPagerPara, strid_CurrEduCls);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvCurrEduClsStuObjLst.length == 0) {
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=CurrEduClsStu)`;
                alert(strMsg);
                return;
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
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortvCurrEduClsStuBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvCurrEduClsStuBy.indexOf("Asc") >= 0) {
                    this.hidSortvCurrEduClsStuBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvCurrEduClsStuBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvCurrEduClsStuBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vCurrEduClsStu();
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
        }
        // /* 获取当前表关键字值的最大值,再加1,避免重复
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
        //*/
        // public async GetMaxStrId(strKeyCtrlName) {
        //     this.DivName = "divGetMaxStrId";
        //     try {
        //         const responseText = await CurrEduClsStu_GetMaxStrIdAsync();
        //         var returnString: string = responseText.toString();
        //         if (returnString == "") {
        //             var strInfo: string = `获取表CurrEduClsStu的最大关键字为空，不成功，请检查!`;
        //             $('#lblResult40').val(strInfo);
        //             //显示信息框
        //             alert(strInfo);
        //             $(strKeyCtrlName).val(returnString);
        //         }
        //         else {
        //             var strInfo: string = `获取表CurrEduClsStu的最大关键字为：${returnString}!`;
        //             $('#lblResult40').val(strInfo);
        //             //显示信息框
        //             alert(strInfo);
        //             $(strKeyCtrlName).val(returnString);
        //         }
        //     }
        //     catch (e) {
        //         console.error('catch(e)=');
        //         console.error(e);
        //         var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
        //         alert(strMsg);
        //     }
        // }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucCurrEduClsStuB1.id_EduClsStu = clsCurrEduClsStuBL.GetMaxStrId_S();
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucCurrEduClsStuB1.id_EduClsStu = clsCurrEduClsStuBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjCurrEduClsStuEN">数据传输的目的类对象</param>
       */
        PutDataToCurrEduClsStuClass(pobjCurrEduClsStuEN) {
            pobjCurrEduClsStuEN.id_CurrEduCls = this.id_CurrEduCls; // 教学班
            pobjCurrEduClsStuEN.id_Stu = this.id_Stu; // 学生
            pobjCurrEduClsStuEN.schoolTerm = this.schoolTerm; // 学期
            pobjCurrEduClsStuEN.schoolYear = this.schoolYear; // 学年
            pobjCurrEduClsStuEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objCurrEduClsStuEN = new clsCurrEduClsStuEN_js_1.clsCurrEduClsStuEN();
            this.PutDataToCurrEduClsStuClass(objCurrEduClsStuEN);
            try {
                const responseText2 = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_AddNewRecordAsync)(objCurrEduClsStuEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
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
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "lngid_EduClsStu">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(lngid_EduClsStu) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objCurrEduClsStuEN = new clsCurrEduClsStuEN_js_1.clsCurrEduClsStuEN();
            try {
                const responseText = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_IsExistAsync)(lngid_EduClsStu);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${lngid_EduClsStu}] 的记录不存在!`;
                    //$('#lblResult1').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                }
            }
            catch (e) {
                var strMsg = `检查相应关键字的记录存在不成功, ${e}.`;
                alert(strMsg);
            }
            try {
                const responseText = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_GetObjByid_EduClsStuAsync)(lngid_EduClsStu);
                objCurrEduClsStuEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromCurrEduClsStuClass(objCurrEduClsStuEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjCurrEduClsStuEN">表实体类对象</param>
       */
        GetDataFromCurrEduClsStuClass(pobjCurrEduClsStuEN) {
            this.id_CurrEduCls = pobjCurrEduClsStuEN.id_CurrEduCls; // 教学班
            this.id_Stu = pobjCurrEduClsStuEN.id_Stu; // 学生
            this.schoolTerm = pobjCurrEduClsStuEN.schoolTerm; // 学期
            this.schoolYear = pobjCurrEduClsStuEN.schoolYear; // 学年
            this.memo = pobjCurrEduClsStuEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(lngid_EduClsStu) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = lngid_EduClsStu.toString();
            try {
                const responseText = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_GetObjByid_EduClsStuAsync)(lngid_EduClsStu);
                var objCurrEduClsStuEN = responseText;
                this.GetDataFromCurrEduClsStuClass(objCurrEduClsStuEN);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objCurrEduClsStuEN = new clsCurrEduClsStuEN_js_1.clsCurrEduClsStuEN();
            objCurrEduClsStuEN.id_EduClsStu = Number(this.KeyId);
            this.PutDataToCurrEduClsStuClass(objCurrEduClsStuEN);
            objCurrEduClsStuEN.sf_UpdFldSetStr = objCurrEduClsStuEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objCurrEduClsStuEN.id_EduClsStu == 0 || objCurrEduClsStuEN.id_EduClsStu == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_UpdateRecordAsync)(objCurrEduClsStuEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrid_EduClsStu) {
            try {
                const responseText = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_DelCurrEduClsStusAsync)(arrid_EduClsStu);
                var returnInt = responseText;
                if (returnInt > 0) {
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
         <param name = "objCurrEduClsStu">需要显示的对象</param>
       */
        ShowCurrEduClsStuObj(divContainer, objCurrEduClsStu) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objCurrEduClsStu);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objCurrEduClsStu[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjCurrEduClsStuEN">表实体类对象</param>
        <returns>列表的第一个关键字值</returns>
       */
        GetFirstKey() {
            if (clsCommonFunc4Web2_js_1.arrSelectedKeys.length == 1) {
                return clsCommonFunc4Web2_js_1.arrSelectedKeys[0];
            }
            else {
                alert(`请选择一个关键字！目前选择了:${clsCommonFunc4Web2_js_1.arrSelectedKeys.length}个关键字。`);
                return "";
            }
        }
        /*
        演示Session 操作
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
        */
        async Demo_Session() {
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
                var strMsg = `演示Session不成功,${e}.`;
                alert(strMsg);
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
        获取Session 关键字的值
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
        <param name = "Key">关键字</param>
         <return>值</return>
        */
        GetSessionAsync(Key) {
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
        /*
        * 设置取消按钮的标题
       */
        set btnCancel(value) {
            $("#btnCancel").html(value);
        }
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd(value) {
            $("#btnOKUpd").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd() {
            return $("#btnOKUpd").html();
        }
        /*
        * 当前教学班Id
       */
        get CurrEduClsId_q() {
            return $("#txtCurrEduClsId_q").val();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 教学班名称
       */
        get eduClsName_q() {
            return $("#txteduClsName_q").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvCurrEduClsStuBy(value) {
            $("#hidSortvCurrEduClsStuBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvCurrEduClsStuBy() {
            return $("#hidSortvCurrEduClsStuBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 当前教学班流水号
       */
        set id_CurrEduCls(value) {
            $("#ddlid_CurrEduCls").val(value);
        }
        /*
        * 当前教学班流水号
       */
        get id_CurrEduCls() {
            return $("#ddlid_CurrEduCls").val();
        }
        /*
        * 学生流水号
       */
        set id_Stu(value) {
            $("#txtid_Stu").val(value);
        }
        /*
        * 学生流水号
       */
        get id_Stu() {
            return $("#txtid_Stu").val();
        }
        /*
        * 设置关键字的值
       */
        set KeyId(value) {
            $("#hidKeyId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get KeyId() {
            return $("#hidKeyId").val();
        }
        /*
        * 备注
       */
        set memo(value) {
            $("#txtMemo").val(value);
        }
        /*
        * 备注
       */
        get memo() {
            return $("#txtMemo").val();
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set OpType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        get OpType() {
            return $("#hidOpType").val();
        }
        /*
        * 学期
       */
        set schoolTerm(value) {
            $("#ddlSchoolTerm").val(value);
        }
        /*
        * 学期
       */
        get schoolTerm() {
            return $("#ddlSchoolTerm").val();
        }
        /*
        * 学年
       */
        set schoolYear(value) {
            $("#ddlSchoolYear").val(value);
        }
        /*
        * 学年
       */
        get schoolYear() {
            return $("#ddlSchoolYear").val();
        }
    }
    exports.CurrEduClsStuCRUD = CurrEduClsStuCRUD;
});