/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiUsers_QUDI_TSEx
表名:Users(01120034)
生成代码版本:2020.03.03.1
生成日期:2020/03/04 13:39:36
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsXzClgEN } from "../TS/L0_Entity/BaseInfo/clsXzClgEN.js";
import { clsXzMajorEN } from "../TS/L0_Entity/BaseInfo/clsXzMajorEN.js";
import { clsXzGradeBaseEN } from "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js";
import { clsUserIdentityEN } from "../TS/L0_Entity/UserManage/clsUserIdentityEN.js";
import { clsvUsersEN } from "../TS/L0_Entity/UserManage/clsvUsersEN.js";
import { XzClg_BindDdl_id_XzCollegeInDiv_Cache } from "../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js";
import { XzMajor_BindDdl_id_XzMajor_Cache } from "../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js";
import { XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache } from "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js";
import { UserIdentity_BindDdl_IdentityIDInDiv_Cache } from "../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js";
import { vUsers_GetObjLstByPagerAsync, vUsers_GetRecCountByCondAsync } from "../TS/L3_ForWApi/UserManage/clsvUsersWApi.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { Users_QUDI } from "./Users_QUDI.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Users_QUDIEx extends Users_QUDI {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvUsersBy: string = "userId";
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

            //1、为下拉框设置数据源,绑定列表数据
            var objXzGradeBase_Cond: clsXzGradeBaseEN = new clsXzGradeBaseEN();
            var objXzClg_Cond: clsXzClgEN = new clsXzClgEN();
            var objXzMajor_Cond: clsXzMajorEN = new clsXzMajorEN();
            var objUserIdentity_Cond: clsUserIdentityEN = new clsUserIdentityEN();

            //1、为下拉框设置数据源,绑定列表数据
            const ddl_id_GradeBase = XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache(this.divName4List, "ddlid_GradeBase");
            const ddl_id_XzCollege = XzClg_BindDdl_id_XzCollegeInDiv_Cache(this.divName4List, "ddlid_XzCollege");
            const ddl_id_XzMajor = XzMajor_BindDdl_id_XzMajor_Cache(this.divName4List, "ddlid_XzMajor");
            const ddl_IdentityID = UserIdentity_BindDdl_IdentityIDInDiv_Cache(this.divName4List, "ddlIdentityID");

            const ddl_id_XzCollege_q = XzClg_BindDdl_id_XzCollegeInDiv_Cache(this.divName4List, "ddlid_XzCollege_q");
            const ddl_id_XzMajor_q = XzMajor_BindDdl_id_XzMajor_Cache(this.divName4List, "ddlid_XzMajor_q");

            this.hidSortvUsersBy = "userId Asc";
            var strWhereCond = this.CombinevUsersCondition();
            //const responseText = await vUsers_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            //    this.RecCount = jsonData;
            //});
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vUsers();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevUsersCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and isGSuser=1";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.id_XzCollege_q != null && this.id_XzCollege_q != "0") {
                strWhereCond += ` And ${clsvUsersEN.con_id_XzCollege} = '${this.id_XzCollege_q}'`;
            }
            if (this.id_XzMajor_q != null && this.id_XzMajor_q != "0") {
                strWhereCond += ` And ${clsvUsersEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
            }
            if (this.UserName_q != "") {
                strWhereCond += ` And ${clsvUsersEN.con_UserName} like '% ${this.UserName_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineUsersCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vUsers() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevUsersCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvUsersObjLst: Array<clsvUsersEN> = [];
        try {
            const responseRecCount = await vUsers_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvUsersBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vUsers_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvUsersObjLst = <Array<clsvUsersEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvUsersObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vUsers(strListDiv, arrvUsersObjLst);
            console.log("完成BindGv_vUsers!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }



}