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
    exports.clsvConceptAttachmentEN = void 0;
    /**
    * 类名:clsvConceptAttachmentEN
    * 表名:vConceptAttachment(01120606)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:44:50
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
    * vConceptAttachment(vConceptAttachment)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvConceptAttachmentEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.conceptName = ""; //概念名称
            this.conceptAttachmentId = 0; //概念附件Id
            this.conceptContent = ""; //概念内容
            this.conceptAttachmentName = ""; //附件名称
            this.conceptId = ""; //概念Id
            this.isSubmit = false; //是否提交
            this.filePath = ""; //文件路径
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
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
                case clsvConceptAttachmentEN.con_ConceptName:
                    return this.conceptName;
                case clsvConceptAttachmentEN.con_ConceptAttachmentId:
                    return this.conceptAttachmentId;
                case clsvConceptAttachmentEN.con_ConceptContent:
                    return this.conceptContent;
                case clsvConceptAttachmentEN.con_ConceptAttachmentName:
                    return this.conceptAttachmentName;
                case clsvConceptAttachmentEN.con_ConceptId:
                    return this.conceptId;
                case clsvConceptAttachmentEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvConceptAttachmentEN.con_FilePath:
                    return this.filePath;
                case clsvConceptAttachmentEN.con_UpdDate:
                    return this.updDate;
                case clsvConceptAttachmentEN.con_Memo:
                    return this.memo;
                case clsvConceptAttachmentEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vConceptAttachment]中不存在！`;
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
                case clsvConceptAttachmentEN.con_ConceptName:
                    this.conceptName = strValue;
                    break;
                case clsvConceptAttachmentEN.con_ConceptAttachmentId:
                    this.conceptAttachmentId = Number(strValue);
                    break;
                case clsvConceptAttachmentEN.con_ConceptContent:
                    this.conceptContent = strValue;
                    break;
                case clsvConceptAttachmentEN.con_ConceptAttachmentName:
                    this.conceptAttachmentName = strValue;
                    break;
                case clsvConceptAttachmentEN.con_ConceptId:
                    this.conceptId = strValue;
                    break;
                case clsvConceptAttachmentEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvConceptAttachmentEN.con_FilePath:
                    this.filePath = strValue;
                    break;
                case clsvConceptAttachmentEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvConceptAttachmentEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvConceptAttachmentEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vConceptAttachment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ConceptName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptName() { return "conceptName"; } //概念名称
        /**
        * 常量:"ConceptAttachmentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptAttachmentId() { return "conceptAttachmentId"; } //概念附件Id
        /**
        * 常量:"ConceptContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptContent() { return "conceptContent"; } //概念内容
        /**
        * 常量:"ConceptAttachmentName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptAttachmentName() { return "conceptAttachmentName"; } //附件名称
        /**
        * 常量:"ConceptId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptId() { return "conceptId"; } //概念Id
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"FilePath"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FilePath() { return "filePath"; } //文件路径
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
    exports.clsvConceptAttachmentEN = clsvConceptAttachmentEN;
    clsvConceptAttachmentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvConceptAttachmentEN.CacheModeId = "02"; //客户端缓存
    clsvConceptAttachmentEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvConceptAttachmentEN.WhereFormat = ""; //条件格式串
    clsvConceptAttachmentEN._CurrTabName = "vConceptAttachment"; //当前表名,与该类相关的表名
    clsvConceptAttachmentEN._KeyFldName = "ConceptAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvConceptAttachmentEN.mintAttributeCount = 10;
    clsvConceptAttachmentEN.AttributeName = ["conceptName", "conceptAttachmentId", "conceptContent", "conceptAttachmentName", "conceptId", "isSubmit", "filePath", "updDate", "memo", "id_CurrEduCls"];
});
