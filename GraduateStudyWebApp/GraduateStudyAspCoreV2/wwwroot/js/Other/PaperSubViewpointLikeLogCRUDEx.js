(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/Other/PaperSubViewpointLikeLogCRUD.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperSubViewpointLikeLogCRUDEx = void 0;
    /**
    * 类名:PaperSubViewpointLikeLogCRUDEx(界面:PaperSubViewpointLikeLogCRUD)
    * 表名:PaperSubViewpointLikeLog(01120560)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/05 04:58:21
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:其他(Other)
    * 框架-层名:WA_界面后台Ex_TS(TS)(WA_ViewScriptCSEx_TS)
    * 编程语言:TypeScript
    **/
    const PaperSubViewpointLikeLogCRUD_js_1 = require("../PagesBase/Other/PaperSubViewpointLikeLogCRUD.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    //import $ from "jquery";
    /** PaperSubViewpointLikeLogCRUDEx 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    **/
    class PaperSubViewpointLikeLogCRUDEx extends PaperSubViewpointLikeLogCRUD_js_1.PaperSubViewpointLikeLogCRUD {
        //public static mstrListDiv = "divDataLst";
        //public static mstrSortvPaperSubViewpointLikeLogBy = "PaperSubViewpointLikeLogId";
        /**
        * 每页记录数，在扩展类可以修改
        **/
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_vPaperSubViewpointLikeLog();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vPaperSubViewpointLikeLog":
                    alert('该类没有绑定该函数：[this.BindGv_vPaperSubViewpointLikeLog_Cache]！');
                    //this.BindGv_vPaperSubViewpointLikeLog_Cache();
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
            if (PaperSubViewpointLikeLogCRUD_js_1.PaperSubViewpointLikeLogCRUD.objPage_CRUD == null) {
                PaperSubViewpointLikeLogCRUD_js_1.PaperSubViewpointLikeLogCRUD.objPage_CRUD = new PaperSubViewpointLikeLogCRUDEx();
                objPage = PaperSubViewpointLikeLogCRUD_js_1.PaperSubViewpointLikeLogCRUD.objPage_CRUD;
            }
            else {
                objPage = PaperSubViewpointLikeLogCRUD_js_1.PaperSubViewpointLikeLogCRUD.objPage_CRUD;
            }
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
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
                    strMsg = '命令:' + strCommandName + "在函数(PaperSubViewpointLikeLogCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.PaperSubViewpointLikeLogCRUDEx = PaperSubViewpointLikeLogCRUDEx;
});
