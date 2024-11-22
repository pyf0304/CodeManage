//import { WApiUsers_QUDI_TS } from "./WApiUsers_QUDI_TS.js";
//import { clsUsersEN } from "../TS/L0_Entity/UserManage/clsUsersEN.js";
//import { clsUsersWApi } from "../TS/L3_ForWApi/UserManage/clsUsersWApi.js";
//import { clsvUserRoleRelationEN } from "../TS/L0_Entity/UserManage/clsvUserRoleRelationEN.js";
//import { clsvUserRoleRelationWApi } from "../TS/L3_ForWApi/UserManage/clsvUserRoleRelationWApi.js";
import { stuUserLoginInfo } from "../TS/FunClass/stuUserLoginInfo.js";
import { clswxUserInfoExWApi } from "../TS/L3_ForWApiEx/UserManage/clswxUserInfoExWApi.js";
import { clsQxUsersEN } from "../TS/L0_Entity/BaseInfo/clsQxUsersEN.js";
import { QxUsers_GetFirstObjAsync, QxUsers_UpdateRecordAsync } from "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js";
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class wxUserInfo {

    public async Page_Load() {
        var strcode_Hid = $("#hidcode").val();

        try {
            if (strcode_Hid != "") {
                const responseObjLst = await clswxUserInfoExWApi.GetwxUserInfoAsync(strcode_Hid).then((jsonData) => {
                    if (jsonData != null) {
                        var strJson = eval('[' + jsonData + ']');

                        this.openId = strJson[0].openid;
                        this.nickName = strJson[0].nickname;
                        //$('#imgheadimgUrl').str(strJson[0].headimgurl);
                        $("#imgheadimgUrl").attr("src", strJson[0].headimgurl);
                        $('#hidheadimgUrl').val(strJson[0].headimgurl);

                        //for (var i = 0; i < strJson.length; i++) {}

                    } else {
                        window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                    }
                });

                if (this.openId != "") {
                    var strWhereCond: string = "openId = '" + this.openId + "'";

                    const responseObjLst2 = await QxUsers_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                        var objUsers: clsQxUsersEN = <clsQxUsersEN>jsonData;
                        if (objUsers != null) {
                            const bolIsSuccess = this.SetSessionAsync("userId", objUsers.userId);
                            //window.location.href = "/GraduateStudyWebApp/CourseLearning/cc_CourseList";
                            window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                        }
                        else {
                            window.location.href = "#pagetwo";
                        }

                    });

                }
                else {
                    var strMsg: string = `解析json数据不成功`;
                    alert(strMsg);
                }

            } else {
                window.location.href = "/GraduateStudyWebApp/WebApp/Login";
            }
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }


        //this.openId = "ofgZ8wfivfnjdEfvmRZ5TEQJvqrQ";
        //this.nickName = "没有昵称";
        ////$('#imgheadimgUrl').str(strJson[0].headimgurl);
        //$("#imgheadimgUrl").attr("src", "http:\/\/thirdwx.qlogo.cn\/mmopen\/vi_32\/DYAIOgq83eqp5d9DJEhOxU1Hdt21C8Mdomq3dYBxWicFANV3uibWlADibYuTSWQZ6p6icjQibjh6Ao7yEvNAe967VicA\/132");
        //$('#hidheadimgUrl').val("http:\/\/thirdwx.qlogo.cn\/mmopen\/vi_32\/DYAIOgq83eqp5d9DJEhOxU1Hdt21C8Mdomq3dYBxWicFANV3uibWlADibYuTSWQZ6p6icjQibjh6Ao7yEvNAe967VicA\/132");
        //window.location.href = "#pagetwo";
    }



    public async btnBind_Click() {
        var strWhereCond = "";
        try {
            if (this.userId != "") {
                strWhereCond += ` ${clsQxUsersEN.con_UserId} = '${this.userId}'`;
                if (this.password != "") {
                    strWhereCond += ` And ${clsQxUsersEN.con_Password} = '${this.password}'`;
                    var objUsers: clsQxUsersEN = new clsQxUsersEN();
                    const responseRecCount = await QxUsers_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                        objUsers = <clsQxUsersEN>jsonData;
                    });

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
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public UpdateRecordSave(): Promise<boolean> {
        //$('#hidDivName').val("divUpdateRecordSave");
        var objUsersEN: clsQxUsersEN = new clsQxUsersEN();

        objUsersEN.userId = this.userId;
        objUsersEN.openId = this.openId;
        objUsersEN.nickName = this.nickName;
        objUsersEN.headimgUrl = this.headimgUrl;
        objUsersEN.memo = "微信绑定" + this.openId;

        objUsersEN.sf_UpdFldSetStr = objUsersEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objUsersEN.userId == "" || objUsersEN.userId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = QxUsers_UpdateRecordAsync(objUsersEN).then((jsonData2) => {
                    var returnBool: boolean = jsonData2;
                    if (returnBool == true) {
                        var strInfo: string = `微信绑定成功!`;
                        //显示信息框
                        alert(strInfo);
                        //window.location.href = "/GraduateStudyWebApp/CourseLearning/cc_CourseList";
                        window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                    }
                    else {
                        var strInfo: string = `绑定不成功!`;
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
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);
            }
        });
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
  * 微信id
 */
    public set openId(value: string) {
        $("#hidOpenId").val(value);
    }
    /*
    * 微信id
   */
    public get openId(): string {
        return $("#hidOpenId").val();
    }

    /*
  * 昵称
 */
    public set nickName(value: string) {
        $("#lbNickName").html(value);
    }
    /*
    * 昵称
   */
    public get nickName(): string {
        return $("#lbNickName").html();
    }

    /*
  * 头像
 */
    public set headimgUrl(value: string) {
        $("#hidheadimgUrl").val(value);
    }
    /*
    * 头像
   */
    public get headimgUrl(): string {
        return $("#hidheadimgUrl").val();
    }
    /*
    设置Session
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
    <param name = "Key">关键字</param>
    <param name = "Value">值</param>
    */
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