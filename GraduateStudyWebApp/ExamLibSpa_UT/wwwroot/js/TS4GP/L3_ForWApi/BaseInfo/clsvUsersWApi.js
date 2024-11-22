/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvUsersWApi
表名:vUsers(01160035)
生成代码版本:2019.07.10.1
生成日期:2019/07/11 01:24:47
生成者:
生成服务器IP:101.251.68.133
工程名称:简单工程样例
工程ID:0116
相关数据库:101.251.68.133,9433AGC
PrjDataBaseId:0111
模块中文名:基本信息
模块英文名:BaseInfo
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
        define(["require", "exports", "jquery", "../../PubFun/tzDictionary.js", "../../PubFun/tzResponseData.js", "../../pubfun/clssyspara4webapi.js", "../../PubFun/stuTopPara.js", "../../PubFun/stuRangePara.js", "../../PubFun/stuPagerPara.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvUsersWApi = void 0;
    /// <summary>
    /// vUsers(vUsers)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2019年07月11日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    var $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    var tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    var tzResponseData_js_1 = require("../../PubFun/tzResponseData.js");
    var clssyspara4webapi_js_1 = require("../../pubfun/clssyspara4webapi.js");
    var stuTopPara_js_1 = require("../../PubFun/stuTopPara.js");
    var stuRangePara_js_1 = require("../../PubFun/stuRangePara.js");
    var stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
    var ResponseData;
    var ReCallFunc = null;
    var clsvUsersWApi = /** @class */ (function () {
        function clsvUsersWApi(strMethod, mapParam, pobjvUsersEN, pReCallFunc) {
            this.NameSpace = "http://tempuri.org/";
            this.MethodName = "";
            this.WEB_SERVICE_URL = "";
            this.soapAction = "";
            this.objvUsersEN = new clsvUsersEN();
            this.Param = new tzDictionary_js_1.Dictionary();
            this.objvUsersEN = pobjvUsersEN;
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetJSONObjByUserId", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
        /// </summary>
        /// <param name = "strUserId">关键字</param>
        /// <returns>获取相应对象</returns>
        clsvUsersWApi.GetObjByUserIdAsync = function (strUserId) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetJSONObjByUserId", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId)
        /// </summary>
        /// <param name = "strUserId">关键字</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取相应对象</returns>
        clsvUsersWApi.GetObjByUserId = function (strUserId, cb, errorCb) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetFirstID", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        clsvUsersWApi.GetFirstIDAsync = function (strWhereCond) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetFirstID", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        clsvUsersWApi.GetFirstID = function (strWhereCond, cb, errorCb) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetFirstObj", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象</returns>
        clsvUsersWApi.GetFirstObjAsync = function (strWhereCond) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetFirstObj", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObj)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取的相应对象</returns>
        clsvUsersWApi.GetFirstObj = function (strWhereCond, cb, errorCb) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetJSONObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象列表</returns>
        clsvUsersWApi.GetObjLstAsync = function (strWhereCond) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetJSONObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象列表</returns>
        clsvUsersWApi.GetObjLstByUserIdLstAsync = function (arrUserId) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetJSONObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取的相应对象列表</returns>
        clsvUsersWApi.GetObjLst = function (strWhereCond, cb, errorCb) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetTopObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
        /// </summary>
        /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
        /// <returns>获取的相应对象列表</returns>
        clsvUsersWApi.GetTopObjLstAsync = function (objTopPara) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetTopObjLst", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "intTopSize">顶部记录数</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取的相应对象列表</returns>
        clsvUsersWApi.GetTopObjLst = function (strWhereCond, intTopSize, cb, errorCb) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetJSONObjLstByPager", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
        /// </summary>
        /// <param name = "intMinNum">最小记录号</param>
        /// <param name = "intMaxNum">最大记录号</param>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsvUsersWApi.GetObjLstByRangeAsync = function (objRangePara) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetJSONObjLstByPager", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
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
        clsvUsersWApi.GetObjLstByRange = function (intMinNum, intMaxNum, strWhereCond, strOrderBy, cb, errorCb) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetJSONObjLstByPager", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
        ///调用样例:行3:mThread.start();
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
        /// </summary>
        /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsvUsersWApi.GetObjLstByPagerAsync = function (objPagerPara) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetJSONObjLstByPager", values, null);
        ///调用样例:行2:Thread mThread = new Thread(objvUsersWS);
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
        clsvUsersWApi.GetObjLstByPager = function (intPageIndex, intPageSize, strWhereCond, strOrderBy, cb, errorCb) {
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
        /// 根据条件获取是否存在相应的记录？
        /// mapParam样例: mapParam.put("strWhereCond", "UserId = '01'");
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "IsExistRecord", values, null);
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>是否存在记录？</returns>
        clsvUsersWApi.IsExistRecordAsync = function (strWhereCond) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "IsExistRecord", values, null);
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>是否存在记录？</returns>
        clsvUsersWApi.IsExistRecord = function (strWhereCond, cb, errorCb) {
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
        clsvUsersWApi.IsExistAsync = function (strUserId) {
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
        clsvUsersWApi.IsExist = function (strUserId, cb, errorCb) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetRecCountByCond", values, null);
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funGetRecCountByCondAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取某一条件的记录数</returns>
        clsvUsersWApi.GetRecCountByCondAsync = function (strWhereCond) {
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
        ///调用样例:行1:clsvUsersWS objvUsersWS = new clsvUsersWS(mHandler, "GetRecCountByCond", values, null);
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funGetRecCountByCond)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
        /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
        /// <returns>获取某一条件的记录数</returns>
        clsvUsersWApi.GetRecCountByCond = function (strWhereCond, cb, errorCb) {
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
        /// 获取WebApi的地址
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        clsvUsersWApi.GetWebApiUrl = function (strController, strAction) {
            var strServiceUrl;
            if (clssyspara4webapi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
                strServiceUrl = "http://" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort + "/" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            else {
                strServiceUrl = "http://" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local + "/" + clssyspara4webapi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            return strServiceUrl;
        };
        clsvUsersWApi.mstrController = "vUsersApi";
        return clsvUsersWApi;
    }());
    exports.clsvUsersWApi = clsvUsersWApi;
    ;
});
