/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiCollege_UT_TS
表名:College(01160017)
生成代码版本:2019.07.10.1
生成日期:2019/07/11 01:23:16
生成者:
工程名称:简单工程样例
工程ID:0116
相关数据库:101.251.68.133,9433SimplePrj
PrjDataBaseId:0111
模块中文名:基本信息
模块英文名:BaseInfo
框架-层名:WApi界面单元测试脚本后台_TS(WA_ViewUTScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == ==
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
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
        define(["require", "exports", "../TS/FunClass/stuUserLoginInfo.js", "../TS/FunClass/stuViewInfo4Session.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var stuUserLoginInfo_js_1 = require("../TS/FunClass/stuUserLoginInfo.js");
    var stuViewInfo4Session_js_1 = require("../TS/FunClass/stuViewInfo4Session.js");
    var objUserLoginInfo;
    var objViewInfo4Session;
    /// <summary>
    /// WApiCollege_UT_TS 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:GeneCode)
    /// </summary>
    var Main_ViewInfo = /** @class */ (function () {
        function Main_ViewInfo() {
        }
        Main_ViewInfo.DispUserInfo = function () {
            objUserLoginInfo = stuUserLoginInfo_js_1.stuUserLoginInfo.GetObjByHtmlString(strUserLoginInfo);
            $('#spnUserId').html(objUserLoginInfo.UserId);
            $('#spnRoleName').html(objUserLoginInfo.RoleName);
            $('#spnCurrSelPrjId').html(objUserLoginInfo.CurrSelPrjId);
            $('#spnCurrSelPrjName').html(objUserLoginInfo.CurrSelPrjName);
            $('#spnPrjDataBaseName').html(objUserLoginInfo.PrjDataBaseName);
        };
        Main_ViewInfo.DispViewInfo = function () {
            objViewInfo4Session = stuViewInfo4Session_js_1.stuViewInfo4Session.GetObjByHtmlString(strViewInfo4Session);
            $('#spnViewId').html(objViewInfo4Session.ViewId);
            $('#spnViewName').html(objViewInfo4Session.ViewName);
            $('#spnApplicationTypeId').html(objViewInfo4Session.ApplicationTypeId);
            $('#spnApplicationTypeName').html(objViewInfo4Session.ApplicationTypeName);
        };
        /*
         演示Session 操作
        */
        Main_ViewInfo.Demo_Session = function () {
            return __awaiter(this, void 0, void 0, function () {
                var strUserId, strUserId_Value1, strUserId_Value2, e_1, strMsg;
                return __generator(this, function (_a) {
                    switch (_a.label) {
                        case 0:
                            _a.trys.push([0, 3, , 4]);
                            strUserId = "TestUserId";
                            return [4 /*yield*/, this.SetSessionAsync("UserId", strUserId)];
                        case 1:
                            _a.sent();
                            return [4 /*yield*/, this.GetSessionAsync("UserId")];
                        case 2:
                            strUserId_Value1 = _a.sent();
                            console.log('strUserId_Value1:' + strUserId_Value1);
                            strUserId_Value2 = $('#hidUserId').val();
                            console.log('strUserId_Value2:' + strUserId_Value2);
                            return [3 /*break*/, 4];
                        case 3:
                            e_1 = _a.sent();
                            strMsg = "\u6F14\u793ASession\u4E0D\u6210\u529F," + decodeURIComponent(e_1.responseText) + ".";
                            alert(strMsg);
                            return [3 /*break*/, 4];
                        case 4: return [2 /*return*/];
                    }
                });
            });
        };
        /*
         设置Session
         <param name = "Key">关键字</param>
         <param name = "Value">值</param>
        */
        Main_ViewInfo.SetSessionAsync = function (Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        //$('#myValue').val(text);
                        var strKey = data.key;
                        var strValue = data.value;
                        //$('#myKey').html(strKey);
                        //$('#myValue').html(strValue);
                        console.log(strKey + strValue);
                    }
                });
            });
        };
        /*
     获取Session 关键字的值
     <param name = "Key">关键字</param>
     <return>值</return>
    */
        Main_ViewInfo.GetSessionAsync = function (Key) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: "/Session/GetString",
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key
                    },
                    success: function (data) {
                        var strValue = data.value;
                        console.log(Key + strValue);
                        resolve(data);
                    },
                    error: function (e) {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        };
        return Main_ViewInfo;
    }());
    exports.Main_ViewInfo = Main_ViewInfo;
});
