(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./cc_CourseChapter_EditEx.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsPublocalStorage.js", "../PagesBase/Knowledges_Share/cc_CourseChapterCRUD.js", "../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseChapterCRUDEx = void 0;
    const cc_CourseChapter_EditEx_js_1 = require("./cc_CourseChapter_EditEx.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const cc_CourseChapterCRUD_js_1 = require("../PagesBase/Knowledges_Share/cc_CourseChapterCRUD.js");
    const clscc_CourseChapterWApi_js_1 = require("../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* cc_CourseChapterCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class cc_CourseChapterCRUDEx extends cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD {
        //public static divName4List: string = "divDataLst";
        //public static mstrSortcc_CourseChapterBy: string = "courseChapterId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType) {
            (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_ReFreshCache)(cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD.CourseId_Cache);
            this.BindGv_cc_CourseChapter4Func();
        }
        BindGv_Cache(strType) {
            switch (strType) {
                case "cc_CourseChapter":
                    alert('该类没有绑定该函数：[this.BindGv_cc_CourseChapter4Func]！');
                    //this.BindGv_cc_CourseChapter4Func();
                    break;
                default:
                    var strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！");
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /*
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        async DelRecord(strCourseChapterId) {
            try {
                const responseText = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_DelRecordAsync)(strCourseChapterId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_ReFreshCache)(cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD.CourseId_Cache);
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
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
    */
        async DelMultiRecord(arrCourseChapterId) {
            try {
                const responseText = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_Delcc_CourseChaptersAsync)(arrCourseChapterId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_ReFreshCache)(cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD.CourseId_Cache);
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
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD.objPage_CRUD == null) {
                cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD.objPage_CRUD = new cc_CourseChapterCRUDEx();
                objPage = cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD.objPage_CRUD;
            }
            else {
                objPage = cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD.objPage_CRUD;
            }
            const objPage_Edit = new cc_CourseChapter_EditEx_js_1.cc_CourseChapter_EditEx(objPage);
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
                    // objPage_Edit.btnUpdateRecord_Click();
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
                    strMsg = '命令:' + strCommandName + "在函数(cc_CourseChapterCRUDEx.btn_Click)中没有被处理！";
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
                cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD.CourseId_Cache = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
                this.SetEventFunc();
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                cc_CourseChapterCRUD_js_1.cc_CourseChapterCRUD.sortcc_CourseChapterBy = "courseChapterName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
    }
    exports.cc_CourseChapterCRUDEx = cc_CourseChapterCRUDEx;
});
