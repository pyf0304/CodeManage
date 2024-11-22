//import * as $ from "jquery";
//import * as QQ from "q";
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/L0_Entity/BaseInfo/clsXzMajorEN.js", "../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js", "../GraduateEduPaper/Paper_QUDI_TS.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js", "../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/PubFun/clsPager.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperMajor = exports.PaperMajorDirecition = void 0;
    const clsvXzMajorDirectionEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js");
    const clsvPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzMajorEN.js");
    const clsMajorDirectionPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js");
    const Paper_QUDI_TS_js_1 = require("../GraduateEduPaper/Paper_QUDI_TS.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsvXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsMajorDirectionPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js");
    const clsvPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js");
    const clsvMajorDirectionPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js");
    /* Paper_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PaperMajorDirecition extends Paper_QUDI_TS_js_1.Paper_QUDI_TS {
        constructor() {
            super(...arguments);
            //public static mstrSortvPaperBy: string = "paperId";
            this.objPager = new clsPager_js_1.clsPager();
            //专业方向
            this.mstrListDivMajorDirection = "divMajorDirectionDataLst";
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 20;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //查询文献类型绑定；
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    // const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                    var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
                    const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
                    //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                    const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
                    //绑定 专业下拉框
                    const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor("ddlid_XzMajor_q");
                    this.hidSortvPaperBy = "paperTitle Asc";
                    this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";
                    var strWhereCond = this.CombinevPaperCondition();
                    const responseText = await (0, clsvPaperWApi_js_1.vPaper_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                        this.RecCount = jsonData;
                    });
                    //2、显示无条件的表内容在GridView中
                    //const gvResult = await this.BindGv_vPaper();
                    var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                    $("#hidUserId").val(strUserId);
                    //判断角色
                    //管理员
                    if (strRoleId == "00620001") {
                    }
                    else if (strRoleId == "00620002") {
                    }
                    else {
                        //如果是学生则 不可以选择用户下拉框
                        //$("#ddlUserId_q").disabled = false;
                        $("#ddlUserId_q").attr("disabled", "disabled");
                    }
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    const gvResult = await this.BindGv_vPaperLoad();
                    $("#divLoading").hide();
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
        /// <summary>
        /// 为下拉框获取数据,从表:[XzMajor]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_id_XzMajor(ddlid_XzMajor, strWhereCond = "1 =1") {
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
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
                        console.log("完成BindDdl_id_XzMajor!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "1=1") {
        //    //var strWhereCond = " 1 =1 ";
        //    var objDdl = document.getElementById(ddlUserId);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = vPaperEx_GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
        //                var arrUserObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
        //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperEN.con_UpdUser, clsvPaperEN.con_UserName, "编辑用户");
        //                console.log("完成BindDdl_UserId!");
        //                resolve(jsonData);
        //            });
        //        }
        //        catch (e) {
        //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //    });
        //}
        /// <summary>
        /// 为下拉框获取数据,从表:[Paper]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_LiteratureTypeId(ddlLiteratureTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrPaperObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "");
                        console.log("完成BindDdl_LiteratureTypeId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 根据条件获取相应论文数据
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vPaperLoad() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevPaperCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperObjLst = [];
            try {
                const responseRecCount = await (0, clsvPaperWApi_js_1.vPaper_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperObjLst = jsonData;
                    //组合新的数据
                    this.GetNewArrayList(arrvPaperObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                //this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
                console.log("完成BindGv_vPaper!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.PaperTitle_q != "") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                }
                if (this.UpdDate_q != "") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
                }
                if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
                }
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    //判断角色
                    //管理员
                    if (strRoleId == "00620001") {
                        //$("#btnDelRecord").show();
                        //$("#btnAudit").show();
                    }
                    else if (strRoleId == "00620002") {
                        //$("#btnDelRecord").hide();
                        //$("#btnAudit").show();
                        //可以查看所属教学班下面的学生数据；
                        //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                        strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                    }
                    else {
                        //$("#btnDelRecord").hide();
                        //$("#btnAudit").hide();
                        //学生00620003
                        //只能查看自己的数据；或公开的数据；
                        strWhereCond += ` And updUser = '${strUserId}'`;
                    }
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 函数功能:在数据 列表中跳转到某一页
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
        <param name = "intPageIndex">页序号</param>
      */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vPaperLoad();
        }
        /* 函数功能:从界面列表中根据某一个字段排序
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
        <param name = "strSortByFld">排序的字段</param>
      */
        async SortBy(strSortByFld) {
            if (this.hidSortvPaperBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvPaperBy.indexOf("Asc") >= 0) {
                    this.hidSortvPaperBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvPaperBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvPaperBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_vPaperLoad();
        }
        //查看专业关系；
        async btnMajorDirection_Click() {
            const responseObjList = await this.BindGv_vXzMajorDirection();
        }
        /* 查询专业方向条件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async btnQueryMajorDirection_Click() {
            var strWhereCond = this.CombinevXzMajorDirectionCondition();
            try {
                const responseRecCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvXzMajorDirectionBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvXzMajorDirectionObjLst = jsonData;
                    this.BindTab_vXzMajorDirection(this.mstrListDivMajorDirection, arrvXzMajorDirectionObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取记录列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vXzMajorDirection() {
            var strListDiv = this.mstrListDivMajorDirection;
            var strWhereCond = this.CombinevXzMajorDirectionCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvXzMajorDirectionObjLst = [];
            try {
                const responseRecCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvXzMajorDirectionBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvXzMajorDirectionObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        CombinevXzMajorDirectionCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strPaperId = $("#hidPaperId").val(); //论文
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                    strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                }
                if (this.MajorDirectionName_q != "") {
                    strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName} like '% ${this.MajorDirectionName_q}%'`;
                }
                strWhereCond += ` And  majorDirectionId not in (select majorDirectionId from MajorDirectionPaperRela where  paperId = '${strPaperId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineXzMajorDirectionCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 显示vXzMajorDirection对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrXzMajorDirectionObjLst">需要绑定的对象列表</param>
    */
        BindTab_vXzMajorDirection(divContainer, arrvXzMajorDirectionObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorDirectionId",
                    ColHeader: "研究方向Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorName",
                    ColHeader: "专业名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorDirectionName",
                    ColHeader: "研究方向名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "MajorDirectionENName",
                    ColHeader: "研究方向英文名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvXzMajorDirectionObjLst, arrDataColumn, "majorDirectionId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //用来选择专业记录方法；
        btnOkInTab_Click(strKeyId) {
            $('#hidMajorDirectionId').val(strKeyId); //专业方向
            this.AddNewRecordSaveMajorDirection();
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSaveMajorDirection() {
            var strMajorDirectionId = $('#hidMajorDirectionId').val(); //专业方向
            var strPaperId = $("#hidPaperId").val(); //论文
            var strUserId = $("#hidUserId").val();
            var objMajorDirectionPaperRelaEN = new clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN();
            this.PutDataToMajorDirectionPaperRelaClass(objMajorDirectionPaperRelaEN);
            try {
                //同一论文不能重复添加同一个专业方向；
                var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And majorDirectionId = '" + strMajorDirectionId + "'";
                const responseText = await (0, clsMajorDirectionPaperRelaWApi_js_1.MajorDirectionPaperRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一论文不能重复添加同一个专业方向！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsMajorDirectionPaperRelaWApi_js_1.MajorDirectionPaperRela_AddNewRecordAsync)(objMajorDirectionPaperRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    HideDialogOne();
                    //window.location.href = "../GraduateEduEx/Paper_QUDI_TS?paperTypeId=01";
                    window.location.href = "../GraduateEduEx/PaperAddXzmajorRela?paperId=" + strPaperId;
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjMajorDirectionPaperRelaEN">数据传输的目的类对象</param>
      */
        PutDataToMajorDirectionPaperRelaClass(pobjMajorDirectionPaperRelaEN) {
            var strMajorDirectionId = $("#hidMajorDirectionId").val();
            var strViewpointId = $("#hidPaperId").val();
            var strUserId = $("#hidUserId").val();
            pobjMajorDirectionPaperRelaEN.majorDirectionId = strMajorDirectionId; // 研究方向Id
            pobjMajorDirectionPaperRelaEN.paperId = strViewpointId; // 论文Id
            pobjMajorDirectionPaperRelaEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjMajorDirectionPaperRelaEN.updUser = $("#hidUserId").val(); // 修改人
            pobjMajorDirectionPaperRelaEN.memo = this.memo; // 备注
        }
        /*
     * 获取年月日
     */
        getNowDate() {
            const date = new Date();
            let month = date.getMonth() + 1;
            let strDate = date.getDate();
            if (month <= 9) {
                month = "0" + month;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
        }
        /*
       * 专业流水号
      */
        get id_XzMajor_q() {
            return $("#ddlid_XzMajor_q").val();
        }
        /*
        * 研究方向名
       */
        get MajorDirectionName_q() {
            return $("#txtMajorDirectionName_q").val();
        }
        /* 函数功能:在数据 列表中跳转到某一页
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
        <param name = "intPageIndex">页序号</param>
      */
        IndexPageOne(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vXzMajorDirection();
        }
        /*
       * 设置排序字段-相当使用ViewState功能
      */
        set hidSortvXzMajorDirectionBy(value) {
            $("#hidSortvXzMajorDirectionBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvXzMajorDirectionBy() {
            return $("#hidSortvXzMajorDirectionBy").val();
        }
        //组合获取新的数据源，通过论文 和专业方向；
        async GetNewArrayList(arrvPaperObjLst) {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevPaperCondition();
            var strWhereCond1 = this.CombinevXzMajorDirectionCondition();
            // var arrvPaperObjLst: Array<clsvPaperEN> = [];
            var arrvMajorDirectionPaperRelaObjLst = [];
            //新对象列表
            var arrPaperMajorObjList = [];
            try {
                //const responseText = vPaper_GetObjLstAsync(strWhereCond).then((jsonData) => {
                //    arrvPaperObjLst = <Array<clsvPaperEN>>jsonData;
                //});
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
                const responseText1 = (0, clsvMajorDirectionPaperRelaWApi_js_1.vMajorDirectionPaperRela_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                    arrvMajorDirectionPaperRelaObjLst = jsonData;
                    //根据数据源组合新对象
                    //1.循环论文
                    var objPaperMajor;
                    for (var i = 0; i < arrvPaperObjLst.length; i++) {
                        //new
                        objPaperMajor = new PaperMajor();
                        //得到相关数据；
                        objPaperMajor.paperId = arrvPaperObjLst[i].paperId;
                        objPaperMajor.paperTitle = arrvPaperObjLst[i].paperTitle;
                        objPaperMajor.updDate = arrvPaperObjLst[i].updDate;
                        objPaperMajor.updUser = arrvPaperObjLst[i].updUser;
                        var objUser = arrUsers.find(x => x.userId == arrvPaperObjLst[i].updUser);
                        if (objUser != null) {
                            objPaperMajor.userName = objUser.userName;
                        }
                        //2得到专业方向；
                        //3比对得到剩下的数据
                        arrvMajorDirectionPaperRelaObjLst = arrvMajorDirectionPaperRelaObjLst.filter(x => x.paperId == arrvPaperObjLst[i].paperId);
                        //4循环的插入数据表
                        var k = 0;
                        for (var j = 0; j < arrvMajorDirectionPaperRelaObjLst.length; j++) {
                            k++;
                            //5专业方向
                            objPaperMajor.MajorDecription += k + "." + arrvMajorDirectionPaperRelaObjLst[j].majorDirectionName + "</br>";
                        }
                        //6存入对象列表；
                        arrPaperMajorObjList.push(objPaperMajor);
                    }
                    try {
                        this.BindTab_PaperMajor(strListDiv, arrPaperMajorObjList);
                        console.log("完成BindGv_PaperMajor!");
                    }
                    catch (e) {
                        console.error('catch(e)=');
                        console.error(e);
                        var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                        alert(strMsg);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vPaper对象的所有属性值
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        <param name = "divContainer">显示容器</param>
        <param name = "arrPaperObjLst">需要绑定的对象列表</param>
      */
        BindTab_PaperMajor(divContainer, arrvPaperObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "MajorDecription",
                    ColHeader: "专业方向",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "用户",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvPaperObjLst, arrDataColumn, "paperId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }
    exports.PaperMajorDirecition = PaperMajorDirecition;
    PaperMajorDirecition.mstrListDiv = "divDataLst";
    //新建类存放数据；
    class PaperMajor {
        constructor() {
            this.mstrPaperId = ""; //论文Id
            this.mstrPaperTitle = ""; //论文标题
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改用户Id
            this.mstrMajorDecription = ""; //专业方向；
            this.mstrUserName = ""; //用户名
        }
        ////论文id
        //public paperId: string,
        ////论文标题
        //public paperTitle: string,
        ////专业方向名
        //public MajorDecription: string,
        ////时间
        //public updDate: string,
        ////人
        //public updUser: string
        /// <summary>
        /// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        get paperId() {
            return this.mstrPaperId;
        }
        ;
        /// <summary>
        /// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        set paperId(value) {
            this.mstrPaperId = value;
        }
        ;
        /// <summary>
        /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        get paperTitle() {
            return this.mstrPaperTitle;
        }
        ;
        /// <summary>
        /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        set paperTitle(value) {
            this.mstrPaperTitle = value;
        }
        ;
        /// <summary>
        /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        get updDate() {
            return this.mstrUpdDate;
        }
        ;
        /// <summary>
        /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        set updDate(value) {
            this.mstrUpdDate = value;
        }
        ;
        /// <summary>
        /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        get updUser() {
            return this.mstrUpdUser;
        }
        ;
        /// <summary>
        /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        set updUser(value) {
            this.mstrUpdUser = value;
        }
        ;
        /// <summary>
        /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        get userName() {
            return this.mstrUserName;
        }
        ;
        /// <summary>
        /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        set userName(value) {
            this.mstrUserName = value;
        }
        ;
        /// <summary>
        /// 专业方向
        get MajorDecription() {
            return this.mstrMajorDecription;
        }
        ;
        /// <summary>
        /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        /// </summary>
        set MajorDecription(value) {
            this.mstrMajorDecription = value;
        }
        ;
    }
    exports.PaperMajor = PaperMajor;
});
