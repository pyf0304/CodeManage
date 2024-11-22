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
    exports.clsViewpointAppraiseEN = void 0;
    /**
    * 类名:clsViewpointAppraiseEN
    * 表名:ViewpointAppraise(01120599)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:14
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
    * 观点评论表(ViewpointAppraise)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsViewpointAppraiseEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngViewpointAppraiseId = 0; //观点评论Id
            this.mstrViewpointId = ""; //观点Id
            this.mstrAppraiseContent = ""; //评议内容
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            this.mstrUpdUser = ""; //修改人
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.viewpointAppraiseId = 0; //观点评论Id
            this.viewpointId = ""; //观点Id
            this.appraiseContent = ""; //评议内容
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.updUser = ""; //修改人
        }
        /**
         * 观点评论Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetViewpointAppraiseId(value) {
            if (value != undefined) {
                this.viewpointAppraiseId = value;
                this.hmProperty["viewpointAppraiseId"] = true;
            }
        }
        /**
         * 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetViewpointId(value) {
            if (value != undefined) {
                this.viewpointId = value;
                this.hmProperty["viewpointId"] = true;
            }
        }
        /**
         * 评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAppraiseContent(value) {
            if (value != undefined) {
                this.appraiseContent = value;
                this.hmProperty["appraiseContent"] = true;
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
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUser(value) {
            if (value != undefined) {
                this.updUser = value;
                this.hmProperty["updUser"] = true;
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
                case clsViewpointAppraiseEN.con_ViewpointAppraiseId:
                    return this.viewpointAppraiseId;
                case clsViewpointAppraiseEN.con_ViewpointId:
                    return this.viewpointId;
                case clsViewpointAppraiseEN.con_AppraiseContent:
                    return this.appraiseContent;
                case clsViewpointAppraiseEN.con_UpdDate:
                    return this.updDate;
                case clsViewpointAppraiseEN.con_Memo:
                    return this.memo;
                case clsViewpointAppraiseEN.con_UpdUser:
                    return this.updUser;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ViewpointAppraise]中不存在！`;
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
                case clsViewpointAppraiseEN.con_ViewpointAppraiseId:
                    this.viewpointAppraiseId = Number(strValue);
                    this.hmProperty["viewpointAppraiseId"] = true;
                    break;
                case clsViewpointAppraiseEN.con_ViewpointId:
                    this.viewpointId = strValue;
                    this.hmProperty["viewpointId"] = true;
                    break;
                case clsViewpointAppraiseEN.con_AppraiseContent:
                    this.appraiseContent = strValue;
                    this.hmProperty["appraiseContent"] = true;
                    break;
                case clsViewpointAppraiseEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsViewpointAppraiseEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsViewpointAppraiseEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ViewpointAppraise]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
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
    exports.clsViewpointAppraiseEN = clsViewpointAppraiseEN;
    clsViewpointAppraiseEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsViewpointAppraiseEN.CacheModeId = "02"; //客户端缓存
    clsViewpointAppraiseEN._CurrTabName = "ViewpointAppraise"; //当前表名,与该类相关的表名
    clsViewpointAppraiseEN._KeyFldName = "ViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsViewpointAppraiseEN.mintAttributeCount = 6;
    clsViewpointAppraiseEN.AttributeName = ["viewpointAppraiseId", "viewpointId", "appraiseContent", "updDate", "memo", "updUser"];
});
