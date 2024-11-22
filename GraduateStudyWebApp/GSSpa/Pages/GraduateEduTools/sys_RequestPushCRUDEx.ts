
/*-- -- -- -- -- -- -- -- -- -- --
类名:sys_RequestPushCRUDEx
表名:sys_RequestPush(01120726)
生成代码版本:2020.09.01.1
生成日期:2020/09/01 17:03:55
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培设置
模块英文名:GraduateEduTools
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clssys_RequestPushEN } from "../TS/L0_Entity/GraduateEduTools/clssys_RequestPushEN.js";
import { clssys_RequestPushENEx } from "../TS/L0_Entity/GraduateEduTools/clssys_RequestPushENEx.js";
import { sys_RequestPush_GetObjLstByPager_Cache, sys_RequestPush_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { sys_RequestPushCRUD } from "./sys_RequestPushCRUD.js";
import { sys_RequestPush_EditEx } from "./sys_RequestPush_EditEx.js";
declare function ShowDialog_sys_RequestPush(strOpType): void;
declare function HideDialog_sys_RequestPush(): void;
declare var $;
declare var window;
/* sys_RequestPushCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class sys_RequestPushCRUDEx extends sys_RequestPushCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortsys_RequestPushBy: string = "requestId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_sys_RequestPush();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "sys_RequestPush":
                alert('该类没有绑定该函数：[this.BindGv_sys_RequestPush_Cache]！');
                //this.BindGv_sys_RequestPush_Cache();
                break;
        }
    }

    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: sys_RequestPushCRUDEx = new sys_RequestPushCRUDEx();
        var objPage_Edit: sys_RequestPush_EditEx = new sys_RequestPush_EditEx(objPage);
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
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
                var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
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
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
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
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
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
                var strMsg = '命令:' + strCommandName + "在函数(sys_RequestPushCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            var strPushTypeId = $('#hidPushTypeId').val();
            if (strPushTypeId == "01") {
                $('#spanTitle').html("按教学班推送");
            }
            else {
                $('#spanTitle').html("按学生推送");
            }

            this.hidSortsys_RequestPushBy = "receiveUser Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const responseBindGv = await this.BindGv_sys_RequestPush4Func();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }


    /* 把所有的查询控件内容组合成一个条件串
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
   <returns>条件串(strWhereCond)</returns>
 */
    public Combinesys_RequestPushConditionObj(): clssys_RequestPushEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPushTypeId = $('#hidPushTypeId').val();
        var objsys_RequestPush_Cond: clssys_RequestPushEN = new clssys_RequestPushEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.ReceiveUser_q != "") {
                strWhereCond += ` And ${clssys_RequestPushEN.con_ReceiveUser} like '% ${this.ReceiveUser_q}%'`;
                objsys_RequestPush_Cond.SetCondFldValue(clssys_RequestPushEN.con_ReceiveUser, this.ReceiveUser_q, "like");
            }
            if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                strWhereCond += ` And ${clssys_RequestPushEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
                objsys_RequestPush_Cond.SetCondFldValue(clssys_RequestPushEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
            }
            if (strPushTypeId != "") {

                strWhereCond += ` And ${clssys_RequestPushEN.con_PushTypeId} = '${strPushTypeId}'`;
                objsys_RequestPush_Cond.SetCondFldValue(clssys_RequestPushEN.con_PushTypeId, strPushTypeId, "=");
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0010)在组合查询条件对象(Combinesys_RequestPushConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objsys_RequestPush_Cond;
    }


    /* 根据条件获取相应的对象列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv4Func)
 */
    public async BindGv_sys_RequestPush4Func() {
        if (this.hidSortsys_RequestPushBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortsys_RequestPushBy)为空，请检查！(In BindGv_sys_RequestPush_Cache)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.mstrListDiv;
        var objsys_RequestPush_Cond = this.Combinesys_RequestPushConditionObj();
        var strWhereCond = JSON.stringify(objsys_RequestPush_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrsys_RequestPushObjLst: Array<clssys_RequestPushEN> = [];
        var arrsys_RequestPushExObjLst: Array<clssys_RequestPushENEx> = [];
        try {
            this.RecCount = await sys_RequestPush_GetRecCountByCond_Cache(objsys_RequestPush_Cond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortsys_RequestPushBy,
                sortFun: (x, y) => { return 0; }
            };
            arrsys_RequestPushObjLst = await sys_RequestPush_GetObjLstByPager_Cache(objPagerPara);
            arrsys_RequestPushExObjLst = arrsys_RequestPushObjLst.map(this.CopyToEx);
            for (var objInFor of arrsys_RequestPushExObjLst) {
                const conFuncMap = await this.FuncMap(objInFor);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_sys_RequestPush4Func(strListDiv, arrsys_RequestPushExObjLst);
            console.log("完成BindGv_sys_RequestPush!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    /* 显示sys_RequestPush对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
     <param name = "divContainer">显示容器</param>
     <param name = "arrsys_RequestPushObjLst">需要绑定的对象列表</param>
   */
    public BindTab_sys_RequestPush4Func(divContainer: string, arrsys_RequestPushExObjLst: Array<clssys_RequestPushENEx>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    SortBy: "userName",
                    ColHeader: "接收用户",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    SortBy: "eduClsName",
                    ColHeader: "教学班",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "requestUser",
                    SortBy: "requestUser",
                    ColHeader: "推送人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "requestDate",
                    SortBy: "requestDate",
                    ColHeader: "推送日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                //{
                //    FldName: "",
                //    SortBy: "",
                //    ColHeader: "修改",
                //    Text: "修改",
                //    TdClass: "text-left",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    SortBy: "",
                //    ColHeader: "删除",
                //    Text: "删除",
                //    TdClass: "text-left",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrsys_RequestPushExObjLst, arrDataColumn, "requestId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }
}