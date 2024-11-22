(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPaper/PaperSubViewpoint_QUDI_TS.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js", "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js", "../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js", "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js", "../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsPaperSubViewpointExWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsStackTrace.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperSubViewpoint_QUDI = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:PaperSubViewpoint_QUDI_TSEx
    表名:PaperSubViewpoint(01120534)
    生成代码版本:2019.12.06.1
    生成日期:2019/12/27 21:14:11
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const PaperSubViewpoint_QUDI_TS_js_1 = require("../GraduateEduPaper/PaperSubViewpoint_QUDI_TS.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperDownloadLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js");
    const clsPaperSubAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js");
    const clsPaperSubViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js");
    const clsSectionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js");
    const clsvPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js");
    const clsvPaperSubViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js");
    const clsExplainTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js");
    const clsSubViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperDownloadLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js");
    const clsPaperSubAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js");
    const clsPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsSectionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsvPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js");
    const clsExplainTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js");
    const clsSubViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js");
    const clsPaperSubViewpointExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsPaperSubViewpointExWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PaperSubViewpoint_QUDI extends PaperSubViewpoint_QUDI_TS_js_1.PaperSubViewpoint_QUDI_TS {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 50;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                if (strUserId != "") {
                    //1、为下拉框设置数据源,绑定列表数据
                    var strWhereCond1 = this.CombinevPaperSubViewpointCondition1();
                    var objvPaperReadWrite = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN;
                    const responseObjLst = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetFirstObjAsync)(strWhereCond1).then((jsonData) => {
                        objvPaperReadWrite = jsonData;
                    });
                    const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId", objvPaperReadWrite.paperId);
                    const ddl_SectionId_q = await this.BindDdl_SectionId("ddlSectionId_q", objvPaperReadWrite.paperId);
                    const ddl_SubViewpointTypeId_q = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId_q");
                    //const ddl_ExplainTypeId_q = await this.BindDdl_ExplainTypeId("ddlExplainTypeId_q");
                    const ddl_SubViewpointTypeId = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId");
                    const ddl_ExplainTypeId = await this.BindDdl_ExplainTypeId("ddlExplainTypeId");
                    //this.hidSortvPaperSubViewpointBy = "subViewpointTypeName Asc";
                    //var strWhereCond = this.CombinevPaperSubViewpointCondition();
                    //const responseText = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //    this.RecCount = jsonData;
                    //});
                    //2、显示无条件的表内容在GridView中
                    const gvResult0 = await this.GetReadWriteData(objvPaperReadWrite);
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    const gvResult = await this.BindGv_vPaperSubViewpoint();
                    //tbody();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //
        /// <summary>
        /// 为下拉框获取数据,从表:[SubViewpointType]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_SubViewpointTypeId(ddlSubViewpointTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlSubViewpointTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlSubViewpointTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    //const responseText = SubViewpointType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    const responseText = (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetObjLst_Cache)().then((jsonData) => {
                        var arrSubViewpointTypeObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlSubViewpointTypeId, arrSubViewpointTypeObjLst, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName, "子观点类型");
                        console.log("完成BindDdl_SubViewpointTypeId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[ExplainType]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_ExplainTypeId(ddlExplainTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlExplainTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlExplainTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    //const responseText = ExplainType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    const responseText = (0, clsExplainTypeWApi_js_1.ExplainType_GetObjLst_Cache)().then((jsonData) => {
                        var arrExplainTypeObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlExplainTypeId, arrExplainTypeObjLst, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName, "说明类型");
                        console.log("完成BindDdl_ExplainTypeId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        DetailRecord() {
            //this.KeyId = strPaperRWId;
            var strWhereCond = this.CombinevPaperSubViewpointCondition1();
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                        var objvPaperReadWriteEN = jsonData;
                        this.GetReadWriteData(objvPaperReadWriteEN);
                        console.log("完成Detail!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        GetReadWriteData(pobjvPaperReadWriteEN) {
            $("#hidPaperId").val(pobjvPaperReadWriteEN.paperId); //论文ID
            $("#txtPaperTitle").html(pobjvPaperReadWriteEN.paperTitle); //论文标题
            $("#txtKeyword").html(pobjvPaperReadWriteEN.keyword); //关键字Id
            $("#txtPeriodical").html(pobjvPaperReadWriteEN.periodical); //
            $("#txtAuthor").html(pobjvPaperReadWriteEN.author); //作者
            $("#txtResearchQuestion").html(pobjvPaperReadWriteEN.researchQuestion); //研究问题
            $("#txtPaperContent").html(pobjvPaperReadWriteEN.paperContent); //论文内容
            $("#hidIsSubmit").val(pobjvPaperReadWriteEN.isSubmit); //是否提交
            console.log($("#hidIsSubmit").val());
            //$("#txtMemo").html(pobjvPaperReadWriteEN.memo);//备注
            this.DetailRecordDownload(pobjvPaperReadWriteEN.paperId);
        }
        DetailRecordDownload(strPaperId) {
            //this.KeyId = strPaperRWId;
            var strWhereCond = " paperId ='" + strPaperId + "'";
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsvPaperWApi_js_1.vPaper_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                        var objvPaperEN = jsonData;
                        if (objvPaperEN.attachmentCount > 0) {
                            $("#btnDownLoadFile").show();
                            $("#lblDownLoadFile").hide();
                        }
                        else {
                            $("#btnDownLoadFile").hide();
                            $("#lblDownLoadFile").show();
                        }
                        console.log("完成Detail!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
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
                        const responseText2 = await this.AddNewRecordSaves().then((jsonData) => {
                            //var returnBool: boolean = jsonData;
                            //if (returnBool == true) {
                            HideDialog();
                            this.btnReOrder_Click();
                            this.BindGv_vPaperSubViewpoint();
                            // }
                            //var returnBool: boolean = jsonData;
                            //if (returnBool == true) {
                            //    HideDialog();
                            //    this.BindGv_vPaperSubViewpoint();
                            //}
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vPaperSubViewpoint();
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
                $("#btnOKUpd").attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
     */
        async AddNewRecordSaves() {
            this.DivName = "divAddNewRecordSave";
            var objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            try {
                //const responseText2 = await PaperSubViewpoint_AddNewRecordAsync(objPaperSubViewpointEN);
                const responseText2 = await (0, clsPaperSubViewpointExWApi_js_1.PaperSubViewpointEx_AddNewRecordWithReturnKeyAsyncEx)(objPaperSubViewpointEN);
                var returnString = responseText2.toString();
                if (returnString != "") {
                    //存放主键；
                    $("#hidKeyId").val(returnString);
                    //判断是否有返回的附件路径值
                    if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        var fileOne = $("#hdnFileOne").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                    }
                    else {
                        if ($("#hdnFileTwo").val() != "") {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            if ($("#hdnFileThree").val() != "") {
                                var fileThree = $("#hdnFileThree").val();
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                            }
                        }
                    }
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.Clear();
                    return responseText2; //一定要有一个返回值，否则会出错！
                }
                //var returnBool: boolean = !!responseText2;
                //if (returnBool == true) {
                ////存放主键；
                ////$("#hidKeyId").val();
                //    //判断是否有返回的附件路径值
                //    if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                //        var fileOne = $("#hdnFileOne").val();
                //        this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                //    }
                //    else {
                //        if ($("#hdnFileTwo").val() != "") {
                //            var fileTwo = $("#hdnFileTwo").val();
                //            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                //        }
                //        else {
                //            if ($("#hdnFileThree").val() != "") {
                //                var fileThree = $("#hdnFileThree").val();
                //                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                //            }
                //        }
                //    }
                //    var strInfo: string = `添加记录成功!`;
                //    $('#lblResult40').val(strInfo);
                //    //显示信息框
                //    alert(strInfo);
                //}
                //else {
                //    var strInfo: string = `添加记录不成功!`;
                //    $('#lblResult40').val(strInfo);
                //    //显示信息框
                //    alert(strInfo);
                //}
                //return responseText2;//一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                this.Clear();
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //添加上传论文附件方法
        async AddNewRecordobjPaperSubAttachmentENSave(filePath, strfileNum) {
            var objPaperSubAttachmentEN = new clsPaperSubAttachmentEN_js_1.clsPaperSubAttachmentEN();
            this.PutDataToPaperAttachmentClass(objPaperSubAttachmentEN, filePath);
            try {
                const responseText2 = await (0, clsPaperSubAttachmentWApi_js_1.PaperSubAttachment_AddNewRecordAsync)(objPaperSubAttachmentEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //var returnKeyId: string = responseText2;
                    //if (returnKeyId != "") {
                    //存放返回主键
                    //  $("#hidKeyId").val(returnKeyId);
                    //第一个附件
                    if (strfileNum == "first") {
                        //如果第二个附件不等于空，那么执行添加函数；
                        if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            //为空则判断第三个附件值；
                            if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                var fileThree = $("#hdnFileThree").val();
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                            }
                        }
                    }
                    else if (strfileNum == "two") {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }
                }
                else {
                    var strInfo = `论文附件添加不成功!`;
                    $('#lblResult40').val(strInfo);
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
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        PutDataToPaperAttachmentClass(pobjPaperSubAttachmentEN, filePath) {
            pobjPaperSubAttachmentEN.subViewpointId = $("#hidKeyId").val(); // 论文Id
            var strfilePath = filePath;
            //判断地址不为空则执行截取操作
            if (strfilePath != "") {
                var index = strfilePath.lastIndexOf("\/");
                strfilePath = strfilePath.substring(index + 1, strfilePath.length);
                pobjPaperSubAttachmentEN.filePath = filePath;
                pobjPaperSubAttachmentEN.paperSubAttachmentName = strfilePath;
            }
            pobjPaperSubAttachmentEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjPaperSubAttachmentEN.updUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改用户Id
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            objPaperSubViewpointEN.subViewpointId = this.KeyId;
            this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubViewpointExWApi_js_1.PaperSubViewpointEx_UpdateRecordAsyncEx)(objPaperSubViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //存放主键;
                            $("#hidKeyId").val(objPaperSubViewpointEN.subViewpointId);
                            //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                            if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                //根据Id删除附件
                                var strwhere = "subViewpointId ='" + objPaperSubViewpointEN.subViewpointId + "'";
                                this.DelRecordByWhere(strwhere);
                            }
                            var strInfo = `修改记录成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("完成UpdateRecordSave");
                        }
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `修改记录不成功,${e}.`;
                    alert(strMsg);
                    return false;
                }
            });
        }
        /*
     根据关键字删除记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        DelRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubAttachmentWApi_js_1.PaperSubAttachment_DelPaperSubAttachmentsByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                        }
                        else {
                            var strInfo = `删除记录不成功!`;
                            //显示信息框
                            //alert(strInfo);
                        }
                        //在修改时候，不管是否有附件数据被清除； 都需要执行附件添加功能
                        //判断是否有返回的附件路径值
                        var fileOne = $("#hdnFileOne").val();
                        if (fileOne != "" && fileOne != undefined) { //第一个附件框判断
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        }
                        else {
                            var fileTwo = $("#hdnFileTwo").val();
                            if (fileTwo != "" && fileTwo != undefined) {
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                            }
                            else {
                                var fileThree = $("#hdnFileThree").val();
                                if (fileThree != "" && fileThree != undefined) {
                                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                                }
                            }
                        }
                        console.log("完成DelRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 为插入记录做准备工作
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
      */
        AddNewRecord() {
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucPaperSubViewpointB1.subViewpointId = clsPaperSubViewpointBL.GetMaxStrId_S();
        }
        CombinevPaperSubViewpointCondition1() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperRWId = $("#hidPaperRWId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (strPaperRWId != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition2() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
                }
                strWhereCond += " order by orderNum Asc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition3() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1=1 ";
            var strPaperRWId = $("#hidPaperRWId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.SectionId_q != "" && this.SectionId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
                }
                if (strPaperRWId != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
                }
                if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
                }
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    //判断角色 教师
                    if (strRoleId == "00620001") {
                        //$("#btnDelRecord").show();
                    }
                    else if (strRoleId == "00620002") {
                        //可以查看所有；
                    }
                    else {
                        strWhereCond += " And updUser = '" + strUserId + "'";
                        //学生00620003
                        //只能查看自己的数据；或公开的数据；
                        //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                        //strWhereCond += ` And updUser = '${objvUserRoleRelation.userId}'`;
                    }
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
                //if (this.ExplainTypeId_q != "" && this.ExplainTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvPaperSubViewpointEN.con_ExplainTypeId} = '${this.ExplainTypeId_q}'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition4() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperRWId = $("#hidPaperRWId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.SectionId_q != "" && this.SectionId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
                }
                if (strPaperRWId != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
                }
                strWhereCond += " order by orderNum Asc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition5() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            return strWhereCond;
        }
        async BindGv_vPaperSubViewpoint() {
            //var strListDiv: string = this.mstrListDiv;
            var strWhereCond2 = this.CombinevPaperSubViewpointCondition2();
            var strWhereCond3 = this.CombinevPaperSubViewpointCondition3();
            var strWhereCond4 = this.CombinevPaperSubViewpointCondition4();
            var strWhereCond5 = this.CombinevPaperSubViewpointCondition5();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrSectionObjLst = [];
            var arrSubViewpointTypeObjLst = [];
            var arrvPaperSubViewpointObjLst = [];
            var arrvPaperSubViewpointObjLst2 = [];
            //获取图片
            var arrPaperSubAttachmentObjLst = [];
            var arrPaperSubAttachmentObjLst2 = [];
            try {
                //const responseText1 = Section_GetObjLstAsync(strWhereCond4).then((jsonData) => {
                //    arrSectionObjLst = <Array<clsSectionEN>>jsonData;
                //});
                const responseText2 = (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrSubViewpointTypeObjLst = jsonData;
                });
                const responseRecCount = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCondAsync)(strWhereCond3).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                this.hidSortvPaperSubViewpointBy = "orderNum Asc";
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond3,
                    orderBy: this.hidSortvPaperSubViewpointBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst3 = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperSubViewpointObjLst2 = jsonData;
                });
                const responseRecCount4 = await (0, clsPaperSubAttachmentWApi_js_1.PaperSubAttachment_GetObjLstAsync)(strWhereCond5).then((jsonData) => {
                    arrPaperSubAttachmentObjLst2 = jsonData;
                });
                var strhtml = "";
                //$('#divTwo li').remove();
                var cateid = 0;
                var cateid_ = 0;
                var intJ = 0;
                $('#tbList tr').remove();
                for (var j = 0; j < arrSubViewpointTypeObjLst.length; j++) {
                    cateid++;
                    intJ++;
                    var fid = 0;
                    var strsubTypeId = arrSubViewpointTypeObjLst[j].subViewpointTypeId;
                    //先创建子模块类型
                    //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>' + cateid + '</td><td></td><td><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></td><td></td><td></td><td class="td-manage">';
                    if ($("#hidIsSubmit").val() == "true") {
                        strhtml += '</td></tr>';
                    }
                    else {
                        strhtml += '<button class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '");><i class="layui-icon">&#xe642;</i>添加子栏目</button>';
                        strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnReOrder_Click("' + strsubTypeId + '")><i class="layui-icon">&#xe642;</i>重序</button>';
                        strhtml += '</td></tr>';
                    }
                    //子类型数据
                    var strSubViewpointId = "";
                    cateid_ = cateid;
                    var intK = 0;
                    arrvPaperSubViewpointObjLst = arrvPaperSubViewpointObjLst2.filter(x => x.subViewpointTypeId == strsubTypeId);
                    for (var k = 0; k < arrvPaperSubViewpointObjLst.length; k++) {
                        strSubViewpointId = arrvPaperSubViewpointObjLst[k].subViewpointId;
                        //先判断子模块类型数据ID和子观点知否匹配；
                        //if (strsubTypeId == arrvPaperSubViewpointObjLst[k].subViewpointTypeId) {
                        cateid++;
                        intK++;
                        //if (arrSectionObjLst.length != 0) {
                        //for (var i = 0; i < arrSectionObjLst.length; i++) {
                        //var strSectionId: string = arrSectionObjLst[i].sectionId;
                        //var strSectionName: string = arrSectionObjLst[i].sectionName;
                        //strhtml += '<li class="ui-li-has-alt ui-first-child"><a href="#" onclick="btnUpdateRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')" class="ui-btn" ><p>' + this.vSubViewpointObjLst[k].subViewpointContent + '</p></a><a href="#" class="ui-btn ui-btn-icon-notext ui-icon-delete" title="删除" onclick="btnDeleteRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')"></a></li>';
                        strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '"><td>' + cateid + '</td><td>' + arrvPaperSubViewpointObjLst[k].sectionName + '</td><td>&nbsp;&nbsp;&nbsp;&nbsp;' + intK + '.<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].rwTitle + '】' + arrvPaperSubViewpointObjLst[k].subViewpointContent + '';
                        //根据子观点id 得到附件
                        arrPaperSubAttachmentObjLst = arrPaperSubAttachmentObjLst2.filter(x => x.subViewpointId == strSubViewpointId);
                        for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" style="margin-left: 10px; " alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';
                        }
                        if (arrvPaperSubViewpointObjLst[k].explainContent != "") {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].explainTypeName + '】' + arrvPaperSubViewpointObjLst[k].explainContent + '';
                        }
                        //if (arrvPaperSubViewpointObjLst[k].literatureSourcesId != "") {
                        //else {
                        //    strhtml += '</td><td><input id="txt_OrderNum' + cateid + '" type="text" class="layui-input x-sort" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click(' + strSubViewpointId + ',"txt_OrderNum' + cateid + '");></td><td>' + arrvPaperSubViewpointObjLst[k].userName + '</td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage"><button class="layui-btn layui-btn layui-btn-xs" onclick="btnUpdateRecordInTab_Click(' + strSubViewpointId + ')"><i class="layui-icon">&#xe642;</i>编辑</button><button class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelRecordInTab_Click(' + strSubViewpointId + ')" href="javascript:;"><i class="layui-icon">&#xe640;</i>删除</button><button class="layui-btn layui-btn layui-btn-xs" onclick="btnUpMoveEx_Click(' + strSubViewpointId + ')" href="javascript:;"><i class="iconfont">&#xe6a5;</i>上移</button><button class="layui-btn layui-btn layui-btn-xs" onclick="btnDownMove_Click(' + strSubViewpointId + ')" href="javascript:;"><i class="iconfont">&#xe6a6;</i>下移</button></td></tr>';
                        //}
                        strhtml += '</td><td><input id="txt_OrderNum' + cateid + '" type="text" class="layui-input x-sort" style="width:40px;" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click("' + strSubViewpointId + '","txt_OrderNum' + cateid + '");>';
                        //上移
                        strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a5;</i></button>';
                        //下移
                        strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a6;</i></button>';
                        strhtml += '</td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage">';
                        if ($("#hidIsSubmit").val() == "true") {
                            strhtml += '' + arrvPaperSubViewpointObjLst[k].okCount + '&nbsp;&nbsp;<img src="../img/vote.png" width = "20px" height = "20px" title = "点赞数" >';
                            strhtml += '&nbsp;&nbsp;评论数：<a href="#" onclick=btnShowAppraise_Click("' + strSubViewpointId + '")>' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a>';
                            if (arrvPaperSubViewpointObjLst[k].score == null) {
                                strhtml += '&nbsp;&nbsp;评分：0';
                            }
                            else {
                                strhtml += '&nbsp;&nbsp;评分：' + arrvPaperSubViewpointObjLst[k].score + '';
                            }
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = "btnAddAppraise_Click(' + strSubViewpointId + ')" > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                        }
                        else {
                            strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strSubViewpointId + '")><i class="layui-icon">&#xe642;</i>编辑</button>';
                            strhtml += '<button class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strSubViewpointId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i>删除</button>';
                        }
                        //if ($("#hidUserId").val() == arrvPaperSubViewpointObjLst[k].updUser && arrvPaperSubViewpointObjLst[k].IsPublicEx == false) {
                        //} else {
                        //    if (arrvPaperSubViewpointObjLst[k].literatureSourcesId == null || arrvPaperSubViewpointObjLst[k].literatureSourcesId == "") {
                        //        strhtml += '</td><td>' + arrvPaperSubViewpointObjLst[k].orderNum + '</td><td>' + arrvPaperSubViewpointObjLst[k].userName + '</td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage">' + arrvPaperSubViewpointObjLst[k].okCount + '&nbsp;&nbsp;<a href="#" onclick="btnAddLikeLog_Click(' + strSubViewpointId + ')"><img src="../img/vote.png" width="20px" height="20px"  title="点赞"></a>&nbsp;&nbsp;评论数：<a href="#" onclick="btnShowAppraise_Click(' + strSubViewpointId + ')">' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a>&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick="btnAddAppraise_Click(' + strSubViewpointId + ')"><i class="layui-icon">&#xe642;</i>添加评论</button></td></tr>';
                        //    }
                        //    else {
                        strhtml += '</td></tr>';
                        //}
                        //}
                        //}
                    }
                }
                //拼接；
                $("#tbList").append(strhtml);
                //调用拼接方法
                //this.GetHtmlByDataSource();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        btnUpdateRecordInTab_Click(strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.Clear();
            var lngKeyId = strKeyId;
            this.UpdateRecord(lngKeyId);
        }
        /*查询*/
        async btnQueryEx_Click() {
            try {
                const gvResult = await this.BindGv_vPaperSubViewpoint();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /**添加 */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                this.selectTitle_Click();
                this.Clear();
                const responseText = await this.AddNewRecord();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
       重序
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
       */
        async btnReOrder_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = $("#hidSubViewpointTypeId").val();
            var strPaperRWId = $("#hidPaperRWId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_ReOrderAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        }
        //public async btnUpMoveEx_Click(strKeyId: string) {
        //    if (this.PreCheck4Order() == false) return;
        //    var strSubViewpointTypeId: string = this.subViewpointTypeId;
        //    var strPaperRWId: string = $("#hidPaperRWId").val();
        //    var arrKeyIds = strKeyId;
        //    try {
        //        var objOrderByData: clsOrderByData = new clsOrderByData();
        //        objOrderByData.KeyIdLst.push(arrKeyIds);
        //        var jsonObject =
        //        {
        //            "subViewpointTypeId": strSubViewpointTypeId,
        //            "paperRWId": strPaperRWId,
        //        };
        //        var jsonStr: string = JSON.stringify(jsonObject);
        //        objOrderByData.ClassificationFieldValueLst = jsonStr;
        //        const responseRederBy = await PaperSubViewpoint_UpMoveAsync(objOrderByData);
        //    }
        //    catch (e) {
        //        var strMsg: string = `上移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
        //        alert(strMsg);
        //        return;
        //    }
        //    const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //}
        /*
        上移
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
        */
        async btnUpMove_Click() {
            if ($('#hidOrderNum').val() == 0) {
                const responseOrder = await this.btnReOrder_Click();
            }
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = $("#hidSubViewpointTypeId").val();
            var strPaperRWId = $("#hidPaperRWId").val();
            var arrKeyIds = $("#hidKeyId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_UpMoveAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `上移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            //var strListDiv: string = this.mstrListDiv;
            //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        //public async btnDownMove_Click(strKeyId: string) {
        //    if (this.PreCheck4Order() == false) return;
        //    var strSubViewpointTypeId: string = this.subViewpointTypeId;
        //    var strPaperRWId: string = $("#hidPaperRWId").val();
        //    var arrKeyIds = strKeyId;
        //    try {
        //        var objOrderByData: clsOrderByData = new clsOrderByData();
        //        //objOrderByData.KeyIdLst = arrKeyIds;
        //        objOrderByData.KeyIdLst.push(arrKeyIds);
        //        var jsonObject =
        //        {
        //            "subViewpointTypeId": strSubViewpointTypeId,
        //            "paperRWId": strPaperRWId,
        //        };
        //        var jsonStr: string = JSON.stringify(jsonObject);
        //        objOrderByData.ClassificationFieldValueLst = jsonStr;
        //        const responseRederBy = await PaperSubViewpoint_DownMoveAsync(objOrderByData);
        //    }
        //    catch (e) {
        //        var strMsg: string = `下移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
        //        alert(strMsg);
        //        return;
        //    }
        //    const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //}
        /*
        下移
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
        */
        async btnDownMove_Click() {
            if ($('#hidOrderNum').val() == 0) {
                const responseOrder = await this.btnReOrder_Click();
            }
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = $("#hidSubViewpointTypeId").val();
            var strPaperRWId = $("#hidPaperRWId").val();
            var arrKeyIds = $("#hidKeyId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_DownMoveAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `下移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            //const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            //var strListDiv: string = this.mstrListDiv;
            //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /* 在数据表里修改排序记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
      */
        async btnUpdateOrderNum_Click(strKeyId, strOrderNum) {
            //var lngKeyId = Number(strKeyId);
            var objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            objPaperSubViewpointEN.subViewpointId = strKeyId;
            objPaperSubViewpointEN.orderNum = Number($("#" + strOrderNum + "").val());
            objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_UpdateRecordAsync)(objPaperSubViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //var strInfo: string = `修改排序号成功!`;
                            //$('#lblResult44').val(strInfo);
                            ////显示信息框
                            //alert(strInfo);
                            const responseBindGv = this.BindGv_vPaperSubViewpoint();
                        }
                        else {
                            //var strInfo: string = `修改排序号不成功!`;
                            //$('#lblResult44').val(strInfo);
                            ////显示信息框
                            //alert(strInfo);
                            //console.log("完成UpdateRecordSave");
                        }
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `修改记录不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        async selectTitle_Click() {
            try {
                var objSubViewpointType;
                var strWhereCond = " subViewpointTypeId='" + this.subViewpointTypeId + "'";
                const responseRecCount = await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objSubViewpointType = jsonData;
                    this.rwTitle = objSubViewpointType.defaTitle;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取记录不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Section]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_SectionId(ddlSectionId, strPaperId) {
            var strWhereCond = " 1 =1 and paperId='" + strPaperId + "'";
            var objDdl = document.getElementById(ddlSectionId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlSectionId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSectionWApi_js_1.Section_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrSectionObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlSectionId, arrSectionObjLst, clsSectionEN_js_1.clsSectionEN.con_SectionId, clsSectionEN_js_1.clsSectionEN.con_SectionName, "论文节");
                        console.log("完成BindDdl_SectionId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /*
        * 论文读写Id
       */
        // public set paperRWId(value: string) {
        //     $("#hidPaperRWId").val(value);
        // }
        // /*
        // * 论文读写Id
        //*/
        // public get paperRWId(): string {
        //     return $("#hidPaperRWId").val();
        // }
        /*
        * 修改用户Id
       */
        // public set updUser(value: string) {
        //     $("#hidUserId").val(value);
        // }
        // /*
        // * 修改用户Id
        //*/
        // public get updUser(): string {
        //     return $("#hidUserId").val();
        // }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjPaperSubViewpointEN">数据传输的目的类对象</param>
      */
        PutDataToPaperSubViewpointClass(pobjPaperSubViewpointEN) {
            pobjPaperSubViewpointEN.paperRWId = $("#hidPaperRWId").val(); // 论文读写Id
            pobjPaperSubViewpointEN.sectionId = this.sectionId; //节
            pobjPaperSubViewpointEN.subViewpointTypeId = this.subViewpointTypeId; // 类型Id
            pobjPaperSubViewpointEN.rwTitle = this.rwTitle; // 读写标题
            pobjPaperSubViewpointEN.subViewpointContent = this.subViewpointContent; // 详情内容
            pobjPaperSubViewpointEN.explainTypeId = this.explainTypeId; // 说明类型Id
            pobjPaperSubViewpointEN.explainContent = this.explainContent; // 说明内容
            pobjPaperSubViewpointEN.isPublic = this.isPublic; // 是否公开
            pobjPaperSubViewpointEN.literatureSourcesId = this.literatureSourcesId; // 文献来源
            pobjPaperSubViewpointEN.pageNumber = this.pageNumber; // 页码
            if (this.orderNum == 0) {
                pobjPaperSubViewpointEN.orderNum = 30;
            }
            else {
                pobjPaperSubViewpointEN.orderNum = this.orderNum; // 序号
            }
            pobjPaperSubViewpointEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改用户Id
            //pobjPaperSubViewpointEN.updUser = $("#hidUserId").val();// 修改用户Id
            pobjPaperSubViewpointEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjPaperSubViewpointEN.memo = this.memo; // 备注
        }
        //添加点赞
        //public async btnAddLikeLog_Click() {
        //    //this.DivName = "divAddNewRecordSave";
        //    var objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();
        //    //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        //    objPaperSubViewpointLikeLogEN.subViewpointId = $("#hidSubViewpointId").val();
        //    objPaperSubViewpointLikeLogEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        //    objPaperSubViewpointLikeLogEN.updUser = $("#hidUserId").val();// 修改用户Id
        //    var strWhereCond = " 1 =1 and updUser='" + objPaperSubViewpointLikeLogEN.updUser + "' and subViewpointId=" + objPaperSubViewpointLikeLogEN.subViewpointId;
        //    try {
        //        const responseText = await PaperSubViewpointLikeLog_IsExistRecordAsync(strWhereCond);
        //        var bolIsExist: boolean = responseText;
        //        if (bolIsExist == true) {
        //            var strMsg: string = `您已经点赞过这条观点了，请给其他观点点赞一下吧！`;
        //            alert(strMsg);
        //            return responseText;//一定要有一个返回值，否则会出错！
        //        }
        //        const responseText2 = await PaperSubViewpointLikeLog_AddNewRecordAsync(objPaperSubViewpointLikeLogEN);
        //        var returnBool: boolean = !!responseText2;
        //        if (returnBool == true) {
        //            var strInfo: string = `点赞成功!`;
        //            $('#lblResult40').val(strInfo);
        //            //显示信息框
        //            alert(strInfo);
        //            this.BindGv_vPaperSubViewpoint();
        //        }
        //        else {
        //            var strInfo: string = `点赞不成功!`;
        //            $('#lblResult40').val(strInfo);
        //            //显示信息框
        //            alert(strInfo);
        //            this.BindGv_vPaperSubViewpoint();
        //        }
        //        return responseText2;//一定要有一个返回值，否则会出错！
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `点赞不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    return true;//一定要有一个返回值，否则会出错！
        //}
        /* 添加评论
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        //public async SubmitAppraise_Click() {
        //    this.DivName = "divAddNewRecordSave";
        //    var objPaperSubViewpointAppraiseEN: clsPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
        //    //this.PutDataToPaperSubViewpointAppraiseClass(objPaperSubViewpointAppraiseEN);
        //    objPaperSubViewpointAppraiseEN.subViewpointId = $("#hidSubViewpointId").val();
        //    objPaperSubViewpointAppraiseEN.AppraiseScore = $("#txtAppraiseScore").val();// 打分
        //    objPaperSubViewpointAppraiseEN.AppraiseContent = $("#txtAppraiseContent").val();// 评议内容
        //    objPaperSubViewpointAppraiseEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        //    objPaperSubViewpointAppraiseEN.updUser = $("#hidUserId").val();// 修改用户Id
        //    try {
        //        const responseText2 = await PaperSubViewpointAppraise_AddNewRecordAsync(objPaperSubViewpointAppraiseEN);
        //        var returnBool: boolean = !!responseText2;
        //        if (returnBool == true) {
        //            var strInfo: string = `添加评论成功!`;
        //            $('#lblResult40').val(strInfo);
        //            //显示信息框
        //            alert(strInfo);
        //            HideDialog3();
        //            this.BindGv_vPaperSubViewpoint();
        //            this.btnShowAppraise_Click();
        //        }
        //        else {
        //            var strInfo: string = `添加评论不成功!`;
        //            $('#lblResult40').val(strInfo);
        //            //显示信息框
        //            alert(strInfo);
        //            HideDialog3();
        //            this.BindGv_vPaperSubViewpoint();
        //            this.btnShowAppraise_Click();
        //        }
        //        $("#btnOKUpdAppraise").attr("disabled", false);
        //        return responseText2;//一定要有一个返回值，否则会出错！
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `添加评论不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    return true;//一定要有一个返回值，否则会出错！
        //}
        ////显示评论
        //public async btnShowAppraise_Click() {
        //    var arrvPaperSubViewpointAppraiseObjLst: Array<clsvPaperSubViewpointAppraiseEN> = [];
        //    var strWhereCond = " subViewpointId=" + $("#hidSubViewpointId").val();
        //    try {
        //        const responseText = vPaperSubViewpointAppraise_GetObjLstAsync(strWhereCond).then((jsonData) => {
        //            arrvPaperSubViewpointAppraiseObjLst = <Array<clsvPaperSubViewpointAppraiseEN>>jsonData;
        //            var strhtml = "";
        //            var cateid: number = 0;
        //            $('#AppraiseList tr').remove();
        //            for (var i = 0; i < arrvPaperSubViewpointAppraiseObjLst.length; i++) {
        //                cateid++;
        //                strhtml += '<tr><td>' + cateid + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].AppraiseContent + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].AppraiseScore + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].userName + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].updDate + '</td><td class="td-manage"></td></tr>';
        //            }
        //            $("#AppraiseList").append(strhtml);
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `获取数据不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //是否显示
        async btnIsDisplay_Click() {
            if (this.IsDisplay == "显示论文") {
                this.IsDisplay = "隐藏论文";
                $("#tabwucPaperReadWrite").show();
            }
            else if (this.IsDisplay == "隐藏论文") {
                this.IsDisplay = "显示论文";
                $("#tabwucPaperReadWrite").hide();
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
                //var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(strKeyId);
                const responseText2 = await this.BindGv_vPaperSubViewpoint();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        DelRecord(strSubViewpointId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubViewpointExWApi_js_1.PaperSubViewpointEx_DelRecordAsyncEx)(strSubViewpointId).then((jsonData) => {
                        //const responseText = PaperSubViewpoint_DelRecordAsync(strSubViewpointId).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            //删除子观点时，需要同时去删除附件；
                            //根据Id删除附件
                            var strwhere = "subViewpointId ='" + strSubViewpointId + "'";
                            this.DelAttactmentRecordByWhere(strwhere);
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
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
        }
        /*
    根据关键字删除记录 附件
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        DelAttactmentRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubAttachmentWApi_js_1.PaperSubAttachment_DelPaperSubAttachmentsByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                        }
                        else {
                            var strInfo = `删除记录不成功!`;
                            //显示信息框
                            //alert(strInfo);
                        }
                        console.log("完成DelRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
        }
        //下载文件
        btnDownLoadFile_Click() {
            this.GetPaperAttachmentRecord();
            this.btnAddDownload_Click();
        }
        GetPaperAttachmentRecord() {
            var strPapeId = $("#hidPaperId").val();
            //this.KeyId = strPaperRWId;
            var strWhereCond = ` ${clsPaperAttachmentEN_js_1.clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
            var arrPaperAttachmentObjLst = [];
            try {
                const responseText = (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrPaperAttachmentObjLst = jsonData;
                    for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {
                        var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                        doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
                    }
                });
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        //添加下载量
        async btnAddDownload_Click() {
            //this.DivName = "divAddNewRecordSave";
            var objPaperDownloadLogEN = new clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperDownloadLogEN.paperId = $("#hidPaperId").val();
            objPaperDownloadLogEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            objPaperDownloadLogEN.updUser = $("#hidUserId").val(); // 修改用户Id
            var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + objPaperDownloadLogEN.paperId;
            try {
                //const responseText = await PaperDownloadLog_IsExistRecordAsync(strWhereCond);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    //var strMsg: string = `您已经收藏过这条论文了！`;
                //    //alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_AddNewRecordAsync)(objPaperDownloadLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //var strInfo: string = `收藏成功!`;
                    //$('#lblResult40').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                else {
                    var strInfo = `添加下载量不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加下载量不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        Clear() {
            this.paperRWId = "";
            $('#ddlSectionId option[0]').attr("selected", true);
            $('#ddlSubViewpointTypeId option[0]').attr("selected", true);
            this.rwTitle = "";
            this.subViewpointContent = "";
            $('#ddlExplainTypeId option[0]').attr("selected", true);
            this.explainContent = "";
            this.isPublic = false;
            this.literatureSourcesId = "";
            this.pageNumber = 0;
            this.orderNum = 0;
            this.Uploadfile = "";
            this.updUser = "";
            this.updDate = "";
            this.memo = "";
            $("#hdnFileOne").val("");
            $("#hdnFileTwo").val("");
            $("#hdnFileThree").val("");
        }
        /*
       * 设置上传文件
       */
        set Uploadfile(value) {
            $("#txtUploadfile").val(value);
        }
        /*
        * 获取上传文件
        */
        get Uploadfile() {
            return $("#txtUploadfile").val();
        }
        /*
       * 设置是否隐藏显示
       */
        set IsDisplay(value) {
            $("#btnIsDisplay").html(value);
        }
        /*
        * 获取是否隐藏显示
        */
        get IsDisplay() {
            return $("#btnIsDisplay").html();
        }
    }
    exports.PaperSubViewpoint_QUDI = PaperSubViewpoint_QUDI;
});
