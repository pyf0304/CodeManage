(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/Knowledges_Share/cc_CourseKnowledges_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js", "../TS/L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js", "../TS/L3_ForWApiEx/Knowledges_Share/clscc_CourseChapterExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseKnowledges_EditEx = void 0;
    const cc_CourseKnowledges_Edit_js_1 = require("../PagesBase/Knowledges_Share/cc_CourseKnowledges_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clscc_CourseChapterEN_js_1 = require("../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js");
    const clscc_CourseKnowledgesEN_js_1 = require("../TS/L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js");
    const clscc_CourseChapterExWApi_js_1 = require("../TS/L3_ForWApiEx/Knowledges_Share/clscc_CourseChapterExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* cc_CourseKnowledges_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class cc_CourseKnowledges_EditEx extends cc_CourseKnowledges_Edit_js_1.cc_CourseKnowledges_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            var objPage = cc_CourseKnowledges_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
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
                    var strMsg = '命令:' + strCommandName + "在函数(cc_CourseKnowledges_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
    */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_cc_CourseKnowledges;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.HideDialog_cc_CourseKnowledges();
                                    this.iShowList.BindGv(clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnKeyId = jsonData;
                                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                    this.HideDialog_cc_CourseKnowledges();
                                    this.iShowList.BindGv(clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In cc_CourseKnowledges_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                this.HideDialog_cc_CourseKnowledges();
                                this.iShowList.BindGv(clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN._CurrTabName, "");
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
    */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId; //定义条件字段
            const ddlCourseChapterId = await this.SetDdl_CourseChapterIdInDiv(strCourseId); //编辑区域
        }
        /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
    */
        async BindDdl4EditRegionInDiv() {
            // 在此处放置用户代码以初始化页面
            var strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId; //定义条件字段
            const ddlKnowledgeTypeId = await this.SetDdl_KnowledgeTypeIdInDiv(); //编辑区域
            const ddlCourseChapterId = await this.SetDdl_CourseChapterIdInDiv(strCourseId); //编辑区域
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[courseChapterId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TSInDiv)
        /// </summary>
        async SetDdl_CourseChapterIdInDiv(strCourseId) {
            var objcc_CourseChapter_Cond = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN(); //编辑区域
            //定义条件字段
            //var strCourseId = "";//定义条件字段
            const ddlCourseChapterId = await (0, clscc_CourseChapterExWApi_js_1.cc_CourseChapterEx_BindDdl_CourseChapterIdInDiv_Cache)(this.divName4Edit, "ddlCourseChapterId", strCourseId); //编辑区域
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjcc_CourseKnowledgesEN">数据传输的目的类对象</param>
      */
        async PutDataTocc_CourseKnowledgesClass(pobjcc_CourseKnowledgesEN) {
            pobjcc_CourseKnowledgesEN.SetKnowledgeName(this.knowledgeName); // 知识点名称
            pobjcc_CourseKnowledgesEN.SetKnowledgeTitle(this.knowledgeTitle); // 知识点标题
            pobjcc_CourseKnowledgesEN.SetCourseChapterId(this.courseChapterId); // 课程章节
            pobjcc_CourseKnowledgesEN.SetKnowledgeTypeId(this.knowledgeTypeId); // 知识点类型
            pobjcc_CourseKnowledgesEN.SetKnowledgeContent(this.knowledgeContent); // 知识点内容
            pobjcc_CourseKnowledgesEN.SetCourseId(clsPublocalStorage_js_1.clsPublocalStorage.courseId);
            pobjcc_CourseKnowledgesEN.SetUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            pobjcc_CourseKnowledgesEN.SetIsShow(true);
            pobjcc_CourseKnowledgesEN.SetMemo(this.memo); // 备注
            pobjcc_CourseKnowledgesEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
        }
    }
    exports.cc_CourseKnowledges_EditEx = cc_CourseKnowledges_EditEx;
});
