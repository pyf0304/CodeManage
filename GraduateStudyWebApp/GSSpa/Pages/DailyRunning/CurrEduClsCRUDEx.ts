
/*-- -- -- -- -- -- -- -- -- -- --
类名:CurrEduClsCRUDEx
表名:CurrEduCls(01120123)
生成代码版本:2020.05.09.1
生成日期:2020/05/11 16:30:25
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:日常运行
模块英文名:DailyRunning
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { gs_TeachingDate_EditEx } from "../GraduateEduTools/gs_TeachingDate_EditEx.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsCurrEduClsEN } from "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js";
import { clsvCurrEduClsEN } from "../TS/L0_Entity/DailyRunning/clsvCurrEduClsEN.js";
import { clsvCurrEduClsENEx } from "../TS/L0_Entity/DailyRunning/clsvCurrEduClsENEx.js";
import { clsgs_TeachingDateEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { CurrEduCls_GetMaxStrIdAsync, CurrEduCls_GetObjByid_CurrEduClsAsync, CurrEduCls_GetObjLstAsync, CurrEduCls_UpdateRecordAsync } from "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";
import { vCurrEduCls_GetObjLstByPagerAsync, vCurrEduCls_GetRecCountByCondAsync } from "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js";
import { gs_TeachingDate_AddNewRecordAsync, gs_TeachingDate_GetFirstObjAsync, gs_TeachingDate_GetObjLst_Cache, gs_TeachingDate_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { vUsersSim_func } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { vCurrEduClsEx_CopyToEx } from "../TS/L3_ForWApiEx/DailyRunning/clsvCurrEduClsExWApi.js";
import { gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { CurrEduClsCRUD } from "./CurrEduClsCRUD.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;

declare function ShowDialogOne(strOpType): void;
declare function HideDialogOne(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* CurrEduClsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class CurrEduClsCRUDEx extends CurrEduClsCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvCurrEduClsBy: string = "id_CurrEduCls";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            //建立缓存

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvCurrEduClsBy = "currEduClsId Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCurrEduCls();
            $("#divLoading").hide();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    BindGv(strType: string, strPara: string) {
        //this.BindGv_vgs_TeachingDate();
        this.BindGv_vCurrEduCls();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "vgs_TeachingDate":
                alert('该类没有绑定该函数：[this.BindGv_vgs_TeachingDate_Cache]！');
                //this.BindGv_vgs_TeachingDate_Cache();
                break;
        }
    }
    /*
   按钮单击,用于调用Js函数中btn_Click
  (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
  */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: CurrEduClsCRUDEx = new CurrEduClsCRUDEx();
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage.btnAddNewRecord_Click();
                break;
            case "SetUpDate":            //修改记录
                var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要设置的记录！");
                    return;
                }
                objPage.btnSetUpDateRecord_Click(strKeyId);
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage.btnUpdateRecord_Click(strKeyId);
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
                var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
