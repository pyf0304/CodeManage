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
    exports.clscc_CourseKnowledgesEN = void 0;
    /**
    * 类名:clscc_CourseKnowledgesEN
    * 表名:cc_CourseKnowledges(01120082)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:00
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 知识点(cc_CourseKnowledges)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clscc_CourseKnowledgesEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrCourseKnowledgeId = ""; //知识点Id
            this.mstrKnowledgeName = ""; //知识点名称
            this.mstrKnowledgeTitle = ""; //知识点标题
            this.mstrKnowledgeContent = ""; //知识点内容
            this.mstrCourseId = ""; //课程Id
            this.mstrKnowledgeTypeId = ""; //知识点类型Id
            this.mstrCourseChapterId = ""; //课程章节ID
            this.mstrUserId = ""; //用户ID
            this.mstrUploadDate = ""; //上传时间
            this.mbolIsShow = false; //是否启用
            this.mbolIsCast = false; //是否播放
            this.mlngLikeCount = 0; //资源喜欢数量
            this.mintOrderNum = 0; //序号
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.courseKnowledgeId = ""; //知识点Id
            this.knowledgeName = ""; //知识点名称
            this.knowledgeTitle = ""; //知识点标题
            this.knowledgeContent = ""; //知识点内容
            this.courseId = ""; //课程Id
            this.knowledgeTypeId = ""; //知识点类型Id
            this.courseChapterId = ""; //课程章节ID
            this.userId = ""; //用户ID
            this.uploadDate = ""; //上传时间
            this.isShow = false; //是否启用
            this.isCast = false; //是否播放
            this.likeCount = 0; //资源喜欢数量
            this.orderNum = 0; //序号
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseKnowledgeId(value) {
            if (value != undefined) {
                this.courseKnowledgeId = value;
                this.hmProperty["courseKnowledgeId"] = true;
            }
        }
        /**
         * 知识点名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKnowledgeName(value) {
            if (value != undefined) {
                this.knowledgeName = value;
                this.hmProperty["knowledgeName"] = true;
            }
        }
        /**
         * 知识点标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKnowledgeTitle(value) {
            if (value != undefined) {
                this.knowledgeTitle = value;
                this.hmProperty["knowledgeTitle"] = true;
            }
        }
        /**
         * 知识点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKnowledgeContent(value) {
            if (value != undefined) {
                this.knowledgeContent = value;
                this.hmProperty["knowledgeContent"] = true;
            }
        }
        /**
         * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseId(value) {
            if (value != undefined) {
                this.courseId = value;
                this.hmProperty["courseId"] = true;
            }
        }
        /**
         * 知识点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKnowledgeTypeId(value) {
            if (value != undefined) {
                this.knowledgeTypeId = value;
                this.hmProperty["knowledgeTypeId"] = true;
            }
        }
        /**
         * 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseChapterId(value) {
            if (value != undefined) {
                this.courseChapterId = value;
                this.hmProperty["courseChapterId"] = true;
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
         * 上传时间(说明:;字段类型:varchar;字段长度:20;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUploadDate(value) {
            if (value != undefined) {
                this.uploadDate = value;
                this.hmProperty["uploadDate"] = true;
            }
        }
        /**
         * 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsShow(value) {
            if (value != undefined) {
                this.isShow = value;
                this.hmProperty["isShow"] = true;
            }
        }
        /**
         * 是否播放(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsCast(value) {
            if (value != undefined) {
                this.isCast = value;
                this.hmProperty["isCast"] = true;
            }
        }
        /**
         * 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLikeCount(value) {
            if (value != undefined) {
                this.likeCount = value;
                this.hmProperty["likeCount"] = true;
            }
        }
        /**
         * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOrderNum(value) {
            if (value != undefined) {
                this.orderNum = value;
                this.hmProperty["orderNum"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clscc_CourseKnowledgesEN.con_CourseKnowledgeId:
                    return this.courseKnowledgeId;
                case clscc_CourseKnowledgesEN.con_KnowledgeName:
                    return this.knowledgeName;
                case clscc_CourseKnowledgesEN.con_KnowledgeTitle:
                    return this.knowledgeTitle;
                case clscc_CourseKnowledgesEN.con_KnowledgeContent:
                    return this.knowledgeContent;
                case clscc_CourseKnowledgesEN.con_CourseId:
                    return this.courseId;
                case clscc_CourseKnowledgesEN.con_KnowledgeTypeId:
                    return this.knowledgeTypeId;
                case clscc_CourseKnowledgesEN.con_CourseChapterId:
                    return this.courseChapterId;
                case clscc_CourseKnowledgesEN.con_UserId:
                    return this.userId;
                case clscc_CourseKnowledgesEN.con_UploadDate:
                    return this.uploadDate;
                case clscc_CourseKnowledgesEN.con_IsShow:
                    return this.isShow;
                case clscc_CourseKnowledgesEN.con_IsCast:
                    return this.isCast;
                case clscc_CourseKnowledgesEN.con_LikeCount:
                    return this.likeCount;
                case clscc_CourseKnowledgesEN.con_OrderNum:
                    return this.orderNum;
                case clscc_CourseKnowledgesEN.con_UpdDate:
                    return this.updDate;
                case clscc_CourseKnowledgesEN.con_UpdUser:
                    return this.updUser;
                case clscc_CourseKnowledgesEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_CourseKnowledges]中不存在！`;
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
                case clscc_CourseKnowledgesEN.con_CourseKnowledgeId:
                    this.courseKnowledgeId = strValue;
                    this.hmProperty["courseKnowledgeId"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_KnowledgeName:
                    this.knowledgeName = strValue;
                    this.hmProperty["knowledgeName"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_KnowledgeTitle:
                    this.knowledgeTitle = strValue;
                    this.hmProperty["knowledgeTitle"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_KnowledgeContent:
                    this.knowledgeContent = strValue;
                    this.hmProperty["knowledgeContent"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_KnowledgeTypeId:
                    this.knowledgeTypeId = strValue;
                    this.hmProperty["knowledgeTypeId"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_CourseChapterId:
                    this.courseChapterId = strValue;
                    this.hmProperty["courseChapterId"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_UploadDate:
                    this.uploadDate = strValue;
                    this.hmProperty["uploadDate"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_IsShow:
                    this.isShow = Boolean(strValue);
                    this.hmProperty["isShow"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_IsCast:
                    this.isCast = Boolean(strValue);
                    this.hmProperty["isCast"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_LikeCount:
                    this.likeCount = Number(strValue);
                    this.hmProperty["likeCount"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    this.hmProperty["orderNum"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clscc_CourseKnowledgesEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_CourseKnowledges]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CourseKnowledgeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseKnowledgeId() { return "courseKnowledgeId"; } //知识点Id
        /**
        * 常量:"KnowledgeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeName() { return "knowledgeName"; } //知识点名称
        /**
        * 常量:"KnowledgeTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeTitle() { return "knowledgeTitle"; } //知识点标题
        /**
        * 常量:"KnowledgeContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeContent() { return "knowledgeContent"; } //知识点内容
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"KnowledgeTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeTypeId() { return "knowledgeTypeId"; } //知识点类型Id
        /**
        * 常量:"CourseChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterId() { return "courseChapterId"; } //课程章节ID
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"UploadDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UploadDate() { return "uploadDate"; } //上传时间
        /**
        * 常量:"IsShow"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsShow() { return "isShow"; } //是否启用
        /**
        * 常量:"IsCast"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCast() { return "isCast"; } //是否播放
        /**
        * 常量:"LikeCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LikeCount() { return "likeCount"; } //资源喜欢数量
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
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
    exports.clscc_CourseKnowledgesEN = clscc_CourseKnowledgesEN;
    clscc_CourseKnowledgesEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clscc_CourseKnowledgesEN.CacheModeId = "02"; //客户端缓存
    clscc_CourseKnowledgesEN._CurrTabName = "cc_CourseKnowledges"; //当前表名,与该类相关的表名
    clscc_CourseKnowledgesEN._KeyFldName = "CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clscc_CourseKnowledgesEN.mintAttributeCount = 16;
    clscc_CourseKnowledgesEN.AttributeName = ["courseKnowledgeId", "knowledgeName", "knowledgeTitle", "knowledgeContent", "courseId", "knowledgeTypeId", "courseChapterId", "userId", "uploadDate", "isShow", "isCast", "likeCount", "orderNum", "updDate", "updUser", "memo"];
});
