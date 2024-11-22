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
    exports.clssys_RequestPushEN = void 0;
    /**
    * 类名:clssys_RequestPushEN
    * 表名:sys_RequestPush(01120726)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:11
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培设置(GraduateEduTools)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 请求推送表(sys_RequestPush)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clssys_RequestPushEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngRequestId = 0; //RequestId
            this.mstrRequesTypeId = ""; //请求类型Id
            this.mstrTableKey = ""; //表主键
            this.mstrReceiveUser = ""; //接收用户
            this.mbolIsReply = false; //是否回复
            this.mstrReplyDate = ""; //回复日期
            this.mstrRequestUser = ""; //RequestUser
            this.mstrRequestDate = ""; //RequestDate
            this.mstrRequestStata = ""; //RequestStata
            this.mstrMemo = ""; //备注
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrPushTypeId = ""; //推送类型Id
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.requestId = 0; //RequestId
            this.requesTypeId = ""; //请求类型Id
            this.tableKey = ""; //表主键
            this.receiveUser = ""; //接收用户
            this.isReply = false; //是否回复
            this.replyDate = ""; //回复日期
            this.requestUser = ""; //RequestUser
            this.requestDate = ""; //RequestDate
            this.requestStata = ""; //RequestStata
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
            this.pushTypeId = ""; //推送类型Id
        }
        /**
         * RequestId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRequestId(value) {
            if (value != undefined) {
                this.requestId = value;
                this.hmProperty["requestId"] = true;
            }
        }
        /**
         * 请求类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRequesTypeId(value) {
            if (value != undefined) {
                this.requesTypeId = value;
                this.hmProperty["requesTypeId"] = true;
            }
        }
        /**
         * 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTableKey(value) {
            if (value != undefined) {
                this.tableKey = value;
                this.hmProperty["tableKey"] = true;
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
            }
        }
        /**
         * RequestUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRequestUser(value) {
            if (value != undefined) {
                this.requestUser = value;
                this.hmProperty["requestUser"] = true;
            }
        }
        /**
         * RequestDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRequestDate(value) {
            if (value != undefined) {
                this.requestDate = value;
                this.hmProperty["requestDate"] = true;
            }
        }
        /**
         * RequestStata(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRequestStata(value) {
            if (value != undefined) {
                this.requestStata = value;
                this.hmProperty["requestStata"] = true;
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
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CurrEduCls(value) {
            if (value != undefined) {
                this.id_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
            }
        }
        /**
         * 推送类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPushTypeId(value) {
            if (value != undefined) {
                this.pushTypeId = value;
                this.hmProperty["pushTypeId"] = true;
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
                case clssys_RequestPushEN.con_RequestId:
                    return this.requestId;
                case clssys_RequestPushEN.con_RequesTypeId:
                    return this.requesTypeId;
                case clssys_RequestPushEN.con_TableKey:
                    return this.tableKey;
                case clssys_RequestPushEN.con_ReceiveUser:
                    return this.receiveUser;
                case clssys_RequestPushEN.con_IsReply:
                    return this.isReply;
                case clssys_RequestPushEN.con_ReplyDate:
                    return this.replyDate;
                case clssys_RequestPushEN.con_RequestUser:
                    return this.requestUser;
                case clssys_RequestPushEN.con_RequestDate:
                    return this.requestDate;
                case clssys_RequestPushEN.con_RequestStata:
                    return this.requestStata;
                case clssys_RequestPushEN.con_Memo:
                    return this.memo;
                case clssys_RequestPushEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clssys_RequestPushEN.con_PushTypeId:
                    return this.pushTypeId;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[sys_RequestPush]中不存在！`;
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
                case clssys_RequestPushEN.con_RequestId:
                    this.requestId = Number(strValue);
                    this.hmProperty["requestId"] = true;
                    break;
                case clssys_RequestPushEN.con_RequesTypeId:
                    this.requesTypeId = strValue;
                    this.hmProperty["requesTypeId"] = true;
                    break;
                case clssys_RequestPushEN.con_TableKey:
                    this.tableKey = strValue;
                    this.hmProperty["tableKey"] = true;
                    break;
                case clssys_RequestPushEN.con_ReceiveUser:
                    this.receiveUser = strValue;
                    this.hmProperty["receiveUser"] = true;
                    break;
                case clssys_RequestPushEN.con_IsReply:
                    this.isReply = Boolean(strValue);
                    this.hmProperty["isReply"] = true;
                    break;
                case clssys_RequestPushEN.con_ReplyDate:
                    this.replyDate = strValue;
                    this.hmProperty["replyDate"] = true;
                    break;
                case clssys_RequestPushEN.con_RequestUser:
                    this.requestUser = strValue;
                    this.hmProperty["requestUser"] = true;
                    break;
                case clssys_RequestPushEN.con_RequestDate:
                    this.requestDate = strValue;
                    this.hmProperty["requestDate"] = true;
                    break;
                case clssys_RequestPushEN.con_RequestStata:
                    this.requestStata = strValue;
                    this.hmProperty["requestStata"] = true;
                    break;
                case clssys_RequestPushEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clssys_RequestPushEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clssys_RequestPushEN.con_PushTypeId:
                    this.pushTypeId = strValue;
                    this.hmProperty["pushTypeId"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[sys_RequestPush]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"RequestId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestId() { return "requestId"; } //RequestId
        /**
        * 常量:"RequesTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequesTypeId() { return "requesTypeId"; } //请求类型Id
        /**
        * 常量:"TableKey"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TableKey() { return "tableKey"; } //表主键
        /**
        * 常量:"ReceiveUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReceiveUser() { return "receiveUser"; } //接收用户
        /**
        * 常量:"IsReply"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsReply() { return "isReply"; } //是否回复
        /**
        * 常量:"ReplyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReplyDate() { return "replyDate"; } //回复日期
        /**
        * 常量:"RequestUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestUser() { return "requestUser"; } //RequestUser
        /**
        * 常量:"RequestDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestDate() { return "requestDate"; } //RequestDate
        /**
        * 常量:"RequestStata"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestStata() { return "requestStata"; } //RequestStata
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
        * 常量:"PushTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PushTypeId() { return "pushTypeId"; } //推送类型Id
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
    exports.clssys_RequestPushEN = clssys_RequestPushEN;
    clssys_RequestPushEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clssys_RequestPushEN.CacheModeId = "02"; //客户端缓存
    clssys_RequestPushEN._CurrTabName = "sys_RequestPush"; //当前表名,与该类相关的表名
    clssys_RequestPushEN._KeyFldName = "RequestId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clssys_RequestPushEN.mintAttributeCount = 12;
    clssys_RequestPushEN.AttributeName = ["requestId", "requesTypeId", "tableKey", "receiveUser", "isReply", "replyDate", "requestUser", "requestDate", "requestStata", "memo", "id_CurrEduCls", "pushTypeId"];
});
