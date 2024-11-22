(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Public_Concept.js", "../PagesBase/GraduateEduTopic/ConceptCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PConcepRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PConceptRela = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:WApiConceptCRUDEx
    表名:Concept(01120602)
    生成代码版本:2020.03.03.1
    生成日期:2020/03/09 13:58:58
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
    const Public_Concept_js_1 = require("../GraduateEduPublicPage/Public_Concept.js");
    const ConceptCRUD_js_1 = require("../PagesBase/GraduateEduTopic/ConceptCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsgs_OriginalPaperLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js");
    const clsgs_PConcepRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PConcepRelaEN.js");
    const clsConceptEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js");
    const clsvConceptEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js");
    const clsgs_OriginalPaperLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js");
    const clsgs_PConcepRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js");
    const clsConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js");
    const clsvConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* WApiConceptCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_PConceptRela extends ConceptCRUD_js_1.ConceptCRUD {
        constructor() {
            super(...arguments);
            //论文列表
            this.mstrListDivPaper = "divConceptDataLst";
            this.recCount = 0;
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortConceptBy: string = "conceptId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
    */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //const arrConcept_Cache = await vConcept_GetObjLstAsync("1=1");
                    //1、为下拉框设置数据源,绑定列表数据
                    //1、为下拉框设置数据源,绑定列表数据
                    ConceptCRUD_js_1.ConceptCRUD.sortConceptBy = "updDate Desc";
                    //var objConcept_Cond = await this.CombineConceptConditionObj();
                    //this.recCount = await vConcept_GetRecCountByCond_Cache(objConcept_Cond);
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_Concept_Cache();
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
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombineConceptCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            var strPaperId = $('#hidPaperId').val();
            var strConceptId = $("#hidConceptId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //获取用户缓存
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            var objConcept_Cond = new clsConceptEN_js_1.clsConceptEN();
            //只能查询提交的概念数据
            strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_IsSubmit} = 'true'`;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                var strPageType = $("#hidPageType").val();
                if (strPageType == "gs_TDR") {
                    if ($("#txtViewpointName_q").val() != "") {
                        strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_ConceptName} like '% ${$("#txtViewpointName_q").val()}%'`;
                    }
                    if ($("#txtViewUpdName_q").val() != "") {
                        var strUserName = $("#txtViewUpdName_q").val();
                        var objUser = arrUsers.find(x => x.userName == strUserName);
                        if (objUser != null) {
                            strWhereCond += " And ${clsvConceptEN.con_UpdUser} = '" + objUser.userId + "'";
                        }
                        //strWhereCond += ` And ${clsvConceptEN.con_UpdUser} like '% ${$("#txtViewUpdName_q").val()}%'`;
                    }
                    //strWhereCond += ` And conceptId not in (select conceptId from RTConceptRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
                }
                else {
                    if (this.conceptName_q != "") {
                        strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_ConceptName} like '% ${this.conceptName_q}%'`;
                        objConcept_Cond.SetCondFldValue(clsConceptEN_js_1.clsConceptEN.con_ConceptName, this.conceptName_q, "like");
                    }
                    var txtConceptUpdName_q = $("#txtConceptUpdName_q").val();
                    if (txtConceptUpdName_q != "") {
                        var objUser = arrUsers.find(x => x.userName == txtConceptUpdName_q);
                        if (objUser != null) {
                            strWhereCond += " And ${clsvConceptEN.con_UpdUser} = '" + objUser.userId + "'";
                            objConcept_Cond.SetCondFldValue(clsvConceptEN_js_1.clsvConceptEN.con_UpdUser, objUser.userId, "=");
                        }
                        // strWhereCond += ` And ${clsvConceptEN.con_UserName} like '% ${txtConceptUpdName_q}%'`;
                        //objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UserName, txtConceptUpdName_q, "like");
                    }
                    //排除获取已存在的关系数据 根据当前用户；
                    strWhereCond += ` And conceptId not in (select conceptId from gs_PConcepRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
    */
        async BindGv_Concept_Cache() {
            var strListDiv = this.mstrListDivPaper;
            var strWhereCond = await this.CombineConceptCondition();
            // var strWhereCond = JSON.stringify(objConceptEN_Sim);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvConceptObjLst = [];
            try {
                //this.recCount = Concept_GetRecCountByCond(objConcept_Cond);
                this.recCount = await (0, clsvConceptWApi_js_1.vConcept_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: ConceptCRUD_js_1.ConceptCRUD.sortConceptBy,
                    sortFun: (x, y) => { return 0; }
                };
                //  var arrConceptObjLst = Concept_GetObjLstByPager_Cache(objPagerPara);
                const responseObjLst = await (0, clsvConceptWApi_js_1.vConcept_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvConceptObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrConceptObjLst.length == 0) {
            //    var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=Concept)`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                //var strhtml = "";
                ////个人观点
                //strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';
                //strhtml += '<div><a href="#" title="当前论文相关概念">当前论文相关概念</a></div>';
                ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';
                //strhtml += '</div><ul class="artlist">';
                //var v = 0;//给内容加个序号
                //for (var i = 0; i < arrvConceptObjLst.length; i++) {
                //    //得到viewpointId；
                //    var strConceptId = arrvConceptObjLst[i].conceptId;
                //    v++;
                //    strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptName + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptContent + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvConceptObjLst[i].userName;
                //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvConceptObjLst[i].updDate;
                //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
                //    ////评论
                //    //strhtml += '&nbsp;&nbsp;评论数:' + arrvConceptObjLst[i].appraiseCount;
                //    ////评分
                //    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvConceptObjLst[i].score + '';
                //    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvConceptObjLst[i].teaScore + '';
                //    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvConceptObjLst[i].stuScore + '';
                //    //引用数
                //    strhtml += '&nbsp;&nbsp;被引用数:' + arrvConceptObjLst[i].citationCount;
                //    strhtml += '&nbsp;&nbsp;<button title="引用该相关概念" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkConceptInTab_Click("' + arrvConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关概念</button>';
                //    strhtml += '</li>';
                //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                //}
                //strhtml += '</ul></div>';
                var strHtml = await Public_Concept_js_1.Public_Concept.BindList_vConcept("02", arrvConceptObjLst);
                //拼接；
                $("#divConceptDataLst").html(strHtml);
                if (arrvConceptObjLst.length > 10) {
                    //$("#divPager2").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                //this.BindTab_Concept(strListDiv, arrConceptObjLst);
                console.log("完成BindGv_Concept!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示Concept对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrConceptObjLst">需要绑定的对象列表</param>
       */
        async BindTab_Concept(divContainer, arrConceptObjLst) {
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
                    fldName: "conceptName",
                    colHeader: "概念名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "conceptContent",
                    colHeader: "概念内容",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "isSubmit",
                //    colHeader: "是否提交",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
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
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnOkConceptInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
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
            (0, clsCommFunc4Web_js_1.BindTabV2Where)(o, arrConceptObjLst, arrDataColumn, "conceptId", "TopicConcept");
            //BindTab(o, arrConceptObjLst, arrDataColumn, "conceptId");
            if (arrConceptObjLst.length > 10) {
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        //概念查询按钮
        async btnConceptQuery_Click() {
            const responseObjList = await this.BindGv_Concept_Cache();
        }
        //分页数据
        /* 函数功能:在数据 列表中跳转到某一页 观点列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
    */
        IndexPageSeven(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.SetCurrPageIndex(intPageIndex);
            this.BindGv_Concept_Cache();
        }
        //添加观点 展示观点列表数据
        async btnAddConceptRela_Click() {
            const responseObjList = await this.BindGv_Concept_Cache();
        }
        //确定选择的观点 并添加到关系表中
        btnOkConceptInTab_Click(strkeyId) {
            //存放Id
            $("#hidConceptId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSave();
        }
        /* 添加新记录，保存函数
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            this.DivName = "divAddNewRecordSave";
            var strPaperId = $('#hidPaperId').val();
            var strConceptId = $("#hidConceptId").val();
            var strPaperLogTypeId = $('#hidPaperLogTypeId').val(); //流程日志参数
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objgs_PConcepRelaEN = new clsgs_PConcepRelaEN_js_1.clsgs_PConcepRelaEN();
            this.PutDataTogs_PConcepRelaClass(objgs_PConcepRelaEN);
            try {
                //同一主题 同一概念 只能添加一次；
                var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And conceptId = '" + strConceptId + "'";
                //var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And viewpointId = '" + strViewpointId + "'";
                const responseText = await (0, clsgs_PConcepRelaWApi_js_1.gs_PConcepRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题同一个用户不能重复添加同一个观点！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                else {
                    const responseText = await (0, clsgs_PConcepRelaWApi_js_1.gs_PConcepRela_AddNewRecordAsync)(objgs_PConcepRelaEN);
                    var returnBool = !!responseText;
                    if (returnBool == true) {
                        var strInfo = `添加记录成功!`;
                        $('#lblResult46').val(strInfo);
                        //查询 论文、日志类型是否存在；
                        var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And logTypeId = '" + strPaperLogTypeId + "'";
                        const responseText6 = await (0, clsgs_OriginalPaperLogWApi_js_1.gs_OriginalPaperLog_IsExistRecordAsync)(strWhere);
                        var bolIsExist = responseText6;
                        if (bolIsExist == true) {
                            return responseText6; //一定要有一个返回值，否则会出错！
                        }
                        else {
                            //添加论文日志；
                            const responseText7 = await this.Addgs_OriginalPaperLogSave().then((jsonData) => {
                            });
                        }
                        //根据ID获取最大数；
                        var strWhereCond2 = " 1 =1 and conceptId=" + strConceptId;
                        var intCitationCount = await (0, clsgs_PConcepRelaWApi_js_1.gs_PConcepRela_GetRecCountByCondAsync)(strWhereCond2);
                        var objConceptEN = new clsConceptEN_js_1.clsConceptEN();
                        objConceptEN.SetConceptId(strConceptId);
                        objConceptEN.SetCitationCount(intCitationCount);
                        objConceptEN.sf_UpdFldSetStr = objConceptEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                            throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                        }
                        const responseText = await (0, clsConceptWApi_js_1.Concept_UpdateRecordAsync)(objConceptEN).then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                            }
                            else {
                                var strInfo = `操作不成功!`;
                                alert(strInfo);
                                console.log("操作不成功");
                            }
                        });
                        //显示信息框
                        alert(strInfo);
                        HideDialogSeven();
                        RefreshWindow();
                    }
                    else {
                        var strInfo = `添加记录不成功!`;
                        $('#lblResult46').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                }
                return responseText; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //添加论文流程日志
        async Addgs_OriginalPaperLogSave() {
            var objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN();
            this.PutDataTogs_OriginalPaperLog(objgs_OriginalPaperLogEN);
            try {
                const responseText2 = await (0, clsgs_OriginalPaperLogWApi_js_1.gs_OriginalPaperLog_AddNewRecordAsync)(objgs_OriginalPaperLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    console.log("添加新建论文日志成功");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加日志记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        async PutDataTogs_OriginalPaperLog(pobjgs_OriginalPaperLogEN) {
            var strPaperId = $("#hidPaperId").val();
            var strPaperLogTypeId = $('#hidPaperLogTypeId').val(); //流程日志参数
            ////通过区分 是小组讨论还是同伴建议
            //var strPaperLogTypeId = $('#hidCommentTypeId').val();
            pobjgs_OriginalPaperLogEN.SetPaperId(strPaperId);
            pobjgs_OriginalPaperLogEN.SetLogTypeId(strPaperLogTypeId);
            pobjgs_OriginalPaperLogEN.SetLogDescription("添加子观点");
            //  $('#PaperLogTypeId').val("03");
            //switch (strPaperLogTypeId) {
            //    case "01":
            //        pobjgs_OriginalPaperLogEN.SetLogDescription( "添加子观点";
            //        break;
            //    case "02":
            //        pobjgs_OriginalPaperLogEN.SetLogDescription( "同伴建议";
            //        break;
            //    default:
            //        var strMsg = `没有数据处理！`;
            //        alert(strMsg);
            //        break;
            //}
            //pobjgs_OriginalPaperLogEN.SetLogDescription( "新建论文";
            pobjgs_OriginalPaperLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            pobjgs_OriginalPaperLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate());
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjgs_PConcepRelaEN">数据传输的目的类对象</param>
       */
        PutDataTogs_PConcepRelaClass(pobjgs_PConcepRelaEN) {
            var strPaperId = $("#hidPaperId").val();
            var strConceptId = $("#hidConceptId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjgs_PConcepRelaEN.SetPaperId(strPaperId); // 主题编号
            pobjgs_PConcepRelaEN.SetSectionId($("#ddlSectionId2").val()); // 主题编号
            pobjgs_PConcepRelaEN.SetConceptId(strConceptId); // 概念Id
            pobjgs_PConcepRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjgs_PConcepRelaEN.SetUpdUser(strUserId); // 修改用户Id
            pobjgs_PConcepRelaEN.SetMemo(this.memo); // 备注
        }
        /* 概念
      */
        async SortByConcept(strSortByFld) {
            if (ConceptCRUD_js_1.ConceptCRUD.sortConceptBy.indexOf(strSortByFld) >= 0) {
                if (ConceptCRUD_js_1.ConceptCRUD.sortConceptBy.indexOf("Asc") >= 0) {
                    ConceptCRUD_js_1.ConceptCRUD.sortConceptBy = `${strSortByFld} Desc`;
                }
                else {
                    ConceptCRUD_js_1.ConceptCRUD.sortConceptBy = `${strSortByFld} Asc`;
                }
            }
            else {
                ConceptCRUD_js_1.ConceptCRUD.sortConceptBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = this.BindGv_Concept_Cache();
        }
        /*
        * 设置取消按钮的标题
       */
        set btnCancel(value) {
            $("#btnCancel").html(value);
        }
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd(value) {
            $("#btnOKUpd").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd() {
            return $("#btnOKUpd").html();
        }
        /*
        * 概念内容
       */
        set conceptContent(value) {
            $("#txtConceptContent").val(value);
        }
        /*
        * 概念内容
       */
        get conceptContent() {
            return $("#txtConceptContent").val();
        }
        /*
        * 概念Id
       */
        set conceptId(value) {
            $("#txtConceptId").val(value);
        }
        /*
        * 概念Id
       */
        get conceptId() {
            return $("#txtConceptId").val();
        }
        /*
        * 概念名称
       */
        set conceptName(value) {
            $("#txtConceptName").val(value);
        }
        /*
        * 概念名称
       */
        get conceptName() {
            return $("#txtConceptName").val();
        }
        /*
        * 概念名称
       */
        get conceptName_q() {
            return $("#txtConceptName_q").val();
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
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortConceptBy(value) {
            $("#hidSortConceptBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortConceptBy() {
            return $("#hidSortConceptBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return clsPublocalStorage_js_1.clsPublocalStorage.userId;
        }
        /*
        * 是否提交
       */
        set isSubmit(value) {
            $("#chkIsSubmit").val(value);
        }
        /*
        * 是否提交
       */
        get isSubmit() {
            return $("#chkIsSubmit").prop("checked");
        }
        /*
        * 是否提交
       */
        get IsSubmit_q() {
            return $("#chkIsSubmit_q").prop("checked");
        }
        /*
        * 设置关键字的值
       */
        set keyId(value) {
            $("#hidKeyId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get keyId() {
            return $("#hidKeyId").val();
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
        * 设置操作类型：Add||Update||Detail
       */
        get opType() {
            return $("#hidOpType").val();
        }
        /*
        * 修改日期
       */
        set updDate(value) {
            $("#txtUpdDate").val(value);
        }
        /*
        * 修改日期
       */
        get updDate() {
            return $("#txtUpdDate").val();
        }
        /*
        * 修改用户Id
       */
        set updUser(value) {
            $("#txtUpdUser").val(value);
        }
        /*
        * 修改用户Id
       */
        get updUser() {
            return $("#txtUpdUser").val();
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
    }
    exports.gs_PConceptRela = gs_PConceptRela;
});
