(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPaper/PaperSubViewpoint_EditEx.js", "../PagesBase/GraduateEduPaper/PaperSubViewpointCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js", "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js", "../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js", "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsPaperSubViewpointExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperSubViewpoint_QUDIEx = void 0;
    const PaperSubViewpoint_EditEx_js_1 = require("../GraduateEduPaper/PaperSubViewpoint_EditEx.js");
    const PaperSubViewpointCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperSubViewpointCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperDownloadLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js");
    const clsPaperSubViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js");
    const clsSectionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js");
    const clsvPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js");
    const clsvPaperSubViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js");
    const clsExplainTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js");
    const clsSubViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperDownloadLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js");
    const clsPaperSubAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js");
    const clsPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsSectionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsExplainTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js");
    const clsSubViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js");
    const clsPaperSubViewpointExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsPaperSubViewpointExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PaperSubViewpoint_QUDIEx extends PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 50;
        }
        BindGv(strType, strPara) {
            this.BindGv_vPaperSubViewpoint();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vPaperSubViewpoint":
                    //alert('该类没有绑定该函数：[this.BindGv_vPaperSubViewpoint_Cache]！');
                    this.btnReOrder_Click();
                    this.BindGv_vPaperSubViewpoint();
                    //this.BindGv_vPaperSubViewpoint_Cache();
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
            let objPage;
            if (PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.objPage_CRUD == null) {
                PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.objPage_CRUD = new PaperSubViewpoint_QUDIEx();
                objPage = PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.objPage_CRUD;
            }
            else {
                objPage = PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.objPage_CRUD;
            }
            const objPage_Edit = new PaperSubViewpoint_EditEx_js_1.PaperSubViewpoint_EditEx(objPage);
            let strMsg = '';
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                case "UpdateRecordInTab": //修改记录InTab
                    strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        const strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (strCommandName == "UpdateRecordInTab") {
                        objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    }
                    else {
                        objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    }
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
                    strMsg = '命令:' + strCommandName + "在函数(PaperSubViewpointCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strUserId != "") {
                    //1、为下拉框设置数据源,绑定列表数据
                    var strWhereCond1 = this.CombinevPaperSubViewpointCondition1();
                    var objvPaperReadWrite = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN;
                    const responseObjLst = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetFirstObjAsync)(strWhereCond1).then((jsonData) => {
                        objvPaperReadWrite = jsonData;
                    });
                    const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId", objvPaperReadWrite.paperId);
                    const ddl_SectionId_q = await this.BindDdl_SectionId("ddlSectionId_q", objvPaperReadWrite.paperId);
                    const ddl_SubViewpointTypeId_q = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId_q");
                    //const ddl_ExplainTypeId_q = await this.BindDdl_ExplainTypeId("ddlExplainTypeId_q");
                    const ddl_SubViewpointTypeId = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId");
                    const ddl_ExplainTypeId = await this.BindDdl_ExplainTypeId("ddlExplainTypeId");
                    //PaperSubViewpointCRUD.sortvPaperSubViewpointBy = "subViewpointTypeName Asc";
                    //var strWhereCond = await this.CombinevPaperSubViewpointCondition();
                    //this.recCount= await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //    
                    //});
                    //2、显示无条件的表内容在GridView中
                    const gvResult0 = await this.GetReadWriteData(objvPaperReadWrite);
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    const gvResult = await this.BindGv_vPaperSubViewpoint();
                    //tbody();
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
        //
        /// <summary>
        /// 为下拉框获取数据,从表:[SubViewpointType]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_SubViewpointTypeId(ddlSubViewpointTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlSubViewpointTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlSubViewpointTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    //const responseText = SubViewpointType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    const responseText = (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetObjLst_Cache)().then((jsonData) => {
                        var arrSubViewpointTypeObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlSubViewpointTypeId, arrSubViewpointTypeObjLst, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName, "子观点类型");
                        console.log("完成BindDdl_SubViewpointTypeId!");
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
        /// 为下拉框获取数据,从表:[ExplainType]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_ExplainTypeId(ddlExplainTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlExplainTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlExplainTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    //const responseText = ExplainType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    const responseText = (0, clsExplainTypeWApi_js_1.ExplainType_GetObjLst_Cache)().then((jsonData) => {
                        var arrExplainTypeObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlExplainTypeId, arrExplainTypeObjLst, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName, "说明类型");
                        console.log("完成BindDdl_ExplainTypeId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        async DetailRecord() {
            //this.keyId = strPaperRWId;
            var strWhereCond = await this.CombinevPaperSubViewpointCondition1();
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                        var objvPaperReadWriteEN = jsonData;
                        this.GetReadWriteData(objvPaperReadWriteEN);
                        console.log("完成Detail!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        GetReadWriteData(pobjvPaperReadWriteEN) {
            $("#hidPaperId").val(pobjvPaperReadWriteEN.paperId); //论文ID
            $("#txtPaperTitle").html(pobjvPaperReadWriteEN.paperTitle); //论文标题
            $("#txtKeyword").html(pobjvPaperReadWriteEN.keyword); //关键字Id
            $("#txtPeriodical").html(pobjvPaperReadWriteEN.periodical); //
            $("#txtAuthor").html(pobjvPaperReadWriteEN.author); //作者
            $("#txtResearchQuestion").html(pobjvPaperReadWriteEN.researchQuestion); //研究问题
            $("#txtPaperContent").html(pobjvPaperReadWriteEN.paperContent); //论文内容
            $("#hidIsSubmit").val(pobjvPaperReadWriteEN.isSubmit); //是否提交
            console.log($("#hidIsSubmit").val());
            //$("#txtMemo").html(pobjvPaperReadWriteEN.memo);//备注
            this.DetailRecordDownload(pobjvPaperReadWriteEN.paperId);
        }
        async DetailRecordDownload(strPaperId) {
            const strThisFuncName = this.DetailRecordDownload.name;
            //this.keyId = strPaperRWId;
            var strWhereCond = " paperId ='" + strPaperId + "'";
            try {
                const objvPaperEN = await (0, clsPaperWApi_js_1.Paper_GetFirstObjAsync)(strWhereCond);
                if (objvPaperEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if (objvPaperEN.attachmentCount > 0) {
                    $("#btnDownLoadFile").show();
                    $("#lblDownLoadFile").hide();
                }
                else {
                    $("#btnDownLoadFile").hide();
                    $("#lblDownLoadFile").show();
                }
                console.log("完成Detail!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        CombinevPaperSubViewpointCondition1() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperRWId = $("#hidPaperRWId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (strPaperRWId != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition2() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.subViewpointTypeId_q != "" && this.subViewpointTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.subViewpointTypeId_q}'`;
                }
                strWhereCond += " order by orderNum Asc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition3() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1=1 ";
            var strPaperRWId = $("#hidPaperRWId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.sectionId_q != "" && this.sectionId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId} = '${this.sectionId_q}'`;
                }
                if (strPaperRWId != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
                }
                if (this.subViewpointTypeId_q != "" && this.subViewpointTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.subViewpointTypeId_q}'`;
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    //判断角色 教师
                    if (strRoleId == "00620001") {
                        //$("#btnDelRecord").show();
                    }
                    else if (strRoleId == "00620002") {
                        //可以查看所有；
                    }
                    else {
                        strWhereCond += " And updUser = '" + strUserId + "'";
                        //学生00620003
                        //只能查看自己的数据；或公开的数据；
                        //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                        //strWhereCond += ` And updUser = '${objvUserRoleRelation.userId}'`;
                    }
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
                //if (this.ExplainTypeId_q != "" && this.ExplainTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvPaperSubViewpointEN.con_ExplainTypeId} = '${this.ExplainTypeId_q}'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition4() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperRWId = $("#hidPaperRWId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.sectionId_q != "" && this.sectionId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId} = '${this.sectionId_q}'`;
                }
                if (strPaperRWId != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
                }
                strWhereCond += " order by orderNum Asc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperSubViewpointCondition5() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            return strWhereCond;
        }
        async BindGv_vPaperSubViewpoint() {
            //var strListDiv: string = this.mstrListDiv;
            var strWhereCond2 = this.CombinevPaperSubViewpointCondition2();
            var strWhereCond3 = this.CombinevPaperSubViewpointCondition3();
            var strWhereCond4 = this.CombinevPaperSubViewpointCondition4();
            var strWhereCond5 = this.CombinevPaperSubViewpointCondition5();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrSectionObjLst = [];
            var arrSubViewpointTypeObjLst = [];
            var arrvPaperSubViewpointObjLst = [];
            var arrvPaperSubViewpointObjLst2 = [];
            //获取图片
            var arrPaperSubAttachmentObjLst = [];
            var arrPaperSubAttachmentObjLst2 = [];
            try {
                //const responseText1 = Section_GetObjLstAsync(strWhereCond4).then((jsonData) => {
                //    arrSectionObjLst = <Array<clsSectionEN>>jsonData;
                //});
                const responseText2 = (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                    arrSubViewpointTypeObjLst = jsonData;
                });
                this.recCount = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCondAsync)(strWhereCond3);
                PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.sortvPaperSubViewpointBy = "orderNum Asc";
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond3,
                    orderBy: PaperSubViewpointCRUD_js_1.PaperSubViewpointCRUD.sortvPaperSubViewpointBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst3 = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperSubViewpointObjLst2 = jsonData;
                });
                const responseRecCount4 = await (0, clsPaperSubAttachmentWApi_js_1.PaperSubAttachment_GetObjLstAsync)(strWhereCond5).then((jsonData) => {
                    arrPaperSubAttachmentObjLst2 = jsonData;
                });
                var strhtml = "";
                //$('#divTwo li').remove();
                var cateid = 0;
                var cateid_ = 0;
                var intJ = 0;
                $('#tbList tr').remove();
                for (var j = 0; j < arrSubViewpointTypeObjLst.length; j++) {
                    cateid++;
                    intJ++;
                    var fid = 0;
                    var strsubTypeId = arrSubViewpointTypeObjLst[j].subViewpointTypeId;
                    //先创建子模块类型
                    //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>' + cateid + '</td><td></td><td><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></td><td></td><td></td><td class="td-manage">';
                    if ($("#hidIsSubmit").val() == "true") {
                        strhtml += '</td></tr>';
                    }
                    else {
                        strhtml += '<button class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '");><i class="layui-icon">&#xe642;</i>添加子栏目</button>';
                        strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnReOrder_Click("' + strsubTypeId + '")><i class="layui-icon">&#xe642;</i>重序</button>';
                        strhtml += '</td></tr>';
                    }
                    //子类型数据
                    var strSubViewpointId = "";
                    cateid_ = cateid;
                    var intK = 0;
                    arrvPaperSubViewpointObjLst = arrvPaperSubViewpointObjLst2.filter(x => x.subViewpointTypeId == strsubTypeId);
                    for (var k = 0; k < arrvPaperSubViewpointObjLst.length; k++) {
                        strSubViewpointId = arrvPaperSubViewpointObjLst[k].subViewpointId;
                        //先判断子模块类型数据ID和子观点知否匹配；
                        //if (strsubTypeId == arrvPaperSubViewpointObjLst[k].subViewpointTypeId) {
                        cateid++;
                        intK++;
                        //if (arrSectionObjLst.length != 0) {
                        //for (var i = 0; i < arrSectionObjLst.length; i++) {
                        //var strSectionId: string = arrSectionObjLst[i].sectionId;
                        //var strSectionName: string = arrSectionObjLst[i].sectionName;
                        //strhtml += '<li class="ui-li-has-alt ui-first-child"><a href="#" onclick="btnUpdateRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')" class="ui-btn" ><p>' + this.vSubViewpointObjLst[k].subViewpointContent + '</p></a><a href="#" class="ui-btn ui-btn-icon-notext ui-icon-delete" title="删除" onclick="btnDeleteRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')"></a></li>';
                        strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '"><td>' + cateid + '</td><td>' + arrvPaperSubViewpointObjLst[k].sectionName + '</td><td>&nbsp;&nbsp;&nbsp;&nbsp;' + intK + '.<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].rwTitle + '】' + arrvPaperSubViewpointObjLst[k].subViewpointContent + '';
                        //根据子观点id 得到附件
                        arrPaperSubAttachmentObjLst = arrPaperSubAttachmentObjLst2.filter(x => x.subViewpointId == strSubViewpointId);
                        for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {
                            var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" style="margin-left: 10px; " alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';
                        }
                        if (arrvPaperSubViewpointObjLst[k].explainContent != "") {
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].explainTypeName + '】' + arrvPaperSubViewpointObjLst[k].explainContent + '';
                        }
                        //if (arrvPaperSubViewpointObjLst[k].literatureSourcesId != "") {
                        //else {
                        //    strhtml += '</td><td><input id="txt_OrderNum' + cateid + '" type="text" class="layui-input x-sort" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click(' + strSubViewpointId + ',"txt_OrderNum' + cateid + '");></td><td>' + arrvPaperSubViewpointObjLst[k].userName + '</td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage"><button class="layui-btn layui-btn layui-btn-xs" onclick="btnUpdateRecordInTab_Click(' + strSubViewpointId + ')"><i class="layui-icon">&#xe642;</i>编辑</button><button class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelRecordInTab_Click(' + strSubViewpointId + ')" href="javascript:;"><i class="layui-icon">&#xe640;</i>删除</button><button class="layui-btn layui-btn layui-btn-xs" onclick="btnUpMoveEx_Click(' + strSubViewpointId + ')" href="javascript:;"><i class="iconfont">&#xe6a5;</i>上移</button><button class="layui-btn layui-btn layui-btn-xs" onclick="btnDownMove_Click(' + strSubViewpointId + ')" href="javascript:;"><i class="iconfont">&#xe6a6;</i>下移</button></td></tr>';
                        //}
                        strhtml += '</td><td><input id="txt_OrderNum' + cateid + '" type="text" class="layui-input x-sort" style="width:40px;" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click("' + strSubViewpointId + '","txt_OrderNum' + cateid + '");>';
                        //上移
                        strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a5;</i></button>';
                        //下移
                        strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a6;</i></button>';
                        strhtml += '</td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage">';
                        if ($("#hidIsSubmit").val() == "true") {
                            strhtml += '' + arrvPaperSubViewpointObjLst[k].okCount + '&nbsp;&nbsp;<img src="../img/vote.png" width = "20px" height = "20px" title = "点赞数" >';
                            strhtml += '&nbsp;&nbsp;评论数：<a href="#" onclick=btnShowAppraise_Click("' + strSubViewpointId + '")>' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a>';
                            if (arrvPaperSubViewpointObjLst[k].score == null) {
                                strhtml += '&nbsp;&nbsp;评分：0';
                            }
                            else {
                                strhtml += '&nbsp;&nbsp;评分：' + arrvPaperSubViewpointObjLst[k].score + '';
                            }
                            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = "btnAddAppraise_Click(' + strSubViewpointId + ')" > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                        }
                        else {
                            strhtml += '<button class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strSubViewpointId + '")><i class="layui-icon">&#xe642;</i>编辑</button>';
                            strhtml += '<button class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strSubViewpointId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i>删除</button>';
                        }
                        //if (clsPublocalStorage.userId == arrvPaperSubViewpointObjLst[k].updUser && arrvPaperSubViewpointObjLst[k].IsPublicEx == false) {
                        //} else {
                        //    if (arrvPaperSubViewpointObjLst[k].literatureSourcesId == null || arrvPaperSubViewpointObjLst[k].literatureSourcesId == "") {
                        //        strhtml += '</td><td>' + arrvPaperSubViewpointObjLst[k].orderNum + '</td><td>' + arrvPaperSubViewpointObjLst[k].userName + '</td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage">' + arrvPaperSubViewpointObjLst[k].okCount + '&nbsp;&nbsp;<a href="#" onclick="btnAddLikeLog_Click(' + strSubViewpointId + ')"><img src="../img/vote.png" width="20px" height="20px"  title="点赞"></a>&nbsp;&nbsp;评论数：<a href="#" onclick="btnShowAppraise_Click(' + strSubViewpointId + ')">' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a>&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick="btnAddAppraise_Click(' + strSubViewpointId + ')"><i class="layui-icon">&#xe642;</i>添加评论</button></td></tr>';
                        //    }
                        //    else {
                        strhtml += '</td></tr>';
                        //}
                        //}
                        //}
                    }
                }
                //拼接；
                $("#tbList").append(strhtml);
                //调用拼接方法
                //this.GetHtmlByDataSource();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*查询*/
        async btnQueryEx_Click() {
            try {
                const gvResult = await this.BindGv_vPaperSubViewpoint();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
       重序
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
       */
        async btnReOrder_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = $("#hidSubViewpointTypeId").val();
            var strPaperRWId = $("#hidPaperRWId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_ReOrderAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        }
        //public async btnUpMoveEx_Click(strKeyId: string) {
        //    if (this.PreCheck4Order() == false) return;
        //    var strSubViewpointTypeId: string = this.subViewpointTypeId;
        //    var strPaperRWId: string = $("#hidPaperRWId").val();
        //    var arrKeyIds = strKeyId;
        //    try {
        //        var objOrderByData: clsOrderByData = new clsOrderByData();
        //        objOrderByData.KeyIdLst.push(arrKeyIds);
        //        var jsonObject =
        //        {
        //            "subViewpointTypeId": strSubViewpointTypeId,
        //            "paperRWId": strPaperRWId,
        //        };
        //        var jsonStr: string = JSON.stringify(jsonObject);
        //        objOrderByData.ClassificationFieldValueLst = jsonStr;
        //        const responseRederBy = await PaperSubViewpoint_UpMoveAsync(objOrderByData);
        //    }
        //    catch (e) {
        //        var strMsg: string = `上移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
        //        alert(strMsg);
        //        return;
        //    }
        //    const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //}
        /*
        上移
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
        */
        async btnUpMove_Click() {
            if ($('#hidOrderNum').val() == 0) {
                const responseOrder = await this.btnReOrder_Click();
            }
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = $("#hidSubViewpointTypeId").val();
            var strPaperRWId = $("#hidPaperRWId").val();
            var arrKeyIds = $("#hidKeyId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_UpMoveAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `上移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            //var strListDiv: string = this.mstrListDiv;
            //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        //public async btnDownMove_Click(strKeyId: string) {
        //    if (this.PreCheck4Order() == false) return;
        //    var strSubViewpointTypeId: string = this.subViewpointTypeId;
        //    var strPaperRWId: string = $("#hidPaperRWId").val();
        //    var arrKeyIds = strKeyId;
        //    try {
        //        var objOrderByData: clsOrderByData = new clsOrderByData();
        //        //objOrderByData.KeyIdLst = arrKeyIds;
        //        objOrderByData.KeyIdLst.push(arrKeyIds);
        //        var jsonObject =
        //        {
        //            "subViewpointTypeId": strSubViewpointTypeId,
        //            "paperRWId": strPaperRWId,
        //        };
        //        var jsonStr: string = JSON.stringify(jsonObject);
        //        objOrderByData.ClassificationFieldValueLst = jsonStr;
        //        const responseRederBy = await PaperSubViewpoint_DownMoveAsync(objOrderByData);
        //    }
        //    catch (e) {
        //        var strMsg: string = `下移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
        //        alert(strMsg);
        //        return;
        //    }
        //    const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //}
        /*
        下移
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
        */
        async btnDownMove_Click() {
            if ($('#hidOrderNum').val() == 0) {
                const responseOrder = await this.btnReOrder_Click();
            }
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = $("#hidSubViewpointTypeId").val();
            var strPaperRWId = $("#hidPaperRWId").val();
            var arrKeyIds = $("#hidKeyId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_DownMoveAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `下移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            //const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            //var strListDiv: string = this.mstrListDiv;
            //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /* 在数据表里修改排序记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
      */
        async btnUpdateOrderNum_Click(strKeyId, strOrderNum) {
            const strThisFuncName = this.btnUpdateOrderNum_Click.name;
            //var lngKeyId = Number(strKeyId);
            var objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            objPaperSubViewpointEN.SetSubViewpointId(strKeyId);
            objPaperSubViewpointEN.SetOrderNum(Number($("#" + strOrderNum + "").val()));
            objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_UpdateRecordAsync)(objPaperSubViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //var strInfo: string = `修改排序号成功!`;
                            //$('#lblResult44').val(strInfo);
                            ////显示信息框
                            //alert(strInfo);
                            const responseBindGv = this.BindGv_vPaperSubViewpoint();
                        }
                        else {
                            //var strInfo: string = `修改排序号不成功!`;
                            //$('#lblResult44').val(strInfo);
                            ////显示信息框
                            //alert(strInfo);
                            //console.log("完成UpdateRecordSave");
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
        /// <summary>
        /// 为下拉框获取数据,从表:[Section]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_SectionId(ddlSectionId, strPaperId) {
            var strWhereCond = " 1 =1 and paperId='" + strPaperId + "'";
            var objDdl = document.getElementById(ddlSectionId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlSectionId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSectionWApi_js_1.Section_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrSectionObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlSectionId, arrSectionObjLst, clsSectionEN_js_1.clsSectionEN.con_SectionId, clsSectionEN_js_1.clsSectionEN.con_SectionName, "论文节");
                        console.log("完成BindDdl_SectionId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /*
        * 论文读写Id
       */
        // public set paperRWId(value: string) {
        //     $("#hidPaperRWId").val(value);
        // }
        // /*
        // * 论文读写Id
        //*/
        // public get paperRWId(): string {
        //     return $("#hidPaperRWId").val();
        // }
        //添加点赞
        //public async btnAddLikeLog_Click() {
        //    //this.DivName = "divAddNewRecordSave";
        //    var objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();
        //    //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        //    objPaperSubViewpointLikeLogEN.SetSubViewpointId($("#hidSubViewpointId").val();
        //    objPaperSubViewpointLikeLogEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
        //    objPaperSubViewpointLikeLogEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
        //    var strWhereCond = " 1 =1 and updUser='" + objPaperSubViewpointLikeLogEN.updUser + "' and subViewpointId=" + objPaperSubViewpointLikeLogEN.subViewpointId;
        //    try {
        //        const responseText = await PaperSubViewpointLikeLog_IsExistRecordAsync(strWhereCond);
        //        var bolIsExist: boolean = responseText;
        //        if (bolIsExist == true) {
        //            var strMsg: string = `您已经点赞过这条观点了，请给其他观点点赞一下吧！`;
        //            alert(strMsg);
        //            return responseText;//一定要有一个返回值，否则会出错！
        //        }
        //        const responseText2 = await PaperSubViewpointLikeLog_AddNewRecordAsync(objPaperSubViewpointLikeLogEN);
        //        var returnBool: boolean = !!responseText2;
        //        if (returnBool == true) {
        //            var strInfo: string = `点赞成功!`;
        //            $('#lblResult40').val(strInfo);
        //            //显示信息框
        //            alert(strInfo);
        //            this.BindGv_vPaperSubViewpoint();
        //        }
        //        else {
        //            var strInfo: string = `点赞不成功!`;
        //            $('#lblResult40').val(strInfo);
        //            //显示信息框
        //            alert(strInfo);
        //            this.BindGv_vPaperSubViewpoint();
        //        }
        //        return responseText2;//一定要有一个返回值，否则会出错！
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `点赞不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    return true;//一定要有一个返回值，否则会出错！
        //}
        async btnIsDisplay_Click() {
            if (this.IsDisplay == "显示论文") {
                this.IsDisplay = "隐藏论文";
                $("#tabwucPaperReadWrite").show();
            }
            else if (this.IsDisplay == "隐藏论文") {
                this.IsDisplay = "显示论文";
                $("#tabwucPaperReadWrite").hide();
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
                //var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(strKeyId);
                const responseText2 = await this.BindGv_vPaperSubViewpoint();
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
        async DelRecord(strSubViewpointId) {
            try {
                const returnInt = await (0, clsPaperSubViewpointExWApi_js_1.PaperSubViewpointEx_DelRecordAsyncEx)(strSubViewpointId);
                if (returnInt > 0) {
                    //删除子观点时，需要同时去删除附件；
                    //根据Id删除附件
                    var strwhere = "subViewpointId ='" + strSubViewpointId + "'";
                    this.DelAttactmentRecordByWhere(strwhere);
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
    根据关键字删除记录 附件
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        DelAttactmentRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubAttachmentWApi_js_1.PaperSubAttachment_DelPaperSubAttachmentsByCondAsync)(strWhere).then((jsonData) => {
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
        //下载文件
        btnDownLoadFile_Click() {
            this.GetPaperAttachmentRecord();
            this.btnAddDownload_Click();
        }
        GetPaperAttachmentRecord() {
            var strPapeId = $("#hidPaperId").val();
            //this.keyId = strPaperRWId;
            var strWhereCond = ` ${clsPaperAttachmentEN_js_1.clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
            var arrPaperAttachmentObjLst = [];
            try {
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
        //添加下载量
        async btnAddDownload_Click() {
            //this.DivName = "divAddNewRecordSave";
            var objPaperDownloadLogEN = new clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperDownloadLogEN.SetPaperId($("#hidPaperId").val());
            objPaperDownloadLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objPaperDownloadLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + objPaperDownloadLogEN.paperId;
            try {
                //const responseText = await PaperDownloadLog_IsExistRecordAsync(strWhereCond);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    //var strMsg: string = `您已经收藏过这条论文了！`;
                //    //alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_AddNewRecordAsync)(objPaperDownloadLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //var strInfo: string = `收藏成功!`;
                    //$('#lblResult40').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
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
        /*
       * 设置上传文件
       */
        set Uploadfile(value) {
            $("#txtUploadfile").val(value);
        }
        /*
        * 获取上传文件
        */
        get Uploadfile() {
            return $("#txtUploadfile").val();
        }
        /*
       * 设置是否隐藏显示
       */
        set IsDisplay(value) {
            $("#btnIsDisplay").html(value);
        }
        /*
        * 获取是否隐藏显示
        */
        get IsDisplay() {
            return $("#btnIsDisplay").html();
        }
        /*
       移动记录序号时的预检查函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
       */
        PreCheck4Order() {
            var strSubViewpointTypeId = this.SubViewpointTypeId_OrderNum;
            if (strSubViewpointTypeId == "") {
                var strMsg = `请输入subViewpointTypeId!`;
                alert(strMsg);
                return false;
            }
            var strPaperRWId = this.PaperRWId_OrderNum;
            if (strPaperRWId == "") {
                var strMsg = `请输入paperRWId!`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /*
       * 论文读写Id
      */
        get paperRWId() {
            return $("#txtPaperRWId").val();
        }
        /*
        * paperRWId
       */
        get PaperRWId_OrderNum() {
            return $("#txtPaperRWId_OrderNum").val();
        }
        /*
        * 论文读写Id
       */
        get PaperRWId_q() {
            return $("#txtPaperRWId_q").val();
        }
        /*
      * subViewpointTypeId
     */
        get SubViewpointTypeId_OrderNum() {
            return $("#ddlSubViewpointTypeId_OrderNum").val();
        }
    }
    exports.PaperSubViewpoint_QUDIEx = PaperSubViewpoint_QUDIEx;
});
