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
    exports.clsvDiscussionTopicsEN = void 0;
    /**
    * 类名:clsvDiscussionTopicsEN
    * 表名:vDiscussionTopics(01120586)
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
    * v讨论主题视图(vDiscussionTopics)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvDiscussionTopicsEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.topicsId = ""; //主题Id
            this.discussionTypeId = ""; //讨论类型Id
            this.discussionTypeName = ""; //讨论类型名称
            this.topicsTitle = ""; //主题标题
            this.topicsContent = ""; //主题内容
            this.isAudit = false; //是否审核
            this.isTop = false; //是否置顶
            this.browseNumber = 0; //浏览量
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.collegeName = ""; //学院名称
            this.id_XzCollege = ""; //学院流水号
            this.id_XzMajor = ""; //专业流水号
            this.majorName = ""; //专业名称
            this.userName = ""; //用户名
            this.subCount = 0; //SubCount
            this.id_CurrEduCls = ""; //教学班流水号
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
                case clsvDiscussionTopicsEN.con_TopicsId:
                    return this.topicsId;
                case clsvDiscussionTopicsEN.con_DiscussionTypeId:
                    return this.discussionTypeId;
                case clsvDiscussionTopicsEN.con_DiscussionTypeName:
                    return this.discussionTypeName;
                case clsvDiscussionTopicsEN.con_topicsTitle:
                    return this.topicsTitle;
                case clsvDiscussionTopicsEN.con_TopicsContent:
                    return this.topicsContent;
                case clsvDiscussionTopicsEN.con_IsAudit:
                    return this.isAudit;
                case clsvDiscussionTopicsEN.con_IsTop:
                    return this.isTop;
                case clsvDiscussionTopicsEN.con_BrowseNumber:
                    return this.browseNumber;
                case clsvDiscussionTopicsEN.con_UpdDate:
                    return this.updDate;
                case clsvDiscussionTopicsEN.con_UpdUser:
                    return this.updUser;
                case clsvDiscussionTopicsEN.con_Memo:
                    return this.memo;
                case clsvDiscussionTopicsEN.con_CollegeName:
                    return this.collegeName;
                case clsvDiscussionTopicsEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvDiscussionTopicsEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvDiscussionTopicsEN.con_MajorName:
                    return this.majorName;
                case clsvDiscussionTopicsEN.con_UserName:
                    return this.userName;
                case clsvDiscussionTopicsEN.con_SubCount:
                    return this.subCount;
                case clsvDiscussionTopicsEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vDiscussionTopics]中不存在！`;
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
                case clsvDiscussionTopicsEN.con_TopicsId:
                    this.topicsId = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_DiscussionTypeId:
                    this.discussionTypeId = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_DiscussionTypeName:
                    this.discussionTypeName = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_topicsTitle:
                    this.topicsTitle = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_TopicsContent:
                    this.topicsContent = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_IsAudit:
                    this.isAudit = Boolean(strValue);
                    break;
                case clsvDiscussionTopicsEN.con_IsTop:
                    this.isTop = Boolean(strValue);
                    break;
                case clsvDiscussionTopicsEN.con_BrowseNumber:
                    this.browseNumber = Number(strValue);
                    break;
                case clsvDiscussionTopicsEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvDiscussionTopicsEN.con_SubCount:
                    this.subCount = Number(strValue);
                    break;
                case clsvDiscussionTopicsEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vDiscussionTopics]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"topicsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicsId() { return "topicsId"; } //主题Id
        /**
        * 常量:"DiscussionTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DiscussionTypeId() { return "discussionTypeId"; } //讨论类型Id
        /**
        * 常量:"DiscussionTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DiscussionTypeName() { return "discussionTypeName"; } //讨论类型名称
        /**
        * 常量:"topicsTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_topicsTitle() { return "topicsTitle"; } //主题标题
        /**
        * 常量:"TopicsContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicsContent() { return "topicsContent"; } //主题内容
        /**
        * 常量:"IsAudit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsAudit() { return "isAudit"; } //是否审核
        /**
        * 常量:"isTop"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsTop() { return "isTop"; } //是否置顶
        /**
        * 常量:"BrowseNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BrowseNumber() { return "browseNumber"; } //浏览量
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
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"SubCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubCount() { return "subCount"; } //SubCount
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
    exports.clsvDiscussionTopicsEN = clsvDiscussionTopicsEN;
    clsvDiscussionTopicsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvDiscussionTopicsEN.CacheModeId = "04"; //sessionStorage
    clsvDiscussionTopicsEN._CurrTabName = "vDiscussionTopics"; //当前表名,与该类相关的表名
    clsvDiscussionTopicsEN._KeyFldName = "topicsId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvDiscussionTopicsEN.mintAttributeCount = 18;
    clsvDiscussionTopicsEN.AttributeName = ["topicsId", "discussionTypeId", "discussionTypeName", "topicsTitle", "topicsContent", "isAudit", "isTop", "browseNumber", "updDate", "updUser", "memo", "collegeName", "id_XzCollege", "id_XzMajor", "majorName", "userName", "subCount", "id_CurrEduCls"];
});
