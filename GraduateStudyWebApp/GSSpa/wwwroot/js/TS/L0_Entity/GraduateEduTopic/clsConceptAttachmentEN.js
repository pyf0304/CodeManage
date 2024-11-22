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
    exports.clsConceptAttachmentEN = void 0;
    /**
    * 类名:clsConceptAttachmentEN
    * 表名:ConceptAttachment(01120603)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:49
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
    * 概念附件(ConceptAttachment)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsConceptAttachmentEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngConceptAttachmentId = 0; //概念附件Id
            this.mstrConceptAttachmentName = ""; //附件名称
            this.mstrConceptId = ""; //概念Id
            this.mstrFilePath = ""; //文件路径
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            this.mstrid_CurrEduCls = ""; //教学班流水号
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.conceptAttachmentId = 0; //概念附件Id
            this.conceptAttachmentName = ""; //附件名称
            this.conceptId = ""; //概念Id
            this.filePath = ""; //文件路径
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
        }
        /**
         * 概念附件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetConceptAttachmentId(value) {
            if (value != undefined) {
                this.conceptAttachmentId = value;
                this.hmProperty["conceptAttachmentId"] = true;
            }
        }
        /**
         * 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetConceptAttachmentName(value) {
            if (value != undefined) {
                this.conceptAttachmentName = value;
                this.hmProperty["conceptAttachmentName"] = true;
            }
        }
        /**
         * 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetConceptId(value) {
            if (value != undefined) {
                this.conceptId = value;
                this.hmProperty["conceptId"] = true;
            }
        }
        /**
         * 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetFilePath(value) {
            if (value != undefined) {
                this.filePath = value;
                this.hmProperty["filePath"] = true;
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
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUserId(value) {
            if (value != undefined) {
                this.updUserId = value;
                this.hmProperty["updUserId"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsConceptAttachmentEN.con_ConceptAttachmentId:
                    return this.conceptAttachmentId;
                case clsConceptAttachmentEN.con_ConceptAttachmentName:
                    return this.conceptAttachmentName;
                case clsConceptAttachmentEN.con_ConceptId:
                    return this.conceptId;
                case clsConceptAttachmentEN.con_FilePath:
                    return this.filePath;
                case clsConceptAttachmentEN.con_UpdDate:
                    return this.updDate;
                case clsConceptAttachmentEN.con_UpdUserId:
                    return this.updUserId;
                case clsConceptAttachmentEN.con_Memo:
                    return this.memo;
                case clsConceptAttachmentEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ConceptAttachment]中不存在！`;
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
                case clsConceptAttachmentEN.con_ConceptAttachmentId:
                    this.conceptAttachmentId = Number(strValue);
                    this.hmProperty["conceptAttachmentId"] = true;
                    break;
                case clsConceptAttachmentEN.con_ConceptAttachmentName:
                    this.conceptAttachmentName = strValue;
                    this.hmProperty["conceptAttachmentName"] = true;
                    break;
                case clsConceptAttachmentEN.con_ConceptId:
                    this.conceptId = strValue;
                    this.hmProperty["conceptId"] = true;
                    break;
                case clsConceptAttachmentEN.con_FilePath:
                    this.filePath = strValue;
                    this.hmProperty["filePath"] = true;
                    break;
                case clsConceptAttachmentEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsConceptAttachmentEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clsConceptAttachmentEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsConceptAttachmentEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ConceptAttachment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ConceptAttachmentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptAttachmentId() { return "conceptAttachmentId"; } //概念附件Id
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
        * 常量:"UpdUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
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
    exports.clsConceptAttachmentEN = clsConceptAttachmentEN;
    clsConceptAttachmentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsConceptAttachmentEN.CacheModeId = "04"; //sessionStorage
    clsConceptAttachmentEN._CurrTabName = "ConceptAttachment"; //当前表名,与该类相关的表名
    clsConceptAttachmentEN._KeyFldName = "ConceptAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsConceptAttachmentEN.mintAttributeCount = 8;
    clsConceptAttachmentEN.AttributeName = ["conceptAttachmentId", "conceptAttachmentName", "conceptId", "filePath", "updDate", "updUserId", "memo", "id_CurrEduCls"];
});
