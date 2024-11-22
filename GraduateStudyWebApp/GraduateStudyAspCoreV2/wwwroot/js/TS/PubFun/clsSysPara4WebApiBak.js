/*
 * 功能:用于WebApi的参数定义
 * 版本:2019-07-24-01
 * 作者:潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PubConfig/clsSysPara4WebApi.js", "./clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.GetWebApiUrl = exports.clsSysPara4WebApiBak = void 0;
    const clsSysPara4WebApi_js_1 = require("../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("./clsString.js");
    class clsSysPara4WebApiBak {
    }
    exports.clsSysPara4WebApiBak = clsSysPara4WebApiBak;
    clsSysPara4WebApiBak.bolIsLocalHost = true; //true,,,false
    //const CurrIPAddressAndPort = "http://Localhost:2408";
    //    public static CurrIPAddressAndPort:string = getHostAddress_web();// "http://Localhost:2408";
    clsSysPara4WebApiBak.CurrIPAddressAndPort = "https://www.sh-tz.com"; // getHostAddress_web();// "http://Localhost:2408";
    clsSysPara4WebApiBak.CurrIPAddressAndPortBak = "http://tzar.tpddns.net:9080"; // getHostAddress_web();// "http://Localhost:2408";
    //    public static CurrIPAddressAndPort_Local: string = "http://localhost:39541";// getHostAddress_web();// "http://Localhost:2408";
    clsSysPara4WebApiBak.CurrPrx = "ExamLibWA";
    clsSysPara4WebApiBak.CurrPrx2 = "ExamLibApi/Api";
    clsSysPara4WebApiBak.CurrPrx3 = "ExamLibApi/Api";
    clsSysPara4WebApiBak.CurrIPAddressAndPort_Local = "http://localhost:28523"; // getHostAddress_web();// "http://Localhost:2408";
    //public static CurrPrx: string = VirtualRootPath + "/WebApi";
    //public static CurrPrx = "";
    clsSysPara4WebApiBak.CurrIPAddressAndPort_GPBak = "http://103.116.76.183:8080"; // getHostAddress_web();// "http://Localhost:2408";
    //    public static CurrIPAddressAndPort_GP: string = "http://tzar.tpddns.cn:9080";// getHostAddress_web();// "http://Localhost:2408";
    //public static CurrIPAddressAndPort_Local_GP: string = "http://localhost:49540";// getHostAddress_web();// "http://Localhost:2408";
    clsSysPara4WebApiBak.CurrIPAddressAndPort_Local_GPBak = "http://tzar.tpddns.net:9080"; // getHostAddress_web();// "http://Localhost:2408";
    clsSysPara4WebApiBak.CurrIPAddressAndPort_Local_GP = "http://103.116.76.183:8080"; // getHostAddress_web();// "http://Localhost:2408";
    //    public static CurrIPAddressAndPort_GP = "http://103.116.76.183:8080";// getHostAddress_web();// "http://Localhost:2408";
    clsSysPara4WebApiBak.CurrIPAddressAndPort_GP = "https://www.sh-tz.com"; // getHostAddress_web();// "http://Localhost:2408";
    //public static CurrPrx: string = VirtualRootPath + "/WebApi";
    clsSysPara4WebApiBak.CurrPrx_GP = "GpWATz";
    clsSysPara4WebApiBak.Url_Session_SetString = "";
    clsSysPara4WebApiBak.spSetRefreshCacheOn = true;
    //"http://localhost:2408/ExamLib/WebService/MyTest1Service.asmx";
    //本地图片
    clsSysPara4WebApiBak.CurrPrx_Local = "GraduateStudyWebApp";
    function GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.GetWebApiUrl = GetWebApiUrl;
});
