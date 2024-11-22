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
    exports.clsObjectiveAttachmentEN = void 0;
    /**
    * 类名:clsObjectiveAttachmentEN
    * 表名:ObjectiveAttachment(01120614)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:52
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
    * 客观附件表(ObjectiveAttachment)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsObjectiveAttachmentEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrTopicObjectiveId = ""; //客观Id
            this.mlngObjectiveAttachmentId = 0; //客观附件Id
            this.mstrObjectiveAttachmentName = ""; //附件名称
            this.mstrFilePath = ""; //文件路径
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            this.mstrid_CurrEduCls = ""; //教学班流水号
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
            this.id_CurrEduCls = ""; //教学班流水号
        }
        /**
         * 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicObjectiveId(value) {
            if (value != undefined) {
                this.topicObjectiveId = value;
                this.hmProperty["topicObjectiveId"] = true;
            }
        }
        /**
         * 客观附件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetObjectiveAttachmentId(value) {
            if (value != undefined) {
                this.objectiveAttachmentId = value;
                this.hmProperty["objectiveAttachmentId"] = true;
            }
        }
        /**
         * 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetObjectiveAttachmentName(value) {
            if (value != undefined) {
                this.objectiveAttachmentName = value;
                this.hmProperty["objectiveAttachmentName"] = true;
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
                case clsObjectiveAttachmentEN.con_TopicObjectiveId:
                    return this.topicObjectiveId;
                case clsObjectiveAttachmentEN.con_ObjectiveAttachmentId:
                    return this.objectiveAttachmentId;
                case clsObjectiveAttachmentEN.con_ObjectiveAttachmentName:
                    return this.objectiveAttachmentName;
                case clsObjectiveAttachmentEN.con_FilePath:
                    return this.filePath;
                case clsObjectiveAttachmentEN.con_UpdDate:
                    return this.updDate;
                case clsObjectiveAttachmentEN.con_UpdUserId:
                    return this.updUserId;
                case clsObjectiveAttachmentEN.con_Memo:
                    return this.memo;
                case clsObjectiveAttachmentEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ObjectiveAttachment]中不存在！`;
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
                case clsObjectiveAttachmentEN.con_TopicObjectiveId:
                    this.topicObjectiveId = strValue;
                    this.hmProperty["topicObjectiveId"] = true;
                    break;
                case clsObjectiveAttachmentEN.con_ObjectiveAttachmentId:
                    this.objectiveAttachmentId = Number(strValue);
                    this.hmProperty["objectiveAttachmentId"] = true;
                    break;
                case clsObjectiveAttachmentEN.con_ObjectiveAttachmentName:
                    this.objectiveAttachmentName = strValue;
                    this.hmProperty["objectiveAttachmentName"] = true;
                    break;
                case clsObjectiveAttachmentEN.con_FilePath:
                    this.filePath = strValue;
                    this.hmProperty["filePath"] = true;
                    break;
                case clsObjectiveAttachmentEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsObjectiveAttachmentEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clsObjectiveAttachmentEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsObjectiveAttachmentEN.con_id_CurrEduCls:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[ObjectiveAttachment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
    exports.clsObjectiveAttachmentEN = clsObjectiveAttachmentEN;
    clsObjectiveAttachmentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsObjectiveAttachmentEN.CacheModeId = "04"; //sessionStorage
    clsObjectiveAttachmentEN._CurrTabName = "ObjectiveAttachment"; //当前表名,与该类相关的表名
    clsObjectiveAttachmentEN._KeyFldName = "ObjectiveAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsObjectiveAttachmentEN.mintAttributeCount = 8;
    clsObjectiveAttachmentEN.AttributeName = ["topicObjectiveId", "objectiveAttachmentId", "objectiveAttachmentName", "filePath", "updDate", "updUserId", "memo", "id_CurrEduCls"];
});
