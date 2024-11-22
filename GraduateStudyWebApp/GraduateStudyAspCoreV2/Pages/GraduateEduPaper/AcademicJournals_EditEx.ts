
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AcademicJournals_EditEx(界面:AcademicJournalsCRUD)
 表名:AcademicJournals(01120929)
 生成代码版本:2021.06.20.1
 生成日期:2021/06/20 17:34:13
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

import { AcademicJournals_Edit } from "../PagesBase/GraduateEduPaper/AcademicJournals_Edit.js";

declare var $;
 /* AcademicJournals_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class AcademicJournals_EditEx extends AcademicJournals_Edit
{


 /*
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 */
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
var objPage = AcademicJournals_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
var strMsg = '命令:' + strCommandName + "在函数(AcademicJournals_EditEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}