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
    exports.clsConceptEN = void 0;
    /**
    * 类名:clsConceptEN
    * 表名:Concept(01120602)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:48
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
    * 观点概念(Concept)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsConceptEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrConceptId = ""; //概念Id
            this.mstrConceptContent = ""; //概念内容
            this.mstrConceptName = ""; //概念名称
            this.mbolIsSubmit = false; //是否提交
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            this.mstrCitationId = ""; //引用Id
            this.mintAppraiseCount = 0; //评论数
            this.mintOkCount = 0; //点赞统计
            this.mfltscore = 0.0; //评分
            this.mfltStuScore = 0.0; //学生平均分
            this.mfltTeaScore = 0.0; //教师评分
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrPdfContent = ""; //Pdf内容
            this.mintPdfPageNum = 0; //Pdf页码
            this.mintCitationCount = 0; //引用统计
            this.mintVersionCount = 0; //版本统计
            this.mstrCreateDate = ""; //建立日期
            this.mstrShareId = ""; //分享Id
            this.mstrUpdUser = ""; //修改人
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.conceptId = ""; //概念Id
            this.conceptContent = ""; //概念内容
            this.conceptName = ""; //概念名称
            this.isSubmit = false; //是否提交
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.citationId = ""; //引用Id
            this.appraiseCount = 0; //评论数
            this.okCount = 0; //点赞统计
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.id_CurrEduCls = ""; //教学班流水号
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.citationCount = 0; //引用统计
            this.versionCount = 0; //版本统计
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.updUser = ""; //修改人
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
         * 概念内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetConceptContent(value) {
            if (value != undefined) {
                this.conceptContent = value;
                this.hmProperty["conceptContent"] = true;
            }
        }
        /**
         * 概念名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetConceptName(value) {
            if (value != undefined) {
                this.conceptName = value;
                this.hmProperty["conceptName"] = true;
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
         * 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCitationId(value) {
            if (value != undefined) {
                this.citationId = value;
                this.hmProperty["citationId"] = true;
            }
        }
        /**
         * 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAppraiseCount(value) {
            if (value != undefined) {
                this.appraiseCount = value;
                this.hmProperty["appraiseCount"] = true;
            }
        }
        /**
         * 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOkCount(value) {
            if (value != undefined) {
                this.okCount = value;
                this.hmProperty["okCount"] = true;
            }
        }
        /**
         * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setscore(value) {
            if (value != undefined) {
                this.score = value;
                this.hmProperty["score"] = true;
            }
        }
        /**
         * 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuScore(value) {
            if (value != undefined) {
                this.stuScore = value;
                this.hmProperty["stuScore"] = true;
            }
        }
        /**
         * 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTeaScore(value) {
            if (value != undefined) {
                this.teaScore = value;
                this.hmProperty["teaScore"] = true;
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
         * Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfContent(value) {
            if (value != undefined) {
                this.pdfContent = value;
                this.hmProperty["pdfContent"] = true;
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
            }
        }
        /**
         * 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCitationCount(value) {
            if (value != undefined) {
                this.citationCount = value;
                this.hmProperty["citationCount"] = true;
            }
        }
        /**
         * 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVersionCount(value) {
            if (value != undefined) {
                this.versionCount = value;
                this.hmProperty["versionCount"] = true;
            }
        }
        /**
         * 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCreateDate(value) {
            if (value != undefined) {
                this.createDate = value;
                this.hmProperty["createDate"] = true;
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
                case clsConceptEN.con_ConceptId:
                    return this.conceptId;
                case clsConceptEN.con_ConceptContent:
                    return this.conceptContent;
                case clsConceptEN.con_ConceptName:
                    return this.conceptName;
                case clsConceptEN.con_IsSubmit:
                    return this.isSubmit;
                case clsConceptEN.con_UpdDate:
                    return this.updDate;
                case clsConceptEN.con_Memo:
                    return this.memo;
                case clsConceptEN.con_CitationId:
                    return this.citationId;
                case clsConceptEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsConceptEN.con_OkCount:
                    return this.okCount;
                case clsConceptEN.con_score:
                    return this.score;
                case clsConceptEN.con_StuScore:
                    return this.stuScore;
                case clsConceptEN.con_TeaScore:
                    return this.teaScore;
                case clsConceptEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsConceptEN.con_PdfContent:
                    return this.pdfContent;
                case clsConceptEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsConceptEN.con_CitationCount:
                    return this.citationCount;
                case clsConceptEN.con_VersionCount:
                    return this.versionCount;
                case clsConceptEN.con_CreateDate:
                    return this.createDate;
                case clsConceptEN.con_ShareId:
                    return this.shareId;
                case clsConceptEN.con_UpdUser:
                    return this.updUser;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[Concept]中不存在！`;
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
                case clsConceptEN.con_ConceptId:
                    this.conceptId = strValue;
                    this.hmProperty["conceptId"] = true;
                    break;
                case clsConceptEN.con_ConceptContent:
                    this.conceptContent = strValue;
                    this.hmProperty["conceptContent"] = true;
                    break;
                case clsConceptEN.con_ConceptName:
                    this.conceptName = strValue;
                    this.hmProperty["conceptName"] = true;
                    break;
                case clsConceptEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsConceptEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsConceptEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsConceptEN.con_CitationId:
                    this.citationId = strValue;
                    this.hmProperty["citationId"] = true;
                    break;
                case clsConceptEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    this.hmProperty["appraiseCount"] = true;
                    break;
                case clsConceptEN.con_OkCount:
                    this.okCount = Number(strValue);
                    this.hmProperty["okCount"] = true;
                    break;
                case clsConceptEN.con_score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsConceptEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    this.hmProperty["stuScore"] = true;
                    break;
                case clsConceptEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    this.hmProperty["teaScore"] = true;
                    break;
                case clsConceptEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsConceptEN.con_PdfContent:
                    this.pdfContent = strValue;
                    this.hmProperty["pdfContent"] = true;
                    break;
                case clsConceptEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    this.hmProperty["pdfPageNum"] = true;
                    break;
                case clsConceptEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    this.hmProperty["citationCount"] = true;
                    break;
                case clsConceptEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    this.hmProperty["versionCount"] = true;
                    break;
                case clsConceptEN.con_CreateDate:
                    this.createDate = strValue;
                    this.hmProperty["createDate"] = true;
                    break;
                case clsConceptEN.con_ShareId:
                    this.shareId = strValue;
                    this.hmProperty["shareId"] = true;
                    break;
                case clsConceptEN.con_UpdUser:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[Concept]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ConceptId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptId() { return "conceptId"; } //概念Id
        /**
        * 常量:"ConceptContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptContent() { return "conceptContent"; } //概念内容
        /**
        * 常量:"ConceptName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptName() { return "conceptName"; } //概念名称
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
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
        * 常量:"CitationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationId() { return "citationId"; } //引用Id
        /**
        * 常量:"AppraiseCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
        /**
        * 常量:"StuScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuScore() { return "stuScore"; } //学生平均分
        /**
        * 常量:"TeaScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaScore() { return "teaScore"; } //教师评分
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
        * 常量:"CitationCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationCount() { return "citationCount"; } //引用统计
        /**
        * 常量:"VersionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /**
        * 常量:"CreateDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateDate() { return "createDate"; } //建立日期
        /**
        * 常量:"ShareId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareId() { return "shareId"; } //分享Id
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
    exports.clsConceptEN = clsConceptEN;
    clsConceptEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsConceptEN.CacheModeId = "04"; //sessionStorage
    clsConceptEN._CurrTabName = "Concept"; //当前表名,与该类相关的表名
    clsConceptEN._KeyFldName = "ConceptId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsConceptEN.mintAttributeCount = 20;
    clsConceptEN.AttributeName = ["conceptId", "conceptContent", "conceptName", "isSubmit", "updDate", "memo", "citationId", "appraiseCount", "okCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "citationCount", "versionCount", "createDate", "shareId", "updUser"];
});
