(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js", "../GraduateEduTopic/SysSkillCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSkillVEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js", "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillVWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPager.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AddSysskillEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SysSkillCRUD
    表名:SysSkill(01120646)
    生成代码版本:2020.05.18.1
    生成日期:2020/05/22 18:59:58
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js");
    //import { clsSysSkillBL } from "../TS/L2_BLL/GraduateEdu/clsSysSkillBL.js";
    //import { clsvSysSkillBL } from "../TS/L2_BLL/GraduateEdu/clsvSysSkillBL.js";
    const SysSkillCRUD_js_1 = require("../GraduateEduTopic/SysSkillCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsvPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js");
    const clsRTSysSkillRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js");
    const clsSysSkillVEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSkillVEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsSysOperationTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js");
    const clsSysSecurityLevelEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsvPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js");
    const clsResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsRTSysSkillRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js");
    const clsSysSkillVWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillVWApi.js");
    const clsSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsSysOperationTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js");
    const clsSysSecurityLevelWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    /* SysSkillCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class AddSysskillEx extends SysSkillCRUD_js_1.SysSkillCRUD {
        constructor() {
            super(...arguments);
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //记录是否导入编辑区的变量
            this.objPager = new clsPager_js_1.clsPager();
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
                //通过主题Id获取教学班ID
                if ($("#hidId_CurrEduCls").val() == "") {
                    var objResearchTopic = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetFirstObjAsync)(" topicId=" + $("#hidTopicId").val());
                    $("#hidId_CurrEduCls").val(objResearchTopic.id_CurrEduCls);
                }
                //建立缓存
                var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
                var strSkillId = $("#hidSkillId").val();
                if (strSkillId != "") {
                    const conBindDdl = await this.BindDdl4EditRegion();
                    const UpdateRecord = await this.UpdateRecord(strSkillId);
                    $("#divLoading").hide();
                }
                else {
                    ////2、显示无条件的表内容在GridView中
                    //const gvResult = await this.BindGv_vSysSkill();
                    $("#divLoading").hide();
                    this.btnAddNewRecord_Click();
                    //获取分享Id
                    const responseText = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("09", clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                    var strShareId = responseText;
                    //var returnBool: boolean = !!responseText2;
                    if (strShareId != "") {
                        this.shareId = strShareId;
                    }
                }
                var strPaperId = $("#hidRequestPaperId").val();
                if (strPaperId != "") {
                    $('#SelectPaper').hide();
                    //存放Id
                    $("#txtCitationId").val(strPaperId);
                }
                else {
                    $('#SelectPaper').show();
                }
                //// 为查询区绑定下拉框
                //const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvSysSkillBy = "skillName Asc";
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
    */
        async btnAddNewRecord_Click() {
            this.OpType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    //const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    // ShowDialog('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    //ShowDialog('Add');
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
                // const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                // ShowDialog('Update');
                this.bolIsLoadEditRegion = true; //
                this.UpdateRecord(strKeyId);
            }
            else {
                // ShowDialog('Update');
                this.UpdateRecord(strKeyId);
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjSysSkillEN">表实体类对象</param>
    */
        GetDataFromSysSkillClass(pobjSysSkillEN) {
            this.skillId = pobjSysSkillEN.skillId; // 技能Id
            this.skillName = pobjSysSkillEN.skillName; // 技能名称
            this.operationTypeId = pobjSysSkillEN.operationTypeId; // 操作类型
            this.levelId = pobjSysSkillEN.levelId; // 级别Id
            this.process = pobjSysSkillEN.process; // 实施过程
            //this.updUser = pobjSysSkillEN.updUser;// 修改人
            //this.updDate = pobjSysSkillEN.updDate;// 修改日期
            this.isSubmit = pobjSysSkillEN.isSubmit; // 是否提交
            this.citationId = pobjSysSkillEN.citationId; // 引用Id
            this.shareId = pobjSysSkillEN.shareId;
            this.memo = pobjSysSkillEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strSkillId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strSkillId;
            try {
                const responseText = await (0, clsSysSkillWApi_js_1.SysSkill_GetObjBySkillIdAsync)(strSkillId);
                var objSysSkillEN = responseText;
                this.GetDataFromSysSkillClass(objSysSkillEN);
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
            var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
            objSysSkillEN.skillId = this.KeyId;
            $("#hidSkillId").val(this.KeyId);
            this.PutDataToSysSkillClass(objSysSkillEN);
            objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsSysSkillWApi_js_1.SysSkill_UpdateRecordAsync)(objSysSkillEN);
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
        }
        /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
    */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var objSysOperationType_Cond = new clsSysOperationTypeEN_js_1.clsSysOperationTypeEN(); //编辑区域
            const ddlOperationTypeId = await (0, clsSysOperationTypeWApi_js_1.SysOperationType_BindDdl_OperationTypeIdInDiv_Cache)(this.divName4List, "ddlOperationTypeId"); //编辑区域
            var objSysSecurityLevel_Cond = new clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN(); //编辑区域
            const ddlLevelId = await (0, clsSysSecurityLevelWApi_js_1.SysSecurityLevel_BindDdl_LevelIdInDiv_Cache)(this.divName4List, "ddlLevelId"); //编辑区域
            //论文
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
            //文献类型；
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Paper]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_LiteratureTypeId(ddlLiteratureTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrPaperObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                        console.log("完成BindDdl_LiteratureTypeId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
    */
        async AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucSysSkillB1.skillId = clsSysSkillBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsSysSkillWApi_js_1.SysSkill_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表SysSkill的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtSkillId').val(returnString);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            var strUrl = "./SysSkill_Edit/";
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
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            if (this.OpType == "AddWithMaxId") {
                                const responseText3 = await this.AddNewRecordWithMaxIdSaveRetrunId().then((jsonData) => {
                                    //var returnBool2 = responseText3;
                                    //if (returnBool2 == true) {
                                    //CloseWindow();
                                    //}
                                });
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        // HideDialog();
                                        this.BindGv_vSysSkill();
                                    }
                                });
                            }
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strSysskillId = $("#hidSkillId").val();
                            const responseText8 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSysskillId, "09", "1", this.Id_CurrEduCls);
                            var returnBool8 = !!responseText8;
                            if (returnBool8 == true) {
                                console.log("技能数据总表同步成功；");
                            }
                            else {
                                console.log("技能数据总表同步失败；");
                            }
                            //添加记录的同时添加历史版本
                            const responseText4 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    CloseWindow();
                                    //alert("添加历史版本出问题！");
                                }
                            });
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                //strInfo += "(In SysSkillCRUD.btnOKUpd_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                    // HideDialog();
                                    //this.BindGv_vSysSkill();
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strSysskillId = $("#hidSkillId").val();
                            const responseText9 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSysskillId, "09", "2", this.Id_CurrEduCls);
                            var returnBool9 = !!responseText9;
                            if (returnBool9 == true) {
                                console.log("技能数据总表同步成功；");
                            }
                            else {
                                console.log("技能数据总表同步失败；");
                            }
                            //添加记录的同时添加历史版本
                            const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    CloseWindow();
                                    //alert("添加历史版本出问题！");
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
        //添加历史版本
        async AddVersionRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objSysSkillVEN = new clsSysSkillVEN_js_1.clsSysSkillVEN();
            objSysSkillVEN.skillId = this.skillId;
            this.PutDataToSysSkillVClass(objSysSkillVEN);
            try {
                const responseText2 = await (0, clsSysSkillVWApi_js_1.SysSkillV_AddNewRecordAsync)(objSysSkillVEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and skillId=" + this.skillId;
                    var intVersionCount = await (0, clsSysSkillVWApi_js_1.SysSkillV_GetRecCountByCondAsync)(strWhereCond2);
                    var objViewpointEN = new clsSysSkillEN_js_1.clsSysSkillEN();
                    objViewpointEN.skillId = this.skillId;
                    objViewpointEN.versionCount = intVersionCount;
                    objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objViewpointEN.skillId == "" || objViewpointEN.skillId == undefined) {
                        throw "关键字不能为空!";
                    }
                    const responseText = (0, clsSysSkillWApi_js_1.SysSkill_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            return true;
                        }
                        else {
                            var strInfo = `添加历史版本数不成功!`;
                            alert(strInfo);
                            console.log("添加历史版本数不成功");
                            CloseWindow();
                            return false;
                        }
                    });
                    return true;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加版本记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjSysSkillEN">数据传输的目的类对象</param>
    */
        PutDataToSysSkillVClass(pobjSysSkillVEN) {
            pobjSysSkillVEN.skillId = this.skillId; // 技能Id
            pobjSysSkillVEN.skillName = this.skillName; // 技能名称
            pobjSysSkillVEN.operationTypeId = this.operationTypeId; // 操作类型
            pobjSysSkillVEN.levelId = this.levelId; // 级别Id
            pobjSysSkillVEN.process = this.process; // 实施过程
            pobjSysSkillVEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改人
            pobjSysSkillVEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjSysSkillVEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
            //pobjSysSkillVEN.isSubmit = this.isSubmit;// 是否提交
            pobjSysSkillVEN.citationId = this.citationId; // 引用Id
            pobjSysSkillVEN.memo = this.memo; // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjSysSkillEN">数据传输的目的类对象</param>
    */
        PutDataToSysSkillClass(pobjSysSkillEN) {
            pobjSysSkillEN.skillId = this.skillId; // 技能Id
            pobjSysSkillEN.skillName = this.skillName; // 技能名称
            pobjSysSkillEN.operationTypeId = this.operationTypeId; // 操作类型
            pobjSysSkillEN.levelId = this.levelId; // 级别Id
            pobjSysSkillEN.process = this.process; // 实施过程
            pobjSysSkillEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改人
            pobjSysSkillEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjSysSkillEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
            pobjSysSkillEN.shareId = this.shareId;
            pobjSysSkillEN.isSubmit = this.isSubmit; // 是否提交
            pobjSysSkillEN.citationId = this.citationId; // 引用Id
            pobjSysSkillEN.memo = this.memo; // 备注
            var strPdfPageNum = $("#hidPdfPageNum").val();
            if (strPdfPageNum != "") {
                pobjSysSkillEN.pdfPageNum = strPdfPageNum;
            }
            else {
                pobjSysSkillEN.pdfPageNum = 1;
            }
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
    */
        async AddNewRecordWithMaxIdSaveRetrunId() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
            objSysSkillEN.createDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd();
            this.PutDataToSysSkillClass(objSysSkillEN);
            try {
                //const responseText2 = await SysSkill_AddNewRecordWithMaxIdAsync(objSysSkillEN);
                const responseText = await (0, clsSysSkillWApi_js_1.SysSkill_AddNewRecordWithReturnKeyAsync)(objSysSkillEN);
                var strSysskillId = responseText;
                //var returnBool: boolean = !!responseText2;
                if (strSysskillId != "") {
                    $("#hidSkillId").val(strSysskillId);
                    const responseText2 = await this.AddNewRecordSaveRtSysskill();
                    return true;
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return strSysskillId; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            //return strSysskillId;//一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjRTSysSkillRelaEN">数据传输的目的类对象</param>
    */
        PutDataToRTSysSkillRelaClass(pobjRTSysSkillRelaEN) {
            var strTopicId = $('#hidTopicId').val();
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var strSkillId = $("#hidSkillId").val();
            pobjRTSysSkillRelaEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
            pobjRTSysSkillRelaEN.topicId = strTopicId; // 主题编号
            pobjRTSysSkillRelaEN.skillId = strSkillId; // 技能Id
            pobjRTSysSkillRelaEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjRTSysSkillRelaEN.updUser = strUserId;
            pobjRTSysSkillRelaEN.memo = this.memo; // 备注
            pobjRTSysSkillRelaEN.classificationId = "0000000000"; // 分类为000000
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSaveRtSysskill() {
            this.DivName = "divAddNewRecordSave";
            var strTopicId = $('#hidTopicId').val();
            var strSkillId = $("#hidSkillId").val();
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var objRTSysSkillRelaEN = new clsRTSysSkillRelaEN_js_1.clsRTSysSkillRelaEN();
            this.PutDataToRTSysSkillRelaClass(objRTSysSkillRelaEN);
            try {
                //同一用户，同一主题 同一技能 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And skillId = '" + strSkillId + "' And updUser = '" + strUserId + "'";
                const responseText = await (0, clsRTSysSkillRelaWApi_js_1.RTSysSkillRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题同一个用户不能重复添加同一个技能！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                else {
                    const responseText2 = await (0, clsRTSysSkillRelaWApi_js_1.RTSysSkillRela_AddNewRecordAsync)(objRTSysSkillRelaEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = `添加记录成功!`;
                        $('#lblResult46').val(strInfo);
                        //根据ID获取最大数；
                        var strWhereCond2 = " 1 =1 and skillId=" + strSkillId;
                        var intCitationCount = await (0, clsRTSysSkillRelaWApi_js_1.RTSysSkillRela_GetRecCountByCondAsync)(strWhereCond2);
                        var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
                        objSysSkillEN.skillId = strSkillId;
                        objSysSkillEN.citationCount = intCitationCount;
                        objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                            throw "关键字不能为空!";
                        }
                        const responseText = await (0, clsSysSkillWApi_js_1.SysSkill_UpdateRecordAsync)(objSysSkillEN).then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                            }
                            else {
                                var strInfo = `操作不成功!`;
                                alert(strInfo);
                                console.log("操作不成功");
                            }
                        });
                        //显示信息框
                        alert(strInfo);
                        //HideDialogNine();
                    }
                    else {
                        var strInfo = `添加记录不成功!`;
                        $('#lblResult46').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                }
                return responseText; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
        }
        /* 函数功能:在数据 列表中跳转到某一页 论文列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
    */
        IndexPageTwo(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vPaper();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvPaperBy(value) {
            $("#hidSortvPaperBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvPaperBy() {
            return $("#hidSortvPaperBy").val();
        }
        /*
       * 论文标题
      */
        get PaperTitle_q() {
            return $("#txtPaperTitle_q").val();
        }
        ///////////////////////论文列表条件
        get ReadUser_q() {
            return $("#ddlUserId_q").val();
        }
        /*
        * 文献类型Id
       */
        get LiteratureTypeId_q() {
            return $("#ddlLiteratureTypeId_q").val();
        }
        /*
        * 论文Id
       */
        set paperId(value) {
            $("#txtPaperId").val(value);
        }
        /*
        * 论文
       */
        get paperId() {
            return $("#txtPaperId").val();
        }
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            var strTopicId = $("#hidTopicId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.PaperTitle_q != "") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                }
                if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
                }
                //用户
                if (this.ReadUser_q != "" && this.ReadUser_q != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_UpdUser} = '${this.ReadUser_q}'`;
                }
                //只查询提交的论文数据
                strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_IsSubmit} = 'true'`;
                //排除获取已被当前观点引用过的论文数据；
                //strWhereCond += ` And paperId not in (select paperId from RTPaperRela where viewpointId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vPaper() {
            var strListDiv = this.mstrListDivPaper;
            var strWhereCond = this.CombinevPaperCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperObjLst = [];
            try {
                const responseRecCount = await (0, clsvPaperWApi_js_1.vPaper_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
                console.log("完成BindGv_vPaper!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vPaper对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrPaperObjLst">需要绑定的对象列表</param>
     */
        BindTab_vPaper(divContainer, arrvPaperObjLst) {
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
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "提交日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "提交用户",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
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
                        btn1.setAttribute("onclick", `btnPaperRecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2Where(o, arrvPaperObjLst, arrDataColumn, "paperId", "TopicPaper");
            //clsCommonFunc4Web.BindTabV2(o, arrvPaperObjLst, arrDataColumn, "paperId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //选择论文弹出列表数据；
        async selectPaper_Click() {
            const responseObjList = await this.BindGv_vPaper();
        }
        //查询论文列表
        async btnPaperQuery_Click() {
            const responseObjList = await this.BindGv_vPaper();
        }
        //确定选择的论文 并添加到关系表中
        btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            $("#txtCitationId").val(strkeyId);
            //设置只读属性；
            $("#txtCitationId").attr("disabled", "disabled");
            //关闭列表
            HideDialogThree();
        }
        /*
    论文
    */
        async SortByPaper(strSortByFld) {
            if (this.hidSortvPaperBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvPaperBy.indexOf("Asc") >= 0) {
                    this.hidSortvPaperBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvPaperBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvPaperBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_vPaper();
        }
        /*
    * 分享
    */
        set shareId(value) {
            $("#ddlShareId").val(value);
        }
        /*
        * 分享
        */
        get shareId() {
            return $("#ddlShareId").val();
        }
        /*
        * 教学班ID
       */
        set Id_CurrEduCls(value) {
            $("#hidId_CurrEduCls").val(value);
        }
        /*
        * 教学班
       */
        get Id_CurrEduCls() {
            return $("#hidId_CurrEduCls").val();
        }
    }
    exports.AddSysskillEx = AddSysskillEx;
    AddSysskillEx.strid_CurrEduCls_Cache = "00000001";
});
