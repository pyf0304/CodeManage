/*-- -- -- -- -- -- -- -- -- -- --
类名:ResearchTopicListEx
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
//import * as $ from "jquery";
//import * as QQ from "q";
import { Public_Concept } from "../GraduateEduPublicPage/Public_Concept.js";
import { Public_SysSkill } from "../GraduateEduPublicPage/Public_SysSkill.js";
import { Public_SysSocialRelations } from "../GraduateEduPublicPage/Public_SysSocialRelations.js";
import { Public_TopicObjective } from "../GraduateEduPublicPage/Public_TopicObjective.js";
import { Public_Viewpoint } from "../GraduateEduPublicPage/Public_Viewpoint.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsgs_OriginalPaperLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js";
import { clsgs_PaperDiscussEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperDiscussEN.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvgs_PConceptRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PConceptRelaEN.js";
import { clsvgs_PSkillRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PSkillRelaEN.js";
import { clsvgs_PSocialRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PSocialRelaEN.js";
import { clsvgs_PTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PTopicObjectiveRelaEN.js";
import { clsvgs_PViewpointRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PViewpointRelaEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsvSysCommentEN } from "../TS/L0_Entity/GraduateEduTools/clsvSysCommentEN.js";
import { clsConceptAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js";
import { clsConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js";
import { clske_SubEN } from "../TS/L0_Entity/GraduateEduTopic/clske_SubEN.js";
import { clske_SuperEN } from "../TS/L0_Entity/GraduateEduTopic/clske_SuperEN.js";
import { clsObjectiveAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";
import { clsRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js";
import { clsRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js";
import { clsSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js";
import { clsSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js";
import { clsTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js";
import { clsViewpointAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js";
import { clsViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js";
import { clsViewpointLikeLogEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointLikeLogEN.js";
import { clsvResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsvResearchTopicEN.js";
import { clsvRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { clsvRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js";
import { clsvRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsTopicUserRoleEN } from "../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js";
import { clsvUsersEN } from "../TS/L0_Entity/UserManage/clsvUsersEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { clsvQxUserRoleRelationEN } from "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js";
import { gs_OriginalPaperLog_AddNewRecordAsync, gs_OriginalPaperLog_GetObjLstAsync, gs_OriginalPaperLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js";
import { gs_PaperDiscuss_AddNewRecordAsync, gs_PaperDiscuss_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperDiscussWApi.js";
import { PaperAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { Paper_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vgs_PConceptRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PConceptRelaWApi.js";
import { vgs_PSkillRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PSkillRelaWApi.js";
import { vgs_PSocialRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PSocialRelaWApi.js";
import { vgs_PTopicObjectiveRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PTopicObjectiveRelaWApi.js";
import { vgs_PViewpointRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PViewpointRelaWApi.js";
import { vPaper_GetObjLstByPagerAsync, vPaper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { vSysComment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js";
import { ConceptAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptAttachmentWApi.js";
import { Concept_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js";
import { ke_Sub_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clske_SubWApi.js";
import { ke_Super_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clske_SuperWApi.js";
import { ObjectiveAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js";
import { ResearchTopic_AddNewRecordAsync, ResearchTopic_GetMaxStrIdAsync, ResearchTopic_GetObjByTopicIdAsync, ResearchTopic_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { RTPaperRela_AddNewRecordAsync, RTPaperRela_DelRecordAsync, RTPaperRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js";
import { RTUserRela_AddNewRecordAsync, RTUserRela_DelRecordAsync, RTUserRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js";
import { RTViewpointRela_AddNewRecordAsync, RTViewpointRela_DelRecordAsync, RTViewpointRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js";
import { SysSkill_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js";
import { SysSocialRelations_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { TopicObjective_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { ViewpointAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js";
import { ViewpointLikeLog_AddNewRecordAsync, ViewpointLikeLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointLikeLogWApi.js";
import { Viewpoint_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js";
import { vResearchTopic_GetObjLstByPagerAsync, vResearchTopic_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvResearchTopicWApi.js";
import { vRTPaperRela_GetObjLstAsync, vRTPaperRela_GetObjLstByPagerAsync, vRTPaperRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js";
import { vRTUserRela_GetObjLstByPagerAsync, vRTUserRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js";
import { vRTViewpointRela_GetObjLstByPagerAsync, vRTViewpointRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js";
import { vViewpoint_GetObjLstByPagerAsync, vViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { SysVote_AddNewRecordAsync, SysVote_GetObjLstAsync, SysVote_GetRecCountByCondAsync, SysVote_IsExistRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { TopicUserRole_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { vUsers_GetObjLstByPagerAsync, vUsers_GetRecCountByCondAsync } from "../TS/L3_ForWApi/UserManage/clsvUsersWApi.js";
import { vQxUserRoleRelation_GetObjLstAsync } from "../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js";
import { ResearchTopicEx_DelRecordAsyncEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsResearchTopicExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsSysPara4WebApi2 } from "../TS/PubFun/clsSysPara4WebApi2.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { ResearchTopic_QUDI } from "./ResearchTopic_QUDI.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogTwo(): void;

declare function HideDialogThree(): void;
declare function HideDialogFour(): void;
declare function LoadTreeShow(): void;

declare function HideDialog3(): void;

declare function RefreshWindow(): void;
//显示评论框
declare function ShowDialog3(): void;
declare function AlertOK(): void;
declare function AlertNo(): void;
declare function AlertScore(): void;
declare function AlertComment(): void;

declare var strAddressAndPort;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class OriginalPaperAllListEx extends ResearchTopic_QUDI {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortResearchTopicBy: string = "topicId";
    //观点列表
    public mstrListDivViewpoint: string = "divViewpointDataLst";

    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";

    //用户列表
    public mstrListDivUser: string = "divUserDataLst";

    //主题用户关系
    public mstrListDivRtUserRela: string = "divRtUserRelaDataLst";

    //主题观点关系
    public mstrListDivRtViewPointRela: string = "divRtViewPointRelaDataLst";

    //主题论文关系
    public mstrListDivRtPaperRela: string = "divRtPaperRelaDataLst";


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
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {

                const ddlTopicId_q = await this.Bind_TopicNameList();

                //页面加载时候 判断主题ID是否为空 不为空则调用论文
                var strTopicId = $("#hidTopicRelaId").val();
                if (strTopicId != "" && strTopicId != undefined) {
                    //点击主题了后，调用论文绑定；
                    const ddlPaperId_q = await this.Bind_TopicPaperList();
                }



                //主题下拉框
                // const ddlOperationTypeId_q = await this.BindDdl_TopicName_q("ddlTopicName", "1=1");
                //设置缓存分类字段；


                //获取用户角色来判断显示不同的列表数据；

                //$('#userName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
                $("#hidUserId").val(clsPubSessionStorage.GetSession_UserId());
                $("#hidRoleId").val(clsPubSessionStorage.GetSession_RoleId());

                //管理员 判断角色 
                if ($("#hidRoleId").val() == "00620001") {

                    $("#btnDelRecord").show();
                    $("#tab4Bind tr").find("td:eq(8)").show();
                }
                else {
                    //学生00620003 教师 
                    $("#btnDelRecord").hide();
                    $("#tab4Bind tr").find("td:eq(8)").hide();
                }
                //需要读取写作步骤，显示不同的状态；
                const gvResult1 = await this.GetPaperLogTypeId();
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //默认论思路
                const gvResult = await this.BindPaperIdea();
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
    public async GetPaperLogTypeId() {
        var strPaperId = $("#hidPaperRelaId").val();
        var result = "";
        ///获取论文步骤状态
        var strWhere = "1=1 And paperId='" + strPaperId+"'";
        var arrvgs_OriginalPaperLogLst: Array<clsgs_OriginalPaperLogEN> = [];

        const responseObjLst1 = await gs_OriginalPaperLog_GetObjLstAsync(strWhere).then((jsonData) => {
            arrvgs_OriginalPaperLogLst = <Array<clsgs_OriginalPaperLogEN>>jsonData;
        });
        //排序为了统计步骤方便
        arrvgs_OriginalPaperLogLst = arrvgs_OriginalPaperLogLst.sort(x => x[clsgs_OriginalPaperLogEN.con_LogTypeId]);
        for (var j = 0; j < arrvgs_OriginalPaperLogLst.length; j++) {
            if (j + 1 == arrvgs_OriginalPaperLogLst.length) {
                result = arrvgs_OriginalPaperLogLst[j].logTypeId;
            }
        }

        var logTypeId = result.toString();
        switch (logTypeId) {
            case "01":
                $("#lblPaperIdea").html("论文思路(开始中)");
                $("#lblPaperViewpoint").html("论文观点(未开始)");
                $("#lblPaperFirst").html("论文初稿(未开始)");
                $("#lblGroupDiscuss").html("小组讨论(未开始)");
                $("#lblPaperSecond").html("论文修改稿(未开始)");
                $("#lblPeerAdvice").html("同伴建议(未开始)");
                $("#lblPaperEnd").html("论文终稿(未开始)");
                break;
            case "02":
                $("#lblPaperIdea").html("论文思路(已完成)");
                $("#lblPaperViewpoint").html("论文观点(开始中)");
                $("#lblPaperFirst").html("论文初稿(未开始)");
                $("#lblGroupDiscuss").html("小组讨论(未开始)");
                $("#lblPaperSecond").html("论文修改稿(未开始)");
                $("#lblPeerAdvice").html("同伴建议(未开始)");
                $("#lblPaperEnd").html("论文终稿(未开始)");
                break;
            case "03":
                $("#lblPaperIdea").html("论文思路(已完成)");
                $("#lblPaperViewpoint").html("论文观点(已完成)");
                $("#lblPaperFirst").html("论文初稿(开始中)");
                $("#lblGroupDiscuss").html("小组讨论(未开始)");
                $("#lblPaperSecond").html("论文修改稿(未开始)");
                $("#lblPeerAdvice").html("同伴建议(未开始)");
                $("#lblPaperEnd").html("论文终稿(未开始)");
                break;
            case "04":
                $("#lblPaperIdea").html("论文思路(已完成)");
                $("#lblPaperViewpoint").html("论文观点(已完成)");
                $("#lblPaperFirst").html("论文初稿(已完成)");
                $("#lblGroupDiscuss").html("小组讨论(开始中)");
                $("#lblPaperSecond").html("论文修改稿(未开始)");
                $("#lblPeerAdvice").html("同伴建议(未开始)");
                $("#lblPaperEnd").html("论文终稿(未开始)");
                break;
            case "05":
                $("#lblPaperIdea").html("论文思路(已完成)");
                $("#lblPaperViewpoint").html("论文观点(已完成)");
                $("#lblPaperFirst").html("论文初稿(已完成)");
                $("#lblGroupDiscuss").html("小组讨论(已完成)");
                $("#lblPaperSecond").html("论文修改稿(开始中)");
                $("#lblPeerAdvice").html("同伴建议(未开始)");
                $("#lblPaperEnd").html("论文终稿(未开始)");
                break;
            case "06":
                $("#lblPaperIdea").html("论文思路(已完成)");
                $("#lblPaperViewpoint").html("论文观点(已完成)");
                $("#lblPaperFirst").html("论文初稿(已完成)");
                $("#lblGroupDiscuss").html("小组讨论(已完成)");
                $("#lblPaperSecond").html("论文修改稿(已完成)");
                $("#lblPeerAdvice").html("同伴建议(开始中)");
                $("#lblPaperEnd").html("论文终稿(未开始)");
                break;
            case "07":
                $("#lblPaperIdea").html("论文思路(已完成)");
                $("#lblPaperViewpoint").html("论文观点(已完成)");
                $("#lblPaperFirst").html("论文初稿(已完成)");
                $("#lblGroupDiscuss").html("小组讨论(已完成)");
                $("#lblPaperSecond").html("论文修改稿(已完成)");
                $("#lblPeerAdvice").html("同伴建议(已完成)");
                $("#lblPaperEnd").html("论文终稿(开始中)");
                break;
            case "08":
                $("#lblPaperIdea").html("论文思路(已完成)");
                $("#lblPaperViewpoint").html("论文观点(已完成)");
                $("#lblPaperFirst").html("论文初稿(已完成)");
                $("#lblGroupDiscuss").html("小组讨论(已完成)");
                $("#lblPaperSecond").html("论文修改稿(已完成)");
                $("#lblPeerAdvice").html("同伴建议(已完成)");
                $("#lblPaperEnd").html("论文终稿(已完成)");
                break;
            default:
                $("#lblPaperIdea").html("论文思路(开始中)");
                $("#lblPaperViewpoint").html("论文观点(未开始)");
                $("#lblPaperFirst").html("论文初稿(未开始)");
                $("#lblGroupDiscuss").html("小组讨论(未开始)");
                $("#lblPaperSecond").html("论文修改稿(未开始)");
                $("#lblPeerAdvice").html("同伴建议(未开始)");
                $("#lblPaperEnd").html("论文终稿(未开始)");
                break;
        }
    }


    //主题
    public async Bind_TopicNameList() {
        try {

            var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";

            var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];

            const responseObjLst = await ResearchTopic_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrResearchTopicObjLst = <Array<clsResearchTopicEN>>jsonData;

            });
            var strhtml = "";
            for (var i = 0; i < arrResearchTopicObjLst.length; i++) {

                //判断主题ID是否为空；
                var strTopic = $("#hidTopicRelaId").val();
                if (strTopic != "") {
                    //如果不为空，那么则判断 循环的ID和当前主题相等，那么则直接赋值
                    if (arrResearchTopicObjLst[i].topicId == strTopic) {
                        $("#hidTopicRelaId").val(arrResearchTopicObjLst[i].topicId);
                        $("#hidTopicName").val(arrResearchTopicObjLst[i].topicName);
                        $("#topicName").html(arrResearchTopicObjLst[i].topicName);

                    }
                }
                else {
                    if (i == 0) {

                        if ($("#hidTopicName").val() == "") {

                            $("#hidTopicRelaId").val(arrResearchTopicObjLst[i].topicId);
                            $("#hidTopicName").val(arrResearchTopicObjLst[i].topicName);
                            $("#topicName").html(arrResearchTopicObjLst[i].topicName);
                        }
                        else {
                            $("#topicName").html($("#hidTopicName").val());
                        }
                    }
                }




                strhtml += '<dd><a onclick=BtnTopicName_Click("' + arrResearchTopicObjLst[i].topicId + '","' + arrResearchTopicObjLst[i].topicName + '")> ' + arrResearchTopicObjLst[i].topicName + '</a></dd>';
            }
            $("#dlTopicNameList").html(strhtml);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //主题下的原创论文；
    public async Bind_TopicPaperList() {
        try {
            //获取主题Id
            var strTopicId = $("#hidTopicRelaId").val();
            var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "' And topicId = '" + strTopicId + "' And paperTypeId='02'";

            var arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN> = [];

            const responseObjLst = await vRTPaperRela_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvRTPaperRelaObjLst = <Array<clsvRTPaperRelaEN>>jsonData;

            });
            var strhtml = "";

            if (arrvRTPaperRelaObjLst.length > 0) {
                for (var i = 0; i < arrvRTPaperRelaObjLst.length; i++) {

                    //判断主题ID是否为空；
                    var strPaperId = $("#hidPaperRelaId").val();
                    if (strPaperId != "") {
                        //如果不为空，那么则判断 循环的ID和当前主题相等，那么则直接赋值
                        if (arrvRTPaperRelaObjLst[i].paperId == strPaperId) {
                            $("#hidPaperRelaId").val(arrvRTPaperRelaObjLst[i].paperId);
                        }
                    }

                    else {
                        if (i == 0) {
                        //    if ($("#hidPaper1Name").val() == "") {

                        //        $("#hidPaperRelaId").val(arrvRTPaperRelaObjLst[i].paperId);
                        //        $("#hidPaper1Name").val(arrvRTPaperRelaObjLst[i].Paper1Name);
                        //        $("#Paper1Name").html(arrvRTPaperRelaObjLst[i].Paper1Name);
                        //    }
                        //    else {
                        //        $("#Paper1Name").html($("#hidPaper1Name").val());
                        //    }
                        }
                    }

                    strhtml += '<dd><a onclick=BtnTopicPaperTitle_Click("' + arrvRTPaperRelaObjLst[i].paperId + '","' + arrvRTPaperRelaObjLst[i].paperTitle + '")> ' + arrvRTPaperRelaObjLst[i].paperTitle + '</a></dd>';
                }
            }
            else {
                $("#hidPaperRelaId").val("");
                $("#hidPaperTitle").val("");
                $("#paperTitle").html("无论文数据");
            }

            $("#dlPaperTitleList").html(strhtml);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }



    //获取主题
    public async BtnTopicName_Click(strkey: string, strName: string) {
        //$("#hidid_CurrEduCls").val(strkey);
        $("#hidTopicRelaId").val(strkey);
        $("#hidTopicName").val(strName);
        $("#topicName").html(strName);

        //点击主题了后，调用论文绑定；
        const ddlPaperId_q = await this.Bind_TopicPaperList();
        // this.GetAllFunctionMethod();
    }
    //点击论文获取默认显示论文思路
    public async BtnTopicPaperTitle_Click(strkey: string, strName: string) {
        //$("#hidid_CurrEduCls").val(strkey);
        $("#hidPaperRelaId").val(strkey);
        $("#hidPaperTitle").val(strName);
        $("#paperTitle").html(strName);

        //默认显示论文思路
        this.BindPaperIdea();

    }



    //主题用户角色
    /// <summary>
    /// 为下拉框获取数据,从表:[OperationType]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_TopicUserRole_q(ddlTopicUserRole_q: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlTopicUserRole_q);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlTopicUserRole_q} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = TopicUserRole_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrTopicUserRoleObjLst: Array<clsTopicUserRoleEN> = <Array<clsTopicUserRoleEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlTopicUserRole_q, arrTopicUserRoleObjLst, clsTopicUserRoleEN.con_TopicUserRoleId, clsTopicUserRoleEN.con_TopicUserRoleName, "");
                    console.log("完成BindDdl_TopicUserRole_q!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    //获取主题数据

    public BindDdl_TopicName_q(dllTopicName: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(dllTopicName);
        if (objDdl == null) {
            var strMsg = `下拉框：${dllTopicName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = ResearchTopic_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrResearchTopicObjLst: Array<clsResearchTopicEN> = <Array<clsResearchTopicEN>>jsonData;
                    clsCommonFunc4Web.BindDdl_ObjLst(dllTopicName, arrResearchTopicObjLst, clsResearchTopicEN.con_TopicId, clsResearchTopicEN.con_TopicName, "");
                    console.log("完成dllTopicName!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    //得到3个关系列表数据；
    public async GetAllFunctionMethod() {
        //组合关系；
        const response = await this.BindGv_AllTopicRela();
        //调用隐藏方法
        this.GetId();

    }
    public GetId() {
        //得到分类子类ID 判断显示隐藏数据；
        var strKeyId = $("#hidke_SubId").val();
        switch (strKeyId) {
            case "0001":
                $("#infoViewpoint").hide();
                $("#infoExpert").hide();
                $("#infoConcept").hide();
                $("#infoFacts").show();
                $("#infoBasis").hide();
                $("#infoSysskill").hide();
                $("#infoSysSocialRelations").hide();
                break;
            case "0002":
                $("#infoViewpoint").hide();
                $("#infoExpert").hide();
                $("#infoConcept").hide();
                $("#infoFacts").hide();
                $("#infoBasis").show();
                $("#infoSysskill").hide();
                $("#infoSysSocialRelations").hide();
                break;
            case "0003":
                $("#infoViewpoint").hide();
                $("#infoExpert").hide();
                $("#infoConcept").show();
                $("#infoFacts").hide();
                $("#infoBasis").hide();
                $("#infoSysskill").hide();
                $("#infoSysSocialRelations").hide();
                break;
            case "0004":
                $("#infoViewpoint").show();
                $("#infoExpert").hide();
                $("#infoConcept").hide();
                $("#infoFacts").hide();
                $("#infoBasis").hide();
                $("#infoSysskill").hide();
                $("#infoSysSocialRelations").hide();
                break;
            case "0005":
                $("#infoViewpoint").hide();
                $("#infoExpert").show();
                $("#infoConcept").hide();
                $("#infoFacts").hide();
                $("#infoBasis").hide();
                $("#infoSysskill").hide();
                $("#infoSysSocialRelations").hide();
                break;
            case "0006":
                $("#infoViewpoint").hide();
                $("#infoExpert").hide();
                $("#infoConcept").hide();
                $("#infoFacts").hide();
                $("#infoBasis").hide();
                $("#infoSysskill").show();
                $("#infoSysSocialRelations").hide();
                break;
            case "0007":
                $("#infoViewpoint").hide();
                $("#infoExpert").hide();
                $("#infoConcept").hide();
                $("#infoFacts").hide();
                $("#infoBasis").hide();
                $("#infoSysskill").hide();
                $("#infoSysSocialRelations").show();
                break;
            default:
                var strMsg = '没有数据需要被处理！';
                alert(strMsg);
                break;

        }

    }


    public GetDataShow() {
        var strKeyId = $("#hidke_SuperId").val();
        switch (strKeyId) {
            case "0001":
                $("#infoViewpoint").hide();
                $("#infoExpert").hide();
                $("#infoConcept").show();
                $("#infoFacts").show();
                $("#infoBasis").show();
                $("#infoSysskill").hide();
                $("#infoSysSocialRelations").hide();
                break;
            case "0002":
                $("#infoViewpoint").show();
                $("#infoExpert").show();
                $("#infoConcept").hide();
                $("#infoFacts").hide();
                $("#infoBasis").hide();
                $("#infoSysskill").hide();
                $("#infoSysSocialRelations").hide();
                break;
            case "0003":
                $("#infoViewpoint").hide();
                $("#infoExpert").hide();
                $("#infoConcept").hide();
                $("#infoFacts").hide();
                $("#infoBasis").hide();
                $("#infoSysskill").show();
                $("#infoSysSocialRelations").hide();
                break;
            case "0004":
                $("#infoViewpoint").hide();
                $("#infoExpert").hide();
                $("#infoConcept").hide();
                $("#infoFacts").hide();
                $("#infoBasis").hide();
                $("#infoSysskill").hide();
                $("#infoSysSocialRelations").show();
                break;

            default:
                var strMsg = '没有数据需要被处理！';
                alert(strMsg);
                break;

        }
    }




    //动态主题数据结构；
    public async GetTopicData() {

        var strWhereCond = this.CombineResearchTopicCondition();
        //声明主题变量
        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];

        const responseObjLst = await ResearchTopic_GetObjLstAsync(strWhereCond).then((jsonData) => {
            arrResearchTopicObjLst = <Array<clsResearchTopicEN>>jsonData;

        });

        //知识点父类 

        var strWhereCond1 = "1=1";
        //声明主题变量
        var arrke_SuperObjLst: Array<clske_SuperEN> = [];

        const responseObjLst1 = await ke_Super_GetObjLstAsync(strWhereCond1).then((jsonData) => {
            arrke_SuperObjLst = <Array<clske_SuperEN>>jsonData;

        });


        //知识点子类
        var strWhereCond2 = "1=1";
        //声明主题变量
        var arrSubObjLst: Array<clske_SubEN> = [];

        const responseObjLst2 = await ke_Sub_GetObjLstAsync(strWhereCond2).then((jsonData) => {
            arrSubObjLst = <Array<clske_SubEN>>jsonData;

        });

        var strhtml = "";
        $("#TreeBind li").remove();
        if (arrke_SuperObjLst.length > 0) {
            //循环数据
            for (var i = 0; i < arrke_SuperObjLst.length; i++) {
                var strke_SuperId = arrke_SuperObjLst[i].ke_SuperId;

                if (i == 0) {
                    strhtml += ' <li id="li' + arrke_SuperObjLst[i].ke_SuperId + '" ><a href="#" class="main" onclick=HideTheme_Click("' + arrke_SuperObjLst[i].ke_SuperId + '")>' + arrke_SuperObjLst[i].ke_SuperName_cn + '(' + arrke_SuperObjLst[i].ke_SuperName_en + ')</a><ul class="submenu"  style = "display: block;">';
                }
                else {


                    strhtml += ' <li id="li' + arrke_SuperObjLst[i].ke_SuperId + '"><a href="#" class="main"  onclick=HideTheme_Click("' + arrke_SuperObjLst[i].ke_SuperId + '")>' + arrke_SuperObjLst[i].ke_SuperName_cn + '(' + arrke_SuperObjLst[i].ke_SuperName_en + ')</a><ul class="submenu"  style = "display: none;">';
                }
                //通过父ID得到子类数据
                var arrke_SubObjLst = arrSubObjLst;
                arrke_SubObjLst = arrke_SubObjLst.filter(x => x.ke_SuperId == strke_SuperId);;
                for (var j = 0; j < arrke_SubObjLst.length; j++) {

                    //默认存放第一条数据显示；
                    if (j == 0) {

                        //判断存放的id控件是否为空；
                        if ($("#hidke_SubId").val() == "") {
                            ////存放Id
                            $("#hidke_SubId").val(arrke_SubObjLst[i].ke_SubId);
                            //$("#hidTopicName").val(arrke_SubObjLst[i].topicName);

                            strhtml += '<li id="liTwo' + arrke_SubObjLst[j].ke_SubId + '" onclick=btnSelectke_Sub("' + arrke_SubObjLst[j].ke_SubId + '","' + arrke_SubObjLst[j].ke_SubName_cn + '")><a href="#" class="selected" >' + arrke_SubObjLst[j].ke_SubName_cn + '</a></li>';

                        } else {
                            strhtml += '<li id="liTwo' + arrke_SubObjLst[j].ke_SubId + '" onclick=btnSelectke_Sub("' + arrke_SubObjLst[j].ke_SubId + '","' + arrke_SubObjLst[j].ke_SubName_cn + '")><a href="#" >' + arrke_SubObjLst[j].ke_SubName_cn + '</a></li>';
                        }
                    }
                    else {
                        strhtml += '<li id="liTwo' + arrke_SubObjLst[j].ke_SubId + '" onclick=btnSelectke_Sub("' + arrke_SubObjLst[j].ke_SubId + '","' + arrke_SubObjLst[j].ke_SubName_cn + '")><a href="#">' + arrke_SubObjLst[j].ke_SubName_cn + '</a></li>';
                    }

                    //strhtml += '<li id="' + arrResearchTopicObjLst[i].topicId + '" onclick=btnSelectResearchTopic("' + arrResearchTopicObjLst[i].topicId + '")><a href="#">' + arrResearchTopicObjLst[i].topicName + '</a></li>';
                }
                strhtml += '</ul></li>';

            }

            $("#TreeBind").append(strhtml);

            //调用数据展示；
            this.GetAllFunctionMethod();
        }
    }

    ////////////////////////////////////////主题用户关系
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public CombinevRTConceptRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            ////判断主题id
            //var strTopicId = $("#hidTopicRelaId").val();
            //if (strTopicId != "") {
            //    strWhereCond += ` And ${clsvRTConceptRelaEN.con_TopicId} = '${strTopicId}'`;
            //}
            //判断Paperid
            var strPaperId = $("#hidPaperRelaId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PConceptRelaEN.con_PaperId} = '${strPaperId}'`;
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    //动态获取所有相关关系表数据
    public async BindGv_AllTopicRela() {
        var strUserId = $("#hidUserId").val();
        //一、条件串
        //1用户关系
        //  var strWhereUserRela = this.CombinevRTUserRelaCondition();
        //2论文关系
        //    var strWherePaperRela = this.CombinevRTPaperRelaCondition();
        //3观点关系
        var strWhereViewpointRela1 = this.CombinevRTViewpointRelaCondition1();
        var strWhereViewpointRela2 = this.CombinevRTViewpointRelaCondition2();
        //附件
        var strWhereCondAttachment = "1=1";
        //5点赞 查询当前用户 点赞数据；
        //var strWhereCondLike = `1=1 And ${clsViewpointLikeLogEN.con_UpdUser} = '${strUserId}'`;// 老方法
        var strWhereCondLike = `1=1 And ${clsSysVoteEN.con_UpdUser} = '${strUserId}'`;//新0605


        //6相关概念
        var strWhereConcept = this.CombinevRTConceptRelaCondition();

        //7客观事实
        var strWhereFacts = "paperId='" + $("#hidPaperRelaId").val() + "' and objectiveType='01'";

        //8客观数据
        var strWhereBasis = "paperId='" + $("#hidPaperRelaId").val() + "' and objectiveType='02'";

        //技能
        var strWhereSysskill = "paperId='" + $("#hidPaperRelaId").val() + "'";


        //9、社会关系
        var strWhereSysSocialRelations = "paperId='" + $("#hidPaperRelaId").val() + "'";

        //用户分数
        var strWhereCond10 = " parentId='root' and  commentTypeId='08' order by Score Desc";

        //二、数据源声明
        var arrvRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
        var arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN> = [];
        var arrvgs_PViewpointRelaObjLst1: Array<clsvgs_PViewpointRelaEN> = [];
        var arrvgs_PViewpointRelaObjLst2: Array<clsvgs_PViewpointRelaEN> = [];
        //获取观点图片
        var arrViewpointAttachmentObjLst: Array<clsViewpointAttachmentEN> = [];
        var arrViewpointAttachmentObjLst2: Array<clsViewpointAttachmentEN> = [];

        //获取概念图片
        var arrConceptAttachmentObjLst: Array<clsConceptAttachmentEN> = [];
        var arrConceptAttachmentObjLst2: Array<clsConceptAttachmentEN> = [];

        //获取客观图片
        var arrObjectiveAttachmentObjLst: Array<clsObjectiveAttachmentEN> = [];
        var arrObjectiveAttachmentObjLst2: Array<clsObjectiveAttachmentEN> = [];


        //获取当前用户的点赞数据
        //var arrViewpointLikeLogObjLst: Array<clsViewpointLikeLogEN> = [];//老方法
        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];//新0605
        //获取相关概念
        var arrvgs_PConceptRelaObjLst: Array<clsvgs_PConceptRelaEN> = [];

        //客观事实
        var arrvgs_PTopicObjectiveRelaObjLst1: Array<clsvgs_PTopicObjectiveRelaEN> = [];

        //客观数据
        var arrvgs_PTopicObjectiveRelaObjLst2: Array<clsvgs_PTopicObjectiveRelaEN> = [];

        //技能
        var arrvgs_SkillObjLst: Array<clsvgs_PSkillRelaEN> = [];

        //社会关系
        var arrvgs_PSocialRelaObjLst: Array<clsvgs_PSocialRelaEN> = [];

        //用户分数
        var objSysComment1: clsvSysCommentEN;
        var arrvSysCommentObjLst: Array<clsvSysCommentEN> = [];
        //三、方法获取调用
        try {
            //const responseObjLst1 = await vRTUserRela_GetObjLstAsync(strWhereUserRela).then((jsonData) => {
            //    arrvRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
            //});

            //const responseObjLst2 = await vRTPaperRela_GetObjLstAsync(strWherePaperRela).then((jsonData) => {
            //    arrvRTPaperRelaObjLst = <Array<clsvRTPaperRelaEN>>jsonData;
            //});

            const responseObjLst3 = await vgs_PViewpointRela_GetObjLstAsync(strWhereViewpointRela1).then((jsonData) => {
                arrvgs_PViewpointRelaObjLst1 = <Array<clsvgs_PViewpointRelaEN>>jsonData;
            });

            const responseObjLst4 = await vgs_PViewpointRela_GetObjLstAsync(strWhereViewpointRela2).then((jsonData) => {
                arrvgs_PViewpointRelaObjLst2 = <Array<clsvgs_PViewpointRelaEN>>jsonData;
            });

            const responseRecCount5 = await ViewpointAttachment_GetObjLstAsync(strWhereCondAttachment).then((jsonData) => {
                arrViewpointAttachmentObjLst2 = <Array<clsViewpointAttachmentEN>>jsonData;
            });
            //获取点赞数据
            //const responseRecCount6 = await ViewpointLikeLog_GetObjLstAsync(strWhereCondLike).then((jsonData) => {
            //    arrViewpointLikeLogObjLst = <Array<clsViewpointLikeLogEN>>jsonData; 
            //});//老方法
            const responseRecCount6 = await SysVote_GetObjLstAsync(strWhereCondLike).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });

            //获取相关概念数据
            const responseRecCount7 = await vgs_PConceptRela_GetObjLstAsync(strWhereConcept).then((jsonData) => {
                arrvgs_PConceptRelaObjLst = <Array<clsvgs_PConceptRelaEN>>jsonData;
            });

            //客观事实
            const responseRecCount8 = await vgs_PTopicObjectiveRela_GetObjLstAsync(strWhereFacts).then((jsonData) => {
                arrvgs_PTopicObjectiveRelaObjLst1 = <Array<clsvgs_PTopicObjectiveRelaEN>>jsonData;
            });

            //客观数据   
            const responseRecCount9 = await vgs_PTopicObjectiveRela_GetObjLstAsync(strWhereBasis).then((jsonData) => {
                arrvgs_PTopicObjectiveRelaObjLst2 = <Array<clsvgs_PTopicObjectiveRelaEN>>jsonData;
            });

            //用户分数  
            const responseRecCount10 = await vSysComment_GetObjLstAsync(strWhereCond10).then((jsonData) => {
                arrvSysCommentObjLst = <Array<clsvSysCommentEN>>jsonData;
            });

            //获取技能
            const responseRecCount12 = await vgs_PSkillRela_GetObjLstAsync(strWhereSysskill).then((jsonData) => {
                arrvgs_SkillObjLst = <Array<clsvgs_PSkillRelaEN>>jsonData;
            });
            //社会关系
            const responseRecCount13 = await vgs_PSocialRela_GetObjLstAsync(strWhereSysSocialRelations).then((jsonData) => {
                arrvgs_PSocialRelaObjLst = <Array<clsvgs_PSocialRelaEN>>jsonData;
            });

            //相关概念附件图片
            const responseRecCount14 = await ConceptAttachment_GetObjLstAsync(strWhereCondAttachment).then((jsonData) => {
                arrConceptAttachmentObjLst2 = <Array<clsConceptAttachmentEN>>jsonData;
            });


            //客观附件图片
            const responseRecCount15 = await ObjectiveAttachment_GetObjLstAsync(strWhereCondAttachment).then((jsonData) => {
                arrObjectiveAttachmentObjLst2 = <Array<clsObjectiveAttachmentEN>>jsonData;
            });

            //得到管理员教师
            var strWhereUserRoleRel: string = " roleId in(00620001,00620002) And QxprjId='0062' order by userId asc ";

            var arrvUserRoleRelationObjLst: Array<clsvQxUserRoleRelationEN> = [];
            const responseRecCount11 = await vQxUserRoleRelation_GetObjLstAsync(strWhereUserRoleRel).then((jsonData) => {
                arrvUserRoleRelationObjLst = <Array<clsvQxUserRoleRelationEN>>jsonData;
            });

            //得到学生数据
            //获取用户缓存数据
            var arrvUserStuNameObjLst: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
            //var strWhereUserName: string = " roleId in (00620001,00620002,00620003) And QxprjId='0062' And userName is not null order by userId asc ";

            //var arrvUserStuNameObjLst: Array<clsvQxUserRoleRelationEN> = [];
            //const responseRecCount16 = await vQxUserRoleRelation_GetObjLstAsync(strWhereUserName).then((jsonData) => {
            //    arrvUserStuNameObjLst = <Array<clsvQxUserRoleRelationEN>>jsonData;
            //});

            var strhtml: string = '<div style="font-size:20px; color: #009688; font-weight: bold; margin-bottom:10px;" id="TopicTitle">当前主题：' + $("#hidTopicName").val() + '</div>';
            ////用户
            //strhtml += '<div class="info" id="infoUser"><div class="title btn-1"><a href="#" title="相关用户">相关用户</a></div><ul class="artlist">';
            //var u = 0;//给内容加个序号
            //for (var i = 0; i < arrvRTUserRelaObjLst.length; i++) {
            //    u++;
            //    //strhtml += u + "." + arrvRTUserRelaObjLst[i].userName + "&nbsp;&nbsp;&nbsp;主题用户角色：(" + arrvRTUserRelaObjLst[i].topicUserRoleName + ")&nbsp;所属主题：" + arrvRTUserRelaObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>";
            //    strhtml += '<li><span class="rowtit color1">' + u + '.</span><span class="abstract-text">' + arrvRTUserRelaObjLst[i].userName + '</span>&nbsp;&nbsp;&nbsp;<span class="rowtit color1">角色：</span><span class="abstract-text">(' + arrvRTUserRelaObjLst[i].topicUserRoleName + ')</span></li>';


            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';

            //    var objComment = arrvSysCommentObjLst.find(x => x.tableKey == arrvRTUserRelaObjLst[i].userId);
            //    if (objComment != null) {

            //        strhtml += '&nbsp;&nbsp;教师评分:' + objComment.score;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;暂无教师打分！';
            //        if ($("#hidRoleId").val() != "00620003") {
            //            strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTUserRelaObjLst[i].userId + '","08","' + arrvRTUserRelaObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
            //        }
            //    }


            //    strhtml += '</li>';
            //}
            //strhtml += '</ul></div>';



            ////论文
            //strhtml += '<div class="info" id="infoPaper"><div class="title btn-2"><a href="#" title="相关论文">相关论文</a></div><ul class="artlist">';
            //var p = 0;//给内容加个序号
            //for (var i = 0; i < arrvRTPaperRelaObjLst.length; i++) {
            //    p++;
            //    //strhtml += p + "." + arrvRTPaperRelaObjLst[i].paperTitle + "&nbsp;&nbsp;所属主题：" + arrvRTPaperRelaObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>";
            //    strhtml += '<li><span class="rowtit color2">' + p + '.</span><span class="abstract-text">' + arrvRTPaperRelaObjLst[i].paperTitle + '</span>';

            //    strhtml += "<span class=\"colorRed\" style=\"padding-left:50px;\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvRTPaperRelaObjLst[i].paperId + "')\">pdf查看</span></li>";
            //    //<a href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvRTPaperRelaObjLst[i].paperId + "')\">pdf查看</a>

            //}
            //strhtml += '</ul></div>';



            ////个人观点
            //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3"><a href="#" title="个人观点">个人观点</a></div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvgs_PViewpointRelaObjLst1.length; i++) {
            //    //得到viewpointId；
            //    var strViewpointId = arrvgs_PViewpointRelaObjLst1[i].viewpointId;
            //    v++;
            //    strhtml += '<li><span class="rowtit color3 btnLeft">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst1[i].viewpointName + '</span>';
            //    if (arrvgs_PViewpointRelaObjLst1[i].versionCount > 0 && arrvgs_PViewpointRelaObjLst1[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('个人观点历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PViewpointRelaObjLst1[i].viewpointId + "&Type=03')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst1[i].viewpointContent + '</span></li>';
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst1[i].viewpointTypeName + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvgs_PViewpointRelaObjLst1[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst1[i].reason + '</span></li>';

            //    //查询附件
            //    arrViewpointAttachmentObjLst = arrViewpointAttachmentObjLst2.filter(x => x.viewpointId == strViewpointId);
            //    if (arrViewpointAttachmentObjLst.length > 0) {
            //        for (var y = 0; y < arrViewpointAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrViewpointAttachmentObjLst[y].filePath;
            //            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrViewpointAttachmentObjLst[y].viewpointAttachmentId + '"/></div></li>';
            //        }
            //    }


            //    //获取引用人；编辑人、用户名称
            //    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人
            //    var CacitionUserName;//引用人

            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PViewpointRelaObjLst1[i].updUser);//技能引用人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        CacitionUserName = arrvUsers[j].userName;
            //        break;
            //    }
            //    ////获取技能编辑人；
            //    //arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PViewpointRelaObjLst1[i].viewsUserId);//技能编辑人
            //    //for (var j = 0; j < arrvUsers.length; j++) {
            //    //    UpdUserName = arrvUsers[j].userName;
            //    //    break;
            //    //}



            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvgs_PViewpointRelaObjLst1[i].updUser);

            //    if (objUserRoleRel != null) {
            //        if (arrvgs_PViewpointRelaObjLst1[i].viewsUserId == arrvgs_PViewpointRelaObjLst1[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvgs_PViewpointRelaObjLst1[i].ViewsUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvgs_PViewpointRelaObjLst1[i].ViewsUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
            //        }
            //    }
            //    else {
            //        if (arrvgs_PViewpointRelaObjLst1[i].viewsUserId == arrvgs_PViewpointRelaObjLst1[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用人]：</span>' + arrvgs_PViewpointRelaObjLst1[i].ViewsUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvgs_PViewpointRelaObjLst1[i].ViewsUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            //        }
            //    }

            //    if (arrvgs_PViewpointRelaObjLst1[i].viewsDate == arrvgs_PViewpointRelaObjLst1[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用时间]：</span>' + arrvgs_PViewpointRelaObjLst1[i].viewsDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvgs_PViewpointRelaObjLst1[i].viewsDate + '&nbsp;/&nbsp;' + arrvgs_PViewpointRelaObjLst1[i].updDate;
            //    }



            //    if (objUserRoleRel == null) {
            //        //是否提交
            //        if (arrvgs_PViewpointRelaObjLst1[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';

            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[评论]：</span>';

            //            //var objLike = arrViewpointLikeLogObjLst.find(x => x.viewpointId == strViewpointId);//老方法
            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strViewpointId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PViewpointRelaObjLst1[i].viewpointId + '","' + arrvgs_PViewpointRelaObjLst1[i].viewsUserId + '","03")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PViewpointRelaObjLst1[i].viewpointId + '","' + arrvgs_PViewpointRelaObjLst1[i].viewsUserId + '","03")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvgs_PViewpointRelaObjLst1[i].okCount + '&nbsp;&nbsp;';
            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue" >评论数:' + arrvgs_PViewpointRelaObjLst1[i].appraiseCount + '</span >';
            //            //评分

            //            if (arrvgs_PViewpointRelaObjLst1[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvgs_PViewpointRelaObjLst1[i].score;
            //            }
            //            if (arrvgs_PViewpointRelaObjLst1[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvgs_PViewpointRelaObjLst1[i].teaScore;
            //            }
            //            if (arrvgs_PViewpointRelaObjLst1[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvgs_PViewpointRelaObjLst1[i].stuScore;
            //            }

            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('个人观点评论', '../GraduateEduTools/SysComment?Key=" + arrvgs_PViewpointRelaObjLst1[i].viewpointId + "&Type=03&User=" + arrvgs_PViewpointRelaObjLst1[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";

            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" data-toggle="modal" onclick = btnShowAppraise_Click("' + arrvgs_PViewpointRelaObjLst1[i].viewpointId + '","03","' + arrvgs_PViewpointRelaObjLst1[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';


            //            strhtml += '</li>';
            //        } else {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
            //        }
            //    } else {
            //        strhtml += '</li>';
            //    }

            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';




            ////专家观点
            //strhtml += '<div class="info" id="infoExpert"><div class="title btn-3"><a href="#" title="专家观点">专家观点</a></div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvgs_PViewpointRelaObjLst2.length; i++) {
            //    //得到viewpointId；
            //    var strViewpointId = arrvgs_PViewpointRelaObjLst2[i].viewpointId;
            //    v++;

            //    //strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst2[i].viewpointName + '</span></li>';
            //    strhtml += '<li><span class="rowtit color3 btnLeft">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst2[i].viewpointName + '</span>';
            //    if (arrvgs_PViewpointRelaObjLst2[i].versionCount > 0 && arrvgs_PViewpointRelaObjLst2[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('专家观点历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PViewpointRelaObjLst2[i].viewpointId + "&Type=04')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst2[i].viewpointContent + '</span></li>';
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst2[i].viewpointTypeName + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvgs_PViewpointRelaObjLst2[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst2[i].reason + '</span></li>';


            //    //查询附件
            //    arrViewpointAttachmentObjLst = arrViewpointAttachmentObjLst2.filter(x => x.viewpointId == strViewpointId);
            //    if (arrViewpointAttachmentObjLst2.length > 0) {
            //        for (var y = 0; y < arrViewpointAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrViewpointAttachmentObjLst[y].filePath;
            //            strhtml += '<br/><li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrViewpointAttachmentObjLst[y].viewpointAttachmentId + '"/></div></li>';
            //        }
            //    }

            //    //获取引用人；编辑人、用户名称
            //    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人
            //    var CacitionUserName;//引用人

            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PViewpointRelaObjLst2[i].updUser);//技能引用人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        CacitionUserName = arrvUsers[j].userName;
            //        break;
            //    }
            //    ////获取技能编辑人；
            //    //arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PViewpointRelaObjLst1[i].viewsUserId);//技能编辑人
            //    //for (var j = 0; j < arrvUsers.length; j++) {
            //    //    UpdUserName = arrvUsers[j].userName;
            //    //    break;
            //    //}


            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvgs_PViewpointRelaObjLst2[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvgs_PViewpointRelaObjLst2[i].viewsUserId == arrvgs_PViewpointRelaObjLst2[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvgs_PViewpointRelaObjLst2[i].ViewsUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvgs_PViewpointRelaObjLst2[i].ViewsUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
            //        }
            //    }
            //    else {
            //        if (arrvgs_PViewpointRelaObjLst2[i].viewsUserId == arrvgs_PViewpointRelaObjLst2[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用人]：</span>' + arrvgs_PViewpointRelaObjLst2[i].ViewsUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvgs_PViewpointRelaObjLst2[i].ViewsUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            //        }
            //    }

            //    if (arrvgs_PViewpointRelaObjLst2[i].viewsDate == arrvgs_PViewpointRelaObjLst2[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用时间]：</span>' + arrvgs_PViewpointRelaObjLst2[i].viewsDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvgs_PViewpointRelaObjLst2[i].viewsDate + '&nbsp;/&nbsp;' + arrvgs_PViewpointRelaObjLst2[i].updDate;
            //    }


            //    if (objUserRoleRel == null) {

            //        if (arrvgs_PViewpointRelaObjLst2[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';

            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[评论]：</span>';
            //            //点赞
            //            //var objLike = arrViewpointLikeLogObjLst.find(x => x.viewpointId == strViewpointId);//老方法
            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strViewpointId);//新0605
            //            //if (objLike == null) {
            //            //    strhtml += '<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + arrvgs_PViewpointRelaObjLst2[i].viewpointId + '")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            //} else {
            //            //    strhtml += '<a href="javascript:void(0)" onclick = btnAddLikeLog_Click("' + arrvgs_PViewpointRelaObjLst2[i].viewpointId + '")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            //}
            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PViewpointRelaObjLst2[i].viewpointId + '","' + arrvgs_PViewpointRelaObjLst2[i].viewsUserId + '","04")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PViewpointRelaObjLst2[i].viewpointId + '","' + arrvgs_PViewpointRelaObjLst2[i].viewsUserId + '","04")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvgs_PViewpointRelaObjLst2[i].okCount + '&nbsp;&nbsp;';
            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span  style="color:royalblue" >评论数:' + arrvgs_PViewpointRelaObjLst2[i].appraiseCount + '</span >';
            //            //评分
            //            if (arrvgs_PViewpointRelaObjLst2[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvgs_PViewpointRelaObjLst2[i].score;
            //            }
            //            if (arrvgs_PViewpointRelaObjLst2[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvgs_PViewpointRelaObjLst2[i].teaScore;
            //            }
            //            if (arrvgs_PViewpointRelaObjLst2[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvgs_PViewpointRelaObjLst2[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('专家观点评论', '../GraduateEduTools/SysComment?Key=" + arrvgs_PViewpointRelaObjLst2[i].viewpointId + "&Type=04&User=" + arrvgs_PViewpointRelaObjLst2[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvgs_PViewpointRelaObjLst2[i].viewpointId + '","04","' + arrvgs_PViewpointRelaObjLst2[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
            //            strhtml += '</li>';
            //        } else {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
            //        }
            //    } else {
            //        strhtml += '</li>';
            //    }


            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';



            ////相关概念
            //strhtml += '<div class="info" id="infoConcept"><div class="title btn-4"><a href="#" title="相关概念">相关概念</a></div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvgs_PConceptRelaObjLst.length; i++) {
            //    //得到概念Id；
            //    var strConceptId = arrvgs_PConceptRelaObjLst[i].conceptId;
            //    v++;
            //    //strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvgs_PConceptRelaObjLst[i].conceptName + '</span></li>';

            //    strhtml += '<li><span class="rowtit color4 btnLeft">' + v + '.[概念]：</span><span class="abstract-text">' + arrvgs_PConceptRelaObjLst[i].conceptName + '</span>';
            //    if (arrvgs_PConceptRelaObjLst[i].versionCount > 0 && arrvgs_PConceptRelaObjLst[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('相关概念历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PConceptRelaObjLst[i].conceptId + "&Type=05')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrvgs_PConceptRelaObjLst[i].conceptContent + '</span></li>';

            //    //查询附件
            //    arrConceptAttachmentObjLst = arrConceptAttachmentObjLst2.filter(x => x.conceptId == strConceptId);
            //    if (arrConceptAttachmentObjLst.length > 0) {
            //        for (var y = 0; y < arrConceptAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrConceptAttachmentObjLst[y].filePath;
            //            //strhtml += '<li><img src="' + strAddressAndPortfull + '" style="max-width:500px; margin-left: 10px; " alt="" id="txtImgPath' + arrConceptAttachmentObjLst[y].conceptAttachmentId + '"/></li>';
            //            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrConceptAttachmentObjLst[y].conceptAttachmentId + '"/></div></li>';
            //        }
            //    }

            //    //获取引用人；编辑人、用户名称
            //    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人
            //    var CacitionUserName;//引用人

            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PConceptRelaObjLst[i].updUser);//技能引用人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        CacitionUserName = arrvUsers[j].userName;
            //        break;
            //    }


            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvgs_PConceptRelaObjLst[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvgs_PConceptRelaObjLst[i].concepUserId == arrvgs_PConceptRelaObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvgs_PConceptRelaObjLst[i].ConcepUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvgs_PConceptRelaObjLst[i].ConcepUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvgs_PConceptRelaObjLst[i].concepUserId == arrvgs_PConceptRelaObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用人]：</span>' + arrvgs_PConceptRelaObjLst[i].ConcepUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvgs_PConceptRelaObjLst[i].ConcepUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            //        }
            //    }

            //    if (arrvgs_PConceptRelaObjLst[i].concepDate == arrvgs_PConceptRelaObjLst[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvgs_PConceptRelaObjLst[i].concepDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvgs_PConceptRelaObjLst[i].concepDate + '&nbsp;/&nbsp;' + arrvgs_PConceptRelaObjLst[i].updDate;
            //    }
            //    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvgs_PConceptRelaObjLst[i].concepDate + '&nbsp;/&nbsp;' + arrvgs_PConceptRelaObjLst[i].updDate + '</li>';

            //    if (objUserRoleRel == null) {


            //        if (arrvgs_PConceptRelaObjLst[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';


            //            //点赞

            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strConceptId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PConceptRelaObjLst[i].conceptId + '","' + arrvgs_PConceptRelaObjLst[i].concepUserId + '","05")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PConceptRelaObjLst[i].conceptId + '","' + arrvgs_PConceptRelaObjLst[i].concepUserId + '","05")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvgs_PConceptRelaObjLst[i].okCount + '&nbsp;&nbsp;';



            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue")>评论数:' + arrvgs_PConceptRelaObjLst[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvgs_PConceptRelaObjLst[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvgs_PConceptRelaObjLst[i].score;
            //            }
            //            if (arrvgs_PConceptRelaObjLst[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvgs_PConceptRelaObjLst[i].teaScore;
            //            }
            //            if (arrvgs_PConceptRelaObjLst[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvgs_PConceptRelaObjLst[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('相关概念评论', '../GraduateEduTools/SysComment?Key=" + arrvgs_PConceptRelaObjLst[i].conceptId + "&Type=05&User=" + arrvgs_PConceptRelaObjLst[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvgs_PConceptRelaObjLst[i].conceptId + '","05","' + arrvgs_PConceptRelaObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
            //            strhtml += '</li>';
            //        } else {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
            //        }
            //    } else {
            //        strhtml += '</li>';
            //    }

            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

            //}
            //strhtml += '</ul></div>';


            ////客观事实
            //strhtml += '<div class="info" id="infoFacts"><div class="title btn-5"><a href="#" title="客观事实">客观事实</a></div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvgs_PTopicObjectiveRelaObjLst1.length; i++) {
            //    var FactTopicObjectiveId = arrvgs_PTopicObjectiveRelaObjLst1[i].topicObjectiveId;
            //    v++;
            //    //strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst1[i].objectiveName + '</span></li>';

            //    strhtml += '<li><span class="rowtit color6 btnLeft">' + v + '.[标题]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst1[i].objectiveName + '</span>';
            //    if (arrvgs_PTopicObjectiveRelaObjLst1[i].versionCount > 0 && arrvgs_PTopicObjectiveRelaObjLst1[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('客观事实历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PTopicObjectiveRelaObjLst1[i].topicObjectiveId + "&Type=06')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst1[i].objectiveContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst1[i].conclusion + '</span></li>';

            //    //查询附件
            //    arrObjectiveAttachmentObjLst = arrObjectiveAttachmentObjLst2.filter(x => x.topicObjectiveId == FactTopicObjectiveId);
            //    if (arrObjectiveAttachmentObjLst.length > 0) {
            //        for (var y = 0; y < arrObjectiveAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrObjectiveAttachmentObjLst[y].filePath;
            //            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrObjectiveAttachmentObjLst[y].objectiveAttachmentId + '"/></div></li>';
            //        }
            //    }
            //    //获取引用人；编辑人、用户名称
            //    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人
            //    var CacitionUserName;//引用人

            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PTopicObjectiveRelaObjLst1[i].updUser);//技能引用人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        CacitionUserName = arrvUsers[j].userName;
            //        break;
            //    }
            //    ////获取技能编辑人；
            //    //arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PViewpointRelaObjLst1[i].viewsUserId);//技能编辑人
            //    //for (var j = 0; j < arrvUsers.length; j++) {
            //    //    UpdUserName = arrvUsers[j].userName;
            //    //    break;
            //    //}
            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvgs_PTopicObjectiveRelaObjLst1[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvgs_PTopicObjectiveRelaObjLst1[i].objUserId == arrvgs_PTopicObjectiveRelaObjLst1[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvgs_PTopicObjectiveRelaObjLst1[i].ObjUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvgs_PTopicObjectiveRelaObjLst1[i].ObjUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvgs_PTopicObjectiveRelaObjLst1[i].objUserId == arrvgs_PTopicObjectiveRelaObjLst1[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑引用人]：</span>' + arrvgs_PTopicObjectiveRelaObjLst1[i].ObjUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvgs_PTopicObjectiveRelaObjLst1[i].ObjUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            //        }
            //    }
            //    if (arrvgs_PTopicObjectiveRelaObjLst1[i].objDate == arrvgs_PTopicObjectiveRelaObjLst1[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvgs_PTopicObjectiveRelaObjLst1[i].objDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvgs_PTopicObjectiveRelaObjLst1[i].objDate + '&nbsp;/&nbsp;' + arrvgs_PTopicObjectiveRelaObjLst1[i].updDate;
            //    }
            //    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvgs_PTopicObjectiveRelaObjLst1[i].objDate + '&nbsp;/&nbsp;' + arrvgs_PTopicObjectiveRelaObjLst1[i].updDate + '</li>';

            //    if (objUserRoleRel == null) {

            //        if (arrvgs_PTopicObjectiveRelaObjLst1[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';

            //            //点赞

            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == FactTopicObjectiveId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PTopicObjectiveRelaObjLst1[i].topicObjectiveId + '","' + arrvgs_PTopicObjectiveRelaObjLst1[i].objUserId + '","06")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PTopicObjectiveRelaObjLst1[i].topicObjectiveId + '","' + arrvgs_PTopicObjectiveRelaObjLst1[i].objUserId + '","06")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvgs_PTopicObjectiveRelaObjLst1[i].okCount + '&nbsp;&nbsp;';

            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue">评论数:' + arrvgs_PTopicObjectiveRelaObjLst1[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvgs_PTopicObjectiveRelaObjLst1[i].score != null) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvgs_PTopicObjectiveRelaObjLst1[i].score;
            //            }
            //            if (arrvgs_PTopicObjectiveRelaObjLst1[i].teaScore != null) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvgs_PTopicObjectiveRelaObjLst1[i].teaScore;
            //            }
            //            if (arrvgs_PTopicObjectiveRelaObjLst1[i].stuScore != null) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvgs_PTopicObjectiveRelaObjLst1[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('客观事实评论', '../GraduateEduTools/SysComment?Key=" + arrvgs_PTopicObjectiveRelaObjLst1[i].topicObjectiveId + "&Type=06&User=" + arrvgs_PTopicObjectiveRelaObjLst1[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvgs_PTopicObjectiveRelaObjLst1[i].topicObjectiveId + '","06","' + arrvgs_PTopicObjectiveRelaObjLst1[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
            //            strhtml += '</li>';
            //        } else {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
            //        }
            //    } else {
            //        strhtml += '</li>';
            //    }

            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //    //arrvRTTopicObjectiveRelaObjLst1.sourceId

            //}
            //strhtml += '</ul></div>';


            ////客观数据 
            //strhtml += '<div class="info" id="infoBasis"><div class="title btn-5"><a href="#" title="客观数据">客观数据</a></div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvgs_PTopicObjectiveRelaObjLst2.length; i++) {
            //    var BasisTopicObjectiveId = arrvgs_PTopicObjectiveRelaObjLst2[i].topicObjectiveId;
            //    v++;
            //    //strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst2[i].objectiveName + '</span></li>';
            //    strhtml += '<li><span class="rowtit color6 btnLeft">' + v + '.[标题]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst2[i].objectiveName + '</span>';
            //    if (arrvgs_PTopicObjectiveRelaObjLst2[i].versionCount > 0 && arrvgs_PTopicObjectiveRelaObjLst2[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('客观数据历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PTopicObjectiveRelaObjLst2[i].topicObjectiveId + "&Type=07')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst2[i].objectiveContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst2[i].conclusion + '</span></li>';

            //    //查询附件
            //    arrObjectiveAttachmentObjLst = arrObjectiveAttachmentObjLst2.filter(x => x.topicObjectiveId == FactTopicObjectiveId);
            //    if (arrObjectiveAttachmentObjLst.length > 0) {
            //        for (var y = 0; y < arrObjectiveAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrObjectiveAttachmentObjLst[y].filePath;
            //            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '" alt="" data-action="zoom" id="txtImgPath' + arrObjectiveAttachmentObjLst[y].objectiveAttachmentId + '"/></div></li>';
            //        }
            //    }
            //    //获取引用人；编辑人、用户名称
            //    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人
            //    var CacitionUserName;//引用人

            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PTopicObjectiveRelaObjLst2[i].updUser);//技能引用人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        CacitionUserName = arrvUsers[j].userName;
            //        break;
            //    }
            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvgs_PTopicObjectiveRelaObjLst2[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvgs_PTopicObjectiveRelaObjLst2[i].objUserId == arrvgs_PTopicObjectiveRelaObjLst2[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvgs_PTopicObjectiveRelaObjLst2[i].ObjUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvgs_PTopicObjectiveRelaObjLst2[i].ObjUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvgs_PTopicObjectiveRelaObjLst2[i].objUserId == arrvgs_PTopicObjectiveRelaObjLst2[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑引用人]：</span>' + arrvgs_PTopicObjectiveRelaObjLst2[i].ObjUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvgs_PTopicObjectiveRelaObjLst2[i].ObjUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            //        }
            //    }

            //    if (arrvgs_PTopicObjectiveRelaObjLst2[i].objDate == arrvgs_PTopicObjectiveRelaObjLst2[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvgs_PTopicObjectiveRelaObjLst2[i].objDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvgs_PTopicObjectiveRelaObjLst2[i].objDate + '&nbsp;/&nbsp;' + arrvgs_PTopicObjectiveRelaObjLst2[i].updDate;
            //    }

            //    if (objUserRoleRel == null) {

            //        if (arrvgs_PTopicObjectiveRelaObjLst2[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';

            //            //点赞

            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == BasisTopicObjectiveId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PTopicObjectiveRelaObjLst2[i].topicObjectiveId + '","' + arrvgs_PTopicObjectiveRelaObjLst2[i].objUserId + '","07")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PTopicObjectiveRelaObjLst2[i].topicObjectiveId + '","' + arrvgs_PTopicObjectiveRelaObjLst2[i].objUserId + '","07")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvgs_PTopicObjectiveRelaObjLst2[i].okCount + '&nbsp;&nbsp;';


            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue">评论数:' + arrvgs_PTopicObjectiveRelaObjLst2[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvgs_PTopicObjectiveRelaObjLst2[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvgs_PTopicObjectiveRelaObjLst2[i].score;
            //            }
            //            if (arrvgs_PTopicObjectiveRelaObjLst2[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvgs_PTopicObjectiveRelaObjLst2[i].teaScore;
            //            }
            //            if (arrvgs_PTopicObjectiveRelaObjLst2[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvgs_PTopicObjectiveRelaObjLst2[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('客观事实评论', '../GraduateEduTools/SysComment?Key=" + arrvgs_PTopicObjectiveRelaObjLst2[i].topicObjectiveId + "&Type=07&User=" + arrvgs_PTopicObjectiveRelaObjLst2[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvgs_PTopicObjectiveRelaObjLst2[i].topicObjectiveId + '","07","' + arrvRTTopicObjectiveRelaObjLst2[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
            //            strhtml += '</li>';
            //        } else {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
            //        }
            //    } else {
            //        strhtml += '</li>';
            //    }
            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';



            ////技能
            //strhtml += '<div class="info" id="infoSysskill"><div class="title btn-4"><a href="#" title="技能">技能</a></div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvgs_SkillObjLst.length; i++) {
            //    //得到技能Id；
            //    var strSkillId = arrvgs_SkillObjLst[i].skillId;
            //    v++;
            //    //strhtml += '<li><span class="rowtit color4">' + v + '.[技能]：</span><span class="abstract-text">' + arrvgs_SkillObjLst[i].conceptName + '</span></li>';

            //    strhtml += '<li><span class="rowtit color4 btnLeft">' + v + '.[技能名称]：</span><span class="abstract-text">' + arrvgs_SkillObjLst[i].skillName + '</span>';
            //    if (arrvgs_SkillObjLst[i].versionCount > 0 && arrvgs_SkillObjLst[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('相关技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_SkillObjLst[i].skillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[实施过程]：</span><span class="abstract-text">' + arrvgs_SkillObjLst[i].process + '</span></li>';

            //    //获取引用人；编辑人、用户名称
            //    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人
            //    var CacitionUserName;//引用人
            //    //获取技能引用人；
            //    //arrvUsers = arrvUserRoleRelationObjLst.filter(x => x.userId == arrvgs_SkillObjLst[i].updUser);//技能引用人
            //    //for (var j = 0; j < arrvUsers.length; j++) {
            //    //    CacitionUserName = arrvUsers[j].userName;
            //    //    break;
            //    //}
            //    ////获取技能编辑人；
            //    //arrvUsers = arrvUserRoleRelationObjLst.filter(x => x.userId == arrvgs_SkillObjLst[i].skillUpdUser);//技能编辑人
            //    //for (var j = 0; j < arrvUsers.length; j++) {
            //    //    UpdUserName = arrvUsers[j].userName;
            //    //    break;
            //    //}
            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_SkillObjLst[i].updUser);//技能引用人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        CacitionUserName = arrvUsers[j].userName;
            //        break;
            //    }
            //    //获取技能编辑人；
            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_SkillObjLst[i].skillUserId);//技能编辑人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        UpdUserName = arrvUsers[j].userName;
            //        break;
            //    }

            //    //如果该技能是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvgs_SkillObjLst[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvgs_SkillObjLst[i].skillUserId == arrvgs_SkillObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + UpdUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvgs_SkillObjLst[i].skillUserId == arrvgs_SkillObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用人]：</span>' + UpdUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用人]：</span>' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            //        }
            //    }

            //    if (arrvgs_SkillObjLst[i].skillDate == arrvgs_SkillObjLst[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvgs_SkillObjLst[i].skillDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvgs_SkillObjLst[i].skillDate + '&nbsp;/&nbsp;' + arrvgs_SkillObjLst[i].updDate;
            //    }


            //    if (objUserRoleRel == null) {


            //        if (arrvgs_SkillObjLst[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';


            //            //点赞

            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSkillId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_SkillObjLst[i].skillId + '","' + arrvgs_SkillObjLst[i].skillUserId + '","09")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_SkillObjLst[i].skillId + '","' + arrvgs_SkillObjLst[i].skillUserId + '","09")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvgs_SkillObjLst[i].okCount + '&nbsp;&nbsp;';



            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue")>评论数:' + arrvgs_SkillObjLst[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvgs_SkillObjLst[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvgs_SkillObjLst[i].score;
            //            }
            //            if (arrvgs_SkillObjLst[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvgs_SkillObjLst[i].teaScore;
            //            }
            //            if (arrvgs_SkillObjLst[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvgs_SkillObjLst[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('操作技能评论', '../GraduateEduTools/SysComment?Key=" + arrvgs_SkillObjLst[i].skillId + "&Type=09&User=" + arrvgs_SkillObjLst[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvgs_SkillObjLst[i].conceptId + '","05","' + arrvgs_PConceptRelaObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
            //            strhtml += '</li>';
            //        } else {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
            //        }
            //    } else {
            //        strhtml += '</li>';
            //    }

            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

            //}
            //strhtml += '</ul></div>';



            ////社会关系
            //strhtml += '<div class="info" id="infoSysSocialRelations"><div class="title btn-3"><a href="#" title="社会关系">社会关系</a></div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvgs_PSocialRelaObjLst.length; i++) {
            //    //得到社会关系Id；
            //    var strSocialId = arrvgs_PSocialRelaObjLst[i].socialId;
            //    v++;
            //    //strhtml += '<li><span class="rowtit color3">' + v + '.[技能]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].conceptName + '</span></li>';

            //    strhtml += '<li><span class="rowtit color3 btnLeft">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].fullName + '</span>';
            //    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].nationality + '</span>';
            //    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].workUnit + '</span>';
            //    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].major + '</span>';
            //    if (arrvgs_PSocialRelaObjLst[i].versionCount > 0 && arrvgs_PSocialRelaObjLst[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('社会关系历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PSocialRelaObjLst[i].socialId + "&Type=09')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].achievement + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].detailedDescription + '</span></li>';

            //    //获取引用人；编辑人、用户名称
            //    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人
            //    var CacitionUserName;//引用人
            //    //获取技能引用人；
 
            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PSocialRelaObjLst[i].updUser);//技能引用人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        CacitionUserName = arrvUsers[j].userName;
            //        break;
            //    }
            //    //获取技能编辑人；
            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvgs_PSocialRelaObjLst[i].socialUserId);//技能编辑人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        UpdUserName = arrvUsers[j].userName;
            //        break;
            //    }


            //    //如果该技能是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvgs_PSocialRelaObjLst[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvgs_PSocialRelaObjLst[i].socialUserId == arrvgs_PSocialRelaObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + UpdUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvgs_PSocialRelaObjLst[i].socialUserId == arrvgs_PSocialRelaObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用人]：</span>' + UpdUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用人]：</span>' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            //        }
            //    }

            //    if (arrvgs_PSocialRelaObjLst[i].socialDate == arrvgs_PSocialRelaObjLst[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用时间]：</span>' + arrvgs_PSocialRelaObjLst[i].socialDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvgs_PSocialRelaObjLst[i].socialDate + '&nbsp;/&nbsp;' + arrvgs_PSocialRelaObjLst[i].updDate;
            //    }


            //    if (objUserRoleRel == null) {


            //        if (arrvgs_PSocialRelaObjLst[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';

            //            //点赞

            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSocialId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PSocialRelaObjLst[i].socialId + '","' + arrvgs_PSocialRelaObjLst[i].socialUserId + '","10")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvgs_PSocialRelaObjLst[i].socialId + '","' + arrvgs_PSocialRelaObjLst[i].socialUserId + '","10")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvgs_PSocialRelaObjLst[i].okCount + '&nbsp;&nbsp;';


            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue")>评论数:' + arrvgs_PSocialRelaObjLst[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvgs_PSocialRelaObjLst[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvgs_PSocialRelaObjLst[i].score;
            //            }
            //            if (arrvgs_PSocialRelaObjLst[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvgs_PSocialRelaObjLst[i].teaScore;
            //            }
            //            if (arrvgs_PSocialRelaObjLst[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvgs_PSocialRelaObjLst[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('社会关系评论', '../GraduateEduTools/SysComment?Key=" + arrvgs_PSocialRelaObjLst[i].socialId + "&Type=10&User=" + arrvgs_PSocialRelaObjLst[i].updUser + "&pubParentId=" + $("#hidTopicRelaId").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvgs_PSocialRelaObjLst[i].conceptId + '","05","' + arrvRTConceptObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
            //            strhtml += '</li>';
            //        } else {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
            //        }
            //    } else {
            //        strhtml += '</li>';
            //    }

            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';

            //}
            //strhtml += '</ul></div>';

            //个人观点
            strhtml += await Public_Viewpoint.BindList_vgs_PViewpointRela("07", "01", arrvgs_PViewpointRelaObjLst1);
            //专家观点
            strhtml += await Public_Viewpoint.BindList_vgs_PViewpointRela("07", "02", arrvgs_PViewpointRelaObjLst2);
            //概念
            strhtml += await Public_Concept.BindList_vgs_PConceptRela("07", arrvgs_PConceptRelaObjLst);
            //客观事实
            strhtml += await Public_TopicObjective.BindList_vgs_PTopicObjectiveRela("07", "01", arrvgs_PTopicObjectiveRelaObjLst1);
            //客观数据
            strhtml += await Public_TopicObjective.BindList_vgs_PTopicObjectiveRela("07", "02", arrvgs_PTopicObjectiveRelaObjLst2);
            //技能
            strhtml += await Public_SysSkill.BindList_vgs_PSkillRela("07", arrvgs_SkillObjLst);
            //社会关系
            strhtml += await Public_SysSocialRelations.BindList_vgs_PSocialRela("07", arrvgs_PSocialRelaObjLst);



            //拼接；
            $("#divContent_list").html(strhtml);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //添加点赞 主键,被点赞用户、点赞类型；
    public async btnAddVote_Click(strViewpointId: string, strUserId: string, strVoteTypeId: string) {
        //thIs.DivName = "divAddNewRecordSave";
        var objSysVoteEN: clsSysVoteEN = new clsSysVoteEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objSysVoteEN.tableKey = strViewpointId;
        objSysVoteEN.voteTypeId = strVoteTypeId;
        objSysVoteEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();//教学班
        objSysVoteEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        objSysVoteEN.updUser = $("#hidUserId").val();// 修改用户Id
        objSysVoteEN.userId = strUserId;//被点赞用户
        var strWhereCond = " 1 =1 and updUser='" + $("#hidUserId").val() + "' and tableKey=" + strViewpointId;
        try {
            const responseText = await SysVote_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经点赞过了，请给其他点赞一下吧！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await SysVote_AddNewRecordAsync(objSysVoteEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {

                var strWhereCond2 = " 1 =1 and tableKey=" + strViewpointId;
                var intVoteCount = await SysVote_GetRecCountByCondAsync(strWhereCond2);


                //通过不同的点赞类型，查询不同的表 把获取到的点赞数据插入到对应的表、表ID数据中
                switch (strVoteTypeId) {
                    case "03":            //个人观点
                        var objViewpointEN: clsViewpointEN = new clsViewpointEN();
                        objViewpointEN.viewpointId = strViewpointId;
                        objViewpointEN.okCount = intVoteCount;

                        objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                            throw "关键字不能为空!";
                        }


                        const responseText1 = Viewpoint_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                this.BindGv_AllTopicRela();
                            }
                            else {
                                var strInfo: string = `点赞不成功!`;
                                alert(strInfo);
                                console.log("点赞不成功");
                            }

                        });
                        break;
                    case "04":            //专家观点
                        var objViewpointEN: clsViewpointEN = new clsViewpointEN();
                        objViewpointEN.viewpointId = strViewpointId;
                        objViewpointEN.okCount = intVoteCount;

                        objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                            throw "关键字不能为空!";
                        }


                        const responseText2 = Viewpoint_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                this.BindGv_AllTopicRela();
                            }
                            else {
                                var strInfo: string = `点赞不成功!`;
                                alert(strInfo);
                                console.log("点赞不成功");
                            }

                        });
                        break;
                    case "05":            //概念
                        var objConceptEN: clsConceptEN = new clsConceptEN();
                        objConceptEN.conceptId = strViewpointId;
                        objConceptEN.okCount = intVoteCount;

                        objConceptEN.sf_UpdFldSetStr = objConceptEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                            throw "关键字不能为空!";
                        }


                        const responseText3 = Concept_UpdateRecordAsync(objConceptEN).then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                this.BindGv_AllTopicRela();
                            }
                            else {
                                var strInfo: string = `点赞不成功!`;
                                alert(strInfo);
                                console.log("点赞不成功");
                            }

                        });
                        break;
                    case "06":            //客观事实
                        var objTopicObjectiveEN: clsTopicObjectiveEN = new clsTopicObjectiveEN();
                        objTopicObjectiveEN.topicObjectiveId = strViewpointId;
                        objTopicObjectiveEN.okCount = intVoteCount;

                        objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                            throw "关键字不能为空!";
                        }


                        const responseText4 = TopicObjective_UpdateRecordAsync(objTopicObjectiveEN).then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                this.BindGv_AllTopicRela();
                            }
                            else {
                                var strInfo: string = `点赞不成功!`;
                                alert(strInfo);
                                console.log("点赞不成功");
                            }

                        });
                        break;
                    case "07":            //客观数据
                        var objTopicObjectiveEN: clsTopicObjectiveEN = new clsTopicObjectiveEN();
                        objTopicObjectiveEN.topicObjectiveId = strViewpointId;
                        objTopicObjectiveEN.okCount = intVoteCount;

                        objTopicObjectiveEN.sf_UpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                            throw "关键字不能为空!";
                        }


                        const responseText5 = TopicObjective_UpdateRecordAsync(objTopicObjectiveEN).then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                this.BindGv_AllTopicRela();
                            }
                            else {
                                var strInfo: string = `点赞不成功!`;
                                alert(strInfo);
                                console.log("点赞不成功");
                            }

                        });
                        break;
                    case "09":            //技能
                        var objysSkillEN: clsSysSkillEN = new clsSysSkillEN();
                        objysSkillEN.skillId = strViewpointId;
                        objysSkillEN.okCount = intVoteCount;

                        objysSkillEN.sf_UpdFldSetStr = objysSkillEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objysSkillEN.skillId == "" || objysSkillEN.skillId == undefined) {
                            throw "关键字不能为空!";
                        }


                        const responseText6 = SysSkill_UpdateRecordAsync(objysSkillEN).then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                this.BindGv_AllTopicRela();
                            }
                            else {
                                var strInfo: string = `点赞不成功!`;
                                alert(strInfo);
                                console.log("点赞不成功");
                            }

                        });
                        break;
                    case "10":            //社会关系
                        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
                        objSysSocialRelationsEN.socialId = strViewpointId;
                        objSysSocialRelationsEN.okCount = intVoteCount;

                        objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                            throw "关键字不能为空!";
                        }


                        const responseText7 = SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN).then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                this.BindGv_AllTopicRela();
                            }
                            else {
                                var strInfo: string = `点赞不成功!`;
                                alert(strInfo);
                                console.log("点赞不成功");
                            }

                        });
                        break;
                    default:
                        var strMsg = "没有数据";
                        alert(strMsg);
                        break;
                }




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





    //添加点赞
    public async btnAddLikeLog_Click() {
        //this.DivName = "divAddNewRecordSave";
        var objViewpointLikeLogEN: clsViewpointLikeLogEN = new clsViewpointLikeLogEN();

        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

        objViewpointLikeLogEN.viewpointId = $("#hidViewpointId").val();
        objViewpointLikeLogEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        objViewpointLikeLogEN.updUserId = $("#hidUserId").val();// 修改用户Id
        var strWhereCond = " 1 =1 and updUser='" + objViewpointLikeLogEN.updUserId + "' and viewpointId=" + objViewpointLikeLogEN.viewpointId;
        try {
            const responseText = await ViewpointLikeLog_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经点赞过这条观点了，请给其他观点点赞一下吧！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await ViewpointLikeLog_AddNewRecordAsync(objViewpointLikeLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {

                const responseBindGv = await this.BindGv_AllTopicRela();
                //var strInfo: string = `点赞成功!`;
                //$('#lblResult40').val(strInfo);
                ////显示信息框
                //alert(strInfo);
            }
            else {
                var strInfo: string = `点赞不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);

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

    //显示评论
    public async btnShowAppraise_Click() {

        var arrgs_PaperDiscussObjLst1: Array<clsgs_PaperDiscussEN> = [];
        var arrgs_PaperDiscussObjLst2: Array<clsgs_PaperDiscussEN> = [];
        var arrgs_PaperDiscussObjLst3: Array<clsgs_PaperDiscussEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        var strUserId = clsPubSessionStorage.GetSession_UserId();


        if ($('#hidOrderbyId').val() == "1") {
            //全部评论
            strWhereCond1 = " parentId='root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' and updUser='" + strUserId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and  discussTypeId='" + $("#hidCommentTypeId").val() + "' and paperId='" + $("#hidTableKey").val() + "' order by updDate Desc";
        }

        //var strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
        //var strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";

        try {

            const responseText1 = await gs_PaperDiscuss_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrgs_PaperDiscussObjLst1 = <Array<clsgs_PaperDiscussEN>>jsonData;
            });
            const responseText2 = await gs_PaperDiscuss_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrgs_PaperDiscussObjLst2 = <Array<clsgs_PaperDiscussEN>>jsonData;
            });

            //获取用户缓存数据
            var arrvUserStuNameObjLst: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            var strhtml = "";
            var varNum = 0;
            $('#J_ShortComment div').remove();
            for (var i = 0; i < arrgs_PaperDiscussObjLst1.length; i++) {
                varNum++;
                //获取用户名
                var arrvUsers: Array<clsvUsersSimEN> = [];
                var UpdUserName;//编辑人
                arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrgs_PaperDiscussObjLst1[i].updUser);//技能引用人
                for (var j = 0; j < arrvUsers.length; j++) {
                    UpdUserName = arrvUsers[j].userName;
                    break;
                }


                strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                if ($("#hidUser").val() == arrgs_PaperDiscussObjLst1[i].updUser) {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842 style="color:red;" > 楼主：' + UpdUserName + '</span>';
                } else {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + UpdUserName + '</span>';
                }
                strhtml += '<span class="comment-time">' + arrgs_PaperDiscussObjLst1[i].updDate + '</span>';
                strhtml += '  <span class="comment-username J_User">' + varNum + '楼</span></p>';
                //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                strhtml += '<div class="comment-content J_CommentContent">' + arrgs_PaperDiscussObjLst1[i].discussContent + '</div>';

                //回复区

                arrgs_PaperDiscussObjLst3 = arrgs_PaperDiscussObjLst2.filter(x => x.parentId == arrgs_PaperDiscussObjLst1[i].discussId);
                if (arrgs_PaperDiscussObjLst3.length > 0) {
                    strhtml += '<div class="reply J_ReplyBlock">';
                    for (var j = 0; j < arrgs_PaperDiscussObjLst3.length; j++) {

                        //获取用户名
                        var arrvUsers: Array<clsvUsersSimEN> = [];
                        var UpdUserName;//编辑人
                        arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrgs_PaperDiscussObjLst3[i].updUser);//技能引用人
                        for (var j = 0; j < arrvUsers.length; j++) {
                            UpdUserName = arrvUsers[j].userName;
                            break;
                        }



                        strhtml += '<div class="reply-block">';

                        strhtml += '<div class="reply-content">';
                        if ($("#hidUser").val() == arrgs_PaperDiscussObjLst3[j].updUser) {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328" style="color:red;"> 楼主(' + UpdUserName + ')</b>：</span>';
                        } else {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328">' + UpdUserName + '</b>：</span>';
                        }
                        strhtml += '' + arrgs_PaperDiscussObjLst3[j].discussContent + '</div>';



                        //strhtml += '<div class="reply-operate reply-operate--hot">'
                        //if (arrgs_PaperDiscussObjLst3[j].scoreType == "2") {
                        //    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrgs_PaperDiscussObjLst3[j].score + '</i></span>';
                        //} else {
                        //    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrgs_PaperDiscussObjLst3[j].score + '</i></span>';
                        //}
                        //strhtml += '<i class="reply-dot">·</i><span>' + arrgs_PaperDiscussObjLst3[j].updDate + '</span>';
                        //strhtml += '</div>';


                        strhtml += '</div>';

                    }
                    strhtml += '</div>';
                }
                ///评论区
                strhtml += '<div class="comment-operate J_CommentOperate clearfix">';
                //if (arrgs_PaperDiscussObjLst1[i].scoreType == "2") {
                //    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrgs_PaperDiscussObjLst1[i].score + '</i></span>';
                //} else {
                //    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrgs_PaperDiscussObjLst1[i].score + '</i></span>';
                //}

                strhtml += '<span class="J_Vote comment-operate-item comment-operate-up">赞<i>1</i></span>';
                strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyComment_Click("' + arrgs_PaperDiscussObjLst1[i].discussId + '")>回复</span>';
                strhtml += '</div>';

                if (strUserId == arrgs_PaperDiscussObjLst1[i].updUser) {
                    strhtml += '<div class="J_Report comment-report" id="J_Report6673850347411436155" onclick=btnDeleteComment_Click("' + arrgs_PaperDiscussObjLst1[i].discussId + '")>删除</div>';
                }
                strhtml += '</div></div>';
            }
            $("#J_ShortComment").append(strhtml);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取数据不成功,${e}.`;
            alert(strMsg);
        }

    }
    //论文思路
    public async liPaperIdea_Click() {
        try {
            const gvResultPaper = await this.BindPaperIdea();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取个人观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //论文观点
    public async liPaperViewpoint_Click() {
        try {
            const gvResultPaper = await this.GetTopicData();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取个人观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //论文初稿
    public async liPaperFirst_Click() {
        try {
            const gvResultPaper = await this.BindGv_PaperFirst("01");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取个人观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //小组讨论
    public async liGroupDiscuss_Click() {
        try {
            var strPaperId = $("#hidPaperRelaId").val();
            $('#hidPaperLogTypeId').val("05");
            $('#hidTableKey').val(strPaperId);//
            $('#hidPaperId').val(strPaperId);//论文主键
            $('#hidCommentTypeId').val("01");

            const gvResultPaper = await this.btnShowAppraise_Click();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取个人观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //论文修改稿
    public async liPaperSecond_Click() {
        try {
            const gvResultPaper = await this.BindGv_PaperFirst("02");

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取个人观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //同伴建议
    public async liPeerAdvice_Click() {
        try {
            var strPaperId = $("#hidPaperRelaId").val();
            $('#hidPaperLogTypeId').val("07");
            $('#hidTableKey').val(strPaperId);//
            $('#hidPaperId').val(strPaperId);//论文主键
            $('#hidCommentTypeId').val("01");
            const gvResultPaper = await this.btnShowAppraise_Click();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取个人观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //论文终稿
    public async liPaperEnd_Click() {
        try {
            const gvResultPaper = await this.BindGv_PaperFirst("03");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取个人观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //论文思路
    public async BindPaperIdea() {
        var strPaperId = $("#hidPaperRelaId").val()
        //通过Id 获得论文思路数据；
        var strWhere = " 1 = 1 And paperId = '" + strPaperId + "'";
        const responseText = await Paper_GetFirstObjAsync(strWhere);
        var objPaperEN: clsPaperEN = <clsPaperEN>responseText;
        if (objPaperEN != null) {
            ////换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            //动态显示对应的数据
            var strhtml = "";
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();
            //论文思路
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号

            //对内容进行换行替换 问题提出
            var strAskQuestion = objPaperEN.askQuestion;
            strAskQuestion = strAskQuestion.replace(/\r\n/g, strBr);
            strAskQuestion = strAskQuestion.replace(/\n/g, strBr);

            //对内容进行换行替换 目前研究的现状
            var strResearchStatus = objPaperEN.researchStatus;
            strResearchStatus = strResearchStatus.replace(/\r\n/g, strBr);
            strResearchStatus = strResearchStatus.replace(/\n/g, strBr);

            //对内容进行换行替换 创新点
            var strInnovationPoints = objPaperEN.innovationPoints;
            strInnovationPoints = strInnovationPoints.replace(/\r\n/g, strBr);
            strInnovationPoints = strInnovationPoints.replace(/\n/g, strBr);

            //对内容进行换行替换 研究设计
            var strResearchDesign = objPaperEN.researchDesign;
            strResearchDesign = strResearchDesign.replace(/\r\n/g, strBr);
            strResearchDesign = strResearchDesign.replace(/\n/g, strBr);

            //对内容进行换行替换  数据处理的维度
            var strDimensionDataProcess = objPaperEN.dimensionDataProcess;
            strDimensionDataProcess = strDimensionDataProcess.replace(/\r\n/g, strBr);
            strDimensionDataProcess = strDimensionDataProcess.replace(/\n/g, strBr);

            //对内容进行换行替换  预期结论
            var strExpectedConclusion = objPaperEN.expectedConclusion;
            strExpectedConclusion = strExpectedConclusion.replace(/\r\n/g, strBr);
            strExpectedConclusion = strExpectedConclusion.replace(/\n/g, strBr);

            //strhtml += v + ".观点：" + arrConceptObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrConceptObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrConceptObjLst[i].viewpointTypeName + ":" + arrConceptObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrConceptObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
            strhtml += '<li><span class="rowtit color3">[问题提出]：</span><span class="abstract-text">' + strAskQuestion + '</span></li>';
            strhtml += '<li><span class="rowtit color3">[目前研究的现状]：</span><span class="abstract-text">' + strResearchStatus + '</span></li>';
            strhtml += '<li><span class="rowtit color3">[创新点]：</span><span class="abstract-text">' + strInnovationPoints + '</span></li>';
            strhtml += '<li><span class="rowtit color3">[研究设计]：</span><span class="abstract-text">' + strResearchDesign + '</span></li>';
            strhtml += '<li><span class="rowtit color3">[数据处理的维度]：</span><span class="abstract-text">' + strDimensionDataProcess + '</span></li>';
            strhtml += '<li><span class="rowtit color3">[预期结论]：</span><span class="abstract-text">' + strExpectedConclusion + '</span></li>';
            strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:70%;">'


            strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + objPaperEN.updDate + '</span>';
            //获取用户名称；根据id；
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
            //获取用户名；
            arrUsers = arrUsers.filter(x => x.userId == objPaperEN.updUser);//用户；


            for (var j = 0; j < arrUsers.length; j++) {
                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrUsers[j].userName + '</span>';
                break;
            }

            strhtml += '&nbsp</div></div></li>';

            strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';

            strhtml += '</ul></div>';

            $("#divDataliPaperIdeaLst").html(strhtml)
        }
        else {

        }
    }
    //论文初稿 strTypeId 区分 初稿、修稿、终稿
    public async BindGv_PaperFirst(strTypeId) {
        //绑定论文pdf
        try {
            var strPaperId = $('#hidPaperId').val();
            var strWhereCond = " 1=1 and paperId ='" + strPaperId + "' order by updDate Asc";

            var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
            arrPaperAttachmentObjLst = await PaperAttachment_GetObjLstAsync(strWhereCond);
            var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
            var strhtml = "";
            var strfilepath = "";

            if (arrPaperAttachmentObjLst.length > 0) {
                for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {
                   //通过排序数据，通过类型 循环标 可以判定 初稿 、修改稿、终稿；
                        if (strTypeId == "01") {
                            if (i == 0) {
                                //初稿
                                strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                                break;
                            }
                        } else if (strTypeId == "02") {
                            if (i == 1) {
                                //修改稿
                                strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                                break;
                            }
                        }
                        else {
                            if (i == 2) { //终稿
                                strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
                                break;
                            }
                        }
                }
            }
            strhtml = "<iframe src='../GraduateEduEx/Pdf?file=" + strfilepath + "' style=\"height:100%;width:99%; min-height:700px;\"></iframe>";
            if (strTypeId == "01") {
                $("#divDataliPaperFirstLst").html(strhtml); 
            } else if (strTypeId == "02") {
                $("#divDataliPaperSecondLst").html(strhtml);
            }
            else {
                $("#divDataliPaperEndLst").html(strhtml);
            }
        }
        catch (e) {
            var strMsg: string = `获取pdf附件数据有问题,${e}.`;
            alert(strMsg);
        }

    }

    //小组讨论 同伴建议
    /* 添加评论内容
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async SubmitAppraise_Click() {
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var strRoleId = clsPubSessionStorage.GetSession_RoleId();

        var strPaperLogTypeId = $('#hidPaperLogTypeId').val();
        var strTableKey = $("#hidTableKey").val();
        //用来区分 小组讨论 或同伴建议 01 02
        var strDiscussTypeId = $("#hidCommentTypeId").val();
        var objgs_PaperDiscussEN: clsgs_PaperDiscussEN = new clsgs_PaperDiscussEN();
        //this.PutDataToSysCommentClass(objSysCommentEN);
        objgs_PaperDiscussEN.paperId = $("#hidTableKey").val();
        objgs_PaperDiscussEN.parentId = $("#hidParentId").val();
        objgs_PaperDiscussEN.discussTypeId = strDiscussTypeId;
        objgs_PaperDiscussEN.userId = $("#hidUser").val();//被评论用户
        objgs_PaperDiscussEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();

        if (strRoleId == "00620003") {
            objgs_PaperDiscussEN.scoreType = "1";

        } else {
            objgs_PaperDiscussEN.scoreType = "2";
        }

        //var strvalue = $("#pin").val();
        ////判断是否有打分 
        //if (strvalue != "" && strvalue != undefined) {
        //    //获取值转化分数
        //    var strScore: string = this.GetScorebyText(strvalue);

        //判断内容是否输入
        if ($("#txtAppraiseContent").val() != "") {
            objgs_PaperDiscussEN.discussContent = $("#txtAppraiseContent").val();// 评议内容
            // objgs_PaperDiscussEN.score = parseInt(strScore);// 打分
            objgs_PaperDiscussEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
            objgs_PaperDiscussEN.updUser = strUserId;// 修改用户Id
            try {
                const responseText2 = await gs_PaperDiscuss_AddNewRecordAsync(objgs_PaperDiscussEN);
                //const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objgs_PaperDiscussEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {


                    //查询 论文、日志类型是否存在；
                    var strWhere = " 1 = 1 And paperId = '" + strTableKey + "' And logTypeId = '" + strPaperLogTypeId + "'";
                    const responseText3 = await gs_OriginalPaperLog_IsExistRecordAsync(strWhere);
                    var bolIsExist: boolean = responseText3;
                    if (bolIsExist == true) {
                        var strInfo: string = `评论成功`;
                        //显示信息框
                        alert(strInfo);
                        HideDialog();
                        $("#btnOKUpdAppraise").attr("disabled", false);
                        const response1 = await this.btnShowAppraise_Click();
                        return true;//一定要有一个返回值，否则会出错！
                    }
                    else {

                        //添加论文日志；
                        const responseText7 = await this.Addgs_OriginalPaperLogSave();

                        var strInfo: string = `评论成功`;
                        //显示信息框
                        alert(strInfo);
                        HideDialog();
                        $("#btnOKUpdAppraise").attr("disabled", false);
                        const response1 = await this.btnShowAppraise_Click();
                    }

                    RefreshWindow();
                }
                else {
                    var strInfo: string = `添加失败!`;
                    //$('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    HideDialog();
                    $("#btnOKUpdAppraise").attr("disabled", false);

                }

                $("#J_PostBtn").attr("disabled", false);
                $("#btnOKUpdAppraise").attr("disabled", false);
                return responseText2;//一定要有一个返回值，否则会出错！
            }
            catch (e) {
                $("#J_PostBtn").attr("disabled", false);
                $("#btnOKUpdAppraise").attr("disabled", false);
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `添加评论不成功,${e}.`;
                alert(strMsg);
            }
        }
        else {
            $("#J_PostBtn").attr("disabled", false);
            $("#btnOKUpdAppraise").attr("disabled", false);
            AlertComment();
            //var strInfo: string = `请输入评语!`;
            ////显示信息框
            //alert(strInfo);
            return;
        }

        //}
        //else {
        //    $("#J_PostBtn").attr("disabled", false);
        //    $("#btnOKUpdAppraise").attr("disabled", false);

        //    AlertScore();
        //    //var strInfo: string = `请选择评分!`;
        //    ////显示信息框
        //    //alert(strInfo);
        //    return;
        //}
        return true;//一定要有一个返回值，否则会出错！
    }
    //添加论文流程日志
    public async Addgs_OriginalPaperLogSave() {


        var objgs_OriginalPaperLogEN: clsgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN();
        this.PutDataTogs_OriginalPaperLog(objgs_OriginalPaperLogEN);

        try {
            const responseText2 = await gs_OriginalPaperLog_AddNewRecordAsync(objgs_OriginalPaperLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                console.log("添加新建论文日志成功");

            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加日志记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }
    public async PutDataTogs_OriginalPaperLog(pobjgs_OriginalPaperLogEN: clsgs_OriginalPaperLogEN) {
        var strPaperId = $("#hidPaperId").val();
        var strPaperLogTypeId = $("#hidPaperLogTypeId").val();
        //通过区分 是小组讨论还是同伴建议
        var strTypeId = $('#hidCommentTypeId').val();
        pobjgs_OriginalPaperLogEN.paperId = strPaperId;
        pobjgs_OriginalPaperLogEN.logTypeId = strPaperLogTypeId;
        switch (strTypeId) {
            case "01":
                pobjgs_OriginalPaperLogEN.logDescription = "小组讨论";
                break;
            case "02":
                pobjgs_OriginalPaperLogEN.logDescription = "同伴建议";
                break;

            default:
                var strMsg = `没有数据处理！`;
                alert(strMsg);
                break;
        }
        //pobjgs_OriginalPaperLogEN.logDescription = "新建论文";
        pobjgs_OriginalPaperLogEN.updUser = clsPubSessionStorage.GetSession_UserId();
        pobjgs_OriginalPaperLogEN.updDate = clsPubFun4Web.getNowDate();
    }

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




    /* 
    删除评论内容
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDeleteComment_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelRecord(strKeyId);
            const response1 = await this.btnShowAppraise_Click();
            // const response2 = await this.SynStatistics();
            //  RefreshWindow();
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
    //public async DelRecord(strCommentId: string) {
    //    try {
    //        const responseText = await gs_PaperDiscuss_DelRecordAsync(strCommentId);
    //        var returnInt: number = responseText;
    //        if (returnInt > 0) {
    //            var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
    //            //显示信息框
    //            alert(strInfo);
    //        }
    //        else {
    //            var strInfo: string = `删除记录不成功!`;
    //            //显示信息框
    //            alert(strInfo);
    //        }
    //        console.log("完成DelRecord!");
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `删除记录不成功. ${e}.`;
    //        alert(strMsg);
    //    }


    //    //return new Promise((resolve, reject) => {
    //    //    try {
    //    //        const responseText = await gs_PaperDiscuss_DelRecordAsync(strCommentId).then((jsonData) => {
    //    //            var returnInt: number = jsonData;
    //    //            if (returnInt > 0) {
    //    //                AlertNo();
    //    //                //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
    //    //                ////显示信息框
    //    //                //alert(strInfo);
    //    //            }
    //    //            else {
    //    //                var strInfo: string = `删除记录不成功!`;
    //    //                //显示信息框
    //    //                alert(strInfo);
    //    //            }
    //    //            console.log("完成DelRecord!");
    //    //            resolve(jsonData);
    //    //        });
    //    //    }
    //    //    catch (e) {
    //    //        console.error('catch(e)=');
    //    //        console.error(e);
    //    //        var strMsg: string = `删除记录不成功. ${e}.`;
    //    //        alert(strMsg);
    //    //    }
    //    //});
    //}



    ////添加删除评论的时候统计其他表的部分数据
    //public async SynStatistics() {
    //    var strCommentTypeId = $("#hidCommentTypeId").val();
    //    var strRoleId = clsPubSessionStorage.GetSession_RoleId();
    //    //论文子观点
    //    if (strCommentTypeId == "02") {
    //        //教师或者管理员权限
    //        if (strRoleId != "00620003") {
    //            var strPaperRWId = $("#hidPubParentId").val();

    //            //添加记录的同时并记录论文读写的教师评价数
    //            var strWhereCond = "   commentTypeId='02' and scoreType='2' and pubParentId=" + strPaperRWId;
    //            var intTeaCount = await SysComment_GetRecCountByCondAsync(strWhereCond);

    //            var objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
    //            objPaperReadWriteEN.paperRWId = strPaperRWId;
    //            objPaperReadWriteEN.teaCount = intTeaCount;

    //            objPaperReadWriteEN.sf_UpdFldSetStr = objPaperReadWriteEN.updFldString;//设置哪些字段被修改(脏字段)
    //            if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
    //                throw "关键字不能为空!";
    //            }

    //            const responseText = await PaperReadWrite_UpdateRecordAsync(objPaperReadWriteEN);
    //            var returnBool: boolean = !!responseText;
    //            if (returnBool == true) {
    //                //刷新缓存
    //                vPaperReadWrite_ReFreshThisCache(clsPublocalStorage.Getid_CurrEduCls());
    //                console.log("添加教师评价数量成功！");
    //            }
    //            else {

    //                console.log("添加教师评价数量失败！");
    //            }
    //            //添加记录的同时并记录论文读写的教师评价数

    //        }
    //    }

    //}


    ///////////////////////////////////////////////////////////////////////////////3个关系列表数据

    ////////////////////////////////////////主题用户关系
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public CombinevRTUserRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.UserId_q != "") {
            //    strWhereCond += ` And ${clsvRTUserRelaEN.con_UserId} like '% ${this.UserId_q}%'`;
            //}
            //if (this.TopicName_q != "") {
            //    strWhereCond += ` And ${clsvRTUserRelaEN.con_TopicName} like '% ${this.TopicName_q}%'`;
            //}

            //判断主题id
            var strTopicId = $("#hidTopicRelaId").val();
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTUserRelaEN.con_TopicId} = '${strTopicId}'`;
            }



        

            ////判断角色 
            ////管理员
            //if (objvUserRoleRelation.roleId == "00620001") {

            //    // $("#btnDelRecord").show();

            //}
            //else if (objvUserRoleRelation.roleId == "00620002") {
            //    //教师
            //    // $("#btnDelRecord").show();
            //    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
            //    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            //}
            //else {
            //    //学生； 
            //    // $("#btnDelRecord").show();
            //    strWhereCond += ` And ${clsvRTUserRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
            //    //学生00620003

            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的记录对象的列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vRTUserRela() {
        var strListDiv: string = this.mstrListDivRtUserRela;
        var strWhereCond = this.CombinevRTUserRelaCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
        try {
            const responseRecCount = await vRTUserRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTUserRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTUserRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            this.BindTab_vRTUserRela(strListDiv, arrvRTUserRelaObjLst);
            console.log("完成BindGv_vRTUserRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vRTUserRela对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrRTUserRelaObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vRTUserRela(divContainer: string, arrvRTUserRelaObjLst: Array<clsvRTUserRelaEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },

                {
                    FldName: "topicName",
                    ColHeader: "栏目主题",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "用户名",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "collegeName",
                    ColHeader: "学院名称",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorName",
                    ColHeader: "专业名称",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },


                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除", TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelUserRelaInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },

            ];
        clsCommonFunc4Web.BindTabV2(o, arrvRTUserRelaObjLst, arrDataColumn, "mId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    //删除主题用户关系
    public async btnDelUserRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelUserRelaRecord(lngKeyId);
            const responseText2 = await this.BindGv_vRTUserRela();
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
    public DelUserRelaRecord(lngmId: number) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTUserRela_DelRecordAsync(lngmId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
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












    //////////////////////////////////////////////////////////////////////////////主题观点关系
    /* 把所有的查询控件内容组合成一个条件串
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
   <returns>条件串(strWhereCond)</returns>
 */
    public CombinevRTViewpointRelaCondition1(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.ViewpointName_q != "") {
            //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.ViewpointName_q}%'`;
            //}
            //if (this.TopicName_q != "") {
            //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicName} like '% ${this.TopicName_q}%'`;
            //}

            ////判断主题id
            //var strTopicId = $("#hidTopicRelaId").val();
            //if (strTopicId != "") {
            //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
            //}

            //判断Paperid
            var strPaperId = $("#hidPaperRelaId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_PaperId} = '${strPaperId}'`;
            }

            strWhereCond += " and userTypeId='01'";

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    public CombinevRTViewpointRelaCondition2(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.ViewpointName_q != "") {
            //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.ViewpointName_q}%'`;
            //}
            //if (this.TopicName_q != "") {
            //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicName} like '% ${this.TopicName_q}%'`;
            //}

            ////判断主题id
            //var strTopicId = $("#hidTopicRelaId").val();
            //if (strTopicId != "") {
            //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
            //}
            //判断Paperid
            var strPaperId = $("#hidPaperRelaId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_PaperId} = '${strPaperId}'`;
            }

            strWhereCond += " and userTypeId='02'";

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vRTViewpointRela() {
        var strListDiv: string = this.mstrListDivRtViewPointRela;
        var strWhereCond = this.CombinevRTViewpointRelaCondition1();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvRTViewpointRelaObjLst1: Array<clsvRTViewpointRelaEN> = [];
        try {
            const responseRecCount = await vRTViewpointRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTViewpointRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTViewpointRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTViewpointRelaObjLst1 = <Array<clsvRTViewpointRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            this.BindTab_vRTViewpointRela(strListDiv, arrvRTViewpointRelaObjLst1);
            console.log("完成BindGv_vRTViewpointRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vRTViewpointRela对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrRTViewpointRelaObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vRTViewpointRela(divContainer: string, arrvRTViewpointRelaObjLst1: Array<clsvRTViewpointRelaEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "viewpointName",
                    ColHeader: "观点名称",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "viewpointTypeName",
                    ColHeader: "观点类型名",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },

                {
                    FldName: "topicName",
                    ColHeader: "栏目主题",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "",
                //    ColHeader: "详情",
                //    Text: "详情",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},

                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除", TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelViewPointRelaRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvRTViewpointRelaObjLst1, arrDataColumn, "mId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    //删除观点关系数据
    public async btnDelViewPointRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelViewPointRelaRecord(lngKeyId);
            const responseText2 = await this.BindGv_vRTViewpointRela();
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
    public DelViewPointRelaRecord(lngmId: number) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTViewpointRela_DelRecordAsync(lngmId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
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















    ////////////////////////////////////////////////////////////////////////////////////主题论文关系
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public CombinevRTPaperRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.TopicName_q != "") {
            //    strWhereCond += ` And ${clsvRTPaperRelaEN.con_TopicName} like '% ${this.TopicName_q}%'`;
            //}
            //if (this.PaperTitle_q != "") {
            //    strWhereCond += ` And ${clsvRTPaperRelaEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
            //}
         
            //判断主题id
            var strTopicId = $("#hidTopicRelaId").val();
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTPaperRelaEN.con_TopicId} = '${strTopicId}'`;
            }
        

            ////判断角色 
            ////管理员
            //if (objvUserRoleRelation.roleId == "00620001") {

            //    // $("#btnDelRecord").show();

            //}
            //else if (objvUserRoleRelation.roleId == "00620002") {
            //    //教师
            //    // $("#btnDelRecord").show();
            //    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
            //    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            //}
            //else {
            //    //学生； 
            //    // $("#btnDelRecord").show();
            //    strWhereCond += ` And ${clsvRTPaperRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
            //    //学生00620003

            //}

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTPaperRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }



    /* 根据条件获取相应的记录对象的列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vRTPaperRela() {
        var strListDiv: string = this.mstrListDivRtPaperRela;
        var strWhereCond = this.CombinevRTPaperRelaCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN> = [];
        try {
            const responseRecCount = await vRTPaperRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTPaperRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTPaperRelaObjLst = <Array<clsvRTPaperRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            this.BindTab_vRTPaperRela(strListDiv, arrvRTPaperRelaObjLst);
            console.log("完成BindGv_vRTPaperRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vRTPaperRela对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrRTPaperRelaObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vRTPaperRela(divContainer: string, arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },

                {
                    FldName: "topicName",
                    ColHeader: "栏目主题",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                
                //{
                //    FldName: "author",
                //    ColHeader: "作者",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "periodical",
                //    ColHeader: "期刊",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "userName",
                    ColHeader: "用户名",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },

                //{
                //    FldName: "",
                //    ColHeader: "详情",
                //    Text: "详情",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},

                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除", TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnDelPaperRelaRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvRTPaperRelaObjLst, arrDataColumn, "mId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    public async btnDelPaperRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelPaperRelaRecord(lngKeyId);
            const responseText2 = await this.BindGv_vRTPaperRela();
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
    public DelPaperRelaRecord(lngmId: number) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTPaperRela_DelRecordAsync(lngmId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
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





    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjResearchTopicEN">数据传输的目的类对象</param>
   */
    public PutDataToResearchTopicClass(pobjResearchTopicEN: clsResearchTopicEN) {
        pobjResearchTopicEN.topicId = this.topicId;// 主题编号
        pobjResearchTopicEN.topicName = this.topicName;// 栏目主题
        pobjResearchTopicEN.topicContent = this.topicContent;// 主题内容
        pobjResearchTopicEN.topicProposePeople = $("#hidUserId").val();// 主题提出人
        pobjResearchTopicEN.orderNum = this.orderNum;// 序号
        pobjResearchTopicEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjResearchTopicEN.updUser = $("#hidUserId").val();// 修改人
        pobjResearchTopicEN.memo = this.memo;// 备注
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

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_ResearchTopic() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombineResearchTopicCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrResearchTopicObjLst: Array<clsvResearchTopicEN> = [];
        try {
            const responseRecCount = await vResearchTopic_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortResearchTopicBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vResearchTopic_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrResearchTopicObjLst = <Array<clsvResearchTopicEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrResearchTopicObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_ResearchTopic(strListDiv, arrResearchTopicObjLst);
            console.log("完成BindGv_ResearchTopic!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public CombineResearchTopicCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.TopicName_q != "") {
            //    strWhereCond += ` And ${clsResearchTopicEN.con_TopicName} like '% ${this.TopicName_q}%'`;
            //}
            //if (this.TopicProposePeople_q != "") {
            //    strWhereCond += ` And ${clsvResearchTopicEN.con_UserName} like '% ${this.TopicProposePeople_q}%'`;
            //}





        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineResearchTopicCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }



    /* 修改
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
  */
    public btnUpdateRecord_Click() {
        //this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        //if (strKeyId == "") {
        //    alert("请选择需要修改的记录！");
        //    return;
        //}
        //判断主题id
        var strTopicId = $("#hidTopicRelaId").val();
        if (strTopicId == "") {
            alert("请选择需要修改的主题！");
            return;
        }
        this.UpdateRecord(strTopicId);
    }

    /* 根据关键字获取相应的记录的对象
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
  */
    public UpdateRecord(strTopicId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strTopicId;
        var strUserId = $("#hidUserId").val();
        return new Promise((resolve, reject) => {
            try {
                const responseText = ResearchTopic_GetObjByTopicIdAsync(strTopicId).then((jsonData) => {
                    var objResearchTopicEN: clsResearchTopicEN = <clsResearchTopicEN>jsonData;
                    // //通过判断数据用户是否是当前登录用户；
                    if (objResearchTopicEN.updUser == strUserId) {
                        ShowDialog('Update');
                        this.GetDataFromResearchTopicClass(objResearchTopicEN);
                        console.log("完成UpdateRecord!");
                        resolve(jsonData);
                    }
                    else {
                        alert("当前数据不是您所添加，不能修改！");
                        return;
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
                            //树形数据源；
                            this.GetTopicData();
                            //this.BindGv_ResearchTopic();
                        }
                    });
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            HideDialog();
                            //树形数据源；
                            this.GetTopicData();
                            //this.BindGv_ResearchTopic();
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }
    /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
 */
    public async btnQuery_Click(strListDiv: string) {

        this.GetTopicData();
        //var strWhereCond = this.CombineResearchTopicCondition();
        //try {
        //    const responseRecCount = await ResearchTopic_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //        this.RecCount = jsonData;
        //    });
        //    var objPagerPara: stuPagerPara = {
        //        pageIndex: 1,
        //        pageSize: this.pageSize,
        //        whereCond: strWhereCond,
        //        orderBy: this.hidSortResearchTopicBy
        //    };
        //    const responseObjLst = await ResearchTopic_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = <Array<clsResearchTopicEN>>jsonData;
        //        this.BindTab_ResearchTopic(this.mstrListDiv, arrResearchTopicObjLst);
        //    });
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //    alert(strMsg);
        //}
    }


    /* 删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
  */
    public async btnDelInRecord_Click(strKeyId: string) {
        try {
            //var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            //if (arrKeyIds.length == 0) {
            //    alert("请选择需要删除的记录！");
            //    return "";
            //}
            const responseText = await this.DelRecordEx(strKeyId);
            //树形数据源；
            this.GetTopicData();
            //const responseText2 = await this.BindGv_ResearchTopic();
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
    public DelRecordEx(strTopicId: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ResearchTopicEx_DelRecordAsyncEx(strTopicId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        //显示信息框
                        alert(strInfo);
                        //删除成功后清空主键隐藏id
                        $('#hidTopicRelaId').val("");
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

    /* 显示ResearchTopic对象的所有属性值
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    <param name = "divContainer">显示容器</param>
    <param name = "arrResearchTopicObjLst">需要绑定的对象列表</param>
  */
    public BindTab_ResearchTopic(divContainer: string, arrResearchTopicObjLst: Array<clsvResearchTopicEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "topicName",
                    ColHeader: "栏目主题",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "topicContent",
                    ColHeader: "主题内容",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "topicProposePeople",
                    ColHeader: "主题提出人",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "orderNum",
                    ColHeader: "序号",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "详情",
                    Text: "详情", TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "修改",
                //    Text: "修改",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrResearchTopicObjLst, arrDataColumn, "topicId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    public btnDetailInTab_Click(strKeyId: string) {

        if (strKeyId == "") {
            alert("请选择需要查看的记录！");
            return;
        }
        this.ResearchTopicDetailRecord(strKeyId);
    }
    /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
    public ResearchTopicDetailRecord(strTopicId: string) {

        this.KeyId = strTopicId;
        var strUserId = $("#hidUserId").val();
        return new Promise((resolve, reject) => {
            try {
                const responseText = ResearchTopic_GetObjByTopicIdAsync(strTopicId).then((jsonData) => {
                    var objResearchTopicEN: clsResearchTopicEN = <clsResearchTopicEN>jsonData;
                    // //显示当前数据；
                    $("#txtTopicNameDetail").html(objResearchTopicEN.topicName);
                    $("#txtTopicContentDetail").html(objResearchTopicEN.topicContent);
                    $("#txtMemoDetail").html(objResearchTopicEN.memo);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `当前无数据获取失败,${e}.`;
                alert(strMsg);
            }
        });
    }



    /* 添加新记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
  */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";

        try {
            const responseText = ResearchTopic_GetMaxStrIdAsync().then((jsonData) => {
                var returnString: string = jsonData.toString();
                if (returnString == "") {
                    var strInfo: string = `获取表Paper的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtTopicId').val(returnString);
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }

        var objResearchTopicEN: clsResearchTopicEN = new clsResearchTopicEN();
        this.PutDataToResearchTopicClass(objResearchTopicEN);
        try {
            //const responseText = await ResearchTopic_IsExistAsync(objResearchTopicEN.topicId);
            //var bolIsExist: boolean = responseText;
            //if (bolIsExist == true) {
            //    var strMsg: string = `添加记录时，关键字：${objResearchTopicEN.topicId}已经存在！`;
            //    alert(strMsg);
            //    return responseText;//一定要有一个返回值，否则会出错！
            //}
            const responseText2 = await ResearchTopic_AddNewRecordAsync(objResearchTopicEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
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


    //////////////////////////////////////观点部分

    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vViewpoint() {
        var strListDiv: string = this.mstrListDivViewpoint;
        var strWhereCond = this.CombinevViewpointCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        try {
            const responseRecCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
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
        //if (arrvViewpointObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vViewpoint(strListDiv, arrvViewpointObjLst);
            console.log("完成BindGv_vViewpoint!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public CombinevViewpointCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strTopicId = $('#hidTopicRelaId').val();
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = $("#hidUserId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.ViewpointName_q != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${this.ViewpointName_q}%'`;
            //}
            //if (this.ViewpointTypeId_q != "" && this.ViewpointTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_ViewpointTypeId} = '${this.ViewpointTypeId_q}'`;
            //}
            //if (this.Reason_q != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_Reason} like '% ${this.Reason_q}%'`;
            //}



            //排除获取已存在的关系数据
            strWhereCond += ` And viewpointId not in (select viewpointId from RTViewpointRela where topicId = '${strTopicId}')`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 显示vViewpoint对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrViewpointObjLst">需要绑定的对象列表</param>
 */
    public BindTab_vViewpoint(divContainer: string, arrvViewpointObjLst: Array<clsvViewpointEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "viewpointName",
                    ColHeader: "观点名称",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "viewpointContent",
                    ColHeader: "观点内容",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "viewpointTypeName",
                    ColHeader: "观点类型名",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "reason",
                //    ColHeader: "理由",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "source",
                //    ColHeader: "来源",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "vpProposePeople",
                //    ColHeader: "观点提出人",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },

                //{
                //    FldName: "",
                //    ColHeader: "详情",
                //    Text: "详情",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定", TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvViewpointObjLst, arrDataColumn, "viewpointId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }





    //添加观点 展示观点列表数据
    public async btnAddRela_Click() {
        const responseObjList = await this.BindGv_vViewpoint();
    }
    //确定选择的观点 并添加到关系表中
    public btnOkInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidViewpointId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSaveViewpointRela();
    }
    /* 添加新记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async AddNewRecordSaveViewpointRela() {
        var strTopicId = $('#hidTopicRelaId').val();
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = $("#hidUserId").val();
        var objRTViewpointRelaEN: clsRTViewpointRelaEN = new clsRTViewpointRelaEN();
        this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);

        try {
            //同一用户 同一主题 同一观点 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId + "'";
            const responseText = await RTViewpointRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个观点！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await RTViewpointRela_AddNewRecordAsync(objRTViewpointRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加成功!`;
                $('#lblResult40').val(strInfo);

                HideDialogTwo();
                //显示信息框
                alert(strInfo);
                //绑定关系列表；
                this.BindGv_vRTViewpointRela();
                //主题Id
                // window.location.href = "../GraduateEdu/ResearchTopicAdd?TopicRelaId" + strTopicId;
            }
            else {
                var strInfo: string = `添加不成功!`;
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
    /* 函数功能:把界面上的属性数据传到类对象中
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
   <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
 */
    public PutDataToRTViewpointRelaClass(pobjRTViewpointRelaEN: clsRTViewpointRelaEN) {

        var strTopicId = $("#hidTopicRelaId").val();
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = $("#hidUserId").val();
        pobjRTViewpointRelaEN.topicId = strTopicId;// 主题编号
        pobjRTViewpointRelaEN.viewpointId = strViewpointId;// 观点Id
        pobjRTViewpointRelaEN.proposePeople = strUserId;// 提出人
        pobjRTViewpointRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjRTViewpointRelaEN.updUser = strUserId;// 修改用户Id// 修改用户Id
        //pobjRTViewpointRelaEN.memo = this.memo;// 备注
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
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_vViewpoint();
    }






    //////////////////////////////////////////////////////论文部分

    //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "1=1") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlUserId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = vPaperEx_GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrUserObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperEN.con_UpdUser, clsvPaperEN.con_UserName, "编辑用户");
    //                console.log("完成BindDdl_UserId!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}
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
                    clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public CombinevPaperCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strPaperTypeId = $("#hidPaperTypeId").val();
        var strTopicId: string = $("#hidTopicRelaId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperTitle_q != "") {
                strWhereCond += ` And ${clsvPaperEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
            }

            if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
            }
            //用户
            if (this.ReadUser_q != "" && this.ReadUser_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_UpdUser} = '${this.ReadUser_q}'`;
            }

            //只查询提交的论文数据
            strWhereCond += ` And ${clsvPaperEN.con_IsSubmit} = 'true'`;
            //排除获取已存在的关系数据
            strWhereCond += ` And paperId not in (select paperId from RTPaperRela where topicId = '${strTopicId}')`;

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vPaper() {
        var strListDiv: string = this.mstrListDivPaper;
        var strWhereCond = this.CombinevPaperCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperObjLst: Array<clsvPaperEN> = [];
        try {
            const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperObjLst = <Array<clsvPaperEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvPaperObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
            console.log("完成BindGv_vPaper!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vPaper对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrPaperObjLst">需要绑定的对象列表</param>
 */
    public BindTab_vPaper(divContainer: string, arrvPaperObjLst: Array<clsvPaperEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "literatureSources",
                    ColHeader: "文献来源",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "提交日期",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "提交用户",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "pcount",
                    ColHeader: "读写数",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "attachmentCount",
                    ColHeader: "附件数",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定", TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnPaperRecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },

            ];
        clsCommonFunc4Web.BindTabV2(o, arrvPaperObjLst, arrDataColumn, "paperId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    //添加论文关系
    public async btnAddPaperRela_Click() {

        const responseObjList = await this.BindGv_vPaper();
    }



    //查询论列表
    public async btnPaperQuery_Click() {
        const responseObjList = await this.BindGv_vPaper();
    }
    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSavePaperRela();
    }
    /* 添加新记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSavePaperRela() {
        var strTopicId = $('#hidTopicRelaId').val();
        var strPaperId = $("#hidPaperId").val();
        var strUserId = $("#hidUserId").val();
        var objRTPaperRelaEN: clsRTPaperRelaEN = new clsRTPaperRelaEN();
        this.PutDataToRTPaperRelaClass(objRTPaperRelaEN);

        try {
            // 同一主题 同一论文 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And paperId = '" + strPaperId + "'";
            const responseText = await RTPaperRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个论文！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await RTPaperRela_AddNewRecordAsync(objRTPaperRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加成功!`;
                $('#lblResult40').val(strInfo);

                HideDialogThree();
                //显示信息框
                alert(strInfo);
                this.BindGv_vRTPaperRela();
                ////主题Id
                //window.location.href = "../GraduateEdu/WApiRTPaperRela_QUDI_TS?TopicRelaId='01'";
            }
            else {
                var strInfo: string = `添加不成功!`;
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
    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjRTPaperRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToRTPaperRelaClass(pobjRTPaperRelaEN: clsRTPaperRelaEN) {
        var strTopicId = $("#hidTopicRelaId").val();
        var strPaperId = $("#hidPaperId").val();
        var strUserId = $("#hidUserId").val();
        pobjRTPaperRelaEN.topicId = strTopicId;// 主题编号
        pobjRTPaperRelaEN.paperId = strPaperId;// 论文Id
        pobjRTPaperRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjRTPaperRelaEN.updUser = strUserId;// 修改人
        pobjRTPaperRelaEN.memo = this.memo;// 备注
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
    /* 函数功能:在数据 列表中跳转到某一页 论文列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
<param name = "intPageIndex">页序号</param>
*/
    public IndexPageTwo(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_vPaper();
    }
    /*
    * 论文标题
   */
    public get PaperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }
    ///////////////////////论文列表条件
    public get ReadUser_q(): string {
        return $("#ddlUserId_q").val();
    }

    /*
    * 文献类型Id
   */
    public get LiteratureTypeId_q(): string {
        return $("#ddlLiteratureTypeId_q").val();
    }



    ///////////////////////////////////////////////////用户数据部分

    //添加用户关系
    public async btnAddUserRela_Click() {

        const responseObjList = await this.BindGv_QxUsers();
    }

    //查询用户数据
    public async btnUserQuery_Click() {
        const responseObjList = await this.BindGv_QxUsers();
    }
    //确定选择的用户 并添加到关系表中
    public btnUserRecordInTab_Click(strkeyId: string) {

        //需要提示选择角色
        if (this.TopicUserRole_q != "" && this.TopicUserRole_q != "0") {
            //存放Id
            $("#hidUserIdKey").val(strkeyId)
            //执行添加关系方法
            this.AddNewRecordSaveUserRela();
        }
        else {
            var strInfo: string = `请选择用户角色!`;

            //显示信息框
            alert(strInfo);
            return;
        }



    }

    /* 添加新记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSaveUserRela() {
        var strTopicId = $('#hidTopicRelaId').val();
        var strPaperId = $("#hidPaperId").val();
        var strUserId = $("#hidUserIdKey").val();
        var objRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
        this.PutDataToRTUserRelaClass(objRTUserRelaEN);

        try {
            // 同一主题 同一用户 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
            const responseText = await RTUserRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个用户！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await RTUserRela_AddNewRecordAsync(objRTUserRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加成功!`;
                $('#lblResult40').val(strInfo);
                //隐藏用户框
                HideDialogFour();
                //显示信息框
                alert(strInfo);
                this.BindGv_vRTUserRela();
                ////主题Id
                //window.location.href = "../GraduateEdu/WApiRTUserRela_QUDI_TS?TopicRelaId='01'";
            }
            else {
                var strInfo: string = `添加不成功!`;
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
    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjRTUserRelaEN">数据传输的目的类对象</param>
   */
    public PutDataToRTUserRelaClass(pobjRTUserRelaEN: clsRTUserRelaEN) {
        var strTopicId = $("#hidTopicRelaId").val();
        var strPaperId = $("#hidPaperId").val();
        var strUserIdKey = $("#hidUserIdKey").val();
        var strUserId = $("#hidUserId").val();
        pobjRTUserRelaEN.topicId = strTopicId;// 主题编号
        pobjRTUserRelaEN.userId = strUserIdKey;// 用户ID
        pobjRTUserRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjRTUserRelaEN.topicUserRoleId = this.TopicUserRole_q;
        pobjRTUserRelaEN.updUser = strUserId;// 修改人
        pobjRTUserRelaEN.memo = this.memo;// 备注
    }


    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public CombineQxUsersCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strTopicId: string = $("#hidTopicRelaId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.UserId_q != "") {
                strWhereCond += ` And ${clsvUsersEN.con_UserId} like '% ${this.UserId_q}%'`;
            }
            if (this.UserName_q != "") {
                strWhereCond += ` And ${clsvUsersEN.con_UserName} like '% ${this.UserName_q}%'`;
            }

            //排除获取已存在的关系数据
            strWhereCond += ` And userId not in (select userId from RTUserRela where topicId = '${strTopicId}')`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineQxUsersCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_QxUsers() {
        var strListDiv: string = this.mstrListDivUser;
        var strWhereCond = this.CombineQxUsersCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrQxUsersObjLst: Array<clsvUsersEN> = [];
        try {
            const responseRecCount = await vUsers_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortQxUsersBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vUsers_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrQxUsersObjLst = <Array<clsvUsersEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        if (arrQxUsersObjLst.length == 0) {
            var strMsg: string = `根据条件获取的对象列表数为空！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_QxUsers(strListDiv, arrQxUsersObjLst);
            console.log("完成BindGv_QxUsers!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示QxUsers对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrQxUsersObjLst">需要绑定的对象列表</param>
   */
    public BindTab_QxUsers(divContainer: string, arrQxUsersObjLst: Array<clsvUsersEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userId",
                    ColHeader: "用户ID",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "用户名",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cardNo",
                    ColHeader: "卡号",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },

                {
                    FldName: "email",
                    ColHeader: "电子邮箱",
                    Text: "", TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "endYearMonth",
                //    ColHeader: "结束年月",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "isArchive",
                //    ColHeader: "isArchive",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "updDate",
                //    ColHeader: "修改日期",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "updUser",
                //    ColHeader: "修改人",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定", TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUserRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },

            ];
        clsCommonFunc4Web.BindTabV2(o, arrQxUsersObjLst, arrDataColumn, "userId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortQxUsersBy(value: string) {
        $("#hidSortQxUsersBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortQxUsersBy(): string {
        return $("#hidSortQxUsersBy").val();
    }

    /* 函数功能:在数据 列表中跳转到某一页 用户列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
<param name = "intPageIndex">页序号</param>
*/
    public IndexPageThree(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_QxUsers();
    }



    //主题
    /*
   *主题
  */
    public get topicName(): string {
        return $("#dllTopicName").val();
    }
    ////////////////////////用户列表条件
    /*
    * 用户ID
   */
    public get UserId_q(): string {
        return $("#txtUserId_q").val();
    }
    /*
   * 用户名
  */
    public get UserName_q(): string {
        return $("#txtUserName_q").val();
    }

    //主题用户角色
    public get TopicUserRole_q(): string {
        return $("#ddlTopicUserRole_q").val();
    }
    /*
    * 主题用户角色
   */
    public set TopicUserRole_q(value: string) {
        $("#ddlTopicUserRole_q").val(value);
    }

    /*
* 设置排序字段-相当使用ViewState功能  主题用户关系
*/
    public set hidSortvRTUserRelaBy(value: string) {
        $("#hidSortvRTUserRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvRTUserRelaBy(): string {
        return $("#hidSortvRTUserRelaBy").val();
    }


    /*
   * 设置排序字段-相当使用ViewState功能 主题观点关系
  */
    public set hidSortvRTViewpointRelaBy(value: string) {
        $("#hidSortvRTViewpointRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvRTViewpointRelaBy(): string {
        return $("#hidSortvRTViewpointRelaBy").val();
    }


    /*
* 设置排序字段-相当使用ViewState功能  主题论文关系
*/
    public set hidSortvRTPaperRelaBy(value: string) {
        $("#hidSortvRTPaperRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvRTPaperRelaBy(): string {
        return $("#hidSortvRTPaperRelaBy").val();
    }

}