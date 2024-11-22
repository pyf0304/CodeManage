(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsPaperEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsPaperENEx = void 0;
    /**
    * 类名:clsPaperENEx
    * 表名:Paper(01120535)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/15 23:44:12
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 论文表(Paper)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsPaperEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperEN.js");
    class clsPaperENEx extends clsPaperEN_js_1.clsPaperEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.id_CurrEduCls = ""; //教学班流水号
            this.paperTypeName = ""; //论文类型名
            this.isSysVote = false; //是否投票
            this.isCollection = false; //是否收藏
            this.isHasAttention = false; //是否收藏
            this.updUserName = ""; //UpdUserName
            this.ds_Author = ""; //作者
            this.ds_Periodical = ""; //期刊
            this.ds_Keyword = ""; //关键字
            this.ds_LiteratureSources = ""; //文献来源
            this.literatureTypeName = ""; //作文类型名
            this.paperStatusName = ""; //论文状态名
            this.majorDirectionId = ""; //研究方向Id
        }
        /**
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayerEx4TypeScript:Gen_ENEx_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            switch (strFldName) {
                case "CtrlId":
                    return "";
                case clsPaperENEx.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsPaperENEx.con_PaperTypeName:
                    return this.paperTypeName;
                case clsPaperENEx.con_IsSysVote:
                    return this.isSysVote;
                case clsPaperENEx.con_IsCollection:
                    return this.isCollection;
                case clsPaperENEx.con_IsHasAttention:
                    return this.isHasAttention;
                case clsPaperENEx.con_UpdUserName:
                    return this.updUserName;
                case clsPaperENEx.con_DS_Author:
                    return this.ds_Author;
                case clsPaperENEx.con_DS_Periodical:
                    return this.ds_Periodical;
                case clsPaperENEx.con_DS_Keyword:
                    return this.ds_Keyword;
                case clsPaperENEx.con_DS_LiteratureSources:
                    return this.ds_LiteratureSources;
                case clsPaperENEx.con_LiteratureTypeName:
                    return this.literatureTypeName;
                case clsPaperENEx.con_PaperStatusName:
                    return this.paperStatusName;
                case clsPaperENEx.con_MajorDirectionId:
                    return this.majorDirectionId;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"PaperTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTypeName() { return "paperTypeName"; } //论文类型名
        /**
        * 常量:"IsSysVote"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSysVote() { return "isSysVote"; } //是否投票
        /**
        * 常量:"IsCollection"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCollection() { return "isCollection"; } //是否收藏
        /**
        * 常量:"IsHasAttention"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsHasAttention() { return "isHasAttention"; } //是否收藏
        /**
        * 常量:"UpdUserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserName() { return "updUserName"; } //UpdUserName
        /**
        * 常量:"DS_Author"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DS_Author() { return "ds_Author"; } //作者
        /**
        * 常量:"DS_Periodical"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DS_Periodical() { return "ds_Periodical"; } //期刊
        /**
        * 常量:"DS_Keyword"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DS_Keyword() { return "ds_Keyword"; } //关键字
        /**
        * 常量:"DS_LiteratureSources"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DS_LiteratureSources() { return "ds_LiteratureSources"; } //文献来源
        /**
        * 常量:"LiteratureTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeName() { return "literatureTypeName"; } //作文类型名
        /**
        * 常量:"PaperStatusName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperStatusName() { return "paperStatusName"; } //论文状态名
        /**
        * 常量:"MajorDirectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionId() { return "majorDirectionId"; } //研究方向Id
        /**
         * 设置对象中某字段名的值.
         * (AutoGCLib.EntityLayerEx4TypeScript:Gen_ENEx_SetFldValue)
         * @param strFldName:字段名
         * @param strValue:字段值
         * @returns 字段值
        */
        SetFldValue(strFldName, strValue) {
            const strThisFuncName = "SetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsPaperENEx.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsPaperENEx.con_PaperTypeName:
                    this.paperTypeName = strValue;
                    this.hmProperty["paperTypeName"] = true;
                    break;
                case clsPaperENEx.con_IsSysVote:
                    this.isSysVote = Boolean(strValue);
                    this.hmProperty["isSysVote"] = true;
                    break;
                case clsPaperENEx.con_IsCollection:
                    this.isCollection = Boolean(strValue);
                    this.hmProperty["isCollection"] = true;
                    break;
                case clsPaperENEx.con_IsHasAttention:
                    this.isHasAttention = Boolean(strValue);
                    this.hmProperty["isHasAttention"] = true;
                    break;
                case clsPaperENEx.con_UpdUserName:
                    this.updUserName = strValue;
                    this.hmProperty["updUserName"] = true;
                    break;
                case clsPaperENEx.con_DS_Author:
                    this.ds_Author = strValue;
                    this.hmProperty["ds_Author"] = true;
                    break;
                case clsPaperENEx.con_DS_Periodical:
                    this.ds_Periodical = strValue;
                    this.hmProperty["ds_Periodical"] = true;
                    break;
                case clsPaperENEx.con_DS_Keyword:
                    this.ds_Keyword = strValue;
                    this.hmProperty["ds_Keyword"] = true;
                    break;
                case clsPaperENEx.con_DS_LiteratureSources:
                    this.ds_LiteratureSources = strValue;
                    this.hmProperty["ds_LiteratureSources"] = true;
                    break;
                case clsPaperENEx.con_LiteratureTypeName:
                    this.literatureTypeName = strValue;
                    this.hmProperty["literatureTypeName"] = true;
                    break;
                case clsPaperENEx.con_PaperStatusName:
                    this.paperStatusName = strValue;
                    this.hmProperty["paperStatusName"] = true;
                    break;
                case clsPaperENEx.con_MajorDirectionId:
                    this.majorDirectionId = strValue;
                    this.hmProperty["majorDirectionId"] = true;
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
    }
    exports.clsPaperENEx = clsPaperENEx;
});
