﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModule_AgcEN
 表名:vFuncModule_Agc(00050125)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:08
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
 /// v功能模块_Agc(vFuncModule_Agc)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvFuncModule_AgcEN = /** @class */ (function (_super) {
__extends(clsvFuncModule_AgcEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvFuncModule_AgcEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 15;
_this.AttributeName = new Array("FuncModuleAgcId", "TabNum", "ViewNum", "ObjNum", "PrjViewNum", "FuncModuleName", "FuncModuleEnName", "PrjId", "PrjName", "OrderNum", "UseStateId", "UseStateName", "UpdDate", "Memo", "UpdUser");
_this.strFuncModuleAgcId = ""; //功能模块Id,
_this.intTabNum = 0; //TabNum,
_this.intViewNum = 0; //ViewNum,
_this.intObjNum = 0; //ObjNum,
_this.intPrjViewNum = 0; //PrjViewNum,
_this.strFuncModuleName = ""; //功能模块名称,
_this.strFuncModuleEnName = ""; //功能模块英文名称,
_this.strPrjId = ""; //工程ID,
_this.strPrjName = ""; //工程名称,
_this.intOrderNum = 0; //序号,
_this.strUseStateId = ""; //使用状态Id,
_this.strUseStateName = ""; //使用状态名称,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
_this.strUpdUser = ""; //修改者,
  return _this;
 }

/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "FuncModuleAgcId", {
 get: function ()
{
return this.mstrFuncModuleAgcId;
},
 set: function(value)
{
 this.mstrFuncModuleAgcId = value;
    this.hmProperty["FuncModuleAgcId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// TabNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "TabNum", {
 get: function ()
{
return this.mintTabNum;
},
 set: function(value)
{
 this.mintTabNum = value;
    this.hmProperty["TabNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ViewNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "ViewNum", {
 get: function ()
{
return this.mintViewNum;
},
 set: function(value)
{
 this.mintViewNum = value;
    this.hmProperty["ViewNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ObjNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "ObjNum", {
 get: function ()
{
return this.mintObjNum;
},
 set: function(value)
{
 this.mintObjNum = value;
    this.hmProperty["ObjNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// PrjViewNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "PrjViewNum", {
 get: function ()
{
return this.mintPrjViewNum;
},
 set: function(value)
{
 this.mintPrjViewNum = value;
    this.hmProperty["PrjViewNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "FuncModuleName", {
 get: function ()
{
return this.mstrFuncModuleName;
},
 set: function(value)
{
 this.mstrFuncModuleName = value;
    this.hmProperty["FuncModuleName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "FuncModuleEnName", {
 get: function ()
{
return this.mstrFuncModuleEnName;
},
 set: function(value)
{
 this.mstrFuncModuleEnName = value;
    this.hmProperty["FuncModuleEnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "PrjId", {
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
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "PrjName", {
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
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "OrderNum", {
 get: function ()
{
return this.mintOrderNum;
},
 set: function(value)
{
 this.mintOrderNum = value;
    this.hmProperty["OrderNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "UseStateId", {
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
/// 使用状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "UseStateName", {
 get: function ()
{
return this.mstrUseStateName;
},
 set: function(value)
{
 this.mstrUseStateName = value;
    this.hmProperty["UseStateName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "UpdDate", {
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
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "Memo", {
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
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFuncModule_AgcEN.prototype, "UpdUser", {
 get: function ()
{
return this.mstrUpdUser;
},
 set: function(value)
{
 this.mstrUpdUser = value;
    this.hmProperty["UpdUser"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_FuncModuleAgcId", {
 get: function () {return "FuncModuleAgcId";}  // 功能模块Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_TabNum", {
 get: function () {return "TabNum";}  // TabNum
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_ViewNum", {
 get: function () {return "ViewNum";}  // ViewNum
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ObjNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_ObjNum", {
 get: function () {return "ObjNum";}  // ObjNum
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjViewNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_PrjViewNum", {
 get: function () {return "PrjViewNum";}  // PrjViewNum
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_FuncModuleName", {
 get: function () {return "FuncModuleName";}  // 功能模块名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_FuncModuleEnName", {
 get: function () {return "FuncModuleEnName";}  // 功能模块英文名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_PrjName", {
 get: function () {return "PrjName";}  // 工程名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_OrderNum", {
 get: function () {return "OrderNum";}  // 序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UseStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_UseStateId", {
 get: function () {return "UseStateId";}  // 使用状态Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UseStateName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_UseStateName", {
 get: function () {return "UseStateName";}  // 使用状态名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFuncModule_AgcEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});

clsvFuncModule_AgcEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvFuncModule_AgcEN._CurrTabName = "vFuncModule_Agc"; //当前表名,与该类相关的表名
clsvFuncModule_AgcEN._KeyFldName = "FuncModuleAgcId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvFuncModule_AgcEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvFuncModule_AgcEN = clsvFuncModule_AgcEN;
});