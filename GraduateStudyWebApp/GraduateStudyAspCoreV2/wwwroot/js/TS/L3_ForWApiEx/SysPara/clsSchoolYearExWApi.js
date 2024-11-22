(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/SysPara/clsSchoolYearEN.js", "../../L0_Entity/SysPara/clsSchoolYearENEx.js", "../../L3_ForWApi/SysPara/clsSchoolYearWApi.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsSchoolYearExWApi = void 0;
    //import * as QQ from "q";
    const clsSchoolYearEN_js_1 = require("../../L0_Entity/SysPara/clsSchoolYearEN.js");
    const clsSchoolYearENEx_js_1 = require("../../L0_Entity/SysPara/clsSchoolYearENEx.js");
    const clsSchoolYearWApi_js_1 = require("../../L3_ForWApi/SysPara/clsSchoolYearWApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    var ResponseData;
    class clsSchoolYearExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objSchoolYearEN = new clsSchoolYearEN_js_1.clsSchoolYearEN();
        }
        ;
        /// <summary>
        /// 获取WebApi的地址
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        static GetWebApiUrl(strController, strAction) {
            var strServiceUrl;
            if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
                strServiceUrl = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
            }
            else {
                strServiceUrl = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
            }
            return strServiceUrl;
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objSchoolYearENS">源对象</param>
        /// <returns>目标对象=>clsSchoolYearEN:objSchoolYearENT</returns>
        static CopyToEx(objSchoolYearENS) {
            var objSchoolYearENT = new clsSchoolYearENEx_js_1.clsSchoolYearENEx();
            try {
                (0, clsSchoolYearWApi_js_1.SchoolYear_CopyObjTo)(objSchoolYearENS, objSchoolYearENT);
                return objSchoolYearENT;
            }
            catch (e) {
                var strMsg = (0, clsString_js_1.Format)("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objSchoolYearENT;
            }
        }
    }
    exports.clsSchoolYearExWApi = clsSchoolYearExWApi;
    clsSchoolYearExWApi.mstrController = "SchoolYearExApi";
    ;
});
