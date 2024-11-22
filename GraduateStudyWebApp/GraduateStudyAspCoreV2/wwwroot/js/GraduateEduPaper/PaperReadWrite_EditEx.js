(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/PaperReadWrite_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperReadWrite_EditEx = void 0;
    /**
    * 类名:PaperReadWrite_EditEx(界面:PaperReadWriteCRUD)
    * 表名:PaperReadWrite(01120547)
    * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/06 01:16:30
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const PaperReadWrite_Edit_js_1 = require("../PagesBase/GraduateEduPaper/PaperReadWrite_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsPaperReadWriteWApiEx_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* PaperReadWrite_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class PaperReadWrite_EditEx extends PaperReadWrite_Edit_js_1.PaperReadWrite_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = PaperReadWrite_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(PaperReadWrite_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        //跳转到pdf维护子观点页面
        async btnSubviewPointRecord_Click() {
            this.opType = "Update";
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            //if (strKeyId == "") {
            //    alert("请选择需要修改的记录！");
            //    return;
            //}
            var strKeyId = $("#hidPaperRWId").val();
            var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
            var objPaperReadWrite;
            var objPaperAttachment;
            var strWhereCond1 = " 1=1 and paperRWId ='" + strKeyId + "'";
            try {
                const responseText1 = await (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_GetFirstObjAsync)(strWhereCond1);
                objPaperReadWrite = responseText1;
                var strWhereCond2 = " 1=1 and paperId ='" + objPaperReadWrite.paperId + "'";
                const responseText2 = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_GetFirstObjAsync)(strWhereCond2);
                objPaperAttachment = responseText2;
                if (strReadWriteTypeId == "02") {
                    if (objPaperAttachment != null) {
                        var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                        window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperRWId=" + strKeyId + "&file=" + strfilepath;
                    }
                    else {
                        window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperRWId=" + strKeyId;
                    }
                }
                else if (strReadWriteTypeId == "04") {
                    if (objPaperAttachment != null) {
                        var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                        window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperRWId=" + strKeyId + "&file=" + strfilepath;
                    }
                    else {
                        window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperRWId=" + strKeyId;
                    }
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面上
      注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
       如果在设置数据库时,就应该一级字段在前,二级字段在后
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
       <param name = "pobjPaperReadWriteEN">表实体类对象</param>
     */
        GetDataFromPaperReadWriteClass(pobjPaperReadWriteEN) {
            this.paperRWId = pobjPaperReadWriteEN.paperRWId; // 论文读写Id
            this.readerId = pobjPaperReadWriteEN.readerId; // 阅读者Id
            $("#hidPaperId").val(pobjPaperReadWriteEN.paperId);
            //this.paperId = pobjPaperReadWriteEN.paperId;// 论文Id
            this.researchQuestion = pobjPaperReadWriteEN.researchQuestion; // 研究问题
            this.shareId = pobjPaperReadWriteEN.shareId;
            this.operationTypeId = pobjPaperReadWriteEN.operationTypeId; // 操作类型ID
            this.updDate = pobjPaperReadWriteEN.updDate; // 修改日期
            //this.updUser = pobjPaperReadWriteEN.updUser;// 修改用户Id
            this.memo = pobjPaperReadWriteEN.memo; // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
       <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
     */
        async PutDataToPaperReadWriteClass(pobjPaperReadWriteEN) {
            pobjPaperReadWriteEN.SetPaperRWId(this.paperRWId); // 论文读写Id
            pobjPaperReadWriteEN.SetReaderId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 阅读者Id
            pobjPaperReadWriteEN.SetPaperId($("#hidPaperId").val()); // 论文Id
            pobjPaperReadWriteEN.SetResearchQuestion(this.researchQuestion); // 研究问题
            pobjPaperReadWriteEN.SetOperationTypeId($("#hidReadWriteTypeId").val()); // 操作类型ID
            pobjPaperReadWriteEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            // pobjPaperReadWriteEN.SetOperationTypeId(this.operationTypeId;// 操作类型ID
            pobjPaperReadWriteEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjPaperReadWriteEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id// 修改用户Id
            pobjPaperReadWriteEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd_Click() {
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            var strCommandText = this.btnSubmit_PaperReadWrite;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                //刷新缓存
                                (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEducls);
                                HideDialog();
                                this.iShowList.BindGv(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, returnBool.toString());
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                //刷新缓存
                                (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEducls);
                                HideDialog();
                                this.iShowList.BindGv(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, returnBool.toString());
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
                //取消提交按钮不可用状态
                $("#btnOKUpd").attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录
           (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
          */
        async AddNewRecordSave() {
            try {
                const responseText = (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表PaperReadWrite的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtPaperRWId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            var objPaperReadWriteEN = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
            //创建时间
            objPaperReadWriteEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
            this.PutDataToPaperReadWriteClass(objPaperReadWriteEN);
            try {
                //const responseText = await PaperReadWrite_IsExistAsync(objPaperReadWriteEN.paperRWId);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `添加记录时，关键字：${objPaperReadWriteEN.paperRWId}已经存在！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await clsPaperReadWriteWApiEx_js_1.clsPaperReadWriteWApiEx.AddNewRecordAsyncEx(objPaperReadWriteEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!同一用户同一论文只能添加一次`;
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
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
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
            var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
            const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
            this.UpdateRecord(strKeyId);
        }
        /* 根据关键字获取相应的记录的对象
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        <param name = "sender">参数列表</param>
      */
        async UpdateRecord(strPaperRWId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.btnSubmit_PaperReadWrite = "确认修改";
            this.btnCancel_PaperReadWrite = "取消修改";
            this.keyId = strPaperRWId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                const objPaperReadWriteEN = await (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_GetObjByPaperRWIdAsync)(strPaperRWId);
                if (objPaperReadWriteEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                // //通过判断数据用户是否是当前登录用户；
                if (objPaperReadWriteEN.updUser == strUserId) {
                    ShowDialog('Update');
                    this.GetDataFromPaperReadWriteClass(objPaperReadWriteEN);
                    console.log("完成UpdateRecord!");
                }
                else {
                    alert("当前数据不是您所添加，不能修改！");
                    return false;
                }
                return true;
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
                return false;
            }
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
        //提交函数
        async SubmitRecord(strPaperRWId) {
            this.keyId = strPaperRWId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_GetObjByPaperRWIdAsync)(strPaperRWId).then((jsonData) => {
                        var objPaperReadWriteEN = jsonData;
                        //判断角色 //学生00620003
                        if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620003") {
                            // //通过判断数据用户是否是当前登录用户；
                            if (objPaperReadWriteEN.updUser == strUserId) {
                                //判断数据是否已提交
                                if (objPaperReadWriteEN.isSubmit == false) {
                                    const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                        //var returnBool: boolean = jsonData;
                                        //if (returnBool == true) {
                                        //    HideDialog();
                                        //    this.BindGv_vPaperReadWrite();
                                        //}
                                    });
                                }
                                else {
                                    alert("当前数据已提交！");
                                    return;
                                }
                            }
                            else {
                                alert("当前数据不是您所添加，不能修改！");
                                return;
                            }
                        }
                        else {
                            //可以提交
                            //判断数据是否已提交
                            if (objPaperReadWriteEN.isSubmit == false) {
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
        //论文提交
        async btnSubmit_Click() {
            var strKeyId = this.keyId; // GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        /* 函数功能:把界面上的属性数据传到类对象中
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
      <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
    */
        PutDataToPaperReadWriteClassSubmit(pobjPaperReadWriteEN) {
            // pobjPaperReadWriteEN.SetPaperRWId(this.paperRWId;// 论文读写Id
            pobjPaperReadWriteEN.SetIsSubmit(true);
            pobjPaperReadWriteEN.submitter = clsPublocalStorage_js_1.clsPublocalStorage.userId; //提交人；
        }
        /* 修改记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async SubmitRecordSave() {
            const strThisFuncName = this.SubmitRecordSave.name;
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            var objPaperReadWriteEN = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
            objPaperReadWriteEN.SetPaperRWId(this.keyId);
            this.PutDataToPaperReadWriteClassSubmit(objPaperReadWriteEN);
            objPaperReadWriteEN.sf_UpdFldSetStr = objPaperReadWriteEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_UpdateRecordAsync)(objPaperReadWriteEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `论文提交成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            //刷新缓存
                            (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEducls);
                            HideDialog();
                            this.iShowList.BindGv(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, "");
                        }
                        else {
                            var strInfo = `论文提交不成功!`;
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
    }
    exports.PaperReadWrite_EditEx = PaperReadWrite_EditEx;
});
