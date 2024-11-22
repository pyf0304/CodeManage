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
    exports.clsvDiscussionSubContentEN = void 0;
    /**
    * 类名:clsvDiscussionSubContentEN
    * 表名:vDiscussionSubContent(01120585)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:43:49
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
    * v讨论子内容视图(vDiscussionSubContent)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvDiscussionSubContentEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.subContent = ""; //子内容
            this.topicsId = ""; //主题Id
            this.topicsTitle = ""; //主题标题
            this.isTop = false; //是否置顶
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.collegeName = ""; //学院名称
            this.id_XzCollege = ""; //学院流水号
            this.id_XzMajor = ""; //专业流水号
            this.majorName = ""; //专业名称
            this.userName = ""; //用户名
            this.browseNumber = 0; //浏览量
            this.id_CurrEduCls = ""; //教学班流水号
            this.parentId = ""; //父节点Id
            this.topicsContent = ""; //主题内容
            this.userId = ""; //用户ID
            this.vUpdDate = ""; //vUpdDate
            this.vUpdUser = ""; //vUpdUser
            this.subContentId = ""; //子内容Id
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
                case clsvDiscussionSubContentEN.con_SubContent:
                    return this.subContent;
                case clsvDiscussionSubContentEN.con_TopicsId:
                    return this.topicsId;
                case clsvDiscussionSubContentEN.con_TopicsTitle:
                    return this.topicsTitle;
                case clsvDiscussionSubContentEN.con_IsTop:
                    return this.isTop;
                case clsvDiscussionSubContentEN.con_UpdDate:
                    return this.updDate;
                case clsvDiscussionSubContentEN.con_UpdUser:
                    return this.updUser;
                case clsvDiscussionSubContentEN.con_Memo:
                    return this.memo;
                case clsvDiscussionSubContentEN.con_CollegeName:
                    return this.collegeName;
                case clsvDiscussionSubContentEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvDiscussionSubContentEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvDiscussionSubContentEN.con_MajorName:
                    return this.majorName;
                case clsvDiscussionSubContentEN.con_UserName:
                    return this.userName;
                case clsvDiscussionSubContentEN.con_BrowseNumber:
                    return this.browseNumber;
                case clsvDiscussionSubContentEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvDiscussionSubContentEN.con_ParentId:
                    return this.parentId;
                case clsvDiscussionSubContentEN.con_TopicsContent:
                    return this.topicsContent;
                case clsvDiscussionSubContentEN.con_UserId:
                    return this.userId;
                case clsvDiscussionSubContentEN.con_vUpdDate:
                    return this.vUpdDate;
                case clsvDiscussionSubContentEN.con_vUpdUser:
                    return this.vUpdUser;
                case clsvDiscussionSubContentEN.con_SubContentId:
                    return this.subContentId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vDiscussionSubContent]中不存在！`;
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
                case clsvDiscussionSubContentEN.con_SubContent:
                    this.subContent = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_TopicsId:
                    this.topicsId = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_TopicsTitle:
                    this.topicsTitle = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_IsTop:
                    this.isTop = Boolean(strValue);
                    break;
                case clsvDiscussionSubContentEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_BrowseNumber:
                    this.browseNumber = Number(strValue);
                    break;
                case clsvDiscussionSubContentEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_ParentId:
                    this.parentId = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_TopicsContent:
                    this.topicsContent = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_vUpdDate:
                    this.vUpdDate = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_vUpdUser:
                    this.vUpdUser = strValue;
                    break;
                case clsvDiscussionSubContentEN.con_SubContentId:
                    this.subContentId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vDiscussionSubContent]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"SubContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubContent() { return "subContent"; } //子内容
        /**
        * 常量:"TopicsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicsId() { return "topicsId"; } //主题Id
        /**
        * 常量:"TopicsTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicsTitle() { return "topicsTitle"; } //主题标题
        /**
        * 常量:"IsTop"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsTop() { return "isTop"; } //是否置顶
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
        * 常量:"BrowseNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BrowseNumber() { return "browseNumber"; } //浏览量
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"ParentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentId() { return "parentId"; } //父节点Id
        /**
        * 常量:"TopicsContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicsContent() { return "topicsContent"; } //主题内容
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"vUpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_vUpdDate() { return "vUpdDate"; } //vUpdDate
        /**
        * 常量:"vUpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_vUpdUser() { return "vUpdUser"; } //vUpdUser
        /**
        * 常量:"SubContentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubContentId() { return "subContentId"; } //子内容Id
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
    exports.clsvDiscussionSubContentEN = clsvDiscussionSubContentEN;
    clsvDiscussionSubContentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvDiscussionSubContentEN.CacheModeId = "05"; //未知
    clsvDiscussionSubContentEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvDiscussionSubContentEN.WhereFormat = ""; //条件格式串
    clsvDiscussionSubContentEN._CurrTabName = "vDiscussionSubContent"; //当前表名,与该类相关的表名
    clsvDiscussionSubContentEN._KeyFldName = "SubContentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvDiscussionSubContentEN.mintAttributeCount = 20;
    clsvDiscussionSubContentEN.AttributeName = ["subContent", "topicsId", "topicsTitle", "isTop", "updDate", "updUser", "memo", "collegeName", "id_XzCollege", "id_XzMajor", "majorName", "userName", "browseNumber", "id_CurrEduCls", "parentId", "topicsContent", "userId", "vUpdDate", "vUpdUser", "subContentId"];
});
