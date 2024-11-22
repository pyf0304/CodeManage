
 /**
 * 类名:gs_PaperVer_DetailEx(界面:gs_PaperVerCRUD)
 * 表名:gs_PaperVer(01120678)
 * 版本:2023.01.08.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/08 21:28:40
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_详细信息后台Ex_TS(TS)(WA_ViewScript_DetailCSEx_TS)
 * 编程语言:TypeScript
 **/
import { gs_PaperVer_Detail } from "../PagesBase/GraduateEduPaper/gs_PaperVer_Detail.js";
import { gs_PaperVerCRUDEx } from "./gs_PaperVerCRUDEx.js";
declare function ShowDialog_gs_PaperVer(strOpType:string): void;
declare function HideDialog_gs_PaperVer(): void;
 /* gs_PaperVer_DetailEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
*/
export class gs_PaperVer_DetailEx extends gs_PaperVer_Detail
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
 **/
public btnDetail_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnDetail_Click.name;
const objgs_PaperVerCRUD:gs_PaperVerCRUDEx = new gs_PaperVerCRUDEx();
const objPage:gs_PaperVer_DetailEx = new gs_PaperVer_DetailEx(objgs_PaperVerCRUD);
switch (strCommandName)
{
case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
////objPage.btnAddNewRecordWithMaxId_Click();
break;
case "CreateWithMaxId":    //添加记录使用最大关键字
//objPage.btnAddNewRecordWithMaxId_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(gs_PaperVer_DetailExEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}