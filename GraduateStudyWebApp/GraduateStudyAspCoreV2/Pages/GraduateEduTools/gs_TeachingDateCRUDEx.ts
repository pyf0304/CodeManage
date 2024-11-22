
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";

import { gs_TeachingDate_EditEx } from "./gs_TeachingDate_EditEx.js";
import { BindTab, BindTab_V, GetCheckedKeyIds, GetFirstCheckedKeyId, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsvgs_TeachingDateEN } from "../TS/L0_Entity/GraduateEduTools/clsvgs_TeachingDateEN.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { vgs_TeachingDate_GetObjLstByPagerAsync, vgs_TeachingDate_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsvgs_TeachingDateWApi.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { gs_TeachingDateCRUD } from "../PagesBase/GraduateEduTools/gs_TeachingDateCRUD.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
declare function ShowDialog_gs_TeachingDate(strOpType): void;
declare function HideDialog_vgs_TeachingDate(): void;
declare var $;
declare var window;
/* gs_TeachingDateCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_TeachingDateCRUDEx extends gs_TeachingDateCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvgs_TeachingDateBy: string = "mId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 15;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_vgs_TeachingDate();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "vgs_TeachingDate":
                alert('该类没有绑定该函数：[this.BindGv_vgs_TeachingDate_Cache]！');
                //this.BindGv_vgs_TeachingDate_Cache();
                break;
        }
    }
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async Combinevgs_TeachingDateCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.StartDate_q != "") {
            //    strWhereCond += ` And ${clsvgs_TeachingDateEN.con_StartDate} like '% ${this.StartDate_q}%'`;
            //}
            //if (this.EndDate_q != "") {
            //    strWhereCond += ` And ${clsvgs_TeachingDateEN.con_EndDate} like '% ${this.EndDate_q}%'`;
            //}

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            //判断角色 
            //管理员
            if (strRoleId == "00620001") {



            }
            else if (strRoleId == "00620002") {

                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

                //只查询自己创建的教学班数据；
                strWhereCond += " and id_CurrEduCls in (select id_CurrEduCls from CurrEduCls where updUser = '" + strUserId + "')";

                //$("#btnCancelSubmit").hide();
            }
            else {

            }
            $("#hidUserId").val(strUserId);
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_TeachingDateCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vgs_TeachingDate() {
        if (gs_TeachingDateCRUD.sortvgs_TeachingDateBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_TeachingDateBy)为空，请检查！(In BindGv_vgs_TeachingDate)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.Combinevgs_TeachingDateCondition();
        
        let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvgs_TeachingDateObjLst: Array<clsvgs_TeachingDateEN> = [];
        try {
            this.recCount = await vgs_TeachingDate_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: gs_TeachingDateCRUD.sortvgs_TeachingDateBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_TeachingDate_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_TeachingDateObjLst = <Array<clsvgs_TeachingDateEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
        try {
            this.BindTab_vgs_TeachingDate(strListDiv, arrvgs_TeachingDateObjLst);
            console.log("完成BindGv_vgs_TeachingDate!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            //console.trace();
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vgs_TeachingDate对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrgs_TeachingDateObjLst">需要绑定的对象列表</param>
     */
    public async BindTab_vgs_TeachingDate(divContainer: string, arrvgs_TeachingDateObjLst: Array<clsvgs_TeachingDateEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    fldName: "",
                    colHeader: "",
                    text: "",
                    tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "currEduClsId",
                    colHeader: "当前教学班Id",
                    text: "",
                    tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: () => { }
                },
                {
                    fldName: "eduClsName",
                    colHeader: "教学班名称",
                    text: "",
                    tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: () => { }
                },
                {
                    fldName: "startDate",
                    colHeader: "开始日期",
                    text: "",
                    tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: () => { }
                },
                {
                    fldName: "endDate",
                    colHeader: "截止日期",
                    text: "",
                    tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "修改",
                    text: "修改",
                    tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    fldName: "",
                    colHeader: "删除",
                    text: "删除",
                    tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        BindTab_V(o, arrvgs_TeachingDateObjLst, arrDataColumn, "mId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }
    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: gs_TeachingDateCRUDEx = new gs_TeachingDateCRUDEx();
        var objPage_Edit: gs_TeachingDate_EditEx = new gs_TeachingDate_EditEx(objPage);
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
                var strMsg = '命令:' + strCommandName + "在函数(gs_TeachingDateCRUDExEx.btn_Click)中没有被处理！";
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
            ////建立缓存
            //
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            gs_TeachingDateCRUD.sortvgs_TeachingDateBy = "startDate Asc";
            this.divName4Pager = "divPager";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vgs_TeachingDate();
            $("#divLoading").hide();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

   // /* 在数据表里修改记录
   // (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   //*/
   // public async btnUpdateRecordInTab_Click(strKeyId: string) {
   //     this.opType = "Update";
   //     if (strKeyId == "") {
   //         alert("请选择需要修改的记录！");
   //         return;
   //     }
   //     if (this.bolIsLoadEditRegion == false)  //
   //     {
   //         const responseBool = await this.AddDPV_Edit(this.divName4Edit);
   //         // 为编辑区绑定下拉框
   //         const conBindDdl = await this.BindDdl4EditRegion();
   //         this.SetEventFunc();
   //         ShowDialog_gs_TeachingDate('Update');
   //         this.bolIsLoadEditRegion = true;  //
   //         var lngKeyId = Number(strKeyId);
   //         this.UpdateRecord(lngKeyId);
   //     }
   //     else {
   //         ShowDialog_gs_TeachingDate('Update');
   //         var lngKeyId = Number(strKeyId);
   //         this.UpdateRecord(lngKeyId);
   //     }
   // }
   // /// <summary>
   // /// 在当前界面中，导入编辑区域
   // /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
   // /// </summary>
   // /// <returns></returns>
   // public async AddDPV_Edit(divName4Edit) {
   //     var strUrl: string = "./gs_TeachingDate_Edit/";
   //     console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
   //     return new Promise(function (resolve, reject) {
   //         $.ajax({
   //             url: strUrl,
   //             method: "GET",
   //             dataType: "html",
   //             data: {},
   //             success: function (data) {
   //                 console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
   //                 $('#' + divName4Edit).html(data);
   //                 resolve(true);
   //                 //setTimeout(() => { clsEditObj.BindTab(); }, 100);
   //                 //clsEditObj.BindTab();
   //             },
   //             error: (e) => {
   //                 console.error(e);
   //                 reject(e);
   //             }
   //         });
   //     });
   // };
}