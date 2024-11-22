
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsgs_ResearchResultAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchResultAttachmentEN.js";
import { clsvgs_ResearchResultEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchResultEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { PaperAttachment_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { gs_ResearchResultAttachment_GetFirstObjAsync, gs_ResearchResultAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultAttachmentWApi.js";
import { vgs_ResearchResult_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchResultWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strAddressAndPort;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ResearchResultDetail {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortUsersBy: string = "userId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }



    public async Page_Load() {
        try {
            if (clsPublocalStorage.userId != "") {


                //绑定pdf_Ifame
                const gvResult1 = await this.Menu_ResultType();

                const gvResult2 = await this.Bind_ResearchResult();

                //tbody();

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

    public async Menu_ResultType() {
        var strResultTypeId = $("#hidResultTypeId").val();

        switch (strResultTypeId) {
            case "01"://选择论文
                const gvResult1 = await this.Bind_PaperPdf();
                break;
            case "02"://pdf
                const gvResult2 = await this.Bind_Pdf();
                break;
            case "03"://图片
                const gvResult3 = await this.Bind_Img();
                
                break;
            case "04"://压缩文件
                const gvResult4 = await this.Bind_Rar();
                break;
        }
    }

    //绑定pdf_Ifame
    public async Bind_PaperPdf() {
        try {
            //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);

            var strPaperId = $("#hidPaperId").val();
            var objPaperAttachment: clsPaperAttachmentEN;
            var strWhereCond = " 1=1 and paperId ='" + strPaperId + "'";
            const responseText = await PaperAttachment_GetFirstObjAsync(strWhereCond);
            objPaperAttachment = <clsPaperAttachmentEN>responseText;

            var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
            var strhtml = "";
            if (objPaperAttachment != null) {
                var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                strhtml = "<iframe id='iframe_Pdf' scrolling='auto' src='../GraduateEduEx/Pdf?zoom=1.1&file=" + strfilepath + "' style=\"height:100%;width:100%; height:730px;\"></iframe>";

            } else {
                strhtml = "<iframe id='iframe_Pdf' scrolling='auto' src='../GraduateEduEx/Pdf?zoom=1.1' style=\"height:100%;width:100%; height:730px;\"></iframe>";
            }

            $("#leftPart").html(strhtml);

        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }


    }

    //绑定pdf_Ifame
    public async Bind_Pdf() {
        try {
            //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);

            var strResultId = $("#hidResultId").val();
            var objgs_ResearchResultAttachment: clsgs_ResearchResultAttachmentEN;
            var strWhereCond = " 1=1 and resultId ='" + strResultId + "'";
            const responseText = await gs_ResearchResultAttachment_GetFirstObjAsync(strWhereCond);
            objgs_ResearchResultAttachment = <clsgs_ResearchResultAttachmentEN>responseText;

            var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
            var strhtml = "";
            if (objgs_ResearchResultAttachment != null) {
                var strfilepath = strAddressAndPort + objgs_ResearchResultAttachment.filePath;
                strhtml = "<iframe id='iframe_Pdf' scrolling='auto' src='../GraduateEduEx/Pdf?zoom=1.1&file=" + strfilepath + "' style=\"height:100%;width:100%; height:730px;\"></iframe>";

            } else {
                strhtml = "<iframe id='iframe_Pdf' scrolling='auto' src='../GraduateEduEx/Pdf?zoom=1.1' style=\"height:100%;width:100%; height:730px;\"></iframe>";
            }

            $("#leftPart").html(strhtml);

        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }


    }

    //绑定pdf_Ifame
    public async Bind_Img() {
        try {
            //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);

            var strResultId = $("#hidResultId").val();
            
            //获取图片
            var arrgs_ResearchResultAttachmentObjLst: Array<clsgs_ResearchResultAttachmentEN> = [];
            var strWhereCond = " 1=1 and resultId ='" + strResultId + "'";

            const responseObjLst = await gs_ResearchResultAttachment_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_ResearchResultAttachmentObjLst = <Array<clsgs_ResearchResultAttachmentEN>>jsonData;
            });

            var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
            var strhtml = "";

            if (arrgs_ResearchResultAttachmentObjLst.length > 0) {
                for (var y = 0; y < arrgs_ResearchResultAttachmentObjLst.length; y++) {
                    var strAddressAndPortfull = strAddressAndPort + arrgs_ResearchResultAttachmentObjLst[y].filePath;
                    strhtml += '<div><img data-action="zoom" src="' + strAddressAndPortfull + '" style="max-width:500px; margin-left: 10px; " alt="" id="txtImgPath' + arrgs_ResearchResultAttachmentObjLst[y].mId + '"/></div>';
                }
            }

            $("#leftPart").html(strhtml);

        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }


    }

    //绑定pdf_Ifame
    public async Bind_Rar() {
        try {
            //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);

            var strResultId = $("#hidResultId").val();
            var objgs_ResearchResultAttachment: clsgs_ResearchResultAttachmentEN;
            var strWhereCond = " 1=1 and resultId ='" + strResultId + "'";
            const responseText = await gs_ResearchResultAttachment_GetFirstObjAsync(strWhereCond);
            objgs_ResearchResultAttachment = <clsgs_ResearchResultAttachmentEN>responseText;

            var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
            var strhtml = "";
            if (objgs_ResearchResultAttachment.filePath != "") {
                var strfilepath = strAddressAndPort + objgs_ResearchResultAttachment.filePath;
                var strfilename = objgs_ResearchResultAttachment.updDate + "研究的附件";
                strhtml += '<button title="下载附件" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownLoadFile_Click("' + strfilepath + '","' + strfilename + '")><i class="layui-icon">&#xe601;</i>下载附件</button>';
            }

            $("#leftPart").html(strhtml);

        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }


    }


    //绑定论文主题汇报
    public async Bind_ResearchResult() {
        var strWhereCond = "1=1 and resultId='" + $("#hidResultId").val() + "'";
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

                    strhtml += '<li>';
                    if (objvgs_ResearchResult.score != 0) {
                        //评分
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;综合评分：' + objvgs_ResearchResult.score;
                    }
                    if (objvgs_ResearchResult.teaScore != 0) {
                        strhtml += '&nbsp;&nbsp;教师评分：' + objvgs_ResearchResult.teaScore;
                    }
                    if (objvgs_ResearchResult.stuScore != 0) {
                        strhtml += '&nbsp;&nbsp;学生评分：' + objvgs_ResearchResult.stuScore + '&nbsp;&nbsp;';
                    }
                    strhtml += "&nbsp;&nbsp;&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('研究成果评论', '../GraduateEduTools/SysComment?Key=" + objvgs_ResearchResult.resultId + "&Type=13&User=" + objvgs_ResearchResult.updUser + "&pubParentId=" + objvgs_ResearchResult.topicId + "&scoreType=3')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + objvgs_ResearchResult.appraiseCount + "</span></button >";

                    strhtml += '</li>';

                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

                    strhtml += '</ul></div>';

                    //拼接；
                    $("#right_Content").html(strhtml);
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

}