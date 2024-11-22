(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QuoteAndGroupPaperEx = void 0;
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* PaperCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class QuoteAndGroupPaperEx extends PaperCRUD_js_1.PaperCRUD {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.recCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucPaperB1.paperId = clsPaperBL.GetMaxStrId_S();
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_GetMaxStrIdAsync)().then((jsonData) => {
                        var returnString = jsonData.toString();
                        if (returnString == "") {
                            var strInfo = `获取表Paper的最大关键字为空，不成功，请检查!`;
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            $('#txtPaperId').val(returnString);
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
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            this.PutDataToPaperClass(objPaperEN);
            try {
                const responseText = await (0, clsPaperWApi_js_1.Paper_IsExistAsync)(objPaperEN.paperId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objPaperEN.paperId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsPaperWApi_js_1.Paper_AddNewRecordAsync)(objPaperEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
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
            if (arrPaperExObjLst.length == 0) {
                var strMsg = `根据条件获取的对象列表数为空！`;
                console.error(strMsg);
                alert(strMsg);
                return;
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
                {
                    fldName: "researchQuestion",
                    colHeader: "研究问题",
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
                {
                    fldName: "updUser",
                    colHeader: "修改用户Id",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
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
                {
                    fldName: "uploadfileUrl",
                    colHeader: "文件地址",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "checker",
                    colHeader: "审核人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isChecked",
                    colHeader: "是否检查",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isQuotethesis",
                    colHeader: "是否引用论文",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
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
            (0, clsCommFunc4Web_js_1.BindTab)(o, arrPaperExObjLst, arrDataColumn, "paperId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.opType = "Add";
            try {
                const responseText = await this.AddNewRecord();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
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
                var strKeyList;
                if (arrKeyIds.length == 0)
                    return "";
                strKeyList = "";
                for (var i = 0; i < arrKeyIds.length; i++) {
                    if (i == 0)
                        strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                    else
                        strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
                }
                //
                var strWhereCond = " paperId in (" + strKeyList + ")";
                const responseText1 = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.recCount = jsonData;
                    if (this.recCount != 0) {
                        alert("请先删除该论文在论文写作或阅读数据！");
                        return "";
                    }
                    else {
                    }
                });
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseText2 = await this.BindGv_vPaper();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
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
                const responseText2 = await this.BindGv_vPaper();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里详细信息记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
       */
        async btnDetailRecordInTab_Click(strKeyId) {
            this.opType = "Detail";
            try {
                if (strKeyId == "") {
                    alert("请选择需要详细信息的记录！");
                    return "";
                }
                this.DetailRecord(strKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `详细信息记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            var strWhereCond = " 1=1 ";
            try {
                const arrPaperObjLst = await (0, clsPaperWApi_js_1.Paper_GetObjLstAsync)(strWhereCond);
                const arrPaperExObjLst = arrPaperObjLst.map(clsPaperExWApi_js_1.PaperEx_CopyToEx);
                this.BindTab_vPaper(this.mstrListDiv, arrPaperExObjLst);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
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
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vPaper();
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vPaper();
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
        /*
        在数据表里选择记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
       */
        async btnSelectRecordInTab_Click1(strKeyId) {
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
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
       */
        btnUpdateRecord_Click(strKeyId) {
            this.opType = "Update";
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        btnUpdateRecordInTab_Click(strKeyId) {
            this.opType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.paperId = "";
            this.paperTitle = "";
            this.paperContent = "";
            this.periodical = "";
            this.author = "";
            this.researchQuestion = "";
            this.updDate = "";
            this.updUser = "";
            this.memo = "";
            this.keyword = "";
            this.literatureSources = "";
            this.literatureLink = "";
            this.uploadfileUrl = "";
            this.isQuotethesis = false;
            this.quoteId = "";
            this.isChecked = false;
            this.checker = "";
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strQuoteAndGroupId = $("#hidQuoteAndGroupId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                //如果假设为01 就是引用论文 02 就是本组论文
                if (strQuoteAndGroupId == "01") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis} = '1'`; //引用论文
                }
                else {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_IsQuotethesis} = '0'`; //本组论文
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
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrPaperId) {
            try {
                const returnInt = await (0, clsPaperWApi_js_1.Paper_DelPapersAsync)(arrPaperId);
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
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(strPaperId) {
            try {
                const returnInt = await (0, clsPaperWApi_js_1.Paper_DelRecordAsync)(strPaperId);
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
        ///*
        //演示Session 操作
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
        //*/
        //public async Demo_Session() {
        //    try {
        //        //设置Session
        //        var strUserId = "TestUserId";
        //        await this.SetSessionAsync("userId", strUserId);
        //        //获取Session
        //        var strUserId_Value1 = await this.GetSessionAsync("userId");
        //        console.log('strUserId_Value1:' + strUserId_Value1);
        //        //获取Session方法2：直接读取页面中的hidUserId
        //        var strUserId_Value2 = this.hidUserId;
        //        console.log('strUserId_Value2:' + strUserId_Value2);
        //    }
        //    catch (e) {
        //        var strMsg: string = `演示Session不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /*
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
         <param name = "sender">参数列表</param>
       */
        DetailRecord(strPaperId) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_GetObjByPaperIdAsync)(strPaperId).then((jsonData) => {
                        var objPaperEN = jsonData;
                        this.GetDataFromPaperClass(objPaperEN);
                        console.log("完成DetailRecord!");
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
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjPaperEN">表实体类对象</param>
       */
        GetDataFromPaperClass(pobjPaperEN) {
            this.paperId = pobjPaperEN.paperId; // 论文Id
            this.paperTitle = pobjPaperEN.paperTitle; // 论文标题
            this.paperContent = pobjPaperEN.paperContent; // 主题内容
            this.periodical = pobjPaperEN.periodical; // 期刊
            this.author = pobjPaperEN.author; // 作者
            this.researchQuestion = pobjPaperEN.researchQuestion; // 研究问题
            this.updDate = pobjPaperEN.updDate; // 修改日期
            this.updUser = pobjPaperEN.updUser; // 修改用户Id
            this.memo = pobjPaperEN.memo; // 备注
            this.keyword = pobjPaperEN.keyword; // 关键字
            this.literatureSources = pobjPaperEN.literatureSources; // 文献来源
            this.literatureLink = pobjPaperEN.literatureLink; // 文献链接
            this.literatureTypeId = pobjPaperEN.literatureTypeId; //文献类型；
            $("#hdnpic").val(pobjPaperEN.uploadfileUrl);
            this.isQuotethesis = pobjPaperEN.isQuotethesis; // 是否引用论文
            this.quoteId = pobjPaperEN.quoteId; // 引用Id
            this.isChecked = pobjPaperEN.isChecked; // 是否检查
            this.checker = pobjPaperEN.checker; // 审核人
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjPaperEN">表实体类对象</param>
        <returns>列表的第一个关键字值</returns>
       */
        GetFirstKey() {
            if (clsCommFunc4Web_js_1.arrSelectedKeys.length == 1) {
                return clsCommFunc4Web_js_1.arrSelectedKeys[0];
            }
            else {
                alert(`请选择一个关键字！目前选择了:${clsCommFunc4Web_js_1.arrSelectedKeys.length}个关键字。`);
                return "";
            }
        }
        /* 获取当前表关键字值的最大值,再加1,避免重复
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
       */
        async GetMaxStrId(strKeyCtrlName) {
            this.DivName = "divGetMaxStrId";
            try {
                const responseText = await (0, clsPaperWApi_js_1.Paper_GetMaxStrIdAsync)();
                var returnString = responseText.toString();
                if (returnString == "") {
                    var strInfo = `获取表Paper的最大关键字为空，不成功，请检查!`;
                    $('#lblResult35').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
                else {
                    var strInfo = `获取表Paper的最大关键字为：${returnString}!`;
                    $('#lblResult35').val(strInfo);
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
        /*
        获取Session 关键字的值
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
        <param name = "Key">关键字</param>
         <return>值</return>
        */
        GetSessionAsync(Key) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_GetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                        resolve(data);
                    },
                    error: (e) => {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
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
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strUserId != "") {
                    //1、为下拉框设置数据源,绑定列表数据
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "paperTitle Asc";
                    ////把类型存入session 区分引用或本组
                    //var strQuoteAndGroupId = $("#hidQuoteAndGroupId").val();
                    //const bolIsSuccess = this.SetSessionAsync("QuoteAndGroupId", strQuoteAndGroupId);
                    const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                    //绑定编辑文献类型
                    const ddl_LiteratureTypeId = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId");
                    var strWhereCond = await this.CombinevPaperCondition();
                    const responseText = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                        this.recCount = jsonData;
                    });
                    //管理员 判断角色 
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                    }
                    else {
                        //学生00620003 教师 
                        $("#btnDelRecord").hide();
                    }
                    //存放userId
                    $("#hidUserId").val(strUserId);
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vPaper();
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
         <param name = "pobjPaperEN">数据传输的目的类对象</param>
       */
        PutDataToPaperClass(pobjPaperEN) {
            pobjPaperEN.SetPaperId(this.paperId); // 论文Id
            pobjPaperEN.SetPaperTitle(this.paperTitle); // 论文标题
            pobjPaperEN.SetPaperContent(this.paperContent); // 主题内容
            pobjPaperEN.SetPeriodical(this.periodical); // 期刊
            pobjPaperEN.SetAuthor(this.author); // 作者
            pobjPaperEN.SetResearchQuestion(this.researchQuestion); // 研究问题
            pobjPaperEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjPaperEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            pobjPaperEN.SetMemo(this.memo); // 备注
            pobjPaperEN.SetKeyword(this.keyword); // 关键字
            pobjPaperEN.SetLiteratureSources(this.literatureSources); // 文献来源
            pobjPaperEN.SetLiteratureLink(this.literatureLink); // 文献链接
            pobjPaperEN.SetLiteratureTypeId(this.literatureTypeId); //文献类型
            pobjPaperEN.SetUploadfileUrl($("#hdnpic").val());
            pobjPaperEN.SetIsQuotethesis(this.isQuotethesis); // 是否引用论文
            pobjPaperEN.SetQuoteId(this.quoteId); // 引用Id
            pobjPaperEN.SetIsChecked(this.isChecked); // 是否检查
            pobjPaperEN.SetChecker(this.checker); // 审核人
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
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtPaperId').prop['ReadOnly'] = bolReadonly;
        }
        /*
        设置Session
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
        <param name = "Key">关键字</param>
        <param name = "Value">值</param>
        */
        SetSessionAsync(Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                    }
                });
            });
        }
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "strPaperId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strPaperId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            try {
                const responseText = await (0, clsPaperWApi_js_1.Paper_IsExistAsync)(strPaperId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strPaperId}] 的记录不存在!`;
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
                const responseText = await (0, clsPaperWApi_js_1.Paper_GetObjByPaperIdAsync)(strPaperId);
                objPaperEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromPaperClass(objPaperEN);
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objPaper">需要显示的对象</param>
       */
        ShowPaperObj(divContainer, objPaper) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaper);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objPaper[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
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
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        UpdateRecord(strPaperId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.keyId = strPaperId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_GetObjByPaperIdAsync)(strPaperId).then((jsonData) => {
                        var objPaperEN = jsonData;
                        // //通过判断数据用户是否是当前登录用户；
                        if (objPaperEN.updUser == strUserId) {
                            ShowDialog('Update');
                            this.GetDataFromPaperClass(objPaperEN);
                            console.log("完成UpdateRecord!");
                            resolve(jsonData);
                        }
                        else {
                            alert("当前数据不是您所添加，不能修改！");
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
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(this.keyId);
            this.PutDataToPaperClass(objPaperEN);
            objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
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
                    return false;
                }
            });
        }
        /*
        * 作者
       */
        set author(value) {
            $("#txtAuthor").val(value);
        }
        /*
        * 作者
       */
        get author() {
            return $("#txtAuthor").val();
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
        * 审核人
       */
        set checker(value) {
            $("#txtChecker").val(value);
        }
        /*
        * 审核人
       */
        get checker() {
            return $("#txtChecker").val();
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
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
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
        * 用户Id
       */
        get hidUserId() {
            return clsPublocalStorage_js_1.clsPublocalStorage.userId;
        }
        /*
        * 是否检查
       */
        set isChecked(value) {
            $("#chkIsChecked").val(value);
        }
        /*
        * 是否检查
       */
        get isChecked() {
            return $("#chkIsChecked").prop("checked");
        }
        /*
        * 是否检查
       */
        get IsChecked_q() {
            return $("#chkIsChecked_q").prop("checked");
        }
        /*
        * 是否引用论文
       */
        set isQuotethesis(value) {
            $("#chkIsQuotethesis").val(value);
        }
        /*
        * 是否引用论文
       */
        get isQuotethesis() {
            return $("#chkIsQuotethesis").prop("checked");
        }
        /*
        * 是否引用论文
       */
        get IsQuotethesis_q() {
            return $("#chkIsQuotethesis_q").prop("checked");
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
        * 关键字
       */
        set keyword(value) {
            $("#txtKeyword").val(value);
        }
        /*
        * 关键字
       */
        get keyword() {
            return $("#txtKeyword").val();
        }
        /*
        * 文献链接
       */
        set literatureLink(value) {
            $("#txtLiteratureLink").val(value);
        }
        /*
        * 文献链接
       */
        get literatureLink() {
            return $("#txtLiteratureLink").val();
        }
        /*
        * 文献来源
       */
        set literatureSources(value) {
            $("#txtLiteratureSources").val(value);
        }
        /*
        * 文献来源
       */
        get literatureSources() {
            return $("#txtLiteratureSources").val();
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
        set opType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 主题内容
       */
        set paperContent(value) {
            $("#txtPaperContent").val(value);
        }
        /*
        * 主题内容
       */
        get paperContent() {
            return $("#txtPaperContent").val();
        }
        /*
        * 论文Id
       */
        set paperId(value) {
            $("#txtPaperId").val(value);
        }
        /*
        * 论文Id
       */
        get paperId() {
            return $("#txtPaperId").val();
        }
        /*
        * 论文标题
       */
        set paperTitle(value) {
            $("#txtPaperTitle").val(value);
        }
        /*
        * 论文标题
       */
        get paperTitle() {
            return $("#txtPaperTitle").val();
        }
        /*
        * 论文标题
       */
        get paperTitle_q() {
            return $("#txtPaperTitle_q").val();
        }
        /*
        * 期刊
       */
        set periodical(value) {
            $("#txtPeriodical").val(value);
        }
        /*
        * 期刊
       */
        get periodical() {
            return $("#txtPeriodical").val();
        }
        /*
        * 引用Id
       */
        set quoteId(value) {
            $("#txtQuoteId").val(value);
        }
        /*
        * 引用Id
       */
        get quoteId() {
            return $("#txtQuoteId").val();
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
        * 文件地址
       */
        set uploadfileUrl(value) {
            $("#txtUploadfileUrl").val(value);
        }
        /*
        * 文件地址
       */
        get uploadfileUrl() {
            return $("#txtUploadfileUrl").val();
        }
        /*
      * 文献类型
     */
        set literatureTypeId(value) {
            $("#ddlLiteratureTypeId").val(value);
        }
        /*
        * 文献类型
       */
        get literatureTypeId() {
            return $("#ddlLiteratureTypeId").val();
        }
        /*
        * 文献类型Id
       */
        get literatureTypeId_q() {
            return $("#ddlLiteratureTypeId_q").val();
        }
    }
    exports.QuoteAndGroupPaperEx = QuoteAndGroupPaperEx;
});
