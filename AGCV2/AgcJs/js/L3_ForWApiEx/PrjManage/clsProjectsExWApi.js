﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProjectsExWApi
 表名:Projects(00050002)
 生成代码版本:2020.04.08.1
 生成日期:2020/04/13 16:55:56
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:工程管理
 模块英文名:PrjManage
 框架-层名:WA_访问扩展层RJ(WA_AccessRJEx)
 编程语言:JavaScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
var __importStar = (this && this.__importStar) || function(mod) {
if (mod && mod.__esModule) return mod;
var result = { };
if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
result["default"] = mod;
return result;
};
(function(factory) {
if (typeof module === "object" && typeof module.exports === "object")
{
var v = factory(require, exports);
if (v !== undefined) module.exports = v;
}
else if (typeof define === "function" && define.amd)
{
define(["require", "exports", "jquery", "../../L0_Entity/PrjManage/clsProjectsEN.js","clscommonfunc4web","clsstacktrace","clssyspara4webapi"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsProjectsEN_js_1 = require("../../L0_Entity/PrjManage/clsProjectsEN.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsSysPara4WebApi_js_1 = require("clssyspara4webapi");

 /// <summary>
 /// 工程(Projects)
 /// (AutoGCLib.WA_AccessRJEx4JavaScript:GeneCode)
 /// </summary>
var ResponseData;
var clsProjectsExWApi = /** @class */ (function() {
function clsProjectsExWApi(pobjProjectsEN)
{
this.objProjectsEN = new clsProjectsEN_js_1.clsProjectsEN();
this.objProjectsEN = pobjProjectsEN;
}

 /// <summary>
 /// 获取WebApi的地址
 /// (AutoGCLib.WA_AccessRJEx4JavaScript:Gen_4WAEx_Js_GetWebApiUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
clsProjectsExWApi.GetWebApiUrl = function(strController, strAction) {
var strServiceUrl;
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
strServiceUrl = "http://" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort+ "/" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx+ "/" + strController+ "/" + strAction;
}
else {
strServiceUrl = "http://" +  clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local+ "/" +  clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx+ "/" + strController+ "/" + strAction;
}
return strServiceUrl;
}
clsProjectsExWApi.mstrController = "ProjectsExApi";
return clsProjectsExWApi;
}());
exports.clsProjectsExWApi = clsProjectsExWApi;
});