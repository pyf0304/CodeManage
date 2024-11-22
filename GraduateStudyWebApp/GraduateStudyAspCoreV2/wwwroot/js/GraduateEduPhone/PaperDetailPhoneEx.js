(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/stuUserLoginInfo.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperDetailPhoneEx = void 0;
    const stuUserLoginInfo_js_1 = require("../TS/FunClass/stuUserLoginInfo.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperDownloadLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperDownloadLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* PaperReadWriteCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class PaperDetailPhoneEx extends PaperCRUD_js_1.PaperCRUD {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.recCount = 0;
        }
        //public objPager: clsPager = new clsPager();
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /*
        //根据ID得到论文读写表数据
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
     */
        async btnDetailRecord_Click() {
            try {
                if ($("#hidUserInfo").val() != "") {
                    var strUserInfo_Hid = $("#hidUserInfo").val();
                    var objvUserRoleRelation;
                    objvUserRoleRelation = stuUserLoginInfo_js_1.stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
                    //$('#lnkUserName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
                    $("#hidUserId").val(objvUserRoleRelation.userId);
                    $("#bUserName").append(objvUserRoleRelation.userName);
                    //this.btnAddViews_Click();
                    const gvResult2 = await this.DetailRecord(); //绑定论文信息
                    //const gvResult1 = await this.IsVoteCollection();//判断是否点赞或者收藏
                    // const gvResult3 = await this.Bind_ShowAppraise_Click();//绑定评论
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../WebApp/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //判断是否点赞或收藏并作出反应
        //public async IsVoteCollection() {
        //    var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage.userId + "' and paperId=" + $("#hidPaperId").val();
        //    try {
        //        const responseText = await PaperLikeLog_IsExistRecordAsync(strWhereCond);
        //        var bolIsExist: boolean = responseText;
        //        if (bolIsExist == true) {
        //            //var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
        //            //alert(strMsg);
        //            $("#imgVotet").attr("src", "../img/vote2.png");
        //            //return responseText;//一定要有一个返回值，否则会出错！
        //        }
        //        else {
        //            $("#imgVotet").attr("src", "../img/vote.png");
        //        }
        //        const responseText2 = await PaperCollectionLog_IsExistRecordAsync(strWhereCond);
        //        var bolIsExist: boolean = responseText2;
        //        if (bolIsExist == true) {
        //            $("#imgCollection").attr("src", "../img/collection2.png");
        //            //var strMsg: string = `您已经收藏过这条论文了！`;
        //            //alert(strMsg);
        //            //return responseText2;//一定要有一个返回值，否则会出错！
        //        }
        //        else {
        //            $("#imgCollection").attr("src", "../img/collection.png");
        //        }
        //    }
        //    catch (e) {
        //        console.error(e);
        //        var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /* 根据关键字获取相应的记录的对象
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
       <param name = "sender">参数列表</param>
     */
        async DetailRecord() {
            const strThisFuncName = this.DetailRecord.name;
            //this.keyId = strPaperRWId;
            var strWhereCond = await this.CombinevPaperReadWriteCondition();
            try {
                const objvPaperEN = await (0, clsPaperWApi_js_1.Paper_GetFirstObjAsync)(strWhereCond);
                if (objvPaperEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                this.GetReadWriteData(objvPaperEN);
                console.log("完成Detail!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面上
       注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        如果在设置数据库时,就应该一级字段在前,二级字段在后
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        <param name = "pobjPaperReadWriteEN">表实体类对象</param>
      */
        GetReadWriteData(pobjvPaperEN) {
            //if (pobjvPaperEN.attachmentCount > 0) {
            //    $("#btnDownLoadFile").show();
            //    $("#lblDownLoadFile").hide();
            //} else {
            //    $("#btnDownLoadFile").hide();
            //    $("#lblDownLoadFile").show();
            //}
            $("#txtPaperTitle").html(pobjvPaperEN.paperTitle); //论文标题
            $("#txtKeyword").html(pobjvPaperEN.keyword); //关键字Id
            $("#txtPeriodical").html(pobjvPaperEN.periodical); //
            $("#txtAuthor").html(pobjvPaperEN.author); //作者
            $("#txtResearchQuestion").html(pobjvPaperEN.researchQuestion); //研究问题
            $("#txtPaperContent").html(pobjvPaperEN.paperContent); //论文内容
            $("#lblUpdDate").text(pobjvPaperEN.updDate); //编辑时间
            $("#lblOKCount").text(pobjvPaperEN.okCount); //点赞数量
            $("#lblViews").text(pobjvPaperEN.browseNumber); //浏览量
            $("#lblViews").val(pobjvPaperEN.browseNumber); //浏览量
            if (pobjvPaperEN.score != null) {
                $("#lblScore").text(pobjvPaperEN.score); //统计平均评分
            }
            else {
                $("#lblScore").text(0); //统计平均评分
            }
            this.btnAddBrowseNumber_Click();
            //$("#txtMemo").html(pobjvPaperEN.memo);//备注
        }
        //  /* 根据条件获取相应的记录对象的列表
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
        //*/
        //  public async BindGv_vPaperReadWrite() {
        //      var strListDiv: string = this.mstrListDiv;
        //      var strWhereCond = await this.CombinevPaperReadWriteCondition();
        //      var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //      var arrvPaperReadWriteObjLst: Array<clsvPaperReadWriteEN> = [];
        //      try {
        //          this.recCount = await vPaperReadWrite_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //          });
        //          var objPagerPara: stuPagerPara = {
        //              pageIndex: intCurrPageIndex,
        //              pageSize: this.pageSize,
        //              whereCond: strWhereCond,
        //              orderBy: this.hidSortvPaperReadWriteBy
        //          };
        //          const responseObjLst = await vPaperReadWrite_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //              arrvPaperReadWriteObjLst = <Array<clsvPaperReadWriteEN>>jsonData;
        //          });
        //      }
        //      catch (e) {
        //          console.error('catch(e)=');
        //          console.error(e);
        //          var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //          alert(strMsg);
        //      }
        //      if (arrvPaperReadWriteObjLst.length == 0) {
        //          var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //          alert(strMsg);
        //          return;
        //      }
        //  }
        /* 把所有的查询控件内容组合成一个条件串
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
          <returns>条件串(strWhereCond)</returns>
        */
        async CombinevPaperReadWriteCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperId = $("#hidPaperId").val();
            //var strUserId = clsPublocalStorage.userId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                strWhereCond += " And paperId = '" + strPaperId + "'";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //添加论文浏览量
        async btnAddBrowseNumber_Click() {
            const strThisFuncName = this.btnAddBrowseNumber_Click.name;
            //
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId($("#hidPaperId").val());
            var intBrowseNum = parseInt($("#lblViews").val());
            if (intBrowseNum == null && intBrowseNum == 0 && intBrowseNum == "") {
                objPaperEN.browseNumber = 1;
            }
            else {
                objPaperEN.browseNumber = intBrowseNum + 1;
            }
            objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        //var strInfo: string = `论文审核成功!`;
                        //$('#lblResult44').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                        //HideDialog();
                        //this.BindGv_vPaper();
                        //this.DetailRecord();
                    }
                    else {
                        var strInfo = `不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("增加浏览量失败");
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
            }
        }
        //添加收藏
        //public async btnAddCollection_Click() {
        //    //this.DivName = "divAddNewRecordSave";
        //    var objPaperCollectionLogEN: clsPaperCollectionLogEN = new clsPaperCollectionLogEN();
        //    //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        //    objPaperCollectionLogEN.SetPaperId($("#hidPaperId").val();
        //    objPaperCollectionLogEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
        //    objPaperCollectionLogEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
        //    var strWhereCond = " 1 =1 and updUser='" + objPaperCollectionLogEN.updUser + "' and paperId=" + objPaperCollectionLogEN.paperId;
        //    try {
        //        const responseText = await PaperCollectionLog_IsExistRecordAsync(strWhereCond);
        //        var bolIsExist: boolean = responseText;
        //        if (bolIsExist == true) {
        //            var strMsg: string = `您已经收藏过这条论文了！`;
        //            alert(strMsg);
        //            return responseText;//一定要有一个返回值，否则会出错！
        //        }
        //        const responseText2 = await PaperCollectionLog_AddNewRecordAsync(objPaperCollectionLogEN);
        //        var returnBool: boolean = !!responseText2;
        //        if (returnBool == true) {
        //            //var strInfo: string = `收藏成功!`;
        //            //$('#lblResult40').val(strInfo);
        //            ////显示信息框
        //            //alert(strInfo);
        //            this.IsVoteCollection();
        //            //this.BindGv_vPaperSubViewpoint();
        //        }
        //        else {
        //            var strInfo: string = `收藏不成功!`;
        //            $('#lblResult40').val(strInfo);
        //            //显示信息框
        //            alert(strInfo);
        //            //this.BindGv_vPaperSubViewpoint();
        //        }
        //        return responseText2;//一定要有一个返回值，否则会出错！
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `收藏不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    return true;//一定要有一个返回值，否则会出错！
        //}
        ////添加评论
        //public async SubmitAppraise_Click() {
        //    this.DivName = "divAddNewRecordSave";
        //    var objPaperAppraiseEN: clsPaperAppraiseEN = new clsPaperAppraiseEN();
        //    //this.PutDataToPaperAppraiseClass(objPaperAppraiseEN);
        //    objPaperAppraiseEN.SetPaperId($("#hidPaperId").val();
        //    var strvalue = $("#pin").val();
        //    //判断是否有打分 
        //    if (strvalue != "" && strvalue != undefined) {
        //        //获取值转化分数
        //        var strScore: string = this.GetScorebyText(strvalue);
        //        //判断内容是否输入
        //        if ($("#txtAppraiseContent").val() != "") {
        //            objPaperAppraiseEN.PaperAppraiseContent = $("#txtAppraiseContent").val();// 评议内容
        //            objPaperAppraiseEN.AppraiseScore = parseInt(strScore);// 打分
        //            objPaperAppraiseEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
        //            objPaperAppraiseEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
        //            try {
        //                const responseText2 = await PaperAppraise_AddNewRecordAsync(objPaperAppraiseEN);
        //                var returnBool: boolean = !!responseText2;
        //                if (returnBool == true) {
        //                    var strInfo: string = `添加评论成功!`;
        //                    $('#lblResult40').val(strInfo);
        //                    //显示信息框
        //                    alert(strInfo);
        //                    this.Bind_ShowAppraise_Click();
        //                    //HideDialog3();
        //                    //this.BindGv_vPaperSubViewpoint();
        //                    //this.btnShowAppraise_Click();
        //                }
        //                else {
        //                    var strInfo: string = `添加评论不成功!`;
        //                    $('#lblResult40').val(strInfo);
        //                    //显示信息框
        //                    alert(strInfo);
        //                    this.Bind_ShowAppraise_Click();
        //                    //HideDialog3();
        //                    //this.BindGv_vPaperSubViewpoint();
        //                    //this.btnShowAppraise_Click();
        //                }
        //                return responseText2;//一定要有一个返回值，否则会出错！
        //            }
        //            catch (e) {
        //                console.error('catch(e)=');
        //                console.error(e);
        //                var strMsg: string = `添加评论不成功,${e}.`;
        //                alert(strMsg);
        //            }
        //        }
        //        else {
        //            var strInfo: string = `请输入评语!`;
        //            //显示信息框
        //            alert(strInfo);
        //            return;
        //        }
        //    }
        //    else {
        //        var strInfo: string = `请选择评分!`;
        //        //显示信息框
        //        alert(strInfo);
        //        return;
        //    }
        //    return true;//一定要有一个返回值，否则会出错！
        //}
        //添加评论
        //public async SubmitAppraise_Click() {
        //    this.DivName = "divAddNewRecordSave";
        //    var objPaperAppraiseEN: clsPaperAppraiseEN = new clsPaperAppraiseEN();
        //    //this.PutDataToPaperAppraiseClass(objPaperAppraiseEN);
        //    objPaperAppraiseEN.SetPaperId($("#hidPaperId").val();
        //    var strvalue = $("#pin").val();
        //    //判断是否有打分 
        //    if (strvalue != "" && strvalue != undefined) {
        //        //获取值转化分数
        //        var strScore: string = this.GetScorebyText(strvalue);
        //        //判断内容是否输入
        //        if ($("#txtAppraiseContent").val() != "") {
        //            objPaperAppraiseEN.PaperAppraiseContent = $("#txtAppraiseContent").val();// 评议内容
        //            objPaperAppraiseEN.AppraiseScore = parseInt(strScore);// 打分
        //            //objPaperAppraiseEN.AppraiseScore = 10;// 打分
        //            objPaperAppraiseEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
        //            objPaperAppraiseEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
        //            try {
        //                const responseText2 = await PaperAppraise_AddNewRecordAsync(objPaperAppraiseEN);
        //                var returnBool: boolean = !!responseText2;
        //                if (returnBool == true) {
        //                    var strInfo: string = `添加评论成功!`;
        //                    $('#lblResult40').val(strInfo);
        //                    //显示信息框
        //                    alert(strInfo);
        //                    this.Bind_ShowAppraise_Click();
        //                    //HideDialog3();
        //                    //this.BindGv_vPaperSubViewpoint();
        //                    //this.btnShowAppraise_Click();
        //                }
        //                else {
        //                    var strInfo: string = `添加评论不成功!`;
        //                    $('#lblResult40').val(strInfo);
        //                    //显示信息框
        //                    alert(strInfo);
        //                    this.Bind_ShowAppraise_Click();
        //                    //HideDialog3();
        //                    //this.BindGv_vPaperSubViewpoint();
        //                    //this.btnShowAppraise_Click();
        //                }
        //                return responseText2;//一定要有一个返回值，否则会出错！
        //            }
        //            catch (e) {
        //                console.error('catch(e)=');
        //                console.error(e);
        //                var strMsg: string = `添加评论不成功,${e}.`;
        //                alert(strMsg);
        //            }
        //        }
        //        else {
        //            var strInfo: string = `请输入评语!`;
        //            //显示信息框
        //            alert(strInfo);
        //            return;
        //        }
        //    }
        //    else {
        //        var strInfo: string = `请选择评分!`;
        //        //显示信息框
        //        alert(strInfo);
        //        return;
        //    }
        //    return true;//一定要有一个返回值，否则会出错！
        //}
        //通过得到的值判断，得到分数
        GetScorebyText(sValue) {
            var Score = "";
            if (sValue == "1") {
                Score = "2";
            }
            else if (sValue == "2") {
                Score = "4";
            }
            else if (sValue == "3") {
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
        //显示评论
        //public async Bind_ShowAppraise_Click() {
        //    var arrvPaperAppraiseObjLst: Array<clsvPaperAppraiseEN> = [];
        //    var strWhereCond = " paperId=" + $("#hidPaperId").val() + " order by updDate Desc";
        //    try {
        //        const responseText = vPaperAppraise_GetObjLstAsync(strWhereCond).then((jsonData) => {
        //            arrvPaperAppraiseObjLst = <Array<clsvPaperAppraiseEN>>jsonData;
        //            var strhtml = "";
        //            $('#ulPinglun li').remove();
        //            for (var i = 0; i < arrvPaperAppraiseObjLst.length; i++) {
        //                strhtml += '<li class="gitment-comment" ><a class="gitment-comment-avatar" ><img class="gitment-comment-avatar-img" src = "../img/avatar5.png" ></a>';
        //                strhtml += '<div class="gitment-comment-main"><div class="gitment-comment-header">';
        //                strhtml += '<a class="gitment-comment-name" >' + arrvPaperAppraiseObjLst[i].userName + '</a>';
        //                strhtml += '<span>' + arrvPaperAppraiseObjLst[i].updDate + '</span></div>';
        //                strhtml += '<div class="gitment-comment-body gitment-markdown"><p>' + arrvPaperAppraiseObjLst[i].PaperAppraiseContent + '</p></div></div></li>';
        //            }
        //            $("#ulPinglun").append(strhtml);
        //            //$('#J_ShortComment div').remove();
        //            //for (var i = 0; i < arrvPaperAppraiseObjLst.length; i++) {
        //            //    //strhtml += '<tr><td>' + cateid + '</td><td>' + arrvPaperAppraiseObjLst[i].AppraiseContent + '</td><td>' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</td><td>' + arrvPaperAppraiseObjLst[i].userName + '</td><td>' + arrvPaperAppraiseObjLst[i].updDate + '</td><td class="td-manage"></td></tr>';
        //            //    strhtml += '<div class="comment" id = "J_Comment6631028263006567418"><div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div><div class="comment-block" id="J_CommentBlock6631028263006567418"><p class="comment-user" >';
        //            //    strhtml += '<span class="comment-username J_User" data-userid="17755842">' + arrvPaperAppraiseObjLst[i].userName + '</span>';
        //            //    strhtml += '<span class="comment-time">' + arrvPaperAppraiseObjLst[i].updDate + '</span></p>';
        //            //    strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
        //            //    strhtml += '<div class="comment-content J_CommentContent">' + arrvPaperAppraiseObjLst[i].PaperAppraiseContent + '</div></div></div>';
        //            //}
        //            //$("#J_ShortComment").append(strhtml);
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `获取数据不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //下载文件
        btnDownLoadFile_Click() {
            this.GetPaperAttachmentRecord();
            this.btnAddDownload_Click();
        }
        GetPaperAttachmentRecord() {
            var strPapeId = $("#hidPaperId").val();
            //this.keyId = strPaperRWId;
            var strWhereCond = ` ${clsPaperAttachmentEN_js_1.clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
            var arrPaperAttachmentObjLst = [];
            try {
                const responseText = (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrPaperAttachmentObjLst = jsonData;
                    for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {
                        var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                        doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
                    }
                });
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        //添加下载量
        async btnAddDownload_Click() {
            //this.DivName = "divAddNewRecordSave";
            var objPaperDownloadLogEN = new clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperDownloadLogEN.SetPaperId($("#hidPaperId").val());
            objPaperDownloadLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objPaperDownloadLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + objPaperDownloadLogEN.paperId;
            try {
                const responseText2 = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_AddNewRecordAsync)(objPaperDownloadLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //var strInfo: string = `收藏成功!`;
                    //$('#lblResult40').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                else {
                    var strInfo = `添加下载量不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加下载量不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /*
       * 获取当前页序号
      */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 论文标题
       */
        set paperTitle(value) {
            $("#txtPaperTitle").val(value);
        }
        /*
        * 论文标题
       */
        get paperTitle() {
            return $("#txtPaperTitle").val();
        }
        /*
        * 论文标题
       */
        get paperTitle_q() {
            return $("#txtPaperTitle_q").val();
        }
        /*
        * 期刊
       */
        set periodical(value) {
            $("#txtPeriodical").val(value);
        }
        /*
        * 期刊
       */
        get periodical() {
            return $("#txtPeriodical").val();
        }
        /*
        * 引用Id
       */
        set quoteId(value) {
            $("#txtQuoteId").val(value);
        }
        /*
        * 引用Id
       */
        get quoteId() {
            return $("#txtQuoteId").val();
        }
        /*
        * 研究问题
       */
        set researchQuestion(value) {
            $("#txtResearchQuestion").val(value);
        }
        /*
        * 研究问题
       */
        get researchQuestion() {
            return $("#txtResearchQuestion").val();
        }
        /*
        * 备注
       */
        set memo(value) {
            $("#txtMemo").val(value);
        }
        /*
        * 备注
       */
        get memo() {
            return $("#txtMemo").val();
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set opType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 主题内容
       */
        set paperContent(value) {
            $("#txtPaperContent").val(value);
        }
        /*
        * 主题内容
       */
        get paperContent() {
            return $("#txtPaperContent").val();
        }
        /*
        * 关键字
       */
        set keyword(value) {
            $("#txtKeyword").val(value);
        }
        /*
        * 关键字
       */
        get keyword() {
            return $("#txtKeyword").val();
        }
        /*
       * 作者
      */
        set author(value) {
            $("#txtAuthor").val(value);
        }
        /*
        * 作者
       */
        get author() {
            return $("#txtAuthor").val();
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
    }
    exports.PaperDetailPhoneEx = PaperDetailPhoneEx;
});
