(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/gs_ResearchResult_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchResultAttachmentEN.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchResultEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ResearchResult_EditEx = void 0;
    const gs_ResearchResult_Edit_js_1 = require("../PagesBase/GraduateEduTopic/gs_ResearchResult_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsgs_ResearchResultAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchResultAttachmentEN.js");
    const clsgs_ResearchResultEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchResultEN.js");
    const clsvRTPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js");
    const clsgs_ResearchResultAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultAttachmentWApi.js");
    const clsgs_ResearchResultWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultWApi.js");
    const clsvRTPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* gs_ResearchResult_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class gs_ResearchResult_EditEx extends gs_ResearchResult_Edit_js_1.gs_ResearchResult_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            var objPage = gs_ResearchResult_EditEx.objPage_Edit;
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
                    var strMsg = '命令:' + strCommandName + "在函数(gs_ResearchResult_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[paperId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
        /// </summary>
        async SetDdl_PaperId(strid_CurrEduCls) {
            //var objPaper_Cond: clsPaperEN = new clsPaperEN();//编辑区域
            ////定义条件字段
            ////var strid_CurrEduCls = "";//定义条件字段
            //const ddlPaperId = await Paper_BindDdl_PaperId_Cache("ddlPaperId", objPaper_Cond, strid_CurrEduCls);//编辑区域
            const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId");
        }
        //专业下拉框绑定
        BindDdl_PaperId(ddlPaperId) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strWhereCond = " topicId= " + strTopicId;
            var objDdl = document.getElementById(ddlPaperId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlPaperId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsvRTPaperRelaWApi_js_1.vRTPaperRela_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrvRTPaperRelaObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst_V)(ddlPaperId, arrvRTPaperRelaObjLst, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperId, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTitle, "主题相关论文");
                        console.log("完成BindDdl_UserId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        async PutDataTogs_ResearchResultClass(pobjgs_ResearchResultEN) {
            //pobjgs_ResearchResultEN.SetResultId(this.resultId;// 会议Id
            //getTextboxio();
            //pobjgs_ResearchResultEN.SetTopicId(clsPrivateSessionStorage.topicId;// 主题编号
            //pobjgs_ResearchResultEN.SetIsSubmit(false;// 是否提交
            //pobjgs_ResearchResultEN.SetResultContent(this.resultContent);// 会议内容
            //pobjgs_ResearchResultEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
            //pobjgs_ResearchResultEN.ResultUser = $("#txtResultUser").val();// 参会者
            //pobjgs_ResearchResultEN.SetUpdUser(clsPublocalStorage.userId;// 修改人
            //pobjgs_ResearchResultEN.SetPaperId(this.paperId;// 论文Id
            //pobjgs_ResearchResultEN.SetPPTUrl($("#hidppt").val();// PPT
            //pobjgs_ResearchResultEN.SetPDFUrl($("#hidpdf").val();// PDF
            //var strYmd = clsPubFun4Web.getNowDate_ymd();
            //if (this.ResultDate == "") {
            //    pobjgs_ResearchResultEN.ResultDate = strYmd;// 会议日期
            //} else {
            //    pobjgs_ResearchResultEN.ResultDate = this.ResultDate;// 会议日期
            //}
            //pobjgs_ResearchResultEN.SetYear(this.ResultDate.substr(0, 4);
            //pobjgs_ResearchResultEN.SetMonth(this.ResultDate.substr(5, 2);
            //pobjgs_ResearchResultEN.SetMemo(this.memo;// 备注
            pobjgs_ResearchResultEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjgs_ResearchResultEN.SetResultId(this.resultId); // 成果Id
            pobjgs_ResearchResultEN.SetPaperId(this.paperId); // 论文Id
            pobjgs_ResearchResultEN.SetTopicId(clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId); // 主题编号
            pobjgs_ResearchResultEN.SetResultTypeId($("#ddlResultTypeId").val()); // 成果类型Id 
            pobjgs_ResearchResultEN.SetResultName(this.resultName); // 成果名称
            pobjgs_ResearchResultEN.SetResultContent(this.resultContent); // 成果内容
            pobjgs_ResearchResultEN.SetAuthor(this.author); // 作者
            pobjgs_ResearchResultEN.SetDivision(this.division); // 分工
            pobjgs_ResearchResultEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjgs_ResearchResultEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjgs_ResearchResultEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjgs_ResearchResultEN">表实体类对象</param>
       */
        async GetDataFromgs_ResearchResultClass(pobjgs_ResearchResultEN) {
            //this.resultId = pobjgs_ResearchResultEN.resultId;// 会议Id
            //this.topicId = pobjgs_ResearchResultEN.topicId;// 主题编号
            //this.isSubmit = pobjgs_ResearchResultEN.isSubmit;// 是否提交
            //this.resultContent = pobjgs_ResearchResultEN.resultContent;// 会议内容
            //$("#txtResultUser").val(pobjgs_ResearchResultEN.ResultUser);// 参会者
            //this.paperId = pobjgs_ResearchResultEN.paperId;
            //$("#hidppt").val(pobjgs_ResearchResultEN.ppTUrl);// PPT
            //$("#hidpdf").val(pobjgs_ResearchResultEN.pdFUrl);// PDF
            //this.ResultDate = pobjgs_ResearchResultEN.ResultDate;// 会议日期
            //this.memo = pobjgs_ResearchResultEN.memo;// 备注
            this.resultId = pobjgs_ResearchResultEN.resultId; // 成果Id
            this.paperId = pobjgs_ResearchResultEN.paperId; // 论文Id
            //this.topicId = pobjgs_ResearchResultEN.topicId;// 主题编号
            //this.resultTypeId = pobjgs_ResearchResultEN.resultTypeId;// 成果类型Id
            this.resultName = pobjgs_ResearchResultEN.resultName; // 成果名称
            this.resultContent = pobjgs_ResearchResultEN.resultContent; // 成果内容
            this.author = pobjgs_ResearchResultEN.author; // 作者
            this.division = pobjgs_ResearchResultEN.division; // 分工
            //this.updDate = pobjgs_ResearchResultEN.updDate;// 修改日期
            //this.updUser = pobjgs_ResearchResultEN.updUser;// 修改人
            this.memo = pobjgs_ResearchResultEN.memo; // 备注
            //setTextboxio();
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_gs_ResearchResult;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        //if (this.opType == "AddWithMaxId") {
                        //    //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                        //    //var returnBool2: boolean = jsonData;
                        //    //if (returnBool2 == true)
                        //    //{
                        //    //HideDialog_gs_ResearchResult();
                        //    //this.iShowList.BindGv_Cache(clsgs_ResearchResultEN._CurrTabName);
                        //    //}
                        //    //});
                        //}
                        //else {
                        var strResultId;
                        const responseText2 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            strResultId = jsonData;
                        });
                        if (strResultId != "") {
                            this.HideDialog_gs_ResearchResult();
                            this.iShowList.BindGv(clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN._CurrTabName, "");
                            //alert("添加历史版本出问题！");
                        }
                        //}
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const returnBool = await this.UpdateRecordSave();
                        if (returnBool == true) {
                            $("#hidResultId").val(this.keyId);
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            //strInfo += "(In gs_ResearchResult_Edit.btnSubmit_Click)";
                            //$('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            //alert(strInfo);
                            layui_Alert(1, strInfo);
                            $("#divLoading").hide();
                            this.HideDialog_gs_ResearchResult();
                            this.iShowList.BindGv(clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN._CurrTabName, "");
                        }
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
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
       (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
      */
        async AddNewRecordWithMaxIdSave() {
            var objgs_ResearchResultEN = new clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN();
            this.PutDataTogs_ResearchResultClass(objgs_ResearchResultEN);
            try {
                const responseKeyId = await (0, clsgs_ResearchResultWApi_js_1.gs_ResearchResult_AddNewRecordWithMaxIdAsync)(objgs_ResearchResultEN);
                var returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    this.resultId = returnKeyId;
                    //判断是否有返回的附件路径值
                    if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        var fileOne = $("#hdnFileOne").val();
                        this.AddNewRecordobjgs_ResearchResultAttachmentENSave(fileOne, "first");
                    }
                    else {
                        if ($("#hdnFileTwo").val() != "") {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordobjgs_ResearchResultAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            if ($("#hdnFileThree").val() != "") {
                                var fileThree = $("#hdnFileThree").val();
                                this.AddNewRecordobjgs_ResearchResultAttachmentENSave(fileThree, "three");
                            }
                        }
                    }
                    //gs_ResearchResult_ReFreshCache();
                    var strInfo = `添加记录成功!`;
                    //$('#lblResult47').val(strInfo);
                    //显示信息框
                    //alert(strInfo);
                    layui_Alert(1, strInfo);
                    $("#divLoading").hide();
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
                throw (strMsg);
            }
            return ""; //一定要有一个返回值，否则会出错！
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objgs_ResearchResultEN = new clsgs_ResearchResultEN_js_1.clsgs_ResearchResultEN();
            objgs_ResearchResultEN.SetResultId(this.keyId);
            this.PutDataTogs_ResearchResultClass(objgs_ResearchResultEN);
            objgs_ResearchResultEN.sf_UpdFldSetStr = objgs_ResearchResultEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_ResearchResultEN.resultId == "" || objgs_ResearchResultEN.resultId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const returnBool = await (0, clsgs_ResearchResultWApi_js_1.gs_ResearchResult_UpdateRecordAsync)(objgs_ResearchResultEN);
                if (returnBool == true) {
                    //存放主键;
                    this.resultId = this.keyId;
                    //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                    if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                        //根据Id删除附件
                        var strwhere = "resultId ='" + this.resultId + "'";
                        this.DelRecordByWhere(strwhere);
                    }
                    //gs_ResearchResult_ReFreshCache();
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
        //添加上传附件方法
        async AddNewRecordobjgs_ResearchResultAttachmentENSave(filePath, strfileNum) {
            var objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN();
            this.PutDataToPaperAttachmentClass(objgs_ResearchResultAttachmentEN, filePath);
            try {
                const responseText2 = await (0, clsgs_ResearchResultAttachmentWApi_js_1.gs_ResearchResultAttachment_AddNewRecordAsync)(objgs_ResearchResultAttachmentEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //var returnKeyId: string = responseText2;
                    //if (returnKeyId != "") {
                    //存放返回主键
                    //  $("#hidKeyId").val(returnKeyId);
                    //第一个附件
                    if (strfileNum == "first") {
                        //如果第二个附件不等于空，那么执行添加函数；
                        if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordobjgs_ResearchResultAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            //为空则判断第三个附件值；
                            if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                var fileThree = $("#hdnFileThree").val();
                                this.AddNewRecordobjgs_ResearchResultAttachmentENSave(fileThree, "three");
                            }
                        }
                    }
                    else if (strfileNum == "two") {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjgs_ResearchResultAttachmentENSave(fileThree, "three");
                        }
                    }
                }
                else {
                    var strInfo = `附件添加不成功!`;
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
        PutDataToPaperAttachmentClass(pobjgs_ResearchResultAttachmentEN, filePath) {
            pobjgs_ResearchResultAttachmentEN.SetResultId(this.resultId); // 论文Id
            var strfilePath = filePath;
            //判断地址不为空则执行截取操作
            if (strfilePath != "") {
                var index = strfilePath.lastIndexOf("\/");
                strfilePath = strfilePath.substring(index + 1, strfilePath.length);
                pobjgs_ResearchResultAttachmentEN.SetFilePath(filePath);
                pobjgs_ResearchResultAttachmentEN.SetFileName(strfilePath);
            }
            pobjgs_ResearchResultAttachmentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjgs_ResearchResultAttachmentEN.SetTopicId(clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId); //主题Id
            pobjgs_ResearchResultAttachmentEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
        }
        /*
    根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        DelRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsgs_ResearchResultAttachmentWApi_js_1.gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsByCondAsync)(strWhere).then((jsonData) => {
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
                            this.AddNewRecordobjgs_ResearchResultAttachmentENSave(fileOne, "first");
                        }
                        else {
                            var fileTwo = $("#hdnFileTwo").val();
                            if (fileTwo != "" && fileTwo != undefined) {
                                this.AddNewRecordobjgs_ResearchResultAttachmentENSave(fileTwo, "two");
                            }
                            else {
                                var fileThree = $("#hdnFileThree").val();
                                if (fileThree != "" && fileThree != undefined) {
                                    this.AddNewRecordobjgs_ResearchResultAttachmentENSave(fileThree, "three");
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
    }
    exports.gs_ResearchResult_EditEx = gs_ResearchResult_EditEx;
});
