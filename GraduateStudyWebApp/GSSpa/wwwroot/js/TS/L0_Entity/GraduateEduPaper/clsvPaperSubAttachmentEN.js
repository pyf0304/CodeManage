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
    exports.clsvPaperSubAttachmentEN = void 0;
    /**
    * 类名:clsvPaperSubAttachmentEN
    * 表名:vPaperSubAttachment(01120598)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:41
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 子观点附件(vPaperSubAttachment)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsvPaperSubAttachmentEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrExplainContent = ""; //说明内容
            this.mstrFilePath = ""; //文件路径
            this.mstrMemo = ""; //备注
            this.mstrPaperRWId = ""; //课文阅读
            this.mstrPaperSubAttachmentName = ""; //附件名称
            this.mstrRWTitle = ""; //读写标题
            this.mstrSubViewpointContent = ""; //详情内容
            this.mlngSubViewpointId = 0; //子观点Id
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mlngPaperSubAttachmentId = 0; //子观点附件Id
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.explainContent = ""; //说明内容
            this.filePath = ""; //文件路径
            this.memo = ""; //备注
            this.paperRWId = ""; //课文阅读
            this.paperSubAttachmentName = ""; //附件名称
            this.rwTitle = ""; //读写标题
            this.subViewpointContent = ""; //详情内容
            this.subViewpointId = 0; //子观点Id
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.paperSubAttachmentId = 0; //子观点附件Id
        }
        /**
         * 说明内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExplainContent(value) {
            if (value != undefined) {
                this.explainContent = value;
                this.hmProperty["explainContent"] = true;
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
         * 课文阅读(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperRWId(value) {
            if (value != undefined) {
                this.paperRWId = value;
                this.hmProperty["paperRWId"] = true;
            }
        }
        /**
         * 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperSubAttachmentName(value) {
            if (value != undefined) {
                this.paperSubAttachmentName = value;
                this.hmProperty["paperSubAttachmentName"] = true;
            }
        }
        /**
         * 读写标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRWTitle(value) {
            if (value != undefined) {
                this.rwTitle = value;
                this.hmProperty["rwTitle"] = true;
            }
        }
        /**
         * 详情内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSubViewpointContent(value) {
            if (value != undefined) {
                this.subViewpointContent = value;
                this.hmProperty["subViewpointContent"] = true;
            }
        }
        /**
         * 子观点Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSubViewpointId(value) {
            if (value != undefined) {
                this.subViewpointId = value;
                this.hmProperty["subViewpointId"] = true;
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
         * 子观点附件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperSubAttachmentId(value) {
            if (value != undefined) {
                this.paperSubAttachmentId = value;
                this.hmProperty["paperSubAttachmentId"] = true;
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
                case clsvPaperSubAttachmentEN.con_ExplainContent:
                    return this.explainContent;
                case clsvPaperSubAttachmentEN.con_FilePath:
                    return this.filePath;
                case clsvPaperSubAttachmentEN.con_Memo:
                    return this.memo;
                case clsvPaperSubAttachmentEN.con_PaperRWId:
                    return this.paperRWId;
                case clsvPaperSubAttachmentEN.con_PaperSubAttachmentName:
                    return this.paperSubAttachmentName;
                case clsvPaperSubAttachmentEN.con_RWTitle:
                    return this.rwTitle;
                case clsvPaperSubAttachmentEN.con_SubViewpointContent:
                    return this.subViewpointContent;
                case clsvPaperSubAttachmentEN.con_SubViewpointId:
                    return this.subViewpointId;
                case clsvPaperSubAttachmentEN.con_UpdDate:
                    return this.updDate;
                case clsvPaperSubAttachmentEN.con_UpdUserId:
                    return this.updUserId;
                case clsvPaperSubAttachmentEN.con_PaperSubAttachmentId:
                    return this.paperSubAttachmentId;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubAttachment]中不存在！`;
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
                case clsvPaperSubAttachmentEN.con_ExplainContent:
                    this.explainContent = strValue;
                    this.hmProperty["explainContent"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_FilePath:
                    this.filePath = strValue;
                    this.hmProperty["filePath"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_PaperRWId:
                    this.paperRWId = strValue;
                    this.hmProperty["paperRWId"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_PaperSubAttachmentName:
                    this.paperSubAttachmentName = strValue;
                    this.hmProperty["paperSubAttachmentName"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_RWTitle:
                    this.rwTitle = strValue;
                    this.hmProperty["rwTitle"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_SubViewpointContent:
                    this.subViewpointContent = strValue;
                    this.hmProperty["subViewpointContent"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_SubViewpointId:
                    this.subViewpointId = Number(strValue);
                    this.hmProperty["subViewpointId"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clsvPaperSubAttachmentEN.con_PaperSubAttachmentId:
                    this.paperSubAttachmentId = Number(strValue);
                    this.hmProperty["paperSubAttachmentId"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubAttachment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ExplainContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExplainContent() { return "explainContent"; } //说明内容
        /**
        * 常量:"FilePath"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FilePath() { return "filePath"; } //文件路径
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"PaperRWId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperRWId() { return "paperRWId"; } //课文阅读
        /**
        * 常量:"PaperSubAttachmentName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperSubAttachmentName() { return "paperSubAttachmentName"; } //附件名称
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
        * 常量:"UpdUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
        /**
        * 常量:"PaperSubAttachmentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperSubAttachmentId() { return "paperSubAttachmentId"; } //子观点附件Id
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
    exports.clsvPaperSubAttachmentEN = clsvPaperSubAttachmentEN;
    clsvPaperSubAttachmentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPaperSubAttachmentEN.CacheModeId = "05"; //未知
    clsvPaperSubAttachmentEN._CurrTabName = "vPaperSubAttachment"; //当前表名,与该类相关的表名
    clsvPaperSubAttachmentEN._KeyFldName = "PaperSubAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPaperSubAttachmentEN.mintAttributeCount = 11;
    clsvPaperSubAttachmentEN.AttributeName = ["explainContent", "filePath", "memo", "paperRWId", "paperSubAttachmentName", "rwTitle", "subViewpointContent", "subViewpointId", "updDate", "updUserId", "paperSubAttachmentId"];
});
