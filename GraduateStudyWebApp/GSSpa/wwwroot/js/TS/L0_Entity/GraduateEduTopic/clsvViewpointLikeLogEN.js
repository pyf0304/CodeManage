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
    exports.clsvViewpointLikeLogEN = void 0;
    /**
    * 类名:clsvViewpointLikeLogEN
    * 表名:vViewpointLikeLog(01120608)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:48
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * vViewpointLikeLog(vViewpointLikeLog)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvViewpointLikeLogEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.memo = ""; //备注
            this.updUserId = ""; //修改用户Id
            this.updDate = ""; //修改日期
            this.viewpointId = ""; //观点Id
            this.viewpointLikeLogId = 0; //观点点赞Id
            this.viewpointName = ""; //观点名称
            this.viewpointContent = ""; //观点内容
            this.reason = ""; //理由
            this.userName = ""; //用户名
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
                case clsvViewpointLikeLogEN.con_Memo:
                    return this.memo;
                case clsvViewpointLikeLogEN.con_UpdUserId:
                    return this.updUserId;
                case clsvViewpointLikeLogEN.con_UpdDate:
                    return this.updDate;
                case clsvViewpointLikeLogEN.con_ViewpointId:
                    return this.viewpointId;
                case clsvViewpointLikeLogEN.con_ViewpointLikeLogId:
                    return this.viewpointLikeLogId;
                case clsvViewpointLikeLogEN.con_ViewpointName:
                    return this.viewpointName;
                case clsvViewpointLikeLogEN.con_ViewpointContent:
                    return this.viewpointContent;
                case clsvViewpointLikeLogEN.con_Reason:
                    return this.reason;
                case clsvViewpointLikeLogEN.con_UserName:
                    return this.userName;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpointLikeLog]中不存在！`;
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
                case clsvViewpointLikeLogEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvViewpointLikeLogEN.con_UpdUserId:
                    this.updUserId = strValue;
                    break;
                case clsvViewpointLikeLogEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvViewpointLikeLogEN.con_ViewpointId:
                    this.viewpointId = strValue;
                    break;
                case clsvViewpointLikeLogEN.con_ViewpointLikeLogId:
                    this.viewpointLikeLogId = Number(strValue);
                    break;
                case clsvViewpointLikeLogEN.con_ViewpointName:
                    this.viewpointName = strValue;
                    break;
                case clsvViewpointLikeLogEN.con_ViewpointContent:
                    this.viewpointContent = strValue;
                    break;
                case clsvViewpointLikeLogEN.con_Reason:
                    this.reason = strValue;
                    break;
                case clsvViewpointLikeLogEN.con_UserName:
                    this.userName = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpointLikeLog]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"UpdUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"ViewpointId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointId() { return "viewpointId"; } //观点Id
        /**
        * 常量:"ViewpointLikeLogId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointLikeLogId() { return "viewpointLikeLogId"; } //观点点赞Id
        /**
        * 常量:"ViewpointName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointName() { return "viewpointName"; } //观点名称
        /**
        * 常量:"ViewpointContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointContent() { return "viewpointContent"; } //观点内容
        /**
        * 常量:"Reason"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Reason() { return "reason"; } //理由
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
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
    exports.clsvViewpointLikeLogEN = clsvViewpointLikeLogEN;
    clsvViewpointLikeLogEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvViewpointLikeLogEN.CacheModeId = "02"; //客户端缓存
    clsvViewpointLikeLogEN._CurrTabName = "vViewpointLikeLog"; //当前表名,与该类相关的表名
    clsvViewpointLikeLogEN._KeyFldName = "ViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvViewpointLikeLogEN.mintAttributeCount = 9;
    clsvViewpointLikeLogEN.AttributeName = ["memo", "updUserId", "updDate", "viewpointId", "viewpointLikeLogId", "viewpointName", "viewpointContent", "reason", "userName"];
});
