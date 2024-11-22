var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsQxUsersEN
    表名:QxUsers(00140015)
    生成代码版本:2019.07.15.2
    生成日期:2019/07/18 14:54:34
    生成者:
    工程名称:统一平台
    工程ID:0014
    相关数据库:101.251.68.133,9433GeneralPlatformTz
    PrjDataBaseId:0184
    模块中文名:用户管理
    模块英文名:UserManage
    框架-层名:实体层(EntityLayer)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    /// <summary>
    /// 用户(QxUsers)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    /// <reference path="../../PubFun/clsGeneralTab.ts" />
    var clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    var clsQxUsersEN = /** @class */ (function (_super) {
        __extends(clsQxUsersEN, _super);
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayer4TypeScript:GenClassConstructor1)
        /// </summary>
        function clsQxUsersEN() {
            var _this = _super.call(this) || this;
            _this.mintAttributeCount = 20;
            _this.AttributeName = new Array("UserId", "UserName", "DepartmentId", "UserStateId", "EffectiveDate", "Password", "id_College", "EffitiveBeginDate", "EffitiveEndDate", "StuTeacherId", "IdentityID", "IsArchive", "openid", "Email", "PhoneNumber", "IsSynch", "SynchDate", "UpdDate", "UpdUser", "Memo");
            _this.mstrUserId = ""; //用户ID
            _this.mstrUserName = ""; //用户名
            _this.mstrDepartmentId = ""; //部门Id
            _this.mstrUserStateId = ""; //用户状态Id
            _this.mstrEffectiveDate = ""; //有效日期
            _this.mstrPassword = ""; //口令
            _this.mstrid_College = ""; //学院流水号
            _this.mstrEffitiveBeginDate = ""; //有效开始日期
            _this.mstrEffitiveEndDate = ""; //有效结束日期
            _this.mstrStuTeacherId = ""; //学工号
            _this.mstrIdentityID = ""; //身份编号
            _this.mbolIsArchive = false; //是否存档
            _this.mstropenid = ""; //微信openid
            _this.mstrEmail = ""; //邮箱
            _this.mstrPhoneNumber = ""; //电话号码
            _this.mbolIsSynch = false; //是否同步
            _this.mstrSynchDate = ""; //同步日期
            _this.mstrUpdDate = ""; //修改日期
            _this.mstrUpdUser = ""; //修改用户
            _this.mstrMemo = ""; //备注
            _this._CurrTabName = "QxUsers";
            _this._KeyFldName = "UserId";
            return _this;
        }
        Object.defineProperty(clsQxUsersEN.prototype, "UserId", {
            /// <summary>
            /// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUserId;
            },
            /// <summary>
            /// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrUserId = value;
                this.hmProperty["UserId"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "UserName", {
            /// <summary>
            /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUserName;
            },
            /// <summary>
            /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrUserName = value;
                this.hmProperty["UserName"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "DepartmentId", {
            /// <summary>
            /// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrDepartmentId;
            },
            /// <summary>
            /// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrDepartmentId = value;
                this.hmProperty["DepartmentId"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "UserStateId", {
            /// <summary>
            /// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUserStateId;
            },
            /// <summary>
            /// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrUserStateId = value;
                this.hmProperty["UserStateId"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "EffectiveDate", {
            /// <summary>
            /// 有效日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrEffectiveDate;
            },
            /// <summary>
            /// 有效日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrEffectiveDate = value;
                this.hmProperty["EffectiveDate"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "Password", {
            /// <summary>
            /// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrPassword;
            },
            /// <summary>
            /// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrPassword = value;
                this.hmProperty["Password"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "id_College", {
            /// <summary>
            /// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrid_College;
            },
            /// <summary>
            /// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrid_College = value;
                this.hmProperty["id_College"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "EffitiveBeginDate", {
            /// <summary>
            /// 有效开始日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrEffitiveBeginDate;
            },
            /// <summary>
            /// 有效开始日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrEffitiveBeginDate = value;
                this.hmProperty["EffitiveBeginDate"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "EffitiveEndDate", {
            /// <summary>
            /// 有效结束日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrEffitiveEndDate;
            },
            /// <summary>
            /// 有效结束日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrEffitiveEndDate = value;
                this.hmProperty["EffitiveEndDate"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "StuTeacherId", {
            /// <summary>
            /// 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrStuTeacherId;
            },
            /// <summary>
            /// 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrStuTeacherId = value;
                this.hmProperty["StuTeacherId"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "IdentityID", {
            /// <summary>
            /// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrIdentityID;
            },
            /// <summary>
            /// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrIdentityID = value;
                this.hmProperty["IdentityID"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "IsArchive", {
            /// <summary>
            /// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mbolIsArchive;
            },
            /// <summary>
            /// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mbolIsArchive = value;
                this.hmProperty["IsArchive"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "openid", {
            /// <summary>
            /// 微信openid(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstropenid;
            },
            /// <summary>
            /// 微信openid(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstropenid = value;
                this.hmProperty["openid"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "Email", {
            /// <summary>
            /// 邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrEmail;
            },
            /// <summary>
            /// 邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrEmail = value;
                this.hmProperty["Email"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "PhoneNumber", {
            /// <summary>
            /// 电话号码(说明:;字段类型:varchar;字段长度:15;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrPhoneNumber;
            },
            /// <summary>
            /// 电话号码(说明:;字段类型:varchar;字段长度:15;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrPhoneNumber = value;
                this.hmProperty["PhoneNumber"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "IsSynch", {
            /// <summary>
            /// 是否同步(说明:;字段类型:bit;字段长度:1;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mbolIsSynch;
            },
            /// <summary>
            /// 是否同步(说明:;字段类型:bit;字段长度:1;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mbolIsSynch = value;
                this.hmProperty["IsSynch"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "SynchDate", {
            /// <summary>
            /// 同步日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrSynchDate;
            },
            /// <summary>
            /// 同步日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrSynchDate = value;
                this.hmProperty["SynchDate"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "UpdDate", {
            /// <summary>
            /// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUpdDate;
            },
            /// <summary>
            /// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrUpdDate = value;
                this.hmProperty["UpdDate"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "UpdUser", {
            /// <summary>
            /// 修改用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUpdUser;
            },
            /// <summary>
            /// 修改用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrUpdUser = value;
                this.hmProperty["UpdUser"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN.prototype, "Memo", {
            /// <summary>
            /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrMemo;
            },
            /// <summary>
            /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrMemo = value;
                this.hmProperty["Memo"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsQxUsersEN, "con_UserId", {
            /// <summary>
            /// 常量:"UserId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UserId"; } //用户ID
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_UserName", {
            /// <summary>
            /// 常量:"UserName"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UserName"; } //用户名
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_DepartmentId", {
            /// <summary>
            /// 常量:"DepartmentId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "DepartmentId"; } //部门Id
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_UserStateId", {
            /// <summary>
            /// 常量:"UserStateId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UserStateId"; } //用户状态Id
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_EffectiveDate", {
            /// <summary>
            /// 常量:"EffectiveDate"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "EffectiveDate"; } //有效日期
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_Password", {
            /// <summary>
            /// 常量:"Password"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "Password"; } //口令
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_id_College", {
            /// <summary>
            /// 常量:"id_College"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "id_College"; } //学院流水号
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_EffitiveBeginDate", {
            /// <summary>
            /// 常量:"EffitiveBeginDate"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "EffitiveBeginDate"; } //有效开始日期
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_EffitiveEndDate", {
            /// <summary>
            /// 常量:"EffitiveEndDate"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "EffitiveEndDate"; } //有效结束日期
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_StuTeacherId", {
            /// <summary>
            /// 常量:"StuTeacherId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "StuTeacherId"; } //学工号
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_IdentityID", {
            /// <summary>
            /// 常量:"IdentityID"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "IdentityID"; } //身份编号
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_IsArchive", {
            /// <summary>
            /// 常量:"IsArchive"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "IsArchive"; } //是否存档
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_openid", {
            /// <summary>
            /// 常量:"openid"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "openid"; } //微信openid
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_Email", {
            /// <summary>
            /// 常量:"Email"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "Email"; } //邮箱
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_PhoneNumber", {
            /// <summary>
            /// 常量:"PhoneNumber"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "PhoneNumber"; } //电话号码
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_IsSynch", {
            /// <summary>
            /// 常量:"IsSynch"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "IsSynch"; } //是否同步
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_SynchDate", {
            /// <summary>
            /// 常量:"SynchDate"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "SynchDate"; } //同步日期
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_UpdDate", {
            /// <summary>
            /// 常量:"UpdDate"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UpdDate"; } //修改日期
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_UpdUser", {
            /// <summary>
            /// 常量:"UpdUser"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UpdUser"; } //修改用户
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsQxUsersEN, "con_Memo", {
            /// <summary>
            /// 常量:"Memo"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "Memo"; } //备注
            ,
            enumerable: true,
            configurable: true
        });
        return clsQxUsersEN;
    }(clsGeneralTab_js_1.clsGeneralTab));
    exports.clsQxUsersEN = clsQxUsersEN;
    ;
});
