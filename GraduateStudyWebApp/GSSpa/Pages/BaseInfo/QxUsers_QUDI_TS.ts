/*-- -- -- -- -- -- -- -- -- -- --
类名:QxUsers_QUDI_TS
表名:QxUsers(01120258)
生成代码版本:2019.10.08.1
生成日期:2019/10/14 15:51:44
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:基本信息维护
模块英文名:BaseInfo
框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsQxUsersEN } from "../TS/L0_Entity/BaseInfo/clsQxUsersEN.js";
//import { clsDepartmentInfoEN } from "../TS/L0_Entity/UserManage/clsDepartmentInfoEN.js";
//import { clsDepartmentInfoWApi } from "../TS/L3_ForWApi/UserManage/clsDepartmentInfoWApi.js";
import { clsXzClgEN } from "../TS/L0_Entity/BaseInfo/clsXzClgEN.js";
import { clsXzGradeBaseEN } from "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js";
import { clsUserIdentityEN } from "../TS/L0_Entity/UserManage/clsUserIdentityEN.js";
import { QxUsers_AddNewRecordAsync, QxUsers_DelQxUserssAsync, QxUsers_DelRecordAsync, QxUsers_GetObjByUserIdAsync, QxUsers_GetObjLstAsync, QxUsers_GetObjLstByPagerAsync, QxUsers_GetRecCountByCondAsync, QxUsers_IsExistAsync, QxUsers_UpdateRecordAsync } from "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js";
import { XzClg_GetObjLstAsync } from "../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js";
import { XzGradeBase_GetObjLstAsync } from "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js";
import { UserIdentity_GetObjLstAsync } from "../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;
/*
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
*/
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
declare var $;
declare var window;
/* QxUsers_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class QxUsers_QUDI_TS implements clsOperateList{
    public mstrListDiv: string = "divDataLst";
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;


    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucQxUsersB1.userId = clsQxUsersBL.GetMaxStrId_S();
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objQxUsersEN: clsQxUsersEN = new clsQxUsersEN();
        this.PutDataToQxUsersClass(objQxUsersEN);
        try {
            const responseText = await QxUsers_IsExistAsync(objQxUsersEN.userId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objQxUsersEN.userId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await QxUsers_AddNewRecordAsync(objQxUsersEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult40').val(strInfo);
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
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }
   

    /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_QxUsers() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombineQxUsersCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrQxUsersObjLst: Array<clsQxUsersEN> = [];
        try {
            const responseRecCount = await QxUsers_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortQxUsersBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await QxUsers_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrQxUsersObjLst = <Array<clsQxUsersEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        if (arrQxUsersObjLst.length == 0) {
            var strMsg: string = `根据条件获取的对象列表数为空！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_QxUsers(strListDiv, arrQxUsersObjLst);
            console.log("完成BindGv_QxUsers!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示QxUsers对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrQxUsersObjLst">需要绑定的对象列表</param>
   */
    public BindTab_QxUsers(divContainer: string, arrQxUsersObjLst: Array<clsQxUsersEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userId",
                    ColHeader: "用户ID",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "用户名",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "card_State",
                    ColHeader: "card_State",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cardNo",
                    ColHeader: "卡号",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "endYearMonth",
                    ColHeader: "结束年月",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "optUser",
                    ColHeader: "optUser",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "optDate",
                    ColHeader: "optDate",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "avatarsPicture",
                    ColHeader: "avatarsPicture",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "email",
                    ColHeader: "电子邮箱",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "phoneNumber",
                    ColHeader: "phoneNumber",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "effectiveDate",
                    ColHeader: "effectiveDate",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "effitiveBeginDate",
                    ColHeader: "effitiveBeginDate",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "effitiveEndDate",
                    ColHeader: "effitiveEndDate",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "id_College",
                    ColHeader: "学院流水号",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isArchive",
                    ColHeader: "isArchive",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改",TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除",TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrQxUsersObjLst, arrDataColumn, "userId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.OpType = "Add";
        try {
            const responseText = await this.AddNewRecord();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
   */
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseText2 = await this.BindGv_QxUsers();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelRecord(strKeyId);
            const responseText2 = await this.BindGv_QxUsers();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    在数据表里详细信息记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
   */
    public async btnDetailRecordInTab_Click(strKeyId: string) {
        this.OpType = "Detail";
        try {
            if (strKeyId == "") {
                alert("请选择需要详细信息的记录！");
                return "";
            }
            this.DetailRecord(strKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `详细信息记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
   */
    public async btnExportExcel_Click() {
        var strWhereCond = " 1=1 ";
        try {
            const responseText = await QxUsers_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrQxUsersObjLst: Array<clsQxUsersEN> = <Array<clsQxUsersEN>>jsonData;
                this.BindTab_QxUsers(this.mstrListDiv, arrQxUsersObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnOKUpd;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_QxUsers();
                        }
                    });
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_QxUsers();
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    public async btnQuery_Click(strListDiv: string) {
        var strWhereCond = this.CombineQxUsersCondition();
        try {
            const responseRecCount = await QxUsers_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortQxUsersBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await QxUsers_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                var arrQxUsersObjLst: Array<clsQxUsersEN> = <Array<clsQxUsersEN>>jsonData;
                this.BindTab_QxUsers(this.mstrListDiv, arrQxUsersObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 
    在数据表里选择记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
   */
    public async btnSelectRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            this.SelectRecord(strKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `选择记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
   */
    public btnUpdateRecord_Click(strKeyId: string) {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        this.UpdateRecord(strKeyId);
    }

    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public btnUpdateRecordInTab_Click(strKeyId: string) {
        this.OpType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        this.UpdateRecord(strKeyId);
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.userId = "";
        this.userName = "";
        $('#ddlDepartmentId option[0]').attr("selected", true);
        $('#ddlid_XzCollege option[0]').attr("selected", true);
        this.userStateId = "";
        $('#ddlid_GradeBase option[0]').attr("selected", true);
        this.card_State = "";
        this.isLeaved = false;
        this.cardNo = "";
        this.beginYearMonth = "";
        this.endYearMonth = "";
        this.optUser = "";
        this.optDate = "";
        this.memo = "";
        this.password = "";
        this.isGpUser = false;
        this.schoolID1 = "";
        this.avatarsPicture = "";
        this.email = "";
        this.phoneNumber = "";
        this.effectiveDate = "";
        this.updDate = "";
        this.updUser = "";
        this.effitiveBeginDate = "";
        this.effitiveEndDate = "";
        this.id_College = "";
        this.stuTeacherID = "";
        $('#ddlIdentityID option[0]').attr("selected", true);
        this.isArchive = false;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombineQxUsersCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.UserId_q != "") {
                strWhereCond += ` And ${clsQxUsersEN.con_UserId} like '% ${this.UserId_q}%'`;
            }
            if (this.UserName_q != "") {
                strWhereCond += ` And ${clsQxUsersEN.con_UserName} like '% ${this.UserName_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineQxUsersCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    ///// <summary>
    ///// 为下拉框获取数据,从表:[DepartmentInfo]中获取
    ///// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    ///// </summary>
    ///// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    //public BindDdl_DepartmentId(ddlDepartmentId: string, strWhereCond: string = "1 =1") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlDepartmentId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlDepartmentId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = DepartmentInfo_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrDepartmentInfoObjLst: Array<clsDepartmentInfoEN> = <Array<clsDepartmentInfoEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlDepartmentId, arrDepartmentInfoObjLst, clsDepartmentInfoEN.con_DepartmentId, clsDepartmentInfoEN.con_DepartmentName, "DepartmentInfo");
    //                console.log("完成BindDdl_DepartmentId!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}
    /// <summary>
    /// 为下拉框获取数据,从表:[XzClg]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_id_XzCollege(ddlid_XzCollege: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlid_XzCollege);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlid_XzCollege} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = XzClg_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrXzClgObjLst: Array<clsXzClgEN> = <Array<clsXzClgEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlid_XzCollege, arrXzClgObjLst, clsXzClgEN.con_id_XzCollege, clsXzClgEN.con_CollegeName, "学院表");
                    console.log("完成BindDdl_id_XzCollege!");
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
    /// 为下拉框获取数据,从表:[XzGradeBase]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_id_GradeBase(ddlid_GradeBase: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlid_GradeBase);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlid_GradeBase} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = XzGradeBase_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrXzGradeBaseObjLst: Array<clsXzGradeBaseEN> = <Array<clsXzGradeBaseEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlid_GradeBase, arrXzGradeBaseObjLst, clsXzGradeBaseEN.con_id_GradeBase, clsXzGradeBaseEN.con_GradeBaseName, "年级");
                    console.log("完成BindDdl_id_GradeBase!");
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
    /// 为下拉框获取数据,从表:[UserIdentity]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_IdentityID(ddlIdentityID: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlIdentityID);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlIdentityID} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = UserIdentity_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrUserIdentityObjLst: Array<clsUserIdentityEN> = <Array<clsUserIdentityEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlIdentityID, arrUserIdentityObjLst, clsUserIdentityEN.con_IdentityID, clsUserIdentityEN.con_IdentityDesc, "用户身份");
                    console.log("完成BindDdl_IdentityID!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public DelMultiRecord(arrUserId: Array<string>) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = QxUsers_DelQxUserssAsync(arrUserId).then((jsonData) => {
                    var returnInt: number = jsonData;
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
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public DelRecord(strUserId: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = QxUsers_DelRecordAsync(strUserId).then((jsonData) => {
                    var returnInt: number = jsonData;
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
                    console.log("完成DelRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }

    /*
    演示Session 操作
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
    */
    public async Demo_Session() {
        try {
            //设置Session
            var strUserId = "TestUserId";
            await this.SetSessionAsync("userId", strUserId);
            //获取Session
            var strUserId_Value1 = await this.GetSessionAsync("userId");
            console.log('strUserId_Value1:' + strUserId_Value1);
            //获取Session方法2：直接读取页面中的hidUserId
            var strUserId_Value2 = this.hidUserId;
            console.log('strUserId_Value2:' + strUserId_Value2);
        }
        catch (e) {
            var strMsg: string = `演示Session不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字详细信息记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
     <param name = "sender">参数列表</param>
   */
    public DetailRecord(strUserId: string) {
        this.btnOKUpd = "";
        this.btnCancel = "关闭";
        return new Promise((resolve, reject) => {
            try {
                const responseText = QxUsers_GetObjByUserIdAsync(strUserId).then((jsonData) => {
                    var objQxUsersEN: clsQxUsersEN = <clsQxUsersEN>jsonData;
                    this.GetDataFromQxUsersClass(objQxUsersEN);
                    console.log("完成DetailRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjQxUsersEN">表实体类对象</param>
   */
    public GetDataFromQxUsersClass(pobjQxUsersEN: clsQxUsersEN) {
        this.userId = pobjQxUsersEN.userId;// 用户ID
        this.userName = pobjQxUsersEN.userName;// 用户名
        this.departmentId = pobjQxUsersEN.departmentId;// 部门Id
        this.id_XzCollege = pobjQxUsersEN.id_XzCollege;// 学院流水号
        this.userStateId = pobjQxUsersEN.userStateId;// 用户状态Id
        this.id_GradeBase = pobjQxUsersEN.id_GradeBase;// 年级流水号
        this.card_State = pobjQxUsersEN.card_State;// card_State
        this.isLeaved = pobjQxUsersEN.isLeaved;// isLeaved
        this.cardNo = pobjQxUsersEN.cardNo;// 卡号
        this.beginYearMonth = pobjQxUsersEN.beginYearMonth;// 开始年月
        this.endYearMonth = pobjQxUsersEN.endYearMonth;// 结束年月
        this.optUser = pobjQxUsersEN.optUser;// optUser
        this.optDate = pobjQxUsersEN.optDate;// optDate
        this.memo = pobjQxUsersEN.memo;// 备注
        this.password = pobjQxUsersEN.password;// password
        this.isGpUser = pobjQxUsersEN.isGpUser;// 是否Gp用户
        this.schoolID1 = pobjQxUsersEN.schoolID1;// 学校编号
        this.avatarsPicture = pobjQxUsersEN.avatarsPicture;// avatarsPicture
        this.email = pobjQxUsersEN.email;// 电子邮箱
        this.phoneNumber = pobjQxUsersEN.phoneNumber;// phoneNumber
        this.effectiveDate = pobjQxUsersEN.effectiveDate;// effectiveDate
        this.updDate = pobjQxUsersEN.updDate;// 修改日期
        this.updUser = pobjQxUsersEN.updUser;// 修改人
        this.effitiveBeginDate = pobjQxUsersEN.effitiveBeginDate;// effitiveBeginDate
        this.effitiveEndDate = pobjQxUsersEN.effitiveEndDate;// effitiveEndDate
        this.id_College = pobjQxUsersEN.id_College;// 学院流水号
        this.stuTeacherID = pobjQxUsersEN.stuTeacherID;// 学工号
        this.identityID = pobjQxUsersEN.identityID;// 身份编号
        this.isArchive = pobjQxUsersEN.isArchive;// isArchive
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjQxUsersEN">表实体类对象</param>
    <returns>列表的第一个关键字值</returns>
   */
    public GetFirstKey(): string {
        if (arrSelectedKeys.length == 1) {
            return arrSelectedKeys[0];
        }
        else {
            alert(`请选择一个关键字！目前选择了:${arrSelectedKeys.length}个关键字。`);
            return "";
        }
    }


    /*
    获取Session 关键字的值
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
    <param name = "Key">关键字</param>
     <return>值</return>
    */
    public GetSessionAsync(Key: string): Promise<string> {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl_Session_GetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                },
                success: function (data) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log('strKey, strValue=' + strKey + strValue);
                    resolve(data);
                },
                error: (e) => {
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /* 函数功能:在数据 列表中跳转到某一页
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
   */
    public async IndexPage(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_QxUsers();
    }

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            //1、为下拉框设置数据源,绑定列表数据
            //const ddl_DepartmentId = await this.BindDdl_DepartmentId("ddlDepartmentId");
            const ddl_id_XzCollege = await this.BindDdl_id_XzCollege("ddlid_XzCollege");
            const ddl_id_GradeBase = await this.BindDdl_id_GradeBase("ddlid_GradeBase");
            const ddl_IdentityID = await this.BindDdl_IdentityID("ddlIdentityID");
            this.hidSortQxUsersBy = "userId Asc";
            var strWhereCond = this.CombineQxUsersCondition();
            const responseText = await QxUsers_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_QxUsers();
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjQxUsersEN">数据传输的目的类对象</param>
   */
    public PutDataToQxUsersClass(pobjQxUsersEN: clsQxUsersEN) {
        pobjQxUsersEN.userId = this.userId;// 用户ID
        pobjQxUsersEN.userName = this.userName;// 用户名
        pobjQxUsersEN.departmentId = this.departmentId;// 部门Id
        pobjQxUsersEN.id_XzCollege = this.id_XzCollege;// 学院流水号
        pobjQxUsersEN.userStateId = this.userStateId;// 用户状态Id
        pobjQxUsersEN.id_GradeBase = this.id_GradeBase;// 年级流水号
        pobjQxUsersEN.card_State = this.card_State;// card_State
        pobjQxUsersEN.isLeaved = this.isLeaved;// isLeaved
        pobjQxUsersEN.cardNo = this.cardNo;// 卡号
        pobjQxUsersEN.beginYearMonth = this.beginYearMonth;// 开始年月
        pobjQxUsersEN.endYearMonth = this.endYearMonth;// 结束年月
        pobjQxUsersEN.optUser = this.optUser;// optUser
        pobjQxUsersEN.optDate = this.optDate;// optDate
        pobjQxUsersEN.memo = this.memo;// 备注
        pobjQxUsersEN.password = this.password;// password
        pobjQxUsersEN.isGpUser = this.isGpUser;// 是否Gp用户
        pobjQxUsersEN.schoolID1 = this.schoolID1;// 学校编号
        pobjQxUsersEN.avatarsPicture = this.avatarsPicture;// avatarsPicture
        pobjQxUsersEN.email = this.email;// 电子邮箱
        pobjQxUsersEN.phoneNumber = this.phoneNumber;// phoneNumber
        pobjQxUsersEN.effectiveDate = this.effectiveDate;// effectiveDate
        pobjQxUsersEN.updDate = this.updDate;// 修改日期
        pobjQxUsersEN.updUser = this.updUser;// 修改人
        pobjQxUsersEN.effitiveBeginDate = this.effitiveBeginDate;// effitiveBeginDate
        pobjQxUsersEN.effitiveEndDate = this.effitiveEndDate;// effitiveEndDate
        pobjQxUsersEN.id_College = this.id_College;// 学院流水号
        pobjQxUsersEN.stuTeacherID = this.stuTeacherID;// 学工号
        pobjQxUsersEN.identityID = this.identityID;// 身份编号
        pobjQxUsersEN.isArchive = this.isArchive;// isArchive
    }


    /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_QueryLst)
   */
    public QueryQxUsersLst(strListDiv: string) {
        var strWhereCond = this.CombineQxUsersCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        return new Promise((resolve, reject) => {
            try {
                var objPagerPara: stuPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortQxUsersBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseText = QxUsers_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                    var arrQxUsersObjLst: Array<clsQxUsersEN> = <Array<clsQxUsersEN>>jsonData;
                    this.BindTab_QxUsers(strListDiv, arrQxUsersObjLst);
                    console.log("完成QueryQxUsersLst!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 
    根据关键字选择相应的记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
     <param name = "sender">参数列表</param>
   */
    public async SelectRecord(strUserId: string) {
        try {
            const responseText = await QxUsers_GetObjByUserIdAsync(strUserId);
            var objQxUsersEN: clsQxUsersEN = <clsQxUsersEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_QxUsers");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtUserId').prop['ReadOnly'] = bolReadonly;
    }

    /*
    设置Session
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
    <param name = "Key">关键字</param>
    <param name = "Value">值</param>
    */
    public SetSessionAsync(Key: string, Value: string): Promise<void> {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl_Session_SetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                    Value: Value
                },
                success: function (data) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log('strKey, strValue=' + strKey + strValue);
                }
            });
        });
    }

    /* 函数功能:把以该关键字的记录内容显示在界面上,
          在这里是把值传到表控件中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
     <param name = "strUserId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strUserId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objQxUsersEN: clsQxUsersEN = new clsQxUsersEN();
        try {
            const responseText = await QxUsers_IsExistAsync(strUserId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strUserId}] 的记录不存在!`;
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
            }
        }
        catch (e) {
            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
            alert(strMsg);
        }
        try {
            const responseText = await QxUsers_GetObjByUserIdAsync(strUserId);
            objQxUsersEN = <clsQxUsersEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromQxUsersClass(objQxUsersEN);
    }

    /* 显示{0}对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
     <param name = "divContainer">显示容器</param>
     <param name = "objQxUsers">需要显示的对象</param>
   */
    public ShowQxUsersObj(divContainer: string, objQxUsers: clsQxUsersEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objQxUsers);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objQxUsers[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中根据某一个字段排序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     <param name = "strSortByFld">排序的字段</param>
   */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortQxUsersBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortQxUsersBy.indexOf("Asc") >= 0) {
                this.hidSortQxUsersBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortQxUsersBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortQxUsersBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_QxUsers();
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public UpdateRecord(strUserId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strUserId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = QxUsers_GetObjByUserIdAsync(strUserId).then((jsonData) => {
                    var objQxUsersEN: clsQxUsersEN = <clsQxUsersEN>jsonData;
                    this.GetDataFromQxUsersClass(objQxUsersEN);
                    console.log("完成UpdateRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public UpdateRecordSave(): Promise<boolean> {
        this.DivName = "divUpdateRecordSave";
        var objQxUsersEN: clsQxUsersEN = new clsQxUsersEN();
        objQxUsersEN.userId = this.KeyId;
        this.PutDataToQxUsersClass(objQxUsersEN);
        objQxUsersEN.sf_UpdFldSetStr = objQxUsersEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objQxUsersEN.userId == "" || objQxUsersEN.userId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = QxUsers_UpdateRecordAsync(objQxUsersEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `修改记录成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        var strInfo: string = `修改记录不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("完成UpdateRecordSave");
                    }
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        });
    }
    /*
    * avatarsPicture
   */
    public set avatarsPicture(value: string) {
        $("#txtAvatarsPicture").val(value);
    }
    /*
    * avatarsPicture
   */
    public get avatarsPicture(): string {
        return $("#txtAvatarsPicture").val();
    }
    /*
    * 开始年月
   */
    public set beginYearMonth(value: string) {
        $("#txtBeginYearMonth").val(value);
    }
    /*
    * 开始年月
   */
    public get beginYearMonth(): string {
        return $("#txtBeginYearMonth").val();
    }
    /*
    * 设置取消按钮的标题
   */
    public set btnCancel(value: string) {
        $("#btnCancel").html(value);
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnOKUpd(value: string) {
        $("#btnOKUpd").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd(): string {
        return $("#btnOKUpd").html();
    }
    /*
    * card_State
   */
    public set card_State(value: string) {
        $("#txtCard_State").val(value);
    }
    /*
    * card_State
   */
    public get card_State(): string {
        return $("#txtCard_State").val();
    }
    /*
    * 卡号
   */
    public set cardNo(value: string) {
        $("#txtCardNo").val(value);
    }
    /*
    * 卡号
   */
    public get cardNo(): string {
        return $("#txtCardNo").val();
    }
    /*
    * 获取当前页序号
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 部门Id
   */
    public set departmentId(value: string) {
        $("#ddlDepartmentId").val(value);
    }
    /*
    * 部门Id
   */
    public get departmentId(): string {
        return $("#ddlDepartmentId").val();
    }
    /*
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
    }
    /*
    * effectiveDate
   */
    public set effectiveDate(value: string) {
        $("#txtEffectiveDate").val(value);
    }
    /*
    * effectiveDate
   */
    public get effectiveDate(): string {
        return $("#txtEffectiveDate").val();
    }
    /*
    * effitiveBeginDate
   */
    public set effitiveBeginDate(value: string) {
        $("#txtEffitiveBeginDate").val(value);
    }
    /*
    * effitiveBeginDate
   */
    public get effitiveBeginDate(): string {
        return $("#txtEffitiveBeginDate").val();
    }
    /*
    * effitiveEndDate
   */
    public set effitiveEndDate(value: string) {
        $("#txtEffitiveEndDate").val(value);
    }
    /*
    * effitiveEndDate
   */
    public get effitiveEndDate(): string {
        return $("#txtEffitiveEndDate").val();
    }
    /*
    * 电子邮箱
   */
    public set email(value: string) {
        $("#txtEmail").val(value);
    }
    /*
    * 电子邮箱
   */
    public get email(): string {
        return $("#txtEmail").val();
    }
    /*
    * 结束年月
   */
    public set endYearMonth(value: string) {
        $("#txtEndYearMonth").val(value);
    }
    /*
    * 结束年月
   */
    public get endYearMonth(): string {
        return $("#txtEndYearMonth").val();
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortQxUsersBy(value: string) {
        $("#hidSortQxUsersBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortQxUsersBy(): string {
        return $("#hidSortQxUsersBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return $("#hidUserId").val();
    }
    /*
    * 学院流水号
   */
    public set id_College(value: string) {
        $("#txtid_College").val(value);
    }
    /*
    * 学院流水号
   */
    public get id_College(): string {
        return $("#txtid_College").val();
    }
    /*
    * 年级流水号
   */
    public set id_GradeBase(value: string) {
        $("#ddlid_GradeBase").val(value);
    }
    /*
    * 年级流水号
   */
    public get id_GradeBase(): string {
        return $("#ddlid_GradeBase").val();
    }
    /*
    * 学院流水号
   */
    public set id_XzCollege(value: string) {
        $("#ddlid_XzCollege").val(value);
    }
    /*
    * 学院流水号
   */
    public get id_XzCollege(): string {
        return $("#ddlid_XzCollege").val();
    }
    /*
    * 身份编号
   */
    public set identityID(value: string) {
        $("#ddlIdentityID").val(value);
    }
    /*
    * 身份编号
   */
    public get identityID(): string {
        return $("#ddlIdentityID").val();
    }
    /*
    * isArchive
   */
    public set isArchive(value: boolean) {
        $("#chkIsArchive").val(value);
    }
    /*
    * isArchive
   */
    public get isArchive(): boolean {
        return $("#chkIsArchive").prop("checked");
    }
    /*
    * 是否Gp用户
   */
    public set isGpUser(value: boolean) {
        $("#chkIsGpUser").val(value);
    }
    /*
    * 是否Gp用户
   */
    public get isGpUser(): boolean {
        return $("#chkIsGpUser").prop("checked");
    }
    /*
    * isLeaved
   */
    public set isLeaved(value: boolean) {
        $("#chkIsLeaved").val(value);
    }
    /*
    * isLeaved
   */
    public get isLeaved(): boolean {
        return $("#chkIsLeaved").prop("checked");
    }
    /*
    * 设置关键字的值
   */
    public set KeyId(value: string) {
        $("#hidKeyId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get KeyId(): string {
        return $("#hidKeyId").val();
    }
    /*
    * 备注
   */
    public set memo(value: string) {
        $("#txtMemo").val(value);
    }
    /*
    * 备注
   */
    public get memo(): string {
        return $("#txtMemo").val();
    }
    /*
    * optDate
   */
    public set optDate(value: string) {
        $("#txtOptDate").val(value);
    }
    /*
    * optDate
   */
    public get optDate(): string {
        return $("#txtOptDate").val();
    }
    /*
    * optUser
   */
    public set optUser(value: string) {
        $("#txtOptUser").val(value);
    }
    /*
    * optUser
   */
    public get optUser(): string {
        return $("#txtOptUser").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set OpType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * password
   */
    public set password(value: string) {
        $("#txtPassword").val(value);
    }
    /*
    * password
   */
    public get password(): string {
        return $("#txtPassword").val();
    }
    /*
    * phoneNumber
   */
    public set phoneNumber(value: string) {
        $("#txtPhoneNumber").val(value);
    }
    /*
    * phoneNumber
   */
    public get phoneNumber(): string {
        return $("#txtPhoneNumber").val();
    }
    /*
    * 学校编号
   */
    public set schoolID1(value: string) {
        $("#txtSchoolID1").val(value);
    }
    /*
    * 学校编号
   */
    public get schoolID1(): string {
        return $("#txtSchoolID1").val();
    }
    /*
    * 学工号
   */
    public set stuTeacherID(value: string) {
        $("#txtStuTeacherID").val(value);
    }
    /*
    * 学工号
   */
    public get stuTeacherID(): string {
        return $("#txtStuTeacherID").val();
    }
    /*
    * 修改日期
   */
    public set updDate(value: string) {
        $("#txtUpdDate").val(value);
    }
    /*
    * 修改日期
   */
    public get updDate(): string {
        return $("#txtUpdDate").val();
    }
    /*
    * 修改人
   */
    public set updUser(value: string) {
        $("#txtUpdUser").val(value);
    }
    /*
    * 修改人
   */
    public get updUser(): string {
        return $("#txtUpdUser").val();
    }
    /*
    * 用户ID
   */
    public set userId(value: string) {
        $("#txtUserId").val(value);
    }
    /*
    * 用户ID
   */
    public get userId(): string {
        return $("#txtUserId").val();
    }
    /*
    * 用户ID
   */
    public get UserId_q(): string {
        return $("#txtUserId_q").val();
    }
    /*
    * 用户名
   */
    public set userName(value: string) {
        $("#txtUserName").val(value);
    }
    /*
    * 用户名
   */
    public get userName(): string {
        return $("#txtUserName").val();
    }
    /*
    * 用户名
   */
    public get UserName_q(): string {
        return $("#txtUserName_q").val();
    }
    /*
    * 用户状态Id
   */
    public set userStateId(value: string) {
        $("#txtUserStateId").val(value);
    }
    /*
    * 用户状态Id
   */
    public get userStateId(): string {
        return $("#txtUserStateId").val();
    }
}