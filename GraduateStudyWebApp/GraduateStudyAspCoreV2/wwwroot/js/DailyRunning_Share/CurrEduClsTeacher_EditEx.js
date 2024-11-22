(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/DailyRunning_Share/CurrEduClsTeacher_Edit.js", "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsTeacherEN.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsTeacher_EditEx = void 0;
    /**
    * 类名:CurrEduClsTeacher_EditEx(界面:CurrEduClsTeacherCRUD)
    * 表名:CurrEduClsTeacher(01120124)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/08 11:32:15
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:日常运行(DailyRunning)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const CurrEduClsTeacher_Edit_js_1 = require("../PagesBase/DailyRunning_Share/CurrEduClsTeacher_Edit.js");
    const clsvCurrEduClsTeacherEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsTeacherEN.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* CurrEduClsTeacher_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class CurrEduClsTeacher_EditEx extends CurrEduClsTeacher_Edit_js_1.CurrEduClsTeacher_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = CurrEduClsTeacher_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(CurrEduClsTeacher_EditEx.btn_Click)中没有被处理！";
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
                                //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                                //var returnBool2: boolean = jsonData;
                                //if (returnBool2 == true)
                                //{
                                //HideDialog();
                                //this.iShowList.BindGv(clsvCurrEduClsTeacherEN._CurrTabName, returnBool.toString());
                                //}
                                //});
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        HideDialog();
                                        this.iShowList.BindGv(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN._CurrTabName, returnBool.toString());
                                    }
                                });
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                strInfo += "(In CurrEduClsTeacherCRUD.btnOKUpd_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN._CurrTabName, returnBool.toString());
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
    }
    exports.CurrEduClsTeacher_EditEx = CurrEduClsTeacher_EditEx;
});
