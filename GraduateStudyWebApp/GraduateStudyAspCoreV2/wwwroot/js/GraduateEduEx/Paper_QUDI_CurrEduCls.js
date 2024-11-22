(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEduClsRelaEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_QUDI_CurrEduCls = void 0;
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js");
    const clsPaperDownloadLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsPaperEduClsRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEduClsRelaEN.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsgs_PaperTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperDownloadLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsgs_PaperTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* Paper_QUDI_CurrEduCls 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Paper_QUDI_CurrEduCls extends PaperCRUD_js_1.PaperCRUD {
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
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                this.divName4Pager = "divPager_CurrEduCls";
                this.divName4Query = "divQuery";
                this.divName4DataList = "divCurrEduClsDataLst";
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //加载页面所需数据源到缓存
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    const gvResult = await this.BindGv_Paper();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
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
        async Refresh_Click() {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(strid_CurrEducls);
            location.reload();
        }
        async BindDdl4QueryRegion() {
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
            //var objXzMajor_Cond: clsXzMajorEN = new clsXzMajorEN();//查询区域
            //const ddl_id_XzMajor_q = await clsDropDownList.BindDdl_XzMajorInvPaper_Cache("ddlid_XzMajor_q", objXzMajor_Cond);//专业查询区域
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
            const ddl_PaperTypeId_q = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId_q");
            //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
            //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajorNum("ddlid_XzMajor_q");
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
                var arrObjLst_Sel = await (0, clsgs_PaperTypeWApi_js_1.gs_PaperType_GetObjLstAsync)(strWhereCond);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
                console.log("完成BindDdl_gs_PaperType_Cache!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
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
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinePaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if ($("#hidTabPaper").val() == "1") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                //}
                //if ($("#hidTabPaper").val() == "2") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                //}
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '%${this.paperTitle_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdDate} like '%${this.updDate_q}%'`;
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                }
                if (this.User_q != "" && this.User_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdUser} = '${this.User_q}'`;
                }
                //论文类型
                if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
                }
                //if (this.User_q != "" && this.User_q != "0") {
                //    strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.User_q}'`;
                //}
                //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                //    strWhereCond += ` And ${clsPaperEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
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
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombinePaperCondition_EduCLs() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if ($("#hidTabPaper").val() == "1") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                //}
                //if ($("#hidTabPaper").val() == "2") {
                //    strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                //}
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '%${this.paperTitle_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdDate} like '%${this.updDate_q}%'`;
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                }
                if (this.User_q != "" && this.User_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdUser} = '${this.User_q}'`;
                }
                //论文类型
                if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
                }
                //if (this.User_q != "" && this.User_q != "0") {
                //    strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.User_q}'`;
                //}
                //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                //    strWhereCond += ` And ${clsPaperEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
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
        CombinePaperConditionobj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            //var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            var objvPaper_Cond = new clsPaperEN_js_1.clsPaperEN();
            //objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_CurrEduCls, clsPublocalStorage.id_CurrEduCls, "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_PaperTitle, this.paperTitle_q, "like");
                }
                if (this.updDate_q != "") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_UpdDate, this.updDate_q, "like");
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId, this.literatureTypeId_q, "=");
                }
                if (this.User_q != "" && this.User_q != "0") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_UpdUser, this.User_q, "=");
                }
                //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                //    objvPaper_Cond.SetCondFldValue(clsPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
                //}
                //论文类型
                if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                    objvPaper_Cond.SetCondFldValue(clsPaperEN_js_1.clsPaperEN.con_PaperTypeId, this.PaperTypeId_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvPaper_Cond;
        }
        //  /* 修改记录
        // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
        //*/
        //  public btnUpdateRecord_Click(strKeyId: string) {
        //      this.opType = "Update";
        //      //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        //      if (strKeyId == "") {
        //          alert("请选择需要修改的记录！");
        //          return;
        //      }
        //      this.UpdateRecord(strKeyId);
        //  }
        //绑定本专业
        async BindGv_Paper() {
            //var strListDiv: string = this.mstrListDivMajor;
            var strWhereCond = await this.CombinePaperCondition();
            //通过登录的用户得到用户专业
            var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            strWhereCond += ` and paperId in (select paperId from PaperEduClsRela where ${clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_id_CurrEduCls}= '${strid_CurrEduCls}')`;
            //strWhereCond += " and  id_XzMajor= '" + strid_XzMajor + "'";
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
                ////绑定方向论文
                //const gvResultDirection = await this.BindGv_vPaperDirection();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取本专业的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrPaperExObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                //this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
                const gvResultPaper = await (0, clsPaperExWApi_js_1.PaperEx_BindTab_Paper)(this.divName4DataList, arrPaperExObjLst, this);
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
                console.log("完成BindGv_vPaperEduCls!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定本专业对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
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
            //this.BindGv_vXzMajorDirection();
        }
        /*
      * 修改用户Id
     */
        set updUser(value) {
            $("#hidUserId").val(value);
        }
        /*
        * 修改用户Id
       */
        get updUser() {
            return clsPublocalStorage_js_1.clsPublocalStorage.userId;
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
        /*
    * 用户
    */
        //public get readUser_q(): string {
        //    return $("#txtReadUser_q").val();
        //}
        get User_q() {
            return $("#ddlUserId_q").val();
        }
        get PaperSort() {
            return $("#ddlPaperSort").val();
        }
        //  /*
        // * 专业流水号
        //*/
        //  public set id_XzMajor_q(value: string) {
        //      $("#ddlid_XzMajor_q").val(value);
        //  }
        //  /*
        //  * 专业流水号
        // */
        //  public get id_XzMajor_q(): string {
        //      return $("#ddlid_XzMajor_q").val();
        //  }
        /*
     * 专业方向号
    */
        // public set MajorDirectionId_q(value: string) {
        //     $("#ddlMajorDirectionId_q").val(value);
        // }
        // /*
        // * 专业方向号
        //*/
        // public get MajorDirectionId_q(): string {
        //     return $("#ddlMajorDirectionId_q").val();
        // }
        //添加下载量
        async btnAddDownload_Click(strPaperId) {
            const strThisFuncName = this.btnAddDownload_Click.name;
            //this.DivName = "divAddNewRecordSave";
            var objPaperDownloadLogEN = new clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN();
            //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperDownloadLogEN.SetPaperId(strPaperId);
            objPaperDownloadLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objPaperDownloadLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + strPaperId;
            try {
                const responseText2 = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_AddNewRecordAsync)(objPaperDownloadLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " paperId=" + strPaperId;
                    var intDownloadCount = await (0, clsPaperDownloadLogWApi_js_1.PaperDownloadLog_GetRecCountByCondAsync)(strWhereCond2);
                    var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                    objPaperEN.SetPaperId(strPaperId);
                    objPaperEN.SetDownloadCount(intDownloadCount);
                    objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    var returnBool = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
                    if (returnBool == true) {
                        //const gvResult = await this.BindGv_Paper();
                        this.BindGv_Paper();
                    }
                    else {
                        var strInfo = `添加下载量不成功!`;
                        alert(strInfo);
                        console.log("添加下载量不成功");
                    }
                }
                else {
                    var strInfo = `添加下载量不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //this.BindGv_vPaperSubViewpoint();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加下载量不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //下载文件
        btnDownLoadFile_Click(strPaperId) {
            //下载函数
            this.GetPaperAttachmentRecord(strPaperId);
            //添加下载记录
            this.btnAddDownload_Click(strPaperId);
        }
        //下载函数
        async GetPaperAttachmentRecord(strPaperId) {
            var strPapeId = strPaperId;
            //this.keyId = strPaperRWId;
            var strWhereCond = ` ${clsPaperAttachmentEN_js_1.clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
            var arrPaperAttachmentObjLst = [];
            try {
                var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
                arrPaperAttachmentObjLst = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetObjLstAsync)(strWhereCond);
                for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {
                    var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                    doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
                }
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
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
    }
    exports.Paper_QUDI_CurrEduCls = Paper_QUDI_CurrEduCls;
});
