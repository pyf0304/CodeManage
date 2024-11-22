(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js", "../TS/L0_Entity/InteractManage/clsSysVoteEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperDetail = void 0;
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperCollectionLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js");
    const clsPaperDownloadLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsSysCommentEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js");
    const clsSysVoteEN_js_1 = require("../TS/L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperCollectionLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js");
    const clsPaperDownloadLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsSysCommentExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* PaperReadWriteCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class PaperDetail extends PaperCRUD_js_1.PaperCRUD {
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    $("#hidRoleId").val(clsPublocalStorage_js_1.clsPublocalStorage.roleId);
                    $("#bUserName").append(clsPublocalStorage_js_1.clsPublocalStorage.userName);
                    const gvResult1 = await this.IsVote(); //判断是否点赞或者收藏
                    const gvResult2 = await this.IsCollection(); //判断是否点赞或者收藏
                    //this.btnAddViews_Click();
                    const gvResult3 = await this.DetailRecord(); //绑定论文信息
                    const gvResult4 = await this.Bind_ShowAppraise_Click(); //绑定评论
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
        //判断是否点赞或收藏并作出反应
        async IsVote() {
            var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' and tableKey='" + $("#hidPaperId").val() + "' and voteTypeId='01'";
            try {
                const responseText = await (0, clsSysVoteWApi_js_1.SysVote_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    //var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                    //alert(strMsg);
                    $("#imgVotet").attr("src", "../img/vote2.png");
                    //return responseText;//一定要有一个返回值，否则会出错！
                }
                else {
                    $("#imgVotet").attr("src", "../img/vote.png");
                }
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        async IsCollection() {
            var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' and paperId=" + $("#hidPaperId").val();
            try {
                const responseText2 = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText2;
                if (bolIsExist == true) {
                    $("#imgCollection").attr("src", "../img/collection2.png");
                    //var strMsg: string = `您已经收藏过这条论文了！`;
                    //alert(strMsg);
                    //return responseText2;//一定要有一个返回值，否则会出错！
                }
                else {
                    $("#imgCollection").attr("src", "../img/collection.png");
                }
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
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
        async GetReadWriteData(pobjvPaperEN) {
            if (pobjvPaperEN.attachmentCount > 0) {
                $("#btnDownLoadFile").show();
                $("#lblDownLoadFile").hide();
            }
            else {
                $("#btnDownLoadFile").hide();
                $("#lblDownLoadFile").show();
            }
            //判断引用论文，自研论文
            if (pobjvPaperEN.paperTypeId == "02") {
                var strPaperTitle = pobjvPaperEN.paperTitle;
                $("#txtPaperTitle").html(strPaperTitle); //论文标题
            }
            else {
                $("#txtPaperTitle").html(pobjvPaperEN.paperTitle); //论文标题
            }
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            $("#txtKeyword").html(pobjvPaperEN.keyword); //关键字Id
            $("#txtPeriodical").html(pobjvPaperEN.periodical); //
            $("#txtAuthor").html(pobjvPaperEN.author); //作者
            $("#txtResearchQuestion").html(pobjvPaperEN.researchQuestion); //研究问题
            $("#txtPaperContent").html(pobjvPaperEN.paperContent); //论文内容
            $("#lblUpdDate").text(pobjvPaperEN.updDate); //编辑时间
            var objUser = arrUsers.find(x => x.userId == pobjvPaperEN.updUser);
            if (objUser != null) {
                $("#lblUpdUser").text(objUser.userName); //编辑用户
            }
            $("#hidPaperUserId").val(pobjvPaperEN.updUser); //编辑用户
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
                objPaperEN.SetBrowseNumber(1);
            }
            else {
                objPaperEN.SetBrowseNumber(intBrowseNum + 1);
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
        //添加点赞
        async btnAddVote_Click() {
            const strThisFuncName = this.btnAddVote_Click.name;
            //this.DivName = "divAddNewRecordSave";
            var objSysVoteEN = new clsSysVoteEN_js_1.clsSysVoteEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objSysVoteEN.SetTableKey($("#hidPaperId").val());
            objSysVoteEN.SetVoteTypeId("01");
            objSysVoteEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objSysVoteEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            objSysVoteEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' and tableKey=" + $("#hidPaperId").val();
            try {
                const responseText = await (0, clsSysVoteWApi_js_1.SysVote_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsSysVoteWApi_js_1.SysVote_AddNewRecordAsync)(objSysVoteEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and voteTypeId='01' and tableKey=" + $("#hidPaperId").val();
                    var intVoteCount = await (0, clsSysVoteWApi_js_1.SysVote_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                    objPaperEN.SetPaperId($("#hidPaperId").val());
                    objPaperEN.SetOkCount(intVoteCount);
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            this.IsVote(); //判断是否点赞或者收藏
                        }
                        else {
                            var strInfo = `点赞不成功!`;
                            alert(strInfo);
                            console.log("点赞不成功");
                        }
                    });
                }
                else {
                    var strInfo = `点赞不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `点赞不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //添加收藏
        async btnAddCollection_Click() {
            const strThisFuncName = this.btnAddCollection_Click.name;
            //this.DivName = "divAddNewRecordSave";
            var objPaperCollectionLogEN = new clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperCollectionLogEN.SetPaperId($("#hidPaperId").val());
            objPaperCollectionLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objPaperCollectionLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            var strWhereCond = " 1 =1 and updUser='" + objPaperCollectionLogEN.updUser + "' and paperId=" + objPaperCollectionLogEN.paperId;
            try {
                const responseText = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经收藏过这条论文了！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_AddNewRecordAsync)(objPaperCollectionLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " paperId=" + $("#hidPaperId").val();
                    var intCollectionCount = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                    objPaperEN.SetPaperId($("#hidPaperId").val());
                    objPaperEN.SetCollectionCount(intCollectionCount);
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            this.IsCollection();
                        }
                        else {
                            var strInfo = `收藏不成功!`;
                            alert(strInfo);
                            console.log("收藏不成功");
                        }
                    });
                }
                else {
                    var strInfo = `收藏不成功!`;
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
                var strMsg = `收藏不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //     var objSysCommentEN: clsSysCommentEN = new clsSysCommentEN();
        //this.PutDataToSysCommentClass(objSysCommentEN);
        //try {
        //    const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN);
        //添加评论
        async SubmitAppraise1_Click() {
            this.divName4Layout = "divAddNewRecordSave";
            var objSysCommentEN = new clsSysCommentEN_js_1.clsSysCommentEN();
            //this.PutDataToSysCommentClass(objSysCommentEN);
            objSysCommentEN.SetTableKey($("#hidPaperId").val());
            objSysCommentEN.SetCommentTypeId("01");
            objSysCommentEN.SetParentId($("#hidParentId").val());
            if ($("#hidRoleId").val() == "00620003") {
                objSysCommentEN.SetScoreType("1");
            }
            else {
                objSysCommentEN.SetScoreType("2");
                objSysCommentEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            var strvalue = $("#pin1").val();
            //判断是否有打分 
            if (strvalue != "" && strvalue != undefined) {
                //获取值转化分数
                var strScore = this.GetScorebyText(strvalue);
                //判断内容是否输入
                if ($("#txtAppraiseContent").val() != "") {
                    objSysCommentEN.SetComment($("#txtAppraiseContent").val()); // 评议内容
                    objSysCommentEN.SetScore(parseInt(strScore)); // 打分
                    objSysCommentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
                    objSysCommentEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
                    try {
                        const responseText2 = await (0, clsSysCommentExWApi_js_1.SysCommentEx_AddNewRecordExAsync)(objSysCommentEN);
                        //const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN);
                        var returnBool = !!responseText2;
                        if (returnBool == true) {
                            //var strInfo: string = `添加评论成功!`;
                            //$('#lblResult40').val(strInfo);
                            ////显示信息框
                            //alert(strInfo);
                            AlertOK();
                            this.Bind_ShowAppraise_Click();
                            //HideDialog3();
                            //this.BindGv_vPaperSubViewpoint();
                            //this.btnShowAppraise_Click();
                        }
                        else {
                            var strInfo = `添加评论不成功!`;
                            $('#lblResult40').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            this.Bind_ShowAppraise_Click();
                            //HideDialog3();
                            //this.BindGv_vPaperSubViewpoint();
                            //this.btnShowAppraise_Click();
                        }
                        $("#J_PostBtn").attr("disabled", false);
                        $("#btnOKUpdAppraise").attr("disabled", false);
                        return responseText2; //一定要有一个返回值，否则会出错！
                    }
                    catch (e) {
                        $("#J_PostBtn").attr("disabled", false);
                        $("#btnOKUpdAppraise").attr("disabled", false);
                        console.error('catch(e)=');
                        console.error(e);
                        var strMsg = `添加评论不成功,${e}.`;
                        alert(strMsg);
                    }
                }
                else {
                    $("#J_PostBtn").attr("disabled", false);
                    $("#btnOKUpdAppraise").attr("disabled", false);
                    //var strInfo: string = `请输入评语!`;
                    ////显示信息框
                    //alert(strInfo);
                    AlertComment();
                    return;
                }
            }
            else {
                $("#J_PostBtn").attr("disabled", false);
                $("#btnOKUpdAppraise").attr("disabled", false);
                //var strInfo: string = `请选择评分!`;
                ////显示信息框
                //alert(strInfo);
                AlertScore();
                return;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //回复评论
        async SubmitAppraise2_Click() {
            this.divName4Layout = "divAddNewRecordSave";
            var objSysCommentEN = new clsSysCommentEN_js_1.clsSysCommentEN();
            //this.PutDataToSysCommentClass(objSysCommentEN);
            objSysCommentEN.SetTableKey($("#hidPaperId").val());
            objSysCommentEN.SetCommentTypeId("01");
            objSysCommentEN.SetParentId($("#hidParentId").val());
            if ($("#hidRoleId").val() == "00620003") {
                objSysCommentEN.SetScoreType("1");
            }
            else {
                objSysCommentEN.SetScoreType("2");
                objSysCommentEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            var strvalue = $("#pin2").val();
            //判断是否有打分 
            if (strvalue != "" && strvalue != undefined) {
                //获取值转化分数
                var strScore = this.GetScorebyText(strvalue);
                //判断内容是否输入
                if ($("#txtAppraiseContent2").val() != "") {
                    objSysCommentEN.SetComment($("#txtAppraiseContent2").val()); // 评议内容
                    objSysCommentEN.SetScore(parseInt(strScore)); // 打分
                    objSysCommentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
                    objSysCommentEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
                    try {
                        const responseText2 = await (0, clsSysCommentExWApi_js_1.SysCommentEx_AddNewRecordExAsync)(objSysCommentEN);
                        //const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN);
                        var returnBool = !!responseText2;
                        if (returnBool == true) {
                            var strInfo = `回复评论成功!`;
                            $('#lblResult40').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            this.Bind_ShowAppraise_Click();
                            HideDialog();
                            //HideDialog3();
                            //this.BindGv_vPaperSubViewpoint();
                            //this.btnShowAppraise_Click();
                        }
                        else {
                            var strInfo = `回复评论不成功!`;
                            $('#lblResult40').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            this.Bind_ShowAppraise_Click();
                            HideDialog();
                            //HideDialog3();
                            //this.BindGv_vPaperSubViewpoint();
                            //this.btnShowAppraise_Click();
                        }
                        $("#btnOKUpdAppraise").attr("disabled", false);
                        return responseText2; //一定要有一个返回值，否则会出错！
                    }
                    catch (e) {
                        $("#btnOKUpdAppraise").attr("disabled", false);
                        console.error('catch(e)=');
                        console.error(e);
                        var strMsg = `添加评论不成功,${e}.`;
                        alert(strMsg);
                    }
                }
                else {
                    $("#btnOKUpdAppraise").attr("disabled", false);
                    var strInfo = `请输入评语!`;
                    //显示信息框
                    alert(strInfo);
                    return;
                }
            }
            else {
                $("#btnOKUpdAppraise").attr("disabled", false);
                var strInfo = `请选择评分!`;
                //显示信息框
                alert(strInfo);
                return;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
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
        /*
        删除评论内容
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
       */
        async btnDeleteComment_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelRecord(strKeyId);
                const response1 = await this.Bind_ShowAppraise_Click();
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
        async DelRecord_pyf(strCommentId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSysCommentExWApi_js_1.SysCommentEx_DelRecordAsync)(strCommentId).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            AlertNo();
                            //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                        }
                        else {
                            var strInfo = `删除记录不成功!`;
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
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
        }
        //显示评论
        async Bind_ShowAppraise_Click() {
            var arrvSysCommentObjLst1 = [];
            var arrvSysCommentObjLst2 = [];
            var arrvSysCommentObjLst3 = [];
            var strWhereCond1 = "";
            var strWhereCond2 = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            if ($('#hidOrderbyId').val() == "1") {
                //全部评论
                strWhereCond1 = " parentId='root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' order by updDate Asc";
                strWhereCond2 = " parentId<>'root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "2") {
                //个人评论
                strWhereCond1 = " parentId='root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
                strWhereCond2 = " parentId<>'root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            }
            else if ($('#hidOrderbyId').val() == "3") {
                //最新评论
                strWhereCond1 = " parentId='root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' order by updDate Desc";
                strWhereCond2 = " parentId<>'root' and  commentTypeId='01' and tableKey='" + $("#hidPaperId").val() + "' order by updDate Desc";
            }
            try {
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const responseText1 = await (0, clsvSysCommentWApi_js_1.vSysComment_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                    arrvSysCommentObjLst1 = jsonData;
                });
                const responseText2 = await (0, clsvSysCommentWApi_js_1.vSysComment_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrvSysCommentObjLst2 = jsonData;
                });
                var strhtml = "";
                var varNum = 0;
                $('#J_ShortComment div').remove();
                for (var i = 0; i < arrvSysCommentObjLst1.length; i++) {
                    varNum++;
                    strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                    strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                    var strUserName = "";
                    var objUser = arrUsers.find(x => x.userId == arrvSysCommentObjLst1[i].updUser);
                    if (objUser != null) {
                        strUserName = objUser.userName;
                    }
                    if ($("#hidPaperUserId").val() == arrvSysCommentObjLst1[i].updUser) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842 style="color:red;" > 楼主：' + strUserName + '</span>';
                    }
                    else {
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
                            var strUserName = "";
                            var objUser = arrUsers.find(x => x.userId == arrvSysCommentObjLst3[j].updUser);
                            if (objUser != null) {
                                strUserName = objUser.userName;
                            }
                            if ($("#hidPaperUserId").val() == arrvSysCommentObjLst3[j].updUser) {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328" style="color:red;"> 楼主(' + strUserName + ')</b>：</span>';
                            }
                            else {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328">' + strUserName + '</b>：</span>';
                            }
                            strhtml += '' + arrvSysCommentObjLst3[j].comment + '</div>';
                            strhtml += '<div class="reply-operate reply-operate--hot">';
                            if (arrvSysCommentObjLst3[j].scoreType == "2") {
                                strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分：<i>' + arrvSysCommentObjLst3[j].score + '</i></span>';
                            }
                            else {
                                strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分：<i>' + arrvSysCommentObjLst3[j].score + '</i></span>';
                            }
                            strhtml += '<i class="reply-dot">·</i><span>' + arrvSysCommentObjLst3[j].updDate + '</span>';
                            strhtml += '</div>';
                            strhtml += '</div>';
                        }
                        strhtml += '</div>';
                    }
                    ///操作区
                    strhtml += '<div class="comment-operate J_CommentOperate clearfix">';
                    if (arrvSysCommentObjLst1[i].scoreType == "2") {
                        strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分：<i>' + arrvSysCommentObjLst1[i].score + '</i></span>';
                    }
                    else {
                        strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分：<i>' + arrvSysCommentObjLst1[i].score + '</i></span>';
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
                var strMsg = `获取数据不成功,${e}.`;
                alert(strMsg);
            }
        }
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
            const strThisFuncName = this.btnAddDownload_Click.name;
            //this.DivName = "divAddNewRecordSave";
            var objPaperDownloadLogEN = new clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperDownloadLogEN.SetPaperId($("#hidPaperId").val());
            objPaperDownloadLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objPaperDownloadLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + objPaperDownloadLogEN.paperId;
            try {
                //const responseText = await PaperDownloadLog_IsExistRecordAsync(strWhereCond);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    //var strMsg: string = `您已经收藏过这条论文了！`;
                //    //alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_AddNewRecordAsync)(objPaperDownloadLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " paperId=" + $("#hidPaperId").val();
                    var intDownloadCount = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                    objPaperEN.SetPaperId($("#hidPaperId").val());
                    objPaperEN.SetDownloadCount(intDownloadCount);
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                        }
                        else {
                            var strInfo = `添加下载量不成功!`;
                            alert(strInfo);
                            console.log("添加下载量不成功");
                        }
                    });
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
    exports.PaperDetail = PaperDetail;
});
