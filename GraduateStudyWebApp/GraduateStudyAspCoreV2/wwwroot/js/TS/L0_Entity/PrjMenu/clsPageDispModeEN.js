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
    exports.enumPageDispMode = exports.clsPageDispModeEN = void 0;
    /**
    * 类名:clsPageDispModeEN
    * 表名:PageDispMode(01120908)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:46:54
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:菜单管理(PrjMenu)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 页面显示模式(PageDispMode)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsPageDispModeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrPageDispModeId = ""; //页面显示模式Id
            this.mstrPageDispModeName = ""; //页面显示模式名称
            this.mstrPageDispModeENName = ""; //页面显示模式英文名
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.pageDispModeId = ""; //页面显示模式Id
            this.pageDispModeName = ""; //页面显示模式名称
            this.pageDispModeENName = ""; //页面显示模式英文名
            this.memo = ""; //备注
        }
        /**
         * 页面显示模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPageDispModeId(value) {
            if (value != undefined) {
                this.pageDispModeId = value;
                this.hmProperty["pageDispModeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 页面显示模式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPageDispModeName(value) {
            if (value != undefined) {
                this.pageDispModeName = value;
                this.hmProperty["pageDispModeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 页面显示模式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPageDispModeENName(value) {
            if (value != undefined) {
                this.pageDispModeENName = value;
                this.hmProperty["pageDispModeENName"] = true;
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
                case clsPageDispModeEN.con_PageDispModeId:
                    return this.pageDispModeId;
                case clsPageDispModeEN.con_PageDispModeName:
                    return this.pageDispModeName;
                case clsPageDispModeEN.con_PageDispModeENName:
                    return this.pageDispModeENName;
                case clsPageDispModeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[PageDispMode]中不存在！`;
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
                case clsPageDispModeEN.con_PageDispModeId:
                    this.pageDispModeId = strValue;
                    this.hmProperty["pageDispModeId"] = true;
                    break;
                case clsPageDispModeEN.con_PageDispModeName:
                    this.pageDispModeName = strValue;
                    this.hmProperty["pageDispModeName"] = true;
                    break;
                case clsPageDispModeEN.con_PageDispModeENName:
                    this.pageDispModeENName = strValue;
                    this.hmProperty["pageDispModeENName"] = true;
                    break;
                case clsPageDispModeEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[PageDispMode]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PageDispModeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PageDispModeId() { return "pageDispModeId"; } //页面显示模式Id
        /**
        * 常量:"PageDispModeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PageDispModeName() { return "pageDispModeName"; } //页面显示模式名称
        /**
        * 常量:"PageDispModeENName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PageDispModeENName() { return "pageDispModeENName"; } //页面显示模式英文名
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
    exports.clsPageDispModeEN = clsPageDispModeEN;
    clsPageDispModeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsPageDispModeEN.CacheModeId = "04"; //sessionStorage
    clsPageDispModeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsPageDispModeEN.WhereFormat = ""; //条件格式串
    clsPageDispModeEN._CurrTabName = "PageDispMode"; //当前表名,与该类相关的表名
    clsPageDispModeEN._KeyFldName = "PageDispModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsPageDispModeEN.mintAttributeCount = 4;
    clsPageDispModeEN.AttributeName = ["pageDispModeId", "pageDispModeName", "pageDispModeENName", "memo"];
    /**
    * 根据表内容设置enum列表
    * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
    **/
    class enumPageDispMode {
    }
    exports.enumPageDispMode = enumPageDispMode;
    /**
    * 弹出框
    **/
    enumPageDispMode.PopupBox_01 = "01";
    /**
    * 右边
    **/
    enumPageDispMode.Right_02 = "02";
    /**
    * 下边
    **/
    enumPageDispMode.Below_03 = "03";
    /**
    * 左边
    **/
    enumPageDispMode.Left_04 = "04";
    /**
    * 全页
    **/
    enumPageDispMode.FullPage_05 = "05";
});
