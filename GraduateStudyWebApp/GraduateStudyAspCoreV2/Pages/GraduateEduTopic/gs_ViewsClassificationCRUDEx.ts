
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_ViewsClassificationCRUDEx
表名:gs_ViewsClassification(01120777)
生成代码版本:2020.12.17.1
生成日期:2020/12/17 15:52:17
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { gs_ViewsClassificationCRUD } from "../PagesBase/GraduateEduTopic/gs_ViewsClassificationCRUD.js";
import { gs_ViewsClassification_Edit } from "../PagesBase/GraduateEduTopic/gs_ViewsClassification_Edit.js";
import { clsgs_ViewsClassificationEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js";
import { clsRTConceptRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTConceptRelaEN.js";
import { clsRTSysSkillRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js";
import { clsRTSysSocialRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js";
import { clsRTTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js";
import { clsRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js";
import { clsvRTConceptRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js";
import { clsvRTSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTSysSkillEN.js";
import { clsvRTSysSocialRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTSysSocialRelaEN.js";
import { clsvRTTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTTopicObjectiveRelaEN.js";
import { clsvRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js";
import { gs_ViewsClassification_DelRecordAsync, gs_ViewsClassification_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js";
import { RTConceptRela_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTConceptRelaWApi.js";
import { RTSysSkillRela_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js";
import { RTSysSocialRela_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js";
import { RTTopicObjectiveRela_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js";
import { RTViewpointRela_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js";
import { vRTConceptRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTConceptRelaWApi.js";
import { vRTSysSkill_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSkillWApi.js";
import { vRTSysSocialRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js";
import { vRTTopicObjectiveRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTTopicObjectiveRelaWApi.js";
import { vRTViewpointRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindDdl_ObjLst, BindTab, GetCheckedKeyIds, GetFirstCheckedKeyId } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";

import { gs_ViewsClassification_EditEx } from "./gs_ViewsClassification_EditEx.js";
declare function ShowDialog_gs_ViewsClassification(strOpType): void;
declare function HideDialog_gs_ViewsClassification(): void;
declare function layui_Alert(str1, str2): void;
declare function GetAllFunctionMethod(): void;
declare function HideDialogClassification(): void;


declare var $;
declare var window;
/* gs_ViewsClassificationCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_ViewsClassificationCRUDEx extends gs_ViewsClassificationCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortgs_ViewsClassificationBy: string = "classificationId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.Page_Load();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "gs_ViewsClassification":
                alert('该类没有绑定该函数：[this.BindGv_gs_ViewsClassification_Cache]！');
                //this.BindGv_gs_ViewsClassification_Cache();
                break;
        }
    }

    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: gs_ViewsClassificationCRUDEx = new gs_ViewsClassificationCRUDEx();
        var objPage_Edit: gs_ViewsClassification_EditEx = new gs_ViewsClassification_EditEx(objPage);
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage_Edit.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
            case "UpdateRecordInTab":            //修改记录InTab
                objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
                break;
            case "DelRecordInTab":   //删除记录InTab 
                objPage.btnDelRecordInTab_Click(strKeyId);
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = GetCheckedKeyIds();
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
                var strMsg = '命令:' + strCommandName + "在函数(gs_ViewsClassificationCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }



    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            gs_ViewsClassification_Edit.id_CurrEduCls_Static = clsPublocalStorage.id_CurrEduCls;
            //if (this.bolIsInitShow == false)  //
            //{
            //    this.objPager.InitShow(this.divName4Pager);
            //    this.bolIsInitShow = true;  //
            //}
            await this.ClassificationTree();


        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }

    //论文组
    public async BindDdl_ClassificationId(ddlClassificationId: string) {
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strWhereCond = " 1 = 1 and topicId='" + strTopicId + "' order by updDate Asc";
        var objDdl = document.getElementById(ddlClassificationId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlClassificationId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        try {

            var arrObjLst_Sel: Array<clsgs_ViewsClassificationEN> = await gs_ViewsClassification_GetObjLstAsync(strWhereCond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsgs_ViewsClassificationEN.con_ClassificationId]);
            BindDdl_ObjLst(ddlClassificationId, arrObjLst_Sel, clsgs_ViewsClassificationEN.con_ClassificationId, clsgs_ViewsClassificationEN.con_ClassificationName, "观点分类");
            console.log("完成BindDdl_gs_ViewsClassificationId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //分类树
    public async ClassificationTree() {
        var strViewsTabNum = $("#hidViewsTabNum").val();
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strWhereCond: string = " 1 = 1 and topicId='" + strTopicId + "' order by updDate Asc";

        //获取观点分类
        var arrgs_ViewsClassificationObjLst: Array<clsgs_ViewsClassificationEN> = [];
        const responseObjLst = await gs_ViewsClassification_GetObjLstAsync(strWhereCond).then((jsonData) => {
            arrgs_ViewsClassificationObjLst = <Array<clsgs_ViewsClassificationEN>>jsonData;

        });


        var arrvRTViewpointRelaObjLst0: Array<clsvRTViewpointRelaEN> = [];
        var arrvRTViewpointRelaObjLst: Array<clsvRTViewpointRelaEN> = [];

        //根据tab页的选择显示的观点也不同
        switch (strViewsTabNum) {
            case "1":
                var strWhereCond1: string = " 1 = 1 and topicId='" + strTopicId + "' and userTypeId='01'";
                const responseObjLst1 = await vRTViewpointRela_GetObjLstAsync(strWhereCond1).then((jsonData) => {
                    arrvRTViewpointRelaObjLst0 = <Array<clsvRTViewpointRelaEN>>jsonData;
                });
                break;
            case "2":
                var strWhereCond2: string = " 1 = 1 and topicId='" + strTopicId + "' and userTypeId='02'";
                const responseObjLst2 = await vRTViewpointRela_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                    arrvRTViewpointRelaObjLst0 = <Array<clsvRTViewpointRelaEN>>jsonData;
                });
                break;
            case "3":
                const responseObjLst3 = await vRTConceptRela_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrvRTConceptRelaObjLst: Array<clsvRTConceptRelaEN> = <Array<clsvRTConceptRelaEN>>jsonData;
                    arrvRTViewpointRelaObjLst0 = arrvRTConceptRelaObjLst.map(this.GetRTVByConcep);
                });

                break;
            case "4":
                var strWhereCond4: string = " 1 = 1 and topicId='" + strTopicId + "' and objectiveType='01'";
                const responseObjLst4 = await vRTTopicObjectiveRela_GetObjLstAsync(strWhereCond4).then((jsonData) => {
                    var arrvRTTopicObjectiveRelaObjLst: Array<clsvRTTopicObjectiveRelaEN> = <Array<clsvRTTopicObjectiveRelaEN>>jsonData;
                    arrvRTViewpointRelaObjLst0 = arrvRTTopicObjectiveRelaObjLst.map(this.GetRTVByTopicObjective);
                });
                break;
            case "5":
                var strWhereCond5: string = " 1 = 1 and topicId='" + strTopicId + "' and objectiveType='02'";
                const responseObjLst5 = await vRTTopicObjectiveRela_GetObjLstAsync(strWhereCond5).then((jsonData) => {
                    var arrvRTTopicObjectiveRelaObjLst: Array<clsvRTTopicObjectiveRelaEN> = <Array<clsvRTTopicObjectiveRelaEN>>jsonData;
                    arrvRTViewpointRelaObjLst0 = arrvRTTopicObjectiveRelaObjLst.map(this.GetRTVByTopicObjective);
                });
                break;
            case "6":
                const responseObjLst6 = await vRTSysSkill_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrvRTSysSkillObjLst: Array<clsvRTSysSkillEN> = <Array<clsvRTSysSkillEN>>jsonData;
                    arrvRTViewpointRelaObjLst0 = arrvRTSysSkillObjLst.map(this.GetRTVBySysSkill);
                });
                break;
            case "7":
                const responseObjLst7 = await vRTSysSocialRela_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrvRTSysSocialRelaObjLst: Array<clsvRTSysSocialRelaEN> = <Array<clsvRTSysSocialRelaEN>>jsonData;
                    arrvRTViewpointRelaObjLst0 = arrvRTSysSocialRelaObjLst.map(this.GetRTVBySysSocial);
                });
                break;
        }


        var strhtml = "";
        strhtml += '<li class="li">';
        strhtml += '<a href="#" id="1000000000" class="main" onclick=btnClearClassification_Click("1000000000")>全部分类<span class="badge badge-success" title="观点数' + arrvRTViewpointRelaObjLst0.length + '条" >' + arrvRTViewpointRelaObjLst0.length + '</span></a>';
        strhtml += '</li>';
        for (var i = 0; i < arrgs_ViewsClassificationObjLst.length; i++) {
            var strClassificationId = arrgs_ViewsClassificationObjLst[i].classificationId;
            var strClassificationName = arrgs_ViewsClassificationObjLst[i].classificationName;

            arrvRTViewpointRelaObjLst = arrvRTViewpointRelaObjLst0.filter(x => x.classificationId == strClassificationId);
            strhtml += '<li class="li" style="margin-left:15px;">';

            strhtml += '<a style="float:left;" href="#" id="' + strClassificationId + '" class="main" onclick=btnClassification_Click("' + strClassificationId + '","' + strClassificationName + '")>' + strClassificationName + '<span class="badge badge-success" title="观点数' + arrvRTViewpointRelaObjLst.length + '条" >' + arrvRTViewpointRelaObjLst.length + '</span></a>';
            strhtml += '<div style="height:22px;">';
            strhtml += '<a style="float:left;margin-top:4px;" href="#" onclick=btnUpdategs_ViewsClassification_Click("' + strClassificationId + '")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="编辑分类" ></i></a>';
            if (clsPublocalStorage.roleId == "00620001") {
                strhtml += '<a style="margin-top:4px;" href="#" onclick=btnDelgs_ViewsClassification_Click("' + strClassificationId + '")><i class="layui-icon layui-icon-delete" style="font-size:16px; color: #0080ff;" title="删除分类" ></i></a>';
            }
            //strhtml += '<a href="#" onclick=btnArrange_ViewsClassification_Click("' + strClassificationId + '","' + strClassificationName + '")><i class="layui-icon layui-icon-cols" style="font-size:16px; color: red;" title="整理分类" ></i></a>';

            //strhtml += '<span class="badge badge-success" title="观点数' + arrvRTViewpointRelaObjLst.length + '条" >' + arrvRTViewpointRelaObjLst.length + '</span>';
            strhtml += '</div>';
            //strhtml += '<a href="#" onclick=UpdateGroupName_Click("' + strClassificationId + '") data-toggle="modal" data-target="#myModal"><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #f6941d;" title="维护组名" ></i></a>';
            //strhtml += '<ul class="submenu" style="display: block;">';
            strhtml += '<div>';
            strhtml += '<ul class="submenu" id="ul' + strClassificationId + '">';


            //循环数据
            for (var j = 0; j < arrvRTViewpointRelaObjLst.length; j++) {

                var strKeyId = arrvRTViewpointRelaObjLst[j].mId;

                var strTitle = arrvRTViewpointRelaObjLst[j].viewpointName
                if (strTitle.length > 10) {
                    strTitle = strTitle.substr(0, 10) + "...";
                }

                strhtml += '<li id="' + strKeyId + '" onclick=btnSelectViews("' + strKeyId + '","' + strClassificationId + '")>';
                //默认存放第一条数据显示；
                //判断存放的id控件是否为空；

                //if ($("#hidViewsId").val() == "") {
                //    //存放Id
                //    $("#hidViewsId").val(strKeyId);
                //    $("#hidClassificationId").val(strClassificationId);

                //    strhtml += '<a href="#" title="' + arrvRTViewpointRelaObjLst[j].viewpointName + '" class="selected">' + strTitle + '</a>';

                //}
                //else {


                //}
                strhtml += '<a href="#" title="' + arrvRTViewpointRelaObjLst[j].viewpointName + '">' + strTitle + '</a>';

                //strhtml += '<div>';
                //strhtml += '<a style="float:left;" href="#" onclick=UpdateViewsClassification_Click("' + arrvRTViewpointRelaObjLst[j].paperAttentionId + '","' + arrvRTViewpointRelaObjLst[j].classificationId + '")><i class="layui-icon layui-icon-edit" style="font-size:16px; color: #0080ff;" title="调整论文组" ></i></a>';


                //strhtml += '&nbsp;&nbsp;<span class="badge badge-success" title="论文答疑' + arrvRTViewpointRelaObjLst[j].paperQCount + '条" >' + arrvRTViewpointRelaObjLst[j].paperQCount + '</span>';
                //strhtml += '&nbsp;&nbsp;<span class="badge badge-warning" title="论文标注' + arrvRTViewpointRelaObjLst[j].tagsCount + '条">' + arrvRTViewpointRelaObjLst[j].tagsCount + '</span>';
                //strhtml += '&nbsp;&nbsp;<span class="badge badge-info" title="教师提问' + arrvRTViewpointRelaObjLst[j].teaQCount + '条" >' + arrvRTViewpointRelaObjLst[j].teaQCount + '</span>';


                //strhtml += '<a href="#" onclick=UpdatePaperSubVer_Click("' + arrvRTViewpointRelaObjLst[j].paperId + '","' + arrvRTViewpointRelaObjLst[j].id_CurrEduCls + '","02")><i class="layui-icon layui-icon-list" style="font-size:16px; color: #219167;" title="pdf查看论文子观点" ></i></a>';
                //strhtml += '</div>';

                strhtml += '</li>';
            }
            strhtml += '</ul>';
            strhtml += '</div>';
            strhtml += '</li>';

        }

        arrvRTViewpointRelaObjLst = arrvRTViewpointRelaObjLst0.filter(x => x.classificationId == "0000000000");
        strhtml += '<li class="li" style="margin-left:15px;">';
        strhtml += '<a href="#" id="0000000000" class="main" onclick=btnClearClassification_Click("0000000000")>未分类<span class="badge badge-success" title="观点数' + arrvRTViewpointRelaObjLst.length + '条" >' + arrvRTViewpointRelaObjLst.length + '</span></a>';
        strhtml += '</li>';
        switch (strViewsTabNum) {
            case "1":
                $("#Classification_TreeBind1").html(strhtml);
                break;
            case "2":
                $("#Classification_TreeBind2").html(strhtml);
                break;
            case "3":
                $("#Classification_TreeBind3").html(strhtml);
                break;
            case "4":
                $("#Classification_TreeBind4").html(strhtml);
                break;
            case "5":
                $("#Classification_TreeBind5").html(strhtml);
                break;
            case "6":
                $("#Classification_TreeBind6").html(strhtml);
                break;
            case "7":
                $("#Classification_TreeBind7").html(strhtml);
                break;
            default:
                $("#Classification_TreeBind1").html(strhtml);
        }

        //绑定下下拉框
        const responseBindGv2 = await this.BindDdl_ClassificationId("ddlClassificationId");

    }


    //转换概念数据到扩展观点实体
    private GetRTVByConcep(objvRTConceptRela: clsvRTConceptRelaEN): clsvRTViewpointRelaEN {
        var objvRTViewpointRela: clsvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
        objvRTViewpointRela.viewpointId = objvRTConceptRela.conceptId;
        objvRTViewpointRela.viewpointName = objvRTConceptRela.conceptName;
        objvRTViewpointRela.mId = objvRTConceptRela.mId;
        return objvRTViewpointRela;
    }

    //转换客观数据到扩展观点实体
    private GetRTVByTopicObjective(objvRTTopicObjectiveRela: clsvRTTopicObjectiveRelaEN): clsvRTViewpointRelaEN {
        var objvRTViewpointRela: clsvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
        objvRTViewpointRela.viewpointId = objvRTTopicObjectiveRela.topicObjectiveId;
        objvRTViewpointRela.viewpointName = objvRTTopicObjectiveRela.objectiveName;
        objvRTViewpointRela.mId = objvRTTopicObjectiveRela.mId;
        return objvRTViewpointRela;
    }


    //转换技能数据到扩展观点实体
    private GetRTVBySysSkill(objvRTSysSkill: clsvRTSysSkillEN): clsvRTViewpointRelaEN {
        var objvRTViewpointRela: clsvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
        objvRTViewpointRela.viewpointId = objvRTSysSkill.skillId;
        objvRTViewpointRela.viewpointName = objvRTSysSkill.skillName;
        objvRTViewpointRela.mId = objvRTSysSkill.mId;
        return objvRTViewpointRela;
    }

    //转换社会关系数据到扩展观点实体
    private GetRTVBySysSocial(objvRTSysSocialRela: clsvRTSysSocialRelaEN): clsvRTViewpointRelaEN {
        var objvRTViewpointRela: clsvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
        objvRTViewpointRela.viewpointId = objvRTSysSocialRela.socialId;
        objvRTViewpointRela.viewpointName = objvRTSysSocialRela.fullName;
        objvRTViewpointRela.mId = objvRTSysSocialRela.mId;
        return objvRTViewpointRela;
    }


    //待研究问题列表绑定
    //public async Bind_ViewsClassificationList() {
    //    var strUserId = clsPublocalStorage.userId;
    //    var strRoleId = clsPublocalStorage.roleId;
    //    var strTopicId = clsPrivateSessionStorage.topicId;
    //    var strWhereCond = await this.Combinevgs_ViewsClassificationCondition();
    //    //var strWhereCond = " topicId='" + strTopicId + "' and year='" + $("#hidYear").val() + "' and month='" + $("#hidMonth").val() + "'";

    //    //声明主题变量
    //    var arrgs_ClassificationDateNumObjLst: Array<clsgs_ViewsClassificationEN> = [];
    //    var arrgs_ViewsClassificationObjLst1: Array<clsgs_ViewsClassificationEN> = [];
    //    var arrgs_ViewsClassificationObjLst2: Array<clsgs_ViewsClassificationEN> = [];

    //    var arrRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
    //    const responseObjLst1 = await gs_ViewsClassificationEx_GetClassificationDateNumObjLstAsync(strWhereCond).then((jsonData) => {
    //        arrgs_ClassificationDateNumObjLst = <Array<clsgs_ViewsClassificationEN>>jsonData;

    //    });


    //    const responseObjLst2 = await gs_ViewsClassification_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //        arrgs_ViewsClassificationObjLst1 = <Array<clsgs_ViewsClassificationEN>>jsonData;

    //    });

    //    var strWhereCond2 = "topicId ='" + strTopicId + "'";
    //    const responseObjLst3 = await vRTUserRela_GetObjLstAsync(strWhereCond2).then((jsonData) => {
    //        arrRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
    //    });

    //    //获取用户缓存数据
    //    var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
    //    //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';

    //    var strhtml = "";

    //    //循环数据源 
    //    strhtml += '<div><th colspan="2">';
    //    for (var y = 0; y < arrRTUserRelaObjLst.length; y++) {

    //        var strUserName = arrRTUserRelaObjLst[y].userName;
    //        var strColorCode = arrRTUserRelaObjLst[y].colorCode;
    //        //得到显示用户的色码块
    //        strhtml += '<label style="background: ' + strColorCode + '">&nbsp;&nbsp;&nbsp;&nbsp;</label>&nbsp;&nbsp;<span>' + strUserName + '</span>&nbsp;&nbsp;&nbsp;';

    //    }
    //    strhtml += '</th></div>';

    //    for (var i = 0; i < arrgs_ClassificationDateNumObjLst.length; i++) {
    //        var strClassificationDate = arrgs_ClassificationDateNumObjLst[i].ClassificationDate
    //        strhtml += '<li class="layui-timeline-item">';
    //        strhtml += '<i class="layui-icon layui-timeline-axis"></i>';
    //        strhtml += '<div class="layui-timeline-content layui-text">';
    //        strhtml += '<h3 class="layui-timeline-title">' + strClassificationDate + '</h3>';

    //        arrgs_ViewsClassificationObjLst2 = arrgs_ViewsClassificationObjLst1.filter(x => x.ClassificationDate == strClassificationDate);
    //        for (var j = 0; j < arrgs_ViewsClassificationObjLst2.length; j++) {
    //            var strKeyId = arrgs_ViewsClassificationObjLst2[j].classificationId;
    //            var strClassificationTitle = arrgs_ViewsClassificationObjLst2[j].ClassificationTitle;
    //            var strClassificationContent = arrgs_ViewsClassificationObjLst2[j].ClassificationContent;
    //            ////处理换行
    //            //strClassificationContent = strClassificationContent.replace(/\r\n/g, strBr);
    //            //strClassificationContent = strClassificationContent.replace(/\n/g, strBr);

    //            var strUpdUser = arrgs_ViewsClassificationObjLst2[j].updUser;
    //            var isSubmit = arrgs_ViewsClassificationObjLst2[j].isSubmit;
    //            var versionCount = arrgs_ViewsClassificationObjLst2[j].versionCount;
    //            var strParticipant = arrgs_ViewsClassificationObjLst2[j].participant;
    //            strhtml += '<div>' + strClassificationTitle + '</div>';
    //            strhtml += '<div>' + strClassificationContent + '</div>';

    //            strhtml += '<div>';
    //            strhtml += '<div style="float:left;">';
    //            var objUser = arrUsers.find(x => x.userId == strUpdUser);
    //            if (objUser != null) {
    //                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[编辑用户]：</span>' + objUser.userName;
    //            }
    //            strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[参与者]：</span>' + strParticipant;
    //            strhtml += '</div>';
    //            strhtml += '<div style="float:right;">';
    //            if (isSubmit == false) {
    //                strhtml += '&nbsp;<span class="rowtit color2">未提交</span>&nbsp;&nbsp;';
    //                if (strRoleId != "00620003") {
    //                    //删除
    //                    strhtml += '<button title="提交待研究问题" class="layui-btn layui-btn-danger layui-btn-xs" onclick=Update_ClassificationIsSubmit_Click("' + strKeyId + '",1) href="javascript:;"><i class="layui-icon">&#x1005;</i>提交</button>';
    //                    //删除
    //                    strhtml += '<button title="删除待研究问题" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelgs_ViewsClassification_Click("' + strKeyId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
    //                }
    //                //编辑
    //                strhtml += '<button title="编辑待研究问题" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdategs_ViewsClassification_Click("' + strKeyId + '")><i class="layui-icon">&#xe642;</i></button>';

    //            } else {
    //                strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[已提交]：</span>';
    //                if (strRoleId == "00620001") {
    //                    //删除
    //                    strhtml += '<button title="撤销提交" class="layui-btn layui-btn-danger layui-btn-xs" onclick=Update_ClassificationIsSubmit_Click("' + strKeyId + '",0) href="javascript:;"><i class="layui-icon">&#xe9aa;</i>撤销提交</button>';
    //                }

    //            }
    //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('待研究问题历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strKeyId + "&Type=14')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本<span class=\"layui-badge\">" + versionCount + "</span></button >";
    //            //判断角色
    //            //不等于学生，其他角色都可以添加问题
    //            strhtml += '</div>';

    //            strhtml += '</div>';
    //            strhtml += '</br>';

    //        }
    //        strhtml += '</div>';
    //        strhtml += '</li>';

    //    }
    //    $("#ViewsClassificationList").html(strhtml);

    //}


    //待研究问题提交




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


            await this.DelRecord(strKeyId);
            await this.ClassificationTree();
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
    public async DelRecord(strClassificationId: string) {
        try {
            const responseText = await gs_ViewsClassification_DelRecordAsync(strClassificationId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                //gs_ViewsClassification_ReFreshCache();
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                //alert();
                layui_Alert(1, strInfo);
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


    //public async btnAddClassificationRecordInTab_Click(strKey: number) {
    public async SubmiClassification_Click() {
        var strViewsTabNum = $("#hidViewsTabNum").val();
        //$("#hidViewsMId").val(strKey);
        //if ($("#ddlClassificationId").val() == 0) {
        //    layui_Alert(3, "请选择需要调整的分类！");
        //} else {
        var returnBool: boolean = true;
        switch (strViewsTabNum) {
            case "1":
                const responseText1 = await this.Update_RTViewpointRela().then((jsonData) => {
                    returnBool = jsonData;
                });
                if (returnBool == true) {
                    layui_Alert(1, "已加入该分类！");
                    GetAllFunctionMethod();
                } else {
                    layui_Alert(3, "加入失败！");
                }
                break;
            case "2":
                const responseText2 = await this.Update_RTViewpointRela().then((jsonData) => {
                    returnBool = jsonData;
                });
                if (returnBool == true) {
                    layui_Alert(1, "已加入该分类！");
                    GetAllFunctionMethod();
                } else {
                    layui_Alert(3, "加入失败！");
                }

                break;
            case "3":
                const responseText3 = await this.Update_RTConceptRela().then((jsonData) => {
                    returnBool = jsonData;
                });
                if (returnBool == true) {
                    layui_Alert(1, "已加入该分类！");
                    GetAllFunctionMethod();
                } else {
                    layui_Alert(3, "加入失败！");
                }

                break;
            case "4":
                const responseText4 = await this.Update_RTTopicObjectiveRela().then((jsonData) => {
                    returnBool = jsonData;
                });
                if (returnBool == true) {
                    GetAllFunctionMethod();
                    layui_Alert(1, "已加入该分类！");
                } else {
                    layui_Alert(3, "加入失败！");
                }

                break;
            case "5":
                const responseText5 = await this.Update_RTTopicObjectiveRela().then((jsonData) => {
                    returnBool = jsonData;
                });
                if (returnBool == true) {
                    layui_Alert(1, "已加入该分类！");
                    GetAllFunctionMethod();
                } else {
                    layui_Alert(3, "加入失败！");
                }

                break;
            case "6":
                const responseText6 = await this.Update_RTSysSkillRela().then((jsonData) => {
                    returnBool = jsonData;
                });
                if (returnBool == true) {
                    layui_Alert(1, "已加入该分类！");
                    GetAllFunctionMethod();
                } else {
                    layui_Alert(3, "加入失败！");
                }

                break;
            case "7":
                const responseText7 = await this.Update_RTSysSocialRela().then((jsonData) => {
                    returnBool = jsonData;
                });
                if (returnBool == true) {
                    layui_Alert(1, "已加入该分类！");
                    GetAllFunctionMethod();
                } else {
                    layui_Alert(3, "加入失败！");
                }
                break;
            default:
                layui_Alert(2, "请选择左边的分类菜单，不然无法添加到分类中去！");
                break;
        }
        //}
        HideDialogClassification();



    }


    /* 修改各观点记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async Update_RTViewpointRela(): Promise<boolean> {
        const strThisFuncName = this.Update_RTViewpointRela.name;

        var objRTViewpointRelaEN: clsRTViewpointRelaEN = new clsRTViewpointRelaEN();
        objRTViewpointRelaEN.SetmId($("#hidViewsMId").val());
        objRTViewpointRelaEN.SetClassificationId($("#ddlClassificationId").val());

        objRTViewpointRelaEN.sfUpdFldSetStr = objRTViewpointRelaEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objRTViewpointRelaEN.mId == 0 || objRTViewpointRelaEN.mId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTViewpointRela_UpdateRecordAsync(objRTViewpointRelaEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {

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

    /* 修改概念记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async Update_RTConceptRela(): Promise<boolean> {
        const strThisFuncName = this.Update_RTConceptRela.name;
        var objRTConceptRelaEN: clsRTConceptRelaEN = new clsRTConceptRelaEN();
        objRTConceptRelaEN.SetmId($("#hidViewsMId").val());
        objRTConceptRelaEN.SetClassificationId($("#ddlClassificationId").val());

        objRTConceptRelaEN.sfUpdFldSetStr = objRTConceptRelaEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objRTConceptRelaEN.mId == 0 || objRTConceptRelaEN.mId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTConceptRela_UpdateRecordAsync(objRTConceptRelaEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {

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


    /* 修改客观记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async Update_RTTopicObjectiveRela(): Promise<boolean> {
        const strThisFuncName = this.Update_RTTopicObjectiveRela.name;
        var objRTTopicObjectiveRelaEN: clsRTTopicObjectiveRelaEN = new clsRTTopicObjectiveRelaEN();
        objRTTopicObjectiveRelaEN.SetmId($("#hidViewsMId").val());
        objRTTopicObjectiveRelaEN.SetClassificationId($("#ddlClassificationId").val());

        objRTTopicObjectiveRelaEN.sfUpdFldSetStr = objRTTopicObjectiveRelaEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objRTTopicObjectiveRelaEN.mId == 0 || objRTTopicObjectiveRelaEN.mId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTTopicObjectiveRela_UpdateRecordAsync(objRTTopicObjectiveRelaEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {

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


    /* 修改技能记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async Update_RTSysSkillRela(): Promise<boolean> {
        const strThisFuncName = this.Update_RTSysSkillRela.name;
        var objRTSysSkillRelaEN: clsRTSysSkillRelaEN = new clsRTSysSkillRelaEN();
        objRTSysSkillRelaEN.SetmId($("#hidViewsMId").val());
        objRTSysSkillRelaEN.SetClassificationId($("#ddlClassificationId").val());

        objRTSysSkillRelaEN.sfUpdFldSetStr = objRTSysSkillRelaEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objRTSysSkillRelaEN.mId == 0 || objRTSysSkillRelaEN.mId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTSysSkillRela_UpdateRecordAsync(objRTSysSkillRelaEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {

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



    /* 修改社会关系记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async Update_RTSysSocialRela(): Promise<boolean> {
        const strThisFuncName = this.Update_RTSysSocialRela.name;
        var objRTSysSocialRelaEN: clsRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
        objRTSysSocialRelaEN.SetmId($("#hidViewsMId").val());
        objRTSysSocialRelaEN.SetClassificationId($("#ddlClassificationId").val());

        objRTSysSocialRelaEN.sfUpdFldSetStr = objRTSysSocialRelaEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objRTSysSocialRelaEN.mId == 0 || objRTSysSocialRelaEN.mId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTSysSocialRela_UpdateRecordAsync(objRTSysSocialRelaEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {

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

}