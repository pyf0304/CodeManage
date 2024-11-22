import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsgs_PaperAttentionEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
import { clsgs_PaperGroupEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { clsPaperSubAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js";
import { clsPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js";
import { clsSectionEN } from "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js";
import { clsvgs_PaperAttentionEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperAttentionEN.js";
import { clsvPaperSubViewpointEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { clsgs_TagsTypeEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TagsTypeEN.js";
import { clsgs_TagsEN } from "../TS/L0_Entity/InteractManage/clsgs_TagsEN.js";
import { clsSysVoteEN } from "../TS/L0_Entity/InteractManage/clsSysVoteEN.js";
import { clsvqa_AnswerEN } from "../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js";
import { clsvqa_QuestionsEN } from "../TS/L0_Entity/InteractManage/clsvqa_QuestionsEN.js";
import { clsSubViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { gs_PaperAttention_DelRecordAsync, gs_PaperAttention_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { gs_PaperGroup_AddNewRecordWithReturnKeyAsync, gs_PaperGroup_GetObjLst_Cache, gs_PaperGroup_ReFreshCache, gs_PaperGroup_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js";
import { PaperSubAttachment_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubAttachmentWApi.js";
import { PaperSubViewpoint_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js";
import { Section_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js";
import { vgs_PaperAttention_GetObjLstAsync, vgs_PaperAttention_GetObjLst_Cache, vgs_PaperAttention_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js";
import { vPaperSubViewpoint_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { gs_TagsType_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TagsTypeWApi.js";
import { gs_Tags_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsgs_TagsWApi.js";
import { SysVote_AddNewRecordAsync, SysVote_GetObjLstAsync, SysVote_GetRecCountByCondAsync, SysVote_IsExistRecordAsync } from "../TS/L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { vqa_Answer_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js";
import { vqa_Questions_GetObjLstAsync } from "../TS/L3_ForWApi/InteractManage/clsvqa_QuestionsWApi.js";
import { SubViewpointType_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { vPaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { vPaperSubViewpointEx_GetSubViewpointTypeNumObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperSubViewpointExWApi.js";
import { vgs_PaperAttentionEx_GetPaperIdNumObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsvgs_PaperAttentionExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsSysPara4WebApi2 } from "../TS/PubFun/clsSysPara4WebApi2.js";
declare function doDownLoad(filepath, filename): void;
declare function layui_Alert(iconKey, strMsg): void;
declare var $;
declare var window;
/* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PaperAttention {
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


                const gvResult1 = await this.PaperAttentionTree();

                var strPaperId = $("#hidPaperId").val();
                const ddl_SectionId_q = await this.BindDdl_SectionId("ddlSectionId_q", strPaperId);
                const ddl_SubViewpointTypeId_q = await this.BindDdl_SubViewpointTypeId("ddlSubViewpointTypeId_q");

                const ddl_PaperGroupId = await this.BindDdl_PaperGroupId("ddlPaperGroupId");


                const gvResult2 = await this.li_PaperAttentionTab_Click();

                //const gvResult2 = await this.Bind_PaperSubViewpoint();

                //const gvResult3 = await this.Bind_PaperQA();

                $("#divLoading").hide();
                //刷新缓存
                vPaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.Getid_CurrEduCls());
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

    public async li_PaperAttentionTab_Click() {



        //如果是点击了树菜单、或者是刷新，那么需要做样式控制；
        //首先要去掉ul下 li a 样式
        //$("#myTab li a").removeClass();
        //$("#myTab li").removeClass();
        //判断根据序号显示不同的数据源

        var strPaperId = $("#hidPaperId").val()
        if (strPaperId != "") {
            var strnum = $("#hidTabNum").val();
            switch (strnum) {
                case "1":
                    const gvResult1 = await this.Bind_PaperSubViewpoint();
                    break;
                case "2":
                    const gvResult2 = await this.Bind_PaperQA();
                    break;
                case "3":
                    const gvResult3 = await this.Bind_PaperTags();
                    break;
                case "4":
                    const gvResult4 = await this.Bind_TeaQA();
                    break;
                default:
                    const gvResult = await this.Bind_PaperSubViewpoint();
                    break;
            }
            //if (strnum == "1") {
            //    //$("#liUser").addClass("active");
            //    //$("#liUser a").addClass("active");

            //    //$("#li_User ").addClass("in active show");

            //    //主题用户关系；
            //    const gvResult = await this.Bind_PaperSubViewpoint();
            //}
            //else if (strnum == "2") {
            //    //$("#liPaper").addClass("active");
            //    //$("#liPaper a").addClass("active");

            //    //$("#li_Paper ").addClass("in active show");
            //    //主题论文关系；
            //    const gvResult = await this.Bind_PaperQA();
            //}
            //else if (strnum == "3") {
            //    //$("#liPaper").addClass("active");
            //    //$("#liPaper a").addClass("active");

            //    //$("#li_Paper ").addClass("in active show");
            //    //主题论文关系；
            //    const gvResult = await this.Bind_TeaQA();
            //}
            //else {
            //    const gvResult = await this.Bind_PaperSubViewpoint();
            //}
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


    //论文组
    public async BindDdl_PaperGroupId(ddlPaperGroupId: string) {
        //var strWhereCond = " updUser='" + clsPubSessionStorage.GetSession_UserId() + "' order by updDate Asc";
        var strUserId = clsPublocalStorage.GetUserId();
        var objDdl = document.getElementById(ddlPaperGroupId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlPaperGroupId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        try {

            //var arrObjLst_Sel: Array<clsgs_PaperGroupEN> = await gs_PaperGroup_GetObjLstAsync(strWhereCond);
            var arrObjLst_Sel: Array<clsgs_PaperGroupEN> = await gs_PaperGroup_GetObjLst_Cache(strUserId);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsgs_PaperGroupEN.con_PaperGroupId]);
            clsCommonFunc4Web.BindDdl_ObjLst(ddlPaperGroupId, arrObjLst_Sel, clsgs_PaperGroupEN.con_PaperGroupId, clsgs_PaperGroupEN.con_PaperGroupName, "论文组");
            console.log("完成BindDdl_gs_PaperGroupId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    /*查询*/
    public async btnQueryEx_Click() {

        try {
            //const gvResult = await this.Bind_PaperSubViewpoint();
            const gvResult = await this.li_PaperAttentionTab_Click();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }




    //关注论文树
    public async PaperAttentionTree() {

        var strUserId = clsPublocalStorage.GetUserId();
        var strWhereCond1 = " updUser='" + strUserId + "'";
        var strWhereCond2 = " userId='" + strUserId + "'";
        //声明主题变量

        var arrgs_PaperGroupObjLst: Array<clsgs_PaperGroupEN> = [];
        var arrvgs_PaperAttentionObjLst0: Array<clsvgs_PaperAttentionEN> = [];
        var arrvgs_PaperIdNumObjLst: Array<clsvgs_PaperAttentionEN> = [];
        var arrvgs_PaperAttentionObjLst: Array<clsvgs_PaperAttentionEN> = [];

        //const responseObjLst1 = await gs_PaperGroup_GetObjLstAsync(strWhereCond1).then((jsonData) => {
        //    arrgs_PaperGroupObjLst = <Array<clsgs_PaperGroupEN>>jsonData;
        //});
        arrgs_PaperGroupObjLst = await gs_PaperGroup_GetObjLst_Cache(strUserId);

        if ($("#hidMyResearch").val() == 1) {
            arrvgs_PaperIdNumObjLst = await vgs_PaperAttentionEx_GetPaperIdNumObjLstAsync(strWhereCond1);

            var arrPaperId = "";
            if (arrvgs_PaperIdNumObjLst.length > 0) {
                for (var i = 0; i < arrvgs_PaperIdNumObjLst.length; i++) {
                    arrPaperId += arrvgs_PaperIdNumObjLst[i].paperId + ",";
                }
                arrPaperId = arrPaperId.substr(0, arrPaperId.length - 1);

                var strWhereCond3 = " paperId in(" + arrPaperId + ") and userId='" + clsPublocalStorage.GetUserId() + "'";

                arrvgs_PaperAttentionObjLst0 = await vgs_PaperAttention_GetObjLstAsync(strWhereCond3);
            }


        } else {
            //const responseObjLst3 = await vgs_PaperAttention_GetObjLstAsync(strWhereCond2).then((jsonData) => {
            //    arrvgs_PaperAttentionObjLst0 = <Array<clsvgs_PaperAttentionEN>>jsonData;

            //});
            arrvgs_PaperAttentionObjLst0 = await vgs_PaperAttention_GetObjLst_Cache(strUserId);
        }


        var strhtml = "";
        if (arrgs_PaperGroupObjLst.length > 0) {
            for (var i = 0; i < arrgs_PaperGroupObjLst.length; i++) {
                strhtml += '<li class="li">';

                strhtml += '<a style="float:left;" href="#" id="' + arrgs_PaperGroupObjLst[i].paperGroupId + '" class="main" title="分组:' + arrgs_PaperGroupObjLst[i].paperGroupName + '" onclick=main_Click("' + arrgs_PaperGroupObjLst[i].paperGroupId + '")>' + arrgs_PaperGroupObjLst[i].paperGroupName + '</a>';

                strhtml += '<a href="#" onclick=UpdateGroupName_Click("' + arrgs_PaperGroupObjLst[i].paperGroupId + '","' + arrgs_PaperGroupObjLst[i].paperGroupName + '")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="编辑组名" ></i></a>';
                //strhtml += '<span onclick=UpMove_Click("' + arrgs_PaperGroupObjLst[i].paperGroupId + '","' + arrgs_PaperGroupObjLst[i].paperGroupName + '")><i class="layui-icon layui-icon-up" style="font-size:16px; color: #0080ff;" title="上移组名" ></i></span>';
                //strhtml += '<span onclick=DownMove_Click("' + arrgs_PaperGroupObjLst[i].paperGroupId + '","' + arrgs_PaperGroupObjLst[i].paperGroupName + '")><i class="layui-icon layui-icon-down" style="font-size:16px; color: #0080ff;" title="下移组名" ></i></span>';



                //strhtml += '<a href="#" onclick=UpdateGroupName_Click("' + arrgs_PaperGroupObjLst[i].paperGroupId + '") data-toggle="modal" data-target="#myModal"><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #f6941d;" title="维护组名" ></i></a>';
                //strhtml += '<ul class="submenu" style="display: block;">';
                strhtml += '<ul class="submenu" id="ul' + arrgs_PaperGroupObjLst[i].paperGroupId + '">';


                arrvgs_PaperAttentionObjLst = arrvgs_PaperAttentionObjLst0.filter(x => x.paperGroupId == arrgs_PaperGroupObjLst[i].paperGroupId);
                //循环数据
                for (var j = 0; j < arrvgs_PaperAttentionObjLst.length; j++) {

                    var strPaperId = arrvgs_PaperAttentionObjLst[j].paperId;

                    var strPaperTitle = arrvgs_PaperAttentionObjLst[j].paperTitle
                    if (strPaperTitle.length > 20) {
                        strPaperTitle = strPaperTitle.substr(0, 20) + "...";
                    }

                    strhtml += '<li id="' + strPaperId + '" onclick=btnSelectPaper("' + strPaperId + '",' + arrvgs_PaperAttentionObjLst[j].paperAttentionId + ',"' + clsPublocalStorage.Getid_CurrEduCls() + '")>';
                    //默认存放第一条数据显示；
                    //判断存放的id控件是否为空；

                    if ($("#hidPaperId").val() == "") {
                        //存放Id
                        $("#hidPaperId").val(strPaperId);
                        //$("#hidid_CurrEduCls").val(arrvgs_PaperAttentionObjLst[j].id_CurrEduCls);

                        strhtml += '<a style="float:left;" href="#" title="' + arrvgs_PaperAttentionObjLst[j].paperTitle + '" class="selected">' + strPaperTitle + '</a>';

                    }
                    else {
                        strhtml += '<a style="float:left;" href="#" title="' + arrvgs_PaperAttentionObjLst[j].paperTitle + '">' + strPaperTitle + '</a>';

                    }
                    strhtml += '<div>';
                    strhtml += '<a style="float:left;" href="#" onclick=UpdatePaperGroup_Click("' + arrvgs_PaperAttentionObjLst[j].paperAttentionId + '","' + arrvgs_PaperAttentionObjLst[j].paperGroupId + '")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="调整论文组" ></i></a>';

                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="badge badge-primary" title="论文子观点' + arrvgs_PaperAttentionObjLst[j].subVCount + '条">' + arrvgs_PaperAttentionObjLst[j].subVCount + '</span>';
                    strhtml += '&nbsp;&nbsp;<span class="badge badge-success" title="论文答疑' + arrvgs_PaperAttentionObjLst[j].paperQCount + '条" >' + arrvgs_PaperAttentionObjLst[j].paperQCount + '</span>';
                    strhtml += '&nbsp;&nbsp;<span class="badge badge-warning" title="论文标注' + arrvgs_PaperAttentionObjLst[j].tagsCount + '条">' + arrvgs_PaperAttentionObjLst[j].tagsCount + '</span>';
                    strhtml += '&nbsp;&nbsp;<span class="badge badge-info" title="教师提问' + arrvgs_PaperAttentionObjLst[j].teaQCount + '条" >' + arrvgs_PaperAttentionObjLst[j].teaQCount + '</span>';


                    //strhtml += '<a href="#" onclick=UpdatePaperSubV_Click("' + arrvgs_PaperAttentionObjLst[j].paperId + '","' + arrvgs_PaperAttentionObjLst[j].id_CurrEduCls + '","02")><i class="layui-icon layui-icon-list" style="font-size:16px; color: #219167;" title="pdf查看论文子观点" ></i></a>';
                    strhtml += '</div>';

                    strhtml += '</li>';
                }
                strhtml += '</ul>';
                strhtml += '</li>';
            }

        }
        $("#TreeBind").html(strhtml);
    }

    /* 
  在数据表里删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
 */
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要取消的关注！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelRecord(lngKeyId);
            const responseText2 = await this.PaperAttentionTree();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `关注不成功. ${e}.`;
            alert(strMsg);
        }
    }


    /* 
   根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
  */
    public DelRecord(lngPaperAttentionId: number) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = gs_PaperAttention_DelRecordAsync(lngPaperAttentionId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        var strInfo: string = `取消关注成功!`;
                        //显示信息框
                        alert(strInfo);
                        var strUserId = clsPublocalStorage.GetUserId();
                        vgs_PaperAttention_ReFreshThisCache(strUserId);//刷新论文关注
                    }
                    else {
                        var strInfo: string = `关注不成功!`;
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
                var strMsg: string = `关注不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }


    public async SubmitUpdateGroup_Click() {
        var strCommandText: string = $('#btnEditGroup').html();
        try {
            switch (strCommandText) {
                case "确认添加":
                    const responseText1 = await this.AddGroup_Click();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText2 = await this.UpdateGroup_Click();
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
            //取消提交按钮不可用状态
            //$("#divLoading").hide();
            //$("#btnOKUpd").attr("disabled", false);

        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }
    //添加组名
    public async AddGroup_Click() {
        try {

            var strUserId = clsPubSessionStorage.GetSession_UserId();

            var objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
            objgs_PaperGroupEN.paperGroupName = $("#txtPaperGroupName").val();
            objgs_PaperGroupEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
            objgs_PaperGroupEN.updUser = strUserId;// 修改用户Id

            var strPaperGroupId = await gs_PaperGroup_AddNewRecordWithReturnKeyAsync(objgs_PaperGroupEN);
            if (strPaperGroupId != "") {
                //刷新缓存
//                const objOrderByData: clsOrderByData = [
//order                ];
                //gs_PaperGroup_ReOrderAsync(strUserId);//刷新论文组
                gs_PaperGroup_ReFreshCache(strUserId);//刷新论文组
                const responseText2 = await this.PaperAttentionTree();
                layui_Alert(1, "组名添加成功!");
                console.log("组名添加成功！");
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `组名添加不成功. ${e}.`;
            alert(strMsg);
        }
    }
    //修改组名
    public async UpdateGroup_Click() {
        try {

            var strPaperGroupId = $("#hidPaperGroupId").val();
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
            objgs_PaperGroupEN.paperGroupId = strPaperGroupId;
            objgs_PaperGroupEN.paperGroupName = $("#txtPaperGroupName").val();
            objgs_PaperGroupEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
            objgs_PaperGroupEN.updUser = strUserId;// 修改用户Id

            objgs_PaperGroupEN.sf_UpdFldSetStr = objgs_PaperGroupEN.updFldString;//设置哪些字段被修改(脏字段)
            if (objgs_PaperGroupEN.paperGroupId == "" || objgs_PaperGroupEN.paperGroupId == undefined) {
                throw "关键字不能为空!";
            }

            const responseText = await gs_PaperGroup_UpdateRecordAsync(objgs_PaperGroupEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //刷新缓存
                gs_PaperGroup_ReFreshCache(strUserId);//刷新论文组
                const responseText2 = await this.PaperAttentionTree();
                layui_Alert(1, "组名修改成功!");
                console.log("组名修改成功！");

            }
            else {
                layui_Alert(3, "组名修改失败!");
                console.log("组名修改失败！");
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `组名修改不成功. ${e}.`;
            alert(strMsg);
        }
    }

    //提交调整关注的论文组
    public async SubmitPaperGroup_Click() {
        try {

            var strPaperAttentionId = $("#hidPaperAttentionId").val();

            var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
            objgs_PaperAttentionEN.paperAttentionId = strPaperAttentionId;
            objgs_PaperAttentionEN.paperGroupId = $('#ddlPaperGroupId').val();

            objgs_PaperAttentionEN.sf_UpdFldSetStr = objgs_PaperAttentionEN.updFldString;//设置哪些字段被修改(脏字段)
            if (objgs_PaperAttentionEN.paperAttentionId == 0 || objgs_PaperAttentionEN.paperAttentionId == undefined) {
                throw "关键字不能为空!";
            }

            const responseText = await gs_PaperAttention_UpdateRecordAsync(objgs_PaperAttentionEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //刷新缓存
                var strUserId = clsPublocalStorage.GetUserId();
                vgs_PaperAttention_ReFreshThisCache(strUserId);//刷新论文关注

                const responseText2 = await this.PaperAttentionTree();
                layui_Alert(1, "调整论文组成功!");
                console.log("调整论文组成功！");

            }
            else {
                layui_Alert(3, "调整论文组失败!");
                console.log("调整论文组失败！");
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `调整论文组不成功. ${e}.`;
            alert(strMsg);
        }
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






    //绑定论文子观点内容
    public async Bind_PaperSubViewpoint() {
        //var strListDiv: string = this.mstrListDiv;
        var strUserId = $("#hidUserId").val();
        //var strPaperRWId = $("#hidPaperRWId").val();

        var strWhereCond2 = this.CombinevPaperSubViewpointCondition3();
        var strWhereCond3 = this.CombinevPaperSubViewpointCondition3();
        var strWhereCond4 = this.CombinevPaperSubViewpointCondition4();
        var strWhereCond5 = " 1=1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";

        //var strWhereCond6 = ` ${clsvSysVoteEN.con_TableKey} = '${strPaperRWId}' And ${clsvSysVoteEN.con_UpdUser} = '${strUserId}'`;
        //var strWhereCond6 = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='02' and pubParentId='" + strPaperRWId + "'";
        var strWhereCond6 = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='02' ";
        //var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页


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

            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();

            //const responseText2 = SubViewpointType_GetObjLstAsync(strWhereCond2).then((jsonData) => {
            //    arrSubViewpointTypeObjLst = <Array<clsSubViewpointTypeEN>>jsonData;
            //});
            const responseText2 = vPaperSubViewpointEx_GetSubViewpointTypeNumObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvPaperSubVTypeNumObjLst = <Array<clsvPaperSubViewpointEN>>jsonData;
            });

            //const responseRecCount = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond3).then((jsonData) => {
            //    this.RecCount = jsonData;
            //});
            //this.hidSortvPaperSubViewpointBy = "orderNum Asc";
            //var objPagerPara: stuPagerPara = {
            //    pageIndex: intCurrPageIndex,
            //    pageSize: this.pageSize,
            //    whereCond: strWhereCond3,
            //    orderBy: this.hidSortvPaperSubViewpointBy
            //};
            //const responseObjLst3 = await vPaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //    arrvPaperSubViewpointObjLst2 = <Array<clsvPaperSubViewpointEN>>jsonData;
            //});
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

            var strhtml = "";
            var cateid: number = 0;
            var cateid_: number = 0;
            var intJ: number = 0;


            //$('#tbList tr').remove();

            strhtml += '<tr cate-id="' + cateid + '" ><td>';

            //strhtml += '<div style="float:left;"><h3>' + intJ + '.' + arrSubViewpointTypeObjLst[j].subViewpointTypeName + '</h3></div>';
            strhtml += '<div style="float:left;"><h3>论文子观点</h3></div>';
            strhtml += '<div style="float:right;">';
            //if ($("#hidType").val() == "01") {
            //    //if ($("#hidIsSubmit").val() != "true") {
            //    //strhtml += '<button title="添加子观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '");><i class="layui-icon"></i></button>';
            //    strhtml += '<button title="添加子观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click();><i class="layui-icon"></i></button>';
            //    //strhtml += '<button title="重新排列序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnReOrder_Click("' + strsubTypeId + '")><i class="layui-icon">&#xe669;</i></button>';
            //    //}
            //}
            strhtml += '<a style="float:left;" href="#" onclick=UpdatePaperSubV_Click("01")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="维护论文子观点" ></i>维护论文子观点</a>';
            strhtml += '<a href="#" onclick=UpdatePaperSubV_Click("02")><i class="layui-icon layui-icon-list" style="font-size:16px; color: #219167;" title="查看论文子观点" ></i>查看论文子观点</a>';

            strhtml += '</div></td></tr>';

            for (var j = 0; j < arrvPaperSubVTypeNumObjLst.length; j++) {
                cateid++;
                intJ++;
                var fid: number = 0;
                var strsubTypeId: string = arrvPaperSubVTypeNumObjLst[j].subViewpointTypeId;
                //先创建子模块类型
                //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';

                strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><th>';

                strhtml += '<div style="float:left;font-size:22px;font-weight:bold;">' + intJ + '.' + arrvPaperSubVTypeNumObjLst[j].subViewpointTypeName + '</div>';
                strhtml += '<span style="float:left;" class="layui-badge" id="SubVTypeCount">' + arrvPaperSubVTypeNumObjLst[j].memo + '</span>';
                //strhtml += '<div style="float:right;">';
                //if ($("#hidType").val() == "01") {
                //    if ($("#hidIsSubmit").val() != "true") {
                //        strhtml += '<button title="添加子观点" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewRecord_Click("' + strsubTypeId + '");><i class="layui-icon"></i></button>';
                //        strhtml += '<button title="重新排列序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnReOrder_Click("' + strsubTypeId + '")><i class="layui-icon">&#xe669;</i></button>';
                //    }
                //}

                strhtml += '</th></tr>';
                //<td>' + cateid + ' </td>
                //strhtml += '<td class="td-manage"></td>';


                //子类型数据
                var strSubViewpointId = "";
                cateid_ = cateid;
                var intK: number = 0;

                arrvPaperSubViewpointObjLst = arrvPaperSubViewpointObjLst2.filter(x => x.subViewpointTypeId == strsubTypeId);


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


                    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" ><td>';


                    strhtml += '&nbsp;&nbsp;<span class="color3">' + intK + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i>【' + arrvPaperSubViewpointObjLst[k].attitudesName + '】' + arrvPaperSubViewpointObjLst[k].subViewpointContent + '';
                    //根据子观点id 得到附件
                    if (arrvPaperSubViewpointObjLst[k].sectionName != "") {
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="layui-icon x-show" status="true">&#xe623;</i>【论文节】' + arrvPaperSubViewpointObjLst[k].sectionName + '';
                    }
                    var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;

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

                    //if ($("#hidType").val() == "01") {
                    //    if ($("#hidIsSubmit").val() == "true") {
                    //        strhtml += '&nbsp;&nbsp;<img src="../img/vote.png" width = "20px" height = "18px" title = "点赞数" >&nbsp;赞' + arrvPaperSubViewpointObjLst[k].okCount;
                    //        //strhtml += '&nbsp;&nbsp;评论数:<a href="#" onclick="btnShowAppraise_Click("' + strSubViewpointId + '")">' + arrvPaperSubViewpointObjLst[k].appraiseCount + '</a>';
                    //        strhtml += '&nbsp;&nbsp;评论数:' + arrvPaperSubViewpointObjLst[k].appraiseCount;
                    //        if (arrvPaperSubViewpointObjLst[k].score != 0) {
                    //            strhtml += '&nbsp;&nbsp;综合评分:' + arrvPaperSubViewpointObjLst[k].score;
                    //        }
                    //        if (arrvPaperSubViewpointObjLst[k].teaScore != 0) {
                    //            strhtml += '&nbsp;&nbsp;教师评分:' + arrvPaperSubViewpointObjLst[k].teaScore;
                    //        }
                    //        if (arrvPaperSubViewpointObjLst[k].stuScore != 0) {
                    //            strhtml += '&nbsp;&nbsp;学生评分:' + arrvPaperSubViewpointObjLst[k].stuScore;
                    //        }

                    //        //strhtml += '&nbsp;&nbsp;<button class="layui-btn layui-btn layui-btn-xs" onclick = "btnAddAppraise_Click("' + strSubViewpointId + '")" > <i class="layui-icon" >&#xe642; </i>添加评论</button >';
                    //    } else {

                    //        //strhtml += '<input id="txt_OrderNum' + cateid + '" type="text" class="layui-input" style="width:40px;" name="order" value="' + arrvPaperSubViewpointObjLst[k].orderNum + '" onBlur=btnUpdateOrderNum_Click("' + strSubViewpointId + '","txt_OrderNum' + cateid + '");>';
                    //        //上移
                    //        strhtml += '<button title="上移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '")><i class="iconfont">&#xe6a5;</i></button>';
                    //        //下移
                    //        strhtml += '<button title="下移序号" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownMove_Click("' + strSubViewpointId + '",' + arrvPaperSubViewpointObjLst[k].orderNum + ',"' + strsubTypeId + '")><i class="iconfont">&#xe6a6;</i></button>';

                    //        //编辑
                    //        strhtml += '<button title="编辑子观点" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + strSubViewpointId + '")><i class="layui-icon">&#xe642;</i></button>';
                    //        //删除
                    //        strhtml += '<button title="删除子观点" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + strSubViewpointId + '")><i class="layui-icon">&#xe640;</i></button>';
                    //    }
                    //} else if ($("#hidType").val() == "02") {

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

                    //}




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

        var strWhereCond = " 1 =1 and updUser='" + clsPubSessionStorage.GetSession_UserId() + "' and tableKey=" + strSubViewpointId;
        try {
            const responseText = await SysVote_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                //alert(strMsg);
                layui_Alert(3, strMsg);
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
                        var strMsg: string = `已点赞!`;
                        layui_Alert(1, strMsg);
                        this.Bind_PaperSubViewpoint();
                    }
                    else {
                        var strMsg: string = `点赞不成功!`;
                        //alert(strInfo);
                        layui_Alert(2, strMsg);

                    }

                });
            }
            else {
                var strInfo: string = `点赞不成功!`;
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



    //绑定论文答疑
    public async Bind_PaperQA() {

        //问题
        var arrvqa_QuestionsObjLst: Array<clsvqa_QuestionsEN> = [];
        //绑定答案数据
        var arrvqa_AnswerObjLst0: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst1: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst2: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst3: Array<clsvqa_AnswerEN> = [];

        //var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        var strUserId = clsPubSessionStorage.GetSession_UserId();
        //var strid_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        var strPaperId = $("#hidPaperId").val();

        //var strQuestionsId = this.questionsId;

        //if ($('#hidOrderbyId').val() == "1") {
        //    //全部评论
        //    strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
        //    strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
        //} else if ($('#hidOrderbyId').val() == "2") {
        //    //个人评论
        //    strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
        //    strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
        //} else if ($('#hidOrderbyId').val() == "3") {
        //最新评论
        var strWhereCond = "1=1 and questionsTypeId='01' and paperId='" + strPaperId + "' order by updDate Desc";

        strWhereCond1 = " parentId='root' and questionsTypeId='01' and  paperId='" + strPaperId + "' order by updDate Desc";
        strWhereCond2 = " parentId<>'root' and questionsTypeId='01' and  paperId='" + strPaperId + "' order by updDate Desc";
        //}
        //var strVateWhereCond = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='12' and id_CurrEduCls='" + strid_CurrEduCls + "'";

        //var strQWhereCond = "questionsId='" + strQuestionsId + "'";
        try {
            const responseText0 = await vqa_Questions_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvqa_QuestionsObjLst = <Array<clsvqa_QuestionsEN>>jsonData;
            });

            const responseText1 = await vqa_Answer_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvqa_AnswerObjLst0 = <Array<clsvqa_AnswerEN>>jsonData;
            });
            const responseText2 = await vqa_Answer_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvqa_AnswerObjLst2 = <Array<clsvqa_AnswerEN>>jsonData;
            });

            //const responseText3 = await SysVote_GetObjLstAsync(strVateWhereCond).then((jsonData) => {
            //    arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            //});



            //var objqa_Questions: clsqa_QuestionsEN = await qa_Questions_GetFirstObjAsync(strQWhereCond);
            //if (objqa_Questions != null) {
            //    $('#Questions_Name').html(objqa_Questions.questionsContent);
            //}


            var strhtml = "";
         
                strhtml += '<div style="text-align:right; margin-right:20px;"><button title="添加问题" class="layui-btn layui-btn-normal layui-btn-xs" onclick=btnAddQA_Click("01");> <i class="layui-icon" ></i>添加问题</button></div>';
            
            var varQNum = 0;
            //$('#J_ShortComment div').remove();
            for (var y = 0; y < arrvqa_QuestionsObjLst.length; y++) {
                varQNum++;
                strhtml += '<div class="comment-title" style="margin-top:5px;">';
                strhtml += '<p class="comment-all" id="Questions_Name">' + varQNum + '、' + arrvqa_QuestionsObjLst[y].questionsContent;
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="解答" class="layui-btn layui-btn layui-btn-xs" onclick=btnQAnswer_Click("' + arrvqa_QuestionsObjLst[y].paperId + '","' + arrvqa_QuestionsObjLst[y].questionsId + '","' + arrvqa_QuestionsObjLst[y].questionsTypeId + '","' + arrvqa_QuestionsObjLst[y].id_CurrEduCls + '")><i class="layui-icon">&#xe6b2;</i></button>';
                strhtml += '</p>';
                strhtml += '</div>';
                strhtml += '<div id="J_ShortComment">';
                arrvqa_AnswerObjLst1 = arrvqa_AnswerObjLst0.filter(x => x.questionsId == arrvqa_QuestionsObjLst[y].questionsId);
                var varANum = 0;
                for (var i = 0; i < arrvqa_AnswerObjLst1.length; i++) {
                    varANum++;
                    strhtml += '<div class="comment" >';
                    strhtml += '<div class="common-avatar J_User" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block">';
                    if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:red;" > 题主：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    } else {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment-username J_User">' + varANum + '楼</span></p>';
                    //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                    //回复区

                    arrvqa_AnswerObjLst3 = arrvqa_AnswerObjLst2.filter(x => x.parentId == arrvqa_AnswerObjLst1[i].answerId);
                    if (arrvqa_AnswerObjLst3.length > 0) {
                        strhtml += '<div class="reply J_ReplyBlock">';
                        for (var j = 0; j < arrvqa_AnswerObjLst3.length; j++) {

                            strhtml += '<div class="reply-block">';

                            strhtml += '<div class="reply-content">';
                            if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst3[j].updUser) {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" style="color:red;"> 题主(' + arrvqa_AnswerObjLst3[j].userName + ')</b>：</span>';
                            } else {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User">' + arrvqa_AnswerObjLst3[j].userName + '</b>：</span>';
                            }
                            strhtml += '' + arrvqa_AnswerObjLst3[j].answerContent + '</div>';



                            strhtml += '<div class="reply-operate reply-operate--hot">'

                            //var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrvqa_AnswerObjLst3[j].answerId);
                            //if (objLike == null) {
                            //    strhtml += '<span class="J_Vote reply-operate-item reply-up" onclick=btnAddVote_Click("' + arrvqa_AnswerObjLst3[j].answerId + '","' + arrvqa_AnswerObjLst3[j].updUser + '")>赞<i>' + arrvqa_AnswerObjLst3[j].voteCount + '</i></span >';
                            //} else {
                            //    strhtml += '<span class="J_Vote reply-operate-item reply-up operate-visited" >已赞<i>' + arrvqa_AnswerObjLst3[j].voteCount + '</i></span >';
                            //}

                            strhtml += '<span class="J_Vote reply-operate-item reply-up operate-visited" >赞<i>' + arrvqa_AnswerObjLst3[j].voteCount + '</i></span >';

                            strhtml += '<i class="reply-dot">·</i><span>' + arrvqa_AnswerObjLst3[j].updDate + '</span>';
                            //if (strUserId == arrvqa_AnswerObjLst3[j].updUser) {
                            //    strhtml += '<i class="reply-dot reply-operate-report" >·</i>';
                            //    strhtml += '<span class="reply-operate-item reply-operate-report J_ReplyReport" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst3[j].answerId + '")>删除</span>';
                            //}
                            strhtml += '</div>';


                            strhtml += '</div>';

                        }
                        strhtml += '</div>';
                    }
                    ///评论区
                    strhtml += '<div class="comment-operate J_CommentOperate clearfix">';

                    //var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrvqa_AnswerObjLst1[i].answerId);
                    //if (objLike == null) {
                    //    strhtml += '<span class="J_Vote comment-operate-item comment-operate-up" onclick=btnAddVote_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].updUser + '")>赞<i>' + arrvqa_AnswerObjLst1[i].voteCount + '</i></span>';
                    //} else {
                    //    strhtml += '<span class="J_Vote comment-operate-item comment-operate-up operate-visited">已赞<i>' + arrvqa_AnswerObjLst1[i].voteCount + '</i></span>';
                    //}
                    strhtml += '<span class="J_Vote comment-operate-item comment-operate-up operate-visited">赞<i>' + arrvqa_AnswerObjLst1[i].voteCount + '</i></span>';

                    //strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>回复</span>';
                    strhtml += '</div>';

                    //if (strUserId == arrvqa_AnswerObjLst1[i].updUser) {

                    //    strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';
                    //}
                    strhtml += '</div></div>';
                }
                strhtml += ' </div>';

            }

            //$("#J_ShortComment").append(strhtml);
            //$("#J_ShortComment").html(strhtml);
            $("#J_Short").html(strhtml);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取数据不成功,${e}.`;
            alert(strMsg);
        }
    }



    //绑定论文标注
    public async Bind_PaperTags() {

        var strWhereCond = "1=1 and paperId='" + $("#hidPaperId").val() + "' order by updDate Asc";
        var strUserId = clsPubSessionStorage.GetSession_UserId()

        var arrgs_TagsObjLst: Array<clsgs_TagsEN> = [];
        var arrgs_TagsObjLst0: Array<clsgs_TagsEN> = [];
        var arrgs_TagsTypeObjLst: Array<clsgs_TagsTypeEN> = [];

        try {
            //获取用户缓存数据
            var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
            //获取标注数据
            const responseText1 = await gs_Tags_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_TagsObjLst = <Array<clsgs_TagsEN>>jsonData;
            });
            const responseText2 = await gs_TagsType_GetObjLstAsync("1=1").then((jsonData) => {
                arrgs_TagsTypeObjLst = <Array<clsgs_TagsTypeEN>>jsonData;
            });
            var strhtml = "";
            strhtml += '<div style="text-align:right; margin-right:20px; margin-top:10px;"><button title="添加标注" class="layui-btn layui-btn-normal layui-btn-xs" onclick=btnAddPaperTags_Click();> <i class="layui-icon" ></i>添加标注</button></div>';
            if (arrgs_TagsObjLst.length > 0) {
                strhtml += '<div class="info" id="infoTages">';
                //strhtml += '<div class="title btn-1">';
                //strhtml += '<a href="#" title="pdf标注">pdf标注</a>';
                //strhtml += '</div><ul class="artlist">';
                strhtml += '<ul class="artlist">';

                var k = 0;
                for (var i = 0; i < arrgs_TagsObjLst.length; i++) {
                    k++;
                    var strTagsId = arrgs_TagsObjLst[i].tagsId;
                    strhtml += '<li>';

                    strhtml += '<div id="T' + strTagsId + '" style="text-align:left; float:left; width:65%;">';
                    strhtml += '<span class="rowtit color1">' + k + '.</span>';

                    var objTagsType = arrgs_TagsTypeObjLst.find(x => x.tagsTypeId == arrgs_TagsObjLst[i].tagsTypeId);
                    if (objTagsType != null) {
                        strhtml += '<span class="rowtit color3">[' + objTagsType.tagsTypeName + ']</span>';
                    }

                    strhtml += '<span class="title btn-2"><a href="#" onclick=btnShowTags_Click("' + strTagsId + '",' + arrgs_TagsObjLst[i].pdfPageNum + ',"' + arrgs_TagsObjLst[i].pdfContent + '"); class="abstract-text">' + arrgs_TagsObjLst[i].tagsContent + '</a></span>';
                    strhtml += '&nbsp;<span  style="font-style:italic;" class="rowtit color2" title="第' + arrgs_TagsObjLst[i].pdfPageNum + '页标记">P' + arrgs_TagsObjLst[i].pdfPageNum + '</span>';
                    strhtml += '</div>';


                    strhtml += '<div style="text-align:right; float:right; width:34%;">';
                    //if (arrgs_TagsObjLst[i].updUser == strUserId) {
                    //    //编辑
                    //    strhtml += '<button title="编辑标注" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateTags_Click("' + strTagsId + '")><i class="layui-icon">&#xe642;</i></button>';
                    //    //删除
                    //    strhtml += '<button title="删除标注" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelTags_Click("' + strTagsId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                    //}

                    var objUser = arrUsers.find(x => x.userId == arrgs_TagsObjLst[i].updUser);
                    if (objUser != null) {
                        var strUpdDate = arrgs_TagsObjLst[i].updDate;
                        strUpdDate = strUpdDate.substr(2, strUpdDate.length - 11);


                        strhtml += '&nbsp;<span class="rowtit color4">' + objUser.userName + '/' + strUpdDate + '</span>&nbsp;&nbsp;';

                        //strhtml += '&nbsp;&nbsp;&nbsp;(' + objUser.userName + '&nbsp;/&nbsp;' + arrgs_TagsObjLst[i].updDate + ')&nbsp;&nbsp;&nbsp;';
                    }
                    strhtml += '</div>';

                    strhtml += '</li>';
                    //strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div>';
                    //strhtml += '<li> <div style="border-bottom: 1px solid #eee;"></div></li>';
                }
                strhtml += '<li>';
                strhtml += '<div style="text-align:left; float:left; width:99%;">';
                for (var j = 0; j < arrgs_TagsTypeObjLst.length; j++) {
                    arrgs_TagsObjLst0 = arrgs_TagsObjLst.filter(x => x.tagsTypeId == arrgs_TagsTypeObjLst[j].tagsTypeId);
                    if (arrgs_TagsObjLst0.length > 0) {
                        strhtml += arrgs_TagsTypeObjLst[j].tagsTypeName + ':' + arrgs_TagsObjLst0.length + '个标注;&nbsp;';
                    }
                }
                strhtml += '</div>';
                strhtml += '</li>';
                strhtml += '</ul>';
                strhtml += '</div>';

                //拼接；
                $("#Paper_Tags").html(strhtml);


            }
            //else {
            //    $("#list_Tags").hide();
            //}
            console.log("完成BindGv_gs_Tags!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //绑定教师提问
    public async Bind_TeaQA() {

        //问题
        var arrvqa_QuestionsObjLst: Array<clsvqa_QuestionsEN> = [];
        //绑定答案数据
        var arrvqa_AnswerObjLst0: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst1: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst2: Array<clsvqa_AnswerEN> = [];
        var arrvqa_AnswerObjLst3: Array<clsvqa_AnswerEN> = [];

        //var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        var strWhereCond1 = "";
        var strWhereCond2 = "";

        //var strUserId = clsPubSessionStorage.GetSession_UserId();
        //var strid_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        var strPaperId = $("#hidPaperId").val();

        //var strQuestionsId = this.questionsId;

        //if ($('#hidOrderbyId').val() == "1") {
        //    //全部评论
        //    strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
        //    strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' order by updDate Asc";
        //} else if ($('#hidOrderbyId').val() == "2") {
        //    //个人评论
        //    strWhereCond1 = " parentId='root' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
        //    strWhereCond2 = " parentId<>'root' and  questionsId='" + strQuestionsId + "' and updUser='" + strUserId + "' order by updDate Asc";
        //} else if ($('#hidOrderbyId').val() == "3") {
        //最新评论
        var strWhereCond = "1=1 and questionsTypeId='02' and paperId='" + strPaperId + "' order by orderNum Asc";

        strWhereCond1 = " parentId='root' and questionsTypeId='02' and answerTypeId='01' and  paperId='" + strPaperId + "' and  isSubmit=1 order by updDate Desc";
        strWhereCond2 = " parentId<>'root' and questionsTypeId='02' and answerTypeId='01' and  paperId='" + strPaperId + "' and  isSubmit=1 order by updDate Desc";
        //}
        //var strVateWhereCond = " 1 =1 and updUser='" + strUserId + "' and voteTypeId='12' and id_CurrEduCls='" + strid_CurrEduCls + "'";

        //var strQWhereCond = "questionsId='" + strQuestionsId + "'";
        try {
            const responseText0 = await vqa_Questions_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvqa_QuestionsObjLst = <Array<clsvqa_QuestionsEN>>jsonData;
            });

            const responseText1 = await vqa_Answer_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                arrvqa_AnswerObjLst0 = <Array<clsvqa_AnswerEN>>jsonData;
            });
            const responseText2 = await vqa_Answer_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                arrvqa_AnswerObjLst2 = <Array<clsvqa_AnswerEN>>jsonData;
            });

            //const responseText3 = await SysVote_GetObjLstAsync(strVateWhereCond).then((jsonData) => {
            //    arrSysVoteObjLst = <Array<clsSysVoteEN>>jsonData;
            //});



            //var objqa_Questions: clsqa_QuestionsEN = await qa_Questions_GetFirstObjAsync(strQWhereCond);
            //if (objqa_Questions != null) {
            //    $('#Questions_Name').html(objqa_Questions.questionsContent);
            //}


            var strhtml = "";
            var varQNum = 0;
            const strRoleName = clsPubSessionStorage.GetSession_RoleName();
            if (strRoleName.indexOf("学生") == -1) {
                strhtml += '<div style="text-align:right; margin-right:20px;"><button title="添加问题" class="layui-btn layui-btn-normal layui-btn-xs" onclick=btnAddQA_Click("02");> <i class="layui-icon" ></i>添加问题</button></div>';
            }
            //$('#J_ShortComment div').remove();
            for (var y = 0; y < arrvqa_QuestionsObjLst.length; y++) {
                varQNum++;
                strhtml += '<div class="comment-title" style="margin-top:5px;">';
                strhtml += '<p class="comment-all" id="Questions_Name">' + varQNum + '、' + arrvqa_QuestionsObjLst[y].questionsContent;
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="解答" class="layui-btn layui-btn layui-btn-xs" onclick=btnQAnswer_Click("' + arrvqa_QuestionsObjLst[y].paperId + '","' + arrvqa_QuestionsObjLst[y].questionsId + '","' + arrvqa_QuestionsObjLst[y].questionsTypeId + '","' + arrvqa_QuestionsObjLst[y].id_CurrEduCls + '")><i class="layui-icon">&#xe6b2;</i></button>';
                strhtml += '</p>';
                strhtml += '</div>';
                strhtml += '<div id="J_ShortComment">';
                arrvqa_AnswerObjLst1 = arrvqa_AnswerObjLst0.filter(x => x.questionsId == arrvqa_QuestionsObjLst[y].questionsId);
                var varANum = 0;
                for (var i = 0; i < arrvqa_AnswerObjLst1.length; i++) {
                    varANum++;
                    strhtml += '<div class="comment" >';
                    strhtml += '<div class="common-avatar J_User" ><img src="../img/avatar5.png" width="100%" height="100%"></div>';
                    strhtml += '<div class="comment-block">';
                    if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst1[i].updUser) {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" style="color:red;" > 题主：' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    } else {
                        strhtml += '<p class="comment-user" ><span class="comment-username J_User" >' + arrvqa_AnswerObjLst1[i].userName + '</span>';
                    }
                    strhtml += '<span class="comment-time">' + arrvqa_AnswerObjLst1[i].updDate + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment-username J_User">' + varANum + '楼</span></p>';
                    //strhtml += '<div class="comment-content J_CommentContent">评分：' + arrvPaperAppraiseObjLst[i].AppraiseScore + '</div>';
                    strhtml += '<div class="comment-content J_CommentContent">' + arrvqa_AnswerObjLst1[i].answerContent + '</div>';

                    //回复区

                    arrvqa_AnswerObjLst3 = arrvqa_AnswerObjLst2.filter(x => x.parentId == arrvqa_AnswerObjLst1[i].answerId);
                    if (arrvqa_AnswerObjLst3.length > 0) {
                        strhtml += '<div class="reply J_ReplyBlock">';
                        for (var j = 0; j < arrvqa_AnswerObjLst3.length; j++) {

                            strhtml += '<div class="reply-block">';

                            strhtml += '<div class="reply-content">';
                            if ($("#hidQuestionsUser").val() == arrvqa_AnswerObjLst3[j].updUser) {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User" style="color:red;"> 题主(' + arrvqa_AnswerObjLst3[j].userName + ')</b>：</span>';
                            } else {
                                strhtml += '<span class="reply-user"><b class="reply-user-nick J_User">' + arrvqa_AnswerObjLst3[j].userName + '</b>：</span>';
                            }
                            strhtml += '' + arrvqa_AnswerObjLst3[j].answerContent + '</div>';



                            strhtml += '<div class="reply-operate reply-operate--hot">'

                            //var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrvqa_AnswerObjLst3[j].answerId);
                            //if (objLike == null) {
                            //    strhtml += '<span class="J_Vote reply-operate-item reply-up" onclick=btnAddVote_Click("' + arrvqa_AnswerObjLst3[j].answerId + '","' + arrvqa_AnswerObjLst3[j].updUser + '")>赞<i>' + arrvqa_AnswerObjLst3[j].voteCount + '</i></span >';
                            //} else {
                            //    strhtml += '<span class="J_Vote reply-operate-item reply-up operate-visited" >已赞<i>' + arrvqa_AnswerObjLst3[j].voteCount + '</i></span >';
                            //}

                            strhtml += '<span class="J_Vote reply-operate-item reply-up operate-visited" >赞<i>' + arrvqa_AnswerObjLst3[j].voteCount + '</i></span >';

                            strhtml += '<i class="reply-dot">·</i><span>' + arrvqa_AnswerObjLst3[j].updDate + '</span>';
                            //if (strUserId == arrvqa_AnswerObjLst3[j].updUser) {
                            //    strhtml += '<i class="reply-dot reply-operate-report" >·</i>';
                            //    strhtml += '<span class="reply-operate-item reply-operate-report J_ReplyReport" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst3[j].answerId + '")>删除</span>';
                            //}
                            strhtml += '</div>';


                            strhtml += '</div>';

                        }
                        strhtml += '</div>';
                    }
                    ///评论区
                    strhtml += '<div class="comment-operate J_CommentOperate clearfix">';

                    //var objLike = arrSysVoteObjLst.find(x => x.tableKey == arrvqa_AnswerObjLst1[i].answerId);
                    //if (objLike == null) {
                    //    strhtml += '<span class="J_Vote comment-operate-item comment-operate-up" onclick=btnAddVote_Click("' + arrvqa_AnswerObjLst1[i].answerId + '","' + arrvqa_AnswerObjLst1[i].updUser + '")>赞<i>' + arrvqa_AnswerObjLst1[i].voteCount + '</i></span>';
                    //} else {
                    //    strhtml += '<span class="J_Vote comment-operate-item comment-operate-up operate-visited">已赞<i>' + arrvqa_AnswerObjLst1[i].voteCount + '</i></span>';
                    //}
                    strhtml += '<span class="J_Vote comment-operate-item comment-operate-up operate-visited">赞<i>' + arrvqa_AnswerObjLst1[i].voteCount + '</i></span>';

                    //strhtml += '<span class="J_Reply comment-operate-item comment-operate-reply" id="J_Reply" onclick=btnReplyAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>回复</span>';
                    strhtml += '</div>';

                    //if (strUserId == arrvqa_AnswerObjLst1[i].updUser) {

                    //    strhtml += '<div class="J_Report comment-report" onclick=btnDelAnswer_Click("' + arrvqa_AnswerObjLst1[i].answerId + '")>删除</div>';
                    //}
                    strhtml += '</div></div>';
                }
                strhtml += ' </div>';

            }

            //$("#J_ShortComment").append(strhtml);
            //$("#J_ShortComment").html(strhtml);
            $("#J_Short_TeaQA").html(strhtml);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取数据不成功,${e}.`;
            alert(strMsg);
        }
    }


    /*
    * 节Id
   */
    public get SectionId_q(): string {
        return $("#ddlSectionId_q").val();
    }


    /*
   * 类型Id
  */
    public get SubViewpointTypeId_q(): string {
        return $("#ddlSubViewpointTypeId_q").val();
    }

}