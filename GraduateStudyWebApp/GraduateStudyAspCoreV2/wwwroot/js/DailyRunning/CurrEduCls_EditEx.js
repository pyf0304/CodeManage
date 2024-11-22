(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/DailyRunning_Share/CurrEduCls_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js", "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js", "../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduCls_EditEx = void 0;
    /**
    * 类名:CurrEduCls_EditEx(界面:CurrEduClsCRUD1)
    * 表名:CurrEduCls(01120123)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/07 17:27:12
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:日常运行(DailyRunning)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const CurrEduCls_Edit_js_1 = require("../PagesBase/DailyRunning_Share/CurrEduCls_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js");
    const clsvCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js");
    const clsgs_TeachingDateEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js");
    const clsgs_TeachingDateWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* CurrEduCls_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class CurrEduCls_EditEx extends CurrEduCls_Edit_js_1.CurrEduCls_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = CurrEduCls_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(CurrEduCls_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
    */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_Click.name;
            try {
                //判断session是否失效
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            if (this.opType == "AddWithMaxId") {
                                const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                    var returnKeyId = jsonData;
                                    if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                        HideDialog();
                                        this.iShowList.BindGv(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName, returnKeyId);
                                    }
                                });
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        HideDialog();
                                        this.iShowList.BindGv(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName, returnBool.toString());
                                    }
                                });
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                strInfo += "(In CurrEduClsCRUD.btnOKUpd_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName, returnBool.toString());
                                }
                            });
                            break;
                        default:
                            var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    alert("登录超时，请重新登录");
                    window.top.location.href = "../Web/Login";
                }
                $("#divLoading").hide();
                //去掉提交按钮不可用状态
                $('#btnOKUpd').attr("disabled", "false");
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
    */
        async AddNewSetDate() {
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", "false");
            this.opType = "AddWithMaxId";
            //this.SetKeyReadOnly(false);
            this.btnSubmit_CurrEduCls = "确认添加";
            this.btnCancel_CurrEduCls = "取消添加";
            this.Clear();
        }
        /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
    */
        async btnUpdateRecord_Click(strKeyId) {
            this.opType = "Update";
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    ShowDialog('Update');
                    this.bolIsLoadEditRegion = true; //
                    this.UpdateRecord(strKeyId);
                }
                else {
                    ShowDialog('Update');
                    this.UpdateRecord(strKeyId);
                }
            }
            else if (strRoleId == "00620002") {
                //教师
                //修改前需要判断 数据是否是当前用户添加 是则可以修改，否则不可修改；
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjByid_CurrEduClsAsync)(strKeyId);
                var objCurrEduClsEN = responseText;
                if (objCurrEduClsEN.modifyUserID == strUserId) {
                    if (this.bolIsLoadEditRegion == false) //
                     {
                        const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                        // 为编辑区绑定下拉框
                        const conBindDdl = await this.BindDdl4EditRegionInDiv();
                        ShowDialog('Update');
                        this.bolIsLoadEditRegion = true; //
                        this.UpdateRecord(strKeyId);
                    }
                    else {
                        ShowDialog('Update');
                        this.UpdateRecord(strKeyId);
                    }
                }
                else {
                    var strInfo = `当前数据不是您添加，不可修改`;
                    //显示信息框
                    alert(strInfo);
                    return;
                }
            }
        }
        /* 为插入记录做准备工作
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
    */
        async AddNewRecord() {
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", "false");
            this.opType = "AddWithMaxId";
            //this.SetKeyReadOnly(false);
            this.btnSubmit_CurrEduCls = "确认添加";
            this.btnCancel_CurrEduCls = "取消添加";
            this.Clear();
            //wucCurrEduClsB1.id_CurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表CurrEduCls的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtid_CurrEduCls').val(returnString);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", "false");
            this.opType = "AddWithMaxId";
            //this.SetKeyReadOnly(false);
            this.btnSubmit_CurrEduCls = "确认添加";
            this.btnCancel_CurrEduCls = "取消添加";
            this.Clear();
            //wucCurrEduClsB1.id_CurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
        }
        //设置日期；
        async SetUpDate() {
            var strId_CurrEduCls = $("#txtid_CurrEduCls").val();
            var strCommandText = this.btnSubmit_Click.name;
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            var objgs_TeachingDateEN = new clsgs_TeachingDateEN_js_1.clsgs_TeachingDateEN();
                            objgs_TeachingDateEN.Setid_CurrEduCls(strId_CurrEduCls);
                            objgs_TeachingDateEN.SetStartDate(this.startDate);
                            objgs_TeachingDateEN.SetEndDate(this.endDate);
                            objgs_TeachingDateEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate());
                            objgs_TeachingDateEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                            // this.PutDataToConceptClass(objConceptEN);
                            objgs_TeachingDateEN.sf_UpdFldSetStr = objgs_TeachingDateEN.updFldString; //设置哪些字段被修改(脏字段)
                            try {
                                const responseText2 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_AddNewRecordAsync)(objgs_TeachingDateEN);
                                var returnBool = !!responseText2;
                                if (returnBool == true) {
                                    //更新教学班日期范围；把备注字段存放日期
                                    var objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
                                    objCurrEduClsEN.Setid_CurrEduCls(strId_CurrEduCls);
                                    objCurrEduClsEN.SetMemo(this.startDate + "-" + this.endDate);
                                    objCurrEduClsEN.sf_UpdFldSetStr = objCurrEduClsEN.updFldString; //设置哪些字段被修改(脏字段)
                                    const responseText3 = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_UpdateRecordAsync)(objCurrEduClsEN);
                                    var returnBool = !!responseText3;
                                    if (returnBool == true) {
                                        console.log("教学班更新成功");
                                        //数据同步；
                                        const responseText2 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync)(strId_CurrEduCls, clsPublocalStorage_js_1.clsPublocalStorage.userId);
                                        var returnBool2 = !!responseText2;
                                        if (returnBool2 == true) {
                                            console.log("同步成功");
                                        }
                                        else {
                                            console.log("同步失败");
                                        }
                                    }
                                    var strInfo = `设置成功!`;
                                    $('#lblResult46').val(strInfo);
                                    //显示信息框
                                    alert(strInfo);
                                    HideDialogOne();
                                }
                                else {
                                    var strInfo = `设置失败!`;
                                    $('#lblResult46').val(strInfo);
                                    //显示信息框
                                    alert(strInfo);
                                }
                                return responseText2; //一定要有一个返回值，否则会出错！
                            }
                            catch (e) {
                                console.error('catch(e)=');
                                console.error(e);
                                var strMsg = `添加记录不成功,${e}.`;
                                alert(strMsg);
                                return false; //一定要有一个返回值，否则会出错！
                            }
                            break;
                        case "确认修改":
                            var mId = $("#hidgs_DateId").val();
                            if (mId != "") {
                                //更新教学班日期表
                                var objgs_TeachingDateEN = new clsgs_TeachingDateEN_js_1.clsgs_TeachingDateEN();
                                objgs_TeachingDateEN.SetmId(mId);
                                objgs_TeachingDateEN.Setid_CurrEduCls(strId_CurrEduCls);
                                objgs_TeachingDateEN.SetStartDate(this.startDate);
                                objgs_TeachingDateEN.SetEndDate(this.endDate);
                                objgs_TeachingDateEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate());
                                objgs_TeachingDateEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                                objgs_TeachingDateEN.sf_UpdFldSetStr = objgs_TeachingDateEN.updFldString; //设置哪些字段被修改(脏字段)
                                const responseText2 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_UpdateRecordAsync)(objgs_TeachingDateEN);
                                var returnBool = !!responseText2;
                                if (returnBool == true) {
                                    console.log("教学班日期表更新成功");
                                    //更新教学班日期范围字段
                                    var objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
                                    objCurrEduClsEN.Setid_CurrEduCls(strId_CurrEduCls);
                                    objCurrEduClsEN.SetMemo(this.startDate + "-" + this.endDate);
                                    objCurrEduClsEN.sf_UpdFldSetStr = objCurrEduClsEN.updFldString; //设置哪些字段被修改(脏字段)
                                    const responseText3 = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_UpdateRecordAsync)(objCurrEduClsEN);
                                    var returnBool = !!responseText3;
                                    if (returnBool == true) {
                                        console.log("教学班更新范围成功");
                                        //数据同步；
                                        const responseText4 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync)(strId_CurrEduCls, clsPublocalStorage_js_1.clsPublocalStorage.userId);
                                        var returnBool2 = !!responseText4;
                                        if (returnBool2 == true) {
                                            console.log("同步成功");
                                        }
                                        else {
                                            console.log("同步失败");
                                        }
                                    }
                                    else {
                                        console.log("教学班更新范围失败");
                                    }
                                    var strInfo = `设置成功!`;
                                    $('#lblResult46').val(strInfo);
                                    //显示信息框
                                    alert(strInfo);
                                    HideDialogOne();
                                }
                                else {
                                    console.log("教学班日期范围更新失败");
                                    var strInfo = `设置失败!`;
                                    $('#lblResult46').val(strInfo);
                                    //显示信息框
                                    alert(strInfo);
                                }
                            }
                            else {
                                console.log("教学班日期范围更新失败");
                            }
                            break;
                        default:
                            var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    alert("登录超时，请重新登录");
                    window.top.location.href = "../Web/Login";
                }
                $("#divLoading").hide();
                //去掉提交按钮不可用状态
                $('#btnOKUpd').attr("disabled", "false");
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
            $("#divLoading").hide();
        }
        /*
    * 开始时间
    */
        set startDate(value) {
            $("#txtStartDate").val(value);
        }
        /*
        * 开始时间
       */
        get startDate() {
            return $("#txtStartDate").val();
        }
        /*
    * 结束时间
    */
        set endDate(value) {
            $("#txtEndDate").val(value);
        }
        /*
        * 结束时间
       */
        get endDate() {
            return $("#txtEndDate").val();
        }
    }
    exports.CurrEduCls_EditEx = CurrEduCls_EditEx;
});
