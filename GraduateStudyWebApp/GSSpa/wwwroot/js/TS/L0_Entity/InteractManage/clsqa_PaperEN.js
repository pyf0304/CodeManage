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
    exports.clsqa_PaperEN = void 0;
    /**
    * 类名:clsqa_PaperEN
    * 表名:qa_Paper(01120643)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:12
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:互动管理(InteractManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 论文答疑表(qa_Paper)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsqa_PaperEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrqa_PaperId = ""; //论文答疑Id
            this.mstrPaperId = ""; //论文Id
            this.mintQuestionsCount = 0; //提问计数
            this.mbolIsDelete = false; //是否删除
            this.mbolIsPublic = false; //是否公开
            this.mbolIsSubmit = false; //是否提交
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mintAnswerCount = 0; //回答计数
            this.mstrShareId = ""; //分享Id
            this.mintTagsCount = 0; //论文标注数
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.qa_PaperId = ""; //论文答疑Id
            this.paperId = ""; //论文Id
            this.questionsCount = 0; //提问计数
            this.isDelete = false; //是否删除
            this.isPublic = false; //是否公开
            this.isSubmit = false; //是否提交
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
            this.answerCount = 0; //回答计数
            this.shareId = ""; //分享Id
            this.tagsCount = 0; //论文标注数
        }
        /**
         * 论文答疑Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setqa_PaperId(value) {
            if (value != undefined) {
                this.qa_PaperId = value;
                this.hmProperty["qa_PaperId"] = true;
            }
        }
        /**
         * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperId(value) {
            if (value != undefined) {
                this.paperId = value;
                this.hmProperty["paperId"] = true;
            }
        }
        /**
         * 提问计数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionsCount(value) {
            if (value != undefined) {
                this.questionsCount = value;
                this.hmProperty["questionsCount"] = true;
            }
        }
        /**
         * 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsDelete(value) {
            if (value != undefined) {
                this.isDelete = value;
                this.hmProperty["isDelete"] = true;
            }
        }
        /**
         * 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsPublic(value) {
            if (value != undefined) {
                this.isPublic = value;
                this.hmProperty["isPublic"] = true;
            }
        }
        /**
         * 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSubmit(value) {
            if (value != undefined) {
                this.isSubmit = value;
                this.hmProperty["isSubmit"] = true;
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
         * 回答计数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerCount(value) {
            if (value != undefined) {
                this.answerCount = value;
                this.hmProperty["answerCount"] = true;
            }
        }
        /**
         * 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetShareId(value) {
            if (value != undefined) {
                this.shareId = value;
                this.hmProperty["shareId"] = true;
            }
        }
        /**
         * 论文标注数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTagsCount(value) {
            if (value != undefined) {
                this.tagsCount = value;
                this.hmProperty["tagsCount"] = true;
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
                case clsqa_PaperEN.con_qa_PaperId:
                    return this.qa_PaperId;
                case clsqa_PaperEN.con_PaperId:
                    return this.paperId;
                case clsqa_PaperEN.con_QuestionsCount:
                    return this.questionsCount;
                case clsqa_PaperEN.con_IsDelete:
                    return this.isDelete;
                case clsqa_PaperEN.con_IsPublic:
                    return this.isPublic;
                case clsqa_PaperEN.con_IsSubmit:
                    return this.isSubmit;
                case clsqa_PaperEN.con_UpdUser:
                    return this.updUser;
                case clsqa_PaperEN.con_UpdDate:
                    return this.updDate;
                case clsqa_PaperEN.con_Memo:
                    return this.memo;
                case clsqa_PaperEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsqa_PaperEN.con_AnswerCount:
                    return this.answerCount;
                case clsqa_PaperEN.con_ShareId:
                    return this.shareId;
                case clsqa_PaperEN.con_TagsCount:
                    return this.tagsCount;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[qa_Paper]中不存在！`;
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
                case clsqa_PaperEN.con_qa_PaperId:
                    this.qa_PaperId = strValue;
                    this.hmProperty["qa_PaperId"] = true;
                    break;
                case clsqa_PaperEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsqa_PaperEN.con_QuestionsCount:
                    this.questionsCount = Number(strValue);
                    this.hmProperty["questionsCount"] = true;
                    break;
                case clsqa_PaperEN.con_IsDelete:
                    this.isDelete = Boolean(strValue);
                    this.hmProperty["isDelete"] = true;
                    break;
                case clsqa_PaperEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    this.hmProperty["isPublic"] = true;
                    break;
                case clsqa_PaperEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsqa_PaperEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsqa_PaperEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsqa_PaperEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsqa_PaperEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsqa_PaperEN.con_AnswerCount:
                    this.answerCount = Number(strValue);
                    this.hmProperty["answerCount"] = true;
                    break;
                case clsqa_PaperEN.con_ShareId:
                    this.shareId = strValue;
                    this.hmProperty["shareId"] = true;
                    break;
                case clsqa_PaperEN.con_TagsCount:
                    this.tagsCount = Number(strValue);
                    this.hmProperty["tagsCount"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[qa_Paper]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"qa_PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_qa_PaperId() { return "qa_PaperId"; } //论文答疑Id
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"QuestionsCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsCount() { return "questionsCount"; } //提问计数
        /**
        * 常量:"IsDelete"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsDelete() { return "isDelete"; } //是否删除
        /**
        * 常量:"IsPublic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsPublic() { return "isPublic"; } //是否公开
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
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
        * 常量:"AnswerCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerCount() { return "answerCount"; } //回答计数
        /**
        * 常量:"ShareId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareId() { return "shareId"; } //分享Id
        /**
        * 常量:"TagsCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TagsCount() { return "tagsCount"; } //论文标注数
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
    exports.clsqa_PaperEN = clsqa_PaperEN;
    clsqa_PaperEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsqa_PaperEN.CacheModeId = "04"; //sessionStorage
    clsqa_PaperEN._CurrTabName = "qa_Paper"; //当前表名,与该类相关的表名
    clsqa_PaperEN._KeyFldName = "qa_PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsqa_PaperEN.mintAttributeCount = 13;
    clsqa_PaperEN.AttributeName = ["qa_PaperId", "paperId", "questionsCount", "isDelete", "isPublic", "isSubmit", "updUser", "updDate", "memo", "id_CurrEduCls", "answerCount", "shareId", "tagsCount"];
});
