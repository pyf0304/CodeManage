(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.StructureChart = void 0;
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* cc_CourseKnowledgesCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class StructureChart {
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                //const gvBindDdl = await this.BindDdl4QueryRegion();
                //this.hidSortvcc_CourseKnowledgesBy = "knowledgeTitle Asc";
                ////2、显示无条件的表内容在GridView中
                //const responseBindGv = await this.BindGv_vcc_CourseKnowledges();
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //const responseBindGv2 = await this.BindGv_gs_KnowledgesLogic();
                    LoadjsPlumb();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
    }
    exports.StructureChart = StructureChart;
});
