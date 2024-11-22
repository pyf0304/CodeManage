(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/RTPaperRela_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTPaperRela_EditEx = void 0;
    /**
    * 类名:RTPaperRela_EditEx(界面:RTPaperRelaCRUD)
    * 表名:RTPaperRela(01120581)
    * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/06 22:44:09
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const RTPaperRela_Edit_js_1 = require("../PagesBase/GraduateEduTopic/RTPaperRela_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsRTPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsRTPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js");
    const clsvRTPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* RTPaperRela_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class RTPaperRela_EditEx extends RTPaperRela_Edit_js_1.RTPaperRela_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = RTPaperRela_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(RTPaperRela_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 根据关键字获取相应的记录的对象
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
    */
        async RtPaperRelaDetailRecord(lngmId) {
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            this.keyId = lngmId.toString();
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsvRTPaperRelaWApi_js_1.vRTPaperRela_GetObjBymIdAsync)(lngmId).then((jsonData) => {
                        var objRTPaperRelaEN = jsonData;
                        // //显示当前数据；
                        $("#txtTopicNameDetail").html(objRTPaperRelaEN.topicName);
                        $("#txtTopicContentDetail").html(objRTPaperRelaEN.topicContent);
                        $("#txtTopicProposePeopleDetail").html(objRTPaperRelaEN.topicProposePeople);
                        $("#txtPaperTitleDetail").html(objRTPaperRelaEN.paperTitle);
                        $("#txtPaperContentDetail").html(objRTPaperRelaEN.paperContent);
                        $("#txtAuthorDetail").html(objRTPaperRelaEN.author);
                        $("#txtPeriodicalDetail").html(objRTPaperRelaEN.periodical);
                        var objUser = arrUsers.find(x => x.userId == objRTPaperRelaEN.updUser);
                        if (objUser != null) {
                            $("#txtUserNameDetail").html(objUser.userName);
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
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjRTPaperRelaEN">数据传输的目的类对象</param>
    */
        async PutDataToRTPaperRelaClass(pobjRTPaperRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strPaperId = RTPaperRela_EditEx.Paper_Static;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjRTPaperRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTPaperRelaEN.SetPaperId(strPaperId); // 论文Id
            pobjRTPaperRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTPaperRelaEN.SetUpdUser(strUserId); // 修改人
            pobjRTPaperRelaEN.SetMemo(this.memo); // 备注
        }
        async SubmitPaperRecord(strPaperId) {
            this.keyId = strPaperId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_GetObjByPaperIdAsync)(strPaperId).then((jsonData) => {
                        var objPaperEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                        // //通过判断数据用户是否是当前登录用户；
                        if (objPaperEN.updUser == clsPublocalStorage_js_1.clsPublocalStorage.userId) {
                            //判断数据是否已审核
                            if (objPaperEN.isSubmit == false) {
                                const responseText3 = this.SubmitPaperRecordSave().then((jsonData) => {
                                });
                            }
                            else {
                                alert("当前数据已审核！");
                                return;
                            }
                        }
                        else {
                            alert("当前数据不是您所添加，不能修改！");
                            return;
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
        /* 论文审核
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async SubmitPaperRecordSave() {
            const strThisFuncName = this.SubmitPaperRecordSave.name;
            //
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(this.keyId);
            //设置提交状态；
            objPaperEN.SetIsSubmit(true);
            //this.PutDataToPaperClassAudit(objPaperEN);
            objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `操作成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            //刷新缓存
                            //vPaper_ReFreshThisCache();
                            //刷新缓存
                            (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            HideDialog();
                            this.iShowList.BindGv(clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName, returnBool.toString());
                        }
                        else {
                            var strInfo = `操作不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("操作失败");
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
        async PublicPaperRecord(strPaperId) {
            this.keyId = strPaperId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_GetObjByPaperIdAsync)(strPaperId).then((jsonData) => {
                        var objPaperEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                        // //通过判断数据用户是否是当前登录用户；
                        if (objPaperEN.updUser == clsPublocalStorage_js_1.clsPublocalStorage.userId) {
                            //判断数据是否已审核
                            if (objPaperEN.isSubmit == false) {
                                const responseText3 = this.PublicRecordSave().then((jsonData) => {
                                });
                            }
                            else {
                                alert("当前数据已审核！");
                                return;
                            }
                        }
                        else {
                            alert("当前数据不是您所添加，不能修改！");
                            return;
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
        /* 论文公开
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async PublicRecordSave() {
            const strThisFuncName = this.PublicRecordSave.name;
            //
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(this.keyId);
            //设置提交状态；
            objPaperEN.SetIsPublic(true);
            //this.PutDataToPaperClassAudit(objPaperEN);
            objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `操作成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            //刷新缓存
                            //vPaper_ReFreshThisCache();
                            //刷新缓存
                            (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            HideDialog();
                            this.iShowList.BindGv(clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName, returnBool.toString());
                        }
                        else {
                            var strInfo = `操作不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("操作失败");
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
        async btnIsSubmitPaper_Click(strKeyId) {
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitPaperRecord(strKeyId);
        }
        //小组论文写作 公开
        async btnIsPublicPaper_Click(strKeyId) {
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.PublicPaperRecord(strKeyId);
        }
        /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSavePaperRela(strPaperId) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            RTPaperRela_EditEx.Paper_Static = strPaperId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objRTPaperRelaEN = new clsRTPaperRelaEN_js_1.clsRTPaperRelaEN();
            this.PutDataToRTPaperRelaClass(objRTPaperRelaEN);
            try {
                // 同一主题 同一论文 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And paperId = '" + strPaperId + "'";
                const bolIsExist = await (0, clsRTPaperRelaWApi_js_1.RTPaperRela_IsExistRecordAsync)(strWhere);
                if (bolIsExist == true) {
                    var strMsg = `同一主题不能重复添加同一个论文！`;
                    alert(strMsg);
                    return false; //一定要有一个返回值，否则会出错！
                }
                const returnBool = await (0, clsRTPaperRelaWApi_js_1.RTPaperRela_AddNewRecordAsync)(objRTPaperRelaEN);
                if (returnBool == true) {
                    var strInfo = `添加成功!`;
                    //HideDialogThree();
                    //显示信息框
                    //alert(strInfo);
                    //this.iShowList.BindGv(clsRTPaperRelaEN._CurrTabName, returnBool.toString());
                    return true;
                }
                else {
                    var strInfo = `添加不成功!`;
                    //显示信息框
                    alert(strInfo);
                    return false;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        //确定选择的论文 并添加到关系表中
        btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            console.error('btnPaperRecordInTab_Click');
            //获取论文条件 02代表 小组成员论文数据；
            var strType = $("#hidstrType").val();
            //if (strType == "01") {
            //执行添加关系方法
            this.AddNewRecordSavePaperRela(strkeyId); //所有论文
            //}
            //else {
            //    //小组成员论文；
            //    //this.AddNewRecordSaveResearchResult();
            //}
        }
    }
    exports.RTPaperRela_EditEx = RTPaperRela_EditEx;
    RTPaperRela_EditEx.Paper_Static = "";
});
