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
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../TS/PubFun/clsCommonFunc4Web.js", "../TS/PubFun/CacheHelper.js", "../TS/PubFun/clsFldComparisonObj.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:WApigs_PaperGroup_UT_TS
    表名:gs_PaperGroup(01120749)
    生成代码版本:2020.09.24.1
    生成日期:2020/09/28 23:16:54
    生成者:pyf2
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培论文
    模块英文名:GraduateEduPaper
    框架-层名:WA_界面UT后台_TS(WA_ViewUTScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    /////import * as $ from "jquery";
    var clsgs_PaperGroupEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js");
    var clsgs_PaperGroupWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    var clsCommonFunc4Web_js_1 = require("../TS/PubFun/clsCommonFunc4Web.js");
    var CacheHelper_js_1 = require("../TS/PubFun/CacheHelper.js");
    var clsFldComparisonObj_js_1 = require("../TS/PubFun/clsFldComparisonObj.js");
    /// <summary>
    /// WApigs_PaperGroup_UT_TS 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:GeneCode)
    /// </summary>
    var WApigs_PaperGroup_UT_TS = /** @class */ (function () {
        function WApigs_PaperGroup_UT_TS() {
        }
        /// <summary>
        /// 检查相应关键字的记录是否存在
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExist)
        /// </summary>
        /// <param name = "sender">发送者</param>
        /// <returns>返回是否存在</returns>
        WApigs_PaperGroup_UT_TS.btnIsExist_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyId, strPaperGroupId, responseText, returnBool, strInfo, strInfo, e_1, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divIsExist");
                            strKeyId = $('#txtstrKeyId1').val();
                            strPaperGroupId = strKeyId;
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.IsExistAsync(strPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            returnBool = responseText;
                            if (returnBool == false) {
                                strInfo = "\u5173\u952E\u5B57:[" + strKeyId + "] \u7684\u8BB0\u5F55\u4E0D\u5B58\u5728!";
                                $('#lblResult1').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u5173\u952E\u5B57:[" + strKeyId + "]\u7684\u76F8\u5173\u8BB0\u5F55\u5B58\u5728!";
                                $('#lblResult1').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_1 = _a.sent();
                            strMsg = "\u68C0\u67E5\u76F8\u5E94\u5173\u952E\u5B57\u7684\u8BB0\u5F55\u5B58\u5728\u4E0D\u6210\u529F, " + e_1 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 检查相应关键字的记录是否存在
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExist_Cache)
        /// </summary>
        /// <param name = "sender">发送者</param>
        /// <returns>返回是否存在</returns>
        WApigs_PaperGroup_UT_TS.btnIsExist_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyId, strPaperGroupId, responseText, returnBool, strInfo, strInfo, e_2, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divIsExist_Cache");
                            strKeyId = $('#txtstrKeyId2').val();
                            strPaperGroupId = strKeyId;
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.IsExist_Cache(strPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            returnBool = responseText;
                            if (returnBool == false) {
                                strInfo = "\u5173\u952E\u5B57:[" + strKeyId + "] \u7684\u8BB0\u5F55\u4E0D\u5B58\u5728!";
                                $('#lblResult2').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u5173\u952E\u5B57:[" + strKeyId + "]\u7684\u76F8\u5173\u8BB0\u5F55\u5B58\u5728!";
                                $('#lblResult2').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_2 = _a.sent();
                            strMsg = "\u68C0\u67E5\u76F8\u5E94\u5173\u952E\u5B57\u7684\u8BB0\u5F55\u5B58\u5728\u4E0D\u6210\u529F, " + e_2 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 检查相应关键字的记录是否存在
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExistRecord)
        /// </summary>
        /// <param name = "sender">发送者</param>
        /// <returns>返回是否存在</returns>
        WApigs_PaperGroup_UT_TS.btnIsExistRecord_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strWhereCond, responseText, returnBool, strInfo, strInfo, e_3, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divIsExistRecord");
                            strWhereCond = $('#txtstrWhereCond3').val();
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.IsExistRecordAsync(strWhereCond)];
                        case 2:
                            responseText = _a.sent();
                            returnBool = responseText;
                            if (returnBool == false) {
                                strWhereCond = $('#txtstrWhereCond3').val();
                                strInfo = "\u6839\u636E\u6761\u4EF6:[" + strWhereCond + "] \u7684\u8BB0\u5F55\u4E0D\u5B58\u5728!";
                                $('#lblResult3').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strWhereCond = $('#txtstrWhereCond3').val();
                                strInfo = "\u6839\u636E\u6761\u4EF6:[" + strWhereCond + "]\u7684\u76F8\u5173\u8BB0\u5F55\u5B58\u5728!";
                                $('#lblResult3').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_3 = _a.sent();
                            strMsg = "\u68C0\u67E5\u6761\u4EF6\u7684\u8BB0\u5F55\u5B58\u5728\u4E0D\u6210\u529F, " + (e_3) + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 检查相应关键字的记录是否存在
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickIsExistRecord_Cache)
        /// </summary>
        /// <param name = "sender">发送者</param>
        /// <returns>返回是否存在</returns>
        WApigs_PaperGroup_UT_TS.btnIsExistRecord_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var objTabName_Cond, objgs_PaperGroup_Cond, arrFldComparisonObj, objgs_PaperGroupEN_Sim, responseText, returnBool, strInfo, strInfo, e_4, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divIsExistRecord_Cache");
                            objTabName_Cond = $('#txtobjTabName_Cond4').val();
                            objgs_PaperGroup_Cond = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
                            console.log("\u5B57\u6BB5\u6BD4\u8F83\u5BF9\u8C61\u8BB0\u5F55\u6570(\u672C\u5730\u83B7\u53D6)\uFF1A" + arrFldComparisonObj.length);
                            arrFldComparisonObj.forEach(function (x) { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
                            objgs_PaperGroupEN_Sim = clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
                            console.log(objgs_PaperGroupEN_Sim);
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.IsExistRecord_Cache(objgs_PaperGroup_Cond)];
                        case 2:
                            responseText = _a.sent();
                            returnBool = responseText;
                            if (returnBool == false) {
                                strInfo = "\u6839\u636E\u6761\u4EF6:[" + JSON.stringify(objgs_PaperGroup_Cond) + "]\u7684\u8BB0\u5F55\u4E0D\u5B58\u5728!";
                                $('#lblResult4').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u6839\u636E\u6761\u4EF6:[" + JSON.stringify(objgs_PaperGroup_Cond) + "]\u7684\u76F8\u5173\u8BB0\u5F55\u5B58\u5728!";
                                $('#lblResult4').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_4 = _a.sent();
                            strMsg = "\u68C0\u67E5\u6761\u4EF6\u7684\u8BB0\u5F55\u5B58\u5728\u4E0D\u6210\u529F, " + (e_4) + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 获取某一条件的记录数
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetRecCountByCond)
        /// </summary>
        /// <param name = "sender">发送者</param>
        /// <returns>返回是否存在</returns>
        WApigs_PaperGroup_UT_TS.btnGetRecCountByCond_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strWhereCond, responseText, returnInt, strInfo, e_5, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetRecCountByCond");
                            strWhereCond = $('#txtstrWhereCond5').val();
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetRecCountByCondAsync(strWhereCond)];
                        case 2:
                            responseText = _a.sent();
                            returnInt = Number(responseText);
                            strWhereCond = $('#txtstrWhereCond5').val();
                            strInfo = "\u6839\u636E\u6761\u4EF6:" + strWhereCond + "\u7684\u8BB0\u5F55\u6570:" + returnInt + "!";
                            $('#lblResult5').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            return [3 /*break*/, 4];
                        case 3:
                            e_5 = _a.sent();
                            strMsg = "\u83B7\u53D6\u67D0\u4E00\u6761\u4EF6\u7684\u8BB0\u5F55\u6570\u4E0D\u6210\u529F," + e_5 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 获取某一条件的记录数
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetRecCountByCond_Cache)
        /// </summary>
        /// <param name = "sender">发送者</param>
        /// <returns>返回是否存在</returns>
        WApigs_PaperGroup_UT_TS.btnGetRecCountByCond_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var objTabName_Cond, objgs_PaperGroup_Cond, arrFldComparisonObj, objgs_PaperGroupEN_Sim, responseText, returnInt, strInfo, e_6, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetRecCountByCond_Cache");
                            objTabName_Cond = $('#txtobjTabName_Cond6').val();
                            objgs_PaperGroup_Cond = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
                            console.log("\u5B57\u6BB5\u6BD4\u8F83\u5BF9\u8C61\u8BB0\u5F55\u6570(\u672C\u5730\u83B7\u53D6)\uFF1A" + arrFldComparisonObj.length);
                            arrFldComparisonObj.forEach(function (x) { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
                            objgs_PaperGroupEN_Sim = clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
                            console.log(objgs_PaperGroupEN_Sim);
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetRecCountByCond_Cache(objgs_PaperGroup_Cond)];
                        case 2:
                            responseText = _a.sent();
                            returnInt = Number(responseText);
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + JSON.stringify(objgs_PaperGroup_Cond) + "]\u7684\u8BB0\u5F55\u6570:" + returnInt + "!";
                            $('#lblResult6').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            return [3 /*break*/, 4];
                        case 3:
                            e_6 = _a.sent();
                            strMsg = "\u83B7\u53D6\u67D0\u4E00\u6761\u4EF6\u7684\u8BB0\u5F55\u6570\u4E0D\u6210\u529F," + e_6 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 添加新记录
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickAddNewRecord)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnAddNewRecord_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var objgs_PaperGroupEN, responseText, bolIsExist, strMsg, responseText2, returnBool, strInfo, strInfo, e_7, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divAddNewRecord");
                            objgs_PaperGroupEN = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            objgs_PaperGroupEN.PaperGroupId = "11111111";
                            objgs_PaperGroupEN.PaperGroupName = "11111111111111111111111111111111111111111111111111";
                            objgs_PaperGroupEN.UpdUser = "11111111111111111111111111111111111111111111111111";
                            objgs_PaperGroupEN.UpdDate = "11111111111111111111";
                            objgs_PaperGroupEN.Meno = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 4, , 5]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.IsExistAsync(objgs_PaperGroupEN.PaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            bolIsExist = responseText;
                            if (bolIsExist == true) {
                                strMsg = "\u6DFB\u52A0\u8BB0\u5F55\u65F6\uFF0C\u5173\u952E\u5B57\uFF1A" + objgs_PaperGroupEN.PaperGroupId + "\u5DF2\u7ECF\u5B58\u5728\uFF01";
                                alert(strMsg);
                                return [2 /*return*/, responseText]; //一定要有一个返回值，否则会出错！
                            }
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.AddNewRecordAsync(objgs_PaperGroupEN)];
                        case 3:
                            responseText2 = _a.sent();
                            returnBool = !!responseText2;
                            if (returnBool == true) {
                                strInfo = "\u6DFB\u52A0\u8BB0\u5F55\u6210\u529F!";
                                $('#lblResult7').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u6DFB\u52A0\u8BB0\u5F55\u4E0D\u6210\u529F!";
                                $('#lblResult7').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 5];
                        case 4:
                            e_7 = _a.sent();
                            strMsg = "\u6DFB\u52A0\u8BB0\u5F55\u4E0D\u6210\u529F," + e_7 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 5];
                        case 5: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 添加新记录
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickAddNewRecord4GetMaxStrId)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnAddNewRecord4GetMaxStrId_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var responseText, returnString, objgs_PaperGroupEN, responseText_1, returnBool, strInfo, strInfo, e_8, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divAddNewRecord4GetMaxStrId");
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetMaxStrIdAsync()];
                        case 1:
                            responseText = _a.sent();
                            returnString = responseText.toString();
                            objgs_PaperGroupEN = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            objgs_PaperGroupEN.PaperGroupId = returnString;
                            objgs_PaperGroupEN.PaperGroupName = "11111111111111111111111111111111111111111111111111";
                            objgs_PaperGroupEN.UpdUser = "11111111111111111111111111111111111111111111111111";
                            objgs_PaperGroupEN.UpdDate = "11111111111111111111";
                            objgs_PaperGroupEN.Meno = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
                            _a.label = 2;
                        case 2:
                            _a.trys.push([2, 4, , 5]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.AddNewRecordAsync(objgs_PaperGroupEN)];
                        case 3:
                            responseText_1 = _a.sent();
                            returnBool = responseText_1;
                            if (returnBool == true) {
                                strInfo = "\u6DFB\u52A0\u8BB0\u5F55\u6210\u529F!";
                                $('#lblResult8').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u6DFB\u52A0\u8BB0\u5F55\u4E0D\u6210\u529F!";
                                $('#lblResult8').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 5];
                        case 4:
                            e_8 = _a.sent();
                            strMsg = "\u6DFB\u52A0\u8BB0\u5F55\u4E0D\u6210\u529F, " + e_8 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 5];
                        case 5: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 获取当前表关键字值的最大值,再加1,避免重复
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetMaxStrId)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetMaxStrId_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var responseText, returnString, strInfo, strInfo, e_9, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetMaxStrId");
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetMaxStrIdAsync()];
                        case 2:
                            responseText = _a.sent();
                            returnString = responseText.toString();
                            if (returnString == "") {
                                strInfo = "\u83B7\u53D6\u8868gs_PaperGroup\u7684\u6700\u5927\u5173\u952E\u5B57\u4E3A\u7A7A\uFF0C\u4E0D\u6210\u529F\uFF0C\u8BF7\u68C0\u67E5!";
                                $('#lblResult9').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u83B7\u53D6\u8868gs_PaperGroup\u7684\u6700\u5927\u5173\u952E\u5B57\u4E3A\uFF1A" + returnString + "!";
                                $('#lblResult9').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_9 = _a.sent();
                            strMsg = "\u83B7\u53D6\u8868\u5173\u952E\u5B57\u7684\u6700\u5927\u503C\u4E0D\u6210\u529F," + e_9 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetMaxStrIdByPrefix)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetMaxStrIdByPrefix_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strPrefix, responseText, returnString, strInfo, strInfo, e_10, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetMaxStrIdByPrefix");
                            strPrefix = $('#txtstrPrefix10').val();
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetMaxStrIdByPrefixAsync(strPrefix)];
                        case 2:
                            responseText = _a.sent();
                            returnString = responseText.toString();
                            if (returnString == "") {
                                strInfo = "\u83B7\u53D6\u8868gs_PaperGroup\u7684\u6700\u5927\u5173\u952E\u5B57\u4E3A\u7A7A\uFF0C\u4E0D\u6210\u529F\uFF0C\u8BF7\u68C0\u67E5!";
                                $('#lblResult10').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u83B7\u53D6\u8868gs_PaperGroup\u7684\u6700\u5927\u5173\u952E\u5B57\u4E3A\uFF1A" + returnString + "!";
                                $('#lblResult10').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_10 = _a.sent();
                            strMsg = "\u83B7\u53D6\u8868\u5173\u952E\u5B57\u7684\u6700\u5927\u503C\u4E0D\u6210\u529F," + e_10 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 修改记录
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickUpdateRecord)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnUpdateRecord_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var objgs_PaperGroupEN, responseText, returnBool, strInfo, strInfo, e_11, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divUpdateRecord");
                            objgs_PaperGroupEN = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            objgs_PaperGroupEN.PaperGroupId = "11111111";
                            objgs_PaperGroupEN.PaperGroupName = "11111111111111111111111111111111111111111111111111";
                            objgs_PaperGroupEN.UpdUser = "11111111111111111111111111111111111111111111111111";
                            objgs_PaperGroupEN.UpdDate = "11111111111111111111";
                            objgs_PaperGroupEN.Meno = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
                            objgs_PaperGroupEN.sf_UpdFldSetStr = objgs_PaperGroupEN.UpdFldString; //设置哪些字段被修改(脏字段)
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.UpdateRecordAsync(objgs_PaperGroupEN)];
                        case 2:
                            responseText = _a.sent();
                            returnBool = responseText;
                            if (returnBool == true) {
                                strInfo = "\u4FEE\u6539\u8BB0\u5F55\u6210\u529F!";
                                $('#lblResult11').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u4FEE\u6539\u8BB0\u5F55\u4E0D\u6210\u529F!";
                                $('#lblResult11').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_11 = _a.sent();
                            strMsg = "\u4FEE\u6539\u8BB0\u5F55\u4E0D\u6210\u529F," + e_11 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 删除记录
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickDelRecord)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnDelRecord_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyId, strPaperGroupId, responseText, returnInt, strInfo, strInfo, e_12, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divDelRecord");
                            strKeyId = $('#txtstrKeyId12').val();
                            strPaperGroupId = strKeyId;
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.DelRecordAsync(strPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            returnInt = responseText;
                            if (returnInt > 0) {
                                strInfo = "\u5220\u9664\u8BB0\u5F55\u6210\u529F, \u5171\u5220\u9664\u4E86" + returnInt + "\u6761\u8BB0\u5F55!";
                                $('#lblResult12').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u5220\u9664\u8BB0\u5F55\u4E0D\u6210\u529F!";
                                $('#lblResult12').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_12 = _a.sent();
                            strMsg = "\u5220\u9664\u8BB0\u5F55\u4E0D\u6210\u529F. " + e_12 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据关键字列表删除记录
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickDelMultiRecord)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnDelgs_PaperGroups_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyIdLst, arrPaperGroupId, responseText, returnInt, strInfo, strInfo, e_13, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divDel[TabName]s");
                            strKeyIdLst = $('#txtarrKeyId13').val();
                            arrPaperGroupId = strKeyIdLst.split(',');
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.Delgs_PaperGroupsAsync(arrPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            returnInt = responseText;
                            if (returnInt > 0) {
                                strInfo = "\u5220\u9664\u8BB0\u5F55\u6210\u529F,\u5171\u5220\u9664" + returnInt + "\u6761\u8BB0\u5F55!";
                                $('#lblResult13').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u5220\u9664\u8BB0\u5F55\u4E0D\u6210\u529F!";
                                $('#lblResult13').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_13 = _a.sent();
                            strMsg = "\u5220\u9664\u8BB0\u5F55\u4E0D\u6210\u529F. " + e_13 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件删除多条记录
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickDelMultiRecordByCond)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnDelMultiRecordByCond_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strWhereCond, responseText, returnInt, strInfo, strInfo, e_14, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divDelMultiRecordByCond");
                            strWhereCond = $('#txtstrWhereCond14').val();
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.Delgs_PaperGroupsByCondAsync(strWhereCond)];
                        case 2:
                            responseText = _a.sent();
                            returnInt = responseText;
                            if (returnInt > 0) {
                                strInfo = "\u5220\u9664\u8BB0\u5F55\u6210\u529F,\u5171\u5220\u9664" + returnInt + "\u6761\u8BB0\u5F55!";
                                $('#lblResult14').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            else {
                                strInfo = "\u5220\u9664\u8BB0\u5F55\u4E0D\u6210\u529F!";
                                $('#lblResult14').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_14 = _a.sent();
                            strMsg = "\u5220\u9664\u8BB0\u5F55\u4E0D\u6210\u529F. " + e_14 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的第一条记录的对象
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetFirstObj)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetFirstObj_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strWhereCond, responseText, objgs_PaperGroupEN, strInfo, e_15, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetFirstObj");
                            strWhereCond = $('#txtstrWhereCond15').val();
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetFirstObjAsync(strWhereCond)];
                        case 2:
                            responseText = _a.sent();
                            objgs_PaperGroupEN = responseText;
                            strWhereCond = $('#txtstrWhereCond15').val();
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + strWhereCond + "] \u83B7\u53D6\u7B2C\u4E00\u4E2A\u8BB0\u5F55\u5BF9\u8C61\uFF1A" + objgs_PaperGroupEN.PaperGroupId + "!";
                            $('#lblResult15').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            this.Showgs_PaperGroupObj("divList15", objgs_PaperGroupEN);
                            return [3 /*break*/, 4];
                        case 3:
                            e_15 = _a.sent();
                            strMsg = "\u6839\u636E\u6761\u4EF6\u83B7\u53D6\u76F8\u5E94\u7684\u7B2C\u4E00\u6761\u8BB0\u5F55\u7684\u5BF9\u8C61\u4E0D\u6210\u529F," + e_15 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjByKey)
        /// </summary>
        /// <param name = "sender">参数列表</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjByPaperGroupId_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyId, strPaperGroupId, responseText, objgs_PaperGroupEN, strInfo, e_16, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjBy[Key]");
                            strKeyId = $('#txtvarKeyId16').val();
                            strPaperGroupId = strKeyId;
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjByPaperGroupIdAsync(strPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            objgs_PaperGroupEN = responseText;
                            strInfo = "\u6839\u636E\u5173\u952E\u5B57:[" + strKeyId + "]\u83B7\u53D6\u5BF9\u8C61\uFF1A" + objgs_PaperGroupEN.PaperGroupId + "!";
                            $('#lblResult16').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            this.Showgs_PaperGroupObj("divList16", objgs_PaperGroupEN);
                            return [3 /*break*/, 4];
                        case 3:
                            e_16 = _a.sent();
                            strMsg = "\u6839\u636E\u5173\u952E\u5B57\u83B7\u53D6\u76F8\u5E94\u7684\u8BB0\u5F55\u7684\u5BF9\u8C61\u4E0D\u6210\u529F," + e_16 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjByKey_Cache)
        /// </summary>
        /// <param name = "sender">参数列表</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjByPaperGroupId_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyId, strPaperGroupId, responseText, objgs_PaperGroupEN, strInfo, e_17, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjBy[Key]_Cache");
                            strKeyId = $('#txtvarKeyId17').val();
                            strPaperGroupId = strKeyId;
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjByPaperGroupId_Cache(strPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            objgs_PaperGroupEN = responseText;
                            strInfo = "\u6839\u636E\u5173\u952E\u5B57:[" + strKeyId + "]\u83B7\u53D6\u5BF9\u8C61\uFF1A" + objgs_PaperGroupEN.PaperGroupId + "!";
                            $('#lblResult17').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            this.Showgs_PaperGroupObj("divList17", objgs_PaperGroupEN);
                            return [3 /*break*/, 4];
                        case 3:
                            e_17 = _a.sent();
                            strMsg = "\u6839\u636E\u5173\u952E\u5B57\u83B7\u53D6\u76F8\u5E94\u7684\u8BB0\u5F55\u7684\u5BF9\u8C61\u4E0D\u6210\u529F," + e_17 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjByKey_WA_Cache)
        /// </summary>
        /// <param name = "sender">参数列表</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjByPaperGroupId_WA_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyId, strPaperGroupId, responseText, objgs_PaperGroupEN, strInfo, e_18, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
                            strKeyId = $('#txtvarKeyId18').val();
                            strPaperGroupId = strKeyId;
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjByPaperGroupId_WA_CacheAsync(strPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            objgs_PaperGroupEN = responseText;
                            strInfo = "\u6839\u636E\u5173\u952E\u5B57:[" + strKeyId + "]\u83B7\u53D6\u5BF9\u8C61\uFF1A" + objgs_PaperGroupEN.PaperGroupId + "!";
                            $('#lblResult18').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            this.Showgs_PaperGroupObj("divList18", objgs_PaperGroupEN);
                            return [3 /*break*/, 4];
                        case 3:
                            e_18 = _a.sent();
                            strMsg = "\u6839\u636E\u5173\u952E\u5B57\u83B7\u53D6\u76F8\u5E94\u7684\u8BB0\u5F55\u7684\u5BF9\u8C61\u4E0D\u6210\u529F," + e_18 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLst)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjLst_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strWhereCond, responseText, arrgs_PaperGroupObjLst, strInfo, e_19, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjLst");
                            strWhereCond = $('#txtstrWhereCond19').val();
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjLstAsync(strWhereCond)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + strWhereCond + "]\u5171\u83B7\u53D6\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult19').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList19", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_19 = _a.sent();
                            strMsg = "\u6839\u636E\u6761\u4EF6\u83B7\u53D6\u76F8\u5E94\u7684\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F," + e_19 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据关键字列表获取相应的对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjLstByKeyLst_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyIdLst, arrPaperGroupId, responseText, arrgs_PaperGroupObjLst, strInfo, e_20, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjLstByKeyLst");
                            strKeyIdLst = $('#txtarrKeyId20').val();
                            arrPaperGroupId = strKeyIdLst.split(',');
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjLstByPaperGroupIdLstAsync(arrPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u5173\u952E\u5B57\u5217\u8868:[" + strKeyIdLst + "]\u5171\u83B7\u53D6\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult20').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList20", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_20 = _a.sent();
                            strMsg = "\u6839\u636E\u5173\u952E\u5B57\u5217\u8868\u83B7\u53D6\u76F8\u5E94\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F," + e_20 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据关键字列表获取相应的对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst_Cache)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjLstByKeyLst_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyIdLst, arrPaperGroupId, responseText, arrgs_PaperGroupObjLst, strInfo, e_21, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjLstByKeyLst_Cache");
                            strKeyIdLst = $('#txtarrKeyId21').val();
                            arrPaperGroupId = strKeyIdLst.split(',');
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjLstByPaperGroupIdLst_Cache(arrPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u5173\u952E\u5B57\u5217\u8868:[" + strKeyIdLst + "]\u5171\u83B7\u53D6\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult21').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList21", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_21 = _a.sent();
                            strMsg = "\u6839\u636E\u5173\u952E\u5B57\u5217\u8868\u83B7\u53D6\u76F8\u5E94\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F," + e_21 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据关键字列表获取相应的对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByKeyLst_WA_Cache)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjLstByKeyLst_WA_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKeyIdLst, arrPaperGroupId, responseText, arrgs_PaperGroupObjLst, strInfo, e_22, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
                            strKeyIdLst = $('#txtarrKeyId22').val();
                            arrPaperGroupId = strKeyIdLst.split(',');
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjLstByPaperGroupIdLst_WA_CacheAsync(arrPaperGroupId)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u5173\u952E\u5B57\u5217\u8868:[" + strKeyIdLst + "]\u5171\u83B7\u53D6\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult22').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList22", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_22 = _a.sent();
                            strMsg = "\u6839\u636E\u5173\u952E\u5B57\u5217\u8868\u83B7\u53D6\u76F8\u5E94\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F," + e_22 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的分页对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetSubObjLst_Cache)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetSubObjLst_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var objTabName_Cond, objgs_PaperGroup_Cond, arrFldComparisonObj, objgs_PaperGroupEN_Sim, responseText, arrgs_PaperGroupObjLst, strInfo, e_23, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetSubObjLst_Cache");
                            objTabName_Cond = $('#txtobjTabName_Cond23').val();
                            objgs_PaperGroup_Cond = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
                            console.log("\u5B57\u6BB5\u6BD4\u8F83\u5BF9\u8C61\u8BB0\u5F55\u6570(\u672C\u5730\u83B7\u53D6)\uFF1A" + arrFldComparisonObj.length);
                            arrFldComparisonObj.forEach(function (x) { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
                            objgs_PaperGroupEN_Sim = clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
                            console.log(objgs_PaperGroupEN_Sim);
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetSubObjLst_Cache(objgs_PaperGroup_Cond)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + JSON.stringify(objgs_PaperGroup_Cond) + "],\u5171\u83B7\u53D6\u5BF9\u8C61\u5217\u8868\u5B50\u96C6\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult23').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList23", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_23 = _a.sent();
                            strMsg = "\u6839\u636E\u6761\u4EF6\u5BF9\u8C61\u83B7\u53D6\u76F8\u5E94\u7684\u5BF9\u8C61\u5217\u8868\u5B50\u96C6\u4E0D\u6210\u529F, " + e_23 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的分页对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetSubObjLst_WA_Cache)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetSubObjLst_WA_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var objTabName_Cond, objgs_PaperGroup_Cond, arrFldComparisonObj, objgs_PaperGroupEN_Sim, responseText, arrgs_PaperGroupObjLst, strInfo, e_24, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetSubObjLst_WA_Cache");
                            objTabName_Cond = $('#txtobjTabName_Cond24').val();
                            objgs_PaperGroup_Cond = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
                            console.log("\u5B57\u6BB5\u6BD4\u8F83\u5BF9\u8C61\u8BB0\u5F55\u6570(\u672C\u5730\u83B7\u53D6)\uFF1A" + arrFldComparisonObj.length);
                            arrFldComparisonObj.forEach(function (x) { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
                            objgs_PaperGroupEN_Sim = clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
                            console.log(objgs_PaperGroupEN_Sim);
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetSubObjLst_WA_CacheAsync(objgs_PaperGroup_Cond)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + JSON.stringify(objgs_PaperGroup_Cond) + "],\u5171\u83B7\u53D6\u5BF9\u8C61\u5217\u8868\u5B50\u96C6\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult24').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList24", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_24 = _a.sent();
                            strMsg = "\u6839\u636E\u6761\u4EF6\u5BF9\u8C61\u83B7\u53D6\u76F8\u5E94\u7684\u5BF9\u8C61\u5217\u8868\u5B50\u96C6\u4E0D\u6210\u529F, " + e_24 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的顶部对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetTopObjLst)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetTopObjLst_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var intTopSize, strOrderBy, strWhereCond, objTopPara, responseText, arrgs_PaperGroupObjLst, strInfo, e_25, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetTopObjLst");
                            intTopSize = Number($('#txtintTopSize25').val());
                            strOrderBy = $('#txtstrOrderBy25').val();
                            strWhereCond = $('#txtstrWhereCond25').val();
                            objTopPara = {
                                WhereCond: strWhereCond,
                                TopSize: intTopSize,
                                OrderBy: "",
                                IsCheckSQLAttack: "false",
                                Exclude: ""
                            };
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetTopObjLstAsync(objTopPara)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + strWhereCond + "],\u9876\u90E8\u6570:[" + intTopSize + "]\u5171\u83B7\u53D6\u9876\u90E8\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult25').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList25", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_25 = _a.sent();
                            strMsg = "\u6839\u636E\u6761\u4EF6\u83B7\u53D6\u76F8\u5E94\u7684\u9876\u90E8\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F, " + e_25 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的分页对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByPager)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjLstByPager_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var intPageIndex, intPageSize, strOrderBy, strWhereCond, objPagerPara, responseText, arrgs_PaperGroupObjLst, strInfo, e_26, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjLstByPager");
                            intPageIndex = Number($('#txtintPageIndex26').val());
                            intPageSize = Number($('#txtintPageSize26').val());
                            strOrderBy = $('#txtstrOrderBy26').val();
                            strWhereCond = $('#txtstrWhereCond26').val();
                            objPagerPara = {
                                PageIndex: intPageIndex,
                                PageSize: intPageSize,
                                WhereCond: strWhereCond,
                                OrderBy: strOrderBy
                            };
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjLstByPagerAsync(objPagerPara)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + strWhereCond + "],\u6BCF\u9875\u8BB0\u5F55\u6570:[" + intPageSize + "],\u7B2C[" + intPageIndex + "]\u9875,\u5171\u83B7\u53D6\u5206\u9875\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult26').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList26", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_26 = _a.sent();
                            strMsg = "\u6839\u636E\u6761\u4EF6\u83B7\u53D6\u76F8\u5E94\u7684\u5206\u9875\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F, " + e_26 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的分页对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByPager_Cache)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjLstByPager_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var intPageIndex, intPageSize, strOrderBy, strWhereCond, objgs_PaperGroup_Cond, arrFldComparisonObj, objgs_PaperGroupEN_Sim, objPagerPara, responseText, arrgs_PaperGroupObjLst, strInfo, e_27, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjLstByPager_Cache");
                            intPageIndex = Number($('#txtintPageIndex27').val());
                            intPageSize = Number($('#txtintPageSize27').val());
                            strOrderBy = $('#txtstrOrderBy27').val();
                            strWhereCond = $('#txtstrWhereCond27').val();
                            objgs_PaperGroup_Cond = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
                            console.log("\u5B57\u6BB5\u6BD4\u8F83\u5BF9\u8C61\u8BB0\u5F55\u6570(\u672C\u5730\u83B7\u53D6)\uFF1A" + arrFldComparisonObj.length);
                            arrFldComparisonObj.forEach(function (x) { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
                            objgs_PaperGroupEN_Sim = clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
                            console.log(objgs_PaperGroupEN_Sim);
                            strWhereCond = JSON.stringify(objgs_PaperGroupEN_Sim);
                            objPagerPara = {
                                PageIndex: intPageIndex,
                                PageSize: intPageSize,
                                WhereCond: strWhereCond,
                                OrderBy: strOrderBy
                            };
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjLstByPager_Cache(objPagerPara)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + strWhereCond + "],\u6BCF\u9875\u8BB0\u5F55\u6570:[" + intPageSize + "],\u7B2C[" + intPageIndex + "]\u9875,\u5171\u83B7\u53D6\u5206\u9875\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult27').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList27", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_27 = _a.sent();
                            strMsg = "\u6839\u636E\u6761\u4EF6\u83B7\u53D6\u76F8\u5E94\u7684\u5206\u9875\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F, " + e_27 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取相应的分页对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByPager_WA_Cache)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjLstByPager_WA_Cache_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var intPageIndex, intPageSize, strOrderBy, strWhereCond, objgs_PaperGroup_Cond, arrFldComparisonObj, objgs_PaperGroupEN_Sim, objPagerPara, responseText, arrgs_PaperGroupObjLst, strInfo, e_28, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjLstByPager_WA_Cache");
                            intPageIndex = Number($('#txtintPageIndex28').val());
                            intPageSize = Number($('#txtintPageSize28').val());
                            strOrderBy = $('#txtstrOrderBy28').val();
                            strWhereCond = $('#txtstrWhereCond28').val();
                            objgs_PaperGroup_Cond = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
                            arrFldComparisonObj = WApigs_PaperGroup_UT_TS.GetLocalObjLst();
                            console.log("\u5B57\u6BB5\u6BD4\u8F83\u5BF9\u8C61\u8BB0\u5F55\u6570(\u672C\u5730\u83B7\u53D6)\uFF1A" + arrFldComparisonObj.length);
                            arrFldComparisonObj.forEach(function (x) { objgs_PaperGroup_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
                            objgs_PaperGroupEN_Sim = clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupBL.GetSimObjFromObj(objgs_PaperGroup_Cond);
                            console.log(objgs_PaperGroupEN_Sim);
                            strWhereCond = JSON.stringify(objgs_PaperGroupEN_Sim);
                            objPagerPara = {
                                PageIndex: intPageIndex,
                                PageSize: intPageSize,
                                WhereCond: strWhereCond,
                                OrderBy: strOrderBy
                            };
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjLstByPager_WA_CacheAsync(objPagerPara)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + strWhereCond + "],\u6BCF\u9875\u8BB0\u5F55\u6570:[" + intPageSize + "],\u7B2C[" + intPageIndex + "]\u9875,\u5171\u83B7\u53D6\u5206\u9875\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult28').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList28", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_28 = _a.sent();
                            strMsg = "\u6839\u636E\u6761\u4EF6\u83B7\u53D6\u76F8\u5E94\u7684\u5206\u9875\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F, " + e_28 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 根据条件获取范围内相应的对象列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_btnClickGetObjLstByRange)
        /// </summary>
        /// <param name = "sender">事件发送者</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.btnGetObjLstByRange_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strOrderBy, intMaxNum, intMinNum, strWhereCond, objRangePara, responseText, arrgs_PaperGroupObjLst, strInfo, e_29, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            $('#hidDivName').val("divGetObjLstByRange");
                            strOrderBy = $('#txtstrOrderBy29').val();
                            intMaxNum = Number($('#txtintMaxNum29').val());
                            intMinNum = Number($('#txtintMinNum29').val());
                            strWhereCond = $('#txtstrWhereCond29').val();
                            objRangePara = {
                                MaxNum: intMaxNum,
                                MinNum: intMinNum,
                                WhereCond: strWhereCond,
                                OrderBy: strOrderBy
                            };
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjLstByRangeAsync(objRangePara)];
                        case 2:
                            responseText = _a.sent();
                            arrgs_PaperGroupObjLst = responseText;
                            strInfo = "\u6839\u636E\u6761\u4EF6:[" + strWhereCond + "],\u6700\u5C0F\u8BB0\u5F55\u53F7:[" + intMinNum + "],\u6700\u5927\u8BB0\u5F55\u53F7:[" + intMaxNum + "],\u5171\u83B7\u53D6\u5206\u9875\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                            $('#lblResult29').val(strInfo);
                            //显示信息框
                            //alert(strInfo);
                            this.BindTab_gs_PaperGroup("divList29", arrgs_PaperGroupObjLst);
                            return [3 /*break*/, 4];
                        case 3:
                            e_29 = _a.sent();
                            strMsg = "\u6839\u636E\u6761\u4EF6\u83B7\u53D6\u8303\u56F4\u5185\u76F8\u5E94\u7684\u5BF9\u8C61\u5217\u8868\u4E0D\u6210\u529F, " + e_29 + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 显示gs_PaperGroup对象的所有属性值
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_UT_BindTab)
        /// </summary>
        /// <param name = "divContainer">显示容器</param>
        /// <param name = "arrgs_PaperGroupObjLst">需要绑定的对象列表</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.BindTab_gs_PaperGroup = function (divContainer, arrgs_PaperGroupObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(divContainer + "\u4E0D\u5B58\u5728\uFF01");
                return;
            }
            var sstrFldName = new Array();
            var sstrColHeader = new Array();
            sstrFldName.push("PaperGroupId");
            sstrColHeader.push("组Id");
            sstrFldName.push("PaperGroupName");
            sstrColHeader.push("组名");
            sstrFldName.push("UpdUser");
            sstrColHeader.push("修改人");
            sstrFldName.push("UpdDate");
            sstrColHeader.push("修改日期");
            sstrFldName.push("Meno");
            sstrColHeader.push("备注");
            clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrgs_PaperGroupObjLst, sstrFldName, sstrColHeader, "PaperGroupId");
        };
        /// <summary>
        /// 显示{0}对象的所有属性值
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_UT_ShowTabObj)
        /// </summary>
        /// <param name = "divContainer">显示容器</param>
        /// <param name = "objgs_PaperGroup">需要显示的对象</param>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.Showgs_PaperGroupObj = function (divContainer, objgs_PaperGroup) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(divContainer + "\u4E0D\u5B58\u5728\uFF01");
                return;
            }
            var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objgs_PaperGroup);
            var ul = document.createElement("ul");
            for (var _i = 0, sstrKeys_1 = sstrKeys; _i < sstrKeys_1.length; _i++) {
                var strKey = sstrKeys_1[_i];
                var strValue = objgs_PaperGroup[strKey];
                var li = document.createElement("li");
                li.innerHTML = strKey + ":" + strValue;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        };
        /// <summary>
        /// 获取当前表的字段名列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_FldComparison)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.AddDPV_FldComparison = function (divName4Edit) {
            var objLst = document.getElementsByTagName("div");
            var strStartName = "divEditFldComparison";
            var arrElement = WApigs_PaperGroup_UT_TS.GetArray(objLst);
            var arrDiv = arrElement;
            var arrFind = arrDiv.filter(function (x) { return x.id.indexOf(strStartName) > -1; });
            arrFind.forEach(function (x) { return x.innerHTML = ""; });
            //var o: HTMLDivElement = document.getElementById("div") as HTMLDivElement;
            var strUrl = "../Test/_FldComparison/";
            console.log("divName4Edit:(In AddDPV_FldComparison)" + divName4Edit);
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Edit).html(data);
                    //setTimeout(() => { clsFldComparisonObj.BindTab(); }, 100);
                    clsFldComparisonObj_js_1.clsFldComparisonObj.BindTab();
                },
                error: function (e) {
                    console.error(e);
                }
            });
        };
        ;
        /// <summary>
        /// 获取当前表的字段名列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFldNameLst)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.GetFldNameLst = function (func) {
            var arrFldName = clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.AttributeName;
            var strFldNameLst1 = arrFldName.join(",");
            clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
            func(strFldNameLst1);
        };
        /// <summary>
        /// 获取当前表的字段名列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetLocalObjLst)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.GetLocalObjLst = function () {
            var strFldComparisonObjLst = $("#hidFldComparisonObjLst").val();
            if (strFldComparisonObjLst == null || strFldComparisonObjLst == "") {
                return new Array();
            }
            var arrFldComparisonObj = JSON.parse(strFldComparisonObjLst);
            return arrFldComparisonObj;
        };
        ;
        /// <summary>
        /// 建立缓存
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_CreateCache)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.CreateCache = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strKey, responseText, arrgs_PaperGroupObjLst, strInfo, strInfo, e_30, strInfo;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            strKey = "";
                            _a.label = 1;
                        case 1:
                            _a.trys.push([1, 3, , 4]);
                            console.log("开始获取缓存：gs_PaperGroup");
                            strKey = clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName;
                            return [4 /*yield*/, clsgs_PaperGroupWApi_js_1.clsgs_PaperGroupWApi.GetObjLst_Cache()];
                        case 2:
                            responseText = _a.sent();
                            console.log("获取缓存完成！gs_PaperGroup");
                            arrgs_PaperGroupObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
                            if (arrgs_PaperGroupObjLst != null) {
                                strInfo = "\u5EFA\u7ACB\u7F13\u5B58Key=[" + strKey + "]\u5B8C\u6210: \u5171\u83B7\u53D6\u5BF9\u8C61\u5217\u8868\u6570\uFF1A" + arrgs_PaperGroupObjLst.length + "!";
                                $('#lblPageStatusContent').html(strInfo);
                            }
                            else {
                                strInfo = "\u5EFA\u7ACB\u7F13\u5B58Key=[" + strKey + "]\u4E0D\u6210\u529F!";
                                $('#lblPageStatusContent').html(strInfo);
                            }
                            return [3 /*break*/, 4];
                        case 3:
                            e_30 = _a.sent();
                            console.log("WApigs_PaperGroup_UT_TS: CreateCache()不成功！");
                            console.error(e_30);
                            strInfo = "\u5EFA\u7ACB\u7F13\u5B58Key=[" + strKey + "]\u5931\u8D25:" + e_30 + "!";
                            console.log(strInfo);
                            $('#lblPageStatusContent').html(strInfo);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /// <summary>
        /// 把Html控件集合转换成Array列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetArray)
        /// </summary>
        /// <returns></returns>
        WApigs_PaperGroup_UT_TS.GetArray = function (arr) {
            var arrLst = new Array();
            for (var i = 0; i < arr.length; i++) {
                var chk = arr[i]; // as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        };
        ;
        return WApigs_PaperGroup_UT_TS;
    }());
    exports.WApigs_PaperGroup_UT_TS = WApigs_PaperGroup_UT_TS;
});
