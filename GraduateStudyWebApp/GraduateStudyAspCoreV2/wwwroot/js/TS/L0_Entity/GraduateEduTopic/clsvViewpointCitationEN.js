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
    exports.clsvViewpointCitationEN = void 0;
    /**
    * 类名:clsvViewpointCitationEN
    * 表名:vViewpointCitation(01120594)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:49:05
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
    * v观点引用(vViewpointCitation)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsvViewpointCitationEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrMemo = ""; //备注
            this.mlngmId = 0; //mId
            this.mstrPaperContent = ""; //主题内容
            this.mstrPaperId = ""; //论文Id
            this.mstrPaperTitle = ""; //论文标题
            this.mstrReason = ""; //理由
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrUserName = ""; //用户名
            this.mstrViewpointId = ""; //观点Id
            this.mstrViewpointName = ""; //观点名称
            this.mstrViewpointTypeId = ""; //观点类型Id
            this.mstrViewpointTypeName = ""; //观点类型名
            this.mstrUpdDate = ""; //修改日期
            this.mstrProposePeople = ""; //提出人
            this.mstrSource = ""; //来源
            this.mstrTopicId = ""; //主题Id
            this.mstrTopicName = ""; //栏目主题
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.memo = ""; //备注
            this.mId = 0; //mId
            this.paperContent = ""; //主题内容
            this.paperId = ""; //论文Id
            this.paperTitle = ""; //论文标题
            this.reason = ""; //理由
            this.updUserId = ""; //修改用户Id
            this.userName = ""; //用户名
            this.viewpointId = ""; //观点Id
            this.viewpointName = ""; //观点名称
            this.viewpointTypeId = ""; //观点类型Id
            this.viewpointTypeName = ""; //观点类型名
            this.updDate = ""; //修改日期
            this.proposePeople = ""; //提出人
            this.source = ""; //来源
            this.topicId = ""; //主题Id
            this.topicName = ""; //栏目主题
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
         * mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetmId(value) {
            if (value != undefined) {
                this.mId = value;
                this.hmProperty["mId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperContent(value) {
            if (value != undefined) {
                this.paperContent = value;
                this.hmProperty["paperContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperTitle(value) {
            if (value != undefined) {
                this.paperTitle = value;
                this.hmProperty["paperTitle"] = true;
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
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUserId(value) {
            if (value != undefined) {
                this.updUserId = value;
                this.hmProperty["updUserId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserName(value) {
            if (value != undefined) {
                this.userName = value;
                this.hmProperty["userName"] = true;
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
         * 观点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetViewpointTypeName(value) {
            if (value != undefined) {
                this.viewpointTypeName = value;
                this.hmProperty["viewpointTypeName"] = true;
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
         * 提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetProposePeople(value) {
            if (value != undefined) {
                this.proposePeople = value;
                this.hmProperty["proposePeople"] = true;
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
         * 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicId(value) {
            if (value != undefined) {
                this.topicId = value;
                this.hmProperty["topicId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 栏目主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicName(value) {
            if (value != undefined) {
                this.topicName = value;
                this.hmProperty["topicName"] = true;
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
                case clsvViewpointCitationEN.con_Memo:
                    return this.memo;
                case clsvViewpointCitationEN.con_mId:
                    return this.mId;
                case clsvViewpointCitationEN.con_PaperContent:
                    return this.paperContent;
                case clsvViewpointCitationEN.con_PaperId:
                    return this.paperId;
                case clsvViewpointCitationEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvViewpointCitationEN.con_Reason:
                    return this.reason;
                case clsvViewpointCitationEN.con_UpdUserId:
                    return this.updUserId;
                case clsvViewpointCitationEN.con_UserName:
                    return this.userName;
                case clsvViewpointCitationEN.con_ViewpointId:
                    return this.viewpointId;
                case clsvViewpointCitationEN.con_ViewpointName:
                    return this.viewpointName;
                case clsvViewpointCitationEN.con_ViewpointTypeId:
                    return this.viewpointTypeId;
                case clsvViewpointCitationEN.con_ViewpointTypeName:
                    return this.viewpointTypeName;
                case clsvViewpointCitationEN.con_UpdDate:
                    return this.updDate;
                case clsvViewpointCitationEN.con_ProposePeople:
                    return this.proposePeople;
                case clsvViewpointCitationEN.con_Source:
                    return this.source;
                case clsvViewpointCitationEN.con_TopicId:
                    return this.topicId;
                case clsvViewpointCitationEN.con_TopicName:
                    return this.topicName;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpointCitation]中不存在！`;
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
                case clsvViewpointCitationEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsvViewpointCitationEN.con_mId:
                    this.mId = Number(strValue);
                    this.hmProperty["mId"] = true;
                    break;
                case clsvViewpointCitationEN.con_PaperContent:
                    this.paperContent = strValue;
                    this.hmProperty["paperContent"] = true;
                    break;
                case clsvViewpointCitationEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsvViewpointCitationEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    this.hmProperty["paperTitle"] = true;
                    break;
                case clsvViewpointCitationEN.con_Reason:
                    this.reason = strValue;
                    this.hmProperty["reason"] = true;
                    break;
                case clsvViewpointCitationEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clsvViewpointCitationEN.con_UserName:
                    this.userName = strValue;
                    this.hmProperty["userName"] = true;
                    break;
                case clsvViewpointCitationEN.con_ViewpointId:
                    this.viewpointId = strValue;
                    this.hmProperty["viewpointId"] = true;
                    break;
                case clsvViewpointCitationEN.con_ViewpointName:
                    this.viewpointName = strValue;
                    this.hmProperty["viewpointName"] = true;
                    break;
                case clsvViewpointCitationEN.con_ViewpointTypeId:
                    this.viewpointTypeId = strValue;
                    this.hmProperty["viewpointTypeId"] = true;
                    break;
                case clsvViewpointCitationEN.con_ViewpointTypeName:
                    this.viewpointTypeName = strValue;
                    this.hmProperty["viewpointTypeName"] = true;
                    break;
                case clsvViewpointCitationEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsvViewpointCitationEN.con_ProposePeople:
                    this.proposePeople = strValue;
                    this.hmProperty["proposePeople"] = true;
                    break;
                case clsvViewpointCitationEN.con_Source:
                    this.source = strValue;
                    this.hmProperty["source"] = true;
                    break;
                case clsvViewpointCitationEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsvViewpointCitationEN.con_TopicName:
                    this.topicName = strValue;
                    this.hmProperty["topicName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vViewpointCitation]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
        /**
        * 常量:"PaperContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperContent() { return "paperContent"; } //主题内容
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"Reason"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Reason() { return "reason"; } //理由
        /**
        * 常量:"UpdUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
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
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"ProposePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProposePeople() { return "proposePeople"; } //提出人
        /**
        * 常量:"Source"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Source() { return "source"; } //来源
        /**
        * 常量:"TopicId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicId() { return "topicId"; } //主题Id
        /**
        * 常量:"TopicName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicName() { return "topicName"; } //栏目主题
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
    exports.clsvViewpointCitationEN = clsvViewpointCitationEN;
    clsvViewpointCitationEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvViewpointCitationEN.CacheModeId = "05"; //未知
    clsvViewpointCitationEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvViewpointCitationEN.WhereFormat = ""; //条件格式串
    clsvViewpointCitationEN._CurrTabName = "vViewpointCitation"; //当前表名,与该类相关的表名
    clsvViewpointCitationEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvViewpointCitationEN.mintAttributeCount = 17;
    clsvViewpointCitationEN.AttributeName = ["memo", "mId", "paperContent", "paperId", "paperTitle", "reason", "updUserId", "userName", "viewpointId", "viewpointName", "viewpointTypeId", "viewpointTypeName", "updDate", "proposePeople", "source", "topicId", "topicName"];
});
