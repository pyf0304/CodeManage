(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo/clsQxUsersEN.js", "../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js", "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js", "../TS/L0_Entity/UserManage_Share/clsUsersEN.js", "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.UserInfo = void 0;
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const clsQxUsersEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsQxUsersEN.js");
    const clsXzClgEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsXzGradeBaseEN_js_1 = require("../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js");
    const clsUsersEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsUsersEN.js");
    const clsQxUsersWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsUsersWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsvUsersWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class UserInfo {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortUsersBy: string = "userId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            try {
                this.Bind_UserInfo();
                $("#divLoading").hide();
                const ddl_id_GradeBase = await this.BindDdl_id_GradeBase("ddlid_GradeBase");
                const ddl_id_XzCollege = await this.BindDdl_id_XzCollege("ddlid_XzCollege");
                const ddl_id_XzMajor = await this.BindDdl_id_XzMajor2("ddlid_XzMajor");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async Bind_UserInfo() {
            try {
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    //判断角色 教师
                    var strWhereCond = "UserID='" + strUserId + "'";
                    //var objvUsers: clsvUsersEN;
                    const responseText = (0, clsvUsersWApi_js_1.vUsers_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                        var objvUsers = jsonData;
                        if (objvUsers.headPic != "") {
                            var strheadPic = "/GraduateStudyWebApp/" + objvUsers.headPic;
                            $('#headPic').attr('src', strheadPic);
                            $('#hidheadPicUrl').val(objvUsers.headPic);
                        }
                        $('#lbl_identityDesc').html(objvUsers.identityDesc);
                        $('#lbl_collegeName').html(objvUsers.collegeName);
                        $('#lbl_majorName').html(objvUsers.majorName);
                        $('#lbl_gradeBaseName').html(objvUsers.gradeBaseName);
                        $('#lbl_UserName').html(objvUsers.userName);
                        $('#lbl_Email').html(objvUsers.email);
                    });
                }
                else {
                    window.top.location.href = "../Web/Index";
                }
                //const responseRecCount1 = await vUsers_GetRecCountByCondAsync("1=1").then((jsonData) => {
                //    var recCount = jsonData;
                //    $('#PaperNum').html(recCount);
                //});
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
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
        BindDdl_id_XzMajor2(ddlid_XzMajor) {
            var strWhereCond = " 1 =1 ";
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
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        btnUpdate_Click() {
            this.btnOKUpd = "确认修改";
            this.Clear();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsUsersWApi_js_1.Users_GetObjByUserIdAsync)(strUserId).then((jsonData) => {
                        var objUsersEN = jsonData;
                        this.GetDataFromUsersClass(objUsersEN);
                        console.log("完成UpdateRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        Clear() {
            this.id_XzCollege = "";
            this.id_XzMajor = "";
            this.id_GradeBase = "";
            this.email = "";
            this.password = "";
        }
        GetDataFromUsersClass(pobjUsersEN) {
            $("#hidUserId").val(pobjUsersEN.userId); // 登录用户名
            if (pobjUsersEN.headPic != "") {
                var strheadPic = "/GraduateStudyWebApp/" + pobjUsersEN.headPic;
                $('#EditheadPic').attr('src', strheadPic);
            }
            this.id_XzCollege = pobjUsersEN.id_XzCollege;
            this.id_XzMajor = pobjUsersEN.id_XzMajor;
            this.id_GradeBase = pobjUsersEN.id_GradeBase; // id_GradeBase
            this.email = pobjUsersEN.email; // EMail
            this.userName = pobjUsersEN.userName;
            $("#txtUploadheadPicUrl").val("");
        }
        //提交
        async btnOKUpd_Click(strListDiv) {
            if (this.id_XzCollege == "") {
                alert("学院不能为空！");
            }
            else if (this.id_XzMajor == "") {
                alert("专业不能为空！");
            }
            else if (this.id_GradeBase == "") {
                alert("年级不能为空！");
            }
            //else if (this.password == "") {
            //    alert("密码不能为空！");
            //}
            //else if (this.RePassword == "") {
            //    alert("重复密码不能为空！");
            //}
            else {
                if (this.password == this.RePassword) {
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            HideDialog();
                            this.Bind_UserInfo();
                        }
                    });
                }
                else {
                    alert("重复密码不一致！");
                    //window.location.href = "#pagetwo";
                }
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async UpdateRecordSave() {
            var objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            var objQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            objUsersEN.SetUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            objQxUsersEN.SetUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            this.PutDataToUsersClass(objUsersEN);
            this.PutDataToUsersClass2(objQxUsersEN);
            objUsersEN.sf_UpdFldSetStr = objUsersEN.updFldString; //设置哪些字段被修改(脏字段)
            objQxUsersEN.sf_UpdFldSetStr = objQxUsersEN.updFldString;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsUsersWApi_js_1.Users_UpdateRecordAsync)(objUsersEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            //var strInfo: string = `修改记录成功!`;
                            //$('#lblResult44').val(strInfo);
                            ////显示信息框
                            //alert(strInfo);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("完成UpdateRecordSave");
                        }
                        //resolve(jsonData);
                    });
                    const responseText2 = (0, clsQxUsersWApi_js_1.QxUsers_UpdateRecordAsync)(objQxUsersEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            $("#divLoading").hide();
                            this.Bind_UserInfo();
                            var strInfo = `修改记录成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            //刷新用户缓存
                            (0, clsvUsersSimWApi_js_1.vUsersSim_ReFreshThisCache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("完成UpdateRecordSave");
                        }
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `修改记录不成功,${e}.`;
                    alert(strMsg);
                    return false;
                }
            });
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjUsersEN">数据传输的目的类对象</param>
       */
        PutDataToUsersClass(pobjUsersEN) {
            pobjUsersEN.Setid_XzCollege(this.id_XzCollege); // 学院流水号
            pobjUsersEN.Setid_XzMajor(this.id_XzMajor); // 专业流水号
            pobjUsersEN.Setid_GradeBase(this.id_GradeBase); // 年级流水号
            pobjUsersEN.SetEmail(this.email); // 电子邮箱
            if (this.password != "" && this.RePassword != "") {
                pobjUsersEN.SetPassword(this.password); // password
            }
            //else
            //{
            //    alert("密码不能为空！");
            //}
            pobjUsersEN.SetUpdDate(this.getNowDateNunber()); // 修改日期
            pobjUsersEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjUsersEN.SetUserName(this.userName); //用户名
            pobjUsersEN.SetHeadPic($('#hidheadPicUrl').val()); //头像
        }
        PutDataToUsersClass2(pobjQxUsersEN) {
            pobjQxUsersEN.Setid_XzCollege(this.id_XzCollege); // 学院流水号
            pobjQxUsersEN.SetEmail(this.email); // 电子邮箱
            if (this.password != "" && this.RePassword != "") {
                pobjQxUsersEN.SetPassword(this.password); // password
            }
            //else {
            //    alert("密码不能为空！");
            //}
            pobjQxUsersEN.SetUpdDate(this.getNowDateNunber()); // 修改日期
            pobjQxUsersEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjQxUsersEN.SetUserName(this.userName);
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
        // /*
        // * 身份编号
        //*/
        // public set identityID(value: string) {
        //     $("#ddlIdentityID").val(value);
        // }
        // /*
        // * 身份编号
        //*/
        // public get identityID(): string {
        //     return $("#ddlIdentityID").val();
        // }
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
        // /*
        // * 用户ID
        //*/
        // public set ReUserId(value: string) {
        //     $("#txtReUserId").val(value);
        // }
        // /*
        // * 用户ID
        //*/
        // public get ReUserId(): string {
        //     return $("#txtReUserId").val();
        // }
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
        set password(value) {
            $("#txtPassword").val(value);
        }
        /*
        * password
       */
        get password() {
            return $("#txtPassword").val();
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
    }
    exports.UserInfo = UserInfo;
});
