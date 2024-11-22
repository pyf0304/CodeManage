(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTabV.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvMessagePushEN = void 0;
    /**
    * 类名:clsvMessagePushEN
    * 表名:vMessagePush(01120282)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:46:38
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
    * 消息推送视图(vMessagePush)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvMessagePushEN extends clsGeneralTabV_js_1.clsGeneralTabV {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
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
            this.messageTypeName = ""; //消息类型名称
            this.isAllpush = false; //是否全体推送
            this.isReceive = false; //是否接收
            this.clientVersionTypeId = ""; //客户端版本类型Id
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
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
                case clsvMessagePushEN.con_MessagePushId:
                    return this.messagePushId;
                case clsvMessagePushEN.con_MessagePushNumber:
                    return this.messagePushNumber;
                case clsvMessagePushEN.con_MessageTitle:
                    return this.messageTitle;
                case clsvMessagePushEN.con_MessageContent:
                    return this.messageContent;
                case clsvMessagePushEN.con_ReceivePeople:
                    return this.receivePeople;
                case clsvMessagePushEN.con_MessageTypeId:
                    return this.messageTypeId;
                case clsvMessagePushEN.con_MessageTypeName:
                    return this.messageTypeName;
                case clsvMessagePushEN.con_IsAllpush:
                    return this.isAllpush;
                case clsvMessagePushEN.con_IsReceive:
                    return this.isReceive;
                case clsvMessagePushEN.con_ClientVersionTypeId:
                    return this.clientVersionTypeId;
                case clsvMessagePushEN.con_UpdDate:
                    return this.updDate;
                case clsvMessagePushEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vMessagePush]中不存在！`;
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
                case clsvMessagePushEN.con_MessagePushId:
                    this.messagePushId = strValue;
                    break;
                case clsvMessagePushEN.con_MessagePushNumber:
                    this.messagePushNumber = strValue;
                    break;
                case clsvMessagePushEN.con_MessageTitle:
                    this.messageTitle = strValue;
                    break;
                case clsvMessagePushEN.con_MessageContent:
                    this.messageContent = strValue;
                    break;
                case clsvMessagePushEN.con_ReceivePeople:
                    this.receivePeople = strValue;
                    break;
                case clsvMessagePushEN.con_MessageTypeId:
                    this.messageTypeId = strValue;
                    break;
                case clsvMessagePushEN.con_MessageTypeName:
                    this.messageTypeName = strValue;
                    break;
                case clsvMessagePushEN.con_IsAllpush:
                    this.isAllpush = Boolean(strValue);
                    break;
                case clsvMessagePushEN.con_IsReceive:
                    this.isReceive = Boolean(strValue);
                    break;
                case clsvMessagePushEN.con_ClientVersionTypeId:
                    this.clientVersionTypeId = strValue;
                    break;
                case clsvMessagePushEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvMessagePushEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vMessagePush]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"MessagePushId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessagePushId() { return "messagePushId"; } //消息Id
        /**
        * 常量:"MessagePushNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessagePushNumber() { return "messagePushNumber"; } //消息编号
        /**
        * 常量:"MessageTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessageTitle() { return "messageTitle"; } //消息标题
        /**
        * 常量:"MessageContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessageContent() { return "messageContent"; } //消息内容
        /**
        * 常量:"ReceivePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReceivePeople() { return "receivePeople"; } //接收人员
        /**
        * 常量:"MessageTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessageTypeId() { return "messageTypeId"; } //消息类型Id
        /**
        * 常量:"MessageTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessageTypeName() { return "messageTypeName"; } //消息类型名称
        /**
        * 常量:"IsAllpush"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsAllpush() { return "isAllpush"; } //是否全体推送
        /**
        * 常量:"IsReceive"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsReceive() { return "isReceive"; } //是否接收
        /**
        * 常量:"ClientVersionTypeId"
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
    exports.clsvMessagePushEN = clsvMessagePushEN;
    clsvMessagePushEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvMessagePushEN.CacheModeId = "02"; //客户端缓存
    clsvMessagePushEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvMessagePushEN.WhereFormat = ""; //条件格式串
    clsvMessagePushEN._CurrTabName = "vMessagePush"; //当前表名,与该类相关的表名
    clsvMessagePushEN._KeyFldName = "MessagePushId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvMessagePushEN.mintAttributeCount = 12;
    clsvMessagePushEN.AttributeName = ["messagePushId", "messagePushNumber", "messageTitle", "messageContent", "receivePeople", "messageTypeId", "messageTypeName", "isAllpush", "isReceive", "clientVersionTypeId", "updDate", "memo"];
});
