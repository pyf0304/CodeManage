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
    exports.clsvSysCommentEN = void 0;
    /**
    * 类名:clsvSysCommentEN
    * 表名:vSysComment(01120624)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:58
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
    * v系统评论表(vSysComment)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvSysCommentEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.commentId = ""; //评论Id
            this.comment = ""; //评论
            this.score = 0.0; //评分
            this.commentTypeId = ""; //评论类型Id
            this.scoreType = ""; //评分类型
            this.parentId = ""; //父Id
            this.tableKey = ""; //表主键
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.commentTypeName = ""; //评论类型名
            this.commentTable = ""; //评论表
            this.commentTableId = ""; //评论表Id
            this.okCount = 0; //点赞统计
            this.pubParentId = ""; //公共父Id
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
                case clsvSysCommentEN.con_CommentId:
                    return this.commentId;
                case clsvSysCommentEN.con_Comment:
                    return this.comment;
                case clsvSysCommentEN.con_score:
                    return this.score;
                case clsvSysCommentEN.con_CommentTypeId:
                    return this.commentTypeId;
                case clsvSysCommentEN.con_ScoreType:
                    return this.scoreType;
                case clsvSysCommentEN.con_ParentId:
                    return this.parentId;
                case clsvSysCommentEN.con_TableKey:
                    return this.tableKey;
                case clsvSysCommentEN.con_UpdUser:
                    return this.updUser;
                case clsvSysCommentEN.con_UpdDate:
                    return this.updDate;
                case clsvSysCommentEN.con_Memo:
                    return this.memo;
                case clsvSysCommentEN.con_CommentTypeName:
                    return this.commentTypeName;
                case clsvSysCommentEN.con_CommentTable:
                    return this.commentTable;
                case clsvSysCommentEN.con_CommentTableId:
                    return this.commentTableId;
                case clsvSysCommentEN.con_OkCount:
                    return this.okCount;
                case clsvSysCommentEN.con_PubParentId:
                    return this.pubParentId;
                case clsvSysCommentEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvSysCommentEN.con_UserId:
                    return this.userId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysComment]中不存在！`;
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
                case clsvSysCommentEN.con_CommentId:
                    this.commentId = strValue;
                    break;
                case clsvSysCommentEN.con_Comment:
                    this.comment = strValue;
                    break;
                case clsvSysCommentEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvSysCommentEN.con_CommentTypeId:
                    this.commentTypeId = strValue;
                    break;
                case clsvSysCommentEN.con_ScoreType:
                    this.scoreType = strValue;
                    break;
                case clsvSysCommentEN.con_ParentId:
                    this.parentId = strValue;
                    break;
                case clsvSysCommentEN.con_TableKey:
                    this.tableKey = strValue;
                    break;
                case clsvSysCommentEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvSysCommentEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvSysCommentEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvSysCommentEN.con_CommentTypeName:
                    this.commentTypeName = strValue;
                    break;
                case clsvSysCommentEN.con_CommentTable:
                    this.commentTable = strValue;
                    break;
                case clsvSysCommentEN.con_CommentTableId:
                    this.commentTableId = strValue;
                    break;
                case clsvSysCommentEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvSysCommentEN.con_PubParentId:
                    this.pubParentId = strValue;
                    break;
                case clsvSysCommentEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvSysCommentEN.con_UserId:
                    this.userId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysComment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CommentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CommentId() { return "commentId"; } //评论Id
        /**
        * 常量:"Comment"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Comment() { return "comment"; } //评论
        /**
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
        /**
        * 常量:"CommentTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CommentTypeId() { return "commentTypeId"; } //评论类型Id
        /**
        * 常量:"ScoreType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreType() { return "scoreType"; } //评分类型
        /**
        * 常量:"ParentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentId() { return "parentId"; } //父Id
        /**
        * 常量:"TableKey"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TableKey() { return "tableKey"; } //表主键
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
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"PubParentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PubParentId() { return "pubParentId"; } //公共父Id
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
    exports.clsvSysCommentEN = clsvSysCommentEN;
    clsvSysCommentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvSysCommentEN.CacheModeId = "02"; //客户端缓存
    clsvSysCommentEN._CurrTabName = "vSysComment"; //当前表名,与该类相关的表名
    clsvSysCommentEN._KeyFldName = "CommentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvSysCommentEN.mintAttributeCount = 17;
    clsvSysCommentEN.AttributeName = ["commentId", "comment", "score", "commentTypeId", "scoreType", "parentId", "tableKey", "updUser", "updDate", "memo", "commentTypeName", "commentTable", "commentTableId", "okCount", "pubParentId", "id_CurrEduCls", "userId"];
});
