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
    exports.clsSysCommentEN = void 0;
    /**
    * 类名:clsSysCommentEN
    * 表名:SysComment(01120622)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:46:50
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
    * 系统评论表(SysComment)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsSysCommentEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrCommentId = ""; //评论Id
            this.mstrComment = ""; //评论
            this.mfltScore = 0.0; //评分
            this.mstrCommentTypeId = ""; //评论类型Id
            this.mstrScoreType = ""; //评分类型
            this.mstrParentId = ""; //父Id
            this.mstrTableKey = ""; //表主键
            this.mintOkCount = 0; //点赞统计
            this.mstrPubParentId = ""; //公共父Id
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrUserId = ""; //用户ID
            this.mintMonth = 0; //月
            this.mintWeek = 0; //周
            this.mstrWeekTimeRange = ""; //WeekTimeRange
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
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
            this.okCount = 0; //点赞统计
            this.pubParentId = ""; //公共父Id
            this.id_CurrEduCls = ""; //教学班流水号
            this.userId = ""; //用户ID
            this.month = 0; //月
            this.week = 0; //周
            this.weekTimeRange = ""; //WeekTimeRange
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
        }
        /**
         * 评论Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCommentId(value) {
            if (value != undefined) {
                this.commentId = value;
                this.hmProperty["commentId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 评论(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetComment(value) {
            if (value != undefined) {
                this.comment = value;
                this.hmProperty["comment"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScore(value) {
            if (value != undefined) {
                this.score = value;
                this.hmProperty["score"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
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
         * 评分类型(说明:;字段类型:char;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScoreType(value) {
            if (value != undefined) {
                this.scoreType = value;
                this.hmProperty["scoreType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 父Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParentId(value) {
            if (value != undefined) {
                this.parentId = value;
                this.hmProperty["parentId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTableKey(value) {
            if (value != undefined) {
                this.tableKey = value;
                this.hmProperty["tableKey"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOkCount(value) {
            if (value != undefined) {
                this.okCount = value;
                this.hmProperty["okCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 公共父Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPubParentId(value) {
            if (value != undefined) {
                this.pubParentId = value;
                this.hmProperty["pubParentId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserId(value) {
            if (value != undefined) {
                this.userId = value;
                this.hmProperty["userId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 月(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMonth(value) {
            if (value != undefined) {
                this.month = value;
                this.hmProperty["month"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 周(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWeek(value) {
            if (value != undefined) {
                this.week = value;
                this.hmProperty["week"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * WeekTimeRange(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWeekTimeRange(value) {
            if (value != undefined) {
                this.weekTimeRange = value;
                this.hmProperty["weekTimeRange"] = true;
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
                case clsSysCommentEN.con_CommentId:
                    return this.commentId;
                case clsSysCommentEN.con_Comment:
                    return this.comment;
                case clsSysCommentEN.con_Score:
                    return this.score;
                case clsSysCommentEN.con_CommentTypeId:
                    return this.commentTypeId;
                case clsSysCommentEN.con_ScoreType:
                    return this.scoreType;
                case clsSysCommentEN.con_ParentId:
                    return this.parentId;
                case clsSysCommentEN.con_TableKey:
                    return this.tableKey;
                case clsSysCommentEN.con_OkCount:
                    return this.okCount;
                case clsSysCommentEN.con_PubParentId:
                    return this.pubParentId;
                case clsSysCommentEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsSysCommentEN.con_UserId:
                    return this.userId;
                case clsSysCommentEN.con_Month:
                    return this.month;
                case clsSysCommentEN.con_Week:
                    return this.week;
                case clsSysCommentEN.con_WeekTimeRange:
                    return this.weekTimeRange;
                case clsSysCommentEN.con_UpdUser:
                    return this.updUser;
                case clsSysCommentEN.con_UpdDate:
                    return this.updDate;
                case clsSysCommentEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysComment]中不存在！`;
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
                case clsSysCommentEN.con_CommentId:
                    this.commentId = strValue;
                    this.hmProperty["commentId"] = true;
                    break;
                case clsSysCommentEN.con_Comment:
                    this.comment = strValue;
                    this.hmProperty["comment"] = true;
                    break;
                case clsSysCommentEN.con_Score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsSysCommentEN.con_CommentTypeId:
                    this.commentTypeId = strValue;
                    this.hmProperty["commentTypeId"] = true;
                    break;
                case clsSysCommentEN.con_ScoreType:
                    this.scoreType = strValue;
                    this.hmProperty["scoreType"] = true;
                    break;
                case clsSysCommentEN.con_ParentId:
                    this.parentId = strValue;
                    this.hmProperty["parentId"] = true;
                    break;
                case clsSysCommentEN.con_TableKey:
                    this.tableKey = strValue;
                    this.hmProperty["tableKey"] = true;
                    break;
                case clsSysCommentEN.con_OkCount:
                    this.okCount = Number(strValue);
                    this.hmProperty["okCount"] = true;
                    break;
                case clsSysCommentEN.con_PubParentId:
                    this.pubParentId = strValue;
                    this.hmProperty["pubParentId"] = true;
                    break;
                case clsSysCommentEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsSysCommentEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clsSysCommentEN.con_Month:
                    this.month = Number(strValue);
                    this.hmProperty["month"] = true;
                    break;
                case clsSysCommentEN.con_Week:
                    this.week = Number(strValue);
                    this.hmProperty["week"] = true;
                    break;
                case clsSysCommentEN.con_WeekTimeRange:
                    this.weekTimeRange = strValue;
                    this.hmProperty["weekTimeRange"] = true;
                    break;
                case clsSysCommentEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsSysCommentEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsSysCommentEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[SysComment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"Score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Score() { return "score"; } //评分
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
        * 常量:"Month"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Month() { return "month"; } //月
        /**
        * 常量:"Week"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Week() { return "week"; } //周
        /**
        * 常量:"WeekTimeRange"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WeekTimeRange() { return "weekTimeRange"; } //WeekTimeRange
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
    exports.clsSysCommentEN = clsSysCommentEN;
    clsSysCommentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsSysCommentEN.CacheModeId = "02"; //客户端缓存
    clsSysCommentEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsSysCommentEN.WhereFormat = ""; //条件格式串
    clsSysCommentEN._CurrTabName = "SysComment"; //当前表名,与该类相关的表名
    clsSysCommentEN._KeyFldName = "CommentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsSysCommentEN.mintAttributeCount = 17;
    clsSysCommentEN.AttributeName = ["commentId", "comment", "score", "commentTypeId", "scoreType", "parentId", "tableKey", "okCount", "pubParentId", "id_CurrEduCls", "userId", "month", "week", "weekTimeRange", "updUser", "updDate", "memo"];
});
