(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperCRUD", "../TS/FunClass/stuUserLoginInfo.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSimWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MajorPaperListEx = void 0;
    const PaperCRUD_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD");
    const stuUserLoginInfo_js_1 = require("../TS/FunClass/stuUserLoginInfo.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsvPaperSimEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperSimEN.js");
    const clsvPaperSimWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSimWApi.js");
    /* MajorPaperListEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class MajorPaperListEx extends PaperCRUD_1.PaperCRUD {
        constructor() {
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvPaperBy: string = "paperId";
            super(...arguments);
            //专业方向
            this.mstrListDivMajorDirection = "divMajorDirectionDataLst";
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 200;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if ($("#hidUserInfo").val() != "") {
                    //加载页面所需数据源到缓存
                    const arrLiteratureType_Cache = await (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetObjLstAsync)("1=1");
                    //const arrXzMajor_Cache = await XzMajor_GetObjLstAsync("1=1");
                    const arrvPaperSim_Cache = await (0, clsvPaperSimWApi_js_1.vPaperSim_GetObjLstAsync)("1=1");
                    ////1、为下拉框设置数据源,绑定列表数据
                    ////查询文献类型绑定；
                    ////const ddl_UserId_q = await clsDropDownList.BindDdl_UserId("ddlUserId_q");
                    //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                    //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN);
                    ////const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor_Cache("ddlid_XzMajor_q", new clsXzMajorEN);
                    //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajorNum("ddlid_XzMajor_q");
                    //绑定编辑文献类型
                    PaperCRUD_1.PaperCRUD.sortPaperBy = "updDate Desc";
                    this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";
                    var strWhereCond = await this.CombinevPaperCondition();
                    const responseText = await (0, clsvPaperSimWApi_js_1.vPaperSim_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                        this.recCount = jsonData;
                    });
                    //2、显示无条件的表内容在GridView中
                    //const gvResult = await this.BindGv_vPaperLoad();
                    //const gvResultMajor = await this.BindGv_vPaperMajor();
                    //const gvResultDecrtion = await this.BindGv_vPaperDirection();
                    //}
                    //else {
                    //    window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                    //}
                    var strUserInfo_Hid = $("#hidUserInfo").val();
                    var objvUserRoleRelation;
                    objvUserRoleRelation = stuUserLoginInfo_js_1.stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
                    $("#hidUserId").val(objvUserRoleRelation.userId);
                    //判断角色
                    //管理员
                    //if (objvUserRoleRelation.roleId == "00620001") {
                    //    $("#btnDelRecord").show();
                    //    $("#btnAudit").show();
                    //}
                    //else if (objvUserRoleRelation.roleId == "00620002") {
                    //    $("#btnDelRecord").hide();
                    //    $("#btnAudit").show();
                    //}
                    //else {
                    //    $("#btnDelRecord").hide();
                    //    $("#btnAudit").hide();
                    //}
                    //   const gvResult = await this.BindGv_vPaperMajor();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../WebApp/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        CombinevPaperSimConditionobj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvPaperSim_Cond = new clsvPaperSimEN_js_1.clsvPaperSimEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.paperTitle_q != "") {
                //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_PaperTitle, this.paperTitle_q, "like");
                //}
                //if (this.updDate_q != "") {
                //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_UpdDate, this.updDate_q, "like");
                //}
                //if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_LiteratureTypeId, this.literatureTypeId_q, "=");
                //}
                //if (this.User_q != "" && this.User_q != "0") {
                //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_UpdUser, this.User_q, "=");
                //}
                //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_id_XzMajor, this.id_XzMajor_q, "=");
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvPaperSim_Cond;
        }
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        CombinevPaperSimCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.paperTitle_q != "") {
                //    strWhereCond += ` And ${clsvPaperSimEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                //}
                //if (this.updDate_q != "") {
                //    strWhereCond += ` And ${clsvPaperSimEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                //}
                //if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvPaperSimEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                //}
                //if (this.User_q != "" && this.User_q != "0") {
                //    strWhereCond += ` And ${clsvPaperSimEN.con_UpdUser} = '${this.User_q}'`;
                //}
                ////if (this.User_q != "" && this.User_q != "0") {
                ////    strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.User_q}'`;
                ////}
                //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                //    strWhereCond += ` And ${clsvPaperSimEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                //    //if (this.MajorDirectionId_q != "" && this.MajorDirectionId_q != "0") {
                //    //    strWhereCond += " and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId='" + this.MajorDirectionId_q + "')";
                //    //}
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        ////绑定本专业
        //public async BindGv_vPaperMajor() {
        //    //var strListDiv: string = this.mstrListDivMajor;
        //    var strWhereCond = await this.CombinevPaperSimCondition();
        //    //通过登录的用户得到用户专业
        //    var strUserInfo_Hid = $("#hidUserInfo").val();
        //    var objvUserRoleRelation: clsvQxUserRoleRelationEN;
        //    objvUserRoleRelation = stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
        //    var strid_XzMajor = objvUserRoleRelation.id_XzMajor;
        //    //strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where id_XzMajor= '${strid_XzMajor}')`;
        //    strWhereCond += " and  id_XzMajor= '" + strid_XzMajor + "'";
        //    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //    var arrvPaperSimObjLst: Array<clsvPaperSimEN> = [];
        //    try {
        //        //this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //        
        //        //});
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: this.pageSize,
        //            whereCond: strWhereCond,
        //            orderBy: PaperCRUD.sortPaperBy
        //        };
        //        const responseObjLst = await vPaperSim_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrvPaperSimObjLst = <Array<clsvPaperSimEN>>jsonData;
        //        });
        //        ////绑定方向论文
        //        //const gvResultDirection = await this.BindGv_vPaperDirection();
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取本专业的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    //if (arrvPaperSimObjLst.length == 0) {
        //    //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //    //    alert(strMsg);
        //    //    return;
        //    //}
        //    try {
        //        //this.BindTab_vPaper(strListDiv, arrvPaperSimObjLst);
        //        const gvResultPaper = await this.BindList_vPaperSim("2", arrvPaperSimObjLst);
        //        console.log("完成BindGv_vPaperMajor!");
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `绑定本专业对象列表不成功.Error Massage:${e}.`;
        //        alert(strMsg);
        //    }
        //}
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
                //if (this.paperTitle_q != "") {
                //    strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                //}
                //if (this.updDate_q != "") {
                //    strWhereCond += ` And ${clsPaperEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                //}
                //if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                //    strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                //}
                ////论文维护
                //if (strPaperTypeId == "01") {
                if ($("#hidUserInfo").val() != "") {
                    var strUserInfo_Hid = $("#hidUserInfo").val();
                    var objvUserRoleRelation;
                    objvUserRoleRelation = stuUserLoginInfo_js_1.stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
                    //$('#lnkUserName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
                    $("#hidUserId").val(objvUserRoleRelation.userId);
                    //判断角色
                    //管理员
                    //if (objvUserRoleRelation.roleId == "00620001") {
                    //    //可以查看所有；
                    //    $("#btnDelRecord").show();
                    //    $("#btnAudit").show();
                    //}
                    //else if (objvUserRoleRelation.roleId == "00620002") {
                    //    $("#btnDelRecord").hide();
                    //    $("#btnAudit").show();
                    //    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    //    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
                    //}
                    //else {
                    //    $("#btnDelRecord").hide();
                    //    $("#btnAudit").hide();
                    //    //学生00620003
                    //    //只能查看自己的数据；或公开的数据；
                    //    //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                    //    strWhereCond += ` And updUser = '${objvUserRoleRelation.userId}'`;
                    //}
                }
                else {
                    window.top.location.href = "../WebApp/Login";
                }
                //}
                //else {
                //    //查看无需做控制；可以看到所有；
                //}
                //if (this.IsChecked_q == true) {
                //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '0'`;
                //}
                //if (this.IsQuotethesis_q == true) {
                //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '0'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
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
    }
    exports.MajorPaperListEx = MajorPaperListEx;
});
