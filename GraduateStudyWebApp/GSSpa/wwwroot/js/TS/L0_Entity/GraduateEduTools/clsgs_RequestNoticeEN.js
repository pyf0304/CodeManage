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
    exports.clsgs_RequestNoticeEN_Sim = exports.clsgs_RequestNoticeEN = void 0;
    /**
    * 类名:clsgs_RequestNoticeEN
    * 表名:gs_RequestNotice(01120724)
    * 生成代码版本:2021.10.17.1
    * 生成日期:2021/10/17 11:34:21
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培设置
    * 模块英文名:GraduateEduTools
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 请求通知表(gs_RequestNotice)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsgs_RequestNoticeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mlngRequestId = 0; //requestId
            this.mstrRequesTypeId = ""; //请求类型Id
            this.mstrTableKey = ""; //表主键
            this.mstrReceiveUser = ""; //接收用户
            this.mbolIsReply = false; //是否回复
            this.mstrReplyDate = ""; //回复日期
            this.mstrRequestUser = ""; //requestUser
            this.mstrRequestDate = ""; //requestDate
            this.mstrRequestStata = ""; //requestStata
            this.mstrPushTypeId = ""; //推送类型Id
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrMemo = ""; //备注
        }
        /**
         * requestId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get requestId() {
            return this.mlngRequestId;
        }
        /**
         * requestId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set requestId(value) {
            if (value != undefined) {
                this.mlngRequestId = value;
                this.hmProperty["requestId"] = true;
            }
        }
        /**
         * 请求类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get requesTypeId() {
            return this.mstrRequesTypeId;
        }
        /**
         * 请求类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set requesTypeId(value) {
            if (value != undefined) {
                this.mstrRequesTypeId = value;
                this.hmProperty["requesTypeId"] = true;
            }
        }
        /**
         * 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get tableKey() {
            return this.mstrTableKey;
        }
        /**
         * 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set tableKey(value) {
            if (value != undefined) {
                this.mstrTableKey = value;
                this.hmProperty["tableKey"] = true;
            }
        }
        /**
         * 接收用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get receiveUser() {
            return this.mstrReceiveUser;
        }
        /**
         * 接收用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set receiveUser(value) {
            if (value != undefined) {
                this.mstrReceiveUser = value;
                this.hmProperty["receiveUser"] = true;
            }
        }
        /**
         * 是否回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get isReply() {
            return this.mbolIsReply;
        }
        /**
         * 是否回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set isReply(value) {
            if (value != undefined) {
                this.mbolIsReply = value;
                this.hmProperty["isReply"] = true;
            }
        }
        /**
         * 回复日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get replyDate() {
            return this.mstrReplyDate;
        }
        /**
         * 回复日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set replyDate(value) {
            if (value != undefined) {
                this.mstrReplyDate = value;
                this.hmProperty["replyDate"] = true;
            }
        }
        /**
         * requestUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get requestUser() {
            return this.mstrRequestUser;
        }
        /**
         * requestUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set requestUser(value) {
            if (value != undefined) {
                this.mstrRequestUser = value;
                this.hmProperty["requestUser"] = true;
            }
        }
        /**
         * requestDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get requestDate() {
            return this.mstrRequestDate;
        }
        /**
         * requestDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set requestDate(value) {
            if (value != undefined) {
                this.mstrRequestDate = value;
                this.hmProperty["requestDate"] = true;
            }
        }
        /**
         * requestStata(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get requestStata() {
            return this.mstrRequestStata;
        }
        /**
         * requestStata(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set requestStata(value) {
            if (value != undefined) {
                this.mstrRequestStata = value;
                this.hmProperty["requestStata"] = true;
            }
        }
        /**
         * 推送类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get pushTypeId() {
            return this.mstrPushTypeId;
        }
        /**
         * 推送类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set pushTypeId(value) {
            if (value != undefined) {
                this.mstrPushTypeId = value;
                this.hmProperty["pushTypeId"] = true;
            }
        }
        /**
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_CurrEduCls() {
            return this.mstrid_CurrEduCls;
        }
        /**
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_CurrEduCls(value) {
            if (value != undefined) {
                this.mstrid_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
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
        * 常量:"requestId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestId() { return "requestId"; } //requestId
        /**
        * 常量:"requesTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequesTypeId() { return "requesTypeId"; } //请求类型Id
        /**
        * 常量:"tableKey"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TableKey() { return "tableKey"; } //表主键
        /**
        * 常量:"receiveUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReceiveUser() { return "receiveUser"; } //接收用户
        /**
        * 常量:"isReply"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsReply() { return "isReply"; } //是否回复
        /**
        * 常量:"replyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReplyDate() { return "replyDate"; } //回复日期
        /**
        * 常量:"requestUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestUser() { return "requestUser"; } //requestUser
        /**
        * 常量:"requestDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestDate() { return "requestDate"; } //requestDate
        /**
        * 常量:"requestStata"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestStata() { return "requestStata"; } //requestStata
        /**
        * 常量:"pushTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PushTypeId() { return "pushTypeId"; } //推送类型Id
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            const strThisFuncName = this.SetCondFldValue.name;
            console.log('strThisFuncName', strThisFuncName);
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
    exports.clsgs_RequestNoticeEN = clsgs_RequestNoticeEN;
    clsgs_RequestNoticeEN._CurrTabName = "gs_RequestNotice"; //当前表名,与该类相关的表名
    clsgs_RequestNoticeEN._KeyFldName = "requestId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_RequestNoticeEN.mintAttributeCount = 12;
    clsgs_RequestNoticeEN.AttributeName = ["requestId", "requesTypeId", "tableKey", "receiveUser", "isReply", "replyDate", "requestUser", "requestDate", "requestStata", "pushTypeId", "id_CurrEduCls", "memo"];
    /**
    * 请求通知表(gs_RequestNotice)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsgs_RequestNoticeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * requestId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.requestId = 0;
            /**
             * 请求类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.requesTypeId = "";
            /**
             * 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.tableKey = "";
            /**
             * 接收用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.receiveUser = "";
            /**
             * 是否回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.isReply = false;
            /**
             * 回复日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.replyDate = "";
            /**
             * requestUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.requestUser = "";
            /**
             * requestDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.requestDate = "";
            /**
             * requestStata(说明:;字段类型:varchar;字段长度:10;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.requestStata = "";
            /**
             * 推送类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.pushTypeId = "";
            /**
             * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_CurrEduCls = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsgs_RequestNoticeEN_Sim = clsgs_RequestNoticeEN_Sim;
});
