var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "jquery", "../../PubFun/tzDictionary.js", "../../PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clswxUserInfoExWApi = void 0;
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
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
            if (clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.bolIsLocalHost == false) {
                strServiceUrl = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx}/${strController}/${strAction}`;
            }
            else {
                strServiceUrl = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx}/${strController}/${strAction}`;
            }
            return strServiceUrl;
        }
    }
    exports.clswxUserInfoExWApi = clswxUserInfoExWApi;
    clswxUserInfoExWApi.mstrController = "wxUserInfoExApi";
    ;
});
