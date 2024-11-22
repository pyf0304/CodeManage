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
    exports.clsvPaperDownloadLogEN = void 0;
    /**
    * 类名:clsvPaperDownloadLogEN
    * 表名:vPaperDownloadLog(01120572)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:40
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
    * v论文下载记录(vPaperDownloadLog)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvPaperDownloadLogEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paperDownloadId = 0; //PaperDownloadId
            this.downloadFile = ""; //DownloadFile
            this.downloadLink = ""; //DownloadLink
            this.paperId = ""; //论文Id
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.paperTitle = ""; //论文标题
            this.author = ""; //作者
            this.keyword = ""; //关键字
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
                case clsvPaperDownloadLogEN.con_PaperDownloadId:
                    return this.paperDownloadId;
                case clsvPaperDownloadLogEN.con_DownloadFile:
                    return this.downloadFile;
                case clsvPaperDownloadLogEN.con_DownloadLink:
                    return this.downloadLink;
                case clsvPaperDownloadLogEN.con_PaperId:
                    return this.paperId;
                case clsvPaperDownloadLogEN.con_UpdUser:
                    return this.updUser;
                case clsvPaperDownloadLogEN.con_UpdDate:
                    return this.updDate;
                case clsvPaperDownloadLogEN.con_Memo:
                    return this.memo;
                case clsvPaperDownloadLogEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvPaperDownloadLogEN.con_Author:
                    return this.author;
                case clsvPaperDownloadLogEN.con_Keyword:
                    return this.keyword;
                case clsvPaperDownloadLogEN.con_UserName:
                    return this.userName;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperDownloadLog]中不存在！`;
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
                case clsvPaperDownloadLogEN.con_PaperDownloadId:
                    this.paperDownloadId = Number(strValue);
                    break;
                case clsvPaperDownloadLogEN.con_DownloadFile:
                    this.downloadFile = strValue;
                    break;
                case clsvPaperDownloadLogEN.con_DownloadLink:
                    this.downloadLink = strValue;
                    break;
                case clsvPaperDownloadLogEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvPaperDownloadLogEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvPaperDownloadLogEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvPaperDownloadLogEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvPaperDownloadLogEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvPaperDownloadLogEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvPaperDownloadLogEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvPaperDownloadLogEN.con_UserName:
                    this.userName = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperDownloadLog]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PaperDownloadId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperDownloadId() { return "paperDownloadId"; } //PaperDownloadId
        /**
        * 常量:"DownloadFile"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DownloadFile() { return "downloadFile"; } //DownloadFile
        /**
        * 常量:"DownloadLink"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DownloadLink() { return "downloadLink"; } //DownloadLink
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
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
    exports.clsvPaperDownloadLogEN = clsvPaperDownloadLogEN;
    clsvPaperDownloadLogEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPaperDownloadLogEN.CacheModeId = "05"; //未知
    clsvPaperDownloadLogEN._CurrTabName = "vPaperDownloadLog"; //当前表名,与该类相关的表名
    clsvPaperDownloadLogEN._KeyFldName = "PaperDownloadId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPaperDownloadLogEN.mintAttributeCount = 11;
    clsvPaperDownloadLogEN.AttributeName = ["paperDownloadId", "downloadFile", "downloadLink", "paperId", "updUser", "updDate", "memo", "paperTitle", "author", "keyword", "userName"];
});
