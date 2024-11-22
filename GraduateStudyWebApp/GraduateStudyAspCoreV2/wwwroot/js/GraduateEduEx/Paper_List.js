(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCountWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_List = void 0;
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperCollectionLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js");
    const clsPaperDownloadLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsgs_PaperTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsgs_PaperAttentionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperCollectionLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js");
    const clsPaperDownloadLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvPaperCountWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCountWApi.js");
    const clsSysVoteWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsgs_PaperTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* Paper_List 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Paper_List extends PaperCRUD_js_1.PaperCRUD {
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
            //                BindDdl_ObjLst(ddlMajorDirectionId, arrXzMajorDirectionObjLst, clsXzMajorDirectionEN.con_MajorDirectionId, clsXzMajorDirectionEN.con_MajorDirectionName, "专业方向");
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //加载页面所需数据源到缓存
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    //绑定编辑文献类型
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "updDate Desc";
                    this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    const gvResult = await this.BindGv_vPaper();
                    this.objPager.recCount = this.recCount;
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
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(strid_CurrEducls);
            location.reload();
        }
        async BindDdl4QueryRegion() {
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
            //var objXzMajor_Cond: clsXzMajorEN = new clsXzMajorEN();//查询区域
            //const ddl_id_XzMajor_q = await clsDropDownList.BindDdl_XzMajorInvPaper_Cache("ddlid_XzMajor_q", objXzMajor_Cond);//专业查询区域
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
            const ddl_PaperTypeId_q = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId_q");
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
                var objgs_PaperType_Cond = new clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN();
                var arrObjLst_Sel = await (0, clsgs_PaperTypeWApi_js_1.gs_PaperType_GetSubObjLst_Cache)(objgs_PaperType_Cond);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
                console.log("完成BindDdl_gs_PaperType_Cache!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
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
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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
        async btnQuery_Click() {
            try {
                $("#divLoading").show();
                const gvResultPaper = await this.BindGv_vPaper();
                this.objPager.recCount = this.recCount;
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
                this.objPager.recCount = this.recCount;
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
                this.objPager.recCount = this.recCount;
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
                this.objPager.recCount = this.recCount;
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
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "updDate Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "2") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "paperTitle Asc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "3") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "appraiseCount Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "4") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "score Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "5") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "pcount Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "6") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "downloadCount Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                else if (this.PaperSort == "7") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "okCount Desc";
                    const gvResult = await this.BindGv_vPaper();
                }
                this.objPager.recCount = this.recCount;
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
        //                var arrXzMajorObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>jsonData;
        //                BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsPaperEN.con_id_XzMajor, clsPaperEN.con_MajorName, "专业");
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
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if ($("#hidTabPaper").val() == "2") {
                    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
                }
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                }
                if (this.User_q != "" && this.User_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdUser} = '${this.User_q}'`;
                }
                //论文类型
                if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
                }
                //if (this.User_q != "" && this.User_q != "0") {
                //    strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.User_q}'`;
                //}
                //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                //    strWhereCond += ` And ${clsPaperEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
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
            //var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            var objvPaper_Cond = new clsPaperEN_js_1.clsPaperEN();
            //objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_CurrEduCls, clsPublocalStorage.id_CurrEduCls, "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_PaperTitle, this.paperTitle_q, "like");
                }
                if (this.updDate_q != "") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_UpdDate, this.updDate_q, "like");
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId, this.literatureTypeId_q, "=");
                }
                if (this.User_q != "" && this.User_q != "0") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_UpdUser, this.User_q, "=");
                }
                //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                //    objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
                //}
                //论文类型
                if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_PaperTypeId, this.PaperTypeId_q, "=");
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
        //public btnUpdateRecord_Click_pyf(strKeyId: string) {
        //    this.opType = "Update";
        //    //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        //    if (strKeyId == "") {
        //        alert("请选择需要修改的记录！");
        //        return;
        //    }
        //    this.UpdateRecord(strKeyId);
        //}
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vPaper() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevPaperCondition();
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            //var strWhereCond2: string = "";
            //var objvPaper_Cond: clsPaperEN = this.CombinevPaperConditionobj();
            ////objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
            //strWhereCond2 = JSON.stringify(objvPaperEN_Sim);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvPaperObjLst0 = [];
            var arrPaperExObjLst = [];
            var objPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            try {
                //this.recCount = await vPaper_GetRecCountByCond_Cache(objvPaper_Cond, strid_CurrEducls);
                //console.log("完成计数!");
                //arrvPaperObjLst0 = await vPaper_GetObjLstByPager_Cache(objPagerPara, strid_CurrEducls);
                //console.log("完成对象列表获取!");
                this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
                //const responseText = await vPaper_GetObjLstByPager_WA_CacheAsync(objPagerPara);
                //arrPaperExObjLst = <Array<clsPaperEN>>responseText;
                const arrvPaperObjLst0 = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                if (strid_CurrEducls == "00000050") {
                    //arrPaperExObjLst = arrvPaperObjLst0.filter(x => x.id_CurrEduCls != "00000050");
                    //const gvResultPaper = await this.BindList_vPaper("1", arrPaperExObjLst);
                    const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst0);
                }
                else {
                    const gvResultPaper = await this.BindList_vPaper("1", arrvPaperObjLst0);
                }
                $("#divPager").show();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定论文视图对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //绑定个性化论文列表
        async BindList_vPaper(strTypeId, arrPaperExObjLst) {
            var arrSysVoteObjLst = [];
            var arrPaperCollectionLogObjLst = [];
            var arrgs_PaperAttentionObjLst = [];
            var arrvPaperCountObjLst = [];
            var strhtml = "";
            var strWhereCond1 = " 1 =1 and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' and voteTypeId='01'";
            var strWhereCond2 = " 1 =1 and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
            //var strWhereCond3 = " 1 =1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            var strWhereCond3 = await this.CombinevPaperCondition();
            try {
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
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
                for (var i = 0; i < arrPaperExObjLst.length; i++) {
                    var objCount = arrvPaperCountObjLst.find(x => x.paperId == arrPaperExObjLst[i].paperId); //使用find必须通过if判断不能为空后才能调用属性
                    if (objCount != null) {
                        strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                        //strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + arrPaperExObjLst[i].paperId + '">' + arrPaperExObjLst[i].paperTitle + '</a>';
                        //判断引用论文，自研论文
                        if (arrPaperExObjLst[i].paperTypeId == "02") {
                            //自研论文
                            strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(原创论文)', '../GraduateEduEx/PaperDetail?paperId=" + arrPaperExObjLst[i].paperId + "')\"><span class='text-info'>" + arrPaperExObjLst[i].paperTitle + "(" + arrPaperExObjLst[i].paperTypeName + ")</a>";
                        }
                        else {
                            strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(引用论文)', '../GraduateEduEx/PaperDetail?paperId=" + arrPaperExObjLst[i].paperId + "')\">" + arrPaperExObjLst[i].paperTitle + "(" + arrPaperExObjLst[i].paperTypeName + ")</a>";
                        }
                        //if (objCount.attachmentCount > 0) {
                        //    strhtml += "<span class=\"btn-2\" style=\"padding-left:50px;\"><a style=\"font-size:15px; color:#f98c51\" href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrPaperExObjLst[i].paperId + "')\">pdf查看</a></span>";
                        //}
                        strhtml += '<span class="btn-2" style="padding-left:50px;"><a style="font-size:15px; color:#f98c51" href="#" onclick=PaperSubVer_Click("' + arrPaperExObjLst[i].paperId + '")>pdf论文子观点查看</a></span>';
                        //只有自研论文才有历史版本
                        if (arrPaperExObjLst[i].paperTypeId == "02") {
                            if (arrPaperExObjLst[i].versionCount > 0 && arrPaperExObjLst[i].versionCount != null) {
                                strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('自研论文历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrPaperExObjLst[i].paperId + "&Type=10')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                            }
                        }
                        strhtml += '</h6>';
                        strhtml += '<div class="baseinfo"><span><a href="#">' + arrPaperExObjLst[i].author + '</a></span><span><a href="#">' + arrPaperExObjLst[i].literatureSources + '</a></span>';
                        strhtml += '<span>' + arrPaperExObjLst[i].periodical + '</span><em>' + arrPaperExObjLst[i].keyword + '</em>';
                        strhtml += '</div>';
                        strhtml += '<div class="abstract">' + arrPaperExObjLst[i].paperContent + '</div>';
                        strhtml += '<div class="opts"><ul class="opts-count">';
                        strhtml += '<li>评论数:<em>' + objCount.appraiseCount + '</em></li><li>综合评分:<em>' + objCount.score + '</em></li>';
                        if (objCount.teaScore != null) {
                            strhtml += '<li>教师评分:<em>' + objCount.teaScore + '</em></li>';
                        }
                        if (objCount.stuScore != null) {
                            strhtml += '<li>学生评分:<em>' + objCount.stuScore + '</em></li>';
                        }
                        strhtml += '<li>读写数:<em>' + objCount.pcount + '</em></li><li>浏览量:<em>' + arrPaperExObjLst[i].browseNumber + '</em></li>';
                        //strhtml += '<li>:<em>' + arrPaperExObjLst[i].pcount + '</em></li>';
                        var objUser = arrUsers.find(x => x.userId == arrPaperExObjLst[i].updUser);
                        if (objUser != null) {
                            strhtml += '<li class="date">编辑用户：' + objUser.userName + '</li><li class="date">发表日期：' + arrPaperExObjLst[i].updDate + '</li></ul>';
                        }
                        strhtml += '<ul class="opts-btn">';
                        var objAttention = arrgs_PaperAttentionObjLst.find(x => x.paperId == arrPaperExObjLst[i].paperId);
                        if (objAttention == null) {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + arrPaperExObjLst[i].paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px;"></i><b>关注</b></a></li>';
                        }
                        else {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + arrPaperExObjLst[i].paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px; color: #1E9FFF;"></i><b>已关注</b></a></li>';
                        }
                        var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrPaperExObjLst[i].paperId);
                        //if (objLike == null) {
                        //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan" href="javascript:void(0)" onclick=btnAddVote_Click("' + arrPaperExObjLst[i].paperId + '","' + arrPaperExObjLst[i].updUser + '")><i></i>点赞</a></li>';
                        //    //console.log("null!");
                        //} else {
                        //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan_" href="javascript:void(0)" onclick=btnAddVote_Click("' + arrPaperExObjLst[i].paperId + '","' + arrPaperExObjLst[i].updUser + '")><i></i>已点赞</a></li>';
                        //    //console.log(objLike.paperId);
                        //}
                        if (objLike == null) {
                            strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + arrPaperExObjLst[i].paperId + '","' + arrPaperExObjLst[i].updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; "></i>点赞</a></li>';
                            //console.log("null!");
                        }
                        else {
                            strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + arrPaperExObjLst[i].paperId + '","' + arrPaperExObjLst[i].updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; color: #1E9FFF;"></i>已点赞</a></li>';
                            //console.log(objLike.paperId);
                        }
                        var objCollection = arrPaperCollectionLogObjLst.find(x => x.paperId == arrPaperExObjLst[i].paperId);
                        //var objSysVoteObjLst: Array<clsvSysVoteEN> = [];
                        //objSysVoteObjLst = arrvSysVoteObjLst.filter(x => x.updUser == "2020/02/18");
                        //if (objCollection == null) {
                        //    strhtml += '<li class="btn-collect"><a class="icon-collect" href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrPaperExObjLst[i].paperId + '")><i></i><b>收藏</b></a></li>';
                        //    //console.log("null!");
                        //} else {
                        //    strhtml += '<li class="btn-collect"><a class="icon-collect_" href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrPaperExObjLst[i].paperId + '")><i></i><b>已收藏</b></a></li>';
                        //    //console.log(objCollection.paperId);
                        //}
                        if (objCollection == null) {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrPaperExObjLst[i].paperId + '")><i class="layui-icon layui-icon-rate" style="font-size: 22px; "></i><b>收藏</b></a></li>';
                            //console.log("null!");
                        }
                        else {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + arrPaperExObjLst[i].paperId + '")><i class="layui-icon layui-icon-rate-solid" style="font-size: 22px; color: #1E9FFF;"></i><b>已收藏</b></a></li>';
                            //console.log(objCollection.paperId);
                        }
                        //if (objCount.attachmentCount > 0) {
                        //    strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click("' + arrPaperExObjLst[i].paperId + '")><i></i><b>点击下载</b></a></li>';
                        //} else {
                        //    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                        //}
                        if (objCount.attachmentCount > 0) {
                            strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile"  href="#" onclick=btnDownLoadFile_Click("' + arrPaperExObjLst[i].paperId + '")> <i class="layui-icon layui-icon-download-circle" style="font-size: 24px; "></i><b>点击下载</b></a></li>';
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
            var strWhereCond = await this.CombinevPaperCondition();
            //通过登录的用户得到用户专业
            var strid_XzMajor = clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor;
            //strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where id_XzMajor= '${strid_XzMajor}')`;
            strWhereCond += " and  id_XzMajor= '" + strid_XzMajor + "'";
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperExObjLst = [];
            try {
                //this.recCount= await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    
                //});
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
                ////绑定方向论文
                //const gvResultDirection = await this.BindGv_vPaperDirection();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取本专业的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrPaperExObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                //this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
                const gvResultPaper = await this.BindList_vPaper("2", arrPaperExObjLst);
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
            var strWhereCond = await this.CombinevPaperCondition();
            //通过登录的用户得到用户专业
            var strid_XzMajor = clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor;
            strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId in (select majorDirectionId from XzMajorDirection where id_XzMajor= '${strid_XzMajor}'))`;
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperExObjLst = [];
            try {
                //this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    
                //});
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取本方向的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrPaperExObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                //this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
                const gvResultPaper = await this.BindList_vPaper("3", arrPaperExObjLst);
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
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.SetCurrPageIndex(intPageIndex);
            const gvResult = await this.BindGv_vPaper();
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:在数据 列表中跳转到某一页
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
       <param name = "intPageIndex">页序号</param>
     */
        IndexPageOne(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.SetCurrPageIndex(intPageIndex);
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
            return clsPublocalStorage_js_1.clsPublocalStorage.userId;
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
        //public get readUser_q(): string {
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
        //添加收藏
        async btnAddCollection_Click(strPaperId) {
            const strThisFuncName = this.btnAddCollection_Click.name;
            var objPaperCollectionLogEN = new clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN();
            objPaperCollectionLogEN.SetPaperId(strPaperId);
            objPaperCollectionLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objPaperCollectionLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
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
                    objPaperEN.SetPaperId(strPaperId);
                    objPaperEN.SetCollectionCount(intCollectionCount);
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
            const strThisFuncName = this.btnAddDownload_Click.name;
            //this.DivName = "divAddNewRecordSave";
            var objPaperDownloadLogEN = new clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperDownloadLogEN.SetPaperId(strPaperId);
            objPaperDownloadLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objPaperDownloadLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + strPaperId;
            try {
                const responseText2 = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_AddNewRecordAsync)(objPaperDownloadLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " paperId=" + strPaperId;
                    var intDownloadCount = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                    objPaperEN.SetPaperId(strPaperId);
                    objPaperEN.SetDownloadCount(intDownloadCount);
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
            //this.keyId = strPaperRWId;
            var strWhereCond = ` ${clsPaperAttachmentEN_js_1.clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
            var arrPaperAttachmentObjLst = [];
            try {
                var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
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
    exports.Paper_List = Paper_List;
});
