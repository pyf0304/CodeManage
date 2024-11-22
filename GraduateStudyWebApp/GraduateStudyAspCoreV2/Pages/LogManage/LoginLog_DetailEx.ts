
 /**
 * 类名:LoginLog_DetailEx(界面:LoginLogCRUD)
 * 表名:LoginLog(01120357)
 * 版本:2023.01.09.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 01:41:33
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:日志管理(LogManage)
 * 框架-层名:WA_详细信息后台Ex_TS(TS)(WA_ViewScript_DetailCSEx_TS)
 * 编程语言:TypeScript
 **/
import { LoginLog_Detail } from "../PagesBase/LogManage/LoginLog_Detail.js";
import { LoginLogCRUDEx } from "./LoginLogCRUDEx.js";
declare function ShowDialog_LoginLog(strOpType:string): void;
declare function HideDialog_LoginLog(): void;
 /* LoginLog_DetailEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
*/
export class LoginLog_DetailEx extends LoginLog_Detail
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
 **/
public btnDetail_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnDetail_Click.name;
const objLoginLogCRUD:LoginLogCRUDEx = new LoginLogCRUDEx();
const objPage:LoginLog_DetailEx = new LoginLog_DetailEx(objLoginLogCRUD);
switch (strCommandName)
{
case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
////objPage.btnAddNewRecordWithMaxId_Click();
break;
case "CreateWithMaxId":    //添加记录使用最大关键字
//objPage.btnAddNewRecordWithMaxId_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(LoginLog_DetailExEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}