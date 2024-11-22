(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/InteractManage/clsqa_AnswerVEN.js", "../../L0_Entity/InteractManage/clsqa_AnswerVENEx.js", "../../L3_ForWApi/InteractManage/clsqa_AnswerVWApi.js", "../../PubFun/clsString2.js", "../../PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsqa_AnswerVExWApi = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsqa_AnswerVExWApi
    表名:qa_AnswerV(01120756)
    生成代码版本:2021.06.19.1
    生成日期:2021/06/19 15:44:49
    生成者:pyf
    生成服务器IP:103.116.76.183
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:互动管理
    模块英文名:InteractManage
    框架-层名:WA_访问扩展层(WA_AccessEx)
    编程语言:TypeScript
    注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
           2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
    == == == == == == == == == == == ==
    */
    //import * as QQ from "q";
    const clsqa_AnswerVEN_js_1 = require("../../L0_Entity/InteractManage/clsqa_AnswerVEN.js");
    const clsqa_AnswerVENEx_js_1 = require("../../L0_Entity/InteractManage/clsqa_AnswerVENEx.js");
    const clsqa_AnswerVWApi_js_1 = require("../../L3_ForWApi/InteractManage/clsqa_AnswerVWApi.js");
    const clsString2_js_1 = require("../../PubFun/clsString2.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    var ResponseData;
    class clsqa_AnswerVExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objqa_AnswerVEN = new clsqa_AnswerVEN_js_1.clsqa_AnswerVEN();
        }
        ;
        /// <summary>
        /// 获取WebApi的地址
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
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
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objqa_AnswerVENS">源对象</param>
        /// <returns>目标对象=>clsqa_AnswerVEN:objqa_AnswerVENT</returns>
        static CopyToEx(objqa_AnswerVENS) {
            var objqa_AnswerVENT = new clsqa_AnswerVENEx_js_1.clsqa_AnswerVENEx();
            try {
                (0, clsqa_AnswerVWApi_js_1.qa_AnswerV_CopyObjTo)(objqa_AnswerVENS, objqa_AnswerVENT);
                return objqa_AnswerVENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objqa_AnswerVENT;
            }
        }
    }
    exports.clsqa_AnswerVExWApi = clsqa_AnswerVExWApi;
    clsqa_AnswerVExWApi.mstrController = "qa_AnswerVExApi";
    ;
});
