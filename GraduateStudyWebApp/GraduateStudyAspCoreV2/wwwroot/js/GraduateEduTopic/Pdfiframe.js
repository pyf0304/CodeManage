(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/ConceptCRUD.js", "../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js", "../PagesBase/GraduateEduTopic/ViewpointCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTConceptRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTConceptRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTConceptRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTTopicObjectiveRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduTopic/clsvViewpointExWApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Pdfiframe = void 0;
    const ConceptCRUD_js_1 = require("../PagesBase/GraduateEduTopic/ConceptCRUD.js");
    const TopicObjectiveCRUD_js_1 = require("../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js");
    const ViewpointCRUD_js_1 = require("../PagesBase/GraduateEduTopic/ViewpointCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsConceptEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js");
    const clsRTConceptRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTConceptRelaEN.js");
    const clsRTSysSkillRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js");
    const clsRTSysSocialRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js");
    const clsRTTopicObjectiveRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js");
    const clsRTViewpointRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js");
    const clsSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js");
    const clsSysSocialRelationsEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js");
    const clsvRTPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js");
    const clsvSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js");
    const clsvSysSocialRelationsEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js");
    const clsvTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js");
    const clsvViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsRTConceptRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTConceptRelaWApi.js");
    const clsRTSysSkillRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js");
    const clsRTSysSocialRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js");
    const clsRTTopicObjectiveRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js");
    const clsRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js");
    const clsSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js");
    const clsSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js");
    const clsvConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsvRTConceptRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTConceptRelaWApi.js");
    const clsvRTPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js");
    const clsvRTSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSkillWApi.js");
    const clsvRTSysSocialRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js");
    const clsvRTTopicObjectiveRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTTopicObjectiveRelaWApi.js");
    const clsvRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js");
    const clsvSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js");
    const clsvSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js");
    const clsvTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsvViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsUsersWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsvViewpointExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTopic/clsvViewpointExWApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Pdfiframe extends ViewpointCRUD_js_1.ViewpointCRUD {
        constructor() {
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortUsersBy: string = "userId";
            super(...arguments);
            //观点列表
            this.mstrListDivViewpoint = "divViewpointDataLst";
            //概念列表
            this.mstrListDivPaper = "divConceptDataLst";
            //客观列表
            this.mstrListDivObjective = "divObjectiveDataLst";
            this.recCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            const strThisFuncName = this.Page_Load.name;
            // 在此处放置用户代码以初始化页面 
            try {
                //通过主题Id获取教学班ID
                if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls == "") {
                    const objResearchTopic = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetFirstObjAsync)(" topicId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId);
                    if (objResearchTopic == null) {
                        const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    //const strThisFuncName = this.Page_Load.name;
                    clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId_q");
                    //绑定编辑框
                    //const responseText2 = await this.BindEdit();
                }
                else {
                    alert("登录超时，请重新登录！");
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //专业下拉框绑定
        BindDdl_PaperId(ddlPaperId) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strWhereCond = " topicId= " + strTopicId;
            var objDdl = document.getElementById(ddlPaperId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlPaperId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsvRTPaperRelaWApi_js_1.vRTPaperRela_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrvRTPaperRelaObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst_V)(ddlPaperId, arrvRTPaperRelaObjLst, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperId, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTitle, "主题相关论文");
                        console.log("完成BindDdl_UserId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        async SelectPaper() {
            try {
                var strPaperId = $("#ddlPaperId_q").val();
                $("#hidPaperId").val(strPaperId);
                //绑定pdf
                const responseText1 = await this.BindPdf();
                //绑定编辑框
                const responseText2 = await this.li_PaperMenu_Click();
                //const responseText2 = await this.BindEdit();
                ////绑定各类型的编辑框
                //const responseText3 = await this.BindPage();
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
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
                const responseText2 = await this.BindEdit();
                //绑定各类型的编辑框
                const responseText3 = await this.BindPage();
            }
            else if (strnum == "2") {
                $("#liPaper_QA a").addClass("active");
                $("#Paper_QA").addClass("active show");
                //主题论文关系；
                const gvResult = await this.Bind_Paper_QA();
            }
            else if (strnum == "3") {
                $("#liPaper_Tags a").addClass("active");
                $("#Paper_Tags").addClass("active show");
                //主题论文关系；
                const gvResult = await this.Bind_Paper_Tags();
            }
            else if (strnum == "4") {
                $("#liTea_QA a").addClass("active");
                $("#Tea_QA").addClass("active show");
                //主题论文关系；
                const gvResult = await this.Bind_Tea_QA();
            }
            else {
                const responseText2 = await this.BindEdit();
                //绑定各类型的编辑框
                const responseText3 = await this.BindPage();
            }
        }
        //绑定Pdf
        async BindPdf() {
            try {
                //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
                var strPaperId = $("#ddlPaperId_q").val();
                var objPaperAttachment;
                var strWhereCond = " 1=1 and paperId ='" + strPaperId + "'";
                const responseText = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetFirstObjAsync)(strWhereCond);
                objPaperAttachment = responseText;
                var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                if (objPaperAttachment != null) {
                    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                    var strhtml = "";
                    strhtml = "<iframe id='iframe_qaPdf' src='../GraduateEduEx/qaPdf?zoom=1.1&file=" + strfilepath + "' style=\"height:100%;width:99%; min-height:700px;\"></iframe>";
                    $("#div_pdf").html(strhtml);
                }
                else {
                    var strhtml = "";
                    strhtml = "<iframe id='iframe_qaPdf' src='../GraduateEduEx/qaPdf?zoom=1.1' style=\"height:100%;width:99%; min-height:700px;\"></iframe>";
                    $("#div_pdf").html(strhtml);
                }
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
                //var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
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
                var strhtml = "<iframe id='iframe_Paper_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='" + varLink + "' style='height:100%;width:99%; min-height:690px;'></iframe>";
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
                //var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                var strhtml = "<iframe id='iframe_Paper_Tags'  frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes'  src='../InteractManage/Paper_Tags?paperId=" + strPaperId + "&id_CurrEduCls=" + strid_CurrEduCls + "' style='height:100%;width:99%; min-height:690px;'></iframe>";
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
                //var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                var varLink = "";
                if (strQuestionsId != "") {
                    varLink = '../InteractManage/Tea_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&questionsId=' + strQuestionsId;
                }
                else {
                    if (strTopicId != "") {
                        varLink = '../InteractManage/Tea_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&topicId=' + strTopicId;
                    }
                    varLink = '../InteractManage/Tea_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls;
                }
                //var strhtml = "<iframe id='iframe_Tea_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='../InteractManage/Paper_QA?paperId=" + strPaperId + "' style='height:100%;width:99%; min-height:650px;'></iframe>";
                var strhtml = "<iframe id='iframe_Tea_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='" + varLink + "' style='height:100%;width:99%; min-height:690px;'></iframe>";
                $("#Tea_QA").html(strhtml);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定各个类型页面
        async BindEdit() {
            var strPaperId = $("#ddlPaperId_q").val();
            var arrvPdfPageNumObjLst = [];
            try {
                //个人观点
                $("#hidUserTypeId").val("01");
                var strListDiv = this.mstrListDivViewpoint;
                var strWhereCond1 = await this.CombinevViewpointCondition();
                var strWhereCond_1 = "1=1 and userTypeId='" + $("#hidUserTypeId").val() + "' and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
                var arrvViewpointObjLst1 = [];
                var arrvViewpointObjLst10 = [];
                var arrvRTViewpointRelaObjLst1 = [];
                const responseObjLst1 = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                    arrvViewpointObjLst10 = jsonData;
                });
                const responseObjLst_1 = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstAsync)(strWhereCond_1).then((jsonData) => {
                    arrvRTViewpointRelaObjLst1 = jsonData;
                });
                //专家观点
                $("#hidUserTypeId").val("02");
                var strListDiv = this.mstrListDivViewpoint;
                var strWhereCond2 = await this.CombinevViewpointCondition();
                var strWhereCond_2 = "1=1 and userTypeId='" + $("#hidUserTypeId").val() + "' and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
                var arrvViewpointObjLst2 = [];
                var arrvViewpointObjLst20 = [];
                var arrvRTViewpointRelaObjLst2 = [];
                const responseObjLst2 = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvViewpointObjLst20 = jsonData;
                });
                const responseObjLst_2 = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstAsync)(strWhereCond_2).then((jsonData) => {
                    arrvRTViewpointRelaObjLst2 = jsonData;
                });
                //相关概念
                var strWhereCond3 = await this.CombineConceptCondition();
                var strWhereCond_3 = "1=1 and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
                var arrvConceptObjLst = [];
                var arrvConceptObjLst0 = [];
                var arrvRTConceptRelaObjLst = [];
                const responseObjLst3 = await (0, clsvConceptWApi_js_1.vConcept_GetObjLstAsync)(strWhereCond3).then((jsonData) => {
                    arrvConceptObjLst0 = jsonData;
                });
                const responseObjLst_3 = await (0, clsvRTConceptRelaWApi_js_1.vRTConceptRela_GetObjLstAsync)(strWhereCond_3).then((jsonData) => {
                    arrvRTConceptRelaObjLst = jsonData;
                });
                //客观事实
                $("#hidObjectiveTypeId").val("01");
                var strWhereCond4 = await this.CombinevTopicObjectiveCondition();
                var strWhereCond_4 = "1=1 and objectiveType='" + $("#hidObjectiveTypeId").val() + "' and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
                var arrvTopicObjectiveObjLst1 = [];
                var arrvTopicObjectiveObjLst10 = [];
                var arrvRTTopicObjectiveRelaObjLst1 = [];
                const responseObjLst4 = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstAsync)(strWhereCond4).then((jsonData) => {
                    arrvTopicObjectiveObjLst10 = jsonData;
                });
                const responseObjLst_4 = await (0, clsvRTTopicObjectiveRelaWApi_js_1.vRTTopicObjectiveRela_GetObjLstAsync)(strWhereCond_4).then((jsonData) => {
                    arrvRTTopicObjectiveRelaObjLst1 = jsonData;
                });
                //客观数据
                $("#hidObjectiveTypeId").val("02");
                var strWhereCond5 = await this.CombinevTopicObjectiveCondition();
                var strWhereCond_5 = "1=1 and objectiveType='" + $("#hidObjectiveTypeId").val() + "' and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
                var arrvTopicObjectiveObjLst2 = [];
                var arrvTopicObjectiveObjLst20 = [];
                var arrvRTTopicObjectiveRelaObjLst2 = [];
                const responseObjLst5 = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstAsync)(strWhereCond5).then((jsonData) => {
                    arrvTopicObjectiveObjLst20 = jsonData;
                });
                const responseObjLst_5 = await (0, clsvRTTopicObjectiveRelaWApi_js_1.vRTTopicObjectiveRela_GetObjLstAsync)(strWhereCond_5).then((jsonData) => {
                    arrvRTTopicObjectiveRelaObjLst2 = jsonData;
                });
                //技能
                var strWhereCond6 = await this.CombinevSysSkillCondition();
                var strWhereCond_6 = "1=1 and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
                var arrvSysSkillObjLst = [];
                var arrvSysSkillObjLst0 = [];
                var arrvRTSysSkillObjLst = [];
                const responseObjLst6 = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetObjLstAsync)(strWhereCond6).then((jsonData) => {
                    arrvSysSkillObjLst0 = jsonData;
                });
                const responseObjLst_6 = await (0, clsvRTSysSkillWApi_js_1.vRTSysSkill_GetObjLstAsync)(strWhereCond_6).then((jsonData) => {
                    arrvRTSysSkillObjLst = jsonData;
                });
                //社会关系
                var strWhereCond7 = await this.CombinevSysSocialRelationsCondition();
                var strWhereCond_7 = "1=1 and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
                var arrvSysSocialRelationsObjLst = [];
                var arrvSysSocialRelationsObjLst0 = [];
                var arrvRTSysSocialRelaObjLst = [];
                const responseObjLst7 = await (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_GetObjLstAsync)(strWhereCond7).then((jsonData) => {
                    arrvSysSocialRelationsObjLst0 = jsonData;
                });
                const responseObjLst_7 = await (0, clsvRTSysSocialRelaWApi_js_1.vRTSysSocialRela_GetObjLstAsync)(strWhereCond_7).then((jsonData) => {
                    arrvRTSysSocialRelaObjLst = jsonData;
                });
                //获取所有观点的pdf页码
                const responseText1 = await (0, clsvViewpointExWApi_js_1.vViewpointEx_GetAllVNumObjLstAsync)(strPaperId).then((jsonData) => {
                    arrvPdfPageNumObjLst = jsonData;
                });
                //获取用户缓存；
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                for (var i = 0; i < arrvPdfPageNumObjLst.length; i++) {
                    strhtml += '<div style="font-size:20px; color: #009688; font-weight: bold; margin-bottom:10px;"><a id="PdfNum' + arrvPdfPageNumObjLst[i].pdfPageNum + '" href="javascript:void(0)" onclick=btnPdfPageNum_Click(' + arrvPdfPageNumObjLst[i].pdfPageNum + ')>pdf第' + arrvPdfPageNumObjLst[i].pdfPageNum + '页各观点：</a></div>';
                    //个人观点1
                    arrvViewpointObjLst1 = arrvViewpointObjLst10.filter(x => x.pdfPageNum == arrvPdfPageNumObjLst[i].pdfPageNum);
                    if (arrvViewpointObjLst1.length > 0) {
                        strhtml += await this.BindList_vViewpoint("01", arrvViewpointObjLst1, arrvRTViewpointRelaObjLst1, arrUsers);
                    }
                    //专家观点2
                    arrvViewpointObjLst2 = arrvViewpointObjLst20.filter(x => x.pdfPageNum == arrvPdfPageNumObjLst[i].pdfPageNum);
                    if (arrvViewpointObjLst2.length > 0) {
                        strhtml += await this.BindList_vViewpoint("02", arrvViewpointObjLst2, arrvRTViewpointRelaObjLst2, arrUsers);
                    }
                    //相关概念3
                    arrvConceptObjLst = arrvConceptObjLst0.filter(x => x.pdfPageNum == arrvPdfPageNumObjLst[i].pdfPageNum);
                    if (arrvConceptObjLst.length > 0) {
                        strhtml += await this.BindList_vConcept(arrvConceptObjLst, arrvRTConceptRelaObjLst);
                    }
                    //客观事实4
                    arrvTopicObjectiveObjLst1 = arrvTopicObjectiveObjLst10.filter(x => x.pdfPageNum == arrvPdfPageNumObjLst[i].pdfPageNum);
                    if (arrvTopicObjectiveObjLst1.length > 0) {
                        strhtml += await this.BindList_vTopicObjective("01", arrvTopicObjectiveObjLst1, arrvRTTopicObjectiveRelaObjLst1);
                    }
                    //客观数据5
                    arrvTopicObjectiveObjLst2 = arrvTopicObjectiveObjLst20.filter(x => x.pdfPageNum == arrvPdfPageNumObjLst[i].pdfPageNum);
                    if (arrvTopicObjectiveObjLst2.length > 0) {
                        strhtml += await this.BindList_vTopicObjective("02", arrvTopicObjectiveObjLst2, arrvRTTopicObjectiveRelaObjLst2);
                    }
                    //技能6
                    arrvSysSkillObjLst = arrvSysSkillObjLst0.filter(x => x.pdfPageNum == arrvPdfPageNumObjLst[i].pdfPageNum);
                    if (arrvSysSkillObjLst.length > 0) {
                        strhtml += await this.BindList_vSysSkill(arrvSysSkillObjLst, arrvRTSysSkillObjLst);
                    }
                    //社会关系7
                    arrvSysSocialRelationsObjLst = arrvSysSocialRelationsObjLst0.filter(x => x.pdfPageNum == arrvPdfPageNumObjLst[i].pdfPageNum);
                    if (arrvSysSocialRelationsObjLst.length > 0) {
                        strhtml += await this.BindList_vSysSocialRelations(arrvSysSocialRelationsObjLst, arrvRTSysSocialRelaObjLst);
                    }
                }
                $("#div_list").html(strhtml);
                //this.hidSortvViewpointBy = "updDate Desc";
                //ConceptCRUD.sortConceptBy = "updDate Desc";
                //TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";
                //this.hidSortvSysSkillBy = "updDate Desc";
                //this.hidSortvSysSocialRelationsBy = "fullName Asc";
                //const responseObjList1 = await this.BindGv_vViewpoint("01");
                //const responseObjList2 = await this.BindGv_vViewpoint("02");
                //const responseObjList3 = await this.BindGv_Concept();
                //const responseObjList4 = await this.BindGv_vTopicObjective("01");
                //const responseObjList5 = await this.BindGv_vTopicObjective("02");
                //const responseObjList6 = await this.BindGv_vSysSkill();
                //const responseObjList7 = await this.BindGv_vSysSocialRelations();
                //var strPaperId = $("#ddlPaperId_q").val();//论文
                //var strPageType = $("#hidPageType").val();//页面参数
                //var strTopicId = clsPrivateSessionStorage.topicId;//存放主题Id
                //$("#myTab li a").removeClass();
                //$("#myTabContent div").removeClass();
                //$("#myTab li a").addClass("nav-link");
                //$("#myTabContent div").addClass("tab-pane");
                ////判断页面参数
                //if (strPageType == "01") {
                //    //个人观点
                //    $("#liViewpoint a").addClass(" active");
                //    $("#li_Viewpoint").addClass(" active show");
                //    //$("#ListTitle").html("当前论文相关的个人观点");
                //    this.hidSortvViewpointBy = "updDate Desc";
                //    //$("#ViewpointList").show();
                //    const responseObjList = await this.BindGv_vViewpoint();
                //}
                //else if (strPageType == "02") {
                //    //专家观点
                //    $("#liExpertViewpoint a").addClass(" active");
                //    $("#li_ExpertViewpoint").addClass(" active show");
                //    //$("#ListTitle").html("当前论文相关的专家观点");
                //    this.hidSortvViewpointBy = "updDate Desc";
                //    //$("#ViewpointList").show();
                //    const responseObjList = await this.BindGv_vViewpoint();
                //}
                //else if (strPageType == "03") {
                //    //概念
                //    $("#liConcept a").addClass(" active");
                //    $("#li_Concept").addClass(" active show");
                //    //$("#ListTitle").html("当前论文相关的相关概念");
                //    ConceptCRUD.sortConceptBy = "updDate Desc";
                //    //$("#ConceptList").show();
                //    const responseObjList = await this.BindGv_Concept();
                //}
                //else if (strPageType == "04") {
                //    //客观事实
                //    $("#liObjective a").addClass(" active");
                //    $("#li_Objective").addClass(" active show");
                //    //$("#ListTitle").html("当前论文相关的客观事实");
                //    TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";
                //    //$("#ObjectiveList").show();
                //    const responseObjList = await this.BindGv_vTopicObjective();
                //}
                //else if (strPageType == "05") {
                //    //客观数据
                //    $("#liObjectiveBasis a").addClass(" active");
                //    $("#li_ObjectiveBasis").addClass(" active show");
                //    //$("#ListTitle").html("当前论文相关的客观数据");
                //    TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";
                //    //$("#ObjectiveList").show();
                //    const responseObjList = await this.BindGv_vTopicObjective();
                //}
                //else if (strPageType == "06") {
                //    //技能
                //    $("#liSysskill a").addClass(" active");
                //    $("#li_Sysskill").addClass(" active show");
                //    //$("#ListTitle").html("当前论文相关的客观数据");
                //    this.hidSortvSysSkillBy = "updDate Desc";
                //    //$("#SysskillList").show();
                //    const responseObjList = await this.BindGv_vSysSkill();
                //}
                //else if (strPageType == "07") {
                //    //社会关系
                //    $("#liSysSocialRela a").addClass(" active");
                //    $("#li_SysSocialRela").addClass(" active show");
                //    this.hidSortvSysSocialRelationsBy = "fullName Asc";
                //    //$("#SysSocialList").show();
                //    const gvResult = await this.BindGv_vSysSocialRelations();
                //}
                //else {
                //}
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定观点html
        async BindList_vViewpoint(strUserTypeId, arrvViewpointObjLst, arrvRTViewpointRelaObjLst, arrUsers) {
            var strTitle = "";
            //判断页面参数
            if (strUserTypeId == "01") {
                strTitle = "个人观点";
            }
            else if (strUserTypeId == "02") {
                //专家观点
                //$("#ListTitle").html("当前论文相关的专家观点");
                strTitle = "专家观点";
            }
            var strhtml = "";
            //个人观点
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
            strhtml += '<div style="float:left;"><a href="#" title="当前论文相关' + strTitle + '">当前论文相关' + strTitle + '</a></div>';
            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrvViewpointObjLst.length; i++) {
                //得到viewpointId；
                var strViewpointId = arrvViewpointObjLst[i].viewpointId;
                v++;
                strhtml += '<div onclick=btnPdfPageNum_Click(' + arrvViewpointObjLst[i].pdfPageNum + ')>';
                //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointContent + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvViewpointObjLst[i].reason + '</span></li>';
                //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>点赞数:' + arrvViewpointObjLst[i].okCount + '&nbsp;&nbsp;';
                ////评论
                //strhtml += '&nbsp;&nbsp;评论数：' + arrvViewpointObjLst[i].appraiseCount;
                ////评分
                //strhtml += '&nbsp;&nbsp;综合评分:' + arrvViewpointObjLst[i].score;
                //strhtml += '&nbsp;&nbsp;教师评分:' + arrvViewpointObjLst[i].teaScore;
                //strhtml += '&nbsp;&nbsp;学生评分:' + arrvViewpointObjLst[i].stuScore;
                var objUser = arrUsers.find(x => x.userId == arrvViewpointObjLst[i].updUser);
                if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                }
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvViewpointObjLst[i].updDate;
                //引用数
                strhtml += '&nbsp;&nbsp;被引用数:' + arrvViewpointObjLst[i].citationCount;
                strhtml += '&nbsp;&nbsp;页码:' + arrvViewpointObjLst[i].pdfPageNum;
                var objRTV = arrvRTViewpointRelaObjLst.find(x => x.viewpointId == arrvViewpointObjLst[i].viewpointId);
                var strStata;
                if (objRTV == null) {
                    strhtml += '&nbsp;&nbsp;未引用本主题';
                    strhtml += '&nbsp;&nbsp;<button title="引用' + strTitle + '" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkInTab_Click("' + arrvViewpointObjLst[i].viewpointId + '")> <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;已引用本主题';
                }
                strhtml += '</li>';
                strhtml += '</div>';
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            return strhtml;
        }
        //绑定概念HTML
        async BindList_vConcept(arrvConceptObjLst, arrvRTConceptRelaObjLst) {
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            var strhtml = "";
            //相关概念
            strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';
            strhtml += '<div style="float:left;"><a href="#" title="当前论文相关概念">当前论文相关概念</a></div>';
            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrvConceptObjLst.length; i++) {
                //得到viewpointId；
                var strConceptId = arrvConceptObjLst[i].conceptId;
                v++;
                strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptContent + '</span></li>';
                var objUser = arrUsers.find(x => x.userId == arrvConceptObjLst[i].updUser);
                if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                }
                //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvConceptObjLst[i].userName;
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvConceptObjLst[i].updDate;
                //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
                ////评论
                //strhtml += '&nbsp;&nbsp;评论数:' + arrvConceptObjLst[i].appraiseCount;
                ////评分
                //strhtml += '&nbsp;&nbsp;综合评分:' + arrvConceptObjLst[i].score + '';
                //strhtml += '&nbsp;&nbsp;教师评分:' + arrvConceptObjLst[i].teaScore + '';
                //strhtml += '&nbsp;&nbsp;学生评分:' + arrvConceptObjLst[i].stuScore + '';
                //引用数
                strhtml += '&nbsp;&nbsp;被引用数:' + arrvConceptObjLst[i].citationCount;
                strhtml += '&nbsp;&nbsp;页码:' + arrvConceptObjLst[i].pdfPageNum;
                var objRTC = arrvRTConceptRelaObjLst.find(x => x.conceptId == arrvConceptObjLst[i].conceptId);
                var strStata;
                if (objRTC == null) {
                    strhtml += '&nbsp;&nbsp;未引用本主题';
                    strStata = 1;
                    strhtml += '&nbsp;&nbsp;<button title="引用该相关概念" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkConceptInTab_Click("' + arrvConceptObjLst[i].conceptId + '",' + strStata + ')> <i class="layui-icon" >&#xe642;</i>引用该相关概念</button>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;已引用本主题';
                    strStata = 2;
                }
                strhtml += '</li>';
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            //拼接；
            //$("#divConceptDataLst").html(strhtml);
            return strhtml;
        }
        //绑定客观HTML
        async BindList_vTopicObjective(strObjectiveTypeId, arrvTopicObjectiveObjLst, arrvRTTopicObjectiveRelaObjLst) {
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            var strTitle = "";
            //判断页面参数
            if (strObjectiveTypeId == "01") {
                strTitle = "客观事实";
            }
            else if (strObjectiveTypeId == "02") {
                //专家观点
                //$("#ListTitle").html("当前论文相关的专家观点");
                strTitle = "客观数据";
            }
            var strhtml = "";
            //个人观点
            strhtml += '<div class="info" id="infoFacts"><div class="title btn-5">';
            strhtml += '<div style="float:left;"><a href="#" title="当前论文相关' + strTitle + '">当前论文相关' + strTitle + '</a></div>';
            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
                //得到viewpointId；
                var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
                v++;
                strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveContent + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].conclusion + '</span></li>';
                //获取用户名；
                var objUser = arrUsers.find(x => x.userId == arrvTopicObjectiveObjLst[i].updUser);
                if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                }
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvTopicObjectiveObjLst[i].updDate;
                //引用数
                strhtml += '&nbsp;&nbsp;被引用数:' + arrvTopicObjectiveObjLst[i].citationCount;
                strhtml += '&nbsp;&nbsp;页码:' + arrvTopicObjectiveObjLst[i].pdfPageNum;
                var objRTT = arrvRTTopicObjectiveRelaObjLst.find(x => x.topicObjectiveId == arrvTopicObjectiveObjLst[i].topicObjectiveId);
                if (objRTT == null) {
                    strhtml += '&nbsp;&nbsp;未引用本主题';
                    strhtml += '&nbsp;&nbsp;<button title="引用该' + strTitle + '" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkObjectiveInTab_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '") > <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;已引用本主题';
                }
                strhtml += '</li>';
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            return strhtml;
        }
        //绑定技能HTML
        async BindList_vSysSkill(arrvSysSkillObjLst, arrvRTSysSkillObjLst) {
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            var strhtml = "";
            //相关技能
            strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';
            strhtml += '<div style="float:left;"><a href="#" title="当前论文相关技能">当前论文相关技能</a></div>';
            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关技能" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关技能</button></div>';
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrvSysSkillObjLst.length; i++) {
                //得到skillId；
                var strSkillId = arrvSysSkillObjLst[i].skillId;
                v++;
                strhtml += '<li><span class="rowtit color4">' + v + '.[技能]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].skillName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[实施过程]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].process + '</span></li>';
                //获取用户名；
                var objUser = arrUsers.find(x => x.userId == arrvSysSkillObjLst[i].updUser);
                if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑用户]：</span>' + objUser.userName;
                }
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvSysSkillObjLst[i].updDate;
                //引用数
                strhtml += '&nbsp;&nbsp;被引用数:' + arrvSysSkillObjLst[i].citationCount;
                strhtml += '&nbsp;&nbsp;页码:' + arrvSysSkillObjLst[i].pdfPageNum;
                var objRTC = arrvRTSysSkillObjLst.find(x => x.skillId == arrvSysSkillObjLst[i].skillId);
                var strStata;
                if (objRTC == null) {
                    strhtml += '&nbsp;&nbsp;未引用本主题';
                    strStata = 1;
                    strhtml += '&nbsp;&nbsp;<button title="引用该相关技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkSysskillInTab_Click("' + arrvSysSkillObjLst[i].skillId + '",' + strStata + ')> <i class="layui-icon" >&#xe642;</i>引用该相关技能</button>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;已引用本主题';
                    strStata = 2;
                }
                strhtml += '</li>';
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            return strhtml;
        }
        //绑定社会关系HTML
        async BindList_vSysSocialRelations(arrvSysSocialRelationsObjLst, arrvRTSysSocialRelaObjLst) {
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            var strhtml = "";
            //社会关系
            strhtml += '<div class="info" id="infoConcept"><div class="title btn-3">';
            strhtml += '<div style="float:left;"><a href="#" title="当前论文社会关系">当前论文社会关系</a></div>';
            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加社会关系" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加社会关系</button></div>';
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrvSysSocialRelationsObjLst.length; i++) {
                //得到socialId；
                var strSocialId = arrvSysSocialRelationsObjLst[i].socialId;
                v++;
                strhtml += '<li><span class="rowtit color3">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].fullName + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].nationality + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].workUnit + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].major + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].achievement + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].detailedDescription + '</span></li>';
                //获取用户名；
                var objUser = arrUsers.find(x => x.userId == arrvSysSocialRelationsObjLst[i].updUser);
                if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                }
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvSysSocialRelationsObjLst[i].updDate;
                //引用数
                strhtml += '&nbsp;&nbsp;被引用数:' + arrvSysSocialRelationsObjLst[i].citationCount;
                strhtml += '&nbsp;&nbsp;页码:' + arrvSysSocialRelationsObjLst[i].pdfPageNum;
                var objRTC = arrvRTSysSocialRelaObjLst.find(x => x.socialId == arrvSysSocialRelationsObjLst[i].socialId);
                var strStata;
                if (objRTC == null) {
                    strStata = 1;
                    strhtml += '&nbsp;&nbsp;未引用本主题';
                    strhtml += '&nbsp;&nbsp;<button title="引用该相关技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkSyssocialInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '",' + strStata + ')> <i class="layui-icon" >&#xe642;</i>引用该社会关系</button>';
                }
                else {
                    strStata = 2;
                    strhtml += '&nbsp;&nbsp;已引用本主题';
                }
                strhtml += '</li>';
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            return strhtml;
        }
        //绑定各个类型页面
        async BindPage() {
            try {
                //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
                var strPaperId = $("#ddlPaperId_q").val(); //论文
                //var strPageType = $("#hidPageType").val();//页面参数1
                var strPageType = $("#ddlVTypeId").val(); //页面参数2
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId; //存放主题Id
                var strPdfPageNum = $('#hidPdfPageNum').val(); //pdf页码
                var strId_CurrEduCls = $('#hidId_CurrEduCls').val(); //教学班
                var strhtml = "";
                //判断页面参数
                if (strPageType == "01") {
                    //个人观点
                    strhtml = "<iframe src='../GraduateEduPublicPage/AddViewpoint?paperId=" + strPaperId + "&userTypeId=01&topicId=" + strTopicId + "&pdfPageNum=" + strPdfPageNum + "&Id_CurrEduCls=" + strId_CurrEduCls + "' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                    $("#div_page").html(strhtml);
                }
                else if (strPageType == "02") {
                    //专家观点
                    strhtml = "<iframe src='../GraduateEduPublicPage/AddViewpoint?paperId=" + strPaperId + "&userTypeId=02&topicId=" + strTopicId + "&pdfPageNum=" + strPdfPageNum + "&Id_CurrEduCls=" + strId_CurrEduCls + "' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                    $("#div_page").html(strhtml);
                }
                else if (strPageType == "03") {
                    //概念
                    strhtml = "<iframe src=' ../GraduateEduPublicPage/AddConcept?paperId=" + strPaperId + "&topicId=" + strTopicId + "&pdfPageNum=" + strPdfPageNum + "&Id_CurrEduCls=" + strId_CurrEduCls + "' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                    $("#div_page").html(strhtml);
                }
                else if (strPageType == "04") {
                    //客观事实
                    strhtml = "<iframe src='../GraduateEduPublicPage/AddObjectiveFact?paperId=" + strPaperId + "&ObjectiveTypeId=01&topicId=" + strTopicId + "&pdfPageNum=" + strPdfPageNum + "&Id_CurrEduCls=" + strId_CurrEduCls + "' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                    $("#div_page").html(strhtml);
                }
                else if (strPageType == "05") {
                    //客观数据
                    strhtml = "<iframe src='../GraduateEduPublicPage/AddObjectiveFact?paperId=" + strPaperId + "&ObjectiveTypeId=02&topicId=" + strTopicId + "&pdfPageNum=" + strPdfPageNum + "&Id_CurrEduCls=" + strId_CurrEduCls + "' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                    $("#div_page").html(strhtml);
                }
                else if (strPageType == "06") {
                    //技能
                    var strhtml = "";
                    strhtml = "<iframe src='../GraduateEduPublicPage/AddSysskill?paperId=" + strPaperId + "&topicId=" + strTopicId + "&pdfPageNum=" + strPdfPageNum + "&Id_CurrEduCls=" + strId_CurrEduCls + "' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                    $("#div_page").html(strhtml);
                }
                else if (strPageType == "07") {
                    //社会关系
                    var strhtml = "";
                    strhtml = "<iframe src='../GraduateEduPublicPage/AddSysSocialRelations?paperId=" + strPaperId + "&topicId=" + strTopicId + "&pdfPageNum=" + strPdfPageNum + "&Id_CurrEduCls=" + strId_CurrEduCls + "' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                    $("#div_page").html(strhtml);
                }
                else {
                }
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //////////////////////////////////////////////////////////////////个人观点部分///////////////////////////////////////////////////////////////////
        /* 把所有的查询控件内容组合成一个条件串
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
           <returns>条件串(strWhereCond)</returns>
         */
        async CombinevViewpointCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strViewpointId = $("#hidViewpointId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //根据传入的usertypeId 来区分是本人观点还是专家观点
                var strhidUserTypeId = $("#hidUserTypeId").val();
                if (strhidUserTypeId != "") {
                    strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_UserTypeId} = '${strhidUserTypeId}'`;
                }
                var strPaperId = $("#ddlPaperId_q").val();
                if (strPaperId != "0") {
                    strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_CitationId} = '${strPaperId}'`;
                }
                //只能查询提交的观点数据
                //strWhereCond += ` And ${clsvViewpointEN.con_IsSubmit} = 'true'`;
                //排除获取已存在的关系数据 根据当前用户；
                //strWhereCond += ` And viewpointId not in (select viewpointId from RTViewpointRela where topicId = '${strTopicId}')`;
                //strWhereCond += ` And viewpointId not in (select viewpointId from RTViewpointRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vViewpoint_pyf(strUserTypeId) {
            $("#hidUserTypeId").val(strUserTypeId);
            var strListDiv = this.mstrListDivViewpoint;
            var strWhereCond = await this.CombinevViewpointCondition();
            var strWhereCond2 = "1=1 and userTypeId='" + strUserTypeId + "' and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvViewpointObjLst = [];
            var arrvRTViewpointRelaObjLst = [];
            //获取用户缓存；
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            try {
                this.recCount = await (0, clsvViewpointWApi_js_1.vViewpoint_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvViewpointBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvViewpointObjLst = jsonData;
                });
                const responseObjLst2 = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvRTViewpointRelaObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvViewpointObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                var strPageType = $("#hidPageType").val(); //页面参数
                var strTitle = "";
                //判断页面参数
                if (strUserTypeId == "01") {
                    strTitle = "个人观点";
                }
                else if (strUserTypeId == "02") {
                    //专家观点
                    //$("#ListTitle").html("当前论文相关的专家观点");
                    strTitle = "专家观点";
                }
                var strhtml = "";
                //个人观点
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                strhtml += '<div style="float:left;"><a href="#" title="当前论文相关' + strTitle + '">当前论文相关' + strTitle + '</a></div>';
                strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvViewpointObjLst.length; i++) {
                    //得到viewpointId；
                    var strViewpointId = arrvViewpointObjLst[i].viewpointId;
                    v++;
                    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                    strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointContent + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvViewpointObjLst[i].reason + '</span></li>';
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>点赞数:' + arrvViewpointObjLst[i].okCount + '&nbsp;&nbsp;';
                    ////评论
                    //strhtml += '&nbsp;&nbsp;评论数：' + arrvViewpointObjLst[i].appraiseCount;
                    ////评分
                    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvViewpointObjLst[i].score;
                    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvViewpointObjLst[i].teaScore;
                    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvViewpointObjLst[i].stuScore;
                    var objUser = arrUsers.find(x => x.userId == arrvViewpointObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvViewpointObjLst[i].updDate;
                    //引用数
                    strhtml += '&nbsp;&nbsp;被引用数:' + arrvViewpointObjLst[i].citationCount;
                    var objRTV = arrvRTViewpointRelaObjLst.find(x => x.viewpointId == arrvViewpointObjLst[i].viewpointId);
                    var strStata;
                    if (objRTV == null) {
                        strhtml += '&nbsp;&nbsp;未引用本主题';
                        strhtml += '&nbsp;&nbsp;<button title="引用' + strTitle + '" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkInTab_Click("' + arrvViewpointObjLst[i].viewpointId + '")> <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;已引用本主题';
                    }
                    strhtml += '</li>';
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                if (strUserTypeId == "01") {
                    $("#divViewpointDataLst").html(strhtml);
                }
                else if (strUserTypeId == "02") {
                    //专家观点
                    $("#divViewpointDataLst2").html(strhtml);
                }
                if (arrvViewpointObjLst.length > 10) {
                    $("#divPager1").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                //this.BindTab_vViewpoint(strListDiv, arrvViewpointObjLst);
                console.log("完成BindGv_vViewpoint!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:在数据 列表中跳转到某一页 观点列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
      <param name = "intPageIndex">页序号</param>
    */
        // public IndexPageOne(intPageIndex) {
        //     if (intPageIndex == 0) {
        //         intPageIndex = this.objPager.pageCount;
        //     }
        //     console.log("跳转到" + intPageIndex + "页");
        //     this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //     this.BindGv_vViewpoint();
        // }
        // /* 观点 个人 专家
        //*/
        // public async SortByViewpoint(strSortByFld: string) {
        //     if (this.hidSortvViewpointBy.indexOf(strSortByFld) >= 0) {
        //         if (this.hidSortvViewpointBy.indexOf("Asc") >= 0) {
        //             this.hidSortvViewpointBy = `${strSortByFld} Desc`;
        //         }
        //         else {
        //             this.hidSortvViewpointBy = `${strSortByFld} Asc`;
        //         }
        //     }
        //     else {
        //         this.hidSortvViewpointBy = `${strSortByFld} Asc`;
        //     }
        //     const responseText2 = await this.BindGv_vViewpoint();
        // }
        //添加观点 展示观点列表数据
        //public async btnAddRela_Click() {
        //    const responseObjList = await this.BindGv_vViewpoint();
        //}
        //确定选择的观点 并添加到关系表中
        btnOkInTab_Click(strkeyId) {
            //存放Id
            $("#hidViewpointId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSaveViewpointRela();
        }
        /* 添加新记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
     */
        async AddNewRecordSaveViewpointRela() {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strViewpointId = $("#hidViewpointId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objRTViewpointRelaEN = new clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN();
            this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);
            try {
                //同一用户，同一主题 同一观点 只能添加一次；
                //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId + "'";
                ////var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
                //const responseText = await RTViewpointRela_IsExistRecordAsync(strWhere);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `同一主题不能重复添加同一个观点！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_AddNewRecordAsync)(objRTViewpointRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加成功!`;
                    $('#lblResult40').val(strInfo);
                    //HideDialogTwo();
                    //显示信息框
                    alert(strInfo);
                    $('#div_list').show();
                    $('#div_page').hide();
                    if ($("#ddlVTypeId").val() == "01") {
                        this.BindGv_vViewpoint_pyf("01");
                    }
                    else {
                        this.BindGv_vViewpoint_pyf("02");
                    }
                    CloseWindow_();
                    //CloseWindow();
                    //绑定专家关系列表； 
                    //this.BindGv_vRTExpertViewpointRela();
                    //主题Id
                    // window.location.href = "../GraduateEdu/ResearchTopicAdd?TopicRelaId" + strTopicId;
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
       <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
     */
        PutDataToRTViewpointRelaClass(pobjRTViewpointRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strViewpointId = $("#hidViewpointId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjRTViewpointRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTViewpointRelaEN.SetViewpointId(strViewpointId); // 观点Id
            pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTViewpointRelaEN.SetUpdUser(strUserId); // 修改用户Id// 修改用户Id
            //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
        }
        ////////////////////////////////////////////////////////////////////////相关概念/////////////////////////////////////////////////////////////
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombineConceptCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strConceptId = $("#hidConceptId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objConcept_Cond = new clsConceptEN_js_1.clsConceptEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.conceptName_q != "") {
                //    strWhereCond += ` And ${clsConceptEN.con_ConceptName} like '% ${this.conceptName_q}%'`;
                //    objConcept_Cond.SetCondFldValue(clsConceptEN.con_ConceptName, this.conceptName_q, "like");
                //}
                //if (this.IsSubmit_q == true) {
                //    strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = '1'`;
                //    objConcept_Cond.SetCondFldValue(clsConceptEN.con_IsSubmit, true, "=");
                //}
                //else {
                //    strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = '0'`;
                //    objConcept_Cond.SetCondFldValue(clsConceptEN.con_IsSubmit, false, "=");
                //}
                var strPaperId = $("#ddlPaperId_q").val();
                if (strPaperId != "0") {
                    strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_CitationId} = '${strPaperId}'`;
                }
                //只能查询提交的概念数据
                //strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = 'true'`;
                //排除获取已存在的关系数据 根据当前用户；
                //strWhereCond += ` And conceptId not in (select conceptId from RTConceptRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
                //strWhereCond += ` And conceptId not in (select conceptId from RTConceptRela where topicId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
    */
        async BindGv_Concept() {
            var strListDiv = this.mstrListDivPaper;
            var strWhereCond = await this.CombineConceptCondition();
            var strWhereCond2 = "1=1 and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
            // var strWhereCond = JSON.stringify(objConceptEN_Sim);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvConceptObjLst = [];
            var arrvRTConceptRelaObjLst = [];
            var arrUsers = [];
            try {
                //this.recCount = Concept_GetRecCountByCond(objConcept_Cond);
                this.recCount = await (0, clsvConceptWApi_js_1.vConcept_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: ConceptCRUD_js_1.ConceptCRUD.sortConceptBy,
                    sortFun: (x, y) => { return 0; }
                };
                //  var arrConceptObjLst = Concept_GetObjLstByPager_Cache(objPagerPara);
                const responseObjLst = await (0, clsvConceptWApi_js_1.vConcept_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvConceptObjLst = jsonData;
                });
                const responseObjLst2 = await (0, clsvRTConceptRelaWApi_js_1.vRTConceptRela_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvRTConceptRelaObjLst = jsonData;
                });
                arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrConceptObjLst.length == 0) {
            //    var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=Concept)`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                var strhtml = "";
                //相关概念
                strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';
                strhtml += '<div style="float:left;"><a href="#" title="当前论文相关概念">当前论文相关概念</a></div>';
                strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvConceptObjLst.length; i++) {
                    //得到viewpointId；
                    var strConceptId = arrvConceptObjLst[i].conceptId;
                    v++;
                    strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptContent + '</span></li>';
                    var objUser = arrUsers.find(x => x.userId == arrvConceptObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvConceptObjLst[i].userName;
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvConceptObjLst[i].updDate;
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
                    ////评论
                    //strhtml += '&nbsp;&nbsp;评论数:' + arrvConceptObjLst[i].appraiseCount;
                    ////评分
                    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvConceptObjLst[i].score + '';
                    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvConceptObjLst[i].teaScore + '';
                    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvConceptObjLst[i].stuScore + '';
                    //引用数
                    strhtml += '&nbsp;&nbsp;被引用数:' + arrvConceptObjLst[i].citationCount;
                    var objRTC = arrvRTConceptRelaObjLst.find(x => x.conceptId == arrvConceptObjLst[i].conceptId);
                    var strStata;
                    if (objRTC == null) {
                        strhtml += '&nbsp;&nbsp;未引用本主题';
                        strStata = 1;
                        strhtml += '&nbsp;&nbsp;<button title="引用该相关概念" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkConceptInTab_Click("' + arrvConceptObjLst[i].conceptId + '",' + strStata + ')> <i class="layui-icon" >&#xe642;</i>引用该相关概念</button>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;已引用本主题';
                        strStata = 2;
                    }
                    strhtml += '</li>';
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divConceptDataLst").html(strhtml);
                if (arrvConceptObjLst.length > 10) {
                    $("#divPager2").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                //this.BindTab_Concept(strListDiv, arrConceptObjLst);
                console.log("完成BindGv_Concept!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 概念
      */
        async SortByConcept(strSortByFld) {
            if (ConceptCRUD_js_1.ConceptCRUD.sortConceptBy.indexOf(strSortByFld) >= 0) {
                if (ConceptCRUD_js_1.ConceptCRUD.sortConceptBy.indexOf("Asc") >= 0) {
                    ConceptCRUD_js_1.ConceptCRUD.sortConceptBy = `${strSortByFld} Desc`;
                }
                else {
                    ConceptCRUD_js_1.ConceptCRUD.sortConceptBy = `${strSortByFld} Asc`;
                }
            }
            else {
                ConceptCRUD_js_1.ConceptCRUD.sortConceptBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = this.BindGv_Concept();
        }
        //分页数据
        /* 函数功能:在数据 列表中跳转到某一页 观点列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
    */
        IndexPageTwo(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            //this.SetCurrPageIndex(intPageIndex, this.divName4Pager);
            this.SetCurrPageIndex(intPageIndex);
            this.BindGv_Concept();
        }
        //添加观点 展示观点列表数据
        async btnAddConceptRela_Click() {
            const responseObjList = await this.BindGv_Concept();
        }
        //确定选择的观点 并添加到关系表中
        btnOkConceptInTab_Click(strkeyId) {
            //存放Id
            $("#hidConceptId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSave2();
        }
        /* 添加新记录，保存函数
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSave2() {
            //this.DivName = "divAddNewRecordSave";
            var objRTConceptRelaEN = new clsRTConceptRelaEN_js_1.clsRTConceptRelaEN();
            this.PutDataToRTConceptRelaClass(objRTConceptRelaEN);
            try {
                const responseText2 = await (0, clsRTConceptRelaWApi_js_1.RTConceptRela_AddNewRecordAsync)(objRTConceptRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    this.BindGv_Concept();
                    $('#div_list').show();
                    $('#div_page').hide();
                    var strInfo = `添加记录成功!`;
                    //显示信息框
                    alert(strInfo);
                    CloseWindow_();
                    //CloseWindow();
                }
                else {
                    var strInfo = `添加记录不成功!`;
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
         <param name = "pobjRTConceptRelaEN">数据传输的目的类对象</param>
       */
        PutDataToRTConceptRelaClass(pobjRTConceptRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strConceptId = $("#hidConceptId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjRTConceptRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTConceptRelaEN.SetConceptId(strConceptId); // 概念Id
            pobjRTConceptRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTConceptRelaEN.SetUpdUser(strUserId); // 修改用户Id
            //pobjRTConceptRelaEN.SetMemo(this.memo;// 备注
        }
        ///////////////////////////////////////////////////////////////////客观数据事实////////////////////////////////////////////////////////////
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        async CombinevTopicObjectiveCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.objectiveName_q != "") {
                //    strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveName} like '% ${this.objectiveName_q}%'`;
                //}
                //根据类型来查询；
                //根据传入的hidObjectiveTypeId 来区分是事实或依据
                var strhidObjectvieTypeId = $("#hidObjectiveTypeId").val();
                if (strhidObjectvieTypeId != "") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectvieTypeId}'`;
                }
                var strPaperId = $("#ddlPaperId_q").val();
                if (strPaperId != "0") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_SourceId} = '${strPaperId}'`;
                }
                //只能查询提交的客观数据
                //strWhereCond += ` And ${clsvTopicObjectiveEN.con_IsSubmit} = 'true'`;
                //排除获取已存在的关系数据 根据当前用户；
                //strWhereCond += ` And topicObjectiveId not in (select topicObjectiveId from vRTTopicObjectiveRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
                //strWhereCond += ` And topicObjectiveId not in (select topicObjectiveId from vRTTopicObjectiveRela where topicId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineTopicObjectiveCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vTopicObjective(strObjectiveTypeId) {
            $("#hidObjectiveTypeId").val(strObjectiveTypeId);
            var strListDiv = this.mstrListDivObjective;
            var strWhereCond = await this.CombinevTopicObjectiveCondition();
            var strWhereCond2 = "1=1 and objectiveType='" + strObjectiveTypeId + "' and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvTopicObjectiveObjLst = [];
            var arrvRTTopicObjectiveRelaObjLst = [];
            try {
                this.recCount = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: TopicObjectiveCRUD_js_1.TopicObjectiveCRUD.sortvTopicObjectiveBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvTopicObjectiveObjLst = jsonData;
                });
                const responseObjLst2 = await (0, clsvRTTopicObjectiveRelaWApi_js_1.vRTTopicObjectiveRela_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvRTTopicObjectiveRelaObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvTopicObjectiveObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                //this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                //var strPageType = $("#hidPageType").val();//页面参数
                var strTitle = "";
                //判断页面参数
                if (strObjectiveTypeId == "01") {
                    strTitle = "客观事实";
                }
                else if (strObjectiveTypeId == "02") {
                    //专家观点
                    //$("#ListTitle").html("当前论文相关的专家观点");
                    strTitle = "客观数据";
                }
                var strhtml = "";
                //个人观点
                strhtml += '<div class="info" id="infoFacts"><div class="title btn-5">';
                strhtml += '<div style="float:left;"><a href="#" title="当前论文相关' + strTitle + '">当前论文相关' + strTitle + '</a></div>';
                strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
                    //得到viewpointId；
                    var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
                    v++;
                    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                    strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveContent + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].conclusion + '</span></li>';
                    //获取用户名；
                    var objUser = arrUsers.find(x => x.userId == arrvTopicObjectiveObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvTopicObjectiveObjLst[i].updDate;
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
                    ////评论
                    //strhtml += '&nbsp;&nbsp;评论数:' + arrvTopicObjectiveObjLst[i].appraiseCount;
                    ////评分
                    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvTopicObjectiveObjLst[i].score + '';
                    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvTopicObjectiveObjLst[i].teaScore + '';
                    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvTopicObjectiveObjLst[i].stuScore + '';
                    //引用数
                    strhtml += '&nbsp;&nbsp;被引用数:' + arrvTopicObjectiveObjLst[i].citationCount;
                    var objRTT = arrvRTTopicObjectiveRelaObjLst.find(x => x.topicObjectiveId == arrvTopicObjectiveObjLst[i].topicObjectiveId);
                    if (objRTT == null) {
                        strhtml += '&nbsp;&nbsp;未引用本主题';
                        strhtml += '&nbsp;&nbsp;<button title="引用该' + strTitle + '" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkObjectiveInTab_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '") > <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;已引用本主题';
                    }
                    strhtml += '</li>';
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                if (strObjectiveTypeId == "01") {
                    $("#divObjectiveDataLst").html(strhtml);
                }
                else if (strObjectiveTypeId == "02") {
                    //专家观点
                    $("#divObjectiveDataLst2").html(strhtml);
                }
                if (arrvTopicObjectiveObjLst.length > 10) {
                    $("#divPager3").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                console.log("完成BindGv_vTopicObjective!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //客观查询按钮
        //public async btnQueryObjective_Click() {
        //    //查询客观列表
        //    const responseObjList = await this.BindGv_vTopicObjective();
        //}
        //分页数据
        /* 函数功能:在数据 列表中跳转到某一页 观点列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
    */
        //public IndexPageThree(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.pageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //    this.BindGv_vTopicObjective();
        //}
        //添加客观关系弹出客观列表按钮
        //public async btnAddTopicObjectiveRela_Click() {
        //    const responseObjList = await this.BindGv_vTopicObjective();
        //}
        //确定选择的客观观点 并添加到关系表中
        btnOkObjectiveInTab_Click(strkeyId) {
            //存放Id
            $("#hidObjectiveId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSave3();
        }
        /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSave3() {
            //this.DivName = "divAddNewRecordSave";
            var objRTTopicObjectiveRelaEN = new clsRTTopicObjectiveRelaEN_js_1.clsRTTopicObjectiveRelaEN();
            this.PutDataToRTTopicObjectiveRelaClass(objRTTopicObjectiveRelaEN);
            try {
                const responseText2 = await (0, clsRTTopicObjectiveRelaWApi_js_1.RTTopicObjectiveRela_AddNewRecordAsync)(objRTTopicObjectiveRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#div_list').show();
                    $('#div_page').hide();
                    if ($("#ddlVTypeId").val() == "04") {
                        this.BindGv_vTopicObjective("01");
                    }
                    else if ($("#ddlVTypeId").val() == "05") {
                        this.BindGv_vTopicObjective("02");
                    }
                    //显示信息框
                    alert(strInfo);
                    CloseWindow_();
                    //CloseWindow();
                    //HideDialogEight();
                }
                else {
                    var strInfo = `添加记录不成功!`;
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
     <param name = "pobjRTTopicObjectiveRelaEN">数据传输的目的类对象</param>
    */
        PutDataToRTTopicObjectiveRelaClass(pobjRTTopicObjectiveRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strObjectiveId = $("#hidObjectiveId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjRTTopicObjectiveRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTTopicObjectiveRelaEN.SetTopicObjectiveId(strObjectiveId); // 客观Id
            pobjRTTopicObjectiveRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTTopicObjectiveRelaEN.SetUpdUser(strUserId); // 修改人
            //pobjRTTopicObjectiveRelaEN.SetMemo(this.memo;// 备注
        }
        //public async SortByObjectiveFact(strSortByFld: string) {
        //    if (TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf(strSortByFld) >= 0) {
        //        if (TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf("Asc") >= 0) {
        //            TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Desc`;
        //        }
        //        else {
        //            TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
        //        }
        //    }
        //    else {
        //        TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
        //    }
        //    const responseBindGv = await this.BindGv_vTopicObjective();
        //}
        //////////////////////////////////////////////////////////////////////////////////////技能、、、、、、、、、、、、、、、、、、、、、、、、、、、、、、、、、
        /*
     * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvSysSkillBy(value) {
            $("#hidSortvSysSkillBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvSysSkillBy() {
            return $("#hidSortvSysSkillBy").val();
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        async CombinevSysSkillCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                var strPaperId = $("#ddlPaperId_q").val();
                if (strPaperId != "0") {
                    strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_CitationId} = '${strPaperId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysSkillCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vSysSkill() {
            //  var strListDiv: string = this.mstrListDiv;
            var strWhereCond = await this.CombinevSysSkillCondition();
            var strWhereCond2 = "1=1 and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvSysSkillObjLst = [];
            var arrvRTSysSkillObjLst = [];
            try {
                this.recCount = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysSkillBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvSysSkillObjLst = jsonData;
                });
                const responseObjLst2 = await (0, clsvRTSysSkillWApi_js_1.vRTSysSkill_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvRTSysSkillObjLst = jsonData;
                });
                var strhtml = "";
                //相关技能
                strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';
                strhtml += '<div style="float:left;"><a href="#" title="当前论文相关技能">当前论文相关技能</a></div>';
                strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关技能" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关技能</button></div>';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvSysSkillObjLst.length; i++) {
                    //得到skillId；
                    var strSkillId = arrvSysSkillObjLst[i].skillId;
                    v++;
                    strhtml += '<li><span class="rowtit color4">' + v + '.[技能]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].skillName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[实施过程]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].process + '</span></li>';
                    //获取用户名称；根据id；
                    var arrUsers = await (0, clsUsersWApi_js_1.Users_GetObjLstAsync)("1=1");
                    //获取用户名；
                    arrUsers = arrUsers.filter(x => x.userId == arrvSysSkillObjLst[i].updUser); //专家观点；
                    for (var j = 0; j < arrUsers.length; j++) {
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrUsers[j].userName + '</span>';
                        break;
                    }
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvSysSkillObjLst[i].userName;
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvSysSkillObjLst[i].updDate;
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
                    ////评论
                    //strhtml += '&nbsp;&nbsp;评论数:' + arrvConceptObjLst[i].appraiseCount;
                    ////评分
                    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvConceptObjLst[i].score + '';
                    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvConceptObjLst[i].teaScore + '';
                    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvConceptObjLst[i].stuScore + '';
                    //引用数
                    strhtml += '&nbsp;&nbsp;被引用数:' + arrvSysSkillObjLst[i].citationCount;
                    var objRTC = arrvRTSysSkillObjLst.find(x => x.skillId == arrvSysSkillObjLst[i].skillId);
                    var strStata;
                    if (objRTC == null) {
                        strhtml += '&nbsp;&nbsp;未引用本主题';
                        strStata = 1;
                        strhtml += '&nbsp;&nbsp;<button title="引用该相关技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkSysskillInTab_Click("' + arrvSysSkillObjLst[i].skillId + '",' + strStata + ')> <i class="layui-icon" >&#xe642;</i>引用该相关技能</button>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;已引用本主题';
                        strStata = 2;
                    }
                    strhtml += '</li>';
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divSysskillDataLst").html(strhtml);
                if (this.recCount >= 10) {
                    $("#divPager").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
        }
        //确定选择的观点 并添加到关系表中
        btnOkSysskillInTab_Click(strkeyId) {
            //存放Id
            $("#hidSkillId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSaveRtSysskill();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjRTSysSkillRelaEN">数据传输的目的类对象</param>
    */
        PutDataToRTSysSkillRelaClass(pobjRTSysSkillRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strSkillId = $("#hidSkillId").val();
            pobjRTSysSkillRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTSysSkillRelaEN.SetSkillId(strSkillId); // 技能Id
            pobjRTSysSkillRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTSysSkillRelaEN.SetUpdUser(strUserId);
            pobjRTSysSkillRelaEN.SetMemo("pdf添加模块"); // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSaveRtSysskill() {
            const strThisFuncName = this.AddNewRecordSaveRtSysskill.name;
            // this.DivName = "divAddNewRecordSave";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strSkillId = $("#hidSkillId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
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
                        //根据ID获取最大数；
                        var strWhereCond2 = " 1 =1 and skillId=" + strSkillId;
                        var intCitationCount = await (0, clsRTSysSkillRelaWApi_js_1.RTSysSkillRela_GetRecCountByCondAsync)(strWhereCond2);
                        var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
                        objSysSkillEN.SetSkillId(strSkillId);
                        objSysSkillEN.SetCitationCount(intCitationCount);
                        objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                            throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
        ////////////////////////////////////////////////////////////////////////社会关系----------------、、、、、、、、、、、////////////////////////////
        /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vSysSocialRelations() {
            // var strListDiv: string = this.mstrListDiv;
            var strWhereCond = await this.CombinevSysSocialRelationsCondition();
            var strWhereCond2 = "1=1 and topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvSysSocialRelationsObjLst = [];
            var arrvRTSysSocialRelaObjLst = [];
            try {
                this.recCount = await (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysSocialRelationsBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvSysSocialRelationsObjLst = jsonData;
                });
                const responseObjLst2 = await (0, clsvRTSysSocialRelaWApi_js_1.vRTSysSocialRela_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvRTSysSocialRelaObjLst = jsonData;
                });
                var strhtml = "";
                //社会关系
                strhtml += '<div class="info" id="infoConcept"><div class="title btn-3">';
                strhtml += '<div style="float:left;"><a href="#" title="当前论文社会关系">当前论文社会关系</a></div>';
                strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加社会关系" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加社会关系</button></div>';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvSysSocialRelationsObjLst.length; i++) {
                    //得到socialId；
                    var strSocialId = arrvSysSocialRelationsObjLst[i].socialId;
                    v++;
                    strhtml += '<li><span class="rowtit color3">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].fullName + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].nationality + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].workUnit + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].major + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].achievement + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].detailedDescription + '</span></li>';
                    //获取用户名称；根据id；
                    var arrUsers = await (0, clsUsersWApi_js_1.Users_GetObjLstAsync)("1=1");
                    //获取用户名；
                    arrUsers = arrUsers.filter(x => x.userId == arrvSysSocialRelationsObjLst[i].updUser); //专家观点；
                    for (var j = 0; j < arrUsers.length; j++) {
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrUsers[j].userName + '</span>';
                        break;
                    }
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvSysSocialRelationsObjLst[i].userName;
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvSysSocialRelationsObjLst[i].updDate;
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
                    ////评论
                    //strhtml += '&nbsp;&nbsp;评论数:' + arrvConceptObjLst[i].appraiseCount;
                    ////评分
                    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvConceptObjLst[i].score + '';
                    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvConceptObjLst[i].teaScore + '';
                    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvConceptObjLst[i].stuScore + '';
                    //引用数
                    strhtml += '&nbsp;&nbsp;被引用数:' + arrvSysSocialRelationsObjLst[i].citationCount;
                    var objRTC = arrvRTSysSocialRelaObjLst.find(x => x.socialId == arrvSysSocialRelationsObjLst[i].socialId);
                    var strStata;
                    if (objRTC == null) {
                        strhtml += '&nbsp;&nbsp;未引用本主题';
                        strStata = 1;
                        strhtml += '&nbsp;&nbsp;<button title="引用该相关技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkSyssocialInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '",' + strStata + ')> <i class="layui-icon" >&#xe642;</i>引用该社会关系</button>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;已引用本主题';
                        strStata = 2;
                    }
                    strhtml += '</li>';
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divSysSocialDataLst").html(strhtml);
                if (this.recCount >= 10) {
                    $("#divPager").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvSysSocialRelationsObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            //try {
            //    this.BindTab_vSysSocialRelations(strListDiv, arrvSysSocialRelationsObjLst);
            //    console.log("完成BindGv_vSysSocialRelations!");
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            //    alert(strMsg);
            //}
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevSysSocialRelationsCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                var strPaperId = $("#ddlPaperId_q").val();
                if (strPaperId != "0") {
                    strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationId} = '${strPaperId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysSocialRelationsCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
         * 设置排序字段-相当使用ViewState功能
        */
        set hidSortvSysSocialRelationsBy(value) {
            $("#hidSortvSysSocialRelationsBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvSysSocialRelationsBy() {
            return $("#hidSortvSysSocialRelationsBy").val();
        }
        //确定选择的观点 并添加到关系表中
        btnOkSyssocialInTab_Click(strkeyId) {
            //存放Id
            $("#hidSocialId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSaveRtSyssocial();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjRTSysSkillRelaEN">数据传输的目的类对象</param>
    */
        PutDataToRTSyssocialRelaClass(pobjRTSysSocialRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strSocialId = $("#hidSocialId").val();
            pobjRTSysSocialRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTSysSocialRelaEN.SetSocialId(strSocialId); // 社会Id
            pobjRTSysSocialRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTSysSocialRelaEN.SetUpdUser(strUserId); // 修改人
            pobjRTSysSocialRelaEN.SetMemo("pdf社会关系"); // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSaveRtSyssocial() {
            const strThisFuncName = this.AddNewRecordSaveRtSyssocial.name;
            // this.DivName = "divAddNewRecordSave";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strSocialId = $("#hidSocialId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objRTSysSocialRelaEN = new clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN();
            this.PutDataToRTSyssocialRelaClass(objRTSysSocialRelaEN);
            try {
                //同一用户，同一主题 同一技能 只能添加一次；
                //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And socialId = '" + strSocialId + "' And updUser = '" + strUserId + "'";
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And socialId = '" + strSocialId + "'";
                const responseText = await (0, clsRTSysSocialRelaWApi_js_1.RTSysSocialRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题不能重复添加同一个社会关系！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                else {
                    const responseText2 = await (0, clsRTSysSocialRelaWApi_js_1.RTSysSocialRela_AddNewRecordAsync)(objRTSysSocialRelaEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = `添加记录成功!`;
                        //根据ID获取最大数；
                        var strWhereCond2 = " 1 =1 and socialId=" + strSocialId;
                        var intCitationCount = await (0, clsRTSysSocialRelaWApi_js_1.RTSysSocialRela_GetRecCountByCondAsync)(strWhereCond2);
                        var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
                        objSysSocialRelationsEN.SetSocialId(strSocialId);
                        objSysSocialRelationsEN.SetCitationCount(intCitationCount);
                        objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                            throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                        }
                        const responseText = await (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_UpdateRecordAsync)(objSysSocialRelationsEN).then((jsonData) => {
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
        //////////////////////////////////////////////////////////////////////////////////////////
        /*
        * 获取当前页序号
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        ////////////////////////////////////////////////观点///////////////////////////////////////////////
        /*
    * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvViewpointBy(value) {
            $("#hidSortvViewpointBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvViewpointBy() {
            return $("#hidSortvViewpointBy").val();
        }
        /////////////////////////////////////////////概念//////////////////////////////////////////////////
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortConceptBy(value) {
            $("#hidSortConceptBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortConceptBy() {
            return $("#hidSortConceptBy").val();
        }
        /////////////////////////////////////////////客观//////////////////////////////////////////////////
        /*
     * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvTopicObjectiveBy(value) {
            $("#hidSortvTopicObjectiveBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvTopicObjectiveBy() {
            return $("#hidSortvTopicObjectiveBy").val();
        }
    }
    exports.Pdfiframe = Pdfiframe;
});
