(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/SysPara/clsOperationTypeEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/SysPara/clsOperationTypeWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperReadWriteAdd = void 0;
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsOperationTypeEN_js_1 = require("../TS/L0_Entity/SysPara/clsOperationTypeEN.js");
    const clsPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsOperationTypeWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsOperationTypeWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsPaperReadWriteWApiEx_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* PaperCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class PaperReadWriteAdd extends PaperCRUD_js_1.PaperCRUD {
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                    //绑定下拉框；
                    var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                    const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
                    //  const ddl_OperationTypeId = await this.BindDdl_OperationTypeId("ddlOperationTypeId");
                    //1、为下拉框设置数据源,绑定列表数据
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "paperTitle Asc";
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    const gvResult = await this.BindGv_vPaper();
                    this.AddNewRecord();
                    //获取分享Id
                    const responseText = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("02", clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    var strShareId = responseText;
                    //var returnBool: boolean = !!responseText2;
                    if (strShareId != "") {
                        this.shareId = strShareId;
                    }
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Index";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        BindDdl_OperationTypeId(ddlOperationTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlOperationTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlOperationTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsOperationTypeWApi_js_1.OperationType_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrOperationTypeObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlOperationTypeId, arrOperationTypeObjLst, clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeId, clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeName, "操作类型");
                        console.log("完成BindDdl_OperationTypeId!");
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
        //添加相关方法
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        AddNewRecord() {
            this.SetKeyReadOnly(true);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucPaperReadWriteB1.paperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_GetMaxStrIdAsync)().then((jsonData) => {
                        var returnString = jsonData.toString();
                        if (returnString == "") {
                            var strInfo = `获取表PaperReadWrite的最大关键字为空，不成功，请检查!`;
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            $('#txtPaperRWId').val(returnString);
                            $('#hidPaperRWId').val(returnString);
                        }
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `获取表关键字的最大值不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtPaperRWId').prop['ReadOnly'] = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.paperRWId = "";
            this.readerId = "";
            $('#ddlPaperId option[0]').attr("selected", true);
            this.researchQuestion = "";
            this.isPublic = false;
            // $('#ddlOperationTypeId option[0]').attr("selected", true);
            this.updDate = "";
            this.updUser = "";
            this.memo = "";
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd_Click() {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            var strCommandText = this.btnOKUpd;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                //HideDialog();
                                (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEducls);
                                //var strReadWriteTypeId = $('#hidReadWriteTypeId').val();
                                //if (strReadWriteTypeId == "01") {
                                //    window.location.href = "../GraduateEduEx/PaperReadList?ReadWriteTypeId=" + strReadWriteTypeId;
                                //}
                                //else if (strReadWriteTypeId == "02") {
                                //    window.location.href = "../GraduateEduEx/PaperReadWrite_QUDI?ReadWriteTypeId=" + strReadWriteTypeId;
                                //}
                                CloseWindow();
                                //this.BindGv_vPaperReadWrite();
                            }
                            else {
                            }
                        });
                        break;
                    //case "确认修改":
                    //    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                    //        var returnBool: boolean = jsonData;
                    //        if (returnBool == true) {
                    //            HideDialog();
                    //            this.BindGv_vPaperReadWrite();
                    //        }
                    //    });
                    //    break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
                $("#btnOKUpd").attr("disabled", false);
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
            const strThisFuncName = this.AddNewRecordSave.name;
            //this.DivName = "divAddNewRecordSave";
            var objPaperReadWriteEN = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
            objPaperReadWriteEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
            this.PutDataToPaperReadWriteClass(objPaperReadWriteEN);
            try {
                const responseText = await (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_IsExistAsync)(objPaperReadWriteEN.paperRWId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objPaperReadWriteEN.paperRWId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await clsPaperReadWriteWApiEx_js_1.clsPaperReadWriteWApiEx.AddNewRecordAsyncEx(objPaperReadWriteEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //添加成功后把数据同步到总表
                    var strPaperRWId = $('#hidPaperRWId').val();
                    const responseText2 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strPaperRWId, "02", "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                    var returnBool2 = !!responseText2;
                    if (returnBool2 == true) {
                        console.log("论文读写数据总表同步成功；");
                    }
                    else {
                        console.log("论文读写数据总表同步失败；");
                    }
                    //添加记录的同时并记录论文的读写数
                    var strPaperId = $('#txtPaperRWId').val();
                    var strWhereCond2 = " 1 =1 and paperId=" + strPaperId;
                    var intRWCount = await (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                    objPaperEN.SetPaperId(strPaperId);
                    objPaperEN.SetPcount(intRWCount);
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText3 = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
                    var returnBool2 = !!responseText3;
                    if (returnBool2 == true) {
                        var strInfo = `添加记录成功!`;
                        $('#lblResult40').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("添加统计数量成功");
                    }
                    else {
                        var strInfo = `添加统计数量不成功!`;
                        alert(strInfo);
                        console.log("添加统计数量不成功");
                    }
                    //const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    //    var returnBool: boolean = jsonData;
                    //});
                    //添加记录的同时并记录论文的读写数
                }
                else {
                    var strInfo = `添加不成功!同一用户同一论文只能添加一次`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //var strInfo: string = `添加记录不成功!`;
                    //$('#lblResult40').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                //var strMsg: string = `添加记录不成功,${e}.`;
                var strMsg = `添加记录不成功,论文不能重复添加`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
      */
        PutDataToPaperReadWriteClass(pobjPaperReadWriteEN) {
            pobjPaperReadWriteEN.SetPaperRWId(this.paperRWId); // 论文读写Id
            pobjPaperReadWriteEN.SetReaderId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 阅读者Id
            pobjPaperReadWriteEN.SetPaperId($("#hidPaperId").val()); // 论文Id
            pobjPaperReadWriteEN.SetResearchQuestion(this.researchQuestion); // 研究问题
            pobjPaperReadWriteEN.SetIsPublic(this.isPublic); //是否公开；
            pobjPaperReadWriteEN.SetShareId(this.shareId);
            pobjPaperReadWriteEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjPaperReadWriteEN.SetOperationTypeId($("#hidReadWriteTypeId").val()); // 操作类型ID
            pobjPaperReadWriteEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjPaperReadWriteEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id// 修改用户Id
            pobjPaperReadWriteEN.SetMemo(this.memo); // 备注
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
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async btnQuery_Click() {
            var strWhereCond = await this.CombinevPaperCondition();
            try {
                this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
                this.BindTab_vPaper(this.mstrListDiv, arrPaperExObjLst);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                }
                //if (this.IsChecked_q == true) {
                //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '0'`;
                //}
                //if (this.IsQuotethesis_q == true) {
                //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '0'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vPaper() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = await this.CombinevPaperCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperExObjLst = [];
            try {
                this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
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
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
                console.log("完成BindGv_vPaper!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vPaper对象的所有属性值
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        <param name = "divContainer">显示容器</param>
        <param name = "arrPaperObjLst">需要绑定的对象列表</param>
      */
        async BindTab_vPaper(divContainer, arrPaperExObjLst) {
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
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "periodical",
                    colHeader: "期刊",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "researchQuestion",
                //    colHeader: "研究问题",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "literatureSources",
                    colHeader: "文献来源",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "literatureLink",
                    colHeader: "文献链接",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "uploadfileUrl",
                //    colHeader: "文件地址",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "checker",
                //    colHeader: "审核人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "isChecked",
                //    colHeader: "是否检查",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "isQuotethesis",
                    colHeader: "是否引用论文",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "updUser",
                //    colHeader: "修改用户Id",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
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
            (0, clsCommFunc4Web_js_1.BindTab)(o, arrPaperExObjLst, arrDataColumn, "paperId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /*
       根据关键字选择相应的记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
        <param name = "sender">参数列表</param>
      */
        async SelectRecord(strPaperId) {
            try {
                const responseText = await (0, clsPaperWApi_js_1.Paper_GetObjByPaperIdAsync)(strPaperId);
                var objPaperEN = responseText;
                console.log("完成SelectRecord!");
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_vPaper");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_QueryLst)
     */
        async QueryvPaperLst(strListDiv) {
            var strWhereCond = await this.CombinevPaperCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            try {
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
                this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
                console.log("完成QueryvPaperLst!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
            this.BindGv_vPaper();
        }
        /* 函数功能:从界面列表中根据某一个字段排序
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
        <param name = "strSortByFld">排序的字段</param>
      */
        async SortBy(strSortByFld) {
            if (PaperCRUD_js_1.PaperCRUD.sortPaperBy.indexOf(strSortByFld) >= 0) {
                if (PaperCRUD_js_1.PaperCRUD.sortPaperBy.indexOf("Asc") >= 0) {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = `${strSortByFld} Desc`;
                }
                else {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = `${strSortByFld} Asc`;
                }
            }
            else {
                PaperCRUD_js_1.PaperCRUD.sortPaperBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_vPaper();
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
       * 用户Id
      */
        get hidUserId() {
            return clsPublocalStorage_js_1.clsPublocalStorage.userId;
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
        // /*
        // * 操作类型ID
        //*/
        // public set operationTypeId(value: string) {
        //     $("#ddlOperationTypeId").val(value);
        // }
        // /*
        // * 操作类型ID
        //*/
        // public get operationTypeId(): string {
        //     return $("#ddlOperationTypeId").val();
        // }
        /*
        * 操作类型ID
       */
        get operationTypeId_q() {
            return $("#ddlOperationTypeId_q").val();
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set opType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 论文Id
       */
        set paperId(value) {
            $("#ddlPaperId").val(value);
        }
        /*
        * 论文Id
       */
        get paperId() {
            return $("#ddlPaperId").val();
        }
        /*
        * 论文读写Id
       */
        set paperRWId(value) {
            $("#txtPaperRWId").val(value);
        }
        /*
        * 论文读写Id
       */
        get paperRWId() {
            return $("#txtPaperRWId").val();
        }
        /*
        * 阅读者Id
       */
        set readerId(value) {
            $("#txtReaderId").val(value);
        }
        /*
        * 阅读者Id
       */
        get readerId() {
            return $("#txtReaderId").val();
        }
        /*
        * 研究问题
       */
        set researchQuestion(value) {
            $("#txtResearchQuestion").val(value);
        }
        /*
        * 研究问题
       */
        get researchQuestion() {
            return $("#txtResearchQuestion").val();
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
       * 文献类型Id
      */
        get literatureTypeId_q() {
            return $("#ddlLiteratureTypeId_q").val();
        }
        /*
       * 是否公开
      */
        set isPublic(value) {
            $("#chkIsPublic").val(value);
        }
        /*
        * 是否公开
       */
        get isPublic() {
            return $("#chkIsPublic").prop("checked");
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
    exports.PaperReadWriteAdd = PaperReadWriteAdd;
});
