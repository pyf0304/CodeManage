/*-- -- -- -- -- -- -- -- -- -- --
类名:ResearchTopic_QUDI_TSEx
表名:ResearchTopic(01120546)
生成代码版本:2019.12.06.1
生成日期:2019/12/27 10:59:12
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
import { Public_Concept } from "../GraduateEduPublicPage/Public_Concept.js";
import { Public_SysSkill } from "../GraduateEduPublicPage/Public_SysSkill.js";
import { Public_SysSocialRelations } from "../GraduateEduPublicPage/Public_SysSocialRelations.js";
import { Public_TopicObjective } from "../GraduateEduPublicPage/Public_TopicObjective.js";
import { Public_Viewpoint } from "../GraduateEduPublicPage/Public_Viewpoint.js";
import { ResearchTopicCRUD } from "../PagesBase/GraduateEduTopic/ResearchTopicCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_TotalDataRelaEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataRelaEN.js";
import { clsgs_TotalDataStatisticsEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js";
import { clsvgs_TotalDataStatisticsEN } from "../TS/L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsEN.js";

import { clsvConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { gs_TdRelaType_BindDdl_TDRelaTypeIdInDiv_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TDRelaTypeWApi.js";
import { gs_TotalDataRela_AddNewRecordAsync, gs_TotalDataRela_DelRecordAsync, gs_TotalDataRela_GetFirstObjAsync, gs_TotalDataRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataRelaWApi.js";
import { gs_TotalDataStatistics_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { vgs_TotalDataStatistics_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js";
import { vConcept_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { vSysSkill_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { vSysSocialRelations_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vTopicObjective_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { vViewpoint_GetObjLstAsync, vViewpoint_GetObjLstByPagerAsync, vViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogTwo(): void;
declare function HideDialogThree(): void;
declare function HideDialogFour(): void;
declare function HideDialogNine(): void;//技能选择
declare function RefreshWindow(): void;
declare function LoadTreeShow(): void;
declare function HideDialogSeven(): void;
declare function HideDialogEight(): void;
declare function HideDialogTen(): void;

declare function Alert1(strMsg): void;
declare function Alert2(strMsg): void;
declare function Alert3(strMsg): void;
declare function Alert4(strMsg): void;

declare var strCurrPrjId;
declare var $;
declare var window;
/* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_TotalDataRela extends ResearchTopicCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortResearchTopicBy: string = "paperId";

    //public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    //public bolIsLoadDetailRegion: boolean = false;  //记录是否导入详细信息区的变量
    //public divName4Edit: string = "divEdit";  //编辑区的Id


    //观点列表
    public mstrListDivViewpoint: string = "divViewpointDataLst";

    //个人观点关系
    public mstrListDivgs_PViewpointRela: string = "divgs_PViewpointRelaDataLst";
    //专家观点
    public mstrListDivRtExpegs_PViewpointRela: string = "divRtExpegs_PViewpointRelaDataLst";


    //概念
    public mstrListConceptDivPaper: string = "divgs_PConceptRelaDataLst";

    //客观事实
    public mstrListTopicObjectiveDivPaper: string = "divRtTopicObjectiveDataLst";
    //客观依据

    public mstrListBasisTopicObjectiveDivPaper: string = "divBasisRtTopicObjectiveDataLst";

    //技能
    public mstrListSysskillDivPaper: string = "divSysskillDataLst";

    //社会关系
    public mstrListSysSocialRelaDivPaper: string = "divgs_PSocialRelaLst";

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
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPublocalStorage.userId != "") {

                //1、为下拉框设置数据源,绑定列表数据

                //主题观点关系
                //this.hidSortvgs_PViewpointRelaBy = "updDate Desc";


                //主题概念
                //this.hidSortvgs_PConceptRelaBy = "updDate Desc";


                //观点
                this.hidSortvViewpointBy = "updDate Desc";
                //客观
                //TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";


                //默认不 显示分页
                //if (this.recCount == 0) {

                //    $("#divPagerViewpoint").attr("style", "display:none;");
                //    $("#divPagerConcept").attr("style", "display:none;");
                //    $("#divExpertPagerViewpoint").attr("style", "display:none;");
                //    $("#divPagerBasis").attr("style", "display:none;");
                //    $("#divPagerResearchResult").attr("style", "display:none;");

                //}
                //2、显示无条件的表内容在GridView中
                //主题列表因为页面调整问题，注释；
                //const gvResult = await this.BindGv_ResearchTopic();

                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；



                //获取关系表ID
                const responseObjId = await this.GetRelaId();

                //绑定传值过来的单条观点
                const responseObjLst1 = await this.Showdiv_Viewpoint();

                //绑定选项卡内各个观点
                const responseObjLst2 = await this.GetAllFunctionMethod();

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


    /******************************************绑定各个观点单个对象***************************************/

    //获取关系表ID
    public async GetRelaId() {
        var strKeyId = $("#hidKeyId").val();
        var strTypeId = $("#hidTypeId").val();
        var strWhereCond = "1=1 and tableKey='" + strKeyId + "' and totalDataTypeId ='" + strTypeId + "'";
       
        try {
            const objgs_TotalDataStatistics = await gs_TotalDataStatistics_GetFirstObjAsync(strWhereCond);
            if (objgs_TotalDataStatistics != null) {
                $("#hidmId").val(objgs_TotalDataStatistics.totalDataId);
            }
            //var strTotalDataId = await gs_TotalDataStatistics_GetFirstIDAsync(strWhereCond);
            //if (strTotalDataId != "") {
            //    $("#hidmId").val(strTotalDataId);
            //}
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    //观点
    public async Showdiv_Viewpoint() {
        var strTypeId = $("#hidTypeId").val();
        switch (strTypeId) {
            case "04":
                const gvResult3 = await this.Bind_vViewpoint();
                break;
            case "05":
                const gvResult4 = await this.Bind_vViewpoint();
                break;
            case "06":
                const gvResult5 = await this.Bind_vConcept();
                break;
            case "07":
                const gvResult6 = await this.Bind_vTopicObjective();
                break;
            case "08":
                const gvResult7 = await this.Bind_vTopicObjective();
                break;
            case "09":
                const gvResult8 = await this.Bind_vSysSkill();
                break;
            case "10":
                const gvResult9 = await this.Bind_vSysSocialRelations();
                break;
            default:
                break;

        }
    }

    //绑定观点数据
    public async Bind_vViewpoint() {
        var strViewpointId = $("#hidKeyId").val();
        var strTypeId = $("#hidTypeId").val();
        var strHtml = "";
        if (strTypeId == "04") {
            strHtml += '<div class="title btn-1"><a href="#" title="个人观点">个人观点</a></div>';
        } else if (strTypeId == "05") {
            strHtml += '<div class="title btn-1"><a href="#" title="专家观点">专家观点</a></div>';
        }
        strHtml += await Public_Viewpoint.Bind_vViewpoint(strViewpointId);
        $("#div_Viewpoint").html(strHtml);
    }

    //绑定相关概念
    public async Bind_vConcept() {
        var strConceptId = $("#hidKeyId").val();
        var strHtml = '<div class="title btn-1"><a href="#" title="相关概念">相关概念</a></div>';
        strHtml += await Public_Concept.Bind_vConcept(strConceptId);
        $("#div_Viewpoint").html(strHtml);
    }

    //客观事实、客观数据
    public async Bind_vTopicObjective() {
        var strTopicObjectiveId = $("#hidKeyId").val();
        var strTypeId = $("#hidTypeId").val();
        var strHtml = "";
        if (strTypeId == "07") {
            strHtml += '<div class="title btn-1"><a href="#" title="客观事实">客观事实</a></div>';
        } else if (strTypeId == "08") {
            strHtml += '<div class="title btn-1"><a href="#" title="客观数据">客观数据</a></div>';
        }
        var strHtml = await Public_TopicObjective.Bind_vTopicObjective(strTopicObjectiveId);
        $("#div_Viewpoint").html(strHtml);
    }

    //技能
    public async Bind_vSysSkill() {
        var strSkillId = $("#hidKeyId").val();
        var strHtml = '<div class="title btn-1"><a href="#" title="技能">技能</a></div>';
        strHtml += await Public_SysSkill.Bind_vSysSkill(strSkillId);
        $("#div_Viewpoint").html(strHtml);

    }

    //社会关系
    public async Bind_vSysSocialRelations() {
        var strSocialId = $("#hidKeyId").val();
        var strHtml = '<div class="title btn-1"><a href="#" title="社会关系">社会关系</a></div>';
        strHtml += await Public_SysSocialRelations.Bind_vSysSocialRelations(strSocialId);
        $("#div_Viewpoint").html(strHtml);
    }



    /***************************绑定各个观点单个对象***************************************/






    //得到7个关系列表数据；
    public async GetAllFunctionMethod() {
        const ddl_TDRelaTypeId = await gs_TdRelaType_BindDdl_TDRelaTypeIdInDiv_Cache(this.divName4List, "ddlgs_TDRelaType");
        const responseObjList1 = await this.BindGv_gs_TotalDataRela_Viewpoint("01");
        const responseObjList2 = await this.BindGv_gs_TotalDataRela_Viewpoint("02");
        const responseObjList3 = await this.BindGv_vgs_PConceptRela();
        const responseObjList4 = await this.BindGv_vgs_PTopicObjectiveRela("01");
        const responseObjList5 = await this.BindGv_vgs_PTopicObjectiveRela("02");
        const responseObjList6 = await this.BindGv_vgs_PSkillRela();
        const responseObjList7 = await this.BindGv_vgs_PSocialRela();

        //var strnum = $("#hidTabNum").val();
        //if (strnum == "3") {
        //    //主题个人观点关系；
        //    $("#hidLiTypeId").val("04");
        //    $('#hidUserTypeId').val("01");
        //    const ddl_TDRelaTypeId = await gs_TDRelaType_BindDdl_TDRelaTypeId_Cache("ddlgs_TDRelaType1", new clsgs_TDRelaTypeEN);
        //    this.BindGv_gs_TotalDataRela_Viewpoint("01");
        //}
        //else if (strnum == "4") {
        //    //专家观点
        //    $("#hidLiTypeId").val("05");
        //    $('#hidUserTypeId').val("02");
        //    const ddl_TDRelaTypeId = await gs_TDRelaType_BindDdl_TDRelaTypeId_Cache("ddlgs_TDRelaType1", new clsgs_TDRelaTypeEN);
        //    this.BindGv_gs_TotalDataRela_Viewpoint("02");
        //    //this.BindGv_vRTExpegs_PViewpointRela();
        //}
        //else if (strnum == "5") {
        //    //主题概念关系
        //    $("#hidLiTypeId").val("06");
        //    const ddl_TDRelaTypeId = await gs_TDRelaType_BindDdl_TDRelaTypeId_Cache("ddlgs_TDRelaType2", new clsgs_TDRelaTypeEN);
        //    this.BindGv_vgs_PConceptRela();
        //}
        //else if (strnum == "6") {
        //    //客观事实关系
        //    $("#hidLiTypeId").val("07");
        //    $('#hidUserTypeId').val("01");
        //    const ddl_TDRelaTypeId = await gs_TDRelaType_BindDdl_TDRelaTypeId_Cache("ddlgs_TDRelaType3", new clsgs_TDRelaTypeEN);
        //    this.BindGv_vgs_PTopicObjectiveRela("01");
        //}
        //else if (strnum == "7") {
        //    //客观依据关系
        //    $("#hidLiTypeId").val("08");
        //    $('#hidUserTypeId').val("02");
        //    const ddl_TDRelaTypeId = await gs_TDRelaType_BindDdl_TDRelaTypeId_Cache("ddlgs_TDRelaType3", new clsgs_TDRelaTypeEN);
        //    this.BindGv_vgs_PTopicObjectiveRela("02");
        //}
        //else if (strnum == "9") {
        //    //技能
        //    $("#hidLiTypeId").val("09");
        //    const ddl_TDRelaTypeId = await gs_TDRelaType_BindDdl_TDRelaTypeId_Cache("ddlgs_TDRelaType4", new clsgs_TDRelaTypeEN);
        //    this.BindGv_vgs_PSkillRela();
        //}
        //else if (strnum == "10") {
        //    //社会关系
        //    $("#hidLiTypeId").val("10");
        //    const ddl_TDRelaTypeId = await gs_TDRelaType_BindDdl_TDRelaTypeId_Cache("ddlgs_TDRelaType5", new clsgs_TDRelaTypeEN);
        //    this.BindGv_vgs_PSocialRela();
        //}
        //else {
        //    //主题个人观点关系；
        //    $("#hidLiTypeId").val("04");
        //    $('#hidUserTypeId').val("01");
        //    const ddl_TDRelaTypeId = await gs_TDRelaType_BindDdl_TDRelaTypeId_Cache("ddlgs_TDRelaType1", new clsgs_TDRelaTypeEN);
        //    this.BindGv_gs_TotalDataRela_Viewpoint("01");
        //}


    }

    //总数据删除函数
    public async btnDelgs_TotalDataRela(strKeyId: string) {
        try {
            this.GetRelaId();
            var strLiTypeId = $("#hidLiTypeId").val();
            var strTotalDataId1 = $("#hidmId").val();

            
            var strWhereCond1 = " totalDataTypeId='" + strLiTypeId + "' and tableKey ='" + strKeyId + "'";
            const objgs_TotalDataStatistics = await gs_TotalDataStatistics_GetFirstObjAsync(strWhereCond1);

            if (objgs_TotalDataStatistics != null) {
                var strWhereCond2 = " totalDataId1=" + strTotalDataId1 + " and totalDataId2 =" + objgs_TotalDataStatistics.totalDataId;

                const objgs_TotalDataRela = await gs_TotalDataRela_GetFirstObjAsync(strWhereCond2);
                if (objgs_TotalDataRela != null) {
                    var intmId: number = objgs_TotalDataRela.mId;
                    const responseText = await gs_TotalDataRela_DelRecordAsync(intmId).then((jsonData) => {
                        var returnInt: number = jsonData;
                        if (returnInt > 0) {
                            var strMsg: string = `删除关系记录成功`;
                            //alert(strMsg);
                            Alert1(strMsg);
                            this.GetAllFunctionMethod();
                        }
                    });
                }
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    //总数据添加函数
    public async btnAddgs_TotalDataRela(strKeyId: string) {
        this.GetRelaId();
        var strLiTypeId = $("#hidLiTypeId").val();
        var strTotalDataId1 = $("#hidmId").val();

        var strWhereCond1 = " totalDataTypeId='" + strLiTypeId + "' and tableKey ='" + strKeyId + "'";
        const objgs_TotalDataStatistics = await gs_TotalDataStatistics_GetFirstObjAsync(strWhereCond1);

        try {
            if (objgs_TotalDataStatistics != null) {
                var objgs_TotalDataRelaEN: clsgs_TotalDataRelaEN = new clsgs_TotalDataRelaEN();
                objgs_TotalDataRelaEN.totalDataId1 = strTotalDataId1;
                objgs_TotalDataRelaEN.totalDataId2 = objgs_TotalDataStatistics.totalDataId;
                //var strLiTypeId = $("#hidLiTypeId").val();
                //switch (strLiTypeId) {
                //    case "04":
                //        objgs_TotalDataRelaEN.tdRelaTypeId = $("#ddlgs_TDRelaType1").val();
                //        break;
                //    case "05":
                //        objgs_TotalDataRelaEN.tdRelaTypeId = $("#ddlgs_TDRelaType1").val();
                //        break;
                //    case "06":
                //        objgs_TotalDataRelaEN.tdRelaTypeId = $("#ddlgs_TDRelaType2").val();
                //        break;
                //    case "07":
                //        objgs_TotalDataRelaEN.tdRelaTypeId = $("#ddlgs_TDRelaType3").val();
                //        break;
                //    case "08":
                //        objgs_TotalDataRelaEN.tdRelaTypeId = $("#ddlgs_TDRelaType3").val();
                //        break;
                //    case "09":
                //        objgs_TotalDataRelaEN.tdRelaTypeId = $("#ddlgs_TDRelaType4").val();
                //        break;
                //    case "10":
                //        objgs_TotalDataRelaEN.tdRelaTypeId = $("#ddlgs_TDRelaType5").val();
                //        break;
                //}
                objgs_TotalDataRelaEN.tdRelaTypeId = $("#ddlgs_TDRelaType").val();
                objgs_TotalDataRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());
                objgs_TotalDataRelaEN.SetUpdUser(clsPublocalStorage.userId);
                objgs_TotalDataRelaEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
                const responseText2 = await gs_TotalDataRela_AddNewRecordAsync(objgs_TotalDataRelaEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    var strInfo: string = `添加记录成功!`;
                    //显示信息框
                    //alert(strInfo);
                    Alert1(strInfo);
                    //绑定概念列表
                    const responseObjLst = await this.GetAllFunctionMethod();
                    HideDialogTwo();
                }
                else {
                    var strInfo: string = `添加记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2;//一定要有一个返回值，否则会出错！
            } else {
                var strInfo: string = `当前观点在总数据表内没找到，请让管理员同步总数据表以后再试!`;
                //显示信息框
                alert(strInfo);
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }


    //关系表通过转换得到各个观点表的主键数组
    public async GetKeyList(): Promise<string> {
        this.GetRelaId();
        var strKeyList2: string = "";
        var strKeyId = $("#hidKeyId").val();
        var strTypeId = $("#hidTypeId").val();

        var strmId = $("#hidmId").val();



        try {
            if (strmId != null && strmId != "") {
                var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                var strWhereCond1 = " totalDataId1 = '" + strmId + "' and id_CurrEduCls ='" + strid_CurrEduCls + "'";

                var arrgs_TotalDataRelaObjLst: Array<clsgs_TotalDataRelaEN> = [];
                var arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];

                const responseObjLst1 = await gs_TotalDataRela_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                    arrgs_TotalDataRelaObjLst = <Array<clsgs_TotalDataRelaEN>>jsonData;
                });
                if (arrgs_TotalDataRelaObjLst.length > 0) {
                    var strKeyList = "";
                    for (var i = 0; i < arrgs_TotalDataRelaObjLst.length; i++) {
                        if (i == 0) strKeyList = strKeyList + "'" + arrgs_TotalDataRelaObjLst[i].totalDataId2 + "'";
                        else strKeyList += "," + "'" + arrgs_TotalDataRelaObjLst[i].totalDataId2 + "'";
                    }
                    var strLiTypeId = $("#hidLiTypeId").val();
                    var strWhereCond2 = " totalDataTypeId='" + strLiTypeId + "' and totalDataId in (" + strKeyList + ")";
                    const responseObjLst2 = await vgs_TotalDataStatistics_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                        arrvgs_TotalDataStatisticsObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                    });
                    if (arrvgs_TotalDataStatisticsObjLst != null) {
                        //var strKeyList2 = "";
                        for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                            if (i == 0) strKeyList2 = strKeyList2 + "'" + arrvgs_TotalDataStatisticsObjLst[i].tableKey + "'";
                            else strKeyList2 += "," + "'" + arrvgs_TotalDataStatisticsObjLst[i].tableKey + "'";
                        }
                    }
                }
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        return strKeyList2;
    }


    ////////////////////////////////////////////7个关系列表数据///////////////////////////////////

    /******************************************个人观点关系相关***************************************/
    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_gs_TotalDataRela_Viewpoint(strVTypeId: string) {
        $('#hidUserTypeId').val(strVTypeId);
        if (strVTypeId == "01") {
            $("#hidLiTypeId").val("04");
        } else if (strVTypeId == "02") {
            $("#hidLiTypeId").val("05");
        }
        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        try {
            var strKeyList2 = await this.GetKeyList();
            if (strKeyList2 != "") {
                var strWhereCond3 = " userTypeId='" + strVTypeId + "' and viewpointId in (" + strKeyList2 + ")";
                const responseObjLst3 = await vViewpoint_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                    arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
                });
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            var strHtml = "";
            if (arrvViewpointObjLst.length > 0) {
                //当前操作类型是各观点关系绑定“04”
                strHtml = await Public_Viewpoint.BindList_vViewpoint("04", strVTypeId, arrvViewpointObjLst)
                console.log("完成divPersonalViewpointRelaDataLst!");
            }
            //拼接；
            if (strVTypeId == "01") {
                $("#divPersonalViewpointRelaDataLst").html(strHtml);
            } else if (strVTypeId == "02") {
                $("#divExpertViewpointRelaDataLst").html(strHtml);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }




    //删除个人观点关系数据
    public async btnDelViewPointRelaRecordInTab_Click(strKeyId: string, strVTypeId: string) {
        if (strVTypeId == "01") {
            $("#hidLiTypeId").val("04");
        } else if (strVTypeId == "02") {
            $("#hidLiTypeId").val("05");
        }
        this.btnDelgs_TotalDataRela(strKeyId);

    }



    //////////////////////////////////////////////////////////////////////////////////////////////////主题观点关系
    /* 观点列表表头排序；
 */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvViewpointBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvViewpointBy.indexOf("Asc") >= 0) {
                this.hidSortvViewpointBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvViewpointBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvViewpointBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vViewpoint();
    }


    //////////////////////////////////////////////////////////////////个人观点部分
    //观点查询按钮
    public async btnViewpointQuery_Click() {

        const responseObjList = await this.BindGv_vViewpoint();
    }

    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public async CombinevViewpointCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;

        var strWhereCond: string = " 1 = 1 ";
        strWhereCond += "  and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";

        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if ($("#txtViewpointName_q").val() != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${$("#txtViewpointName_q").val()}%'`;
            }
            //if ($("#txtViewUpdName_q").val() != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_UserName} like '% ${$("#txtViewUpdName_q").val()}%'`;
            //}
            //根据传入的usertypeId 来区分是本人观点还是专家观点
            var strhidUserTypeId = $("#hidUserTypeId").val();
            if (strhidUserTypeId != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_UserTypeId} = '${strhidUserTypeId}'`;
            }

            //只能查询提交的观点数据
            strWhereCond += ` And ${clsvViewpointEN.con_IsSubmit} = 'true'`;

            //排除获取已存在的关系数据 根据当前用户；
            //strWhereCond += ` And viewpointId not in (select viewpointId from gs_PViewpointRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vViewpoint() {
        var strListDiv: string = this.mstrListDivViewpoint;
        var strWhereCond = await this.CombinevViewpointCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        try {
            this.recCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: 10,
                whereCond: strWhereCond,
                orderBy: this.hidSortvViewpointBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        try {

            var strVTypeId = $("#hidUserTypeId").val();//页面参数

            var strHtml = await Public_Viewpoint.BindList_vViewpoint("05", strVTypeId, arrvViewpointObjLst)

            //拼接；
            $("#divViewpointDataLst").html(strHtml);

            if (arrvViewpointObjLst.length > 30) {
                //$("#divPager1").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }

            console.log("完成BindGv_vViewpoint!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    //添加观点 展示观点列表数据
    public async btnAddViewpointRela_Click() {
        const responseObjList = await this.BindGv_vViewpoint();
    }
    //确定选择的观点 并添加到关系表中
    public btnAdd_ViewpointRela_Click(strkeyId: string) {
        //存放Id
        //$("#hidViewpointId").val(strkeyId)
        //执行添加关系方法
        //this.AddNewRecordSaveViewpointRela(strkeyId);
        this.btnAddgs_TotalDataRela(strkeyId);

    }

    /*
 * 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvViewpointBy(value: string) {
        $("#hidSortvViewpointBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvViewpointBy(): string {
        return $("#hidSortvViewpointBy").val();
    }

    /* 函数功能:在数据 列表中跳转到某一页 观点列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
    public IndexPageOne(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vViewpoint();
    }



    //////////////////////////////////////////相关概念//////////////////////////////////////////////////


    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vgs_PConceptRela() {
        $("#hidLiTypeId").val("06");
        var arrvConceptObjLst: Array<clsvConceptEN> = [];
        try {
            var strKeyList2 = await this.GetKeyList();
            if (strKeyList2 != "") {
                var strWhereCond3 = " conceptId in (" + strKeyList2 + ")";
                const responseObjLst3 = await vConcept_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                    arrvConceptObjLst = <Array<clsvConceptEN>>jsonData;
                });
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            var strHtml = "";
            if (arrvConceptObjLst.length > 0) {
                //当前操作类型是各观点关系绑定“04”
                strHtml = await Public_Concept.BindList_vConcept("04", arrvConceptObjLst)
                console.log("完成BindGv_vgs_PConceptRela!");
            }
            //拼接；
            $("#divgs_PConceptRelaDataLst").html(strHtml);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }



    }


    /* 
在数据表里删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelConceptRelaRecordInTab_Click(strKeyId: string) {
        $("#hidLiTypeId").val("06");
        this.btnDelgs_TotalDataRela(strKeyId);

    }




    //确定选择的观点 并添加到关系表中
    public btnOkConceptInTab_Click(strkeyId: string) {
        //存放Id
        //$("#hidViewpointId").val(strkeyId)
        //执行添加关系方法
        //this.AddNewRecordSaveConceptRela(strkeyId);
        this.btnAddgs_TotalDataRela(strkeyId);

    }



    //////////////////////////////////////客观事实数据关系///////////////////////////////////////



    /* 根据条件获取相应的对象列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vgs_PTopicObjectiveRela(strVTypeId: string) {
        $('#hidUserTypeId').val(strVTypeId);
        if (strVTypeId == "01") {
            $("#hidLiTypeId").val("07");
        } else if (strVTypeId == "02") {
            $("#hidLiTypeId").val("08");
        }
        var arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN> = [];
        try {
            var strKeyList2 = await this.GetKeyList();
            if (strKeyList2 != "") {
                var strWhereCond3 = " topicObjectiveId in (" + strKeyList2 + ")";
                const responseObjLst3 = await vTopicObjective_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                    arrvTopicObjectiveObjLst = <Array<clsvTopicObjectiveEN>>jsonData;
                });
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            var strHtml = "";
            if (arrvTopicObjectiveObjLst.length > 0) {
                //当前操作类型是各观点关系绑定“04”
                strHtml = await Public_TopicObjective.BindList_vTopicObjective("04", strVTypeId, arrvTopicObjectiveObjLst)
                console.log("完成BindGv_vgs_PTopicObjectiveRela!");
            }
            //拼接；
            if (strVTypeId == "01") {
                $("#divRtTopicObjectiveDataLst").html(strHtml);
            } else if (strVTypeId == "02") {
                $("#divBasisRtTopicObjectiveDataLst").html(strHtml);
            }
        }

        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }



    /* 
在数据表里删除记录 删除客观事实
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelObjectiveRecordInTab_Click(strKeyId: string, strVTypeId: string) {
        if (strVTypeId == "01") {
            $("#hidLiTypeId").val("07");
        } else if (strVTypeId == "02") {
            $("#hidLiTypeId").val("08");
        }
        this.btnDelgs_TotalDataRela(strKeyId);

    }



    //确定选择的观点 并添加到关系表中
    public btnOkObjectiveInTab_Click(strkeyId: string) {
        //存放Id
        //$("#hidViewpointId").val(strkeyId)
        //执行添加关系方法
        //this.AddNewRecordSaveObjectiveRela(strkeyId);
        this.btnAddgs_TotalDataRela(strkeyId);

    }

    //////////////////////用户列表条件
    /*
    * 用户ID
   */
    public get userId_q(): string {
        return $("#txtUserId_q").val();
    }
    /*
   * 用户名
  */
    public get userName_q(): string {
        return $("#txtUserName_q").val();
    }


    /*
    * 获取当前页序号-------观点
   */
    public get CurrPageIndexViewpoint(): number {
        return $("#hidCurrPageIndexViewpoint").val();
    }
    /*
    * 设置当前页序号-------观点
   */
    public set CurrPageIndexViewpoint(value: number) {
        $("#hidCurrPageIndexViewpoint").val(value);
    }




    ///////////////////---------------------------------------------------------所有数据列表排序功能



    /* 观点 个人 专家
   */
    public async SortByViewpoint(strSortByFld: string) {
        if (this.hidSortvViewpointBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvViewpointBy.indexOf("Asc") >= 0) {
                this.hidSortvViewpointBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvViewpointBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvViewpointBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vViewpoint();
    }



    /*
        * 设置排序字段-相当使用ViewState功能
       */
    public set hidSortvUsersBy(value: string) {
        $("#hidSortvUsersBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvUsersBy(): string {
        return $("#hidSortvUsersBy").val();
    }

    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvTopicObjectiveBy(value: string) {
        $("#hidSortvTopicObjectiveBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvTopicObjectiveBy(): string {
        return $("#hidSortvTopicObjectiveBy").val();
    }




    //-----------------tab页切换事件

    //个人观点
    public async liViewpointClick() {
        try {
            const gvResultPaper = await this.GetAllFunctionMethod();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取个人观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //专家观点
    public async liExpertViewpointClick() {
        try {
            const gvResultPaper = await this.GetAllFunctionMethod();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取专家观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //相关概念
    public async liConceptClick() {
        try {
            const gvResultPaper = await this.GetAllFunctionMethod();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取相关概念列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //客观事实
    public async liObjectiveFactClick() {
        try {
            const gvResultPaper = await this.GetAllFunctionMethod();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取客观事实列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //客观数据
    public async liObjectiveBasisClick() {
        try {
            const gvResultPaper = await this.GetAllFunctionMethod();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取客观依据列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //技能；
    public async liSysskillClick() {
        try {
            const gvResultPaper = await this.GetAllFunctionMethod();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取客观依据列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //社会关系；
    public async liSysSocialRelationsClick() {
        try {
            const gvResultPaper = await this.GetAllFunctionMethod();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取客观依据列表不成功,${e}.`;
            alert(strMsg);
        }
    }



    //////////////////////////////////技能////////////////////////////////

    /* 函数功能:在数据 列表中跳转到某一页
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
 <param name = "intPageIndex">页序号</param>
*/
    public IndexPageTen(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vgs_PSkillRela();
    }

    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vgs_PSkillRela() {

        $("#hidLiTypeId").val("09");

        var arrvSysSkillObjLst: Array<clsvSysSkillEN> = [];

        try {
            var strKeyList2 = await this.GetKeyList();
            if (strKeyList2 != "") {
                var strWhereCond3 = " skillId in (" + strKeyList2 + ")";
                const responseObjLst3 = await vSysSkill_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                    arrvSysSkillObjLst = <Array<clsvSysSkillEN>>jsonData;
                });
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            var strHtml = "";
            if (arrvSysSkillObjLst.length > 0) {
                //当前操作类型是各观点关系绑定“04”
                strHtml = await Public_SysSkill.BindList_vSysSkill("04", arrvSysSkillObjLst)
                console.log("完成BindGv_vgs_PSkillRela!");
            }
            //拼接；
            $("#divSysskillDataLst").html(strHtml);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    /* 
在数据表里删除技能关系
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelSysskillRecordInTab_Click(strKeyId: string) {
        $("#hidLiTypeId").val("09");
        this.btnDelgs_TotalDataRela(strKeyId);
    }

    //添加技能关系
    public btnOkSysskillInTab_Click(strkeyId: string) {
        //存放Id
        //$("#hidViewpointId").val(strkeyId)
        //执行添加关系方法
        //this.AddNewRecordSaveConceptRela(strkeyId);
        this.btnAddgs_TotalDataRela(strkeyId);

    }

    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvgs_PSkillRelaBy(value: string) {
        $("#hidSortvgs_PSkillRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_PSkillRelaBy(): string {
        return $("#hidSortvgs_PSkillRelaBy").val();
    }



    //--------------------------------=================================================================--社会关系
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vgs_PSocialRela() {
        $("#hidLiTypeId").val("10");
        var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = [];

        try {
            var strKeyList2 = await this.GetKeyList();
            if (strKeyList2 != "") {
                var strWhereCond3 = " socialId in (" + strKeyList2 + ")";
                const responseObjLst3 = await vSysSocialRelations_GetObjLstAsync(strWhereCond3).then((jsonData) => {
                    arrvSysSocialRelationsObjLst = <Array<clsvSysSocialRelationsEN>>jsonData;
                });
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            var strHtml = "";
            if (arrvSysSocialRelationsObjLst.length > 0) {
                //当前操作类型是各观点关系绑定“04”
                strHtml = await Public_SysSocialRelations.BindList_vSysSocialRelations("04", arrvSysSocialRelationsObjLst)
                console.log("完成BindGv_vgs_PSocialRela!");
            }
            //拼接；
            $("#divSysSocialRelaDataLst").html(strHtml);
        }

        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 函数功能:在数据 列表中跳转到某一页
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
<param name = "intPageIndex">页序号</param>
*/
    public IndexPageEleven(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vgs_PSocialRela();
    }


    /* 
在数据表里删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelgs_PSocialRelaRecordInTab_Click(strKeyId: string) {
        $("#hidLiTypeId").val("10");
        this.btnDelgs_TotalDataRela(strKeyId);
    }


    //添加社会关系
    public async btnOkgs_PSocialRelaInTab_Click(strkeyId: string) {
        //存放Id
        //$("#hidViewpointId").val(strkeyId)
        //执行添加关系方法
        //this.AddNewRecordSaveConceptRela(strkeyId);
        this.btnAddgs_TotalDataRela(strkeyId);
    }

    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvgs_PSocialRelaBy(value: string) {
        $("#hidSortvgs_PSocialRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_PSocialRelaBy(): string {
        return $("#hidSortvgs_PSocialRelaBy").val();
    }


    /* 函数功能:在数据 列表中跳转到某一页
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
  */
    public async IndexPage(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        var strnum = $("#hidTabNum").val();
        //11代表研究计划 否则就是主题；
    }



    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvgs_ResearchPlanBy(value: string) {
        $("#hidSortvgs_ResearchPlanBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_ResearchPlanBy(): string {
        return $("#hidSortvgs_ResearchPlanBy").val();
    }


    /*
    * 获取当前页序号
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }

}


