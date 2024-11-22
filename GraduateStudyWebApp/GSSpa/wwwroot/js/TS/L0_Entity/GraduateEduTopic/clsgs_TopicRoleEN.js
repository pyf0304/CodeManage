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
    exports.clsgs_TopicRoleEN = void 0;
    /**
    * 类名:clsgs_TopicRoleEN
    * 表名:gs_TopicRole(01120869)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 16:10:02
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
    * 主题权限表(gs_TopicRole)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_TopicRoleEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrTopicRoleId = ""; //主题权限Id
            this.mstrTopicId = ""; //主题Id
            this.mstrMenuNum = ""; //菜单编号
            this.mstrMenuName = ""; //菜单名称
            this.mbolMenuIsHide = false; //菜单是否隐藏
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            this.mbolIsDefault = false; //是否默认
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.topicRoleId = ""; //主题权限Id
            this.topicId = ""; //主题Id
            this.menuNum = ""; //菜单编号
            this.menuName = ""; //菜单名称
            this.menuIsHide = false; //菜单是否隐藏
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.isDefault = false; //是否默认
        }
        /**
         * 主题权限Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicRoleId(value) {
            if (value != undefined) {
                this.topicRoleId = value;
                this.hmProperty["topicRoleId"] = true;
            }
        }
        /**
         * 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicId(value) {
            if (value != undefined) {
                this.topicId = value;
                this.hmProperty["topicId"] = true;
            }
        }
        /**
         * 菜单编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMenuNum(value) {
            if (value != undefined) {
                this.menuNum = value;
                this.hmProperty["menuNum"] = true;
            }
        }
        /**
         * 菜单名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMenuName(value) {
            if (value != undefined) {
                this.menuName = value;
                this.hmProperty["menuName"] = true;
            }
        }
        /**
         * 菜单是否隐藏(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMenuIsHide(value) {
            if (value != undefined) {
                this.menuIsHide = value;
                this.hmProperty["menuIsHide"] = true;
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
         * 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsDefault(value) {
            if (value != undefined) {
                this.isDefault = value;
                this.hmProperty["isDefault"] = true;
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
                case clsgs_TopicRoleEN.con_TopicRoleId:
                    return this.topicRoleId;
                case clsgs_TopicRoleEN.con_TopicId:
                    return this.topicId;
                case clsgs_TopicRoleEN.con_MenuNum:
                    return this.menuNum;
                case clsgs_TopicRoleEN.con_MenuName:
                    return this.menuName;
                case clsgs_TopicRoleEN.con_MenuIsHide:
                    return this.menuIsHide;
                case clsgs_TopicRoleEN.con_UpdDate:
                    return this.updDate;
                case clsgs_TopicRoleEN.con_UpdUser:
                    return this.updUser;
                case clsgs_TopicRoleEN.con_Memo:
                    return this.memo;
                case clsgs_TopicRoleEN.con_IsDefault:
                    return this.isDefault;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TopicRole]中不存在！`;
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
                case clsgs_TopicRoleEN.con_TopicRoleId:
                    this.topicRoleId = strValue;
                    this.hmProperty["topicRoleId"] = true;
                    break;
                case clsgs_TopicRoleEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsgs_TopicRoleEN.con_MenuNum:
                    this.menuNum = strValue;
                    this.hmProperty["menuNum"] = true;
                    break;
                case clsgs_TopicRoleEN.con_MenuName:
                    this.menuName = strValue;
                    this.hmProperty["menuName"] = true;
                    break;
                case clsgs_TopicRoleEN.con_MenuIsHide:
                    this.menuIsHide = Boolean(strValue);
                    this.hmProperty["menuIsHide"] = true;
                    break;
                case clsgs_TopicRoleEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_TopicRoleEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_TopicRoleEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_TopicRoleEN.con_IsDefault:
                    this.isDefault = Boolean(strValue);
                    this.hmProperty["isDefault"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TopicRole]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"TopicRoleId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicRoleId() { return "topicRoleId"; } //主题权限Id
        /**
        * 常量:"TopicId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicId() { return "topicId"; } //主题Id
        /**
        * 常量:"MenuNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MenuNum() { return "menuNum"; } //菜单编号
        /**
        * 常量:"MenuName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MenuName() { return "menuName"; } //菜单名称
        /**
        * 常量:"MenuIsHide"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MenuIsHide() { return "menuIsHide"; } //菜单是否隐藏
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
        * 常量:"IsDefault"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsDefault() { return "isDefault"; } //是否默认
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
    exports.clsgs_TopicRoleEN = clsgs_TopicRoleEN;
    clsgs_TopicRoleEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_TopicRoleEN.CacheModeId = "02"; //客户端缓存
    clsgs_TopicRoleEN._CurrTabName = "gs_TopicRole"; //当前表名,与该类相关的表名
    clsgs_TopicRoleEN._KeyFldName = "TopicRoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_TopicRoleEN.mintAttributeCount = 9;
    clsgs_TopicRoleEN.AttributeName = ["topicRoleId", "topicId", "menuNum", "menuName", "menuIsHide", "updDate", "updUser", "memo", "isDefault"];
});
