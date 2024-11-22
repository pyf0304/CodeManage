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
    exports.clsvMajorDirectionPaperRelaEN = void 0;
    /**
    * 类名:clsvMajorDirectionPaperRelaEN
    * 表名:vMajorDirectionPaperRela(01120555)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:38
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
    * v专业方向论文关系(vMajorDirectionPaperRela)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvMajorDirectionPaperRelaEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.mId = 0; //mId
            this.majorDirectionId = ""; //研究方向Id
            this.paperId = ""; //论文Id
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.id_XzMajor = ""; //专业流水号
            this.majorDirectionENName = ""; //研究方向英文名
            this.majorDirectionName = ""; //研究方向名
            this.majorDirectionExplain = ""; //专业方向说明
            this.isVisible = false; //是否显示
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
            this.checker = ""; //审核人
            this.isChecked = false; //是否检查
            this.majorID = ""; //专业ID
            this.majorName = ""; //专业名称
            this.userName = ""; //用户名
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
                case clsvMajorDirectionPaperRelaEN.con_mId:
                    return this.mId;
                case clsvMajorDirectionPaperRelaEN.con_MajorDirectionId:
                    return this.majorDirectionId;
                case clsvMajorDirectionPaperRelaEN.con_PaperId:
                    return this.paperId;
                case clsvMajorDirectionPaperRelaEN.con_UpdDate:
                    return this.updDate;
                case clsvMajorDirectionPaperRelaEN.con_UpdUser:
                    return this.updUser;
                case clsvMajorDirectionPaperRelaEN.con_Memo:
                    return this.memo;
                case clsvMajorDirectionPaperRelaEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName:
                    return this.majorDirectionENName;
                case clsvMajorDirectionPaperRelaEN.con_MajorDirectionName:
                    return this.majorDirectionName;
                case clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain:
                    return this.majorDirectionExplain;
                case clsvMajorDirectionPaperRelaEN.con_IsVisible:
                    return this.isVisible;
                case clsvMajorDirectionPaperRelaEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvMajorDirectionPaperRelaEN.con_PaperContent:
                    return this.paperContent;
                case clsvMajorDirectionPaperRelaEN.con_Periodical:
                    return this.periodical;
                case clsvMajorDirectionPaperRelaEN.con_Author:
                    return this.author;
                case clsvMajorDirectionPaperRelaEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsvMajorDirectionPaperRelaEN.con_Keyword:
                    return this.keyword;
                case clsvMajorDirectionPaperRelaEN.con_LiteratureSources:
                    return this.literatureSources;
                case clsvMajorDirectionPaperRelaEN.con_LiteratureLink:
                    return this.literatureLink;
                case clsvMajorDirectionPaperRelaEN.con_UploadfileUrl:
                    return this.uploadfileUrl;
                case clsvMajorDirectionPaperRelaEN.con_IsQuotethesis:
                    return this.isQuotethesis;
                case clsvMajorDirectionPaperRelaEN.con_Checker:
                    return this.checker;
                case clsvMajorDirectionPaperRelaEN.con_IsChecked:
                    return this.isChecked;
                case clsvMajorDirectionPaperRelaEN.con_MajorID:
                    return this.majorID;
                case clsvMajorDirectionPaperRelaEN.con_MajorName:
                    return this.majorName;
                case clsvMajorDirectionPaperRelaEN.con_UserName:
                    return this.userName;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vMajorDirectionPaperRela]中不存在！`;
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
                case clsvMajorDirectionPaperRelaEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvMajorDirectionPaperRelaEN.con_MajorDirectionId:
                    this.majorDirectionId = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName:
                    this.majorDirectionENName = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_MajorDirectionName:
                    this.majorDirectionName = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain:
                    this.majorDirectionExplain = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_IsVisible:
                    this.isVisible = Boolean(strValue);
                    break;
                case clsvMajorDirectionPaperRelaEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_PaperContent:
                    this.paperContent = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_Periodical:
                    this.periodical = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_LiteratureSources:
                    this.literatureSources = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_LiteratureLink:
                    this.literatureLink = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_UploadfileUrl:
                    this.uploadfileUrl = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_IsQuotethesis:
                    this.isQuotethesis = Boolean(strValue);
                    break;
                case clsvMajorDirectionPaperRelaEN.con_Checker:
                    this.checker = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_IsChecked:
                    this.isChecked = Boolean(strValue);
                    break;
                case clsvMajorDirectionPaperRelaEN.con_MajorID:
                    this.majorID = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvMajorDirectionPaperRelaEN.con_UserName:
                    this.userName = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vMajorDirectionPaperRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"MajorDirectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionId() { return "majorDirectionId"; } //研究方向Id
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
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
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"MajorDirectionENName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionENName() { return "majorDirectionENName"; } //研究方向英文名
        /**
        * 常量:"MajorDirectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionName() { return "majorDirectionName"; } //研究方向名
        /**
        * 常量:"MajorDirectionExplain"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionExplain() { return "majorDirectionExplain"; } //专业方向说明
        /**
        * 常量:"IsVisible"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible() { return "isVisible"; } //是否显示
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
        * 常量:"Checker"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Checker() { return "checker"; } //审核人
        /**
        * 常量:"IsChecked"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsChecked() { return "isChecked"; } //是否检查
        /**
        * 常量:"MajorID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorID() { return "majorID"; } //专业ID
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
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
    exports.clsvMajorDirectionPaperRelaEN = clsvMajorDirectionPaperRelaEN;
    clsvMajorDirectionPaperRelaEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvMajorDirectionPaperRelaEN.CacheModeId = "05"; //未知
    clsvMajorDirectionPaperRelaEN._CurrTabName = "vMajorDirectionPaperRela"; //当前表名,与该类相关的表名
    clsvMajorDirectionPaperRelaEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvMajorDirectionPaperRelaEN.mintAttributeCount = 26;
    clsvMajorDirectionPaperRelaEN.AttributeName = ["mId", "majorDirectionId", "paperId", "updDate", "updUser", "memo", "id_XzMajor", "majorDirectionENName", "majorDirectionName", "majorDirectionExplain", "isVisible", "paperTitle", "paperContent", "periodical", "author", "researchQuestion", "keyword", "literatureSources", "literatureLink", "uploadfileUrl", "isQuotethesis", "checker", "isChecked", "majorID", "majorName", "userName"];
});
