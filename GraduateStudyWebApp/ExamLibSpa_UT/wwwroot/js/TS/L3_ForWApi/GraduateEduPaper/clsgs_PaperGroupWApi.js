/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_PaperGroupWApi
表名:gs_PaperGroup(01120749)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 18:28:55
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
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
        define(["require", "exports", "jquery", "../../PubFun/clsCommonFunc4Web.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js", "../../PubFun/tzDictionary.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/stuTopPara.js", "../../PubFun/stuRangePara.js", "../../PubFun/stuPagerPara.js", "../../PubFun/clsStackTrace.js", "../../PubFun/CacheHelper.js", "../../PubFun/tzPubFun.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    /// <summary>
    /// 论文分组(gs_PaperGroup)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by pyf2 on 2020年09月28日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    var $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    var clsCommonFunc4Web_js_1 = require("../../PubFun/clsCommonFunc4Web.js");
    var clsgs_PaperGroupEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js");
    var tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    var clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    var stuTopPara_js_1 = require("../../PubFun/stuTopPara.js");
    var stuRangePara_js_1 = require("../../PubFun/stuRangePara.js");
    var stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
    var clsStackTrace_js_1 = require("../../PubFun/clsStackTrace.js");
    var CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
    var jsString_js_1 = require("../../PubFun/jsString.js");
    var clsString_js_1 = require("../../PubFun/clsString.js");
    var ResponseData;
    var clsgs_PaperGroupWApi = /** @class */ (function () {
        function clsgs_PaperGroupWApi(pobjgs_PaperGroupEN) {
            this.objgs_PaperGroupEN = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
            this.objgs_PaperGroupEN = pobjgs_PaperGroupEN;
        }
        ;
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
        /// </summary>
        /// <param name = "strPaperGroupId">关键字</param>
        /// <returns>对象</returns>
        clsgs_PaperGroupWApi.GetObjByPaperGroupIdAsync = function (strPaperGroupId) {
            var strAction = "GetObjByPaperGroupId";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("PaperGroupId", strPaperGroupId);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "json",
                    data: strData,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            var returnObj = JSON.parse(data.ReturnObj);
                            //console.log(returnObj);
                            resolve(returnObj);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存中获取.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
        /// </summary>
        /// <param name = "strPaperGroupId">所给的关键字</param>
        /// <returns>对象</returns>
        clsgs_PaperGroupWApi.GetObjByPaperGroupId_Cache = function (strPaperGroupId) {
            return __awaiter(this, void 0, void 0, function () {
                var arrgs_PaperGroupObjLst_Cache, obj, arrgs_PaperGroup_Sel, objgs_PaperGroup, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0: return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 1:
                            arrgs_PaperGroupObjLst_Cache = _a.sent();
                            obj = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            try {
                                arrgs_PaperGroup_Sel = arrgs_PaperGroupObjLst_Cache.filter(function (x) { return x.PaperGroupId == strPaperGroupId; });
                                if (arrgs_PaperGroup_Sel.length > 0) {
                                    objgs_PaperGroup = arrgs_PaperGroup_Sel[0];
                                    return [2 /*return*/, objgs_PaperGroup];
                                }
                                else {
                                    return [2 /*return*/, obj];
                                }
                            }
                            catch (e) {
                                strMsg = "\u9519\u8BEF:[" + e + "]. \n\u6839\u636E\u5173\u952E\u5B57:[" + strPaperGroupId + "]\u83B7\u53D6\u76F8\u5E94\u7684\u5BF9\u8C61\u4E0D\u6210\u529F!";
                                alert(strMsg);
                            }
                            return [2 /*return*/, obj];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存中获取.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
        /// </summary>
        /// <param name = "strPaperGroupId">所给的关键字</param>
        /// <returns>对象</returns>
        clsgs_PaperGroupWApi.GetObjByPaperGroupId_localStorage = function (strPaperGroupId) {
            return __awaiter(this, void 0, void 0, function () {
                var strKey, strTempObj, objgs_PaperGroup_Cache, objgs_PaperGroup, strInfo, e_1, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            if (clsString_js_1.clsString.IsNullOrEmpty(strPaperGroupId) == true)
                                return [2 /*return*/, null];
                            strKey = clsString_js_1.clsString.Format("{0}_{1}", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName, strPaperGroupId);
                            if (strKey == "") {
                                console.log("关键字为空！不正确");
                                throw new Error("关键字为空！不正确");
                            }
                            if (localStorage.hasOwnProperty(strKey)) {
                                strTempObj = localStorage.getItem(strKey);
                                objgs_PaperGroup_Cache = JSON.parse(strTempObj);
                                return [2 /*return*/, objgs_PaperGroup_Cache];
                            }
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjByPaperGroupIdAsync(strPaperGroupId)];
                        case 2:
                            objgs_PaperGroup = _a.sent();
                            if (objgs_PaperGroup != null) {
                                localStorage.setItem(strKey, JSON.stringify(objgs_PaperGroup));
                                strInfo = "Key:[" + strKey + "]\u7684\u7F13\u5B58\u5DF2\u7ECF\u5EFA\u7ACB!";
                                console.log(strInfo);
                                return [2 /*return*/, objgs_PaperGroup];
                            }
                            return [2 /*return*/, objgs_PaperGroup];
                        case 3:
                            e_1 = _a.sent();
                            strMsg = "\u9519\u8BEF:[" + e_1 + "]. \n\u6839\u636E\u5173\u952E\u5B57:[" + strPaperGroupId + "]\u83B7\u53D6\u76F8\u5E94\u7684\u5BF9\u8C61\u4E0D\u6210\u529F!";
                            alert(strMsg);
                            return [2 /*return*/];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存中获取.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
        /// </summary>
        /// <param name = "strPaperGroupId">所给的关键字</param>
        /// <returns>对象</returns>
        clsgs_PaperGroupWApi.UpdateObjInLst_Cache = function (objgs_PaperGroup) {
            return __awaiter(this, void 0, void 0, function () {
                var arrgs_PaperGroupObjLst_Cache, obj, e_2, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            _a.trys.push([0, 2, , 3]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 1:
                            arrgs_PaperGroupObjLst_Cache = _a.sent();
                            obj = arrgs_PaperGroupObjLst_Cache.find(function (x) { return x.PaperGroupName == objgs_PaperGroup.PaperGroupName && x.UpdUser == objgs_PaperGroup.UpdUser; });
                            if (obj != null) {
                                objgs_PaperGroup.PaperGroupId = obj.PaperGroupId;
                                clsgs_PaperGroupBL.CopyObjTo(objgs_PaperGroup, obj);
                            }
                            else {
                                arrgs_PaperGroupObjLst_Cache.push(objgs_PaperGroup);
                            }
                            return [3 /*break*/, 3];
                        case 2:
                            e_2 = _a.sent();
                            strMsg = "\u9519\u8BEF:[" + e_2 + "]. \n\u5728\u5217\u8868\u4E2D\u4FEE\u6539\u5BF9\u8C61\u4E0D\u6210\u529F!";
                            alert(strMsg);
                            return [3 /*break*/, 3];
                        case 3:
                            ;
                            return [2 /*return*/];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字获取相关对象的名称属性, 从缓存中获取.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
        /// </summary>
        /// <param name = "strPaperGroupId">所给的关键字</param>
        /// <returns>对象</returns>
        clsgs_PaperGroupWApi.GetNameByPaperGroupId_Cache = function (strPaperGroupId) {
            return __awaiter(this, void 0, void 0, function () {
                var arrgs_PaperGroupObjLst_Cache, obj, arrgs_PaperGroup_Sel, objgs_PaperGroup, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0: return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 1:
                            arrgs_PaperGroupObjLst_Cache = _a.sent();
                            obj = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            try {
                                arrgs_PaperGroup_Sel = arrgs_PaperGroupObjLst_Cache.filter(function (x) { return x.PaperGroupId == strPaperGroupId; });
                                if (arrgs_PaperGroup_Sel.length > 0) {
                                    objgs_PaperGroup = arrgs_PaperGroup_Sel[0];
                                    return [2 /*return*/, objgs_PaperGroup.PaperGroupName];
                                }
                                else {
                                    return [2 /*return*/, ""];
                                }
                            }
                            catch (e) {
                                strMsg = "\u9519\u8BEF:[" + e + "]. \n\u6839\u636E\u5173\u952E\u5B57:[" + strPaperGroupId + "]\u83B7\u53D6\u76F8\u5E94\u7684\u5BF9\u8C61\u540D\u79F0\u5C5E\u6027\u4E0D\u6210\u529F!";
                                alert(strMsg);
                            }
                            return [2 /*return*/, obj];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 映射函数。根据表映射把输入字段值，映射成输出字段值
        /// 作者:pyf2
        /// 日期:20200928182855
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
        /// </summary>
        /// <param name = "strInFldName">输入字段名</param>
        /// <param name = "strOutFldName">输出字段名</param>
        /// <param name = "strInValue">输入字段值</param>
        /// <returns>返回一个输出字段值</returns>
        clsgs_PaperGroupWApi.func = function (strInFldName, strOutFldName, strInValue) {
            return __awaiter(this, void 0, void 0, function () {
                var strMsg, strMsg, objgs_PaperGroup;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            if (strInFldName != clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupId) {
                                strMsg = clsString_js_1.clsString.Format("输入字段名:[{0}]不正确!", strInFldName);
                                throw new Error(strMsg);
                            }
                            if (clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.AttributeName.indexOf(strOutFldName) == -1) {
                                strMsg = clsString_js_1.clsString.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.AttributeName.join(','));
                                throw new Error(strMsg);
                            }
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjByPaperGroupId_Cache(strInValue)];
                        case 1:
                            objgs_PaperGroup = _a.sent();
                            if (objgs_PaperGroup == null)
                                return [2 /*return*/, ""];
                            return [2 /*return*/, objgs_PaperGroup[strOutFldName].toString()];
                    }
                });
            });
        };
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存中获取.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SetCache)
        /// </summary>
        /// <param name = "strPaperGroupId">所给的关键字</param>
        /// <returns>对象</returns>
        clsgs_PaperGroupWApi.SetCache = function () {
        };
        ;
        /// <summary>
        /// 根据关键字获取相应的对象
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_WA_CacheAsync)
        /// </summary>
        /// <param name = "strPaperGroupId">关键字</param>
        /// <returns>对象</returns>
        clsgs_PaperGroupWApi.GetObjByPaperGroupId_WA_CacheAsync = function (strPaperGroupId) {
            var strAction = "GetObjByPaperGroupId_Cache";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("PaperGroupId", strPaperGroupId);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "json",
                    data: strData,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            var returnObj = JSON.parse(data.ReturnObj);
                            //console.log(returnObj);
                            resolve(returnObj);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        clsgs_PaperGroupWApi.GetFirstIDAsync = function (strWhereCond) {
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
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnStr);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象</returns>
        clsgs_PaperGroupWApi.GetFirstObjAsync = function (strWhereCond) {
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
                        if (data.ErrorId == 0) {
                            var returnObj = JSON.parse(data.ReturnObj);
                            //console.log(returnObj);
                            resolve(returnObj);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
        /// </summary>
        /// <returns>从本地缓存中获取的对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLst_ClientCache = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strWhereCond, strKey, arrgs_PaperGroupObjLst_Cache, responseText, arrgs_PaperGroupObjLst, strInfo, e_3, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            strWhereCond = "1=1";
                            clsgs_PaperGroupWApi.InitListCache();
                            strKey = clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName;
                            if (strKey == "") {
                                console.log("关键字为空！不正确");
                                throw new Error("关键字为空！不正确");
                            }
                            if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
                                arrgs_PaperGroupObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
                                return [2 /*return*/, arrgs_PaperGroupObjLst_Cache];
                            }
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLstAsync(strWhereCond)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_PaperGroupObjLst);
                            strInfo = "Key:[" + strKey + "]\u7684\u7F13\u5B58\u5DF2\u7ECF\u5EFA\u7ACB\uFF0C\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            console.log(strInfo);
                            return [2 /*return*/, arrgs_PaperGroupObjLst];
                        case 3:
                            e_3 = _a.sent();
                            console.log("GetObjLst_Cache:e");
                            console.error(e_3);
                            strMsg = "\u4ECE\u672C\u5730\u7F13\u5B58\u4E2D\u83B7\u53D6\u6240\u6709\u5BF9\u8C61\u5217\u8868\u51FA\u9519. \n\u670D\u52A1\u5668\u9519\u8BEF\uFF1A" + e_3 + ".";
                            throw (strMsg);
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
        /// </summary>
        /// <returns>从本地缓存中获取的对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLst_localStorage = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strWhereCond, strKey, strTempObjLst, arrgs_PaperGroupObjLst_Cache, responseText, arrgs_PaperGroupObjLst, strInfo, e_4, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            strWhereCond = "1=1";
                            clsgs_PaperGroupWApi.InitListCache();
                            strKey = clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName;
                            if (strKey == "") {
                                console.log("关键字为空！不正确");
                                throw new Error("关键字为空！不正确");
                            }
                            if (localStorage.hasOwnProperty(strKey)) {
                                strTempObjLst = localStorage.getItem(strKey);
                                arrgs_PaperGroupObjLst_Cache = JSON.parse(strTempObjLst);
                                return [2 /*return*/, arrgs_PaperGroupObjLst_Cache];
                            }
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLstAsync(strWhereCond)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            localStorage.setItem(strKey, JSON.stringify(arrgs_PaperGroupObjLst));
                            strInfo = "Key:[" + strKey + "]\u7684\u7F13\u5B58\u5DF2\u7ECF\u5EFA\u7ACB\uFF0C\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            console.log(strInfo);
                            return [2 /*return*/, arrgs_PaperGroupObjLst];
                        case 3:
                            e_4 = _a.sent();
                            console.log("GetObjLst_Cache:e");
                            console.error(e_4);
                            strMsg = "\u4ECE\u672C\u5730\u7F13\u5B58\u4E2D\u83B7\u53D6\u6240\u6709\u5BF9\u8C61\u5217\u8868\u51FA\u9519. \n\u670D\u52A1\u5668\u9519\u8BEF\uFF1A" + e_4 + ".";
                            throw (strMsg);
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLstAsync = function (strWhereCond) {
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
                        if (data.ErrorId == 0) {
                            var returnObjLst = JSON.parse(data.ReturnObjLst);
                            //console.log(returnObjLst);
                            resolve(returnObjLst);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
        /// </summary>
        /// <returns>从本地缓存中获取的对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLst_sessionStorage = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strWhereCond, strKey, strTempObjLst, arrgs_PaperGroupObjLst_Cache, responseText, arrgs_PaperGroupObjLst, strInfo, e_5, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            strWhereCond = "1=1";
                            clsgs_PaperGroupWApi.InitListCache();
                            strKey = clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName;
                            if (strKey == "") {
                                console.log("关键字为空！不正确");
                                throw new Error("关键字为空！不正确");
                            }
                            if (sessionStorage.hasOwnProperty(strKey)) {
                                strTempObjLst = sessionStorage.getItem(strKey);
                                arrgs_PaperGroupObjLst_Cache = JSON.parse(strTempObjLst);
                                return [2 /*return*/, arrgs_PaperGroupObjLst_Cache];
                            }
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLstAsync(strWhereCond)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperGroupObjLst));
                            strInfo = "Key:[" + strKey + "]\u7684\u7F13\u5B58\u5DF2\u7ECF\u5EFA\u7ACB\uFF0C\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            console.log(strInfo);
                            return [2 /*return*/, arrgs_PaperGroupObjLst];
                        case 3:
                            e_5 = _a.sent();
                            console.log("GetObjLst_Cache:e");
                            console.error(e_5);
                            strMsg = "\u4ECE\u7F13\u5B58\u4E2D\u83B7\u53D6\u6240\u6709\u5BF9\u8C61\u5217\u8868\u51FA\u9519. \n\u670D\u52A1\u5668\u9519\u8BEF\uFF1A" + e_5 + ".";
                            throw (strMsg);
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
        /// </summary>
        /// <returns>从本地缓存中获取的对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLst_Cache = function () {
            return __awaiter(this, void 0, void 0, function () {
                var arrgs_PaperGroupObjLst_Cache, _a;
                return __generator(this, function (_b) {
                    switch (_b.label) {
                        case 0:
                            _a = clsgs_PaperGroupWApi.CacheModeId;
                            switch (_a) {
                                case "04": return [3 /*break*/, 1];
                                case "03": return [3 /*break*/, 3];
                                case "02": return [3 /*break*/, 5];
                            }
                            return [3 /*break*/, 7];
                        case 1: return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_sessionStorage()];
                        case 2:
                            arrgs_PaperGroupObjLst_Cache = _b.sent();
                            return [3 /*break*/, 9];
                        case 3: return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_localStorage()];
                        case 4:
                            arrgs_PaperGroupObjLst_Cache = _b.sent();
                            return [3 /*break*/, 9];
                        case 5: return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_ClientCache()];
                        case 6:
                            arrgs_PaperGroupObjLst_Cache = _b.sent();
                            return [3 /*break*/, 9];
                        case 7: return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_ClientCache()];
                        case 8:
                            arrgs_PaperGroupObjLst_Cache = _b.sent();
                            return [3 /*break*/, 9];
                        case 9: return [2 /*return*/, arrgs_PaperGroupObjLst_Cache];
                    }
                });
            });
        };
        /// <summary>
        /// 获取服务器缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_WA_CacheAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取的相应对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLst_WA_CacheAsync = function () {
            var strAction = "GetObjLst_Cache";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "json",
                    data: strData,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            var returnObjLst = JSON.parse(data.ReturnObjLst);
                            //console.log(returnObjLst);
                            resolve(returnObjLst);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件对象, 从缓存的对象列表中获取子集.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
        /// </summary>
        /// <param name = "objstrPaperGroupId_Cond">条件对象</param>
        /// <returns>对象列表子集</returns>
        clsgs_PaperGroupWApi.GetSubObjLst_Cache = function (objgs_PaperGroup_Cond) {
            return __awaiter(this, void 0, void 0, function () {
                var objgs_PaperGroup_Sim, arrgs_PaperGroupObjLst_Cache, arrgs_PaperGroup_Sel, dicFldComparisonOp, sstrKeys, _loop_1, strComparisonOp, strValue, strType, _i, sstrKeys_1, strKey, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            objgs_PaperGroup_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 1:
                            arrgs_PaperGroupObjLst_Cache = _a.sent();
                            arrgs_PaperGroup_Sel = arrgs_PaperGroupObjLst_Cache.filter(function (x) { return true; });
                            if (objgs_PaperGroup_Sim.sf_FldComparisonOp == null || objgs_PaperGroup_Sim.sf_FldComparisonOp == "")
                                return [2 /*return*/, arrgs_PaperGroup_Sel];
                            dicFldComparisonOp = JSON.parse(objgs_PaperGroup_Sim.sf_FldComparisonOp);
                            console.log("clsgs_PaperGroupWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
                            console.log(dicFldComparisonOp);
                            try {
                                sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objgs_PaperGroup_Sim);
                                console.log(sstrKeys);
                                _loop_1 = function (strKey) {
                                    if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                                        return "continue";
                                    arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] != null; });
                                    strComparisonOp = dicFldComparisonOp[strKey];
                                    strValue = objgs_PaperGroup_Sim[strKey];
                                    strType = typeof (strValue);
                                    switch (strType) {
                                        case "string":
                                            if (strValue == null)
                                                return "continue";
                                            if (strValue == "")
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey].toString() == strValue.toString(); });
                                            }
                                            else if (strComparisonOp == "like") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey].toString().indexOf(strValue) != -1; });
                                            }
                                            break;
                                        case "boolean":
                                            if (strValue == null)
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] == strValue; });
                                            }
                                            break;
                                        case "number":
                                            if (strValue == 0)
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] == strValue; });
                                            }
                                            else if (strComparisonOp == ">=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] >= strValue; });
                                            }
                                            else if (strComparisonOp == "<=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] <= strValue; });
                                            }
                                            else if (strComparisonOp == ">") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] > strValue; });
                                            }
                                            else if (strComparisonOp == "<") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] <= strValue; });
                                            }
                                            break;
                                    }
                                };
                                for (_i = 0, sstrKeys_1 = sstrKeys; _i < sstrKeys_1.length; _i++) {
                                    strKey = sstrKeys_1[_i];
                                    _loop_1(strKey);
                                }
                                return [2 /*return*/, arrgs_PaperGroup_Sel];
                            }
                            catch (e) {
                                strMsg = "\u9519\u8BEF:[" + e + "]. \n\u6839\u636E\u6761\u4EF6:[" + JSON.stringify(objgs_PaperGroup_Sim) + "]\u7F13\u5B58\u5BF9\u8C61\u5217\u8868\u4E2D\u83B7\u53D6\u5B50\u96C6\u5BF9\u8C61\u4E0D\u6210\u529F!";
                                throw new Error(strMsg);
                            }
                            return [2 /*return*/, new Array()];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_WA_CacheAsync)
        /// </summary>
        /// <param name = "objgs_PaperGroup_Cond">条件对象</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsgs_PaperGroupWApi.GetSubObjLst_WA_CacheAsync = function (objgs_PaperGroup_Cond) {
            var strAction = "GetSubObjLst_Cache";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objgs_PaperGroupEN_Sim,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            var returnObjLst = JSON.parse(data.ReturnObjLst);
                            //console.log(returnObjLst);
                            resolve(returnObjLst);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字列表获取相关对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
        /// </summary>
        /// <param name = "arrPaperGroupId">关键字列表</param>
        /// <returns>对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLstByPaperGroupIdLstAsync = function (arrPaperGroupId) {
            var strAction = "GetObjLstByPaperGroupIdLst";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: { "": arrPaperGroupId },
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            var returnObjLst = JSON.parse(data.ReturnObjLst);
                            //console.log(returnObjLst);
                            resolve(returnObjLst);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字列表获取相关对象列表, 从缓存中获取.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
        /// </summary>
        /// <param name = "arrstrPaperGroupIdLst">关键字列表</param>
        /// <returns>对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLstByPaperGroupIdLst_Cache = function (arrPaperGroupIdLst) {
            return __awaiter(this, void 0, void 0, function () {
                var arrgs_PaperGroupObjLst_Cache, arrgs_PaperGroup_Sel, e_6, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            _a.trys.push([0, 2, , 3]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 1:
                            arrgs_PaperGroupObjLst_Cache = _a.sent();
                            arrgs_PaperGroup_Sel = arrgs_PaperGroupObjLst_Cache.filter(function (x) { return arrPaperGroupIdLst.indexOf(x.PaperGroupId) > -1; });
                            return [2 /*return*/, arrgs_PaperGroup_Sel];
                        case 2:
                            e_6 = _a.sent();
                            strMsg = "\u9519\u8BEF:[" + e_6 + "]. \n\u6839\u636E\u5173\u952E\u5B57:[" + arrPaperGroupIdLst.join(",") + "]\u83B7\u53D6\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F!";
                            throw new Error(strMsg);
                        case 3: return [2 /*return*/, new Array()];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_WA_CacheAsync)
        /// </summary>
        /// <param name = "arrPaperGroupId">关键字列表</param>
        /// <returns>对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLstByPaperGroupIdLst_WA_CacheAsync = function (arrPaperGroupId) {
            var strAction = "GetObjLstByPaperGroupIdLst_Cache";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: { "": arrPaperGroupId },
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            var returnObjLst = JSON.parse(data.ReturnObjLst);
                            //console.log(returnObjLst);
                            resolve(returnObjLst);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
        /// </summary>
        /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
        /// <returns>获取的相应对象列表</returns>
        clsgs_PaperGroupWApi.GetTopObjLstAsync = function (objTopPara) {
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
                        if (data.ErrorId == 0) {
                            var returnObjLst = JSON.parse(data.ReturnObjLst);
                            //console.log(returnObjLst);
                            resolve(returnObjLst);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
        /// </summary>
        /// <param name = "objRangePara">根据范围获取对象列表的参数对象</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLstByRangeAsync = function (objRangePara) {
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
                        if (data.ErrorId == 0) {
                            var returnObjLst = JSON.parse(data.ReturnObjLst);
                            //console.log(returnObjLst);
                            resolve(returnObjLst);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        /// <summary>
        /// 从缓存中获取分页对象列表.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
        /// </summary>
        /// <param name = "objPagerPara">分页参数结构</param>
        /// <returns>对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLstByPager_Cache = function (objPagerPara) {
            return __awaiter(this, void 0, void 0, function () {
                var arrgs_PaperGroupObjLst_Cache, arrgs_PaperGroup_Sel, obj_Cond, dicFldComparisonOp, sstrKeys, _loop_2, strComparisonOp, strValue, strType, _i, sstrKeys_2, strKey, intStart, intEnd, sstrSplit, strSortType, strSortFld, objFirst, strSortValue, strSortFldType, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0: return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 1:
                            arrgs_PaperGroupObjLst_Cache = _a.sent();
                            if (arrgs_PaperGroupObjLst_Cache.length == 0)
                                return [2 /*return*/, arrgs_PaperGroupObjLst_Cache];
                            arrgs_PaperGroup_Sel = arrgs_PaperGroupObjLst_Cache.filter(function (x) { return true; });
                            obj_Cond = JSON.parse(objPagerPara.WhereCond);
                            dicFldComparisonOp = {};
                            if (obj_Cond.sf_FldComparisonOp != "") {
                                dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
                            }
                            console.log("clsgs_PaperGroupWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
                            console.log(dicFldComparisonOp);
                            try {
                                sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(obj_Cond);
                                console.log(sstrKeys);
                                _loop_2 = function (strKey) {
                                    if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                                        return "continue";
                                    arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] != null; });
                                    strComparisonOp = dicFldComparisonOp[strKey];
                                    strValue = obj_Cond[strKey];
                                    strType = typeof (strValue);
                                    switch (strType) {
                                        case "string":
                                            if (strValue == null)
                                                return "continue";
                                            if (strValue == "")
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey].toString() == strValue.toString(); });
                                            }
                                            else if (strComparisonOp == "like") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey].toString().indexOf(strValue) != -1; });
                                            }
                                            break;
                                        case "boolean":
                                            if (strValue == null)
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] == strValue; });
                                            }
                                            break;
                                        case "number":
                                            if (strValue == 0)
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] == strValue; });
                                            }
                                            else if (strComparisonOp == ">=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] >= strValue; });
                                            }
                                            else if (strComparisonOp == "<=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] <= strValue; });
                                            }
                                            else if (strComparisonOp == ">") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] > strValue; });
                                            }
                                            else if (strComparisonOp == "<") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] <= strValue; });
                                            }
                                            break;
                                    }
                                };
                                for (_i = 0, sstrKeys_2 = sstrKeys; _i < sstrKeys_2.length; _i++) {
                                    strKey = sstrKeys_2[_i];
                                    _loop_2(strKey);
                                }
                                if (arrgs_PaperGroup_Sel.length == 0)
                                    return [2 /*return*/, arrgs_PaperGroup_Sel];
                                intStart = objPagerPara.PageSize * (objPagerPara.PageIndex - 1);
                                if (intStart <= 0)
                                    intStart = 0;
                                intEnd = intStart + objPagerPara.PageSize;
                                if (objPagerPara.OrderBy != null && objPagerPara.OrderBy.length > 0) {
                                    sstrSplit = objPagerPara.OrderBy.split(" ");
                                    strSortType = "asc";
                                    strSortFld = sstrSplit[0];
                                    if (sstrSplit.length > 1)
                                        strSortType = sstrSplit[1];
                                    objFirst = arrgs_PaperGroup_Sel[0];
                                    strSortValue = objFirst[strSortFld];
                                    strSortFldType = typeof (strSortValue);
                                    //console.log("排序字段的数据类型: " + strSortFldType);
                                    switch (strSortFldType) {
                                        case "string":
                                            if (strSortType.toLowerCase() == "asc") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort(function (x, y) { return x[strSortFld].localeCompare(y[strSortFld]); });
                                            }
                                            else {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort(function (x, y) { return y[strSortFld].localeCompare(x[strSortFld]); });
                                            }
                                            break;
                                        case "number":
                                        case "boolean":
                                            if (strSortType.toLowerCase() == "asc") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort(function (x, y) { return x[strSortFld] - y[strSortFld]; });
                                            }
                                            else {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort(function (x, y) { return y[strSortFld] - x[strSortFld]; });
                                            }
                                            break;
                                    }
                                }
                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.slice(intStart, intEnd);
                                return [2 /*return*/, arrgs_PaperGroup_Sel];
                            }
                            catch (e) {
                                strMsg = "\u9519\u8BEF:[" + e + "]. \n\u6839\u636E\u6761\u4EF6:[" + objPagerPara.WhereCond + "]\u83B7\u53D6\u5206\u9875\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F!(In clsgs_PaperGroupWApi.GetObjLstByPager_Cache)";
                                throw new Error(strMsg);
                            }
                            return [2 /*return*/, new Array()];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_WA_CacheAsync)
        /// </summary>
        /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLstByPager_WA_CacheAsync = function (objPagerPara) {
            var strAction = "GetObjLstByPager_Cache";
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
                        if (data.ErrorId == 0) {
                            var returnObjLst = JSON.parse(data.ReturnObjLst);
                            //console.log(returnObjLst);
                            resolve(returnObjLst);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
        /// </summary>
        /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
        /// <returns>获取的相应记录对象列表</returns>
        clsgs_PaperGroupWApi.GetObjLstByPagerAsync = function (objPagerPara) {
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
                        if (data.ErrorId == 0) {
                            var returnObjLst = JSON.parse(data.ReturnObjLst);
                            //console.log(returnObjLst);
                            resolve(returnObjLst);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 调用WebApi来删除记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
        /// </summary>
        /// <param name = "strPaperGroupId">关键字</param>
        /// <returns>获取删除的结果</returns>
        clsgs_PaperGroupWApi.DelRecordAsync = function (strPaperGroupId) {
            var strAction = "DelRecord";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            strUrl = strUrl + "/" + strPaperGroupId;
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strPaperGroupId", strPaperGroupId);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "DELETE",
                    dataType: "json",
                    data: { "": strPaperGroupId },
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnInt);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字列表删除记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
        /// </summary>
        /// <param name = "arrPaperGroupId">关键字列表</param>
        /// <returns>实际删除记录的个数</returns>
        clsgs_PaperGroupWApi.Delgs_PaperGroupsAsync = function (arrPaperGroupId) {
            var strAction = "Delgs_PaperGroups";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: { "": arrPaperGroupId },
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnInt);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件删除记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
        /// </summary>
        /// <returns>实际删除记录的个数</returns>
        clsgs_PaperGroupWApi.Delgs_PaperGroupsByCondAsync = function (strWhereCond) {
            var strAction = "Delgs_PaperGroupsByCond";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: { "": strWhereCond },
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnInt);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        /// <summary>
        /// 调用WebApi来添加记录，数据传递使用JSON串
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
        /// </summary>
        /// <param name = "objgs_PaperGroupEN">需要添加的对象</param>
        /// <returns>获取相应的记录的对象</returns>
        clsgs_PaperGroupWApi.AddNewRecordAsync = function (objgs_PaperGroupEN) {
            var strMsg = "";
            var strAction = "AddNewRecord";
            var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroupEN);
            //var strJSON = JSON.stringify(objgs_PaperGroupEN_Sim);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objgs_PaperGroupEN_Sim,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnBool);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 调用WebApi来添加记录，数据传递使用JSON串
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
        /// </summary>
        /// <param name = "objgs_PaperGroupEN">需要添加的对象</param>
        /// <returns>获取相应的记录的对象</returns>
        clsgs_PaperGroupWApi.AddNewRecordWithMaxIdAsync = function (objgs_PaperGroupEN) {
            var strMsg = "";
            var strAction = "AddNewRecordWithMaxId";
            var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroupEN);
            //var strJSON = JSON.stringify(objgs_PaperGroupEN_Sim);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objgs_PaperGroupEN_Sim,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnStr);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
        /// </summary>
        /// <param name = "objgs_PaperGroupEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        clsgs_PaperGroupWApi.AddNewRecordWithReturnKeyAsync = function (objgs_PaperGroupEN) {
            var strAction = "AddNewRecordWithReturnKey";
            var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroupEN);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objgs_PaperGroupEN_Sim,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnStr);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        /// <summary>
        /// 调用WebApi来修改记录，数据传递使用JSON串
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
        /// </summary>
        /// <param name = "objgs_PaperGroupEN">需要添加的对象</param>
        /// <returns>获取修改是否成功？</returns>
        clsgs_PaperGroupWApi.UpdateRecordAsync = function (objgs_PaperGroupEN) {
            var strMsg = "";
            var strAction = "UpdateRecord";
            if (objgs_PaperGroupEN.sf_UpdFldSetStr === null || objgs_PaperGroupEN.sf_UpdFldSetStr === "") {
                strMsg = "\u5BF9\u8C61(\u5173\u952E\u5B57: " + objgs_PaperGroupEN.PaperGroupId + ")\u7684\u3010\u4FEE\u6539\u5B57\u6BB5\u96C6\u3011\u4E3A\u7A7A\uFF0C\u4E0D\u80FD\u4FEE\u6539!";
                throw strMsg;
            }
            var objgs_PaperGroupEN_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroupEN);
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: objgs_PaperGroupEN_Sim,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnBool);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件来修改记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
        /// </summary>
        /// <param name = "objgs_PaperGroupEN">需要修改的对象</param>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        clsgs_PaperGroupWApi.UpdateWithConditionAsync = function (objgs_PaperGroupEN, strWhereCond) {
            var strAction = "UpdateWithCondition";
            if (objgs_PaperGroupEN.sf_UpdFldSetStr === null || objgs_PaperGroupEN.sf_UpdFldSetStr === "") {
                var strMsg = "\u5BF9\u8C61(\u5173\u952E\u5B57: " + objgs_PaperGroupEN.PaperGroupId + ")\u7684\u3010\u4FEE\u6539\u5B57\u6BB5\u96C6\u3011\u4E3A\u7A7A\uFF0C\u4E0D\u80FD\u4FEE\u6539!";
                throw new Error(strMsg);
            }
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "POST",
                    dataType: "json",
                    data: strData,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnBool);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件对象, 从缓存的对象列表中获取子集.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
        /// </summary>
        /// <param name = "objstrPaperGroupId_Cond">条件对象</param>
        /// <returns>对象列表子集</returns>
        clsgs_PaperGroupWApi.IsExistRecord_Cache = function (objgs_PaperGroup_Cond) {
            return __awaiter(this, void 0, void 0, function () {
                var objgs_PaperGroup_Sim, arrgs_PaperGroupObjLst_Cache, arrgs_PaperGroup_Sel, dicFldComparisonOp, sstrKeys, _loop_3, strComparisonOp, strValue, strType, _i, sstrKeys_3, strKey, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            objgs_PaperGroup_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 1:
                            arrgs_PaperGroupObjLst_Cache = _a.sent();
                            arrgs_PaperGroup_Sel = arrgs_PaperGroupObjLst_Cache.filter(function (x) { return true; });
                            if (objgs_PaperGroup_Sim.sf_FldComparisonOp == null || objgs_PaperGroup_Sim.sf_FldComparisonOp == "")
                                return [2 /*return*/, arrgs_PaperGroup_Sel.length > 0 ? true : false];
                            dicFldComparisonOp = JSON.parse(objgs_PaperGroup_Sim.sf_FldComparisonOp);
                            console.log("clsgs_PaperGroupWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
                            console.log(dicFldComparisonOp);
                            try {
                                sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objgs_PaperGroup_Sim);
                                console.log(sstrKeys);
                                _loop_3 = function (strKey) {
                                    if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                                        return "continue";
                                    strComparisonOp = dicFldComparisonOp[strKey];
                                    strValue = objgs_PaperGroup_Sim[strKey];
                                    strType = typeof (strValue);
                                    switch (strType) {
                                        case "string":
                                            if (strValue == null)
                                                return "continue";
                                            if (strValue == "")
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey].toString() == strValue.toString(); });
                                            }
                                            else if (strComparisonOp == "like") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey].toString().indexOf(strValue) != -1; });
                                            }
                                            break;
                                        case "boolean":
                                            if (strValue == null)
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] == strValue; });
                                            }
                                            break;
                                        case "number":
                                            if (strValue == 0)
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] == strValue; });
                                            }
                                            else if (strComparisonOp == ">=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] >= strValue; });
                                            }
                                            else if (strComparisonOp == "<=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] <= strValue; });
                                            }
                                            else if (strComparisonOp == ">") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] > strValue; });
                                            }
                                            else if (strComparisonOp == "<") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] <= strValue; });
                                            }
                                            break;
                                    }
                                };
                                for (_i = 0, sstrKeys_3 = sstrKeys; _i < sstrKeys_3.length; _i++) {
                                    strKey = sstrKeys_3[_i];
                                    _loop_3(strKey);
                                }
                                if (arrgs_PaperGroup_Sel.length > 0) {
                                    return [2 /*return*/, true];
                                }
                                else {
                                    return [2 /*return*/, false];
                                }
                            }
                            catch (e) {
                                strMsg = "\u6839\u636E\u6761\u4EF6:[" + JSON.stringify(objgs_PaperGroup_Sim) + "]\u5224\u65AD\u662F\u5426\u5B58\u5728\u4E0D\u6210\u529F!";
                                throw new Error(strMsg);
                            }
                            return [2 /*return*/, false];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件获取是否存在相应的记录？
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>是否存在记录？</returns>
        clsgs_PaperGroupWApi.IsExistRecordAsync = function (strWhereCond) {
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
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnBool);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字判断是否存在记录, 从本地缓存中判断.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
        /// </summary>
        /// <param name = "strPaperGroupId">所给的关键字</param>
        /// <returns>对象</returns>
        clsgs_PaperGroupWApi.IsExist_Cache = function (strPaperGroupId) {
            return __awaiter(this, void 0, void 0, function () {
                var arrgs_PaperGroupObjLst_Cache, obj, arrgs_PaperGroup_Sel, objgs_PaperGroup, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0: return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 1:
                            arrgs_PaperGroupObjLst_Cache = _a.sent();
                            obj = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            try {
                                arrgs_PaperGroup_Sel = arrgs_PaperGroupObjLst_Cache.filter(function (x) { return x.PaperGroupId == strPaperGroupId; });
                                if (arrgs_PaperGroup_Sel.length > 0) {
                                    return [2 /*return*/, true];
                                }
                                else {
                                    return [2 /*return*/, false];
                                }
                            }
                            catch (e) {
                                strMsg = "\u6839\u636E\u5173\u952E\u5B57:[" + strPaperGroupId + "]\u5224\u65AD\u662F\u5426\u5B58\u5728\u4E0D\u6210\u529F!";
                                alert(strMsg);
                            }
                            return [2 /*return*/, false];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据关键字判断是否存在记录
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
        /// </summary>
        /// <param name = "strPaperGroupId">关键字</param>
        /// <returns>是否存在?存在返回True</returns>
        clsgs_PaperGroupWApi.IsExistAsync = function (strPaperGroupId) {
            //检测记录是否存在
            var strAction = "IsExist";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("PaperGroupId", strPaperGroupId);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "json",
                    data: strData,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnBool);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        /// <summary>
        /// 获取某一条件的记录数
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>获取某一条件的记录数</returns>
        clsgs_PaperGroupWApi.GetRecCountByCondAsync = function (strWhereCond) {
            var strAction = "GetRecCountByCond";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", strWhereCond);
            var strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            console.log('GetRecCountByCondAsync:strData:');
            console.log(strData);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "json",
                    data: strData,
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnInt);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据条件对象, 从缓存的对象列表中获取记录数.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
        /// </summary>
        /// <param name = "objgs_PaperGroup_Cond">条件对象</param>
        /// <returns>对象列表记录数</returns>
        clsgs_PaperGroupWApi.GetRecCountByCond_Cache = function (objgs_PaperGroup_Cond) {
            return __awaiter(this, void 0, void 0, function () {
                var objgs_PaperGroup_Sim, arrgs_PaperGroupObjLst_Cache, arrgs_PaperGroup_Sel, dicFldComparisonOp, sstrKeys, _loop_4, strComparisonOp, strValue, strType, _i, sstrKeys_4, strKey, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            objgs_PaperGroup_Sim = clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 1:
                            arrgs_PaperGroupObjLst_Cache = _a.sent();
                            arrgs_PaperGroup_Sel = arrgs_PaperGroupObjLst_Cache.filter(function (x) { return true; });
                            if (objgs_PaperGroup_Sim.sf_FldComparisonOp == null || objgs_PaperGroup_Sim.sf_FldComparisonOp == "")
                                return [2 /*return*/, arrgs_PaperGroup_Sel.length];
                            dicFldComparisonOp = JSON.parse(objgs_PaperGroup_Sim.sf_FldComparisonOp);
                            console.log("clsgs_PaperGroupWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
                            console.log(dicFldComparisonOp);
                            try {
                                sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objgs_PaperGroup_Sim);
                                console.log(sstrKeys);
                                _loop_4 = function (strKey) {
                                    if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                                        return "continue";
                                    arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] != null; });
                                    strComparisonOp = dicFldComparisonOp[strKey];
                                    strValue = objgs_PaperGroup_Sim[strKey];
                                    strType = typeof (strValue);
                                    switch (strType) {
                                        case "string":
                                            if (strValue == null)
                                                return "continue";
                                            if (strValue == "")
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey].toString() == strValue.toString(); });
                                            }
                                            else if (strComparisonOp == "like") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey].toString().indexOf(strValue) != -1; });
                                            }
                                            break;
                                        case "boolean":
                                            if (strValue == null)
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] == strValue; });
                                            }
                                            break;
                                        case "number":
                                            if (strValue == 0)
                                                return "continue";
                                            if (strComparisonOp == "=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] == strValue; });
                                            }
                                            else if (strComparisonOp == ">=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] >= strValue; });
                                            }
                                            else if (strComparisonOp == "<=") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] <= strValue; });
                                            }
                                            else if (strComparisonOp == ">") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] > strValue; });
                                            }
                                            else if (strComparisonOp == "<") {
                                                arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(function (x) { return x[strKey] <= strValue; });
                                            }
                                            break;
                                    }
                                };
                                for (_i = 0, sstrKeys_4 = sstrKeys; _i < sstrKeys_4.length; _i++) {
                                    strKey = sstrKeys_4[_i];
                                    _loop_4(strKey);
                                }
                                return [2 /*return*/, arrgs_PaperGroup_Sel.length];
                            }
                            catch (e) {
                                strMsg = "\u9519\u8BEF:[" + e + "]. \n\u6839\u636E\u6761\u4EF6:[" + JSON.stringify(objgs_PaperGroup_Sim) + "]\u4ECE\u7F13\u5B58\u5BF9\u8C61\u5217\u8868\u4E2D\u83B7\u53D6\u8BB0\u5F55\u6570\u4E0D\u6210\u529F!";
                                throw new Error(strMsg);
                            }
                            return [2 /*return*/, 0];
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 获取表的最大关键字
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
        /// </summary>
        /// <returns>获取表的最大关键字</returns>
        clsgs_PaperGroupWApi.GetMaxStrIdAsync = function () {
            var strAction = "GetMaxStrId";
            var strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "json",
                    success: function (data) {
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnStr);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        };
        ;
        /// <summary>
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefixAsync)
        /// </summary>
        /// <param name = "mapParam">参数列表</param>
        /// <returns>获取当前表关键字值的最大值</returns>
        clsgs_PaperGroupWApi.GetMaxStrIdByPrefixAsync = function (strPrefix) {
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
                        if (data.ErrorId == 0) {
                            resolve(data.ReturnStr);
                        }
                        else {
                            console.log(data.ErrorMsg);
                            reject(data.ErrorMsg);
                        }
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "\u7F51\u7EDC\u9519\u8BEF\uFF01\u8BBF\u95EE\u5730\u5740:" + strUrl + "\u4E0D\u6210\u529F\uFF01";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
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
        clsgs_PaperGroupWApi.GetWebApiUrl = function (strController, strAction) {
            var strServiceUrl;
            if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
                strServiceUrl = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort + "/" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            else {
                strServiceUrl = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local + "/" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            return strServiceUrl;
        };
        /// <summary>
        /// 为下拉框获取数据,从表:[gs_PaperGroup]中获取
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DdlBind_Cache)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        clsgs_PaperGroupWApi.prototype.BindDdl_PaperGroupId_Cache2 = function (strDdlName, objgs_PaperGroup_Cond) {
            return __awaiter(this, void 0, void 0, function () {
                var objDdl, strMsg, arrObjLst_Sel, e_7, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            objDdl = document.getElementById(strDdlName);
                            if (objDdl == null) {
                                strMsg = "\u4E0B\u62C9\u6846\uFF1A" + strDdlName + " \u4E0D\u5B58\u5728\uFF01";
                                alert(strMsg);
                                throw (strMsg);
                            }
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi.GetSubObjLst_Cache(objgs_PaperGroup_Cond)];
                        case 2:
                            arrObjLst_Sel = _a.sent();
                            clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupId, clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName, "论文分组");
                            console.log("完成BindDdl_PaperGroupId!");
                            return [3 /*break*/, 4];
                        case 3:
                            e_7 = _a.sent();
                            strMsg = "\u4F7F\u7528\u7F13\u5B58\u5BF9\u8C61\u5217\u8868\u7ED1\u5B9A\u4E0B\u62C9\u6846\u51FA\u9519," + e_7 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_InitListCache)
        /// </summary>
        clsgs_PaperGroupWApi.InitListCache = function () {
        };
        /// <summary>
        /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
        /// </summary>
        clsgs_PaperGroupWApi.ReFreshCache = function () {
            var strMsg = "\u5237\u65B0\u7F13\u5B58\u6210\u529F\uFF01(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction() + ")";
            console.log(strMsg);
            // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
            var strKey = clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName;
            switch (clsgs_PaperGroupWApi.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
            }
        };
        /// <summary>
        /// 刷新本类中的缓存.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
        /// </summary>
        clsgs_PaperGroupWApi.ReFreshThisCache = function () {
            var strMsg = "";
            if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
                var strKey = clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName;
                switch (clsgs_PaperGroupWApi.CacheModeId) {
                    case "04": //sessionStorage
                        sessionStorage.removeItem(strKey);
                        break;
                    case "03": //localStorage
                        localStorage.removeItem(strKey);
                        break;
                    case "02": //ClientCache
                        CacheHelper_js_1.CacheHelper.Remove(strKey);
                        break;
                    default:
                        CacheHelper_js_1.CacheHelper.Remove(strKey);
                        break;
                }
                strMsg = "\u5237\u65B0\u7F13\u5B58\u6210\u529F\uFF01(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction() + ")",
                    console.log(strMsg);
            }
            else {
                strMsg = "\u5237\u65B0\u7F13\u5B58\u5DF2\u7ECF\u5173\u95ED\u3002(clsSysPara4WebApi.spSetRefreshCacheOn == false)(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction() + ")";
                console.log(strMsg);
            }
        };
        clsgs_PaperGroupWApi.mstrController = "gs_PaperGroupApi";
        clsgs_PaperGroupWApi.CacheModeId = ""; //
        return clsgs_PaperGroupWApi;
    }());
    exports.clsgs_PaperGroupWApi = clsgs_PaperGroupWApi;
    ;
    var clsgs_PaperGroupBL = /** @class */ (function () {
        function clsgs_PaperGroupBL() {
            /// <summary>
            /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
            /// </summary>
            this.arrgs_PaperGroupObjLst_Cache = new Array();
            /// <summary>
            /// 从缓存中查找失败的次数
            /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
            /// </summary>
            this.intFindFailCount = 0;
        }
        /// <summary>
        /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
        /// </summary>
        clsgs_PaperGroupBL.prototype.CheckPropertyNew = function (pobjgs_PaperGroupEN) {
            //检查字段非空， 即数据表要求非常非空的字段，不能为空！
            if (null === pobjgs_PaperGroupEN.UpdUser
                || null !== pobjgs_PaperGroupEN.UpdUser && pobjgs_PaperGroupEN.UpdUser.toString() === "") {
                throw new Error("(errid:Watl000058)字段[论文分组|修改人]不能为空(NULL)!(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
            if (null !== pobjgs_PaperGroupEN.PaperGroupId && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.PaperGroupId) > 8) {
                throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|组Id(PaperGroupId)]的长度不能超过8!值:$(pobjgs_PaperGroupEN.PaperGroupId)(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            if (null !== pobjgs_PaperGroupEN.PaperGroupName && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.PaperGroupName) > 50) {
                throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|组名(PaperGroupName)]的长度不能超过50!值:$(pobjgs_PaperGroupEN.PaperGroupName)(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            if (null !== pobjgs_PaperGroupEN.UpdUser && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.UpdUser) > 50) {
                throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|修改人(UpdUser)]的长度不能超过50!值:$(pobjgs_PaperGroupEN.UpdUser)(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            if (null !== pobjgs_PaperGroupEN.UpdDate && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.UpdDate) > 20) {
                throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjgs_PaperGroupEN.UpdDate)(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            if (null !== pobjgs_PaperGroupEN.Meno && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.Meno) > 2000) {
                throw new Error("(errid:Watl000059)字段[论文分组(gs_PaperGroup)|备注(Meno)]的长度不能超过2000!值:$(pobjgs_PaperGroupEN.Meno)(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            //检查字段的数据类型是否正确
            if (null !== pobjgs_PaperGroupEN.PaperGroupId && undefined !== pobjgs_PaperGroupEN.PaperGroupId && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.PaperGroupId) === false) {
                throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|组Id(PaperGroupId)]的值:[$(pobjgs_PaperGroupEN.PaperGroupId)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            if (null !== pobjgs_PaperGroupEN.PaperGroupName && undefined !== pobjgs_PaperGroupEN.PaperGroupName && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.PaperGroupName) === false) {
                throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|组名(PaperGroupName)]的值:[$(pobjgs_PaperGroupEN.PaperGroupName)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            if (null !== pobjgs_PaperGroupEN.UpdUser && undefined !== pobjgs_PaperGroupEN.UpdUser && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.UpdUser) === false) {
                throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|修改人(UpdUser)]的值:[$(pobjgs_PaperGroupEN.UpdUser)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            if (null !== pobjgs_PaperGroupEN.UpdDate && undefined !== pobjgs_PaperGroupEN.UpdDate && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.UpdDate) === false) {
                throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|修改日期(UpdDate)]的值:[$(pobjgs_PaperGroupEN.UpdDate)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            if (null !== pobjgs_PaperGroupEN.Meno && undefined !== pobjgs_PaperGroupEN.Meno && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.Meno) === false) {
                throw new Error("(errid:Watl000060)字段[论文分组(gs_PaperGroup)|备注(Meno)]的值:[$(pobjgs_PaperGroupEN.Meno)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckPropertyNew)");
            }
            //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
            //设置说明该对象已经检查过了，后面不需要再检查，即非法！
            pobjgs_PaperGroupEN._IsCheckProperty = true;
        };
        ;
        /// <summary>
        /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
        /// </summary>
        clsgs_PaperGroupBL.prototype.CheckProperty4Update = function (pobjgs_PaperGroupEN) {
            //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
            if (null !== pobjgs_PaperGroupEN.PaperGroupId && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.PaperGroupId) > 8) {
                throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|组Id(PaperGroupId)]的长度不能超过8!值:$(pobjgs_PaperGroupEN.PaperGroupId)(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            if (null !== pobjgs_PaperGroupEN.PaperGroupName && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.PaperGroupName) > 50) {
                throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|组名(PaperGroupName)]的长度不能超过50!值:$(pobjgs_PaperGroupEN.PaperGroupName)(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            if (null !== pobjgs_PaperGroupEN.UpdUser && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.UpdUser) > 50) {
                throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|修改人(UpdUser)]的长度不能超过50!值:$(pobjgs_PaperGroupEN.UpdUser)(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            if (null !== pobjgs_PaperGroupEN.UpdDate && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.UpdDate) > 20) {
                throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjgs_PaperGroupEN.UpdDate)(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            if (null !== pobjgs_PaperGroupEN.Meno && tzPubFun_js_1.GetStrLen(pobjgs_PaperGroupEN.Meno) > 2000) {
                throw new Error("(errid:Watl000062)字段[论文分组(gs_PaperGroup)|备注(Meno)]的长度不能超过2000!值:$(pobjgs_PaperGroupEN.Meno)(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            //检查字段的数据类型是否正确
            if (null !== pobjgs_PaperGroupEN.PaperGroupId && undefined !== pobjgs_PaperGroupEN.PaperGroupId && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.PaperGroupId) === false) {
                throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|组Id(PaperGroupId)]的值:[$(pobjgs_PaperGroupEN.PaperGroupId)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            if (null !== pobjgs_PaperGroupEN.PaperGroupName && undefined !== pobjgs_PaperGroupEN.PaperGroupName && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.PaperGroupName) === false) {
                throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|组名(PaperGroupName)]的值:[$(pobjgs_PaperGroupEN.PaperGroupName)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            if (null !== pobjgs_PaperGroupEN.UpdUser && undefined !== pobjgs_PaperGroupEN.UpdUser && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.UpdUser) === false) {
                throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|修改人(UpdUser)]的值:[$(pobjgs_PaperGroupEN.UpdUser)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            if (null !== pobjgs_PaperGroupEN.UpdDate && undefined !== pobjgs_PaperGroupEN.UpdDate && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.UpdDate) === false) {
                throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|修改日期(UpdDate)]的值:[$(pobjgs_PaperGroupEN.UpdDate)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            if (null !== pobjgs_PaperGroupEN.Meno && undefined !== pobjgs_PaperGroupEN.Meno && jsString_js_1.tzDataType.isString(pobjgs_PaperGroupEN.Meno) === false) {
                throw new Error("(errid:Watl000063)字段[论文分组(gs_PaperGroup)|备注(Meno)]的值:[$(pobjgs_PaperGroupEN.Meno)], 非法，应该为字符型!(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            //检查主键是否为Null或者空！
            if (null === pobjgs_PaperGroupEN.PaperGroupId
                || null !== pobjgs_PaperGroupEN.PaperGroupId && pobjgs_PaperGroupEN.PaperGroupId.toString() === ""
                || null !== pobjgs_PaperGroupEN.PaperGroupId && pobjgs_PaperGroupEN.PaperGroupId.toString() === "0") {
                throw new Error("(errid:Watl000064)字段[论文分组|组Id]不能为空(NULL)!(clsgs_PaperGroupBL:CheckProperty4Update)");
            }
            //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
            pobjgs_PaperGroupEN._IsCheckProperty = true;
        };
        ;
        /// <summary>
        /// 把一个对象转化为一个JSON串
        /// 作者:pyf2
        /// 日期:20200928182855
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
        /// </summary>
        /// <param name = "strJSON">需要转化的JSON串</param>
        /// <returns>返回一个生成的对象</returns>
        clsgs_PaperGroupBL.GetJSONStrByObj = function (pobjgs_PaperGroupEN) {
            pobjgs_PaperGroupEN.sf_UpdFldSetStr = pobjgs_PaperGroupEN.UpdFldString;
            var strJson;
            var jsonData;
            try {
                strJson = JSON.stringify(pobjgs_PaperGroupEN);
            }
            catch (objException) {
                tzPubFun_js_1.myShowErrorMsg(objException.message);
            }
            return strJson;
        };
        ;
        /// <summary>
        /// 把一个JSON串转化为一个对象列表
        /// 作者:pyf2
        /// 日期:20200928182855
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
        /// </summary>
        /// <param name = "strJSON">需要转化的JSON串</param>
        /// <returns>返回一个生成的对象列表</returns>
        clsgs_PaperGroupBL.GetObjLstByJSONStr = function (strJSON) {
            var arrgs_PaperGroupObjLst = new Array();
            if (strJSON === "") {
                return arrgs_PaperGroupObjLst;
            }
            try {
                arrgs_PaperGroupObjLst = JSON.parse(strJSON);
            }
            catch (objException) {
                return arrgs_PaperGroupObjLst;
            }
            return arrgs_PaperGroupObjLst;
        };
        ;
        /// <summary>
        /// 把一个JSON串转化为一个对象
        /// 作者:pyf2
        /// 日期:20200928182855
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
        /// </summary>
        /// <param name = "strJSON">需要转化的JSON串</param>
        /// <returns>返回一个生成的对象</returns>
        clsgs_PaperGroupBL.GetObjByJSONStr = function (strJSON) {
            var pobjgs_PaperGroupEN = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
            if (strJSON === "") {
                return pobjgs_PaperGroupEN;
            }
            try {
                pobjgs_PaperGroupEN = JSON.parse(strJSON);
            }
            catch (objException) {
                return pobjgs_PaperGroupEN;
            }
            return pobjgs_PaperGroupEN;
        };
        ;
        /// <summary>
        /// 把同一个类的对象,从简化对象复制到对象
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjFromSimObj)
        /// </summary>
        /// <param name = "objgs_PaperGroupENS">源简化对象</param>
        /// <param name = "objgs_PaperGroupENT">目标对象</param>
        clsgs_PaperGroupBL.CopyObjFromSimObj = function (objgs_PaperGroupENS, objgs_PaperGroupENT) {
            objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
            objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
            objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
            objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
            objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
        };
        /// <summary>
        /// 根据条件对象中的字段内容组合成一个条件串
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        clsgs_PaperGroupBL.GetCombineCondition = function (objgs_PaperGroup_Cond) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupId) == true) {
                var strComparisonOp_PaperGroupId = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupId];
                strWhereCond += clsString_js_1.clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupId, objgs_PaperGroup_Cond.PaperGroupId, strComparisonOp_PaperGroupId);
            }
            if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName) == true) {
                var strComparisonOp_PaperGroupName = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName];
                strWhereCond += clsString_js_1.clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName, objgs_PaperGroup_Cond.PaperGroupName, strComparisonOp_PaperGroupName);
            }
            if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser) == true) {
                var strComparisonOp_UpdUser = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser];
                strWhereCond += clsString_js_1.clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser, objgs_PaperGroup_Cond.UpdUser, strComparisonOp_UpdUser);
            }
            if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdDate) == true) {
                var strComparisonOp_UpdDate = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdDate];
                strWhereCond += clsString_js_1.clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdDate, objgs_PaperGroup_Cond.UpdDate, strComparisonOp_UpdDate);
            }
            if (objgs_PaperGroup_Cond.dicFldComparisonOp.hasOwnProperty(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_Meno) == true) {
                var strComparisonOp_Meno = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_Meno];
                strWhereCond += clsString_js_1.clsString.Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_Meno, objgs_PaperGroup_Cond.Meno, strComparisonOp_Meno);
            }
            return strWhereCond;
        };
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
        /// </summary>
        /// <param name = "objgs_PaperGroupENS">源对象</param>
        /// <param name = "objgs_PaperGroupENT">目标对象</param>
        clsgs_PaperGroupBL.CopyObjTo = function (objgs_PaperGroupENS, objgs_PaperGroupENT) {
            objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
            objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
            objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
            objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
            objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
            objgs_PaperGroupENT.sf_UpdFldSetStr = objgs_PaperGroupENS.UpdFldString; //sf_UpdFldSetStr
        };
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象(简单)
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjToSimObj)
        /// </summary>
        /// <param name = "objgs_PaperGroupENS">源对象</param>
        /// <param name = "objgs_PaperGroupENT">目标对象</param>
        clsgs_PaperGroupBL.CopyObjToSimObj = function (objgs_PaperGroupENS, objgs_PaperGroupENT) {
            objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
            objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
            objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
            objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
            objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
            objgs_PaperGroupENT.sf_UpdFldSetStr = objgs_PaperGroupENS.UpdFldString; //专门用于记录某字段属性是否修改
            objgs_PaperGroupENT.sf_FldComparisonOp = objgs_PaperGroupENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
        };
        /// <summary>
        /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
        /// </summary>
        /// <param name = "objgs_PaperGroupENS">源简化对象</param>
        /// <param name = "objgs_PaperGroupENT">目标对象</param>
        clsgs_PaperGroupBL.CopyObjFromSimObj4Upd = function (objgs_PaperGroupENS, objgs_PaperGroupENT) {
            var strsf_UpdFldSetStr = objgs_PaperGroupENS.sf_UpdFldSetStr;
            var sstrFldSet = strsf_UpdFldSetStr.split('|');
            if (sstrFldSet.indexOf(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupId) >= 0) {
                objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
            }
            if (sstrFldSet.indexOf(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName) >= 0) {
                objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
            }
            if (sstrFldSet.indexOf(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser) >= 0) {
                objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
            }
            if (sstrFldSet.indexOf(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdDate) >= 0) {
                objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
            }
            if (sstrFldSet.indexOf(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_Meno) >= 0) {
                objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
            }
        };
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象(简单)
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetSimObjFromObj)
        /// </summary>
        /// <param name = "objgs_PaperGroupENS">源对象</param>
        /// <param name = "objgs_PaperGroupENT">目标对象</param>
        clsgs_PaperGroupBL.GetSimObjFromObj = function (objgs_PaperGroupENS) {
            var objgs_PaperGroupENT = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN_Sim();
            objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
            objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
            objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
            objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
            objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
            objgs_PaperGroupENT.sf_UpdFldSetStr = objgs_PaperGroupENS.UpdFldString; //专门用于记录某字段属性是否修改
            objgs_PaperGroupENT.sf_FldComparisonOp = objgs_PaperGroupENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
            return objgs_PaperGroupENT;
        };
        return clsgs_PaperGroupBL;
    }());
    exports.clsgs_PaperGroupBL = clsgs_PaperGroupBL;
    ;
});
