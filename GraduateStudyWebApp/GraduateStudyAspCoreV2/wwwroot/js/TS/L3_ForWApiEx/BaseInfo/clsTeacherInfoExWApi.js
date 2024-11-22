(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/BaseInfo_Share/clsTeacherInfoEN.js", "../../L0_Entity/BaseInfo_Share/clsTeacherInfoENEx.js", "../../PubConfig/clsSysPara4WebApi.js", "../../L3_ForWApi/BaseInfo_Share/clsTeacherInfoWApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsTeacherInfoExWApi = void 0;
    //import * as QQ from "q";
    const clsTeacherInfoEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsTeacherInfoEN.js");
    const clsTeacherInfoENEx_js_1 = require("../../L0_Entity/BaseInfo_Share/clsTeacherInfoENEx.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsTeacherInfoWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsTeacherInfoWApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    var ResponseData;
    class clsTeacherInfoExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objTeacherInfoEN = new clsTeacherInfoEN_js_1.clsTeacherInfoEN();
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
        /// <param name = "objTeacherInfoENS">源对象</param>
        /// <returns>目标对象=>clsTeacherInfoEN:objTeacherInfoENT</returns>
        static CopyToEx(objTeacherInfoENS) {
            var objTeacherInfoENT = new clsTeacherInfoENEx_js_1.clsTeacherInfoENEx();
            try {
                (0, clsTeacherInfoWApi_js_1.TeacherInfo_CopyObjTo)(objTeacherInfoENS, objTeacherInfoENT);
                return objTeacherInfoENT;
            }
            catch (e) {
                var strMsg = (0, clsString_js_1.Format)("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objTeacherInfoENT;
            }
        }
    }
    exports.clsTeacherInfoExWApi = clsTeacherInfoExWApi;
    clsTeacherInfoExWApi.mstrController = "TeacherInfoExApi";
    ;
});