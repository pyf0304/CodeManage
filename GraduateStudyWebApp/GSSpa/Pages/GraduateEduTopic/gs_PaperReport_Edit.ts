
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_PaperReport_Edit
表名:gs_PaperReport(01120772)
生成代码版本:2020.11.22.1
生成日期:2020/12/01 00:53:20
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_编辑区后台_TS(WA_ViewScript_EditCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsgs_PaperReportEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_PaperReportEN.js";
import { clsvgs_PaperReportEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_PaperReportEN.js";
import { gs_PaperReport_AddNewRecordAsync, gs_PaperReport_AddNewRecordWithMaxIdAsync, gs_PaperReport_GetObjByReportIdAsync, gs_PaperReport_IsExistAsync, gs_PaperReport_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_PaperReportWApi.js";
import { PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";

/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_PaperReport(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_PaperReport(): void;
declare var $;
declare var window;
/* gs_PaperReport_Edit 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
*/
export abstract class gs_PaperReport_Edit {
    public static objPage_Edit: gs_PaperReport_Edit;
    protected iShowList: IShowList;
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divPaperReportEdit";  //编辑区的Id
    constructor(objShowList: IShowList) {
        this.iShowList = objShowList;
        gs_PaperReport_Edit.objPage_Edit = this;
    }
    public objPager: clsPager = new clsPager();
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;


    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        var strUrl: string = "./gs_PaperReport_Edit/";
        console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Edit).html(data);
                    resolve(true);
                    //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                    //clsEditObj.BindTab();
                },
                error: (e) => {
                    console.error(e);
                    reject(e);
                }
            });
        });
    };

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            this.SetEventFunc();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 函数功能:设置事件函数
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
   */
    public async SetEventFunc() {
        // 在此处放置用户代码以初始化页面
        try {
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }





    /* 添加新记录
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.OpType = "Add";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                this.SetEventFunc();
                ShowDialog_gs_PaperReport('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog_gs_PaperReport('Add');
                const responseText = await this.AddNewRecord();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
   */
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        var strid_CurrEduCls = "";  //定义条件字段
        const ddlPaperId = await this.SetDdl_PaperId(strid_CurrEduCls);//编辑区域
    }


    /* 添加新记录
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
   */
    public async btnAddNewRecordWithMaxId_Click() {
        this.OpType = "AddWithMaxId";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                this.SetEventFunc();
                ShowDialog_gs_PaperReport('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecordWithMaxId();
            }
            else {
                ShowDialog_gs_PaperReport('Add');
                const responseText = this.AddNewRecordWithMaxId();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 设置绑定下拉框，针对字段:[paperId]
    /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
    /// </summary>
    public async SetDdl_PaperId(strid_CurrEduCls: string) {
        var objPaper_Cond: clsPaperEN = new clsPaperEN();//编辑区域
        //定义条件字段
        //var strid_CurrEduCls = "";//定义条件字段
        const ddlPaperId = await PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache(this.divName4Edit, "ddlPaperId", strid_CurrEduCls);//编辑区域
      
    }


    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
        this.OpType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            this.SetEventFunc();
            ShowDialog_gs_PaperReport('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_PaperReport('Update');
            this.UpdateRecord(strKeyId);
        }
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
   */
    public async btnUpdateRecord_Click(strKeyId: string) {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            this.SetEventFunc();
            ShowDialog_gs_PaperReport('Update');
            this.bolIsLoadEditRegion = true;  //
            const update = await this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_PaperReport('Update');
            const update = await this.UpdateRecord(strKeyId);
        }
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
                    if (this.OpType == "AddWithMaxId") {
                        const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            var returnKeyId: string = <string>jsonData;
                            if (clsString.IsNullOrEmpty(returnKeyId) == false) {
                                HideDialog_gs_PaperReport();
                                this.iShowList.BindGv(clsvgs_PaperReportEN._CurrTabName, "");
                            }
                        });
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog_gs_PaperReport();
                                this.iShowList.BindGv(clsvgs_PaperReportEN._CurrTabName, "");
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In gs_PaperReport_Edit.btnSubmit_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog_gs_PaperReport();
                            this.iShowList.BindGv(clsvgs_PaperReportEN._CurrTabName, "");
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

    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtReportId').prop['ReadOnly'] = bolReadonly;
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.reportId = "";
        this.updDate = "";
        $('#ddlPaperId option[0]').attr("selected", true);
        this.reportContent = "";
        this.reportUser = "";
        this.reportDate = "";
        this.updUser = "";
        this.pdFUrl = "";
        this.ppTUrl = "";
        this.memo = "";
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_gs_PaperReport = "确认添加";
        this.btnCancel_gs_PaperReport = "取消添加";
        this.Clear();
        //wucgs_PaperReportB1.reportId = clsgs_PaperReportBL.GetMaxStrId_S();
       
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_gs_PaperReport = "确认添加";
        this.btnCancel_gs_PaperReport = "取消添加";
        this.Clear();
        //wucgs_PaperReportB1.reportId = clsgs_PaperReportBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_PaperReportEN">数据传输的目的类对象</param>
   */
    public PutDataTogs_PaperReportClass(pobjgs_PaperReportEN: clsgs_PaperReportEN) {
        pobjgs_PaperReportEN.reportId = this.reportId;// 汇报Id
        pobjgs_PaperReportEN.updDate = this.updDate;// 修改日期
        pobjgs_PaperReportEN.paperId = this.paperId;// 论文Id
        pobjgs_PaperReportEN.reportContent = this.reportContent;// 汇报内容
        pobjgs_PaperReportEN.reportUser = this.reportUser;// 汇报用户
        pobjgs_PaperReportEN.reportDate = this.reportDate;// 汇报日期
        pobjgs_PaperReportEN.updUser = this.updUser;// 修改人
        pobjgs_PaperReportEN.pdFUrl = this.pdFUrl;// pdFUrl
        pobjgs_PaperReportEN.ppTUrl = this.ppTUrl;// ppTUrl
        pobjgs_PaperReportEN.memo = this.memo;// 备注
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objgs_PaperReportEN: clsgs_PaperReportEN = new clsgs_PaperReportEN();
        this.PutDataTogs_PaperReportClass(objgs_PaperReportEN);
        try {
            const responseText = await gs_PaperReport_IsExistAsync(objgs_PaperReportEN.reportId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objgs_PaperReportEN.reportId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await gs_PaperReport_AddNewRecordAsync(objgs_PaperReportEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //gs_PaperReport_ReFreshCache();
                var strInfo: string = `添加记录成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
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
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
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

    /* 函数功能:把以该关键字的记录内容显示在界面上,
          在这里是把值传到表控件中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
     <param name = "strReportId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strReportId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objgs_PaperReportEN: clsgs_PaperReportEN = new clsgs_PaperReportEN();
        try {
            const responseText = await gs_PaperReport_IsExistAsync(strReportId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strReportId}] 的记录不存在!`;
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
            }
        }
        catch (e) {
            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
            alert(strMsg);
        }
        try {
            const responseText = await gs_PaperReport_GetObjByReportIdAsync(strReportId);
            objgs_PaperReportEN = <clsgs_PaperReportEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_PaperReportClass(objgs_PaperReportEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjgs_PaperReportEN">表实体类对象</param>
   */
    public GetDataFromgs_PaperReportClass(pobjgs_PaperReportEN: clsgs_PaperReportEN) {
        this.reportId = pobjgs_PaperReportEN.reportId;// 汇报Id
        this.updDate = pobjgs_PaperReportEN.updDate;// 修改日期
        this.paperId = pobjgs_PaperReportEN.paperId;// 论文Id
        this.reportContent = pobjgs_PaperReportEN.reportContent;// 汇报内容
        this.reportUser = pobjgs_PaperReportEN.reportUser;// 汇报用户
        this.reportDate = pobjgs_PaperReportEN.reportDate;// 汇报日期
        this.updUser = pobjgs_PaperReportEN.updUser;// 修改人
        this.pdFUrl = pobjgs_PaperReportEN.pdFUrl;// pdFUrl
        this.ppTUrl = pobjgs_PaperReportEN.ppTUrl;// ppTUrl
        this.memo = pobjgs_PaperReportEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strReportId: string) {
        this.btnSubmit_gs_PaperReport = "确认修改";
        this.btnCancel_gs_PaperReport = "取消修改";
        this.KeyId = strReportId;
        try {
            const responseText = await gs_PaperReport_GetObjByReportIdAsync(strReportId);
            var objgs_PaperReportEN: clsgs_PaperReportEN = <clsgs_PaperReportEN>responseText;
            const conGetDataFromClass = await this.GetDataFromgs_PaperReportClass(objgs_PaperReportEN);
            console.log("完成UpdateRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
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
    /*
    * 设置取消按钮的标题(Used In AddNewRecord())
   */
    public set btnCancel_gs_PaperReport(value: string) {
        $("#btnCancel_gs_PaperReport").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnSubmit_gs_PaperReport(): string {
        return $("#btnSubmit_gs_PaperReport").html();
    }
    /*
    * 设置确定按钮的标题(Used In AddNewRecord())
   */
    public set btnSubmit_gs_PaperReport(value: string) {
        $("#btnSubmit_gs_PaperReport").html(value);
    }
    /*
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvgs_PaperReportBy(value: string) {
        $("#hidSortvgs_PaperReportBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_PaperReportBy(): string {
        return $("#hidSortvgs_PaperReportBy").val();
    }
    /*
    * 设置关键字的值(Used In UpdateRecord())
   */
    public set KeyId(value: string) {
        $("#hidKeyId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get KeyId(): string {
        return $("#hidKeyId").val();
    }
    /*
    * 备注 (Used In Clear())
   */
    public set memo(value: string) {
        $("#txtMemo").val(value);
    }
    /*
    * 备注 (Used In PutDataToClass())
   */
    public get memo(): string {
        return $("#txtMemo").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set OpType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public get OpType(): string {
        return $("#hidOpType").val();
    }
    /*
    * 论文Id (Used In Clear())
   */
    public set paperId(value: string) {
        $("#ddlPaperId").val(value);
    }
    /*
    * 论文Id (Used In PutDataToClass())
   */
    public get paperId(): string {
        return $("#ddlPaperId").val();
    }
    /*
    * pdFUrl (Used In Clear())
   */
    public set pdFUrl(value: string) {
        $("#txtPDFUrl").val(value);
    }
    /*
    * pdFUrl (Used In PutDataToClass())
   */
    public get pdFUrl(): string {
        return $("#txtPDFUrl").val();
    }
    /*
    * ppTUrl (Used In Clear())
   */
    public set ppTUrl(value: string) {
        $("#txtPPTUrl").val(value);
    }
    /*
    * ppTUrl (Used In PutDataToClass())
   */
    public get ppTUrl(): string {
        return $("#txtPPTUrl").val();
    }
    /*
    * 汇报内容 (Used In Clear())
   */
    public set reportContent(value: string) {
        $("#txtReportContent").val(value);
    }
    /*
    * 汇报内容 (Used In PutDataToClass())
   */
    public get reportContent(): string {
        return $("#txtReportContent").val();
    }
    /*
    * 汇报日期 (Used In Clear())
   */
    public set reportDate(value: string) {
        $("#txtReportDate").val(value);
    }
    /*
    * 汇报日期 (Used In PutDataToClass())
   */
    public get reportDate(): string {
        return $("#txtReportDate").val();
    }
    /*
    * 汇报Id (Used In Clear())
   */
    public set reportId(value: string) {
        $("#txtReportId").val(value);
    }
    /*
    * 汇报Id (Used In PutDataToClass())
   */
    public get reportId(): string {
        return $("#txtReportId").val();
    }
    /*
    * 汇报用户 (Used In Clear())
   */
    public set reportUser(value: string) {
        $("#txtReportUser").val(value);
    }
    /*
    * 汇报用户 (Used In PutDataToClass())
   */
    public get reportUser(): string {
        return $("#txtReportUser").val();
    }
    /*
    * 修改日期 (Used In Clear())
   */
    public set updDate(value: string) {
        $("#txtUpdDate").val(value);
    }
    /*
    * 修改日期 (Used In PutDataToClass())
   */
    public get updDate(): string {
        return $("#txtUpdDate").val();
    }
    /*
    * 修改人 (Used In Clear())
   */
    public set updUser(value: string) {
        $("#txtUpdUser").val(value);
    }
    /*
    * 修改人 (Used In PutDataToClass())
   */
    public get updUser(): string {
        return $("#txtUpdUser").val();
    }
}