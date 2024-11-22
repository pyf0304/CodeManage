﻿
 /**
 * 类名:vqa_Answer_DetailEx(界面:qa_AnswerCRUD)
 * 表名:qa_Answer(01120641)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/08 01:02:24
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:互动管理(InteractManage)
 * 框架-层名:WA_详细信息后台Ex_TS(TS)(WA_ViewScript_DetailCSEx_TS)
 * 编程语言:TypeScript
 **/
import { vqa_Answer_Detail } from "../PagesBase/InteractManage/vqa_Answer_Detail.js";
import { qa_AnswerCRUDEx } from "./qa_AnswerCRUDEx.js";
declare function ShowDialog_qa_Answer(strOpType:string): void;
declare function HideDialog_vqa_Answer(): void;
 /* vqa_Answer_DetailEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
*/
export class vqa_Answer_DetailEx extends vqa_Answer_Detail
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
 **/
public btnDetail_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnDetail_Click.name;
const objqa_AnswerCRUD:qa_AnswerCRUDEx = new qa_AnswerCRUDEx();
const objPage:vqa_Answer_DetailEx = new vqa_Answer_DetailEx(objqa_AnswerCRUD);
switch (strCommandName)
{
case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
////objPage.btnAddNewRecordWithMaxId_Click();
break;
case "CreateWithMaxId":    //添加记录使用最大关键字
//objPage.btnAddNewRecordWithMaxId_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(vqa_Answer_DetailExEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}