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
    exports.clsvSectionEN = void 0;
    /**
    * 类名:clsvSectionEN
    * 表名:vSection(01120559)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:44:15
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
    * 论文节视图(vSection)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvSectionEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.sectionId = ""; //节Id
            this.sectionName = ""; //节名
            this.paperId = ""; //论文Id
            this.orderNum = 0; //序号
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.paperTitle = ""; //论文标题
            this.author = ""; //作者
            this.researchQuestion = ""; //研究问题
            this.keyword = ""; //关键字
            this.parentId = ""; //父节点Id
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
                case clsvSectionEN.con_SectionId:
                    return this.sectionId;
                case clsvSectionEN.con_SectionName:
                    return this.sectionName;
                case clsvSectionEN.con_PaperId:
                    return this.paperId;
                case clsvSectionEN.con_OrderNum:
                    return this.orderNum;
                case clsvSectionEN.con_UpdDate:
                    return this.updDate;
                case clsvSectionEN.con_UpdUser:
                    return this.updUser;
                case clsvSectionEN.con_Memo:
                    return this.memo;
                case clsvSectionEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvSectionEN.con_Author:
                    return this.author;
                case clsvSectionEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsvSectionEN.con_Keyword:
                    return this.keyword;
                case clsvSectionEN.con_ParentId:
                    return this.parentId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSection]中不存在！`;
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
                case clsvSectionEN.con_SectionId:
                    this.sectionId = strValue;
                    break;
                case clsvSectionEN.con_SectionName:
                    this.sectionName = strValue;
                    break;
                case clsvSectionEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvSectionEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvSectionEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvSectionEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvSectionEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvSectionEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvSectionEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvSectionEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    break;
                case clsvSectionEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvSectionEN.con_ParentId:
                    this.parentId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSection]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"SectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionId() { return "sectionId"; } //节Id
        /**
        * 常量:"SectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName() { return "sectionName"; } //节名
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
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
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
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
        * 常量:"ParentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentId() { return "parentId"; } //父节点Id
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
    exports.clsvSectionEN = clsvSectionEN;
    clsvSectionEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvSectionEN.CacheModeId = "04"; //sessionStorage
    clsvSectionEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvSectionEN.WhereFormat = ""; //条件格式串
    clsvSectionEN._CurrTabName = "vSection"; //当前表名,与该类相关的表名
    clsvSectionEN._KeyFldName = "SectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvSectionEN.mintAttributeCount = 12;
    clsvSectionEN.AttributeName = ["sectionId", "sectionName", "paperId", "orderNum", "updDate", "updUser", "memo", "paperTitle", "author", "researchQuestion", "keyword", "parentId"];
});
