(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchPlanEN.js", "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanEN.js", "../TS/L0_Entity/ParameterTable/clsgs_TopicTaskStatusEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_TopicTaskStatusWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPager.js", "../TS/PubFun/clsPubSessionStorage.js", "./gs_ResearchPlanCRUDEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopicPlanEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_ResearchPlanCRUD
    表名:gs_ResearchPlan(01120663)
    生成代码版本:2020.06.05.2
    生成日期:2020/06/10 20:14:21
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsgs_ResearchPlanEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchPlanEN.js");
    const clsResearchTopicEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js");
    const clsvgs_ResearchPlanEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanEN.js");
    const clsgs_TopicTaskStatusEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_TopicTaskStatusEN.js");
    const clsgs_ResearchPlanWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js");
    const clsvgs_ResearchPlanWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsgs_TopicTaskStatusWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_TopicTaskStatusWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const gs_ResearchPlanCRUDEx_js_1 = require("./gs_ResearchPlanCRUDEx.js");
    /* gs_ResearchPlanCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class ResearchTopicPlanEx extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsLoadDetailRegion = false; //记录是否导入详细信息区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.divName4Detail = "divDetail"; //详细信息区的Id
            this.divName4Pager_ResearchPlan = "divPagerResearchPlan";
            this.objPager = new clsPager_js_1.clsPager();
            this.RecCount = 0;
            //研究计划
            this.mstrListDivResearchPlan = "divResearchPlanDataLst";
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
                //建立缓存
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvgs_ResearchPlanBy = "topicName Asc";
                //this.divName4Pager = "divPagerResearchPlan";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager_ResearchPlan);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vgs_ResearchPlan();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
        btn_Click(strCommandName, strKeyId) {
            var objPage = new gs_ResearchPlanCRUDEx_js_1.gs_ResearchPlanCRUDEx();
            switch (strCommandName) {
                case "Query": //查询记录
                    //this.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    this.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    this.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    this.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    this.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    this.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
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
                    var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            var strUrl = "./gs_ResearchPlan_Edit/";
            console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "html",
                    data: {},
                    success: function (data) {
                        console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                        $('#' + divName4Edit).html(data);
                        resolve(true);
                        //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                        //clsEditObj.BindTab();
                    },
                    error: (e) => {
                        console.error(e);
                        reject(e);
                    }
                });
            });
        }
        ;
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Detail)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Detail(divName4Detail) {
            var strUrl = "./gs_ResearchPlan_Detail/";
            console.log("divName4Detail:(In AddDPV_Detail)" + divName4Detail);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "html",
                    data: {},
                    success: function (data) {
                        console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                        $('#' + divName4Detail).html(data);
                        resolve(true);
                        //setTimeout(() => { clsDetailObj.BindTab(); }, 100);
                        //clsDetailObj.BindTab();
                    },
                    error: (e) => {
                        console.error(e);
                        reject(e);
                    }
                });
            });
        }
        ;
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvgs_ResearchPlanBy = "topicName Asc";
                //2、显示无条件的表内容在GridView中
                //const gvResult = await this.BindGv_vgs_ResearchPlan_Cache();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        //public async btnQuery_Click() {
        //    var strWhereCond = this.Combinevgs_ResearchPlanCondition();
        //    try {
        //        const responseRecCount = await vgs_ResearchPlan_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //            this.RecCount = jsonData;
        //        });
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: 1,
        //            pageSize: this.pageSize,
        //            whereCond: strWhereCond,
        //            orderBy: this.hidSortvgs_ResearchPlanBy,
        //            sortFun: (x, y) => { return 0; }
        //        };
        //        const responseObjLst = await vgs_ResearchPlan_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            var arrvgs_ResearchPlanObjLst: Array<clsvgs_ResearchPlanEN> = <Array<clsvgs_ResearchPlanEN>>jsonData;
        //            this.BindTab_vgs_ResearchPlan(this.mstrListDiv, arrvgs_ResearchPlanObjLst);
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `查询不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    ShowDialog('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog('Add');
                    const responseText = await this.AddNewRecord();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
       */
        async btnAddNewRecordWithMaxId_Click() {
            this.OpType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    ShowDialog('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                }
                else {
                    ShowDialog('Add');
                    const responseText = this.AddNewRecordWithMaxId();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var objgs_TopicTaskStatus_Cond = new clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN(); //编辑区域
            var objResearchTopic_Cond = new clsResearchTopicEN_js_1.clsResearchTopicEN(); //编辑区域
            const ddlStatusId = await (0, clsgs_TopicTaskStatusWApi_js_1.gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache)(this.divName4Edit, "ddlStatusId"); //编辑区域
            //定义条件字段
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
            var objgs_TopicTaskStatus_Cond = new clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN(); //查询区域
            const ddlStatusId_q = await (0, clsgs_TopicTaskStatusWApi_js_1.gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache)(this.divName4Edit, "ddlStatusId_q"); //查询区域
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        async btnUpdateRecordInTab_Click(strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Update');
                this.bolIsLoadEditRegion = true; //
                this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog('Update');
                this.UpdateRecord(strKeyId);
            }
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
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.BindGv_vgs_ResearchPlan();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里选择记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
       */
        async btnSelectRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                this.SelectRecord(strKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `选择记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(strPlanId) {
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_DelRecordAsync)(strPlanId);
                var returnInt = responseText;
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
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strPlanId) {
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_GetObjByPlanIdAsync)(strPlanId);
                var objgs_ResearchPlanEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vgs_ResearchPlan");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
       */
        async btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Update');
                this.bolIsLoadEditRegion = true; //
                this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog('Update');
                this.UpdateRecord(strKeyId);
            }
        }
        /* 删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
       */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vgs_ResearchPlan();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        //public async btnExportExcel_Click() {
        //    var strWhereCond = " 1=1 ";
        //    try {
        //        const responseText = await vgs_ResearchPlan_GetObjLstAsync(strWhereCond).then((jsonData) => {
        //            var arrvgs_ResearchPlanObjLst: Array<clsvgs_ResearchPlanEN> = <Array<clsvgs_ResearchPlanEN>>jsonData;
        //            this.BindTab_vgs_ResearchPlan(this.mstrListDiv, arrvgs_ResearchPlanObjLst);
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `导出Excel不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.OpType == "AddWithMaxId") {
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnBool2 = jsonData;
                                if (returnBool2 == true) {
                                    HideDialog();
                                    this.BindGv_vgs_ResearchPlan();
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vgs_ResearchPlan();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In gs_ResearchPlanCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vgs_ResearchPlan();
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        //public Combinevgs_ResearchPlanCondition(): string {
        //    //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //    //例如 1 = 1 && userName = '张三'
        //    var strWhereCond: string = " 1 = 1 ";
        //    //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //    try {
        //        if (this.TopicName_q != "") {
        //            strWhereCond += ` And ${clsvgs_ResearchPlanEN.con_TopicName} like '% ${this.TopicName_q}%'`;
        //        }
        //        if (this.StatusId_q != "" && this.StatusId_q != "0") {
        //            strWhereCond += ` And ${clsvgs_ResearchPlanEN.con_StatusId} = '${this.StatusId_q}'`;
        //        }
        //    }
        //    catch (objException) {
        //        var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_ResearchPlanCondition)时出错!请联系管理员!${objException}`;
        //        throw strMsg;
        //    }
        //    return strWhereCond;
        //}
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinevgs_ResearchPlanConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvgs_ResearchPlan_Cond = new clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.TopicName_q != "") {
                    strWhereCond += ` And ${clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName} like '% ${this.TopicName_q}%'`;
                    objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName, this.TopicName_q, "like");
                }
                if (this.StatusId_q != "" && this.StatusId_q != "0") {
                    strWhereCond += ` And ${clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId} = '${this.StatusId_q}'`;
                    objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId, this.StatusId_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0008)在组合查询条件对象(Combinegs_ResearchPlanConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvgs_ResearchPlan_Cond;
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortvgs_ResearchPlanBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvgs_ResearchPlanBy.indexOf("Asc") >= 0) {
                    this.hidSortvgs_ResearchPlanBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvgs_ResearchPlanBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvgs_ResearchPlanBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vgs_ResearchPlan();
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtPlanId').prop['ReadOnly'] = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
        }
        /* 获取当前表关键字值的最大值,再加1,避免重复
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
       */
        async GetMaxStrId(strKeyCtrlName) {
            this.DivName = "divGetMaxStrId";
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_GetMaxStrIdAsync)();
                var returnString = responseText.toString();
                if (returnString == "") {
                    var strInfo = `获取表gs_ResearchPlan的最大关键字为空，不成功，请检查!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
                else {
                    var strInfo = `获取表gs_ResearchPlan的最大关键字为：${returnString}!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucgs_ResearchPlanB1.planId = clsgs_ResearchPlanBL.GetMaxStrId_S();
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucgs_ResearchPlanB1.planId = clsgs_ResearchPlanBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjgs_ResearchPlanEN">数据传输的目的类对象</param>
       */
        PutDataTogs_ResearchPlanClass(pobjgs_ResearchPlanEN) {
            pobjgs_ResearchPlanEN.planId = this.planId; // 计划Id
            pobjgs_ResearchPlanEN.statusId = this.statusId; // 状态
            pobjgs_ResearchPlanEN.topicId = this.topicId; // 主题
            var strId_CurrEduCls = $("#hidId_CurrEduCls").val();
            pobjgs_ResearchPlanEN.id_CurrEduCls = strId_CurrEduCls;
            pobjgs_ResearchPlanEN.planContent = this.planContent; // 计划内容
            pobjgs_ResearchPlanEN.responsibleUser = this.responsibleUser; // 负责人/小组
            pobjgs_ResearchPlanEN.startDate = this.startDate; // 开始日期
            pobjgs_ResearchPlanEN.endDate = this.endDate; // 截止日期
            pobjgs_ResearchPlanEN.isSubmit = this.isSubmit; // 是否提交
            pobjgs_ResearchPlanEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改人
            pobjgs_ResearchPlanEN.updDate = this.updDate; // 修改日期
            pobjgs_ResearchPlanEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objgs_ResearchPlanEN = new clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN();
            this.PutDataTogs_ResearchPlanClass(objgs_ResearchPlanEN);
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_IsExistAsync)(objgs_ResearchPlanEN.planId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objgs_ResearchPlanEN.planId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_AddNewRecordAsync)(objgs_ResearchPlanEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
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
                return false; //一定要有一个返回值，否则会出错！
            }
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objgs_ResearchPlanEN = new clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN();
            this.PutDataTogs_ResearchPlanClass(objgs_ResearchPlanEN);
            try {
                const responseText2 = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_AddNewRecordWithMaxIdAsync)(objgs_ResearchPlanEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
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
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "strPlanId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strPlanId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objgs_ResearchPlanEN = new clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN();
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_IsExistAsync)(strPlanId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strPlanId}] 的记录不存在!`;
                    //$('#lblResult1').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                }
            }
            catch (e) {
                var strMsg = `检查相应关键字的记录存在不成功, ${e}.`;
                alert(strMsg);
            }
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_GetObjByPlanIdAsync)(strPlanId);
                objgs_ResearchPlanEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromgs_ResearchPlanClass(objgs_ResearchPlanEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjgs_ResearchPlanEN">表实体类对象</param>
       */
        GetDataFromgs_ResearchPlanClass(pobjgs_ResearchPlanEN) {
            this.planId = pobjgs_ResearchPlanEN.planId; // 计划Id
            this.statusId = pobjgs_ResearchPlanEN.statusId; // 状态
            this.topicId = pobjgs_ResearchPlanEN.topicId; // 主题
            this.planContent = pobjgs_ResearchPlanEN.planContent; // 计划内容
            this.responsibleUser = pobjgs_ResearchPlanEN.responsibleUser; // 负责人/小组
            this.startDate = pobjgs_ResearchPlanEN.startDate; // 开始日期
            this.endDate = pobjgs_ResearchPlanEN.endDate; // 截止日期
            this.isSubmit = pobjgs_ResearchPlanEN.isSubmit; // 是否提交
            this.updUser = pobjgs_ResearchPlanEN.updUser; // 修改人
            this.updDate = pobjgs_ResearchPlanEN.updDate; // 修改日期
            this.memo = pobjgs_ResearchPlanEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strPlanId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strPlanId;
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_GetObjByPlanIdAsync)(strPlanId);
                var objgs_ResearchPlanEN = responseText;
                this.GetDataFromgs_ResearchPlanClass(objgs_ResearchPlanEN);
                console.log("完成UpdateRecord!");
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
            this.DivName = "divUpdateRecordSave";
            var objgs_ResearchPlanEN = new clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN();
            objgs_ResearchPlanEN.planId = this.KeyId;
            this.PutDataTogs_ResearchPlanClass(objgs_ResearchPlanEN);
            objgs_ResearchPlanEN.sf_UpdFldSetStr = objgs_ResearchPlanEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_ResearchPlanEN.planId == "" || objgs_ResearchPlanEN.planId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_UpdateRecordAsync)(objgs_ResearchPlanEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrPlanId) {
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_Delgs_ResearchPlansAsync)(arrPlanId);
                var returnInt = responseText;
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
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objgs_ResearchPlan">需要显示的对象</param>
       */
        Showgs_ResearchPlanObj(divContainer, objgs_ResearchPlan) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objgs_ResearchPlan);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objgs_ResearchPlan[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjgs_ResearchPlanEN">表实体类对象</param>
        <returns>列表的第一个关键字值</returns>
       */
        GetFirstKey() {
            if (clsCommonFunc4Web2_js_1.arrSelectedKeys.length == 1) {
                return clsCommonFunc4Web2_js_1.arrSelectedKeys[0];
            }
            else {
                alert(`请选择一个关键字！目前选择了:${clsCommonFunc4Web2_js_1.arrSelectedKeys.length}个关键字。`);
                return "";
            }
        }
        /*
        * 设置取消按钮的标题
       */
        set btnCancel(value) {
            $("#btnCancel").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd() {
            return $("#btnOKUpd").html();
        }
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd(value) {
            $("#btnOKUpd").html(value);
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 截止日期
       */
        set endDate(value) {
            $("#txtEndDate").val(value);
        }
        /*
        * 截止日期
       */
        get endDate() {
            return $("#txtEndDate").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        // public set hidSortvgs_ResearchPlanBy(value: string) {
        //     $("#hidSortvgs_ResearchPlanBy").val(value);
        // }
        // /*
        // * 设置排序字段
        //*/
        // public get hidSortvgs_ResearchPlanBy(): string {
        //     return $("#hidSortvgs_ResearchPlanBy").val();
        // }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 是否提交
       */
        set isSubmit(value) {
            $("#chkIsSubmit").attr("checked", value);
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
        set KeyId(value) {
            $("#hidKeyId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get KeyId() {
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
        set OpType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        get OpType() {
            return $("#hidOpType").val();
        }
        /*
        * 计划内容
       */
        set planContent(value) {
            $("#txtPlanContent").val(value);
        }
        /*
        * 计划内容
       */
        get planContent() {
            return $("#txtPlanContent").val();
        }
        /*
        * 计划Id
       */
        set planId(value) {
            $("#txtPlanId").val(value);
        }
        /*
        * 计划Id
       */
        get planId() {
            return $("#txtPlanId").val();
        }
        /*
        * 负责人/小组
       */
        set responsibleUser(value) {
            $("#txtResponsibleUser").val(value);
        }
        /*
        * 负责人/小组
       */
        get responsibleUser() {
            return $("#txtResponsibleUser").val();
        }
        /*
        * 开始日期
       */
        set startDate(value) {
            $("#txtStartDate").val(value);
        }
        /*
        * 开始日期
       */
        get startDate() {
            return $("#txtStartDate").val();
        }
        /*
        * 状态Id
       */
        set statusId(value) {
            $("#ddlStatusId").val(value);
        }
        /*
        * 状态Id
       */
        get statusId() {
            return $("#ddlStatusId").val();
        }
        /*
        * 状态Id
       */
        get StatusId_q() {
            return $("#ddlStatusId_q").val();
        }
        /*
        * 主题编号
       */
        set topicId(value) {
            $("#ddlTopicId").val(value);
        }
        /*
        * 主题编号
       */
        get topicId() {
            return $("#ddlTopicId").val();
        }
        /*
        * 栏目主题
       */
        get TopicName_q() {
            return $("#txtTopicName_q").val();
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
        * 修改人
       */
        set updUser(value) {
            $("#txtUpdUser").val(value);
        }
        /*
        * 修改人
       */
        get updUser() {
            return $("#txtUpdUser").val();
        }
        //研究计划
        async liResearchPlanClick() {
            try {
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager_ResearchPlan);
                    this.bolIsInitShow = true; //
                }
                ////教师布置任务
                //const gvResult = await this.BindGv_gs_TeacherTask();
                //研究计划
                const gvResultPaper = await this.BindGv_vgs_ResearchPlan();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取客观依据列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:在数据 列表中跳转到某一页
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
        <param name = "intPageIndex">页序号</param>
      */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager_ResearchPlan);
            var strnum = $("#hidTabNum").val();
            //11代表研究计划 否则就是主题；
            if (strnum == "11") {
                this.BindGv_vgs_ResearchPlan();
            }
            //else {
            //    this.BindGv_ResearchTopic();
            //}
        }
        /////////////////////////////////////////////////////////////////////////////研究计划
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        Combinevgs_ResearchPlanCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + $("#hidId_CurrEduCls").val() + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = $("#hidTopicRelaId").val();
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicId} = '${strTopicId}'`;
                }
                //判断角色 
                //管理员
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                }
                else if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                    //教师
                }
                else {
                    //学生； 
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combinegs_ResearchPlanCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vgs_ResearchPlan() {
            var strListDiv = this.mstrListDivResearchPlan; //研究计划
            var strWhereCond = this.Combinevgs_ResearchPlanCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager_ResearchPlan); //获取当前页
            var arrvgs_ResearchPlanObjLst = [];
            var arrvUsersObjLst = [];
            try {
                const responseRecCount = await (0, clsvgs_ResearchPlanWApi_js_1.vgs_ResearchPlan_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvgs_ResearchPlanBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvgs_ResearchPlanWApi_js_1.vgs_ResearchPlan_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvgs_ResearchPlanObjLst = jsonData;
                });
                //获取用户缓存数据；
                arrvUsersObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vgs_ResearchPlan(arrvgs_ResearchPlanObjLst, arrvUsersObjLst);
                console.log("完成BindGv_vgs_ResearchPlan!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //页面动态绑定
        BindTab_vgs_ResearchPlan(arrvgs_ResearchPlanObjLst, arrvUsersObjLst) {
            var strhtml = "";
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            strhtml += '<div class="info" id="infoResearchPlan"><div class="title btn-4">';
            strhtml += '<div style="float:left;"><a href="#" title="研究计划">研究计划</a></div>';
            strhtml += '</div><ul class="artlist">';
            var v = 0; //给内容加个序号
            for (var i = 0; i < arrvgs_ResearchPlanObjLst.length; i++) {
                //得到planId；
                var strPlanId = arrvgs_ResearchPlanObjLst[i].planId;
                v++;
                strhtml += '<li><span class="rowtit color4">' + v + '.[研究状态]：</span><span class="abstract-text">' + arrvgs_ResearchPlanObjLst[i].statusName + '</span></li>';
                //判断计划类型
                if (arrvgs_ResearchPlanObjLst[i].planTypeId == "01") {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[计划类型]：</span><span class="abstract-text">个人计划</span></li>';
                }
                else {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[计划类型]：</span><span class="abstract-text">小组计划</span></li>';
                }
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[负责人/小组]：</span><span class="abstract-text">' + arrvgs_ResearchPlanObjLst[i].responsibleUser + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[计划内容]：</span><span class="abstract-text">' + arrvgs_ResearchPlanObjLst[i].planContent + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[操作]：';
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[开始日期]：' + arrvgs_ResearchPlanObjLst[i].startDate + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[结束日期]：</span>' + arrvgs_ResearchPlanObjLst[i].endDate;
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[完成日期]：</span>' + arrvgs_ResearchPlanObjLst[i].actualFinishingDate;
                //获取引用人；编辑人、用户名称
                //var arrUsers: Array<clsvUsersSimEN> = await Users_GetObjLstAsync("1=1");
                var arrvUsers = [];
                var UpdUserName; //编辑人
                //获取技能编辑人；
                arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvgs_ResearchPlanObjLst[i].acceptanceUser); //技能编辑人
                for (var j = 0; j < arrvUsers.length; j++) {
                    UpdUserName = arrvUsers[j].userName;
                    break;
                }
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[验收用户]：</span>' + UpdUserName;
                if (arrvgs_ResearchPlanObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
                }
                if (arrvgs_ResearchPlanObjLst[i].isSubmit != true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelResearchPlan_Click(\'' + arrvgs_ResearchPlanObjLst[i].planId + '\')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdateResearchPlan_Click("' + arrvgs_ResearchPlanObjLst[i].planId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="提交" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnSubmitResearchPlan_Click("' + arrvgs_ResearchPlanObjLst[i].planId + '") > <i class="layui-icon" >&#xe642;</i>提交</button>';
                }
                strhtml += '</span></li>';
                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            //拼接；
            $("#divResearchPlanDataLst").html(strhtml);
            if (arrvgs_ResearchPlanObjLst.length > 10) {
                $("#divPagerResearchPlan").show();
                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager_ResearchPlan);
            }
        }
        //研究计划提交
        async btnSubmitResearchPlan_Click(strKeyId) {
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        //提交判断；
        async SubmitRecord(strPlanId) {
            this.KeyId = strPlanId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_GetObjByPlanIdAsync)(strPlanId).then((jsonData) => {
                        var objgs_ResearchPlanEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                        var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                        //可以提交
                        //判断数据是否已提交
                        if (objgs_ResearchPlanEN.isSubmit == false) {
                            const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                            });
                        }
                        else {
                            alert("当前数据已提交！");
                            return;
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
        /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        SubmitRecordSave() {
            //this.DivName = "divUpdateRecordSave";
            var objgs_ResearchPlanEN = new clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN();
            objgs_ResearchPlanEN.planId = this.KeyId;
            objgs_ResearchPlanEN.isSubmit = true;
            objgs_ResearchPlanEN.actualFinishingDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate();
            objgs_ResearchPlanEN.acceptanceUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); //验收用户
            objgs_ResearchPlanEN.sf_UpdFldSetStr = objgs_ResearchPlanEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_ResearchPlanEN.planId == "" || objgs_ResearchPlanEN.planId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_UpdateRecordAsync)(objgs_ResearchPlanEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `提交成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            // HideDialog();
                            this.BindGv_vgs_ResearchPlan();
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
        /* 删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
      */
        async btnDelResearchPlan_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                //得到当前登录的教师角色
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                if (strRoleId == "00620003") {
                    //提示学生不可删除数据；
                    var strInfo = `您权限不够，不可删除`;
                    //显示信息框
                    alert(strInfo);
                    return;
                }
                else {
                    const responseText = await this.DelPlanRecord(strKeyId);
                    const responseBindGv = await this.BindGv_vgs_ResearchPlan();
                }
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
        async DelPlanRecord(strPlanId) {
            try {
                const responseText = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_DelRecordAsync)(strPlanId);
                var returnInt = responseText;
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
    * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvgs_ResearchPlanBy(value) {
            $("#hidSortvgs_ResearchPlanBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvgs_ResearchPlanBy() {
            return $("#hidSortvgs_ResearchPlanBy").val();
        }
    }
    exports.ResearchTopicPlanEx = ResearchTopicPlanEx;
});
