(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js", "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js", "./ObjectiveBasis.js", "../GraduateEduPublicPage/Public_TopicObjective.js", "../GraduateEduPublicPage/Pub_PaperList.js", "../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveVerEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ObjectiveBasisEx = void 0;
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsvTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    //import { stuUserLoginInfo } from "../TS/FunClass/stuUserLoginInfo.js";
    //import { clsvQxUserRoleRelationEN } from "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js";
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsObjectiveAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js");
    const clsTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    //import { clsvPaperExWApi } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperExWApi.js";
    const clsRTTopicObjectiveRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js");
    const ObjectiveBasis_js_1 = require("./ObjectiveBasis.js");
    //import { clsvTopicObjectiveExWApi } from "../TS/L3_ForWApiEx/GraduateEdu/clsvTopicObjectiveExWApi.js";
    const Public_TopicObjective_js_1 = require("../GraduateEduPublicPage/Public_TopicObjective.js");
    const Pub_PaperList_js_1 = require("../GraduateEduPublicPage/Pub_PaperList.js");
    const TopicObjectiveCRUD_js_1 = require("../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsTopicObjectiveVerEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveVerEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsObjectiveAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js");
    const clsRTTopicObjectiveRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js");
    const clsTopicObjectiveVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveVerWApi.js");
    const clsTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js");
    const clsvTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* WApiTopicObjective_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class ObjectiveBasisEx extends ObjectiveBasis_js_1.ObjectiveBasis {
        constructor() {
            super(...arguments);
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvTopicObjectiveBy: string = "topicObjectiveId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //首次加载默认个人观点
                    var strViewType = "01";
                    $("#hidViewType").val(strViewType);
                    //const arrvTopicObjective_Cache = await vTopicObjective_GetObjLstAsync("1=1");
                    TopicObjectiveCRUD_js_1.TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";
                    //用户下拉框绑定
                    var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
                    const ddlObjectiveUserId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UserIdInvTopicObjectiveBasis_Cache("ddlObjectiveUserId_q", objUsers_Cond);
                    const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
                    //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                    //文献类型；
                    const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vTopicObjective();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Paper]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_LiteratureTypeId(ddlLiteratureTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrPaperObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                        console.log("完成BindDdl_LiteratureTypeId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        ////获取客观数据用户
        //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "1=1 And objectiveType ='02'") {
        //    //var strWhereCond = " 1 =1 ";
        //    var objDdl = document.getElementById(ddlUserId);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = vTopicObjectiveEx_GetTopicObjectiveUserObjLstAsync(strWhereCond).then((jsonData) => {
        //                var arrUserObjLst: Array<clsvTopicObjectiveEN> = <Array<clsvTopicObjectiveEN>>jsonData;
        //                BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvTopicObjectiveEN.con_UpdUser, clsvTopicObjectiveEN.con_UserName, "编辑用户");
        //                console.log("完成BindDdl_UserId!");
        //                resolve(jsonData);
        //            });
        //        }
        //        catch (e) {
        //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //    });
        //}
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
    */
        async CombinevTopicObjectiveCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.objectiveName_q != "") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveName} like '% ${this.objectiveName_q}%'`;
                }
                //if (this.userName_q != "") {
                //    strWhereCond += ` And ${clsvTopicObjectiveEN.con_UserName} like '% ${this.userName_q}%'`;
                //}
                if (this.User_q != "" && this.User_q != "0") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser} = '${this.User_q}'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                //判断客观类型 区分是客观事实、客观依据
                var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
                if (strhidObjectiveTypeId != "") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectiveTypeId}'`;
                }
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //$('#lnkUserName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#btnCancelSubmit").show();
                }
                else if (strRoleId == "00620002") {
                    $("#btnCancelSubmit").show();
                    ////根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    ////strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                    ////strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "')";
                    //strWhereCond += ` And ${clsvTopicObjectiveEN.con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
                    //var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
                    //if (strhidObjectiveTypeId != "") {
                    //    strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectiveTypeId}'`;
                    //}
                }
                else {
                    //学生； 
                    //学生00620003
                    $("#btnCancelSubmit").hide();
                    //这里判断--如果类型为01 个人观点、否则是他人观点；
                    var strViewType = $("#hidViewType").val();
                    if (strViewType == "01") {
                        strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser} = '${strUserId}'`;
                    }
                    else {
                        strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser} <> '${strUserId}'`;
                    }
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineTopicObjectiveCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async btnQuery_Click() {
            try {
                this.BindGv_vTopicObjective();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vTopicObjective() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = await this.CombinevTopicObjectiveCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvTopicObjectiveObjLst = [];
            try {
                //this.recCount = await vTopicObjective_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //});
                this.recCount = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: TopicObjectiveCRUD_js_1.TopicObjectiveCRUD.sortvTopicObjectiveBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvTopicObjectiveObjLst = jsonData;
                });
                ////换行符
                //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                ////动态显示对应的数据
                //var strhtml = "";
                //var strUserId = clsPublocalStorage.userId;
                //var strRoleId = clsPublocalStorage.roleId;
                ////个人观点
                //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                ////strhtml += '<div style="float:left;"><a href="#" title="当前论文相关' + strTitle + '">当前论文相关' + strTitle + '</a></div>';
                //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加客观数据" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加客观数据</button></div>';
                //strhtml += '</div><ul class="artlist">';
                //var v = 0;//给内容加个序号
                //for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
                //    //得到topicObjectiveId；
                //    var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
                //    v++;
                //    //对内容进行换行替换
                //    var strObjectiveContent = arrvTopicObjectiveObjLst[i].objectiveContent;
                //    var strConclusion = arrvTopicObjectiveObjLst[i].conclusion;
                //    strObjectiveContent = strObjectiveContent.replace(/\r\n/g, strBr);
                //    strObjectiveContent = strObjectiveContent.replace(/\n/g, strBr);
                //    strConclusion = strConclusion.replace(/\r\n/g, strBr);
                //    strConclusion = strConclusion.replace(/\n/g, strBr);
                //    //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                //    strhtml += '<li><span class="rowtit color3">[客观名称]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
                //    strhtml += '<li><span class="rowtit color3">[客观内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
                //    strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';
                //    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'
                //    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].updDate + '</span>';
                //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].userName + '</span>';
                //    //判断ture 、false
                //    if (arrvTopicObjectiveObjLst[i].isSubmit == true) {
                //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                //    }
                //    else {
                //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                //    }
                //    //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[是否提交]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].isSubmit + '</span></div>';
                //    if (strUserId == arrvTopicObjectiveObjLst[i].updUser) {
                //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit colorRed">[操作]：</span>';
                //        //修改个人观点
                //        strhtml += '&nbsp;&nbsp;<button title="修改客观数据" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
                //        //删除个人观点
                //        strhtml += '&nbsp;&nbsp;<button title="删除客观数据" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';
                //        //数据提交
                //        strhtml += '&nbsp;&nbsp;<button title="数据提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>数据提交</button>';
                //        //历史版本
                //        if (arrvTopicObjectiveObjLst[i].versionCount > 0 && arrvTopicObjectiveObjLst[i].versionCount != null) {
                //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('客观数据历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvTopicObjectiveObjLst[i].topicObjectiveId + "&Type=07')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                //        }
                //        strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strTopicObjectiveId + "&TypeId=08','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";
                //    } else {
                //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
                //    }
                //    //读取session角色 来判断绑定不同数据列表
                //    //获取用户角色来判断显示不同的列表数据；
                //    if (strRoleId != "00620003") {
                //        //取消提交
                //        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
                //    }
                //    //else {
                //    //    //学生00620003 教师 需要隐藏
                //    //    //取消提交
                //    //    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" style="display:none;" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
                //    //}
                //    strhtml += '</div></div></li>';
                //    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
                //}
                //strhtml += '</ul></div>';
                var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
                var strHtml = await Public_TopicObjective_js_1.Public_TopicObjective.BindList_vTopicObjective("01", strhidObjectiveTypeId, arrvTopicObjectiveObjLst);
                var strViewType = $("#hidViewType").val();
                if (strViewType == "01") {
                    //拼接；
                    $("#divDataLst").html(strHtml);
                }
                else {
                    //拼接；
                    $("#divOtherDataLst").html(strHtml);
                }
                if (this.recCount >= 10) {
                    $("#divPager1").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvTopicObjectiveObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            //try {
            //    this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
            //    console.log("完成BindGv_vTopicObjective!");
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            //    alert(strMsg);
            //}
        }
        /* 显示vTopicObjective对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrTopicObjectiveObjLst">需要绑定的对象列表</param>
       */
        async BindTab_vTopicObjective(divContainer, arrvTopicObjectiveObjLst) {
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
                    fldName: "objectiveName",
                    colHeader: "客观名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "objectiveType",
                    colHeader: "客观类型",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "objectiveTypeName",
                    colHeader: "客观类型名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isSubmit",
                    colHeader: "是否提交",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 在数据表里修改记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
     */
        async btnUpdateRecordInTab_Click(strKeyId) {
            this.opType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
            const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
            this.UpdateRecord(strKeyId);
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                //判断session是否失效
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            //if (this.opType == "AddWithMaxId") {
                            //    const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            //        var returnBool2: boolean = jsonData;
                            //        if (returnBool2 == true) {
                            //            HideDialog();
                            //            this.BindGv_vTopicObjective();
                            //        }
                            //    });
                            //}
                            //else {
                            //}
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    //HideDialog();
                                    //this.BindGv_vTopicObjective();
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strTopicObjectiveId = $('#hidObjectiveId').val();
                            const responseText6 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strTopicObjectiveId, "08", "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool6 = !!responseText6;
                            if (returnBool6 == true) {
                                console.log("客观数据总表同步成功；");
                            }
                            else {
                                console.log("客观数据总表同步失败；");
                            }
                            //修改记录的同时添加历史版本
                            const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vTopicObjective();
                                    //alert("添加历史版本出问题！");
                                }
                            });
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                //strInfo += "(In WApiTopicObjective_QUDI_TS.btnOKUpd_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                }
                            });
                            var strTopicObjectiveId = $('#hidObjectiveId').val();
                            const responseText7 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strTopicObjectiveId, "08", "2", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool7 = !!responseText7;
                            if (returnBool7 == true) {
                                console.log("客观数据总表同步成功；");
                            }
                            else {
                                console.log("客观数据总表同步失败；");
                            }
                            //修改记录的同时添加历史版本
                            const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vTopicObjective();
                                    //alert("添加历史版本出问题！");
                                }
                            });
                            break;
                        default:
                            var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    alert("登录超时，请重新登录");
                    window.top.location.href = "../Web/Login";
                }
                $("#divLoading").hide();
                //去掉提交按钮不可用状态
                $('#btnOKUpd').attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        //////////////////////////////添加数据
        /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
    */
        async btnAddNewRecord_Click() {
            this.opType = "Add";
            try {
                var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
                const responseText = await this.AddNewRecord();
                //获取分享Id
                const responseText1 = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("08", clsPublocalStorage_js_1.clsPublocalStorage.userId);
                var strShareId = responseText1;
                //var returnBool: boolean = !!responseText2;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        async AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", false);
        }
        /* 添加新记录，保存函数
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSave() {
            try {
                const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表TopicObjective的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtTopicObjectiveId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            //判断Id是否为空
            if ($('#txtTopicObjectiveId').val() != "") {
                this.DivName = "divAddNewRecordSave";
                $('#hidObjectiveId').val($('#txtTopicObjectiveId').val());
                var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
                objTopicObjectiveEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
                this.PutDataToTopicObjectiveClass(objTopicObjectiveEN);
                try {
                    const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_IsExistAsync)(objTopicObjectiveEN.topicObjectiveId);
                    var bolIsExist = responseText;
                    if (bolIsExist == true) {
                        var strMsg = `添加记录时，关键字：${objTopicObjectiveEN.topicObjectiveId}已经存在！`;
                        alert(strMsg);
                        return responseText; //一定要有一个返回值，否则会出错！
                    }
                    const responseText2 = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_AddNewRecordAsync)(objTopicObjectiveEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        //var strInfo: string = `添加记录成功!`;
                        //$('#lblResult46').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                        //添加成功，则执行附件添加方法；
                        //判断是否有返回的附件路径值
                        if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                            var fileOne = $("#hdnFileOne").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        }
                        else {
                            if ($("#hdnFileTwo").val() != "") {
                                var fileTwo = $("#hdnFileTwo").val();
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                            }
                            else {
                                if ($("#hdnFileThree").val() != "") {
                                    var fileThree = $("#hdnFileThree").val();
                                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                                }
                            }
                        }
                    }
                    else {
                        var strInfo = `添加记录不成功!`;
                        $('#lblResult46').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                    return responseText2; //一定要有一个返回值，否则会出错！
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `添加记录不成功,${e}.`;
                    alert(strMsg);
                    return false;
                }
            }
            else {
                var strInfo = `获取最大关键字为空，不成功!`;
                //显示信息框
                alert(strInfo);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //////////////////////////////////////////////////////////////////////附件添加
        //添加上传论文附件方法
        async AddNewRecordobjPaperSubAttachmentENSave(filePath, strfileNum) {
            var objObjectiveAttachmentEN = new clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN();
            this.PutDataToPaperAttachmentClass(objObjectiveAttachmentEN, filePath);
            try {
                const responseText2 = await (0, clsObjectiveAttachmentWApi_js_1.ObjectiveAttachment_AddNewRecordAsync)(objObjectiveAttachmentEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //第一个附件
                    if (strfileNum == "first") {
                        //如果第二个附件不等于空，那么执行添加函数；
                        if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            //为空则判断第三个附件值；
                            if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                var fileThree = $("#hdnFileThree").val();
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                            }
                        }
                    }
                    else if (strfileNum == "two") {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }
                }
                else {
                    var strInfo = `论文附件添加不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //观点附件数据存放
        PutDataToPaperAttachmentClass(pobjObjectiveAttachmentEN, filePath) {
            pobjObjectiveAttachmentEN.SetTopicObjectiveId($("#txtTopicObjectiveId").val()); // 概念Id
            var strfilePath = filePath;
            //判断地址不为空则执行截取操作
            if (strfilePath != "") {
                var index = strfilePath.lastIndexOf("\/");
                strfilePath = strfilePath.substring(index + 1, strfilePath.length);
                pobjObjectiveAttachmentEN.SetFilePath(filePath);
                pobjObjectiveAttachmentEN.SetObjectiveAttachmentName(strfilePath);
            }
            pobjObjectiveAttachmentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjObjectiveAttachmentEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls); //教学班
            pobjObjectiveAttachmentEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
        }
        ///////////////////////////////////////////////////////////////////数据提交；
        //客观提交审核
        async btnIsSubmit_Click(strKeyId) {
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        //提交判断；
        async SubmitRecord(strTopicObjectiveId) {
            this.keyId = strTopicObjectiveId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsTopicObjectiveWApi_js_1.TopicObjective_GetObjByTopicObjectiveIdAsync)(strTopicObjectiveId).then((jsonData) => {
                        var objTopicObjectiveEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                        //判断角色 //学生00620003
                        if (strRoleId == "00620003") {
                            // //通过判断数据用户是否是当前登录用户；
                            if (objTopicObjectiveEN.updUser == strUserId) {
                                //判断数据是否已审核
                                if (objTopicObjectiveEN.isSubmit == false) {
                                    const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                    });
                                }
                                else {
                                    alert("当前数据已提交！");
                                    return;
                                }
                            }
                            else {
                                alert("当前数据不是您所添加，不能提交！");
                                return;
                            }
                        }
                        else {
                            //可以提交
                            //判断数据是否已提交
                            if (objTopicObjectiveEN.isSubmit == false) {
                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                });
                            }
                            else {
                                alert("当前数据已提交！");
                                return;
                            }
                        }
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 提交权限修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async SubmitRecordSave() {
            const strThisFuncName = this.SubmitRecordSave.name;
            //
            var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
            objTopicObjectiveEN.SetTopicObjectiveId(this.keyId);
            objTopicObjectiveEN.SetIsSubmit(true);
            // this.PutDataToTopicObjectiveClass(objTopicObjectiveEN);
            objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `提交成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            HideDialog();
                            this.BindGv_vTopicObjective();
                        }
                        else {
                            var strInfo = `提交不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("提交失败");
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
        ///////////////////////////////////////////////////////////////////删除数据控制；
        /*
       在数据表里删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
      */
        async btnDelRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                ////查询和id相关的关系数据是否存在
                //var strWhere = ` 1=1 And ${clsRTTopicObjectiveRelaEN.con_TopicObjectiveId} = '${strKeyId}'`;
                //const responseObjLst = await RTTopicObjectiveRela_GetObjLstAsync(strWhere).then((jsonData) => {
                //    var arrRTTopicObjectiveRelaObjLst = <Array<clsRTTopicObjectiveRelaEN>>jsonData;
                //    if (arrRTTopicObjectiveRelaObjLst.length > 0) {
                //        alert("当前数据已被引用,不能删除！");
                //        return;
                //    }
                //    else {
                //        const responseText = this.DelRecord(strKeyId);
                //        const responseBindGv = this.BindGv_vTopicObjective();
                //    }
                //});
                //查询和id相关的关系数据是否存在
                var strWhere1 = ` 1=1 And ${clsRTTopicObjectiveRelaEN_js_1.clsRTTopicObjectiveRelaEN.con_TopicObjectiveId} = '${strKeyId}'`;
                var RTVCount = 0;
                const responseText1 = await (0, clsRTTopicObjectiveRelaWApi_js_1.RTTopicObjectiveRela_GetRecCountByCondAsync)(strWhere1).then((jsonData) => {
                    RTVCount = jsonData;
                });
                //查询和id相关的评论评分是否存在
                var strWhere2 = " 1=1 And tableKey ='" + strKeyId + "' and commentTypeId='07'";
                var commentCount = 0;
                const responseText2 = await (0, clsSysCommentWApi_js_1.SysComment_GetRecCountByCondAsync)(strWhere2).then((jsonData) => {
                    commentCount = jsonData;
                });
                if (RTVCount > 0) {
                    alert("当前数据已被引用,不能删除！");
                    return;
                }
                else if (commentCount > 0) {
                    alert("当前数据已被人评论打分,不能删除！");
                    return;
                }
                else {
                    var strTopicObjectiveVWhereCond = " topicObjectiveId='" + strKeyId + "' order by updDate Asc";
                    var arrTopicObjectiveVObjLst = [];
                    const responseText1 = await (0, clsTopicObjectiveVerWApi_js_1.TopicObjectiveVer_GetObjLstAsync)(strTopicObjectiveVWhereCond).then((jsonData) => {
                        arrTopicObjectiveVObjLst = jsonData;
                    });
                    var arrSelectedKeys = arrTopicObjectiveVObjLst.map((x) => {
                        var strId = x.topicObjectiveVId.toString();
                        //var strKey = strId.substring(3);
                        return strId;
                    });
                    //更新总表3个参数 主键、子表类型、页面操作类型；
                    var strSubViewpointId = strKeyId;
                    const responseText7 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSubViewpointId, "08", "3", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                    var returnBool7 = !!responseText7;
                    if (returnBool7 == true) {
                        console.log("概念数据总表删除成功；");
                    }
                    else {
                        console.log("概念数据总表删除失败；");
                    }
                    const responseText0 = await this.VDelMultiRecord(arrSelectedKeys);
                    const responseText = this.DelRecord(strKeyId);
                    const responseBindGv = this.BindGv_vTopicObjective();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        //批量删除
        VDelMultiRecord(arrTopicObjectiveVId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsTopicObjectiveVerWApi_js_1.TopicObjectiveVer_DelTopicObjectiveVersAsync)(arrTopicObjectiveVId).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            var strInfo = `删除历史版本成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                            console.log(strInfo);
                        }
                        else {
                            var strInfo = `历史版本删除记录不成功!`;
                            //显示信息框
                            alert(strInfo);
                        }
                        console.log("完成DelMultiRecord!");
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
        /* 删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
    */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                //需要判断当前数据中是否包含已提交数据、如果有则不能删除
                var strKeyList;
                if (arrKeyIds.length == 0)
                    return "";
                strKeyList = "";
                for (var i = 0; i < arrKeyIds.length; i++) {
                    if (i == 0)
                        strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                    else
                        strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
                }
                //
                var strWhereCond = " topicObjectiveId in (" + strKeyList + ")";
                var arrTopicObjectiveObjLst = [];
                const responseText1 = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrTopicObjectiveObjLst = jsonData;
                    //查询是否有提交的数据
                    arrTopicObjectiveObjLst = arrTopicObjectiveObjLst.filter(x => x.isSubmit == true);
                    if (arrTopicObjectiveObjLst.length > 0) {
                        alert("包含有已提交数据，不能删除！");
                        return "";
                    }
                });
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vTopicObjective();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        ////////////////////////////////////////////////////修改数据
        //修改权限判断是否提交 提交则不可修改；
        /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
    */
        async UpdateRecord(strTopicObjectiveId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.keyId = strTopicObjectiveId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_GetObjByTopicObjectiveIdAsync)(strTopicObjectiveId);
                var objTopicObjectiveEN = responseText;
                // //通过判断数据用户是否是当前登录用户；
                if (objTopicObjectiveEN.updUser == strUserId) {
                    //判断数据是否提交，提交则不可修改；
                    if (objTopicObjectiveEN.isSubmit == false) {
                        ShowDialog('Update');
                        this.GetDataFromTopicObjectiveClass(objTopicObjectiveEN);
                        console.log("完成UpdateRecord!");
                    }
                    else {
                        alert("当前数据已提交,不能修改！");
                        return;
                    }
                }
                else {
                    alert("当前数据不是您所添加，不能修改！");
                    return;
                }
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
            objTopicObjectiveEN.SetTopicObjectiveId(this.keyId);
            $('#hidObjectiveId').val(this.keyId);
            this.PutDataToTopicObjectiveClass(objTopicObjectiveEN);
            objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //如果等于空，那么就去判断附件是否为空；
                    //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                    if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                        //根据Id删除附件
                        var strwhere = "topicObjectiveId ='" + objTopicObjectiveEN.topicObjectiveId + "'";
                        this.DelRecordByWhere(strwhere);
                    }
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
            }
            return true;
        }
        //添加历史版本
        async AddVersionRecordSave() {
            const strThisFuncName = this.AddVersionRecordSave.name;
            var objTopicObjectiveVerEN = new clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN();
            objTopicObjectiveVerEN.SetTopicObjectiveId(this.topicObjectiveId);
            this.PutDataToTopicObjectiveVClass(objTopicObjectiveVerEN);
            try {
                const responseText2 = await (0, clsTopicObjectiveVerWApi_js_1.TopicObjectiveVer_AddNewRecordAsync)(objTopicObjectiveVerEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and topicObjectiveId=" + this.topicObjectiveId;
                    var intVersionCount = await (0, clsTopicObjectiveVerWApi_js_1.TopicObjectiveVer_GetRecCountByCondAsync)(strWhereCond2);
                    var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
                    objTopicObjectiveEN.SetTopicObjectiveId(this.topicObjectiveId);
                    objTopicObjectiveEN.SetVersionCount(intVersionCount);
                    objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            return true;
                        }
                        else {
                            var strInfo = `添加历史版本数不成功!`;
                            alert(strInfo);
                            console.log("添加历史版本数不成功");
                            return false;
                        }
                    });
                    return true;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加版本记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        //删除观点附件
        /*
    根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        DelRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsObjectiveAttachmentWApi_js_1.ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                        }
                        else {
                            var strInfo = `删除记录不成功!`;
                            //显示信息框
                            //alert(strInfo);
                        }
                        //在修改时候，不管是否有附件数据被清除； 都需要执行附件添加功能
                        //判断是否有返回的附件路径值
                        var fileOne = $("#hdnFileOne").val();
                        if (fileOne != "" && fileOne != undefined) { //第一个附件框判断
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        }
                        else {
                            var fileTwo = $("#hdnFileTwo").val();
                            if (fileTwo != "" && fileTwo != undefined) {
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                            }
                            else {
                                var fileThree = $("#hdnFileThree").val();
                                if (fileThree != "" && fileThree != undefined) {
                                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                                }
                            }
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
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjTopicObjectiveEN">数据传输的目的类对象</param>
      */
        PutDataToTopicObjectiveVClass(pobjTopicObjectiveVerEN) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjTopicObjectiveVerEN.SetTopicObjectiveId(this.topicObjectiveId); // 客观Id
            pobjTopicObjectiveVerEN.SetObjectiveName(this.objectiveName); // 客观名称
            pobjTopicObjectiveVerEN.SetObjectiveContent(this.objectiveContent); // 客观内容
            //判断客观类型
            var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
            if (strhidObjectiveTypeId != "") {
                pobjTopicObjectiveVerEN.SetObjectiveType(strhidObjectiveTypeId);
            }
            //pobjTopicObjectiveVerEEN.SetObjectiveType(this.objectiveType;// 客观类型
            pobjTopicObjectiveVerEN.SetSourceId(this.sourceId); // 来源Id
            pobjTopicObjectiveVerEN.SetConclusion(this.conclusion); // 结论
            pobjTopicObjectiveVerEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjTopicObjectiveVerEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjTopicObjectiveVerEN.SetUpdUser(strUserId); // 修改用户Id
            pobjTopicObjectiveVerEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjTopicObjectiveEN">数据传输的目的类对象</param>
       */
        PutDataToTopicObjectiveClass(pobjTopicObjectiveEN) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjTopicObjectiveEN.SetTopicObjectiveId(this.topicObjectiveId); // 客观Id
            pobjTopicObjectiveEN.SetObjectiveName(this.objectiveName); // 客观名称
            pobjTopicObjectiveEN.SetObjectiveContent(this.objectiveContent); // 客观内容
            //判断客观类型
            var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
            if (strhidObjectiveTypeId != "") {
                pobjTopicObjectiveEN.SetObjectiveType(strhidObjectiveTypeId);
            }
            //pobjTopicObjectiveEEN.SetObjectiveType(this.objectiveType;// 客观类型
            pobjTopicObjectiveEN.SetSourceId(this.sourceId); // 来源Id
            pobjTopicObjectiveEN.SetConclusion(this.conclusion); // 结论
            pobjTopicObjectiveEN.SetShareId(this.shareId);
            pobjTopicObjectiveEN.SetIsSubmit(false); // 是否提交
            pobjTopicObjectiveEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            ;
            pobjTopicObjectiveEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjTopicObjectiveEN.SetUpdUser(strUserId); // 修改用户Id
            pobjTopicObjectiveEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:把类对象的属性内容显示到界面上
     注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
      如果在设置数据库时,就应该一级字段在前,二级字段在后
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
      <param name = "pobjTopicObjectiveEN">表实体类对象</param>
    */
        GetDataFromTopicObjectiveClass(pobjTopicObjectiveEN) {
            this.topicObjectiveId = pobjTopicObjectiveEN.topicObjectiveId; // 客观Id
            this.objectiveName = pobjTopicObjectiveEN.objectiveName; // 客观名称
            this.objectiveContent = pobjTopicObjectiveEN.objectiveContent; // 客观内容
            this.objectiveType = pobjTopicObjectiveEN.objectiveType; // 客观类型
            this.sourceId = pobjTopicObjectiveEN.sourceId; // 来源Id
            this.conclusion = pobjTopicObjectiveEN.conclusion; // 结论
            this.shareId = pobjTopicObjectiveEN.shareId;
            this.isSubmit = pobjTopicObjectiveEN.isSubmit; // 是否提交
            this.updDate = pobjTopicObjectiveEN.updDate; // 修改日期
            this.updUser = pobjTopicObjectiveEN.updUser; // 修改用户Id
            this.memo = pobjTopicObjectiveEN.memo; // 备注
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvPaperBy(value) {
            $("#hidSortvPaperBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvPaperBy() {
            return $("#hidSortvPaperBy").val();
        }
        /*
       * 论文标题
      */
        get paperTitle_q() {
            return $("#txtPaperTitle_q").val();
        }
        ///////////////////////论文列表条件
        get readUser_q() {
            return $("#ddlUserId_q").val();
        }
        /*
        * 文献类型Id
       */
        get literatureTypeId_q() {
            return $("#ddlLiteratureTypeId_q").val();
        }
        /*
        * 论文Id
       */
        set paperId(value) {
            $("#txtPaperId").val(value);
        }
        /*
        * 论文
       */
        get paperId() {
            return $("#txtPaperId").val();
        }
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        async CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                }
                //用户
                if (this.readUser_q != "" && this.readUser_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdUser} = '${this.readUser_q}'`;
                }
                //只查询提交的论文数据
                strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_IsSubmit} = 'true'`;
                //排除获取已被当前观点引用过的论文数据；
                //strWhereCond += ` And paperId not in (select paperId from RTPaperRela where viewpointId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //选择论文弹出列表数据；
        async selectPaper_Click() {
            const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
            await objPage_Paper.Page_Load();
            //await objPage_Paper.BindGv_vPaper();
        }
        //查询论文列表
        async btnPaperQuery_Click() {
            const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
            await objPage_Paper.Page_Load();
            //await objPage_Paper.BindGv_vPaper();
        }
        //确定选择的论文 并添加到关系表中
        btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            $("#txtSourceId").val(strkeyId);
            //设置只读属性；
            $("#txtSourceId").attr("disabled", "disabled");
            //$("#txtPaperId").val(strkeyId);
            ////设置只读属性；
            //$("#txtPaperId").attr("disabled", "disabled");
            //关闭列表
            HideDialogThree();
        }
        /*
      * 文献类型
     */
        set objectiveType(value) {
            $("#ddlObjectiveType").val(value);
        }
        /*
        * 文献类型
       */
        get objectiveType() {
            return $("#ddlObjectiveType").val();
        }
        //取消提交
        async btnCancelSubmit_Click(strKeyId) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            // var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要取消的记录！");
                return;
            }
            try {
                this.CancelSubmitRecordSave(strKeyId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*取消
      
     */
        async CancelSubmitRecordSave(strKeyId) {
            const strThisFuncName = this.CancelSubmitRecordSave.name;
            //
            var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
            objTopicObjectiveEN.SetTopicObjectiveId(strKeyId);
            objTopicObjectiveEN.SetIsSubmit(false);
            //objPaperEN..submitter = clsPublocalStorage.userId;//提交人；
            objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN).then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        var strInfo = `取消成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //HideDialog();
                        this.BindGv_vTopicObjective();
                    }
                    else {
                        var strInfo = `取消不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("取消失败");
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `取消记录不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
    * 用户名
    */
        get userName_q() {
            return $("#txtUserName_q").val();
        }
        /*
    * 起始时间
    */
        get StartDate_q() {
            return $("#txtStartDate_q").val();
        }
        /*
        * 起始时间
       */
        set StartDate_q(value) {
            $("#txtStartDate_q").val(value);
        }
        /*
       * 结束时间
      */
        get EndDate_q() {
            return $("#txtEndDate_q").val();
        }
        /*
        * 结束时间
       */
        set EndDate_q(value) {
            $("#txtEndDate_q").val(value);
        }
        get User_q() {
            return $("#ddlObjectiveUserId_q").val();
        }
        /*
     * 分享
     */
        set shareId(value) {
            $("#ddlShareId").val(value);
        }
        /*
        * 分享
        */
        get shareId() {
            return $("#ddlShareId").val();
        }
    }
    exports.ObjectiveBasisEx = ObjectiveBasisEx;
});
