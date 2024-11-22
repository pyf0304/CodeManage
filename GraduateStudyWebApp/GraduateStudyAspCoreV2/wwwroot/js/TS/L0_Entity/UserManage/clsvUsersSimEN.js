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
    exports.clsvUsersSimEN = void 0;
    /**
    * 类名:clsvUsersSimEN
    * 表名:vUsersSim(01120699)
    * 版本:2023.02.24.1(服务器:WIN-SRV103-116)
    * 日期:2023/02/25 21:19:31
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:用户管理(UserManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * vUsersSim(vUsersSim)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvUsersSimEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.userId = ""; //用户ID
            this.userName = ""; //用户名
            this.id_XzCollege = ""; //学院流水号
            this.collegeName = ""; //学院名称
            this.id_XzMajor = ""; //专业流水号
            this.majorName = ""; //专业名称
            this.headPic = ""; //头像
            this.isGSuser = false; //是否GS用户
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
                case clsvUsersSimEN.con_UserId:
                    return this.userId;
                case clsvUsersSimEN.con_UserName:
                    return this.userName;
                case clsvUsersSimEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvUsersSimEN.con_CollegeName:
                    return this.collegeName;
                case clsvUsersSimEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvUsersSimEN.con_MajorName:
                    return this.majorName;
                case clsvUsersSimEN.con_HeadPic:
                    return this.headPic;
                case clsvUsersSimEN.con_IsGSuser:
                    return this.isGSuser;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vUsersSim]中不存在！`;
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
                case clsvUsersSimEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvUsersSimEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvUsersSimEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvUsersSimEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvUsersSimEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvUsersSimEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvUsersSimEN.con_HeadPic:
                    this.headPic = strValue;
                    break;
                case clsvUsersSimEN.con_IsGSuser:
                    this.isGSuser = Boolean(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vUsersSim]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
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
        * 常量:"HeadPic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_HeadPic() { return "headPic"; } //头像
        /**
        * 常量:"IsGSuser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsGSuser() { return "isGSuser"; } //是否GS用户
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
    exports.clsvUsersSimEN = clsvUsersSimEN;
    clsvUsersSimEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvUsersSimEN.CacheModeId = "03"; //localStorage
    clsvUsersSimEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvUsersSimEN.WhereFormat = "UserId in (Select UserId from CmPrjIdUserIdRela where CmPrjId='{0}')"; //条件格式串
    clsvUsersSimEN._CurrTabName = "vUsersSim"; //当前表名,与该类相关的表名
    clsvUsersSimEN._KeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvUsersSimEN.mintAttributeCount = 8;
    clsvUsersSimEN.AttributeName = ["userId", "userName", "id_XzCollege", "collegeName", "id_XzMajor", "majorName", "headPic", "isGSuser"];
});
