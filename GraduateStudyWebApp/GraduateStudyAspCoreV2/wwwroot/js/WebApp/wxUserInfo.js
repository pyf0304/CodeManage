(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L3_ForWApiEx/UserManage/clswxUserInfoExWApi.js", "../TS/L0_Entity/BaseInfo/clsQxUsersEN.js", "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.wxUserInfo = void 0;
    const clswxUserInfoExWApi_js_1 = require("../TS/L3_ForWApiEx/UserManage/clswxUserInfoExWApi.js");
    const clsQxUsersEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsQxUsersEN.js");
    const clsQxUsersWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class wxUserInfo {
        async Page_Load() {
            var strcode_Hid = $("#hidcode").val();
            try {
                if (strcode_Hid != "") {
                    const responseObjLst = await clswxUserInfoExWApi_js_1.clswxUserInfoExWApi.GetwxUserInfoAsync(strcode_Hid).then((jsonData) => {
                        if (jsonData != null) {
                            var strJson = eval('[' + jsonData + ']');
                            this.openId = strJson[0].openid;
                            this.nickName = strJson[0].nickname;
                            //$('#imgheadimgUrl').str(strJson[0].headimgurl);
                            $("#imgheadimgUrl").attr("src", strJson[0].headimgurl);
                            $('#hidheadimgUrl').val(strJson[0].headimgurl);
                            //for (var i = 0; i < strJson.length; i++) {}
                        }
                        else {
                            window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                        }
                    });
                    if (this.openId != "") {
                        var strWhereCond = "openId = '" + this.openId + "'";
                        const responseObjLst2 = await (0, clsQxUsersWApi_js_1.QxUsers_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                            var objUsers = jsonData;
                            if (objUsers != null) {
                                const bolIsSuccess = this.SetSessionAsync("userId", objUsers.userId);
                                //window.location.href = "/GraduateStudyWebApp/CourseLearning_Share/cc_CourseList";
                                window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                            }
                            else {
                                window.location.href = "#pagetwo";
                            }
                        });
                    }
                    else {
                        var strMsg = `解析json数据不成功`;
                        alert(strMsg);
                    }
                }
                else {
                    window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //this.openId = "ofgZ8wfivfnjdEfvmRZ5TEQJvqrQ";
            //this.nickName = "没有昵称";
            ////$('#imgheadimgUrl').str(strJson[0].headimgurl);
            //$("#imgheadimgUrl").attr("src", "http:\/\/thirdwx.qlogo.cn\/mmopen\/vi_32\/DYAIOgq83eqp5d9DJEhOxU1Hdt21C8Mdomq3dYBxWicFANV3uibWlADibYuTSWQZ6p6icjQibjh6Ao7yEvNAe967VicA\/132");
            //$('#hidheadimgUrl').val("http:\/\/thirdwx.qlogo.cn\/mmopen\/vi_32\/DYAIOgq83eqp5d9DJEhOxU1Hdt21C8Mdomq3dYBxWicFANV3uibWlADibYuTSWQZ6p6icjQibjh6Ao7yEvNAe967VicA\/132");
            //window.location.href = "#pagetwo";
        }
        async btnBind_Click() {
            var strWhereCond = "";
            try {
                if (this.userId != "") {
                    strWhereCond += ` ${clsQxUsersEN_js_1.clsQxUsersEN.con_UserId} = '${this.userId}'`;
                    if (this.password != "") {
                        strWhereCond += ` And ${clsQxUsersEN_js_1.clsQxUsersEN.con_Password} = '${this.password}'`;
                        var objUsers = await (0, clsQxUsersWApi_js_1.QxUsers_GetFirstObjAsync)(strWhereCond);
                        if (objUsers != null) {
                            const bolIsSuccess = this.SetSessionAsync("userId", this.userId);
                            //this.UpdateRecordSave();
                            this.UpdateRecordSave();
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
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            objUsersEN.SetUserId(this.userId);
            objUsersEN.SetOpenId(this.openId);
            objUsersEN.SetNickName(this.nickName);
            objUsersEN.SetHeadimgUrl(this.headimgUrl);
            objUsersEN.SetMemo("微信绑定" + this.openId);
            objUsersEN.sf_UpdFldSetStr = objUsersEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objUsersEN.userId == "" || objUsersEN.userId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsQxUsersWApi_js_1.QxUsers_UpdateRecordAsync)(objUsersEN).then((jsonData2) => {
                        var returnBool = jsonData2;
                        if (returnBool == true) {
                            var strInfo = `微信绑定成功!`;
                            //显示信息框
                            alert(strInfo);
                            //window.location.href = "/GraduateStudyWebApp/CourseLearning_Share/cc_CourseList";
                            window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                        }
                        else {
                            var strInfo = `绑定不成功!`;
                            //显示信息框
                            alert(strInfo);
                            console.log("完成UpdateRecordSave");
                        }
                        resolve(jsonData2);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `修改记录不成功,${e}.`;
                    alert(strMsg);
                }
            });
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
      * 微信id
     */
        set openId(value) {
            $("#hidOpenId").val(value);
        }
        /*
        * 微信id
       */
        get openId() {
            return $("#hidOpenId").val();
        }
        /*
      * 昵称
     */
        set nickName(value) {
            $("#lbNickName").html(value);
        }
        /*
        * 昵称
       */
        get nickName() {
            return $("#lbNickName").html();
        }
        /*
      * 头像
     */
        set headimgUrl(value) {
            $("#hidheadimgUrl").val(value);
        }
        /*
        * 头像
       */
        get headimgUrl() {
            return $("#hidheadimgUrl").val();
        }
        /*
        设置Session
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
        <param name = "Key">关键字</param>
        <param name = "Value">值</param>
        */
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
    exports.wxUserInfo = wxUserInfo;
});
