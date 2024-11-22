
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:cc_CourseCRUDEx
 表名:cc_Course(01120056)
 生成代码版本:2020.05.12.1
 生成日期:2020/05/12 20:36:27
 生成者:
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:课程学习
 模块英文名:CourseLearning
 框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { cc_CourseCRUD } from "./cc_CourseCRUD.js";
import { clsCommonFunc4Web }   from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clscc_CourseEN } from "../TS/L0_Entity/CourseLearning/clscc_CourseEN.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsvcc_CourseEN } from "../TS/L0_Entity/CourseLearning/clsvcc_CourseEN.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { cc_Course_GetMaxStrIdAsync, cc_Course_GetObjByCourseIdAsync, cc_Course_GetObjLstAsync } from "../TS/L3_ForWApi/CourseLearning/clscc_CourseWApi.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
 /* cc_CourseCRUDEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class cc_CourseCRUDEx extends cc_CourseCRUD
{
//public static mstrListDiv: string = "divDataLst";
//public static mstrSortvcc_CourseBy: string = "courseId";
 /*
 * 每页记录数，在扩展类可以修改
*/
public get pageSize():number {
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

            this.hidSortvcc_CourseBy = "courseCode Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vcc_Course();
            $("#divLoading").hide();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
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
                            var returnBool2: string = jsonData;
                            if (clsString.IsNullOrEmpty(returnBool2) == false) {
                                HideDialog();
                                this.BindGv_vcc_Course();
                            }
                        });
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vcc_Course();
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In cc_CourseCRUD.btnOKUpd_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_vcc_Course();
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

 /*
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
 */
public static btn_Click(strCommandName: string, strKeyId: string) {
var objPage:cc_CourseCRUDEx = new cc_CourseCRUDEx();
switch (strCommandName)
{
case "Query":    //查询记录
objPage.btnQuery_Click();
break;

case "UpdateRecord":            //修改记录
case "Update":            //修改记录
var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
        objPage.btnUpdateRecord_Click(strKeyId);
break;
case "CopyRecord":            //复制记录
case "Clone":            //复制记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要复制的记录！");
return;
}
//objPage.btnCopyRecord_Click();
break;
case "DelRecord":            //删除记录
case "Delete":            //删除记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return;
}
objPage.btnDelRecord_Click();
break;
case "DelRecordBySign":            //按标志删除记录
case "DeleteBySign":            //按标志删除记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return;
}
//objPage.btnDelRecordBySign_Click();
break;
case "UnDelRecordBySign":            //按标志恢复删除记录
case "UnDeleteBySign":            //按标志恢复删除记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return;
}
//objPage.btnUnDelRecordBySign_Click();
break;
case "GoTop":            //置顶记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要置顶的记录！");
return;
}
//objPage.btnGoTop_Click();
break;
case "GoBottum":            //移底记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要移底的记录！");
return;
}
//objPage.btnGoBottum_Click();
break;
case "UpMove":            //上移记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要上移的记录！");
return;
}
//objPage.btnUpMove_Click();
break;
case "DownMove":            //下移记录
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
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
        //wuccc_CourseB1.courseId = clscc_CourseBL.GetMaxStrId_S();
        try {
            const responseText = await cc_Course_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表cc_Course的最大关键字为空，不成功，请检查!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                $('#txtCourseId').val(returnString);
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
        //wuccc_CourseB1.courseId = clscc_CourseBL.GetMaxStrId_S();
    }


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
            const responseText = await cc_Course_GetObjByCourseIdAsync(strKeyId);
            var objcc_CourseEN: clscc_CourseEN = <clscc_CourseEN>responseText;
            if (objcc_CourseEN.updUserId == strUserId) {
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
            var strWhereCond = " courseId in (" + strKeyList + ")";
            var arrcc_CourseObjLst: Array<clscc_CourseEN> = [];
            const responseText1 = await cc_Course_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrcc_CourseObjLst = <Array<clscc_CourseEN>>jsonData;
                //查询是否有提交的数据
                arrcc_CourseObjLst = arrcc_CourseObjLst.filter(x => x.updUserId != strUserId);
                if (arrcc_CourseObjLst.length > 0) {
                    alert("包含其他用户添加数据，不能删除！");
                    return "";
                }
            });


            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vcc_Course();
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
    public Combinevcc_CourseCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.CourseCode_q != "") {
                strWhereCond += ` And ${clsvcc_CourseEN.con_CourseCode} like '% ${this.CourseCode_q}%'`;
            }
            if (this.CourseName_q != "") {
                strWhereCond += ` And ${clsvcc_CourseEN.con_CourseName} like '% ${this.CourseName_q}%'`;
            }
            if (this.majorName_q != "") {
                strWhereCond += ` And ${clsvcc_CourseEN.con_MajorName} like '% ${this.majorName_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinecc_CourseCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 显示vcc_Course对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrcc_CourseObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vcc_Course(divContainer: string, arrvcc_CourseObjLst: Array<clsvcc_CourseEN>) {
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
                    FldName: "courseCode",
                    ColHeader: "课程代码",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                
                {
                    FldName: "courseName",
                    ColHeader: "课程名",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "CourseTypeName",
                    ColHeader: "课程类型名",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorName",
                    ColHeader: "专业名",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "courseDescription",
                    ColHeader: "课程描述",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "编辑人",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "编辑时间",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "",
                //    ColHeader: "修改",
                //    Text: "修改",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvcc_CourseObjLst, arrDataColumn, "courseId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

}