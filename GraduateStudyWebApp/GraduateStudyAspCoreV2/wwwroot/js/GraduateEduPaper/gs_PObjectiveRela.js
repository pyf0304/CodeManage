(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Public_TopicObjective.js", "../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PTopicObjectiveRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PTopicObjectiveRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PObjectiveRela = void 0;
    const Public_TopicObjective_js_1 = require("../GraduateEduPublicPage/Public_TopicObjective.js");
    const TopicObjectiveCRUD_js_1 = require("../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsgs_OriginalPaperLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js");
    const clsgs_PTopicObjectiveRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PTopicObjectiveRelaEN.js");
    const clsTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js");
    const clsvTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js");
    const clsgs_OriginalPaperLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js");
    const clsgs_PTopicObjectiveRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PTopicObjectiveRelaWApi.js");
    const clsTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js");
    const clsvTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* WApiTopicObjective_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_PObjectiveRela extends TopicObjectiveCRUD_js_1.TopicObjectiveCRUD {
        constructor() {
            super(...arguments);
            //客观数据列表
            this.mstrListDivObjective = "divObjectiveDataLst";
            this.recCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    ////建立缓存
                    //
                    //const arrvTopicObjective_Cache = await vTopicObjective_GetObjLstAsync("1=1");
                    TopicObjectiveCRUD_js_1.TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";
                    ////用户下拉框绑定
                    //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                    ////文献类型；
                    //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                    //var strWhereCond = await this.CombinevTopicObjectiveCondition();
                    //const responseText = await vTopicObjective_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //});
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vTopicObjective();
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
        async CombinevTopicObjectiveCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            var strPaperId = $('#hidPaperId').val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var txtObjUpdName_q = $("#txtObjUpdName_q").val();
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //只能查询提交的客观数据
                strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_IsSubmit} = 'true'`;
                var strPageType = $("#hidPageType").val();
                if (strPageType == "gs_TDR") {
                    if ($("#txtViewpointName_q").val() != "") {
                        strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveName} like '% ${$("#txtViewpointName_q").val()}%'`;
                    }
                    if ($("#txtViewUpdName_q").val() != "") {
                        var strUserName = $("#txtViewUpdName_q").val();
                        var objUser = arrUsers.find(x => x.userName == strUserName);
                        if (objUser != null) {
                            strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser} = '${objUser.userId}'`;
                        }
                    }
                    var strhidObjectvieTypeId = $("#hidObjectiveTypeId").val();
                    if (strhidObjectvieTypeId != "") {
                        strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectvieTypeId}'`;
                    }
                    //strWhereCond += ` And topicObjectiveId not in (select topicObjectiveId from RTTopicObjectiveRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
                }
                else {
                    if (this.objectiveName_q != "") {
                        strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveName} like '% ${this.objectiveName_q}%'`;
                    }
                    if (txtObjUpdName_q != "") {
                        var strUserName = txtObjUpdName_q;
                        var objUser = arrUsers.find(x => x.userName == strUserName);
                        if (objUser != null) {
                            strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_UpdUser} = '${objUser.userId}'`;
                        }
                    }
                    //根据类型来查询；
                    //根据传入的hidObjectiveTypeId 来区分是事实或依据
                    var strhidObjectvieTypeId = $("#hidObjectiveTypeId").val();
                    if (strhidObjectvieTypeId != "") {
                        strWhereCond += ` And ${clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectvieTypeId}'`;
                    }
                    //排除获取已存在的关系数据 根据当前用户；
                    strWhereCond += ` And topicObjectiveId not in (select topicObjectiveId from gs_PTopicObjectiveRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
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
            var strListDiv = this.mstrListDivObjective;
            var strWhereCond = await this.CombinevTopicObjectiveCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvTopicObjectiveObjLst = [];
            try {
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
            try {
                //this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
                //var strPageType = $("#hidObjectiveTypeId").val();//页面参数
                //var strTitle = "";
                ////判断页面参数
                //if (strPageType == "01") {
                //    strTitle = "客观事实";
                //} else if (strPageType == "02") {
                //    //专家观点
                //    //$("#ListTitle").html("当前论文相关的专家观点");
                //    strTitle = "客观数据";
                //}
                //var strhtml = "";
                ////个人观点
                //strhtml += '<div class="info" id="infoFacts"><div class="title btn-5">';
                //strhtml += '<div><a href="#" title="' + strTitle + '">' + strTitle + '</a></div>';
                ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';
                //strhtml += '</div><ul class="artlist">';
                //var v = 0;//给内容加个序号
                //for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
                //    //得到viewpointId；
                //    var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
                //    v++;
                //    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                //    strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveContent + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].conclusion + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvTopicObjectiveObjLst[i].userName;
                //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvTopicObjectiveObjLst[i].updDate;
                //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
                //    ////评论
                //    //strhtml += '&nbsp;&nbsp;评论数:' + arrvTopicObjectiveObjLst[i].appraiseCount;
                //    ////评分
                //    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvTopicObjectiveObjLst[i].score + '';
                //    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvTopicObjectiveObjLst[i].teaScore + '';
                //    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvTopicObjectiveObjLst[i].stuScore + '';
                //    //引用数
                //    strhtml += '&nbsp;&nbsp;被引用数:' + arrvTopicObjectiveObjLst[i].citationCount;
                //    strhtml += '&nbsp;&nbsp;<button title="引用该' + strTitle + '" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkObjectiveInTab_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '") > <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';
                //    strhtml += '</li>';
                //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                //}
                //strhtml += '</ul></div>';
                var strPageType = $("#hidObjectiveTypeId").val(); //页面参数
                var strHtml = await Public_TopicObjective_js_1.Public_TopicObjective.BindList_vTopicObjective("02", strPageType, arrvTopicObjectiveObjLst);
                //拼接；
                $("#divObjectiveDataLst").html(strHtml);
                if (arrvTopicObjectiveObjLst.length > 10) {
                    //$("#divPager3").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                console.log("完成BindGv_vTopicObjective!");
                //this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
                //console.log("完成BindGv_vTopicObjective!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
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
                //{
                //    fldName: "paperTitle",
                //    colHeader: "论文标题",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "objectiveName",
                    colHeader: "客观名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "objectiveContent",
                    colHeader: "客观内容",
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
                    colHeader: "修改日期",
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
                        btn1.setAttribute("onclick", `btnOkObjectiveInTab_Click('${strKeyId}');`);
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
            //BindTab(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId");
            (0, clsCommFunc4Web_js_1.BindTabV2Where_V)(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId", "TopicObjectiveFact");
            if (arrvTopicObjectiveObjLst.length > 10) {
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            //this.objPager.recCount = this.recCount;
            //this.objPager.pageSize = this.pageSize;
            //this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //概念查询按钮
        async btnQueryObjective_Click() {
            //查询客观列表
            const responseObjList = await this.BindGv_vTopicObjective();
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
            this.BindGv_vTopicObjective();
        }
        //添加客观关系弹出客观列表按钮
        async btnAddTopicObjectiveRela_Click() {
            const responseObjList = await this.BindGv_vTopicObjective();
        }
        //确定选择的客观观点 并添加到关系表中
        btnOkObjectiveInTab_Click(strkeyId) {
            //存放Id
            $("#hidObjectiveId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSave();
        }
        /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            var strObjectiveId = $("#hidObjectiveId").val();
            var strPaperId = $('#hidPaperId').val();
            var strPaperLogTypeId = $('#hidPaperLogTypeId').val(); //流程日志参数
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            this.DivName = "divAddNewRecordSave";
            var objgs_PTopicObjectiveRelaEN = new clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN();
            this.PutDataTogs_PTopicObjectiveRelaClass(objgs_PTopicObjectiveRelaEN);
            try {
                //同一主题 同一客观事实 数据 只能添加一次；
                var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And topicObjectiveId = '" + strObjectiveId + "'";
                //var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And viewpointId = '" + strViewpointId + "'";
                const responseText = await (0, clsgs_PTopicObjectiveRelaWApi_js_1.gs_PTopicObjectiveRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题同一用户不能重复添加同一个客观事实数据！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                else {
                    const responseText = await (0, clsgs_PTopicObjectiveRelaWApi_js_1.gs_PTopicObjectiveRela_AddNewRecordAsync)(objgs_PTopicObjectiveRelaEN);
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
                        var strWhereCond2 = " 1 =1 and topicObjectiveId=" + strObjectiveId;
                        var intCitationCount = await (0, clsgs_PTopicObjectiveRelaWApi_js_1.gs_PTopicObjectiveRela_GetRecCountByCondAsync)(strWhereCond2);
                        var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
                        objTopicObjectiveEN.SetTopicObjectiveId(strObjectiveId);
                        objTopicObjectiveEN.SetCitationCount(intCitationCount);
                        objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                            throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                        }
                        const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN).then((jsonData) => {
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
                        HideDialogEight();
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
            //$('#PaperLogTypeId').val("02");
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
     <param name = "pobjgs_PTopicObjectiveRelaEN">数据传输的目的类对象</param>
    */
        PutDataTogs_PTopicObjectiveRelaClass(pobjgs_PTopicObjectiveRelaEN) {
            var strPaperId = $("#hidPaperId").val();
            var strObjectiveId = $("#hidObjectiveId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjgs_PTopicObjectiveRelaEN.SetPaperId(strPaperId); // 主题编号
            pobjgs_PTopicObjectiveRelaEN.SetSectionId($("#ddlSectionId3").val()); // 论文章节id
            pobjgs_PTopicObjectiveRelaEN.SetTopicObjectiveId(strObjectiveId); // 客观Id
            pobjgs_PTopicObjectiveRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjgs_PTopicObjectiveRelaEN.SetUpdUser(strUserId); // 修改人
            pobjgs_PTopicObjectiveRelaEN.SetMemo(this.memo); // 备注
        }
        async SortByObjectiveFact(strSortByFld) {
            if (TopicObjectiveCRUD_js_1.TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf(strSortByFld) >= 0) {
                if (TopicObjectiveCRUD_js_1.TopicObjectiveCRUD.sortvTopicObjectiveBy.indexOf("Asc") >= 0) {
                    TopicObjectiveCRUD_js_1.TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Desc`;
                }
                else {
                    TopicObjectiveCRUD_js_1.TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
                }
            }
            else {
                TopicObjectiveCRUD_js_1.TopicObjectiveCRUD.sortvTopicObjectiveBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vTopicObjective();
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
        * 结论
       */
        set conclusion(value) {
            $("#txtconclusion").val(value);
        }
        /*
        * 结论
       */
        get conclusion() {
            return $("#txtconclusion").val();
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
        set hidSortvTopicObjectiveBy(value) {
            $("#hidSortvTopicObjectiveBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvTopicObjectiveBy() {
            return $("#hidSortvTopicObjectiveBy").val();
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
        * 客观内容
       */
        set objectiveContent(value) {
            $("#txtObjectiveContent").val(value);
        }
        /*
        * 客观内容
       */
        get objectiveContent() {
            return $("#txtObjectiveContent").val();
        }
        /*
        * 客观名称
       */
        set objectiveName(value) {
            $("#txtObjectiveName").val(value);
        }
        /*
        * 客观名称
       */
        get objectiveName() {
            return $("#txtObjectiveName").val();
        }
        /*
        * 客观名称
       */
        get objectiveName_q() {
            return $("#txtObjectiveName_q").val();
        }
        /*
        * 客观类型
       */
        set objectiveType(value) {
            $("#txtObjectiveType").val(value);
        }
        /*
        * 客观类型
       */
        get objectiveType() {
            return $("#txtObjectiveType").val();
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
        * 来源Id
       */
        set sourceId(value) {
            $("#txtSourceId").val(value);
        }
        /*
        * 来源Id
       */
        get sourceId() {
            return $("#txtSourceId").val();
        }
        /*
        * 客观Id
       */
        set topicObjectiveId(value) {
            $("#txtTopicObjectiveId").val(value);
        }
        /*
        * 客观Id
       */
        get topicObjectiveId() {
            return $("#txtTopicObjectiveId").val();
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
    }
    exports.gs_PObjectiveRela = gs_PObjectiveRela;
});
