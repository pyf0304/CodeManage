(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvSectionEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString2.js", "./Section_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Section_EditEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:Section_EditEx
    表名:Section(01120558)
    生成代码版本:2020.09.24.1
    生成日期:2020/09/26 20:48:55
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培论文
    模块英文名:GraduateEduPaper
    框架-层名:WA_编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsSectionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js");
    const clsvSectionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvSectionEN.js");
    const clsSectionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const Section_Edit_js_1 = require("./Section_Edit.js");
    /* Section_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class Section_EditEx extends Section_Edit_js_1.Section_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            var objPage = Section_EditEx.objPage_Edit;
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
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(Section_EditExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_Section;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.OpType == "Add") {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog_Section();
                                    this.iShowList.BindGv(clsvSectionEN_js_1.clsvSectionEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnKeyId = jsonData;
                                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                                    HideDialog_Section();
                                    this.btnReOrder_Click();
                                    this.iShowList.BindGv(clsvSectionEN_js_1.clsvSectionEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In Section_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog_Section();
                                this.btnReOrder_Click();
                                this.iShowList.BindGv(clsvSectionEN_js_1.clsvSectionEN._CurrTabName, "");
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
        /* 函数功能:把界面上的属性数据传到类对象中
       (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
       <param name = "pobjSectionEN">数据传输的目的类对象</param>
     */
        PutDataToSectionClass(pobjSectionEN) {
            //存放论文ID
            var strPaperId = $("#hidPaperId").val();
            //父节点Id
            var parentId = $("#hidParentId").val();
            //排序号
            var orderNum = $("#hidOrderNum").val();
            if (orderNum != "" && orderNum != "0") {
                pobjSectionEN.orderNum = orderNum;
            }
            else {
                pobjSectionEN.orderNum = 30;
            }
            pobjSectionEN.sectionName = this.sectionName; // 节名
            pobjSectionEN.paperId = strPaperId;
            pobjSectionEN.parentId = parentId;
            pobjSectionEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改人
        }
        /* 函数功能:把类对象的属性内容显示到界面上
       注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        如果在设置数据库时,就应该一级字段在前,二级字段在后
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        <param name = "pobjSectionEN">表实体类对象</param>
      */
        GetDataFromSectionClass(pobjSectionEN) {
            //存放论文ID
            $("#hidPaperId").val(pobjSectionEN.paperId);
            //父节点Id
            $("#hidParentId").val(pobjSectionEN.parentId);
            //排序号
            $("#hidOrderNum").val(pobjSectionEN.orderNum);
            this.sectionName = pobjSectionEN.sectionName; // 节名
        }
        /* 添加新记录
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
    */
        async btnAddNewSection_Click(strPaperId, parentId) {
            try {
                const responseBool = await this.btnAddNewRecordWithMaxId_Click();
                this.OpType = "AddWithMaxId";
                //存放论文ID
                $("#hidPaperId").val(strPaperId);
                //父节点Id
                $("#hidParentId").val(parentId);
                //判断传入的父节点，然后显示不同的提示名称；例如 root 显示章名称；否则就是添加节名称；
                if (parentId == "root") {
                    $("#lblSectionName").html("章名称");
                }
                else {
                    $("#lblSectionName").html("节名称");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        async btnUpdateSection_Click(sectionId) {
            try {
                this.KeyId = sectionId;
                const responseBool = await this.btnUpdateRecordInTab_Click(sectionId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objSectionEN = new clsSectionEN_js_1.clsSectionEN();
            objSectionEN.sectionId = this.KeyId;
            this.PutDataToSectionClass(objSectionEN);
            objSectionEN.sf_UpdFldSetStr = objSectionEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSectionEN.sectionId == "" || objSectionEN.sectionId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsSectionWApi_js_1.Section_UpdateRecordAsync)(objSectionEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //Section_ReFreshCache();
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /*
    重序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
    */
        async btnReOrder_Click() {
            // if (this.PreCheck4Order() == false) return;
            var strSectionId = $("#hidParentId").val();
            var strPaperId = $("#hidPaperId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "parentId": strSectionId,
                    "paperId": strPaperId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsSectionWApi_js_1.Section_ReOrderAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            this.iShowList.BindGv(clsvSectionEN_js_1.clsvSectionEN._CurrTabName, "");
        }
        /*
        /*
           * 设置关键字的值(Used In UpdateRecord())
          */
        set KeyId(value) {
            $("#hidKeyId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get KeyId() {
            return $("#hidKeyId").val();
        }
    }
    exports.Section_EditEx = Section_EditEx;
});
