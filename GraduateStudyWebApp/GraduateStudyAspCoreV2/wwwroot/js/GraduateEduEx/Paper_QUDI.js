(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPaper/Paper_EditEx.js", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsMajorDirectionPaperRelaExWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperEduClsRelaExWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./Paper_QUDI_AllPaper.js", "./Paper_QUDI_CurrEduCls.js", "./Paper_QUDI_Direction.js", "./Paper_QUDI_Major.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_QUDI = void 0;
    const Paper_EditEx_js_1 = require("../GraduateEduPaper/Paper_EditEx.js");
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsgs_PaperTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsgs_PaperTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsMajorDirectionPaperRelaExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsMajorDirectionPaperRelaExWApi.js");
    const clsPaperEduClsRelaExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperEduClsRelaExWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const Paper_QUDI_AllPaper_js_1 = require("./Paper_QUDI_AllPaper.js");
    const Paper_QUDI_CurrEduCls_js_1 = require("./Paper_QUDI_CurrEduCls.js");
    const Paper_QUDI_Direction_js_1 = require("./Paper_QUDI_Direction.js");
    const Paper_QUDI_Major_js_1 = require("./Paper_QUDI_Major.js");
    /* Paper_QUDI 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Paper_QUDI extends PaperCRUD_js_1.PaperCRUD {
        constructor() {
            super(...arguments);
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvPaperBy: string = "paperId";
            this.mstrListDiv = "divDataLst";
            this.recCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_vPaper();
            layui_Alert(1, "已关注！");
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vPaper":
                    //alert('该类没有绑定该函数：[this.BindGv_vPaper_Cache]！');
                    this.BindGv_vPaper();
                    layui_Alert(1, "已关注！");
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        async SetMajorDirectionName(strid_XzMajor) {
            let arrObjLst_Sel = await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjLst_Cache)(strid_XzMajor);
            if (arrObjLst_Sel == null)
                return;
            arrObjLst_Sel = arrObjLst_Sel.filter(x => x.id_XzMajor == strid_XzMajor);
            for (var i = 0; i < arrObjLst_Sel.length; i++) {
                if (i == 0) {
                    let strMajorDirectionName;
                    if ((0, clsString_js_1.IsNullOrEmpty)(clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionId) == true) {
                        strMajorDirectionName = (0, clsString_js_1.Format)("<span class='text-nowrap'><span class='font-weight-bold'>[{0}]</span>方向论文</span>", arrObjLst_Sel[i].majorDirectionName);
                        $("#aMajorDirectionName").html(strMajorDirectionName);
                    }
                    else {
                        strMajorDirectionName = (0, clsString_js_1.Format)("<span class='text-nowrap'><span class='font-weight-bold'>[{0}]</span>方向论文</span>", clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionName);
                        $("#aMajorDirectionName").html(strMajorDirectionName);
                    }
                }
            }
        }
        async SetDl_MajorDirection(strid_XzMajor) {
            var strhtml = "";
            let arrObjLst_Sel = await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjLst_Cache)(clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
            if (arrObjLst_Sel == null)
                return;
            arrObjLst_Sel = arrObjLst_Sel.filter(x => x.id_XzMajor == strid_XzMajor);
            for (var i = 0; i < arrObjLst_Sel.length; i++) {
                if (i == 0) {
                    if ((0, clsString_js_1.IsNullOrEmpty)(clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionId) == true) {
                        //$("#hidid_CurrEduCls").val(arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls);
                        $("#spnMajorDirectionName").html(arrObjLst_Sel[i].majorDirectionName);
                    }
                    else {
                        $("#spnMajorDirectionName").html(clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionName);
                    }
                }
                strhtml += '<dd><a onclick=btn_Click(\'MajorDirectChange\', "' + arrObjLst_Sel[i].majorDirectionId + '")> ' + arrObjLst_Sel[i].majorDirectionName + '</a></dd>';
            }
            $("#dlMajorDirection").html(strhtml);
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                this.SetEventFunc();
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_BindDdl_MajorDirectionIdByid_XzMajorInDiv_Cache)(this.divName4Function, "ddlMajorDirectionId_SetFldValue", clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
                    //await XzMajorDirection_BindDdl_MajorDirectionIdByid_XzMajorInDiv_Cache(this.divName4List, "ddlMajorDirectionId_SetFldValue", clsPublocalStorage.id_XzMajor);
                    this.SetMajorDirectionName(clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
                    (0, clsCommFunc4Ctrl_js_1.SetSpanHtmlByIdInDiv)(this.divName4List, "spnMajorName", (0, clsString_js_1.Format)("[{0}]", clsPublocalStorage_js_1.clsPublocalStorage.majorName));
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "updDate Desc";
                    var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                    //判断角色
                    //管理员
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                        $("#btnAudit").show();
                        $("#btnSynPaperStatistics").show();
                    }
                    else if (strRoleId == "00620002") {
                        $("#btnDelRecord").hide();
                        $("#btnAudit").show();
                    }
                    else {
                        $("#btnDelRecord").hide();
                        $("#btnAudit").hide();
                        $("#btnCancelSubmit").hide();
                    }
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vPaper();
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
        async BindDdl4QueryRegion() {
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
            //const ddl_ddlUserId_q = await this.BindDdl_UserId("ddlUserId_q");
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
            //绑定编辑文献类型
            //const ddl_LiteratureTypeId = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId", new clsLiteratureTypeEN);
            const ddl_PaperTypeId_q = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId_q");
            //绑定论文类型下拉框
            //const ddl_PaperTypeId = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId");
            //论文状态
            //const ddl_PaperStatusId_q = await this.BindDdl_gs_PaperStatus_Cache("ddlPaperStatusId");
            //
            //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
            //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajorNum("ddlid_XzMajor_q");
        }
        async BindDdl_LiteratureTypeId_Cache(ddlLiteratureTypeId, objLiteratureType_Cond) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetSubObjLst_Cache)(objLiteratureType_Cond);
                arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId]);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                console.log("完成BindDdl_LiteratureTypeId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async BindDdl_gs_PaperType_Cache(ddlgs_PaperTypeId) {
            var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlgs_PaperTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlgs_PaperTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var objgs_PaperType_Cond = new clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN();
                var arrObjLst_Sel = await (0, clsgs_PaperTypeWApi_js_1.gs_PaperType_GetSubObjLst_Cache)(objgs_PaperType_Cond);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
                console.log("完成BindDdl_gs_PaperType_Cache!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
            //var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            var strWhereCond = " 1 = 1 ";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                }
                //论文类型
                if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
                }
                //用户
                if (this.User_q != "" && this.User_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdUser} = '${this.User_q}'`;
                }
                //论文维护
                if (strPaperTypeId == "01") {
                    if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                        //判断角色
                        //管理员
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                        if (strRoleId == "00620001") {
                            //可以查看所有；
                            $("#btnDelRecord").show();
                            $("#btnAudit").show();
                            $("#btnCancelSubmit").show();
                            //strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                        }
                        else if (strRoleId == "00620002") {
                            $("#btnDelRecord").show();
                            $("#btnAudit").show();
                            $("#btnCancelSubmit").show();
                            //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                            //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                            //strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                        }
                        else {
                            $("#btnDelRecord").show();
                            $("#btnAudit").hide();
                            $("#btnCancelSubmit").hide();
                            //学生00620003
                            //只能查看自己的数据；或公开的数据；
                            //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                            strWhereCond += ` And updUser = '${strUserId}'`;
                        }
                    }
                    else {
                        window.top.location.href = "../Web/Login";
                    }
                }
                else {
                    //查看无需做控制；可以看到所有；
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vPaper() {
            var strListDiv = this.mstrListDiv;
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
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
                ////绑定专业论文
                //const gvResultMajor = await this.BindGv_vPaperMajor();
                ////绑定方向论文
                //const gvResultDirection = await this.BindGv_vPaperDirection();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrPaperExObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
                console.log("完成BindGv_vPaper!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vPaper对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrPaperObjLst">需要绑定的对象列表</param>
     */
        async BindTab_vPaper(divContainer, arrPaperExObjLst) {
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
                    text: "",
                    tdClass: "text-left",
                    sortBy: "paperTitle", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "paperTitle",
                //    colHeader: "论文标题",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var a1: HTMLElement = document.createElement("Label");
                //        a1.innerText = strText;
                //        a1.className = "btn btn-outline-info";
                //        a1.setAttribute("onclick", `btnDetailRecordInTab_Click('${strKeyId}');`);
                //        return a1;
                //    }
                //},
                {
                    fldName: "periodical",
                    colHeader: "期刊",
                    text: "", tdClass: "text-left",
                    sortBy: "periodical", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left",
                    sortBy: "author", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "researchQuestion",
                //    colHeader: "研究问题",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left",
                    sortBy: "keyword", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "literatureSources",
                    colHeader: "文献来源",
                    text: "", tdClass: "text-left",
                    sortBy: "literatureSources", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "literatureLink",
                //    colHeader: "文献链接",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "uploadfileUrl",
                //    colHeader: "文件地址",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "checker",
                //    colHeader: "审核人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "isSubmit",
                    colHeader: "是否提交",
                    text: "", tdClass: "text-left",
                    sortBy: "isSubmit", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isChecked",
                    colHeader: "是否审核",
                    text: "", tdClass: "text-left",
                    sortBy: "isChecked", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "isQuotethesis",
                //    colHeader: "是否引用论文",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "updDate",
                    colHeader: "提交日期",
                    text: "", tdClass: "text-left",
                    sortBy: "updDate", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "提交用户",
                    text: "", tdClass: "text-left",
                    sortBy: "userName", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "pcount",
                //    colHeader: "读写数",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "attachmentCount",
                    colHeader: "附件数",
                    text: "", tdClass: "text-left",
                    sortBy: "attachmentCount", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "详情",
                    text: "详情", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDetailRecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
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
            (0, clsCommFunc4Web_js_1.BindTab)(o, arrPaperExObjLst, arrDataColumn, "paperId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
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
            const responseBindGv = await this.BindGv_vPaper();
        }
        /*
       * 获取当前页序号
      */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvPaperBy(value) {
            $("#hidSortvPaperBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvPaperBy() {
            return $("#hidSortvPaperBy").val();
        }
        /*
        * 是否检查
       */
        get IsChecked_q() {
            return $("#chkIsChecked_q").prop("checked");
        }
        /*
        * 是否引用论文
       */
        get IsQuotethesis_q() {
            return $("#chkIsQuotethesis_q").prop("checked");
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set opType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 主题名称
       */
        get updDate_q() {
            return $("#txtUpdDate_q").val();
        }
        /*
        * 论文标题
       */
        get paperTitle_q() {
            return $("#txtPaperTitle_q").val();
        }
        /*
        * 文献类型Id
       */
        get literatureTypeId_q() {
            return $("#ddlLiteratureTypeId_q").val();
        }
        /*
    * 论文类型查询
    */
        set PaperTypeId_q(value) {
            $("#ddlPaperTypeId_q").val(value);
        }
        /*
        * 论文类型查询
        */
        get PaperTypeId_q() {
            return $("#ddlPaperTypeId_q").val();
        }
        /*
    * 用户
    */
        //public get readUser_q(): string {
        //    return $("#txtReadUser_q").val();
        //}
        get User_q() {
            return $("#ddlUserId_q").val();
        }
        /** 函数功能:设置事件函数
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
        **/
        async SetEventFunc() {
            const strThisFuncName = this.SetEventFunc.name;
            // 在此处放置用户代码以初始化页面
            try {
                //没有定义相关事件
                const ddlMajorDirectionId_SetFldValue = (0, clsCommFunc4Ctrl_js_1.GetSelectObjInDiv)(this.divName4Function, 'ddlMajorDirectionId_SetFldValue');
                ddlMajorDirectionId_SetFldValue.addEventListener('change', e => { this.ddlMajorDirectionId_SetFldValue_SelectedIndexChanged(ddlMajorDirectionId_SetFldValue); });
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("设置事件函数不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 按钮单击,用于调用Js函数中btn_Click
        * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        **/
        static btn_Click(strCommandName, strKeyId) {
            let objPage = new Paper_QUDI();
            //if (PaperCRUD.objPage_CRUD == null) {
            //    PaperCRUD.objPage_CRUD = new Paper_QUDI();
            //    objPage = <Paper_QUDI>PaperCRUD.objPage_CRUD;
            //}
            //else {
            //    objPage = <Paper_QUDI>PaperCRUD.objPage_CRUD;
            //}
            const objPage_Edit = new Paper_EditEx_js_1.Paper_EditEx(objPage);
            let strMsg = '';
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            switch (strCommandName) {
                case "SetCurrMajorDirection": //查询记录
                    objPage.btnSetCurrMajorDirection_Click();
                    break;
                case "SetCurrEduCls": //查询记录
                    objPage.btnSetCurrEduCls_Click();
                    break;
                //case "SetCurrMajor":    //查询记录
                //    objPage.btnSetCurrMajor_Click();
                //    break;
                case "MajorDirection": //查询记录
                    objPage.liMajorDirection_Click();
                    break;
                case "CurrEduCls": //查询记录
                    objPage.liCurrEduCls_Click();
                    break;
                case "AllPaper": //查询记录
                    objPage.liAllPaper_Click();
                    break;
                case "Major": //查询记录
                    objPage.liMajor_Click();
                    break;
                //case "AddCollection":    //查询记录
                //    objPage.btnAddCollection_Click(strKeyId);
                //    break;
                //case "AddVote":    //查询记录
                //    objPage.btnAddVote_Click(strKeyId);
                //    break;
                //case "AddAttention":    //查询记录
                //    objPage.btnAddAttention_Click(objPage, strKeyId);
                //    break;
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                case "UpdateRecordInTab": //修改记录InTab
                    strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        const strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (strCommandName == "UpdateRecordInTab") {
                        objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    }
                    else {
                        objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    }
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "ExportExcel": //导出Excel
                    //objPage.btnExportExcel_Click();
                    //alert("导出Excel功能还没有开通！");
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    strMsg = '命令:' + strCommandName + "在函数(PaperCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
        **/
        async btnQuery_Click() {
            const strThisFuncName = this.btnQuery_Click.name;
            this.SetCurrPageIndex(1);
            let objPage_Sub;
            switch (Paper_QUDI.CurrTabName) {
                case "AllPaper":
                    objPage_Sub = new Paper_QUDI_AllPaper_js_1.Paper_QUDI_AllPaper();
                    await objPage_Sub.Page_Load();
                    break;
                case "CurrEduCls":
                    objPage_Sub = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                    await objPage_Sub.Page_Load();
                    break;
                case "Major":
                    objPage_Sub = new Paper_QUDI_Major_js_1.Paper_QUDI_Major();
                    await objPage_Sub.Page_Load();
                    break;
                case "Direction":
                    objPage_Sub = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                    await objPage_Sub.Page_Load();
                    break;
                default:
                    const strMsg = '当前Tab:' + Paper_QUDI.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                    alert(strMsg);
                    break;
            }
            //    const responseBindGv = await this.BindGv_vPaper();
        }
        /* 所有论文
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async liAllPaper_Click() {
            try {
                Paper_QUDI.CurrTabName = "AllPaper";
                const objPage = new Paper_QUDI_AllPaper_js_1.Paper_QUDI_AllPaper();
                await objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 所有论文
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async liCurrEduCls_Click() {
            try {
                Paper_QUDI.CurrTabName = "CurrEduCls";
                const objPage = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                await objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 本专业
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async liMajor_Click() {
            try {
                Paper_QUDI.CurrTabName = "Major";
                //绑定专业论文
                const objPage = new Paper_QUDI_Major_js_1.Paper_QUDI_Major();
                objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 本专业方向
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async liMajorDirection_Click() {
            try {
                Paper_QUDI.CurrTabName = "Direction";
                //绑定方向论文
                const objPage = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /** 函数功能:从界面列表中根据某一个字段排序
     * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     * @param objAnchorElement:带有排序字段的Anchors
     **/
        async SortBy(objAnchorElement) {
            const strThisFuncName = this.SortBy.name;
            console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
            let strSortExpress = "";
            //event = window.event || event;
            if (typeof (objAnchorElement) != "function") {
                const thisEventObj = objAnchorElement;
                strSortExpress = thisEventObj.getAttribute("FldName");
            }
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, PaperCRUD_js_1.PaperCRUD.ascOrDesc4SortFun, PaperCRUD_js_1.PaperCRUD.sortPaperBy, strSortExpress);
            PaperCRUD_js_1.PaperCRUD.sortPaperBy = sortBy;
            PaperCRUD_js_1.PaperCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            PaperCRUD_js_1.PaperCRUD.sortFun_Static = sortFun;
            await this.btnQuery_Click();
        }
        /* 所有论文
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async btnSetCurrEduCls_Click() {
            const strThisFuncName = this.btnSetCurrEduCls_Click.name;
            try {
                var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                let arrKeyIds;
                let objPage_Sub;
                switch (Paper_QUDI.CurrTabName) {
                    case "AllPaper":
                        objPage_Sub = new Paper_QUDI_AllPaper_js_1.Paper_QUDI_AllPaper();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "CurrEduCls":
                        objPage_Sub = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "Major":
                        objPage_Sub = new Paper_QUDI_Major_js_1.Paper_QUDI_Major();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "Direction":
                        objPage_Sub = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    default:
                        const strMsg = '当前Tab:' + Paper_QUDI.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                        alert(strMsg);
                        break;
                }
                if (arrKeyIds.length == 0) {
                    alert("请选择需要设置当前教学班的记录！");
                    return "";
                }
                await (0, clsPaperEduClsRelaExWApi_js_1.PaperEduClsRelaEx_SetId_CurrEduCls)(arrKeyIds, strid_CurrEducls);
                Paper_QUDI.CurrTabName = "CurrEduCls";
                const objPage = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                await objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `设置当前教学班不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 所有论文
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async btnSetCurrMajorDirection_Click() {
            const strThisFuncName = this.btnSetCurrEduCls_Click.name;
            try {
                const strMajorDirectionId = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Function, "ddlMajorDirectionId_SetFldValue");
                if (strMajorDirectionId == "") {
                    const strMsg = "请输入研究方向Id(MajorDirectionId)!";
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                let arrKeyIds;
                let objPage_Sub;
                switch (Paper_QUDI.CurrTabName) {
                    case "AllPaper":
                        objPage_Sub = new Paper_QUDI_AllPaper_js_1.Paper_QUDI_AllPaper();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "CurrEduCls":
                        objPage_Sub = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "Major":
                        objPage_Sub = new Paper_QUDI_Major_js_1.Paper_QUDI_Major();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "Direction":
                        objPage_Sub = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    default:
                        const strMsg = '当前Tab:' + Paper_QUDI.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                        alert(strMsg);
                        break;
                }
                if (arrKeyIds.length == 0) {
                    alert("请选择需要设置专业方向的记录！");
                    return "";
                }
                await (0, clsMajorDirectionPaperRelaExWApi_js_1.MajorDirectionPaperRelaEx_SetMajorDirectionId)(arrKeyIds, strMajorDirectionId);
                Paper_QUDI.CurrTabName = "Direction";
                const objPage = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                await objPage.Page_Load();
                //const objPage2 = new Paper_QUDI_Major();
                //await objPage2.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `设置当前专业研究方向不成功,${e}.`;
                alert(strMsg);
            }
        }
        /** 函数功能:系统生成的Change事件函数
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript+<>c__DisplayClass13_0:<Gen_WApi_Ts_GeneEventFuncEx>b__1)
    */
        async ddlMajorDirectionId_SetFldValue_SelectedIndexChanged(ddlMajorDirectionId_SetFldValue) {
            const strThisFuncName = this.ddlMajorDirectionId_SetFldValue_SelectedIndexChanged.name;
            const strMajorDirectionId = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Function, "ddlMajorDirectionId_SetFldValue");
            if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true)
                return;
            clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionId = strMajorDirectionId;
            const objXzMajorDirection = await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjByMajorDirectionId_Cache)(strMajorDirectionId, clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
            if (objXzMajorDirection == null) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionName = objXzMajorDirection.majorDirectionName;
            const strMajorDirectionName = (0, clsString_js_1.Format)("<span class='text-nowrap'><span class='font-weight-bold'>[{0}]</span>方向论文</span>", objXzMajorDirection.majorDirectionName);
            $("#aMajorDirectionName").html(strMajorDirectionName);
            const objPage = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
            await objPage.Page_Load();
        }
    }
    exports.Paper_QUDI = Paper_QUDI;
    Paper_QUDI.CurrTabName = "AllPaper";
});
