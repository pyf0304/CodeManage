/**
* 类名:CurrEduClsStu_EditEx(界面:CurrEduClsStuCRUD)
* 表名:CurrEduClsStu(01120125)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/07 19:49:34
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:日常运行(DailyRunning)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/DailyRunning_Share/CurrEduClsStu_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsStuEN.js", "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js", "../TS/L0_Entity/UserManage_Share/clsStudentInfoEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsStu_EditEx = void 0;
    const CurrEduClsStu_Edit_js_1 = require("../PagesBase/DailyRunning_Share/CurrEduClsStu_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsCurrEduClsStuEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsStuEN.js");
    const clsvCurrEduClsStuEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js");
    const clsStudentInfoEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsStudentInfoEN.js");
    const clsCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsStuWApi.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js");
    const clsStudentInfoWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* CurrEduClsStu_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class CurrEduClsStu_EditEx extends CurrEduClsStu_Edit_js_1.CurrEduClsStu_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = CurrEduClsStu_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(CurrEduClsStu_EditEx.btn_Click)中没有被处理！";
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
                            }
                            else {
                                var returnBool = await this.AddNewRecordSave();
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName, returnBool.toString());
                                }
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            var returnBool = await this.UpdateRecordSave();
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In CurrEduClsStuCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.iShowList.BindGv(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName, returnBool.toString());
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
        /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSaveCurrEduClsStu(strid_CurrEduCls) {
            //获取用户，通过用户Id 查询学生表数据得到学生流水号；
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objCurrEduClsStuEN = new clsCurrEduClsStuEN_js_1.clsCurrEduClsStuEN();
            const responseText = await this.PutDataToCurrEduClsStu(objCurrEduClsStuEN, strid_CurrEduCls);
            try {
                //同一用户，同一主题 同一观点 只能添加一次；
                var strWhere = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "' And stuID = '" + strUserId + "'";
                //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
                const responseText = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经加入过该教学班了！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_AddNewRecordAsync)(objCurrEduClsStuEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //关闭列表
                    HideDialogOne();
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
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjCurrEduClsStuEN">数据传输的目的类对象</param>
    */
        async PutDataToCurrEduClsStu(pobjCurrEduClsStuEN, strid_CurrEduCls) {
            pobjCurrEduClsStuEN.Setid_CurrEduCls(strid_CurrEduCls); // 教学班
            //获取用户，通过用户Id 查询学生表数据得到学生流水号；
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strid_StudentInfo = "";
            var strSchoolTeam = "";
            var strSchoolYear = "";
            var strWhereCond = `1=1 And ${clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuID} = '${strUserId}'`;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText = await (0, clsStudentInfoWApi_js_1.StudentInfo_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                var objStudentInfoEN = jsonData;
                if (objStudentInfoEN != null) {
                    strid_StudentInfo = objStudentInfoEN.id_StudentInfo;
                }
            });
            pobjCurrEduClsStuEN.Setid_Stu(strid_StudentInfo); // 学生
            //pobjCurrEduClsStuEN.schoolTerm = this.schoolTerm;// 学期
            //pobjCurrEduClsStuEN.schoolYear = this.schoolYear;// 学年
            pobjCurrEduClsStuEN.SetModifyDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 
            pobjCurrEduClsStuEN.SetModifyUserID(strUserId); //
            pobjCurrEduClsStuEN.SetMemo(this.memo); // 备注
        }
        //确定选择 并添加到关系表中
        async btnCurrEduClsInTab_Click(strkeyId) {
            const response = await this.AddNewRecordSaveCurrEduClsStu(strkeyId);
        }
    }
    exports.CurrEduClsStu_EditEx = CurrEduClsStu_EditEx;
});
