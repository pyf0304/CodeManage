(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/JournalSubjectCRUD.js", "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsJournalSubjectExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./JournalSubject_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.JournalSubjectCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:JournalSubjectCRUDEx(界面:JournalSubjectCRUD)
    表名:JournalSubject(01120930)
    生成代码版本:2021.06.19.1
    生成日期:2021/06/20 00:53:33
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培论文
    模块英文名:GraduateEduPaper
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const JournalSubjectCRUD_js_1 = require("../PagesBase/GraduateEduPaper/JournalSubjectCRUD.js");
    const clsJournalSubjectWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js");
    const clsJournalSubjectExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsJournalSubjectExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const JournalSubject_EditEx_js_1 = require("./JournalSubject_EditEx.js");
    /* JournalSubjectCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class JournalSubjectCRUDEx extends JournalSubjectCRUD_js_1.JournalSubjectCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortJournalSubjectBy: string = "journalSubjectId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            alert('该类没有绑定该函数：[this.BindGv_JournalSubject]！');
            //this.BindGv_JournalSubject();
        }
        BindGv_Cache(strType, strPara) {
            switch (strType) {
                case "JournalSubject":
                    this.BindGv_JournalSubject4Func();
                    break;
                default:
                    var strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new JournalSubjectCRUDEx();
            var objPage_Edit = new JournalSubject_EditEx_js_1.JournalSubject_EditEx(objPage);
            switch (strCommandName) {
                case "CloseExcelDiv": //查询记录
                    objPage.btnCloseExcelDiv_Click();
                    break;
                case "ImportData": //查询记录
                    objPage.btnImportData_Click();
                    break;
                case "ImportDataFromExcel": //查询记录
                    objPage.btnImportDataFromExcel_Click();
                    break;
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    objPage_Edit.btnAddNewRecordWithMaxId_Click();
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
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    ;
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        var strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "UpdateRecordInTab": //修改记录InTab
                    objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "ExportExcel": //导出Excel
                    objPage.btnExportExcel_Click();
                    //alert("导出Excel功能还没有开通！");
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    if ((0, clsCommFunc4Web_js_1.confirm_del)(arrKeyIds.length) == false) {
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
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
                    var strMsg = '命令:' + strCommandName + "在函数(JournalSubjectCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        async btnCloseExcelDiv_Click() {
            //$("#divImportExcel").css("display", "block");
            $("#divImportExcel").css("display", "none");
        }
        async btnImportDataFromExcel_Click() {
            $("#divImportExcel").css("display", "block");
            //$("#divImportExcel").css("display", "none");
        }
        async btnImportData_Click() {
            //$("#divImportExcel").css("display", "block");
            //$("#divImportExcel").css("display", "none");
            //JournalSubject.JournalSubjectEx_ImportDataFromCsv(csv, strUserId);
            console.log("btnImportData_Click");
            var strCsv1 = strCsv;
            if ((0, clsString_js_1.IsNullOrEmpty)(strCsv1)) {
                var strMsg = `Excel数据为空，请选择一个Excel文件！`;
                console.error("Error: ", strMsg);
                alert(strMsg);
                return;
            }
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                const responseText = await (0, clsJournalSubjectExWApi_js_1.JournalSubjectEx_ImportDataFromCsv)(strCsv1, strUserId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clsJournalSubjectWApi_js_1.JournalSubject_ReFreshCache)();
                    const responseBindGv = await this.BindGv_JournalSubject4Func();
                    var strMsg = `已导入了:[${returnInt}]条记录.`;
                    alert(strMsg);
                }
                return returnInt;
            }
            catch (e) {
                var strMsg = `导入Excel不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
        }
    }
    exports.JournalSubjectCRUDEx = JournalSubjectCRUDEx;
});
