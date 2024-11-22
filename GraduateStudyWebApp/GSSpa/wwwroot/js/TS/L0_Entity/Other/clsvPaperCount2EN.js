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
    exports.clsvPaperCount2EN = void 0;
    /**
    * 类名:clsvPaperCount2EN
    * 表名:vPaperCount2(01120596)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:34
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:其他(Other)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * vPaperCount2(vPaperCount2)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvPaperCount2EN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.pcount = 0; //读写数
            this.okCount = 0; //点赞统计
            this.appraiseCount = 0; //评论数
            this.collectionCount = 0; //收藏数
            this.downloadCount = 0; //下载数
            this.score = 0.0; //评分
            this.attachmentCount = 0; //附件计数
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
                case clsvPaperCount2EN.con_PaperId:
                    return this.paperId;
                case clsvPaperCount2EN.con_Pcount:
                    return this.pcount;
                case clsvPaperCount2EN.con_OkCount:
                    return this.okCount;
                case clsvPaperCount2EN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvPaperCount2EN.con_CollectionCount:
                    return this.collectionCount;
                case clsvPaperCount2EN.con_DownloadCount:
                    return this.downloadCount;
                case clsvPaperCount2EN.con_score:
                    return this.score;
                case clsvPaperCount2EN.con_AttachmentCount:
                    return this.attachmentCount;
                case clsvPaperCount2EN.con_UpdUser:
                    return this.updUser;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperCount2]中不存在！`;
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
                case clsvPaperCount2EN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvPaperCount2EN.con_Pcount:
                    this.pcount = Number(strValue);
                    break;
                case clsvPaperCount2EN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvPaperCount2EN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvPaperCount2EN.con_CollectionCount:
                    this.collectionCount = Number(strValue);
                    break;
                case clsvPaperCount2EN.con_DownloadCount:
                    this.downloadCount = Number(strValue);
                    break;
                case clsvPaperCount2EN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvPaperCount2EN.con_AttachmentCount:
                    this.attachmentCount = Number(strValue);
                    break;
                case clsvPaperCount2EN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperCount2]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"Pcount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Pcount() { return "pcount"; } //读写数
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"AppraiseCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
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
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
        /**
        * 常量:"AttachmentCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AttachmentCount() { return "attachmentCount"; } //附件计数
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
    exports.clsvPaperCount2EN = clsvPaperCount2EN;
    clsvPaperCount2EN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPaperCount2EN.CacheModeId = "05"; //未知
    clsvPaperCount2EN._CurrTabName = "vPaperCount2"; //当前表名,与该类相关的表名
    clsvPaperCount2EN._KeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPaperCount2EN.mintAttributeCount = 9;
    clsvPaperCount2EN.AttributeName = ["paperId", "pcount", "okCount", "appraiseCount", "collectionCount", "downloadCount", "score", "attachmentCount", "updUser"];
});
