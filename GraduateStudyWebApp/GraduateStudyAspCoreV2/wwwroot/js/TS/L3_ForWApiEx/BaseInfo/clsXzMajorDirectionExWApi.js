/*-- -- -- -- -- -- -- -- -- -- --
类名:clsXzMajorDirectionExWApi
表名:XzMajorDirection(01120552)
生成代码版本:2021.06.06.1
生成日期:2021/06/11 17:41:46
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:基本信息维护
模块英文名:BaseInfo
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/BaseInfo_Share/clsXzMajorDirectionEN.js", "../../L0_Entity/BaseInfo_Share/clsXzMajorDirectionENEx.js", "../../PubConfig/clsSysPara4WebApi.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsXzMajorDirectionExWApi = void 0;
    /// <summary>
    /// 专业方向(XzMajorDirection)
    /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by pyf on 2021年06月11日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as QQ from "q";
    const clsXzMajorDirectionEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorDirectionEN.js");
    const clsXzMajorDirectionENEx_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorDirectionENEx.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsXzMajorDirectionWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    var ResponseData;
    class clsXzMajorDirectionExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objXzMajorDirectionEN = new clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN();
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
        /// <param name = "objXzMajorDirectionENS">源对象</param>
        /// <returns>目标对象=>clsXzMajorDirectionEN:objXzMajorDirectionENT</returns>
        static CopyToEx(objXzMajorDirectionENS) {
            var objXzMajorDirectionENT = new clsXzMajorDirectionENEx_js_1.clsXzMajorDirectionENEx();
            try {
                (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_CopyObjTo)(objXzMajorDirectionENS, objXzMajorDirectionENT);
                return objXzMajorDirectionENT;
            }
            catch (e) {
                var strMsg = (0, clsString_js_1.Format)("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objXzMajorDirectionENT;
            }
        }
    }
    exports.clsXzMajorDirectionExWApi = clsXzMajorDirectionExWApi;
    clsXzMajorDirectionExWApi.mstrController = "XzMajorDirectionExApi";
    ;
});
