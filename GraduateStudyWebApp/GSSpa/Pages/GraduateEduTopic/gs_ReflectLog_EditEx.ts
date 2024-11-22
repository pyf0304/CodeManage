
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_ReflectLog_EditEx
表名:gs_ReflectLog(01120702)
生成代码版本:2020.07.13.1
生成日期:2020/07/14 16:04:54
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_界面编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { gs_ReflectLog_Edit } from "./gs_ReflectLog_Edit.js";
import { gs_ReflectLogCRUDEx } from "./gs_ReflectLogCRUDEx.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsgs_ReflectLogEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
declare function ShowDialog_gs_ReflectLog(strOpType): void;
declare function HideDialog_gs_ReflectLog(): void;
declare var $;
declare var window;
/* gs_ReflectLog_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class gs_ReflectLog_EditEx extends gs_ReflectLog_Edit {

    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    */
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        var objgs_ReflectLogCRUD: gs_ReflectLogCRUDEx = new gs_ReflectLogCRUDEx();
        var objPage: gs_ReflectLog_EditEx = new gs_ReflectLog_EditEx(objgs_ReflectLogCRUD);
        switch (strCommandName) {
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage.btnAddNewRecord_Click();
                break;
       
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                var strMsg = '命令:' + strCommandName + "在函数(gs_ReflectLog_EditExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }
    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjgs_ReflectLogEN">数据传输的目的类对象</param>
*/
    public PutDataTogs_ReflectLogClass(pobjgs_ReflectLogEN: clsgs_ReflectLogEN) {
        var strTopicId = $("#hidTopicRelaId").val();
        pobjgs_ReflectLogEN.topicId = strTopicId;// 主题编号
        pobjgs_ReflectLogEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
        pobjgs_ReflectLogEN.reflectLogName = this.reflectLogName;// 标题
        pobjgs_ReflectLogEN.reflectLogContent = this.reflectLogContent;// 内容
        pobjgs_ReflectLogEN.updDate = clsPubFun4Web.getNowDate_ymd();// 修改日期
        pobjgs_ReflectLogEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改人
        pobjgs_ReflectLogEN.memo = this.memo;// 备注
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_ReflectLog;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    if (this.OpType == "AddWithMaxId") {
                        //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                        //var returnBool2: boolean = jsonData;
                        //if (returnBool2 == true)
                        //{
                        //HideDialog_gs_ReflectLog();
                        //this.iShowList.BindGv_Cache(clsgs_ReflectLogEN._CurrTabName);
                        //}
                        //});
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog_gs_ReflectLog();
                                this.iShowList.BindGv(clsgs_ReflectLogEN._CurrTabName, "");
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In gs_ReflectLog_Edit.btnSubmit_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog_gs_ReflectLog();
                            this.iShowList.BindGv(clsgs_ReflectLogEN._CurrTabName, "");
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

}