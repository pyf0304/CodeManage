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
    exports.clsPaperReadWriteEN = void 0;
    /**
    * 类名:clsPaperReadWriteEN
    * 表名:PaperReadWrite(01120547)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:47
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
    * 论文读写表(PaperReadWrite)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsPaperReadWriteEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrPaperRWId = ""; //课文阅读
            this.mstrReaderId = ""; //阅读者Id
            this.mstrPaperId = ""; //论文Id
            this.mstrResearchQuestion = ""; //研究问题
            this.mstrOperationTypeId = ""; //操作类型ID
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            this.mbolIsSubmit = false; //是否提交
            this.mbolIsPublic = false; //是否公开
            this.mstrSubmitter = ""; //提交人
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mintSubVCount = 0; //论文子观点数
            this.mintTeaCount = 0; //TeaCount
            this.mstrCreateDate = ""; //建立日期
            this.mstrShareId = ""; //分享Id
            this.mstrUpdUser = ""; //修改人
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.paperRWId = ""; //课文阅读
            this.readerId = ""; //阅读者Id
            this.paperId = ""; //论文Id
            this.researchQuestion = ""; //研究问题
            this.operationTypeId = ""; //操作类型ID
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.isSubmit = false; //是否提交
            this.isPublic = false; //是否公开
            this.submitter = ""; //提交人
            this.id_CurrEduCls = ""; //教学班流水号
            this.subVCount = 0; //论文子观点数
            this.teaCount = 0; //TeaCount
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.updUser = ""; //修改人
        }
        /**
         * 课文阅读(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperRWId(value) {
            if (value != undefined) {
                this.paperRWId = value;
                this.hmProperty["paperRWId"] = true;
            }
        }
        /**
         * 阅读者Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReaderId(value) {
            if (value != undefined) {
                this.readerId = value;
                this.hmProperty["readerId"] = true;
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
            }
        }
        /**
         * 研究问题(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResearchQuestion(value) {
            if (value != undefined) {
                this.researchQuestion = value;
                this.hmProperty["researchQuestion"] = true;
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
            }
        }
        /**
         * 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSubmit(value) {
            if (value != undefined) {
                this.isSubmit = value;
                this.hmProperty["isSubmit"] = true;
            }
        }
        /**
         * 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsPublic(value) {
            if (value != undefined) {
                this.isPublic = value;
                this.hmProperty["isPublic"] = true;
            }
        }
        /**
         * 提交人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSubmitter(value) {
            if (value != undefined) {
                this.submitter = value;
                this.hmProperty["submitter"] = true;
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
            }
        }
        /**
         * 论文子观点数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSubVCount(value) {
            if (value != undefined) {
                this.subVCount = value;
                this.hmProperty["subVCount"] = true;
            }
        }
        /**
         * TeaCount(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTeaCount(value) {
            if (value != undefined) {
                this.teaCount = value;
                this.hmProperty["teaCount"] = true;
            }
        }
        /**
         * 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCreateDate(value) {
            if (value != undefined) {
                this.createDate = value;
                this.hmProperty["createDate"] = true;
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
                case clsPaperReadWriteEN.con_PaperRWId:
                    return this.paperRWId;
                case clsPaperReadWriteEN.con_ReaderId:
                    return this.readerId;
                case clsPaperReadWriteEN.con_PaperId:
                    return this.paperId;
                case clsPaperReadWriteEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsPaperReadWriteEN.con_OperationTypeId:
                    return this.operationTypeId;
                case clsPaperReadWriteEN.con_UpdDate:
                    return this.updDate;
                case clsPaperReadWriteEN.con_Memo:
                    return this.memo;
                case clsPaperReadWriteEN.con_IsSubmit:
                    return this.isSubmit;
                case clsPaperReadWriteEN.con_IsPublic:
                    return this.isPublic;
                case clsPaperReadWriteEN.con_Submitter:
                    return this.submitter;
                case clsPaperReadWriteEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsPaperReadWriteEN.con_SubVCount:
                    return this.subVCount;
                case clsPaperReadWriteEN.con_TeaCount:
                    return this.teaCount;
                case clsPaperReadWriteEN.con_CreateDate:
                    return this.createDate;
                case clsPaperReadWriteEN.con_ShareId:
                    return this.shareId;
                case clsPaperReadWriteEN.con_UpdUser:
                    return this.updUser;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[PaperReadWrite]中不存在！`;
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
                case clsPaperReadWriteEN.con_PaperRWId:
                    this.paperRWId = strValue;
                    this.hmProperty["paperRWId"] = true;
                    break;
                case clsPaperReadWriteEN.con_ReaderId:
                    this.readerId = strValue;
                    this.hmProperty["readerId"] = true;
                    break;
                case clsPaperReadWriteEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsPaperReadWriteEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    this.hmProperty["researchQuestion"] = true;
                    break;
                case clsPaperReadWriteEN.con_OperationTypeId:
                    this.operationTypeId = strValue;
                    this.hmProperty["operationTypeId"] = true;
                    break;
                case clsPaperReadWriteEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsPaperReadWriteEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsPaperReadWriteEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsPaperReadWriteEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    this.hmProperty["isPublic"] = true;
                    break;
                case clsPaperReadWriteEN.con_Submitter:
                    this.submitter = strValue;
                    this.hmProperty["submitter"] = true;
                    break;
                case clsPaperReadWriteEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsPaperReadWriteEN.con_SubVCount:
                    this.subVCount = Number(strValue);
                    this.hmProperty["subVCount"] = true;
                    break;
                case clsPaperReadWriteEN.con_TeaCount:
                    this.teaCount = Number(strValue);
                    this.hmProperty["teaCount"] = true;
                    break;
                case clsPaperReadWriteEN.con_CreateDate:
                    this.createDate = strValue;
                    this.hmProperty["createDate"] = true;
                    break;
                case clsPaperReadWriteEN.con_ShareId:
                    this.shareId = strValue;
                    this.hmProperty["shareId"] = true;
                    break;
                case clsPaperReadWriteEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[PaperReadWrite]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PaperRWId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperRWId() { return "paperRWId"; } //课文阅读
        /**
        * 常量:"ReaderId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReaderId() { return "readerId"; } //阅读者Id
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"ResearchQuestion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResearchQuestion() { return "researchQuestion"; } //研究问题
        /**
        * 常量:"OperationTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OperationTypeId() { return "operationTypeId"; } //操作类型ID
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
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"IsPublic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsPublic() { return "isPublic"; } //是否公开
        /**
        * 常量:"Submitter"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Submitter() { return "submitter"; } //提交人
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"SubVCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubVCount() { return "subVCount"; } //论文子观点数
        /**
        * 常量:"TeaCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaCount() { return "teaCount"; } //TeaCount
        /**
        * 常量:"CreateDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateDate() { return "createDate"; } //建立日期
        /**
        * 常量:"ShareId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareId() { return "shareId"; } //分享Id
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
    exports.clsPaperReadWriteEN = clsPaperReadWriteEN;
    clsPaperReadWriteEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsPaperReadWriteEN.CacheModeId = "04"; //sessionStorage
    clsPaperReadWriteEN._CurrTabName = "PaperReadWrite"; //当前表名,与该类相关的表名
    clsPaperReadWriteEN._KeyFldName = "PaperRWId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsPaperReadWriteEN.mintAttributeCount = 16;
    clsPaperReadWriteEN.AttributeName = ["paperRWId", "readerId", "paperId", "researchQuestion", "operationTypeId", "updDate", "memo", "isSubmit", "isPublic", "submitter", "id_CurrEduCls", "subVCount", "teaCount", "createDate", "shareId", "updUser"];
});
