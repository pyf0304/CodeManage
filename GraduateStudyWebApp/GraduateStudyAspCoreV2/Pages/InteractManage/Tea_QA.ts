import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPublicParagraph } from "../TS/FunClass/clsPublicParagraph.js";
import { clsvCurrEduClsStuEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js";
import { clsvCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsTeacherEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsgs_AnswerCountEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_AnswerCountEN.js";
import { clsvRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js";
import { clsqa_AnswerEN } from "../TS/L0_Entity/InteractManage/clsqa_AnswerEN.js";
import { clsqa_AnswerVerEN } from "../TS/L0_Entity/InteractManage/clsqa_AnswerVerEN.js";
import { clsqa_PushEN } from "../TS/L0_Entity/InteractManage/clsqa_PushEN.js";
import { clsqa_QuestionsEN } from "../TS/L0_Entity/InteractManage/clsqa_QuestionsEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsvqa_AnswerEN } from "../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js";
import { clsvqa_QuestionsEN } from "../TS/L0_Entity/InteractManage/clsvqa_QuestionsEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { vCurrEduClsStu_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js";
import { vCurrEduClsTeacher_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js";
import { Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { gs_AnswerCount_Delgs_AnswerCountsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_AnswerCountWApi.js";
import { vRTUserRela_GetFirstObjAsync, vRTUserRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js";
import { qa_AnswerVer_AddNewRecordAsync, qa_AnswerVer_GetFirstObjAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_AnswerVerWApi.js";
import { qa_Answer_AddNewRecordWithReturnKeyAsync, qa_Answer_GetObjByAnswerIdAsync, qa_Answer_GetRecCountByCondAsync, qa_Answer_IsExistRecordAsync, qa_Answer_UpdateRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_AnswerWApi.js";
import { qa_Push_AddNewRecordAsync, qa_Push_UpdateRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js";
import { qa_Questions_AddNewRecordWithReturnKeyAsync, qa_Questions_DelRecordAsync, qa_Questions_DownMoveAsync, qa_Questions_GetFirstObjAsync, qa_Questions_GetObjByQuestionsIdAsync, qa_Questions_GetObjLstAsync, qa_Questions_GetRecCountByCondAsync, qa_Questions_ReFreshCache, qa_Questions_ReOrderAsync, qa_Questions_UpdateRecordAsync, qa_Questions_UpMoveAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_QuestionsWApi.js";
import { SysVote_AddNewRecordAsync, SysVote_GetObjLstAsync, SysVote_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { vqa_Answer_GetObjLstAsync, vqa_Answer_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js";
import { vqa_Questions_GetObjLstAsync, vqa_Questions_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsvqa_QuestionsWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { gs_AnswerCountEx_AddNewRecordWithMaxIdAsync } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_AnswerCountExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { qa_AnswerEx_DelRecordAsyncEx } from "../TS/L3_ForWApiEx/InteractManage/clsqa_AnswerExWApi.js";
import { vqa_AnswerEx_Getvqa_AnswerTopicIdNumObjLstAsync, vqa_AnswerEx_Getvqa_AnswerUserNumObjLstAsync } from "../TS/L3_ForWApiEx/InteractManage/clsvqa_AnswerExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { clsOrderByData } from "../TS/PubFun/clsOrderByData.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format } from "../TS/PubFun/clsString.js";
declare var strCurrPrjId;
declare function Alert1(strMsg): void;
declare function Alert2(strMsg): void;
declare function Alert3(strMsg): void;
declare function Alert4(strMsg): void;
declare function startCompare(): void;//比较段落
declare function setTextboxio(): void;

declare function btnShowAnswer_Click(strKey, pageNum, pdfContent): void;

declare function SetDivLertTop(str1, str2, str3, str4, str5): void;

declare function DiscussListOrderby(): void;

declare function atOthers(strStuName, strTeaName): void;
declare function LayercClose(): void;
declare function InviteOthers_Click(key): void;

declare function HideDialog(): void;

declare var $;
declare var window;
/* spaqa_QuestionsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Tea_QA {
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



    //显示回答、讨论等绑定列表
    public async Bind_Show3List() {
        switch ($('#hidAnswerTypeId').val()) {
            case "01":
                const responseBindGv1 = await this.btnShowAnswer_Click();
                break;
            case "02":
                const responseBindGv2 = await this.btnShowDiscuss_Click();
                break;
            case "03":
                const responseBindGv3 = await this.btnShowGroupDiscuss_Click();
                break;
            case "04":
                const responseBindGv4 = await this.btnShowRecommendAnswer_Click();
                break;
            default:
                break;
        }
    }



    //绑定提问数据
    public async Showdiv_Questions() {

        //var strWhereCond1 = "1=1 and questionsTypeId='02' and paperId='" + $("#hidPaperId").val() + "'";
        var strWhereCond = "1=1 and questionsTypeId='02' and paperId='" + $("#hidPaperId").val() + "' order by orderNum Asc";
        var strUserId = clsPublocalStorage.userId;
        //var objqa_Questions: clsqa_QuestionsEN = null;
        //var arrvqa_QuestionsObjLst0: Array<clsvqa_QuestionsEN> = [];
        var arrvqa_QuestionsObjLst: Array<clsvqa_QuestionsEN> = [];
        //var arrvqa_PdfPageNumObjLst: Array<clsvqa_QuestionsEN> = [];
        try {

            //const responseText1 = await vqa_QuestionsEx_GetPageNumObjLstAsync(strWhereCond1).then((jsonData) => {
            //    arrvqa_PdfPageNumObjLst = <Array<clsvqa_QuestionsEN>>jsonData;
            //});
            const responseText2 = await vqa_Questions_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvqa_QuestionsObjLst = <Array<clsvqa_QuestionsEN>>jsonData;
            });

            var strhtml = "";
            strhtml += '<div class="info" id="infoSubViewpoint">';

            var strRoleId = clsPublocalStorage.roleId;
            //判断角色
            //不等于学生，其他角色都可以添加问题
            if (strRoleId != "00620003") {

                strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加问题" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewQuestions_Click();> <i class="layui-icon" ></i>添加问题</button></div>';

            }

            //for (var j = 0; j < arrvqa_PdfPageNumObjLst.length; j++) {
            //    arrvqa_QuestionsObjLst = arrvqa_QuestionsObjLst0.filter(x => x.pdfPageNum == arrvqa_PdfPageNumObjLst[j].pdfPageNum)
            //    strhtml += '<div class="title btn-2">';
            //    strhtml += '<a href="#" title="当前pdf论文上的第几页一共有几个问题">第' + arrvqa_PdfPageNumObjLst[j].pdfPageNum + '页上的' + arrvqa_QuestionsObjLst.length + '个答疑</a>';


            //    strhtml += '</div>';
            strhtml += '<ul class="artlist">';


            var k = 0;
            for (var i = 0; i < arrvqa_QuestionsObjLst.length; i++) {

                var strQuestionsId = arrvqa_QuestionsObjLst[i].questionsId;
                k++;
                strhtml += '<li>';

                strhtml += '<div id="Q' + strQuestionsId + '" style="text-align:left; float:left; width:65%;">';
                strhtml += '<span class="rowtit color1">' + k + '.</span>';
                //strhtml += '&nbsp;<span class="rowtit color3">[' + arrvqa_QuestionsObjLst[i].pdfPageNum + ']</span>';

                strhtml += '<span class="title btn-4"><a href="#" onclick=btnShowAnswer_Click("' + strQuestionsId + '",' + arrvqa_QuestionsObjLst[i].pdfPageNum + ',"' + arrvqa_QuestionsObjLst[i].pdfContent + '"); class="abstract-text">' + arrvqa_QuestionsObjLst[i].questionsContent + '</a></span>';
                strhtml += '&nbsp;<span style="font-style:italic;" class="rowtit color2" title="第' + arrvqa_QuestionsObjLst[i].pdfPageNum + '页标记">P' + arrvqa_QuestionsObjLst[i].pdfPageNum + '</span>';
                strhtml += '&nbsp;<span class="rowtit color3">[' + arrvqa_QuestionsObjLst[i].answerCount + ']</span>';
                strhtml += '</div>';

                strhtml += '<div style="text-align:right; float:right; width:34%;">';
                if (strRoleId != "00620003") {
                    //上移
                    strhtml += '<button title="上移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strQuestionsId + '",' + arrvqa_QuestionsObjLst[i].orderNum + ')><i class="iconfont">&#xe6a5;</i></button>';
                    ////下移
                    strhtml += '<button title="下移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strQuestionsId + '",' + arrvqa_QuestionsObjLst[i].orderNum + ')><i class="iconfont">&#xe6a6;</i></button>';
                }
                if (arrvqa_QuestionsObjLst[i].updUser == strUserId) {
                    //编辑
                    strhtml += '<button title="编辑问题" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateQuestions_Click("' + strQuestionsId + '")><i class="layui-icon">&#xe642;</i></button>';
                    //删除
                    strhtml += '<button title="删除问题" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelQuestions_Click("' + strQuestionsId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
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
            //}
            strhtml += '</div>';

            //拼接；
            $("#div_qa_Questions").html(strhtml);
            console.log("完成BindGv_vqa_Questions!");

            var hidQuestionsId = $('#hidQuestionsId').val();
            if (hidQuestionsId != "") {
                var objQuestions = arrvqa_QuestionsObjLst.find(x => x.questionsId == hidQuestionsId)
                if (objQuestions != null) {

                    btnShowAnswer_Click(hidQuestionsId, objQuestions.pdfPageNum, objQuestions.pdfContent);
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

        var strWhereCond = "1=1 and questionsTypeId='02' and paperId='" + $("#hidPaperId").val() + "' order by updDate Asc";

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
                if ($("#pdf_zoom").val() == "auto") {
                    Currpdf_zoom = 110;
                } else {
                    Currpdf_zoom = Number($("#pdf_zoom").val());
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


    //绑定答案数据
    public async btnShowAnswer_Click() {

        //对pdf添加高亮
        //this.btnUpdatePaperPageNum_Click(this.hidPdfContent);

        //绑定答案数据
        var arrvqa_AnswerNumObjLst1: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerNumObjLst2: Array<clsvqa_AnswerEN> = [];

        var arrvqa_AnswerObjLst1: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst1_1: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst1_2: Array<clsvqa_AnswerEN> = [];

        var arrvqa_AnswerObjLst2: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst3: Array<clsvqa_AnswerEN> = [];

        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        var strUserId = clsPublocalStorage.userId;
        var strRoleId = clsPublocalStorage.roleId;
        var strQuestionsId = this.questionsId;

        //主题用户关系列表
        //var objvRTUserRela: clsvRTUserRelaEN = new clsvRTUserRelaEN;

        var arrvRTUserRela0: Array<clsvRTUserRelaEN> = [];
        var arrvRTUserRela1: Array<clsvRTUserRelaEN> = [];
        var arrvRTUserRela2: Array<clsvRTUserRelaEN> = [];
        //主题用户关系 用来显示小组推荐答案色码块标志；
        var arrRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];


        var arrvRTUserRela0_1: Array<clsvRTUserRelaEN> = [];
        var arrvRTUserRela0_2: Array<clsvRTUserRelaEN> = [];




        if ($('#hidOrderbyId').val() == "1") {
            //全部评论 
            strWhereCond1 = " parentId='root' and answerTypeId='01' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='01' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and answerTypeId='01' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='01' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and answerTypeId='01' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='01' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
        }
        var strVateWhereCond = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='12' and pubParentId='" + strQuestionsId + "'";

        var strQWhereCond = "questionsId='" + strQuestionsId + "'";
        try {

            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);


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
                //$('#Questions_Name').html(objqa_Questions.questionsContent);
                $('#answerCount').html(objqa_Questions.answerCount);
                $('#discussCount').html(objqa_Questions.discussCount);
                $('#groupDiscussCount').html(objqa_Questions.groupDiscussCount);
            }


            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                //var strWhereCond3 = "topicId ='" + strTopicId + "' and topicUserRoleId='0002'";
                var strWhereCond3 = "topicId ='" + strTopicId + "'";
                //const responseObjLst3 = await vRTUserRela_GetFirstObjAsync(strWhereCond3).then((jsonData) => {
                //    objvRTUserRela = <clsvRTUserRelaEN>jsonData;
                //});
                //判断角色
                //不等于学生，其他角色都可以添加问题
                //if (strRoleId != "00620003") {



                var strWhereCond4 = " questionsId='" + strQuestionsId + "' and topicId<>'' ";

                const responseText1 = await vqa_AnswerEx_Getvqa_AnswerTopicIdNumObjLstAsync(strWhereCond4).then((jsonData) => {
                    arrvqa_AnswerNumObjLst1 = <Array<clsvqa_AnswerEN>>jsonData;
                });

                if (arrvqa_AnswerNumObjLst1.length > 0) {
                    var arrTopicId = "";
                    for (var i = 0; i < arrvqa_AnswerNumObjLst1.length; i++) {
                        arrTopicId += arrvqa_AnswerNumObjLst1[i].topicId + ",";
                    }
                    arrTopicId = arrTopicId.substr(0, arrTopicId.length - 1);

                    var strWhereCond5 = "topicId in(" + arrTopicId + ") order by topicId Asc";

                    const responseObjLst2 = await vRTUserRela_GetObjLstAsync(strWhereCond5).then((jsonData) => {
                        arrvRTUserRela0 = <Array<clsvRTUserRelaEN>>jsonData;
                    });
                }

                //} else {

                const responseObjLst1 = await vRTUserRela_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                    arrvRTUserRela0_1 = <Array<clsvRTUserRelaEN>>jsonData;
                });

                //}



            } else {

            }

            var strhtml = "";
            var varNum = 0;
            var varFalseNum = 0;
            //$('#J_ShortComment div').remove();
            for (var i = 0; i < arrvqa_AnswerObjLst1.length; i++) {

                var strUserheadPic = "";
                var objUser = arrUsers.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                if (objUser != null) {
                    if (objUser.headPic != "") {
                        var strheadPic = "/GraduateStudyWebApp/" + objUser.headPic;
                        strUserheadPic += '<div class="common-avatar J_User" ><img src="' + strheadPic + '" width="100%" height="100%"></div>';
                    } else {
                        strUserheadPic += '<div class="common-avatar J_User" ><img src="/GraduateStudyWebApp/UploadFiles/UserheadPic/n-avator-bg.png" width="100%" height="100%"></div>';
                    }
                } else {
                    strUserheadPic += '<div class="common-avatar J_User" ><img src="/GraduateStudyWebApp/UploadFiles/UserheadPic/n-avator-bg.png" width="100%" height="100%"></div>';
                }


                //1.判断答案是否提交 ，没提交则显示自己的 并且可以编辑；
                if (arrvqa_AnswerObjLst1[i].isSubmit == true) {
                    varNum++;
                    strhtml += '<div class="comment" >';


                    //根据循环的答案得到主题ID，通过主题ID过滤得到当前主题用户关系列表，同时需要判断只有小组答案 才显示色码块；
                    if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                        arrRTUserRelaObjLst = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                        //循环数据源 
                        strhtml += '<div><th colspan="2">';
                        for (var y = 0; y < arrRTUserRelaObjLst.length; y++) {
                            // var strUserId = arrRTUserRelaObjLst[y].userId;
                            var strUserName = arrRTUserRelaObjLst[y].userName;
                            var strColorCode = arrRTUserRelaObjLst[y].colorCode;
                            //得到显示用户的色码块
                            strhtml += '<label style="background: ' + strColorCode + '">&nbsp;&nbsp;&nbsp;&nbsp;</label>&nbsp;&nbsp;<span>' + strUserName + '</span>&nbsp;&nbsp;&nbsp;';

                        }
                        strhtml += '</th></div>';
                    }

                    //用户头像
                    strhtml += strUserheadPic;

                    strhtml += '<div class="comment-block">';
                    //给用户上色
                    //if (strRoleId != "00620003") {
                    if (arrvqa_AnswerNumObjLst1.length > 0) {
                        if (arrvqa_AnswerObjLst1[i].topicId != "") {
                            arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                            var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                            if (objvRTUserRela != null) {
                                if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:#800080;font-weight:bold;">小组推荐回答(' + objvRTUserRela.topicName + ')</span>';
                                } else {
                                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                                }
                            }
                            else {
                                strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';

                            }

                        }
                        else {
                            strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                        }

                    }
                    else {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    }

                    //} else {
                    //    if (strTopicId != "") {
                    //        var objvRTUserRela = arrvRTUserRela0.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                    //        if (objvRTUserRela != null) {
                    //            //if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                    //            //    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';"> 教师：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //            //} else {
                    //            //    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                    //            //}
                    //            if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                    //                strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:#800080;font-weight:bold;">小组推荐回答(' + objvRTUserRela.topicName + ')</span>';
                    //            } else {
                    //                strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                    //            }
                    //        } else {
                    //            if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                    //                strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:red;" > 教师：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //            } else {
                    //                strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //            }
                    //        }

                    //    } else {
                    //        if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                    //            strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:red;" > 教师：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //        } else {
                    //            strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //        }
                    //    }
                    //}





                    strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment-username J_User">' + varNum + '楼</span></p>';
                    //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';

                    //给内容上色
                    //给用户上色
                    //if (strRoleId != "00620003") {
                    if (arrvqa_AnswerNumObjLst1.length > 0) {

                        if (arrvqa_AnswerObjLst1[i].topicId != "") {
                            arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                            var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                            if (objvRTUserRela != null) {
                                //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                //    strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                                //} else {}
                                strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                            } else {
                                //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                //    strhtml += '<div class="comment-content J_CommentContent" >' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                                //} else { }
                                strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';


                            }

                        }
                        else {
                            strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                        }

                    }
                    else {
                        strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                    }

                    //}
                    //else {
                    //    if (strTopicId != "") {
                    //        var objvRTUserRela = arrvRTUserRela0.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                    //        if (objvRTUserRela != null) {
                    //            //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                    //            //    strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                    //            //} else { }
                    //            strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                    //        } else {
                    //            //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                    //            //    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                    //            //} else {}
                    //            strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                    //        }

                    //    } else {
                    //        //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                    //        //    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                    //        //} else {}
                    //        strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                    //    }
                    //}



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

                    //strhtml += "<span class=\"J_Reply comment-operate-item comment-operate-reply\" id=\"J_Reply\" onclick=\"xadmin.open('教师问题回答评论', '../GraduateEduTools/SysComment?Key=" + arrvqa_AnswerObjLst1[i].answerId + "&Type=11&User=" + arrvqa_AnswerObjLst1[i].updUser + "&pubParentId=" + strQuestionsId + "')\">评论</span>";
                    strhtml += '<span class="J_Reply comment-operate-item2 comment-operate-reply" id="J_Reply" onclick=SysComment("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].updUser + '","' + strQuestionsId + '")>评论<i>' + arrvqa_AnswerObjLst1[i].appraiseCount + '</i>';
                    if (arrvqa_AnswerObjLst1[i].teaScore != 0) {
                        strhtml += '&nbsp;&nbsp;教师评分:<i> ' + arrvqa_AnswerObjLst1[i].teaScore + ' </i>';
                    }
                    if (arrvqa_AnswerObjLst1[i].stuScore != 0) {
                        strhtml += '&nbsp;&nbsp;学生评分:<i> ' + arrvqa_AnswerObjLst1[i].stuScore + ' </i>';
                    }
                    strhtml += '</span>';


                    strhtml += '</div>';
                    if (strTopicId != "") {
                        //var strRTUserId = objvRTUserRela.userId;


                        arrvqa_AnswerObjLst1_1 = arrvqa_AnswerObjLst1.filter(x => x.topicId == strTopicId);
                        if (arrvqa_AnswerObjLst1_1.length > 0) {
                            arrvqa_AnswerObjLst1_2 = arrvqa_AnswerObjLst1_1.filter(x => x.isRecommend == true);

                            if (arrvqa_AnswerObjLst1_2.length == 0) {
                                arrvRTUserRela0_2 = arrvRTUserRela0_1.filter(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                if (arrvRTUserRela0_2.length > 0) {
                                    var objvRTUserRela = arrvRTUserRela0_1.find(x => x.topicUserRoleId == "0002");
                                    if (objvRTUserRela != null) {
                                        if (objvRTUserRela.userId == strUserId) {
                                            if (arrvqa_AnswerObjLst1[i].isRecommend != true) {
                                                strhtml += '<div class="J_Report comment-report" style="right:50px;" id="J_Report6673850347411436155" onclick=btnUpdateAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].topicId + '")>小组推荐</div>';
                                            }
                                        }
                                    }


                                }
                            }

                        }
                    }
                    if (strUserId == arrvqa_AnswerObjLst1[i].updUser) {
                        //strhtml += '<div class="J_Report comment-report" id="J_Report6673850347411436155" onclick=btnUpdateAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>修改</div>';
                        strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';
                    }
                    //历史记录
                    //strhtml += "<div class=\"J_Report comment-report\" style=\"right:150px;\" onclick=\"xadmin.open('历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvqa_AnswerObjLst1[i].answerId + "&Type=12')\">历史版本</div>";
                    strhtml += '<div class=\"J_Report comment-report\" style=\"right:150px;\" onclick=SearchParentV("' + arrvqa_AnswerObjLst1[i].answerId + '")>历史版本</div>';


                    strhtml += '</div></div>';
                }
                else {
                    varFalseNum++;
                    //如果是小组推荐答案，那么成员都可以看见；
                    if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                        if (strTopicId != "") {
                            if (arrvqa_AnswerObjLst1[i].topicId != "") {
                                arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                                //如果当前用户包含在主题用户关系表中，那么则内容可见；
                                var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == strUserId);
                                if (objvRTUserRela != null) {
                                    strhtml += '<div class="comment" >';
                                    //头像
                                    strhtml += strUserheadPic;
                                    strhtml += '<div class="comment-block">';


                                    ////给用户上色
                                    //if (strRoleId != "00620003") {
                                    if (arrvqa_AnswerNumObjLst1.length > 0) {
                                        if (arrvqa_AnswerObjLst1[i].topicId != "") {
                                            arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                                            var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                            if (objvRTUserRela != null) {
                                                if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:#800080;font-weight:bold;">小组推荐回答(' + objvRTUserRela.topicName + ')</span>';
                                                } else {
                                                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                                                }
                                            } else {
                                                strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';

                                            }

                                        }
                                        else {
                                            strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                                        }

                                    }
                                    else {
                                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                                    }

                                    strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;</p>';
                                    //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';

                                    ////给内容上色
                                    ////给用户上色
                                    //if (strRoleId != "00620003") {
                                    if (arrvqa_AnswerNumObjLst1.length > 0) {
                                        if (arrvqa_AnswerObjLst1[i].topicId != "") {
                                            arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                                            var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                            if (objvRTUserRela != null) {

                                                strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                                            } else {

                                                strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';


                                            }

                                        }
                                        else {
                                            strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                                        }

                                    }
                                    else {
                                        strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                                    }

                                    strhtml += '<div class="J_Report comment-report" style="right:100px;" id="J_Report6673850347411436155" onclick=btnSubmitQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>提交</div>';
                                    strhtml += '<div class="J_Report comment-report" style="right:50px;" id="J_Report6673850347411436155" onclick=btnUpdateQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].topicId + '")>修改</div>';
                                    strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';

                                }
                            }
                        }
                        else {
                            strhtml += '<div class="comment" >';
                            //头像
                            strhtml += strUserheadPic;

                            strhtml += '<div class="comment-block">';


                            strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '(推荐回答)</span>';


                            strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;</p>';
                            //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';


                            strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';


                            strhtml += '<div class="J_Report comment-report" style="right:100px;" id="J_Report6673850347411436155" onclick=btnSubmitQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>提交</div>';
                            //strhtml += '<div class="J_Report comment-report" style="right:50px;" id="J_Report6673850347411436155" onclick=btnUpdateQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].topicId + '")>修改</div>';
                            strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';



                        }
                    }
                    else {
                        //如果不是小组答案，且没有提交的数据，那么只能自己看自己的
                        if (strUserId == arrvqa_AnswerObjLst1[i].updUser) {

                            //if (arrvqa_AnswerObjLst1[i].topicId != "") {
                            //    arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                            //    //如果当前用户包含在主题用户关系表中，那么则内容可见；
                            //    var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == strUserId);
                            //    if (objvRTUserRela != null) {
                            //        //小组成员

                            //    }
                            //    else {
                            //        //否则只能查看自己

                            //    }
                            //}



                            strhtml += '<div class="comment" >';
                            //头像
                            strhtml += strUserheadPic;

                            strhtml += '<div class="comment-block">';


                            ////给用户上色
                            //if (strRoleId != "00620003") {
                            if (arrvqa_AnswerNumObjLst1.length > 0) {
                                if (arrvqa_AnswerObjLst1[i].topicId != "") {
                                    arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                                    var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                    if (objvRTUserRela != null) {
                                        if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                            strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:#800080;font-weight:bold;">小组推荐回答(' + objvRTUserRela.topicName + ')</span>';
                                        } else {
                                            strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                                        }
                                    } else {
                                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';

                                    }

                                }
                                else {
                                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                                }

                            }
                            else {
                                strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                            }

                            strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;</p>';
                            //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';

                            ////给内容上色
                            ////给用户上色
                            //if (strRoleId != "00620003") {
                            if (arrvqa_AnswerNumObjLst1.length > 0) {
                                if (arrvqa_AnswerObjLst1[i].topicId != "") {
                                    arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                                    var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                    if (objvRTUserRela != null) {

                                        strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                                    } else {

                                        strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';


                                    }

                                }
                                else {
                                    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                                }

                            }
                            else {
                                strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                            }


                            if (strTopicId != "") {
                                //var strRTUserId = objvRTUserRela.userId;


                                arrvqa_AnswerObjLst1_1 = arrvqa_AnswerObjLst1.filter(x => x.topicId == strTopicId);
                                if (arrvqa_AnswerObjLst1_1.length > 0) {
                                    arrvqa_AnswerObjLst1_2 = arrvqa_AnswerObjLst1_1.filter(x => x.isRecommend == true);

                                    if (arrvqa_AnswerObjLst1_2.length == 0) {
                                        arrvRTUserRela0_2 = arrvRTUserRela0_1.filter(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                        if (arrvRTUserRela0_2.length > 0) {
                                            var objvRTUserRela = arrvRTUserRela0_1.find(x => x.topicUserRoleId == "0002");
                                            if (objvRTUserRela != null) {
                                                if (objvRTUserRela.userId == strUserId) {
                                                    if (arrvqa_AnswerObjLst1[i].isRecommend != true) {
                                                        strhtml += '<div class="J_Report comment-report" style="right:150px;" id="J_Report6673850347411436155" onclick=btnUpdateAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].topicId + '")>小组推荐</div>';
                                                    }
                                                }
                                            }


                                        }
                                    }

                                }
                            }

                            strhtml += '<div class="J_Report comment-report" style="right:100px;" id="J_Report6673850347411436155" onclick=btnSubmitQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>提交</div>';
                            strhtml += '<div class="J_Report comment-report" style="right:50px;" id="J_Report6673850347411436155" onclick=btnUpdateQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].topicId + '")>修改</div>';
                            strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';
                        }
                    }






                    strhtml += '</div></div>';
                }




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

    //绑定组间讨论区
    public async btnShowDiscuss_Click() {
        //绑定答案数据
        var arrvqa_AnswerObjLst1: Array<clsvqa_AnswerEN> = [];
        //var arrvqa_AnswerObjLst1_1: Array<clsvqa_AnswerEN> = [];
        //var arrvqa_AnswerObjLst1_2: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst2: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst3: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerUserNumObjLst: Array<clsvqa_AnswerEN> = [];
        var arrvRTUserRelaLst: Array<clsvRTUserRelaEN> = [];
        var arrvqa_AnswerNumObjLst1: Array<clsvqa_AnswerEN> = [];

        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        var strUserId = clsPublocalStorage.userId;
        var strQuestionsId = this.questionsId;

        //主题用户关系列表
        //var objvRTUserRela: clsvRTUserRelaEN = new clsvRTUserRelaEN;

        //var arrvRTUserRela0: Array<clsvRTUserRelaEN> = [];
        //var arrvRTUserRela: Array<clsvRTUserRelaEN> = [];


        if ($('#hidOrderbyId').val() == "1") {
            //全部评论
            strWhereCond1 = " parentId='root' and answerTypeId='02' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='02' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and answerTypeId='02' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='02' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and answerTypeId='02' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='02' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
        }

        try {
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            const responseText1 = await vqa_Answer_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvqa_AnswerObjLst1 = <Array<clsvqa_AnswerEN>>jsonData;
            });
            const responseText2 = await vqa_Answer_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvqa_AnswerObjLst2 = <Array<clsvqa_AnswerEN>>jsonData;
            });

            var strVateWhereCond = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='12' and pubParentId='" + strQuestionsId + "'";
            const responseText3 = await SysVote_GetObjLstAsync(strVateWhereCond).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });

            var strWhereCond4 = " answerTypeId='02' and  questionsId='" + strQuestionsId + "'";
            const responseText4 = await vqa_AnswerEx_Getvqa_AnswerUserNumObjLstAsync(strWhereCond4).then((jsonData) => {
                arrvqa_AnswerUserNumObjLst = <Array<clsvqa_AnswerEN>>jsonData;
            });

            var strTopicId = clsPrivateSessionStorage.topicId;
            var strWhereCond5 = "topicId ='" + strTopicId + "'";
            const responseObjLst5 = await vRTUserRela_GetObjLstAsync(strWhereCond5).then((jsonData) => {
                arrvRTUserRelaLst = <Array<clsvRTUserRelaEN>>jsonData;
            });


            var strWhereCond5 = " answerTypeId='02' and questionsId='" + strQuestionsId + "' and topicId<>'' ";

            const responseText5 = await vqa_AnswerEx_Getvqa_AnswerTopicIdNumObjLstAsync(strWhereCond5).then((jsonData) => {
                arrvqa_AnswerNumObjLst1 = <Array<clsvqa_AnswerEN>>jsonData;
            });

            if (arrvqa_AnswerNumObjLst1.length > 0) {
                var arrTopicId = "";
                for (var i = 0; i < arrvqa_AnswerNumObjLst1.length; i++) {
                    arrTopicId += arrvqa_AnswerNumObjLst1[i].topicId + ",";
                }
                arrTopicId = arrTopicId.substr(0, arrTopicId.length - 1);

                var strWhereCond6 = "topicId in(" + arrTopicId + ") order by topicId Asc";

                const responseObjLst6 = await vRTUserRela_GetObjLstAsync(strWhereCond6).then((jsonData) => {
                    arrvRTUserRelaLst = <Array<clsvRTUserRelaEN>>jsonData;
                });
            }


            var strQWhereCond = "questionsId='" + strQuestionsId + "'";
            const objqa_Questions = await qa_Questions_GetFirstObjAsync(strQWhereCond);
            if (objqa_Questions != null) {
                //$('#Questions_Name').html(objqa_Questions.questionsContent);
                $('#answerCount').html(objqa_Questions.answerCount);
                $('#discussCount').html(objqa_Questions.discussCount);
                $('#groupDiscussCount').html(objqa_Questions.groupDiscussCount);
            }


            //var strTopicId = clsPrivateSessionStorage.topicId;
            //if (strTopicId != "") {
            //    var strWhereCond3 = "topicId ='" + strTopicId + "' and topicUserRoleId='0002'";
            //    //const responseObjLst3 = await vRTUserRela_GetFirstObjAsync(strWhereCond3).then((jsonData) => {
            //    //    objvRTUserRela = <clsvRTUserRelaEN>jsonData;
            //    //});
            //    const responseObjLst3 = await vRTUserRela_GetObjLstAsync(strWhereCond3).then((jsonData) => {
            //        arrvRTUserRela0 = <Array<clsvRTUserRelaEN>>jsonData;
            //    });
            //}


            var strhtml = "";
            var varNum = 0;

            if (arrvqa_AnswerUserNumObjLst.length > 0) {
                strhtml += '<div style="text-align:left; width:99%;margin:8px;">';
                strhtml += '<p class="text-primary float-left">参与讨论用户：</p>';
                for (var k = 0; k < arrvqa_AnswerUserNumObjLst.length; k++) {
                    if (arrvqa_AnswerUserNumObjLst.length > 0) {
                        strhtml += arrvqa_AnswerUserNumObjLst[k].userName + '<span class="badge badge-pill badge-primary">' + arrvqa_AnswerUserNumObjLst[k].memo + '</span>&nbsp;&nbsp;';
                    }
                }
                strhtml += '</div>';
            }
            //$('#J_ShortComment div').remove();
            for (var i = 0; i < arrvqa_AnswerObjLst1.length; i++) {
                varNum++;
                strhtml += '<div class="comment" >';

                //头像
                var strUserheadPic = "";
                var objUser = arrUsers.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                if (objUser != null) {
                    if (objUser.headPic != "") {
                        var strheadPic = "/GraduateStudyWebApp/" + objUser.headPic;
                        strUserheadPic += '<div class="common-avatar J_User" ><img src="' + strheadPic + '" width="100%" height="100%"></div>';
                    } else {
                        strUserheadPic += '<div class="common-avatar J_User" ><img src="/GraduateStudyWebApp/UploadFiles/UserheadPic/n-avator-bg.png" width="100%" height="100%"></div>';
                    }
                } else {
                    strUserheadPic += '<div class="common-avatar J_User" ><img src="/GraduateStudyWebApp/UploadFiles/UserheadPic/n-avator-bg.png" width="100%" height="100%"></div>';
                }
                strhtml += strUserheadPic;

                strhtml += '<div class="comment-block">';
                //if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                //    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:red;" > 题主：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                //} else {
                //    strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                //}


                var objvRTUserRela = arrvRTUserRelaLst.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                if (objvRTUserRela != null) {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + '">' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                }
                else {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                }


                strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment-username J_User">' + varNum + '楼</span></p>';
                //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                //    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                //} else { }
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
                strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply' + arrvqa_AnswerObjLst1[i].answerId + '" onclick=btnReplyDiscuss_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].userName + '")>回复</span>';
                strhtml += '</div>';

                if (strUserId == arrvqa_AnswerObjLst1[i].updUser) {
                    //strhtml += '<div class="J_Report comment-report" id="J_Report6673850347411436155" onclick=btnUpdateAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>修改</div>';
                    strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';
                }
                strhtml += '</div></div>';
            }

            $("#J_ShortComment_Discuss").html(strhtml);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取数据不成功,${e}.`;
            alert(strMsg);
        }

    }

    //绑定组内讨论区
    public async btnShowGroupDiscuss_Click() {
        //绑定答案数据
        var arrvqa_AnswerObjLst1: Array<clsvqa_AnswerEN> = [];
        //var arrvqa_AnswerObjLst1_1: Array<clsvqa_AnswerEN> = [];
        //var arrvqa_AnswerObjLst1_2: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst2: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst3: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerUserNumObjLst: Array<clsvqa_AnswerEN> = [];
        var arrvRTUserRelaLst: Array<clsvRTUserRelaEN> = [];

        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        var strUserId = clsPublocalStorage.userId;
        var strQuestionsId = this.questionsId;
        var strTopicId = clsPrivateSessionStorage.topicId;


        //主题用户关系列表
        //var objvRTUserRela: clsvRTUserRelaEN = new clsvRTUserRelaEN;

        //var arrvRTUserRela0: Array<clsvRTUserRelaEN> = [];
        //var arrvRTUserRela: Array<clsvRTUserRelaEN> = [];


        if ($('#hidOrderbyId').val() == "1") {
            //全部评论
            strWhereCond1 = " parentId='root' and answerTypeId='03' and  questionsId='" + strQuestionsId + "' and  topicId='" + strTopicId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='03' and  questionsId='" + strQuestionsId + "'and  topicId='" + strTopicId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and answerTypeId='03' and  questionsId='" + strQuestionsId + "' and  topicId='" + strTopicId + "' and updUser='" + strUserId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='03' and  questionsId='" + strQuestionsId + "' and  topicId='" + strTopicId + "' and updUser='" + strUserId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and answerTypeId='03' and  questionsId='" + strQuestionsId + "' and  topicId='" + strTopicId + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='03' and  questionsId='" + strQuestionsId + "' and  topicId='" + strTopicId + "' order by updDate Desc";
        }
        var strVateWhereCond = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='12' and pubParentId='" + strQuestionsId + "'";

        var strQWhereCond = "questionsId='" + strQuestionsId + "'";
        try {
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            const responseText1 = await vqa_Answer_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvqa_AnswerObjLst1 = <Array<clsvqa_AnswerEN>>jsonData;
            });
            const responseText2 = await vqa_Answer_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvqa_AnswerObjLst2 = <Array<clsvqa_AnswerEN>>jsonData;
            });

            const responseText3 = await SysVote_GetObjLstAsync(strVateWhereCond).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });

            var strWhereCond4 = " answerTypeId='03' and  questionsId='" + strQuestionsId + "'";
            const responseText4 = await vqa_AnswerEx_Getvqa_AnswerUserNumObjLstAsync(strWhereCond4).then((jsonData) => {
                arrvqa_AnswerUserNumObjLst = <Array<clsvqa_AnswerEN>>jsonData;
            });

            var strTopicId = clsPrivateSessionStorage.topicId;
            var strWhereCond5 = "topicId ='" + strTopicId + "'";
            const responseObjLst5 = await vRTUserRela_GetObjLstAsync(strWhereCond5).then((jsonData) => {
                arrvRTUserRelaLst = <Array<clsvRTUserRelaEN>>jsonData;
            });

            const objqa_Questions = await qa_Questions_GetFirstObjAsync(strQWhereCond);
            if (objqa_Questions != null) {
                //$('#Questions_Name').html(objqa_Questions.questionsContent);
                $('#answerCount').html(objqa_Questions.answerCount);
                $('#discussCount').html(objqa_Questions.discussCount);
                $('#groupDiscussCount').html(objqa_Questions.groupDiscussCount);
            }


            //var strTopicId = clsPrivateSessionStorage.topicId;
            //if (strTopicId != "") {
            //    var strWhereCond3 = "topicId ='" + strTopicId + "' and topicUserRoleId='0002'";
            //    //const responseObjLst3 = await vRTUserRela_GetFirstObjAsync(strWhereCond3).then((jsonData) => {
            //    //    objvRTUserRela = <clsvRTUserRelaEN>jsonData;
            //    //});
            //    const responseObjLst3 = await vRTUserRela_GetObjLstAsync(strWhereCond3).then((jsonData) => {
            //        arrvRTUserRela0 = <Array<clsvRTUserRelaEN>>jsonData;
            //    });
            //}

            var strhtml = "";
            var varNum = 0;
            strhtml += '<div style="text-align:left; width:99%;margin:8px;">';
            //for (var k = 0; k < arrvqa_AnswerUserNumObjLst.length; k++) {
            //    if (arrvqa_AnswerUserNumObjLst.length > 0) {
            //        strhtml += arrvqa_AnswerUserNumObjLst[k].userName + ':<span class="badge badge-pill badge-primary">' + arrvqa_AnswerUserNumObjLst[k].memo + '</span>&nbsp;&nbsp;';
            //    }
            //}
            strhtml += '<p class="text-primary float-left">参与讨论用户：</p>';
            for (var k = 0; k < arrvqa_AnswerUserNumObjLst.length; k++) {
                if (arrvqa_AnswerUserNumObjLst.length > 0) {
                    strhtml += arrvqa_AnswerUserNumObjLst[k].userName + '<span class="badge badge-pill badge-primary">' + arrvqa_AnswerUserNumObjLst[k].memo + '</span>&nbsp;&nbsp;';
                }
            }
            strhtml += '</div>';
            //$('#J_ShortComment div').remove();
            for (var i = 0; i < arrvqa_AnswerObjLst1.length; i++) {
                varNum++;
                strhtml += '<div class="comment" >';
                //头像
                var strUserheadPic = "";
                var objUser = arrUsers.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                if (objUser != null) {
                    if (objUser.headPic != "") {
                        var strheadPic = "/GraduateStudyWebApp/" + objUser.headPic;
                        strUserheadPic += '<div class="common-avatar J_User" ><img src="' + strheadPic + '" width="100%" height="100%"></div>';
                    } else {
                        strUserheadPic += '<div class="common-avatar J_User" ><img src="/GraduateStudyWebApp/UploadFiles/UserheadPic/n-avator-bg.png" width="100%" height="100%"></div>';
                    }
                } else {
                    strUserheadPic += '<div class="common-avatar J_User" ><img src="/GraduateStudyWebApp/UploadFiles/UserheadPic/n-avator-bg.png" width="100%" height="100%"></div>';
                }
                strhtml += strUserheadPic;

                strhtml += '<div class="comment-block">';
                //if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                //    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:red;" > 题主：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                //} else {
                //    strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                //}
                var objvRTUserRela = arrvRTUserRelaLst.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                if (objvRTUserRela != null) {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + '">' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                }
                else {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                }
                strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment-username J_User">' + varNum + '楼</span></p>';
                //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                //    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                //} else { }
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
                strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply' + arrvqa_AnswerObjLst1[i].answerId + '" onclick=btnReplyDiscuss_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].userName + '")>回复</span>';
                strhtml += '</div>';

                if (strUserId == arrvqa_AnswerObjLst1[i].updUser) {
                    //strhtml += '<div class="J_Report comment-report" id="J_Report6673850347411436155" onclick=btnUpdateAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>修改</div>';
                    strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';
                }
                strhtml += '</div></div>';
            }

            $("#J_ShortComment_Discuss2").html(strhtml);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取数据不成功,${e}.`;
            alert(strMsg);
        }

    }

    //推荐回答
    public async btnShowRecommendAnswer_Click() {

        //对pdf添加高亮
        this.btnUpdatePaperPageNum_Click(this.hidPdfContent);

        //绑定答案数据
        var arrvqa_AnswerNumObjLst1: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerNumObjLst2: Array<clsvqa_AnswerEN> = [];

        var arrvqa_AnswerObjLst1: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst1_1: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst1_2: Array<clsvqa_AnswerEN> = [];

        var arrvqa_AnswerObjLst2: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst3: Array<clsvqa_AnswerEN> = [];

        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        var strUserId = clsPublocalStorage.userId;
        var strRoleId = clsPublocalStorage.roleId;
        var strQuestionsId = this.questionsId;

        //主题用户关系列表
        //var objvRTUserRela: clsvRTUserRelaEN = new clsvRTUserRelaEN;

        var arrvRTUserRela0: Array<clsvRTUserRelaEN> = [];
        var arrvRTUserRela1: Array<clsvRTUserRelaEN> = [];
        var arrvRTUserRela2: Array<clsvRTUserRelaEN> = [];
        //主题用户关系 用来显示小组推荐答案色码块标志；
        var arrRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];


        var arrvRTUserRela0_1: Array<clsvRTUserRelaEN> = [];
        var arrvRTUserRela0_2: Array<clsvRTUserRelaEN> = [];




        if ($('#hidOrderbyId').val() == "1") {
            //全部评论 
            strWhereCond1 = " parentId='root' and isRecommend=1 and answerTypeId='01' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='01' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and isRecommend=1 and answerTypeId='01' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='01' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and isRecommend=1 and answerTypeId='01' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and answerTypeId='01' and  questionsId='" + strQuestionsId + "' order by updDate Desc";
        }
        var strVateWhereCond = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='12' and pubParentId='" + strQuestionsId + "'";

        var strQWhereCond = "questionsId='" + strQuestionsId + "'";
        try {

            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);


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
                //$('#Questions_Name').html(objqa_Questions.questionsContent);
                $('#answerCount').html(objqa_Questions.answerCount);
                $('#discussCount').html(objqa_Questions.discussCount);
                $('#groupDiscussCount').html(objqa_Questions.groupDiscussCount);
            }


            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                //var strWhereCond3 = "topicId ='" + strTopicId + "' and topicUserRoleId='0002'";
                var strWhereCond3 = "topicId ='" + strTopicId + "'";
                //const responseObjLst3 = await vRTUserRela_GetFirstObjAsync(strWhereCond3).then((jsonData) => {
                //    objvRTUserRela = <clsvRTUserRelaEN>jsonData;
                //});
                //判断角色
                //不等于学生，其他角色都可以添加问题
                //if (strRoleId != "00620003") {



                var strWhereCond4 = " questionsId='" + strQuestionsId + "' and topicId<>'' ";

                const responseText1 = await vqa_AnswerEx_Getvqa_AnswerTopicIdNumObjLstAsync(strWhereCond4).then((jsonData) => {
                    arrvqa_AnswerNumObjLst1 = <Array<clsvqa_AnswerEN>>jsonData;
                });

                if (arrvqa_AnswerNumObjLst1.length > 0) {
                    var arrTopicId = "";
                    for (var i = 0; i < arrvqa_AnswerNumObjLst1.length; i++) {
                        arrTopicId += arrvqa_AnswerNumObjLst1[i].topicId + ",";
                    }
                    arrTopicId = arrTopicId.substr(0, arrTopicId.length - 1);

                    var strWhereCond5 = "topicId in(" + arrTopicId + ") order by topicId Asc";

                    const responseObjLst2 = await vRTUserRela_GetObjLstAsync(strWhereCond5).then((jsonData) => {
                        arrvRTUserRela0 = <Array<clsvRTUserRelaEN>>jsonData;
                    });
                }





                //} else {

                const responseObjLst1 = await vRTUserRela_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                    arrvRTUserRela0_1 = <Array<clsvRTUserRelaEN>>jsonData;
                });

                //}



            }

            var strhtml = "";
            var varNum = 0;
            var varFalseNum = 0;
            //$('#J_ShortComment div').remove();
            for (var i = 0; i < arrvqa_AnswerObjLst1.length; i++) {

                //头像
                var strUserheadPic = "";
                var objUser = arrUsers.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                if (objUser != null) {
                    if (objUser.headPic != "") {
                        var strheadPic = "/GraduateStudyWebApp/" + objUser.headPic;
                        strUserheadPic += '<div class="common-avatar J_User" ><img src="' + strheadPic + '" width="100%" height="100%"></div>';
                    } else {
                        strUserheadPic += '<div class="common-avatar J_User" ><img src="/GraduateStudyWebApp/UploadFiles/UserheadPic/n-avator-bg.png" width="100%" height="100%"></div>';
                    }
                } else {
                    strUserheadPic += '<div class="common-avatar J_User" ><img src="/GraduateStudyWebApp/UploadFiles/UserheadPic/n-avator-bg.png" width="100%" height="100%"></div>';
                }

                //1.判断答案是否提交 ，没提交则显示自己的 并且可以编辑；
                if (arrvqa_AnswerObjLst1[i].isSubmit == true) {
                    varNum++;
                    strhtml += '<div class="comment" >';


                    //根据循环的答案得到主题ID，通过主题ID过滤得到当前主题用户关系列表，同时需要判断只有小组答案 才显示色码块；
                    if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                        arrRTUserRelaObjLst = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                        //循环数据源 
                        strhtml += '<div><th colspan="2">';
                        for (var y = 0; y < arrRTUserRelaObjLst.length; y++) {
                            // var strUserId = arrRTUserRelaObjLst[y].userId;
                            var strUserName = arrRTUserRelaObjLst[y].userName;
                            var strColorCode = arrRTUserRelaObjLst[y].colorCode;
                            //得到显示用户的色码块
                            strhtml += '<label style="background: ' + strColorCode + '">&nbsp;&nbsp;&nbsp;&nbsp;</label>&nbsp;&nbsp;<span>' + strUserName + '</span>&nbsp;&nbsp;&nbsp;';

                        }
                        strhtml += '</th></div>';
                    }


                    //头像
                    strhtml += strUserheadPic;

                    strhtml += '<div class="comment-block">';


                    //给用户上色
                    //if (strRoleId != "00620003") {
                    if (arrvqa_AnswerNumObjLst1.length > 0) {
                        if (arrvqa_AnswerObjLst1[i].topicId != "") {
                            arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                            var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                            if (objvRTUserRela != null) {
                                if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:#800080;font-weight:bold;">小组推荐回答(' + objvRTUserRela.topicName + ')</span>';
                                } else {
                                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                                }
                            } else {
                                strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';

                            }

                        }
                        else {
                            strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                        }

                    }
                    else {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    }

                    //} else {
                    //    if (strTopicId != "") {
                    //        var objvRTUserRela = arrvRTUserRela0.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                    //        if (objvRTUserRela != null) {
                    //            //if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                    //            //    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';"> 教师：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //            //} else {
                    //            //    strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                    //            //}
                    //            if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                    //                strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:#800080;font-weight:bold;">小组推荐回答(' + objvRTUserRela.topicName + ')</span>';
                    //            } else {
                    //                strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                    //            }
                    //        } else {
                    //            if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                    //                strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:red;" > 教师：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //            } else {
                    //                strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //            }
                    //        }

                    //    } else {
                    //        if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                    //            strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:red;" > 教师：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //        } else {
                    //            strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    //        }
                    //    }
                    //}





                    strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment-username J_User">' + varNum + '楼</span></p>';
                    //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';

                    //给内容上色
                    //给用户上色
                    //if (strRoleId != "00620003") {
                    if (arrvqa_AnswerNumObjLst1.length > 0) {
                        if (arrvqa_AnswerObjLst1[i].topicId != "") {
                            arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                            var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                            if (objvRTUserRela != null) {
                                //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                //    strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                                //} else {}
                                strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                            } else {
                                //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                //    strhtml += '<div class="comment-content J_CommentContent" >' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                                //} else { }
                                strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';


                            }

                        }
                        else {
                            strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                        }

                    }
                    else {
                        strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                    }

                    //}
                    //else {
                    //    if (strTopicId != "") {
                    //        var objvRTUserRela = arrvRTUserRela0.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                    //        if (objvRTUserRela != null) {
                    //            //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                    //            //    strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                    //            //} else { }
                    //            strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                    //        } else {
                    //            //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                    //            //    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                    //            //} else {}
                    //            strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                    //        }

                    //    } else {
                    //        //if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                    //        //    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '<span style="color:red;">(小组推荐回答)</span></div>';
                    //        //} else {}
                    //        strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                    //    }
                    //}



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
                    if (strTopicId != "") {
                        //var strRTUserId = objvRTUserRela.userId;


                        arrvqa_AnswerObjLst1_1 = arrvqa_AnswerObjLst1.filter(x => x.topicId == strTopicId);
                        if (arrvqa_AnswerObjLst1_1.length > 0) {
                            arrvqa_AnswerObjLst1_2 = arrvqa_AnswerObjLst1_1.filter(x => x.isRecommend == true);

                            if (arrvqa_AnswerObjLst1_2.length == 0) {
                                arrvRTUserRela0_2 = arrvRTUserRela0_1.filter(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                if (arrvRTUserRela0_2.length > 0) {
                                    var objvRTUserRela = arrvRTUserRela0_1.find(x => x.topicUserRoleId == "0002");
                                    if (objvRTUserRela != null) {
                                        if (objvRTUserRela.userId == strUserId) {
                                            if (arrvqa_AnswerObjLst1[i].isRecommend != true) {
                                                strhtml += '<div class="J_Report comment-report" style="right:50px;" id="J_Report6673850347411436155" onclick=btnUpdateAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].topicId + '")>小组推荐</div>';
                                            }
                                        }
                                    }


                                }
                            }

                        }
                    }
                    if (strUserId == arrvqa_AnswerObjLst1[i].updUser) {
                        //strhtml += '<div class="J_Report comment-report" id="J_Report6673850347411436155" onclick=btnUpdateAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>修改</div>';
                        strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';
                    }
                    //历史记录
                    //strhtml += "<div class=\"J_Report comment-report\" style=\"right:150px;\" onclick=\"xadmin.open('历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvqa_AnswerObjLst1[i].answerId + "&Type=12')\">历史版本</div>";
                    strhtml += '<div class=\"J_Report comment-report\" style=\"right:150px;\" onclick=SearchParentV("' + arrvqa_AnswerObjLst1[i].answerId + '")>历史版本</div>';


                    strhtml += '</div></div>';
                }
                else {
                    varFalseNum++;
                    //如果是小组推荐答案，那么成员都可以看见；
                    if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                        if (arrvqa_AnswerObjLst1[i].topicId != "") {
                            arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                            //如果当前用户包含在主题用户关系表中，那么则内容可见；
                            var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == strUserId);
                            if (objvRTUserRela != null) {
                                strhtml += '<div class="comment" >';
                                //头像
                                strhtml += strUserheadPic;

                                strhtml += '<div class="comment-block">';


                                ////给用户上色
                                //if (strRoleId != "00620003") {
                                if (arrvqa_AnswerNumObjLst1.length > 0) {
                                    if (arrvqa_AnswerObjLst1[i].topicId != "") {
                                        arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                                        var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                        if (objvRTUserRela != null) {
                                            if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                                strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:#800080;font-weight:bold;">小组推荐回答(' + objvRTUserRela.topicName + ')</span>';
                                            } else {
                                                strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                                            }
                                        } else {
                                            strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';

                                        }

                                    }
                                    else {
                                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                                    }

                                }
                                else {
                                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                                }

                                strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;</p>';
                                //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';

                                ////给内容上色
                                ////给用户上色
                                //if (strRoleId != "00620003") {
                                if (arrvqa_AnswerNumObjLst1.length > 0) {
                                    if (arrvqa_AnswerObjLst1[i].topicId != "") {
                                        arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                                        var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                        if (objvRTUserRela != null) {

                                            strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                                        } else {

                                            strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';


                                        }

                                    }
                                    else {
                                        strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                                    }

                                }
                                else {
                                    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                                }

                                strhtml += '<div class="J_Report comment-report" style="right:100px;" id="J_Report6673850347411436155" onclick=btnSubmitQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>提交</div>';
                                strhtml += '<div class="J_Report comment-report" style="right:50px;" id="J_Report6673850347411436155" onclick=btnUpdateQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].topicId + '")>修改</div>';
                                strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';

                            }
                        }
                    }

                    else {
                        //如果不是小组答案，且没有提交的数据，那么只能自己看自己的
                        if (strUserId == arrvqa_AnswerObjLst1[i].updUser) {

                            //if (arrvqa_AnswerObjLst1[i].topicId != "") {
                            //    arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                            //    //如果当前用户包含在主题用户关系表中，那么则内容可见；
                            //    var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == strUserId);
                            //    if (objvRTUserRela != null) {
                            //        //小组成员

                            //    }
                            //    else {
                            //        //否则只能查看自己

                            //    }
                            //}



                            strhtml += '<div class="comment" >';
                            //头像
                            strhtml += strUserheadPic;

                            strhtml += '<div class="comment-block">';


                            ////给用户上色
                            //if (strRoleId != "00620003") {
                            if (arrvqa_AnswerNumObjLst1.length > 0) {
                                if (arrvqa_AnswerObjLst1[i].topicId != "") {
                                    arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                                    var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                    if (objvRTUserRela != null) {
                                        if (arrvqa_AnswerObjLst1[i].isRecommend == true) {
                                            strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:#800080;font-weight:bold;">小组推荐回答(' + objvRTUserRela.topicName + ')</span>';
                                        } else {
                                            strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].userName + '(' + objvRTUserRela.topicName + ')</span>';
                                        }
                                    } else {
                                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';

                                    }

                                }
                                else {
                                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                                }

                            }
                            else {
                                strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                            }

                            strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;</p>';
                            //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';

                            ////给内容上色
                            ////给用户上色
                            //if (strRoleId != "00620003") {
                            if (arrvqa_AnswerNumObjLst1.length > 0) {
                                if (arrvqa_AnswerObjLst1[i].topicId != "") {
                                    arrvRTUserRela1 = arrvRTUserRela0.filter(x => x.topicId == arrvqa_AnswerObjLst1[i].topicId);
                                    var objvRTUserRela = arrvRTUserRela1.find(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                    if (objvRTUserRela != null) {

                                        strhtml += '<div class="comment-content J_CommentContent"  style="color:' + objvRTUserRela.colorCode + ';">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                                    } else {

                                        strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';


                                    }

                                }
                                else {
                                    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                                }

                            }
                            else {
                                strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';
                            }


                            if (strTopicId != "") {
                                //var strRTUserId = objvRTUserRela.userId;


                                arrvqa_AnswerObjLst1_1 = arrvqa_AnswerObjLst1.filter(x => x.topicId == strTopicId);
                                if (arrvqa_AnswerObjLst1_1.length > 0) {
                                    arrvqa_AnswerObjLst1_2 = arrvqa_AnswerObjLst1_1.filter(x => x.isRecommend == true);

                                    if (arrvqa_AnswerObjLst1_2.length == 0) {
                                        arrvRTUserRela0_2 = arrvRTUserRela0_1.filter(x => x.userId == arrvqa_AnswerObjLst1[i].updUser);
                                        if (arrvRTUserRela0_2.length > 0) {
                                            var objvRTUserRela = arrvRTUserRela0_1.find(x => x.topicUserRoleId == "0002");
                                            if (objvRTUserRela != null) {
                                                if (objvRTUserRela.userId == strUserId) {
                                                    if (arrvqa_AnswerObjLst1[i].isRecommend != true) {
                                                        strhtml += '<div class="J_Report comment-report" style="right:150px;" id="J_Report6673850347411436155" onclick=btnUpdateAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].topicId + '")>小组推荐</div>';
                                                    }
                                                }
                                            }


                                        }
                                    }

                                }
                            }

                            strhtml += '<div class="J_Report comment-report" style="right:100px;" id="J_Report6673850347411436155" onclick=btnSubmitQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>提交</div>';
                            strhtml += '<div class="J_Report comment-report" style="right:50px;" id="J_Report6673850347411436155" onclick=btnUpdateQa_Answer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].topicId + '")>修改</div>';
                            strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';
                        }
                    }






                    strhtml += '</div></div>';
                }




            }
            //$("#J_ShortComment").append(strhtml);
            $("#J_ShortComment2").html(strhtml);

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
                        //if (clsPubSessionStorage.GetUserLst() != "") {
                        //const responseText2_3 = await this.AddNewqa_Push();//推送方法
                        //}
                        const responseOrder = await this.btnReOrder_Click();
                        const responseText2_4 = await this.Showdiv_Questions();
                        //const responseText2_5 = await this.Showdiv_PdfQuestions();

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
                        //const responseText3_3 = await this.Showdiv_PdfQuestions();
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

            var strWhereCond = " id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "' order by stuName Asc";
            var arrCurrEduClsStuObjLst: Array<clsvCurrEduClsStuEN> = await vCurrEduClsStu_GetObjLstAsync(strWhereCond);

            //把存入的数组拿出来循环并添加到推送表
            for (var i = 0; i < arrCurrEduClsStuObjLst.length; i++) {
                var strUserId = arrCurrEduClsStuObjLst[i].stuID;
                var objqa_PushEN: clsqa_PushEN = new clsqa_PushEN();
                objqa_PushEN.SetQuestionsId(this.questionsId);
                objqa_PushEN.SetReceiveUser(strUserId);
                objqa_PushEN.SetIsReceive(false);
                objqa_PushEN.SetIsRequestReply(true);// 是否要求回复
                objqa_PushEN.SetUpdDate(clsPubFun4Web.getNowDate());
                objqa_PushEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班Id
                const responseText = await qa_Push_AddNewRecordAsync(objqa_PushEN);
                console.log(responseText);
            }
            //添加完以后清空用户数组字符串
            //var strKey: string = "UserLst";
            //sessionStorage.removeItem(strKey);
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
        pobjqa_QuestionsEN.SetQuestionsTypeId("02");
        pobjqa_QuestionsEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班Id
        
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

                Alert2("该问题下面已经有回答了，所以不能删除哦！");
                return "";
            }
            else {

                const responseText = await this.DelRecord1(strKeyId);
                const responseOrder = await this.btnReOrder_Click();
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
        var strWhereCond = " questionsTypeId='02' and paperId=" + strPaperId;
        var intQuestionsCount = await vqa_Questions_GetRecCountByCondAsync(strWhereCond);

        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.SetPaperId(strPaperId);
        objPaperEN.SetTeaQCount(intQuestionsCount);

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


            if ($('#hidAnswerTypeId').val() == "01") {
                if ($('#hidParentId').val() == "root") {

                    var strWhere = " answerTypeId='01' and questionsId='" + this.questionsId + "' and updUser='" + clsPublocalStorage.userId + "' and isRecommend=0 and parentId='root'";
                    var returnBool: boolean = await qa_Answer_IsExistRecordAsync(strWhere);
                    if (returnBool == true) {

                        var strInfo: string = `一个问题只能回答一次，您已经回答过了!`;
                        //显示信息框
                        alert(strInfo);
                        return false;
                    }
                    else {
                        $('#myModalAnswerLabel').html("回答编辑");
                        $('#AnswerInfo').show();
                        $('#AnswerIsSubmit').show();
                    }
                } else {
                    $('#myModalAnswerLabel').html("回答编辑");
                    $('#AnswerInfo').show();
                    $('#AnswerIsSubmit').show();
                }
            } else {
                $('#AnswerInfo').hide();
                $('#AnswerIsSubmit').hide();
                $('#myModalAnswerLabel').html("讨论编辑");
            }

            $('#div_qa_Answer').hide();
            $('#divEditAnswerRegion').show();

            this.btnOKUpd2 = "确认添加";
            this.btnCancel2 = "取消添加";
            this.answerContent = "";
            //const responseText = this.AddNewRecordWithMaxId();
            //1、获取当前用户的色码块
            if (clsPrivateSessionStorage.topicId != "") {
                var strTopicId = clsPrivateSessionStorage.topicId;
                const responseText1 = await this.GetLoginUserColorCode(strTopicId);
            }

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
    public async btnUpdateAnswer_Click(strAnswerId: string, strTopicId: string) {
        if (clsPrivateSessionStorage.topicId != "") {
            this.btnOKUpd2 = "确认推荐";
            this.btnCancel2 = "取消推荐";
        } else {
            this.btnOKUpd2 = "确认修改";
            this.btnCancel2 = "取消修改";
        }

        this.answerId = strAnswerId;
        //1、获取当前用户的色码块
        const responseText1 = await this.GetLoginUserColorCode(strTopicId);
        try {
            const responseText = await qa_Answer_GetObjByAnswerIdAsync(strAnswerId);
            var objqa_AnswerEN: clsqa_AnswerEN = <clsqa_AnswerEN>responseText;
            if (this.btnOKUpd2 == "确认推荐") {
                // var strAnswerContent = objqa_AnswerEN.answerContent.replace("</?[^>]+>", "");//去除html标签

                var strAnswerContent = objqa_AnswerEN.answerContent.replace(/<\/?.+?>/g, "");
                var strAnswerContent = strAnswerContent.replace(/ /g, "");//dds为得到后的内容
                //txtcontent = txtcontent.replace("\\s*|\t|\r|\n", "");//去除字符串中的空格,回车,换行符,制表符
                this.answerContent = strAnswerContent;
            }
            else {
                this.answerContent = objqa_AnswerEN.answerContent;
            }


            //textarea编辑样式；
            setTextboxio();
            console.log("完成UpdateRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }
    //获取当前登录用户的色码在该主题下
    public async GetLoginUserColorCode(strTopicId: string) {

        //主题用户关系
        var arrRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
        var strTopicId = strTopicId;
        var strUserId = clsPublocalStorage.userId;
        $("#hidUserId").val(strUserId);
        ////获取缓存色码表；
        //var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
        ////获取色码数据
        //const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
        //    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;

        //});
        var strWhereCondUser = ` 1=1 And ${clsvRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsvRTUserRelaEN.con_UserId} ='${strUserId}'`;
        //根据当前登录人和主题Id 查询用户排序号，根据排序号 得到色码对应色块；
        const responseText = await vRTUserRela_GetFirstObjAsync(strWhereCondUser).then((jsonData) => {
            var objRtUsersEN: clsvRTUserRelaEN = <clsvRTUserRelaEN>jsonData;
            //通过用户的编号，获取色码表对应的编号色码
            //var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRtUsersEN.orderNum);

            if (objRtUsersEN != null) {
                $("#hidColorCode").val(objRtUsersEN.colorCode);
                ////这里用固定背景色；
                //$("#hidColorCode").val(objRtUsersEN.userBgColor);
            }
        })


    }


    //修改答案

    public async btnUpdateQa_Answer_Click(strAnswerId: string, strTopicId: string) {

        this.btnOKUpd2 = "确认修改";
        this.btnCancel2 = "取消修改";
        
        this.answerId = strAnswerId;
        //1、获取当前用户的色码块
        const responseText1 = await this.GetLoginUserColorCode(strTopicId);
        try {
            const responseText = await qa_Answer_GetObjByAnswerIdAsync(strAnswerId);
            var objqa_AnswerEN: clsqa_AnswerEN = <clsqa_AnswerEN>responseText;
            this.answerContent = objqa_AnswerEN.answerContent;
            //判断如果得到isRecommend状态为true则是小组答案，那么存放到控件；用于修改时候判断是否需要增加历史版本
            if (objqa_AnswerEN.isRecommend == true) {
                $('#hidIsRecommend').val(1);
            }

            $("#hidAnswerTypeId").val(objqa_AnswerEN.answerTypeId);
            $("#hidParentId").val(objqa_AnswerEN.parentId);
            //textarea编辑样式；
            setTextboxio();
            console.log("完成UpdateRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }




    //提交答案
    public async btnSubmitQa_Answer_Click(strAnswerId: string) {
        const strThisFuncName = this.btnSubmitQa_Answer_Click.name;

        this.answerId = strAnswerId;

        try {
            var objqa_AnswerEN: clsqa_AnswerEN = new clsqa_AnswerEN();
            objqa_AnswerEN.SetAnswerId(strAnswerId);
            objqa_AnswerEN.SetIsSubmit(true);

            objqa_AnswerEN.sfUpdFldSetStr = objqa_AnswerEN.updFldString;//设置哪些字段被修改(脏字段)
            if (objqa_AnswerEN.answerId == "" || objqa_AnswerEN.answerId == undefined) {
                 throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            var returnBool: boolean = true;
            const responseText = qa_Answer_UpdateRecordAsync(objqa_AnswerEN).then((jsonData) => {
                returnBool = jsonData;
            });
            if (returnBool == true) {
                //const gvResult = await this.btnShowAnswer_Click();

                var strInfo: string = `提交成功!`;
                Alert1(strInfo);
                console.log("提交成功");
                //this.btnShowAnswer_Click();
                const gvResult1 = await this.SynAnswer();
                const gvResult2 = await this.Bind_Show3List();
                //if ($('#hidAnswerTypeId').val() == "01") {
                //    this.btnShowAnswer_Click();
                //} else {
                //    this.btnShowDiscuss_Click();
                //}
            }
            else {
                var strInfo: string = `提交失败!`;
                //alert(strInfo);
                Alert1(strInfo);
                console.log("提交失败");
            }

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
                    var returnBool1: boolean = true;
                    const responseText1_1 = await this.AddNewRecordWithMaxIdSave2().then((jsonData) => {
                        returnBool1 = jsonData;
                    });

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
                    if (returnBool1 == true) {
                        const responseText1_2 = await this.AddNewRecordWithMaxIdSave3().then((jsonData) => {
                        });

                        $('#div_qa_Answer').show();
                        $('#divEditAnswerRegion').hide();
                        const responseBindGv = await this.Bind_Show3List();

                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    var returnBool2: boolean = true;
                    const responseText3 = await this.UpdateRecordSave2().then((jsonData) => {
                        var returnBool2: boolean = jsonData;

                    });
                    //必须是小组答案才有历史
                    if ($("#hidIsRecommend").val() != "") {
                        //确认推荐，说明就是小组答案，那么这里需要增加历史版本；
                        const responseText3_2 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                console.log("添加历史版本成功！");
                            }
                        });
                    }
                    var strAnswerId = $('#hidAnswerId').val();
                    const responseText7 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strAnswerId, "11", "2", clsPublocalStorage.id_CurrEduCls);
                    var returnBool6: boolean = !!responseText7;
                    if (returnBool6 == true) {
                        console.log("论文子观点数据总表同步成功；");
                    }
                    else {
                        console.log("论文子观点数据总表同步失败；");
                    }

                    if (returnBool2 == true) {
                        var strInfo: string = returnBool2 ? "修改成功！" : "修改不成功！";
                        console.log(strInfo);
                        Alert1(strInfo);
                        $('#div_qa_Answer').show();
                        $('#divEditAnswerRegion').hide();

                        const responseBindGv = await this.Bind_Show3List();
                    }
                    else {
                        var strInfo: string = returnBool2 ? "修改成功！" : "修改不成功！";
                        console.log(strInfo);
                        alert(strInfo);
                    }
                    break;

                case "确认推荐":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    var returnBool3_1: boolean = true;
                    const responseText3_1 = await this.AddNewRecordWithMaxIdSave2().then((jsonData) => {
                        returnBool3_1 = jsonData;
                    });

                    //必须是小组答案才有历史
                    if ($("#hidIsRecommend").val() != "") {
                        //确认推荐，说明就是小组答案，那么这里需要增加历史版本；
                        const responseText3_2 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                console.log("添加历史版本成功！");
                            }
                        });
                    }


                    if (returnBool3_1 == true) {
                        const responseText3_3 = await this.AddNewRecordWithMaxIdSave3().then((jsonData) => {
                        });

                        $('#div_qa_Answer').show();
                        $('#divEditAnswerRegion').hide();
                        this.btnShowAnswer_Click();
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
    //添加历史版本
    public async AddVersionRecordSave() {

        var objqa_AnswerVerEN: clsqa_AnswerVerEN = new clsqa_AnswerVerEN();
        objqa_AnswerVerEN.SetAnswerId(this.answerId);
        this.PutDataToqa_AnswerVClass(objqa_AnswerVerEN);

        try {
            const responseText2 = await qa_AnswerVer_AddNewRecordAsync(objqa_AnswerVerEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                console.log("添加历史版本成功");
                return true;
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加版本记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }

    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjConceptEN">数据传输的目的类对象</param>
  */
    public PutDataToqa_AnswerVClass(pobjqa_AnswerVerEN: clsqa_AnswerVerEN) {

        var strUserId = clsPublocalStorage.userId;
        pobjqa_AnswerVerEN.SetQuestionsId(this.questionsId);//问题ID

        pobjqa_AnswerVerEN.SetIsRecommend(true);
        if (clsPrivateSessionStorage.topicId != "") {
            pobjqa_AnswerVerEN.SetTopicId(clsPrivateSessionStorage.topicId);
        }
        //pobjqa_AnswerEN.SetParentId("root";//父节点
        pobjqa_AnswerVerEN.SetAnswerTypeId($("#hidAnswerTypeId").val()); //回答类型Id
        pobjqa_AnswerVerEN.SetParentId($("#hidParentId").val());//父节点
        pobjqa_AnswerVerEN.SetAnswerContent(this.answerContent);// 答案内容
        pobjqa_AnswerVerEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjqa_AnswerVerEN.SetUpdUser(strUserId);// 修改用户Id
        //是否提交
        pobjqa_AnswerVerEN.SetIsSubmit(this.isSubmit);


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

    /* 添加回答
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
   */
    public async AddNewRecordWithMaxIdSave2() {
        //
        var objqa_AnswerEN: clsqa_AnswerEN = new clsqa_AnswerEN();
        var strUserId = clsPublocalStorage.userId;
       
        var strColorCode = $("#hidColorCode").val();

        //如果回答类型是回答问题（01），那么就针对多用户编辑处理
        if ($("#hidAnswerTypeId").val() == "01") {
            //如果是添加段落，那么肯定是第一条记录，只需要把当前用户的色码块通过html标签加入到段落内容；
            this.answerContent = "<span style='color:" + strColorCode + "' name='" + strUserId + "' >" + this.answerContent + "</span>";
            //this.answerContent = '<span style="color:' + strColorCode + '">' + this.answerContent + '</span>';
        }


        this.PutDataToqa_AnswerClass(objqa_AnswerEN);
        try {

            //const responseText2 = await qa_Answer_AddNewRecordWithMaxIdAsync(objqa_AnswerEN);
            const responseText2 = await qa_Answer_AddNewRecordWithReturnKeyAsync(objqa_AnswerEN);
            //var returnBool: boolean = !!responseText2;
            var strAnswerId: string = responseText2;
            $("#hidAnswerId").val(strAnswerId);
            //存放隐藏控件，用用于历史版本添加；
            this.answerId = strAnswerId;

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

    /**添加讨论*/
    public async DiscussSubmit_Click() {
        //
        var objqa_AnswerEN: clsqa_AnswerEN = new clsqa_AnswerEN();

        objqa_AnswerEN.SetQuestionsId(this.questionsId);//问题ID
        objqa_AnswerEN.SetTopicId(clsPrivateSessionStorage.topicId);
        objqa_AnswerEN.SetAnswerTypeId($("#hidAnswerTypeId").val()); //回答类型Id
        objqa_AnswerEN.SetParentId($("#hidParentId").val());//父节点
        //objqa_AnswerEN.SetParentId("root";//父节点
        objqa_AnswerEN.SetAnswerContent($("#txtDiscussContent").val());// 讨论内容

        objqa_AnswerEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        objqa_AnswerEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        //是否提交
        objqa_AnswerEN.SetIsSubmit(true);
        try {


            const responseText2 = await qa_Answer_AddNewRecordWithReturnKeyAsync(objqa_AnswerEN);

            var strAnswerId: string = responseText2;

            //存放隐藏控件，用用于历史版本添加；
            this.answerId = strAnswerId;

            //var returnBool: boolean = !!responseText2;
            if (strAnswerId != "") {

                //if (returnBool == true) {
                const responseText2 = await this.SynAnswer();
                const responseText1_2 = await this.AddNewRecordWithMaxIdSave3().then((jsonData) => {
                });

                const responseBindGv = await this.Bind_Show3List();
                var strInfo: string = '';
                if ($("#hidParentId").val() == "root") {
                    strInfo = `发布成功!`;

                } else {
                    strInfo = `回复成功!`;
                    $("#btnDiscussSubmit").html("发布");
                    $('#txtDiscussContent').attr('placeholder', "请输入讨论内容");
                }


                $("#txtDiscussContent").val("");
                Alert1(strInfo);
                //div滚动条显示在最底层
                DiscussListOrderby();
                //alert(strInfo);
                return true;
            }
            else {
                var strInfo: string = `发布不成功!`;
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
            var strMsg: string = `发布不成功,${e}.`;
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
        var strHisToryUserId: string = "";
        //判断如果是小组数据修改，那么就比对数据
        if ($("#hidIsRecommend").val() != "") {
            //修改段落，那么首先需要查询该段落的最后一条历史记录，得到段落数据，然后取出来与当前段落数据比较，返回更改的段落数据
            var strWhereCond2 = " 1=1 and answerId=" + this.answerId + " order by AnswerVId desc ";
            // var intVersionCount = await qa_AnswerVer_GetRecCountByCondAsync(strWhereCond2);
            const responseText = await qa_AnswerVer_GetFirstObjAsync(strWhereCond2).then((jsonData) => {
                var objqa_AnswerVerEN: clsqa_AnswerVerEN = <clsqa_AnswerVerEN>jsonData;

                if (objqa_AnswerVerEN != null) {
                    //需要去标签的更改数据存放
                    $("#inpLeft").val(objqa_AnswerVerEN.answerContent);
                    //存放老的带标签的数据不更改
                    $("#inpOldData").val(objqa_AnswerVerEN.answerContent);
                    strHisToryUserId = objqa_AnswerVerEN.updUser;
                }
            })
            //调用比较方法
            startCompare();
           
            //返回比对后的字符串数据；
            var strInputNewContent = $("#txtAnswerContent").val();
            var strNew = $("#inpRight").val();
            var strNewTextContent = clsPublicParagraph.GetNewStringList(strInputNewContent, strNew);
            //把得到新的数据存入编辑控件
            $("#txtAnswerContent").val(strNewTextContent);
        }


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

    //根据老的标签字符串，格式化后，循环数据存放对象列表；
    public AddArrayByString(strText: string): Array<clsPublicParagraph> {
        //用来记录是标签开始，还是结束；
        var Ismark: boolean = false;
        var strTextValue: string = "";//用来接收循环的数据组合；
        //声明一个临时对象列表
        let arrObjLst: Array<clsPublicParagraph> = new Array<clsPublicParagraph>();
        //循环标签字符串，这里循环的是老的标签数据；
        for (var i = 0; i < strText.length; i++) {
            //首先判断标签符号是否是< 
            if (strText[i] == "<") {
                //判断临时数据是否为"" ;为空则说明数据已经被处理，是起始数据；不为空，则说明是标签中间内容部分
                if (strTextValue != "") {
                    //不等于空，则说明是标签内容部分，结束，那么需要插入到对象列表；
                    var objPublicParagraph: clsPublicParagraph = new clsPublicParagraph();
                    objPublicParagraph.TextValue = strTextValue;//把数据存放到对象；
                    objPublicParagraph.IsTag = false;

                    arrObjLst.push(objPublicParagraph);

                    //清空临时变量数据；
                    strTextValue = "";

                    //将数据插入对象列表后，更改为true，因为是标签
                    Ismark = true;
                    //将字符存放到临时数据 ，进行组合
                    strTextValue += strText[i];

                }
                else {
                    //等于空，说明是开始，
                    Ismark = true;
                    //将字符存放到临时数据 ，进行组合
                    strTextValue += strText[i];
                }

            }
            else if (strText[i] == ">") {
                //如果是结束标签；那么ismark改为false；把临时数据存入对象，清空临时数据存放

                var objPublicParagraph: clsPublicParagraph = new clsPublicParagraph();
                objPublicParagraph.TextValue = strTextValue;//把数据存放到对象；
                objPublicParagraph.IsTag = true;

                arrObjLst.push(objPublicParagraph);


                Ismark = false;
                strTextValue = "";
            }
            else {
                //不是<>标签，那么字符继续组合存放
                strTextValue += strText[i];


                ////判断ismark是否为true or false；为true说明还在循环标签 未结束；
                //if(Ismark == true)
                //{
                //    //那么字符继续组合存放
                //    strTextValue += strText[i];
                //}
                //else {
                //    //如果为false，那么则判断 不是标签了，是正常内容；
                //    strTextValue += strText[i];
                //}

            }

        }
        return arrObjLst;
    }




    /* 删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
   */
    public async btnDelAnswer_Click(strAnswerId: string) {
        try {
            //先删除总表数据信息
           // var strAnswerId = $('#hidAnswerId').val();
            const responseText7 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strAnswerId, "11", "3", clsPublocalStorage.id_CurrEduCls);
            var returnBool6: boolean = !!responseText7;
            if (returnBool6 == true) {
                console.log("论文子观点数据总表同步成功；");
            }
            else {
                console.log("论文子观点数据总表同步失败；");
            }


            const responseText = await this.DelRecord2(strAnswerId);

            const responseBindGv = await this.Bind_Show3List();
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

            const responseText = await qa_AnswerEx_DelRecordAsyncEx(strAnswerId);
            var returnInt: number = responseText;
            if (returnInt > 0) {

                const responseText = await gs_AnswerCount_Delgs_AnswerCountsByCondAsync("answerId='" + strAnswerId + "'");
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
        if ($("#hidIsRecommend").val() != "") {
            pobjqa_AnswerEN.SetIsRecommend(true);
        }
        if (clsPrivateSessionStorage.topicId != "") {
            pobjqa_AnswerEN.SetTopicId(clsPrivateSessionStorage.topicId);
        }
        //pobjqa_AnswerEN.SetParentId("root";//父节点
        pobjqa_AnswerEN.SetAnswerTypeId($("#hidAnswerTypeId").val()); //回答类型Id
        pobjqa_AnswerEN.SetParentId($("#hidParentId").val());//父节点
        pobjqa_AnswerEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班Id
        pobjqa_AnswerEN.SetAnswerContent(this.answerContent);// 答案内容

        pobjqa_AnswerEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjqa_AnswerEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        //是否提交
        pobjqa_AnswerEN.SetIsSubmit(this.isSubmit);
    }

    //添加删除答案的时候统计问题数据量到问题表和论文答疑表
    public async SynAnswer() {
        const strThisFuncName = this.SynAnswer.name;

        //var strqa_PaperId = $("#hidqa_PaperId").val();

        ////添加记录的同时并记录论文读写的教师评价数
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
        var strAnswerTypeId = $("#hidAnswerTypeId").val();

        var strWhereCond = " questionsId='" + this.questionsId + "' and answerTypeId='" + strAnswerTypeId + "'";
        if (strAnswerTypeId == "01") {
            strWhereCond += " and isSubmit=1";
        }

        var intAnswerCount2 = await vqa_Answer_GetRecCountByCondAsync(strWhereCond);

        var objqa_QuestionsEN: clsqa_QuestionsEN = new clsqa_QuestionsEN();
        objqa_QuestionsEN.SetQuestionsId(this.questionsId);
        if (strAnswerTypeId == "01") {
            objqa_QuestionsEN.SetAnswerCount(intAnswerCount2);
        } else if (strAnswerTypeId == "02") {
            objqa_QuestionsEN.SetDiscussCount(intAnswerCount2);
        } else {
            objqa_QuestionsEN.SetGroupDiscussCount(intAnswerCount2);
        }


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




    ////////////////////////////////////////////////////////////记录回答数，便于统计周////////////////////////////////////////////////////////////
    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
  */
    public async AddNewRecordWithMaxIdSave3() {
        //
        var objgs_AnswerCountEN: clsgs_AnswerCountEN = new clsgs_AnswerCountEN();
        this.PutDataTogs_AnswerCountClass(objgs_AnswerCountEN);
        try {
            const responseText2 = await gs_AnswerCountEx_AddNewRecordWithMaxIdAsync(objgs_AnswerCountEN);
            var strAnswerCountId: string = responseText2;
            if (strAnswerCountId != "") {
                var strInfo: string = `添加回答统计记录数成功!`;

                //显示信息框
                console.log(strInfo);
                //Alert1(strInfo);
                //alert(strInfo);
                return true;
            }
            else {
                var strInfo: string = `添加回答统计记录数不成功!`;

                //显示信息框
                console.log(strInfo);
                //alert(strInfo);
                return false;
            }
            //return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加回答统计记录数不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }


    public PutDataTogs_AnswerCountClass(pobjgs_AnswerCountEN: clsgs_AnswerCountEN) {
        pobjgs_AnswerCountEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班ID
        pobjgs_AnswerCountEN.SetPaperId($("#hidPaperId").val());//论文ID
        pobjgs_AnswerCountEN.SetQuestionsId(this.questionsId);//问题ID
        if ($("#hidIsRecommend").val() != "") {
            pobjgs_AnswerCountEN.SetIsRecommend(true);
        }
        if (clsPrivateSessionStorage.topicId != "") {
            pobjgs_AnswerCountEN.SetTopicId(clsPrivateSessionStorage.topicId);
        }
        //pobjgs_AnswerCountEN.SetParentId("root";//父节点

        pobjgs_AnswerCountEN.SetAnswerId(this.answerId);
        pobjgs_AnswerCountEN.SetAnswerTypeId($("#hidAnswerTypeId").val()); //回答类型Id
        //pobjgs_AnswerCountEN.SetParentId($("#hidParentId").val();//父节点

        pobjgs_AnswerCountEN.SetAnswerContent(this.answerContent);// 答案内容

        pobjgs_AnswerCountEN.SetDataUser(clsPublocalStorage.userId);// 修改人
        pobjgs_AnswerCountEN.SetUserName(clsPublocalStorage.userName);// 修改人

        pobjgs_AnswerCountEN.SetDataAddDate(clsPubFun4Web.getNowDate());// 修改日期

        pobjgs_AnswerCountEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjgs_AnswerCountEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        //是否提交
        //pobjgs_AnswerCountEN.SetIsSubmit(this.isSubmit;

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
                        this.Bind_Show3List();
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


    //////////////////////////////////////////////////问题表的重序、上移、下移///////////////////////////////////////////////

    /*
重序
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
*/
    public async btnReOrder_Click() {
        // if (this.PreCheck4Order() == false) return;
        var strQuestionsTypeId: string = '02';
        var strPaperId: string = $("#hidPaperId").val();
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            var jsonObject =
            {
                "questionsTypeId": strQuestionsTypeId,
                "paperId": strPaperId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await qa_Questions_ReOrderAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `重序出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.Showdiv_Questions();
    }

    /*
    上移
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
    */
    public async btnUpMove_Click() {
        if ($('#hidOrderNum').val() == 0) {
            const responseOrder = await this.btnReOrder_Click();
        }
        //  if (this.PreCheck4Order() == false) return;
        var strQuestionsTypeId: string = '02';
        var strPaperId: string = $("#hidPaperId").val();
        var arrKeyIds = $("#hidKeyId").val();
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "questionsTypeId": strQuestionsTypeId,
                "paperId": strPaperId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await qa_Questions_UpMoveAsync(objOrderByData);
            const responsegs = await qa_Questions_ReFreshCache();
        }
        catch (e) {
            var strMsg: string = `上移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.Showdiv_Questions();


        //var strListDiv: string = this.mstrListDiv;
        //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /*
    下移
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
    */
    public async btnDownMove_Click() {
        if ($('#hidOrderNum').val() == 0) {
            const responseOrder = await this.btnReOrder_Click();
        }

        //  if (this.PreCheck4Order() == false) return;
        var strQuestionsTypeId: string = '02';
        var strPaperId: string = $("#hidPaperId").val();
        var arrKeyIds = $("#hidKeyId").val();
        //先获取该节点段落最大段落数，如果和排序号相等，那么则是最后一条数据
        var orderNum = $('#hidOrderNum').val();
        var strWhere = " 1=1 And paperId='" + strPaperId + "' And questionsTypeId='" + strQuestionsTypeId + "'";
        var intCount = await qa_Questions_GetRecCountByCondAsync(strWhere);
        if (intCount == orderNum) {
            var strMsg: string = `该记录已经是最后一条记录`;
            alert(strMsg);
            return;
        }
        else {
            try {
                var objOrderByData: clsOrderByData = new clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject =
                {
                    "questionsTypeId": strQuestionsTypeId,
                    "paperId": strPaperId,
                };
                var jsonStr: string = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await qa_Questions_DownMoveAsync(objOrderByData);
                const responsegs = await qa_Questions_ReFreshCache();
            }
            catch (e) {
                var strMsg: string = `下移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.Showdiv_Questions();
        }

        //const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //var strListDiv: string = this.mstrListDiv;
        //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
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
    /*
* 是否提交
*/
    public set isSubmit(value: boolean) {
        $("#chkIsSubmit").attr("checked", value);
    }
    /*
    * 是否提交
   */
    public get isSubmit(): boolean {
        return $("#chkIsSubmit").prop("checked");
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

    /*
* pdfDiv_top
*/
    public set pdfDiv_top(value: string) {
        //$("#hidPdfPageNum").val(value);
        //$("#iframe_qaPdf").contents().find("#pdfDiv_top").val(value);
        $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val(value);
    }
    /*
    * pdfDiv_top
   */
    public get pdfDiv_top(): string {
        //return $("#hidPdfPageNum").val();
        //return $("#iframe_qaPdf").contents().find("#pdfDiv_top").val();
        return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val();
    }


    /*
* pdfDiv_left
*/
    public set pdfDiv_left(value: string) {
        //$("#hidPdfPageNum").val(value);
        //$("#iframe_qaPdf").contents().find("#pdfDiv_left").val(value);
        $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val(value);
    }
    /*
    * page_cache
   */
    public get pdfDiv_left(): string {
        //return $("#hidPdfPageNum").val();
        //return $("#iframe_qaPdf").contents().find("#pdfDiv_left").val();
        return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val();
    }



}