(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/UserManage/clsvUsersSimEN.js", "../../L0_Entity/UserManage/clsvUsersSimENEx.js", "../../L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../../PubFun/clsString2.js", "../../PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvUsersSimExWApi = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsvUsersSimExWApi
    表名:vUsersSim(01120699)
    生成代码版本:2021.06.06.1
    生成日期:2021/06/17 22:30:41
    生成者:pyf
    生成服务器IP:103.116.76.183
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:用户管理
    模块英文名:UserManage
    框架-层名:WA_访问扩展层(WA_AccessEx)
    编程语言:TypeScript
    注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
           2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
    == == == == == == == == == == == ==
    */
    //import * as QQ from "q";
    const clsvUsersSimEN_js_1 = require("../../L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsvUsersSimENEx_js_1 = require("../../L0_Entity/UserManage/clsvUsersSimENEx.js");
    const clsvUsersSimWApi_js_1 = require("../../L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsString2_js_1 = require("../../PubFun/clsString2.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    var ResponseData;
    class clsvUsersSimExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objvUsersSimEN = new clsvUsersSimEN_js_1.clsvUsersSimEN();
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
        /// <param name = "objvUsersSimENS">源对象</param>
        /// <returns>目标对象=>clsvUsersSimEN:objvUsersSimENT</returns>
        static CopyToEx(objvUsersSimENS) {
            var objvUsersSimENT = new clsvUsersSimENEx_js_1.clsvUsersSimENEx();
            try {
                (0, clsvUsersSimWApi_js_1.vUsersSim_CopyObjTo)(objvUsersSimENS, objvUsersSimENT);
                return objvUsersSimENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objvUsersSimENT;
            }
        }
    }
    exports.clsvUsersSimExWApi = clsvUsersSimExWApi;
    clsvUsersSimExWApi.mstrController = "vUsersSimExApi";
    ;
});
