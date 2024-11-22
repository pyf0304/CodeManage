///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { PaperSubViewpointCRUD } from "../PagesBase/GraduateEduPaper/PaperSubViewpointCRUD.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../TS/L0_Entity/GraduateEduPaper/clsPaperENEx.js";
import { clsvPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js";
import { clsvPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsvConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { Paper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaperReadWrite_GetObjLstByPagerAsync, vPaperReadWrite_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { vPaperSubViewpoint_GetObjLstByPagerAsync, vPaperSubViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { vConcept_GetObjLstByPager_Cache, vConcept_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { vSysSkill_GetObjLstByPagerAsync, vSysSkill_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { vSysSocialRelations_GetObjLstByPagerAsync, vSysSocialRelations_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vTopicObjective_GetObjLstByPagerAsync, vTopicObjective_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { vViewpoint_GetObjLstByPagerAsync, vViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { PaperEx_GetObjExLstByPagerAsync } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PersonalKnowledgeViewEx extends PaperSubViewpointCRUD {
    //观点列表
    public mstrListDivViewpoint: string = "divViewpointDataLst";

    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";

    //用户列表
    public mstrListDivUser: string = "divUserDataLst";

    //研究计划

    public mstrListDivResearchPlan: string = "divResearchPlanDataLst";
    //布置任务
    public mstrListDivgs_TeacherTask: string = "divgs_TeacherTaskDataLst";

    //主题用户关系
    public mstrListDivRtUserRela: string = "divRtUserRelaDataLst";

    //个人观点关系
    public mstrListDivRtViewPointRela: string = "divRtViewPointRelaDataLst";
    //专家观点
    public mstrListDivRtExpertViewPointRela: string = "divRtExpertViewPointRelaDataLst";

    //主题引用论文关系
    //public mstrListDivRtPaperRela: string = "divRtPaperRelaDataLst";
    public mstrListDivRtCitedPaperRela: string = "divRtCitedPaperRelaDataLst";


    //主题自研论文关系
    public mstrListDivRtOriginalPaperRela: string = "divRtOriginalPaperRelaDataLst";

    //概念
    public mstrListConceptDivPaper: string = "divRtConceptRelaDataLst";
    //客观事实
    public mstrListTopicObjectiveDivPaper: string = "divRtTopicObjectiveDataLst";
    //客观依据

    public mstrListBasisTopicObjectiveDivPaper: string = "divBasisRtTopicObjectiveDataLst";
    //研究结果
    public mstrListResearchResultDivPaper: string = "divRtResearchResultDataLst";

    //技能
    public mstrListSysskillDivPaper: string = "divSysskillDataLst";

    //社会关系
    public mstrListSysSocialRelaDivPaper: string = "divRtSysSocialRelaLst";


    public strBr: string = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    public recCount = 0;

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPublocalStorage.userId != "") {

               
                this.hidSortBy = "updDate Desc";
               
       
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；


                $("#hidUserId").val(clsPublocalStorage.userId);
                $("#hidRoleId").val(clsPublocalStorage.roleId);
                $("#hidId_CurrEduCls").val(clsPublocalStorage.id_CurrEduCls);

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
                const gvResult = await this.GetAllFunctionMethod();
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
    //得到3个关系列表数据；
    public async GetAllFunctionMethod() {

        //如果是点击了树菜单、或者是刷新，那么需要做样式控制；
        //首先要去掉ul下 li a 样式
        $("#myTab li a").removeClass();
        $("#myTab li").removeClass();
        //判断根据序号显示不同的数据源
        var strnum = $("#hidTabNum").val();
        if (strnum == "1") {
            $("#liPaper").addClass("active");
            $("#liPaper a").addClass("active");
            $("#li_Paper ").addClass("in active show");
            //论文
            this.BindGv_vPaper();
        }
        else if (strnum == "2") {
            $("#liPaperReadWrite").addClass("active");
            $("#liPaperReadWrite a").addClass("active");

            $("#li_PaperReadWrite ").addClass("in active show");
            //论文读写
            this.BindGv_vPaperReadWrite();
        }
        else if (strnum == "3") {
            $("#liPaperSubViewpoint").addClass("active");
            $("#liPaperSubViewpoint a").addClass("active");

            $("#li_PaperSubViewpoint ").addClass("in active show");
            //论文子观点
            this.BindGv_vPaperSubViewpoint();
        }
        else if (strnum == "4") {
            $("#liViewpoint").addClass("active");
            $("#liViewpoint a").addClass("active");

            $("#li_Viewpoint ").addClass("in active show");

            //个人观点关系；
            this.BindGv_vViewpoint();
        }
        else if (strnum == "5") {
            $("#liExpertViewpoint").addClass("active");
            $("#liExpertViewpoint a").addClass("active");

            $("#li_ExpertViewpoint ").addClass("in active show");
            //专家观点
            this.BindGv_vExpertViewpoint();
        }
        else if (strnum == "6") {
            $("#liConcept").addClass("active");
            $("#liConcept a").addClass("active");

            $("#li_Concept ").addClass("in active show");
            //主题概念关系
            this.BindGv_Concept_Cache();
        }
        else if (strnum == "7") {
            $("#liObjectiveFact").addClass("active");
            $("#liObjectiveFact a").addClass("active");

            $("#li_Objective ").addClass("in active show");
            //客观事实关系
            this.BindGv_vTopicObjective();
        }
        else if (strnum == "8") {
            $("#liObjectiveBasis").addClass("active");
            $("#liObjectiveBasis a").addClass("active");


            $("#li_ObjectiveBasis ").addClass("in active show");
            //客观依据关系
            this.BindGv_vTopicObjectiveBasis();
        }
      
        else if (strnum == "9") {
            $("#liSysskill").addClass("active");
            $("#liSysskill a").addClass("active");


            $("#liSysskill ").addClass("in active show");
            //技能
            this.BindGv_vSysSkill();
        }
        else if (strnum == "10") {
            $("#liSysSocialRela").addClass("active");
            $("#liSysSocialRela a").addClass("active");


            $("#liSysSocialRela ").addClass("in active show");
            //社会关系
            this.BindGv_vSysSocialRelations();
        }
      
        else {
            $("#liPaper").addClass("active");
            $("#liPaper a").addClass("active");
            $("#li_Paper ").addClass("in active show");
            //论文
            this.BindGv_vPaper();
        }

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
        //this.setCurrPageIndex(intPageIndex, this.divName4Pager);
          this.SetCurrPageIndex(intPageIndex);
        //判断根据序号显示不同的数据源
        var strnum = $("#hidTabNum").val();
        if (strnum == "1") {
            //论文
            this.BindGv_vPaper();
        }
        else if (strnum == "2") {
            //论文读写
            this.BindGv_vPaperReadWrite();
        }
        else if (strnum == "3") {
            //论文子观点
            this.BindGv_vPaperSubViewpoint();
        }
        else if (strnum == "4") {

            //个人观点关系；
            this.BindGv_vViewpoint();
        }
        else if (strnum == "5") {
            //专家观点
            this.BindGv_vExpertViewpoint();
        }
        else if (strnum == "6") {
            //主题概念关系
            this.BindGv_Concept_Cache();
        }
        else if (strnum == "7") {
            //客观事实关系
            this.BindGv_vTopicObjective();
        }
        else if (strnum == "8") {
            //客观依据关系
            this.BindGv_vTopicObjectiveBasis();
        }
        else if (strnum == "9") {
            //技能
            this.BindGv_vSysSkill();
        }
        else if (strnum == "10") {
            //社会关系
            this.BindGv_vSysSocialRelations();
        }
        else {
            //论文
            this.BindGv_vPaper();
        }
    }



    //论文
    public async liPaperClick() {
        try {
        
            const gvResultPaper = await this.BindGv_vPaper();
           
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //论文读写
    public async liPaperReadWriteClick() {
        try {

            const gvResultPaper = await this.BindGv_vPaperReadWrite();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //论文子观点
    public async liPaperSubViewpointClick() {
        try {

            const gvResultPaper = await this.BindGv_vPaperSubViewpoint();
            if (this.recCount > 10) {
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //个人观点
    public async liViewpointClick() {
        try {

            const gvResultPaper = await this.BindGv_vViewpoint();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //专家观点
    public async liExpertViewpointClick() {
        try {

            const gvResultPaper = await this.BindGv_vExpertViewpoint();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //概念
    public async liConceptClick() {
        try {

            const gvResultPaper = await this.BindGv_Concept_Cache();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //客观事实
    public async liObjectiveFactClick() {
        try {

            const gvResultPaper = await this.BindGv_vTopicObjective();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    
    //客观数据
    public async liObjectiveBasisClick() {
        try {

            const gvResultPaper = await this.BindGv_vTopicObjectiveBasis();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }
   //技能
    public async liSysskillClick() {
        try {

            const gvResultPaper = await this.BindGv_vSysSkill();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //社会关系
    public async liSysSocialRelationsClick() {
        try {

            const gvResultPaper = await this.BindGv_vSysSocialRelations();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevPaperCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
                if (clsPublocalStorage.userId != "") {
                    //判断角色//管理员
                    var strUserId = clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage.roleId;
                    if (strRoleId == "00620001") {
                    }
                    else if (strRoleId == "00620002") {
                    }
                    else {
                        //学生00620003
                        strWhereCond += ` And updUser = '${strUserId}'`;
                    }
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
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
       // var strListDiv: string = this.mstrListDiv;
        var strWhereCond = await this.CombinevPaperCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrPaperExObjLst: Array<clsPaperENEx> = [];
        try {
            this.recCount = await Paper_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }
            };
            const arrPaperExObjLst = await PaperEx_GetObjExLstByPagerAsync(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        try {
            const response = await this.BindTab_vPaper(arrPaperExObjLst);

            if (this.recCount > 10) {
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            console.log("完成BindGv_vPaper!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    public async BindTab_vPaper(arrPaperExObjLst: Array<clsPaperENEx>) {
       
      
        var strhtml: string = '';
        strhtml += '<div class="info" id="infoPaper"><div class="title btn-3"><ul class="artlist">';
        var p = 0;//给内容加个序号
        for (var i = 0; i < arrPaperExObjLst.length; i++) {

            p++;
        //    var strPaperId = arrPaperExObjLst[i].paperId;
            //判断引用论文，自研论文
            if (arrPaperExObjLst[i].paperTypeId == "02") {
                strhtml += '<li><span class="rowtit color3">' + p + '.[标题]：</span><span class="abstract-text">' + arrPaperExObjLst[i].paperTitle + '(' + arrPaperExObjLst[i].paperTypeName + ')</span></li>';
            }
            else {
                strhtml += '<li><span class="rowtit color3">' + p + '.[标题]：</span><span class="abstract-text">' + arrPaperExObjLst[i].paperTitle + '(' + arrPaperExObjLst[i].paperTypeName + ')</span></li>';
            }
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[研究问题]：</span><span class="abstract-text">' + arrPaperExObjLst[i].researchQuestion + '</span><span class="rowtit color3">[关键字]：</span><span class="abstract-text">' + arrPaperExObjLst[i].keyword + '</span></li>';

        }
        strhtml += '</ul></div>';

        $("#divRtCitedPaperRelaDataLst").html(strhtml);
        
       
    }



    //////--------------------------------------论文读写

    /* 把所有的查询控件内容组合成一个条件串
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
   <returns>条件串(strWhereCond)</returns>
 */
    public async CombinevPaperReadWriteCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //// 02 代表论文写作

                var strUserId = clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage.roleId;

                if (strRoleId == "00620001") {
                }
                //判断角色 //学生00620003
                else if (strRoleId == "00620002") {
                }
                else {
                    //只能查看自己的数据；或公开的数据；学生
                    strWhereCond += ` And updUser = '${strUserId}'`;

                }
        
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vPaperReadWrite() {
        //var strListDiv: string = this.mstrListDiv;
        var strWhereCond = await this.CombinevPaperReadWriteCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvPaperReadWriteObjLst: Array<clsvPaperReadWriteEN> = [];
        try {
            this.recCount = await vPaperReadWrite_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaperReadWrite_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperReadWriteObjLst = <Array<clsvPaperReadWriteEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        try {

            this.BindTab_vPaperReadWrite(arrvPaperReadWriteObjLst);
            console.log("完成BindGv_vPaperReadWrite!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    public async BindTab_vPaperReadWrite(arrvPaperReadWriteObjLst: Array<clsvPaperReadWriteEN>) {
        var strhtml: string = '';
        strhtml += '<div class="info" id="infoPaper"><div class="title btn-3"><ul class="artlist">';
        var p = 0;//给内容加个序号
        for (var i = 0; i < arrvPaperReadWriteObjLst.length; i++) {

            p++;
            var strPaperId = arrvPaperReadWriteObjLst[i].paperId;
            //判断引用论文，自研论文
            if (arrvPaperReadWriteObjLst[i].operationTypeId == "02") {
                strhtml += '<li><span class="rowtit color3">' + p + '.[标题]：</span><span class="abstract-text">' + arrvPaperReadWriteObjLst[i].paperTitle + '(' + arrvPaperReadWriteObjLst[i].operationTypeName + ')</span></li>';
            }
            else {
                strhtml += '<li><span class="rowtit color3">' + p + '.[标题]：</span><span class="abstract-text">' + arrvPaperReadWriteObjLst[i].paperTitle + '(' + arrvPaperReadWriteObjLst[i].operationTypeName + ')</span></li>';
            }
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[研究问题]：</span><span class="abstract-text">' + arrvPaperReadWriteObjLst[i].researchQuestion + '</span><span class="rowtit color3">[关键字]：</span><span class="abstract-text">' + arrvPaperReadWriteObjLst[i].keyword + '</span></li>';

        }
        strhtml += '</ul></div>';

        $("#divPaperReadWriteDataLst").html(strhtml);
        if (this.recCount > 10) {
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }

    //-------------------------------------------------------论文子观点

    public async CombinevPaperSubViewpointCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //// 02 代表论文写作

            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            if (strRoleId == "00620001") {
            }
            //判断角色 //学生00620003
            else if (strRoleId == "00620002") {
            }
            else {
                //只能查看自己的数据；或公开的数据；学生
                strWhereCond += ` And updUser = '${strUserId}'`;

            }

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    /* 根据条件获取相应的记录对象的列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vPaperSubViewpoint() {
        //var strListDiv: string = this.mstrListDiv;
        var strWhereCond = await this.CombinevPaperSubViewpointCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN> = [];
        try {
            this.recCount = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperSubViewpointObjLst = <Array<clsvPaperSubViewpointEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        try {

            const response = await this.BindTab_vPaperSubViewpoint1(arrvPaperSubViewpointObjLst);
            console.log("完成BindGv_vPaperReadWrite!");
            if (this.recCount > 10) {
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    public async BindTab_vPaperSubViewpoint1(arrvPaperSubViewpointObjLst: Array<clsvPaperSubViewpointEN>) {
        var strhtml: string = '';
        strhtml += '<div class="info" id="infoPaper"><div class="title btn-3"></div><ul class="artlist">';
        var p = 0;//给内容加个序号
        for (var i = 0; i < arrvPaperSubViewpointObjLst.length; i++) {

            p++;
           // var strPaperId = arrvPaperSubViewpointObjLst[i].subViewpointId;
            //判断引用论文，自研论文

            strhtml += '<li><span class="rowtit color3">' + p + '.[观点类型]：</span><span class="abstract-text">' + arrvPaperSubViewpointObjLst[i].subViewpointTypeName + '</span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvPaperSubViewpointObjLst[i].subViewpointContent + '</span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">' + arrvPaperSubViewpointObjLst[i].explainTypeName + '：</span><span class="abstract-text">' + arrvPaperSubViewpointObjLst[i].explainContent + '</span></li>';

        }
        strhtml += '</ul></div>';

        $("#divPaperSubViewpointDataLst").html(strhtml);
       
    }
    //-----------------------------------------------------------------------------个人观点

    /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevViewpointCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {

            //var strhidUserTypeId = $("#hidUserTypeId").val();
            //if (strhidUserTypeId != "") {
            //    strWhereCond += ` And ${clsvViewpointEN.con_UserTypeId} = '${strhidUserTypeId}'`;
            //}
            strWhereCond += ` And ${clsvViewpointEN.con_UserTypeId} = '01'`;
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            $("#hidUserId").val(strUserId);
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                $("#btnDelRecord").show();
                $("#btnCancelSubmit").show();

            }
            else if (strRoleId == "00620002") {
                //教师
               
            }
            else {
               
                //学生00620003 00620002教师
                strWhereCond += ` And ${clsvViewpointEN.con_UpdUser} = '${strUserId}'`;
            }
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
       // var strListDiv: string = this.mstrListDiv;
        var strWhereCond = await this.CombinevViewpointCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        try {
            this.recCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }

            };
            const responseObjLst = await vViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
            });
            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            //动态显示对应的数据
            var strhtml = "";
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            //个人观点
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号
            for (var i = 0; i < arrvViewpointObjLst.length; i++) {
                //得到viewpointId；
                var strViewpointId = arrvViewpointObjLst[i].viewpointId;
                v++;

                //对内容进行换行替换
                var strViewpointContent = arrvViewpointObjLst[i].viewpointContent;
                var strReason = arrvViewpointObjLst[i].reason;

                strViewpointContent = strViewpointContent.replace(/\r\n/g, strBr);
                strViewpointContent = strViewpointContent.replace(/\n/g, strBr);

                strReason = strReason.replace(/\r\n/g, strBr);
                strReason = strReason.replace(/\n/g, strBr);

                strhtml += '<li><span class="rowtit color3">[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';

                //strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[类型]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointTypeName + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
                //类型+理由
                strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';

                //strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[来源]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].source + '</span></li>';

                strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">';


                strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].updDate + '</span>';
                
                //判断ture 、false
                if (arrvViewpointObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                }
                strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';

            //拼接；
            $("#divRtViewPointRelaDataLst").html(strhtml);

            if (this.recCount >= 10) {
                $("#divPagerViewpoint").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

      
    }

    //----------------------------------------------------专家观点
    
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public CombinevExpertViewpointCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {

            strWhereCond += ` And ${clsvViewpointEN.con_UserTypeId} = '02'`;
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            $("#hidUserId").val(strUserId);
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                $("#btnDelRecord").show();
                $("#btnCancelSubmit").show();

            }
            else if (strRoleId == "00620002") {
                //教师

            }
            else {

                //学生00620003 00620002教师
                strWhereCond += ` And ${clsvViewpointEN.con_UpdUser} = '${strUserId}'`;
            }
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
    public async BindGv_vExpertViewpoint() {
        // var strListDiv: string = this.mstrListDiv;
        var strWhereCond = await this.CombinevExpertViewpointCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        try {
            this.recCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }

            };
            const responseObjLst = await vViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
            });
            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            //动态显示对应的数据
            var strhtml = "";
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            //个人观点
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号
            for (var i = 0; i < arrvViewpointObjLst.length; i++) {
                //得到viewpointId；
                var strViewpointId = arrvViewpointObjLst[i].viewpointId;
                v++;

                //对内容进行换行替换
                var strViewpointContent = arrvViewpointObjLst[i].viewpointContent;
                var strReason = arrvViewpointObjLst[i].reason;

                strViewpointContent = strViewpointContent.replace(/\r\n/g, strBr);
                strViewpointContent = strViewpointContent.replace(/\n/g, strBr);

                strReason = strReason.replace(/\r\n/g, strBr);
                strReason = strReason.replace(/\n/g, strBr);

                strhtml += '<li><span class="rowtit color3">[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';
                 strhtml += '<li><span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
                //类型+理由
                strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';

                strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">';


                strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].updDate + '</span>';

                //判断ture 、false
                if (arrvViewpointObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                }
                strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';

            //拼接；
            $("#divRtExpertViewPointRelaDataLst").html(strhtml);

            if (this.recCount >= 10) {
                $("#divExpertPagerViewpoint").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }


    }

    //--------------------------------------------------------------------概念

    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
<returns>条件串(strWhereCond)</returns>
*/
    public CombineConceptConditionObj(): clsvConceptEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objConcept_Cond: clsvConceptEN = new clsvConceptEN();
        objConcept_Cond.SetCondFldValue(clsvConceptEN.con_id_CurrEduCls, clsPublocalStorage.id_CurrEduCls, "=");
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

            }
            else if (strRoleId == "00620002") {

            }
            else {
                $("#btnCancelSubmit").hide();
                //学生； 
                strWhereCond += ` And ${clsvConceptEN.con_UpdUser} = '${strUserId}'`;
                objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdUser, strUserId, "=");
            
            }
            $("#hidUserId").val(strUserId);
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objConcept_Cond;
    }
    /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
*/
    public async BindGv_Concept_Cache() {
      
      
        var objConcept_Cond = this.CombineConceptConditionObj();
        var strWhereCond = JSON.stringify(objConcept_Cond);
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrConceptObjLst: Array<clsvConceptEN> = [];
        try {
            this.recCount = await vConcept_GetRecCountByCond_Cache(objConcept_Cond, clsPublocalStorage.id_CurrEduCls);
            //this.recCount = await vConcept_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            

            //});
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrConceptObjLst = await vConcept_GetObjLstByPager_Cache(objPagerPara, clsPublocalStorage.id_CurrEduCls);
            //const responseObjLst = await vConcept_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //    arrConceptObjLst = <Array<clsvConceptEN>>jsonData;
            //});
            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            //动态显示对应的数据
            var strhtml = "";
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            //个人观点
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号
            for (var i = 0; i < arrConceptObjLst.length; i++) {
                //得到conceptId；
                var strConceptId = arrConceptObjLst[i].conceptId;
                v++;
                //对内容进行换行替换
                var strConceptContent = arrConceptObjLst[i].conceptContent;
                strConceptContent = strConceptContent.replace(/\r\n/g, strBr);
                strConceptContent = strConceptContent.replace(/\n/g, strBr);

                //strhtml += v + ".观点：" + arrConceptObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrConceptObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrConceptObjLst[i].viewpointTypeName + ":" + arrConceptObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrConceptObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                strhtml += '<li><span class="rowtit color3">[概念名称]：</span><span class="abstract-text">' + arrConceptObjLst[i].conceptName + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[概念内容]：</span><span class="abstract-text">' + strConceptContent + '</span></li>';
                strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:70%;">'


                strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrConceptObjLst[i].updDate + '</span>';
             
                //判断ture 、false
                if (arrConceptObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                }
              
               

                strhtml += '</li>';


                strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            //拼接；
            $("#divRtConceptRelaDataLst").html(strhtml);


            if (this.recCount >= 10) {
                $("#divPagerConcept").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }

        if (this.recCount >= 10) {
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }
    //-----------------------------------------------------客观事实
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public async CombinevTopicObjectiveCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断客观类型 区分是客观事实、客观依据
          
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveType} = '01'`;
         
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            $("#hidUserId").val(strUserId);
    
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {
              
            }
            else if (strRoleId == "00620002") {
             
            }
            else {
                //学生； 
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} = '${strUserId}'`;
        
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineTopicObjectiveCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vTopicObjective() {
      
        var strWhereCond = await this.CombinevTopicObjectiveCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN> = [];
        try {
            this.recCount = await vTopicObjective_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vTopicObjective_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvTopicObjectiveObjLst = <Array<clsvTopicObjectiveEN>>jsonData;
            });
            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            //动态显示对应的数据
            var strhtml = "";
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            //个人观点
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

         
            strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号
            for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
                //得到topicObjectiveId；
                var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
                v++;
                //对内容进行换行替换
                var strObjectiveContent = arrvTopicObjectiveObjLst[i].objectiveContent;
                var strConclusion = arrvTopicObjectiveObjLst[i].conclusion;
                strObjectiveContent = strObjectiveContent.replace(/\r\n/g, strBr);
                strObjectiveContent = strObjectiveContent.replace(/\n/g, strBr);
                strConclusion = strConclusion.replace(/\r\n/g, strBr);
                strConclusion = strConclusion.replace(/\n/g, strBr);
                //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                strhtml += '<li><span class="rowtit color3">[客观名称]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[客观内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';
                strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'

                strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].updDate + '</span>';
            //判断ture 、false
                if (arrvTopicObjectiveObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                }
        
                strhtml += '</li>';

                strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            //拼接；
            $("#divRtTopicObjectiveDataLst").html(strhtml);

            if (this.recCount >= 10) {
                $("#divPagerObjective").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }




        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
   
    }

    //-----------------------------------------------------------------客观数据

    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public CombinevTopicObjectiveBasisCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断客观类型 区分是客观事实、客观依据

            strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveType} = '02'`;

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            $("#hidUserId").val(strUserId);

            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

            }
            else if (strRoleId == "00620002") {

            }
            else {
                //学生； 
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} = '${strUserId}'`;

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineTopicObjectiveCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vTopicObjectiveBasis() {

        var strWhereCond = await this.CombinevTopicObjectiveBasisCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN> = [];
        try {
            this.recCount = await vTopicObjective_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vTopicObjective_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvTopicObjectiveObjLst = <Array<clsvTopicObjectiveEN>>jsonData;
            });
            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            //动态显示对应的数据
            var strhtml = "";
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            //个人观点
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';


            strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号
            for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
                //得到topicObjectiveId；
                var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
                v++;
                //对内容进行换行替换
                var strObjectiveContent = arrvTopicObjectiveObjLst[i].objectiveContent;
                var strConclusion = arrvTopicObjectiveObjLst[i].conclusion;
                strObjectiveContent = strObjectiveContent.replace(/\r\n/g, strBr);
                strObjectiveContent = strObjectiveContent.replace(/\n/g, strBr);
                strConclusion = strConclusion.replace(/\r\n/g, strBr);
                strConclusion = strConclusion.replace(/\n/g, strBr);
                //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                strhtml += '<li><span class="rowtit color3">[客观名称]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[客观内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';
                strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'

                strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].updDate + '</span>';
                //判断ture 、false
                if (arrvTopicObjectiveObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                }

                strhtml += '</li>';

                strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            //拼接；
            $("#divBasisRtTopicObjectiveDataLst").html(strhtml);

            if (this.recCount >= 10) {
                $("#divPagerBasis").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }




        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }

    }


    //-------------------------------------------------技能
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public async CombinevSysSkillCondition(): Promise<string>  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
         
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            $("#hidUserId").val(strUserId);
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

            
            }
            else if (strRoleId == "00620002") {
              
            }
            else {
                //学生 教师；
            
                strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} = '${strUserId}'`;
                //strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} = '${objvUserRoleRelation.userId}'`;

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysSkillCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vSysSkill() {
     
        var strWhereCond = await this.CombinevSysSkillCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvSysSkillObjLst: Array<clsvSysSkillEN> = [];

        try {
            this.recCount = await vSysSkill_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }
            };
            arrvSysSkillObjLst = await vSysSkill_GetObjLstByPagerAsync(objPagerPara);
            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            //动态显示对应的数据
            var strhtml = "";
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            //技能
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

         strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号
            for (var i = 0; i < arrvSysSkillObjLst.length; i++) {
                //得到skillId；
                var strSkillId = arrvSysSkillObjLst[i].skillId;
                v++;
                var strProcess = arrvSysSkillObjLst[i].process;
                strProcess = strProcess.replace(/\r\n/g, strBr);
                strProcess = strProcess.replace(/\n/g, strBr);
                //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                strhtml += '<li><span class="rowtit color3">[技能名称]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].skillName + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[实施过程]：</span><span class="abstract-text">' + strProcess + '</span></li>';
                //strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].conclusion + '</span></li>';
                strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'

                strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].updDate + '</span>';

              
              

                strhtml += '</li>';

                strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            //拼接；
            $("#divSysskillDataLst").html(strhtml);

            if (this.recCount >= 10) {
                $("#divPagerSysskill").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
    
    }

    //-------------------------------------------------------------社会关系

    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vSysSocialRelations() {
        var strWhereCond = await this.CombinevSysSocialRelationsCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = [];
        try {
            this.recCount = await vSysSocialRelations_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortBy,
                sortFun: (x, y) => { return 0; }
            };
            arrvSysSocialRelationsObjLst = await vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara);


            //换行符
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            //动态显示对应的数据
            var strhtml = "";
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            //社会关系
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号
            for (var i = 0; i < arrvSysSocialRelationsObjLst.length; i++) {
                //得到socialId；
                var strSocialId = arrvSysSocialRelationsObjLst[i].socialId;
                v++;
                var strDetailedDescription = arrvSysSocialRelationsObjLst[i].detailedDescription;
                strDetailedDescription = strDetailedDescription.replace(/\r\n/g, strBr);
                strDetailedDescription = strDetailedDescription.replace(/\n/g, strBr);
                //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].fullName + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].nationality + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].workUnit + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].major + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].achievement + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + strDetailedDescription + '</span></li>';
                strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'

                strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].updDate + '</span>';

                //判断ture 、false
                if (arrvSysSocialRelationsObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                }


                strhtml += '</li>';

                strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            //拼接；
            $("#divSysSocialRelaDataLst").html(strhtml);

            if (this.recCount >= 10) {
                $("#divPagerSysSocialRela").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }

    }


    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinevSysSocialRelationsCondition(): Promise<string>  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
         
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            $("#hidUserId").val(strUserId);
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

            }
            else if (strRoleId == "00620002") {
          
            }
            else {
                //学生 教师；
          
                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_UpdUser} = '${strUserId}'`;
                //strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} = '${objvUserRoleRelation.userId}'`;

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysSocialRelationsCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
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

    /*
* 设置排序字段-相当使用ViewState功能  主题用户关系
*/
    public set hidSortBy(value: string) {
        $("#hidSortBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortBy(): string {
        return $("#hidSortBy").val();
    }
}