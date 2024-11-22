
 /**
 * 类名:gs_TopicTaskStatus_EditEx(界面:gs_TopicTaskStatusCRUD)
 * 表名:gs_TopicTaskStatus(01120664)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/06 01:37:19
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培参数(ParameterTable)
 * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
 * 编程语言:TypeScript
 **/
import { gs_TopicTaskStatus_Edit } from "../PagesBase/ParameterTable/gs_TopicTaskStatus_Edit.js";
import { clsgs_TopicTaskStatusEN } from "../TS/L0_Entity/ParameterTable/clsgs_TopicTaskStatusEN.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
 /* gs_TopicTaskStatus_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class gs_TopicTaskStatus_EditEx extends gs_TopicTaskStatus_Edit
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 **/
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnEdit_Click.name;
const objPage = gs_TopicTaskStatus_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(gs_TopicTaskStatus_EditEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}


    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjgs_TopicTaskStatusEN">数据传输的目的类对象</param>
*/
    public async PutDataTogs_TopicTaskStatusClass(pobjgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN) {
        pobjgs_TopicTaskStatusEN.SetStatusId(this.statusId);// 状态Id
        pobjgs_TopicTaskStatusEN.SetStatusName(this.statusName);// 状态名称
        pobjgs_TopicTaskStatusEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
    }


}