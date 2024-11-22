(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEdu/clsViewpointScoreEN.js", "../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js", "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js", "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js", "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointLikeLogEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js", "../TS/L0_Entity/InteractManage/clsSysVoteEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersEN.js", "../TS/L3_ForWApi/GraduateEdu/clsViewpointScoreWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsConceptAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clske_SubWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clske_SuperWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointLikeLogWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTConceptRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTTopicObjectiveRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTopic/clsResearchTopicExWApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../GraduateEduPublicPage/Pub_PaperList.js", "../GraduateEduPublicPage/Pub_QxUsersList.js", "../GraduateEduPublicPage/Pub_RTPaperRelaList.js", "../GraduateEduPublicPage/Pub_RTUserRelaList.js", "../GraduateEduPublicPage/Pub_RTViewpointRelaList.js", "../GraduateEduPublicPage/Pub_ViewpointList.js", "../PagesBase/GraduateEduTopic/ResearchTopic_Edit.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.KnowledgeEconomyListEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:ResearchTopicListEx
    表名:ResearchTopic(01120546)
    生成代码版本:2019.12.06.1
    生成日期:2019/12/27 10:59:12
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
    //
    //import * as QQ from "q";
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    //import { clsvViewpointAppraiseEN } from "../TS/L0_Entity/GraduateEdu/clsvViewpointAppraiseEN.js";
    //import { clsvViewpointAppraiseWApi } from "../TS/L3_ForWApi/GraduateEdu/clsvViewpointAppraiseWApi.js";
    //import { clsViewpointAppraiseEN } from "../TS/L0_Entity/GraduateEdu/clsViewpointAppraiseEN.js";
    //import { clsViewpointAppraiseWApi } from "../TS/L3_ForWApi/GraduateEdu/clsViewpointAppraiseWApi.js";
    const clsViewpointScoreEN_js_1 = require("../TS/L0_Entity/GraduateEdu/clsViewpointScoreEN.js");
    //import { clsSysCommentWApi } from "../TS/L3_ForWApi/GraduateEdu/clsSysCommentWApi.js";
    const clsSysCommentEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js");
    const clsConceptEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js");
    const clsResearchTopicEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js");
    const clsRTPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js");
    const clsRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js");
    const clsRTViewpointRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js");
    const clsSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js");
    const clsSysSocialRelationsEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js");
    const clsTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js");
    const clsViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js");
    const clsViewpointLikeLogEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointLikeLogEN.js");
    const clsvRTConceptRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js");
    const clsvRTPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js");
    const clsvRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js");
    const clsvRTViewpointRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js");
    const clsSysVoteEN_js_1 = require("../TS/L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsTopicUserRoleEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js");
    const clsvUsersEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersEN.js");
    const clsViewpointScoreWApi_js_1 = require("../TS/L3_ForWApi/GraduateEdu/clsViewpointScoreWApi.js");
    const clsvSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js");
    const clsConceptAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsConceptAttachmentWApi.js");
    const clsConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js");
    const clske_SubWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clske_SubWApi.js");
    const clske_SuperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clske_SuperWApi.js");
    const clsObjectiveAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js");
    const clsResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsRTPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js");
    const clsRTUserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js");
    const clsRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js");
    const clsSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js");
    const clsSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js");
    const clsTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js");
    const clsViewpointAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js");
    const clsViewpointLikeLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointLikeLogWApi.js");
    const clsViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js");
    const clsvRTConceptRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTConceptRelaWApi.js");
    const clsvRTSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSkillWApi.js");
    const clsvRTSysSocialRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js");
    const clsvRTTopicObjectiveRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTTopicObjectiveRelaWApi.js");
    const clsvRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsTopicUserRoleWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsvQxUserRoleRelationWApi_js_1 = require("../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js");
    const clsSysCommentExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js");
    const clsResearchTopicExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTopic/clsResearchTopicExWApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    //import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
    //import { clsRTPaperRelaBL } from "../TS/L2_BLL/GraduateEdu/clsRTPaperRelaBL.js";
    //import { clsvRTViewpointRelaBL } from "../TS/L2_BLL/GraduateEdu/clsvRTViewpointRelaBL.js";
    //import { clsvConceptBL } from "../TS/L2_BLL/GraduateEdu/clsvConceptBL.js";
    const Pub_PaperList_js_1 = require("../GraduateEduPublicPage/Pub_PaperList.js");
    const Pub_QxUsersList_js_1 = require("../GraduateEduPublicPage/Pub_QxUsersList.js");
    const Pub_RTPaperRelaList_js_1 = require("../GraduateEduPublicPage/Pub_RTPaperRelaList.js");
    const Pub_RTUserRelaList_js_1 = require("../GraduateEduPublicPage/Pub_RTUserRelaList.js");
    const Pub_RTViewpointRelaList_js_1 = require("../GraduateEduPublicPage/Pub_RTViewpointRelaList.js");
    const Pub_ViewpointList_js_1 = require("../GraduateEduPublicPage/Pub_ViewpointList.js");
    const ResearchTopic_Edit_js_1 = require("../PagesBase/GraduateEduTopic/ResearchTopic_Edit.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class KnowledgeEconomyListEx extends ResearchTopic_Edit_js_1.ResearchTopic_Edit {
        constructor() {
            super(...arguments);
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortResearchTopicBy: string = "topicId";
            //观点列表
            this.mstrListDivViewpoint = "divViewpointDataLst";
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
            //用户列表
            this.mstrListDivUser = "divUserDataLst";
            //主题用户关系
            this.mstrListDivRtUserRela = "divRtUserRelaDataLst";
            //主题观点关系
            this.mstrListDivRtViewPointRela = "divRtViewPointRelaDataLst";
            //主题论文关系
            this.mstrListDivRtPaperRela = "divRtPaperRelaDataLst";
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
                    //var strWhereCond = await this.CombineResearchTopicCondition();
                    //const responseText = await ResearchTopic_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //});
                    const ddlOperationTypeId_q = await this.Bind_TopicNameList();
                    //主题下拉框
                    // const ddlOperationTypeId_q = await this.BindDdl_TopicName_q("ddlTopicName", "1=1");
                    //设置缓存分类字段；
                    //获取用户角色来判断显示不同的列表数据；
                    //$('#lnkUserName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    $("#hidRoleId").val(clsPublocalStorage_js_1.clsPublocalStorage.roleId);
                    //管理员 判断角色 
                    if ($("#hidRoleId").val() == "00620001") {
                        $("#btnDelRecord").show();
                        $("#tab4Bind tr").find("td:eq(8)").show();
                    }
                    else {
                        //学生00620003 教师 
                        $("#btnDelRecord").hide();
                        $("#tab4Bind tr").find("td:eq(8)").hide();
                    }
                    //树列表
                    const gvResult = await this.GetTopicData();
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
        //主题
        async Bind_TopicNameList() {
            try {
                var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
                var arrResearchTopicObjLst = [];
                const responseObjLst = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrResearchTopicObjLst = jsonData;
                });
                var strhtml = "";
                for (var i = 0; i < arrResearchTopicObjLst.length; i++) {
                    if (i == 0) {
                        if (clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicName == "") {
                            clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId = arrResearchTopicObjLst[i].topicId;
                            clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicName = arrResearchTopicObjLst[i].topicName;
                            $("#topicName").html(arrResearchTopicObjLst[i].topicName);
                        }
                        else {
                            $("#topicName").html(clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicName);
                        }
                    }
                    strhtml += '<dd><a onclick=BtnTopicName_Click("' + arrResearchTopicObjLst[i].topicId + '","' + arrResearchTopicObjLst[i].topicName + '")> ' + arrResearchTopicObjLst[i].topicName + '</a></dd>';
                }
                $("#dlTopicNameList").html(strhtml);
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //教学班教师
        async BtnTopicName_Click(strkey, strName) {
            //$("#hidid_CurrEduCls").val(strkey);
            clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId = strkey;
            clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicName = strName;
            $("#topicName").html(strName);
            this.GetAllFunctionMethod();
        }
        //主题用户角色
        /// <summary>
        /// 为下拉框获取数据,从表:[OperationType]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_TopicUserRole_q(ddlTopicUserRole_q, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlTopicUserRole_q);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlTopicUserRole_q} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsTopicUserRoleWApi_js_1.TopicUserRole_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrTopicUserRoleObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlTopicUserRole_q, arrTopicUserRoleObjLst, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName, "");
                        console.log("完成BindDdl_TopicUserRole_q!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //获取主题数据
        BindDdl_TopicName_q(dllTopicName, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(dllTopicName);
            if (objDdl == null) {
                var strMsg = `下拉框：${dllTopicName} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrResearchTopicObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(dllTopicName, arrResearchTopicObjLst, clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId, clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicName, "");
                        console.log("完成dllTopicName!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //得到3个关系列表数据；
        async GetAllFunctionMethod() {
            ////主题用户关系；
            //this.BindGv_vRTUserRela();
            ////主题观点关系；
            //this.BindGv_vRTViewpointRela();
            ////主题论文关系；
            //this.BindGv_vRTPaperRela();
            //this.GetTopicData();
            //组合关系；
            const response = await this.BindGv_AllTopicRela();
            //调用隐藏方法
            this.GetId();
        }
        GetId() {
            //得到分类子类ID 判断显示隐藏数据；
            var strKeyId = $("#hidke_SubId").val();
            switch (strKeyId) {
                case "0001":
                    $("#infoViewpoint").hide();
                    $("#infoExpert").hide();
                    $("#infoConcept").hide();
                    $("#infoFacts").show();
                    $("#infoBasis").hide();
                    $("#infoSysskill").hide();
                    $("#infoSysSocialRelations").hide();
                    break;
                case "0002":
                    $("#infoViewpoint").hide();
                    $("#infoExpert").hide();
                    $("#infoConcept").hide();
                    $("#infoFacts").hide();
                    $("#infoBasis").show();
                    $("#infoSysskill").hide();
                    $("#infoSysSocialRelations").hide();
                    break;
                case "0003":
                    $("#infoViewpoint").hide();
                    $("#infoExpert").hide();
                    $("#infoConcept").show();
                    $("#infoFacts").hide();
                    $("#infoBasis").hide();
                    $("#infoSysskill").hide();
                    $("#infoSysSocialRelations").hide();
                    break;
                case "0004":
                    $("#infoViewpoint").show();
                    $("#infoExpert").hide();
                    $("#infoConcept").hide();
                    $("#infoFacts").hide();
                    $("#infoBasis").hide();
                    $("#infoSysskill").hide();
                    $("#infoSysSocialRelations").hide();
                    break;
                case "0005":
                    $("#infoViewpoint").hide();
                    $("#infoExpert").show();
                    $("#infoConcept").hide();
                    $("#infoFacts").hide();
                    $("#infoBasis").hide();
                    $("#infoSysskill").hide();
                    $("#infoSysSocialRelations").hide();
                    break;
                case "0006":
                    $("#infoViewpoint").hide();
                    $("#infoExpert").hide();
                    $("#infoConcept").hide();
                    $("#infoFacts").hide();
                    $("#infoBasis").hide();
                    $("#infoSysskill").show();
                    $("#infoSysSocialRelations").hide();
                    break;
                case "0007":
                    $("#infoViewpoint").hide();
                    $("#infoExpert").hide();
                    $("#infoConcept").hide();
                    $("#infoFacts").hide();
                    $("#infoBasis").hide();
                    $("#infoSysskill").hide();
                    $("#infoSysSocialRelations").show();
                    break;
                default:
                    var strMsg = '没有数据需要被处理！';
                    alert(strMsg);
                    break;
            }
        }
        GetDataShow() {
            var strKeyId = $("#hidke_SuperId").val();
            switch (strKeyId) {
                case "0001":
                    $("#infoViewpoint").hide();
                    $("#infoExpert").hide();
                    $("#infoConcept").show();
                    $("#infoFacts").show();
                    $("#infoBasis").show();
                    $("#infoSysskill").hide();
                    $("#infoSysSocialRelations").hide();
                    break;
                case "0002":
                    $("#infoViewpoint").show();
                    $("#infoExpert").show();
                    $("#infoConcept").hide();
                    $("#infoFacts").hide();
                    $("#infoBasis").hide();
                    $("#infoSysskill").hide();
                    $("#infoSysSocialRelations").hide();
                    break;
                case "0003":
                    $("#infoViewpoint").hide();
                    $("#infoExpert").hide();
                    $("#infoConcept").hide();
                    $("#infoFacts").hide();
                    $("#infoBasis").hide();
                    $("#infoSysskill").show();
                    $("#infoSysSocialRelations").hide();
                    break;
                case "0004":
                    $("#infoViewpoint").hide();
                    $("#infoExpert").hide();
                    $("#infoConcept").hide();
                    $("#infoFacts").hide();
                    $("#infoBasis").hide();
                    $("#infoSysskill").hide();
                    $("#infoSysSocialRelations").show();
                    break;
                default:
                    var strMsg = '没有数据需要被处理！';
                    alert(strMsg);
                    break;
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        async CombineResearchTopicCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.topicName_q != "") {
                //    strWhereCond += ` And ${clsResearchTopicEN.con_TopicName} like '% ${this.topicName_q}%'`;
                //}
                //if (this.TopicProposePeople_q != "") {
                //    strWhereCond += ` And ${clsvResearchTopicEN.con_UserName} like '% ${this.TopicProposePeople_q}%'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineResearchTopicCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //动态主题数据结构；
        async GetTopicData() {
            var strWhereCond = await this.CombineResearchTopicCondition();
            //声明主题变量
            var arrResearchTopicObjLst = [];
            const responseObjLst = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                arrResearchTopicObjLst = jsonData;
            });
            //知识点父类 
            var strWhereCond1 = "1=1";
            //声明主题变量
            var arrke_SuperObjLst = [];
            const responseObjLst1 = await (0, clske_SuperWApi_js_1.ke_Super_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                arrke_SuperObjLst = jsonData;
            });
            //知识点子类
            var strWhereCond2 = "1=1";
            //声明主题变量
            var arrSubObjLst = [];
            const responseObjLst2 = await (0, clske_SubWApi_js_1.ke_Sub_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                arrSubObjLst = jsonData;
            });
            var strhtml = "";
            $("#TreeBind li").remove();
            if (arrke_SuperObjLst.length > 0) {
                //循环数据
                for (var i = 0; i < arrke_SuperObjLst.length; i++) {
                    var strke_SuperId = arrke_SuperObjLst[i].ke_SuperId;
                    if (i == 0) {
                        strhtml += ' <li id="li' + arrke_SuperObjLst[i].ke_SuperId + '" ><a href="#" class="main" onclick=HideTheme_Click("' + arrke_SuperObjLst[i].ke_SuperId + '")>' + arrke_SuperObjLst[i].ke_SuperName_cn + '(' + arrke_SuperObjLst[i].ke_SuperName_en + ')</a><ul class="submenu"  style = "display: block;">';
                    }
                    else {
                        strhtml += ' <li id="li' + arrke_SuperObjLst[i].ke_SuperId + '"><a href="#" class="main"  onclick=HideTheme_Click("' + arrke_SuperObjLst[i].ke_SuperId + '")>' + arrke_SuperObjLst[i].ke_SuperName_cn + '(' + arrke_SuperObjLst[i].ke_SuperName_en + ')</a><ul class="submenu"  style = "display: none;">';
                    }
                    //通过父ID得到子类数据
                    var arrke_SubObjLst = arrSubObjLst;
                    arrke_SubObjLst = arrke_SubObjLst.filter(x => x.ke_SuperId == strke_SuperId);
                    ;
                    for (var j = 0; j < arrke_SubObjLst.length; j++) {
                        //默认存放第一条数据显示；
                        if (j == 0) {
                            //判断存放的id控件是否为空；
                            if ($("#hidke_SubId").val() == "") {
                                ////存放Id
                                $("#hidke_SubId").val(arrke_SubObjLst[i].ke_SubId);
                                strhtml += '<li id="liTwo' + arrke_SubObjLst[j].ke_SubId + '" onclick=btnSelectke_Sub("' + arrke_SubObjLst[j].ke_SubId + '","' + arrke_SubObjLst[j].ke_SubName_cn + '")><a href="#" class="selected" >' + arrke_SubObjLst[j].ke_SubName_cn + '</a></li>';
                            }
                            else {
                                strhtml += '<li id="liTwo' + arrke_SubObjLst[j].ke_SubId + '" onclick=btnSelectke_Sub("' + arrke_SubObjLst[j].ke_SubId + '","' + arrke_SubObjLst[j].ke_SubName_cn + '")><a href="#" >' + arrke_SubObjLst[j].ke_SubName_cn + '</a></li>';
                            }
                        }
                        else {
                            strhtml += '<li id="liTwo' + arrke_SubObjLst[j].ke_SubId + '" onclick=btnSelectke_Sub("' + arrke_SubObjLst[j].ke_SubId + '","' + arrke_SubObjLst[j].ke_SubName_cn + '")><a href="#">' + arrke_SubObjLst[j].ke_SubName_cn + '</a></li>';
                        }
                        //strhtml += '<li id="' + arrResearchTopicObjLst[i].topicId + '" onclick=btnSelectResearchTopic("' + arrResearchTopicObjLst[i].topicId + '")><a href="#">' + arrResearchTopicObjLst[i].topicName + '</a></li>';
                    }
                    strhtml += '</ul></li>';
                }
                $("#TreeBind").append(strhtml);
                this.GetAllFunctionMethod();
            }
        }
        ////////////////////////////////////////主题用户关系
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        async CombinevRTConceptRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicId} = '${strTopicId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //动态获取所有相关关系表数据
        async BindGv_AllTopicRela() {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //一、条件串
            //1用户关系
            var strWhereUserRela = this.CombinevRTUserRelaCondition();
            //2论文关系
            var strWherePaperRela = this.CombinevRTPaperRelaCondition();
            //3观点关系
            var strWhereViewpointRela1 = this.CombinevRTViewpointRelaCondition1();
            var strWhereViewpointRela2 = this.CombinevRTViewpointRelaCondition2();
            //附件
            var strWhereCondAttachment = "1=1";
            //5点赞 查询当前用户 点赞数据；
            //var strWhereCondLike = `1=1 And ${clsViewpointLikeLogEN.con_UpdUser} = '${strUserId}'`;// 老方法
            var strWhereCondLike = `1=1 And ${clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser} = '${strUserId}'`; //新0605
            //6相关概念
            var strWhereConcept = await this.CombinevRTConceptRelaCondition();
            //7客观事实
            var strWhereFacts = "topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "' and objectiveType='01'";
            //8客观数据
            var strWhereBasis = "topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "' and objectiveType='02'";
            //技能
            var strWhereSysskill = "topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
            //9、社会关系
            var strWhereSysSocialRelations = "topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
            //用户分数
            var strWhereCond10 = " parentId='root' and  commentTypeId='08' order by Score Desc";
            //二、数据源声明
            var arrvRTUserRelaObjLst = [];
            var arrvRTPaperRelaObjLst = [];
            var arrvRTViewpointRelaObjLst1 = [];
            var arrvRTViewpointRelaObjLst2 = [];
            //获取观点图片
            var arrViewpointAttachmentObjLst = [];
            var arrViewpointAttachmentObjLst2 = [];
            //获取概念图片
            var arrConceptAttachmentObjLst = [];
            var arrConceptAttachmentObjLst2 = [];
            //获取客观图片
            var arrObjectiveAttachmentObjLst = [];
            var arrObjectiveAttachmentObjLst2 = [];
            //获取当前用户的点赞数据
            //var arrViewpointLikeLogObjLst: Array<clsViewpointLikeLogEN> = [];//老方法
            var arrSysVoteObjLst = []; //新0605
            //获取相关概念
            var arrvRTConceptObjLst = [];
            //客观事实
            var arrvRTTopicObjectiveRelaObjLst1 = [];
            //客观数据
            var arrvRTTopicObjectiveRelaObjLst2 = [];
            //技能
            var arrvRTSysSkillObjLst = [];
            //社会关系
            var arrvRTSysSocialRelaObjLst = [];
            //用户分数
            var objSysComment1;
            var arrvSysCommentObjLst = [];
            //三、方法获取调用
            try {
                //const responseObjLst1 = await vRTUserRela_GetObjLstAsync(strWhereUserRela).then((jsonData) => {
                //    arrvRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
                //});
                //const responseObjLst2 = await vRTPaperRela_GetObjLstAsync(strWherePaperRela).then((jsonData) => {
                //    arrvRTPaperRelaObjLst = <Array<clsvRTPaperRelaEN>>jsonData;
                //});
                const responseObjLst3 = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstAsync)(strWhereViewpointRela1).then((jsonData) => {
                    arrvRTViewpointRelaObjLst1 = jsonData;
                });
                const responseObjLst4 = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstAsync)(strWhereViewpointRela2).then((jsonData) => {
                    arrvRTViewpointRelaObjLst2 = jsonData;
                });
                const responseRecCount5 = await (0, clsViewpointAttachmentWApi_js_1.ViewpointAttachment_GetObjLstAsync)(strWhereCondAttachment).then((jsonData) => {
                    arrViewpointAttachmentObjLst2 = jsonData;
                });
                //获取点赞数据
                //const responseRecCount6 = await ViewpointLikeLog_GetObjLstAsync(strWhereCondLike).then((jsonData) => {
                //    arrViewpointLikeLogObjLst = <Array<clsViewpointLikeLogEN>>jsonData; 
                //});//老方法
                const responseRecCount6 = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLstAsync)(strWhereCondLike).then((jsonData) => {
                    arrSysVoteObjLst = jsonData;
                });
                //获取相关概念数据
                const responseRecCount7 = await (0, clsvRTConceptRelaWApi_js_1.vRTConceptRela_GetObjLstAsync)(strWhereConcept).then((jsonData) => {
                    arrvRTConceptObjLst = jsonData;
                });
                //客观事实
                const responseRecCount8 = await (0, clsvRTTopicObjectiveRelaWApi_js_1.vRTTopicObjectiveRela_GetObjLstAsync)(strWhereFacts).then((jsonData) => {
                    arrvRTTopicObjectiveRelaObjLst1 = jsonData;
                });
                //客观数据   
                const responseRecCount9 = await (0, clsvRTTopicObjectiveRelaWApi_js_1.vRTTopicObjectiveRela_GetObjLstAsync)(strWhereBasis).then((jsonData) => {
                    arrvRTTopicObjectiveRelaObjLst2 = jsonData;
                });
                //用户分数  
                const responseRecCount10 = await (0, clsvSysCommentWApi_js_1.vSysComment_GetObjLstAsync)(strWhereCond10).then((jsonData) => {
                    arrvSysCommentObjLst = jsonData;
                });
                //获取技能
                const responseRecCount12 = await (0, clsvRTSysSkillWApi_js_1.vRTSysSkill_GetObjLstAsync)(strWhereSysskill).then((jsonData) => {
                    arrvRTSysSkillObjLst = jsonData;
                });
                //社会关系
                const responseRecCount13 = await (0, clsvRTSysSocialRelaWApi_js_1.vRTSysSocialRela_GetObjLstAsync)(strWhereSysskill).then((jsonData) => {
                    arrvRTSysSocialRelaObjLst = jsonData;
                });
                //相关概念附件图片
                const responseRecCount14 = await (0, clsConceptAttachmentWApi_js_1.ConceptAttachment_GetObjLstAsync)(strWhereCondAttachment).then((jsonData) => {
                    arrConceptAttachmentObjLst2 = jsonData;
                });
                //客观附件图片
                const responseRecCount15 = await (0, clsObjectiveAttachmentWApi_js_1.ObjectiveAttachment_GetObjLstAsync)(strWhereCondAttachment).then((jsonData) => {
                    arrObjectiveAttachmentObjLst2 = jsonData;
                });
                //得到管理员教师
                var strWhereUserRoleRel = " roleId in(00620001,00620002) And QxprjId='0062' order by userId asc ";
                var arrvUserRoleRelationObjLst = [];
                const responseRecCount11 = await (0, clsvQxUserRoleRelationWApi_js_1.vQxUserRoleRelation_GetObjLstAsync)(strWhereUserRoleRel).then((jsonData) => {
                    arrvUserRoleRelationObjLst = jsonData;
                });
                //得到学生数据
                //获取用户缓存数据
                var arrvUserStuNameObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                //var strWhereUserName: string = " roleId in (00620001,00620002,00620003) And QxprjId='0062' And userName is not null order by userId asc ";
                //var arrvUserStuNameObjLst: Array<clsvQxUserRoleRelationEN> = [];
                //const responseRecCount16 = await vQxUserRoleRelation_GetObjLstAsync(strWhereUserName).then((jsonData) => {
                //    arrvUserStuNameObjLst = <Array<clsvQxUserRoleRelationEN>>jsonData;
                //});
                var strhtml = '<div style="font-size:20px; color: #009688; font-weight: bold; margin-bottom:10px;" id="TopicTitle">当前主题：' + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicName + '</div>';
                ////用户
                //strhtml += '<div class="info" id="infoUser"><div class="title btn-1"><a href="#" title="相关用户">相关用户</a></div><ul class="artlist">';
                //var u = 0;//给内容加个序号
                //for (var i = 0; i < arrvRTUserRelaObjLst.length; i++) {
                //    u++;
                //    //strhtml += u + "." + arrvRTUserRelaObjLst[i].userName + "&nbsp;&nbsp;&nbsp;主题用户角色：(" + arrvRTUserRelaObjLst[i].topicUserRoleName + ")&nbsp;所属主题：" + arrvRTUserRelaObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>";
                //    strhtml += '<li><span class="rowtit color1">' + u + '.</span><span class="abstract-text">' + arrvRTUserRelaObjLst[i].userName + '</span>&nbsp;&nbsp;&nbsp;<span class="rowtit color1">角色：</span><span class="abstract-text">(' + arrvRTUserRelaObjLst[i].topicUserRoleName + ')</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';
                //    var objComment = arrvSysCommentObjLst.find(x => x.tableKey == arrvRTUserRelaObjLst[i].userId);
                //    if (objComment != null) {
                //        strhtml += '&nbsp;&nbsp;教师评分:' + objComment.score;
                //    } else {
                //        strhtml += '&nbsp;&nbsp;暂无教师打分！';
                //        if ($("#hidRoleId").val() != "00620003") {
                //            strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTUserRelaObjLst[i].userId + '","08","' + arrvRTUserRelaObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                //        }
                //    }
                //    strhtml += '</li>';
                //}
                //strhtml += '</ul></div>';
                ////论文
                //strhtml += '<div class="info" id="infoPaper"><div class="title btn-2"><a href="#" title="相关论文">相关论文</a></div><ul class="artlist">';
                //var p = 0;//给内容加个序号
                //for (var i = 0; i < arrvRTPaperRelaObjLst.length; i++) {
                //    p++;
                //    //strhtml += p + "." + arrvRTPaperRelaObjLst[i].paperTitle + "&nbsp;&nbsp;所属主题：" + arrvRTPaperRelaObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>";
                //    strhtml += '<li><span class="rowtit color2">' + p + '.</span><span class="abstract-text">' + arrvRTPaperRelaObjLst[i].paperTitle + '</span>';
                //    strhtml += "<span class=\"colorRed\" style=\"padding-left:50px;\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvRTPaperRelaObjLst[i].paperId + "')\">pdf查看</span></li>";
                //    //<a href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvRTPaperRelaObjLst[i].paperId + "')\">pdf查看</a>
                //}
                //strhtml += '</ul></div>';
                //个人观点
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3"><a href="#" title="个人观点">个人观点</a></div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvRTViewpointRelaObjLst1.length; i++) {
                    //得到viewpointId；
                    var strViewpointId = arrvRTViewpointRelaObjLst1[i].viewpointId;
                    v++;
                    strhtml += '<li><span class="rowtit color3 btnLeft">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst1[i].viewpointName + '</span>';
                    if (arrvRTViewpointRelaObjLst1[i].versionCount > 0 && arrvRTViewpointRelaObjLst1[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('个人观点历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTViewpointRelaObjLst1[i].viewpointId + "&Type=03')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    strhtml += '</li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst1[i].viewpointContent + '</span></li>';
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst1[i].viewpointTypeName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvRTViewpointRelaObjLst1[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst1[i].reason + '</span></li>';
                    //查询附件
                    arrViewpointAttachmentObjLst = arrViewpointAttachmentObjLst2.filter(x => x.viewpointId == strViewpointId);
                    if (arrViewpointAttachmentObjLst.length > 0) {
                        for (var y = 0; y < arrViewpointAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrViewpointAttachmentObjLst[y].filePath;
                            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrViewpointAttachmentObjLst[y].viewpointAttachmentId + '"/></div></li>';
                        }
                    }
                    //如果该观点是老师，编辑人后面加上教师标识
                    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst1[i].updUser);
                    if (objUserRoleRel != null) {
                        if (arrvRTViewpointRelaObjLst1[i].viewsUserId == arrvRTViewpointRelaObjLst1[i].updUser) {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + objUserRoleRel.userName + '(教师)</span>';
                        }
                        else {
                            var arrvUsersRT = arrvUserStuNameObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst1[i].viewsUserId);
                            if (arrvUsersRT != null) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvUsersRT.userName + '&nbsp;/&nbsp;' + objUserRoleRel.userName + '(教师)</span>';
                            }
                        }
                    }
                    else {
                        //等于空，则不是教师所以需要通过缓存用户数据调取用户名称
                        var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst1[i].viewsUserId);
                        if (arrvUsers != null) {
                            if (arrvRTViewpointRelaObjLst1[i].viewsUserId == arrvRTViewpointRelaObjLst1[i].updUser) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用人]：</span>' + arrvUsers.userName;
                            }
                            else {
                                //得到引用人
                                var arrvUsersRT = arrvUserStuNameObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst1[i].updUser);
                                if (arrvUsersRT != null) {
                                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvUsers.userName + '&nbsp;/&nbsp;' + arrvUsersRT.userName;
                                }
                            }
                        }
                    }
                    if (arrvRTViewpointRelaObjLst1[i].viewsDate == arrvRTViewpointRelaObjLst1[i].updDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用时间]：</span>' + arrvRTViewpointRelaObjLst1[i].viewsDate;
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTViewpointRelaObjLst1[i].viewsDate + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst1[i].updDate;
                    }
                    if (objUserRoleRel == null) {
                        //是否提交
                        if (arrvRTViewpointRelaObjLst1[i].isSubmit == true) {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[评论]：</span>';
                            //var objLike = arrViewpointLikeLogObjLst.find(x => x.viewpointId == strViewpointId);//老方法
                            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strViewpointId); //新0605
                            //点赞
                            //if (objLike == null) {
                            //    strhtml += '<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + arrvRTViewpointRelaObjLst1[i].viewpointId + '")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                            //} else {
                            //    strhtml += '<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + arrvRTViewpointRelaObjLst1[i].viewpointId + '")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                            //}
                            if (objLike == null) {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTViewpointRelaObjLst1[i].viewpointId + '","' + arrvRTViewpointRelaObjLst1[i].viewsUserId + '","03")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                            }
                            else {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTViewpointRelaObjLst1[i].viewpointId + '","' + arrvRTViewpointRelaObjLst1[i].viewsUserId + '","03")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                            }
                            strhtml += '&nbsp;' + arrvRTViewpointRelaObjLst1[i].okCount + '&nbsp;&nbsp;';
                            //评论
                            strhtml += '&nbsp;&nbsp;<span style="color:royalblue" >评论数:' + arrvRTViewpointRelaObjLst1[i].appraiseCount + '</span >';
                            //评分
                            if (arrvRTViewpointRelaObjLst1[i].score != 0) {
                                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTViewpointRelaObjLst1[i].score;
                            }
                            if (arrvRTViewpointRelaObjLst1[i].teaScore != 0) {
                                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTViewpointRelaObjLst1[i].teaScore;
                            }
                            if (arrvRTViewpointRelaObjLst1[i].stuScore != 0) {
                                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTViewpointRelaObjLst1[i].stuScore;
                            }
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('个人观点评论', '../GraduateEduTools/SysComment?Key=" + arrvRTViewpointRelaObjLst1[i].viewpointId + "&Type=03&User=" + arrvRTViewpointRelaObjLst1[i].updUser + "&pubParentId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" data-toggle="modal" onclick = btnShowAppraise_Click("' + arrvRTViewpointRelaObjLst1[i].viewpointId + '","03","' + arrvRTViewpointRelaObjLst1[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                            strhtml += '</li>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
                        }
                    }
                    else {
                        strhtml += '</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //专家观点
                strhtml += '<div class="info" id="infoExpert"><div class="title btn-3"><a href="#" title="专家观点">专家观点</a></div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvRTViewpointRelaObjLst2.length; i++) {
                    //得到viewpointId；
                    var strViewpointId = arrvRTViewpointRelaObjLst2[i].viewpointId;
                    v++;
                    //strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst2[i].viewpointName + '</span></li>';
                    strhtml += '<li><span class="rowtit color3 btnLeft">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst2[i].viewpointName + '</span>';
                    if (arrvRTViewpointRelaObjLst2[i].versionCount > 0 && arrvRTViewpointRelaObjLst2[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('专家观点历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTViewpointRelaObjLst2[i].viewpointId + "&Type=04')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    strhtml += '</li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst2[i].viewpointContent + '</span></li>';
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst2[i].viewpointTypeName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvRTViewpointRelaObjLst2[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst2[i].reason + '</span></li>';
                    //查询附件
                    arrViewpointAttachmentObjLst = arrViewpointAttachmentObjLst2.filter(x => x.viewpointId == strViewpointId);
                    if (arrvRTViewpointRelaObjLst2.length > 0) {
                        for (var y = 0; y < arrViewpointAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrViewpointAttachmentObjLst[y].filePath;
                            strhtml += '<br/><li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrViewpointAttachmentObjLst[y].viewpointAttachmentId + '"/></div></li>';
                        }
                    }
                    //如果该观点是老师，编辑人后面加上教师标识
                    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst2[i].updUser);
                    if (objUserRoleRel != null) {
                        if (arrvRTViewpointRelaObjLst2[i].viewsUserId == arrvRTViewpointRelaObjLst2[i].updUser) {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + objUserRoleRel.userName + '(教师)</span>';
                        }
                        else {
                            var arrvUsersRT = arrvUserStuNameObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst2[i].viewsUserId);
                            if (arrvUsersRT != null) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvUsersRT.userName + '&nbsp;/&nbsp;' + objUserRoleRel.userName + '(教师)</span>';
                            }
                        }
                    }
                    else {
                        var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst2[i].viewsUserId);
                        if (arrvUsers != null) {
                            if (arrvRTViewpointRelaObjLst2[i].viewsUserId == arrvRTViewpointRelaObjLst2[i].updUser) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用人]：</span>' + arrvUsers.userName;
                            }
                            else {
                                var arrvUsersRT = arrvUserStuNameObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst2[i].updUser);
                                if (arrvUsersRT != null) {
                                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvUsers.userName + '&nbsp;/&nbsp;' + arrvUsersRT.userName;
                                }
                            }
                        }
                    }
                    if (arrvRTViewpointRelaObjLst2[i].viewsDate == arrvRTViewpointRelaObjLst2[i].updDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用时间]：</span>' + arrvRTViewpointRelaObjLst2[i].viewsDate;
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTViewpointRelaObjLst2[i].viewsDate + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst2[i].updDate;
                    }
                    if (objUserRoleRel == null) {
                        if (arrvRTViewpointRelaObjLst2[i].isSubmit == true) {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[评论]：</span>';
                            //点赞
                            //var objLike = arrViewpointLikeLogObjLst.find(x => x.viewpointId == strViewpointId);//老方法
                            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strViewpointId); //新0605
                            //if (objLike == null) {
                            //    strhtml += '<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + arrvRTViewpointRelaObjLst2[i].viewpointId + '")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                            //} else {
                            //    strhtml += '<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + arrvRTViewpointRelaObjLst2[i].viewpointId + '")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                            //}
                            if (objLike == null) {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTViewpointRelaObjLst2[i].viewpointId + '","' + arrvRTViewpointRelaObjLst2[i].viewsUserId + '","04")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                            }
                            else {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTViewpointRelaObjLst2[i].viewpointId + '","' + arrvRTViewpointRelaObjLst2[i].viewsUserId + '","04")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                            }
                            strhtml += '&nbsp;' + arrvRTViewpointRelaObjLst2[i].okCount + '&nbsp;&nbsp;';
                            //评论
                            strhtml += '&nbsp;&nbsp;<span  style="color:royalblue" >评论数:' + arrvRTViewpointRelaObjLst2[i].appraiseCount + '</span >';
                            //评分
                            if (arrvRTViewpointRelaObjLst2[i].score != 0) {
                                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTViewpointRelaObjLst2[i].score;
                            }
                            if (arrvRTViewpointRelaObjLst2[i].teaScore != 0) {
                                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTViewpointRelaObjLst2[i].teaScore;
                            }
                            if (arrvRTViewpointRelaObjLst2[i].stuScore != 0) {
                                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTViewpointRelaObjLst2[i].stuScore;
                            }
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('专家观点评论', '../GraduateEduTools/SysComment?Key=" + arrvRTViewpointRelaObjLst2[i].viewpointId + "&Type=04&User=" + arrvRTViewpointRelaObjLst2[i].updUser + "&pubParentId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTViewpointRelaObjLst2[i].viewpointId + '","04","' + arrvRTViewpointRelaObjLst2[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                            strhtml += '</li>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
                        }
                    }
                    else {
                        strhtml += '</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //相关概念
                strhtml += '<div class="info" id="infoConcept"><div class="title btn-4"><a href="#" title="相关概念">相关概念</a></div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvRTConceptObjLst.length; i++) {
                    //得到概念Id；
                    var strConceptId = arrvRTConceptObjLst[i].conceptId;
                    v++;
                    //strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvRTConceptObjLst[i].conceptName + '</span></li>';
                    strhtml += '<li><span class="rowtit color4 btnLeft">' + v + '.[概念]：</span><span class="abstract-text">' + arrvRTConceptObjLst[i].conceptName + '</span>';
                    if (arrvRTConceptObjLst[i].versionCount > 0 && arrvRTConceptObjLst[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('相关概念历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTConceptObjLst[i].conceptId + "&Type=05')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    strhtml += '</li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrvRTConceptObjLst[i].conceptContent + '</span></li>';
                    //查询附件
                    arrConceptAttachmentObjLst = arrConceptAttachmentObjLst2.filter(x => x.conceptId == strConceptId);
                    if (arrConceptAttachmentObjLst.length > 0) {
                        for (var y = 0; y < arrConceptAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrConceptAttachmentObjLst[y].filePath;
                            //strhtml += '<li><img src="' + strAddressAndPortfull + '" style="max-width:500px; margin-left: 10px; " alt="" id="txtImgPath' + arrConceptAttachmentObjLst[y].conceptAttachmentId + '"/></li>';
                            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrConceptAttachmentObjLst[y].conceptAttachmentId + '"/></div></li>';
                        }
                    }
                    //如果该观点是老师，编辑人后面加上教师标识
                    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTConceptObjLst[i].updUser);
                    if (objUserRoleRel != null) {
                        if (arrvRTConceptObjLst[i].concepUserId == arrvRTConceptObjLst[i].updUser) {
                            //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvRTConceptObjLst[i].ConcepUserName + '(教师)</span>';
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + objUserRoleRel.userName + '(教师)</span>';
                        }
                        else {
                            var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTConceptObjLst[i].concepUserId);
                            if (arrvUsers != null) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvUsers.userName + '&nbsp;/&nbsp;' + objUserRoleRel.userName + '(教师)</span>';
                            }
                        }
                    }
                    else {
                        //等于空，则不是教师所以需要通过缓存用户数据调取用户名称
                        var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTConceptObjLst[i].concepUserId);
                        if (arrvUsers != null) {
                            if (arrvRTConceptObjLst[i].concepUserId == arrvRTConceptObjLst[i].updUser) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用人]：</span>' + arrvUsers.userName;
                            }
                            else {
                                //关系表的编辑用户；
                                var arrvUsersRT = arrvUserStuNameObjLst.find(x => x.userId == arrvRTConceptObjLst[i].updUser);
                                if (arrvUsersRT != null) {
                                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvUsers.userName + '&nbsp;/&nbsp;' + arrvUsersRT.userName;
                                }
                            }
                        }
                    }
                    if (arrvRTConceptObjLst[i].concepDate == arrvRTConceptObjLst[i].updDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvRTConceptObjLst[i].concepDate;
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTConceptObjLst[i].concepDate + '&nbsp;/&nbsp;' + arrvRTConceptObjLst[i].updDate;
                    }
                    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTConceptObjLst[i].concepDate + '&nbsp;/&nbsp;' + arrvRTConceptObjLst[i].updDate + '</li>';
                    if (objUserRoleRel == null) {
                        if (arrvRTConceptObjLst[i].isSubmit == true) {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';
                            //点赞
                            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strConceptId); //新0605
                            if (objLike == null) {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTConceptObjLst[i].conceptId + '","' + arrvRTConceptObjLst[i].concepUserId + '","05")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                            }
                            else {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTConceptObjLst[i].conceptId + '","' + arrvRTConceptObjLst[i].concepUserId + '","05")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                            }
                            strhtml += '&nbsp;' + arrvRTConceptObjLst[i].okCount + '&nbsp;&nbsp;';
                            //评论
                            strhtml += '&nbsp;&nbsp;<span style="color:royalblue")>评论数:' + arrvRTConceptObjLst[i].appraiseCount + '</span>';
                            //评分
                            if (arrvRTConceptObjLst[i].score != 0) {
                                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTConceptObjLst[i].score;
                            }
                            if (arrvRTConceptObjLst[i].teaScore != 0) {
                                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTConceptObjLst[i].teaScore;
                            }
                            if (arrvRTConceptObjLst[i].stuScore != 0) {
                                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTConceptObjLst[i].stuScore;
                            }
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('相关概念评论', '../GraduateEduTools/SysComment?Key=" + arrvRTConceptObjLst[i].conceptId + "&Type=05&User=" + arrvRTConceptObjLst[i].updUser + "&pubParentId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTConceptObjLst[i].conceptId + '","05","' + arrvRTConceptObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                            strhtml += '</li>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
                        }
                    }
                    else {
                        strhtml += '</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //客观事实
                strhtml += '<div class="info" id="infoFacts"><div class="title btn-5"><a href="#" title="客观事实">客观事实</a></div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvRTTopicObjectiveRelaObjLst1.length; i++) {
                    var FactTopicObjectiveId = arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId;
                    v++;
                    //strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst1[i].objectiveName + '</span></li>';
                    strhtml += '<li><span class="rowtit color6 btnLeft">' + v + '.[标题]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst1[i].objectiveName + '</span>';
                    if (arrvRTTopicObjectiveRelaObjLst1[i].versionCount > 0 && arrvRTTopicObjectiveRelaObjLst1[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('客观事实历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + "&Type=06')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    strhtml += '</li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst1[i].objectiveContent + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst1[i].conclusion + '</span></li>';
                    //查询附件
                    arrObjectiveAttachmentObjLst = arrObjectiveAttachmentObjLst2.filter(x => x.topicObjectiveId == FactTopicObjectiveId);
                    if (arrObjectiveAttachmentObjLst.length > 0) {
                        for (var y = 0; y < arrObjectiveAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrObjectiveAttachmentObjLst[y].filePath;
                            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrObjectiveAttachmentObjLst[y].objectiveAttachmentId + '"/></div></li>';
                        }
                    }
                    //如果该观点是老师，编辑人后面加上教师标识
                    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst1[i].updUser);
                    if (objUserRoleRel != null) {
                        if (arrvRTTopicObjectiveRelaObjLst1[i].objUserId == arrvRTTopicObjectiveRelaObjLst1[i].updUser) {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + objUserRoleRel.userName + '(教师)</span>';
                        }
                        else {
                            var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst1[i].objUserId);
                            if (arrvUsers != null) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvUsers.userName + '&nbsp;/&nbsp;' + objUserRoleRel.userName + '(教师)</span>';
                            }
                        }
                    }
                    else {
                        var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst1[i].objUserId);
                        if (arrvUsers != null) {
                            if (arrvRTTopicObjectiveRelaObjLst1[i].objUserId == arrvRTTopicObjectiveRelaObjLst1[i].updUser) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑引用人]：</span>' + arrvUsers.userName;
                            }
                            else {
                                var arrvUsersRt = arrvUserStuNameObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst1[i].updUser);
                                if (arrvUsersRt != null) {
                                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvUsers.userName + '&nbsp;/&nbsp;' + arrvUsersRt.userName;
                                }
                            }
                        }
                    }
                    if (arrvRTTopicObjectiveRelaObjLst1[i].objDate == arrvRTTopicObjectiveRelaObjLst1[i].updDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst1[i].objDate;
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst1[i].objDate + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst1[i].updDate;
                    }
                    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst1[i].objDate + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst1[i].updDate + '</li>';
                    if (objUserRoleRel == null) {
                        if (arrvRTTopicObjectiveRelaObjLst1[i].isSubmit == true) {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';
                            //点赞
                            var objLike = arrSysVoteObjLst.find(x => x.tableKey == FactTopicObjectiveId); //新0605
                            if (objLike == null) {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + '","' + arrvRTTopicObjectiveRelaObjLst1[i].objUserId + '","06")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                            }
                            else {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + '","' + arrvRTTopicObjectiveRelaObjLst1[i].objUserId + '","06")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                            }
                            strhtml += '&nbsp;' + arrvRTTopicObjectiveRelaObjLst1[i].okCount + '&nbsp;&nbsp;';
                            //评论
                            strhtml += '&nbsp;&nbsp;<span style="color:royalblue">评论数:' + arrvRTTopicObjectiveRelaObjLst1[i].appraiseCount + '</span>';
                            //评分
                            if (arrvRTTopicObjectiveRelaObjLst1[i].score != null) {
                                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTTopicObjectiveRelaObjLst1[i].score;
                            }
                            if (arrvRTTopicObjectiveRelaObjLst1[i].teaScore != null) {
                                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTTopicObjectiveRelaObjLst1[i].teaScore;
                            }
                            if (arrvRTTopicObjectiveRelaObjLst1[i].stuScore != null) {
                                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTTopicObjectiveRelaObjLst1[i].stuScore;
                            }
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('客观事实评论', '../GraduateEduTools/SysComment?Key=" + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + "&Type=06&User=" + arrvRTTopicObjectiveRelaObjLst1[i].updUser + "&pubParentId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + '","06","' + arrvRTTopicObjectiveRelaObjLst1[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                            strhtml += '</li>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
                        }
                    }
                    else {
                        strhtml += '</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                    //arrvRTTopicObjectiveRelaObjLst1.sourceId
                }
                strhtml += '</ul></div>';
                //客观数据 
                strhtml += '<div class="info" id="infoBasis"><div class="title btn-5"><a href="#" title="客观数据">客观数据</a></div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvRTTopicObjectiveRelaObjLst2.length; i++) {
                    var BasisTopicObjectiveId = arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId;
                    v++;
                    //strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst2[i].objectiveName + '</span></li>';
                    strhtml += '<li><span class="rowtit color6 btnLeft">' + v + '.[标题]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst2[i].objectiveName + '</span>';
                    if (arrvRTTopicObjectiveRelaObjLst2[i].versionCount > 0 && arrvRTTopicObjectiveRelaObjLst2[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('客观数据历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + "&Type=07')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    strhtml += '</li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst2[i].objectiveContent + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst2[i].conclusion + '</span></li>';
                    //查询附件
                    arrObjectiveAttachmentObjLst = arrObjectiveAttachmentObjLst2.filter(x => x.topicObjectiveId == FactTopicObjectiveId);
                    if (arrObjectiveAttachmentObjLst.length > 0) {
                        for (var y = 0; y < arrObjectiveAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrObjectiveAttachmentObjLst[y].filePath;
                            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrObjectiveAttachmentObjLst[y].objectiveAttachmentId + '"/></div></li>';
                        }
                    }
                    //如果该观点是老师，编辑人后面加上教师标识
                    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst2[i].updUser);
                    if (objUserRoleRel != null) {
                        if (arrvRTTopicObjectiveRelaObjLst2[i].objUserId == arrvRTTopicObjectiveRelaObjLst2[i].updUser) {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + objUserRoleRel.userName + '(教师)</span>';
                        }
                        else {
                            var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst2[i].objUserId);
                            if (arrvUsers != null) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvUsers.userName + '&nbsp;/&nbsp;' + objUserRoleRel.userName + '(教师)</span>';
                            }
                        }
                    }
                    else {
                        var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst2[i].objUserId);
                        if (arrvUsers != null) {
                            //如果编辑人和引用人一样
                            if (arrvRTTopicObjectiveRelaObjLst2[i].objUserId == arrvRTTopicObjectiveRelaObjLst2[i].updUser) {
                                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑引用人]：</span>' + arrvUsers.userName;
                            }
                            else {
                                var arrvUsersRT = arrvUserStuNameObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst2[i].updUser);
                                if (arrvUsersRT != null) {
                                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvUsers.userName + '&nbsp;/&nbsp;' + arrvUsersRT.userName;
                                }
                            }
                        }
                    }
                    if (arrvRTTopicObjectiveRelaObjLst2[i].objDate == arrvRTTopicObjectiveRelaObjLst2[i].updDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst2[i].objDate;
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst2[i].objDate + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst2[i].updDate;
                    }
                    if (objUserRoleRel == null) {
                        if (arrvRTTopicObjectiveRelaObjLst2[i].isSubmit == true) {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';
                            //点赞
                            var objLike = arrSysVoteObjLst.find(x => x.tableKey == BasisTopicObjectiveId); //新0605
                            if (objLike == null) {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + '","' + arrvRTTopicObjectiveRelaObjLst2[i].objUserId + '","07")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                            }
                            else {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + '","' + arrvRTTopicObjectiveRelaObjLst2[i].objUserId + '","07")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                            }
                            strhtml += '&nbsp;' + arrvRTTopicObjectiveRelaObjLst2[i].okCount + '&nbsp;&nbsp;';
                            strhtml += '&nbsp;&nbsp;<span style="color:royalblue">评论数:' + arrvRTTopicObjectiveRelaObjLst2[i].appraiseCount + '</span>';
                            //评分
                            if (arrvRTTopicObjectiveRelaObjLst2[i].score != 0) {
                                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTTopicObjectiveRelaObjLst2[i].score;
                            }
                            if (arrvRTTopicObjectiveRelaObjLst2[i].teaScore != 0) {
                                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTTopicObjectiveRelaObjLst2[i].teaScore;
                            }
                            if (arrvRTTopicObjectiveRelaObjLst2[i].stuScore != 0) {
                                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTTopicObjectiveRelaObjLst2[i].stuScore;
                            }
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('客观事实评论', '../GraduateEduTools/SysComment?Key=" + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + "&Type=07&User=" + arrvRTTopicObjectiveRelaObjLst2[i].updUser + "&pubParentId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + '","07","' + arrvRTTopicObjectiveRelaObjLst2[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                            strhtml += '</li>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
                        }
                    }
                    else {
                        strhtml += '</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //技能
                strhtml += '<div class="info" id="infoSysskill"><div class="title btn-4"><a href="#" title="技能">技能</a></div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvRTSysSkillObjLst.length; i++) {
                    //得到技能Id；
                    var strSkillId = arrvRTSysSkillObjLst[i].skillId;
                    v++;
                    //strhtml += '<li><span class="rowtit color4">' + v + '.[技能]：</span><span class="abstract-text">' + arrvRTSysSkillObjLst[i].conceptName + '</span></li>';
                    strhtml += '<li><span class="rowtit color4 btnLeft">' + v + '.[技能名称]：</span><span class="abstract-text">' + arrvRTSysSkillObjLst[i].skillName + '</span>';
                    if (arrvRTSysSkillObjLst[i].versionCount > 0 && arrvRTSysSkillObjLst[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('相关技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTSysSkillObjLst[i].skillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    strhtml += '</li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[实施过程]：</span><span class="abstract-text">' + arrvRTSysSkillObjLst[i].process + '</span></li>';
                    //获取引用人；编辑人、用户名称
                    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
                    //var arrvUsers: Array<clsvUsersSimEN> = [];
                    var UpdUserName; //编辑人
                    var CacitionUserName; //引用人
                    //获取技能引用人；
                    //arrvUsers = arrvUserRoleRelationObjLst.filter(x => x.userId == arrvRTSysSkillObjLst[i].updUser);//技能引用人
                    //for (var j = 0; j < arrvUsers.length; j++) {
                    //    CacitionUserName = arrvUsers[j].userName;
                    //    break;
                    //}
                    ////获取技能编辑人；
                    //arrvUsers = arrvUserRoleRelationObjLst.filter(x => x.userId == arrvRTSysSkillObjLst[i].skillUpdUser);//技能编辑人
                    //for (var j = 0; j < arrvUsers.length; j++) {
                    //    UpdUserName = arrvUsers[j].userName;
                    //    break;
                    //}
                    var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTSysSkillObjLst[i].updUser); //技能引用人
                    if (arrvUsers != null) {
                        CacitionUserName = arrvUsers.userName;
                    }
                    //for (var j = 0; j < arrvUsers.length; j++) {
                    //    CacitionUserName = arrvUsers[j].userName;
                    //    break;
                    //}
                    //获取技能编辑人；
                    var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTSysSkillObjLst[i].skillUpdUser); //技能编辑人
                    if (arrvUsers != null) {
                        UpdUserName = arrvUsers.userName;
                    }
                    //for (var j = 0; j < arrvUsers.length; j++) {
                    //    UpdUserName = arrvUsers[j].userName;
                    //    break;
                    //}
                    //如果该技能是老师，编辑人后面加上教师标识
                    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTSysSkillObjLst[i].updUser);
                    if (objUserRoleRel != null) {
                        if (arrvRTSysSkillObjLst[i].skillUpdUser == arrvRTSysSkillObjLst[i].updUser) {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + UpdUserName + '(教师)</span>';
                        }
                        else {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
                        }
                    }
                    else {
                        if (arrvRTSysSkillObjLst[i].skillUpdUser == arrvRTSysSkillObjLst[i].updUser) {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用人]：</span>' + UpdUserName;
                        }
                        else {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用人]：</span>' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
                        }
                    }
                    if (arrvRTSysSkillObjLst[i].skillUpdDate == arrvRTSysSkillObjLst[i].updDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvRTSysSkillObjLst[i].skillUpdDate;
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTSysSkillObjLst[i].skillUpdDate + '&nbsp;/&nbsp;' + arrvRTSysSkillObjLst[i].updDate;
                    }
                    if (objUserRoleRel == null) {
                        if (arrvRTSysSkillObjLst[i].isSubmit == true) {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';
                            //点赞
                            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSkillId); //新0605
                            if (objLike == null) {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTSysSkillObjLst[i].skillId + '","' + arrvRTSysSkillObjLst[i].skillUpdUser + '","09")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                            }
                            else {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTSysSkillObjLst[i].skillId + '","' + arrvRTSysSkillObjLst[i].skillUpdUser + '","09")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                            }
                            strhtml += '&nbsp;' + arrvRTSysSkillObjLst[i].okCount + '&nbsp;&nbsp;';
                            //评论
                            strhtml += '&nbsp;&nbsp;<span style="color:royalblue")>评论数:' + arrvRTSysSkillObjLst[i].appraiseCount + '</span>';
                            //评分
                            if (arrvRTSysSkillObjLst[i].score != 0) {
                                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTSysSkillObjLst[i].score;
                            }
                            if (arrvRTSysSkillObjLst[i].teaScore != 0) {
                                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTSysSkillObjLst[i].teaScore;
                            }
                            if (arrvRTSysSkillObjLst[i].stuScore != 0) {
                                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTSysSkillObjLst[i].stuScore;
                            }
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('操作技能评论', '../GraduateEduTools/SysComment?Key=" + arrvRTSysSkillObjLst[i].skillId + "&Type=09&User=" + arrvRTSysSkillObjLst[i].updUser + "&pubParentId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTSysSkillObjLst[i].conceptId + '","05","' + arrvRTConceptObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                            strhtml += '</li>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
                        }
                    }
                    else {
                        strhtml += '</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //社会关系
                strhtml += '<div class="info" id="infoSysSocialRelations"><div class="title btn-3"><a href="#" title="社会关系">社会关系</a></div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvRTSysSocialRelaObjLst.length; i++) {
                    //得到社会关系Id；
                    var strSocialId = arrvRTSysSocialRelaObjLst[i].socialId;
                    v++;
                    //strhtml += '<li><span class="rowtit color3">' + v + '.[技能]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].conceptName + '</span></li>';
                    strhtml += '<li><span class="rowtit color3 btnLeft">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].fullName + '</span>';
                    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].nationality + '</span>';
                    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].workUnit + '</span>';
                    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].major + '</span>';
                    if (arrvRTSysSocialRelaObjLst[i].versionCount > 0 && arrvRTSysSocialRelaObjLst[i].versionCount != null) {
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('社会关系历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTSysSocialRelaObjLst[i].socialId + "&Type=09')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    }
                    strhtml += '</li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].achievement + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].detailedDescription + '</span></li>';
                    //获取引用人；编辑人、用户名称
                    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
                    var UpdUserName; //编辑人
                    var CacitionUserName; //引用人
                    var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTSysSocialRelaObjLst[i].updUser); //技能引用人
                    if (arrvUsers != null) {
                        CacitionUserName = arrvUsers.userName;
                    }
                    else {
                        CacitionUserName = "";
                    }
                    //for (var j = 0; j < arrvUsers.length; j++) {
                    //    CacitionUserName = arrvUsers[j].userName;
                    //    break;
                    //}
                    //获取技能编辑人；
                    var arrvUsers = arrvUserStuNameObjLst.find(x => x.userId == arrvRTSysSocialRelaObjLst[i].socialUpdUser); //技能编辑人
                    if (arrvUsers != null) {
                        UpdUserName = arrvUsers.userName;
                    }
                    else {
                        UpdUserName = "";
                    }
                    //for (var j = 0; j < arrvUsers.length; j++) {
                    //    UpdUserName = arrvUsers[j].userName;
                    //    break;
                    //}
                    //如果该技能是老师，编辑人后面加上教师标识
                    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTSysSocialRelaObjLst[i].updUser);
                    if (objUserRoleRel != null) {
                        if (arrvRTSysSocialRelaObjLst[i].socialUpdUser == arrvRTSysSocialRelaObjLst[i].updUser) {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + UpdUserName + '(教师)</span>';
                        }
                        else {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
                        }
                    }
                    else {
                        if (arrvRTSysSocialRelaObjLst[i].socialUpdUser == arrvRTSysSocialRelaObjLst[i].updUser) {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用人]：</span>' + UpdUserName;
                        }
                        else {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用人]：</span>' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
                        }
                    }
                    if (arrvRTSysSocialRelaObjLst[i].socialUpdDate == arrvRTSysSocialRelaObjLst[i].updDate) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用时间]：</span>' + arrvRTSysSocialRelaObjLst[i].socialUpdDate;
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTSysSocialRelaObjLst[i].socialUpdDate + '&nbsp;/&nbsp;' + arrvRTSysSocialRelaObjLst[i].updDate;
                    }
                    if (objUserRoleRel == null) {
                        if (arrvRTSysSocialRelaObjLst[i].isSubmit == true) {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';
                            //点赞
                            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSocialId); //新0605
                            if (objLike == null) {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTSysSocialRelaObjLst[i].socialId + '","' + arrvRTSysSocialRelaObjLst[i].socialUpdUser + '","10")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
                            }
                            else {
                                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTSysSocialRelaObjLst[i].socialId + '","' + arrvRTSysSocialRelaObjLst[i].socialUpdUser + '","10")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
                            }
                            strhtml += '&nbsp;' + arrvRTSysSocialRelaObjLst[i].okCount + '&nbsp;&nbsp;';
                            //评论
                            strhtml += '&nbsp;&nbsp;<span style="color:royalblue")>评论数:' + arrvRTSysSocialRelaObjLst[i].appraiseCount + '</span>';
                            //评分
                            if (arrvRTSysSocialRelaObjLst[i].score != 0) {
                                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTSysSocialRelaObjLst[i].score;
                            }
                            if (arrvRTSysSocialRelaObjLst[i].teaScore != 0) {
                                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTSysSocialRelaObjLst[i].teaScore;
                            }
                            if (arrvRTSysSocialRelaObjLst[i].stuScore != 0) {
                                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTSysSocialRelaObjLst[i].stuScore;
                            }
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('社会关系评论', '../GraduateEduTools/SysComment?Key=" + arrvRTSysSocialRelaObjLst[i].socialId + "&Type=10&User=" + arrvRTSysSocialRelaObjLst[i].updUser + "&pubParentId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTSysSocialRelaObjLst[i].conceptId + '","05","' + arrvRTConceptObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                            strhtml += '</li>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
                        }
                    }
                    else {
                        strhtml += '</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divContent_list").html(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //添加点赞 主键,被点赞用户、点赞类型；
        async btnAddVote_Click(strViewpointId, strUserId, strVoteTypeId) {
            const strThisFuncName = this.btnAddVote_Click.name;
            //thIs.DivName = "divAddNewRecordSave";
            var objSysVoteEN = new clsSysVoteEN_js_1.clsSysVoteEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objSysVoteEN.SetTableKey(strViewpointId);
            objSysVoteEN.SetVoteTypeId(strVoteTypeId);
            objSysVoteEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls); //教学班
            objSysVoteEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objSysVoteEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            objSysVoteEN.SetLikedUserId(strUserId); //被点赞用户
            var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' and tableKey=" + strViewpointId;
            try {
                const responseText = await (0, clsSysVoteWApi_js_1.SysVote_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经点赞过了，请给其他点赞一下吧！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsSysVoteWApi_js_1.SysVote_AddNewRecordAsync)(objSysVoteEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and tableKey=" + strViewpointId;
                    var intVoteCount = await (0, clsSysVoteWApi_js_1.SysVote_GetRecCountByCondAsync)(strWhereCond2);
                    //通过不同的点赞类型，查询不同的表 把获取到的点赞数据插入到对应的表、表ID数据中
                    switch (strVoteTypeId) {
                        case "03": //个人观点
                            var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
                            objViewpointEN.SetViewpointId(strViewpointId);
                            objViewpointEN.SetOkCount(intVoteCount);
                            objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
                            if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                            }
                            const responseText1 = (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.BindGv_AllTopicRela();
                                }
                                else {
                                    var strInfo = `点赞不成功!`;
                                    alert(strInfo);
                                    console.log("点赞不成功");
                                }
                            });
                            break;
                        case "04": //专家观点
                            var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
                            objViewpointEN.SetViewpointId(strViewpointId);
                            objViewpointEN.SetOkCount(intVoteCount);
                            objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
                            if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                            }
                            const responseText2 = (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.BindGv_AllTopicRela();
                                }
                                else {
                                    var strInfo = `点赞不成功!`;
                                    alert(strInfo);
                                    console.log("点赞不成功");
                                }
                            });
                            break;
                        case "05": //概念
                            var objConceptEN = new clsConceptEN_js_1.clsConceptEN();
                            objConceptEN.SetConceptId(strViewpointId);
                            objConceptEN.SetOkCount(intVoteCount);
                            objConceptEN.sf_UpdFldSetStr = objConceptEN.updFldString; //设置哪些字段被修改(脏字段)
                            if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                            }
                            const responseText3 = (0, clsConceptWApi_js_1.Concept_UpdateRecordAsync)(objConceptEN).then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.BindGv_AllTopicRela();
                                }
                                else {
                                    var strInfo = `点赞不成功!`;
                                    alert(strInfo);
                                    console.log("点赞不成功");
                                }
                            });
                            break;
                        case "06": //客观事实
                            var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
                            objTopicObjectiveEN.SetTopicObjectiveId(strViewpointId);
                            objTopicObjectiveEN.SetOkCount(intVoteCount);
                            objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
                            if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                            }
                            const responseText4 = (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN).then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.BindGv_AllTopicRela();
                                }
                                else {
                                    var strInfo = `点赞不成功!`;
                                    alert(strInfo);
                                    console.log("点赞不成功");
                                }
                            });
                            break;
                        case "07": //客观数据
                            var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
                            objTopicObjectiveEN.SetTopicObjectiveId(strViewpointId);
                            objTopicObjectiveEN.SetOkCount(intVoteCount);
                            objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
                            if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                            }
                            const responseText5 = (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN).then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.BindGv_AllTopicRela();
                                }
                                else {
                                    var strInfo = `点赞不成功!`;
                                    alert(strInfo);
                                    console.log("点赞不成功");
                                }
                            });
                            break;
                        case "09": //技能
                            var objysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
                            objysSkillEN.SetSkillId(strViewpointId);
                            objysSkillEN.SetOkCount(intVoteCount);
                            objysSkillEN.sf_UpdFldSetStr = objysSkillEN.updFldString; //设置哪些字段被修改(脏字段)
                            if (objysSkillEN.skillId == "" || objysSkillEN.skillId == undefined) {
                                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                            }
                            const responseText6 = (0, clsSysSkillWApi_js_1.SysSkill_UpdateRecordAsync)(objysSkillEN).then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.BindGv_AllTopicRela();
                                }
                                else {
                                    var strInfo = `点赞不成功!`;
                                    alert(strInfo);
                                    console.log("点赞不成功");
                                }
                            });
                            break;
                        case "10": //社会关系
                            var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
                            objSysSocialRelationsEN.SetSocialId(strViewpointId);
                            objSysSocialRelationsEN.SetOkCount(intVoteCount);
                            objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
                            if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                            }
                            const responseText7 = (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_UpdateRecordAsync)(objSysSocialRelationsEN).then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.BindGv_AllTopicRela();
                                }
                                else {
                                    var strInfo = `点赞不成功!`;
                                    alert(strInfo);
                                    console.log("点赞不成功");
                                }
                            });
                            break;
                        default:
                            var strMsg = "没有数据";
                            alert(strMsg);
                            break;
                    }
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
        //添加点赞
        async btnAddLikeLog_Click() {
            //this.DivName = "divAddNewRecordSave";
            var objViewpointLikeLogEN = new clsViewpointLikeLogEN_js_1.clsViewpointLikeLogEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objViewpointLikeLogEN.SetViewpointId($("#hidViewpointId").val());
            objViewpointLikeLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objViewpointLikeLogEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            var strWhereCond = " 1 =1 and updUser='" + objViewpointLikeLogEN.updUserId + "' and viewpointId=" + objViewpointLikeLogEN.viewpointId;
            try {
                const responseText = await (0, clsViewpointLikeLogWApi_js_1.ViewpointLikeLog_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经点赞过这条观点了，请给其他观点点赞一下吧！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsViewpointLikeLogWApi_js_1.ViewpointLikeLog_AddNewRecordAsync)(objViewpointLikeLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    const responseBindGv = await this.BindGv_AllTopicRela();
                    //var strInfo: string = `点赞成功!`;
                    //$('#lblResult40').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);
                }
                else {
                    var strInfo = `点赞不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
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
        //显示评论
        async btnShowAppraise_Click() {
            var arrvSysCommentObjLst1 = [];
            var arrvSysCommentObjLst2 = [];
            var arrvSysCommentObjLst3 = [];
            var strWhereCond1 = "";
            var strWhereCond2 = "";
            if ($('#hidOrderbyId').val() == "1") {
                //全部评论
                strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
                strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人评论
                strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' order by updDate Asc";
                strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新评论
                strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Desc";
                strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Desc";
            }
            //var strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
            //var strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
            try {
                //获取用户缓存数据
                var arrvUserStuNameObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const responseText1 = await (0, clsvSysCommentWApi_js_1.vSysComment_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                    arrvSysCommentObjLst1 = jsonData;
                });
                const responseText2 = await (0, clsvSysCommentWApi_js_1.vSysComment_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvSysCommentObjLst2 = jsonData;
                });
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrvSysCommentObjLst1.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var strUserName = "";
                    var objUser = arrvUserStuNameObjLst.find(x => x.userId == arrvSysCommentObjLst3[j].updUser);
                    if (objUser != null) {
                        strUserName = objUser.userName;
                    }
                    if ($("#hidViewpointUserId").val() == arrvSysCommentObjLst1[i].updUser) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842 style="color:red;" > 楼主：' + strUserName + '</span>';
                    }
                    else {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + strUserName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrvSysCommentObjLst1[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">' + varNum + '楼</span></p>';
                    //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">' + arrvSysCommentObjLst1[i].comment + '</div>';
                    //回复区
                    arrvSysCommentObjLst3 = arrvSysCommentObjLst2.filter(x => x.parentId == arrvSysCommentObjLst1[i].commentId);
                    if (arrvSysCommentObjLst3.length > 0) {
                        strhtml += '<div class="reply J_ReplyBlock">';
                        for (var j = 0; j < arrvSysCommentObjLst3.length; j++) {
                            strhtml += '<div class="reply-block">';
                            strhtml += '<div class="reply-content">';
                            var strUserName = "";
                            var objUser = arrvUserStuNameObjLst.find(x => x.userId == arrvSysCommentObjLst3[j].updUser);
                            if (objUser != null) {
                                strUserName = objUser.userName;
                            }
                            if ($("#hidViewpointUserId").val() == arrvSysCommentObjLst3[j].updUser) {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328" style="color:red;"> 楼主(' + strUserName + ')</b>：</span>';
                            }
                            else {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328">' + strUserName + '</b>：</span>';
                            }
                            strhtml += '' + arrvSysCommentObjLst3[j].comment + '</div>';
                            strhtml += '<div class="reply-operate reply-operate--hot">';
                            if (arrvSysCommentObjLst3[j].scoreType == "2") {
                                strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrvSysCommentObjLst3[j].score + '</i></span>';
                            }
                            else {
                                strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrvSysCommentObjLst3[j].score + '</i></span>';
                            }
                            strhtml += '<i class="reply-dot">·</i><span>' + arrvSysCommentObjLst3[j].updDate + '</span>';
                            strhtml += '</div>';
                            strhtml += '</div>';
                        }
                        strhtml += '</div>';
                    }
                    ///评论区
                    strhtml += '<div class="comment-operate J_CommentOperate clearfix">';
                    if (arrvSysCommentObjLst1[i].scoreType == "2") {
                        strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrvSysCommentObjLst1[i].score + '</i></span>';
                    }
                    else {
                        strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrvSysCommentObjLst1[i].score + '</i></span>';
                    }
                    strhtml += '<span class="J_Vote comment-operate-item comment-operate-up">赞<i>1</i></span>';
                    strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyComment_Click("' + arrvSysCommentObjLst1[i].commentId + '")>回复</span>';
                    strhtml += '</div>';
                    strhtml += '</div></div>';
                }
                $("#J_ShortComment").append(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取数据不成功,${e}.`;
                alert(strMsg);
            }
        }
        //public async btnShowAppraise_Click() {
        //    var arrvViewpointAppraiseObjLst: Array<clsvViewpointAppraiseEN> = [];
        //    var strWhereCond = " viewpointId=" + $("#hidViewpointId").val();
        //    try {
        //        const responseText = vViewpointAppraise_GetObjLstAsync(strWhereCond).then((jsonData) => {
        //            arrvViewpointAppraiseObjLst = <Array<clsvViewpointAppraiseEN>>jsonData;
        //            //var strhtml = "";
        //            //var cateid: number = 0;
        //            //$('#AppraiseList tr').remove();
        //            //for (var i = 0; i < arrvPaperSubViewpointAppraiseObjLst.length; i++) {
        //            //    cateid++;
        //            //    strhtml += '<tr><td>' + cateid + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].AppraiseContent + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].AppraiseScore + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].userName + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].updDate + '</td><td class="td-manage"></td></tr>';
        //            //}
        //            //$("#AppraiseList").append(strhtml);
        //            var strhtml = "";
        //            var varNum = 0;
        //            $('#J_ShortComment div').remove();
        //            for (var i = 0; i < arrvViewpointAppraiseObjLst.length; i++) {
        //                //strhtml += '<tr><td>' + cateid + '</td><td>' + arrvDiscussionSubContentObjLst[i].AppraiseContent + '</td><td>' + arrvDiscussionSubContentObjLst[i].AppraiseScore + '</td><td>' + arrvDiscussionSubContentObjLst[i].userName + '</td><td>' + arrvDiscussionSubContentObjLst[i].updDate + '</td><td class="td-manage"></td></tr>';
        //                varNum++;
        //                strhtml += '<div class="comment" id = "J_Comment6631028263006567418"><div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div><div class="comment-block" id="J_CommentBlock6631028263006567418"><p class="comment-user" >';
        //                if (clsPublocalStorage.userId == arrvViewpointAppraiseObjLst[i].updUser) {
        //                    strhtml += '<span class="comment-username J_User" data-userid="17755842" style="color:red;">楼主：' + arrvViewpointAppraiseObjLst[i].userName + '</span>';
        //                } else {
        //                    strhtml += '<span class="comment-username J_User" data-userid="17755842">' + arrvViewpointAppraiseObjLst[i].userName + '</span>';
        //                }
        //                strhtml += '<span class="comment-time">' + arrvViewpointAppraiseObjLst[i].updDate + '</span></p>';
        //                strhtml += '<div class="comment-content J_CommentContent">' + varNum + '楼</div>';
        //                strhtml += '<div class="comment-content J_CommentContent">' + arrvViewpointAppraiseObjLst[i].AppraiseContent + '</div></div></div>';
        //            }
        //            $("#J_ShortComment").append(strhtml);
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `获取数据不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //点击添加评论，弹出框 根据角色来隐藏显示打分；
        //public async AppraiseScoreStyle() {
        //    var strCommentTypeId = $("#hidCommentTypeId").val();//获取评论类型
        //    var strKeyId = $("#hidTableKey").val();//获取主键
        //    //首先要判断此条数据是否提交、只有提交了才能被评论
        //    switch (strCommentTypeId) {
        //        case "01":
        //            //01	论文 
        //            var vRTPaperRela: vRTPaperRelaEN = await clsvRTPaperRela_GetObjBymIdAsync(strKeyId);
        //            if (vRTPaperRela != null) {
        //                if (vRTPaperRela.isSubmit == false) {
        //                    var strMsg: string = `论文未提交,不能评论`;
        //                    alert(strMsg);
        //                    return;
        //                }
        //                else {
        //                    this.GetUserRoleOperationStyle();
        //                }
        //            }
        //            break;
        //        case "03":
        //            // 03	个人观点
        //            var vRtviewpoint: clsvRTViewpointRelaEN = await vRTViewpointRela_GetObjBymIdAsync(strKeyId);
        //            if (vRtviewpoint != null) {
        //                if (vRtviewpoint.isSubmit == false) {
        //                    var strMsg: string = `个人观点未提交,不能评论`;
        //                    alert(strMsg);
        //                    return;
        //                }
        //                else {
        //                    this.GetUserRoleOperationStyle();
        //                }
        //            }
        //            break;
        //        case "04":
        //            // 04	专家观点
        //            var vRtviewpointExpert: clsvRTViewpointRelaEN = await vRTViewpointRela_GetObjBymIdAsync(strKeyId);
        //            if (vRtviewpointExpert != null) {
        //                if (vRtviewpointExpert.isSubmit == false) {
        //                    var strMsg: string = `专家观点未提交,不能评论`;
        //                    alert(strMsg);
        //                    return;
        //                }
        //                else {
        //                    this.GetUserRoleOperationStyle();
        //                }
        //            }
        //            break;
        //        case "05":
        //            //05	主题概念
        //            var vrtConcept: clsvRTConceptRelaEN = await vRTConceptRela_GetObjBymIdAsync(strKeyId);
        //            if (vrtConcept != null) {
        //                if (vrtConcept.isSubmit == false) {
        //                    var strMsg: string = `概念未提交,不能评论`;
        //                    alert(strMsg);
        //                    return;
        //                }
        //                else {
        //                    this.GetUserRoleOperationStyle();
        //                }
        //            }
        //            break;
        //        case "06":
        //            // 06	客观事实
        //            var vRTTopicObjectiveRelaFact: clsvRTTopicObjectiveRelaEN = await vRTTopicObjectiveRela_GetObjBymIdAsync(strKeyId);
        //            if (vRTTopicObjectiveRelaFact != null) {
        //                if (vRTTopicObjectiveRelaFact.isSubmit == false) {
        //                    var strMsg: string = `客观事实未提交,不能评论`;
        //                    alert(strMsg);
        //                    return;
        //                }
        //                else {
        //                    this.GetUserRoleOperationStyle();
        //                }
        //            }
        //            break;
        //        case "07":
        //            //07	客观数据
        //            var vRTTopicObjectiveRelaBasis: clsvRTTopicObjectiveRelaEN = await vRTTopicObjectiveRela_GetObjBymIdAsync(strKeyId);
        //            if (vRTTopicObjectiveRelaBasis != null) {
        //                if (vRTTopicObjectiveRelaBasis.isSubmit == false) {
        //                    var strMsg: string = `客观数据未提交,不能评论`;
        //                    alert(strMsg);
        //                    return;
        //                }
        //                else {
        //                    this.GetUserRoleOperationStyle();
        //                }
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //    //ShowDialog3();
        //}
        //public GetUserRoleOperationStyle() {
        //    //通过角色判断教师才可以打分，如果是学生需要隐藏
        //    //读取session角色 来判断绑定不同数据列表
        //    //获取用户角色来判断显示不同的列表数据；
        //    //判断角色 
        //    //管理员
        //    if (clsPublocalStorage.roleId == "00620001") {
        //        $("#AppraiseScoreId").attr("style", "");
        //    }
        //    else if (clsPublocalStorage.roleId == "00620002") {
        //        //调用打分功能；
        //        $("#AppraiseScoreId").attr("style", "");
        //    }
        //    else {
        //        //如果是学生；
        //        //$("#AppraiseScoreId").attr("style", "display:none;");
        //        $("#AppraiseScoreId").attr("style", "");
        //    }
        //    ShowDialog3();
        //}
        /* 添加评论内容
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
     */
        async SubmitAppraise_Click() {
            var objSysCommentEN = new clsSysCommentEN_js_1.clsSysCommentEN();
            //this.PutDataToSysCommentClass(objSysCommentEN);
            objSysCommentEN.SetTableKey($("#hidTableKey").val());
            objSysCommentEN.SetCommentTypeId($("#hidCommentTypeId").val());
            objSysCommentEN.SetParentId($("#hidParentId").val());
            objSysCommentEN.SetPubParentId(clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId);
            if ($("#hidRoleId").val() == "00620003") {
                objSysCommentEN.SetScoreType("1");
            }
            else {
                objSysCommentEN.SetScoreType("2");
                objSysCommentEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            var strvalue = $("#pin").val();
            //判断是否有打分 
            if (strvalue != "" && strvalue != undefined) {
                //获取值转化分数
                var strScore = this.GetScorebyText(strvalue);
                //判断内容是否输入
                if ($("#txtAppraiseContent").val() != "") {
                    objSysCommentEN.SetComment($("#txtAppraiseContent").val()); // 评议内容
                    objSysCommentEN.SetScore(parseInt(strScore)); // 打分
                    objSysCommentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
                    objSysCommentEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
                    try {
                        const responseText2 = await (0, clsSysCommentExWApi_js_1.SysCommentEx_AddNewRecordExAsync)(objSysCommentEN);
                        //const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN);
                        var returnBool = !!responseText2;
                        if (returnBool == true) {
                            var strInfo = `添加成功!`;
                            $('#lblResult40').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            HideDialog3();
                            const response1 = await this.btnShowAppraise_Click();
                            const response2 = await this.BindGv_AllTopicRela();
                            $("#btnOKUpdAppraise").attr("disabled", false);
                        }
                        else {
                            var strInfo = `添加失败!`;
                            $('#lblResult40').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            HideDialog3();
                            $("#btnOKUpdAppraise").attr("disabled", false);
                        }
                        $("#J_PostBtn").attr("disabled", false);
                        $("#btnOKUpdAppraise").attr("disabled", false);
                        return responseText2; //一定要有一个返回值，否则会出错！
                    }
                    catch (e) {
                        $("#J_PostBtn").attr("disabled", false);
                        $("#btnOKUpdAppraise").attr("disabled", false);
                        console.error('catch(e)=');
                        console.error(e);
                        var strMsg = `添加评论不成功,${e}.`;
                        alert(strMsg);
                    }
                }
                else {
                    $("#J_PostBtn").attr("disabled", false);
                    $("#btnOKUpdAppraise").attr("disabled", false);
                    var strInfo = `请输入评语!`;
                    //显示信息框
                    alert(strInfo);
                    return;
                }
            }
            else {
                $("#J_PostBtn").attr("disabled", false);
                $("#btnOKUpdAppraise").attr("disabled", false);
                var strInfo = `请选择评分!`;
                //显示信息框
                alert(strInfo);
                return;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //public async SubmitAppraise_Click() {
        //    this.DivName = "divAddNewRecordSave";
        //    var objViewpointAppraiseEN: clsViewpointAppraiseEN = new clsViewpointAppraiseEN();
        //    //this.PutDataToPaperSubViewpointAppraiseClass(objPaperSubViewpointAppraiseEN);
        //    objViewpointAppraiseEN.SetViewpointId($("#hidViewpointId").val();
        //    //请输入评论
        //    if ($("#txtAppraiseContent").val() != "") {
        //        ////获取值转化分数
        //        //var strScore: string = this.GetScorebyText(strvalue);
        //        //objViewpointAppraiseEN = Number(strScore);// 打分
        //        objViewpointAppraiseEN.AppraiseContent = $("#txtAppraiseContent").val();// 评议内容
        //        objViewpointAppraiseEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
        //        objViewpointAppraiseEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
        //        try {
        //            const responseText2 = await ViewpointAppraise_AddNewRecordAsync(objViewpointAppraiseEN);
        //            var returnBool: boolean = !!responseText2;
        //            if (returnBool == true) {
        //                var strInfo: string = `添加评论成功!`;
        //                $('#lblResult40').val(strInfo);
        //                //显示信息框
        //                alert(strInfo);
        //                HideDialog3();
        //                //根据角色来添加评分；
        //                //读取session角色 来判断绑定不同数据列表
        //           
        //                objvUserRoleRelation = stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
        //                //判断角色 
        //                //管理员
        //                if (objvUserRoleRelation.roleId == "00620001") {
        //                    //调用打分功能；
        //                    this.SubmitScore_Click();
        //                }
        //                else if (objvUserRoleRelation.roleId == "00620002") {
        //                    //调用打分功能；
        //                    this.SubmitScore_Click();
        //                }
        //                else {
        //                    const responseBindGv = await this.BindGv_AllTopicRela();
        //                    this.btnShowAppraise_Click();
        //                }
        //                //const responseBindGv = await this.BindGv_AllTopicRela();
        //                //this.btnShowAppraise_Click();
        //            }
        //            else {
        //                var strInfo: string = `添加评论不成功!`;
        //                $('#lblResult40').val(strInfo);
        //                //显示信息框
        //                alert(strInfo);
        //                HideDialog3();
        //                //this.BindGv_vPaperSubViewpoint();
        //                //显示评论
        //                this.btnShowAppraise_Click();
        //            }
        //            return responseText2;//一定要有一个返回值，否则会出错！
        //        }
        //        catch (e) {
        //            console.error('catch(e)=');
        //            console.error(e);
        //            var strMsg: string = `添加评论不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //    }
        //    else {
        //        var strInfo: string = `请输入评价内容!`;
        //        //显示信息框
        //        alert(strInfo);
        //        return;
        //    }
        //    return true;//一定要有一个返回值，否则会出错！
        //}
        /* 添加评论评分
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async SubmitScore_Click() {
            var objclsViewpointScoreEN = new clsViewpointScoreEN_js_1.clsViewpointScoreEN();
            objclsViewpointScoreEN.SetViewpointId($("#hidViewpointId").val());
            var strvalue = $("#pin").val();
            //判断是否有打分 
            if (strvalue != "" && strvalue != undefined) {
                //获取值转化分数
                var strScore = this.GetScorebyText(strvalue);
                objclsViewpointScoreEN.SetViewpointScore(Number(strScore)); // 打分
                objclsViewpointScoreEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
                objclsViewpointScoreEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
                try {
                    const responseText2 = await (0, clsViewpointScoreWApi_js_1.ViewpointScore_AddNewRecordAsync)(objclsViewpointScoreEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        // //var strInfo: string = `添加评论成功!`;
                        // //$('#lblResult40').val(strInfo);
                        // ////显示信息框
                        // //alert(strInfo);
                        //// HideDialog3();
                        const responseBindGv = await this.BindGv_AllTopicRela();
                        this.btnShowAppraise_Click();
                    }
                    else {
                        // var strInfo: string = `添加评论不成功!`;
                        // $('#lblResult40').val(strInfo);
                        // //显示信息框
                        // alert(strInfo);
                        //// HideDialog3();
                        //显示评论
                        this.btnShowAppraise_Click();
                    }
                    return responseText2; //一定要有一个返回值，否则会出错！
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `添加评论不成功,${e}.`;
                    alert(strMsg);
                }
            }
            else {
                var strInfo = `请选择评分!`;
                //显示信息框
                alert(strInfo);
                return;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //通过得到的值判断，得到分数
        GetScorebyText(sValue) {
            var Score = "";
            if (sValue == "1") {
                Score = "2";
            }
            else if (sValue == "2") {
                Score = "4";
            }
            else if (sValue == "一3") {
                Score = "6";
            }
            else if (sValue == "4") {
                Score = "8";
            }
            else {
                Score = "10";
            }
            return Score;
        }
        ///////////////////////////////////////////////////////////////////////////////3个关系列表数据
        ////////////////////////////////////////主题用户关系
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        async CombinevRTUserRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.userId_q != "") {
                //    strWhereCond += ` And ${clsvRTUserRelaEN.con_UserId} like '% ${this.userId_q}%'`;
                //}
                //if (this.topicName_q != "") {
                //    strWhereCond += ` And ${clsvRTUserRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
                //}
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                //}
                //else if (objvUserRoleRelation.roleId == "00620002") {
                //    //教师
                //    // $("#btnDelRecord").show();
                //    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
                //}
                //else {
                //    //学生； 
                //    // $("#btnDelRecord").show();
                //    strWhereCond += ` And ${clsvRTUserRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //    //学生00620003
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //删除主题用户关系
        async btnDelUserRelaRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelUserRelaRecord(lngKeyId);
                const objPage_RTUserRela = new Pub_RTUserRelaList_js_1.Pub_RTUserRelaList();
                await objPage_RTUserRela.Page_Load();
                //await objPage_ResearchTopic.BindGv_vRTUserRela();
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
        DelUserRelaRecord(lngmId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsRTUserRelaWApi_js_1.RTUserRela_DelRecordAsync)(lngmId).then((jsonData) => {
                        var returnInt = jsonData;
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
        //////////////////////////////////////////////////////////////////////////////主题观点关系
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        CombinevRTViewpointRelaCondition1() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.viewpointName_q != "") {
                //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
                //}
                //if (this.topicName_q != "") {
                //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
                //}
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                strWhereCond += " and userTypeId='01'";
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevRTViewpointRelaCondition2() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.viewpointName_q != "") {
                //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
                //}
                //if (this.topicName_q != "") {
                //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
                //}
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                strWhereCond += " and userTypeId='02'";
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //删除观点关系数据
        async btnDelViewPointRelaRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelViewPointRelaRecord(lngKeyId);
                const objPage_RTViewpointRela = new Pub_RTViewpointRelaList_js_1.Pub_RTViewpointRelaList();
                await objPage_RTViewpointRela.Page_Load();
                //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();
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
        DelViewPointRelaRecord(lngmId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_DelRecordAsync)(lngmId).then((jsonData) => {
                        var returnInt = jsonData;
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
        ////////////////////////////////////////////////////////////////////////////////////主题论文关系
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        async CombinevRTPaperRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.topicName_q != "") {
                //    strWhereCond += ` And ${clsvRTPaperRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
                //}
                //if (this.paperTitle_q != "") {
                //    strWhereCond += ` And ${clsvRTPaperRelaEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                //}
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                ////判断角色 
                ////管理员
                //if (objvUserRoleRelation.roleId == "00620001") {
                //    // $("#btnDelRecord").show();
                //}
                //else if (objvUserRoleRelation.roleId == "00620002") {
                //    //教师
                //    // $("#btnDelRecord").show();
                //    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
                //}
                //else {
                //    //学生； 
                //    // $("#btnDelRecord").show();
                //    strWhereCond += ` And ${clsvRTPaperRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //    //学生00620003
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTPaperRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        async btnDelPaperRelaRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelPaperRelaRecord(lngKeyId);
                const objPage_RTPaperRela = new Pub_RTPaperRelaList_js_1.Pub_RTPaperRelaList();
                await objPage_RTPaperRela.Page_Load();
                //await objPage_RTPaperRela.BindGv_vRTPaperRela();
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
        DelPaperRelaRecord(lngmId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsRTPaperRelaWApi_js_1.RTPaperRela_DelRecordAsync)(lngmId).then((jsonData) => {
                        var returnInt = jsonData;
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
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjResearchTopicEN">数据传输的目的类对象</param>
       */
        async PutDataToResearchTopicClass(pobjResearchTopicEN) {
            pobjResearchTopicEN.SetTopicId(this.topicId); // 主题编号
            pobjResearchTopicEN.SetTopicName(this.topicName); // 栏目主题
            pobjResearchTopicEN.SetTopicContent(this.topicContent); // 主题内容
            pobjResearchTopicEN.SetTopicProposePeople(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 主题提出人
            pobjResearchTopicEN.SetOrderNum(this.orderNum); // 序号
            pobjResearchTopicEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjResearchTopicEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjResearchTopicEN.SetMemo(this.memo); // 备注
        }
        /*
    * 获取年月日
    */
        getNowDate() {
            const date = new Date();
            let month = date.getMonth() + 1;
            let strDate = date.getDate();
            if (month <= 9) {
                month = "0" + month;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
        }
        /* 修改
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
      */
        async btnUpdateRecord_Click() {
            //this.opType = "Update";
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            //if (strKeyId == "") {
            //    alert("请选择需要修改的记录！");
            //    return;
            //}
            //判断主题id
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            if (strTopicId == "") {
                alert("请选择需要修改的主题！");
                return;
            }
            this.UpdateRecord(strTopicId);
        }
        /* 根据关键字获取相应的记录的对象
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        <param name = "sender">参数列表</param>
      */
        async UpdateRecord(strTopicId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.btnSubmit_ResearchTopic = "确认修改";
            this.btnCancel_ResearchTopic = "取消修改";
            this.keyId = strTopicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                const objResearchTopicEN = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjByTopicIdAsync)(strTopicId);
                if (objResearchTopicEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                // //通过判断数据用户是否是当前登录用户；
                if (objResearchTopicEN.updUser == strUserId) {
                    ShowDialog('Update');
                    this.GetDataFromResearchTopicClass(objResearchTopicEN);
                    console.log("完成UpdateRecord!");
                }
                else {
                    alert("当前数据不是您所添加，不能修改！");
                    return false;
                }
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_ResearchTopic;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                //树形数据源；
                                this.GetTopicData();
                                //this.BindGv_ResearchTopic();
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                //树形数据源；
                                this.GetTopicData();
                                //this.BindGv_ResearchTopic();
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
        /* 根据条件获取相应的记录对象的列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async btnQuery_Click(strListDiv) {
            this.GetTopicData();
            //var strWhereCond = await this.CombineResearchTopicCondition();
            //try {
            //    this.recCount = await ResearchTopic_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            //    });
            //    var objPagerPara: stuPagerPara = {
            //        pageIndex: 1,
            //        pageSize: this.pageSize,
            //        whereCond: strWhereCond,
            //        orderBy: this.hidSortResearchTopicBy
            //    };
            //    const responseObjLst = await ResearchTopic_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = <Array<clsResearchTopicEN>>jsonData;
            //        this.BindTab_ResearchTopic(this.mstrListDiv, arrResearchTopicObjLst);
            //    });
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            //    alert(strMsg);
            //}
        }
        /* 删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
      */
        async btnDelInRecord_Click(strKeyId) {
            try {
                //var arrKeyIds = GetCheckedKeyIds();
                //if (arrKeyIds.length == 0) {
                //    alert("请选择需要删除的记录！");
                //    return "";
                //}
                const responseText = await this.DelRecordEx(strKeyId);
                //树形数据源；
                this.GetTopicData();
                //const responseText2 = await this.BindGv_ResearchTopic();
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
        DelRecordEx(strTopicId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsResearchTopicExWApi_js_1.ResearchTopicEx_DelRecordAsyncEx)(strTopicId).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                            //显示信息框
                            alert(strInfo);
                            //删除成功后清空主键隐藏id
                            clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId = "";
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
        btnDetailInTab_Click(strKeyId) {
            if (strKeyId == "") {
                alert("请选择需要查看的记录！");
                return;
            }
            this.ResearchTopicDetailRecord(strKeyId);
        }
        /* 根据关键字获取相应的记录的对象
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
      <param name = "sender">参数列表</param>
    */
        ResearchTopicDetailRecord(strTopicId) {
            this.keyId = strTopicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjByTopicIdAsync)(strTopicId).then((jsonData) => {
                        var objResearchTopicEN = jsonData;
                        // //显示当前数据；
                        $("#txtTopicNameDetail").html(objResearchTopicEN.topicName);
                        $("#txtTopicContentDetail").html(objResearchTopicEN.topicContent);
                        $("#txtMemoDetail").html(objResearchTopicEN.memo);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `当前无数据获取失败,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
      */
        async AddNewRecordSave() {
            try {
                const responseText = (0, clsResearchTopicWApi_js_1.ResearchTopic_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表Paper的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtTopicId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            var objResearchTopicEN = new clsResearchTopicEN_js_1.clsResearchTopicEN();
            this.PutDataToResearchTopicClass(objResearchTopicEN);
            try {
                //const responseText = await ResearchTopic_IsExistAsync(objResearchTopicEN.topicId);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `添加记录时，关键字：${objResearchTopicEN.topicId}已经存在！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsResearchTopicWApi_js_1.ResearchTopic_AddNewRecordAsync)(objResearchTopicEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
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
                //if (this.viewpointName_q != "") {
                //    strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
                //}
                //if (this.viewpointTypeId_q != "" && this.viewpointTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvViewpointEN.con_ViewpointTypeId} = '${this.viewpointTypeId_q}'`;
                //}
                //if (this.Reason_q != "") {
                //    strWhereCond += ` And ${clsvViewpointEN.con_Reason} like '% ${this.Reason_q}%'`;
                //}
                //排除获取已存在的关系数据
                strWhereCond += ` And viewpointId not in (select viewpointId from RTViewpointRela where topicId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //添加观点 展示观点列表数据
        async btnAddRela_Click() {
            const objPage_Viewpoint = new Pub_ViewpointList_js_1.Pub_ViewpointList();
            await objPage_Viewpoint.Page_Load();
            //await objPage_Viewpoint.BindGv_vViewpoint();
        }
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
                //同一用户 同一主题 同一观点 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId + "'";
                const responseText = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题不能重复添加同一个观点！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_AddNewRecordAsync)(objRTViewpointRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加成功!`;
                    $('#lblResult40').val(strInfo);
                    HideDialogTwo();
                    //显示信息框
                    alert(strInfo);
                    //绑定关系列表；
                    const objPage_RTViewpointRela = new Pub_RTViewpointRelaList_js_1.Pub_RTViewpointRelaList();
                    await objPage_RTViewpointRela.Page_Load();
                    //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();
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
                return false;
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
            pobjRTViewpointRelaEN.SetProposePeople(strUserId); // 提出人
            pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTViewpointRelaEN.SetUpdUser(strUserId); // 修改用户Id// 修改用户Id
            //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
        }
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
        /// <summary>
        /// 为下拉框获取数据,从表:[Paper]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        async BindDdl_LiteratureTypeId(ddlLiteratureTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                const arrPaperObjLst = await (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetObjLstAsync)(strWhereCond);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                console.log("完成BindDdl_LiteratureTypeId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                }
                //用户
                if (this.readUser_q != "" && this.readUser_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdUser} = '${this.readUser_q}'`;
                }
                //只查询提交的论文数据
                strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_IsSubmit} = 'true'`;
                //排除获取已存在的关系数据
                strWhereCond += ` And paperId not in (select paperId from RTPaperRela where topicId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //添加论文关系
        async btnAddPaperRela_Click() {
            const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
            await objPage_Paper.Page_Load();
            //await objPage_Paper.BindGv_vPaper();
        }
        //查询论列表
        async btnPaperQuery_Click() {
            const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
            await objPage_Paper.Page_Load();
            //await objPage_Paper.BindGv_vPaper();
        }
        //确定选择的论文 并添加到关系表中
        btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSavePaperRela();
        }
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
                // 同一主题 同一论文 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And paperId = '" + strPaperId + "'";
                const responseText = await (0, clsRTPaperRelaWApi_js_1.RTPaperRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题不能重复添加同一个论文！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsRTPaperRelaWApi_js_1.RTPaperRela_AddNewRecordAsync)(objRTPaperRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加成功!`;
                    $('#lblResult40').val(strInfo);
                    HideDialogThree();
                    //显示信息框
                    alert(strInfo);
                    const objPage_RTPaperRela = new Pub_RTPaperRelaList_js_1.Pub_RTPaperRelaList();
                    await objPage_RTPaperRela.Page_Load();
                    //await objPage_RTPaperRela.BindGv_vRTPaperRela();
                    ////主题Id
                    //window.location.href = "../GraduateEdu/WApiRTPaperRela_QUDI_TS?TopicRelaId='01'";
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
                return false;
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
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjRTPaperRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTPaperRelaEN.SetPaperId(strPaperId); // 论文Id
            pobjRTPaperRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTPaperRelaEN.SetUpdUser(strUserId); // 修改人
            pobjRTPaperRelaEN.SetMemo(this.memo); // 备注
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
        /* 函数功能:在数据 列表中跳转到某一页 论文列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
    */
        //public IndexPageTwo(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.pageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //    this.BindGv_vPaper();
        //}
        /*
        * 论文标题
       */
        get paperTitle_q() {
            return $("#txtPaperTitle_q").val();
        }
        ///////////////////////论文列表条件
        get readUser_q() {
            return $("#ddlUserId_q").val();
        }
        /*
        * 文献类型Id
       */
        get literatureTypeId_q() {
            return $("#ddlLiteratureTypeId_q").val();
        }
        ///////////////////////////////////////////////////用户数据部分
        //添加用户关系
        async btnAddUserRela_Click() {
            const objPage_QxUsers = new Pub_QxUsersList_js_1.Pub_QxUsersList();
            await objPage_QxUsers.Page_Load();
            //await objPage_QxUsers.BindGv_QxUsers();
        }
        //查询用户数据
        async btnUserQuery_Click() {
            const objPage_QxUsers = new Pub_QxUsersList_js_1.Pub_QxUsersList();
            await objPage_QxUsers.Page_Load();
            //await objPage_QxUsers.BindGv_QxUsers();
        }
        //确定选择的用户 并添加到关系表中
        btnUserRecordInTab_Click(strkeyId) {
            //需要提示选择角色
            if (this.TopicUserRole_q != "" && this.TopicUserRole_q != "0") {
                //存放Id
                $("#hidUserIdKey").val(strkeyId);
                //执行添加关系方法
                this.AddNewRecordSaveUserRela();
            }
            else {
                var strInfo = `请选择用户角色!`;
                //显示信息框
                alert(strInfo);
                return;
            }
        }
        /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSaveUserRela() {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strPaperId = $("#hidPaperId").val();
            var strUserId = $("#hidUserIdKey").val();
            var objRTUserRelaEN = new clsRTUserRelaEN_js_1.clsRTUserRelaEN();
            this.PutDataToRTUserRelaClass(objRTUserRelaEN);
            try {
                // 同一主题 同一用户 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
                const responseText = await (0, clsRTUserRelaWApi_js_1.RTUserRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题不能重复添加同一个用户！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsRTUserRelaWApi_js_1.RTUserRela_AddNewRecordAsync)(objRTUserRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加成功!`;
                    $('#lblResult40').val(strInfo);
                    //隐藏用户框
                    HideDialogFour();
                    //显示信息框
                    alert(strInfo);
                    const objPage_RTUserRela = new Pub_RTUserRelaList_js_1.Pub_RTUserRelaList();
                    await objPage_RTUserRela.Page_Load();
                    //await objPage_ResearchTopic.BindGv_vRTUserRela();
                    ////主题Id
                    //window.location.href = "../GraduateEdu/WApiRTUserRela_QUDI_TS?TopicRelaId='01'";
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
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjRTUserRelaEN">数据传输的目的类对象</param>
       */
        PutDataToRTUserRelaClass(pobjRTUserRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strPaperId = $("#hidPaperId").val();
            var strUserIdKey = $("#hidUserIdKey").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjRTUserRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTUserRelaEN.SetUserId(strUserIdKey); // 用户ID
            pobjRTUserRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTUserRelaEN.SetTopicUserRoleId(this.TopicUserRole_q);
            pobjRTUserRelaEN.SetUpdUser(strUserId); // 修改人
            pobjRTUserRelaEN.SetMemo(this.memo); // 备注
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombineQxUsersCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.userId_q != "") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_UserId} like '% ${this.userId_q}%'`;
                }
                if (this.userName_q != "") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_UserName} like '% ${this.userName_q}%'`;
                }
                //排除获取已存在的关系数据
                strWhereCond += ` And userId not in (select userId from RTUserRela where topicId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineQxUsersCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortQxUsersBy(value) {
            $("#hidSortQxUsersBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortQxUsersBy() {
            return $("#hidSortQxUsersBy").val();
        }
        //主题
        /*
       *主题
      */
        get topicName() {
            return $("#dllTopicName").val();
        }
        ////////////////////////用户列表条件
        /*
        * 用户ID
       */
        get userId_q() {
            return $("#txtUserId_q").val();
        }
        /*
       * 用户名
      */
        get userName_q() {
            return $("#txtUserName_q").val();
        }
        //主题用户角色
        get TopicUserRole_q() {
            return $("#ddlTopicUserRole_q").val();
        }
        /*
        * 主题用户角色
       */
        set TopicUserRole_q(value) {
            $("#ddlTopicUserRole_q").val(value);
        }
        /*
    * 设置排序字段-相当使用ViewState功能  主题用户关系
    */
        set hidSortvRTUserRelaBy(value) {
            $("#hidSortvRTUserRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTUserRelaBy() {
            return $("#hidSortvRTUserRelaBy").val();
        }
        /*
       * 设置排序字段-相当使用ViewState功能 主题观点关系
      */
        set hidSortvRTViewpointRelaBy(value) {
            $("#hidSortvRTViewpointRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTViewpointRelaBy() {
            return $("#hidSortvRTViewpointRelaBy").val();
        }
        /*
    * 设置排序字段-相当使用ViewState功能  主题论文关系
    */
        set hidSortvRTPaperRelaBy(value) {
            $("#hidSortvRTPaperRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTPaperRelaBy() {
            return $("#hidSortvRTPaperRelaBy").val();
        }
    }
    exports.KnowledgeEconomyListEx = KnowledgeEconomyListEx;
});
/* 根据条件获取相应的记录对象的列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
//    public async BindGv_vRTUserRela() {
//    var strListDiv: string = this.mstrListDivRtUserRela;
//    var strWhereCond = await this.CombinevRTUserRelaCondition();
//    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
//    var arrvRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
//    try {
//        this.recCount = await vRTUserRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
//        });
//        var objPagerPara: stuPagerPara = {
//            pageIndex: intCurrPageIndex,
//            pageSize: this.pageSize,
//            whereCond: strWhereCond,
//            orderBy: this.hidSortvRTUserRelaBy,
//            sortFun: (x, y) => { return 0; }
//        };
//        const responseObjLst = await vRTUserRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
//            arrvRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
//        });
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
//        alert(strMsg);
//    }
//    try {
//        this.BindTab_vRTUserRela(strListDiv, arrvRTUserRelaObjLst);
//        console.log("完成BindGv_vRTUserRela!");
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
//        alert(strMsg);
//    }
//}
/* 显示vRTUserRela对象的所有属性值
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
<param name = "divContainer">显示容器</param>
<param name = "arrRTUserRelaObjLst">需要绑定的对象列表</param>
*/
//    public async BindTab_vRTUserRela(divContainer: string, arrvRTUserRelaObjLst: Array<clsvRTUserRelaEN>) {
//    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
//    if (o == null) {
//        alert(`${divContainer}不存在！`);
//        return;
//    }
//    var arrDataColumn: Array<clsDataColumn> =
//        [
//            {
//                fldName: "",
//                colHeader: "",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "CheckBox",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "topicName",
//                colHeader: "栏目主题",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "userName",
//                colHeader: "用户名",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "collegeName",
//                colHeader: "学院名称",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "majorName",
//                colHeader: "专业名称",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "",
//                colHeader: "删除",
//                text: "删除", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Button",
//                orderNum: 1,
//                funcName: (strKeyId: string, strText: string) => {
//                    var btn1: HTMLElement = document.createElement("button");
//                    btn1.innerText = strText;
//                    btn1.className = "btn btn-outline-info btn-sm";
//                    btn1.setAttribute("onclick", `btnDelUserRelaInTab_Click('${strKeyId}');`);
//                    return btn1;
//                }
//            },
//        ];
//    BindTab_V(o, arrvRTUserRelaObjLst, arrDataColumn, "mId", this);
//    this.objPager.recCount = this.recCount;
//    this.objPager.pageSize = this.pageSize;
//    this.objPager.ShowPagerV2(this, this.divName4Pager);
//}
/* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
//    public async BindGv_ResearchTopic() {
//    var strListDiv: string = this.divName4DataList;
//    var strWhereCond = await this.CombineResearchTopicCondition();
//    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
//    var arrResearchTopicObjLst: Array<clsvResearchTopicEN> = [];
//    try {
//        this.recCount = await vResearchTopic_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
//        });
//        var objPagerPara: stuPagerPara = {
//            pageIndex: intCurrPageIndex,
//            pageSize: this.pageSize,
//            whereCond: strWhereCond,
//            orderBy: ResearchTopicCRUD.sortResearchTopicBy,
//            sortFun: (x, y) => { return 0; }
//        };
//        const responseObjLst = await vResearchTopic_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
//            arrResearchTopicObjLst = <Array<clsvResearchTopicEN>>jsonData;
//        });
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
//        alert(strMsg);
//    }
//    //if (arrResearchTopicObjLst.length == 0) {
//    //    var strMsg: string = `根据条件获取的对象列表数为空！`;
//    //console.error(strMsg);
//    //    alert(strMsg);
//    //    return;
//    //}
//    try {
//        this.BindTab_ResearchTopic(strListDiv, arrResearchTopicObjLst);
//        console.log("完成BindGv_ResearchTopic!");
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
//        alert(strMsg);
//    }
//}
/* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
//    public async CombineResearchTopicCondition():Promise<string> {
//    //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//    //例如 1 = 1 && userName = '张三'
//    var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
//    //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//    try {
//        if (this.topicName_q != "") {
//            strWhereCond += ` And ${clsResearchTopicEN.con_TopicName} like '% ${this.topicName_q}%'`;
//        }
//        if (this.TopicProposePeople_q != "") {
//            strWhereCond += ` And ${clsvResearchTopicEN.con_UserName} like '% ${this.TopicProposePeople_q}%'`;
//        }
//    }
//    catch (objException) {
//        var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineResearchTopicCondition)时出错!请联系管理员!${objException}`;
//        throw strMsg;
//    }
//    return strWhereCond;
//}
/* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
//    public async BindGv_vRTViewpointRela() {
//    var strListDiv: string = this.mstrListDivRtViewPointRela;
//    var strWhereCond = await this.CombinevRTViewpointRelaCondition1();
//    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
//    var arrvRTViewpointRelaObjLst1: Array<clsvRTViewpointRelaEN> = [];
//    try {
//        this.recCount = await vRTViewpointRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
//        });
//        var objPagerPara: stuPagerPara = {
//            pageIndex: intCurrPageIndex,
//            pageSize: this.pageSize,
//            whereCond: strWhereCond,
//            orderBy: this.hidSortvRTViewpointRelaBy,
//            sortFun: (x, y) => { return 0; }
//        };
//        const responseObjLst = await vRTViewpointRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
//            arrvRTViewpointRelaObjLst1 = <Array<clsvRTViewpointRelaEN>>jsonData;
//        });
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
//        alert(strMsg);
//    }
//    try {
//        this.BindTab_vRTViewpointRela(strListDiv, arrvRTViewpointRelaObjLst1);
//        console.log("完成BindGv_vRTViewpointRela!");
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
//        alert(strMsg);
//    }
//}
/* 显示vRTViewpointRela对象的所有属性值
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
<param name = "divContainer">显示容器</param>
<param name = "arrRTViewpointRelaObjLst">需要绑定的对象列表</param>
*/
//    public async BindTab_vRTViewpointRela(divContainer: string, arrvRTViewpointRelaObjLst1: Array<clsvRTViewpointRelaEN>) {
//    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
//    if (o == null) {
//        alert(`${divContainer}不存在！`);
//        return;
//    }
//    var arrDataColumn: Array<clsDataColumn> =
//        [
//            {
//                fldName: "",
//                colHeader: "",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "CheckBox",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "viewpointName",
//                colHeader: "观点名称",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "viewpointTypeName",
//                colHeader: "观点类型名",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "topicName",
//                colHeader: "栏目主题",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "updDate",
//                colHeader: "修改日期",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            //{
//            //    fldName: "",
//            //    colHeader: "详情",
//            //    text: "详情",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Button",
//            //    orderNum: 1,
//            //    funcName: (strKeyId: string, strText: string) => {
//            //        var btn1: HTMLElement = document.createElement("button");
//            //        btn1.innerText = strText;
//            //        btn1.className = "btn btn-outline-info";
//            //        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
//            //        return btn1;
//            //    }
//            //},
//            {
//                fldName: "",
//                colHeader: "删除",
//                text: "删除", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Button",
//                orderNum: 1,
//                funcName: (strKeyId: string, strText: string) => {
//                    var btn1: HTMLElement = document.createElement("button");
//                    btn1.innerText = strText;
//                    btn1.className = "btn btn-outline-info btn-sm";
//                    btn1.setAttribute("onclick", `btnDelViewPointRelaRecordInTab_Click('${strKeyId}');`);
//                    return btn1;
//                }
//            },
//        ];
//    BindTab_V(o, arrvRTViewpointRelaObjLst1, arrDataColumn, "mId", this);
//    this.objPager.recCount = this.recCount;
//    this.objPager.pageSize = this.pageSize;
//    this.objPager.ShowPagerV2(this, this.divName4Pager);
//}
/* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
//    public async BindGv_vRTPaperRela() {
//    var strListDiv: string = this.mstrListDivRtPaperRela;
//    var strWhereCond = await this.CombinevRTPaperRelaCondition();
//    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
//    var arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN> = [];
//    try {
//        this.recCount = await vRTPaperRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
//        });
//        var objPagerPara: stuPagerPara = {
//            pageIndex: intCurrPageIndex,
//            pageSize: this.pageSize,
//            whereCond: strWhereCond,
//            orderBy: this.hidSortvRTPaperRelaBy,
//            sortFun: (x, y) => { return 0; }
//        };
//        const responseObjLst = await vRTPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
//            arrvRTPaperRelaObjLst = <Array<clsvRTPaperRelaEN>>jsonData;
//        });
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
//        alert(strMsg);
//    }
//    try {
//        this.BindTab_vRTPaperRela(strListDiv, arrvRTPaperRelaObjLst);
//        console.log("完成BindGv_vRTPaperRela(in KnowledgeEconomyListEx)!");
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
//        alert(strMsg);
//    }
//}
/* 显示vRTPaperRela对象的所有属性值
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
<param name = "divContainer">显示容器</param>
<param name = "arrRTPaperRelaObjLst">需要绑定的对象列表</param>
*/
//    public async BindTab_vRTPaperRela(divContainer: string, arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN>) {
//    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
//    if (o == null) {
//        alert(`${divContainer}不存在！`);
//        return;
//    }
//    var arrDataColumn: Array<clsDataColumn> =
//        [
//            {
//                fldName: "",
//                colHeader: "",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "CheckBox",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "topicName",
//                colHeader: "栏目主题",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "paperTitle",
//                colHeader: "论文标题",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            //{
//            //    fldName: "author",
//            //    colHeader: "作者",
//            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Label",
//            //    orderNum: 1,
//            //    funcName: () => { }
//            //},
//            //{
//            //    fldName: "periodical",
//            //    colHeader: "期刊",
//            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Label",
//            //    orderNum: 1,
//            //    funcName: () => { }
//            //},
//            {
//                fldName: "userName",
//                colHeader: "用户名",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            //{
//            //    fldName: "",
//            //    colHeader: "详情",
//            //    text: "详情",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Button",
//            //    orderNum: 1,
//            //    funcName: (strKeyId: string, strText: string) => {
//            //        var btn1: HTMLElement = document.createElement("button");
//            //        btn1.innerText = strText;
//            //        btn1.className = "btn btn-outline-info btn-sm";
//            //        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
//            //        return btn1;
//            //    }
//            //},
//            {
//                fldName: "",
//                colHeader: "删除",
//                text: "删除", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Button",
//                orderNum: 1,
//                funcName: (strKeyId: string, strText: string) => {
//                    var btn1: HTMLElement = document.createElement("button");
//                    btn1.innerText = strText;
//                    btn1.className = "btn btn-outline-info";
//                    btn1.setAttribute("onclick", `btnDelPaperRelaRecordInTab_Click('${strKeyId}');`);
//                    return btn1;
//                }
//            },
//        ];
//    BindTab_V(o, arrvRTPaperRelaObjLst, arrDataColumn, "mId", this);
//    this.objPager.recCount = this.recCount;
//    this.objPager.pageSize = this.pageSize;
//    this.objPager.ShowPagerV2(this, this.divName4Pager);
//}
/* 显示ResearchTopic对象的所有属性值
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
<param name = "divContainer">显示容器</param>
<param name = "arrResearchTopicObjLst">需要绑定的对象列表</param>
*/
//    public async BindTab_ResearchTopic(divContainer: string, arrResearchTopicObjLst: Array<clsvResearchTopicEN>) {
//    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
//    if (o == null) {
//        alert(`${divContainer}不存在！`);
//        return;
//    }
//    var arrDataColumn: Array<clsDataColumn> =
//        [
//            {
//                fldName: "",
//                colHeader: "",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "CheckBox",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "topicName",
//                colHeader: "栏目主题",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "topicContent",
//                colHeader: "主题内容",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "topicProposePeople",
//                colHeader: "主题提出人",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "orderNum",
//                colHeader: "序号",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "updDate",
//                colHeader: "修改日期",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "updUser",
//                colHeader: "修改人",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "",
//                colHeader: "详情",
//                text: "详情", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Button",
//                orderNum: 1,
//                funcName: (strKeyId: string, strText: string) => {
//                    var btn1: HTMLElement = document.createElement("button");
//                    btn1.innerText = strText;
//                    btn1.className = "btn btn-outline-info btn-sm";
//                    btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
//                    return btn1;
//                }
//            },
//            //{
//            //    fldName: "",
//            //    colHeader: "修改",
//            //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Button",
//            //    orderNum: 1,
//            //    funcName: (strKeyId: string, strText: string) => {
//            //        var btn1: HTMLElement = document.createElement("button");
//            //        btn1.innerText = strText;
//            //        btn1.className = "btn btn-outline-info btn-sm";
//            //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
//            //        return btn1;
//            //    }
//            //},
//            //{
//            //    fldName: "",
//            //    colHeader: "删除",
//            //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Button",
//            //    orderNum: 1,
//            //    funcName: (strKeyId: string, strText: string) => {
//            //        var btn1: HTMLElement = document.createElement("button");
//            //        btn1.innerText = strText;
//            //        btn1.className = "btn btn-outline-info btn-sm";
//            //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
//            //        return btn1;
//            //    }
//            //},
//        ];
//    BindTab_V(o, arrResearchTopicObjLst, arrDataColumn, "topicId", this);
//    this.objPager.recCount = this.recCount;
//    this.objPager.pageSize = this.pageSize;
//    this.objPager.ShowPagerV2(this, this.divName4Pager);
//}
//////////////////////////////////////观点部分
/* 根据条件获取相应的记录对象的列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
//    public async BindGv_vViewpoint() {
//    var strListDiv: string = this.mstrListDivViewpoint;
//    var strWhereCond = await this.CombinevViewpointCondition();
//    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
//    var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
//    try {
//        this.recCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
//        });
//        var objPagerPara: stuPagerPara = {
//            pageIndex: intCurrPageIndex,
//            pageSize: this.pageSize,
//            whereCond: strWhereCond,
//            orderBy: this.hidSortvViewpointBy,
//            sortFun: (x, y) => { return 0; }
//        };
//        const responseObjLst = await vViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
//            arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
//        });
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
//        alert(strMsg);
//    }
//    //if (arrvViewpointObjLst.length == 0) {
//    //    var strMsg: string = `根据条件获取的对象列表数为空！`;
//    //console.error(strMsg);
//    //    alert(strMsg);
//    //    return;
//    //}
//    try {
//        this.BindTab_vViewpoint(strListDiv, arrvViewpointObjLst);
//        console.log("完成BindGv_vViewpoint!");
//    }
//    catch (e) {
//        console.error('catch(e)=');
//        console.error(e);
//        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
//        alert(strMsg);
//    }
//}
/* 显示vViewpoint对象的所有属性值
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
<param name = "divContainer">显示容器</param>
<param name = "arrViewpointObjLst">需要绑定的对象列表</param>
*/
//    public async BindTab_vViewpoint(divContainer: string, arrvViewpointObjLst: Array<clsvViewpointEN>) {
//    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
//    if (o == null) {
//        alert(`${divContainer}不存在！`);
//        return;
//    }
//    var arrDataColumn: Array<clsDataColumn> =
//        [
//            {
//                fldName: "",
//                colHeader: "",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "CheckBox",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "viewpointName",
//                colHeader: "观点名称",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "viewpointContent",
//                colHeader: "观点内容",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "viewpointTypeName",
//                colHeader: "观点类型名",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            //{
//            //    fldName: "reason",
//            //    colHeader: "理由",
//            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Label",
//            //    orderNum: 1,
//            //    funcName: () => { }
//            //},
//            //{
//            //    fldName: "source",
//            //    colHeader: "来源",
//            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Label",
//            //    orderNum: 1,
//            //    funcName: () => { }
//            //},
//            //{
//            //    fldName: "vpProposePeople",
//            //    colHeader: "观点提出人",
//            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Label",
//            //    orderNum: 1,
//            //    funcName: () => { }
//            //},
//            {
//                fldName: "updDate",
//                colHeader: "修改日期",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "updUser",
//                colHeader: "修改人",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            //{
//            //    fldName: "",
//            //    colHeader: "详情",
//            //    text: "详情",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Button",
//            //    orderNum: 1,
//            //    funcName: (strKeyId: string, strText: string) => {
//            //        var btn1: HTMLElement = document.createElement("button");
//            //        btn1.innerText = strText;
//            //        btn1.className = "btn btn-outline-info btn-sm";
//            //        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
//            //        return btn1;
//            //    }
//            //},
//            {
//                fldName: "",
//                colHeader: "确定",
//                text: "确定", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Button",
//                orderNum: 1,
//                funcName: (strKeyId: string, strText: string) => {
//                    var btn1: HTMLElement = document.createElement("button");
//                    btn1.innerText = strText;
//                    btn1.className = "btn btn-outline-info btn-sm";
//                    btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
//                    return btn1;
//                }
//            },
//            //{
//            //    fldName: "",
//            //    colHeader: "删除",
//            //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Button",
//            //    orderNum: 1,
//            //    funcName: (strKeyId: string, strText: string) => {
//            //        var btn1: HTMLElement = document.createElement("button");
//            //        btn1.innerText = strText;
//            //        btn1.className = "btn btn-outline-info btn-sm";
//            //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
//            //        return btn1;
//            //    }
//            //},
//        ];
//    BindTab_V(o, arrvViewpointObjLst, arrDataColumn, "viewpointId", this);
//    this.objPager.recCount = this.recCount;
//    this.objPager.pageSize = this.pageSize;
//    this.objPager.ShowPagerV2(this, this.divName4Pager);
//}
/* 显示QxUsers对象的所有属性值
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    <param name = "divContainer">显示容器</param>
    <param name = "arrQxUsersObjLst">需要绑定的对象列表</param>
  */
//    public async BindTab_QxUsers(divContainer: string, arrQxUsersObjLst: Array<clsvUsersEN>) {
//    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
//    if (o == null) {
//        alert(`${divContainer}不存在！`);
//        return;
//    }
//    var arrDataColumn: Array<clsDataColumn> =
//        [
//            {
//                fldName: "",
//                colHeader: "",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "CheckBox",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "userId",
//                colHeader: "用户ID",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "userName",
//                colHeader: "用户名",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "cardNo",
//                colHeader: "卡号",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            {
//                fldName: "email",
//                colHeader: "电子邮箱",
//                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Label",
//                orderNum: 1,
//                funcName: () => { }
//            },
//            //{
//            //    fldName: "endYearMonth",
//            //    colHeader: "结束年月",
//            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Label",
//            //    orderNum: 1,
//            //    funcName: () => { }
//            //},
//            //{
//            //    fldName: "isArchive",
//            //    colHeader: "isArchive",
//            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Label",
//            //    orderNum: 1,
//            //    funcName: () => { }
//            //},
//            //{
//            //    fldName: "updDate",
//            //    colHeader: "修改日期",
//            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Label",
//            //    orderNum: 1,
//            //    funcName: () => { }
//            //},
//            //{
//            //    fldName: "updUser",
//            //    colHeader: "修改人",
//            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//            //    columnType: "Label",
//            //    orderNum: 1,
//            //    funcName: () => { }
//            //},
//            {
//                fldName: "",
//                colHeader: "确定",
//                text: "确定", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
//                columnType: "Button",
//                orderNum: 1,
//                funcName: (strKeyId: string, strText: string) => {
//                    var btn1: HTMLElement = document.createElement("button");
//                    btn1.innerText = strText;
//                    btn1.className = "btn btn-outline-info btn-sm";
//                    btn1.setAttribute("onclick", `btnUserRecordInTab_Click('${strKeyId}');`);
//                    return btn1;
//                }
//            },
//        ];
//    BindTab_V(o, arrQxUsersObjLst, arrDataColumn, "userId", this);
//    this.objPager.recCount = this.recCount;
//    this.objPager.pageSize = this.pageSize;
//    this.objPager.ShowPagerV2(this, this.divName4Pager);
//}
