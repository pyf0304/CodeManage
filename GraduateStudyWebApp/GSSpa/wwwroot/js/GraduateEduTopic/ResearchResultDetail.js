(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchResultWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchResultDetail = void 0;
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsgs_ResearchResultAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultAttachmentWApi.js");
    const clsvgs_ResearchResultWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchResultWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsSysPara4WebApi2_js_1 = require("../TS/PubFun/clsSysPara4WebApi2.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class ResearchResultDetail {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortUsersBy: string = "userId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
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
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async Menu_ResultType() {
            var strResultTypeId = $("#hidResultTypeId").val();
            switch (strResultTypeId) {
                case "01": //选择论文
                    const gvResult1 = await this.Bind_PaperPdf();
                    break;
                case "02": //pdf
                    const gvResult2 = await this.Bind_Pdf();
                    break;
                case "03": //图片
                    const gvResult3 = await this.Bind_Img();
                    break;
                case "04": //压缩文件
                    const gvResult4 = await this.Bind_Rar();
                    break;
            }
        }
        //绑定pdf_Ifame
        async Bind_PaperPdf() {
            try {
                //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
                var strPaperId = $("#hidPaperId").val();
                var objPaperAttachment;
                var strWhereCond = " 1=1 and paperId ='" + strPaperId + "'";
                const responseText = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetFirstObjAsync)(strWhereCond);
                objPaperAttachment = responseText;
                var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
                var strhtml = "";
                if (objPaperAttachment != null) {
                    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                    strhtml = "<iframe id='iframe_Pdf' scrolling='auto' src='../GraduateEduEx/Pdf?zoom=1.1&file=" + strfilepath + "' style=\"height:100%;width:100%; height:730px;\"></iframe>";
                }
                else {
                    strhtml = "<iframe id='iframe_Pdf' scrolling='auto' src='../GraduateEduEx/Pdf?zoom=1.1' style=\"height:100%;width:100%; height:730px;\"></iframe>";
                }
                $("#leftPart").html(strhtml);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定pdf_Ifame
        async Bind_Pdf() {
            try {
                //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
                var strResultId = $("#hidResultId").val();
                var objgs_ResearchResultAttachment;
                var strWhereCond = " 1=1 and resultId ='" + strResultId + "'";
                const responseText = await (0, clsgs_ResearchResultAttachmentWApi_js_1.gs_ResearchResultAttachment_GetFirstObjAsync)(strWhereCond);
                objgs_ResearchResultAttachment = responseText;
                var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
                var strhtml = "";
                if (objgs_ResearchResultAttachment != null) {
                    var strfilepath = strAddressAndPort + objgs_ResearchResultAttachment.filePath;
                    strhtml = "<iframe id='iframe_Pdf' scrolling='auto' src='../GraduateEduEx/Pdf?zoom=1.1&file=" + strfilepath + "' style=\"height:100%;width:100%; height:730px;\"></iframe>";
                }
                else {
                    strhtml = "<iframe id='iframe_Pdf' scrolling='auto' src='../GraduateEduEx/Pdf?zoom=1.1' style=\"height:100%;width:100%; height:730px;\"></iframe>";
                }
                $("#leftPart").html(strhtml);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定pdf_Ifame
        async Bind_Img() {
            try {
                //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
                var strResultId = $("#hidResultId").val();
                //获取图片
                var arrgs_ResearchResultAttachmentObjLst = [];
                var strWhereCond = " 1=1 and resultId ='" + strResultId + "'";
                const responseObjLst = await (0, clsgs_ResearchResultAttachmentWApi_js_1.gs_ResearchResultAttachment_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_ResearchResultAttachmentObjLst = jsonData;
                });
                var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
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
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定pdf_Ifame
        async Bind_Rar() {
            try {
                //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
                var strResultId = $("#hidResultId").val();
                var objgs_ResearchResultAttachment;
                var strWhereCond = " 1=1 and resultId ='" + strResultId + "'";
                const responseText = await (0, clsgs_ResearchResultAttachmentWApi_js_1.gs_ResearchResultAttachment_GetFirstObjAsync)(strWhereCond);
                objgs_ResearchResultAttachment = responseText;
                var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
                var strhtml = "";
                if (objgs_ResearchResultAttachment.filePath != "") {
                    var strfilepath = strAddressAndPort + objgs_ResearchResultAttachment.filePath;
                    var strfilename = objgs_ResearchResultAttachment.updDate + "研究的附件";
                    strhtml += '<button title="下载附件" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownLoadFile_Click("' + strfilepath + '","' + strfilename + '")><i class="layui-icon">&#xe601;</i>下载附件</button>';
                }
                $("#leftPart").html(strhtml);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        //绑定论文主题汇报
        async Bind_ResearchResult() {
            var strWhereCond = "1=1 and resultId='" + $("#hidResultId").val() + "'";
            var strWhereCond2 = "1=1";
            var objvgs_ResearchResult;
            try {
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
                const responseObjLst = await (0, clsvgs_ResearchResultWApi_js_1.vgs_ResearchResult_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvgs_ResearchResult = jsonData;
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
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.ResearchResultDetail = ResearchResultDetail;
});
