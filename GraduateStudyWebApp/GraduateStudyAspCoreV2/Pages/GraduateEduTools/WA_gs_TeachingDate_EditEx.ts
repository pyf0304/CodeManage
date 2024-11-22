
 /**
 * 类名:WA_gs_TeachingDate_EditEx(界面:gs_TeachingDateCRUD)
 * 表名:gs_TeachingDate(01120684)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/06 01:51:44
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
 * 编程语言:TypeScript
 **/
import { gs_TeachingDate_Edit } from "../PagesBase/GraduateEduTools/gs_TeachingDate_Edit.js";
 /* WA_gs_TeachingDate_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class WA_gs_TeachingDate_EditEx extends gs_TeachingDate_Edit
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 **/
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnEdit_Click.name;
const objPage = WA_gs_TeachingDate_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(WA_gs_TeachingDate_EditEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}