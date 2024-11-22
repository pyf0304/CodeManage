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
    exports.clsvgs_PaperAttentionEN = void 0;
    /**
    * 类名:clsvgs_PaperAttentionEN
    * 表名:vgs_PaperAttention(01120750)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:44
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
    * 论文关注视图(vgs_PaperAttention)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_PaperAttentionEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paperAttentionId = 0; //论文收藏Id
            this.paperId = ""; //论文Id
            this.paperTitle = ""; //论文标题
            this.author = ""; //作者
            this.keyword = ""; //关键字
            this.browseNumber = 0; //浏览量
            this.userId = ""; //用户ID
            this.paperGroupId = ""; //组Id
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.meno = ""; //备注
            this.paperGroupName = ""; //组名
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
                case clsvgs_PaperAttentionEN.con_PaperAttentionId:
                    return this.paperAttentionId;
                case clsvgs_PaperAttentionEN.con_PaperId:
                    return this.paperId;
                case clsvgs_PaperAttentionEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvgs_PaperAttentionEN.con_Author:
                    return this.author;
                case clsvgs_PaperAttentionEN.con_Keyword:
                    return this.keyword;
                case clsvgs_PaperAttentionEN.con_BrowseNumber:
                    return this.browseNumber;
                case clsvgs_PaperAttentionEN.con_UserId:
                    return this.userId;
                case clsvgs_PaperAttentionEN.con_PaperGroupId:
                    return this.paperGroupId;
                case clsvgs_PaperAttentionEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_PaperAttentionEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_PaperAttentionEN.con_Meno:
                    return this.meno;
                case clsvgs_PaperAttentionEN.con_PaperGroupName:
                    return this.paperGroupName;
                case clsvgs_PaperAttentionEN.con_PaperQCount:
                    return this.paperQCount;
                case clsvgs_PaperAttentionEN.con_SubVCount:
                    return this.subVCount;
                case clsvgs_PaperAttentionEN.con_TagsCount:
                    return this.tagsCount;
                case clsvgs_PaperAttentionEN.con_TeaQCount:
                    return this.teaQCount;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PaperAttention]中不存在！`;
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
                case clsvgs_PaperAttentionEN.con_PaperAttentionId:
                    this.paperAttentionId = Number(strValue);
                    break;
                case clsvgs_PaperAttentionEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_BrowseNumber:
                    this.browseNumber = Number(strValue);
                    break;
                case clsvgs_PaperAttentionEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_PaperGroupId:
                    this.paperGroupId = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_Meno:
                    this.meno = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_PaperGroupName:
                    this.paperGroupName = strValue;
                    break;
                case clsvgs_PaperAttentionEN.con_PaperQCount:
                    this.paperQCount = Number(strValue);
                    break;
                case clsvgs_PaperAttentionEN.con_SubVCount:
                    this.subVCount = Number(strValue);
                    break;
                case clsvgs_PaperAttentionEN.con_TagsCount:
                    this.tagsCount = Number(strValue);
                    break;
                case clsvgs_PaperAttentionEN.con_TeaQCount:
                    this.teaQCount = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PaperAttention]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PaperAttentionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperAttentionId() { return "paperAttentionId"; } //论文收藏Id
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
        * 常量:"BrowseNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BrowseNumber() { return "browseNumber"; } //浏览量
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"PaperGroupId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperGroupId() { return "paperGroupId"; } //组Id
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
        * 常量:"Meno"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Meno() { return "meno"; } //备注
        /**
        * 常量:"PaperGroupName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperGroupName() { return "paperGroupName"; } //组名
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
    exports.clsvgs_PaperAttentionEN = clsvgs_PaperAttentionEN;
    clsvgs_PaperAttentionEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_PaperAttentionEN.CacheModeId = "04"; //sessionStorage
    clsvgs_PaperAttentionEN._CurrTabName = "vgs_PaperAttention"; //当前表名,与该类相关的表名
    clsvgs_PaperAttentionEN._KeyFldName = "PaperAttentionId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_PaperAttentionEN.mintAttributeCount = 16;
    clsvgs_PaperAttentionEN.AttributeName = ["paperAttentionId", "paperId", "paperTitle", "author", "keyword", "browseNumber", "userId", "paperGroupId", "updUser", "updDate", "meno", "paperGroupName", "paperQCount", "subVCount", "tagsCount", "teaQCount"];
});
