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
        define(["require", "exports", "jquery", "../../PubFun/tzDictionary.js", "../../PubFun/clsSysPara4WebApi2.js", "../../L0_Entity/GraduateEduTopic/clsgs_RTqa_PaperRelaEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_RTqa_PaperRelaExWApi = void 0;
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2019年12月25日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    const clsgs_RTqa_PaperRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_RTqa_PaperRelaEN.js");
    var ResponseData;
    class clsgs_RTqa_PaperRelaExWApi {
        constructor(pobjgs_RTqa_PaperRelaEN) {
            this.objgs_RTqa_PaperRelaEN = new clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN();
            this.objgs_RTqa_PaperRelaEN = pobjgs_RTqa_PaperRelaEN;
        }
        ;
        /// <summary>
        /// 同步核算
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        static SynTopicPaperQAAsync(strid_CurrEduCls, strTopicId, strUpdUser) {
            var strAction = "SynTopicPaperQA";
            let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strid_CurrEduCls", strid_CurrEduCls);
            mapParam.add("strTopicId", strTopicId);
            mapParam.add("strUpdUser", strUpdUser);
            let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "json",
                    data: strData,
                    success: function (data) {
                        resolve(data);
                        //if (data.ErrorId == 0) {
                        //    resolve(data.ReturnStr);
                        //}
                        //else {
                        //    console.log(data.ErrorMsg);
                        //    reject(data.ErrorMsg);
                        //}
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        }
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
    exports.clsgs_RTqa_PaperRelaExWApi = clsgs_RTqa_PaperRelaExWApi;
    clsgs_RTqa_PaperRelaExWApi.mstrController = "gs_RTqa_PaperRelaExApi";
});
