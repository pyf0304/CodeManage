
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TopicRole_Edit
表名:gs_TopicRole(01120869)
生成代码版本:2021.01.08.1
生成日期:2021/01/08 01:06:01
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
import { clsgs_TopicRoleEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_TopicRoleEN.js";
import { gs_TopicRole_AddNewRecordAsync, gs_TopicRole_AddNewRecordWithMaxIdAsync, gs_TopicRole_CheckProperty4Update, gs_TopicRole_CheckPropertyNew, gs_TopicRole_GetMaxStrIdAsync, gs_TopicRole_GetObjByTopicRoleIdAsync, gs_TopicRole_IsExistAsync, gs_TopicRole_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_TopicRole(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_TopicRole(): void;
declare var $;
declare var window;
/* gs_TopicRole_Edit 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
*/
export abstract class gs_TopicRole_Edit {
    public static objPage_Edit: gs_TopicRole_Edit;
    protected iShowList: IShowList;
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divEdit";  //编辑区的Id
    constructor(objShowList: IShowList) {
        this.iShowList = objShowList;
        gs_TopicRole_Edit.objPage_Edit = this;
    }


    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        var strUrl: string = "./gs_TopicRole_Edit/";
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
                ShowDialog_gs_TopicRole('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog_gs_TopicRole('Add');
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
                ShowDialog_gs_TopicRole('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecordWithMaxId();
            }
            else {
                ShowDialog_gs_TopicRole('Add');
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
            ShowDialog_gs_TopicRole('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_TopicRole('Update');
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
            ShowDialog_gs_TopicRole('Update');
            this.bolIsLoadEditRegion = true;  //
            const update = await this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog_gs_TopicRole('Update');
            const update = await this.UpdateRecord(strKeyId);
        }
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_TopicRole;
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
                                HideDialog_gs_TopicRole();
                                this.iShowList.BindGv(clsgs_TopicRoleEN._CurrTabName, "");
                            }
                        });
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog_gs_TopicRole();
                                this.iShowList.BindGv(clsgs_TopicRoleEN._CurrTabName, "");
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In gs_TopicRole_Edit.btnSubmit_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog_gs_TopicRole();
                            this.iShowList.BindGv(clsgs_TopicRoleEN._CurrTabName, "");
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
        $('#txtTopicRoleId').prop['ReadOnly'] = bolReadonly;
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.topicRoleId = "";
        this.topicId = "";
        this.menuNum = "";
        this.menuName = "";
        this.menuIsHide = false;
        this.updDate = "";
        this.updUser = "";
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        this.btnSubmit_gs_TopicRole = "确认添加";
        this.btnCancel_gs_TopicRole = "取消添加";
        this.Clear();
        //wucgs_TopicRoleB1.topicRoleId = clsgs_TopicRoleBL.GetMaxStrId_S();
        try {
            const responseText = await gs_TopicRole_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表gs_TopicRole的最大关键字为空，不成功，请检查!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                $('#txtTopicRoleId').val(returnString);
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
        this.btnSubmit_gs_TopicRole = "确认添加";
        this.btnCancel_gs_TopicRole = "取消添加";
        this.Clear();
        //wucgs_TopicRoleB1.topicRoleId = clsgs_TopicRoleBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_TopicRoleEN">数据传输的目的类对象</param>
   */
    public PutDataTogs_TopicRoleClass(pobjgs_TopicRoleEN: clsgs_TopicRoleEN) {
        pobjgs_TopicRoleEN.topicRoleId = this.topicRoleId;// 主题权限Id
        pobjgs_TopicRoleEN.topicId = this.topicId;// 主题编号
        pobjgs_TopicRoleEN.menuNum = this.menuNum;// 菜单编号
        pobjgs_TopicRoleEN.menuName = this.menuName;// 菜单名称
        pobjgs_TopicRoleEN.menuIsHide = this.menuIsHide;// 菜单是否隐藏
        pobjgs_TopicRoleEN.updDate = this.updDate;// 修改日期
        pobjgs_TopicRoleEN.updUser = this.updUser;// 修改人
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objgs_TopicRoleEN: clsgs_TopicRoleEN = new clsgs_TopicRoleEN();
        this.PutDataTogs_TopicRoleClass(objgs_TopicRoleEN);
        try {
            gs_TopicRole_CheckPropertyNew(objgs_TopicRoleEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseText = await gs_TopicRole_IsExistAsync(objgs_TopicRoleEN.topicRoleId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objgs_TopicRoleEN.topicRoleId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await gs_TopicRole_AddNewRecordAsync(objgs_TopicRoleEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //gs_TopicRole_ReFreshCache();
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
        var objgs_TopicRoleEN: clsgs_TopicRoleEN = new clsgs_TopicRoleEN();
        this.PutDataTogs_TopicRoleClass(objgs_TopicRoleEN);
        try {
            gs_TopicRole_CheckPropertyNew(objgs_TopicRoleEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseKeyId = await gs_TopicRole_AddNewRecordWithMaxIdAsync(objgs_TopicRoleEN);
            var returnKeyId: string = responseKeyId;
            if (clsString.IsNullOrEmpty(returnKeyId) == false) {
                //gs_TopicRole_ReFreshCache();
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
     <param name = "strTopicRoleId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strTopicRoleId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objgs_TopicRoleEN: clsgs_TopicRoleEN = new clsgs_TopicRoleEN();
        try {
            const responseText = await gs_TopicRole_IsExistAsync(strTopicRoleId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strTopicRoleId}] 的记录不存在!`;
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
            const responseText = await gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId);
            objgs_TopicRoleEN = <clsgs_TopicRoleEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_TopicRoleClass(objgs_TopicRoleEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjgs_TopicRoleEN">表实体类对象</param>
   */
    public GetDataFromgs_TopicRoleClass(pobjgs_TopicRoleEN: clsgs_TopicRoleEN) {
        this.topicRoleId = pobjgs_TopicRoleEN.topicRoleId;// 主题权限Id
        this.topicId = pobjgs_TopicRoleEN.topicId;// 主题编号
        this.menuNum = pobjgs_TopicRoleEN.menuNum;// 菜单编号
        this.menuName = pobjgs_TopicRoleEN.menuName;// 菜单名称
        this.menuIsHide = pobjgs_TopicRoleEN.menuIsHide;// 菜单是否隐藏
        this.updDate = pobjgs_TopicRoleEN.updDate;// 修改日期
        this.updUser = pobjgs_TopicRoleEN.updUser;// 修改人
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strTopicRoleId: string) {
        this.btnSubmit_gs_TopicRole = "确认修改";
        this.btnCancel_gs_TopicRole = "取消修改";
        this.KeyId = strTopicRoleId;
        try {
            const responseText = await gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId);
            var objgs_TopicRoleEN: clsgs_TopicRoleEN = <clsgs_TopicRoleEN>responseText;
            const conGetDataFromClass = await this.GetDataFromgs_TopicRoleClass(objgs_TopicRoleEN);
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
        var objgs_TopicRoleEN: clsgs_TopicRoleEN = new clsgs_TopicRoleEN();
        objgs_TopicRoleEN.topicRoleId = this.KeyId;
        this.PutDataTogs_TopicRoleClass(objgs_TopicRoleEN);
        objgs_TopicRoleEN.sf_UpdFldSetStr = objgs_TopicRoleEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_TopicRoleEN.topicRoleId == "" || objgs_TopicRoleEN.topicRoleId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            gs_TopicRole_CheckProperty4Update(objgs_TopicRoleEN);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `检查数据不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
        try {
            const responseText = await gs_TopicRole_UpdateRecordAsync(objgs_TopicRoleEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //gs_TopicRole_ReFreshCache();
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
    public set btnCancel_gs_TopicRole(value: string) {
        $("#btnCancel_gs_TopicRole").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnSubmit_gs_TopicRole(): string {
        return $("#btnSubmit_gs_TopicRole").html();
    }
    /*
    * 设置确定按钮的标题(Used In AddNewRecord())
   */
    public set btnSubmit_gs_TopicRole(value: string) {
        $("#btnSubmit_gs_TopicRole").html(value);
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
    public set hidSortgs_TopicRoleBy(value: string) {
        $("#hidSortgs_TopicRoleBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortgs_TopicRoleBy(): string {
        return $("#hidSortgs_TopicRoleBy").val();
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
    * 菜单是否隐藏 (Used In Clear())
   */
    public set menuIsHide(value: boolean) {
        $("#chkMenuIsHide").attr("checked", value);
    }
    /*
    * 菜单是否隐藏 (Used In PutDataToClass())
   */
    public get menuIsHide(): boolean {
        return $("#chkMenuIsHide").prop("checked");
    }
    /*
    * 菜单名称 (Used In Clear())
   */
    public set menuName(value: string) {
        $("#txtMenuName").val(value);
    }
    /*
    * 菜单名称 (Used In PutDataToClass())
   */
    public get menuName(): string {
        return $("#txtMenuName").val();
    }
    /*
    * 菜单编号 (Used In Clear())
   */
    public set menuNum(value: string) {
        $("#txtMenuNum").val(value);
    }
    /*
    * 菜单编号 (Used In PutDataToClass())
   */
    public get menuNum(): string {
        return $("#txtMenuNum").val();
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
    * 主题编号 (Used In Clear())
   */
    public set topicId(value: string) {
        $("#txtTopicId").val(value);
    }
    /*
    * 主题编号 (Used In PutDataToClass())
   */
    public get topicId(): string {
        return $("#txtTopicId").val();
    }
    /*
    * 主题权限Id (Used In Clear())
   */
    public set topicRoleId(value: string) {
        $("#txtTopicRoleId").val(value);
    }
    /*
    * 主题权限Id (Used In PutDataToClass())
   */
    public get topicRoleId(): string {
        return $("#txtTopicRoleId").val();
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