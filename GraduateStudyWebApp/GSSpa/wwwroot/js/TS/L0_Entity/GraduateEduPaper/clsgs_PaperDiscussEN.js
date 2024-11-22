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
    exports.clsgs_PaperDiscussEN = void 0;
    /**
    * 类名:clsgs_PaperDiscussEN
    * 表名:gs_PaperDiscuss(01120681)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:40
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 论文讨论表(gs_PaperDiscuss)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_PaperDiscussEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrDiscussId = ""; //讨论ID
            this.mstrDiscussContent = ""; //讨论内容
            this.mstrPaperId = ""; //论文Id
            this.mstrParentId = ""; //父节点Id
            this.mfltscore = 0.0; //评分
            this.mstrScoreType = ""; //评分类型
            this.mstrDiscussTypeId = ""; //讨论类型Id
            this.mstrUserId = ""; //用户ID
            this.mintVoteCount = 0; //点赞计数
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.discussId = ""; //讨论ID
            this.discussContent = ""; //讨论内容
            this.paperId = ""; //论文Id
            this.parentId = ""; //父节点Id
            this.score = 0.0; //评分
            this.scoreType = ""; //评分类型
            this.discussTypeId = ""; //讨论类型Id
            this.userId = ""; //用户ID
            this.voteCount = 0; //点赞计数
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.id_CurrEduCls = ""; //教学班流水号
            this.memo = ""; //备注
        }
        /**
         * 讨论ID(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDiscussId(value) {
            if (value != undefined) {
                this.discussId = value;
                this.hmProperty["discussId"] = true;
            }
        }
        /**
         * 讨论内容(说明:;字段类型:varchar;字段长度:2000;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDiscussContent(value) {
            if (value != undefined) {
                this.discussContent = value;
                this.hmProperty["discussContent"] = true;
            }
        }
        /**
         * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperId(value) {
            if (value != undefined) {
                this.paperId = value;
                this.hmProperty["paperId"] = true;
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
         * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setscore(value) {
            if (value != undefined) {
                this.score = value;
                this.hmProperty["score"] = true;
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
            }
        }
        /**
         * 讨论类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDiscussTypeId(value) {
            if (value != undefined) {
                this.discussTypeId = value;
                this.hmProperty["discussTypeId"] = true;
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
         * 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVoteCount(value) {
            if (value != undefined) {
                this.voteCount = value;
                this.hmProperty["voteCount"] = true;
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
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CurrEduCls(value) {
            if (value != undefined) {
                this.id_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
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
                case clsgs_PaperDiscussEN.con_DiscussId:
                    return this.discussId;
                case clsgs_PaperDiscussEN.con_DiscussContent:
                    return this.discussContent;
                case clsgs_PaperDiscussEN.con_PaperId:
                    return this.paperId;
                case clsgs_PaperDiscussEN.con_ParentId:
                    return this.parentId;
                case clsgs_PaperDiscussEN.con_score:
                    return this.score;
                case clsgs_PaperDiscussEN.con_ScoreType:
                    return this.scoreType;
                case clsgs_PaperDiscussEN.con_DiscussTypeId:
                    return this.discussTypeId;
                case clsgs_PaperDiscussEN.con_UserId:
                    return this.userId;
                case clsgs_PaperDiscussEN.con_VoteCount:
                    return this.voteCount;
                case clsgs_PaperDiscussEN.con_UpdUser:
                    return this.updUser;
                case clsgs_PaperDiscussEN.con_UpdDate:
                    return this.updDate;
                case clsgs_PaperDiscussEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsgs_PaperDiscussEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperDiscuss]中不存在！`;
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
                case clsgs_PaperDiscussEN.con_DiscussId:
                    this.discussId = strValue;
                    this.hmProperty["discussId"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_DiscussContent:
                    this.discussContent = strValue;
                    this.hmProperty["discussContent"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_ParentId:
                    this.parentId = strValue;
                    this.hmProperty["parentId"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_ScoreType:
                    this.scoreType = strValue;
                    this.hmProperty["scoreType"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_DiscussTypeId:
                    this.discussTypeId = strValue;
                    this.hmProperty["discussTypeId"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_VoteCount:
                    this.voteCount = Number(strValue);
                    this.hmProperty["voteCount"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsgs_PaperDiscussEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperDiscuss]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"DiscussId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DiscussId() { return "discussId"; } //讨论ID
        /**
        * 常量:"DiscussContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DiscussContent() { return "discussContent"; } //讨论内容
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"ParentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentId() { return "parentId"; } //父节点Id
        /**
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
        /**
        * 常量:"ScoreType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreType() { return "scoreType"; } //评分类型
        /**
        * 常量:"DiscussTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DiscussTypeId() { return "discussTypeId"; } //讨论类型Id
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"VoteCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteCount() { return "voteCount"; } //点赞计数
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
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
    exports.clsgs_PaperDiscussEN = clsgs_PaperDiscussEN;
    clsgs_PaperDiscussEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_PaperDiscussEN.CacheModeId = "04"; //sessionStorage
    clsgs_PaperDiscussEN._CurrTabName = "gs_PaperDiscuss"; //当前表名,与该类相关的表名
    clsgs_PaperDiscussEN._KeyFldName = "DiscussId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_PaperDiscussEN.mintAttributeCount = 13;
    clsgs_PaperDiscussEN.AttributeName = ["discussId", "discussContent", "paperId", "parentId", "score", "scoreType", "discussTypeId", "userId", "voteCount", "updUser", "updDate", "id_CurrEduCls", "memo"];
});
