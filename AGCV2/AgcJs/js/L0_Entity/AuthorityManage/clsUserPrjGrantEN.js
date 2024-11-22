﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPrjGrantEN
 表名:UserPrjGrant(00050092)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:14
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:权限管理
 模块英文名:AuthorityManage
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
 /// UserPrjGrant(UserPrjGrant)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsUserPrjGrantEN = /** @class */ (function (_super) {
__extends(clsUserPrjGrantEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsUserPrjGrantEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 9;
_this.AttributeName = new Array("mId", "UserId", "PrjId", "RoleId", "VisitedNum", "LastVisitedDate", "OptId", "OptDate", "Memo");
_this.lngmId = 0; //mId,
_this.strUserId = ""; //用户Id,
_this.strPrjId = ""; //工程ID,
_this.strRoleId = ""; //角色ID,
_this.intVisitedNum = 0; //访问数,
_this.strLastVisitedDate = ""; //最后访问时间,
_this.strOptId = ""; //操作者Id,
_this.strOptDate = ""; //操作日期,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserPrjGrantEN.prototype, "mId", {
 get: function ()
{
return this.mlngmId;
},
 set: function(value)
{
 this.mlngmId = value;
    this.hmProperty["mId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserPrjGrantEN.prototype, "UserId", {
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
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserPrjGrantEN.prototype, "PrjId", {
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
/// 角色ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserPrjGrantEN.prototype, "RoleId", {
 get: function ()
{
return this.mstrRoleId;
},
 set: function(value)
{
 this.mstrRoleId = value;
    this.hmProperty["RoleId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 访问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserPrjGrantEN.prototype, "VisitedNum", {
 get: function ()
{
return this.mintVisitedNum;
},
 set: function(value)
{
 this.mintVisitedNum = value;
    this.hmProperty["VisitedNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 最后访问时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserPrjGrantEN.prototype, "LastVisitedDate", {
 get: function ()
{
return this.mstrLastVisitedDate;
},
 set: function(value)
{
 this.mstrLastVisitedDate = value;
    this.hmProperty["LastVisitedDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 操作者Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserPrjGrantEN.prototype, "OptId", {
 get: function ()
{
return this.mstrOptId;
},
 set: function(value)
{
 this.mstrOptId = value;
    this.hmProperty["OptId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 操作日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserPrjGrantEN.prototype, "OptDate", {
 get: function ()
{
return this.mstrOptDate;
},
 set: function(value)
{
 this.mstrOptDate = value;
    this.hmProperty["OptDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserPrjGrantEN.prototype, "Memo", {
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
 /// 常量:"mId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserPrjGrantEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserPrjGrantEN, "con_UserId", {
 get: function () {return "UserId";}  // 用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserPrjGrantEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RoleId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserPrjGrantEN, "con_RoleId", {
 get: function () {return "RoleId";}  // 角色ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"VisitedNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserPrjGrantEN, "con_VisitedNum", {
 get: function () {return "VisitedNum";}  // 访问数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"LastVisitedDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserPrjGrantEN, "con_LastVisitedDate", {
 get: function () {return "LastVisitedDate";}  // 最后访问时间
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OptId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserPrjGrantEN, "con_OptId", {
 get: function () {return "OptId";}  // 操作者Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OptDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserPrjGrantEN, "con_OptDate", {
 get: function () {return "OptDate";}  // 操作日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserPrjGrantEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsUserPrjGrantEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsUserPrjGrantEN._CurrTabName = "UserPrjGrant"; //当前表名,与该类相关的表名
clsUserPrjGrantEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsUserPrjGrantEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsUserPrjGrantEN = clsUserPrjGrantEN;
});