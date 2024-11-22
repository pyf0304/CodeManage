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
    exports.clsvSysCountEN = void 0;
    /**
    * 类名:clsvSysCountEN
    * 表名:vSysCount(01120626)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/15 23:44:03
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
    * 数据统计视图(vSysCount)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvSysCountEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.countId = ""; //CountId
            this.countTypeId = ""; //CountTypeId
            this.commentTypeName = ""; //评论类型名
            this.commentTable = ""; //评论表
            this.okCount = 0; //点赞统计
            this.commentTableId = ""; //评论表Id
            this.collectionCount = 0; //收藏数量
            this.downloadCount = 0; //下载数
            this.attachmentCount = 0; //附件计数
            this.commentCount = 0; //评论数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.tableKey = ""; //表主键
            this.parentId = ""; //父Id
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.paperRWCount = 0; //PaperRWCount
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
                case clsvSysCountEN.con_CountId:
                    return this.countId;
                case clsvSysCountEN.con_CountTypeId:
                    return this.countTypeId;
                case clsvSysCountEN.con_CommentTypeName:
                    return this.commentTypeName;
                case clsvSysCountEN.con_CommentTable:
                    return this.commentTable;
                case clsvSysCountEN.con_OkCount:
                    return this.okCount;
                case clsvSysCountEN.con_CommentTableId:
                    return this.commentTableId;
                case clsvSysCountEN.con_CollectionCount:
                    return this.collectionCount;
                case clsvSysCountEN.con_DownloadCount:
                    return this.downloadCount;
                case clsvSysCountEN.con_AttachmentCount:
                    return this.attachmentCount;
                case clsvSysCountEN.con_CommentCount:
                    return this.commentCount;
                case clsvSysCountEN.con_Score:
                    return this.score;
                case clsvSysCountEN.con_StuScore:
                    return this.stuScore;
                case clsvSysCountEN.con_TeaScore:
                    return this.teaScore;
                case clsvSysCountEN.con_TableKey:
                    return this.tableKey;
                case clsvSysCountEN.con_ParentId:
                    return this.parentId;
                case clsvSysCountEN.con_UpdUser:
                    return this.updUser;
                case clsvSysCountEN.con_UpdDate:
                    return this.updDate;
                case clsvSysCountEN.con_Memo:
                    return this.memo;
                case clsvSysCountEN.con_PaperRWCount:
                    return this.paperRWCount;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysCount]中不存在！`;
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
                case clsvSysCountEN.con_CountId:
                    this.countId = strValue;
                    break;
                case clsvSysCountEN.con_CountTypeId:
                    this.countTypeId = strValue;
                    break;
                case clsvSysCountEN.con_CommentTypeName:
                    this.commentTypeName = strValue;
                    break;
                case clsvSysCountEN.con_CommentTable:
                    this.commentTable = strValue;
                    break;
                case clsvSysCountEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvSysCountEN.con_CommentTableId:
                    this.commentTableId = strValue;
                    break;
                case clsvSysCountEN.con_CollectionCount:
                    this.collectionCount = Number(strValue);
                    break;
                case clsvSysCountEN.con_DownloadCount:
                    this.downloadCount = Number(strValue);
                    break;
                case clsvSysCountEN.con_AttachmentCount:
                    this.attachmentCount = Number(strValue);
                    break;
                case clsvSysCountEN.con_CommentCount:
                    this.commentCount = Number(strValue);
                    break;
                case clsvSysCountEN.con_Score:
                    this.score = Number(strValue);
                    break;
                case clsvSysCountEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvSysCountEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvSysCountEN.con_TableKey:
                    this.tableKey = strValue;
                    break;
                case clsvSysCountEN.con_ParentId:
                    this.parentId = strValue;
                    break;
                case clsvSysCountEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvSysCountEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvSysCountEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvSysCountEN.con_PaperRWCount:
                    this.paperRWCount = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysCount]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CountId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CountId() { return "countId"; } //CountId
        /**
        * 常量:"CountTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CountTypeId() { return "countTypeId"; } //CountTypeId
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
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"CommentTableId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CommentTableId() { return "commentTableId"; } //评论表Id
        /**
        * 常量:"CollectionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollectionCount() { return "collectionCount"; } //收藏数量
        /**
        * 常量:"DownloadCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DownloadCount() { return "downloadCount"; } //下载数
        /**
        * 常量:"AttachmentCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AttachmentCount() { return "attachmentCount"; } //附件计数
        /**
        * 常量:"CommentCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CommentCount() { return "commentCount"; } //评论数
        /**
        * 常量:"Score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Score() { return "score"; } //评分
        /**
        * 常量:"StuScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuScore() { return "stuScore"; } //学生平均分
        /**
        * 常量:"TeaScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaScore() { return "teaScore"; } //教师评分
        /**
        * 常量:"TableKey"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TableKey() { return "tableKey"; } //表主键
        /**
        * 常量:"ParentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentId() { return "parentId"; } //父Id
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
        * 常量:"PaperRWCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperRWCount() { return "paperRWCount"; } //PaperRWCount
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
    exports.clsvSysCountEN = clsvSysCountEN;
    clsvSysCountEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvSysCountEN.CacheModeId = "05"; //未知
    clsvSysCountEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvSysCountEN.WhereFormat = ""; //条件格式串
    clsvSysCountEN._CurrTabName = "vSysCount"; //当前表名,与该类相关的表名
    clsvSysCountEN._KeyFldName = "CountId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvSysCountEN.mintAttributeCount = 19;
    clsvSysCountEN.AttributeName = ["countId", "countTypeId", "commentTypeName", "commentTable", "okCount", "commentTableId", "collectionCount", "downloadCount", "attachmentCount", "commentCount", "score", "stuScore", "teaScore", "tableKey", "parentId", "updUser", "updDate", "memo", "paperRWCount"];
});
