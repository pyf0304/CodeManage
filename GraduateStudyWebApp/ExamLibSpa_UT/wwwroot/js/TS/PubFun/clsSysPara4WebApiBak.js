/*
 * 功能：用于WebApi的参数定义
 * 版本：2019-07-24-01
 * 作者：潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var clsSysPara4WebApiBak = /** @class */ (function () {
        function clsSysPara4WebApiBak() {
        }
        clsSysPara4WebApiBak.bolIsLocalHost = false;
        //var CurrIPAddressAndPort = "http://Localhost:2408";
        //    public static CurrIPAddressAndPort:string = getHostAddress_web();// "http://Localhost:2408";
        clsSysPara4WebApiBak.CurrIPAddressAndPort = "tzar.tpddns.cn:9080"; // getHostAddress_web();// "http://Localhost:2408";
        clsSysPara4WebApiBak.CurrIPAddressAndPort_Local = "localhost:49540"; // getHostAddress_web();// "http://Localhost:2408";
        //public static CurrPrx: string = VirtualRootPath + "/WebApi";
        clsSysPara4WebApiBak.CurrPrx = "ExamLibSpa/Api";
        clsSysPara4WebApiBak.CurrIPAddressAndPort_GP = "tzar.tpddns.cn:9080"; // getHostAddress_web();// "http://Localhost:2408";
        clsSysPara4WebApiBak.CurrIPAddressAndPort_Local_GP = "localhost:49540"; // getHostAddress_web();// "http://Localhost:2408";
        //public static CurrPrx: string = VirtualRootPath + "/WebApi";
        clsSysPara4WebApiBak.CurrPrx_GP = "GP/Api";
        return clsSysPara4WebApiBak;
    }());
    exports.clsSysPara4WebApiBak = clsSysPara4WebApiBak;
});
