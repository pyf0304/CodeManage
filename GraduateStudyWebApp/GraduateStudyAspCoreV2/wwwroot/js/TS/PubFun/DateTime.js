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
    exports.DateTime = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:DateTime
    表名:DateTime(00050565)
    生成代码版本:2020.06.13.1
    生成日期:2020/06/15 19:14:32
    生成者:
    工程名称:AGC
    工程ID:0005
    相关数据库:tzar.tpddns.cn,19433AGC_CS12
    PrjDataBaseId:0213
    模块中文名:系统参数
    模块英文名:SysPara
    框架-层名:纯粹类(PureClass)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    /// <summary>
    /// DateTime(DateTime)
    /// (AutoGCLib.PureClass4TypeScript:GeneCode)
    /// </summary>
    class DateTime {
        constructor() {
            this.mintAttributeCount = 7;
            this.AttributeName = new Array("mId", "year", "month", "Day", "Hour", "Minute", "Second");
            //以下是属性变量
            this.mlngmId = 0; //mId
            this.mintYear = 0; //年
            this.mintMonth = 0; //月
            this.mintDay = 0; //日
            this.mintWeek = 0; //日
            this.mintHour = 0; //时
            this.mintMinute = 0; //分
            this.mintSecond = 0; //秒
        }
        /// <summary>
        /// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        get mId() {
            return this.mlngmId;
        }
        ;
        /// <summary>
        /// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        set mId(value) {
            this.mlngmId = value;
        }
        ;
        /// <summary>
        /// 年(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        get year() {
            return this.mintYear;
        }
        ;
        /// <summary>
        /// 年(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        set year(value) {
            this.mintYear = value;
        }
        ;
        /// <summary>
        /// 月(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        get month() {
            return this.mintMonth;
        }
        ;
        /// <summary>
        /// 月(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        set month(value) {
            this.mintMonth = value;
        }
        ;
        /// <summary>
        /// 日(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        get Day() {
            return this.mintDay;
        }
        ;
        /// <summary>
        /// 日(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        set Day(value) {
            this.mintDay = value;
        }
        ;
        /// <summary>
        /// 日(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        get week() {
            return this.mintWeek;
        }
        ;
        /// <summary>
        /// 日(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        set week(value) {
            this.mintWeek = value;
        }
        ;
        /// <summary>
        /// 时(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        get Hour() {
            return this.mintHour;
        }
        ;
        /// <summary>
        /// 时(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        set Hour(value) {
            this.mintHour = value;
        }
        ;
        /// <summary>
        /// 分(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        get Minute() {
            return this.mintMinute;
        }
        ;
        /// <summary>
        /// 分(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        set Minute(value) {
            this.mintMinute = value;
        }
        ;
        /// <summary>
        /// 秒(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        get Second() {
            return this.mintSecond;
        }
        ;
        /// <summary>
        /// 秒(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.PureClass4TypeScript:Gen_PC_ClsProperty)
        /// </summary>
        set Second(value) {
            this.mintSecond = value;
        }
        ;
        /// <summary>
        /// 常量:"mId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_mId() { return "mId"; } //mId
        /// <summary>
        /// 常量:"year"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Year() { return "year"; } //年
        /// <summary>
        /// 常量:"month"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Month() { return "month"; } //月
        /// <summary>
        /// 常量:"Day"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Day() { return "Day"; } //日
        /// <summary>
        /// 常量:"Hour"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Hour() { return "Hour"; } //时
        /// <summary>
        /// 常量:"Minute"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Minute() { return "Minute"; } //分
        /// <summary>
        /// 常量:"Second"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Second() { return "Second"; } //秒
    }
    exports.DateTime = DateTime;
    DateTime._CurrTabName = "DateTime"; //当前表名,与该类相关的表名
    DateTime._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    ;
});
