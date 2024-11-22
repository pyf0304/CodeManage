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
    exports.clsvMessagePushUsersRelationEN = void 0;
    /**
    * 类名:clsvMessagePushUsersRelationEN
    * 表名:vMessagePushUsersRelation(01120285)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:37
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
    * 消息推送用户关系视图(vMessagePushUsersRelation)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvMessagePushUsersRelationEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.messagePushUsersRelationId = 0; //消息推送与用户关系Id
            this.messagePushId = ""; //消息Id
            this.messagePushNumber = ""; //消息编号
            this.messageTitle = ""; //消息标题
            this.messageContent = ""; //消息内容
            this.messageTypeId = ""; //消息类型Id
            this.isAllpush = false; //是否全体推送
            this.clientVersionTypeId = ""; //客户端版本类型Id
            this.receivePeople = ""; //接收人员
            this.isReceive = false; //是否接收
            this.createTime = ""; //建立时间
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
                case clsvMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                    return this.messagePushUsersRelationId;
                case clsvMessagePushUsersRelationEN.con_MessagePushId:
                    return this.messagePushId;
                case clsvMessagePushUsersRelationEN.con_MessagePushNumber:
                    return this.messagePushNumber;
                case clsvMessagePushUsersRelationEN.con_MessageTitle:
                    return this.messageTitle;
                case clsvMessagePushUsersRelationEN.con_MessageContent:
                    return this.messageContent;
                case clsvMessagePushUsersRelationEN.con_MessageTypeId:
                    return this.messageTypeId;
                case clsvMessagePushUsersRelationEN.con_IsAllpush:
                    return this.isAllpush;
                case clsvMessagePushUsersRelationEN.con_ClientVersionTypeId:
                    return this.clientVersionTypeId;
                case clsvMessagePushUsersRelationEN.con_ReceivePeople:
                    return this.receivePeople;
                case clsvMessagePushUsersRelationEN.con_IsReceive:
                    return this.isReceive;
                case clsvMessagePushUsersRelationEN.con_CreateTime:
                    return this.createTime;
                case clsvMessagePushUsersRelationEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vMessagePushUsersRelation]中不存在！`;
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
                case clsvMessagePushUsersRelationEN.con_MessagePushUsersRelationId:
                    this.messagePushUsersRelationId = Number(strValue);
                    break;
                case clsvMessagePushUsersRelationEN.con_MessagePushId:
                    this.messagePushId = strValue;
                    break;
                case clsvMessagePushUsersRelationEN.con_MessagePushNumber:
                    this.messagePushNumber = strValue;
                    break;
                case clsvMessagePushUsersRelationEN.con_MessageTitle:
                    this.messageTitle = strValue;
                    break;
                case clsvMessagePushUsersRelationEN.con_MessageContent:
                    this.messageContent = strValue;
                    break;
                case clsvMessagePushUsersRelationEN.con_MessageTypeId:
                    this.messageTypeId = strValue;
                    break;
                case clsvMessagePushUsersRelationEN.con_IsAllpush:
                    this.isAllpush = Boolean(strValue);
                    break;
                case clsvMessagePushUsersRelationEN.con_ClientVersionTypeId:
                    this.clientVersionTypeId = strValue;
                    break;
                case clsvMessagePushUsersRelationEN.con_ReceivePeople:
                    this.receivePeople = strValue;
                    break;
                case clsvMessagePushUsersRelationEN.con_IsReceive:
                    this.isReceive = Boolean(strValue);
                    break;
                case clsvMessagePushUsersRelationEN.con_CreateTime:
                    this.createTime = strValue;
                    break;
                case clsvMessagePushUsersRelationEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vMessagePushUsersRelation]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"MessagePushUsersRelationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MessagePushUsersRelationId() { return "messagePushUsersRelationId"; } //消息推送与用户关系Id
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
        * 常量:"clientVersionTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ClientVersionTypeId() { return "clientVersionTypeId"; } //客户端版本类型Id
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
    exports.clsvMessagePushUsersRelationEN = clsvMessagePushUsersRelationEN;
    clsvMessagePushUsersRelationEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvMessagePushUsersRelationEN.CacheModeId = "05"; //未知
    clsvMessagePushUsersRelationEN._CurrTabName = "vMessagePushUsersRelation"; //当前表名,与该类相关的表名
    clsvMessagePushUsersRelationEN._KeyFldName = "MessagePushUsersRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvMessagePushUsersRelationEN.mintAttributeCount = 12;
    clsvMessagePushUsersRelationEN.AttributeName = ["messagePushUsersRelationId", "messagePushId", "messagePushNumber", "messageTitle", "messageContent", "messageTypeId", "isAllpush", "clientVersionTypeId", "receivePeople", "isReceive", "createTime", "memo"];
});
