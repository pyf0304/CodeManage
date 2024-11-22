
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_KnowledgesGraph_Edit
表名:gs_KnowledgesGraph(01120873)
生成代码版本:2021.01.27.2
生成日期:2021/01/27 23:31:21
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关
模块英文名:Knowledges
框架-层名:WA_编辑区后台_TS(WA_ViewScript_EditCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clscc_CourseEN } from "../TS/L0_Entity/CourseLearning/clscc_CourseEN.js";
import { clsgs_KnowledgesGraphEN } from "../TS/L0_Entity/Knowledges/clsgs_KnowledgesGraphEN.js";
import { cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache } from "../TS/L3_ForWApi/CourseLearning/clscc_CourseTypeWApi.js";
import { gs_KnowledgesGraph_AddNewRecordAsync, gs_KnowledgesGraph_AddNewRecordWithMaxIdAsync, gs_KnowledgesGraph_CheckProperty4Update, gs_KnowledgesGraph_CheckPropertyNew, gs_KnowledgesGraph_GetMaxStrIdAsync, gs_KnowledgesGraph_GetObjByKnowledgeGraphIdAsync, gs_KnowledgesGraph_IsExistAsync, gs_KnowledgesGraph_UpdateRecordAsync } from "../TS/L3_ForWApi/Knowledges/clsgs_KnowledgesGraphWApi.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_KnowledgesGraph(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_KnowledgesGraph(): void;
declare var $;
declare var window;
/* gs_KnowledgesGraph_Edit 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
*/
export abstract class gs_KnowledgesGraph_Edit {
    public static objPage_Edit: gs_KnowledgesGraph_Edit;
    protected iShowList: IShowList;
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divEdit";  //编辑区的Id
    constructor(objShowList: IShowList) {
        this.iShowList = objShowList;
        gs_KnowledgesGraph_Edit.objPage_Edit = this;
    }


    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        var strUrl: string = "./gs_KnowledgesGraph_Edit/";
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
                ShowDialog_gs_KnowledgesGraph('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog_gs_KnowledgesGraph('Add');
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
        const ddlCourseId = await this.SetDdl_CourseId();//编辑区域
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
                ShowDialog_gs_KnowledgesGraph('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecordWithMaxId();
            }
            else {
                ShowDialog_gs_KnowledgesGraph('Add');
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
    /// 设置绑定下拉框，针对字段:[courseId]
    /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
    /// </summary>
    public async SetDdl_CourseId() {
        var objcc_Course_Cond: clscc_CourseEN = new clscc_CourseEN();//编辑区域
        const ddlCourseId = await cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache(this.divName4Edit, "ddlCourseId");//编辑区域
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
            ShowDialog_gs_KnowledgesGraph('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_KnowledgesGraph('Update');
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
            ShowDialog_gs_KnowledgesGraph('Update');
            this.bolIsLoadEditRegion = true;  //
            const update = await this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_KnowledgesGraph('Update');
            const update = await this.UpdateRecord(strKeyId);
        }
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_KnowledgesGraph;
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
                                HideDialog_gs_KnowledgesGraph();
                                this.iShowList.BindGv(clsgs_KnowledgesGraphEN._CurrTabName, "");
                            }
                        });
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog_gs_KnowledgesGraph();
                                this.iShowList.BindGv(clsgs_KnowledgesGraphEN._CurrTabName, "");
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In gs_KnowledgesGraph_Edit.btnSubmit_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog_gs_KnowledgesGraph();
                            this.iShowList.BindGv(clsgs_KnowledgesGraphEN._CurrTabName, "");
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
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.knowledgeGraphName = "";
        $('#ddlCourseId option[0]').attr("selected", true);
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        this.btnSubmit_gs_KnowledgesGraph = "确认添加";
        this.btnCancel_gs_KnowledgesGraph = "取消添加";
        this.Clear();
        //wucgs_KnowledgesGraphB1.knowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
        try {
            const responseText = await gs_KnowledgesGraph_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表gs_KnowledgesGraph的最大关键字为空，不成功，请检查!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                $('#txtKnowledgeGraphId').val(returnString);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.btnSubmit_gs_KnowledgesGraph = "确认添加";
        this.btnCancel_gs_KnowledgesGraph = "取消添加";
        this.Clear();
        //wucgs_KnowledgesGraphB1.knowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_KnowledgesGraphEN">数据传输的目的类对象</param>
   */
    public PutDataTogs_KnowledgesGraphClass(pobjgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN) {
        pobjgs_KnowledgesGraphEN.knowledgeGraphName = this.knowledgeGraphName;// 知识点图名
        pobjgs_KnowledgesGraphEN.courseId = this.courseId;// 课程Id
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
        this.PutDataTogs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
        try {
            gs_KnowledgesGraph_CheckPropertyNew(objgs_KnowledgesGraphEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseText = await gs_KnowledgesGraph_IsExistAsync(objgs_KnowledgesGraphEN.knowledgeGraphId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objgs_KnowledgesGraphEN.knowledgeGraphId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await gs_KnowledgesGraph_AddNewRecordAsync(objgs_KnowledgesGraphEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                console.error("由于该页面没有设置使用缓存列表，所以没有刷新缓存！请在生成代码平台中为该页面中设置使用缓存列表。");//gs_KnowledgesGraph_ReFreshCache();
                //gs_KnowledgesGraph_ReFreshCache();
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
        var objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
        this.PutDataTogs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
        try {
            gs_KnowledgesGraph_CheckPropertyNew(objgs_KnowledgesGraphEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseKeyId = await gs_KnowledgesGraph_AddNewRecordWithMaxIdAsync(objgs_KnowledgesGraphEN);
            var returnKeyId: string = responseKeyId;
            if (clsString.IsNullOrEmpty(returnKeyId) == false) {
                console.error("由于该页面没有设置使用缓存列表，所以没有刷新缓存！请在生成代码平台中为该页面中设置使用缓存列表。");//gs_KnowledgesGraph_ReFreshCache();
                //gs_KnowledgesGraph_ReFreshCache();
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
     <param name = "strKnowledgeGraphId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strKnowledgeGraphId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
        try {
            const responseText = await gs_KnowledgesGraph_IsExistAsync(strKnowledgeGraphId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strKnowledgeGraphId}] 的记录不存在!`;
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
            const responseText = await gs_KnowledgesGraph_GetObjByKnowledgeGraphIdAsync(strKnowledgeGraphId);
            objgs_KnowledgesGraphEN = <clsgs_KnowledgesGraphEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjgs_KnowledgesGraphEN">表实体类对象</param>
   */
    public GetDataFromgs_KnowledgesGraphClass(pobjgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN) {
        this.knowledgeGraphName = pobjgs_KnowledgesGraphEN.knowledgeGraphName;// 知识点图名
        this.courseId = pobjgs_KnowledgesGraphEN.courseId;// 课程Id
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strKnowledgeGraphId: string) {
        this.btnSubmit_gs_KnowledgesGraph = "确认修改";
        this.btnCancel_gs_KnowledgesGraph = "取消修改";
        this.KeyId = strKnowledgeGraphId;
        try {
            const responseText = await gs_KnowledgesGraph_GetObjByKnowledgeGraphIdAsync(strKnowledgeGraphId);
            var objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN = <clsgs_KnowledgesGraphEN>responseText;
            const conGetDataFromClass = await this.GetDataFromgs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
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
        var objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
        objgs_KnowledgesGraphEN.knowledgeGraphId = this.KeyId;
        this.PutDataTogs_KnowledgesGraphClass(objgs_KnowledgesGraphEN);
        objgs_KnowledgesGraphEN.sf_UpdFldSetStr = objgs_KnowledgesGraphEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_KnowledgesGraphEN.knowledgeGraphId == "" || objgs_KnowledgesGraphEN.knowledgeGraphId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            gs_KnowledgesGraph_CheckProperty4Update(objgs_KnowledgesGraphEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseText = await gs_KnowledgesGraph_UpdateRecordAsync(objgs_KnowledgesGraphEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                console.error("由于该页面没有设置使用缓存列表，所以没有刷新缓存！请在生成代码平台中为该页面中设置使用缓存列表。");//gs_KnowledgesGraph_ReFreshCache();
                //gs_KnowledgesGraph_ReFreshCache();
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
    public set btnCancel_gs_KnowledgesGraph(value: string) {
        $("#btnCancel_gs_KnowledgesGraph").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnSubmit_gs_KnowledgesGraph(): string {
        return $("#btnSubmit_gs_KnowledgesGraph").html();
    }
    /*
    * 设置确定按钮的标题(Used In AddNewRecord())
   */
    public set btnSubmit_gs_KnowledgesGraph(value: string) {
        $("#btnSubmit_gs_KnowledgesGraph").html(value);
    }
    /*
    * 课程Id (Used In Clear())
   */
    public set courseId(value: string) {
        $("#ddlCourseId").val(value);
    }
    /*
    * 课程Id (Used In PutDataToClass())
   */
    public get courseId(): string {
        if ($("#ddlCourseId").val() == "0") return "";
        return $("#ddlCourseId").val();
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
    public set hidSortgs_KnowledgesGraphBy(value: string) {
        $("#hidSortgs_KnowledgesGraphBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortgs_KnowledgesGraphBy(): string {
        return $("#hidSortgs_KnowledgesGraphBy").val();
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
    * 知识点图名 (Used In Clear())
   */
    public set knowledgeGraphName(value: string) {
        $("#txtKnowledgeGraphName").val(value);
    }
    /*
    * 知识点图名 (Used In PutDataToClass())
   */
    public get knowledgeGraphName(): string {
        return $("#txtKnowledgeGraphName").val();
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
}