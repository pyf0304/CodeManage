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
    exports.clsMessagePushUsersRelationEN = void 0;
    /**
    * 类名:clsMessagePushUsersRelationEN
    * 表名:MessagePushUsersRelation(01120284)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:18
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:新闻公告(NewsAnnouncement)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 消息推送与用户关系(MessagePushUsersRelation)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsMessagePushUsersRelationEN extends clsGeneralTab_js_1.clsGeneralTab {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            /**
             * 设置对象中私有属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPrivateVar)
            */
            this.mlngMessagePushUsersRelationId = 0; //消息推送用户关系Id
            this.mstrMessagePushId = ""; //消息Id
            this.mstrReceivePeople = ""; //接收人员
            this.mbolIsReceive = false; //是否接收
            this.mstrCreateTime = ""; //建立时间
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.messagePushUsersRelationId = 0; //消息推送用户关系Id
            this.messagePushId = ""; //消息Id
            this.receivePeople = ""; //接收人员
            this.isReceive = false; //是否接收
            this.createTime = ""; //建立时间
            this.memo = ""; //备注
        }
        /**
         * 消息推送用户关系Id(说明:;字段类型:bigint identity;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMessagePushUsersRelationId(value) {
            if (value != undefined) {
                this.messagePushUsersRelationId = value;
                this.hmProperty["messagePushUsersRelationId"] = true;
            }
        }
        /**
         * 消息Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMessagePushId(value) {
            if (value != undefined) {
                this.messagePushId = value;
                this.hmProperty["messagePushId"] = true;
            }
        }
        /**
         * 接收人员(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReceivePeople(value) {
            if (value != undefined) {
                this.receivePeople = value;
                this.hmProperty["receivePeople"] = true;
            }
        }
        /**
         * 是否接收(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsReceive(value) {
            if (value != undefined) {
                this.isReceive = value;
                this.hmProperty["isReceive"] = true;
            }
        }
        /**
         * 建立时间(说明:;字段类型:varchar;字段长度:16;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCreateTime(value) {
            if (value != undefined) {
                this.createTime = value;
                this.hmProperty["createTime"] = true;
            }
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMemo(value) {
            if (value != undefined) {
                this.memo = value;
                this.hmProperty["memo"] = true;
            }
        }
        /**
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                    return this.messagePushUsersRelationId;
                case clsMessagePushUsersRelationEN.con_MessagePushId:
                    return this.messagePushId;
                case clsMessagePushUsersRelationEN.con_ReceivePeople:
                    return this.receivePeople;
                case clsMessagePushUsersRelationEN.con_IsReceive:
                    return this.isReceive;
                case clsMessagePushUsersRelationEN.con_CreateTime:
                    return this.createTime;
                case clsMessagePushUsersRelationEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[MessagePushUsersRelation]中不存在！`;
                    console.error(strMsg);
                    return "";
            }
        }
        /**
         * 设置对象中某字段名的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetFldValue)
         * @param strFldName:字段名
         * @param strValue:字段值
         * @returns 字段值
        */
        SetFldValue(strFldName, strValue) {
            const strThisFuncName = "SetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                    this.messagePushUsersRelationId = Number(strValue);
                    this.hmProperty["messagePushUsersRelationId"] = true;
                    break;
                case clsMessagePushUsersRelationEN.con_MessagePushId:
                    this.messagePushId = strValue;
                    this.hmProperty["messagePushId"] = true;
                    break;
                case clsMessagePushUsersRelationEN.con_ReceivePeople:
                    this.receivePeople = strValue;
                    this.hmProperty["receivePeople"] = true;
                    break;
                case clsMessagePushUsersRelationEN.con_IsReceive:
                    this.isReceive = Boolean(strValue);
                    this.hmProperty["isReceive"] = true;
                    break;
                case clsMessagePushUsersRelationEN.con_CreateTime:
                    this.createTime = strValue;
                    this.hmProperty["createTime"] = true;
                    break;
                case clsMessagePushUsersRelationEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[MessagePushUsersRelation]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"MessagePushUsersRelationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessagePushUsersRelationId() { return "messagePushUsersRelationId"; } //消息推送用户关系Id
        /**
        * 常量:"messagePushId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessagePushId() { return "messagePushId"; } //消息Id
        /**
        * 常量:"receivePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReceivePeople() { return "receivePeople"; } //接收人员
        /**
        * 常量:"IsReceive"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsReceive() { return "isReceive"; } //是否接收
        /**
        * 常量:"CreateTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateTime() { return "createTime"; } //建立时间
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 设置条件字段值.
        * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetCondFldValue)
        * @param strFldName:字段名
        * @param strFldValue:字段值
        * @param strComparisonOp:比较操作条符
        * @returns 根据关键字获取的名称
        **/
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            const strThisFuncName = this.SetCondFldValue.name;
            this.SetFldValue(strFldName, strFldValue);
            if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsMessagePushUsersRelationEN = clsMessagePushUsersRelationEN;
    clsMessagePushUsersRelationEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsMessagePushUsersRelationEN.CacheModeId = "05"; //未知
    clsMessagePushUsersRelationEN._CurrTabName = "MessagePushUsersRelation"; //当前表名,与该类相关的表名
    clsMessagePushUsersRelationEN._KeyFldName = "MessagePushUsersRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsMessagePushUsersRelationEN.mintAttributeCount = 6;
    clsMessagePushUsersRelationEN.AttributeName = ["messagePushUsersRelationId", "messagePushId", "receivePeople", "isReceive", "createTime", "memo"];
});
