(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/stuUserLoginInfo.js", "../TS/L0_Entity/NewsAnnouncement/clsFeedBackEN.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L3_ForWApi/NewsAnnouncement/clsFeedBackWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.User = void 0;
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
    //import { clsUsersEN } from "../TS/L0_Entity/UserManage/clsUsersEN.js";
    //import { clsUsersWApi } from "../TS/L3_ForWApi/UserManage/clsUsersWApi.js";
    //import { clsvUserRoleRelationEN } from "../TS/L0_Entity/UserManage/clsvUserRoleRelationEN.js";
    //import { clsvUserRoleRelationWApi } from "../TS/L3_ForWApi/UserManage/clsvUserRoleRelationWApi.js";
    const stuUserLoginInfo_js_1 = require("../TS/FunClass/stuUserLoginInfo.js");
    const clsFeedBackEN_js_1 = require("../TS/L0_Entity/NewsAnnouncement/clsFeedBackEN.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsFeedBackWApi_js_1 = require("../TS/L3_ForWApi/NewsAnnouncement/clsFeedBackWApi.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class User {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortUsersBy: string = "userId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strUserInfo_Hid = $("#hidUserInfo").val();
                var objvUserRoleRelation;
                objvUserRoleRelation = stuUserLoginInfo_js_1.stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
                $('#userName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
                //$('#PrjName').html('当前工程：' + objvUserRoleRelation.PrjName);
                $('#hidUserId').val(objvUserRoleRelation.userId);
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                //这是一个单表的插入的代码,由于逻辑层太简单,
                //就把逻辑层合并到控制层,
                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        //HideDialog();
                        //this.BindGv_FeedBack();
                        window.location.href = "#pageone";
                    }
                });
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
      */
        async AddNewRecordSave() {
            //this.DivName = "divAddNewRecordSave";
            var objFeedBackEN = new clsFeedBackEN_js_1.clsFeedBackEN();
            this.PutDataToFeedBackClass(objFeedBackEN);
            try {
                const responseText2 = await (0, clsFeedBackWApi_js_1.FeedBack_AddNewRecordAsync)(objFeedBackEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `提交成功，您的反馈我们会尽快查阅处理!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `提交不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `提交记录不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjFeedBackEN">数据传输的目的类对象</param>
       */
        PutDataToFeedBackClass(pobjFeedBackEN) {
            pobjFeedBackEN.nickName = this.nickName; // 接收者称谓
            pobjFeedBackEN.email = this.EMail; // EMail
            pobjFeedBackEN.feedBackNumber = this.getNowDateNunber();
            pobjFeedBackEN.telephone = this.telephone; // telephone
            pobjFeedBackEN.feedBackContent = this.feedBackContent; // feedBackContent
            pobjFeedBackEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjFeedBackEN.updUser = $("#hidUserId").val(); // 修改人
        }
        /*
         设置Session
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
        GetSessionAsync(Key) {
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
        /*
        * 获取年月日
        */
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
       * 设置确定按钮的标题
      */
        set btnOKUpd(value) {
            $("#btnOKUpd").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd() {
            return $("#btnOKUpd").html();
        }
        /*
       * EMail
      */
        set EMail(value) {
            $("#txtEMail").val(value);
        }
        /*
        * EMail
       */
        get EMail() {
            return $("#txtEMail").val();
        }
        /*
        * feedBackContent
       */
        set feedBackContent(value) {
            $("#txtFeedBackContent").val(value);
        }
        /*
        * feedBackContent
       */
        get feedBackContent() {
            return $("#txtFeedBackContent").val();
        }
        /*
        * 接收者称谓
       */
        set nickName(value) {
            $("#txtNickName").val(value);
        }
        /*
        * 接收者称谓
       */
        get nickName() {
            return $("#txtNickName").val();
        }
        /*
       * telephone
      */
        set telephone(value) {
            $("#txtTelephone").val(value);
        }
        /*
        * telephone
       */
        get telephone() {
            return $("#txtTelephone").val();
        }
    }
    exports.User = User;
});
