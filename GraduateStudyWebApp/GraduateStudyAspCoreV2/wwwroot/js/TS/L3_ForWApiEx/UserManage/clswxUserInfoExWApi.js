(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clswxUserInfoExWApi = void 0;
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    var ReCallFunc = null;
    class clswxUserInfoExWApi {
        constructor(strMethod, mapParam, pReCallFunc) {
            this.NameSpace = "http://tempuri.org/";
            this.MethodName = "";
            this.WEB_SERVICE_URL = "";
            this.soapAction = "";
            this.Param = new tzDictionary_js_1.Dictionary();
            ReCallFunc = pReCallFunc;
            this.MethodName = strMethod;
            this.Param = mapParam;
            if (this.Param.length() === 0) {
                this.Param = new tzDictionary_js_1.Dictionary();
            }
        }
        ;
        /// <summary>
        /// 获取微信信息
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <returns>获取的相应对象列表</returns>
        static GetwxUserInfoAsync(strcode) {
            var strAction = "GetwxUserInfo";
            let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strcode", strcode);
            let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "Get",
                    dataType: "json",
                    data: strData,
                    success: function (data) {
                        resolve(data);
                    },
                    error: (e) => {
                        console.error(e);
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        }
        ;
        /// <summary>
        /// 获取WebApi的地址
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
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
    }
    exports.clswxUserInfoExWApi = clswxUserInfoExWApi;
    clswxUserInfoExWApi.mstrController = "wxUserInfoExApi";
    ;
});
