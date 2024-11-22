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
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "jquery", "../../L0_Entity/UserManage/clsQxUsersEN.js", "../../L2_BLL/UserManage/clsQxUsersBL.js", "../../PubFun/tzDictionary.js", "../../PubFun/tzResponseData.js", "../../pubfun/clssyspara4webapi.js", "../../PubFun/stuTopPara.js", "../../PubFun/stuRangePara.js", "../../PubFun/stuPagerPara.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsQxUsersWApi = void 0;
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
    var clsQxUsersEN_js_1 = require("../../L0_Entity/UserManage/clsQxUsersEN.js");
    var clsQxUsersBL_js_1 = require("../../L2_BLL/UserManage/clsQxUsersBL.js");
    var tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    var tzResponseData_js_1 = require("../../PubFun/tzResponseData.js");
    var clssyspara4webapi_js_1 = require("../../pubfun/clssyspara4webapi.js");
    var stuTopPara_js_1 = require("../../PubFun/stuTopPara.js");
    var stuRangePara_js_1 = require("../../PubFun/stuRangePara.js");
    var stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
    var ResponseData;
    var ReCallFunc = null;
    var clsQxUsersWApi = /** @class */ (function () {
        function clsQxUsersWApi(strMethod, mapParam, pobjQxUsersEN, pReCallFunc) {
            this.NameSpace = "http://tempuri.org/";
            this.MethodName = "";
            this.WEB_SERVICE_URL = "";
            this.soapAction = "";
            this.objQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            this.Param = new tzDictionary_js_1.Dictionary();
            this.objQxUsersEN = pobjQxUsersEN;
            ReCallFunc = pReCallFunc;
            ResponseData = new tzResponseData_js_1.tzResponseData();
            this.MethodName = strMethod;
            this.Param = mapParam;
            if (this.Param.length() === 0) {
                this.Param = new tzDictionary_js_1.Dictionary();
            }
        }
        ;
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
        clsQxUsersWApi.GetObjByUserIdAsync = function (strUserId) {
            var strAction = "GetObjByUserId";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("UserId", strUserId);
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
        /// 根据关键字获取相应的记录的对象
        /// mapParam样例:strUserId = "01"
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjByUserId", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId)
        /// </summary>
        /// <param name = "strUserId">关键字</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取相应对象</returns>
        clsQxUsersWApi.GetObjByUserId = function (strUserId, cb, errorCb) {
            var strAction = "GetObjByUserId";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("UserId", strUserId);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetFirstID", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        clsQxUsersWApi.GetFirstIDAsync = function (strWhereCond) {
            var strAction = "GetFirstID";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
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
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetFirstID", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        clsQxUsersWApi.GetFirstID = function (strWhereCond, cb, errorCb) {
            var strAction = "GetFirstID";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetFirstObj", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象</returns>
        clsQxUsersWApi.GetFirstObjAsync = function (strWhereCond) {
            var strAction = "GetFirstObj";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
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
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetFirstObj", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObj)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取的相应对象</returns>
        clsQxUsersWApi.GetFirstObj = function (strWhereCond, cb, errorCb) {
            var strAction = "GetFirstObj";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象列表</returns>
        clsQxUsersWApi.GetObjLstAsync = function (strWhereCond) {
            var strAction = "GetObjLst";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
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
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象列表</returns>
        clsQxUsersWApi.GetObjLstByUserIdLstAsync = function (arrUserId) {
            var strAction = "GetObjLstByUserIdLst";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: { "": arrUserId },
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
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取的相应对象列表</returns>
        clsQxUsersWApi.GetObjLst = function (strWhereCond, cb, errorCb) {
            var strAction = "GetObjLst";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetTopObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
        /// </summary>
        /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
        /// <returns>获取的相应对象列表</returns>
        clsQxUsersWApi.GetTopObjLstAsync = function (objTopPara) {
            var strAction = "GetTopObjLst";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = stuTopPara_js_1.stuTopPara.GetMapParam(objTopPara);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objTopPara,
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
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetTopObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "intTopSize">顶部记录数</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取的相应对象列表</returns>
        clsQxUsersWApi.GetTopObjLst = function (strWhereCond, intTopSize, cb, errorCb) {
            var strAction = "GetTopObjLst";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            mapParam.add("intTopSize", intTopSize);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjLstByPager", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
        /// </summary>
        /// <param name = "intMinNum">最小记录号</param>
        /// <param name = "intMaxNum">最大记录号</param>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsQxUsersWApi.GetObjLstByRangeAsync = function (objRangePara) {
            var strAction = "GetObjLstByRange";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = stuRangePara_js_1.stuRangePara.GetMapParam(objRangePara);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objRangePara,
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
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjLstByPager", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
        /// </summary>
        /// <param name = "intMinNum">最小记录号</param>
        /// <param name = "intMaxNum">最大记录号</param>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsQxUsersWApi.GetObjLstByRange = function (intMinNum, intMaxNum, strWhereCond, strOrderBy, cb, errorCb) {
            if (strOrderBy === void 0) { strOrderBy = ""; }
            var strAction = "GetObjLstByRange";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("intMinNum", intMinNum);
            mapParam.add("intMaxNum", intMaxNum);
            mapParam.add("strWhereCond", strWhereCond);
            mapParam.add("strOrderBy", strOrderBy);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjLstByPager", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
        /// </summary>
        /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsQxUsersWApi.GetObjLstByPagerAsync = function (objPagerPara) {
            var strAction = "GetObjLstByPager";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = stuPagerPara_js_1.stuPagerPara.GetMapParam(objPagerPara);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objPagerPara,
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
        /// 根据条件获取相应的记录对象列表
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjLstByPager", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager)
        /// </summary>
        /// <param name = "intPageIndex">页序号</param>
        /// <param name = "intPageSize">每页记录数</param>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsQxUsersWApi.GetObjLstByPager = function (intPageIndex, intPageSize, strWhereCond, strOrderBy, cb, errorCb) {
            if (strOrderBy === void 0) { strOrderBy = ""; }
            var strAction = "GetObjLstByPager";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("intPageIndex", intPageIndex);
            mapParam.add("intPageSize", intPageSize);
            mapParam.add("strWhereCond", strWhereCond);
            mapParam.add("strOrderBy", strOrderBy);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 调用WebApi来删除记录
        /// mapParam样例:strUserId = "01"
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "DelRecord", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
        /// </summary>
        /// <param name = "strUserId">关键字</param>
        /// <returns>获取删除的结果</returns>
        clsQxUsersWApi.DelRecordAsync = function (strUserId) {
            var strAction = "DelRecord";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            strUrl = strUrl + "/" + strUserId;
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strUserId", strUserId);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "DELETE",
                    dataType: "json",
                    data: { "": strUserId },
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
        /// 调用WebApi来删除记录
        /// mapParam样例:strUserId = "01"
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "DelRecord", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecord)
        /// </summary>
        /// <param name = "strUserId">关键字</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取删除的结果</returns>
        clsQxUsersWApi.DelRecord = function (strUserId, cb, errorCb) {
            var strAction = "DelRecord";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            $.ajax({
                url: strUrl,
                method: "DELETE",
                dataType: "json",
                data: { "": strUserId },
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 根据关键字列表删除记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
        /// </summary>
        /// <param name = "arrUserId">关键字列表</param>
        /// <returns>实际删除记录的个数</returns>
        clsQxUsersWApi.DelQxUserssAsync = function (arrUserId) {
            var strAction = "DelQxUserss";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: { "": arrUserId },
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
        /// 根据关键字列表删除记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecord)
        /// </summary>
        /// <param name = "arrUserId">关键字列表</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>实际删除记录的个数</returns>
        clsQxUsersWApi.DelQxUserss = function (arrUserId, cb, errorCb) {
            var strAction = "DelQxUserss";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: { "": arrUserId },
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        /// <summary>
        /// 根据条件删除记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
        /// </summary>
        /// <returns>实际删除记录的个数</returns>
        clsQxUsersWApi.DelQxUserssByCondAsync = function (strWhereCond) {
            var strAction = "DelQxUserssByCond";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: { "": strWhereCond },
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
        /// 根据条件删除记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCond)
        /// </summary>
        /// <returns>实际删除记录的个数</returns>
        clsQxUsersWApi.DelQxUserssByCond = function (strWhereCond, cb, errorCb) {
            var strAction = "DelQxUserssByCond";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: { "": strWhereCond },
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        /// <summary>
        /// 调用WebApi来添加记录，数据传递使用JSON串
        /// mapParam样例:无
        ///调用样例:行1:clsQxUsersWA objQxUsersWA = new clsQxUsersWS(mHandler, "AddNewRecord", values, objQxUsersEN);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
        /// </summary>
        /// <param name = "objQxUsersEN">需要添加的对象</param>
        /// <returns>获取相应的记录的对象</returns>
        clsQxUsersWApi.AddNewRecordAsync = function (objQxUsersEN) {
            var strMsg = "";
            var strAction = "AddNewRecord";
            if (objQxUsersEN.UserId === null || objQxUsersEN.UserId === "") {
                strMsg = "需要的对象的关键字为空，不能添加!";
                throw strMsg;
            }
            var objQxUsersEN_Sim = clsQxUsersBL_js_1.clsQxUsersBL.GetSimObjFromObj(objQxUsersEN);
            //var strJSON = JSON.stringify(objQxUsersEN_Sim);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objQxUsersEN_Sim,
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
        /// 调用WebApi来添加记录，数据传递使用JSON串
        /// mapParam样例:无
        ///调用样例:行1:clsQxUsersWA objQxUsersWA = new clsQxUsersWS(mHandler, "AddNewRecord", values, objQxUsersEN);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecord)
        /// </summary>
        /// <param name = "objQxUsersEN">需要添加的对象</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取相应的记录的对象</returns>
        clsQxUsersWApi.AddNewRecord = function (objQxUsersEN, cb, errorCb) {
            var strMsg = "";
            var strAction = "AddNewRecord";
            if (objQxUsersEN.UserId === null || objQxUsersEN.UserId === "") {
                strMsg = "需要的对象的关键字为空，不能添加!";
                throw strMsg;
            }
            var objQxUsersEN_Sim = clsQxUsersBL_js_1.clsQxUsersBL.GetSimObjFromObj(objQxUsersEN);
            //var strJSON = JSON.stringify(objQxUsersEN);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objQxUsersEN_Sim,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
        /// </summary>
        /// <param name = "objQxUsersEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        clsQxUsersWApi.AddNewRecordWithReturnKeyAsync = function (objQxUsersEN) {
            var strAction = "AddNewRecordWithReturnKey";
            if (objQxUsersEN.UserId === null || objQxUsersEN.UserId === "") {
                var strMsg = "需要的对象的关键字为空，不能添加!";
                throw new Error(strMsg);
            }
            var objQxUsersEN_Sim = clsQxUsersBL_js_1.clsQxUsersBL.GetSimObjFromObj(objQxUsersEN);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objQxUsersEN_Sim,
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
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
        /// </summary>
        /// <param name = "objQxUsersEN">需要添加的表对象</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>返回新添加记录的关键字</returns>
        clsQxUsersWApi.AddNewRecordWithReturnKey = function (objQxUsersEN, cb, errorCb) {
            var strAction = "AddNewRecordWithReturnKey";
            if (objQxUsersEN.UserId === null || objQxUsersEN.UserId === "") {
                var strMsg = "需要的对象的关键字为空，不能添加!";
                throw new Error(strMsg);
            }
            var objQxUsersEN_Sim = clsQxUsersBL_js_1.clsQxUsersBL.GetSimObjFromObj(objQxUsersEN);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objQxUsersEN_Sim,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        /// <summary>
        /// 调用WebApi来修改记录，数据传递使用JSON串
        /// mapParam样例:无
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "UpdateRecord", values, objQxUsersEN);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
        /// </summary>
        /// <param name = "objQxUsersEN">需要添加的对象</param>
        /// <returns>获取修改是否成功？</returns>
        clsQxUsersWApi.UpdateRecordAsync = function (objQxUsersEN) {
            var strMsg = "";
            var strAction = "UpdateRecord";
            if (objQxUsersEN.sf_UpdFldSetStr === null || objQxUsersEN.sf_UpdFldSetStr === "") {
                strMsg = "\u5BF9\u8C61(\u5173\u952E\u5B57: " + objQxUsersEN.UserId + ")\u7684\u3010\u4FEE\u6539\u5B57\u6BB5\u96C6\u3011\u4E3A\u7A7A\uFF0C\u4E0D\u80FD\u4FEE\u6539!";
                throw strMsg;
            }
            var objQxUsersEN_Sim = clsQxUsersBL_js_1.clsQxUsersBL.GetSimObjFromObj(objQxUsersEN);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "PUT",
                    dataType: "json",
                    data: objQxUsersEN_Sim,
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
        /// 调用WebApi来修改记录，数据传递使用JSON串
        /// mapParam样例:无
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "UpdateRecord", values, objQxUsersEN);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecord)
        /// </summary>
        /// <param name = "objQxUsersEN">需要添加的对象</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取修改是否成功？</returns>
        clsQxUsersWApi.UpdateRecord = function (objQxUsersEN, cb, errorCb) {
            var strMsg = "";
            var strAction = "UpdateRecord";
            if (objQxUsersEN.sf_UpdFldSetStr === null || objQxUsersEN.sf_UpdFldSetStr === "") {
                strMsg = "\u5BF9\u8C61(\u5173\u952E\u5B57: " + objQxUsersEN.UserId + ")\u7684\u3010\u4FEE\u6539\u5B57\u6BB5\u96C6\u3011\u4E3A\u7A7A\uFF0C\u4E0D\u80FD\u4FEE\u6539!";
                throw strMsg;
            }
            var objQxUsersEN_Sim = clsQxUsersBL_js_1.clsQxUsersBL.GetSimObjFromObj(objQxUsersEN);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            $.ajax({
                url: strUrl,
                method: "PUT",
                dataType: "json",
                data: objQxUsersEN_Sim,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 根据条件来修改记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordWithConditionAsync)
        /// </summary>
        /// <param name = "objQxUsersEN">需要修改的对象</param>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        clsQxUsersWApi.UpdateRecordWithConditionAsync = function (objQxUsersEN, strWhereCond) {
            var strAction = "UpdateRecordWithCondition";
            if (objQxUsersEN.sf_UpdFldSetStr === null || objQxUsersEN.sf_UpdFldSetStr === "") {
                var strMsg = "\u5BF9\u8C61(\u5173\u952E\u5B57: " + objQxUsersEN.UserId + ")\u7684\u3010\u4FEE\u6539\u5B57\u6BB5\u96C6\u3011\u4E3A\u7A7A\uFF0C\u4E0D\u80FD\u4FEE\u6539!";
                throw new Error(strMsg);
            }
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "PUT",
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
        /// <summary>
        /// 根据条件来修改记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordWithCondition)
        /// </summary>
        /// <param name = "objQxUsersEN">需要修改的对象</param>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        clsQxUsersWApi.UpdateRecordWithCondition = function (objQxUsersEN, strWhereCond, cb, errorCb) {
            var strAction = "UpdateRecordWithCondition";
            if (objQxUsersEN.sf_UpdFldSetStr === null || objQxUsersEN.sf_UpdFldSetStr === "") {
                var strMsg = "\u5BF9\u8C61(\u5173\u952E\u5B57: " + objQxUsersEN.UserId + ")\u7684\u3010\u4FEE\u6539\u5B57\u6BB5\u96C6\u3011\u4E3A\u7A7A\uFF0C\u4E0D\u80FD\u4FEE\u6539!";
                throw new Error(strMsg);
            }
            var objQxUsersEN_Sim = clsQxUsersBL_js_1.clsQxUsersBL.GetSimObjFromObj(objQxUsersEN);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            $.ajax({
                url: strUrl,
                method: "PUT",
                dataType: "json",
                data: {
                    objQxUsersEN: objQxUsersEN_Sim,
                    strWhereCond: strWhereCond
                },
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        /// <summary>
        /// 根据条件获取是否存在相应的记录？
        /// mapParam样例: mapParam.put("strWhereCond", "UserId = '01'");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "IsExistRecord", values, null);
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>是否存在记录？</returns>
        clsQxUsersWApi.IsExistRecordAsync = function (strWhereCond) {
            var strAction = "IsExistRecord";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
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
        /// 根据条件获取是否存在相应的记录？
        /// mapParam样例: mapParam.put("strWhereCond", "UserId = '01'");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "IsExistRecord", values, null);
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>是否存在记录？</returns>
        clsQxUsersWApi.IsExistRecord = function (strWhereCond, cb, errorCb) {
            var strAction = "IsExistRecord";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 根据关键字判断是否存在记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
        /// </summary>
        /// <param name = "strUserId">关键字</param>
        /// <returns>是否存在?存在返回True</returns>
        clsQxUsersWApi.IsExistAsync = function (strUserId) {
            //检测记录是否存在
            var strAction = "IsExist";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("UserId", strUserId);
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
        /// <summary>
        /// 根据关键字判断是否存在记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
        /// </summary>
        /// <param name = "strUserId">关键字</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>是否存在?存在返回True</returns>
        clsQxUsersWApi.IsExist = function (strUserId, cb, errorCb) {
            //检测记录是否存在
            var strAction = "IsExist";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("UserId", strUserId);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        /// <summary>
        /// 获取某一条件的记录数
        /// mapParam样例: mapParam.put("strWhereCond", "UserId = '01'");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetRecCountByCond", values, null);
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funGetRecCountByCondAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取某一条件的记录数</returns>
        clsQxUsersWApi.GetRecCountByCondAsync = function (strWhereCond) {
            var strAction = "GetRecCountByCond";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
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
        /// 获取某一条件的记录数
        /// mapParam样例: mapParam.put("strWhereCond", "UserId = '01'");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetRecCountByCond", values, null);
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funGetRecCountByCond)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取某一条件的记录数</returns>
        clsQxUsersWApi.GetRecCountByCond = function (strWhereCond, cb, errorCb) {
            var strAction = "GetRecCountByCond";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 获取表的最大关键字
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetMaxStrId", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
        /// </summary>
        /// <returns>获取表的最大关键字</returns>
        clsQxUsersWApi.GetMaxStrIdAsync = function () {
            var strAction = "GetMaxStrId";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "json",
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
        /// 获取表的最大关键字
        /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
        ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetMaxStrId", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrId)
        /// </summary>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取表的最大关键字</returns>
        clsQxUsersWApi.GetMaxStrId = function (cb, errorCb) {
            var strAction = "GetMaxStrId";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefixAsync)
        /// </summary>
        /// <param name = "mapParam">参数列表</param>
        /// <returns>获取当前表关键字值的最大值</returns>
        clsQxUsersWApi.GetMaxStrIdByPrefixAsync = function (strPrefix) {
            var strAction = "GetMaxStrIdByPrefix";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strPrefix", strPrefix);
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
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
        /// </summary>
        /// <param name = "mapParam">参数列表</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取当前表关键字值的最大值</returns>
        clsQxUsersWApi.GetMaxStrIdByPrefix = function (strPrefix, cb, errorCb) {
            var strAction = "GetMaxStrIdByPrefix";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strPrefix", strPrefix);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    cb(data);
                },
                error: function (e) {
                    var strErrMsg = decodeURIComponent(e.responseText);
                    errorCb(strErrMsg);
                }
            });
        };
        ;
        /// <summary>
        /// 获取WebApi的地址
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        clsQxUsersWApi.GetWebApiUrl = function (strController, strAction) {
            var strServiceUrl;
            if (clssyspara4webapi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
                strServiceUrl = "http://" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort + "/" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            else {
                strServiceUrl = "http://" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local + "/" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            return strServiceUrl;
        };
        clsQxUsersWApi.mstrController = "QxUsersApi";
        return clsQxUsersWApi;
    }());
    exports.clsQxUsersWApi = clsQxUsersWApi;
    ;
});
