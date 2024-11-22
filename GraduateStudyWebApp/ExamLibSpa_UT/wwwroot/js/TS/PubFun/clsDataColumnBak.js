/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDataColumn
表名:ExamType(01160053)
生成代码版本:2019.07.19.1
生成日期:2019/07/21 17:06:50
生成者:
工程名称:简单工程样例
工程ID:0116
相关数据库:101.251.68.133,9433SimplePrj
PrjDataBaseId:0111
模块中文名:基本信息
模块英文名:BaseInfo
框架-层名:实体层(EntityLayer)
编程语言:TypeScript
== == == == == == == == == == == ==
*/
/// <summary>
/// 考试类型(ExamType)
/// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
/// </summary>
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var clsDataColumnBak = /** @class */ (function () {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayer4TypeScript:GenClassConstructor1)
        /// </summary>
        function clsDataColumnBak() {
            this.mstrFldName = ""; //考试类型Id
            this.mstrColHeader = ""; //考试类型名
            this.mintOrderNum = 0; //是否删除
            this.mstrColumnType = ""; //列类型：Label,TextBox,Button
            this.mstrFuncName = function () { }; //备注
        }
        Object.defineProperty(clsDataColumnBak.prototype, "FldName", {
            /// <summary>
            /// 考试类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrFldName;
            },
            /// <summary>
            /// 考试类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrFldName = value;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsDataColumnBak.prototype, "ColHeader", {
            /// <summary>
            /// 考试类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrColHeader;
            },
            /// <summary>
            /// 考试类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrColHeader = value;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsDataColumnBak.prototype, "OrderNum", {
            /// <summary>
            /// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mintOrderNum;
            },
            /// <summary>
            /// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mintOrderNum = value;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsDataColumnBak.prototype, "ColumnType", {
            /// <summary>
            /// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            get: function () {
                return this.mstrColumnType;
            },
            /// <summary>
            /// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
            /// </summary>
            set: function (value) {
                this.mstrColumnType = value;
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsDataColumnBak, "con_FldName", {
            /// <summary>
            /// 常量:"FldName"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "FldName"; } //考试类型Id
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsDataColumnBak, "con_ColHeader", {
            /// <summary>
            /// 常量:"ColHeader"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "ColHeader"; } //考试类型名
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsDataColumnBak, "con__IsDeleted", {
            /// <summary>
            /// 常量:"_IsDeleted"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "_IsDeleted"; } //是否删除
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsDataColumnBak, "con_ColumnType", {
            /// <summary>
            /// 常量:"ColumnType"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "ColumnType"; } //删除日期
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsDataColumnBak, "con_Memo", {
            /// <summary>
            /// 常量:"Memo"
            /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            get: function () { return "Memo"; } //备注
            ,
            enumerable: true,
            configurable: true
        });
        return clsDataColumnBak;
    }());
    exports.clsDataColumnBak = clsDataColumnBak;
    ;
});
