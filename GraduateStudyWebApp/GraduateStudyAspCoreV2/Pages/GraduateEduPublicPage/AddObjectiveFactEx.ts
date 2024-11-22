
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";

import { clsObjectiveAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js";
import { clsTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";


import { TopicObjectiveCRUD } from "../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js";
import { TopicObjective_Edit } from "../PagesBase/GraduateEduTopic/TopicObjective_Edit.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsTopicObjectiveVerEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveVerEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { ObjectiveAttachment_AddNewRecordAsync, ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js";
import { ResearchTopic_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { TopicObjectiveVer_AddNewRecordAsync, TopicObjectiveVer_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveVerWApi.js";
import { TopicObjective_AddNewRecordAsync, TopicObjective_GetMaxStrIdAsync, TopicObjective_GetObjByTopicObjectiveIdAsync, TopicObjective_GetObjLstAsync, TopicObjective_IsExistAsync, TopicObjective_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { BindDdl_ObjLst, GetCheckedKeyIds } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Pub_PaperList } from "./Pub_PaperList.js";
import { Format } from "../TS/PubFun/clsString.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogThree(): void;
declare function CloseWindow(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiTopicObjective_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class AddObjectiveFactEx extends TopicObjective_Edit {
    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvTopicObjectiveBy: string = "topicObjectiveId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        const strThisFuncName = this.Page_Load.name;
        // 在此处放置用户代码以初始化页面
        try {

            if (clsPublocalStorage.userId != "") {

                //通过主题Id获取教学班ID
                if (clsPublocalStorage.id_CurrEduCls == "") {
                    const objResearchTopic = await ResearchTopic_GetFirstObjAsync(" topicId=" + clsPrivateSessionStorage.topicId);
                    if (objResearchTopic == null) {
                        const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                        //const strThisFuncName = this.ShowData.name;
                    }
                    clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;
                } 

                //const arrvTopicObjective_Cache = await vTopicObjective_GetObjLstAsync("1=1");

                var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
                //const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
                if ($("#hidObjectiveId").val() != "") {
                    const UpdateRecord = await this.UpdateRecord($("#hidObjectiveId").val());
                     $("#divLoading").hide();
                }
                else {
                    this.AddNewRecord();
                    var configTypeId;
                    var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
                    if (strhidObjectiveTypeId=="01") {
                        configTypeId = "07";
                    }
                    else {
                        configTypeId = "08";
                    }
                    //获取分享Id
                    const responseText = await gs_UserConfigEx_GetNewReturnShareIdEx(configTypeId, clsPublocalStorage.userId);
                    var strShareId: string = responseText;
                    //var returnBool: boolean = !!responseText2;
                    if (strShareId != "") {
                        this.shareId = strShareId;
                    }
                    $("#divLoading").hide();
                }
                ////建立缓存
                //

                TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";
               
                //用户下拉框绑定
                //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域
                //文献类型；
                const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");

              
                //var strWhereCond = await this.CombinevTopicObjectiveCondition();
                //const responseText = await vTopicObjective_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                
                //});
                ////2、显示无条件的表内容在GridView中
                //const gvResult = await this.BindGv_vTopicObjective();
                //$('#divEditRegion').modal('show');
                //ShowDialog("Add");
                //进来默认添加界面设置；

                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；


                //获取传参的paperId
                var strPaperId = $("#hidRequestPaperId").val();
                if (strPaperId != "") {
                    $('#SelectPaper').hide();
                    //存放Id
                    $("#txtSourceId").val(strPaperId);
                }
                else {
                    $('#SelectPaper').show();
                }
               

            }
            else {
                window.top.location.href = "../Web/Login";
            }
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 为下拉框获取数据,从表:[Paper]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_LiteratureTypeId(ddlLiteratureTypeId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlLiteratureTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = LiteratureType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrPaperObjLst: Array<clsLiteratureTypeEN> = <Array<clsLiteratureTypeEN>>jsonData;
                    BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                    console.log("完成BindDdl_LiteratureTypeId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }


    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
*/
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnSubmit_TopicObjective;
        try {

            //判断session是否失效
            if (clsPublocalStorage.userId != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        //if (this.opType == "AddWithMaxId") {
                        //    const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                        //        var returnBool2: boolean = jsonData;
                        //        if (returnBool2 == true) {
                        //            HideDialog();
                        //            this.BindGv_vTopicObjective();
                        //        }
                        //    });
                        //}
                        //else {

                        //}
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                //HideDialog();
                                //this.BindGv_vTopicObjective();
                                //CloseWindow();
                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；
                        var configTypeId;
                        var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
                        if (strhidObjectiveTypeId == "01") {
                            configTypeId = "07";
                        }
                        else {
                            configTypeId = "08";
                        }
                      
                        var strTopicObjectiveId = $('#hidObjectiveId').val();
                        const responseText6 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strTopicObjectiveId, configTypeId, "1", clsPublocalStorage.id_CurrEduCls);
                        var returnBool6: boolean = !!responseText6;
                        if (returnBool6 == true) {
                            console.log("客观数据总表同步成功；");
                        }
                        else {
                            console.log("客观数据总表同步失败；");
                        }
                        //修改记录的同时添加历史版本
                        const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                CloseWindow();
                                //alert("添加历史版本出问题！");
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                            //strInfo += "(In WApiTopicObjective_QUDI_TS.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                //HideDialog();
                                //this.BindGv_vTopicObjective();
                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；
                        var configTypeId;
                        var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
                        if (strhidObjectiveTypeId == "01") {
                            configTypeId = "07";
                        }
                        else {
                            configTypeId = "08";
                        }

                        var strTopicObjectiveId = $('#hidObjectiveId').val();
                        const responseText7 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strTopicObjectiveId, configTypeId, "2", clsPublocalStorage.id_CurrEduCls);
                        var returnBool7: boolean = !!responseText7;
                        if (returnBool7 == true) {
                            console.log("客观数据总表同步成功；");
                        }
                        else {
                            console.log("客观数据总表同步失败；");
                        }
                        //修改记录的同时添加历史版本
                        const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                CloseWindow();
                                //HideDialog();
                                //this.BindGv_vTopicObjective();
                                //alert("添加历史版本出问题！");
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                        alert(strMsg);
                        break;
                }
            }
            else {
                window.top.location.href = "../Web/Login";
            }
            $("#divLoading").hide();
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", false);
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }



    /* 添加新记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
*/
    public async btnAddNewRecord_Click() {
        this.opType = "Add";
        try {
            const responseText = await this.AddNewRecord();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_TopicObjective = "确认添加";
        this.btnCancel_TopicObjective = "取消添加";
        this.Clear();
        //去掉提交按钮不可用状态
        $('#btnOKUpd').attr("disabled", false);
    }
    public Clear() {

        $("#hdnFileOne").val("");
        $("#hdnFileTwo").val("");
        $("#hdnFileThree").val("");
    }

    /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSave() {

        try {
            const responseText = await TopicObjective_GetMaxStrIdAsync().then((jsonData) => {
                var returnString: string = jsonData.toString();
                if (returnString == "") {
                    var strInfo: string = `获取表TopicObjective的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtTopicObjectiveId').val(returnString);
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
        //判断Id是否为空
        if ($('#txtTopicObjectiveId').val() != "") {
            var strTopicObjectiveId = $("#txtTopicObjectiveId").val()
            //存放Id
            $('#hidObjectiveId').val(strTopicObjectiveId);

            
            var objTopicObjectiveEN: clsTopicObjectiveEN = new clsTopicObjectiveEN();
            objTopicObjectiveEN.SetCreateDate(clsPubFun4Web.getNowDate_ymd());
            this.PutDataToTopicObjectiveClass(objTopicObjectiveEN);
            try {
                const responseText = await TopicObjective_IsExistAsync(objTopicObjectiveEN.topicObjectiveId);
                var bolIsExist: boolean = responseText;
                if (bolIsExist == true) {
                    var strMsg: string = `添加记录时，关键字：${objTopicObjectiveEN.topicObjectiveId}已经存在！`;
                    alert(strMsg);
                    return responseText;//一定要有一个返回值，否则会出错！
                }
                const responseText2 = await TopicObjective_AddNewRecordAsync(objTopicObjectiveEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    //var strInfo: string = `添加记录成功!`;
                    //$('#lblResult46').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);

                    //添加主题客观关系；
                    //this.AddObjectiveNewRecordSave();
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
            }

        }
        else {

            var strInfo: string = `获取最大关键字为空，不成功!`;
            //显示信息框
            alert(strInfo);
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    //添加历史版本
    public async AddVersionRecordSave() {
        const strThisFuncName = this.AddVersionRecordSave.name;


        var objTopicObjectiveVerEN: clsTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
        objTopicObjectiveVerEN.SetTopicObjectiveId(this.topicObjectiveId);
        this.PutDataToTopicObjectiveVClass(objTopicObjectiveVerEN);

        try {
            const responseText2 = await TopicObjectiveVer_AddNewRecordAsync(objTopicObjectiveVerEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " 1 =1 and topicObjectiveId=" + this.topicObjectiveId;
                var intVersionCount = await TopicObjectiveVer_GetRecCountByCondAsync(strWhereCond2);


                var objTopicObjectiveEN: clsTopicObjectiveEN = new clsTopicObjectiveEN();
                objTopicObjectiveEN.SetTopicObjectiveId(this.topicObjectiveId);
                objTopicObjectiveEN.SetVersionCount(intVersionCount);


                objTopicObjectiveEN.sfUpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }


                const responseText = TopicObjective_UpdateRecordAsync(objTopicObjectiveEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        return true;
                    }
                    else {
                        var strInfo: string = `添加历史版本数不成功!`;
                        alert(strInfo);
                        console.log("添加历史版本数不成功");
                        return false;
                    }

                });
                return true;
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加版本记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }

    //////////////////////////////////////////////////////////////////////附件添加
    //添加上传论文附件方法
    public async AddNewRecordobjPaperSubAttachmentENSave(filePath: string, strfileNum: string) {
        var objObjectiveAttachmentEN: clsObjectiveAttachmentEN = new clsObjectiveAttachmentEN();
        this.PutDataToPaperAttachmentClass(objObjectiveAttachmentEN, filePath);
        try {
            const responseText2 = await ObjectiveAttachment_AddNewRecordAsync(objObjectiveAttachmentEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //第一个附件
                if (strfileNum == "first") {
                    //如果第二个附件不等于空，那么执行添加函数；
                    if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                        var fileTwo = $("#hdnFileTwo").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    }
                    else {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }
                }
                else if (strfileNum == "two") {
                    //为空则判断第三个附件值；
                    if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                        var fileThree = $("#hdnFileThree").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                    }
                }

            }
            else {
                var strInfo: string = `论文附件添加不成功!`;
                $('#lblResult40').val(strInfo);
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
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    //观点附件数据存放
    public PutDataToPaperAttachmentClass(pobjObjectiveAttachmentEN: clsObjectiveAttachmentEN, filePath: string) {
        pobjObjectiveAttachmentEN.SetTopicObjectiveId($("#txtTopicObjectiveId").val());// 概念Id

        var strfilePath = filePath;
        //判断地址不为空则执行截取操作
        if (strfilePath != "") {
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjObjectiveAttachmentEN.SetFilePath(filePath);

            pobjObjectiveAttachmentEN.SetObjectiveAttachmentName(strfilePath);
        }
        pobjObjectiveAttachmentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期

        pobjObjectiveAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班
        pobjObjectiveAttachmentEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id


    }
    ///////////////////////////////////////////////////////////////////数据提交；
    //客观提交审核
    public async btnIsSubmit_Click(strKeyId: string) {

        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        this.SubmitRecord(strKeyId);

    }
    //提交判断；
    public async SubmitRecord(strTopicObjectiveId: string) {

        this.keyId = strTopicObjectiveId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = TopicObjective_GetObjByTopicObjectiveIdAsync(strTopicObjectiveId).then((jsonData) => {
                    var objTopicObjectiveEN: clsTopicObjectiveEN = <clsTopicObjectiveEN>jsonData;

                    //通过session 权限获取权限

                    var strUserId = clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage.roleId;
                    //判断角色 //学生00620003
                    if (strRoleId == "00620003") {

                        // //通过判断数据用户是否是当前登录用户；
                        if (objTopicObjectiveEN.updUser == strUserId) {

                            //判断数据是否已审核
                            if (objTopicObjectiveEN.isSubmit == false) {

                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {

                                });
                            }
                            else {
                                alert("当前数据已提交！");
                                return;
                            }
                        }
                        else {
                            alert("当前数据不是您所添加，不能提交！");
                            return;
                        }
                    }
                    else {

                        //可以提交
                        //判断数据是否已提交
                        if (objTopicObjectiveEN.isSubmit == false) {

                            const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                            });
                        }
                        else {
                            alert("当前数据已提交！");
                            return;
                        }
                    }

                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /* 提交权限修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async SubmitRecordSave(): Promise<boolean> {
        const strThisFuncName = this.SubmitRecordSave.name;

        //
        var objTopicObjectiveEN: clsTopicObjectiveEN = new clsTopicObjectiveEN();
        objTopicObjectiveEN.SetTopicObjectiveId(this.keyId);
        objTopicObjectiveEN.SetIsSubmit(true);
        this.PutDataToTopicObjectiveClass(objTopicObjectiveEN);
        objTopicObjectiveEN.sfUpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = TopicObjective_UpdateRecordAsync(objTopicObjectiveEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        HideDialog();
                        this.iShowList.BindGv(clsTopicObjectiveEN._CurrTabName, returnBool.toString());
                    }
                    else {
                        var strInfo: string = `提交不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("提交失败");
                    }
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    ////////////////////////////////////////////////////修改数据

    //修改权限判断是否提交 提交则不可修改；
    /* 根据关键字获取相应的记录的对象
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
 <param name = "sender">参数列表</param>
*/
    public async UpdateRecord(strTopicObjectiveId: string): Promise<boolean> 
   {
        this.btnSubmit_TopicObjective = "确认修改";
        this.btnCancel_TopicObjective = "取消修改";
        this.keyId = strTopicObjectiveId;
        var strUserId = clsPublocalStorage.userId;
        try {
            const responseText = await TopicObjective_GetObjByTopicObjectiveIdAsync(strTopicObjectiveId);
            var objTopicObjectiveEN: clsTopicObjectiveEN = <clsTopicObjectiveEN>responseText;

            // //通过判断数据用户是否是当前登录用户；
            //if (objTopicObjectiveEN.updUser == strUserId) {

            //    //判断数据是否提交，提交则不可修改；
            //    if (objTopicObjectiveEN.isSubmit == false) {
            //        //ShowDialog('Update');
                    
            //    }
            //    else {
            //        alert("当前数据已提交,不能修改！");
            //        return;
            //    }

            //}
            //else {
            //    alert("当前数据不是您所添加，不能修改！");
            //    return;
            //}

            this.GetDataFromTopicObjectiveClass(objTopicObjectiveEN);
            console.log("完成UpdateRecord!");
            return true;
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        return true;
    }



    /* 修改记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async UpdateRecordSave() {
        const strThisFuncName = this.UpdateRecordSave.name;


        var objTopicObjectiveEN: clsTopicObjectiveEN = new clsTopicObjectiveEN();
        objTopicObjectiveEN.SetTopicObjectiveId(this.keyId);
        this.PutDataToTopicObjectiveClass(objTopicObjectiveEN);
        objTopicObjectiveEN.sfUpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await TopicObjective_UpdateRecordAsync(objTopicObjectiveEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {

                //如果等于空，那么就去判断附件是否为空；
                //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                    //根据Id删除附件
                    var strwhere = "topicObjectiveId ='" + objTopicObjectiveEN.topicObjectiveId + "'";
                    this.DelRecordByWhere(strwhere);

                }

            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
        }
        return true;
    }

    //删除观点附件
    /* 
根据关键字删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync(strWhere).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {

                        //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        ////显示信息框
                        //alert(strInfo);
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
                        //显示信息框
                        //alert(strInfo);
                    }

                    //在修改时候，不管是否有附件数据被清除； 都需要执行附件添加功能
                    //判断是否有返回的附件路径值
                    var fileOne = $("#hdnFileOne").val();
                    if (fileOne != "" && fileOne != undefined) { //第一个附件框判断

                        this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                    }
                    else {
                        var fileTwo = $("#hdnFileTwo").val();
                        if (fileTwo != "" && fileTwo != undefined) {

                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            var fileThree = $("#hdnFileThree").val();
                            if (fileThree != "" && fileThree != undefined) {

                                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                            }
                        }

                    }

                    console.log("完成DelRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjTopicObjectiveEN">数据传输的目的类对象</param>
  */
    public PutDataToTopicObjectiveVClass(pobjTopicObjectiveVerEN: clsTopicObjectiveVerEN) {
        var strUserId = clsPublocalStorage.userId;
        pobjTopicObjectiveVerEN.SetTopicObjectiveId(this.topicObjectiveId);// 客观Id
        pobjTopicObjectiveVerEN.SetObjectiveName(this.objectiveName);// 客观名称
        pobjTopicObjectiveVerEN.SetObjectiveContent(this.objectiveContent);// 客观内容
        //判断客观类型
        var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
        if (strhidObjectiveTypeId != "") {
            pobjTopicObjectiveVerEN.SetObjectiveType(strhidObjectiveTypeId);
        }
        //pobjTopicObjectiveEEN.SetObjectiveType(this.objectiveType;// 客观类型
        pobjTopicObjectiveVerEN.SetSourceId(this.sourceId);// 来源Id
        pobjTopicObjectiveVerEN.SetConclusion(this.conclusion);// 结论
        pobjTopicObjectiveVerEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);

        pobjTopicObjectiveVerEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjTopicObjectiveVerEN.SetUpdUser(strUserId);// 修改用户Id
        pobjTopicObjectiveVerEN.SetMemo(this.memo);// 备注

        var strPdfPageNum = $("#hidPdfPageNum").val();
        if (strPdfPageNum != "") {
            pobjTopicObjectiveVerEN.SetPdfPageNum(strPdfPageNum);
        }
        else {
            pobjTopicObjectiveVerEN.SetPdfPageNum(1);
        }
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjTopicObjectiveEN">数据传输的目的类对象</param>
   */
    public async PutDataToTopicObjectiveClass(pobjTopicObjectiveEN: clsTopicObjectiveEN) {
        var strUserId = clsPublocalStorage.userId;
        pobjTopicObjectiveEN.SetTopicObjectiveId(this.topicObjectiveId);// 客观Id
        pobjTopicObjectiveEN.SetObjectiveName(this.objectiveName);// 客观名称
        pobjTopicObjectiveEN.SetObjectiveContent(this.objectiveContent);// 客观内容
        //判断客观类型
        var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
        if (strhidObjectiveTypeId != "") {
            pobjTopicObjectiveEN.SetObjectiveType(strhidObjectiveTypeId);
        }
        //pobjTopicObjectiveEEN.SetObjectiveType(this.objectiveType;// 客观类型
        pobjTopicObjectiveEN.SetSourceId(this.sourceId);// 来源Id
        pobjTopicObjectiveEN.SetConclusion(this.conclusion);// 结论
        pobjTopicObjectiveEN.SetShareId(this.shareId);//分享；
        pobjTopicObjectiveEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjTopicObjectiveEN.SetIsSubmit(false);// 是否提交 //因为是个人数据，所以状态直接为false；
        pobjTopicObjectiveEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        if (this.btnSubmit_TopicObjective == "确认添加") {
            pobjTopicObjectiveEN.SetUpdUser(strUserId);// 修改用户Id
        }
        
        pobjTopicObjectiveEN.SetMemo(this.memo);// 备注
    }


    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvPaperBy(value: string) {
        $("#hidSortvPaperBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvPaperBy(): string {
        return $("#hidSortvPaperBy").val();
    }
    /*
   * 论文标题
  */
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }
    ///////////////////////论文列表条件
    public get readUser_q(): string {
        return $("#ddlUserId_q").val();
    }
   
    /*
    * 文献类型Id
   */
    public get literatureTypeId_q(): string {
        return $("#ddlLiteratureTypeId_q").val();
    }
    /*
    * 论文Id
   */
    public set paperId(value: string) {
        $("#txtPaperId").val(value);
    }
    /*
    * 论文
   */
    public get paperId(): string {
        return $("#txtPaperId").val();
    }
    /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevPaperCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strPaperTypeId = $("#hidPaperTypeId").val();
        var strTopicId: string = clsPrivateSessionStorage.topicId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }

            if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
            }
            //用户
            if (this.readUser_q != "" && this.readUser_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.readUser_q}'`;
            }
            //只查询提交的论文数据
            strWhereCond += ` And ${clsPaperEN.con_IsSubmit} = 'true'`;

            //排除获取已被当前观点引用过的论文数据；
            //strWhereCond += ` And paperId not in (select paperId from RTPaperRela where viewpointId = '${strTopicId}')`;

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

 
    //选择论文弹出列表数据；
    public async selectPaper_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.BindGv_vPaper();
    }
    //查询论文列表
    public async btnPaperQuery_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.BindGv_vPaper();
    }
    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)

        $("#txtSourceId").val(strkeyId);
        //设置只读属性；
        $("#txtSourceId").attr("disabled", "disabled");
        //$("#txtPaperId").val(strkeyId);
        ////设置只读属性；
        //$("#txtPaperId").attr("disabled", "disabled");
        //关闭列表
        HideDialogThree();

    }


    /*
  * 文献类型
 */
    public set objectiveType(value: string) {
        $("#ddlObjectiveType").val(value);
    }
    /*
    * 文献类型
   */
    public get objectiveType(): string {
        return $("#ddlObjectiveType").val();
    }

    /*
 * 分享
 */
    public set shareId(value: string) {
        $("#ddlShareId").val(value);
    }
    /*
    * 分享
    */
    public get shareId(): string {
        return $("#ddlShareId").val();
    }

}