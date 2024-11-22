(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo/clsXzMajorEN.js", "../TS/L0_Entity/BaseInfo/clsvXzMajorEN.js", "../TS/L0_Entity/BaseInfo/clsXzClgEN.js", "../TS/L0_Entity/BaseInfo/clsXzMajorShoolTypeEN.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsString2.js", "../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js", "../TS/L3_ForWApi/BaseInfo/clsXzMajorShoolTypeWApi.js", "../TS/L3_ForWApi/BaseInfo/clsvXzMajorWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorCRUD = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:XzMajorCRUD
    表名:XzMajor(01120065)
    生成代码版本:2020.05.09.1
    生成日期:2020/05/11 16:30:25
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:基本信息维护
    模块英文名:BaseInfo
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzMajorEN.js");
    const clsvXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsvXzMajorEN.js");
    const clsXzClgEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzClgEN.js");
    const clsXzMajorShoolTypeEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzMajorShoolTypeEN.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js");
    const clsXzMajorShoolTypeWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzMajorShoolTypeWApi.js");
    const clsvXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsvXzMajorWApi.js");
    /* XzMajorCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
   */
    class XzMajorCRUD extends clsOperateList2_js_1.clsOperateList {
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
                this.hidSortvXzMajorBy = "MajorID Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vXzMajor();
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
            var strUrl = "./XzMajor_Edit/";
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
                this.hidSortvXzMajorBy = "MajorID Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vXzMajor_Cache();
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
            var strWhereCond = this.CombinevXzMajorCondition();
            try {
                const responseRecCount = await (0, clsvXzMajorWApi_js_1.vXzMajor_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvXzMajorBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvXzMajorWApi_js_1.vXzMajor_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvXzMajorObjLst = jsonData;
                    this.BindTab_vXzMajor(this.mstrListDiv, arrvXzMajorObjLst);
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
            var objXzMajorShoolType_Cond = new clsXzMajorShoolTypeEN_js_1.clsXzMajorShoolTypeEN(); //编辑区域
            // var objXzClg_Cond: clsXzClgEN = new clsXzClgEN();//编辑区域
            const ddlid_XzMajorShoolType = await (0, clsXzMajorShoolTypeWApi_js_1.XzMajorShoolType_BindDdl_id_XzMajorShoolTypeInDiv_Cache)(this.divName4List, "ddlid_XzMajorShoolType"); //编辑区域
            //const ddlid_XzCollege = await XzClg_BindDdl_id_XzCollege_Cache("ddlid_XzCollege", objXzClg_Cond);//编辑区域
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
            var objXzClg_Cond = new clsXzClgEN_js_1.clsXzClgEN(); //查询区域
            const ddlid_XzCollege_q = await (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4List, "ddlid_XzCollege_q"); //查询区域
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
                this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog('Update');
                this.UpdateRecord(strKeyId);
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
                const responseBindGv = await this.BindGv_vXzMajor();
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
                this.DetailRecord(strKeyId);
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
        async DelRecord(strid_XzMajor) {
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_DelRecordAsync)(strid_XzMajor);
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
        async DetailRecord(strid_XzMajor) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjByid_XzMajorAsync)(strid_XzMajor);
                var objXzMajorEN = responseText;
                this.GetDataFromXzMajorClass(objXzMajorEN);
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
        async SelectRecord(strid_XzMajor) {
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjByid_XzMajorAsync)(strid_XzMajor);
                var objXzMajorEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vXzMajor");
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
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId();
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
                this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog('Update');
                this.UpdateRecord(strKeyId);
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
                const responseBindGv = await this.BindGv_vXzMajor();
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
                const responseText = await (0, clsvXzMajorWApi_js_1.vXzMajor_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvXzMajorObjLst = jsonData;
                    this.BindTab_vXzMajor(this.mstrListDiv, arrvXzMajorObjLst);
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
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnBool2 = jsonData;
                                if (clsString2_js_1.clsString.IsNullOrEmpty(returnBool2) == false) {
                                    HideDialog();
                                    this.BindGv_vXzMajor();
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vXzMajor();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In XzMajorCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vXzMajor();
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
        CombinevXzMajorCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.MajorID_q != "") {
                    strWhereCond += ` And ${clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID} like '% ${this.MajorID_q}%'`;
                }
                if (this.majorName_q != "") {
                    strWhereCond += ` And ${clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName} like '% ${this.majorName_q}%'`;
                }
                if (this.id_XzCollege_q != "" && this.id_XzCollege_q != "0") {
                    strWhereCond += ` And ${clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege} = '${this.id_XzCollege_q}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineXzMajorCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevXzMajorConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvXzMajor_Cond = new clsvXzMajorEN_js_1.clsvXzMajorEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.MajorID_q != "") {
                    strWhereCond += ` And ${clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID} like '% ${this.MajorID_q}%'`;
                    objvXzMajor_Cond.SetCondFldValue(clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID, this.MajorID_q, "like");
                }
                if (this.majorName_q != "") {
                    strWhereCond += ` And ${clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName} like '% ${this.majorName_q}%'`;
                    objvXzMajor_Cond.SetCondFldValue(clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName, this.majorName_q, "like");
                }
                if (this.id_XzCollege_q != "" && this.id_XzCollege_q != "0") {
                    strWhereCond += ` And ${clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege} = '${this.id_XzCollege_q}'`;
                    objvXzMajor_Cond.SetCondFldValue(clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege, this.id_XzCollege_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineXzMajorConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvXzMajor_Cond;
        }
        /* 显示vXzMajor对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrXzMajorObjLst">需要绑定的对象列表</param>
       */
        BindTab_vXzMajor(divContainer, arrvXzMajorObjLst) {
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
                    FldName: "MajorID",
                    ColHeader: "专业ID",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorName",
                    ColHeader: "专业名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "MajorEnglishName",
                    ColHeader: "英文名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "collegeName",
                    ColHeader: "学院名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "MajorDirection",
                    ColHeader: "专业方向",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "modifyDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "modifyUserID",
                    ColHeader: "修改人",
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
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvXzMajorObjLst, arrDataColumn, "id_XzMajor");
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
            this.BindGv_vXzMajor();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vXzMajor() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevXzMajorCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvXzMajorObjLst = [];
            try {
                const responseRecCount = await (0, clsvXzMajorWApi_js_1.vXzMajor_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvXzMajorBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvXzMajorWApi_js_1.vXzMajor_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvXzMajorObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvXzMajorObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vXzMajor(strListDiv, arrvXzMajorObjLst);
                console.log("完成BindGv_vXzMajor!");
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
        async BindGv_vXzMajor_Cache() {
            var strListDiv = this.mstrListDiv;
            var objvXzMajor_Cond = this.CombinevXzMajorConditionObj();
            var strWhereCond = JSON.stringify(objvXzMajor_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvXzMajorObjLst = [];
            try {
                this.RecCount = await (0, clsvXzMajorWApi_js_1.vXzMajor_GetRecCountByCond_Cache)(objvXzMajor_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvXzMajorBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvXzMajorObjLst = await (0, clsvXzMajorWApi_js_1.vXzMajor_GetObjLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvXzMajorObjLst.length == 0) {
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=XzMajor)`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vXzMajor(strListDiv, arrvXzMajorObjLst);
                console.log("完成BindGv_vXzMajor!");
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
            if (this.hidSortvXzMajorBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvXzMajorBy.indexOf("Asc") >= 0) {
                    this.hidSortvXzMajorBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvXzMajorBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvXzMajorBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vXzMajor();
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
        }
        /* 获取当前表关键字值的最大值,再加1,避免重复
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
       */
        async GetMaxStrId(strKeyCtrlName) {
            this.DivName = "divGetMaxStrId";
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_GetMaxStrIdAsync)();
                var returnString = responseText.toString();
                if (returnString == "") {
                    var strInfo = `获取表XzMajor的最大关键字为空，不成功，请检查!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
                else {
                    var strInfo = `获取表XzMajor的最大关键字为：${returnString}!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            //this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucXzMajorB1.id_XzMajor = clsXzMajorBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表XzMajor的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtid_XzMajor').val(returnString);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            //this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucXzMajorB1.id_XzMajor = clsXzMajorBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjXzMajorEN">数据传输的目的类对象</param>
       */
        PutDataToXzMajorClass(pobjXzMajorEN) {
            pobjXzMajorEN.majorID = this.MajorID; // 专业ID
            pobjXzMajorEN.majorName = this.majorName; // 专业名称
            pobjXzMajorEN.isVisible = this.IsVisible; // 是否显示
            pobjXzMajorEN.majorEnglishName = this.MajorEnglishName; // 英文名
            pobjXzMajorEN.majorExplain = this.MajorExplain; // 专业说明
            pobjXzMajorEN.id_XzMajorShoolType = this.id_XzMajorShoolType; // 专业类型
            pobjXzMajorEN.id_XzCollege = this.id_XzCollege; // 学院
            pobjXzMajorEN.majorDirection = this.MajorDirection; // 专业方向
            pobjXzMajorEN.memo = this.memo; // 备注
            pobjXzMajorEN.modifyUserID = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId().toString(); // userId;// 修改人
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objXzMajorEN = new clsXzMajorEN_js_1.clsXzMajorEN();
            this.PutDataToXzMajorClass(objXzMajorEN);
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_IsExistAsync)(objXzMajorEN.id_XzMajor);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objXzMajorEN.id_XzMajor}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsXzMajorWApi_js_1.XzMajor_AddNewRecordAsync)(objXzMajorEN);
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
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objXzMajorEN = new clsXzMajorEN_js_1.clsXzMajorEN();
            this.PutDataToXzMajorClass(objXzMajorEN);
            try {
                const responseText2 = await (0, clsXzMajorWApi_js_1.XzMajor_AddNewRecordWithMaxIdAsync)(objXzMajorEN);
                var returnBool = responseText2;
                if (clsString2_js_1.clsString.IsNullOrEmpty(returnBool) == false) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
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
                return "";
            }
            return ""; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "strid_XzMajor">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strid_XzMajor) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objXzMajorEN = new clsXzMajorEN_js_1.clsXzMajorEN();
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_IsExistAsync)(strid_XzMajor);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strid_XzMajor}] 的记录不存在!`;
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
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjByid_XzMajorAsync)(strid_XzMajor);
                objXzMajorEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromXzMajorClass(objXzMajorEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjXzMajorEN">表实体类对象</param>
       */
        GetDataFromXzMajorClass(pobjXzMajorEN) {
            this.MajorID = pobjXzMajorEN.majorID; // 专业ID
            this.majorName = pobjXzMajorEN.majorName; // 专业名称
            this.IsVisible = pobjXzMajorEN.isVisible; // 是否显示
            this.MajorEnglishName = pobjXzMajorEN.majorEnglishName; // 英文名
            this.MajorExplain = pobjXzMajorEN.majorExplain; // 专业说明
            this.id_XzMajorShoolType = pobjXzMajorEN.id_XzMajorShoolType; // 专业类型
            this.id_XzCollege = pobjXzMajorEN.id_XzCollege; // 学院
            this.MajorDirection = pobjXzMajorEN.majorDirection; // 专业方向
            this.memo = pobjXzMajorEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strid_XzMajor) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strid_XzMajor;
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjByid_XzMajorAsync)(strid_XzMajor);
                var objXzMajorEN = responseText;
                this.GetDataFromXzMajorClass(objXzMajorEN);
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
            var objXzMajorEN = new clsXzMajorEN_js_1.clsXzMajorEN();
            objXzMajorEN.id_XzMajor = this.KeyId;
            this.PutDataToXzMajorClass(objXzMajorEN);
            objXzMajorEN.sf_UpdFldSetStr = objXzMajorEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objXzMajorEN.id_XzMajor == "" || objXzMajorEN.id_XzMajor == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_UpdateRecordAsync)(objXzMajorEN);
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
        async DelMultiRecord(arrid_XzMajor) {
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_DelXzMajorsAsync)(arrid_XzMajor);
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
         <param name = "objXzMajor">需要显示的对象</param>
       */
        ShowXzMajorObj(divContainer, objXzMajor) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objXzMajor);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objXzMajor[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjXzMajorEN">表实体类对象</param>
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
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvXzMajorBy(value) {
            $("#hidSortvXzMajorBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvXzMajorBy() {
            return $("#hidSortvXzMajorBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 学院流水号
       */
        set id_XzCollege(value) {
            $("#ddlid_XzCollege").val(value);
        }
        /*
        * 学院流水号
       */
        get id_XzCollege() {
            return $("#ddlid_XzCollege").val();
        }
        /*
        * 学院流水号
       */
        get id_XzCollege_q() {
            return $("#ddlid_XzCollege_q").val();
        }
        /*
        * 专业学校类型流水号
       */
        set id_XzMajorShoolType(value) {
            $("#ddlid_XzMajorShoolType").val(value);
        }
        /*
        * 专业学校类型流水号
       */
        get id_XzMajorShoolType() {
            return $("#ddlid_XzMajorShoolType").val();
        }
        /*
        * 是否显示
       */
        set IsVisible(value) {
            $("#chkIsVisible").val(value);
        }
        /*
        * 是否显示
       */
        get IsVisible() {
            return $("#chkIsVisible").prop("checked");
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
        * 专业方向
       */
        set MajorDirection(value) {
            $("#txtMajorDirection").val(value);
        }
        /*
        * 专业方向
       */
        get MajorDirection() {
            return $("#txtMajorDirection").val();
        }
        /*
        * 专业英文名称
       */
        set MajorEnglishName(value) {
            $("#txtMajorEnglishName").val(value);
        }
        /*
        * 专业英文名称
       */
        get MajorEnglishName() {
            return $("#txtMajorEnglishName").val();
        }
        /*
        * 专业说明
       */
        set MajorExplain(value) {
            $("#txtMajorExplain").val(value);
        }
        /*
        * 专业说明
       */
        get MajorExplain() {
            return $("#txtMajorExplain").val();
        }
        /*
        * 专业ID
       */
        set MajorID(value) {
            $("#txtMajorID").val(value);
        }
        /*
        * 专业ID
       */
        get MajorID() {
            return $("#txtMajorID").val();
        }
        /*
        * 专业ID
       */
        get MajorID_q() {
            return $("#txtMajorID_q").val();
        }
        /*
        * 专业名称
       */
        set majorName(value) {
            $("#txtmajorName").val(value);
        }
        /*
        * 专业名称
       */
        get majorName() {
            return $("#txtmajorName").val();
        }
        /*
        * 专业名称
       */
        get majorName_q() {
            return $("#txtmajorName_q").val();
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
        * 修改人
       */
        get modifyUserID() {
            return $("#txtModifyUserID").val();
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
    }
    exports.XzMajorCRUD = XzMajorCRUD;
});
