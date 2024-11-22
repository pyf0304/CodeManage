/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiXzMajorDirectionCRUD_TSEx
表名:XzMajorDirection(01120552)
生成代码版本:2019.12.06.1
生成日期:2019/12/26 15:53:43
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
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
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo_Share/clsvXzMajorDirectionEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsvXzMajorDirectionWApi.js", "../PagesBase/BaseInfo_Share/XzMajorDirectionCRUD.js", "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../TS/FunClass_Share/clsPubVar4Web.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorDirectionCRUDEx = void 0;
    const clsvXzMajorDirectionEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsvXzMajorDirectionEN.js");
    const clsvXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsvXzMajorDirectionWApi.js");
    const XzMajorDirectionCRUD_js_1 = require("../PagesBase/BaseInfo_Share/XzMajorDirectionCRUD.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsPubVar4Web_js_1 = require("../TS/FunClass_Share/clsPubVar4Web.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* WApiXzMajorDirectionCRUD_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class XzMajorDirectionCRUDEx extends XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD {
        //public static divName4List: string = "divDataLst";
        //public static mstrSortvXzMajorDirectionBy: string = "majorDirectionId";
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
            const strThisFuncName = this.Page_Load.name;
            // 在此处放置用户代码以初始化页面
            try {
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                if (strUserId != "") {
                    //加载所需缓存
                    //加载页面所需数据源到缓存
                    const arrXzMajor_Cache = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjLstAsync)("1=1");
                    const arrvPaper_Cache = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetObjLstAsync)("1=1");
                    //管理员 判断角色 
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                    }
                    else {
                        //学生00620003 教师 
                        $("#btnDelRecord").hide();
                    }
                    $("#hidUserId").val(strUserId);
                    //1、为下拉框设置数据源,绑定列表数据
                    //const ddl_id_XzMajor = await this.BindDdl_id_XzMajor_Catche("ddlid_XzMajor", new clsXzMajorEN);
                    //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor_Catche("ddlid_XzMajor_q", new clsXzMajorEN);
                    const ddl_id_XzMajor = await this.BindDdl_id_XzMajor("ddlid_XzMajor");
                    const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor("ddlid_XzMajor_q");
                    XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD.sortXzMajorDirectionBy = "updDate Desc";
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    // var strWhereCond =await  this.CombinevXzMajorDirectionCondition();
                    var objvXzMajorDirection_Cond = await this.CombinevXzMajorDirectionConditionobj();
                    this.recCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCond_Cache)(objvXzMajorDirection_Cond); //.then((jsonData) => {
                    //    this.recCount = jsonData;
                    //});
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vXzMajorDirection();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.(in ${this.constructor.name}.${strThisFuncName})`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        BindDdl_id_XzMajor(ddlid_XzMajor, strWhereCond = "1 =1") {
            const strThisFuncName = this.BindDdl_id_XzMajor.name;
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlid_XzMajor);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzMajorWApi_js_1.XzMajor_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrXzMajorObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
                        console.log("完成BindDdl_id_XzMajor!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    alert(strMsg);
                }
            });
        }
        async btnQuery_Click() {
            var strWhereCond = await this.CombineXzMajorDirectionCondition();
            try {
                const gvResult = await this.BindGv_vXzMajorDirection();
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vXzMajorDirection() {
            const strThisFuncName = this.BindGv_vXzMajorDirection.name;
            var strListDiv = this.divName4DataList;
            // var strWhereCond =await  this.CombinevXzMajorDirectionCondition();
            var objvXzMajorDirection_Cond = await this.CombinevXzMajorDirectionConditionobj();
            //var objvXzMajorDirection_Sim = vXzMajorDirection_GetSimObjFromObj(objvXzMajorDirection_Cond);
            //console.log(objvXzMajorDirection_Sim);
            var strWhereCond = JSON.stringify(objvXzMajorDirection_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvXzMajorDirectionObjLst = [];
            try {
                //const responseRecCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.recCount = jsonData;
                //});
                this.recCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCond_Cache)(objvXzMajorDirection_Cond);
                console.log("完成vXzMajorDirection计数!");
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD.sortXzMajorDirectionBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrvXzMajorDirectionObjLst = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetObjLstByPager_Cache)(objPagerPara);
                console.log("完成vXzMajorDirection对象列表!");
                //const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrvXzMajorDirectionObjLst = <Array<clsvXzMajorDirectionEN>>jsonData;
                //});
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.(in ${this.constructor.name}.${strThisFuncName})`;
                alert(strMsg);
            }
            //if (arrvXzMajorDirectionObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vXzMajorDirection(strListDiv, arrvXzMajorDirectionObjLst);
                console.log("完成BindGv_vXzMajorDirection!");
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        CombinevXzMajorDirectionConditionobj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvXzMajorDirectionCond = new clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                    strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                    objvXzMajorDirectionCond.SetCondFldValue(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor, this.id_XzMajor_q, "=");
                }
                if (this.majorDirectionName_q != "") {
                    strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName} like '% ${this.majorDirectionName_q}%'`;
                    objvXzMajorDirectionCond.SetCondFldValue(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName, this.majorDirectionName_q, "=");
                }
                //if (this.MajorDirectionENName_q != "") {
                //    strWhereCond += ` And ${clsvXzMajorDirectionEN.con_MajorDirectionENName} like '% ${this.MajorDirectionENName_q}%'`;
                //}
                //if (this.IsVisible_q == true) {
                //    strWhereCond += ` And ${clsvXzMajorDirectionEN.con_IsVisible} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsvXzMajorDirectionEN.con_IsVisible} = '0'`;
                //}
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    //判断角色 
                    //管理员
                    if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620001") {
                        $("#btnDelRecord").show();
                    }
                    //else if (objvUserRoleRelation.roleId == "00620002") {
                    //    //教师
                    //    $("#btnDelRecord").hide();
                    //    //可以查看所有；
                    //}
                    else {
                        //学生；
                        $("#btnDelRecord").hide();
                        //学生00620003
                        //只能查看自己的数据
                        strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser} = '${$("#hidUserId").val()}'`;
                        objvXzMajorDirectionCond.SetCondFldValue(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser, $("#hidUserId").val(), "=");
                    }
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineXzMajorDirectionCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvXzMajorDirectionCond;
        }
        /* 显示vXzMajorDirection对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrXzMajorDirectionObjLst">需要绑定的对象列表</param>
     */
        async BindTab_vXzMajorDirection(divContainer, arrvXzMajorDirectionObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionId",
                    colHeader: "研究方向Id",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业名称",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionName",
                    colHeader: "研究方向名",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionENName",
                    colHeader: "研究方向英文名",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "修改人",
                    text: "", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            await (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvXzMajorDirectionObjLst, arrDataColumn, "majorDirectionId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }
    exports.XzMajorDirectionCRUDEx = XzMajorDirectionCRUDEx;
});
