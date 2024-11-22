(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPaper/gs_PaperAttention_EditEx.js", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCountWApi.js", "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperCollectionLogExWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/L3_ForWApiEx/InteractManage/clsSysVoteExWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./Paper_ListEx_AllPaper.js", "./Paper_ListEx_CurrEduCls.js", "./Paper_ListEx_Direction.js", "./Paper_ListEx_Major.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_ListEx = void 0;
    const gs_PaperAttention_EditEx_js_1 = require("../GraduateEduPaper/gs_PaperAttention_EditEx.js");
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperDownloadLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsgs_PaperTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js");
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
    const clsPaperCollectionLogExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperCollectionLogExWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsSysVoteExWApi_js_1 = require("../TS/L3_ForWApiEx/InteractManage/clsSysVoteExWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const Paper_ListEx_AllPaper_js_1 = require("./Paper_ListEx_AllPaper.js");
    const Paper_ListEx_CurrEduCls_js_1 = require("./Paper_ListEx_CurrEduCls.js");
    const Paper_ListEx_Direction_js_1 = require("./Paper_ListEx_Direction.js");
    const Paper_ListEx_Major_js_1 = require("./Paper_ListEx_Major.js");
    /* Paper_ListEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Paper_ListEx extends PaperCRUD_js_1.PaperCRUD {
        constructor() {
            super(...arguments);
            //专业方向
            this.mstrListDivMajorDirection = "divMajorDirectionDataLst";
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_Paper();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "QxUsers":
                    alert('该类没有绑定该函数：[this.BindGv_QxUsers_Cache]！');
                    //this.BindGv_QxUsers_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /**
        * 按钮单击,用于调用Js函数中btn_Click
        * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        **/
        static btn_Click(strCommandName, strKeyId) {
            let objPage = new Paper_ListEx();
            //if (PaperCRUD.objPage_CRUD == null) {
            //    PaperCRUD.objPage_CRUD = new Paper_ListEx();
            //    objPage = <Paper_ListEx>PaperCRUD.objPage_CRUD;
            //}
            //else {
            //    objPage = <Paper_ListEx>PaperCRUD.objPage_CRUD;
            //}
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
                case "MajorDirection": //查询记录
                    objPage.liMajorDirection_Click();
                    break;
                case "CurrEduCls": //查询记录
                    objPage.liCurrEduCls_Click();
                    break;
                case "AllPaper": //查询记录
                    objPage.liAllPaper_Click();
                    break;
                case "Major": //查询记录
                    objPage.liMajor_Click();
                    break;
                case "AddCollection": //查询记录
                    objPage.btnAddCollection_Click(strKeyId);
                    break;
                case "AddVote": //查询记录
                    objPage.btnAddVote_Click(strKeyId);
                    break;
                case "AddAttention": //查询记录
                    objPage.btnAddAttention_Click(objPage, strKeyId);
                    break;
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "ExportExcel": //导出Excel
                    //objPage.btnExportExcel_Click();
                    //alert("导出Excel功能还没有开通！");
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
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
                    strMsg = '命令:' + strCommandName + "在函数(Paper_ListExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                this.divName4Query = "divQuery";
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    this.SetEventFunc();
                    //加载页面所需数据源到缓存
                    // 为查询区绑定下拉框
                    await this.BindDdl4QueryRegion();
                    await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_BindDdl_MajorDirectionIdByid_XzMajorInDiv_Cache)(this.divName4Query, "ddlMajorDirectionId_SetFldValue", clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
                    //绑定编辑文献类型
                    this.SetMajorDirectionName(clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
                    (0, clsCommFunc4Ctrl_js_1.SetSpanHtmlByIdInDiv)(this.divName4List, "spnMajorName", (0, clsString_js_1.Format)("[{0}]", clsPublocalStorage_js_1.clsPublocalStorage.majorName));
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "updDate Desc";
                    this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    const objPage = new Paper_ListEx_AllPaper_js_1.Paper_ListEx_AllPaper();
                    await objPage.Page_Load();
                    //this.objPager.recCount = this.recCount;
                    //this.objPager.pageSize = this.pageSize;
                    //this.objPager.ShowPagerV2(this, this.divName4Pager);
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
            const strThisFuncName = this.btnQuery_Click.name;
            try {
                $("#divLoading").show();
                let objPage_Sub;
                switch (Paper_ListEx.CurrTabName) {
                    case "AllPaper":
                        objPage_Sub = new Paper_ListEx_AllPaper_js_1.Paper_ListEx_AllPaper();
                        await objPage_Sub.Page_Load();
                        break;
                    case "CurrEduCls":
                        objPage_Sub = new Paper_ListEx_CurrEduCls_js_1.Paper_ListEx_CurrEduCls();
                        await objPage_Sub.Page_Load();
                        break;
                    case "Major":
                        objPage_Sub = new Paper_ListEx_Major_js_1.Paper_ListEx_Major();
                        await objPage_Sub.Page_Load();
                        break;
                    case "Direction":
                        objPage_Sub = new Paper_ListEx_Direction_js_1.Paper_ListEx_Direction();
                        await objPage_Sub.Page_Load();
                        break;
                    default:
                        strMsg = '当前Tab:' + Paper_ListEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                        alert(strMsg);
                        break;
                }
                //const gvResultPaper = await this.BindGv_Paper0();
                //this.objPager.recCount = this.recCount;
                //this.objPager.pageSize = this.pageSize;
                //this.objPager.ShowPagerV2(this, this.divName4Pager);
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
        async liAllPaper_Click() {
            try {
                Paper_ListEx.CurrTabName = "AllPaper";
                const objPage = new Paper_ListEx_AllPaper_js_1.Paper_ListEx_AllPaper();
                await objPage.Page_Load();
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
        async liCurrEduCls_Click() {
            try {
                Paper_ListEx.CurrTabName = "CurrEduCls";
                const objPage = new Paper_ListEx_CurrEduCls_js_1.Paper_ListEx_CurrEduCls();
                await objPage.Page_Load();
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
        async liMajor_Click() {
            try {
                Paper_ListEx.CurrTabName = "Major";
                //绑定专业论文
                const objPage = new Paper_ListEx_Major_js_1.Paper_ListEx_Major();
                objPage.Page_Load();
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
        async liMajorDirection_Click() {
            try {
                Paper_ListEx.CurrTabName = "Direction";
                //绑定方向论文
                const objPage = new Paper_ListEx_Direction_js_1.Paper_ListEx_Direction();
                objPage.Page_Load();
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
                }
                else if (this.PaperSort == "2") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "paperTitle Asc";
                }
                else if (this.PaperSort == "3") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "appraiseCount Desc";
                }
                else if (this.PaperSort == "4") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "score Desc";
                }
                else if (this.PaperSort == "5") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "pcount Desc";
                }
                else if (this.PaperSort == "6") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "downloadCount Desc";
                }
                else if (this.PaperSort == "7") {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "okCount Desc";
                }
                this.btnQuery_Click();
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
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
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if ($("#hidTabPaper").val() == "1") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                //}
                //if ($("#hidTabPaper").val() == "2") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                //}
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '%${this.paperTitle_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdDate} like '%${this.updDate_q}%'`;
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
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombinevPaperCondition_EduCLs() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if ($("#hidTabPaper").val() == "1") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                //}
                //if ($("#hidTabPaper").val() == "2") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                //}
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '%${this.paperTitle_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdDate} like '%${this.updDate_q}%'`;
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
        //  /* 修改记录
        // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
        //*/
        //  public btnUpdateRecord_Click(strKeyId: string) {
        //      this.opType = "Update";
        //      //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        //      if (strKeyId == "") {
        //          alert("请选择需要修改的记录！");
        //          return;
        //      }
        //      this.UpdateRecord(strKeyId);
        //  }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vPaperBak() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevPaperCondition();
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            //var strWhereCond2: string = "";
            //var objvPaper_Cond: clsPaperEN = this.CombinevPaperConditionobj();
            ////objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
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
                arrvPaperObjLst0 = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrPaperExObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                if (strid_CurrEducls == "00000050") //私有空间
                 {
                    //arrPaperExObjLst = arrvPaperObjLst0.filter(x => x.id_CurrEduCls != "00000050");
                    //const gvResultPaper = await this.BindList_vPaper("1", arrPaperExObjLst);
                    const gvResultPaper = await this.BindList_vPaperBak("1", arrvPaperObjLst0);
                }
                else {
                    const gvResultPaper = await this.BindList_vPaperBak("1", arrvPaperObjLst0);
                }
                $("#divPager").show();
                //if (arrPaperExObjLst.length >= 10) {
                //    $("#divPager").show();
                //    this.objPager.recCount = this.recCount;
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
        async BindGv_Paper00() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevPaperCondition();
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            //var strWhereCond2: string = "";
            //var objvPaper_Cond: clsPaperEN = this.CombinevPaperConditionobj();
            ////objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperObjLst0 = [];
            var arrPaperObjLst = [];
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
                arrPaperObjLst0 = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrPaperExObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                if (strid_CurrEducls == "00000050") //私有空间
                 {
                    //arrPaperExObjLst = arrvPaperObjLst0.filter(x => x.id_CurrEduCls != "00000050");
                    //const gvResultPaper = await this.BindList_vPaper("1", arrPaperExObjLst);
                    const gvResultPaper = await (0, clsPaperExWApi_js_1.PaperEx_BindList_Paper)("1", "", arrPaperObjLst0);
                }
                else {
                    const gvResultPaper = await (0, clsPaperExWApi_js_1.PaperEx_BindList_Paper)("1", "", arrPaperObjLst0);
                }
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
                $("#divPager").show();
                //if (arrPaperExObjLst.length >= 10) {
                //    $("#divPager").show();
                //    this.objPager.recCount = this.recCount;
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
        async BindList_vPaperBak(strTypeId, arrPaperExObjLst) {
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
                arrSysVoteObjLst = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLstAsync)(strWhereCond1);
                arrPaperCollectionLogObjLst = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_GetObjLstAsync)(strWhereCond2);
                arrvPaperCountObjLst = await (0, clsvPaperCountWApi_js_1.vPaperCount_GetObjLstAsync)(strWhereCond3);
                arrgs_PaperAttentionObjLst = await (0, clsgs_PaperAttentionWApi_js_1.gs_PaperAttention_GetObjLstAsync)(strWhereCond2);
                for (var i = 0; i < arrPaperExObjLst.length; i++) {
                    const objvPaperEx = arrPaperExObjLst[i];
                    var objCount = arrvPaperCountObjLst.find(x => x.paperId == objvPaperEx.paperId); //使用find必须通过if判断不能为空后才能调用属性
                    if (objCount != null) {
                        strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                        //strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + objPaperEx.paperId + '">' + objPaperEx.paperTitle + '</a>';
                        //判断引用论文，自研论文
                        if (objvPaperEx.paperTypeId == "02") {
                            //自研论文
                            strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(原创论文)', '../GraduateEduEx/PaperDetail?paperId=" + objvPaperEx.paperId + "')\"><span class='text-info'>" + objvPaperEx.paperTitle + "(" + objvPaperEx.paperTypeName + ")</a>";
                        }
                        else {
                            strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(引用论文)', '../GraduateEduEx/PaperDetail?paperId=" + objvPaperEx.paperId + "')\">" + objvPaperEx.paperTitle + "(" + objvPaperEx.paperTypeName + ")</a>";
                        }
                        //if (objCount.attachmentCount > 0) {
                        //    strhtml += "<span class=\"btn-2\" style=\"padding-left:50px;\"><a style=\"font-size:15px; color:#f98c51\" href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + objPaperEx.paperId + "')\">pdf查看</a></span>";
                        //}
                        strhtml += '<span class="btn-2" style="padding-left:50px;"><a style="font-size:15px; color:#f98c51" href="#" onclick=PaperSubVer_Click("' + objvPaperEx.paperId + '")>pdf论文子观点查看</a></span>';
                        //只有自研论文才有历史版本
                        if (objvPaperEx.paperTypeId == "02") {
                            if (objvPaperEx.versionCount > 0 && objvPaperEx.versionCount != null) {
                                strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('自研论文历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + objvPaperEx.paperId + "&Type=10')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                            }
                        }
                        strhtml += '</h6>';
                        strhtml += '<div class="baseinfo"><span><a href="#">' + objvPaperEx.author + '</a></span><span><a href="#">' + objvPaperEx.literatureSources + '</a></span>';
                        strhtml += '<span>' + objvPaperEx.periodical + '</span><em>' + objvPaperEx.keyword + '</em>';
                        strhtml += '</div>';
                        strhtml += '<div class="abstract">' + objvPaperEx.paperContent + '</div>';
                        strhtml += '<div class="opts"><ul class="opts-count">';
                        strhtml += '<li>评论数:<em>' + objCount.appraiseCount + '</em></li><li>综合评分:<em>' + objCount.score + '</em></li>';
                        if (objCount.teaScore != null) {
                            strhtml += '<li>教师评分:<em>' + objCount.teaScore + '</em></li>';
                        }
                        if (objCount.stuScore != null) {
                            strhtml += '<li>学生评分:<em>' + objCount.stuScore + '</em></li>';
                        }
                        strhtml += '<li>读写数:<em>' + objCount.pcount + '</em></li><li>浏览量:<em>' + objvPaperEx.browseNumber + '</em></li>';
                        //strhtml += '<li>:<em>' + objPaperEx.pcount + '</em></li>';
                        var objUser = arrUsers.find(x => x.userId == objvPaperEx.updUser);
                        if (objUser != null) {
                            strhtml += '<li class="date">编辑用户：' + objUser.userName + '</li><li class="date">发表日期：' + objvPaperEx.updDate + '</li></ul>';
                        }
                        strhtml += '<ul class="opts-btn">';
                        var objAttention = arrgs_PaperAttentionObjLst.find(x => x.paperId == objvPaperEx.paperId);
                        if (objAttention == null) {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + objvPaperEx.paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px;"></i><b>关注</b></a></li>';
                        }
                        else {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAttention_Click("' + objvPaperEx.paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px; color: #1E9FFF;"></i><b>已关注</b></a></li>';
                        }
                        var objLike = arrSysVoteObjLst.find(x => x.tableKey == objvPaperEx.paperId);
                        //if (objLike == null) {
                        //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan" href="javascript:void(0)" onclick=btnAddVote_Click("' + objPaperEx.paperId + '","' + objPaperEx.updUser + '")><i></i>点赞</a></li>';
                        //    //console.log("null!");
                        //} else {
                        //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan_" href="javascript:void(0)" onclick=btnAddVote_Click("' + objPaperEx.paperId + '","' + objPaperEx.updUser + '")><i></i>已点赞</a></li>';
                        //    //console.log(objLike.paperId);
                        //}
                        if (objLike == null) {
                            strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + objvPaperEx.paperId + '","' + objvPaperEx.updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; "></i>点赞</a></li>';
                            //console.log("null!");
                        }
                        else {
                            strhtml += '<li>' + objCount.okCount + '<a href="javascript:void(0)" onclick=btnAddVote_Click("' + objvPaperEx.paperId + '","' + objvPaperEx.updUser + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; color: #1E9FFF;"></i>已点赞</a></li>';
                            //console.log(objLike.paperId);
                        }
                        var objCollection = arrPaperCollectionLogObjLst.find(x => x.paperId == objvPaperEx.paperId);
                        //var objSysVoteObjLst: Array<clsvSysVoteEN> = [];
                        //objSysVoteObjLst = arrvSysVoteObjLst.filter(x => x.updUser == "2020/02/18");
                        //if (objCollection == null) {
                        //    strhtml += '<li class="btn-collect"><a class="icon-collect" href="javascript:void(0)" onclick=btnAddCollection_Click("' + objPaperEx.paperId + '")><i></i><b>收藏</b></a></li>';
                        //    //console.log("null!");
                        //} else {
                        //    strhtml += '<li class="btn-collect"><a class="icon-collect_" href="javascript:void(0)" onclick=btnAddCollection_Click("' + objPaperEx.paperId + '")><i></i><b>已收藏</b></a></li>';
                        //    //console.log(objCollection.paperId);
                        //}
                        if (objCollection == null) {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + objvPaperEx.paperId + '")><i class="layui-icon layui-icon-rate" style="font-size: 22px; "></i><b>收藏</b></a></li>';
                            //console.log("null!");
                        }
                        else {
                            strhtml += '<li><a href="javascript:void(0)" onclick=btnAddCollection_Click("' + objvPaperEx.paperId + '")><i class="layui-icon layui-icon-rate-solid" style="font-size: 22px; color: #1E9FFF;"></i><b>已收藏</b></a></li>';
                            //console.log(objCollection.paperId);
                        }
                        //if (objCount.attachmentCount > 0) {
                        //    strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click("' + objPaperEx.paperId + '")><i></i><b>点击下载</b></a></li>';
                        //} else {
                        //    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                        //}
                        if (objCount.attachmentCount > 0) {
                            strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile"  href="#" onclick=btnDownLoadFile_Click("' + objvPaperEx.paperId + '")> <i class="layui-icon layui-icon-download-circle" style="font-size: 24px; "></i><b>点击下载</b></a></li>';
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
            const gvResult = await this.BindGv_Paper00();
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
        //添加点赞
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
                    var returnBool = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
                    if (returnBool == true) {
                        //const gvResult = await this.BindGv_Paper();
                        this.BindGv_Paper00();
                    }
                    else {
                        var strInfo = `添加下载量不成功!`;
                        alert(strInfo);
                        console.log("添加下载量不成功");
                    }
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
        async GetPaperAttachmentRecord(strPaperId) {
            var strPapeId = strPaperId;
            //this.keyId = strPaperRWId;
            var strWhereCond = ` ${clsPaperAttachmentEN_js_1.clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
            var arrPaperAttachmentObjLst = [];
            try {
                var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                arrPaperAttachmentObjLst = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetObjLstAsync)(strWhereCond);
                for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {
                    var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                    doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
                }
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
        //添加收藏
        async btnAddAttention_Click(objPage, strPaperId) {
            const strThisFuncName = this.btnAddAttention_Click.name;
            try {
                const objPage_Edit = new gs_PaperAttention_EditEx_js_1.gs_PaperAttention_EditEx(objPage);
                const returnBool = await objPage_Edit.btnAttention_Click(strPaperId);
                let objPage_Sub;
                if (returnBool == true) {
                    switch (Paper_ListEx.CurrTabName) {
                        case "AllPaper":
                            objPage_Sub = new Paper_ListEx_AllPaper_js_1.Paper_ListEx_AllPaper();
                            await objPage_Sub.Page_Load();
                            break;
                        case "CurrEduCls":
                            objPage_Sub = new Paper_ListEx_CurrEduCls_js_1.Paper_ListEx_CurrEduCls();
                            await objPage_Sub.Page_Load();
                            break;
                        case "Major":
                            objPage_Sub = new Paper_ListEx_Major_js_1.Paper_ListEx_Major();
                            await objPage_Sub.Page_Load();
                            break;
                        case "Direction":
                            objPage_Sub = new Paper_ListEx_Direction_js_1.Paper_ListEx_Direction();
                            await objPage_Sub.Page_Load();
                            break;
                        default:
                            strMsg = '当前Tab:' + Paper_ListEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    var strInfo = `收藏不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                return returnBool; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `关注不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        async btnAddCollection_Click(strPaperId) {
            const strThisFuncName = this.btnAddAttention_Click.name;
            try {
                const returnBool = await (0, clsPaperCollectionLogExWApi_js_1.PaperCollectionLogEx_btnAddCollection_Click)(strPaperId, clsPublocalStorage_js_1.clsPublocalStorage.userId);
                let objPage_Sub;
                if (returnBool == true) {
                    switch (Paper_ListEx.CurrTabName) {
                        case "AllPaper":
                            objPage_Sub = new Paper_ListEx_AllPaper_js_1.Paper_ListEx_AllPaper();
                            await objPage_Sub.Page_Load();
                            break;
                        case "CurrEduCls":
                            objPage_Sub = new Paper_ListEx_CurrEduCls_js_1.Paper_ListEx_CurrEduCls();
                            await objPage_Sub.Page_Load();
                            break;
                        case "Major":
                            objPage_Sub = new Paper_ListEx_Major_js_1.Paper_ListEx_Major();
                            await objPage_Sub.Page_Load();
                            break;
                        case "Direction":
                            objPage_Sub = new Paper_ListEx_Direction_js_1.Paper_ListEx_Direction();
                            await objPage_Sub.Page_Load();
                            break;
                        default:
                            strMsg = '当前Tab:' + Paper_ListEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    var strInfo = `收藏不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                return returnBool; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `关注不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        async btnAddVote_Click(strPaperId) {
            const strThisFuncName = this.btnAddAttention_Click.name;
            try {
                const objPaper = await (0, clsPaperWApi_js_1.Paper_GetObjByPaperIdAsync)(strPaperId);
                if (objPaper == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                const returnBool = await (0, clsSysVoteExWApi_js_1.SysVoteEx_btnAddVote_Click_PaperId)(strPaperId, clsPublocalStorage_js_1.clsPublocalStorage.userId, objPaper.updUser);
                let objPage_Sub;
                if (returnBool == true) {
                    switch (Paper_ListEx.CurrTabName) {
                        case "AllPaper":
                            objPage_Sub = new Paper_ListEx_AllPaper_js_1.Paper_ListEx_AllPaper();
                            await objPage_Sub.Page_Load();
                            break;
                        case "CurrEduCls":
                            objPage_Sub = new Paper_ListEx_CurrEduCls_js_1.Paper_ListEx_CurrEduCls();
                            await objPage_Sub.Page_Load();
                            break;
                        case "Major":
                            objPage_Sub = new Paper_ListEx_Major_js_1.Paper_ListEx_Major();
                            await objPage_Sub.Page_Load();
                            break;
                        case "Direction":
                            objPage_Sub = new Paper_ListEx_Direction_js_1.Paper_ListEx_Direction();
                            await objPage_Sub.Page_Load();
                            break;
                        default:
                            strMsg = '当前Tab:' + Paper_ListEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    var strInfo = `收藏不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                return returnBool; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `关注不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        async SetMajorDirectionName(strid_XzMajor) {
            let arrObjLst_Sel = await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjLst_Cache)(strid_XzMajor);
            if (arrObjLst_Sel == null)
                return;
            arrObjLst_Sel = arrObjLst_Sel.filter(x => x.id_XzMajor == strid_XzMajor);
            for (var i = 0; i < arrObjLst_Sel.length; i++) {
                if (i == 0) {
                    let strMajorDirectionName;
                    if ((0, clsString_js_1.IsNullOrEmpty)(clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionId) == true) {
                        strMajorDirectionName = (0, clsString_js_1.Format)("<span class='text-nowrap'><span class='font-weight-bold'>[{0}]</span>方向论文</span>", arrObjLst_Sel[i].majorDirectionName);
                        $("#aMajorDirectionName").html(strMajorDirectionName);
                    }
                    else {
                        strMajorDirectionName = (0, clsString_js_1.Format)("<span class='text-nowrap'><span class='font-weight-bold'>[{0}]</span>方向论文</span>", clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionName);
                        $("#aMajorDirectionName").html(strMajorDirectionName);
                    }
                }
            }
        }
        /** 函数功能:设置事件函数
       * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
       **/
        async SetEventFunc() {
            const strThisFuncName = this.SetEventFunc.name;
            // 在此处放置用户代码以初始化页面
            try {
                //没有定义相关事件
                const ddlMajorDirectionId_SetFldValue = (0, clsCommFunc4Ctrl_js_1.GetSelectObjInDiv)(this.divName4Query, 'ddlMajorDirectionId_SetFldValue');
                ddlMajorDirectionId_SetFldValue.addEventListener('change', e => { this.ddlMajorDirectionId_SetFldValue_SelectedIndexChanged(ddlMajorDirectionId_SetFldValue); });
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("设置事件函数不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 函数功能:系统生成的Change事件函数
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript+<>c__DisplayClass13_0:<Gen_WApi_Ts_GeneEventFuncEx>b__1)
    */
        async ddlMajorDirectionId_SetFldValue_SelectedIndexChanged(ddlMajorDirectionId_SetFldValue) {
            const strThisFuncName = this.ddlMajorDirectionId_SetFldValue_SelectedIndexChanged.name;
            const strMajorDirectionId = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Query, "ddlMajorDirectionId_SetFldValue");
            if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true)
                return;
            clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionId = strMajorDirectionId;
            const objXzMajorDirection = await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjByMajorDirectionId_Cache)(strMajorDirectionId, clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
            if (objXzMajorDirection == null) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionName = objXzMajorDirection.majorDirectionName;
            const strMajorDirectionName = (0, clsString_js_1.Format)("<span class='text-nowrap'><span class='font-weight-bold'>[{0}]</span>方向论文</span>", objXzMajorDirection.majorDirectionName);
            $("#aMajorDirectionName").html(strMajorDirectionName);
            const objPage = new Paper_ListEx_Direction_js_1.Paper_ListEx_Direction();
            await objPage.Page_Load();
        }
    }
    exports.Paper_ListEx = Paper_ListEx;
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrsortPaperBy: string = "paperId";
    Paper_ListEx.CurrTabName = "AllPaper";
});
