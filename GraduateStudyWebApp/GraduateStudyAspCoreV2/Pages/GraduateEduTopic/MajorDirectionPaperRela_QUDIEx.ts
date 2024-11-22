/*-- -- -- -- -- -- -- -- -- -- --
类名:MajorDirectionPaperRela_QUDI_TSEx
表名:MajorDirectionPaperRela(01120554)
生成代码版本:2019.12.06.1
生成日期:2019/12/27 10:50:18
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { MajorDirectionPaperRela_EditEx } from "../GraduateEduPaper/MajorDirectionPaperRela_EditEx.js";
import { MajorDirectionPaperRelaCRUD } from "../PagesBase/GraduateEduPaper/MajorDirectionPaperRelaCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsXzMajorDirectionEN } from "../TS/L0_Entity/BaseInfo_Share/clsXzMajorDirectionEN.js";
import { clsXzMajorEN } from "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js";
import { clsMajorDirectionPaperRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvMajorDirectionPaperRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaEN.js";
import { XzMajorDirection_GetObjLstAsync } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js";
import { XzMajor_GetObjLstAsync } from "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js";
import { Paper_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vMajorDirectionPaperRela_GetObjLstByPagerAsync, vMajorDirectionPaperRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindDdl_ObjLst, BindTab, BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* MajorDirectionPaperRela_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class MajorDirectionPaperRela_QUDIEx extends MajorDirectionPaperRelaCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvMajorDirectionPaperRelaBy: string = "mId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_vMajorDirectionPaperRela();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vMajorDirectionPaperRela":
                alert('该类没有绑定该函数：[this.BindGv_vMajorDirectionPaperRela_Cache]！');
                //this.BindGv_vMajorDirectionPaperRela_Cache();
                break;
            default:
                strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);
                break;
        }
    }

    /**
    * 按钮单击,用于调用Js函数中btn_Click
    * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    **/
    public static btn_Click(strCommandName: string, strKeyId: string) {
        let objPage: MajorDirectionPaperRela_QUDIEx;
        if (MajorDirectionPaperRelaCRUD.objPage_CRUD == null) {
            MajorDirectionPaperRelaCRUD.objPage_CRUD = new MajorDirectionPaperRela_QUDIEx();
            objPage = <MajorDirectionPaperRela_QUDIEx>MajorDirectionPaperRelaCRUD.objPage_CRUD;
        }
        else {
            objPage = <MajorDirectionPaperRela_QUDIEx>MajorDirectionPaperRelaCRUD.objPage_CRUD;
        }
        const objPage_Edit: MajorDirectionPaperRela_EditEx = new MajorDirectionPaperRela_EditEx(objPage);
        let strMsg = '';
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
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
            case "UpdateRecordInTab":            //修改记录InTab
                strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
                if (IsNullOrEmpty(strKeyId) == true) {
                    const strMsg = "请选择需要修改的记录！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if (strCommandName == "UpdateRecordInTab") {
                    objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                }
                else {
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                }
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "ExportExcel":            //导出Excel
                //objPage.btnExportExcel_Click();
                //alert("导出Excel功能还没有开通！");
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
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
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
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
                strMsg = '命令:' + strCommandName + "在函数(MajorDirectionPaperRela_QUDIExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPublocalStorage.userId != "") {
              

                var strUserId = clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage.roleId;

                //管理员 判断角色 
                if (strRoleId == "00620001") {

                    $("#btnDelRecord").show();
                }
                else {
                    //学生00620003 教师 
                    $("#btnDelRecord").show();

                }
                $("#hidUserId").val(strUserId);
                //1、为下拉框设置数据源,绑定列表数据
                const ddl_MajorDirectionId = await this.BindDdl_MajorDirectionId("ddlMajorDirectionId");
                const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId");
                const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor("ddlid_XzMajor_q");
                MajorDirectionPaperRelaCRUD.sortvMajorDirectionPaperRelaBy = "MajorDirectionENName Asc";
                var strWhereCond = await this.CombinevMajorDirectionPaperRelaCondition();
                const responseText = await vMajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    this.recCount = jsonData;
                });
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vMajorDirectionPaperRela();
                $("#divLoading").hide();
            }
            else {
                window.top.location.href = "../Web/Login";
            }
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    /// <summary>
    /// 为下拉框获取数据,从表:[XzMajor]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind4QueryRegion)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_id_XzMajor(ddlid_XzMajor: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlid_XzMajor);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = XzMajor_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrXzMajorObjLst: Array<clsXzMajorEN> = <Array<clsXzMajorEN>>jsonData;
                    BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "专业");
                    console.log("完成BindDdl_id_XzMajor!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /// <summary>
    /// 为下拉框获取数据,从表:[Paper]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_PaperId(ddlPaperId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlPaperId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlPaperId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrPaperObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>jsonData;
                    BindDdl_ObjLst(ddlPaperId, arrPaperObjLst, clsPaperEN.con_PaperId, clsPaperEN.con_PaperTitle, "");
                    console.log("完成BindDdl_PaperId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /// <summary>
    /// 为下拉框获取数据,从表:[XzMajorDirection]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_MajorDirectionId(ddlMajorDirectionId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlMajorDirectionId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlMajorDirectionId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = XzMajorDirection_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrXzMajorDirectionObjLst: Array<clsXzMajorDirectionEN> = <Array<clsXzMajorDirectionEN>>jsonData;
                    BindDdl_ObjLst(ddlMajorDirectionId, arrXzMajorDirectionObjLst, clsXzMajorDirectionEN.con_MajorDirectionId, clsXzMajorDirectionEN.con_MajorDirectionName, "专业方向");
                    console.log("完成BindDdl_MajorDirectionId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    public async CombinevMajorDirectionPaperRelaCondition(): Promise<string>  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
            }
            if (this.majorDirectionName_q != "") {
                strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_MajorDirectionName} like '% ${this.majorDirectionName_q}%'`;
            }
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }
           
            //if (this.IsQuotethesis_q == true) {
            //    strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_IsQuotethesis} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_IsQuotethesis} = '0'`;
            //}

            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            if (strUserId != "") {
             
                $("#hidUserId").val(strUserId);

                //判断角色 管理员
                if (strRoleId == "00620001") {

                    $("#btnDelRecord").show();
                }
                ////判断角色 教师
                //else if (objvUserRoleRelation.roleId == "00620002") {
                //    $("#btnDelRecord").hide();
                //    //可以查看所有；
                //}
                else {
                    $("#btnDelRecord").show();
                    //学生00620003
                    //只能查看自己的数据；或公开的数据；
                    strWhereCond += ` And updUser = '${strUserId}'`;
                }
            }
            else {
                window.top.location.href = "../Web/Login";
                //window.location.href = "/GraduateStudyWebApp/WebApp/Login";
            }


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineMajorDirectionPaperRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 显示vMajorDirectionPaperRela对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrMajorDirectionPaperRelaObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vMajorDirectionPaperRela(divContainer: string, arrvMajorDirectionPaperRelaObjLst: Array<clsvMajorDirectionPaperRelaEN>) {
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
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionName",
                    colHeader: "研究方向名",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "MajorDirectionENName",
                    colHeader: "研究方向英文",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "isVisible",
                //    colHeader: "是否显示",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
              
                //{
                //    fldName: "researchQuestion",
                //    colHeader: "研究问题",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "keyword",
                //    colHeader: "关键字",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "literatureSources",
                //    colHeader: "文献来源",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "literatureLink",
                //    colHeader: "文献链接",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "uploadfileUrl",
                //    colHeader: "文件地址",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "isQuotethesis",
                //    colHeader: "是否引用论文",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "checker",
                //    colHeader: "审核人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "isChecked",
                //    colHeader: "是否检查",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "编辑人",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        BindTab_V(o, arrvMajorDirectionPaperRelaObjLst, arrDataColumn, "mId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

 
    /*
* 获取年月日
*/
    public getNowDate(): string {
        const date = new Date();
        let month: string | number = date.getMonth() + 1;
        let strDate: string | number = date.getDate();
        if (month <= 9) {
            month = "0" + month;
        }
        if (strDate <= 9) {
            strDate = "0" + strDate;
        }

        return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
    }

    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vMajorDirectionPaperRela() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevMajorDirectionPaperRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvMajorDirectionPaperRelaObjLst: Array<clsvMajorDirectionPaperRelaEN> = [];
        try {
            this.recCount = await vMajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: MajorDirectionPaperRelaCRUD.sortvMajorDirectionPaperRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vMajorDirectionPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvMajorDirectionPaperRelaObjLst = <Array<clsvMajorDirectionPaperRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvMajorDirectionPaperRelaObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vMajorDirectionPaperRela(strListDiv, arrvMajorDirectionPaperRelaObjLst);
            console.log("完成BindGv_vMajorDirectionPaperRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    /* 删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
 */
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }


            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseText2 = await this.BindGv_vMajorDirectionPaperRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

}