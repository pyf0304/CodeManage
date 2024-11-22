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
    exports.clsvViewpointAttachmentEN = void 0;
    /**
    * 类名:clsvViewpointAttachmentEN
    * 表名:vViewpointAttachment(01120593)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:46
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v观点附件(vViewpointAttachment)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvViewpointAttachmentEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.viewpointAttachmentId = 0; //主键Id
            this.reason = ""; //理由
            this.viewpointAttachmentName = ""; //附件名称
            this.source = ""; //来源
            this.viewpointId = ""; //观点Id
            this.filePath = ""; //文件路径
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.viewpointContent = ""; //观点内容
            this.viewpointName = ""; //观点名称
            this.viewpointTypeId = ""; //观点类型Id
            this.viewpointTypeName = ""; //观点类型名
            this.vpProposePeople = ""; //观点提出人
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
                case clsvViewpointAttachmentEN.con_ViewpointAttachmentId:
                    return this.viewpointAttachmentId;
                case clsvViewpointAttachmentEN.con_Reason:
                    return this.reason;
                case clsvViewpointAttachmentEN.con_ViewpointAttachmentName:
                    return this.viewpointAttachmentName;
                case clsvViewpointAttachmentEN.con_Source:
                    return this.source;
                case clsvViewpointAttachmentEN.con_ViewpointId:
                    return this.viewpointId;
                case clsvViewpointAttachmentEN.con_FilePath:
                    return this.filePath;
                case clsvViewpointAttachmentEN.con_UpdUser:
                    return this.updUser;
                case clsvViewpointAttachmentEN.con_UpdDate:
                    return this.updDate;
                case clsvViewpointAttachmentEN.con_ViewpointContent:
                    return this.viewpointContent;
                case clsvViewpointAttachmentEN.con_ViewpointName:
                    return this.viewpointName;
                case clsvViewpointAttachmentEN.con_ViewpointTypeId:
                    return this.viewpointTypeId;
                case clsvViewpointAttachmentEN.con_ViewpointTypeName:
                    return this.viewpointTypeName;
                case clsvViewpointAttachmentEN.con_VPProposePeople:
                    return this.vpProposePeople;
                case clsvViewpointAttachmentEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpointAttachment]中不存在！`;
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
                case clsvViewpointAttachmentEN.con_ViewpointAttachmentId:
                    this.viewpointAttachmentId = Number(strValue);
                    break;
                case clsvViewpointAttachmentEN.con_Reason:
                    this.reason = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_ViewpointAttachmentName:
                    this.viewpointAttachmentName = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_Source:
                    this.source = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_ViewpointId:
                    this.viewpointId = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_FilePath:
                    this.filePath = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_ViewpointContent:
                    this.viewpointContent = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_ViewpointName:
                    this.viewpointName = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_ViewpointTypeId:
                    this.viewpointTypeId = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_ViewpointTypeName:
                    this.viewpointTypeName = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_VPProposePeople:
                    this.vpProposePeople = strValue;
                    break;
                case clsvViewpointAttachmentEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpointAttachment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ViewpointAttachmentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointAttachmentId() { return "viewpointAttachmentId"; } //主键Id
        /**
        * 常量:"Reason"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Reason() { return "reason"; } //理由
        /**
        * 常量:"ViewpointAttachmentName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointAttachmentName() { return "viewpointAttachmentName"; } //附件名称
        /**
        * 常量:"Source"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Source() { return "source"; } //来源
        /**
        * 常量:"ViewpointId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointId() { return "viewpointId"; } //观点Id
        /**
        * 常量:"FilePath"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FilePath() { return "filePath"; } //文件路径
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
        * 常量:"ViewpointContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointContent() { return "viewpointContent"; } //观点内容
        /**
        * 常量:"ViewpointName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointName() { return "viewpointName"; } //观点名称
        /**
        * 常量:"ViewpointTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointTypeId() { return "viewpointTypeId"; } //观点类型Id
        /**
        * 常量:"ViewpointTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointTypeName() { return "viewpointTypeName"; } //观点类型名
        /**
        * 常量:"VPProposePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VPProposePeople() { return "vpProposePeople"; } //观点提出人
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
    exports.clsvViewpointAttachmentEN = clsvViewpointAttachmentEN;
    clsvViewpointAttachmentEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvViewpointAttachmentEN.CacheModeId = "05"; //未知
    clsvViewpointAttachmentEN._CurrTabName = "vViewpointAttachment"; //当前表名,与该类相关的表名
    clsvViewpointAttachmentEN._KeyFldName = "ViewpointAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvViewpointAttachmentEN.mintAttributeCount = 14;
    clsvViewpointAttachmentEN.AttributeName = ["viewpointAttachmentId", "reason", "viewpointAttachmentName", "source", "viewpointId", "filePath", "updUser", "updDate", "viewpointContent", "viewpointName", "viewpointTypeId", "viewpointTypeName", "vpProposePeople", "id_CurrEduCls"];
});
