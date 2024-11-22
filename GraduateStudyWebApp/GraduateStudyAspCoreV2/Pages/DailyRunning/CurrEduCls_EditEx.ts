﻿
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
import { CurrEduCls_Edit } from "../PagesBase/DailyRunning_Share/CurrEduCls_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsCurrEduClsEN } from "../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js";
import { clsvCurrEduClsEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js";
import { clsgs_TeachingDateEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js";
import { CurrEduCls_GetMaxStrIdAsync, CurrEduCls_GetObjByid_CurrEduClsAsync, CurrEduCls_UpdateRecordAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { gs_TeachingDate_AddNewRecordAsync, gs_TeachingDate_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { IsNullOrEmpty } from "../TS/PubFun/clsString.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;

declare function ShowDialogOne(strOpType): void;
declare function HideDialogOne(): void;

declare var $;
declare var window;
 /* CurrEduCls_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class CurrEduCls_EditEx extends CurrEduCls_Edit
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 **/
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnEdit_Click.name;
const objPage = CurrEduCls_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
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
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnSubmit_Click.name;
        try {

            //判断session是否失效
            if (clsPublocalStorage.userId != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnKeyId: string = <string>jsonData;
                                if (IsNullOrEmpty(returnKeyId) == false) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsvCurrEduClsEN._CurrTabName, returnKeyId);
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsvCurrEduClsEN._CurrTabName, returnBool.toString());
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In CurrEduClsCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.iShowList.BindGv(clsvCurrEduClsEN._CurrTabName, returnBool.toString());
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
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
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }
    /* 为插入记录做准备工作
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
    public async AddNewSetDate() {
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
    public async btnUpdateRecord_Click(strKeyId: string) {
        this.opType = "Update";
        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        //读取session角色 来判断绑定不同数据列表
        //获取用户角色来判断显示不同的列表数据；
        var strUserId = clsPublocalStorage.userId;
        var strRoleId = clsPublocalStorage.roleId;

        //判断角色 
        //管理员
        if (strRoleId == "00620001") {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegionInDiv();
                ShowDialog('Update');
                this.bolIsLoadEditRegion = true;  //
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
            const responseText = await CurrEduCls_GetObjByid_CurrEduClsAsync(strKeyId);
            var objCurrEduClsEN: clsCurrEduClsEN = <clsCurrEduClsEN>responseText;
            if (objCurrEduClsEN.modifyUserID == strUserId) {
                if (this.bolIsLoadEditRegion == false)  //
                {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    ShowDialog('Update');
                    this.bolIsLoadEditRegion = true;  //
                    this.UpdateRecord(strKeyId);
                }
                else {
                    ShowDialog('Update');
                    this.UpdateRecord(strKeyId);
                }
            }
            else {
                var strInfo: string = `当前数据不是您添加，不可修改`;
                //显示信息框
                alert(strInfo);
                return;
            }
        }


    }

    /* 为插入记录做准备工作
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
    public async AddNewRecord() {
        //去掉提交按钮不可用状态
        $('#btnOKUpd').attr("disabled", "false");
        this.opType = "AddWithMaxId";
        //this.SetKeyReadOnly(false);
        this.btnSubmit_CurrEduCls = "确认添加";
        this.btnCancel_CurrEduCls = "取消添加";
        this.Clear();
        //wucCurrEduClsB1.id_CurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
        try {
            const responseText = await CurrEduCls_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表CurrEduCls的最大关键字为空，不成功，请检查!`;
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
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
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
    public async SetUpDate() {
        var strId_CurrEduCls = $("#txtid_CurrEduCls").val();

        var strCommandText: string = this.btnSubmit_Click.name;
        try {
            if (clsPublocalStorage.userId != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":

                        var objgs_TeachingDateEN: clsgs_TeachingDateEN = new clsgs_TeachingDateEN();
                        objgs_TeachingDateEN.Setid_CurrEduCls(strId_CurrEduCls);
                        objgs_TeachingDateEN.SetStartDate(this.startDate);
                        objgs_TeachingDateEN.SetEndDate(this.endDate);
                        objgs_TeachingDateEN.SetUpdDate(clsPubFun4Web.getNowDate());
                        objgs_TeachingDateEN.SetUpdUser(clsPublocalStorage.userId);
                        // this.PutDataToConceptClass(objConceptEN);
                        objgs_TeachingDateEN.sfUpdFldSetStr = objgs_TeachingDateEN.updFldString;//设置哪些字段被修改(脏字段)


                        try {
                            const responseText2 = await gs_TeachingDate_AddNewRecordAsync(objgs_TeachingDateEN);
                            var returnBool: boolean = !!responseText2;
                            if (returnBool == true) {

                                //更新教学班日期范围；把备注字段存放日期
                                var objCurrEduClsEN: clsCurrEduClsEN = new clsCurrEduClsEN();
                                objCurrEduClsEN.Setid_CurrEduCls(strId_CurrEduCls);
                                objCurrEduClsEN.SetMemo( this.startDate + "-" + this.endDate);
                                objCurrEduClsEN.sfUpdFldSetStr = objCurrEduClsEN.updFldString;//设置哪些字段被修改(脏字段)
                                const responseText3 = await CurrEduCls_UpdateRecordAsync(objCurrEduClsEN);
                                var returnBool: boolean = !!responseText3;
                                if (returnBool == true) {
                                    console.log("教学班更新成功");
                                    //数据同步；
                                    const responseText2 = await gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync(strId_CurrEduCls, clsPublocalStorage.userId);
                                    var returnBool2: boolean = !!responseText2;
                                    if (returnBool2 == true) {
                                        console.log("同步成功");
                                    }
                                    else {
                                        console.log("同步失败");
                                    }
                                }


                                var strInfo: string = `设置成功!`;
                                $('#lblResult46').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                                HideDialogOne();
                            }
                            else {
                                var strInfo: string = `设置失败!`;
                                $('#lblResult46').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                            }
                            return responseText2;//一定要有一个返回值，否则会出错！
                        }
                        catch (e) {
                            console.error('catch(e)=');
                            console.error(e);
                            var strMsg: string = `添加记录不成功,${e}.`;
                            alert(strMsg);
                            return false;//一定要有一个返回值，否则会出错！
                        }

                        break;
                    case "确认修改":
                        var mId = $("#hidgs_DateId").val();
                        if (mId != "") {
                            //更新教学班日期表
                            var objgs_TeachingDateEN: clsgs_TeachingDateEN = new clsgs_TeachingDateEN();
                            objgs_TeachingDateEN.SetmId( mId);
                            objgs_TeachingDateEN.Setid_CurrEduCls( strId_CurrEduCls);
                            objgs_TeachingDateEN.SetStartDate( this.startDate);
                            objgs_TeachingDateEN.SetEndDate( this.endDate);
                            objgs_TeachingDateEN.SetUpdDate( clsPubFun4Web.getNowDate());
                            objgs_TeachingDateEN.SetUpdUser( clsPublocalStorage.userId);

                            objgs_TeachingDateEN.sfUpdFldSetStr = objgs_TeachingDateEN.updFldString;//设置哪些字段被修改(脏字段)
                            const responseText2 = await gs_TeachingDate_UpdateRecordAsync(objgs_TeachingDateEN);
                            var returnBool: boolean = !!responseText2;
                            if (returnBool == true) {
                                console.log("教学班日期表更新成功");

                                //更新教学班日期范围字段
                                var objCurrEduClsEN: clsCurrEduClsEN = new clsCurrEduClsEN();
                                objCurrEduClsEN.Setid_CurrEduCls(strId_CurrEduCls);
                                objCurrEduClsEN.SetMemo(this.startDate + "-" + this.endDate);
                                objCurrEduClsEN.sfUpdFldSetStr = objCurrEduClsEN.updFldString;//设置哪些字段被修改(脏字段)
                                const responseText3 = await CurrEduCls_UpdateRecordAsync(objCurrEduClsEN);
                                var returnBool: boolean = !!responseText3;
                                if (returnBool == true) {
                                    console.log("教学班更新范围成功");
                                    //数据同步；
                                    const responseText4 = await gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync(strId_CurrEduCls, clsPublocalStorage.userId);
                                    var returnBool2: boolean = !!responseText4;
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

                                var strInfo: string = `设置成功!`;
                                $('#lblResult46').val(strInfo);
                                //显示信息框
                                alert(strInfo);
                                HideDialogOne();
                            }
                            else {
                                console.log("教学班日期范围更新失败");
                                var strInfo: string = `设置失败!`;
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
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
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
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }

        $("#divLoading").hide();
    }



    /*
* 开始时间
*/
    public set startDate(value: string) {
        $("#txtStartDate").val(value);
    }
    /*
    * 开始时间
   */
    public get startDate(): string {
        return $("#txtStartDate").val();
    }

    /*
* 结束时间
*/
    public set endDate(value: string) {
        $("#txtEndDate").val(value);
    }
    /*
    * 结束时间
   */
    public get endDate(): string {
        return $("#txtEndDate").val();
    }
}