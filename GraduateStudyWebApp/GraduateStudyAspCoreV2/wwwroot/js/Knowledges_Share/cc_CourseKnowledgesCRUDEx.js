(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js", "../TS/L0_Entity/Knowledges_Share/clscc_CourseKnowledgesENEx.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/FunClass_Share/clsPubVar4Web.js", "../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js", "../TS/L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaEN.js", "../TS/L0_Entity/Knowledges_Share/clsKnowledgeTypeEN.js", "../TS/PubFun/clsOperateList.js", "./cc_CourseKnowledges_EditEx.js", "./KnowledgeType_EditEx.js", "../TS/L3_ForWApi/Knowledges_Share/clscc_CourseKnowledgesWApi.js", "../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../TS/L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js", "../TS/PubFun/clsString.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/L3_ForWApiEx/Knowledges_Share/clscc_CourseKnowledgesExWApi.js", "../PagesBase/Knowledges_Share/cc_CourseKnowledges_Edit.js", "../PagesBase/Knowledges_Share/cc_CourseKnowledgesCRUD.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseKnowledgesCRUDEx = void 0;
    const clscc_CourseKnowledgesEN_js_1 = require("../TS/L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js");
    const clscc_CourseKnowledgesENEx_js_1 = require("../TS/L0_Entity/Knowledges_Share/clscc_CourseKnowledgesENEx.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubVar4Web_js_1 = require("../TS/FunClass_Share/clsPubVar4Web.js");
    const clscc_CourseChapterEN_js_1 = require("../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js");
    const clscc_KnowledgesExamLibRelaEN_js_1 = require("../TS/L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaEN.js");
    const clsKnowledgeTypeEN_js_1 = require("../TS/L0_Entity/Knowledges_Share/clsKnowledgeTypeEN.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const cc_CourseKnowledges_EditEx_js_1 = require("./cc_CourseKnowledges_EditEx.js");
    const KnowledgeType_EditEx_js_1 = require("./KnowledgeType_EditEx.js");
    const clscc_CourseKnowledgesWApi_js_1 = require("../TS/L3_ForWApi/Knowledges_Share/clscc_CourseKnowledgesWApi.js");
    const clscc_CourseChapterWApi_js_1 = require("../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsKnowledgeTypeWApi_js_1 = require("../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clscc_KnowledgesExamLibRelaWApi_js_1 = require("../TS/L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clscc_CourseKnowledgesExWApi_js_1 = require("../TS/L3_ForWApiEx/Knowledges_Share/clscc_CourseKnowledgesExWApi.js");
    const cc_CourseKnowledges_Edit_js_1 = require("../PagesBase/Knowledges_Share/cc_CourseKnowledges_Edit.js");
    const cc_CourseKnowledgesCRUD_js_1 = require("../PagesBase/Knowledges_Share/cc_CourseKnowledgesCRUD.js");
    /* cc_CourseKnowledgesCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class cc_CourseKnowledgesCRUDEx extends cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD {
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType) {
            //cc_CourseKnowledges_ReFreshCache(clsPublocalStorage.courseId);
            this.BindGv_cc_CourseKnowledges4Func();
        }
        BindGv_Cache(strType) {
            switch (strType) {
                case "cc_CourseKnowledges":
                    alert('该类没有绑定该函数：[this.BindGv_cc_CourseKnowledges_Cache]！');
                    //this.BindGv_cc_CourseKnowledges_Cache();
                    break;
            }
        }
        /*
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        async DelRecord(strCourseKnowledgeId) {
            try {
                const responseText = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_DelRecordAsync)(strCourseKnowledgeId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_ReFreshCache)(clsPublocalStorage_js_1.clsPublocalStorage.courseId);
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                var strMsg = `删除记录不成功. ${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
    */
        async DelMultiRecord(arrCourseKnowledgeId) {
            try {
                const responseText = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_Delcc_CourseKnowledgessAsync)(arrCourseKnowledgeId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_ReFreshCache)(clsPublocalStorage_js_1.clsPublocalStorage.courseId);
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelMultiRecord!");
            }
            catch (e) {
                var strMsg = `删除记录不成功. ${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.objPage_CRUD == null) {
                cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.objPage_CRUD = new cc_CourseKnowledgesCRUDEx();
                objPage = cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.objPage_CRUD;
            }
            else {
                objPage = cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.objPage_CRUD;
            }
            const objPage_Edit = new cc_CourseKnowledges_EditEx_js_1.cc_CourseKnowledges_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
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
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "UpdateRecordInTab": //修改记录InTab
                    objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    objPage.btnCopyRecord_Click();
                    break;
                case "ExportExcel": //导出Excel
                    objPage.btnExportExcel_Click();
                    //alert("导出Excel功能还没有开通！");
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    if ((0, clsCommFunc4Web_js_1.confirm_del)(arrKeyIds.length) == false) {
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
                    objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    objPage.btnReOrder_Click();
                    break;
                case "AddKnowType": //增加知识点类型
                    objPage.btnAddKnowType_Click();
                    break;
                default:
                    strMsg = '命令:' + strCommandName + "在函数(cc_CourseKnowledgesCRUDEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
                cc_CourseKnowledges_Edit_js_1.cc_CourseKnowledges_Edit.CourseId_Cache = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
                this.SetEventFunc();
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.sortcc_CourseKnowledgesBy = "orderNum Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                await this.BindGv_cc_CourseKnowledges4Func();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
    */
        async Combinecc_CourseKnowledgesConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objcc_CourseKnowledges_Cond = new clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.knowledgeTitle_q != "") {
                    strWhereCond += ` And ${clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN.con_KnowledgeTitle} like '% ${this.knowledgeTitle_q}%'`;
                    objcc_CourseKnowledges_Cond.SetCondFldValue(clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN.con_KnowledgeTitle, this.knowledgeTitle_q, "like");
                }
                //if ( this.userId_q != "")
                //{
                //strWhereCond += ` And ${ clscc_CourseKnowledgesEN.con_UserId} like '% ${ this.userId_q }%'`;
                //objcc_CourseKnowledges_Cond.SetCondFldValue(clscc_CourseKnowledgesEN.con_UserId, this.userId_q, "like");
                //}
                if (this.courseChapterId_q != "" && this.courseChapterId_q != "0") {
                    strWhereCond += ` And ${clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN.con_CourseChapterId} = '${this.courseChapterId_q}'`;
                    objcc_CourseKnowledges_Cond.SetCondFldValue(clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN.con_CourseChapterId, this.courseChapterId_q, "=");
                }
                //查询当前课程
                var strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
                strWhereCond += ` And ${clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN.con_CourseId} = '${strCourseId}'`;
                objcc_CourseKnowledges_Cond.SetCondFldValue(clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN.con_CourseId, strCourseId, "=");
                //if ($("#ddlIsShow_q").prop("selectedIndex") == 1)
                //{
                //strWhereCond += ` And ${clscc_CourseKnowledgesEN.con_IsShow } = '1'`; 
                //objcc_CourseKnowledges_Cond.SetCondFldValue(clscc_CourseKnowledgesEN.con_IsShow, true, "=");
                //}
                //else if ($("#ddlIsShow_q").prop("selectedIndex") == 2)
                //{
                //strWhereCond += ` And ${clscc_CourseKnowledgesEN.con_IsShow } = '0'`;
                //objcc_CourseKnowledges_Cond.SetCondFldValue(clscc_CourseKnowledgesEN.con_IsShow, false, "=");
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(Combinecc_CourseKnowledgesConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            objcc_CourseKnowledges_Cond.whereCond = strWhereCond;
            return objcc_CourseKnowledges_Cond;
        }
        async BindGv_cc_CourseKnowledges4Func() {
            if (cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.sortcc_CourseKnowledgesBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortcc_CourseKnowledgesBy)为空，请检查！(In BindGv_cc_CourseKnowledges_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.divName4DataList;
            var objcc_CourseKnowledges_Cond = await this.Combinecc_CourseKnowledgesConditionObj();
            objcc_CourseKnowledges_Cond.SetCondFldValue(clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN.con_CourseId, cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache, "=");
            var strWhereCond = JSON.stringify(objcc_CourseKnowledges_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrcc_CourseKnowledgesExObjLst = [];
            try {
                this.recCount = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_GetRecCountByCond_Cache)(objcc_CourseKnowledges_Cond, cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.sortcc_CourseKnowledgesBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrcc_CourseKnowledgesExObjLst = await (0, clscc_CourseKnowledgesExWApi_js_1.cc_CourseKnowledgesEx_GetObjExLstByPager_Cache)(objPagerPara, cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache);
                //arrcc_CourseKnowledgesExObjLst = arrcc_CourseKnowledgesObjLst.map(this.CopyToEx);
                //for (var objInFor of arrcc_CourseKnowledgesExObjLst) {
                //    const conFuncMap = await this.FuncMap(objInFor);
                //}
            }
            catch (e) {
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrcc_CourseKnowledgesExObjLst.length == 0) {
                var strKey = `${clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN._CurrTabName}_${cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_cc_CourseKnowledges4Func(strListDiv, arrcc_CourseKnowledgesExObjLst);
                console.log("完成BindGv_cc_CourseKnowledges4Func!");
            }
            catch (e) {
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /// <summary>
        /// 把一个扩展类的部分属性进行函数转换
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
        /// </summary>
        /// <param name = "objcc_CourseKnowledgesS">源对象</param>
        async FuncMap(objcc_CourseKnowledges) {
            try {
                {
                    var cc_CourseChapter_CourseChapterId = objcc_CourseKnowledges.courseChapterId;
                    var cc_CourseChapter_ChapterName = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_func)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName, cc_CourseChapter_CourseChapterId, objcc_CourseKnowledges.courseId);
                    objcc_CourseKnowledges.courseChapterName = cc_CourseChapter_ChapterName;
                }
                ;
                {
                    var KnowledgeType_KnowledgeTypeId = objcc_CourseKnowledges.knowledgeTypeId;
                    var KnowledgeType_KnowledgeTypeName = await (0, clsKnowledgeTypeWApi_js_1.KnowledgeType_func)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName, KnowledgeType_KnowledgeTypeId, objcc_CourseKnowledges.courseId);
                    objcc_CourseKnowledges.knowledgeTypeName = KnowledgeType_KnowledgeTypeName;
                }
                ;
                {
                    var strCourseKnowledgeId = objcc_CourseKnowledges.courseKnowledgeId;
                    var objcc_KnowledgesExamLibRela_Cond = new clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN;
                    objcc_KnowledgesExamLibRela_Cond.SetCondFldValue(clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.con_CourseKnowledgeId, strCourseKnowledgeId, "=");
                    var intQuestionNum = await (0, clscc_KnowledgesExamLibRelaWApi_js_1.cc_KnowledgesExamLibRela_GetRecCountByCond_Cache)(objcc_KnowledgesExamLibRela_Cond, objcc_CourseKnowledges.courseId);
                    objcc_CourseKnowledges.questionNum = intQuestionNum;
                }
                ;
            }
            catch (e) {
                var strMsg = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
    */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
            var strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId; //定义条件字段
            const ddlCourseChapterId_q = await this.SetDdl_CourseChapterIdInDiv(strCourseId); //查询区域
        }
        //设置添加知识点类型；
        async btnAddKnowType_Click() {
            var objPage = new cc_CourseKnowledgesCRUDEx();
            var objPage_Edit = new KnowledgeType_EditEx_js_1.KnowledgeType_EditEx(objPage);
            objPage_Edit.btnAddNewRecordWithMaxId_Click();
        }
        /* 显示cc_CourseKnowledges对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
       <param name = "divContainer">显示容器</param>
       <param name = "arrcc_CourseKnowledgesExObjLst">需要绑定的对象列表</param>
     */
        async BindTab_cc_CourseKnowledges4Func(divContainer, arrcc_CourseKnowledgesExObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "",
                    text: "",
                    tdClass: "text-left",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "orderNum",
                    sortBy: "orderNum", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "序号",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: () => { }
                },
                {
                    fldName: "knowledgeName",
                    sortBy: "knowledgeName", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "知识点名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: () => { }
                },
                {
                    fldName: clscc_CourseKnowledgesENEx_js_1.clscc_CourseKnowledgesENEx.con_CourseChapterName,
                    sortBy: "courseChapterId", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "课程章节",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: () => { }
                },
                {
                    fldName: "userId",
                    sortBy: "userId", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "用户ID",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: () => { }
                },
                {
                    fldName: clscc_CourseKnowledgesENEx_js_1.clscc_CourseKnowledgesENEx.con_KnowledgeTypeName,
                    sortBy: clscc_CourseKnowledgesENEx_js_1.clscc_CourseKnowledgesENEx.con_KnowledgeTypeName,
                    getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "知识点类型名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: () => { }
                },
                {
                    fldName: "isShow",
                    sortBy: "isShow", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "是否启用",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: () => { }
                },
                //{
                //    fldName: "LikeCount",
                //    sortBy: "LikeCount",
                //    colHeader: "资源喜欢数量",
                //    text: "",
                //    tdClass: "text-left",
                //    columnType: "Label",
                //    orderNum: 8,
                //    funcName: () => { }
                //},
                {
                    fldName: "updDate",
                    sortBy: "updDate", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: () => { }
                },
                {
                    fldName: clscc_CourseKnowledgesENEx_js_1.clscc_CourseKnowledgesENEx.con_QuestionNum,
                    sortBy: clscc_CourseKnowledgesENEx_js_1.clscc_CourseKnowledgesENEx.con_QuestionNum,
                    getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "题目数",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: () => { }
                },
                //{
                //    fldName: "updUser",
                //    sortBy: "updUser",
                //    colHeader: "修改人",
                //    text: "",
                //    tdClass: "text-left",
                //    columnType: "Label",
                //    orderNum: 10,
                //    funcName: () => { }
                //},
            ];
            await this.ExtendFldFuncMap(arrcc_CourseKnowledgesExObjLst, arrDataColumn);
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrcc_CourseKnowledgesExObjLst, arrDataColumn, "courseKnowledgeId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /*
        重序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
        */
        async btnReOrder_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strCourseChapterId = this.courseChapterId_q;
            if (strCourseChapterId == "0") {
                var strMsg = `没有选择章节，请选择一下章节！`;
                alert(strMsg);
                return;
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "courseChapterId": strCourseChapterId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_ReOrderAsync)(objOrderByData);
                (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_ReFreshCache)(cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache);
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseKnowledges4Func();
        }
        /*
        置底
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoBottum_Click)
        */
        async btnGoBottum_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strCourseChapterId = this.courseChapterId_q;
            if (strCourseChapterId == "0") {
                var strMsg = `没有选择章节，请选择一下章节！`;
                alert(strMsg);
                return;
            }
            var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4DataList);
            if (arrKeyIds.length == 0) {
                alert("请选择需要置底的记录！");
                return "";
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "courseChapterId": strCourseChapterId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_GoBottomAsync)(objOrderByData);
                (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_ReFreshCache)(cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache);
            }
            catch (e) {
                var strMsg = `置底出错。错误:${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseKnowledges4Func();
            var strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Web_js_1.SetCkechedItem4KeyId)(strListDiv, e));
        }
        /*
        移动记录序号时的预检查函数
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
        */
        PreCheck4Order() {
            var strCourseChapterId = this.courseChapterId_q;
            if (strCourseChapterId == "") {
                var strMsg = `请输入courseChapterId!`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return false;
            }
            return true;
        }
        /*
        下移
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
        */
        async btnDownMove_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strCourseChapterId = this.courseChapterId_q;
            if (strCourseChapterId == "0") {
                var strMsg = `没有选择章节，请选择一下章节！`;
                alert(strMsg);
                return;
            }
            var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4DataList);
            if (arrKeyIds.length == 0) {
                alert(`请选择需要下移的记录!`);
                return;
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "courseChapterId": strCourseChapterId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_DownMoveAsync)(objOrderByData);
                (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_ReFreshCache)(cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache);
            }
            catch (e) {
                var strMsg = `下移记录出错。错误:${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseKnowledges4Func();
            var strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Web_js_1.SetCkechedItem4KeyId)(strListDiv, e));
        }
        /*
        上移
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
        */
        async btnUpMove_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strCourseChapterId = this.courseChapterId_q;
            if (strCourseChapterId == "0") {
                var strMsg = `没有选择章节，请选择一下章节！`;
                alert(strMsg);
                return;
            }
            var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4DataList);
            if (arrKeyIds.length == 0) {
                alert(`请选择需要上移的记录!`);
                return;
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "courseChapterId": strCourseChapterId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_UpMoveAsync)(objOrderByData);
                (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_ReFreshCache)(cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache);
            }
            catch (e) {
                var strMsg = `上移记录出错。错误:${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseKnowledges4Func();
            var strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Web_js_1.SetCkechedItem4KeyId)(strListDiv, e));
        }
        /* 置顶
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoTop_Click)
        */
        async btnGoTop_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strCourseChapterId = this.courseChapterId_q;
            if (strCourseChapterId == "0") {
                var strMsg = `没有选择章节，请选择一下章节！`;
                alert(strMsg);
                return;
            }
            var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4DataList);
            if (arrKeyIds.length == 0) {
                alert("请选择需要置顶的记录！");
                return "";
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "courseChapterId": strCourseChapterId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_GoTopAsync)(objOrderByData);
                (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_ReFreshCache)(cc_CourseKnowledgesCRUD_js_1.cc_CourseKnowledgesCRUD.CourseId_Cache);
            }
            catch (e) {
                var strMsg = `置顶出错。错误:${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseKnowledges4Func();
            var strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Web_js_1.SetCkechedItem4KeyId)(strListDiv, e));
        }
    }
    exports.cc_CourseKnowledgesCRUDEx = cc_CourseKnowledgesCRUDEx;
    //public static divName4List: string = "divDataLst";
    //public static mstrSortcc_CourseKnowledgesBy: string = "courseKnowledgeId";
    cc_CourseKnowledgesCRUDEx.strCourseId_Cache = clsPublocalStorage_js_1.clsPublocalStorage.courseId; //缓存分类字段
});
