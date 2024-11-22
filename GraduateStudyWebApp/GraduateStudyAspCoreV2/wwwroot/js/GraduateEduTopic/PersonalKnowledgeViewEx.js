(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperSubViewpointCRUD.js", "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PersonalKnowledgeViewEx = void 0;
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const PaperSubViewpointCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperSubViewpointCRUD.js");
    const clsvConceptEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js");
    const clsvSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js");
    const clsvSysSocialRelationsEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js");
    const clsvTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js");
    const clsvViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsvConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsvSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js");
    const clsvSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js");
    const clsvTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsvViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PersonalKnowledgeViewEx extends PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD {
        constructor() {
            super(...arguments);
            //观点列表
            this.mstrListDivViewpoint = "divViewpointDataLst";
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
            //用户列表
            this.mstrListDivUser = "divUserDataLst";
            //研究计划
            this.mstrListDivResearchPlan = "divResearchPlanDataLst";
            //布置任务
            this.mstrListDivgs_TeacherTask = "divgs_TeacherTaskDataLst";
            //主题用户关系
            this.mstrListDivRtUserRela = "divRtUserRelaDataLst";
            //个人观点关系
            this.mstrListDivRtViewPointRela = "divRtViewPointRelaDataLst";
            //专家观点
            this.mstrListDivRtExpertViewPointRela = "divRtExpertViewPointRelaDataLst";
            //主题引用论文关系
            //public mstrListDivRtPaperRela: string = "divRtPaperRelaDataLst";
            this.mstrListDivRtCitedPaperRela = "divRtCitedPaperRelaDataLst";
            //主题自研论文关系
            this.mstrListDivRtOriginalPaperRela = "divRtOriginalPaperRelaDataLst";
            //概念
            this.mstrListConceptDivPaper = "divRtConceptRelaDataLst";
            //客观事实
            this.mstrListTopicObjectiveDivPaper = "divRtTopicObjectiveDataLst";
            //客观依据
            this.mstrListBasisTopicObjectiveDivPaper = "divBasisRtTopicObjectiveDataLst";
            //研究结果
            this.mstrListResearchResultDivPaper = "divRtResearchResultDataLst";
            //技能
            this.mstrListSysskillDivPaper = "divSysskillDataLst";
            //社会关系
            this.mstrListSysSocialRelaDivPaper = "divRtSysSocialRelaLst";
            this.strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            this.recCount = 0;
        }
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
                    this.hidSortBy = "updDate Desc";
                    //读取session角色 来判断绑定不同数据列表
                    //获取用户角色来判断显示不同的列表数据；
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    $("#hidRoleId").val(clsPublocalStorage_js_1.clsPublocalStorage.roleId);
                    $("#hidId_CurrEduCls").val(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                    //管理员 判断角色 
                    if ($("#hidRoleId").val() == "00620001") {
                        $("#btnDelRecord").show();
                        $("#tab4Bind tr").find("td:eq(8)").show();
                    }
                    else {
                        //学生00620003 教师 
                        $("#btnDelRecord").hide();
                        $("#tab4Bind tr").find("td:eq(8)").hide();
                    }
                    const gvResult = await this.GetAllFunctionMethod();
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
        //得到3个关系列表数据；
        async GetAllFunctionMethod() {
            //如果是点击了树菜单、或者是刷新，那么需要做样式控制；
            //首先要去掉ul下 li a 样式
            $("#myTab li a").removeClass();
            $("#myTab li").removeClass();
            //判断根据序号显示不同的数据源
            var strnum = $("#hidTabNum").val();
            if (strnum == "1") {
                $("#liPaper").addClass("active");
                $("#liPaper a").addClass("active");
                $("#li_Paper ").addClass("in active show");
                //论文
                this.BindGv_vPaper();
            }
            else if (strnum == "2") {
                $("#liPaperReadWrite").addClass("active");
                $("#liPaperReadWrite a").addClass("active");
                $("#li_PaperReadWrite ").addClass("in active show");
                //论文读写
                this.BindGv_vPaperReadWrite();
            }
            else if (strnum == "3") {
                $("#liPaperSubViewpoint").addClass("active");
                $("#liPaperSubViewpoint a").addClass("active");
                $("#li_PaperSubViewpoint ").addClass("in active show");
                //论文子观点
                this.BindGv_vPaperSubViewpoint();
            }
            else if (strnum == "4") {
                $("#liViewpoint").addClass("active");
                $("#liViewpoint a").addClass("active");
                $("#li_Viewpoint ").addClass("in active show");
                //个人观点关系；
                this.BindGv_vViewpoint();
            }
            else if (strnum == "5") {
                $("#liExpertViewpoint").addClass("active");
                $("#liExpertViewpoint a").addClass("active");
                $("#li_ExpertViewpoint ").addClass("in active show");
                //专家观点
                this.BindGv_vExpertViewpoint();
            }
            else if (strnum == "6") {
                $("#liConcept").addClass("active");
                $("#liConcept a").addClass("active");
                $("#li_Concept ").addClass("in active show");
                //主题概念关系
                this.BindGv_Concept_Cache();
            }
            else if (strnum == "7") {
                $("#liObjectiveFact").addClass("active");
                $("#liObjectiveFact a").addClass("active");
                $("#li_Objective ").addClass("in active show");
                //客观事实关系
                this.BindGv_vTopicObjective();
            }
            else if (strnum == "8") {
                $("#liObjectiveBasis").addClass("active");
                $("#liObjectiveBasis a").addClass("active");
                $("#li_ObjectiveBasis ").addClass("in active show");
                //客观依据关系
                this.BindGv_vTopicObjectiveBasis();
            }
            else if (strnum == "9") {
                $("#liSysskill").addClass("active");
                $("#liSysskill a").addClass("active");
                $("#liSysskill ").addClass("in active show");
                //技能
                this.BindGv_vSysSkill();
            }
            else if (strnum == "10") {
                $("#liSysSocialRela").addClass("active");
                $("#liSysSocialRela a").addClass("active");
                $("#liSysSocialRela ").addClass("in active show");
                //社会关系
                this.BindGv_vSysSocialRelations();
            }
            else {
                $("#liPaper").addClass("active");
                $("#liPaper a").addClass("active");
                $("#li_Paper ").addClass("in active show");
                //论文
                this.BindGv_vPaper();
            }
        }
        /* 函数功能:在数据 列表中跳转到某一页
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
    */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            //this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.SetCurrPageIndex(intPageIndex);
            //判断根据序号显示不同的数据源
            var strnum = $("#hidTabNum").val();
            if (strnum == "1") {
                //论文
                this.BindGv_vPaper();
            }
            else if (strnum == "2") {
                //论文读写
                this.BindGv_vPaperReadWrite();
            }
            else if (strnum == "3") {
                //论文子观点
                this.BindGv_vPaperSubViewpoint();
            }
            else if (strnum == "4") {
                //个人观点关系；
                this.BindGv_vViewpoint();
            }
            else if (strnum == "5") {
                //专家观点
                this.BindGv_vExpertViewpoint();
            }
            else if (strnum == "6") {
                //主题概念关系
                this.BindGv_Concept_Cache();
            }
            else if (strnum == "7") {
                //客观事实关系
                this.BindGv_vTopicObjective();
            }
            else if (strnum == "8") {
                //客观依据关系
                this.BindGv_vTopicObjectiveBasis();
            }
            else if (strnum == "9") {
                //技能
                this.BindGv_vSysSkill();
            }
            else if (strnum == "10") {
                //社会关系
                this.BindGv_vSysSocialRelations();
            }
            else {
                //论文
                this.BindGv_vPaper();
            }
        }
        //论文
        async liPaperClick() {
            try {
                const gvResultPaper = await this.BindGv_vPaper();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //论文读写
        async liPaperReadWriteClick() {
            try {
                const gvResultPaper = await this.BindGv_vPaperReadWrite();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //论文子观点
        async liPaperSubViewpointClick() {
            try {
                const gvResultPaper = await this.BindGv_vPaperSubViewpoint();
                if (this.recCount > 10) {
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //个人观点
        async liViewpointClick() {
            try {
                const gvResultPaper = await this.BindGv_vViewpoint();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //专家观点
        async liExpertViewpointClick() {
            try {
                const gvResultPaper = await this.BindGv_vExpertViewpoint();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //概念
        async liConceptClick() {
            try {
                const gvResultPaper = await this.BindGv_Concept_Cache();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //客观事实
        async liObjectiveFactClick() {
            try {
                const gvResultPaper = await this.BindGv_vTopicObjective();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //客观数据
        async liObjectiveBasisClick() {
            try {
                const gvResultPaper = await this.BindGv_vTopicObjectiveBasis();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //技能
        async liSysskillClick() {
            try {
                const gvResultPaper = await this.BindGv_vSysSkill();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //社会关系
        async liSysSocialRelationsClick() {
            try {
                const gvResultPaper = await this.BindGv_vSysSocialRelations();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
    */
        async CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //判断角色//管理员
                    var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                    if (strRoleId == "00620001") {
                    }
                    else if (strRoleId == "00620002") {
                    }
                    else {
                        //学生00620003
                        strWhereCond += ` And updUser = '${strUserId}'`;
                    }
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vPaper() {
            // var strListDiv: string = this.mstrListDiv;
            var strWhereCond = await this.CombinevPaperCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperExObjLst = [];
            try {
                this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                const response = await this.BindTab_vPaper(arrPaperExObjLst);
                if (this.recCount > 10) {
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                console.log("完成BindGv_vPaper!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        async BindTab_vPaper(arrPaperExObjLst) {
            var strhtml = '';
            strhtml += '<div class="info" id="infoPaper"><div class="title btn-3"><ul class="artlist">';
            var p = 0; //给内容加个序号
            for (var i = 0; i < arrPaperExObjLst.length; i++) {
                p++;
                //    var strPaperId = arrPaperExObjLst[i].paperId;
                //判断引用论文，自研论文
                if (arrPaperExObjLst[i].paperTypeId == "02") {
                    strhtml += '<li><span class="rowtit color3">' + p + '.[标题]：</span><span class="abstract-text">' + arrPaperExObjLst[i].paperTitle + '(' + arrPaperExObjLst[i].paperTypeName + ')</span></li>';
                }
                else {
                    strhtml += '<li><span class="rowtit color3">' + p + '.[标题]：</span><span class="abstract-text">' + arrPaperExObjLst[i].paperTitle + '(' + arrPaperExObjLst[i].paperTypeName + ')</span></li>';
                }
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[研究问题]：</span><span class="abstract-text">' + arrPaperExObjLst[i].researchQuestion + '</span><span class="rowtit color3">[关键字]：</span><span class="abstract-text">' + arrPaperExObjLst[i].keyword + '</span></li>';
            }
            strhtml += '</ul></div>';
            $("#divRtCitedPaperRelaDataLst").html(strhtml);
        }
        //////--------------------------------------论文读写
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        async CombinevPaperReadWriteCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //// 02 代表论文写作
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strRoleId == "00620001") {
                }
                //判断角色 //学生00620003
                else if (strRoleId == "00620002") {
                }
                else {
                    //只能查看自己的数据；或公开的数据；学生
                    strWhereCond += ` And updUser = '${strUserId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vPaperReadWrite() {
            //var strListDiv: string = this.mstrListDiv;
            var strWhereCond = await this.CombinevPaperReadWriteCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvPaperReadWriteObjLst = [];
            try {
                this.recCount = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperReadWriteObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vPaperReadWrite(arrvPaperReadWriteObjLst);
                console.log("完成BindGv_vPaperReadWrite!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        async BindTab_vPaperReadWrite(arrvPaperReadWriteObjLst) {
            var strhtml = '';
            strhtml += '<div class="info" id="infoPaper"><div class="title btn-3"><ul class="artlist">';
            var p = 0; //给内容加个序号
            for (var i = 0; i < arrvPaperReadWriteObjLst.length; i++) {
                p++;
                var strPaperId = arrvPaperReadWriteObjLst[i].paperId;
                //判断引用论文，自研论文
                if (arrvPaperReadWriteObjLst[i].operationTypeId == "02") {
                    strhtml += '<li><span class="rowtit color3">' + p + '.[标题]：</span><span class="abstract-text">' + arrvPaperReadWriteObjLst[i].paperTitle + '(' + arrvPaperReadWriteObjLst[i].operationTypeName + ')</span></li>';
                }
                else {
                    strhtml += '<li><span class="rowtit color3">' + p + '.[标题]：</span><span class="abstract-text">' + arrvPaperReadWriteObjLst[i].paperTitle + '(' + arrvPaperReadWriteObjLst[i].operationTypeName + ')</span></li>';
                }
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[研究问题]：</span><span class="abstract-text">' + arrvPaperReadWriteObjLst[i].researchQuestion + '</span><span class="rowtit color3">[关键字]：</span><span class="abstract-text">' + arrvPaperReadWriteObjLst[i].keyword + '</span></li>';
            }
            strhtml += '</ul></div>';
            $("#divPaperReadWriteDataLst").html(strhtml);
            if (this.recCount > 10) {
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        //-------------------------------------------------------论文子观点
        async CombinevPaperSubViewpointCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //// 02 代表论文写作
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strRoleId == "00620001") {
                }
                //判断角色 //学生00620003
                else if (strRoleId == "00620002") {
                }
                else {
                    //只能查看自己的数据；或公开的数据；学生
                    strWhereCond += ` And updUser = '${strUserId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vPaperSubViewpoint() {
            //var strListDiv: string = this.mstrListDiv;
            var strWhereCond = await this.CombinevPaperSubViewpointCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvPaperSubViewpointObjLst = [];
            try {
                this.recCount = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperSubViewpointObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                const response = await this.BindTab_vPaperSubViewpoint1(arrvPaperSubViewpointObjLst);
                console.log("完成BindGv_vPaperReadWrite!");
                if (this.recCount > 10) {
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        async BindTab_vPaperSubViewpoint1(arrvPaperSubViewpointObjLst) {
            var strhtml = '';
            strhtml += '<div class="info" id="infoPaper"><div class="title btn-3"></div><ul class="artlist">';
            var p = 0; //给内容加个序号
            for (var i = 0; i < arrvPaperSubViewpointObjLst.length; i++) {
                p++;
                // var strPaperId = arrvPaperSubViewpointObjLst[i].subViewpointId;
                //判断引用论文，自研论文
                strhtml += '<li><span class="rowtit color3">' + p + '.[观点类型]：</span><span class="abstract-text">' + arrvPaperSubViewpointObjLst[i].subViewpointTypeName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvPaperSubViewpointObjLst[i].subViewpointContent + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">' + arrvPaperSubViewpointObjLst[i].explainTypeName + '：</span><span class="abstract-text">' + arrvPaperSubViewpointObjLst[i].explainContent + '</span></li>';
            }
            strhtml += '</ul></div>';
            $("#divPaperSubViewpointDataLst").html(strhtml);
        }
        //-----------------------------------------------------------------------------个人观点
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        async CombinevViewpointCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //var strhidUserTypeId = $("#hidUserTypeId").val();
                //if (strhidUserTypeId != "") {
                //    strWhereCond += ` And ${clsvViewpointEN.con_UserTypeId} = '${strhidUserTypeId}'`;
                //}
                strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_UserTypeId} = '01'`;
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#btnDelRecord").show();
                    $("#btnCancelSubmit").show();
                }
                else if (strRoleId == "00620002") {
                    //教师
                }
                else {
                    //学生00620003 00620002教师
                    strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_UpdUser} = '${strUserId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vViewpoint() {
            // var strListDiv: string = this.mstrListDiv;
            var strWhereCond = await this.CombinevViewpointCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvViewpointObjLst = [];
            try {
                this.recCount = await (0, clsvViewpointWApi_js_1.vViewpoint_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvViewpointObjLst = jsonData;
                });
                //换行符
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //个人观点
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvViewpointObjLst.length; i++) {
                    //得到viewpointId；
                    var strViewpointId = arrvViewpointObjLst[i].viewpointId;
                    v++;
                    //对内容进行换行替换
                    var strViewpointContent = arrvViewpointObjLst[i].viewpointContent;
                    var strReason = arrvViewpointObjLst[i].reason;
                    strViewpointContent = strViewpointContent.replace(/\r\n/g, strBr);
                    strViewpointContent = strViewpointContent.replace(/\n/g, strBr);
                    strReason = strReason.replace(/\r\n/g, strBr);
                    strReason = strReason.replace(/\n/g, strBr);
                    strhtml += '<li><span class="rowtit color3">[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointTypeName + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
                    //类型+理由
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';
                    //strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[来源]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].source + '</span></li>';
                    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">';
                    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].updDate + '</span>';
                    //判断ture 、false
                    if (arrvViewpointObjLst[i].isSubmit == true) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                    }
                    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divRtViewPointRelaDataLst").html(strhtml);
                if (this.recCount >= 10) {
                    $("#divPagerViewpoint").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //----------------------------------------------------专家观点
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        CombinevExpertViewpointCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_UserTypeId} = '02'`;
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#btnDelRecord").show();
                    $("#btnCancelSubmit").show();
                }
                else if (strRoleId == "00620002") {
                    //教师
                }
                else {
                    //学生00620003 00620002教师
                    strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_UpdUser} = '${strUserId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vExpertViewpoint() {
            // var strListDiv: string = this.mstrListDiv;
            var strWhereCond = await this.CombinevExpertViewpointCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvViewpointObjLst = [];
            try {
                this.recCount = await (0, clsvViewpointWApi_js_1.vViewpoint_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvViewpointObjLst = jsonData;
                });
                //换行符
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //个人观点
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvViewpointObjLst.length; i++) {
                    //得到viewpointId；
                    var strViewpointId = arrvViewpointObjLst[i].viewpointId;
                    v++;
                    //对内容进行换行替换
                    var strViewpointContent = arrvViewpointObjLst[i].viewpointContent;
                    var strReason = arrvViewpointObjLst[i].reason;
                    strViewpointContent = strViewpointContent.replace(/\r\n/g, strBr);
                    strViewpointContent = strViewpointContent.replace(/\n/g, strBr);
                    strReason = strReason.replace(/\r\n/g, strBr);
                    strReason = strReason.replace(/\n/g, strBr);
                    strhtml += '<li><span class="rowtit color3">[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
                    //类型+理由
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';
                    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">';
                    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].updDate + '</span>';
                    //判断ture 、false
                    if (arrvViewpointObjLst[i].isSubmit == true) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                    }
                    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divRtExpertViewPointRelaDataLst").html(strhtml);
                if (this.recCount >= 10) {
                    $("#divExpertPagerViewpoint").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //--------------------------------------------------------------------概念
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
    <returns>条件串(strWhereCond)</returns>
    */
        CombineConceptConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objConcept_Cond = new clsvConceptEN_js_1.clsvConceptEN();
            objConcept_Cond.SetCondFldValue(clsvConceptEN_js_1.clsvConceptEN.con_id_CurrEduCls, clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls, "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                }
                else {
                    $("#btnCancelSubmit").hide();
                    //学生； 
                    strWhereCond += ` And ${clsvConceptEN_js_1.clsvConceptEN.con_UpdUser} = '${strUserId}'`;
                    objConcept_Cond.SetCondFldValue(clsvConceptEN_js_1.clsvConceptEN.con_UpdUser, strUserId, "=");
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objConcept_Cond;
        }
        /* 根据条件获取相应的对象列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
    */
        async BindGv_Concept_Cache() {
            var objConcept_Cond = this.CombineConceptConditionObj();
            var strWhereCond = JSON.stringify(objConcept_Cond);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrConceptObjLst = [];
            try {
                this.recCount = await (0, clsvConceptWApi_js_1.vConcept_GetRecCountByCond_Cache)(objConcept_Cond, clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                //this.recCount = await vConcept_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //});
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrConceptObjLst = await (0, clsvConceptWApi_js_1.vConcept_GetObjLstByPager_Cache)(objPagerPara, clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                //const responseObjLst = await vConcept_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrConceptObjLst = <Array<clsvConceptEN>>jsonData;
                //});
                //换行符
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //个人观点
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrConceptObjLst.length; i++) {
                    //得到conceptId；
                    var strConceptId = arrConceptObjLst[i].conceptId;
                    v++;
                    //对内容进行换行替换
                    var strConceptContent = arrConceptObjLst[i].conceptContent;
                    strConceptContent = strConceptContent.replace(/\r\n/g, strBr);
                    strConceptContent = strConceptContent.replace(/\n/g, strBr);
                    //strhtml += v + ".观点：" + arrConceptObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrConceptObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrConceptObjLst[i].viewpointTypeName + ":" + arrConceptObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrConceptObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                    strhtml += '<li><span class="rowtit color3">[概念名称]：</span><span class="abstract-text">' + arrConceptObjLst[i].conceptName + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[概念内容]：</span><span class="abstract-text">' + strConceptContent + '</span></li>';
                    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:70%;">';
                    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrConceptObjLst[i].updDate + '</span>';
                    //判断ture 、false
                    if (arrConceptObjLst[i].isSubmit == true) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                    }
                    strhtml += '</li>';
                    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divRtConceptRelaDataLst").html(strhtml);
                if (this.recCount >= 10) {
                    $("#divPagerConcept").show();
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
            if (this.recCount >= 10) {
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        //-----------------------------------------------------客观事实
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
                //判断客观类型 区分是客观事实、客观依据
                strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType} = '01'`;
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser} = '${strUserId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineTopicObjectiveCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vTopicObjective() {
            var strWhereCond = await this.CombinevTopicObjectiveCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvTopicObjectiveObjLst = [];
            try {
                this.recCount = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvTopicObjectiveObjLst = jsonData;
                });
                //换行符
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //个人观点
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
                    //得到topicObjectiveId；
                    var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
                    v++;
                    //对内容进行换行替换
                    var strObjectiveContent = arrvTopicObjectiveObjLst[i].objectiveContent;
                    var strConclusion = arrvTopicObjectiveObjLst[i].conclusion;
                    strObjectiveContent = strObjectiveContent.replace(/\r\n/g, strBr);
                    strObjectiveContent = strObjectiveContent.replace(/\n/g, strBr);
                    strConclusion = strConclusion.replace(/\r\n/g, strBr);
                    strConclusion = strConclusion.replace(/\n/g, strBr);
                    //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                    strhtml += '<li><span class="rowtit color3">[客观名称]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[客观内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';
                    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">';
                    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].updDate + '</span>';
                    //判断ture 、false
                    if (arrvTopicObjectiveObjLst[i].isSubmit == true) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                    }
                    strhtml += '</li>';
                    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divRtTopicObjectiveDataLst").html(strhtml);
                if (this.recCount >= 10) {
                    $("#divPagerObjective").show();
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
        }
        //-----------------------------------------------------------------客观数据
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        CombinevTopicObjectiveBasisCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断客观类型 区分是客观事实、客观依据
                strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType} = '02'`;
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                }
                else {
                    //学生； 
                    strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser} = '${strUserId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineTopicObjectiveCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vTopicObjectiveBasis() {
            var strWhereCond = await this.CombinevTopicObjectiveBasisCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvTopicObjectiveObjLst = [];
            try {
                this.recCount = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvTopicObjectiveObjLst = jsonData;
                });
                //换行符
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //个人观点
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
                    //得到topicObjectiveId；
                    var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
                    v++;
                    //对内容进行换行替换
                    var strObjectiveContent = arrvTopicObjectiveObjLst[i].objectiveContent;
                    var strConclusion = arrvTopicObjectiveObjLst[i].conclusion;
                    strObjectiveContent = strObjectiveContent.replace(/\r\n/g, strBr);
                    strObjectiveContent = strObjectiveContent.replace(/\n/g, strBr);
                    strConclusion = strConclusion.replace(/\r\n/g, strBr);
                    strConclusion = strConclusion.replace(/\n/g, strBr);
                    //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                    strhtml += '<li><span class="rowtit color3">[客观名称]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[客观内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';
                    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">';
                    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].updDate + '</span>';
                    //判断ture 、false
                    if (arrvTopicObjectiveObjLst[i].isSubmit == true) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                    }
                    strhtml += '</li>';
                    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divBasisRtTopicObjectiveDataLst").html(strhtml);
                if (this.recCount >= 10) {
                    $("#divPagerBasis").show();
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
        }
        //-------------------------------------------------技能
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
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                }
                else {
                    //学生 教师；
                    strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} = '${strUserId}'`;
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
            var strWhereCond = await this.CombinevSysSkillCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvSysSkillObjLst = [];
            try {
                this.recCount = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrvSysSkillObjLst = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetObjLstByPagerAsync)(objPagerPara);
                //换行符
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //技能
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvSysSkillObjLst.length; i++) {
                    //得到skillId；
                    var strSkillId = arrvSysSkillObjLst[i].skillId;
                    v++;
                    var strProcess = arrvSysSkillObjLst[i].process;
                    strProcess = strProcess.replace(/\r\n/g, strBr);
                    strProcess = strProcess.replace(/\n/g, strBr);
                    //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                    strhtml += '<li><span class="rowtit color3">[技能名称]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].skillName + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[实施过程]：</span><span class="abstract-text">' + strProcess + '</span></li>';
                    //strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].conclusion + '</span></li>';
                    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">';
                    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].updDate + '</span>';
                    strhtml += '</li>';
                    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divSysskillDataLst").html(strhtml);
                if (this.recCount >= 10) {
                    $("#divPagerSysskill").show();
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
        }
        //-------------------------------------------------------------社会关系
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vSysSocialRelations() {
            var strWhereCond = await this.CombinevSysSocialRelationsCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvSysSocialRelationsObjLst = [];
            try {
                this.recCount = await (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrvSysSocialRelationsObjLst = await (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_GetObjLstByPagerAsync)(objPagerPara);
                //换行符
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //社会关系
                strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                strhtml += '</div><ul class="artlist">';
                var v = 0; //给内容加个序号
                for (var i = 0; i < arrvSysSocialRelationsObjLst.length; i++) {
                    //得到socialId；
                    var strSocialId = arrvSysSocialRelationsObjLst[i].socialId;
                    v++;
                    var strDetailedDescription = arrvSysSocialRelationsObjLst[i].detailedDescription;
                    strDetailedDescription = strDetailedDescription.replace(/\r\n/g, strBr);
                    strDetailedDescription = strDetailedDescription.replace(/\n/g, strBr);
                    //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].fullName + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].nationality + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].workUnit + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].major + '</span></li>';
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].achievement + '</span></li>';
                    strhtml += '<li><span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + strDetailedDescription + '</span></li>';
                    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">';
                    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].updDate + '</span>';
                    //判断ture 、false
                    if (arrvSysSocialRelationsObjLst[i].isSubmit == true) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                    }
                    strhtml += '</li>';
                    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';
                //拼接；
                $("#divSysSocialRelaDataLst").html(strhtml);
                if (this.recCount >= 10) {
                    $("#divPagerSysSocialRela").show();
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
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevSysSocialRelationsCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                }
                else {
                    //学生 教师；
                    strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdUser} = '${strUserId}'`;
                    //strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} = '${objvUserRoleRelation.userId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysSocialRelationsCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
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
    * 设置排序字段-相当使用ViewState功能  主题用户关系
    */
        set hidSortBy(value) {
            $("#hidSortBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortBy() {
            return $("#hidSortBy").val();
        }
    }
    exports.PersonalKnowledgeViewEx = PersonalKnowledgeViewEx;
});
