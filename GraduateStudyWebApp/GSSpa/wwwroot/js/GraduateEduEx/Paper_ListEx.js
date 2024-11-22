(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPaper/Paper_QUDI_TS.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js", "../TS/L0_Entity/InteractManage/clsSysVoteEN.js", "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCountWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_ListEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:Paper_QUDI_TSEx
    表名:Paper(01120535)
    生成代码版本:2019.12.06.1
    生成日期:2019/12/25 17:37:11
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
    const Paper_QUDI_TS_js_1 = require("../GraduateEduPaper/Paper_QUDI_TS.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsgs_PaperAttentionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js");
    const clsgs_PaperGroupEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperCollectionLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js");
    const clsPaperDownloadLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsvPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js");
    const clsSysVoteEN_js_1 = require("../TS/L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsgs_PaperTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsgs_PaperAttentionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperGroupWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperCollectionLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js");
    const clsPaperDownloadLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvgs_PaperAttentionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js");
    const clsvPaperCountWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCountWApi.js");
    const clsvPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsgs_PaperTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsvPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsSysPara4WebApi2_js_1 = require("../TS/PubFun/clsSysPara4WebApi2.js");
    /* Paper_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Paper_ListEx extends Paper_QUDI_TS_js_1.Paper_QUDI_TS {
        constructor() {
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvPaperBy: string = "paperId";
            super(...arguments);
            //专业方向
            this.mstrListDivMajorDirection = "divMajorDirectionDataLst";
            ////通过专业得到专业方向
            //public async selectXzMajorDirection_Click() {
            //    try {
            //        //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
            //        //var strWhereCond = " id_XzMajor='" + this.id_XzMajor_q + "'";
            //        //const ddl_MajorDirectionId = await this.BindDdl_MajorDirectionId("ddlMajorDirectionId_q", strWhereCond);
            //    }
            //    catch (e) {
            //        var strMsg: string = `获取数据有问题,${e}.`;
            //        alert(strMsg);
            //    }
            //}
            ////绑定下拉专业方向
            //public BindDdl_MajorDirectionId(ddlMajorDirectionId: string, strWhereCond: string) {
            //    //var strWhereCond = " 1 =1 ";
            //    var objDdl = document.getElementById(ddlMajorDirectionId);
            //    if (objDdl == null) {
            //        var strMsg = `下拉框：${ddlMajorDirectionId} 不存在！`;
            //        alert(strMsg);
            //        throw (strMsg);
            //    }
            //    return new Promise((resolve, reject) => {
            //        try {
            //            const responseText = XzMajorDirection_GetObjLstAsync(strWhereCond).then((jsonData) => {
            //                var arrXzMajorDirectionObjLst: Array<clsXzMajorDirectionEN> = <Array<clsXzMajorDirectionEN>>jsonData;
            //                clsCommonFunc4Web.BindDdl_ObjLst(ddlMajorDirectionId, arrXzMajorDirectionObjLst, clsXzMajorDirectionEN.con_MajorDirectionId, clsXzMajorDirectionEN.con_MajorDirectionName, "专业方向");
            //                console.log("完成BindDdl_id_XzMajorDirection!");
            //                resolve(jsonData);
            //            });
            //        }
            //        catch (e) {
            //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            //            alert(strMsg);
            //        }
            //    });
            //}
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
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    //加载页面所需数据源到缓存
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    //绑定编辑文献类型
                    this.hidSortvPaperBy = "updDate Desc";
                    this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";
                    $("#hidUserId").val(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    const gvResult = await this.BindGv_vPaper();
                    this.objPager.RecCount = this.RecCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
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
        async Refresh_Click() {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            (0, clsvPaperExWApi_js_1.vPaperEx_ReFreshThisCacheById_CurrEduCls)(strid_CurrEducls);
            location.reload();
        }
        async BindDdl4QueryRegion() {
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
            //var objXzMajor_Cond: clsXzMajorEN = new clsXzMajorEN();//查询区域
            //const ddl_id_XzMajor_q = await clsDropDownList.BindDdl_XzMajorInvPaper_Cache("ddlid_XzMajor_q", objXzMajor_Cond);//专业查询区域
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
            const ddl_PaperTypeId_q = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId_q");
            //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
            //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajorNum("ddlid_XzMajor_q");
        }
        async BindDdl_gs_PaperType_Cache(ddlgs_PaperTypeId) {
            var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlgs_PaperTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlgs_PaperTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsgs_PaperTypeWApi_js_1.gs_PaperType_GetObjLstAsync)(strWhereCond);
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
                console.log("完成BindDdl_gs_PaperType_Cache!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        ////专业下拉框绑定
        //public BindDdl_id_XzMajorNum(ddlid_XzMajor: string, strWhereCond: string = "1=1") {
        //    //var strWhereCond = " 1 =1 ";
        //    var objDdl = document.getElementById(ddlid_XzMajor);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = vPaperEx_GetMajorNumObjLstAsync(strWhereCond).then((jsonData) => {
        //                var arrXzMajorObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
        //                clsCommonFunc4Web.BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsvPaperEN.con_id_XzMajor, clsvPaperEN.con_MajorName, "专业");
        //                console.log("完成BindDdl_id_XzMajor!");
        //                resolve(jsonData);
        //            });
        //        }
        //        catch (e) {
        //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //    });
        //}
        async BindDdl_LiteratureTypeId_Cache(ddlLiteratureTypeId, objLiteratureType_Cond) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetSubObjLst_Cache)(objLiteratureType_Cond);
                arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId]);
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                console.log("完成BindDdl_LiteratureTypeId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 查询
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async btnQuery_Click(strListDiv) {
            try {
                $("#divLoading").show();
                const gvResultPaper = await this.BindGv_vPaper();
                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
                $("#divLoading").hide();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 所有论文
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async liAllPaper_Click(key) {
            try {
                const gvResultPaper = await this.BindGv_vPaper();
                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 本专业
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async liMajor_Click(strListDiv) {
            try {
                //绑定专业论文
                const gvResultMajor = await this.BindGv_vPaperMajor();
                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 本专业方向
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async liMajorDirection_Click(strListDiv) {
            try {
                //绑定方向论文
                const gvResultDirection = await this.BindGv_vPaperDirection();
                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //排序事件
        async PaperSort_Click() {
            try {
                if (this.PaperSort == "1") {
                    this.hidSortvPaperBy = "updDate Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "2") {
                    this.hidSortvPaperBy = "paperTitle Asc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "3") {
                    this.hidSortvPaperBy = "appraiseCount Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "4") {
                    this.hidSortvPaperBy = "score Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "5") {
                    this.hidSortvPaperBy = "pcount Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "6") {
                    this.hidSortvPaperBy = "downloadCount Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "7") {
                    this.hidSortvPaperBy = "okCount Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        ////专业下拉框绑定
        //public BindDdl_id_XzMajor(ddlid_XzMajor: string, strWhereCond: string = "1=1") {
        //    //var strWhereCond = " 1 =1 ";
        //    var objDdl = document.getElementById(ddlid_XzMajor);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = vPaperEx_GetMajorNumObjLstAsync(strWhereCond).then((jsonData) => {
        //                var arrXzMajorObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
        //                clsCommonFunc4Web.BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsvPaperEN.con_id_XzMajor, clsvPaperEN.con_MajorName, "专业");
        //                console.log("完成BindDdl_id_XzMajor!");
        //                resolve(jsonData);
        //            });
        //        }
        //        catch (e) {
        //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //    });
        //}
        ////专业下拉框绑定
        //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "1=1") {
        //    //var strWhereCond = " 1 =1 ";
        //    var objDdl = document.getElementById(ddlUserId);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = vPaperEx_GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
        //                var arrUserObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
        //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperEN.con_UpdUser, clsvPaperEN.con_UserName, "编辑用户");
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
        CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if ($("#hidTabPaper").val() == "1") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
                //}
                //if ($("#hidTabPaper").val() == "2") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
                //}
                if (this.PaperTitle_q != "") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle} like '%${this.PaperTitle_q}%'`;
                }
                if (this.UpdDate_q != "") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_UpdDate} like '%${this.UpdDate_q}%'`;
                }
                if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
                }
                if (this.User_q != "" && this.User_q != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_UpdUser} = '${this.User_q}'`;
                }
                //论文类型
                if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
                }
                //if (this.User_q != "" && this.User_q != "0") {
                //    strWhereCond += ` And ${clsvPaperEN.con_UpdUser} = '${this.User_q}'`;
                //}
                //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                //    strWhereCond += ` And ${clsvPaperEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                //    //if (this.MajorDirectionId_q != "" && this.MajorDirectionId_q != "0") {
                //    //    strWhereCond += " and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId='" + this.MajorDirectionId_q + "')";
                //    //}
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperConditionobj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            //var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
            var objvPaper_Cond = new clsvPaperEN_js_1.clsvPaperEN();
            //objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_id_CurrEduCls, clsPublocalStorage.Getid_CurrEduCls(), "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.PaperTitle_q != "") {
                    objvPaper_Cond.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle, this.PaperTitle_q, "like");
                }
                if (this.UpdDate_q != "") {
                    objvPaper_Cond.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_UpdDate, this.UpdDate_q, "like");
                }
                if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                    objvPaper_Cond.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId, this.LiteratureTypeId_q, "=");
                }
                if (this.User_q != "" && this.User_q != "0") {
                    objvPaper_Cond.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_UpdUser, this.User_q, "=");
                }
                //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                //    objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
                //}
                //论文类型
                if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                    objvPaper_Cond.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_PaperTypeId, this.PaperTypeId_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvPaper_Cond;
        }
        /* 修改记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
      */
        btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vPaper() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevPaperCondition();
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            //var strWhereCond2: string = "";
            //var objvPaper_Cond: clsvPaperEN = this.CombinevPaperConditionobj();
            ////objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperObjLst0 = [];
            var arrvPaperObjLst = [];
            var objPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            try {
                //this.RecCount = await vPaper_GetRecCountByCond_Cache(objvPaper_Cond, strid_CurrEducls);
                //console.log("完成计数!");
                //arrvPaperObjLst0 = await vPaper_GetObjLstByPager_Cache(objPagerPara, strid_CurrEducls);
                //console.log("完成对象列表获取!");
                const responseRecCount = await (0, clsvPaperWApi_js_1.vPaper_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                //const responseText = await vPaper_GetObjLstByPager_WA_CacheAsync(objPagerPara);
                //arrvPaperObjLst = <Array<clsvPaperEN>>responseText;
                const responseObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperObjLst0 = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvPaperObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                if (strid_CurrEducls == "00000050") //私有空间
                 {
                    //arrvPaperObjLst = arrvPaperObjLst0.filter(x => x.id_CurrEduCls != "00000050");
                    //const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst);
                    const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst0);
                }
                else {
                    const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst0);
                }
                $("#divPager").show();
                //if (arrvPaperObjLst.length >= 10) {
                //    $("#divPager").show();
                //    this.objPager.RecCount = this.RecCount;
                //    this.objPager.pageSize = this.pageSize;
                //    this.objPager.ShowPagerV2(this, this.divName4Pager);
                //} else {
                //    $("#divPager").hide();
                //}
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定论文视图对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //绑定个性化论文列表
        async BindList_vPaper(strTypeId, arrvPaperObjLst) {
            var arrSysVoteObjLst = [];
            var arrPaperCollectionLogObjLst = [];
            var arrgs_PaperAttentionObjLst = [];
            var arrvPaperCountObjLst = [];
            var strhtml = "";
            var strWhereCond1 = " 1 =1 and updUser='" + $("#hidUserId").val() + "' and voteTypeId='01'";
            var strWhereCond2 = " 1 =1 and updUser='" + $("#hidUserId").val() + "'";
            //var strWhereCond3 = " 1 =1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
            var strWhereCond3 = this.CombinevPaperCondition();
            try {
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
                const responseText = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                    arrSysVoteObjLst = jsonData;
                });
                const responseText2 = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrPaperCollectionLogObjLst = jsonData;
                });
                const responseText3 = await (0, clsvPaperCountWApi_js_1.vPaperCount_GetObjLstAsync)(strWhereCond3).then((jsonData) => {
                    arrvPaperCountObjLst = jsonData;
                });
                const responseText4 = await (0, clsgs_PaperAttentionWApi_js_1.gs_PaperAttention_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrgs_PaperAttentionObjLst = jsonData;
                });
                for (var i = 0; i < arrvPaperObjLst.length; i++) {
                    var objCount = arrvPaperCountObjLst.find(x => x.paperId == arrvPaperObjLst[i].paperId); //使用find必须通过if判断不能为空后才能调用属性
                    if (objCount != null) {
                        strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                        //strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + arrvPaperObjLst[i].paperId + '">' + arrvPaperObjLst[i].paperTitle + '</a>';
                        //判断引用论文，自研论文
                        if (arrvPaperObjLst[i].paperTypeId == "02") {
                            //自研论文
                            strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(原创论文)', '../GraduateEduEx/PaperDetail?paperId=" + arrvPaperObjLst[i].paperId + "')\"><span class='text-info'>" + arrvPaperObjLst[i].paperTitle + "(" + arrvPaperObjLst[i].paperTypeName + ")</a>";
                        }
                        else {
                            strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(引用论文)', '../GraduateEduEx/PaperDetail?paperId=" + arrvPaperObjLst[i].paperId + "')\">" + arrvPaperObjLst[i].paperTitle + "(" + arrvPaperObjLst[i].paperTypeName + ")</a>";
                        }
                        //if (objCount.attachmentCount > 0) {
                        //    strhtml += "<span class=\"btn-2\" style=\"padding-left:50px;\"><a style=\"font-size:15px; color:#f98c51\" href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvPaperObjLst[i].paperId + "')\">pdf查看</a></span>";
                        //}
                        strhtml += '<span class="btn-2" style="padding-left:50px;"><a style="font-size:15px; color:#f98c51" href="#" onclick=PaperSubV_Click("' + arrvPaperObjLst[i].paperId + '")>pdf论文子观点查看</a></span>';
                        //只有自研论文才有历史版本
                        if (arrvPaperObjLst[i].paperTypeId == "02") {
                            if (arrvPaperObjLst[i].versionCount > 0 && arrvPaperObjLst[i].versionCount != null) {
                                strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('自研论文历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvPaperObjLst[i].paperId + "&Type=10')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                            }
                        }
                        strhtml += '</h6>';
                        strhtml += '<div class="baseinfo"><span><a href="#">' + arrvPaperObjLst[i].author + '</a></span><span><a href="#">' + arrvPaperObjLst[i].literatureSources + '</a></span>';
                        strhtml += '<span>' + arrvPaperObjLst[i].periodical + '</span><em>' + arrvPaperObjLst[i].keyword + '</em>';
                        strhtml += '</div>';
                        strhtml += '<div class="abstract">' + arrvPaperObjLst[i].paperContent + '</div>';
                        strhtml += '<div class="opts"><ul class="opts-count">';
                        strhtml += '<li>评论数:<em>' + objCount.appraiseCount + '</em></li><li>综合评分:<em>' + objCount.score + '</em></li>';
                        if (objCount.teaScore != null) {
                            strhtml += '<li>教师评分:<em>' + objCount.teaScore + '</em></li>';
                        }
                        if (objCount.stuScore != null) {
                            strhtml += '<li>学生评分:<em>' + objCount.stuScore + '</em></li>';
                        }
                        strhtml += '<li>读写数:<em>' + objCount.pcount + '</em></li><li>浏览量:<em>' + arrvPaperObjLst[i].browseNumber + '</em></li>';
                        //strhtml += '<li>:<em>' + arrvPaperObjLst[i].pcount + '</em></li>';
                        var objUser = arrUsers.find(x => x.userId == arrvPaperObjLst[i].updUser);
                        if (objUser != null) {
                            strhtml += '<li class="date">编辑用户：' + objUser.userName + '</li><li class="date">发表日期：' + arrvPaperObjLst[i].updDate + '</li></ul>';
                        }
                        strhtml += '<ul class="opts-btn">';
                        var objAttention = arrgs_PaperAttentionObjLst.find(x => x.paperId == arrvPaperObjLst[i].paperId);
                        if (objAttention == null) {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + arrvPaperObjLst[i].paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px;"></i><b>关注</b></a></li>';
                        }
                        else {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + arrvPaperObjLst[i].paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px; color: #1E9FFF;"></i><b>已关注</b></a></li>';
                        }
                        var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrvPaperObjLst[i].paperId);
                        //if (objLike == null) {
                        //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan" href="javascript:void(0)" onclick=btnAddVote_Click("' + arrvPaperObjLst[i].paperId + '","' + arrvPaperObjLst[i].updUser + '")><i></i>点赞</a></li>';
                        //    //console.log("null!");
                        //} else {
                        //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan_" href="javascript:void(0)" onclick=btnAddVote_Click("' + arrvPaperObjLst[i].paperId + '","' + arrvPaperObjLst[i].updUser + '")><i></i>已点赞</a></li>';
                        //    //console.log(objLike.paperId);
                        //}
                        if (objLike == null) {
                            strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + arrvPaperObjLst[i].paperId + '","' + arrvPaperObjLst[i].updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; "></i>点赞</a></li>';
                            //console.log("null!");
                        }
                        else {
                            strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + arrvPaperObjLst[i].paperId + '","' + arrvPaperObjLst[i].updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; color: #1E9FFF;"></i>已点赞</a></li>';
                            //console.log(objLike.paperId);
                        }
                        var objCollection = arrPaperCollectionLogObjLst.find(x => x.paperId == arrvPaperObjLst[i].paperId);
                        //var objSysVoteObjLst: Array<clsvSysVoteEN> = [];
                        //objSysVoteObjLst = arrvSysVoteObjLst.filter(x => x.updUser == "2020/02/18");
                        //if (objCollection == null) {
                        //    strhtml += '<li class="btn-collect"><a class="icon-collect" href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrvPaperObjLst[i].paperId + '")><i></i><b>收藏</b></a></li>';
                        //    //console.log("null!");
                        //} else {
                        //    strhtml += '<li class="btn-collect"><a class="icon-collect_" href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrvPaperObjLst[i].paperId + '")><i></i><b>已收藏</b></a></li>';
                        //    //console.log(objCollection.paperId);
                        //}
                        if (objCollection == null) {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrvPaperObjLst[i].paperId + '")><i class="layui-icon layui-icon-rate" style="font-size: 22px; "></i><b>收藏</b></a></li>';
                            //console.log("null!");
                        }
                        else {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrvPaperObjLst[i].paperId + '")><i class="layui-icon layui-icon-rate-solid" style="font-size: 22px; color: #1E9FFF;"></i><b>已收藏</b></a></li>';
                            //console.log(objCollection.paperId);
                        }
                        //if (objCount.attachmentCount > 0) {
                        //    strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click("' + arrvPaperObjLst[i].paperId + '")><i></i><b>点击下载</b></a></li>';
                        //} else {
                        //    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                        //}
                        if (objCount.attachmentCount > 0) {
                            strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile"  href="#" onclick=btnDownLoadFile_Click("' + arrvPaperObjLst[i].paperId + '")> <i class="layui-icon layui-icon-download-circle" style="font-size: 24px; "></i><b>点击下载</b></a></li>';
                        }
                        else {
                            strhtml += '<li><a id="btnDownLoadFile" href="#" title="暂无下载文件"><i class="layui-icon layui-icon-download-circle" style="font-size: 24px; color: #1E9FFF;"></i><b>无下载文件</b></a></li>';
                        }
                    }
                    strhtml += '</ul></div>';
                    strhtml += '</dd></dl></div>';
                }
                if (strTypeId == "1") {
                    if ($("#hidTabPaper").val() == "1") {
                        $("#divDataLst").html(strhtml);
                    }
                    else {
                        $("#divCurrEduClsDataLst").html(strhtml);
                    }
                }
                else if (strTypeId == "2") {
                    $('#divDataLstMajor').html(strhtml);
                }
                else if (strTypeId == "3") {
                    $('#divDataLstDirection').html(strhtml);
                }
                //if (strTypeId == "1") {
                //    $("#divDataLst").append(strhtml);
                //} else if (strTypeId == "2") {
                //    $('#divDataLstMajor').append(strhtml);
                //} else if (strTypeId == "3") {
                //    $('#divDataLstDirection').append(strhtml);
                //}
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //绑定本专业
        async BindGv_vPaperMajor() {
            //var strListDiv: string = this.mstrListDivMajor;
            var strWhereCond = this.CombinevPaperCondition();
            //通过登录的用户得到用户专业
            var strid_XzMajor = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_id_XzMajor();
            //strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where id_XzMajor= '${strid_XzMajor}')`;
            strWhereCond += " and  id_XzMajor= '" + strid_XzMajor + "'";
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperObjLst = [];
            try {
                //const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: 50,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperObjLst = jsonData;
                });
                ////绑定方向论文
                //const gvResultDirection = await this.BindGv_vPaperDirection();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取本专业的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvPaperObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                //this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
                const gvResultPaper = await this.BindList_vPaper("2", arrvPaperObjLst);
                console.log("完成BindGv_vPaperMajor!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定本专业对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //绑定本方向
        async BindGv_vPaperDirection() {
            //var strListDiv: string = this.mstrListDivDirection;
            var strWhereCond = this.CombinevPaperCondition();
            //通过登录的用户得到用户专业
            var strid_XzMajor = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_id_XzMajor();
            strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId in (select majorDirectionId from XzMajorDirection where id_XzMajor= '${strid_XzMajor}'))`;
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperObjLst = [];
            try {
                //const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: 50,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取本方向的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvPaperObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                //this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
                const gvResultPaper = await this.BindList_vPaper("3", arrvPaperObjLst);
                console.log("完成BindGv_vPaperDirection!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定本方向对象列表不成功.Error Massage:${e}.`;
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
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            const gvResult = await this.BindGv_vPaper();
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:在数据 列表中跳转到某一页
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
       <param name = "intPageIndex">页序号</param>
     */
        IndexPageOne(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            //this.BindGv_vXzMajorDirection();
        }
        /*
      * 修改用户Id
     */
        set updUser(value) {
            $("#hidUserId").val(value);
        }
        /*
        * 修改用户Id
       */
        get updUser() {
            return $("#hidUserId").val();
        }
        /*
       * 设置排序字段-相当使用ViewState功能
      */
        set hidSortvXzMajorDirectionBy(value) {
            $("#hidSortvXzMajorDirectionBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvXzMajorDirectionBy() {
            return $("#hidSortvXzMajorDirectionBy").val();
        }
        /*
    * 用户
    */
        //public get ReadUser_q(): string {
        //    return $("#txtReadUser_q").val();
        //}
        get User_q() {
            return $("#ddlUserId_q").val();
        }
        get PaperSort() {
            return $("#ddlPaperSort").val();
        }
        //  /*
        // * 专业流水号
        //*/
        //  public set id_XzMajor_q(value: string) {
        //      $("#ddlid_XzMajor_q").val(value);
        //  }
        //  /*
        //  * 专业流水号
        // */
        //  public get id_XzMajor_q(): string {
        //      return $("#ddlid_XzMajor_q").val();
        //  }
        /*
     * 专业方向号
    */
        // public set MajorDirectionId_q(value: string) {
        //     $("#ddlMajorDirectionId_q").val(value);
        // }
        // /*
        // * 专业方向号
        //*/
        // public get MajorDirectionId_q(): string {
        //     return $("#ddlMajorDirectionId_q").val();
        // }
        //添加关注
        async btnAttention_Click(strPaperId) {
            try {
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.GetUserId();
                var strWhereCond = " 1 =1 and updUser='" + strUserId + "' and paperId=" + strPaperId;
                const responseText = await (0, clsgs_PaperAttentionWApi_js_1.gs_PaperAttention_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经关注过这条论文了，请关注其他论文！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                var strWhereCond1 = " updUser='" + strUserId + "' and paperGroupName='" + clsPublocalStorage_js_1.clsPublocalStorage.GeteduClsName() + "'";
                var objgs_PaperGroup = await (0, clsgs_PaperGroupWApi_js_1.gs_PaperGroup_GetFirstObjAsync)(strWhereCond1);
                var objgs_PaperAttentionEN = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
                objgs_PaperAttentionEN.paperId = strPaperId;
                objgs_PaperAttentionEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
                objgs_PaperAttentionEN.updUser = strUserId; // 修改用户Id
                objgs_PaperAttentionEN.userId = strUserId; // 修改用户Id
                if (objgs_PaperGroup != null) {
                    objgs_PaperAttentionEN.paperGroupId = objgs_PaperGroup.paperGroupId;
                }
                else {
                    var objgs_PaperGroupEN = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                    objgs_PaperGroupEN.paperGroupName = clsPublocalStorage_js_1.clsPublocalStorage.GeteduClsName();
                    objgs_PaperGroupEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
                    objgs_PaperGroupEN.updUser = strUserId; // 修改用户Id
                    var strPaperGroupId = await (0, clsgs_PaperGroupWApi_js_1.gs_PaperGroup_AddNewRecordWithReturnKeyAsync)(objgs_PaperGroupEN);
                    if (strPaperGroupId != "") {
                        objgs_PaperAttentionEN.paperGroupId = strPaperGroupId;
                        (0, clsgs_PaperGroupWApi_js_1.gs_PaperGroup_ReFreshCache)(strUserId); //刷新论文组
                    }
                }
                const responseText3 = await (0, clsgs_PaperAttentionWApi_js_1.gs_PaperAttention_AddNewRecordAsync)(objgs_PaperAttentionEN);
                var returnBool = !!responseText3;
                if (returnBool == true) {
                    this.BindGv_vPaper();
                    layui_Alert(1, "已关注！");
                    (0, clsvgs_PaperAttentionWApi_js_1.vgs_PaperAttention_ReFreshThisCache)(strUserId); //刷新论文关注
                    //var strWhereCond3 = " paperId=" + strPaperId;
                    //var intCollectionCount = await gs_PaperAttention_GetRecCountByCondAsync(strWhereCond3);
                    //var objPaperEN: clsPaperEN = new clsPaperEN();
                    //objPaperEN.paperId = strPaperId;
                    //objPaperEN.collectionCount = intCollectionCount;
                    //objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                    //if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    //    throw "关键字不能为空!";
                    //}
                    //const responseText4 = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    //    var returnBool: boolean = jsonData;
                    //    if (returnBool == true) {
                    //        //const gvResult = await this.BindGv_vPaper();
                    //        this.BindGv_vPaper();
                    //    }
                    //    else {
                    //        var strInfo: string = `关注不成功!`;
                    //        alert(strInfo);
                    //        console.log("关注不成功");
                    //    }
                    //});
                }
                else {
                    var strInfo = `关注不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                return responseText3; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `关注不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //添加点赞
        async btnAddVote_Click(strPaperId, strUserId) {
            //this.DivName = "divAddNewRecordSave";
            var objSysVoteEN = new clsSysVoteEN_js_1.clsSysVoteEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objSysVoteEN.tableKey = strPaperId;
            objSysVoteEN.voteTypeId = "01";
            objSysVoteEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            objSysVoteEN.updUser = $("#hidUserId").val(); // 修改用户Id
            objSysVoteEN.userId = strUserId; //被点赞用户
            objSysVoteEN.id_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            var strWhereCond = " 1 =1 and updUser='" + $("#hidUserId").val() + "' and tableKey=" + strPaperId;
            try {
                const responseText = await (0, clsSysVoteWApi_js_1.SysVote_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsSysVoteWApi_js_1.SysVote_AddNewRecordAsync)(objSysVoteEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1=1 and voteTypeId='01' and tableKey=" + strPaperId;
                    var intVoteCount = await (0, clsSysVoteWApi_js_1.SysVote_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                    objPaperEN.paperId = strPaperId;
                    objPaperEN.okCount = intVoteCount;
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw "关键字不能为空!";
                    }
                    const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //const gvResult = await this.BindGv_vPaper();
                            this.BindGv_vPaper();
                        }
                        else {
                            var strInfo = `点赞不成功!`;
                            alert(strInfo);
                            console.log("点赞不成功");
                        }
                    });
                }
                else {
                    var strInfo = `点赞不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.DetailRecord();
                    //this.BindGv_vPaperSubViewpoint();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `点赞不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //添加收藏
        async btnAddCollection_Click(strPaperId) {
            var objPaperCollectionLogEN = new clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN();
            objPaperCollectionLogEN.paperId = strPaperId;
            objPaperCollectionLogEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            objPaperCollectionLogEN.updUser = $("#hidUserId").val(); // 修改用户Id
            var strWhereCond = " updUser='" + objPaperCollectionLogEN.updUser + "' and paperId=" + strPaperId;
            try {
                const responseText = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_IsExistRecordAsync)(strWhereCond);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经收藏过这条论文了！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_AddNewRecordAsync)(objPaperCollectionLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " paperId=" + strPaperId;
                    var intCollectionCount = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                    objPaperEN.paperId = strPaperId;
                    objPaperEN.collectionCount = intCollectionCount;
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw "关键字不能为空!";
                    }
                    const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //const gvResult = await this.BindGv_vPaper();
                            this.BindGv_vPaper();
                        }
                        else {
                            var strInfo = `收藏不成功!`;
                            alert(strInfo);
                            console.log("收藏不成功");
                        }
                    });
                }
                else {
                    var strInfo = `收藏不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `收藏不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //添加下载量
        async btnAddDownload_Click(strPaperId) {
            //this.DivName = "divAddNewRecordSave";
            var objPaperDownloadLogEN = new clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperDownloadLogEN.paperId = strPaperId;
            objPaperDownloadLogEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            objPaperDownloadLogEN.updUser = $("#hidUserId").val(); // 修改用户Id
            var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + strPaperId;
            try {
                const responseText2 = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_AddNewRecordAsync)(objPaperDownloadLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " paperId=" + strPaperId;
                    var intDownloadCount = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                    objPaperEN.paperId = strPaperId;
                    objPaperEN.downloadCount = intDownloadCount;
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw "关键字不能为空!";
                    }
                    const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //const gvResult = await this.BindGv_vPaper();
                            this.BindGv_vPaper();
                        }
                        else {
                            var strInfo = `添加下载量不成功!`;
                            alert(strInfo);
                            console.log("添加下载量不成功");
                        }
                    });
                }
                else {
                    var strInfo = `添加下载量不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加下载量不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //下载文件
        btnDownLoadFile_Click(strPaperId) {
            //下载函数
            this.GetPaperAttachmentRecord(strPaperId);
            //添加下载记录
            this.btnAddDownload_Click(strPaperId);
        }
        //下载函数
        GetPaperAttachmentRecord(strPaperId) {
            var strPapeId = strPaperId;
            //this.KeyId = strPaperRWId;
            var strWhereCond = ` ${clsPaperAttachmentEN_js_1.clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
            var arrPaperAttachmentObjLst = [];
            try {
                var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
                const responseText = (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrPaperAttachmentObjLst = jsonData;
                    for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {
                        var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                        doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
                    }
                });
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
    * 论文类型查询
    */
        set PaperTypeId_q(value) {
            $("#ddlPaperTypeId_q").val(value);
        }
        /*
        * 论文类型查询
        */
        get PaperTypeId_q() {
            return $("#ddlPaperTypeId_q").val();
        }
    }
    exports.Paper_ListEx = Paper_ListEx;
});
