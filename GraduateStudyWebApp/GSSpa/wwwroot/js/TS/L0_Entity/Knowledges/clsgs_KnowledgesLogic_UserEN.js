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
    exports.clsgs_KnowledgesLogic_UserEN = void 0;
    /**
    * 类名:clsgs_KnowledgesLogic_UserEN
    * 表名:gs_KnowledgesLogic_User(01120889)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:04
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
    * 知识点逻辑点_个性化用户(gs_KnowledgesLogic_User)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_KnowledgesLogic_UserEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrCourseKnowledgeId = ""; //知识点Id
            this.mstrKnowledgeGraphId = ""; //知识点图Id
            this.mstrClassName = ""; //样式名称
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.mId = 0; //mId
            this.courseKnowledgeId = ""; //知识点Id
            this.knowledgeGraphId = ""; //知识点图Id
            this.className = ""; //样式名称
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
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
            }
        }
        /**
         * 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseKnowledgeId(value) {
            if (value != undefined) {
                this.courseKnowledgeId = value;
                this.hmProperty["courseKnowledgeId"] = true;
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
            }
        }
        /**
         * 样式名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetClassName(value) {
            if (value != undefined) {
                this.className = value;
                this.hmProperty["className"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsgs_KnowledgesLogic_UserEN.con_mId:
                    return this.mId;
                case clsgs_KnowledgesLogic_UserEN.con_CourseKnowledgeId:
                    return this.courseKnowledgeId;
                case clsgs_KnowledgesLogic_UserEN.con_KnowledgeGraphId:
                    return this.knowledgeGraphId;
                case clsgs_KnowledgesLogic_UserEN.con_ClassName:
                    return this.className;
                case clsgs_KnowledgesLogic_UserEN.con_UpdDate:
                    return this.updDate;
                case clsgs_KnowledgesLogic_UserEN.con_UpdUser:
                    return this.updUser;
                case clsgs_KnowledgesLogic_UserEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesLogic_User]中不存在！`;
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
                case clsgs_KnowledgesLogic_UserEN.con_mId:
                    this.mId = Number(strValue);
                    this.hmProperty["mId"] = true;
                    break;
                case clsgs_KnowledgesLogic_UserEN.con_CourseKnowledgeId:
                    this.courseKnowledgeId = strValue;
                    this.hmProperty["courseKnowledgeId"] = true;
                    break;
                case clsgs_KnowledgesLogic_UserEN.con_KnowledgeGraphId:
                    this.knowledgeGraphId = strValue;
                    this.hmProperty["knowledgeGraphId"] = true;
                    break;
                case clsgs_KnowledgesLogic_UserEN.con_ClassName:
                    this.className = strValue;
                    this.hmProperty["className"] = true;
                    break;
                case clsgs_KnowledgesLogic_UserEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_KnowledgesLogic_UserEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_KnowledgesLogic_UserEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesLogic_User]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"CourseKnowledgeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseKnowledgeId() { return "courseKnowledgeId"; } //知识点Id
        /**
        * 常量:"KnowledgeGraphId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeGraphId() { return "knowledgeGraphId"; } //知识点图Id
        /**
        * 常量:"ClassName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ClassName() { return "className"; } //样式名称
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
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
    exports.clsgs_KnowledgesLogic_UserEN = clsgs_KnowledgesLogic_UserEN;
    clsgs_KnowledgesLogic_UserEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_KnowledgesLogic_UserEN.CacheModeId = "02"; //客户端缓存
    clsgs_KnowledgesLogic_UserEN._CurrTabName = "gs_KnowledgesLogic_User"; //当前表名,与该类相关的表名
    clsgs_KnowledgesLogic_UserEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_KnowledgesLogic_UserEN.mintAttributeCount = 7;
    clsgs_KnowledgesLogic_UserEN.AttributeName = ["mId", "courseKnowledgeId", "knowledgeGraphId", "className", "updDate", "updUser", "memo"];
});
