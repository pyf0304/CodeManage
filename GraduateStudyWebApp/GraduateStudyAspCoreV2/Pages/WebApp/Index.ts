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
//import { clsvUserRoleRelationEN } from "../TS/L0_Entity/UserManage/clsvUserRoleRelationEN.js";
//import { clsvUserRoleRelationWApi } from "../TS/L3_ForWApi/UserManage/clsvUserRoleRelationWApi.js";
import { stuUserLoginInfo } from "../TS/FunClass/stuUserLoginInfo.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
//declare var strcourseID_Hid;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Index {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortUsersBy: string = "userId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }



    public static async Page_Load() {
        // 在此处放置用户代码以初始化页面

        var strUserId_Hid = clsPublocalStorage.userId;
       // var strcourseID_Hid = $("#hidCourseID").val();
        


        try {
            if (strUserId_Hid != "") {

                ////把课程ID存入session
                //var strCourseId: string = $("#hidCourseID").val();
                //const bolIsSuccess = this.SetSessionAsync("courseId", strCourseId);

                //var strWhereCond: string = " userId='" + strUserId_Hid + "'";
                ////var strWhereCond: string = " userId='" + strUserId_Hid + "' and courseId='" + strcourseID_Hid + "'";
                //var arrvUserRoleRelationObjLst: Array<clsvQxUserRoleRelationEN> = [];
                //const responseObjLst = await vQxUserRoleRelation_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                //    var objvUserRoleRelation: clsvQxUserRoleRelationEN = <clsvQxUserRoleRelationEN>jsonData;
                //    //              console.log(objUserLoginInfo);
                //   // $('#IndexTitle').html(objvUserRoleRelation.PrjName);

                //    var strJson = JSON.stringify(objvUserRoleRelation);
                //    console.log(strJson);
                //    const bolIsSuccess = this.SetSessionAsync("objvUserRoleRelation", strJson);


                //});
            } else {
                //var strUserInfo_Hid = $("#hidUserInfo").val();
                //if (strUserInfo_Hid != "") {
                //    var objvUserRoleRelation: clsvQxUserRoleRelationEN;
                //    objvUserRoleRelation = stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);

                //  //  $('#IndexTitle').html('课程管理(' + objvUserRoleRelation.PrjName + ')');
                //}
                //else {
                window.location.href = "/GraduateStudyWebApp/WebApp/Login";
               // }
            }


        }

        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
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
}