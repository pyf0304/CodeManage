
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:JournalSubjectCategory_EditEx(界面:JournalSubjectCategoryCRUD)
 表名:JournalSubjectCategory(01120931)
 生成代码版本:2021.06.19.1
 生成日期:2021/06/20 00:12:22
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
//import * as $ from "jquery";
//import * as QQ from "q";
import { JournalSubjectCategory_Edit } from "./JournalSubjectCategory_Edit.js";
import { clsCommonFunc4Web }   from "../TS/PubFun/clsCommonFunc4Web2.js";
declare var $;
 /* JournalSubjectCategory_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class JournalSubjectCategory_EditEx extends JournalSubjectCategory_Edit
{


 /*
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 */
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
var objPage = JournalSubjectCategory_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
var strMsg = '命令:' + strCommandName + "在函数(JournalSubjectCategory_EditExEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}