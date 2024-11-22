
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { clsQxUsersEN } from "../TS/L0_Entity/BaseInfo/clsQxUsersEN.js";
import { clsXzClgEN } from "../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js";
import { clsXzMajorEN } from "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js";
import { clsXzGradeBaseEN } from "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js";
import { clsUsersEN } from "../TS/L0_Entity/UserManage_Share/clsUsersEN.js";
import { clsvUsersEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersEN.js";
import { QxUsers_UpdateRecordAsync } from "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js";
import { XzClg_GetObjLstAsync } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js";
import { XzMajor_GetObjLstAsync } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js";
import { XzGradeBase_GetObjLstAsync } from "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js";
import { Users_GetObjByUserIdAsync, Users_UpdateRecordAsync } from "../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js";
import { vUsersSim_ReFreshThisCache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { vUsers_GetFirstObjAsync } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { BindDdl_ObjLst, BindTab } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class UserInfo {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortUsersBy: string = "userId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }



    public async Page_Load() {
        try {
            this.Bind_UserInfo();

            $("#divLoading").hide();
            const ddl_id_GradeBase = await this.BindDdl_id_GradeBase("ddlid_GradeBase");
            const ddl_id_XzCollege = await this.BindDdl_id_XzCollege("ddlid_XzCollege");
            const ddl_id_XzMajor = await this.BindDdl_id_XzMajor2("ddlid_XzMajor");

        }

        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    public async Bind_UserInfo() {

        try {
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            if (strUserId != "") {

                $("#hidUserId").val(strUserId);
                //判断角色 教师
                var strWhereCond = "UserID='" + strUserId + "'";


                //var objvUsers: clsvUsersEN;
                const responseText = vUsers_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                    var objvUsers: clsvUsersEN = <clsvUsersEN>jsonData;
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
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    public async selectMajor_Click() {
        try {
            //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
            var strWhereCond = " id_XzCollege='" + this.id_XzCollege + "'";
            const ddl_id_XzMajor = await this.BindDdl_id_XzMajor("ddlid_XzMajor", strWhereCond);

        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }


    }


    /// <summary>
    /// 为下拉框获取数据,从表:[XzGradeBase]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_id_GradeBase(ddlid_GradeBase: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlid_GradeBase);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlid_GradeBase} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = XzGradeBase_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrXzGradeBaseObjLst: Array<clsXzGradeBaseEN> = <Array<clsXzGradeBaseEN>>jsonData;
                    BindDdl_ObjLst(ddlid_GradeBase, arrXzGradeBaseObjLst, clsXzGradeBaseEN.con_id_GradeBase, clsXzGradeBaseEN.con_GradeBaseName, "年级");
                    console.log("完成BindDdl_id_GradeBase!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /// <summary>
    /// 为下拉框获取数据,从表:[XzClg]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_id_XzCollege(ddlid_XzCollege: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlid_XzCollege);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlid_XzCollege} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = XzClg_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrXzClgObjLst: Array<clsXzClgEN> = <Array<clsXzClgEN>>jsonData;
                    BindDdl_ObjLst(ddlid_XzCollege, arrXzClgObjLst, clsXzClgEN.con_id_XzCollege, clsXzClgEN.con_CollegeName, "学院");
                    console.log("完成BindDdl_id_XzCollege!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /// <summary>
    /// 为下拉框获取数据,从表:[XzMajor]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_id_XzMajor2(ddlid_XzMajor: string) {
        var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlid_XzMajor);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = XzMajor_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrXzMajorObjLst: Array<clsXzMajorEN> = <Array<clsXzMajorEN>>jsonData;
                    BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "专业");
                    console.log("完成BindDdl_id_XzMajor!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /// <summary>
    /// 为下拉框获取数据,从表:[XzMajor]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_id_XzMajor(ddlid_XzMajor: string, strWhereCond: string) {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlid_XzMajor);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = XzMajor_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrXzMajorObjLst: Array<clsXzMajorEN> = <Array<clsXzMajorEN>>jsonData;
                    BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "专业");
                    console.log("完成BindDdl_id_XzMajor!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public btnUpdate_Click() {
        this.btnOKUpd = "确认修改";
        this.Clear();

        var strUserId = clsPublocalStorage.userId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Users_GetObjByUserIdAsync(strUserId).then((jsonData) => {
                    var objUsersEN: clsUsersEN = <clsUsersEN>jsonData;
                    this.GetDataFromUsersClass(objUsersEN);
                    console.log("完成UpdateRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }


    public Clear() {

        this.id_XzCollege = "";
        this.id_XzMajor = "";
        this.id_GradeBase = "";
        this.email = "";
        this.password = "";

    }

    public GetDataFromUsersClass(pobjUsersEN: clsUsersEN) {
        $("#hidUserId").val(pobjUsersEN.userId);// 登录用户名
        if (pobjUsersEN.headPic != "") {
            var strheadPic = "/GraduateStudyWebApp/" + pobjUsersEN.headPic;
            $('#EditheadPic').attr('src', strheadPic);
        }

        this.id_XzCollege = pobjUsersEN.id_XzCollege;
        this.id_XzMajor = pobjUsersEN.id_XzMajor;
        this.id_GradeBase = pobjUsersEN.id_GradeBase;// id_GradeBase
        this.email = pobjUsersEN.email;// EMail
        this.userName = pobjUsersEN.userName;
        $("#txtUploadheadPicUrl").val("");

    }

    //提交
    public async btnOKUpd_Click(strListDiv: string) {
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
                    var returnBool: boolean = jsonData;
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
    public async UpdateRecordSave(): Promise<boolean> {

        var objUsersEN: clsUsersEN = new clsUsersEN();
        var objQxUsersEN: clsQxUsersEN = new clsQxUsersEN();
        objUsersEN.SetUserId(clsPublocalStorage.userId);
        objQxUsersEN.SetUserId(clsPublocalStorage.userId);
        this.PutDataToUsersClass(objUsersEN);
        this.PutDataToUsersClass2(objQxUsersEN);
        objUsersEN.sfUpdFldSetStr = objUsersEN.updFldString;//设置哪些字段被修改(脏字段)
        objQxUsersEN.sfUpdFldSetStr = objQxUsersEN.updFldString;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Users_UpdateRecordAsync(objUsersEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //var strInfo: string = `修改记录成功!`;
                        //$('#lblResult44').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                    }
                    else {
                        var strInfo: string = `修改记录不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("完成UpdateRecordSave");
                    }
                    //resolve(jsonData);
                });

                const responseText2 = QxUsers_UpdateRecordAsync(objQxUsersEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        $("#divLoading").hide();
                        this.Bind_UserInfo();
                        var strInfo: string = `修改记录成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //刷新用户缓存
                        vUsersSim_ReFreshThisCache(clsSysPara4WebApi.cmPrjId);
                    }
                    else {
                        var strInfo: string = `修改记录不成功!`;
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
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        });
    }



    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjUsersEN">数据传输的目的类对象</param>
   */
    public PutDataToUsersClass(pobjUsersEN: clsUsersEN) {
        pobjUsersEN.Setid_XzCollege(this.id_XzCollege);// 学院流水号
        pobjUsersEN.Setid_XzMajor(this.id_XzMajor);// 专业流水号
        pobjUsersEN.Setid_GradeBase(this.id_GradeBase);// 年级流水号
        pobjUsersEN.SetEmail(this.email);// 电子邮箱
        if (this.password != "" && this.RePassword != "") {
            pobjUsersEN.SetPassword(this.password);// password
        }
        //else
        //{
        //    alert("密码不能为空！");
        //}
        pobjUsersEN.SetUpdDate(this.getNowDateNunber());// 修改日期
        pobjUsersEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjUsersEN.SetUserName(this.userName);//用户名
        pobjUsersEN.SetHeadPic($('#hidheadPicUrl').val());//头像

    }


    public PutDataToUsersClass2(pobjQxUsersEN: clsQxUsersEN) {
        pobjQxUsersEN.Setid_XzCollege(this.id_XzCollege);// 学院流水号
        pobjQxUsersEN.SetEmail(this.email);// 电子邮箱
        if (this.password != "" && this.RePassword != "") {
            pobjQxUsersEN.SetPassword(this.password);// password
        }
        //else {
        //    alert("密码不能为空！");
        //}

        pobjQxUsersEN.SetUpdDate(this.getNowDateNunber());// 修改日期
        pobjQxUsersEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjQxUsersEN.SetUserName(this.userName);

    }




    /*
   * 获取年月日
   */
    public getNowDate(): string {
        const date = new Date();
        let month: string | number = date.getMonth() + 1;
        let strDate: string | number = date.getDate();
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
    public getNowDateNunber(): string {
        const date = new Date();
        let month: string | number = date.getMonth() + 1;
        let strDate: string | number = date.getDate();
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
    public set id_GradeBase(value: string) {
        $("#ddlid_GradeBase").val(value);
    }
    /*
    * 年级流水号
   */
    public get id_GradeBase(): string {
        return $("#ddlid_GradeBase").val();
    }

    /*
    * 学院流水号
   */
    public set id_XzCollege(value: string) {
        $("#ddlid_XzCollege").val(value);
    }
    /*
    * 学院流水号
   */
    public get id_XzCollege(): string {
        return $("#ddlid_XzCollege").val();
    }

    /*
    * 专业流水号
   */
    public set id_XzMajor(value: string) {
        $("#ddlid_XzMajor").val(value);
    }
    /*
    * 专业流水号
   */
    public get id_XzMajor(): string {
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
    public set email(value: string) {
        $("#txtEmail").val(value);
    }
    /*
    * 用户ID
   */
    public get email(): string {
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
    public set userName(value: string) {
        $("#txtUserName").val(value);
    }
    /*
    * 用户名
   */
    public get userName(): string {
        return $("#txtUserName").val();
    }
    /*
    * password
    */
    public set password(value: string) {
        $("#txtPassword").val(value);
    }
    /*
    * password
   */
    public get password(): string {
        return $("#txtPassword").val();
    }

    /*
    * password
    */
    public set RePassword(value: string) {
        $("#txtRePassword").val(value);
    }
    /*
    * password
   */
    public get RePassword(): string {
        return $("#txtRePassword").val();
    }


    /*
   * 设置确定按钮的标题
  */
    public set btnOKUpd(value: string) {
        $("#btnOKUpd").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd(): string {
        return $("#btnOKUpd").html();
    }
}