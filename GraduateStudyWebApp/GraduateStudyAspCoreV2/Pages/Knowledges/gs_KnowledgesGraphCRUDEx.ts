﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_KnowledgesGraphCRUDEx
表名:gs_KnowledgesGraph(01120873)
生成代码版本:2021.01.27.2
生成日期:2021/01/27 23:33:31
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关
模块英文名:Knowledges
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { BindTab, GetCheckedKeyIds, GetFirstCheckedKeyId, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { gs_KnowledgesGraph_EditEx } from "./gs_KnowledgesGraph_EditEx.js";
import { clsgs_KnowledgesGraphEN } from "../TS/L0_Entity/Knowledges_Share/clsgs_KnowledgesGraphEN.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { gs_KnowledgesGraphCRUD } from "../PagesBase/Knowledges_Share/gs_KnowledgesGraphCRUD.js";
import { GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
declare function ShowDialog_gs_KnowledgesGraph(strOpType): void;
declare function HideDialog_gs_KnowledgesGraph(): void;
declare var $;
declare var window;
/* gs_KnowledgesGraphCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_KnowledgesGraphCRUDEx extends gs_KnowledgesGraphCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortgs_KnowledgesGraphBy: string = "knowledgeGraphId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_gs_KnowledgesGraph4Func();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "gs_KnowledgesGraph":
                alert('该类没有绑定该函数：[this.BindGv_gs_KnowledgesGraph_Cache]！');
                //this.BindGv_gs_KnowledgesGraph_Cache();
                break;
        }
    }

    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: gs_KnowledgesGraphCRUDEx = new gs_KnowledgesGraphCRUDEx();
        var objPage_Edit: gs_KnowledgesGraph_EditEx = new gs_KnowledgesGraph_EditEx(objPage);
        switch (strCommandName) {
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
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
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
                var strMsg = '命令:' + strCommandName + "在函数(gs_KnowledgesGraphCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }


    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async Combinegs_KnowledgesGraphCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
            //    strWhereCond += ` And ${clsgs_KnowledgesGraphEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
            //}
            strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";

            if (this.courseId_q != "" && this.courseId_q != "0") {
                strWhereCond += ` And ${clsgs_KnowledgesGraphEN.con_CourseId} = '${this.courseId_q}'`;
            }
            if (this.knowledgeGraphName_q != "") {
                strWhereCond += ` And ${clsgs_KnowledgesGraphEN.con_KnowledgeGraphName} like '% ${this.knowledgeGraphName_q}%'`;
            }
            if (this.createUser_q != "") {
                strWhereCond += ` And ${clsgs_KnowledgesGraphEN.con_CreateUser} like '% ${this.createUser_q}%'`;
            }
            if (this.updDate_q != "") {
                strWhereCond += ` And ${clsgs_KnowledgesGraphEN.con_UpdDate} like '% ${this.updDate_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_KnowledgesGraphCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 显示gs_KnowledgesGraph对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrgs_KnowledgesGraphObjLst">需要绑定的对象列表</param>
   */
    public async BindTab_gs_KnowledgesGraph(divContainer: string, arrgs_KnowledgesGraphObjLst: Array<clsgs_KnowledgesGraphEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    fldName: "",
                    sortBy: "", sortFun: SortFun, getDataSource: "",
                    colHeader: "",
                    text: "",
                    tdClass: "text-left",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "knowledgeGraphName",
                    sortBy: "knowledgeGraphName",
                    sortFun: SortFun, getDataSource: "",
                    colHeader: "知识点图名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: () => { }
                },
                {
                    fldName: "createUser",
                    sortBy: "createUser",
                    sortFun: SortFun, getDataSource: "",
                    colHeader: "建立用户",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    sortBy: "updDate",
                    sortFun: SortFun, getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    sortBy: "updUser",
                    sortFun: SortFun, getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: () => { }
                },
                {
                    fldName: "id_CurrEduCls",
                    sortBy: "id_CurrEduCls",
                    sortFun: SortFun, getDataSource: "",
                    colHeader: "当前教学班流水号",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: () => { }
                },
                {
                    fldName: "courseId",
                    sortBy: "courseId",
                    sortFun: SortFun, getDataSource: "",
                    colHeader: "课程Id",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "逻辑结构图",
                    text: "构建", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 8,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDetailRecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
            ];
        BindTab(o, arrgs_KnowledgesGraphObjLst, arrDataColumn, "knowledgeGraphId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
  */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            gs_KnowledgesGraphCRUD.CourseId_Cache = clsPublocalStorage.courseId;
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            gs_KnowledgesGraphCRUD.sortgs_KnowledgesGraphBy = "knowledgeGraphName Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_gs_KnowledgesGraph4Func();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }
}