(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/CourseLearning/clscc_CourseEN.js", "../TS/L0_Entity/Knowledges/clsgs_KnowledgesGraphEN.js", "../TS/L3_ForWApi/CourseLearning/clscc_CourseTypeWApi.js", "../TS/L3_ForWApi/Knowledges/clsgs_KnowledgesGraphWApi.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_KnowledgesGraph_Edit = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_KnowledgesGraph_Edit
    表名:gs_KnowledgesGraph(01120873)
    生成代码版本:2021.01.27.2
    生成日期:2021/01/27 23:31:21
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:知识点相关
    模块英文名:Knowledges
    框架-层名:WA_编辑区后台_TS(WA_ViewScript_EditCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clscc_CourseEN_js_1 = require("../TS/L0_Entity/CourseLearning/clscc_CourseEN.js");
    const clsgs_KnowledgesGraphEN_js_1 = require("../TS/L0_Entity/Knowledges/clsgs_KnowledgesGraphEN.js");
    const clscc_CourseTypeWApi_js_1 = require("../TS/L3_ForWApi/CourseLearning/clscc_CourseTypeWApi.js");
    const clsgs_KnowledgesGraphWApi_js_1 = require("../TS/L3_ForWApi/Knowledges/clsgs_KnowledgesGraphWApi.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* gs_KnowledgesGraph_Edit 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    */
    class gs_KnowledgesGraph_Edit {
        constructor(objShowList) {
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            gs_KnowledgesGraph_Edit.objPage_Edit = this;
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            var strUrl = "./gs_KnowledgesGraph_Edit/";
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
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                this.SetEventFunc();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:设置事件函数
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
       */
        async SetEventFunc() {
            // 在此处放置用户代码以初始化页面
            try {
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    this.SetEventFunc();
                    ShowDialog_gs_KnowledgesGraph('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog_gs_KnowledgesGraph('Add');
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
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            const ddlCourseId = await this.SetDdl_CourseId(); //编辑区域
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
       */
        async btnAddNewRecordWithMaxId_Click() {
            this.OpType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    this.SetEventFunc();
                    ShowDialog_gs_KnowledgesGraph('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                }
                else {
                    ShowDialog_gs_KnowledgesGraph('Add');
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
        /// <summary>
        /// 设置绑定下拉框，针对字段:[courseId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
        /// </summary>
        async SetDdl_CourseId() {
            var objcc_Course_Cond = new clscc_CourseEN_js_1.clscc_CourseEN(); //编辑区域
            const ddlCourseId = await (0, clscc_CourseTypeWApi_js_1.cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache)(this.divName4Edit, "ddlCourseId"); //编辑区域
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
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
                this.SetEventFunc();
                ShowDialog_gs_KnowledgesGraph('Update');
                this.bolIsLoadEditRegion = true; //
                this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog_gs_KnowledgesGraph('Update');
                this.UpdateRecord(strKeyId);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
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
                this.SetEventFunc();
                ShowDialog_gs_KnowledgesGraph('Update');
                this.bolIsLoadEditRegion = true; //
                const update = await this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog_gs_KnowledgesGraph('Update');
                const update = await this.UpdateRecord(strKeyId);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_gs_KnowledgesGraph;
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
                                var returnKeyId = jsonData;
                                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                                    HideDialog_gs_KnowledgesGraph();
                                    this.iShowList.BindGv(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog_gs_KnowledgesGraph();
                                    this.iShowList.BindGv(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In gs_KnowledgesGraph_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog_gs_KnowledgesGraph();
                                this.iShowList.BindGv(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN._CurrTabName, "");
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.knowledgeGraphName = "";
            $('#ddlCourseId option[0]').attr("selected", true);
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.btnSubmit_gs_KnowledgesGraph = "确认添加";
            this.btnCancel_gs_KnowledgesGraph = "取消添加";
            this.Clear();
            //wucgs_KnowledgesGraphB1.knowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表gs_KnowledgesGraph的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtKnowledgeGraphId').val(returnString);
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
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.btnSubmit_gs_KnowledgesGraph = "确认添加";
            this.btnCancel_gs_KnowledgesGraph = "取消添加";
            this.Clear();
            //wucgs_KnowledgesGraphB1.knowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjgs_KnowledgesGraphEN">数据传输的目的类对象</param>
       */
        PutDataTogs_KnowledgesGraphClass(pobjgs_KnowledgesGraphEN) {
            pobjgs_KnowledgesGraphEN.knowledgeGraphName = this.knowledgeGraphName; // 知识点图名
            pobjgs_KnowledgesGraphEN.courseId = this.courseId; // 课程Id
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN();
            this.PutDataTogs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
            try {
                (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_CheckPropertyNew)(objgs_KnowledgesGraphEN);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `检查数据不成功,${e}.`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_IsExistAsync)(objgs_KnowledgesGraphEN.knowledgeGraphId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objgs_KnowledgesGraphEN.knowledgeGraphId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_AddNewRecordAsync)(objgs_KnowledgesGraphEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    console.error("由于该页面没有设置使用缓存列表，所以没有刷新缓存！请在生成代码平台中为该页面中设置使用缓存列表。"); //gs_KnowledgesGraph_ReFreshCache();
                    //gs_KnowledgesGraph_ReFreshCache();
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
                return false; //一定要有一个返回值，否则会出错！
            }
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN();
            this.PutDataTogs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
            try {
                (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_CheckPropertyNew)(objgs_KnowledgesGraphEN);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `检查数据不成功,${e}.`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseKeyId = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_AddNewRecordWithMaxIdAsync)(objgs_KnowledgesGraphEN);
                var returnKeyId = responseKeyId;
                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                    console.error("由于该页面没有设置使用缓存列表，所以没有刷新缓存！请在生成代码平台中为该页面中设置使用缓存列表。"); //gs_KnowledgesGraph_ReFreshCache();
                    //gs_KnowledgesGraph_ReFreshCache();
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
                return responseKeyId; //一定要有一个返回值，否则会出错！
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
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "strKnowledgeGraphId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strKnowledgeGraphId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN();
            try {
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_IsExistAsync)(strKnowledgeGraphId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strKnowledgeGraphId}] 的记录不存在!`;
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
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetObjByKnowledgeGraphIdAsync)(strKnowledgeGraphId);
                objgs_KnowledgesGraphEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromgs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjgs_KnowledgesGraphEN">表实体类对象</param>
       */
        GetDataFromgs_KnowledgesGraphClass(pobjgs_KnowledgesGraphEN) {
            this.knowledgeGraphName = pobjgs_KnowledgesGraphEN.knowledgeGraphName; // 知识点图名
            this.courseId = pobjgs_KnowledgesGraphEN.courseId; // 课程Id
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strKnowledgeGraphId) {
            this.btnSubmit_gs_KnowledgesGraph = "确认修改";
            this.btnCancel_gs_KnowledgesGraph = "取消修改";
            this.KeyId = strKnowledgeGraphId;
            try {
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetObjByKnowledgeGraphIdAsync)(strKnowledgeGraphId);
                var objgs_KnowledgesGraphEN = responseText;
                const conGetDataFromClass = await this.GetDataFromgs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN();
            objgs_KnowledgesGraphEN.knowledgeGraphId = this.KeyId;
            this.PutDataTogs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
            objgs_KnowledgesGraphEN.sf_UpdFldSetStr = objgs_KnowledgesGraphEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_KnowledgesGraphEN.knowledgeGraphId == "" || objgs_KnowledgesGraphEN.knowledgeGraphId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_CheckProperty4Update)(objgs_KnowledgesGraphEN);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `检查数据不成功,${e}.`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_UpdateRecordAsync)(objgs_KnowledgesGraphEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    console.error("由于该页面没有设置使用缓存列表，所以没有刷新缓存！请在生成代码平台中为该页面中设置使用缓存列表。"); //gs_KnowledgesGraph_ReFreshCache();
                    //gs_KnowledgesGraph_ReFreshCache();
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
        }
        /*
        * 设置取消按钮的标题(Used In AddNewRecord())
       */
        set btnCancel_gs_KnowledgesGraph(value) {
            $("#btnCancel_gs_KnowledgesGraph").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnSubmit_gs_KnowledgesGraph() {
            return $("#btnSubmit_gs_KnowledgesGraph").html();
        }
        /*
        * 设置确定按钮的标题(Used In AddNewRecord())
       */
        set btnSubmit_gs_KnowledgesGraph(value) {
            $("#btnSubmit_gs_KnowledgesGraph").html(value);
        }
        /*
        * 课程Id (Used In Clear())
       */
        set courseId(value) {
            $("#ddlCourseId").val(value);
        }
        /*
        * 课程Id (Used In PutDataToClass())
       */
        get courseId() {
            if ($("#ddlCourseId").val() == "0")
                return "";
            return $("#ddlCourseId").val();
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
        set hidSortgs_KnowledgesGraphBy(value) {
            $("#hidSortgs_KnowledgesGraphBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortgs_KnowledgesGraphBy() {
            return $("#hidSortgs_KnowledgesGraphBy").val();
        }
        /*
        * 设置关键字的值(Used In UpdateRecord())
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
        * 知识点图名 (Used In Clear())
       */
        set knowledgeGraphName(value) {
            $("#txtKnowledgeGraphName").val(value);
        }
        /*
        * 知识点图名 (Used In PutDataToClass())
       */
        get knowledgeGraphName() {
            return $("#txtKnowledgeGraphName").val();
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
    exports.gs_KnowledgesGraph_Edit = gs_KnowledgesGraph_Edit;
});
