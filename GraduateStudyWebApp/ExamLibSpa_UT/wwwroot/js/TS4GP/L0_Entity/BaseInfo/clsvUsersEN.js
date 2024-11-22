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
    类名:clsvUsersEN
    表名:vUsers(01160035)
    生成代码版本:2019.07.10.1
    生成日期:2019/07/11 01:24:46
    生成者:
    工程名称:简单工程样例
    工程ID:0116
    相关数据库:101.251.68.133,9433AGC
    PrjDataBaseId:0111
    模块中文名:基本信息
    模块英文名:BaseInfo
    框架-层名:实体层(EntityLayer)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    /// <summary>
    /// vUsers(vUsers)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    /// <reference path="../../PubFun/clsGeneralTab.ts" />
    var clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    var clsvUsersEN = /** @class */ (function (_super) {
        __extends(clsvUsersEN, _super);
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayer4TypeScript:GenClassConstructor1)
        /// </summary>
        function clsvUsersEN() {
            var _this = _super.call(this) || this;
            _this.mintAttributeCount = 9;
            _this.AttributeName = new Array("UserId", "UserName", "UserStateId", "UserStateName", "Password", "DepartmentId", "DepartmentName", "OrderNum", "Memo");
            _this.mstrUserId = ""; //用户ID
            _this.mstrUserName = ""; //用户名
            _this.mstrUserStateId = ""; //用户状态号
            _this.mstrUserStateName = ""; //用户状态名
            _this.mstrPassword = ""; //密码
            _this.mstrDepartmentId = ""; //部门ID
            _this.mstrDepartmentName = ""; //部门名称
            _this.mintOrderNum = 0; //排序
            _this.mstrMemo = ""; //备注
            _this._CurrTabName = "vUsers";
            _this._KeyFldName = "UserId";
            return _this;
        }
        Object.defineProperty(clsvUsersEN.prototype, "UserId", {
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
        Object.defineProperty(clsvUsersEN.prototype, "UserName", {
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
        Object.defineProperty(clsvUsersEN.prototype, "UserStateId", {
            /// <summary>
            /// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUserStateId;
            },
            /// <summary>
            /// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:False)
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
        Object.defineProperty(clsvUsersEN.prototype, "UserStateName", {
            /// <summary>
            /// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUserStateName;
            },
            /// <summary>
            /// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrUserStateName = value;
                this.hmProperty["UserStateName"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsvUsersEN.prototype, "Password", {
            /// <summary>
            /// 密码(说明:;字段类型:varchar;字段长度:100;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrPassword;
            },
            /// <summary>
            /// 密码(说明:;字段类型:varchar;字段长度:100;是否可空:False)
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
        Object.defineProperty(clsvUsersEN.prototype, "DepartmentId", {
            /// <summary>
            /// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrDepartmentId;
            },
            /// <summary>
            /// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
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
        Object.defineProperty(clsvUsersEN.prototype, "DepartmentName", {
            /// <summary>
            /// 部门名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrDepartmentName;
            },
            /// <summary>
            /// 部门名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrDepartmentName = value;
                this.hmProperty["DepartmentName"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsvUsersEN.prototype, "OrderNum", {
            /// <summary>
            /// 排序(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mintOrderNum;
            },
            /// <summary>
            /// 排序(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mintOrderNum = value;
                this.hmProperty["OrderNum"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsvUsersEN.prototype, "Memo", {
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
        Object.defineProperty(clsvUsersEN, "con_UserId", {
            /// <summary>
            /// 常量:"UserId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UserId"; } //用户ID
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsvUsersEN, "con_UserName", {
            /// <summary>
            /// 常量:"UserName"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UserName"; } //用户名
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsvUsersEN, "con_UserStateId", {
            /// <summary>
            /// 常量:"UserStateId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UserStateId"; } //用户状态号
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsvUsersEN, "con_UserStateName", {
            /// <summary>
            /// 常量:"UserStateName"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UserStateName"; } //用户状态名
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsvUsersEN, "con_Password", {
            /// <summary>
            /// 常量:"Password"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "Password"; } //密码
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsvUsersEN, "con_DepartmentId", {
            /// <summary>
            /// 常量:"DepartmentId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "DepartmentId"; } //部门ID
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsvUsersEN, "con_DepartmentName", {
            /// <summary>
            /// 常量:"DepartmentName"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "DepartmentName"; } //部门名称
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsvUsersEN, "con_OrderNum", {
            /// <summary>
            /// 常量:"OrderNum"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "OrderNum"; } //排序
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsvUsersEN, "con_Memo", {
            /// <summary>
            /// 常量:"Memo"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "Memo"; } //备注
            ,
            enumerable: true,
            configurable: true
        });
        return clsvUsersEN;
    }(clsGeneralTab_js_1.clsGeneralTab));
    exports.clsvUsersEN = clsvUsersEN;
    ;
});
