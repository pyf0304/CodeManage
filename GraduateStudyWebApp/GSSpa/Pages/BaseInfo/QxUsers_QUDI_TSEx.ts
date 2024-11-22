/*-- -- -- -- -- -- -- -- -- -- --
类名:QxUsers_QUDI_TSEx
表名:QxUsers(01120258)
生成代码版本:2019.10.08.1
生成日期:2019/10/14 15:52:11
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:基本信息维护
模块英文名:BaseInfo
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { QxUsers_GetRecCountByCondAsync } from "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { QxUsers_QUDI_TS } from "./QxUsers_QUDI_TS.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* QxUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class QxUsers_QUDI_TSEx extends QxUsers_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortQxUsersBy: string = "userId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
  */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();

            if (strUserId != "") {
                //1、为下拉框设置数据源,绑定列表数据
              


                //管理员 判断角色 
                if (strRoleId == "00620001") {

                    $("#btnDelRecord").show();
                    $("#tab4Bind tr").find("td:eq(19)").show();
                }
                else {
                    //学生00620003 教师 
                    $("#btnDelRecord").hide();
                    $("#tab4Bind tr").find("td:eq(19)").hide();
                }
                $("#hidUserId").val(strUserId);
                //1、为下拉框设置数据源,绑定列表数据
                //const ddl_DepartmentId = await this.BindDdl_DepartmentId("ddlDepartmentId");
                const ddl_id_XzCollege = await this.BindDdl_id_XzCollege("ddlid_XzCollege");
                const ddl_id_GradeBase = await this.BindDdl_id_GradeBase("ddlid_GradeBase");
                const ddl_IdentityID = await this.BindDdl_IdentityID("ddlIdentityID");
                this.hidSortQxUsersBy = "userId Asc";
                var strWhereCond = this.CombineQxUsersCondition();
                const responseText = await QxUsers_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_QxUsers();

            }
            else {
                window.top.location.href = "../Web/Login";
            }

           
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

}