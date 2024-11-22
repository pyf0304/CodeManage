(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/TopicObjective_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js", "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js", "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveVerEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TopicObjective_EditEx = void 0;
    /**
    * 类名:TopicObjective_EditEx(界面:TopicObjectiveCRUD)
    * 表名:TopicObjective(01120613)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/05 00:08:18
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const TopicObjective_Edit_js_1 = require("../PagesBase/GraduateEduTopic/TopicObjective_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsObjectiveAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js");
    const clsTopicObjectiveEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js");
    const clsTopicObjectiveVerEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveVerEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsObjectiveAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js");
    const clsTopicObjectiveVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveVerWApi.js");
    const clsTopicObjectiveWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* TopicObjective_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class TopicObjective_EditEx extends TopicObjective_Edit_js_1.TopicObjective_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = TopicObjective_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(TopicObjective_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
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
            var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
            const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
            this.UpdateRecord(strKeyId);
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
    */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_TopicObjective;
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
                            //if (this.opType == "AddWithMaxId") {
                            //    const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            //        var returnBool2: boolean = jsonData;
                            //        if (returnBool2 == true) {
                            //            HideDialog();
                            //            this.BindGv_vTopicObjective();
                            //        }
                            //    });
                            //}
                            //else {
                            //}
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    //HideDialog();
                                    //this.BindGv_vTopicObjective();
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strTopicObjectiveId = $('#hidObjectiveId').val();
                            const responseText6 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strTopicObjectiveId, "07", "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool6 = !!responseText6;
                            if (returnBool6 == true) {
                                console.log("客观数据总表同步成功；");
                            }
                            else {
                                console.log("客观数据总表同步失败；");
                            }
                            //修改记录的同时添加历史版本
                            const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, returnBool.toString());
                                    //alert("添加历史版本出问题！");
                                }
                            });
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                //strInfo += "(In WApiTopicObjective_QUDI_TS.btnOKUpd_Click)";
                                //$('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                }
                            });
                            var strTopicObjectiveId = $('#hidObjectiveId').val();
                            const responseText7 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strTopicObjectiveId, "07", "2", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool7 = !!responseText7;
                            if (returnBool7 == true) {
                                console.log("客观数据总表同步成功；");
                            }
                            else {
                                console.log("客观数据总表同步失败；");
                            }
                            //修改记录的同时添加历史版本
                            const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, returnBool.toString());
                                    //alert("添加历史版本出问题！");
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
                $('#btnOKUpd').attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        //////////////////////////////添加数据
        /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
    */
        async btnAddNewRecord_Click() {
            this.opType = "Add";
            try {
                var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
                //获取分享Id
                const responseText1 = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("07", clsPublocalStorage_js_1.clsPublocalStorage.userId);
                var strShareId = responseText1;
                //var returnBool: boolean = !!responseText2;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }
                const responseText = await this.AddNewRecord();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        async AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnSubmit_TopicObjective = "确认添加";
            this.btnCancel_TopicObjective = "取消添加";
            this.Clear();
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", false);
        }
        /* 添加新记录，保存函数
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSave() {
            try {
                const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表TopicObjective的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtTopicObjectiveId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            //判断Id是否为空
            if ($('#txtTopicObjectiveId').val() != "") {
                $('#hidObjectiveId').val($('#txtTopicObjectiveId').val());
                var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
                objTopicObjectiveEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
                this.PutDataToTopicObjectiveClass(objTopicObjectiveEN);
                try {
                    const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_IsExistAsync)(objTopicObjectiveEN.topicObjectiveId);
                    var bolIsExist = responseText;
                    if (bolIsExist == true) {
                        var strMsg = `添加记录时，关键字：${objTopicObjectiveEN.topicObjectiveId}已经存在！`;
                        alert(strMsg);
                        return responseText; //一定要有一个返回值，否则会出错！
                    }
                    const responseText2 = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_AddNewRecordAsync)(objTopicObjectiveEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        //var strInfo: string = `添加记录成功!`;
                        //$('#lblResult46').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                        //添加成功，则执行附件添加方法；
                        //判断是否有返回的附件路径值
                        if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                            var fileOne = $("#hdnFileOne").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        }
                        else {
                            if ($("#hdnFileTwo").val() != "") {
                                var fileTwo = $("#hdnFileTwo").val();
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                            }
                            else {
                                if ($("#hdnFileThree").val() != "") {
                                    var fileThree = $("#hdnFileThree").val();
                                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                                }
                            }
                        }
                    }
                    else {
                        var strInfo = `添加记录不成功!`;
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
                    return false;
                }
            }
            else {
                var strInfo = `获取最大关键字为空，不成功!`;
                //显示信息框
                alert(strInfo);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //////////////////////////////////////////////////////////////////////附件添加
        //添加上传论文附件方法
        async AddNewRecordobjPaperSubAttachmentENSave(filePath, strfileNum) {
            var objObjectiveAttachmentEN = new clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN();
            this.PutDataToPaperAttachmentClass(objObjectiveAttachmentEN, filePath);
            try {
                const responseText2 = await (0, clsObjectiveAttachmentWApi_js_1.ObjectiveAttachment_AddNewRecordAsync)(objObjectiveAttachmentEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //第一个附件
                    if (strfileNum == "first") {
                        //如果第二个附件不等于空，那么执行添加函数；
                        if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            //为空则判断第三个附件值；
                            if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                var fileThree = $("#hdnFileThree").val();
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                            }
                        }
                    }
                    else if (strfileNum == "two") {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }
                }
                else {
                    var strInfo = `论文附件添加不成功!`;
                    $('#lblResult40').val(strInfo);
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
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //观点附件数据存放
        PutDataToPaperAttachmentClass(pobjObjectiveAttachmentEN, filePath) {
            pobjObjectiveAttachmentEN.SetTopicObjectiveId($("#txtTopicObjectiveId").val()); // 概念Id
            var strfilePath = filePath;
            //判断地址不为空则执行截取操作
            if (strfilePath != "") {
                var index = strfilePath.lastIndexOf("\/");
                strfilePath = strfilePath.substring(index + 1, strfilePath.length);
                pobjObjectiveAttachmentEN.SetFilePath(filePath);
                pobjObjectiveAttachmentEN.SetObjectiveAttachmentName(strfilePath);
            }
            pobjObjectiveAttachmentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjObjectiveAttachmentEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls); //教学班
            pobjObjectiveAttachmentEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
        }
        ///////////////////////////////////////////////////////////////////数据提交；
        //客观提交审核
        async btnIsSubmit_Click(strKeyId) {
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        //提交判断；
        async SubmitRecord(strTopicObjectiveId) {
            this.keyId = strTopicObjectiveId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsTopicObjectiveWApi_js_1.TopicObjective_GetObjByTopicObjectiveIdAsync)(strTopicObjectiveId).then((jsonData) => {
                        var objTopicObjectiveEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                        //判断角色 //学生00620003
                        if (strRoleId == "00620003") {
                            // //通过判断数据用户是否是当前登录用户；
                            if (objTopicObjectiveEN.updUser == strUserId) {
                                //判断数据是否已审核
                                if (objTopicObjectiveEN.isSubmit == false) {
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
                            if (objTopicObjectiveEN.isSubmit == false) {
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
        /* 提交权限修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async SubmitRecordSave() {
            const strThisFuncName = this.SubmitRecordSave.name;
            //
            var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
            objTopicObjectiveEN.SetTopicObjectiveId(this.keyId);
            objTopicObjectiveEN.SetIsSubmit(true);
            //this.PutDataToTopicObjectiveClass(objTopicObjectiveEN);
            objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `提交成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            HideDialog();
                            this.iShowList.BindGv(clsTopicObjectiveEN_js_1.clsTopicObjectiveEN._CurrTabName, returnBool.toString());
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
                    return false;
                }
            });
        }
        ////////////////////////////////////////////////////修改数据
        //修改权限判断是否提交 提交则不可修改；
        /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
    */
        async UpdateRecord(strTopicObjectiveId) {
            this.btnSubmit_TopicObjective = "确认修改";
            this.btnCancel_TopicObjective = "取消修改";
            this.keyId = strTopicObjectiveId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_GetObjByTopicObjectiveIdAsync)(strTopicObjectiveId);
                var objTopicObjectiveEN = responseText;
                // //通过判断数据用户是否是当前登录用户；
                if (objTopicObjectiveEN.updUser == strUserId) {
                    //判断数据是否提交，提交则不可修改；
                    if (objTopicObjectiveEN.isSubmit == false) {
                        ShowDialog('Update');
                        this.GetDataFromTopicObjectiveClass(objTopicObjectiveEN);
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
                return false;
            }
            return true;
        }
        /* 修改记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
            objTopicObjectiveEN.SetTopicObjectiveId(this.keyId);
            $('#hidObjectiveId').val(this.keyId);
            this.PutDataToTopicObjectiveClass(objTopicObjectiveEN);
            objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //如果等于空，那么就去判断附件是否为空；
                    //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                    if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                        //根据Id删除附件
                        var strwhere = "topicObjectiveId ='" + objTopicObjectiveEN.topicObjectiveId + "'";
                        this.DelRecordByWhere(strwhere);
                    }
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
            return true;
        }
        //添加历史版本
        async AddVersionRecordSave() {
            const strThisFuncName = this.AddVersionRecordSave.name;
            var objTopicObjectiveVerEN = new clsTopicObjectiveVerEN_js_1.clsTopicObjectiveVerEN();
            objTopicObjectiveVerEN.SetTopicObjectiveId(this.topicObjectiveId);
            this.PutDataToTopicObjectiveVClass(objTopicObjectiveVerEN);
            try {
                const responseText2 = await (0, clsTopicObjectiveVerWApi_js_1.TopicObjectiveVer_AddNewRecordAsync)(objTopicObjectiveVerEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and topicObjectiveId=" + this.topicObjectiveId;
                    var intVersionCount = await (0, clsTopicObjectiveVerWApi_js_1.TopicObjectiveVer_GetRecCountByCondAsync)(strWhereCond2);
                    var objTopicObjectiveEN = new clsTopicObjectiveEN_js_1.clsTopicObjectiveEN();
                    objTopicObjectiveEN.SetTopicObjectiveId(this.topicObjectiveId);
                    objTopicObjectiveEN.SetVersionCount(intVersionCount);
                    objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsTopicObjectiveWApi_js_1.TopicObjective_UpdateRecordAsync)(objTopicObjectiveEN).then((jsonData) => {
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
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjTopicObjectiveEN">数据传输的目的类对象</param>
      */
        PutDataToTopicObjectiveVClass(pobjTopicObjectiveVerEN) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjTopicObjectiveVerEN.SetTopicObjectiveId(this.topicObjectiveId); // 客观Id
            pobjTopicObjectiveVerEN.SetObjectiveName(this.objectiveName); // 客观名称
            pobjTopicObjectiveVerEN.SetObjectiveContent(this.objectiveContent); // 客观内容
            //判断客观类型
            var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
            if (strhidObjectiveTypeId != "") {
                pobjTopicObjectiveVerEN.SetObjectiveType(strhidObjectiveTypeId);
            }
            //pobjTopicObjectiveVerEEN.SetObjectiveType(this.objectiveType;// 客观类型
            pobjTopicObjectiveVerEN.SetSourceId(this.sourceId); // 来源Id
            pobjTopicObjectiveVerEN.SetConclusion(this.conclusion); // 结论
            pobjTopicObjectiveVerEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjTopicObjectiveVerEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjTopicObjectiveVerEN.SetUpdUser(strUserId); // 修改用户Id
            pobjTopicObjectiveVerEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjTopicObjectiveEN">数据传输的目的类对象</param>
       */
        async PutDataToTopicObjectiveClass(pobjTopicObjectiveEN) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjTopicObjectiveEN.SetTopicObjectiveId(this.topicObjectiveId); // 客观Id
            pobjTopicObjectiveEN.SetObjectiveName(this.objectiveName); // 客观名称
            pobjTopicObjectiveEN.SetObjectiveContent(this.objectiveContent); // 客观内容
            //判断客观类型
            var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
            if (strhidObjectiveTypeId != "") {
                pobjTopicObjectiveEN.SetObjectiveType(strhidObjectiveTypeId);
            }
            //pobjTopicObjectiveEEN.SetObjectiveType(this.objectiveType;// 客观类型
            pobjTopicObjectiveEN.SetSourceId(this.sourceId); // 来源Id
            pobjTopicObjectiveEN.SetConclusion(this.conclusion); // 结论
            pobjTopicObjectiveEN.SetIsSubmit(false); //是否提交；
            pobjTopicObjectiveEN.SetShareId(this.shareId);
            pobjTopicObjectiveEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjTopicObjectiveEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjTopicObjectiveEN.SetUpdUser(strUserId); // 修改用户Id
            pobjTopicObjectiveEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
    如果在设置数据库时,就应该一级字段在前,二级字段在后
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
    <param name = "pobjTopicObjectiveEN">表实体类对象</param>
    */
        GetDataFromTopicObjectiveClass(pobjTopicObjectiveEN) {
            this.topicObjectiveId = pobjTopicObjectiveEN.topicObjectiveId; // 客观Id
            this.objectiveName = pobjTopicObjectiveEN.objectiveName; // 客观名称
            this.objectiveContent = pobjTopicObjectiveEN.objectiveContent; // 客观内容
            this.objectiveType = pobjTopicObjectiveEN.objectiveType; // 客观类型
            this.sourceId = pobjTopicObjectiveEN.sourceId; // 来源Id
            this.conclusion = pobjTopicObjectiveEN.conclusion; // 结论
            this.shareId = pobjTopicObjectiveEN.shareId;
            this.isSubmit = pobjTopicObjectiveEN.isSubmit; // 是否提交
            this.updDate = pobjTopicObjectiveEN.updDate; // 修改日期
            //this.updUser = pobjTopicObjectiveEN.updUser;// 修改用户Id
            this.memo = pobjTopicObjectiveEN.memo; // 备注
        }
        //删除观点附件
        /*
    根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        DelRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsObjectiveAttachmentWApi_js_1.ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                        }
                        else {
                            var strInfo = `删除记录不成功!`;
                            //显示信息框
                            //alert(strInfo);
                        }
                        //在修改时候，不管是否有附件数据被清除； 都需要执行附件添加功能
                        //判断是否有返回的附件路径值
                        var fileOne = $("#hdnFileOne").val();
                        if (fileOne != "" && fileOne != undefined) { //第一个附件框判断
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        }
                        else {
                            var fileTwo = $("#hdnFileTwo").val();
                            if (fileTwo != "" && fileTwo != undefined) {
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                            }
                            else {
                                var fileThree = $("#hdnFileThree").val();
                                if (fileThree != "" && fileThree != undefined) {
                                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                                }
                            }
                        }
                        console.log("完成DelRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
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
    exports.TopicObjective_EditEx = TopicObjective_EditEx;
});
