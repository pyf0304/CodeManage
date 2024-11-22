
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TobeStudiedProblem_Edit
表名:gs_TobeStudiedProblem(01120776)
生成代码版本:2020.12.12.1
生成日期:2020/12/15 21:32:14
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
import { clsgs_TobeStudiedProblemEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js";
import { clsvgs_TobeStudiedProblemEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_TobeStudiedProblemEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { gs_TobeStudiedProblem_AddNewRecordAsync, gs_TobeStudiedProblem_AddNewRecordWithMaxIdAsync, gs_TobeStudiedProblem_CheckProperty4Update, gs_TobeStudiedProblem_CheckPropertyNew, gs_TobeStudiedProblem_GetObjByProblemIdAsync, gs_TobeStudiedProblem_IsExistAsync, gs_TobeStudiedProblem_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemWApi.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_TobeStudiedProblem(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_TobeStudiedProblem(): void;
declare var $;
declare var window;
/* gs_TobeStudiedProblem_Edit 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
*/
export abstract class gs_TobeStudiedProblem_Edit {
    public static objPage_Edit: gs_TobeStudiedProblem_Edit;
    protected iShowList: IShowList;
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divTobeStudiedProblemEdit";  //编辑区的Id
    constructor(objShowList: IShowList) {
        this.iShowList = objShowList;
        gs_TobeStudiedProblem_Edit.objPage_Edit = this;
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
        var strUrl: string = "./gs_TobeStudiedProblem_Edit/";
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
                ShowDialog_gs_TobeStudiedProblem('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog_gs_TobeStudiedProblem('Add');
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
        const ddlTopicId = await this.SetDdl_TopicId(strid_CurrEduCls);//编辑区域
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
                ShowDialog_gs_TobeStudiedProblem('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecordWithMaxId();
            }
            else {
                ShowDialog_gs_TobeStudiedProblem('Add');
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
            ShowDialog_gs_TobeStudiedProblem('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_TobeStudiedProblem('Update');
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
            ShowDialog_gs_TobeStudiedProblem('Update');
            this.bolIsLoadEditRegion = true;  //
            const update = await this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_TobeStudiedProblem('Update');
            const update = await this.UpdateRecord(strKeyId);
        }
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_TobeStudiedProblem;
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
                                HideDialog_gs_TobeStudiedProblem();
                                this.iShowList.BindGv(clsvgs_TobeStudiedProblemEN._CurrTabName, "");
                            }
                        });
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog_gs_TobeStudiedProblem();
                                this.iShowList.BindGv(clsvgs_TobeStudiedProblemEN._CurrTabName, "");
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In gs_TobeStudiedProblem_Edit.btnSubmit_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog_gs_TobeStudiedProblem();
                            this.iShowList.BindGv(clsvgs_TobeStudiedProblemEN._CurrTabName, "");
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
        $('#txtProblemId').prop['ReadOnly'] = bolReadonly;
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.problemId = "";
        this.problemTitle = "";
        this.problemContent = "";
        $('#ddlTopicId option[0]').attr("selected", true);
        this.isSubmit = false;
        this.problemDate = "";
        this.updDate = "";
        this.updUser = "";
        this.year = "";
        this.month = "";
        this.versionCount = 0;
        this.participant = "";
        this.memo = "";
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_gs_TobeStudiedProblem = "确认添加";
        this.btnCancel_gs_TobeStudiedProblem = "取消添加";
        this.Clear();
        //wucgs_TobeStudiedProblemB1.problemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_gs_TobeStudiedProblem = "确认添加";
        this.btnCancel_gs_TobeStudiedProblem = "取消添加";
        this.Clear();
        //wucgs_TobeStudiedProblemB1.problemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_TobeStudiedProblemEN">数据传输的目的类对象</param>
   */
    public PutDataTogs_TobeStudiedProblemClass(pobjgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN) {
        pobjgs_TobeStudiedProblemEN.problemId = this.problemId;// 问题Id
        pobjgs_TobeStudiedProblemEN.problemTitle = this.problemTitle;// 问题标题
        pobjgs_TobeStudiedProblemEN.problemContent = this.problemContent;// 问题内容
        pobjgs_TobeStudiedProblemEN.topicId = this.topicId;// 主题编号
        pobjgs_TobeStudiedProblemEN.isSubmit = this.isSubmit;// 是否提交
        pobjgs_TobeStudiedProblemEN.problemDate = this.problemDate;// 问题日期
        pobjgs_TobeStudiedProblemEN.updDate = this.updDate;// 修改日期
        pobjgs_TobeStudiedProblemEN.updUser = this.updUser;// 修改人
        pobjgs_TobeStudiedProblemEN.year = this.year;// 年
        pobjgs_TobeStudiedProblemEN.month = this.month;// 月
        pobjgs_TobeStudiedProblemEN.versionCount = this.versionCount;// 版本统计
        pobjgs_TobeStudiedProblemEN.participant = this.participant;// 参与者
        pobjgs_TobeStudiedProblemEN.memo = this.memo;// 备注
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
        this.PutDataTogs_TobeStudiedProblemClass(objgs_TobeStudiedProblemEN);
        try {
            gs_TobeStudiedProblem_CheckPropertyNew(objgs_TobeStudiedProblemEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseText = await gs_TobeStudiedProblem_IsExistAsync(objgs_TobeStudiedProblemEN.problemId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objgs_TobeStudiedProblemEN.problemId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await gs_TobeStudiedProblem_AddNewRecordAsync(objgs_TobeStudiedProblemEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //gs_TobeStudiedProblem_ReFreshCache();
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
        var objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
        this.PutDataTogs_TobeStudiedProblemClass(objgs_TobeStudiedProblemEN);
        try {
            gs_TobeStudiedProblem_CheckPropertyNew(objgs_TobeStudiedProblemEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseKeyId = await gs_TobeStudiedProblem_AddNewRecordWithMaxIdAsync(objgs_TobeStudiedProblemEN);
            var returnKeyId: string = responseKeyId;
            if (clsString.IsNullOrEmpty(returnKeyId) == false) {
                //gs_TobeStudiedProblem_ReFreshCache();
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
     <param name = "strProblemId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strProblemId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
        try {
            const responseText = await gs_TobeStudiedProblem_IsExistAsync(strProblemId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strProblemId}] 的记录不存在!`;
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
            const responseText = await gs_TobeStudiedProblem_GetObjByProblemIdAsync(strProblemId);
            objgs_TobeStudiedProblemEN = <clsgs_TobeStudiedProblemEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_TobeStudiedProblemClass(objgs_TobeStudiedProblemEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjgs_TobeStudiedProblemEN">表实体类对象</param>
   */
    public GetDataFromgs_TobeStudiedProblemClass(pobjgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN) {
        this.problemId = pobjgs_TobeStudiedProblemEN.problemId;// 问题Id
        this.problemTitle = pobjgs_TobeStudiedProblemEN.problemTitle;// 问题标题
        this.problemContent = pobjgs_TobeStudiedProblemEN.problemContent;// 问题内容
        this.topicId = pobjgs_TobeStudiedProblemEN.topicId;// 主题编号
        this.isSubmit = pobjgs_TobeStudiedProblemEN.isSubmit;// 是否提交
        this.problemDate = pobjgs_TobeStudiedProblemEN.problemDate;// 问题日期
        this.updDate = pobjgs_TobeStudiedProblemEN.updDate;// 修改日期
        this.updUser = pobjgs_TobeStudiedProblemEN.updUser;// 修改人
        this.year = pobjgs_TobeStudiedProblemEN.year;// 年
        this.month = pobjgs_TobeStudiedProblemEN.month;// 月
        this.versionCount = pobjgs_TobeStudiedProblemEN.versionCount;// 版本统计
        this.participant = pobjgs_TobeStudiedProblemEN.participant;// 参与者
        this.memo = pobjgs_TobeStudiedProblemEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strProblemId: string) {
        this.btnSubmit_gs_TobeStudiedProblem = "确认修改";
        this.btnCancel_gs_TobeStudiedProblem = "取消修改";
        this.KeyId = strProblemId;
        try {
            const responseText = await gs_TobeStudiedProblem_GetObjByProblemIdAsync(strProblemId);
            var objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN = <clsgs_TobeStudiedProblemEN>responseText;
            const conGetDataFromClass = await this.GetDataFromgs_TobeStudiedProblemClass(objgs_TobeStudiedProblemEN);
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
        var objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
        objgs_TobeStudiedProblemEN.problemId = this.KeyId;
        this.PutDataTogs_TobeStudiedProblemClass(objgs_TobeStudiedProblemEN);
        objgs_TobeStudiedProblemEN.sf_UpdFldSetStr = objgs_TobeStudiedProblemEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_TobeStudiedProblemEN.problemId == "" || objgs_TobeStudiedProblemEN.problemId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            gs_TobeStudiedProblem_CheckProperty4Update(objgs_TobeStudiedProblemEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseText = await gs_TobeStudiedProblem_UpdateRecordAsync(objgs_TobeStudiedProblemEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //gs_TobeStudiedProblem_ReFreshCache();
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
    public set btnCancel_gs_TobeStudiedProblem(value: string) {
        $("#btnCancel_gs_TobeStudiedProblem").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnSubmit_gs_TobeStudiedProblem(): string {
        return $("#btnSubmit_gs_TobeStudiedProblem").html();
    }
    /*
    * 设置确定按钮的标题(Used In AddNewRecord())
   */
    public set btnSubmit_gs_TobeStudiedProblem(value: string) {
        $("#btnSubmit_gs_TobeStudiedProblem").html(value);
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
    public set hidSortvgs_TobeStudiedProblemBy(value: string) {
        $("#hidSortvgs_TobeStudiedProblemBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_TobeStudiedProblemBy(): string {
        return $("#hidSortvgs_TobeStudiedProblemBy").val();
    }
    /*
    * 是否提交 (Used In Clear())
   */
    public set isSubmit(value: boolean) {
        $("#chkIsSubmit").attr("checked", value);
    }
    /*
    * 是否提交 (Used In PutDataToClass())
   */
    public get isSubmit(): boolean {
        return $("#chkIsSubmit").prop("checked");
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
    * 月 (Used In Clear())
   */
    public set month(value: string) {
        $("#txtMonth").val(value);
    }
    /*
    * 月 (Used In PutDataToClass())
   */
    public get month(): string {
        return $("#txtMonth").val();
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
    * 参与者 (Used In Clear())
   */
    public set participant(value: string) {
        $("#txtParticipant").val(value);
    }
    /*
    * 参与者 (Used In PutDataToClass())
   */
    public get participant(): string {
        return $("#txtParticipant").val();
    }
    /*
    * 问题内容 (Used In Clear())
   */
    public set problemContent(value: string) {
        $("#txtProblemContent").val(value);
    }
    /*
    * 问题内容 (Used In PutDataToClass())
   */
    public get problemContent(): string {
        return $("#txtProblemContent").val();
    }
    /*
    * 问题日期 (Used In Clear())
   */
    public set problemDate(value: string) {
        $("#txtProblemDate").val(value);
    }
    /*
    * 问题日期 (Used In PutDataToClass())
   */
    public get problemDate(): string {
        return $("#txtProblemDate").val();
    }
    /*
    * 问题Id (Used In Clear())
   */
    public set problemId(value: string) {
        $("#txtProblemId").val(value);
    }
    /*
    * 问题Id (Used In PutDataToClass())
   */
    public get problemId(): string {
        return $("#txtProblemId").val();
    }
    /*
    * 问题标题 (Used In Clear())
   */
    public set problemTitle(value: string) {
        $("#txtProblemTitle").val(value);
    }
    /*
    * 问题标题 (Used In PutDataToClass())
   */
    public get problemTitle(): string {
        return $("#txtProblemTitle").val();
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
    /*
    * 版本统计 (Used In Clear())
   */
    public set versionCount(value: number) {
        $("#txtVersionCount").val(value);
    }
    /*
    * 版本统计 (Used In PutDataToClass())
   */
    public get versionCount(): number {
        var strVersionCount = $("#txtVersionCount").val();
        if (clsString.IsNullOrEmpty(strVersionCount)) return 0;
        return Number(strVersionCount);
    }
    /*
    * 年 (Used In Clear())
   */
    public set year(value: string) {
        $("#txtYear").val(value);
    }
    /*
    * 年 (Used In PutDataToClass())
   */
    public get year(): string {
        return $("#txtYear").val();
    }
}