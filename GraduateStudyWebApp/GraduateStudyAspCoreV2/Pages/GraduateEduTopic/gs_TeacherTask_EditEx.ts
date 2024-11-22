
/**
* 类名:gs_TeacherTask_EditEx(界面:gs_TeacherTaskCRUD)
* 表名:gs_TeacherTask(01120686)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/07 16:22:44
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培主题(GraduateEduTopic)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
import { gs_TeacherTask_Edit } from "../PagesBase/GraduateEduTopic/gs_TeacherTask_Edit.js";
import { enumPageDispMode } from "../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js";
import { CheckDivExist } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { Format } from "../TS/PubFun/clsString.js";
/* gs_TeacherTask_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class gs_TeacherTask_EditEx extends gs_TeacherTask_Edit {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    **/
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnEdit_Click.name;
        const objPage = gs_TeacherTask_EditEx.objPage_Edit;
        switch (strCommandName) {
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(gs_TeacherTask_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }
    /**
    * 在当前界面中，导入编辑区域
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    * @returns 
    **/
    public async AddDPV_Edit(divName4Edit: string) {
        const strThisFuncName = this.AddDPV_Edit.name;
        CheckDivExist(divName4Edit);
        const strUrl = "../GraduateEduTopic/gs_TeacherTask_Edit";
        //console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data: any) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Edit).html(data);
                    resolve(true);
                    //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                    //clsEditObj.BindTab();
                },
                error: (e: any) => {
                    console.error(e);
                    reject(e);
                }
            });
        });
    }

    /** 添加新记录
  * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
  **/
    public async btnAddNewRecord_Click() {
        const strThisFuncName = this.btnAddNewRecord_Click.name;
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                this.opType = "Add";
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegionInDiv();
                this.SetEventFunc();
                this.bolIsLoadEditRegion = true;  //
                this.btnSubmit_gs_TeacherTask = "确认添加";
                this.btnCancel_gs_TeacherTask = "取消添加";
                const responseText = this.AddNewRecord();
                if (gs_TeacherTask_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01) {
                    this.ShowDialog_gs_TeacherTask('Add');
                }
            }
            else {
                this.opType = "Add";
                this.btnSubmit_gs_TeacherTask = "确认添加";
                this.btnCancel_gs_TeacherTask = "取消添加";
                const responseText = await this.AddNewRecord();
                if (gs_TeacherTask_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01) {
                    this.ShowDialog_gs_TeacherTask('Add');
                }
            }
        }
        catch (e) {
            const strMsg = Format("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }


}