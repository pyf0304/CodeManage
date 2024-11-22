(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../PagesBase/Knowledges_Share/cc_CourseChapter_Edit.js", "../TS/PubFun/clsString.js", "../TS/PubFun/clsCommFunc4Ctrl.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseChapter_EditEx = void 0;
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const cc_CourseChapter_Edit_js_1 = require("../PagesBase/Knowledges_Share/cc_CourseChapter_Edit.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    /* cc_CourseChapter_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class cc_CourseChapter_EditEx extends cc_CourseChapter_Edit_js_1.cc_CourseChapter_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            this.CourseId_Cache = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
            var objPage = cc_CourseChapter_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    //objPage.btnUpdateRecord_Click();
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)("divList");
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        var strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    objPage.btnUpdateRecord_Click(strKeyId);
                    break;
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(cc_CourseChapter_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjcc_CourseChapterEN">数据传输的目的类对象</param>
       */
        async PutDataTocc_CourseChapterClass(pobjcc_CourseChapterEN) {
            pobjcc_CourseChapterEN.SetCourseChapterName(this.courseChapterName); // 课程章节名称
            pobjcc_CourseChapterEN.SetChapterName(this.chapterName); // 章名
            pobjcc_CourseChapterEN.SetSectionName(this.sectionName); // 节名
            pobjcc_CourseChapterEN.SetChapterName_Sim(this.chapterName_Sim); // 章名简称
            pobjcc_CourseChapterEN.SetSectionName_Sim(this.sectionName_Sim); // 节名简称
            pobjcc_CourseChapterEN.SetCourseId(clsPublocalStorage_js_1.clsPublocalStorage.courseId);
            pobjcc_CourseChapterEN.SetParentNodeID("00000000"); //根
            pobjcc_CourseChapterEN.SetIsOpenToAllStu(true);
            pobjcc_CourseChapterEN.SetIsOpenToSchool(true);
            pobjcc_CourseChapterEN.SetIsOpenToSocial(true);
            pobjcc_CourseChapterEN.SetIsMustMenu(true);
            pobjcc_CourseChapterEN.SetIsFile(true);
            pobjcc_CourseChapterEN.SetIsUse(this.isUse); // 是否使用
            pobjcc_CourseChapterEN.SetChapterContent(this.chapterContent); // 章节内容
            pobjcc_CourseChapterEN.SetMemo(this.memo); // 备注
            pobjcc_CourseChapterEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
        }
    }
    exports.cc_CourseChapter_EditEx = cc_CourseChapter_EditEx;
});
