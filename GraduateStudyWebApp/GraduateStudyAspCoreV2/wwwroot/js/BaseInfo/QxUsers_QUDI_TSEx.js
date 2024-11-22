(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/BaseInfo_Share/QxUsersCRUD.js", "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QxUsers_QUDI_TSEx = void 0;
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
    //
    //import * as QQ from "q";
    const QxUsersCRUD_js_1 = require("../PagesBase/BaseInfo_Share/QxUsersCRUD.js");
    const clsQxUsersWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsUserIdentityWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* QxUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class QxUsers_QUDI_TSEx extends QxUsersCRUD_js_1.QxUsersCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortQxUsersBy: string = "userId";
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
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
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
                    //1、为下拉框设置数据源,绑定列表数据
                    //const ddl_DepartmentId = await this.BindDdl_DepartmentId("ddlDepartmentId");
                    await this.SetDdl_id_XzCollegeInDiv();
                    await this.SetDdl_id_GradeBaseInDiv();
                    await this.SetDdl_IdentityIDInDiv();
                    QxUsersCRUD_js_1.QxUsersCRUD.sortQxUsersBy = "userId Asc";
                    var strWhereCond = await this.CombineQxUsersCondition();
                    this.recCount = await (0, clsQxUsersWApi_js_1.QxUsers_GetRecCountByCondAsync)(strWhereCond);
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_QxUsers();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async SetDdl_id_XzCollegeInDiv() {
            await (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4Query, "ddlid_XzCollege"); //
        }
        async SetDdl_id_GradeBaseInDiv() {
            await (0, clsXzGradeBaseWApi_js_1.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache)(this.divName4Query, "ddlid_GradeBase"); //
        }
        async SetDdl_IdentityIDInDiv() {
            await (0, clsUserIdentityWApi_js_1.UserIdentity_BindDdl_IdentityIDInDiv_Cache)(this.divName4Query, "ddlIdentityID"); //
        }
    }
    exports.QxUsers_QUDI_TSEx = QxUsers_QUDI_TSEx;
});
