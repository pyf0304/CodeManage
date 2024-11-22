(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsDropDownList.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js", "../TS/PubFun/clsPublocalStorage.js", "../GraduateEduPublicPage/Public_SysSkill.js", "../GraduateEduPublicPage/Pub_PaperList.js", "../PagesBase/GraduateEduTopic/SysSkillCRUD.js", "../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js", "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsString.js", "./SysSkill_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSkillCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SysSkillCRUDEx
    表名:SysSkill(01120646)
    生成代码版本:2020.05.18.1
    生成日期:2020/05/22 19:00:05
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsvSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const Public_SysSkill_js_1 = require("../GraduateEduPublicPage/Public_SysSkill.js");
    const Pub_PaperList_js_1 = require("../GraduateEduPublicPage/Pub_PaperList.js");
    const SysSkillCRUD_js_1 = require("../PagesBase/GraduateEduTopic/SysSkillCRUD.js");
    const clsRTSysSkillRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsSysOperationTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js");
    const clsSysSecurityLevelEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js");
    const clsSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsRTSysSkillRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js");
    const clsSysSkillVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillVerWApi.js");
    const clsSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js");
    const clsvSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsSysOperationTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js");
    const clsSysSecurityLevelWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const SysSkill_EditEx_js_1 = require("./SysSkill_EditEx.js");
    /* SysSkillCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class SysSkillCRUDEx extends SysSkillCRUD_js_1.SysSkillCRUD {
        constructor() {
            super(...arguments);
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvSysSkillBy: string = "skillId";
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_vSysSkill();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vSysSkill":
                    alert('该类没有绑定该函数：[this.BindGv_vSysSkill_Cache]！');
                    //this.BindGv_vSysSkill_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (SysSkillCRUD_js_1.SysSkillCRUD.objPage_CRUD == null) {
                SysSkillCRUD_js_1.SysSkillCRUD.objPage_CRUD = new SysSkillCRUDEx();
                objPage = SysSkillCRUD_js_1.SysSkillCRUD.objPage_CRUD;
            }
            else {
                objPage = SysSkillCRUD_js_1.SysSkillCRUD.objPage_CRUD;
            }
            const objPage_Edit = new SysSkill_EditEx_js_1.SysSkill_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    ;
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //建立缓存
                    var strViewType = "01";
                    $("#hidViewType").val(strViewType);
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    SysSkillCRUD_js_1.SysSkillCRUD.sortvSysSkillBy = "skillName Asc";
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vSysSkill();
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
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    $("#divLoading").hide();
                    //论文
                    //PaperCRUD.sortPaperBy = "updDate Desc";
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    SysSkillCRUD_js_1.SysSkillCRUD.sortvSysSkillBy = "skillName Asc";
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vSysSkill_Cache();
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
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
    */
        async CombinevSysSkillCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.skillName_q != "") {
                    strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName} like '% ${this.skillName_q}%'`;
                }
                if (this.operationTypeId_q != "" && this.operationTypeId_q != "0") {
                    strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId} = '${this.operationTypeId_q}'`;
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#btnDelRecord").show();
                    $("#btnCancelSubmit").show();
                    if (this.updUser_q != "") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} like '% ${this.updUser_q}%'`;
                    }
                }
                else if (strRoleId == "00620002") {
                    //教师
                    $("#btnDelRecord").hide();
                    $("#btnCancelSubmit").show();
                    if (this.updUser_q != "") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} like '% ${this.updUser_q}%'`;
                    }
                }
                else {
                    //学生 教师；
                    $("#btnDelRecord").hide();
                    $("#btnCancelSubmit").hide();
                    //学生00620003 00620002教师
                    var strViewType = $("#hidViewType").val();
                    if (strViewType == "01") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} = '${strUserId}'`;
                    }
                    else {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} <> '${strUserId}'`;
                    }
                    //strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} = '${objvUserRoleRelation.userId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysSkillCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vSysSkill() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevSysSkillCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvSysSkillObjLst = [];
            try {
                this.recCount = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: SysSkillCRUD_js_1.SysSkillCRUD.sortvSysSkillBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvSysSkillObjLst = jsonData;
                });
                ////换行符
                //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                ////动态显示对应的数据
                //var strhtml = "";
                //var strUserId = clsPublocalStorage.userId;
                //var strRoleId = clsPublocalStorage.roleId;
                ////技能
                //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加技能" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加技能</button></div>';
                //strhtml += '</div><ul class="artlist">';
                //var v = 0;//给内容加个序号
                //for (var i = 0; i < arrvSysSkillObjLst.length; i++) {
                //    //得到skillId；
                //    var strSkillId = arrvSysSkillObjLst[i].skillId;
                //    v++;
                //    var strProcess = arrvSysSkillObjLst[i].process;
                //    strProcess = strProcess.replace(/\r\n/g, strBr);
                //    strProcess = strProcess.replace(/\n/g, strBr);
                //    //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                //    strhtml += '<li><span class="rowtit color3">[技能名称]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].skillName + '</span></li>';
                //    strhtml += '<li><span class="rowtit color3">[实施过程]：</span><span class="abstract-text">' + strProcess + '</span></li>';
                //    //strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].conclusion + '</span></li>';
                //    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'
                //    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].updDate + '</span>';
                //    //获取用户名称；根据id；
                //    var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
                //    //获取用户名；
                //    arrUsers = arrUsers.filter(x => x.userId == arrvSysSkillObjLst[i].updUser);//专家观点；
                //    for (var j = 0; j < arrUsers.length; j++) {
                //        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrUsers[j].userName + '</span>';
                //        break;
                //    }
                //    //判断ture 、false
                //    if (arrvSysSkillObjLst[i].isSubmit == true) {
                //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                //    }
                //    else {
                //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                //    }
                //    //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[是否提交]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].isSubmit + '</span></div>';
                //    if (strUserId == arrvSysSkillObjLst[i].updUser) {
                //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit colorRed">[操作]：</span>';
                //        //修改技能
                //        strhtml += '&nbsp;&nbsp;<button title="修改技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>修改技能</button>';
                //        //删除技能
                //        strhtml += '&nbsp;&nbsp;<button title="删除技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>删除技能</button>';
                //        //数据提交
                //        strhtml += '&nbsp;&nbsp;<button title="提交技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>提交技能</button>';
                //        //历史版本
                //        //if (arrvSysSkillObjLst[i].versionCount > 0 && arrvSysSkillObjLst[i].versionCount != null) {
                //        //    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvSysSkillObjLst[i].skillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                //        //}
                //        strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strSkillId + "&TypeId=09','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";
                //    } else {
                //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
                //    }
                //    //读取session角色 来判断绑定不同数据列表
                //    //获取用户角色来判断显示不同的列表数据；
                //    //管理员则不需要隐藏
                //    if (strRoleId != "00620003") {
                //        //取消提交
                //        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
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
                //拼接；
                var strHtml = await Public_SysSkill_js_1.Public_SysSkill.BindList_vSysSkill("01", arrvSysSkillObjLst);
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
            //if (arrvSysSkillObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            //try {
            //    this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
            //    console.log("完成BindGv_vSysSkill!");
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            //    alert(strMsg);
            //}
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
    */
        async CombinevSysSkillConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvSysSkill_Cond = new clsvSysSkillEN_js_1.clsvSysSkillEN();
            objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN_js_1.clsvSysSkillEN.con_id_CurrEduCls, clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls, "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.skillName_q != "") {
                    strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName} like '% ${this.skillName_q}%'`;
                    objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName, this.skillName_q, "like");
                }
                if (this.operationTypeId_q != "" && this.operationTypeId_q != "0") {
                    strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId} = '${this.operationTypeId_q}'`;
                    objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId, this.operationTypeId_q, "=");
                }
                //if (this.updUser_q != "") {
                //    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${this.updUser_q}%'`;
                //    objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_UpdUser, this.updUser_q, "like");
                //}
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#btnCancelSubmit").show();
                    if (this.updUser_q != "") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} like '% ${this.updUser_q}%'`;
                        objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser, this.updUser_q, "like");
                    }
                }
                else if (strRoleId == "00620002") {
                    $("#btnCancelSubmit").show();
                    if (this.updUser_q != "") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} like '% ${this.updUser_q}%'`;
                        objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser, this.updUser_q, "like");
                    }
                }
                else {
                    $("#btnCancelSubmit").hide();
                    //学生； 
                    strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} = '${strUserId}'`;
                    objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser, strUserId, "=");
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineSysSkillConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvSysSkill_Cond;
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
    */
        async BindGv_vSysSkill_Cache() {
            var strListDiv = this.divName4DataList;
            var objvSysSkill_Cond = await this.CombinevSysSkillConditionObj();
            objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN_js_1.clsvSysSkillEN.con_id_CurrEduCls, SysSkillCRUDEx.strid_CurrEduCls_Cache, "=");
            var strWhereCond = JSON.stringify(objvSysSkill_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvSysSkillObjLst = [];
            try {
                this.recCount = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetRecCountByCond_Cache)(objvSysSkill_Cond, SysSkillCRUDEx.strid_CurrEduCls_Cache);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: SysSkillCRUD_js_1.SysSkillCRUD.sortvSysSkillBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvSysSkillObjLst = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetObjLstByPager_Cache)(objPagerPara, SysSkillCRUDEx.strid_CurrEduCls_Cache);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvSysSkillObjLst.length == 0) {
            //    var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=SysSkill_${SysSkillCRUD.strid_CurrEduCls_Cache})`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
                console.log("完成BindGv_vSysSkill!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vSysSkill对象的所有属性值
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
      <param name = "divContainer">显示容器</param>
      <param name = "arrSysSkillObjLst">需要绑定的对象列表</param>
    */
        async BindTab_vSysSkill(divContainer, arrvSysSkillObjLst) {
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
                    fldName: "skillName",
                    colHeader: "技能名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "process",
                    colHeader: "实施过程",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "levelName",
                    colHeader: "级别名称",
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
                //{
                //    fldName: "okCount",
                //    colHeader: "点赞统计",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "appraiseCount",
                //    colHeader: "评论数",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "score",
                //    colHeader: "评分",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "stuScore",
                //    colHeader: "学生平均分",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "teaScore",
                //    colHeader: "教师评分",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "pdfContent",
                //    colHeader: "Pdf内容",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "pdfPageNum",
                //    colHeader: "Pdf页码",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "citationCount",
                //    colHeader: "引用统计",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "versionCount",
                //    colHeader: "版本统计",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "updUser",
                    colHeader: "修改人",
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
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvSysSkillObjLst, arrDataColumn, "skillId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
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
                //查询和id相关的关系数据是否存在
                var strWhere1 = ` 1=1 And ${clsRTSysSkillRelaEN_js_1.clsRTSysSkillRelaEN.con_SkillId} = '${strKeyId}'`;
                var RTVCount = 0;
                const responseText1 = await (0, clsRTSysSkillRelaWApi_js_1.RTSysSkillRela_GetRecCountByCondAsync)(strWhere1).then((jsonData) => {
                    RTVCount = jsonData;
                });
                //查询和id相关的评论评分是否存在09
                var strWhere2 = " 1=1 And tableKey ='" + strKeyId + "' and commentTypeId='09'";
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
                    //先获取历史版本再删除；
                    var strSkillVWhereCond = " SkillvId='" + strKeyId + "' order by updDate Asc";
                    var arrSkillVWObjLst = [];
                    const responseText1 = await (0, clsSysSkillVerWApi_js_1.SysSkillVer_GetObjLstAsync)(strSkillVWhereCond).then((jsonData) => {
                        arrSkillVWObjLst = jsonData;
                    });
                    var arrSelectedKeys = arrSkillVWObjLst.map((x) => {
                        var strId = x.skillVId.toString();
                        //var strKey = strId.substring(3);
                        return strId;
                    });
                    //更新总表3个参数 主键、子表类型、页面操作类型；
                    var strSkillId = strKeyId;
                    const responseText6 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSkillId, "09", "3", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                    var returnBool6 = !!responseText6;
                    if (returnBool6 == true) {
                        console.log("技能数据总表删除成功；");
                    }
                    else {
                        console.log("技能数据总表删除失败；");
                    }
                    const responseText0 = await this.VDelMultiRecord(arrSelectedKeys);
                    const responseText = await this.DelRecord(strKeyId);
                    const responseBindGv = await this.BindGv_vSysSkill();
                }
                ////const responseText = await this.DelRecord(strKeyId);
                ////const responseText2 = await this.BindGv_vSysSkill();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        //批量删除
        VDelMultiRecord(arrSkillIdVId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSysSkillVerWApi_js_1.SysSkillVer_DelSysSkillVersAsync)(arrSkillIdVId).then((jsonData) => {
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
        /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
    */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
            const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
            var objSysOperationType_Cond = new clsSysOperationTypeEN_js_1.clsSysOperationTypeEN(); //编辑区域
            var objSysSecurityLevel_Cond = new clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN(); //编辑区域
            const ddlOperationTypeId = await (0, clsSysOperationTypeWApi_js_1.SysOperationType_BindDdl_OperationTypeIdInDiv_Cache)(this.divName4List, "ddlOperationTypeId"); //编辑区域
            const ddlLevelId = await (0, clsSysSecurityLevelWApi_js_1.SysSecurityLevel_BindDdl_LevelIdInDiv_Cache)(this.divName4List, "ddlLevelId"); //编辑区域
            //文献类型；
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
        }
        // <summary>
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
                var strWhereCond = " skillId in (" + strKeyList + ")";
                var arrSysSkillObjLst = [];
                const responseText1 = await (0, clsSysSkillWApi_js_1.SysSkill_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrSysSkillObjLst = jsonData;
                    //查询是否有提交的数据
                    arrSysSkillObjLst = arrSysSkillObjLst.filter(x => x.isSubmit == true);
                    if (arrSysSkillObjLst.length > 0) {
                        alert("包含有已提交数据，不能删除！");
                        return "";
                    }
                });
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vSysSkill();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        //----------------------------------------------------------------论文部分
        /* 函数功能:在数据 列表中跳转到某一页 论文列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
    */
        //public IndexPageTwo(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.pageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //    this.BindGv_vPaper();
        //}
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
        CombinevPaperCondition() {
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
            //论文用户
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
            const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
            await objPage_Paper.BindGv_vPaper();
        }
        //查询论文列表
        async btnPaperQuery_Click() {
            const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
            await objPage_Paper.BindGv_vPaper();
        }
        //确定选择的论文 并添加到关系表中
        btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            $("#txtCitationId").val(strkeyId);
            //设置只读属性；
            $("#txtCitationId").attr("disabled", "disabled");
            //关闭列表
            HideDialogThree();
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
    exports.SysSkillCRUDEx = SysSkillCRUDEx;
    SysSkillCRUDEx.strid_CurrEduCls_Cache = "";
});
