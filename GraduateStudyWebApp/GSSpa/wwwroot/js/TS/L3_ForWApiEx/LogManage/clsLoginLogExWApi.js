/*-- -- -- -- -- -- -- -- -- -- --
类名:clsLoginLogExWApi
表名:LoginLog(01120357)
生成代码版本:2021.01.04.1
生成日期:2021/01/04 16:59:47
生成者:lyl
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:日志管理
模块英文名:LogManage
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
        define(["require", "exports", "../../L0_Entity/LogManage/clsLoginLogEN.js", "../../L0_Entity/LogManage/clsLoginLogENEx.js", "../../PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsLoginLogExWApi = void 0;
    //import * as QQ from "q";
    const clsLoginLogEN_js_1 = require("../../L0_Entity/LogManage/clsLoginLogEN.js");
    const clsLoginLogENEx_js_1 = require("../../L0_Entity/LogManage/clsLoginLogENEx.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    var ResponseData;
    class clsLoginLogExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objLoginLogEN = new clsLoginLogEN_js_1.clsLoginLogEN();
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
        /// 把同一个类的对象,复制到该类的扩展对象
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objLoginLogENS">源对象</param>
        /// <param name = "objLoginLogENT">目标对象</param>
        static CopyToEx(objLoginLogENS) {
            var objLoginLogENT = new clsLoginLogENEx_js_1.clsLoginLogENEx();
            objLoginLogENT.loginLogId = objLoginLogENS.loginLogId; //loginLogId
            objLoginLogENT.loginLogNumber = objLoginLogENS.loginLogNumber; //loginLogNumber
            objLoginLogENT.loginIP = objLoginLogENS.loginIP; //loginIP
            objLoginLogENT.failReason = objLoginLogENS.failReason; //failReason
            objLoginLogENT.loginResult = objLoginLogENS.loginResult; //loginResult
            objLoginLogENT.loginTime = objLoginLogENS.loginTime; //loginTime
            objLoginLogENT.loginUserId = objLoginLogENS.loginUserId; //loginUserId
            objLoginLogENT.memo = objLoginLogENS.memo; //备注
            objLoginLogENT.onlineTime = objLoginLogENS.onlineTime; //onlineTime
            objLoginLogENT.outTime = objLoginLogENS.outTime; //outTime
            objLoginLogENT.sf_UpdFldSetStr = objLoginLogENS.updFldString; //专门用于记录某字段属性是否修改
            objLoginLogENT.sf_FldComparisonOp = objLoginLogENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
            return objLoginLogENT;
        }
    }
    exports.clsLoginLogExWApi = clsLoginLogExWApi;
    clsLoginLogExWApi.mstrController = "LoginLogExApi";
    ;
});
