var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/tzDictionary.js", "../../PubConfig/clsSysPara4WebApi.js", "../../L0_Entity/GraduateEduTopic/clsgs_ResearchResultEN.js", "../../PubFun/clsString.js", "axios", "../../L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_ResearchResultExWApi = void 0;
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2019年12月25日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as QQ from "q";
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsgs_ResearchResultEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_ResearchResultEN.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const axios_1 = __importDefault(require("axios"));
    const clsgs_ResearchResultWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultWApi.js");
    var ResponseData;
    class clsgs_ResearchResultExWApi {
        constructor(pobjgs_ResearchResultEN) {
            this.objgs_ResearchResultEN = new clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN();
            this.objgs_ResearchResultEN = pobjgs_ResearchResultEN;
        }
        ;
        /// <summary>
        /// 获取会议年数量
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象列表</returns>
        static async GetResultYearNumObjLstAsync(strWhereCond) {
            const strThisFuncName = "GetResultYearNumObjLstAsync";
            var strAction = "GetResultYearNumObjLst";
            let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            try {
                const response = await axios_1.default.get(strUrl, {
                    params: { "strWhereCond": strWhereCond }
                });
                const data = response.data;
                if (data.errorId == 0) {
                    const returnObjLst = data.returnObjLst;
                    if (returnObjLst == null) {
                        const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", this.mstrController, strThisFuncName);
                        console.error(strNullInfo);
                        throw (strNullInfo);
                    }
                    //console.log(returnObjLst);
                    const arrObjLst = (0, clsgs_ResearchResultWApi_js_1.gs_ResearchResult_GetObjLstByJSONObjLst)(returnObjLst);
                    return (arrObjLst);
                }
                else {
                    console.error(data.errorMsg);
                    throw (data.errorMsg);
                }
            }
            catch (error) {
                console.error(error);
                if (error.statusText == undefined) {
                    throw error;
                }
                if (error.statusText == "error") {
                    const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                    console.error(strInfo);
                    throw (strInfo);
                }
                else if (error.statusText == "Not Found") {
                    const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                    console.error(strInfo);
                    throw (strInfo);
                }
                else {
                    throw (error.statusText);
                }
            }
        }
        /// <summary>
        /// 获取会议月份数量
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象列表</returns>
        static async GetResultMonthNumObjLstAsync(strWhereCond) {
            const strThisFuncName = "GetResultMonthNumObjLstAsync";
            var strAction = "GetResultMonthNumObjLst";
            let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            try {
                const response = await axios_1.default.get(strUrl, {
                    params: { "strWhereCond": strWhereCond }
                });
                const data = response.data;
                if (data.errorId == 0) {
                    const returnObjLst = data.returnObjLst;
                    if (returnObjLst == null) {
                        const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", this.mstrController, strThisFuncName);
                        console.error(strNullInfo);
                        throw (strNullInfo);
                    }
                    //console.log(returnObjLst);
                    const arrObjLst = (0, clsgs_ResearchResultWApi_js_1.gs_ResearchResult_GetObjLstByJSONObjLst)(returnObjLst);
                    return (arrObjLst);
                }
                else {
                    console.error(data.errorMsg);
                    throw (data.errorMsg);
                }
            }
            catch (error) {
                console.error(error);
                if (error.statusText == undefined) {
                    throw error;
                }
                if (error.statusText == "error") {
                    const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                    console.error(strInfo);
                    throw (strInfo);
                }
                else if (error.statusText == "Not Found") {
                    const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                    console.error(strInfo);
                    throw (strInfo);
                }
                else {
                    throw (error.statusText);
                }
            }
        }
        /// <summary>
        /// 获取会议日期数量
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象列表</returns>
        static async GetResultDateNumObjLstAsync(strWhereCond) {
            const strThisFuncName = "GetResultDateNumObjLstAsync";
            var strAction = "GetResultDateNumObjLst";
            let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            try {
                const response = await axios_1.default.get(strUrl, {
                    params: { "strWhereCond": strWhereCond }
                });
                const data = response.data;
                if (data.errorId == 0) {
                    const returnObjLst = data.returnObjLst;
                    if (returnObjLst == null) {
                        const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", this.mstrController, strThisFuncName);
                        console.error(strNullInfo);
                        throw (strNullInfo);
                    }
                    //console.log(returnObjLst);
                    const arrObjLst = (0, clsgs_ResearchResultWApi_js_1.gs_ResearchResult_GetObjLstByJSONObjLst)(returnObjLst);
                    return (arrObjLst);
                }
                else {
                    console.error(data.errorMsg);
                    throw (data.errorMsg);
                }
            }
            catch (error) {
                console.error(error);
                if (error.statusText == undefined) {
                    throw error;
                }
                if (error.statusText == "error") {
                    const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                    console.error(strInfo);
                    throw (strInfo);
                }
                else if (error.statusText == "Not Found") {
                    const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                    console.error(strInfo);
                    throw (strInfo);
                }
                else {
                    throw (error.statusText);
                }
            }
        }
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
    exports.clsgs_ResearchResultExWApi = clsgs_ResearchResultExWApi;
    clsgs_ResearchResultExWApi.mstrController = "gs_ResearchResultExApi";
});
