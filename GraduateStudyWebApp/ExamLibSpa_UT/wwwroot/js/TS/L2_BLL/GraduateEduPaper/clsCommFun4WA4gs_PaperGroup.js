var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsCommFun4BL.js", "../../PubFun/clsSysPara4WebApi.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsCommFun4WA4gs_PaperGroup = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsCommFun4WA4gs_PaperGroup
    表名:gs_PaperGroup(01120749)
    生成代码版本:2020.09.24.1
    生成日期:2020/09/28 18:28:56
    生成者:pyf2
    生成服务器IP:192.168.1.10
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培论文
    模块英文名:GraduateEduPaper
    框架-层名:WA_访问层公共函数类扩展(CommFun4WA)
    编程语言:TypeScript
    注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
           2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
    == == == == == == == == == == == ==
    */
    var clsCommFun4BL_js_1 = require("../../PubFun/clsCommFun4BL.js");
    var clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    var clsgs_PaperGroupWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    /// <summary>
    /// 论文分组(gs_PaperGroup)
    /// 数据源类型:SQL表
    /// (AutoGCLib.CommFun4WA4TypeScript:GeneCode)
    /// </summary>
    var clsCommFun4WA4gs_PaperGroup = /** @class */ (function (_super) {
        __extends(clsCommFun4WA4gs_PaperGroup, _super);
        function clsCommFun4WA4gs_PaperGroup() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        /// <summary>
        /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
        /// (AutoGCLib.CommFun4WA4TypeScript:Gen_4CFWA_Ts_ReFreshCache)
        /// </summary>
        clsCommFun4WA4gs_PaperGroup.prototype.ReFreshCache = function () {
            var strMsg = "";
            if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == false) {
                strMsg = "\u5237\u65B0\u7F13\u5B58\u5DF2\u7ECF\u5173\u95ED\u3002(clsSysPara4WebApi.spSetRefreshCacheOn == false)({clsStackTrace.GetCurrClassFunctionByLevel(3)}->{clsStackTrace.GetCurrClassFunctionByLevel(2)}->{clsStackTrace.GetCurrClassFunction()})";
                console.log(strMsg);
                return;
            }
            // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
            clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.ReFreshThisCache();
        };
        return clsCommFun4WA4gs_PaperGroup;
    }(clsCommFun4BL_js_1.clsCommFun4BL));
    exports.clsCommFun4WA4gs_PaperGroup = clsCommFun4WA4gs_PaperGroup;
});
