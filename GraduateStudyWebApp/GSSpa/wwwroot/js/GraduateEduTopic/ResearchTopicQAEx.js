(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../InteractManage/qa_PaperCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_RTqa_PaperRelaEN.js", "../TS/L0_Entity/InteractManage/clsqa_PaperEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_RTqa_PaperRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_RTqa_PaperRelaWApi.js", "../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApiEx/GraduateEduTopic/clsgs_RTqa_PaperRelaExWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopicQAEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:WApiConcept_QUDI_CacheEx
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
    const qa_PaperCRUD_js_1 = require("../InteractManage/qa_PaperCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsgs_RTqa_PaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_RTqa_PaperRelaEN.js");
    const clsqa_PaperEN_js_1 = require("../TS/L0_Entity/InteractManage/clsqa_PaperEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsgs_RTqa_PaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_RTqa_PaperRelaWApi.js");
    const clsvgs_RTqa_PaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvgs_RTqa_PaperRelaWApi.js");
    const clsqa_PaperWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsgs_RTqa_PaperRelaExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTopic/clsgs_RTqa_PaperRelaExWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsSysPara4WebApi2_js_1 = require("../TS/PubFun/clsSysPara4WebApi2.js");
    /* WApiConcept_QUDI_CacheEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class ResearchTopicQAEx extends qa_PaperCRUD_js_1.qa_PaperCRUD {
        constructor() {
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvgs_RTqa_PaperRelaBy: string = "qa_PaperId";
            super(...arguments);
            //答疑列表
            this.mstrListDiv = "divRTqa_PaperRelaDataLst";
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 20;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    //建立缓存
                    //
                    // 为查询区绑定下拉框
                    //const gvBindDdl = await this.BindDdl4QueryRegion();
                    this.hidSortvgs_RTqa_PaperRelaBy = "updDate Desc";
                    //this.hidSortvPaperBy = "updDate Desc";
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult1 = await this.SynTopicPaperQA();
                    const gvResult2 = await this.BindGv_vgs_RTqa_PaperRela();
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
        //同步论文和论文答疑
        async SynTopicPaperQA() {
            try {
                var strid_CurrEduCls = $("#hidId_CurrEduCls").val();
                var strTopicId = $('#hidTopicRelaId').val();
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                const responseText = await clsgs_RTqa_PaperRelaExWApi_js_1.clsgs_RTqa_PaperRelaExWApi.SynTopicPaperQAAsync(strid_CurrEduCls, strTopicId, strUserId);
                var returnBool = !!responseText;
                if (returnBool == false) {
                    var strMsg = `同步论文答疑不成功！`;
                }
                else {
                    console.log("同步论文答疑成功!");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `同步论文答疑不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        Combinevgs_RTqa_PaperRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                strWhereCond += " and id_CurrEduCls=" + $("#hidId_CurrEduCls").val();
                //strWhereCond += " and isPublic=0";
                strWhereCond += " and topicId=" + $('#hidTopicRelaId').val();
                //if (this.PaperTitle_q != "") {
                //    strWhereCond += ` And ${clsvgs_RTqa_PaperRelaEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                //}
                //if (this.UserName_q != "") {
                //    strWhereCond += ` And ${clsvgs_RTqa_PaperRelaEN.con_UserName} like '% ${this.UserName_q}%'`;
                //}
                //if (this.UpdDate_q != "") {
                //    strWhereCond += ` And ${clsvgs_RTqa_PaperRelaEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
                //}
                //if ($('#hidTypeId').val() == "2") {
                //    $('#FunInfo').show();
                //    $('#btnAddNewRecord').show();
                //    $('#btnDelRecord').show();
                //    strWhereCond += " and updUser=" + clsPubSessionStorage.GetSession_UserId();
                //}
                //else {
                //    $('#FunInfo').hide();
                //    $('#btnDelRecord').hide();
                //    $('#btnAddNewRecord').hide();
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combineqa_PaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        async btnQuery_Click() {
            const gvResult = await this.BindGv_vgs_RTqa_PaperRela();
        }
        /* 根据条件获取相应的对象列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vgs_RTqa_PaperRela() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.Combinevgs_RTqa_PaperRelaCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvgs_RTqa_PaperRelaObjLst = [];
            try {
                const responseRecCount = await (0, clsvgs_RTqa_PaperRelaWApi_js_1.vgs_RTqa_PaperRela_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvgs_RTqa_PaperRelaBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvgs_RTqa_PaperRelaWApi_js_1.vgs_RTqa_PaperRela_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvgs_RTqa_PaperRelaObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvgs_RTqa_PaperRelaObjLst.length > 20) {
                $("#divRTqa_PaperRela").show();
            }
            try {
                this.BindTab_vgs_RTqa_PaperRela(strListDiv, arrvgs_RTqa_PaperRelaObjLst);
                console.log("完成BindGv_vgs_RTqa_PaperRela!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vgs_RTqa_PaperRela对象的所有属性值
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        <param name = "divContainer">显示容器</param>
        <param name = "arrqa_PaperObjLst">需要绑定的对象列表</param>
      */
        BindTab_vgs_RTqa_PaperRela(divContainer, arrvgs_RTqa_PaperRelaObjLst) {
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
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "isPublic",
                //    ColHeader: "是否公开",
                //    Text: "", TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "qaUserName",
                    ColHeader: "用户",
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
                    FldName: "attachmentCount",
                    ColHeader: "附件计数",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "tagsCount",
                    ColHeader: "标注数",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "questionsCount",
                    ColHeader: "提问数",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "answerCount",
                    ColHeader: "回答数",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "参与答疑",
                    Text: "参与答疑", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnQARecord_Click(${strKeyId});`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvgs_RTqa_PaperRelaObjLst, arrDataColumn, "mId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //正常跳转到pdf答疑页面
        async btnQARecord_Click(strKeyId) {
            var objvgs_RTqa_PaperRela;
            var objPaperAttachment;
            var strWhereCond1 = " 1=1 and mId=" + strKeyId + "";
            try {
                const responseText1 = await (0, clsvgs_RTqa_PaperRelaWApi_js_1.vgs_RTqa_PaperRela_GetFirstObjAsync)(strWhereCond1);
                objvgs_RTqa_PaperRela = responseText1;
                var strWhereCond2 = " 1=1 and paperId ='" + objvgs_RTqa_PaperRela.paperId + "' order by updDate Desc";
                const responseText2 = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetFirstObjAsync)(strWhereCond2);
                objPaperAttachment = responseText2;
                var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
                var strHref = "";
                if (objPaperAttachment != null) {
                    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                    strHref = "../InteractManage/Pdf_QA?zoom=1.1&topicId=" + objvgs_RTqa_PaperRela.topicId + "&qa_PaperId=" + objvgs_RTqa_PaperRela.qa_PaperId + "&paperId=" + objvgs_RTqa_PaperRela.paperId + "&file=" + strfilepath;
                }
                else {
                    strHref = "../InteractManage/Pdf_QA?zoom=1.1&topicId=" + objvgs_RTqa_PaperRela.topicId + "&qa_PaperId=" + objvgs_RTqa_PaperRela.qa_PaperId + "&paperId=" + objvgs_RTqa_PaperRela.paperId + "";
                }
                //window.location.href = "xadmin.open('添加论文观点', '" + strHref + "', '', '', true)";
                xadminopen(strHref);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new ResearchTopicQAEx();
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //ShowDialogQA('AddWithMaxId');
                    console.log('进入了btn_Click事件');
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //ShowDialogQA('AddWithMaxId');
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
        //public async btnAddNewRecordWithMaxId_Click() {
        //    this.OpType = "AddWithMaxId";
        //    try {
        //        if (this.bolIsLoadEditRegion == false)  //
        //        {
        //            console.log('开始添加AddDPV_Edit界面');
        //            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
        //            // 为编辑区绑定下拉框
        //            console.log('结束AddDPV_Edit界面');
        //            const conBindDdl = await this.BindDdl4EditRegion();
        //            console.log('结束BindDdl4EditRegion绑定');
        //            ShowDialogQA('Add');
        //            this.BindGv_vPaper();
        //            this.bolIsLoadEditRegion = true;  //
        //        }
        //        else {
        //            ShowDialogQA('Add');
        //            console.log('开始绑定BindGv_vPaper');
        //            this.BindGv_vPaper();
        //            console.log('结束绑定BindGv_vPaper');
        //        }
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `添加新记录初始化不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //////////////////////////////////////////////////////论文部分/////////////////////////////////////////////////
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId", objUsers_Cond); //用户查询区域
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
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
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                console.log("完成BindDdl_LiteratureTypeId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //确定选择的论文 并添加到关系表中
        async btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                var returnBool2 = jsonData;
                if (returnBool2 == true) {
                    //HideDialogQA();
                    HideDialogThree();
                    this.BindGv_vgs_RTqa_PaperRela();
                }
            });
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objqa_PaperEN = new clsqa_PaperEN_js_1.clsqa_PaperEN();
            this.PutDataToqa_PaperClass(objqa_PaperEN);
            try {
                //const responseText2 = await qa_Paper_AddNewRecordWithMaxIdAsync(objqa_PaperEN);
                //添加答疑
                const responseText = await (0, clsqa_PaperWApi_js_1.qa_Paper_AddNewRecordWithReturnKeyAsync)(objqa_PaperEN);
                //var returnBool: boolean = !!responseText2;
                var strqa_PaperId = responseText;
                if (strqa_PaperId != "") {
                    var objgs_RTqa_PaperRelaEN = new clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN();
                    objgs_RTqa_PaperRelaEN.topicId = $("#hidTopicRelaId").val();
                    objgs_RTqa_PaperRelaEN.qa_PaperId = strqa_PaperId;
                    objgs_RTqa_PaperRelaEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
                    objgs_RTqa_PaperRelaEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改日期
                    //添加论文答疑关系
                    const responseText2 = await (0, clsgs_RTqa_PaperRelaWApi_js_1.gs_RTqa_PaperRela_AddNewRecordAsync)(objgs_RTqa_PaperRelaEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = `添加记录成功!`;
                        $('#lblResult47').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        var strInfo = `添加答疑关系不成功!`;
                        $('#lblResult47').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                    return responseText2; //一定要有一个返回值，否则会出错！
                }
                else {
                    var strInfo = `添加答疑不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
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
        PutDataToqa_PaperClass(pobjqa_PaperEN) {
            pobjqa_PaperEN.paperId = $("#hidPaperId").val(); // 论文Id
            pobjqa_PaperEN.isPublic = false; // 是否公开
            pobjqa_PaperEN.isSubmit = false; // 是否公开
            pobjqa_PaperEN.questionsCount = 0;
            pobjqa_PaperEN.answerCount = 0;
            pobjqa_PaperEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjqa_PaperEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改日期
            var strId_CurrEduCls = $("#hidId_CurrEduCls").val();
            pobjqa_PaperEN.id_CurrEduCls = strId_CurrEduCls; //教学班id
            pobjqa_PaperEN.memo = this.memo; // 备注
        }
        /* 函数功能:在数据 列表中跳转到某一页
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
       <param name = "intPageIndex">页序号</param>
     */
        //public IndexPageOne(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.PageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.CurrPageIndex2 = intPageIndex;
        //    this.BindGv_vPaper();
        //}
        //////////////////////////////////////////////////////论文部分/////////////////////////////////////////////////
        // /*
        // * 论文标题
        //*/
        // public get paperTitle(): string {
        //     return $("#txtPaperTitle").val();
        // }
        // ///////////////////////论文列表条件
        // public get PaperUser(): string {
        //     return $("#ddlUserId").val();
        // }
        // /*
        // * 文献类型Id
        //*/
        // public get literatureTypeId(): string {
        //     return $("#ddlLiteratureTypeId").val();
        // }
        //  /*
        // * 设置排序字段-相当使用ViewState功能
        //*/
        //  public set hidSortvPaperBy(value: string) {
        //      $("#hidSortvPaperBy").val(value);
        //  }
        //  /*
        //  * 设置排序字段
        // */
        //  public get hidSortvPaperBy(): string {
        //      return $("#hidSortvPaperBy").val();
        //  }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvgs_RTqa_PaperRelaBy(value) {
            $("#hidSortvgs_RTqa_PaperRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvgs_RTqa_PaperRelaBy() {
            return $("#hidSortvgs_RTqa_PaperRelaBy").val();
        }
    }
    exports.ResearchTopicQAEx = ResearchTopicQAEx;
});
