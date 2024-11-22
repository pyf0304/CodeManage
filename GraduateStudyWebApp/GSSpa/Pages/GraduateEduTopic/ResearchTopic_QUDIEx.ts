import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsCurrEduClsEN } from "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";
import { clsRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js";
import { clsvRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js";
import { clsgs_ColorEN } from "../TS/L0_Entity/ParameterTable/clsgs_ColorEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsTopicUserRoleEN } from "../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { CurrEduCls_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";
import { sys_RequestPush_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js";
import { ResearchTopic_AddNewRecordWithReturnKeyAsync, ResearchTopic_GetFirstObjAsync, ResearchTopic_GetObjByTopicIdAsync, ResearchTopic_GetObjLstAsync, ResearchTopic_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { RTUserRela_AddNewRecordAsync, RTUserRela_DelRecordAsync, RTUserRela_GetFirstObjAsync, RTUserRela_GetObjLstAsync, RTUserRela_IsExistRecordAsync, RTUserRela_ReFreshCache, RTUserRela_ReOrderAsync, RTUserRela_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js";
import { vRTUserRela_GetObjBymId_Cache, vRTUserRela_GetObjLst_Cache, vRTUserRela_GetSubObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js";
import { gs_Color_GetObjLstAsync, gs_Color_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ColorWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { TopicUserRole_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { CurrEduClsEx_SortFun_IntTag } from "../TS/L3_ForWApiEx/DailyRunning/clsCurrEduClsExWApi.js";
import { CurrEduClsTeacherEx_SetCurrEduClsOrderNum4TeacherId } from "../TS/L3_ForWApiEx/DailyRunning/clsCurrEduClsTeacherExWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { ResearchTopicEx_DelRecordAsyncEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsResearchTopicExWApi.js";
import { RTUserRelaEx_UpdateTypeTableHtmlAsync } from "../TS/L3_ForWApiEx/GraduateEduTopic/clsRTUserRelaExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { clsOrderByData } from "../TS/PubFun/clsOrderByData.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { PaperLstSel } from "./PaperLstSel.js";
import { RTPaperRela_QUDIEx } from "./RTPaperRela_QUDIEx.js";
import { UsersLstSel } from "./UsersLstSel.js";

//import * as $ from "jquery";
//import * as QQ from "q";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;

declare function ShowUserColor(): void;
declare function HideUserColor(): void;

declare function HideDialogFour(): void;

declare function LoadTreeShow(strKey): void;
declare function HideDialogSeven(): void;

declare function liPaperClick(strKeyId): void;//相关论文
declare function liTeacherTaskClick(): void;//教师任务
declare function liResearchPlanClick(): void;//研究计划
declare function liPaperSubViewpoint(): void;//论文子观点

declare function liViewpointClick(): void;//个人观点
declare function liExpertViewpointClick(): void;//专家观点
declare function liConceptClick(): void;//相关概念
declare function liObjectiveFactClick(): void;//客观事实
declare function liObjectiveBasisClick(): void;//客观依据
declare function liSysskillClick(): void;//技能
declare function liSysSocialRelationsClick(): void;//社会关系

declare function ligs_ReflectLog(): void;//反思日志
declare function liMeetingMinutesClick(): void;//会议纪要
declare function liPaperReportClick(): void;//论文汇报
declare function liTobeStudiedProblemClick(): void;//待研究问题
declare function liResearchResultClick(): void;//研究成果
declare function liViewsClassificationClick(): void;//各观点分类
declare function xadminopen2(title, strFile, intWidth, intHeight): void;//打开一个对话框

declare function TopicMenuIsHide(): void;//主题菜单是否隐藏
declare var $;
declare var window;
/* ResearchTopic_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ResearchTopic_QUDIEx implements clsOperateList implements IShowList {
    //export class ResearchTopic_QUDIEx extends ResearchTopic_QUDI {
    //用户列表
    public static topicId: string = "";//当前所选的主题Id
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 20;
    }
    public RecCount = 0;
    BindGv(strType: string, strPara: string) {
        alert('该类没有绑定该函数：[this.BindGv_vViewInfo]！');
        //this.BindGv_vViewInfo();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case clsRTPaperRelaEN._CurrTabName:
                if (clsString.IsNullOrEmpty(strPara) == false) {

                    var obj = new RTPaperRela_QUDIEx();
                    obj.btnPaperRecordInTab_Click(strPara);
                }
                break;
            case clsRTUserRelaEN._CurrTabName:
                if (clsString.IsNullOrEmpty(strPara) == false) {

                    this.btnUserRecordInTab_Click(strPara);
                }
                break;

            default:
                var strMsg = clsString.Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);

        }
    }
    /*
    按钮单击,用于调用Js函数中btn_Click
   (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
   */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: ResearchTopic_QUDIEx = new ResearchTopic_QUDIEx();
        var objPage_Edit_PaperSel: PaperLstSel = new PaperLstSel(objPage);
        switch (strCommandName) {
           
            case "AddTeacherTask":    //添加研究计划
                //var objPage_Edit_TeacherTask: Addgs_TeacherTaskEx = new Addgs_TeacherTaskEx(objPage);

                //objPage_Edit_TeacherTask.btnAddgs_TeacherTask_Click();
                break;
            case "AddResearchPlan":    //添加研究计划
                objPage.btnAddResearchPlan_Click();
                break;
            case "AddRelaPaper":    //查询记录
                objPage_Edit_PaperSel.btnAddPaperRela_Click();
                break;
            case "AddRelaUsers":    //查询记录
                var objPage_Edit_UsersSel: UsersLstSel = new UsersLstSel(objPage);

                objPage_Edit_UsersSel.btnAddUserRela_Click();
                break;
            case "Query":    //查询记录
                //objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                //objPage_Edit.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                //objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
            case "UpdateRecordInTab":            //修改记录InTab
                //objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                //objPage.btnDelRecord_Click();
                break;
            case "DelRecordInTab":   //删除记录InTab 
                //objPage.btnDelRecordInTab_Click(strKeyId);
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要下移的记录！");
                    return;
                }
                //objPage.btnDownMove_Click();
                break;
            case "ReOrder":            //重序记录
                //objPage.btnReOrder_Click();
                break;
            default:
                var strMsg = '命令:' + strCommandName + "在函数(gs_TopicRoleCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {
                //主题
                this.hidSortResearchTopicBy = "updDate Desc";
                //主题用户
                this.hidSortvRTUserRelaBy = "updDate Asc";

                this.hidSortQxUsersBy = "updDate Desc";

                //读取session角色 来判断绑定不同数据列表
                $("#hidUserId").val(clsPubSessionStorage.GetSession_UserId());
                $("#hidRoleId").val(clsPubSessionStorage.GetSession_RoleId());
                //管理员 判断角色 
                if ($("#hidRoleId").val() == "00620001") {

                    //    $("#btnDelRecord").show();
                    $("#tab4Bind tr").find("td:eq(8)").show();
                }
                else {
                    //学生00620003 教师 
                    //      $("#btnDelRecord").hide();
                    $("#tab4Bind tr").find("td:eq(8)").hide();
                }

                //if (this.bolIsInitShow == false)  //
                //{
                //    this.objPager.InitShow(this.divName4Pager);
                //    this.bolIsInitShow = true;  //
                //}
                const gvResult1 = await this.Bind_ApplyTopicCount();
                const gvResult2 = await this.GetTopicData();
                $("#divLoading").hide();
            }
            else {
                alert("登录超时，请重新登录！");
                window.top.location.href = "../Web/Login";
            }
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //申请主题数
    public async Bind_ApplyTopicCount() {
        try {
            //var strWhereCond = " 1=1  and id_CurrEduCls=" + clsPublocalStorage.Getid_CurrEduCls();
            var strWhereCond = " 1=1 ";
            strWhereCond += " and requesTypeId='02' and receiveUser='" + clsPubSessionStorage.GetSession_UserId() + "' and isReply=0";

            var int_ReceiveCount = await sys_RequestPush_GetRecCountByCondAsync(strWhereCond)
            $("#ApplyTopicCount").html(int_ReceiveCount);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            //alert(strMsg);
            console.log(strMsg);
        }
    }

    /* 为插入记录做准备工作
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
 */
    public AddNewRecord() {
        //this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //去掉提交按钮不可用状态
        $('#btnOKUpd').attr("disabled", false);
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.OpType = "Add";
        try {
            var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
            const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
            const responseText = await this.AddNewRecord();
            //获取分享Id
            const responseText1 = await gs_UserConfigEx_GetNewReturnShareIdEx("12", clsPubSessionStorage.GetSession_UserId());
            var strShareId: string = responseText1;
            if (strShareId != "") {
                this.shareId = strShareId;
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }


    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.topicId = "";
        this.topicName = "";
        this.topicContent = "";
        this.topicProposePeople = "";
        this.orderNum = 0;
        this.updDate = "";
        this.updUser = "";
        this.memo = "";
    }


    //得到3个关系列表数据；
    public async GetAllFunctionMethod(strTopicId: string) {
        ResearchTopic_QUDIEx.topicId = strTopicId;
        $('#hidTopicRelaId').val(ResearchTopic_QUDIEx.topicId);
        TopicMenuIsHide();
        clsPublocalStorage.eduClsTypeId = $("#hideduClsTypeId").val();

        $("#divContent_list").show();
        //如果是点击了树菜单、或者是刷新，那么需要做样式控制；
        //首先要去掉ul下 li a 样式
        //$("#myTab li a").removeClass();
        //$("#myTab li").removeClass();
        //判断根据序号显示不同的数据源
        var strnum = $("#hidTabNum").val();

        switch (strnum) {
            case "1":
                //主题用户关系；
                this.BindGv_vRTUserRela();
                break;
            case "2":
                //主题论文关系；
                liPaperClick('01');
                break;
            case "3":
                //主题个人观点关系；
                liViewsClassificationClick();
                liViewpointClick();
                //this.BindGv_vRTViewpointRela();
                break;
            case "4":
                //专家观点
                liViewsClassificationClick();
                liExpertViewpointClick();
                //this.BindGv_vRTExpertViewpointRela();
                break;
            case "5":
                //主题概念关系
                liViewsClassificationClick();
                liConceptClick();
                //this.BindGv_vRTConceptRela();
                break;
            case "6":
                //客观事实关系
                liViewsClassificationClick();
                liObjectiveFactClick();
                //this.BindGv_vRTTopicObjectiveRela();
                break;
            case "7":
                //客观依据关系
                liViewsClassificationClick();
                liObjectiveBasisClick();
                //this.BasisBindGv_vRTTopicObjectiveRela();
                break;
            //case "8":
            //    //研究结果
            //    this.BindGv_vRTResearchResult();
            //    break;
            case "9":
                //技能
                liViewsClassificationClick();
                liSysskillClick();
                //this.BindGv_vRTSysSkill();
                break;
            case "10":
                //社会关系
                liViewsClassificationClick();
                liSysSocialRelationsClick();
                break;
            case "11":
                //研究计划
                //this.BindGv_vgs_ResearchPlan();
                liTeacherTaskClick();
                liResearchPlanClick();
                break;
            case "12":
                //小组论文习作
                liPaperClick('02');
                break;
            case "13":
                //反思日志
                ligs_ReflectLog();
                break;
            case "14":
                break;
            case "15":
                //论文子观点
                liPaperSubViewpoint();
                break;
            case "16":
                //会议纪要
                liMeetingMinutesClick();
                break;
            case "17":
                //论文汇报
                liPaperReportClick();
                break;
            case "18":
                //待研究问题
                liTobeStudiedProblemClick();
                break;
            case "19":
                //研究成果
                liResearchResultClick();
                break;
            default:
                this.BindGv_vRTUserRela();
                break;
        }
    }

    //动态主题数据结构；
    public async GetTopicData() {

        var strWhereCond = this.CombineResearchTopicCondition();
        //声明主题变量
        var arrResearchTopicObjLst0: Array<clsResearchTopicEN> = [];
        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];
        //声明主题变量
        var arrCurrEduClsObjLst: Array<clsCurrEduClsEN> = [];

        arrResearchTopicObjLst0 = await ResearchTopic_GetObjLstAsync(strWhereCond);
        var arrid_CurrEduCls = "";
        for (var i = 0; i < arrResearchTopicObjLst0.length; i++) {
            arrid_CurrEduCls += arrResearchTopicObjLst0[i].id_CurrEduCls + ",";
        }
        if (arrid_CurrEduCls.length > 0) {
            arrid_CurrEduCls = arrid_CurrEduCls.substr(0, arrid_CurrEduCls.length - 1);

            var strWhereCond2 = "id_CurrEduCls in(" + arrid_CurrEduCls + ") order by eduClsName Asc";

            arrCurrEduClsObjLst = await CurrEduCls_GetObjLstAsync(strWhereCond2);
            const strRoleName = clsPubSessionStorage.GetSession_RoleName();
            
            if (strRoleName.indexOf("学生") == -1) {
                const strTeacherId = clsPubSessionStorage.GetSession_UserId();
                await    CurrEduClsTeacherEx_SetCurrEduClsOrderNum4TeacherId(arrCurrEduClsObjLst, strTeacherId);
                arrCurrEduClsObjLst = arrCurrEduClsObjLst.sort(CurrEduClsEx_SortFun_IntTag);
            }
        }

        //主题用户关系
        var strWhereCond3 = "UserID ='" + clsPubSessionStorage.GetSession_UserId() + "'";
        var arrRTUserRelaObjLst: Array<clsRTUserRelaEN> = [];
        var objResearchTopicEN: clsResearchTopicEN = new clsResearchTopicEN;
        arrRTUserRelaObjLst = await RTUserRela_GetObjLstAsync(strWhereCond3);

        var strhtml = "";
        //$("#TreeBind li").remove();
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var stateNum = 1;
        if (arrCurrEduClsObjLst.length > 0) {

            //判断如果存在00000050私有教学班，但是没有私有主题，则默认添加一个默认主题
            var objCurrEduCls = arrCurrEduClsObjLst.find(x => x.id_CurrEduCls == "00000050");
            if (objCurrEduCls != null) {
                //有这个教学班，那么查询是否有这个教学班的私有主题，没有则默认添加一个(01代表私有)
                var strWhereCond = " 1=1 And id_CurrEduCls = '00000050' And updUser = '" + strUserId + "' And shareId = '01'";
                objResearchTopicEN = await ResearchTopic_GetFirstObjAsync(strWhereCond);
                if (objResearchTopicEN != null) {
                    console.log('已有私有主题');
                    //主题菜单树展示
                    const responseTextTree = await this.ShowResearchTopicTree(arrCurrEduClsObjLst, arrResearchTopicObjLst0, arrRTUserRelaObjLst);
                }
                else {
                    //没有则添加一个
                    //没有主题就默认添加一天主题数据；
                    const responseTextAdd = await this.AddPrivateTopic();
                }
            }
            else {
                //主题菜单树展示
                const responseTextTree = await this.ShowResearchTopicTree(arrCurrEduClsObjLst, arrResearchTopicObjLst0, arrRTUserRelaObjLst);
            }
        }
    }

    //主题菜单树的展示
    public async ShowResearchTopicTree(arrCurrEduClsObjLst: Array<clsCurrEduClsEN>, arrResearchTopicObjLst0: Array<clsResearchTopicEN>, arrRTUserRelaObjLst: Array<clsRTUserRelaEN>) {
        var strhtml = "";
        //如果私有教学班没有 则直接显示；
        for (var j = 0; j < arrCurrEduClsObjLst.length; j++) {
            //var streduClsName = arrCurrEduClsObjLst[j].eduClsName;
            //if (streduClsName.length > 5) {
            //    streduClsName = streduClsName.substr(0, 5) + "...";
            //}
            var htmleduClsName = '';
            var streduClsTypeId = arrCurrEduClsObjLst[j].eduClsTypeId;
            //如果是公共私有教学班那么就不显示
            if (streduClsTypeId == "0001") {
                htmleduClsName += '<a href="#" id="' + arrCurrEduClsObjLst[j].id_CurrEduCls + '" class="main" title="私有研究" onclick=main_Click("' + arrCurrEduClsObjLst[j].id_CurrEduCls + '")>私有研究</a>';
            } else {
                htmleduClsName += '<a href="#" id="' + arrCurrEduClsObjLst[j].id_CurrEduCls + '" class="main" title="' + arrCurrEduClsObjLst[j].eduClsName + '" onclick=main_Click("' + arrCurrEduClsObjLst[j].id_CurrEduCls + '")>' + arrCurrEduClsObjLst[j].eduClsName + '</a>';
            }

            strhtml += '<li class="li">';
            strhtml += htmleduClsName;
            //strhtml += '<ul class="submenu" style="display: block;">';
            strhtml += '<ul class="submenu" id="ul' + arrCurrEduClsObjLst[j].id_CurrEduCls + '">';

            var arrResearchTopicObjLst = arrResearchTopicObjLst0.filter(x => x.id_CurrEduCls == arrCurrEduClsObjLst[j].id_CurrEduCls);
            if (arrResearchTopicObjLst.length > 0) {
                //循环数据
                for (var i = 0; i < arrResearchTopicObjLst.length; i++) {
                    var strTopicName = arrResearchTopicObjLst[i].topicName;
                    if (strTopicName.length > 15) {
                        strTopicName = "<span>" + strTopicName.substr(0, 15) + "...</span>";
                    }
                    //var objCurrEduCls = arrCurrEduClsObjLst.find(x => x.id_CurrEduCls == arrResearchTopicObjLst[i].id_CurrEduCls);
                    //if (objCurrEduCls != null) {
                    //    var streduClsName = objCurrEduCls.eduClsName;
                    //    if (streduClsName.length > 5) {
                    //        streduClsName = streduClsName.substr(0, 5) + "...";
                    //    }
                    //    var htmleduClsName = '';
                    //    //如果是公共私有教学班那么就不显示
                    //    if (objCurrEduCls.eduClsTypeId == "0001") {
                    //        htmleduClsName += '';
                    //    } else {
                    //        htmleduClsName += '&nbsp;<a style="color:#436EEE;float:left" title="' + objCurrEduCls.eduClsName + '">(' + streduClsName + ')</a>';
                    //    }


                    strhtml += '<li id="' + arrResearchTopicObjLst[i].topicId + '" onclick=btnSelectResearchTopic("' + arrResearchTopicObjLst[i].topicId + '","' + arrResearchTopicObjLst[i].id_CurrEduCls + '","' + arrResearchTopicObjLst[i].topicName + '","' + streduClsTypeId + '")>';
                    //默认存放第一条数据显示；

                    //根据主题用户关系得到当前主题和登录用户之间的身份信息
                    var strIcon = '';
                    var objRTUserRela = arrRTUserRelaObjLst.find(x => x.topicId == arrResearchTopicObjLst[i].topicId);
                    if (objRTUserRela != null) {
                        switch (objRTUserRela.topicUserRoleId) {
                            case "0001":
                                strIcon += '&nbsp;<i class="layui-icon layui-icon-group" style = "font-size: 16px; color: red;" title="指导者" ></i>';
                                break;
                            case "0002":
                                strIcon += '&nbsp;<i class="layui-icon layui-icon-friends" style = "font-size:16px; color: #F4606C;" title="组长" ></i>';
                                break;
                            case "0003":
                                strIcon += '&nbsp;<i class="layui-icon layui-icon-username" style = "font-size: 16px; color: #19CAAD;" title="成员" ></i>';
                                break;
                        }
                    } else {
                        strIcon += '&nbsp;<i class="layui-icon layui-icon-set" style = "font-size: 16px; color: #1E9FFF;" title="管理" ></i>';
                    }

                    //if (i == 0) {
                    //判断存放的id控件是否为空；
                    if (clsString.IsNullOrEmpty(ResearchTopic_QUDIEx.topicId) == true) {
                        //存放Id
                        ResearchTopic_QUDIEx.topicId = arrResearchTopicObjLst[i].topicId;
                        $('#hidTopicRelaId').val(ResearchTopic_QUDIEx.topicId );
                        $("#hidId_CurrEduCls").val(arrResearchTopicObjLst[i].id_CurrEduCls);
                        $("#topicName", window.parent.document).html(arrResearchTopicObjLst[i].topicName);
                        clsPublocalStorage.eduClsTypeId = streduClsTypeId;
                        //strhtml += '<a style="float:left" href="#" title="' + arrResearchTopicObjLst[i].topicName + '" class="selected">' + strTopicName + '</a>' + strIcon + '</div>';
                        strhtml += '<a href="#" title="' + arrResearchTopicObjLst[i].topicName + '" class="selected">' + strTopicName + strIcon + '</a>';
                        //strhtml += '<li id="' + arrResearchTopicObjLst[i].topicId + '" onclick=btnSelectResearchTopic("' + arrResearchTopicObjLst[i].topicId + '","' + arrResearchTopicObjLst[i].id_CurrEduCls + '","' + arrResearchTopicObjLst[i].topicName + '","' + objCurrEduCls.eduClsTypeId + '")><a href="#" class="selected">' + arrResearchTopicObjLst[i].topicName + '</a>' + htmleduClsName + '</li>';
                    }
                    else {
                        strhtml += '<a href="#" title="' + arrResearchTopicObjLst[i].topicName + '">' + strTopicName + strIcon + '</a>';
                    }

                    strhtml += '</li>';
                }

            }
            strhtml += '</ul>';
            strhtml += '</li>';

        }
        //$("#divContent_list").show();
        $("#TreeBind").html(strhtml);
        ////首次调用树展开；
        //给每一个教学班前的图标展示位展开状态
        //LoadTreeShow(arrCurrEduClsObjLst[j].id_CurrEduCls);
        ////调用关系列表数据
        $("#hideduClsTypeId").val(clsPublocalStorage.eduClsTypeId);
        //const responseText1 = await this.TopicMenuIsHide();

        const responseText2 = await this.GetAllFunctionMethod(ResearchTopic_QUDIEx.topicId);
    }

    //如果当前登录的用户没有教学班主题，那么默认给添加一个私有主题；
    /* 添加新记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddPrivateTopic() {
        this.DivName = "divAddNewRecordSave";
        var strTopicId;
        var strUserName = clsPubSessionStorage.GetSession_UserName();
        var objResearchTopicEN: clsResearchTopicEN = new clsResearchTopicEN();
        //objResearchTopicEN.topicId = strTopicId;// 主题编号
        objResearchTopicEN.topicName = strUserName + "私有主题";// 栏目主题
        objResearchTopicEN.topicContent = strUserName + "私有主题";// 主题内容
        objResearchTopicEN.topicProposePeople = clsPubSessionStorage.GetSession_UserId();// 主题提出人
        objResearchTopicEN.orderNum = 30;// 序号
        objResearchTopicEN.shareId = "01";//共享
        objResearchTopicEN.id_CurrEduCls = "00000050";//自动添加的都只能添加私有教学班
        objResearchTopicEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        objResearchTopicEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改人
        objResearchTopicEN.memo = this.memo;// 备注
        try {
            strTopicId = await ResearchTopic_AddNewRecordWithReturnKeyAsync(objResearchTopicEN);
            //var returnBool: boolean = !!responseText2;
            //if (returnBool == true) {
            if (strTopicId != "") {

                //这里默认添加一个用户数据 ，作为主题用户关系的组长；
                const responseText3 = await this.AddNewTopicAndRecordSaveUserRela(strTopicId);

                //完成后重新绑定菜单树
                const responseText4 = await this.GetTopicData();

                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                //  alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return true;//一定要有一个返回值，否则会出错！
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
            //判断主题id

            if (clsString.IsNullOrEmpty(ResearchTopic_QUDIEx.topicId) == true) {
                strWhereCond += ` And ${clsvRTUserRelaEN.con_TopicId} = '${ResearchTopic_QUDIEx.topicId}'`;
            }
            //读取session角色 来判断绑定不同数据列表
            //判断角色 //管理员
            if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {

            }
            else if (clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                //教师
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                // strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
            }
            else {
                //学生； 
                //strWhereCond += ` And ${clsvRTUserRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
            }
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

        //var strWhereCond = this.CombinevRTUserRelaCondition();
        //var intCurrPageIndex = this.CurrPageIndexUser;//获取当前页
        var arrvRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
        var arrvUsersObjLst: Array<clsvUsersSimEN> = [];
        var arrTopicUserRoleObjLst: Array<clsTopicUserRoleEN> = [];
        try {

            //var objPagerPara: stuPagerPara = {
            //    pageIndex: intCurrPageIndex,
            //    pageSize: this.pageSize,
            //    whereCond: strWhereCond,
            //    orderBy: this.hidSortvRTUserRelaBy,
            //    sortFun: (x, y) => { return 0; }
            //};


            //const responseObjLst = await vRTUserRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //    arrvRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
            //});


            //var objvRTUserRela_Cond: clsvRTUserRelaEN = new clsvRTUserRelaEN();
            //objvRTUserRela_Cond.SetCondFldValue(clsvRTUserRelaEN.con_TopicId, strTopicId, "=");
            arrvRTUserRelaObjLst = await vRTUserRela_GetObjLst_Cache(ResearchTopic_QUDIEx.topicId);

            //获取用户缓存数据；
            arrvUsersObjLst = await vUsersSim_GetObjLst_Cache();

            //获取用户角色表
            const responseText = TopicUserRole_GetObjLst_Cache().then((jsonData) => {
                arrTopicUserRoleObjLst = <Array<clsTopicUserRoleEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            this.BindTabvRTUserRela(arrvRTUserRelaObjLst, arrvUsersObjLst, arrTopicUserRoleObjLst);

            var arrTopicUserList = "";
            for (var i = 0; i < arrvRTUserRelaObjLst.length; i++) {
                arrTopicUserList += arrvRTUserRelaObjLst[i].userId + ",";
            }
            arrTopicUserList = arrTopicUserList.substr(0, arrTopicUserList.length - 1);
            clsPublocalStorage.TopicUserList = arrTopicUserList;


            console.log("完成BindGv_vRTUserRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    //绑定主题用户关系列表；
    public BindTabvRTUserRela(arrvRTUserRelaObjLst: Array<clsvRTUserRelaEN>, arrvUsersObjLst: Array<clsvUsersSimEN>, arrTopicUserRoleObjLst: Array<clsTopicUserRoleEN>) {
        var strhtml = "";
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var strRoleId = "";
        strhtml += '<div class="info" id="infoRTUserRela"><div class="title btn-4">';
        strhtml += '</div><ul class="artlist">';

        //获取当前用户在 主题用户关系表中的角色；
        var objUserRole = arrvRTUserRelaObjLst.find(x => x.userId == strUserId);
        if (objUserRole != null) {
            strRoleId = objUserRole.topicUserRoleId;
        }

        var v = 0;//给内容加个序号
        for (var i = 0; i < arrvRTUserRelaObjLst.length; i++) {
            //得到mId；
            var strmId = arrvRTUserRelaObjLst[i].mId;
            var strUserColor = arrvRTUserRelaObjLst[i].colorCode;
            var strTopicUser = arrvRTUserRelaObjLst[i].userId;
            var strTopicRoleId = arrvRTUserRelaObjLst[i].topicUserRoleId;
            v++;
            var objUser = arrvUsersObjLst.find(x => x.userId == arrvRTUserRelaObjLst[i].userId);
            if (objUser != null) {
                var strUserName = objUser.userName;
                strhtml += '<li><span class="rowtit color4">' + v + '.[用户]：</span><span class="abstract-text">' + strUserName + '</span>';
            }

            //学院
            strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[学院]：</span><span class="abstract-text">' + arrvRTUserRelaObjLst[i].collegeName + '</span>';

            strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[专业]：</span><span class="abstract-text">' + arrvRTUserRelaObjLst[i].majorName + '</span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[角色]：</span><span class="abstract-text">' + arrvRTUserRelaObjLst[i].topicUserRoleName + '</span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[色码]：</span><span class="abstract-text"><label style="background: ' + strUserColor + '">&nbsp;&nbsp;&nbsp;&nbsp;</label></span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[操作]：';


            ////修改色码
            ////只能修改自己的，所以这里判断一下；
            //if (strTopicUser == strUserId) {
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick="btnUpdateUserRelaInTab_Click(' + arrvRTUserRelaObjLst[i].mId + ')" >修改</button>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelUserRelaInTab_Click(' + arrvRTUserRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
            //}
            //else {
            if (strRoleId != "0003") {
                //组长或指导员
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick="btnUpdateUserRelaInTab_Click(' + arrvRTUserRelaObjLst[i].mId + ',' + strRoleId + ')" >修改</button>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelUserRelaInTab_Click(' + arrvRTUserRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';

            }
            else {
                //成员 只能修改自己的，所以这里判断一下；
                if (strTopicUser == strUserId) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick="btnUpdateUserRelaInTab_Click(' + arrvRTUserRelaObjLst[i].mId + ',' + strRoleId + ')" >修改</button>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelUserRelaInTab_Click(' + arrvRTUserRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                }
            }
            strhtml += '</span></li>';
            strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        }
        strhtml += '</ul></div>';

        //拼接；
        $("#divRtUserRelaDataLst").html(strhtml);

    }

    //主题用户色码修改
    public async btnUpdateUserRelaInTab_Click(strKeyId: string, strRoleId: string) {
        //判断主题id
        var arrgs_ColorObjLst: Array<clsgs_ColorEN> = [];
        var arrTopicUserRoleObjLst: Array<clsTopicUserRoleEN> = [];
        var strLoginUserId = clsPubSessionStorage.GetSession_UserId();
        if (clsString.IsNullOrEmpty(ResearchTopic_QUDIEx.topicId) == true) {

            //拼接后再调用下拉框绑定；
            //获取用户角色表
            const responseText = TopicUserRole_GetObjLst_Cache().then((jsonData) => {
                arrTopicUserRoleObjLst = <Array<clsTopicUserRoleEN>>jsonData;
            });

            var lngKeyId = Number(strKeyId);
            //var objvGetRtUsersEN: clsvRTUserRelaEN = await vRTUserRela_GetObjBymIdAsync(lngKeyId);
            var objvGetRtUsersEN = await vRTUserRela_GetObjBymId_Cache(lngKeyId, ResearchTopic_QUDIEx.topicId);
            if (objvGetRtUsersEN != null) {
                var strTopicRoleId = objvGetRtUsersEN.topicUserRoleId;
                var strColorId = objvGetRtUsersEN.colorId;
                //存入老色码块
                $("#hidOldColorCode").val(objvGetRtUsersEN.colorCode);
                $('#hidUpdUserId').val(objvGetRtUsersEN.userId);
                //if (objGetRtUsersEN.userId == strLoginUserId) {
                //只要 

                ShowUserColor();
                var strColor: string = "";
                var strWhereCond = " 1=1 And colorId not in (select colorId from RTUserRela where topicId='" + ResearchTopic_QUDIEx.topicId + "' And colorId != '" + strColor + "')";
                const responseObjLst = await gs_Color_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrgs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;
                });

                var strhtml = "";
                //var strUserId = clsPubSessionStorage.GetSession_UserId();
                strhtml += '<div class="info" id="infogsColor">';
                strhtml += '<button title="点击确定" class="layui-btn layui-btn btn-sm" onclick=btnOkUserColor_Click("' + strColorId + '") >确定</button>';
                strhtml += '<div class="title btn-4" style="float:left;margin-top:-10px;">';
                //判断当前用户角色，如果是成员，那么不能修改角色、只有组长和指导员才可以修改；
                if (strRoleId != "0003") {
                    strhtml += '<select id="ddlRtUserRole" name="ddlRtUserRole" class="form-control" style="width:180px;">';
                }
                else {
                    strhtml += '<select id="ddlRtUserRole" name="ddlRtUserRole" class="form-control" style="width:180px;" disabled="disabled">';
                }
                //如果大于0 则绑定下拉框
                if (arrTopicUserRoleObjLst.length > 0) {
                    for (var j = 0; j < arrTopicUserRoleObjLst.length; j++) {
                        var strRoleId = arrTopicUserRoleObjLst[j].topicUserRoleId;
                        //如果循环的ID等于当前修改的ID则选中
                        if (arrTopicUserRoleObjLst[j].topicUserRoleId == strTopicRoleId) {
                            strhtml += '<option value="' + strRoleId + '">' + arrTopicUserRoleObjLst[j].topicUserRoleName + '</option>';
                        }
                        else {
                            strhtml += '<option value="' + strRoleId + '">' + arrTopicUserRoleObjLst[j].topicUserRoleName + '</option>';
                        }
                    }
                    //strhtml += '<option value="0001">指导者</option><option value="0002">组长</option><option value="0003">成员</option></select>';
                }

                //strhtml += '<option value="0001">指导者</option><option value="0002">组长</option><option value="0003">成员</option></select>';
                strhtml += '</select></div><ul class="artlist">';
                var v = 0;//给内容加个序号
                for (var i = 0; i < arrgs_ColorObjLst.length; i++) {
                    //得到mId；
                    var strcolorId = arrgs_ColorObjLst[i].colorId;
                    var strUserColor = arrgs_ColorObjLst[i].colorCode;
                    v++;

                    strhtml += '<li>';
                    strhtml += '<button style="background:' + strUserColor + ';" title="点击选择" class="layui-btn layui-btn" onclick=btnOkUserColor_Click("' + strcolorId + '") ></button>';
                    strhtml += '</li>';

                    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                }
                strhtml += '</ul></div>';

                //拼接；
                $("#divUserColorDataLst").html(strhtml);
                this.RtUserRoleId = objvGetRtUsersEN.topicUserRoleId;
            }
        }
    }
    //确定选择色码，把色码更新到主题用户关系表；
    public async btnOkUserColor_Click(strcolorId: string) {
        var strKeyId = $('#hidTopicUserId').val();

        var strUserId = "";
        var objRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
        objRTUserRelaEN.mId = Number(strKeyId);
        objRTUserRelaEN.colorId = strcolorId;
        objRTUserRelaEN.topicUserRoleId = this.RtUserRoleId;

        objRTUserRelaEN.sf_UpdFldSetStr = objRTUserRelaEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objRTUserRelaEN.mId == 0 || objRTUserRelaEN.mId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await RTUserRela_UpdateRecordAsync(objRTUserRelaEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                RTUserRela_ReFreshCache(ResearchTopic_QUDIEx.topicId);
                HideUserColor();
                this.BindGv_vRTUserRela();

                //var objvGetRtUsersEN: clsvRTUserRelaEN = await vRTUserRela_GetObjBymIdAsync(strKeyId);
                var objvGetRtUsersEN = await vRTUserRela_GetObjBymId_Cache(objRTUserRelaEN.mId, ResearchTopic_QUDIEx.topicId);
                if (objvGetRtUsersEN != null) {

                    var OldColorCode = $("#hidOldColorCode").val();
                    //得到新的色码块
                    $("#hidNewColorCode").val(objvGetRtUsersEN.colorCode);
                    //得到修改的用户Id
                    var strUserId: string = $('#hidUpdUserId').val();

                    var OldColor = OldColorCode.substr(1, OldColorCode.length)
                    var NewColor = objvGetRtUsersEN.colorCode.substr(1, objvGetRtUsersEN.colorCode.length)

                    //调用更改当前用户所涉及的所有表背景 
                    const responseText = RTUserRelaEx_UpdateTypeTableHtmlAsync(OldColor, NewColor, strUserId);
                }


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

    //删除主题用户关系
    public async btnDelUserRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var strUserId = $("#hidUserId").val();

            var lngKeyId = Number(strKeyId);
            //var objdelRtUsersEN: clsRTUserRelaEN = await RTUserRela_GetObjBymIdAsync(lngKeyId);
            var objdelRtUsersEN = await vRTUserRela_GetObjBymId_Cache(lngKeyId, ResearchTopic_QUDIEx.topicId);
            if (objdelRtUsersEN == null) return;
            //var strWhereCond = ` 1=1 And ${clsRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsRTUserRelaEN.con_UserId} ='${strUserId}'`;
            // var strWhereCond = ` 1=1 And ${clsRTUserRelaEN.con_mId} = '${lngKeyId}'`;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；

            var objvRTUserRela_Cond: clsvRTUserRelaEN = new clsvRTUserRelaEN();
            objvRTUserRela_Cond.SetCondFldValue(clsvRTUserRelaEN.con_UserId, strUserId, "=");

            var arrRtUsersEN: Array<clsvRTUserRelaEN> = await vRTUserRela_GetSubObjLst_Cache(objvRTUserRela_Cond, ResearchTopic_QUDIEx.topicId);
            if (arrRtUsersEN.length > 0) {
                if (arrRtUsersEN[0].topicUserRoleId == "0003") {
                    //成员
                    var strMsg = `您当前是成员不能删除数据！`;
                    alert(strMsg);
                    return;
                }
                else {



                    if (objdelRtUsersEN.userId == strUserId) {
                        //自己不能删除自己
                        var strMsg = `自己不能删除自己！`;
                        alert(strMsg);
                        return;
                    }
                    else {
                        //指导员0001 //组长0002
                        const responseText = this.DelUserRelaRecord(lngKeyId);
                        const responseText1 = this.btnReOrder_Click();
                    }


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
                        RTUserRela_ReFreshCache(ResearchTopic_QUDIEx.topicId);
                        //绑定列表
                        this.BindGv_vRTUserRela();
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
    public IndexPageFour(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.CurrPageIndexUser = intPageIndex;
        this.BindGv_vRTUserRela();
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
        if (this.orderNum == 0) {
            pobjResearchTopicEN.orderNum = 30;// 序号
        } else {
            pobjResearchTopicEN.orderNum = this.orderNum;// 序号
        }

        pobjResearchTopicEN.shareId = this.shareId;
        pobjResearchTopicEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        pobjResearchTopicEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjResearchTopicEN.updUser = $("#hidUserId").val();// 修改人
        pobjResearchTopicEN.memo = this.memo;// 备注
    }

    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public CombineResearchTopicCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.TopicName_q != "") {
                strWhereCond += ` And ${clsResearchTopicEN.con_TopicName} like '% ${this.TopicName_q}%'`;
            }
            //if (this.TopicProposePeople_q != "") {
            //    strWhereCond += ` And ${clsResearchTopicEN.con_UserName} like '% ${this.TopicProposePeople_q}%'`;
            //}

            //判断角色 
            //管理员
            if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {

                strWhereCond += " And topicId in (select topicId from RTUserRela where UserID ='" + clsPubSessionStorage.GetSession_UserId() + "')";

                //如果不属于私有教育班那么执行下面的sql
                if (clsPublocalStorage.Getid_CurrEduCls() != "00000050") {
                    //strWhereCond += " And shareId <> '01'";
                    //strWhereCond += " or id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "' And topicId in (select topicId from RTUserRela where UserID ='" + clsPubSessionStorage.GetSession_UserId() + "')";
                    strWhereCond += " or id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
                    //strWhereCond += " And shareId <> '01'";
                }

                if (this.TopicName_q != "") {
                    strWhereCond += ` And ${clsResearchTopicEN.con_TopicName} like '% ${this.TopicName_q}%'`;
                }
                //if (this.TopicProposePeople_q != "") {
                //    strWhereCond += ` And ${clsResearchTopicEN.con_UserName} like '% ${this.TopicProposePeople_q}%'`;
                //}

                strWhereCond += " [exclude]or [/exclude]";
                //  $("#btnDelRecord").show();
            }
            else if (clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                //strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
                strWhereCond += ` And topicId in (select topicId from RTUserRela where UserID = '${clsPubSessionStorage.GetSession_UserId()}')`;
                //教师
                // $("#btnDelRecord").hide();
                //strWhereCond += ` And ${clsResearchTopicEN.con_id_CurrEduCls} = '${clsPublocalStorage.Getid_CurrEduCls()}'`;
                //可以查看所有；
            }
            else {
                //学生； //教师
                //  $("#btnDelRecord").hide();
                //查询关系表数据 已经主题数据来显示主题方法；
                strWhereCond += ` And topicId in (select topicId from RTUserRela where UserID = '${clsPubSessionStorage.GetSession_UserId()}')`;
            }
            strWhereCond += ' order by topicName Asc';

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

        if (clsString.IsNullOrEmpty(ResearchTopic_QUDIEx.topicId) == true) {
            alert("请选择需要修改的主题！");
            return;
        }
        var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
        const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
        this.UpdateRecord(ResearchTopic_QUDIEx.topicId);
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
    /* 函数功能:把类对象的属性内容显示到界面上
   注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
    如果在设置数据库时,就应该一级字段在前,二级字段在后
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
    <param name = "pobjResearchTopicEN">表实体类对象</param>
  */
    public GetDataFromResearchTopicClass(pobjResearchTopicEN: clsResearchTopicEN) {
        this.topicId = pobjResearchTopicEN.topicId;// 主题编号
        this.topicName = pobjResearchTopicEN.topicName;// 栏目主题
        this.topicContent = pobjResearchTopicEN.topicContent;// 主题内容
        this.topicProposePeople = pobjResearchTopicEN.topicProposePeople;// 主题提出人
        this.shareId = pobjResearchTopicEN.shareId;//
        this.orderNum = pobjResearchTopicEN.orderNum;// 序号
        this.updDate = pobjResearchTopicEN.updDate;// 修改日期
        this.updUser = pobjResearchTopicEN.updUser;// 修改人
        this.memo = pobjResearchTopicEN.memo;// 备注
    }
    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnOKUpd;
        try {
            //判断session是否失效
            if (clsPubSessionStorage.GetSession_UserId() != "") {
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
            $('#divLoading').hide();
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", false);
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }


    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public UpdateRecordSave(): Promise<boolean> {
        this.DivName = "divUpdateRecordSave";
        var objResearchTopicEN: clsResearchTopicEN = new clsResearchTopicEN();
        objResearchTopicEN.topicId = this.KeyId;
        this.PutDataToResearchTopicClass(objResearchTopicEN);
        objResearchTopicEN.sf_UpdFldSetStr = objResearchTopicEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objResearchTopicEN.topicId == "" || objResearchTopicEN.topicId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = ResearchTopic_UpdateRecordAsync(objResearchTopicEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
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



    /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
 */
    public async btnQuery_Click(strListDiv: string) {
        const responseText = await this.GetTopicData();
    }


    /* 删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
  */
    public async btnDelInRecord_Click(strKeyId: string) {
        try {
            //判断登录用户在主题用户中的角色是什么如果是成员，那么则不可以删除主题；
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strWhere = " 1=1 And topicId='" + strKeyId + "' And userId='" + strUserId + "'";
            var ObjRTUserRelaEN: clsRTUserRelaEN = await RTUserRela_GetFirstObjAsync(strWhere);
            if (ObjRTUserRelaEN != null) {
                if (ObjRTUserRelaEN.topicUserRoleId == "0003") {
                    //成员角色；
                    var strMsg: string = `您在当前的主题中角色是成员，不能删除主题`;
                    alert(strMsg);
                    return;
                }
                else {
                    const responseText1 = await this.DelRecordEx(strKeyId);
                    //树形数据源；
                    const responseText2 = await this.GetTopicData();

                }
            }
            else {
                //成员角色；
                var strMsg: string = `您不是当前的主题成员，不能删除主题`;
                alert(strMsg);
                return;
            }



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
                        ResearchTopic_QUDIEx.topicId = "";
                        $('#hidTopicRelaId').val(ResearchTopic_QUDIEx.topicId);
                    }
                    else {
                        var strInfo: string = `当前主题已包含相关关系数据，不能删除!`;
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


    //public btnDetailInTab_Click(strKeyId: string) {

    //    if (strKeyId == "") {
    //        alert("请选择需要查看的记录！");
    //        return;
    //    }
    //    this.ResearchTopicDetailRecord(strKeyId);
    //}
    /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
    //public ResearchTopicDetailRecord(strTopicId: string) {

    //    this.KeyId = strTopicId;
    //    var strUserId = $("#hidUserId").val();
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = ResearchTopic_GetObjByTopicIdAsync(strTopicId).then((jsonData) => {
    //                var objResearchTopicEN: clsResearchTopicEN = <clsResearchTopicEN>jsonData;
    //                // //显示当前数据；
    //                $("#txtTopicNameDetail").html(objResearchTopicEN.topicName);
    //                $("#txtTopicContentDetail").html(objResearchTopicEN.topicContent);
    //                $("#txtMemoDetail").html(objResearchTopicEN.memo);
    //            });
    //        }
    //        catch (e) {
    //            console.error(e);
    //            var strMsg: string = `当前无数据获取失败,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}



    /* 添加新记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
  */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";

        var objResearchTopicEN: clsResearchTopicEN = new clsResearchTopicEN();
        this.PutDataToResearchTopicClass(objResearchTopicEN);
        try {
            var strTopicId = await ResearchTopic_AddNewRecordWithReturnKeyAsync(objResearchTopicEN);
            if (strTopicId != "") {

                //这里默认添加一个用户数据 ，作为主题用户关系的组长；
                this.AddNewTopicAndRecordSaveUserRela(strTopicId);


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
            return true;//一定要有一个返回值，否则会出错！
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

    /* 添加主题同时把用户作为组长存放到主题用户关系表*/
    public async AddNewTopicAndRecordSaveUserRela(strTopicId: string) {

        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var objRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
        this.PutDataToRTUserRelaClassWhere(objRTUserRelaEN, strTopicId);
        //获取缓存色码表；
        var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
        try {
            // 同一主题 同一用户 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
            const responseText = await RTUserRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个用户！`;
                //alert(strMsg);
                console.log("同一主题不能重复添加同一个用户！");
                // return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await RTUserRela_AddNewRecordAsync(objRTUserRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                RTUserRela_ReFreshCache(ResearchTopic_QUDIEx.topicId);
                var strInfo: string = `添加成功!`;
                $('#lblResult40').val(strInfo);
                //隐藏用户框
                HideDialogFour();
                //显示信息框
                alert(strInfo);
                const responseText3 = await this.btnReOrder_Click();
                //获取色码数据
                const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
                    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;

                });
                //添加完成后把根据用户排序号得到色码表 样式把样式更新到主题用户关系表；
                var strWhereUserRela = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
                //const responseText = await RTUserRela_GetFirstObjAsync(strWhere);
                const responseText = await RTUserRela_GetFirstObjAsync(strWhereUserRela).then((jsonData) => {
                    var objRTUserRelaEN: clsRTUserRelaEN = <clsRTUserRelaEN>jsonData;

                    if (objRTUserRelaEN != null) {
                        //得到用户排序号
                        var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRTUserRelaEN.orderNum);
                        if (Objgs_Color != null) {
                            //得到色码

                            var objUpdateRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
                            objUpdateRTUserRelaEN.mId = objRTUserRelaEN.mId;
                            objUpdateRTUserRelaEN.colorId = Objgs_Color.colorId;
                            objUpdateRTUserRelaEN.userBgColor = Objgs_Color.colorCode;//用户背景色码；

                            objUpdateRTUserRelaEN.sf_UpdFldSetStr = objUpdateRTUserRelaEN.updFldString;//设置哪些字段被修改(脏字段)

                            const responseText = RTUserRela_UpdateRecordAsync(objUpdateRTUserRelaEN).then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    return true;
                                }
                                else {
                                    var strInfo: string = `修改用户色码不成功!`;
                                    alert(strInfo);
                                    console.log("修改用户色码不成功");
                                    return false;
                                }
                            });
                        }
                    }
                })
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
        }
        return true;//一定要有一个返回值，否则会出错！
    }
    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjRTUserRelaEN">数据传输的目的类对象</param>
   */
    public PutDataToRTUserRelaClassWhere(pobjRTUserRelaEN: clsRTUserRelaEN, strTopicId: string) {
        var strUserId = $("#hidUserId").val();
        pobjRTUserRelaEN.topicId = strTopicId;// 主题编号
        pobjRTUserRelaEN.userId = strUserId;// 用户ID
        pobjRTUserRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjRTUserRelaEN.topicUserRoleId = "0002";//组成
        pobjRTUserRelaEN.updUser = strUserId;// 修改人
        pobjRTUserRelaEN.orderNum = 30;
        pobjRTUserRelaEN.colorId = ""; //获取不同色码
        pobjRTUserRelaEN.memo = this.memo;// 备注
    }
    //获取不同色码
    public getRandomColor(): string {
        return '#' + ('00000' + (Math.random() * 0x1000000 << 0).toString(16)).substr(-6);
    }
    /*
重序
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
*/
    public async btnReOrder_Click() {

        try {
            var objOrderByData: clsOrderByData = new clsOrderByData();
            var jsonObject =
            {
                "topicId": ResearchTopic_QUDIEx.topicId,
            };
            var jsonStr: string = JSON.stringify(jsonObject);
            objOrderByData.ClassificationFieldValueLst = jsonStr;
            const responseRederBy = await RTUserRela_ReOrderAsync(objOrderByData);
            RTUserRela_ReFreshCache(ResearchTopic_QUDIEx.topicId);
        }
        catch (e) {
            var strMsg: string = `重序出错。错误:${e}.(In ${clsStackTrace.GetCurrClassFunction()})`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return;
        }
        //绑定主题用户关系；
        this.BindGv_vRTUserRela();
    }






    //确定选择的用户 并添加到关系表中
    public async btnUserRecordInTab_Click(strkeyId: string) {
        ////主题用户角色下拉框
        //const ddl_TopicUserRole_q = await this.BindDdl_TopicUserRole_q("ddlTopicUserRole_q");
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

        var strPaperId = $("#hidPaperId").val();
        var strUserId = $("#hidUserIdKey").val();
        var objRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
        this.PutDataToRTUserRelaClass(objRTUserRelaEN);
        //获取缓存色码表；
        var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
        try {
            // 同一主题 同一用户 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + ResearchTopic_QUDIEx.topicId + "' And userId = '" + strUserId + "'";
            const responseText = await RTUserRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个用户！`;
                //alert(strMsg);
                console.log("同一主题不能重复添加同一个用户！");
            }

            const responseText2 = await RTUserRela_AddNewRecordAsync(objRTUserRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                RTUserRela_ReFreshCache(ResearchTopic_QUDIEx.topicId);
                var strInfo: string = `添加成功!`;
                $('#lblResult40').val(strInfo);
                //隐藏用户框
                HideDialogFour();
                //显示信息框
                alert(strInfo);
                const responseText3 = await this.btnReOrder_Click();
                //获取色码数据
                const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
                    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;

                });
                //添加完成后把根据用户排序号得到色码表 样式把样式更新到主题用户关系表；
                var strWhereUserRela = " 1 = 1 And topicId = '" + ResearchTopic_QUDIEx.topicId + "' And userId = '" + strUserId + "'";
                //const responseText = await RTUserRela_GetFirstObjAsync(strWhere);
                const responseText = await RTUserRela_GetFirstObjAsync(strWhereUserRela).then((jsonData) => {
                    var objRTUserRelaEN: clsRTUserRelaEN = <clsRTUserRelaEN>jsonData;

                    if (objRTUserRelaEN != null) {
                        //得到用户排序号
                        var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRTUserRelaEN.orderNum);
                        if (Objgs_Color != null) {
                            //得到色码

                            var objUpdateRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
                            objUpdateRTUserRelaEN.mId = objRTUserRelaEN.mId;
                            objUpdateRTUserRelaEN.colorId = Objgs_Color.colorId;
                            objUpdateRTUserRelaEN.userBgColor = Objgs_Color.colorCode;//用户背景色码；

                            objUpdateRTUserRelaEN.sf_UpdFldSetStr = objUpdateRTUserRelaEN.updFldString;//设置哪些字段被修改(脏字段)
                            const responseText = RTUserRela_UpdateRecordAsync(objUpdateRTUserRelaEN).then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    return true;
                                }
                                else {
                                    var strInfo: string = `修改用户色码不成功!`;
                                    alert(strInfo);
                                    console.log("修改用户色码不成功");
                                    return false;
                                }

                            });



                        }
                    }
                })
                this.BindGv_vRTUserRela();
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
    //添加完成后把根据用户排序号得到色码表 样式把样式更新到主题用户关系表；


    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjRTUserRelaEN">数据传输的目的类对象</param>
   */
    public PutDataToRTUserRelaClass(pobjRTUserRelaEN: clsRTUserRelaEN) {

        var strPaperId = $("#hidPaperId").val();
        var strUserIdKey = $("#hidUserIdKey").val();
        var strUserId = $("#hidUserId").val();

        pobjRTUserRelaEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
        pobjRTUserRelaEN.topicId = ResearchTopic_QUDIEx.topicId;// 主题编号
        pobjRTUserRelaEN.userId = strUserIdKey;// 用户ID
        pobjRTUserRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjRTUserRelaEN.topicUserRoleId = this.TopicUserRole_q;
        pobjRTUserRelaEN.orderNum = 30;
        pobjRTUserRelaEN.colorId = "";
        pobjRTUserRelaEN.updUser = strUserId;// 修改人
        pobjRTUserRelaEN.memo = this.memo;// 备注
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



    //////////////////////用户列表条件
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
    * 获取当前页序号 -------用户
   */
    public get CurrPageIndexUser(): number {
        return $("#hidCurrPageIndexUser").val();
    }
    /*
    * 设置当前页序号  -------用户
   */
    public set CurrPageIndexUser(value: number) {
        $("#hidCurrPageIndexUser").val(value);
    }

    //////////////////////////////////////////////所有数据列表排序功能///////////////////////////////////////////////////

    /* 主题用户关系表头排序
*/
    public async SortByRTUser(strSortByFld: string) {
        if (this.hidSortvRTUserRelaBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvRTUserRelaBy.indexOf("Asc") >= 0) {
                this.hidSortvRTUserRelaBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvRTUserRelaBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvRTUserRelaBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vRTUserRela();
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
    //小组成员
    public async liUserClick() {
        try {
            const gvResultPaper = await this.BindGv_vRTUserRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题用户列表不成功,${e}.`;
            alert(strMsg);
        }
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
*  修改主题用户角色
*/
    public set RtUserRoleId(value: string) {
        $("#ddlRtUserRole").val(value);
    }
    /*
    * 修改主题用户角色
    */
    public get RtUserRoleId(): string {
        return $("#ddlRtUserRole").val();
    }

    /*
    * 论文标题
   */
    public get PaperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }






    /*
    * 设置取消按钮的标题
   */
    public set btnCancel(value: string) {
        $("#btnCancel").html(value);
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnOKUpd(value: string) {
        $("#btnOKUpd").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd(): string {
        return $("#btnOKUpd").html();
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
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortResearchTopicBy(value: string) {
        $("#hidSortResearchTopicBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortResearchTopicBy(): string {
        return $("#hidSortResearchTopicBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return $("#hidUserId").val();
    }
    /*
    * 设置关键字的值
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
    * 备注
   */
    public set memo(value: string) {
        $("#txtMemo").val(value);
    }
    /*
    * 备注
   */
    public get memo(): string {
        return $("#txtMemo").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set OpType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 序号
   */
    public set orderNum(value: number) {
        $("#txtOrderNum").val(value);
    }
    /*
    * 序号
   */
    public get orderNum(): number {
        return $("#txtOrderNum").val();
    }
    /*
    * 主题内容
   */
    public set topicContent(value: string) {
        $("#txtTopicContent").val(value);
    }
    /*
    * 主题内容
   */
    public get topicContent(): string {
        return $("#txtTopicContent").val();
    }
    /*
    * 主题编号
   */
    public set topicId(value: string) {
        $("#txtTopicId").val(value);
    }
    /*
    * 主题编号
   */
    public get topicId(): string {
        return $("#txtTopicId").val();
    }
    /*
    * 栏目主题
   */
    public set topicName(value: string) {
        $("#txtTopicName").val(value);
    }
    /*
    * 栏目主题
   */
    public get topicName(): string {
        return $("#txtTopicName").val();
    }
    /*
    * 栏目主题
   */
    public get TopicName_q(): string {
        return $("#txtTopicName_q").val();
    }
    /*
    * 主题提出人
   */
    public set topicProposePeople(value: string) {
        $("#txtTopicProposePeople").val(value);
    }
    /*
    * 主题提出人
   */
    public get topicProposePeople(): string {
        return $("#txtTopicProposePeople").val();
    }
    /*
    * 主题提出人
   */
    public get TopicProposePeople_q(): string {
        return $("#txtTopicProposePeople_q").val();
    }
    /*
    * 修改日期
   */
    public set updDate(value: string) {
        $("#txtUpdDate").val(value);
    }
    /*
    * 修改日期
   */
    public get updDate(): string {
        return $("#txtUpdDate").val();
    }
    /*
    * 修改人
   */
    public set updUser(value: string) {
        $("#txtUpdUser").val(value);
    }
    /*
    * 修改人
   */
    public get updUser(): string {
        return $("#txtUpdUser").val();
    }



    //添加 研究计划
    public btnAddResearchPlan_Click() {

        var strKeyId = ResearchTopic_QUDIEx.topicId;// $('#hidTopicRelaId').val();
        var strId_CurrEduCls = $("#hidId_CurrEduCls").val();
        if (strKeyId == "") {
            alert("请选择数据！");
            return;
        }
        else {
            //存放选择id
            //var strObjectiveType = "02";
            //$('#hidObjectiveTypeId').val(strObjectiveType);

            //xadmin.open('添加研究计划', '../GraduateEduPublicPage/AddResearchPlan?topicId=' + strKeyId + '&Id_CurrEduCls=' + strId_CurrEduCls, 1200, 800);
            xadminopen2('添加研究计划', '../GraduateEduPublicPage/AddResearchPlan?topicId=' + strKeyId + '&Id_CurrEduCls=' + strId_CurrEduCls, 1200, 800);
        }
    }
}