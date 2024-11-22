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
    exports.clsLoginLogEN = void 0;
    /**
    * 类名:clsLoginLogEN
    * 表名:LoginLog(01120357)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:45:58
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:日志管理(LogManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 登录日志(LoginLog)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsLoginLogEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngLoginLogId = 0; //LoginLogId
            this.mstrLoginLogNumber = ""; //LoginLogNumber
            this.mstrLoginIP = ""; //LoginIP
            this.mstrFailReason = ""; //FailReason
            this.mstrLoginResult = ""; //LoginResult
            this.mstrLoginTime = ""; //LoginTime
            this.mstrLoginUserId = ""; //LoginUserId
            this.mstrMemo = ""; //备注
            this.mstrOnlineTime = ""; //OnlineTime
            this.mstrOutTime = ""; //OutTime
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.loginLogId = 0; //LoginLogId
            this.loginLogNumber = ""; //LoginLogNumber
            this.loginIP = ""; //LoginIP
            this.failReason = ""; //FailReason
            this.loginResult = ""; //LoginResult
            this.loginTime = ""; //LoginTime
            this.loginUserId = ""; //LoginUserId
            this.memo = ""; //备注
            this.onlineTime = ""; //OnlineTime
            this.outTime = ""; //OutTime
        }
        /**
         * LoginLogId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLoginLogId(value) {
            if (value != undefined) {
                this.loginLogId = value;
                this.hmProperty["loginLogId"] = true;
            }
        }
        /**
         * LoginLogNumber(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLoginLogNumber(value) {
            if (value != undefined) {
                this.loginLogNumber = value;
                this.hmProperty["loginLogNumber"] = true;
            }
        }
        /**
         * LoginIP(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLoginIP(value) {
            if (value != undefined) {
                this.loginIP = value;
                this.hmProperty["loginIP"] = true;
            }
        }
        /**
         * FailReason(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetFailReason(value) {
            if (value != undefined) {
                this.failReason = value;
                this.hmProperty["failReason"] = true;
            }
        }
        /**
         * LoginResult(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLoginResult(value) {
            if (value != undefined) {
                this.loginResult = value;
                this.hmProperty["loginResult"] = true;
            }
        }
        /**
         * LoginTime(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLoginTime(value) {
            if (value != undefined) {
                this.loginTime = value;
                this.hmProperty["loginTime"] = true;
            }
        }
        /**
         * LoginUserId(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLoginUserId(value) {
            if (value != undefined) {
                this.loginUserId = value;
                this.hmProperty["loginUserId"] = true;
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
         * OnlineTime(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOnlineTime(value) {
            if (value != undefined) {
                this.onlineTime = value;
                this.hmProperty["onlineTime"] = true;
            }
        }
        /**
         * OutTime(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOutTime(value) {
            if (value != undefined) {
                this.outTime = value;
                this.hmProperty["outTime"] = true;
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
                case clsLoginLogEN.con_LoginLogId:
                    return this.loginLogId;
                case clsLoginLogEN.con_LoginLogNumber:
                    return this.loginLogNumber;
                case clsLoginLogEN.con_LoginIP:
                    return this.loginIP;
                case clsLoginLogEN.con_FailReason:
                    return this.failReason;
                case clsLoginLogEN.con_LoginResult:
                    return this.loginResult;
                case clsLoginLogEN.con_LoginTime:
                    return this.loginTime;
                case clsLoginLogEN.con_LoginUserId:
                    return this.loginUserId;
                case clsLoginLogEN.con_Memo:
                    return this.memo;
                case clsLoginLogEN.con_OnlineTime:
                    return this.onlineTime;
                case clsLoginLogEN.con_OutTime:
                    return this.outTime;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[LoginLog]中不存在！`;
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
                case clsLoginLogEN.con_LoginLogId:
                    this.loginLogId = Number(strValue);
                    this.hmProperty["loginLogId"] = true;
                    break;
                case clsLoginLogEN.con_LoginLogNumber:
                    this.loginLogNumber = strValue;
                    this.hmProperty["loginLogNumber"] = true;
                    break;
                case clsLoginLogEN.con_LoginIP:
                    this.loginIP = strValue;
                    this.hmProperty["loginIP"] = true;
                    break;
                case clsLoginLogEN.con_FailReason:
                    this.failReason = strValue;
                    this.hmProperty["failReason"] = true;
                    break;
                case clsLoginLogEN.con_LoginResult:
                    this.loginResult = strValue;
                    this.hmProperty["loginResult"] = true;
                    break;
                case clsLoginLogEN.con_LoginTime:
                    this.loginTime = strValue;
                    this.hmProperty["loginTime"] = true;
                    break;
                case clsLoginLogEN.con_LoginUserId:
                    this.loginUserId = strValue;
                    this.hmProperty["loginUserId"] = true;
                    break;
                case clsLoginLogEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsLoginLogEN.con_OnlineTime:
                    this.onlineTime = strValue;
                    this.hmProperty["onlineTime"] = true;
                    break;
                case clsLoginLogEN.con_OutTime:
                    this.outTime = strValue;
                    this.hmProperty["outTime"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[LoginLog]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"LoginLogId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LoginLogId() { return "loginLogId"; } //LoginLogId
        /**
        * 常量:"LoginLogNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LoginLogNumber() { return "loginLogNumber"; } //LoginLogNumber
        /**
        * 常量:"LoginIP"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LoginIP() { return "loginIP"; } //LoginIP
        /**
        * 常量:"FailReason"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FailReason() { return "failReason"; } //FailReason
        /**
        * 常量:"LoginResult"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LoginResult() { return "loginResult"; } //LoginResult
        /**
        * 常量:"LoginTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LoginTime() { return "loginTime"; } //LoginTime
        /**
        * 常量:"LoginUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LoginUserId() { return "loginUserId"; } //LoginUserId
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"OnlineTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OnlineTime() { return "onlineTime"; } //OnlineTime
        /**
        * 常量:"OutTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OutTime() { return "outTime"; } //OutTime
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
    exports.clsLoginLogEN = clsLoginLogEN;
    clsLoginLogEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsLoginLogEN.CacheModeId = "02"; //客户端缓存
    clsLoginLogEN._CurrTabName = "LoginLog"; //当前表名,与该类相关的表名
    clsLoginLogEN._KeyFldName = "LoginLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsLoginLogEN.mintAttributeCount = 10;
    clsLoginLogEN.AttributeName = ["loginLogId", "loginLogNumber", "loginIP", "failReason", "loginResult", "loginTime", "loginUserId", "memo", "onlineTime", "outTime"];
});
