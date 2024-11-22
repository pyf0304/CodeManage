/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvXzMajorDirectionExWApi
表名:vXzMajorDirection(01120553)
生成代码版本:2021.06.06.1
生成日期:2021/06/11 17:41:23
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
        define(["require", "exports", "../../L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js", "../../L0_Entity/BaseInfo/clsvXzMajorDirectionENEx.js", "../../PubFun/clsSysPara4WebApi2.js", "../../PubFun/clsString2.js", "../../L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvXzMajorDirectionExWApi = void 0;
    //import * as QQ from "q";
    const clsvXzMajorDirectionEN_js_1 = require("../../L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js");
    const clsvXzMajorDirectionENEx_js_1 = require("../../L0_Entity/BaseInfo/clsvXzMajorDirectionENEx.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    const clsString2_js_1 = require("../../PubFun/clsString2.js");
    const clsvXzMajorDirectionWApi_js_1 = require("../../L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js");
    var ResponseData;
    class clsvXzMajorDirectionExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objvXzMajorDirectionEN = new clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN();
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
        /// <param name = "objvXzMajorDirectionENS">源对象</param>
        /// <returns>目标对象=>clsvXzMajorDirectionEN:objvXzMajorDirectionENT</returns>
        static CopyToEx(objvXzMajorDirectionENS) {
            var objvXzMajorDirectionENT = new clsvXzMajorDirectionENEx_js_1.clsvXzMajorDirectionENEx();
            try {
                (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_CopyObjTo)(objvXzMajorDirectionENS, objvXzMajorDirectionENT);
                return objvXzMajorDirectionENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objvXzMajorDirectionENT;
            }
        }
    }
    exports.clsvXzMajorDirectionExWApi = clsvXzMajorDirectionExWApi;
    clsvXzMajorDirectionExWApi.mstrController = "vXzMajorDirectionExApi";
    ;
});
