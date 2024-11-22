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
    exports.clsgs_KnowledgesGraphEN = void 0;
    /**
    * 类名:clsgs_KnowledgesGraphEN
    * 表名:gs_KnowledgesGraph(01120873)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 02:45:42
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 知识点逻辑图(gs_KnowledgesGraph)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_KnowledgesGraphEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrKnowledgeGraphId = ""; //知识点图Id
            this.mstrKnowledgeGraphName = ""; //连连看图名
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrCourseId = ""; //课程Id
            this.mstrCreateUser = ""; //建立用户
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            this.mstrGraphTypeId = ""; //图谱类型Id
            this.mbolIsDisplay = false; //是否显示
            this.mbolIsExtend = false; //是否扩展
            this.mbolIsRecommend = false; //是否推荐
            this.mbolIsAnswer = false; //是否回答
            this.mbolIsSubmit = false; //是否提交
            this.mstrStartTime = ""; //开始时间
            this.mstrSubmitTime = ""; //提交时间
            this.mstrTakeUpTime = ""; //耗时
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.knowledgeGraphId = ""; //知识点图Id
            this.knowledgeGraphName = ""; //连连看图名
            this.id_CurrEduCls = ""; //教学班流水号
            this.courseId = ""; //课程Id
            this.createUser = ""; //建立用户
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.graphTypeId = ""; //图谱类型Id
            this.isDisplay = false; //是否显示
            this.isExtend = false; //是否扩展
            this.isRecommend = false; //是否推荐
            this.isAnswer = false; //是否回答
            this.isSubmit = false; //是否提交
            this.startTime = ""; //开始时间
            this.submitTime = ""; //提交时间
            this.takeUpTime = ""; //耗时
        }
        /**
         * 知识点图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKnowledgeGraphId(value) {
            if (value != undefined) {
                this.knowledgeGraphId = value;
                this.hmProperty["knowledgeGraphId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 连连看图名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKnowledgeGraphName(value) {
            if (value != undefined) {
                this.knowledgeGraphName = value;
                this.hmProperty["knowledgeGraphName"] = true;
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
         * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseId(value) {
            if (value != undefined) {
                this.courseId = value;
                this.hmProperty["courseId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 建立用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCreateUser(value) {
            if (value != undefined) {
                this.createUser = value;
                this.hmProperty["createUser"] = true;
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
         * 图谱类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetGraphTypeId(value) {
            if (value != undefined) {
                this.graphTypeId = value;
                this.hmProperty["graphTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsDisplay(value) {
            if (value != undefined) {
                this.isDisplay = value;
                this.hmProperty["isDisplay"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否扩展(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsExtend(value) {
            if (value != undefined) {
                this.isExtend = value;
                this.hmProperty["isExtend"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否推荐(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsRecommend(value) {
            if (value != undefined) {
                this.isRecommend = value;
                this.hmProperty["isRecommend"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否回答(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsAnswer(value) {
            if (value != undefined) {
                this.isAnswer = value;
                this.hmProperty["isAnswer"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSubmit(value) {
            if (value != undefined) {
                this.isSubmit = value;
                this.hmProperty["isSubmit"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 开始时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStartTime(value) {
            if (value != undefined) {
                this.startTime = value;
                this.hmProperty["startTime"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 提交时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSubmitTime(value) {
            if (value != undefined) {
                this.submitTime = value;
                this.hmProperty["submitTime"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 耗时(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTakeUpTime(value) {
            if (value != undefined) {
                this.takeUpTime = value;
                this.hmProperty["takeUpTime"] = true;
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
                case clsgs_KnowledgesGraphEN.con_KnowledgeGraphId:
                    return this.knowledgeGraphId;
                case clsgs_KnowledgesGraphEN.con_KnowledgeGraphName:
                    return this.knowledgeGraphName;
                case clsgs_KnowledgesGraphEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsgs_KnowledgesGraphEN.con_CourseId:
                    return this.courseId;
                case clsgs_KnowledgesGraphEN.con_CreateUser:
                    return this.createUser;
                case clsgs_KnowledgesGraphEN.con_UpdDate:
                    return this.updDate;
                case clsgs_KnowledgesGraphEN.con_UpdUser:
                    return this.updUser;
                case clsgs_KnowledgesGraphEN.con_Memo:
                    return this.memo;
                case clsgs_KnowledgesGraphEN.con_GraphTypeId:
                    return this.graphTypeId;
                case clsgs_KnowledgesGraphEN.con_IsDisplay:
                    return this.isDisplay;
                case clsgs_KnowledgesGraphEN.con_IsExtend:
                    return this.isExtend;
                case clsgs_KnowledgesGraphEN.con_IsRecommend:
                    return this.isRecommend;
                case clsgs_KnowledgesGraphEN.con_IsAnswer:
                    return this.isAnswer;
                case clsgs_KnowledgesGraphEN.con_IsSubmit:
                    return this.isSubmit;
                case clsgs_KnowledgesGraphEN.con_StartTime:
                    return this.startTime;
                case clsgs_KnowledgesGraphEN.con_SubmitTime:
                    return this.submitTime;
                case clsgs_KnowledgesGraphEN.con_TakeUpTime:
                    return this.takeUpTime;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesGraph]中不存在！`;
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
                case clsgs_KnowledgesGraphEN.con_KnowledgeGraphId:
                    this.knowledgeGraphId = strValue;
                    this.hmProperty["knowledgeGraphId"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_KnowledgeGraphName:
                    this.knowledgeGraphName = strValue;
                    this.hmProperty["knowledgeGraphName"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_CreateUser:
                    this.createUser = strValue;
                    this.hmProperty["createUser"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_GraphTypeId:
                    this.graphTypeId = strValue;
                    this.hmProperty["graphTypeId"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_IsDisplay:
                    this.isDisplay = Boolean(strValue);
                    this.hmProperty["isDisplay"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_IsExtend:
                    this.isExtend = Boolean(strValue);
                    this.hmProperty["isExtend"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_IsRecommend:
                    this.isRecommend = Boolean(strValue);
                    this.hmProperty["isRecommend"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_IsAnswer:
                    this.isAnswer = Boolean(strValue);
                    this.hmProperty["isAnswer"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_StartTime:
                    this.startTime = strValue;
                    this.hmProperty["startTime"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_SubmitTime:
                    this.submitTime = strValue;
                    this.hmProperty["submitTime"] = true;
                    break;
                case clsgs_KnowledgesGraphEN.con_TakeUpTime:
                    this.takeUpTime = strValue;
                    this.hmProperty["takeUpTime"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesGraph]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"KnowledgeGraphId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeGraphId() { return "knowledgeGraphId"; } //知识点图Id
        /**
        * 常量:"KnowledgeGraphName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeGraphName() { return "knowledgeGraphName"; } //连连看图名
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"CreateUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateUser() { return "createUser"; } //建立用户
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
        * 常量:"GraphTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GraphTypeId() { return "graphTypeId"; } //图谱类型Id
        /**
        * 常量:"IsDisplay"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsDisplay() { return "isDisplay"; } //是否显示
        /**
        * 常量:"IsExtend"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsExtend() { return "isExtend"; } //是否扩展
        /**
        * 常量:"IsRecommend"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRecommend() { return "isRecommend"; } //是否推荐
        /**
        * 常量:"IsAnswer"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsAnswer() { return "isAnswer"; } //是否回答
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"StartTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StartTime() { return "startTime"; } //开始时间
        /**
        * 常量:"SubmitTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubmitTime() { return "submitTime"; } //提交时间
        /**
        * 常量:"TakeUpTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TakeUpTime() { return "takeUpTime"; } //耗时
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
    exports.clsgs_KnowledgesGraphEN = clsgs_KnowledgesGraphEN;
    clsgs_KnowledgesGraphEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_KnowledgesGraphEN.CacheModeId = "04"; //sessionStorage
    clsgs_KnowledgesGraphEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_KnowledgesGraphEN.WhereFormat = ""; //条件格式串
    clsgs_KnowledgesGraphEN._CurrTabName = "gs_KnowledgesGraph"; //当前表名,与该类相关的表名
    clsgs_KnowledgesGraphEN._KeyFldName = "KnowledgeGraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_KnowledgesGraphEN.mintAttributeCount = 17;
    clsgs_KnowledgesGraphEN.AttributeName = ["knowledgeGraphId", "knowledgeGraphName", "id_CurrEduCls", "courseId", "createUser", "updDate", "updUser", "memo", "graphTypeId", "isDisplay", "isExtend", "isRecommend", "isAnswer", "isSubmit", "startTime", "submitTime", "takeUpTime"];
});
