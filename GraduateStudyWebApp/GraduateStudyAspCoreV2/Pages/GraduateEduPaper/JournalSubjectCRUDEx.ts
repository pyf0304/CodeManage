﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:JournalSubjectCRUDEx(界面:JournalSubjectCRUD)
表名:JournalSubject(01120930)
生成代码版本:2021.06.19.1
生成日期:2021/06/20 00:53:33
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { JournalSubjectCRUD } from "../PagesBase/GraduateEduPaper/JournalSubjectCRUD.js";
import { JournalSubject_ReFreshCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js";
import { JournalSubjectEx_ImportDataFromCsv } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsJournalSubjectExWApi.js";
import { GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindTab, confirm_del, GetCheckedKeyIds, GetFirstCheckedKeyId } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";

import { IShowList } from "../TS/PubFun/IShowList.js";

import { JournalSubject_EditEx } from "./JournalSubject_EditEx.js";
declare var strCsv: string;
declare var $;
/* JournalSubjectCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class JournalSubjectCRUDEx extends JournalSubjectCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortJournalSubjectBy: string = "journalSubjectId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        alert('该类没有绑定该函数：[this.BindGv_JournalSubject]！');
        //this.BindGv_JournalSubject();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "JournalSubject":
                this.BindGv_JournalSubject4Func();
                break;
            default:
                var strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);
                break;
        }
    }

    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: JournalSubjectCRUDEx = new JournalSubjectCRUDEx();
        var objPage_Edit: JournalSubject_EditEx = new JournalSubject_EditEx(objPage);
        switch (strCommandName) {
            case "CloseExcelDiv":    //查询记录
                objPage.btnCloseExcelDiv_Click();
                break;
            case "ImportData":    //查询记录
                objPage.btnImportData_Click();
                break;
            case "ImportDataFromExcel":    //查询记录
                objPage.btnImportDataFromExcel_Click();
                break;
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage_Edit.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
                if (IsNullOrEmpty(strKeyId) == true) {
                    var strMsg = "请选择需要修改的记录！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
            case "UpdateRecordInTab":            //修改记录InTab
                objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "ExportExcel":            //导出Excel
                objPage.btnExportExcel_Click();
                //alert("导出Excel功能还没有开通！");
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                if (confirm_del(arrKeyIds.length) == false) {
                    return;
                }
                objPage.btnDelRecord_Click();
                break;
            case "DelRecordInTab":   //删除记录InTab 
                objPage.btnDelRecordInTab_Click(strKeyId);
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要下移的记录！");
                    return;
                }
                //objPage.btnDownMove_Click();
                break;
            case "ReOrder":            //重序记录
                //objPage.btnReOrder_Click();
                break;
            default:
                var strMsg = '命令:' + strCommandName + "在函数(JournalSubjectCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }




    public async btnCloseExcelDiv_Click() {
        //$("#divImportExcel").css("display", "block");
        $("#divImportExcel").css("display", "none");
    }
    public async btnImportDataFromExcel_Click() {
        $("#divImportExcel").css("display", "block");
        //$("#divImportExcel").css("display", "none");

    }
    public async btnImportData_Click() {
        //$("#divImportExcel").css("display", "block");
        //$("#divImportExcel").css("display", "none");

        //JournalSubject.JournalSubjectEx_ImportDataFromCsv(csv, strUserId);
        console.log("btnImportData_Click");
        var strCsv1 = strCsv;
        if (IsNullOrEmpty(strCsv1)) {
            var strMsg: string = `Excel数据为空，请选择一个Excel文件！`;
            console.error("Error: ", strMsg);
            alert(strMsg);
            return;
        }

        var strUserId = clsPublocalStorage.userId;

        try {

            const responseText = await JournalSubjectEx_ImportDataFromCsv(strCsv1, strUserId);
            var returnInt: number = responseText;
            if (returnInt > 0) {

                JournalSubject_ReFreshCache();
                const responseBindGv = await this.BindGv_JournalSubject4Func();
                var strMsg: string = `已导入了:[${returnInt}]条记录.`;
                alert(strMsg);
            }
            return returnInt;
        }
        catch (e) {
            var strMsg: string = `导入Excel不成功,${e}.`;
            console.error(strMsg);
            alert(strMsg);
            return false;
        }
    }
}