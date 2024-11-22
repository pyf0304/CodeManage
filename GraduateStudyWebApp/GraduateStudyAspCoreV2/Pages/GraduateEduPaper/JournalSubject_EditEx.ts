
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:JournalSubject_EditEx(界面:JournalSubjectCRUD)
 表名:JournalSubject(01120930)
 生成代码版本:2021.06.19.1
 生成日期:2021/06/20 00:53:36
 生成者:
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";

import { JournalSubject_Edit } from "../PagesBase/GraduateEduPaper/JournalSubject_Edit.js";
import { BindTab }   from "../TS/PubFun/clsCommFunc4Web.js";
declare var $;
 /* JournalSubject_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class JournalSubject_EditEx extends JournalSubject_Edit
{


 /*
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 */
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
var objPage = JournalSubject_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
var strMsg = '命令:' + strCommandName + "在函数(JournalSubject_EditEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}