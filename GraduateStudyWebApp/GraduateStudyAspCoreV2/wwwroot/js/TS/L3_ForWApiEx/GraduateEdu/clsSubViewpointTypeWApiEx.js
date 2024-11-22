(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/ParameterTable/clsSubViewpointTypeEN.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsSubViewpointTypeWApiEx = void 0;
    //import * as QQ from "q";
    const clsSubViewpointTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsSubViewpointTypeEN.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    var ResponseData;
    class clsSubViewpointTypeWApiEx {
        constructor(pobjSubViewpointTypeEN) {
            this.objSubViewpointTypeEN = new clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN();
            this.objSubViewpointTypeEN = pobjSubViewpointTypeEN;
        }
        ;
        /// <summary>
        /// 调用WebApi来添加记录，数据传递使用JSON串
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
        /// </summary>
        /// <param name = "objSubViewpointTypeEN">需要添加的对象</param>
        /// <returns>获取相应的记录的对象</returns>
        static AddNewRecordAsyncEx(objSubViewpointTypeEN) {
            var strMsg = "";
            var strAction = "AddNewRecordEx";
            //if (objSubViewpointTypeEN.subViewpointTypeId === null || objSubViewpointTypeEN.subViewpointTypeId === "") {
            //    strMsg = "需要的对象的关键字为空，不能添加!";
            //    throw strMsg;
            //}
            //var strJSON = JSON.stringify(objSubViewpointTypeEN_Sim);
            let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objSubViewpointTypeEN,
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
                strServiceUrl = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx3}/${strController}/${strAction}`;
            }
            else {
                strServiceUrl = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx3}/${strController}/${strAction}`;
            }
            return strServiceUrl;
        }
    }
    exports.clsSubViewpointTypeWApiEx = clsSubViewpointTypeWApiEx;
    clsSubViewpointTypeWApiEx.mstrController = "SubViewpointTypeExApi";
});
