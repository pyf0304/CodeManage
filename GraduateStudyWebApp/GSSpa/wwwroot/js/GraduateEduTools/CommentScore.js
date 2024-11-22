(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTools/clsSysScoreSummaryEN.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js", "../TS/L3_ForWApi/InteractManage/clsgs_TagsWApi.js", "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CommentScore = void 0;
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsSysScoreSummaryEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsSysScoreSummaryEN.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js");
    const clsSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysScoreSummaryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js");
    const clsgs_TagsWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsgs_TagsWApi.js");
    const clsvqa_AnswerWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js");
    const clsSysCommentExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class CommentScore {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 50;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    const gvResult1 = await this.CurrEduClsStuTree();
                    const gvResult2 = await this.li_QaCommentScore_Click();
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
        async li_QaCommentScore_Click() {
            //如果是点击了树菜单、或者是刷新，那么需要做样式控制；
            //首先要去掉ul下 li a 样式
            //$("#myTab li a").removeClass();
            //$("#myTab li").removeClass();
            //判断根据序号显示不同的数据源
            //var strPaperId = $("#hidPaperId").val()
            //if (strPaperId != "") {
            var strnum = $("#hidTabNum").val();
            switch (strnum) {
                case "1":
                    const gvResult1 = await this.Bind_Qa_Answer();
                    break;
                case "2":
                    const gvResult2 = await this.Bind_SysComment();
                    break;
                case "3":
                    const gvResult3 = await this.Bind_PaperTags();
                    break;
                //case "4":
                //    const gvResult4 = await this.Bind_TeaQA();
                //    break;
                default:
                    const gvResult = await this.Bind_Qa_Answer();
                    break;
            }
            //   }
        }
        //绑定论文标记
        async Bind_PaperTags() {
            //标记表
            var arrgs_TagsObjLst = [];
            //打分表
            var arrSysScoreSummaryObjLst = [];
            var objSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN;
            var strUserId = $("#hidStuId").val();
            var strId_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            var strWhereCond4 = " 1=1 and updUser='" + strUserId + "' and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "' order by updDate desc";
            //var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
            //打分0045 表示标记打分（教师专属）
            var strWhereCond5 = " 1=1 and userId='" + strUserId + "' And scoreTypeId ='0045' And id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            try {
                //获取标记数据；
                const responseObjLst2 = await (0, clsgs_TagsWApi_js_1.gs_Tags_GetObjLstAsync)(strWhereCond4).then((jsonData) => {
                    arrgs_TagsObjLst = jsonData;
                });
                const responseTextTopic = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetFirstObjAsync)(strWhereCond5).then((jsonData) => {
                    objSysScoreSummaryEN = jsonData;
                });
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                var intJ = 0;
                strhtml += '<tr cate-id="' + cateid + '" ><td>';
                //strhtml += '<div style="float:left;"><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></div>';
                strhtml += '<div style="float:left;"><h3>标记数据</h3></div>';
                strhtml += '<div style="float:right;">';
                if (objSysScoreSummaryEN != null) {
                    if (objSysScoreSummaryEN.isSubmit == false) {
                        strhtml += '<a style="float:left;" href="#" onclick=BtnAddOrUpdateScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0045")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="打分" ></i>打分</a>';
                        strhtml += '<a href="#" onclick=BtnSubmitScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0045")><i class="layui-icon layui-icon-list" style="font-size:16px; color: #219167;" title="提交" ></i>提交</a>';
                    }
                    else {
                    }
                }
                else {
                    strhtml += '<a style="float:left;" href="#" onclick=BtnAddOrUpdateScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0045")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="打分" ></i>打分</a>';
                    strhtml += '<a href="#" onclick=BtnSubmitScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0045")><i class="layui-icon layui-icon-list" style="font-size:16px; color: #219167;" title="提交" ></i>提交</a>';
                }
                strhtml += '</div></td></tr>';
                var intK = 0;
                for (var k = 0; k < arrgs_TagsObjLst.length; k++) {
                    intK++;
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + intK + '" ><td>';
                    strhtml += '&nbsp;&nbsp;<span class="color3">' + intK + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i>【标记内容】' + arrgs_TagsObjLst[k].tagsContent + '';
                    strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="color2"><i class="layui-icon x-show" status="true">&#xe623;</i>【标记时间】' + arrgs_TagsObjLst[k].updDate + '</span>';
                    strhtml += '</td></tr>';
                }
                //}
                $("#tbTagsList").html(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //教学班学生树
        async CurrEduClsStuTree() {
            //教学班学生
            var arrvCurrEduClsObjLst = [];
            //讨论表
            var arrvqa_AnswerObjLst = [];
            //评价表
            var arrSysCommentObjLst = [];
            //打分表
            var arrSysScoreSummaryObjLst = [];
            //标记表
            var arrgs_TagsObjLst = [];
            //var strWhereCond1 = " updUser='" + clsPublocalStorage.GetUserId() + "' And";
            var strWhereCond1 = " id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'"; //得到评论表的条件；
            //得到讨论表的条件；010203代表属于讨论的类型；
            var strWhereCond3 = " id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "' And answerTypeId in ('01','02','03')";
            //打分00041 0042 表示讨论打分 和评价打分（教师专属）
            var strWhereCond4 = " scoreTypeId in('0041','0042','0045') And id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            // var strWhereCond5 = " 1=1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
            //获取讨论数据；
            const responseObjLst1 = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjLstAsync)(strWhereCond3).then((jsonData) => {
                arrvqa_AnswerObjLst = jsonData;
            });
            //获取评价数据；
            const responseObjLst2 = await (0, clsSysCommentWApi_js_1.SysComment_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                arrSysCommentObjLst = jsonData;
            });
            // 获取教学班学生数据；
            const responseObjLst3 = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                arrvCurrEduClsObjLst = jsonData;
            });
            //打分表
            const responseObjLst4 = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetObjLstAsync)(strWhereCond4).then((jsonData) => {
                arrSysScoreSummaryObjLst = jsonData;
            });
            //获取标记数据；
            const responseObjLst5 = await (0, clsgs_TagsWApi_js_1.gs_Tags_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                arrgs_TagsObjLst = jsonData;
            });
            var CountTotal = 0;
            var strhtml = "";
            if (arrvCurrEduClsObjLst.length > 0) {
                CountTotal = arrvCurrEduClsObjLst.length; //获取教学班人数
                //循环数据
                for (var i = 0; i < arrvCurrEduClsObjLst.length; i++) {
                    var strStuId = arrvCurrEduClsObjLst[i].stuID;
                    var strStuName = arrvCurrEduClsObjLst[i].stuName;
                    var strid_CurrEduCls = arrvCurrEduClsObjLst[i].id_CurrEduCls;
                    //存放Id
                    $("#hidStuId").val(strStuId);
                    $("#spUserName").html(strStuName);
                    $("#hidid_CurrEduCls").val(strid_CurrEduCls);
                    //strhtml += '<li id="' + strStuId + '" onclick=btnSelectPaper("' + strStuId + '","' + strid_CurrEduCls + '","' + strStuName + '")>';
                    ////默认存放第一条数据显示；
                    ////判断存放的id控件是否为空；
                    //if ($("#hidStuId").val() == "") {
                    //    //存放Id
                    //    $("#hidStuId").val(strStuId);
                    //    $("#hidid_CurrEduCls").val(strid_CurrEduCls);
                    //    strhtml += '<a style="float:left;" href="#" title="' + strStuName + '" class="selected">' + strStuName + '</a>';
                    //}
                    //else {
                    //    strhtml += '<a style="float:left;" href="#" title="' + strStuName + '">' + strStuName + '</a>';
                    //}
                    //strhtml += '<div>';
                    //获取当前用户讨论数据；
                    var qaCount = 0;
                    var arrvqa_AnswerObjLst1 = arrvqa_AnswerObjLst.filter(x => x.updUser == strStuId);
                    if (arrvqa_AnswerObjLst1.length > 0) {
                        qaCount = arrvqa_AnswerObjLst1.length;
                    }
                    //获取当前用户评论数据；
                    var commentCount = 0;
                    var arrSysCommentObjLst1 = arrSysCommentObjLst.filter(x => x.updUser == strStuId);
                    if (arrSysCommentObjLst1.length > 0) {
                        commentCount = arrSysCommentObjLst1.length;
                    }
                    var strqaScore = 0;
                    var strqaDate = "";
                    //获取分数（讨论0041 、评价0042） ，获取相关时间
                    var arrSysScoreSummaryObjLst1 = arrSysScoreSummaryObjLst.find(x => x.userId == strStuId && x.id_CurrEduCls == strid_CurrEduCls && x.scoreTypeId == "0041");
                    if (arrSysScoreSummaryObjLst1 != null) {
                        strqaScore = arrSysScoreSummaryObjLst1.score;
                        strqaDate = arrSysScoreSummaryObjLst1.updDate.substr(2, 8);
                    }
                    //得到讨论名次，通过分数；
                    var qaIndexNumber = 0;
                    var arrSysScoreSummaryObjLst2 = arrSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strid_CurrEduCls && x.scoreTypeId == "0041" && x.score > strqaScore);
                    if (strqaScore == 0) {
                        qaIndexNumber = CountTotal;
                    }
                    else {
                        qaIndexNumber = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var strCommentScore = 0;
                    var strCommentDate = "";
                    var arrSysScoreSummaryObjLst3 = arrSysScoreSummaryObjLst.find(x => x.userId == strStuId && x.id_CurrEduCls == strid_CurrEduCls && x.scoreTypeId == "0042");
                    if (arrSysScoreSummaryObjLst3 != null) {
                        strCommentScore = arrSysScoreSummaryObjLst3.score;
                        strCommentDate = arrSysScoreSummaryObjLst3.updDate.substr(2, 8);
                    }
                    //得到评价名次，通过分数；
                    var CommentIndexNumber = 0;
                    var arrSysScoreSummaryObjLst4 = arrSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strid_CurrEduCls && x.scoreTypeId == "0042" && x.score > strCommentScore);
                    if (strCommentScore == 0) {
                        CommentIndexNumber = CountTotal;
                    }
                    else {
                        CommentIndexNumber = arrSysScoreSummaryObjLst4.length + 1; //加1代表当前排名；
                    }
                    //标记数量
                    var TagCount = 0;
                    var arrgs_TagsObjLst1 = arrgs_TagsObjLst.filter(x => x.updUser == strStuId);
                    if (arrgs_TagsObjLst1.length > 0) {
                        TagCount = arrgs_TagsObjLst1.length;
                    }
                    //标记分数 
                    var strTagScore = 0;
                    var strTagDate = "";
                    var arrSysScoreSummaryObjLst5 = arrSysScoreSummaryObjLst.find(x => x.userId == strStuId && x.id_CurrEduCls == strid_CurrEduCls && x.scoreTypeId == "0045");
                    if (arrSysScoreSummaryObjLst5 != null) {
                        strTagScore = arrSysScoreSummaryObjLst5.score;
                        strTagDate = arrSysScoreSummaryObjLst5.updDate.substr(2, 8);
                    }
                    //标记名次
                    var TagIndexNumber = 0;
                    var arrSysScoreSummaryObjLst6 = arrSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strid_CurrEduCls && x.scoreTypeId == "0045" && x.score > strTagScore);
                    if (strTagScore == 0) {
                        TagIndexNumber = CountTotal;
                    }
                    else {
                        TagIndexNumber = arrSysScoreSummaryObjLst6.length + 1; //加1代表当前排名；
                    }
                    strhtml += '<tr>';
                    strhtml += '<td><button id="' + strStuId + '" onclick=btnSelectPaper("' + strStuId + '","' + strid_CurrEduCls + '","' + strStuName + '")>' + strStuName + '</button></td>';
                    //讨论回复
                    strhtml += '<td>' + qaIndexNumber + '</td>';
                    strhtml += '<td>' + qaCount + '/' + strqaScore + '</td>';
                    strhtml += '<td>' + strqaDate + '</td>';
                    //评论
                    strhtml += '<td>' + CommentIndexNumber + '</td>';
                    strhtml += '<td>' + commentCount + '/' + strCommentScore + '</td>';
                    strhtml += '<td>' + strCommentDate + '</td>';
                    //标记
                    strhtml += '<td>' + TagIndexNumber + '</td>';
                    strhtml += '<td>' + TagCount + '/' + strTagScore + '</td>';
                    strhtml += '<td>' + strTagDate + '</td>';
                    strhtml += '</tr>';
                }
                $("#TreeBind").html(strhtml);
            }
        }
        //绑定讨论
        async Bind_Qa_Answer() {
            //var strListDiv: string = this.mstrListDiv;
            //讨论表
            var arrvqa_AnswerObjLst = [];
            //评价表
            var arrSysCommentObjLst = [];
            //打分表
            var arrSysScoreSummaryObjLst = [];
            var objSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN;
            var strUserId = $("#hidStuId").val();
            var strId_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            //得到讨论表的条件；010203代表属于讨论的类型；
            var strWhereCond3 = " 1=1 and updUser='" + strUserId + "' and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "' And answerTypeId in ('01','02','03') order by updDate desc";
            var strWhereCond4 = " 1=1 and updUser='" + strUserId + "' and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            //var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
            //打分00041 0042 表示讨论打分 和评价打分（教师专属）
            var strWhereCond5 = " 1=1 and userId='" + strUserId + "' And scoreTypeId ='0041' And id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            try {
                //获取讨论数据；
                const responseObjLst1 = await (0, clsvqa_AnswerWApi_js_1.vqa_Answer_GetObjLstAsync)(strWhereCond3).then((jsonData) => {
                    arrvqa_AnswerObjLst = jsonData;
                });
                ////获取评价数据；
                //const responseObjLst2 = await SysComment_GetObjLstAsync(strWhereCond4).then((jsonData) => {
                //    arrSysCommentObjLst = <Array<clsSysCommentEN>>jsonData;
                //});
                const responseTextTopic = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetFirstObjAsync)(strWhereCond5).then((jsonData) => {
                    objSysScoreSummaryEN = jsonData;
                });
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                var intJ = 0;
                //$('#tbList tr').remove();
                strhtml += '<tr cate-id="' + cateid + '" ><td>';
                //strhtml += '<div style="float:left;"><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></div>';
                strhtml += '<div style="float:left;"><h3>讨论数据</h3></div>';
                strhtml += '<div style="float:right;">';
                if (objSysScoreSummaryEN != null) {
                    if (objSysScoreSummaryEN.isSubmit == false) {
                        strhtml += '<a style="float:left;" href="#" onclick=BtnAddOrUpdateScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0041")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="打分" ></i>打分</a>';
                        strhtml += '<a href="#" onclick=BtnSubmitScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0041")><i class="layui-icon layui-icon-list" style="font-size:16px; color: #219167;" title="提交" ></i>提交</a>';
                    }
                    else {
                    }
                }
                else {
                    strhtml += '<a style="float:left;" href="#" onclick=BtnAddOrUpdateScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0041")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="打分" ></i>打分</a>';
                    strhtml += '<a href="#" onclick=BtnSubmitScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0041")><i class="layui-icon layui-icon-list" style="font-size:16px; color: #219167;" title="提交" ></i>提交</a>';
                }
                strhtml += '</div></td></tr>';
                var intK = 0;
                for (var k = 0; k < arrvqa_AnswerObjLst.length; k++) {
                    intK++;
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + intK + '" ><td>';
                    strhtml += '&nbsp;&nbsp;<span class="color3">' + intK + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i>【讨论内容】' + arrvqa_AnswerObjLst[k].answerContent + '';
                    strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="color2"><i class="layui-icon x-show" status="true">&#xe623;</i>【讨论时间】' + arrvqa_AnswerObjLst[k].updDate + '</span>';
                    strhtml += '</td></tr>';
                }
                //}
                $("#tbList").html(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //绑定评价
        async Bind_SysComment() {
            //var strListDiv: string = this.mstrListDiv;
            ////讨论表
            //var arrvqa_AnswerObjLst: Array<clsvqa_AnswerEN> = [];
            //评价表
            var arrSysCommentObjLst = [];
            //打分表
            var arrSysScoreSummaryObjLst = [];
            var objSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN;
            var strUserId = $("#hidStuId").val();
            var strId_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            //得到讨论表的条件；010203代表属于讨论的类型；
            var strWhereCond3 = " 1=1 and updUser='" + strUserId + "' and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "' And answerTypeId in ('01','02','03') order by updDate desc";
            var strWhereCond4 = " 1=1 and updUser='" + strUserId + "' and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "' order by updDate desc";
            //var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
            //打分00041 0042 表示讨论打分 和评价打分（教师专属）
            var strWhereCond5 = " 1=1 and userId='" + strUserId + "' And scoreTypeId ='0042' And id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            try {
                ////获取讨论数据；
                //const responseObjLst1 = await vqa_Answer_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                //    arrvqa_AnswerObjLst = <Array<clsvqa_AnswerEN>>jsonData;
                //});
                //获取评价数据；
                const responseObjLst2 = await (0, clsSysCommentWApi_js_1.SysComment_GetObjLstAsync)(strWhereCond4).then((jsonData) => {
                    arrSysCommentObjLst = jsonData;
                });
                const responseTextTopic = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetFirstObjAsync)(strWhereCond5).then((jsonData) => {
                    objSysScoreSummaryEN = jsonData;
                });
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                var intJ = 0;
                //$('#tbList tr').remove();
                strhtml += '<tr cate-id="' + cateid + '" ><td>';
                //strhtml += '<div style="float:left;"><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></div>';
                strhtml += '<div style="float:left;"><h3>评价数据</h3></div>';
                strhtml += '<div style="float:right;">';
                if (objSysScoreSummaryEN != null) {
                    if (objSysScoreSummaryEN.isSubmit == false) {
                        strhtml += '<a style="float:left;" href="#" onclick=BtnAddOrUpdateScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0042")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="打分" ></i>打分</a>';
                        strhtml += '<a href="#" onclick=BtnSubmitScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0042")><i class="layui-icon layui-icon-list" style="font-size:16px; color: #219167;" title="提交" ></i>提交</a>';
                    }
                    else {
                    }
                }
                else {
                    strhtml += '<a style="float:left;" href="#" onclick=BtnAddOrUpdateScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0042")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="打分" ></i>打分</a>';
                    strhtml += '<a href="#" onclick=BtnSubmitScoreSummary_Click("' + strUserId + '","' + strId_CurrEducls + '","0042")><i class="layui-icon layui-icon-list" style="font-size:16px; color: #219167;" title="提交" ></i>提交</a>';
                }
                strhtml += '</div></td></tr>';
                var intK = 0;
                for (var k = 0; k < arrSysCommentObjLst.length; k++) {
                    intK++;
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + intK + '" ><td>';
                    strhtml += '&nbsp;&nbsp;<span class="color3">' + intK + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i>【评价内容】' + arrSysCommentObjLst[k].comment + '';
                    strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="color2"><i class="layui-icon x-show" status="true">&#xe623;</i>【评价时间】' + arrSysCommentObjLst[k].updDate + '</span>';
                    strhtml += '</td></tr>';
                }
                //}
                $("#tbCommentList").html(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //讨论打分  --评价打分
        async BtnAddOrUpdateScoreSummary_Click(strUserId, strId_CurrEducls, strScoreTypeId) {
            var objSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN;
            //通过条件查询是否存在、存在则取到分数显示到文本框；
            var strWhereCond = " 1=1 And id_CurrEduCls = '" + strId_CurrEducls + "' And userId = '" + strUserId + "' And scoreTypeId = '" + strScoreTypeId + "'";
            const responseTextTopic = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                objSysScoreSummaryEN = jsonData;
                if (objSysScoreSummaryEN != null) {
                    $('#txtScoreName').val(objSysScoreSummaryEN.score);
                }
            });
        }
        //讨论提交 ---//评价提交
        async BtnSubmitScoreSummary_Click(strUserId, strId_CurrEducls, strScoreTypeId) {
            var objSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN;
            //通过条件查询是否存在、存在则取到分数显示到文本框；
            var strWhereCond = " 1=1 And id_CurrEduCls = '" + strId_CurrEducls + "' And userId = '" + strUserId + "' And scoreTypeId = '" + strScoreTypeId + "'";
            const responseTextTopic = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                objSysScoreSummaryEN = jsonData;
            });
            if (objSysScoreSummaryEN != null) {
                var objNewSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN;
                objNewSysScoreSummaryEN.mId = objSysScoreSummaryEN.mId;
                //设置提交状态；
                objNewSysScoreSummaryEN.isSubmit = true;
                objNewSysScoreSummaryEN.sf_UpdFldSetStr = objNewSysScoreSummaryEN.updFldString; //设置哪些字段被修改(脏字段)
                if (objNewSysScoreSummaryEN.mId == 0 || objNewSysScoreSummaryEN.mId == undefined) {
                    throw "关键字不能为空!";
                }
                return new Promise((resolve, reject) => {
                    try {
                        const responseText = (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_UpdateRecordAsync)(objNewSysScoreSummaryEN).then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                //刷新缓存
                                const responseText2 = this.CurrEduClsStuTree();
                                const gvResult2 = this.li_QaCommentScore_Click();
                                layui_Alert(1, "操作成功!");
                                console.log("操作成功！");
                            }
                            else {
                                //刷新缓存
                                //const responseText2 =  this.CurrEduClsStuTree();
                                layui_Alert(1, "操作失败!");
                                console.log("操作失败！");
                            }
                            resolve(jsonData);
                        });
                    }
                    catch (e) {
                        console.error('catch(e)=');
                        console.error(e);
                        var strMsg = `修改记录不成功,${e}.`;
                        alert(strMsg);
                    }
                });
            }
        }
        //打分提交
        async SubmitScore_Click() {
            try {
                var strUserId = $("#hidStuId").val();
                var strUpdUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strnum = $("#hidTabNum").val();
                var objSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN();
                objSysScoreSummaryEN.userId = strUserId;
                objSysScoreSummaryEN.score = $("#txtScoreName").val();
                objSysScoreSummaryEN.id_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                if (strnum == "1") {
                    //讨论
                    objSysScoreSummaryEN.scoreTypeId = "0041";
                }
                if (strnum == "2") {
                    //讨论
                    objSysScoreSummaryEN.scoreTypeId = "0042";
                }
                else {
                    //标志
                    objSysScoreSummaryEN.scoreTypeId = "0045";
                }
                objSysScoreSummaryEN.isSubmit = false;
                objSysScoreSummaryEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
                objSysScoreSummaryEN.updUser = strUpdUser; // 修改用户Id
                const responseText = await (0, clsSysCommentExWApi_js_1.SysCommentEx_AddOrUpdateSysScoreSummaryAsync)(objSysScoreSummaryEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //刷新缓存
                    const responseText2 = await this.CurrEduClsStuTree();
                    layui_Alert(1, "操作成功!");
                    console.log("操作成功！");
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `操作不成功. ${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.CommentScore = CommentScore;
});
