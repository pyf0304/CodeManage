﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProjectsEN
 表名:Projects(00050002)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:13
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:工程管理
 模块英文名:PrjManage
 框架-层名:实体层RJ(EntityLayerRJ)
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
 /// 工程(Projects)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsProjectsEN = /** @class */ (function (_super) {
__extends(clsProjectsEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsProjectsEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 16;
_this.AttributeName = new Array("PrjId", "PrjName", "PrjDomain", "ISOPrjName", "JavaPackageName", "TableSpace", "VirtualDirectory", "PrjRootDirectory", "IsRelaDataBase", "SoftStructureId", "ApplicationTypeId", "UseStateId", "IsSupportMvc", "UserId", "UpdDate", "Memo");
_this.strPrjId = ""; //工程ID,
_this.strPrjName = ""; //工程名称,
_this.strPrjDomain = ""; //域/包名,
_this.strISOPrjName = ""; //ISO工程名,
_this.strJavaPackageName = ""; //Java包名,
_this.strTableSpace = ""; //表空间,
_this.strVirtualDirectory = ""; //虚拟目录,
_this.strPrjRootDirectory = ""; //工程根目录,
_this.bolIsRelaDataBase = false; //是否关联数据库,
_this.strSoftStructureId = ""; //架构ID,
_this.intApplicationTypeId = 0; //应用程序类型ID,
_this.strUseStateId = ""; //使用状态Id,
_this.bolIsSupportMvc = false; //是否支持Mvc,
_this.strUserId = ""; //用户Id,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "PrjId", {
 get: function ()
{
return this.mstrPrjId;
},
 set: function(value)
{
 this.mstrPrjId = value;
    this.hmProperty["PrjId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "PrjName", {
 get: function ()
{
return this.mstrPrjName;
},
 set: function(value)
{
 this.mstrPrjName = value;
    this.hmProperty["PrjName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 域/包名(说明:;字段类型:varchar;字段长度:128;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "PrjDomain", {
 get: function ()
{
return this.mstrPrjDomain;
},
 set: function(value)
{
 this.mstrPrjDomain = value;
    this.hmProperty["PrjDomain"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ISO工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "ISOPrjName", {
 get: function ()
{
return this.mstrISOPrjName;
},
 set: function(value)
{
 this.mstrISOPrjName = value;
    this.hmProperty["ISOPrjName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// Java包名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "JavaPackageName", {
 get: function ()
{
return this.mstrJavaPackageName;
},
 set: function(value)
{
 this.mstrJavaPackageName = value;
    this.hmProperty["JavaPackageName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表空间(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "TableSpace", {
 get: function ()
{
return this.mstrTableSpace;
},
 set: function(value)
{
 this.mstrTableSpace = value;
    this.hmProperty["TableSpace"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 虚拟目录(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "VirtualDirectory", {
 get: function ()
{
return this.mstrVirtualDirectory;
},
 set: function(value)
{
 this.mstrVirtualDirectory = value;
    this.hmProperty["VirtualDirectory"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程根目录(说明:;字段类型:varchar;字段长度:255;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "PrjRootDirectory", {
 get: function ()
{
return this.mstrPrjRootDirectory;
},
 set: function(value)
{
 this.mstrPrjRootDirectory = value;
    this.hmProperty["PrjRootDirectory"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否关联数据库(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "IsRelaDataBase", {
 get: function ()
{
return this.mbolIsRelaDataBase;
},
 set: function(value)
{
 this.mbolIsRelaDataBase = value;
    this.hmProperty["IsRelaDataBase"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 架构ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "SoftStructureId", {
 get: function ()
{
return this.mstrSoftStructureId;
},
 set: function(value)
{
 this.mstrSoftStructureId = value;
    this.hmProperty["SoftStructureId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "ApplicationTypeId", {
 get: function ()
{
return this.mintApplicationTypeId;
},
 set: function(value)
{
 this.mintApplicationTypeId = value;
    this.hmProperty["ApplicationTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "UseStateId", {
 get: function ()
{
return this.mstrUseStateId;
},
 set: function(value)
{
 this.mstrUseStateId = value;
    this.hmProperty["UseStateId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否支持Mvc(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "IsSupportMvc", {
 get: function ()
{
return this.mbolIsSupportMvc;
},
 set: function(value)
{
 this.mbolIsSupportMvc = value;
    this.hmProperty["IsSupportMvc"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "UserId", {
 get: function ()
{
return this.mstrUserId;
},
 set: function(value)
{
 this.mstrUserId = value;
    this.hmProperty["UserId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "UpdDate", {
 get: function ()
{
return this.mstrUpdDate;
},
 set: function(value)
{
 this.mstrUpdDate = value;
    this.hmProperty["UpdDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProjectsEN.prototype, "Memo", {
 get: function ()
{
return this.mstrMemo;
},
 set: function(value)
{
 this.mstrMemo = value;
    this.hmProperty["Memo"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_PrjName", {
 get: function () {return "PrjName";}  // 工程名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjDomain"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_PrjDomain", {
 get: function () {return "PrjDomain";}  // 域/包名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ISOPrjName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_ISOPrjName", {
 get: function () {return "ISOPrjName";}  // ISO工程名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"JavaPackageName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_JavaPackageName", {
 get: function () {return "JavaPackageName";}  // Java包名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TableSpace"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_TableSpace", {
 get: function () {return "TableSpace";}  // 表空间
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"VirtualDirectory"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_VirtualDirectory", {
 get: function () {return "VirtualDirectory";}  // 虚拟目录
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjRootDirectory"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_PrjRootDirectory", {
 get: function () {return "PrjRootDirectory";}  // 工程根目录
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsRelaDataBase"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_IsRelaDataBase", {
 get: function () {return "IsRelaDataBase";}  // 是否关联数据库
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SoftStructureId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_SoftStructureId", {
 get: function () {return "SoftStructureId";}  // 架构ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_ApplicationTypeId", {
 get: function () {return "ApplicationTypeId";}  // 应用程序类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UseStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_UseStateId", {
 get: function () {return "UseStateId";}  // 使用状态Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSupportMvc"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_IsSupportMvc", {
 get: function () {return "IsSupportMvc";}  // 是否支持Mvc
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_UserId", {
 get: function () {return "UserId";}  // 用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProjectsEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsProjectsEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
this[strFldName] = strFldValue;
if (this.dicFldComparisonOp.hasOwnProperty(strFldName) == false)
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
else
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
}
clsProjectsEN._CurrTabName = "Projects"; //当前表名,与该类相关的表名
clsProjectsEN._KeyFldName = "PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsProjectsEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsProjectsEN = clsProjectsEN;
});