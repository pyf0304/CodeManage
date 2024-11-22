(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PdfDetail = void 0;
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PdfDetail {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortUsersBy: string = "userId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            var strKeyId = $("#hidPaperId").val();
            var objPaperAttachment;
            try {
                var strWhereCond = " 1=1 and paperId ='" + strKeyId + "'";
                const responseText = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetFirstObjAsync)(strWhereCond);
                objPaperAttachment = responseText;
                if (objPaperAttachment != null) {
                    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                    var strhtml = "";
                    strhtml = "<iframe src='../GraduateEduEx/Pdf?file=" + strfilepath + "' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                    $("#div_pdf").html(strhtml);
                }
                else {
                    var strhtml = "";
                    strhtml = "<iframe src='../GraduateEduEx/Pdf' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                    $("#div_pdf").html(strhtml);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.PdfDetail = PdfDetail;
});
