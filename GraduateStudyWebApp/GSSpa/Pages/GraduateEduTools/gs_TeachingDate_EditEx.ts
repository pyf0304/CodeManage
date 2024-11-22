
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TeachingDate_EditEx
表名:gs_TeachingDate(01120684)
生成代码版本:2020.07.25.1
生成日期:2020/07/27 14:20:26
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研培设置
模块英文名:GraduateEduTools
框架-层名:WA_编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { gs_TeachingDate_Edit } from "./gs_TeachingDate_Edit.js";
//import { gs_TeachingDateCRUDEx } from "./gs_TeachingDateCRUDEx.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsgs_TeachingDateEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js";
import { clsvgs_TeachingDateEN } from "../TS/L0_Entity/GraduateEduTools/clsvgs_TeachingDateEN.js";
import { gs_TeachingDate_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { SysCommentEx_UpdateCommentWeekAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js";
declare function ShowDialog_gs_TeachingDate(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_TeachingDate(): void;
declare var $;
declare var window;
/* gs_TeachingDate_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class gs_TeachingDate_EditEx extends gs_TeachingDate_Edit {

 
    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    */
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        var objPage = gs_TeachingDate_Edit.objPage_Edit;
        //if (objPage == null) {
        //    var objgs_TeachingDateCRUD: gs_TeachingDateCRUDEx = new gs_TeachingDateCRUDEx();
        //    objPage = new gs_TeachingDate_EditEx(objgs_TeachingDateCRUD);
        //}
        switch (strCommandName) {
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage.btnAddNewRecord_Click();
                break;
         
            case "UpdateRecordInTab":            //修改记录InTab
                objPage.btnUpdateRecordInTab_Click(strKeyId);
                break;
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                var strMsg = '命令:' + strCommandName + "在函数(gs_TeachingDate_EditExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }


    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
*/
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_TeachingDate;
        //判断如果教学班文本框没有数据，那么就取标题栏下拉框的缓存数据
        if ($("#txtid_CurrEduCls").val() == "") {
            var strId_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        }
        else {
            var strId_CurrEduCls: string = $("#txtid_CurrEduCls").val();
        }

        try {
            //判断session是否失效
            if (clsPubSessionStorage.GetSession_UserId() != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.OpType == "AddWithMaxId") {
                            //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                            //var returnKeyId: string = <string>jsonData;
                            //if (clsString.IsNullOrEmpty(returnKeyId) == false)
                            //{
                            //HideDialog_gs_TeachingDate();
                            //this.iShowList.BindGv_Cache(clsvgs_TeachingDateEN._CurrTabName);
                            //}
                            //});
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    HideDialog_gs_TeachingDate();
                                    this.iShowList.BindGv(clsvgs_TeachingDateEN._CurrTabName, "");
                                    //数据同步；
                                    const responseText4 = gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync(strId_CurrEduCls, clsPubSessionStorage.GetSession_UserId());
                                    var returnBool3: boolean = !!responseText4;
                                    if (returnBool3 == true) {
                                        const responseText5 = SysCommentEx_UpdateCommentWeekAsync(strId_CurrEduCls, clsPubSessionStorage.GetSession_UserId());
                                        var returnBool5: boolean = !!responseText5;
                                        if (returnBool5 == true) {
                                            console.log("同步成功");
                                        } else {
                                            console.log("同步数据成功,但同步评论出错");
                                           
                                        }
                                    }
                                    else {
                                        console.log("同步失败");
                                    }
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In gs_TeachingDate_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog_gs_TeachingDate();
                                this.iShowList.BindGv(clsvgs_TeachingDateEN._CurrTabName, "");
                                //数据同步；
                                const responseText4 = gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync(strId_CurrEduCls, clsPubSessionStorage.GetSession_UserId());
                                var returnBool3: boolean = !!responseText4;
                                if (returnBool3 == true) {
                                    console.log("同步成功");
                                }
                                else {
                                    console.log("同步失败");
                                }
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`
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
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

    /* 在数据表里修改记录
   (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
  */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
       
        this.KeyId = strKeyId;
        this.OpType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            this.SetEventFunc();
            ShowDialog_gs_TeachingDate('Update');
            this.bolIsLoadEditRegion = true;  //
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        else {
            ShowDialog_gs_TeachingDate('Update');
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        //关键字存放
        $("#hidgs_DateId").val(strKeyId);
    }

    /* 修改记录
   (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async UpdateRecordSave() {
        this.DivName = "divUpdateRecordSave";
        var objgs_TeachingDateEN: clsgs_TeachingDateEN = new clsgs_TeachingDateEN();
        var strKeyId = $("#hidgs_DateId").val();
        objgs_TeachingDateEN.mId = Number(strKeyId);
        this.PutDataTogs_TeachingDateClass(objgs_TeachingDateEN);
        objgs_TeachingDateEN.sf_UpdFldSetStr = objgs_TeachingDateEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_TeachingDateEN.mId == 0 || objgs_TeachingDateEN.mId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await gs_TeachingDate_UpdateRecordAsync(objgs_TeachingDateEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //gs_TeachingDate_ReFreshCache(gs_TeachingDate_Edit.strid_CurrEduCls_Cache);
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            this.SetEventFunc();
            $("#divLoading").hide();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjgs_TeachingDateEN">数据传输的目的类对象</param>
  */
    public PutDataTogs_TeachingDateClass(pobjgs_TeachingDateEN: clsgs_TeachingDateEN) {
        pobjgs_TeachingDateEN.id_CurrEduCls = this.id_CurrEduCls;// 当前教学班流水号
        pobjgs_TeachingDateEN.startDate = this.startDate;// 开始日期
        pobjgs_TeachingDateEN.endDate = this.endDate;// 截止日期
        pobjgs_TeachingDateEN.updDate = clsPubFun4Web.getNowDate_ymd();// 修改日期
        pobjgs_TeachingDateEN.updUser = clsPubSessionStorage.GetSession_UserId();
        pobjgs_TeachingDateEN.memo = this.memo;// 备注
    }

}