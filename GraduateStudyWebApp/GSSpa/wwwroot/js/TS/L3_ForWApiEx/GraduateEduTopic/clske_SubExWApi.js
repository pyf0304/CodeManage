(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTopic/clske_SubEN.js", "../../L0_Entity/GraduateEduTopic/clske_SubENEx.js", "../../L3_ForWApi/GraduateEduTopic/clske_SubWApi.js", "../../PubFun/clsString2.js", "../../PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clske_SubExWApi = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clske_SubExWApi
    表名:ke_Sub(01120660)
    生成代码版本:2021.06.19.1
    生成日期:2021/06/19 14:59:55
    生成者:pyf
    生成服务器IP:192.168.1.12
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:WA_访问扩展层(WA_AccessEx)
    编程语言:TypeScript
    注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
           2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
    == == == == == == == == == == == ==
    */
    //import * as QQ from "q";
    const clske_SubEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clske_SubEN.js");
    const clske_SubENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clske_SubENEx.js");
    const clske_SubWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clske_SubWApi.js");
    const clsString2_js_1 = require("../../PubFun/clsString2.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    var ResponseData;
    class clske_SubExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objke_SubEN = new clske_SubEN_js_1.clske_SubEN();
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
        /// <param name = "objke_SubENS">源对象</param>
        /// <returns>目标对象=>clske_SubEN:objke_SubENT</returns>
        static CopyToEx(objke_SubENS) {
            var objke_SubENT = new clske_SubENEx_js_1.clske_SubENEx();
            try {
                (0, clske_SubWApi_js_1.ke_Sub_CopyObjTo)(objke_SubENS, objke_SubENT);
                return objke_SubENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objke_SubENT;
            }
        }
    }
    exports.clske_SubExWApi = clske_SubExWApi;
    clske_SubExWApi.mstrController = "ke_SubExApi";
    ;
});
