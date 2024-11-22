/*-- -- -- -- -- -- -- -- -- -- --
类名:PaperSubViewpoint_QUDI_TSEx
表名:PaperSubViewpoint(01120534)
生成代码版本:2019.12.06.1
生成日期:2019/12/27 21:14:11
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { clsPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js";
import { clsSectionEN } from "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js";
import { clsvPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js";
import { clsvPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsSubViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js";
import { vPaperReadWrite_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
//import { clsPaperSubViewpointAppraiseEN } from "../TS/L0_Entity/GraduateEdu/clsPaperSubViewpointAppraiseEN.js";
//import { clsPaperSubViewpointAppraiseWApi } from "../TS/L3_ForWApi/GraduateEdu/clsPaperSubViewpointAppraiseWApi.js";
//import { clsvPaperSubViewpointAppraiseWApi } from "../TS/L3_ForWApi/GraduateEdu/clsvPaperSubViewpointAppraiseWApi.js";
//import { clsvPaperSubViewpointAppraiseEN } from "../TS/L0_Entity/GraduateEdu/clsvPaperSubViewpointAppraiseEN.js";
import { PaperSubViewpoint_QUDI_TS } from "../GraduateEduPaper/PaperSubViewpoint_QUDI_TS.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperDownloadLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js";
import { clsPaperSubAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsExplainTypeEN } from "../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { vPaperSubViewpoint_GetObjLstByPagerAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { ExplainType_BindDdl_ExplainTypeIdInDiv_Cache, ExplainType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js";
import { PaperSubViewpoint_AddNewRecordAsync, PaperSubViewpoint_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js";
import { PaperSubAttachment_AddNewRecordAsync, PaperSubAttachment_DelPaperSubAttachmentsByCondAsync, PaperSubAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js";
import { vPaper_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { PaperDownloadLog_AddNewRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js";
import { Section_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js";
import { SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache, SubViewpointType_GetFirstObjAsync, SubViewpointType_GetObjLstAsync, SubViewpointType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialog3(): void;
//declare function tbody(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var strAddressAndPort;
declare function doDownLoad(filepath, filename): void;

declare var $;
declare var window;
/* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PaperSubViewpoint extends PaperSubViewpoint_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 100;
    }


    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();
            if (strUserId != "") {
                
                //加载页面所需数据源到缓存
                const arrSubViewpointType_Cache = await SubViewpointType_GetObjLstAsync("1=1");
                const arrExplainType_Cache = await ExplainType_GetObjLstAsync("1=1");
                //const arrvPaperSubViewpoint_Cache = await vPaperSubViewpoint_GetObjLstAsync("1=1");


                //1、为下拉框设置数据源,绑定列表数据
                var strWhereCond1 = this.CombinevPaperSubViewpointCondition1();
                var objvPaperReadWrite: clsvPaperReadWriteEN = new clsvPaperReadWriteEN;
                const responseObjLst = await vPaperReadWrite_GetFirstObjAsync(strWhereCond1).then((jsonData) => {
                    objvPaperReadWrite = <clsvPaperReadWriteEN>jsonData;
                });

                var objSubViewpointType_Cond: clsSubViewpointTypeEN = new clsSubViewpointTypeEN();
                var objExplainType_Cond: clsExplainTypeEN = new clsExplainTypeEN();

                const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId", objvPaperReadWrite.paperId);
                const ddl_SectionId_q = await this.BindDdl_SectionId("ddlSectionId_q", objvPaperReadWrite.paperId);

                const ddl_SubViewpointTypeId_q = SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache(this.divName4List, "ddlSubViewpointTypeId_q");
                const ddl_SubViewpointTypeId = SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache(this.divName4List, "ddlSubViewpointTypeId");
                const ddl_ExplainTypeId = ExplainType_BindDdl_ExplainTypeIdInDiv_Cache(this.divName4List, "ddlExplainTypeId");

                //const ddl_SubViewpointTypeId_q = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId_q");
                ////const ddl_ExplainTypeId_q = await this.BindDdl_ExplainTypeId("ddlExplainTypeId_q");
                //const ddl_SubViewpointTypeId = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId");
                //const ddl_ExplainTypeId = await this.BindDdl_ExplainTypeId("ddlExplainTypeId");

                //this.hidSortvPaperSubViewpointBy = "subViewpointTypeName Asc";
                this.hidSortvPaperSubViewpointBy = "orderNum Asc";

                //var strWhereCond = this.CombinevPaperSubViewpointCondition();

                //const responseText = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                //2、显示无条件的表内容在GridView中


               
                $("#hidUserId").val(strUserId);
                //判断角色 教师

                if (strRoleId == "00620001") {

                    //$("#btnDelRecord").show();
                }
                else if (strRoleId == "00620002") {

                    //可以查看所有；
                }
                else {

                }

                const gvResult0 = await this.GetReadWriteData(objvPaperReadWrite);

                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                const gvResult = await this.BindGv_vPaperSubViewpoint();
                //tbody();
                $("#divLoading").hide();

            }
            else {
                window.top.location.href = "../Web/Login";
            }


        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    public async BindDdl_SubViewpointTypeId_Cache(strDdlName: string, objSubViewpointType_Cond: clsSubViewpointTypeEN){
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_SubViewpointTypeId_Cache");
        var arrObjLst_Sel: Array<clsSubViewpointTypeEN> = await SubViewpointType_GetSubObjLst_Cache(objSubViewpointType_Cond);
        clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsSubViewpointTypeEN.con_SubViewpointTypeId, clsSubViewpointTypeEN.con_SubViewpointTypeName, "");
    }


    public DetailRecord() {

        //this.KeyId = strPaperRWId;
        var strWhereCond = this.CombinevPaperSubViewpointCondition1();
        return new Promise((resolve, reject) => {
            try {
                const responseText = vPaperReadWrite_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                    var objvPaperReadWriteEN: clsvPaperReadWriteEN = <clsvPaperReadWriteEN>jsonData;
                    this.GetReadWriteData(objvPaperReadWriteEN);
                    console.log("完成Detail!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }


    public async GetReadWriteData(pobjvPaperReadWriteEN: clsvPaperReadWriteEN) {
        $("#hidPaperId").val(pobjvPaperReadWriteEN.paperId);//论文ID

        $("#txtPaperTitle").html(pobjvPaperReadWriteEN.paperTitle);//论文标题
        $("#txtKeyword").html(pobjvPaperReadWriteEN.keyword);//关键字Id
        $("#txtPeriodical").html(pobjvPaperReadWriteEN.periodical);//
        $("#txtAuthor").html(pobjvPaperReadWriteEN.author);//作者
        $("#txtResearchQuestion").html(pobjvPaperReadWriteEN.researchQuestion);//研究问题
        $("#txtPaperContent").html(pobjvPaperReadWriteEN.paperContent);//论文内容
        this.DetailRecordDownload(pobjvPaperReadWriteEN.paperId);


        $("#hidViewpointUserId").val(pobjvPaperReadWriteEN.updUser);//作者
    }

    public DetailRecordDownload(strPaperId: string) {

        //this.KeyId = strPaperRWId;
        var strWhereCond = " paperId ='" + strPaperId + "'";
        return new Promise((resolve, reject) => {
            try {
                const responseText = vPaper_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                    var objvPaperEN: clsvPaperEN = <clsvPaperEN>jsonData;

                    if (objvPaperEN.attachmentCount > 0) {
                        $("#btnDownLoadFile").show();
                        $("#lblDownLoadFile").hide();

                    } else {
                        $("#btnDownLoadFile").hide();
                        $("#lblDownLoadFile").show();
                    }

                    console.log("完成Detail!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnOKUpd;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_vPaperSubViewpoint();
                        }
                    });
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_vPaperSubViewpoint();
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
            $("#btnOKUpd").attr("disabled", false);

        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }
    /* 添加新记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        //创建时间
        objPaperSubViewpointEN.createDate = clsPubFun4Web.getNowDate_ymd();
        this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        try {
            const responseText2 = await PaperSubViewpoint_AddNewRecordAsync(objPaperSubViewpointEN);

            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //存放主键；
                //$("#hidKeyId").val();

                //判断是否有返回的附件路径值
                if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    var fileOne = $("#hdnFileOne").val();
                    this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                }
                else {
                    if ($("#hdnFileTwo").val() != "") {
                        var fileTwo = $("#hdnFileTwo").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    }
                    else {
                        if ($("#hdnFileThree").val() != "") {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }

                }

                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
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
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }
    //添加上传论文附件方法
    public async AddNewRecordobjPaperSubAttachmentENSave(filePath: string, strfileNum: string) {
        var objPaperSubAttachmentEN: clsPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
        this.PutDataToPaperAttachmentClass(objPaperSubAttachmentEN, filePath);
        try {
            const responseText2 = await PaperSubAttachment_AddNewRecordAsync(objPaperSubAttachmentEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //var returnKeyId: string = responseText2;
                //if (returnKeyId != "") {
                //存放返回主键
                //  $("#hidKeyId").val(returnKeyId);
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
    public PutDataToPaperAttachmentClass(pobjPaperSubAttachmentEN: clsPaperSubAttachmentEN, filePath: string) {
        pobjPaperSubAttachmentEN.subViewpointId = $("#hidKeyId").val();// 论文Id

        var strfilePath = filePath;
        var index = strfilePath.lastIndexOf("\/");
        strfilePath = strfilePath.substring(index + 1, strfilePath.length);
        pobjPaperSubAttachmentEN.filePath = filePath;
        pobjPaperSubAttachmentEN.paperSubAttachmentName = strfilePath;

        pobjPaperSubAttachmentEN.updDate = clsPubFun4Web.getNowDate();// 修改日期

       

        pobjPaperSubAttachmentEN.updUserId = clsPubSessionStorage.GetSession_UserId();// 修改用户Id


    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public UpdateRecordSave(): Promise<boolean> {
        this.DivName = "divUpdateRecordSave";
        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        objPaperSubViewpointEN.subViewpointId = this.KeyId;
        this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubViewpoint_UpdateRecordAsync(objPaperSubViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //存放主键;
                        $("#hidKeyId").val(objPaperSubViewpointEN.subViewpointId);
                        //得到相关论文附件地址，判断是否为空
                        if ($("#hdnFileOne").val() != "" || $("#hdnFileTwo").val() != "" || $("#hdnFileThree").val() != "") {
                            //根据Id删除附件
                            var strwhere = "subViewpointId ='" + objPaperSubViewpointEN.subViewpointId + "'";
                            this.DelRecordByWhere(strwhere);

                        }

                        var strInfo: string = `修改记录成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        var strInfo: string = `修改记录不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("完成UpdateRecordSave");
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
    /* 
 根据关键字删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubAttachment_DelPaperSubAttachmentsByCondAsync(strWhere).then((jsonData) => {
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

                    //不管是否有数据删除 都需要执行附件添加功能
                    //判断是否有返回的附件路径值
                    //判断是否有返回的附件路径值
                    if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        var fileOne = $("#hdnFileOne").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                    }
                    else {
                        if ($("#hdnFileTwo").val() != "") {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            if ($("#hdnFileThree").val() != "") {
                                var fileThree = $("#hdnFileThree").val();
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
                return false;
            }
        });
    }






    public CombinevPaperSubViewpointCondition1(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperRWId = $("#hidPaperRWId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {

            if (strPaperRWId != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    public CombinevPaperSubViewpointCondition2(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {

            if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
            }

            strWhereCond += " order by orderNum Asc";


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    public CombinevPaperSubViewpointCondition3(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1=1 ";
        var strPaperRWId = $("#hidPaperRWId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.SectionId_q != "" && this.SectionId_q != "0" && this.SectionId_q != null) {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
            }
            if (strPaperRWId != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
            }
            if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0" && this.SubViewpointTypeId_q != null) {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
            }
            //if (this.ExplainTypeId_q != "" && this.ExplainTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvPaperSubViewpointEN.con_ExplainTypeId} = '${this.ExplainTypeId_q}'`;
            //}



        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }



    public CombinevPaperSubViewpointCondition3Obj(): clsvPaperSubViewpointEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperRWId = $("#hidPaperRWId").val();
        var objvPaperSubViewpoint_Cond: clsvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.SectionId_q != "" && this.SectionId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
                objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN.con_SectionId, this.SectionId_q, "=");
            }
            if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
                objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN.con_SubViewpointTypeId, this.SubViewpointTypeId_q, "=");
            }
            objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN.con_PaperRWId, strPaperRWId, "=");

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombinePaperSubViewpointConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvPaperSubViewpoint_Cond;
    }

    public CombinevPaperSubViewpointCondition4(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperRWId = $("#hidPaperRWId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.SectionId_q != "" && this.SectionId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
            }
            if (strPaperRWId != "") {
                strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
            }

            strWhereCond += " order by orderNum Asc";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    public CombinevPaperSubViewpointCondition5(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        return strWhereCond;
    }
    public async BindGv_vPaperSubViewpoint() {
        //var strListDiv: string = this.mstrListDiv;
        var strUserId = $("#hidUserId").val();
        var strPaperRWId = $("#hidPaperRWId").val();

        //var strWhereCond2 = this.CombinevPaperSubViewpointCondition2();
        var strWhereCond3 = this.CombinevPaperSubViewpointCondition3();

        var strWhereCond4 = this.CombinevPaperSubViewpointCondition4();
        var strWhereCond5 = this.CombinevPaperSubViewpointCondition5();

        //var strWhereCond6 = ` ${clsvPaperSubViewpointLikeLogEN.con_PaperRWId} = '${strPaperRWId}' And ${clsvPaperSubViewpointLikeLogEN.con_UpdUser} = '${strUserId}'`;


        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页




        var arrSubViewpointTypeObjLst: Array<clsSubViewpointTypeEN> = [];

        var arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN> = [];
        var arrvPaperSubViewpointObjLst2: Array<clsvPaperSubViewpointEN> = [];

        //获取图片
        var arrPaperSubAttachmentObjLst: Array<clsPaperSubAttachmentEN> = [];
        var arrPaperSubAttachmentObjLst2: Array<clsPaperSubAttachmentEN> = [];

        //获取点赞数据
        //var arrvPaperSubViewpointLikeLogObjLst: Array<clsvPaperSubViewpointLikeLogEN> = [];
        try {

            var objSubViewpointTypet_Cond: clsSubViewpointTypeEN = new clsSubViewpointTypeEN;
            if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                objSubViewpointTypet_Cond.SetCondFldValue(clsSubViewpointTypeEN.con_SubViewpointTypeId, this.SubViewpointTypeId_q, "=");
            }
            arrSubViewpointTypeObjLst = await SubViewpointType_GetSubObjLst_Cache(objSubViewpointTypet_Cond);

            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond3,
                orderBy: this.hidSortvPaperSubViewpointBy,
                sortFun: (x, y) => { return 0; }
            };
            //arrvPaperSubViewpointObjLst2 = vPaperSubViewpoint_GetObjLstByPager_WA_CacheAsync(objPagerPara);

            //const responseObjLst3 = await vPaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //    arrvPaperSubViewpointObjLst2 = <Array<clsvPaperSubViewpointEN>>jsonData;
            //});
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            const responseObjLst3 = await vPaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperSubViewpointObjLst2 = <Array<clsvPaperSubViewpointEN>>jsonData;
            });


            const responseRecCount4 = await PaperSubAttachment_GetObjLstAsync(strWhereCond5).then((jsonData) => {
                arrPaperSubAttachmentObjLst2 = <Array<clsPaperSubAttachmentEN>>jsonData;
            });

            //const responseRecCount6 = await vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond6).then((jsonData) => {
            //    arrvPaperSubViewpointLikeLogObjLst = <Array<clsvPaperSubViewpointLikeLogEN>>jsonData;
            //});
            var strhtml = "";
            //$('#divTwo li').remove();
            var cateid: number = 0;
            var cateid_: number = 0;

            var intJ: number = 0;
            $('#tbList tr').remove();
            for (var j = 0; j < arrSubViewpointTypeObjLst.length; j++) {
                cateid++;
                intJ++;
                var fid: number = 0;
                var strsubTypeId: string = arrSubViewpointTypeObjLst[j].subViewpointTypeId;
                //先创建子模块类型
                //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';

                //strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td><input type="checkbox" name="" lay-skin="primary"></td><td>' + cateid + '</td><td></td><td><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></td><td></td><td></td><td></td><td class="td-manage"><button class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '");><i class="layui-icon">&#xe642;</i>添加子栏目</button></td></tr>';
                //strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td><input type="checkbox" name="" lay-skin="primary"></td><td>' + cateid + '</td><td></td><td><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></td><td></td><td></td><td></td><td class="td-manage"></td></tr>';
                strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>' + cateid + '</td><td></td><td><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></td><td></td><td></td><td class="td-manage"></td></tr>';



                //子类型数据
                var strSubviewPointId = "";
                cateid_ = cateid;
                var intK: number = 0;

                arrvPaperSubViewpointObjLst = arrvPaperSubViewpointObjLst2.filter(x => x.subViewpointTypeId == strsubTypeId);

                for (var k = 0; k < arrvPaperSubViewpointObjLst.length; k++) {
                    strSubviewPointId = arrvPaperSubViewpointObjLst[k].subViewpointId;
                    //先判断子模块类型数据ID和子观点知否匹配；
                    //if (strsubTypeId == arrvPaperSubViewpointObjLst[k].subViewpointTypeId) {
                    cateid++;
                    intK++;

                    //strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '"><td><input type="checkbox" name="" lay-skin="primary"></td>';
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '">';
                    strhtml += '<td>' + cateid + '</td><td>' + arrvPaperSubViewpointObjLst[k].sectionName + '</td><td>&nbsp;&nbsp;&nbsp;&nbsp;' + intK + '.<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].rwTitle + '】' + arrvPaperSubViewpointObjLst[k].subViewpointContent + '';
                    arrPaperSubAttachmentObjLst = arrPaperSubAttachmentObjLst2.filter(x => x.subViewpointId == strSubviewPointId);
                    //根据子观点id 得到附件
                    for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {
                        //if (strSubviewPointId == arrPaperSubAttachmentObjLst[y].subViewpointId) {

                        var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" style="margin-left: 10px; " alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';
                        //}

                    }

                    if (arrvPaperSubViewpointObjLst[k].explainContent != "") {
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].explainTypeName + '】' + arrvPaperSubViewpointObjLst[k].explainContent + '';
                    }

                    //if (arrvPaperSubViewpointObjLst[k].literatureSourcesId != "") {



                    //strhtml += '</td><td><input id="txt_OrderNum' + cateid + '" type="text" class="layui-input x-sort" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click(' + arrvPaperSubViewpointObjLst[k].subViewpointId + ',"txt_OrderNum' + cateid + '");></td>';
                    var objUser = arrUsers.find(x => x.userId == arrvPaperSubViewpointObjLst[k].updUser);
                    if (objUser != null) {
                        strhtml += '</td><td> ' + objUser.userName + ' </td><td>' + arrvPaperSubViewpointObjLst[k].updDate + '</td><td class="td-manage" > ';
                    }
                    

                    strhtml += '&nbsp;&nbsp;<a href="#" style="color:royalblue" onclick="btnShowAppraise_Click(' + arrvPaperSubViewpointObjLst[k].subViewpointId + ')">评论数：' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a >';

                    if (arrvPaperSubViewpointObjLst[k].score == null) {
                        strhtml += '&nbsp;&nbsp;评分：0'
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;评分：' + arrvPaperSubViewpointObjLst[k].score + '';
                    }

                    strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = "btnShowAppraise_Click(' + arrvPaperSubViewpointObjLst[k].subViewpointId + ')" > <i class="layui-icon" >&#xe642; </i>添加评论</button >';



                    strhtml += '</td></tr>';


                    //}

                }


            }
            //拼接；
            $("#tbList").append(strhtml);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    /*查询*/
    public async btnQueryEx_Click() {

        try {
            const gvResult = await this.BindGv_vPaperSubViewpoint();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /**添加 */
    public async btnAddNewRecord_Click() {
        this.OpType = "Add";
        try {
            this.selectTitle_Click();

            const responseText = await this.AddNewRecord();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*
   上移
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
   */
    //public async btnUpMoveEx_Click(strKeyId: string) {
    //    if (this.PreCheck4Order() == false) return;
    //    var strSubViewpointTypeId: string = this.subViewpointTypeId;
    //    var strPaperRWId: string = $("#hidPaperRWId").val();
    //    var arrKeyIds = strKeyId;

    //    try {
    //        var objOrderByData: clsOrderByData = new clsOrderByData();
    //        objOrderByData.KeyIdLst.push(arrKeyIds);
    //        var jsonObject =
    //        {
    //            "subViewpointTypeId": strSubViewpointTypeId,
    //            "paperRWId": strPaperRWId,
    //        };
    //        var jsonStr: string = JSON.stringify(jsonObject);
    //        objOrderByData.ClassificationFieldValueLst = jsonStr;
    //        const responseRederBy = await PaperSubViewpoint_UpMoveAsync(objOrderByData);
    //    }
    //    catch (e) {
    //        var strMsg: string = `上移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
    //        alert(strMsg);
    //        return;
    //    }
    //    const responseBindGv = await this.BindGv_vPaperSubViewpoint();
    //}

    /*
  下移
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
  */
    //public async btnDownMove_Click(strKeyId: string) {
    //    if (this.PreCheck4Order() == false) return;
    //    var strSubViewpointTypeId: string = this.subViewpointTypeId;
    //    var strPaperRWId: string = $("#hidPaperRWId").val();
    //    var arrKeyIds = strKeyId;
    //    try {
    //        var objOrderByData: clsOrderByData = new clsOrderByData();
    //        //objOrderByData.KeyIdLst = arrKeyIds;
    //        objOrderByData.KeyIdLst.push(arrKeyIds);
    //        var jsonObject =
    //        {
    //            "subViewpointTypeId": strSubViewpointTypeId,
    //            "paperRWId": strPaperRWId,
    //        };
    //        var jsonStr: string = JSON.stringify(jsonObject);
    //        objOrderByData.ClassificationFieldValueLst = jsonStr;
    //        const responseRederBy = await PaperSubViewpoint_DownMoveAsync(objOrderByData);
    //    }
    //    catch (e) {
    //        var strMsg: string = `下移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
    //        alert(strMsg);
    //        return;
    //    }
    //    const responseBindGv = await this.BindGv_vPaperSubViewpoint();

    //}

    /* 在数据表里修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
  */
    public async btnUpdateOrderNum_Click(strKeyId: string, strOrderNum: string) {

        //var lngKeyId = Number(strKeyId);

        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        objPaperSubViewpointEN.subViewpointId = strKeyId;
        objPaperSubViewpointEN.orderNum = Number($("#" + strOrderNum + "").val());
        objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString;//设置哪些字段被修改(脏字段)

        if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperSubViewpoint_UpdateRecordAsync(objPaperSubViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //var strInfo: string = `修改排序号成功!`;
                        //$('#lblResult44').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);

                    }
                    else {
                        //var strInfo: string = `修改排序号不成功!`;
                        //$('#lblResult44').val(strInfo);
                        ////显示信息框
                        //alert(strInfo);
                        //console.log("完成UpdateRecordSave");
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

        //this.BindGv_vPaperSubViewpoint();
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
    }


    public async selectTitle_Click() {

        try {

            var objSubViewpointType: clsSubViewpointTypeEN;
            var strWhereCond = " subViewpointTypeId='" + this.subViewpointTypeId + "'";
            const responseRecCount = await SubViewpointType_GetFirstObjAsync(strWhereCond).then((jsonData) => {
                objSubViewpointType = <clsSubViewpointTypeEN>jsonData;
                this.rwTitle = objSubViewpointType.defaTitle;


            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取记录不成功,${e}.`;
            alert(strMsg);
        }
    }




    /// <summary>
    /// 为下拉框获取数据,从表:[Section]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_SectionId(ddlSectionId: string, strPaperId: string) {
        var strWhereCond = " 1 =1 and paperId='" + strPaperId + "'";
        var objDdl = document.getElementById(ddlSectionId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlSectionId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Section_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrSectionObjLst: Array<clsSectionEN> = <Array<clsSectionEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlSectionId, arrSectionObjLst, clsSectionEN.con_SectionId, clsSectionEN.con_SectionName, "论文节");
                    console.log("完成BindDdl_SectionId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }



    /*
    * 论文读写Id
   */
    // public set paperRWId(value: string) {
    //     $("#hidPaperRWId").val(value);
    // }
    // /*
    // * 论文读写Id
    //*/
    // public get paperRWId(): string {
    //     return $("#hidPaperRWId").val();
    // }

    /*
    * 修改用户Id
   */
    // public set updUser(value: string) {
    //     $("#hidUserId").val(value);
    // }
    // /*
    // * 修改用户Id
    //*/
    // public get updUser(): string {
    //     return $("#hidUserId").val();
    // }

    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjPaperSubViewpointEN">数据传输的目的类对象</param>
  */
    public PutDataToPaperSubViewpointClass(pobjPaperSubViewpointEN: clsPaperSubViewpointEN) {
        pobjPaperSubViewpointEN.paperRWId = $("#hidPaperRWId").val();// 论文读写Id

        pobjPaperSubViewpointEN.sectionId = this.sectionId;//节
        pobjPaperSubViewpointEN.subViewpointTypeId = this.subViewpointTypeId;// 类型Id
        pobjPaperSubViewpointEN.rwTitle = this.rwTitle;// 读写标题

        pobjPaperSubViewpointEN.subViewpointContent = this.subViewpointContent;// 详情内容
        pobjPaperSubViewpointEN.explainTypeId = this.explainTypeId;// 说明类型Id
        pobjPaperSubViewpointEN.explainContent = this.explainContent;// 说明内容
        pobjPaperSubViewpointEN.isPublic = this.isPublic;// 是否公开
        pobjPaperSubViewpointEN.literatureSourcesId = this.literatureSourcesId;// 文献来源
        pobjPaperSubViewpointEN.pageNumber = this.pageNumber;// 页码
        pobjPaperSubViewpointEN.orderNum = this.orderNum;// 序号

      
        pobjPaperSubViewpointEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改用户Id

        //pobjPaperSubViewpointEN.updUser = $("#hidUserId").val();// 修改用户Id
        pobjPaperSubViewpointEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjPaperSubViewpointEN.memo = this.memo;// 备注
    }


   
    /* 添加评论
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    //public async SubmitAppraise_Click() {
    //    this.DivName = "divAddNewRecordSave";
    //    var objPaperSubViewpointAppraiseEN: clsPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
    //    //this.PutDataToPaperSubViewpointAppraiseClass(objPaperSubViewpointAppraiseEN);
    //    objPaperSubViewpointAppraiseEN.subViewpointId = $("#hidSubViewpointId").val();
    //    var strvalue = $("#pin").val();
    //    //判断是否有打分 
    //    if (strvalue != "" && strvalue != undefined) {

    //        //请输入评论
    //        if ($("#txtAppraiseContent").val() != "") {
    //            //获取值转化分数
    //            var strScore: string = this.GetScorebyText(strvalue);
    //            objPaperSubViewpointAppraiseEN.AppraiseScore = Number(strScore);// 打分
    //            objPaperSubViewpointAppraiseEN.AppraiseContent = $("#txtAppraiseContent").val();// 评议内容
    //            objPaperSubViewpointAppraiseEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
    //            objPaperSubViewpointAppraiseEN.updUser = $("#hidUserId").val();// 修改用户Id
    //            try {
    //                const responseText2 = await PaperSubViewpointAppraise_AddNewRecordAsync(objPaperSubViewpointAppraiseEN);
    //                var returnBool: boolean = !!responseText2;
    //                if (returnBool == true) {
    //                    var strInfo: string = `添加评论成功!`;
    //                    $('#lblResult40').val(strInfo);
    //                    //显示信息框
    //                    alert(strInfo);
    //                    HideDialog3();
    //                    const responseBindGv = await this.BindGv_vPaperSubViewpoint();
    //                    this.btnShowAppraise_Click();
    //                }
    //                else {
    //                    var strInfo: string = `添加评论不成功!`;
    //                    $('#lblResult40').val(strInfo);
    //                    //显示信息框
    //                    alert(strInfo);
    //                    HideDialog3();
    //                    //this.BindGv_vPaperSubViewpoint();
    //                    this.btnShowAppraise_Click();
    //                }
    //                $("#btnOKUpdAppraise").attr("disabled", false);
    //                return responseText2;//一定要有一个返回值，否则会出错！
    //            }
    //            catch (e) {
    //                console.error('catch(e)=');
    //                console.error(e);
    //                var strMsg: string = `添加评论不成功,${e}.`;
    //                alert(strMsg);
    //            }
    //        }
    //        else {

    //            var strInfo: string = `请输入评价内容!`;
    //            //显示信息框
    //            alert(strInfo);
    //            return;
    //        }


    //    }
    //    else {
    //        var strInfo: string = `请选择评分!`;
    //        //显示信息框
    //        alert(strInfo);
    //        return;
    //    }

    //    return true;//一定要有一个返回值，否则会出错！
    //}

    //通过得到的值判断，得到分数
    public GetScorebyText(sValue: string) {

        var Score: string = "";
        if (sValue == "1") {
            Score = "2";
        }
        else if (sValue == "2") {
            Score = "4";
        }
        else if (sValue == "一3") {
            Score = "6";
        }
        else if (sValue == "4") {
            Score = "8";
        }
        else {
            Score = "10";
        }
        return Score;
    }


    //显示评论
    //public async btnShowAppraise_Click() {
    //    var arrvPaperSubViewpointAppraiseObjLst: Array<clsvPaperSubViewpointAppraiseEN> = [];

    //    var strWhereCond = " subViewpointId=" + $("#hidSubViewpointId").val();
    //    try {
    //        const responseText = vPaperSubViewpointAppraise_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //            arrvPaperSubViewpointAppraiseObjLst = <Array<clsvPaperSubViewpointAppraiseEN>>jsonData;

    //            //var strhtml = "";
    //            //var cateid: number = 0;
    //            //$('#AppraiseList tr').remove();
    //            //for (var i = 0; i < arrvPaperSubViewpointAppraiseObjLst.length; i++) {
    //            //    cateid++;
    //            //    strhtml += '<tr><td>' + cateid + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].AppraiseContent + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].AppraiseScore + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].userName + '</td><td>' + arrvPaperSubViewpointAppraiseObjLst[i].updDate + '</td><td class="td-manage"></td></tr>';
    //            //}
    //            //$("#AppraiseList").append(strhtml);

    //            var strhtml = "";
    //            var varNum = 0;
    //            $('#J_ShortComment div').remove();
    //            for (var i = 0; i < arrvPaperSubViewpointAppraiseObjLst.length; i++) {
    //                //strhtml += '<tr><td>' + cateid + '</td><td>' + arrvDiscussionSubContentObjLst[i].AppraiseContent + '</td><td>' + arrvDiscussionSubContentObjLst[i].AppraiseScore + '</td><td>' + arrvDiscussionSubContentObjLst[i].userName + '</td><td>' + arrvDiscussionSubContentObjLst[i].updDate + '</td><td class="td-manage"></td></tr>';
    //                varNum++;
    //                strhtml += '<div class="comment" id = "J_Comment6631028263006567418"><div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div><div class="comment-block" id="J_CommentBlock6631028263006567418"><p class="comment-user" >';
    //                if ($("#hidViewpointUserId").val() == arrvPaperSubViewpointAppraiseObjLst[i].updUser) {
    //                    strhtml += '<span class="comment-username J_User" data-userid="17755842" style="color:red;">楼主：' + arrvPaperSubViewpointAppraiseObjLst[i].userName + '</span>';
    //                } else {
    //                    strhtml += '<span class="comment-username J_User" data-userid="17755842">' + arrvPaperSubViewpointAppraiseObjLst[i].userName + '</span>';
    //                }


    //                strhtml += '<span class="comment-time">' + arrvPaperSubViewpointAppraiseObjLst[i].updDate + '</span></p>';
    //                strhtml += '<div class="comment-content J_CommentContent">' + varNum + '楼</div>';
    //                strhtml += '<div class="comment-content J_CommentContent">' + arrvPaperSubViewpointAppraiseObjLst[i].AppraiseContent + '</div></div></div>';
    //            }
    //            $("#J_ShortComment").append(strhtml);

    //        });


    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `获取数据不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //}

    //是否显示

    public async btnIsDisplay_Click() {
        if (this.IsDisplay == "显示论文") {
            this.IsDisplay = "隐藏论文";
            $("#tabwucPaperReadWrite").show();
        }
        else if (this.IsDisplay == "隐藏论文") {
            this.IsDisplay = "显示论文";
            $("#tabwucPaperReadWrite").hide();
        }

    }



    //下载文件
    public btnDownLoadFile_Click() {

        this.GetPaperAttachmentRecord();
        this.btnAddDownload_Click();
    }


    public GetPaperAttachmentRecord() {
        var strPapeId = $("#hidPaperId").val();
        //this.KeyId = strPaperRWId;
        var strWhereCond = ` ${clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
        var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
        try {
            const responseText = PaperAttachment_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrPaperAttachmentObjLst = <Array<clsPaperAttachmentEN>>jsonData;
                for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {

                    var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                    doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
                }
            });

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }



    }

    //添加下载量
    public async btnAddDownload_Click() {
        //this.DivName = "divAddNewRecordSave";
        var objPaperDownloadLogEN: clsPaperDownloadLogEN = new clsPaperDownloadLogEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objPaperDownloadLogEN.paperId = $("#hidPaperId").val();
        objPaperDownloadLogEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        objPaperDownloadLogEN.updUser = $("#hidUserId").val();// 修改用户Id
        var strWhereCond = " 1 =1 and updUser='" + objPaperDownloadLogEN.updUser + "' and paperId=" + objPaperDownloadLogEN.paperId;
        try {
            //const responseText = await PaperDownloadLog_IsExistRecordAsync(strWhereCond);
            //var bolIsExist: boolean = responseText;
            //if (bolIsExist == true) {
            //    //var strMsg: string = `您已经收藏过这条论文了！`;
            //    //alert(strMsg);
            //    return responseText;//一定要有一个返回值，否则会出错！
            //}

            const responseText2 = await PaperDownloadLog_AddNewRecordAsync(objPaperDownloadLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //var strInfo: string = `收藏成功!`;
                //$('#lblResult40').val(strInfo);
                ////显示信息框
                //alert(strInfo);

                //this.BindGv_vPaperSubViewpoint();
            }
            else {
                var strInfo: string = `添加下载量不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加下载量不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }



    /*
* 获取年月日
*/
    public getNowDate(): string {
        const date = new Date();
        let month: string | number = date.getMonth() + 1;
        let strDate: string | number = date.getDate();
        if (month <= 9) {
            month = "0" + month;
        }
        if (strDate <= 9) {
            strDate = "0" + strDate;
        }

        return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
    }

    /*
   * 设置排序
   */
    public set IsDisplay(value: string) {
        $("#btnIsDisplay").html(value);
    }
    /*
    * 获取排序
    */
    public get IsDisplay(): string {
        return $("#btnIsDisplay").html();
    }
}