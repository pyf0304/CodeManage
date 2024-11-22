
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_PaperReport_EditEx
表名:gs_PaperReport(01120772)
生成代码版本:2020.11.22.1
生成日期:2020/12/01 00:54:01
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
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsgs_PaperReportEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_PaperReportEN.js";
import { clsvRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { gs_PaperReport_AddNewRecordWithMaxIdAsync, gs_PaperReport_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_PaperReportWApi.js";
import { vRTPaperRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { gs_PaperReport_Edit } from "./gs_PaperReport_Edit.js";
declare function ShowDialog_gs_PaperReport(strOpType): void;
declare function HideDialog_gs_PaperReport(): void;
declare function layui_Alert(str1, str2): void;
declare var $;
declare var window;
/* gs_PaperReport_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class gs_PaperReport_EditEx extends gs_PaperReport_Edit {


    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    */
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        var objPage = gs_PaperReport_EditEx.objPage_Edit;
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
                var strMsg = '命令:' + strCommandName + "在函数(gs_PaperReport_EditExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }

    /* 为插入记录做准备工作
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
  */
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_gs_PaperReport = "确认添加";
        this.btnCancel_gs_PaperReport = "取消添加";
        this.Clear();
        this.reportDate = clsPubFun4Web.getNowDate_ymd();
        //wucgs_PaperReportB1.reportId = clsgs_PaperReportBL.GetMaxStrId_S();
    }


    /// <summary>
    /// 设置绑定下拉框，针对字段:[paperId]
    /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
    /// </summary>
    public async SetDdl_PaperId(strid_CurrEduCls: string) {
        //var objPaper_Cond: clsPaperEN = new clsPaperEN();//编辑区域
        ////定义条件字段
        ////var strid_CurrEduCls = "";//定义条件字段
        //const ddlPaperId = await Paper_BindDdl_PaperId_Cache("ddlPaperId", objPaper_Cond, strid_CurrEduCls);//编辑区域
        const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId");
    }

    //专业下拉框绑定
    public BindDdl_PaperId(ddlPaperId: string) {
        var strTopicId = $("#hidTopicRelaId").val();
        var strWhereCond = " topicId= " + strTopicId;

        var objDdl = document.getElementById(ddlPaperId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlPaperId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = vRTPaperRela_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN> = <Array<clsvRTPaperRelaEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlPaperId, arrvRTPaperRelaObjLst, clsvRTPaperRelaEN.con_PaperId, clsvRTPaperRelaEN.con_PaperTitle, "主题相关论文");
                    console.log("完成BindDdl_UserId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    public PutDataTogs_PaperReportClass(pobjgs_PaperReportEN: clsgs_PaperReportEN) {
        //pobjgs_PaperReportEN.reportId = this.reportId;// 会议Id
        //getTextboxio();
        pobjgs_PaperReportEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
        pobjgs_PaperReportEN.topicId = $("#hidTopicRelaId").val();// 主题编号
        pobjgs_PaperReportEN.isSubmit = false;// 是否提交
        pobjgs_PaperReportEN.reportContent = this.reportContent;// 会议内容
        pobjgs_PaperReportEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjgs_PaperReportEN.reportUser = $("#txtReportUser").val();// 参会者
        pobjgs_PaperReportEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改人
        pobjgs_PaperReportEN.paperId = this.paperId;// 论文Id

        pobjgs_PaperReportEN.ppTUrl = $("#hidppt").val();// PPT
        pobjgs_PaperReportEN.pdFUrl = $("#hidpdf").val();// PDF

        var strYmd = clsPubFun4Web.getNowDate_ymd();
        if (this.reportDate == "") {
            pobjgs_PaperReportEN.reportDate = strYmd;// 会议日期
        } else {
            pobjgs_PaperReportEN.reportDate = this.reportDate;// 会议日期
        }
        pobjgs_PaperReportEN.year = this.reportDate.substr(0, 4);
        pobjgs_PaperReportEN.month = this.reportDate.substr(5, 2);
        pobjgs_PaperReportEN.memo = this.memo;// 备注
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjgs_PaperReportEN">表实体类对象</param>
   */
    public GetDataFromgs_PaperReportClass(pobjgs_PaperReportEN: clsgs_PaperReportEN) {
        this.reportId = pobjgs_PaperReportEN.reportId;// 会议Id
        //this.topicId = pobjgs_PaperReportEN.topicId;// 主题编号
        //this.isSubmit = pobjgs_PaperReportEN.isSubmit;// 是否提交
        this.reportContent = pobjgs_PaperReportEN.reportContent;// 会议内容
        $("#txtReportUser").val(pobjgs_PaperReportEN.reportUser);// 参会者
        this.paperId = pobjgs_PaperReportEN.paperId;
        $("#hidppt").val(pobjgs_PaperReportEN.ppTUrl);// PPT
        $("#hidpdf").val(pobjgs_PaperReportEN.pdFUrl);// PDF
        this.reportDate = pobjgs_PaperReportEN.reportDate;// 会议日期
        this.memo = pobjgs_PaperReportEN.memo;// 备注
        //setTextboxio();
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_PaperReport;

        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    //if (this.OpType == "AddWithMaxId") {
                    //    //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                    //    //var returnBool2: boolean = jsonData;
                    //    //if (returnBool2 == true)
                    //    //{
                    //    //HideDialog_gs_PaperReport();
                    //    //this.iShowList.BindGv_Cache(clsgs_PaperReportEN._CurrTabName);
                    //    //}
                    //    //});
                    //}
                    //else {
                    var strReportId;
                    const responseText2 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                        strReportId = jsonData;
                    });
                    if (strReportId != "") {


                        HideDialog_gs_PaperReport();
                        this.iShowList.BindGv(clsgs_PaperReportEN._CurrTabName, "");
                        //alert("添加历史版本出问题！");


                    }
                    //}
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    var returnBool;
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        returnBool = jsonData;
                    });
                    if (returnBool == true) {
                        $("#hidReportId").val(this.KeyId);
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        //strInfo += "(In gs_PaperReport_Edit.btnSubmit_Click)";
                        //$('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        //alert(strInfo);
                        layui_Alert(1, strInfo);
                        $("#divLoading").hide();



                        HideDialog_gs_PaperReport();
                        this.iShowList.BindGv(clsgs_PaperReportEN._CurrTabName, "");


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

    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
   (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
  */
    public async AddNewRecordWithMaxIdSave() {
        this.DivName = "divAddNewRecordWithMaxIdSave";
        var objgs_PaperReportEN: clsgs_PaperReportEN = new clsgs_PaperReportEN();
        this.PutDataTogs_PaperReportClass(objgs_PaperReportEN);
        try {
            const responseKeyId = await gs_PaperReport_AddNewRecordWithMaxIdAsync(objgs_PaperReportEN);
            var returnKeyId: string = responseKeyId;
            if (clsString.IsNullOrEmpty(returnKeyId) == false) {
                //gs_PaperReport_ReFreshCache();
                var strInfo: string = `添加记录成功!`;
                //$('#lblResult47').val(strInfo);
                //显示信息框
                //alert(strInfo);
                layui_Alert(1, strInfo);
                $("#divLoading").hide();
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseKeyId;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }


    /* 修改记录
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public async UpdateRecordSave() {
        this.DivName = "divUpdateRecordSave";
        var objgs_PaperReportEN: clsgs_PaperReportEN = new clsgs_PaperReportEN();
        objgs_PaperReportEN.reportId = this.KeyId;
        this.PutDataTogs_PaperReportClass(objgs_PaperReportEN);
        objgs_PaperReportEN.sf_UpdFldSetStr = objgs_PaperReportEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_PaperReportEN.reportId == "" || objgs_PaperReportEN.reportId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await gs_PaperReport_UpdateRecordAsync(objgs_PaperReportEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //gs_PaperReport_ReFreshCache();
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }



}