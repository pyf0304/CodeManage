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
    exports.clsPaperEN = void 0;
    /**
    * 类名:clsPaperEN
    * 表名:Paper(01120535)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/15 23:44:09
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
    * 论文表(Paper)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsPaperEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrPaperId = ""; //论文Id
            this.mstrPaperTitle = ""; //论文标题
            this.mstrPaperContent = ""; //主题内容
            this.mstrPeriodical = ""; //期刊
            this.mstrAuthor = ""; //作者
            this.mstrResearchQuestion = ""; //研究问题
            this.mstrKeyword = ""; //关键字
            this.mstrLiteratureSources = ""; //文献来源
            this.mstrLiteratureLink = ""; //文献链接
            this.mstrUploadfileUrl = ""; //文件地址
            this.mbolIsQuotethesis = false; //是否引用论文
            this.mstrQuoteId = ""; //引用Id
            this.mbolIsChecked = false; //是否检查
            this.mstrChecker = ""; //审核人
            this.mstrLiteratureTypeId = ""; //作文类型Id
            this.mintBrowseNumber = 0; //浏览量
            this.mbolIsSubmit = false; //是否提交
            this.mintAppraiseCount = 0; //评论数
            this.mintAttachmentCount = 0; //附件计数
            this.mintCollectionCount = 0; //收藏数量
            this.mintDownloadCount = 0; //下载数
            this.mintOkCount = 0; //点赞统计
            this.mintPcount = 0; //读写数
            this.mfltScore = 0.0; //评分
            this.mfltStuScore = 0.0; //学生平均分
            this.mfltTeaScore = 0.0; //教师评分
            this.mstrPaperTypeId = ""; //论文类型Id
            this.mstrPaperStatusId = ""; //论文状态Id
            this.mintVersionCount = 0; //版本统计
            this.mbolIsPublic = false; //是否公开
            this.mstrAskQuestion = ""; //问题提出
            this.mstrResearchStatus = ""; //目前研究的现状
            this.mstrInnovationPoints = ""; //创新点
            this.mstrResearchDesign = ""; //研究设计
            this.mstrDimensionDataProcess = ""; //数据处理的维度
            this.mstrExpectedConclusion = ""; //预期结论
            this.mstrShareId = ""; //分享Id
            this.mintPaperQCount = 0; //论文答疑数
            this.mintSubVCount = 0; //论文子观点数
            this.mintTagsCount = 0; //论文标注数
            this.mintTeaQCount = 0; //教师提问数
            this.mstrCreateDate = ""; //建立日期
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.paperId = ""; //论文Id
            this.paperTitle = ""; //论文标题
            this.paperContent = ""; //主题内容
            this.periodical = ""; //期刊
            this.author = ""; //作者
            this.researchQuestion = ""; //研究问题
            this.keyword = ""; //关键字
            this.literatureSources = ""; //文献来源
            this.literatureLink = ""; //文献链接
            this.uploadfileUrl = ""; //文件地址
            this.isQuotethesis = false; //是否引用论文
            this.quoteId = ""; //引用Id
            this.isChecked = false; //是否检查
            this.checker = ""; //审核人
            this.literatureTypeId = ""; //作文类型Id
            this.browseNumber = 0; //浏览量
            this.isSubmit = false; //是否提交
            this.appraiseCount = 0; //评论数
            this.attachmentCount = 0; //附件计数
            this.collectionCount = 0; //收藏数量
            this.downloadCount = 0; //下载数
            this.okCount = 0; //点赞统计
            this.pcount = 0; //读写数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.paperTypeId = ""; //论文类型Id
            this.paperStatusId = ""; //论文状态Id
            this.versionCount = 0; //版本统计
            this.isPublic = false; //是否公开
            this.askQuestion = ""; //问题提出
            this.researchStatus = ""; //目前研究的现状
            this.innovationPoints = ""; //创新点
            this.researchDesign = ""; //研究设计
            this.dimensionDataProcess = ""; //数据处理的维度
            this.expectedConclusion = ""; //预期结论
            this.shareId = ""; //分享Id
            this.paperQCount = 0; //论文答疑数
            this.subVCount = 0; //论文子观点数
            this.tagsCount = 0; //论文标注数
            this.teaQCount = 0; //教师提问数
            this.createDate = ""; //建立日期
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
        }
        /**
         * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperId(value) {
            if (value != undefined) {
                this.paperId = value;
                this.hmProperty["paperId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperTitle(value) {
            if (value != undefined) {
                this.paperTitle = value;
                this.hmProperty["paperTitle"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperContent(value) {
            if (value != undefined) {
                this.paperContent = value;
                this.hmProperty["paperContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPeriodical(value) {
            if (value != undefined) {
                this.periodical = value;
                this.hmProperty["periodical"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAuthor(value) {
            if (value != undefined) {
                this.author = value;
                this.hmProperty["author"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 研究问题(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResearchQuestion(value) {
            if (value != undefined) {
                this.researchQuestion = value;
                this.hmProperty["researchQuestion"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 关键字(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKeyword(value) {
            if (value != undefined) {
                this.keyword = value;
                this.hmProperty["keyword"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 文献来源(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLiteratureSources(value) {
            if (value != undefined) {
                this.literatureSources = value;
                this.hmProperty["literatureSources"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 文献链接(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLiteratureLink(value) {
            if (value != undefined) {
                this.literatureLink = value;
                this.hmProperty["literatureLink"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 文件地址(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUploadfileUrl(value) {
            if (value != undefined) {
                this.uploadfileUrl = value;
                this.hmProperty["uploadfileUrl"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否引用论文(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsQuotethesis(value) {
            if (value != undefined) {
                this.isQuotethesis = value;
                this.hmProperty["isQuotethesis"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuoteId(value) {
            if (value != undefined) {
                this.quoteId = value;
                this.hmProperty["quoteId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否检查(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsChecked(value) {
            if (value != undefined) {
                this.isChecked = value;
                this.hmProperty["isChecked"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 审核人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetChecker(value) {
            if (value != undefined) {
                this.checker = value;
                this.hmProperty["checker"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 作文类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLiteratureTypeId(value) {
            if (value != undefined) {
                this.literatureTypeId = value;
                this.hmProperty["literatureTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetBrowseNumber(value) {
            if (value != undefined) {
                this.browseNumber = value;
                this.hmProperty["browseNumber"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 附件计数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAttachmentCount(value) {
            if (value != undefined) {
                this.attachmentCount = value;
                this.hmProperty["attachmentCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 收藏数量(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCollectionCount(value) {
            if (value != undefined) {
                this.collectionCount = value;
                this.hmProperty["collectionCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 下载数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDownloadCount(value) {
            if (value != undefined) {
                this.downloadCount = value;
                this.hmProperty["downloadCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 读写数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPcount(value) {
            if (value != undefined) {
                this.pcount = value;
                this.hmProperty["pcount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScore(value) {
            if (value != undefined) {
                this.score = value;
                this.hmProperty["score"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperTypeId(value) {
            if (value != undefined) {
                this.paperTypeId = value;
                this.hmProperty["paperTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 论文状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperStatusId(value) {
            if (value != undefined) {
                this.paperStatusId = value;
                this.hmProperty["paperStatusId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 问题提出(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAskQuestion(value) {
            if (value != undefined) {
                this.askQuestion = value;
                this.hmProperty["askQuestion"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 目前研究的现状(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResearchStatus(value) {
            if (value != undefined) {
                this.researchStatus = value;
                this.hmProperty["researchStatus"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 创新点(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetInnovationPoints(value) {
            if (value != undefined) {
                this.innovationPoints = value;
                this.hmProperty["innovationPoints"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 研究设计(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResearchDesign(value) {
            if (value != undefined) {
                this.researchDesign = value;
                this.hmProperty["researchDesign"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 数据处理的维度(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDimensionDataProcess(value) {
            if (value != undefined) {
                this.dimensionDataProcess = value;
                this.hmProperty["dimensionDataProcess"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 预期结论(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExpectedConclusion(value) {
            if (value != undefined) {
                this.expectedConclusion = value;
                this.hmProperty["expectedConclusion"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 论文答疑数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperQCount(value) {
            if (value != undefined) {
                this.paperQCount = value;
                this.hmProperty["paperQCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 论文子观点数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSubVCount(value) {
            if (value != undefined) {
                this.subVCount = value;
                this.hmProperty["subVCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教师提问数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTeaQCount(value) {
            if (value != undefined) {
                this.teaQCount = value;
                this.hmProperty["teaQCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                case clsPaperEN.con_PaperId:
                    return this.paperId;
                case clsPaperEN.con_PaperTitle:
                    return this.paperTitle;
                case clsPaperEN.con_PaperContent:
                    return this.paperContent;
                case clsPaperEN.con_Periodical:
                    return this.periodical;
                case clsPaperEN.con_Author:
                    return this.author;
                case clsPaperEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsPaperEN.con_Keyword:
                    return this.keyword;
                case clsPaperEN.con_LiteratureSources:
                    return this.literatureSources;
                case clsPaperEN.con_LiteratureLink:
                    return this.literatureLink;
                case clsPaperEN.con_UploadfileUrl:
                    return this.uploadfileUrl;
                case clsPaperEN.con_IsQuotethesis:
                    return this.isQuotethesis;
                case clsPaperEN.con_QuoteId:
                    return this.quoteId;
                case clsPaperEN.con_IsChecked:
                    return this.isChecked;
                case clsPaperEN.con_Checker:
                    return this.checker;
                case clsPaperEN.con_LiteratureTypeId:
                    return this.literatureTypeId;
                case clsPaperEN.con_BrowseNumber:
                    return this.browseNumber;
                case clsPaperEN.con_IsSubmit:
                    return this.isSubmit;
                case clsPaperEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsPaperEN.con_AttachmentCount:
                    return this.attachmentCount;
                case clsPaperEN.con_CollectionCount:
                    return this.collectionCount;
                case clsPaperEN.con_DownloadCount:
                    return this.downloadCount;
                case clsPaperEN.con_OkCount:
                    return this.okCount;
                case clsPaperEN.con_Pcount:
                    return this.pcount;
                case clsPaperEN.con_Score:
                    return this.score;
                case clsPaperEN.con_StuScore:
                    return this.stuScore;
                case clsPaperEN.con_TeaScore:
                    return this.teaScore;
                case clsPaperEN.con_PaperTypeId:
                    return this.paperTypeId;
                case clsPaperEN.con_PaperStatusId:
                    return this.paperStatusId;
                case clsPaperEN.con_VersionCount:
                    return this.versionCount;
                case clsPaperEN.con_IsPublic:
                    return this.isPublic;
                case clsPaperEN.con_AskQuestion:
                    return this.askQuestion;
                case clsPaperEN.con_ResearchStatus:
                    return this.researchStatus;
                case clsPaperEN.con_InnovationPoints:
                    return this.innovationPoints;
                case clsPaperEN.con_ResearchDesign:
                    return this.researchDesign;
                case clsPaperEN.con_DimensionDataProcess:
                    return this.dimensionDataProcess;
                case clsPaperEN.con_ExpectedConclusion:
                    return this.expectedConclusion;
                case clsPaperEN.con_ShareId:
                    return this.shareId;
                case clsPaperEN.con_PaperQCount:
                    return this.paperQCount;
                case clsPaperEN.con_SubVCount:
                    return this.subVCount;
                case clsPaperEN.con_TagsCount:
                    return this.tagsCount;
                case clsPaperEN.con_TeaQCount:
                    return this.teaQCount;
                case clsPaperEN.con_CreateDate:
                    return this.createDate;
                case clsPaperEN.con_UpdUser:
                    return this.updUser;
                case clsPaperEN.con_UpdDate:
                    return this.updDate;
                case clsPaperEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[Paper]中不存在！`;
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
                case clsPaperEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsPaperEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    this.hmProperty["paperTitle"] = true;
                    break;
                case clsPaperEN.con_PaperContent:
                    this.paperContent = strValue;
                    this.hmProperty["paperContent"] = true;
                    break;
                case clsPaperEN.con_Periodical:
                    this.periodical = strValue;
                    this.hmProperty["periodical"] = true;
                    break;
                case clsPaperEN.con_Author:
                    this.author = strValue;
                    this.hmProperty["author"] = true;
                    break;
                case clsPaperEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    this.hmProperty["researchQuestion"] = true;
                    break;
                case clsPaperEN.con_Keyword:
                    this.keyword = strValue;
                    this.hmProperty["keyword"] = true;
                    break;
                case clsPaperEN.con_LiteratureSources:
                    this.literatureSources = strValue;
                    this.hmProperty["literatureSources"] = true;
                    break;
                case clsPaperEN.con_LiteratureLink:
                    this.literatureLink = strValue;
                    this.hmProperty["literatureLink"] = true;
                    break;
                case clsPaperEN.con_UploadfileUrl:
                    this.uploadfileUrl = strValue;
                    this.hmProperty["uploadfileUrl"] = true;
                    break;
                case clsPaperEN.con_IsQuotethesis:
                    this.isQuotethesis = Boolean(strValue);
                    this.hmProperty["isQuotethesis"] = true;
                    break;
                case clsPaperEN.con_QuoteId:
                    this.quoteId = strValue;
                    this.hmProperty["quoteId"] = true;
                    break;
                case clsPaperEN.con_IsChecked:
                    this.isChecked = Boolean(strValue);
                    this.hmProperty["isChecked"] = true;
                    break;
                case clsPaperEN.con_Checker:
                    this.checker = strValue;
                    this.hmProperty["checker"] = true;
                    break;
                case clsPaperEN.con_LiteratureTypeId:
                    this.literatureTypeId = strValue;
                    this.hmProperty["literatureTypeId"] = true;
                    break;
                case clsPaperEN.con_BrowseNumber:
                    this.browseNumber = Number(strValue);
                    this.hmProperty["browseNumber"] = true;
                    break;
                case clsPaperEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsPaperEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    this.hmProperty["appraiseCount"] = true;
                    break;
                case clsPaperEN.con_AttachmentCount:
                    this.attachmentCount = Number(strValue);
                    this.hmProperty["attachmentCount"] = true;
                    break;
                case clsPaperEN.con_CollectionCount:
                    this.collectionCount = Number(strValue);
                    this.hmProperty["collectionCount"] = true;
                    break;
                case clsPaperEN.con_DownloadCount:
                    this.downloadCount = Number(strValue);
                    this.hmProperty["downloadCount"] = true;
                    break;
                case clsPaperEN.con_OkCount:
                    this.okCount = Number(strValue);
                    this.hmProperty["okCount"] = true;
                    break;
                case clsPaperEN.con_Pcount:
                    this.pcount = Number(strValue);
                    this.hmProperty["pcount"] = true;
                    break;
                case clsPaperEN.con_Score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsPaperEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    this.hmProperty["stuScore"] = true;
                    break;
                case clsPaperEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    this.hmProperty["teaScore"] = true;
                    break;
                case clsPaperEN.con_PaperTypeId:
                    this.paperTypeId = strValue;
                    this.hmProperty["paperTypeId"] = true;
                    break;
                case clsPaperEN.con_PaperStatusId:
                    this.paperStatusId = strValue;
                    this.hmProperty["paperStatusId"] = true;
                    break;
                case clsPaperEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    this.hmProperty["versionCount"] = true;
                    break;
                case clsPaperEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    this.hmProperty["isPublic"] = true;
                    break;
                case clsPaperEN.con_AskQuestion:
                    this.askQuestion = strValue;
                    this.hmProperty["askQuestion"] = true;
                    break;
                case clsPaperEN.con_ResearchStatus:
                    this.researchStatus = strValue;
                    this.hmProperty["researchStatus"] = true;
                    break;
                case clsPaperEN.con_InnovationPoints:
                    this.innovationPoints = strValue;
                    this.hmProperty["innovationPoints"] = true;
                    break;
                case clsPaperEN.con_ResearchDesign:
                    this.researchDesign = strValue;
                    this.hmProperty["researchDesign"] = true;
                    break;
                case clsPaperEN.con_DimensionDataProcess:
                    this.dimensionDataProcess = strValue;
                    this.hmProperty["dimensionDataProcess"] = true;
                    break;
                case clsPaperEN.con_ExpectedConclusion:
                    this.expectedConclusion = strValue;
                    this.hmProperty["expectedConclusion"] = true;
                    break;
                case clsPaperEN.con_ShareId:
                    this.shareId = strValue;
                    this.hmProperty["shareId"] = true;
                    break;
                case clsPaperEN.con_PaperQCount:
                    this.paperQCount = Number(strValue);
                    this.hmProperty["paperQCount"] = true;
                    break;
                case clsPaperEN.con_SubVCount:
                    this.subVCount = Number(strValue);
                    this.hmProperty["subVCount"] = true;
                    break;
                case clsPaperEN.con_TagsCount:
                    this.tagsCount = Number(strValue);
                    this.hmProperty["tagsCount"] = true;
                    break;
                case clsPaperEN.con_TeaQCount:
                    this.teaQCount = Number(strValue);
                    this.hmProperty["teaQCount"] = true;
                    break;
                case clsPaperEN.con_CreateDate:
                    this.createDate = strValue;
                    this.hmProperty["createDate"] = true;
                    break;
                case clsPaperEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsPaperEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsPaperEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[Paper]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"PaperContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperContent() { return "paperContent"; } //主题内容
        /**
        * 常量:"Periodical"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Periodical() { return "periodical"; } //期刊
        /**
        * 常量:"Author"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Author() { return "author"; } //作者
        /**
        * 常量:"ResearchQuestion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResearchQuestion() { return "researchQuestion"; } //研究问题
        /**
        * 常量:"Keyword"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Keyword() { return "keyword"; } //关键字
        /**
        * 常量:"LiteratureSources"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureSources() { return "literatureSources"; } //文献来源
        /**
        * 常量:"LiteratureLink"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureLink() { return "literatureLink"; } //文献链接
        /**
        * 常量:"UploadfileUrl"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UploadfileUrl() { return "uploadfileUrl"; } //文件地址
        /**
        * 常量:"IsQuotethesis"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsQuotethesis() { return "isQuotethesis"; } //是否引用论文
        /**
        * 常量:"QuoteId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuoteId() { return "quoteId"; } //引用Id
        /**
        * 常量:"IsChecked"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsChecked() { return "isChecked"; } //是否检查
        /**
        * 常量:"Checker"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Checker() { return "checker"; } //审核人
        /**
        * 常量:"LiteratureTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeId() { return "literatureTypeId"; } //作文类型Id
        /**
        * 常量:"BrowseNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BrowseNumber() { return "browseNumber"; } //浏览量
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
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
        static get con_CollectionCount() { return "collectionCount"; } //收藏数量
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
        * 常量:"Score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Score() { return "score"; } //评分
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
        * 常量:"PaperTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTypeId() { return "paperTypeId"; } //论文类型Id
        /**
        * 常量:"PaperStatusId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperStatusId() { return "paperStatusId"; } //论文状态Id
        /**
        * 常量:"VersionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /**
        * 常量:"IsPublic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsPublic() { return "isPublic"; } //是否公开
        /**
        * 常量:"AskQuestion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AskQuestion() { return "askQuestion"; } //问题提出
        /**
        * 常量:"ResearchStatus"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResearchStatus() { return "researchStatus"; } //目前研究的现状
        /**
        * 常量:"InnovationPoints"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_InnovationPoints() { return "innovationPoints"; } //创新点
        /**
        * 常量:"ResearchDesign"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResearchDesign() { return "researchDesign"; } //研究设计
        /**
        * 常量:"DimensionDataProcess"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DimensionDataProcess() { return "dimensionDataProcess"; } //数据处理的维度
        /**
        * 常量:"ExpectedConclusion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExpectedConclusion() { return "expectedConclusion"; } //预期结论
        /**
        * 常量:"ShareId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareId() { return "shareId"; } //分享Id
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
        * 常量:"CreateDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateDate() { return "createDate"; } //建立日期
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
    exports.clsPaperEN = clsPaperEN;
    clsPaperEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsPaperEN.CacheModeId = ""; //
    clsPaperEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsPaperEN.WhereFormat = "PaperId in (Select PaperId from PaperEduClsRela where Id_CurrEduCls='{0}'))"; //条件格式串
    clsPaperEN._CurrTabName = "Paper"; //当前表名,与该类相关的表名
    clsPaperEN._KeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsPaperEN.mintAttributeCount = 45;
    clsPaperEN.AttributeName = ["paperId", "paperTitle", "paperContent", "periodical", "author", "researchQuestion", "keyword", "literatureSources", "literatureLink", "uploadfileUrl", "isQuotethesis", "quoteId", "isChecked", "checker", "literatureTypeId", "browseNumber", "isSubmit", "appraiseCount", "attachmentCount", "collectionCount", "downloadCount", "okCount", "pcount", "score", "stuScore", "teaScore", "paperTypeId", "paperStatusId", "versionCount", "isPublic", "askQuestion", "researchStatus", "innovationPoints", "researchDesign", "dimensionDataProcess", "expectedConclusion", "shareId", "paperQCount", "subVCount", "tagsCount", "teaQCount", "createDate", "updUser", "updDate", "memo"];
});
