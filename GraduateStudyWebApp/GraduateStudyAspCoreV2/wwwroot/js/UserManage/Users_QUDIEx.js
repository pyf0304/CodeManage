(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/UserManage_Share/UsersCRUD.js", "../TS/L0_Entity/UserManage_Share/clsvUsersEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersWApi.js", "../TS/L3_ForWApiEx/BaseInfo_Share/clsXzClgExWApi.js", "../TS/L3_ForWApiEx/BaseInfo_Share/clsXzMajorExWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Users_QUDIEx = void 0;
    const UsersCRUD_js_1 = require("../PagesBase/UserManage_Share/UsersCRUD.js");
    const clsvUsersEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersEN.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsvUsersWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersWApi.js");
    const clsXzClgExWApi_js_1 = require("../TS/L3_ForWApiEx/BaseInfo_Share/clsXzClgExWApi.js");
    const clsXzMajorExWApi_js_1 = require("../TS/L3_ForWApiEx/BaseInfo_Share/clsXzMajorExWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Users_QUDIEx extends UsersCRUD_js_1.UsersCRUD {
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
                this.SetEventFunc();
                //1、为下拉框设置数据源,绑定列表数据
                //1、为下拉框设置数据源,绑定列表数据
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                UsersCRUD_js_1.UsersCRUD.sortvUsersBy = "userId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                await this.BindGv_vUsers();
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
        async CombinevUsersCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and isGSuser=1";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if ((0, clsString_js_1.IsNullOrEmpty)(this.id_XzCollege_q) == false && this.id_XzCollege_q != "0") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege} = '${this.id_XzCollege_q}'`;
                }
                if ((0, clsString_js_1.IsNullOrEmpty)(this.id_XzMajor_q) == false && this.id_XzMajor_q != "0") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                }
                if ((0, clsString_js_1.IsNullOrEmpty)(this.userName_q) == false) {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_UserName} like '% ${this.userName_q}%'`;
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
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevUsersCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvUsersObjLst = [];
            try {
                this.recCount = await (0, clsvUsersWApi_js_1.vUsers_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: UsersCRUD_js_1.UsersCRUD.sortvUsersBy,
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
        /** 函数功能:系统生成的Change事件函数
        * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript+<>c__DisplayClass12_0:<Gen_WApi_Ts_GeneEventFuncEx>b__1)
        **/
        async ddlid_XzCollege_q_SelectedIndexChanged() {
            //alert('请在扩展层:UsersCRUDExEx中重写该函数！');
            if ((0, clsString_js_1.IsNullOrEmpty)(this.id_XzCollege_q) == true)
                return;
            this.SetDdl_id_XzMajorById_CollegeInDiv(this.id_XzCollege_q);
        }
        async SetDdl_id_XzMajorById_CollegeInDiv(strid_XzCollege) {
            await (0, clsXzMajorWApi_js_1.XzMajor_BindDdl_id_XzMajorByid_XzCollegeInDiv_Cache)(this.divName4Query, "ddlid_XzMajor_q", strid_XzCollege); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_XzCollege]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_id_XzCollegeInDiv() {
            await (0, clsXzClgExWApi_js_1.XzClgEx_BindDdl_id_XzCollegeForvUsersSimInDiv_CacheEx)(this.divName4Query, "ddlid_XzCollege_q", clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_XzMajor]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_id_XzMajorInDiv() {
            await (0, clsXzMajorExWApi_js_1.XzMajorEx_BindDdl_id_XzMajorForvUsersSimInDiv_CacheEx)(this.divName4Query, "ddlid_XzMajor_q", clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId); //
        }
    }
    exports.Users_QUDIEx = Users_QUDIEx;
});
