(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Public_Concept.js", "../GraduateEduPublicPage/Public_SysSkill.js", "../GraduateEduPublicPage/Public_SysSocialRelations.js", "../GraduateEduPublicPage/Public_TopicObjective.js", "../GraduateEduPublicPage/Public_Viewpoint.js", "../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvgs_TobeStudiedProblemEN.js", "../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphVerWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperVerWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsConceptVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_MeetingMinutesWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_TobeStudiedProblemWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointVerWApi.js", "../TS/L3_ForWApi/InteractManage/clsqa_AnswerVerWApi.js", "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.HistoricalVersion = void 0;
    const Public_Concept_js_1 = require("../GraduateEduPublicPage/Public_Concept.js");
    const Public_SysSkill_js_1 = require("../GraduateEduPublicPage/Public_SysSkill.js");
    const Public_SysSocialRelations_js_1 = require("../GraduateEduPublicPage/Public_SysSocialRelations.js");
    const Public_TopicObjective_js_1 = require("../GraduateEduPublicPage/Public_TopicObjective.js");
    const Public_Viewpoint_js_1 = require("../GraduateEduPublicPage/Public_Viewpoint.js");
    const clsvgs_PaperParagraphEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js");
    const clsvgs_MeetingMinutesEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesEN.js");
    const clsvgs_TobeStudiedProblemEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvgs_TobeStudiedProblemEN.js");
    const clsvqa_AnswerEN_js_1 = require("../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js");
    const clsgs_PaperParagraphVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphVerWApi.js");
    const clsPaperSubAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js");
    const clsvgs_PaperParagraphWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js");
    const clsvgs_PaperVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperVerWApi.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsConceptVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsConceptVerWApi.js");
    const clsgs_MeetingMinutesVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesVerWApi.js");
    const clsgs_TobeStudiedProblemVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemVerWApi.js");
    const clsSysSkillVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillVerWApi.js");
    const clsSysSocialRelationsVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsVerWApi.js");
    const clsTopicObjectiveVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveVerWApi.js");
    const clsvgs_MeetingMinutesWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvgs_MeetingMinutesWApi.js");
    const clsvgs_TobeStudiedProblemWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvgs_TobeStudiedProblemWApi.js");
    const clsViewpointVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointVerWApi.js");
    const clsqa_AnswerVerWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_AnswerVerWApi.js");
    const clsvqa_AnswerWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsPaperENEx_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class HistoricalVersion {
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //
                    //显示当前版本的观点
                    const gvResult1 = await this.Showdiv_Version();
                    //版本列表
                    //const gvResult2 = await this.btnShowAppraise_Click();
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
        async Showdiv_Version() {
            var strTypeId = $("#hidTypeId").val();
            switch (strTypeId) {
                case "02":
                    const gvResult2 = await this.BindGv_vPaperSubViewpoint();
                    break;
                case "03":
                    const gvResult3 = await this.Bind_vViewpoint();
                    const List_Result3 = await this.Bind_ViewpointVersion();
                    break;
                case "04":
                    const gvResult4 = await this.Bind_vViewpoint();
                    const List_Result4 = await this.Bind_ViewpointVersion();
                    break;
                case "05":
                    const gvResult5 = await this.Bind_vConcept();
                    const List_Result5 = await this.Bind_ConceptVersion();
                    break;
                case "06":
                    const gvResult6 = await this.Bind_vTopicObjective();
                    const List_Result6 = await this.Bind_TopicObjectiveVersion();
                    break;
                case "07":
                    const gvResult7 = await this.Bind_vTopicObjective();
                    const List_Result7 = await this.Bind_TopicObjectiveVersion();
                    break;
                case "08":
                    const gvResult8 = await this.Bind_vSysSkill();
                    const List_Result8 = await this.Bind_SysSkillVersion();
                    break;
                case "09":
                    const gvResult9 = await this.Bind_vSysSocialRelations();
                    const List_Result9 = await this.Bind_SysSocialRelationsVersion();
                    break;
                case "10":
                    const gvResult10 = await this.Bind_vPaper();
                    const List_Result10 = await this.BindList_vPaperVersion();
                    break;
                case "11":
                    //论文写作段落历史版本；
                    const gvResult11 = await this.BindGv_vgs_PaperParagraph();
                    const List_Result11 = await this.BindList_vgs_PaperParagraphVersion();
                    break;
                case "12":
                    //小组答案；
                    const gvResult12 = await this.BindGv_vqa_Answer();
                    const List_Result12 = await this.BindList_vqa_AnswerVersion();
                    break;
                case "13":
                    //会议纪要；
                    const gvResult13 = await this.BindGv_gs_MeetingMinutes();
                    const List_Result13 = await this.BindList_gs_MeetingMinutesVersion();
                    break;
                case "14":
                    //待研究问题；
                    const gvResult14 = await this.BindGv_gs_TobeStudiedProblem();
                    const List_Result14 = await this.BindList_gs_TobeStudiedProblemVersion();
                    break;
                default:
                    break;
            }
        }
        //绑定论文子观点数据
        async BindGv_vPaperSubViewpoint() {
            var strWhereCond = "1=1 and subViewpointId='" + $("#hidKeyId").val() + "'";
            var strWhereCond2 = "1=1";
            var objvPaperSubViewpoint;
            //获取图片
            var arrPaperSubAttachmentObjLst = [];
            var arrPaperSubAttachmentObjLst2 = [];
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            try {
                const responseRecCount4 = await (0, clsPaperSubAttachmentWApi_js_1.PaperSubAttachment_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrPaperSubAttachmentObjLst2 = jsonData;
                });
                const responseObjLst = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvPaperSubViewpoint = jsonData;
                    if (objvPaperSubViewpoint != null) {
                        var strhtml = "";
                        strhtml += '<div class="info" id="infoViewpoint">';
                        strhtml += '<ul class="artlist">';
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + objvPaperSubViewpoint.rwTitle + ']：</span><span class="abstract-text">' + objvPaperSubViewpoint.subViewpointContent + '</span></li>';
                        if (objvPaperSubViewpoint.sectionName != "") {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[论文节]：</span><span class="abstract-text">' + objvPaperSubViewpoint.sectionName + '</span></li>';
                        }
                        arrPaperSubAttachmentObjLst = arrPaperSubAttachmentObjLst2.filter(x => x.subViewpointId == objvPaperSubViewpoint.subViewpointId);
                        if (arrPaperSubAttachmentObjLst.length > 0) {
                            //var strAddressAndPort = "https://www.sh-tz.com/GraduateStudyWebApp/";
                            var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                            for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {
                                var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                                strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" style="max-width:500px; margin-left: 10px;" alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';
                            }
                        }
                        if (objvPaperSubViewpoint.explainContent != "") {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + objvPaperSubViewpoint.explainTypeName + ']：</span><span class="abstract-text">' + objvPaperSubViewpoint.explainContent + '</span></li>';
                        }
                        //if (objvPaperSubViewpoint.literatureSourcesId != "") {
                        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[引用文献]：</span><span class="abstract-text">' +  '(作者：' + objvPaperSubViewpoint.AuthorEx + ')</span></li>';
                        //}
                        var objUser = arrUsers.find(x => x.userId == objvPaperSubViewpoint.updUser);
                        if (objUser != null) {
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                        }
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvPaperSubViewpoint.updDate;
                        strhtml += '</li>';
                        strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                        strhtml += '</ul></div>';
                        //拼接；
                        $("#div_Viewpoint").html(strhtml);
                        console.log("完成BindGv_vPaperSubViewpoint!");
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //绑定观点数据
        async Bind_vViewpoint() {
            var strViewpointId = $("#hidKeyId").val();
            var strHtml = await Public_Viewpoint_js_1.Public_Viewpoint.Bind_vViewpoint(strViewpointId);
            $("#div_Viewpoint").html(strHtml);
        }
        //绑定相关概念
        async Bind_vConcept() {
            var strConceptId = $("#hidKeyId").val();
            var strHtml = await Public_Concept_js_1.Public_Concept.Bind_vConcept(strConceptId);
            $("#div_Viewpoint").html(strHtml);
        }
        //客观事实、客观数据
        async Bind_vTopicObjective() {
            var strTopicObjectiveId = $("#hidKeyId").val();
            var strHtml = await Public_TopicObjective_js_1.Public_TopicObjective.Bind_vTopicObjective(strTopicObjectiveId);
            $("#div_Viewpoint").html(strHtml);
        }
        //技能
        async Bind_vSysSkill() {
            var strSkillId = $("#hidKeyId").val();
            var strHtml = await Public_SysSkill_js_1.Public_SysSkill.Bind_vSysSkill(strSkillId);
            $("#div_Viewpoint").html(strHtml);
        }
        //社会关系
        async Bind_vSysSocialRelations() {
            var strSocialId = $("#hidKeyId").val();
            var strHtml = await Public_SysSocialRelations_js_1.Public_SysSocialRelations.Bind_vSysSocialRelations(strSocialId);
            $("#div_Viewpoint").html(strHtml);
        }
        //绑定论文写作段落
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vgs_PaperParagraph() {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            const strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
            var strhtml = "";
            var strParagraphId = $("#hidKeyId").val();
            var strWhereCond = " 1=1 and paragraphId='" + strParagraphId + "'";
            var objvgs_PaperParagraph = new clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN;
            try {
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const responseObjLst = await (0, clsvgs_PaperParagraphWApi_js_1.vgs_PaperParagraph_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvgs_PaperParagraph = jsonData;
                });
                if (objvgs_PaperParagraph != null) {
                    //段落
                    strhtml += '<div class="info" id="infogs_PaperParagraph">';
                    strhtml += '<ul class="artlist">';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[类型]：</span><span class="abstract-text">' + objvgs_PaperParagraph.paragraphTypeName + '</span></li>';
                    //先判断段落类型，根据类型判断是图片，还是段落；
                    if (objvgs_PaperParagraph.paragraphTypeName == "02") {
                        //图片，如果图片存放字段不为空
                        if (objvgs_PaperParagraph.paragraphContent != "") {
                            var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                            var strAddressAndPortfull = strAddressAndPort + objvgs_PaperParagraph.paragraphContent;
                            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[段落内容]：</span><span class="abstract-text"><img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strParagraphId + '"/></span></li>';
                        }
                    }
                    else {
                        //文字
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[段落内容]：</span><span class="abstract-text">' + objvgs_PaperParagraph.paragraphContent + '</span></li>';
                    }
                    //创建用户，创建时间
                    var objUser = arrUsers.find(x => x.userId == objvgs_PaperParagraph.createUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvgs_PaperParagraph.createDate;
                    strhtml += '</li>';
                    //编辑用户编辑时间
                    var objUser = arrUsers.find(x => x.userId == objvgs_PaperParagraph.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvgs_PaperParagraph.updDate;
                    strhtml += '</li>';
                    //如果当前观点有引用论文，那么就显示论文标题和作者
                    var varPaperId = objvgs_PaperParagraph.paperId;
                    if (varPaperId != "" && varPaperId != null) {
                        var objPaper = await (0, clsPaperExWApi_js_1.PaperEx_GetObjByPaperIdById_CurrEduCls_Cache)(varPaperId, strid_CurrEducls);
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[当前论文]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                    }
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                    strhtml += '</ul></div>';
                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成段落绑定!");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            return strhtml;
        }
        ////绑定观点数据
        //public async BindGv_vViewpoint() {
        //    var strViewpointId = $("#hidKeyId").val()
        //    var strHtml = await Public_Viewpoint.Bind_vViewpoint(strViewpointId)
        //    $("#div_Viewpoint").html(strHtml);
        //}
        ////绑定相关概念
        //public async BindGv_Concept() {
        //    var strWhereCond = "1=1 and conceptId='" + $("#hidKeyId").val() + "'";
        //    var objvConcept: clsvConceptEN;
        //    try {
        //        const responseObjLst = await vConcept_GetFirstObjAsync(strWhereCond).then((jsonData) => {
        //            objvConcept = <clsvConceptEN>jsonData;
        //            if (objvConcept != null) {
        //                var strhtml = "";
        //                strhtml += '<div class="info" id="infoViewpoint">';
        //                strhtml += '<ul class="artlist">';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[概念]：</span><span class="abstract-text">' + objvConcept.conceptName + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + objvConcept.conceptContent + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objvConcept.userName;
        //                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvConcept.updDate;
        //                strhtml += '</li>';
        //                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //                strhtml += '</ul></div>';
        //                //拼接；
        //                $("#div_Viewpoint").html(strhtml);
        //                console.log("完成BindGv_vViewpoint!");
        //            }
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        ////客观事实、客观数据
        //public async BindGv_vTopicObjective() {
        //    var strWhereCond = "1=1 and topicObjectiveId='" + $("#hidKeyId").val() + "'";
        //    var objvTopicObjective: clsvTopicObjectiveEN;
        //    try {
        //        const responseObjLst = await vTopicObjective_GetFirstObjAsync(strWhereCond).then((jsonData) => {
        //            objvTopicObjective = <clsvTopicObjectiveEN>jsonData;
        //            if (objvTopicObjective != null) {
        //                var strhtml = "";
        //                //个人观点
        //                strhtml += '<div class="info" id="infoViewpoint">';
        //                strhtml += '<ul class="artlist">';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[标题]：</span><span class="abstract-text">' + objvTopicObjective.objectiveName + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + objvTopicObjective.objectiveContent + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + objvTopicObjective.conclusion + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objvTopicObjective.userName;
        //                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvTopicObjective.updDate;
        //                strhtml += '</li>';
        //                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //                strhtml += '</ul></div>';
        //                //拼接；
        //                $("#div_Viewpoint").html(strhtml);
        //                console.log("完成BindGv_vTopicObjective!");
        //            }
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        ////技能
        //public async BindGv_vSysSkill() {
        //    var strWhereCond = "1=1 and skillId='" + $("#hidKeyId").val() + "'";
        //    var objvSysSkill: clsvSysSkillEN;
        //    try {
        //        //获取用户缓存数据
        //        //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
        //        //获取用户缓存数据
        //        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        //        const responseObjLst = await vSysSkill_GetFirstObjAsync(strWhereCond).then((jsonData) => {
        //            objvSysSkill = <clsvSysSkillEN>jsonData;
        //            if (objvSysSkill != null) {
        //                var strhtml = "";
        //                //技能
        //                strhtml += '<div class="info" id="infoViewpoint">';
        //                strhtml += '<ul class="artlist">';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[技能]：</span><span class="abstract-text">' + objvSysSkill.skillName + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[类型]：</span><span class="abstract-text">' + objvSysSkill.operationTypeName + '</span>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[保密等级]：</span><span class="abstract-text">' + objvSysSkill.levelName + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[实施过程]：</span><span class="abstract-text">' + objvSysSkill.process + '</span></li>';
        //                var objUser = arrUsers.find(x => x.userId == objvSysSkill.updUser);
        //                if (objUser != null) {
        //                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
        //                }
        //                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvSysSkill.updDate;
        //                strhtml += '</li>';
        //                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //                strhtml += '</ul></div>';
        //                //拼接；
        //                $("#div_Viewpoint").html(strhtml);
        //                console.log("完成BindGv_vSysSkill!");
        //            }
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        ////社会关系
        //public async BindGv_vSysSocialRelations() {
        //    var strWhereCond = "1=1 and socialId='" + $("#hidKeyId").val() + "'";
        //    var objvSysSocialRelations: clsvSysSocialRelationsEN;
        //    try {
        //        //获取用户缓存数据
        //        //var arrUsers: Array<clsUsersEN> = await Users_GetObjLst_Cache();
        //        //获取用户缓存数据
        //        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        //        const responseObjLst = await vSysSocialRelations_GetFirstObjAsync(strWhereCond).then((jsonData) => {
        //            objvSysSocialRelations = <clsvSysSocialRelationsEN>jsonData;
        //            if (objvSysSocialRelations != null) {
        //                var strhtml = "";
        //                //技能
        //                strhtml += '<div class="info" id="infoViewpoint">';
        //                strhtml += '<ul class="artlist">';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[姓名]：</span><span class="abstract-text">' + objvSysSocialRelations.fullName + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[国籍]：</span><span class="abstract-text">' + objvSysSocialRelations.nationality + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[工作单位]：</span><span class="abstract-text">' + objvSysSocialRelations.workUnit + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[专业]：</span><span class="abstract-text">' + objvSysSocialRelations.major + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[成就]：</span><span class="abstract-text">' + objvSysSocialRelations.achievement + '</span></li>';
        //                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[详细说明]：</span><span class="abstract-text">' + objvSysSocialRelations.detailedDescription + '</span></li>';
        //                var objUser = arrUsers.find(x => x.userId == objvSysSocialRelations.updUser);
        //                if (objUser != null) {
        //                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
        //                }
        //                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvSysSocialRelations.updDate;
        //                strhtml += '</li>';
        //                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //                strhtml += '</ul></div>';
        //                //拼接；
        //                $("#div_Viewpoint").html(strhtml);
        //                console.log("完成BindGv_vSysSocialRelations!");
        //            }
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //自研论文；
        //绑定个性化论文列表
        async Bind_vPaper() {
            const strThisFuncName = this.Bind_vPaper.name;
            var strWhereCond = "1=1 and paperId='" + $("#hidKeyId").val() + "'";
            try {
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const objPaperEN = await (0, clsPaperWApi_js_1.Paper_GetFirstObjAsync)(strWhereCond);
                if (objPaperEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                const objPaperENEx = (0, clsPaperExWApi_js_1.PaperEx_CopyToEx)(objPaperEN);
                (0, clsPaperExWApi_js_1.PaperEx_FuncMapByFldName)(clsPaperENEx_js_1.clsPaperENEx.con_PaperStatusName, objPaperENEx);
                var strhtml = "";
                //自研论文
                strhtml += '<div class="info" id="infoPaper">';
                strhtml += '<ul class="artlist">';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[标题]：</span><span class="abstract-text">' + objPaperENEx.paperTitle + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[作者]：</span><span class="abstract-text">' + objPaperENEx.author + '</span>;&nbsp;&nbsp;<span class="rowtit color6">[期刊]：</span><span class="abstract-text">'
                    + objPaperENEx.periodical + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[关键字]：</span><span class="abstract-text">' + objPaperENEx.keyword + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[状态]：</span><span class="abstract-text">' + objPaperENEx.paperStatusName + '</span></li>';
                //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + ObjvPaper.paperContent + '</span></li>';
                strhtml += '<li><span class="abstract-text">' + objPaperENEx.paperContent + '</span></li>';
                var objUser = arrUsers.find(x => x.userId == objPaperENEx.updUser);
                if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                }
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objPaperENEx.updDate;
                strhtml += '</li>';
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                strhtml += '</ul></div>';
                $('#div_Viewpoint').html(strhtml);
                console.log("完成BindList_vPaper!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //小组答案
        async BindGv_vqa_Answer() {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            var strhtml = "";
            var strAnswerId = $("#hidKeyId").val();
            var strWhereCond = " 1=1 and answerId='" + strAnswerId + "'";
            var objvqa_Answer = new clsvqa_AnswerEN_js_1.clsvqa_AnswerEN;
            try {
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const responseObjLst = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvqa_Answer = jsonData;
                });
                if (objvqa_Answer != null) {
                    //段落
                    strhtml += '<div class="info" id="infovqa_Answer">';
                    strhtml += '<ul class="artlist">';
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[类型]：</span><span class="abstract-text">' + objvgs_PaperParagraph.paragraphTypeName + '</span></li>';
                    ////先判断段落类型，根据类型判断是图片，还是段落；
                    //if (objvqa_Answer.paragraphTypeName == "02") {
                    //    //图片，如果图片存放字段不为空
                    //    if (objvgs_PaperParagraph.paragraphContent != "") {
                    //        var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
                    //        var strAddressAndPortfull = strAddressAndPort + objvgs_PaperParagraph.paragraphContent;
                    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[段落内容]：</span><span class="abstract-text"><img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strParagraphId + '"/></span></li>';
                    //    }
                    //}
                    //else {
                    //文字
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[问题内容]：</span><span class="abstract-text">' + objvqa_Answer.questionsContent + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[答案内容]：</span><span class="abstract-text">' + objvqa_Answer.answerContent + '</span></li>';
                    //  }
                    ////编辑用户编辑时间
                    //var objUser = arrUsers.find(x => x.userId == objvgs_PaperParagraph.updUser);
                    //if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objvqa_Answer.userName;
                    //}
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvqa_Answer.updDate;
                    strhtml += '</li>';
                    ////如果当前观点有引用论文，那么就显示论文标题和作者
                    //var varPaperId = objvgs_PaperParagraph.paperId;
                    //if (varPaperId != "" && varPaperId != null) {
                    //    var objPaper: clsPaperEN = await vPaper_GetObjByPaperId_Cache(varPaperId, strid_CurrEducls);
                    //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[当前论文]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                    //}
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                    strhtml += '</ul></div>';
                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成答案绑定!");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            return strhtml;
        }
        //会议纪要
        async BindGv_gs_MeetingMinutes() {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            var strhtml = "";
            var strMeetingId = $("#hidKeyId").val();
            var strWhereCond = " 1=1 and meetingId='" + strMeetingId + "'";
            var objvgs_MeetingMinutes = new clsvgs_MeetingMinutesEN_js_1.clsvgs_MeetingMinutesEN;
            try {
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const responseObjLst = await (0, clsvgs_MeetingMinutesWApi_js_1.vgs_MeetingMinutes_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvgs_MeetingMinutes = jsonData;
                });
                if (objvgs_MeetingMinutes != null) {
                    //段落
                    strhtml += '<div class="info" id="infovgs_MeetingMinutes">';
                    strhtml += '<ul class="artlist">';
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[类型]：</span><span class="abstract-text">' + objvgs_PaperParagraph.paragraphTypeName + '</span></li>';
                    ////先判断段落类型，根据类型判断是图片，还是段落；
                    //if (objvqa_Answer.paragraphTypeName == "02") {
                    //    //图片，如果图片存放字段不为空
                    //    if (objvgs_PaperParagraph.paragraphContent != "") {
                    //        var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
                    //        var strAddressAndPortfull = strAddressAndPort + objvgs_PaperParagraph.paragraphContent;
                    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[段落内容]：</span><span class="abstract-text"><img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strParagraphId + '"/></span></li>';
                    //    }
                    //}
                    //else {
                    //文字
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[会议内容]：</span><span class="abstract-text">' + objvgs_MeetingMinutes.meetingContent + '</span></li>';
                    //  }
                    //编辑用户编辑时间
                    var objUser = arrUsers.find(x => x.userId == objvgs_MeetingMinutes.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[会议时间]：</span>' + objvgs_MeetingMinutes.meetingDate;
                    strhtml += '</li>';
                    ////如果当前观点有引用论文，那么就显示论文标题和作者
                    //var varPaperId = objvgs_PaperParagraph.paperId;
                    //if (varPaperId != "" && varPaperId != null) {
                    //    var objPaper: clsPaperEN = await vPaper_GetObjByPaperId_Cache(varPaperId, strid_CurrEducls);
                    //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[当前论文]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                    //}
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                    strhtml += '</ul></div>';
                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成答案绑定!");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            return strhtml;
        }
        //待研究问题
        async BindGv_gs_TobeStudiedProblem() {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            var strhtml = "";
            var strProblemId = $("#hidKeyId").val();
            var strWhereCond = " 1=1 and problemId='" + strProblemId + "'";
            var objvgs_TobeStudiedProblem = new clsvgs_TobeStudiedProblemEN_js_1.clsvgs_TobeStudiedProblemEN;
            try {
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const responseObjLst = await (0, clsvgs_TobeStudiedProblemWApi_js_1.vgs_TobeStudiedProblem_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvgs_TobeStudiedProblem = jsonData;
                });
                if (objvgs_TobeStudiedProblem != null) {
                    //段落
                    strhtml += '<div class="info" id="infovgs_TobeStudiedProblem">';
                    strhtml += '<ul class="artlist">';
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[类型]：</span><span class="abstract-text">' + objvgs_PaperParagraph.paragraphTypeName + '</span></li>';
                    ////先判断段落类型，根据类型判断是图片，还是段落；
                    //if (objvqa_Answer.paragraphTypeName == "02") {
                    //    //图片，如果图片存放字段不为空
                    //    if (objvgs_PaperParagraph.paragraphContent != "") {
                    //        var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
                    //        var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
                    //        var strAddressAndPortfull = strAddressAndPort + objvgs_PaperParagraph.paragraphContent;
                    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[段落内容]：</span><span class="abstract-text"><img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strParagraphId + '"/></span></li>';
                    //    }
                    //}
                    //else {
                    //文字
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[问题标题]：</span><span class="abstract-text">' + objvgs_TobeStudiedProblem.problemTitle + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[问题内容]：</span><span class="abstract-text">' + objvgs_TobeStudiedProblem.problemContent + '</span></li>';
                    //  }
                    //编辑用户编辑时间
                    var objUser = arrUsers.find(x => x.userId == objvgs_TobeStudiedProblem.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[待研究问题时间]：</span>' + objvgs_TobeStudiedProblem.problemDate;
                    strhtml += '</li>';
                    ////如果当前观点有引用论文，那么就显示论文标题和作者
                    //var varPaperId = objvgs_PaperParagraph.paperId;
                    //if (varPaperId != "" && varPaperId != null) {
                    //    var objPaper: clsPaperEN = await vPaper_GetObjByPaperId_Cache(varPaperId, strid_CurrEducls);
                    //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[当前论文]：</span>' + objPaper.paperTitle + '(作者：' + objPaper.author + ')</li>';
                    //}
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                    strhtml += '</ul></div>';
                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成答案绑定!");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            return strhtml;
        }
        /******************************************************************历史版本***********************************************************/
        /******************************************************************历史版本***********************************************************/
        /******************************************************************历史版本***********************************************************/
        //观点历史版本
        async Bind_ViewpointVersion() {
            var arrViewpointVObjLst = [];
            var strWhereCond = "";
            //var strWhereCond2 = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " viewpointId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  viewpointId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  viewpointId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsViewpointVerWApi_js_1.ViewpointVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrViewpointVObjLst = jsonData;
                });
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1 and isGSuser=1");
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrViewpointVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrViewpointVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrViewpointVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    strhtml += '<div class="comment-content J_CommentContent">[观点]' + arrViewpointVObjLst[i].viewpointName + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">[内容]' + arrViewpointVObjLst[i].viewpointName + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">[方法]' + arrViewpointVObjLst[i].reason + '</div>';
                    ////回复区
                    //arrViewpointVObjLst3 = arrViewpointVObjLst2.filter(x => x.parentId == arrViewpointVObjLst[i].commentId);
                    //if (arrViewpointVObjLst3.length > 0) {
                    //    strhtml += '<div class="reply J_ReplyBlock">';
                    //    for (var j = 0; j < arrViewpointVObjLst3.length; j++) {
                    //        strhtml += '<div class="reply-block">';
                    //        strhtml += '<div class="reply-content">';
                    //        if ($("#hidUser").val() == arrViewpointVObjLst3[j].updUser) {
                    //            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328" style="color:red;"> 楼主(' + arrViewpointVObjLst3[j].userName + ')</b>：</span>';
                    //        } else {
                    //            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328">' + arrViewpointVObjLst3[j].userName + '</b>：</span>';
                    //        }
                    //        strhtml += '' + arrViewpointVObjLst3[j].comment + '</div>';
                    //        strhtml += '<div class="reply-operate reply-operate--hot">'
                    //        if (arrViewpointVObjLst3[j].scoreType == "2") {
                    //            strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrViewpointVObjLst3[j].score + '</i></span>';
                    //        } else {
                    //            strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrViewpointVObjLst3[j].score + '</i></span>';
                    //        }
                    //        strhtml += '<i class="reply-dot">·</i><span>' + arrViewpointVObjLst3[j].updDate + '</span>';
                    //        strhtml += '</div>';
                    //        strhtml += '</div>';
                    //    }
                    //    strhtml += '</div>';
                    //}
                    /////版本区
                    //strhtml += '<div class="comment-operate J_CommentOperate clearfix">';
                    //if (arrViewpointVObjLst[i].scoreType == "2") {
                    //    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrViewpointVObjLst[i].score + '</i></span>';
                    //} else {
                    //    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrViewpointVObjLst[i].score + '</i></span>';
                    //}
                    //strhtml += '<span class="J_Vote comment-operate-item comment-operate-up">赞<i>1</i></span>';
                    //strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyComment_Click("' + arrViewpointVObjLst[i].commentId + '")>回复</span>';
                    //strhtml += '</div>';
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
        //概念历史版本
        async Bind_ConceptVersion() {
            var arrConceptVObjLst = [];
            var strWhereCond = "";
            //var strWhereCond2 = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " conceptId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  conceptId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  conceptId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsConceptVerWApi_js_1.ConceptVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrConceptVObjLst = jsonData;
                });
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrConceptVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrConceptVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrConceptVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    strhtml += '<div class="comment-content J_CommentContent">[概念]' + arrConceptVObjLst[i].conceptName + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">[内容]' + arrConceptVObjLst[i].conceptContent + '</div>';
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
        //客观历史版本
        async Bind_TopicObjectiveVersion() {
            var arrTopicObjectiveVObjLst = [];
            var strWhereCond = "";
            //var strWhereCond2 = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " topicObjectiveId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  topicObjectiveId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  topicObjectiveId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsTopicObjectiveVerWApi_js_1.TopicObjectiveVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrTopicObjectiveVObjLst = jsonData;
                });
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1 and isGSuser=1");
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrTopicObjectiveVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrTopicObjectiveVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrTopicObjectiveVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    strhtml += '<div class="comment-content J_CommentContent">[标题]' + arrTopicObjectiveVObjLst[i].objectiveName + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">[内容]' + arrTopicObjectiveVObjLst[i].objectiveContent + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">[推论]' + arrTopicObjectiveVObjLst[i].conclusion + '</div>';
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
        //技能版本
        async Bind_SysSkillVersion() {
            var arrSysSkillVObjLst = [];
            var strWhereCond = "";
            //var strWhereCond2 = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " skillId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  skillId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  skillId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsSysSkillVerWApi_js_1.SysSkillVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrSysSkillVObjLst = jsonData;
                });
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1 and isGSuser=1");
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrSysSkillVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrSysSkillVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrSysSkillVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    strhtml += '<div class="comment-content J_CommentContent">[技能]' + arrSysSkillVObjLst[i].skillName + '</div>';
                    //strhtml += '<div class="comment-content J_CommentContent">[类型]' + arrSysSkillVObjLst[i].operationTypeName + '</div>';
                    //strhtml += '<div class="comment-content J_CommentContent">[保密等级]' + arrSysSkillVObjLst[i].levelName + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">[实施过程]' + arrSysSkillVObjLst[i].process + '</div>';
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
        //社会关系
        async Bind_SysSocialRelationsVersion() {
            var arrSysSocialRelationsVObjLst = [];
            var strWhereCond = "";
            //var strWhereCond2 = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " socialId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  socialId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  socialId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsSysSocialRelationsVerWApi_js_1.SysSocialRelationsVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrSysSocialRelationsVObjLst = jsonData;
                });
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1 and isGSuser=1");
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrSysSocialRelationsVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrSysSocialRelationsVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrSysSocialRelationsVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    strhtml += '<div class="comment-content J_CommentContent">[姓名]' + arrSysSocialRelationsVObjLst[i].fullName + '[国籍]' + arrSysSocialRelationsVObjLst[i].nationality + '[工作单位]' + arrSysSocialRelationsVObjLst[i].workUnit + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">[专业]' + arrSysSocialRelationsVObjLst[i].major + '[成就]' + arrSysSocialRelationsVObjLst[i].achievement + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">[详细说明]' + arrSysSocialRelationsVObjLst[i].detailedDescription + '</div>';
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
        //自研论文历史版本
        async BindList_vPaperVersion() {
            var arrvgs_PaperVObjLst = [];
            var strWhereCond = "";
            //var strWhereCond2 = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " paperId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  paperId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  paperId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsvgs_PaperVerWApi_js_1.vgs_PaperVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_PaperVObjLst = jsonData;
                });
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1 and isGSuser=1");
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrvgs_PaperVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrvgs_PaperVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrvgs_PaperVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    strhtml += '<div class="comment-content J_CommentContent">[标题]' + arrvgs_PaperVObjLst[i].paperTitle + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">[关键字]' + arrvgs_PaperVObjLst[i].keyword + '[类型]' + arrvgs_PaperVObjLst[i].literatureTypeName + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">' + arrvgs_PaperVObjLst[i].paperContent + '</div>';
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
        //小组历史答案
        async BindList_vqa_AnswerVersion() {
            var arrqa_AnswerVObjLst = [];
            var strWhereCond = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " answerId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  answerId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  answerId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsqa_AnswerVerWApi_js_1.qa_AnswerVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrqa_AnswerVObjLst = jsonData;
                });
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1 and isGSuser=1");
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrqa_AnswerVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrqa_AnswerVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrqa_AnswerVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    ////先判断段落类型，根据类型判断是图片，还是段落；
                    //if (arrgs_PaperParagraphVObjLst[i].paragraphTypeId == "02") {
                    //    //图片，如果图片存放字段不为空
                    //    if (arrgs_PaperParagraphVObjLst[i].paragraphContent != "") {
                    //        var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
                    //        var strAddressAndPortfull = strAddressAndPort + arrgs_PaperParagraphVObjLst[i].paragraphContent;
                    //        strhtml += '<div class="comment-content J_CommentContent">[内容]<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + arrgs_PaperParagraphVObjLst[i].paragraphId + '"/></div>';
                    //    }
                    //}
                    //else {
                    //文字
                    strhtml += '<div class="comment-content J_CommentContent">[内容]' + arrqa_AnswerVObjLst[i].answerContent + '</div>';
                    // }
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
        //段落版本
        async BindList_vgs_PaperParagraphVersion() {
            var arrgs_PaperParagraphVObjLst = [];
            var strWhereCond = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " paragraphId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  paragraphId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  paragraphId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsgs_PaperParagraphVerWApi_js_1.gs_PaperParagraphVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_PaperParagraphVObjLst = jsonData;
                });
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1 and isGSuser=1");
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrgs_PaperParagraphVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrgs_PaperParagraphVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrgs_PaperParagraphVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    //先判断段落类型，根据类型判断是图片，还是段落；
                    if (arrgs_PaperParagraphVObjLst[i].paragraphTypeId == "02") {
                        //图片，如果图片存放字段不为空
                        if (arrgs_PaperParagraphVObjLst[i].paragraphContent != "") {
                            var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                            var strAddressAndPortfull = strAddressAndPort + arrgs_PaperParagraphVObjLst[i].paragraphContent;
                            strhtml += '<div class="comment-content J_CommentContent">[内容]<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + arrgs_PaperParagraphVObjLst[i].paragraphId + '"/></div>';
                        }
                    }
                    else {
                        //文字
                        strhtml += '<div class="comment-content J_CommentContent">[内容]' + arrgs_PaperParagraphVObjLst[i].paragraphContent + '</div>';
                    }
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
        //会议纪要版本
        async BindList_gs_MeetingMinutesVersion() {
            var arrgs_MeetingMinutesVObjLst = [];
            var strWhereCond = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " meetingId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  meetingId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  meetingId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsgs_MeetingMinutesVerWApi_js_1.gs_MeetingMinutesVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_MeetingMinutesVObjLst = jsonData;
                });
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1 and isGSuser=1");
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrgs_MeetingMinutesVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrgs_MeetingMinutesVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrgs_MeetingMinutesVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    //文字
                    strhtml += '<div class="comment-content J_CommentContent">[内容]' + arrgs_MeetingMinutesVObjLst[i].meetingContent + '</div>';
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
        //待研究问题版本
        async BindList_gs_TobeStudiedProblemVersion() {
            var arrgs_TobeStudiedProblemVObjLst = [];
            var strWhereCond = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部版本
                strWhereCond = " problemId='" + $("#hidKeyId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人版本
                strWhereCond = "  problemId='" + $("#hidKeyId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新版本
                strWhereCond = "  problemId='" + $("#hidKeyId").val() + "' order by updDate Desc";
            }
            try {
                const responseText1 = await (0, clsgs_TobeStudiedProblemVerWApi_js_1.gs_TobeStudiedProblemVer_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_TobeStudiedProblemVObjLst = jsonData;
                });
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1 and isGSuser=1");
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrgs_TobeStudiedProblemVObjLst.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var objUser = arrUsers.find(x => x.userId == arrgs_TobeStudiedProblemVObjLst[i].updUser);
                    if (objUser != null) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + objUser.userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrgs_TobeStudiedProblemVObjLst[i].updDate + '</span>';
                    strhtml += '  <span class="comment-username J_User">第' + varNum + '版本</span></p>';
                    //文字
                    strhtml += '<div class="comment-content J_CommentContent">' + arrgs_TobeStudiedProblemVObjLst[i].problemContent + '</div>';
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
    }
    exports.HistoricalVersion = HistoricalVersion;
});
