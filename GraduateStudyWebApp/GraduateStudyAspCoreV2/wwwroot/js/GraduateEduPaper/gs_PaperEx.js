(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Pub_PaperList.js", "../PagesBase/GraduateEduPaper/gs_PaperVer_Edit.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js", "../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js", "../TS/L0_Entity/ParameterTable/clsgs_PaperStatusEN.js", "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_PaperStatusWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsPaperWApiEx.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperEx = void 0;
    const Pub_PaperList_js_1 = require("../GraduateEduPublicPage/Pub_PaperList.js");
    const gs_PaperVer_Edit_js_1 = require("../PagesBase/GraduateEduPaper/gs_PaperVer_Edit.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsgs_OriginalPaperLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js");
    const clsgs_PaperVerEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js");
    const clsMajorDirectionPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsRTPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js");
    const clsgs_PaperStatusEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_PaperStatusEN.js");
    const clsgs_PaperTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsgs_OriginalPaperLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js");
    const clsgs_PaperVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsMajorDirectionPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsRTPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js");
    const clsgs_PaperStatusWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_PaperStatusWApi.js");
    const clsgs_PaperTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsPaperWApiEx_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsPaperWApiEx.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* gs_PaperEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_PaperEx extends gs_PaperVer_Edit_js_1.gs_PaperVer_Edit {
        constructor() {
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvPaperBy: string = "paperId";
            super(...arguments);
            //专业方向
            this.mstrListDivMajorDirection = "divMajorDirectionDataLst";
        }
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    //判断自研论文的步骤顺序 来改变按钮颜色；
                    const gvBtnColor = await this.ChangeBtnColorByTypeId();
                    var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                    //判断角色
                    //管理员
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                        $("#btnAudit").show();
                        $("#btnSynPaperStatistics").show();
                    }
                    else if (strRoleId == "00620002") {
                        $("#btnDelRecord").hide();
                        $("#btnAudit").show();
                    }
                    else {
                        $("#btnDelRecord").hide();
                        $("#btnAudit").hide();
                        $("#btnCancelSubmit").hide();
                    }
                    //2、显示无条件的表内容在GridView中
                    const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
                    await objPage_Paper.Page_Load();
                    //await objPage_Paper.BindGv_vPaper();
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
        //根据论文进度步骤来显示按钮颜色 或置灰
        async ChangeBtnColorByTypeId() {
            var strWhere = " 1 = 1 order by logTypeId desc";
            const responseText = await (0, clsgs_OriginalPaperLogWApi_js_1.gs_OriginalPaperLog_GetFirstObjAsync)(strWhere).then((jsonData) => {
                var objgs_OriginalPaperLog = jsonData;
                if (objgs_OriginalPaperLog != null) {
                    var logTypeId = objgs_OriginalPaperLog.logTypeId;
                    switch (logTypeId) {
                        case "01":
                            $('#btnAddNewPaper').attr("disabled", false);
                            $('#btnAddSubviewpointPaper').attr("disabled", false);
                            $("#btnAddSubviewpointPaper").removeClass();
                            $("#btnAddSubviewpointPaper").addClass("layui-btn");
                            $('#btnAddFirstPaper').attr("disabled", true);
                            $('#btnGroupDiscuss').attr("disabled", true);
                            $('#btnUpdatePaper').attr("disabled", true);
                            $('#btnCompanionProposal').attr("disabled", true);
                            $('#btnEndPaper').attr("disabled", true);
                            break;
                        case "02":
                            $('#btnAddNewPaper').attr("disabled", false);
                            $('#btnAddSubviewpointPaper').attr("disabled", false);
                            $("#btnAddSubviewpointPaper").removeClass();
                            $("#btnAddSubviewpointPaper").addClass("btn btn-outline-info text-nowrap btn-sm");
                            $('#btnAddFirstPaper').attr("disabled", false);
                            $("#btnAddFirstPaper").removeClass();
                            $("#btnAddFirstPaper").addClass("layui-btn");
                            $('#btnGroupDiscuss').attr("disabled", true);
                            $('#btnUpdatePaper').attr("disabled", true);
                            $('#btnCompanionProposal').attr("disabled", true);
                            $('#btnEndPaper').attr("disabled", true);
                            break;
                        case "03":
                            $('#btnAddNewPaper').attr("disabled", false);
                            $('#btnAddSubviewpointPaper').attr("disabled", true);
                            $('#btnAddFirstPaper').attr("disabled", false);
                            $("#btnAddFirstPaper").removeClass();
                            $("#btnAddFirstPaper").addClass("btn btn-outline-info text-nowrap btn-sm");
                            $('#btnGroupDiscuss').attr("disabled", false);
                            $("#btnGroupDiscuss").removeClass();
                            $("#btnGroupDiscuss").addClass("layui-btn");
                            $('#btnUpdatePaper').attr("disabled", true);
                            $('#btnCompanionProposal').attr("disabled", true);
                            $('#btnEndPaper').attr("disabled", true);
                            break;
                        case "04":
                            $('#btnAddNewPaper').attr("disabled", false);
                            $('#btnAddSubviewpointPaper').attr("disabled", false);
                            $('#btnAddFirstPaper').attr("disabled", false);
                            $('#btnGroupDiscuss').attr("disabled", false);
                            $("#btnGroupDiscuss").removeClass();
                            $("#btnGroupDiscuss").addClass("btn btn-outline-info text-nowrap btn-sm");
                            $('#btnUpdatePaper').attr("disabled", false);
                            $("#btnUpdatePaper").removeClass();
                            $("#btnUpdatePaper").addClass("layui-btn");
                            $('#btnCompanionProposal').attr("disabled", true);
                            $('#btnEndPaper').attr("disabled", true);
                            break;
                        case "05":
                            $('#btnAddNewPaper').attr("disabled", false);
                            $('#btnAddSubviewpointPaper').attr("disabled", false);
                            $('#btnAddFirstPaper').attr("disabled", false);
                            $('#btnGroupDiscuss').attr("disabled", false);
                            $('#btnUpdatePaper').attr("disabled", false);
                            $("#btnUpdatePaper").removeClass();
                            $("#btnUpdatePaper").addClass("btn btn-outline-info text-nowrap btn-sm");
                            $('#btnCompanionProposal').attr("disabled", false);
                            $("#btnCompanionProposal").removeClass();
                            $("#btnCompanionProposal").addClass("layui-btn");
                            $('#btnEndPaper').attr("disabled", true);
                            break;
                        case "06":
                            $('#btnAddNewPaper').attr("disabled", false);
                            $('#btnAddSubviewpointPaper').attr("disabled", false);
                            $('#btnAddFirstPaper').attr("disabled", false);
                            $('#btnGroupDiscuss').attr("disabled", false);
                            $('#btnUpdatePaper').attr("disabled", false);
                            $('#btnCompanionProposal').attr("disabled", false);
                            $("#btnCompanionProposal").removeClass();
                            $("#btnCompanionProposal").addClass("btn btn-outline-info text-nowrap btn-sm");
                            $('#btnEndPaper').attr("disabled", false);
                            $("#btnEndPaper").removeClass();
                            $("#btnEndPaper").addClass("layui-btn");
                            break;
                        case "07":
                            $('#btnAddNewPaper').attr("disabled", false);
                            $('#btnAddSubviewpointPaper').attr("disabled", false);
                            $('#btnAddFirstPaper').attr("disabled", false);
                            $('#btnGroupDiscuss').attr("disabled", false);
                            $('#btnUpdatePaper').attr("disabled", false);
                            $('#btnCompanionProposal').attr("disabled", false);
                            $('#btnEndPaper').attr("disabled", false);
                            $("#btnEndPaper").removeClass();
                            $("#btnEndPaper").addClass("btn btn-outline-info text-nowrap btn-sm");
                            break;
                        default:
                            var strMsg = `没有数据处理！`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    //等于空，那么新建则保持原样，其他按钮置灰
                    $('#btnAddNewPaper').attr("disabled", false);
                    $('#btnAddSubviewpointPaper').attr("disabled", true);
                    $('#btnAddFirstPaper').attr("disabled", true);
                    $('#btnGroupDiscuss').attr("disabled", true);
                    $('#btnUpdatePaper').attr("disabled", true);
                    $('#btnCompanionProposal').attr("disabled", true);
                    $('#btnEndPaper').attr("disabled", true);
                }
            });
        }
        //统计核算
        async btnSynPaperStatistics_Click() {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                $("#divLoading").show();
                const responseText2 = await clsPaperWApiEx_js_1.clsPaperWApiEx.SynPaperStatisticsAsync(strUserId);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `统计核算成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $("#divLoading").hide();
                }
                else {
                    var strInfo = `统计核算不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $("#divLoading").hide();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `统计核算异常,${e}.`;
                alert(strMsg);
                $("#divLoading").hide();
            }
        }
        //新建论文
        async btnAddNewPaper_Click() {
            this.opType = "Add";
            try {
                const responseText = await this.AddNewRecord();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        //搜集子观点
        async btnAddSubviewpointPaper_Click() {
            var strLogId = $('#PaperLogTypeId').val();
            var strPaperId = $('#hidPaperId').val();
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            //  var strPaperTypeLogId = this.GetPapertypeLogId(strLogId);
            try {
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `收集子观点方法不成功,${e}.`;
                alert(strMsg);
            }
        }
      
        //同伴建议
        async btnCompanionProposal_Click() {
            var strLogId = $('#PaperLogTypeId').val();
            var strPaperTypeLogId = this.GetPapertypeLogId(strLogId);
            try {
                //通过Id查询是否存在此记录，不存在则提示不能进行此步骤操作；
                var strWhere = " 1=1 And logTypeId='" + strPaperTypeLogId + "'";
                const responseText = await (0, clsgs_OriginalPaperLogWApi_js_1.gs_OriginalPaperLog_GetFirstObjAsync)(strWhere).then((jsonData) => {
                    var objgs_OriginalPaperLog = jsonData;
                    if (objgs_OriginalPaperLog != null) {
                        //功能待完善
                    }
                    else {
                        //成员
                        var strMsg = `上一步骤未完成，不可使用此功能！`;
                        alert(strMsg);
                        return;
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `收集子观点方法不成功,${e}.`;
                alert(strMsg);
            }
        }
        //通过获得步骤类型 返回上一步骤类型ID；
        GetPapertypeLogId(logTypeId) {
            var strLogTypeId = "";
            try {
                switch (logTypeId) {
                    case "01":
                        strLogTypeId = ""; //01第一个流程步骤，所以不用查询上一步骤；
                        break;
                    case "02":
                        strLogTypeId = "01";
                        break;
                    case "03":
                        strLogTypeId = "02";
                        break;
                    case "04":
                        strLogTypeId = "03";
                        break;
                    case "05":
                        strLogTypeId = "04";
                        break;
                    case "06":
                        strLogTypeId = "05";
                        break;
                    case "07":
                        strLogTypeId = "06";
                        break;
                    default:
                        var strMsg = `没有数据处理！`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `收集子观点方法不成功,${e}.`;
                alert(strMsg);
            }
            return strLogTypeId;
        }
        async BindDdl4QueryRegion() {
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
            //var objXzMajor_Cond: clsXzMajorEN = new clsXzMajorEN();//查询区域
            //const ddl_id_XzMajor_q = await clsDropDownList.BindDdl_XzMajorInvPaper_Cache("ddlid_XzMajor_q", objXzMajor_Cond);//专业查询区域
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
            //绑定编辑文献类型
            const ddl_LiteratureTypeId = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
            // const ddl_PaperTypeId_q = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId_q");
            //绑定论文类型下拉框
            //  const ddl_PaperTypeId = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId");
            //论文状态
            const ddl_PaperStatusId_q = await this.BindDdl_gs_PaperStatus_Cache("ddlPaperStatusId");
            //
            //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
            //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajorNum("ddlid_XzMajor_q");
        }
        /* 添加新记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
     */
        async btnAddNewRecord_Click() {
            this.opType = "Add";
            try {
                const responseText = await this.AddNewRecord();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        async BindDdl_gs_PaperType_Cache(ddlgs_PaperTypeId) {
            var strWhereCond = " 1=1 ";
            var objDdl = document.getElementById(ddlgs_PaperTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlgs_PaperTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsgs_PaperTypeWApi_js_1.gs_PaperType_GetObjLstAsync)(strWhereCond);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
                console.log("完成BindDdl_gs_PaperType_Cache!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async BindDdl_gs_PaperStatus_Cache(ddlgs_PaperStatusId) {
            var strWhereCond = " 1=1 ";
            var objDdl = document.getElementById(ddlgs_PaperStatusId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlgs_PaperStatusId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsgs_PaperStatusWApi_js_1.gs_PaperStatus_GetObjLstAsync)(strWhereCond);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlgs_PaperStatusId, arrObjLst_Sel, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusName, "论文状态");
                console.log("完成BindDdl_gs_PaperStatus_Cache!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //专业下拉框绑定
        //public BindDdl_id_XzMajorNum(ddlid_XzMajor: string, strWhereCond: string = "1=1") {
        //    //var strWhereCond = " 1 =1 ";
        //    var objDdl = document.getElementById(ddlid_XzMajor);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = vPaperEx_GetMajorNumObjLstAsync(strWhereCond).then((jsonData) => {
        //                var arrXzMajorObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>jsonData;
        //                BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsPaperEN.con_id_XzMajor, clsPaperEN.con_MajorName, "专业");
        //                console.log("完成BindDdl_id_XzMajor!");
        //                resolve(jsonData);
        //            });
        //        }
        //        catch (e) {
        //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //    });
        //}
        async BindDdl_LiteratureTypeId_Cache(ddlLiteratureTypeId, objLiteratureType_Cond) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetSubObjLst_Cache)(objLiteratureType_Cond);
                arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId]);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                console.log("完成BindDdl_LiteratureTypeId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 查询
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async btnQuery_Click(strListDiv) {
            try {
                $("#divLoading").show();
                const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
                await objPage_Paper.Page_Load();
                //await objPage_Paper.BindGv_vPaper();
                $("#divLoading").hide();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
      */
        async btnDelRecord_Click() {
            try {
                var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var strKeyList;
                if (arrKeyIds.length == 0)
                    return "";
                strKeyList = "";
                for (var i = 0; i < arrKeyIds.length; i++) {
                    if (i == 0)
                        strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                    else
                        strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
                }
                var strWhereCond = " paperId in (" + strKeyList + ")";
                var intPaperRWCount = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetRecCountByCondAsync)(strWhereCond);
                if (intPaperRWCount != 0) {
                    alert("请先删除该论文下阅读或写作数据！");
                    return "";
                }
                var intRTPaperCount = await (0, clsRTPaperRelaWApi_js_1.RTPaperRela_GetRecCountByCondAsync)(strWhereCond);
                if (intRTPaperCount != 0) {
                    alert("请先删除该论文和主题关系数据！");
                    return "";
                }
                const responseText1 = await this.DelRecordByWhere(strWhereCond);
                //刷新缓存
                (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(strid_CurrEducls);
                const responseText2 = await this.DelMultiRecord(arrKeyIds);
                const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
                await objPage_Paper.Page_Load();
                //await objPage_Paper.BindGv_vPaper();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据关键字列表删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
     */
        async DelMultiRecord(arrPaperId) {
            try {
                const returnInt = await (0, clsPaperWApi_js_1.Paper_DelPapersAsync)(arrPaperId);
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
        /* 为插入记录做准备工作 设置相关操作；
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            //this.SetKeyReadOnly(false);
            this.btnSubmit_gs_PaperVer = "确认添加";
            this.btnCancel_gs_PaperVer = "取消添加";
            this.Clear();
            this.Disabled_false();
            //$('#btnOKUpd').attr("disabled", false);
            //wucPaperB1.paperId = clsPaperBL.GetMaxStrId_S();
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
    */
        async AddNewRecordWithMaxIdSaveRetrunId() {
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            this.PutDataToPaperClass(objPaperEN);
            try {
                //先判断数据论文标题是否重名
                var intPaperCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)("1=1 and paperTitle='" + this.paperTitle + "' and id_CurrEduCls ='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'");
                if (intPaperCount != 0) {
                    var strMsg = `添加记录时，当前教学班论文标题：${objPaperEN.paperTitle}已经存在，请重新命名！`;
                    alert(strMsg);
                    return false; //一定要有一个返回值，否则会出错！
                }
                //const responseText2 = await SysSkill_AddNewRecordWithMaxIdAsync(objSysSkillEN);
                const responseText = await (0, clsPaperWApi_js_1.Paper_AddNewRecordWithReturnKeyAsync)(objPaperEN);
                var strPaperId = responseText;
                //var returnBool: boolean = !!responseText2;
                if (strPaperId != "") {
                    //存放主键
                    $("#hidPaperId").val(strPaperId);
                    //判断是否有返回的附件路径值
                    if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        var fileOne = $("#hdnFileOne").val();
                        const responseText06 = await this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                        var returnBool2 = !!responseText06;
                        if (returnBool2 != true) {
                            var strInfo = `添加论文成功,但添加附件失败，请修改该条数据重新上传附件!`;
                            alert(strInfo);
                            return false;
                        }
                    }
                    else {
                        if ($("#hdnFileTwo").val() != "") {
                            var fileTwo = $("#hdnFileTwo").val();
                            const responseText07 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                        }
                        else {
                            if ($("#hdnFileThree").val() != "") {
                                var fileThree = $("#hdnFileThree").val();
                                const responseText08 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                            }
                        }
                    }
                    return true;
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return strPaperId; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            //return strSysPaperId;//一定要有一个返回值，否则会出错！
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd_Click() {
            if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                var strCommandText = this.btnSubmit_gs_PaperVer;
                try {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            var returnBool = true;
                            //const responseText2 = await this.AddNewRecordWithMaxIdSaveRetrunId AddNewRecordSave().then((jsonData) => {
                            //    returnBool = jsonData;
                            //});
                            const responseText2 = await this.AddNewRecordWithMaxIdSaveRetrunId().then((jsonData) => {
                            });
                            if (returnBool == true) {
                                //添加成功后统计附件数量到论文表
                                const responseText3 = await this.AddAttachmentCount();
                                //添加主题论文关系 --添加时候需要添加，主题论文关系，修改时候，只是修改论文；
                                const responseText4 = await this.AddNewRecordSavePaperRela();
                                //添加记录的同时添加历史版本 判断只有原创论文才记录历史版本
                                const responseText6 = await this.AddVersionRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        //alert("添加历史版本出问题！");
                                    }
                                });
                                //添加论文日志；
                                const responseText7 = await this.Addgs_OriginalPaperLogSave().then((jsonData) => {
                                });
                                var strInfo = `添加记录成功!`;
                                alert(strInfo);
                                this.Clear();
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            var returnBool = true;
                            const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                            });
                            if (returnBool == true) {
                                //判断只有原创论文才记录历史版本
                                if (this.paperTypeId == "02") {
                                    const responseText6 = await this.AddVersionRecordSave().then((jsonData) => {
                                        var returnBool = jsonData;
                                        if (returnBool == true) {
                                            //alert("添加历史版本出问题！");
                                        }
                                    });
                                }
                                //修改成功后删除附件并添加新的附件
                                const responseText5 = await this.DelOldfileAddNewfile();
                                //修改成功后统计附件数量到论文表
                                const responseText6 = await this.AddAttachmentCount();
                                //判断是初稿、修改稿、终稿；
                                //添加论文日志；
                                const responseText7 = await this.Addgs_OriginalPaperLogSave();
                                var strInfo = `修改记录成功!`;
                                alert(strInfo);
                                this.Disabled_false();
                                this.Clear();
                            }
                            break;
                        default:
                            var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                            alert(strMsg);
                            break;
                    }
                    //取消提交按钮不可用状态
                    $("#divLoading").hide();
                    $("#btnOKUpd").attr("disabled", false);
                }
                catch (e) {
                    var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                    alert(strMsg);
                }
            }
            else {
                $("#btnOKUpd").attr("disabled", false);
                alert("用户session丢失，请重新登录！");
            }
        }
        ///////////////////////////////////////////////----------------------------------------------------添加主题论文关系
        /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSavePaperRela() {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strPaperId = $("#hidPaperId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objRTPaperRelaEN = new clsRTPaperRelaEN_js_1.clsRTPaperRelaEN();
            this.PutDataToRTPaperRelaClass(objRTPaperRelaEN);
            try {
                //// 同一主题 同一论文 只能添加一次；
                //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And paperId = '" + strPaperId + "'";
                //const responseText = await RTPaperRela_IsExistRecordAsync(strWhere);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `同一主题不能重复添加同一个论文！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsRTPaperRelaWApi_js_1.RTPaperRela_AddNewRecordAsync)(objRTPaperRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                }
                else {
                    var strInfo = `添加不成功!`;
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
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjRTPaperRelaEN">数据传输的目的类对象</param>
    */
        PutDataToRTPaperRelaClass(pobjRTPaperRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strPaperId = $("#hidPaperId").val();
            //$('#hidUserId').val(objvUserRoleRelation.userId);
            pobjRTPaperRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTPaperRelaEN.SetPaperId(strPaperId); // 论文Id
            pobjRTPaperRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTPaperRelaEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjRTPaperRelaEN.SetMemo(this.memo); // 备注
        }
        //添加论文流程日志
        async Addgs_OriginalPaperLogSave() {
            var objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN();
            this.PutDataTogs_OriginalPaperLog(objgs_OriginalPaperLogEN);
            try {
                const responseText2 = await (0, clsgs_OriginalPaperLogWApi_js_1.gs_OriginalPaperLog_AddNewRecordAsync)(objgs_OriginalPaperLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    console.log("添加新建论文日志成功");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加日志记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        async PutDataTogs_OriginalPaperLog(pobjgs_OriginalPaperLogEN) {
            var strPaperId = $("#hidPaperId").val();
            var strPaperLogTypeId = $('#PaperLogTypeId').val();
            pobjgs_OriginalPaperLogEN.SetPaperId(strPaperId);
            pobjgs_OriginalPaperLogEN.SetLogTypeId(strPaperLogTypeId);
            switch (strPaperLogTypeId) {
                case "01":
                    pobjgs_OriginalPaperLogEN.SetLogDescription("新建论文");
                    break;
                case "02":
                    pobjgs_OriginalPaperLogEN.SetLogDescription("收集子观点");
                    break;
                case "03":
                    pobjgs_OriginalPaperLogEN.SetLogDescription("论文初稿");
                    break;
                case "04":
                    pobjgs_OriginalPaperLogEN.SetLogDescription("小组讨论");
                    break;
                case "05":
                    pobjgs_OriginalPaperLogEN.SetLogDescription("论文修改稿");
                    break;
                case "06":
                    pobjgs_OriginalPaperLogEN.SetLogDescription("同伴建议");
                    break;
                case "07":
                    pobjgs_OriginalPaperLogEN.SetLogDescription("论文终稿");
                    break;
                default:
                    var strMsg = `没有数据处理！`;
                    alert(strMsg);
                    break;
            }
            //pobjgs_OriginalPaperLogEN.SetLogDescription( "新建论文";
            pobjgs_OriginalPaperLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            pobjgs_OriginalPaperLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate());
        }
        //添加历史版本
        async AddVersionRecordSave() {
            const strThisFuncName = this.AddVersionRecordSave.name;
            var strPaperId = $("#hidPaperId").val();
            var objgs_PaperEN = new clsgs_PaperVerEN_js_1.clsgs_PaperVerEN();
            objgs_PaperEN.SetPaperId(strPaperId);
            this.PutDataToPaperVerClass(objgs_PaperEN);
            try {
                const responseText2 = await (0, clsgs_PaperVerWApi_js_1.gs_PaperVer_AddNewRecordAsync)(objgs_PaperEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1=1 and paperId='" + strPaperId + "'";
                    var intVersionCount = await (0, clsgs_PaperVerWApi_js_1.gs_PaperVer_GetRecCountByCondAsync)(strWhereCond2);
                    if (intVersionCount > 0) {
                        var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                        objPaperEN.SetPaperId(strPaperId);
                        objPaperEN.SetVersionCount(intVersionCount);
                        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                            throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                        }
                        const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                return true;
                            }
                            else {
                                var strInfo = `添加历史版本数不成功!`;
                                alert(strInfo);
                                console.log("添加历史版本数不成功");
                                return false;
                            }
                        });
                    }
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
        //public async GetPaperDataByPaperId() {
        //}
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjPaperEN">数据传输的目的类对象</param>
       */
        async PutDataToPaperVerClass(pobjPaperEN) {
            var strPaperId = $("#hidPaperId").val();
            pobjPaperEN.SetPaperId(strPaperId); // 论文Id
            pobjPaperEN.SetPaperTitle(this.paperTitle); // 论文标题
            pobjPaperEN.SetPaperContent(this.paperContent); // 主题内容
            pobjPaperEN.SetPeriodical(this.periodical); // 期刊
            pobjPaperEN.SetAuthor(this.author); // 作者
            pobjPaperEN.SetResearchQuestion(this.researchQuestion); // 研究问题
            pobjPaperEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd()); // 修改日期
            pobjPaperEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            pobjPaperEN.SetMemo(this.memo); // 备注
            pobjPaperEN.SetKeyword(this.keyword); // 关键字
            pobjPaperEN.SetLiteratureSources(this.literatureSources); // 文献来源
            pobjPaperEN.SetLiteratureLink(this.literatureLink); // 文献链接
            pobjPaperEN.SetLiteratureTypeId(this.literatureTypeId); //文献类型
            pobjPaperEN.SetUploadfileUrl($("#hdnpic").val());
            pobjPaperEN.SetIsQuotethesis(this.isQuotethesis); // 是否引用论文
            pobjPaperEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjPaperEN.SetQuoteId(this.quoteId); // 引用Id
            pobjPaperEN.SetIsChecked(this.isChecked); // 是否检查
            pobjPaperEN.SetChecker(this.checker); // 审核人
            pobjPaperEN.SetPaperTypeId(this.paperTypeId); // 论文类型
            pobjPaperEN.SetPaperStatusId(this.paperStatusId); // 论文状态
        }
        //统计附件数量并添加到论文表
        async AddAttachmentCount() {
            const strThisFuncName = this.AddAttachmentCount.name;
            //添加记录的同时并记录论文的读写数
            var strPaperId = $("#hidPaperId").val();
            var strWhereCond2 = " 1=1 and paperId=" + strPaperId;
            var intAttachmentCount = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetRecCountByCondAsync)(strWhereCond2);
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(strPaperId);
            objPaperEN.SetAttachmentCount(intAttachmentCount);
            objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            const responseText = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
            var returnBool = !!responseText;
            if (returnBool == true) {
                (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                HideDialog();
                const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
                await objPage_Paper.Page_Load();
                //await objPage_Paper.BindGv_vPaper();
                $("#divLoading").hide();
                //显示信息框
                console.log("添加统计数量成功");
            }
            else {
                var strInfo = `添加统计数量不成功!`;
                alert(strInfo);
                console.log("添加统计数量不成功");
            }
        }
        /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
      */
        async AddNewRecordSave() {
            try {
                const responseText01 = await (0, clsPaperWApi_js_1.Paper_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表Paper的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtPaperId').val(returnString);
                        $('#hidPaperId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId($('#hidPaperId').val());
            const responseText02 = await this.PutDataToPaperClass(objPaperEN);
            try {
                const responseText03 = await (0, clsPaperWApi_js_1.Paper_IsExistAsync)(objPaperEN.paperId);
                var bolIsExist = responseText03;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objPaperEN.paperId}已经存在！`;
                    alert(strMsg);
                    return responseText03; //一定要有一个返回值，否则会出错！
                }
                var intPaperCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)("1=1 and paperTitle='" + this.paperTitle + "' and id_CurrEduCls ='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'");
                if (intPaperCount != 0) {
                    var strMsg = `添加记录时，当前教学班论文标题：${objPaperEN.paperTitle}已经存在，请重新命名！`;
                    alert(strMsg);
                    return false; //一定要有一个返回值，否则会出错！
                }
                const responseText05 = await (0, clsPaperWApi_js_1.Paper_AddNewRecordAsync)(objPaperEN);
                var returnBool = !!responseText05;
                if (returnBool == true) {
                    //判断是否有返回的附件路径值
                    if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        var fileOne = $("#hdnFileOne").val();
                        const responseText06 = await this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                        var returnBool2 = !!responseText06;
                        if (returnBool2 != true) {
                            var strInfo = `添加论文成功,但添加附件失败，请修改该条数据重新上传附件!`;
                            alert(strInfo);
                            return false;
                        }
                    }
                    else {
                        if ($("#hdnFileTwo").val() != "") {
                            var fileTwo = $("#hdnFileTwo").val();
                            const responseText07 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                        }
                        else {
                            if ($("#hdnFileThree").val() != "") {
                                var fileThree = $("#hdnFileThree").val();
                                const responseText08 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                            }
                        }
                    }
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText05; //一定要有一个返回值，否则会出错！
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
        //添加上传论文附件方法
        async AddNewRecordPaperAttachmentSave(filePath, strfileNum) {
            var objPaperAttachmentEN = new clsPaperAttachmentEN_js_1.clsPaperAttachmentEN();
            const responseText1 = await this.PutDataToPaperAttachmentClass(objPaperAttachmentEN, filePath);
            try {
                const responseText2 = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_AddNewRecordAsync)(objPaperAttachmentEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //第一个附件
                    if (strfileNum == "first") {
                        //如果第二个附件不等于空，那么执行添加函数；
                        if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                            var fileTwo = $("#hdnFileTwo").val();
                            const responseText3 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                        }
                        else {
                            //为空则判断第三个附件值；
                            if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                var fileThree = $("#hdnFileThree").val();
                                const responseText4 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                            }
                        }
                    }
                    else if (strfileNum == "two") {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            const responseText5 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
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
                return false;
            }
            //return true;//一定要有一个返回值，否则会出错！
        }
        async PutDataToPaperAttachmentClass(pobjPaperAttachmentEN, filePath) {
            pobjPaperAttachmentEN.SetPaperId($("#hidPaperId").val()); // 论文Id
            var strfilePath = filePath;
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjPaperAttachmentEN.SetFilePath(filePath);
            pobjPaperAttachmentEN.SetPaperAttachmentName(strfilePath);
            pobjPaperAttachmentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjPaperAttachmentEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
        }
        //论文类型下拉框事件
        ddlPaperTypeChange() {
            //判断下拉框是否有值，且值是否等于
            if (this.paperTypeId != "" && this.paperTypeId != "0") {
                if (this.paperTypeId == "01") {
                    //引用论文
                    $("#ddlPaperStatusId").attr("disabled", true);
                }
                else {
                    //原创论文
                    $("#ddlPaperStatusId").attr("disabled", false);
                }
            }
        }
        /* 修改记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
      */
        async btnUpdateRecord_Click(strKeyId) {
            var strLogId = $('#PaperLogTypeId').val();
            var strPaperTypeLogId = this.GetPapertypeLogId(strLogId);
            try {
                //通过Id查询是否存在此记录，不存在则提示不能进行此步骤操作；
                //收集子观点类型是02 ，那么就查询上一级步骤是否已经完成 所以需要 查询01；
                var strWhere = " 1=1 And logTypeId='" + strPaperTypeLogId + "'";
                const responseText = await (0, clsgs_OriginalPaperLogWApi_js_1.gs_OriginalPaperLog_GetFirstObjAsync)(strWhere).then((jsonData) => {
                    var objgs_OriginalPaperLog = jsonData;
                    if (objgs_OriginalPaperLog != null) {
                        this.opType = "Update";
                        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
                        if (strKeyId == "") {
                            alert("请选择需要修改的记录！");
                            return;
                        }
                        this.UpdateRecord1(strKeyId);
                    }
                    else {
                        //成员
                        var strMsg = `上一步骤未完成，不可使用此功能！`;
                        alert(strMsg);
                        return;
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `收集子观点方法不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(this.keyId);
            $("#hidPaperId").val(this.keyId);
            const responseText01 = await this.PutDataToPaperClass(objPaperEN);
            objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                var returnBool = true;
                const responseText02 = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                    returnBool = jsonData;
                });
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
        async DelOldfileAddNewfile() {
            try {
                ////得到相关论文附件地址，判断是否为空   ---------------注释，因为是自研论文，所以每一次的附件需要保存不删除；
                //if ($("#hdnFileOne").val() != "" || $("#hdnFileTwo").val() != "" || $("#hdnFileThree").val() != "") {
                //    //根据Id删除附件
                //    var strwhere = "paperId ='" + this.keyId + "'";
                //    const responseText1 = await this.DelRecordByWhere(strwhere);
                //}
                //不管是否有数据删除 都需要执行附件添加功能
                //判断是否有返回的附件路径值
                //判断是否有返回的附件路径值
                if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    var fileOne = $("#hdnFileOne").val();
                    const responseText2 = await this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                    var returnBool2 = !!responseText2;
                    if (returnBool2 != true) {
                        var strInfo = `修改记录成功,但添加附件失败，请修改该条数据重新上传附件!`;
                        alert(strInfo);
                        return "";
                    }
                }
                else {
                    if ($("#hdnFileTwo").val() != "") {
                        var fileTwo = $("#hdnFileTwo").val();
                        const responseText3 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                    }
                    else {
                        if ($("#hdnFileThree").val() != "") {
                            var fileThree = $("#hdnFileThree").val();
                            const responseText4 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                        }
                    }
                }
            }
            catch (e) {
                var strInfo = `修改记录不成功!`;
                $('#lblResult44').val(strInfo);
                //显示信息框
                alert(strInfo);
                console.log("完成UpdateRecordSave");
            }
        }
        /*
       根据关键字删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
      */
        async DelRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperAttachmentWApi_js_1.PaperAttachment_DelPaperAttachmentsByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                            console.log("删除附件成功,共删除" + returnInt + "条记录!");
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
        /* 根据关键字获取相应的记录的对象
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        <param name = "sender">参数列表</param>
      */
        async UpdateRecord1(strPaperId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.btnSubmit_gs_PaperVer = "确认修改";
            this.btnCancel_gs_PaperVer = "取消修改";
            this.keyId = strPaperId;
            try {
                const objPaperEN = await (0, clsPaperWApi_js_1.Paper_GetObjByPaperIdAsync)(strPaperId);
                if (objPaperEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                $("#btnOKUpd").show();
                $("#btnCancel").show();
                ShowDialog('Update');
                this.GetDataFromPaperClass(objPaperEN);
                $("#txtPaperTitle").attr("disabled", true);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        //public async GetPaperDataByPaperId() {
        //}
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjPaperEN">数据传输的目的类对象</param>
       */
        async PutDataToPaperClass(pobjPaperEN) {
            //pobjPaperEN.SetPaperId(this.paperId;// 论文Id
            pobjPaperEN.SetPaperTitle(this.paperTitle); // 论文标题
            pobjPaperEN.SetPaperContent(this.paperContent); // 主题内容
            pobjPaperEN.SetPeriodical(this.periodical); // 期刊
            pobjPaperEN.SetAuthor(this.author); // 作者
            pobjPaperEN.SetResearchQuestion(this.researchQuestion); // 研究问题
            pobjPaperEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd()); // 修改日期
            pobjPaperEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            pobjPaperEN.SetMemo(this.memo); // 备注
            pobjPaperEN.SetKeyword(this.keyword); // 关键字
            pobjPaperEN.SetLiteratureSources(this.literatureSources); // 文献来源
            pobjPaperEN.SetLiteratureLink(this.literatureLink); // 文献链接
            pobjPaperEN.SetLiteratureTypeId(this.literatureTypeId); //文献类型
            pobjPaperEN.SetUploadfileUrl($("#hdnpic").val());
            pobjPaperEN.SetIsQuotethesis(this.isQuotethesis); // 是否引用论文
            //pobjPaperEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls;
            pobjPaperEN.SetQuoteId(this.quoteId); // 引用Id
            pobjPaperEN.SetIsChecked(this.isChecked); // 是否检查
            pobjPaperEN.SetChecker(this.checker); // 审核人
            pobjPaperEN.SetPaperTypeId("02"); // 论文类型----默认自研论文，02；
            pobjPaperEN.SetPaperStatusId(this.paperStatusId); // 论文状态
            pobjPaperEN.SetIsPublic(false); //原创论文默认为false
        }
        /* 函数功能:把类对象的属性内容显示到界面上
       注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        如果在设置数据库时,就应该一级字段在前,二级字段在后
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        <param name = "pobjPaperEN">表实体类对象</param>
      */
        GetDataFromPaperClass(pobjPaperEN) {
            this.paperId = pobjPaperEN.paperId; // 论文Id
            this.paperTitle = pobjPaperEN.paperTitle; // 论文标题
            this.paperContent = pobjPaperEN.paperContent; // 主题内容
            this.periodical = pobjPaperEN.periodical; // 期刊
            this.author = pobjPaperEN.author; // 作者
            this.researchQuestion = pobjPaperEN.researchQuestion; // 研究问题
            this.updDate = pobjPaperEN.updDate; // 修改日期
            this.updUser = pobjPaperEN.updUser; // 修改用户Id
            this.memo = pobjPaperEN.memo; // 备注
            this.keyword = pobjPaperEN.keyword; // 关键字
            this.literatureSources = pobjPaperEN.literatureSources; // 文献来源
            this.literatureLink = pobjPaperEN.literatureLink; // 文献链接
            this.literatureTypeId = pobjPaperEN.literatureTypeId; //文献类型；
            $("#hdnpic").val(pobjPaperEN.uploadfileUrl);
            this.isQuotethesis = pobjPaperEN.isQuotethesis; // 是否引用论文
            this.quoteId = pobjPaperEN.quoteId; // 引用Id
            this.isChecked = pobjPaperEN.isChecked; // 是否检查
            this.checker = pobjPaperEN.checker; // 审核人
            this.paperTypeId = pobjPaperEN.paperTypeId; // 论文类型
            this.paperStatusId = pobjPaperEN.paperStatusId; // 论文状态
            setTextboxio();
            if (pobjPaperEN.isSubmit == true) {
                this.Disabled_true();
            }
            else {
                this.Disabled_false();
            }
            //if (pobjPaperEN.paperTypeId != "") {
            //    if (pobjPaperEN.paperTypeId == "02") {
            //        $("#ddlPaperTypeId").attr("disabled", true);
            //        $("#ddlPaperStatusId").attr("disabled", false); //原创论文可以修改 论文状态；
            //    }
            //    else {
            //        $("#ddlPaperTypeId").attr("disabled", true);
            //        $("#ddlPaperStatusId").attr("disabled", true);
            //    }
            //}
        }
        /*
      * 修改用户Id
     */
        set updUser(value) {
            $("#hidUserId").val(value);
        }
        /*
        * 修改用户Id
       */
        get updUser() {
            return clsPublocalStorage_js_1.clsPublocalStorage.userId;
        }
        //论文审核
        async btnAudit_Click(strKeyId) {
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要审核的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        //审核判断；
        async SubmitRecord(strPaperId) {
            this.keyId = strPaperId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_GetObjByPaperIdAsync)(strPaperId).then((jsonData) => {
                        var objPaperEN = jsonData;
                        //通过session 权限获取权限
                        //判断角色 //学生00620003
                        if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620003") {
                            // //通过判断数据用户是否是当前登录用户；
                            if (objPaperEN.updUser == clsPublocalStorage_js_1.clsPublocalStorage.userId) {
                                //判断数据是否已审核
                                if (objPaperEN.isChecked == false) {
                                    const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                        //var returnBool: boolean = jsonData;
                                        //if (returnBool == true) {
                                        //    HideDialog();
                                        //    this.BindGv_vPaperReadWrite();
                                        //}
                                    });
                                }
                                else {
                                    alert("当前数据已审核！");
                                    return;
                                }
                            }
                            else {
                                alert("当前数据不是您所添加，不能修改！");
                                return;
                            }
                        }
                        else {
                            //可以提交
                            //判断数据是否已提交
                            if (objPaperEN.isChecked == false) {
                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                });
                            }
                            else {
                                alert("当前数据已审核！");
                                return;
                            }
                        }
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 论文审核
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async SubmitRecordSave() {
            const strThisFuncName = this.SubmitRecordSave.name;
            //
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(this.keyId);
            //设置提交状态；
            objPaperEN.SetIsChecked(true);
            this.PutDataToPaperClassAudit(objPaperEN);
            objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const returnBool = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
                if (returnBool == true) {
                    var strInfo = `论文审核成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //刷新缓存
                    //vPaper_ReFreshThisCache();
                    HideDialog();
                    const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
                    await objPage_Paper.Page_Load();
                    //await objPage_Paper.BindGv_vPaper();
                }
                else {
                    var strInfo = `论文审核不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("审核失败");
                }
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
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
    */
        PutDataToPaperClassAudit(pobjPaperEN) {
            //pobjPaperReadWriteEN.SetPaperRWId(this.paperRWId;// 论文读写Id
            pobjPaperEN.SetIsChecked(true);
            pobjPaperEN.SetChecker(clsPublocalStorage_js_1.clsPublocalStorage.userId); //提交人；
        }
        /*
        * 主题内容
       */
        // public set paperContent(value: string) {
        //     $("#txtPaperContent").html(value);
        // }
        // /*
        // * 主题内容
        //*/
        // public get paperContent(): string {
        //     var editors = textboxio.get('#txtPaperContent');
        //     var editor = editors[0];
        //     return editor.content.get();
        //     return $("#txtPaperContent").html();
        // }
        ////绑定本专业
        //public async BindGv_vPaperMajor() {
        //    var strListDiv: string = this.mstrListDivMajor;
        //    var strWhereCond = await this.CombinevPaperCondition();
        //    //通过登录的用户得到用户专业
        //    var strid_XzMajor = clsPublocalStorage.id_XzMajor;
        //    //strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where id_XzMajor= '${strid_XzMajor}')`;
        //    strWhereCond += " and  id_XzMajor= '" + strid_XzMajor + "'";
        //    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //    var arrPaperExObjLst: Array<clsPaperENEx> = [];
        //    try {
        //        this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //        });
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: 20,
        //            whereCond: strWhereCond,
        //            orderBy: PaperCRUD.sortPaperBy,
        //            sortFun: (x, y) => { return 0; }
        //        };
        //        const responseObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrPaperExObjLst = <Array<clsPaperEN>>jsonData;
        //        });
        //        ////绑定方向论文
        //        //const gvResultDirection = await this.BindGv_vPaperDirection();
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    //if (arrPaperExObjLst.length == 0) {
        //    //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    //console.error(strMsg);
        //    //    alert(strMsg);
        //    //    return;
        //    //}
        //    try {
        //        const objPage_Paper = new Pub_PaperList();
        //        await objPage_Paper.BindTab_vPaper(strListDiv, arrPaperExObjLst);
        //        console.log("完成BindGv_vPaperMajor!");
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //绑定本方向
        //public async BindGv_vPaperDirection() {
        //    var strListDiv: string = this.mstrListDivDirection;
        //    var strWhereCond = await this.CombinevPaperCondition();
        //    //通过登录的用户得到用户专业
        //    var strid_XzMajor = clsPublocalStorage.id_XzMajor;
        //    strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId in (select majorDirectionId from XzMajorDirection where id_XzMajor= '${strid_XzMajor}'))`;
        //    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //    var arrPaperExObjLst: Array<clsPaperENEx> = [];
        //    try {
        //        this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //        });
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: 20,
        //            whereCond: strWhereCond,
        //            orderBy: PaperCRUD.sortPaperBy,
        //            sortFun: (x, y) => { return 0; }
        //        };
        //        const responseObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrPaperExObjLst = <Array<clsPaperEN>>jsonData;
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    //if (arrPaperExObjLst.length == 0) {
        //    //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    //console.error(strMsg);
        //    //    alert(strMsg);
        //    //    return;
        //    //}
        //    try {
        //        this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
        //        console.log("完成BindGv_vPaperDirection!");
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //public async btnMajorDirection_Click() {
        //    const responseObjList = await this.BindGv_vXzMajorDirection();
        //}
        //  /* 根据条件获取相应的记录对象的列表
        // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
        //*/
        //  public async btnQueryMajorDirection_Click() {
        //      var strWhereCond = await this.CombinevXzMajorDirectionCondition();
        //      try {
        //          this.recCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //          });
        //          var objPagerPara: stuPagerPara = {
        //              pageIndex: 1,
        //              pageSize: this.pageSize,
        //              whereCond: strWhereCond,
        //              orderBy: this.hidSortvXzMajorDirectionBy
        //          };
        //          const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //              var arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN> = <Array<clsvXzMajorDirectionEN>>jsonData;
        //              this.BindTab_vXzMajorDirection(this.mstrListDivMajorDirection, arrvXzMajorDirectionObjLst);
        //          });
        //      }
        //      catch (e) {
        //          console.error('catch(e)=');
        //          console.error(e);
        //          var strMsg: string = `获取记录列表不成功,${e}.`;
        //          alert(strMsg);
        //      }
        //  }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        //public async BindGv_vXzMajorDirection() {
        //    var strListDiv: string = this.mstrListDivMajorDirection;
        //    var strWhereCond = await this.CombinevXzMajorDirectionCondition();
        //    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //    var arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN> = [];
        //    try {
        //        this.recCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //        });
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: this.pageSize,
        //            whereCond: strWhereCond,
        //            orderBy: this.hidSortvXzMajorDirectionBy
        //        };
        //        const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrvXzMajorDirectionObjLst = <Array<clsvXzMajorDirectionEN>>jsonData;
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    try {
        //        this.BindTab_vXzMajorDirection(strListDiv, arrvXzMajorDirectionObjLst);
        //        console.log("完成BindGv_vXzMajorDirection!");
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //    /* 把所有的查询控件内容组合成一个条件串
        //(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        // <returns>条件串(strWhereCond)</returns>
        //*/
        //    public CombinevXzMajorDirectionCondition(): string {
        //        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //        //例如 1 = 1 && userName = '张三'
        //        var strPaperId = $("#hidPaperId").val();//论文
        //        var strWhereCond: string = " 1 = 1 ";
        //        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //        try {
        //            if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
        //                strWhereCond += ` And ${clsvXzMajorDirectionEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
        //            }
        //            if (this.majorDirectionName_q != "") {
        //                strWhereCond += ` And ${clsvXzMajorDirectionEN.con_MajorDirectionName} like '% ${this.majorDirectionName_q}%'`;
        //            }
        //            strWhereCond += ` And  majorDirectionId not in (select majorDirectionId from MajorDirectionPaperRela where  paperId = '${strPaperId}')`;
        //        }
        //        catch (objException) {
        //            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineXzMajorDirectionCondition)时出错!请联系管理员!${objException}`;
        //            throw strMsg;
        //        }
        //        return strWhereCond;
        //    }
        //用来选择专业记录方法；
        btnOkInTab_Click(strKeyId) {
            $('#hidMajorDirectionId').val(strKeyId); //专业方向
            this.AddNewRecordSaveMajorDirection();
        }
        /* 添加新记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        */
        async AddNewRecordSaveMajorDirection() {
            var strMajorDirectionId = $('#hidMajorDirectionId').val(); //专业方向
            var strPaperId = $("#hidPaperId").val(); //论文
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objMajorDirectionPaperRelaEN = new clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN();
            this.PutDataToMajorDirectionPaperRelaClass(objMajorDirectionPaperRelaEN);
            try {
                //同一论文不能重复添加同一个专业方向；
                var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And majorDirectionId = '" + strMajorDirectionId + "'";
                const responseText = await (0, clsMajorDirectionPaperRelaWApi_js_1.MajorDirectionPaperRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一论文不能重复添加同一个专业方向！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsMajorDirectionPaperRelaWApi_js_1.MajorDirectionPaperRela_AddNewRecordAsync)(objMajorDirectionPaperRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    HideDialogOne();
                    //window.location.href = "../GraduateEduEx/PaperCRUD?paperTypeId=01";
                    window.location.href = "../GraduateEdu/PaperAddXzmajorRela?paperId=" + strPaperId;
                }
                else {
                    var strInfo = `添加记录不成功!`;
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
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjMajorDirectionPaperRelaEN">数据传输的目的类对象</param>
      */
        PutDataToMajorDirectionPaperRelaClass(pobjMajorDirectionPaperRelaEN) {
            var strMajorDirectionId = $("#hidMajorDirectionId").val();
            //var strViewpointId = $("#hidPaperId").val();
            //var strUserId = clsPublocalStorage.userId;
            pobjMajorDirectionPaperRelaEN.SetMajorDirectionId(strMajorDirectionId); // 研究方向Id
            pobjMajorDirectionPaperRelaEN.SetPaperId($("#hidPaperId").val()); // 论文Id
            pobjMajorDirectionPaperRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjMajorDirectionPaperRelaEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjMajorDirectionPaperRelaEN.SetMemo(this.memo); // 备注
        }
        ///* 函数功能:在数据 列表中跳转到某一页
        //   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
        //   <param name = "intPageIndex">页序号</param>
        // */
        //public IndexPageOne(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.pageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //    this.BindGv_vXzMajorDirection();
        //}
        //论文提交
        async btnIsSubmit_Click(strKeyId) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            try {
                this.IsSubmitRecordSave(strKeyId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*提交论文
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async IsSubmitRecordSave(strKeyId) {
            const strThisFuncName = this.IsSubmitRecordSave.name;
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            //
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(strKeyId);
            objPaperEN.SetIsSubmit(true);
            //objPaperEN..submitter = clsPublocalStorage.userId;//提交人；
            objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const returnBool = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
                if (returnBool == true) {
                    var strInfo = `提交成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //刷新缓存
                    (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(strid_CurrEducls);
                    HideDialog();
                    const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
                    await objPage_Paper.Page_Load();
                    //await objPage_Paper.BindGv_vPaper();
                }
                else {
                    var strInfo = `提交不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("取消失败");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `提交不成功,${e}.`;
                alert(strMsg);
            }
        }
        //取消论文提交
        async btnCancelSubmit_Click(strKeyId) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            try {
                this.CancelSubmitRecordSave(strKeyId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*取消提交论文
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async CancelSubmitRecordSave(strKeyId) {
            const strThisFuncName = this.CancelSubmitRecordSave.name;
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            //
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(strKeyId);
            objPaperEN.SetIsSubmit(false);
            //objPaperEN..submitter = clsPublocalStorage.userId;//提交人；
            objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const returnBool = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
                if (returnBool == true) {
                    var strInfo = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //刷新缓存
                    (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(strid_CurrEducls);
                    HideDialog();
                    const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
                    await objPage_Paper.Page_Load();
                    //await objPage_Paper.BindGv_vPaper();
                }
                else {
                    var strInfo = `取消不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("取消失败");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `取消记录不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
       * 设置排序字段-相当使用ViewState功能
      */
        set hidSortvXzMajorDirectionBy(value) {
            $("#hidSortvXzMajorDirectionBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvXzMajorDirectionBy() {
            return $("#hidSortvXzMajorDirectionBy").val();
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
     * 论文类型查询
     */
        set PaperTypeId_q(value) {
            $("#ddlPaperTypeId_q").val(value);
        }
        /*
        * 论文类型查询
        */
        get PaperTypeId_q() {
            return $("#ddlPaperTypeId_q").val();
        }
        /*
         * 论文类型
         */
        set paperTypeId(value) {
            $("#ddlPaperTypeId").val(value);
        }
        /*
        * 论文类型
        */
        get paperTypeId() {
            return $("#ddlPaperTypeId").val();
        }
        /*
     * 论文状态
     */
        set paperStatusId(value) {
            $("#ddlPaperStatusId").val(value);
        }
        /*
        * 论文状态
        */
        get paperStatusId() {
            return $("#ddlPaperStatusId").val();
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.paperId = "";
            this.paperTitle = "";
            this.paperContent = "";
            this.periodical = "";
            this.author = "";
            this.researchQuestion = "";
            this.updDate = "";
            this.updUser = "";
            this.memo = "";
            this.keyword = "";
            this.literatureSources = "";
            this.literatureLink = "";
            this.uploadfileUrl = "";
            this.isQuotethesis = false;
            this.quoteId = "";
            this.isChecked = false;
            this.checker = "";
            $('#ddlLiteratureTypeId option[0]').attr("selected", true);
            this.Uploadfile = "";
            $("#hdnFileOne").val("");
            $("#hdnFileTwo").val("");
            $("#hdnFileThree").val("");
            $('#ddlPaperTypeId option[0]').attr("selected", true);
            $('#ddlPaperStatusId option[0]').attr("selected", true);
        }
        //屏蔽控件
        Disabled_true() {
            $("#txtPaperTitle").attr("disabled", true);
            $("#txtPaperContent").attr("disabled", true);
            $("#txtPeriodical").attr("disabled", true);
            $("#txtAuthor").attr("disabled", true);
            $("#txtResearchQuestion").attr("disabled", true);
            $("#txtKeyword").attr("disabled", true);
            $("#ddlLiteratureTypeId").attr("disabled", true);
            $("#txtLiteratureSources").attr("disabled", true);
            $("#txtLiteratureLink").attr("disabled", true);
            $("#txtLiteratureLink").attr("disabled", true);
            $("#txtLiteratureLink").attr("disabled", true);
            $("#ddlPaperTypeId").attr("disabled", true);
            $("#ddlPaperStatusId").attr("disabled", true);
        }
        //开放控件
        Disabled_false() {
            $("#txtPaperTitle").attr("disabled", false);
            $("#txtPaperContent").attr("disabled", false);
            $("#txtPeriodical").attr("disabled", false);
            $("#txtAuthor").attr("disabled", false);
            $("#txtResearchQuestion").attr("disabled", false);
            $("#txtKeyword").attr("disabled", false);
            $("#ddlLiteratureTypeId").attr("disabled", false);
            $("#ddlPaperTypeId").attr("disabled", false);
            $("#ddlPaperStatusId").attr("disabled", true);
            $("#txtLiteratureSources").attr("disabled", false);
            $("#txtLiteratureLink").attr("disabled", false);
            $("#txtLiteratureLink").attr("disabled", false);
            $("#txtLiteratureLink").attr("disabled", false);
        }
        /*
       * 专业流水号
      */
        get id_XzMajor_q() {
            return $("#ddlid_XzMajor_q").val();
        }
        /*
        * 研究方向名
       */
        get majorDirectionName_q() {
            return $("#txtMajorDirectionName_q").val();
        }
        /*
    * 用户
    */
        //public get readUser_q(): string {
        //    return $("#txtReadUser_q").val();
        //}
        get User_q() {
            return $("#ddlUserId_q").val();
        }
    }
    exports.gs_PaperEx = gs_PaperEx;
});
