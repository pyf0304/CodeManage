/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiUsers_QUDI_TSEx
表名:Users(00070029)
生成代码版本:2019.08.30.1
生成日期:2019/09/26 01:05:04
生成者:
工程名称:任务管理
工程ID:0007
相关数据库:101.251.68.133,9433TaskManage
PrjDataBaseId:0007
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == ==
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
//import { WApiUsers_QUDI_TS } from "./WApiUsers_QUDI_TS.js";
//import { clsUsersEN } from "../TS/L0_Entity/UserManage_Share/clsUsersEN.js";
//import { clsUsersWApi } from "../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js";
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo/clsQxUsersEN.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js", "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../TS/L0_Entity/LogManage/clsLoginLogEN.js", "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js", "../TS/L0_Entity/UserManage_Share/clsUserIdentityEN.js", "../TS/L0_Entity/UserManage_Share/clsUsersEN.js", "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js", "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js", "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/L3_ForWApiEx/UserManage_Share/clsUsersExWApi.js", "../PagesBase/LogManage/LoginLog_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Login_TSEx = void 0;
    const clsQxUsersEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsQxUsersEN.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsXzClgEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsLoginLogEN_js_1 = require("../TS/L0_Entity/LogManage/clsLoginLogEN.js");
    const clsXzGradeBaseEN_js_1 = require("../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js");
    const clsUserIdentityEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsUserIdentityEN.js");
    const clsUsersEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsUsersEN.js");
    const clsvQxUserRoleRelationEN_js_1 = require("../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js");
    const clsQxUsersWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsLoginLogWApi_js_1 = require("../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsUserIdentityWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js");
    const clsUsersWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsvQxUserRoleRelationWApi_js_1 = require("../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsUsersExWApi_js_1 = require("../TS/L3_ForWApiEx/UserManage_Share/clsUsersExWApi.js");
    const LoginLog_Edit_js_1 = require("../PagesBase/LogManage/LoginLog_Edit.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Login_TSEx extends LoginLog_Edit_js_1.LoginLog_Edit {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortUsersBy: string = "userId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        //登录方法
        async btnQuery_Click() {
            var result = "";
            var strWhereCond = "";
            try {
                if (this.userId != "") {
                    strWhereCond += ` ${clsQxUsersEN_js_1.clsQxUsersEN.con_UserId} = '${this.userId}'`;
                    if (this.password != "") {
                        strWhereCond += ` And ${clsQxUsersEN_js_1.clsQxUsersEN.con_Password} = '${this.password}'`;
                        var arrUsersObjLst = [];
                        arrUsersObjLst = await (0, clsQxUsersWApi_js_1.QxUsers_GetObjLstAsync)(strWhereCond);
                        var objUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
                        if (arrUsersObjLst.length != 0) {
                            for (objUsersEN of arrUsersObjLst) {
                                result = "ok";
                                const bolIsSuccess = this.SetSessionAsync("userId", this.userId);
                                const bolIsSuccess2 = this.SetSessionAsync("userName", objUsersEN.userName);
                                //this.GetUserRoleName();
                                //调用登录日志；
                                this.AddNewRecordLoginLogSave(result);
                                //alert("登录成功！");
                                break;
                            }
                        }
                        else {
                            alert("用户名或密码错误！");
                        }
                    }
                    else {
                        alert("请输入密码！");
                    }
                }
                else {
                    alert("请输入用户名！");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `登录失败,${e}.`;
                alert(strMsg);
            }
        }
        //通过用户登录ID获取用户的角色名
        async GetUserRoleName() {
            var strRoleResult = "";
            var strWhereCond = " userId='" + this.userId + "' And QxprjId='0062' order by roleId asc ";
            var arrvUserRoleRelationObjLst = [];
            //获取所有角色，判断是否是教师还是学生；
            const responseObjLst = await (0, clsvQxUserRoleRelationWApi_js_1.vQxUserRoleRelation_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                arrvUserRoleRelationObjLst = jsonData;
                var objvUserRoleRelation = new clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN();
                //循环判断是否包含教师或学生
                if (arrvUserRoleRelationObjLst.length > 0) {
                    for (objvUserRoleRelation of arrvUserRoleRelationObjLst) {
                        //00620001 管理员 00620002教师 00620003学生、只要包含其中一个角色那么就跳出
                        if (objvUserRoleRelation.roleId == "00620001") {
                            strRoleResult = "admin";
                            break;
                        }
                        else if (objvUserRoleRelation.roleId == "00620002") {
                            strRoleResult = "teacher";
                            break;
                        }
                        else if (objvUserRoleRelation.roleId == "00620003") {
                            strRoleResult = "student";
                            break;
                        }
                        else {
                        }
                    }
                    //window.location.href = "/WebApp/UserRoleRelation";
                    //window.location.href = "/GraduateStudyWebApp/CourseLearning_Share/cc_CourseList";
                    if ($("#hidStata").val() == "1") {
                        window.location.href = "../Web/Index";
                    }
                    else {
                        window.location.href = "../WebApp/Indexs";
                    }
                }
                var strJson = JSON.stringify(objvUserRoleRelation);
                console.log(strJson);
                const bolIsSuccess = this.SetSessionAsync("objvUserRoleRelation", strJson);
            });
        }
        /* 添加登录日志
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
     */
        async AddNewRecordLoginLogSave(strResult) {
            var objLoginLogEN = new clsLoginLogEN_js_1.clsLoginLogEN();
            this.PutDataToLoginLogClass_pyf(objLoginLogEN, strResult);
            try {
                const responseText2 = await (0, clsLoginLogWApi_js_1.LoginLog_AddNewRecordAsync)(objLoginLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //登录 成功 ，获取用户角色角色存放session；
                    this.GetUserRoleName();
                    //var strInfo: string = `添加记录成功!`;
                    //$('#lblResult40').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);
                }
                else {
                    var strInfo = `日志添加记录不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjLoginLogEN">数据传输的目的类对象</param>
       */
        async PutDataToLoginLogClass_pyf(pobjLoginLogEN, strResult) {
            pobjLoginLogEN.SetLoginUserId(this.userId); // 登录用户Id
            pobjLoginLogEN.SetLoginLogNumber(this.getNowDateNunber());
            //pobjLoginLogEN.SetLoginIP(LoginIp;// 登录IP
            pobjLoginLogEN.SetLoginIP(""); // 登录IP 先默认为空
            pobjLoginLogEN.SetLoginTime(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 登录时间
            pobjLoginLogEN.SetOutTime(""); // 注销时间
            pobjLoginLogEN.SetOnlineTime(""); // 在线时间
            if (strResult == "ok") {
                pobjLoginLogEN.SetLoginResult("成功"); // 登录结果
            }
            else {
                pobjLoginLogEN.SetLoginResult("失败"); // 登录结果
            }
            pobjLoginLogEN.SetFailReason(""); // failReason
            pobjLoginLogEN.SetMemo(this.memo); // 备注
        }
        /*
       * 获取年月日数据串
       */
        getNowDateNunber() {
            const date = new Date();
            let month = date.getMonth() + 1;
            let strDate = date.getDate();
            if (month <= 9) {
                month = "0" + month;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            return date.getFullYear().toString() + month + strDate + date.getHours() + date.getMinutes() + date.getSeconds();
        }
        //获取带格式的年月日
        getNowDate() {
            const date = new Date();
            let month = date.getMonth() + 1;
            let strDate = date.getDate();
            if (month <= 9) {
                month = "0" + month;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
        }
        /*
       * 登录用户名
      */
        set userId(value) {
            $("#txtUserId").val(value);
        }
        /*
        * 登录用户名
       */
        get userId() {
            return $("#txtUserId").val();
        }
        /*
       * 密码
      */
        set password(value) {
            $("#txtPassword").val(value);
        }
        /*
        * 密码
       */
        get password() {
            return $("#txtPassword").val();
        }
        /*
         设置Session
         <param name = "Key">关键字</param>
         <param name = "Value">值</param>
        */
        static SetSessionAsync(Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        //$('#myValue').val(text);
                        var strKey = data.key;
                        var strValue = data.value;
                        //$('#myKey').html(strKey);
                        //$('#myValue').html(strValue);
                        console.log(strKey + strValue);
                    }
                });
            });
        }
        /*
    获取Session 关键字的值
    <param name = "Key">关键字</param>
    <return>值</return>
    */
        static GetSessionAsync(Key) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: "/Session/GetString",
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key
                    },
                    success: function (data) {
                        var strValue = data.value;
                        console.log(Key + strValue);
                        resolve(data);
                    },
                    error: (e) => {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        }
        async btn_Register_Click(strListDiv) {
            try {
                const ddl_id_GradeBase = await this.BindDdl_id_GradeBase("ddlid_GradeBase");
                const ddl_id_XzCollege = await this.BindDdl_id_XzCollege("ddlid_XzCollege");
                //const ddl_id_XzMajor = await this.BindDdl_id_XzMajor("ddlid_XzMajor");
                const ddl_IdentityID = await this.BindDdl_IdentityID("ddlIdentityID");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async selectMajor_Click() {
            try {
                //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
                var strWhereCond = " id_XzCollege='" + this.id_XzCollege + "'";
                const ddl_id_XzMajor = await this.BindDdl_id_XzMajor("ddlid_XzMajor", strWhereCond);
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[XzGradeBase]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_id_GradeBase(ddlid_GradeBase, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlid_GradeBase);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlid_GradeBase} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzGradeBaseWApi_js_1.XzGradeBase_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrXzGradeBaseObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlid_GradeBase, arrXzGradeBaseObjLst, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseName, "年级");
                        console.log("完成BindDdl_id_GradeBase!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[XzClg]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_id_XzCollege(ddlid_XzCollege, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlid_XzCollege);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlid_XzCollege} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzClgWApi_js_1.XzClg_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrXzClgObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlid_XzCollege, arrXzClgObjLst, clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege, clsXzClgEN_js_1.clsXzClgEN.con_CollegeName, "学院");
                        console.log("完成BindDdl_id_XzCollege!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[XzMajor]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_id_XzMajor(ddlid_XzMajor, strWhereCond) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlid_XzMajor);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzMajorWApi_js_1.XzMajor_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrXzMajorObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
                        console.log("完成BindDdl_id_XzMajor!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[UserIdentity]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_IdentityID(ddlIdentityID, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlIdentityID);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlIdentityID} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsUserIdentityWApi_js_1.UserIdentity_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrUserIdentityObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlIdentityID, arrUserIdentityObjLst, clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID, clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityDesc, "用户身份");
                        console.log("完成BindDdl_IdentityID!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //注册方法
        async btnRegister_Click(strListDiv) {
            if (this.id_XzCollege == "") {
                alert("学院不能为空！");
                window.location.href = "#pagetwo";
            }
            else if (this.id_XzMajor == "") {
                alert("专业不能为空！");
                window.location.href = "#pagetwo";
            }
            else if (this.id_GradeBase == "") {
                alert("年级不能为空！");
                window.location.href = "#pagetwo";
            }
            else if (this.identityID == "") {
                alert("身份不能为空！");
                window.location.href = "#pagetwo";
            }
            else if (this.userId == "") {
                alert("账号不能为空！");
                window.location.href = "#pagetwo";
            }
            else if (this.userName == "") {
                alert("姓名不能为空！");
                window.location.href = "#pagetwo";
            }
            else if (this.RePassword == "") {
                alert("密码不能为空！");
                window.location.href = "#pagetwo";
            }
            else if (this.Re_Password == "") {
                alert("重复密码不能为空！");
                window.location.href = "#pagetwo";
            }
            else {
                if (this.RePassword == this.Re_Password) {
                    const responseText2 = await this.AddUserSave().then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //alert("注册成功！");
                            window.location.href = "#pageLogin";
                        }
                    });
                }
                else {
                    alert("重复密码不一致！");
                    window.location.href = "#pagetwo";
                }
            }
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddUserSave() {
            var objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            this.PutDataToUsersClass(objUsersEN);
            try {
                const responseText = await (0, clsUsersWApi_js_1.Users_IsExistAsync)(objUsersEN.userId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `注册账号：${objUsersEN.userId}已经存在，请重新命名！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsUsersExWApi_js_1.UsersEx_AddNewRecordAsync)(objUsersEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `注册成功，请等待管理员审核!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `注册不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `注册记录不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjUsersEN">数据传输的目的类对象</param>
       */
        PutDataToUsersClass(pobjUsersEN) {
            pobjUsersEN.SetUserId(this.ReUserId); // 用户ID
            pobjUsersEN.SetUserName(this.userName); // 用户名
            pobjUsersEN.SetUserStateId("02"); // 用户状态Id
            pobjUsersEN.SetPassword(this.RePassword); // password
            pobjUsersEN.Setid_GradeBase(this.id_GradeBase); // 年级流水号
            pobjUsersEN.Setid_XzCollege(this.id_XzCollege); // 学院流水号
            pobjUsersEN.Setid_XzMajor(this.id_XzMajor); // 专业流水号
            pobjUsersEN.SetEmail(this.email); // 电子邮箱
            pobjUsersEN.SetIdentityID(this.identityID); // 身份编号
            pobjUsersEN.SetIsRegister(true); // isRegister
            pobjUsersEN.SetRegisterDate(this.getNowDateNunber()); // registerDate 
            pobjUsersEN.SetUpdDate(this.getNowDateNunber()); // 修改日期
            pobjUsersEN.SetUpdUser(this.userId); // 修改人
            pobjUsersEN.SetMemo("移动端注册"); // 备注
        }
        /*
        * 年级流水号
       */
        set id_GradeBase(value) {
            $("#ddlid_GradeBase").val(value);
        }
        /*
        * 年级流水号
       */
        get id_GradeBase() {
            return $("#ddlid_GradeBase").val();
        }
        /*
        * 学院流水号
       */
        set id_XzCollege(value) {
            $("#ddlid_XzCollege").val(value);
        }
        /*
        * 学院流水号
       */
        get id_XzCollege() {
            return $("#ddlid_XzCollege").val();
        }
        /*
        * 专业流水号
       */
        set id_XzMajor(value) {
            $("#ddlid_XzMajor").val(value);
        }
        /*
        * 专业流水号
       */
        get id_XzMajor() {
            return $("#ddlid_XzMajor").val();
        }
        /*
        * 身份编号
       */
        set identityID(value) {
            $("#ddlIdentityID").val(value);
        }
        /*
        * 身份编号
       */
        get identityID() {
            return $("#ddlIdentityID").val();
        }
        /*
       * 用户ID
      */
        set email(value) {
            $("#txtEmail").val(value);
        }
        /*
        * 用户ID
       */
        get email() {
            return $("#txtEmail").val();
        }
        /*
        * 用户ID
       */
        set ReUserId(value) {
            $("#txtReUserId").val(value);
        }
        /*
        * 用户ID
       */
        get ReUserId() {
            return $("#txtReUserId").val();
        }
        /*
        * 用户名
       */
        set userName(value) {
            $("#txtUserName").val(value);
        }
        /*
        * 用户名
       */
        get userName() {
            return $("#txtUserName").val();
        }
        /*
        * password
        */
        set RePassword(value) {
            $("#txtRePassword").val(value);
        }
        /*
        * password
       */
        get RePassword() {
            return $("#txtRePassword").val();
        }
        /*
        * password
        */
        set Re_Password(value) {
            $("#txtRe_Password").val(value);
        }
        /*
        * password
       */
        get Re_Password() {
            return $("#txtRe_Password").val();
        }
        SetSessionAsync(Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                    }
                });
            });
        }
    }
    exports.Login_TSEx = Login_TSEx;
});
