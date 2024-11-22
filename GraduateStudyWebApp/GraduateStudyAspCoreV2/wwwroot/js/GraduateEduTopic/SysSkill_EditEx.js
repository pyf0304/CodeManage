(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/SysSkill_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSkill_EditEx = void 0;
    const SysSkill_Edit_js_1 = require("../PagesBase/GraduateEduTopic/SysSkill_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js");
    const clsvSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js");
    const clsSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* SysSkill_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class SysSkill_EditEx extends SysSkill_Edit_js_1.SysSkill_Edit {
        constructor() {
            super(...arguments);
            this.Id_CurrEduCls = "";
        }
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = SysSkill_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(SysSkill_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
    */
        async btnAddNewRecord_Click() {
            this.opType = "Add";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    ShowDialog('Add');
                    this.bolIsLoadEditRegion = true; //
                    //获取分享Id
                    const responseText1 = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("09", clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    var strShareId = responseText1;
                    //var returnBool: boolean = !!responseText2;
                    if (strShareId != "") {
                        this.shareId = strShareId;
                    }
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog('Add');
                    const responseText = await this.AddNewRecord();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_Click.name;
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            if (this.opType == "AddWithMaxId") {
                                //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                //    var returnBool2: boolean = jsonData;
                                //    if (returnBool2 == true) {
                                //        HideDialog();
                                //        this.iShowList.BindGv(clsvSysSkillEN._CurrTabName, returnKeyId);
                                //    }
                                //});
                                const responseText2 = await this.AddNewRecordWithReturnKeyAsync().then((jsonData) => {
                                    const returnKeyId = jsonData;
                                    HideDialog();
                                    this.iShowList.BindGv(clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, returnKeyId);
                                });
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        HideDialog();
                                        this.iShowList.BindGv(clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, returnBool.toString());
                                    }
                                });
                            }
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strSysskillId = $("#hidSkillId").val();
                            const responseText8 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSysskillId, "09", "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool8 = !!responseText8;
                            if (returnBool8 == true) {
                                console.log("技能数据总表同步成功；");
                            }
                            else {
                                console.log("技能数据总表同步失败；");
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                strInfo += "(In SysSkillCRUD.btnOKUpd_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, returnBool.toString());
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strSysskillId = $("#hidSkillId").val();
                            const responseText9 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSysskillId, "09", "2", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool9 = !!responseText9;
                            if (returnBool9 == true) {
                                console.log("技能数据总表同步成功；");
                            }
                            else {
                                console.log("技能数据总表同步失败；");
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
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
            objSysSkillEN.SetSkillId(this.keyId);
            $("#hidSkillId").val(this.keyId);
            this.PutDataToSysSkillClass(objSysSkillEN);
            objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsSysSkillWApi_js_1.SysSkill_UpdateRecordAsync)(objSysSkillEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
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
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
      */
        async AddNewRecordWithReturnKeyAsync() {
            var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
            objSysSkillEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
            this.PutDataToSysSkillClass(objSysSkillEN);
            try {
                const responseText2 = await (0, clsSysSkillWApi_js_1.SysSkill_AddNewRecordWithReturnKeyAsync)(objSysSkillEN); //.AddNewRecordWithMaxIdAsync(objSysSkillEN);
                var strSysSkillId = responseText2;
                if (strSysSkillId != "") {
                    $("#hidSkillId").val(strSysSkillId);
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
                return strSysSkillId; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                throw (strMsg);
            }
            return ""; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjSysSkillEN">数据传输的目的类对象</param>
    */
        async PutDataToSysSkillClass(pobjSysSkillEN) {
            pobjSysSkillEN.SetSkillId(this.skillId); // 技能Id
            pobjSysSkillEN.SetSkillName(this.skillName); // 技能名称
            pobjSysSkillEN.SetOperationTypeId(this.operationTypeId); // 操作类型
            pobjSysSkillEN.SetLevelId(this.levelId); // 级别Id
            pobjSysSkillEN.SetProcess(this.process); // 实施过程
            pobjSysSkillEN.SetShareId(this.shareId);
            pobjSysSkillEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjSysSkillEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjSysSkillEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjSysSkillEN.SetIsSubmit(this.isSubmit); // 是否提交
            pobjSysSkillEN.SetCitationId(this.citationId); // 引用Id
            pobjSysSkillEN.SetMemo(this.memo); // 备注
        }
        //提交判断；
        async SubmitRecord(strSkillId) {
            this.keyId = strSkillId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSysSkillWApi_js_1.SysSkill_GetObjBySkillIdAsync)(strSkillId).then((jsonData) => {
                        var objSysSkillEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                        //判断角色 //学生00620003
                        if (strRoleId == "00620003") {
                            // //通过判断数据用户是否是当前登录用户；
                            if (objSysSkillEN.updUser == strUserId) {
                                //判断数据是否已审核
                                if (objSysSkillEN.isSubmit == false) {
                                    const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                    });
                                }
                                else {
                                    alert("当前数据已提交！");
                                    return;
                                }
                            }
                            else {
                                alert("当前数据不是您所添加，不能提交！");
                                return;
                            }
                        }
                        else {
                            //可以提交
                            //判断数据是否已提交
                            if (objSysSkillEN.isSubmit == false) {
                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                });
                            }
                            else {
                                alert("当前数据已提交！");
                                return;
                            }
                        }
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async SubmitRecordSave() {
            const strThisFuncName = this.SubmitRecordSave.name;
            //
            var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
            objSysSkillEN.SetSkillId(this.keyId);
            objSysSkillEN.SetIsSubmit(true);
            objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSysSkillWApi_js_1.SysSkill_UpdateRecordAsync)(objSysSkillEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `提交成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            //HideDialog();
                            this.iShowList.BindGv(clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, returnBool.toString());
                        }
                        else {
                            var strInfo = `提交不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("提交失败");
                        }
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `修改记录不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //取消提交
        async btnCancelSubmit_Click(strKeyId) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要取消的记录！");
                return;
            }
            try {
                this.CancelSubmitRecordSave(strKeyId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*取消
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async CancelSubmitRecordSave(strKeyId) {
            const strThisFuncName = this.CancelSubmitRecordSave.name;
            //
            var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
            objSysSkillEN.SetSkillId(strKeyId);
            objSysSkillEN.SetIsSubmit(false);
            objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = (0, clsSysSkillWApi_js_1.SysSkill_UpdateRecordAsync)(objSysSkillEN).then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        var strInfo = `取消成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //HideDialog();
                        this.iShowList.BindGv(clsvSysSkillEN_js_1.clsvSysSkillEN._CurrTabName, returnBool.toString());
                    }
                    else {
                        var strInfo = `取消不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("取消失败");
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `取消记录不成功,${e}.`;
                alert(strMsg);
            }
        }
        //技能提交审核
        async btnIsSubmit_Click(strKeyId) {
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        async btnUpdateRecordInTab_Click(strKeyId) {
            this.opType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
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
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegionInDiv();
                //ShowDialog('Update');
                this.bolIsLoadEditRegion = true; //
                this.UpdateRecord(strKeyId);
            }
            else {
                //ShowDialog('Update');
                this.UpdateRecord(strKeyId);
            }
        }
        /* 根据关键字获取相应的记录的对象
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
    */
        async UpdateRecord(strSkillId) {
            this.btnSubmit_SysSkill = "确认修改";
            this.btnCancel_SysSkill = "取消修改";
            this.keyId = strSkillId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                const responseText = await (0, clsSysSkillWApi_js_1.SysSkill_GetObjBySkillIdAsync)(strSkillId);
                var objSysSkillEN = responseText;
                // //通过判断数据用户是否是当前登录用户；
                if (objSysSkillEN.updUser == strUserId) {
                    //判断数据是否提交，提交则不可修改；
                    if (objSysSkillEN.isSubmit == false) {
                        ShowDialog('Update');
                        this.GetDataFromSysSkillClass(objSysSkillEN);
                        console.log("完成UpdateRecord!");
                    }
                    else {
                        alert("当前数据已提交,不能修改！");
                        return false;
                    }
                }
                else {
                    alert("当前数据不是您所添加，不能修改！");
                    return false;
                }
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            return true;
        }
        /* 函数功能:把类对象的属性内容显示到界面上
      注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
       如果在设置数据库时,就应该一级字段在前,二级字段在后
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
       <param name = "pobjSysSkillEN">表实体类对象</param>
     */
        GetDataFromSysSkillClass(pobjSysSkillEN) {
            this.skillId = pobjSysSkillEN.skillId; // 技能Id
            this.skillName = pobjSysSkillEN.skillName; // 技能名称
            this.operationTypeId = pobjSysSkillEN.operationTypeId; // 操作类型
            this.levelId = pobjSysSkillEN.levelId; // 级别Id
            this.process = pobjSysSkillEN.process; // 实施过程
            this.shareId = pobjSysSkillEN.shareId;
            this.updUser = pobjSysSkillEN.updUser; // 修改人
            this.updDate = pobjSysSkillEN.updDate; // 修改日期
            this.isSubmit = pobjSysSkillEN.isSubmit; // 是否提交
            this.citationId = pobjSysSkillEN.citationId; // 引用Id
            this.memo = pobjSysSkillEN.memo; // 备注
        }
        /*
    * 分享
    */
        set shareId(value) {
            $("#ddlShareId").val(value);
        }
        /*
        * 分享
        */
        get shareId() {
            return $("#ddlShareId").val();
        }
    }
    exports.SysSkill_EditEx = SysSkill_EditEx;
});
