
import { clsQxUsersEN } from "../TS/L0_Entity/BaseInfo/clsQxUsersEN.js";
//import { clsQxUsersBL } from "../TS/L2_BLL/BaseInfo/clsQxUsersBL.js";

import { LoginLog_Edit } from "../PagesBase/LogManage/LoginLog_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsLoginLogEN } from "../TS/L0_Entity/LogManage/clsLoginLogEN.js";
import { clsvQxUserRoleRelationEN } from "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js";
import { QxUsers_GetObjLstAsync } from "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js";
import { LoginLog_AddNewRecordAsync } from "../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js";
import { vQxUserRoleRelation_GetObjLstAsync } from "../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js";
//import { clsQxUsersEN } from "../TS4GP/L0_Entity/UserManage/clsQxUsersEN.js";
//import { clsQxUsersWApi } from "../TS4GP/L3_ForWApi/UserManage/clsQxUsersWApi.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
//ip
declare var LoginIp;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Login_TSEx extends LoginLog_Edit {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortUsersBy: string = "userId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }


    //登录方法
    public async btnQuery_Click() {
        var result: string = "";
        var strWhereCond = "";
        try {
            if (this.userId != "") {
                strWhereCond += ` ${clsQxUsersEN.con_UserId} = '${this.userId}'`;
                if (this.password != "") {
                    strWhereCond += ` And ${clsQxUsersEN.con_Password} = '${this.password}'`;
                    var arrUsersObjLst: Array<clsQxUsersEN> = [];
                    arrUsersObjLst = await QxUsers_GetObjLstAsync(strWhereCond);
                    var objUsersEN: clsQxUsersEN = new clsQxUsersEN();

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
            var strMsg: string = `登录失败,${e}.`;
            alert(strMsg);
        }
    }

    //通过用户登录ID获取用户的角色名
    public async GetUserRoleName() {
        var strRoleResult: string = "";
        var strWhereCond: string = " userId='" + this.userId + "'";
        var arrvUserRoleRelationObjLst: Array<clsvQxUserRoleRelationEN> = [];
        //获取所有角色，判断是否是教师还是学生；
        const responseObjLst = await vQxUserRoleRelation_GetObjLstAsync(strWhereCond).then((jsonData) => {
            arrvUserRoleRelationObjLst = <Array<clsvQxUserRoleRelationEN>>jsonData;
            var objvUserRoleRelation: clsvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
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
    public async AddNewRecordLoginLogSave(strResult: string) {
        
        var objLoginLogEN: clsLoginLogEN = new clsLoginLogEN();
        this.PutDataToLoginLogClass_pyf(objLoginLogEN, strResult);
        try {
            const responseText2 = await LoginLog_AddNewRecordAsync(objLoginLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {

                //登录 成功 ，获取用户角色角色存放session；
                this.GetUserRoleName();

                //var strInfo: string = `添加记录成功!`;
                //$('#lblResult40').val(strInfo);
                ////显示信息框
                //alert(strInfo);
            }
            else {
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
    public async PutDataToLoginLogClass_pyf(pobjLoginLogEN: clsLoginLogEN, strResult: string) {
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
        pobjLoginLogEN.SetMemo(this.memo);// 备注
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

    //获取带格式的日志文件
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


    /*
     设置Session    
     <param name = "Key">关键字</param>
     <param name = "Value">值</param>
    */
    public static SetSessionAsync(Key: string, Value: string): Promise<void> {
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
    public static GetSessionAsync(Key: string): Promise<string> {
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
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }
    public SetSessionAsync(Key: string, Value: string): Promise<void> {
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