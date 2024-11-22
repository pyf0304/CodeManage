(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js", "../TS/L0_Entity/GraduateEduTools/clsvSysCommentEN.js", "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js", "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsString2.js", "./SysComment_QUDI_TS.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysComment_QUDI_TSEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SysComment_QUDI_TSEx
    表名:SysComment(01120622)
    生成代码版本:2020.04.08.1
    生成日期:2020/04/10 16:56:31
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsSysCommentEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js");
    const clsvSysCommentEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvSysCommentEN.js");
    const clsConceptEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js");
    const clsTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js");
    const clsViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsvPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js");
    const clsSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsvSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js");
    const clsvConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsvTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsvViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const SysComment_QUDI_TS_js_1 = require("./SysComment_QUDI_TS.js");
    /* SysComment_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class SysComment_QUDI_TSEx extends SysComment_QUDI_TS_js_1.SysComment_QUDI_TS {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvSysCommentBy: string = "commentId";
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
                //建立缓存
                //
                //const arrvSysComment_Cache = await vSysComment_GetObjLstAsync("1=1");
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    this.hidSortvSysCommentBy = "updDate Desc";
                    //var strWhereCond = this.CombinevSysCommentCondition();
                    //const responseText = await vSysComment_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //    this.RecCount = jsonData;
                    //});
                    if (this.bolIsInitShow == false) //
                     {
                        for (let i = 0; i < 7; i++) {
                            this.objPager.InitShow(SysComment_QUDI_TSEx.arrDivName4Pager[i]);
                        }
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vSysComment();
                    $("#hidUserId").val(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
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
        /* 查询
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async btnQuery_Click(strListDiv) {
            try {
                this.BindGv_vSysComment();
                //if ($("#hidQueryStata").val() == "1") {
                //    const gvResult1 = await this.BindGv_PaperComment();
                //} else if ($("#hidQueryStata").val() == "2") {
                //    const gvResult2 = await this.BindGv_PaperSubViewpointComment();
                //} else if ($("#hidQueryStata").val() == "3") {
                //    const gvResult3 = await this.BindGv_ViewpointComment();
                //} else if ($("#hidQueryStata").val() == "4") {
                //    const gvResult3 = await this.BindGv_ViewpointComment();
                //} else if ($("#hidQueryStata").val() == "5") {
                //    const gvResult3 = await this.BindGv_ViewpointComment();
                //} else if ($("#hidQueryStata").val() == "6") {
                //    const gvResult3 = await this.BindGv_ViewpointComment();
                //}
                //else {
                //    const gvResult4 = await this.BindGv_DiscussionTopicsComment();
                //}
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 论文评论
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async li_PaperComment_Click(strListDiv) {
            try {
                const gvResult = await this.BindGv_vSysComment();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 论文子观点评论
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async li_PaperSubViewpointComment_Click(strListDiv) {
            try {
                const gvResult = await this.BindGv_vSysComment();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 个人观点评论
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async li_ViewpointComment_Click(strListDiv) {
            try {
                const gvResult = await this.BindGv_vSysComment();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
    专家观点评论
    (AutoGCLib.WA_ViewScript_TS4CSharp:Gen_WApi_JS_btnQuery_Click)
    */
        async li_ExpertViewpointComment_Click(strListDiv) {
            try {
                const gvResult = await this.BindGv_vSysComment();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        概念评论
        (AutoGCLib.WA_ViewScript_TS4CSharp:Gen_WApi_JS_btnQuery_Click)
        */
        async li_ConceptComment_Click(strListDiv) {
            try {
                const gvResult = await this.BindGv_vSysComment();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        客观事实评论
        (AutoGCLib.WA_ViewScript_TS4CSharp:Gen_WApi_JS_btnQuery_Click)
        */
        async li_ObjectiveFactComment_Click(strListDiv) {
            try {
                const gvResult = await this.BindGv_vSysComment();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        客观数据评论
        (AutoGCLib.WA_ViewScript_TS4CSharp:Gen_WApi_JS_btnQuery_Click)
        */
        async li_ObjectiveBasisComment_Click(strListDiv) {
            try {
                const gvResult = await this.BindGv_vSysComment();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //查询条件
        /*
         <returns>论文条件串(strWhereCond)</returns>
       */
        async CombinevSysCommentCondition1() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            var strUserId = "";
            var objUser = arrUsers.find(x => x.userName == this.UserName_q);
            if (objUser != null) {
                strUserId = objUser.userId;
            }
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                if (this.scoreType != "" && this.scoreType != "0") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType} = '${this.scoreType}'`;
                }
                //查询论文；
                strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId} = '01'`;
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysCommentCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
        <returns>论文子观点条件串(strWhereCond)</returns>
      */
        async CombinevSysCommentCondition2() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            var strUserId = "";
            var objUser = arrUsers.find(x => x.userName == this.UserName_q);
            if (objUser != null) {
                strUserId = objUser.userId;
            }
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                if (this.scoreType != "" && this.scoreType != "0") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType} = '${this.scoreType}'`;
                }
                //查询论文子观点；
                strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId} = '02'`;
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysCommentCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
       <returns>个人观点条件串(strWhereCond)</returns>
     */
        async CombinevSysCommentCondition3() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            var strUserId = "";
            var objUser = arrUsers.find(x => x.userName == this.UserName_q);
            if (objUser != null) {
                strUserId = objUser.userId;
            }
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                if (this.scoreType != "" && this.scoreType != "0") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType} = '${this.scoreType}'`;
                }
                //查询个人观点；
                strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId} = '03'`;
                //同时查询观点类型是个人的
                strWhereCond += ` And tableKey in (select viewpointId from Viewpoint where userTypeId='01')`;
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysCommentCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
      <returns>专家观点条件串(strWhereCond)</returns>
    */
        async CombinevSysCommentCondition4() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            var strUserId = "";
            var objUser = arrUsers.find(x => x.userName == this.UserName_q);
            if (objUser != null) {
                strUserId = objUser.userId;
            }
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                if (this.scoreType != "" && this.scoreType != "0") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType} = '${this.scoreType}'`;
                }
                //查询专家观点；
                strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId} = '04'`;
                //同时查询观点类型是专家的
                strWhereCond += ` And tableKey in (select viewpointId from Viewpoint where userTypeId='02')`;
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysCommentCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
     <returns>概念条件串(strWhereCond)</returns>
    */
        async CombinevSysCommentCondition5() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            var strUserId = "";
            var objUser = arrUsers.find(x => x.userName == this.UserName_q);
            if (objUser != null) {
                strUserId = objUser.userId;
            }
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                if (this.scoreType != "" && this.scoreType != "0") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType} = '${this.scoreType}'`;
                }
                //查询概念；
                strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId} = '05'`;
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysCommentCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
    <returns>客观事实条件串(strWhereCond)</returns>
    */
        async CombinevSysCommentCondition6() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            var strUserId = "";
            var objUser = arrUsers.find(x => x.userName == this.UserName_q);
            if (objUser != null) {
                strUserId = objUser.userId;
            }
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                if (this.scoreType != "" && this.scoreType != "0") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType} = '${this.scoreType}'`;
                }
                //查询客观事实；
                strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId} = '06'`;
                strWhereCond += ` And tableKey in (select topicObjectiveId from TopicObjective where objectiveType = '01')`;
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysCommentCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
    <returns>客观数据条件串(strWhereCond)</returns>
    */
        async CombinevSysCommentCondition7() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            var strUserId = "";
            var objUser = arrUsers.find(x => x.userName == this.UserName_q);
            if (objUser != null) {
                strUserId = objUser.userId;
            }
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                if (this.scoreType != "" && this.scoreType != "0") {
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType} = '${this.scoreType}'`;
                }
                //查询数据事实；
                strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId} = '07'`;
                strWhereCond += ` And tableKey in (select topicObjectiveId from TopicObjective where objectiveType = '02')`;
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysCommentCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vSysComment() {
            //var strListDiv: string = this.mstrListDiv;
            var strWhereCond;
            const strQueryStata = $("#hidQueryStata").val();
            const intQueryStata = Number(strQueryStata) - 1;
            let arrPaperObjLst = []; //论文
            let arrPaperSubviewpointObjLst = []; //论文子观点；
            let arrViewPointObjLst = []; //主题观点、个人；
            let arrExpertViewPointObjLst = []; //主题观点、专家；
            let arrConceptObjLst = []; //主题概念；
            let arrTopicObjectiveFactObjLst = []; //主题客观、事实；
            let arrTopicObjectiveBasisObjLst = []; //主题客观、数据；
            let intRecNum = 0;
            switch (strQueryStata) {
                case "1":
                    strWhereCond = await this.CombinevSysCommentCondition1();
                    //获取论文数据源; 必须是提交论文
                    var strWhere = ` 1=1 And ${clsPaperEN_js_1.clsPaperEN.con_IsSubmit} = 'true'`;
                    arrPaperObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLstAsync)(strWhere);
                    intRecNum = arrPaperObjLst.length;
                    break;
                case "2":
                    strWhereCond = await this.CombinevSysCommentCondition2();
                    //获取论文子观点; 必须是提交论文
                    var strWhere = ` 1=1 `;
                    arrPaperSubviewpointObjLst = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstAsync)(strWhere);
                    intRecNum = arrPaperSubviewpointObjLst.length;
                    break;
                case "3":
                    strWhereCond = await this.CombinevSysCommentCondition3();
                    //获取主题个人观点 必须是提交
                    var strWhere = ` 1=1 And ${clsViewpointEN_js_1.clsViewpointEN.con_UserTypeId} ='01' And ${clsViewpointEN_js_1.clsViewpointEN.con_IsSubmit} = 'true'`;
                    arrViewPointObjLst = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstAsync)(strWhere);
                    intRecNum = arrViewPointObjLst.length;
                    break;
                case "4":
                    strWhereCond = await this.CombinevSysCommentCondition4();
                    //获取主题专家观点 必须是提交
                    var strWhere = ` 1=1 And ${clsViewpointEN_js_1.clsViewpointEN.con_UserTypeId} ='02' And ${clsViewpointEN_js_1.clsViewpointEN.con_IsSubmit} = 'true'`;
                    arrExpertViewPointObjLst = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstAsync)(strWhere);
                    intRecNum = arrExpertViewPointObjLst.length;
                    break;
                case "5":
                    strWhereCond = await this.CombinevSysCommentCondition5();
                    //获取主题概念
                    var strWhere = ` 1=1 And ${clsConceptEN_js_1.clsConceptEN.con_IsSubmit} = 'true'`;
                    arrConceptObjLst = await (0, clsvConceptWApi_js_1.vConcept_GetObjLstAsync)(strWhere);
                    intRecNum = arrConceptObjLst.length;
                    break;
                case "6":
                    strWhereCond = await this.CombinevSysCommentCondition6();
                    //获取客观事实
                    var strWhere = ` 1=1 And ${clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveType} = '01' And ${clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_IsSubmit} = 'true'`;
                    arrTopicObjectiveFactObjLst = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstAsync)(strWhere);
                    intRecNum = arrTopicObjectiveFactObjLst.length;
                    break;
                default:
                    strWhereCond = await this.CombinevSysCommentCondition7();
                    //获取客观数据
                    var strWhere = ` 1=1 And ${clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_ObjectiveType} = '02' And ${clsTopicObjectiveEN_js_1.clsTopicObjectiveEN.con_IsSubmit} = 'true'`;
                    arrTopicObjectiveBasisObjLst = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstAsync)(strWhere);
                    intRecNum = arrTopicObjectiveBasisObjLst.length;
                    break;
            }
            //if (intRecNum == 0) {
            //    const strMsg = clsString.Format("根据条件获取的记录数为0！");
            //    console.error("Error: ", strMsg);
            //    //console.trace();
            //    this.ShowEmptyRecNumInfo(SysComment_QUDI_TSEx.arrDivDataLst[intQueryStata], strMsg);
            //    this.objPager.Hide(SysComment_QUDI_TSEx.arrDivName4Pager[intQueryStata]);
            //    return;
            //}
            //根节点
            var ParentarrvSysCommentObjLst = [];
            //获取不是父节点的所有子节点数据
            var NotParentarrvSysCommentObjLst = [];
            //父节点下子节点
            var ChildarrvSysCommentObjLst = [];
            //用来获取排除父节点下子节点的剩余数据；
            var RemainDatavSysCommentObjLst = [];
            var intCurrPageIndex = this.getCurrPageIndex(SysComment_QUDI_TSEx.arrDivName4Pager[intQueryStata]); //获取当前页
            var arrvSysCommentObjLst = [];
            try {
                const responseRecCount = await (0, clsvSysCommentWApi_js_1.vSysComment_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysCommentBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrvSysCommentObjLst = await (0, clsvSysCommentWApi_js_1.vSysComment_GetObjLstByPagerAsync)(objPagerPara);
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                $('#tbList1 tr').remove();
                $('#tbList2 tr').remove();
                $('#tbList3 tr').remove();
                $('#tbList4 tr').remove();
                $('#tbList5 tr').remove();
                $('#tbList6 tr').remove();
                $('#tbList7 tr').remove();
                //获取父节点
                ParentarrvSysCommentObjLst = arrvSysCommentObjLst.filter(x => x.parentId == "root");
                //获取不是父节点数据；
                NotParentarrvSysCommentObjLst = arrvSysCommentObjLst.filter(x => x.parentId != "root");
                //先把不是父节点数据赋值给剩余数据，用于数据的每次筛选；
                RemainDatavSysCommentObjLst = NotParentarrvSysCommentObjLst;
                if (ParentarrvSysCommentObjLst.length > 0) {
                    //得到数据源循环数据
                    for (var i = 0; i < ParentarrvSysCommentObjLst.length; i++) {
                        cateid++;
                        // intJ++;
                        var fid = 0;
                        //评论内容；
                        var strCommentContent = ParentarrvSysCommentObjLst[i].comment;
                        //获取主键作为父节点
                        var strParentId = ParentarrvSysCommentObjLst[i].commentId;
                        //读取子节点 从不是父节点的数据中读取，这样可以减少资源浪费；strParentId 主键作为父节点
                        //ChildarrvSysCommentObjLst = arrvSysCommentObjLst.filter(x => x.parentId == strParentId);
                        ChildarrvSysCommentObjLst = NotParentarrvSysCommentObjLst.filter(x => x.parentId == strParentId);
                        //先把不是root数据源赋值给剩余数据；每次筛选除开父节点的数据；过滤自身数据
                        RemainDatavSysCommentObjLst = RemainDatavSysCommentObjLst.filter(x => x.parentId != strParentId);
                        strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>';
                        strhtml += '<i class="layui-icon x-show" status="true"></i>' + strCommentContent + '</td>';
                        //打分
                        strhtml += '<td>' + ParentarrvSysCommentObjLst[i].score + '</td>';
                        //评分类型
                        if (ParentarrvSysCommentObjLst[i].scoreType == "1") {
                            var strStu = "学生";
                            strhtml += '<td>' + strStu + '</td>';
                        }
                        else {
                            var strTeach = "教师";
                            strhtml += '<td>' + strTeach + '</td>';
                        }
                        //获取tablekey查询过滤；
                        var strTablekey = ParentarrvSysCommentObjLst[i].tableKey;
                        //根据不同的模块查询 比对得到不同的名称和被评论人；
                        switch (strQueryStata) {
                            case "1":
                                var pubarrPaperObjLst = []; //论文
                                pubarrPaperObjLst = arrPaperObjLst.filter(x => x.paperId == strTablekey);
                                for (let item of pubarrPaperObjLst) {
                                    console.log(item.paperTitle);
                                    //名称
                                    strhtml += '<td>' + item.paperTitle + '</td>';
                                    var objUser = arrUsers.find(x => x.userId == item.updUser);
                                    if (objUser != null) {
                                        //被评论人
                                        strhtml += '<td>' + objUser.userName + '</td>';
                                    }
                                }
                                break;
                            case "2":
                                var pubarrPaperSubviewpointObjLst = []; //论文子观点；
                                pubarrPaperSubviewpointObjLst = arrPaperSubviewpointObjLst.filter(x => x.subViewpointId == strTablekey);
                                for (let item of pubarrPaperSubviewpointObjLst) {
                                    console.log(item.subViewpointContent);
                                    //名称
                                    strhtml += '<td>' + item.subViewpointContent + '</td>';
                                    //被评论人
                                    var objUser = arrUsers.find(x => x.userId == item.updUser);
                                    if (objUser != null) {
                                        strhtml += '<td>' + objUser.userName + '</td>';
                                    }
                                }
                                break;
                            case "3":
                                var pubarrViewPointObjLst = []; //主题观点、个人；
                                pubarrViewPointObjLst = arrViewPointObjLst.filter(x => x.viewpointId == strTablekey);
                                for (let item of pubarrViewPointObjLst) {
                                    console.log(item.viewpointName);
                                    //名称
                                    strhtml += '<td>' + item.viewpointName + '</td>';
                                    var objUser = arrUsers.find(x => x.userId == item.updUser);
                                    if (objUser != null) {
                                        //被评论人
                                        strhtml += '<td>' + objUser.userName + '</td>';
                                    }
                                }
                                break;
                            case "4":
                                var pubarrExpertViewPointObjLst = []; //主题观点、专家；
                                pubarrExpertViewPointObjLst = arrExpertViewPointObjLst.filter(x => x.viewpointId == strTablekey);
                                for (let item of pubarrExpertViewPointObjLst) {
                                    console.log(item.viewpointName);
                                    //名称
                                    strhtml += '<td>' + item.viewpointName + '</td>';
                                    var objUser = arrUsers.find(x => x.userId == item.updUser);
                                    if (objUser != null) {
                                        //被评论人
                                        strhtml += '<td>' + objUser.userName + '</td>';
                                    }
                                }
                                break;
                            case "5":
                                var pubarrConceptObjLst = []; //主题概念；
                                pubarrConceptObjLst = arrConceptObjLst.filter(x => x.conceptId == strTablekey);
                                for (let item of pubarrConceptObjLst) {
                                    console.log(item.conceptName);
                                    //名称
                                    strhtml += '<td>' + item.conceptName + '</td>';
                                    var objUser = arrUsers.find(x => x.userId == item.updUser);
                                    if (objUser != null) {
                                        //被评论人
                                        strhtml += '<td>' + objUser.userName + '</td>';
                                    }
                                    //被评论人
                                    //  strhtml += '<td>' + item.userName + '</td>';
                                }
                                break;
                            case "6":
                                var pubarrTopicObjectiveFactObjLst = []; //主题客观、事实；
                                pubarrTopicObjectiveFactObjLst = arrTopicObjectiveFactObjLst.filter(x => x.topicObjectiveId == strTablekey);
                                for (let item of pubarrTopicObjectiveFactObjLst) {
                                    console.log(item.objectiveName);
                                    //名称
                                    strhtml += '<td>' + item.objectiveName + '</td>';
                                    var objUser = arrUsers.find(x => x.userId == item.updUser);
                                    if (objUser != null) {
                                        //被评论人
                                        strhtml += '<td>' + objUser.userName + '</td>';
                                    }
                                }
                                break;
                            default:
                                var pubarrTopicObjectiveBasisObjLst = []; //主题客观、数据；
                                pubarrTopicObjectiveBasisObjLst = arrTopicObjectiveBasisObjLst.filter(x => x.topicObjectiveId == strTablekey);
                                for (let item of pubarrTopicObjectiveBasisObjLst) {
                                    console.log(item.objectiveName);
                                    //名称
                                    strhtml += '<td>' + item.objectiveName + '</td>';
                                    var objUser = arrUsers.find(x => x.userId == item.updUser);
                                    if (objUser != null) {
                                        //被评论人
                                        strhtml += '<td>' + objUser.userName + '</td>';
                                    }
                                }
                                break;
                        }
                        //评论时间
                        strhtml += '<td>' + ParentarrvSysCommentObjLst[i].updDate + '</td>';
                        var objUser = arrUsers.find(x => x.userId == ParentarrvSysCommentObjLst[i].updUser);
                        if (objUser != null) {
                            //评论人
                            strhtml += '<td>' + objUser.userName + '</td>';
                        }
                        //回复数
                        ///评论人
                        if (ChildarrvSysCommentObjLst.length > 0) {
                            strhtml += '<td>' + ChildarrvSysCommentObjLst.length + '</td>';
                        }
                        else {
                            strhtml += '<td>0</td>';
                        }
                        //删除
                        strhtml += '<td class="td-manage"><button class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelSysComment("' + ParentarrvSysCommentObjLst[i].commentId + '") href = "javascript:;" > <i class="layui-icon" ></i>删除</button ></td>';
                        //结束
                        strhtml += '</tr>';
                        //父节点转化
                        cateid_ = cateid;
                        //子数据
                        if (ChildarrvSysCommentObjLst.length > 0) {
                            for (var j = 0; j < ChildarrvSysCommentObjLst.length; j++) {
                                cateid++;
                                strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="display:none;"><td>';
                                //strhtml += '<i class="layui-icon x-show" status = "true" ></i>' + ChildarrvSysCommentObjLst[j].comment + '</td>';
                                strhtml += '' + ChildarrvSysCommentObjLst[j].comment + '</td>';
                                //打分
                                strhtml += '<td>' + ChildarrvSysCommentObjLst[j].score + '</td>';
                                //评分类型
                                if (ChildarrvSysCommentObjLst[j].scoreType == "1") {
                                    var strStu = "学生";
                                    strhtml += '<td>' + strStu + '</td>';
                                }
                                else {
                                    var strTeach = "教师";
                                    strhtml += '<td>' + strTeach + '</td>';
                                }
                                //名称
                                strhtml += '<td></td>';
                                //被评论人
                                strhtml += '<td></td>';
                                //评论时间
                                strhtml += '<td>' + ChildarrvSysCommentObjLst[j].updDate + '</td>';
                                var objUser = arrUsers.find(x => x.userId == ChildarrvSysCommentObjLst[j].updUser);
                                if (objUser != null) {
                                    ///评论人
                                    strhtml += '<td>' + objUser.userName + '</td>';
                                }
                                //回复数
                                strhtml += '<td></td>';
                                //删除
                                strhtml += '<td class="td-manage"><button class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelSysComment("' + ChildarrvSysCommentObjLst[j].commentId + '") href = "javascript:;" > <i class="layui-icon" ></i>删除</button ></td>';
                                //结束
                                strhtml += '</tr>';
                            }
                        }
                    }
                }
                else {
                    //如果剩余数据大于0 ，那么则绑定；
                    if (RemainDatavSysCommentObjLst.length > 0) {
                        for (var j = 0; j < RemainDatavSysCommentObjLst.length; j++) {
                            cateid++;
                            strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '"><td>'; //这里就不用隐藏显示了，因为没有root根数据；
                            //strhtml += '<i class="layui-icon x-show" status = "true" ></i>' + RemainDatavSysCommentObjLst[j].comment + '</td>';
                            strhtml += '' + RemainDatavSysCommentObjLst[j].comment + '</td>';
                            //打分
                            strhtml += '<td>' + RemainDatavSysCommentObjLst[j].score + '</td>';
                            //评分类型
                            if (RemainDatavSysCommentObjLst[j].scoreType == "1") {
                                var strStu = "学生";
                                strhtml += '<td>' + strStu + '</td>';
                            }
                            else {
                                var strTeach = "教师";
                                strhtml += '<td>' + strTeach + '</td>';
                            }
                            //名称
                            strhtml += '<td></td>';
                            //被评论人
                            strhtml += '<td></td>';
                            //评论时间
                            strhtml += '<td>' + RemainDatavSysCommentObjLst[j].updDate + '</td>';
                            var objUser = arrUsers.find(x => x.userId == RemainDatavSysCommentObjLst[j].updUser);
                            if (objUser != null) {
                                ///评论人
                                strhtml += '<td>' + objUser.userName + '</td>';
                            }
                            //回复数
                            strhtml += '<td></td>';
                            //删除
                            strhtml += '<td class="td-manage"><button class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelSysComment("' + RemainDatavSysCommentObjLst[j].commentId + '") href = "javascript:;" > <i class="layui-icon" ></i>删除</button ></td>';
                            //结束
                            strhtml += '</tr>';
                        }
                    }
                    else {
                        const strMsg = clsString2_js_1.clsString.Format("根据条件获取的记录数为0！");
                        console.error("Error: ", strMsg);
                        //console.trace();
                        this.ShowEmptyRecNumInfo(SysComment_QUDI_TSEx.arrDivDataLst[intQueryStata], strMsg);
                        this.objPager.Hide(SysComment_QUDI_TSEx.arrDivName4Pager[intQueryStata]);
                        //return;
                    }
                }
                //拼接；
                switch (strQueryStata) {
                    case "1":
                        $("#tbList1").html(strhtml);
                        break;
                    case "2":
                        $("#tbList2").html(strhtml);
                        break;
                    case "3":
                        $("#tbList3").html(strhtml);
                        break;
                    case "4":
                        $("#tbList4").html(strhtml);
                        break;
                    case "5":
                        $("#tbList5").html(strhtml);
                        break;
                    case "6":
                        $("#tbList6").html(strhtml);
                        break;
                    default:
                        $("#tbList7").html(strhtml);
                        break;
                }
                tbody();
                if (arrvSysCommentObjLst.length > 0) {
                    this.objPager.RecCount = this.RecCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, SysComment_QUDI_TSEx.arrDivName4Pager[intQueryStata]);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
        }
        //删除数据方法
        /*
       在数据表里删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
      */
        async btnDelSysComment(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //根据当前得到主键作为父节点来查询是否包含子节点数据
                var strWhereCond = ` 1=1 And ${clsSysCommentEN_js_1.clsSysCommentEN.con_ParentId} = '${strKeyId}'`;
                //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
                const responseText = (0, clsSysCommentWApi_js_1.SysComment_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    var objSysCommenEN = jsonData;
                    if (objSysCommenEN != null) {
                        //有数据，那么需要提示先删除子节点数据
                        //成员
                        var strMsg = `该数据还包含了其它子数据，不可删除！`;
                        alert(strMsg);
                        return;
                    }
                    else {
                        //根据当前登录人；
                        const responseText1 = (0, clsSysCommentWApi_js_1.SysComment_GetObjByCommentIdAsync)(strKeyId).then((jsonData) => {
                            var objSysCommenEN = jsonData;
                            if (objSysCommenEN != null) {
                                //判断角色 
                                //管理员
                                if (strRoleId == "00620001") {
                                    const responseText = this.DelRecord(strKeyId);
                                }
                                else if (strRoleId == "00620002") {
                                    const responseText = this.DelRecord(strKeyId);
                                }
                                else {
                                    if (objSysCommenEN.updUser == strUserId) {
                                        //
                                        const responseText = this.DelRecord(strKeyId);
                                    }
                                    else {
                                        //成员
                                        var strMsg = `您只能删除自己添加的数据！`;
                                        alert(strMsg);
                                        return;
                                    }
                                }
                                //if (objSysCommenEN.updUser == strUserId) {
                                //    //
                                //    const responseText = this.DelRecord(strKeyId);
                                //}
                                //else {
                                //    //成员
                                //    var strMsg = `您只能删除自己添加的数据！`;
                                //    alert(strMsg);
                                //    return;
                                //}
                            }
                        });
                    }
                });
                //const responseText = await this.DelRecord(strKeyId);
                //const responseBindGv = await this.BindGv_vSysComment();
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
        async DelRecord(strCommentId) {
            try {
                const responseText = await (0, clsSysCommentWApi_js_1.SysComment_DelRecordAsync)(strCommentId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    const responseBindGv = await this.BindGv_vSysComment();
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
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
        /*
     * 评分类型
    */
        set scoreType(value) {
            $("#ddlScoreType").val(value);
        }
        /*
        * 评分类型
       */
        get scoreType() {
            return $("#ddlScoreType").val();
        }
    }
    exports.SysComment_QUDI_TSEx = SysComment_QUDI_TSEx;
    SysComment_QUDI_TSEx.arrDivName4Pager = [
        'divPager_PaperComment',
        'divPager_PaperSubViewpointComment',
        'divPager_ViewpointComment',
        'divPager_ExpertViewpointComment',
        'divPager_ConceptComment',
        'divPager_ObjectiveFactComment',
        'divPager_ObjectiveBasisComment'
    ];
    SysComment_QUDI_TSEx.arrDivDataLst = [
        'divDataLst_PaperComment',
        'divDataLst_PaperSubViewpointComment',
        'divDataLst_ViewpointComment',
        'divDataLst_ExpertViewpointComment',
        'divDataLst_ConceptComment',
        'divDataLst_ObjectiveFactComment',
        'divDataLst_ObjectiveBasisComment'
    ];
});
