(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/LogManage/clsLoginLogEN.js", "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js", "../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Login = void 0;
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsLoginLogEN_js_1 = require("../TS/L0_Entity/LogManage/clsLoginLogEN.js");
    const clsvQxUserRoleRelationEN_js_1 = require("../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js");
    const clsLoginLogWApi_js_1 = require("../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsvQxUserRoleRelationWApi_js_1 = require("../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Login {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortUsersBy: string = "userId";
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        //登录方法
        async btnQuery_Click() {
            $("#divLoading").show();
            var result = "";
            var strWhereCond = "";
            try {
                strWhereCond += ` ${clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserId} = '${this.userId}'`;
                strWhereCond += ` And ${clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Password} = '${this.password}'`;
                strWhereCond += ` And QxprjId = '0062' order by roleId asc `;
                var objvUserRoleRelation = new clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN();
                //const responseText = await QxUsers_GetFirstObjAsync(strWhereCond);
                //var objQxUsers: clsQxUsersEN = <clsQxUsersEN>responseText;
                const responseObjLst = await (0, clsvQxUserRoleRelationWApi_js_1.vQxUserRoleRelation_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                    objvUserRoleRelation = jsonData;
                });
                if (objvUserRoleRelation != null) {
                    result = "ok";
                    //调用登录日志；
                    clsPubSessionStorage_js_1.clsPubSessionStorage.SetSession_UserId(objvUserRoleRelation.userId);
                    clsPubSessionStorage_js_1.clsPubSessionStorage.SetSession_UserName(objvUserRoleRelation.userName);
                    clsPubSessionStorage_js_1.clsPubSessionStorage.SetSession_RoleId(objvUserRoleRelation.roleId);
                    clsPubSessionStorage_js_1.clsPubSessionStorage.SetSession_RoleName(objvUserRoleRelation.roleName);
                    clsPubSessionStorage_js_1.clsPubSessionStorage.SetSession_id_XzMajor(objvUserRoleRelation.id_XzMajor);
                    clsPubSessionStorage_js_1.clsPubSessionStorage.SetSession_majorName(objvUserRoleRelation.majorName);
                    if (clsPublocalStorage_js_1.clsPublocalStorage.GetUserId() != "") {
                        if (clsPublocalStorage_js_1.clsPublocalStorage.GetUserId() != objvUserRoleRelation.userId) {
                            clsPublocalStorage_js_1.clsPublocalStorage.SetUserId(objvUserRoleRelation.userId);
                            clsPubSessionStorage_js_1.clsPubSessionStorage.userId = objvUserRoleRelation.userId;
                            var strKey = "id_CurrEduCls";
                            localStorage.removeItem(strKey);
                        }
                    }
                    else {
                        clsPublocalStorage_js_1.clsPublocalStorage.SetUserId(objvUserRoleRelation.userId);
                        clsPubSessionStorage_js_1.clsPubSessionStorage.userId = objvUserRoleRelation.userId;
                    }
                    $("#divLoading").hide();
                    if ($("#hidState").val() == "1") {
                        CloseWindow();
                    }
                    else {
                        window.location.href = "../Web/IndexIframe";
                    }
                    //const responseText1 = await this.GetUserRoleName();
                    (0, clsvUsersSimWApi_js_1.vUsersSim_ReFreshThisCache)();
                    const responseText2 = await this.AddNewRecordLoginLogSave(result);
                    //window.location.href = "../Web/Index";
                }
                else {
                    $("#divLoading").hide();
                    alert("用户名或密码错误！");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `登录失败,${e}.`;
                alert(strMsg);
            }
        }
        /* 添加登录日志
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
     */
        async AddNewRecordLoginLogSave(strResult) {
            //this.DivName = "divAddNewRecordSave";
            var objLoginLogEN = new clsLoginLogEN_js_1.clsLoginLogEN();
            this.PutDataToLoginLogClass(objLoginLogEN, strResult);
            try {
                const responseText2 = await (0, clsLoginLogWApi_js_1.LoginLog_AddNewRecordAsync)(objLoginLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                }
                else {
                    $("#divLoading").hide();
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
        PutDataToLoginLogClass(pobjLoginLogEN, strResult) {
            pobjLoginLogEN.loginUserId = this.userId; // 登录用户Id
            pobjLoginLogEN.loginLogNumber = this.getNowDateNunber();
            //pobjLoginLogEN.loginIP = LoginIp;// 登录IP
            pobjLoginLogEN.loginIP = ""; // 登录IP 先默认为空
            pobjLoginLogEN.loginTime = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 登录时间
            pobjLoginLogEN.outTime = ""; // 注销时间
            pobjLoginLogEN.onlineTime = ""; // 在线时间
            if (strResult == "ok") {
                pobjLoginLogEN.loginResult = "成功"; // 登录结果
            }
            else {
                pobjLoginLogEN.loginResult = "失败"; // 登录结果
            }
            pobjLoginLogEN.failReason = ""; // failReason
            //pobjLoginLogEN.memo = this.memo;// 备注
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
    }
    exports.Login = Login;
});
