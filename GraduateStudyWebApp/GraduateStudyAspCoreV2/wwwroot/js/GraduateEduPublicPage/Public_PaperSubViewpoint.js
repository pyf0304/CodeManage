(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaENEx.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduTopic/clsvRTPaperRelaExWApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Public_PaperSubViewpoint = void 0;
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsvPaperSubViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js");
    const clsvRTPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js");
    const clsvRTPaperRelaENEx_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaENEx.js");
    const clsvRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsPaperSubAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsvRTPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js");
    const clsvRTUserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsSubViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsvRTPaperRelaExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTopic/clsvRTPaperRelaExWApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Public_PaperSubViewpoint extends PaperCRUD_js_1.PaperCRUD {
        constructor() {
            super(...arguments);
            this.mstrListDivPaper = "divTopicPaperDataLst";
        }
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    this.divName4Pager = "";
                    this.hidSortvRTPaperRelaBy = "updDate Desc";
                    //  var strPaperId = $("#hidPaperId").val();
                    // const gvResult2 = await this.Bind_PaperSubViewpoint();
                    //const gvResult3 = await this.Bind_PaperQA();
                    //  $("#divLoading").hide();
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
        //////////////////////////////////////论文子观点//////////////////////////////////////
        //论文子观点
        async liPaperSubViewpoint() {
            try {
                this.divName4Pager = "divPager_TopicPaperLst";
                const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId_q");
                const gvResultPaper = await this.BindListPaperSubViewpoint();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //论文下拉框绑定
        BindDdl_PaperId(ddlPaperId) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strWhereCond = " topicId= " + strTopicId;
            var objDdl = document.getElementById(ddlPaperId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlPaperId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsvRTPaperRelaWApi_js_1.vRTPaperRela_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrvRTPaperRelaObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst_V)(ddlPaperId, arrvRTPaperRelaObjLst, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperId, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTitle, "主题相关论文");
                        console.log("完成BindDdl_UserId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //论文子观点列表
        async BindListPaperSubViewpoint() {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strHtml = await this.Bind_PaperSubViewpoint(strUserId, strTopicId);
            //拼接；
            $("#tbList").html(strHtml);
        }
        //选择论文
        async SelectPaperBak() {
            try {
                var strPaperId = $("#ddlPaperId_q").val();
                $("#hidPaperId").val(strPaperId);
                const responseText = await this.BindListPaperSubViewpoint();
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        async SelectPaper() {
            try {
                var strPaperId = $("#ddlPaperId_q").val();
                $("#hidPaperId").val(strPaperId);
                this.divName4Pager = "divPager_TopicPaperLst";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                await this.BindGv_vRTPaperRela_pyf();
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        CombinevPaperSubViewpointCondition2(strTopicId) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.subViewpointTypeId_q != "" && this.subViewpointTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.subViewpointTypeId_q}'`;
                //}
                //判断主题id
                // var strTopicId = clsPrivateSessionStorage.topicId;
                //if (strTopicId != "") {
                //    strWhereCond += ` And ${clsvPaperSubViewpointEN.con_TopicId} = '${strTopicId}'`;
                //}
                strWhereCond += " order by orderNum Asc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition3(strTopicId) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1=1 ";
            //var strPaperRWId = $("#hidPaperRWId").val();
            var strPaperId = $("#hidPaperId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TopicId} = '${strTopicId}'`;
                }
                if (strPaperId != "") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperId} = '${strPaperId}'`;
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strRoleId == "00620001") {
                    //$("#btnDelRecord").show();
                }
                else if (strRoleId == "00620002") {
                    //可以查看所有；
                }
                else {
                    if ($("#hidType").val() == "01") {
                        strWhereCond += " And updUser = '" + strUserId + "'";
                    }
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition4(strTopicId) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperRWId = $("#hidPaperRWId").val();
            var strPaperId = $("#hidPaperId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.sectionId_q != "" && this.sectionId_q != "0") {
                //    strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.sectionId_q}'`;
                //}
                //判断主题id
                //  var strTopicId = clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TopicId} = '${strTopicId}'`;
                }
                //if (strPaperId != "") {
                //    strWhereCond += ` And ${clsvPaperSubViewpointEN.con_PaperId} = '${strPaperId}'`;
                //}
                if ($("#hidType").val() == "01") {
                    strWhereCond += " And updUser = '" + strUserId + "'";
                }
                strWhereCond += " order by orderNum Asc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //绑定论文子观点内容
        async Bind_PaperSubViewpoint(strUserId, strTopicId) {
            //var strListDiv: string = this.mstrListDiv;
            var strUserId = strUserId;
            //var strPaperRWId = $("#hidPaperRWId").val();
            var strWhereCond2 = this.CombinevPaperSubViewpointCondition2(strTopicId);
            var strWhereCond3 = this.CombinevPaperSubViewpointCondition3(strTopicId);
            var strWhereCond4 = this.CombinevPaperSubViewpointCondition4(strTopicId);
            var strWhereCond5 = " 1=1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //var strWhereCond6 = ` ${clsvSysVoteEN.con_TableKey} = '${strPaperRWId}' And ${clsvSysVoteEN.con_UpdUser} = '${strUserId}'`;
            //var strWhereCond6 = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='02' and pubParentId='" + strPaperRWId + "'";
            var strWhereCond6 = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='02' ";
            //var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
            var arrSectionObjLst = [];
            var arrSubViewpointTypeObjLst = [];
            var arrvPaperSubViewpointObjLst = [];
            var arrvPaperSubViewpointObjLst2 = [];
            //获取图片
            var arrPaperSubAttachmentObjLst = [];
            var arrPaperSubAttachmentObjLst2 = [];
            //获取点赞数据
            var arrSysVoteObjLst = [];
            //主题用户关系
            var arrRTUserRelaObjLst = [];
            try {
                //const responseText1 = Section_GetObjLstAsync(strWhereCond4).then((jsonData) => {
                //    arrSectionObjLst = <Array<clsSectionEN>>jsonData;
                //});
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const responseText2 = (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrSubViewpointTypeObjLst = jsonData;
                });
                const responseObjLst3 = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstAsync)(strWhereCond3).then((jsonData) => {
                    arrvPaperSubViewpointObjLst2 = jsonData;
                });
                const responseRecCount4 = await (0, clsPaperSubAttachmentWApi_js_1.PaperSubAttachment_GetObjLstAsync)(strWhereCond5).then((jsonData) => {
                    arrPaperSubAttachmentObjLst2 = jsonData;
                });
                const responseText = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLstAsync)(strWhereCond6).then((jsonData) => {
                    arrSysVoteObjLst = jsonData;
                });
                //获取主题用户关系数据得到用户色码
                var strWhereCondUser = ` 1=1 And ${clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId} = '${strTopicId}'`;
                const responseObjLst5 = await (0, clsvRTUserRelaWApi_js_1.vRTUserRela_GetObjLstAsync)(strWhereCondUser).then((jsonData) => {
                    arrRTUserRelaObjLst = jsonData;
                });
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                var intJ = 0;
                for (var j = 0; j < arrSubViewpointTypeObjLst.length; j++) {
                    cateid++;
                    intJ++;
                    var fid = 0;
                    var strsubTypeId = arrSubViewpointTypeObjLst[j].subViewpointTypeId;
                    //先创建子模块类型
                    //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>';
                    strhtml += '<div style="float:left;"><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></div>';
                    strhtml += '</div></td></tr>';
                    //<td>' + cateid + ' </td>
                    //strhtml += '<td class="td-manage"></td>';
                    //子类型数据
                    var strSubViewpointId = "";
                    cateid_ = cateid;
                    var intK = 0;
                    arrvPaperSubViewpointObjLst = arrvPaperSubViewpointObjLst2.filter(x => x.subViewpointTypeId == strsubTypeId);
                    for (var k = 0; k < arrvPaperSubViewpointObjLst.length; k++) {
                        strSubViewpointId = arrvPaperSubViewpointObjLst[k].subViewpointId;
                        var strUpdUser = arrvPaperSubViewpointObjLst[k].updUser;
                        //先判断子模块类型数据ID和子观点知否匹配；
                        //if (strsubTypeId == arrvPaperSubViewpointObjLst[k].subViewpointTypeId) {
                        cateid++;
                        intK++;
                        //if (arrSectionObjLst.length != 0) {
                        //for (var i = 0; i < arrSectionObjLst.length; i++) {
                        //var strSectionId: string = arrSectionObjLst[i].sectionId;
                        //var strSectionName: string = arrSectionObjLst[i].sectionName;
                        //strhtml += '<li class="ui-li-has-alt ui-first-child"><a href="#" onclick="btnUpdateRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')" class="ui-btn" ><p>' + this.vSubViewpointObjLst[k].subViewpointContent + '</p></a><a href="#" class="ui-btn ui-btn-icon-notext ui-icon-delete" title="删除" onclick="btnDeleteRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')"></a></li>';
                        strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" ><td>';
                        //判断当前内容编辑用户的色码
                        var UserColor;
                        var objRtUser = arrRTUserRelaObjLst.find(x => x.userId == strUpdUser);
                        if (objRtUser != null) {
                            UserColor = objRtUser.colorCode;
                            ////判断是赞成01，反对03，还是疑问02；
                            //if (arrvPaperSubViewpointObjLst[k].attitudesId == "01") {
                            //}
                            //else if (arrvPaperSubViewpointObjLst[k].attitudesId == "02") {
                            //}
                            //else {
                            //}
                            strhtml += '&nbsp;&nbsp;<span class="color3">' + intK + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i><span style="color:' + UserColor + '">【' + arrvPaperSubViewpointObjLst[k].attitudesName + '】' + arrvPaperSubViewpointObjLst[k].subViewpointContent + '</span>';
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;<span class="color3">' + intK + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i><span>【' + arrvPaperSubViewpointObjLst[k].attitudesName + '】' + arrvPaperSubViewpointObjLst[k].subViewpointContent + '</span>';
                        }
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i><span style="color:' + UserColor + '">【论文名】' + arrvPaperSubViewpointObjLst[k].paperTitle + '</span>';
                        //根据子观点id 得到附件
                        if (arrvPaperSubViewpointObjLst[k].sectionName != "") {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i><span style="color:' + UserColor + '">【论文节】' + arrvPaperSubViewpointObjLst[k].sectionName + '</span>';
                        }
                        var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                        arrPaperSubAttachmentObjLst = arrPaperSubAttachmentObjLst2.filter(x => x.subViewpointId == strSubViewpointId);
                        if (arrPaperSubAttachmentObjLst.length > 0) {
                            for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {
                                var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                                strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';
                            }
                        }
                        if (arrvPaperSubViewpointObjLst[k].explainContent != "") {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i><span style="color:' + UserColor + '">【' + arrvPaperSubViewpointObjLst[k].explainTypeName + '】' + arrvPaperSubViewpointObjLst[k].explainContent + '</span>';
                        }
                        if (arrvPaperSubViewpointObjLst[k].paperPageNum != 0) {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a class="color3" ><i class="layui-icon x-show" status="true">&#xe623;</i>【pdf页码】第' + arrvPaperSubViewpointObjLst[k].paperPageNum + '页</a>';
                        }
                        var objUser = arrUsers.find(x => x.userId == arrvPaperSubViewpointObjLst[k].updUser);
                        if (objUser != null) {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="color2"><i class="layui-icon x-show" status="true">&#xe623;</i>【编辑时间】' + arrvPaperSubViewpointObjLst[k].updDate + '【编辑用户】' + objUser.userName + '</span>';
                        }
                        //最底一行编辑
                        strhtml += '<br/><div style="float:right;">';
                        strhtml += '&nbsp;&nbsp;<span style="color:royalblue" >评论数:' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</span>';
                        if (arrvPaperSubViewpointObjLst[k].score != 0) {
                            strhtml += '&nbsp;&nbsp;综合评分:' + arrvPaperSubViewpointObjLst[k].score;
                        }
                        if (arrvPaperSubViewpointObjLst[k].teaScore != 0) {
                            strhtml += '&nbsp;&nbsp;教师评分:' + arrvPaperSubViewpointObjLst[k].teaScore;
                        }
                        if (arrvPaperSubViewpointObjLst[k].stuScore != 0) {
                            strhtml += '&nbsp;&nbsp;学生评分:' + arrvPaperSubViewpointObjLst[k].stuScore;
                        }
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('论文读写子观点评论', '../GraduateEduTools/SysComment?Key=" + strSubViewpointId + "&Type=02&User=" + arrvPaperSubViewpointObjLst[k].updUser + "&pubParentId=" + $("#hidPaperId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                        strhtml += '</div></td></tr>';
                    }
                }
                //拼接；
                //  $("#tbList").html(strhtml);
                return strhtml;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////主题论文关系
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        async CombinevRTPaperRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                //判断角色 
                //管理员
                if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620001") {
                }
                else if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620002") {
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    //   strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //  strWhereCond += ` And ${clsvRTPaperRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                    //学生00620003
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTPaperRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vRTPaperRela_pyf() {
            var strPaperTypeId = $('#hidPaperTypeId').val();
            var strListDiv = "";
            var strWhereCond = await this.CombinevRTPaperRelaCondition();
            if (strPaperTypeId == "01") {
                strListDiv = this.mstrListDivPaper;
                strWhereCond += " and paperTypeId='" + strPaperTypeId + "'";
            }
            else {
                strListDiv = this.mstrListDivPaper;
                strWhereCond += " and paperTypeId='" + strPaperTypeId + "'";
            }
            var intCurrPageIndex = this.CurrPageIndexPaper; //获取当前页
            var arrvRTPaperRelaObjLst = [];
            var arrvRTPaperRelaENExObjLst = [];
            try {
                this.recCount = await (0, clsvRTPaperRelaWApi_js_1.vRTPaperRela_GetRecCountByCondAsync)(strWhereCond);
                //如果记录数小于10,
                if (this.recCount < 10) {
                    $("#divPagerPaper").attr("style", "display:none;");
                }
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvRTPaperRelaBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvRTPaperRelaWApi_js_1.vRTPaperRela_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvRTPaperRelaObjLst = jsonData;
                });
                arrvRTPaperRelaENExObjLst = arrvRTPaperRelaObjLst.map(this.CopyToEx);
                for (var objInFor of arrvRTPaperRelaENExObjLst) {
                    const conFuncMap = await this.FuncMap(objInFor);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                //if (strPaperTypeId == "01") {
                this.BindTab_vRTPaperRela(strListDiv, arrvRTPaperRelaENExObjLst);
                // } 
                console.log("完成BindGv_vRTPaperRela(in Public_PaperSubViewpoint)!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 把一个扩展类的部分属性进行函数转换
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
        /// </summary>
        /// <param name = "objzx_ConceptS">源对象</param>
        async FuncMap(objvRTPaperRela) {
            try {
                {
                    var vUsersSim_UserId = objvRTPaperRela.updUser;
                    var vUsersSim_UserName = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, vUsersSim_UserId, clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                    objvRTPaperRela.userName = vUsersSim_UserName;
                }
                ;
            }
            catch (e) {
                var strMsg = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objzx_ConceptENS">源对象</param>
        /// <returns>目标对象=>clszx_ConceptEN:objzx_ConceptENT</returns>
        CopyToEx(objzx_ConceptENS) {
            var objzx_ConceptENT = new clsvRTPaperRelaENEx_js_1.clsvRTPaperRelaENEx();
            try {
                objzx_ConceptENT = (0, clsvRTPaperRelaExWApi_js_1.vRTPaperRelaEx_CopyToEx)(objzx_ConceptENS);
                return objzx_ConceptENT;
            }
            catch (e) {
                var strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})", clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction());
                alert(strMsg);
                return objzx_ConceptENT;
            }
        }
        /* 显示vRTPaperRela对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrRTPaperRelaObjLst">需要绑定的对象列表</param>
    */
        async BindTab_vRTPaperRela(divContainer, arrvRTPaperRelaObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "编辑日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "编辑人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "进入子观点",
                    text: "进入子观点", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnPaperSubViewpoint_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelPaperRelaRecordInTab_Click("${strKeyId}");`);
                //        return btn1;
                //    }
                //},
            ];
            (0, clsCommFunc4Web_js_1.BindTabV2Where_V)(o, arrvRTPaperRelaObjLst, arrDataColumn, "mId", "TopicRTPaper");
            //BindTab(o, arrvRTPaperRelaObjLst, arrDataColumn, "mId");
            if (this.recCount > 10) {
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        //选择论文
        async btnPaperSubViewpoint_Click(strKeyId) {
            //通过ID得到论文ID
            var keyId = Number(strKeyId);
            const responseText = await (0, clsvRTPaperRelaWApi_js_1.vRTPaperRela_GetObjBymIdAsync)(keyId).then((jsonData) => {
                var objvRTPaperRelaEN = jsonData;
                if (objvRTPaperRelaEN != null) {
                    $("#hidTopicPaperId").val(objvRTPaperRelaEN.paperId);
                    HideDialogPaperSubViewpoint();
                }
            });
        }
        /*
       * 获取当前页序号  -------论文
      */
        get CurrPageIndexPaper() {
            return $("#hidCurrPageIndexPaper").val();
        }
        /*
        * 设置当前页序号-------论文
       */
        set CurrPageIndexPaper(value) {
            $("#hidCurrPageIndexPaper").val(value);
        }
        /*
     * 设置排序字段-相当使用ViewState功能  主题论文关系
     */
        set hidSortvRTPaperRelaBy(value) {
            $("#hidSortvRTPaperRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTPaperRelaBy() {
            return $("#hidSortvRTPaperRelaBy").val();
        }
    }
    exports.Public_PaperSubViewpoint = Public_PaperSubViewpoint;
});
