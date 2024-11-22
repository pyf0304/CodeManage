
 /**
 * 类名:gs_PaperAttention_EditEx(界面:gs_PaperAttentionCRUD)
 * 表名:gs_PaperAttention(01120748)
 * 版本:2023.02.18.1(服务器:WIN-SRV103-116)
 * 日期:2023/02/18 03:37:02
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
 * 编程语言:TypeScript
 **/

import { gs_PaperAttention_Edit } from "../PagesBase/GraduateEduPaper/gs_PaperAttention_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_PaperAttentionEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
import { clsgs_PaperGroupEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { gs_PaperAttention_AddNewRecordAsync, gs_PaperAttention_IsExistRecordAsync, gs_PaperAttention_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { gs_PaperGroup_AddNewRecordWithReturnKeyAsync, gs_PaperGroup_GetFirstObjAsync, gs_PaperGroup_ReFreshCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js";
import { vgs_PaperAttention_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
declare function layui_Alert(iconKey, strMsg): void;

 /* gs_PaperAttention_EditEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class gs_PaperAttention_EditEx extends gs_PaperAttention_Edit
{


 /**
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
 **/
public static btnEdit_Click(strCommandName: string, strKeyId: string) {
const strThisFuncName = this.btnEdit_Click.name;
const objPage = gs_PaperAttention_EditEx.objPage_Edit;
switch (strCommandName)
{
case "Submit":            //提交
objPage.btnSubmit_Click();
break;
default:
const strMsg = '命令:' + strCommandName + "在函数(gs_PaperAttention_EditEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
}
}

    //添加关注
    public async btnAttention_Click(strPaperId: string) {
        try {
            var strUserId = clsPublocalStorage.userId;

            var strWhereCond = " 1 =1 and updUser='" + strUserId + "' and paperId=" + strPaperId;

            const responseText = await gs_PaperAttention_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经关注过这条论文了，请关注其他论文！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }



            var strWhereCond1 = " updUser='" + strUserId + "' and paperGroupName='" + clsPublocalStorage.eduClsName + "'";

            const objgs_PaperGroup = await gs_PaperGroup_GetFirstObjAsync(strWhereCond1);

            var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
            objgs_PaperAttentionEN.SetPaperId(strPaperId);
            objgs_PaperAttentionEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
            objgs_PaperAttentionEN.SetUpdUser(strUserId);// 修改用户Id
            objgs_PaperAttentionEN.SetUserId(strUserId);// 修改用户Id
            if (objgs_PaperGroup != null) {
                objgs_PaperAttentionEN.SetPaperGroupId(objgs_PaperGroup.paperGroupId);
            } else {
                var objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
                objgs_PaperGroupEN.SetPaperGroupName(clsPublocalStorage.eduClsName);
                objgs_PaperGroupEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
                objgs_PaperGroupEN.SetUpdUser(strUserId);// 修改用户Id

                var strPaperGroupId = await gs_PaperGroup_AddNewRecordWithReturnKeyAsync(objgs_PaperGroupEN);
                if (strPaperGroupId != "") {
                    objgs_PaperAttentionEN.SetPaperGroupId(strPaperGroupId);
                    gs_PaperGroup_ReFreshCache(strUserId);//刷新论文组
                }
            }

            const returnBool = await gs_PaperAttention_AddNewRecordAsync(objgs_PaperAttentionEN);
            if (returnBool == true) {
                //this.BindGv_Paper();
                layui_Alert(1, "已关注！")
                vgs_PaperAttention_ReFreshThisCache(strUserId);//刷新论文关注
                gs_PaperAttention_ReFreshThisCache(strUserId);//刷新论文关注

            }
            else {
                var strInfo: string = `关注不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                return false;
                //this.BindGv_vPaperSubViewpoint();
            }
            return returnBool;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `关注不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }



}