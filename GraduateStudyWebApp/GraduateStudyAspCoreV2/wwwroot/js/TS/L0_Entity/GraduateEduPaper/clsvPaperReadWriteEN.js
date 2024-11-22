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
    exports.clsvPaperReadWriteEN = void 0;
    /**
    * 类名:clsvPaperReadWriteEN
    * 表名:vPaperReadWrite(01120550)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:55:15
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
    * v论文读写表(vPaperReadWrite)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvPaperReadWriteEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paperRWId = ""; //课文阅读
            this.readerId = ""; //阅读者Id
            this.paperId = ""; //论文Id
            this.paperTitle = ""; //论文标题
            this.paperContent = ""; //主题内容
            this.periodical = ""; //期刊
            this.author = ""; //作者
            this.keyword = ""; //关键字
            this.researchQuestion = ""; //研究问题
            this.operationTypeId = ""; //操作类型ID
            this.operationTypeName = ""; //操作类型名
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.literatureLink = ""; //文献链接
            this.literatureSources = ""; //文献来源
            this.literatureTypeId = ""; //作文类型Id
            this.literatureTypeName = ""; //作文类型名
            this.uploadfileUrl = ""; //文件地址
            this.isPublic = false; //是否公开
            this.isSubmit = false; //是否提交
            this.submitter = ""; //提交人
            this.pcount = 0; //读写数
            this.teaCount = 0; //TeaCount
            this.id_CurrEduCls = ""; //教学班流水号
            this.subVCount = 0; //论文子观点数
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.updUser = ""; //修改人
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
                case clsvPaperReadWriteEN.con_PaperRWId:
                    return this.paperRWId;
                case clsvPaperReadWriteEN.con_ReaderId:
                    return this.readerId;
                case clsvPaperReadWriteEN.con_PaperId:
                    return this.paperId;
                case clsvPaperReadWriteEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvPaperReadWriteEN.con_PaperContent:
                    return this.paperContent;
                case clsvPaperReadWriteEN.con_Periodical:
                    return this.periodical;
                case clsvPaperReadWriteEN.con_Author:
                    return this.author;
                case clsvPaperReadWriteEN.con_Keyword:
                    return this.keyword;
                case clsvPaperReadWriteEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsvPaperReadWriteEN.con_OperationTypeId:
                    return this.operationTypeId;
                case clsvPaperReadWriteEN.con_OperationTypeName:
                    return this.operationTypeName;
                case clsvPaperReadWriteEN.con_UpdDate:
                    return this.updDate;
                case clsvPaperReadWriteEN.con_Memo:
                    return this.memo;
                case clsvPaperReadWriteEN.con_LiteratureLink:
                    return this.literatureLink;
                case clsvPaperReadWriteEN.con_LiteratureSources:
                    return this.literatureSources;
                case clsvPaperReadWriteEN.con_LiteratureTypeId:
                    return this.literatureTypeId;
                case clsvPaperReadWriteEN.con_LiteratureTypeName:
                    return this.literatureTypeName;
                case clsvPaperReadWriteEN.con_UploadfileUrl:
                    return this.uploadfileUrl;
                case clsvPaperReadWriteEN.con_IsPublic:
                    return this.isPublic;
                case clsvPaperReadWriteEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvPaperReadWriteEN.con_Submitter:
                    return this.submitter;
                case clsvPaperReadWriteEN.con_Pcount:
                    return this.pcount;
                case clsvPaperReadWriteEN.con_TeaCount:
                    return this.teaCount;
                case clsvPaperReadWriteEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvPaperReadWriteEN.con_SubVCount:
                    return this.subVCount;
                case clsvPaperReadWriteEN.con_CreateDate:
                    return this.createDate;
                case clsvPaperReadWriteEN.con_ShareId:
                    return this.shareId;
                case clsvPaperReadWriteEN.con_UpdUser:
                    return this.updUser;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperReadWrite]中不存在！`;
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
                case clsvPaperReadWriteEN.con_PaperRWId:
                    this.paperRWId = strValue;
                    break;
                case clsvPaperReadWriteEN.con_ReaderId:
                    this.readerId = strValue;
                    break;
                case clsvPaperReadWriteEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvPaperReadWriteEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvPaperReadWriteEN.con_PaperContent:
                    this.paperContent = strValue;
                    break;
                case clsvPaperReadWriteEN.con_Periodical:
                    this.periodical = strValue;
                    break;
                case clsvPaperReadWriteEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvPaperReadWriteEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvPaperReadWriteEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    break;
                case clsvPaperReadWriteEN.con_OperationTypeId:
                    this.operationTypeId = strValue;
                    break;
                case clsvPaperReadWriteEN.con_OperationTypeName:
                    this.operationTypeName = strValue;
                    break;
                case clsvPaperReadWriteEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvPaperReadWriteEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvPaperReadWriteEN.con_LiteratureLink:
                    this.literatureLink = strValue;
                    break;
                case clsvPaperReadWriteEN.con_LiteratureSources:
                    this.literatureSources = strValue;
                    break;
                case clsvPaperReadWriteEN.con_LiteratureTypeId:
                    this.literatureTypeId = strValue;
                    break;
                case clsvPaperReadWriteEN.con_LiteratureTypeName:
                    this.literatureTypeName = strValue;
                    break;
                case clsvPaperReadWriteEN.con_UploadfileUrl:
                    this.uploadfileUrl = strValue;
                    break;
                case clsvPaperReadWriteEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    break;
                case clsvPaperReadWriteEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvPaperReadWriteEN.con_Submitter:
                    this.submitter = strValue;
                    break;
                case clsvPaperReadWriteEN.con_Pcount:
                    this.pcount = Number(strValue);
                    break;
                case clsvPaperReadWriteEN.con_TeaCount:
                    this.teaCount = Number(strValue);
                    break;
                case clsvPaperReadWriteEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvPaperReadWriteEN.con_SubVCount:
                    this.subVCount = Number(strValue);
                    break;
                case clsvPaperReadWriteEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvPaperReadWriteEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvPaperReadWriteEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperReadWrite]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PaperRWId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperRWId() { return "paperRWId"; } //课文阅读
        /**
        * 常量:"ReaderId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReaderId() { return "readerId"; } //阅读者Id
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
        * 常量:"Keyword"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Keyword() { return "keyword"; } //关键字
        /**
        * 常量:"ResearchQuestion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResearchQuestion() { return "researchQuestion"; } //研究问题
        /**
        * 常量:"OperationTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OperationTypeId() { return "operationTypeId"; } //操作类型ID
        /**
        * 常量:"OperationTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OperationTypeName() { return "operationTypeName"; } //操作类型名
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
        * 常量:"LiteratureLink"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureLink() { return "literatureLink"; } //文献链接
        /**
        * 常量:"LiteratureSources"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureSources() { return "literatureSources"; } //文献来源
        /**
        * 常量:"LiteratureTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeId() { return "literatureTypeId"; } //作文类型Id
        /**
        * 常量:"LiteratureTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeName() { return "literatureTypeName"; } //作文类型名
        /**
        * 常量:"UploadfileUrl"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UploadfileUrl() { return "uploadfileUrl"; } //文件地址
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
        * 常量:"Submitter"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Submitter() { return "submitter"; } //提交人
        /**
        * 常量:"Pcount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Pcount() { return "pcount"; } //读写数
        /**
        * 常量:"TeaCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaCount() { return "teaCount"; } //TeaCount
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"SubVCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubVCount() { return "subVCount"; } //论文子观点数
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
    exports.clsvPaperReadWriteEN = clsvPaperReadWriteEN;
    clsvPaperReadWriteEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPaperReadWriteEN.CacheModeId = "04"; //sessionStorage
    clsvPaperReadWriteEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvPaperReadWriteEN.WhereFormat = ""; //条件格式串
    clsvPaperReadWriteEN._CurrTabName = "vPaperReadWrite"; //当前表名,与该类相关的表名
    clsvPaperReadWriteEN._KeyFldName = "PaperRWId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPaperReadWriteEN.mintAttributeCount = 28;
    clsvPaperReadWriteEN.AttributeName = ["paperRWId", "readerId", "paperId", "paperTitle", "paperContent", "periodical", "author", "keyword", "researchQuestion", "operationTypeId", "operationTypeName", "updDate", "memo", "literatureLink", "literatureSources", "literatureTypeId", "literatureTypeName", "uploadfileUrl", "isPublic", "isSubmit", "submitter", "pcount", "teaCount", "id_CurrEduCls", "subVCount", "createDate", "shareId", "updUser"];
});
