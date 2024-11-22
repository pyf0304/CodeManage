(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/FunClass/clsPublicParagraph.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemVEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemVWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsString2.js", "./gs_TobeStudiedProblem_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TobeStudiedProblem_EditEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_TobeStudiedProblem_EditEx
    表名:gs_TobeStudiedProblem(01120776)
    生成代码版本:2020.12.12.1
    生成日期:2020/12/15 21:33:22
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:WA_编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsPublicParagraph_js_1 = require("../TS/FunClass/clsPublicParagraph.js");
    const clsgs_TobeStudiedProblemEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js");
    const clsgs_TobeStudiedProblemVEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemVEN.js");
    const clsvRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js");
    const clsgs_TobeStudiedProblemVWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemVWApi.js");
    const clsgs_TobeStudiedProblemWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemWApi.js");
    const clsvRTUserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const gs_TobeStudiedProblem_Edit_js_1 = require("./gs_TobeStudiedProblem_Edit.js");
    /* gs_TobeStudiedProblem_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class gs_TobeStudiedProblem_EditEx extends gs_TobeStudiedProblem_Edit_js_1.gs_TobeStudiedProblem_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            var objPage = gs_TobeStudiedProblem_EditEx.objPage_Edit;
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
                    var strMsg = '命令:' + strCommandName + "在函数(gs_TobeStudiedProblem_EditExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.btnSubmit_gs_TobeStudiedProblem = "确认添加";
            this.btnCancel_gs_TobeStudiedProblem = "取消添加";
            this.Clear();
            //wucgs_TobeStudiedProblemB1.problemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表gs_TobeStudiedProblem的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtProblemId').val(returnString);
                    $('#txtProblemDate').val(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        PutDataTogs_TobeStudiedProblemClass(pobjgs_TobeStudiedProblemEN) {
            //pobjgs_TobeStudiedProblemEN.problemId = this.problemId;// 会议Id
            //getTextboxio();
            pobjgs_TobeStudiedProblemEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
            pobjgs_TobeStudiedProblemEN.topicId = $("#hidTopicRelaId").val(); // 主题编号
            pobjgs_TobeStudiedProblemEN.isSubmit = false; // 是否提交
            pobjgs_TobeStudiedProblemEN.problemTitle = this.problemTitle; // 会议内容
            pobjgs_TobeStudiedProblemEN.problemContent = this.problemContent; // 会议内容
            pobjgs_TobeStudiedProblemEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjgs_TobeStudiedProblemEN.participant = $("#txtParticipant").val(); // 参会者
            pobjgs_TobeStudiedProblemEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改人
            var strYmd = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd();
            if (this.problemDate == "") {
                pobjgs_TobeStudiedProblemEN.problemDate = strYmd; // 会议日期
            }
            else {
                pobjgs_TobeStudiedProblemEN.problemDate = this.problemDate; // 会议日期
            }
            pobjgs_TobeStudiedProblemEN.year = this.problemDate.substr(0, 4);
            pobjgs_TobeStudiedProblemEN.month = this.problemDate.substr(5, 2);
            pobjgs_TobeStudiedProblemEN.memo = this.memo; // 备注
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjgs_TobeStudiedProblemEN">表实体类对象</param>
       */
        GetDataFromgs_TobeStudiedProblemClass(pobjgs_TobeStudiedProblemEN) {
            this.problemId = pobjgs_TobeStudiedProblemEN.problemId; // 会议Id
            this.topicId = pobjgs_TobeStudiedProblemEN.topicId; // 主题编号
            this.isSubmit = pobjgs_TobeStudiedProblemEN.isSubmit; // 是否提交
            this.problemTitle = pobjgs_TobeStudiedProblemEN.problemTitle; // 会议内容
            this.problemContent = pobjgs_TobeStudiedProblemEN.problemContent; // 会议内容
            $("#txtParticipant").val(pobjgs_TobeStudiedProblemEN.participant); // 参会者
            this.problemDate = pobjgs_TobeStudiedProblemEN.problemDate; // 会议日期
            this.memo = pobjgs_TobeStudiedProblemEN.memo; // 备注
            setTextboxio2();
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_gs_TobeStudiedProblem;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        //if (this.OpType == "AddWithMaxId") {
                        //    //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                        //    //var returnBool2: boolean = jsonData;
                        //    //if (returnBool2 == true)
                        //    //{
                        //    //HideDialog_gs_TobeStudiedProblem();
                        //    //this.iShowList.BindGv_Cache(clsgs_TobeStudiedProblemEN._CurrTabName);
                        //    //}
                        //    //});
                        //}
                        //else {
                        var strProblemId;
                        const responseText2 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            strProblemId = jsonData;
                        });
                        if (strProblemId != "") {
                            $("#hidProblemId").val(strProblemId);
                            //添加记录的同时添加历史版本
                            const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog_gs_TobeStudiedProblem();
                                    this.iShowList.BindGv(clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN._CurrTabName, "");
                                    //alert("添加历史版本出问题！");
                                }
                            });
                        }
                        //}
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        var returnBool;
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            returnBool = jsonData;
                        });
                        if (returnBool == true) {
                            $("#hidProblemId").val(this.KeyId);
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            //strInfo += "(In gs_TobeStudiedProblem_Edit.btnSubmit_Click)";
                            //$('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            //alert(strInfo);
                            layui_Alert(1, strInfo);
                            //添加记录的同时添加历史版本
                            const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog_gs_TobeStudiedProblem();
                                    this.iShowList.BindGv(clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN._CurrTabName, "");
                                    //alert("添加历史版本出问题！");
                                }
                            });
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
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN();
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            //1、获取当前用户的色码块
            const responseText1 = await this.GetLoginUserColorCode();
            var strColorCode = $("#hidColorCode").val();
            getTextboxio2();
            //如果是添加段落，那么肯定是第一条记录，只需要把当前用户的色码块通过html标签加入到段落内容；
            this.problemContent = "<span style='color:" + strColorCode + "' name='" + strUserId + "' >" + this.problemContent + "</span>";
            //this.problemContent = '<span style="color:' + strColorCode + '">' + this.problemContent + '</span>';
            this.PutDataTogs_TobeStudiedProblemClass(objgs_TobeStudiedProblemEN);
            try {
                const responseKeyId = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_AddNewRecordWithMaxIdAsync)(objgs_TobeStudiedProblemEN);
                var returnKeyId = responseKeyId;
                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                    //gs_TobeStudiedProblem_ReFreshCache();
                    var strInfo = `添加记录成功!`;
                    //$('#lblResult47').val(strInfo);
                    //显示信息框
                    //alert(strInfo);
                    layui_Alert(1, strInfo);
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
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN();
            objgs_TobeStudiedProblemEN.problemId = this.KeyId;
            getTextboxio2();
            var strHisToryUserId = "";
            //修改段落，那么首先需要查询该段落的最后一条历史记录，得到段落数据，然后取出来与当前段落数据比较，返回更改的段落数据
            var strWhereCond2 = " 1 =1 and problemId=" + this.KeyId + " order by ProblemVId desc ";
            // var intVersionCount = await gs_TobeStudiedProblemV_GetRecCountByCondAsync(strWhereCond2);
            const responseText = await (0, clsgs_TobeStudiedProblemVWApi_js_1.gs_TobeStudiedProblemV_GetFirstObjAsync)(strWhereCond2).then((jsonData) => {
                var objgs_TobeStudiedProblemVEN = jsonData;
                if (objgs_TobeStudiedProblemVEN != null) {
                    //需要去标签的更改数据存放
                    $("#inpLeft").val(objgs_TobeStudiedProblemVEN.problemContent);
                    //存放老的带标签的数据不更改
                    $("#inpOldData").val(objgs_TobeStudiedProblemVEN.problemContent);
                    strHisToryUserId = objgs_TobeStudiedProblemVEN.updUser;
                }
            });
            //调用比较方法
            startCompare2();
            //返回比对后的字符串数据；
            var strInputNewContent = $("#txtProblemContent").val();
            var strNew = $("#inpRight").val();
            var strNewTextContent = clsPublicParagraph_js_1.clsPublicParagraph.GetNewStringList(strInputNewContent, strNew);
            //把得到新的数据存入编辑控件
            //$("#txtAnswerContent").val(strNewTextContent);
            this.problemContent = strNewTextContent;
            this.PutDataTogs_TobeStudiedProblemClass(objgs_TobeStudiedProblemEN);
            objgs_TobeStudiedProblemEN.sf_UpdFldSetStr = objgs_TobeStudiedProblemEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_TobeStudiedProblemEN.problemId == "" || objgs_TobeStudiedProblemEN.problemId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_UpdateRecordAsync)(objgs_TobeStudiedProblemEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //gs_TobeStudiedProblem_ReFreshCache();
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
        //添加历史版本
        async AddVersionRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objgs_TobeStudiedProblemVEN = new clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN();
            this.PutDataTogs_TobeStudiedProblemVClass(objgs_TobeStudiedProblemVEN);
            try {
                const responseText2 = await (0, clsgs_TobeStudiedProblemVWApi_js_1.gs_TobeStudiedProblemV_AddNewRecordAsync)(objgs_TobeStudiedProblemVEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and problemId=" + $("#hidProblemId").val();
                    var intVersionCount = await (0, clsgs_TobeStudiedProblemVWApi_js_1.gs_TobeStudiedProblemV_GetRecCountByCondAsync)(strWhereCond2);
                    var objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN();
                    objgs_TobeStudiedProblemEN.problemId = $("#hidProblemId").val();
                    objgs_TobeStudiedProblemEN.versionCount = intVersionCount;
                    objgs_TobeStudiedProblemEN.sf_UpdFldSetStr = objgs_TobeStudiedProblemEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objgs_TobeStudiedProblemEN.problemId == "" || objgs_TobeStudiedProblemEN.problemId == undefined) {
                        throw "关键字不能为空!";
                    }
                    const responseText = (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_UpdateRecordAsync)(objgs_TobeStudiedProblemEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            return true;
                        }
                        else {
                            var strInfo = `添加历史版本数不成功!`;
                            alert(strInfo);
                            console.log("添加历史版本数不成功");
                            //CloseWindow();
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
        PutDataTogs_TobeStudiedProblemVClass(pobjgs_TobeStudiedProblemVEN) {
            pobjgs_TobeStudiedProblemVEN.problemId = $("#hidProblemId").val();
            pobjgs_TobeStudiedProblemVEN.topicId = $("#hidTopicRelaId").val(); // 主题编号
            pobjgs_TobeStudiedProblemVEN.isSubmit = false; // 是否提交
            //pobjgs_TobeStudiedProblemVEN.problemTitle = this.problemTitle;// 是否提交
            pobjgs_TobeStudiedProblemVEN.problemContent = this.problemContent; // 会议内容
            pobjgs_TobeStudiedProblemVEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjgs_TobeStudiedProblemVEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改人
            var strYmd = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd();
            if (this.problemDate == "") {
                pobjgs_TobeStudiedProblemVEN.problemDate = strYmd; // 会议日期
            }
            else {
                pobjgs_TobeStudiedProblemVEN.problemDate = this.problemDate; // 会议日期
            }
            pobjgs_TobeStudiedProblemVEN.memo = this.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strProblemId) {
            this.btnSubmit_gs_TobeStudiedProblem = "确认修改";
            this.btnCancel_gs_TobeStudiedProblem = "取消修改";
            this.KeyId = strProblemId;
            try {
                //1、获取当前用户的色码块
                const responseText1 = await this.GetLoginUserColorCode();
                const responseText2 = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_GetObjByProblemIdAsync)(strProblemId);
                var objgs_TobeStudiedProblemEN = responseText2;
                const conGetDataFromClass = await this.GetDataFromgs_TobeStudiedProblemClass(objgs_TobeStudiedProblemEN);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        //获取当前登录用户的色码在该主题下
        async GetLoginUserColorCode() {
            var strTopicId = $("#hidTopicRelaId").val();
            //主题用户关系
            var arrRTUserRelaObjLst = [];
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            $("#hidUserId").val(strUserId);
            ////获取缓存色码表；
            //var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
            ////获取色码数据
            //const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
            //    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;
            //});
            var strWhereCondUser = ` 1=1 And ${clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserId} ='${strUserId}'`;
            //根据当前登录人和主题Id 查询用户排序号，根据排序号 得到色码对应色块；
            const responseText = await (0, clsvRTUserRelaWApi_js_1.vRTUserRela_GetFirstObjAsync)(strWhereCondUser).then((jsonData) => {
                var objRtUsersEN = jsonData;
                //通过用户的编号，获取色码表对应的编号色码
                //var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRtUsersEN.orderNum);
                if (objRtUsersEN != null) {
                    $("#hidColorCode").val(objRtUsersEN.colorCode);
                    //这里用固定背景色；
                    //$("#hidColorCode").val(objRtUsersEN.userBgColor);
                }
            });
        }
    }
    exports.gs_TobeStudiedProblem_EditEx = gs_TobeStudiedProblem_EditEx;
});
