
/*-- -- -- -- -- -- -- -- -- -- --
类名:SysSkillCRUD
表名:SysSkill(01120646)
生成代码版本:2020.05.18.1
生成日期:2020/05/22 18:59:58
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { clsSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js";
//import { clsSysSkillBL } from "../TS/L2_BLL/GraduateEdu/clsSysSkillBL.js";
//import { clsvSysSkillBL } from "../TS/L2_BLL/GraduateEdu/clsvSysSkillBL.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";

import { SysSkillCRUD } from "../PagesBase/GraduateEduTopic/SysSkillCRUD.js";
import { SysSkill_Edit } from "../PagesBase/GraduateEduTopic/SysSkill_Edit.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsRTSysSkillRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js";
import { clsSysSkillVerEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSkillVerEN.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsSysOperationTypeEN } from "../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js";
import { clsSysSecurityLevelEN } from "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { ResearchTopic_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { RTSysSkillRela_AddNewRecordAsync, RTSysSkillRela_GetRecCountByCondAsync, RTSysSkillRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js";
import { SysSkillVer_AddNewRecordAsync, SysSkillVer_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillVerWApi.js";
import { SysSkill_AddNewRecordWithReturnKeyAsync, SysSkill_GetMaxStrIdAsync, SysSkill_GetObjBySkillIdAsync, SysSkill_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { SysOperationType_BindDdl_OperationTypeIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js";
import { SysSecurityLevel_BindDdl_LevelIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { BindDdl_ObjLst } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { Pub_PaperList } from "./Pub_PaperList.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
declare function HideDialogThree(): void;
declare function CloseWindow(): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;
/*
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
*/
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
declare var $;
declare var window;
/* SysSkillCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class AddSysskillEx extends SysSkill_Edit {
    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";
    public static strid_CurrEduCls_Cache: string = "00000001";
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divEdit";  //记录是否导入编辑区的变量
    //public objPager: clsPager = new clsPager();
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public recCount = 0;


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        const strThisFuncName = this.Page_Load.name;
        // 在此处放置用户代码以初始化页面
        try {
            //通过主题Id获取教学班ID
            if (clsPublocalStorage.id_CurrEduCls == "") {
                const objResearchTopic = await ResearchTopic_GetFirstObjAsync(" topicId=" + clsPrivateSessionStorage.topicId);
                if (objResearchTopic == null) {
                    const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                    //const strThisFuncName = this.Page_Load.name;
                }
                clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;
            } 

            //建立缓存
            var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
            const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4Edit, "ddlShareId");

            var strSkillId = $("#hidSkillId").val();
            if (strSkillId != "") {
                const conBindDdl = await this.BindDdl4EditRegion();
                const UpdateRecord = await this.UpdateRecord(strSkillId);
                $("#divLoading").hide();
            }
            else {
                ////2、显示无条件的表内容在GridView中
                //const gvResult = await this.BindGv_vSysSkill();
                $("#divLoading").hide();
                this.btnAddNewRecord_Click();
                //获取分享Id
                const responseText = await gs_UserConfigEx_GetNewReturnShareIdEx("09", clsPublocalStorage.userId);
                var strShareId: string = responseText;
                //var returnBool: boolean = !!responseText2;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }
            }

            var strPaperId = $("#hidRequestPaperId").val();
            if (strPaperId != "") {
                $('#SelectPaper').hide();
                //存放Id
                $("#txtCitationId").val(strPaperId);
            }
            else {
                $('#SelectPaper').show();
            }
          
            //// 为查询区绑定下拉框
            //const gvBindDdl = await this.BindDdl4QueryRegion();
            SysSkillCRUD.sortvSysSkillBy = "skillName Asc";
            

        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 添加新记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
*/
    public async btnAddNewRecord_Click() {
        this.opType = "AddWithMaxId";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                //const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
               // ShowDialog('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                //ShowDialog('Add');
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
    /* 修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
    public async btnUpdateRecord_Click(strKeyId: string) {
        this.opType = "Update";
        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
           // const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
           // ShowDialog('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
           // ShowDialog('Update');
            this.UpdateRecord(strKeyId);
        }
    }
    /* 函数功能:把类对象的属性内容显示到界面上
注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 如果在设置数据库时,就应该一级字段在前,二级字段在后
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
 <param name = "pobjSysSkillEN">表实体类对象</param>
*/
    public GetDataFromSysSkillClass(pobjSysSkillEN: clsSysSkillEN) {
        this.skillId = pobjSysSkillEN.skillId;// 技能Id
        this.skillName = pobjSysSkillEN.skillName;// 技能名称
        this.operationTypeId = pobjSysSkillEN.operationTypeId;// 操作类型
        this.levelId = pobjSysSkillEN.levelId;// 级别Id
        this.process = pobjSysSkillEN.process;// 实施过程
        //this.updUser = pobjSysSkillEN.updUser;// 修改人
        //this.updDate = pobjSysSkillEN.updDate;// 修改日期
        this.isSubmit = pobjSysSkillEN.isSubmit;// 是否提交
        this.citationId = pobjSysSkillEN.citationId;// 引用Id
        this.shareId = pobjSysSkillEN.shareId;
        this.memo = pobjSysSkillEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strSkillId: string): Promise<boolean>  {
        this.btnSubmit_SysSkill = "确认修改";
        this.btnCancel_SysSkill = "取消修改";
        this.keyId = strSkillId;
        try {
            const responseText = await SysSkill_GetObjBySkillIdAsync(strSkillId);
            var objSysSkillEN: clsSysSkillEN = <clsSysSkillEN>responseText;
            this.GetDataFromSysSkillClass(objSysSkillEN);
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


        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        objSysSkillEN.SetSkillId(this.keyId);
        $("#hidSkillId").val(this.keyId);
        this.PutDataToSysSkillClass(objSysSkillEN);
        objSysSkillEN.sfUpdFldSetStr = objSysSkillEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await SysSkill_UpdateRecordAsync(objSysSkillEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
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

    /* 函数功能:为编辑区绑定下拉框
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
*/
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        var objSysOperationType_Cond: clsSysOperationTypeEN = new clsSysOperationTypeEN();//编辑区域
        const ddlOperationTypeId = await SysOperationType_BindDdl_OperationTypeIdInDiv_Cache(this.divName4Edit, "ddlOperationTypeId");//编辑区域

        var objSysSecurityLevel_Cond: clsSysSecurityLevelEN = new clsSysSecurityLevelEN();//编辑区域
        const ddlLevelId = await SysSecurityLevel_BindDdl_LevelIdInDiv_Cache(this.divName4Edit,"ddlLevelId");//编辑区域

        //论文
        var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
        const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域
        //文献类型；
        const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
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
    /* 为插入记录做准备工作
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnSubmit_SysSkill = "确认添加";
        this.btnCancel_SysSkill = "取消添加";
        this.Clear();
        //wucSysSkillB1.skillId = clsSysSkillBL.GetMaxStrId_S();
        try {
            const responseText = await SysSkill_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表SysSkill的最大关键字为空，不成功，请检查!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                $('#txtSkillId').val(returnString);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }
    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        var strUrl: string = "./SysSkill_Edit/";
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

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnSubmit_Click.name;
        try {
            if (clsPublocalStorage.userId != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            const responseText3 = await this.AddNewRecordWithMaxIdSaveRetrunId().then((jsonData) => {
                                //var returnBool2 = responseText3;
                                //if (returnBool2 == true) {
                                //CloseWindow();
                                //}
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                   // HideDialog();
                                    //this.BindGv_vSysSkill();
                                    this.iShowList.BindGv(clsvSysSkillEN._CurrTabName, returnBool.toString());
                                }
                            });
                        }
                        //更新总表3个参数 主键、子表类型、页面操作类型；

                        var strSysskillId = $("#hidSkillId").val();
                        const responseText8 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSysskillId, "09", "1", clsPublocalStorage.id_CurrEduCls);
                        var returnBool8: boolean = !!responseText8;
                        if (returnBool8 == true) {
                            console.log("技能数据总表同步成功；");
                        }
                        else {
                            console.log("技能数据总表同步失败；");
                        }
                        //添加记录的同时添加历史版本
                        const responseText4 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                CloseWindow();
                                //alert("添加历史版本出问题！");
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                            //strInfo += "(In SysSkillCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                               // HideDialog();
                                //this.BindGv_vSysSkill();
                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；

                        var strSysskillId = $("#hidSkillId").val();
                        const responseText9 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSysskillId, "09", "2", clsPublocalStorage.id_CurrEduCls);
                        var returnBool9: boolean = !!responseText9;
                        if (returnBool9 == true) {
                            console.log("技能数据总表同步成功；");
                        }
                        else {
                            console.log("技能数据总表同步失败；");
                        }
                        //添加记录的同时添加历史版本
                        const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                CloseWindow();
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
                alert("登录超时，请重新登录");
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
    //添加历史版本
    public async AddVersionRecordSave() {
        const strThisFuncName = this.AddVersionRecordSave.name;

        var objSysSkillVerEN: clsSysSkillVerEN = new clsSysSkillVerEN();
        objSysSkillVerEN.SetSkillId(this.skillId);
        this.PutDataToSysSkillVClass(objSysSkillVerEN);

        try {
            const responseText2 = await SysSkillVer_AddNewRecordAsync(objSysSkillVerEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " 1 =1 and skillId=" + this.skillId;
                var intVersionCount = await SysSkillVer_GetRecCountByCondAsync(strWhereCond2);


                var objViewpointEN: clsSysSkillEN = new clsSysSkillEN();
                objViewpointEN.SetSkillId(this.skillId);
                objViewpointEN.SetVersionCount(intVersionCount);


                objViewpointEN.sfUpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objViewpointEN.skillId == "" || objViewpointEN.skillId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }


                const responseText = SysSkill_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        return true;
                    }
                    else {
                        var strInfo: string = `添加历史版本数不成功!`;
                        alert(strInfo);
                        console.log("添加历史版本数不成功");
                        CloseWindow();
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

    /* 函数功能:把界面上的属性数据传到类对象中
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
<param name = "pobjSysSkillEN">数据传输的目的类对象</param>
*/
    public PutDataToSysSkillVClass(pobjSysSkillVerEN: clsSysSkillVerEN) {
        pobjSysSkillVerEN.SetSkillId(this.skillId);// 技能Id
        pobjSysSkillVerEN.SetSkillName(this.skillName);// 技能名称
        pobjSysSkillVerEN.SetOperationTypeId(this.operationTypeId);// 操作类型
        pobjSysSkillVerEN.SetLevelId(this.levelId);// 级别Id
        pobjSysSkillVerEN.SetProcess(this.process);// 实施过程
        pobjSysSkillVerEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjSysSkillVerEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjSysSkillVerEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        //pobjSysSkillVerEN.SetIsSubmit(this.isSubmit;// 是否提交
        pobjSysSkillVerEN.SetCitationId(this.citationId);// 引用Id
        pobjSysSkillVerEN.SetMemo(this.memo);// 备注
    }

    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjSysSkillEN">数据传输的目的类对象</param>
*/
    public async PutDataToSysSkillClass(pobjSysSkillEN: clsSysSkillEN) {
        pobjSysSkillEN.SetSkillId(this.skillId);// 技能Id
        pobjSysSkillEN.SetSkillName(this.skillName);// 技能名称
        pobjSysSkillEN.SetOperationTypeId(this.operationTypeId);// 操作类型
        pobjSysSkillEN.SetLevelId(this.levelId);// 级别Id
        pobjSysSkillEN.SetProcess(this.process);// 实施过程
        pobjSysSkillEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjSysSkillEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjSysSkillEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjSysSkillEN.SetShareId(this.shareId);
        pobjSysSkillEN.SetIsSubmit(this.isSubmit);// 是否提交
        pobjSysSkillEN.SetCitationId(this.citationId);// 引用Id
        pobjSysSkillEN.SetMemo(this.memo);// 备注
        var strPdfPageNum = $("#hidPdfPageNum").val();
        if (strPdfPageNum != "") {
            pobjSysSkillEN.SetPdfPageNum(strPdfPageNum);
        }
        else {
            pobjSysSkillEN.SetPdfPageNum(1);
        }
    }
    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
*/
    public async AddNewRecordWithMaxIdSaveRetrunId() {
        
        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        objSysSkillEN.SetCreateDate(clsPubFun4Web.getNowDate_ymd());
        this.PutDataToSysSkillClass(objSysSkillEN);
        try {
            //const responseText2 = await SysSkill_AddNewRecordWithMaxIdAsync(objSysSkillEN);
            const responseText = await SysSkill_AddNewRecordWithReturnKeyAsync(objSysSkillEN);
            var strSysskillId: string = responseText;
            //var returnBool: boolean = !!responseText2;
            if (strSysskillId != "") {

                $("#hidSkillId").val(strSysskillId);

                const responseText2 = await this.AddNewRecordSaveRtSysskill();

                return true;
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return strSysskillId;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        //return strSysskillId;//一定要有一个返回值，否则会出错！
    }
    /* 函数功能:把界面上的属性数据传到类对象中
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
<param name = "pobjRTSysSkillRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToRTSysSkillRelaClass(pobjRTSysSkillRelaEN: clsRTSysSkillRelaEN) {
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strUserId = clsPublocalStorage.userId;
        var strSkillId = $("#hidSkillId").val();
        pobjRTSysSkillRelaEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjRTSysSkillRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTSysSkillRelaEN.SetSkillId(strSkillId);// 技能Id
        pobjRTSysSkillRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTSysSkillRelaEN.SetUpdUser(strUserId);
        pobjRTSysSkillRelaEN.SetMemo(this.memo);// 备注
        pobjRTSysSkillRelaEN.SetClassificationId("0000000000");// 分类为000000
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSaveRtSysskill() {
        const strThisFuncName = this.AddNewRecordSaveRtSysskill.name;
        
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strSkillId = $("#hidSkillId").val();
        var strUserId = clsPublocalStorage.userId;
        var objRTSysSkillRelaEN: clsRTSysSkillRelaEN = new clsRTSysSkillRelaEN();
        this.PutDataToRTSysSkillRelaClass(objRTSysSkillRelaEN);
        try {
            //同一用户，同一主题 同一技能 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And skillId = '" + strSkillId + "' And updUser = '" + strUserId + "'";
            const responseText = await RTSysSkillRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题同一个用户不能重复添加同一个技能！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            else {

                const responseText2 = await RTSysSkillRela_AddNewRecordAsync(objRTSysSkillRelaEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    var strInfo: string = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);

                    //根据ID获取最大数；
                    var strWhereCond2 = " 1 =1 and skillId=" + strSkillId;
                    var intCitationCount = await RTSysSkillRela_GetRecCountByCondAsync(strWhereCond2);


                    var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
                    objSysSkillEN.SetSkillId(strSkillId);
                    objSysSkillEN.SetCitationCount(intCitationCount);

                    objSysSkillEN.sfUpdFldSetStr = objSysSkillEN.updFldString;//设置哪些字段被修改(脏字段)
                    if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                         throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }

                    const responseText = await SysSkill_UpdateRecordAsync(objSysSkillEN).then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {


                        }
                        else {
                            var strInfo: string = `操作不成功!`;
                            alert(strInfo);
                            console.log("操作不成功");
                        }

                    });


                    //显示信息框
                    alert(strInfo);
                    //HideDialogNine();
                }
                else {
                    var strInfo: string = `添加记录不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
            }
            return responseText;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
    }



    /* 函数功能:在数据 列表中跳转到某一页 论文列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
<param name = "intPageIndex">页序号</param>
*/
    //public IndexPageTwo(intPageIndex) {
    //    if (intPageIndex == 0) {
    //        intPageIndex = this.objPager.pageCount;
    //    }
    //    console.log("跳转到" + intPageIndex + "页");
    //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
    //    this.BindGv_vPaper();
    //}
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
        $("#txtCitationId").val(strkeyId);
        //设置只读属性；
        $("#txtCitationId").attr("disabled", "disabled");
        //关闭列表
        HideDialogThree();

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