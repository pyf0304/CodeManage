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
import { PaperSubViewpoint_QUDI_TS } from "../GraduateEduPaper/PaperSubViewpoint_QUDI_TS.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperDownloadLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperSubAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js";
import { clsPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js";
import { clsSectionEN } from "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsvPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsExplainTypeEN } from "../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js";
import { clsgs_PaperSubViewsAttitudesEN } from "../TS/L0_Entity/ParameterTable/clsgs_PaperSubViewsAttitudesEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsSubViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { PaperAttachment_GetFirstObjAsync, PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { PaperDownloadLog_AddNewRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperDownloadLogWApi.js";
import { PaperSubAttachment_AddNewRecordAsync, PaperSubAttachment_DelPaperSubAttachmentsByCondAsync, PaperSubAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js";
import { PaperSubViewpoint_DelRecordAsync, PaperSubViewpoint_DownMoveAsync, PaperSubViewpoint_GetRecCountByCondAsync, PaperSubViewpoint_ReOrderAsync, PaperSubViewpoint_UpdateRecordAsync, PaperSubViewpoint_UpMoveAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js";
import { Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { Section_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js";
import { vPaperSubViewpoint_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { vPaper_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { SysComment_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { SysVote_AddNewRecordAsync, SysVote_GetObjLstAsync, SysVote_GetRecCountByCondAsync, SysVote_IsExistRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { ExplainType_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js";
import { gs_PaperSubViewsAttitudes_BindDdl_AttitudesIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_PaperSubViewsAttitudesWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { SubViewpointType_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { PaperSubViewpointEx_AddNewRecordWithReturnKeyAsyncEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsPaperSubViewpointExWApi.js";
import { vPaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { vPaperSubViewpointEx_GetSubViewpointTypeNumObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperSubViewpointExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsOrderByData } from "../TS/PubFun/clsOrderByData.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { clsSysPara4WebApi2 } from "../TS/PubFun/clsSysPara4WebApi2.js";
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
export class PaperSubViewpoint_pdf extends PaperSubViewpoint_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 50;
    }


    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {


                $("#hidUserId").val(clsPubSessionStorage.GetSession_UserId());
                $("#hidRoleId").val(clsPubSessionStorage.GetSession_RoleId());

                //1、为下拉框设置数据源,绑定列表数据

                if ($('#hidid_CurrEduCls').val() == "") {
                    $('#hidid_CurrEduCls').val(clsPublocalStorage.Getid_CurrEduCls());
                }

                var strPaperId = $("#hidPaperId").val();
                const ddl_SectionId_q = await this.BindDdl_SectionId("ddlSectionId_q", strPaperId);
                const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId", strPaperId);


                const ddl_SubViewpointTypeId_q = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId_q");
                //const ddl_ExplainTypeId_q = await this.BindDdl_ExplainTypeId("ddlExplainTypeId_q");
                const ddl_SubViewpointTypeId = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId");

                const ddl_ExplainTypeId = await this.BindDdl_ExplainTypeId("ddlExplainTypeId");

                this.hidSortvPaperSubViewpointBy = "subViewpointTypeName Asc";


                var strRoleId = clsPubSessionStorage.GetSession_RoleId();
                //判断角色
                //学生
                if (strRoleId == "00620003") {
                    if ($("#hidTopicId").val() != "") {
                        $("#liTeaTest_QA").show();
                    } else {
                        $("#liTeaTest_QA").hide();
                    }
                }
                else {
                    $("#liTeaTest_QA").show();
                }
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //绑定pdf_Ifame
                const gvResult1 = await this.BindPdf();

                const gvResult2 = await this.li_PaperMenu_Click();

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


    public async li_PaperMenu_Click() {



        //如果是点击了树菜单、或者是刷新，那么需要做样式控制；
        //首先要去掉ul下 li a 样式
        $("#tabMenu li a").removeClass();
        $("#tabMenu li a").addClass("nav-link");

        $("#Paper_SubViewpoint").removeClass();
        $("#Paper_QA").removeClass();
        $("#Paper_Tags").removeClass();
        $("#Tea_QA").removeClass();

        $("#Paper_SubViewpoint").addClass("tab-pane fade");
        $("#Paper_QA").addClass("tab-pane fade");
        $("#Paper_Tags").addClass("tab-pane fade");
        $("#Tea_QA").addClass("tab-pane fade");

        //判断根据序号显示不同的数据源
        var strnum = $("#hidTabNum").val();


        if (strnum == "1") {
            //$("#liUser").addClass("active");
            $("#liPaper_SubViewpoint a").addClass("active");

            $("#Paper_SubViewpoint").addClass("active show");

            //主题用户关系；
            //论文摘要
            const gvResult1 = await this.Bind_PaperContent();
            //绑定论文子观点
            const gvResult2 = await this.BindGv_vPaperSubViewpoint();
        }
        else if (strnum == "2") {
            $("#liPaper_QA a").addClass("active");

            $("#Paper_QA").addClass("active show");

            $("#iframe_qaPdf").contents().find("#hidIsQA_Tags").val(1);
            //主题论文关系；
            const gvResult = await this.Bind_Paper_QA();
        }
        else if (strnum == "3") {
            $("#liPaper_Tags a").addClass("active");

            $("#Paper_Tags").addClass("active show");

            $("#iframe_qaPdf").contents().find("#hidIsQA_Tags").val(2);
            //主题论文关系；
            const gvResult = await this.Bind_Paper_Tags();
        }
        else if (strnum == "4") {
            $("#liTea_QA a").addClass("active");

            $("#Tea_QA").addClass("active show");
            //主题论文关系；
            const gvResult = await this.Bind_Tea_QA();
        }
        else if (strnum == "5") {
            $("#liTeaTest_QA a").addClass("active");

            $("#TeaTest_QA").addClass("active show");
            //主题论文关系；
            const gvResult = await this.Bind_TeaTest_QA();
        }
        else {
            const gvResult = await this.Bind_PaperContent();
        }
    }

    //绑定pdf_Ifame
    public async BindPdf() {
        try {
            //clsPrjInfoEN objPrjInfo = clsPrjInfoBL.GetObjByPrjID_Cache(strPrjId);

            var strPaperId = $("#hidPaperId").val();
            var objPaperAttachment: clsPaperAttachmentEN;
            var strWhereCond = " 1=1 and paperId ='" + strPaperId + "'";
            const responseText = await PaperAttachment_GetFirstObjAsync(strWhereCond);
            objPaperAttachment = <clsPaperAttachmentEN>responseText;

            var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
            var strhtml = "";
            if (objPaperAttachment != null) {
                var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                strhtml = "<iframe id='iframe_qaPdf' scrolling='auto' src='../GraduateEduEx/qaPdf?zoom=1.1&file=" + strfilepath + "' style=\"height:100%;width:100%; height:730px;\"></iframe>";

            } else {
                strhtml = "<iframe id='iframe_qaPdf' scrolling='auto' src='../GraduateEduEx/qaPdf?zoom=1.1' style=\"height:100%;width:100%; height:730px;\"></iframe>";
            }

            $("#leftPart").html(strhtml);

        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }


    }

    //绑定Paper_QA
    public async Bind_Paper_QA() {
        try {
            var strPaperId = $("#hidPaperId").val();
            var strQuestionsId = $("#hidQuestionsId").val();
            var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
            var strPushId = $("#hidPushId").val();

            var varLink = "";
            if (strQuestionsId != "") {
                if (strPushId != "") {
                    varLink = '../InteractManage/Paper_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&questionsId=' + strQuestionsId + '&pushId=' + strPushId;
                } else {
                    varLink = '../InteractManage/Paper_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&questionsId=' + strQuestionsId;
                }


            }
            else {
                varLink = '../InteractManage/Paper_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls;
            }

            //var strhtml = "<iframe id='iframe_Paper_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='../InteractManage/Paper_QA?paperId=" + strPaperId + "' style='height:100%;width:99%; min-height:650px;'></iframe>";
            var strhtml = "<iframe id='iframe_Paper_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='" + varLink + "' style='height:100%;width:100%; height:730px;'></iframe>";

            $("#Paper_QA").html(strhtml);
        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }
    }

    //绑定Paper_Tags
    public async Bind_Paper_Tags() {
        try {
            var strPaperId = $("#hidPaperId").val();
            var strid_CurrEduCls = $("#hidid_CurrEduCls").val();

            var strhtml = "<iframe id='iframe_Paper_Tags'  frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes'  src='../InteractManage/Paper_Tags?paperId=" + strPaperId + "&id_CurrEduCls=" + strid_CurrEduCls + "' style='height:100%;width:100%; height:730px;'></iframe>";

            $("#Paper_Tags").html(strhtml);
        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }
    }


    //绑定Tea_QA
    public async Bind_Tea_QA() {
        try {
            var strPaperId = $("#hidPaperId").val();
            var strQuestionsId = $("#hidQuestionsId").val();
            var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
            var strTopicId = $('#hidTopicId').val();
            var varLink = "";
            if (strQuestionsId != "") {
                varLink = '../InteractManage/Tea_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&questionsId=' + strQuestionsId;
            }
            else {
                if (strTopicId != "") {
                    varLink = '../InteractManage/Tea_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&topicId=' + strTopicId;
                }
                else {
                    varLink = '../InteractManage/Tea_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls;
                }
            }

            //var strhtml = "<iframe id='iframe_Tea_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='../InteractManage/Paper_QA?paperId=" + strPaperId + "' style='height:100%;width:99%; min-height:650px;'></iframe>";
            var strhtml = "<iframe id='iframe_Tea_QA' frameborder='no' border='0' scrolling='auto' src='" + varLink + "' style='width:100%; height:730px;'></iframe>";

            $("#Tea_QA").html(strhtml);
        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }
    }

    //绑定Bind_TeaTest_QA
    public async Bind_TeaTest_QA() {
        try {
            var strPaperId = $("#hidPaperId").val();
            var strQuestionsId = $("#hidQuestionsId").val();
            var strid_CurrEduCls = $("#hidid_CurrEduCls").val();
            var strTopicId = $('#hidTopicId').val();
            var varLink = "";
            if (strQuestionsId != "") {
                varLink = '../InteractManage/TeaTest_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&questionsId=' + strQuestionsId;
            }
            else {
                if (strTopicId != "") {
                    varLink = '../InteractManage/TeaTest_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls + '&topicId=' + strTopicId;
                }
                else {
                    varLink = '../InteractManage/TeaTest_QA?paperId=' + strPaperId + '&id_CurrEduCls=' + strid_CurrEduCls;
                }
            }

            //var strhtml = "<iframe id='iframe_Tea_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='../InteractManage/Paper_QA?paperId=" + strPaperId + "' style='height:100%;width:99%; min-height:650px;'></iframe>";
            var strhtml = "<iframe id='iframe_TeaTest_QA' frameborder='no' border='0' marginwidth='0' marginheight='0' scrolling='auto' allowtransparency='yes' src='" + varLink + "' style='height:100%;width:100%; min-height:700px;'></iframe>";

            $("#TeaTest_QA").html(strhtml);
        }
        catch (e) {
            var strMsg: string = `获取数据有问题,${e}.`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 为下拉框获取数据,从表:[SubViewpointType]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_SubViewpointTypeId(ddlSubViewpointTypeId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlSubViewpointTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlSubViewpointTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                //const responseText = SubViewpointType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                const responseText = SubViewpointType_GetObjLst_Cache().then((jsonData) => {
                    var arrSubViewpointTypeObjLst: Array<clsSubViewpointTypeEN> = <Array<clsSubViewpointTypeEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlSubViewpointTypeId, arrSubViewpointTypeObjLst, clsSubViewpointTypeEN.con_SubViewpointTypeId, clsSubViewpointTypeEN.con_SubViewpointTypeName, "子观点类型");
                    console.log("完成BindDdl_SubViewpointTypeId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /// <summary>
    /// 为下拉框获取数据,从表:[ExplainType]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_ExplainTypeId(ddlExplainTypeId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlExplainTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlExplainTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                //const responseText = ExplainType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                const responseText = ExplainType_GetObjLst_Cache().then((jsonData) => {
                    var arrExplainTypeObjLst: Array<clsExplainTypeEN> = <Array<clsExplainTypeEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlExplainTypeId, arrExplainTypeObjLst, clsExplainTypeEN.con_ExplainTypeId, clsExplainTypeEN.con_ExplainTypeName, "说明类型");
                    console.log("完成BindDdl_ExplainTypeId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    public async Bind_PaperContent() {



        //var strWhereCond = " paperId = " + strPaperId;
        //var objvPaperReadWrite: clsvPaperReadWriteEN = new clsvPaperReadWriteEN;

        //const responseObjLst = await vPaperReadWrite_GetFirstObjAsync(strWhereCond).then((jsonData) => {
        //    objvPaperReadWrite = <clsvPaperReadWriteEN>jsonData;
        //});




        var strPaperId = $("#hidPaperId").val();


        var objvPaper_Cond: clsvPaperEN = new clsvPaperEN();//查询区域
        //var objvPaper: clsvPaperEN = null;
        //objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_PaperId, strPaperId, "=");
        //var objvPaper: clsvPaperEN = await vPaper_GetObjByPaperId_Cache(strPaperId, strid_CurrEducls);
        var objvPaper: clsvPaperEN = await vPaper_GetFirstObjAsync("paperId='" + strPaperId + "'");
        ////获取用户缓存数据
        //var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

        //$("#hidIsSubmit").val(objvPaper.isSubmit);//是否提交

        var strhtml = "";
        //var strWhereCond1 = " 1=1 and paperId ='" + strPaperId + "'";
        //var strWhereCond2 = " 1=1 and paperId ='" + strPaperId + "' and updUser='" + $("#hidUserId").val() + "'";

        try {
            //const responseText1 = await vPaperCount_GetFirstObjAsync(strWhereCond1);
            //objvPaperCount = <clsvPaperCountEN>responseText1;

            //const responseText2 = await PaperLikeLog_GetFirstObjAsync(strWhereCond2);
            //objPaperLikeLog = <clsPaperLikeLogEN>responseText2;

            //const responseText3 = await PaperCollectionLog_GetFirstObjAsync(strWhereCond2);
            //objPaperCollectionLog = <clsPaperCollectionLogEN>responseText3;

            var strTitle = objvPaper.paperTitle + '(作者:' + objvPaper.author + '-提交者:' + objvPaper.userName + ')';

            $("#spanPaperContent").html(strTitle);

            var strhtml = "";
            //for (var i = 0; i < arrvPaperObjLst.length; i++) {

            strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';

            if (objvPaper.paperTypeId == "02") {
                strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + objvPaper.paperId + '">' + objvPaper.paperTitle + '(' + objvPaper.paperTypeName + ')</a></h6>';

            }
            else {

                //自研论文
                strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + objvPaper.paperId + '">' + objvPaper.paperTitle + '</a></h6>';

            }



            strhtml += '<div class="baseinfo"><span><a href="#">' + objvPaper.author + '</a></span><span><a href="#">' + objvPaper.literatureSources + '</a></span>';
            strhtml += '<span>' + objvPaper.periodical + '</span><em>' + objvPaper.keyword + '</em></div>';
            strhtml += '<div class="abstract">' + objvPaper.paperContent + '</div>';

            strhtml += '<div class="opts"><ul class="opts-count">';
            //var objUser = arrUsers.find(x => x.userId == objvPaper.updUser);
            //if (objUser != null) {
            //    strhtml += '<li>论文读写者:<em>' + objUser.userName + '</em></li>';
            //}
            strhtml += '<li>论文提交者:<em>' + objvPaper.userName + '</em></li>';
            //strhtml += '<li>观点数:<em>' + pobjvPaperReadWriteEN.subVCount + '</em></li><li>教师分:<em>' + pobjvPaperReadWriteEN.teaCount + '</em></li>';

            strhtml += '<ul class="opts-btn">';




            if (objvPaper.attachmentCount > 0) {
                strhtml += '<li>' + objvPaper.downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click()><i></i><b>点击下载</b></a></li>';
            } else {
                strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
            }

            strhtml += '</ul></div>';
            strhtml += '</dd></dl></div>';
            //}


            $("#tabwucPaperReadWrite").html(strhtml);



        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }

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
                    const returnBool = await this.AddNewRecordSaves();
                    //var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        HideDialog();
                        //this.btnReOrder_Click();
                        //this.BindGv_vPaperSubViewpoint();
                        //BindGv_vPaperSubViewpoint
                    }

                        //var returnBool: boolean = jsonData;
                        //if (returnBool == true) {
                        //    HideDialog();
                        //    this.BindGv_vPaperSubViewpoint();

                        //}
                    

                    const BingGv = await this.BindGv_vPaperSubViewpoint();
                    const UpdateRest = await this.SynSubV();

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
                    //添加成功后把数据同步到总表
                    var strSubViewpointId = $('#hidKeyId').val();
                    const responseText5 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSubViewpointId, "03", "2", this.Id_CurrEduCls);
                    var returnBool5: boolean = !!responseText5;
                    if (returnBool5 == true) {
                        console.log("论文子观点数据总表同步成功；");
                    }
                    else {
                        console.log("论文子观点数据总表同步失败；");
                    }

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
    public async AddNewRecordSaves():Promise<boolean> {
        console.error('PaperSubViewpoint_pdf-AddNewRecordSaves()');
        this.DivName = "divAddNewRecordSave";
        var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
        //创建时间
        objPaperSubViewpointEN.createDate = clsPubFun4Web.getNowDate_ymd();
        this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        try {
            //const responseText2 = await PaperSubViewpoint_AddNewRecordAsync(objPaperSubViewpointEN);
            const returnKey = await PaperSubViewpointEx_AddNewRecordWithReturnKeyAsyncEx(objPaperSubViewpointEN);

            if (returnKey != "") {

                //存放主键；
                $("#hidKeyId").val(returnKey);
                //$("#hidSubViewpointId").val(returnString);

                //判断是否有返回的附件路径值
                if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    var fileOne = $("#hdnFileOne").val();
                    await this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                }
                else {
                    if ($("#hdnFileTwo").val() != "") {
                        var fileTwo = $("#hdnFileTwo").val();
                        await this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    }
                    else {
                        if ($("#hdnFileThree").val() != "") {
                            var fileThree = $("#hdnFileThree").val();
                            await this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }

                }

                //var strPaperId = objPaperSubViewpointEN.paperId;
                ////添加记录的同时并记录论文读写的教师评价数
                //var strWhereCond = " paperId=" + strPaperId;
                //var intSubVCount = await PaperSubViewpoint_GetRecCountByCondAsync(strWhereCond);

                //var objPaperEN: clsPaperEN = new clsPaperEN();
                //objPaperEN.paperId = strPaperId;
                //objPaperEN.subVCount = intSubVCount;

                //objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                //if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                //    throw "关键字不能为空!";
                //}

                //const responseText = await Paper_UpdateRecordAsync(objPaperEN);
                //var returnBool: boolean = !!responseText;
                //if (returnBool == true) {
                //    console.log("统计论文子观点数量成功！");
                //    //刷新缓存
                //    vPaper_ReFreshThisCache($("#hidid_CurrEduCls").val());
                //}
                //else {

                //    console.log("统计论文子观点数量失败！");
                //}
                ////添加记录的同时并记录论文读写的教师评价数

                ////添加成功后把数据同步到总表
                //var strSubViewpointId = $('#hidKeyId').val();
                //const responseText2 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSubViewpointId, "03", "1");
                //var returnBool2: boolean = !!responseText2;
                //if (returnBool2 == true) {
                //    console.log("论文子观点数据总表同步成功；");
                //}
                //else {
                //    console.log("论文子观点数据总表同步失败；");
                //}


                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                this.Clear();

                return true;//一定要有一个返回值，否则会出错！
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            this.Clear();
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
                        await this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    }
                    else {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            await this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }
                }
                else if (strfileNum == "two") {
                    //为空则判断第三个附件值；
                    if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                        var fileThree = $("#hdnFileThree").val();
                        await this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
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
        //判断地址不为空则执行截取操作
        if (strfilePath != "") {
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjPaperSubAttachmentEN.filePath = filePath;

            pobjPaperSubAttachmentEN.paperSubAttachmentName = strfilePath;
        }
        pobjPaperSubAttachmentEN.updDate = clsPubFun4Web.getNowDate();// 修改日期

        pobjPaperSubAttachmentEN.id_CurrEduCls = $("#hidid_CurrEduCls").val();//教学班
        pobjPaperSubAttachmentEN.paperRWId = $("#hidPaperRWId").val();//读写Id
        pobjPaperSubAttachmentEN.updUserId = clsPubSessionStorage.GetSession_UserId();// 修改用户Id


    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public async UpdateRecordSave(): Promise<boolean> {
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
                //const responseText = PaperSubViewpointEx_UpdateRecordAsyncEx(objPaperSubViewpointEN).then((jsonData) => {
                const responseText = PaperSubViewpoint_UpdateRecordAsync(objPaperSubViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //存放主键;
                        $("#hidKeyId").val(objPaperSubViewpointEN.subViewpointId);



                        //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                        if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
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
                return false;
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



    //同步子观点到论文表
    public async SynSubV() {
        var strPaperId = $("#hidPaperId").val();
        //添加记录的同时并记录论文读写的教师评价数
        var strWhereCond = " paperId=" + strPaperId;
        var intSubVCount = await PaperSubViewpoint_GetRecCountByCondAsync(strWhereCond);

        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = strPaperId;
        objPaperEN.subVCount = intSubVCount;

        objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw "关键字不能为空!";
        }

        const responseText = await Paper_UpdateRecordAsync(objPaperEN);
        var returnBool: boolean = !!responseText;
        if (returnBool == true) {
            console.log("统计论文子观点数量成功！");
            //刷新缓存
            vPaperEx_ReFreshThisCacheById_CurrEduCls($("#hidid_CurrEduCls").val());
        }
        else {

            console.log("统计论文子观点数量失败！");
        }
        //添加记录的同时并记录论文读写的教师评价数

        //添加成功后把数据同步到总表
        var strSubViewpointId = $('#hidKeyId').val();
        const responseText2 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSubViewpointId, "03", "1", this.Id_CurrEduCls);
        var returnBool2: boolean = !!responseText2;
        if (returnBool2 == true) {
            console.log("论文子观点数据总表同步成功；");
        }
        else {
            console.log("论文子观点数据总表同步失败；");
        }

    }

    /* 为插入记录做准备工作
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
  */
    public AddNewRecord() {

        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucPaperSubViewpointB1.subViewpointId = clsPaperSubViewpointBL.GetMaxStrId_S();
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
        //var strPaperRWId = $("#hidPaperRWId").val();
        var strPaperId = $("#hidPaperId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.SectionId_q != "" && this.SectionId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
            }
            //if (strPaperRWId != "") {
            //    strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
            //}
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_PaperId} = '${strPaperId}'`;
            }

            if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
            }

            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();

            if (strRoleId == "00620001") {

                //$("#btnDelRecord").show();
            }
            else if (strRoleId == "00620002") {

                //可以查看所有；
            }
            else {
                if ($("#hidType").val() == "01") {
                    strWhereCond += " And updUser = '" + strUserId + "'";
                }

                //学生00620003
                //只能查看自己的数据；或公开的数据；
                //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;

                //strWhereCond += ` And updUser = '${objvUserRoleRelation.userId}'`;
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

    public CombinevPaperSubViewpointCondition4(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //var strPaperRWId = $("#hidPaperRWId").val();
        var strPaperId = $("#hidPaperId").val();
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.SectionId_q != "" && this.SectionId_q != "0") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
            }
            //if (strPaperRWId != "") {
            //    strWhereCond += ` And ${clsPaperReadWriteEN.con_PaperRWId} = '${strPaperRWId}'`;
            //}
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvPaperSubViewpointEN.con_PaperId} = '${strPaperId}'`;
            }

            if ($("#hidType").val() == "01") {
                strWhereCond += " And updUser = '" + strUserId + "'";
            }


            strWhereCond += " order by orderNum Asc";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //public CombinevPaperSubViewpointCondition5(): string {
    //    //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
    //    //例如 1 = 1 && userName = '张三'
    //    var strWhereCond: string = " 1 = 1 ";
    //    return strWhereCond;
    //}
    public async BindGv_vPaperSubViewpoint() {
        //var strListDiv: string = this.mstrListDiv;
        var strUserId = $("#hidUserId").val();
        //var strPaperRWId = $("#hidPaperRWId").val();
        var strid_CurrEduCls = $("#hidid_CurrEduCls").val();

        var strWhereCond2 = this.CombinevPaperSubViewpointCondition3();
        var strWhereCond3 = this.CombinevPaperSubViewpointCondition3();
        if ($("#hidSortPsv").val() == 1) {
            strWhereCond3 += " order by paperPageNum Asc";
        } else {
            strWhereCond3 += " order by updDate Desc";
        }
        //strWhereCond3 += this.CombinevPaperSubViewpointCondition3();
        var strWhereCond4 = this.CombinevPaperSubViewpointCondition4();
        var strWhereCond5 = " 1=1 and id_CurrEduCls='" + strid_CurrEduCls + "'";

        //var strWhereCond6 = ` ${clsvSysVoteEN.con_TableKey} = '${strPaperRWId}' And ${clsvSysVoteEN.con_UpdUser} = '${strUserId}'`;
        //var strWhereCond6 = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='02' and pubParentId='" + strPaperRWId + "'";
        var strWhereCond6 = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='02' ";
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页


        var arrSectionObjLst: Array<clsSectionEN> = [];



        //var arrSubViewpointTypeObjLst: Array<clsSubViewpointTypeEN> = [];

        var arrvPaperSubVTypeNumObjLst: Array<clsvPaperSubViewpointEN> = [];

        var arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN> = [];

        var arrvPaperSubViewpointObjLst2: Array<clsvPaperSubViewpointEN> = [];

        //获取图片
        var arrPaperSubAttachmentObjLst: Array<clsPaperSubAttachmentEN> = [];
        var arrPaperSubAttachmentObjLst2: Array<clsPaperSubAttachmentEN> = [];
        //获取点赞数据
        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        try {

            //const responseText1 = Section_GetObjLstAsync(strWhereCond4).then((jsonData) => {
            //    arrSectionObjLst = <Array<clsSectionEN>>jsonData;


            //});




            const responseText2 = vPaperSubViewpointEx_GetSubViewpointTypeNumObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvPaperSubVTypeNumObjLst = <Array<clsvPaperSubViewpointEN>>jsonData;
            });

            const responseObjLst3 = await vPaperSubViewpoint_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                arrvPaperSubViewpointObjLst2 = <Array<clsvPaperSubViewpointEN>>jsonData;
            });

            const responseRecCount4 = await PaperSubAttachment_GetObjLstAsync(strWhereCond5).then((jsonData) => {
                arrPaperSubAttachmentObjLst2 = <Array<clsPaperSubAttachmentEN>>jsonData;
            });
            //const responseRecCount6 = await vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond6).then((jsonData) => {
            //    arrvPaperSubViewpointLikeLogObjLst = <Array<clsvPaperSubViewpointLikeLogEN>>jsonData;
            //});
            //const responseRecCount7 = await vSysVote_GetObjLstAsync(strWhereCond6).then((jsonData) => {
            //    arrvPaperSubViewpointLikeLogObjLst = <Array<clsvSysVoteEN>>jsonData;
            //});
            const responseText = await SysVote_GetObjLstAsync(strWhereCond6).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });

            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            var strhtml = "";
            var cateid: number = 0;
            var cateid_: number = 0;
            var intJ: number = 0;


            //$('#tbList tr').remove();

            //for (var j = 0; j < arrSubViewpointTypeObjLst.length; j++) {
            //    cateid++;
            //    intJ++;

            var fid: number = 0;
            //    var strsubTypeId: string = arrSubViewpointTypeObjLst[j].subViewpointTypeId;
            //先创建子模块类型
            //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';

            //strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>';

            ////strhtml += '<div style="float:left;"><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></div>';
            //strhtml += '<div style="float:left;"><h3>论文子观点</h3></div>';
            //strhtml += '<div style="float:right;">';
            //if ($("#hidType").val() == "01") {
            //    //if ($("#hidIsSubmit").val() != "true") {
            //    //strhtml += '<button title="添加子观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '");><i class="layui-icon"></i></button>';
            //    strhtml += '<button title="添加子观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click();><i class="layui-icon"></i></button>';
            //    //strhtml += '<button title="重新排列序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnReOrder_Click("' + strsubTypeId + '")><i class="layui-icon">&#xe669;</i></button>';
            //    //}
            //}

            //strhtml += '</div></td></tr>';
            //<td>' + cateid + ' </td>
            //strhtml += '<td class="td-manage"></td>';


            for (var j = 0; j < arrvPaperSubVTypeNumObjLst.length; j++) {
                cateid++;
                intJ++;
                var fid: number = 0;
                var strsubTypeId: string = arrvPaperSubVTypeNumObjLst[j].subViewpointTypeId;
                //先创建子模块类型
                //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';

                strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>';

                //strhtml += '<div style="float:left;"><h3>' + intJ + '.' + arrvPaperSubVTypeNumObjLst[j].subViewpointTypeName + '</h3><span class="layui-badge" id="SubVTypeCount">' + arrvPaperSubVTypeNumObjLst[j].memo + '</span></div>';
                strhtml += '<div style="float:left;font-size:22px;font-weight:bold;">' + intJ + '.' + arrvPaperSubVTypeNumObjLst[j].subViewpointTypeName + '</div>';
                strhtml += '<span style="float:left;" class="layui-badge" id="SubVTypeCount">' + arrvPaperSubVTypeNumObjLst[j].memo + '</span>';

                strhtml += '<div style="float:right;">';
                if ($("#hidType").val() == "01") {
                    if ($("#hidIsSubmit").val() != "true") {
                        strhtml += '<button title="添加子观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '")><i class="layui-icon"></i></button>';

                    }
                }
                strhtml += '</div>';
                strhtml += '</td></tr>';
                //<td>' + cateid + ' </td>
                //strhtml += '<td class="td-manage"></td>';


                //子类型数据
                var strSubViewpointId = "";
                cateid_ = cateid;
                var intK: number = 0;

                arrvPaperSubViewpointObjLst = arrvPaperSubViewpointObjLst2.filter(x => x.subViewpointTypeId == strsubTypeId);


                //arrvPaperSubViewpointObjLst = arrvPaperSubViewpointObjLst2.filter(x => x.subViewpointTypeId == strsubTypeId);


                for (var k = 0; k < arrvPaperSubViewpointObjLst.length; k++) {
                    strSubViewpointId = arrvPaperSubViewpointObjLst[k].subViewpointId;
                    //先判断子模块类型数据ID和子观点知否匹配；
                    //if (strsubTypeId == arrvPaperSubViewpointObjLst[k].subViewpointTypeId) {
                    cateid++;
                    intK++;
                    //if (arrSectionObjLst.length != 0) {
                    //for (var i = 0; i < arrSectionObjLst.length; i++) {

                    //var strSectionId: string = arrSectionObjLst[i].sectionId;
                    //var strSectionName: string = arrSectionObjLst[i].sectionName;
                    //strhtml += '<li class="ui-li-has-alt ui-first-child"><a href="#" onclick="btnUpdateRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')" class="ui-btn" ><p>' + this.vSubViewpointObjLst[k].subViewpointContent + '</p></a><a href="#" class="ui-btn ui-btn-icon-notext ui-icon-delete" title="删除" onclick="btnDeleteRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')"></a></li>';


                    //strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" onmouseover=btnUpdatePaperPageNum_Click(' + arrvPaperSubViewpointObjLst[k].paperPageNum + ',"' + arrvPaperSubViewpointObjLst[k].explainContent + '")><td>';
                    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" onclick=btnUpdatePaperPageNum_Click(' + arrvPaperSubViewpointObjLst[k].paperPageNum + ',"' + arrvPaperSubViewpointObjLst[k].explainContent + '")><td>';

                    strhtml += '&nbsp;&nbsp;<span class="color3">' + intK + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].attitudesName + '】' + arrvPaperSubViewpointObjLst[k].subViewpointContent + '';

                    //strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【观点类型】' + arrvPaperSubViewpointObjLst[k].subViewpointTypeName + '';
                    //根据子观点id 得到附件
                    if (arrvPaperSubViewpointObjLst[k].sectionName != "") {
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【论文节】' + arrvPaperSubViewpointObjLst[k].sectionName + '';
                    }

                    arrPaperSubAttachmentObjLst = arrPaperSubAttachmentObjLst2.filter(x => x.subViewpointId == strSubViewpointId);
                    if (arrPaperSubAttachmentObjLst.length > 0) {
                        for (var y = 0; y < arrPaperSubAttachmentObjLst.length; y++) {

                            var strAddressAndPortfull = strAddressAndPort + arrPaperSubAttachmentObjLst[y].filePath;
                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + arrPaperSubAttachmentObjLst[y].paperSubAttachmentId + '"/>';

                        }
                    }

                    if (arrvPaperSubViewpointObjLst[k].explainContent != "") {
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].explainTypeName + '】' + arrvPaperSubViewpointObjLst[k].explainContent + '';
                    }

                    //if (arrvPaperSubViewpointObjLst[k].literatureSourcesId != "") {

                    //    strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【引用文献】' + arrvPaperSubViewpointObjLst[k].PaperTitleEx + '(作者：' + arrvPaperSubViewpointObjLst[k].AuthorEx + ')';
                    //}

                    if (arrvPaperSubViewpointObjLst[k].paperPageNum != 0) {
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a class="color3" ><i class="layui-icon x-show" status="true">&#xe623;</i>【pdf页码】第' + arrvPaperSubViewpointObjLst[k].paperPageNum + '页</a>';
                    }



                    var objUser = arrUsers.find(x => x.userId == arrvPaperSubViewpointObjLst[k].updUser);
                    if (objUser != null) {
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="color2"><i class="layui-icon x-show" status="true">&#xe623;</i>【编辑时间】' + arrvPaperSubViewpointObjLst[k].updDate + '【编辑用户】' + objUser.userName + '</span>';

                    }

                    //最底一行编辑
                    strhtml += '<br/><div style="float:right;">';
                    if ($("#hidType").val() == "01") {
                        //if ($("#hidIsSubmit").val() == "true") {
                        strhtml += '&nbsp;&nbsp;<img src="../img/vote.png" width = "20px" height = "18px" title = "点赞数" >&nbsp;赞' + arrvPaperSubViewpointObjLst[k].okCount;
                        //strhtml += '&nbsp;&nbsp;评论数:<a href="#" onclick="btnShowAppraise_Click("' + strSubViewpointId + '")">' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a>';
                        strhtml += '&nbsp;&nbsp;评论数:' + arrvPaperSubViewpointObjLst[k].appraiseCount;
                        if (arrvPaperSubViewpointObjLst[k].score != 0) {
                            strhtml += '&nbsp;&nbsp;综合评分:' + arrvPaperSubViewpointObjLst[k].score;
                        }
                        if (arrvPaperSubViewpointObjLst[k].teaScore != 0) {
                            strhtml += '&nbsp;&nbsp;教师评分:' + arrvPaperSubViewpointObjLst[k].teaScore;
                        }
                        if (arrvPaperSubViewpointObjLst[k].stuScore != 0) {
                            strhtml += '&nbsp;&nbsp;学生评分:' + arrvPaperSubViewpointObjLst[k].stuScore;
                        }

                        //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = "btnAddAppraise_Click("' + strSubViewpointId + '")" > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                        //} else {

                        //strhtml += '<input id="txt_OrderNum' + cateid + '" type="text" class="layui-input" style="width:40px;" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click("' + strSubViewpointId + '","txt_OrderNum' + cateid + '");>';
                        //上移
                        //strhtml += '<button title="上移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '")><i class="iconfont">&#xe6a5;</i></button>';
                        ////下移
                        //strhtml += '<button title="下移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '")><i class="iconfont">&#xe6a6;</i></button>';

                        //编辑
                        strhtml += '<button title="编辑子观点" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strSubViewpointId + '")><i class="layui-icon">&#xe642;</i></button>';
                        //删除
                        strhtml += '<button title="删除子观点" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strSubViewpointId + '")><i class="layui-icon">&#xe640;</i></button>';
                        //}
                    } else if ($("#hidType").val() == "02") {

                        //var objLike = arrvPaperSubViewpointLikeLogObjLst.find(x => x.tableKey == strSubViewpointId);
                        var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSubViewpointId);
                        //if (objLike == null) {
                        //    strhtml += '&nbsp;&nbsp;<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + strSubViewpointId + '") ><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞" >&nbsp;赞' + arrvPaperSubViewpointObjLst[k].okCount + '</a>';
                        //} else {
                        //    strhtml += '&nbsp;&nbsp;<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + strSubViewpointId + '") ><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞" >&nbsp;已赞' + arrvPaperSubViewpointObjLst[k].okCount + '</a>';
                        //}
                        if (objLike == null) {
                            strhtml += '&nbsp;&nbsp;<a href="javascript:void(0)" onclick=btnAddVote_Click("' + strSubViewpointId + '","' + arrvPaperSubViewpointObjLst[k].updUser + '") ><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞" >&nbsp;赞' + arrvPaperSubViewpointObjLst[k].okCount + '</a>';
                        } else {
                            strhtml += '&nbsp;&nbsp;<a href="javascript:void(0)" onclick=btnAddVote_Click("' + strSubViewpointId + '","' + arrvPaperSubViewpointObjLst[k].updUser + '") ><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞" >&nbsp;已赞' + arrvPaperSubViewpointObjLst[k].okCount + '</a>';
                        }


                        strhtml += '&nbsp;&nbsp;<span style="color:royalblue" >评论数:' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</span>';

                        if (arrvPaperSubViewpointObjLst[k].score != 0) {
                            strhtml += '&nbsp;&nbsp;综合评分:' + arrvPaperSubViewpointObjLst[k].score;
                        }
                        if (arrvPaperSubViewpointObjLst[k].teaScore != 0) {
                            strhtml += '&nbsp;&nbsp;教师评分:' + arrvPaperSubViewpointObjLst[k].teaScore;
                        }
                        if (arrvPaperSubViewpointObjLst[k].stuScore != 0) {
                            strhtml += '&nbsp;&nbsp;学生评分:' + arrvPaperSubViewpointObjLst[k].stuScore;
                        }
                        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('论文子观点评论', '../GraduateEduTools/SysComment?Key=" + strSubViewpointId + "&Type=02&User=" + arrvPaperSubViewpointObjLst[k].updUser + "&pubParentId=" + $("#hidPaperId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
                        //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = "btnShowAppraise_Click("' + strSubViewpointId + '")" > <i class="layui-icon" >&#xe642; </i>添加评论</button >';

                    }

                    //strhtml += '</div></td><td style="text-align:center"><input id="txt_OrderNum' + cateid + '" type="text" class="layui-input x-sort" style="width:40px;" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click("' + strSubViewpointId + '","txt_OrderNum' + cateid + '");>';
                    ////上移
                    //strhtml += '<br/><button title="上移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strSubViewpointId + '","' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a5;</i></button>';
                    ////下移
                    //strhtml += '<button title="下移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strSubViewpointId + '","' + strsubTypeId + '") href="javascript:;"><i class="iconfont">&#xe6a6;</i></button>';

                    strhtml += '</div></td></tr>';

                    //strhtml += '<td class="td-manage"></td>';
                }

            }
            //拼接；
            //$("#tbList").append(strhtml);
            $("#tbList").html(strhtml);

            //调用拼接方法
            //this.GetHtmlByDataSource();

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }


    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
        this.OpType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        this.Clear();
        //var lngKeyId = strKeyId;
        var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
        const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
        //观点态度ID
        var objgs_PaperSubViewsAttitudes_Cond: clsgs_PaperSubViewsAttitudesEN = new clsgs_PaperSubViewsAttitudesEN();//编辑区域
        const ddl_gs_PaperSubViewsAttitudes = await gs_PaperSubViewsAttitudes_BindDdl_AttitudesIdInDiv_Cache(this.divName4List,"ddlAttitudesId");
        this.UpdateRecord(strKeyId);
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
            //const responseText1 = await this.selectTitle_Click(); //添加的时候默认选择类型名称不需要了
            this.Clear();

            await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
            //观点态度ID
            const ddl_gs_PaperSubViewsAttitudes = await gs_PaperSubViewsAttitudes_BindDdl_AttitudesIdInDiv_Cache(this.divName4List, "ddlAttitudesId");
            const responseText2 = await this.AddNewRecord();

            //获取分享Id
            const responseText3 = await gs_UserConfigEx_GetNewReturnShareIdEx("03", clsPubSessionStorage.GetSession_UserId());
            var strShareId: string = responseText3;
            //var returnBool: boolean = !!responseText2;
            if (strShareId != "") {
                this.shareId = strShareId;
            }
            //默认观点态度显示01；
            this.attitudesId = "01";
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*
   重序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
   */
    public async btnReOrder_Click() {
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = $("#hidSubViewpointTypeId").val();
        var strPaperRWId: string = $("#hidPaperRWId").val();
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_ReOrderAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `重序出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
    }

    /*
    上移
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
    */
    public async btnUpMove_Click() {
        if ($('#hidOrderNum').val() == 0) {
            const responseOrder = await this.btnReOrder_Click();
        }
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = $("#hidSubViewpointTypeId").val();
        var strPaperRWId: string = $("#hidPaperRWId").val();
        var arrKeyIds = $("#hidKeyId").val();
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_UpMoveAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `上移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();


        //var strListDiv: string = this.mstrListDiv;
        //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /*
    下移
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
    */
    public async btnDownMove_Click() {
        if ($('#hidOrderNum').val() == 0) {
            const responseOrder = await this.btnReOrder_Click();
        }
        if (this.PreCheck4Order() == false) return;
        var strSubViewpointTypeId: string = $("#hidSubViewpointTypeId").val();
        var strPaperRWId: string = $("#hidPaperRWId").val();
        var arrKeyIds = $("#hidKeyId").val();
        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            objOrderByData.KeyIdLst = arrKeyIds;
            var jsonObject =
            {
                "subViewpointTypeId": strSubViewpointTypeId,
                "paperRWId": strPaperRWId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await PaperSubViewpoint_DownMoveAsync(objOrderByData);
        }
        catch (e) {
            var strMsg: string = `下移记录出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
            return;
        }
        const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        //var strListDiv: string = this.mstrListDiv;
        //arrKeyIds.forEach((e) => clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
    }

    /* 在数据表里修改排序记录
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
                        const responseBindGv = this.BindGv_vPaperSubViewpoint();

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


    }

    //添加的时候默认选择类型名称不需要了
    //public async selectTitle_Click() {

    //    try {

    //        var objSubViewpointType: clsSubViewpointTypeEN;
    //        var strWhereCond = " subViewpointTypeId='" + this.subViewpointTypeId + "'";
    //        const responseRecCount = await SubViewpointType_GetFirstObjAsync(strWhereCond).then((jsonData) => {
    //            objSubViewpointType = <clsSubViewpointTypeEN>jsonData;
    //            this.rwTitle = objSubViewpointType.defaTitle;


    //        });
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `获取记录不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //}




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


    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjPaperSubViewpointEN">表实体类对象</param>
   */
    public GetDataFromPaperSubViewpointClass(pobjPaperSubViewpointEN: clsPaperSubViewpointEN) {
        //this.paperRWId = pobjPaperSubViewpointEN.paperRWId;// 论文读写Id
        this.sectionId = pobjPaperSubViewpointEN.sectionId;// 节Id
        this.subViewpointTypeId = pobjPaperSubViewpointEN.subViewpointTypeId;// 类型Id
        //  this.rwTitle = pobjPaperSubViewpointEN.rwTitle;// 读写标题
        this.subViewpointContent = pobjPaperSubViewpointEN.subViewpointContent;// 详情内容
        this.explainTypeId = pobjPaperSubViewpointEN.explainTypeId;// 说明类型Id
        this.explainContent = pobjPaperSubViewpointEN.explainContent;// 说明内容
        this.isPublic = pobjPaperSubViewpointEN.isPublic;// 是否公开
        this.literatureSourcesId = pobjPaperSubViewpointEN.literatureSourcesId;// 文献来源

        //this.paperPageNum = pobjPaperSubViewpointEN.paperPageNum;// 页码
        //this.PaperLineNum = pobjPaperSubViewpointEN.PaperLineNum;// 页码

        this.orderNum = pobjPaperSubViewpointEN.orderNum;// 序号
        this.updUser = pobjPaperSubViewpointEN.updUser;// 修改用户Id
        this.updDate = pobjPaperSubViewpointEN.updDate;// 修改日期
        this.memo = pobjPaperSubViewpointEN.memo;// 备注
        this.attitudesId = pobjPaperSubViewpointEN.attitudesId;//观点态度；
        this.shareId = pobjPaperSubViewpointEN.shareId;
    }

    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjPaperSubViewpointEN">数据传输的目的类对象</param>
  */
    public PutDataToPaperSubViewpointClass(pobjPaperSubViewpointEN: clsPaperSubViewpointEN) {
        //pobjPaperSubViewpointEN.paperRWId = $("#hidPaperRWId").val();// 论文读写Id
        pobjPaperSubViewpointEN.paperRWId = "00000000";// 论文读写Id
        pobjPaperSubViewpointEN.paperId = $("#hidPaperId").val();// 论文Id
        pobjPaperSubViewpointEN.sectionId = this.sectionId;//节
        pobjPaperSubViewpointEN.id_CurrEduCls = this.Id_CurrEduCls;
        pobjPaperSubViewpointEN.subViewpointTypeId = this.subViewpointTypeId;// 类型Id
        // pobjPaperSubViewpointEN.rwTitle = this.rwTitle;// 读写标题
        //判断主题ID是否为空
        var strTopicId = $("#hidTopicId").val();
        if (strTopicId != "") {
            pobjPaperSubViewpointEN.topicId = strTopicId;
        }


        pobjPaperSubViewpointEN.subViewpointContent = this.subViewpointContent;// 详情内容
        pobjPaperSubViewpointEN.explainTypeId = this.explainTypeId;// 说明类型Id
        pobjPaperSubViewpointEN.explainContent = this.explainContent;// 说明内容
        pobjPaperSubViewpointEN.isPublic = this.isPublic;// 是否公开
        pobjPaperSubViewpointEN.literatureSourcesId = this.literatureSourcesId;// 文献来源

        pobjPaperSubViewpointEN.paperPageNum = this.pdfPageNum;// 页码
        //pobjPaperSubViewpointEN.PaperLineNum = this.pdfDiv_top;// 行号

        if (this.orderNum == 0) {
            pobjPaperSubViewpointEN.orderNum = 30;
        }
        else {
            pobjPaperSubViewpointEN.orderNum = this.orderNum;// 序号
        }

        pobjPaperSubViewpointEN.shareId = this.shareId;
        pobjPaperSubViewpointEN.attitudesId = this.attitudesId;//观点态度；

        pobjPaperSubViewpointEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改用户Id
        pobjPaperSubViewpointEN.userId = clsPubSessionStorage.GetSession_UserId();
        //pobjPaperSubViewpointEN.updUser = $("#hidUserId").val();// 修改用户Id
        pobjPaperSubViewpointEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjPaperSubViewpointEN.memo = this.memo;// 备注
    }

    //添加点赞
    public async btnAddVote_Click(strSubViewpointId: string, strUserId: string) {
        //this.DivName = "divAddNewRecordSave";
        var objSysVoteEN: clsSysVoteEN = new clsSysVoteEN();
        objSysVoteEN.tableKey = strSubViewpointId;
        objSysVoteEN.voteTypeId = "02";
        objSysVoteEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        objSysVoteEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改用户Id
        objSysVoteEN.userId = strUserId;//被点赞用户
        objSysVoteEN.pubParentId = $("#hidPaperId").val();
        objSysVoteEN.id_CurrEduCls = $("#hidid_CurrEduCls").val();

        var strWhereCond = " 1 =1 and updUser='" + $("#hidUserId").val() + "' and tableKey=" + strSubViewpointId;
        try {
            const responseText = await SysVote_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await SysVote_AddNewRecordAsync(objSysVoteEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {



                var strWhereCond2 = " 1=1 and voteTypeId='02' and tableKey=" + strSubViewpointId;
                var intVoteCount = await SysVote_GetRecCountByCondAsync(strWhereCond2);

                var objPaperSubViewpointEN: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
                objPaperSubViewpointEN.subViewpointId = strSubViewpointId;
                objPaperSubViewpointEN.okCount = intVoteCount;

                objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
                    throw "关键字不能为空!";
                }

                const responseText = PaperSubViewpoint_UpdateRecordAsync(objPaperSubViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        //const gvResult = await this.BindGv_vPaper();

                        this.BindGv_vPaperSubViewpoint();
                    }
                    else {
                        var strInfo: string = `点赞不成功!`;
                        alert(strInfo);
                        console.log("点赞不成功");
                    }

                });
            }
            else {
                var strInfo: string = `点赞不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.DetailRecord();
                //this.BindGv_vPaperSubViewpoint();
            }


            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `点赞不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }


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

    /* 
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            //添加成功后把数据同步到总表
            var strSubViewpointId = $('#hidKeyId').val();

            //删除前先查询是否有评论数据，如果存在则提示必须先删除评论数据才能执行子观点删除；
            var strWhere = "1=1 And commentTypeId='02' And tableKey='" + strSubViewpointId + "'";
            const responseText4 = await SysComment_IsExistRecordAsync(strWhere);
            var returnBool3: boolean = !!responseText4;
            if (returnBool3 == true) {
                console.log("子观点数据存在评论不可删除");
                alert("请先删除该子观点评论数据！");
                return "";
            }
            else {
                const responseText3 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSubViewpointId, "03", "3", this.Id_CurrEduCls);
                var returnBool3: boolean = !!responseText3;
                if (returnBool3 == true) {
                    console.log("论文子观点数据总表删除成功；");
                }
                else {
                    console.log("论文子观点数据总表删除失败；");
                }

                //var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(strKeyId);
            }


            const responseText2 = await this.BindGv_vPaperSubViewpoint();
            const UpdateRest = await this.SynSubV();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }
    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public DelRecord(strSubViewpointId: string) {
        return new Promise((resolve, reject) => {
            try {

                const responseText = PaperSubViewpoint_DelRecordAsync(strSubViewpointId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {

                        //删除子观点时，需要同时去删除附件；
                        //根据Id删除附件
                        var strwhere = "subViewpointId ='" + strSubViewpointId + "'";
                        this.DelAttactmentRecordByWhere(strwhere);



                        var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
                        //显示信息框
                        alert(strInfo);
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

    /* 
根据关键字删除记录 附件
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelAttactmentRecordByWhere(strWhere: string) {
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


    //下载文件
    public btnDownLoadFile_Click() {

        this.GetPaperAttachmentRecord();
        this.btnAddDownload_Click();
    }


    public GetPaperAttachmentRecord() {
        var strPapeId = $("#hidPaperId").val();

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



    /// <summary>
    /// 把Html控件集合转换成Array列表
    /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetArray)
    /// </summary>
    /// <returns></returns>
    public GetArray(arr): Array<HTMLElement> {
        let arrLst: Array<HTMLElement> = new Array<HTMLElement>();
        for (var i = 0; i < arr.length; i++) {
            var chk: HTMLElement = arr[i];// as HTMLElement;
            arrLst.push(chk);
        }
        return arrLst;
    };


    //添加高亮
    public btnUpdatePaperPageNum_Click() {
        this.RemoveSelect()
        var objLst = document.getElementsByTagName("span");
        //var strStartName: string = "400%";
        let arrElement: Array<HTMLElement> = this.GetArray(objLst) as Array<HTMLElement>;
        //let arrSpan
        let arrFind: Array<HTMLSpanElement> = arrElement as Array<HTMLSpanElement>;
        //let arrFind: Array<HTMLSpanElement> = arrSpan.filter(x => x.id.indexOf(strStartName) > -1);

        let arrWord: Array<string> = arrFind.map(x => x.innerText);

        let strWord = arrWord.join("");
        var intWord = strWord.indexOf("400%");
        strWord = strWord.substring(intWord);

        let strFindText = $('#hidExplainContent').val();
        var intStart = strWord.indexOf(strFindText);
        if (intStart > -1) {
            var strInnerText = arrFind[intStart].innerText;
            var strCurrWord = strWord.substring(0, 1);
            var intWordIndex = 0;
            var bolFind = false;
            var intCompareIndex = 0;
            while (bolFind == false) {

                strInnerText = arrFind[intStart + intCompareIndex].innerText;
                strCurrWord = strFindText.substring(intCompareIndex, intCompareIndex + 1);
                console.log(strInnerText + "--" + strCurrWord);
                if (strInnerText == strCurrWord) {
                    intCompareIndex++;
                    if (intCompareIndex >= strFindText.length) break;
                    continue;
                }
                else {
                    intStart++;
                    intCompareIndex = 0;
                    if (intStart > arrFind.length - 2) {
                        break;
                    }
                }

                //                intStart++;

            }
            var intLen = strFindText.length;
            var intEnd = intStart + intLen;
            let arrSpan_Sel: Array<HTMLSpanElement> = arrFind.slice(intStart, intEnd)
            arrSpan_Sel.forEach(x => {
                var strWord = x.innerText;
                var objSpan_New: HTMLSpanElement = document.createElement("span");
                objSpan_New.className = "text-span";
                objSpan_New.innerText = strWord;
                x.innerHTML = "";
                x.appendChild(objSpan_New);
            });
        }
        //let divResult: HTMLDivElement = document.getElementById("divResult") as HTMLDivElement;

        //divResult.innerText = strWord;


    };

    //清除高亮
    public RemoveSelect() {

        var objLst = document.getElementsByTagName("span");
        //var strStartName: string = "divEditFldComparison";
        let arrElement: Array<HTMLElement> = this.GetArray(objLst) as Array<HTMLElement>;
        let arrSpan: Array<HTMLSpanElement> = arrElement as Array<HTMLSpanElement>;
        let arrSpan_Sel: Array<HTMLSpanElement> = arrSpan.filter(x => x.className == "text-span");

        arrSpan_Sel.forEach(x => {
            var strWord = x.innerText;
            var objSpan_Parent = x.parentNode as HTMLSpanElement;
            objSpan_Parent.innerHTML = strWord;

        });


    };


    public Clear() {
        this.paperRWId = "";
        $('#ddlSectionId option[0]').attr("selected", true);
        $('#ddlSubViewpointTypeId option[0]').attr("selected", true);
        this.rwTitle = "";
        this.subViewpointContent = "";
        $('#ddlExplainTypeId option[0]').attr("selected", true);
        this.explainContent = "";
        this.isPublic = false;
        this.literatureSourcesId = "";
        //this.paperPageNum = 0;
        //this.PaperLineNum = 0;
        this.orderNum = 0;
        this.Uploadfile = "";
        this.updUser = "";
        this.updDate = "";
        this.memo = "";
        $("#hdnFileOne").val("");
        $("#hdnFileTwo").val("");
        $("#hdnFileThree").val("");
    }

    /*
   * 设置上传文件
   */
    public set Uploadfile(value: string) {
        $("#txtUploadfile").val(value);
    }
    /*
    * 获取上传文件
    */
    public get Uploadfile(): string {
        return $("#txtUploadfile").val();
    }


    // /*
    //* 设置页码
    //*/
    // public set paperPageNum(value: number) {
    //     $("#txtPaperPageNum").val(value);
    // }
    // /*
    // * 获取页码
    // */
    // public get paperPageNum(): number {
    //     return $("#txtPaperPageNum").val();
    // }

    // /*
    //* 设置行号
    //*/
    // public set PaperLineNum(value: number) {
    //     $("#txtPaperLineNum").val(value);
    // }
    // /*
    // * 获取行号
    // */
    // public get PaperLineNum(): number {
    //     return $("#txtPaperLineNum").val();
    // }



    /*
   * 设置是否隐藏显示
   */
    public set IsDisplay(value: string) {
        $("#btnIsDisplay").html(value);
    }
    /*
    * 获取是否隐藏显示
    */
    public get IsDisplay(): string {
        return $("#btnIsDisplay").html();
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
    /*
* 观点态度
*/
    public set attitudesId(value: string) {
        $("#ddlAttitudesId").val(value);
    }
    /*
    * 观点态度Id
   */
    public get attitudesId(): string {
        return $("#ddlAttitudesId").val();
    }


    /******************************************************************iFrame子页面控件******************************************************/




    /*
   * Pdf内容
  */
    public set pdfContent(value: string) {
        //$("#hidPdfContent").val(value);
        $("#iframe_qaPdf").contents().find("#hidPdfContent").val(value);
    }
    /*
    * Pdf内容
   */
    public get pdfContent(): string {
        //return $("#hidPdfContent").val();
        return $("#iframe_qaPdf").contents().find("#hidPdfContent").val();

    }

    /*
    * Pdf页码
   */
    public set pdfPageNum(value: number) {
        //$("#hidPdfPageNum").val(value);
        $("#iframe_qaPdf").contents().find("#hidPdfPageNum").val(value);
    }
    /*
    * Pdf页码
   */
    public get pdfPageNum(): number {
        //return $("#hidPdfPageNum").val();
        return $("#iframe_qaPdf").contents().find("#hidPdfPageNum").val();
    }



    /*
 * PdfTop
*/
    public set page_top(value: number) {
        //$("#hidPdfPageNum").val(value);
        $("#iframe_qaPdf").contents().find("#page_top").val(value);
    }
    /*
    * PdfTop
   */
    public get page_top(): number {
        //return $("#hidPdfPageNum").val();
        return $("#iframe_qaPdf").contents().find("#page_top").val();
    }



    /*
 * page_cache
*/
    public set page_cache(value: string) {
        //$("#hidPdfPageNum").val(value);
        $("#iframe_qaPdf").contents().find("#page_cache").val(value);
    }
    /*
    * page_cache
   */
    public get page_cache(): string {
        //return $("#hidPdfPageNum").val();
        return $("#iframe_qaPdf").contents().find("#page_cache").val();
    }

    /*
* pdf_zoom
*/
    public set pdf_zoom(value: string) {
        //$("#hidPdfPageNum").val(value);
        $("#iframe_qaPdf").contents().find("#pdf_zoom").val(value);
    }
    /*
    * pdf_zoom
   */
    public get pdf_zoom(): string {
        //return $("#hidPdfPageNum").val();
        return $("#iframe_qaPdf").contents().find("#pdf_zoom").val();
    }

    /*
* pdfDiv_top
*/
    public set pdfDiv_top(value: string) {
        //$("#hidPdfPageNum").val(value);
        $("#iframe_qaPdf").contents().find("#pdfDiv_top").val(value);
    }
    /*
    * pdfDiv_top
   */
    public get pdfDiv_top(): string {
        //return $("#hidPdfPageNum").val();
        return $("#iframe_qaPdf").contents().find("#pdfDiv_top").val();
    }


    /*
* pdfDiv_left
*/
    public set PdfPageCache(value: string) {
        //$("#hidPdfPageNum").val(value);
        $("#iframe_qaPdf").contents().find("#pdfDiv_left").val(value);
    }
    /*
    * page_cache
   */
    public get pdfDiv_left(): string {
        //return $("#hidPdfPageNum").val();
        return $("#iframe_qaPdf").contents().find("#pdfDiv_left").val();
    }


    /*
    * 教学班ID
   */
    public set Id_CurrEduCls(value: string) {
        $("#hidid_CurrEduCls").val(value);
    }
    /*
    * 教学班
   */
    public get Id_CurrEduCls(): string {
        return $("#hidid_CurrEduCls").val();
    }

}