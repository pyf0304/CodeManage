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
    exports.clsvXzMajorDirectionEN = void 0;
    /**
    * 类名:clsvXzMajorDirectionEN
    * 表名:vXzMajorDirection(01120553)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 02:45:37
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:基本信息维护(BaseInfo)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v专业方向(vXzMajorDirection)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvXzMajorDirectionEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.majorDirectionId = ""; //研究方向Id
            this.id_XzMajor = ""; //专业流水号
            this.majorID = ""; //专业ID
            this.majorName = ""; //专业名称
            this.majorDirectionName = ""; //研究方向名
            this.majorDirectionENName = ""; //研究方向英文名
            this.majorDirectionExplain = ""; //专业方向说明
            this.isVisible = false; //是否显示
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
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
                case clsvXzMajorDirectionEN.con_MajorDirectionId:
                    return this.majorDirectionId;
                case clsvXzMajorDirectionEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvXzMajorDirectionEN.con_MajorID:
                    return this.majorID;
                case clsvXzMajorDirectionEN.con_MajorName:
                    return this.majorName;
                case clsvXzMajorDirectionEN.con_MajorDirectionName:
                    return this.majorDirectionName;
                case clsvXzMajorDirectionEN.con_MajorDirectionENName:
                    return this.majorDirectionENName;
                case clsvXzMajorDirectionEN.con_MajorDirectionExplain:
                    return this.majorDirectionExplain;
                case clsvXzMajorDirectionEN.con_IsVisible:
                    return this.isVisible;
                case clsvXzMajorDirectionEN.con_UpdDate:
                    return this.updDate;
                case clsvXzMajorDirectionEN.con_UpdUser:
                    return this.updUser;
                case clsvXzMajorDirectionEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzMajorDirection]中不存在！`;
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
                case clsvXzMajorDirectionEN.con_MajorDirectionId:
                    this.majorDirectionId = strValue;
                    break;
                case clsvXzMajorDirectionEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvXzMajorDirectionEN.con_MajorID:
                    this.majorID = strValue;
                    break;
                case clsvXzMajorDirectionEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvXzMajorDirectionEN.con_MajorDirectionName:
                    this.majorDirectionName = strValue;
                    break;
                case clsvXzMajorDirectionEN.con_MajorDirectionENName:
                    this.majorDirectionENName = strValue;
                    break;
                case clsvXzMajorDirectionEN.con_MajorDirectionExplain:
                    this.majorDirectionExplain = strValue;
                    break;
                case clsvXzMajorDirectionEN.con_IsVisible:
                    this.isVisible = Boolean(strValue);
                    break;
                case clsvXzMajorDirectionEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvXzMajorDirectionEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvXzMajorDirectionEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzMajorDirection]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"MajorID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorID() { return "majorID"; } //专业ID
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
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
    exports.clsvXzMajorDirectionEN = clsvXzMajorDirectionEN;
    clsvXzMajorDirectionEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvXzMajorDirectionEN.CacheModeId = "03"; //localStorage
    clsvXzMajorDirectionEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvXzMajorDirectionEN.WhereFormat = ""; //条件格式串
    clsvXzMajorDirectionEN._CurrTabName = "vXzMajorDirection"; //当前表名,与该类相关的表名
    clsvXzMajorDirectionEN._KeyFldName = "MajorDirectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvXzMajorDirectionEN.mintAttributeCount = 11;
    clsvXzMajorDirectionEN.AttributeName = ["majorDirectionId", "id_XzMajor", "majorID", "majorName", "majorDirectionName", "majorDirectionENName", "majorDirectionExplain", "isVisible", "updDate", "updUser", "memo"];
});
