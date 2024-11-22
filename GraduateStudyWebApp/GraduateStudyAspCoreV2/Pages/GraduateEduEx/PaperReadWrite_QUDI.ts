
import { PaperReadWrite_EditEx } from "../GraduateEduPaper/PaperReadWrite_EditEx.js";
import { PaperReadWriteCRUD } from "../PagesBase/GraduateEduPaper/PaperReadWriteCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { clsvPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { PaperReadWrite_GetObjByPaperRWIdAsync, PaperReadWrite_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js";
import { vPaperReadWrite_GetObjLstByPagerAsync, vPaperReadWrite_GetRecCountByCondAsync, vPaperReadWrite_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { vPaperSubViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { clsPaperReadWriteWApiEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
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
declare var strAddressAndPort;
declare var strCurrPrjId;
declare var $;
declare var window;
/* PaperReadWrite_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PaperReadWrite_QUDI extends PaperReadWriteCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperReadWriteBy: string = "paperRWId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_vPaperReadWrite();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vPaperReadWrite":
                alert('该类没有绑定该函数：[this.BindGv_vPaperReadWrite_Cache]！');
                //this.BindGv_vPaperReadWrite_Cache();
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
        let objPage: PaperReadWrite_QUDI;
        if (PaperReadWriteCRUD.objPage_CRUD == null) {
            PaperReadWriteCRUD.objPage_CRUD = new PaperReadWrite_QUDI();
            objPage = <PaperReadWrite_QUDI>PaperReadWriteCRUD.objPage_CRUD;
        }
        else {
            objPage = <PaperReadWrite_QUDI>PaperReadWriteCRUD.objPage_CRUD;
        }
        const objPage_Edit: PaperReadWrite_EditEx = new PaperReadWrite_EditEx(objPage);
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
                strMsg = '命令:' + strCommandName + "在函数(PaperReadWriteCRUDExEx.btn_Click)中没有被处理！";
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

                //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");

                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
                objUsers_Cond.SetCondFldValue(clsvPaperReadWriteEN.con_OperationTypeId, "02", "=");
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaperReadWrite_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域

                PaperReadWriteCRUD.sortvPaperReadWriteBy = "updDate Desc";
                //var strWhereCond = await this.CombinevPaperReadWriteCondition();

                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；

                //存放userId
                $("#hidUserId").val(clsPublocalStorage.userId);
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPaperReadWrite();
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


    /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
 */
    public async btnQuery_Click() {
        //var strWhereCond = await this.CombinevPaperReadWriteCondition();
        try {
            $("#divLoading").show();
            const gvResult = await this.BindGv_vPaperReadWrite();
            $("#divLoading").hide();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //统计核算
    public async btnSynPaperRWStatistics_Click() {
        var strUserId = clsPublocalStorage.userId;
        try {
            $("#divLoading").show();
            const responseText2 = await clsPaperReadWriteWApiEx.SynPaperRWStatisticsAsync(strUserId);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `统计核算成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
                $("#divLoading").hide();
            }
            else {
                var strInfo: string = `统计核算不成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
                $("#divLoading").hide();
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `统计核算异常,${e}.`;
            alert(strMsg);
            $("#divLoading").hide();
        }
    }


    //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "operationTypeId='02'") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlUserId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = clsvPaperReadWriteWApiEx.GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrUserObjLst: Array<clsvPaperReadWriteEN> = <Array<clsvPaperReadWriteEN>>jsonData;
    //                BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperReadWriteEN.con_UpdUser, clsvPaperReadWriteEN.con_UserName, "编辑用户");
    //                console.log("完成BindDdl_UserId!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinevPaperReadWriteCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsvPaperReadWriteEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }
            //if (this.updDate_q != "") {
            //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdDate} like '% ${this.updDate_q}%'`;
            //}
            if (this.readUser_q != "" && this.readUser_q != "0") {
                strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} = '${this.readUser_q}'`;
            }

            //if (this.readUser_q != "") {
            //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} like '% ${this.readUser_q}%'`;
            //}
            //// 02 代表论文写作
            //if (strReadWriteTypeId != "") {
            strWhereCond += ` And ${clsvPaperReadWriteEN.con_OperationTypeId} = '02'`;
            //}

            //if (this.operationTypeId_q != "" && this.operationTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_OperationTypeId} = '${this.operationTypeId_q}'`;
            //}
            //if (this.updUser_q != "") {
            //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} like '% ${this.updUser_q}%'`;
            //}
            //如果是写作 则需要判断当前用户  02 写作 04查看；
            if (strReadWriteTypeId == "02") {
                var strUserId = clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage.roleId;

                if (strRoleId == "00620001") {
                    $("#btnDelRecord").show();
                    $("#btnCancelSubmit").show();
                    $("#btnSynPaperRWStatistics").show();
                    //可以查看所有；管理员
                }
                //判断角色 //学生00620003
                else if (strRoleId == "00620002") {
                    $("#btnDelRecord").show();
                    $("#btnCancelSubmit").show();
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

                }
                else {
                    $("#btnCancelSubmit").hide();
                    $("#ddlUserId_q").hide();
                    $("#btnDelRecord").show();
                    //只能查看自己的数据；或公开的数据；学生
                    //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                    strWhereCond += ` And updUser = '${strUserId}'`;

                }
            }
            //}
            //else {
            //    window.top.location.href = "../Web/Login";
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    /* 显示vPaperReadWrite对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrPaperReadWriteObjLst">需要绑定的对象列表</param>
 */
    public async BindTab_vPaperReadWrite(divContainer: string, arrvPaperReadWriteObjLst: Array<clsvPaperReadWriteEN>) {
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
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "paperContent",
                //    colHeader: "主题内容",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "periodical",
                    colHeader: "期刊",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
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
                //    fldName: "operationTypeName",
                //    colHeader: "操作类型名",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "userName",
                    colHeader: "写作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                {
                    fldName: "updDate",
                    colHeader: "写作日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                {
                    fldName: "isSubmit",
                    colHeader: "是否提交",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "subVCount",
                    colHeader: "观点数",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "teaCount",
                    colHeader: "教师分",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
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
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},

                //{
                //    fldName: "",
                //    colHeader: "子观点",
                //    Text: "子观点",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        //btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                //        btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                //        return btn1;
                //    }
                //},

                {
                    fldName: "",
                    colHeader: "pdf子观点",
                    text: "pdf子观点", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        //btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                        btn1.setAttribute("onclick", `btnSubviewPointRecord_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    colHeader: "详细",
                //    Text: "详细",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDetailRecordInTab_Click('${strKeyId}');`);
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
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        BindTab_V(o, arrvPaperReadWriteObjLst, arrDataColumn, "paperRWId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    /* 删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
  */
    public async btnDelRecord_Click() {
        try {
            var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;
            var arrKeyIds = GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            var strKeyList;
            if (arrKeyIds.length == 0) return "";
            strKeyList = "";
            for (var i = 0; i < arrKeyIds.length; i++) {
                if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
            }
            //
            var strWhereCond = " paperRWId in (" + strKeyList + ")";
            this.recCount = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond);
                if (this.recCount != 0) {
                    alert("请先删除该论文下子观点！");
                    return "";
                }
                else {
                    //刷新缓存
                    const responseText = this.DelMultiRecord(arrKeyIds);

                    vPaperReadWrite_ReFreshThisCache(strid_CurrEducls);
                    const responseText2 = this.BindGv_vPaperReadWrite();
                }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }


    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public async DelMultiRecord(arrPaperRWId: Array<string>) {

        try {
            const returnInt = await clsPaperReadWriteWApiEx.DelPaperReadWritesExAsync(arrPaperRWId);
            if (returnInt > 0) {
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelMultiRecord!");

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }

    }
  

    //取消论文提交
    public async btnCancelSubmit_Click(strKeyId: string) {
        var strUserId = clsPublocalStorage.userId;
        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        try {
            this.CancelSubmitRecordSave(strKeyId);

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*取消提交论文
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async CancelSubmitRecordSave(strKeyId: string) {
        const strThisFuncName = this.CancelSubmitRecordSave.name;
        var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;
        //
        var objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
        objPaperReadWriteEN.SetPaperRWId( strKeyId);
        objPaperReadWriteEN.SetIsSubmit( false);
        objPaperReadWriteEN.SetSubmitter( clsPublocalStorage.userId);//提交人；
        objPaperReadWriteEN.sfUpdFldSetStr = objPaperReadWriteEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }

        try {
            const responseText = PaperReadWrite_UpdateRecordAsync(objPaperReadWriteEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    var strInfo: string = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);

                    //刷新缓存
                    vPaperReadWrite_ReFreshThisCache(strid_CurrEducls);
                    HideDialog();
                    this.BindGv_vPaperReadWrite();
                }
                else {
                    var strInfo: string = `取消不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("取消失败");
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `取消记录不成功,${e}.`;
            alert(strMsg);
        }

    }
    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vPaperReadWrite() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevPaperReadWriteCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvPaperReadWriteObjLst: Array<clsvPaperReadWriteEN> = [];
        try {
            this.recCount = await vPaperReadWrite_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: PaperReadWriteCRUD.sortvPaperReadWriteBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaperReadWrite_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperReadWriteObjLst = <Array<clsvPaperReadWriteEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {

            this.BindTab_vPaperReadWrite(strListDiv, arrvPaperReadWriteObjLst);

            console.log("完成BindGv_vPaperReadWrite!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /*
 * 用户
*/
    //public get readUser_q(): string {
    //    return $("#txtReadUser_q").val();
    //}
    public get readUser_q(): string {
        return $("#ddlUserId_q").val();
    }

    /*
* 分享
*/
    public set shareId(value: string) {
        $("#ddlShareId").val(value);
    }
    /*
    * 分享
    */
    public get shareId(): string {
        return $("#ddlShareId").val();
    }

}