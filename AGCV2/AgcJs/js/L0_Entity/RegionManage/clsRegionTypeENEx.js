﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRegionTypeENEx
 表名:RegionType(00050081)
 生成代码版本:2020.04.08.1
 生成日期:2020/04/12 22:02:02
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
 框架-层名:实体扩展层RJ(EntityLayerRJEx)
 编程语言:JavaScript
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
define(["require", "exports", "jquery", "clsgeneraltab"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsGeneralTab_js_1 = require("clsgeneraltab");
 /// <summary>
 /// 区域类型(RegionType)
 /// (AutoGCLib.EntityLayerRJEx4JavaScript:GeneCode)
 /// </summary>
var clsRegionTypeENEx = /** @class */ (function (_super) {
__extends(clsRegionTypeENEx, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJEx4JavaScript:Gen_ENEx_ClassConstructor1)
/// </summary>
 function clsRegionTypeENEx()
 {
 var _this = _super.call(this) || this;
  return _this;
 }
return clsRegionTypeENEx;
}(clsRegionTypeEN_js_1.clsRegionTypeEN));
exports.clsRegionTypeENEx = clsRegionTypeENEx;
});