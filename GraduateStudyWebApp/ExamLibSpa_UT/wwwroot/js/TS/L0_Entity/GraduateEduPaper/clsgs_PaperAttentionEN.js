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
    类名:clsgs_PaperAttentionEN
    表名:gs_PaperAttention(01120748)
    生成代码版本:2020.09.24.1
    生成日期:2020/09/29 00:00:12
    生成者:pyf2
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培论文
    模块英文名:GraduateEduPaper
    框架-层名:实体层(EntityLayer)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    /// <summary>
    /// 论文关注(gs_PaperAttention)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    /// <reference path="../../PubFun/clsGeneralTab.ts" />
    var clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    var clsgs_PaperAttentionEN = /** @class */ (function (_super) {
        __extends(clsgs_PaperAttentionEN, _super);
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        /// </summary>
        function clsgs_PaperAttentionEN() {
            var _this = _super.call(this) || this;
            _this.mlngPaperAttentionId = 0; //论文收藏Id
            _this.mstrPaperId = ""; //论文Id
            _this.mstrUserId = ""; //用户ID
            _this.mstrPaperGroupId = ""; //组Id
            _this.mstrUpdUser = ""; //修改人
            _this.mstrUpdDate = ""; //修改日期
            _this.mstrMeno = ""; //备注
            return _this;
        }
        Object.defineProperty(clsgs_PaperAttentionEN.prototype, "PaperAttentionId", {
            /// <summary>
            /// 论文收藏Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            get: function () {
                return this.mlngPaperAttentionId;
            },
            /// <summary>
            /// 论文收藏Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            set: function (value) {
                this.mlngPaperAttentionId = value;
                this.hmProperty["PaperAttentionId"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsgs_PaperAttentionEN.prototype, "PaperId", {
            /// <summary>
            /// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            get: function () {
                return this.mstrPaperId;
            },
            /// <summary>
            /// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrPaperId = value;
                this.hmProperty["PaperId"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsgs_PaperAttentionEN.prototype, "UserId", {
            /// <summary>
            /// 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUserId;
            },
            /// <summary>
            /// 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
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
        Object.defineProperty(clsgs_PaperAttentionEN.prototype, "PaperGroupId", {
            /// <summary>
            /// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            get: function () {
                return this.mstrPaperGroupId;
            },
            /// <summary>
            /// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrPaperGroupId = value;
                this.hmProperty["PaperGroupId"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsgs_PaperAttentionEN.prototype, "UpdUser", {
            /// <summary>
            /// 修改人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUpdUser;
            },
            /// <summary>
            /// 修改人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
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
        Object.defineProperty(clsgs_PaperAttentionEN.prototype, "UpdDate", {
            /// <summary>
            /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            get: function () {
                return this.mstrUpdDate;
            },
            /// <summary>
            /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
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
        Object.defineProperty(clsgs_PaperAttentionEN.prototype, "Meno", {
            /// <summary>
            /// 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            get: function () {
                return this.mstrMeno;
            },
            /// <summary>
            /// 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrMeno = value;
                this.hmProperty["Meno"] = true;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsgs_PaperAttentionEN, "con_PaperAttentionId", {
            /// <summary>
            /// 常量:"PaperAttentionId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "PaperAttentionId"; } //论文收藏Id
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsgs_PaperAttentionEN, "con_PaperId", {
            /// <summary>
            /// 常量:"PaperId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "PaperId"; } //论文Id
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsgs_PaperAttentionEN, "con_UserId", {
            /// <summary>
            /// 常量:"UserId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UserId"; } //用户ID
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsgs_PaperAttentionEN, "con_PaperGroupId", {
            /// <summary>
            /// 常量:"PaperGroupId"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "PaperGroupId"; } //组Id
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsgs_PaperAttentionEN, "con_UpdUser", {
            /// <summary>
            /// 常量:"UpdUser"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UpdUser"; } //修改人
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsgs_PaperAttentionEN, "con_UpdDate", {
            /// <summary>
            /// 常量:"UpdDate"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "UpdDate"; } //修改日期
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsgs_PaperAttentionEN, "con_Meno", {
            /// <summary>
            /// 常量:"Meno"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "Meno"; } //备注
            ,
            enumerable: true,
            configurable: true
        });
        clsgs_PaperAttentionEN.prototype.SetCondFldValue = function (strFldName, strFldValue, strComparisonOp) {
            this[strFldName] = strFldValue;
            if (this.dicFldComparisonOp.hasOwnProperty(strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        };
        clsgs_PaperAttentionEN._CurrTabName = "gs_PaperAttention"; //当前表名,与该类相关的表名
        clsgs_PaperAttentionEN._KeyFldName = "PaperAttentionId"; //当前表中的关键字名称,与该类相关的表中关键字名
        clsgs_PaperAttentionEN.mintAttributeCount = 7;
        clsgs_PaperAttentionEN.AttributeName = new Array("PaperAttentionId", "PaperId", "UserId", "PaperGroupId", "UpdUser", "UpdDate", "Meno");
        return clsgs_PaperAttentionEN;
    }(clsGeneralTab_js_1.clsGeneralTab));
    exports.clsgs_PaperAttentionEN = clsgs_PaperAttentionEN;
    ;
    /// <summary>
    /// 论文关注(gs_PaperAttention)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    var clsgs_PaperAttentionEN_Sim = /** @class */ (function () {
        function clsgs_PaperAttentionEN_Sim() {
            //以下是属性变量
            /// <summary>
            /// 论文收藏Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.PaperAttentionId = 0;
            /// <summary>
            /// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.PaperId = "";
            /// <summary>
            /// 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.UserId = "";
            /// <summary>
            /// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.PaperGroupId = "";
            /// <summary>
            /// 修改人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.UpdUser = "";
            /// <summary>
            /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.UpdDate = "";
            /// <summary>
            /// 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.Meno = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
        return clsgs_PaperAttentionEN_Sim;
    }());
    exports.clsgs_PaperAttentionEN_Sim = clsgs_PaperAttentionEN_Sim;
    ;
});
