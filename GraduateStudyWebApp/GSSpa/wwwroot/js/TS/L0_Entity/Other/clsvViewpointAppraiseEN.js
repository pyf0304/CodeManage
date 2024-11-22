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
    exports.clsvViewpointAppraiseEN = void 0;
    /**
    * 类名:clsvViewpointAppraiseEN
    * 表名:vViewpointAppraise(01120610)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:35
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:其他(Other)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * vViewpointAppraise(vViewpointAppraise)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvViewpointAppraiseEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.userName = ""; //用户名
            this.viewpointAppraiseId = 0; //观点评论Id
            this.viewpointId = ""; //观点Id
            this.appraiseContent = ""; //评议内容
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.viewpointName = ""; //观点名称
            this.viewpointContent = ""; //观点内容
            this.reason = ""; //理由
            this.updUser = ""; //修改人
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
                case clsvViewpointAppraiseEN.con_UserName:
                    return this.userName;
                case clsvViewpointAppraiseEN.con_ViewpointAppraiseId:
                    return this.viewpointAppraiseId;
                case clsvViewpointAppraiseEN.con_ViewpointId:
                    return this.viewpointId;
                case clsvViewpointAppraiseEN.con_AppraiseContent:
                    return this.appraiseContent;
                case clsvViewpointAppraiseEN.con_UpdDate:
                    return this.updDate;
                case clsvViewpointAppraiseEN.con_Memo:
                    return this.memo;
                case clsvViewpointAppraiseEN.con_ViewpointName:
                    return this.viewpointName;
                case clsvViewpointAppraiseEN.con_ViewpointContent:
                    return this.viewpointContent;
                case clsvViewpointAppraiseEN.con_Reason:
                    return this.reason;
                case clsvViewpointAppraiseEN.con_UpdUser:
                    return this.updUser;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpointAppraise]中不存在！`;
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
                case clsvViewpointAppraiseEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvViewpointAppraiseEN.con_ViewpointAppraiseId:
                    this.viewpointAppraiseId = Number(strValue);
                    break;
                case clsvViewpointAppraiseEN.con_ViewpointId:
                    this.viewpointId = strValue;
                    break;
                case clsvViewpointAppraiseEN.con_AppraiseContent:
                    this.appraiseContent = strValue;
                    break;
                case clsvViewpointAppraiseEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvViewpointAppraiseEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvViewpointAppraiseEN.con_ViewpointName:
                    this.viewpointName = strValue;
                    break;
                case clsvViewpointAppraiseEN.con_ViewpointContent:
                    this.viewpointContent = strValue;
                    break;
                case clsvViewpointAppraiseEN.con_Reason:
                    this.reason = strValue;
                    break;
                case clsvViewpointAppraiseEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpointAppraise]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"ViewpointAppraiseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointAppraiseId() { return "viewpointAppraiseId"; } //观点评论Id
        /**
        * 常量:"ViewpointId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointId() { return "viewpointId"; } //观点Id
        /**
        * 常量:"AppraiseContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseContent() { return "appraiseContent"; } //评议内容
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
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
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
    exports.clsvViewpointAppraiseEN = clsvViewpointAppraiseEN;
    clsvViewpointAppraiseEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvViewpointAppraiseEN.CacheModeId = "02"; //客户端缓存
    clsvViewpointAppraiseEN._CurrTabName = "vViewpointAppraise"; //当前表名,与该类相关的表名
    clsvViewpointAppraiseEN._KeyFldName = "ViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvViewpointAppraiseEN.mintAttributeCount = 10;
    clsvViewpointAppraiseEN.AttributeName = ["userName", "viewpointAppraiseId", "viewpointId", "appraiseContent", "updDate", "memo", "viewpointName", "viewpointContent", "reason", "updUser"];
});
