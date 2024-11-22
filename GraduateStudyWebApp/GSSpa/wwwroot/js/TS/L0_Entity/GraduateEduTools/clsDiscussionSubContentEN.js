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
    exports.clsDiscussionSubContentEN = void 0;
    /**
    * 类名:clsDiscussionSubContentEN
    * 表名:DiscussionSubContent(01120587)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:14:40
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培设置(GraduateEduTools)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 讨论子内容(DiscussionSubContent)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsDiscussionSubContentEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrSubContentId = ""; //字内容Id
            this.mstrSubContent = ""; //子内容
            this.mstrTopicsId = ""; //主题Id
            this.mbolIsTop = false; //是否置顶
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            this.mstrParentId = ""; //父节点Id
            this.mstrUserId = ""; //用户ID
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.subContentId = ""; //字内容Id
            this.subContent = ""; //子内容
            this.topicsId = ""; //主题Id
            this.isTop = false; //是否置顶
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.parentId = ""; //父节点Id
            this.userId = ""; //用户ID
        }
        /**
         * 字内容Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSubContentId(value) {
            if (value != undefined) {
                this.subContentId = value;
                this.hmProperty["subContentId"] = true;
            }
        }
        /**
         * 子内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSubContent(value) {
            if (value != undefined) {
                this.subContent = value;
                this.hmProperty["subContent"] = true;
            }
        }
        /**
         * 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicsId(value) {
            if (value != undefined) {
                this.topicsId = value;
                this.hmProperty["topicsId"] = true;
            }
        }
        /**
         * 是否置顶(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsTop(value) {
            if (value != undefined) {
                this.isTop = value;
                this.hmProperty["isTop"] = true;
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
         * 父节点Id(说明:;字段类型:char;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParentId(value) {
            if (value != undefined) {
                this.parentId = value;
                this.hmProperty["parentId"] = true;
            }
        }
        /**
         * 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserId(value) {
            if (value != undefined) {
                this.userId = value;
                this.hmProperty["userId"] = true;
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
                case clsDiscussionSubContentEN.con_SubContentId:
                    return this.subContentId;
                case clsDiscussionSubContentEN.con_SubContent:
                    return this.subContent;
                case clsDiscussionSubContentEN.con_TopicsId:
                    return this.topicsId;
                case clsDiscussionSubContentEN.con_IsTop:
                    return this.isTop;
                case clsDiscussionSubContentEN.con_UpdDate:
                    return this.updDate;
                case clsDiscussionSubContentEN.con_UpdUser:
                    return this.updUser;
                case clsDiscussionSubContentEN.con_Memo:
                    return this.memo;
                case clsDiscussionSubContentEN.con_ParentId:
                    return this.parentId;
                case clsDiscussionSubContentEN.con_UserId:
                    return this.userId;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[DiscussionSubContent]中不存在！`;
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
                case clsDiscussionSubContentEN.con_SubContentId:
                    this.subContentId = strValue;
                    this.hmProperty["subContentId"] = true;
                    break;
                case clsDiscussionSubContentEN.con_SubContent:
                    this.subContent = strValue;
                    this.hmProperty["subContent"] = true;
                    break;
                case clsDiscussionSubContentEN.con_TopicsId:
                    this.topicsId = strValue;
                    this.hmProperty["topicsId"] = true;
                    break;
                case clsDiscussionSubContentEN.con_IsTop:
                    this.isTop = Boolean(strValue);
                    this.hmProperty["isTop"] = true;
                    break;
                case clsDiscussionSubContentEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsDiscussionSubContentEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsDiscussionSubContentEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsDiscussionSubContentEN.con_ParentId:
                    this.parentId = strValue;
                    this.hmProperty["parentId"] = true;
                    break;
                case clsDiscussionSubContentEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[DiscussionSubContent]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"subContentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubContentId() { return "subContentId"; } //字内容Id
        /**
        * 常量:"subContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubContent() { return "subContent"; } //子内容
        /**
        * 常量:"topicsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicsId() { return "topicsId"; } //主题Id
        /**
        * 常量:"isTop"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsTop() { return "isTop"; } //是否置顶
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
        * 常量:"ParentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentId() { return "parentId"; } //父节点Id
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
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
    exports.clsDiscussionSubContentEN = clsDiscussionSubContentEN;
    clsDiscussionSubContentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsDiscussionSubContentEN.CacheModeId = "05"; //未知
    clsDiscussionSubContentEN._CurrTabName = "DiscussionSubContent"; //当前表名,与该类相关的表名
    clsDiscussionSubContentEN._KeyFldName = "subContentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsDiscussionSubContentEN.mintAttributeCount = 9;
    clsDiscussionSubContentEN.AttributeName = ["subContentId", "subContent", "topicsId", "isTop", "updDate", "updUser", "memo", "parentId", "userId"];
});
