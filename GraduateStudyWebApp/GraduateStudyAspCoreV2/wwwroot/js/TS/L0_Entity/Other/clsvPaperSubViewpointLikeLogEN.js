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
    exports.clsvPaperSubViewpointLikeLogEN = void 0;
    /**
    * 类名:clsvPaperSubViewpointLikeLogEN
    * 表名:vPaperSubViewpointLikeLog(01120563)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:44:17
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
    * v子观点点赞表(vPaperSubViewpointLikeLog)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvPaperSubViewpointLikeLogEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paperSubViewpointLikeLogId = 0; //点赞Id
            this.subViewpointId = ""; //子观点Id
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.rwTitle = ""; //读写标题
            this.subViewpointContent = ""; //详情内容
            this.explainContent = ""; //说明内容
            this.paperRWId = ""; //课文阅读
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
                case clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
                    return this.paperSubViewpointLikeLogId;
                case clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
                    return this.subViewpointId;
                case clsvPaperSubViewpointLikeLogEN.con_UpdDate:
                    return this.updDate;
                case clsvPaperSubViewpointLikeLogEN.con_Memo:
                    return this.memo;
                case clsvPaperSubViewpointLikeLogEN.con_RWTitle:
                    return this.rwTitle;
                case clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
                    return this.subViewpointContent;
                case clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
                    return this.explainContent;
                case clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
                    return this.paperRWId;
                case clsvPaperSubViewpointLikeLogEN.con_UpdUser:
                    return this.updUser;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubViewpointLikeLog]中不存在！`;
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
                case clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
                    this.paperSubViewpointLikeLogId = Number(strValue);
                    break;
                case clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
                    this.subViewpointId = strValue;
                    break;
                case clsvPaperSubViewpointLikeLogEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvPaperSubViewpointLikeLogEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvPaperSubViewpointLikeLogEN.con_RWTitle:
                    this.rwTitle = strValue;
                    break;
                case clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
                    this.subViewpointContent = strValue;
                    break;
                case clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
                    this.explainContent = strValue;
                    break;
                case clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
                    this.paperRWId = strValue;
                    break;
                case clsvPaperSubViewpointLikeLogEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubViewpointLikeLog]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PaperSubViewpointLikeLogId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperSubViewpointLikeLogId() { return "paperSubViewpointLikeLogId"; } //点赞Id
        /**
        * 常量:"SubViewpointId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubViewpointId() { return "subViewpointId"; } //子观点Id
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
        * 常量:"RWTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RWTitle() { return "rwTitle"; } //读写标题
        /**
        * 常量:"SubViewpointContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubViewpointContent() { return "subViewpointContent"; } //详情内容
        /**
        * 常量:"ExplainContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExplainContent() { return "explainContent"; } //说明内容
        /**
        * 常量:"PaperRWId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperRWId() { return "paperRWId"; } //课文阅读
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
    exports.clsvPaperSubViewpointLikeLogEN = clsvPaperSubViewpointLikeLogEN;
    clsvPaperSubViewpointLikeLogEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPaperSubViewpointLikeLogEN.CacheModeId = "02"; //客户端缓存
    clsvPaperSubViewpointLikeLogEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvPaperSubViewpointLikeLogEN.WhereFormat = ""; //条件格式串
    clsvPaperSubViewpointLikeLogEN._CurrTabName = "vPaperSubViewpointLikeLog"; //当前表名,与该类相关的表名
    clsvPaperSubViewpointLikeLogEN._KeyFldName = "PaperSubViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPaperSubViewpointLikeLogEN.mintAttributeCount = 9;
    clsvPaperSubViewpointLikeLogEN.AttributeName = ["paperSubViewpointLikeLogId", "subViewpointId", "updDate", "memo", "rwTitle", "subViewpointContent", "explainContent", "paperRWId", "updUser"];
});
