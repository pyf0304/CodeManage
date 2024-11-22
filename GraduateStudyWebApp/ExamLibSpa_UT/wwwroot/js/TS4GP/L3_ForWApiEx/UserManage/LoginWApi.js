/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUsersWApi
表名:QxUsers(00140015)
生成代码版本:2019.07.15.2
生成日期:2019/07/18 14:54:37
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433GeneralPlatformTz
PrjDataBaseId:0184
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WebApi访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
    result["default"] = mod;
    return result;
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "jquery", "../../PubFun/tzDictionary.js", "../../pubfun/clssyspara4webapi.js", "../../PubFun/stuLoginPara.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    /// <summary>
    /// 用户(QxUsers)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2019年07月18日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    var $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    var tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    var clssyspara4webapi_js_1 = require("../../pubfun/clssyspara4webapi.js");
    var stuLoginPara_js_1 = require("../../PubFun/stuLoginPara.js");
    var ReCallFunc = null;
    var LoginWApi = /** @class */ (function () {
        function LoginWApi(strMethod, mapParam, pReCallFunc) {
            this.NameSpace = "http://tempuri.org/";
            this.MethodName = "";
            this.WEB_SERVICE_URL = "";
            this.soapAction = "";
            this.Param = new tzDictionary_js_1.Dictionary();
            ReCallFunc = pReCallFunc;
            this.MethodName = strMethod;
            this.Param = mapParam;
            if (this.Param.length() === 0) {
                this.Param = new tzDictionary_js_1.Dictionary();
            }
        }
        ;
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name = "objLoginPara">登录登录</param>
        /// <returns>是否存在?存在返回True</returns>
        LoginWApi.UserLoginAsync = function (objLoginPara) {
            //检测记录是否存在
            var strAction = "UserLogin";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = stuLoginPara_js_1.stuLoginPara.GetMapParam(objLoginPara);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objLoginPara,
                    success: function (data) {
                        resolve(data);
                    },
                    error: function (e) {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        };
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name = "objLoginPara">登录登录</param>
        /// <returns>是否存在?存在返回True</returns>
        LoginWApi.UserLogin2Async = function (objLoginPara) {
            //检测记录是否存在
            var strAction = "UserLogin2";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = stuLoginPara_js_1.stuLoginPara.GetMapParam(objLoginPara);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objLoginPara,
                    success: function (data) {
                        resolve(data);
                    },
                    error: function (e) {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        };
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name = "objLoginPara">登录登录</param>
        /// <returns>是否存在?存在返回True</returns>
        LoginWApi.UserLoginByPrjIdAsync = function (objLoginPara) {
            //检测记录是否存在
            var strAction = "UserLoginByPrjId";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = stuLoginPara_js_1.stuLoginPara.GetMapParam(objLoginPara);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objLoginPara,
                    success: function (data) {
                        resolve(data);
                    },
                    error: function (e) {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        };
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name = "objLoginPara">登录登录</param>
        /// <returns>是否存在?存在返回True</returns>
        LoginWApi.UserLoginWithEffectiveDateAsync = function (objLoginPara) {
            //检测记录是否存在
            var strAction = "UserLogin";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = stuLoginPara_js_1.stuLoginPara.GetMapParam(objLoginPara);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objLoginPara,
                    success: function (data) {
                        var bolIsSuccess = data;
                        if (bolIsSuccess == "false") {
                            return false;
                        }
                        else if (bolIsSuccess == "true") {
                            return true;
                        }
                        else if (bolIsSuccess == "EffectiveDateError") {
                            var strMsg = "";
                            strMsg = "\u7528\u6237\u767B\u5F55\uFF08UserLoginWithEffectiveDate\uFF09\u6709\u95EE\u9898,\u7531\u4E8E\u60A8(" + objLoginPara.LoginName + ")\u7684\u7528\u6237\u6709\u6548\u65E5\u671F\u51FA\u9519,\u8BF7\u8054\u7CFB\u7CFB\u7EDF\u7BA1\u7406\u5458\uFF01\u5F53\u524D\u65E5\u671F\uFF1A" + objLoginPara.EffectiveDate + ".";
                            throw (strMsg);
                        }
                        return Boolean(bolIsSuccess);
                        //resolve(data);
                    },
                    error: function (e) {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        };
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// mapParam样例:strUserId = "01"
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjByUserId", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
        /// </summary>
        /// <param name = "strUserId">关键字</param>
        /// <returns>获取相应对象</returns>
        LoginWApi.GetUserIdByLoginNameAsync = function (strLoginName) {
            var strAction = "GetUserIdByLoginName";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strLoginName", strLoginName);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "json",
                    data: strData,
                    success: function (data) {
                        resolve(data);
                    },
                    error: function (e) {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 获取WebApi的地址
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        LoginWApi.GetWebApiUrl = function (strController, strAction) {
            var strServiceUrl;
            if (clssyspara4webapi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
                strServiceUrl = "http://" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort + "/" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            else {
                strServiceUrl = "http://" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local + "/" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            return strServiceUrl;
        };
        LoginWApi.mstrController = "LoginApi";
        return LoginWApi;
    }());
    exports.LoginWApi = LoginWApi;
    ;
});
