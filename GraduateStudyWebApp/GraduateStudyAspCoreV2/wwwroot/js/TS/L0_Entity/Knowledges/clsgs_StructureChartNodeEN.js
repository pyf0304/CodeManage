(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_StructureChartNodeEN_Sim = exports.clsgs_StructureChartNodeEN = void 0;
    /**
    * 类名:clsgs_StructureChartNodeEN
    * 表名:gs_StructureChartNode(01120877)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:01:45
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:知识点相关
    * 模块英文名:Knowledges
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 结构图节点(gs_StructureChartNode)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsgs_StructureChartNodeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mlngmId = 0; //mId
            this.mstrStructureChartId = ""; //结构图Id
            this.mstrNodeId = ""; //节点Id
            this.mstrNodeTitle = ""; //节点标题
            this.mstrParentId = ""; //父Id
            this.mbolIsRoot = false; //IsRoot
            this.mbolExpanded = false; //扩大
            this.mstrDirection = ""; //方向
            this.mstrBgColor = ""; //背景色
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
        }
        /**
         * mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get mId() {
            return this.mlngmId;
        }
        /**
         * mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set mId(value) {
            if (value != undefined) {
                this.mlngmId = value;
                this.hmProperty["mId"] = true;
            }
        }
        /**
         * 结构图Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get StructureChartId() {
            return this.mstrStructureChartId;
        }
        /**
         * 结构图Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set StructureChartId(value) {
            if (value != undefined) {
                this.mstrStructureChartId = value;
                this.hmProperty["StructureChartId"] = true;
            }
        }
        /**
         * 节点Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get NodeId() {
            return this.mstrNodeId;
        }
        /**
         * 节点Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set NodeId(value) {
            if (value != undefined) {
                this.mstrNodeId = value;
                this.hmProperty["NodeId"] = true;
            }
        }
        /**
         * 节点标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get NodeTitle() {
            return this.mstrNodeTitle;
        }
        /**
         * 节点标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set NodeTitle(value) {
            if (value != undefined) {
                this.mstrNodeTitle = value;
                this.hmProperty["NodeTitle"] = true;
            }
        }
        /**
         * 父Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get parentId() {
            return this.mstrParentId;
        }
        /**
         * 父Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set parentId(value) {
            if (value != undefined) {
                this.mstrParentId = value;
                this.hmProperty["parentId"] = true;
            }
        }
        /**
         * IsRoot(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get IsRoot() {
            return this.mbolIsRoot;
        }
        /**
         * IsRoot(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set IsRoot(value) {
            if (value != undefined) {
                this.mbolIsRoot = value;
                this.hmProperty["IsRoot"] = true;
            }
        }
        /**
         * 扩大(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get Expanded() {
            return this.mbolExpanded;
        }
        /**
         * 扩大(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set Expanded(value) {
            if (value != undefined) {
                this.mbolExpanded = value;
                this.hmProperty["Expanded"] = true;
            }
        }
        /**
         * 方向(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get Direction() {
            return this.mstrDirection;
        }
        /**
         * 方向(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set Direction(value) {
            if (value != undefined) {
                this.mstrDirection = value;
                this.hmProperty["Direction"] = true;
            }
        }
        /**
         * 背景色(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get BgColor() {
            return this.mstrBgColor;
        }
        /**
         * 背景色(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set BgColor(value) {
            if (value != undefined) {
                this.mstrBgColor = value;
                this.hmProperty["BgColor"] = true;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get updDate() {
            return this.mstrUpdDate;
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set updDate(value) {
            if (value != undefined) {
                this.mstrUpdDate = value;
                this.hmProperty["updDate"] = true;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get updUser() {
            return this.mstrUpdUser;
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set updUser(value) {
            if (value != undefined) {
                this.mstrUpdUser = value;
                this.hmProperty["updUser"] = true;
            }
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get memo() {
            return this.mstrMemo;
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set memo(value) {
            if (value != undefined) {
                this.mstrMemo = value;
                this.hmProperty["memo"] = true;
            }
        }
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
        /**
        * 常量:"StructureChartId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StructureChartId() { return "StructureChartId"; } //结构图Id
        /**
        * 常量:"NodeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_NodeId() { return "NodeId"; } //节点Id
        /**
        * 常量:"NodeTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_NodeTitle() { return "NodeTitle"; } //节点标题
        /**
        * 常量:"parentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentId() { return "parentId"; } //父Id
        /**
        * 常量:"IsRoot"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRoot() { return "IsRoot"; } //IsRoot
        /**
        * 常量:"Expanded"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Expanded() { return "Expanded"; } //扩大
        /**
        * 常量:"Direction"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Direction() { return "Direction"; } //方向
        /**
        * 常量:"BgColor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BgColor() { return "BgColor"; } //背景色
        /**
        * 常量:"updDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"updUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            this[strFldName] = strFldValue;
            if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsgs_StructureChartNodeEN = clsgs_StructureChartNodeEN;
    clsgs_StructureChartNodeEN._CurrTabName = "gs_StructureChartNode"; //当前表名,与该类相关的表名
    clsgs_StructureChartNodeEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_StructureChartNodeEN.mintAttributeCount = 12;
    clsgs_StructureChartNodeEN.AttributeName = ["mId", "StructureChartId", "NodeId", "NodeTitle", "parentId", "IsRoot", "Expanded", "Direction", "BgColor", "updDate", "updUser", "memo"];
    /**
    * 结构图节点(gs_StructureChartNode)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsgs_StructureChartNodeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.mId = 0;
            /**
             * 结构图Id(说明:;字段类型:char;字段长度:10;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.StructureChartId = "";
            /**
             * 节点Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.NodeId = "";
            /**
             * 节点标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.NodeTitle = "";
            /**
             * 父Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.parentId = "";
            /**
             * IsRoot(说明:;字段类型:bit;字段长度:1;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.IsRoot = false;
            /**
             * 扩大(说明:;字段类型:bit;字段长度:1;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.Expanded = false;
            /**
             * 方向(说明:;字段类型:varchar;字段长度:50;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.Direction = "";
            /**
             * 背景色(说明:;字段类型:varchar;字段长度:50;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.BgColor = "";
            /**
             * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updDate = "";
            /**
             * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.updUser = "";
            /**
             * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.memo = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsgs_StructureChartNodeEN_Sim = clsgs_StructureChartNodeEN_Sim;
});
