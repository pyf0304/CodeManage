
 /**
 * 类名:LoginLog_Detail(界面:LoginLogCRUD)
 * 表名:LoginLog(01120357)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:37:35
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:日志管理(LogManage)
 * 框架-层名:WA_详细信息后台_TS(TS)(WA_ViewScript_DetailCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { LoginLog_GetObjByLoginLogIdAsync } from "../../TS/L3_ForWApi/LogManage/clsLoginLogWApi.js";
import { clsLoginLogEN } from "../../TS/L0_Entity/LogManage/clsLoginLogEN.js";
import { arrSelectedKeys } from "../../TS/PubFun/clsCommFunc4Web.js";
import { CheckControlExist, SetButtonHtmlByIdInDiv, SetLabelHtmlByIdInDiv } from "../../TS/PubFun/clsCommFunc4Ctrl.js";
import { Format, IsNullOrEmpty } from "../../TS/PubFun/clsString.js";
import { IShowList } from "../../TS/PubFun/IShowList.js";
 /**
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strDialogName:string): void;
/**
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(strDialogName:string): void;
 /* LoginLog_Detail 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
*/
export abstract class LoginLog_Detail 
{
public opType = "";
public keyId = "";

private iShowList: IShowList;
public mstrListDiv = "divDataLst";
public bolIsLoadDetailRegion = false;  //记录是否导入编辑区的变量
public divName4Detail = "divDetail";  //编辑区的Id
constructor(objShowList: IShowList) {
this.iShowList = objShowList;
}


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Detail)
 /// </summary>
 /// <returns></returns>
public async AddDPV_Detail(divName4Detail:string) {
const strThisFuncName = this.AddDPV_Detail.name;
const strUrl = "./LoginLog_Detail/";
console.log("divName4Detail:(In AddDPV_Detail)" + divName4Detail);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "html",
data: { },
success: function(data:any) {
console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
$('#' + divName4Detail).html(data);
resolve(true);
//setTimeout(() => { clsDetailObj.BindTab(); }, 100);
//clsDetailObj.BindTab();
},
error: (e:any) => {
console.error(e);
reject(e);
}
});
});
}

 /**
  显示对话框
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
 **/
