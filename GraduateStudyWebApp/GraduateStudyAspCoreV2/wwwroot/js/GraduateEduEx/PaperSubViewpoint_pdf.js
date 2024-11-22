(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPaper/PaperSubViewpoint_EditEx.js", "../PagesBase/GraduateEduPaper/PaperSubViewpointCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js", "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js", "../TS/L0_Entity/InteractManage/clsSysVoteEN.js", "../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js", "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSubViewpointExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperSubViewpoint_pdf = void 0;
    const PaperSubViewpoint_EditEx_js_1 = require("../GraduateEduPaper/PaperSubViewpoint_EditEx.js");
    const PaperSubViewpointCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperSubViewpointCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperDownloadLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsPaperENEx_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js");
    const clsPaperSubAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js");
    const clsPaperSubViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js");
    const clsSectionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js");
    const clsvPaperSubViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js");
    const clsSysVoteEN_js_1 = require("../TS/L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsExplainTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js");
    const clsSubViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperDownloadLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js");
    const clsPaperSubAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js");
    const clsPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsSectionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsExplainTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js");
    const clsSubViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsvPaperSubViewpointExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSubViewpointExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PaperSubViewpoint_pdf extends PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 50;
        }
        BindGv(strType, strPara) {
            this.BindGv_vPaperSubViewpoint();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vPaperSubViewpoint":
                    alert('该类没有绑定该函数：[this.BindGv_vPaperSubViewpoint_Cache]！');
                    //this.BindGv_vPaperSubViewpoint_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /**
        * 按钮单击,用于调用Js函数中btn_Click
        * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        **/
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.objPage_CRUD == null) {
                PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.objPage_CRUD = new PaperSubViewpoint_pdf();
                objPage = PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.objPage_CRUD;
            }
            else {
                objPage = PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.objPage_CRUD;
            }
            const objPage_Edit = new PaperSubViewpoint_EditEx_js_1.PaperSubViewpoint_EditEx(objPage);
            let strMsg = '';
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
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
                case "Create": //添加记录
                    objPage_Edit.divName4Edit = "divEditRegion";
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                case "UpdateRecordInTab": //修改记录InTab
                    strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        const strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (strCommandName == "UpdateRecordInTab") {
                        objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    }
                    else {
                        objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    }
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "ExportExcel": //导出Excel
                    //objPage.btnExportExcel_Click();
                    //alert("导出Excel功能还没有开通！");
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
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
                default:
                    strMsg = '命令:' + strCommandName + "在函数(PaperSubViewpoint_pdf.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    $("#hidRoleId").val(clsPublocalStorage_js_1.clsPublocalStorage.roleId);
                    //1、为下拉框设置数据源,绑定列表数据
                    if ($('#hidid_CurrEduCls').val() == "") {
                        $('#hidid_CurrEduCls').val(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                    }
                    var strPaperId = $("#hidPaperId").val();
                    const ddl_SectionId_q = await this.BindDdl_SectionId("ddlSectionId_q", strPaperId);
                    const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId", strPaperId);
                    const ddl_SubViewpointTypeId_q = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId_q");
                    //const ddl_ExplainTypeId_q = await this.BindDdl_ExplainTypeId("ddlExplainTypeId_q");
                    const ddl_SubViewpointTypeId = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId");
                    const ddl_ExplainTypeId = await this.BindDdl_ExplainTypeId("ddlExplainTypeId");
                    PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.sortvPaperSubViewpointBy = "subViewpointTypeName Asc";
                    var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                    //判断角色
                    //学生
                    if (strRoleId == "00620003") {
                        if (clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId != "") {
                            $("#liTeaTest_QA").show();
                        }
                        else {
                            $("#liTeaTest_QA").hide();
                        }
                    }
                    else {
                        $("#liTeaTest_QA").show();
                    }
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //绑定pdf_Ifame
                    const gvResult1 = await this.BindPdf();
                    const gvResult2 = await this.li_PaperMenu_Click();
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
        async li_PaperMenu_Click() {
            //如果是点击了树菜单、或者是刷新，那么需要做样式控制；
            //首先要去掉ul下 li a 样式
            $("#tabMenu li a").removeClass();
            $("#tabMenu li a").addClass("nav-link");
            $("#Paper_SubViewpoint").removeClass();
            $("#Paper_QA").removeClass();
            $("#Paper_Tags").removeClass();
            $("#Tea_QA").removeClass();
            $("#Paper_SubViewpoint").addClass("tab-pane fade");
            $("#Paper_QA").addClass("tab-pane fade");
            $("#Paper_Tags").addClass("tab-pane fade");
            $("#Tea_QA").addClass("tab-pane fade");
            //判断根据序号显示不同的数据源
            var strnum = $("#hidTabNum").val();
            if (strnum == "1") {
                //$("#liUser").addClass("active");
                $("#liPaper_SubViewpoint a").addClass("active");
                $("#Paper_SubViewpoint").addClass("active show");
                //主题用户关系；
                //论文摘要
                const gvResult1 = await this.Bind_PaperContent();
                //绑定论文子观点
                const gvResult2 = await this.BindGv_vPaperSubViewpoint();
            }
            else if (strnum == "2") {
                $("#liPaper_QA a").addClass("active");
                $("#Paper_QA").addClass("active show");
                $("#iframe_qaPdf").contents().find("#hidIsQA_Tags").val(1);
                //主题论文关系；
                const gvResult = await this.Bind_Paper_QA();
            }
            else if (strnum == "3") {
                $("#liPaper_Tags a").addClass("active");
                $("#Paper_Tags").addClass("active show");
                $("#iframe_qaPdf").contents().find("#hidIsQA_Tags").val(2);
                //主题论文关系；
                const gvResult = await this.Bind_Paper_Tags();
            }
            else if (strnum == "4") {
                $("#liTea_QA a").addClass("active");
                $("#Tea_QA").addClass("active show");
                //主题论文关系；
                const gvResult = await this.Bind_Tea_QA();
            }
            else if (strnum == "5") {
                $("#liTeaTest_QA a").addClass("active");
                $("#TeaTest_QA").addClass("active show");
                //主题论文关系；
                const gvResult = await this.Bind_TeaTest_QA();
            }
            else {
                const gvResult = await this.Bind_PaperContent();
            }
        }
        //绑定pdf_Ifame
        async BindPdf() {
            try {
                //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
                var strPaperId = $("#hidPaperId").val();
                var objPaperAttachment;
                var strWhereCond = " 1=1 and paperId ='" + strPaperId + "'";
                const responseText = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetFirstObjAsync)(strWhereCond);
                objPaperAttachment = responseText;
                var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                var strhtml = "";
                if (objPaperAttachment != null) {
                    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                    strhtml = "<iframe id='iframe_qaPdf' scrolling='auto' src='../GraduateEduEx/qaPdf?zoom=1.1&file=" + strfilepath + "' style=\"height:100%;width:100%; height:730px;\"></iframe>";
                }
                else {
                    strhtml = "<iframe id='iframe_qaPdf' scrolling='auto' src='../GraduateEduEx/qaPdf?zoom=1.1' style=\"height:100%;width:100%; height:730px;\"></iframe>";
                }
                $("#leftPart").html(strhtml);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定Paper_QA
        async Bind_Paper_QA() {
            try {
                var strPaperId = $("#hidPaperId").val();
                var strQuestionsId = $("#hidQuestionsId").val();
                var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
                var strPushId = $("#hidPushId").val();
                var varLink = "";
                if (strQuestionsId != "") {
                    if (strPushId != "") {
                        varLink = '../InteractManage/Paper_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&questionsId=' + strQuestionsId + '&pushId=' + strPushId;
                    }
                    else {
                        varLink = '../InteractManage/Paper_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&questionsId=' + strQuestionsId;
                    }
                }
                else {
                    varLink = '../InteractManage/Paper_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls;
                }
                //var strhtml = "<iframe id='iframe_Paper_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='../InteractManage/Paper_QA?paperId=" + strPaperId + "' style='height:100%;width:99%; min-height:650px;'></iframe>";
                var strhtml = "<iframe id='iframe_Paper_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='" + varLink + "' style='height:100%;width:100%; height:730px;'></iframe>";
                $("#Paper_QA").html(strhtml);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定Paper_Tags
        async Bind_Paper_Tags() {
            try {
                var strPaperId = $("#hidPaperId").val();
                var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
                var strhtml = "<iframe id='iframe_Paper_Tags'  frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes'  src='../InteractManage/Paper_Tags?paperId=" + strPaperId + "&id_CurrEduCls=" + strid_CurrEduCls + "' style='height:100%;width:100%; height:730px;'></iframe>";
                $("#Paper_Tags").html(strhtml);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定Tea_QA
        async Bind_Tea_QA() {
            try {
                var strPaperId = $("#hidPaperId").val();
                var strQuestionsId = $("#hidQuestionsId").val();
                var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                var varLink = "";
                if (strQuestionsId != "") {
                    varLink = '../InteractManage/Tea_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&questionsId=' + strQuestionsId;
                }
                else {
                    if (strTopicId != "") {
                        varLink = '../InteractManage/Tea_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&topicId=' + strTopicId;
                    }
                    else {
                        varLink = '../InteractManage/Tea_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls;
                    }
                }
                //var strhtml = "<iframe id='iframe_Tea_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='../InteractManage/Paper_QA?paperId=" + strPaperId + "' style='height:100%;width:99%; min-height:650px;'></iframe>";
                var strhtml = "<iframe id='iframe_Tea_QA' frameborder='no' border='0' scrolling='auto' src='" + varLink + "' style='width:100%; height:730px;'></iframe>";
                $("#Tea_QA").html(strhtml);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定Bind_TeaTest_QA
        async Bind_TeaTest_QA() {
            try {
                var strPaperId = $("#hidPaperId").val();
                var strQuestionsId = $("#hidQuestionsId").val();
                var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                var varLink = "";
                if (strQuestionsId != "") {
                    varLink = '../InteractManage/TeaTest_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&questionsId=' + strQuestionsId;
                }
                else {
                    if (strTopicId != "") {
                        varLink = '../InteractManage/TeaTest_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&topicId=' + strTopicId;
                    }
                    else {
                        varLink = '../InteractManage/TeaTest_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls;
                    }
                }
                //var strhtml = "<iframe id='iframe_Tea_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='../InteractManage/Paper_QA?paperId=" + strPaperId + "' style='height:100%;width:99%; min-height:650px;'></iframe>";
                var strhtml = "<iframe id='iframe_TeaTest_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='" + varLink + "' style='height:100%;width:100%; min-height:700px;'></iframe>";
                $("#TeaTest_QA").html(strhtml);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
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
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlSubViewpointTypeId, arrSubViewpointTypeObjLst, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName, "子观点类型");
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
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlExplainTypeId, arrExplainTypeObjLst, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName, "说明类型");
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
        async Bind_PaperContent() {
            const strThisFuncName = this.Bind_PaperContent.name;
            //var strWhereCond = " paperId = " + strPaperId;
            //var objvPaperReadWrite: clsvPaperReadWriteEN = new clsvPaperReadWriteEN;
            //const responseObjLst = await vPaperReadWrite_GetFirstObjAsync(strWhereCond).then((jsonData) => {
            //    objvPaperReadWrite = <clsvPaperReadWriteEN>jsonData;
            //});
            var strPaperId = $("#hidPaperId").val();
            var objvPaper_Cond = new clsPaperEN_js_1.clsPaperEN(); //查询区域
            //var objvPaper: clsPaperEN = null;
            //objvPaper_Cond.SetCondFldValue(clsPaperEN.con_PaperId, strPaperId, "=");
            //var objvPaper: clsPaperEN = await vPaper_GetObjByPaperId_Cache(strPaperId, strid_CurrEducls);
            const objPaperEN = await (0, clsPaperWApi_js_1.Paper_GetFirstObjAsync)("paperId='" + strPaperId + "'");
            if (objPaperEN == null) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const objPaperENEx = (0, clsPaperExWApi_js_1.PaperEx_CopyToEx)(objPaperEN);
            (0, clsPaperExWApi_js_1.PaperEx_FuncMapByFldName)(clsPaperENEx_js_1.clsPaperENEx.con_UpdUserName, objPaperENEx);
            (0, clsPaperExWApi_js_1.PaperEx_FuncMapByFldName)(clsPaperENEx_js_1.clsPaperENEx.con_PaperTypeName, objPaperENEx);
            var strhtml = "";
            try {
                var strTitle = objPaperENEx.paperTitle + '(作者:' + objPaperENEx.author + '-提交者:' + objPaperENEx.updUserName + ')';
                $("#spanPaperContent").html(strTitle);
                var strhtml = "";
                //for (var i = 0; i < arrPaperExObjLst.length; i++) {
                strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                if (objPaperENEx.paperTypeId == "02") {
                    strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + objPaperENEx.paperId + '">' + objPaperENEx.paperTitle + '(' + objPaperENEx.paperTypeName + ')</a></h6>';
                }
                else {
                    //自研论文
                    strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + objPaperENEx.paperId + '">' + objPaperENEx.paperTitle + '</a></h6>';
                }
                strhtml += '<div class="baseinfo"><span><a href="#">' + objPaperENEx.author + '</a></span><span><a href="#">' + objPaperENEx.literatureSources + '</a></span>';
                strhtml += '<span>' + objPaperENEx.periodical + '</span><em>' + objPaperENEx.keyword + '</em></div>';
                strhtml += '<div class="abstract">' + objPaperENEx.paperContent + '</div>';
                strhtml += '<div class="opts"><ul class="opts-count">';
                //var objUser = arrUsers.find(x => x.userId == objvPaper.updUser);
                //if (objUser != null) {
                //    strhtml += '<li>论文读写者:<em>' + objUser.userName + '</em></li>';
                //}
                strhtml += '<li>论文提交者:<em>' + objPaperENEx.updUserName + '</em></li>';
                //strhtml += '<li>观点数:<em>' + pobjvPaperReadWriteEN.subVCount + '</em></li><li>教师分:<em>' + pobjvPaperReadWriteEN.teaCount + '</em></li>';
                strhtml += '<ul class="opts-btn">';
                if (objPaperENEx.attachmentCount > 0) {
                    strhtml += '<li>' + objPaperENEx.downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click()><i></i><b>点击下载</b></a></li>';
                }
                else {
                    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                }
                strhtml += '</ul></div>';
                strhtml += '</dd></dl></div>';
                //}
                $("#tabwucPaperReadWrite").html(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
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
                            await this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            //为空则判断第三个附件值；
                            if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                var fileThree = $("#hdnFileThree").val();
                                await this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                            }
                        }
                    }
                    else if (strfileNum == "two") {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            await this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
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
            pobjPaperSubAttachmentEN.SetSubViewpointId($("#hidKeyId").val()); // 论文Id
            var strfilePath = filePath;
            //判断地址不为空则执行截取操作
            if (strfilePath != "") {
                var index = strfilePath.lastIndexOf("\/");
                strfilePath = strfilePath.substring(index + 1, strfilePath.length);
                pobjPaperSubAttachmentEN.SetFilePath(filePath);
                pobjPaperSubAttachmentEN.SetPaperSubAttachmentName(strfilePath);
            }
            pobjPaperSubAttachmentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjPaperSubAttachmentEN.Setid_CurrEduCls($("#hidid_CurrEduCls").val()); //教学班
            pobjPaperSubAttachmentEN.SetPaperRWId($("#hidPaperRWId").val()); //读写Id
            pobjPaperSubAttachmentEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
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
        //同步子观点到论文表
        async SynSubV() {
            const strThisFuncName = this.SynSubV.name;
            var strPaperId = $("#hidPaperId").val();
            //添加记录的同时并记录论文读写的教师评价数
            var strWhereCond = " paperId=" + strPaperId;
            var intSubVCount = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetRecCountByCondAsync)(strWhereCond);
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(strPaperId);
            objPaperEN.SetSubVCount(intSubVCount);
            objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            const responseText = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
            var returnBool = !!responseText;
            if (returnBool == true) {
                console.log("统计论文子观点数量成功！");
                //刷新缓存
                (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)($("#hidid_CurrEduCls").val());
            }
            else {
                console.log("统计论文子观点数量失败！");
            }
            //添加记录的同时并记录论文读写的教师评价数
            //添加成功后把数据同步到总表
            var strSubViewpointId = $('#hidKeyId').val();
            const responseText2 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSubViewpointId, "03", "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            var returnBool2 = !!responseText2;
            if (returnBool2 == true) {
                console.log("论文子观点数据总表同步成功；");
            }
            else {
                console.log("论文子观点数据总表同步失败；");
            }
        }
        CombinevPaperSubViewpointCondition2() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.subViewpointTypeId_q != "" && this.subViewpointTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.subViewpointTypeId_q}'`;
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
            //var strPaperRWId = $("#hidPaperRWId").val();
            var strPaperId = $("#hidPaperId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.sectionId_q != "" && this.sectionId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId} = '${this.sectionId_q}'`;
                }
                //if (strPaperRWId != "") {
                //    strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
                //}
                if (strPaperId != "") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperId} = '${strPaperId}'`;
                }
                if (this.subViewpointTypeId_q != "" && this.subViewpointTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.subViewpointTypeId_q}'`;
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strRoleId == "00620001") {
                    //$("#btnDelRecord").show();
                }
                else if (strRoleId == "00620002") {
                    //可以查看所有；
                }
                else {
                    if ($("#hidType").val() == "01") {
                        strWhereCond += " And updUser = '" + strUserId + "'";
                    }
                    //学生00620003
                    //只能查看自己的数据；或公开的数据；
                    //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                    //strWhereCond += ` And updUser = '${objvUserRoleRelation.userId}'`;
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
            //var strPaperRWId = $("#hidPaperRWId").val();
            var strPaperId = $("#hidPaperId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.sectionId_q != "" && this.sectionId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId} = '${this.sectionId_q}'`;
                }
                //if (strPaperRWId != "") {
                //    strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
                //}
                if (strPaperId != "") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperId} = '${strPaperId}'`;
                }
                if ($("#hidType").val() == "01") {
                    strWhereCond += " And updUser = '" + strUserId + "'";
                }
                strWhereCond += " order by orderNum Asc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //public CombinevPaperSubViewpointCondition5(): string {
        //    //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //    //例如 1 = 1 && userName = '张三'
        //    var strWhereCond: string = " 1 = 1 ";
        //    return strWhereCond;
        //}
        async BindGv_vPaperSubViewpoint() {
            //var strListDiv: string = this.mstrListDiv;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var strPaperRWId = $("#hidPaperRWId").val();
            var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
            var strWhereCond2 = this.CombinevPaperSubViewpointCondition3();
            var strWhereCond3 = this.CombinevPaperSubViewpointCondition3();
            if ($("#hidSortPsv").val() == 1) {
                strWhereCond3 += " order by paperPageNum Asc";
            }
            else {
                strWhereCond3 += " order by updDate Desc";
            }
            //strWhereCond3 += this.CombinevPaperSubViewpointCondition3();
            var strWhereCond4 = this.CombinevPaperSubViewpointCondition4();
            var strWhereCond5 = " 1=1 and id_CurrEduCls='" + strid_CurrEduCls + "'";
            //var strWhereCond6 = ` ${clsvSysVoteEN.con_TableKey} = '${strPaperRWId}' And ${clsvSysVoteEN.con_UpdUser} = '${strUserId}'`;
            //var strWhereCond6 = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='02' and pubParentId='" + strPaperRWId + "'";
            var strWhereCond6 = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='02' ";
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrSectionObjLst = [];
            //var arrSubViewpointTypeObjLst: Array<clsSubViewpointTypeEN> = [];
            var arrvPaperSubVTypeNumObjLst = [];
            var arrvPaperSubViewpointObjLst = [];
            var arrvPaperSubViewpointObjLst2 = [];
            //获取图片
            var arrPaperSubAttachmentObjLst = [];
            var arrPaperSubAttachmentObjLst2 = [];
            //获取点赞数据
            var arrSysVoteObjLst = [];
            try {
                //const responseText1 = Section_GetObjLstAsync(strWhereCond4).then((jsonData) => {
                //    arrSectionObjLst = <Array<clsSectionEN>>jsonData;
                //});
                const responseText2 = (0, clsvPaperSubViewpointExWApi_js_1.vPaperSubViewpointEx_GetSubViewpointTypeNumObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvPaperSubVTypeNumObjLst = jsonData;
                });
                const responseObjLst3 = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstAsync)(strWhereCond3).then((jsonData) => {
                    arrvPaperSubViewpointObjLst2 = jsonData;
                });
                const responseRecCount4 = await (0, clsPaperSubAttachmentWApi_js_1.PaperSubAttachment_GetObjLstAsync)(strWhereCond5).then((jsonData) => {
                    arrPaperSubAttachmentObjLst2 = jsonData;
                });
                //const responseRecCount6 = await vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond6).then((jsonData) => {
                //    arrvPaperSubViewpointLikeLogObjLst = <Array<clsvPaperSubViewpointLikeLogEN>>jsonData;
                //});
                //const responseRecCount7 = await vSysVote_GetObjLstAsync(strWhereCond6).then((jsonData) => {
                //    arrvPaperSubViewpointLikeLogObjLst = <Array<clsvSysVoteEN>>jsonData;
                //});
                const responseText = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLstAsync)(strWhereCond6).then((jsonData) => {
                    arrSysVoteObjLst = jsonData;
                });
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                var intJ = 0;
                //$('#tbList tr').remove();
                //for (var j = 0; j < arrSubViewpointTypeObjLst.length; j++) {
                //    cateid++;
                //    intJ++;
                var fid = 0;
                //    var strsubTypeId: string = arrSubViewpointTypeObjLst[j].subViewpointTypeId;
                //先创建子模块类型
                //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';
                //strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>';
                ////strhtml += '<div style="float:left;"><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></div>';
                //strhtml += '<div style="float:left;"><h3>论文子观点</h3></div>';
                //strhtml += '<div style="float:right;">';
                //if ($("#hidType").val() == "01") {
                //    //if ($("#hidIsSubmit").val() != "true") {
                //    //strhtml += '<button title="添加子观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '");><i class="layui-icon"></i></button>';
                //    strhtml += '<button title="添加子观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click();><i class="layui-icon"></i></button>';
                //    //strhtml += '<button title="重新排列序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnReOrder_Click("' + strsubTypeId + '")><i class="layui-icon">&#xe669;</i></button>';
                //    //}
                //}
                //strhtml += '</div></td></tr>';
                //<td>' + cateid + ' </td>
                //strhtml += '<td class="td-manage"></td>';
                for (var j = 0; j < arrvPaperSubVTypeNumObjLst.length; j++) {
                    cateid++;
                    intJ++;
                    var fid = 0;
                    var strsubTypeId = arrvPaperSubVTypeNumObjLst[j].subViewpointTypeId;
                    //先创建子模块类型
                    //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>';
                    //strhtml += '<div style="float:left;"><h3>' + intJ + '.' + arrvPaperSubVTypeNumObjLst[j].subViewpointTypeName + '</h3><span class="layui-badge" id="SubVTypeCount">' + arrvPaperSubVTypeNumObjLst[j].memo + '</span></div>';
                    strhtml += '<div style="float:left;font-size:22px;font-weight:bold;">' + intJ + '.' + arrvPaperSubVTypeNumObjLst[j].subViewpointTypeName + '</div>';
                    strhtml += '<span style="float:left;" class="layui-badge" id="SubVTypeCount">' + arrvPaperSubVTypeNumObjLst[j].memo + '</span>';
                    strhtml += '<div style="float:right;">';
                    if ($("#hidType").val() == "01") {
                        if ($("#hidIsSubmit").val() != "true") {
                            strhtml += '<button title="添加子观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '")><i class="layui-icon"></i></button>';
                        }
                    }
                    strhtml += '</div>';
                    strhtml += '</td></tr>';
                    //<td>' + cateid + ' </td>
                    //strhtml += '<td class="td-manage"></td>';
                    //子类型数据
                    var strSubViewpointId = "";
                    cateid_ = cateid;
                    var intK = 0;
                    arrvPaperSubViewpointObjLst = arrvPaperSubViewpointObjLst2.filter(x => x.subViewpointTypeId == strsubTypeId);
                    //arrvPaperSubViewpointObjLst = arrvPaperSubViewpointObjLst2.filter(x => x.subViewpointTypeId == strsubTypeId);
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
                        //strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" onmouseover=btnUpdatePaperPageNum_Click(' + arrvPaperSubViewpointObjLst[k].paperPageNum + ',"' + arrvPaperSubViewpointObjLst[k].explainContent + '")><td>';
                        strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" onclick=btnUpdatePaperPageNum_Click(' + arrvPaperSubViewpointObjLst[k].paperPageNum + ',"' + arrvPaperSubViewpointObjLst[k].explainContent + '")><td>';
                        strhtml += '&nbsp;&nbsp;<span class="color3">' + intK + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].attitudesName + '】' + arrvPaperSubViewpointObjLst[k].subViewpointContent + '';
                        //strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【观点类型】' + arrvPaperSubViewpointObjLst[k].subViewpointTypeName + '';
                        //根据子观点id 得到附件
                        if (arrvPaperSubViewpointObjLst[k].sectionName != "") {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【论文节】' + arrvPaperSubViewpointObjLst[k].sectionName + '';
                        }
                        arrPaperSubAttachmentObjLst = arrPaperSubAttachmentObjLst2.filter(x => x.subViewpointId == strSubViewpointId);
                        if (arrPaperSubAttachmentObjLst.length > 0) {
                            for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {
                                var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                                strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';
                            }
                        }
                        if (arrvPaperSubViewpointObjLst[k].explainContent != "") {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].explainTypeName + '】' + arrvPaperSubViewpointObjLst[k].explainContent + '';
                        }
                        //if (arrvPaperSubViewpointObjLst[k].literatureSourcesId != "") {
                        //    strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【引用文献】' + arrvPaperSubViewpointObjLst[k].PaperTitleEx + '(作者：' + arrvPaperSubViewpointObjLst[k].AuthorEx + ')';
                        //}
                        if (arrvPaperSubViewpointObjLst[k].paperPageNum != 0) {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a class="color3" ><i class="layui-icon x-show" status="true">&#xe623;</i>【pdf页码】第' + arrvPaperSubViewpointObjLst[k].paperPageNum + '页</a>';
                        }
                        var objUser = arrUsers.find(x => x.userId == arrvPaperSubViewpointObjLst[k].updUser);
                        if (objUser != null) {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="color2"><i class="layui-icon x-show" status="true">&#xe623;</i>【编辑时间】' + arrvPaperSubViewpointObjLst[k].updDate + '【编辑用户】' + objUser.userName + '</span>';
                        }
                        //最底一行编辑
                        strhtml += '<br/><div style="float:right;">';
                        if ($("#hidType").val() == "01") {
                            //if ($("#hidIsSubmit").val() == "true") {
                            strhtml += '&nbsp;&nbsp;<img src="../img/vote.png" width = "20px" height = "18px" title = "点赞数" >&nbsp;赞' + arrvPaperSubViewpointObjLst[k].okCount;
                            //strhtml += '&nbsp;&nbsp;评论数:<a href="#" onclick="btnShowAppraise_Click("' + strSubViewpointId + '")">' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a>';
                            strhtml += '&nbsp;&nbsp;评论数:' + arrvPaperSubViewpointObjLst[k].appraiseCount;
                            if (arrvPaperSubViewpointObjLst[k].score != 0) {
                                strhtml += '&nbsp;&nbsp;综合评分:' + arrvPaperSubViewpointObjLst[k].score;
                            }
                            if (arrvPaperSubViewpointObjLst[k].teaScore != 0) {
                                strhtml += '&nbsp;&nbsp;教师评分:' + arrvPaperSubViewpointObjLst[k].teaScore;
                            }
                            if (arrvPaperSubViewpointObjLst[k].stuScore != 0) {
                                strhtml += '&nbsp;&nbsp;学生评分:' + arrvPaperSubViewpointObjLst[k].stuScore;
                            }
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = "btnAddAppraise_Click("' + strSubViewpointId + '")" > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                            //} else {
                            //strhtml += '<input id="txt_OrderNum' + cateid + '" type="text" class="layui-input" style="width:40px;" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click("' + strSubViewpointId + '","txt_OrderNum' + cateid + '");>';
                            //上移
                            //strhtml += '<button title="上移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '")><i class="iconfont">&#xe6a5;</i></button>';
                            ////下移
                            //strhtml += '<button title="下移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '")><i class="iconfont">&#xe6a6;</i></button>';
                            //编辑
                            strhtml += '<button title="编辑子观点" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strSubViewpointId + '")><i class="layui-icon">&#xe642;</i></button>';
                            //删除
                            strhtml += '<button title="删除子观点" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strSubViewpointId + '")><i class="layui-icon">&#xe640;</i></button>';
                            //}
                        }
                        else if ($("#hidType").val() == "02") {
                            //var objLike = arrvPaperSubViewpointLikeLogObjLst.find(x => x.tableKey == strSubViewpointId);
                            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSubViewpointId);
                            //if (objLike == null) {
                            //    strhtml += '&nbsp;&nbsp;<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + strSubViewpointId + '") ><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞" >&nbsp;赞' + arrvPaperSubViewpointObjLst[k].okCount + '</a>';
                            //} else {
                            //    strhtml += '&nbsp;&nbsp;<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + strSubViewpointId + '") ><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞" >&nbsp;已赞' + arrvPaperSubViewpointObjLst[k].okCount + '</a>';
                            //}
                            if (objLike == null) {
                                strhtml += '&nbsp;&nbsp;<a href="javascript:void(0)" onclick=btnAddVote_Click("' + strSubViewpointId + '","' + arrvPaperSubViewpointObjLst[k].updUser + '") ><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞" >&nbsp;赞' + arrvPaperSubViewpointObjLst[k].okCount + '</a>';
                            }
                            else {
                                strhtml += '&nbsp;&nbsp;<a href="javascript:void(0)" onclick=btnAddVote_Click("' + strSubViewpointId + '","' + arrvPaperSubViewpointObjLst[k].updUser + '") ><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞" >&nbsp;已赞' + arrvPaperSubViewpointObjLst[k].okCount + '</a>';
                            }
                            strhtml += '&nbsp;&nbsp;<span style="color:royalblue" >评论数:' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</span>';
                            if (arrvPaperSubViewpointObjLst[k].score != 0) {
                                strhtml += '&nbsp;&nbsp;综合评分:' + arrvPaperSubViewpointObjLst[k].score;
                            }
                            if (arrvPaperSubViewpointObjLst[k].teaScore != 0) {
                                strhtml += '&nbsp;&nbsp;教师评分:' + arrvPaperSubViewpointObjLst[k].teaScore;
                            }
                            if (arrvPaperSubViewpointObjLst[k].stuScore != 0) {
                                strhtml += '&nbsp;&nbsp;学生评分:' + arrvPaperSubViewpointObjLst[k].stuScore;
                            }
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('论文子观点评论', '../GraduateEduTools/SysComment?Key=" + strSubViewpointId + "&Type=02&User=" + arrvPaperSubViewpointObjLst[k].updUser + "&pubParentId=" + $("#hidPaperId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = "btnShowAppraise_Click("' + strSubViewpointId + '")" > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                        }
                        //strhtml += '</div></td><td style="text-align:center"><input id="txt_OrderNum' + cateid + '" type="text" class="layui-input x-sort" style="width:40px;" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click("' + strSubViewpointId + '","txt_OrderNum' + cateid + '");>';
                        ////上移
                        //strhtml += '<br/><button title="上移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strSubViewpointId + '","' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a5;</i></button>';
                        ////下移
                        //strhtml += '<button title="下移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strSubViewpointId + '","' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a6;</i></button>';
                        strhtml += '</div></td></tr>';
                        //strhtml += '<td class="td-manage"></td>';
                    }
                }
                //拼接；
                //$("#tbList").append(strhtml);
                $("#tbList").html(strhtml);
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
            const strThisFuncName = this.btnUpdateOrderNum_Click.name;
            //var lngKeyId = Number(strKeyId);
            var objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            objPaperSubViewpointEN.SetSubViewpointId(strKeyId);
            objPaperSubViewpointEN.SetOrderNum(Number($("#" + strOrderNum + "").val()));
            objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
        //添加的时候默认选择类型名称不需要了
        //public async selectTitle_Click() {
        //    try {
        //        var objSubViewpointType: clsSubViewpointTypeEN;
        //        var strWhereCond = " subViewpointTypeId='" + this.subViewpointTypeId + "'";
        //        this.recCount = await SubViewpointType_GetFirstObjAsync(strWhereCond).then((jsonData) => {
        //            objSubViewpointType = <clsSubViewpointTypeEN>jsonData;
        //            this.rwTitle = objSubViewpointType.defaTitle;
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `获取记录不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
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
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlSectionId, arrSectionObjLst, clsSectionEN_js_1.clsSectionEN.con_SectionId, clsSectionEN_js_1.clsSectionEN.con_SectionName, "论文节");
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
        //添加点赞
        async btnAddVote_Click(strSubViewpointId, strUserId) {
            const strThisFuncName = this.btnAddVote_Click.name;
            //this.DivName = "divAddNewRecordSave";
            var objSysVoteEN = new clsSysVoteEN_js_1.clsSysVoteEN();
            objSysVoteEN.SetTableKey(strSubViewpointId);
            objSysVoteEN.SetVoteTypeId("02");
            objSysVoteEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objSysVoteEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            objSysVoteEN.SetLikedUserId(strUserId); //被点赞用户
            objSysVoteEN.SetPubParentId($("#hidPaperId").val());
            objSysVoteEN.Setid_CurrEduCls($("#hidid_CurrEduCls").val());
            var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' and tableKey=" + strSubViewpointId;
            try {
                const responseText = await (0, clsSysVoteWApi_js_1.SysVote_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsSysVoteWApi_js_1.SysVote_AddNewRecordAsync)(objSysVoteEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1=1 and voteTypeId='02' and tableKey=" + strSubViewpointId;
                    var intVoteCount = await (0, clsSysVoteWApi_js_1.SysVote_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
                    objPaperSubViewpointEN.SetSubViewpointId(strSubViewpointId);
                    objPaperSubViewpointEN.SetOkCount(intVoteCount);
                    objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_UpdateRecordAsync)(objPaperSubViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //const gvResult = await this.BindGv_vPaper();
                            this.BindGv_vPaperSubViewpoint();
                        }
                        else {
                            var strInfo = `点赞不成功!`;
                            alert(strInfo);
                            console.log("点赞不成功");
                        }
                    });
                }
                else {
                    var strInfo = `点赞不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.DetailRecord();
                    //this.BindGv_vPaperSubViewpoint();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `点赞不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
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
                //添加成功后把数据同步到总表
                var strSubViewpointId = $('#hidKeyId').val();
                //删除前先查询是否有评论数据，如果存在则提示必须先删除评论数据才能执行子观点删除；
                var strWhere = "1=1 And commentTypeId='02' And tableKey='" + strSubViewpointId + "'";
                const responseText4 = await (0, clsSysCommentWApi_js_1.SysComment_IsExistRecordAsync)(strWhere);
                var returnBool3 = !!responseText4;
                if (returnBool3 == true) {
                    console.log("子观点数据存在评论不可删除");
                    alert("请先删除该子观点评论数据！");
                    return "";
                }
                else {
                    const responseText3 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSubViewpointId, "03", "3", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                    var returnBool3 = !!responseText3;
                    if (returnBool3 == true) {
                        console.log("论文子观点数据总表删除成功；");
                    }
                    else {
                        console.log("论文子观点数据总表删除失败；");
                    }
                    //var lngKeyId = Number(strKeyId);
                    const responseText = await this.DelRecord(strKeyId);
                }
                const responseText2 = await this.BindGv_vPaperSubViewpoint();
                const UpdateRest = await this.SynSubV();
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
        async DelRecord(strSubViewpointId) {
            try {
                const returnInt = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_DelRecordAsync)(strSubViewpointId);
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
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
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
            objPaperDownloadLogEN.SetPaperId($("#hidPaperId").val());
            objPaperDownloadLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objPaperDownloadLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
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
        /// <summary>
        /// 把Html控件集合转换成Array列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetArray)
        /// </summary>
        /// <returns></returns>
        GetArray(arr) {
            let arrLst = new Array();
            for (var i = 0; i < arr.length; i++) {
                var chk = arr[i]; // as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        }
        ;
        //添加高亮
        btnUpdatePaperPageNum_Click() {
            this.RemoveSelect();
            var objLst = document.getElementsByTagName("span");
            //var strStartName: string = "400%";
            let arrElement = this.GetArray(objLst);
            //let arrSpan
            let arrFind = arrElement;
            //let arrFind: Array<HTMLSpanElement> = arrSpan.filter(x => x.id.indexOf(strStartName) > -1);
            let arrWord = arrFind.map(x => x.innerText);
            let strWord = arrWord.join("");
            var intWord = strWord.indexOf("400%");
            strWord = strWord.substring(intWord);
            let strFindText = $('#hidExplainContent').val();
            var intStart = strWord.indexOf(strFindText);
            if (intStart > -1) {
                var strInnerText = arrFind[intStart].innerText;
                var strCurrWord = strWord.substring(0, 1);
                var intWordIndex = 0;
                var bolFind = false;
                var intCompareIndex = 0;
                while (bolFind == false) {
                    strInnerText = arrFind[intStart + intCompareIndex].innerText;
                    strCurrWord = strFindText.substring(intCompareIndex, intCompareIndex + 1);
                    console.log(strInnerText + "--" + strCurrWord);
                    if (strInnerText == strCurrWord) {
                        intCompareIndex++;
                        if (intCompareIndex >= strFindText.length)
                            break;
                        continue;
                    }
                    else {
                        intStart++;
                        intCompareIndex = 0;
                        if (intStart > arrFind.length - 2) {
                            break;
                        }
                    }
                    //                intStart++;
                }
                var intLen = strFindText.length;
                var intEnd = intStart + intLen;
                let arrSpan_Sel = arrFind.slice(intStart, intEnd);
                arrSpan_Sel.forEach(x => {
                    var strWord = x.innerText;
                    var objSpan_New = document.createElement("span");
                    objSpan_New.className = "text-span";
                    objSpan_New.innerText = strWord;
                    x.innerHTML = "";
                    x.appendChild(objSpan_New);
                });
            }
            //let divResult: HTMLDivElement = document.getElementById("divResult") as HTMLDivElement;
            //divResult.innerText = strWord;
        }
        ;
        //清除高亮
        RemoveSelect() {
            var objLst = document.getElementsByTagName("span");
            //var strStartName: string = "divEditFldComparison";
            let arrElement = this.GetArray(objLst);
            let arrSpan = arrElement;
            let arrSpan_Sel = arrSpan.filter(x => x.className == "text-span");
            arrSpan_Sel.forEach(x => {
                var strWord = x.innerText;
                var objSpan_Parent = x.parentNode;
                objSpan_Parent.innerHTML = strWord;
            });
        }
        ;
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
        // /*
        //* 设置页码
        //*/
        // public set paperPageNum(value: number) {
        //     $("#txtPaperPageNum").val(value);
        // }
        // /*
        // * 获取页码
        // */
        // public get paperPageNum(): number {
        //     return $("#txtPaperPageNum").val();
        // }
        // /*
        //* 设置行号
        //*/
        // public set PaperLineNum(value: number) {
        //     $("#txtPaperLineNum").val(value);
        // }
        // /*
        // * 获取行号
        // */
        // public get PaperLineNum(): number {
        //     return $("#txtPaperLineNum").val();
        // }
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
    * 观点态度
    */
        set attitudesId(value) {
            $("#ddlAttitudesId").val(value);
        }
        /*
        * 观点态度Id
       */
        get attitudesId() {
            return $("#ddlAttitudesId").val();
        }
        /******************************************************************iFrame子页面控件******************************************************/
        /*
       * Pdf内容
      */
        set pdfContent(value) {
            //$("#hidPdfContent").val(value);
            $("#iframe_qaPdf").contents().find("#hidPdfContent").val(value);
        }
        /*
        * Pdf内容
       */
        get pdfContent() {
            //return $("#hidPdfContent").val();
            return $("#iframe_qaPdf").contents().find("#hidPdfContent").val();
        }
        /*
        * Pdf页码
       */
        set pdfPageNum(value) {
            //$("#hidPdfPageNum").val(value);
            $("#iframe_qaPdf").contents().find("#hidPdfPageNum").val(value);
        }
        /*
        * Pdf页码
       */
        get pdfPageNum() {
            //return $("#hidPdfPageNum").val();
            return $("#iframe_qaPdf").contents().find("#hidPdfPageNum").val();
        }
        /*
     * PdfTop
    */
        set page_top(value) {
            //$("#hidPdfPageNum").val(value);
            $("#iframe_qaPdf").contents().find("#page_top").val(value);
        }
        /*
        * PdfTop
       */
        get page_top() {
            //return $("#hidPdfPageNum").val();
            return $("#iframe_qaPdf").contents().find("#page_top").val();
        }
        /*
     * page_cache
    */
        set page_cache(value) {
            //$("#hidPdfPageNum").val(value);
            $("#iframe_qaPdf").contents().find("#page_cache").val(value);
        }
        /*
        * page_cache
       */
        get page_cache() {
            //return $("#hidPdfPageNum").val();
            return $("#iframe_qaPdf").contents().find("#page_cache").val();
        }
        /*
    * pdf_zoom
    */
        set pdf_zoom(value) {
            //$("#hidPdfPageNum").val(value);
            $("#iframe_qaPdf").contents().find("#pdf_zoom").val(value);
        }
        /*
        * pdf_zoom
       */
        get pdf_zoom() {
            //return $("#hidPdfPageNum").val();
            return $("#iframe_qaPdf").contents().find("#pdf_zoom").val();
        }
        /*
    * pdfDiv_top
    */
        set pdfDiv_top(value) {
            //$("#hidPdfPageNum").val(value);
            $("#iframe_qaPdf").contents().find("#pdfDiv_top").val(value);
        }
        /*
        * pdfDiv_top
       */
        get pdfDiv_top() {
            //return $("#hidPdfPageNum").val();
            return $("#iframe_qaPdf").contents().find("#pdfDiv_top").val();
        }
        /*
    * pdfDiv_left
    */
        set PdfPageCache(value) {
            //$("#hidPdfPageNum").val(value);
            $("#iframe_qaPdf").contents().find("#pdfDiv_left").val(value);
        }
        /*
        * page_cache
       */
        get pdfDiv_left() {
            //return $("#hidPdfPageNum").val();
            return $("#iframe_qaPdf").contents().find("#pdfDiv_left").val();
        }
        /*
        * 教学班ID
       */
        set Id_CurrEduCls(value) {
            $("#hidid_CurrEduCls").val(value);
        }
        /*
        * 教学班
       */
        get Id_CurrEduCls() {
            return $("#hidid_CurrEduCls").val();
        }
    }
    exports.PaperSubViewpoint_pdf = PaperSubViewpoint_pdf;
});
