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
        clsSysPara4WebApi.bolIsLocalHost = true; //本地调试true 服务器false；
        clsSysPara4WebApi.CurrIPAddressAndPort = "https://www.sh-tz.com"; // getHostAddress_web();// "http://Localhost:2408";
        clsSysPara4WebApi.CurrIPAddressAndPort_Local = "http://localhost:58332"; //本地api调试
        //public static CurrPrx: string = "Api";//本地； 
        //本地图片
        clsSysPara4WebApi.CurrPrx_Local = "GraduateStudyWebApp";
        //服务器
        clsSysPara4WebApi.CurrPrx = "ExamLibApi/Api";
        clsSysPara4WebApi.CurrPrx2 = "ExamLibApi/Api";
        clsSysPara4WebApi.CurrPrx3 = "ExamLibApi/Api";
        clsSysPara4WebApi.spSetRefreshCacheOn = true;
        return clsSysPara4WebApi;
    }());
    exports.clsSysPara4WebApi = clsSysPara4WebApi;
});
