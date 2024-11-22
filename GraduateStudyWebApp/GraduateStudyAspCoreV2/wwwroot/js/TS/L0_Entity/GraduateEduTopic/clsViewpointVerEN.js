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
    exports.clsViewpointVerEN = void 0;
    /**
    * 类名:clsViewpointVerEN
    * 表名:ViewpointVer(01120650)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:48:21
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
    * 观点版本表(ViewpointVer)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsViewpointVerEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngViewpointVId = 0; //ViewpointVId
            this.mstrViewpointId = ""; //观点Id
            this.mstrViewpointName = ""; //观点名称
            this.mstrViewpointContent = ""; //观点内容
            this.mstrViewpointTypeId = ""; //观点类型Id
            this.mstrReason = ""; //理由
            this.mstrSource = ""; //来源
            this.mstrVPProposePeople = ""; //观点提出人
            this.mstrUserTypeId = ""; //用户类型Id
            this.mstrCitationId = ""; //引用Id
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrPdfContent = ""; //Pdf内容
            this.mintPdfPageNum = 0; //Pdf页码
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.viewpointVId = 0; //ViewpointVId
            this.viewpointId = ""; //观点Id
            this.viewpointName = ""; //观点名称
            this.viewpointContent = ""; //观点内容
            this.viewpointTypeId = ""; //观点类型Id
            this.reason = ""; //理由
            this.source = ""; //来源
            this.vpProposePeople = ""; //观点提出人
            this.userTypeId = ""; //用户类型Id
            this.citationId = ""; //引用Id
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.id_CurrEduCls = ""; //教学班流水号
            this.memo = ""; //备注
        }
        /**
         * ViewpointVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetViewpointVId(value) {
            if (value != undefined) {
                this.viewpointVId = value;
                this.hmProperty["viewpointVId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetViewpointId(value) {
            if (value != undefined) {
                this.viewpointId = value;
                this.hmProperty["viewpointId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetViewpointName(value) {
            if (value != undefined) {
                this.viewpointName = value;
                this.hmProperty["viewpointName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetViewpointContent(value) {
            if (value != undefined) {
                this.viewpointContent = value;
                this.hmProperty["viewpointContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetViewpointTypeId(value) {
            if (value != undefined) {
                this.viewpointTypeId = value;
                this.hmProperty["viewpointTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReason(value) {
            if (value != undefined) {
                this.reason = value;
                this.hmProperty["reason"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSource(value) {
            if (value != undefined) {
                this.source = value;
                this.hmProperty["source"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 观点提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVPProposePeople(value) {
            if (value != undefined) {
                this.vpProposePeople = value;
                this.hmProperty["vpProposePeople"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserTypeId(value) {
            if (value != undefined) {
                this.userTypeId = value;
                this.hmProperty["userTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCitationId(value) {
            if (value != undefined) {
                this.citationId = value;
                this.hmProperty["citationId"] = true;
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
         * Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfContent(value) {
            if (value != undefined) {
                this.pdfContent = value;
                this.hmProperty["pdfContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfPageNum(value) {
            if (value != undefined) {
                this.pdfPageNum = value;
                this.hmProperty["pdfPageNum"] = true;
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
                case clsViewpointVerEN.con_ViewpointVId:
                    return this.viewpointVId;
                case clsViewpointVerEN.con_ViewpointId:
                    return this.viewpointId;
                case clsViewpointVerEN.con_ViewpointName:
                    return this.viewpointName;
                case clsViewpointVerEN.con_ViewpointContent:
                    return this.viewpointContent;
                case clsViewpointVerEN.con_ViewpointTypeId:
                    return this.viewpointTypeId;
                case clsViewpointVerEN.con_Reason:
                    return this.reason;
                case clsViewpointVerEN.con_Source:
                    return this.source;
                case clsViewpointVerEN.con_VPProposePeople:
                    return this.vpProposePeople;
                case clsViewpointVerEN.con_UserTypeId:
                    return this.userTypeId;
                case clsViewpointVerEN.con_CitationId:
                    return this.citationId;
                case clsViewpointVerEN.con_UpdDate:
                    return this.updDate;
                case clsViewpointVerEN.con_UpdUser:
                    return this.updUser;
                case clsViewpointVerEN.con_PdfContent:
                    return this.pdfContent;
                case clsViewpointVerEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsViewpointVerEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsViewpointVerEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ViewpointVer]中不存在！`;
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
                case clsViewpointVerEN.con_ViewpointVId:
                    this.viewpointVId = Number(strValue);
                    this.hmProperty["viewpointVId"] = true;
                    break;
                case clsViewpointVerEN.con_ViewpointId:
                    this.viewpointId = strValue;
                    this.hmProperty["viewpointId"] = true;
                    break;
                case clsViewpointVerEN.con_ViewpointName:
                    this.viewpointName = strValue;
                    this.hmProperty["viewpointName"] = true;
                    break;
                case clsViewpointVerEN.con_ViewpointContent:
                    this.viewpointContent = strValue;
                    this.hmProperty["viewpointContent"] = true;
                    break;
                case clsViewpointVerEN.con_ViewpointTypeId:
                    this.viewpointTypeId = strValue;
                    this.hmProperty["viewpointTypeId"] = true;
                    break;
                case clsViewpointVerEN.con_Reason:
                    this.reason = strValue;
                    this.hmProperty["reason"] = true;
                    break;
                case clsViewpointVerEN.con_Source:
                    this.source = strValue;
                    this.hmProperty["source"] = true;
                    break;
                case clsViewpointVerEN.con_VPProposePeople:
                    this.vpProposePeople = strValue;
                    this.hmProperty["vpProposePeople"] = true;
                    break;
                case clsViewpointVerEN.con_UserTypeId:
                    this.userTypeId = strValue;
                    this.hmProperty["userTypeId"] = true;
                    break;
                case clsViewpointVerEN.con_CitationId:
                    this.citationId = strValue;
                    this.hmProperty["citationId"] = true;
                    break;
                case clsViewpointVerEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsViewpointVerEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsViewpointVerEN.con_PdfContent:
                    this.pdfContent = strValue;
                    this.hmProperty["pdfContent"] = true;
                    break;
                case clsViewpointVerEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    this.hmProperty["pdfPageNum"] = true;
                    break;
                case clsViewpointVerEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsViewpointVerEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[ViewpointVer]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ViewpointVId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointVId() { return "viewpointVId"; } //ViewpointVId
        /**
        * 常量:"ViewpointId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointId() { return "viewpointId"; } //观点Id
        /**
        * 常量:"ViewpointName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointName() { return "viewpointName"; } //观点名称
        /**
        * 常量:"ViewpointContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointContent() { return "viewpointContent"; } //观点内容
        /**
        * 常量:"ViewpointTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointTypeId() { return "viewpointTypeId"; } //观点类型Id
        /**
        * 常量:"Reason"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Reason() { return "reason"; } //理由
        /**
        * 常量:"Source"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Source() { return "source"; } //来源
        /**
        * 常量:"VPProposePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VPProposePeople() { return "vpProposePeople"; } //观点提出人
        /**
        * 常量:"UserTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserTypeId() { return "userTypeId"; } //用户类型Id
        /**
        * 常量:"CitationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationId() { return "citationId"; } //引用Id
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
        * 常量:"PdfContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfContent() { return "pdfContent"; } //Pdf内容
        /**
        * 常量:"PdfPageNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageNum() { return "pdfPageNum"; } //Pdf页码
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
    exports.clsViewpointVerEN = clsViewpointVerEN;
    clsViewpointVerEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsViewpointVerEN.CacheModeId = ""; //
    clsViewpointVerEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsViewpointVerEN.WhereFormat = ""; //条件格式串
    clsViewpointVerEN._CurrTabName = "ViewpointVer"; //当前表名,与该类相关的表名
    clsViewpointVerEN._KeyFldName = "ViewpointVId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsViewpointVerEN.mintAttributeCount = 16;
    clsViewpointVerEN.AttributeName = ["viewpointVId", "viewpointId", "viewpointName", "viewpointContent", "viewpointTypeId", "reason", "source", "vpProposePeople", "userTypeId", "citationId", "updDate", "updUser", "pdfContent", "pdfPageNum", "id_CurrEduCls", "memo"];
});
