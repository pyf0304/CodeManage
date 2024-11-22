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
    exports.clsSysSkillVerEN = void 0;
    /**
    * 类名:clsSysSkillVerEN
    * 表名:SysSkillVer(01120647)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:48:15
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 系统技能版本(SysSkillVer)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsSysSkillVerEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngSkillVId = 0; //SkillVId
            this.mstrSkillId = ""; //技能Id
            this.mstrSkillName = ""; //技能名称
            this.mstrOperationTypeId = ""; //操作类型ID
            this.mstrProcess = ""; //实施过程
            this.mstrLevelId = ""; //级别Id
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrCitationId = ""; //引用Id
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrPdfContent = ""; //Pdf内容
            this.mintPdfPageNum = 0; //Pdf页码
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.skillVId = 0; //SkillVId
            this.skillId = ""; //技能Id
            this.skillName = ""; //技能名称
            this.operationTypeId = ""; //操作类型ID
            this.process = ""; //实施过程
            this.levelId = ""; //级别Id
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.citationId = ""; //引用Id
            this.id_CurrEduCls = ""; //教学班流水号
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.memo = ""; //备注
        }
        /**
         * SkillVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSkillVId(value) {
            if (value != undefined) {
                this.skillVId = value;
                this.hmProperty["skillVId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 技能Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSkillId(value) {
            if (value != undefined) {
                this.skillId = value;
                this.hmProperty["skillId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 技能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSkillName(value) {
            if (value != undefined) {
                this.skillName = value;
                this.hmProperty["skillName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 操作类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOperationTypeId(value) {
            if (value != undefined) {
                this.operationTypeId = value;
                this.hmProperty["operationTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 实施过程(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetProcess(value) {
            if (value != undefined) {
                this.process = value;
                this.hmProperty["process"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLevelId(value) {
            if (value != undefined) {
                this.levelId = value;
                this.hmProperty["levelId"] = true;
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
         * 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCitationId(value) {
            if (value != undefined) {
                this.citationId = value;
                this.hmProperty["citationId"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsSysSkillVerEN.con_SkillVId:
                    return this.skillVId;
                case clsSysSkillVerEN.con_SkillId:
                    return this.skillId;
                case clsSysSkillVerEN.con_SkillName:
                    return this.skillName;
                case clsSysSkillVerEN.con_OperationTypeId:
                    return this.operationTypeId;
                case clsSysSkillVerEN.con_Process:
                    return this.process;
                case clsSysSkillVerEN.con_LevelId:
                    return this.levelId;
                case clsSysSkillVerEN.con_UpdUser:
                    return this.updUser;
                case clsSysSkillVerEN.con_UpdDate:
                    return this.updDate;
                case clsSysSkillVerEN.con_CitationId:
                    return this.citationId;
                case clsSysSkillVerEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsSysSkillVerEN.con_PdfContent:
                    return this.pdfContent;
                case clsSysSkillVerEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsSysSkillVerEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysSkillVer]中不存在！`;
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
                case clsSysSkillVerEN.con_SkillVId:
                    this.skillVId = Number(strValue);
                    this.hmProperty["skillVId"] = true;
                    break;
                case clsSysSkillVerEN.con_SkillId:
                    this.skillId = strValue;
                    this.hmProperty["skillId"] = true;
                    break;
                case clsSysSkillVerEN.con_SkillName:
                    this.skillName = strValue;
                    this.hmProperty["skillName"] = true;
                    break;
                case clsSysSkillVerEN.con_OperationTypeId:
                    this.operationTypeId = strValue;
                    this.hmProperty["operationTypeId"] = true;
                    break;
                case clsSysSkillVerEN.con_Process:
                    this.process = strValue;
                    this.hmProperty["process"] = true;
                    break;
                case clsSysSkillVerEN.con_LevelId:
                    this.levelId = strValue;
                    this.hmProperty["levelId"] = true;
                    break;
                case clsSysSkillVerEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsSysSkillVerEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsSysSkillVerEN.con_CitationId:
                    this.citationId = strValue;
                    this.hmProperty["citationId"] = true;
                    break;
                case clsSysSkillVerEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsSysSkillVerEN.con_PdfContent:
                    this.pdfContent = strValue;
                    this.hmProperty["pdfContent"] = true;
                    break;
                case clsSysSkillVerEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    this.hmProperty["pdfPageNum"] = true;
                    break;
                case clsSysSkillVerEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysSkillVer]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"SkillVId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SkillVId() { return "skillVId"; } //SkillVId
        /**
        * 常量:"SkillId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SkillId() { return "skillId"; } //技能Id
        /**
        * 常量:"SkillName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SkillName() { return "skillName"; } //技能名称
        /**
        * 常量:"OperationTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OperationTypeId() { return "operationTypeId"; } //操作类型ID
        /**
        * 常量:"Process"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Process() { return "process"; } //实施过程
        /**
        * 常量:"LevelId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LevelId() { return "levelId"; } //级别Id
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
        * 常量:"CitationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationId() { return "citationId"; } //引用Id
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
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
    exports.clsSysSkillVerEN = clsSysSkillVerEN;
    clsSysSkillVerEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsSysSkillVerEN.CacheModeId = ""; //
    clsSysSkillVerEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsSysSkillVerEN.WhereFormat = ""; //条件格式串
    clsSysSkillVerEN._CurrTabName = "SysSkillVer"; //当前表名,与该类相关的表名
    clsSysSkillVerEN._KeyFldName = "SkillVId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsSysSkillVerEN.mintAttributeCount = 13;
    clsSysSkillVerEN.AttributeName = ["skillVId", "skillId", "skillName", "operationTypeId", "process", "levelId", "updUser", "updDate", "citationId", "id_CurrEduCls", "pdfContent", "pdfPageNum", "memo"];
});
