
 /**
 * 类名:qa_Questions_DetailEx(界面:qa_QuestionsCRUD)
 * 表名:qa_Questions(01120642)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/08 01:17:19
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:互动管理(InteractManage)
 * 框架-层名:WA_详细信息后台Ex_TS(TS)(WA_ViewScript_DetailCSEx_TS)
 * 编程语言:TypeScript
 **/
import { qa_Questions_Detail } from "../PagesBase/InteractManage/qa_Questions_Detail.js";
import { qa_QuestionsCRUDEx } from "./qa_QuestionsCRUDEx.js";
declare function ShowDialog_qa_Questions(strOpType:string): void;
declare function HideDialog_vqa_Questions(): void;
 /* qa_Questions_DetailEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
*/
export class qa_Questions_DetailEx extends qa_Questions_Detail
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
 **/
public btnDetail_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnDetail_Click.name;
const objqa_QuestionsCRUD:qa_QuestionsCRUDEx = new qa_QuestionsCRUDEx();
const objPage:qa_Questions_DetailEx = new qa_Questions_DetailEx(objqa_QuestionsCRUD);
switch (strCommandName)
{
case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
////objPage.btnAddNewRecordWithMaxId_Click();
break;
case "CreateWithMaxId":    //添加记录使用最大关键字
//objPage.btnAddNewRecordWithMaxId_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(qa_Questions_DetailExEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}