(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js", "../TS/L0_Entity/ParameterTable/clsgs_TopicTaskStatusEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_TopicTaskStatusWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "./gs_ResearchPlanCRUD.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ResearchPlanCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_ResearchPlanCRUDEx
    表名:gs_ResearchPlan(01120663)
    生成代码版本:2020.06.05.2
    生成日期:2020/06/10 20:10:17
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsResearchTopicEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js");
    const clsgs_TopicTaskStatusEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_TopicTaskStatusEN.js");
    const clsResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsvgs_ResearchPlanWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsgs_TopicTaskStatusWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_TopicTaskStatusWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const gs_ResearchPlanCRUD_js_1 = require("./gs_ResearchPlanCRUD.js");
    /* gs_ResearchPlanCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
   */
    class gs_ResearchPlanCRUDEx extends gs_ResearchPlanCRUD_js_1.gs_ResearchPlanCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvgs_ResearchPlanBy: string = "planId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new gs_ResearchPlanCRUDEx();
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage.btnUpdateRecord_Click(strKeyId);
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
                    objPage.btnDelRecord_Click();
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
                this.divName4Pager = "divPager_ResearchPlan"; //列表中的分页区的层Id
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
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
        /* 函数功能:把界面上的属性数据传到类对象中
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
      <param name = "pobjgs_ResearchPlanEN">数据传输的目的类对象</param>
    */
        PutDataTogs_ResearchPlanClass(pobjgs_ResearchPlanEN) {
            pobjgs_ResearchPlanEN.planId = this.planId; // 计划Id
            pobjgs_ResearchPlanEN.statusId = this.statusId; // 状态
            pobjgs_ResearchPlanEN.planTypeId = this.planTypeId; // 类型
            pobjgs_ResearchPlanEN.topicId = this.topicId; // 主题
            pobjgs_ResearchPlanEN.planContent = this.planContent; // 计划内容
            pobjgs_ResearchPlanEN.responsibleUser = this.responsibleUser; // 负责人/小组
            pobjgs_ResearchPlanEN.startDate = this.startDate; // 开始日期
            pobjgs_ResearchPlanEN.endDate = this.endDate; // 截止日期
            pobjgs_ResearchPlanEN.isSubmit = this.isSubmit; // 是否提交
            pobjgs_ResearchPlanEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改人
            pobjgs_ResearchPlanEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjgs_ResearchPlanEN.memo = this.memo; // 备注
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
            this.planTypeId = pobjgs_ResearchPlanEN.planTypeId; // 类型
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
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vgs_ResearchPlan() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.Combinevgs_ResearchPlanCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvgs_ResearchPlanObjLst = [];
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
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvgs_ResearchPlanObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vgs_ResearchPlan(strListDiv, arrvgs_ResearchPlanObjLst);
                console.log("完成BindGv_vgs_ResearchPlan!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vgs_ResearchPlan对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrgs_ResearchPlanObjLst">需要绑定的对象列表</param>
    */
        BindTab_vgs_ResearchPlan(divContainer, arrvgs_ResearchPlanObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "topicName",
                    ColHeader: "栏目主题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "statusName",
                    ColHeader: "状态名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "planContent",
                    ColHeader: "计划内容",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "responsibleUser",
                    ColHeader: "负责人/小组",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "startDate",
                    ColHeader: "开始日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "endDate",
                    ColHeader: "截止日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "actualFinishingDate",
                    ColHeader: "实际完成日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "acceptanceUser",
                    ColHeader: "验收用户",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvgs_ResearchPlanObjLst, arrDataColumn, "planId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
    */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var objgs_TopicTaskStatus_Cond = new clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN(); //编辑区域
            var objResearchTopic_Cond = new clsResearchTopicEN_js_1.clsResearchTopicEN(); //编辑区域
            const ddlStatusId = await (0, clsgs_TopicTaskStatusWApi_js_1.gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache)(this.divName4List, "ddlStatusId"); //编辑区域
            //定义条件字段
            //var strid_CurrEduCls = "";//定义条件字段
            const ddlTopicId = await this.BindDdl_TopicId_Cache("ddlTopicId", clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls()); //编辑区域
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        async BindDdl_TopicId_Cache(strDdlName, id_CurrEduCls) {
            var objDdl = document.getElementById(strDdlName);
            if (objDdl == null) {
                var strMsg = `下拉框：${strDdlName} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            //为数据源于表的下拉框设置内容
            console.log("开始：BindDdl_ResearchTopicCache");
            var arrObjLst_Sel = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjLst_sessionStorage)(id_CurrEduCls);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId, clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicName, "主题");
        }
        /*
    * 类型Id
    */
        set planTypeId(value) {
            $("#ddlPlanTypeId").val(value);
        }
        /*
        * 计划类型Id
       */
        get planTypeId() {
            return $("#ddlPlanTypeId").val();
        }
    }
    exports.gs_ResearchPlanCRUDEx = gs_ResearchPlanCRUDEx;
});
