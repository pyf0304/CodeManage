import { Public_Concept } from "../GraduateEduPublicPage/Public_Concept.js";
import { Public_SysSkill } from "../GraduateEduPublicPage/Public_SysSkill.js";
import { Public_SysSocialRelations } from "../GraduateEduPublicPage/Public_SysSocialRelations.js";
import { Public_TopicObjective } from "../GraduateEduPublicPage/Public_TopicObjective.js";
import { Public_Viewpoint } from "../GraduateEduPublicPage/Public_Viewpoint.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { clsPaperSubAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js";
import { clsvPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsSysCommentEN } from "../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js";
import { clsvSysCommentEN } from "../TS/L0_Entity/GraduateEduTools/clsvSysCommentEN.js";
import { clsvgs_PaperReportEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_PaperReportEN.js";
import { clsvgs_ResearchResultEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchResultEN.js";
import { clsvqa_AnswerEN } from "../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { PaperReadWrite_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js";
import { PaperSubAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js";
import { vPaperReadWrite_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { vPaperSubViewpoint_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { SysComment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { vSysComment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js";
import { vgs_PaperReport_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_PaperReportWApi.js";
import { vgs_ResearchResult_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchResultWApi.js";
import { vqa_Answer_GetFirstObjAsync } from "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { SysCommentEx_AddNewRecordExAsync, SysCommentEx_DelRecordAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { Format } from "../TS/PubFun/clsString.js";


declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogTwo(): void;
declare var $;
declare var window;
declare function RefreshWindow(): void;
declare function AlertOK(): void;
declare function AlertNo(): void;
declare function AlertScore(): void;
declare function AlertComment(): void;
declare function SetFontSize(): void;
/* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class SysCommentEx {

    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPublocalStorage.userId != "") {

                //显示当前打分类型
                const gvResult1 = await this.Showdiv_ScoreType();
                //显示当前评论的观点
                const gvResult2 = await this.Showdiv_Viewpoint();
                //评论列表
                const gvResult3 = await this.btnShowAppraise_Click();
                SetFontSize();
                $("#divLoading").hide();

            }
            else {
                window.top.location.href = "../Web/Login";
            }


        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //显示当前打分类型
    public async Showdiv_ScoreType() {
        var strCommentTypeId = $("#hidScoreType").val();
        var strhtml = "";
        switch (strCommentTypeId) {
            case "1":
                strhtml += '<div id="pingfen2"></div>';
                break;
            case "2":
                strhtml += '<div id="pingfen2"></div>';
                break;
            case "3":
                strhtml += '<input id="txtScoreNum" name="txtScoreNum" placeholder="请输入1~100的分值" class="form-control" style="width:150px;" />';
                break;
            default:
                strhtml += '<div id="pingfen2"></div>';
                break;
        }
        //拼接；
        $("#scoreType").html(strhtml);
    }
    //显示当前评论的观点
    public async Showdiv_Viewpoint() {
        var strCommentTypeId = $("#hidCommentTypeId").val();
        switch (strCommentTypeId) {
            case "02":
                const gvResult2 = await this.BindGv_vPaperSubViewpoint();
                break;
            case "03":
                const gvResult3 = await this.Bind_vViewpoint();
                break;
            case "04":
                const gvResult4 = await this.Bind_vViewpoint();
                break;
            case "05":
                const gvResult5 = await this.Bind_vConcept();
                break;
            case "06":
                const gvResult6 = await this.Bind_vTopicObjective();
                break;
            case "07":
                const gvResult7 = await this.Bind_vTopicObjective();
                break;
            case "09":
                const gvResult8 = await this.Bind_vSysSkill();
                break;
            case "10":
                const gvResult9 = await this.Bind_vSysSocialRelations();
                break;
            case "11":
                const gvResult11 = await this.BindGv_vqa_Answer();
                break;
            case "12":
                const gvResult12 = await this.BindGv_vgs_PaperReport();
                break;
            case "13":
                const gvResult13 = await this.BindGv_vgs_ResearchResult();
                break;
            //case "22":
            //    const gvResult22 = await this.Bind_vViewpoint();
            //    break;
            //case "23":
            //    const gvResult23 = await this.Bind_vViewpoint();
            //    break;
            //case "24":
            //    const gvResult24 = await this.Bind_vConcept();
            //    break;
            //case "25":
            //    const gvResult25 = await this.Bind_vTopicObjective();
            //    break;
            //case "26":
            //    const gvResult26 = await this.Bind_vTopicObjective();
            //    break;
            //case "27":
            //    const gvResult27 = await this.Bind_vSysSkill();
            //    break;
            //case "28":
            //    const gvResult28 = await this.Bind_vSysSocialRelations();
            //    break;
            default:
                break;
        }
    }
    //绑定论文子观点数据
    public async BindGv_vPaperSubViewpoint() {

        var strWhereCond = "1=1 and subViewpointId='" + $("#hidTableKey").val() + "'";
        var strWhereCond2 = "1=1";

        var objvPaperSubViewpoint: clsvPaperSubViewpointEN;

        //获取图片
        var arrPaperSubAttachmentObjLst: Array<clsPaperSubAttachmentEN> = [];
        var arrPaperSubAttachmentObjLst2: Array<clsPaperSubAttachmentEN> = [];

        try {
            const responseRecCount4 = await PaperSubAttachment_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrPaperSubAttachmentObjLst2 = <Array<clsPaperSubAttachmentEN>>jsonData;
            });
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            const responseObjLst = await vPaperSubViewpoint_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvPaperSubViewpoint = <clsvPaperSubViewpointEN>jsonData;

                if (objvPaperSubViewpoint != null) {
                    var strhtml = "";
                    strhtml += '<div class="info" id="infoSubViewpoint"><div class="title btn-2"><a href="#" title="' + objvPaperSubViewpoint.subViewpointTypeName + '">' + objvPaperSubViewpoint.subViewpointTypeName + '</a></div>';
                    //strhtml += '<div class="info" id="infoViewpoint">';
                    strhtml += '<ul class="artlist">';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + objvPaperSubViewpoint.rwTitle + ']：</span><span class="abstract-text">' + objvPaperSubViewpoint.subViewpointContent + '</span></li>';

                    if (objvPaperSubViewpoint.sectionName != "") {

                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[论文节]：</span><span class="abstract-text">' + objvPaperSubViewpoint.sectionName + '</span></li>';
                    }

                    arrPaperSubAttachmentObjLst = arrPaperSubAttachmentObjLst2.filter(x => x.subViewpointId == objvPaperSubViewpoint.subViewpointId);
                    if (arrPaperSubAttachmentObjLst.length > 0) {
                        //var strAddressAndPort = "https://www.sh-tz.com/GraduateStudyWebApp/";
                        var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
                        for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {

                            var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img data-action="zoom" src="' + strAddressAndPortfull + '" style="max-width:500px; margin-left: 10px;" alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';

                        }
                    }

                    if (objvPaperSubViewpoint.explainContent != "") {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + objvPaperSubViewpoint.explainTypeName + ']：</span><span class="abstract-text">' + objvPaperSubViewpoint.explainContent + '</span></li>';

                    }

                    //if (objvPaperSubViewpoint.literatureSourcesId != "") {
                    //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[引用文献]：</span><span class="abstract-text">' + objvPaperSubViewpoint.PaperNameEx + '(作者：' + objvPaperSubViewpoint.AuthorEx + ')</span></li>';

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
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //--------------------------------------- 论文项目
    //绑定观点数据
    public async Bind_vViewpoint() {
        var strViewpointId = $("#hidTableKey").val()
        var strHtml = await Public_Viewpoint.Bind_vViewpoint(strViewpointId)
        $("#div_Viewpoint").html(strHtml);
    }

    //绑定相关概念
    public async Bind_vConcept() {
        var strConceptId = $("#hidTableKey").val()
        var strHtml = await Public_Concept.Bind_vConcept(strConceptId)
        $("#div_Viewpoint").html(strHtml);
    }

    //客观事实、客观数据
    public async Bind_vTopicObjective() {
        var strTopicObjectiveId = $("#hidTableKey").val()
        var strHtml = await Public_TopicObjective.Bind_vTopicObjective(strTopicObjectiveId)
        $("#div_Viewpoint").html(strHtml);
    }

    //技能
    public async Bind_vSysSkill() {
        var strSkillId = $("#hidTableKey").val()
        var strHtml = await Public_SysSkill.Bind_vSysSkill(strSkillId)
        $("#div_Viewpoint").html(strHtml);

    }

    //社会关系
    public async Bind_vSysSocialRelations() {
        var strSocialId = $("#hidTableKey").val()
        var strHtml = await Public_SysSocialRelations.Bind_vSysSocialRelations(strSocialId)
        $("#div_Viewpoint").html(strHtml);
    }


    //绑定论文子观点数据
    public async BindGv_vqa_Answer() {
        var strWhereCond = "1=1 and answerId='" + $("#hidTableKey").val() + "'";
        var strWhereCond2 = "1=1";
        var objvqa_Answer: clsvqa_AnswerEN;

        try {
            const responseObjLst = await vqa_Answer_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvqa_Answer = <clsvqa_AnswerEN>jsonData;

                if (objvqa_Answer != null) {
                    var strhtml = "";
                    strhtml += '<div class="info" id="infovqa_Answer"><div class="title btn-2"><a href="#" title="' + objvqa_Answer.answerContent + '">' + objvqa_Answer.answerContent + '</a></div>';
                    //strhtml += '<div class="info" id="infoViewpoint">';
                    strhtml += '<ul class="artlist">';

                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objvqa_Answer.userName;

                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvqa_Answer.updDate;
                    strhtml += '</li>';

                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                    strhtml += '</ul></div>';

                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成BindGv_vqa_Answer!");
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }



    //绑定论文主题汇报
    public async BindGv_vgs_PaperReport() {
        var strWhereCond = "1=1 and reportId='" + $("#hidTableKey").val() + "'";
        var strWhereCond2 = "1=1";
        var objvgs_PaperReport: clsvgs_PaperReportEN;

        try {
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            const responseObjLst = await vgs_PaperReport_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvgs_PaperReport = <clsvgs_PaperReportEN>jsonData;

                if (objvgs_PaperReport != null) {
                    var strhtml = "";
                    strhtml += '<div class="info" id="infovgs_PaperReport"><div class="title btn-2"><a href="#" title="汇报内容">' + objvgs_PaperReport.reportContent + '</a></div>';
                    //strhtml += '<div class="info" id="infoViewpoint">';
                    strhtml += '<ul class="artlist">';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color2">[汇报人员]：</span><span class="abstract-text">' + objvgs_PaperReport.reportUser + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[汇报日期]：</span><span class="abstract-text">' + objvgs_PaperReport.reportDate + '</span></li>';
                    var objUser = arrUsers.find(x => x.userId == objvgs_PaperReport.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑用户]：</span><span class="abstract-text">' + objUser.userName + '</span></li>';
                    }
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span><span class="abstract-text">' + objvgs_PaperReport.updDate + '</span></li>';
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                    strhtml += '</ul></div>';

                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成BindGv_vgs_PaperReport!");
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //绑定论文主题汇报
    public async BindGv_vgs_ResearchResult() {
        var strWhereCond = "1=1 and resultId='" + $("#hidTableKey").val() + "'";
        var strWhereCond2 = "1=1";
        var objvgs_ResearchResult: clsvgs_ResearchResultEN;

        try {
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            const responseObjLst = await vgs_ResearchResult_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvgs_ResearchResult = <clsvgs_ResearchResultEN>jsonData;

                if (objvgs_ResearchResult != null) {
                    var strhtml = "";
                    strhtml += '<div class="info" id="infovgs_ResearchResult">';

                    strhtml += '<ul class="artlist">';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成果名称]：</span><span class="abstract-text">' + objvgs_ResearchResult.resultName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成果说明]：</span><span class="abstract-text">' + objvgs_ResearchResult.resultContent + '</span></li>';
                    //strhtml += '<div class="info" id="infovgs_ResearchResult"><div class="title btn-2"><a href="#" title="汇报内容">' + objvgs_ResearchResult.reportContent + '</a></div>';
                    //strhtml += '<div class="info" id="infoViewpoint">';
                    //strhtml += '<ul class="artlist">';

                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color2">[作者]：</span><span class="abstract-text">' + objvgs_ResearchResult.author + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[分工]：</span><span class="abstract-text">' + objvgs_ResearchResult.division + '</span></li>';
                    var objUser = arrUsers.find(x => x.userId == objvgs_ResearchResult.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑用户]：</span><span class="abstract-text">' + objUser.userName + '</span></li>';
                    }
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span><span class="abstract-text">' + objvgs_ResearchResult.updDate + '</span></li>';
                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                    strhtml += '</ul></div>';

                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成BindGv_vgs_ResearchResult!");
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    ////--------------------------------------中学项目
    ////绑定观点数据
    //public async Bind_ZxViewpoint() {
    //    var strViewpointId = $("#hidTableKey").val()
    //    var strHtml = await Public_zx_Viewpoint.Bind_zx_Viewpoint(strViewpointId)
    //    $("#div_Viewpoint").html(strHtml);
    //}

    ////绑定相关概念
    //public async Bind_ZxConcept() {
    //    var strConceptId = $("#hidTableKey").val()
    //    var strHtml = await Public_zx_Concept.Bind_zx_Concept(strConceptId)
    //    $("#div_Viewpoint").html(strHtml);
    //}

    ////客观事实、客观数据
    //public async Bind_ZxTopicObjective() {
    //    var strTopicObjectiveId = $("#hidTableKey").val()
    //    var strHtml = await Public_zx_TopicObjective.Bind_zx_TopicObjective(strTopicObjectiveId)
    //    $("#div_Viewpoint").html(strHtml);
    //}

    ////技能
    //public async Bind_ZxSysSkill() {
    //    var strSkillId = $("#hidTableKey").val()
    //    var strHtml = await Public_zx_SysSkill.Bind_zx_Skill(strSkillId)
    //    $("#div_Viewpoint").html(strHtml);

    //}

    ////社会关系
    //public async Bind_ZxSysSocialRelations() {
    //    var strSocialId = $("#hidTableKey").val()
    //    var strHtml = await Public_zx_SocialRelations.Bind_zx_SocialRelations(strSocialId)
    //    $("#div_Viewpoint").html(strHtml);
    //}

    //显示评论
    public async btnShowAppraise_Click() {

        var arrvSysCommentObjLst1: Array<clsvSysCommentEN> = [];
        var arrvSysCommentObjLst2: Array<clsvSysCommentEN> = [];
        var arrvSysCommentObjLst3: Array<clsvSysCommentEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        var strUserId = clsPublocalStorage.userId;


        if ($('#hidOrderbyId').val() == "1") {
            //全部评论
            strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Desc";
        }

        //var strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
        //var strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";

        try {
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            const responseText1 = await vSysComment_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvSysCommentObjLst1 = <Array<clsvSysCommentEN>>jsonData;
            });
            const responseText2 = await vSysComment_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvSysCommentObjLst2 = <Array<clsvSysCommentEN>>jsonData;
            });

            var strhtml = "";
            var varNum = 0;
            $('#J_ShortComment div').remove();
            for (var i = 0; i < arrvSysCommentObjLst1.length; i++) {
                varNum++;
                strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                var strUserName: string = "";
                var objUser = arrUsers.find(x => x.userId == arrvSysCommentObjLst1[i].updUser);
                if (objUser != null) {
                    strUserName = objUser.userName;
                }
                if ($("#hidUser").val() == arrvSysCommentObjLst1[i].updUser) {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842 style="color:red;" > 楼主：' + strUserName + '</span>';
                } else {
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
                        var strUserName: string = "";
                        var objUser = arrUsers.find(x => x.userId == arrvSysCommentObjLst3[j].updUser);
                        if (objUser != null) {
                            strUserName = objUser.userName;
                        }
                        if ($("#hidUser").val() == arrvSysCommentObjLst3[j].updUser) {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328" style="color:red;"> 楼主(' + strUserName + ')</b>：</span>';
                        } else {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328">' + strUserName + '</b>：</span>';
                        }
                        strhtml += '' + arrvSysCommentObjLst3[j].comment + '</div>';



                        strhtml += '<div class="reply-operate reply-operate--hot">'
                        if (arrvSysCommentObjLst3[j].scoreType == "2") {
                            strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrvSysCommentObjLst3[j].score + '</i></span>';
                        } else {
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
                } else {
                    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrvSysCommentObjLst1[i].score + '</i></span>';
                }

                strhtml += '<span class="J_Vote comment-operate-item comment-operate-up">赞<i>1</i></span>';
                strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyComment_Click("' + arrvSysCommentObjLst1[i].commentId + '")>回复</span>';
                strhtml += '</div>';

                if (strUserId == arrvSysCommentObjLst1[i].updUser) {
                    strhtml += '<div class="J_Report comment-report" id="J_Report6673850347411436155" onclick=btnDeleteComment_Click("' + arrvSysCommentObjLst1[i].commentId + '")>删除</div>';
                }
                strhtml += '</div></div>';
            }
            $("#J_ShortComment").append(strhtml);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取数据不成功,${e}.`;
            alert(strMsg);
        }

    }


    /* 添加评论内容
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async SubmitAppraise_Click() {
        var strUserId = clsPublocalStorage.userId;
        var strRoleId = clsPublocalStorage.roleId;

        var objSysCommentEN: clsSysCommentEN = new clsSysCommentEN();
        //this.PutDataToSysCommentClass(objSysCommentEN);
        objSysCommentEN.SetTableKey($("#hidTableKey").val());
        objSysCommentEN.SetCommentTypeId($("#hidCommentTypeId").val());
        objSysCommentEN.SetParentId($("#hidParentId").val());
        objSysCommentEN.SetPubParentId($("#hidPubParentId").val());
        objSysCommentEN.SetUserId($("#hidUser").val());//被评论用户
        objSysCommentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);

        if (strRoleId == "00620003") {
            objSysCommentEN.SetScoreType("1");

        } else {
            objSysCommentEN.SetScoreType("2");

        }

        //判断分值类型，分别赋值
        var strvalue = "";
        var strScore = "";
        if ($("#hidScoreType").val() == "3") {
            strvalue = $("#txtScoreNum").val();
            strScore = strvalue;
        } else {

            //strvalue = $("#pin").val();
            //strScore = this.GetScorebyText(strvalue);
            strvalue = $("#hidScoreNum").val();
            strScore = strvalue;
        }


        //判断是否有打分 
        if (strvalue != "" && strvalue != undefined) {
            //获取值转化分数



            //判断内容是否输入
            if ($("#txtAppraiseContent").val() != "") {
                objSysCommentEN.SetComment( $("#txtAppraiseContent").val());// 评议内容
                objSysCommentEN.SetScore( parseFloat(strScore));// 打分
                objSysCommentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
                objSysCommentEN.SetUpdUser(strUserId);// 修改用户Id
                try {
                    const responseText2 = await SysCommentEx_AddNewRecordExAsync(objSysCommentEN);
                    //const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN);
                    var returnBool: boolean = !!responseText2;
                    if (returnBool == true) {
                        //var strInfo: string = `添加成功!`;
                        ////$('#lblResult40').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                        HideDialog();
                        $("#btnOKUpdAppraise").attr("disabled", false);
                        const response1 = await this.btnShowAppraise_Click();
                        const response2 = await this.SynStatistics();
                        RefreshWindow();
                        AlertOK();
                    }
                    else {
                        var strInfo: string = `添加失败!`;
                        //$('#lblResult40').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        HideDialog();
                        $("#btnOKUpdAppraise").attr("disabled", false);

                    }

                    $("#J_PostBtn").attr("disabled", false);
                    $("#btnOKUpdAppraise").attr("disabled", false);
                    return responseText2;//一定要有一个返回值，否则会出错！
                }
                catch (e) {
                    $("#J_PostBtn").attr("disabled", false);
                    $("#btnOKUpdAppraise").attr("disabled", false);
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg: string = `添加评论不成功,${e}.`;
                    alert(strMsg);
                }
            }
            else {
                $("#J_PostBtn").attr("disabled", false);
                $("#btnOKUpdAppraise").attr("disabled", false);
                AlertComment();
                //var strInfo: string = `请输入评语!`;
                ////显示信息框
                //alert(strInfo);
                return;
            }

        }
        else {
            $("#J_PostBtn").attr("disabled", false);
            $("#btnOKUpdAppraise").attr("disabled", false);

            AlertScore();
            //var strInfo: string = `请选择评分!`;
            ////显示信息框
            //alert(strInfo);
            return;
        }
        return true;//一定要有一个返回值，否则会出错！
    }


    //通过得到的值判断，得到分数
    public GetScorebyText(sValue: string) {

        var Score: string = "";
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




    /* 
    删除评论内容
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDeleteComment_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelRecord(strKeyId);
            const response1 = await this.btnShowAppraise_Click();
            const response2 = await this.SynStatistics();
            RefreshWindow();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public DelRecord(strCommentId: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysCommentEx_DelRecordAsync(strCommentId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        AlertNo();
                        //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        ////显示信息框
                        //alert(strInfo);
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
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
                var strMsg: string = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }



    //添加删除评论的时候统计其他表的部分数据
    public async SynStatistics() {
        const strThisFuncName = this.SynStatistics.name;

        var strCommentTypeId = $("#hidCommentTypeId").val();
        var strRoleId = clsPublocalStorage.roleId;
        //论文子观点
        if (strCommentTypeId == "02") {
            //教师或者管理员权限
            if (strRoleId != "00620003") {
                var strPaperRWId = $("#hidPubParentId").val();

                //添加记录的同时并记录论文读写的教师评价数
                var strWhereCond = "   commentTypeId='02' and scoreType='2' and pubParentId=" + strPaperRWId;
                var intTeaCount = await SysComment_GetRecCountByCondAsync(strWhereCond);

                var objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
                objPaperReadWriteEN.SetPaperRWId(strPaperRWId);
                objPaperReadWriteEN.SetTeaCount(intTeaCount);

                objPaperReadWriteEN.sfUpdFldSetStr = objPaperReadWriteEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }

                const responseText = await PaperReadWrite_UpdateRecordAsync(objPaperReadWriteEN);
                var returnBool: boolean = !!responseText;
                if (returnBool == true) {
                    //刷新缓存
                    vPaperReadWrite_ReFreshThisCache(clsPublocalStorage.id_CurrEduCls);
                    console.log("添加教师评价数量成功！");
                }
                else {

                    console.log("添加教师评价数量失败！");
                }
                //添加记录的同时并记录论文读写的教师评价数

            }
        }

    }

}


















