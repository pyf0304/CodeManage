(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsMessagePushTypeEN_Sim = exports.clsMessagePushTypeEN = void 0;
    /**
    * 类名:clsMessagePushTypeEN
    * 表名:MessagePushType(01120281)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:05:50
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:新闻公告
    * 模块英文名:NewsAnnouncement
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 消息类型(MessagePushType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsMessagePushTypeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrMessageTypeId = ""; //消息类型Id
            this.mstrMessageTypeName = ""; //消息类型名称
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
        }
        /**
         * 消息类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get messageTypeId() {
            return this.mstrMessageTypeId;
        }
        /**
         * 消息类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set messageTypeId(value) {
            if (value != undefined) {
                this.mstrMessageTypeId = value;
                this.hmProperty["messageTypeId"] = true;
            }
        }
        /**
         * 消息类型名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get MessageTypeName() {
            return this.mstrMessageTypeName;
        }
        /**
         * 消息类型名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set MessageTypeName(value) {
            if (value != undefined) {
                this.mstrMessageTypeName = value;
                this.hmProperty["MessageTypeName"] = true;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get updDate() {
            return this.mstrUpdDate;
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set updDate(value) {
            if (value != undefined) {
                this.mstrUpdDate = value;
                this.hmProperty["updDate"] = true;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get updUser() {
            return this.mstrUpdUser;
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set updUser(value) {
            if (value != undefined) {
                this.mstrUpdUser = value;
                this.hmProperty["updUser"] = true;
            }
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get memo() {
            return this.mstrMemo;
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set memo(value) {
            if (value != undefined) {
                this.mstrMemo = value;
                this.hmProperty["memo"] = true;
            }
        }
        /**
        * 常量:"messageTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessageTypeId() { return "messageTypeId"; } //消息类型Id
        /**
        * 常量:"MessageTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessageTypeName() { return "MessageTypeName"; } //消息类型名称
        /**
        * 常量:"updDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"updUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            this[strFldName] = strFldValue;
            if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsMessagePushTypeEN = clsMessagePushTypeEN;
    clsMessagePushTypeEN._CurrTabName = "MessagePushType"; //当前表名,与该类相关的表名
    clsMessagePushTypeEN._KeyFldName = "messageTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsMessagePushTypeEN.mintAttributeCount = 5;
    clsMessagePushTypeEN.AttributeName = ["messageTypeId", "MessageTypeName", "updDate", "updUser", "memo"];
    /**
    * 消息类型(MessagePushType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsMessagePushTypeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 消息类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.messageTypeId = "";
            /**
             * 消息类型名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.MessageTypeName = "";
            /**
             * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updDate = "";
            /**
             * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updUser = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsMessagePushTypeEN_Sim = clsMessagePushTypeEN_Sim;
});
