(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/stuUserLoginInfo.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/L3_ForWApiEx/Other/clsvPaperSimExWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSimWApi.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperSimEN.js", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/PubFun/clsOperateList.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperAllListEx = void 0;
    const stuUserLoginInfo_js_1 = require("../TS/FunClass/stuUserLoginInfo.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsvPaperSimExWApi_js_1 = require("../TS/L3_ForWApiEx/Other/clsvPaperSimExWApi.js");
    const clsvPaperSimWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSimWApi.js");
    const clsvPaperSimEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperSimEN.js");
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    /* PaperAllListEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PaperAllListEx extends PaperCRUD_js_1.PaperCRUD {
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
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "updDate Desc";
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
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    const gvResult = await this.BindGv_vPaper();
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
        /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vPaper() {
            var strListDiv = this.divName4DataList;
            //var strWhereCond = await this.CombinevPaperCondition();
            var strWhereCond = "";
            var objvPaperSim_Cond = this.CombinevPaperSimConditionobj();
            strWhereCond = JSON.stringify(objvPaperSim_Cond);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvPaperSimObjLst = [];
            var objPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            try {
                this.recCount = await (0, clsvPaperSimExWApi_js_1.vPaperSimEx_GetRecCountByCondById_CurrEduCls_Cache)(objvPaperSim_Cond, clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                console.log("完成计数!");
                arrvPaperSimObjLst = await (0, clsvPaperSimExWApi_js_1.vPaperSimEx_GetObjLstByPagerById_CurrEduCls_Cache)(objPagerPara, clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                console.log("完成对象列表获取!");
                //this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //});
                //const responseObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrvPaperSimObjLst = <Array<clsPaperEN>>jsonData;
                //});
                //const responseText = await vPaper_GetObjLstByPager_WA_CacheAsync(objPagerPara);
                //arrvPaperSimObjLst = <Array<clsPaperEN>>responseText;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvPaperSimObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                //  const gvResultPaper = await this.BindList_vPaperSim("1", arrvPaperSimObjLst);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定论文视图对象列表不成功.Error Massage:${e}.`;
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
        //    /* 根据条件获取相应的记录对象的列表
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
        //*/
        //    public async BindGv_vPaper() {
        //        var strListDiv: string = this.mstrListDiv;
        //        var strWhereCond = await this.CombinevPaperCondition();
        //        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //        var arrPaperExObjLst: Array<clsPaperENEx> = [];
        //        try {
        //            this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //            });
        //            var objPagerPara: stuPagerPara = {
        //                pageIndex: intCurrPageIndex,
        //                pageSize: this.pageSize,
        //                whereCond: strWhereCond,
        //                orderBy: PaperCRUD.sortPaperBy
        //            };
        //            const responseObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara).then((jsonData) => {
        //                arrPaperExObjLst = <Array<clsPaperEN>>jsonData;
        //            });
        //            ////绑定专业论文
        //            //const gvResultMajor = await this.BindGv_vPaperMajor();
        //            ////绑定方向论文
        //            //const gvResultDirection = await this.BindGv_vPaperDirection();
        //        }
        //        catch (e) {
        //            console.error('catch(e)=');
        //            console.error(e);
        //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //        //if (arrPaperExObjLst.length == 0) {
        //        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //        //    alert(strMsg);
        //        //    return;
        //        //}
        //        try {
        //            this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
        //            console.log("完成BindGv_vPaper!");
        //        }
        //        catch (e) {
        //            console.error('catch(e)=');
        //            console.error(e);
        //            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //            alert(strMsg);
        //        }
        //    }
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
    exports.PaperAllListEx = PaperAllListEx;
});
