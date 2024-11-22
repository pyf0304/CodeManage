
 /**
 * 类名:gs_TotalDataStatistics_EditEx(界面:gs_TotalDataStatisticsCRUD)
 * 表名:gs_TotalDataStatistics(01120683)
 * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/06 11:03:39
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
 * 编程语言:TypeScript
 **/
import { gs_TotalDataStatistics_Edit } from "../PagesBase/GraduateEduTools/gs_TotalDataStatistics_Edit.js";
 /* gs_TotalDataStatistics_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class gs_TotalDataStatistics_EditEx extends gs_TotalDataStatistics_Edit
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 **/
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnEdit_Click.name;
const objPage = gs_TotalDataStatistics_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(gs_TotalDataStatistics_EditEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}



}