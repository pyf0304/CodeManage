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
    exports.clsvgs_TagsEN = void 0;
    /**
    * 类名:clsvgs_TagsEN
    * 表名:vgs_Tags(01120757)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:32
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
    * 论文标注视图(vgs_Tags)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_TagsEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.tagsId = ""; //标注Id
            this.tagsContent = ""; //标注内容
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.voteCount = 0; //点赞计数
            this.orderNum = 0; //序号
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.pdfLineNum = 0; //pdf行号
            this.pdfX = ""; //PdfX
            this.pdfY = ""; //PdfY
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
            this.paperTitle = ""; //论文标题
            this.paperId = ""; //论文Id
            this.shareId = ""; //分享Id
            this.pdfPageNumIn = ""; //PdfPageNumIn
            this.pdfPageTop = 0; //pdf页面顶部位置
            this.pdfDivLet = ""; //PdfDivLet
            this.pdfDivTop = ""; //PdfDivTop
            this.pdfZoom = ""; //PdfZoom
            this.tagsTypeId = ""; //标注类型ID
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
                case clsvgs_TagsEN.con_TagsId:
                    return this.tagsId;
                case clsvgs_TagsEN.con_TagsContent:
                    return this.tagsContent;
                case clsvgs_TagsEN.con_PdfContent:
                    return this.pdfContent;
                case clsvgs_TagsEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsvgs_TagsEN.con_VoteCount:
                    return this.voteCount;
                case clsvgs_TagsEN.con_OrderNum:
                    return this.orderNum;
                case clsvgs_TagsEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_TagsEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_TagsEN.con_PdfLineNum:
                    return this.pdfLineNum;
                case clsvgs_TagsEN.con_PdfX:
                    return this.pdfX;
                case clsvgs_TagsEN.con_PdfY:
                    return this.pdfY;
                case clsvgs_TagsEN.con_Memo:
                    return this.memo;
                case clsvgs_TagsEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvgs_TagsEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvgs_TagsEN.con_PaperId:
                    return this.paperId;
                case clsvgs_TagsEN.con_ShareId:
                    return this.shareId;
                case clsvgs_TagsEN.con_PdfPageNumIn:
                    return this.pdfPageNumIn;
                case clsvgs_TagsEN.con_PdfPageTop:
                    return this.pdfPageTop;
                case clsvgs_TagsEN.con_PdfDivLet:
                    return this.pdfDivLet;
                case clsvgs_TagsEN.con_PdfDivTop:
                    return this.pdfDivTop;
                case clsvgs_TagsEN.con_PdfZoom:
                    return this.pdfZoom;
                case clsvgs_TagsEN.con_TagsTypeId:
                    return this.tagsTypeId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_Tags]中不存在！`;
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
                case clsvgs_TagsEN.con_TagsId:
                    this.tagsId = strValue;
                    break;
                case clsvgs_TagsEN.con_TagsContent:
                    this.tagsContent = strValue;
                    break;
                case clsvgs_TagsEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case clsvgs_TagsEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case clsvgs_TagsEN.con_VoteCount:
                    this.voteCount = Number(strValue);
                    break;
                case clsvgs_TagsEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvgs_TagsEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_TagsEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_TagsEN.con_PdfLineNum:
                    this.pdfLineNum = Number(strValue);
                    break;
                case clsvgs_TagsEN.con_PdfX:
                    this.pdfX = strValue;
                    break;
                case clsvgs_TagsEN.con_PdfY:
                    this.pdfY = strValue;
                    break;
                case clsvgs_TagsEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvgs_TagsEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvgs_TagsEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvgs_TagsEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvgs_TagsEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvgs_TagsEN.con_PdfPageNumIn:
                    this.pdfPageNumIn = strValue;
                    break;
                case clsvgs_TagsEN.con_PdfPageTop:
                    this.pdfPageTop = Number(strValue);
                    break;
                case clsvgs_TagsEN.con_PdfDivLet:
                    this.pdfDivLet = strValue;
                    break;
                case clsvgs_TagsEN.con_PdfDivTop:
                    this.pdfDivTop = strValue;
                    break;
                case clsvgs_TagsEN.con_PdfZoom:
                    this.pdfZoom = strValue;
                    break;
                case clsvgs_TagsEN.con_TagsTypeId:
                    this.tagsTypeId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_Tags]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"TagsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TagsId() { return "tagsId"; } //标注Id
        /**
        * 常量:"TagsContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TagsContent() { return "tagsContent"; } //标注内容
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
        * 常量:"VoteCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteCount() { return "voteCount"; } //点赞计数
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
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
        * 常量:"PdfLineNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfLineNum() { return "pdfLineNum"; } //pdf行号
        /**
        * 常量:"PdfX"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfX() { return "pdfX"; } //PdfX
        /**
        * 常量:"PdfY"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfY() { return "pdfY"; } //PdfY
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
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"ShareId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareId() { return "shareId"; } //分享Id
        /**
        * 常量:"PdfPageNumIn"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageNumIn() { return "pdfPageNumIn"; } //PdfPageNumIn
        /**
        * 常量:"PdfPageTop"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageTop() { return "pdfPageTop"; } //pdf页面顶部位置
        /**
        * 常量:"PdfDivLet"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfDivLet() { return "pdfDivLet"; } //PdfDivLet
        /**
        * 常量:"PdfDivTop"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfDivTop() { return "pdfDivTop"; } //PdfDivTop
        /**
        * 常量:"PdfZoom"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfZoom() { return "pdfZoom"; } //PdfZoom
        /**
        * 常量:"TagsTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TagsTypeId() { return "tagsTypeId"; } //标注类型ID
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
    exports.clsvgs_TagsEN = clsvgs_TagsEN;
    clsvgs_TagsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_TagsEN.CacheModeId = ""; //
    clsvgs_TagsEN._CurrTabName = "vgs_Tags"; //当前表名,与该类相关的表名
    clsvgs_TagsEN._KeyFldName = "TagsId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_TagsEN.mintAttributeCount = 22;
    clsvgs_TagsEN.AttributeName = ["tagsId", "tagsContent", "pdfContent", "pdfPageNum", "voteCount", "orderNum", "updUser", "updDate", "pdfLineNum", "pdfX", "pdfY", "memo", "id_CurrEduCls", "paperTitle", "paperId", "shareId", "pdfPageNumIn", "pdfPageTop", "pdfDivLet", "pdfDivTop", "pdfZoom", "tagsTypeId"];
});