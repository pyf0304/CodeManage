(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo/clsQxUsersEN.js", "../PagesBase/LogManage/LoginLog_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/LogManage/clsLoginLogEN.js", "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js", "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js", "../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Login_TSEx = void 0;
    const clsQxUsersEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsQxUsersEN.js");
    //import { clsQxUsersBL } from "../TS/L2_BLL/BaseInfo/clsQxUsersBL.js";
    const LoginLog_Edit_js_1 = require("../PagesBase/LogManage/LoginLog_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsLoginLogEN_js_1 = require("../TS/L0_Entity/LogManage/clsLoginLogEN.js");
    const clsvQxUserRoleRelationEN_js_1 = require("../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js");
    const clsQxUsersWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsLoginLogWApi_js_1 = require("../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js");
    const clsvQxUserRoleRelationWApi_js_1 = require("../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js");
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
            var strWhereCond = " userId='" + this.userId + "'";
            var arrvUserRoleRelationObjLst = [];
            //获取所有角色，判断是否是教师还是学生；
            const responseObjLst = await (0, clsvQxUserRoleRelationWApi_js_1.vQxUserRoleRelation_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                arrvUserRoleRelationObjLst = jsonData;
                var objvUserRoleRelation = new clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN();
                //循环判断是否包含教师或学生
                if (arrvUserRoleRelationObjLst.length > 0) {
                    for (objvUserRoleRelation of arrvUserRoleRelationObjLst) {
                        //00620002教师 00620003学生、只要包含其中一个角色那么就跳出
                        if (objvUserRoleRelation.roleId == "00620002") {
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
                    window.location.href = "/GraduateStudyWebApp/WebApp/Indexs";
                }
                var strJson = JSON.stringify(objvUserRoleRelation);
                console.log(strJson);
                const bolIsSuccess = this.SetSessionAsync("objvUserRoleRelation", strJson);
            });
        }
        /* 添加新记录
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
        //获取带格式的日志文件
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
