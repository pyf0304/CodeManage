﻿
/**
* 类名:SysSkill_EditEx(界面:SysSkillCRUD)
* 表名:SysSkill(01120646)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/07 23:16:04
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培主题(GraduateEduTopic)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
import { SysSkill_Edit } from "../PagesBase/GraduateEduTopic/SysSkill_Edit.js";
/* SysSkill_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class SysSkill_EditEx4ResearchTopicSysskill extends SysSkill_Edit {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = SysSkill_EditEx4ResearchTopicSysskill.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(SysSkill_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }
  

}