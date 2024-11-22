﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewInfoEN_Sim
 表名:ViewInfo(00050006)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 00:23:43
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
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
 /// 界面(ViewInfo)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsViewInfoEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsViewInfoEN_Sim()
 {
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.ViewId = "";

/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.ViewName = "";

/// 界面类型码(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ViewTypeCode = 0;

/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ApplicationTypeId = 0;

/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.FuncModuleAgcId = "";

/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 this.DataBaseName = "";

/// 主表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.KeyForMainTab = "";

/// 明细表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.KeyForDetailTab = "";

/// 是否需要排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNeedSort = false;

/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNeedTransCode = false;

/// 是否需要设置导出字段(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNeedSetExportFld = false;

/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 this.UserId = "";

/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.PrjId = "";

/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.ViewFunction = "";

/// 界面说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.ViewDetail = "";

/// 缺省菜单名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.DefaMenuName = "";

/// 明细表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.DetailTabId = "";

/// 文件名(说明:;字段类型:varchar;字段长度:150;是否可空:False)
 this.FileName = "";

/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 this.FilePath = "";

/// 主表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.MainTabId = "";

/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.ViewCnName = "";

/// 界面组ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.ViewGroupId = "";

/// 输入数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.INRelaTabId = "";

/// 输入数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.INSQLDSTypeId = "";

/// 输出数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.OUTRelaTabId = "";

/// 输出数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.OUTSQLDSTypeId = "";

/// DetailTabType(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 this.DetailTabType = "";

/// DetailViewId(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.DetailViewId = "";

/// MainTabType(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 this.MainTabType = "";

/// 是否使用缓存列表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsUseCache4List = false;

/// MainViewId(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.MainViewId = "";

/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.GeneCodeDate = "";

/// 任务Id(说明:;字段类型:char;字段长度:16;是否可空:True)
 this.TaskId = "";

/// 区域数(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.RegionNum = 0;

/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdDate = "";

/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdUserId = "";

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

/// 是否同步到Server(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsSynchToServer = false;

/// 同步到Server日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.SynchToServerDate = "";

/// 同步到Server用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.SynchToServerUser = "";

/// 是否同步到Client(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsSynchToClient = false;

/// 同步到Client库日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.SynchToClientDate = "";

/// 同步到Client库用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.SynchToClientUser = "";

/// 同步来源(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.SynSource = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsViewInfoEN_Sim;
}());
exports.clsViewInfoEN_Sim = clsViewInfoEN_Sim;
});