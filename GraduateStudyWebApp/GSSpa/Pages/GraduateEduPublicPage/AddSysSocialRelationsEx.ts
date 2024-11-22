
/*-- -- -- -- -- -- -- -- -- -- --
类名:SysSocialRelationsCRUDEx
表名:SysSocialRelations(01120644)
生成代码版本:2020.05.18.1
生成日期:2020/05/22 19:00:05
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
//import { SysSocialRelationsCRUD } from "./SysSocialRelationsCRUD.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";

import { SysSocialRelationsCRUD } from "../GraduateEduTopic/SysSocialRelationsCRUD.js";
import { SysSocialRelationsCRUDEx } from "../GraduateEduTopic/SysSocialRelationsCRUDEx.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsRTSysSocialRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js";
import { clsSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js";
import { clsSysSocialRelationsVEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsVEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsSysSecurityLevelEN } from "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js";
import { ResearchTopic_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { RTSysSocialRela_AddNewRecordAsync, RTSysSocialRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js";
import { SysSocialRelationsV_AddNewRecordAsync, SysSocialRelationsV_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsVWApi.js";
import { SysSocialRelations_AddNewRecordWithReturnKeyAsync, SysSocialRelations_GetMaxStrIdAsync, SysSocialRelations_GetObjBySocialIdAsync, SysSocialRelations_GetRecCountByCondAsync, SysSocialRelations_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { vSysSocialRelations_GetObjLstByPagerAsync, vSysSocialRelations_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { SysSecurityLevel_BindDdl_LevelIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function CloseWindow(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* SysSocialRelationsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class AddSysSocialRelationsEx extends SysSocialRelationsCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvSysSocialRelationsBy: string = "socialId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }


    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: SysSocialRelationsCRUDEx = new SysSocialRelationsCRUDEx();
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage.btnUpdateRecord_Click(strKeyId);
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
                objPage.btnDelRecord_Click();
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
                var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
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
                //通过主题Id获取教学班ID
                if ($("#hidId_CurrEduCls").val() == "") {
                    var objResearchTopic: clsResearchTopicEN = await ResearchTopic_GetFirstObjAsync(" topicId=" + $("#hidTopicId").val());
                    $("#hidId_CurrEduCls").val(objResearchTopic.id_CurrEduCls);
                } 

                //建立缓存
                //this.AddNewRecord();
                //// 为查询区绑定下拉框
                var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
                const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
                var strSocialId = $("#hidSocialId").val();
                if (strSocialId != "") {
                    const conBindDdl = await this.BindDdl4EditRegion();
                    const UpdateRecord = await this.UpdateRecord(strSocialId);
                    $("#divLoading").hide();
                }
                else {
                    $("#divLoading").hide();
                    //获取分享Id
                    const responseText = await gs_UserConfigEx_GetNewReturnShareIdEx("10", clsPubSessionStorage.GetSession_UserId());
                    var strShareId: string = responseText;
                    //var returnBool: boolean = !!responseText2;
                    if (strShareId != "") {
                        this.shareId = strShareId;
                    }
                    this.btnAddNewRecord_Click();
                   
                }

             
                //const gvBindDdl = await this.BindDdl4QueryRegion();
               
                this.hidSortvSysSocialRelationsBy = "fullName Asc";
                ////2、显示无条件的表内容在GridView中
                //const gvResult = await this.BindGv_vSysSocialRelations();
             
               
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

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.OpType = "AddWithMaxId";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                //const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
               
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
               
                const responseText = await this.AddNewRecord();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
    public async btnUpdateRecord_Click(strKeyId: string) {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            ShowDialog('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog('Update');
            this.UpdateRecord(strKeyId);
        }
    }

    /* 函数功能:把类对象的属性内容显示到界面上
注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 如果在设置数据库时,就应该一级字段在前,二级字段在后
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
 <param name = "pobjSysSocialRelationsEN">表实体类对象</param>
*/
    public GetDataFromSysSocialRelationsClass(pobjSysSocialRelationsEN: clsSysSocialRelationsEN) {
        this.socialId = pobjSysSocialRelationsEN.socialId;// 社会Id
        this.fullName = pobjSysSocialRelationsEN.fullName;// 姓名
        this.nationality = pobjSysSocialRelationsEN.nationality;// 国籍
        this.levelId = pobjSysSocialRelationsEN.levelId;// 级别Id
        this.workUnit = pobjSysSocialRelationsEN.workUnit;// 工作单位
        this.major = pobjSysSocialRelationsEN.major;// 专业
        this.achievement = pobjSysSocialRelationsEN.achievement;// 成就
        this.detailedDescription = pobjSysSocialRelationsEN.detailedDescription;// 详细说明
        this.shareId = pobjSysSocialRelationsEN.shareId;
        //this.updUser = pobjSysSocialRelationsEN.updUser;// 修改人
        //this.updDate = pobjSysSocialRelationsEN.updDate;// 修改日期
        this.isSubmit = pobjSysSocialRelationsEN.isSubmit;// 是否提交
        this.memo = pobjSysSocialRelationsEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strSocialId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strSocialId;
        try {
            const responseText = await SysSocialRelations_GetObjBySocialIdAsync(strSocialId);
            var objSysSocialRelationsEN: clsSysSocialRelationsEN = <clsSysSocialRelationsEN>responseText;
            this.GetDataFromSysSocialRelationsClass(objSysSocialRelationsEN);
            console.log("完成UpdateRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public async UpdateRecordSave() {
        this.DivName = "divUpdateRecordSave";
        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
        objSysSocialRelationsEN.socialId = this.KeyId;
        this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
        objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
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

    /* 函数功能:为编辑区绑定下拉框
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
    */
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        var objSysSecurityLevel_Cond: clsSysSecurityLevelEN = new clsSysSecurityLevelEN();//编辑区域
        const ddlLevelId = await SysSecurityLevel_BindDdl_LevelIdInDiv_Cache(this.divName4Edit, "ddlLevelId");//编辑区域
    }

    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vSysSocialRelations() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevSysSocialRelationsCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = [];
        try {
            const responseRecCount = await vSysSocialRelations_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvSysSocialRelationsBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvSysSocialRelationsObjLst = <Array<clsvSysSocialRelationsEN>>jsonData;
            });



            //动态显示对应的数据
            var strhtml = "";
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();
            //社会关系
            strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加社会关系" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加社会关系</button></div>';

            strhtml += '</div><ul class="artlist">';
            var v = 0;//给内容加个序号
            for (var i = 0; i < arrvSysSocialRelationsObjLst.length; i++) {
                //得到socialId；
                var strSocialId = arrvSysSocialRelationsObjLst[i].socialId;
                v++;
                //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].fullName + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].nationality + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].workUnit + '</span>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].major + '</span></li>';
                strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].achievement + '</span></li>';
                strhtml += '<li><span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].detailedDescription + '</span></li>';
                strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'

                strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].updDate + '</span>';

                ////获取用户名称；根据id；
                //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
                ////获取用户名；
                //var strUserName = arrUsers.filter(x => x.userId == arrvSysSocialRelationsObjLst[i].updUser);//

                //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + strUserName + '</span>';

                //判断ture 、false
                if (arrvSysSocialRelationsObjLst[i].isSubmit == true) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                }
                else {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                }
                //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[是否提交]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].isSubmit + '</span></div>';


                if (strUserId == arrvSysSocialRelationsObjLst[i].updUser) {
                    strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit colorRed">[操作]：</span>';
                    //修改技能
                    strhtml += '&nbsp;&nbsp;<button title="修改社会关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>修改社会关系</button>';
                    //删除技能
                    strhtml += '&nbsp;&nbsp;<button title="删除社会关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>删除社会关系</button>';
                    //数据提交
                    strhtml += '&nbsp;&nbsp;<button title="提交数据" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>提交数据</button>';
                    //历史版本
                    //if (arrvSysSocialRelationsObjLst[i].versionCount > 0 && arrvSysSocialRelationsObjLst[i].versionCount != null) {
                    //    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvSysSocialRelationsObjLst[i].skillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                    //}
                } else {
                    strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
                }
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；


                //管理员则不需要隐藏
                if (strRoleId != "00620003") {

                    //取消提交
                    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';

                }
                //else {
                //    //学生00620003 教师 需要隐藏
                //    //取消提交
                //    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" style="display:none;" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';


                //}

                strhtml += '</div></div></li>';

                strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            }
            strhtml += '</ul></div>';
            //拼接；
            $("#divDataLst").html(strhtml);

            if (this.RecCount >= 10) {
                $("#divPager").show();
                this.objPager.RecCount = this.RecCount;
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
        //if (arrvSysSocialRelationsObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        //try {
        //    this.BindTab_vSysSocialRelations(strListDiv, arrvSysSocialRelationsObjLst);
        //    console.log("完成BindGv_vSysSocialRelations!");
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //    alert(strMsg);
        //}
    }


    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevSysSocialRelationsCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + $("#hidId_CurrEduCls").val() + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.FullName_q != "") {
                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_FullName} like '% ${this.FullName_q}%'`;
            }
            if (this.Achievement_q != "") {
                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_Achievement} like '% ${this.Achievement_q}%'`;
            }
            if (this.LevelId_q != "" && this.LevelId_q != "0") {
                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_LevelId} = '${this.LevelId_q}'`;
            }

            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();
            $("#hidUserId").val(strUserId);
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                $("#btnDelRecord").show();
                $("#btnCancelSubmit").show();


            }
            else if (strRoleId == "00620002") {
                //教师
                $("#btnDelRecord").hide();
                $("#btnCancelSubmit").show();

            }
            else {
                //学生 教师；
                $("#btnDelRecord").hide();
                $("#btnCancelSubmit").hide();
                //学生00620003 00620002教师

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
    /* 显示vSysSocialRelations对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrSysSocialRelationsObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vSysSocialRelations(divContainer: string, arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN>) {
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
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "fullName",
                    ColHeader: "姓名",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "nationality",
                    ColHeader: "国籍",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "workUnit",
                    ColHeader: "工作单位",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "major",
                    ColHeader: "专业",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "achievement",
                    ColHeader: "成就",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "detailedDescription",
                    ColHeader: "详细说明",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "levelName",
                    ColHeader: "级别名称",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
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
        clsCommonFunc4Web.BindTabV2(o, arrvSysSocialRelationsObjLst, arrDataColumn, "socialId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }




    /* 函数功能:把界面上的属性数据传到类对象中
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
<param name = "pobjSysSocialRelationsEN">数据传输的目的类对象</param>
*/
    public PutDataToSysSocialRelationsVClass(pobjSysSocialRelationsVEN: clsSysSocialRelationsVEN) {
        var strSocialId = $("#hidSocialId").val();
        pobjSysSocialRelationsVEN.socialId = strSocialId;// 社会Id
        pobjSysSocialRelationsVEN.fullName = this.fullName;// 姓名
        pobjSysSocialRelationsVEN.nationality = this.nationality;// 国籍
        pobjSysSocialRelationsVEN.levelId = this.levelId;// 级别Id
        pobjSysSocialRelationsVEN.workUnit = this.workUnit;// 工作单位
        pobjSysSocialRelationsVEN.major = this.major;// 专业
        pobjSysSocialRelationsVEN.achievement = this.achievement;// 成就
        pobjSysSocialRelationsVEN.detailedDescription = this.detailedDescription;// 详细说明
        pobjSysSocialRelationsVEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改人
        pobjSysSocialRelationsVEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjSysSocialRelationsVEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
        //pobjSysSocialRelationsVEN.isSubmit = this.isSubmit;// 是否提交
        pobjSysSocialRelationsVEN.memo = this.memo;// 备注
    }


    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjSysSocialRelationsEN">数据传输的目的类对象</param>
*/
    public PutDataToSysSocialRelationsClass(pobjSysSocialRelationsEN: clsSysSocialRelationsEN) {
        //pobjSysSocialRelationsEN.socialId = this.socialId;// 社会Id
        pobjSysSocialRelationsEN.fullName = this.fullName;// 姓名
        pobjSysSocialRelationsEN.nationality = this.nationality;// 国籍
        pobjSysSocialRelationsEN.levelId = this.levelId;// 级别Id
        pobjSysSocialRelationsEN.workUnit = this.workUnit;// 工作单位
        pobjSysSocialRelationsEN.major = this.major;// 专业
        pobjSysSocialRelationsEN.achievement = this.achievement;// 成就
        pobjSysSocialRelationsEN.detailedDescription = this.detailedDescription;// 详细说明
        pobjSysSocialRelationsEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改人
        pobjSysSocialRelationsEN.shareId = this.shareId;
        pobjSysSocialRelationsEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjSysSocialRelationsEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
        pobjSysSocialRelationsEN.isSubmit = this.isSubmit;// 是否提交
        pobjSysSocialRelationsEN.citationId = $("#hidRequestPaperId").val();// 引用论文
        
        pobjSysSocialRelationsEN.memo = this.memo;// 备注

        var strPdfPageNum = $("#hidPdfPageNum").val();
        if (strPdfPageNum != "") {
            pobjSysSocialRelationsEN.pdfPageNum = strPdfPageNum;
        }
        else {
            pobjSysSocialRelationsEN.pdfPageNum = 1;
        }
    }


    //概念提交审核
    public async btnIsSubmit_Click(strKeyId: string) {

        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        this.SubmitRecord(strKeyId);

    }
    //提交判断；
    public async SubmitRecord(strSocialId: string) {

        this.KeyId = strSocialId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysSocialRelations_GetObjBySocialIdAsync(strSocialId).then((jsonData) => {
                    var objSysSocialRelationsEN: clsSysSocialRelationsEN = <clsSysSocialRelationsEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage.GetSession_RoleId();

                    //判断角色 //学生00620003
                    if (strRoleId == "00620003") {
                        // //通过判断数据用户是否是当前登录用户；
                        if (objSysSocialRelationsEN.updUser == strUserId) {
                            //判断数据是否已审核
                            if (objSysSocialRelationsEN.isSubmit == false) {
                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {

                                });
                            }
                            else {
                                alert("当前数据已提交！");
                                return;
                            }
                        }
                        else {
                            alert("当前数据不是您所添加，不能提交！");
                            return;
                        }
                    }
                    else {
                        //可以提交
                        //判断数据是否已提交
                        if (objSysSocialRelationsEN.isSubmit == false) {
                            const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                            });
                        }
                        else {
                            alert("当前数据已提交！");
                            return;
                        }
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
    /* 修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public SubmitRecordSave(): Promise<boolean> {
        //this.DivName = "divUpdateRecordSave";
        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
        objSysSocialRelationsEN.socialId = this.KeyId;
        objSysSocialRelationsEN.isSubmit = true;
        objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                       // HideDialog();
                        this.BindGv_vSysSocialRelations();// BindGv_vSysSkill_Cache();
                    }
                    else {
                        var strInfo: string = `提交不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("提交失败");
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

    //取消提交
    public async btnCancelSubmit_Click(strKeyId: string) {
        var strUserId = $("#hidUserId").val();
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
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
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async CancelSubmitRecordSave(strKeyId: string) {
        //this.DivName = "divUpdateRecordSave";
        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
        objSysSocialRelationsEN.socialId = strKeyId;
        objSysSocialRelationsEN.isSubmit = false;
        objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
            throw "关键字不能为空!";
        }

        try {
            const responseText = SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    var strInfo: string = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);

                    //HideDialog();
                    this.BindGv_vSysSocialRelations();
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

  
    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
*/
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnOKUpd;
        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.OpType == "AddWithMaxId") {
                            const responseText3 = await this.AddNewRecordWithMaxIdSaveRetrunId().then((jsonData) => {
                                //CloseWindow();
                              
                                //var returnBool2: boolean = jsonData;
                                //if (returnBool2 == true) {
                                //    HideDialog();
                                //    this.BindGv_vSysSocialRelations();
                                //}
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    //HideDialog();
                                    this.BindGv_vSysSocialRelations();
                                }
                            });
                        }
                        //更新总表3个参数 主键、子表类型、页面操作类型；
                        
                        var strSocialId = $("#hidSocialId").val();
                        const responseText8 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSocialId, "10", "1", this.Id_CurrEduCls);
                        var returnBool8: boolean = !!responseText8;
                        if (returnBool8 == true) {
                            console.log("社会关系数据总表同步成功；");
                        }
                        else {
                            console.log("社会关系数据总表同步失败；");
                        }
                        //添加记录的同时添加历史版本
                        const responseText4 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                CloseWindow();
                                //alert("添加历史版本出问题！");
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In SysSocialRelationsCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                //HideDialog();
                                this.BindGv_vSysSocialRelations();
                            }
                        });
                        //更新总表3个参数 主键、子表类型、页面操作类型；

                        var strSocialId = $("#hidSocialId").val();
                        const responseText9 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSocialId, "10", "2", this.Id_CurrEduCls);
                        var returnBool9: boolean = !!responseText9;
                        if (returnBool9 == true) {
                            console.log("社会关系数据总表同步成功；");
                        }
                        else {
                            console.log("社会关系数据总表同步失败；");
                        }
                        //添加记录的同时添加历史版本
                        const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                CloseWindow();
                                //alert("添加历史版本出问题！");
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
            $("#divLoading").hide();

            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", false);
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }
    //添加历史版本
    public async AddVersionRecordSave() {
        //this.DivName = "divUpdateRecordSave";
        var strSocialId = $("#hidSocialId").val();
        var objSysSocialRelationsVEN: clsSysSocialRelationsVEN = new clsSysSocialRelationsVEN();

        objSysSocialRelationsVEN.socialId = strSocialId;
        this.PutDataToSysSocialRelationsVClass(objSysSocialRelationsVEN);

        try {
            const responseText2 = await SysSocialRelationsV_AddNewRecordAsync(objSysSocialRelationsVEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " 1 =1 and socialId=" + strSocialId;
                var intVersionCount = await SysSocialRelationsV_GetRecCountByCondAsync(strWhereCond2);


                var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
                objSysSocialRelationsEN.socialId = strSocialId;
                objSysSocialRelationsEN.versionCount = intVersionCount;


                objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                    throw "关键字不能为空!";
                }


                const responseText = SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        return true;
                    }
                    else {
                        var strInfo: string = `添加历史版本数不成功!`;
                        alert(strInfo);
                        console.log("添加历史版本数不成功");
                        CloseWindow();
                        return false;
                    }

                });
                return true;
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加版本记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }

    /* 为插入记录做准备工作
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        $('#btnOKUpd').attr("disabled", false);
        this.OpType = "AddWithMaxId";

        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucSysSocialRelationsB1.socialId = clsSysSocialRelationsBL.GetMaxStrId_S();
        try {
            const responseText = await SysSocialRelations_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表SysSocialRelations的最大关键字为空，不成功，请检查!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                $('#txtSocialId').val(returnString);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.SetKeyReadOnly(false);
        $('#btnOKUpd').attr("disabled", false);
        this.OpType = "AddWithMaxId";

        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucSysSocialRelationsB1.socialId = clsSysSocialRelationsBL.GetMaxStrId_S();
    }

    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
*/
    public async AddNewRecordWithMaxIdSaveRetrunId() {
        this.DivName = "divAddNewRecordWithMaxIdSave";
        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
        objSysSocialRelationsEN.createDate = clsPubFun4Web.getNowDate_ymd();
        this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
        try {
            const responseText = await SysSocialRelations_AddNewRecordWithReturnKeyAsync(objSysSocialRelationsEN);
            var strSocialId: string = responseText;
            if (strSocialId != "") {
            //var returnBool: boolean = !!responseText2;
            //if (returnBool == true) {

                $("#hidSocialId").val(strSocialId);

                //添加社会-主题 关系
                const responseText2 = await this.AddNewRecordSaveRtSysSocial();

                //var strInfo: string = `添加记录成功!`;
                //$('#lblResult47').val(strInfo);
                ////显示信息框
                //alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText;//一定要有一个返回值，否则会出错！
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
 <param name = "pobjRTSysSocialRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToRTSysSocialRelaClass(pobjRTSysSocialRelaEN: clsRTSysSocialRelaEN) {
        var strTopicId = $('#hidTopicId').val();
        var strSocialId = $("#hidSocialId").val();
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        pobjRTSysSocialRelaEN.id_CurrEduCls = $("#hidId_CurrEduCls").val();
        pobjRTSysSocialRelaEN.topicId = strTopicId;// 主题编号
        pobjRTSysSocialRelaEN.socialId = strSocialId;// 社会Id
        pobjRTSysSocialRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjRTSysSocialRelaEN.updUser = strUserId;// 修改人
        pobjRTSysSocialRelaEN.memo = this.memo;// 备注
        pobjRTSysSocialRelaEN.classificationId = "0000000000";// 分类为000000
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSaveRtSysSocial() {
        this.DivName = "divAddNewRecordSave";
        var strTopicId = $('#hidTopicId').val();
        var strSocialId = $("#hidSocialId").val();
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        var objRTSysSocialRelaEN: clsRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
        this.PutDataToRTSysSocialRelaClass(objRTSysSocialRelaEN);
        try {

            //同一用户，同一主题 同一社会关系 只能添加一次；
            //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And socialId = '" + strSocialId + "' And updUser = '" + strUserId + "'";
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And socialId = '" + strSocialId + "' And updUser = '" + strUserId + "'";
            const responseText = await RTSysSocialRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题同一个用户不能重复添加同一个社会关系！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            else {

                const responseText2 = await RTSysSocialRela_AddNewRecordAsync(objRTSysSocialRelaEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    var strInfo: string = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);

                    //根据ID获取最大数；
                    var strWhereCond2 = " 1 =1 and socialId=" + strSocialId;
                    var intCitationCount = await SysSocialRelations_GetRecCountByCondAsync(strWhereCond2);


                    var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
                    objSysSocialRelationsEN.socialId = strSocialId;
                    objSysSocialRelationsEN.citationCount = intCitationCount;

                    objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
                    if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                        throw "关键字不能为空!";
                    }

                    const responseText = await SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN).then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {


                        }
                        else {
                            var strInfo: string = `操作不成功!`;
                            alert(strInfo);
                            console.log("操作不成功");
                        }
                    });
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo: string = `添加记录不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
            }
            return responseText;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
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
    * 教学班ID
   */
    public set Id_CurrEduCls(value: string) {
        $("#hidId_CurrEduCls").val(value);
    }
    /*
    * 教学班
   */
    public get Id_CurrEduCls(): string {
        return $("#hidId_CurrEduCls").val();
    }
}