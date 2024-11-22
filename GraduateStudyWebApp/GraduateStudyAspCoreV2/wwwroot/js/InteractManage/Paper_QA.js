(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/InteractManage/clsqa_AnswerEN.js", "../TS/L0_Entity/InteractManage/clsqa_PushEN.js", "../TS/L0_Entity/InteractManage/clsqa_QuestionsEN.js", "../TS/L0_Entity/InteractManage/clsSysVoteEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/InteractManage/clsqa_AnswerWApi.js", "../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js", "../TS/L3_ForWApi/InteractManage/clsqa_QuestionsWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js", "../TS/L3_ForWApi/InteractManage/clsvqa_QuestionsWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/L3_ForWApiEx/InteractManage/clsqa_AnswerExWApi.js", "../TS/L3_ForWApiEx/InteractManage/clsvqa_QuestionsExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_QA = void 0;
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsqa_AnswerEN_js_1 = require("../TS/L0_Entity/InteractManage/clsqa_AnswerEN.js");
    const clsqa_PushEN_js_1 = require("../TS/L0_Entity/InteractManage/clsqa_PushEN.js");
    const clsqa_QuestionsEN_js_1 = require("../TS/L0_Entity/InteractManage/clsqa_QuestionsEN.js");
    const clsSysVoteEN_js_1 = require("../TS/L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js");
    const clsvCurrEduClsTeacherWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsqa_AnswerWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_AnswerWApi.js");
    const clsqa_PushWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js");
    const clsqa_QuestionsWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_QuestionsWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsvqa_AnswerWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js");
    const clsvqa_QuestionsWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsvqa_QuestionsWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsqa_AnswerExWApi_js_1 = require("../TS/L3_ForWApiEx/InteractManage/clsqa_AnswerExWApi.js");
    const clsvqa_QuestionsExWApi_js_1 = require("../TS/L3_ForWApiEx/InteractManage/clsvqa_QuestionsExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* spaqa_QuestionsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Paper_QA {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvqa_QuestionsBy: string = "questionsId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //显示当前评论的观点
                    const gvResult2 = await this.Showdiv_Questions();
                    //评论列表
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
        //绑定提问数据
        async Showdiv_Questions() {
            var strWhereCond1 = "1=1 and questionsTypeId='01' and paperId='" + $("#hidPaperId").val() + "'";
            var strWhereCond = "1=1 and questionsTypeId='01' and paperId='" + $("#hidPaperId").val() + "' order by updDate Asc";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var objqa_Questions: clsqa_QuestionsEN = null;
            var arrvqa_QuestionsObjLst0 = [];
            var arrvqa_QuestionsObjLst = [];
            var arrvqa_PdfPageNumObjLst = [];
            try {
                const responseText1 = await (0, clsvqa_QuestionsExWApi_js_1.vqa_QuestionsEx_GetPageNumObjLstAsync)(strWhereCond1).then((jsonData) => {
                    arrvqa_PdfPageNumObjLst = jsonData;
                });
                const responseText2 = await (0, clsvqa_QuestionsWApi_js_1.vqa_Questions_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvqa_QuestionsObjLst0 = jsonData;
                });
                var strhtml = "";
                strhtml += '<div class="info" id="infoPaper_QA">';
                for (var j = 0; j < arrvqa_PdfPageNumObjLst.length; j++) {
                    arrvqa_QuestionsObjLst = arrvqa_QuestionsObjLst0.filter(x => x.pdfPageNum == arrvqa_PdfPageNumObjLst[j].pdfPageNum);
                    strhtml += '<div class="title btn-2">';
                    strhtml += '<a href="#" title="当前pdf论文上的第几页一共有几个问题">第' + arrvqa_PdfPageNumObjLst[j].pdfPageNum + '页上的' + arrvqa_QuestionsObjLst.length + '个答疑</a>';
                    //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加问题" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewQuestions_Click();> <i class="layui-icon" ></i>添加问题</button></div>';
                    strhtml += '</div><ul class="artlist">';
                    var k = 0;
                    for (var i = 0; i < arrvqa_QuestionsObjLst.length; i++) {
                        k++;
                        strhtml += '<li>';
                        strhtml += '<div id="Q' + arrvqa_QuestionsObjLst[i].questionsId + '" style="text-align:left; float:left; width:65%;">';
                        strhtml += '<span class="rowtit color1">' + k + '.</span>';
                        //strhtml += '&nbsp;<span class="rowtit color3">[' + arrvqa_QuestionsObjLst[i].pdfPageNum + ']</span>';
                        strhtml += '<span class="title btn-4"><a href="#" onclick=btnShowAnswer_Click("' + arrvqa_QuestionsObjLst[i].questionsId + '",' + arrvqa_QuestionsObjLst[i].pdfPageNum + ',"' + arrvqa_QuestionsObjLst[i].pdfContent + '"); class="abstract-text">' + arrvqa_QuestionsObjLst[i].questionsContent + '</a></span>';
                        strhtml += '&nbsp;<span style="font-style:italic;" class="rowtit color2" title="第' + arrvqa_QuestionsObjLst[i].pdfPageNum + '页标记">P' + arrvqa_QuestionsObjLst[i].pdfPageNum + '</span>';
                        strhtml += '&nbsp;<span class="rowtit color3">[' + arrvqa_QuestionsObjLst[i].answerCount + ']</span>';
                        strhtml += '</div>';
                        strhtml += '<div style="text-align:right; float:right; width:34%;">';
                        if (arrvqa_QuestionsObjLst[i].updUser == strUserId) {
                            //编辑
                            strhtml += '<button title="编辑问题" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateQuestions_Click("' + arrvqa_QuestionsObjLst[i].questionsId + '")><i class="layui-icon">&#xe642;</i></button>';
                            //删除
                            strhtml += '<button title="删除问题" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelQuestions_Click("' + arrvqa_QuestionsObjLst[i].questionsId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                        }
                        //strhtml += '<span class="rowtit color5">[提问用户]：</span>' + arrvqa_QuestionsObjLst[i].userName + '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[提问时间]：</span>' + arrvqa_QuestionsObjLst[i].updDate;
                        var strUpdDate = arrvqa_QuestionsObjLst[i].updDate;
                        strUpdDate = strUpdDate.substr(2, strUpdDate.length - 11);
                        strhtml += '&nbsp;<span class="rowtit color4">' + arrvqa_QuestionsObjLst[i].userName + '/' + strUpdDate + '</span>&nbsp;&nbsp;';
                        strhtml += '</div>';
                        strhtml += '</li>';
                        //strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div>';
                        //strhtml += '<li> <div style="border-bottom: 1px solid #eee;"></div></li>';
                    }
                    strhtml += '</ul>';
                }
                strhtml += '</div>';
                //拼接；
                $("#div_qa_Questions").html(strhtml);
                console.log("完成BindGv_vqa_Questions!");
                var strQuestionsId = $('#hidQuestionsId').val();
                if (strQuestionsId != "") {
                    var objQuestions = arrvqa_QuestionsObjLst0.find(x => x.questionsId == strQuestionsId);
                    if (objQuestions != null) {
                        btnShowAnswer_Click(strQuestionsId, objQuestions.pdfPageNum, objQuestions.pdfContent);
                    }
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //显示pdf标注
        async Showdiv_PdfQuestions() {
            var strWhereCond = "1=1 and questionsTypeId='01' and paperId='" + $("#hidPaperId").val() + "' order by updDate Asc";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var objqa_Questions: clsqa_QuestionsEN = null;
            var arrqa_QuestionsObjLst0 = [];
            var arrqa_QuestionsObjLst = [];
            try {
                const responseText1 = await (0, clsqa_QuestionsWApi_js_1.qa_Questions_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrqa_QuestionsObjLst = jsonData;
                });
                //$(".QuestionsCss").remove();
                $("#iframe_qaPdf", parent.document).contents().find(".QuestionsCss").remove();
                for (var i = 0; i < arrqa_QuestionsObjLst.length; i++) {
                    var strPdfPageNum = arrqa_QuestionsObjLst[i].pdfPageNum;
                    var strQuestionsId = arrqa_QuestionsObjLst[i].questionsId;
                    var strQuestionsContent = arrqa_QuestionsObjLst[i].questionsContent;
                    //如果zoom是auto的那么就默认赋值110
                    var Currpdf_zoom = 0;
                    if (this.pdf_zoom == "auto") {
                        Currpdf_zoom = 110;
                    }
                    else {
                        Currpdf_zoom = Number(this.pdf_zoom);
                    }
                    var Datapdf_zoom = 0;
                    if (arrqa_QuestionsObjLst[i].pdfZoom == "auto") {
                        Datapdf_zoom = 110;
                    }
                    else {
                        Datapdf_zoom = Number(arrqa_QuestionsObjLst[i].pdfZoom);
                    }
                    //var Datapdf_zoom: number = Number(arrgs_TagsObjLst[i].pdfZoom);
                    var strPdfDivTop = Number(arrqa_QuestionsObjLst[i].pdfDivTop);
                    var strPdfDivLet = Number(arrqa_QuestionsObjLst[i].pdfDivLet);
                    if (Currpdf_zoom > Datapdf_zoom) {
                        var ZoomValue = Currpdf_zoom - Datapdf_zoom;
                        ZoomValue = ZoomValue - (ZoomValue / 10);
                        //获得换算后的top值
                        strPdfDivTop = strPdfDivTop + (strPdfDivTop * (ZoomValue / 100));
                        //获得换算后的top值
                        strPdfDivLet = strPdfDivLet + (strPdfDivLet * (ZoomValue / 100));
                        strPdfDivTop = strPdfDivTop - 20; //补充值，为了标记放置在文字的上面
                    }
                    else if (Currpdf_zoom < Datapdf_zoom) {
                        var ZoomValue = Datapdf_zoom - Currpdf_zoom;
                        ZoomValue = ZoomValue + (ZoomValue / 10);
                        //获得换算后的top值
                        strPdfDivTop = strPdfDivTop - (strPdfDivTop * (ZoomValue / 100));
                        //获得换算后的top值
                        strPdfDivLet = strPdfDivLet - (strPdfDivLet * (ZoomValue / 100));
                        strPdfDivTop = strPdfDivTop - 20; //补充值，为了标记放置在文字的上面
                    }
                    else {
                        strPdfDivTop = strPdfDivTop - 20; //补充值，为了标记放置在文字的上面
                    }
                    //var pdfPage = document.getElementsByClassName("page");
                    var pdfPage = window.parent.frames["iframe_qaPdf"].contentDocument.getElementsByClassName("page");
                    var j;
                    for (j = 0; j <= pdfPage.length; j++) {
                        if (strPdfPageNum != 0) {
                            if (strPdfPageNum == j) {
                                //var div = document.createElement("img");
                                //div.innerText = strTagsContent;
                                //div.style.left = strPdfDivLet + "px";
                                //div.style.top = strPdfDivTop + "px";
                                //div.style.position = "absolute";
                                //div.title = strTagsContent;
                                //div.style.zIndex = "999";
                                //div.id = strQuestionsId;
                                //div.src = "/GraduateStudyWebApp/images/QA.png";
                                //div.setAttribute("onclick", "btnUpdateTags_Click('" + strQuestionsId + "')");
                                var div = document.createElement("a");
                                //div.innerText = strTagsContent;
                                //div.href = "#Q" + strQuestionsId;
                                div.className = "QuestionsCss";
                                div.style.left = strPdfDivLet + "px";
                                div.style.top = strPdfDivTop + "px";
                                div.style.position = "absolute";
                                div.style.zIndex = "999";
                                div.title = strQuestionsContent;
                                div.id = strQuestionsId;
                                //div.className = "layui-icon layui-icon-survey";//答疑图标
                                //if (arrqa_QuestionsObjLst[i].updUser == strUserId) {
                                //    div.setAttribute("onclick", "btnUpdateQuestions_Click('" + strQuestionsId + "')");
                                //}
                                div.setAttribute("onclick", "btnIndexesQuestions_Click('" + strQuestionsId + "')");
                                //var vari = document.createElement("i");
                                //vari.className = "layui-icon layuilayui-icon-reply-fill";
                                ////vari.className = "layui-icon";
                                //vari.style.color = "#1E9FFF";
                                //vari.style.fontSize = "30px";
                                //vari.style.lineHeight = "32px";
                                //vari.innerText = "&#xe60f";
                                var vari = document.createElement("img");
                                vari.style.height = "24px";
                                vari.style.width = "24px";
                                vari.src = "/GraduateStudyWebApp/images/QA.png";
                                div.appendChild(vari);
                                pdfPage[j - 1].appendChild(div);
                            }
                        }
                    }
                }
                console.log("完成Showdiv_PdfQuestions绑定!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //public static uniq(arr: Array<clsvqa_QuestionsEN>): Array<clsvqa_QuestionsEN> {
        //    let arrObjLst_New: Array<clsvqa_QuestionsEN> = new Array<clsvqa_QuestionsEN>();
        //    for (let x of arr) {
        //        if (Pdf_QA.IsExist(arrObjLst_New, x) == false) {
        //            arrObjLst_New.push(x);
        //        }
        //    }
        //    return arrObjLst_New;
        //}
        //public static IsExist(arr: Array<clsvqa_QuestionsEN>, key: clsvqa_QuestionsEN) {
        //    let arr_Sel = arr.filter(x => x.pdfPageNum == key.pdfPageNum);
        //    if (arr_Sel.length > 0) return true;
        //    return false;
        //}
        //public static GetvPdfpageNumByvqa_Questions(objvqa_Questions: clsvqa_QuestionsEN): clsvqa_QuestionsEN {
        //    var objvqa_Questions: clsvqa_QuestionsEN = new clsvqa_QuestionsEN();
        //    objvqa_Questions.questionsId = objvqa_Questions.questionsId;
        //    objvqa_Questions.pdfPageNum = objvqa_Questions.pdfPageNum;
        //    return objvqa_Questions;
        //}
        //绑定答案数据并对pdf添加高亮
        async btnShowAnswer_Click() {
            //对pdf添加高亮
            //this.btnUpdatePaperPageNum_Click(this.hidPdfContent);
            //绑定答案数据
            var arrvqa_AnswerObjLst1 = [];
            var arrvqa_AnswerObjLst2 = [];
            var arrvqa_AnswerObjLst3 = [];
            var arrSysVoteObjLst = [];
            var strWhereCond1 = "";
            var strWhereCond2 = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strQuestionsId = this.questionsId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部评论
                strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
                strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人评论
                strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
                strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新评论
                strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
                strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
            }
            var strVateWhereCond = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='12' and pubParentId='" + strQuestionsId + "'";
            var strQWhereCond = "questionsId='" + strQuestionsId + "'";
            try {
                const responseText1 = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                    arrvqa_AnswerObjLst1 = jsonData;
                });
                const responseText2 = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvqa_AnswerObjLst2 = jsonData;
                });
                const responseText3 = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLstAsync)(strVateWhereCond).then((jsonData) => {
                    arrSysVoteObjLst = jsonData;
                });
                const objqa_Questions = await (0, clsqa_QuestionsWApi_js_1.qa_Questions_GetFirstObjAsync)(strQWhereCond);
                if (objqa_Questions != null) {
                    $('#Questions_Name').html(objqa_Questions.questionsContent);
                }
                var strhtml = "";
                var varNum = 0;
                //$('#J_ShortComment div').remove();
                for (var i = 0; i < arrvqa_AnswerObjLst1.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" >';
                    strhtml += '<div class="common-avatar J_User" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block">';
                    if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:red;" > 题主：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    }
                    else {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment-username J_User">' + varNum + '楼</span></p>';
                    //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                    //回复区
                    arrvqa_AnswerObjLst3 = arrvqa_AnswerObjLst2.filter(x => x.parentId == arrvqa_AnswerObjLst1[i].answerId);
                    if (arrvqa_AnswerObjLst3.length > 0) {
                        strhtml += '<div class="reply J_ReplyBlock">';
                        for (var j = 0; j < arrvqa_AnswerObjLst3.length; j++) {
                            strhtml += '<div class="reply-block">';
                            strhtml += '<div class="reply-content">';
                            if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst3[j].updUser) {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" style="color:red;"> 题主(' + arrvqa_AnswerObjLst3[j].userName + ')</b>：</span>';
                            }
                            else {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User">' + arrvqa_AnswerObjLst3[j].userName + '</b>：</span>';
                            }
                            strhtml += '' + arrvqa_AnswerObjLst3[j].answerContent + '</div>';
                            strhtml += '<div class="reply-operate reply-operate--hot">';
                            //if (arrvqa_AnswerObjLst3[j].scoreType == "2") {
                            //    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrvqa_AnswerObjLst3[j].score + '</i></span>';
                            //} else {
                            //    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrvqa_AnswerObjLst3[j].score + '</i></span>';
                            //}
                            var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrvqa_AnswerObjLst3[j].answerId);
                            if (objLike == null) {
                                strhtml += '<span class="J_Vote reply-operate-item reply-up" onclick=btnAddVote_Click("' + arrvqa_AnswerObjLst3[j].answerId + '","' + arrvqa_AnswerObjLst3[j].updUser + '")>赞<i>' + arrvqa_AnswerObjLst3[j].voteCount + '</i></span >';
                            }
                            else {
                                strhtml += '<span class="J_Vote reply-operate-item reply-up operate-visited" >已赞<i>' + arrvqa_AnswerObjLst3[j].voteCount + '</i></span >';
                            }
                            //strhtml += '<i class="reply-dot">·</i><span class="J_Reply reply-operate-item"  onclick=btnReplyAnswer_Click("' + arrvqa_AnswerObjLst3[j].answerId + '")>回复</span>';
                            strhtml += '<i class="reply-dot">·</i><span>' + arrvqa_AnswerObjLst3[j].updDate + '</span>';
                            if (strUserId == arrvqa_AnswerObjLst3[j].updUser) {
                                strhtml += '<i class="reply-dot reply-operate-report" >·</i>';
                                strhtml += '<span class="reply-operate-item reply-operate-report J_ReplyReport" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst3[j].answerId + '")>删除</span>';
                            }
                            strhtml += '</div>';
                            strhtml += '</div>';
                        }
                        strhtml += '</div>';
                    }
                    ///评论区
                    strhtml += '<div class="comment-operate J_CommentOperate clearfix">';
                    //if (arrvqa_AnswerObjLst1[i].scoreType == "2") {
                    //    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrvqa_AnswerObjLst1[i].score + '</i></span>';
                    //} else {
                    //    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrvqa_AnswerObjLst1[i].score + '</i></span>';
                    //}
                    var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrvqa_AnswerObjLst1[i].answerId);
                    if (objLike == null) {
                        strhtml += '<span class="J_Vote comment-operate-item comment-operate-up" onclick=btnAddVote_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].updUser + '")>赞<i>' + arrvqa_AnswerObjLst1[i].voteCount + '</i></span>';
                    }
                    else {
                        strhtml += '<span class="J_Vote comment-operate-item comment-operate-up operate-visited">已赞<i>' + arrvqa_AnswerObjLst1[i].voteCount + '</i></span>';
                    }
                    strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>回复</span>';
                    strhtml += '</div>';
                    if (strUserId == arrvqa_AnswerObjLst1[i].updUser) {
                        //strhtml += '<div class="J_Report comment-report" id="J_Report6673850347411436155" onclick=btnUpdateAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>修改</div>';
                        strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';
                    }
                    strhtml += '</div></div>';
                }
                //$("#J_ShortComment").append(strhtml);
                $("#J_ShortComment").html(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取数据不成功,${e}.`;
                alert(strMsg);
            }
        }
        //添加高亮
        btnUpdatePaperPageNum_Click(strFindText) {
            this.RemoveSelect();
            //var objLst = document.getElementsByTagName("span");
            var objLst = window.parent.frames["iframe_qaPdf"].contentDocument.getElementsByTagName("span");
            //var strStartName: string = "400%";
            let arrElement = this.GetArray(objLst);
            //let arrSpan
            let arrFind = arrElement;
            //let arrFind: Array<HTMLSpanElement> = arrSpan.filter(x => x.id.indexOf(strStartName) > -1);
            let arrWord = arrFind.map(x => x.innerText);
            let strWord = arrWord.join("");
            var intWord = strWord.indexOf("400%");
            strWord = strWord.substring(intWord);
            //let strFindText = $('#hidExplainContent').val();
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
                }
                var intLen = strFindText.length;
                var intEnd = intStart + intLen;
                let arrSpan_Sel = arrFind.slice(intStart, intEnd);
                arrSpan_Sel.forEach(x => {
                    var strWord = x.innerText;
                    //var objSpan_New: HTMLSpanElement = document.createElement("span");
                    var objSpan_New = window.parent.frames["iframe_qaPdf"].contentDocument.createElement("span");
                    objSpan_New.className = "text-span";
                    objSpan_New.innerText = strWord;
                    x.innerHTML = "";
                    x.appendChild(objSpan_New);
                });
            }
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
        //清除高亮
        RemoveSelect() {
            //var objLst = document.getElementsByTagName("span");
            var objLst = window.parent.frames["iframe_qaPdf"].contentDocument.getElementsByTagName("span");
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
        /* 添加问题
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
       */
        async btnAddNewQuestions_Click() {
            this.opType = "AddWithMaxId";
            try {
                this.btnOKUpd1 = "确认添加";
                this.btnCancel1 = "取消添加";
                this.Clear1();
                //const responseText = this.AddNewRecordWithMaxId();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改问题
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        <param name = "sender">参数列表</param>
      */
        async btnUpdateQuestions_Click(strQuestionsId) {
            this.btnOKUpd1 = "确认修改";
            this.btnCancel1 = "取消修改";
            this.questionsId = strQuestionsId;
            try {
                const responseText = await (0, clsqa_QuestionsWApi_js_1.qa_Questions_GetObjByQuestionsIdAsync)(strQuestionsId);
                var objqa_QuestionsEN = responseText;
                this.GetDataFromqa_QuestionsClass(objqa_QuestionsEN);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd1_Click() {
            var strCommandText = this.btnOKUpd1;
            try {
                switch (strCommandText) {
                    case "添加":
                        //const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        var returnBool2 = true;
                        const responseText2_1 = await this.AddNewRecordWithMaxIdSave1().then((jsonData) => {
                            returnBool2 = jsonData;
                        });
                        if (returnBool2 == true) {
                            //同步问题数量信息
                            const responseText2_2 = await this.SynQuestions();
                            $('#divEditQuestionsRegion').hide();
                            $('#div_qa_Welcome').show();
                            if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetUserLst() != "") {
                                const responseText2_3 = await this.AddNewqa_Push();
                            }
                            const responseText2_4 = await this.Showdiv_Questions();
                            const responseText2_5 = await this.Showdiv_PdfQuestions();
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        var returnBool3 = true;
                        var strInfo = "";
                        const responseText3_1 = await this.UpdateRecordSave1().then((jsonData) => {
                            returnBool3 = jsonData;
                            strInfo = returnBool3 ? "问题修改成功！" : "问题修改不成功！";
                            //strInfo += "(In qa_QuestionsCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                        });
                        if (returnBool3 == true) {
                            Alert1(strInfo);
                            $('#divEditQuestionsRegion').hide();
                            $('#div_qa_Answer').show();
                            const responseText3_2 = await this.Showdiv_Questions();
                            const responseText3_3 = await this.Showdiv_PdfQuestions();
                        }
                        else {
                            alert(strInfo);
                        }
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
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave1() {
            //
            var objqa_QuestionsEN = new clsqa_QuestionsEN_js_1.clsqa_QuestionsEN();
            objqa_QuestionsEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            this.PutDataToqa_QuestionsClass(objqa_QuestionsEN);
            try {
                //const responseText2 = await qa_Questions_AddNewRecordWithMaxIdAsync(objqa_QuestionsEN);
                const responseText2 = await (0, clsqa_QuestionsWApi_js_1.qa_Questions_AddNewRecordWithReturnKeyAsync)(objqa_QuestionsEN);
                var strQuestionsId = responseText2;
                //var returnBool: boolean = !!responseText2;
                if (strQuestionsId != "") {
                    this.questionsId = strQuestionsId;
                    var strInfo = `添加问题成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    Alert1(strInfo);
                    //alert(strInfo);
                    return true;
                }
                else {
                    var strInfo = `添加问题不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    return false;
                }
                //一定要有一个返回值，否则会出错！
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
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async UpdateRecordSave1() {
            const strThisFuncName = this.UpdateRecordSave1.name;
            //
            var objqa_QuestionsEN = new clsqa_QuestionsEN_js_1.clsqa_QuestionsEN();
            objqa_QuestionsEN.SetQuestionsId(this.questionsId);
            this.PutDataToqa_QuestionsClass(objqa_QuestionsEN);
            objqa_QuestionsEN.sf_UpdFldSetStr = objqa_QuestionsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objqa_QuestionsEN.questionsId == "" || objqa_QuestionsEN.questionsId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsqa_QuestionsWApi_js_1.qa_Questions_UpdateRecordAsync)(objqa_QuestionsEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                }
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
        ///添加问题推送
        async AddNewqa_Push() {
            try {
                var strJson = clsPubSessionStorage_js_1.clsPubSessionStorage.GetUserLst();
                var JsonLent = strJson.length;
                strJson = strJson.substr(0, JsonLent - 1);
                console.log(strJson);
                var strUses = eval('[' + strJson + ']');
                //把存入的数组拿出来循环并添加到推送表
                for (var i = 0; i < strUses.length; i++) {
                    var strUserId = strUses[i];
                    var objqa_PushEN = new clsqa_PushEN_js_1.clsqa_PushEN();
                    objqa_PushEN.SetQuestionsId(this.questionsId);
                    objqa_PushEN.SetReceiveUser(strUserId);
                    objqa_PushEN.SetIsReceive(false);
                    objqa_PushEN.SetIsRequestReply(this.isRequestReply); // 是否要求回复
                    objqa_PushEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate());
                    objqa_PushEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls); //教学班Id
                    const responseText = await (0, clsqa_PushWApi_js_1.qa_Push_AddNewRecordAsync)(objqa_PushEN);
                    console.log(responseText);
                }
                //添加完以后清空用户数组字符串
                var strKey = "UserLst";
                sessionStorage.removeItem(strKey);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `推送记录添加不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjqa_QuestionsEN">数据传输的目的类对象</param>
      */
        PutDataToqa_QuestionsClass(pobjqa_QuestionsEN) {
            pobjqa_QuestionsEN.SetPaperId($("#hidPaperId").val());
            pobjqa_QuestionsEN.Setqa_PaperId("00000000");
            pobjqa_QuestionsEN.SetQuestionsTypeId("01");
            pobjqa_QuestionsEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjqa_QuestionsEN.SetQuestionsContent(this.questionsContent); // 提问内容
            pobjqa_QuestionsEN.SetPdfContent(this.pdfContent); // Pdf内容
            pobjqa_QuestionsEN.SetPdfPageNum(this.pdfPageNum); // Pdf页码
            pobjqa_QuestionsEN.SetOrderNum(this.orderNum); // 序号
            pobjqa_QuestionsEN.SetPdfPageNumIn(this.page_cache);
            pobjqa_QuestionsEN.SetPdfPageTop(this.page_top);
            pobjqa_QuestionsEN.SetPdfZoom(this.pdf_zoom);
            var pdfDiv_top = this.pdfDiv_top;
            pdfDiv_top = pdfDiv_top.substr(0, pdfDiv_top.length - 2);
            var pdfDiv_left = this.pdfDiv_left;
            pdfDiv_left = pdfDiv_left.substr(0, pdfDiv_left.length - 2);
            pobjqa_QuestionsEN.SetPdfDivTop(pdfDiv_top);
            pobjqa_QuestionsEN.SetPdfDivLet(pdfDiv_left);
            pobjqa_QuestionsEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjqa_QuestionsEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
        }
        /* 函数功能:把类对象的属性内容显示到界面上
       注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        如果在设置数据库时,就应该一级字段在前,二级字段在后
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        <param name = "pobjqa_QuestionsEN">表实体类对象</param>
      */
        GetDataFromqa_QuestionsClass(pobjqa_QuestionsEN) {
            this.questionsContent = pobjqa_QuestionsEN.questionsContent; // 提问内容
            this.pdfContent = pobjqa_QuestionsEN.pdfContent; // Pdf内容
            this.pdfPageNum = pobjqa_QuestionsEN.pdfPageNum; // Pdf页码
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear1() {
            this.questionsContent = "";
            this.pdfContent = "";
            this.pdfPageNum = 0;
            this.orderNum = 0;
        }
        /*
        在数据表里删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
       */
        async btnDelQuestions_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                //删除问题的时候需要查看一下是否有答案，如果有不能删除
                var strWhereCond = " questionsId=" + strKeyId;
                var intAnswerCount = await (0, clsqa_AnswerWApi_js_1.qa_Answer_GetRecCountByCondAsync)(strWhereCond);
                if (intAnswerCount > 0) {
                    //alert("该问题下面已经有回答了，所以不能删除哦！");
                    Alert2("该问题下面已经有回答了，所以不能删除哦！");
                    return "";
                }
                else {
                    const responseText = await this.DelRecord1(strKeyId);
                    const responseBindGv = await this.Showdiv_Questions();
                    const responseBindPdf = await this.Showdiv_PdfQuestions();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        删除问题
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord1(strQuestionsId) {
            try {
                const responseText = await (0, clsqa_QuestionsWApi_js_1.qa_Questions_DelRecordAsync)(strQuestionsId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    const responseText3 = await this.SynQuestions();
                    var strInfo = `删除记录成功!`;
                    //显示信息框
                    //alert(strInfo);
                    Alert1(strInfo);
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
        //添加删除问题的时候统计问题数据量到论文答疑表
        async SynQuestions() {
            const strThisFuncName = this.SynQuestions.name;
            var strPaperId = $("#hidPaperId").val();
            //添加记录的同时并记录论文读写的教师评价数
            var strWhereCond = " questionsTypeId='01' and paperId=" + strPaperId;
            var intQuestionsCount = await (0, clsvqa_QuestionsWApi_js_1.vqa_Questions_GetRecCountByCondAsync)(strWhereCond);
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(strPaperId);
            objPaperEN.SetPaperQCount(intQuestionsCount);
            objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            const responseText = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
            var returnBool = !!responseText;
            if (returnBool == true) {
                //刷新缓存
                console.log("添加问题数量成功！");
            }
            else {
                console.log("添加问题数量失败！");
            }
            //添加记录的同时并记录论文读写的教师评价数
        }
        /*************************************************回答相关的模块********************************************************/
        /* 添加答案
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
       */
        async btnAddNewAnswer_Click() {
            this.opType = "AddWithMaxId";
            try {
                this.btnOKUpd2 = "确认添加";
                this.btnCancel2 = "取消添加";
                this.answerContent = "";
                //const responseText = this.AddNewRecordWithMaxId();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改答案
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async btnUpdateAnswer_Click(strAnswerId) {
            this.btnOKUpd2 = "确认修改";
            this.btnCancel2 = "取消修改";
            this.answerId = strAnswerId;
            try {
                const responseText = await (0, clsqa_AnswerWApi_js_1.qa_Answer_GetObjByAnswerIdAsync)(strAnswerId);
                var objqa_AnswerEN = responseText;
                this.answerContent = objqa_AnswerEN.answerContent;
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd2_Click() {
            var strCommandText = this.btnOKUpd2;
            try {
                switch (strCommandText) {
                    case "添加":
                        //const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        var returnBool2 = true;
                        const responseText2 = await this.AddNewRecordWithMaxIdSave2().then((jsonData) => {
                            returnBool2 = jsonData;
                        });
                        if (returnBool2 == true) {
                            $('#div_qa_Answer').show();
                            $('#divEditAnswerRegion').hide();
                            this.btnShowAnswer_Click();
                            if ($('#hidPushId').val() != "") {
                                const responseText2_1 = await this.btnUpdQA_Push_Click($('#hidPushId').val());
                            }
                        }
                        //更新总表3个参数 主键、子表类型、页面操作类型；
                        //$("#hidAnswerId").val(strAnswerId);
                        var strAnswerId = $('#hidAnswerId').val();
                        const responseText6 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strAnswerId, "11", "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                        var returnBool6 = !!responseText6;
                        if (returnBool6 == true) {
                            console.log("论文子观点数据总表同步成功；");
                        }
                        else {
                            console.log("论文子观点数据总表同步失败；");
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave2().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            //strInfo += "(In qa_AnswerCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            if (returnBool == true) {
                                Alert1(strInfo);
                                $('#div_qa_Answer').show();
                                $('#divEditAnswerRegion').hide();
                                this.btnShowAnswer_Click();
                            }
                            else {
                                alert(strInfo);
                            }
                        });
                        var strAnswerId = $('#hidAnswerId').val();
                        const responseText7 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strAnswerId, "11", "2", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                        var returnBool6 = !!responseText7;
                        if (returnBool6 == true) {
                            console.log("论文子观点数据总表同步成功；");
                        }
                        else {
                            console.log("论文子观点数据总表同步失败；");
                        }
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
        /* 如果是被邀请回答的问题，回答完以后会更新推送表内的信息
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async btnUpdQA_Push_Click(pushId) {
            const strThisFuncName = this.btnUpdQA_Push_Click.name;
            var objqa_PushEN = new clsqa_PushEN_js_1.clsqa_PushEN();
            objqa_PushEN.SetPushId(pushId);
            objqa_PushEN.SetIsReceive(true);
            objqa_PushEN.SetIsReply(true);
            objqa_PushEN.SetReplyDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate());
            objqa_PushEN.SetReceiveDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate());
            objqa_PushEN.sf_UpdFldSetStr = objqa_PushEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objqa_PushEN.pushId == 0 || objqa_PushEN.pushId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsqa_PushWApi_js_1.qa_Push_UpdateRecordAsync)(objqa_PushEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    Alert1("当前邀请已经回复！");
                }
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
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave2() {
            //
            var objqa_AnswerEN = new clsqa_AnswerEN_js_1.clsqa_AnswerEN();
            objqa_AnswerEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            this.PutDataToqa_AnswerClass(objqa_AnswerEN);
            try {
                //const responseText2 = await qa_Answer_AddNewRecordWithMaxIdAsync(objqa_AnswerEN);
                const responseText2 = await (0, clsqa_AnswerWApi_js_1.qa_Answer_AddNewRecordWithReturnKeyAsync)(objqa_AnswerEN);
                //var returnBool: boolean = !!responseText2;
                var strAnswerId = responseText2;
                $("#hidAnswerId").val(strAnswerId);
                //var returnBool: boolean = !!responseText2;
                if (strAnswerId != "") {
                    //if (returnBool == true) {
                    const responseText2 = await this.SynAnswer();
                    var strInfo = `添加回答成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    Alert1(strInfo);
                    //alert(strInfo);
                    return true;
                }
                else {
                    var strInfo = `添加回答不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    return false;
                }
                //return responseText2;//一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加回答不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 修改记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async UpdateRecordSave2() {
            const strThisFuncName = this.UpdateRecordSave2.name;
            //
            var objqa_AnswerEN = new clsqa_AnswerEN_js_1.clsqa_AnswerEN();
            objqa_AnswerEN.SetAnswerId(this.answerId);
            $("#hidAnswerId").val(this.answerId);
            this.PutDataToqa_AnswerClass(objqa_AnswerEN);
            objqa_AnswerEN.sf_UpdFldSetStr = objqa_AnswerEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objqa_AnswerEN.answerId == "" || objqa_AnswerEN.answerId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsqa_AnswerWApi_js_1.qa_Answer_UpdateRecordAsync)(objqa_AnswerEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                }
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
        /* 删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
       */
        async btnDelAnswer_Click(strAnswerId) {
            try {
                const responseText = await this.DelRecord2(strAnswerId);
                const responseBindGv = await this.btnShowAnswer_Click();
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
        async DelRecord2(strAnswerId) {
            try {
                //const responseText = await qa_Answer_DelRecordAsync(strAnswerId);
                const responseText = await (0, clsqa_AnswerExWApi_js_1.qa_AnswerEx_DelRecordAsyncEx)(strAnswerId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    const responseText2 = await this.SynAnswer();
                    var strInfo = `删除记录成功!`;
                    //显示信息框
                    Alert1(strInfo);
                    //alert(strInfo);
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
        PutDataToqa_AnswerClass(pobjqa_AnswerEN) {
            pobjqa_AnswerEN.SetQuestionsId(this.questionsId); //问题ID
            //pobjqa_AnswerEN.SetParentId("root";//父节点
            pobjqa_AnswerEN.SetParentId($("#hidParentId").val()); //父节点
            pobjqa_AnswerEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjqa_AnswerEN.SetAnswerContent(this.answerContent); // 答案内容
            pobjqa_AnswerEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjqa_AnswerEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
        }
        //添加删除答案的时候统计问题数据量到问题表和论文答疑表
        async SynAnswer() {
            const strThisFuncName = this.SynAnswer.name;
            //var strqa_PaperId = $("#hidqa_PaperId").val();
            //添加记录的同时并记录论文读写的教师评价数
            //var strWhereCond = " qa_PaperId=" + strqa_PaperId;
            //var intAnswerCount1 = await vqa_Answer_GetRecCountByCondAsync(strWhereCond);
            //var objqa_PaperEN: clsqa_PaperEN = new clsqa_PaperEN();
            //objqa_PaperEN.Setqa_PaperId(strqa_PaperId;
            //objqa_PaperEN.SetAnswerCount(intAnswerCount1;
            //objqa_PaperEN.sf_UpdFldSetStr = objqa_PaperEN.updFldString;//设置哪些字段被修改(脏字段)
            //if (objqa_PaperEN.qa_PaperId == "" || objqa_PaperEN.qa_PaperId == undefined) {
            //     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            //}
            //const responseText1 = await qa_Paper_UpdateRecordAsync(objqa_PaperEN);
            //var returnBool1: boolean = !!responseText1;
            //if (returnBool1 == true) {
            //    //刷新缓存
            //    console.log("添加答案数量到答疑表成功！");
            //}
            //else {
            //    console.log("添加答案数量到答疑表失败！");
            //}
            //添加记录的同时并记录论文读写的教师评价数
            var strWhereCond = " questionsId=" + this.questionsId;
            var intAnswerCount2 = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetRecCountByCondAsync)(strWhereCond);
            var objqa_QuestionsEN = new clsqa_QuestionsEN_js_1.clsqa_QuestionsEN();
            objqa_QuestionsEN.SetQuestionsId(this.questionsId);
            objqa_QuestionsEN.SetAnswerCount(intAnswerCount2);
            objqa_QuestionsEN.sf_UpdFldSetStr = objqa_QuestionsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objqa_QuestionsEN.questionsId == "" || objqa_QuestionsEN.questionsId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            const responseText2 = await (0, clsqa_QuestionsWApi_js_1.qa_Questions_UpdateRecordAsync)(objqa_QuestionsEN);
            var returnBool2 = !!responseText2;
            if (returnBool2 == true) {
                //刷新缓存
                console.log("添加答案数量到答疑表成功！");
            }
            else {
                console.log("添加答案数量到答疑表失败！");
            }
            //添加记录的同时并记录论文读写的教师评价数
        }
        /////////////////////////////////////////////////////////点赞——邀请其他人/////////////////////////////////////////////////////
        /**
         * 添加点赞
         * @param strAnswerId
         * @param strUserId
         */
        async btnAddVote_Click(strAnswerId, strUserId) {
            const strThisFuncName = this.btnAddVote_Click.name;
            //this.DivName = "divAddNewRecordSave";
            var objSysVoteEN = new clsSysVoteEN_js_1.clsSysVoteEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objSysVoteEN.SetTableKey(strAnswerId);
            objSysVoteEN.SetVoteTypeId("12");
            objSysVoteEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objSysVoteEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            objSysVoteEN.SetLikedUserId(strUserId); //被点赞用户
            objSysVoteEN.SetPubParentId(this.questionsId);
            objSysVoteEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls); //教学班Id
            //var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage.userId + "' and tableKey=" + strAnswerId;
            try {
                //const responseText = await SysVote_IsExistRecordAsync(strWhereCond);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsSysVoteWApi_js_1.SysVote_AddNewRecordAsync)(objSysVoteEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1=1 and voteTypeId='12' and tableKey=" + strAnswerId;
                    var intVoteCount = await (0, clsSysVoteWApi_js_1.SysVote_GetRecCountByCondAsync)(strWhereCond2);
                    var objqa_AnswerEN = new clsqa_AnswerEN_js_1.clsqa_AnswerEN();
                    objqa_AnswerEN.SetAnswerId(strAnswerId);
                    objqa_AnswerEN.SetVoteCount(intVoteCount);
                    objqa_AnswerEN.sf_UpdFldSetStr = objqa_AnswerEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objqa_AnswerEN.answerId == "" || objqa_AnswerEN.answerId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsqa_AnswerWApi_js_1.qa_Answer_UpdateRecordAsync)(objqa_AnswerEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //const gvResult = await this.btnShowAnswer_Click();
                            var strInfo = `已点赞!`;
                            Alert1(strInfo);
                            console.log("已点赞");
                            this.btnShowAnswer_Click();
                        }
                        else {
                            var strInfo = `点赞不成功!`;
                            //alert(strInfo);
                            Alert1(strInfo);
                            console.log("点赞不成功");
                        }
                    });
                }
                else {
                    var strInfo = `点赞不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    //alert(strInfo);
                    Alert1(strInfo);
                    //this.DetailRecord();
                    //this.BindGv_vPaperSubViewpoint();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `点赞不成功,${e}.`;
                //alert(strMsg);
                Alert1(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //邀请其他人
        async InviteOthers_Click() {
            var strWhereCond = "1=1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var objqa_Questions: clsqa_QuestionsEN = null;
            var arrvCurrEduClsStuObjLst = [];
            var arrvCurrEduClsTeacherObjLst = [];
            try {
                const responseText1 = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsStuObjLst = jsonData;
                });
                const responseText2 = await (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsTeacherObjLst = jsonData;
                });
                var strhtml1 = "";
                strhtml1 += '<ul>';
                var j = 0;
                for (var i = 0; i < arrvCurrEduClsStuObjLst.length; i++) {
                    j++;
                    strhtml1 += '<li class="btn-2">&nbsp;&nbsp;&nbsp;<span class="rowtit color3">' + j + '.</span>';
                    strhtml1 += '<a href="#" onclick=btnAtUserName_Click("' + arrvCurrEduClsStuObjLst[i].stuID + '","' + arrvCurrEduClsStuObjLst[i].stuName + '")>[' + arrvCurrEduClsStuObjLst[i].stuName + ']</a>';
                    strhtml1 += '</li>';
                }
                strhtml1 += '</ul>';
                var strhtml2 = "";
                strhtml2 += '<ul class="artlist">';
                var k = 0;
                for (var i = 0; i < arrvCurrEduClsTeacherObjLst.length; i++) {
                    k++;
                    strhtml2 += '<li class="btn-2">&nbsp;&nbsp;&nbsp;<span class="rowtit color3">' + k + '.</span>';
                    strhtml2 += '<a href="#" onclick=btnAtUserName_Click("' + arrvCurrEduClsTeacherObjLst[i].teacherID + '","' + arrvCurrEduClsTeacherObjLst[i].teacherName + '")>[' + arrvCurrEduClsTeacherObjLst[i].teacherName + ']</a>';
                    strhtml2 += '</li>';
                }
                strhtml2 += '</ul>';
                //var strhtml3 = "内容1";
                //var strhtml4 = "内容2";
                atOthers(strhtml1, strhtml2);
                //atOthers(strhtml3, strhtml4);
                //拼接；
                console.log("完成教学班教师和学生的信息绑定!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取教学班学生和教师的数据不成功,${e}.`;
                alert(strMsg);
            }
        }
        //at其他人
        async btnAtUserName_Click(strKey, strName) {
            var key = $('#hidInviteKey').val();
            if (key == 1) {
                var varContentLen = this.questionsContent.length;
                var area1 = this.questionsContent.substr(0, varContentLen);
                //@内容后附加空格标识
                var area2 = '@' + strName + ' ';
                //var area3 = objString.substr(cursorPosition, getLength(objString) - cursorPosition);
                //更新textarea的value值
                this.questionsContent = this.questionsContent + area2;
            }
            else {
                var varContentLen = this.answerContent.length;
                var area1 = this.answerContent.substr(0, varContentLen);
                //@内容后附加空格标识
                var area2 = '@' + strName + ' ';
                //var area3 = objString.substr(cursorPosition, getLength(objString) - cursorPosition);
                //更新textarea的value值
                this.answerContent = this.answerContent + area2;
            }
            //var objUsers: stuUserLoginInfo = new stuUserLoginInfo();
            //objUsers.userId = strKey;
            //objUsers.userName = strName;
            //var strJson = JSON.stringify(objUsers);
            if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetUserLst() != "") {
                var strJson = clsPubSessionStorage_js_1.clsPubSessionStorage.GetUserLst() + "'" + strKey + "',";
                clsPubSessionStorage_js_1.clsPubSessionStorage.SetUserLst(strJson);
            }
            else {
                var strJson = "'" + strKey + "',";
                clsPubSessionStorage_js_1.clsPubSessionStorage.SetUserLst(strJson);
            }
            LayercClose();
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        //public TagsClear() {
        //    this.tagsContent = "";
        //}
        /*
        * 设置取消按钮的标题
       */
        set btnCancel1(value) {
            $("#btnCancel1").html(value);
        }
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd1(value) {
            $("#btnOKUpd1").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd1() {
            return $("#btnOKUpd1").html();
        }
        /*
        * 设置取消按钮的标题
       */
        set btnCancel2(value) {
            $("#btnCancel2").html(value);
        }
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd2(value) {
            $("#btnOKUpd2").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd2() {
            return $("#btnOKUpd2").html();
        }
        // /*
        // * 设置确定按钮的标题
        //*/
        // public set btnOKUpd3(value: string) {
        //     $("#btnOKUpd3").html(value);
        // }
        // /*
        // * 获取按钮的标题
        //*/
        // public get btnOKUpd3(): string {
        //     return $("#btnOKUpd3").html();
        // }
        /*
        * 序号
       */
        set orderNum(value) {
            $("#txtOrderNum").val(value);
        }
        /*
        * 序号
       */
        get orderNum() {
            return $("#txtOrderNum").val();
        }
        //  /*
        // * Pdf内容
        //*/
        //  public set pdfContent(value: string) {
        //      $("#hidPdfContent").val(value);
        //  }
        //  /*
        //  * Pdf内容
        // */
        //  public get pdfContent(): string {
        //      return $("#hidPdfContent").val();
        //  }
        //  /*
        //  * Pdf页码
        // */
        //  public set pdfPageNum(value: number) {
        //      $("#hidPdfPageNum").val(value);
        //  }
        //  /*
        //  * Pdf页码
        // */
        //  public get pdfPageNum(): number {
        //      return $("#hidPdfPageNum").val();
        //  }
        /*
        * 提问内容
       */
        set questionsContent(value) {
            $("#txtQuestionsContent").val(value);
        }
        /*
        * 提问内容
       */
        get questionsContent() {
            return $("#txtQuestionsContent").val();
        }
        /*
       * 答案内容
      */
        set answerContent(value) {
            $("#txtAnswerContent").val(value);
        }
        /*
        * 答案内容
       */
        get answerContent() {
            return $("#txtAnswerContent").val();
        }
        /*
    * 设置操作类型：Add||Update||Detail
    */
        set opType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        get opType() {
            return $("#hidOpType").val();
        }
        /*
        * 设置关键字的值
       */
        set questionsId(value) {
            $("#hidQuestionsId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get questionsId() {
            return $("#hidQuestionsId").val();
        }
        // /*
        // * 设置关键字的值
        //*/hidPdfContent
        // public set tagsId(value: string) {
        //     $("#hidTagsId").val(value);
        // }
        // /*
        // * 设置关键字的值
        //*/
        // public get tagsId(): string {
        //     return $("#hidTagsId").val();
        // }
        /*
        * 设置关键字的值
       */
        set hidPdfContent(value) {
            $("#hidPdfContent").val(value);
        }
        /*
        * 设置关键字的值
       */
        get hidPdfContent() {
            return $("#hidPdfContent").val();
        }
        /*
        * 设置关键字的值
       */
        set answerId(value) {
            $("#hidAnswerId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get answerId() {
            return $("#hidAnswerId").val();
        }
        /*
    * 是否要求回复
    */
        set isRequestReply(value) {
            $("#chkIsRequestReply").attr("checked", value);
        }
        /*
        * 是否要求回复
       */
        get isRequestReply() {
            return $("#chkIsRequestReply").prop("checked");
        }
        // /*
        // * pdf标注内容
        //*/
        // public set tagsContent(value: string) {
        //     $("#txtTagsContent").val(value);
        // }
        // /*
        // * pdf标注内容
        //*/
        // public get tagsContent(): string {
        //     return $("#txtTagsContent").val();
        // }
        /******************************************************************iFrame子页面控件******************************************************/
        /*
       * Pdf内容
      */
        set pdfContent(value) {
            //$("#hidPdfContent").val(value);
            //$("#iframe_qaPdf").contents().find("#hidPdfContent").val(value);
            //$(window.parent.$("#iframe_qaPdf")).contents().find("#hidPdfContent").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#hidPdfContent").val(value);
        }
        /*
        * Pdf内容
       */
        get pdfContent() {
            //return $("#hidPdfContent").val();
            //return $("#iframe_qaPdf").contents().find("#hidPdfContent").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#hidPdfContent").val();
        }
        /*
        * Pdf页码
       */
        set pdfPageNum(value) {
            //$("#hidPdfPageNum").val(value);
            //$("#iframe_qaPdf").contents().find("#hidPdfPageNum").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#hidPdfPageNum").val(value);
        }
        /*
        * Pdf页码
       */
        get pdfPageNum() {
            //return $("#hidPdfPageNum").val();
            //return $("#iframe_qaPdf").contents().find("#hidPdfPageNum").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#hidPdfPageNum").val();
        }
        /*
     * PdfTop
    */
        set page_top(value) {
            //$("#hidPdfPageNum").val(value);
            //$("#iframe_qaPdf").contents().find("#page_top").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#page_top").val(value);
        }
        /*
        * PdfTop
       */
        get page_top() {
            //return $("#hidPdfPageNum").val();
            //return $("#iframe_qaPdf").contents().find("#page_top").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#page_top").val();
        }
        /*
     * page_cache
    */
        set page_cache(value) {
            //$("#hidPdfPageNum").val(value);
            //$("#iframe_qaPdf").contents().find("#page_cache").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#page_cache").val(value);
        }
        /*
        * page_cache
       */
        get page_cache() {
            //return $("#hidPdfPageNum").val();
            //return $("#iframe_qaPdf").contents().find("#page_cache").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#page_cache").val();
        }
        /*
    * pdf_zoom
    */
        set pdf_zoom(value) {
            //$("#hidPdfPageNum").val(value);
            //$("#iframe_qaPdf").contents().find("#pdf_zoom").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#pdf_zoom").val(value);
        }
        /*
        * pdf_zoom
       */
        get pdf_zoom() {
            //return $("#hidPdfPageNum").val();
            //return $("#iframe_qaPdf").contents().find("#pdf_zoom").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#pdf_zoom").val();
        }
        //    /*
        //* pdfDiv_top
        //*/
        //    public set pdfDiv_top(value: string) {
        //        //$("#hidPdfPageNum").val(value);
        //        //$("#iframe_qaPdf").contents().find("#pdfDiv_top").val(value);
        //        $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val(value);
        //    }
        //    /*
        //    * pdfDiv_top
        //   */
        //    public get pdfDiv_top(): string {
        //        //return $("#hidPdfPageNum").val();
        //        //return $("#iframe_qaPdf").contents().find("#pdfDiv_top").val();
        //        return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val();
        //    }
        //    /*
        //* pdfDiv_left
        //*/
        //    public set pdfDiv_left(value: string) {
        //        //$("#hidPdfPageNum").val(value);
        //        //$("#iframe_qaPdf").contents().find("#pdfDiv_left").val(value);
        //        $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val(value);
        //    }
        //    /*
        //    * pdfDiv_left
        //   */
        //    public get pdfDiv_left(): string {
        //        //return $("#hidPdfPageNum").val();
        //        //return $("#iframe_qaPdf").contents().find("#pdfDiv_left").val();
        //        return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val();
        //    }
        /*
    * pdfDiv_top
    */
        set pdfDiv_top(value) {
            $("#pdfDiv_top").val(value);
            //$("#iframe_qaPdf").contents().find("#pdfDiv_top").val(value);
            //$("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val(value);
        }
        /*
        * pdfDiv_top
       */
        get pdfDiv_top() {
            return $("#pdfDiv_top").val();
            //return $("#iframe_qaPdf").contents().find("#pdfDiv_top").val();
            //return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val();
        }
        /*
    * pdfDiv_left
    */
        set pdfDiv_left(value) {
            $("#pdfDiv_left").val(value);
            //$("#iframe_qaPdf").contents().find("#pdfDiv_left").val(value);
            //$("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val(value);
        }
        /*
        * pdfDiv_left
       */
        get pdfDiv_left() {
            return $("#pdfDiv_left").val();
            //return $("#iframe_qaPdf").contents().find("#pdfDiv_left").val();
            //return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val();
        }
    }
    exports.Paper_QA = Paper_QA;
});
