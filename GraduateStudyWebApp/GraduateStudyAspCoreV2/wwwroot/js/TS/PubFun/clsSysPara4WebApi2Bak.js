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
    exports.clsSysPara4WebApi3 = void 0;
    class clsSysPara4WebApi3 {
    }
    exports.clsSysPara4WebApi3 = clsSysPara4WebApi3;
    clsSysPara4WebApi3.bolIsLocalHost = false; //本地调试true 服务器false；
    clsSysPara4WebApi3.CurrIPAddressAndPort = "https://www.sh-tz.com"; // getHostAddress_web();// "http://Localhost:2408";
    //public static CurrIPAddressAndPort: string = "http://tzar.tpddns.cn:9080";// getHostAddress_web();// "http://Localhost:2408";
    clsSysPara4WebApi3.CurrIPAddressAndPort_Local = "http://localhost:58332"; //本地api调试
    //http://localhost:49590/;
    //http://localhost:58332
    //public static CurrPrx: string = "Api";//本地； 
    //本地图片
    clsSysPara4WebApi3.CurrPrx_Local = "GraduateStudyWebApp";
    //本地图片展示前缀
    clsSysPara4WebApi3.CurrIPAddressAndPort_LocalPic = "http://localhost:49590"; //本地api调试
    //服务器
    clsSysPara4WebApi3.CurrPrx = "ExamLibApi/Api";
    clsSysPara4WebApi3.CurrPrx2 = "ExamLibApi/Api";
    clsSysPara4WebApi3.CurrPrx3 = "ExamLibApi/Api";
    clsSysPara4WebApi3.spSetRefreshCacheOn = true;
});
