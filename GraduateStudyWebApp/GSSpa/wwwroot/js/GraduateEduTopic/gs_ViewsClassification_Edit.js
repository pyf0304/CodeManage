(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js", "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js", "../TS/PubFun/clsPager.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ViewsClassification_Edit = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_ViewsClassification_Edit
    表名:gs_ViewsClassification(01120777)
    生成代码版本:2020.12.17.1
    生成日期:2020/12/17 15:50:09
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:WA_编辑区后台_TS(WA_ViewScript_EditCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsgs_ViewsClassificationEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js");
    const clsResearchTopicEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js");
    const clsgs_ViewsClassificationWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* gs_ViewsClassification_Edit 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    */
    class gs_ViewsClassification_Edit {
        constructor(objShowList) {
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divViewsClassificationEdit"; //编辑区的Id
            this.objPager = new clsPager_js_1.clsPager();
            this.RecCount = 0;
            this.iShowList = objShowList;
            gs_ViewsClassification_Edit.objPage_Edit = this;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            var strUrl = "./gs_ViewsClassification_Edit/";
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
                    ShowDialog_gs_ViewsClassification('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog_gs_ViewsClassification('Add');
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
            var strid_CurrEduCls = ""; //定义条件字段
            const ddlTopicId = await this.SetDdl_TopicId(strid_CurrEduCls); //编辑区域
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
                    ShowDialog_gs_ViewsClassification('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                }
                else {
                    ShowDialog_gs_ViewsClassification('Add');
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
        /// 设置绑定下拉框，针对字段:[topicId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
        /// </summary>
        async SetDdl_TopicId(strid_CurrEduCls) {
            var objResearchTopic_Cond = new clsResearchTopicEN_js_1.clsResearchTopicEN(); //编辑区域
            //定义条件字段
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
                ShowDialog_gs_ViewsClassification('Update');
                this.bolIsLoadEditRegion = true; //
                this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog_gs_ViewsClassification('Update');
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
                ShowDialog_gs_ViewsClassification('Update');
                this.bolIsLoadEditRegion = true; //
                const update = await this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog_gs_ViewsClassification('Update');
                const update = await this.UpdateRecord(strKeyId);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_gs_ViewsClassification;
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
                                    HideDialog_gs_ViewsClassification();
                                    this.iShowList.BindGv(clsgs_ViewsClassificationEN_js_1.clsgs_ViewsClassificationEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog_gs_ViewsClassification();
                                    this.iShowList.BindGv(clsgs_ViewsClassificationEN_js_1.clsgs_ViewsClassificationEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In gs_ViewsClassification_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog_gs_ViewsClassification();
                                this.iShowList.BindGv(clsgs_ViewsClassificationEN_js_1.clsgs_ViewsClassificationEN._CurrTabName, "");
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtClassificationId').prop['ReadOnly'] = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.classificationId = "";
            this.classificationName = "";
            $('#ddlTopicId option[0]').attr("selected", true);
            this.updDate = "";
            this.updUser = "";
            this.memo = "";
            this.orderNum = 0;
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnSubmit_gs_ViewsClassification = "确认添加";
            this.btnCancel_gs_ViewsClassification = "取消添加";
            this.Clear();
            //wucgs_ViewsClassificationB1.classificationId = clsgs_ViewsClassificationBL.GetMaxStrId_S();
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.SetKeyReadOnly(false);
            this.btnSubmit_gs_ViewsClassification = "确认添加";
            this.btnCancel_gs_ViewsClassification = "取消添加";
            this.Clear();
            //wucgs_ViewsClassificationB1.classificationId = clsgs_ViewsClassificationBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjgs_ViewsClassificationEN">数据传输的目的类对象</param>
       */
        PutDataTogs_ViewsClassificationClass(pobjgs_ViewsClassificationEN) {
            pobjgs_ViewsClassificationEN.classificationId = this.classificationId; // 分类Id
            pobjgs_ViewsClassificationEN.classificationName = this.classificationName; // 分类名称
            pobjgs_ViewsClassificationEN.topicId = this.topicId; // 主题编号
            pobjgs_ViewsClassificationEN.updDate = this.updDate; // 修改日期
            pobjgs_ViewsClassificationEN.updUser = this.updUser; // 修改人
            pobjgs_ViewsClassificationEN.memo = this.memo; // 备注
            pobjgs_ViewsClassificationEN.orderNum = this.orderNum; // 序号
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objgs_ViewsClassificationEN = new clsgs_ViewsClassificationEN_js_1.clsgs_ViewsClassificationEN();
            this.PutDataTogs_ViewsClassificationClass(objgs_ViewsClassificationEN);
            try {
                (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_CheckPropertyNew)(objgs_ViewsClassificationEN);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `检查数据不成功,${e}.`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_IsExistAsync)(objgs_ViewsClassificationEN.classificationId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objgs_ViewsClassificationEN.classificationId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_AddNewRecordAsync)(objgs_ViewsClassificationEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //gs_ViewsClassification_ReFreshCache();
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
            var objgs_ViewsClassificationEN = new clsgs_ViewsClassificationEN_js_1.clsgs_ViewsClassificationEN();
            this.PutDataTogs_ViewsClassificationClass(objgs_ViewsClassificationEN);
            try {
                (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_CheckPropertyNew)(objgs_ViewsClassificationEN);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `检查数据不成功,${e}.`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseKeyId = await (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_AddNewRecordWithMaxIdAsync)(objgs_ViewsClassificationEN);
                var returnKeyId = responseKeyId;
                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                    //gs_ViewsClassification_ReFreshCache();
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
         <param name = "strClassificationId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strClassificationId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objgs_ViewsClassificationEN = new clsgs_ViewsClassificationEN_js_1.clsgs_ViewsClassificationEN();
            try {
                const responseText = await (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_IsExistAsync)(strClassificationId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strClassificationId}] 的记录不存在!`;
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
                const responseText = await (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_GetObjByClassificationIdAsync)(strClassificationId);
                objgs_ViewsClassificationEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromgs_ViewsClassificationClass(objgs_ViewsClassificationEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjgs_ViewsClassificationEN">表实体类对象</param>
       */
        GetDataFromgs_ViewsClassificationClass(pobjgs_ViewsClassificationEN) {
            this.classificationId = pobjgs_ViewsClassificationEN.classificationId; // 分类Id
            this.classificationName = pobjgs_ViewsClassificationEN.classificationName; // 分类名称
            this.topicId = pobjgs_ViewsClassificationEN.topicId; // 主题编号
            this.updDate = pobjgs_ViewsClassificationEN.updDate; // 修改日期
            this.updUser = pobjgs_ViewsClassificationEN.updUser; // 修改人
            this.memo = pobjgs_ViewsClassificationEN.memo; // 备注
            this.orderNum = pobjgs_ViewsClassificationEN.orderNum; // 序号
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strClassificationId) {
            this.btnSubmit_gs_ViewsClassification = "确认修改";
            this.btnCancel_gs_ViewsClassification = "取消修改";
            this.KeyId = strClassificationId;
            try {
                const responseText = await (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_GetObjByClassificationIdAsync)(strClassificationId);
                var objgs_ViewsClassificationEN = responseText;
                const conGetDataFromClass = await this.GetDataFromgs_ViewsClassificationClass(objgs_ViewsClassificationEN);
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
            var objgs_ViewsClassificationEN = new clsgs_ViewsClassificationEN_js_1.clsgs_ViewsClassificationEN();
            objgs_ViewsClassificationEN.classificationId = this.KeyId;
            this.PutDataTogs_ViewsClassificationClass(objgs_ViewsClassificationEN);
            objgs_ViewsClassificationEN.sf_UpdFldSetStr = objgs_ViewsClassificationEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_ViewsClassificationEN.classificationId == "" || objgs_ViewsClassificationEN.classificationId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_CheckProperty4Update)(objgs_ViewsClassificationEN);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `检查数据不成功,${e}.`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_UpdateRecordAsync)(objgs_ViewsClassificationEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //gs_ViewsClassification_ReFreshCache();
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
        set btnCancel_gs_ViewsClassification(value) {
            $("#btnCancel_gs_ViewsClassification").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnSubmit_gs_ViewsClassification() {
            return $("#btnSubmit_gs_ViewsClassification").html();
        }
        /*
        * 设置确定按钮的标题(Used In AddNewRecord())
       */
        set btnSubmit_gs_ViewsClassification(value) {
            $("#btnSubmit_gs_ViewsClassification").html(value);
        }
        /*
        * 分类Id (Used In Clear())
       */
        set classificationId(value) {
            $("#txtClassificationId").val(value);
        }
        /*
        * 分类Id (Used In PutDataToClass())
       */
        get classificationId() {
            return $("#txtClassificationId").val();
        }
        /*
        * 分类名称 (Used In Clear())
       */
        set classificationName(value) {
            $("#txtClassificationName").val(value);
        }
        /*
        * 分类名称 (Used In PutDataToClass())
       */
        get classificationName() {
            return $("#txtClassificationName").val();
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
        set hidSortgs_ViewsClassificationBy(value) {
            $("#hidSortgs_ViewsClassificationBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortgs_ViewsClassificationBy() {
            return $("#hidSortgs_ViewsClassificationBy").val();
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
        * 备注 (Used In Clear())
       */
        set memo(value) {
            $("#txtMemo").val(value);
        }
        /*
        * 备注 (Used In PutDataToClass())
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
        * 序号 (Used In Clear())
       */
        set orderNum(value) {
            $("#txtOrderNum").val(value);
        }
        /*
        * 序号 (Used In PutDataToClass())
       */
        get orderNum() {
            var strOrderNum = $("#txtOrderNum").val();
            if (clsString2_js_1.clsString.IsNullOrEmpty(strOrderNum))
                return 0;
            return Number(strOrderNum);
        }
        /*
        * 主题编号 (Used In Clear())
       */
        set topicId(value) {
            $("#ddlTopicId").val(value);
        }
        /*
        * 主题编号 (Used In PutDataToClass())
       */
        get topicId() {
            if ($("#ddlTopicId").val() == "0")
                return "";
            return $("#ddlTopicId").val();
        }
        /*
        * 修改日期 (Used In Clear())
       */
        set updDate(value) {
            $("#txtUpdDate").val(value);
        }
        /*
        * 修改日期 (Used In PutDataToClass())
       */
        get updDate() {
            return $("#txtUpdDate").val();
        }
        /*
        * 修改人 (Used In Clear())
       */
        set updUser(value) {
            $("#txtUpdUser").val(value);
        }
        /*
        * 修改人 (Used In PutDataToClass())
       */
        get updUser() {
            return $("#txtUpdUser").val();
        }
    }
    exports.gs_ViewsClassification_Edit = gs_ViewsClassification_Edit;
});
