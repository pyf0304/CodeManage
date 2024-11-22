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
    exports.enumXzMajorDirection = exports.clsXzMajorDirectionEN = void 0;
    /**
    * 类名:clsXzMajorDirectionEN
    * 表名:XzMajorDirection(01120552)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:08
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:基本信息维护(BaseInfo)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 专业方向(XzMajorDirection)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsXzMajorDirectionEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrMajorDirectionId = ""; //研究方向Id
            this.mstrid_XzMajor = ""; //专业流水号
            this.mstrMajorDirectionName = ""; //研究方向名
            this.mstrMajorDirectionENName = ""; //研究方向英文名
            this.mstrMajorDirectionExplain = ""; //专业方向说明
            this.mbolIsVisible = false; //是否显示
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.majorDirectionId = ""; //研究方向Id
            this.id_XzMajor = ""; //专业流水号
            this.majorDirectionName = ""; //研究方向名
            this.majorDirectionENName = ""; //研究方向英文名
            this.majorDirectionExplain = ""; //专业方向说明
            this.isVisible = false; //是否显示
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * 研究方向Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorDirectionId(value) {
            if (value != undefined) {
                this.majorDirectionId = value;
                this.hmProperty["majorDirectionId"] = true;
            }
        }
        /**
         * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_XzMajor(value) {
            if (value != undefined) {
                this.id_XzMajor = value;
                this.hmProperty["id_XzMajor"] = true;
            }
        }
        /**
         * 研究方向名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorDirectionName(value) {
            if (value != undefined) {
                this.majorDirectionName = value;
                this.hmProperty["majorDirectionName"] = true;
            }
        }
        /**
         * 研究方向英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorDirectionENName(value) {
            if (value != undefined) {
                this.majorDirectionENName = value;
                this.hmProperty["majorDirectionENName"] = true;
            }
        }
        /**
         * 专业方向说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorDirectionExplain(value) {
            if (value != undefined) {
                this.majorDirectionExplain = value;
                this.hmProperty["majorDirectionExplain"] = true;
            }
        }
        /**
         * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsVisible(value) {
            if (value != undefined) {
                this.isVisible = value;
                this.hmProperty["isVisible"] = true;
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
                case clsXzMajorDirectionEN.con_MajorDirectionId:
                    return this.majorDirectionId;
                case clsXzMajorDirectionEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsXzMajorDirectionEN.con_MajorDirectionName:
                    return this.majorDirectionName;
                case clsXzMajorDirectionEN.con_MajorDirectionENName:
                    return this.majorDirectionENName;
                case clsXzMajorDirectionEN.con_MajorDirectionExplain:
                    return this.majorDirectionExplain;
                case clsXzMajorDirectionEN.con_IsVisible:
                    return this.isVisible;
                case clsXzMajorDirectionEN.con_UpdDate:
                    return this.updDate;
                case clsXzMajorDirectionEN.con_UpdUser:
                    return this.updUser;
                case clsXzMajorDirectionEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[XzMajorDirection]中不存在！`;
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
                case clsXzMajorDirectionEN.con_MajorDirectionId:
                    this.majorDirectionId = strValue;
                    this.hmProperty["majorDirectionId"] = true;
                    break;
                case clsXzMajorDirectionEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    this.hmProperty["id_XzMajor"] = true;
                    break;
                case clsXzMajorDirectionEN.con_MajorDirectionName:
                    this.majorDirectionName = strValue;
                    this.hmProperty["majorDirectionName"] = true;
                    break;
                case clsXzMajorDirectionEN.con_MajorDirectionENName:
                    this.majorDirectionENName = strValue;
                    this.hmProperty["majorDirectionENName"] = true;
                    break;
                case clsXzMajorDirectionEN.con_MajorDirectionExplain:
                    this.majorDirectionExplain = strValue;
                    this.hmProperty["majorDirectionExplain"] = true;
                    break;
                case clsXzMajorDirectionEN.con_IsVisible:
                    this.isVisible = Boolean(strValue);
                    this.hmProperty["isVisible"] = true;
                    break;
                case clsXzMajorDirectionEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsXzMajorDirectionEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsXzMajorDirectionEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[XzMajorDirection]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"MajorDirectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionId() { return "majorDirectionId"; } //研究方向Id
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"MajorDirectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionName() { return "majorDirectionName"; } //研究方向名
        /**
        * 常量:"MajorDirectionENName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionENName() { return "majorDirectionENName"; } //研究方向英文名
        /**
        * 常量:"MajorDirectionExplain"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionExplain() { return "majorDirectionExplain"; } //专业方向说明
        /**
        * 常量:"IsVisible"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible() { return "isVisible"; } //是否显示
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
    exports.clsXzMajorDirectionEN = clsXzMajorDirectionEN;
    clsXzMajorDirectionEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsXzMajorDirectionEN.CacheModeId = "03"; //localStorage
    clsXzMajorDirectionEN._CurrTabName = "XzMajorDirection"; //当前表名,与该类相关的表名
    clsXzMajorDirectionEN._KeyFldName = "MajorDirectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsXzMajorDirectionEN.mintAttributeCount = 9;
    clsXzMajorDirectionEN.AttributeName = ["majorDirectionId", "id_XzMajor", "majorDirectionName", "majorDirectionENName", "majorDirectionExplain", "isVisible", "updDate", "updUser", "memo"];
    /**
    * 根据表内容设置enum列表
    * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
    **/
    class enumXzMajorDirection {
    }
    exports.enumXzMajorDirection = enumXzMajorDirection;
    /**
    * testlyl
    **/
    enumXzMajorDirection.testlyl_00000001 = "00000001";
    /**
    * test0118
    **/
    enumXzMajorDirection.test_00000003 = "00000003";
    /**
    * 杨雪姣
    **/
    enumXzMajorDirection.Lucy_00000004 = "00000004";
    /**
    * 信息化教育
    **/
    enumXzMajorDirection.Information_Technology_00000005 = "00000005";
    /**
    * 绩效培训
    **/
    enumXzMajorDirection._00000006 = "00000006";
    /**
    * 网络方向
    **/
    enumXzMajorDirection._00000007 = "00000007";
    /**
    * 数字媒体
    **/
    enumXzMajorDirection._00000008 = "00000008";
    /**
    * 自适应学习与个性化学习
    **/
    enumXzMajorDirection.Adaptive_learning_and_personalized_learning_00000009 = "00000009";
});