*/
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnOKUpd;
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
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnKeyId: string = <string>jsonData;
                                if (clsString.IsNullOrEmpty(returnKeyId) == false) {
                                    HideDialog();
                                    this.BindGv_vCurrEduCls();
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vCurrEduCls();
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
                                this.BindGv_vCurrEduCls();
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
            $('#btnOKUpd').attr("disabled", false);
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

  
    /* 为插入记录做准备工作
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
    public async AddNewRecord() {
        //去掉提交按钮不可用状态
        $('#btnOKUpd').attr("disabled", false);
        this.OpType = "AddWithMaxId";
        //this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
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
        $('#btnOKUpd').attr("disabled", false);
        this.OpType = "AddWithMaxId";
        //this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucCurrEduClsB1.id_CurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
    }

    //概念提交审核
    public async mySubmitDate() {

        const responseText1 = await this.SetUpDate();

    }


    //设置日期；
    public async SetUpDate() {
        var strId_CurrEduCls = $("#txtid_CurrEduCls").val();

        var strCommandText: string = this.btnOKUpd;
        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":

                        var objgs_TeachingDateEN: clsgs_TeachingDateEN = new clsgs_TeachingDateEN();
                        objgs_TeachingDateEN.id_CurrEduCls = strId_CurrEduCls;
                        objgs_TeachingDateEN.startDate = this.startDate;
                        objgs_TeachingDateEN.endDate = this.endDate;
                        objgs_TeachingDateEN.updDate = clsPubFun4Web.getNowDate();
                        objgs_TeachingDateEN.updUser = clsPubSessionStorage.GetSession_UserId();
                        // this.PutDataToConceptClass(objConceptEN);
                        objgs_TeachingDateEN.sf_UpdFldSetStr = objgs_TeachingDateEN.updFldString;//设置哪些字段被修改(脏字段)


                        try {
                            const responseText2 = await gs_TeachingDate_AddNewRecordAsync(objgs_TeachingDateEN);
                            var returnBool: boolean = !!responseText2;
                            if (returnBool == true) {

                                //更新教学班日期范围；把备注字段存放日期
                                var objCurrEduClsEN: clsCurrEduClsEN = new clsCurrEduClsEN();
                                objCurrEduClsEN.id_CurrEduCls = strId_CurrEduCls
                                objCurrEduClsEN.memo = this.startDate + "-" + this.endDate;
                                objCurrEduClsEN.sf_UpdFldSetStr = objCurrEduClsEN.updFldString;//设置哪些字段被修改(脏字段)
                                const responseText3 = await CurrEduCls_UpdateRecordAsync(objCurrEduClsEN);
                                var returnBool: boolean = !!responseText3;
                                if (returnBool == true) {
                                    console.log("教学班更新成功");
                                    //数据同步；
                                    const responseText2 = await gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync(strId_CurrEduCls, clsPubSessionStorage.GetSession_UserId());
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
                            objgs_TeachingDateEN.mId = mId;
                            objgs_TeachingDateEN.id_CurrEduCls = strId_CurrEduCls;
                            objgs_TeachingDateEN.startDate = this.startDate;
                            objgs_TeachingDateEN.endDate = this.endDate;
                            objgs_TeachingDateEN.updDate = clsPubFun4Web.getNowDate();
                            objgs_TeachingDateEN.updUser = clsPubSessionStorage.GetSession_UserId();


                            objgs_TeachingDateEN.sf_UpdFldSetStr = objgs_TeachingDateEN.updFldString;//设置哪些字段被修改(脏字段)
                            const responseText2 = await gs_TeachingDate_UpdateRecordAsync(objgs_TeachingDateEN);
                            var returnBool: boolean = !!responseText2;
                            if (returnBool == true) {
                                console.log("教学班日期表更新成功");

                                //更新教学班日期范围字段
                                var objCurrEduClsEN: clsCurrEduClsEN = new clsCurrEduClsEN();
                                objCurrEduClsEN.id_CurrEduCls = strId_CurrEduCls
                                objCurrEduClsEN.memo = this.startDate + "-" + this.endDate;
                                objCurrEduClsEN.sf_UpdFldSetStr = objCurrEduClsEN.updFldString;//设置哪些字段被修改(脏字段)
                                const responseText3 = await CurrEduCls_UpdateRecordAsync(objCurrEduClsEN);
                                var returnBool: boolean = !!responseText3;
                                if (returnBool == true) {
                                    console.log("教学班更新范围成功");
                                    //数据同步；
                                    const responseText4 = await gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync(strId_CurrEduCls, clsPubSessionStorage.GetSession_UserId());
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
            $('#btnOKUpd').attr("disabled", false);
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }

        $("#divLoading").hide();
    }
    /* 修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/


    /* 修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
    public async btnUpdateRecord_Click(strKeyId:string) {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        //读取session角色 来判断绑定不同数据列表
        //获取用户角色来判断显示不同的列表数据；
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var strRoleId = clsPubSessionStorage.GetSession_RoleId();

        //判断角色 
        //管理员
        if (strRoleId == "00620001") {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
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
                    const conBindDdl = await this.BindDdl4EditRegion();
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
            //需要判断当前数据中是否包含已提交数据、如果有则不能删除
            var strKeyList;
            if (arrKeyIds.length == 0) return "";
            strKeyList = "";
            for (var i = 0; i < arrKeyIds.length; i++) {
                if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
            }
            //
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strWhereCond = " id_CurrEduCls in (" + strKeyList + ")";
            var arrCurrEduClsObjLst: Array<clsCurrEduClsEN> = [];
            const responseText1 = await CurrEduCls_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrCurrEduClsObjLst = <Array<clsCurrEduClsEN>>jsonData;
                //查询是否有提交的数据
                arrCurrEduClsObjLst = arrCurrEduClsObjLst.filter(x => x.modifyUserID != strUserId);
                if (arrCurrEduClsObjLst.length > 0) {
                    alert("包含其他用户添加数据，不能删除！");
                    return "";
                }
            });


            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vCurrEduCls();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }




    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevCurrEduClsCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.CurrEduClsId_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_CurrEduClsId} like '% ${this.CurrEduClsId_q}%'`;
            }
            if (this.eduClsName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /// <summary>
    /// 把同一个类的对象,复制到另一个对象
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
    /// </summary>
    /// <param name = "objvCurrEduClsENS">源对象</param>
    /// <returns>目标对象=>clsvCurrEduClsEN:objvCurrEduClsENT</returns>
    public CopyToEx(objvCurrEduClsENS: clsvCurrEduClsEN): clsvCurrEduClsENEx {
        var objvCurrEduClsENT = new clsvCurrEduClsENEx();
        try {
            objvCurrEduClsENT = vCurrEduClsEx_CopyToEx(objvCurrEduClsENS);
            return objvCurrEduClsENT;
        }
        catch (e) {
            var strMsg: string = clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})",
                clsStackTrace.GetCurrClassFunction());
            alert(strMsg);
            return objvCurrEduClsENT;
        }
    }
    /// <summary>
    /// 把一个扩展类的部分属性进行函数转换
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
    /// </summary>
    /// <param name = "objvCurrEduClsS">源对象</param>
    public async FuncMap(objvCurrEduCls: clsvCurrEduClsENEx) {
        try {
            {
                var vUsersSim_UserId = objvCurrEduCls.modifyUserID;
                var vUsersSim_UserName = await vUsersSim_func(clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, vUsersSim_UserId);
                objvCurrEduCls.userName = vUsersSim_UserName;
            };

            {
                let arrgs_TeachingDate = await gs_TeachingDate_GetObjLst_Cache(objvCurrEduCls.id_CurrEduCls);
                if (arrgs_TeachingDate.length > 0) {
                    let objgs_TeachingDate = arrgs_TeachingDate[0];
                    let strTeachingDate = clsString.Format("{0}-{1}", objgs_TeachingDate.startDate, objgs_TeachingDate.endDate);
                    objvCurrEduCls.teachingDate = strTeachingDate;
                }
            };


        }
        catch (e) {
            var strMsg: string = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
        }
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vCurrEduCls() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevCurrEduClsCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvCurrEduClsObjLst: Array<clsvCurrEduClsEN> = [];
        var arrvCurrEduClsExObjLst: Array<clsvCurrEduClsENEx> = [];
        try {
            const responseRecCount = await vCurrEduCls_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvCurrEduClsBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vCurrEduCls_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvCurrEduClsObjLst = <Array<clsvCurrEduClsEN>>jsonData;
            });


            arrvCurrEduClsExObjLst = arrvCurrEduClsObjLst.map(this.CopyToEx);
            for (var objInFor of arrvCurrEduClsExObjLst) {
                const conFuncMap = await this.FuncMap(objInFor);
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }

        try {
            this.BindTab_vCurrEduCls(strListDiv, arrvCurrEduClsExObjLst);
            console.log("完成BindGv_vCurrEduCls!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vCurrEduCls对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrCurrEduClsObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vCurrEduCls(divContainer: string, arrvCurrEduClsObjLst: Array<clsvCurrEduClsENEx>) {
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
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "currEduClsId",
                    ColHeader: "教学班Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    ColHeader: "教学班",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "courseCode",
                //    ColHeader: "课程代码",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "courseName",
                    ColHeader: "课程",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "collegeName",
                    ColHeader: "学院",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "schoolYear",
                    ColHeader: "学年",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "schoolTerm",
                    ColHeader: "学期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "TeachingDate",
                    ColHeader: "时间范围",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    SortBy: "userName",
                    ColHeader: "编辑人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 21,
                    FuncName: () => { }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvCurrEduClsObjLst, arrDataColumn, "id_CurrEduCls");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    /* 设置教学班时间范围；
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
    public async btnSetUpDateRecord_Click(KeyId: string) {
        var objPage: CurrEduClsCRUDEx = new CurrEduClsCRUDEx();
        var objPage_Edit: gs_TeachingDate_EditEx = new gs_TeachingDate_EditEx(objPage);
        var strKeyId = KeyId;
        //判断教学班数据是否已经被设置
        var strWhere = " 1 = 1 And id_CurrEduCls = '" + strKeyId + "'";
        const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhere);
        var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
        if (objgs_TeachingDateEN != null) {
            //赋值，弹出框
            //存放教学班日期范围表主键
            $("#hidgs_DateId").val(objgs_TeachingDateEN.mId);
            objPage_Edit.btnUpdateRecordInTab_Click(objgs_TeachingDateEN.mId.toString());
        }
        else {
            //添加 需要清空下隐藏数据
            $("#hidgs_DateId").val("");
            objPage_Edit.btnAddNewRecord_Click();

        }


      
    }
    /* 为插入记录做准备工作
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
    public async AddNewSetDate() {
        //去掉提交按钮不可用状态
        $('#btnOKUpd').attr("disabled", false);
        this.OpType = "AddWithMaxId";
        //this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();

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