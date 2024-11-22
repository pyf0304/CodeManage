(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js", "../../L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_OriginalPaperLogExWApi = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsgs_OriginalPaperLogExWApi
    表名:gs_OriginalPaperLog(01120680)
    生成代码版本:2021.06.06.1
    生成日期:2021/06/11 17:33:35
    生成者:pyf
    生成服务器IP:103.116.76.183
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培论文
    模块英文名:GraduateEduPaper
    框架-层名:WA_访问扩展层(WA_AccessEx)
    编程语言:TypeScript
    注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
           2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
    == == == == == == == == == == == ==
    */
    //import * as QQ from "q";
    const clsgs_OriginalPaperLogEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js");
    const clsgs_OriginalPaperLogENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogENEx.js");
    const clsgs_OriginalPaperLogWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    var ResponseData;
    class clsgs_OriginalPaperLogExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN();
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
        /// <param name = "objgs_OriginalPaperLogENS">源对象</param>
        /// <returns>目标对象=>clsgs_OriginalPaperLogEN:objgs_OriginalPaperLogENT</returns>
        static CopyToEx(objgs_OriginalPaperLogENS) {
            var objgs_OriginalPaperLogENT = new clsgs_OriginalPaperLogENEx_js_1.clsgs_OriginalPaperLogENEx();
            try {
                (0, clsgs_OriginalPaperLogWApi_js_1.gs_OriginalPaperLog_CopyObjTo)(objgs_OriginalPaperLogENS, objgs_OriginalPaperLogENT);
                return objgs_OriginalPaperLogENT;
            }
            catch (e) {
                var strMsg = (0, clsString_js_1.Format)("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objgs_OriginalPaperLogENT;
            }
        }
    }
    exports.clsgs_OriginalPaperLogExWApi = clsgs_OriginalPaperLogExWApi;
    clsgs_OriginalPaperLogExWApi.mstrController = "gs_OriginalPaperLogExApi";
    ;
});
