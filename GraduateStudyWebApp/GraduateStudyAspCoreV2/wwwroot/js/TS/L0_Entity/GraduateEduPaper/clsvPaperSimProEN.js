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
    exports.clsvPaperSimProEN = void 0;
    /**
    * 类名:clsvPaperSimProEN
    * 表名:vPaperSimPro(01120944)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:44:30
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
    * vPaperSimPro(vPaperSimPro)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvPaperSimProEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paperTitle = ""; //论文标题
            this.paperContent = ""; //主题内容
            this.periodical = ""; //期刊
            this.author = ""; //作者
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
                case clsvPaperSimProEN.con_PaperId:
                    return this.paperId;
                case clsvPaperSimProEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvPaperSimProEN.con_PaperContent:
                    return this.paperContent;
                case clsvPaperSimProEN.con_Periodical:
                    return this.periodical;
                case clsvPaperSimProEN.con_Author:
                    return this.author;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSimPro]中不存在！`;
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
                case clsvPaperSimProEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvPaperSimProEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvPaperSimProEN.con_PaperContent:
                    this.paperContent = strValue;
                    break;
                case clsvPaperSimProEN.con_Periodical:
                    this.periodical = strValue;
                    break;
                case clsvPaperSimProEN.con_Author:
                    this.author = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSimPro]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
    exports.clsvPaperSimProEN = clsvPaperSimProEN;
    clsvPaperSimProEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPaperSimProEN.CacheModeId = "04"; //sessionStorage
    clsvPaperSimProEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvPaperSimProEN.WhereFormat = "PaperId in (Select PaperId from PaperEduClsRela where Id_CurrEduCls='{0}')"; //条件格式串
    clsvPaperSimProEN._CurrTabName = "vPaperSimPro"; //当前表名,与该类相关的表名
    clsvPaperSimProEN._KeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPaperSimProEN.mintAttributeCount = 5;
    clsvPaperSimProEN.AttributeName = ["paperId", "paperTitle", "paperContent", "periodical", "author"];
});
