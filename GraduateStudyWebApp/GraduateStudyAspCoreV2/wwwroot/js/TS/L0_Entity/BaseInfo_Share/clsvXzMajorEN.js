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
    exports.clsvXzMajorEN = void 0;
    /**
    * 类名:clsvXzMajorEN
    * 表名:vXzMajor(01120066)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:13:57
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
    * v专业(vXzMajor)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvXzMajorEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.id_XzMajor = ""; //专业流水号
            this.majorID = ""; //专业ID
            this.majorName = ""; //专业名称
            this.majorEnglishName = ""; //专业英文名称
            this.majorExplain = ""; //专业说明
            this.majorNationalID = ""; //专业国家代码
            this.id_XzCollege = ""; //学院流水号
            this.collegeID = ""; //学院ID
            this.collegeName = ""; //学院名称
            this.collegeNameA = ""; //学院名称简写
            this.id_MajorType = ""; //专业类型(文理工)流水号
            this.majorTypeName = ""; //专业类型名称
            this.id_DegreeType = ""; //学位类型流水号
            this.xwTypeDesc = ""; //学位类型名称
            this.isMainMajor = false; //是否重要专业
            this.majorDirection = ""; //专业方向
            this.isVisible = false; //是否显示
            this.isNormal = false; //IsNormal
            this.modifyDate = ""; //修改日期
            this.modifyUserID = ""; //修改人
            this.memo = ""; //备注
            this.isVisible4XzClg = false; //IsVisible4XzClg
            this.typeName = ""; //类型名称
            this.id_XzMajorShoolType = ""; //专业学校类型流水号
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
                case clsvXzMajorEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvXzMajorEN.con_MajorID:
                    return this.majorID;
                case clsvXzMajorEN.con_MajorName:
                    return this.majorName;
                case clsvXzMajorEN.con_MajorEnglishName:
                    return this.majorEnglishName;
                case clsvXzMajorEN.con_MajorExplain:
                    return this.majorExplain;
                case clsvXzMajorEN.con_MajorNationalID:
                    return this.majorNationalID;
                case clsvXzMajorEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvXzMajorEN.con_CollegeID:
                    return this.collegeID;
                case clsvXzMajorEN.con_CollegeName:
                    return this.collegeName;
                case clsvXzMajorEN.con_CollegeNameA:
                    return this.collegeNameA;
                case clsvXzMajorEN.con_id_MajorType:
                    return this.id_MajorType;
                case clsvXzMajorEN.con_MajorTypeName:
                    return this.majorTypeName;
                case clsvXzMajorEN.con_id_DegreeType:
                    return this.id_DegreeType;
                case clsvXzMajorEN.con_XwTypeDesc:
                    return this.xwTypeDesc;
                case clsvXzMajorEN.con_IsMainMajor:
                    return this.isMainMajor;
                case clsvXzMajorEN.con_MajorDirection:
                    return this.majorDirection;
                case clsvXzMajorEN.con_IsVisible:
                    return this.isVisible;
                case clsvXzMajorEN.con_IsNormal:
                    return this.isNormal;
                case clsvXzMajorEN.con_ModifyDate:
                    return this.modifyDate;
                case clsvXzMajorEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsvXzMajorEN.con_Memo:
                    return this.memo;
                case clsvXzMajorEN.con_IsVisible4XzClg:
                    return this.isVisible4XzClg;
                case clsvXzMajorEN.con_TypeName:
                    return this.typeName;
                case clsvXzMajorEN.con_id_XzMajorShoolType:
                    return this.id_XzMajorShoolType;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzMajor]中不存在！`;
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
                case clsvXzMajorEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvXzMajorEN.con_MajorID:
                    this.majorID = strValue;
                    break;
                case clsvXzMajorEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvXzMajorEN.con_MajorEnglishName:
                    this.majorEnglishName = strValue;
                    break;
                case clsvXzMajorEN.con_MajorExplain:
                    this.majorExplain = strValue;
                    break;
                case clsvXzMajorEN.con_MajorNationalID:
                    this.majorNationalID = strValue;
                    break;
                case clsvXzMajorEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvXzMajorEN.con_CollegeID:
                    this.collegeID = strValue;
                    break;
                case clsvXzMajorEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvXzMajorEN.con_CollegeNameA:
                    this.collegeNameA = strValue;
                    break;
                case clsvXzMajorEN.con_id_MajorType:
                    this.id_MajorType = strValue;
                    break;
                case clsvXzMajorEN.con_MajorTypeName:
                    this.majorTypeName = strValue;
                    break;
                case clsvXzMajorEN.con_id_DegreeType:
                    this.id_DegreeType = strValue;
                    break;
                case clsvXzMajorEN.con_XwTypeDesc:
                    this.xwTypeDesc = strValue;
                    break;
                case clsvXzMajorEN.con_IsMainMajor:
                    this.isMainMajor = Boolean(strValue);
                    break;
                case clsvXzMajorEN.con_MajorDirection:
                    this.majorDirection = strValue;
                    break;
                case clsvXzMajorEN.con_IsVisible:
                    this.isVisible = Boolean(strValue);
                    break;
                case clsvXzMajorEN.con_IsNormal:
                    this.isNormal = Boolean(strValue);
                    break;
                case clsvXzMajorEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    break;
                case clsvXzMajorEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    break;
                case clsvXzMajorEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvXzMajorEN.con_IsVisible4XzClg:
                    this.isVisible4XzClg = Boolean(strValue);
                    break;
                case clsvXzMajorEN.con_TypeName:
                    this.typeName = strValue;
                    break;
                case clsvXzMajorEN.con_id_XzMajorShoolType:
                    this.id_XzMajorShoolType = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzMajor]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
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
        * 常量:"MajorEnglishName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorEnglishName() { return "majorEnglishName"; } //专业英文名称
        /**
        * 常量:"MajorExplain"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorExplain() { return "majorExplain"; } //专业说明
        /**
        * 常量:"MajorNationalID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorNationalID() { return "majorNationalID"; } //专业国家代码
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"CollegeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeID() { return "collegeID"; } //学院ID
        /**
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"CollegeNameA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeNameA() { return "collegeNameA"; } //学院名称简写
        /**
        * 常量:"id_MajorType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_MajorType() { return "id_MajorType"; } //专业类型(文理工)流水号
        /**
        * 常量:"MajorTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorTypeName() { return "majorTypeName"; } //专业类型名称
        /**
        * 常量:"id_DegreeType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_DegreeType() { return "id_DegreeType"; } //学位类型流水号
        /**
        * 常量:"XwTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_XwTypeDesc() { return "xwTypeDesc"; } //学位类型名称
        /**
        * 常量:"IsMainMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsMainMajor() { return "isMainMajor"; } //是否重要专业
        /**
        * 常量:"MajorDirection"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirection() { return "majorDirection"; } //专业方向
        /**
        * 常量:"IsVisible"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible() { return "isVisible"; } //是否显示
        /**
        * 常量:"IsNormal"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsNormal() { return "isNormal"; } //IsNormal
        /**
        * 常量:"ModifyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyDate() { return "modifyDate"; } //修改日期
        /**
        * 常量:"ModifyUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyUserID() { return "modifyUserID"; } //修改人
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"IsVisible4XzClg"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible4XzClg() { return "isVisible4XzClg"; } //IsVisible4XzClg
        /**
        * 常量:"TypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TypeName() { return "typeName"; } //类型名称
        /**
        * 常量:"id_XzMajorShoolType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajorShoolType() { return "id_XzMajorShoolType"; } //专业学校类型流水号
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
    exports.clsvXzMajorEN = clsvXzMajorEN;
    clsvXzMajorEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvXzMajorEN.CacheModeId = "02"; //客户端缓存
    clsvXzMajorEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvXzMajorEN.WhereFormat = ""; //条件格式串
    clsvXzMajorEN._CurrTabName = "vXzMajor"; //当前表名,与该类相关的表名
    clsvXzMajorEN._KeyFldName = "id_XzMajor"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvXzMajorEN.mintAttributeCount = 24;
    clsvXzMajorEN.AttributeName = ["id_XzMajor", "majorID", "majorName", "majorEnglishName", "majorExplain", "majorNationalID", "id_XzCollege", "collegeID", "collegeName", "collegeNameA", "id_MajorType", "majorTypeName", "id_DegreeType", "xwTypeDesc", "isMainMajor", "majorDirection", "isVisible", "isNormal", "modifyDate", "modifyUserID", "memo", "isVisible4XzClg", "typeName", "id_XzMajorShoolType"];
});
