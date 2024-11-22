(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/ParameterTable/gs_ParagraphTypeCRUD.js", "./gs_ParagraphType_EditEx.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ParagraphTypeCRUDEx = void 0;
    /**
    * 类名:gs_ParagraphTypeCRUDEx(界面:gs_ParagraphTypeCRUD)
    * 表名:gs_ParagraphType(01120746)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/05 23:54:30
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培参数(ParameterTable)
    * 框架-层名:WA_界面后台Ex_TS(TS)(WA_ViewScriptCSEx_TS)
    * 编程语言:TypeScript
    **/
    const gs_ParagraphTypeCRUD_js_1 = require("../PagesBase/ParameterTable/gs_ParagraphTypeCRUD.js");
    const gs_ParagraphType_EditEx_js_1 = require("./gs_ParagraphType_EditEx.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    //import $ from "jquery";
    /** gs_ParagraphTypeCRUDEx 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    **/
    class gs_ParagraphTypeCRUDEx extends gs_ParagraphTypeCRUD_js_1.gs_ParagraphTypeCRUD {
        //public static mstrListDiv = "divDataLst";
        //public static mstrSortgs_ParagraphTypeBy = "ParagraphTypeId";
        /**
        * 每页记录数，在扩展类可以修改
        **/
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_gs_ParagraphType();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "gs_ParagraphType":
                    alert('该类没有绑定该函数：[this.BindGv_gs_ParagraphType_Cache]！');
                    //this.BindGv_gs_ParagraphType_Cache();
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
            if (gs_ParagraphTypeCRUD_js_1.gs_ParagraphTypeCRUD.objPage_CRUD == null) {
                gs_ParagraphTypeCRUD_js_1.gs_ParagraphTypeCRUD.objPage_CRUD = new gs_ParagraphTypeCRUDEx();
                objPage = gs_ParagraphTypeCRUD_js_1.gs_ParagraphTypeCRUD.objPage_CRUD;
            }
            else {
                objPage = gs_ParagraphTypeCRUD_js_1.gs_ParagraphTypeCRUD.objPage_CRUD;
            }
            const objPage_Edit = new gs_ParagraphType_EditEx_js_1.gs_ParagraphType_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
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
                    strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        const strMsg = "请选择需要修改的记录！";
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
                    strMsg = '命令:' + strCommandName + "在函数(gs_ParagraphTypeCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.gs_ParagraphTypeCRUDEx = gs_ParagraphTypeCRUDEx;
});
