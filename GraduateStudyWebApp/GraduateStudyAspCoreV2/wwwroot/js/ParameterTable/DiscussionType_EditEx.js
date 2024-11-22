(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/ParameterTable/DiscussionType_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/ParameterTable/clsDiscussionTypeEN.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.DiscussionType_EditEx = void 0;
    const DiscussionType_Edit_js_1 = require("../PagesBase/ParameterTable/DiscussionType_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsDiscussionTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsDiscussionTypeEN.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* DiscussionType_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class DiscussionType_EditEx extends DiscussionType_Edit_js_1.DiscussionType_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = DiscussionType_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(DiscussionType_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_DiscussionType;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        const responseText2 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            var returnBool2 = jsonData;
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnBool2) == false) {
                                HideDialog();
                                this.iShowList.BindGv(clsDiscussionTypeEN_js_1.clsDiscussionTypeEN._CurrTabName, "");
                            }
                        });
                        // if (this.opType == "AddWithMaxId") {}
                        //else {
                        //    const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                        //        var returnBool: boolean = jsonData;
                        //        if (returnBool == true) {
                        //            HideDialog();
                        //            this.BindGv_DiscussionType();
                        //        }
                        //    });
                        //}
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.iShowList.BindGv(clsDiscussionTypeEN_js_1.clsDiscussionTypeEN._CurrTabName, "");
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
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjDiscussionTypeEN">数据传输的目的类对象</param>
       */
        async PutDataToDiscussionTypeClass(pobjDiscussionTypeEN) {
            pobjDiscussionTypeEN.SetDiscussionTypeName(this.discussionTypeName); // 讨论类型名称
            pobjDiscussionTypeEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjDiscussionTypeEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            ; // 修改人
            pobjDiscussionTypeEN.SetMemo(this.memo); // 备注
        }
    }
    exports.DiscussionType_EditEx = DiscussionType_EditEx;
});
