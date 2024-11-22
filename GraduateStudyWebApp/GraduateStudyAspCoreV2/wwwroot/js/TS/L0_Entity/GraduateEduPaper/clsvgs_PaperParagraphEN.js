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
    exports.clsvgs_PaperParagraphEN = void 0;
    /**
    * 类名:clsvgs_PaperParagraphEN
    * 表名:vgs_PaperParagraph(01120747)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:53:29
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
    * 论文段落视图(vgs_PaperParagraph)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_PaperParagraphEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paragraphId = ""; //段落Id
            this.paragraphStateName = ""; //段落状态
            this.paragraphTypeName = ""; //段落类型
            this.paperId = ""; //论文Id
            this.sectionId = ""; //节Id
            this.paragraphStateId = ""; //段落状态Id
            this.paragraphTypeId = ""; //段落类型Id
            this.paragraphContent = ""; //段落内容
            this.voteCount = 0; //点赞计数
            this.commentCount = 0; //评论数
            this.versionCount = 0; //版本统计
            this.createDate = ""; //建立日期
            this.createUser = ""; //建立用户
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.orderNum = 0; //序号
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
                case clsvgs_PaperParagraphEN.con_ParagraphId:
                    return this.paragraphId;
                case clsvgs_PaperParagraphEN.con_ParagraphStateName:
                    return this.paragraphStateName;
                case clsvgs_PaperParagraphEN.con_ParagraphTypeName:
                    return this.paragraphTypeName;
                case clsvgs_PaperParagraphEN.con_PaperId:
                    return this.paperId;
                case clsvgs_PaperParagraphEN.con_SectionId:
                    return this.sectionId;
                case clsvgs_PaperParagraphEN.con_ParagraphStateId:
                    return this.paragraphStateId;
                case clsvgs_PaperParagraphEN.con_ParagraphTypeId:
                    return this.paragraphTypeId;
                case clsvgs_PaperParagraphEN.con_ParagraphContent:
                    return this.paragraphContent;
                case clsvgs_PaperParagraphEN.con_VoteCount:
                    return this.voteCount;
                case clsvgs_PaperParagraphEN.con_CommentCount:
                    return this.commentCount;
                case clsvgs_PaperParagraphEN.con_VersionCount:
                    return this.versionCount;
                case clsvgs_PaperParagraphEN.con_CreateDate:
                    return this.createDate;
                case clsvgs_PaperParagraphEN.con_CreateUser:
                    return this.createUser;
                case clsvgs_PaperParagraphEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_PaperParagraphEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_PaperParagraphEN.con_Memo:
                    return this.memo;
                case clsvgs_PaperParagraphEN.con_OrderNum:
                    return this.orderNum;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PaperParagraph]中不存在！`;
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
                case clsvgs_PaperParagraphEN.con_ParagraphId:
                    this.paragraphId = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_ParagraphStateName:
                    this.paragraphStateName = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_ParagraphTypeName:
                    this.paragraphTypeName = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_SectionId:
                    this.sectionId = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_ParagraphStateId:
                    this.paragraphStateId = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_ParagraphTypeId:
                    this.paragraphTypeId = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_ParagraphContent:
                    this.paragraphContent = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_VoteCount:
                    this.voteCount = Number(strValue);
                    break;
                case clsvgs_PaperParagraphEN.con_CommentCount:
                    this.commentCount = Number(strValue);
                    break;
                case clsvgs_PaperParagraphEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvgs_PaperParagraphEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_CreateUser:
                    this.createUser = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvgs_PaperParagraphEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PaperParagraph]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ParagraphId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphId() { return "paragraphId"; } //段落Id
        /**
        * 常量:"ParagraphStateName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphStateName() { return "paragraphStateName"; } //段落状态
        /**
        * 常量:"ParagraphTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphTypeName() { return "paragraphTypeName"; } //段落类型
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"SectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionId() { return "sectionId"; } //节Id
        /**
        * 常量:"ParagraphStateId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphStateId() { return "paragraphStateId"; } //段落状态Id
        /**
        * 常量:"ParagraphTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphTypeId() { return "paragraphTypeId"; } //段落类型Id
        /**
        * 常量:"ParagraphContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParagraphContent() { return "paragraphContent"; } //段落内容
        /**
        * 常量:"VoteCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteCount() { return "voteCount"; } //点赞计数
        /**
        * 常量:"CommentCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CommentCount() { return "commentCount"; } //评论数
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
        * 常量:"CreateUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateUser() { return "createUser"; } //建立用户
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
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
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
    exports.clsvgs_PaperParagraphEN = clsvgs_PaperParagraphEN;
    clsvgs_PaperParagraphEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_PaperParagraphEN.CacheModeId = "02"; //客户端缓存
    clsvgs_PaperParagraphEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvgs_PaperParagraphEN.WhereFormat = ""; //条件格式串
    clsvgs_PaperParagraphEN._CurrTabName = "vgs_PaperParagraph"; //当前表名,与该类相关的表名
    clsvgs_PaperParagraphEN._KeyFldName = "ParagraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_PaperParagraphEN.mintAttributeCount = 17;
    clsvgs_PaperParagraphEN.AttributeName = ["paragraphId", "paragraphStateName", "paragraphTypeName", "paperId", "sectionId", "paragraphStateId", "paragraphTypeId", "paragraphContent", "voteCount", "commentCount", "versionCount", "createDate", "createUser", "updDate", "updUser", "memo", "orderNum"];
});
