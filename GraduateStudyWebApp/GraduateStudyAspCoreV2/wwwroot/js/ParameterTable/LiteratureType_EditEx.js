(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/ParameterTable/LiteratureType_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.LiteratureType_EditEx = void 0;
    /**
    * 类名:LiteratureType_EditEx(界面:LiteratureTypeCRUD)
    * 表名:LiteratureType(01120557)
    * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/06 22:43:18
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培参数(ParameterTable)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const LiteratureType_Edit_js_1 = require("../PagesBase/ParameterTable/LiteratureType_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* LiteratureType_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class LiteratureType_EditEx extends LiteratureType_Edit_js_1.LiteratureType_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = LiteratureType_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(LiteratureType_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjLiteratureTypeEN">数据传输的目的类对象</param>
      */
        async PutDataToLiteratureTypeClass(pobjLiteratureTypeEN) {
            pobjLiteratureTypeEN.SetLiteratureTypeId(this.literatureTypeId); // 文献类型Id
            pobjLiteratureTypeEN.SetLiteratureTypeName(this.literatureTypeName); // 文献名称
            pobjLiteratureTypeEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            ; // 修改人
            pobjLiteratureTypeEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
        }
    }
    exports.LiteratureType_EditEx = LiteratureType_EditEx;
});
