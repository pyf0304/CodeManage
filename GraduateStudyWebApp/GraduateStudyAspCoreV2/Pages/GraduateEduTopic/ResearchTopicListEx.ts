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
//
//import * as QQ from "q";
import { Public_Concept } from "../GraduateEduPublicPage/Public_Concept.js";
import { Public_SysSkill } from "../GraduateEduPublicPage/Public_SysSkill.js";
import { Public_SysSocialRelations } from "../GraduateEduPublicPage/Public_SysSocialRelations.js";
import { Public_TopicObjective } from "../GraduateEduPublicPage/Public_TopicObjective.js";
import { Public_Viewpoint } from "../GraduateEduPublicPage/Public_Viewpoint.js";
import { Pub_PaperList } from "../GraduateEduPublicPage/Pub_PaperList.js";
import { Pub_QxUsersList } from "../GraduateEduPublicPage/Pub_QxUsersList.js";
import { Pub_RTPaperRelaList } from "../GraduateEduPublicPage/Pub_RTPaperRelaList.js";
import { Pub_RTUserRelaList } from "../GraduateEduPublicPage/Pub_RTUserRelaList.js";
import { Pub_RTViewpointRelaList } from "../GraduateEduPublicPage/Pub_RTViewpointRelaList.js";
import { Pub_ViewpointList } from "../GraduateEduPublicPage/Pub_ViewpointList.js";
import { ResearchTopic_Edit } from "../PagesBase/GraduateEduTopic/ResearchTopic_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsViewpointScoreEN } from "../TS/L0_Entity/GraduateEdu/clsViewpointScoreEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsSysCommentEN } from "../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js";
import { clsvSysCommentEN } from "../TS/L0_Entity/GraduateEduTools/clsvSysCommentEN.js";
import { clsConceptAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js";
import { clsConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js";
import { clsgs_ReflectLogEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js";
import { clsgs_TeacherTaskEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_TeacherTaskEN.js";
import { clsObjectiveAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";
import { clsRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js";
import { clsRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js";
import { clsSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js";
import { clsSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js";
import { clsTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js";
import { clsvgs_ResearchPlanEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanEN.js";
import { clsViewpointAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js";
import { clsViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js";
import { clsvRTConceptRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js";
import { clsvRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { clsvRTSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTSysSkillEN.js";
import { clsvRTSysSocialRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTSysSocialRelaEN.js";
import { clsvRTTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTTopicObjectiveRelaEN.js";
import { clsvRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js";
import { clsvRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsTopicUserRoleEN } from "../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js";
import { clsvUsersEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { clsvQxUserRoleRelationEN } from "../TS/L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js";
import { ViewpointScore_AddNewRecordAsync } from "../TS/L3_ForWApi/GraduateEdu/clsViewpointScoreWApi.js";
import { vSysComment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js";
import { ConceptAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptAttachmentWApi.js";
import { Concept_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js";
import { gs_ReflectLog_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ReflectLogWApi.js";
import { gs_TeacherTask_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TeacherTaskWApi.js";
import { ObjectiveAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js";
import { ResearchTopic_AddNewRecordAsync, ResearchTopic_GetMaxStrIdAsync, ResearchTopic_GetObjByTopicIdAsync, ResearchTopic_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { RTPaperRela_AddNewRecordAsync, RTPaperRela_DelRecordAsync, RTPaperRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js";
import { RTUserRela_AddNewRecordAsync, RTUserRela_DelRecordAsync, RTUserRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js";
import { RTViewpointRela_AddNewRecordAsync, RTViewpointRela_DelRecordAsync, RTViewpointRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js";
import { SysSkill_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js";
import { SysSocialRelations_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { TopicObjective_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { vgs_ResearchPlan_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js";
import { ViewpointAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js";
import { Viewpoint_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js";
import { vRTConceptRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTConceptRelaWApi.js";
import { vRTPaperRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js";
import { vRTSysSkill_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSkillWApi.js";
import { vRTSysSocialRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js";
import { vRTTopicObjectiveRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTTopicObjectiveRelaWApi.js";
import { vRTUserRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js";
import { vRTViewpointRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js";
import { SysVote_AddNewRecordAsync, SysVote_GetObjLstAsync, SysVote_GetRecCountByCondAsync, SysVote_IsExistRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { TopicUserRole_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { vQxUserRoleRelation_GetObjLstAsync } from "../TS/L3_ForWApi/UsersRight/clsvQxUserRoleRelationWApi.js";
import { SysCommentEx_AddNewRecordExAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js";
import { ResearchTopicEx_DelRecordAsyncEx } from "../TS/L3_ForWApiEx/GraduateEduTopic/clsResearchTopicExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { BindDdl_ObjLst } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogTwo(): void;
declare function HideDialogThree(): void;
declare function HideDialogFour(): void;
declare function LoadTreeShow(): void;
declare function HideDialog3(): void;
declare function SetFontSize(): void;

declare function TopicListMenuIsHide(): void;

//显示评论框
declare function ShowDialog3(): void;
declare var strAddressAndPort;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ResearchTopicListEx extends ResearchTopic_Edit {
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
            if (clsPublocalStorage.userId != "") {
                //获取用户角色来判断显示不同的列表数据；
                $("#hidUserId").val(clsPublocalStorage.userId);
                $("#hidRoleId").val(clsPublocalStorage.roleId);

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
                //树列表
                const gvResult = await this.GetTopicData();
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
                    BindDdl_ObjLst(ddlTopicUserRole_q, arrTopicUserRoleObjLst, clsTopicUserRoleEN.con_TopicUserRoleId, clsTopicUserRoleEN.con_TopicUserRoleName, "");
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
    //得到3个关系列表数据；
    public async GetAllFunctionMethod() {
        //组合关系；
        const gvResult = await this.BindGv_AllTopicRela();
        TopicListMenuIsHide();
        //SetFontSize();
        $("#divLoading").hide();
    }

    //动态主题数据结构；
    public async GetTopicData() {

        var strWhereCond = await this.CombineResearchTopicCondition();
        //声明主题变量
        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];

        const responseObjLst = await ResearchTopic_GetObjLstAsync(strWhereCond).then((jsonData) => {
            arrResearchTopicObjLst = <Array<clsResearchTopicEN>>jsonData;
        });

        var strhtml = "";
        $("#TreeBind li").remove();
        if (arrResearchTopicObjLst.length > 0) {
            //循环数据
            for (var i = 0; i < arrResearchTopicObjLst.length; i++) {
                //默认存放第一条数据显示；
                if (i == 0) {

                    //判断存放的id控件是否为空；
                    if (clsPrivateSessionStorage.topicId == "") {
                        //存放Id
                        clsPrivateSessionStorage.topicId = arrResearchTopicObjLst[i].topicId;
                        clsPrivateSessionStorage.topicName = arrResearchTopicObjLst[i].topicName;
                        strhtml += '<li id="' + arrResearchTopicObjLst[i].topicId + '" onclick=btnSelectResearchTopic("' + arrResearchTopicObjLst[i].topicId + '","' + arrResearchTopicObjLst[i].topicName + '")><a href="#" class="selected">' + arrResearchTopicObjLst[i].topicName + '</a></li>';
                    } else {
                        strhtml += '<li id="' + arrResearchTopicObjLst[i].topicId + '" onclick=btnSelectResearchTopic("' + arrResearchTopicObjLst[i].topicId + '","' + arrResearchTopicObjLst[i].topicName + '")><a href="#">' + arrResearchTopicObjLst[i].topicName + '</a></li>';
                    }
                }
                else {
                    strhtml += '<li id="' + arrResearchTopicObjLst[i].topicId + '" onclick=btnSelectResearchTopic("' + arrResearchTopicObjLst[i].topicId + '","' + arrResearchTopicObjLst[i].topicName + '")><a href="#">' + arrResearchTopicObjLst[i].topicName + '</a></li>';
                }
            }
            $("#TreeBind").append(strhtml);
            //默认展开树
            LoadTreeShow();
            //调用数据展示；
            this.GetAllFunctionMethod();
        }
    }

    ////////////////////////////////////////各个观点条件////////////////////////////////////////////////////////
    //个人观点条件
    public CombinevRTViewpointRelaCondition1(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            strWhereCond += " and userTypeId='01'";
            if (this.Keyword_q != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.Keyword_q}%'`;
                strWhereCond += ` or ${clsvRTViewpointRelaEN.con_ViewpointContent} like '% ${this.Keyword_q}%'`;
                strWhereCond += '[exclude] or [/exclude]';
            }
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            strWhereCond += " and userTypeId='01'";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //专家观点条件
    public CombinevRTViewpointRelaCondition2(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            strWhereCond += " and userTypeId='02'";
            if (this.Keyword_q != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.Keyword_q}%'`;
                strWhereCond += ` or ${clsvRTViewpointRelaEN.con_ViewpointContent} like '% ${this.Keyword_q}%'`;

                strWhereCond += '[exclude] or [/exclude]';
            }
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            strWhereCond += " and userTypeId='02'";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //相关概念条件
    public async CombinevRTConceptRelaCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTConceptRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            if (this.Keyword_q != "") {
                strWhereCond += ` And ${clsvRTConceptRelaEN.con_ConceptName} like '% ${this.Keyword_q}%'`;
                strWhereCond += ` or ${clsvRTConceptRelaEN.con_ConceptContent} like '% ${this.Keyword_q}%'`;
                strWhereCond += '[exclude] or [/exclude]';
            }
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTConceptRelaEN.con_TopicId} = '${strTopicId}'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //客观事实条件
    public CombinevRTTopicObjectiveRelaCondition1(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            strWhereCond += ` and objectiveType='01'`;
            if (this.Keyword_q != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_ObjectiveName} like '% ${this.Keyword_q}%'`;
                strWhereCond += ` or ${clsvRTTopicObjectiveRelaEN.con_ObjectiveContent} like '% ${this.Keyword_q}%'`;
                strWhereCond += '[exclude] or [/exclude]';
            }
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            strWhereCond += ` and objectiveType='01'`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //客观数据条件
    public CombinevRTTopicObjectiveRelaCondition2(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            strWhereCond += ` and objectiveType='02'`;
            if (this.Keyword_q != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_ObjectiveName} like '% ${this.Keyword_q}%'`;
                strWhereCond += ` or ${clsvRTTopicObjectiveRelaEN.con_ObjectiveContent} like '% ${this.Keyword_q}%'`;
                strWhereCond += '[exclude] or [/exclude]';
            }
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            strWhereCond += ` and objectiveType='02'`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //技能条件
    public CombinevRTSysSkillCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTSysSkillEN.con_TopicId} = '${strTopicId}'`;
            }
            if (this.Keyword_q != "") {
                strWhereCond += ` And ${clsvRTSysSkillEN.con_SkillName} like '% ${this.Keyword_q}%'`;
                strWhereCond += ` or ${clsvRTSysSkillEN.con_Process} like '% ${this.Keyword_q}%'`;
                strWhereCond += '[exclude] or [/exclude]';
            }
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTSysSkillEN.con_TopicId} = '${strTopicId}'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //社会关系条件
    public CombinevRTSysSocialRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTSysSocialRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            if (this.Keyword_q != "") {
                strWhereCond += ` And ${clsvRTSysSocialRelaEN.con_FullName} like '% ${this.Keyword_q}%'`;
                strWhereCond += ` or ${clsvRTSysSocialRelaEN.con_DetailedDescription} like '% ${this.Keyword_q}%'`;

                strWhereCond += '[exclude] or [/exclude]';
            }
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTSysSocialRelaEN.con_TopicId} = '${strTopicId}'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    //是否教师打分条件
    public CombineIsTeaComment(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = "";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if ($("#ddlIsTeaComment_q").val() != "0") {
                if ($("#ddlIsTeaComment_q").val() == "01") {
                    strWhereCond = " and teaScore>0";
                }
                else {
                    strWhereCond = " and teaScore=0";
                }
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    //反思条件
    public async Combinegs_ReflectLogCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsgs_ReflectLogEN.con_TopicId} = '${strTopicId}'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_ResearchPlanCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    //动态获取所有相关关系表数据
    public async BindGv_AllTopicRela() {


        var strUserId = clsPublocalStorage.userId;
        //一、条件串
        //1用户关系
        var strWhereUserRela = await this.CombinevRTUserRelaCondition();
        //2论文关系
        var strWherePaperRela1 = await this.CombinevRTPaperRelaCondition() + " and paperTypeId='01'";
        var strWherePaperRela2 = await this.CombinevRTPaperRelaCondition() + " and paperTypeId='02'";
        //3个人观点
        var strWhereViewpointRela1 = await this.CombinevRTViewpointRelaCondition1() + this.CombineIsTeaComment();
        //专家观点
        var strWhereViewpointRela2 = await this.CombinevRTViewpointRelaCondition2() + this.CombineIsTeaComment();
        //附件
        var strWhereCondAttachment = "1=1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //5点赞 查询当前用户 点赞数据；
        var strWhereCondLike = `1=1 And ${clsSysVoteEN.con_UpdUser} = '${strUserId}'`;//新0605
        //6相关概念
        var strWhereConcept = await this.CombinevRTConceptRelaCondition() + this.CombineIsTeaComment();
        //7客观事实
        var strWhereFacts = await this.CombinevRTTopicObjectiveRelaCondition1() + this.CombineIsTeaComment();
        //8客观数据
        var strWhereBasis = await this.CombinevRTTopicObjectiveRelaCondition2() + this.CombineIsTeaComment();
        //技能
        var strWhereSysskill = await this.CombinevRTSysSkillCondition() + this.CombineIsTeaComment();
        //9、社会关系
        var strWhereSysSocialRelations = this.CombinevRTSysSocialRelaCondition() + this.CombineIsTeaComment();
        //用户分数
        var strWhereCond10 = " parentId='root' and  commentTypeId='08' order by Score Desc";

        //11研究计划
        var strWhereResearchPlan = "topicId='" + clsPrivateSessionStorage.topicId + "'";

        //12研究计划之 教师任务布置
        var strWhereTeacherTask = "topicId='" + clsPrivateSessionStorage.topicId + "'";
        //反思
        var strWheregs_ReflectLog = await this.Combinegs_ReflectLogCondition();


        //二、数据源声明
        var arrvRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
        var arrvRTPaperRelaObjLst1: Array<clsvRTPaperRelaEN> = [];
        var arrvRTPaperRelaObjLst2: Array<clsvRTPaperRelaEN> = [];
        var arrvRTViewpointRelaObjLst1: Array<clsvRTViewpointRelaEN> = [];
        var arrvRTViewpointRelaObjLst2: Array<clsvRTViewpointRelaEN> = [];
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
        var arrSysVoteObjLst: Array<clsSysVoteEN> = [];//新0605
        //获取相关概念
        var arrvRTConceptObjLst: Array<clsvRTConceptRelaEN> = [];
        //客观事实
        var arrvRTTopicObjectiveRelaObjLst1: Array<clsvRTTopicObjectiveRelaEN> = [];
        //客观数据
        var arrvRTTopicObjectiveRelaObjLst2: Array<clsvRTTopicObjectiveRelaEN> = [];
        //技能
        var arrvRTSysSkillObjLst: Array<clsvRTSysSkillEN> = [];
        //社会关系
        var arrvRTSysSocialRelaObjLst: Array<clsvRTSysSocialRelaEN> = [];
        //用户分数
        var objSysComment1: clsvSysCommentEN;
        var arrvSysCommentObjLst: Array<clsvSysCommentEN> = [];
        //研究计划
        var arrvResearchPlanObjLst: Array<clsvgs_ResearchPlanEN> = [];
        //教师任务布置
        var arrgs_TeacherTaskObjLst: Array<clsgs_TeacherTaskEN> = [];
        var arrgs_ReflectLogObjList: Array<clsgs_ReflectLogEN> = [];//反思
        //三、方法获取调用
        try {
            const responseObjLst1 = await vRTUserRela_GetObjLstAsync(strWhereUserRela).then((jsonData) => {
                arrvRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
            });
            const responseObjLst2 = await vRTPaperRela_GetObjLstAsync(strWherePaperRela1).then((jsonData) => {
                arrvRTPaperRelaObjLst1 = <Array<clsvRTPaperRelaEN>>jsonData;
            });
            const responseObjLst12 = await vRTPaperRela_GetObjLstAsync(strWherePaperRela2).then((jsonData) => {
                arrvRTPaperRelaObjLst2 = <Array<clsvRTPaperRelaEN>>jsonData;
            });
            const responseObjLst3 = await vRTViewpointRela_GetObjLstAsync(strWhereViewpointRela1).then((jsonData) => {
                arrvRTViewpointRelaObjLst1 = <Array<clsvRTViewpointRelaEN>>jsonData;
            });
            const responseObjLst4 = await vRTViewpointRela_GetObjLstAsync(strWhereViewpointRela2).then((jsonData) => {
                arrvRTViewpointRelaObjLst2 = <Array<clsvRTViewpointRelaEN>>jsonData;
            });
            const responseRecCount5 = await ViewpointAttachment_GetObjLstAsync(strWhereCondAttachment).then((jsonData) => {
                arrViewpointAttachmentObjLst2 = <Array<clsViewpointAttachmentEN>>jsonData;
            });
            const responseRecCount6 = await SysVote_GetObjLstAsync(strWhereCondLike).then((jsonData) => {
                arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            });
            //获取相关概念数据
            const responseRecCount7 = await vRTConceptRela_GetObjLstAsync(strWhereConcept).then((jsonData) => {
                arrvRTConceptObjLst = <Array<clsvRTConceptRelaEN>>jsonData;
            });
            //客观事实
            const responseRecCount8 = await vRTTopicObjectiveRela_GetObjLstAsync(strWhereFacts).then((jsonData) => {
                arrvRTTopicObjectiveRelaObjLst1 = <Array<clsvRTTopicObjectiveRelaEN>>jsonData;
            });
            //客观数据   
            const responseRecCount9 = await vRTTopicObjectiveRela_GetObjLstAsync(strWhereBasis).then((jsonData) => {
                arrvRTTopicObjectiveRelaObjLst2 = <Array<clsvRTTopicObjectiveRelaEN>>jsonData;
            });
            //用户分数  
            const responseRecCount10 = await vSysComment_GetObjLstAsync(strWhereCond10).then((jsonData) => {
                arrvSysCommentObjLst = <Array<clsvSysCommentEN>>jsonData;
            });
            //获取技能
            const responseRecCount12 = await vRTSysSkill_GetObjLstAsync(strWhereSysskill).then((jsonData) => {
                arrvRTSysSkillObjLst = <Array<clsvRTSysSkillEN>>jsonData;
            });
            //社会关系
            const responseRecCount13 = await vRTSysSocialRela_GetObjLstAsync(strWhereSysSocialRelations).then((jsonData) => {
                arrvRTSysSocialRelaObjLst = <Array<clsvRTSysSocialRelaEN>>jsonData;
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
            var arrvUserStuNameObjLst: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
            //研究计划
            const responseRecCount16 = await vgs_ResearchPlan_GetObjLstAsync(strWhereResearchPlan).then((jsonData) => {
                arrvResearchPlanObjLst = <Array<clsvgs_ResearchPlanEN>>jsonData;
            });
            //教师任务布置
            const responseRecCount17 = await gs_TeacherTask_GetObjLstAsync(strWhereTeacherTask).then((jsonData) => {
                arrgs_TeacherTaskObjLst = <Array<clsgs_TeacherTaskEN>>jsonData;
            });
            //反思
            const responseRecCount18 = await gs_ReflectLog_GetObjLstAsync(strWheregs_ReflectLog).then((jsonData) => {
                arrgs_ReflectLogObjList = <Array<clsgs_ReflectLogEN>>jsonData;
            });


            var strhtml: string = '<div style="font-size:20px; color: #009688; font-weight: bold; margin-bottom:10px;" id="TopicTitle">当前主题：' + clsPrivateSessionStorage.topicName + '</div>';
            //用户
            strhtml += '<div class="info" id="infoUser"><div class="title btn-1"><a href="#" title="小组成员">小组成员</a></div><ul class="artlist">';
            var u = 0;//给内容加个序号
            for (var i = 0; i < arrvRTUserRelaObjLst.length; i++) {
                u++;
                //strhtml += u + "." + arrvRTUserRelaObjLst[i].userName + "&nbsp;&nbsp;&nbsp;主题用户角色：(" + arrvRTUserRelaObjLst[i].topicUserRoleName + ")&nbsp;所属主题：" + arrvRTUserRelaObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>";
                strhtml += '<li><span class="rowtit color1">' + u + '.</span><span class="abstract-text">' + arrvRTUserRelaObjLst[i].userName + '</span>&nbsp;&nbsp;&nbsp;<span class="rowtit color1">角色：</span><span class="abstract-text">(' + arrvRTUserRelaObjLst[i].topicUserRoleName + ')</span></li>';

                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';

                var objComment = arrvSysCommentObjLst.find(x => x.tableKey == arrvRTUserRelaObjLst[i].userId);
                if (objComment != null) {

                    strhtml += '&nbsp;&nbsp;教师评分:' + objComment.score;
                } else {
                    strhtml += '&nbsp;&nbsp;暂无教师打分！';
                    if ($("#hidRoleId").val() != "00620003") {
                        strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTUserRelaObjLst[i].userId + '","08","' + arrvRTUserRelaObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                    }
                }
                strhtml += '</li>';
            }
            strhtml += '</ul></div>';

            //研究计划
            //用户
            strhtml += '<div class="info" id="infoResearchPlan">';
            //布置任务
            strhtml += '<div class="title btn-1"><a href="#" title="任务布置">任务布置</a></div><ul class="artlist">';
            var u = 0;//给内容加个序号
            for (var i = 0; i < arrgs_TeacherTaskObjLst.length; i++) {
                u++;
                strhtml += '<li><span class="rowtit color3 btnLeft">' + u + '.[任务说明]：</span><span class="abstract-text">' + arrgs_TeacherTaskObjLst[i].missionStatement + '</span></li>';


                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[任务要求]：</span><span class="abstract-text">' + arrgs_TeacherTaskObjLst[i].missionRequirement + '</span></li>';

                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[发布时间]：' + arrvResearchPlanObjLst[i].updDate + '</span>'

            }
            strhtml += '</ul><br/><hr/>';

            strhtml += '<div class="title btn-1"><a href="#" title="研究计划">研究计划</a></div><ul class="artlist">';
            var u = 0;//给内容加个序号
            for (var i = 0; i < arrvResearchPlanObjLst.length; i++) {

                var strPlanId = arrvResearchPlanObjLst[i].planId;
                u++;
                strhtml += '<li><span class="rowtit color3 btnLeft">' + u + '.[研究状态]：</span><span class="abstract-text">' + arrvResearchPlanObjLst[i].statusName + '</span></li>';

                //判断计划类型
                if (arrvResearchPlanObjLst[i].planTypeId == "01") {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[计划类型]：</span><span class="abstract-text">个人计划</span></li>';
                }
                else {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[计划类型]：</span><span class="abstract-text">小组计划</span></li>';
                }
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[负责人/小组]：</span><span class="abstract-text">' + arrvResearchPlanObjLst[i].responsibleUser + '</span></li>';
                //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst1[i].viewpointTypeName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[计划内容]：</span><span class="abstract-text">' + arrvResearchPlanObjLst[i].planContent + '</span></li>';

                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[开始日期]：' + arrvResearchPlanObjLst[i].startDate + '</span>'
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[结束日期]：</span>' + arrvResearchPlanObjLst[i].endDate;
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[完成日期]：</span>' + arrvResearchPlanObjLst[i].actualFinishingDate;

                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[验收用户]：</span>' + arrvResearchPlanObjLst[i].acceptanceUser;

                if (arrvResearchPlanObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;<span class="rowtit colorRed">[未提交]</span></li>';
                }
            }
            strhtml += '</ul></div>';

            //-------------------反思模块
            strhtml += '<div class="info" id="infogs_ReflectLog">';
            strhtml += '<div class="title btn-1"><a href="#" title="反思">反思</a></div><ul class="artlist">';
            var u = 0;//给内容加个序号
            for (var i = 0; i < arrgs_ReflectLogObjList.length; i++) {
                u++;
                strhtml += '<li><span class="rowtit color3 btnLeft">' + u + '.[名称]：</span><span class="abstract-text">' + arrgs_ReflectLogObjList[i].reflectLogName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[内容]：</span><span class="abstract-text">' + arrgs_ReflectLogObjList[i].reflectLogContent + '</span></li>';

                //获取引用人；编辑人、用户名称
                var arrvUsers: Array<clsvUsersSimEN> = [];
                var UpdUserName;//编辑人
                var CacitionUserName;//引用人
                //获取技能引用人；
                arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrgs_ReflectLogObjList[i].updUser);//技能引用人
                for (var j = 0; j < arrvUsers.length; j++) {
                    UpdUserName = arrvUsers[j].userName;
                    break;
                }


                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑时间]：' + arrgs_ReflectLogObjList[i].updDate + '</span>'
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑用户]：</span>' + UpdUserName;

            }
            strhtml += '</ul></div>';




            //相关引用论文
            strhtml += '<div class="info" id="infoPaper"><div class="title btn-2"><a href="#" title="相关论文">相关论文</a></div><ul class="artlist">';
            var p = 0;//给内容加个序号
            for (var i = 0; i < arrvRTPaperRelaObjLst1.length; i++) {
                p++;
                //strhtml += p + "." + arrvRTPaperRelaObjLst[i].paperTitle + "&nbsp;&nbsp;所属主题：" + arrvRTPaperRelaObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>";
                strhtml += '<li><span class="rowtit color2">' + p + '.</span><span class="abstract-text">' + arrvRTPaperRelaObjLst1[i].paperTitle + '</span>';

                strhtml += "<span class=\"colorRed\" style=\"padding-left:50px;\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvRTPaperRelaObjLst1[i].paperId + "')\">pdf查看</span></li>";
                //<a href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrvRTPaperRelaObjLst[i].paperId + "')\">pdf查看</a>

            }
            strhtml += '</ul></div>';

            //相关自研论文
            strhtml += '<div class="info" id="infoPaper2"><div class="title btn-2"><a href="#" title="自研论文">自研论文</a></div><ul class="artlist">';
            var p = 0;//给内容加个序号
            for (var i = 0; i < arrvRTPaperRelaObjLst2.length; i++) {
                p++;
                //strhtml += p + "." + arrvRTPaperRelaObjLst[i].paperTitle + "&nbsp;&nbsp;所属主题：" + arrvRTPaperRelaObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>";
                strhtml += '<li><a style="cursor:pointer;" onclick=btnNewPaper("' + arrvRTPaperRelaObjLst2[i].paperId + '")><span class="rowtit color2">' + p + '.</span><span class="abstract-text">' + arrvRTPaperRelaObjLst2[i].paperTitle + '</span></a>';
                if (arrvRTPaperRelaObjLst2[i].versionCount > 0 && arrvRTPaperRelaObjLst2[i].versionCount != null) {
                    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('自研论文历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTPaperRelaObjLst2[i].paperId + "&Type=10')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                }
                strhtml += '</li>';

            }
            strhtml += '</ul></div>';


            //换行符
            //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';

            //个人观点
            //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3"><a href="#" title="个人观点">个人观点</a></div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvRTViewpointRelaObjLst1.length; i++) {
            //    //得到viewpointId；
            //    var strViewpointId = arrvRTViewpointRelaObjLst1[i].viewpointId;

            //    v++;
            //    //对内容进行换行替换
            //    var strViewpointContent = arrvRTViewpointRelaObjLst1[i].viewpointContent;
            //    var strReason = arrvRTViewpointRelaObjLst1[i].reason;

            //    strViewpointContent = strViewpointContent.replace(/\r\n/g, strBr);
            //    strViewpointContent = strViewpointContent.replace(/\n/g, strBr);

            //    strReason = strReason.replace(/\r\n/g, strBr);
            //    strReason = strReason.replace(/\n/g, strBr);

            //    strhtml += '<li><span class="rowtit color3 btnLeft">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst1[i].viewpointName + '</span>';
            //    if (arrvRTViewpointRelaObjLst1[i].versionCount > 0 && arrvRTViewpointRelaObjLst1[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('个人观点历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTViewpointRelaObjLst1[i].viewpointId + "&Type=03')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst1[i].viewpointTypeName + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvRTViewpointRelaObjLst1[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';


            //    //查询附件
            //    arrViewpointAttachmentObjLst = arrViewpointAttachmentObjLst2.filter(x => x.viewpointId == strViewpointId);
            //    if (arrViewpointAttachmentObjLst.length > 0) {
            //        for (var y = 0; y < arrViewpointAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrViewpointAttachmentObjLst[y].filePath;
            //            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '"  alt="" data-action="zoom" /></div></li>';
            //            //strhtml += '<li class="example"><img src="' + strAddressAndPortfull + '" style="max-width:200px; margin-left: 10px; " alt="" id="txtImgPath' + arrViewpointAttachmentObjLst[y].viewpointAttachmentId + '"/></li>';
            //        }
            //    }

            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst1[i].updUser);

            //    if (objUserRoleRel != null) {
            //        if (arrvRTViewpointRelaObjLst1[i].viewsUserId == arrvRTViewpointRelaObjLst1[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvRTViewpointRelaObjLst1[i].ViewsUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvRTViewpointRelaObjLst1[i].ViewsUserName + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst1[i].userName + '(教师)</span>';
            //        }
            //    }
            //    else {
            //        if (arrvRTViewpointRelaObjLst1[i].viewsUserId == arrvRTViewpointRelaObjLst1[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用人]：</span>' + arrvRTViewpointRelaObjLst1[i].ViewsUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvRTViewpointRelaObjLst1[i].ViewsUserName + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst1[i].userName;
            //        }
            //    }

            //    if (arrvRTViewpointRelaObjLst1[i].viewsDate == arrvRTViewpointRelaObjLst1[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用时间]：</span>' + arrvRTViewpointRelaObjLst1[i].viewsDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTViewpointRelaObjLst1[i].viewsDate + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst1[i].updDate;
            //    }

            //    if (objUserRoleRel == null) {
            //        //是否提交
            //        if (arrvRTViewpointRelaObjLst1[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';

            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[评论]：</span>';

            //            //var objLike = arrViewpointLikeLogObjLst.find(x => x.viewpointId == strViewpointId);//老方法
            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strViewpointId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTViewpointRelaObjLst1[i].viewpointId + '","' + arrvRTViewpointRelaObjLst1[i].viewsUserId + '","03")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTViewpointRelaObjLst1[i].viewpointId + '","' + arrvRTViewpointRelaObjLst1[i].viewsUserId + '","03")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvRTViewpointRelaObjLst1[i].okCount + '&nbsp;&nbsp;';
            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue" >评论数:' + arrvRTViewpointRelaObjLst1[i].appraiseCount + '</span >';
            //            //评分

            //            if (arrvRTViewpointRelaObjLst1[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTViewpointRelaObjLst1[i].score;
            //            }
            //            if (arrvRTViewpointRelaObjLst1[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTViewpointRelaObjLst1[i].teaScore;
            //            }
            //            if (arrvRTViewpointRelaObjLst1[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTViewpointRelaObjLst1[i].stuScore;
            //            }

            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('个人观点评论', '../GraduateEduTools/SysComment?Key=" + arrvRTViewpointRelaObjLst1[i].viewpointId + "&Type=03&User=" + arrvRTViewpointRelaObjLst1[i].updUser + "&pubParentId=" + clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";

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




            //专家观点
            //strhtml += '<div class="info" id="infoExpert"><div class="title btn-3"><a href="#" title="专家观点">专家观点</a></div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvRTViewpointRelaObjLst2.length; i++) {
            //    //得到viewpointId；
            //    var strViewpointId = arrvRTViewpointRelaObjLst2[i].viewpointId;
            //    v++;
            //    //对内容进行换行替换
            //    var strViewpointContent = arrvRTViewpointRelaObjLst2[i].viewpointContent;
            //    var strReason = arrvRTViewpointRelaObjLst2[i].reason;

            //    strViewpointContent = strViewpointContent.replace(/\r\n/g, strBr);
            //    strViewpointContent = strViewpointContent.replace(/\n/g, strBr);

            //    strReason = strReason.replace(/\r\n/g, strBr);
            //    strReason = strReason.replace(/\n/g, strBr);

            //    //strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst2[i].viewpointName + '</span></li>';
            //    strhtml += '<li><span class="rowtit color3 btnLeft">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst2[i].viewpointName + '</span>';
            //    if (arrvRTViewpointRelaObjLst2[i].versionCount > 0 && arrvRTViewpointRelaObjLst2[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('专家观点历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTViewpointRelaObjLst2[i].viewpointId + "&Type=04')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst2[i].viewpointTypeName + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvRTViewpointRelaObjLst2[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';

            //    //查询附件
            //    arrViewpointAttachmentObjLst = arrViewpointAttachmentObjLst2.filter(x => x.viewpointId == strViewpointId);
            //    if (arrvRTViewpointRelaObjLst2.length > 0) {
            //        for (var y = 0; y < arrViewpointAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrViewpointAttachmentObjLst[y].filePath;
            //            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '"  alt="" data-action="zoom" /></div></li>';
            //        }
            //    }

            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTViewpointRelaObjLst2[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvRTViewpointRelaObjLst2[i].viewsUserId == arrvRTViewpointRelaObjLst2[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvRTViewpointRelaObjLst2[i].ViewsUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvRTViewpointRelaObjLst2[i].ViewsUserName + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst2[i].userName + '(教师)</span>';
            //        }
            //    }
            //    else {
            //        if (arrvRTViewpointRelaObjLst2[i].viewsUserId == arrvRTViewpointRelaObjLst2[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用人]：</span>' + arrvRTViewpointRelaObjLst2[i].ViewsUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvRTViewpointRelaObjLst2[i].ViewsUserName + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst2[i].userName;
            //        }
            //    }

            //    if (arrvRTViewpointRelaObjLst2[i].viewsDate == arrvRTViewpointRelaObjLst2[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用时间]：</span>' + arrvRTViewpointRelaObjLst2[i].viewsDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTViewpointRelaObjLst2[i].viewsDate + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst2[i].updDate;
            //    }


            //    if (objUserRoleRel == null) {

            //        if (arrvRTViewpointRelaObjLst2[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';

            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[评论]：</span>';
            //            //点赞
            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strViewpointId);//新0605
            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTViewpointRelaObjLst2[i].viewpointId + '","' + arrvRTViewpointRelaObjLst2[i].viewsUserId + '","04")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTViewpointRelaObjLst2[i].viewpointId + '","' + arrvRTViewpointRelaObjLst2[i].viewsUserId + '","04")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvRTViewpointRelaObjLst2[i].okCount + '&nbsp;&nbsp;';
            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span  style="color:royalblue" >评论数:' + arrvRTViewpointRelaObjLst2[i].appraiseCount + '</span >';
            //            //评分
            //            if (arrvRTViewpointRelaObjLst2[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTViewpointRelaObjLst2[i].score;
            //            }
            //            if (arrvRTViewpointRelaObjLst2[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTViewpointRelaObjLst2[i].teaScore;
            //            }
            //            if (arrvRTViewpointRelaObjLst2[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTViewpointRelaObjLst2[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('专家观点评论', '../GraduateEduTools/SysComment?Key=" + arrvRTViewpointRelaObjLst2[i].viewpointId + "&Type=04&User=" + arrvRTViewpointRelaObjLst2[i].updUser + "&pubParentId=" + clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTViewpointRelaObjLst2[i].viewpointId + '","04","' + arrvRTViewpointRelaObjLst2[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
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
            //for (var i = 0; i < arrvRTConceptObjLst.length; i++) {
            //    //得到概念Id；
            //    var strConceptId = arrvRTConceptObjLst[i].conceptId;
            //    v++;
            //    //对内容进行换行替换
            //    var strConceptContent = arrvRTConceptObjLst[i].conceptContent;
            //    strConceptContent = strConceptContent.replace(/\r\n/g, strBr);
            //    strConceptContent = strConceptContent.replace(/\n/g, strBr);



            //    strhtml += '<li><span class="rowtit color4 btnLeft">' + v + '.[概念]：</span><span class="abstract-text">' + arrvRTConceptObjLst[i].conceptName + '</span>';
            //    if (arrvRTConceptObjLst[i].versionCount > 0 && arrvRTConceptObjLst[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('相关概念历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTConceptObjLst[i].conceptId + "&Type=05')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + strConceptContent + '</span></li>';

            //    //查询附件
            //    arrConceptAttachmentObjLst = arrConceptAttachmentObjLst2.filter(x => x.conceptId == strConceptId);
            //    if (arrConceptAttachmentObjLst.length > 0) {
            //        for (var y = 0; y < arrConceptAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrConceptAttachmentObjLst[y].filePath;
            //            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '"  alt="" data-action="zoom" /></div></li>';
            //        }
            //    }

            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTConceptObjLst[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvRTConceptObjLst[i].concepUserId == arrvRTConceptObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvRTConceptObjLst[i].ConcepUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvRTConceptObjLst[i].ConcepUserName + '&nbsp;/&nbsp;' + arrvRTConceptObjLst[i].userName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvRTConceptObjLst[i].concepUserId == arrvRTConceptObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用人]：</span>' + arrvRTConceptObjLst[i].ConcepUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvRTConceptObjLst[i].ConcepUserName + '&nbsp;/&nbsp;' + arrvRTConceptObjLst[i].userName;
            //        }
            //    }

            //    if (arrvRTConceptObjLst[i].concepDate == arrvRTConceptObjLst[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvRTConceptObjLst[i].concepDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTConceptObjLst[i].concepDate + '&nbsp;/&nbsp;' + arrvRTConceptObjLst[i].updDate;
            //    }

            //    if (objUserRoleRel == null) {


            //        if (arrvRTConceptObjLst[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';

            //            //点赞
            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strConceptId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTConceptObjLst[i].conceptId + '","' + arrvRTConceptObjLst[i].concepUserId + '","05")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTConceptObjLst[i].conceptId + '","' + arrvRTConceptObjLst[i].concepUserId + '","05")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvRTConceptObjLst[i].okCount + '&nbsp;&nbsp;';

            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue")>评论数:' + arrvRTConceptObjLst[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvRTConceptObjLst[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTConceptObjLst[i].score;
            //            }
            //            if (arrvRTConceptObjLst[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTConceptObjLst[i].teaScore;
            //            }
            //            if (arrvRTConceptObjLst[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTConceptObjLst[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('相关概念评论', '../GraduateEduTools/SysComment?Key=" + arrvRTConceptObjLst[i].conceptId + "&Type=05&User=" + arrvRTConceptObjLst[i].updUser + "&pubParentId=" + clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTConceptObjLst[i].conceptId + '","05","' + arrvRTConceptObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
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
            //for (var i = 0; i < arrvRTTopicObjectiveRelaObjLst1.length; i++) {
            //    var FactTopicObjectiveId = arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId;
            //    v++;
            //    //对内容进行换行替换
            //    var strObjectiveContent = arrvRTTopicObjectiveRelaObjLst1[i].objectiveContent;
            //    var strConclusion = arrvRTTopicObjectiveRelaObjLst1[i].conclusion;
            //    strObjectiveContent = strObjectiveContent.replace(/\r\n/g, strBr);
            //    strObjectiveContent = strObjectiveContent.replace(/\n/g, strBr);
            //    strConclusion = strConclusion.replace(/\r\n/g, strBr);
            //    strConclusion = strConclusion.replace(/\n/g, strBr);


            //    strhtml += '<li><span class="rowtit color6 btnLeft">' + v + '.[标题]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst1[i].objectiveName + '</span>';
            //    if (arrvRTTopicObjectiveRelaObjLst1[i].versionCount > 0 && arrvRTTopicObjectiveRelaObjLst1[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('客观事实历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + "&Type=06')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';

            //    //查询附件
            //    arrObjectiveAttachmentObjLst = arrObjectiveAttachmentObjLst2.filter(x => x.topicObjectiveId == FactTopicObjectiveId);
            //    if (arrObjectiveAttachmentObjLst.length > 0) {
            //        for (var y = 0; y < arrObjectiveAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrObjectiveAttachmentObjLst[y].filePath;
            //            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '"  alt="" data-action="zoom" /></div></li>';
            //        }
            //    }

            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst1[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvRTTopicObjectiveRelaObjLst1[i].objUserId == arrvRTTopicObjectiveRelaObjLst1[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvRTTopicObjectiveRelaObjLst1[i].ObjUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvRTTopicObjectiveRelaObjLst1[i].ObjUserName + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst1[i].userName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvRTTopicObjectiveRelaObjLst1[i].objUserId == arrvRTTopicObjectiveRelaObjLst1[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑引用人]：</span>' + arrvRTTopicObjectiveRelaObjLst1[i].ObjUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvRTTopicObjectiveRelaObjLst1[i].ObjUserName + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst1[i].userName;
            //        }
            //    }
            //    if (arrvRTTopicObjectiveRelaObjLst1[i].objDate == arrvRTTopicObjectiveRelaObjLst1[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst1[i].objDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst1[i].objDate + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst1[i].updDate;
            //    }
            //    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst1[i].objDate + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst1[i].updDate + '</li>';

            //    if (objUserRoleRel == null) {

            //        if (arrvRTTopicObjectiveRelaObjLst1[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';

            //            //点赞

            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == FactTopicObjectiveId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + '","' + arrvRTTopicObjectiveRelaObjLst1[i].objUserId + '","06")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + '","' + arrvRTTopicObjectiveRelaObjLst1[i].objUserId + '","06")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvRTTopicObjectiveRelaObjLst1[i].okCount + '&nbsp;&nbsp;';

            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue">评论数:' + arrvRTTopicObjectiveRelaObjLst1[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvRTTopicObjectiveRelaObjLst1[i].score != null) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTTopicObjectiveRelaObjLst1[i].score;
            //            }
            //            if (arrvRTTopicObjectiveRelaObjLst1[i].teaScore != null) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTTopicObjectiveRelaObjLst1[i].teaScore;
            //            }
            //            if (arrvRTTopicObjectiveRelaObjLst1[i].stuScore != null) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTTopicObjectiveRelaObjLst1[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('客观事实评论', '../GraduateEduTools/SysComment?Key=" + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + "&Type=06&User=" + arrvRTTopicObjectiveRelaObjLst1[i].updUser + "&pubParentId=" + clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTTopicObjectiveRelaObjLst1[i].topicObjectiveId + '","06","' + arrvRTTopicObjectiveRelaObjLst1[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
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
            //for (var i = 0; i < arrvRTTopicObjectiveRelaObjLst2.length; i++) {
            //    var BasisTopicObjectiveId = arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId;
            //    v++;
            //    //对内容进行换行替换
            //    var strObjectiveContent = arrvRTTopicObjectiveRelaObjLst2[i].objectiveContent;
            //    var strConclusion = arrvRTTopicObjectiveRelaObjLst2[i].conclusion;
            //    strObjectiveContent = strObjectiveContent.replace(/\r\n/g, strBr);
            //    strObjectiveContent = strObjectiveContent.replace(/\n/g, strBr);
            //    strConclusion = strConclusion.replace(/\r\n/g, strBr);
            //    strConclusion = strConclusion.replace(/\n/g, strBr);

            //    //strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst2[i].objectiveName + '</span></li>';
            //    strhtml += '<li><span class="rowtit color6 btnLeft">' + v + '.[标题]：</span><span class="abstract-text">' + arrvRTTopicObjectiveRelaObjLst2[i].objectiveName + '</span>';
            //    if (arrvRTTopicObjectiveRelaObjLst2[i].versionCount > 0 && arrvRTTopicObjectiveRelaObjLst2[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('客观数据历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + "&Type=07')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';

            //    //查询附件
            //    arrObjectiveAttachmentObjLst = arrObjectiveAttachmentObjLst2.filter(x => x.topicObjectiveId == FactTopicObjectiveId);
            //    if (arrObjectiveAttachmentObjLst.length > 0) {
            //        for (var y = 0; y < arrObjectiveAttachmentObjLst.length; y++) {
            //            var strAddressAndPortfull = strAddressAndPort + arrObjectiveAttachmentObjLst[y].filePath;
            //            strhtml += '<li><div class="example"><img src="' + strAddressAndPortfull + '"  alt="" data-action="zoom" /></div></li>';
            //        }
            //    }

            //    //如果该观点是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTTopicObjectiveRelaObjLst2[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvRTTopicObjectiveRelaObjLst2[i].objUserId == arrvRTTopicObjectiveRelaObjLst2[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + arrvRTTopicObjectiveRelaObjLst2[i].ObjUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + arrvRTTopicObjectiveRelaObjLst2[i].ObjUserName + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst2[i].userName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvRTTopicObjectiveRelaObjLst2[i].objUserId == arrvRTTopicObjectiveRelaObjLst2[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑引用人]：</span>' + arrvRTTopicObjectiveRelaObjLst2[i].ObjUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[编辑&nbsp;/&nbsp;引用人]：</span>' + arrvRTTopicObjectiveRelaObjLst2[i].ObjUserName + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst2[i].userName;
            //        }
            //    }

            //    if (arrvRTTopicObjectiveRelaObjLst2[i].objDate == arrvRTTopicObjectiveRelaObjLst2[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst2[i].objDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTTopicObjectiveRelaObjLst2[i].objDate + '&nbsp;/&nbsp;' + arrvRTTopicObjectiveRelaObjLst2[i].updDate;
            //    }

            //    if (objUserRoleRel == null) {

            //        if (arrvRTTopicObjectiveRelaObjLst2[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';

            //            //点赞

            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == BasisTopicObjectiveId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + '","' + arrvRTTopicObjectiveRelaObjLst2[i].objUserId + '","07")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + '","' + arrvRTTopicObjectiveRelaObjLst2[i].objUserId + '","07")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvRTTopicObjectiveRelaObjLst2[i].okCount + '&nbsp;&nbsp;';


            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue">评论数:' + arrvRTTopicObjectiveRelaObjLst2[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvRTTopicObjectiveRelaObjLst2[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTTopicObjectiveRelaObjLst2[i].score;
            //            }
            //            if (arrvRTTopicObjectiveRelaObjLst2[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTTopicObjectiveRelaObjLst2[i].teaScore;
            //            }
            //            if (arrvRTTopicObjectiveRelaObjLst2[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTTopicObjectiveRelaObjLst2[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('客观事实评论', '../GraduateEduTools/SysComment?Key=" + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + "&Type=07&User=" + arrvRTTopicObjectiveRelaObjLst2[i].updUser + "&pubParentId=" + clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTTopicObjectiveRelaObjLst2[i].topicObjectiveId + '","07","' + arrvRTTopicObjectiveRelaObjLst2[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
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
            //for (var i = 0; i < arrvRTSysSkillObjLst.length; i++) {
            //    //得到技能Id；
            //    var strSkillId = arrvRTSysSkillObjLst[i].skillId;
            //    v++;

            //    var strProcess = arrvRTSysSkillObjLst[i].process;
            //    strProcess = strProcess.replace(/\r\n/g, strBr);
            //    strProcess = strProcess.replace(/\n/g, strBr);

            //    //strhtml += '<li><span class="rowtit color4">' + v + '.[技能]：</span><span class="abstract-text">' + arrvRTSysSkillObjLst[i].conceptName + '</span></li>';

            //    strhtml += '<li><span class="rowtit color4 btnLeft">' + v + '.[技能名称]：</span><span class="abstract-text">' + arrvRTSysSkillObjLst[i].skillName + '</span>';
            //    if (arrvRTSysSkillObjLst[i].versionCount > 0 && arrvRTSysSkillObjLst[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('相关技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTSysSkillObjLst[i].skillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[实施过程]：</span><span class="abstract-text">' + strProcess + '</span></li>';

            //    //获取引用人；编辑人、用户名称
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人
            //    var CacitionUserName;//引用人
            //    //获取技能引用人；
            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvRTSysSkillObjLst[i].updUser);//技能引用人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        CacitionUserName = arrvUsers[j].userName;
            //        break;
            //    }
            //    //获取技能编辑人；
            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvRTSysSkillObjLst[i].skillUpdUser);//技能编辑人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        UpdUserName = arrvUsers[j].userName;
            //        break;
            //    }

            //    //如果该技能是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTSysSkillObjLst[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvRTSysSkillObjLst[i].skillUpdUser == arrvRTSysSkillObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + UpdUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvRTSysSkillObjLst[i].skillUpdUser == arrvRTSysSkillObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用人]：</span>' + UpdUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用人]：</span>' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            //        }
            //    }

            //    if (arrvRTSysSkillObjLst[i].skillUpdDate == arrvRTSysSkillObjLst[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑引用时间]：</span>' + arrvRTSysSkillObjLst[i].skillUpdDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTSysSkillObjLst[i].skillUpdDate + '&nbsp;/&nbsp;' + arrvRTSysSkillObjLst[i].updDate;
            //    }


            //    if (objUserRoleRel == null) {
            //        if (arrvRTSysSkillObjLst[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';
            //            //点赞
            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSkillId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTSysSkillObjLst[i].skillId + '","' + arrvRTSysSkillObjLst[i].skillUpdUser + '","09")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTSysSkillObjLst[i].skillId + '","' + arrvRTSysSkillObjLst[i].skillUpdUser + '","09")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvRTSysSkillObjLst[i].okCount + '&nbsp;&nbsp;';

            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue")>评论数:' + arrvRTSysSkillObjLst[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvRTSysSkillObjLst[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTSysSkillObjLst[i].score;
            //            }
            //            if (arrvRTSysSkillObjLst[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTSysSkillObjLst[i].teaScore;
            //            }
            //            if (arrvRTSysSkillObjLst[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTSysSkillObjLst[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('操作技能评论', '../GraduateEduTools/SysComment?Key=" + arrvRTSysSkillObjLst[i].skillId + "&Type=09&User=" + arrvRTSysSkillObjLst[i].updUser + "&pubParentId=" + clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTSysSkillObjLst[i].conceptId + '","05","' + arrvRTConceptObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
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
            //for (var i = 0; i < arrvRTSysSocialRelaObjLst.length; i++) {
            //    //得到社会关系Id；
            //    var strSocialId = arrvRTSysSocialRelaObjLst[i].socialId;
            //    v++;

            //    var strDetailedDescription = arrvRTSysSocialRelaObjLst[i].detailedDescription;
            //    strDetailedDescription = strDetailedDescription.replace(/\r\n/g, strBr);
            //    strDetailedDescription = strDetailedDescription.replace(/\n/g, strBr);
            //    //strhtml += '<li><span class="rowtit color3">' + v + '.[技能]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].conceptName + '</span></li>';

            //    strhtml += '<li><span class="rowtit color3 btnLeft">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].fullName + '</span>';
            //    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].nationality + '</span>';
            //    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].workUnit + '</span>';
            //    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].major + '</span>';
            //    if (arrvRTSysSocialRelaObjLst[i].versionCount > 0 && arrvRTSysSocialRelaObjLst[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('社会关系历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTSysSocialRelaObjLst[i].socialId + "&Type=09')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';

            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].achievement + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + strDetailedDescription + '</span></li>';

            //    //获取引用人；编辑人、用户名称
            //    //var arrUsers: Array<clsvUsersSimEN> = await Users_GetObjLstAsync("1=1");
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人
            //    var CacitionUserName;//引用人
            //    //获取技能引用人；
            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvRTSysSocialRelaObjLst[i].updUser);//社会关系引用人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        CacitionUserName = arrvUsers[j].userName;
            //        break;
            //    }
            //    //获取技能编辑人；
            //    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == arrvRTSysSocialRelaObjLst[i].socialUpdUser);//社会关系编辑人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        UpdUserName = arrvUsers[j].userName;
            //        break;
            //    }

            //    //如果该技能是老师，编辑人后面加上教师标识
            //    var objUserRoleRel = arrvUserRoleRelationObjLst.find(x => x.userId == arrvRTSysSocialRelaObjLst[i].updUser);
            //    if (objUserRoleRel != null) {
            //        if (arrvRTSysSocialRelaObjLst[i].socialUpdUser == arrvRTSysSocialRelaObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑引用人]：' + UpdUserName + '(教师)</span>';
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[编辑&nbsp;/&nbsp;引用人]：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName + '(教师)</span>';
            //        }
            //    } else {
            //        if (arrvRTSysSocialRelaObjLst[i].socialUpdUser == arrvRTSysSocialRelaObjLst[i].updUser) {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用人]：</span>' + UpdUserName;
            //        } else {
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用人]：</span>' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            //        }
            //    }

            //    if (arrvRTSysSocialRelaObjLst[i].socialUpdDate == arrvRTSysSocialRelaObjLst[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑引用时间]：</span>' + arrvRTSysSocialRelaObjLst[i].socialUpdDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[编辑&nbsp;/&nbsp;引用时间]：</span>' + arrvRTSysSocialRelaObjLst[i].socialUpdDate + '&nbsp;/&nbsp;' + arrvRTSysSocialRelaObjLst[i].updDate;
            //    }


            //    if (objUserRoleRel == null) {

            //        if (arrvRTSysSocialRelaObjLst[i].isSubmit == true) {
            //            strhtml += '&nbsp;&nbsp;<span class="rowtit color5">[已提交]</span></li>';
            //            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[评论]：</span>';

            //            //点赞
            //            var objLike = arrSysVoteObjLst.find(x => x.tableKey == strSocialId);//新0605

            //            if (objLike == null) {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTSysSocialRelaObjLst[i].socialId + '","' + arrvRTSysSocialRelaObjLst[i].socialUpdUser + '","10")><img src="../img/vote.png" width = "20px" height = "18px" title = "点赞"></a>';
            //            } else {
            //                strhtml += '<a href="javascript:void(0)" onclick = btnAddVote_Click("' + arrvRTSysSocialRelaObjLst[i].socialId + '","' + arrvRTSysSocialRelaObjLst[i].socialUpdUser + '","10")><img src="../img/vote2.png" width = "20px" height = "18px" title = "已点赞"></a>';
            //            }
            //            strhtml += '&nbsp;' + arrvRTSysSocialRelaObjLst[i].okCount + '&nbsp;&nbsp;';


            //            //评论
            //            strhtml += '&nbsp;&nbsp;<span style="color:royalblue")>评论数:' + arrvRTSysSocialRelaObjLst[i].appraiseCount + '</span>';
            //            //评分
            //            if (arrvRTSysSocialRelaObjLst[i].score != 0) {
            //                strhtml += '&nbsp;&nbsp;综合评分:' + arrvRTSysSocialRelaObjLst[i].score;
            //            }
            //            if (arrvRTSysSocialRelaObjLst[i].teaScore != 0) {
            //                strhtml += '&nbsp;&nbsp;教师评分:' + arrvRTSysSocialRelaObjLst[i].teaScore;
            //            }
            //            if (arrvRTSysSocialRelaObjLst[i].stuScore != 0) {
            //                strhtml += '&nbsp;&nbsp;学生评分:' + arrvRTSysSocialRelaObjLst[i].stuScore;
            //            }
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('社会关系评论', '../GraduateEduTools/SysComment?Key=" + arrvRTSysSocialRelaObjLst[i].socialId + "&Type=10&User=" + arrvRTSysSocialRelaObjLst[i].updUser + "&pubParentId=" + clsPrivateSessionStorage.topicId + "&FontSize=" + $("#hidFontSize").val() + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论</button >";
            //            //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = btnShowAppraise_Click("' + arrvRTSysSocialRelaObjLst[i].conceptId + '","05","' + arrvRTConceptObjLst[i].updUser + '") > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
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
            strhtml += await Public_Viewpoint.BindList_vRTViewpointRela("07", "01", arrvRTViewpointRelaObjLst1);
            //专家观点
            strhtml += await Public_Viewpoint.BindList_vRTViewpointRela("07", "02", arrvRTViewpointRelaObjLst2);
            //概念
            strhtml += await Public_Concept.BindList_vRTConceptRela("07", arrvRTConceptObjLst);
            //客观事实
            strhtml += await Public_TopicObjective.BindList_vRTTopicObjectiveRela("07", "01", arrvRTTopicObjectiveRelaObjLst1);
            //客观数据
            strhtml += await Public_TopicObjective.BindList_vRTTopicObjectiveRela("07", "02", arrvRTTopicObjectiveRelaObjLst2);
            //技能
            strhtml += await Public_SysSkill.BindList_vRTSysSkill("07", arrvRTSysSkillObjLst);
            //社会关系
            strhtml += await Public_SysSocialRelations.BindList_vRTSysSocialRela("07", arrvRTSysSocialRelaObjLst);



            //拼接；
            $("#divContent_list").html(strhtml);

            SetFontSize();
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
        const strThisFuncName = this.btnAddVote_Click.name;

        //thIs.DivName = "divAddNewRecordSave";
        var objSysVoteEN: clsSysVoteEN = new clsSysVoteEN();

        objSysVoteEN.SetTableKey(strViewpointId);
        objSysVoteEN.SetVoteTypeId(strVoteTypeId);
        objSysVoteEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班
        objSysVoteEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        objSysVoteEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
        objSysVoteEN.SetLikedUserId(strUserId);//被点赞用户
        objSysVoteEN.SetPubParentId(clsPrivateSessionStorage.topicId);
        var strWhereCond = " 1 =1 and updUser='" + clsPublocalStorage.userId + "' and tableKey=" + strViewpointId;
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
                        objViewpointEN.SetViewpointId(strViewpointId);
                        objViewpointEN.SetOkCount(intVoteCount);

                        objViewpointEN.sfUpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
                        objViewpointEN.SetViewpointId(strViewpointId);
                        objViewpointEN.SetOkCount(intVoteCount);

                        objViewpointEN.sfUpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
                        objConceptEN.SetConceptId(strViewpointId);
                        objConceptEN.SetOkCount(intVoteCount);

                        objConceptEN.sfUpdFldSetStr = objConceptEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
                        objTopicObjectiveEN.SetTopicObjectiveId(strViewpointId);
                        objTopicObjectiveEN.SetOkCount(intVoteCount);

                        objTopicObjectiveEN.sfUpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
                        objTopicObjectiveEN.SetTopicObjectiveId(strViewpointId);
                        objTopicObjectiveEN.SetOkCount(intVoteCount);

                        objTopicObjectiveEN.sfUpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
                             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
                        objysSkillEN.SetSkillId(strViewpointId);
                        objysSkillEN.SetOkCount(intVoteCount);

                        objysSkillEN.sfUpdFldSetStr = objysSkillEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objysSkillEN.skillId == "" || objysSkillEN.skillId == undefined) {
                             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
                        objSysSocialRelationsEN.SetSocialId(strViewpointId);
                        objSysSocialRelationsEN.SetOkCount(intVoteCount);

                        objSysSocialRelationsEN.sfUpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
                        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
    //public async btnAddLikeLog_Click() {
    //    //this.DivName = "divAddNewRecordSave";
    //    var objViewpointLikeLogEN: clsViewpointLikeLogEN = new clsViewpointLikeLogEN();

    //    objViewpointLikeLogEN.SetViewpointId($("#hidViewpointId").val();
    //    objViewpointLikeLogEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
    //    objViewpointLikeLogEN.SetUpdUser(clsPublocalStorage.userId;// 修改用户Id
    //    var strWhereCond = " 1 =1 and updUser='" + objViewpointLikeLogEN.updUser + "' and viewpointId=" + objViewpointLikeLogEN.viewpointId;
    //    try {
    //        const responseText = await ViewpointLikeLog_IsExistRecordAsync(strWhereCond);
    //        var bolIsExist: boolean = responseText;
    //        if (bolIsExist == true) {
    //            var strMsg: string = `您已经点赞过这条观点了，请给其他观点点赞一下吧！`;
    //            alert(strMsg);
    //            return responseText;//一定要有一个返回值，否则会出错！
    //        }

    //        const responseText2 = await ViewpointLikeLog_AddNewRecordAsync(objViewpointLikeLogEN);
    //        var returnBool: boolean = !!responseText2;
    //        if (returnBool == true) {

    //            const responseBindGv = await this.BindGv_AllTopicRela();
    //        }
    //        else {
    //            var strInfo: string = `点赞不成功!`;
    //            $('#lblResult40').val(strInfo);
    //            //显示信息框
    //            alert(strInfo);

    //        }
    //        return responseText2;//一定要有一个返回值，否则会出错！
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `点赞不成功,${e}.`;
    //        alert(strMsg);
    //    }

    //    return true;//一定要有一个返回值，否则会出错！
    //}

    //显示评论
    public async btnShowAppraise_Click() {

        var arrvSysCommentObjLst1: Array<clsvSysCommentEN> = [];
        var arrvSysCommentObjLst2: Array<clsvSysCommentEN> = [];
        var arrvSysCommentObjLst3: Array<clsvSysCommentEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";
        if ($('#hidOrderbyId').val() == "1") {
            //全部评论
            strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "2") {
            //个人评论
            strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' and updUser='" + clsPublocalStorage.userId + "' order by updDate Asc";
            strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' and updUser='" + clsPublocalStorage.userId + "' order by updDate Asc";
        } else if ($('#hidOrderbyId').val() == "3") {
            //最新评论
            strWhereCond1 = " parentId='root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Desc";
            strWhereCond2 = " parentId<>'root' and  commentTypeId='" + $("#hidCommentTypeId").val() + "' and tableKey='" + $("#hidTableKey").val() + "' order by updDate Desc";
        }

        try {
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

            const responseText1 = await vSysComment_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvSysCommentObjLst1 = <Array<clsvSysCommentEN>>jsonData;
            });
            const responseText2 = await vSysComment_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvSysCommentObjLst2 = <Array<clsvSysCommentEN>>jsonData;
            });

            var strhtml = "";
            var varNum = 0;
            $('#J_ShortComment div').remove();
            for (var i = 0; i < arrvSysCommentObjLst1.length; i++) {
                varNum++;
                strhtml += '<div class="comment" id = "J_Comment6631028263006567418">';
                strhtml += '<div class="common-avatar J_User" data-userid="17755842" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                strhtml += '<div class="comment-block" id="J_CommentBlock6631028263006567418">';
                var strUserName: string = "";
                var objUser = arrUsers.find(x => x.userId == arrvSysCommentObjLst1[j].updUser);
                if (objUser != null) {
                    strUserName = objUser.userName;
                }
                if ($("#hidViewpointUserId").val() == arrvSysCommentObjLst1[i].updUser) {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842 style="color:red;" > 楼主：' + strUserName + '</span>';
                } else {
                    strhtml += '<p class="comment-user" ><span class="comment-username J_User" data-userid="17755842">' + strUserName + '</span>';
                }
                strhtml += '<span class="comment-time">' + arrvSysCommentObjLst1[i].updDate + '</span>';
                strhtml += '  <span class="comment-username J_User">' + varNum + '楼</span></p>';
                //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                strhtml += '<div class="comment-content J_CommentContent">' + arrvSysCommentObjLst1[i].comment + '</div>';

                //回复区

                arrvSysCommentObjLst3 = arrvSysCommentObjLst2.filter(x => x.parentId == arrvSysCommentObjLst1[i].commentId);
                if (arrvSysCommentObjLst3.length > 0) {
                    strhtml += '<div class="reply J_ReplyBlock">';
                    for (var j = 0; j < arrvSysCommentObjLst3.length; j++) {

                        strhtml += '<div class="reply-block">';

                        strhtml += '<div class="reply-content">';
                        var strUserName: string = "";
                        var objUser = arrUsers.find(x => x.userId == arrvSysCommentObjLst3[j].updUser);
                        if (objUser != null) {
                            strUserName = objUser.userName;
                        }
                        if ($("#hidViewpointUserId").val() == arrvSysCommentObjLst3[j].updUser) {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328" style="color:red;"> 楼主(' + strUserName + ')</b>：</span>';
                        } else {
                            strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" data-userid="28805328">' + strUserName + '</b>：</span>';
                        }
                        strhtml += '' + arrvSysCommentObjLst3[j].comment + '</div>';



                        strhtml += '<div class="reply-operate reply-operate--hot">'
                        if (arrvSysCommentObjLst3[j].scoreType == "2") {
                            strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrvSysCommentObjLst3[j].score + '</i></span>';
                        } else {
                            strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrvSysCommentObjLst3[j].score + '</i></span>';
                        }
                        strhtml += '<i class="reply-dot">·</i><span>' + arrvSysCommentObjLst3[j].updDate + '</span>';
                        strhtml += '</div>';


                        strhtml += '</div>';

                    }
                    strhtml += '</div>';
                }
                ///评论区
                strhtml += '<div class="comment-operate J_CommentOperate clearfix">';
                if (arrvSysCommentObjLst1[i].scoreType == "2") {
                    strhtml += '<span class="J_Vote reply-operate-item reply-up" style="color:red;">教师评分:<i>' + arrvSysCommentObjLst1[i].score + '</i></span>';
                } else {
                    strhtml += '<span class="J_Vote reply-operate-item reply-up">学生评分:<i>' + arrvSysCommentObjLst1[i].score + '</i></span>';
                }

                strhtml += '<span class="J_Vote comment-operate-item comment-operate-up">赞<i>1</i></span>';
                strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyComment_Click("' + arrvSysCommentObjLst1[i].commentId + '")>回复</span>';
                strhtml += '</div>';

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

    /* 添加评论内容
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async SubmitAppraise_Click() {
        
        var objSysCommentEN: clsSysCommentEN = new clsSysCommentEN();
        //this.PutDataToSysCommentClass(objSysCommentEN);
        objSysCommentEN.SetTableKey($("#hidTableKey").val());
        objSysCommentEN.SetCommentTypeId($("#hidCommentTypeId").val());
        objSysCommentEN.SetParentId($("#hidParentId").val());
        objSysCommentEN.SetPubParentId(clsPrivateSessionStorage.topicId);
        if ($("#hidRoleId").val() == "00620003") {
            objSysCommentEN.SetScoreType("1");
        } else {
            objSysCommentEN.SetScoreType("2");
            objSysCommentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        }
        var strvalue = $("#pin").val();
        //判断是否有打分 
        if (strvalue != "" && strvalue != undefined) {
            //获取值转化分数
            var strScore: string = this.GetScorebyText(strvalue);

            //判断内容是否输入
            if ($("#txtAppraiseContent").val() != "") {
                objSysCommentEN.SetComment( $("#txtAppraiseContent").val());// 评议内容
                objSysCommentEN.SetScore( parseInt(strScore));// 打分
                objSysCommentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
                objSysCommentEN.SetUpdUser(clsPublocalStorage.userId);// 修改用户Id
                try {
                    const responseText2 = await SysCommentEx_AddNewRecordExAsync(objSysCommentEN);
                    //const responseText2 = await SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN);
                    var returnBool: boolean = !!responseText2;
                    if (returnBool == true) {
                        var strInfo: string = `添加成功!`;
                        $('#lblResult40').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        HideDialog3();
                        const response1 = await this.btnShowAppraise_Click();
                        const response2 = await this.BindGv_AllTopicRela();
                        $("#btnOKUpdAppraise").attr("disabled", false);
                    }
                    else {
                        var strInfo: string = `添加失败!`;
                        $('#lblResult40').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        HideDialog3();
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
                var strInfo: string = `请输入评语!`;
                //显示信息框
                alert(strInfo);
                return;
            }

        }
        else {
            $("#J_PostBtn").attr("disabled", false);
            $("#btnOKUpdAppraise").attr("disabled", false);
            var strInfo: string = `请选择评分!`;
            //显示信息框
            alert(strInfo);
            return;
        }
        return true;//一定要有一个返回值，否则会出错！
    }


    /* 添加评论评分
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async SubmitScore_Click() {
        
        var objclsViewpointScoreEN: clsViewpointScoreEN = new clsViewpointScoreEN();
        objclsViewpointScoreEN.SetViewpointId($("#hidViewpointId").val());
        var strvalue = $("#pin").val();
        //判断是否有打分 
        if (strvalue != "" && strvalue != undefined) {

            //获取值转化分数
            var strScore: string = this.GetScorebyText(strvalue);
            objclsViewpointScoreEN.SetViewpointScore(Number(strScore));// 打分
            objclsViewpointScoreEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
            objclsViewpointScoreEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id
            try {
                const responseText2 = await ViewpointScore_AddNewRecordAsync(objclsViewpointScoreEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {

                    const responseBindGv = await this.BindGv_AllTopicRela();
                    this.btnShowAppraise_Click();
                }
                else {

                    //显示评论
                    this.btnShowAppraise_Click();
                }
                return responseText2;//一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `添加评论不成功,${e}.`;
                alert(strMsg);
            }

        }
        else {
            var strInfo: string = `请选择评分!`;
            //显示信息框
            alert(strInfo);
            return;
        }

        return true;//一定要有一个返回值，否则会出错！
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


    ///////////////////////////////////////////////////////////////////////////////3个关系列表数据

    ////////////////////////////////////////主题用户关系
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public async CombinevRTUserRelaCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {

            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTUserRelaEN.con_TopicId} = '${strTopicId}'`;
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTUserRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
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

            const objPage_RTUserRela = new Pub_RTUserRelaList();
            await objPage_RTUserRela.Page_Load();
            //await objPage_ResearchTopic.BindGv_vRTUserRela();
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


    //删除观点关系数据
    public async btnDelViewPointRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelViewPointRelaRecord(lngKeyId);

            const objPage_RTViewpointRela = new Pub_RTViewpointRelaList();
            await objPage_RTViewpointRela.Page_Load();
            //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();

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
    public async CombinevRTPaperRelaCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTPaperRelaEN.con_TopicId} = '${strTopicId}'`;
            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTPaperRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    public async btnDelPaperRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelPaperRelaRecord(lngKeyId);
            const objPage_RTPaperRela = new Pub_RTPaperRelaList();
            await objPage_RTPaperRela.Page_Load();
            //await objPage_RTPaperRela.BindGv_vRTPaperRela();

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
    public async PutDataToResearchTopicClass(pobjResearchTopicEN: clsResearchTopicEN) {
        pobjResearchTopicEN.SetTopicId(this.topicId);// 主题编号
        pobjResearchTopicEN.SetTopicName(this.topicName);// 栏目主题
        pobjResearchTopicEN.SetTopicContent(this.topicContent);// 主题内容
        pobjResearchTopicEN.SetTopicProposePeople( clsPublocalStorage.userId);// 主题提出人
        pobjResearchTopicEN.SetOrderNum(this.orderNum);// 序号
        pobjResearchTopicEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjResearchTopicEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjResearchTopicEN.SetMemo(this.memo);// 备注
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

    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombineResearchTopicCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
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
    public async btnUpdateRecord_Click() {
        //判断主题id
        var strTopicId = clsPrivateSessionStorage.topicId;
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
    public async UpdateRecord(strTopicId: string) {
        const strThisFuncName = this.UpdateRecord.name;
        this.btnSubmit_ResearchTopic = "确认修改";
        this.btnCancel_ResearchTopic = "取消修改";
        this.keyId = strTopicId;
        var strUserId = clsPublocalStorage.userId;

        try {
            const objResearchTopicEN = await ResearchTopic_GetObjByTopicIdAsync(strTopicId);
            if (objResearchTopicEN == null) {
                const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            // //通过判断数据用户是否是当前登录用户；
            if (objResearchTopicEN.updUser == strUserId) {
                ShowDialog('Update');
                this.GetDataFromResearchTopicClass(objResearchTopicEN);
                console.log("完成UpdateRecord!");
            }
            else {
                alert("当前数据不是您所添加，不能修改！");
                return false;
            }
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;

    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnSubmit_ResearchTopic;
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
    /* 查询所有观点的关键字和是否教师评论
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
 */
    public async btnQuery_Click(strListDiv: string) {

        const gvResult = await this.BindGv_AllTopicRela();
    }


    /* 删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
  */
    public async btnDelInRecord_Click(strKeyId: string) {
        try {
            const responseText = await this.DelRecordEx(strKeyId);
            //树形数据源；
            this.GetTopicData();
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
                        clsPrivateSessionStorage.topicId = "";
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

        this.keyId = strTopicId;
        var strUserId = clsPublocalStorage.userId;
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


    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombinevViewpointCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strTopicId = clsPrivateSessionStorage.topicId;
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //排除获取已存在的关系数据
            strWhereCond += ` And viewpointId not in (select viewpointId from RTViewpointRela where topicId = '${strTopicId}')`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    //添加观点 展示观点列表数据
    public async btnAddRela_Click() {
        const objPage_Viewpoint = new Pub_ViewpointList();
        await objPage_Viewpoint.Page_Load();
        //await objPage_Viewpoint.BindGv_vViewpoint();
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
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;
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
                const objPage_RTViewpointRela = new Pub_RTViewpointRelaList();
                await objPage_RTViewpointRela.Page_Load();
            //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();

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

        var strTopicId = clsPrivateSessionStorage.topicId;
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;
        pobjRTViewpointRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTViewpointRelaEN.SetViewpointId(strViewpointId);// 观点Id
        pobjRTViewpointRelaEN.SetProposePeople(strUserId);// 提出人
        pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTViewpointRelaEN.SetUpdUser(strUserId);// 修改用户Id// 修改用户Id
        //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
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
            //排除获取已存在的关系数据
            strWhereCond += ` And paperId not in (select paperId from RTPaperRela where topicId = '${strTopicId}')`;

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }



    //添加论文关系
    public async btnAddPaperRela_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.Page_Load();
        //await objPage_Paper.BindGv_vPaper();

    }



    //查询论列表
    public async btnPaperQuery_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.Page_Load();
        //await objPage_Paper.BindGv_vPaper();
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
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strPaperId = $("#hidPaperId").val();
        var strUserId = clsPublocalStorage.userId;
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
                const objPage_RTPaperRela = new Pub_RTPaperRelaList();
                await objPage_RTPaperRela.Page_Load();
            //await objPage_RTPaperRela.BindGv_vRTPaperRela();

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
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strPaperId = $("#hidPaperId").val();
        var strUserId = clsPublocalStorage.userId;
        pobjRTPaperRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTPaperRelaEN.SetPaperId(strPaperId);// 论文Id
        pobjRTPaperRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTPaperRelaEN.SetUpdUser(strUserId);// 修改人
        pobjRTPaperRelaEN.SetMemo(this.memo);// 备注
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



    ///////////////////////////////////////////////////用户数据部分

    //添加用户关系
    public async btnAddUserRela_Click() {

        const objPage_QxUsers = new Pub_QxUsersList();
        await objPage_QxUsers.Page_Load();
        //await objPage_QxUsers.BindGv_QxUsers();
    }

    //查询用户数据
    public async btnUserQuery_Click() {
        const objPage_QxUsers = new Pub_QxUsersList();
        await objPage_QxUsers.Page_Load();
        //await objPage_QxUsers.BindGv_QxUsers();
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
        var strTopicId = clsPrivateSessionStorage.topicId;
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
                const objPage_RTUserRela = new Pub_RTUserRelaList();
                await objPage_RTUserRela.Page_Load();
            //await objPage_ResearchTopic.BindGv_vRTUserRela();

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
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strPaperId = $("#hidPaperId").val();
        var strUserIdKey = $("#hidUserIdKey").val();
        var strUserId = clsPublocalStorage.userId;
        pobjRTUserRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTUserRelaEN.SetUserId(strUserIdKey);// 用户ID
        pobjRTUserRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTUserRelaEN.SetTopicUserRoleId(this.TopicUserRole_q);
        pobjRTUserRelaEN.SetUpdUser(strUserId);// 修改人
        pobjRTUserRelaEN.SetMemo(this.memo);// 备注
    }


    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombineQxUsersCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strTopicId: string = clsPrivateSessionStorage.topicId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.userId_q != "") {
                strWhereCond += ` And ${clsvUsersEN.con_UserId} like '% ${this.userId_q}%'`;
            }
            if (this.userName_q != "") {
                strWhereCond += ` And ${clsvUsersEN.con_UserName} like '% ${this.userName_q}%'`;
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

  

    ////////////////////////用户列表条件
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
    /*
    * 关键字
   */
    public get Keyword_q(): string {
        return $("#txtKeyword_q").val();
    }
}