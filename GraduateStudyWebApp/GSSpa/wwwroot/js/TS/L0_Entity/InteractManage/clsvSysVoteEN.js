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
    exports.clsvSysVoteEN = void 0;
    /**
    * 类名:clsvSysVoteEN
    * 表名:vSysVote(01120633)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:29
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:互动管理(InteractManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v系统点赞视图(vSysVote)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvSysVoteEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.voteId = 0; //点赞Id
            this.tableKey = ""; //表主键
            this.pubParentId = ""; //公共父Id
            this.voteTypeId = ""; //点赞类型Id
            this.voteTypeName = ""; //点赞类型名称
            this.updUser = ""; //修改人
            this.voteTable = ""; //点赞表
            this.updDate = ""; //修改日期
            this.voteTableId = ""; //点赞表Id
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
            this.userId = ""; //用户ID
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
                case clsvSysVoteEN.con_VoteId:
                    return this.voteId;
                case clsvSysVoteEN.con_TableKey:
                    return this.tableKey;
                case clsvSysVoteEN.con_PubParentId:
                    return this.pubParentId;
                case clsvSysVoteEN.con_VoteTypeId:
                    return this.voteTypeId;
                case clsvSysVoteEN.con_VoteTypeName:
                    return this.voteTypeName;
                case clsvSysVoteEN.con_UpdUser:
                    return this.updUser;
                case clsvSysVoteEN.con_VoteTable:
                    return this.voteTable;
                case clsvSysVoteEN.con_UpdDate:
                    return this.updDate;
                case clsvSysVoteEN.con_VoteTableId:
                    return this.voteTableId;
                case clsvSysVoteEN.con_Memo:
                    return this.memo;
                case clsvSysVoteEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvSysVoteEN.con_UserId:
                    return this.userId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysVote]中不存在！`;
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
                case clsvSysVoteEN.con_VoteId:
                    this.voteId = Number(strValue);
                    break;
                case clsvSysVoteEN.con_TableKey:
                    this.tableKey = strValue;
                    break;
                case clsvSysVoteEN.con_PubParentId:
                    this.pubParentId = strValue;
                    break;
                case clsvSysVoteEN.con_VoteTypeId:
                    this.voteTypeId = strValue;
                    break;
                case clsvSysVoteEN.con_VoteTypeName:
                    this.voteTypeName = strValue;
                    break;
                case clsvSysVoteEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvSysVoteEN.con_VoteTable:
                    this.voteTable = strValue;
                    break;
                case clsvSysVoteEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvSysVoteEN.con_VoteTableId:
                    this.voteTableId = strValue;
                    break;
                case clsvSysVoteEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvSysVoteEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvSysVoteEN.con_UserId:
                    this.userId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysVote]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"VoteId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteId() { return "voteId"; } //点赞Id
        /**
        * 常量:"TableKey"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TableKey() { return "tableKey"; } //表主键
        /**
        * 常量:"PubParentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PubParentId() { return "pubParentId"; } //公共父Id
        /**
        * 常量:"VoteTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteTypeId() { return "voteTypeId"; } //点赞类型Id
        /**
        * 常量:"VoteTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteTypeName() { return "voteTypeName"; } //点赞类型名称
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"VoteTable"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteTable() { return "voteTable"; } //点赞表
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"VoteTableId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteTableId() { return "voteTableId"; } //点赞表Id
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
    exports.clsvSysVoteEN = clsvSysVoteEN;
    clsvSysVoteEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvSysVoteEN.CacheModeId = "05"; //未知
    clsvSysVoteEN._CurrTabName = "vSysVote"; //当前表名,与该类相关的表名
    clsvSysVoteEN._KeyFldName = "VoteId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvSysVoteEN.mintAttributeCount = 12;
    clsvSysVoteEN.AttributeName = ["voteId", "tableKey", "pubParentId", "voteTypeId", "voteTypeName", "updUser", "voteTable", "updDate", "voteTableId", "memo", "id_CurrEduCls", "userId"];
});
