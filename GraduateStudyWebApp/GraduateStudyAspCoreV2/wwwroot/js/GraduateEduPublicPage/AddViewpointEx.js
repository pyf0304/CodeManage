/*-- -- -- -- -- -- -- -- -- -- --
类名:Viewpoint_QUDI_TSEx
表名:Viewpoint(01120542)
生成代码版本:2019.12.06.1
生成日期:2019/12/27 11:02:10
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
///// <reference path="../../scripts/typings/q/q.d.ts" />CloseWindowCloseWindow
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/Viewpoint_Edit.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointCitationEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointVerEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointCitationWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./Pub_PaperList.js", "./Pub_ResearchTopicList.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AddViewpointEx = void 0;
    const Viewpoint_Edit_js_1 = require("../PagesBase/GraduateEduTopic/Viewpoint_Edit.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsRTViewpointRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js");
    const clsViewpointAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js");
    const clsViewpointCitationEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointCitationEN.js");
    const clsViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js");
    const clsViewpointVerEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointVerEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js");
    const clsViewpointAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js");
    const clsViewpointCitationWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointCitationWApi.js");
    const clsViewpointVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointVerWApi.js");
    const clsViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js");
    const clsvViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const Pub_PaperList_js_1 = require("./Pub_PaperList.js");
    const Pub_ResearchTopicList_js_1 = require("./Pub_ResearchTopicList.js");
    /* Viewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class AddViewpointEx extends Viewpoint_Edit_js_1.Viewpoint_Edit {
        constructor() {
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvViewpointBy: string = "viewpointId";
            super(...arguments);
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
            //主题列表
            this.mstrListdivTopicDataLst = "divTopicDataLst";
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
            const strThisFuncName = this.Page_Load.name;
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls == "") {
                        const objResearchTopic = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetFirstObjAsync)(" topicId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId); //通过主题Id获取教学班ID
                        if (objResearchTopic == null) {
                            const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                            console.error(strMsg);
                            alert(strMsg);
                            return;
                            //const strThisFuncName = this.Page_Load.name;
                        }
                        clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;
                    }
                    var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                    const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
                    const ddl_ViewpointTypeId = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId");
                    var userTypeId;
                    var userTypeId = $("#hidUserTypeId").val();
                    if (userTypeId == "01") {
                        userTypeId = "04";
                    }
                    else {
                        userTypeId = "05";
                    }
                    if ($("#hidViewpointId").val() != "") {
                        const UpdateRecord = await this.UpdateRecord($("#hidViewpointId").val());
                        //if ($("#hidIsRecommend").val() != "") {
                        //    const RecommendRecord = await this.RecommendRecord($("#hidViewpointId").val());
                        //}
                        $("#divLoading").hide();
                    }
                    else {
                        this.AddNewRecord();
                        //获取分享Id
                        const responseText = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)(userTypeId, clsPublocalStorage_js_1.clsPublocalStorage.userId);
                        var strShareId = responseText;
                        //var returnBool: boolean = !!responseText2;
                        if (strShareId != "") {
                            this.shareId = strShareId;
                        }
                        $("#divLoading").hide();
                    }
                    //1、为下拉框设置数据源,绑定列表数据
                    //const ddl_ViewpointTypeId_q = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId_q");
                    //ViewpointCRUD.sortvViewpointBy = "updDate Desc";
                    //this.hidSortResearchTopicBy = "updDate Desc";
                    //论文
                    //PaperCRUD.sortPaperBy = "updDate Desc";
                    //用户下拉框绑定
                    //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                    var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
                    const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
                    //文献类型；
                    const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                    //论文
                    this.hidSortvRTPaperRelaBy = "updDate Desc";
                    //var strWhereCond = await this.CombinevViewpointCondition();
                    //const responseText = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //});
                    //2、显示无条件的表内容在GridView中
                    //const gvResult = await this.BindGv_vViewpoint();
                    //获取传参的paperId
                    var strPaperId = $("#hidRequestPaperId").val();
                    if (strPaperId != "") {
                        $('#SelectPaper').hide();
                        //存放Id
                        $("#txtPaperId").val(strPaperId);
                    }
                    else {
                        $('#SelectPaper').show();
                    }
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
        /* 为插入记录做准备工作
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
      */
        async AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnSubmit_Viewpoint = "确认添加";
            this.btnCancel_Viewpoint = "取消添加";
            this.Clear();
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", false);
            //wucViewpointB1.viewpointId = clsViewpointBL.GetMaxStrId_S();
            //return new Promise((resolve, reject) => {
            //    try {
            //        const responseText = Viewpoint_GetMaxStrIdAsync().then((jsonData) => {
            //            var returnString: string = jsonData.toString();
            //            if (returnString == "") {
            //                var strInfo: string = `获取表Paper的最大关键字为空，不成功，请检查!`;
            //                //显示信息框
            //                alert(strInfo);
            //            }
            //            else {
            //                $('#txtViewpointId').val(returnString);
            //            }
            //        });
            //    }
            //    catch (e) {
            //        console.error('catch(e)=');
            //        console.error(e);
            //        var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            //        alert(strMsg);
            //    }
            //});
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[ViewpointType]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_ViewpointTypeId(ddlViewpointTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlViewpointTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlViewpointTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointTypeWApi_js_1.ViewpointType_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrViewpointTypeObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlViewpointTypeId, arrViewpointTypeObjLst, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName, "观点类型");
                        console.log("完成BindDdl_ViewpointTypeId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
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
        /* 函数功能:把界面上的属性数据传到类对象中
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
      <param name = "pobjViewpointEN">数据传输的目的类对象</param>
    */
        PutDataToViewpointVerClass(pobjViewpointVerEN) {
            pobjViewpointVerEN.SetViewpointId(this.viewpointId); // 观点Id
            pobjViewpointVerEN.SetViewpointName(this.viewpointName); // 观点名称
            pobjViewpointVerEN.SetViewpointContent(this.viewpointContent); // 观点内容
            pobjViewpointVerEN.SetViewpointTypeId(this.viewpointTypeId); // 观点类型Id
            pobjViewpointVerEN.SetReason(this.reason); // 理由
            pobjViewpointVerEN.SetSource(this.source); // 来源
            pobjViewpointVerEN.SetCitationId(this.paperId); //引用论文id;
            //判断用户类型，然后添加数据
            var strhidUserTypeId = $("#hidUserTypeId").val();
            if (strhidUserTypeId != "") {
                pobjViewpointVerEN.SetUserTypeId(strhidUserTypeId);
            }
            if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls != "") {
                pobjViewpointVerEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            else {
                pobjViewpointVerEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            pobjViewpointVerEN.SetVPProposePeople(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 观点提出人
            pobjViewpointVerEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjViewpointVerEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjViewpointVerEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjViewpointEN">数据传输的目的类对象</param>
      */
        async PutDataToViewpointClass(pobjViewpointEN) {
            pobjViewpointEN.SetViewpointId(this.viewpointId); // 观点Id
            pobjViewpointEN.SetViewpointName(this.viewpointName); // 观点名称
            pobjViewpointEN.SetViewpointContent(this.viewpointContent); // 观点内容
            pobjViewpointEN.SetViewpointTypeId(this.viewpointTypeId); // 观点类型Id
            pobjViewpointEN.SetReason(this.reason); // 理由
            pobjViewpointEN.SetSource(this.source); // 来源
            pobjViewpointEN.SetIsSubmit(false); //是否提交；//因为是在主题维护个人添加，所以状态为false，方便后续修改更正；
            pobjViewpointEN.SetShareId(this.shareId);
            pobjViewpointEN.SetCitationId(this.paperId); //引用论文id;
            var strPdfPageNum = $("#hidPdfPageNum").val();
            if (strPdfPageNum != "") {
                pobjViewpointEN.SetPdfPageNum(strPdfPageNum);
            }
            else {
                pobjViewpointEN.SetPdfPageNum(1);
            }
            //判断用户类型，然后添加数据
            var strhidUserTypeId = $("#hidUserTypeId").val();
            if (strhidUserTypeId != "") {
                pobjViewpointEN.SetUserTypeId(strhidUserTypeId);
            }
            if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls != "") {
                pobjViewpointEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            else {
                pobjViewpointEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            //pobjViewpointEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls;
            pobjViewpointEN.SetVPProposePeople(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 观点提出人
            pobjViewpointEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            if (this.btnSubmit_Viewpoint == "确认添加") {
                pobjViewpointEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            }
            //pobjViewpointEN.SetUpdUser(clsPublocalStorage.userId;// 修改人
            pobjViewpointEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjViewpointEN">表实体类对象</param>
       */
        async GetDataFromViewpointClass(pobjViewpointEN) {
            this.viewpointId = pobjViewpointEN.viewpointId; // 观点Id
            this.viewpointName = pobjViewpointEN.viewpointName; // 观点名称
            this.viewpointContent = pobjViewpointEN.viewpointContent; // 观点内容
            this.viewpointTypeId = pobjViewpointEN.viewpointTypeId; // 观点类型Id
            this.reason = pobjViewpointEN.reason; // 理由
            this.source = pobjViewpointEN.source; // 来源
            this.isSubmit = pobjViewpointEN.isSubmit; //是否提交；
            this.vpProposePeople = pobjViewpointEN.vpProposePeople; // 观点提出人
            this.shareId = pobjViewpointEN.shareId;
            this.paperId = pobjViewpointEN.citationId; //引用Id;
            //this.updDate = pobjViewpointEN.updDate;// 修改日期
            //this.updUser = pobjViewpointEN.updUser;// 修改人
            this.memo = pobjViewpointEN.memo; // 备注
        }
        /* 修改记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
      */
        async btnUpdateRecord_Click(strKeyId) {
            this.opType = "Update";
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
        }
        /* 根据关键字获取相应的记录的对象
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        <param name = "sender">参数列表</param>
      */
        async UpdateRecord(strViewpointId) {
            if ($("#hidIsRecommend").val() != "") {
                this.btnSubmit_Viewpoint = "确认推荐";
                this.btnCancel_Viewpoint = "取消推荐";
            }
            else {
                this.btnSubmit_Viewpoint = "确认修改";
                this.btnCancel_Viewpoint = "取消修改";
            }
            this.keyId = strViewpointId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointWApi_js_1.Viewpoint_GetObjByViewpointIdAsync)(strViewpointId).then((jsonData) => {
                        var objViewpointEN = jsonData;
                        // //通过判断数据用户是否是当前登录用户；
                        //if (objViewpointEN.updUser == strUserId) {
                        //判断数据是否提交，提交则不可修改；
                        //if (objViewpointEN.isSubmit == false) {
                        //ShowDialog('Update');
                        this.GetDataFromViewpointClass(objViewpointEN);
                        console.log("完成UpdateRecord!");
                        //resolve(jsonData);
                        //}
                        //else {
                        //    alert("当前数据已提交,不能修改！");
                        //    return;
                        //}
                        //}
                        //else {
                        //    alert("当前数据不是您所添加，不能修改！");
                        //    return;
                        //}
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `提交数据可能有异常,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
      */
        //public async btnDelRecord_Click() {
        //    try {
        //        var arrKeyIds = GetCheckedKeyIds();
        //        if (arrKeyIds.length == 0) {
        //            alert("请选择需要删除的记录！");
        //            return "";
        //        }
        //        //需要判断当前数据中是否包含已提交数据、如果有则不能删除
        //        var strKeyList;
        //        if (arrKeyIds.length == 0) return "";
        //        strKeyList = "";
        //        for (var i = 0; i < arrKeyIds.length; i++) {
        //            if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
        //            else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
        //        }
        //        //
        //        var strWhereCond = " viewpointId in (" + strKeyList + ")";
        //        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        //        const responseText1 = await vViewpoint_GetObjLstAsync(strWhereCond).then((jsonData) => {
        //            arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
        //            //查询是否有提交的数据
        //            arrvViewpointObjLst = arrvViewpointObjLst.filter(x => x.isSubmit == true);
        //            if (arrvViewpointObjLst.length > 0) {
        //                alert("包含有已提交数据，不能删除！");
        //                return "";
        //            }
        //        });
        //        const responseText = await this.DelMultiRecord(arrKeyIds);
        //        const responseText2 = await this.BindGv_vViewpoint();
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `删除记录不成功. ${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //观点提交审核
        async btnIsSubmit_Click(strKeyId) {
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        //提交判断；
        async SubmitRecord(strViewpointId) {
            this.keyId = strViewpointId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointWApi_js_1.Viewpoint_GetObjByViewpointIdAsync)(strViewpointId).then((jsonData) => {
                        var objViewpointEN = jsonData;
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                        //判断角色 //学生00620003
                        if (strRoleId == "00620003") {
                            // //通过判断数据用户是否是当前登录用户；
                            if (objViewpointEN.updUser == strUserId) {
                                //判断数据是否已审核
                                if (objViewpointEN.isSubmit == false) {
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
                            if (objViewpointEN.isSubmit == false) {
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
        /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async SubmitRecordSave() {
            const strThisFuncName = this.SubmitRecordSave.name;
            //
            var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
            objViewpointEN.SetViewpointId(this.keyId);
            objViewpointEN.SetIsSubmit(true);
            this.PutDataToViewpointClass(objViewpointEN);
            objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `提交成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            HideDialog();
                            //this.BindGv_vViewpoint();
                            this.iShowList.BindGv(clsViewpointEN_js_1.clsViewpointEN._CurrTabName, returnBool.toString());
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
        /* 在数据表里修改记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
     */
        btnDetailInTab_Click(strKeyId) {
            if (strKeyId == "") {
                alert("请选择需要的记录！");
                return;
            }
            this.DetailRecord(strKeyId);
        }
        /* 根据关键字获取相应的记录的对象
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
          <param name = "sender">参数列表</param>
        */
        DetailRecord(strViewpointId) {
            this.keyId = strViewpointId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsvViewpointWApi_js_1.vViewpoint_GetObjByViewpointIdAsync)(strViewpointId).then((jsonData) => {
                        var objvViewpointEN = jsonData;
                        //数据显示
                        $("#txtViewpointNameDetail").html(objvViewpointEN.viewpointName);
                        $("#txtViewpointTypeNameDetail").html(objvViewpointEN.viewpointTypeName);
                        $("#txtViewpointContentDetail").html(objvViewpointEN.viewpointContent);
                        $("#txtReasonDetail").html(objvViewpointEN.reason);
                        $("#txtSourceDetail").html(objvViewpointEN.source);
                        $("#txtMemoDetail").html(objvViewpointEN.memo);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `当前无数据获取失败,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
       具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
     */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_Viewpoint;
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
                            var returnBool = true;
                            const responseText2_1 = await this.AddNewRecordSave().then((jsonData) => {
                                returnBool = jsonData;
                            });
                            //如果接受参数是不添加关系表的那么就不添加关系
                            if (returnBool == true) {
                                var strInfo = `添加记录成功!`;
                                alert(strInfo);
                                var IsAddRela = $("#hidIsAddRela").val();
                                if (IsAddRela != "false") {
                                    //添加观点关系
                                    const responseText2_2 = await this.AddNewRecordSaveViewpointRela();
                                }
                            }
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var userTypeId;
                            var userTypeId = $("#hidUserTypeId").val();
                            if (userTypeId == "01") {
                                userTypeId = "04";
                            }
                            else {
                                userTypeId = "05";
                            }
                            var strViewpointId = $('#hidViewpointId').val();
                            const responseText7 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strViewpointId, userTypeId, "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool7 = !!responseText7;
                            if (returnBool7 == true) {
                                console.log("客观数据总表同步成功；");
                            }
                            else {
                                console.log("客观数据总表同步失败；");
                            }
                            //添加记录的同时添加历史版本
                            const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    CloseWindow();
                                    //alert("添加历史版本出问题！");
                                }
                            });
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    //HideDialog();
                                    //this.BindGv_vViewpoint();
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var userTypeId;
                            var userTypeId = $("#hidUserTypeId").val();
                            if (userTypeId == "01") {
                                userTypeId = "04";
                            }
                            else {
                                userTypeId = "05";
                            }
                            var strViewpointId = $('#hidViewpointId').val();
                            const responseText6 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strViewpointId, userTypeId, "2", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool6 = !!responseText6;
                            if (returnBool6 == true) {
                                console.log("客观数据总表同步成功；");
                            }
                            else {
                                console.log("客观数据总表同步失败；");
                            }
                            //修改记录的同时添加历史版本
                            const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    CloseWindow();
                                    //HideDialog();
                                    //this.BindGv_vViewpoint();
                                    //alert("添加历史版本出问题！");
                                }
                            });
                            break;
                        case "确认推荐":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            var returnBool = true;
                            const responseText3_1 = await this.AddNewRecordSave().then((jsonData) => {
                                returnBool = jsonData;
                            });
                            //如果接受参数是不添加关系表的那么就不添加关系
                            if (returnBool == true) {
                                var strInfo = `推荐记录成功!`;
                                alert(strInfo);
                                var IsAddRela = $("#hidIsAddRela").val();
                                if (IsAddRela != "false") {
                                    //添加观点关系
                                    const responseText3_2 = await this.AddNewRecordSaveViewpointRela();
                                }
                            }
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var userTypeId;
                            var userTypeId = $("#hidUserTypeId").val();
                            if (userTypeId == "01") {
                                userTypeId = "04";
                            }
                            else {
                                userTypeId = "05";
                            }
                            var strViewpointId = $('#hidViewpointId').val();
                            const responseText3_3 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strViewpointId, userTypeId, "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool7 = !!responseText3_3;
                            if (returnBool7 == true) {
                                console.log("客观数据总表同步成功；");
                            }
                            else {
                                console.log("客观数据总表同步失败；");
                            }
                            //添加记录的同时添加历史版本
                            const responseText3_4 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    CloseWindow();
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
                //防止重复提交
                $('#btnOKUpd').attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            try {
                const responseText = await (0, clsViewpointWApi_js_1.Viewpoint_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表ViewPoint的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtViewpointId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            if ($('#txtViewpointId').val() != "") {
                var strViewpointId = $('#txtViewpointId').val();
                //存放主键；
                $('#hidViewpointId').val(strViewpointId);
                var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
                objViewpointEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
                if ($("#hidIsRecommend").val() != "") {
                    objViewpointEN.SetIsRecommend(true);
                }
                this.PutDataToViewpointClass(objViewpointEN);
                try {
                    //const responseText = await Viewpoint_IsExistAsync(objViewpointEN.viewpointId);
                    //var bolIsExist: boolean = responseText;
                    //if (bolIsExist == true) {
                    //    var strMsg: string = `添加记录时，关键字：${objViewpointEN.viewpointId}已经存在！`;
                    //    alert(strMsg);
                    //    return responseText;//一定要有一个返回值，否则会出错！
                    //}
                    const responseText2 = await (0, clsViewpointWApi_js_1.Viewpoint_AddNewRecordAsync)(objViewpointEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        //添加附件图片
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
                        ////执行之前需要判断是否有引用 ;有就添加论文、没有就添加附件；
                        //if ($("#txtPaperId").val() == "") {
                        //    //添加成功，则执行附件添加方法；
                        //    //判断是否有返回的附件路径值
                        //    if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        //        var fileOne = $("#hdnFileOne").val();
                        //        this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        //    }
                        //    else {
                        //        if ($("#hdnFileTwo").val() != "") {
                        //            var fileTwo = $("#hdnFileTwo").val();
                        //            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        //        }
                        //        else {
                        //            if ($("#hdnFileThree").val() != "") {
                        //                var fileThree = $("#hdnFileThree").val();
                        //                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        //            }
                        //        }
                        //    }
                        //}
                        //else {
                        //    //1.这里执行添加观点引用论文；
                        //    var objclsViewpointCitationEN: clsViewpointCitationEN = new clsViewpointCitationEN();
                        //    this.PutDataToclsViewpointCitationClass(objclsViewpointCitationEN);
                        //    //引用论文；
                        //    const responseText3 = await ViewpointCitation_AddNewRecordAsync(objclsViewpointCitationEN);
                        //    var returnBool: boolean = !!responseText3;
                        //    if (returnBool == true) {
                        //        //添加成功，则执行附件添加方法；
                        //        //判断是否有返回的附件路径值
                        //        if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        //            var fileOne = $("#hdnFileOne").val();
                        //            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        //        }
                        //        else {
                        //            if ($("#hdnFileTwo").val() != "") {
                        //                var fileTwo = $("#hdnFileTwo").val();
                        //                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        //            }
                        //            else {
                        //                if ($("#hdnFileThree").val() != "") {
                        //                    var fileThree = $("#hdnFileThree").val();
                        //                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        //                }
                        //            }
                        //        }
                        //    }
                        //    else {
                        //    }
                        //}
                        //var strInfo: string = `添加记录成功!`;
                        //$('#lblResult40').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                    }
                    else {
                        var strInfo = `编辑记录不成功!`;
                        $('#lblResult40').val(strInfo);
                        //显示信息框
                        CloseWindow();
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
        //添加历史版本
        async AddVersionRecordSave() {
            const strThisFuncName = this.AddVersionRecordSave.name;
            var objViewpointVerEN = new clsViewpointVerEN_js_1.clsViewpointVerEN();
            objViewpointVerEN.SetViewpointId(this.viewpointId);
            this.PutDataToViewpointVerClass(objViewpointVerEN);
            try {
                const responseText2 = await (0, clsViewpointVerWApi_js_1.ViewpointVer_AddNewRecordAsync)(objViewpointVerEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and viewpointId=" + this.viewpointId;
                    var intVersionCount = await (0, clsViewpointVerWApi_js_1.ViewpointVer_GetRecCountByCondAsync)(strWhereCond2);
                    var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
                    objViewpointEN.SetViewpointId(this.viewpointId);
                    objViewpointEN.SetVersionCount(intVersionCount);
                    objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            return true;
                        }
                        else {
                            var strInfo = `添加历史版本数不成功!`;
                            alert(strInfo);
                            console.log("添加历史版本数不成功");
                            CloseWindow();
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
        /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
    */
        PutDataToclsViewpointCitationClass(pobjViewpointCitationEN) {
            var strPaperId = $("#txtPaperId").val();
            var strViewpointId = $("#txtViewpointId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjViewpointCitationEN.SetPaperId(strPaperId); // 论文编号
            pobjViewpointCitationEN.SetViewpointId(strViewpointId); // 观点Id
            pobjViewpointCitationEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjViewpointCitationEN.SetUpdUserId(strUserId); // 修改用户Id// 修改用户Id
            //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
        }
        //////////////////////////////////////////////////////////////////////附件添加
        //添加上传论文附件方法
        async AddNewRecordobjPaperSubAttachmentENSave(filePath, strfileNum) {
            var objViewpointAttachmentEN = new clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN();
            this.PutDataToPaperAttachmentClass(objViewpointAttachmentEN, filePath);
            try {
                const responseText2 = await (0, clsViewpointAttachmentWApi_js_1.ViewpointAttachment_AddNewRecordAsync)(objViewpointAttachmentEN);
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
        PutDataToPaperAttachmentClass(pobjViewpointAttachmentEN, filePath) {
            pobjViewpointAttachmentEN.SetViewpointId($("#txtViewpointId").val()); // 观点Id
            var strfilePath = filePath;
            //判断地址不为空则执行截取操作
            if (strfilePath != "") {
                var index = strfilePath.lastIndexOf("\/");
                strfilePath = strfilePath.substring(index + 1, strfilePath.length);
                pobjViewpointAttachmentEN.SetFilePath(filePath);
                pobjViewpointAttachmentEN.SetViewpointAttachmentName(strfilePath);
            }
            pobjViewpointAttachmentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls != "") {
                pobjViewpointAttachmentEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            else {
                pobjViewpointAttachmentEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            //pobjViewpointAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls;//教学班
            pobjViewpointAttachmentEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
        }
        ////////////////////////////////////////////////修改时的方法
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
            objViewpointEN.SetViewpointId(this.keyId);
            this.PutDataToViewpointClass(objViewpointEN);
            objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //判断引用的论文ID是否为空
                            var strPaperId = $("#txtPaperId").val();
                            if (strPaperId != "") {
                                //，如果不为空，根据Id删除引用文件
                                var strwhere = "viewpointId ='" + objViewpointEN.viewpointId + "'";
                                this.DelRecordViewpointCitationByWhere(strwhere);
                            }
                            else {
                                //如果等于空，那么就去判断附件是否为空；
                                //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                                if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                    //根据Id删除附件
                                    var strwhere = "viewpointId ='" + objViewpointEN.viewpointId + "'";
                                    this.DelRecordByWhere(strwhere);
                                }
                            }
                            var strInfo = `修改记录成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("完成UpdateRecordSave");
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
        //删除附件
        DelRecordViewpointCitationByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointCitationWApi_js_1.ViewpointCitation_DelViewpointCitationsByCondAsync)(strWhere).then((jsonData) => {
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
                        //清除后、添加新的论文数据；
                        this.AddNewRecordViewpointCitationSave();
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
        //添加引用论文
        async AddNewRecordViewpointCitationSave() {
            //1.这里执行添加观点引用论文；
            var objclsViewpointCitationEN = new clsViewpointCitationEN_js_1.clsViewpointCitationEN();
            this.PutDataToclsViewpointCitationClass(objclsViewpointCitationEN);
            //引用论文；
            const responseText3 = await (0, clsViewpointCitationWApi_js_1.ViewpointCitation_AddNewRecordAsync)(objclsViewpointCitationEN);
            var returnBool = !!responseText3;
            if (returnBool == true) {
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
            }
        }
        //删除观点附件
        /*
    根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        DelRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointAttachmentWApi_js_1.ViewpointAttachment_DelViewpointAttachmentsByCondAsync)(strWhere).then((jsonData) => {
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
        ////////////////////////////////////////////////////////////////////////////////// 添加主题关系部分
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        //public async BindGv_ResearchTopic() {
        //    var strListDiv: string = this.mstrListdivTopicDataLst;
        //    var strWhereCond = await this.CombineResearchTopicCondition();
        //    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //    var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];
        //    try {
        //        this.recCount = await ResearchTopic_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //        });
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: this.pageSize,
        //            whereCond: strWhereCond,
        //            orderBy: this.hidSortResearchTopicBy,
        //            sortFun: (x, y) => { return 0; }
        //        };
        //        const responseObjLst = await ResearchTopic_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrResearchTopicObjLst = <Array<clsResearchTopicEN>>jsonData;
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    //if (arrResearchTopicObjLst.length == 0) {
        //    //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    //console.error(strMsg);
        //    //    alert(strMsg);
        //    //    return;
        //    //}
        //    try {
        //        this.BindTab_ResearchTopic(strListDiv, arrResearchTopicObjLst);
        //        console.log("完成BindGv_ResearchTopic!");
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /* 显示ResearchTopic对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrResearchTopicObjLst">需要绑定的对象列表</param>
     */
        //public async BindTab_ResearchTopic(divContainer: string, arrResearchTopicObjLst: Array<clsResearchTopicEN>) {
        //    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        //    if (o == null) {
        //        alert(`${divContainer}不存在！`);
        //        return;
        //    }
        //    var arrDataColumn: Array<clsDataColumn> =
        //        [
        //            {
        //                fldName: "",
        //                colHeader: "",
        //                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "CheckBox",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "topicName",
        //                colHeader: "栏目主题",
        //                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "topicContent",
        //                colHeader: "主题内容",
        //                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            //{
        //            //    fldName: "topicProposePeople",
        //            //    colHeader: "主题提出人",
        //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //            //    columnType: "Label",
        //            //    orderNum: 1,
        //            //    funcName: () => { }
        //            //},
        //            //{
        //            //    fldName: "orderNum",
        //            //    colHeader: "序号",
        //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //            //    columnType: "Label",
        //            //    orderNum: 1,
        //            //    funcName: () => { }
        //            //},
        //            {
        //                fldName: "updDate",
        //                colHeader: "修改日期",
        //                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "updUser",
        //                colHeader: "修改人",
        //                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "",
        //                colHeader: "确定",
        //                text: "确定", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Button",
        //                orderNum: 1,
        //                funcName: (strKeyId: string, strText: string) => {
        //                    var btn1: HTMLElement = document.createElement("button");
        //                    btn1.innerText = strText;
        //                    btn1.className = "btn btn-outline-info btn-sm";
        //                    btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
        //                    return btn1;
        //                }
        //            },
        //            //{
        //            //    fldName: "",
        //            //    colHeader: "修改",
        //            //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //            //    columnType: "Button",
        //            //    orderNum: 1,
        //            //    funcName: (strKeyId: string, strText: string) => {
        //            //        var btn1: HTMLElement = document.createElement("button");
        //            //        btn1.innerText = strText;
        //            //        btn1.className = "btn btn-outline-info btn-sm";
        //            //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
        //            //        return btn1;
        //            //    }
        //            //},
        //            //{
        //            //    fldName: "",
        //            //    colHeader: "删除",
        //            //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //            //    columnType: "Button",
        //            //    orderNum: 1,
        //            //    funcName: (strKeyId: string, strText: string) => {
        //            //        var btn1: HTMLElement = document.createElement("button");
        //            //        btn1.innerText = strText;
        //            //        btn1.className = "btn btn-outline-info btn-sm";
        //            //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
        //            //        return btn1;
        //            //    }
        //            //},
        //        ];
        //    BindTab(o, arrResearchTopicObjLst, arrDataColumn, "topicId", this);
        //    this.objPager.recCount = this.recCount;
        //    this.objPager.pageSize = this.pageSize;
        //    this.objPager.ShowPagerV2(this, this.divName4Pager);
        //}
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        async CombineResearchTopicCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strViewpointId = $('#hidViewpointId').val(); //观点
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId; //主题
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.topicName_q != "") {
                //    strWhereCond += ` And ${clsResearchTopicEN.con_TopicName} like '% ${this.topicName_q}%'`;
                //}
                //if (this.TopicProposePeople_q != "") {
                //    strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} like '% ${this.TopicProposePeople_q}%'`;
                //}
                //排除获取已存在的关系数据 根据当前用户；
                strWhereCond += ` And topicId not in (select topicId from RTViewpointRela where viewpointId = '${strViewpointId}' And updUser = '${strUserId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineResearchTopicCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //添加主题关系 展示主题列表数据
        async btnAddRela_Click() {
            const objPage_ResearchTopic = new Pub_ResearchTopicList_js_1.Pub_ResearchTopicList();
            await objPage_ResearchTopic.BindGv_ResearchTopic();
        }
        //确定选择的主题 并添加到关系表中
        btnOkInTab_Click(strkeyId) {
            //存放Id
            clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId = strkeyId;
            //执行添加关系方法
            this.AddNewRecordSaveViewpointRela();
        }
        ///////////////////////////////////---------------------------------------------------------------------------添加主题观点关系
        /* 添加新记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
     */
        async AddNewRecordSaveViewpointRela() {
            const strThisFuncName = this.AddNewRecordSaveViewpointRela.name;
            var strViewpointId = $('#hidViewpointId').val(); //观点
            var objRTViewpointRelaEN = new clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN();
            this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);
            try {
                ////同一主题 同一观点 只能添加一次；
                //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId + "'";
                ////var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
                //const responseText = await RTViewpointRela_IsExistRecordAsync(strWhere);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `同一观点不能重复添加同一个主题！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_AddNewRecordAsync)(objRTViewpointRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //根据ID获取最大数；
                    var strWhereCond2 = " 1 =1 and viewpointId=" + strViewpointId;
                    var intCitationCount = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_GetRecCountByCondAsync)(strWhereCond2);
                    var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
                    objViewpointEN.SetViewpointId(strViewpointId);
                    objViewpointEN.SetCitationCount(intCitationCount);
                    objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = await (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                        }
                        else {
                            var strInfo = `操作不成功!`;
                            alert(strInfo);
                            console.log("操作不成功");
                        }
                    });
                    //var strInfo: string = `添加成功!`;
                    //$('#lblResult40').val(strInfo);
                    //HideDialogTwo();
                    ////显示信息框
                    //alert(strInfo);
                    //window.location.href = "../GraduateEdu/ViewpointAdd?TopicRelaId=" + strViewpointId;
                    ////执行之前需要判断是否有引用 ;有就添加论文、没有就添加附件；
                    //if ($("#txtPaperId").val() == "") {
                    //添加成功，则执行附件添加方法；
                    //判断是否有返回的附件路径值
                    //if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    //    var fileOne = $("#hdnFileOne").val();
                    //    this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                    //}
                    //else {
                    //    if ($("#hdnFileTwo").val() != "") {
                    //        var fileTwo = $("#hdnFileTwo").val();
                    //        this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    //    }
                    //    else {
                    //        if ($("#hdnFileThree").val() != "") {
                    //            var fileThree = $("#hdnFileThree").val();
                    //            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                    //        }
                    //    }
                    //}
                    //}
                    //else {
                    //    //1.这里执行添加观点引用论文；
                    //    var objclsViewpointCitationEN: clsViewpointCitationEN = new clsViewpointCitationEN();
                    //    this.PutDataToclsViewpointCitationClass(objclsViewpointCitationEN);
                    //    //引用论文；
                    //    const responseText3 = await ViewpointCitation_AddNewRecordAsync(objclsViewpointCitationEN);
                    //    var returnBool: boolean = !!responseText3;
                    //    if (returnBool == true) {
                    //        //添加成功，则执行附件添加方法；
                    //        //判断是否有返回的附件路径值
                    //        if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    //            var fileOne = $("#hdnFileOne").val();
                    //            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                    //        }
                    //        else {
                    //            if ($("#hdnFileTwo").val() != "") {
                    //                var fileTwo = $("#hdnFileTwo").val();
                    //                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    //            }
                    //            else {
                    //                if ($("#hdnFileThree").val() != "") {
                    //                    var fileThree = $("#hdnFileThree").val();
                    //                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                    //                }
                    //            }
                    //        }
                    //    }
                    //    else {
                    //    }
                    //}
                }
                else {
                    var strInfo = `添加不成功!`;
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
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
      <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
    */
        PutDataToRTViewpointRelaClass(pobjRTViewpointRelaEN) {
            var strViewpointId = $("#hidViewpointId").val();
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjRTViewpointRelaEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjRTViewpointRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTViewpointRelaEN.SetViewpointId(strViewpointId); // 观点Id
            pobjRTViewpointRelaEN.SetProposePeople(strUserId); // 提出人
            pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTViewpointRelaEN.SetUpdUser(strUserId); // 修改用户Id// 修改用户Id
            pobjRTViewpointRelaEN.SetClassificationId("0000000000"); // 分类为000000
            //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
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
        //选择论文
        //添加用户关系
        async selectPaper_Click() {
            const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
            await objPage_Paper.BindGv_vPaper();
        }
        //查询论列表
        async btnPaperQuery_Click() {
            const objPage_Paper = new Pub_PaperList_js_1.Pub_PaperList();
            await objPage_Paper.BindGv_vPaper();
        }
        ////查询用户数据
        //public async btnUserQuery_Click() {
        //    const responseObjList = await this.BindGv_vPaper();
        //}
        //确定选择的论文 并添加到关系表中
        btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            $("#txtPaperId").val(strkeyId);
            //设置只读属性；
            $("#txtPaperId").attr("disabled", "disabled");
            //关闭列表
            HideDialogThree();
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.viewpointId = "";
            this.viewpointName = "";
            this.viewpointContent = "";
            $('#ddlViewpointTypeId option[0]').attr("selected", true);
            this.reason = "";
            this.source = "";
            this.vpProposePeople = "";
            this.updDate = "";
            this.updUser = "";
            this.memo = "";
            this.paperId = "";
            $("#hdnFileOne").val("");
            $("#hdnFileTwo").val("");
            $("#hdnFileThree").val("");
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
    exports.AddViewpointEx = AddViewpointEx;
});
