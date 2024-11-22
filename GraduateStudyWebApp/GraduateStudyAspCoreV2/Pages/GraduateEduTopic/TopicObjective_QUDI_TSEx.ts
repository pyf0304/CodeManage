
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiTopicObjective_QUDI_TSEx
表名:TopicObjective(01120613)
生成代码版本:2020.03.20.1
生成日期:2020/03/23 16:53:03
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
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsObjectiveAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js";
import { clsRTTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTTopicObjectiveRelaEN.js";
import { clsTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { BindDdl_ObjLst, BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

import { Public_TopicObjective } from "../GraduateEduPublicPage/Public_TopicObjective.js";
import { Pub_PaperList } from "../GraduateEduPublicPage/Pub_PaperList.js";
import { TopicObjectiveCRUD } from "../PagesBase/GraduateEduTopic/TopicObjectiveCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsTopicObjectiveVerEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveVerEN.js";
import { SysComment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { ObjectiveAttachment_AddNewRecordAsync, ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsObjectiveAttachmentWApi.js";
import { RTTopicObjectiveRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTTopicObjectiveRelaWApi.js";
import { TopicObjectiveVer_DelTopicObjectiveVersAsync, TopicObjectiveVer_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveVerWApi.js";
import { TopicObjective_GetObjLstAsync, TopicObjective_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { vTopicObjective_GetObjLstByPagerAsync, vTopicObjective_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { GetCheckedKeyIdsInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { TopicObjective_EditEx } from "./TopicObjective_EditEx.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogThree(): void;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiTopicObjective_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class TopicObjective_QUDI_TSEx extends TopicObjectiveCRUD implements IShowList {
    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvTopicObjectiveBy: string = "topicObjectiveId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_vTopicObjective();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vTopicObjective":
                alert('该类没有绑定该函数：[this.BindGv_vTopicObjective_Cache]！');
                //this.BindGv_vTopicObjective_Cache();
                break;
            default:
                strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);
                break;
        }
    }

    /**
    * 按钮单击,用于调用Js函数中btn_Click
    * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    **/
    public static btn_Click(strCommandName: string, strKeyId: string) {
        let objPage: TopicObjective_QUDI_TSEx;
        if (TopicObjectiveCRUD.objPage_CRUD == null) {
            TopicObjectiveCRUD.objPage_CRUD = new TopicObjective_QUDI_TSEx();
            objPage = <TopicObjective_QUDI_TSEx>TopicObjectiveCRUD.objPage_CRUD;
        }
        else {
            objPage = <TopicObjective_QUDI_TSEx>TopicObjectiveCRUD.objPage_CRUD;
        }
        const objPage_Edit: TopicObjective_EditEx = new TopicObjective_EditEx(objPage);
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
        let strMsg = '';
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "ExportExcel":            //导出Excel
                //objPage.btnExportExcel_Click();
                //alert("导出Excel功能还没有开通！");
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
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
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
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
                strMsg = '命令:' + strCommandName + "在函数(TopicObjectiveCRUDExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            this.divName4Pager = "divPager1";  //列表中的分页区的层Id
            if (clsPublocalStorage.userId != "") {
                ////建立缓存
                var strViewType = "01";
                $("#hidViewType").val(strViewType);
                //const arrvTopicObjective_Cache = await vTopicObjective_GetObjLstAsync("1=1");

                TopicObjectiveCRUD.sortvTopicObjectiveBy = "updDate Desc";
                
                //用户下拉框绑定
                //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域

                const ddl_ObjectiveUserId_q = await clsDropDownList.BindDdl_UserIdInvTopicObjectiveFact_Cache("ddlObjectiveUserId_q", objUsers_Cond);

                //论文用户下拉框绑定
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域


                //文献类型；
                const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vTopicObjective();
                $("#divLoading").hide();
            }
            else {
                window.top.location.href = "../Web/Login";
            }
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
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


    ////获取客观事实用户
    //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "1=1 And objectiveType ='01'") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlUserId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = vTopicObjectiveEx_GetTopicObjectiveUserObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrUserObjLst: Array<clsvTopicObjectiveEN> = <Array<clsvTopicObjectiveEN>>jsonData;
    //                BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvTopicObjectiveEN.con_UpdUser, clsvTopicObjectiveEN.con_UserName, "编辑用户");
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
            if (this.objectiveName_q != "") {
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveName} like '% ${this.objectiveName_q}%'`;
            }
            //if (this.userName_q != "") {
            //    strWhereCond += ` And ${clsvTopicObjectiveEN.con_UserName} like '% ${this.userName_q}%'`;
            //}
            if (this.User_q != "" && this.User_q != "0") {
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} = '${this.User_q}'`;
            }
            if (this.StartDate_q != "") {
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdDate} > '${this.StartDate_q}'`;
            }
            if (this.EndDate_q != "") {
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdDate} < '${this.EndDate_q}'`;
            }

            //判断客观类型 区分是客观事实、客观依据
            var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
            if (strhidObjectiveTypeId != "") {
                strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectiveTypeId}'`;
            }

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            $("#hidUserId").val(strUserId);
            //$('#lnkUserName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');

            //判断角色 
            //管理员
            if (strRoleId == "00620001") {
                $("#btnCancelSubmit").show();
            }
            else if (strRoleId == "00620002") {
                $("#btnCancelSubmit").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
                //strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "') or updUser = '" + strUserId + "'";
                //strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "')";
                //strWhereCond += ` And ${clsvTopicObjectiveEN.con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
                //var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
                //if (strhidObjectiveTypeId != "") {
                //    strWhereCond += ` And ${clsvTopicObjectiveEN.con_ObjectiveType} = '${strhidObjectiveTypeId}'`;
                //}
                //$("#btnCancelSubmit").hide();
            }
            else {
                //学生； 
                var strViewType = $("#hidViewType").val();
                if (strViewType == "01") {
                    strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} = '${strUserId}'`;
                }
                else {
                    strWhereCond += ` And ${clsvTopicObjectiveEN.con_UpdUser} <> '${strUserId}'`;
                }
                //学生00620003
                $("#btnCancelSubmit").hide();
                // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${objvUserRoleRelation.userId}'`;
            }




        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineTopicObjectiveCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
    public async btnQuery_Click() {

        try {
            this.BindGv_vTopicObjective();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `查询不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vTopicObjective() {
        this.divName4Pager = "divPager1";  //列表中的分页区的层Id
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevTopicObjectiveCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN> = [];
        try {
            this.recCount = await vTopicObjective_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: TopicObjectiveCRUD.sortvTopicObjectiveBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vTopicObjective_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvTopicObjectiveObjLst = <Array<clsvTopicObjectiveEN>>jsonData;
            });
            ////换行符
            //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            ////动态显示对应的数据
            //var strhtml = "";
            //var strUserId = clsPublocalStorage.userId;
            //var strRoleId = clsPublocalStorage.roleId;
            ////个人观点
            //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            ////strhtml += '<div style="float:left;"><a href="#" title="当前论文相关' + strTitle + '">当前论文相关' + strTitle + '</a></div>';
            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加客观事实" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加客观事实</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvTopicObjectiveObjLst.length; i++) {
            //    //得到topicObjectiveId；
            //    var strTopicObjectiveId = arrvTopicObjectiveObjLst[i].topicObjectiveId;
            //    v++;
            //    //对内容进行换行替换
            //    var strObjectiveContent = arrvTopicObjectiveObjLst[i].objectiveContent;
            //    var strConclusion = arrvTopicObjectiveObjLst[i].conclusion;
            //    strObjectiveContent = strObjectiveContent.replace(/\r\n/g, strBr);
            //    strObjectiveContent = strObjectiveContent.replace(/\n/g, strBr);
            //    strConclusion = strConclusion.replace(/\r\n/g, strBr);
            //    strConclusion = strConclusion.replace(/\n/g, strBr);
            //    //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
            //    strhtml += '<li><span class="rowtit color3">[客观名称]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].objectiveName + '</span></li>';
            //    strhtml += '<li><span class="rowtit color3">[客观内容]：</span><span class="abstract-text">' + strObjectiveContent + '</span></li>';
            //    strhtml += '<li><span class="rowtit color3">[客观推论]：</span><span class="abstract-text">' + strConclusion + '</span></li>';
            //    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'

            //    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].updDate + '</span>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].userName + '</span>';
            //    //判断ture 、false
            //    if (arrvTopicObjectiveObjLst[i].isSubmit == true) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
            //    }
            //    else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
            //    }
            //    //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[是否提交]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].isSubmit + '</span></div>';




            //    if (strUserId == arrvTopicObjectiveObjLst[i].updUser) {
            //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit colorRed">[操作]：</span>';
            //        //修改个人观点
            //        strhtml += '&nbsp;&nbsp;<button title="修改客观事实" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
            //        //删除个人观点
            //        strhtml += '&nbsp;&nbsp;<button title="删除客观事实" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';
            //        //数据提交
            //        strhtml += '&nbsp;&nbsp;<button title="提交事实" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>提交事实</button>';
            //        //历史版本
            //        if (arrvTopicObjectiveObjLst[i].versionCount > 0 && arrvTopicObjectiveObjLst[i].versionCount != null) {
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('客观事实历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvTopicObjectiveObjLst[i].topicObjectiveId + "&Type=06')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //        }
            //        strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strTopicObjectiveId + "&TypeId=07','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";
            //    } else {
            //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
            //    }
            //    //读取session角色 来判断绑定不同数据列表
            //    //获取用户角色来判断显示不同的列表数据；


            //    //管理员则不需要隐藏
            //    if (strRoleId != "00620003") {

            //        //取消提交
            //        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';

            //    }
            //    //else {
            //    //    //学生00620003 教师 需要隐藏
            //    //    //取消提交
            //    //    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" style="display:none;" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';


            //    //}

            //    strhtml += '</div></div></li>';

            //    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';

            

            var strhidObjectiveTypeId = $("#hidObjectiveTypeId").val();
            var strHtml = await Public_TopicObjective.BindList_vTopicObjective("01", strhidObjectiveTypeId, arrvTopicObjectiveObjLst)

            var strViewType = $("#hidViewType").val();
            if (strViewType == "01") {
                //拼接；
                $("#divDataLst").html(strHtml);
            }
            else {
                //拼接；
                $("#divOtherDataLst").html(strHtml);
            }

            if (this.recCount >= 10) {
                $("#divPager1").show();
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
        //if (arrvTopicObjectiveObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        //try {
        //    this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
        //    console.log("完成BindGv_vTopicObjective!");
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //    alert(strMsg);
        //}
    }

    /* 显示vTopicObjective对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrTopicObjectiveObjLst">需要绑定的对象列表</param>
   */
    public async BindTab_vTopicObjective(divContainer: string, arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN>) {
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
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "objectiveName",
                    colHeader: "客观名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "objectiveType",
                    colHeader: "客观类型",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "objectiveTypeName",
                    colHeader: "客观类型名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isSubmit",
                    colHeader: "是否提交",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
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
        BindTab_V(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }




    ///////////////////////////////////////////////////////////////////删除数据控制；

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

            //查询和id相关的关系数据是否存在
            var strWhere1 = ` 1=1 And ${clsRTTopicObjectiveRelaEN.con_TopicObjectiveId} = '${strKeyId}'`;
            var RTVCount: number = 0;
            const responseText1 = await RTTopicObjectiveRela_GetRecCountByCondAsync(strWhere1).then((jsonData) => {
                RTVCount = jsonData;
            });

            //查询和id相关的评论评分是否存在
            var strWhere2 = " 1=1 And tableKey ='" + strKeyId + "' and commentTypeId='06'";
            var commentCount: number = 0;
            const responseText2 = await SysComment_GetRecCountByCondAsync(strWhere2).then((jsonData) => {
                commentCount = jsonData;
            });




            if (RTVCount > 0) {
                alert("当前数据已被引用,不能删除！");
                return;
            }
            else if (commentCount > 0) {
                alert("当前数据已被人评论打分,不能删除！");
                return;
            } else {
                var strTopicObjectiveVWhereCond = " topicObjectiveId='" + strKeyId + "' order by updDate Asc";
                var arrTopicObjectiveVObjLst: Array<clsTopicObjectiveVerEN> = [];
                const responseText1 = await TopicObjectiveVer_GetObjLstAsync(strTopicObjectiveVWhereCond).then((jsonData) => {
                    arrTopicObjectiveVObjLst = <Array<clsTopicObjectiveVerEN>>jsonData;
                });
                var arrSelectedKeys: Array<string> =
                    arrTopicObjectiveVObjLst.map((x) => {
                        var strId = x.topicObjectiveVId.toString();
                        //var strKey = strId.substring(3);
                        return strId;
                    });

                //更新总表3个参数 主键、子表类型、页面操作类型；
                var strTopicObjectiveId = strKeyId;
                const responseText6 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strTopicObjectiveId, "07", "3", clsPublocalStorage.id_CurrEduCls);
                var returnBool6: boolean = !!responseText6;
                if (returnBool6 == true) {
                    console.log("客观数据总表同步成功；");
                }
                else {
                    console.log("客观数据总表同步失败；");
                }
                const responseText0 = await this.VDelMultiRecord(arrSelectedKeys);
                const responseText = this.DelRecord(strKeyId);
                const responseBindGv = this.BindGv_vTopicObjective();
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    //批量删除
    public VDelMultiRecord(arrTopicObjectiveVId: Array<string>) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = TopicObjectiveVer_DelTopicObjectiveVersAsync(arrTopicObjectiveVId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        var strInfo: string = `删除历史版本成功,共删除${returnInt}条记录!`;
                        ////显示信息框
                        //alert(strInfo);
                        console.log(strInfo);
                    }
                    else {
                        var strInfo: string = `历史版本删除记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    console.log("完成DelMultiRecord!");
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

    /* 删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
*/
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            //需要判断当前数据中是否包含已提交数据、如果有则不能删除
            var strKeyList;
            if (arrKeyIds.length == 0) return "";
            strKeyList = "";
            for (var i = 0; i < arrKeyIds.length; i++) {
                if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
            }
            //
            var strWhereCond = " topicObjectiveId in (" + strKeyList + ")";
            var arrTopicObjectiveObjLst: Array<clsTopicObjectiveEN> = [];
            const responseText1 = await TopicObjective_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrTopicObjectiveObjLst = <Array<clsTopicObjectiveEN>>jsonData;
                //查询是否有提交的数据
                arrTopicObjectiveObjLst = arrTopicObjectiveObjLst.filter(x => x.isSubmit == true);
                if (arrTopicObjectiveObjLst.length > 0) {
                    alert("包含有已提交数据，不能删除！");
                    return "";
                }
            });

            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vTopicObjective();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    //删除观点附件
    /* 
根据关键字删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync(strWhere).then((jsonData) => {
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

 
//    ///////////////////////////////////////////////////////////////论文

//    /* 函数功能:在数据 列表中跳转到某一页 论文列表
//(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
//<param name = "intPageIndex">页序号</param>
//*/
//    public IndexPageTwo(intPageIndex) {
//        if (intPageIndex == 0) {
//            intPageIndex = this.objPager.pageCount;
//        }
//        console.log("跳转到" + intPageIndex + "页");
//        this.SetCurrPageIndex(intPageIndex);
//        this.BindGv_vPaper();
//    }
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
    /*
    * 论文Id
   */
    public set paperId(value: string) {
        $("#txtPaperId").val(value);
    }
    /*
    * 论文
   */
    public get paperId(): string {
        return $("#txtPaperId").val();
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
            //排除获取已被当前观点引用过的论文数据；
            //strWhereCond += ` And paperId not in (select paperId from RTPaperRela where viewpointId = '${strTopicId}')`;

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    //选择论文弹出列表数据；
    public async selectPaper_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.Page_Load();
         //await objPage_Paper.BindGv_vPaper();
    }
    //查询论文列表
    public async btnPaperQuery_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.Page_Load();
         //await objPage_Paper.BindGv_vPaper();
    }
    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)

        $("#txtSourceId").val(strkeyId);
        //设置只读属性；
        $("#txtSourceId").attr("disabled", "disabled");
        //$("#txtPaperId").val(strkeyId);
        ////设置只读属性；
        //$("#txtPaperId").attr("disabled", "disabled");
        //关闭列表
        HideDialogThree();

    }


    /*
  * 文献类型
 */
    public set objectiveType(value: string) {
        $("#ddlObjectiveType").val(value);
    }
    /*
    * 文献类型
   */
    public get objectiveType(): string {
        return $("#ddlObjectiveType").val();
    }


    //取消提交
    public async btnCancelSubmit_Click(strKeyId: string) {
        var strUserId = clsPublocalStorage.userId;
        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要取消的记录！");
            return;
        }

        try {
            this.CancelSubmitRecordSave(strKeyId);

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*取消
  
 */
    public async CancelSubmitRecordSave(strKeyId: string) {
        const strThisFuncName = this.CancelSubmitRecordSave.name;

        //
        var objTopicObjectiveEN: clsTopicObjectiveEN = new clsTopicObjectiveEN();
        objTopicObjectiveEN.SetTopicObjectiveId(strKeyId);
        objTopicObjectiveEN.SetIsSubmit(false);
        //objPaperEN..submitter = clsPublocalStorage.userId;//提交人；
        objTopicObjectiveEN.sfUpdFldSetStr = objTopicObjectiveEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objTopicObjectiveEN.topicObjectiveId == "" || objTopicObjectiveEN.topicObjectiveId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }

        try {
            const responseText = TopicObjective_UpdateRecordAsync(objTopicObjectiveEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    var strInfo: string = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);

                    //HideDialog();
                    this.BindGv_vTopicObjective();
                }
                else {
                    var strInfo: string = `取消不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("取消失败");
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `取消记录不成功,${e}.`;
            alert(strMsg);
        }

    }

    /*
* 用户名
*/
    public get userName_q(): string {
        return $("#txtUserName_q").val();
    }
    /*
* 起始时间
*/
    public get StartDate_q(): string {
        return $("#txtStartDate_q").val();
    }
    /*
    * 起始时间
   */
    public set StartDate_q(value: string) {
        $("#txtStartDate_q").val(value);
    }

    /*
   * 结束时间
  */
    public get EndDate_q(): string {
        return $("#txtEndDate_q").val();
    }
    /*
    * 结束时间
   */
    public set EndDate_q(value: string) {
        $("#txtEndDate_q").val(value);
    }
    public get User_q(): string {
        return $("#ddlObjectiveUserId_q").val();
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

    //////////////////////////////////////////////////////////////////////附件添加
    //添加上传论文附件方法
    public async AddNewRecordobjPaperSubAttachmentENSave(filePath: string, strfileNum: string) {
        var objObjectiveAttachmentEN: clsObjectiveAttachmentEN = new clsObjectiveAttachmentEN();
        this.PutDataToPaperAttachmentClass(objObjectiveAttachmentEN, filePath);
        try {
            const responseText2 = await ObjectiveAttachment_AddNewRecordAsync(objObjectiveAttachmentEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
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
    //观点附件数据存放
    public PutDataToPaperAttachmentClass(pobjObjectiveAttachmentEN: clsObjectiveAttachmentEN, filePath: string) {
        pobjObjectiveAttachmentEN.SetTopicObjectiveId($("#txtTopicObjectiveId").val());// 概念Id

        var strfilePath = filePath;
        //判断地址不为空则执行截取操作
        if (strfilePath != "") {
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjObjectiveAttachmentEN.SetFilePath(filePath);

            pobjObjectiveAttachmentEN.SetObjectiveAttachmentName(strfilePath);
        }
        pobjObjectiveAttachmentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期

        pobjObjectiveAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班
        pobjObjectiveAttachmentEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id


    }

}