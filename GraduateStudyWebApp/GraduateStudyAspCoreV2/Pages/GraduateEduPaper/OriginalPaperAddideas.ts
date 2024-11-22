
import { Public_Concept } from "../GraduateEduPublicPage/Public_Concept.js";
import { Public_SysSkill } from "../GraduateEduPublicPage/Public_SysSkill.js";
import { Public_SysSocialRelations } from "../GraduateEduPublicPage/Public_SysSocialRelations.js";
import { Public_TopicObjective } from "../GraduateEduPublicPage/Public_TopicObjective.js";
import { Public_Viewpoint } from "../GraduateEduPublicPage/Public_Viewpoint.js";
import { ResearchTopicCRUD } from "../PagesBase/GraduateEduTopic/ResearchTopicCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_OriginalPaperLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js";
import { clsgs_PConcepRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PConcepRelaEN.js";
import { clsgs_PTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PTopicObjectiveRelaEN.js";
import { clsgs_PViewpointRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PViewpointRelaEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js";
import { clsSectionEN } from "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js";
import { clsvgs_PConceptRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PConceptRelaEN.js";
import { clsvgs_PSkillRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PSkillRelaEN.js";
import { clsvgs_PSocialRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PSocialRelaEN.js";
import { clsvgs_PTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PTopicObjectiveRelaEN.js";
import { clsvgs_PViewpointRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PViewpointRelaEN.js";
import { clsViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { gs_OriginalPaperLog_AddNewRecordAsync, gs_OriginalPaperLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js";
import { gs_PConcepRela_DelRecordAsync, gs_PConcepRela_GetObjBymIdAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js";
import { gs_PSkillRela_DelRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PSkillRelaWApi.js";
import { gs_PSocialRela_DelRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PSocialRelaWApi.js";
import { gs_PTopicObjectiveRela_DelRecordAsync, gs_PTopicObjectiveRela_GetObjBymIdAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PTopicObjectiveRelaWApi.js";
import { gs_PViewpointRela_AddNewRecordAsync, gs_PViewpointRela_DelRecordAsync, gs_PViewpointRela_GetObjBymIdAsync, gs_PViewpointRela_GetRecCountByCondAsync, gs_PViewpointRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PViewpointRelaWApi.js";
import { Section_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js";
import { vgs_PConceptRela_GetObjLstByPagerAsync, vgs_PConceptRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PConceptRelaWApi.js";
import { vgs_PSkillRela_GetObjLstByPagerAsync, vgs_PSkillRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PSkillRelaWApi.js";
import { vgs_PSocialRela_GetObjLstByPagerAsync, vgs_PSocialRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PSocialRelaWApi.js";
import { vgs_PTopicObjectiveRela_GetObjLstByPagerAsync, vgs_PTopicObjectiveRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PTopicObjectiveRelaWApi.js";
import { vgs_PViewpointRela_GetObjLstByPagerAsync, vgs_PViewpointRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PViewpointRelaWApi.js";
import { Viewpoint_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js";
import { vViewpoint_GetObjLstByPagerAsync, vViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { PaperEx_GetSubObjLstById_CurrEduCls_Cache } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { BindDdl_ObjLst, BindTabV2Where_V, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
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

declare function ShowDialogFour(): void;//添加用户关系；
declare var strCurrPrjId;
declare var $;
declare var window;
/* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class OriginalPaperAddideas extends ResearchTopicCRUD {
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
                this.hidSortvgs_PViewpointRelaBy = "updDate Desc";


                //主题概念
                this.hidSortvgs_PConceptRelaBy = "updDate Desc";


                //观点
                this.hidSortvViewpointBy = "updDate Desc";
                //客观
                //TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";


                //默认不 显示分页
                if (this.recCount == 0) {

                    $("#divPagerViewpoint").attr("style", "display:none;");
                    $("#divPagerConcept").attr("style", "display:none;");
                    $("#divExpertPagerViewpoint").attr("style", "display:none;");
                    $("#divPagerBasis").attr("style", "display:none;");
                    $("#divPagerResearchResult").attr("style", "display:none;");

                }



                //2、显示无条件的表内容在GridView中
                //主题列表因为页面调整问题，注释；
                //const gvResult = await this.BindGv_ResearchTopic();

                //读取session角色 来判断绑定不同数据列表
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
                ////调用关系列表数据
                const responseObjLst1 = await this.GetPaperData();
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
                    BindDdl_ObjLst(ddlSectionId, arrSectionObjLst, clsSectionEN.con_SectionId, clsSectionEN.con_SectionName, "论文节");
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

    public async GetPaperData() {
        var strPaperId = $('#hidPaperId').val();
        const strCourseId = clsPublocalStorage.courseId;
        var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;
        var objvPaper_Cond: clsPaperEN = new clsPaperEN();//查询区域
        
        objvPaper_Cond.SetCondFldValue(clsPaperEN.con_PaperId, strPaperId, "=");
     const   arrPaperExObjLst = await PaperEx_GetSubObjLstById_CurrEduCls_Cache(objvPaper_Cond, strid_CurrEducls);
        var arrvUsersObjLst: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);


        var strhtml = "";
        //var strWhereCond1 = " 1=1 and paperId ='" + pobjvPaperReadWriteEN.paperId + "'";
        //var strWhereCond2 = " 1=1 and paperId ='" + pobjvPaperReadWriteEN.paperId + "' and updUser='" + clsPublocalStorage.userId + "'";

        try {
            //const responseText1 = await vPaperCount_GetFirstObjAsync(strWhereCond1);
            //objvPaperCount = <clsvPaperCountEN>responseText1;

            //const responseText2 = await PaperLikeLog_GetFirstObjAsync(strWhereCond2);
            //objPaperLikeLog = <clsPaperLikeLogEN>responseText2;

            //const responseText3 = await PaperCollectionLog_GetFirstObjAsync(strWhereCond2);
            //objPaperCollectionLog = <clsPaperCollectionLogEN>responseText3;

            var strhtml = "";
            for (var i = 0; i < arrPaperExObjLst.length; i++) {

                strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看', '../GraduateEduEx/PaperDetail?paperId=" + arrPaperExObjLst[i].paperId + "')\"><span style='color:#c7228d;'>" + arrPaperExObjLst[i].paperTitle + "</a>";
                if (arrPaperExObjLst[i].attachmentCount > 0) {
                    strhtml += "<span class=\"btn-2\" style=\"padding-left:50px;\"><a style=\"font-size:15px; color:#f98c51\" href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + arrPaperExObjLst[i].paperId + "')\">pdf查看</a></span>";
                }
                strhtml += '</h6>';

                strhtml += '<div class="baseinfo"><span><a href="#">' + arrPaperExObjLst[i].periodical + '</a></span><span><a href="#">' + arrPaperExObjLst[i].keyword + '</a></span>';
                strhtml += '</div>';
                //<span>' + arrPaperExObjLst[i].periodical + ' < /span><em>' + arrPaperExObjLst[i].keyword + '</em >
                strhtml += '<div class="abstract">' + arrPaperExObjLst[i].paperContent + '</div>';

                strhtml += '<div class="opts"><ul class="opts-count">';
                strhtml += '<li>评论数:<em>' + arrPaperExObjLst[i].appraiseCount + '</em></li>';
                strhtml += '<li>读写数:<em>' + arrPaperExObjLst[i].pcount + '</em></li><li>发表日期:<em>' + arrPaperExObjLst[i].updDate + '</em></li>';
                var objUser = arrvUsersObjLst.find(x => x.userId == arrPaperExObjLst[i].updUser);
                if (objUser != null) {
                    strhtml += '<li>发表人:<em>' + objUser.userName + '</em></li>';
                }
                
                strhtml += '<ul class="opts-btn">';




                //if (arrPaperExObjLst[i].attachmentCount > 0) {
                //    strhtml += '<li>' + arrPaperExObjLst[i].downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click()><i></i><b>点击下载</b></a></li>';
                //} else {
                //    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                //}

                strhtml += '</ul></div>';
                strhtml += '</dd></dl></div>';
            }


            $("#tabwucPaperReadWrite").html(strhtml);



        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定论文对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }

    }

    //得到3个关系列表数据；
    public async GetAllFunctionMethod() {

        //如果是点击了树菜单、或者是刷新，那么需要做样式控制；
        //首先要去掉ul下 li a 样式
        $("#myTab li a").removeClass();
        $("#myTab li").removeClass();
        //判断根据序号显示不同的数据源
        var strnum = $("#hidTabNum").val();
        var strPaperId = $("#hidPaperId").val();
        if (strnum == "3") {
            $("#liViewpoint").addClass("active");
            $("#liViewpoint a").addClass("active");

            $("#li_Viewpoint ").addClass("in active show");
            //主题个人观点关系；
            this.BindGv_vgs_PViewpointRela();
        }
        else if (strnum == "4") {
            $("#liExpertViewpoint").addClass("active");
            $("#liExpertViewpoint a").addClass("active");

            $("#li_ExpertViewpoint ").addClass("in active show");

            //专家观点
            this.BindGv_vRTExpegs_PViewpointRela();
        }
        else if (strnum == "5") {
            $("#liConcept").addClass("active");
            $("#liConcept a").addClass("active");

            $("#li_Concept ").addClass("in active show");

            //主题概念关系
            this.BindGv_vgs_PConceptRela();
        }
        else if (strnum == "6") {
            $("#liObjectiveFact").addClass("active");
            $("#liObjectiveFact a").addClass("active");

            $("#li_Objective ").addClass("in active show");

            //客观事实关系
            this.BindGv_vgs_PTopicObjectiveRela();
        }
        else if (strnum == "7") {
            $("#liObjectiveBasis").addClass("active");
            $("#liObjectiveBasis a").addClass("active");

            $("#li_ObjectiveBasis ").addClass("in active show");

            //客观依据关系
            this.BasisBindGv_vgs_PTopicObjectiveRela();
        }
        else if (strnum == "9") {
            $("#liSysskill").addClass("active");
            $("#liSysskill a").addClass("active");

            $("#liSysskill ").addClass("in active show");

            //技能
            this.BindGv_vgs_PSkillRela();
        }
        else if (strnum == "10") {
            $("#liSysSocialRela").addClass("active");
            $("#liSysSocialRela a").addClass("active");

            $("#liSysSocialRela ").addClass("in active show");

            //社会关系
            this.BindGv_vgs_PSocialRela();
        }
        else {
            $("#liViewpoint").addClass("active");
            $("#liViewpoint a").addClass("active");

            $("#li_Viewpoint ").addClass("in active show");

            const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId1", strPaperId);
            //主题个人观点关系；
            this.BindGv_vgs_PViewpointRela();
        }


    }




    ///////////////////////////////////////////////////////////////////////////////3个关系列表数据

    //////////////////////////////////////////////////////////////////////////////////////////////////专家------观点关系
    //   /* 观点列表表头排序；
    //*/
    //   public async SortBy(strSortByFld: string) {
    //       if (this.hidSortvViewpointBy.indexOf(strSortByFld) >= 0) {
    //           if (this.hidSortvViewpointBy.indexOf("Asc") >= 0) {
    //               this.hidSortvViewpointBy = `${strSortByFld} Desc`;
    //           }
    //           else {
    //               this.hidSortvViewpointBy = `${strSortByFld} Asc`;
    //           }
    //       }
    //       else {
    //           this.hidSortvViewpointBy = `${strSortByFld} Asc`;
    //       }
    //       const responseText2 = await this.BindGv_vViewpoint();
    //   }

    //添加观点 展示观点列表数据
    public async btnAddExperRela_Click() {
        const responseObjList = await this.BindGv_vRTExpegs_PViewpointRela();
    }
    /* 把所有的查询控件内容组合成一个条件串
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
   <returns>条件串(strWhereCond)</returns>
 */
    public CombinevRTExpegs_PViewpointRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.viewpointName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
            //}
            //if (this.topicName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
            //}

            //判断主题id
            var strPaperId = $("#hidPaperId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_PaperId} = '${strPaperId}'`;
            }
            //只显示专家观点数据
            strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_UserTypeId} ='02'`;
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；


            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {
                $("#btnDelRecord").show();
            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
                $("#btnDelRecord").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //  strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
            }
            else {
                //学生； 
                $("#btnDelRecord").show();
                //   strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //学生00620003

                // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${objvUserRoleRelation.userId}'`;
            }


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_PViewpointRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vRTExpegs_PViewpointRela() {
        var strListDiv: string = this.mstrListDivRtExpegs_PViewpointRela;
        var strWhereCond = await this.CombinevRTExpegs_PViewpointRelaCondition();
        var intCurrPageIndex = this.CurrPageIndexViewpoint;//获取当前页
        var arrvgs_PViewpointRelaObjLst: Array<clsvgs_PViewpointRelaEN> = [];
        try {
            this.recCount = await vgs_PViewpointRela_GetRecCountByCondAsync(strWhereCond);

                ////如果记录数小于10,
                //if (this.recCount < 10) {
                //    $("#divPagerViewpoint").attr("style", "display:none;");
                //}
            
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_PViewpointRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_PViewpointRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_PViewpointRelaObjLst = <Array<clsvgs_PViewpointRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {

            this.BindList_vgs_PViewpointRela("02", arrvgs_PViewpointRelaObjLst);
            //this.BindTab_vRTExpegs_PViewpointRela(strListDiv, arrvgs_PViewpointRelaObjLst);
            console.log("完成BindGv_vgs_PViewpointRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vgs_PViewpointRela对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrgs_PViewpointRelaObjLst">需要绑定的对象列表</param>
*/

    //public async BindTab_vRTExpegs_PViewpointRela(divContainer: string, arrvgs_PViewpointRelaObjLst: Array<clsvgs_PViewpointRelaEN>) {
    //    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
    //    if (o == null) {
    //        alert(`${divContainer}不存在！`);
    //        return;
    //    }
    //    var arrDataColumn: Array<clsDataColumn> =
    //        [
    //            {
    //                fldName: "",
    //                colHeader: "",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "CheckBox",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "viewpointName",
    //                colHeader: "观点名称",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "viewpointTypeName",
    //                colHeader: "观点类型名",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },

    //            //{
    //            //    fldName: "topicName",
    //            //    colHeader: "栏目主题",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: () => { }
    //            //},
    //            //{
    //            //    fldName: "userTypeName",
    //            //    colHeader: "观点角色",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: () => { }
    //            //},
    //            {
    //                fldName: "updDate",
    //                colHeader: "修改日期",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "userName",
    //                colHeader: "编辑人",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            //{
    //            //    fldName: "",
    //            //    colHeader: "详情",
    //            //    text: "详情",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Button",
    //            //    orderNum: 1,
    //            //    funcName: (strKeyId: string, strText: string) => {
    //            //        var btn1: HTMLElement = document.createElement("button");
    //            //        btn1.innerText = strText;
    //            //        btn1.className = "btn btn-outline-info btn-sm";
    //            //        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
    //            //        return btn1;
    //            //    }
    //            //},

    //            {
    //                fldName: "",
    //                colHeader: "删除",
    //                text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Button",
    //                orderNum: 1,
    //                funcName: (strKeyId: string, strText: string) => {
    //                    var btn1: HTMLElement = document.createElement("button");
    //                    btn1.innerText = strText;
    //                    btn1.className = "btn btn-outline-info btn-sm";
    //                    btn1.setAttribute("onclick", `btnDelExpegs_PViewpointRelaRecordInTab_Click('${strKeyId}');`);
    //                    return btn1;
    //                }
    //            },
    //        ];
    //    BindTabV2Where(o, arrvgs_PViewpointRelaObjLst, arrDataColumn, "mId", "TopicRTExpertViewpoint");
    //    //BindTab(o, arrvgs_PViewpointRelaObjLst, arrDataColumn, "mId");
    //    if (this.recCount > 10) {
    //        this.objPager.recCount = this.recCount;
    //        this.objPager.pageSize = this.pageSize;
    //        this.objPager.ShowPagerV2(this, this.divName4Pager);
    //    }


    //}



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


    /* 把所有的查询控件内容组合成一个条件串
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
   <returns>条件串(strWhereCond)</returns>
 */
    public Combinevgs_PViewpointRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.viewpointName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
            //}
            //if (this.topicName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
            //}

            //判断主题id
            var strPaperId = $("#hidPaperId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_PaperId} = '${strPaperId}'`;
            }
            //只显示个人观点数据
            strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_UserTypeId} ='01'`;
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；


            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {

                $("#btnDelRecord").show();

            }


            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
                $("#btnDelRecord").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //     strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //学生； 
                $("#btnDelRecord").show();
                //    strWhereCond += ` And ${clsvgs_PViewpointRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //学生00620003

                // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${objvUserRoleRelation.userId}'`;
            }


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_PViewpointRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vgs_PViewpointRela() {
        var strListDiv: string = this.mstrListDivgs_PViewpointRela;
        var strWhereCond = await this.Combinevgs_PViewpointRelaCondition();
        var intCurrPageIndex = this.CurrPageIndexViewpoint;//获取当前页
        var arrvgs_PViewpointRelaObjLst: Array<clsvgs_PViewpointRelaEN> = [];
        try {
            this.recCount = await vgs_PViewpointRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_PViewpointRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_PViewpointRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_PViewpointRelaObjLst = <Array<clsvgs_PViewpointRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            //如果记录数小于10,
            //if (this.recCount < 10) {
            //    $("#divPagerViewpoint").attr("style", "display:none;");
            //}

            this.BindList_vgs_PViewpointRela("01", arrvgs_PViewpointRelaObjLst);
            console.log("完成BindGv_vgs_PViewpointRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    public async BindList_vgs_PViewpointRela(strVType, arrvgs_PViewpointRelaObjLst: Array<clsvgs_PViewpointRelaEN>) {
        $("#hidPageType").val(strVType);
        var strPageType = strVType;//页面参数
        //var strUserId = clsPublocalStorage.userId;
        //var strTitle = "";
        ////判断页面参数
        //if (strPageType == "01") {
        //    strTitle = "个人观点";
        //} else if (strPageType == "02") {
        //    //专家观点
        //    //$("#ListTitle").html("当前论文相关的专家观点");
        //    strTitle = "专家观点";
        //}
        //var strhtml = "";
        ////个人观点
        //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

        //strhtml += '<div style="float:left;"><a href="#" title="' + strTitle + '">' + strTitle + '</a></div>';
        ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';

        //strhtml += '</div><ul class="artlist">';
        //var v = 0;//给内容加个序号
        //for (var i = 0; i < arrvgs_PViewpointRelaObjLst.length; i++) {
        //    //得到viewpointId；
        //    var strViewpointId = arrvgs_PViewpointRelaObjLst[i].viewpointId;
        //    v++;
        //    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
        //    strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst[i].viewpointName + '</span></li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst[i].viewpointContent + '</span></li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvgs_PViewpointRelaObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst[i].reason + '</span></li>';
        //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[依据]：</span><span class="abstract-text">' + arrvgs_PViewpointRelaObjLst[i].viewpointContent + '</span></li>';

        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
        //    if (arrvgs_PViewpointRelaObjLst[i].okCount != 0) {
        //        strhtml += '点赞数：' + arrvgs_PViewpointRelaObjLst[i].okCount + '&nbsp;&nbsp';
        //    }
        //    if (arrvgs_PViewpointRelaObjLst[i].appraiseCount != 0) {
        //        //评论
        //        strhtml += '&nbsp;&nbsp;评论数：' + arrvgs_PViewpointRelaObjLst[i].appraiseCount;
        //    }
        //    if (arrvgs_PViewpointRelaObjLst[i].score != 0) {
        //        //评分
        //        strhtml += '&nbsp;&nbsp;综合评分：' + arrvgs_PViewpointRelaObjLst[i].score;
        //    }
        //    if (arrvgs_PViewpointRelaObjLst[i].teaScore != 0) {
        //        strhtml += '&nbsp;&nbsp;教师评分：' + arrvgs_PViewpointRelaObjLst[i].teaScore;
        //    }
        //    if (arrvgs_PViewpointRelaObjLst[i].stuScore != 0) {
        //        strhtml += '&nbsp;&nbsp;学生评分：' + arrvgs_PViewpointRelaObjLst[i].stuScore;
        //    }
        //    //引用数
        //    strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvgs_PViewpointRelaObjLst[i].citationCount;

        //    if (arrvgs_PViewpointRelaObjLst[i].versionCount != 0) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvgs_PViewpointRelaObjLst[i].versionCount;
        //    }
        //    if (arrvgs_PViewpointRelaObjLst[i].isSubmit == true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
        //    }
        //    else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
        //    }

        //    strhtml += '</li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';


        //    if (arrvgs_PViewpointRelaObjLst[i].viewsUserId == arrvgs_PViewpointRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + arrvgs_PViewpointRelaObjLst[i].ViewsUserName;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvgs_PViewpointRelaObjLst[i].ViewsUserName + '&nbsp;/&nbsp;' + arrvgs_PViewpointRelaObjLst[i].updUser;
        //        //strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvgs_PViewpointRelaObjLst[i].ViewsUserName + '&nbsp;/&nbsp;' + arrvgs_PViewpointRelaObjLst[i].userName;
        //    }
        //    if (arrvgs_PViewpointRelaObjLst[i].viewsDate == arrvgs_PViewpointRelaObjLst[i].updDate) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvgs_PViewpointRelaObjLst[i].viewsDate;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvgs_PViewpointRelaObjLst[i].viewsDate + '&nbsp;/&nbsp;' + arrvgs_PViewpointRelaObjLst[i].updDate;
        //    }
        //    //strhtml += '&nbsp;&nbsp;&nbsp;编辑用户：' + arrvgs_PViewpointRelaObjLst[i].userName;
        //    //strhtml += '&nbsp;&nbsp;编辑时间：' + arrvgs_PViewpointRelaObjLst[i].updDate + '</span>';

        //    if (strUserId == arrvgs_PViewpointRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelViewPointRelaRecordInTab_Click(' + arrvgs_PViewpointRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
        //    }
        //    if (arrvgs_PViewpointRelaObjLst[i].isSubmit != true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdViewPoint_Click("' + arrvgs_PViewpointRelaObjLst[i].viewpointId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
        //    }

        //    if (arrvgs_PViewpointRelaObjLst[i].versionCount > 0 && arrvgs_PViewpointRelaObjLst[i].versionCount != null) {
        //        strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PViewpointRelaObjLst[i].viewpointId + "&Type=03')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
        //    }
        //    strhtml += '</li>';



        //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //}
        //strhtml += '</ul></div>';

        $("#hidPageType").val(strVType);
        var strUserTypeId = strVType;
        var strHtml = await Public_Viewpoint.BindList_vgs_PViewpointRela("06", strUserTypeId, arrvgs_PViewpointRelaObjLst);


        //拼接；
        if (strPageType == "01") {
            $("#divgs_PViewpointRelaDataLst").html(strHtml);

            if (arrvgs_PViewpointRelaObjLst.length > 10) {
                $("#divPagerViewpoint").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        } else if (strPageType == "02") {
            $("#divRtExpegs_PViewpointRelaDataLst").html(strHtml);

            if (arrvgs_PViewpointRelaObjLst.length > 10) {
                $("#divExpertPagerViewpoint").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }

    }



    //public async BindTab_vgs_PViewpointRela(divContainer: string, arrvgs_PViewpointRelaObjLst: Array<clsvgs_PViewpointRelaEN>) {
    //    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
    //    if (o == null) {
    //        alert(`${divContainer}不存在！`);
    //        return;
    //    }
    //    var arrDataColumn: Array<clsDataColumn> =
    //        [
    //            {
    //                fldName: "",
    //                colHeader: "",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "CheckBox",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "viewpointName",
    //                colHeader: "观点名称",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "viewpointTypeName",
    //                colHeader: "观点类型名",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },

    //            //{
    //            //    fldName: "topicName",
    //            //    colHeader: "栏目主题",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: () => { }
    //            //},
    //            //{
    //            //    fldName: "userTypeName",
    //            //    colHeader: "观点角色",
    //            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Label",
    //            //    orderNum: 1,
    //            //    funcName: () => { }
    //            //},
    //            {
    //                fldName: "updDate",
    //                colHeader: "修改日期",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "userName",
    //                colHeader: "编辑人",
    //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            //{
    //            //    fldName: "",
    //            //    colHeader: "详情",
    //            //    text: "详情",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //            //    columnType: "Button",
    //            //    orderNum: 1,
    //            //    funcName: (strKeyId: string, strText: string) => {
    //            //        var btn1: HTMLElement = document.createElement("button");
    //            //        btn1.innerText = strText;
    //            //        btn1.className = "btn btn-outline-info btn-sm";
    //            //        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
    //            //        return btn1;
    //            //    }
    //            //},

    //            {
    //                fldName: "",
    //                colHeader: "删除",
    //                text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Button",
    //                orderNum: 1,
    //                funcName: (strKeyId: string, strText: string) => {
    //                    var btn1: HTMLElement = document.createElement("button");
    //                    btn1.innerText = strText;
    //                    btn1.className = "btn btn-outline-info btn-sm";
    //                    btn1.setAttribute("onclick", `btnDelViewPointRelaRecordInTab_Click('${strKeyId}');`);
    //                    return btn1;
    //                }
    //            },
    //        ];
    //    BindTabV2Where(o, arrvgs_PViewpointRelaObjLst, arrDataColumn, "mId", "TopicRTViewpoint");
    //    //BindTab(o, arrvgs_PViewpointRelaObjLst, arrDataColumn, "mId");
    //    if (this.recCount > 10) {
    //        this.objPager.recCount = this.recCount;
    //        this.objPager.pageSize = this.pageSize;
    //        this.objPager.ShowPagerV2(this, this.divName4Pager);
    //    }


    //}

    //删除个人观点关系数据
    public async btnDelViewPointRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);

            var strUserId = clsPublocalStorage.userId;
            //var strPaperId = $("#hidPaperId").val();
            //var strWhereCond = ` 1=1 And ${clsRTUserRelaEN.con_PaperId} = '${strPaperId}' And ${clsRTUserRelaEN.con_UserId} ='${strUserId}'`;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = gs_PViewpointRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRtViewpointEN: clsgs_PViewpointRelaEN = <clsgs_PViewpointRelaEN>jsonData;
                if (objRtViewpointEN != null) {
                    if (objRtViewpointEN.updUser == strUserId) {
                        //01 个人
                        if ($("#hidPageType").val() == "01") {
                            const responseText = this.DelViewPointRelaRecord(lngKeyId, "01");
                        } else if ($("#hidPageType").val() == "02") {
                            const responseText = this.DelViewPointRelaRecord(lngKeyId, "02");
                        }
                        // const responseText2 = await this.BindGv_vRTPaperRela();
                    }
                    else {

                        //成员
                        var strMsg = `您只能删除自己添加的数据！`;
                        alert(strMsg);
                        return;
                    }
                }
            })


            //const responseText = await this.DelViewPointRelaRecord(lngKeyId);
            //const responseText2 = await this.BindGv_vgs_PViewpointRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    //删除专家观点关系数据
    public async btnDelExpegs_PViewpointRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            var strUserId = clsPublocalStorage.userId;

            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = gs_PViewpointRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRtExpertViewpointEN: clsgs_PViewpointRelaEN = <clsgs_PViewpointRelaEN>jsonData;
                if (objRtExpertViewpointEN != null) {
                    if (objRtExpertViewpointEN.updUser == strUserId) {
                        //01 个人
                        const responseText = this.DelViewPointRelaRecord(lngKeyId, "02");
                        // const responseText2 = await this.BindGv_vRTPaperRela();
                    }
                    else {

                        //成员
                        var strMsg = `您只能删除自己添加的数据！`;
                        alert(strMsg);
                        return;
                    }
                }
            })

            //const responseText = await this.DelViewPointRelaRecord(lngKeyId,"02");
            //const responseText2 = await this.BindGv_vRTExpegs_PViewpointRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }
    /* 
    根据关键字删除记录  type 01 个人 02专家
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public DelViewPointRelaRecord(lngmId: number, TypeId: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = gs_PViewpointRela_DelRecordAsync(lngmId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        //type 01 个人 02专家
                        if (TypeId == "01") {
                            //个人
                            this.BindGv_vgs_PViewpointRela();
                        } else {
                            //专家
                            this.BindGv_vRTExpegs_PViewpointRela();
                        }

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


    //分页数据
    /* 函数功能:在数据 列表中跳转到某一页 观点列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
 <param name = "intPageIndex">页序号</param>
*/
    public IndexPageSix(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vgs_PViewpointRela();
    }




    //////////////////////////////////////////////////////////////////个人观点部分
    //观点查询按钮
    public async btnViewpointQuery_Click() {

        const responseObjList = await this.BindGv_vViewpoint();
    }


    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vViewpoint() {
        var strListDiv: string = this.mstrListDivViewpoint;
        var strWhereCond = await this.CombinevViewpointCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        var arrvUsersObjLst: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        try {
            this.recCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: 30,
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
        //console.error(strMsg);
        //    alert(strMsg);
        //    return;
        //}
        try {

            var strPageType = $("#hidUserTypeId").val();//页面参数
            //var strhidUserTypeId = $("#hidUserTypeId").val();
            var strTitle = "";
            //判断页面参数
            if (strPageType == "01") {
                strTitle = "个人观点";
            } else if (strPageType == "02") {
                //专家观点
                //$("#ListTitle").html("当前论文相关的专家观点");
                strTitle = "专家观点";
            }
            var strhtml = "";
            //个人观点
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            strhtml += '<div><a href="#" title="' + strTitle + '">' + strTitle + '</a></div>';
            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';

            strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号
            for (var i = 0; i < arrvViewpointObjLst.length; i++) {
                //得到viewpointId；
                var strViewpointId = arrvViewpointObjLst[i].viewpointId;
                v++;
                //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointContent + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvViewpointObjLst[i].reason + '</span></li>';
                var objUser = arrvUsersObjLst.find(x => x.userId == arrvViewpointObjLst[i].updUser);
                if (objUser != null) {
                    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + objUser.userName;
                }

                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvViewpointObjLst[i].updDate;


                //引用数
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;被引用数:' + arrvViewpointObjLst[i].citationCount;

                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="引用' + strTitle + '" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkInTab_Click("' + arrvViewpointObjLst[i].viewpointId + '")> <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';


                strhtml += '</li>';

                strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';

            //拼接；
            $("#divViewpointDataLst").html(strhtml);

            if (arrvViewpointObjLst.length > 10) {
                //$("#divPager1").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            //this.BindTab_vViewpoint(strListDiv, arrvViewpointObjLst);
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
    public async CombinevViewpointCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strPaperId = clsPrivateSessionStorage.topicId;
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if ($("#txtViewpointName_q").val() != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${$("#txtViewpointName_q").val()}%'`;
            }
            //if ($("#txtViewUpdName_q").val() != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_UserName} like '% ${$("#txtViewUpdName_q").val()}%'`;
            //}

            //if (this.viewpointTypeId_q != "" && this.viewpointTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_ViewpointTypeId} = '${this.viewpointTypeId_q}'`;
            //}
            //if (this.Reason_q != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_Reason} like '% ${this.Reason_q}%'`;
            //}

            //if ($("#hidUserInfo").val() != "") {
            //    var strUserInfo_Hid = $("#hidUserInfo").val();
            //    var objvUserRoleRelation: clsvQxUserRoleRelationEN;
            //    objvUserRoleRelation = stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);

            //    $("#hidUserId").val(objvUserRoleRelation.userId);
            //    //判断角色 
            //    //管理员
            //    if (objvUserRoleRelation.roleId == "00620001") {

            //        $("#btnDelRecord").show();


            //    }

            //    else {
            //        //学生 教师；
            //        $("#btnDelRecord").hide();

            //        //学生00620003 00620002教师

            //        strWhereCond += ` And ${clsvViewpointEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
            //        //strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} = '${objvUserRoleRelation.userId}'`;

            //    }
            //}

            //根据传入的usertypeId 来区分是本人观点还是专家观点
            var strhidUserTypeId = $("#hidUserTypeId").val();
            if (strhidUserTypeId != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_UserTypeId} = '${strhidUserTypeId}'`;
            }

            //只能查询提交的观点数据
            strWhereCond += ` And ${clsvViewpointEN.con_IsSubmit} = 'true'`;

            //排除获取已存在的关系数据 根据当前用户；
            strWhereCond += ` And viewpointId not in (select viewpointId from gs_PViewpointRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
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
    public async BindTab_vViewpoint(divContainer: string, arrvViewpointObjLst: Array<clsvViewpointEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "viewpointName",
                    colHeader: "观点名称",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "viewpointContent",
                    colHeader: "观点内容",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "viewpointTypeName",
                    colHeader: "观点类型名",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "userTypeName",
                //    colHeader: "观点角色",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "reason",
                //    colHeader: "理由",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "source",
                //    colHeader: "来源",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "vpProposePeople",
                //    colHeader: "观点提出人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "updDate",
                    colHeader: "编辑日期",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "编辑人",
                    text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                //{
                //    fldName: "",
                //    colHeader: "详情",
                //    text: "详情",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        BindTabV2Where_V(o, arrvViewpointObjLst, arrDataColumn, "viewpointId", "TopicViewpoint");
        //BindTab(o, arrvViewpointObjLst, arrDataColumn, "viewpointId");
        this.objPager.recCount = this.recCount;
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
        const strThisFuncName = this.AddNewRecordSaveViewpointRela.name;
        var strPaperId = $('#hidPaperId').val();
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;
        var strPaperLogTypeId = $('#hidPaperLogTypeId').val();//流程日志参数
        var objgs_PViewpointRelaEN: clsgs_PViewpointRelaEN = new clsgs_PViewpointRelaEN();
        this.PutDataTogs_PViewpointRelaClass(objgs_PViewpointRelaEN);

        try {
            //同一主题 同一观点 只能添加一次；
            var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And viewpointId = '" + strViewpointId + "'";
            //var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And viewpointId = '" + strViewpointId + "'";
            const responseText = await gs_PViewpointRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个观点！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await gs_PViewpointRela_AddNewRecordAsync(objgs_PViewpointRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加成功!`;
                $('#lblResult40').val(strInfo);

                //查询 论文、日志类型是否存在；
                var strWhereLog = " 1 = 1 And paperId = '" + strPaperId + "' And logTypeId = '" + strPaperLogTypeId + "'";
                const responseText6 = await gs_OriginalPaperLog_IsExistRecordAsync(strWhereLog);
                var bolIsExist: boolean = responseText6;
                if (bolIsExist == true) {


                    return responseText6;//一定要有一个返回值，否则会出错！
                }
                else {


                    //添加论文日志；
                    const responseText7 = await this.Addgs_OriginalPaperLogSave().then((jsonData) => {


                    });

                }

                //根据ID获取最大数；
                var strWhereCond2 = " 1 =1 and viewpointId=" + strViewpointId;
                var intCitationCount = await gs_PViewpointRela_GetRecCountByCondAsync(strWhereCond2);


                var objViewpointEN: clsViewpointEN = new clsViewpointEN();
                objViewpointEN.SetViewpointId(strViewpointId);
                objViewpointEN.SetCitationCount(intCitationCount);

                objViewpointEN.sfUpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }

                const responseText = await Viewpoint_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {

                        this.BindGv_vgs_PViewpointRela();
                    }
                    else {
                        var strInfo: string = `添加不成功!`;
                        alert(strInfo);
                        console.log("添加不成功");
                    }

                });



                HideDialogTwo();
                //显示信息框
                alert(strInfo);
                //绑定专家关系列表； 
                RefreshWindow();
                //this.BindGv_vRTExpegs_PViewpointRela();
                //主题Id
                // window.location.href = "../GraduateEdu/ResearchTopicAdd?TopicRelaId" + strPaperId;
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
        var strPaperLogTypeId = $('#hidPaperLogTypeId').val();//流程日志参数
        //通过区分 是小组讨论还是同伴建议
        var logTypeId = $('#hidCommentTypeId').val();
        pobjgs_OriginalPaperLogEN.SetPaperId(strPaperId);
        pobjgs_OriginalPaperLogEN.SetLogTypeId(strPaperLogTypeId);
        pobjgs_OriginalPaperLogEN.SetLogDescription( "添加子观点");
        // $('#PaperLogTypeId').val("03");
        //switch (strPaperLogTypeId) {
        //    case "01":
        //        pobjgs_OriginalPaperLogEN.SetLogDescription( "添加子观点";
        //        break;
        //    case "02":
        //        pobjgs_OriginalPaperLogEN.SetLogDescription( "同伴建议";
        //        break;

        //    default:
        //        var strMsg = `没有数据处理！`;
        //        alert(strMsg);
        //        break;
        //}
        //pobjgs_OriginalPaperLogEN.SetLogDescription( "新建论文";
        pobjgs_OriginalPaperLogEN.SetUpdUser(clsPublocalStorage.userId);
        pobjgs_OriginalPaperLogEN.SetUpdDate(clsPubFun4Web.getNowDate());
    }

    /* 函数功能:把界面上的属性数据传到类对象中
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
   <param name = "pobjgs_PViewpointRelaEN">数据传输的目的类对象</param>
 */
    public PutDataTogs_PViewpointRelaClass(pobjgs_PViewpointRelaEN: clsgs_PViewpointRelaEN) {

        var strPaperId = $("#hidPaperId").val();
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;

        pobjgs_PViewpointRelaEN.SetPaperId(strPaperId);// 主题编号
        pobjgs_PViewpointRelaEN.SetSectionId($("#ddlSectionId1").val());// 主题编号
        pobjgs_PViewpointRelaEN.SetViewpointId(strViewpointId);// 观点Id
        pobjgs_PViewpointRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjgs_PViewpointRelaEN.SetUpdUser(strUserId);// 修改用户Id// 修改用户Id
        //pobjgs_PViewpointRelaEN.SetMemo(this.memo;// 备注
    }
    //   /*
    //* 获取当前时间
    //*/
    //   public getNowDate(): string {
    //       const date = new Date();
    //       let strMonth: string | number = date.getMonth() + 1;
    //       let strDate: string | number = date.getDate();

    //       let strHours: string | number = date.getHours();
    //       let strMinutes: string | number = date.getMinutes();
    //       let strSeconds: string | number = date.getSeconds();


    //       if (strMonth <= 9) {
    //           strMonth = "0" + strMonth;
    //       }
    //       if (strDate <= 9) {
    //           strDate = "0" + strDate;
    //       }
    //       if (strHours <= 9) {
    //           strHours = "0" + strHours;
    //       }
    //       if (strMinutes <= 9) {
    //           strMinutes = "0" + strMinutes;
    //       }
    //       if (strSeconds <= 9) {
    //           strSeconds = "0" + strSeconds;
    //       }


    //       return date.getFullYear().toString() + "-" + strMonth + "-" + strDate + " " + strHours + ":" + strMinutes + ":" + strSeconds;
    //   }
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



    ////////////////////////////////////////////////////////////////////////////////////////////相关概念



    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
<returns>条件串(strWhereCond)</returns>
*/
    public Combinevgs_PConceptRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //var objvgs_PConceptRela_Cond: clsvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.topicName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PConceptRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
            //    objvgs_PConceptRela_Cond.SetCondFldValue(clsvgs_PConceptRelaEN.con_TopicName, this.topicName_q, "like");
            //}
            //if (this.conceptName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PConceptRelaEN.con_ConceptName} like '% ${this.conceptName_q}%'`;
            //    objvgs_PConceptRela_Cond.SetCondFldValue(clsvgs_PConceptRelaEN.con_ConceptName, this.conceptName_q, "like");
            //}
            //判断主题id
            var strPaperId = $("#hidPaperId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PConceptRelaEN.con_PaperId} = '${strPaperId}'`;
            }
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；



            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {

                // $("#btnDelRecord").show();

            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
                // $("#btnDelRecord").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //      strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //学生； 
                // $("#btnDelRecord").show();
                //   strWhereCond += ` And ${clsvgs_PConceptRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //学生00620003

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(Combinegs_PConcepRelaConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vgs_PConceptRela() {
        var strListDiv: string = this.mstrListConceptDivPaper;
        var strWhereCond = await this.Combinevgs_PConceptRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvgs_PConceptRelaObjLst: Array<clsvgs_PConceptRelaEN> = [];
        try {
            this.recCount = await vgs_PConceptRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_PConceptRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_PConceptRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_PConceptRelaObjLst = <Array<clsvgs_PConceptRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvgs_PConceptRelaObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {

            var strHtml = await Public_Concept.BindList_vgs_PConceptRela("06", arrvgs_PConceptRelaObjLst);
            //this.BindList_vgs_PConceptRela(arrvgs_PConceptRelaObjLst);
            //拼接；
            $("#divgs_PConceptRelaDataLst").html(strHtml);

            if (arrvgs_PConceptRelaObjLst.length > 10) {
                $("#divPagerConcept").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
           
            //this.BindTab_vgs_PConceptRela(strListDiv, arrvgs_PConceptRelaObjLst);
            console.log("完成BindGv_vgs_PConceptRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    //public BindList_vgs_PConceptRela(arrvgs_PConceptRelaObjLst: Array<clsvgs_PConceptRelaEN>) {
    //    var strhtml = "";
    //    var strUserId = clsPublocalStorage.userId;
    //    strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';

    //    strhtml += '<div style="float:left;"><a href="#" title="相关概念">相关概念</a></div>';
    //    //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';

    //    strhtml += '</div><ul class="artlist">';
    //    var v = 0;//给内容加个序号
    //    for (var i = 0; i < arrvgs_PConceptRelaObjLst.length; i++) {
    //        //得到viewpointId；
    //        var strConceptId = arrvgs_PConceptRelaObjLst[i].conceptId;
    //        v++;
    //        strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvgs_PConceptRelaObjLst[i].conceptName + '</span></li>';
    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrvgs_PConceptRelaObjLst[i].conceptContent + '</span></li>';

    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';

    //        if (arrvgs_PConceptRelaObjLst[i].appraiseCount != 0) {
    //            //评论
    //            strhtml += '&nbsp;&nbsp;评论数：' + arrvgs_PConceptRelaObjLst[i].appraiseCount;
    //        }
    //        if (arrvgs_PConceptRelaObjLst[i].score != 0) {
    //            //评分
    //            strhtml += '&nbsp;&nbsp;综合评分：' + arrvgs_PConceptRelaObjLst[i].score;
    //        }
    //        if (arrvgs_PConceptRelaObjLst[i].teaScore != 0) {
    //            strhtml += '&nbsp;&nbsp;教师评分：' + arrvgs_PConceptRelaObjLst[i].teaScore;
    //        }
    //        if (arrvgs_PConceptRelaObjLst[i].stuScore != 0) {
    //            strhtml += '&nbsp;&nbsp;学生评分：' + arrvgs_PConceptRelaObjLst[i].stuScore;
    //        }

    //        //引用数
    //        strhtml += '&nbsp;&nbsp;被引用数：' + arrvgs_PConceptRelaObjLst[i].citationCount;
    //        if (arrvgs_PConceptRelaObjLst[i].versionCount != 0) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvgs_PConceptRelaObjLst[i].versionCount;
    //        }

    //        if (arrvgs_PConceptRelaObjLst[i].isSubmit == true) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
    //        }
    //        else {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
    //        }

    //        strhtml += '</li>';
    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';

    //        if (arrvgs_PConceptRelaObjLst[i].concepUserId == arrvgs_PConceptRelaObjLst[i].updUser) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + arrvgs_PConceptRelaObjLst[i].ConcepUserName;
    //        } else {
    //            //strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvgs_PConceptRelaObjLst[i].ConcepUserName + '&nbsp;/&nbsp;' + arrvgs_PConceptRelaObjLst[i].userName;
    //            strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvgs_PConceptRelaObjLst[i].ConcepUserName + '&nbsp;/&nbsp;' + arrvgs_PConceptRelaObjLst[i].updUser;

    //        }
    //        if (arrvgs_PConceptRelaObjLst[i].concepDate == arrvgs_PConceptRelaObjLst[i].updDate) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvgs_PConceptRelaObjLst[i].concepDate;
    //        } else {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvgs_PConceptRelaObjLst[i].concepDate + '&nbsp;/&nbsp;' + arrvgs_PConceptRelaObjLst[i].updDate;
    //        }


    //        //strhtml += '&nbsp;&nbsp;编辑用户：' + arrvgs_PConceptRelaObjLst[i].userName;
    //        //strhtml += '&nbsp;&nbsp;编辑时间：' + arrvgs_PConceptRelaObjLst[i].updDate + '</span>';


    //        if (strUserId == arrvgs_PConceptRelaObjLst[i].updUser) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelConceptRecordInTab_Click(' + arrvgs_PConceptRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
    //        }
    //        if (arrvgs_PConceptRelaObjLst[i].isSubmit != true) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdConcept_Click("' + arrvgs_PConceptRelaObjLst[i].conceptId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
    //        }

    //        if (arrvgs_PConceptRelaObjLst[i].versionCount > 0 && arrvgs_PConceptRelaObjLst[i].versionCount != null) {
    //            strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('相关概念历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PConceptRelaObjLst[i].conceptId + "&Type=05')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
    //        }
    //        strhtml += '</li>';



    //        strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
    //    }
    //    strhtml += '</ul></div>';

    //    //拼接；
    //    $("#divgs_PConceptRelaDataLst").html(strhtml);

    //    if (arrvgs_PConceptRelaObjLst.length > 10) {
    //        $("#divPagerConcept").show();
    //        this.objPager.recCount = this.recCount;
    //        this.objPager.pageSize = this.pageSize;
    //        this.objPager.ShowPagerV2(this, this.divName4Pager);
    //    }
    //}


    /* 
在数据表里删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelConceptRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            //const responseText = await this.DelConceptRecord(lngKeyId).then((jsonData) => {
            //    ;
            //});
            var strUserId = clsPublocalStorage.userId;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = gs_PConcepRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRtConceptEN: clsgs_PConcepRelaEN = <clsgs_PConcepRelaEN>jsonData;
                if (objRtConceptEN != null) {
                    if (objRtConceptEN.updUser == strUserId) {
                        //
                        const responseText = this.DelConceptRecord(lngKeyId);
                    }
                    else {

                        //成员
                        var strMsg = `您只能删除自己添加的数据！`;
                        alert(strMsg);
                        return;
                    }
                }
            })

            //const responseText = await this.DelConceptRecord(lngKeyId);
            //const responseBindGv = await this.BindGv_vgs_PConceptRela();
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
    public DelConceptRecord(lngmId: number): Promise<number> {
        return new Promise((resolve, reject) => {
            try {
                const responseText = gs_PConcepRela_DelRecordAsync(lngmId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        this.BindGv_vgs_PConceptRela();
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
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvgs_PConceptRelaBy(value: string) {
        $("#hidSortvgs_PConceptRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_PConceptRelaBy(): string {
        return $("#hidSortvgs_PConceptRelaBy").val();
    }






    //////////////////////////////////////、、、、、、、、、、、、、、、、、客观事实关系




    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public Combinevgs_PTopicObjectiveRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.objectiveName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName} like '% ${this.objectiveName_q}%'`;
            //}
            //if (this.topicName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
            //}



            //判断主题id
            var strPaperId = $("#hidPaperId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_PaperId} = '${strPaperId}'`;
            }

            //查询客观事实
            strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType} = '01'`;

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；



            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {

                // $("#btnDelRecord").show();

            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
                // $("#btnDelRecord").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //学生； 
                // $("#btnDelRecord").show();
                // strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //学生00620003

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_PTopicObjectiveRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vgs_PTopicObjectiveRela() {
        var strListDiv: string = this.mstrListTopicObjectiveDivPaper;
        var strWhereCond = await this.Combinevgs_PTopicObjectiveRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvgs_PTopicObjectiveRelaObjLst: Array<clsvgs_PTopicObjectiveRelaEN> = [];
        try {
            this.recCount = await vgs_PTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_PTopicObjectiveRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_PTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_PTopicObjectiveRelaObjLst = <Array<clsvgs_PTopicObjectiveRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvgs_PTopicObjectiveRelaObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {


            this.BindList_vgs_PTopicObjectiveRela("01", arrvgs_PTopicObjectiveRelaObjLst);
            console.log("完成BindGv_vgs_PTopicObjectiveRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    public async BindList_vgs_PTopicObjectiveRela(strType: string, arrvgs_PTopicObjectiveRelaObjLst: Array<clsvgs_PTopicObjectiveRelaEN>) {
        //$("#hidPageType").val(strType);
        //var strPageType = strType;//页面参数
        //var strUserId = clsPublocalStorage.userId;
        //var strTitle = "";
        ////判断页面参数
        //if (strPageType == "04") {
        //    strTitle = "客观事实";
        //} else if (strPageType == "05") {
        //    //专家观点
        //    //$("#ListTitle").html("当前论文相关的专家观点");
        //    strTitle = "客观数据";
        //}
        //var strhtml = "";

        //strhtml += '<div class="info" id="infoFacts">';

        //strhtml += '<div class="title btn-5"><div style="float:left;"><a href="#" title="' + strTitle + '">' + strTitle + '</a></div></div>';
        ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';

        //strhtml += '<ul class="artlist">';
        //var v = 0;//给内容加个序号
        //for (var i = 0; i < arrvgs_PTopicObjectiveRelaObjLst.length; i++) {
        //    //得到viewpointId；
        //    var strTopicObjectiveId = arrvgs_PTopicObjectiveRelaObjLst[i].topicObjectiveId;
        //    v++;
        //    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
        //    strhtml += '<li><span class="rowtit color6">' + v + '.[标题]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst[i].objectiveName + '</span></li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[内容]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst[i].objectiveContent + '</span></li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color6">[推论]：</span><span class="abstract-text">' + arrvgs_PTopicObjectiveRelaObjLst[i].conclusion + '</span></li>';

        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';

        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].appraiseCount != 0) {
        //        //评论
        //        strhtml += '&nbsp;&nbsp;评论数：' + arrvgs_PTopicObjectiveRelaObjLst[i].appraiseCount;
        //    }
        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].score != 0) {
        //        //评分
        //        strhtml += '&nbsp;&nbsp;综合评分：' + arrvgs_PTopicObjectiveRelaObjLst[i].score;
        //    }
        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].teaScore != 0) {
        //        strhtml += '&nbsp;&nbsp;教师评分：' + arrvgs_PTopicObjectiveRelaObjLst[i].teaScore;
        //    }
        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].stuScore != 0) {
        //        strhtml += '&nbsp;&nbsp;学生评分：' + arrvgs_PTopicObjectiveRelaObjLst[i].stuScore;
        //    }
        //    //引用数
        //    strhtml += '&nbsp;&nbsp;被引用数：' + arrvgs_PTopicObjectiveRelaObjLst[i].citationCount;
        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].versionCount != 0) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvgs_PTopicObjectiveRelaObjLst[i].versionCount;
        //    }
        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].isSubmit == true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
        //    }
        //    else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
        //    }

        //    strhtml += '</li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';

        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].objUserId == arrvgs_PTopicObjectiveRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + arrvgs_PTopicObjectiveRelaObjLst[i].ObjUserName;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvgs_PTopicObjectiveRelaObjLst[i].ObjUserName + '&nbsp;/&nbsp;' + arrvgs_PTopicObjectiveRelaObjLst[i].updUser;
        //        //strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvgs_PTopicObjectiveRelaObjLst[i].ObjUserName + '&nbsp;/&nbsp;' + arrvgs_PTopicObjectiveRelaObjLst[i].userName;
        //    }
        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].objDate == arrvgs_PTopicObjectiveRelaObjLst[i].updDate) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvgs_PTopicObjectiveRelaObjLst[i].objDate;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvgs_PTopicObjectiveRelaObjLst[i].objDate + '&nbsp;/&nbsp;' + arrvgs_PTopicObjectiveRelaObjLst[i].updDate;
        //    }

        //    if (strUserId == arrvgs_PTopicObjectiveRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelObjectiveRecordInTab_Click(' + arrvgs_PTopicObjectiveRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除引用</button>';
        //    }
        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].isSubmit != true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdObjective_Click("' + arrvgs_PTopicObjectiveRelaObjLst[i].topicObjectiveId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
        //    }
        //    //strhtml += '&nbsp;&nbsp;<button style="float:right;" title="删除' + strTitle + '" class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelObjectiveRecordInTab_Click(' + arrvgs_PTopicObjectiveRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>删除' + strTitle + '</button>';
        //    if (arrvgs_PTopicObjectiveRelaObjLst[i].versionCount > 0 && arrvgs_PTopicObjectiveRelaObjLst[i].versionCount != null) {
        //        strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PTopicObjectiveRelaObjLst[i].topicObjectiveId + "&Type=06')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
        //    }

        //    strhtml += '</li>';
        //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //}
        //strhtml += '</ul></div>';

        $("#hidPageType").val(strType);
        var strPageType = strType;//页面参数
        var strHtml = await Public_TopicObjective.BindList_vgs_PTopicObjectiveRela("06", strPageType, arrvgs_PTopicObjectiveRelaObjLst);


        if (strPageType == "01") {
            $("#divRtTopicObjectiveDataLst").html(strHtml);

            if (arrvgs_PTopicObjectiveRelaObjLst.length > 10) {
                $("#divPagerObjective").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        } else if (strPageType == "02") {
            $("#divBasisRtTopicObjectiveDataLst").html(strHtml);

            if (arrvgs_PTopicObjectiveRelaObjLst.length > 10) {
                $("#divPagerBasis").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        //拼接；

    }

    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvgs_PTopicObjectiveRelaBy(value: string) {
        $("#hidSortvgs_PTopicObjectiveRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_PTopicObjectiveRelaBy(): string {
        return $("#hidSortvgs_PTopicObjectiveRelaBy").val();
    }

    /* 
在数据表里删除记录 删除客观事实
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelObjectiveRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            //var lngKeyId = Number(strKeyId);
            //const responseText = await this.DelConceptRecord(lngKeyId).then((jsonData) => {
            //    ;
            //});
            var lngKeyId = Number(strKeyId);
            var strUserId = clsPublocalStorage.userId;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = gs_PTopicObjectiveRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRTTopicObjectiveEN: clsgs_PTopicObjectiveRelaEN = <clsgs_PTopicObjectiveRelaEN>jsonData;
                if (objRTTopicObjectiveEN != null) {
                    if (objRTTopicObjectiveEN.updUser == strUserId) {
                        //01 客观事实

                        if ($("#hidPageType").val() == "01") {
                            const responseText = this.DelObjectiveRecord(lngKeyId, "01");
                        } else if ($("#hidPageType").val() == "02") {
                            const responseText = this.DelObjectiveRecord(lngKeyId, "02");
                        }
                        // const responseText2 = await this.BindGv_vRTPaperRela();
                    }
                    else {

                        //成员
                        var strMsg = `您只能删除自己添加的数据！`;
                        alert(strMsg);
                        return;
                    }
                }
            })

            ////删除客观事实
            //const responseText = await this.DelObjectiveRecord(lngKeyId);

            //const responseBindGv = await this.BindGv_vgs_PTopicObjectiveRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    //删除客观依据
    public async btnDelBasisObjectiveRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            //var lngKeyId = Number(strKeyId);
            //const responseText = await this.DelConceptRecord(lngKeyId).then((jsonData) => {
            //    ;
            //});
            var lngKeyId = Number(strKeyId);
            var strUserId = clsPublocalStorage.userId;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = gs_PTopicObjectiveRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRTTopicObjectiveBasisEN: clsgs_PTopicObjectiveRelaEN = <clsgs_PTopicObjectiveRelaEN>jsonData;
                if (objRTTopicObjectiveBasisEN != null) {
                    if (objRTTopicObjectiveBasisEN.updUser == strUserId) {
                        //01 客观依据
                        const responseText = this.DelObjectiveRecord(lngKeyId, "02");
                        // const responseText2 = await this.BindGv_vRTPaperRela();
                    }
                    else {

                        //成员
                        var strMsg = `您只能删除自己添加的数据！`;
                        alert(strMsg);
                        return;
                    }
                }
            })

            ////删除客观依据
            //const responseText = await this.DelObjectiveRecord(lngKeyId);

            //const responseBindGv = await this.BasisBindGv_vgs_PTopicObjectiveRela();
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
    public async DelObjectiveRecord(lngmId: number, TypeId: string) {
        try {
            const responseText = await gs_PTopicObjectiveRela_DelRecordAsync(lngmId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                if (TypeId == "01") {
                    //客观事实
                    this.BindGv_vgs_PTopicObjectiveRela();
                }
                else {
                    //客观依据
                    this.BasisBindGv_vgs_PTopicObjectiveRela();

                }
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
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }





    /////////////////////////////////////////////////////客观数据关系///////////////////////////////////////////////////


    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public BasisCombinevgs_PTopicObjectiveRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.objectiveName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName} like '% ${this.objectiveName_q}%'`;
            //}
            //if (this.topicName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
            //}

            //判断主题id
            var strPaperId = $("#hidPaperId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_PaperId} = '${strPaperId}'`;
            }
            //查询客观依据
            strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType} = '02'`;
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；



            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {

                // $("#btnDelRecord").show();

            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
                // $("#btnDelRecord").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //     strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //学生； 
                // $("#btnDelRecord").show();
                //      strWhereCond += ` And ${clsvgs_PTopicObjectiveRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //学生00620003

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_PTopicObjectiveRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /*  客观依据
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BasisBindGv_vgs_PTopicObjectiveRela() {
        var strListDiv: string = this.mstrListBasisTopicObjectiveDivPaper;
        var strWhereCond = this.BasisCombinevgs_PTopicObjectiveRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvgs_PTopicObjectiveRelaObjLst: Array<clsvgs_PTopicObjectiveRelaEN> = [];
        try {
            this.recCount = await vgs_PTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_PTopicObjectiveRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_PTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_PTopicObjectiveRelaObjLst = <Array<clsvgs_PTopicObjectiveRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvgs_PTopicObjectiveRelaObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindList_vgs_PTopicObjectiveRela("02", arrvgs_PTopicObjectiveRelaObjLst);
            console.log("完成BindGv_vgs_PTopicObjectiveRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
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
    public set hidSortvgs_PViewpointRelaBy(value: string) {
        $("#hidSortvgs_PViewpointRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_PViewpointRelaBy(): string {
        return $("#hidSortvgs_PViewpointRelaBy").val();
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


    //public get CurrPagePaper(): number {
    //    return $("#hidCurrPagePaper").val();
    //}
    //public set CurrPagePaper(value: number) {
    //    $("#hidCurrPagePaper").val(value);
    //}

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

    /*主题个人观点关系
   */
    public async SortByRTViewpoint(strSortByFld: string) {
        if (this.hidSortvgs_PViewpointRelaBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvgs_PViewpointRelaBy.indexOf("Asc") >= 0) {
                this.hidSortvgs_PViewpointRelaBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvgs_PViewpointRelaBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvgs_PViewpointRelaBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vgs_PViewpointRela();
    }

    /*主题专家关系
  */
    public async SortByRTExpertViewpoint(strSortByFld: string) {
        if (this.hidSortvgs_PViewpointRelaBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvgs_PViewpointRelaBy.indexOf("Asc") >= 0) {
                this.hidSortvgs_PViewpointRelaBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvgs_PViewpointRelaBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvgs_PViewpointRelaBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vRTExpegs_PViewpointRela();
    }

    /*主题概念关系
    */
    public async SortByRTConcept(strSortByFld: string) {
        if (this.hidSortvgs_PConceptRelaBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvgs_PConceptRelaBy.indexOf("Asc") >= 0) {
                this.hidSortvgs_PConceptRelaBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvgs_PConceptRelaBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvgs_PConceptRelaBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vgs_PConceptRela();
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




    //--------------------------------------------------------------------------tab页切换事件

    //个人观点
    public async liViewpointClick() {
        try {
            //var strNum = "3";
            //$("#hidTabNum").val(strNum);
            var strPaperId = $("#hidPaperId").val();
            const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId1", strPaperId);
            const gvResultPaper = await this.BindGv_vgs_PViewpointRela();
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
            //var strNum = "4";
            //$("#hidTabNum").val(strNum);
            var strPaperId = $("#hidPaperId").val();
            const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId1", strPaperId);
            const gvResultPaper = await this.BindGv_vRTExpegs_PViewpointRela();
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

            //var strNum = "5";
            //$("#hidTabNum").val(strNum);
            var strPaperId = $("#hidPaperId").val();
            const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId2", strPaperId);
            const gvResultPaper = await this.BindGv_vgs_PConceptRela();
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
            //var strNum = "6";
            //$("#hidTabNum").val(strNum);
            var strPaperId = $("#hidPaperId").val();
            const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId3", strPaperId);
            const gvResultPaper = await this.BindGv_vgs_PTopicObjectiveRela();
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
            //var strNum = "7";
            //$("#hidTabNum").val(strNum);
            var strPaperId = $("#hidPaperId").val();
            const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId3", strPaperId);
            const gvResultPaper = await this.BasisBindGv_vgs_PTopicObjectiveRela();
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
            //var strNum = "7";
            //$("#hidTabNum").val(strNum);
            var strPaperId = $("#hidPaperId").val();
            const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId4", strPaperId);
            const gvResultPaper = await this.BindGv_vgs_PSkillRela();
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
            //var strNum = "7";
            //$("#hidTabNum").val(strNum);
            var strPaperId = $("#hidPaperId").val();
            const ddl_SectionId = await this.BindDdl_SectionId("ddlSectionId5", strPaperId);
            const gvResultPaper = await this.BindGv_vgs_PSocialRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取客观依据列表不成功,${e}.`;
            alert(strMsg);
        }
    }



    //--------------------------------=================================================================--技能
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
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public Combinevgs_PSkillRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.skillName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PSkillRelaEN.con_SkillName} like '% ${this.skillName_q}%'`;
            //}
            //if (this.operationTypeId_q != "" && this.operationTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvgs_PSkillRelaEN.con_OperationTypeId} = '${this.operationTypeId_q}'`;
            //}
            //判断主题id
            var strPaperId = $("#hidPaperId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PSkillRelaEN.con_PaperId} = '${strPaperId}'`;
            }

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；

            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {

            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
            }
            else {
                //学生； 
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_PSkillRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vgs_PSkillRela() {
        var strListDiv: string = this.mstrListSysskillDivPaper;//显示div
        var strWhereCond = await this.Combinevgs_PSkillRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvgs_PSkillRelaObjLst: Array<clsvgs_PSkillRelaEN> = [];
        //var arrvUsersObjLst: Array<clsvUsersSimEN> = [];
        try {
            this.recCount = await vgs_PSkillRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_PSkillRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_PSkillRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_PSkillRelaObjLst = <Array<clsvgs_PSkillRelaEN>>jsonData;
            });

            //var strWhereUserRel = "1=1";


            //    arrvUsersObjLst = <Array<clsUsersEN>>jsonData;
            //});
            //arrvUsersObjLst = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvgs_PSkillRelaObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            var strHtml = await Public_SysSkill.BindList_vgs_PSkillRela("06", arrvgs_PSkillRelaObjLst);
            //拼接；
            $("#divSysskillDataLst").html(strHtml);

            if (arrvgs_PSkillRelaObjLst.length > 10) {
                $("#divPagerSysskill").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            //this.BindTab_vgs_PSkillRela(arrvgs_PSkillRelaObjLst, arrvUsersObjLst);
            console.log("完成BindGv_vgs_PSkillRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vgs_PSkillRela对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrgs_PSkillRelaObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vgs_PSkillRela(arrvgs_PSkillRelaObjLst: Array<clsvgs_PSkillRelaEN>, arrvUsersObjLst: Array<clsvUsersSimEN>) {



        var strhtml = "";
        var strUserId = clsPublocalStorage.userId;
        strhtml += '<div class="info" id="infoSysskill"><div class="title btn-4">';

        strhtml += '<div style="float:left;"><a href="#" title="相关技能">相关技能</a></div>';
      
        strhtml += '</div><ul class="artlist">';
        var v = 0;//给内容加个序号
        for (var i = 0; i < arrvgs_PSkillRelaObjLst.length; i++) {
            //得到viewpointId；
            var strConceptId = arrvgs_PSkillRelaObjLst[i].skillId;
            v++;
            strhtml += '<li><span class="rowtit color4">' + v + '.[技能名称]：</span><span class="abstract-text">' + arrvgs_PSkillRelaObjLst[i].skillName + '</span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[实施过程]：</span><span class="abstract-text">' + arrvgs_PSkillRelaObjLst[i].process + '</span></li>';

            //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';

            //if (arrvgs_PSkillRelaObjLst[i].appraiseCount != 0) {
            //    //评论
            //    strhtml += '&nbsp;&nbsp;评论数：' + arrvgs_PSkillRelaObjLst[i].appraiseCount;
            //}
            //if (arrvgs_PSkillRelaObjLst[i].score != 0) {
            //    //评分
            //    strhtml += '&nbsp;&nbsp;综合评分：' + arrvgs_PSkillRelaObjLst[i].score;
            //}
            //if (arrvgs_PSkillRelaObjLst[i].teaScore != 0) {
            //    strhtml += '&nbsp;&nbsp;教师评分：' + arrvgs_PSkillRelaObjLst[i].teaScore;
            //}
            //if (arrvgs_PSkillRelaObjLst[i].stuScore != 0) {
            //    strhtml += '&nbsp;&nbsp;学生评分：' + arrvgs_PSkillRelaObjLst[i].stuScore;
            //}




            ////引用数
            //strhtml += '&nbsp;&nbsp;被引用数：' + arrvgs_PSkillRelaObjLst[i].citationCount;
            //if (arrvgs_PSkillRelaObjLst[i].versionCount != 0) {
            //    strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvgs_PSkillRelaObjLst[i].versionCount;
            //}
            ////通过用户ID得到用户名；

            ////strhtml += '&nbsp;&nbsp;编辑用户：' + arrvgs_PSkillRelaObjLst[i].userName;
            //strhtml += '&nbsp;&nbsp;编辑时间：' + arrvgs_PSkillRelaObjLst[i].updDate + '</span>';

            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
            if (arrvgs_PSkillRelaObjLst[i].okCount != 0) {
                strhtml += '点赞数：' + arrvgs_PSkillRelaObjLst[i].okCount + '&nbsp;&nbsp';
            }
            if (arrvgs_PSkillRelaObjLst[i].appraiseCount != 0) {
                //评论
                strhtml += '&nbsp;&nbsp;评论数：' + arrvgs_PSkillRelaObjLst[i].appraiseCount;
            }
            if (arrvgs_PSkillRelaObjLst[i].score != 0) {
                //评分
                strhtml += '&nbsp;&nbsp;综合评分：' + arrvgs_PSkillRelaObjLst[i].score;
            }
            if (arrvgs_PSkillRelaObjLst[i].teaScore != 0) {
                strhtml += '&nbsp;&nbsp;教师评分：' + arrvgs_PSkillRelaObjLst[i].teaScore;
            }
            if (arrvgs_PSkillRelaObjLst[i].stuScore != 0) {
                strhtml += '&nbsp;&nbsp;学生评分：' + arrvgs_PSkillRelaObjLst[i].stuScore;
            }
            //引用数
            strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvgs_PSkillRelaObjLst[i].citationCount;

            if (arrvgs_PSkillRelaObjLst[i].versionCount != 0) {
                strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvgs_PSkillRelaObjLst[i].versionCount;
            }
            if (arrvgs_PSkillRelaObjLst[i].isSubmit == true) {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
            }
            else {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
            }

            strhtml += '</li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';


            //获取引用人；编辑人、用户名称

            var arrvUsers: Array<clsvUsersSimEN> = [];
            var UpdUserName;//编辑人
            var CacitionUserName;//引用人
            //获取技能引用人；
            arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvgs_PSkillRelaObjLst[i].updUser);//技能引用人
            for (var j = 0; j < arrvUsers.length; j++) {
                CacitionUserName = arrvUsers[j].userName;
                break;
            }
            //获取技能编辑人；
            arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvgs_PSkillRelaObjLst[i].skillUserId);//技能编辑人
            for (var j = 0; j < arrvUsers.length; j++) {
                UpdUserName = arrvUsers[j].userName;
                break;
            }


            //for (var j = 0; j < arrUsers.length; j++) {
            //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrUsers[j].userName + '</span>';
            //    break;
            //}



            if (arrvgs_PSkillRelaObjLst[i].skillUserId == arrvgs_PSkillRelaObjLst[i].updUser) {
                strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + UpdUserName;
            } else {
                strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
            }
            if (arrvgs_PSkillRelaObjLst[i].skillDate == arrvgs_PSkillRelaObjLst[i].updDate) {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvgs_PSkillRelaObjLst[i].skillDate;
            } else {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvgs_PSkillRelaObjLst[i].skillDate + '&nbsp;/&nbsp;' + arrvgs_PSkillRelaObjLst[i].updDate;
            }





            if (strUserId == arrvgs_PSkillRelaObjLst[i].updUser) {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelSysskillRecordInTab_Click(' + arrvgs_PSkillRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
            }
            if (arrvgs_PSkillRelaObjLst[i].isSubmit != true) {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdSysskill_Click("' + arrvgs_PSkillRelaObjLst[i].skillId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
            }

            //strhtml += '&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除相关引用" class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelSysskillRecordInTab_Click(' + arrvgs_PSkillRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除相关引用</button>';

            if (arrvgs_PSkillRelaObjLst[i].versionCount > 0 && arrvgs_PSkillRelaObjLst[i].versionCount != null) {
                strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('相关技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PSkillRelaObjLst[i].skillId + "&Type=06')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            }
            strhtml += '</li>';



            strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        }
        strhtml += '</ul></div>';

        //拼接；
        $("#divSysskillDataLst").html(strhtml);

        if (arrvgs_PSkillRelaObjLst.length > 10) {
            $("#divPagerSysskill").show();
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }

    }


    /* 
在数据表里删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelSysskillRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.Delgs_PSkillRelaRecord(lngKeyId);
            const responseBindGv = await this.BindGv_vgs_PSkillRela();
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
    public async Delgs_PSkillRelaRecord(lngmId: number) {
        try {
            const responseText = await gs_PSkillRela_DelRecordAsync(lngmId);
            var returnInt: number = responseText;
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
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
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
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public Combinevgs_PSocialRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.skillName_q != "") {
            //    strWhereCond += ` And ${clsvgs_PSkillRelaEN.con_SkillName} like '% ${this.skillName_q}%'`;
            //}
            //if (this.operationTypeId_q != "" && this.operationTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvgs_PSkillRelaEN.con_OperationTypeId} = '${this.operationTypeId_q}'`;
            //}
            //判断主题id
            var strPaperId = $("#hidPaperId").val();
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PSocialRelaEN.con_PaperId} = '${strPaperId}'`;
            }

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；

            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {

            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
            }
            else {
                //学生； 
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_PSocialRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vgs_PSocialRela() {
        var strListDiv: string = this.mstrListSysSocialRelaDivPaper;
        var strWhereCond = await this.Combinevgs_PSocialRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvgs_PSocialRelaObjLst: Array<clsvgs_PSocialRelaEN> = [];
        //var arrvUsersObjLst: Array<clsvUsersSimEN> = [];
        try {
            this.recCount = await vgs_PSocialRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_PSocialRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_PSocialRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_PSocialRelaObjLst = <Array<clsvgs_PSocialRelaEN>>jsonData;
            });

            //arrvUsersObjLst = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvgs_PSocialRelaObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            var strHtml = await Public_SysSocialRelations.BindList_vgs_PSocialRela("06", arrvgs_PSocialRelaObjLst);
            //拼接；divSysSocialRelaDataLst
            $("#divSysSocialRelaDataLst").html(strHtml);

            if (arrvgs_PSocialRelaObjLst.length > 10) {
                // $("#divSysSocialRelationsDataLst").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            //this.BindTab_vgs_PSocialRela(arrvgs_PSocialRelaObjLst, arrvUsersObjLst);
            console.log("完成BindGv_vgs_PSocialRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    //public async BindTab_vgs_PSocialRela(arrvgs_PSocialRelaObjLst: Array<clsvgs_PSocialRelaEN>, arrvUsersObjLst: Array<clsvUsersSimEN>) {
    //    var strhtml = "";
    //    var strUserId = clsPublocalStorage.userId;//获取当前登录ID 
    //    strhtml += '<div class="info" id="infoSysSocialRela"><div class="title btn-4">';

    //    strhtml += '<div style="float:left;"><a href="#" title="相关社会关系">相关社会关系</a></div>';

    //    strhtml += '</div><ul class="artlist">';
    //    var v = 0;//给内容加个序号
    //    for (var i = 0; i < arrvgs_PSocialRelaObjLst.length; i++) {
    //        //得到socialId；
    //        var strSocialId = arrvgs_PSocialRelaObjLst[i].socialId;
    //        v++;
    //        strhtml += '<li><span class="rowtit color4">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].fullName + '</span>';
    //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[国籍]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].nationality + '</span>';
    //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[工作单位]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].workUnit + '</span>';
    //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[专业]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].major + '</span></li>';

    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[成就]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].achievement + '</span></li>';
    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[详细说明]：</span><span class="abstract-text">' + arrvgs_PSocialRelaObjLst[i].detailedDescription + '</span></li>';

    //        //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';

    //        //if (arrvgs_PSocialRelaObjLst[i].appraiseCount != 0) {
    //        //    //评论
    //        //    strhtml += '&nbsp;&nbsp;评论数：' + arrvgs_PSocialRelaObjLst[i].appraiseCount;
    //        //}
    //        //if (arrvgs_PSocialRelaObjLst[i].score != 0) {
    //        //    //评分
    //        //    strhtml += '&nbsp;&nbsp;综合评分：' + arrvgs_PSocialRelaObjLst[i].score;
    //        //}
    //        //if (arrvgs_PSocialRelaObjLst[i].teaScore != 0) {
    //        //    strhtml += '&nbsp;&nbsp;教师评分：' + arrvgs_PSocialRelaObjLst[i].teaScore;
    //        //}
    //        //if (arrvgs_PSocialRelaObjLst[i].stuScore != 0) {
    //        //    strhtml += '&nbsp;&nbsp;学生评分：' + arrvgs_PSocialRelaObjLst[i].stuScore;
    //        //}

    //        ////引用数
    //        //strhtml += '&nbsp;&nbsp;被引用数：' + arrvgs_PSocialRelaObjLst[i].citationCount;
    //        //if (arrvgs_PSocialRelaObjLst[i].versionCount != 0) {
    //        //    strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvgs_PSocialRelaObjLst[i].versionCount;
    //        //}
    //        ////通过用户ID得到用户名；

    //        ////strhtml += '&nbsp;&nbsp;编辑用户：' + arrvgs_PSkillRelaObjLst[i].userName;
    //        //strhtml += '&nbsp;&nbsp;编辑时间：' + arrvgs_PSocialRelaObjLst[i].updDate + '</span>';

    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
    //        if (arrvgs_PSocialRelaObjLst[i].okCount != 0) {
    //            strhtml += '点赞数：' + arrvgs_PSocialRelaObjLst[i].okCount + '&nbsp;&nbsp';
    //        }
    //        if (arrvgs_PSocialRelaObjLst[i].appraiseCount != 0) {
    //            //评论
    //            strhtml += '&nbsp;&nbsp;评论数：' + arrvgs_PSocialRelaObjLst[i].appraiseCount;
    //        }
    //        if (arrvgs_PSocialRelaObjLst[i].score != 0) {
    //            //评分
    //            strhtml += '&nbsp;&nbsp;综合评分：' + arrvgs_PSocialRelaObjLst[i].score;
    //        }
    //        if (arrvgs_PSocialRelaObjLst[i].teaScore != 0) {
    //            strhtml += '&nbsp;&nbsp;教师评分：' + arrvgs_PSocialRelaObjLst[i].teaScore;
    //        }
    //        if (arrvgs_PSocialRelaObjLst[i].stuScore != 0) {
    //            strhtml += '&nbsp;&nbsp;学生评分：' + arrvgs_PSocialRelaObjLst[i].stuScore;
    //        }
    //        //引用数
    //        strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvgs_PSocialRelaObjLst[i].citationCount;

    //        if (arrvgs_PSocialRelaObjLst[i].versionCount != 0) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvgs_PSocialRelaObjLst[i].versionCount;
    //        }
    //        if (arrvgs_PSocialRelaObjLst[i].isSubmit == true) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
    //        }
    //        else {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
    //        }

    //        strhtml += '</li>';
    //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';


    //        //获取引用人；编辑人、用户名称

    //        var arrvUsers: Array<clsvUsersSimEN> = [];
    //        var UpdUserName;//编辑人
    //        var CacitionUserName;//引用人
    //        //获取技能引用人；
    //        arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvgs_PSocialRelaObjLst[i].updUser);//技能引用人
    //        for (var j = 0; j < arrvUsers.length; j++) {
    //            CacitionUserName = arrvUsers[j].userName;
    //            break;
    //        }
    //        //获取技能编辑人；
    //        arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvgs_PSocialRelaObjLst[i].socialUserId);//技能编辑人
    //        for (var j = 0; j < arrvUsers.length; j++) {
    //            UpdUserName = arrvUsers[j].userName;
    //            break;
    //        }


    //        //for (var j = 0; j < arrUsers.length; j++) {
    //        //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrUsers[j].userName + '</span>';
    //        //    break;
    //        //}



    //        if (arrvgs_PSocialRelaObjLst[i].socialUserId == arrvgs_PSocialRelaObjLst[i].updUser) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + UpdUserName;
    //        } else {
    //            strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
    //        }
    //        if (arrvgs_PSocialRelaObjLst[i].socialDate == arrvgs_PSocialRelaObjLst[i].updDate) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvgs_PSocialRelaObjLst[i].socialDate;
    //        } else {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvgs_PSocialRelaObjLst[i].socialDate + '&nbsp;/&nbsp;' + arrvgs_PSocialRelaObjLst[i].updDate;
    //        }


    //        if (strUserId == arrvgs_PSocialRelaObjLst[i].updUser) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelgs_PSocialRelaRecordInTab_Click(' + arrvgs_PSocialRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
    //        }
    //        if (arrvgs_PSocialRelaObjLst[i].isSubmit != true) {
    //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdSyssocial_Click("' + arrvgs_PSocialRelaObjLst[i].socialId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
    //        }


    //        //strhtml += '&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除相关引用" class="layui-btn-danger layui-btn layui-btn-xs" onclick="btnDelgs_PSocialRelaRecordInTab_Click(' + arrvgs_PSocialRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除相关引用</button>';
    //        if (arrvgs_PSocialRelaObjLst[i].versionCount > 0 && arrvgs_PSocialRelaObjLst[i].versionCount != null) {
    //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('相关技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvgs_PSocialRelaObjLst[i].socialId + "&Type=09')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
    //        }
    //        strhtml += '</li>';



    //        strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
    //    }
    //    strhtml += '</ul></div>';

    //    //拼接；divSysSocialRelaDataLst
    //    $("#divSysSocialRelaDataLst").html(strhtml);

    //    if (arrvgs_PSocialRelaObjLst.length > 10) {
    //        // $("#divSysSocialRelationsDataLst").show();
    //        this.objPager.recCount = this.recCount;
    //        this.objPager.pageSize = this.pageSize;
    //        this.objPager.ShowPagerV2(this, this.divName4Pager);
    //    }
    //}

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
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.Delgs_PSocialRelaRecord(lngKeyId);
            const responseBindGv = await this.BindGv_vgs_PSocialRela();
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
    public async Delgs_PSocialRelaRecord(lngmId: number) {
        try {
            const responseText = await gs_PSocialRela_DelRecordAsync(lngmId);
            var returnInt: number = responseText;
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
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
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


