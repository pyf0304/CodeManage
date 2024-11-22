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
    exports.clsgs_TagsEN = void 0;
    /**
    * 类名:clsgs_TagsEN
    * 表名:gs_Tags(01120714)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:51:49
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
    * 标注(gs_Tags)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_TagsEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrTagsId = ""; //标注Id
            this.mstrTagsContent = ""; //标注内容
            this.mstrPdfContent = ""; //Pdf内容
            this.mintPdfPageNum = 0; //Pdf页码
            this.mintVoteCount = 0; //点赞计数
            this.mstrUserId = ""; //用户ID
            this.mintOrderNum = 0; //序号
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mintPdfLineNum = 0; //pdf行号
            this.mstrPdfX = ""; //PdfX
            this.mstrPdfY = ""; //PdfY
            this.mstrMemo = ""; //备注
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrPaperId = ""; //论文Id
            this.mstrShareId = ""; //分享Id
            this.mstrPdfPageNumIn = ""; //PdfPageNumIn
            this.mintPdfPageTop = 0; //pdf页面顶部位置
            this.mstrPdfDivLet = ""; //PdfDivLet
            this.mstrPdfDivTop = ""; //PdfDivTop
            this.mstrPdfZoom = ""; //PdfZoom
            this.mstrTagsTypeId = ""; //标注类型ID
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.tagsId = ""; //标注Id
            this.tagsContent = ""; //标注内容
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.voteCount = 0; //点赞计数
            this.userId = ""; //用户ID
            this.orderNum = 0; //序号
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.pdfLineNum = 0; //pdf行号
            this.pdfX = ""; //PdfX
            this.pdfY = ""; //PdfY
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
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
         * 标注Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTagsId(value) {
            if (value != undefined) {
                this.tagsId = value;
                this.hmProperty["tagsId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 标注内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTagsContent(value) {
            if (value != undefined) {
                this.tagsContent = value;
                this.hmProperty["tagsContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVoteCount(value) {
            if (value != undefined) {
                this.voteCount = value;
                this.hmProperty["voteCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserId(value) {
            if (value != undefined) {
                this.userId = value;
                this.hmProperty["userId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOrderNum(value) {
            if (value != undefined) {
                this.orderNum = value;
                this.hmProperty["orderNum"] = true;
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
         * pdf行号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfLineNum(value) {
            if (value != undefined) {
                this.pdfLineNum = value;
                this.hmProperty["pdfLineNum"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * PdfX(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfX(value) {
            if (value != undefined) {
                this.pdfX = value;
                this.hmProperty["pdfX"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * PdfY(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfY(value) {
            if (value != undefined) {
                this.pdfY = value;
                this.hmProperty["pdfY"] = true;
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
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CurrEduCls(value) {
            if (value != undefined) {
                this.id_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
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
         * PdfPageNumIn(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfPageNumIn(value) {
            if (value != undefined) {
                this.pdfPageNumIn = value;
                this.hmProperty["pdfPageNumIn"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * pdf页面顶部位置(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfPageTop(value) {
            if (value != undefined) {
                this.pdfPageTop = value;
                this.hmProperty["pdfPageTop"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * PdfDivLet(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfDivLet(value) {
            if (value != undefined) {
                this.pdfDivLet = value;
                this.hmProperty["pdfDivLet"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * PdfDivTop(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfDivTop(value) {
            if (value != undefined) {
                this.pdfDivTop = value;
                this.hmProperty["pdfDivTop"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * PdfZoom(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfZoom(value) {
            if (value != undefined) {
                this.pdfZoom = value;
                this.hmProperty["pdfZoom"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 标注类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTagsTypeId(value) {
            if (value != undefined) {
                this.tagsTypeId = value;
                this.hmProperty["tagsTypeId"] = true;
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
                case clsgs_TagsEN.con_TagsId:
                    return this.tagsId;
                case clsgs_TagsEN.con_TagsContent:
                    return this.tagsContent;
                case clsgs_TagsEN.con_PdfContent:
                    return this.pdfContent;
                case clsgs_TagsEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsgs_TagsEN.con_VoteCount:
                    return this.voteCount;
                case clsgs_TagsEN.con_UserId:
                    return this.userId;
                case clsgs_TagsEN.con_OrderNum:
                    return this.orderNum;
                case clsgs_TagsEN.con_UpdUser:
                    return this.updUser;
                case clsgs_TagsEN.con_UpdDate:
                    return this.updDate;
                case clsgs_TagsEN.con_PdfLineNum:
                    return this.pdfLineNum;
                case clsgs_TagsEN.con_PdfX:
                    return this.pdfX;
                case clsgs_TagsEN.con_PdfY:
                    return this.pdfY;
                case clsgs_TagsEN.con_Memo:
                    return this.memo;
                case clsgs_TagsEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsgs_TagsEN.con_PaperId:
                    return this.paperId;
                case clsgs_TagsEN.con_ShareId:
                    return this.shareId;
                case clsgs_TagsEN.con_PdfPageNumIn:
                    return this.pdfPageNumIn;
                case clsgs_TagsEN.con_PdfPageTop:
                    return this.pdfPageTop;
                case clsgs_TagsEN.con_PdfDivLet:
                    return this.pdfDivLet;
                case clsgs_TagsEN.con_PdfDivTop:
                    return this.pdfDivTop;
                case clsgs_TagsEN.con_PdfZoom:
                    return this.pdfZoom;
                case clsgs_TagsEN.con_TagsTypeId:
                    return this.tagsTypeId;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_Tags]中不存在！`;
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
                case clsgs_TagsEN.con_TagsId:
                    this.tagsId = strValue;
                    this.hmProperty["tagsId"] = true;
                    break;
                case clsgs_TagsEN.con_TagsContent:
                    this.tagsContent = strValue;
                    this.hmProperty["tagsContent"] = true;
                    break;
                case clsgs_TagsEN.con_PdfContent:
                    this.pdfContent = strValue;
                    this.hmProperty["pdfContent"] = true;
                    break;
                case clsgs_TagsEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    this.hmProperty["pdfPageNum"] = true;
                    break;
                case clsgs_TagsEN.con_VoteCount:
                    this.voteCount = Number(strValue);
                    this.hmProperty["voteCount"] = true;
                    break;
                case clsgs_TagsEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clsgs_TagsEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    this.hmProperty["orderNum"] = true;
                    break;
                case clsgs_TagsEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_TagsEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_TagsEN.con_PdfLineNum:
                    this.pdfLineNum = Number(strValue);
                    this.hmProperty["pdfLineNum"] = true;
                    break;
                case clsgs_TagsEN.con_PdfX:
                    this.pdfX = strValue;
                    this.hmProperty["pdfX"] = true;
                    break;
                case clsgs_TagsEN.con_PdfY:
                    this.pdfY = strValue;
                    this.hmProperty["pdfY"] = true;
                    break;
                case clsgs_TagsEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_TagsEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsgs_TagsEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsgs_TagsEN.con_ShareId:
                    this.shareId = strValue;
                    this.hmProperty["shareId"] = true;
                    break;
                case clsgs_TagsEN.con_PdfPageNumIn:
                    this.pdfPageNumIn = strValue;
                    this.hmProperty["pdfPageNumIn"] = true;
                    break;
                case clsgs_TagsEN.con_PdfPageTop:
                    this.pdfPageTop = Number(strValue);
                    this.hmProperty["pdfPageTop"] = true;
                    break;
                case clsgs_TagsEN.con_PdfDivLet:
                    this.pdfDivLet = strValue;
                    this.hmProperty["pdfDivLet"] = true;
                    break;
                case clsgs_TagsEN.con_PdfDivTop:
                    this.pdfDivTop = strValue;
                    this.hmProperty["pdfDivTop"] = true;
                    break;
                case clsgs_TagsEN.con_PdfZoom:
                    this.pdfZoom = strValue;
                    this.hmProperty["pdfZoom"] = true;
                    break;
                case clsgs_TagsEN.con_TagsTypeId:
                    this.tagsTypeId = strValue;
                    this.hmProperty["tagsTypeId"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_Tags]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
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
    exports.clsgs_TagsEN = clsgs_TagsEN;
    clsgs_TagsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_TagsEN.CacheModeId = "02"; //客户端缓存
    clsgs_TagsEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_TagsEN.WhereFormat = ""; //条件格式串
    clsgs_TagsEN._CurrTabName = "gs_Tags"; //当前表名,与该类相关的表名
    clsgs_TagsEN._KeyFldName = "TagsId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_TagsEN.mintAttributeCount = 22;
    clsgs_TagsEN.AttributeName = ["tagsId", "tagsContent", "pdfContent", "pdfPageNum", "voteCount", "userId", "orderNum", "updUser", "updDate", "pdfLineNum", "pdfX", "pdfY", "memo", "id_CurrEduCls", "paperId", "shareId", "pdfPageNumIn", "pdfPageTop", "pdfDivLet", "pdfDivTop", "pdfZoom", "tagsTypeId"];
});
