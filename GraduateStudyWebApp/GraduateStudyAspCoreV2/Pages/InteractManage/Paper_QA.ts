import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsvCurrEduClsStuEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js";
import { clsvCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsTeacherEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsqa_AnswerEN } from "../TS/L0_Entity/InteractManage/clsqa_AnswerEN.js";
import { clsqa_PushEN } from "../TS/L0_Entity/InteractManage/clsqa_PushEN.js";
import { clsqa_QuestionsEN } from "../TS/L0_Entity/InteractManage/clsqa_QuestionsEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsvqa_AnswerEN } from "../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js";
import { clsvqa_QuestionsEN } from "../TS/L0_Entity/InteractManage/clsvqa_QuestionsEN.js";
import { vCurrEduClsStu_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js";
import { vCurrEduClsTeacher_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js";
import { Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { qa_Answer_AddNewRecordWithReturnKeyAsync, qa_Answer_GetObjByAnswerIdAsync, qa_Answer_GetRecCountByCondAsync, qa_Answer_UpdateRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_AnswerWApi.js";
import { qa_Push_AddNewRecordAsync, qa_Push_UpdateRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js";
import { qa_Questions_AddNewRecordWithReturnKeyAsync, qa_Questions_DelRecordAsync, qa_Questions_GetFirstObjAsync, qa_Questions_GetObjByQuestionsIdAsync, qa_Questions_GetObjLstAsync, qa_Questions_UpdateRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_QuestionsWApi.js";
import { SysVote_AddNewRecordAsync, SysVote_GetObjLstAsync, SysVote_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { vqa_Answer_GetObjLstAsync, vqa_Answer_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js";
import { vqa_Questions_GetObjLstAsync, vqa_Questions_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsvqa_QuestionsWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { qa_AnswerEx_DelRecordAsyncEx } from "../TS/L3_ForWApiEx/InteractManage/clsqa_AnswerExWApi.js";
import { vqa_QuestionsEx_GetPageNumObjLstAsync } from "../TS/L3_ForWApiEx/InteractManage/clsvqa_QuestionsExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
declare var strCurrPrjId;
declare function Alert1(strMsg): void;
declare function Alert2(strMsg): void;
declare function Alert3(strMsg): void;
declare function Alert4(strMsg): void;

declare function btnShowAnswer_Click(strKey, pageNum, pdfContent): void;

declare function SetDivLertTop(str1, str2, str3, str4, str5): void;


declare function atOthers(strStuName, strTeaName): void;
declare function LayercClose(): void;
declare function InviteOthers_Click(key): void;

declare function HideDialog(): void;

declare var $;
declare var window;
/* spaqa_QuestionsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Paper_QA {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvqa_QuestionsBy: string = "questionsId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPublocalStorage.userId != "") {

                //显示当前评论的观点

                const gvResult2 = await this.Showdiv_Questions()

                //评论列表
                //const gvResult2 = await this.btnShowAppraise_Click();
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



    //绑定提问数据
    public async Showdiv_Questions() {

        var strWhereCond1 = "1=1 and questionsTypeId='01' and paperId='" + $("#hidPaperId").val() + "'";
        var strWhereCond = "1=1 and questionsTypeId='01' and paperId='" + $("#hidPaperId").val() + "' order by updDate Asc";
        var strUserId = clsPublocalStorage.userId
        //var objqa_Questions: clsqa_QuestionsEN = null;
        var arrvqa_QuestionsObjLst0: Array<clsvqa_QuestionsEN> = [];
        var arrvqa_QuestionsObjLst: Array<clsvqa_QuestionsEN> = [];
        var arrvqa_PdfPageNumObjLst: Array<clsvqa_QuestionsEN> = [];
        try {

            const responseText1 = await vqa_QuestionsEx_GetPageNumObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvqa_PdfPageNumObjLst = <Array<clsvqa_QuestionsEN>>jsonData;
            });
            const responseText2 = await vqa_Questions_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvqa_QuestionsObjLst0 = <Array<clsvqa_QuestionsEN>>jsonData;
            });

            var strhtml = "";
            strhtml += '<div class="info" id="infoPaper_QA">';
            for (var j = 0; j < arrvqa_PdfPageNumObjLst.length; j++) {

                arrvqa_QuestionsObjLst = arrvqa_QuestionsObjLst0.filter(x => x.pdfPageNum == arrvqa_PdfPageNumObjLst[j].pdfPageNum)

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
                var objQuestions = arrvqa_QuestionsObjLst0.find(x => x.questionsId == strQuestionsId)
                if (objQuestions != null) {

                    btnShowAnswer_Click(strQuestionsId, objQuestions.pdfPageNum, objQuestions.pdfContent);
                }
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //显示pdf标注
    public async Showdiv_PdfQuestions() {

        var strWhereCond = "1=1 and questionsTypeId='01' and paperId='" + $("#hidPaperId").val() + "' order by updDate Asc";

        var strUserId = clsPublocalStorage.userId
        //var objqa_Questions: clsqa_QuestionsEN = null;
        var arrqa_QuestionsObjLst0: Array<clsqa_QuestionsEN> = [];
        var arrqa_QuestionsObjLst: Array<clsqa_QuestionsEN> = [];

        try {

            const responseText1 = await qa_Questions_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrqa_QuestionsObjLst = <Array<clsqa_QuestionsEN>>jsonData;
            });

            //$(".QuestionsCss").remove();
            $("#iframe_qaPdf", parent.document).contents().find(".QuestionsCss").remove();
            for (var i = 0; i < arrqa_QuestionsObjLst.length; i++) {

                var strPdfPageNum = arrqa_QuestionsObjLst[i].pdfPageNum;
                var strQuestionsId = arrqa_QuestionsObjLst[i].questionsId;
                var strQuestionsContent = arrqa_QuestionsObjLst[i].questionsContent;


                //如果zoom是auto的那么就默认赋值110
                var Currpdf_zoom: number = 0;
                if (this.pdf_zoom == "auto") {
                    Currpdf_zoom = 110;
                } else {
                    Currpdf_zoom = Number(this.pdf_zoom);
                }

                var Datapdf_zoom: number = 0;
                if (arrqa_QuestionsObjLst[i].pdfZoom == "auto") {
                    Datapdf_zoom = 110;
                } else {
                    Datapdf_zoom = Number(arrqa_QuestionsObjLst[i].pdfZoom);
                }

                //var Datapdf_zoom: number = Number(arrgs_TagsObjLst[i].pdfZoom);
                var strPdfDivTop: number = Number(arrqa_QuestionsObjLst[i].pdfDivTop);
                var strPdfDivLet: number = Number(arrqa_QuestionsObjLst[i].pdfDivLet);

                if (Currpdf_zoom > Datapdf_zoom) {
                    var ZoomValue = Currpdf_zoom - Datapdf_zoom;
                    ZoomValue = ZoomValue - (ZoomValue / 10);
                    //获得换算后的top值
                    strPdfDivTop = strPdfDivTop + (strPdfDivTop * (ZoomValue / 100));
                    //获得换算后的top值
                    strPdfDivLet = strPdfDivLet + (strPdfDivLet * (ZoomValue / 100));

                    strPdfDivTop = strPdfDivTop - 20;//补充值，为了标记放置在文字的上面

                } else if (Currpdf_zoom < Datapdf_zoom) {
                    var ZoomValue = Datapdf_zoom - Currpdf_zoom;
                    ZoomValue = ZoomValue + (ZoomValue / 10);
                    //获得换算后的top值
                    strPdfDivTop = strPdfDivTop - (strPdfDivTop * (ZoomValue / 100));
                    //获得换算后的top值
                    strPdfDivLet = strPdfDivLet - (strPdfDivLet * (ZoomValue / 100));

                    strPdfDivTop = strPdfDivTop - 20;//补充值，为了标记放置在文字的上面

                }
                else {
                    strPdfDivTop = strPdfDivTop - 20;//补充值，为了标记放置在文字的上面
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
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
    public async btnShowAnswer_Click() {

        //对pdf添加高亮
        //this.btnUpdatePaperPageNum_Click(this.hidPdfContent);

        //绑定答案数据
        var arrvqa_AnswerObjLst1: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst2: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst3: Array<clsvqa_AnswerEN> = [];

        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        var strUserId = clsPublocalStorage.userId;
        var strQuestionsId = this.questionsId;

        if ($('#hidOrderbyId').val() == "1") {
            //全部评论
            strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
        }
        var strVateWhereCond = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='12' and pubParentId='" + strQuestionsId + "'";

        var strQWhereCond = "questionsId='" + strQuestionsId + "'";
        try {

            const responseText1 = await vqa_Answer_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvqa_AnswerObjLst1 = <Array<clsvqa_AnswerEN>>jsonData;
            });
            const responseText2 = await vqa_Answer_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvqa_AnswerObjLst2 = <Array<clsvqa_AnswerEN>>jsonData;
            });

            const responseText3 = await SysVote_GetObjLstAsync(strVateWhereCond).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });

            const objqa_Questions = await qa_Questions_GetFirstObjAsync(strQWhereCond);
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
                } else {
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
                        } else {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User">' + arrvqa_AnswerObjLst3[j].userName + '</b>：</span>';
                        }
                        strhtml += '' + arrvqa_AnswerObjLst3[j].answerContent + '</div>';



                        strhtml += '<div class="reply-operate reply-operate--hot">'
                        //if (arrvqa_AnswerObjLst3[j].scoreType == "2") {
                        //    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrvqa_AnswerObjLst3[j].score + '</i></span>';
                        //} else {
                        //    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrvqa_AnswerObjLst3[j].score + '</i></span>';
                        //}
                        var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrvqa_AnswerObjLst3[j].answerId);
                        if (objLike == null) {
                            strhtml += '<span class="J_Vote reply-operate-item reply-up" onclick=btnAddVote_Click("' + arrvqa_AnswerObjLst3[j].answerId + '","' + arrvqa_AnswerObjLst3[j].updUser + '")>赞<i>' + arrvqa_AnswerObjLst3[j].voteCount + '</i></span >';
                        } else {
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
                } else {
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
            var strMsg: string = `获取数据不成功,${e}.`;
            alert(strMsg);
        }

    }

    //添加高亮
    public btnUpdatePaperPageNum_Click(strFindText: string) {

        this.RemoveSelect()
        //var objLst = document.getElementsByTagName("span");
        var objLst = window.parent.frames["iframe_qaPdf"].contentDocument.getElementsByTagName("span");
        //var strStartName: string = "400%";
        let arrElement: Array<HTMLElement> = this.GetArray(objLst) as Array<HTMLElement>;
        //let arrSpan
        let arrFind: Array<HTMLSpanElement> = arrElement as Array<HTMLSpanElement>;
        //let arrFind: Array<HTMLSpanElement> = arrSpan.filter(x => x.id.indexOf(strStartName) > -1);

        let arrWord: Array<string> = arrFind.map(x => x.innerText);

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
                    if (intCompareIndex >= strFindText.length) break;
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
            let arrSpan_Sel: Array<HTMLSpanElement> = arrFind.slice(intStart, intEnd)
            arrSpan_Sel.forEach(x => {
                var strWord = x.innerText;
                //var objSpan_New: HTMLSpanElement = document.createElement("span");
                var objSpan_New: HTMLSpanElement = window.parent.frames["iframe_qaPdf"].contentDocument.createElement("span");
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
    public GetArray(arr): Array<HTMLElement> {
        let arrLst: Array<HTMLElement> = new Array<HTMLElement>();
        for (var i = 0; i < arr.length; i++) {
            var chk: HTMLElement = arr[i];// as HTMLElement;
            arrLst.push(chk);
        }
        return arrLst;
    }
    //清除高亮
    public RemoveSelect() {

        //var objLst = document.getElementsByTagName("span");
        var objLst = window.parent.frames["iframe_qaPdf"].contentDocument.getElementsByTagName("span");
        //var strStartName: string = "divEditFldComparison";
        let arrElement: Array<HTMLElement> = this.GetArray(objLst) as Array<HTMLElement>;
        let arrSpan: Array<HTMLSpanElement> = arrElement as Array<HTMLSpanElement>;
        let arrSpan_Sel: Array<HTMLSpanElement> = arrSpan.filter(x => x.className == "text-span");

        arrSpan_Sel.forEach(x => {
            var strWord = x.innerText;
            var objSpan_Parent = x.parentNode as HTMLSpanElement;
            objSpan_Parent.innerHTML = strWord;

        });


    };




    /* 添加问题
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
   */
    public async btnAddNewQuestions_Click() {
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
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }



    /* 修改问题
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
  */
    public async btnUpdateQuestions_Click(strQuestionsId: string) {
        this.btnOKUpd1 = "确认修改";
        this.btnCancel1 = "取消修改";
        this.questionsId = strQuestionsId;
        try {
            const responseText = await qa_Questions_GetObjByQuestionsIdAsync(strQuestionsId);
            var objqa_QuestionsEN: clsqa_QuestionsEN = <clsqa_QuestionsEN>responseText;
            this.GetDataFromqa_QuestionsClass(objqa_QuestionsEN);
            console.log("完成UpdateRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnOKUpd1_Click() {
        var strCommandText: string = this.btnOKUpd1;
        try {
            switch (strCommandText) {
                case "添加":
                    //const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    var returnBool2: boolean = true;
                    const responseText2_1 = await this.AddNewRecordWithMaxIdSave1().then((jsonData) => {
                        returnBool2 = jsonData;

                    });
                    if (returnBool2 == true) {
                        //同步问题数量信息
                        const responseText2_2 = await this.SynQuestions();
                        $('#divEditQuestionsRegion').hide();
                        $('#div_qa_Welcome').show();
                        if (clsPubSessionStorage.GetUserLst() != "") {
                            const responseText2_3 = await this.AddNewqa_Push();
                        }
                        const responseText2_4 = await this.Showdiv_Questions();
                        const responseText2_5 = await this.Showdiv_PdfQuestions();

                    }

                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    var returnBool3: boolean = true;
                    var strInfo: string = "";
                    const responseText3_1 = await this.UpdateRecordSave1().then((jsonData) => {
                        returnBool3 = jsonData;
                        strInfo = returnBool3 ? "问题修改成功！" : "问题修改不成功！";
                        //strInfo += "(In qa_QuestionsCRUD.btnOKUpd_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                    });

                    if (returnBool3 == true) {
                        Alert1(strInfo)

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
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }



    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
   */
    public async AddNewRecordWithMaxIdSave1() {
        //
        var objqa_QuestionsEN: clsqa_QuestionsEN = new clsqa_QuestionsEN();
        objqa_QuestionsEN.SetCreateDate(clsPubFun4Web.getNowDate());// 修改日期
        this.PutDataToqa_QuestionsClass(objqa_QuestionsEN);

        try {
            //const responseText2 = await qa_Questions_AddNewRecordWithMaxIdAsync(objqa_QuestionsEN);
            const responseText2 = await qa_Questions_AddNewRecordWithReturnKeyAsync(objqa_QuestionsEN);

            var strQuestionsId: string = responseText2;

            //var returnBool: boolean = !!responseText2;
            if (strQuestionsId != "") {
                this.questionsId = strQuestionsId;
                var strInfo: string = `添加问题成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                Alert1(strInfo)
                //alert(strInfo);
                return true;
            }
            else {
                var strInfo: string = `添加问题不成功!`;
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
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public async UpdateRecordSave1() {
        const strThisFuncName = this.UpdateRecordSave1.name;

        //
        var objqa_QuestionsEN: clsqa_QuestionsEN = new clsqa_QuestionsEN();
        objqa_QuestionsEN.SetQuestionsId(this.questionsId);
        this.PutDataToqa_QuestionsClass(objqa_QuestionsEN);
        objqa_QuestionsEN.sfUpdFldSetStr = objqa_QuestionsEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objqa_QuestionsEN.questionsId == "" || objqa_QuestionsEN.questionsId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await qa_Questions_UpdateRecordAsync(objqa_QuestionsEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }

    ///添加问题推送
    public async AddNewqa_Push() {
        try {
            var strJson = clsPubSessionStorage.GetUserLst();
            var JsonLent: number = strJson.length;
            strJson = strJson.substr(0, JsonLent - 1);
            console.log(strJson);
            var strUses = eval('[' + strJson + ']');
            //把存入的数组拿出来循环并添加到推送表
            for (var i = 0; i < strUses.length; i++) {
                var strUserId = strUses[i];
                var objqa_PushEN: clsqa_PushEN = new clsqa_PushEN();
                objqa_PushEN.SetQuestionsId(this.questionsId);
                objqa_PushEN.SetReceiveUser(strUserId);
                objqa_PushEN.SetIsReceive(false);
                objqa_PushEN.SetIsRequestReply(this.isRequestReply);// 是否要求回复
                objqa_PushEN.SetUpdDate(clsPubFun4Web.getNowDate());
                objqa_PushEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班Id
                const responseText = await qa_Push_AddNewRecordAsync(objqa_PushEN);
                console.log(responseText);
            }
            //添加完以后清空用户数组字符串
            var strKey: string = "UserLst";
            sessionStorage.removeItem(strKey);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `推送记录添加不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }
    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjqa_QuestionsEN">数据传输的目的类对象</param>
  */
    public PutDataToqa_QuestionsClass(pobjqa_QuestionsEN: clsqa_QuestionsEN) {
        pobjqa_QuestionsEN.SetPaperId($("#hidPaperId").val());
        pobjqa_QuestionsEN.Setqa_PaperId("00000000");
        pobjqa_QuestionsEN.SetQuestionsTypeId("01");
        pobjqa_QuestionsEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjqa_QuestionsEN.SetQuestionsContent(this.questionsContent);// 提问内容
        pobjqa_QuestionsEN.SetPdfContent(this.pdfContent);// Pdf内容
        pobjqa_QuestionsEN.SetPdfPageNum(this.pdfPageNum);// Pdf页码
        pobjqa_QuestionsEN.SetOrderNum(this.orderNum);// 序号


        pobjqa_QuestionsEN.SetPdfPageNumIn(this.page_cache);
        pobjqa_QuestionsEN.SetPdfPageTop(this.page_top);
        pobjqa_QuestionsEN.SetPdfZoom(this.pdf_zoom);
        var pdfDiv_top = this.pdfDiv_top;
        pdfDiv_top = pdfDiv_top.substr(0, pdfDiv_top.length - 2);
        var pdfDiv_left = this.pdfDiv_left;
        pdfDiv_left = pdfDiv_left.substr(0, pdfDiv_left.length - 2);


        pobjqa_QuestionsEN.SetPdfDivTop(pdfDiv_top);
        pobjqa_QuestionsEN.SetPdfDivLet(pdfDiv_left);

        pobjqa_QuestionsEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjqa_QuestionsEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
    }


    /* 函数功能:把类对象的属性内容显示到界面上
   注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
    如果在设置数据库时,就应该一级字段在前,二级字段在后
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
    <param name = "pobjqa_QuestionsEN">表实体类对象</param>
  */
    public GetDataFromqa_QuestionsClass(pobjqa_QuestionsEN: clsqa_QuestionsEN) {
        this.questionsContent = pobjqa_QuestionsEN.questionsContent;// 提问内容
        this.pdfContent = pobjqa_QuestionsEN.pdfContent;// Pdf内容
        this.pdfPageNum = pobjqa_QuestionsEN.pdfPageNum;// Pdf页码


    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear1() {
        this.questionsContent = "";
        this.pdfContent = "";
        this.pdfPageNum = 0;
        this.orderNum = 0;
    }

    /* 
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDelQuestions_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }

            //删除问题的时候需要查看一下是否有答案，如果有不能删除
            var strWhereCond = " questionsId=" + strKeyId;
            var intAnswerCount = await qa_Answer_GetRecCountByCondAsync(strWhereCond);
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
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    删除问题
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord1(strQuestionsId: string) {
        try {
            const responseText = await qa_Questions_DelRecordAsync(strQuestionsId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                const responseText3 = await this.SynQuestions();
                var strInfo: string = `删除记录成功!`;
                //显示信息框
                //alert(strInfo);
                Alert1(strInfo);
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
    }

    //添加删除问题的时候统计问题数据量到论文答疑表
    public async SynQuestions() {
        const strThisFuncName = this.SynQuestions.name;
        var strPaperId = $("#hidPaperId").val();

        //添加记录的同时并记录论文读写的教师评价数
        var strWhereCond = " questionsTypeId='01' and paperId=" + strPaperId;
        var intQuestionsCount = await vqa_Questions_GetRecCountByCondAsync(strWhereCond);

        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId(strPaperId);
        objPaperEN.SetPaperQCount(intQuestionsCount);

        objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }

        const responseText = await Paper_UpdateRecordAsync(objPaperEN);
        var returnBool: boolean = !!responseText;
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
    public async btnAddNewAnswer_Click() {
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
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 修改答案
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async btnUpdateAnswer_Click(strAnswerId: string) {
        this.btnOKUpd2 = "确认修改";
        this.btnCancel2 = "取消修改";
        this.answerId = strAnswerId;
        try {
            const responseText = await qa_Answer_GetObjByAnswerIdAsync(strAnswerId);
            var objqa_AnswerEN: clsqa_AnswerEN = <clsqa_AnswerEN>responseText;
            this.answerContent = objqa_AnswerEN.answerContent;
            console.log("完成UpdateRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnOKUpd2_Click() {
        var strCommandText: string = this.btnOKUpd2;
        try {
            switch (strCommandText) {
                case "添加":
                    //const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    var returnBool2: boolean = true;
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
                    const responseText6 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strAnswerId, "11", "1", clsPublocalStorage.id_CurrEduCls);
                    var returnBool6: boolean = !!responseText6;
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
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
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
                    const responseText7 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strAnswerId, "11", "2", clsPublocalStorage.id_CurrEduCls);
                    var returnBool6: boolean = !!responseText7;
                    if (returnBool6 == true) {
                        console.log("论文子观点数据总表同步成功；");
                    }
                    else {
                        console.log("论文子观点数据总表同步失败；");
                    }
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

    /* 如果是被邀请回答的问题，回答完以后会更新推送表内的信息
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public async btnUpdQA_Push_Click(pushId: number) {
        const strThisFuncName = this.btnUpdQA_Push_Click.name;
        var objqa_PushEN: clsqa_PushEN = new clsqa_PushEN();
        objqa_PushEN.SetPushId(pushId);
        objqa_PushEN.SetIsReceive(true);
        objqa_PushEN.SetIsReply(true);
        objqa_PushEN.SetReplyDate(clsPubFun4Web.getNowDate());
        objqa_PushEN.SetReceiveDate(clsPubFun4Web.getNowDate());
        objqa_PushEN.sfUpdFldSetStr = objqa_PushEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objqa_PushEN.pushId == 0 || objqa_PushEN.pushId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await qa_Push_UpdateRecordAsync(objqa_PushEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                Alert1("当前邀请已经回复！");
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }

    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
   */
    public async AddNewRecordWithMaxIdSave2() {
        //
        var objqa_AnswerEN: clsqa_AnswerEN = new clsqa_AnswerEN();
        objqa_AnswerEN.SetCreateDate(clsPubFun4Web.getNowDate());// 修改日期
        this.PutDataToqa_AnswerClass(objqa_AnswerEN);
        try {
            //const responseText2 = await qa_Answer_AddNewRecordWithMaxIdAsync(objqa_AnswerEN);
            const responseText2 = await qa_Answer_AddNewRecordWithReturnKeyAsync(objqa_AnswerEN);
            //var returnBool: boolean = !!responseText2;
            var strAnswerId: string = responseText2;
            $("#hidAnswerId").val(strAnswerId);
            //var returnBool: boolean = !!responseText2;
            if (strAnswerId != "") {

                //if (returnBool == true) {
                const responseText2 = await this.SynAnswer();
                var strInfo: string = `添加回答成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                Alert1(strInfo);
                //alert(strInfo);
                return true;
            }
            else {
                var strInfo: string = `添加回答不成功!`;
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
            var strMsg: string = `添加回答不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    /* 修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async UpdateRecordSave2() {
        const strThisFuncName = this.UpdateRecordSave2.name;
        //
        var objqa_AnswerEN: clsqa_AnswerEN = new clsqa_AnswerEN();
        objqa_AnswerEN.SetAnswerId(this.answerId);
        $("#hidAnswerId").val(this.answerId);
        this.PutDataToqa_AnswerClass(objqa_AnswerEN);

        objqa_AnswerEN.sfUpdFldSetStr = objqa_AnswerEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objqa_AnswerEN.answerId == "" || objqa_AnswerEN.answerId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await qa_Answer_UpdateRecordAsync(objqa_AnswerEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }




    /* 删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
   */
    public async btnDelAnswer_Click(strAnswerId: string) {
        try {
            const responseText = await this.DelRecord2(strAnswerId);
            const responseBindGv = await this.btnShowAnswer_Click();

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
    public async DelRecord2(strAnswerId: string) {
        try {
            //const responseText = await qa_Answer_DelRecordAsync(strAnswerId);
            const responseText = await qa_AnswerEx_DelRecordAsyncEx(strAnswerId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                const responseText2 = await this.SynAnswer();
                var strInfo: string = `删除记录成功!`;
                //显示信息框
                Alert1(strInfo);
                //alert(strInfo);
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
    }
    public PutDataToqa_AnswerClass(pobjqa_AnswerEN: clsqa_AnswerEN) {
        pobjqa_AnswerEN.SetQuestionsId(this.questionsId);//问题ID
        //pobjqa_AnswerEN.SetParentId("root";//父节点
        pobjqa_AnswerEN.SetParentId($("#hidParentId").val());//父节点
        pobjqa_AnswerEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjqa_AnswerEN.SetAnswerContent(this.answerContent);// 答案内容
        pobjqa_AnswerEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjqa_AnswerEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
    }

    //添加删除答案的时候统计问题数据量到问题表和论文答疑表
    public async SynAnswer() {
        const strThisFuncName = this.SynAnswer.name;
        //var strqa_PaperId = $("#hidqa_PaperId").val();

        //添加记录的同时并记录论文读写的教师评价数
        //var strWhereCond = " qa_PaperId=" + strqa_PaperId;
        //var intAnswerCount1 = await vqa_Answer_GetRecCountByCondAsync(strWhereCond);

        //var objqa_PaperEN: clsqa_PaperEN = new clsqa_PaperEN();
        //objqa_PaperEN.Setqa_PaperId(strqa_PaperId;
        //objqa_PaperEN.SetAnswerCount(intAnswerCount1;

        //objqa_PaperEN.sfUpdFldSetStr = objqa_PaperEN.updFldString;//设置哪些字段被修改(脏字段)
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
        var intAnswerCount2 = await vqa_Answer_GetRecCountByCondAsync(strWhereCond);

        var objqa_QuestionsEN: clsqa_QuestionsEN = new clsqa_QuestionsEN();
        objqa_QuestionsEN.SetQuestionsId(this.questionsId);
        objqa_QuestionsEN.SetAnswerCount(intAnswerCount2);

        objqa_QuestionsEN.sfUpdFldSetStr = objqa_QuestionsEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objqa_QuestionsEN.questionsId == "" || objqa_QuestionsEN.questionsId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }

        const responseText2 = await qa_Questions_UpdateRecordAsync(objqa_QuestionsEN);
        var returnBool2: boolean = !!responseText2;
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
    public async btnAddVote_Click(strAnswerId: string, strUserId: string) {
        const strThisFuncName = this.btnAddVote_Click.name;
        //this.DivName = "divAddNewRecordSave";
        var objSysVoteEN: clsSysVoteEN = new clsSysVoteEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objSysVoteEN.SetTableKey(strAnswerId);
        objSysVoteEN.SetVoteTypeId("12");
        objSysVoteEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        objSysVoteEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
        objSysVoteEN.SetLikedUserId(strUserId);//被点赞用户
        objSysVoteEN.SetPubParentId(this.questionsId);
        objSysVoteEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班Id


        //var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage.userId + "' and tableKey=" + strAnswerId;
        try {
            //const responseText = await SysVote_IsExistRecordAsync(strWhereCond);
            //var bolIsExist: boolean = responseText;
            //if (bolIsExist == true) {
            //    var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
            //    alert(strMsg);
            //    return responseText;//一定要有一个返回值，否则会出错！
            //}

            const responseText2 = await SysVote_AddNewRecordAsync(objSysVoteEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {



                var strWhereCond2 = " 1=1 and voteTypeId='12' and tableKey=" + strAnswerId;
                var intVoteCount = await SysVote_GetRecCountByCondAsync(strWhereCond2);

                var objqa_AnswerEN: clsqa_AnswerEN = new clsqa_AnswerEN();
                objqa_AnswerEN.SetAnswerId(strAnswerId);
                objqa_AnswerEN.SetVoteCount(intVoteCount);

                objqa_AnswerEN.sfUpdFldSetStr = objqa_AnswerEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objqa_AnswerEN.answerId == "" || objqa_AnswerEN.answerId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }

                const responseText = qa_Answer_UpdateRecordAsync(objqa_AnswerEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //const gvResult = await this.btnShowAnswer_Click();
                        var strInfo: string = `已点赞!`;
                        Alert1(strInfo);
                        console.log("已点赞");
                        this.btnShowAnswer_Click();
                    }
                    else {
                        var strInfo: string = `点赞不成功!`;
                        //alert(strInfo);
                        Alert1(strInfo);
                        console.log("点赞不成功");
                    }

                });
            }
            else {
                var strInfo: string = `点赞不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                //alert(strInfo);
                Alert1(strInfo);
                //this.DetailRecord();
                //this.BindGv_vPaperSubViewpoint();
            }


            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `点赞不成功,${e}.`;
            //alert(strMsg);
            Alert1(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }

    //邀请其他人
    public async InviteOthers_Click() {
        var strWhereCond = "1=1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        var strUserId = clsPublocalStorage.userId

        //var objqa_Questions: clsqa_QuestionsEN = null;
        var arrvCurrEduClsStuObjLst: Array<clsvCurrEduClsStuEN> = [];
        var arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN> = [];


        try {

            const responseText1 = await vCurrEduClsStu_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvCurrEduClsStuObjLst = <Array<clsvCurrEduClsStuEN>>jsonData;
            });
            const responseText2 = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvCurrEduClsTeacherObjLst = <Array<clsvCurrEduClsTeacherEN>>jsonData;
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
            var strMsg: string = `获取教学班学生和教师的数据不成功,${e}.`;
            alert(strMsg);
        }
    }

    //at其他人
    public async btnAtUserName_Click(strKey: string, strName: string) {
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
        if (clsPubSessionStorage.GetUserLst() != "") {

            var strJson = clsPubSessionStorage.GetUserLst() + "'" + strKey + "',";
            clsPubSessionStorage.SetUserLst(strJson);
        }
        else {
            var strJson = "'" + strKey + "',";
            clsPubSessionStorage.SetUserLst(strJson);
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
    public set btnCancel1(value: string) {
        $("#btnCancel1").html(value);
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnOKUpd1(value: string) {
        $("#btnOKUpd1").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd1(): string {
        return $("#btnOKUpd1").html();
    }

    /*
    * 设置取消按钮的标题
   */
    public set btnCancel2(value: string) {
        $("#btnCancel2").html(value);
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnOKUpd2(value: string) {
        $("#btnOKUpd2").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd2(): string {
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
    public set orderNum(value: number) {
        $("#txtOrderNum").val(value);
    }
    /*
    * 序号
   */
    public get orderNum(): number {
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
    public set questionsContent(value: string) {
        $("#txtQuestionsContent").val(value);
    }
    /*
    * 提问内容
   */
    public get questionsContent(): string {
        return $("#txtQuestionsContent").val();
    }

    /*
   * 答案内容
  */
    public set answerContent(value: string) {
        $("#txtAnswerContent").val(value);
    }
    /*
    * 答案内容
   */
    public get answerContent(): string {
        return $("#txtAnswerContent").val();
    }

    /*
* 设置操作类型：Add||Update||Detail
*/
    public set opType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public get opType(): string {
        return $("#hidOpType").val();
    }


    /*
    * 设置关键字的值
   */
    public set questionsId(value: string) {
        $("#hidQuestionsId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get questionsId(): string {
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
    public set hidPdfContent(value: string) {
        $("#hidPdfContent").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get hidPdfContent(): string {
        return $("#hidPdfContent").val();
    }




    /*
    * 设置关键字的值
   */
    public set answerId(value: string) {
        $("#hidAnswerId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get answerId(): string {
        return $("#hidAnswerId").val();
    }


    /*
* 是否要求回复
*/
    public set isRequestReply(value: boolean) {
        $("#chkIsRequestReply").attr("checked", value);
    }
    /*
    * 是否要求回复
   */
    public get isRequestReply(): boolean {
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
    public set pdfContent(value: string) {
        //$("#hidPdfContent").val(value);
        //$("#iframe_qaPdf").contents().find("#hidPdfContent").val(value);
        //$(window.parent.$("#iframe_qaPdf")).contents().find("#hidPdfContent").val(value);
        $("#iframe_qaPdf", parent.document).contents().find("#hidPdfContent").val(value);
    }
    /*
    * Pdf内容
   */
    public get pdfContent(): string {
        //return $("#hidPdfContent").val();
        //return $("#iframe_qaPdf").contents().find("#hidPdfContent").val();
        return $("#iframe_qaPdf", parent.document).contents().find("#hidPdfContent").val();

    }

    /*
    * Pdf页码
   */
    public set pdfPageNum(value: number) {
        //$("#hidPdfPageNum").val(value);
        //$("#iframe_qaPdf").contents().find("#hidPdfPageNum").val(value);
        $("#iframe_qaPdf", parent.document).contents().find("#hidPdfPageNum").val(value);
    }
    /*
    * Pdf页码
   */
    public get pdfPageNum(): number {
        //return $("#hidPdfPageNum").val();
        //return $("#iframe_qaPdf").contents().find("#hidPdfPageNum").val();
        return $("#iframe_qaPdf", parent.document).contents().find("#hidPdfPageNum").val();
    }



    /*
 * PdfTop
*/
    public set page_top(value: number) {
        //$("#hidPdfPageNum").val(value);
        //$("#iframe_qaPdf").contents().find("#page_top").val(value);
        $("#iframe_qaPdf", parent.document).contents().find("#page_top").val(value);
    }
    /*
    * PdfTop
   */
    public get page_top(): number {
        //return $("#hidPdfPageNum").val();
        //return $("#iframe_qaPdf").contents().find("#page_top").val();
        return $("#iframe_qaPdf", parent.document).contents().find("#page_top").val();
    }



    /*
 * page_cache
*/
    public set page_cache(value: string) {
        //$("#hidPdfPageNum").val(value);
        //$("#iframe_qaPdf").contents().find("#page_cache").val(value);
        $("#iframe_qaPdf", parent.document).contents().find("#page_cache").val(value);
    }
    /*
    * page_cache
   */
    public get page_cache(): string {
        //return $("#hidPdfPageNum").val();
        //return $("#iframe_qaPdf").contents().find("#page_cache").val();
        return $("#iframe_qaPdf", parent.document).contents().find("#page_cache").val();
    }

    /*
* pdf_zoom
*/
    public set pdf_zoom(value: string) {
        //$("#hidPdfPageNum").val(value);
        //$("#iframe_qaPdf").contents().find("#pdf_zoom").val(value);
        $("#iframe_qaPdf", parent.document).contents().find("#pdf_zoom").val(value);
    }
    /*
    * pdf_zoom
   */
    public get pdf_zoom(): string {
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
    public set pdfDiv_top(value: string) {
        $("#pdfDiv_top").val(value);
        //$("#iframe_qaPdf").contents().find("#pdfDiv_top").val(value);
        //$("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val(value);
    }
    /*
    * pdfDiv_top
   */
    public get pdfDiv_top(): string {
        return $("#pdfDiv_top").val();
        //return $("#iframe_qaPdf").contents().find("#pdfDiv_top").val();
        //return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val();
    }


    /*
* pdfDiv_left
*/
    public set pdfDiv_left(value: string) {
        $("#pdfDiv_left").val(value);
        //$("#iframe_qaPdf").contents().find("#pdfDiv_left").val(value);
        //$("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val(value);
    }
    /*
    * pdfDiv_left
   */
    public get pdfDiv_left(): string {
        return $("#pdfDiv_left").val();
        //return $("#iframe_qaPdf").contents().find("#pdfDiv_left").val();
        //return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val();
    }

}