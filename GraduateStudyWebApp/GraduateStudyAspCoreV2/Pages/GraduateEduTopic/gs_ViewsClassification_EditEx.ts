

import { gs_ViewsClassification_Edit } from "../PagesBase/GraduateEduTopic/gs_ViewsClassification_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_ViewsClassificationEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { IsNullOrEmpty } from "../TS/PubFun/clsString.js";

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
                var strMsg = '命令:' + strCommandName + "在函数(gs_ViewsClassification_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }

    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjgs_ViewsClassificationEN">数据传输的目的类对象</param>
  */
    public async PutDataTogs_ViewsClassificationClass(pobjgs_ViewsClassificationEN: clsgs_ViewsClassificationEN) {
        //pobjgs_ViewsClassificationEN.SetClassificationId(this.classificationId;// 分类Id
        pobjgs_ViewsClassificationEN.SetClassificationName(this.classificationName);// 分类名称
        pobjgs_ViewsClassificationEN.SetTopicId(clsPrivateSessionStorage.topicId);// 主题编号
        pobjgs_ViewsClassificationEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjgs_ViewsClassificationEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjgs_ViewsClassificationEN.SetMemo(this.memo);// 备注
        pobjgs_ViewsClassificationEN.SetOrderNum(this.orderNum);// 序号
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
                    //if (this.opType == "AddWithMaxId") {
                    const returnKeyId = await this.AddNewRecordWithMaxIdSave();
                    if (IsNullOrEmpty(returnKeyId) == false) {
                        this.HideDialog_gs_ViewsClassification();
                        this.iShowList.BindGv(clsgs_ViewsClassificationEN._CurrTabName, "");
                    }

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
                    const returnBool = await this.UpdateRecordSave();
                    var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                    strInfo += "(In gs_ViewsClassification_Edit.btnSubmit_Click)";                    
                    //显示信息框
                    console.log(strInfo);
                    alert(strInfo);
                    if (returnBool == true) {
                        this.HideDialog_gs_ViewsClassification();
                        this.iShowList.BindGv(clsgs_ViewsClassificationEN._CurrTabName, "");
                    }

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
    /** 函数功能:为编辑区绑定下拉框
* (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
**/
    public async BindDdl4EditRegionInDiv() {
        const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
        // 在此处放置用户代码以初始化页面
        const strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;


        await this.SetDdl_TopicIdInDiv(strid_CurrEduCls);//编辑区域
    }

}