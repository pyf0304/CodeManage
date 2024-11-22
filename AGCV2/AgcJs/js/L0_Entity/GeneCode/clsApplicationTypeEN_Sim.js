﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsApplicationTypeEN_Sim
 表名:ApplicationType(00050127)
 生成代码版本:2020.04.08.1
 生成日期:2020/04/13 16:09:00
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:生成代码
 模块英文名:GeneCode
 框架-层名:简化实体层RJ(EntityLayerRJ_Sim)
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
define(["require", "exports", "jquery", ], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
 /// <summary>
 /// 应用程序类型(ApplicationType)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsApplicationTypeEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsApplicationTypeEN_Sim()
 {
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ApplicationTypeId = 0;

/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.ApplicationTypeName = "";

/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 this.ApplicationTypeSimName = "";

/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.ApplicationTypeENName = "";

/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.ProgLangTypeId = "";

/// 编程语言类型Id2(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.ProgLangTypeId2 = "";

/// 编程语言类型Id3(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.ProgLangTypeId3 = "";

/// 编程语言类型Id4(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.ProgLangTypeId4 = "";

/// 编程语言类型Id5(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.ProgLangTypeId5 = "";

/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsVisible = false;

/// 访问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.VisitedNum = 0;

/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.OrderNum = 0;

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsApplicationTypeEN_Sim;
}());
exports.clsApplicationTypeEN_Sim = clsApplicationTypeEN_Sim;
});