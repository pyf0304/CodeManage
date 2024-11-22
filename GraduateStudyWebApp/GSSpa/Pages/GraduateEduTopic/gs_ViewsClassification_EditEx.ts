
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_ViewsClassification_EditEx
表名:gs_ViewsClassification(01120777)
生成代码版本:2020.12.17.1
生成日期:2020/12/17 15:50:51
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { gs_ViewsClassification_Edit } from "./gs_ViewsClassification_Edit.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { clsgs_ViewsClassificationEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
declare function ShowDialog_gs_ViewsClassification(strOpType): void;
declare function HideDialog_gs_ViewsClassification(): void;
declare var $;
declare var window;
/* gs_ViewsClassification_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class gs_ViewsClassification_EditEx extends gs_ViewsClassification_Edit {


    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    */
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        var objPage = gs_ViewsClassification_EditEx.objPage_Edit;
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
                var strMsg = '命令:' + strCommandName + "在函数(gs_ViewsClassification_EditExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }

    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjgs_ViewsClassificationEN">数据传输的目的类对象</param>
  */
    public PutDataTogs_ViewsClassificationClass(pobjgs_ViewsClassificationEN: clsgs_ViewsClassificationEN) {
        //pobjgs_ViewsClassificationEN.classificationId = this.classificationId;// 分类Id
        pobjgs_ViewsClassificationEN.classificationName = this.classificationName;// 分类名称
        pobjgs_ViewsClassificationEN.topicId = $("#hidTopicRelaId").val();// 主题编号
        pobjgs_ViewsClassificationEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjgs_ViewsClassificationEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改人
        pobjgs_ViewsClassificationEN.memo = this.memo;// 备注
        pobjgs_ViewsClassificationEN.orderNum = this.orderNum;// 序号
    }

    
    /* 函数功能:把类对象的属性内容显示到界面上
   注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
    如果在设置数据库时,就应该一级字段在前,二级字段在后
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
    <param name = "pobjgs_ViewsClassificationEN">表实体类对象</param>
  */
    public GetDataFromgs_ViewsClassificationClass(pobjgs_ViewsClassificationEN: clsgs_ViewsClassificationEN) {
        //this.classificationId = pobjgs_ViewsClassificationEN.classificationId;// 分类Id
        this.classificationName = pobjgs_ViewsClassificationEN.classificationName;// 分类名称
        //this.topicId = pobjgs_ViewsClassificationEN.topicId;// 主题编号
        //this.updDate = pobjgs_ViewsClassificationEN.updDate;// 修改日期
        //this.updUser = pobjgs_ViewsClassificationEN.updUser;// 修改人
        //this.memo = pobjgs_ViewsClassificationEN.memo;// 备注
        //this.orderNum = pobjgs_ViewsClassificationEN.orderNum;// 序号
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_ViewsClassification;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    //if (this.OpType == "AddWithMaxId") {
                    const responseText2 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                        var returnKeyId: string = <string>jsonData;
                        if (clsString.IsNullOrEmpty(returnKeyId) == false) {
                            HideDialog_gs_ViewsClassification();
                            this.iShowList.BindGv(clsgs_ViewsClassificationEN._CurrTabName, "");
                        }
                    });

                    //}
                    //else {
                    //    const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                    //        var returnBool: boolean = jsonData;
                    //        if (returnBool == true) {
                    //            HideDialog_gs_ViewsClassification();
                    //            this.iShowList.BindGv(clsgs_ViewsClassificationEN._CurrTabName);
                    //        }
                    //    });
                    //}
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In gs_ViewsClassification_Edit.btnSubmit_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog_gs_ViewsClassification();
                            this.iShowList.BindGv(clsgs_ViewsClassificationEN._CurrTabName, "");
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