public ShowDialog_LoginLog(strOp:string) {
const strThisFuncName = this.ShowDialog_LoginLog.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_LoginLog");
CheckControlExist(this.divName4Detail, "h4", "lblDialogTitle_LoginLog");
       if (strOp === "Add" || strOp === "AddWithMaxId" ) {
           $('#lblDialogTitle_LoginLog').html('添加记录');
//LoginLog_DetailEx.GetMaxStrId('#txtLoginLogId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_LoginLog').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_LoginLog').hide();
            $('#lblDialogTitle_LoginLog').html('详细信息');
}
        ShowDialog('#divDetailDialog_LoginLog');
}

 /**
  隐藏对话框
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_LoginLog() {
const strThisFuncName = this.HideDialog_LoginLog.name;
CheckControlExist(this.divName4Detail, "div", "divDetailDialog_LoginLog");
      HideDialog('#divDetailDialog_LoginLog');
}

 /* 
 在数据表里详细信息记录
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
*/
public async btnDetailRecordInTab_Click(strKeyId:string) {
const strThisFuncName = this.btnDetailRecordInTab_Click.name;
this.opType = "Detail";
try
{
 if (strKeyId == "")
{
alert("请选择需要详细信息的记录！");
return "";
}
const lngKeyId =  Number(strKeyId);
this.DetailRecord(lngKeyId);
}
catch(e)
{
const strMsg = Format("详细信息记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /* 
 根据关键字详细信息记录
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
  <param name = "sender">参数列表</param>
*/
public async DetailRecord(lngLoginLogId: number):Promise<boolean> 
{
const strThisFuncName = this.DetailRecord.name;
this.btnSubmit_d_LoginLog = "";
this.btnCancel_d_LoginLog = "关闭";
try
{
const objLoginLogEN = await LoginLog_GetObjByLoginLogIdAsync(lngLoginLogId);
       if (objLoginLogEN == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.ShowDetailDataFromLoginLogClass(objLoginLogEN);
console.log("完成DetailRecord!");
}
catch(e)
{
const strMsg = Format("显示详细信息不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
            return false;
}
            return true;
}

 /* 修改记录
 (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecord_Click)
*/
public async btnDetailRecord_Click(strKeyId:string) {
const strThisFuncName = this.btnDetailRecord_Click.name;
this.opType = "Detail";
if (IsNullOrEmpty(strKeyId) == true)
{
const strMsg = "需要显示详细信息记录的关键字为空，请检查！";
console.error(strMsg);
alert(strMsg);
}
if (this.bolIsLoadDetailRegion == false)  //
{
const responseBool = await this.AddDPV_Detail(this.divName4Detail);
 // 为编辑区绑定下拉框
//const conBindDdl = await this.BindDdl4DetailRegion();
this.bolIsLoadDetailRegion = true;  //
const lngKeyId =  Number(strKeyId);
this.DetailRecord(lngKeyId);
this.ShowDialog_LoginLog('Detail');
}
else
{
const lngKeyId =  Number(strKeyId);
this.DetailRecord(lngKeyId);
this.ShowDialog_LoginLog('Detail');
}
}

 /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
  (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
  <param name = "pobjLoginLogEN">表实体类对象</param>
*/
public ShowDetailDataFromLoginLogClass(pobjLoginLogEN: clsLoginLogEN )
{
const strThisFuncName = this.ShowDetailDataFromLoginLogClass.name;
 this.loginLogNumber_d = pobjLoginLogEN.loginLogNumber;// LoginLogNumber
 this.loginIP_d = pobjLoginLogEN.loginIP;// LoginIP
 this.failReason_d = pobjLoginLogEN.failReason;// FailReason
 this.loginResult_d = pobjLoginLogEN.loginResult;// LoginResult
 this.loginTime_d = pobjLoginLogEN.loginTime;// LoginTime
 this.loginUserId_d = pobjLoginLogEN.loginUserId;// LoginUserId
 this.onlineTime_d = pobjLoginLogEN.onlineTime;// OnlineTime
 this.outTime_d = pobjLoginLogEN.outTime;// OutTime
 this.memo_d = pobjLoginLogEN.memo;// 备注
}
 /**
 * 设置取消按钮的标题(Used In DetailRecord())
 **/
public  set btnCancel_d_LoginLog(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnCancel_d_LoginLog", value);
}
 /**
 * 设置确定按钮的标题(Used In DetailRecord())
 **/
public  set btnSubmit_d_LoginLog(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Detail, "btnSubmit_d_LoginLog", value);
}
 /**
 * FailReason (Used In ShowDetailDataFromClass())
 **/
public  set failReason_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblFailReason_d", value);
}
 /**
 * LoginIP (Used In ShowDetailDataFromClass())
 **/
public  set loginIP_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblLoginIP_d", value);
}
 /**
 * LoginLogNumber (Used In ShowDetailDataFromClass())
 **/
public  set loginLogNumber_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblLoginLogNumber_d", value);
}
 /**
 * LoginResult (Used In ShowDetailDataFromClass())
 **/
public  set loginResult_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblLoginResult_d", value);
}
 /**
 * LoginTime (Used In ShowDetailDataFromClass())
 **/
public  set loginTime_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblLoginTime_d", value);
}
 /**
 * LoginUserId (Used In ShowDetailDataFromClass())
 **/
public  set loginUserId_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblLoginUserId_d", value);
}
 /**
 * 备注 (Used In ShowDetailDataFromClass())
 **/
public  set memo_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblMemo_d", value);
}
 /**
 * OnlineTime (Used In ShowDetailDataFromClass())
 **/
public  set onlineTime_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblOnlineTime_d", value);
}
 /**
 * OutTime (Used In ShowDetailDataFromClass())
 **/
public  set outTime_d(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Detail, "lblOutTime_d", value);
}
}