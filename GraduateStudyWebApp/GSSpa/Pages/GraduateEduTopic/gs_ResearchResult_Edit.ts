
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_ResearchResult_Edit
表名:gs_ResearchResult(01120780)
生成代码版本:2020.12.17.1
生成日期:2020/12/22 22:16:13
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
import { clsgs_ResearchResultEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchResultEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsvgs_ResearchResultEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchResultEN.js";
import { gs_ResearchResult_AddNewRecordAsync, gs_ResearchResult_AddNewRecordWithMaxIdAsync, gs_ResearchResult_CheckProperty4Update, gs_ResearchResult_CheckPropertyNew, gs_ResearchResult_GetObjByResultIdAsync, gs_ResearchResult_IsExistAsync, gs_ResearchResult_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultWApi.js";
import { PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_ResearchResult(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_ResearchResult(): void;
declare var $;
declare var window;
/* gs_ResearchResult_Edit 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
*/
export abstract class gs_ResearchResult_Edit {
    public static objPage_Edit: gs_ResearchResult_Edit;
    protected iShowList: IShowList;
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divResearchResultEdit";  //编辑区的Id
    constructor(objShowList: IShowList) {
        this.iShowList = objShowList;
        gs_ResearchResult_Edit.objPage_Edit = this;
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
        var strUrl: string = "./gs_ResearchResult_Edit/";
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
                ShowDialog_gs_ResearchResult('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog_gs_ResearchResult('Add');
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
        //const ddlTopicId = await this.SetDdl_TopicId(strid_CurrEduCls);//编辑区域
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
                ShowDialog_gs_ResearchResult('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecordWithMaxId();
            }
            else {
                ShowDialog_gs_ResearchResult('Add');
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
        const ddlPaperId = await PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache(this.divName4Edit,
            "ddlPaperId", strid_CurrEduCls);//编辑区域
    }

    /// <summary>
    /// 设置绑定下拉框，针对字段:[topicId]
    /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
    /// </summary>
    public async SetDdl_TopicId(strid_CurrEduCls: string) {
        var objResearchTopic_Cond: clsResearchTopicEN = new clsResearchTopicEN();//编辑区域
        //定义条件字段
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
            ShowDialog_gs_ResearchResult('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_ResearchResult('Update');
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
            ShowDialog_gs_ResearchResult('Update');
            this.bolIsLoadEditRegion = true;  //
            const update = await this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_ResearchResult('Update');
            const update = await this.UpdateRecord(strKeyId);
        }
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_ResearchResult;
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
                                HideDialog_gs_ResearchResult();
                                this.iShowList.BindGv(clsvgs_ResearchResultEN._CurrTabName, "");
                            }
                        });
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog_gs_ResearchResult();
                                this.iShowList.BindGv(clsvgs_ResearchResultEN._CurrTabName, "");
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In gs_ResearchResult_Edit.btnSubmit_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog_gs_ResearchResult();
                            this.iShowList.BindGv(clsvgs_ResearchResultEN._CurrTabName, "");
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
        $('#txtResultId').prop['ReadOnly'] = bolReadonly;
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.resultId = "";
        $('#ddlPaperId option[0]').attr("selected", true);
        $('#ddlTopicId option[0]').attr("selected", true);
        this.resultTypeId = "";
        this.resultName = "";
        this.resultContent = "";
        this.author = "";
        this.division = "";
        this.updDate = "";
        this.updUser = "";
        this.memo = "";
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_gs_ResearchResult = "确认添加";
        this.btnCancel_gs_ResearchResult = "取消添加";
        this.Clear();
        //wucgs_ResearchResultB1.resultId = clsgs_ResearchResultBL.GetMaxStrId_S();
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_gs_ResearchResult = "确认添加";
        this.btnCancel_gs_ResearchResult = "取消添加";
        this.Clear();
        //wucgs_ResearchResultB1.resultId = clsgs_ResearchResultBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_ResearchResultEN">数据传输的目的类对象</param>
   */
    public PutDataTogs_ResearchResultClass(pobjgs_ResearchResultEN: clsgs_ResearchResultEN) {
        pobjgs_ResearchResultEN.resultId = this.resultId;// 成果Id
        pobjgs_ResearchResultEN.paperId = this.paperId;// 论文Id
        pobjgs_ResearchResultEN.topicId = this.topicId;// 主题编号
        pobjgs_ResearchResultEN.resultTypeId = this.resultTypeId;// 成果类型Id
        pobjgs_ResearchResultEN.resultName = this.resultName;// 成果名称
        pobjgs_ResearchResultEN.resultContent = this.resultContent;// 成果内容
        pobjgs_ResearchResultEN.author = this.author;// 作者
        pobjgs_ResearchResultEN.division = this.division;// 分工
        pobjgs_ResearchResultEN.updDate = this.updDate;// 修改日期
        pobjgs_ResearchResultEN.updUser = this.updUser;// 修改人
        pobjgs_ResearchResultEN.memo = this.memo;// 备注
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objgs_ResearchResultEN: clsgs_ResearchResultEN = new clsgs_ResearchResultEN();
        this.PutDataTogs_ResearchResultClass(objgs_ResearchResultEN);
        try {
            gs_ResearchResult_CheckPropertyNew(objgs_ResearchResultEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseText = await gs_ResearchResult_IsExistAsync(objgs_ResearchResultEN.resultId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objgs_ResearchResultEN.resultId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await gs_ResearchResult_AddNewRecordAsync(objgs_ResearchResultEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //gs_ResearchResult_ReFreshCache();
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
        var objgs_ResearchResultEN: clsgs_ResearchResultEN = new clsgs_ResearchResultEN();
        this.PutDataTogs_ResearchResultClass(objgs_ResearchResultEN);
        try {
            gs_ResearchResult_CheckPropertyNew(objgs_ResearchResultEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseKeyId = await gs_ResearchResult_AddNewRecordWithMaxIdAsync(objgs_ResearchResultEN);
            var returnKeyId: string = responseKeyId;
            if (clsString.IsNullOrEmpty(returnKeyId) == false) {
                //gs_ResearchResult_ReFreshCache();
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
     <param name = "strResultId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strResultId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objgs_ResearchResultEN: clsgs_ResearchResultEN = new clsgs_ResearchResultEN();
        try {
            const responseText = await gs_ResearchResult_IsExistAsync(strResultId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strResultId}] 的记录不存在!`;
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
            const responseText = await gs_ResearchResult_GetObjByResultIdAsync(strResultId);
            objgs_ResearchResultEN = <clsgs_ResearchResultEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_ResearchResultClass(objgs_ResearchResultEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjgs_ResearchResultEN">表实体类对象</param>
   */
    public GetDataFromgs_ResearchResultClass(pobjgs_ResearchResultEN: clsgs_ResearchResultEN) {
        this.resultId = pobjgs_ResearchResultEN.resultId;// 成果Id
        this.paperId = pobjgs_ResearchResultEN.paperId;// 论文Id
        this.topicId = pobjgs_ResearchResultEN.topicId;// 主题编号
        this.resultTypeId = pobjgs_ResearchResultEN.resultTypeId;// 成果类型Id
        this.resultName = pobjgs_ResearchResultEN.resultName;// 成果名称
        this.resultContent = pobjgs_ResearchResultEN.resultContent;// 成果内容
        this.author = pobjgs_ResearchResultEN.author;// 作者
        this.division = pobjgs_ResearchResultEN.division;// 分工
        this.updDate = pobjgs_ResearchResultEN.updDate;// 修改日期
        this.updUser = pobjgs_ResearchResultEN.updUser;// 修改人
        this.memo = pobjgs_ResearchResultEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strResultId: string) {
        this.btnSubmit_gs_ResearchResult = "确认修改";
        this.btnCancel_gs_ResearchResult = "取消修改";
        this.KeyId = strResultId;
        try {
            const responseText = await gs_ResearchResult_GetObjByResultIdAsync(strResultId);
            var objgs_ResearchResultEN: clsgs_ResearchResultEN = <clsgs_ResearchResultEN>responseText;
            const conGetDataFromClass = await this.GetDataFromgs_ResearchResultClass(objgs_ResearchResultEN);
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
        var objgs_ResearchResultEN: clsgs_ResearchResultEN = new clsgs_ResearchResultEN();
        objgs_ResearchResultEN.resultId = this.KeyId;
        this.PutDataTogs_ResearchResultClass(objgs_ResearchResultEN);
        objgs_ResearchResultEN.sf_UpdFldSetStr = objgs_ResearchResultEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_ResearchResultEN.resultId == "" || objgs_ResearchResultEN.resultId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            gs_ResearchResult_CheckProperty4Update(objgs_ResearchResultEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseText = await gs_ResearchResult_UpdateRecordAsync(objgs_ResearchResultEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //gs_ResearchResult_ReFreshCache();
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
    * 作者 (Used In Clear())
   */
    public set author(value: string) {
        $("#txtAuthor").val(value);
    }
    /*
    * 作者 (Used In PutDataToClass())
   */
    public get author(): string {
        return $("#txtAuthor").val();
    }
    /*
    * 设置取消按钮的标题(Used In AddNewRecord())
   */
    public set btnCancel_gs_ResearchResult(value: string) {
        $("#btnCancel_gs_ResearchResult").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnSubmit_gs_ResearchResult(): string {
        return $("#btnSubmit_gs_ResearchResult").html();
    }
    /*
    * 设置确定按钮的标题(Used In AddNewRecord())
   */
    public set btnSubmit_gs_ResearchResult(value: string) {
        $("#btnSubmit_gs_ResearchResult").html(value);
    }
    /*
    * 分工 (Used In Clear())
   */
    public set division(value: string) {
        $("#txtDivision").val(value);
    }
    /*
    * 分工 (Used In PutDataToClass())
   */
    public get division(): string {
        return $("#txtDivision").val();
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
    public set hidSortvgs_ResearchResultBy(value: string) {
        $("#hidSortvgs_ResearchResultBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_ResearchResultBy(): string {
        return $("#hidSortvgs_ResearchResultBy").val();
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
        if ($("#ddlPaperId").val() == "0") return "";
        return $("#ddlPaperId").val();
    }
    /*
    * 成果内容 (Used In Clear())
   */
    public set resultContent(value: string) {
        $("#txtResultContent").val(value);
    }
    /*
    * 成果内容 (Used In PutDataToClass())
   */
    public get resultContent(): string {
        return $("#txtResultContent").val();
    }
    /*
    * 成果Id (Used In Clear())
   */
    public set resultId(value: string) {
        $("#txtResultId").val(value);
    }
    /*
    * 成果Id (Used In PutDataToClass())
   */
    public get resultId(): string {
        return $("#txtResultId").val();
    }
    /*
    * 成果名称 (Used In Clear())
   */
    public set resultName(value: string) {
        $("#txtResultName").val(value);
    }
    /*
    * 成果名称 (Used In PutDataToClass())
   */
    public get resultName(): string {
        return $("#txtResultName").val();
    }
    /*
    * 成果类型Id (Used In Clear())
   */
    public set resultTypeId(value: string) {
        $("#txtResultTypeId").val(value);
    }
    /*
    * 成果类型Id (Used In PutDataToClass())
   */
    public get resultTypeId(): string {
        return $("#txtResultTypeId").val();
    }
    /*
    * 主题编号 (Used In Clear())
   */
    public set topicId(value: string) {
        $("#ddlTopicId").val(value);
    }
    /*
    * 主题编号 (Used In PutDataToClass())
   */
    public get topicId(): string {
        if ($("#ddlTopicId").val() == "0") return "";
        return $("#ddlTopicId").val();
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