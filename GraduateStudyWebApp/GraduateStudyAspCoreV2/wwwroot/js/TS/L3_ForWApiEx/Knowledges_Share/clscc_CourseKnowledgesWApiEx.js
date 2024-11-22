(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clscc_CourseKnowledgesWApiEx = void 0;
    /// <summary>
    /// 课程知识点(cc_CourseKnowledges)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2019年12月04日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as QQ from "q";
    const clscc_CourseKnowledgesEN_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    var ResponseData;
    class clscc_CourseKnowledgesWApiEx {
        constructor(pobjcc_CourseKnowledgesEN) {
            this.objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN();
            this.objcc_CourseKnowledgesEN = pobjcc_CourseKnowledgesEN;
        }
        ;
        /// <summary>
        /// 调用WebApi来添加记录，数据传递使用JSON串
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
        /// </summary>
        /// <param name = "objcc_CourseKnowledgesEN">需要添加的对象</param>
        /// <returns>获取相应的记录的对象</returns>
        static AddNewRecordAsyncEx(objcc_CourseKnowledgesEN) {
            var strMsg = "";
            var strAction = "AddNewRecordEx";
            //if (objcc_CourseKnowledgesEN.courseKnowledgeId === null || objcc_CourseKnowledgesEN.courseKnowledgeId === "") {
            //    strMsg = "需要的对象的关键字为空，不能添加!";
            //    throw strMsg;
            //}
            //var strJSON = JSON.stringify(objcc_CourseKnowledgesEN_Sim);
            let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objcc_CourseKnowledgesEN,
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
    exports.clscc_CourseKnowledgesWApiEx = clscc_CourseKnowledgesWApiEx;
    clscc_CourseKnowledgesWApiEx.mstrController = "cc_CourseKnowledgesExApi";
});
