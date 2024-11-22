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
    exports.clsgs_KnowledgesLogicRelaEN = void 0;
    /**
    * 类名:clsgs_KnowledgesLogicRelaEN
    * 表名:gs_KnowledgesLogicRela(01120870)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:52:57
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 知识点逻辑关系表(gs_KnowledgesLogicRela)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_KnowledgesLogicRelaEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngmId = 0; //mId
            this.mstrCourseKnowledgeIdA = ""; //课程知识点AId
            this.mstrCourseKnowledgeTitleA = ""; //课程知识点标题A
            this.mstrCourseKnowledgeIdB = ""; //课程知识点BId
            this.mstrCourseKnowledgeTitleB = ""; //课程知识点标题B
            this.mstrKnowledgeGraphId = ""; //知识点图Id
            this.mstrSourceAnchor = ""; //源锚点
            this.mstrTargetAnchor = ""; //目标锚点
            this.mstrRelaTitle = ""; //关系标题
            this.mstrRelaTypeId = ""; //关系类型Id
            this.mstrCourseId = ""; //课程Id
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.mId = 0; //mId
            this.courseKnowledgeIdA = ""; //课程知识点AId
            this.courseKnowledgeTitleA = ""; //课程知识点标题A
            this.courseKnowledgeIdB = ""; //课程知识点BId
            this.courseKnowledgeTitleB = ""; //课程知识点标题B
            this.knowledgeGraphId = ""; //知识点图Id
            this.sourceAnchor = ""; //源锚点
            this.targetAnchor = ""; //目标锚点
            this.relaTitle = ""; //关系标题
            this.relaTypeId = ""; //关系类型Id
            this.courseId = ""; //课程Id
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
        }
        /**
         * mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetmId(value) {
            if (value != undefined) {
                this.mId = value;
                this.hmProperty["mId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程知识点AId(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseKnowledgeIdA(value) {
            if (value != undefined) {
                this.courseKnowledgeIdA = value;
                this.hmProperty["courseKnowledgeIdA"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程知识点标题A(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseKnowledgeTitleA(value) {
            if (value != undefined) {
                this.courseKnowledgeTitleA = value;
                this.hmProperty["courseKnowledgeTitleA"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程知识点BId(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseKnowledgeIdB(value) {
            if (value != undefined) {
                this.courseKnowledgeIdB = value;
                this.hmProperty["courseKnowledgeIdB"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程知识点标题B(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseKnowledgeTitleB(value) {
            if (value != undefined) {
                this.courseKnowledgeTitleB = value;
                this.hmProperty["courseKnowledgeTitleB"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 知识点图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKnowledgeGraphId(value) {
            if (value != undefined) {
                this.knowledgeGraphId = value;
                this.hmProperty["knowledgeGraphId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 源锚点(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSourceAnchor(value) {
            if (value != undefined) {
                this.sourceAnchor = value;
                this.hmProperty["sourceAnchor"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 目标锚点(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTargetAnchor(value) {
            if (value != undefined) {
                this.targetAnchor = value;
                this.hmProperty["targetAnchor"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 关系标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRelaTitle(value) {
            if (value != undefined) {
                this.relaTitle = value;
                this.hmProperty["relaTitle"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRelaTypeId(value) {
            if (value != undefined) {
                this.relaTypeId = value;
                this.hmProperty["relaTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseId(value) {
            if (value != undefined) {
                this.courseId = value;
                this.hmProperty["courseId"] = true;
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
                case clsgs_KnowledgesLogicRelaEN.con_mId:
                    return this.mId;
                case clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdA:
                    return this.courseKnowledgeIdA;
                case clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleA:
                    return this.courseKnowledgeTitleA;
                case clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdB:
                    return this.courseKnowledgeIdB;
                case clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleB:
                    return this.courseKnowledgeTitleB;
                case clsgs_KnowledgesLogicRelaEN.con_KnowledgeGraphId:
                    return this.knowledgeGraphId;
                case clsgs_KnowledgesLogicRelaEN.con_SourceAnchor:
                    return this.sourceAnchor;
                case clsgs_KnowledgesLogicRelaEN.con_TargetAnchor:
                    return this.targetAnchor;
                case clsgs_KnowledgesLogicRelaEN.con_RelaTitle:
                    return this.relaTitle;
                case clsgs_KnowledgesLogicRelaEN.con_RelaTypeId:
                    return this.relaTypeId;
                case clsgs_KnowledgesLogicRelaEN.con_CourseId:
                    return this.courseId;
                case clsgs_KnowledgesLogicRelaEN.con_UpdUser:
                    return this.updUser;
                case clsgs_KnowledgesLogicRelaEN.con_UpdDate:
                    return this.updDate;
                case clsgs_KnowledgesLogicRelaEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesLogicRela]中不存在！`;
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
                case clsgs_KnowledgesLogicRelaEN.con_mId:
                    this.mId = Number(strValue);
                    this.hmProperty["mId"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdA:
                    this.courseKnowledgeIdA = strValue;
                    this.hmProperty["courseKnowledgeIdA"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleA:
                    this.courseKnowledgeTitleA = strValue;
                    this.hmProperty["courseKnowledgeTitleA"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeIdB:
                    this.courseKnowledgeIdB = strValue;
                    this.hmProperty["courseKnowledgeIdB"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_CourseKnowledgeTitleB:
                    this.courseKnowledgeTitleB = strValue;
                    this.hmProperty["courseKnowledgeTitleB"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_KnowledgeGraphId:
                    this.knowledgeGraphId = strValue;
                    this.hmProperty["knowledgeGraphId"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_SourceAnchor:
                    this.sourceAnchor = strValue;
                    this.hmProperty["sourceAnchor"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_TargetAnchor:
                    this.targetAnchor = strValue;
                    this.hmProperty["targetAnchor"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_RelaTitle:
                    this.relaTitle = strValue;
                    this.hmProperty["relaTitle"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_RelaTypeId:
                    this.relaTypeId = strValue;
                    this.hmProperty["relaTypeId"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_KnowledgesLogicRelaEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesLogicRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
        /**
        * 常量:"CourseKnowledgeIdA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseKnowledgeIdA() { return "courseKnowledgeIdA"; } //课程知识点AId
        /**
        * 常量:"CourseKnowledgeTitleA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseKnowledgeTitleA() { return "courseKnowledgeTitleA"; } //课程知识点标题A
        /**
        * 常量:"CourseKnowledgeIdB"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseKnowledgeIdB() { return "courseKnowledgeIdB"; } //课程知识点BId
        /**
        * 常量:"CourseKnowledgeTitleB"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseKnowledgeTitleB() { return "courseKnowledgeTitleB"; } //课程知识点标题B
        /**
        * 常量:"KnowledgeGraphId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeGraphId() { return "knowledgeGraphId"; } //知识点图Id
        /**
        * 常量:"SourceAnchor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SourceAnchor() { return "sourceAnchor"; } //源锚点
        /**
        * 常量:"TargetAnchor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TargetAnchor() { return "targetAnchor"; } //目标锚点
        /**
        * 常量:"RelaTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RelaTitle() { return "relaTitle"; } //关系标题
        /**
        * 常量:"RelaTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RelaTypeId() { return "relaTypeId"; } //关系类型Id
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
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
    exports.clsgs_KnowledgesLogicRelaEN = clsgs_KnowledgesLogicRelaEN;
    clsgs_KnowledgesLogicRelaEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_KnowledgesLogicRelaEN.CacheModeId = "02"; //客户端缓存
    clsgs_KnowledgesLogicRelaEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_KnowledgesLogicRelaEN.WhereFormat = ""; //条件格式串
    clsgs_KnowledgesLogicRelaEN._CurrTabName = "gs_KnowledgesLogicRela"; //当前表名,与该类相关的表名
    clsgs_KnowledgesLogicRelaEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_KnowledgesLogicRelaEN.mintAttributeCount = 14;
    clsgs_KnowledgesLogicRelaEN.AttributeName = ["mId", "courseKnowledgeIdA", "courseKnowledgeTitleA", "courseKnowledgeIdB", "courseKnowledgeTitleB", "knowledgeGraphId", "sourceAnchor", "targetAnchor", "relaTitle", "relaTypeId", "courseId", "updUser", "updDate", "memo"];
});
