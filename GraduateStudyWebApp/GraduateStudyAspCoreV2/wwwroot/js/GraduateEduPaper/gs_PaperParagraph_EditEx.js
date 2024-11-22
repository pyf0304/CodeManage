(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/gs_PaperParagraphCRUD.js", "../PagesBase/GraduateEduPaper/gs_PaperParagraph_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/FunClass/clsPublicParagraph.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVerEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphVerWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperParagraph_EditEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_PaperParagraph_EditEx
    表名:gs_PaperParagraph(01120744)
    生成代码版本:2020.09.09.1
    生成日期:2020/09/23 22:47:04
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
    //
    //import * as QQ from "q";
    const gs_PaperParagraphCRUD_js_1 = require("../PagesBase/GraduateEduPaper/gs_PaperParagraphCRUD.js");
    const gs_PaperParagraph_Edit_js_1 = require("../PagesBase/GraduateEduPaper/gs_PaperParagraph_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPublicParagraph_js_1 = require("../TS/FunClass/clsPublicParagraph.js");
    const clsgs_PaperParagraphEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js");
    const clsgs_PaperParagraphVerEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVerEN.js");
    const clsvgs_PaperParagraphEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js");
    const clsgs_PaperParagraphVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphVerWApi.js");
    const clsgs_PaperParagraphWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* gs_PaperParagraph_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class gs_PaperParagraph_EditEx extends gs_PaperParagraph_Edit_js_1.gs_PaperParagraph_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            var objPage = gs_PaperParagraph_EditEx.objPage_Edit;
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
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(gs_PaperParagraph_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
    */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_gs_PaperParagraph;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "Add") {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.HideDialog_gs_PaperParagraph();
                                    this.iShowList.BindGv(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnKeyId = jsonData;
                                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                    //存放返回主键
                                    $("#hidParagraphId").val(returnKeyId);
                                    this.keyId = returnKeyId;
                                    //HideDialog_gs_PaperParagraph();
                                    this.btnReOrder_Click();
                                    //this.iShowList.BindGv(clsvgs_PaperParagraphEN._CurrTabName);
                                }
                            });
                            //添加历史版本
                            const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    this.HideDialog_gs_PaperParagraph();
                                    this.iShowList.BindGv(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In gs_PaperParagraph_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                //HideDialog_gs_PaperParagraph();
                                //this.iShowList.BindGv(clsvgs_PaperParagraphEN._CurrTabName);
                            }
                        });
                        //修改记录的同时添加历史版本
                        const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                this.HideDialog_gs_PaperParagraph();
                                this.iShowList.BindGv(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName, "");
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
        /*
    重序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
    */
        async btnReOrder_Click() {
            if (this.PreCheck4Order() == false)
                return;
            //var strSectionId: string = gs_PaperParagraphCRUD.SectionId_OrderNum;
            var strSectionId = $("#hidSectionId").val();
            var strPaperId = $("#hidPaperId").val();
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "sectionId": strSectionId,
                    "paperId": strPaperId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_ReOrderAsync)(objOrderByData);
                //gs_PaperParagraph_ReFreshCache();
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            this.iShowList.BindGv(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName, "");
        }
        /*
    移动记录序号时的预检查函数
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
    */
        PreCheck4Order() {
            var strSectionId = gs_PaperParagraphCRUD_js_1.gs_PaperParagraphCRUD.SectionId_OrderNum;
            if (strSectionId == "") {
                var strMsg = `请输入sectionId!`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            //
            var objgs_PaperParagraphEN = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
            objgs_PaperParagraphEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd()); // 修改日期
            objgs_PaperParagraphEN.SetCreateUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); //用户
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strColorCode = $("#hidUserColorCode").val();
            //如果是添加段落，那么肯定是第一条记录，只需要把当前用户的色码块通过html标签加入到段落内容；
            this.paragraphContent = "<span style='color:" + strColorCode + "' name='" + strUserId + "'>" + this.paragraphContent + "</span>";
            this.PutDataTogs_PaperParagraphClass(objgs_PaperParagraphEN);
            try {
                const responseKeyId = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_AddNewRecordWithMaxIdAsync)(objgs_PaperParagraphEN);
                var returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    //gs_PaperParagraph_ReFreshCache();
                    var strInfo = `添加记录成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseKeyId; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            return ""; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
       (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
       <param name = "pobjgs_PaperParagraphEN">数据传输的目的类对象</param>
     */
        async PutDataTogs_PaperParagraphClass(pobjgs_PaperParagraphEN) {
            //存放论文ID
            var strPaperId = $("#hidPaperId").val();
            //节点Id
            var strSectionId = $("#hidSectionId").val();
            pobjgs_PaperParagraphEN.SetPaperId(strPaperId);
            pobjgs_PaperParagraphEN.SetSectionId(strSectionId);
            pobjgs_PaperParagraphEN.SetParagraphTypeId(this.paragraphTypeId); // 段落类型
            //根据下拉框的选择值 来判断存内容还是图片
            if (this.paragraphTypeId == "01") {
                pobjgs_PaperParagraphEN.SetParagraphContent(this.paragraphContent); // 段落内容
            }
            else {
                //图片，那么需要获取隐藏图片的返回字段
                var strfileNamePic = $("#hdnFileOne").val();
                pobjgs_PaperParagraphEN.SetParagraphContent(strfileNamePic); // 段落内容
            }
            var orderNum = $("#hidOrderNum").val();
            if (orderNum != "" && orderNum != "0") {
                pobjgs_PaperParagraphEN.SetOrderNum(orderNum);
            }
            else {
                pobjgs_PaperParagraphEN.SetOrderNum(30);
            }
            pobjgs_PaperParagraphEN.SetParagraphStateId("01"); //01未编辑 02 编辑中
            pobjgs_PaperParagraphEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd()); // 修改日期
            pobjgs_PaperParagraphEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); //用户
            pobjgs_PaperParagraphEN.SetMemo(this.memo); // 备注
        }
        /* 修改记录
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            //
            var objgs_PaperParagraphEN = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
            objgs_PaperParagraphEN.SetParagraphId(this.keyId);
            var strHisToryUserId = "";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //修改段落，那么首先需要查询该段落的最后一条历史记录，得到段落数据，然后取出来与当前段落数据比较，返回更改的段落数据
            var strWhereCond2 = " 1=1 and paragraphId=" + this.keyId + " order by ParagraphVId desc ";
            // var intVersionCount = await gs_PaperParagraphVer_GetRecCountByCondAsync(strWhereCond2);
            const responseText = await (0, clsgs_PaperParagraphVerWApi_js_1.gs_PaperParagraphVer_GetFirstObjAsync)(strWhereCond2).then((jsonData) => {
                var objgs_PaperParagraphVerEN = jsonData;
                if (objgs_PaperParagraphVerEN != null) {
                    //需要去标签的更改数据存放
                    $("#inpLeft").val(objgs_PaperParagraphVerEN.paragraphContent);
                    //存放老的带标签的数据不更改
                    $("#inpOldData").val(objgs_PaperParagraphVerEN.paragraphContent);
                    strHisToryUserId = objgs_PaperParagraphVerEN.updUser;
                }
            });
            ////如果当前修改的编辑人和获取的历史编辑人一致，那么则不用比对数据
            //if (strHisToryUserId != strUserId) {
            //    //调用比较方法
            //    startCompare();
            //    //比较之后，把返回结果赋值给操作段落控件
            //    this.paragraphContent = $("#inpRight").val();
            //}
            //else {
            //}
            //调用比较方法，得到有差别的字符串；
            startCompare();
            //返回比对后的字符串数据；
            //var strOld = $("#inpLeft").val();
            var strInputNewContent = $("#txtParagraphContent").val();
            var strCheckBackNew = $("#inpRight").val();
            var strNewTextContent = clsPublicParagraph_js_1.clsPublicParagraph.GetNewStringList(strInputNewContent, strCheckBackNew);
            //把得到新的数据存入编辑控件
            $("#txtParagraphContent").val(strNewTextContent);
            this.PutDataTogs_PaperParagraphClass(objgs_PaperParagraphEN);
            objgs_PaperParagraphEN.sf_UpdFldSetStr = objgs_PaperParagraphEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_PaperParagraphEN.paragraphId == "" || objgs_PaperParagraphEN.paragraphId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_UpdateRecordAsync)(objgs_PaperParagraphEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //gs_PaperParagraph_ReFreshCache();
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
        /* 函数功能:把类对象的属性内容显示到界面上
       注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        如果在设置数据库时,就应该一级字段在前,二级字段在后
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        <param name = "pobjgs_PaperParagraphEN">表实体类对象</param>
      */
        GetDataFromgs_PaperParagraphClass(pobjgs_PaperParagraphEN) {
            //存放论文ID
            $("#hidPaperId").val(pobjgs_PaperParagraphEN.paperId);
            //节点Id
            $("#hidSectionId").val(pobjgs_PaperParagraphEN.sectionId);
            this.paragraphTypeId = pobjgs_PaperParagraphEN.paragraphTypeId; // 段落类型
            $("#hidParagraphId").val(pobjgs_PaperParagraphEN.paragraphId);
            $("#hidOrderNum").val(pobjgs_PaperParagraphEN.orderNum);
            //根据下拉框的选择值 来判断存内容还是图片
            if (this.paragraphTypeId == "01") {
                $("#trParagraphContent").show();
                this.paragraphContent = pobjgs_PaperParagraphEN.paragraphContent; // 段落内容
            }
            else {
                $("#trParagraphPic").show();
                //图片，那么需要获取隐藏图片的返回字段
                $("#hdnFileOne").val(pobjgs_PaperParagraphEN.paragraphContent); // 段落内容图片
            }
            //this.paragraphContent = pobjgs_PaperParagraphEN.paragraphContent;// 段落内容
            this.memo = pobjgs_PaperParagraphEN.memo; // 备注
            setTextboxio();
        }
        /* 添加新记录
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
    */
        async btnAddNewParagraph_Click(strPaperId, strSectionId, orderNum, colorCode) {
            try {
                const responseBool = await this.btnAddNewRecordWithMaxId_Click();
                this.opType = "AddWithMaxId";
                //存放论文ID
                $("#hidPaperId").val(strPaperId);
                //节点Id
                $("#hidSectionId").val(strSectionId);
                $("#hidOrderNum").val(orderNum);
                $("#hidUserColorCode").val(colorCode);
                $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        async btnUpdategs_PaperParagraph_Click(paragraphId, colorCode) {
            try {
                this.keyId = paragraphId;
                const responseBool = await this.btnUpdateRecordInTab_Click(paragraphId);
                $("#hidParagraphId").val(paragraphId);
                $("#hidUserColorCode").val(colorCode);
                $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        //添加或修改时 历史记录；
        //添加历史版本
        async AddVersionRecordSave() {
            const strThisFuncName = this.AddVersionRecordSave.name;
            //
            var objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN_js_1.clsgs_PaperParagraphVerEN();
            var strParagraphId = $("#hidParagraphId").val();
            objgs_PaperParagraphVerEN.SetParagraphId(strParagraphId);
            this.PutDataTogs_PaperParagraphVClass(objgs_PaperParagraphVerEN);
            try {
                const responseText2 = await (0, clsgs_PaperParagraphVerWApi_js_1.gs_PaperParagraphVer_AddNewRecordAsync)(objgs_PaperParagraphVerEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1=1 and paragraphId=" + strParagraphId;
                    var intVersionCount = await (0, clsgs_PaperParagraphVerWApi_js_1.gs_PaperParagraphVer_GetRecCountByCondAsync)(strWhereCond2);
                    var objgs_PaperParagraphEN = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
                    objgs_PaperParagraphEN.SetParagraphId(strParagraphId);
                    objgs_PaperParagraphEN.SetVersionCount(intVersionCount);
                    objgs_PaperParagraphEN.sf_UpdFldSetStr = objgs_PaperParagraphEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objgs_PaperParagraphEN.paragraphId == "" || objgs_PaperParagraphEN.paragraphId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_UpdateRecordAsync)(objgs_PaperParagraphEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            return true;
                        }
                        else {
                            var strInfo = `添加历史版本数不成功!`;
                            alert(strInfo);
                            console.log("添加历史版本数不成功");
                            return false;
                        }
                    });
                    return true;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加版本记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_PaperParagraphEN">数据传输的目的类对象</param>
    */
        PutDataTogs_PaperParagraphVClass(pobjgs_PaperParagraphEN) {
            //存放论文ID
            var strPaperId = $("#hidPaperId").val();
            //段落ID
            //var strParagraphId = $("#hidParagraphId").val();
            //pobjgs_PaperParagraphEN.SetParagraphId(strParagraphId);//段落Id
            pobjgs_PaperParagraphEN.SetPaperId(strPaperId);
            //节点Id
            var strSectionId = $("#hidSectionId").val();
            pobjgs_PaperParagraphEN.SetParagraphTypeId(this.paragraphTypeId); // 段落类型
            //根据下拉框的选择值 来判断存内容还是图片
            if (this.paragraphTypeId == "01") {
                pobjgs_PaperParagraphEN.SetParagraphContent(this.paragraphContent); // 段落内容
            }
            else {
                //图片，那么需要获取隐藏图片的返回字段
                var strfileNamePic = $("#hdnFileOne").val();
                pobjgs_PaperParagraphEN.SetParagraphContent(strfileNamePic); // 段落内容
            }
            pobjgs_PaperParagraphEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd()); // 修改日期
            pobjgs_PaperParagraphEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); //用户
            pobjgs_PaperParagraphEN.SetSectionId(strSectionId); // 修改日期
            pobjgs_PaperParagraphEN.SetMemo(this.memo); // 备注
        }
    }
    exports.gs_PaperParagraph_EditEx = gs_PaperParagraph_EditEx;
});
