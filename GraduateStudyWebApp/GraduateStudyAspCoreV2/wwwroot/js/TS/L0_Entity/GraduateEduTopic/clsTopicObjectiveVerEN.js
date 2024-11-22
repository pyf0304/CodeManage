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
    exports.clsTopicObjectiveVerEN = void 0;
    /**
    * 类名:clsTopicObjectiveVerEN
    * 表名:TopicObjectiveVer(01120648)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:45:23
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
    * 主题客观版本(TopicObjectiveVer)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsTopicObjectiveVerEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngTopicObjectiveVId = 0; //主题客观版本Id
            this.mstrTopicObjectiveId = ""; //客观Id
            this.mstrObjectiveName = ""; //客观名称
            this.mstrObjectiveContent = ""; //客观内容
            this.mstrObjectiveType = ""; //客观类型
            this.mstrConclusion = ""; //结论
            this.mstrSourceId = ""; //来源Id
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrPdfContent = ""; //Pdf内容
            this.mintPdfPageNum = 0; //Pdf页码
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.topicObjectiveVId = 0; //主题客观版本Id
            this.topicObjectiveId = ""; //客观Id
            this.objectiveName = ""; //客观名称
            this.objectiveContent = ""; //客观内容
            this.objectiveType = ""; //客观类型
            this.conclusion = ""; //结论
            this.sourceId = ""; //来源Id
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.id_CurrEduCls = ""; //教学班流水号
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.memo = ""; //备注
        }
        /**
         * 主题客观版本Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicObjectiveVId(value) {
            if (value != undefined) {
                this.topicObjectiveVId = value;
                this.hmProperty["topicObjectiveVId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicObjectiveId(value) {
            if (value != undefined) {
                this.topicObjectiveId = value;
                this.hmProperty["topicObjectiveId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetObjectiveName(value) {
            if (value != undefined) {
                this.objectiveName = value;
                this.hmProperty["objectiveName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetObjectiveContent(value) {
            if (value != undefined) {
                this.objectiveContent = value;
                this.hmProperty["objectiveContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetObjectiveType(value) {
            if (value != undefined) {
                this.objectiveType = value;
                this.hmProperty["objectiveType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetConclusion(value) {
            if (value != undefined) {
                this.conclusion = value;
                this.hmProperty["conclusion"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 来源Id(说明:;字段类型:char;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSourceId(value) {
            if (value != undefined) {
                this.sourceId = value;
                this.hmProperty["sourceId"] = true;
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
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CurrEduCls(value) {
            if (value != undefined) {
                this.id_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfContent(value) {
            if (value != undefined) {
                this.pdfContent = value;
                this.hmProperty["pdfContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfPageNum(value) {
            if (value != undefined) {
                this.pdfPageNum = value;
                this.hmProperty["pdfPageNum"] = true;
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
                case clsTopicObjectiveVerEN.con_TopicObjectiveVId:
                    return this.topicObjectiveVId;
                case clsTopicObjectiveVerEN.con_TopicObjectiveId:
                    return this.topicObjectiveId;
                case clsTopicObjectiveVerEN.con_ObjectiveName:
                    return this.objectiveName;
                case clsTopicObjectiveVerEN.con_ObjectiveContent:
                    return this.objectiveContent;
                case clsTopicObjectiveVerEN.con_ObjectiveType:
                    return this.objectiveType;
                case clsTopicObjectiveVerEN.con_Conclusion:
                    return this.conclusion;
                case clsTopicObjectiveVerEN.con_SourceId:
                    return this.sourceId;
                case clsTopicObjectiveVerEN.con_UpdDate:
                    return this.updDate;
                case clsTopicObjectiveVerEN.con_UpdUser:
                    return this.updUser;
                case clsTopicObjectiveVerEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsTopicObjectiveVerEN.con_PdfContent:
                    return this.pdfContent;
                case clsTopicObjectiveVerEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsTopicObjectiveVerEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[TopicObjectiveVer]中不存在！`;
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
                case clsTopicObjectiveVerEN.con_TopicObjectiveVId:
                    this.topicObjectiveVId = Number(strValue);
                    this.hmProperty["topicObjectiveVId"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_TopicObjectiveId:
                    this.topicObjectiveId = strValue;
                    this.hmProperty["topicObjectiveId"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_ObjectiveName:
                    this.objectiveName = strValue;
                    this.hmProperty["objectiveName"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_ObjectiveContent:
                    this.objectiveContent = strValue;
                    this.hmProperty["objectiveContent"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_ObjectiveType:
                    this.objectiveType = strValue;
                    this.hmProperty["objectiveType"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_Conclusion:
                    this.conclusion = strValue;
                    this.hmProperty["conclusion"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_SourceId:
                    this.sourceId = strValue;
                    this.hmProperty["sourceId"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_PdfContent:
                    this.pdfContent = strValue;
                    this.hmProperty["pdfContent"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    this.hmProperty["pdfPageNum"] = true;
                    break;
                case clsTopicObjectiveVerEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[TopicObjectiveVer]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"TopicObjectiveVId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicObjectiveVId() { return "topicObjectiveVId"; } //主题客观版本Id
        /**
        * 常量:"TopicObjectiveId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicObjectiveId() { return "topicObjectiveId"; } //客观Id
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
        * 常量:"Conclusion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Conclusion() { return "conclusion"; } //结论
        /**
        * 常量:"SourceId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SourceId() { return "sourceId"; } //来源Id
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
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"PdfContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfContent() { return "pdfContent"; } //Pdf内容
        /**
        * 常量:"PdfPageNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageNum() { return "pdfPageNum"; } //Pdf页码
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
    exports.clsTopicObjectiveVerEN = clsTopicObjectiveVerEN;
    clsTopicObjectiveVerEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsTopicObjectiveVerEN.CacheModeId = ""; //
    clsTopicObjectiveVerEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsTopicObjectiveVerEN.WhereFormat = ""; //条件格式串
    clsTopicObjectiveVerEN._CurrTabName = "TopicObjectiveVer"; //当前表名,与该类相关的表名
    clsTopicObjectiveVerEN._KeyFldName = "TopicObjectiveVId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsTopicObjectiveVerEN.mintAttributeCount = 13;
    clsTopicObjectiveVerEN.AttributeName = ["topicObjectiveVId", "topicObjectiveId", "objectiveName", "objectiveContent", "objectiveType", "conclusion", "sourceId", "updDate", "updUser", "id_CurrEduCls", "pdfContent", "pdfPageNum", "memo"];
});
