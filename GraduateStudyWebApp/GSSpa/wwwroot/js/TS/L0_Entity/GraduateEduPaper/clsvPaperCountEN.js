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
    exports.clsvPaperCountEN = void 0;
    /**
    * 类名:clsvPaperCountEN
    * 表名:vPaperCount(01120595)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:40
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
    * vPaperCount(vPaperCount)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvPaperCountEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paperId = ""; //论文Id
            this.appraiseCount = 0; //评论数
            this.attachmentCount = 0; //附件计数
            this.collectionCount = 0; //收藏数
            this.downloadCount = 0; //下载数
            this.okCount = 0; //点赞统计
            this.pcount = 0; //读写数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.browseNumber = 0; //浏览量
            this.updDate = ""; //修改日期
            this.paperTitle = ""; //论文标题
            this.updUser = ""; //修改人
            this.paperQCount = 0; //论文答疑数
            this.subVCount = 0; //论文子观点数
            this.tagsCount = 0; //论文标注数
            this.teaQCount = 0; //教师提问数
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
                case clsvPaperCountEN.con_PaperId:
                    return this.paperId;
                case clsvPaperCountEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvPaperCountEN.con_AttachmentCount:
                    return this.attachmentCount;
                case clsvPaperCountEN.con_CollectionCount:
                    return this.collectionCount;
                case clsvPaperCountEN.con_DownloadCount:
                    return this.downloadCount;
                case clsvPaperCountEN.con_OkCount:
                    return this.okCount;
                case clsvPaperCountEN.con_Pcount:
                    return this.pcount;
                case clsvPaperCountEN.con_score:
                    return this.score;
                case clsvPaperCountEN.con_StuScore:
                    return this.stuScore;
                case clsvPaperCountEN.con_TeaScore:
                    return this.teaScore;
                case clsvPaperCountEN.con_BrowseNumber:
                    return this.browseNumber;
                case clsvPaperCountEN.con_UpdDate:
                    return this.updDate;
                case clsvPaperCountEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvPaperCountEN.con_UpdUser:
                    return this.updUser;
                case clsvPaperCountEN.con_PaperQCount:
                    return this.paperQCount;
                case clsvPaperCountEN.con_SubVCount:
                    return this.subVCount;
                case clsvPaperCountEN.con_TagsCount:
                    return this.tagsCount;
                case clsvPaperCountEN.con_TeaQCount:
                    return this.teaQCount;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperCount]中不存在！`;
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
                case clsvPaperCountEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvPaperCountEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvPaperCountEN.con_AttachmentCount:
                    this.attachmentCount = Number(strValue);
                    break;
                case clsvPaperCountEN.con_CollectionCount:
                    this.collectionCount = Number(strValue);
                    break;
                case clsvPaperCountEN.con_DownloadCount:
                    this.downloadCount = Number(strValue);
                    break;
                case clsvPaperCountEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvPaperCountEN.con_Pcount:
                    this.pcount = Number(strValue);
                    break;
                case clsvPaperCountEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvPaperCountEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvPaperCountEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvPaperCountEN.con_BrowseNumber:
                    this.browseNumber = Number(strValue);
                    break;
                case clsvPaperCountEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvPaperCountEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvPaperCountEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvPaperCountEN.con_PaperQCount:
                    this.paperQCount = Number(strValue);
                    break;
                case clsvPaperCountEN.con_SubVCount:
                    this.subVCount = Number(strValue);
                    break;
                case clsvPaperCountEN.con_TagsCount:
                    this.tagsCount = Number(strValue);
                    break;
                case clsvPaperCountEN.con_TeaQCount:
                    this.teaQCount = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperCount]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"AppraiseCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
        /**
        * 常量:"AttachmentCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AttachmentCount() { return "attachmentCount"; } //附件计数
        /**
        * 常量:"CollectionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollectionCount() { return "collectionCount"; } //收藏数
        /**
        * 常量:"DownloadCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DownloadCount() { return "downloadCount"; } //下载数
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"Pcount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Pcount() { return "pcount"; } //读写数
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
        * 常量:"BrowseNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BrowseNumber() { return "browseNumber"; } //浏览量
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"PaperQCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperQCount() { return "paperQCount"; } //论文答疑数
        /**
        * 常量:"SubVCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubVCount() { return "subVCount"; } //论文子观点数
        /**
        * 常量:"TagsCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TagsCount() { return "tagsCount"; } //论文标注数
        /**
        * 常量:"TeaQCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaQCount() { return "teaQCount"; } //教师提问数
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
    exports.clsvPaperCountEN = clsvPaperCountEN;
    clsvPaperCountEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPaperCountEN.CacheModeId = "05"; //未知
    clsvPaperCountEN._CurrTabName = "vPaperCount"; //当前表名,与该类相关的表名
    clsvPaperCountEN._KeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPaperCountEN.mintAttributeCount = 18;
    clsvPaperCountEN.AttributeName = ["paperId", "appraiseCount", "attachmentCount", "collectionCount", "downloadCount", "okCount", "pcount", "score", "stuScore", "teaScore", "browseNumber", "updDate", "paperTitle", "updUser", "paperQCount", "subVCount", "tagsCount", "teaQCount"];
});
