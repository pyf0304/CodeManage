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
    exports.clske_SubEN = void 0;
    /**
    * 类名:clske_SubEN
    * 表名:ke_Sub(01120660)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:48:09
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
    * 知识经济子类(ke_Sub)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clske_SubEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrke_SubId = ""; //知识子类Id
            this.mstrke_SuperId = ""; //知识分类Id
            this.mstrke_SubName_cn = ""; //知识子类名
            this.mstrke_SubName_en = ""; //知识子类英文名
            this.mstrke_SubDescribe_cn = ""; //知识子类描述
            this.mstrke_SubDescribe_en = ""; //知识子类英文描述
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            this.mstrLink = ""; //相应链接
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.ke_SubId = ""; //知识子类Id
            this.ke_SuperId = ""; //知识分类Id
            this.ke_SubName_cn = ""; //知识子类名
            this.ke_SubName_en = ""; //知识子类英文名
            this.ke_SubDescribe_cn = ""; //知识子类描述
            this.ke_SubDescribe_en = ""; //知识子类英文描述
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.link = ""; //相应链接
        }
        /**
         * 知识子类Id(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setke_SubId(value) {
            if (value != undefined) {
                this.ke_SubId = value;
                this.hmProperty["ke_SubId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 知识分类Id(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setke_SuperId(value) {
            if (value != undefined) {
                this.ke_SuperId = value;
                this.hmProperty["ke_SuperId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 知识子类名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setke_SubName_cn(value) {
            if (value != undefined) {
                this.ke_SubName_cn = value;
                this.hmProperty["ke_SubName_cn"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 知识子类英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setke_SubName_en(value) {
            if (value != undefined) {
                this.ke_SubName_en = value;
                this.hmProperty["ke_SubName_en"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 知识子类描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setke_SubDescribe_cn(value) {
            if (value != undefined) {
                this.ke_SubDescribe_cn = value;
                this.hmProperty["ke_SubDescribe_cn"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 知识子类英文描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setke_SubDescribe_en(value) {
            if (value != undefined) {
                this.ke_SubDescribe_en = value;
                this.hmProperty["ke_SubDescribe_en"] = true;
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
         * 相应链接(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLink(value) {
            if (value != undefined) {
                this.link = value;
                this.hmProperty["link"] = true;
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
                case clske_SubEN.con_ke_SubId:
                    return this.ke_SubId;
                case clske_SubEN.con_ke_SuperId:
                    return this.ke_SuperId;
                case clske_SubEN.con_ke_SubName_cn:
                    return this.ke_SubName_cn;
                case clske_SubEN.con_ke_SubName_en:
                    return this.ke_SubName_en;
                case clske_SubEN.con_ke_SubDescribe_cn:
                    return this.ke_SubDescribe_cn;
                case clske_SubEN.con_ke_SubDescribe_en:
                    return this.ke_SubDescribe_en;
                case clske_SubEN.con_UpdDate:
                    return this.updDate;
                case clske_SubEN.con_UpdUser:
                    return this.updUser;
                case clske_SubEN.con_Memo:
                    return this.memo;
                case clske_SubEN.con_Link:
                    return this.link;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ke_Sub]中不存在！`;
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
                case clske_SubEN.con_ke_SubId:
                    this.ke_SubId = strValue;
                    this.hmProperty["ke_SubId"] = true;
                    break;
                case clske_SubEN.con_ke_SuperId:
                    this.ke_SuperId = strValue;
                    this.hmProperty["ke_SuperId"] = true;
                    break;
                case clske_SubEN.con_ke_SubName_cn:
                    this.ke_SubName_cn = strValue;
                    this.hmProperty["ke_SubName_cn"] = true;
                    break;
                case clske_SubEN.con_ke_SubName_en:
                    this.ke_SubName_en = strValue;
                    this.hmProperty["ke_SubName_en"] = true;
                    break;
                case clske_SubEN.con_ke_SubDescribe_cn:
                    this.ke_SubDescribe_cn = strValue;
                    this.hmProperty["ke_SubDescribe_cn"] = true;
                    break;
                case clske_SubEN.con_ke_SubDescribe_en:
                    this.ke_SubDescribe_en = strValue;
                    this.hmProperty["ke_SubDescribe_en"] = true;
                    break;
                case clske_SubEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clske_SubEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clske_SubEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clske_SubEN.con_Link:
                    this.link = strValue;
                    this.hmProperty["link"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ke_Sub]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ke_SubId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ke_SubId() { return "ke_SubId"; } //知识子类Id
        /**
        * 常量:"ke_SuperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ke_SuperId() { return "ke_SuperId"; } //知识分类Id
        /**
        * 常量:"ke_SubName_cn"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ke_SubName_cn() { return "ke_SubName_cn"; } //知识子类名
        /**
        * 常量:"ke_SubName_en"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ke_SubName_en() { return "ke_SubName_en"; } //知识子类英文名
        /**
        * 常量:"ke_SubDescribe_cn"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ke_SubDescribe_cn() { return "ke_SubDescribe_cn"; } //知识子类描述
        /**
        * 常量:"ke_SubDescribe_en"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ke_SubDescribe_en() { return "ke_SubDescribe_en"; } //知识子类英文描述
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
        * 常量:"Link"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Link() { return "link"; } //相应链接
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
    exports.clske_SubEN = clske_SubEN;
    clske_SubEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clske_SubEN.CacheModeId = "04"; //sessionStorage
    clske_SubEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clske_SubEN.WhereFormat = ""; //条件格式串
    clske_SubEN._CurrTabName = "ke_Sub"; //当前表名,与该类相关的表名
    clske_SubEN._KeyFldName = "ke_SubId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clske_SubEN.mintAttributeCount = 10;
    clske_SubEN.AttributeName = ["ke_SubId", "ke_SuperId", "ke_SubName_cn", "ke_SubName_en", "ke_SubDescribe_cn", "ke_SubDescribe_en", "updDate", "updUser", "memo", "link"];
});
