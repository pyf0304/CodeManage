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
    exports.clsMessagePushEN = void 0;
    /**
    * 类名:clsMessagePushEN
    * 表名:MessagePush(01120280)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 16:13:46
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
    * 消息推送(MessagePush)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsMessagePushEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrMessagePushId = ""; //消息Id
            this.mstrMessagePushNumber = ""; //消息编号
            this.mstrMessageTitle = ""; //消息标题
            this.mstrMessageContent = ""; //消息内容
            this.mstrReceivePeople = ""; //接收人员
            this.mstrMessageTypeId = ""; //消息类型Id
            this.mbolIsAllpush = false; //是否全体推送
            this.mbolIsReceive = false; //是否接收
            this.mstrClientVersionTypeId = ""; //客户端版本类型Id
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.messagePushId = ""; //消息Id
            this.messagePushNumber = ""; //消息编号
            this.messageTitle = ""; //消息标题
            this.messageContent = ""; //消息内容
            this.receivePeople = ""; //接收人员
            this.messageTypeId = ""; //消息类型Id
            this.isAllpush = false; //是否全体推送
            this.isReceive = false; //是否接收
            this.clientVersionTypeId = ""; //客户端版本类型Id
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
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
         * 消息编号(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMessagePushNumber(value) {
            if (value != undefined) {
                this.messagePushNumber = value;
                this.hmProperty["messagePushNumber"] = true;
            }
        }
        /**
         * 消息标题(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMessageTitle(value) {
            if (value != undefined) {
                this.messageTitle = value;
                this.hmProperty["messageTitle"] = true;
            }
        }
        /**
         * 消息内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMessageContent(value) {
            if (value != undefined) {
                this.messageContent = value;
                this.hmProperty["messageContent"] = true;
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
         * 消息类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMessageTypeId(value) {
            if (value != undefined) {
                this.messageTypeId = value;
                this.hmProperty["messageTypeId"] = true;
            }
        }
        /**
         * 是否全体推送(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsAllpush(value) {
            if (value != undefined) {
                this.isAllpush = value;
                this.hmProperty["isAllpush"] = true;
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
         * 客户端版本类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetClientVersionTypeId(value) {
            if (value != undefined) {
                this.clientVersionTypeId = value;
                this.hmProperty["clientVersionTypeId"] = true;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdDate(value) {
            if (value != undefined) {
                this.updDate = value;
                this.hmProperty["updDate"] = true;
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
                case clsMessagePushEN.con_MessagePushId:
                    return this.messagePushId;
                case clsMessagePushEN.con_MessagePushNumber:
                    return this.messagePushNumber;
                case clsMessagePushEN.con_MessageTitle:
                    return this.messageTitle;
                case clsMessagePushEN.con_MessageContent:
                    return this.messageContent;
                case clsMessagePushEN.con_ReceivePeople:
                    return this.receivePeople;
                case clsMessagePushEN.con_MessageTypeId:
                    return this.messageTypeId;
                case clsMessagePushEN.con_IsAllpush:
                    return this.isAllpush;
                case clsMessagePushEN.con_IsReceive:
                    return this.isReceive;
                case clsMessagePushEN.con_ClientVersionTypeId:
                    return this.clientVersionTypeId;
                case clsMessagePushEN.con_UpdDate:
                    return this.updDate;
                case clsMessagePushEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[MessagePush]中不存在！`;
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
                case clsMessagePushEN.con_MessagePushId:
                    this.messagePushId = strValue;
                    this.hmProperty["messagePushId"] = true;
                    break;
                case clsMessagePushEN.con_MessagePushNumber:
                    this.messagePushNumber = strValue;
                    this.hmProperty["messagePushNumber"] = true;
                    break;
                case clsMessagePushEN.con_MessageTitle:
                    this.messageTitle = strValue;
                    this.hmProperty["messageTitle"] = true;
                    break;
                case clsMessagePushEN.con_MessageContent:
                    this.messageContent = strValue;
                    this.hmProperty["messageContent"] = true;
                    break;
                case clsMessagePushEN.con_ReceivePeople:
                    this.receivePeople = strValue;
                    this.hmProperty["receivePeople"] = true;
                    break;
                case clsMessagePushEN.con_MessageTypeId:
                    this.messageTypeId = strValue;
                    this.hmProperty["messageTypeId"] = true;
                    break;
                case clsMessagePushEN.con_IsAllpush:
                    this.isAllpush = Boolean(strValue);
                    this.hmProperty["isAllpush"] = true;
                    break;
                case clsMessagePushEN.con_IsReceive:
                    this.isReceive = Boolean(strValue);
                    this.hmProperty["isReceive"] = true;
                    break;
                case clsMessagePushEN.con_ClientVersionTypeId:
                    this.clientVersionTypeId = strValue;
                    this.hmProperty["clientVersionTypeId"] = true;
                    break;
                case clsMessagePushEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsMessagePushEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[MessagePush]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"messagePushId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessagePushId() { return "messagePushId"; } //消息Id
        /**
        * 常量:"messagePushNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessagePushNumber() { return "messagePushNumber"; } //消息编号
        /**
        * 常量:"messageTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessageTitle() { return "messageTitle"; } //消息标题
        /**
        * 常量:"MessageContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessageContent() { return "messageContent"; } //消息内容
        /**
        * 常量:"receivePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReceivePeople() { return "receivePeople"; } //接收人员
        /**
        * 常量:"messageTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessageTypeId() { return "messageTypeId"; } //消息类型Id
        /**
        * 常量:"isAllpush"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsAllpush() { return "isAllpush"; } //是否全体推送
        /**
        * 常量:"IsReceive"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsReceive() { return "isReceive"; } //是否接收
        /**
        * 常量:"clientVersionTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ClientVersionTypeId() { return "clientVersionTypeId"; } //客户端版本类型Id
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
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
    exports.clsMessagePushEN = clsMessagePushEN;
    clsMessagePushEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsMessagePushEN.CacheModeId = "05"; //未知
    clsMessagePushEN._CurrTabName = "MessagePush"; //当前表名,与该类相关的表名
    clsMessagePushEN._KeyFldName = "messagePushId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsMessagePushEN.mintAttributeCount = 11;
    clsMessagePushEN.AttributeName = ["messagePushId", "messagePushNumber", "messageTitle", "messageContent", "receivePeople", "messageTypeId", "isAllpush", "isReceive", "clientVersionTypeId", "updDate", "memo"];
});
