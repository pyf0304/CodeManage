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
    exports.clsvQxUserRoleRelationEN = void 0;
    /**
    * 类名:clsvQxUserRoleRelationEN
    * 表名:vQxUserRoleRelation(01120257)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:46:15
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:权限管理(UsersRight)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * vQx用户角色关系(vQxUserRoleRelation)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvQxUserRoleRelationEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.mId = 0; //mId
            this.userId = ""; //用户ID
            this.roleId = ""; //角色Id
            this.qxPrjId = ""; //QxPrjId
            this.memo = ""; //备注
            this.prjName = ""; //PrjName
            this.roleName = ""; //角色名
            this.userName = ""; //用户名
            this.departmentId = ""; //部门Id
            this.userStateId = ""; //用户状态Id
            this.departmentName = ""; //部门名称
            this.userStateName = ""; //用户状态名
            this.identityDesc = ""; //身份描述
            this.identityID = ""; //身份编号
            this.stuTeacherID = ""; //学工号
            this.id_XzMajor = ""; //专业流水号
            this.collegeName = ""; //学院名称
            this.id_XzCollege = ""; //学院流水号
            this.majorName = ""; //专业名称
            this.password = ""; //Password
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
                case clsvQxUserRoleRelationEN.con_mId:
                    return this.mId;
                case clsvQxUserRoleRelationEN.con_UserId:
                    return this.userId;
                case clsvQxUserRoleRelationEN.con_RoleId:
                    return this.roleId;
                case clsvQxUserRoleRelationEN.con_QxPrjId:
                    return this.qxPrjId;
                case clsvQxUserRoleRelationEN.con_Memo:
                    return this.memo;
                case clsvQxUserRoleRelationEN.con_PrjName:
                    return this.prjName;
                case clsvQxUserRoleRelationEN.con_RoleName:
                    return this.roleName;
                case clsvQxUserRoleRelationEN.con_UserName:
                    return this.userName;
                case clsvQxUserRoleRelationEN.con_DepartmentId:
                    return this.departmentId;
                case clsvQxUserRoleRelationEN.con_UserStateId:
                    return this.userStateId;
                case clsvQxUserRoleRelationEN.con_DepartmentName:
                    return this.departmentName;
                case clsvQxUserRoleRelationEN.con_UserStateName:
                    return this.userStateName;
                case clsvQxUserRoleRelationEN.con_IdentityDesc:
                    return this.identityDesc;
                case clsvQxUserRoleRelationEN.con_IdentityID:
                    return this.identityID;
                case clsvQxUserRoleRelationEN.con_StuTeacherID:
                    return this.stuTeacherID;
                case clsvQxUserRoleRelationEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvQxUserRoleRelationEN.con_CollegeName:
                    return this.collegeName;
                case clsvQxUserRoleRelationEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvQxUserRoleRelationEN.con_MajorName:
                    return this.majorName;
                case clsvQxUserRoleRelationEN.con_Password:
                    return this.password;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vQxUserRoleRelation]中不存在！`;
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
                case clsvQxUserRoleRelationEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvQxUserRoleRelationEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_RoleId:
                    this.roleId = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_QxPrjId:
                    this.qxPrjId = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_PrjName:
                    this.prjName = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_RoleName:
                    this.roleName = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_DepartmentId:
                    this.departmentId = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_UserStateId:
                    this.userStateId = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_DepartmentName:
                    this.departmentName = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_UserStateName:
                    this.userStateName = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_IdentityDesc:
                    this.identityDesc = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_IdentityID:
                    this.identityID = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_StuTeacherID:
                    this.stuTeacherID = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvQxUserRoleRelationEN.con_Password:
                    this.password = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vQxUserRoleRelation]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"RoleId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RoleId() { return "roleId"; } //角色Id
        /**
        * 常量:"QxPrjId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QxPrjId() { return "qxPrjId"; } //QxPrjId
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"PrjName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PrjName() { return "prjName"; } //PrjName
        /**
        * 常量:"RoleName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RoleName() { return "roleName"; } //角色名
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"DepartmentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DepartmentId() { return "departmentId"; } //部门Id
        /**
        * 常量:"UserStateId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserStateId() { return "userStateId"; } //用户状态Id
        /**
        * 常量:"DepartmentName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DepartmentName() { return "departmentName"; } //部门名称
        /**
        * 常量:"UserStateName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserStateName() { return "userStateName"; } //用户状态名
        /**
        * 常量:"IdentityDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IdentityDesc() { return "identityDesc"; } //身份描述
        /**
        * 常量:"IdentityID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IdentityID() { return "identityID"; } //身份编号
        /**
        * 常量:"StuTeacherID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuTeacherID() { return "stuTeacherID"; } //学工号
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
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
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"Password"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Password() { return "password"; } //Password
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
    exports.clsvQxUserRoleRelationEN = clsvQxUserRoleRelationEN;
    clsvQxUserRoleRelationEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvQxUserRoleRelationEN.CacheModeId = "02"; //客户端缓存
    clsvQxUserRoleRelationEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvQxUserRoleRelationEN.WhereFormat = ""; //条件格式串
    clsvQxUserRoleRelationEN._CurrTabName = "vQxUserRoleRelation"; //当前表名,与该类相关的表名
    clsvQxUserRoleRelationEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvQxUserRoleRelationEN.mintAttributeCount = 20;
    clsvQxUserRoleRelationEN.AttributeName = ["mId", "userId", "roleId", "qxPrjId", "memo", "prjName", "roleName", "userName", "departmentId", "userStateId", "departmentName", "userStateName", "identityDesc", "identityID", "stuTeacherID", "id_XzMajor", "collegeName", "id_XzCollege", "majorName", "password"];
});
