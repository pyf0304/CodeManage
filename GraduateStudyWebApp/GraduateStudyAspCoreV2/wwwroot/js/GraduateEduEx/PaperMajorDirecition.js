//
//import * as QQ from "q";
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo_Share/clsvXzMajorDirectionEN.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsvXzMajorDirectionWApi.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsGeneralTab.js", "../PagesBase/GraduateEduPaper/MajorDirectionPaperRelaCRUD.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperMajor = exports.PaperMajorDirecition = void 0;
    const clsvXzMajorDirectionEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsvXzMajorDirectionEN.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsMajorDirectionPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsvXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsvXzMajorDirectionWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsMajorDirectionPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js");
    const clsvMajorDirectionPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js");
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsGeneralTab_js_1 = require("../TS/PubFun/clsGeneralTab.js");
    const MajorDirectionPaperRelaCRUD_js_1 = require("../PagesBase/GraduateEduPaper/MajorDirectionPaperRelaCRUD.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    /* PaperMajorDirecition 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PaperMajorDirecition extends MajorDirectionPaperRelaCRUD_js_1.MajorDirectionPaperRelaCRUD {
        constructor() {
            super(...arguments);
            //public static mstrSortvPaperBy: string = "paperId";
            //public objPager: clsPager = new clsPager();
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    // const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                    var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
                    const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
                    //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                    //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN);
                    //绑定 专业下拉框
                    const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor("ddlid_XzMajor_q");
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "paperTitle Asc";
                    this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";
                    var strWhereCond = await this.CombinevPaperCondition();
                    this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
                    //2、显示无条件的表内容在GridView中
                    //const gvResult = await this.BindGv_vPaper();
                    var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
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
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
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
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "");
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
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevPaperCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperExObjLst = [];
            try {
                this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
                //组合新的数据
                this.GetNewArrayList(arrPaperExObjLst);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                //this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
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
        async CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                //if (this.updDate_q != "") {
                //    strWhereCond += ` And ${clsPaperEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                //}
                //if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                //    strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                //}
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
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
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.SetCurrPageIndex(intPageIndex);
            this.BindGv_vPaperLoad();
        }
        /* 函数功能:从界面列表中根据某一个字段排序
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
        <param name = "strSortByFld">排序的字段</param>
      */
        async SortBy(strSortByFld) {
            if (PaperCRUD_js_1.PaperCRUD.sortPaperBy.indexOf(strSortByFld) >= 0) {
                if (PaperCRUD_js_1.PaperCRUD.sortPaperBy.indexOf("Asc") >= 0) {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = `${strSortByFld} Desc`;
                }
                else {
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = `${strSortByFld} Asc`;
                }
            }
            else {
                PaperCRUD_js_1.PaperCRUD.sortPaperBy = `${strSortByFld} Asc`;
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
            var strWhereCond = await this.CombinevXzMajorDirectionCondition();
            try {
                this.recCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCondAsync)(strWhereCond);
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
            var strWhereCond = await this.CombinevXzMajorDirectionCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvXzMajorDirectionObjLst = [];
            try {
                this.recCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCondAsync)(strWhereCond);
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
                if (this.majorDirectionName_q != "") {
                    strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName} like '% ${this.majorDirectionName_q}%'`;
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
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionId",
                    colHeader: "研究方向Id",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionName",
                    colHeader: "研究方向名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "MajorDirectionENName",
                    colHeader: "研究方向英文名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    colHeader: "修改人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvXzMajorDirectionObjLst, arrDataColumn, "majorDirectionId", this);
            this.objPager.recCount = this.recCount;
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
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
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
                    //window.location.href = "../GraduateEduEx/PaperCRUD?paperTypeId=01";
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
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjMajorDirectionPaperRelaEN.SetMajorDirectionId(strMajorDirectionId); // 研究方向Id
            pobjMajorDirectionPaperRelaEN.SetPaperId(strViewpointId); // 论文Id
            pobjMajorDirectionPaperRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjMajorDirectionPaperRelaEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            //pobjMajorDirectionPaperRelaEN.SetMemo(this.memo;// 备注
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
        get majorDirectionName_q() {
            return $("#txtMajorDirectionName_q").val();
        }
        /* 函数功能:在数据 列表中跳转到某一页
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
        <param name = "intPageIndex">页序号</param>
      */
        IndexPageOne(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.SetCurrPageIndex(intPageIndex);
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
        async GetNewArrayList(arrPaperExObjLst) {
            var strListDiv = this.divName4List;
            var strWhereCond = await this.CombinevPaperCondition();
            var strWhereCond1 = this.CombinevXzMajorDirectionCondition();
            // var arrPaperExObjLst: Array<clsPaperENEx> = [];
            var arrvMajorDirectionPaperRelaObjLst = [];
            //新对象列表
            var arrPaperMajorObjList = [];
            try {
                //const responseText = vPaper_GetObjLstAsync(strWhereCond).then((jsonData) => {
                //    arrPaperExObjLst = <Array<clsPaperEN>>jsonData;
                //});
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const responseText1 = (0, clsvMajorDirectionPaperRelaWApi_js_1.vMajorDirectionPaperRela_GetObjLstAsync)(strWhereCond1).then((jsonData) => {
                    arrvMajorDirectionPaperRelaObjLst = jsonData;
                    //根据数据源组合新对象
                    //1.循环论文
                    var objPaperMajor;
                    for (var i = 0; i < arrPaperExObjLst.length; i++) {
                        //new
                        objPaperMajor = new PaperMajor();
                        //得到相关数据；
                        objPaperMajor.paperId = arrPaperExObjLst[i].paperId;
                        objPaperMajor.paperTitle = arrPaperExObjLst[i].paperTitle;
                        objPaperMajor.updDate = arrPaperExObjLst[i].updDate;
                        objPaperMajor.updUser = arrPaperExObjLst[i].updUser;
                        var objUser = arrUsers.find(x => x.userId == arrPaperExObjLst[i].updUser);
                        if (objUser != null) {
                            objPaperMajor.userName = objUser.userName;
                        }
                        //2得到专业方向；
                        //3比对得到剩下的数据
                        arrvMajorDirectionPaperRelaObjLst = arrvMajorDirectionPaperRelaObjLst.filter(x => x.paperId == arrPaperExObjLst[i].paperId);
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
        async BindTab_PaperMajor(divContainer, arrPaperExObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "MajorDecription",
                    colHeader: "专业方向",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
            ];
            (0, clsCommFunc4Web_js_1.BindTab)(o, arrPaperExObjLst, arrDataColumn, "paperId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }
    exports.PaperMajorDirecition = PaperMajorDirecition;
    PaperMajorDirecition.mstrListDiv = "divDataLst";
    //新建类存放数据；
    class PaperMajor extends clsGeneralTab_js_1.clsGeneralTab {
        constructor() {
            super(...arguments);
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
