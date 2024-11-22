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
    exports.clsvObjectiveAttachmentEN = void 0;
    /**
    * 类名:clsvObjectiveAttachmentEN
    * 表名:vObjectiveAttachment(01120618)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:51
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
    * vObjectiveAttachment(vObjectiveAttachment)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvObjectiveAttachmentEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.topicObjectiveId = ""; //客观Id
            this.objectiveAttachmentId = 0; //客观附件Id
            this.objectiveAttachmentName = ""; //附件名称
            this.filePath = ""; //文件路径
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
            this.objectiveName = ""; //客观名称
            this.objectiveContent = ""; //客观内容
            this.objectiveType = ""; //客观类型
            this.objectiveTypeName = ""; //ObjectiveTypeName
            this.conclusion = ""; //结论
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
                case clsvObjectiveAttachmentEN.con_TopicObjectiveId:
                    return this.topicObjectiveId;
                case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId:
                    return this.objectiveAttachmentId;
                case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentName:
                    return this.objectiveAttachmentName;
                case clsvObjectiveAttachmentEN.con_FilePath:
                    return this.filePath;
                case clsvObjectiveAttachmentEN.con_UpdDate:
                    return this.updDate;
                case clsvObjectiveAttachmentEN.con_UpdUserId:
                    return this.updUserId;
                case clsvObjectiveAttachmentEN.con_Memo:
                    return this.memo;
                case clsvObjectiveAttachmentEN.con_ObjectiveName:
                    return this.objectiveName;
                case clsvObjectiveAttachmentEN.con_ObjectiveContent:
                    return this.objectiveContent;
                case clsvObjectiveAttachmentEN.con_ObjectiveType:
                    return this.objectiveType;
                case clsvObjectiveAttachmentEN.con_ObjectiveTypeName:
                    return this.objectiveTypeName;
                case clsvObjectiveAttachmentEN.con_Conclusion:
                    return this.conclusion;
                case clsvObjectiveAttachmentEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vObjectiveAttachment]中不存在！`;
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
                case clsvObjectiveAttachmentEN.con_TopicObjectiveId:
                    this.topicObjectiveId = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId:
                    this.objectiveAttachmentId = Number(strValue);
                    break;
                case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentName:
                    this.objectiveAttachmentName = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_FilePath:
                    this.filePath = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_UpdUserId:
                    this.updUserId = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_ObjectiveName:
                    this.objectiveName = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_ObjectiveContent:
                    this.objectiveContent = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_ObjectiveType:
                    this.objectiveType = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_ObjectiveTypeName:
                    this.objectiveTypeName = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_Conclusion:
                    this.conclusion = strValue;
                    break;
                case clsvObjectiveAttachmentEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vObjectiveAttachment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"TopicObjectiveId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicObjectiveId() { return "topicObjectiveId"; } //客观Id
        /**
        * 常量:"ObjectiveAttachmentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveAttachmentId() { return "objectiveAttachmentId"; } //客观附件Id
        /**
        * 常量:"ObjectiveAttachmentName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveAttachmentName() { return "objectiveAttachmentName"; } //附件名称
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
        * 常量:"ObjectiveName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveName() { return "objectiveName"; } //客观名称
        /**
        * 常量:"ObjectiveContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveContent() { return "objectiveContent"; } //客观内容
        /**
        * 常量:"ObjectiveType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveType() { return "objectiveType"; } //客观类型
        /**
        * 常量:"ObjectiveTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveTypeName() { return "objectiveTypeName"; } //ObjectiveTypeName
        /**
        * 常量:"Conclusion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Conclusion() { return "conclusion"; } //结论
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
    exports.clsvObjectiveAttachmentEN = clsvObjectiveAttachmentEN;
    clsvObjectiveAttachmentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvObjectiveAttachmentEN.CacheModeId = "02"; //客户端缓存
    clsvObjectiveAttachmentEN._CurrTabName = "vObjectiveAttachment"; //当前表名,与该类相关的表名
    clsvObjectiveAttachmentEN._KeyFldName = "ObjectiveAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvObjectiveAttachmentEN.mintAttributeCount = 13;
    clsvObjectiveAttachmentEN.AttributeName = ["topicObjectiveId", "objectiveAttachmentId", "objectiveAttachmentName", "filePath", "updDate", "updUserId", "memo", "objectiveName", "objectiveContent", "objectiveType", "objectiveTypeName", "conclusion", "id_CurrEduCls"];
});