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
    exports.clsqa_PushEN = void 0;
    /**
    * 类名:clsqa_PushEN
    * 表名:qa_Push(01120640)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:52:42
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:互动管理(InteractManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 答疑推送(qa_Push)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsqa_PushEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngPushId = 0; //推送d
            this.mstrQuestionsId = ""; //提问Id
            this.mstrReceiveUser = ""; //接收用户
            this.mstrReceiveDate = ""; //接收日期
            this.mbolIsReceive = false; //是否接收
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mbolIsReply = false; //是否回复
            this.mbolIsRequestReply = false; //是否要求回复
            this.mstrReplyDate = ""; //回复日期
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.pushId = 0; //推送d
            this.questionsId = ""; //提问Id
            this.receiveUser = ""; //接收用户
            this.receiveDate = ""; //接收日期
            this.isReceive = false; //是否接收
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
            this.isReply = false; //是否回复
            this.isRequestReply = false; //是否要求回复
            this.replyDate = ""; //回复日期
        }
        /**
         * 推送d(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPushId(value) {
            if (value != undefined) {
                this.pushId = value;
                this.hmProperty["pushId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionsId(value) {
            if (value != undefined) {
                this.questionsId = value;
                this.hmProperty["questionsId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 接收用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReceiveUser(value) {
            if (value != undefined) {
                this.receiveUser = value;
                this.hmProperty["receiveUser"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 接收日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReceiveDate(value) {
            if (value != undefined) {
                this.receiveDate = value;
                this.hmProperty["receiveDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CurrEduCls(value) {
            if (value != undefined) {
                this.id_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsReply(value) {
            if (value != undefined) {
                this.isReply = value;
                this.hmProperty["isReply"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否要求回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsRequestReply(value) {
            if (value != undefined) {
                this.isRequestReply = value;
                this.hmProperty["isRequestReply"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 回复日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReplyDate(value) {
            if (value != undefined) {
                this.replyDate = value;
                this.hmProperty["replyDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                case clsqa_PushEN.con_PushId:
                    return this.pushId;
                case clsqa_PushEN.con_QuestionsId:
                    return this.questionsId;
                case clsqa_PushEN.con_ReceiveUser:
                    return this.receiveUser;
                case clsqa_PushEN.con_ReceiveDate:
                    return this.receiveDate;
                case clsqa_PushEN.con_IsReceive:
                    return this.isReceive;
                case clsqa_PushEN.con_UpdDate:
                    return this.updDate;
                case clsqa_PushEN.con_Memo:
                    return this.memo;
                case clsqa_PushEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsqa_PushEN.con_IsReply:
                    return this.isReply;
                case clsqa_PushEN.con_IsRequestReply:
                    return this.isRequestReply;
                case clsqa_PushEN.con_ReplyDate:
                    return this.replyDate;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[qa_Push]中不存在！`;
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
                case clsqa_PushEN.con_PushId:
                    this.pushId = Number(strValue);
                    this.hmProperty["pushId"] = true;
                    break;
                case clsqa_PushEN.con_QuestionsId:
                    this.questionsId = strValue;
                    this.hmProperty["questionsId"] = true;
                    break;
                case clsqa_PushEN.con_ReceiveUser:
                    this.receiveUser = strValue;
                    this.hmProperty["receiveUser"] = true;
                    break;
                case clsqa_PushEN.con_ReceiveDate:
                    this.receiveDate = strValue;
                    this.hmProperty["receiveDate"] = true;
                    break;
                case clsqa_PushEN.con_IsReceive:
                    this.isReceive = Boolean(strValue);
                    this.hmProperty["isReceive"] = true;
                    break;
                case clsqa_PushEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsqa_PushEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsqa_PushEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsqa_PushEN.con_IsReply:
                    this.isReply = Boolean(strValue);
                    this.hmProperty["isReply"] = true;
                    break;
                case clsqa_PushEN.con_IsRequestReply:
                    this.isRequestReply = Boolean(strValue);
                    this.hmProperty["isRequestReply"] = true;
                    break;
                case clsqa_PushEN.con_ReplyDate:
                    this.replyDate = strValue;
                    this.hmProperty["replyDate"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[qa_Push]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PushId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PushId() { return "pushId"; } //推送d
        /**
        * 常量:"QuestionsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsId() { return "questionsId"; } //提问Id
        /**
        * 常量:"ReceiveUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReceiveUser() { return "receiveUser"; } //接收用户
        /**
        * 常量:"ReceiveDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReceiveDate() { return "receiveDate"; } //接收日期
        /**
        * 常量:"IsReceive"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsReceive() { return "isReceive"; } //是否接收
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
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"IsReply"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsReply() { return "isReply"; } //是否回复
        /**
        * 常量:"IsRequestReply"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRequestReply() { return "isRequestReply"; } //是否要求回复
        /**
        * 常量:"ReplyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReplyDate() { return "replyDate"; } //回复日期
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
    exports.clsqa_PushEN = clsqa_PushEN;
    clsqa_PushEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsqa_PushEN.CacheModeId = "05"; //未知
    clsqa_PushEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsqa_PushEN.WhereFormat = ""; //条件格式串
    clsqa_PushEN._CurrTabName = "qa_Push"; //当前表名,与该类相关的表名
    clsqa_PushEN._KeyFldName = "PushId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsqa_PushEN.mintAttributeCount = 11;
    clsqa_PushEN.AttributeName = ["pushId", "questionsId", "receiveUser", "receiveDate", "isReceive", "updDate", "memo", "id_CurrEduCls", "isReply", "isRequestReply", "replyDate"];
});
