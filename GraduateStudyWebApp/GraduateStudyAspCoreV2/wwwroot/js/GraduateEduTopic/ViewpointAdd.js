///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
//import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/PubFun/clsCommFunc4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js", "../PagesBase/GraduateEduTopic/ResearchTopicCRUD.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubConfig/clsPrivateSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ViewpointAdd = void 0;
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    //import { clsvRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js";
    const clsvRTViewpointRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js");
    const clsRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js");
    const clsvRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js");
    const ResearchTopicCRUD_js_1 = require("../PagesBase/GraduateEduTopic/ResearchTopicCRUD.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    /* ResearchTopic_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class ViewpointAdd extends ResearchTopicCRUD_js_1.ResearchTopicCRUD {
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
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strUserId != "") {
                    //  const ddl_OperationTypeId = await this.BindDdl_OperationTypeId("ddlOperationTypeId");
                    //1、为下拉框设置数据源,绑定列表数据
                    this.hidSortResearchTopicBy = "topicName Asc";
                    this.hidSortvRTViewpointRelaBy = "viewpointName Asc";
                    //2、显示无条件的表内容在GridView中
                    $("#hidUserId").val(strUserId);
                    //var strWhereCond = await this.CombineResearchTopicCondition();
                    //const responseText = await ResearchTopic_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //});
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vRTViewpointRela();
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
        /* 根据条件获取相应的记录对象的列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async btnQuery_Click() {
            var strWhereCond = await this.CombinevRTViewpointRelaCondition();
            try {
                this.recCount = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvRTViewpointRelaBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvRTViewpointRelaObjLst = jsonData;
                    this.BindTab_vRTViewpointRela(this.mstrListDiv, arrvRTViewpointRelaObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        btnokRecord_Click_pyf() {
            //this.AddNewRecordSave();
        }
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        async CombinevRTViewpointRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strviewpointId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId; //得到主题id
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.viewpointName_q != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
                }
                //if (this.viewpointTypeId_q != "" && this.viewpointTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointTypeId} = '${this.viewpointTypeId_q}'`;
                //}
                if (this.topicName_q != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
                }
                //根据观点查询关系;
                if (strviewpointId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointId} = '${strviewpointId}'`;
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#btnDelRecord").show();
                }
                else {
                    //学生； //教师
                    $("#btnDelRecord").show();
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdUser} = '${strUserId}'`;
                    //学生00620003
                    // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vRTViewpointRela() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = await this.CombinevRTViewpointRelaCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvRTViewpointRelaObjLst = [];
            try {
                this.recCount = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvRTViewpointRelaBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvRTViewpointRelaObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvRTViewpointRelaObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vRTViewpointRela(strListDiv, arrvRTViewpointRelaObjLst);
                console.log("完成BindGv_vRTViewpointRela!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
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
                var bolresult = false;
                var strKeyList;
                if (arrKeyIds.length == 0)
                    return "";
                strKeyList = "";
                for (var i = 0; i < arrKeyIds.length; i++) {
                    if (i == 0)
                        strKeyList = strKeyList + "" + arrKeyIds[i].toString() + "";
                    else
                        strKeyList += "," + "" + arrKeyIds[i].toString() + "";
                }
                // 删除RTViewpointRela本表中与当前对象有关的记录
                var strWhereCond = " mId in (" + strKeyList + ")";
                var arrvRTViewpointRelaObjLst = [];
                const responseObjLst = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvRTViewpointRelaObjLst = jsonData;
                    //循环列表，判断数据是否是当前用户 ，是则可以删除；
                    //判断权限、管理员教师可以删除、
                    var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                    //管理员 判断角色 
                    if (strRoleId == "00620001" || strRoleId == "00620002") {
                        this.DelMultiRecord(arrKeyIds);
                        this.BindGv_vRTViewpointRela();
                    }
                    else {
                        //学生00620003
                        var objvRTViewpointRela = new clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN();
                        //循环判断数据用户不是登录用户则提示不可以删除
                        for (objvRTViewpointRela of arrvRTViewpointRelaObjLst) {
                            //如果存在不相同就提示不可删除；
                            if (objvRTViewpointRela.updUser != strUserId) {
                                alert("不能删除别人主题观点关系！");
                                bolresult = true;
                                return;
                            }
                        }
                        if (bolresult == true) {
                            return;
                        }
                        else {
                            this.DelMultiRecord(arrKeyIds);
                            this.BindGv_vRTViewpointRela();
                        }
                    }
                });
                //const responseText = await this.DelMultiRecord(arrKeyIds);
                //const responseText2 = await this.BindGv_vRTViewpointRela();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据关键字列表删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
     */
        async DelMultiRecord(arrmId) {
            try {
                const returnInt = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_DelRTViewpointRelasAsync)(arrmId);
                if (returnInt > 0) {
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelMultiRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vRTViewpointRela对象的所有属性值
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        <param name = "divContainer">显示容器</param>
        <param name = "arrRTViewpointRelaObjLst">需要绑定的对象列表</param>
      */
        async BindTab_vRTViewpointRela(divContainer, arrvRTViewpointRelaObjLst) {
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
                    fldName: "viewpointName",
                    colHeader: "观点名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "viewpointContent",
                //    colHeader: "观点内容",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "viewpointTypeName",
                    colHeader: "观点类型名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "reason",
                //    colHeader: "理由",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "source",
                //    colHeader: "来源",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "proposePeople",
                //    colHeader: "提出人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "topicName",
                    colHeader: "栏目主题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "topicContent",
                //    colHeader: "主题内容",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "topicProposePeople",
                //    colHeader: "主题提出人",
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
                    fldName: "updUser",
                    colHeader: "修改人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "详情",
                    text: "详情", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
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
                //        btn1.className = "btn btn-outline-info";
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
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvRTViewpointRelaObjLst, arrDataColumn, "mId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        btnDetailInTab_Click(strKeyId) {
            if (strKeyId == "") {
                alert("请选择需要查看的记录！");
                return;
            }
            var lngKeyId = Number(strKeyId);
            this.RtViewpointRelaDetailRecord(lngKeyId);
        }
        /* 根据关键字获取相应的记录的对象
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
      <param name = "sender">参数列表</param>
    */
        RtViewpointRelaDetailRecord(lngmId) {
            //this.keyId = lngmId.toString();
            try {
                const responseText = (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjBymIdAsync)(lngmId).then((jsonData) => {
                    var objvRTViewpointRelaEN = jsonData;
                    // //显示当前数据；
                    $("#txtTopicNameDetail").html(objvRTViewpointRelaEN.topicName);
                    $("#txtTopicContentDetail").html(objvRTViewpointRelaEN.topicContent);
                    $("#txtViewpointNameDetail").html(objvRTViewpointRelaEN.viewpointName);
                    $("#txtViewpointTypeNameDetail").html(objvRTViewpointRelaEN.viewpointTypeName);
                    $("#txtViewpointContentDetail").html(objvRTViewpointRelaEN.viewpointContent);
                    $("#txtReasonDetail").html(objvRTViewpointRelaEN.reason);
                    $("#txtSourceDetail").html(objvRTViewpointRelaEN.source);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg = `当前无数据获取失败,${e}.`;
                alert(strMsg);
            }
        }
        //    /* 根据条件获取相应的记录对象的列表
        //    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
        //  */
        //    public async BindGv_ResearchTopic() {
        //        var strListDiv: string = this.mstrListDiv;
        //        var strWhereCond = await this.CombineResearchTopicCondition();
        //        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];
        //        try {
        //            this.recCount = await ResearchTopic_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //            });
        //            var objPagerPara: stuPagerPara = {
        //                pageIndex: intCurrPageIndex,
        //                pageSize: this.pageSize,
        //                whereCond: strWhereCond,
        //                orderBy: this.hidSortResearchTopicBy
        //            };
        //            const responseObjLst = await ResearchTopic_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //                arrResearchTopicObjLst = <Array<clsResearchTopicEN>>jsonData;
        //            });
        //        }
        //        catch (e) {
        //            console.error('catch(e)=');
        //            console.error(e);
        //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //        //if (arrResearchTopicObjLst.length == 0) {
        //        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //        //    alert(strMsg);
        //        //    return;
        //        //}
        //        try {
        //            this.BindTab_ResearchTopic(strListDiv, arrResearchTopicObjLst);
        //            console.log("完成BindGv_ResearchTopic!");
        //        }
        //        catch (e) {
        //            console.error('catch(e)=');
        //            console.error(e);
        //            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //            alert(strMsg);
        //        }
        //    }
        //    /* 显示ResearchTopic对象的所有属性值
        //   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        //   <param name = "divContainer">显示容器</param>
        //   <param name = "arrResearchTopicObjLst">需要绑定的对象列表</param>
        // */
        //    public async BindTab_ResearchTopic(divContainer: string, arrResearchTopicObjLst: Array<clsResearchTopicEN>) {
        //        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        //        if (o == null) {
        //            alert(`${divContainer}不存在！`);
        //            return;
        //        }
        //        var arrDataColumn: Array<clsDataColumn> =
        //            [
        //                {
        //                    fldName: "",
        //                    colHeader: "",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "CheckBox",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "topicName",
        //                    colHeader: "栏目主题",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "topicContent",
        //                    colHeader: "主题内容",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "topicProposePeople",
        //                    colHeader: "主题提出人",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "orderNum",
        //                    colHeader: "序号",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "updDate",
        //                    colHeader: "修改日期",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "updUser",
        //                    colHeader: "修改人",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                //{
        //                //    fldName: "",
        //                //    colHeader: "修改",
        //                //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                //    columnType: "Button",
        //                //    orderNum: 1,
        //                //    funcName: (strKeyId: string, strText: string) => {
        //                //        var btn1: HTMLElement = document.createElement("button");
        //                //        btn1.innerText = strText;
        //                //        btn1.className = "btn btn-outline-info";
        //                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
        //                //        return btn1;
        //                //    }
        //                //},
        //                //{
        //                //    fldName: "",
        //                //    colHeader: "删除",
        //                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                //    columnType: "Button",
        //                //    orderNum: 1,
        //                //    funcName: (strKeyId: string, strText: string) => {
        //                //        var btn1: HTMLElement = document.createElement("button");
        //                //        btn1.innerText = strText;
        //                //        btn1.className = "btn btn-outline-info";
        //                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
        //                //        return btn1;
        //                //    }
        //                //},
        //            ];
        //        BindTab(o, arrResearchTopicObjLst, arrDataColumn, "topicId");
        //        this.objPager.recCount = this.recCount;
        //        this.objPager.pageSize = this.pageSize;
        //        this.objPager.ShowPagerV2(this, this.divName4Pager);
        //    }
        //    /* 把所有的查询控件内容组合成一个条件串
        // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        //  <returns>条件串(strWhereCond)</returns>
        //*/
        //    public async CombineResearchTopicCondition():Promise<string> {
        //        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //        //例如 1 = 1 && userName = '张三'
        //        var strViewpointId = clsPrivateSessionStorage.topicId;//观点
        //        var strTopicId = clsPrivateSessionStorage.topicId;//主题
        //        var strUserId = clsPublocalStorage.userId;
        //        var strWhereCond: string = " 1 = 1 ";
        //        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //        try {
        //            if (this.topicName_q != "") {
        //                strWhereCond += ` And ${clsResearchTopicEN.con_TopicName} like '% ${this.topicName_q}%'`;
        //            }
        //            if (this.TopicProposePeople_q != "") {
        //                strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} like '% ${this.TopicProposePeople_q}%'`;
        //            }
        //            //排除获取已存在的关系数据
        //            strWhereCond += ` And topicId not in (select topicId from RTViewpointRela where viewpointId = '${strViewpointId}' And updUser = '${strUserId}')` ;
        //        }
        //        catch (objException) {
        //            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineResearchTopicCondition)时出错!请联系管理员!${objException}`;
        //            throw strMsg;
        //        }
        //        return strWhereCond;
        //    }
        //    public btnokRecord_Click() {
        //        this.AddNewRecordSave();
        //    }
        //    /* 添加新记录
        //   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        //  */
        //    public async AddNewRecordSave() {
        //        var strViewpointId = clsPrivateSessionStorage.topicId;//观点
        //        var strTopicId = clsPrivateSessionStorage.topicId;//主题
        //        var strUserId = clsPublocalStorage.userId;
        //        var objRTViewpointRelaEN: clsRTViewpointRelaEN = new clsRTViewpointRelaEN();
        //        this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);
        //        try {
        //            //同一用户 同一主题 同一观点 只能添加一次；
        //            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId + "'";
        //            const responseText = await RTViewpointRela_IsExistRecordAsync(strWhere);
        //            var bolIsExist: boolean = responseText;
        //            if (bolIsExist == true) {
        //                var strMsg: string = `同一观点不能重复添加同一个主题！`;
        //                alert(strMsg);
        //                return responseText;//一定要有一个返回值，否则会出错！
        //            }
        //            const responseText2 = await RTViewpointRela_AddNewRecordAsync(objRTViewpointRelaEN);
        //            var returnBool: boolean = !!responseText2;
        //            if (returnBool == true) {
        //                var strInfo: string = `添加成功!`;
        //                $('#lblResult40').val(strInfo);
        //                //显示信息框
        //                alert(strInfo);
        //                window.location.href = "../GraduateEdu/Viewpoint_QUDI_TS";
        //            }
        //            else {
        //                var strInfo: string = `添加不成功!`;
        //                $('#lblResult40').val(strInfo);
        //                //显示信息框
        //                alert(strInfo);
        //            }
        //            return responseText2;//一定要有一个返回值，否则会出错！
        //        }
        //        catch (e) {
        //            console.error('catch(e)=');
        //            console.error(e);
        //            var strMsg: string = `添加记录不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //        return true;//一定要有一个返回值，否则会出错！
        //    }
        //    /* 函数功能:把界面上的属性数据传到类对象中
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        //  <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
        //*/
        //    public PutDataToRTViewpointRelaClass(pobjRTViewpointRelaEN: clsRTViewpointRelaEN) {
        //        var strTopicId = clsPrivateSessionStorage.topicId;
        //        var strViewpointId = clsPrivateSessionStorage.topicId;
        //        var strUserId = clsPublocalStorage.userId;
        //        pobjRTViewpointRelaEN.SetTopicId(strTopicId;// 主题编号
        //        pobjRTViewpointRelaEN.SetViewpointId(strViewpointId;// 观点Id
        //        pobjRTViewpointRelaEN.SetProposePeople(strUserId;// 提出人
        //        pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
        //        pobjRTViewpointRelaEN.SetUpdUser(strUserId;// 修改用户Id// 修改用户Id
        //        //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
        //    }
        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.SetCurrPageIndex(intPageIndex);
            this.BindGv_ResearchTopic();
        }
        /* 函数功能:从界面列表中根据某一个字段排序
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
        <param name = "strSortByFld">排序的字段</param>
      */
        async SortBy(strSortByFld) {
            if (this.hidSortResearchTopicBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortResearchTopicBy.indexOf("Asc") >= 0) {
                    this.hidSortResearchTopicBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortResearchTopicBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortResearchTopicBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_ResearchTopic();
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
        /*
       * 栏目主题
      */
        get topicName_q() {
            return $("#txtTopicName_q").val();
        }
        /*
        * 主题提出人
       */
        get TopicProposePeople_q() {
            return $("#txtTopicProposePeople_q").val();
        }
        /*
       * 设置排序字段-相当使用ViewState功能
      */
        set hidSortResearchTopicBy(value) {
            $("#hidSortResearchTopicBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortResearchTopicBy() {
            return $("#hidSortResearchTopicBy").val();
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
     * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvRTViewpointRelaBy(value) {
            $("#hidSortvRTViewpointRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTViewpointRelaBy() {
            return $("#hidSortvRTViewpointRelaBy").val();
        }
        /*
      * 观点名称
     */
        get viewpointName_q() {
            return $("#txtViewpointName_q").val();
        }
    }
    exports.ViewpointAdd = ViewpointAdd;
});