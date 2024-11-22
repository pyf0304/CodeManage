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
    var clsSysPara4WebApi = /** @class */ (function () {
        function clsSysPara4WebApi() {
        }
        clsSysPara4WebApi.bolIsLocalHost = false;
        //var CurrIPAddressAndPort = "http://Localhost:2408";
        //    public static CurrIPAddressAndPort:string = getHostAddress_web();// "http://Localhost:2408";
        clsSysPara4WebApi.CurrIPAddressAndPort = "101.251.68.133"; // getHostAddress_web();// "http://Localhost:2408";
        clsSysPara4WebApi.CurrIPAddressAndPort_Local = "localhost:49540"; // getHostAddress_web();// "http://Localhost:2408";
        //public static CurrPrx: string = VirtualRootPath + "/WebApi";
        clsSysPara4WebApi.CurrPrx = "GP/Api";
        return clsSysPara4WebApi;
    }());
    exports.clsSysPara4WebApi = clsSysPara4WebApi;
});
