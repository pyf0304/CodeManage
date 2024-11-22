(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./KnowledgeType_EditEx.js", "../PagesBase/Knowledges_Share/KnowledgeTypeCRUD.js", "../TS/L0_Entity/Knowledges_Share/clsKnowledgeTypeEN.js", "../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../TS/L3_ForWApiEx/Knowledges_Share/clsKnowledgeTypeExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "../PagesBase/Knowledges_Share/KnowledgeType_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.KnowledgeTypeCRUDEx = void 0;
    const KnowledgeType_EditEx_js_1 = require("./KnowledgeType_EditEx.js");
    const KnowledgeTypeCRUD_js_1 = require("../PagesBase/Knowledges_Share/KnowledgeTypeCRUD.js");
    const clsKnowledgeTypeEN_js_1 = require("../TS/L0_Entity/Knowledges_Share/clsKnowledgeTypeEN.js");
    const clsKnowledgeTypeWApi_js_1 = require("../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeExWApi_js_1 = require("../TS/L3_ForWApiEx/Knowledges_Share/clsKnowledgeTypeExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const KnowledgeType_Edit_js_1 = require("../PagesBase/Knowledges_Share/KnowledgeType_Edit.js");
    /* KnowledgeTypeCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class KnowledgeTypeCRUDEx extends KnowledgeTypeCRUD_js_1.KnowledgeTypeCRUD {
        //public static divName4List: string = "divDataLst";
        //public static mstrSortKnowledgeTypeBy: string = "knowledgeTypeId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType) {
            this.BindGv_KnowledgeType4Func();
        }
        BindGv_Cache(strType) {
            switch (strType) {
                case "KnowledgeType":
                    alert('该类没有绑定该函数：[this.BindGv_KnowledgeType_Cache]！');
                    //this.BindGv_KnowledgeType_Cache();
                    break;
                default:
                    var strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (KnowledgeTypeCRUD_js_1.KnowledgeTypeCRUD.objPage_CRUD == null) {
                KnowledgeTypeCRUD_js_1.KnowledgeTypeCRUD.objPage_CRUD = new KnowledgeTypeCRUDEx();
                objPage = KnowledgeTypeCRUD_js_1.KnowledgeTypeCRUD.objPage_CRUD;
            }
            else {
                objPage = KnowledgeTypeCRUD_js_1.KnowledgeTypeCRUD.objPage_CRUD;
            }
            const objPage_Edit = new KnowledgeType_EditEx_js_1.KnowledgeType_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    objPage_Edit.btnAddNewRecordWithMaxId_Click();
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
                    //objPage.btnCopyRecord_Click();
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
                    strMsg = '命令:' + strCommandName + "在函数(KnowledgeTypeCRUDEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombineKnowledgeTypeConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objKnowledgeType_Cond = new clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.knowledgeTypeName_q != "") {
                    strWhereCond += ` And ${clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName} like '% ${this.knowledgeTypeName_q}%'`;
                    objKnowledgeType_Cond.SetCondFldValue(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName, this.knowledgeTypeName_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(CombineKnowledgeTypeConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            objKnowledgeType_Cond.whereCond = strWhereCond;
            return objKnowledgeType_Cond;
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv4Func)
    */
        async BindGv_KnowledgeType4Func() {
            if (KnowledgeTypeCRUD_js_1.KnowledgeTypeCRUD.sortKnowledgeTypeBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortKnowledgeTypeBy)为空，请检查！(In BindGv_KnowledgeType_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.divName4DataList;
            var objKnowledgeType_Cond = await this.CombineKnowledgeTypeConditionObj();
            var strWhereCond = JSON.stringify(objKnowledgeType_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrKnowledgeTypeExObjLst = [];
            try {
                this.recCount = await (0, clsKnowledgeTypeWApi_js_1.KnowledgeType_GetRecCountByCond_Cache)(objKnowledgeType_Cond, clsPublocalStorage_js_1.clsPublocalStorage.courseId);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: KnowledgeTypeCRUD_js_1.KnowledgeTypeCRUD.sortKnowledgeTypeBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrKnowledgeTypeExObjLst = await (0, clsKnowledgeTypeExWApi_js_1.KnowledgeTypeEx_GetObjExLstByPager_Cache)(objPagerPara, clsPublocalStorage_js_1.clsPublocalStorage.courseId);
                //arrKnowledgeTypeExObjLst = arrKnowledgeTypeObjLst.map(this.CopyToEx);
                //for (var objInFor of arrKnowledgeTypeExObjLst) {
                //    const conFuncMap = await this.FuncMap(objInFor);
                //}
            }
            catch (e) {
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrKnowledgeTypeExObjLst.length == 0) {
                var strKey = `${clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_KnowledgeType4Func(strListDiv, arrKnowledgeTypeExObjLst);
                console.log("完成BindGv_KnowledgeType4Func!");
            }
            catch (e) {
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 函数功能:页面导入,当页面开始运行时所发生的事件
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
        **/
        async Page_Load() {
            const strThisFuncName = this.Page_Load.name;
            // 在此处放置用户代码以初始化页面
            try {
                KnowledgeTypeCRUD_js_1.KnowledgeTypeCRUD.CourseId_Cache = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
                KnowledgeType_Edit_js_1.KnowledgeType_Edit.CourseId_Cache = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
                this.SetEventFunc();
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                KnowledgeTypeCRUD_js_1.KnowledgeTypeCRUD.sortKnowledgeTypeBy = "knowledgeTypeName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_KnowledgeType4Func();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
    }
    exports.KnowledgeTypeCRUDEx = KnowledgeTypeCRUDEx;
});
