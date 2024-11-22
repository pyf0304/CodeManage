﻿import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsgs_OriginalPaperLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js";
import { clsgs_PaperDiscussEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperDiscussEN.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { clsPaperSubAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsvPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsvConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsViewpointAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { gs_OriginalPaperLog_AddNewRecordAsync, gs_OriginalPaperLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js";
import { gs_PaperDiscuss_AddNewRecordAsync, gs_PaperDiscuss_DelRecordAsync, gs_PaperDiscuss_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperDiscussWApi.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { PaperReadWrite_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js";
import { PaperSubAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js";
import { vPaperReadWrite_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { vPaperSubViewpoint_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { SysComment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { ResearchTopic_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { vConcept_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { ViewpointAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js";
import { vSysSkill_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { vSysSocialRelations_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vTopicObjective_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { vViewpoint_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { vPaperEx_GetSubObjLstById_CurrEduCls_Cache } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsSysPara4WebApi2 } from "../TS/PubFun/clsSysPara4WebApi2.js";
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

/* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_PaperDiscussEx {

    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {
                //通过主题Id获取教学班ID
                if ($("#hidId_CurrEduCls").val() == "") {
                    var objResearchTopic: clsResearchTopicEN = await ResearchTopic_GetFirstObjAsync(" topicId=" + $("#hidPubParentId").val());
                    $("#hidId_CurrEduCls").val(objResearchTopic.id_CurrEduCls);
                } 
                //显示当前评论的观点
                //const gvResult1 = await this.Showdiv_Viewpoint()
                const responseObjLst1 = await this.GetPaperData();

                //绑定pdf
                const responseText1 = await this.BindPdf();

                //评论列表
                const gvResult2 = await this.btnShowAppraise_Click();
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

    //显示自研论文数据；
    public async GetPaperData() {
        var strPaperId = $('#hidPaperId').val();

        var strid_CurrEducls = $("#hidId_CurrEduCls").val();
        var objvPaper_Cond: clsvPaperEN = new clsvPaperEN();//查询区域
        var arrvPaperObjLst: Array<clsvPaperEN> = [];
        objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_PaperId, strPaperId, "=");
        arrvPaperObjLst = await vPaperEx_GetSubObjLstById_CurrEduCls_Cache(objvPaper_Cond, strid_CurrEducls);
        //获取用户缓存；
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
        var strhtml = "";
        //var strWhereCond1 = " 1=1 and paperId ='" + pobjvPaperReadWriteEN.paperId + "'";
        //var strWhereCond2 = " 1=1 and paperId ='" + pobjvPaperReadWriteEN.paperId + "' and updUser='" + $("#hidUserId").val() + "'";

        try {
            //const responseText1 = await vPaperCount_GetFirstObjAsync(strWhereCond1);
            //objvPaperCount = <clsvPaperCountEN>responseText1;

            //const responseText2 = await PaperLikeLog_GetFirstObjAsync(strWhereCond2);
            //objPaperLikeLog = <clsPaperLikeLogEN>responseText2;

            //const responseText3 = await PaperCollectionLog_GetFirstObjAsync(strWhereCond2);
            //objPaperCollectionLog = <clsPaperCollectionLogEN>responseText3;

            var strhtml = "";
            for (var i = 0; i < arrvPaperObjLst.length; i++) {

                strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看', '../GraduateEduEx/PaperDetail?paperId=" + arrvPaperObjLst[i].paperId + "')\"><span style='color:#c7228d;'>" + arrvPaperObjLst[i].paperTitle + "</a>";
                if (arrvPaperObjLst[i].attachmentCount > 0) {
                    strhtml += "<span class=\"btn-2\" style=\"padding-left:50px;\"><a style=\"font-size:15px; color:#f98c51\" href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvPaperObjLst[i].paperId + "')\">pdf查看</a></span>";
                }
                strhtml += '</h6>';

                strhtml += '<div class="baseinfo"><span><a href="#">' + arrvPaperObjLst[i].periodical + '</a></span><span><a href="#">' + arrvPaperObjLst[i].keyword + '</a></span>';
                strhtml += '</div>';
                //<span>' + arrvPaperObjLst[i].periodical + ' < /span><em>' + arrvPaperObjLst[i].keyword + '</em >
                strhtml += '<div class="abstract">' + arrvPaperObjLst[i].paperContent + '</div>';

                strhtml += '<div class="opts"><ul class="opts-count">';
                strhtml += '<li>评论数:<em>' + arrvPaperObjLst[i].appraiseCount + '</em></li>';
                strhtml += '<li>读写数:<em>' + arrvPaperObjLst[i].pcount + '</em></li><li>发表日期:<em>' + arrvPaperObjLst[i].updDate + '</em></li>';
                var objUser = arrUsers.find(x => x.userId == arrvPaperObjLst[i].updUser)
                if (objUser != null) {
                    strhtml += '<li>发表人:<em>' + objUser.userName + '</em></li>';
                }
                
                strhtml += '<ul class="opts-btn">';

                //存放论文编辑用户
                $("#hidUser").val(arrvPaperObjLst[i].updUser);


                //if (arrvPaperObjLst[i].attachmentCount > 0) {
                //    strhtml += '<li>' + arrvPaperObjLst[i].downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click()><i></i><b>点击下载</b></a></li>';
                //} else {
                //    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                //}

                strhtml += '</ul></div>';
                strhtml += '</dd></dl></div>';
            }


            $("#tabwucPaperReadWrite").html(strhtml);



        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定论文对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }

    }

    //绑定论文pdf
    public async BindPdf() {
        try {
            //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
            var strPaperId = $('#hidPaperId').val();

            //var objPaperAttachment: clsPaperAttachmentEN;
            var strWhereCond = " 1=1 and paperId ='" + strPaperId + "'";
            var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
            arrPaperAttachmentObjLst = await PaperAttachment_GetObjLstAsync(strWhereCond);
            //objPaperAttachment = <clsPaperAttachmentEN>responseText;
            var strDiscussTypeId = $("#hidCommentTypeId").val();
            var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
            var strhtml = "";
            var strfilepath = "";
            for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {
                if (strDiscussTypeId == "01") {
                    if (i == 0)
                    {
                        strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                    }
                } else {
                    if (i == 1) {
                        strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                    }
                }
            }
            strhtml = "<iframe src='../GraduateEduEx/Pdf?file=" + strfilepath + "' style=\"height:100%;width:99%; min-height:700px;\"></iframe>";
            $("#div_pdf").html(strhtml);

            //if (objPaperAttachment != null) {
            //    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
            //    var strhtml = "";
            //    strhtml = "<iframe src='../GraduateEduEx/Pdf?file=" + strfilepath + "' style=\"height:100%;width:99%; min-height:700px;\"></iframe>";
            //    $("#div_pdf").html(strhtml);

            //} else {
            //    var strhtml = "";
            //    strhtml = "<iframe src='../GraduateEduEx/Pdf' style=\"height:100%;width:99%; min-height:700px;\"></iframe>";
            //    $("#div_pdf").html(strhtml);
            //}
        }
        catch (e) {
            var strMsg: string = `获取pdf附件数据有问题,${e}.`;
            alert(strMsg);
        }


    }

    public async Showdiv_Viewpoint() {
        var strCommentTypeId = $("#hidCommentTypeId").val();
        switch (strCommentTypeId) {
            case "02":
                const gvResult2 = await this.BindGv_vPaperSubViewpoint();
                break;
            case "03":
                const gvResult3 = await this.BindGv_vViewpoint();
                break;
            case "04":
                const gvResult4 = await this.BindGv_vViewpoint();
                break;
            case "05":
                const gvResult5 = await this.BindGv_Concept();
                break;
            case "06":
                const gvResult6 = await this.BindGv_vTopicObjective();
                break;
            case "07":
                const gvResult7 = await this.BindGv_vTopicObjective();
                break;
            case "09":
                const gvResult8 = await this.BindGv_vSysSkill();
                break;
            case "10":
                const gvResult9 = await this.BindGv_vSysSocialRelations();
                break;
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
        //获取用户缓存数据
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

        try {
            const responseRecCount4 = await PaperSubAttachment_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrPaperSubAttachmentObjLst2 = <Array<clsPaperSubAttachmentEN>>jsonData;
            });

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
                        var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
                        for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {

                            var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" style="max-width:500px; margin-left: 10px;" alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';

                        }
                    }

                    if (objvPaperSubViewpoint.explainContent != "") {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + objvPaperSubViewpoint.explainTypeName + ']：</span><span class="abstract-text">' + objvPaperSubViewpoint.explainContent + '</span></li>';

                    }

                    //if (objvPaperSubViewpoint.literatureSourcesId != "") {

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

    //绑定观点数据
    public async BindGv_vViewpoint() {
        var strWhereCond = "1=1 and viewpointId='" + $("#hidTableKey").val() + "'";
        //附件
        var strWhereCondAttachment = "1=1";

        var objvViewpoint: clsvViewpointEN;
        //获取图片
        var arrViewpointAttachmentObjLst: Array<clsViewpointAttachmentEN> = [];
        var arrViewpointAttachmentObjLst2: Array<clsViewpointAttachmentEN> = [];
        try {
            const responseRecCount5 = await ViewpointAttachment_GetObjLstAsync(strWhereCondAttachment).then((jsonData) => {
                arrViewpointAttachmentObjLst2 = <Array<clsViewpointAttachmentEN>>jsonData;
            });

            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
            const responseObjLst = await vViewpoint_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvViewpoint = <clsvViewpointEN>jsonData;

                if (objvViewpoint != null) {
                    var strhtml = "";
                    //个人观点
                    strhtml += '<div class="info" id="infoViewpoint">';
                    strhtml += '<ul class="artlist">';

                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点]：</span><span class="abstract-text">' + objvViewpoint.viewpointName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[内容]：</span><span class="abstract-text">' + objvViewpoint.viewpointContent + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + objvViewpoint.viewpointTypeName + ']：</span><span class="abstract-text">' + objvViewpoint.reason + '</span></li>';
                    //查询附件
                    arrViewpointAttachmentObjLst = arrViewpointAttachmentObjLst2.filter(x => x.viewpointId == objvViewpoint.viewpointId);
                    if (arrViewpointAttachmentObjLst.length > 0) {

                        //var strAddressAndPort = "https://www.sh-tz.com/GraduateStudyWebApp/";
                        var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;

                        for (var y = 0; y < arrViewpointAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrViewpointAttachmentObjLst[y].filePath;
                            strhtml += '<li><img src="' + strAddressAndPortfull + '" style="max-width:500px; margin-left: 10px; " alt="" id="txtImgPath' + arrViewpointAttachmentObjLst[y].viewpointAttachmentId + '"/></li>';
                        }
                    }
                    var objUser = arrUsers.find(x => x.userId == objvViewpoint.updUser)
                    if (objUser != null) 
                        {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                        }
                  
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvViewpoint.updDate;
                    strhtml += '</li>';

                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                    strhtml += '</ul></div>';

                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成BindGv_vViewpoint!");
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

    //绑定相关概念
    public async BindGv_Concept() {
        var strWhereCond = "1=1 and conceptId='" + $("#hidTableKey").val() + "'";
        var objvConcept: clsvConceptEN;

        try {
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
            const responseObjLst = await vConcept_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvConcept = <clsvConceptEN>jsonData;

                if (objvConcept != null) {
                    var strhtml = "";
                    strhtml += '<div class="info" id="infoViewpoint">';
                    strhtml += '<ul class="artlist">';

                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[概念]：</span><span class="abstract-text">' + objvConcept.conceptName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + objvConcept.conceptContent + '</span></li>';
                    var objUser = arrUsers.find(x => x.userId == objvConcept.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvConcept.updDate;
                    strhtml += '</li>';

                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                    strhtml += '</ul></div>';

                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成BindGv_vViewpoint!");
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


    //客观事实、客观数据
    public async BindGv_vTopicObjective() {
        var strWhereCond = "1=1 and topicObjectiveId='" + $("#hidTableKey").val() + "'";
        var objvTopicObjective: clsvTopicObjectiveEN;

        try {
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
            const responseObjLst = await vTopicObjective_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvTopicObjective = <clsvTopicObjectiveEN>jsonData;

                if (objvTopicObjective != null) {
                    var strhtml = "";
                    //个人观点
                    strhtml += '<div class="info" id="infoViewpoint">';
                    strhtml += '<ul class="artlist">';

                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[标题]：</span><span class="abstract-text">' + objvTopicObjective.objectiveName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + objvTopicObjective.objectiveContent + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + objvTopicObjective.conclusion + '</span></li>';
                    var objUser = arrUsers.find(x => x.userId == objvTopicObjective.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvTopicObjective.updDate;
                    strhtml += '</li>';

                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                    strhtml += '</ul></div>';

                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成BindGv_vTopicObjective!");
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


    //技能
    public async BindGv_vSysSkill() {
        var strWhereCond = "1=1 and skillId='" + $("#hidTableKey").val() + "'";
        var objvSysSkill: clsvSysSkillEN;

        try {
            //获取用户缓存数据
            //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            const responseObjLst = await vSysSkill_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvSysSkill = <clsvSysSkillEN>jsonData;

                if (objvSysSkill != null) {
                    var strhtml = "";
                    //技能
                    strhtml += '<div class="info" id="infoViewpoint">';
                    strhtml += '<ul class="artlist">';

                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[技能]：</span><span class="abstract-text">' + objvSysSkill.skillName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[类型]：</span><span class="abstract-text">' + objvSysSkill.operationTypeName + '</span>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[保密等级]：</span><span class="abstract-text">' + objvSysSkill.levelName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[实施过程]：</span><span class="abstract-text">' + objvSysSkill.process + '</span></li>';

                    var objUser = arrUsers.find(x => x.userId == objvSysSkill.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvSysSkill.updDate;
                    strhtml += '</li>';

                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                    strhtml += '</ul></div>';

                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成BindGv_vSysSkill!");
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


    //社会关系
    public async BindGv_vSysSocialRelations() {
        var strWhereCond = "1=1 and socialId='" + $("#hidTableKey").val() + "'";
        var objvSysSocialRelations: clsvSysSocialRelationsEN;

        try {
            //获取用户缓存数据
            //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            const responseObjLst = await vSysSocialRelations_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvSysSocialRelations = <clsvSysSocialRelationsEN>jsonData;

                if (objvSysSocialRelations != null) {
                    var strhtml = "";
                    //技能
                    strhtml += '<div class="info" id="infoViewpoint">';
                    strhtml += '<ul class="artlist">';

                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[姓名]：</span><span class="abstract-text">' + objvSysSocialRelations.fullName + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[国籍]：</span><span class="abstract-text">' + objvSysSocialRelations.nationality + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[工作单位]：</span><span class="abstract-text">' + objvSysSocialRelations.workUnit + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[专业]：</span><span class="abstract-text">' + objvSysSocialRelations.major + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[成就]：</span><span class="abstract-text">' + objvSysSocialRelations.achievement + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[详细说明]：</span><span class="abstract-text">' + objvSysSocialRelations.detailedDescription + '</span></li>';

                    var objUser = arrUsers.find(x => x.userId == objvSysSocialRelations.updUser);
                    if (objUser != null) {
                        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + objvSysSocialRelations.updDate;
                    strhtml += '</li>';

                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                    strhtml += '</ul></div>';

                    //拼接；
                    $("#div_Viewpoint").html(strhtml);
                    console.log("完成BindGv_vSysSocialRelations!");
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

    //显示评论
    public async btnShowAppraise_Click() {

        var arrgs_PaperDiscussObjLst1: Array<clsgs_PaperDiscussEN> = [];
        var arrgs_PaperDiscussObjLst2: Array<clsgs_PaperDiscussEN> = [];
        var arrgs_PaperDiscussObjLst3: Array<clsgs_PaperDiscussEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        var strUserId = clsPubSessionStorage.GetSession_UserId();


        if ($('#hidOrderbyId').val() == "1") {
            //全部评论
            strWhereCond1 = " parentId='root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' order by updDate Desc";
        }

        //var strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
        //var strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";

        try {

            const responseText1 = await gs_PaperDiscuss_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrgs_PaperDiscussObjLst1 = <Array<clsgs_PaperDiscussEN>>jsonData;
            });
            const responseText2 = await gs_PaperDiscuss_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrgs_PaperDiscussObjLst2 = <Array<clsgs_PaperDiscussEN>>jsonData;
            });

            //获取用户缓存数据
            var arrvUserStuNameObjLst: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            var strhtml = "";
            var varNum = 0;
            $('#J_ShortComment div').remove();
            for (var i = 0; i < arrgs_PaperDiscussObjLst1.length; i++) {
                varNum++;
                //获取用户名
                var arrvUsers: Array<clsvUsersSimEN> = [];
                var UpdUserName;//编辑人
                arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrgs_PaperDiscussObjLst1[i].updUser);//技能引用人
                for (var j = 0; j < arrvUsers.length; j++) {
                    UpdUserName = arrvUsers[j].userName;
                    break;
                }


                strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                if ($("#hidUser").val() == arrgs_PaperDiscussObjLst1[i].updUser) {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842 style="color:red;" > 楼主：' + UpdUserName + '</span>';
                } else {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + UpdUserName + '</span>';
                }
                strhtml += '<span class="comment-time">' + arrgs_PaperDiscussObjLst1[i].updDate + '</span>';
                strhtml += '  <span class="comment-username J_User">' + varNum + '楼</span></p>';
                //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                strhtml += '<div class="comment-content J_CommentContent">' + arrgs_PaperDiscussObjLst1[i].discussContent + '</div>';

                //回复区

                arrgs_PaperDiscussObjLst3 = arrgs_PaperDiscussObjLst2.filter(x => x.parentId == arrgs_PaperDiscussObjLst1[i].discussId);
                if (arrgs_PaperDiscussObjLst3.length > 0) {
                    strhtml += '<div class="reply J_ReplyBlock">';
                    for (var j = 0; j < arrgs_PaperDiscussObjLst3.length; j++) {

                        //获取用户名
                        var arrvUsers: Array<clsvUsersSimEN> = [];
                        var UpdUserName;//编辑人
                        arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrgs_PaperDiscussObjLst3[i].updUser);//技能引用人
                        for (var j = 0; j < arrvUsers.length; j++) {
                            UpdUserName = arrvUsers[j].userName;
                            break;
                        }



                        strhtml += '<div class="reply-block">';

                        strhtml += '<div class="reply-content">';
                        if ($("#hidUser").val() == arrgs_PaperDiscussObjLst3[j].updUser) {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328" style="color:red;"> 楼主(' + UpdUserName + ')</b>：</span>';
                        } else {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328">' + UpdUserName + '</b>：</span>';
                        }
                        strhtml += '' + arrgs_PaperDiscussObjLst3[j].discussContent + '</div>';



                        //strhtml += '<div class="reply-operate reply-operate--hot">'
                        //if (arrgs_PaperDiscussObjLst3[j].scoreType == "2") {
                        //    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrgs_PaperDiscussObjLst3[j].score + '</i></span>';
                        //} else {
                        //    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrgs_PaperDiscussObjLst3[j].score + '</i></span>';
                        //}
                        //strhtml += '<i class="reply-dot">·</i><span>' + arrgs_PaperDiscussObjLst3[j].updDate + '</span>';
                        //strhtml += '</div>';


                        strhtml += '</div>';

                    }
                    strhtml += '</div>';
                }
                ///评论区
                strhtml += '<div class="comment-operate J_CommentOperate clearfix">';
                //if (arrgs_PaperDiscussObjLst1[i].scoreType == "2") {
                //    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrgs_PaperDiscussObjLst1[i].score + '</i></span>';
                //} else {
                //    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrgs_PaperDiscussObjLst1[i].score + '</i></span>';
                //}

                strhtml += '<span class="J_Vote comment-operate-item comment-operate-up">赞<i>1</i></span>';
                strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyComment_Click("' + arrgs_PaperDiscussObjLst1[i].discussId + '")>回复</span>';
                strhtml += '</div>';

                if (strUserId == arrgs_PaperDiscussObjLst1[i].updUser) {
                    strhtml += '<div class="J_Report comment-report" id="J_Report6673850347411436155" onclick=btnDeleteComment_Click("' + arrgs_PaperDiscussObjLst1[i].discussId + '")>删除</div>';
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
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var strRoleId = clsPubSessionStorage.GetSession_RoleId();

        var strPaperLogTypeId = $('#hidPaperLogTypeId').val();
        var strTableKey = $("#hidTableKey").val();
        //用来区分 小组讨论 或同伴建议 01 02
        var strDiscussTypeId = $("#hidCommentTypeId").val();
        var objgs_PaperDiscussEN: clsgs_PaperDiscussEN = new clsgs_PaperDiscussEN();
        //this.PutDataToSysCommentClass(objSysCommentEN);
        objgs_PaperDiscussEN.paperId = $("#hidTableKey").val();
        objgs_PaperDiscussEN.parentId = $("#hidParentId").val();
        objgs_PaperDiscussEN.discussTypeId = strDiscussTypeId;
        objgs_PaperDiscussEN.userId = $("#hidUser").val();//被评论用户
        objgs_PaperDiscussEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();

        if (strRoleId == "00620003") {
            objgs_PaperDiscussEN.scoreType = "1";

        } else {
            objgs_PaperDiscussEN.scoreType = "2";
        }

        //var strvalue = $("#pin").val();
        ////判断是否有打分 
        //if (strvalue != "" && strvalue != undefined) {
        //    //获取值转化分数
        //    var strScore: string = this.GetScorebyText(strvalue);

            //判断内容是否输入
        if ($("#txtAppraiseContent").val() != "") {
            objgs_PaperDiscussEN.discussContent = $("#txtAppraiseContent").val();// 评议内容
               // objgs_PaperDiscussEN.score = parseInt(strScore);// 打分
                objgs_PaperDiscussEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
                objgs_PaperDiscussEN.updUser = strUserId;// 修改用户Id
                try {
                    const responseText2 = await gs_PaperDiscuss_AddNewRecordAsync(objgs_PaperDiscussEN);
                    //const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objgs_PaperDiscussEN);
                    var returnBool: boolean = !!responseText2;
                    if (returnBool == true) {
                     

                        //查询 论文、日志类型是否存在；
                        var strWhere = " 1 = 1 And paperId = '" + strTableKey + "' And logTypeId = '" + strPaperLogTypeId+"'";
                        const responseText3 = await gs_OriginalPaperLog_IsExistRecordAsync(strWhere);
                        var bolIsExist: boolean = responseText3;
                        if (bolIsExist == true) {
                            var strInfo: string = `评论成功`;
                            //显示信息框
                            alert(strInfo);
                            HideDialog();
                            $("#btnOKUpdAppraise").attr("disabled", false);
                            const response1 = await this.btnShowAppraise_Click();
                            return true;//一定要有一个返回值，否则会出错！
                        }
                        else {

                            //添加论文日志；
                            const responseText7 = await this.Addgs_OriginalPaperLogSave();

                            var strInfo: string = `评论成功`;
                            //显示信息框
                            alert(strInfo);
                            HideDialog();
                            $("#btnOKUpdAppraise").attr("disabled", false);
                            const response1 = await this.btnShowAppraise_Click();
                        }
                        
                        RefreshWindow();
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

        //}
        //else {
        //    $("#J_PostBtn").attr("disabled", false);
        //    $("#btnOKUpdAppraise").attr("disabled", false);

        //    AlertScore();
        //    //var strInfo: string = `请选择评分!`;
        //    ////显示信息框
        //    //alert(strInfo);
        //    return;
        //}
        return true;//一定要有一个返回值，否则会出错！
    }
    //添加论文流程日志
    public async Addgs_OriginalPaperLogSave() {


        var objgs_OriginalPaperLogEN: clsgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN();
        this.PutDataTogs_OriginalPaperLog(objgs_OriginalPaperLogEN);

        try {
            const responseText2 = await gs_OriginalPaperLog_AddNewRecordAsync(objgs_OriginalPaperLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                console.log("添加新建论文日志成功");

            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加日志记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }
    public async PutDataTogs_OriginalPaperLog(pobjgs_OriginalPaperLogEN: clsgs_OriginalPaperLogEN) {
        var strPaperId = $("#hidPaperId").val();
        var strPaperLogTypeId = $("#hidPaperLogTypeId").val();
        //通过区分 是小组讨论还是同伴建议
        var strTypeId = $('#hidCommentTypeId').val();
        pobjgs_OriginalPaperLogEN.paperId = strPaperId;
        pobjgs_OriginalPaperLogEN.logTypeId = strPaperLogTypeId;
        switch (strTypeId) {
            case "01":
                pobjgs_OriginalPaperLogEN.logDescription = "小组讨论";
                break;
            case "02":
                pobjgs_OriginalPaperLogEN.logDescription = "同伴建议";
                break;
          
            default:
                var strMsg = `没有数据处理！`;
                alert(strMsg);
                break;
        }
        //pobjgs_OriginalPaperLogEN.logDescription = "新建论文";
        pobjgs_OriginalPaperLogEN.updUser = clsPubSessionStorage.GetSession_UserId();
        pobjgs_OriginalPaperLogEN.updDate = clsPubFun4Web.getNowDate();
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
           // const response2 = await this.SynStatistics();
          //  RefreshWindow();
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
    public async DelRecord(strCommentId: string) {
        try {
            const responseText = await gs_PaperDiscuss_DelRecordAsync(strCommentId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelRecord!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }


        //return new Promise((resolve, reject) => {
        //    try {
        //        const responseText = await gs_PaperDiscuss_DelRecordAsync(strCommentId).then((jsonData) => {
        //            var returnInt: number = jsonData;
        //            if (returnInt > 0) {
        //                AlertNo();
        //                //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
        //                ////显示信息框
        //                //alert(strInfo);
        //            }
        //            else {
        //                var strInfo: string = `删除记录不成功!`;
        //                //显示信息框
        //                alert(strInfo);
        //            }
        //            console.log("完成DelRecord!");
        //            resolve(jsonData);
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `删除记录不成功. ${e}.`;
        //        alert(strMsg);
        //    }
        //});
    }



    //添加删除评论的时候统计其他表的部分数据
    public async SynStatistics() {
        var strCommentTypeId = $("#hidCommentTypeId").val();
        var strRoleId = clsPubSessionStorage.GetSession_RoleId();
        //论文子观点
        if (strCommentTypeId == "02") {
            //教师或者管理员权限
            if (strRoleId != "00620003") {
                var strPaperRWId = $("#hidPubParentId").val();

                //添加记录的同时并记录论文读写的教师评价数
                var strWhereCond = "   commentTypeId='02' and scoreType='2' and pubParentId=" + strPaperRWId;
                var intTeaCount = await SysComment_GetRecCountByCondAsync(strWhereCond);

                var objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
                objPaperReadWriteEN.paperRWId = strPaperRWId;
                objPaperReadWriteEN.teaCount = intTeaCount;

                objPaperReadWriteEN.sf_UpdFldSetStr = objPaperReadWriteEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
                    throw "关键字不能为空!";
                }

                const responseText = await PaperReadWrite_UpdateRecordAsync(objPaperReadWriteEN);
                var returnBool: boolean = !!responseText;
                if (returnBool == true) {
                    //刷新缓存
                    vPaperReadWrite_ReFreshThisCache($("#hidId_CurrEduCls").val());
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
