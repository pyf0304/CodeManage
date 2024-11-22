(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../PagesBase/Knowledges_Share/KnowledgeType_Edit.js", "../TS/PubFun/clsString.js", "../TS/PubFun/clsCommFunc4Ctrl.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.KnowledgeType_EditEx = void 0;
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const KnowledgeType_Edit_js_1 = require("../PagesBase/Knowledges_Share/KnowledgeType_Edit.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    /* KnowledgeType_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class KnowledgeType_EditEx extends KnowledgeType_Edit_js_1.KnowledgeType_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            var objPage = KnowledgeType_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)("divList");
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        var strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    objPage.btnUpdateRecord_Click(strKeyId);
                    break;
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(KnowledgeType_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjKnowledgeTypeEN">数据传输的目的类对象</param>
      */
        async PutDataToKnowledgeTypeClass(pobjKnowledgeTypeEN) {
            pobjKnowledgeTypeEN.SetKnowledgeTypeName(this.knowledgeTypeName); // 知识点类型名
            pobjKnowledgeTypeEN.SetCourseId(clsPublocalStorage_js_1.clsPublocalStorage.courseId);
            pobjKnowledgeTypeEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjKnowledgeTypeEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
        }
        /* 添加新记录
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
    */
        async btnAddNewRecordWithMaxId_Click() {
            this.opType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    //if (this.bolIsUseInDiv == true) {
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    //}
                    //else {
                    //    const conBindDdl = await this.BindDdl4EditRegion();
                    //}
                    this.SetEventFunc();
                    this.ShowDialog_KnowledgeType('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                }
                else {
                    this.ShowDialog_KnowledgeType('Add');
                    const responseText = this.AddNewRecordWithMaxId();
                }
            }
            catch (e) {
                var strMsg = `添加新记录初始化不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
    }
    exports.KnowledgeType_EditEx = KnowledgeType_EditEx;
});
