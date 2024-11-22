﻿
/**
* 类名:ExplainType_EditEx(界面:ExplainTypeCRUD)
* 表名:ExplainType(01120548)
* 版本:2023.01.04.1(服务器:WIN-SRV103-116)
* 日期:2023/01/06 22:43:11
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培参数(ParameterTable)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
import { ExplainType_Edit } from "../PagesBase/ParameterTable/ExplainType_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsExplainTypeEN } from "../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
/* ExplainType_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class ExplainType_EditEx extends ExplainType_Edit {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = ExplainType_EditEx.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(ExplainType_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }

    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjExplainTypeEN">数据传输的目的类对象</param>
  */
    public async PutDataToExplainTypeClass(pobjExplainTypeEN: clsExplainTypeEN) {
        pobjExplainTypeEN.SetExplainTypeId(this.explainTypeId);// 说明类型Id
        pobjExplainTypeEN.SetExplainTypeName(this.explainTypeName);// 说明类型名
        pobjExplainTypeEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjExplainTypeEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id
        pobjExplainTypeEN.SetMemo(this.memo);// 备注
    }


}