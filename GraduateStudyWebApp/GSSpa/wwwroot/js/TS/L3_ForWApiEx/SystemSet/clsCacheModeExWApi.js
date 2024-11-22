/**
* 类名:clsCacheModeExWApi
* 表名:CacheMode(01120688)
* 生成代码版本:2021.09.17.1
* 生成日期:2021/09/20 16:03:13
* 生成者:pyf
* 生成服务器IP:103.116.76.183
* 工程名称:问卷调查
* 工程ID:0112
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:系统设置
* 模块英文名:SystemSet
* 框架-层名:WA_访问扩展层(WA_AccessEx)
* 编程语言:TypeScript
* 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
  *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
**/
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/SystemSet/clsCacheModeEN.js", "../../L0_Entity/SystemSet/clsCacheModeENEx.js", "../../PubFun/clsSysPara4WebApi2.js", "../../PubFun/clsString2.js", "../../L3_ForWApi/SystemSet/clsCacheModeWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsCacheModeExWApi = void 0;
    /**
    * 缓存方式(CacheMode)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2021年09月20日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCacheModeEN_js_1 = require("../../L0_Entity/SystemSet/clsCacheModeEN.js");
    const clsCacheModeENEx_js_1 = require("../../L0_Entity/SystemSet/clsCacheModeENEx.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    const clsString2_js_1 = require("../../PubFun/clsString2.js");
    const clsCacheModeWApi_js_1 = require("../../L3_ForWApi/SystemSet/clsCacheModeWApi.js");
    class clsCacheModeExWApi {
        constructor() {
            this.objCacheModeEN = new clsCacheModeEN_js_1.clsCacheModeEN();
        }
        /**
        * 获取WebApi的地址
        * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
        * @returns 返回当前文件中Web服务的地址
        **/
        static GetWebApiUrl(strController, strAction) {
            let strServiceUrl;
            if (clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.bolIsLocalHost == false) {
                strServiceUrl = clsString2_js_1.clsString.Format("{0}/{1}/{2}/{3}", clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort, clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx, strController, strAction);
            }
            else {
                strServiceUrl = clsString2_js_1.clsString.Format("{0}/{1}/{2}/{3}", clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort_Local, clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx, strController, strAction);
            }
            return strServiceUrl;
        }
        /**
        * 把同一个类的对象,复制到另一个对象
        * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
        * @param objCacheModeENS:源对象
        * @returns 目标对象=>clsCacheModeEN:objCacheModeENT
        **/
        static CopyToEx(objCacheModeENS) {
            const objCacheModeENT = new clsCacheModeENEx_js_1.clsCacheModeENEx();
            try {
                (0, clsCacheModeWApi_js_1.CacheMode_CopyObjTo)(objCacheModeENS, objCacheModeENT);
                return objCacheModeENT;
            }
            catch (e) {
                const strMsg = clsString2_js_1.clsString.Format("(errid:Watl000066)Copy表对象数据出错,{0}.", e);
                console.error(strMsg);
                alert(strMsg);
                return objCacheModeENT;
            }
        }
    }
    exports.clsCacheModeExWApi = clsCacheModeExWApi;
    clsCacheModeExWApi.mstrController = "CacheModeExApi";
});