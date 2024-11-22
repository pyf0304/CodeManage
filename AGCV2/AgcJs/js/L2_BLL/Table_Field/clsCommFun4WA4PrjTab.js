﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCommFun4WA4PrjTab
 表名:PrjTab(00050009)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:05:56
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
 框架-层名:WA_访问公共函数扩展(CommFun4WARJ)
 编程语言:JavaScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
var __extends = (this && this.__extends) || (function() {
var extendStatics = function(d, b) {
extendStatics = Object.setPrototypeOf ||
({ __proto__: [] }
instanceof Array && function(d, b) { d.__proto__ = b; }) ||
function(d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
return extendStatics(d, b);
};
return function(d, b) {
extendStatics(d, b);
function __() { this.constructor = d; }
d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
})();
(function(factory) {
if (typeof module === "object" && typeof module.exports === "object")
{
var v = factory(require, exports);
if (v !== undefined) module.exports = v;
}
else if (typeof define === "function" && define.amd)
{
define(["require", "exports", "clscommfun4blv2","clssyspara4webapi","../../L3_ForWApi/Table_Field/clsPrjTabWApi.js","../../L3_ForWApi/Table_Field/clsvPrjTabWApi.js","../../L3_ForWApi/Table_Field/clsvPrjTab4ErrMsgWApi.js","../../L3_ForWApi/LogManage/clsvPrjTab4GeneCodeWApi.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsCommFun4BLV2_js_1 = require("clscommfun4blv2");
var clsSysPara4WebApi_js_1 = require("clssyspara4webapi");
var clsPrjTabWApi_js_1 = require("../../L3_ForWApi/Table_Field/clsPrjTabWApi.js");
var clsvPrjTabWApi_js_1 = require("../../L3_ForWApi/Table_Field/clsvPrjTabWApi.js");
var clsvPrjTab4ErrMsgWApi_js_1 = require("../../L3_ForWApi/Table_Field/clsvPrjTab4ErrMsgWApi.js");
var clsvPrjTab4GeneCodeWApi_js_1 = require("../../L3_ForWApi/LogManage/clsvPrjTab4GeneCodeWApi.js");
 /// <summary>
 /// 工程表(PrjTab)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WARJ4JavaScript:GeneCode)
 /// </summary>
var clsCommFun4WA4PrjTab  = /** @class */ (function (_super) {
__extends(clsCommFun4WA4PrjTab, _super);
function clsCommFun4WA4PrjTab()
{
return _super !== null && _super.apply(this, arguments) || this;
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WARJ4JavaScript:Gen_4CFWA_Js_ReFreshCache)
 /// </summary>
clsCommFun4WA4PrjTab.prototype.ReFreshCache = function(strPrjId)
{
var strMsg = "";
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == false)
{
strMsg = "刷新缓存已经关闭。(clsSysPara4WebApi.spSetRefreshCacheOn == false)(" + clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace.GetCurrClassFunction() +")";
console.log(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabWApi_js_1.clsPrjTabWApi.ReFreshThisCache(strPrjId);
clsvPrjTabWApi_js_1.clsvPrjTabWApi.ReFreshThisCache(strPrjId);
clsvPrjTab4ErrMsgWApi_js_1.clsvPrjTab4ErrMsgWApi.ReFreshThisCache(strPrjId);
clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.ReFreshThisCache(strPrjId);
}
return clsCommFun4WA4PrjTab;
}(clsCommFun4BLV2_js_1.clsCommFun4BLV2));
exports.clsCommFun4WA4PrjTab = clsCommFun4WA4PrjTab;
});