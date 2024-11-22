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
    exports.clsgs_ResearchResultAttachmentEN = void 0;
    /**
    * 类名:clsgs_ResearchResultAttachmentEN
    * 表名:gs_ResearchResultAttachment(01120779)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:48:27
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
    * 研究成果附件表(gs_ResearchResultAttachment)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_ResearchResultAttachmentEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngmId = 0; //mId
            this.mstrResultId = ""; //成果Id
            this.mstrTopicId = ""; //主题Id
            this.mstrFileName = ""; //文件名称
            this.mstrFilePath = ""; //文件路径
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.mId = 0; //mId
            this.resultId = ""; //成果Id
            this.topicId = ""; //主题Id
            this.fileName = ""; //文件名称
            this.filePath = ""; //文件路径
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetmId(value) {
            if (value != undefined) {
                this.mId = value;
                this.hmProperty["mId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 成果Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResultId(value) {
            if (value != undefined) {
                this.resultId = value;
                this.hmProperty["resultId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicId(value) {
            if (value != undefined) {
                this.topicId = value;
                this.hmProperty["topicId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 文件名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetFileName(value) {
            if (value != undefined) {
                this.fileName = value;
                this.hmProperty["fileName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                case clsgs_ResearchResultAttachmentEN.con_mId:
                    return this.mId;
                case clsgs_ResearchResultAttachmentEN.con_ResultId:
                    return this.resultId;
                case clsgs_ResearchResultAttachmentEN.con_TopicId:
                    return this.topicId;
                case clsgs_ResearchResultAttachmentEN.con_FileName:
                    return this.fileName;
                case clsgs_ResearchResultAttachmentEN.con_FilePath:
                    return this.filePath;
                case clsgs_ResearchResultAttachmentEN.con_UpdDate:
                    return this.updDate;
                case clsgs_ResearchResultAttachmentEN.con_UpdUser:
                    return this.updUser;
                case clsgs_ResearchResultAttachmentEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_ResearchResultAttachment]中不存在！`;
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
                case clsgs_ResearchResultAttachmentEN.con_mId:
                    this.mId = Number(strValue);
                    this.hmProperty["mId"] = true;
                    break;
                case clsgs_ResearchResultAttachmentEN.con_ResultId:
                    this.resultId = strValue;
                    this.hmProperty["resultId"] = true;
                    break;
                case clsgs_ResearchResultAttachmentEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsgs_ResearchResultAttachmentEN.con_FileName:
                    this.fileName = strValue;
                    this.hmProperty["fileName"] = true;
                    break;
                case clsgs_ResearchResultAttachmentEN.con_FilePath:
                    this.filePath = strValue;
                    this.hmProperty["filePath"] = true;
                    break;
                case clsgs_ResearchResultAttachmentEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_ResearchResultAttachmentEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_ResearchResultAttachmentEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_ResearchResultAttachment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
        /**
        * 常量:"ResultId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResultId() { return "resultId"; } //成果Id
        /**
        * 常量:"TopicId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicId() { return "topicId"; } //主题Id
        /**
        * 常量:"FileName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FileName() { return "fileName"; } //文件名称
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
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
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
    exports.clsgs_ResearchResultAttachmentEN = clsgs_ResearchResultAttachmentEN;
    clsgs_ResearchResultAttachmentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_ResearchResultAttachmentEN.CacheModeId = ""; //
    clsgs_ResearchResultAttachmentEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_ResearchResultAttachmentEN.WhereFormat = ""; //条件格式串
    clsgs_ResearchResultAttachmentEN._CurrTabName = "gs_ResearchResultAttachment"; //当前表名,与该类相关的表名
    clsgs_ResearchResultAttachmentEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_ResearchResultAttachmentEN.mintAttributeCount = 8;
    clsgs_ResearchResultAttachmentEN.AttributeName = ["mId", "resultId", "topicId", "fileName", "filePath", "updDate", "updUser", "memo"];
});
