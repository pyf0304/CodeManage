(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo/clsXzClgEN.js", "../TS/L0_Entity/BaseInfo/clsXzMajorEN.js", "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js", "../TS/L0_Entity/UserManage/clsUserIdentityEN.js", "../TS/L0_Entity/UserManage/clsvUsersEN.js", "../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js", "../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js", "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersWApi.js", "./Users_QUDI.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Users_QUDIEx = void 0;
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
    const clsXzClgEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzClgEN.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzMajorEN.js");
    const clsXzGradeBaseEN_js_1 = require("../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js");
    const clsUserIdentityEN_js_1 = require("../TS/L0_Entity/UserManage/clsUserIdentityEN.js");
    const clsvUsersEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersEN.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsUserIdentityWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js");
    const clsvUsersWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersWApi.js");
    const Users_QUDI_js_1 = require("./Users_QUDI.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Users_QUDIEx extends Users_QUDI_js_1.Users_QUDI {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvUsersBy: string = "userId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //1、为下拉框设置数据源,绑定列表数据
                var objXzGradeBase_Cond = new clsXzGradeBaseEN_js_1.clsXzGradeBaseEN();
                var objXzClg_Cond = new clsXzClgEN_js_1.clsXzClgEN();
                var objXzMajor_Cond = new clsXzMajorEN_js_1.clsXzMajorEN();
                var objUserIdentity_Cond = new clsUserIdentityEN_js_1.clsUserIdentityEN();
                //1、为下拉框设置数据源,绑定列表数据
                const ddl_id_GradeBase = (0, clsXzGradeBaseWApi_js_1.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache)(this.divName4List, "ddlid_GradeBase");
                const ddl_id_XzCollege = (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4List, "ddlid_XzCollege");
                const ddl_id_XzMajor = (0, clsXzMajorWApi_js_1.XzMajor_BindDdl_id_XzMajor_Cache)(this.divName4List, "ddlid_XzMajor");
                const ddl_IdentityID = (0, clsUserIdentityWApi_js_1.UserIdentity_BindDdl_IdentityIDInDiv_Cache)(this.divName4List, "ddlIdentityID");
                const ddl_id_XzCollege_q = (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4List, "ddlid_XzCollege_q");
                const ddl_id_XzMajor_q = (0, clsXzMajorWApi_js_1.XzMajor_BindDdl_id_XzMajor_Cache)(this.divName4List, "ddlid_XzMajor_q");
                this.hidSortvUsersBy = "userId Asc";
                var strWhereCond = this.CombinevUsersCondition();
                //const responseText = await vUsers_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vUsers();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevUsersCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and isGSuser=1";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_XzCollege_q != null && this.id_XzCollege_q != "0") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege} = '${this.id_XzCollege_q}'`;
                }
                if (this.id_XzMajor_q != null && this.id_XzMajor_q != "0") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                }
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_UserName} like '% ${this.UserName_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineUsersCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vUsers() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevUsersCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvUsersObjLst = [];
            try {
                const responseRecCount = await (0, clsvUsersWApi_js_1.vUsers_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvUsersBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvUsersWApi_js_1.vUsers_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvUsersObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvUsersObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
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
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.Users_QUDIEx = Users_QUDIEx;
});
