import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsLoginLogEN } from "../TS/L0_Entity/LogManage/clsLoginLogEN.js";
import { clsvQxUserRoleRelationEN } from "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js";
import { cc_Course_GetObjByCourseId_Cache } from "../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js";
import { CurrEduCls_GetObjByid_CurrEduClsAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { LoginLog_AddNewRecordAsync } from "../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js";
import { UserDefaValueEx_getUserDefaValue, UserDefaValueEx_setUserDefaValue } from "../TS/L3_ForWApi/LogManage/clsUserDefaValueExWApi.js";
import { vUsersSim_ReFreshThisCache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { vQxUserRoleRelation_GetFirstObjAsync } from "../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";

declare function CloseWindow(): void;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Login {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortUsersBy: string = "userId";


    public async Page_Load() {
        // 在此处放置用户代码以初始化页面

        try {

        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    //登录方法
    public async btnLogin_Click() {
        const strThisFuncName = this.btnLogin_Click.name;
        $("#divLoading").show();
        var result: string = "";
        var strWhereCond = "";
        try {
            strWhereCond += ` ${clsvQxUserRoleRelationEN.con_UserId} = '${this.userId}'`;
            strWhereCond += ` And ${clsvQxUserRoleRelationEN.con_Password} = '${this.password}'`;
            strWhereCond += ` And QxprjId = '0062' order by roleId asc `;


            var objvUserRoleRelation: clsvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
            //const responseText = await QxUsers_GetFirstObjAsync(strWhereCond);
            //var objQxUsers: clsQxUsersEN = <clsQxUsersEN>responseText;
            const responseObjLst = await vQxUserRoleRelation_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objvUserRoleRelation = <clsvQxUserRoleRelationEN>jsonData;
            });

            if (objvUserRoleRelation != null) {
                result = "ok";
                //调用登录日志；

                clsPublocalStorage.userId = objvUserRoleRelation.userId;
                clsPublocalStorage.userName = objvUserRoleRelation.userName;
                clsPublocalStorage.roleId = objvUserRoleRelation.roleId;
                clsPublocalStorage.roleName = objvUserRoleRelation.roleName;
                clsPublocalStorage.id_XzMajor = objvUserRoleRelation.id_XzMajor;
                clsPublocalStorage.majorName = objvUserRoleRelation.majorName;
                if (clsPublocalStorage.userId != "") {
                    if (clsPublocalStorage.userId != objvUserRoleRelation.userId) {
                        clsPublocalStorage.userId = objvUserRoleRelation.userId;                        
                        var strKey: string = "id_CurrEduCls";
                        localStorage.removeItem(strKey);
                    }
                } else {
                    clsPublocalStorage.userId = objvUserRoleRelation.userId;                    
                }


                const strId_CurrEduCls = await UserDefaValueEx_getUserDefaValue(clsPublocalStorage.userId, "默认教学班Id");
                if (IsNullOrEmpty(strId_CurrEduCls) || strId_CurrEduCls == "0") {
                    //strCmPrjId = await CMProjectEx_AddDefaCmProject(clsPubSessionStorage.currSelPrjId, clsPubSessionStorage.currSelPrjName, clsPublocalStorage.userId);
                    if (IsNullOrEmpty(strId_CurrEduCls) == false) {
                        const con2 = await UserDefaValueEx_setUserDefaValue(clsPublocalStorage.userId, "默认教学班Id", strId_CurrEduCls);
                    }
                    else {
                        const strMsg = Format("新建默认教学班Id不成功，请检查!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                }
                else {
                    
                    var strWhereCond1 = " id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                    // 获取教学班学生数据；
                    const objCurrEduCls = await CurrEduCls_GetObjByid_CurrEduClsAsync(strId_CurrEduCls);

                    if (objCurrEduCls != null) {
                        const strCourseId = objCurrEduCls.courseId;

                        clsPublocalStorage.id_CurrEduCls = strId_CurrEduCls;
                        clsPublocalStorage.eduClsTypeId = objCurrEduCls.eduClsTypeId;
                        clsPublocalStorage.eduClsName = objCurrEduCls.eduClsName;
                        clsPublocalStorage.courseId = strCourseId;
                        const objcc_Course = await cc_Course_GetObjByCourseId_Cache(strCourseId);
                        if (objcc_Course == null) {
                            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                            console.error(strMsg);
                            alert(strMsg);
                            return;
                        }
                        clsPublocalStorage.courseName = objcc_Course.courseName;

                    }

                }


                if (clsPublocalStorage.userId != "") {
                    if (clsPublocalStorage.userId != objvUserRoleRelation.userId) {
                        clsPublocalStorage.userId = objvUserRoleRelation.userId;
                        var strKey: string = "id_CurrEduCls";
                        localStorage.removeItem(strKey);
                    }
                } else {
                    clsPublocalStorage.userId = objvUserRoleRelation.userId;
                }

                $("#divLoading").hide();

                if ($("#hidState").val() == "1") {
                    CloseWindow();
                } else {
                    window.location.href = "../Web/IndexIframe";
                }
                //const responseText1 = await this.GetUserRoleName();
                vUsersSim_ReFreshThisCache(clsSysPara4WebApi.cmPrjId)
                const responseText2 = await this.AddNewRecordLoginLogSave(result);
                //window.location.href = "../Web/Index";
            } else {
                $("#divLoading").hide();
                alert("用户名或密码错误！");

            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `登录失败,${e}.`;
            alert(strMsg);
        }
    }


    /* 添加登录日志
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async AddNewRecordLoginLogSave(strResult: string) {
        //this.DivName = "divAddNewRecordSave";
        var objLoginLogEN: clsLoginLogEN = new clsLoginLogEN();
        this.PutDataToLoginLogClass(objLoginLogEN, strResult);
        try {
            const responseText2 = await LoginLog_AddNewRecordAsync(objLoginLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {

            }
            else {
                $("#divLoading").hide();
                var strInfo: string = `日志添加记录不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjLoginLogEN">数据传输的目的类对象</param>
   */
    public PutDataToLoginLogClass(pobjLoginLogEN: clsLoginLogEN, strResult: string) {
        pobjLoginLogEN.SetLoginUserId(this.userId);// 登录用户Id
        pobjLoginLogEN.SetLoginLogNumber(this.getNowDateNunber());
        //pobjLoginLogEN.SetLoginIP(LoginIp;// 登录IP
        pobjLoginLogEN.SetLoginIP("");// 登录IP 先默认为空
        pobjLoginLogEN.SetLoginTime(clsPubFun4Web.getNowDate());// 登录时间
        pobjLoginLogEN.SetOutTime("");// 注销时间
        pobjLoginLogEN.SetOnlineTime("");// 在线时间
        if (strResult == "ok") {
            pobjLoginLogEN.SetLoginResult("成功");// 登录结果
        }
        else {
            pobjLoginLogEN.SetLoginResult("失败");// 登录结果
        }

        pobjLoginLogEN.SetFailReason("");// failReason
        //pobjLoginLogEN.SetMemo(this.memo;// 备注
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
   * 登录用户名
  */
    public set userId(value: string) {
        $("#txtUserId").val(value);
    }
    /*
    * 登录用户名
   */
    public get userId(): string {
        return $("#txtUserId").val();
    }

    /*
   * 密码
  */
    public set password(value: string) {
        $("#txtPassword").val(value);
    }
    /*
    * 密码
   */
    public get password(): string {
        return $("#txtPassword").val();
    }


    //    /*
    //     设置Session    
    //     <param name = "Key">关键字</param>
    //     <param name = "Value">值</param>
    //    */
    //    public static SetSessionAsync(Key: string, Value: string): Promise<void> {
    //        return new Promise(function (resolve, reject) {

    //            $.ajax({
    //                url: strUrl_Session_SetString,
    //                cache: false,
    //                async: false,
    //                type: 'get',
    //                dataType: "json",
    //                data: {
    //                    Key: Key,
    //                    Value: Value
    //                },
    //                success: function (data) {
    //                    //$('#myValue').val(text);
    //                    var strKey = data.key;
    //                    var strValue = data.value;

    //                    //$('#myKey').html(strKey);
    //                    //$('#myValue').html(strValue);
    //                    console.log(strKey + strValue);

    //                }

    //            });
    //        });
    //    }

    //    /*
    //获取Session 关键字的值
    //<param name = "Key">关键字</param>
    //<return>值</return>
    //*/
    //    public static GetSessionAsync(Key: string): Promise<string> {
    //        return new Promise(function (resolve, reject) {

    //            $.ajax({
    //                url: "/Session/GetString",
    //                cache: false,
    //                async: false,
    //                type: 'get',
    //                dataType: "json",
    //                data: {
    //                    Key: Key
    //                },
    //                success: function (data) {
    //                    var strValue = data.value;

    //                    console.log(Key + strValue);
    //                    resolve(data);
    //                },
    //                error: (e) => {
    //                    var strErrMsg = decodeURIComponent(e.responseText)
    //                    reject(e);
    //                }
    //            });
    //        });
    //    }



    //    public async btn_Register_Click(strListDiv: string) {
    //        try {
    //            const ddl_id_GradeBase = await this.BindDdl_id_GradeBase("ddlid_GradeBase");
    //            const ddl_id_XzCollege = await this.BindDdl_id_XzCollege("ddlid_XzCollege");
    //            //const ddl_id_XzMajor = await this.BindDdl_id_XzMajor("ddlid_XzMajor");
    //            const ddl_IdentityID = await this.BindDdl_IdentityID("ddlIdentityID");
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    }

    //    public async selectMajor_Click() {
    //        try {
    //            //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);
    //            var strWhereCond = " id_XzCollege='" + this.id_XzCollege + "'";
    //            const ddl_id_XzMajor = await this.BindDdl_id_XzMajor("ddlid_XzMajor", strWhereCond);

    //        }
    //        catch (e) {
    //            var strMsg: string = `获取数据有问题,${e}.`;
    //            alert(strMsg);
    //        }


    //    }


    //    /// <summary>
    //    /// 为下拉框获取数据,从表:[XzGradeBase]中获取
    //    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    //    /// </summary>
    //    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    //    public BindDdl_id_GradeBase(ddlid_GradeBase: string, strWhereCond: string = "1 =1") {
    //        //var strWhereCond = " 1 =1 ";
    //        var objDdl = document.getElementById(ddlid_GradeBase);
    //        if (objDdl == null) {
    //            var strMsg = `下拉框：${ddlid_GradeBase} 不存在！`;
    //            alert(strMsg);
    //            throw (strMsg);
    //        }
    //        return new Promise((resolve, reject) => {
    //            try {
    //                const responseText = XzGradeBase_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //                    var arrXzGradeBaseObjLst: Array<clsXzGradeBaseEN> = <Array<clsXzGradeBaseEN>>jsonData;
    //                    BindDdl_ObjLst(ddlid_GradeBase, arrXzGradeBaseObjLst, clsXzGradeBaseEN.con_id_GradeBase, clsXzGradeBaseEN.con_GradeBaseName, "年级");
    //                    console.log("完成BindDdl_id_GradeBase!");
    //                    resolve(jsonData);
    //                });
    //            }
    //            catch (e) {
    //                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //                alert(strMsg);
    //            }
    //        });
    //    }
    //    /// <summary>
    //    /// 为下拉框获取数据,从表:[XzClg]中获取
    //    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    //    /// </summary>
    //    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    //    public BindDdl_id_XzCollege(ddlid_XzCollege: string, strWhereCond: string = "1 =1") {
    //        //var strWhereCond = " 1 =1 ";
    //        var objDdl = document.getElementById(ddlid_XzCollege);
    //        if (objDdl == null) {
    //            var strMsg = `下拉框：${ddlid_XzCollege} 不存在！`;
    //            alert(strMsg);
    //            throw (strMsg);
    //        }
    //        return new Promise((resolve, reject) => {
    //            try {
    //                const responseText = XzClg_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //                    var arrXzClgObjLst: Array<clsXzClgEN> = <Array<clsXzClgEN>>jsonData;
    //                    BindDdl_ObjLst(ddlid_XzCollege, arrXzClgObjLst, clsXzClgEN.con_id_XzCollege, clsXzClgEN.con_CollegeName, "学院");
    //                    console.log("完成BindDdl_id_XzCollege!");
    //                    resolve(jsonData);
    //                });
    //            }
    //            catch (e) {
    //                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //                alert(strMsg);
    //            }
    //        });
    //    }
    //    /// <summary>
    //    /// 为下拉框获取数据,从表:[XzMajor]中获取
    //    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    //    /// </summary>
    //    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    //    public BindDdl_id_XzMajor(ddlid_XzMajor: string, strWhereCond: string) {
    //        //var strWhereCond = " 1 =1 ";
    //        var objDdl = document.getElementById(ddlid_XzMajor);
    //        if (objDdl == null) {
    //            var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
    //            alert(strMsg);
    //            throw (strMsg);
    //        }
    //        return new Promise((resolve, reject) => {
    //            try {
    //                const responseText = XzMajor_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //                    var arrXzMajorObjLst: Array<clsXzMajorEN> = <Array<clsXzMajorEN>>jsonData;
    //                    BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "专业");
    //                    console.log("完成BindDdl_id_XzMajor!");
    //                    resolve(jsonData);
    //                });
    //            }
    //            catch (e) {
    //                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //                alert(strMsg);
    //            }
    //        });
    //    }
    //    /// <summary>
    //    /// 为下拉框获取数据,从表:[UserIdentity]中获取
    //    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    //    /// </summary>
    //    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    //    public BindDdl_IdentityID(ddlIdentityID: string, strWhereCond: string = "1 =1") {
    //        //var strWhereCond = " 1 =1 ";
    //        var objDdl = document.getElementById(ddlIdentityID);
    //        if (objDdl == null) {
    //            var strMsg = `下拉框：${ddlIdentityID} 不存在！`;
    //            alert(strMsg);
    //            throw (strMsg);
    //        }
    //        return new Promise((resolve, reject) => {
    //            try {
    //                const responseText = UserIdentity_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //                    var arrUserIdentityObjLst: Array<clsUserIdentityEN> = <Array<clsUserIdentityEN>>jsonData;
    //                    BindDdl_ObjLst(ddlIdentityID, arrUserIdentityObjLst, clsUserIdentityEN.con_IdentityID, clsUserIdentityEN.con_identityDesc, "用户身份");
    //                    console.log("完成BindDdl_IdentityID!");
    //                    resolve(jsonData);
    //                });
    //            }
    //            catch (e) {
    //                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //                alert(strMsg);
    //            }
    //        });
    //    }



    //    //注册方法
    //    public async btnRegister_Click(strListDiv: string) {
    //        if (this.id_XzCollege == "") {
    //            alert("学院不能为空！");
    //            window.location.href = "#pagetwo";
    //        }
    //        else if (this.id_XzMajor == "") {
    //            alert("专业不能为空！");
    //            window.location.href = "#pagetwo";
    //        }
    //        else if (this.id_GradeBase == "") {
    //            alert("年级不能为空！");
    //            window.location.href = "#pagetwo";
    //        }
    //        else if (this.identityID == "") {
    //            alert("身份不能为空！");
    //            window.location.href = "#pagetwo";
    //        }
    //        else if (this.userId == "") {
    //            alert("账号不能为空！");
    //            window.location.href = "#pagetwo";
    //        }
    //        else if (this.userName == "") {
    //            alert("姓名不能为空！");
    //            window.location.href = "#pagetwo";
    //        }
    //        else if (this.RePassword == "") {
    //            alert("密码不能为空！");
    //            window.location.href = "#pagetwo";
    //        }
    //        else if (this.Re_Password == "") {
    //            alert("重复密码不能为空！");
    //            window.location.href = "#pagetwo";
    //        }
    //        else {
    //            if (this.RePassword == this.Re_Password) {
    //                const responseText2 = await this.AddUserSave().then((jsonData) => {
    //                    var returnBool: boolean = jsonData;
    //                    if (returnBool == true) {
    //                        //alert("注册成功！");
    //                        window.location.href = "#pageLogin";

    //                    }
    //                });
    //            }
    //            else {
    //                alert("重复密码不一致！");
    //                window.location.href = "#pagetwo";
    //            }
    //        }
    //    }


    //    /* 添加新记录
    //    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    //   */
    //    public async AddUserSave() {
    //        this.DivName = "divAddNewRecordSave";
    //        var objUsersEN: clsUsersEN = new clsUsersEN();
    //        this.PutDataToUsersClass(objUsersEN);
    //        try {
    //            const responseText = await Users_IsExistAsync(objUsersEN.userId);
    //            var bolIsExist: boolean = responseText;
    //            if (bolIsExist == true) {
    //                var strMsg: string = `注册账号：${objUsersEN.userId}已经存在，请重新命名！`;
    //                alert(strMsg);
    //                return responseText;//一定要有一个返回值，否则会出错！
    //            }
    //            const responseText2 = await UsersEx_AddNewRecordAsync(objUsersEN);
    //            var returnBool: boolean = !!responseText2;
    //            if (returnBool == true) {
    //                var strInfo: string = `注册成功，请等待管理员审核!`;
    //                $('#lblResult40').val(strInfo);
    //                //显示信息框
    //                alert(strInfo);
    //            }
    //            else {
    //                var strInfo: string = `注册不成功!`;
    //                $('#lblResult40').val(strInfo);
    //                //显示信息框
    //                alert(strInfo);
    //            }
    //            return responseText2;//一定要有一个返回值，否则会出错！
    //        }
    //        catch (e) {
    //            console.error('catch(e)=');
    //            console.error(e);
    //            var strMsg: string = `注册记录不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //        return true;//一定要有一个返回值，否则会出错！
    //    }

    //    /* 函数功能:把界面上的属性数据传到类对象中
    //     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    //     <param name = "pobjUsersEN">数据传输的目的类对象</param>
    //   */
    //    public PutDataToUsersClass(pobjUsersEN: clsUsersEN) {
    //        pobjUsersEN.SetUserId(this.ReUserId;// 用户ID
    //        pobjUsersEN.SetUserName(this.userName;// 用户名
    //        pobjUsersEN.SetUserStateId("02";// 用户状态Id
    //        pobjUsersEN.SetPassword(this.RePassword;// password
    //        pobjUsersEN.Setid_GradeBase(this.id_GradeBase;// 年级流水号
    //        pobjUsersEN.Setid_XzCollege(this.id_XzCollege;// 学院流水号
    //        pobjUsersEN.Setid_XzMajor(this.id_XzMajor;// 专业流水号

    //        pobjUsersEN.SetEmail(this.email;// 电子邮箱
    //        pobjUsersEN.SetIdentityID(this.identityID;// 身份编号
    //        pobjUsersEN.SetIsRegister(true;// isRegister
    //        pobjUsersEN.SetRegisterDate(this.getNowDateNunber();// registerDate 
    //        pobjUsersEN.SetUpdDate(this.getNowDateNunber();// 修改日期
    //        pobjUsersEN.SetUpdUser(this.userId;// 修改人
    //        pobjUsersEN.SetMemo("移动端注册";// 备注
    //    }

    //  /*
    //  * 年级流水号
    // */
    //  public set id_GradeBase(value: string) {
    //      $("#ddlid_GradeBase").val(value);
    //  }
    //  /*
    //  * 年级流水号
    // */
    //  public get id_GradeBase(): string {
    //      return $("#ddlid_GradeBase").val();
    //  }
    //  /*
    //  * 学院流水号
    // */
    //  public set id_XzCollege(value: string) {
    //      $("#ddlid_XzCollege").val(value);
    //  }
    //  /*
    //  * 学院流水号
    // */
    //  public get id_XzCollege(): string {
    //      return $("#ddlid_XzCollege").val();
    //  }

    //  /*
    //  * 专业流水号
    // */
    //  public set id_XzMajor(value: string) {
    //      $("#ddlid_XzMajor").val(value);
    //  }
    //  /*
    //  * 专业流水号
    // */
    //  public get id_XzMajor(): string {
    //      return $("#ddlid_XzMajor").val();
    //  }

    //  /*
    //  * 身份编号
    // */
    //  public set identityID(value: string) {
    //      $("#ddlIdentityID").val(value);
    //  }
    //  /*
    //  * 身份编号
    // */
    //  public get identityID(): string {
    //      return $("#ddlIdentityID").val();
    //  }


    //  /*
    // * 用户ID
    //*/
    //  public set email(value: string) {
    //      $("#txtEmail").val(value);
    //  }
    //  /*
    //  * 用户ID
    // */
    //  public get email(): string {
    //      return $("#txtEmail").val();
    //  }

    //  /*
    //  * 用户ID
    // */
    //  public set ReUserId(value: string) {
    //      $("#txtReUserId").val(value);
    //  }
    //  /*
    //  * 用户ID
    // */
    //  public get ReUserId(): string {
    //      return $("#txtReUserId").val();
    //  }
    //  /*
    //  * 用户名
    // */
    //  public set userName(value: string) {
    //      $("#txtUserName").val(value);
    //  }
    //  /*
    //  * 用户名
    // */
    //  public get userName(): string {
    //      return $("#txtUserName").val();
    //  }
    //  /*
    //  * password
    //  */
    //  public set RePassword(value: string) {
    //      $("#txtRePassword").val(value);
    //  }
    //  /*
    //  * password
    // */
    //  public get RePassword(): string {
    //      return $("#txtRePassword").val();
    //  }

    //  /*
    //  * password
    //  */
    //  public set Re_Password(value: string) {
    //      $("#txtRe_Password").val(value);
    //  }
    //  /*
    //  * password
    // */
    //  public get Re_Password(): string {
    //      return $("#txtRe_Password").val();
    //  }





}