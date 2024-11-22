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
    exports.clsSysCommentTypeEN = void 0;
    /**
    * 类名:clsSysCommentTypeEN
    * 表名:SysCommentType(01120623)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:52:04
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培参数(ParameterTable)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 评论类型表(SysCommentType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsSysCommentTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrCommentTypeId = ""; //评论类型Id
            this.mstrCommentTypeName = ""; //评论类型名
            this.mstrCommentTable = ""; //评论表
            this.mstrCommentTableId = ""; //评论表Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.commentTypeId = ""; //评论类型Id
            this.commentTypeName = ""; //评论类型名
            this.commentTable = ""; //评论表
            this.commentTableId = ""; //评论表Id
            this.memo = ""; //备注
        }
        /**
         * 评论类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCommentTypeId(value) {
            if (value != undefined) {
                this.commentTypeId = value;
                this.hmProperty["commentTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 评论类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCommentTypeName(value) {
            if (value != undefined) {
                this.commentTypeName = value;
                this.hmProperty["commentTypeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 评论表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCommentTable(value) {
            if (value != undefined) {
                this.commentTable = value;
                this.hmProperty["commentTable"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 评论表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCommentTableId(value) {
            if (value != undefined) {
                this.commentTableId = value;
                this.hmProperty["commentTableId"] = true;
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
                case clsSysCommentTypeEN.con_CommentTypeId:
                    return this.commentTypeId;
                case clsSysCommentTypeEN.con_CommentTypeName:
                    return this.commentTypeName;
                case clsSysCommentTypeEN.con_CommentTable:
                    return this.commentTable;
                case clsSysCommentTypeEN.con_CommentTableId:
                    return this.commentTableId;
                case clsSysCommentTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysCommentType]中不存在！`;
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
                case clsSysCommentTypeEN.con_CommentTypeId:
                    this.commentTypeId = strValue;
                    this.hmProperty["commentTypeId"] = true;
                    break;
                case clsSysCommentTypeEN.con_CommentTypeName:
                    this.commentTypeName = strValue;
                    this.hmProperty["commentTypeName"] = true;
                    break;
                case clsSysCommentTypeEN.con_CommentTable:
                    this.commentTable = strValue;
                    this.hmProperty["commentTable"] = true;
                    break;
                case clsSysCommentTypeEN.con_CommentTableId:
                    this.commentTableId = strValue;
                    this.hmProperty["commentTableId"] = true;
                    break;
                case clsSysCommentTypeEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[SysCommentType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CommentTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CommentTypeId() { return "commentTypeId"; } //评论类型Id
        /**
        * 常量:"CommentTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CommentTypeName() { return "commentTypeName"; } //评论类型名
        /**
        * 常量:"CommentTable"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CommentTable() { return "commentTable"; } //评论表
        /**
        * 常量:"CommentTableId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CommentTableId() { return "commentTableId"; } //评论表Id
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
    exports.clsSysCommentTypeEN = clsSysCommentTypeEN;
    clsSysCommentTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsSysCommentTypeEN.CacheModeId = "03"; //localStorage
    clsSysCommentTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsSysCommentTypeEN.WhereFormat = ""; //条件格式串
    clsSysCommentTypeEN._CurrTabName = "SysCommentType"; //当前表名,与该类相关的表名
    clsSysCommentTypeEN._KeyFldName = "CommentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsSysCommentTypeEN.mintAttributeCount = 5;
    clsSysCommentTypeEN.AttributeName = ["commentTypeId", "commentTypeName", "commentTable", "commentTableId", "memo"];
});
